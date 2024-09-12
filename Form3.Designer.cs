namespace 股票清單自動掃描判斷
{
    partial class 股票清單頁面
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.resultsBox = new System.Windows.Forms.ListBox();
            this.stockDataGridView = new System.Windows.Forms.DataGridView();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.基本信息 = new System.Windows.Forms.TabPage();
            this.財務摘要 = new System.Windows.Forms.TabPage();
            this.股票表現 = new System.Windows.Forms.TabPage();
            this.市場表現 = new System.Windows.Forms.TabPage();
            this.投資者資訊 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.SymbolText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DescriptionText = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CikText = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IndustryText = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.websiteText = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addressText = new System.Windows.Forms.TextBox();
            this.financialList = new System.Windows.Forms.ListView();
            this.指标header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.数值header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StockList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AnalysList = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InvestorList = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteButton = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).BeginInit();
            this.TabControl.SuspendLayout();
            this.基本信息.SuspendLayout();
            this.財務摘要.SuspendLayout();
            this.股票表現.SuspendLayout();
            this.市場表現.SuspendLayout();
            this.投資者資訊.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.stockDataGridView);
            this.groupBox1.Controls.Add(this.resultsBox);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.searchBox);
            this.groupBox1.Location = new System.Drawing.Point(24, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TabControl);
            this.groupBox2.Location = new System.Drawing.Point(24, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 409);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchBox.Location = new System.Drawing.Point(102, 17);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(560, 27);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "股票代碼:";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.SearchButton.Location = new System.Drawing.Point(668, 17);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(78, 27);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "搜尋";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultsBox
            // 
            this.resultsBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultsBox.FormattingEnabled = true;
            this.resultsBox.ItemHeight = 16;
            this.resultsBox.Location = new System.Drawing.Point(102, 40);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(560, 196);
            this.resultsBox.TabIndex = 3;
            this.resultsBox.Visible = false;
            // 
            // stockDataGridView
            // 
            this.stockDataGridView.AllowUserToAddRows = false;
            this.stockDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.stockDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.stockDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stockDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDataGridView.Location = new System.Drawing.Point(10, 50);
            this.stockDataGridView.MultiSelect = false;
            this.stockDataGridView.Name = "stockDataGridView";
            this.stockDataGridView.ReadOnly = true;
            this.stockDataGridView.RowTemplate.Height = 24;
            this.stockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockDataGridView.Size = new System.Drawing.Size(652, 186);
            this.stockDataGridView.TabIndex = 4;
            this.stockDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockDataGridView_CellClick);
            this.stockDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockDataGridView_CellContentClick);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.基本信息);
            this.TabControl.Controls.Add(this.財務摘要);
            this.TabControl.Controls.Add(this.股票表現);
            this.TabControl.Controls.Add(this.市場表現);
            this.TabControl.Controls.Add(this.投資者資訊);
            this.TabControl.Location = new System.Drawing.Point(10, 21);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(736, 369);
            this.TabControl.TabIndex = 0;
            // 
            // 基本信息
            // 
            this.基本信息.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.基本信息.Controls.Add(this.groupBox9);
            this.基本信息.Controls.Add(this.groupBox8);
            this.基本信息.Controls.Add(this.groupBox7);
            this.基本信息.Controls.Add(this.groupBox6);
            this.基本信息.Controls.Add(this.groupBox5);
            this.基本信息.Controls.Add(this.groupBox4);
            this.基本信息.Controls.Add(this.groupBox3);
            this.基本信息.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.基本信息.Location = new System.Drawing.Point(4, 22);
            this.基本信息.Name = "基本信息";
            this.基本信息.Padding = new System.Windows.Forms.Padding(3);
            this.基本信息.Size = new System.Drawing.Size(728, 343);
            this.基本信息.TabIndex = 0;
            this.基本信息.Text = "基本信息";
            // 
            // 財務摘要
            // 
            this.財務摘要.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.財務摘要.Controls.Add(this.financialList);
            this.財務摘要.Location = new System.Drawing.Point(4, 22);
            this.財務摘要.Name = "財務摘要";
            this.財務摘要.Padding = new System.Windows.Forms.Padding(3);
            this.財務摘要.Size = new System.Drawing.Size(728, 343);
            this.財務摘要.TabIndex = 1;
            this.財務摘要.Text = "財務摘要";
            // 
            // 股票表現
            // 
            this.股票表現.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.股票表現.Controls.Add(this.StockList);
            this.股票表現.Location = new System.Drawing.Point(4, 22);
            this.股票表現.Name = "股票表現";
            this.股票表現.Size = new System.Drawing.Size(728, 343);
            this.股票表現.TabIndex = 2;
            this.股票表現.Text = "股票表現";
            // 
            // 市場表現
            // 
            this.市場表現.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.市場表現.Controls.Add(this.AnalysList);
            this.市場表現.Location = new System.Drawing.Point(4, 22);
            this.市場表現.Name = "市場表現";
            this.市場表現.Size = new System.Drawing.Size(728, 343);
            this.市場表現.TabIndex = 3;
            this.市場表現.Text = "市場表現";
            // 
            // 投資者資訊
            // 
            this.投資者資訊.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.投資者資訊.Controls.Add(this.InvestorList);
            this.投資者資訊.Location = new System.Drawing.Point(4, 22);
            this.投資者資訊.Name = "投資者資訊";
            this.投資者資訊.Size = new System.Drawing.Size(728, 343);
            this.投資者資訊.TabIndex = 4;
            this.投資者資訊.Text = "投資者資訊";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "代碼:";
            // 
            // SymbolText
            // 
            this.SymbolText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SymbolText.Dock = System.Windows.Forms.DockStyle.Right;
            this.SymbolText.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SymbolText.Location = new System.Drawing.Point(47, 23);
            this.SymbolText.Name = "SymbolText";
            this.SymbolText.Size = new System.Drawing.Size(100, 20);
            this.SymbolText.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.SymbolText);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 50);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.NameText);
            this.groupBox4.Location = new System.Drawing.Point(162, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(150, 50);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "名字:";
            // 
            // NameText
            // 
            this.NameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameText.Dock = System.Windows.Forms.DockStyle.Right;
            this.NameText.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameText.Location = new System.Drawing.Point(47, 23);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 20);
            this.NameText.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DescriptionText);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(6, 122);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(716, 205);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(3, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "描述:";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(52, 20);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(650, 163);
            this.DescriptionText.TabIndex = 2;
            this.DescriptionText.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.CikText);
            this.groupBox6.Location = new System.Drawing.Point(318, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(150, 50);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(3, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "CIK:";
            // 
            // CikText
            // 
            this.CikText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CikText.Dock = System.Windows.Forms.DockStyle.Right;
            this.CikText.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CikText.Location = new System.Drawing.Point(47, 23);
            this.CikText.Name = "CikText";
            this.CikText.Size = new System.Drawing.Size(100, 20);
            this.CikText.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.IndustryText);
            this.groupBox7.Location = new System.Drawing.Point(474, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(231, 50);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(3, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "行業:";
            // 
            // IndustryText
            // 
            this.IndustryText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IndustryText.Dock = System.Windows.Forms.DockStyle.Right;
            this.IndustryText.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.IndustryText.Location = new System.Drawing.Point(52, 23);
            this.IndustryText.Name = "IndustryText";
            this.IndustryText.Size = new System.Drawing.Size(176, 20);
            this.IndustryText.TabIndex = 1;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.websiteText);
            this.groupBox8.Location = new System.Drawing.Point(6, 62);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(256, 50);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "groupBox8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(3, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "官網:";
            // 
            // websiteText
            // 
            this.websiteText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.websiteText.Dock = System.Windows.Forms.DockStyle.Right;
            this.websiteText.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.websiteText.Location = new System.Drawing.Point(47, 23);
            this.websiteText.Name = "websiteText";
            this.websiteText.Size = new System.Drawing.Size(206, 20);
            this.websiteText.TabIndex = 1;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Controls.Add(this.addressText);
            this.groupBox9.Location = new System.Drawing.Point(268, 62);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(440, 50);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "groupBox9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(3, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "地址:";
            // 
            // addressText
            // 
            this.addressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressText.Dock = System.Windows.Forms.DockStyle.Right;
            this.addressText.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addressText.Location = new System.Drawing.Point(50, 23);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(387, 20);
            this.addressText.TabIndex = 1;
            // 
            // financialList
            // 
            this.financialList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.financialList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.指标header,
            this.数值header});
            this.financialList.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.financialList.FullRowSelect = true;
            this.financialList.Location = new System.Drawing.Point(6, 18);
            this.financialList.Name = "financialList";
            this.financialList.Size = new System.Drawing.Size(716, 312);
            this.financialList.TabIndex = 0;
            this.financialList.UseCompatibleStateImageBehavior = false;
            this.financialList.View = System.Windows.Forms.View.Details;
            // 
            // 指标header
            // 
            this.指标header.Text = "指标";
            this.指标header.Width = 359;
            // 
            // 数值header
            // 
            this.数值header.Text = "数值";
            this.数值header.Width = 356;
            // 
            // StockList
            // 
            this.StockList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StockList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.StockList.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StockList.FullRowSelect = true;
            this.StockList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.StockList.Location = new System.Drawing.Point(6, 15);
            this.StockList.Name = "StockList";
            this.StockList.Size = new System.Drawing.Size(716, 312);
            this.StockList.TabIndex = 1;
            this.StockList.UseCompatibleStateImageBehavior = false;
            this.StockList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "指标";
            this.columnHeader1.Width = 359;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "数值";
            this.columnHeader2.Width = 356;
            // 
            // AnalysList
            // 
            this.AnalysList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnalysList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.AnalysList.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AnalysList.FullRowSelect = true;
            this.AnalysList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AnalysList.Location = new System.Drawing.Point(6, 15);
            this.AnalysList.Name = "AnalysList";
            this.AnalysList.Size = new System.Drawing.Size(716, 312);
            this.AnalysList.TabIndex = 2;
            this.AnalysList.UseCompatibleStateImageBehavior = false;
            this.AnalysList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "指标";
            this.columnHeader3.Width = 359;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "数值";
            this.columnHeader4.Width = 356;
            // 
            // InvestorList
            // 
            this.InvestorList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InvestorList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.InvestorList.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InvestorList.FullRowSelect = true;
            this.InvestorList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.InvestorList.Location = new System.Drawing.Point(6, 15);
            this.InvestorList.Name = "InvestorList";
            this.InvestorList.Size = new System.Drawing.Size(716, 312);
            this.InvestorList.TabIndex = 3;
            this.InvestorList.UseCompatibleStateImageBehavior = false;
            this.InvestorList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "指标";
            this.columnHeader5.Width = 359;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "数值";
            this.columnHeader6.Width = 356;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.deleteButton.Location = new System.Drawing.Point(668, 59);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(78, 27);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "刪除";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // 股票清單頁面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 720);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "股票清單頁面";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.基本信息.ResumeLayout(false);
            this.財務摘要.ResumeLayout(false);
            this.股票表現.ResumeLayout(false);
            this.市場表現.ResumeLayout(false);
            this.投資者資訊.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView stockDataGridView;
        private System.Windows.Forms.ListBox resultsBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage 基本信息;
        private System.Windows.Forms.TabPage 財務摘要;
        private System.Windows.Forms.TabPage 股票表現;
        private System.Windows.Forms.TabPage 市場表現;
        private System.Windows.Forms.TabPage 投資者資訊;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SymbolText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox DescriptionText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CikText;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IndustryText;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox websiteText;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.ListView financialList;
        private System.Windows.Forms.ColumnHeader 指标header;
        private System.Windows.Forms.ColumnHeader 数值header;
        private System.Windows.Forms.ListView StockList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView AnalysList;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView InvestorList;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}