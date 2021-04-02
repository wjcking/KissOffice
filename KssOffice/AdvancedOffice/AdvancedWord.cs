using System;
using System.Collections.Generic;
using System.Text;
using Aspose.Words;
using Aspose.Words.Tables;
using System.Data;

namespace KssOffice
{
    /// <summary>
    /// 继承aspose。words 获得所有表格
    /// </summary>
    public class AdvancedWord : Document
    {
        private const string HtmlTableTR = "<tr>{0}</tr>\r\n";
        private const string HtmlTableTD = "<td style=\"border:1px solid gray;\">{0}</td>\r\n";
        private const string HtmlTableHead = "<table>\r\n";
        private const string HtmlTableHeadEnd = "</table>\r\n";

        private DataSet tableSets;
        private StringBuilder tableHtml;
        public AdvancedWord(string file)   : base(file)
        {
       
            tableHtml = new StringBuilder();
            tableSets = new DataSet(GetType().Name);
             
        }

        /// <summary>
        /// 获得表格html
        /// </summary>
        /// <returns></returns>
        private string GetTableAndHtml()
        {
            //清空
            tableHtml.Remove(0, tableHtml.Length);
            tableSets.Tables.Clear();
           
            foreach (Section sec in Sections)
            {
                foreach (Table tab in sec.Body.Tables)
                {
                    if (tab.Rows.Count == 0)
                        break;

                    StringBuilder innerTable = new StringBuilder();
                    DataTable dt = new DataTable();
               
                    innerTable.Append(HtmlTableHead);
                    //添加列
                    int maxColumnCount = 0;
                    for (int i = 0; i < tab.Rows.Count; i++)
                    {
                        if (tab.Rows[i].Cells.Count > maxColumnCount)
                            maxColumnCount = tab.Rows[i].Cells.Count;
                    }
                    //列最大个数
                    for (int i=0;i< maxColumnCount;i++)
                       dt.Columns.Add("column" + i.ToString(), typeof(string));
                     
                    
                    foreach (Row row in tab.Rows)
                    {
                        //建立一行
                        DataRow dr = dt.NewRow();
                        StringBuilder td = new StringBuilder();

                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            string innerText = row.Cells[i].GetText().Replace("\a", String.Empty);
                            dr[i] = innerText;
                            td.AppendFormat(HtmlTableTD, innerText);
                        }
                        //添加row
                        dt.Rows.Add(dr);
                        innerTable.AppendFormat(HtmlTableTR, td);
                    }
                    dt.AcceptChanges();
                    tableSets.Tables.Add(dt);

                    innerTable.Append(HtmlTableHeadEnd);
                    tableHtml.Append(innerTable);
                }

            }
            return tableHtml.ToString();
        }

        public DataSet TableSets
        {
            get
            {

                if (tableSets.Tables.Count == 0)
                    GetTableAndHtml();

                return tableSets;
            }
        }
        public string TableHtml
        {
            get
            {
                if (tableHtml.Length <= 0)
                    GetTableAndHtml();

                return this.tableHtml.ToString();
            }
        }
    }
}

