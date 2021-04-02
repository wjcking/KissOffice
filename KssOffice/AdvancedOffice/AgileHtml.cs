using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;
using System.IO;
using System.Net;
using System.Data;


namespace KssOffice
{
    public class AgileHtml : KssOutput
    { 
        private string domain;

         public AgileHtml()
        {

        }

        //主域名
        public string Domain
        {
            get { return domain; }
        }
       
        //错误，线程调用
        public static string Error { get; set; }
    
        /// <summary>
        /// 获得一个网页的主节点，多个函数调用
        /// </summary> 
        private static HtmlNode GetRootNode(string url)
        {
            HtmlDocument document = new HtmlDocument();
            bool isUrl = false;


            if (url.IndexOf(Constant.HttpPrefix) > -1 || url.IndexOf(Constant.HttpsPrefix) > -1)
                isUrl = true;

            if (isUrl)
            {
                string html = GetContentByUrl(url);
                document.LoadHtml(html);
                //Stream stream =GetStreamByUrl(url);
                //if (stream == null)
                //    return null;

                //document.Load(stream, true);
            }
            else
            {
                if (!File.Exists(url))
                    Error = "没有找到该文件或者不是文件类型";

                try
                {
              //      document.Load(url, true);
                    if (Configuration.ExtractEncode == null)
                        document.Load(url, Encoding.Default);
                    else
                        document.Load(url, Configuration.ExtractEncode);
                }
                catch (Exception e)
                {
                    Error = e.Message + url;
                }
            }
            HtmlNode rootNode = document.DocumentNode;
            return rootNode;
        }
        public static DataSet GetContentByXPath(string url, string xpath, bool isText, out string extractHtml)
        {
            HtmlNode rootNode = GetRootNode(url);
            if (rootNode == null)
            {
                extractHtml = "没有返回URL stream";
                return null;
            }
            HtmlNodeCollection nodeList = rootNode.SelectNodes(xpath);

            if (nodeList == null)
            {
                extractHtml = "没有找到该节点";
                return null;
            }
            StringBuilder nodeString = new StringBuilder();

            foreach (HtmlNode node in nodeList)
            {

                if (isText)
                    nodeString.Append(node.InnerText);
                else
                    nodeString.Append(node.OuterHtml);

                nodeString.Append("<br/>\r\n");
            }
            extractHtml = nodeString.ToString();

            DataSet tableSets = GetDateTableByNodeType(nodeList, isText);

            return tableSets;
        }

        private static DataSet GetDateTableByNodeType(HtmlNodeCollection nodeList, bool isText)
        {

            DataSet ds = new DataSet();
            string nodeType = nodeList[0].Name.ToLower();
            switch (nodeType)
            {
                case "ul":
                    foreach (HtmlNode node in nodeList)
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("[ul]无序列表", typeof(string));
                        HtmlNodeCollection innerNode = node.SelectNodes("li");

                        if (innerNode == null)
                            continue;

                        foreach (HtmlNode inner in innerNode)
                        {          //建立一行
                            DataRow dr = dt.NewRow();
                            dr[0] = isText ? inner.InnerText : inner.OuterHtml;
                            dt.Rows.Add(dr);
                        }
                        dt.AcceptChanges();
                        ds.Tables.Add(dt);

                    }
                    break;
                case "table":
                    foreach (HtmlNode node in nodeList)
                    {
                        DataTable dt = new DataTable();
                        HtmlNodeCollection trNode = node.SelectNodes("tr");
                        int maxColumnCount = 0;

                        if (trNode == null)
                            trNode = node.SelectNodes("tbody/tr");

                        if (trNode == null)
                            continue;
                        //获得每个表列的最大值
                        if (maxColumnCount == 0)
                        {
                            foreach (HtmlNode tr in trNode)
                            {
                                HtmlNodeCollection tdNode = tr.SelectNodes("td");

                                if (tdNode == null)
                                    continue;
                                if (tdNode.Count > maxColumnCount)
                                    maxColumnCount = tdNode.Count;

                            }
                        }
                        //最大列数
                        for (int i = 0; i < maxColumnCount; i++)
                            dt.Columns.Add("列" + i.ToString(), typeof(string));
                        foreach (HtmlNode tr in trNode)
                        {
                            HtmlNodeCollection tdNode = tr.SelectNodes("td");
                            if (tdNode == null)
                                continue;
                            //建立一行
                            DataRow dr = dt.NewRow();
                            for (int i = 0; i < tdNode.Count; i++)
                            {
                                HtmlNode td = tdNode[i];
                                dr[i] = isText ? td.InnerText : td.InnerHtml;
                            }
                            dt.Rows.Add(dr);

                        }
                        dt.AcceptChanges();
                        ds.Tables.Add(dt);

                    }
                    break;
                default:
                    DataTable singleTable = new DataTable();
                    singleTable.Columns.Add(String.Format(Constant.BracketsAndInfo, nodeType, "单个元素"), typeof(string));

                    foreach (HtmlNode node in nodeList)
                    {
                        if (node.InnerText.Trim() == "")
                            continue;
                        //建立一行
                        DataRow dr = singleTable.NewRow();
                        dr[0] = isText ? node.InnerText : node.OuterHtml;
                        singleTable.Rows.Add(dr);
                    }

                    singleTable.AcceptChanges();
                    ds.Tables.Add(singleTable);
                    break;
            }

            return ds;
        }

        //获取网页，并编码
        private static string GetContentByUrl(string url)
        {
            string result = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                //声明一个HttpWebRequest请求  
                request.Timeout = 30000;
                request.Proxy = null;
                //设置连接超时时间  
                request.Headers.Set("Pragma", "no-cache");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string contentType = response.ContentType;
                string status = response.StatusCode.ToString();
                Encoding encoding = Encoding.Default;

                if (response.StatusDescription.ToUpper() == "OK")        //大写
                {
                    //设置获取链接中网页的编码格式
                    switch (response.CharacterSet.ToLower())           //小写
                    {
                        case "gbk":
                            encoding = Encoding.GetEncoding("GBK");
                            break;
                        case "gb2312":
                            encoding = Encoding.GetEncoding("GB2312");
                            break;
                        case "utf-8":
                            encoding = Encoding.UTF8;
                            break;
                        case "iso-8859-1":
                            encoding = Encoding.GetEncoding("GBK");    //GB2312              
                            break;
                        case "big5":
                            encoding = Encoding.GetEncoding("Big5");
                            break;
                        default:
                            encoding = Encoding.UTF8;
                            break;
                    }

                }

                Stream responseStream = null;
                if ("gzip".Equals(response.ContentEncoding))
                {
                    responseStream = new System.IO.Compression.GZipStream(response.GetResponseStream(), System.IO.Compression.CompressionMode.Decompress);
                }
                else if ("deflate".Equals(response.ContentEncoding))
                {
                    responseStream = new System.IO.Compression.DeflateStream(response.GetResponseStream(), System.IO.Compression.CompressionMode.Decompress);
                }
                else
                {
                    responseStream = response.GetResponseStream();
                }
                if (responseStream != null)
                {
                    //编码如果不为空则选用下啦菜单
                    StreamReader streamReader = new StreamReader(responseStream, Configuration.ExtractEncode ==null? encoding:Configuration.ExtractEncode);
                    result = streamReader.ReadToEnd().Trim();

                    streamReader.Close();
                }
            }
            catch (Exception e)
            {
                result = e.Message;
                //   throw;
            }
            return result;

        }

        //获取流，并编码
        private static Stream GetStreamByUrl(string url)
        {

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                //声明一个HttpWebRequest请求  
                request.Timeout = 30000;
                request.Proxy = null;
                //设置连接超时时间  
                request.Headers.Set("Pragma", "no-cache");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                 
                string contentType = response.ContentType;
                string status = response.StatusCode.ToString();
            

                Stream responseStream = null;
                if ("gzip".Equals(response.ContentEncoding))
                {
                    responseStream = new System.IO.Compression.GZipStream(response.GetResponseStream(), System.IO.Compression.CompressionMode.Decompress);
                }
                else if ("deflate".Equals(response.ContentEncoding))
                {
                    responseStream = new System.IO.Compression.DeflateStream(response.GetResponseStream(), System.IO.Compression.CompressionMode.Decompress);
                }
                else
                {
                    responseStream = response.GetResponseStream();
                }

                return responseStream;
            }
            catch//(Exception e)
            {
                
                return null;
            }

        }
        private void GetLocalUrlByRecursion(string url)
        {

            HtmlNode rootNode = GetRootNode(url);

            if (rootNode == null)
                return;

            HtmlNodeCollection nodeList = rootNode.SelectNodes("//a");

            if (nodeList == null)
                return;

            foreach (HtmlNode node in nodeList)
            {
                if (node.Attributes["href"] == null)
                    continue;
                string u = node.Attributes["href"].Value.ToLower();

                if (u.Equals(string.Empty))
                    continue;
                //if (IsContainAddress(u))
                //    continue;
      
             bool isExists =   AddressList.Exists(delegate(string val) {
                    if (u.Equals(val))
                        return true;
                    else
                        return false;
                });

             if (isExists)
                 continue;
                if (u == "#")
                    continue;
                if (u.IndexOf("javascript:") > -1)
                    continue;
                if (u.IndexOf("tencent:") > -1)
                    continue;
                if (u.IndexOf("mailto:") > -1)
                    continue;
                if (u.IndexOf(Constant.HttpsPrefix) > -1)
                    continue;
 
                if (u.IndexOf(Constant.HttpPrefix) > -1)
                {
                    string ext = Path.GetExtension(u);
                    //扩展名过滤
                    if (ext == ".zip" || ext == ".rar" || ext == ".7z"||ext==".pdf")
                        continue;
                    //如果不是内连接则跳出
                    if (u.IndexOf(domain) < 0)
                        continue;
                    AddressList.Add(u);

                    //递归
                    GetLocalUrlByRecursion(u);
                }
                else
                {
                    string finalUrl;
                    if (u.Substring(0, 1) == "/")
                        finalUrl = Constant.HttpPrefix + domain + u;
                    else
                        finalUrl = Constant.HttpPrefix + domain + "/" + u;
                     

                    AddressList.Add(finalUrl);

                    //递归
                    GetLocalUrlByRecursion(finalUrl);

                }
            }
        }


        //递归获取内连接
        public List<string> RecurLocalUrl(string url)
        {

            if (AddressList == null)
                AddressList = new List<string>();

            AddressList.Clear();

            if (url.Length < 10)
                return AddressList;

            if (string.IsNullOrEmpty(domain))
                domain = Network.GetDomain(url);
            //递归内连接
            try
            {
                GetLocalUrlByRecursion(url);
            }
            catch (Exception e)
            {
                Error = e.Message;
            }
            domain = String.Empty;
            //把title作为excel中的列头
            if (AddressList.Count > 1)
            {

                HtmlNode rootNode = GetRootNode(url);

                if (rootNode == null)
                    AddressList[0] = domain.Replace(".", "");
                else
                {
                    HtmlNode nodeTitle = rootNode.SelectSingleNode("/html[1]/head[1]/title[1]");
                    AddressList[0] = nodeTitle == null ? domain.Replace(".", "") : nodeTitle.InnerText;
                }

                AddressList[0] = AddressList[0].Trim();
            }
            return AddressList;
        }
    }
}