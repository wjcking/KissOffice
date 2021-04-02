namespace KssOffice
{
    partial class PdfProcess
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listFiles = new KssOffice.AsposeItem(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOption = new System.Windows.Forms.TabPage();
            this.cbExcel = new System.Windows.Forms.CheckBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.rbOneSheets = new System.Windows.Forms.RadioButton();
            this.rbMultipleSheets = new System.Windows.Forms.RadioButton();
            this.rbSingleHtmlTotal = new System.Windows.Forms.RadioButton();
            this.rbMutipleHtml = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbExcelWithOneSheets = new System.Windows.Forms.RadioButton();
            this.rbExcelWithSheets = new System.Windows.Forms.RadioButton();
            this.tabPageConvert = new System.Windows.Forms.TabPage();
            this.flowContainer1 = new KssOffice.FlowContainer(this.components);
            this.tabPageDataGrid = new System.Windows.Forms.TabPage();
            this.dgList = new KssOffice.DataGridAdvanced(this.components);
            this.tabPageOutput = new System.Windows.Forms.TabPage();
            this.txtOutput = new KssOffice.TextboxAdvanced(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageOption.SuspendLayout();
            this.tabPageConvert.SuspendLayout();
            this.tabPageDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.tabPageOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listFiles);
            this.groupBox1.Location = new System.Drawing.Point(13, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 173);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件列表";
            // 
            // listFiles
            // 
            this.listFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listFiles.FormattingEnabled = true;
            this.listFiles.HorizontalScrollbar = true;
            this.listFiles.ItemHeight = 12;
            this.listFiles.Location = new System.Drawing.Point(17, 19);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(541, 136);
            this.listFiles.Source = "init";
            this.listFiles.TabIndex = 2;
            this.listFiles.SelectedIndexChanged += new System.EventHandler(this.listWords_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(120, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 5);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "打开文件";
            // 
            // btnFolder
            // 
            this.btnFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFolder.Location = new System.Drawing.Point(484, 34);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(105, 21);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.Text = "打开文件夹";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.Btn_Clicked);
            // 
            // btnFile
            // 
            this.btnFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFile.Location = new System.Drawing.Point(350, 34);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(129, 21);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "打开单个word文档";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.Btn_Clicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageOption);
            this.tabControl1.Controls.Add(this.tabPageConvert);
            this.tabControl1.Controls.Add(this.tabPageDataGrid);
            this.tabControl1.Controls.Add(this.tabPageOutput);
            this.tabControl1.Location = new System.Drawing.Point(13, 239);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(576, 192);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPageOption
            // 
            this.tabPageOption.AutoScroll = true;
            this.tabPageOption.Controls.Add(this.cbExcel);
            this.tabPageOption.Controls.Add(this.btnExport);
            this.tabPageOption.Controls.Add(this.rbOneSheets);
            this.tabPageOption.Controls.Add(this.rbMultipleSheets);
            this.tabPageOption.Controls.Add(this.rbSingleHtmlTotal);
            this.tabPageOption.Controls.Add(this.rbMutipleHtml);
            this.tabPageOption.Controls.Add(this.label3);
            this.tabPageOption.Controls.Add(this.label2);
            this.tabPageOption.Controls.Add(this.rbExcelWithOneSheets);
            this.tabPageOption.Controls.Add(this.rbExcelWithSheets);
            this.tabPageOption.Location = new System.Drawing.Point(4, 22);
            this.tabPageOption.Name = "tabPageOption";
            this.tabPageOption.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOption.Size = new System.Drawing.Size(568, 166);
            this.tabPageOption.TabIndex = 0;
            this.tabPageOption.Text = "表格导出";
            this.tabPageOption.UseVisualStyleBackColor = true;
            // 
            // cbExcel
            // 
            this.cbExcel.AutoSize = true;
            this.cbExcel.Checked = true;
            this.cbExcel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExcel.Location = new System.Drawing.Point(45, 135);
            this.cbExcel.Name = "cbExcel";
            this.cbExcel.Size = new System.Drawing.Size(390, 16);
            this.cbExcel.TabIndex = 7;
            this.cbExcel.Text = "选中则导出Excel2000以上版本(xlsx)，否则导出Excel97格式(xls)  ";
            this.cbExcel.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(449, 17);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(87, 31);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.Btn_Clicked);
            // 
            // rbOneSheets
            // 
            this.rbOneSheets.AccessibleName = "6";
            this.rbOneSheets.AutoSize = true;
            this.rbOneSheets.Location = new System.Drawing.Point(45, 104);
            this.rbOneSheets.Name = "rbOneSheets";
            this.rbOneSheets.Size = new System.Drawing.Size(191, 16);
            this.rbOneSheets.TabIndex = 8;
            this.rbOneSheets.Text = "导出一个Excel文件一个Sheet页";
            this.rbOneSheets.UseVisualStyleBackColor = true;
            this.rbOneSheets.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // rbMultipleSheets
            // 
            this.rbMultipleSheets.AccessibleName = "1";
            this.rbMultipleSheets.AutoSize = true;
            this.rbMultipleSheets.Location = new System.Drawing.Point(45, 82);
            this.rbMultipleSheets.Name = "rbMultipleSheets";
            this.rbMultipleSheets.Size = new System.Drawing.Size(191, 16);
            this.rbMultipleSheets.TabIndex = 7;
            this.rbMultipleSheets.Text = "导出一个Excel文件多个Sheet页";
            this.rbMultipleSheets.UseVisualStyleBackColor = true;
            this.rbMultipleSheets.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // rbSingleHtmlTotal
            // 
            this.rbSingleHtmlTotal.AccessibleName = "5";
            this.rbSingleHtmlTotal.AutoSize = true;
            this.rbSingleHtmlTotal.Location = new System.Drawing.Point(260, 60);
            this.rbSingleHtmlTotal.Name = "rbSingleHtmlTotal";
            this.rbSingleHtmlTotal.Size = new System.Drawing.Size(155, 16);
            this.rbSingleHtmlTotal.TabIndex = 10;
            this.rbSingleHtmlTotal.Text = "汇总单个网页(多个表格)";
            this.rbSingleHtmlTotal.UseVisualStyleBackColor = true;
            this.rbSingleHtmlTotal.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // rbMutipleHtml
            // 
            this.rbMutipleHtml.AccessibleName = "4";
            this.rbMutipleHtml.AutoSize = true;
            this.rbMutipleHtml.Location = new System.Drawing.Point(260, 38);
            this.rbMutipleHtml.Name = "rbMutipleHtml";
            this.rbMutipleHtml.Size = new System.Drawing.Size(131, 16);
            this.rbMutipleHtml.TabIndex = 9;
            this.rbMutipleHtml.Text = "多个网页(html文件)";
            this.rbMutipleHtml.UseVisualStyleBackColor = true;
            this.rbMutipleHtml.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "导出到Html网页文件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "导出到Excel";
            // 
            // rbExcelWithOneSheets
            // 
            this.rbExcelWithOneSheets.AccessibleName = "3";
            this.rbExcelWithOneSheets.AutoSize = true;
            this.rbExcelWithOneSheets.Location = new System.Drawing.Point(45, 38);
            this.rbExcelWithOneSheets.Name = "rbExcelWithOneSheets";
            this.rbExcelWithOneSheets.Size = new System.Drawing.Size(191, 16);
            this.rbExcelWithOneSheets.TabIndex = 5;
            this.rbExcelWithOneSheets.Text = "导出多个Excel中一个Sheet页面";
            this.rbExcelWithOneSheets.UseVisualStyleBackColor = true;
            this.rbExcelWithOneSheets.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // rbExcelWithSheets
            // 
            this.rbExcelWithSheets.AccessibleName = "2";
            this.rbExcelWithSheets.AutoSize = true;
            this.rbExcelWithSheets.Location = new System.Drawing.Point(45, 60);
            this.rbExcelWithSheets.Name = "rbExcelWithSheets";
            this.rbExcelWithSheets.Size = new System.Drawing.Size(191, 16);
            this.rbExcelWithSheets.TabIndex = 6;
            this.rbExcelWithSheets.Text = "导出多个Excel中多个Sheet页面";
            this.rbExcelWithSheets.UseVisualStyleBackColor = true;
            this.rbExcelWithSheets.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // tabPageConvert
            // 
            this.tabPageConvert.Controls.Add(this.flowContainer1);
            this.tabPageConvert.Location = new System.Drawing.Point(4, 22);
            this.tabPageConvert.Name = "tabPageConvert";
            this.tabPageConvert.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConvert.Size = new System.Drawing.Size(568, 166);
            this.tabPageConvert.TabIndex = 3;
            this.tabPageConvert.Text = "类型转换";
            this.tabPageConvert.UseVisualStyleBackColor = true;
            // 
            // flowContainer1
            // 
            this.flowContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flowContainer1.AutoSize = true;
            this.flowContainer1.ColumnCount = 3;
            this.flowContainer1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.43305F));
            this.flowContainer1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.56695F));
            this.flowContainer1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.flowContainer1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.flowContainer1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.flowContainer1.Location = new System.Drawing.Point(13, 17);
            this.flowContainer1.Name = "flowContainer1";
            this.flowContainer1.RowCount = 2;
            this.flowContainer1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.flowContainer1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.flowContainer1.Size = new System.Drawing.Size(542, 118);
            this.flowContainer1.TabIndex = 12;
            // 
            // tabPageDataGrid
            // 
            this.tabPageDataGrid.Controls.Add(this.dgList);
            this.tabPageDataGrid.Location = new System.Drawing.Point(4, 22);
            this.tabPageDataGrid.Name = "tabPageDataGrid";
            this.tabPageDataGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDataGrid.Size = new System.Drawing.Size(568, 166);
            this.tabPageDataGrid.TabIndex = 2;
            this.tabPageDataGrid.Text = "数据表格";
            this.tabPageDataGrid.UseVisualStyleBackColor = true;
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgList.Location = new System.Drawing.Point(3, 3);
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.RowTemplate.Height = 23;
            this.dgList.Size = new System.Drawing.Size(564, 162);
            this.dgList.TabIndex = 0;
            // 
            // tabPageOutput
            // 
            this.tabPageOutput.Controls.Add(this.txtOutput);
            this.tabPageOutput.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutput.Name = "tabPageOutput";
            this.tabPageOutput.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutput.Size = new System.Drawing.Size(568, 166);
            this.tabPageOutput.TabIndex = 1;
            this.tabPageOutput.Text = "输出查看";
            this.tabPageOutput.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.AllowDrop = true;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.08F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(3, 3);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(565, 162);
            this.txtOutput.TabIndex = 8;
            // 
            // PdfProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PdfProcess";
            this.Size = new System.Drawing.Size(601, 443);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageOption.ResumeLayout(false);
            this.tabPageOption.PerformLayout();
            this.tabPageConvert.ResumeLayout(false);
            this.tabPageConvert.PerformLayout();
            this.tabPageDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.tabPageOutput.ResumeLayout(false);
            this.tabPageOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AsposeItem listFiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TabPage tabPageOption;
        private System.Windows.Forms.TabPage tabPageOutput;
        private TextboxAdvanced txtOutput;
        private System.Windows.Forms.RadioButton rbMultipleSheets;
        private System.Windows.Forms.RadioButton rbMutipleHtml;
        private System.Windows.Forms.RadioButton rbExcelWithSheets;
        private System.Windows.Forms.TabPage tabPageDataGrid;
        private DataGridAdvanced dgList;
        private System.Windows.Forms.RadioButton rbSingleHtmlTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.RadioButton rbExcelWithOneSheets;
        private System.Windows.Forms.TabPage tabPageConvert;
        public System.Windows.Forms.TabControl tabControl1;
        private FlowContainer flowContainer1;
        private System.Windows.Forms.CheckBox cbExcel;
        private System.Windows.Forms.RadioButton rbOneSheets;

    }
}

