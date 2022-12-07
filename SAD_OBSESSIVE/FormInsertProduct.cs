using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace SAD_OBSESSIVE
{
    public partial class FormInsertProduct : Form
    {
        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_Obsessive";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        public string sqlInsert;
        public string sqlUpdate;
        public List<string> listSize = new List<string>();
        FormDisplay FormDisplay = new FormDisplay();
        public string passedID;
        public DataTable dtInfo = new DataTable();
        public string KatAwal="";
        public int VolAwal = 0;
        public DataTable dtKat = new DataTable();
        public DataTable dtVol = new DataTable();
        public bool KatChange = false;
        public bool VolChange = false;
        public int Stok = 0;

        public FormInsertProduct()
        {
            InitializeComponent();
            imgLocation = "";
        }

        private void LoadInfo()
        {
            passedID = FormDisplay.passingId;
            dtInfo = new DataTable();
            sqlQuery = $"select p.NAMA_PRODUK as Nama,k.NAMA_KATEGORI as Kategori,k.VOLUME as Vol, p.SIZE as Size, p.HARGA_JUAL as Jual,p.TOTAL_STOK as Tot from PRODUK p,KATEGORI k where p.ID_KATEGORI = k.ID_KATEGORI and p.ID_PRODUK = '{passedID}'; ; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtInfo);

            tBNamaProd.Text = dtInfo.Rows[0][0].ToString();
            cBoxKategori.Text = dtInfo.Rows[0][1].ToString();
            cBoxVol.Text = dtInfo.Rows[0][2].ToString();
            tBSize.Text = dtInfo.Rows[0][3].ToString();
            tBHargaJual.Text = dtInfo.Rows[0][4].ToString();
            Stok = Convert.ToInt32(dtInfo.Rows[0][5].ToString());

            VolAwal = Convert.ToInt32(cBoxVol.Text);
            KatAwal = cBoxKategori.Text;
        }
        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            listSize.Clear();
            cBoxVol.Enabled = false;
            buttonAddVol.Enabled = false;
            LoadInfo();
            Load_Filter_Kat();
            Load_Filter_Vol();
            LoadGambar();
            cBoxVol.Text = dtInfo.Rows[0][2].ToString();
        }
        private void Load_Filter_Kat()
        {
            cBoxKategori.Items.Clear();
            dtKat = new DataTable();
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
            cBoxVol.Text = "";
            dtVol = new DataTable();
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

        public string imgLocation = "";
        
        private void buttonAddProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void cBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxKategori.Text == "")
            {
                cBoxVol.Enabled = false;
                buttonAddVol.Enabled = false;
            }
            else
            {
                cBoxVol.Enabled = true;
                buttonAddVol.Enabled = true;
            }
            Load_Filter_Vol();
            KatChange = true;
        }

        private void cBoxVol_SelectedIndexChanged(object sender, EventArgs e)
        {
            KatChange = true;
        }

        private void buttonAddVol_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = $"select fNamaKat('{cBoxKategori.Text.ToString()}');";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            string Namkat = sqlCommand.ExecuteScalar().ToString();
            sqlConnect.Close();

            sqlConnect.Open();
            sqlQuery = $"select fVol('{Namkat}');";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            string volu = sqlCommand.ExecuteScalar().ToString();
            sqlConnect.Close();

            cBoxVol.Text = volu;
        }

        private void buttonAddImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            byte[] images = null;
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //display image in picture box
                imgLocation = open.FileName.ToString();
                //pictureBoxAdd.ImageLocation = imgLocation;

                
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);
                label9.Text = images.ToString();

                try
                {
                    sqlConnect.Open();
                    sqlQuery = $"update PRODUK set GAMBAR=@imagesup where substring(ID_PRODUK,1,7)= '{passedID.Substring(0, 7)}';";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.Parameters.Add(new MySqlParameter("@imagesup", images));
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                    MessageBox.Show("Gambar berhasil diupdate");
                }
                catch (Exception)
                {
                    MessageBox.Show("Gagal");
                }
            }
            LoadInfo();
            Load_Filter_Kat();
            Load_Filter_Vol();
            LoadGambar();
        }

        private void cBoxKategori_TextChanged(object sender, EventArgs e)
        {
            if (cBoxKategori.Text == "")
            {
                cBoxVol.Enabled = false;
                buttonAddVol.Enabled = false;
            }
            else
            {
                cBoxVol.Enabled = true;
                buttonAddVol.Enabled = true;
            }
            Load_Filter_Vol();
        }

        private void tBNamaProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonChangeNama_Click(object sender, EventArgs e)
        {
            if (tBNamaProd.Text != null)
            {
                sqlConnect.Open();
                sqlUpdate = $"update PRODUK set NAMA_PRODUK = '{tBNamaProd.Text}' where substring(ID_PRODUK,1,7)= '{passedID.Substring(0, 7)}'; ";
                sqlCommand = new MySqlCommand(sqlUpdate, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                MessageBox.Show("Nama Produk berhasil diubah");
            }
            else
            {
                MessageBox.Show("Nama Produk tidak boleh kosong");
            }
        }

        private void buttonChangeKat_Click(object sender, EventArgs e)
        {
            if (cBoxKategori != null)
            {

                if (cBoxKategori.Text.ToUpper() == KatAwal.ToUpper())
                {
                    MessageBox.Show("Kategori tidak berubah");
                }
                else
                {
                    if (cBoxVol.Text != "")
                    {
                        


                        sqlConnect.Open();
                        sqlQuery = $"select fNamaKat('{cBoxKategori.Text.ToString()}');";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        string Namkat = sqlCommand.ExecuteScalar().ToString();

                        sqlQuery = $"select concat('{Namkat}',lpad({cBoxVol.Text},2,0));";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        string IDKat = sqlCommand.ExecuteScalar().ToString();


                        for(int i = 0; i < dtKat.Rows.Count; i++)
                        {
                            if (cBoxKategori.Text.ToUpper() == dtKat.Rows[i][0].ToString().ToUpper())
                            {
                                KatChange = false;
                            }
                        }

                        for (int i = 0; i < dtKat.Rows.Count; i++)
                        {
                            if (cBoxVol.Text.ToUpper() == dtVol.Rows[i][0].ToString().ToUpper())
                            {
                                VolChange = false;
                            }
                        }

                        if (KatChange == true || VolChange==true)
                        {
                            sqlInsert = $"insert into KATEGORI values('{IDKat}', '{cBoxKategori.Text}',{cBoxVol.Text},0); ";
                            sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
                            sqlCommand.ExecuteNonQuery();
                        }

                        sqlUpdate = $"update PRODUK set ID_KATEGORI = '{IDKat}' where substring(ID_PRODUK,1,7)= '{passedID.Substring(0, 7)}'; ";
                        sqlCommand = new MySqlCommand(sqlUpdate, sqlConnect);
                        sqlCommand.ExecuteNonQuery();
                        sqlConnect.Close();

                        MessageBox.Show("Perubahan Kategori berhasil");
                    }
                    else
                    {
                        MessageBox.Show("Volume tidak boleh kosong");
                    }
                }
            }
            else
            {
                MessageBox.Show("Kategori tidak boleh kosong");
            }
        }

        private void buttonChangeVol_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(cBoxVol.Text) == VolAwal)
            {
                MessageBox.Show("Volume tidak berubah");
            }
            else
            {
                if (cBoxVol != null)
                {
                    sqlConnect.Open();
                    sqlQuery = $"select fNamaKat('{KatAwal}');";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    string Namkat = sqlCommand.ExecuteScalar().ToString();

                    sqlQuery = $"select concat('{Namkat}',lpad({cBoxVol.Text},2,0));";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    string IDKat = sqlCommand.ExecuteScalar().ToString();


                    sqlUpdate = $"update PRODUK set ID_KATEGORI = '{IDKat}' where substring(ID_PRODUK,1,7)= '{passedID.Substring(0, 7)}'; ";
                    sqlCommand = new MySqlCommand(sqlUpdate, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    MessageBox.Show("Perubahan Kategori berhasil");
                }
                else
                {
                    MessageBox.Show("Volume tidak boleh kosong");
                }
            }
        }

        private void buttonSaveHarga_Jual_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlUpdate = $"update PRODUK set HARGA_JUAL = '{tBHargaJual.Text}' where ID_PRODUK= '{passedID}'; ";
            sqlCommand = new MySqlCommand(sqlUpdate, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }

        private void buttonAddStock_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            if (tBStockAwal.Text=="" || tBHargaBeli.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong");
            }
            else
            {
                sqlQuery = $"select fHitungStokUpdate('{passedID}');";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                int StokTerpakai = Convert.ToInt32(sqlCommand.ExecuteScalar().ToString());
                if ((Stok + Convert.ToInt32(tBStockAwal.Text))< StokTerpakai)
                {
                    MessageBox.Show("Input Stok tidak sesuai");
                }
                else
                {
                    sqlInsert = $"insert into PENGELUARAN() values(null, null, null, '{passedID}', '{dtInfo.Rows[0][0].ToString()}', {tBStockAwal.Text}, {tBHargaBeli.Text}, null, '{dateTimePickerProd.Value.ToString("yyyy-MM-dd")}', 0); ";
                    sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlUpdate = $"update PRODUK set TOTAL_STOK= {Stok + Convert.ToInt32(tBStockAwal.Text)}, STOK_SISA={Stok + Convert.ToInt32(tBStockAwal.Text) - StokTerpakai} where ID_PRODUK='{passedID}'; ";
                    sqlCommand = new MySqlCommand(sqlUpdate, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Stock berhasil diupdate");
                    tBHargaBeli.Clear();
                    tBStockAwal.Clear();
                    dateTimePickerProd.Value = DateTime.Today;
                }

            }
            sqlConnect.Close();
        }

        public void LoadGambar()
        {
            try
            {
                imgLocation = "";
                sqlConnect.Open();
                sqlQuery = "select GAMBAR from PRODUK where ID_PRODUK='" + passedID + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable dtCoba = new DataTable();
                sqlAdapter.Fill(dtCoba);
                sqlConnect.Close();
                byte[] images = ((byte[])dtCoba.Rows[0][0]);
                MemoryStream mstream = new MemoryStream(images);
                pictureBoxAdd.Image = Image.FromStream(mstream);
                
            }
            catch (Exception)
            {

            }
        }
    }
}
