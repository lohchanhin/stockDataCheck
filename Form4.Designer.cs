namespace 股票清單自動掃描判斷
{
    partial class 股票分析
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stock_Kline = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Back = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.SymbolText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.autoStart = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.analysisList = new System.Windows.Forms.ListBox();
            this.倒計時 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.測試 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.間隔 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.方法 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stock_Kline)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stock_Kline);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 696);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // stock_Kline
            // 
            this.stock_Kline.BackColor = System.Drawing.Color.Transparent;
            this.stock_Kline.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.stock_Kline.BorderlineColor = System.Drawing.Color.Black;
            this.stock_Kline.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.stock_Kline.ChartAreas.Add(chartArea1);
            this.stock_Kline.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.stock_Kline.Legends.Add(legend1);
            this.stock_Kline.Location = new System.Drawing.Point(3, 111);
            this.stock_Kline.Name = "stock_Kline";
            this.stock_Kline.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.stock_Kline.Series.Add(series1);
            this.stock_Kline.Size = new System.Drawing.Size(539, 582);
            this.stock_Kline.TabIndex = 1;
            this.stock_Kline.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Back);
            this.groupBox1.Controls.Add(this.Next);
            this.groupBox1.Controls.Add(this.SymbolText);
            this.groupBox1.Location = new System.Drawing.Point(71, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(6, 21);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 3;
            this.Back.Text = "上一個";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(258, 21);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 2;
            this.Next.Text = "下一個";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // SymbolText
            // 
            this.SymbolText.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SymbolText.Location = new System.Drawing.Point(117, 17);
            this.SymbolText.Name = "SymbolText";
            this.SymbolText.Size = new System.Drawing.Size(100, 27);
            this.SymbolText.TabIndex = 1;
            this.SymbolText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StopButton);
            this.groupBox3.Controls.Add(this.autoStart);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Location = new System.Drawing.Point(563, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 696);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(53, 607);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(132, 62);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "暫停";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // autoStart
            // 
            this.autoStart.Location = new System.Drawing.Point(53, 524);
            this.autoStart.Name = "autoStart";
            this.autoStart.Size = new System.Drawing.Size(132, 60);
            this.autoStart.TabIndex = 4;
            this.autoStart.Text = "全自動";
            this.autoStart.UseVisualStyleBackColor = true;
            this.autoStart.Click += new System.EventHandler(this.autoStart_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.analysisList);
            this.groupBox5.Controls.Add(this.倒計時);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.測試);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.間隔);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.方法);
            this.groupBox5.Location = new System.Drawing.Point(18, 38);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(191, 467);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // analysisList
            // 
            this.analysisList.FormattingEnabled = true;
            this.analysisList.ItemHeight = 12;
            this.analysisList.Location = new System.Drawing.Point(69, 10);
            this.analysisList.Name = "analysisList";
            this.analysisList.Size = new System.Drawing.Size(120, 88);
            this.analysisList.TabIndex = 7;
            this.analysisList.Visible = false;
            this.analysisList.SelectedIndexChanged += new System.EventHandler(this.analysisList_SelectedIndexChanged);
            // 
            // 倒計時
            // 
            this.倒計時.AutoSize = true;
            this.倒計時.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.倒計時.Location = new System.Drawing.Point(102, 238);
            this.倒計時.Name = "倒計時";
            this.倒計時.Size = new System.Drawing.Size(18, 19);
            this.倒計時.TabIndex = 6;
            this.倒計時.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(6, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "切換時間:";
            // 
            // 測試
            // 
            this.測試.Location = new System.Drawing.Point(35, 375);
            this.測試.Name = "測試";
            this.測試.Size = new System.Drawing.Size(132, 58);
            this.測試.TabIndex = 4;
            this.測試.Text = "測試";
            this.測試.UseVisualStyleBackColor = true;
            this.測試.Visible = false;
            this.測試.Click += new System.EventHandler(this.測試_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "間隔:";
            // 
            // 間隔
            // 
            this.間隔.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.間隔.Location = new System.Drawing.Point(69, 51);
            this.間隔.Name = "間隔";
            this.間隔.Size = new System.Drawing.Size(115, 27);
            this.間隔.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "分析:";
            // 
            // 方法
            // 
            this.方法.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.方法.Location = new System.Drawing.Point(69, 10);
            this.方法.Name = "方法";
            this.方法.Size = new System.Drawing.Size(115, 27);
            this.方法.TabIndex = 1;
            this.方法.Click += new System.EventHandler(this.方法_Click);
            // 
            // 股票分析
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 720);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "股票分析";
            this.Text = "Form4";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stock_Kline)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TextBox SymbolText;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button autoStart;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox 方法;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox 間隔;
        private System.Windows.Forms.Button 測試;
        private System.Windows.Forms.DataVisualization.Charting.Chart stock_Kline;
        private System.Windows.Forms.Label 倒計時;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox analysisList;
    }
}