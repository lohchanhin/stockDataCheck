using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data;

namespace 股票清單自動掃描判斷
{
    public partial class 股票清單頁面 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public 股票清單頁面()
        {
            InitializeComponent();
            SearchButton.Click += new EventHandler(button1_Click);
            resultsBox.MouseDoubleClick += new MouseEventHandler(resultsBox_MouseDoubleClick);
            LoadStocksFromDatabase();  // 同步等待異步方法完成，以便在表單加載時完成股票資料的加載
                                       // 为窗体添加 MouseDown 事件处理器
            this.MouseDown += Form_MouseDown;
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            // 检查鼠标点击位置是否在 ListBox 内
            if (!resultsBox.Bounds.Contains(e.Location))
            {
                // 如果不在 ListBox 内，隐藏 ListBox
                resultsBox.Visible = false;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await PerformSearchAsync(searchBox.Text);
        }

        private async Task PerformSearchAsync(string keywords)
        {
            string apiKey = "NCTD0ASNS7ZKRKNI"; // Use your real API key
            string url = $"https://www.alphavantage.co/query?function=SYMBOL_SEARCH&keywords={keywords}&apikey={apiKey}";

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                //Debug.WriteLine(responseBody);
                var searchResults = JsonConvert.DeserializeObject<SearchData>(responseBody);

                var sortedMatches = searchResults.BestMatches
                    .OrderByDescending(match => double.Parse(match.MatchScore));

                resultsBox.Items.Clear();
                if (sortedMatches.Any())
                {
                    foreach (var item in sortedMatches)
                    {
                        string json = JsonConvert.SerializeObject(item);
                        resultsBox.Items.Add(json);
                    }
                    resultsBox.BringToFront();
                    resultsBox.Visible = true;
                }
                else
                {
                    resultsBox.Visible = false;
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}");
                resultsBox.Visible = false;
            }
        }

        private async Task AddStockToDatabase(BestMatch stock)
        {
            string connectionString = "Server=localhost; Database=StockData; Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            INSERT INTO Stocks (Symbol, Name, Type, Region, MarketOpen, MarketClose, Timezone, Currency, MatchScore)
            VALUES (@Symbol, @Name, @Type, @Region, @MarketOpen, @MarketClose, @Timezone, @Currency, @MatchScore)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Symbol", stock.Symbol);
                    command.Parameters.AddWithValue("@Name", stock.Name);
                    command.Parameters.AddWithValue("@Type", stock.Type);
                    command.Parameters.AddWithValue("@Region", stock.Region);
                    command.Parameters.AddWithValue("@MarketOpen", stock.MarketOpen);
                    command.Parameters.AddWithValue("@MarketClose", stock.MarketClose);
                    command.Parameters.AddWithValue("@Timezone", stock.Timezone);
                    command.Parameters.AddWithValue("@Currency", stock.Currency);
                    command.Parameters.AddWithValue("@MatchScore", stock.MatchScore);

                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        private async Task LoadStocksFromDatabase()
        {
            // 使用 localhost 和 StockData 數據庫
            string connectionString = "Server=localhost; Database=StockData; Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // 只選擇需要的列
                string query = @"
            SELECT 
                Symbol, 
                Name, 
                Type, 
                Region, 
                CONVERT(VARCHAR, MarketOpen, 108) AS MarketOpen, 
                CONVERT(VARCHAR, MarketClose, 108) AS MarketClose
            FROM Stocks";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        stockDataGridView.DataSource = dataTable;  // 設置數據源
                    }
                }
            }
        }




        private async void resultsBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = resultsBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                string json = resultsBox.Items[index].ToString();
                BestMatch selectedMatch = JsonConvert.DeserializeObject<BestMatch>(json);

                // 添加到數據庫
                await AddStockToDatabase(selectedMatch);

                // 重新從資料庫加載股票到 DataGridView
                await LoadStocksFromDatabase();

                resultsBox.Items.Clear();
                resultsBox.Visible = false;
            }
        }




        private async Task FetchCompanyOverview(string symbol)
        {
            string apiKey = "NCTD0ASNS7ZKRKNI"; // Use your real API key
            string url = $"https://www.alphavantage.co/query?function=OVERVIEW&symbol={symbol}&apikey={apiKey}";

            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                try
                {
                    CompanyOverview overview = JsonConvert.DeserializeObject<CompanyOverview>(responseBody, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        MissingMemberHandling = MissingMemberHandling.Ignore
                    });

                    if(overview != null)
                    {
                        //基本信息
                        SymbolText.Text = overview.Symbol;
                        NameText.Text = overview.Name;
                        CikText.Text = overview.CIK;
                        IndustryText.Text = overview.Industry;
                        websiteText.Text = overview.OfficialSite;
                        DescriptionText.Text = overview.Description;
                        addressText.Text = overview.Address;

                        // 財務摘要
                        ListViewItem MarketCapital = new ListViewItem("市值");
                        MarketCapital.SubItems.Add($"{overview.MarketCapitalization:N0} USD");

                        ListViewItem EBITDA = new ListViewItem("息稅折舊及攤銷前利潤");
                        EBITDA.SubItems.Add($"{overview.EBITDA:N0} USD");

                        ListViewItem RevenueTTM = new ListViewItem("過去十二個月的收入");
                        RevenueTTM.SubItems.Add($"{overview.RevenueTTM:N0} USD");

                        ListViewItem GrossProfitTTM = new ListViewItem("過去十二個月的毛利潤");
                        GrossProfitTTM.SubItems.Add($"{overview.GrossProfitTTM:N0} USD");

                        ListViewItem ProfitMargin = new ListViewItem("利潤率");
                        ProfitMargin.SubItems.Add($"{overview.ProfitMargin:P2}");

                        ListViewItem OperatingMarginTTM = new ListViewItem("運營利潤率");
                        OperatingMarginTTM.SubItems.Add($"{overview.OperatingMarginTTM:P2}");

                        financialList.Items.Clear();
                        financialList.Items.Add(MarketCapital);
                        financialList.Items.Add(EBITDA);
                        financialList.Items.Add(RevenueTTM);
                        financialList.Items.Add(GrossProfitTTM);
                        financialList.Items.Add(ProfitMargin);
                        financialList.Items.Add(OperatingMarginTTM);

                        // 股票表現
                        ListViewItem perRatioItem = new ListViewItem("PERatio (價盈率)");
                        perRatioItem.SubItems.Add(overview.PERatio.ToString("N2"));

                        ListViewItem pegRatioItem = new ListViewItem("PEGRatio (價盈增長比率)");
                        pegRatioItem.SubItems.Add(overview.PEGRatio.ToString("N2"));

                        ListViewItem bookValueItem = new ListViewItem("BookValue (每股淨資產)");
                        bookValueItem.SubItems.Add(overview.BookValue.ToString("N2"));

                        ListViewItem dividendPerShareItem = new ListViewItem("DividendPerShare (每股股息)");
                        dividendPerShareItem.SubItems.Add(overview.DividendPerShare.ToString("N2"));

                        ListViewItem dividendYieldItem = new ListViewItem("DividendYield (股息率)");
                        dividendYieldItem.SubItems.Add($"{overview.DividendYield:P2}");  // 轉為百分比格式

                        ListViewItem epsItem = new ListViewItem("EPS (每股收益)");
                        epsItem.SubItems.Add(overview.EPS.ToString("N2"));

                        ListViewItem revenuePerShareTTMItem = new ListViewItem("RevenuePerShareTTM (過去12個月每股收入)");
                        revenuePerShareTTMItem.SubItems.Add(overview.RevenuePerShareTTM.ToString("N2"));

                        ListViewItem quarterlyEarningsGrowthYOYItem = new ListViewItem("QuarterlyEarningsGrowthYOY (季度盈利年增長率)");
                        quarterlyEarningsGrowthYOYItem.SubItems.Add($"{overview.QuarterlyEarningsGrowthYOY:P2}");

                        ListViewItem quarterlyRevenueGrowthYOYItem = new ListViewItem("QuarterlyRevenueGrowthYOY (季度收入年增長率)");
                        quarterlyRevenueGrowthYOYItem.SubItems.Add($"{overview.QuarterlyRevenueGrowthYOY:P2}");

                        ListViewItem analystTargetPriceItem = new ListViewItem("AnalystTargetPrice (分析師目標價)");
                        analystTargetPriceItem.SubItems.Add(overview.AnalystTargetPrice.ToString("C2"));  // 轉為貨幣格式

                        ListViewItem trailingPEItem = new ListViewItem("TrailingPE (滾動價盈率)");
                        trailingPEItem.SubItems.Add(overview.TrailingPE.ToString("N2"));

                        ListViewItem forwardPEItem = new ListViewItem("ForwardPE (預期價盈率)");
                        forwardPEItem.SubItems.Add(overview.ForwardPE.ToString("N2"));

                        ListViewItem priceToSalesRatioTTMItem = new ListViewItem("PriceToSalesRatioTTM (價銷比)");
                        priceToSalesRatioTTMItem.SubItems.Add(overview.PriceToSalesRatioTTM.ToString("N2"));

                        ListViewItem priceToBookRatioItem = new ListViewItem("PriceToBookRatio (價淨比)");
                        priceToBookRatioItem.SubItems.Add(overview.PriceToBookRatio.ToString("N2"));

                        StockList.Items.Clear();
                        StockList.Items.Add(perRatioItem);
                        StockList.Items.Add(pegRatioItem);
                        StockList.Items.Add(bookValueItem);
                        StockList.Items.Add(dividendPerShareItem);
                        StockList.Items.Add(dividendYieldItem);
                        StockList.Items.Add(epsItem);
                        StockList.Items.Add(revenuePerShareTTMItem);
                        StockList.Items.Add(quarterlyEarningsGrowthYOYItem);
                        StockList.Items.Add(quarterlyRevenueGrowthYOYItem);
                        StockList.Items.Add(analystTargetPriceItem);
                        StockList.Items.Add(trailingPEItem);
                        StockList.Items.Add(forwardPEItem);
                        StockList.Items.Add(priceToSalesRatioTTMItem);
                        StockList.Items.Add(priceToBookRatioItem);


                        //市場表現
                        // 創建市場表現 ListViewItems
                        ListViewItem analystRatingStrongBuyItem = new ListViewItem("強烈買入評級");
                        analystRatingStrongBuyItem.SubItems.Add(overview.AnalystRatingStrongBuy.ToString());

                        ListViewItem analystRatingBuyItem = new ListViewItem("買入評級");
                        analystRatingBuyItem.SubItems.Add(overview.AnalystRatingBuy.ToString());

                        ListViewItem analystRatingHoldItem = new ListViewItem("持有評級");
                        analystRatingHoldItem.SubItems.Add(overview.AnalystRatingHold.ToString());

                        ListViewItem analystRatingSellItem = new ListViewItem("賣出評級");
                        analystRatingSellItem.SubItems.Add(overview.AnalystRatingSell.ToString());

                        ListViewItem analystRatingStrongSellItem = new ListViewItem("強烈賣出評級");
                        analystRatingStrongSellItem.SubItems.Add(overview.AnalystRatingStrongSell.ToString());

                        ListViewItem week52HighItem = new ListViewItem("52周最高價");
                        week52HighItem.SubItems.Add(overview.High52Week.ToString("N2"));

                        ListViewItem week52LowItem = new ListViewItem("52周最低價");
                        week52LowItem.SubItems.Add(overview.Low52Week.ToString("N2"));

                        ListViewItem movingAverage50DayItem = new ListViewItem("50日移動平均");
                        movingAverage50DayItem.SubItems.Add(overview.MovingAverage50Day.ToString("N2"));

                        ListViewItem movingAverage200DayItem = new ListViewItem("200日移動平均");
                        movingAverage200DayItem.SubItems.Add(overview.MovingAverage200Day.ToString("N2"));

                        // 創建額外的 ListViewItems
                        ListViewItem betaItem = new ListViewItem("Beta (貝塔係數)");
                        betaItem.SubItems.Add(overview.Beta.ToString("N2"));

                        ListViewItem sharesOutstandingItem = new ListViewItem("Shares Outstanding (流通股數)");
                        sharesOutstandingItem.SubItems.Add(overview.SharesOutstanding.ToString("N0")); // 格式化為不帶小數的數字，並添加千位分隔符


                        // 添加到 AnalysList ListView
                        AnalysList.Items.Clear(); // 清除現有項目
                        AnalysList.Items.Add(analystRatingStrongBuyItem);
                        AnalysList.Items.Add(analystRatingBuyItem);
                        AnalysList.Items.Add(analystRatingHoldItem);
                        AnalysList.Items.Add(analystRatingSellItem);
                        AnalysList.Items.Add(analystRatingStrongSellItem);
                        AnalysList.Items.Add(week52HighItem);
                        AnalysList.Items.Add(week52LowItem);
                        AnalysList.Items.Add(movingAverage50DayItem);
                        AnalysList.Items.Add(movingAverage200DayItem);
                        AnalysList.Items.Add(betaItem);
                        AnalysList.Items.Add(sharesOutstandingItem);

                        //投資者資訊
                        // 創建投資者資訊 ListViewItems
                        ListViewItem dividendDateItem = new ListViewItem("DividendDate (分紅支付日期)");
                        dividendDateItem.SubItems.Add(overview.DividendDate.ToShortDateString());  // 轉換為短日期格式

                        ListViewItem exDividendDateItem = new ListViewItem("ExDividendDate (除息日期)");
                        exDividendDateItem.SubItems.Add(overview.ExDividendDate.ToShortDateString());  // 轉換為短日期格式

                        ListViewItem evToRevenueItem = new ListViewItem("EVToRevenue (企業價值對比收入)");
                        evToRevenueItem.SubItems.Add(overview.EVToRevenue.ToString("N2"));  // 格式化數字

                        ListViewItem evToEBITDAItem = new ListViewItem("EVToEBITDA (企業價值對比EBITDA)");
                        evToEBITDAItem.SubItems.Add(overview.EVToEBITDA.ToString("N2"));  // 格式化數字

                        // 添加到 InvestorList ListView
                        InvestorList.Items.Clear();  // 清除現有項目
                        InvestorList.Items.Add(dividendDateItem);
                        InvestorList.Items.Add(exDividendDateItem);
                        InvestorList.Items.Add(evToRevenueItem);
                        InvestorList.Items.Add(evToEBITDAItem);
                    }
                    else
                    {
                        MessageBox.Show("無法解析公司概覽數據。");
                    }
                }
                catch (JsonException ex)
                {
                    MessageBox.Show($"解析數據時出錯: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("數據獲取失敗！");
            }
        }


        private class SearchData
        {
            [JsonProperty("bestMatches")]
            public List<BestMatch> BestMatches { get; set; }
        }

        public class CompanyOverview
        {
            public string Symbol { get; set; }
            public string AssetType { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string CIK { get; set; }
            public string Exchange { get; set; }
            public string Currency { get; set; }
            public string Country { get; set; }
            public string Sector { get; set; }
            public string Industry { get; set; }
            public string Address { get; set; }
            public string OfficialSite { get; set; }
            public string FiscalYearEnd { get; set; }
            public string LatestQuarter { get; set; }
            public long MarketCapitalization { get; set; }
            public long EBITDA { get; set; }
            public decimal PERatio { get; set; }
            public decimal PEGRatio { get; set; }
            public decimal BookValue { get; set; }
            public decimal DividendPerShare { get; set; }
            public decimal DividendYield { get; set; }
            public decimal EPS { get; set; }
            public decimal RevenuePerShareTTM { get; set; }
            public decimal ProfitMargin { get; set; }
            public decimal OperatingMarginTTM { get; set; }
            public decimal ReturnOnAssetsTTM { get; set; }
            public decimal ReturnOnEquityTTM { get; set; }
            public long RevenueTTM { get; set; }
            public long GrossProfitTTM { get; set; }
            public decimal DilutedEPSTTM { get; set; }
            public decimal QuarterlyEarningsGrowthYOY { get; set; }
            public decimal QuarterlyRevenueGrowthYOY { get; set; }
            public decimal AnalystTargetPrice { get; set; }
            public int AnalystRatingStrongBuy { get; set; }
            public int AnalystRatingBuy { get; set; }
            public int AnalystRatingHold { get; set; }
            public int AnalystRatingSell { get; set; }
            public int AnalystRatingStrongSell { get; set; }
            public decimal TrailingPE { get; set; }
            public decimal ForwardPE { get; set; }
            public decimal PriceToSalesRatioTTM { get; set; }
            public decimal PriceToBookRatio { get; set; }
            public decimal EVToRevenue { get; set; }
            public decimal EVToEBITDA { get; set; }
            public decimal Beta { get; set; }
            public decimal High52Week { get; set; }
            public decimal Low52Week { get; set; }
            public decimal MovingAverage50Day { get; set; }
            public decimal MovingAverage200Day { get; set; }
            public long SharesOutstanding { get; set; }
            public DateTime DividendDate { get; set; }
            public DateTime ExDividendDate { get; set; }
        }


        private class BestMatch
        {
            [JsonProperty("1. symbol")]
            public string Symbol { get; set; }
            [JsonProperty("2. name")]
            public string Name { get; set; }
            [JsonProperty("3. type")]
            public string Type { get; set; }
            [JsonProperty("4. region")]
            public string Region { get; set; }
            [JsonProperty("5. marketOpen")]
            public string MarketOpen { get; set; }
            [JsonProperty("6. marketClose")]
            public string MarketClose { get; set; }
            [JsonProperty("7. timezone")]
            public string Timezone { get; set; }
            [JsonProperty("8. currency")]
            public string Currency { get; set; }
            [JsonProperty("9. matchScore")]
            public string MatchScore { get; set; }
        }

        private async void stockDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on the row header or a specific column
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Assuming the symbol is in the first column, adjust the index if necessary
                string symbol = stockDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                await FetchCompanyOverview(symbol);
            }
        }

        private async void stockDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on the row header or a specific column
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Assuming the symbol is in the first column, adjust the index if necessary
                string symbol = stockDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                await FetchCompanyOverview(symbol);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (stockDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = stockDataGridView.SelectedRows[0].Index;
                string symbol = stockDataGridView.Rows[selectedIndex].Cells["Symbol"].Value.ToString();

                if (!string.IsNullOrEmpty(symbol))
                {
                    // 執行刪除操作
                    DeleteStockFromDatabase(symbol);

                    // 從 DataGridView 中移除行
                    stockDataGridView.Rows.RemoveAt(selectedIndex);
                }
            }
            else
            {
                MessageBox.Show("請選擇一行以進行刪除。");
            }
        }

        private async Task DeleteStockFromDatabase(string symbol)
        {
            string connectionString = "Server=localhost; Database=StockData; Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Stocks WHERE Symbol = @Symbol";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Symbol", symbol);
                    connection.Open();
                    int result = await command.ExecuteNonQueryAsync();
                    if (result > 0)
                    {
                        MessageBox.Show("股票已成功刪除。");
                    }
                    else
                    {
                        MessageBox.Show("刪除失敗，股票可能已被刪除或不存在。");
                    }
                }
            }
        }

        private async void searchBox_TextChanged(object sender, EventArgs e)
        {
            if(searchBox.Text == "")
            {
                resultsBox.Visible = false;
            }
            else
            {
                await PerformSearchAsync(searchBox.Text);
            }
            
        }


    }
}
