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
    public partial class FormEditPengeluaranLain : Form
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
        public FormEditPengeluaranLain()
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
            LoadData();
            this.BackColor = ColorTranslator.FromHtml("#C38E6C");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (tBNamaLain.Text != ""  && cBoxKet.Text != "" )
            {

                
                sqlConnect.Open();
                sqlInsert = $"update PENGELUARAN_LAIN_LAIN set NAMA_PENGELUARAN_LAIN='{tBNamaLain.Text}',KETERANGAN_PENGELUARAN_LAIN='{cBoxKet.Text}' where ID_PENGELUARAN_LAIN='{ID}'; ";
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
            ID = FormPengeluaranLain.passingId;
            sqlConnect.Open();
            dtLain = new DataTable();
           
            sqlQuery = $"select ID_PENGELUARAN_LAIN as ID, NAMA_PENGELUARAN_LAIN as Nama, KETERANGAN_PENGELUARAN_LAIN as Keterangan,HARGA_PENGELUARAN_LAIN as Harga,JUMLAH_PENGELUARAN_LAIN as Jumlah,TANGGAL_PENGELUARAN_LAIN as Tanggal from PENGELUARAN_LAIN_LAIN where ID_PENGELUARAN_LAIN='{ID}'; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtLain);
            sqlConnect.Close();

            tBNamaLain.Text = dtLain.Rows[0][1].ToString();
            cBoxKet.Text = dtLain.Rows[0][2].ToString();
            tBHargaLain.Text = dtLain.Rows[0][3].ToString();
            dTPLain.Text = dtLain.Rows[0][5].ToString();
            tBJumlahLain.Text = dtLain.Rows[0][4].ToString();

        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            LoadAwal();
            this.Close();
        }

        private void FormEditPengeluaranLain_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadAwal();
        }
    }
}
