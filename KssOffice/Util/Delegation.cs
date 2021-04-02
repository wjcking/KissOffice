using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace KssOffice
{

    public delegate void SaveFormatEventHandler(object sender, SaveFormatEventArgs e);
    public delegate void StatusBarEventHandler(object sender, StatusBarEventArgs e);
    public delegate void UrlEventHandler(object sender, UrlEventArgs e);

    /// <summary>
    /// 格式转换选择代理【用于flowcontainer按钮发送到主窗体】
    /// </summary>
    public class SaveFormatEventArgs : EventArgs //事件参数类
    {
        private Aspose.Words.SaveFormat selectedFormat;

        public Aspose.Words.SaveFormat SelectedFormat
        {
            get { return selectedFormat; }
            set { selectedFormat = value; }
        }
    }

    //状态栏事件参数
    public class StatusBarEventArgs : EventArgs,IStatus
    {
        public string Text { get; set; }
        public Color BackgroundColor { get; set; }
        public Color ForeColor { get; set; }


        public void Done()
        {
            Text = "就绪";
            BackgroundColor = Constant.ColorControl;
        }
        public void Done(string doneString)
        {
           BackgroundColor = Constant.ColorControl;
            Text = doneString;
        }

        public void Error(string error)
        {
            BackgroundColor = Constant.ColorError; 
            Text = error;
        }
        public void Start(string text)
        {
            Text = text;
            BackgroundColor = Constant.ColorStart; ;
        }

       
    }
    //地址提取事件参数
    public class UrlEventArgs : EventArgs
    {
        public string Name { get; set; }
        public string UrlString { get; set; }
        public List<string> UrlAddresses
        {
            get
            {
                if (string.IsNullOrEmpty(UrlString))
                    return null;

                List<string> urlList = new List<string>();
                urlList.AddRange(UrlString.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));

                return urlList;
            }
        }
    }
}
