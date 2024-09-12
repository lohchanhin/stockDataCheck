using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 股票清單自動掃描判斷
{
    public partial class 系統設定頁面 : Form
    {
        public 系統設定頁面()
        {
            InitializeComponent();
            InitializeTextBox();
            LoadSettings();
        }

        public void InitializeTextBox()
        {
            richTextBox1.Text = "系統設定參數說明：\n\n" +
            "SenderEmail: 設定用於發送通知郵件的寄送人電子郵件地址。\n" +
            "RecipientEmail: 指定接收通知郵件的收信人電子郵件地址。\n" +
            "SMTPPassword: SMTP服務的專用密碼，用於身份驗證以確保郵件傳送的安全。\n" +
            "IntervalSeconds: 電子郵件通知發送的時間間隔，單位為秒，設定此參數來控制發送頻率。";

        }

        private void LoadSettings()
        {
            string connectionString = "Server=localhost; Database=StockData; Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 SenderEmail, RecipientEmail, SMTPPassword, IntervalSeconds FROM SystemParameter";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    senderEmail.Text = reader["SenderEmail"].ToString();
                    recipientEmail.Text = reader["RecipientEmail"].ToString();
                    SMTPPassword.Text = reader["SMTPPassword"].ToString();
                    IntervalSeconds.Text = reader["IntervalSeconds"].ToString();
                }
                else
                {
                    MessageBox.Show("未找到設定資料。");
                }
                reader.Close();
            }
        }

        private void SaveSettings()
        {
            string connectionString = "Server=localhost; Database=StockData; Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string mergeSql = @"
            MERGE INTO SystemParameter AS target
            USING (SELECT @Id AS Id) AS source
            ON (target.Id = source.Id)
            WHEN MATCHED THEN
                UPDATE SET 
                    SenderEmail = @SenderEmail, 
                    RecipientEmail = @RecipientEmail, 
                    SMTPPassword = @SMTPPassword, 
                    IntervalSeconds = @IntervalSeconds
            WHEN NOT MATCHED THEN
                INSERT (SenderEmail, RecipientEmail, SMTPPassword, IntervalSeconds)
                VALUES (@SenderEmail, @RecipientEmail, @SMTPPassword, @IntervalSeconds);
        ";

                SqlCommand command = new SqlCommand(mergeSql, connection);
                command.Parameters.AddWithValue("@Id", 1);  // 假定 Id=1 是您的系統設定
                command.Parameters.AddWithValue("@SenderEmail", senderEmail.Text);
                command.Parameters.AddWithValue("@RecipientEmail", recipientEmail.Text);
                command.Parameters.AddWithValue("@SMTPPassword", SMTPPassword.Text);
                command.Parameters.AddWithValue("@IntervalSeconds", int.Parse(IntervalSeconds.Text));

                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("設定已保存。");
                }
                else
                {
                    MessageBox.Show("未進行任何更改。");
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }
    }
}
