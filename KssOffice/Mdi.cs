using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace KssOffice
{
    [ComVisibleAttribute(true)]
    public partial class Mdi : Form
    {
        public readonly static WebBrowser webBrowser = new WebBrowser();
        private WordExporter wordExporter;
        // private PdfProcess pdfProcess;
        private HtmlExtractor htmlExtractor;
        private string postResult;

        public Mdi()
        {
            InitializeComponent();

            Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine();
            skin.SkinFile = Environment.CurrentDirectory + "\\skin.ssk";
            webBrowser.ScrollBarsEnabled = false;
            webBrowser.ObjectForScripting = this;
            webBrowser.Url = new Uri(Environment.CurrentDirectory + "\\Start.htm");
            webBrowser.Dock = DockStyle.Fill;
            container.Controls.Add(webBrowser);
      
        }

       private  void htmlExtractor_StatusBarResponse(object sender, StatusBarEventArgs e)
        {
            lbStatus.Text = e.Text;
            lbStatus.BackColor = e.BackgroundColor;
        }

       public void navigate(string id)
       {
           switch (id)
           {
               case "lnkWord":
               case "imgWord":
                   tsmMain_Click(tsmWordTable, null);
                   return;
               case "lnkHtml":
               case "imgHtml":
                   tsmMain_Click(tsmHtmlExtractor, null);
                   return;
           }
       }
     //javascript 调用发送留言
        public void postMessage(string userName, string message)
        {
            if (!string.IsNullOrEmpty(postResult))
            {
                MessageBox.Show("不能重复提交");
                return;
            }
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("请输入署名");
                return;
            }

            if (message.Length < 10)
            {
                MessageBox.Show("提交信息必须超过10个字符");
                return;
            }
            postResult = Network.PostMessage(userName, message);

            MessageBox.Show(postResult);
        }
        private void tsmMain_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsm = sender as ToolStripMenuItem;

            switch (tsm.Name)
            {
                case "tsmConvert":
                case "tsmWordTable":
                    container.Controls.Clear();
                    if (wordExporter == null)
                    {
                        wordExporter = new WordExporter();
                        wordExporter.StatusBarResponse += new StatusBarEventHandler(htmlExtractor_StatusBarResponse);
                    }
                    //选项转变
                    wordExporter.tabControl1.SelectedIndex = tsm.Name == "tsmConvert" ? 1 : 0;
                    wordExporter.Dock = DockStyle.Fill;
                    container.Controls.Add(wordExporter);
                    return;
                case "tsmPdf":
                    //container.Controls.Clear();
                    //if (pdfProcess == null)
                    //    pdfProcess = new PdfProcess();
                    //pdfProcess.Dock = DockStyle.Fill;
                    //container.Controls.Add(pdfProcess);
                    return;
                case "tsmHtmlExtractor":
                    container.Controls.Clear();
                    if (htmlExtractor == null)
                    {
                        htmlExtractor = new HtmlExtractor();
                        htmlExtractor.StatusBarResponse += new StatusBarEventHandler(htmlExtractor_StatusBarResponse);
                    }
                    htmlExtractor.Dock = DockStyle.Fill;
                    container.Controls.Add(htmlExtractor);
                    return;
                case "tsmStart":

                    container.Controls.Clear();
                    container.Controls.Add(webBrowser);
                    return;
                case "tsmWebsite":
                    Process.Start("http://www.easyfound.com.cn");
                    return;
                case "tsmOpenChm":
                    Process.Start("kssoffice.chm");
                    return;
            }
        }
    }
}
