using System;
using System.Collections.Generic;
using System.Text;
using Aspose.Pdf;
using System.IO;
namespace KssOffice
{
    public class AdvancedPdf : Pdf
    {
       //private string fileName;

        private AdvancedPdf(FileStream pdfStream)
            : base(pdfStream)
        {
       
        }

        //public string FileName
        //{
        //    get { return fileName; }
        //}
        public static AdvancedPdf GetInstance(string fileName)
        {
            FileStream fs1 = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
            AdvancedPdf doc = new AdvancedPdf(fs1);
            fs1.Close();

            return doc;
        }
        public string GetBasicInfo()
        {
            StringBuilder basicInfo = new StringBuilder();
      //      basicInfo.Append("文件：").AppendLine(fileName);
            if (!string.IsNullOrEmpty(base.Author))
                basicInfo.Append("作者：").AppendLine(base.Author);
            if (!string.IsNullOrEmpty(base.Creator))
                basicInfo.Append(" 创建人：").Append(base.Creator);
            if (!string.IsNullOrEmpty(base.Producer))
                basicInfo.Append(" 生产者：").Append(base.Producer);
            if (!string.IsNullOrEmpty(base.Keywords))
                basicInfo.Append(" 关键字：").Append(base.Keywords);

            basicInfo.Append(" 默认字体：").Append(base.DefaultFontName);
            if (base.IsBookmarked)
                basicInfo.Append("有水印");
            if (base.IsLandscape)
                basicInfo.Append("纵向显示");

            if (!string.IsNullOrEmpty(base.Subject))
                basicInfo.Append(" 主题：").Append(base.Subject);
            if (!string.IsNullOrEmpty(base.Title))
                basicInfo.Append(" 标题：").Append(base.Title);

            basicInfo.Append(" 页数：").Append(base.Sections.Count);

            return basicInfo.ToString();
        }
    }
}
