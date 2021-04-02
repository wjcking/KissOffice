using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Aspose.Cells;
using System.Data;
using System.Drawing;
using System.Diagnostics;

namespace KssOffice
{
    public class KssExport :KssOutput
    {
        
        private Destination destination;
        private Workbook singleExcel = null;
        private string versionExten = Constant.ExtenExcel97;
        private StringBuilder htmlTable = null;
        public static Dictionary<Destination, string> DestinationText = null;
        private string exportFolder;

        private string xpath;
        private bool isText;
        public enum Destination
        {
            SingleExcelWithSheets = 1,
            ExcelWithSheets = 2,
            ExcelWithOneSheets = 3,
            MutipleHtml = 4,
            SingleHtmlTotal = 5,
            SingleExcelWithOneSheet = 6,
        }
        private void Initialize()
        {if (DestinationText == null)
            {
                DestinationText = new Dictionary<Destination, string>();
                DestinationText.Add(Destination.SingleExcelWithSheets ,"单个Excel多个Sheets");
                DestinationText.Add(Destination.ExcelWithSheets, "多个Excel多个Sheets");
                DestinationText.Add(Destination.ExcelWithOneSheets, "多个Excel单个Sheet");
                DestinationText.Add(Destination.MutipleHtml,"多个html页面");
                DestinationText.Add(Destination.SingleHtmlTotal ,"单个html页面汇总");
                DestinationText.Add(Destination.SingleExcelWithOneSheet, "单个excel单个Sheet");
            }
        }

        /// <summary>
        /// word导出表格到excel
        /// </summary>
        /// <param name="addresses"></param>
        /// <param name="destination">导出到哪里</param>
        /// <param name="isXlsx">2000以上格式</param>
        public KssExport(List<string> addresses, Destination destination, bool isXlsx)
        {
            AddressList = addresses;
            this.destination = destination;
            if (isXlsx)
                versionExten = Constant.ExtenExcel2000;

            Initialize();
        }
      /// 网页导出表格到excel
        public KssExport(List<string> urlAddresses, string  xpath, bool isText, Destination destination, bool isXlsx)
        {
            AddressList = urlAddresses;
            this.destination = destination;
            this.xpath = xpath;
            this.isText = isText;
            if (isXlsx)
                versionExten = Constant.ExtenExcel2000;
            Initialize();
        }

        public void Export()
        {

            if (AddressList.Count == 0)
            {
                MessageBox.Show("列表中没有发现网页文档或网址", "");
                return;
            }
            //导出文件夹
            if (destination == Destination.SingleHtmlTotal || 
                destination == Destination.SingleExcelWithOneSheet ||
                destination == Destination.SingleExcelWithSheets)
                exportFolder = Configuration.WordTableFolder;
            else
                exportFolder = Configuration.WordTableFolder + DestinationText[destination] + "\\";

            if (!Directory.Exists(exportFolder))
                Directory.CreateDirectory(exportFolder);

            //导出单个excel
            if (Destination.SingleExcelWithSheets == destination || Destination.SingleExcelWithOneSheet == destination)
            {
                if (singleExcel == null)
                    singleExcel = new Workbook();

                singleExcel.Worksheets.Clear();
            }
            //初始化html汇总
            if (Destination.SingleHtmlTotal == destination)
            {
                if (htmlTable == null)
                    htmlTable = new StringBuilder();

                htmlTable.Remove(0, htmlTable.Length);
            }
            int id = 1;
            foreach (string fileName in AddressList)
            {
                try
                {
                    AdvancedWord aw = new AdvancedWord(fileName);

                    if (aw.TableSets.Tables.Count == 0)
                    {
                        AppendError("没有发现表格", fileName);
                        continue;
                    }
                    //循环调用
                    switch (destination)
                    {
                        case Destination.MutipleHtml:
                            ExportToMutipleHtml(aw.OriginalFileName,aw.TableHtml, id);
                            AppendFormatLine(Constant.BracketsAndInfo, id++, DestinationText[destination] + fileName);
                            continue;
                        case Destination.SingleHtmlTotal:
                            htmlTable.Append(String.Format("<p>{0}</p>", fileName));//哪个文档提取的
                            htmlTable.Append(aw.TableHtml);   
                            AppendFormatLine(Constant.BracketsAndInfo, id++, DestinationText[destination] + fileName);
                        
                            continue;
                        case Destination.ExcelWithSheets:
                            ExportToExcelWithSheets(aw.OriginalFileName,aw.TableSets, id);
                            AppendFormatLine(Constant.BracketsAndInfo, id++, DestinationText[destination] + fileName);
                            continue;
                        case Destination.ExcelWithOneSheets:
                            ExportToExcelWithOneSheet(aw.OriginalFileName, aw.TableSets, id);
                            AppendFormatLine(Constant.BracketsAndInfo, id++, DestinationText[destination] + fileName);
                            continue;
                        case Destination.SingleExcelWithSheets:
                            ExportToSingleExcelWithSheets(aw.OriginalFileName, aw.TableSets, id);
                            AppendFormatLine(Constant.BracketsAndInfo, id++, DestinationText[destination] + fileName);
                            continue;
                        case Destination.SingleExcelWithOneSheet:
                            ExportToSingleExcelWithOneSheet(aw.OriginalFileName, aw.TableSets, id);
                            AppendFormatLine(Constant.BracketsAndInfo, id++, DestinationText[destination] + fileName);
                            continue;
                    }
                    AppendLine(fileName);
                }
                catch (Exception e)
                {
                    AppendError(e.Message, fileName);
                }
            }
            if (Destination.SingleExcelWithSheets == destination || Destination.SingleExcelWithOneSheet == destination)
            {
                
                //导出到一个Excel文件多个Sheet页
                singleExcel.Save(exportFolder + DestinationText[destination]+ versionExten);
            }
            //汇总到单个html
            if (Destination.SingleHtmlTotal == destination)
            {
                CreateFiles(exportFolder + DestinationText[destination] + Constant.ExtenHtm, htmlTable.ToString());
            }
            AppendLine("导出文件夹：" + exportFolder);
            AppendLine("导出方法：" + DestinationText[destination]);
 
            MessageBox.Show("执行完毕" + string.Format(Constant.Brackets, id));
            Process.Start(exportFolder);
        }


        public void ExtractHtml()
        {
            if (AddressList.Count == 0)
            {
                MessageBox.Show("列表中没有发现网页文档", "");
                return;
            }
            //导出文件夹
            if (destination == Destination.SingleHtmlTotal ||
                destination == Destination.SingleExcelWithOneSheet ||
                destination == Destination.SingleExcelWithSheets)
                exportFolder = Configuration.AgileHtmlFolder;
            else
                exportFolder = Configuration.AgileHtmlFolder + DestinationText[destination] + "\\";

            if (!Directory.Exists(exportFolder))
                Directory.CreateDirectory(exportFolder);

            //导出单个excel
            if (Destination.SingleExcelWithSheets == destination || Destination.SingleExcelWithOneSheet == destination)
            {
                if (singleExcel == null)
                    singleExcel = new Workbook();

                singleExcel.Worksheets.Clear();
            }
            //初始化html汇总
            if (Destination.SingleHtmlTotal == destination)
            {
                if (htmlTable == null)
                    htmlTable = new StringBuilder();

                htmlTable.Remove(0, htmlTable.Length);
            }
            int id = 1;
            foreach (string fileName in AddressList)
            {
 
                try
                {
                    string extractHtml;
                    DataSet ds = AgileHtml.GetContentByXPath(fileName, xpath, isText,  out extractHtml);

                    if (ds == null)
                    {
                        AppendError("未能找到数据", fileName);
                        continue;
                    }
                    if (ds.Tables.Count == 0)
                    {
                        AppendError("没有发现表格", fileName);
                        continue;
                    }
                    //循环调用
                    switch (destination)
                    {
                        case Destination.MutipleHtml:
                            
                            ExportToMutipleHtml(fileName, extractHtml, id);
                            AppendFormat(Constant.BracketsAndInfo, id++, DestinationText[destination] + fileName);
                            continue;
                        case Destination.SingleHtmlTotal:
                            htmlTable.Append(String.Format("<p>{0}</p>", fileName));//哪个文档提取的
                            htmlTable.Append(extractHtml);
                            AppendFormat(Constant.BracketsAndInfo, id++, DestinationText[destination] + fileName);

                            continue;
                        case Destination.ExcelWithSheets:
                            ExportToExcelWithSheets(fileName, ds, id);
                            AppendFormat(Constant.BracketsAndInfo, id++, DestinationText[destination] + fileName);
                            continue;
                        case Destination.ExcelWithOneSheets:
                            ExportToExcelWithOneSheet(fileName, ds, id);
                            AppendFormat(Constant.BracketsAndInfo, id++, DestinationText[destination] + fileName);
                            continue;
                        case Destination.SingleExcelWithSheets:
                            ExportToSingleExcelWithSheets(fileName, ds, id);
                            AppendFormat(Constant.BracketsAndInfo, id++, DestinationText[destination] + fileName);
                            continue;
                        case Destination.SingleExcelWithOneSheet:
                            ExportToSingleExcelWithOneSheet(fileName, ds, id);
                            AppendFormat(Constant.BracketsAndInfo, id++, DestinationText[destination] + fileName);
                            continue;
                    }
                    CurrentOutput = (fileName);
                }
                catch (Exception e)
                {
                    AppendError("出现错误"+fileName,e.Message);
                }
            }
            if (Destination.SingleExcelWithSheets == destination || Destination.SingleExcelWithOneSheet == destination)
            {
                //导出到一个Excel文件多个Sheet页
                singleExcel.Save(exportFolder + DestinationText[destination] + versionExten);
            }
            //汇总到单个html
            if (Destination.SingleHtmlTotal == destination)
            {
                CreateFiles(exportFolder + DestinationText[destination] + Constant.ExtenHtm, htmlTable.ToString());
            }
          CurrentOutput = "导出文件夹：" + exportFolder +" 导出方法：" + DestinationText[destination];

            MessageBox.Show("执行完毕" + string.Format(Constant.Brackets, id));
            Process.Start(exportFolder);
        }
        //多个html
        private void ExportToMutipleHtml(string fileName, string html , int id)
        {
             
            string file = Path.GetFileNameWithoutExtension(fileName);
            string htmFileName = exportFolder + string.Format(Constant.Brackets, id) + file + Constant.ExtenHtm;

            CreateFiles(htmFileName, html);

        }
        //多个excel多个sheets
        private void ExportToExcelWithSheets(string fileName, DataSet ds, int id)
        {
            Workbook excel = new Workbook();

            int index = 0;
            foreach (DataTable dt in ds.Tables)
            {
                if (index == 0)
                {
                    excel.Worksheets[0].Cells.ImportDataTable(dt, false, "A1");
                }
                else
                {
                    excel.Worksheets.Add(dt.TableName);
                    excel.Worksheets[dt.TableName].Cells.ImportDataTable(dt, false, "A1");
                }
                index++;
            }
            string file = Path.GetFileNameWithoutExtension(fileName);
            string excelFileName = exportFolder + string.Format(Constant.Brackets, id) + file + versionExten;
            excel.Save(excelFileName);

        }
        //多个文件一个sheet
        private void ExportToExcelWithOneSheet(
            string fileName, DataSet ds, int id)
        { 
            Workbook excel = new Workbook();

            foreach (DataTable dt in ds.Tables)
            {
                excel.Worksheets[0].Cells.ImportDataTable(dt, false, excel.Worksheets[0].Cells.Rows.Count, 0, true);
            }
            string file = Path.GetFileNameWithoutExtension(fileName);
            string excelFileName = exportFolder  + string.Format(Constant.Brackets, id) + file + versionExten;
            excel.Save(excelFileName);

        }
        //单个文件多个sheets
        private void ExportToSingleExcelWithSheets(string fileName, DataSet ds, int id)
        {

            string file = Path.GetFileNameWithoutExtension(fileName);
            string sheetName = file + id;
            singleExcel.Worksheets.Add(sheetName);
            //     singleExcel.Worksheets[sheetName].Cells[0, 0].Value = aw.OriginalFileName;
            Style style = new Style();
            style.BackgroundColor = Color.Yellow;

            foreach (DataTable dt in ds.Tables)
            {

                //Style style = singleExcel.Styles["yellow"];

                int rowCount = singleExcel.Worksheets[sheetName].Cells.Rows.Count;

                singleExcel.Worksheets[sheetName].Cells[rowCount, 0].SetStyle(style);
                singleExcel.Worksheets[sheetName].Cells.ImportDataTable(dt, false, rowCount, 0, true);

            }
        }
        //单个文件一个sheet
        private void ExportToSingleExcelWithOneSheet(string fileName, DataSet ds, int id)
        {
            if (singleExcel.Worksheets.Count == 0)
            {
                singleExcel.Worksheets.Add("Sheet1");
       //         int styleIndex = singleExcel.Styles.Add();
            }
            foreach (DataTable dt in ds.Tables)
            {
                singleExcel.Worksheets[0].Cells.ImportDataTable(dt, false, singleExcel.Worksheets[0].Cells.Rows.Count, 0, true);
            }
            singleExcel.Worksheets[0].Cells.InsertRow(singleExcel.Worksheets[0].Cells.Rows.Count);
            int padWidth = fileName.Length + 10;
            string spliter = fileName.PadLeft(padWidth, '《');
            singleExcel.Worksheets[0].Cells[singleExcel.Worksheets[0].Cells.Rows.Count, 0].PutValue(spliter.PadRight(spliter.Length + 10, '》'));
            singleExcel.Worksheets[0].Cells.InsertRow(singleExcel.Worksheets[0].Cells.Rows.Count);
        } 

        private static void CreateFiles(string fileName, string text)
        {
            if (!File.Exists(fileName))
            {
                FileStream fs1 = new FileStream(fileName, FileMode.Create, FileAccess.Write);//创建写入文件          
                StreamWriter sw = new StreamWriter(fs1, Encoding.Default);

                sw.WriteLine(text);
                sw.Close();
                fs1.Close();
            }
            else
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs, Encoding.Default);
                sr.WriteLine(text);
                sr.Close();
                fs.Close();
            }
        }
    }
}
