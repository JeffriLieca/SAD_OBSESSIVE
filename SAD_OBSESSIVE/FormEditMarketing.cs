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
    public partial class FormEditMarketing : Form
    {


        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_Obsessive";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        public string sqlInsert;
        public DataTable dtMarketing = new DataTable();
        public int index = 0;
        public string KatSekarang = "";
        public int stock = 0;
        public string ID = "";
        public FormEditMarketing()
        {
            InitializeComponent();
        }

        private void Load_Filter_Plat()
        {
            cBoxPlat.Items.Clear();
            DataTable dtPlat = new DataTable();
            sqlQuery = $"select distinct PLATFORM from MARKETING where STATUS_DELETE_MARKETING=0 ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlat);
            cBoxPlat.Items.Add("");
            for (int i = 0; i < dtPlat.Rows.Count; i++)
            {
                cBoxPlat.Items.Add(dtPlat.Rows[i][0].ToString());
            }

        }

        private void FormAddMarketing_Load(object sender, EventArgs e)
        {
            Load_Filter_Plat();
            LoadData();
            this.BackColor = ColorTranslator.FromHtml("#C38E6C");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (tBNamaMarketing.Text != ""  && cBoxPlat.Text != "" && tBHargaMar.Text != "" )
            {

                if (tBClick.Text == "")
                {
                    tBClick.Text = "0";
                }
                if (tBReach.Text == "")
                {
                    tBReach.Text = "0";
                }
                if (tBView.Text == "")
                {
                    tBView.Text = "0";
                }
                sqlConnect.Open();
                sqlInsert = $"update MARKETING set NAMA_MARKETING='{tBNamaMarketing.Text}',PLATFORM='{cBoxPlat.Text}',TANGGAL_AKHIR='{dTPAkhir.Value.ToString("yyyy-MM-dd")}',`VIEW`={tBView.Text},REACH={tBReach.Text},CLICK={tBClick.Text} where ID_MARKETING='{ID}'; ";
                sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Berhasil di edit");
                LoadAwal();
                this.Close();
            }
            
            else
            {
                MessageBox.Show("Data tidak boleh kosong");
            }
        }
        public event EventHandler PerformForm1Click;

        private void LoadAwal()
        {
            EventHandler handler = this.PerformForm1Click;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }
        private void LoadData()
        {
            ID = FormMarketing.passingId;
            sqlConnect.Open();
            dtMarketing = new DataTable();
           
            sqlQuery = $"select ID_MARKETING,NAMA_MARKETING, PLATFORM, HARGA_MARKETING,TANGGAL_AWAL, TANGGAL_AKHIR, `VIEW`,REACH,CLICK from MARKETING where ID_MARKETING='{ID}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMarketing);
            sqlConnect.Close();

            tBNamaMarketing.Text = dtMarketing.Rows[0][1].ToString();
            cBoxPlat.Text = dtMarketing.Rows[0][2].ToString();
            tBHargaMar.Text = dtMarketing.Rows[0][3].ToString();
            dTPAwal.Text = dtMarketing.Rows[0][4].ToString();
            dTPAkhir.Text = dtMarketing.Rows[0][5].ToString();
            tBView.Text = dtMarketing.Rows[0][6].ToString();
            tBReach.Text = dtMarketing.Rows[0][7].ToString();
            tBClick.Text = dtMarketing.Rows[0][8].ToString();

        }

        private void dTPAkhir_ValueChanged(object sender, EventArgs e)
        {
            if (dTPAkhir.Value < dTPAwal.Value)
            {
                MessageBox.Show("Tanggal Akhir tidak boleh lebih kecil dari Tanggal Awal");
                dTPAkhir.Value = dTPAwal.Value;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tBView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tBReach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tBClick_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void FormEditMarketing_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadAwal();
        }
    }
}
