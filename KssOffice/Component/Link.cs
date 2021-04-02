using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

using System.Windows.Forms;
namespace KssOffice
{
    public partial class Link :  LinkLabel
    {
        public Link()
        {
            InitializeComponent();
        }

        public Link(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        
        }

        protected override void OnClick(EventArgs e)
        {
            if (AccessibleName == "excel")
                System.Diagnostics.Process.Start(Constant.ExcelHtmlTag);
    
            base.OnClick(e);
        }
    }
}
