using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAD_OBSESSIVE.Db;
using MySql.Data.MySqlClient;
using System.IO;

namespace SAD_OBSESSIVE
{



    public partial class FormDisplay : Form
    {
        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_Obsessive";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        public DataTable dtProduct = new DataTable();
        public int index=0;
        public string KatSekarang = "";
        public int stock = 0;
        public static string passingId { get; set; }
        public FormDisplay()
        {
            InitializeComponent();
            cBoxVol.Enabled = false;
            LoadProduct();
            LoadGambar();
            Load_Filter_Kat();
            Load_Filter_Vol();

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {

            cBoxVol.Enabled = false;
            LoadProduct();
            LoadGambar();
            Load_Filter_Kat();
            Load_Filter_Vol();
        }
        private void LoadProduct()
        {
            sqlConnect.Open();
            dtProduct = new DataTable();

            sqlCommand = new MySqlCommand("pFilterSearchProduk",sqlConnect);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("parNamaProd", textBoxSearchProd.Text);
            sqlCommand.Parameters.AddWithValue("parNamaKat", cBoxKategori.Text);
            sqlCommand.Parameters.AddWithValue("parVol", cBoxVol.Text);
            sqlCommand.Parameters.AddWithValue("parSize", cBoxSize.Text);
            sqlCommand.Parameters.AddWithValue("parStok", stock);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtProduct);
            dgvInvent.DataSource = dtProduct;
            dgvInvent.Columns.Remove("ID");
            dgvInvent.Columns[2].Width = 40;
            dgvInvent.Columns[3].Width = 40;
            dgvInvent.Columns[4].Width = 40;
            sqlConnect.Close();
            sqlCommand.CommandType = CommandType.Text;


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult drDelete = MessageBox.Show("Confirm to delete?", "Delete", MessageBoxButtons.YesNo);
            if (drDelete == DialogResult.Yes)
            {
                sqlConnect.Open();
                sqlQuery = "update PRODUK set STATUS_DELETE_PENGELUARAN_LAIN = '1' where ID_PRODUK = '" + dtProduct.Rows[index][0] + "' ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormInsertProduct formInsertProduct = new FormInsertProduct();
            formInsertProduct.Show();
        }
        public void LoadGambar()
        {
            string imgLocation = "";
            sqlConnect.Open();
            sqlQuery = "select GAMBAR from PRODUK where ID_PRODUK='" + dtProduct.Rows[index][0] + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dtCoba = new DataTable();
            sqlAdapter.Fill(dtCoba);
            //byte[] images = ((byte[])dtCoba.Rows[0][0]);
            //MemoryStream mstream = new MemoryStream(images);
            //pictureBoxProd.Image = Image.FromStream(mstream);
            sqlConnect.Close();
        }

        private void dgvInvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow selectedRow = dgvInvent.Rows[index];
            passingId = dtProduct.Rows[index][0].ToString();
            label7.Text = passingId.ToString();

        }

        private void cBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxKategori.Text == "")
            {
                cBoxVol.Enabled = false;
            }
            else
            {
                cBoxVol.Enabled=true;
            }
            Load_Filter_Vol();
            LoadProduct();
        }
        private void Load_Filter_Kat()
        {
            cBoxKategori.Items.Clear();
            DataTable dtKat = new DataTable();
            sqlQuery = $"select distinct NAMA_KATEGORI from KATEGORI;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtKat);
            cBoxKategori.Items.Add("");
            for (int i = 0; i < dtKat.Rows.Count; i++)
            {
                cBoxKategori.Items.Add(dtKat.Rows[i][0].ToString());
            }

        }
        private void Load_Filter_Vol()
        {
            cBoxVol.Items.Clear();
            DataTable dtVol = new DataTable();
            sqlQuery = $"select VOLUME from KATEGORI where substring(ID_KATEGORI,1,2)=fNamaKat('{cBoxKategori.Text}');";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtVol);
            cBoxVol.Items.Add("");
            for (int i = 0; i < dtVol.Rows.Count; i++)
            {
                cBoxVol.Items.Add(dtVol.Rows[i][0].ToString());
            }
        }

        private void cBoxVol_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void cBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void textBoxSearchProd_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void tBStok_TextChanged(object sender, EventArgs e)
        {
            if (tBStok.Text == "")
            {
                stock=0;
            }
            else
            {
                stock = Convert.ToInt32(tBStok.Text);
            }
            LoadProduct();
        }

        private void FormDisplay_Load(object sender, EventArgs e)
        {
            cBoxVol.Enabled = false;
            LoadProduct();
            LoadGambar();
            Load_Filter_Kat();
            Load_Filter_Vol();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddProduct formAddProduct = new FormAddProduct();
            formAddProduct.Show();
        }
    }
}
