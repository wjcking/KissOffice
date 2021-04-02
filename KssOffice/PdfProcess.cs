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
    public partial class PdfProcess : UserControl
    {
         
        private delegate void invokeDelegate();    
        private AdvancedPdf advPdf;
        private KssExport.Destination destination = KssExport.Destination.ExcelWithSheets;
        private List<string> extentionList;
        public PdfProcess()
        {
            InitializeComponent();
            flowContainer1.BindConvertType();
            flowContainer1.SaveFormatClick += new SaveFormatEventHandler(flowContainer1_SaveFormatClick);

            extentionList = new List<string>();
            extentionList.Add(Constant.ExtenPdf);

        }


        private void flowContainer1_SaveFormatClick(object sender, SaveFormatEventArgs e)
        {
            tabControl1.SelectedTab = tabPageOutput;

            KssConvert kssConvert = new KssConvert(txtOutput, listFiles, e.SelectedFormat);
            kssConvert.Convert();
        }  
        private void StartMethod()
        { 
            Invoke(new invokeDelegate(RecurFolder)); 
        }
 
        private void Btn_Clicked(object sender, System.EventArgs e)
        {
            Button btn = sender as Button;

         //   tabPageOutput.ForeColor = Color.Black;
            switch (btn.Name)
            {
                case "btnFolder":
              //      tabPageOutput.ForeColor = Color.Red;
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
                    listFiles.DataSource = null;
                    listFiles.Items.Add(fdlg.FileName); 
                
                    return;
                case "btnExport":
                    tabControl1.SelectedTab = tabPageOutput;
            
                    KssExport kssExport = new KssExport(txtOutput,listFiles, destination, cbExcel.Checked );
                    kssExport.Export();
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

                txtOutput.AppendLine("正在循环获取" + dlg.SelectedPath);
                listFiles.BindFilesByDirectory(dlg.SelectedPath, extentionList);
                txtOutput.AppendLine("获取完毕" );
            }
            catch (Exception e)
            {
                tabControl1.SelectedTab = tabPageOutput;
                txtOutput.AppendLine(e.Message);
            }
        }

        private void listTables_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
            tabControl1.SelectedTab = tabPageDataGrid; 
        }

        private void listWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
             
                if (string.IsNullOrEmpty(listFiles.Text))
                {
                  //  txtOutput.AppendLine("文件夹中没有发现word文档");
                    return;
                }
                advPdf = AdvancedPdf.GetInstance(listFiles.Text);

                txtOutput.AppendLine(advPdf.GetBasicInfo());

        

            }
            catch (Exception exp)
            {
                tabControl1.SelectedTab = tabPageOutput;
                txtOutput.AppendLine(exp.Message);
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
