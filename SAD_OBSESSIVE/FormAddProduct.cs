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
    public partial class FormAddProduct : Form
    {
        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_Obsessive";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        public string sqlInsert;
        public List<string> listSize = new List<string>();
        public bool KatChange = false;
        public bool VolChange = false;
        public DataTable dtKat = new DataTable();
        public DataTable dtVol = new DataTable();
        public FormAddProduct()
        {
            InitializeComponent();
            imgLocation = "";
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            listSize.Clear();
            cBoxVol.Enabled = false;
            buttonAddVol.Enabled = false;
            Load_Filter_Kat();
            Load_Filter_Vol();
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
            if (tBNamaProd != null && cBoxKategori.Text != null && cBoxVol.Text != null && listSize.Count != 0 && tBStockAwal.Text != null && tBHargaJual.Text != null && tBHargaBeli.Text != null)
            {
                try
                {
                    MemoryStream memory = new MemoryStream();
                    pictureBoxAdd.Image.Save(memory, pictureBoxAdd.Image.RawFormat);
                    // Gambar
                    byte[] images = null;
                    BinaryReader brs;
                    if (imgLocation != "")
                    {

                        FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        brs = new BinaryReader(stream);
                        images = brs.ReadBytes((int)stream.Length);
                    }
                    else
                    {
                        images = memory.ToArray();
                    }

                    sqlConnect.Open();
                    sqlQuery = $"select fNamaKat('{cBoxKategori.Text.ToString()}');";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    string Namkat = sqlCommand.ExecuteScalar().ToString();
                    sqlConnect.Close();

                    sqlConnect.Open();
                    sqlQuery = $"select concat('{Namkat}',lpad({cBoxVol.Text},2,0));";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    string IDKat = sqlCommand.ExecuteScalar().ToString();
                    sqlConnect.Close();


                    sqlConnect.Open();

                    for(int i = 0; i < dtKat.Rows.Count;i++)
                    {
                        if (cBoxKategori.Text.ToUpper() == dtKat.Rows[i].ToString().ToUpper())
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

                    foreach (string size in listSize)
                    {
                        sqlInsert = $"insert into PRODUK values(null, '{IDKat}','{tBNamaProd.Text}', '{size}', {tBHargaJual.Text}, {tBHargaBeli.Text}, @images, {tBStockAwal.Text}, null, '{dateTimePickerProd.Value.ToString("yyyy-MM-dd")}', 0); ";
                        sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
                        sqlCommand.Parameters.Add(new MySqlParameter("@images", images));
                        sqlCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Produk berhasil ditambahkan");


                    sqlConnect.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Produk sudah ada");
                }
            }
            else
            {
                MessageBox.Show("Ada data yang belum terisi");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                listSize.Add(checkBox1.Text);
            }
            else
            {
                listSize.Remove(checkBox1.Text);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                listSize.Add(checkBox2.Text);
            }
            else
            {
                listSize.Remove(checkBox2.Text);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                listSize.Add(checkBox3.Text);
            }
            else
            {
                listSize.Remove(checkBox3.Text);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                listSize.Add(checkBox5.Text);
            }
            else
            {
                listSize.Remove(checkBox5.Text);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                listSize.Add(checkBox4.Text);
            }
            else
            {
                listSize.Remove(checkBox4.Text);
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                listSize.Add(checkBox7.Text);
            }
            else
            {
                listSize.Remove(checkBox7.Text);
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                listSize.Add(checkBox6.Text);
            }
            else
            {
                listSize.Remove(checkBox6.Text);
            }
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
            VolChange = true;

        }

        private void cBoxVol_SelectedIndexChanged(object sender, EventArgs e)
        {
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

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //display image in picture box
                imgLocation = open.FileName.ToString();
                pictureBoxAdd.ImageLocation = imgLocation;
            }
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

        private void buttonCancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
