namespace KssOffice
{
    partial class Mdi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mdi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmMain = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWordTable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHtmlExtractor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLinkExtractor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPdf = new System.Windows.Forms.ToolStripMenuItem();
            this.视图VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmhelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpenChm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWebsite = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.container = new System.Windows.Forms.Panel();
            this.lbStatus = new KssOffice.StatusBar(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMain,
            this.视图VToolStripMenuItem,
            this.tsmhelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(771, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmMain
            // 
            this.tsmMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmWordTable,
            this.tsmHtmlExtractor,
            this.tsmLinkExtractor,
            this.tsmPdf});
            this.tsmMain.Name = "tsmMain";
            this.tsmMain.Size = new System.Drawing.Size(58, 21);
            this.tsmMain.Text = "工具(&F)";
            this.tsmMain.Click += new System.EventHandler(this.tsmMain_Click);
            // 
            // tsmWordTable
            // 
            this.tsmWordTable.Name = "tsmWordTable";
            this.tsmWordTable.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tsmWordTable.Size = new System.Drawing.Size(196, 22);
            this.tsmWordTable.Text = "Word批量操作";
            this.tsmWordTable.Click += new System.EventHandler(this.tsmMain_Click);
            // 
            // tsmHtmlExtractor
            // 
            this.tsmHtmlExtractor.Name = "tsmHtmlExtractor";
            this.tsmHtmlExtractor.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.tsmHtmlExtractor.Size = new System.Drawing.Size(196, 22);
            this.tsmHtmlExtractor.Text = "网页数据提取工具";
            this.tsmHtmlExtractor.Visible = false;
            this.tsmHtmlExtractor.Click += new System.EventHandler(this.tsmMain_Click);
            // 
            // tsmLinkExtractor
            // 
            this.tsmLinkExtractor.Name = "tsmLinkExtractor";
            this.tsmLinkExtractor.Size = new System.Drawing.Size(196, 22);
            this.tsmLinkExtractor.Text = "批量站内链接提取工具";
            this.tsmLinkExtractor.Visible = false;
            // 
            // tsmPdf
            // 
            this.tsmPdf.Name = "tsmPdf";
            this.tsmPdf.Size = new System.Drawing.Size(196, 22);
            this.tsmPdf.Text = "Pdf文档处理";
            this.tsmPdf.Visible = false;
            this.tsmPdf.Click += new System.EventHandler(this.tsmMain_Click);
            // 
            // 视图VToolStripMenuItem
            // 
            this.视图VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStart});
            this.视图VToolStripMenuItem.Name = "视图VToolStripMenuItem";
            this.视图VToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.视图VToolStripMenuItem.Text = "视图(&V)";
            // 
            // tsmStart
            // 
            this.tsmStart.Name = "tsmStart";
            this.tsmStart.Size = new System.Drawing.Size(112, 22);
            this.tsmStart.Text = "起始页";
            this.tsmStart.Click += new System.EventHandler(this.tsmMain_Click);
            // 
            // tsmhelp
            // 
            this.tsmhelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpenChm,
            this.tsmWebsite});
            this.tsmhelp.Name = "tsmhelp";
            this.tsmhelp.Size = new System.Drawing.Size(61, 21);
            this.tsmhelp.Text = "帮助(&H)";
            // 
            // tsmOpenChm
            // 
            this.tsmOpenChm.Name = "tsmOpenChm";
            this.tsmOpenChm.Size = new System.Drawing.Size(152, 22);
            this.tsmOpenChm.Text = "打开帮助文档";
            this.tsmOpenChm.Click += new System.EventHandler(this.tsmMain_Click);
            // 
            // tsmWebsite
            // 
            this.tsmWebsite.Name = "tsmWebsite";
            this.tsmWebsite.Size = new System.Drawing.Size(152, 22);
            this.tsmWebsite.Text = "访问官网";
            this.tsmWebsite.Click += new System.EventHandler(this.tsmMain_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 26);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(646, 23);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 25);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(771, 594);
            this.container.TabIndex = 4;
            // 
            // lbStatus
            // 
            this.lbStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbStatus.Location = new System.Drawing.Point(0, 619);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(771, 20);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "就绪";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Mdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 639);
            this.Controls.Add(this.container);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mdi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "金速提取";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmMain;
        private System.Windows.Forms.ToolStripMenuItem tsmWordTable;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.ToolStripMenuItem tsmhelp;
        private System.Windows.Forms.ToolStripMenuItem 视图VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmStart;
        private System.Windows.Forms.ToolStripMenuItem tsmHtmlExtractor;
        private System.Windows.Forms.ToolStripMenuItem tsmPdf;
        private StatusBar lbStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmLinkExtractor;
        private System.Windows.Forms.ToolStripMenuItem tsmOpenChm;
        private System.Windows.Forms.ToolStripMenuItem tsmWebsite;

    }
}