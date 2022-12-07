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



    public partial class FormOrder : Form
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

        public int posisiX = 15;
        public int posisiY = 15;
        public static string passingId { get; set; }
        public FormOrder()
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
            posisiY = 15;
            sqlConnect.Open();
            panelProd.Controls.OfType<Panel>().ToList().ForEach(pnl => pnl.Dispose());
            dtProduct = new DataTable();


            sqlCommand = new MySqlCommand("pFilterSearchProdukGambar",sqlConnect);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("parNamaProd", textBoxSearchProd.Text);
            sqlCommand.Parameters.AddWithValue("parNamaKat", cBoxKategori.Text);
            sqlCommand.Parameters.AddWithValue("parVol", cBoxVol.Text);
            sqlCommand.Parameters.AddWithValue("parSize", cBoxSize.Text);
            sqlCommand.Parameters.AddWithValue("parStok", stock);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(this.dtProduct);
            //dgvInvent.DataSource = dtProduct;
            //dgvInvent.Columns.Remove("ID");
            //dgvInvent.Columns[2].Width = 40;
            //dgvInvent.Columns[3].Width = 40;
            //dgvInvent.Columns[4].Width = 40;
            
            sqlConnect.Close();
            sqlCommand.CommandType = CommandType.Text;

            
            int nomorProd = 0;
            imageListProd.Images.Clear();
            for (int j = 0; j < dtProduct.Rows.Count / 3 + 1; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (nomorProd < dtProduct.Rows.Count)
                    {


                        byte[] images = (byte[])dtProduct.Rows[nomorProd][6];
                        MemoryStream mstream = new MemoryStream(images);

                        imageListProd.Images.Add(Image.FromStream(mstream));

                        
                        //Button panelProd = new Button();
                        //this.panelProd.Controls.Add(panelProd);

                        //Label labelSize = new Label();
                        //labelSize.Text = dtProduct.Rows[nomorProd][3].ToString();
                        //panelProd.Controls.Add(labelSize);
                        //panelProd.Size = new Size(110, 140);
                        //panelProd.Location = new Point(posisiX, posisiY);
                        //panelProd.Text = $"{dtProduct.Rows[nomorProd][1].ToString()}\n{dtProduct.Rows[nomorProd][2].ToString()}";
                        //panelProd.Visible = true;
                        //panelProd.BringToFront();
                        //panelProd.Tag = dtProduct.Rows[nomorProd][0].ToString();
                        ////buttonhu.Image = Image.FromStream(mstream);
                        //panelProd.ImageList = imageListProd;
                        //panelProd.ImageIndex = nomorProd;
                        //panelProd.TextImageRelation = TextImageRelation.ImageAboveText;
                        //panelProd.TextAlign = ContentAlignment.MiddleRight;
                        //panelProd.ImageAlign = ContentAlignment.MiddleCenter;
                        //panelProd.Click += Buttonhu_Click;
                        //panelProd.FlatStyle = FlatStyle.Flat;
                        //panelProd.ForeColor = Color.Black;

                        Panel panProd = new Panel();
                        panelProd.Controls.Add(panProd);
                        panProd.Size = new Size(160, 160);
                        panProd.Location = new Point(posisiX, posisiY);
                        panProd.BackColor = Color.Aqua;
                        panProd.Tag= dtProduct.Rows[nomorProd][0].ToString();

                        PictureBox picGambar = new PictureBox();
                        panProd.Controls.Add(picGambar);
                        picGambar.Image = Image.FromStream(mstream);
                        picGambar.SizeMode = PictureBoxSizeMode.StretchImage;
                        picGambar.Location = new Point(8, 9);
                        picGambar.Size = new Size(83, 88);

                        Button butMin = new Button();
                        panProd.Controls.Add(butMin);
                        butMin.Text = "-";
                        butMin.TextAlign = ContentAlignment.MiddleCenter;
                        butMin.FlatStyle = FlatStyle.Flat;
                        butMin.Font = new Font(butMin.Font.font, ,12);
                        butMin.BackColor = Color.CadetBlue;
                        butMin.Location = new Point(97,9);
                        butMin.Size = new Size(25, 25);
                        butMin.Tag = dtProduct.Rows[nomorProd][0].ToString();

                        Button butPlus = new Button();
                        panProd.Controls.Add(butPlus);
                        butPlus.Text = "+";
                        butPlus.TextAlign = ContentAlignment.MiddleCenter;
                        butPlus.FlatStyle = FlatStyle.Flat;
                        butPlus.BackColor = Color.CadetBlue;
                        butPlus.Location = new Point(127, 9);
                        butPlus.Size = new Size(25, 25);
                        butPlus.Tag = dtProduct.Rows[nomorProd][0].ToString();

                        Label labNama = new Label();
                        labNama.Text= dtProduct.Rows[nomorProd][1].ToString();
                        panProd.Controls.Add(labNama);
                        labNama.AutoSize = true;
                        labNama.Location = new Point(5,100);

                        Label labKat = new Label();
                        labKat.Text = dtProduct.Rows[nomorProd][2].ToString();
                        panProd.Controls.Add(labKat);
                        labKat.AutoSize = true;
                        labKat.Location = new Point(5, 120);

                        Label labVol = new Label();
                        labVol.Text = $"Vol. {dtProduct.Rows[nomorProd][4].ToString()}";
                        panProd.Controls.Add(labVol);
                        labVol.AutoSize = true;
                        labVol.Location = new Point(5, 140);

                        Label labSize = new Label();
                        labSize.Text = $"Size : {dtProduct.Rows[nomorProd][3].ToString()}";
                        panProd.Controls.Add(labSize);
                        labSize.Location = new Point(97, 50);

                        Label labStock = new Label();
                        labStock.Text = $"Stock : {dtProduct.Rows[nomorProd][5].ToString()}";
                        panProd.Controls.Add(labStock);
                        labStock.Location = new Point(97, 75);


                        posisiX += 175;
                        if (posisiX > 600)
                        {
                            posisiX = 0;
                        }
                        nomorProd++;
                    }
                }
                posisiY += 175;
                posisiX = 15;
            }
            posisiX = 15;
            sqlConnect.Close();

        }

        private void Buttonhu_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
            //string imgLocation = "";
            //sqlConnect.Open();
            //sqlQuery = "select GAMBAR from PRODUK where ID_PRODUK='" + dtProduct.Rows[index][0] + "';";
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //DataTable dtCoba = new DataTable();
            //sqlAdapter.Fill(dtCoba);
            ////byte[] images = ((byte[])dtCoba.Rows[0][0]);
            ////MemoryStream mstream = new MemoryStream(images);
            ////pictureBoxProd.Image = Image.FromStream(mstream);
            //sqlConnect.Close();
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

        private void dgvInvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelProd_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
