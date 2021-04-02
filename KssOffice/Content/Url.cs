using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace KssOffice
{
    public partial class Url : Form
    {
        public event UrlEventHandler UrlEvent;
        protected UrlEventArgs urlEventArgs = new UrlEventArgs();

        private delegate void DelegateRequestAddresses();
        private string historyList;
      //  private string  excelUrlAddresses;
        private AgileHtml agileHtml;
        private Thread threadRequestURL;
        private static Url urlInstance = null;
        
        public Url()
        {
            InitializeComponent();
            BindUrlGroup();
        }
        private void BindUrlGroup()
        {
            listUrlGroup .DataSource = AdvancedCell.GetUrlHistoryColumnName();
            if (listUrlGroup.Items.Count == 0)
                return;
            listUrlGroup.SelectedIndex = listUrlGroup.Items.Count - 1;
        }
        //主窗体任务栏，委托
        protected void OnUrlSelected()
        {
            if (UrlEvent != null)
            {
                urlEventArgs.UrlString = txtAddresses.Text;
                UrlEvent(this, urlEventArgs);
            }
        }
        //初始化
        private void InitializeIEHistory()
        {
            historyList = IEHistory.GetHistoryString(); 
        }

        //单件模式
        public static void GetInstance()
        {
            if (urlInstance == null)
            {
                urlInstance = new Url();
                urlInstance.StartPosition = FormStartPosition.CenterScreen;
                urlInstance.Show();
                return;
            }

            urlInstance.Activate();
        }
        //包起来
        private void GetAddresses()
        {
            if (agileHtml == null)
                agileHtml = new AgileHtml();

            agileHtml.RecurLocalUrl(txtRequestURL.Text);
        }
   
        public List<string> UrlAddresses
        {
            get
            {
                if (string.IsNullOrEmpty(txtAddresses.Text))
                    return null;

                List<string> urlList = new List<string>();
                urlList.AddRange(txtAddresses.Text.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));

                return urlList;
            }
        }

        private void btnHandle_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            statusBar.Start("正在读取数据请稍后...");

            switch (btn.Name)
            {
                case "btnRefresh":
                    BindUrlGroup();
                    break;
                case "btnHandle"://历史记录

                    if (!String.IsNullOrEmpty(historyList))
                    {
                        txtAddresses.Text = historyList;
                        break;
                    }
                    Thread threadInit = new Thread(InitializeIEHistory);
                    threadInit.Start();
                    while (true)
                    {
                        Application.DoEvents();
                        if (!threadInit.IsAlive)
                        {
                            urlEventArgs.Name = btnHandle.Text;
                            txtAddresses.Text = historyList;
                            break;
                        }
                    }
                    break;
                case "btnOK":
                    //回发事件到主窗体
                    OnUrlSelected(); 
                    break;
                case "btnGet":
                    threadRequestURL = new Thread(GetAddresses);
                    threadRequestURL.Start();

                    btnAbort.Visible = true;
                    btnGet.Enabled = false;
                    while (true)
                    {
                        if (agileHtml == null)
                            break;

                        Application.DoEvents();

                        if (agileHtml.AddressList != null)
                        {
                            string finishedLines = string.Format(Constant.BracketsAndInfo, "提取" + txtRequestURL.Text, "当前总共：" + agileHtml.AddressList.Count.ToString());
                            Text = finishedLines;
                            statusBar.Done(finishedLines);
                        }

                        if (!threadRequestURL.IsAlive)
                        {
                            MessageBox.Show("提取完毕：地址追加到excel中，完毕总共 " + agileHtml.AddressList.Count);
                            Text = "提取完毕:" + txtRequestURL.Text;

                            AdvancedCell.AddExtractedAddresses(agileHtml.AddressList, listUrlGroup.Items.Count);

                            //从新绑定  
                            BindUrlGroup();
                            btnAbort.Visible = false;
                            btnGet.Enabled = true;
                            break;
                        }
                    }
                    break;
                case "btnAbort":
                    if (threadRequestURL.IsAlive)
                    {
                        if (MessageBox.Show("是否要停止获取地址", "提取", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                        {
                            threadRequestURL.Abort();
                            if (agileHtml.AddressList.Count > 0)
                                agileHtml.AddressList[0] = "停止获取" + txtRequestURL.Text;
                            //从新绑定 
                            BindUrlGroup();
                        }
                    }
                    break;

            }
            statusBar.Done();
        }

       
        //关闭窗口释放
        private void Url_FormClosing(object sender, FormClosingEventArgs e)
        {
            urlInstance = null;

            if (threadRequestURL !=null)
                if (threadRequestURL.IsAlive)                          
                        threadRequestURL.Abort();
        }

        private void listUrlGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listUrlGroup.SelectedIndex < 0)
                return;
            urlEventArgs.Name = listUrlGroup.Text;
            txtAddresses.Text = AdvancedCell.GetUrlHistoryByColumnIndex(listUrlGroup.SelectedIndex);
        }

    }
}
