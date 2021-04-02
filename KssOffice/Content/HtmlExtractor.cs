using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Threading;
using System.Drawing;


namespace KssOffice
{
    public partial class HtmlExtractor : KssControl
    {
        private readonly AdvBrowser webPreview;
        private delegate void invokeDelegate();
        private delegate void invokeWebRequest();
        private KssExport.Destination destination = KssExport.Destination.SingleExcelWithSheets;
        private List<string> extentionList;
        private List<XPathInfo> xpathList;
        private Url urlWnd = null;
        private DataSet tableSets;
        private string outputHtml;
        private KssExport kssExport;
        private List<string> addressList;
        public HtmlExtractor()
        {
            InitializeComponent();

            extentionList = new List<string>();
            extentionList.Add(Constant.ExtenHtm);
            extentionList.Add(Constant.ExtenHtml);
            extentionList.Add(Constant.ExtenMht);

            drpEncoding.SelectedIndex = 0;
            if (webPreview == null)
                webPreview = new AdvBrowser();
            webPreview.ScriptErrorsSuppressed = true;
            webPreview.Dock = DockStyle.Fill;

            tabPreview.Controls.Add(webPreview);
            BindXpath();
        }
        //url窗体事件接收 
        private void urlWnd_UrlEvent(object sender, UrlEventArgs e)
        {
            listURL.DataSource = e.UrlAddresses;
            addressList = e.UrlAddresses;
     //       boxUrl.Text = string.Format(Constant.Brackets, e.UrlAddresses.Count) + e.Name;
        }
        //线程调用提取所有
        private void ThreadExtract()
        {
            if (addressList == null)
                return;
            kssExport = new KssExport(addressList, txtXPath.Text, cbIsText.Checked, destination, cbExcel.Checked);
            kssExport.ExtractHtml();
        }

        //从htmltag.xls中获取xpath
        private void BindXpath()
        {
            listXPath.Items.Clear();
            xpathList = AdvancedCell.GetXPathList();

            foreach (XPathInfo xp in xpathList)
            {
                listXPath.Items.Add(xp.Display);
            }
        }

        /// <summary>
        /// UI线程获取文件夹
        /// </summary>
        private void StartMethod()
        {
            Invoke(new invokeDelegate(RecurFolder));
        }

        //递归获取文件
        private void RecurFolder()
        {
            try
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();

                if (dlg.ShowDialog() == DialogResult.Cancel)
                    return;

                Start("正在循环获取：" + dlg.SelectedPath);
                listURL.BindFilesByDirectory(dlg.SelectedPath, extentionList);
                Done("获取完毕");

            }
            catch (Exception e)
            {
                tabControl1.SelectedTab = tabPageOutput;
                txtOutput.AppendLine(e.Message);
            }
        }
        //获得html请求
        private void GetHtmlRequest(object param)
        {
            object[] o = param as object[];
            tableSets = AgileHtml.GetContentByXPath(o[0].ToString(), o[1].ToString(), Convert.ToBoolean(o[2]), out outputHtml);
        }

        private void Btn_Clicked(object sender, System.EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "btnURL":
                    urlWnd = new Url();
                    urlWnd.UrlEvent += new UrlEventHandler(urlWnd_UrlEvent);
                    urlWnd.Show();
                    return;
                case "btnFolder":
                    Thread invokeThread = new Thread(new ThreadStart(StartMethod));
                    invokeThread.Start();
                    while (true)
                    {
                        Application.DoEvents();
                        if (!invokeThread.IsAlive) {
                    addressList = listURL.FileList;
                            break; 
                        }
                    }
                    //线程调用
                    return;
                case "btnFile":
                    OpenFileDialog fdlg = new OpenFileDialog();
                    fdlg.RestoreDirectory = true;
                    fdlg.Filter = Constant.FileHtmlFilter;
                    if (fdlg.ShowDialog() == DialogResult.Cancel)
                        return;
                    listURL.DataSource = null;
                    listURL.Items.Add(fdlg.FileName);
                    //线程调用
                    if (addressList != null)
                    {
                        addressList.Clear();
                        addressList.Add(fdlg.FileName);
                    }
                    return;
                case "btnFastExtract":
                case "btnExport":
                    if (listURL.Items.Count == 0)
                        goto case "btnURL";
                    Thread threadExtract = new Thread(ThreadExtract);
                    threadExtract.Start();
                    while (true)
                    {
                        Application.DoEvents();
                        if (kssExport == null)
                            continue;

                        Start(kssExport.CurrentOutput);
                        if (!threadExtract.IsAlive)
                        {
                            Done();
                            break;
                        }
                    }

                    return;
                case "btnAdd":
                    try
                    {
                        AdvancedCell.AddXPath(txtXPath.Text, txtXPathName.Text);

                        Done("添加或刷新完毕");
                        BindXpath();
                    }
                    catch (Exception excelExp)
                    {
                        Error(excelExp.Message);
                    }
                    return;

            }
        }
        //解析后获得的表格
        private void listTables_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listTables.SelectedIndex < 0)
                return;

            tabControl1.SelectedTab = tabPageDataGrid;
            DataTableCollection tables = listTables.Source as DataTableCollection;
            dgList.DataSource = tables[listTables.SelectedIndex];

        }
        //解析单个地址，浏览
        private void listWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tabControl1.SelectedTab = tabPreview;
                if (!string.IsNullOrEmpty(listXPath.Text))
                    tabPreview.Text = listXPath.Text;

                listTables.Items.Clear();
                if (string.IsNullOrEmpty(listURL.Text))
                    return;
                Start("正在解析" + listURL.Text);

                Thread invokeThread = new Thread(new ParameterizedThreadStart(GetHtmlRequest));
                object[] param = new object[3];

                param[0] = listURL.Text;
                param[1] = txtXPath.Text;
                param[2] = cbIsText.Checked;
                invokeThread.Start(param);
                while (true)
                {
                    Application.DoEvents();
                    if (!string.IsNullOrEmpty(AgileHtml.Error))
                    {
                        Error(AgileHtml.Error);
                        webPreview.DocumentText = AgileHtml.Error;

                        txtOutput.AppendError("解析错误", AgileHtml.Error);
                        AgileHtml.Error = String.Empty;
                    }
                    if (!invokeThread.IsAlive)
                    {
                        webPreview.DocumentText = outputHtml;
                        txtOutput.Text = outputHtml;
                        if (tableSets != null)
                            listTables.Source = tableSets.Tables;
                        Done("解析完毕");
                        return;
                    }
                }
            }
            catch (Exception exp)
            {
                tabControl1.SelectedTab = tabPageOutput;

                Error(exp.Message);
            }
        }
        //选取导出方式
        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                int de = Convert.ToInt32(rb.AccessibleName);
                destination = (KssExport.Destination)de;
            }
        }
        //添加xpath到excel
        private void listXPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtXPath.Text = xpathList[listXPath.SelectedIndex].XPath;
            txtXPathName.Text = xpathList[listXPath.SelectedIndex].Name;
            tabPreview.Text = listXPath.Text;
            btnFastExtract.Text = "提取数据" + listXPath.Text;
        }

        //提取文本还是html
        private void cbIsText_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsText.Checked)
                btnExport.Text = "提取内容（纯文本）";
            else
                btnExport.Text = "提取内容（带有Html标签）";
            listWords_SelectedIndexChanged(sender, e);
        }

            //设置编码
        private void drpEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drpEncoding.SelectedIndex > 0)
                Configuration.ExtractEncode = Encoding.GetEncoding(drpEncoding.Text);
            else
                Configuration.ExtractEncode = null;
            listWords_SelectedIndexChanged(sender, e);
        }

        private void HtmlExtractor_Load(object sender, EventArgs e)
        {

        }

    }

}
