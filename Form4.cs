using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace 股票清單自動掃描判斷
{
    public partial class 股票分析 : Form
    {
        private List<string> stockSymbols = new List<string>();
        private int currentIndex = 0;
        private HttpClient client = new HttpClient();
        private Timer timer = new Timer();
        private int countdownSeconds;

        public string Username;
        public string Password;
        public string Intervel;
        public string recipientEmail;

        private EmailService emailService;



        public 股票分析()
        {
            InitializeComponent();
            LoadSettings();
            LoadStockSymbols();
            InitAnalysis();
            //InitTimer();
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
                    Username = reader["SenderEmail"].ToString();
                    recipientEmail = reader["RecipientEmail"].ToString();
                    Password = reader["SMTPPassword"].ToString().Trim();
                    //MessageBox.Show("|" + Password + "|");  // 显示密码时两侧添加分隔符，以便观察是否有额外空格
                    Intervel = reader["IntervalSeconds"].ToString();

                    // 替换多个连续的空格为一个空格
                    Password = Regex.Replace(Password, @"\s+", " ").Trim();

                    // 比较修正后的密码
                    if (Password == "yeul kchf thih fccm")
                    {
                       // MessageBox.Show("yes");
                    }
                    else
                    {
                       // MessageBox.Show("no, is: '" + Password + "'");
                    }

                    foreach (char c in Password)
                    {
                      //  Console.WriteLine($"{c}: {(int)c}");
                    }


                    emailService = new EmailService(new EmailSettings
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        Username = Username,
                        Password = Password,
                        EnableSSL = true
                    });

                    間隔.Text = Intervel;
                }
                else
                {
                    MessageBox.Show("請前往參數設定", "未找到設定資料", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
            }
        }

        private void InitTimer()
        {
            if (timer != null)
            {
                timer.Stop();    // 停止当前计时器
                timer.Dispose(); // 释放当前计时器资源
            }
            timer = new Timer();
            timer.Interval = 1000; // 设置计时器的时间间隔为1秒
            timer.Tick += TimerTick; // 订阅计时事件
            timer.Start(); // 启动计时器
        }

        private void TimerTick(object sender, EventArgs e)
        {
            countdownSeconds-=1;
            倒計時.Text = countdownSeconds.ToString();
            if (countdownSeconds <= 0)
            {
                timer.Stop();
                Next_Click(sender, e);
            }
        }

        private void StartTimer()
        {
            if (int.TryParse(間隔.Text, out int interval))
            {
                countdownSeconds = interval;
                倒計時.Text = countdownSeconds.ToString();
                timer.Start();
            }
            else
            {
                MessageBox.Show("請輸入有效的數字格式");
            }
        }

        private void InitAnalysis()
        {
            analysisList.Items.Add("TD9");
            方法.Text = "TD9";
        }

        private async void LoadStockSymbols()
        {
            string connectionString = "Server=localhost; Database=StockData; Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Symbol FROM Stocks", connection);
                await connection.OpenAsync();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                while (reader.Read())
                {
                    stockSymbols.Add(reader["Symbol"].ToString());
                }
            }
            if (stockSymbols.Count > 0)
            {
                SymbolText.Text = stockSymbols[currentIndex];
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= stockSymbols.Count)
            {
                currentIndex = 0;
            }
            SymbolText.Text = stockSymbols[currentIndex];
            StartTimer();
            FetchStockData(SymbolText.Text);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = stockSymbols.Count - 1;
            }
            SymbolText.Text = stockSymbols[currentIndex];
        }

        private async void 測試_Click(object sender, EventArgs e)
        {
            string symbol = SymbolText.Text.Trim();
            if (!string.IsNullOrEmpty(symbol))
            {
                await FetchStockData(symbol);  // 繼續您原有的股票數據抓取功能
                
                // 測試發送郵件
                try
                {
                    string subject = "股票分析測試郵件";
                    string body = $"這是一個測試郵件，用來確認股票分析應用的郵件發送功能正常。正在分析的股票代碼為：{symbol}";
                    emailService.SendEmail("wwwchanhin@126.com", subject, body);  // 替換recipient@example.com為接收郵件的實際地址
                    SaveEmailHistory(symbol, 方法.Text, DateTime.Now, "wwwchanhin@126.com", true);
                    MessageBox.Show("測試郵件已發送。請檢查您的郵箱。", "郵件發送成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"無法發送測試郵件。錯誤：{ex.Message}", "郵件發送錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的股票代碼！");
            }
        }


        private async Task FetchStockData(string symbol)
        {
            string apiKey = "NCTD0ASNS7ZKRKNI";
            string url = $"https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={symbol}&apikey={apiKey}";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string jsonData = await response.Content.ReadAsStringAsync();
                UpdateChart(jsonData);
            }
            else
            {
                MessageBox.Show("數據獲取失敗！");
            }
        }

        private void UpdateChart(string jsonData)
        {
            var data = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(jsonData);
            var timeSeries = ((JObject)data["Time Series (Daily)"]).Properties().OrderBy(p => p.Name).ToList();

            Series series = stock_Kline.Series.FindByName("KLine") ?? stock_Kline.Series.Add("KLine");
            series.ChartType = SeriesChartType.Candlestick;
            series.Points.Clear();

            List<double> closes = new List<double>();
            foreach (var point in timeSeries)
            {
                string time = point.Name;
                var values = (JObject)point.Value;
                double open = double.Parse(values["1. open"].ToString(), CultureInfo.InvariantCulture);
                double high = double.Parse(values["2. high"].ToString(), CultureInfo.InvariantCulture);
                double low = double.Parse(values["3. low"].ToString(), CultureInfo.InvariantCulture);
                double close = double.Parse(values["4. close"].ToString(), CultureInfo.InvariantCulture);
                closes.Add(close);

                int idx = series.Points.AddXY(time, high, low, open, close);
                series.Points[idx].Color = close >= open ? Color.Green : Color.Red;
            }

            if (方法.Text == "TD9")
            {
                PerformTD9Analysis(series, closes, SymbolText.Text);
            }

            ConfigureChartArea();
        }

        private void PerformTD9Analysis(Series series, List<double> closes, string symbol)
        {
            int tdCount = 0, tsCount = 0;
            bool isTD9Triggered = false, isTS9Triggered = false;

            for (int i = 4; i < closes.Count; i++)
            {
                if (closes[i] > closes[i - 4])
                {
                    tdCount = tdCount < 9 ? tdCount + 1 : 1;
                }
                else
                {
                    tdCount = 0;
                }

                if (closes[i] < closes[i - 4])
                {
                    tsCount = tsCount < 9 ? tsCount + 1 : 1;
                }
                else
                {
                    tsCount = 0;
                }

                if (tdCount > 0)
                {
                    series.Points[i].Label = $"TD{tdCount}";
                    series.Points[i].LabelForeColor = Color.Green;
                    series.Points[i].LabelBackColor = Color.Black;
                }

                if (tsCount > 0)
                {
                    series.Points[i].Label = $"TS{tsCount}";
                    series.Points[i].LabelForeColor = Color.Red;
                    series.Points[i].LabelBackColor = Color.Black;
                }

                if (i == closes.Count - 1)
                {
                    if (tdCount == 9)
                    {
                        isTD9Triggered = true;
                    }
                    if (tsCount == 9)
                    {
                        isTS9Triggered = true;
                    }
                }
            }

            if (isTD9Triggered || isTS9Triggered)
            {
                string signalType = isTD9Triggered ? "TD9" : "TS9";
                string message = $"最新的數據點達到 {signalType}，可以考慮" + (isTD9Triggered ? "賣出" : "買入") + "。";
                //MessageBox.Show(message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);

                emailService.SendEmail("wwwchanhin@126.com", "交易信號通知", message);
                SaveEmailHistory(symbol, signalType, DateTime.Now, "wwwchanhin@126.com", true);
            }
        }

        private void ConfigureChartArea()
        {
            stock_Kline.Visible = true;
            var chartArea = stock_Kline.ChartAreas[0];
            chartArea.BackColor = Color.White;
            chartArea.AxisX.MajorGrid.LineColor = Color.Gray;
            chartArea.AxisY.MajorGrid.LineColor = Color.Gray;
            chartArea.AxisX.LabelStyle.ForeColor = Color.Black;
            chartArea.AxisY.LabelStyle.ForeColor = Color.Black;
            chartArea.AxisX.MajorGrid.Enabled = true;
            chartArea.AxisY.MajorGrid.Enabled = true;
            chartArea.CursorX.IsUserEnabled = true;
            chartArea.CursorX.IsUserSelectionEnabled = true;
            chartArea.AxisX.ScaleView.Zoomable = true;
            chartArea.AxisY.IsStartedFromZero = false;
        }

        private void 方法_Click(object sender, EventArgs e)
        {
            analysisList.Visible = true;
        }

        private void analysisList_SelectedIndexChanged(object sender, EventArgs e)
        {
            方法.Text = analysisList.SelectedItem.ToString();
            analysisList.Visible = false;
        }

        private void autoStart_Click(object sender, EventArgs e)
        {
            InitTimer();
            StartTimer();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {            
            timer.Dispose();
            倒計時.Text = "已停止";
        }

        private void SaveEmailHistory(string symbol, string signalType, DateTime triggerDate, string emailAddress, bool sentStatus)
        {
            using (var connection = new SqlConnection("Server=localhost; Database=StockData; Integrated Security=True;"))
            {
                string cmdText = "INSERT INTO EmailHistory (Symbol, SignalType, TriggerDate, EmailAddress, SentStatus) VALUES (@Symbol, @SignalType, @TriggerDate, @EmailAddress, @SentStatus)";
                using (var command = new SqlCommand(cmdText, connection))
                {
                    command.Parameters.AddWithValue("@Symbol", symbol);
                    command.Parameters.AddWithValue("@SignalType", signalType);
                    command.Parameters.AddWithValue("@TriggerDate", triggerDate);
                    command.Parameters.AddWithValue("@EmailAddress", emailAddress);
                    command.Parameters.AddWithValue("@SentStatus", sentStatus);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }

    public class EmailSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool EnableSSL { get; set; }
    }

    public class EmailService
    {
        private EmailSettings settings;

        public EmailService(EmailSettings settings)
        {
            this.settings = settings;
        }

        public void SendEmail(string to, string subject, string body)
        {
            using (var client = new SmtpClient(settings.Host, settings.Port))
            {
                client.EnableSsl = settings.EnableSSL;
                client.Credentials = new NetworkCredential(settings.Username, settings.Password);

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(settings.Username),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };
                mailMessage.To.Add(to);

                client.Send(mailMessage);
            }
        }
    }
}
