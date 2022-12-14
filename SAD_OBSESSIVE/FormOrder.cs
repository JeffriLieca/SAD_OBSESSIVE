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



    public partial class FormOrder : Form
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
        private string sqlUpdate;
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        public string sqlInsert;
        public static DataTable dtProduct = new DataTable();
        public static DataTable dtCart = new DataTable();
        public int index=0;
        public string KatSekarang = "";
        public int stock = 1;
        public bool clear = false;

        public int posisiX = 15;
        public int posisiY = 15;
        public static string passingId { get; set; }
        public FormOrder()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {

            cBoxVol.Enabled = false;
            LoadProduct();
            LoadGambar();
            Load_Filter_Kat();
            Load_Filter_Vol();
        }

        static Label[] labelStock = new Label[dtProduct.Rows.Count];
        static Button[] btnMin = new Button[dtProduct.Rows.Count];
        TextBox[] txtbox = new TextBox[dtProduct.Rows.Count];
        Button[] btnPlus = new Button[dtProduct.Rows.Count];
        public int[] stokSisa = new int[dtProduct.Rows.Count];
        private void LoadProduct()
        {
            if (clear == false)
            {

                posisiY = 15;
                sqlConnect.Open();
                panelProd.Controls.OfType<Panel>().ToList().ForEach(pnl => pnl.Dispose());
                dtProduct = new DataTable();


                sqlCommand = new MySqlCommand("pFilterSearchProdukGambar", sqlConnect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("parNamaProd", textBoxSearchProd.Text);
                sqlCommand.Parameters.AddWithValue("parNamaKat", cBoxKategori.Text);
                sqlCommand.Parameters.AddWithValue("parVol", cBoxVol.Text);
                sqlCommand.Parameters.AddWithValue("parSize", cBoxSize.Text);
                sqlCommand.Parameters.AddWithValue("parStok", stock);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtProduct);
                //dgvInvent.DataSource = dtProduct;
                //dgvInvent.Columns.Remove("ID");
                //dgvInvent.Columns[2].Width = 40;
                //dgvInvent.Columns[3].Width = 40;
                //dgvInvent.Columns[4].Width = 40;

                sqlConnect.Close();
                sqlCommand.CommandType = CommandType.Text;

                labelStock = new Label[dtProduct.Rows.Count];
                btnMin = new Button[dtProduct.Rows.Count];
                txtbox = new TextBox[dtProduct.Rows.Count];
                btnPlus = new Button[dtProduct.Rows.Count];
                stokSisa = new int[dtProduct.Rows.Count];


                int nomorProd = 0;
                imageListProd.Images.Clear();
                for (int j = 0; j < dtProduct.Rows.Count / 3 + 1; j++)
                {
                    for (int i = 0; i < 4; i++)
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
                            panProd.BackColor = Color.RosyBrown;
                            panProd.Tag = dtProduct.Rows[nomorProd][0].ToString();

                            PictureBox picGambar = new PictureBox();
                            panProd.Controls.Add(picGambar);
                            picGambar.Image = Image.FromStream(mstream);
                            picGambar.SizeMode = PictureBoxSizeMode.StretchImage;
                            picGambar.Location = new Point(8, 9);
                            picGambar.Size = new Size(83, 88);

                            //Button butMin = new Button();
                            //panProd.Controls.Add(butMin);
                            //butMin.Text = "-";
                            //butMin.TextAlign = ContentAlignment.MiddleCenter;
                            //butMin.FlatStyle = FlatStyle.Flat;
                            //butMin.Font = new Font(butMin.Font.ToString(),12);
                            //butMin.BackColor = Color.CadetBlue;
                            //butMin.Location = new Point(97,9);
                            //butMin.Size = new Size(25, 25);
                            //butMin.Tag = dtProduct.Rows[nomorProd][0].ToString();
                            //butMin.Click += ButMin_Click;

                            //Button butPlus = new Button();
                            //panProd.Controls.Add(butPlus);
                            //butPlus.Text = "+";
                            //butPlus.TextAlign = ContentAlignment.MiddleCenter;
                            //butPlus.FlatStyle = FlatStyle.Flat;
                            //butPlus.Font = new Font(butMin.Font.ToString(), 12);
                            //butPlus.BackColor = Color.CadetBlue;
                            //butPlus.Location = new Point(127, 9);
                            //butPlus.Size = new Size(25, 25);
                            //butPlus.Tag = i;
                            //butPlus.Click += ButPlus_Click;

                            Label labNamaProd = new Label();
                            panProd.Controls.Add(labNamaProd);
                            labNamaProd.Text = dtProduct.Rows[nomorProd][1].ToString();
                            labNamaProd.AutoSize = true;
                            labNamaProd.Location = new Point(5, 100);

                            btnMin[nomorProd] = new System.Windows.Forms.Button();
                            panProd.Controls.Add(btnMin[nomorProd]);
                            btnMin[nomorProd].Text = "-";
                            btnMin[nomorProd].TextAlign = ContentAlignment.MiddleCenter;
                            btnMin[nomorProd].FlatStyle = FlatStyle.Flat;
                            btnMin[nomorProd].Font = new Font(btnMin[nomorProd].Font.ToString(), 12);
                            btnMin[nomorProd].BackColor = Color.CadetBlue;
                            btnMin[nomorProd].Location = new Point(97, 9);
                            btnMin[nomorProd].Size = new Size(25, 25);
                            btnMin[nomorProd].Tag = nomorProd;
                            btnMin[nomorProd].Click += ButMin_Click;

                            btnPlus[nomorProd] = new System.Windows.Forms.Button();
                            panProd.Controls.Add(btnPlus[nomorProd]);
                            btnPlus[nomorProd].Text = "+";
                            btnPlus[nomorProd].TextAlign = ContentAlignment.MiddleCenter;
                            btnPlus[nomorProd].FlatStyle = FlatStyle.Flat;
                            btnPlus[nomorProd].Font = new Font(btnPlus[nomorProd].Font.ToString(), 12);
                            btnPlus[nomorProd].BackColor = Color.CadetBlue;
                            btnPlus[nomorProd].Location = new Point(127, 9);
                            btnPlus[nomorProd].Size = new Size(25, 25);
                            btnPlus[nomorProd].Tag = nomorProd;
                            btnPlus[nomorProd].Click += ButPlus_Click;



                            labelStock[nomorProd] = new System.Windows.Forms.Label();
                            labelStock[nomorProd].Text = dtProduct.Rows[nomorProd][5].ToString();
                            panProd.Controls.Add(labelStock[nomorProd]);
                            labelStock[nomorProd].Tag = dtProduct.Rows[nomorProd][0].ToString();
                            labelStock[nomorProd].AutoSize = true;
                            labelStock[nomorProd].Location = new Point(135, 75);

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
                            labStock.Text = $"Stock : ";
                            stokSisa[nomorProd] = Convert.ToInt32(dtProduct.Rows[nomorProd][5].ToString());
                            panProd.Controls.Add(labStock);
                            labStock.Location = new Point(97, 75);


                            posisiX += 175;
                            if (posisiX > 750)
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
        }

        private void ButPlus_Click(object sender, EventArgs e)
        {
            Button bts = (Button)sender;
            int index = Convert.ToInt32(bts.Tag);
            string IDbut = labelStock[index].Tag.ToString();
            if (Convert.ToInt32(labelStock[index].Text) > 0)
            {
                //labelStock[index].Text = (Convert.ToInt32(labelStock[index].Text) - 1).ToString();


                sqlConnect.Open();
                sqlInsert = $"insert into TEMP_DETAIL_PENJUALAN values(null, fIDPenjualan('{dTPCart.Value.ToString("yyyy-MM-dd")}'), '{IDbut}', 1, fCariHargaProduk('{IDbut}'), null, 0); ";
                sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                LoadCart();
                LoadProduct();
            }
            else
            {
                MessageBox.Show("Stok tidak cukup");
            }
        }

        private void ButMin_Click(object sender, EventArgs e)
        {

            Button bts = (Button)sender;
            int index = Convert.ToInt32(bts.Tag);
            string IDbut = labelStock[index].Tag.ToString();

            //if (Convert.ToInt32(labelStock[index].Text) < stokSisa[index])
            //{
                //labelStock[index].Text = (Convert.ToInt32(labelStock[index].Text) + 1).ToString();
                sqlConnect.Open();
                sqlCommand = new MySqlCommand("pKurangiCart11", sqlConnect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("parIDProd", IDbut);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                sqlCommand.CommandType = CommandType.Text;
                LoadCart();
           // }
            LoadProduct();
            
        }

        private void Buttonhu_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlUpdate = "update PRODUK set STATUS_DELETE_PENGELUARAN_LAIN = '1' where ID_PRODUK = '" + dtProduct.Rows[index][0] + "' ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
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

        private void LoadPenjualan()
        {
            sqlConnect.Open();
            sqlInsert = $"insert into TEMP_PENJUALAN values(null, '{dTPCart.Value.ToString("yyyy-MM-dd")}', null, null, 0); ";
            sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }
        
        private void LoadCart()
        {
            panelCart.Controls.OfType<Label>().ToList().ForEach(lbl => lbl.Dispose());
            panelCart.Controls.OfType<Button>().ToList().ForEach(bt => bt.Dispose());
            dtCart = new DataTable();
            sqlQuery = $"select v.`ID Produk`,p.NAMA_PRODUK, v.Jumlah, format(v.Harga,0), format(v.Subtotal,0), p.SIZE from vCart v,PRODUK p where v.`ID Produk`=p.ID_PRODUK;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCart);
            int posisi = 10;
            for (int i = 0; i < dtCart.Rows.Count; i++)
            {
                Button buttSilang = new Button();
                buttSilang.Text = "X";
                buttSilang.FlatStyle = FlatStyle.Flat;
                buttSilang.Font = new Font(buttSilang.Font.ToString(), 5);
                buttSilang.TextAlign = ContentAlignment.TopCenter;
                panelCart.Controls.Add(buttSilang);
                buttSilang.Tag = dtCart.Rows[i][0].ToString();
                buttSilang.Location = new Point(5, posisi);
                buttSilang.Size = new Size(15, 15);
                buttSilang.Click += ButtSilang_Click;

                Label labNamaCart = new Label();
                labNamaCart.Text = dtCart.Rows[i][1].ToString() + " -"+dtCart.Rows[i][5].ToString();
                panelCart.Controls.Add(labNamaCart);
                labNamaCart.AutoSize = true;
                labNamaCart.Location = new Point(20, posisi);

                posisi += 20;
                Label labJumCart = new Label();
                labJumCart.Text = $"{dtCart.Rows[i][2].ToString()} X @{dtCart.Rows[i][3].ToString()}";
                panelCart.Controls.Add(labJumCart);
                labJumCart.AutoSize = true;
                labJumCart.Location = new Point(30, posisi);

                Label labSubCart = new Label();
                labSubCart.Text = $"{dtCart.Rows[i][4].ToString()}";
                panelCart.Controls.Add(labSubCart);
                labSubCart.AutoSize = false;
                labSubCart.TextAlign = ContentAlignment.MiddleRight;
                labSubCart.Location = new Point(185, posisi);

                posisi += 30;
            }
            if (dtCart.Rows.Count > 0)
            {
                sqlConnect.Open();
                sqlQuery = $"select format(ifnull(TOTAL_PENJUALAN,0),0) from TEMP_PENJUALAN limit 1;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                labelTotal.Text = $"Rp. {sqlCommand.ExecuteScalar().ToString()}";

                sqlConnect.Close();
            }
            else
            {
                labelTotal.Text = "Rp. 0";
            }
        }

        private void ButtSilang_Click(object sender, EventArgs e)
        {
            Button bts = (Button)sender;
            
            string IDbut = bts.Tag.ToString();
            sqlConnect.Open();
            sqlCommand = new MySqlCommand("pKurangiCartBanyak", sqlConnect);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("parIDProd", IDbut);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            sqlCommand.CommandType = CommandType.Text;

            LoadProduct();
            LoadCart();
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
            if (clear == false)
            {

                if (cBoxKategori.Text == "")
                {
                    cBoxVol.Enabled = false;
                }
                else
                {
                    cBoxVol.Enabled = true;
                }
                Load_Filter_Vol();
                LoadProduct();
            }
        }
        private void Load_Filter_Kat()
        {
            if (clear == false)
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
            try
            {
                if (tBStok.Text == "")
                {
                }
                else
                {
                    stock = Convert.ToInt32(tBStok.Text);
                    LoadProduct();
                }
            }
            catch (Exception)
            {

            }
        }

        private void FormDisplay_Load(object sender, EventArgs e)
        {
            DeletePenjualan();
            cBoxVol.Enabled = false;
            labelTotal.TextAlign = ContentAlignment.MiddleRight;
            LoadProduct();
            LoadGambar();
            Load_Filter_Kat();
            Load_Filter_Vol();
            LoadCart();
            LoadPenjualan();
            panel7.BackColor = ColorTranslator.FromHtml("#6B3D20");
            panel8.BackColor = ColorTranslator.FromHtml("#6B3D20");
            this.BackColor= ColorTranslator.FromHtml("#C38E6C");
            buttonOrder.Enabled = false;
            textBoxSearchProd.Select();
            BuatButton();
        }




        private void buttonClear_Click(object sender, EventArgs e)
        {
            DeletePenjualan();
            LoadPenjualan();
            LoadCart();
            LoadProduct();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlCommand = new MySqlCommand("pPindahData", sqlConnect);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            sqlCommand.CommandType = CommandType.Text;
            LoadPenjualan();
            LoadCart();
        }

        private void dTPCart_ValueChanged(object sender, EventArgs e)
        {
            DeletePenjualan();
            LoadPenjualan();
            LoadCart();
            LoadProduct();
        }

        private void FormOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            DeletePenjualan();
        }
        private void DeletePenjualan()
        {
            sqlConnect.Open();
            sqlCommand = new MySqlCommand("pDelCart", sqlConnect);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            sqlCommand.CommandType = CommandType.Text;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            FormHistory formHistory = new FormHistory();
            formHistory.PerformForm1Click += new EventHandler(frm2_PerformForm1Click);
            formHistory.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear = true;
            cBoxKategori.Text = "";
            textBoxSearchProd.Text = "";
            cBoxVol.Text = "";
            cBoxSize.Text = "";
            tBStok.Text = "1";
            //tBStok.Clear();
            //textBoxSearchProd.Clear();
            //cBoxSize.SelectedIndex = 0;
            //cBoxVol.SelectedIndex = 0;
            //cBoxKategori.SelectedIndex = 0;

            clear = false;
            LoadProduct();
        }
        private void frm2_PerformForm1Click(object sender, EventArgs e)
        {
            LoadProduct();
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
