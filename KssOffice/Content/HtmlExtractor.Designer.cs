namespace KssOffice
{
    partial class HtmlExtractor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFilter = new System.Windows.Forms.TabPage();
            this.tabPreview = new System.Windows.Forms.TabPage();
            this.tabPageOutput = new System.Windows.Forms.TabPage();
            this.txtOutput = new KssOffice.TextboxAdvanced(this.components);
            this.tabPageDataGrid = new System.Windows.Forms.TabPage();
            this.dgList = new KssOffice.DataGridAdvanced(this.components);
            this.listTables = new KssOffice.ListItem(this.components);
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
            this.link2 = new KssOffice.Link(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.listXPath = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXPathName = new System.Windows.Forms.TextBox();
            this.txtXPath = new System.Windows.Forms.TextBox();
            this.drpEncoding = new System.Windows.Forms.ComboBox();
            this.link1 = new KssOffice.Link(this.components);
            this.cbIsText = new System.Windows.Forms.CheckBox();
            this.btnFastExtract = new System.Windows.Forms.Button();
            this.listURL = new KssOffice.ListItem(this.components);
            this.btnFile = new System.Windows.Forms.Button();
            this.btnURL = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPageOutput.SuspendLayout();
            this.tabPageDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.tabPageOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabFilter);
            this.tabControl1.Controls.Add(this.tabPreview);
            this.tabControl1.Controls.Add(this.tabPageOutput);
            this.tabControl1.Controls.Add(this.tabPageDataGrid);
            this.tabControl1.Controls.Add(this.tabPageOption);
            this.tabControl1.Location = new System.Drawing.Point(270, 165);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(509, 373);
            this.tabControl1.TabIndex = 15;
            // 
            // tabFilter
            // 
            this.tabFilter.Location = new System.Drawing.Point(4, 22);
            this.tabFilter.Name = "tabFilter";
            this.tabFilter.Size = new System.Drawing.Size(501, 347);
            this.tabFilter.TabIndex = 4;
            this.tabFilter.Text = "提取条件";
            this.tabFilter.UseVisualStyleBackColor = true;
            // 
            // tabPreview
            // 
            this.tabPreview.Location = new System.Drawing.Point(4, 22);
            this.tabPreview.Name = "tabPreview";
            this.tabPreview.Size = new System.Drawing.Size(501, 347);
            this.tabPreview.TabIndex = 3;
            this.tabPreview.Text = "预览";
            this.tabPreview.UseVisualStyleBackColor = true;
            // 
            // tabPageOutput
            // 
            this.tabPageOutput.Controls.Add(this.txtOutput);
            this.tabPageOutput.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutput.Name = "tabPageOutput";
            this.tabPageOutput.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutput.Size = new System.Drawing.Size(501, 347);
            this.tabPageOutput.TabIndex = 1;
            this.tabPageOutput.Text = "网页标签";
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
            this.txtOutput.Size = new System.Drawing.Size(495, 341);
            this.txtOutput.TabIndex = 8;
            // 
            // tabPageDataGrid
            // 
            this.tabPageDataGrid.Controls.Add(this.dgList);
            this.tabPageDataGrid.Controls.Add(this.listTables);
            this.tabPageDataGrid.Location = new System.Drawing.Point(4, 22);
            this.tabPageDataGrid.Name = "tabPageDataGrid";
            this.tabPageDataGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDataGrid.Size = new System.Drawing.Size(501, 347);
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
            this.dgList.Location = new System.Drawing.Point(113, 6);
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.RowTemplate.Height = 23;
            this.dgList.Size = new System.Drawing.Size(341, 196);
            this.dgList.TabIndex = 0;
            // 
            // listTables
            // 
            this.listTables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listTables.BackColor = System.Drawing.SystemColors.Info;
            this.listTables.FormattingEnabled = true;
            this.listTables.ItemHeight = 12;
            this.listTables.Location = new System.Drawing.Point(5, 6);
            this.listTables.Name = "listTables";
            this.listTables.Size = new System.Drawing.Size(103, 196);
            this.listTables.Source = "init";
            this.listTables.TabIndex = 3;
            this.listTables.SelectedIndexChanged += new System.EventHandler(this.listTables_SelectedIndexChanged);
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
            this.tabPageOption.Size = new System.Drawing.Size(501, 347);
            this.tabPageOption.TabIndex = 0;
            this.tabPageOption.Text = "提取";
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
            this.btnExport.Location = new System.Drawing.Point(13, 195);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(158, 31);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "提取";
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
            this.rbSingleHtmlTotal.Location = new System.Drawing.Point(243, 60);
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
            this.rbMutipleHtml.Location = new System.Drawing.Point(243, 38);
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
            this.label3.Location = new System.Drawing.Point(240, 17);
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
            // link2
            // 
            this.link2.AccessibleName = "excel";
            this.link2.AutoSize = true;
            this.link2.Location = new System.Drawing.Point(27, 464);
            this.link2.Name = "link2";
            this.link2.Size = new System.Drawing.Size(167, 12);
            this.link2.TabIndex = 8;
            this.link2.TabStop = true;
            this.link2.Text = "打开Excel编辑条件和提取地址";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(141, 492);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 21);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加或刷新";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Btn_Clicked);
            // 
            // listXPath
            // 
            this.listXPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listXPath.FormattingEnabled = true;
            this.listXPath.ItemHeight = 12;
            this.listXPath.Location = new System.Drawing.Point(23, 216);
            this.listXPath.Name = "listXPath";
            this.listXPath.Size = new System.Drawing.Size(206, 136);
            this.listXPath.TabIndex = 3;
            this.listXPath.SelectedIndexChanged += new System.EventHandler(this.listXPath_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "表达式名称：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "提取表达式：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "文档标记选择：";
            // 
            // txtXPathName
            // 
            this.txtXPathName.Location = new System.Drawing.Point(23, 411);
            this.txtXPathName.Name = "txtXPathName";
            this.txtXPathName.Size = new System.Drawing.Size(212, 21);
            this.txtXPathName.TabIndex = 0;
            this.txtXPathName.Text = "表格";
            // 
            // txtXPath
            // 
            this.txtXPath.Location = new System.Drawing.Point(23, 370);
            this.txtXPath.Name = "txtXPath";
            this.txtXPath.Size = new System.Drawing.Size(212, 21);
            this.txtXPath.TabIndex = 0;
            this.txtXPath.Text = "//table";
            // 
            // drpEncoding
            // 
            this.drpEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.drpEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpEncoding.FormattingEnabled = true;
            this.drpEncoding.Items.AddRange(new object[] {
            "出现乱码请选择",
            "GB2312",
            "UTF-8"});
            this.drpEncoding.Location = new System.Drawing.Point(473, 119);
            this.drpEncoding.Name = "drpEncoding";
            this.drpEncoding.Size = new System.Drawing.Size(100, 20);
            this.drpEncoding.TabIndex = 12;
            this.drpEncoding.SelectedIndexChanged += new System.EventHandler(this.drpEncoding_SelectedIndexChanged);
            // 
            // link1
            // 
            this.link1.AccessibleName = "excel";
            this.link1.AutoSize = true;
            this.link1.Location = new System.Drawing.Point(339, 43);
            this.link1.Name = "link1";
            this.link1.Size = new System.Drawing.Size(53, 12);
            this.link1.TabIndex = 8;
            this.link1.TabStop = true;
            this.link1.Text = "配置文档";
            // 
            // cbIsText
            // 
            this.cbIsText.AutoSize = true;
            this.cbIsText.Checked = true;
            this.cbIsText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsText.Location = new System.Drawing.Point(274, 123);
            this.cbIsText.Name = "cbIsText";
            this.cbIsText.Size = new System.Drawing.Size(180, 16);
            this.cbIsText.TabIndex = 6;
            this.cbIsText.Text = "选中则提取文本否则提取HTML";
            this.cbIsText.UseVisualStyleBackColor = true;
            this.cbIsText.CheckedChanged += new System.EventHandler(this.cbIsText_CheckedChanged);
            // 
            // btnFastExtract
            // 
            this.btnFastExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFastExtract.Location = new System.Drawing.Point(579, 117);
            this.btnFastExtract.Name = "btnFastExtract";
            this.btnFastExtract.Size = new System.Drawing.Size(182, 23);
            this.btnFastExtract.TabIndex = 11;
            this.btnFastExtract.Text = "提取";
            this.btnFastExtract.UseVisualStyleBackColor = true;
            this.btnFastExtract.Click += new System.EventHandler(this.Btn_Clicked);
            // 
            // listURL
            // 
            this.listURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listURL.BackColor = System.Drawing.SystemColors.Info;
            this.listURL.FormattingEnabled = true;
            this.listURL.HorizontalScrollbar = true;
            this.listURL.ItemHeight = 12;
            this.listURL.Location = new System.Drawing.Point(270, 72);
            this.listURL.Name = "listURL";
            this.listURL.Size = new System.Drawing.Size(491, 28);
            this.listURL.Source = "init";
            this.listURL.TabIndex = 2;
            this.listURL.SelectedIndexChanged += new System.EventHandler(this.listWords_SelectedIndexChanged);
            // 
            // btnFile
            // 
            this.btnFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFile.Location = new System.Drawing.Point(427, 34);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(99, 21);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "打开单个网页";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.Btn_Clicked);
            // 
            // btnURL
            // 
            this.btnURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnURL.Location = new System.Drawing.Point(643, 34);
            this.btnURL.Name = "btnURL";
            this.btnURL.Size = new System.Drawing.Size(118, 21);
            this.btnURL.TabIndex = 1;
            this.btnURL.Text = "打开URL地址";
            this.btnURL.UseVisualStyleBackColor = true;
            this.btnURL.Click += new System.EventHandler(this.Btn_Clicked);
            // 
            // btnFolder
            // 
            this.btnFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFolder.Location = new System.Drawing.Point(532, 34);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(105, 21);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.Text = "打开本地文件夹";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.Btn_Clicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "打开Html文档";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(120, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 5);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // HtmlExtractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.link1);
            this.Controls.Add(this.drpEncoding);
            this.Controls.Add(this.btnFastExtract);
            this.Controls.Add(this.link2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cbIsText);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listURL);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listXPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtXPathName);
            this.Controls.Add(this.btnURL);
            this.Controls.Add(this.txtXPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "HtmlExtractor";
            this.Size = new System.Drawing.Size(791, 556);
            this.Load += new System.EventHandler(this.HtmlExtractor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageOutput.ResumeLayout(false);
            this.tabPageOutput.PerformLayout();
            this.tabPageDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.tabPageOption.ResumeLayout(false);
            this.tabPageOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnFile;
        private ListItem listURL;
        private ListItem listTables;
        private System.Windows.Forms.Button btnURL;
        private System.Windows.Forms.CheckBox cbIsText;
        private System.Windows.Forms.TabPage tabPageOutput;
        private TextboxAdvanced txtOutput;
        private System.Windows.Forms.TabPage tabPageOption;
        private System.Windows.Forms.CheckBox cbExcel;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.RadioButton rbOneSheets;
        private System.Windows.Forms.RadioButton rbMultipleSheets;
        private System.Windows.Forms.RadioButton rbSingleHtmlTotal;
        private System.Windows.Forms.RadioButton rbMutipleHtml;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbExcelWithOneSheets;
        private System.Windows.Forms.RadioButton rbExcelWithSheets;
        private System.Windows.Forms.TabPage tabPageDataGrid;
        private DataGridAdvanced dgList;
        private System.Windows.Forms.TabPage tabPreview;
        private System.Windows.Forms.TabPage tabFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listXPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtXPathName;
        private System.Windows.Forms.TextBox txtXPath;
        public System.Windows.Forms.TabControl tabControl1;
        private Link link2;
        private System.Windows.Forms.Button btnFastExtract;
        private Link link1;
        private System.Windows.Forms.ComboBox drpEncoding;

    }
}

