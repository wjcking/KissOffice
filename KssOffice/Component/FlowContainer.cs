using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace KssOffice
{
    /// <summary>
    /// 转换类型按钮
    /// </summary>
    public partial class FlowContainer :  TableLayoutPanel
    {
        public event SaveFormatEventHandler SaveFormatClick;


        public FlowContainer()
        {
            InitializeComponent(); 
        }

        public void BindConvertType()
        {
           foreach(KeyValuePair<Aspose.Words.SaveFormat,string> kv in Constant.ConvertFormat)
            {
                Button  b= new Button();
                b.Name = "btn" + kv.Key.ToString();
                b.Text = "转换为" + kv.Value.ToUpper() + "文件";
                b.Width = 160;
                b.Height = 30;
                b.Click += new EventHandler(b_Click);
                b.AccessibleName = Convert.ToInt32((Aspose.Words.SaveFormat)kv.Key).ToString();
                Controls.Add(b);
            }
        }
        public void OnSaveFormatClick(SaveFormatEventArgs e)
        {
            if (SaveFormatClick != null)
            {
                SaveFormatClick(this, e);
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int format = Convert.ToInt32(button.AccessibleName);
            SaveFormatEventArgs fe = new SaveFormatEventArgs();
            fe.SelectedFormat = (Aspose.Words.SaveFormat)format;
            OnSaveFormatClick(fe);
        }

        public FlowContainer(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }

}
