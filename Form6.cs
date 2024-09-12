using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 股票清單自動掃描判斷
{
    public partial class 通知設定頁面 : Form
    {
        private string connectionString = "Server=localhost; Database=StockData; Integrated Security=True;";

        public 通知設定頁面()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
           // EmailHistory.Columns.Add("Symbol", "股票代碼");
            //EmailHistory.Columns.Add("SignalType", "信號類型");
            //EmailHistory.Columns.Add("TriggerDate", "觸發日期");
            //EmailHistory.Columns.Add("EmailAddress", "電子郵件");
            //EmailHistory.Columns.Add("SentStatus", "發送狀態");
            EmailHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadEmailHistory();
        }

        private void LoadEmailHistory()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var cmdText = @"
            SELECT Symbol, SignalType, TriggerDate, EmailAddress, SentStatus
            FROM EmailHistory
            WHERE Symbol LIKE @Symbol
              AND SignalType LIKE @SignalType
              AND EmailAddress LIKE @Email
              AND CAST(TriggerDate AS DATE) = CAST(@TriggerDate AS DATE)";

                using (var command = new SqlCommand(cmdText, connection))
                {
                    command.Parameters.AddWithValue("@Symbol", $"%{Symbol.Text}%");
                    command.Parameters.AddWithValue("@SignalType", $"%{方法text.Text}%");
                    command.Parameters.AddWithValue("@Email", $"%{emailText.Text}%");
                    command.Parameters.AddWithValue("@TriggerDate", dateTimePicker1.Value.Date);

                    using (var reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        EmailHistory.DataSource = dt;
                    }
                }
            }
        }

    }
}
