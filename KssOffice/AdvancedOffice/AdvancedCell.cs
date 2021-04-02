using System;
using System.Collections.Generic;
using System.Text;
using Aspose.Cells;
using System.Data;

namespace KssOffice
{
    public class AdvancedCell : Workbook
    {
        public AdvancedCell(string file)
            : base(file)
        {
        }

        public AdvancedCell()
        {

        }

        public static List<XPathInfo> GetXPathList()
        {
            Workbook wb = new Workbook(Constant.ExcelHtmlTag);
            Worksheet sheetXPath = wb.Worksheets["XPath"];

            List<XPathInfo> list = new List<XPathInfo>();
            for (int i = sheetXPath.Cells.Rows.Count - 1; i > 0; i--)
            {
                XPathInfo pi = new XPathInfo();
                pi.XPath = sheetXPath.Cells[i, 0].Value.ToString();
                pi.Name = sheetXPath.Cells[i, 1].Value.ToString();
                list.Add(pi);
            }
            return list;
        }

        public static   string  GetUrlAddressList()
        {
            Workbook wb = new Workbook(Constant.ExcelHtmlTag);
            Worksheet sheetXPath = wb.Worksheets["URL"];

        //    List<string> list = new List<string>();
            StringBuilder list = new StringBuilder();
            for (int i = sheetXPath.Cells.Rows.Count - 1; i > 0; i--)
            {
                if (sheetXPath.Cells[i, 0] == null)
                    continue;
                if (sheetXPath.Cells[i, 0].Value == null)
                    continue;
              //  list.Add(sheetXPath.Cells[i, 0].Value.ToString());
                list.Append(sheetXPath.Cells[i, 0].Value.ToString());
                list.Append("\r\n");
            }
            return list.ToString();

        }

        public static bool AddXPath(string xpath, string name)
        {
            Workbook wb = new Workbook(Constant.ExcelHtmlTag);
            Worksheet sheetXPath = wb.Worksheets["XPath"];

            Cell foundCell = sheetXPath.Cells.FindString(name, null);
            if (foundCell != null)
                return false;
            sheetXPath.Cells[sheetXPath.Cells.Rows.Count, 0].Value = xpath;
            sheetXPath.Cells[sheetXPath.Cells.Rows.Count - 1, 1].Value = name;
            wb.Save(Constant.ExcelHtmlTag);
            return true;

        }
        //批量添加提取后的地址
        public static void AddExtractedAddresses(List<string> addressList, int columnMax)
        {
            Workbook wb = new Workbook(Constant.ExcelHtmlTag);
            Worksheet sheetXPath = wb.Worksheets["URL"];
 
            int row = 0;
            foreach (string url in addressList)
            {
                if (url.Length > 225)
                    continue;
                sheetXPath.Cells[row++, columnMax].PutValue(url);
            } 
            wb.Save(Constant.ExcelHtmlTag);
        }

        //获取历史记录每一列的第一行,用于数据绑定
        public static List<string> GetUrlHistoryColumnName()
        {
            Workbook wb = new Workbook(Constant.ExcelHtmlTag);
            Worksheet sheetXPath = wb.Worksheets["URL"];
            //从新刷新
            wb.Save(Constant.ExcelHtmlTag);
            List<string> list = new List<string>();
            for (int i = 0; i < Constant.ExcelColumnCount; i++)
            {
                Cell cell = sheetXPath.Cells[0, i];
                if (cell == null)
                    return list;
                if (cell.Value == null)
                    return list;
                list.Add(cell.Value.ToString());
            }
            list.Reverse();
            return list;
        }


        //获取历史记录每一列的第一行,用于数据绑定
        public static string  GetUrlHistoryByColumnIndex(int index)
        {
            Workbook wb = new Workbook(Constant.ExcelHtmlTag);
            Worksheet sheetXPath = wb.Worksheets["URL"];
            StringBuilder addresses = new StringBuilder();
            for (int i = 1; i < sheetXPath.Cells.Rows.Count; i++)
            {
                Cell cell = sheetXPath.Cells[i, index];
                if (cell == null)
                    continue;
                if (cell.Value == null)
                    continue;
                if (string.IsNullOrEmpty(cell.Value.ToString().Trim()))
                    continue;
                addresses.Append(cell.Value.ToString()).Append("\r\n");
            }
            return addresses.ToString();
        }
    }
}
