using System;
using System.Collections.Generic;
using System.Text;

namespace KssOffice
{
    public class KssOutput
    {
        //当前输出信息
        public string CurrentOutput { get; set; }

        //内部地址
        public List<string> AddressList
        {
            get;
            set;
        }

        public void AppendLine(string text)
        {
            CurrentOutput = text + "\r\n";
        }
        public void AppendFormat(string format, params object[] args)
        {
            CurrentOutput = string.Format(format, args);
        }
        public void AppendFormatLine(string format, params object[] args)
        {
            CurrentOutput = string.Format(format, args+"\r\n");
        }
        public void AppendError(string error, string info)
        {
            CurrentOutput = string.Format("[{0}]   {1}", error, info);
        }
    }
}
