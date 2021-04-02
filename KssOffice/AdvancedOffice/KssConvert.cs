using System;
using Aspose.Words;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;

namespace KssOffice
{
    public class KssConvert : KssOutput
    {

        private SaveFormat convertFormat;

        public KssConvert(List<string> addresses,SaveFormat format)
        {
            AddressList = addresses;
            convertFormat = format;
        }

        public void Convert()
        {
            string convertedFolder = Configuration.WordConvertFolder + convertFormat.ToString() + "\\";
            if (!Directory.Exists(convertedFolder))
                Directory.CreateDirectory(convertedFolder);

            int id = 1;
            foreach (string fileName in  AddressList)
            {
                try
                {
                    string file = Path.GetFileNameWithoutExtension(fileName);
                    string convertFileName = convertedFolder + string.Format(Constant.Brackets, id) + file + Constant.ConvertFormat[convertFormat];
                    Document doc = new Document(fileName);
       
                    doc.Save(convertFileName, convertFormat);
                    
                    string outInfo = string.Format( Constant.Brackets, id++);
                    CurrentOutput = ("正在转换："+outInfo + convertFileName);
                }
                catch (Exception e)
                {
                    AppendError(e.Message, fileName);
                }

            }
            CurrentOutput = "导出文件夹：" + convertedFolder ;
             

            Process.Start(convertedFolder);
        }
    }
}
