using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KssOffice
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //初始化

            Constant.ConvertFormat = new Dictionary<Aspose.Words.SaveFormat, string>();
    //        Constant.ConvertFormat.Add(Aspose.Words.SaveFormat.Rtf, ".rtf");
            Constant.ConvertFormat.Add(Aspose.Words.SaveFormat.Pdf, Constant.ExtenPdf);
            Constant.ConvertFormat.Add(Aspose.Words.SaveFormat.Swf, ".swf");
            Constant.ConvertFormat.Add(Aspose.Words.SaveFormat.Html, Constant.ExtenHtm);
            Constant.ConvertFormat.Add(Aspose.Words.SaveFormat.Mhtml, ".mht");
            Constant.ConvertFormat.Add(Aspose.Words.SaveFormat.Text, Constant.ExtenText);
            Constant.ConvertFormat.Add(Aspose.Words.SaveFormat.Jpeg, ".jpg");

            if (!System.IO.File.Exists(Constant.ExcelHtmlTag))
            {
                Constant.ExcelHtmlTag = "htmltag.xlsx";
                Constant.ExcelColumnCount = 16384;
            }

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Mdi());
        }
    }
}
