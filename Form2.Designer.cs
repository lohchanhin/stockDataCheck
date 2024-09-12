namespace 股票清單自動掃描判斷
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SystemSettingBtn = new System.Windows.Forms.Button();
            this.NoticeBtn = new System.Windows.Forms.Button();
            this.StockAnalysisBtn = new System.Windows.Forms.Button();
            this.StockListBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showArea = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(144)))));
            this.panel1.Controls.Add(this.SystemSettingBtn);
            this.panel1.Controls.Add(this.NoticeBtn);
            this.panel1.Controls.Add(this.StockAnalysisBtn);
            this.panel1.Controls.Add(this.StockListBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 720);
            this.panel1.TabIndex = 0;
            // 
            // SystemSettingBtn
            // 
            this.SystemSettingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.SystemSettingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SystemSettingBtn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SystemSettingBtn.Image = ((System.Drawing.Image)(resources.GetObject("SystemSettingBtn.Image")));
            this.SystemSettingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SystemSettingBtn.Location = new System.Drawing.Point(30, 475);
            this.SystemSettingBtn.Name = "SystemSettingBtn";
            this.SystemSettingBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SystemSettingBtn.Size = new System.Drawing.Size(156, 58);
            this.SystemSettingBtn.TabIndex = 5;
            this.SystemSettingBtn.Text = "系統設定";
            this.SystemSettingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SystemSettingBtn.UseVisualStyleBackColor = false;
            this.SystemSettingBtn.Click += new System.EventHandler(this.SystemSettingBtn_Click);
            // 
            // NoticeBtn
            // 
            this.NoticeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.NoticeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NoticeBtn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NoticeBtn.Image = ((System.Drawing.Image)(resources.GetObject("NoticeBtn.Image")));
            this.NoticeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NoticeBtn.Location = new System.Drawing.Point(30, 397);
            this.NoticeBtn.Name = "NoticeBtn";
            this.NoticeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NoticeBtn.Size = new System.Drawing.Size(156, 58);
            this.NoticeBtn.TabIndex = 4;
            this.NoticeBtn.Text = "通知設定";
            this.NoticeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NoticeBtn.UseVisualStyleBackColor = false;
            this.NoticeBtn.Click += new System.EventHandler(this.NoticeBtn_Click);
            // 
            // StockAnalysisBtn
            // 
            this.StockAnalysisBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.StockAnalysisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StockAnalysisBtn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StockAnalysisBtn.Image = ((System.Drawing.Image)(resources.GetObject("StockAnalysisBtn.Image")));
            this.StockAnalysisBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StockAnalysisBtn.Location = new System.Drawing.Point(30, 312);
            this.StockAnalysisBtn.Name = "StockAnalysisBtn";
            this.StockAnalysisBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StockAnalysisBtn.Size = new System.Drawing.Size(156, 58);
            this.StockAnalysisBtn.TabIndex = 2;
            this.StockAnalysisBtn.Text = "股票分析";
            this.StockAnalysisBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StockAnalysisBtn.UseVisualStyleBackColor = false;
            this.StockAnalysisBtn.Click += new System.EventHandler(this.StockAnalysisBtn_Click);
            // 
            // StockListBtn
            // 
            this.StockListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.StockListBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StockListBtn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StockListBtn.Image = ((System.Drawing.Image)(resources.GetObject("StockListBtn.Image")));
            this.StockListBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StockListBtn.Location = new System.Drawing.Point(30, 230);
            this.StockListBtn.Name = "StockListBtn";
            this.StockListBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StockListBtn.Size = new System.Drawing.Size(156, 58);
            this.StockListBtn.TabIndex = 1;
            this.StockListBtn.Text = "股票清單";
            this.StockListBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StockListBtn.UseVisualStyleBackColor = false;
            this.StockListBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // showArea
            // 
            this.showArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showArea.Location = new System.Drawing.Point(226, 0);
            this.showArea.Name = "showArea";
            this.showArea.Size = new System.Drawing.Size(854, 720);
            this.showArea.TabIndex = 1;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.showArea);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel showArea;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button StockListBtn;
        private System.Windows.Forms.Button StockAnalysisBtn;
        private System.Windows.Forms.Button SystemSettingBtn;
        private System.Windows.Forms.Button NoticeBtn;
    }
}