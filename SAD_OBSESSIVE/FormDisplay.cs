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
using System.Runtime.InteropServices;
using System.Threading;

namespace SAD_OBSESSIVE
{



    public partial class FormDisplay : Form
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
        public DataTable dtProduct = new DataTable();
        public int index=0;
        public string KatSekarang = "";
        public int stock = 0;
        public static string passingId { get; set; }
        public FormDisplay()
        {
            InitializeComponent();
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
            sqlConnect.Close();
            dgvInvent.Columns["Kategori"].Width = 200;
            dgvInvent.Columns["Nama"].Width = 180;
            dgvInvent.Columns["Size"].Width = 50;
            dgvInvent.Columns["Size"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInvent.Columns["Vol"].Width = 50;
            dgvInvent.Columns["Stock"].Width = 50;
            dgvInvent.Columns["Vol"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInvent.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            sqlCommand.CommandType = CommandType.Text;
            

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (passingId != "")
            {
                DialogResult drDelete = MessageBox.Show("Confirm to delete?", "Delete", MessageBoxButtons.YesNo);
                if (drDelete == DialogResult.Yes)
                {
                    sqlConnect.Open();
                    sqlQuery = "update PRODUK set STATUS_DELETE_PENGELUARAN_LAIN = '1' where ID_PRODUK = '" + dtProduct.Rows[index][0] + "' ";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                    passingId = "";
                    MessageBox.Show("Data berhasil di delete");
                    LoadProduct();
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang mau didelete");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (passingId != "")
            {

                FormInsertProduct formInsertProduct = new FormInsertProduct();
                formInsertProduct.PerformForm1Click += new EventHandler(frm2_PerformForm1Click);
                formInsertProduct.ShowDialog();
            }
            else
            {
                MessageBox.Show("Pilih data yang mau diedit");
            }
        }

        private void FormInsertProduct_PerformForm1Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void dgvInvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                index = e.RowIndex;
                DataGridViewRow selectedRow = dgvInvent.Rows[index];
                passingId = dtProduct.Rows[index][0].ToString();
                
            }
            catch (Exception)
            {
            }

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
            BuatButton();
            cBoxVol.Enabled = false;
            LoadProduct();
            Load_Filter_Kat();
            Load_Filter_Vol();
            passingId = "";
            buttonInventory.Enabled = false;
            
        }


        private void frm2_PerformForm1Click(object sender, EventArgs e)
        {
            LoadProduct();
            passingId = "";
            
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddProduct formAddProduct = new FormAddProduct();
            formAddProduct.PerformForm1Click += new EventHandler(frm2_PerformForm1Click);
            formAddProduct.ShowDialog();
        }

        private void tBStok_KeyPress(object sender, KeyPressEventArgs e)
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

        private void buttonOrder_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormOrder formOrder = new FormOrder();
            formOrder.ShowDialog();
            this.Close();
        }

        private void buttonInventory_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormDisplay formDisplay = new FormDisplay();
            formDisplay.ShowDialog();
            this.Close();
        }

        private void buttonExpenses_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormPengeluaranLain formPengeluaranLain = new FormPengeluaranLain();
            formPengeluaranLain.ShowDialog();
            this.Close();
        }

        private void buttonMarketing_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormMarketing formMarketing = new FormMarketing();
            formMarketing.ShowDialog();
            this.Close();
        }

        private void buttonProfitLoss_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormProfitLoss formProfitLoss = new FormProfitLoss();
            formProfitLoss.ShowDialog();
            this.Close();
        }

        private void buttonChart_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formChart = new Form1();
            formChart.ShowDialog();
            this.Close();
        }
    }
}
