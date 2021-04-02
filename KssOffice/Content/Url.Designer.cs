namespace KssOffice
{
    partial class Url
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Url));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnHandle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRequestURL = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listUrlGroup = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.link2 = new KssOffice.Link(this.components);
            this.link1 = new KssOffice.Link(this.components);
            this.statusBar = new KssOffice.StatusBar(this.components);
            this.txtAddresses = new KssOffice.TextboxAdvanced(this.components);
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.ForeColor = System.Drawing.Color.Orange;
            this.btnOK.Location = new System.Drawing.Point(491, 336);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(189, 25);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "绑定到主窗口地址列表 >>>";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnHandle_Click);
            // 
            // btnHandle
            // 
            this.btnHandle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHandle.Location = new System.Drawing.Point(268, 336);
            this.btnHandle.Name = "btnHandle";
            this.btnHandle.Size = new System.Drawing.Size(170, 25);
            this.btnHandle.TabIndex = 6;
            this.btnHandle.Text = "获取IE浏览器历史记录";
            this.btnHandle.UseVisualStyleBackColor = true;
            this.btnHandle.Click += new System.EventHandler(this.btnHandle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "网址列表以http://开头，每行一个";
            // 
            // txtRequestURL
            // 
            this.txtRequestURL.Location = new System.Drawing.Point(12, 59);
            this.txtRequestURL.Name = "txtRequestURL";
            this.txtRequestURL.Size = new System.Drawing.Size(229, 22);
            this.txtRequestURL.TabIndex = 1;
            this.txtRequestURL.Text = "http://";
            // 
            // btnGet
            // 
            this.btnGet.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGet.Location = new System.Drawing.Point(187, 88);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(55, 27);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "提取";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnHandle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "请输入网页地址";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Location = new System.Drawing.Point(254, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1, 320);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // listUrlGroup
            // 
            this.listUrlGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listUrlGroup.FormattingEnabled = true;
            this.listUrlGroup.HorizontalScrollbar = true;
            this.listUrlGroup.Location = new System.Drawing.Point(12, 168);
            this.listUrlGroup.Name = "listUrlGroup";
            this.listUrlGroup.Size = new System.Drawing.Size(229, 160);
            this.listUrlGroup.TabIndex = 4;
            this.listUrlGroup.SelectedIndexChanged += new System.EventHandler(this.listUrlGroup_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "提取记录";
            // 
            // btnAbort
            // 
            this.btnAbort.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAbort.Location = new System.Drawing.Point(128, 88);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(51, 27);
            this.btnAbort.TabIndex = 3;
            this.btnAbort.Text = "停止";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Visible = false;
            this.btnAbort.Click += new System.EventHandler(this.btnHandle_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRefresh.Location = new System.Drawing.Point(153, 334);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 27);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "重新获取";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnHandle_Click);
            // 
            // link2
            // 
            this.link2.AccessibleName = "excel";
            this.link2.AutoSize = true;
            this.link2.Location = new System.Drawing.Point(180, 142);
            this.link2.Name = "link2";
            this.link2.Size = new System.Drawing.Size(63, 14);
            this.link2.TabIndex = 18;
            this.link2.TabStop = true;
            this.link2.Text = "打开编辑";
            // 
            // link1
            // 
            this.link1.AccessibleName = "excel";
            this.link1.AutoSize = true;
            this.link1.Location = new System.Drawing.Point(547, 29);
            this.link1.Name = "link1";
            this.link1.Size = new System.Drawing.Size(133, 14);
            this.link1.TabIndex = 18;
            this.link1.TabStop = true;
            this.link1.Text = "编辑条件和提取地址";
            // 
            // statusBar
            // 
            this.statusBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar.Location = new System.Drawing.Point(0, 388);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(694, 24);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "获取地址方式： 1) 提取网页地址 2) 从历史记录中选择 3)在右侧输入框直接输入";
            this.statusBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddresses
            // 
            this.txtAddresses.AllowDrop = true;
            this.txtAddresses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddresses.BackColor = System.Drawing.SystemColors.Info;
            this.txtAddresses.Location = new System.Drawing.Point(268, 59);
            this.txtAddresses.Multiline = true;
            this.txtAddresses.Name = "txtAddresses";
            this.txtAddresses.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAddresses.Size = new System.Drawing.Size(411, 269);
            this.txtAddresses.TabIndex = 5;
            // 
            // Url
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 412);
            this.Controls.Add(this.link2);
            this.Controls.Add(this.link1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.listUrlGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRequestURL);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnHandle);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddresses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Url";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "提取网页地址";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Url_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnHandle;
        private TextboxAdvanced txtAddresses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRequestURL;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listUrlGroup;
        private StatusBar statusBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbort;
        private Link link1;
        private Link link2;
        private System.Windows.Forms.Button btnRefresh;
    }
}