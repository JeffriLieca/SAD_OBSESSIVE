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
    public partial class FormAddPengeluaranLain : Form
    {


        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_Obsessive";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        public string sqlInsert;
        public DataTable dtLain = new DataTable();
        public int index = 0;
        public string KatSekarang = "";
        public int stock = 0;
        public string ID = "";
        public FormAddPengeluaranLain()
        {
            InitializeComponent();
        }

        private void Load_Filter_Ket()
        {
            cBoxKet.Items.Clear();
            DataTable dtKet = new DataTable();
            sqlQuery = $"select distinct KETERANGAN_PENGELUARAN_LAIN from PENGELUARAN_LAIN_LAIN;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtKet);
            cBoxKet.Items.Add("");
            for (int i = 0; i < dtKet.Rows.Count; i++)
            {
                cBoxKet.Items.Add(dtKet.Rows[i][0].ToString());
            }


        }

        private void FormAddMarketing_Load(object sender, EventArgs e)
        {
            Load_Filter_Ket();
            this.BackColor = ColorTranslator.FromHtml("#C38E6C");
        }

        public event EventHandler PerformForm1Click;

        private void LoadAwal()
        {
            EventHandler handler = this.PerformForm1Click;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (tBNamaLain.Text != ""  && cBoxKet.Text != "" && tBHargaLain.Text!="" && tBJumlahLain.Text!="" )
            {

                
                sqlConnect.Open();
                sqlInsert = $"insert into PENGELUARAN_LAIN_LAIN values(null,'{tBNamaLain.Text}',{tBHargaLain.Text},{tBJumlahLain.Text},'{cBoxKet.Text}','{dTPLain.Value.ToString("yyyy-MM-dd")}',0); ";
                sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Berhasil di tambahkan");
                LoadAwal();
                this.Close();
            }
            
            else
            {
                MessageBox.Show("Data tidak boleh kosong");
            }
        }
        
        


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tBHargaLain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tBJumlahLain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void FormAddPengeluaranLain_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadAwal();
        }
    }
}
