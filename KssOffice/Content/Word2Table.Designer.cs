namespace KssOffice
{
    partial class WordExporter
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
            this.listWord = new KssOffice.ListItem(this.components);
            this.btnConvertPdf = new System.Windows.Forms.Button();
            this.btnFastExport = new System.Windows.Forms.Button();
            this.listTables = new KssOffice.ListItem(this.components);
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
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageOption.SuspendLayout();
            this.tabPageConvert.SuspendLayout();
            this.tabPageDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listWord);
            this.groupBox1.Controls.Add(this.btnConvertPdf);
            this.groupBox1.Controls.Add(this.btnFastExport);
            this.groupBox1.Location = new System.Drawing.Point(15, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 197);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Word文件&&表格列表";
            // 
            // listWord
            // 
            this.listWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listWord.FormattingEnabled = true;
            this.listWord.HorizontalScrollbar = true;
            this.listWord.Location = new System.Drawing.Point(20, 21);
            this.listWord.Name = "listWord";
            this.listWord.Size = new System.Drawing.Size(631, 134);
            this.listWord.Source = "init";
            this.listWord.TabIndex = 2;
            this.listWord.SelectedIndexChanged += new System.EventHandler(this.listWords_SelectedIndexChanged);
            // 
            // btnConvertPdf
            // 
            this.btnConvertPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvertPdf.Location = new System.Drawing.Point(511, 161);
            this.btnConvertPdf.Name = "btnConvertPdf";
            this.btnConvertPdf.Size = new System.Drawing.Size(140, 26);
            this.btnConvertPdf.TabIndex = 11;
            this.btnConvertPdf.Text = "批量转换为PDF文档";
            this.btnConvertPdf.UseVisualStyleBackColor = true;
            this.btnConvertPdf.Click += new System.EventHandler(this.Btn_Clicked);
            // 
            // btnFastExport
            // 
            this.btnFastExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFastExport.Location = new System.Drawing.Point(354, 161);
            this.btnFastExport.Name = "btnFastExport";
            this.btnFastExport.Size = new System.Drawing.Size(151, 26);
            this.btnFastExport.TabIndex = 11;
            this.btnFastExport.Text = "表格批量导出Excel";
            this.btnFastExport.UseVisualStyleBackColor = true;
            this.btnFastExport.Click += new System.EventHandler(this.Btn_Clicked);
            // 
            // listTables
            // 
            this.listTables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listTables.FormattingEnabled = true;
            this.listTables.Location = new System.Drawing.Point(6, 6);
            this.listTables.Name = "listTables";
            this.listTables.Size = new System.Drawing.Size(151, 212);
            this.listTables.Source = "init";
            this.listTables.TabIndex = 3;
            this.listTables.SelectedIndexChanged += new System.EventHandler(this.listTables_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(140, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 5);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "打开Word文档";
            // 
            // btnFolder
            // 
            this.btnFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFolder.Location = new System.Drawing.Point(547, 37);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(140, 23);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.Text = "打开文件夹";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.Btn_Clicked);
            // 
            // btnFile
            // 
            this.btnFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFile.Location = new System.Drawing.Point(391, 37);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(150, 23);
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
            this.tabControl1.Controls.Add(this.tabPageDataGrid);
            this.tabControl1.Controls.Add(this.tabPageOption);
            this.tabControl1.Controls.Add(this.tabPageConvert);
            this.tabControl1.Location = new System.Drawing.Point(15, 269);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 254);
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
            this.tabPageOption.Location = new System.Drawing.Point(4, 23);
            this.tabPageOption.Name = "tabPageOption";
            this.tabPageOption.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOption.Size = new System.Drawing.Size(664, 227);
            this.tabPageOption.TabIndex = 0;
            this.tabPageOption.Text = "表格导出";
            this.tabPageOption.UseVisualStyleBackColor = true;
            // 
            // cbExcel
            // 
            this.cbExcel.AutoSize = true;
            this.cbExcel.Checked = true;
            this.cbExcel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExcel.Location = new System.Drawing.Point(52, 146);
            this.cbExcel.Name = "cbExcel";
            this.cbExcel.Size = new System.Drawing.Size(453, 18);
            this.cbExcel.TabIndex = 7;
            this.cbExcel.Text = "选中则导出Excel2000以上版本(xlsx)，否则导出Excel97格式(xls)  ";
            this.cbExcel.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(514, 18);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(111, 34);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.Btn_Clicked);
            // 
            // rbOneSheets
            // 
            this.rbOneSheets.AccessibleName = "6";
            this.rbOneSheets.AutoSize = true;
            this.rbOneSheets.Location = new System.Drawing.Point(52, 113);
            this.rbOneSheets.Name = "rbOneSheets";
            this.rbOneSheets.Size = new System.Drawing.Size(221, 18);
            this.rbOneSheets.TabIndex = 8;
            this.rbOneSheets.Text = "导出一个Excel文件一个Sheet页";
            this.rbOneSheets.UseVisualStyleBackColor = true;
            this.rbOneSheets.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // rbMultipleSheets
            // 
            this.rbMultipleSheets.AccessibleName = "1";
            this.rbMultipleSheets.AutoSize = true;
            this.rbMultipleSheets.Location = new System.Drawing.Point(52, 89);
            this.rbMultipleSheets.Name = "rbMultipleSheets";
            this.rbMultipleSheets.Size = new System.Drawing.Size(221, 18);
            this.rbMultipleSheets.TabIndex = 7;
            this.rbMultipleSheets.Text = "导出一个Excel文件多个Sheet页";
            this.rbMultipleSheets.UseVisualStyleBackColor = true;
            this.rbMultipleSheets.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // rbSingleHtmlTotal
            // 
            this.rbSingleHtmlTotal.AccessibleName = "5";
            this.rbSingleHtmlTotal.AutoSize = true;
            this.rbSingleHtmlTotal.Location = new System.Drawing.Point(303, 65);
            this.rbSingleHtmlTotal.Name = "rbSingleHtmlTotal";
            this.rbSingleHtmlTotal.Size = new System.Drawing.Size(179, 18);
            this.rbSingleHtmlTotal.TabIndex = 10;
            this.rbSingleHtmlTotal.Text = "汇总单个网页(多个表格)";
            this.rbSingleHtmlTotal.UseVisualStyleBackColor = true;
            this.rbSingleHtmlTotal.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // rbMutipleHtml
            // 
            this.rbMutipleHtml.AccessibleName = "4";
            this.rbMutipleHtml.AutoSize = true;
            this.rbMutipleHtml.Location = new System.Drawing.Point(303, 41);
            this.rbMutipleHtml.Name = "rbMutipleHtml";
            this.rbMutipleHtml.Size = new System.Drawing.Size(151, 18);
            this.rbMutipleHtml.TabIndex = 9;
            this.rbMutipleHtml.Text = "多个网页(html文件)";
            this.rbMutipleHtml.UseVisualStyleBackColor = true;
            this.rbMutipleHtml.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "导出到Html网页文件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "导出到Excel";
            // 
            // rbExcelWithOneSheets
            // 
            this.rbExcelWithOneSheets.AccessibleName = "3";
            this.rbExcelWithOneSheets.AutoSize = true;
            this.rbExcelWithOneSheets.Location = new System.Drawing.Point(52, 41);
            this.rbExcelWithOneSheets.Name = "rbExcelWithOneSheets";
            this.rbExcelWithOneSheets.Size = new System.Drawing.Size(221, 18);
            this.rbExcelWithOneSheets.TabIndex = 5;
            this.rbExcelWithOneSheets.Text = "导出多个Excel中一个Sheet页面";
            this.rbExcelWithOneSheets.UseVisualStyleBackColor = true;
            this.rbExcelWithOneSheets.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // rbExcelWithSheets
            // 
            this.rbExcelWithSheets.AccessibleName = "2";
            this.rbExcelWithSheets.AutoSize = true;
            this.rbExcelWithSheets.Location = new System.Drawing.Point(52, 65);
            this.rbExcelWithSheets.Name = "rbExcelWithSheets";
            this.rbExcelWithSheets.Size = new System.Drawing.Size(221, 18);
            this.rbExcelWithSheets.TabIndex = 6;
            this.rbExcelWithSheets.Text = "导出多个Excel中多个Sheet页面";
            this.rbExcelWithSheets.UseVisualStyleBackColor = true;
            this.rbExcelWithSheets.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // tabPageConvert
            // 
            this.tabPageConvert.Controls.Add(this.flowContainer1);
            this.tabPageConvert.Location = new System.Drawing.Point(4, 23);
            this.tabPageConvert.Name = "tabPageConvert";
            this.tabPageConvert.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConvert.Size = new System.Drawing.Size(664, 227);
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
            this.flowContainer1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.flowContainer1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.flowContainer1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.flowContainer1.Location = new System.Drawing.Point(15, 18);
            this.flowContainer1.Name = "flowContainer1";
            this.flowContainer1.RowCount = 2;
            this.flowContainer1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.flowContainer1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.flowContainer1.Size = new System.Drawing.Size(632, 128);
            this.flowContainer1.TabIndex = 12;
            // 
            // tabPageDataGrid
            // 
            this.tabPageDataGrid.Controls.Add(this.dgList);
            this.tabPageDataGrid.Controls.Add(this.listTables);
            this.tabPageDataGrid.Location = new System.Drawing.Point(4, 23);
            this.tabPageDataGrid.Name = "tabPageDataGrid";
            this.tabPageDataGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDataGrid.Size = new System.Drawing.Size(664, 227);
            this.tabPageDataGrid.TabIndex = 2;
            this.tabPageDataGrid.Text = "数据表格";
            this.tabPageDataGrid.UseVisualStyleBackColor = true;
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgList.Location = new System.Drawing.Point(163, 6);
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.RowTemplate.Height = 23;
            this.dgList.Size = new System.Drawing.Size(484, 208);
            this.dgList.TabIndex = 0;
            // 
            // WordExporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WordExporter";
            this.Size = new System.Drawing.Size(701, 542);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageOption.ResumeLayout(false);
            this.tabPageOption.PerformLayout();
            this.tabPageConvert.ResumeLayout(false);
            this.tabPageConvert.PerformLayout();
            this.tabPageDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListItem listTables;
        private ListItem listWord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TabPage tabPageOption;
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
        private System.Windows.Forms.Button btnFastExport;
        private System.Windows.Forms.Button btnConvertPdf;

    }
}

