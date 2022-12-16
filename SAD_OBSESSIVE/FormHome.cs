using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace SAD_OBSESSIVE
{
    public partial class FormHome : Form
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
            buttonOrder.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonOrder.Width, buttonOrder.Height, 30, 30));
            buttonInventory.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonOrder.Width, buttonOrder.Height, 30, 30));
            buttonExpenses.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonOrder.Width, buttonOrder.Height, 30, 30));
            buttonMarketing.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonOrder.Width, buttonOrder.Height, 30, 30));
            buttonProfitLoss.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonOrder.Width, buttonOrder.Height, 30, 30));
            buttonChart.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonOrder.Width, buttonOrder.Height, 30, 30));
            panel8.BackColor = ColorTranslator.FromHtml("#6B3D20");
            this.BackColor = ColorTranslator.FromHtml("#C38E6C");
        }
        public FormHome()
        {
            //Thread t = new Thread(new ThreadStart(StartSplash));
            //t.Start();
            //Thread.Sleep(2000);
            InitializeComponent();
            //t.Abort();
        }

        //private void StartSplash()
        //{
        //    Application.Run(new Splash());
        //}
        private void FormHome_Load(object sender, EventArgs e)
        {
            BuatButton();
            pictureBox2.Location = new Point(this.Size.Width / 4-200, this.Size.Height / 2);
            pictureBox3.Location = new Point(this.Size.Width * 3 / 4, this.Size.Height / 2);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
