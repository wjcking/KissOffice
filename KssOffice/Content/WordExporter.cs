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
    public partial class WordExporter : KssControl
    {

        private delegate void invokeDelegate();
        private AdvancedWord advWord;
        private KssExport.Destination destination = KssExport.Destination.SingleExcelWithSheets;
        private List<string> extentionList;
        private KssExport kssExport;
        private KssConvert  kssConvert;
        public WordExporter()
        {
            InitializeComponent();
            flowContainer1.BindConvertType();
            flowContainer1.SaveFormatClick += new SaveFormatEventHandler(flowContainer1_SaveFormatClick);

            extentionList = new List<string>();
            extentionList.Add(Constant.ExtenWord97);
            extentionList.Add(Constant.ExtenWord2003);

        }

        //类型转换按钮
        private void flowContainer1_SaveFormatClick(object sender, SaveFormatEventArgs e)
        {
            if (listWord.Items.Count == 0)
            {
                Btn_Clicked(btnFolder, null);
                return;
            }
             
            Thread threadConvert = new Thread(new ParameterizedThreadStart(ThreadConvert));
            threadConvert.Start(e);
            while (true)
            {
                if (kssConvert == null)
                    continue;
                Start(kssConvert.CurrentOutput);
                Application.DoEvents();
                if (!threadConvert.IsAlive)
                {
                    Done();
                    break;
                }
            }
        }
        private void StartMethod()
        {
            Invoke(new invokeDelegate(RecurFolder));
        }
        private void ThreadExport()
        {
            kssExport = new KssExport(listWord.FileList, destination, cbExcel.Checked);
            kssExport.Export();
        }
        private void ThreadConvert(object e)
        {
            SaveFormatEventArgs args = e as SaveFormatEventArgs;
              kssConvert = new KssConvert(listWord.FileList, args.SelectedFormat);
            kssConvert.Convert();

        }
        private void Btn_Clicked(object sender, System.EventArgs e)
        {
            Button btn = sender as Button;

            //   tabPageOutput.ForeColor = Color.Black;
            switch (btn.Name)
            {
                case "btnConvertPdf":
                    if (listWord.Items.Count == 0)
                        goto case "btnFolder";

                    SaveFormatEventArgs saveFormat = new SaveFormatEventArgs();
                    saveFormat.SelectedFormat = Aspose.Words.SaveFormat.Pdf;
                    flowContainer1_SaveFormatClick(sender, saveFormat);
                    return;
                case "btnFolder":
                    Thread invokeThread = new Thread(new ThreadStart(StartMethod));
                    invokeThread.Start();

                    while (true)
                    {
                        Application.DoEvents();
                        if (!invokeThread.IsAlive)
                            break;
                    }
                    return;
                case "btnFile":
                    OpenFileDialog fdlg = new OpenFileDialog();
                    fdlg.RestoreDirectory = true;
                    fdlg.Filter = Constant.FileWordFilter;
                    if (fdlg.ShowDialog() == DialogResult.Cancel)
                        return;
                    listWord.DataSource = null;

                    listWord.Items.Add(fdlg.FileName);
                    advWord = new AdvancedWord(fdlg.FileName);
                    listTables.Source = advWord.TableSets.Tables;
                    return;
                case "btnFastExport":
                case "btnExport":
                    if (listWord.Items.Count == 0)
                        goto case "btnFolder";
               
                    Thread threadExport = new Thread(ThreadExport);
                    threadExport.Start();

                    while (true)
                    {
                        if (kssExport == null)
                            continue;
                        Application.DoEvents();
                        Start(kssExport.CurrentOutput);
                      //  txtOutput.AppendLine(kssExport.CurrentOutput);
                        if (!threadExport.IsAlive)
                        {

                            Done();
                            break;
                        }
                    }
                    return;
            }
        }
  
        private void RecurFolder()
        {
            try
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();

                if (dlg.ShowDialog() == DialogResult.Cancel)
                    return;
                Start("正在循环获取：" + dlg.SelectedPath);
                listWord.BindFilesByDirectory(dlg.SelectedPath, extentionList);

                Done("获取完毕");
            }
            catch (Exception e)
            {
                Error(e.Message);
            }
        }

        private void listTables_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listTables.SelectedIndex < 0)
                return;
            if (advWord.TableSets.Tables.Count == 0)
                return;

            tabControl1.SelectedTab = tabPageDataGrid;
            dgList.DataSource = advWord.TableSets.Tables[listTables.SelectedIndex];
        }

        private void listWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listTables.Items.Clear();
                if (string.IsNullOrEmpty(listWord.Text))
                {
                    //  txtOutput.AppendLine("文件夹中没有发现word文档");
                    return;
                }
                advWord = new AdvancedWord(listWord.Text);
                if (advWord.TableSets.Tables.Count == 0)
                {
                    Done(listWord.Text + "文件中没有发现word表格");
                    return;
                }
                tabControl1.SelectedTab = tabPageDataGrid;
                listTables.Source = advWord.TableSets.Tables;

            }
            catch (Exception exp)
            {
              Error(exp.Message);
            }
        }

        private void Radio_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                int de = Convert.ToInt32(rb.AccessibleName);
                destination = (KssExport.Destination)de;
            }
        }

    }

}
