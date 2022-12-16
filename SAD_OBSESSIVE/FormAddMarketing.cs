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
    public partial class FormAddMarketing : Form
    {


        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_Obsessive";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        public string sqlInsert;
        public DataTable dtProduct = new DataTable();
        public int index = 0;
        public string KatSekarang = "";
        public int stock = 0;
        public FormAddMarketing()
        {
            InitializeComponent();
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

        public event EventHandler PerformForm1Click;

        private void LoadAwal()
        {
            EventHandler handler = this.PerformForm1Click;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }

            private void FormAddMarketing_Load(object sender, EventArgs e)
        {
            Load_Filter_Plat();
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
                sqlInsert = $"insert into MARKETING values(null, '{tBNamaMarketing.Text}','{cBoxPlat.Text}', '{tBHargaMar.Text}', '{dTPAwal.Value.ToString("yyyy-MM-dd")}', '{dTPAkhir.Value.ToString("yyyy-MM-dd")}', {tBView.Text}, '{tBReach.Text}','{tBClick.Text}', 0); ";
                sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Marketing berhasil di tambahkan");
                Clear();
                LoadAwal();
            }
            
            else
            {
                MessageBox.Show("Data tidak boleh kosong");
            }
        }
        private void Clear()
        {
            tBNamaMarketing.Clear();
            cBoxPlat.Text = "";
            tBHargaMar.Clear();
            dTPAwal.Value = DateTime.Now;
            dTPAkhir.Value = DateTime.Now;
            tBView.Clear();
            tBReach.Clear();
            tBClick.Clear();
            Load_Filter_Plat();
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
            LoadAwal();
            this.Close();
        }

        private void cBoxPlat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tBHargaMar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
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

        private void FormAddMarketing_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadAwal();
        }
    }
}
