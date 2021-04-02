using System;
using System.Collections.Generic;
using System.Text;

namespace KssOffice
{
    public class TagInfo
    {
        public string Tag { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }

    }

    public class XPathInfo
    {
       
        private string xpath;
        public string  Name{ get; set; }
        public string CreateTime { get; set; }
        public string XPath
        {
            get
            { 
                return  xpath;
            }
            set
            {
                xpath = value;
            }
        }

        public string Display
        {
            get
            {
                return String.Format(Constant.BracketsAndInfo, Name, XPath);
            }
        }
    }
}
