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



    public partial class FormMarketing : Form
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
            button7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonHome.Width, buttonHome.Height, 30, 30));
            button5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonHome.Width, buttonHome.Height, 30, 30));
            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonHome.Width, buttonHome.Height, 30, 30));
            button6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonHome.Width, buttonHome.Height, 30, 30));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonHome.Width, buttonHome.Height, 30, 30));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonHome.Width, buttonHome.Height, 30, 30));
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonHome.Width, buttonHome.Height, 30, 30));
            panel7.BackColor = ColorTranslator.FromHtml("#6B3D20");
            panel8.BackColor = ColorTranslator.FromHtml("#6B3D20");
            this.BackColor = ColorTranslator.FromHtml("#C38E6C");
        }
        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_Obsessive";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        public DataTable dtMarketing = new DataTable();
        public int index=0;
        public string KatSekarang = "";
        public int stock = 0;
        public static string passingId { get; set; }
        public FormMarketing()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadProduct();
            Load_Filter_Plat();
        }
        private void LoadProduct()
        {
            sqlConnect.Open();
            dtMarketing = new DataTable();

            sqlCommand = new MySqlCommand("pFilterMarketing", sqlConnect);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("parPlat", cBoxPlat.Text);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMarketing);
            dgvMarketing.DataSource = dtMarketing;
            //dgvMarketing.Columns.Remove("ID_MARKETING");
            dgvMarketing.Columns["Nama Marketing"].Width = 200;
            dgvMarketing.Columns["View"].Width = 50;
            dgvMarketing.Columns["Reach"].Width = 50;
            dgvMarketing.Columns["Click"].Width = 50;
            sqlConnect.Close();
            sqlCommand.CommandType = CommandType.Text;
            passingId = "";
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (passingId != "")
            {

                DialogResult drDelete = MessageBox.Show("Confirm to delete?", "Delete", MessageBoxButtons.YesNo);
                if (drDelete == DialogResult.Yes)
                {
                    sqlConnect.Open();
                    sqlQuery = $"insert into PENGELUARAN() values(null, null, '{passingId}', null, '{dtMarketing.Rows[index][1].ToString()}', -1, '{dtMarketing.Rows[index][3].ToString()}', null, '{DateTime.Now.ToString("yyyy-MM-dd")}', 0); ";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();

                    sqlQuery = "update MARKETING set STATUS_DELETE_MARKETING= '1' where ID_MARKETING = '" + passingId + "' ;";
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
                    FormEditMarketing formEditMarketing = new FormEditMarketing();
                    formEditMarketing.PerformForm1Click += new EventHandler(frm2_PerformForm1Click);
                    formEditMarketing.ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("Pilih data yang mau diedit");
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
                passingId = dtMarketing.Rows[index][0].ToString();
            }
            catch (Exception)
            {
            }

        }

       
        private void Load_Filter_Plat()
        {
            cBoxPlat.Items.Clear();
            DataTable dtPlat = new DataTable();
            sqlQuery = $"select distinct PLATFORM from MARKETING where STATUS_DELETE_MARKETING=0;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlat);
            cBoxPlat.Items.Add("");
            for (int i = 0; i < dtPlat.Rows.Count; i++)
            {
                cBoxPlat.Items.Add(dtPlat.Rows[i][0].ToString());
            }

        }

      
        public void FormMarketing_Load(object sender, EventArgs e)
        {
            LoadProduct();
            Load_Filter_Plat();
            BuatButton();
            buttonMarketing.Enabled = false;
            button3.Enabled = false;
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            FormAddMarketing formAddMarketing = new FormAddMarketing();
            formAddMarketing.PerformForm1Click += new EventHandler(frm2_PerformForm1Click);
            formAddMarketing.ShowDialog();
        }
        

        private void frm2_PerformForm1Click(object sender, EventArgs e)
        {
            LoadProduct();
            Load_Filter_Plat();
        }

        private void cBoxPlat_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOrder formOrder = new FormOrder();
            formOrder.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDisplay formDisplay = new FormDisplay();
            formDisplay.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPengeluaranLain formPengeluaranLain = new FormPengeluaranLain();
            formPengeluaranLain.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMarketing formMarketing = new FormMarketing();
            formMarketing.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProfitLoss formProfitLoss = new FormProfitLoss();
            formProfitLoss.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formChart = new Form1();
            formChart.ShowDialog();
            this.Close();
        }


    }
}
