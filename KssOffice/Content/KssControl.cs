using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace KssOffice
{
    public partial class KssControl : UserControl, IStatus
    {
        //发送到主窗体
        public event StatusBarEventHandler StatusBarResponse;
        protected StatusBarEventArgs status = new StatusBarEventArgs();

        public KssControl()
        {
            InitializeComponent();
        }   
        
        //主窗体任务栏，委托
        protected void OnStatusBarResponsed(StatusBarEventArgs e)
        {
            if (StatusBarResponse != null)
            {
                StatusBarResponse(this, e);
            }
        }

        public void Done()
        {
            status.Done();
            OnStatusBarResponsed(status);
        }

        public void Done(string doneString)
        {
            status.Done(doneString);
            OnStatusBarResponsed(status);
        }

        public void Error(string error)
        {
            status.Error(error);
            OnStatusBarResponsed(status);
        }

        public void Start(string text)
        {
            status.Start(text);
            OnStatusBarResponsed(status);
        }
    }
}
