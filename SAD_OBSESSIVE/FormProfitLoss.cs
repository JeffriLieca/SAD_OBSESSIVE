using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SAD_OBSESSIVE
{
    public partial class FormProfitLoss : Form
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
        public DataTable dtProfitLoss = new DataTable();
        public DataTable dtDetailPenjualan = new DataTable();
        public int index = 0;
        public string KatSekarang = "";
        public int stock = 0;
        public string ID = "";
        public FormProfitLoss()
        {
            InitializeComponent();
        }

        private void FormProfitLoss_Load(object sender, EventArgs e)
        {
            LoadDTPAwal();
            LoadDGV();
            LoadTotal();
            BuatButton();
            buttonProfitLoss.Enabled = false;
            ButtonOke.Visible = true;
            panelReport.Visible = true;
        }
        private void LoadDGV()
        {
            dtProfitLoss = new DataTable();
            sqlCommand = new MySqlCommand("pPanggilView", sqlConnect);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("grupnya", cBoxGrup.Text);
            sqlCommand.Parameters.AddWithValue("tgl_awal", dTPAwal.Value.ToString("yyyy-MM-dd"));
            sqlCommand.Parameters.AddWithValue("tgl_akhir", dTPAkhir.Value.ToString("yyyy-MM-dd"));
            sqlCommand.Parameters.AddWithValue("parNama", cBoxKategori.Text);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtProfitLoss);
            dGVProfitLoss.DataSource = dtProfitLoss;
            sqlConnect.Close();
            sqlCommand.CommandType = CommandType.Text;
        }
        private void LoadDTPAwal()
        {
            try
            {
                DataTable dtAwal = new DataTable();
                sqlInsert = "select fCariTanggalAwal();";
                sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtAwal);
                dGVProfitLoss.DataSource = dtAwal;
                string tanggal = dtAwal.Rows[0][0].ToString();
                dTPAwal.Value = DateTime.Parse(tanggal);
            }
            catch (Exception)
            {

            }
        }
        private void LoadTotal()
        {
            sqlConnect.Open();
            sqlInsert = $"select fTotalLossProduk('{dTPAwal.Value.ToString("yyyy-MM-dd")}','{dTPAkhir.Value.ToString("yyyy-MM-dd")}');";
            sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
            labelProd.Text = sqlCommand.ExecuteScalar().ToString();

            sqlInsert = $"select fTotalLossMarketing('{dTPAwal.Value.ToString("yyyy-MM-dd")}','{dTPAkhir.Value.ToString("yyyy-MM-dd")}');";
            sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
            labelMark.Text = sqlCommand.ExecuteScalar().ToString();

            sqlInsert = $"select fTotalLossLain('{dTPAwal.Value.ToString("yyyy-MM-dd")}','{dTPAkhir.Value.ToString("yyyy-MM-dd")}');";
            sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
            labelLain.Text = sqlCommand.ExecuteScalar().ToString();

            sqlInsert = $"select fTotalProfitProduk('{dTPAwal.Value.ToString("yyyy-MM-dd")}','{dTPAkhir.Value.ToString("yyyy-MM-dd")}');";
            sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
            labelProf.Text = sqlCommand.ExecuteScalar().ToString();

            sqlInsert = $"select fTotalProfitLoss('{dTPAwal.Value.ToString("yyyy-MM-dd")}','{dTPAkhir.Value.ToString("yyyy-MM-dd")}');";
            sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
            labelProfLoss.Text = sqlCommand.ExecuteScalar().ToString();
            sqlConnect.Close();

            labelTanggal.Text = $"{dTPAwal.Value.ToString("dd MMMM yyyy")} - {dTPAkhir.Value.ToString("dd MMMM yyyy")}";
        }

        private void dTPAwal_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dTPAkhir_ValueChanged(object sender, EventArgs e)
        {
        }

        private void cBoxGrup_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDGV();
            LoadTotal();
        }

        private void cBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDGV();
            LoadTotal();
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

        private void dGVProfitLoss_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonOke_Click(object sender, EventArgs e)
        {

            LoadDGV();
            LoadTotal();
        }
    }
}
