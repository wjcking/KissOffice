using System;
using System.Collections.Generic;
using System.Text;
using Aspose.Words;
using System.Windows.Forms;
using System.Drawing;

namespace KssOffice
{
     public   class Constant
     {


         public const string Brackets = "[{0}]";
         public const string BracketsAndInfo = "[{0}]{1}";
         public const string DateFormat = "yyMdHms";
         public static string ExcelHtmlTag = "htmltag.xls";
         public static Dictionary<SaveFormat, string> ConvertFormat = null;
         public const string FileWordFilter = "word2003以上|*.docx | word97|*.doc";
         public const string FileHtmlFilter  = "超文本|*.htm|超文本|*.htm|超文本模板|*.mht";
         public const string ExtenText = ".txt";
         public const string ExtenPdf = ".pdf";
         public const string ExtenHtm = ".htm";
         public const string ExtenHtml = ".html";
         public const string ExtenMht= ".mht";
         public const string ExtenExcel97 = ".xls";
         public const string ExtenExcel2000 = ".xlsx";

         public const string ExtenWord97 =".doc";

         public const string ExtenWord2003 = ".docx";

         public readonly static Color ColorError = Color.Yellow; 
         public readonly static Color ColorStart = Color.Orange;
         public readonly static  Color ColorControl = Color.FromArgb(234, 234, 234);
         public const string HttpPrefix = "http://";
         public const string HttpsPrefix = "https://";


         public static int ExcelColumnCount = 256;
     }
}
