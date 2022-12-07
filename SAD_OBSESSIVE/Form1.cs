using SAD_OBSESSIVE.Models;
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

namespace SAD_OBSESSIVE
{
    public partial class Form1 : Form
    {
        private Dashboard model;
        public Form1()
        {
            InitializeComponent();

            //Default - Last 7 days
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Today;
            buttonLast7Days.Select();
            

            model = new Dashboard();
            LoadData();
        }

        //Private methods
        private void LoadData()
        {
            var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData == true)
            {
                labelNumOrders.Text = model.NumPenjualan.ToString();
                labelTotalRev.Text = model.TotalRevenue.ToString();
                labelTotalPro.Text = model.TotalProfit.ToString();

                labelTotProduct.Text = model.NumProduk.ToString();
                labelTotStock.Text = model.NumStock.ToString();
                labelTotTerjual.Text = model.NumProdukTerjual.ToString();

                chartKiri.DataSource = model.GrossRevenueList;
                chartKiri.Series[0].XValueMember = "Date";
                chartKiri.Series[0].YValueMembers = "TotalAmount";
                chartKiri.DataBind();

                chartKanan.DataSource = model.TopProductsList;
                chartKanan.Series[0].XValueMember = "Key";
                chartKanan.Series[0].YValueMembers = "Value";
                chartKanan.DataBind();

                Console.WriteLine("Loaded view :)");
            }
            else Console.WriteLine("view not loaded, same query");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            model = new Dashboard();
            LoadData();
        }
    }
}
