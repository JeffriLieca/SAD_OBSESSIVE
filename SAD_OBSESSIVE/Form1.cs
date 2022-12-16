//using SAD_OBSESSIVE.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace SAD_OBSESSIVE
{

    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeft,
            int nTop,
            int nRight,
            int nBotto,
            int nWidthEllipse,
            int nHeightEllipse);
        private void BuatButton()
        {
            buttonHome.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonHome.Width, buttonHome.Height, 30, 30));
            buttonOrder.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonHome.Width, buttonHome.Height, 30, 30));
            buttonInventory.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonHome.Width, buttonHome.Height, 30, 30));
            buttonExpenses.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonHome.Width, buttonHome.Height, 30, 30));
            buttonMarketing.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonHome.Width, buttonHome.Height, 30, 30));
            buttonProfitLoss.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonHome.Width, buttonHome.Height, 30, 30));
            buttonChart.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonHome.Width, buttonHome.Height, 30, 30));
            panel7.BackColor = ColorTranslator.FromHtml("#6B3D20");
            panel8.BackColor = ColorTranslator.FromHtml("#6B3D20");
            this.BackColor = ColorTranslator.FromHtml("#C38E6C");
        }

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_Obsessive";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        public string sqlInsert;
        public DataTable dtChart = new DataTable();
        public DataTable dtChart2 = new DataTable();
        public DataTable dtDataChart = new DataTable();
        public DataTable dtDataChartKanan = new DataTable();
        public int index = 0;
        public int index2 = 0;
        public string KatSekarang = "";
        public int stock = 0;
        public string ID = "";
        //private Dashboard model;
        public Form1()
        {
            InitializeComponent();

            //Default - Last 7 days
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Today;
            buttonLast7Days.Select();
            

            //model = new Dashboard();
            LoadData();
        }

        //Private methods
        private void LoadData()
        {
            //var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            //if (refreshData == true)
            //{
            //labelNumOrders.Text = model.NumPenjualan.ToString();
            //labelTotalRev.Text = model.TotalRevenue.ToString();
            //labelTotalPro.Text = model.TotalProfit.ToString();

            //labelTotProduct.Text = model.NumProduk.ToString();
            //labelTotStock.Text = model.NumStock.ToString();
            //labelTotTerjual.Text = model.NumProdukTerjual.ToString();

            //chartKiri.DataSource = model.GrossRevenueList;
            //chartKiri.Series[0].XValueMember = "Date";
            //chartKiri.Series[0].YValueMembers = "TotalAmount";
            //chartKiri.DataBind();

            //chartKanan.DataSource = model.TopProductsList;
            //chartKanan.Series[0].XValueMember = "Key";
            //chartKanan.Series[0].YValueMembers = "Value";
            //chartKanan.DataBind();

            //    Console.WriteLine("Loaded view :)");
            //}
            //else Console.WriteLine("view not loaded, same query");

            sqlConnect.Open();
            sqlInsert = $"select fHitungJumlahPenjualan('{dtpStartDate.Value.ToString("yyyy-MM-dd")}','{dtpEndDate.Value.ToString("yyyy-MM-dd")}');";
            sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
            labelNumOrders.Text = sqlCommand.ExecuteScalar().ToString();

            sqlInsert = $"select fHitungProduk();";
            sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
            labelTotProduct.Text = sqlCommand.ExecuteScalar().ToString();

            sqlInsert = $"select fHitungStokSisaProduk();";
            sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
            labelTotStock.Text = sqlCommand.ExecuteScalar().ToString();

            sqlInsert = $"select fHitungJumlahBajuTerjual();";
            sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
            labelTotTerjual.Text = sqlCommand.ExecuteScalar().ToString();

            sqlInsert = $"select fTotalProfitLoss('{dtpStartDate.Value.ToString("yyyy-MM-dd")}','{dtpEndDate.Value.ToString("yyyy-MM-dd")}');";
            sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
            labelTotalPro.Text = sqlCommand.ExecuteScalar().ToString();

            sqlInsert = $"select fTotalProfitProduk('{dtpStartDate.Value.ToString("yyyy-MM-dd")}','{dtpEndDate.Value.ToString("yyyy-MM-dd")}');";
            sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
            labelTotalRev.Text = sqlCommand.ExecuteScalar().ToString();

            sqlConnect.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCBChartKiri();
            LoadFilter();
            LoadIsiChartKiri();
            LoadCBChartKanan();
            LoadIsiChartKanan();
            cBBy.SelectedIndex = 0;
            LoadData();
            BuatButton();
            buttonChart.Enabled = false;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            LoadIsiChartKanan();
            LoadIsiChartKiri();
            LoadData();

        }
        private void LoadChart()
        {

        }

        private void LoadCBChartKiri()
        {
            dtChart = new DataTable();
            sqlInsert = "select ID_CHART as ID, NAMA_CHART as Nama,BENTUK_CHART_DEF as Def,PARAMETER as Parameter,`CALL` as `Call` from CHART_FORMAT where substring(ID_CHART,1,2)='KI';";
            sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtChart);
            cBChartName.DataSource = dtChart;
            cBChartName.DisplayMember = dtChart.Columns["Nama"].ToString();
            cBChartName.ValueMember = dtChart.Columns["ID"].ToString();

            cBoxTypeKiri.Text = dtChart.Rows[index][2].ToString();
            TipeKiri();
        }

        private void LoadCBChartKanan()
        {
            dtChart2 = new DataTable();
            sqlInsert = "select ID_CHART as ID, NAMA_CHART as Nama,BENTUK_CHART_DEF as Def,PARAMETER as Parameter,`CALL` as `Call` from CHART_FORMAT where substring(ID_CHART,1,2)='KA';";
            sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtChart2);
            cBChartKanan.DataSource = dtChart2;
            cBChartKanan.DisplayMember = dtChart2.Columns["Nama"].ToString();
            cBChartKanan.ValueMember = dtChart2.Columns["ID"].ToString();

            cBoxTypeKanan.Text = dtChart2.Rows[index][2].ToString();
            TipeKanan();
        }
        private void cBoxGrup_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIsiChartKiri();
        }

        private void cBChartName_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = cBChartName.SelectedIndex;
            cBoxGrup.Text = "";
            cBparBy.Text = "Click";
            cBparJenis.Text = "";
            LoadFilter();
            LoadIsiChartKiri();
            cBoxTypeKiri.Text = dtChart.Rows[index][2].ToString();
            TipeKiri();

        }
        private void LoadFilter()
        {
            cBoxGrup.Text = "";
            cBparBy.Text = "Click";
            cBparJenis.Text = "";
            cBparBy.Visible = false;
            cBparJenis.Visible = false;
            if (dtChart.Rows[index][3].ToString().Contains("parJenis"))
            {
                label13.Visible = true;
                cBparJenis.Visible = true;
            }
            else if (dtChart.Rows[index][3].ToString().Contains("parBy"))
            {
                label13.Visible = true;
                cBparBy.Visible = true;
            }
            else
            {
                label13.Visible = false;
                cBparBy.Visible = false;
                cBparJenis.Visible = false;
            }
        }

        private void LoadIsiChartKiri()
        {
            try
            {
                chartKiri.Series[0].Points.Clear();
                //sqlConnect.Open();
                dtDataChart = new DataTable();
                sqlCommand = new MySqlCommand(dtChart.Rows[index][4].ToString(), sqlConnect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("grupnya", cBoxGrup.Text);
                sqlCommand.Parameters.AddWithValue("tgl_awal", dtpStartDate.Value.ToString("yyyy-MM-dd"));
                sqlCommand.Parameters.AddWithValue("tgl_akhir", dtpEndDate.Value.ToString("yyyy-MM-dd"));
                if (dtChart.Rows[index][3].ToString().Contains("parJenis"))
                {
                    sqlCommand.Parameters.AddWithValue("parJenis", cBparJenis.Text);
                }
                else if (dtChart.Rows[index][3].ToString().Contains("parBy"))
                {
                    sqlCommand.Parameters.AddWithValue("parBy", cBparBy.Text);
                }
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtDataChart);
                //dGVProfitLoss.DataSource = dtProfitLoss;

                //var reader = sqlCommand.ExecuteReader();
                //var resultTable = new List<KeyValuePair<string, decimal>>();
                //while (reader.Read())
                //{
                //    resultTable.Add(new KeyValuePair<string, decimal>(Convert.ToString(reader[0]), Convert.ToDecimal(reader[1])));

                //}
                //reader.Close();

                sqlConnect.Close();
                sqlCommand.CommandType = CommandType.Text;

                //foreach (var items in resultTable)
                //{

                //    ListChart.Add(new BuatIsiChart(items.Key, items.Value));

                //}

                labelTitleKiri.Text = dtChart.Rows[index][1].ToString().Substring(6);
                chartKiri.DataSource = dtDataChart;
                chartKiri.Series[0].XValueMember = dtDataChart.Columns[0].ToString();
                chartKiri.Series[0].YValueMembers = dtDataChart.Columns[1].ToString();
                chartKiri.DataBind();
                chartKiri.ChartAreas[0].AxisY.LabelStyle.Format = "{0:#,#}";
                //chartKiri.Titles.Add( dtChart.Rows[index][1].ToString());
                if (dtChart.Rows[index][2].ToString() == "Column")
                {
                    chartKiri.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                }
                else if (dtChart.Rows[index][2].ToString() == "Line")
                {
                    chartKiri.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                }
                else if (dtChart.Rows[index][2].ToString() == "Area")
                {
                    chartKiri.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
                }
                chartKiri.Series[0].Color = Color.Blue;
                foreach (var point in chartKiri.Series[0].Points)
                {
                    if (point.YValues[0] < 0)
                    {
                        point.Color = Color.Red;
                    }
                    else
                    {
                        point.Color = Color.Blue;
                    }
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void cBparBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIsiChartKiri();
        }

        

        private void cBparJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIsiChartKiri();
        }

        private void chartKanan_Click(object sender, EventArgs e)
        {

        }

        private void LoadIsiChartKanan()
        {
            try
            {
                chartKanan.Series[0].Points.Clear();
                //sqlConnect.Open();
                dtDataChartKanan = new DataTable();
                sqlCommand = new MySqlCommand(dtChart2.Rows[index2][4].ToString(), sqlConnect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (dtChart2.Rows[index2][3].ToString().Contains("awal"))
                {
                    sqlCommand.Parameters.AddWithValue("awal", dtpStartDate.Value.ToString("yyyy-MM-dd"));
                }
                if (dtChart2.Rows[index2][3].ToString().Contains("akhir"))
                {
                    sqlCommand.Parameters.AddWithValue("akhir", dtpEndDate.Value.ToString("yyyy-MM-dd"));
                }
                sqlCommand.Parameters.AddWithValue("lim", tBLimit.Text);
                if (dtChart2.Rows[index2][3].ToString().Contains("dari"))
                {
                    sqlCommand.Parameters.AddWithValue("dari", cBBy.Text);
                }
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtDataChartKanan);
                //dGVProfitLoss.DataSource = dtProfitLoss;

                //var reader = sqlCommand.ExecuteReader();
                //var resultTable = new List<KeyValuePair<string, decimal>>();
                //while (reader.Read())
                //{
                //    resultTable.Add(new KeyValuePair<string, decimal>(Convert.ToString(reader[0]), Convert.ToDecimal(reader[1])));

                //}
                //reader.Close();

                sqlConnect.Close();
                sqlCommand.CommandType = CommandType.Text;

                //foreach (var items in resultTable)
                //{

                //    ListChart.Add(new BuatIsiChart(items.Key, items.Value));

                //}
                labelTitleKanan.Text = "Top "+tBLimit.Text+" "+dtChart2.Rows[index2][1].ToString().Substring(10);
                chartKanan.DataSource = dtDataChartKanan;
                chartKanan.Series[0].XValueMember = dtDataChartKanan.Columns[1].ToString();
                chartKanan.Series[0].YValueMembers = dtDataChartKanan.Columns[2].ToString();
                chartKanan.DataBind();
                chartKanan.ChartAreas[0].AxisY.LabelStyle.Format = "{0:#,#}";
                //chartKiri.Titles.Add( dtChart.Rows[index][1].ToString());
                
                
            }
            catch (Exception)
            {

            }

        }

        private void cBChartKanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                index2 = cBChartKanan.SelectedIndex;
                if (dtChart2.Rows[index2][3].ToString().Contains("dari"))
                {
                    label15.Visible = true;
                    cBBy.Visible = true;
                    cBBy.SelectedIndex = 0;
                }
                else
                {
                    label15.Visible = false;
                    cBBy.Visible = false;
                }
                LoadIsiChartKanan();
                cBoxTypeKanan.Text = dtChart2.Rows[index2][2].ToString();
                TipeKanan();
            }
            catch (Exception)
            {

            }

            
        }

        private void cBBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIsiChartKanan();
        }

        private void tBLimit_TextChanged(object sender, EventArgs e)
        {
            LoadIsiChartKanan();
        }

        private void buttonToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
            buttonOK.Visible = false;
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            LoadIsiChartKanan();
            LoadIsiChartKiri();
            LoadData();
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtAwal = new DataTable();
                sqlInsert = "select fCariTanggalAwal();";
                sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtAwal);
                string tanggal = dtAwal.Rows[0][0].ToString();
                dtpStartDate.Value = DateTime.Parse(tanggal);
                dtpEndDate.Value = DateTime.Today;
            }
            catch (Exception)
            {

            }
            LoadIsiChartKanan();
            LoadIsiChartKiri();
            LoadData();
        }

        private void buttonLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Today;
            buttonOK.Visible = false;
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            LoadIsiChartKanan();
            LoadIsiChartKiri();
            LoadData();
        }

        private void buttonLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Today;
            buttonOK.Visible = false;
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            LoadIsiChartKanan();
            LoadIsiChartKiri();
            LoadData();
        }

        private void buttonCustom_Click(object sender, EventArgs e)
        {
            buttonOK.Visible = true;
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
        }

        private void cBoxTypeKanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipeKanan();
        }
        private void TipeKanan()
        {
            if (cBoxTypeKanan.Text == "Pyramid")
            {
                chartKanan.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            }
            else if (cBoxTypeKanan.Text == "Doughnut")
            {
                chartKanan.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            }
            else if (cBoxTypeKanan.Text == "Funnel")
            {
                chartKanan.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel;
            }
            else
            {
                chartKanan.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            }

        }
        private void TipeKiri()
        {
            if (cBoxTypeKiri.Text == "Bar")
            {
                chartKiri.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            }
            else if (cBoxTypeKiri.Text == "Line")
            {
                chartKiri.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }
            else if (cBoxTypeKiri.Text == "Area")
            {
                chartKiri.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            }
            else
            {
                chartKiri.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
        }

        private void cBoxTypeKiri_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipeKiri();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tBLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.ShowDialog();
            this.Close();
        }
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOrder formOrder = new FormOrder();
            formOrder.ShowDialog();
            this.Close();
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDisplay formDisplay = new FormDisplay();
            formDisplay.ShowDialog();
            this.Close();
        }

        private void buttonExpenses_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPengeluaranLain formPengeluaranLain = new FormPengeluaranLain();
            formPengeluaranLain.ShowDialog();
            this.Close();
        }

        private void buttonMarketing_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMarketing formMarketing = new FormMarketing();
            formMarketing.ShowDialog();
            this.Close();
        }

        private void buttonProfitLoss_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProfitLoss formProfitLoss = new FormProfitLoss();
            formProfitLoss.ShowDialog();
            this.Close();
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formChart = new Form1();
            formChart.ShowDialog();
            this.Close();
        }
    }
}
