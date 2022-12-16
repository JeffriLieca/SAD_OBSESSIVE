using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SAD_OBSESSIVE
{
    
    public partial class FormHistory : Form
    {
        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_Obsessive";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        public string sqlInsert;
        public DataTable dtPenjualan = new DataTable();
        public DataTable dtDetailPenjualan = new DataTable();
        public int index = 0;
        public string KatSekarang = "";
        public int stock = 0;
        public string ID = "";
        public FormHistory()
        {
            InitializeComponent();
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            LoadPenjualan();
            this.BackColor = ColorTranslator.FromHtml("#C38E6C");
        }
        public event EventHandler PerformForm1Click;

        private void LoadAwal()
        {
            EventHandler handler = this.PerformForm1Click;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }
        private void LoadPenjualan()
        {
            dtPenjualan = new DataTable();
            sqlConnect.Open();
            sqlQuery = "select ID_PENJUALAN as ID,date_format(TANGGAL_PENJUALAN,'%d %M %Y') as Tanggal, JML_ITEM_PENJUALAN as 'Jumlah Item', TOTAL_PENJUALAN as Total from PENJUALAN where STATUS_DELETE_PENJUALAN=0 order by TANGGAL_PENJUALAN desc; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPenjualan);
            dGVPenjualan.DataSource = dtPenjualan;
            sqlConnect.Close();
        }

        private void dGVPenjualan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                ID = dtPenjualan.Rows[index][0].ToString();
                LoadDetailPenjualan();

            }
            catch (Exception)
            {
            }
        }
        private void LoadDetailPenjualan()
        {
            dtDetailPenjualan = new DataTable();
            sqlConnect.Open();
            sqlQuery = $"select d.ID_PENJUALAN ID,p.ID_PRODUK,p.NAMA_PRODUK as Nama, concat(k.NAMA_KATEGORI,' Vol.',k.VOLUME)as Edisi,d.JML_PRODUK as Jumlah,d.HARGA_JUAL_PRODUK as Harga,d.SUBTOTAL_JUAL_PRODUK as Subtotal from DETAIL_PENJUALAN d, PRODUK p, KATEGORI  k where d.ID_PRODUK = p.ID_PRODUK and p.ID_KATEGORI = k.ID_KATEGORI and d.ID_PENJUALAN = '{ID}' and STATUS_DELETE_DETAIL=0; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDetailPenjualan);
            dGVDetail.DataSource = dtDetailPenjualan;
            dGVDetail.Columns.Remove("ID_PRODUK");
            sqlConnect.Close();
        }

        private void buttonRefund_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {

                sqlConnect.Open();
                sqlQuery = $"update PENJUALAN set STATUS_DELETE_PENJUALAN=1 where ID_PENJUALAN='{ID}'; ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlQuery = $"update DETAIL_PENJUALAN set STATUS_DELETE_DETAIL=1 where ID_PENJUALAN='{ID}'; ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();

                for (int i = 0; i < dtDetailPenjualan.Rows.Count; i++)
                {
                    sqlQuery = $"update PRODUK set STOK_SISA=STOK_SISA+{dtDetailPenjualan.Rows[i][4].ToString()} where ID_PRODUK='{dtDetailPenjualan.Rows[i][1].ToString()}'; ";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                }

                sqlConnect.Close();
                LoadPenjualan();
                LoadDetailPenjualan();
                MessageBox.Show($"Penjualan {ID} telah di refund");
                ID = "";
            }
            else
            {
                MessageBox.Show("belum ada data terpilih");
            }

        }

        private void roundButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            LoadAwal();

        }

        private void FormHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadAwal();
        }
    }
}
