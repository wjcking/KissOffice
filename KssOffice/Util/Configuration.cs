using System;
using System.Collections.Generic;
using System.Text;

namespace KssOffice
{
    public class Configuration
    {
        public readonly static string DesktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
        public readonly static string WordTableFolder = DesktopFolder + "[金速]Word表格导出\\";
        public readonly static string WordConvertFolder = DesktopFolder + "[金速]Word转换\\";
        public readonly static string AgileHtmlFolder = DesktopFolder + "[金速]网页数据提取\\";
        public readonly static ConfigXml ConfigString = new ConfigXml("settings.xml");
        //可变，根据下拉菜单
        public static Encoding ExtractEncode = null;
    }



}
