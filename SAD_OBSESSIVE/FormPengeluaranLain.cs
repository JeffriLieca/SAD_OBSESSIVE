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



    public partial class FormPengeluaranLain : Form
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
        public DataTable dtPLain = new DataTable();
        public int index=0;
        public string KatSekarang = "";
        public int stock = 0;
        public static string passingId { get; set; }
        public FormPengeluaranLain()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {

            LoadProduct();
            Load_Filter_Ket();
        }
        private void LoadProduct()
        {
            sqlConnect.Open();
            dtPLain = new DataTable();

            sqlCommand = new MySqlCommand("pFilterPengeluaranLain", sqlConnect);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("parLuar", cBoxKet.Text);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPLain);
            dgvLain.DataSource = dtPLain;
            sqlConnect.Close();
            sqlCommand.CommandType = CommandType.Text;
            dgvLain.Columns["Nama"].Width = 200;
            dgvLain.Columns["Keterangan"].Width = 150;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (passingId != "")
            {

                DialogResult drDelete = MessageBox.Show("Confirm to delete?", "Delete", MessageBoxButtons.YesNo);
                if (drDelete == DialogResult.Yes)
                {
                    sqlConnect.Open();
                    sqlQuery = $"insert into PENGELUARAN values(null, '{passingId}',null, null, '{dtPLain.Rows[index][1].ToString()}', {Convert.ToInt32(dtPLain.Rows[index][4].ToString())*-1}, '{dtPLain.Rows[index][3].ToString()}', null, '{DateTime.Now.ToString("yyyy-MM-dd")}', 0); ";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();

                    sqlQuery = "update PENGELUARAN_LAIN_LAIN set STATUS_DELETE_PENGELUARAN_LAIN= '1' where ID_PENGELUARAN_LAIN = '" + passingId + "' ;";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();

                    sqlConnect.Close();
                    passingId = "";
                    LoadProduct();
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang mau di delete");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (passingId != "")
            {


                try
                {
                    FormEditPengeluaranLain formEditPengeluaranLain = new FormEditPengeluaranLain();
                    formEditPengeluaranLain.PerformForm1Click += new EventHandler(frm2_PerformForm1Click);
                    formEditPengeluaranLain.ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("Eror");
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang mau diedit");
            }
        }

        private void dgvInvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                index = e.RowIndex;
                DataGridViewRow selectedRow = dgvLain.Rows[index];
                passingId = dtPLain.Rows[index][0].ToString();
                
            }
            catch (Exception)
            {

            }

        }

       
        private void Load_Filter_Ket()
        {
            cBoxKet.Items.Clear();
            DataTable dtKet = new DataTable();
            sqlQuery = $"select distinct KETERANGAN_PENGELUARAN_LAIN from PENGELUARAN_LAIN_LAIN where STATUS_DELETE_PENGELUARAN_LAIN=0;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtKet);
            cBoxKet.Items.Add("");
            for (int i = 0; i < dtKet.Rows.Count; i++)
            {
                cBoxKet.Items.Add(dtKet.Rows[i][0].ToString());
            }

        }
        

     

        

       

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddProduct formAddProduct = new FormAddProduct();
            formAddProduct.Show();
        }

      
        public void FormMarketing_Load(object sender, EventArgs e)
        {
            LoadProduct();
            Load_Filter_Ket();
            BuatButton();
            buttonExpenses.Enabled = false;

            passingId = "";
            
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            FormAddPengeluaranLain formAddPengeluaranLain = new FormAddPengeluaranLain();
            formAddPengeluaranLain.PerformForm1Click += new EventHandler(frm2_PerformForm1Click);
            formAddPengeluaranLain.ShowDialog();
        }
        

        private void frm2_PerformForm1Click(object sender, EventArgs e)
        {
            LoadProduct();
            Load_Filter_Ket();

            passingId = "";
            
        }

        private void cBoxKet_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProduct();
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
