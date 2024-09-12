using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 股票清單自動掃描判斷
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.showArea.Controls.Clear();
            股票清單頁面 stockList = new 股票清單頁面 { Dock = DockStyle.Fill ,TopLevel = false , TopMost = true};
            stockList.FormBorderStyle = FormBorderStyle.None;
            this.showArea.Controls.Add(stockList);
            stockList.Show();
        }

        private void StockAnalysisBtn_Click(object sender, EventArgs e)
        {
            this.showArea.Controls.Clear();
            股票分析 stockAnalysis = new 股票分析 { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            stockAnalysis.FormBorderStyle = FormBorderStyle.None;
            this.showArea.Controls.Add(stockAnalysis);
            stockAnalysis.Show();
        }



        private void NoticeBtn_Click(object sender, EventArgs e)
        {
            this.showArea.Controls.Clear();
            通知設定頁面 NoticeSetting = new 通知設定頁面 { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            NoticeSetting.FormBorderStyle = FormBorderStyle.None;
            this.showArea.Controls.Add(NoticeSetting);
            NoticeSetting.Show();
        }

        private void SystemSettingBtn_Click(object sender, EventArgs e)
        {
            this.showArea.Controls.Clear();
            系統設定頁面 SystemSetting = new 系統設定頁面 { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            SystemSetting.FormBorderStyle = FormBorderStyle.None;
            this.showArea.Controls.Add(SystemSetting);
            SystemSetting.Show();
        }
    }
}
