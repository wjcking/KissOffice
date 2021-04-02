using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace KssOffice
{
    public partial class StatusBar : Label, IStatus
    {
        public StatusBar()
        {
            InitializeComponent();
        }

        public StatusBar(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void Done()
        {
            Text = "就绪";
            BackColor = Constant.ColorControl;
        }

        public void Done(string text)
        {
            Text = text;
            BackColor = Constant.ColorControl;
        }

        public void Error(string text)
        {
            BackColor = Constant.ColorError;
            Text = text;
        }

        public void Start(string text)
        {
            BackColor = Constant.ColorStart;
            Text = text;
        }
    }
}
