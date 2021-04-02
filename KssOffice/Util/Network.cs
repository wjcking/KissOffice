using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Collections.Specialized;
using System.IO;

namespace KssOffice
{
    public class Network
    {
        private static string requestPage = Configuration.ConfigString.GetValue("RequestPage");
       

        public static string GetRemoteString(string type)
        {
            WebClient webClient = new WebClient();
            NameValueCollection VarPost = new NameValueCollection();

            VarPost.Add("type", type);//将textBox1中的数据变为用a标识的参数，并用POST传值方式传给网页 

            byte[] byRemoteInfo = webClient.UploadValues(requestPage, "POST", VarPost);
            string remoteInfo = System.Text.Encoding.UTF8.GetString(byRemoteInfo);

            return remoteInfo;

        }

        public static string GetDomain(string domain)
        {
            domain = domain.Replace(Constant.HttpPrefix, string.Empty);
            int pos = domain.IndexOf('/');
            if (pos > -1)
                domain = domain.Substring(0, pos);
            string[] domainNameList = new string[] { ".com.cn", ".net.cn", ".org.cn", ".gov.cn", ".ac.cn", ".bj.cn", ".sh.cn", ".tj.cn", ".cq.cn", ".he.cn", ".sx.cn", ".nm.cn", ".ln.cn", ".jl.cn", ".hl.cn", ".js.cn", ".zj.cn", ".ah.cn", ".fj.cn", ".jx.cn", ".sd.cn", ".ha.cn", ".hb.cn", ".hn.cn", ".gd.cn", ".gx.cn", ".hi.cn", ".sc.cn", ".gz.cn", ".yn.cn", ".xz.cn", ".sn.cn", ".gs.cn", ".qh.cn", ".nx.cn", ".xj.cn", ".tw.cn", ".hk.cn", ".mo.cn", ".com", ".net", ".org", ".biz", ".info", ".cc", ".tv", ".cn" };
            for (int i = 0; i < domainNameList.Length; i++)
            {
                if (domain.Length < domainNameList[i].Length)
                    return domain;
                if (domain.Substring(domain.Length - domainNameList[i].Length, domainNameList[i].Length).ToLower() == domainNameList[i])
                {

                    domain = domain.Substring(0, domain.Length - domainNameList[i].Length);//去除域名后缀 
                    if (domain.LastIndexOf(".") > 0)
                    {
                        domain = domain.Substring(domain.LastIndexOf("."), domain.Length - domain.LastIndexOf(".")) + domainNameList[i];//二级域名，提取顶级域，顺便组合 
                        if (domain.IndexOf(".") == 0) //第一个为小数点，去掉 
                        {
                            domain = domain.Substring(1, domain.Length - 1);
                        }
                    }
                    else
                    {
                        domain += domainNameList[i];//已是顶级域，组合返回 
                    }

                    break;
                }
            }

            return domain;

        }

        public static string PostMessage(string userName, string message)
        {
            WebClient webClient = new WebClient();
            NameValueCollection VarPost = new NameValueCollection();

            VarPost.Add("type", "kssmessage");
            VarPost.Add("username", userName);
            VarPost.Add("message", message);

            byte[] byRemoteInfo = webClient.UploadValues(requestPage, "POST", VarPost);
            string remoteInfo = System.Text.Encoding.UTF8.GetString(byRemoteInfo);

            return remoteInfo;
        }
    }
}
