using SAD_OBSESSIVE.Db;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAD_OBSESSIVE.Models
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public class Dashboard : DbConnection
    {
        //Field & Properties
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumPenjualan { get; private set; }
        public int NumProduk { get; private set; }
        public int NumStock { get; private set; }

        public List<KeyValuePair<string, int>> TopProductsList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public List<KeyValuePair<string, int>> CleanRevenueList { get; private set; }
        public List<KeyValuePair<string, int>> Loss { get; private set; }
        public int NumProdukTerjual { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }

        public Dashboard()
        {

        }

        //Private Methods
        private void GetNumberItems()
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command=new MySqlCommand())
                {
                    command.Connection = connection;
                    //Get Total Number of Produk
                    command.CommandText = "select fHitungProduk();";
                    NumProduk = Convert.ToInt32(command.ExecuteScalar());

                    command.Connection = connection;
                    //Get Total Number of Stock
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "fHitungStokSisaProduk";
                    command.Parameters.Add(new MySqlParameter("retur", MySqlDbType.Int32, 0));
                    command.Parameters["retur"].Direction = System.Data.ParameterDirection.ReturnValue;
                    NumStock = command.ExecuteNonQuery();

                    //command.Parameters.Add("@awal", MySqlDbType.Date);
                    //command.Parameters.Add("@akhir", MySqlDbType.Date);


                    //startDate =DateTime.Today.AddDays(-20);
                    //command.Connection = connection;
                    ////Get Total Number of Penjualan
                    //command.CommandType = System.Data.CommandType.StoredProcedure;
                    //command.CommandText = "select fHitungJumlahPenjualan();";
                    ////command.Parameters.AddWithValue("@awal", startDate);
                    ////command.Parameters.AddWithValue("@akhir", endDate);
                    command.Parameters.Add("@awal", MySqlDbType.Date);
                    command.Parameters.Add("@akhir", MySqlDbType.Date);
                    //command.Parameters["@awal"].Value = startDate;
                    //command.Parameters["@akhir"].Value = startDate;

                    ////command.Parameters["@awal"].Value = startDate;
                    ////command.Parameters["@awal"].Value = endDate;
                    //NumPenjualan = Convert.ToInt32(command.ExecuteScalar());
                    //command.CommandType = System.Data.CommandType.StoredProcedure;

                    //MySqlParameter tglAwal = command.CreateParameter();
                    //tglAwal.DbType = System.Data.DbType.DateTime;
                    //tglAwal.ParameterName = "@awaltgl";
                    //tglAwal.Value = startDate;
                    //command.Parameters.Add(tglAwal);

                    //MySqlParameter tglAkhir = command.CreateParameter();
                    //tglAkhir.DbType = System.Data.DbType.DateTime;
                    //tglAkhir.ParameterName = "@akhirtgl";
                    //tglAkhir.Value = endDate;
                    //command.Parameters.Add(tglAkhir);


                    //MySqlParameter jumlah = command.CreateParameter();
                    //jumlah.DbType = System.Data.DbType.Int32;
                    //jumlah.ParameterName = "jumlahnya";
                    //jumlah.Direction = System.Data.ParameterDirection.Output;
                    //command.Parameters.Add(jumlah);

                    //command.ExecuteNonQuery();


                    //command.Parameters.AddWithValue("awal", startDate);
                    //command.Parameters.AddWithValue("akhir", endDate);
                    ////command.Parameters.AddWithValue("@awal", startDate).Value=startDate;
                    ////command.Parameters.AddWithValue("@akhir", endDate).Value=endDate;
                    //command.Parameters["awal"].Value = startDate;
                    //command.Parameters["akhir"].Value = endDate;



                    command.CommandType = System.Data.CommandType.Text;
                    command.Connection = connection;
                    //Get Total Number of Order
                    command.CommandText = "select ifnull(sum(JML_ITEM_PENJUALAN),0) from PENJUALAN where TANGGAL_PENJUALAN between @awal and @akhir;";
                    command.Parameters["@awal"].Value = startDate;
                    command.Parameters["@akhir"].Value = endDate;
                    NumProdukTerjual = Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        private void GetOrderAnalysis()
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand())
                {


                    command.Parameters.Add("@awal", MySqlDbType.Date);
                    command.Parameters.Add("@akhir", MySqlDbType.Date);
                    command.Connection = connection;
                    command.CommandText = "select TANGGAL_PENJUALAN as Date,sum(TOTAL_PENJUALAN) as TotalAmount from PENJUALAN where TANGGAL_PENJUALAN between @awal and @akhir group by TANGGAL_PENJUALAN;";
                    command.Parameters["@awal"].Value = startDate;
                    command.Parameters["@akhir"].Value = endDate;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(new KeyValuePair<DateTime, decimal>(Convert.ToDateTime(reader[0]), Convert.ToDecimal(reader[1])));
                        TotalRevenue += Convert.ToDecimal(reader[1]);

                    }
                    TotalProfit = TotalRevenue * 0.2m;
                    reader.Close();

                    // Group by days
                    if (numberDays <= 30)
                    {
                        foreach (var item in resultTable)
                        {
                            try
                            {


                                //GrossRevenueList.Add(new RevenueByDate()
                                //{
                                //    Date = item.Key.ToString("dd MMM"),
                                //    TotalAmount = item.Value
                                //});
                                GrossRevenueList = (from orderlist in resultTable
                                                    group orderlist by orderlist.Key.ToString("dd MMM")
                                          into order
                                                    select new RevenueByDate
                                                    {
                                                        Date = order.Key,
                                                        TotalAmount = order.Sum(amount => amount.Value)
                                                    }).ToList();
                            }
                            catch
                            {

                            }
                        }
                    }

                    //Group by Week
                    else if (numberDays <= 92)
                    {

                        GrossRevenueList = (from orderlist in resultTable
                                            group orderlist by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(orderlist.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                          into order
                                            select new RevenueByDate
                                            {
                                                Date = "Week " + order.Key.ToString(),
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    //months
                    else if (numberDays <= 365 * 2)
                    {

                        bool isYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from orderlist in resultTable
                                            group orderlist by orderlist.Key.ToString("MMM yyyy")
                                          into order
                                            select new RevenueByDate
                                            {
                                                Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    else
                    {

                        bool isYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from orderlist in resultTable
                                            group orderlist by orderlist.Key.ToString("yyyy")
                                          into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                }
            }
        }

        private void GetProductAnalysis()
        {
            TopProductsList = new List<KeyValuePair<string, int>>();
            
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand())
                {
                    MySqlDataReader reader;
                    command.Connection = connection;
                    //Get Top 5 product
                    command.CommandText = "select p.NAMA_PRODUK as Nama, ifnull(sum(JML_PRODUK),0) as Terjual from PRODUK p , DETAIL_PENJUALAN DP where p.ID_PRODUK = DP.ID_PRODUK group by p.NAMA_PRODUK order by 2 desc limit 5; ";
                    command.Parameters.AddWithValue("@awal", startDate);
                    command.Parameters.AddWithValue("@akhir", endDate);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TopProductsList.Add(new KeyValuePair<string, int>(reader[0].ToString(), Convert.ToInt32(reader[1])));
                    }
                    reader.Close();
                }
            }
        }

        //public methods
        public bool LoadData(DateTime passStartDate,DateTime passEndDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, endDate.Hour, endDate.Minute, 59);
            if (passStartDate != this.startDate || passEndDate != this.endDate)
            {

                this.startDate = passStartDate;
                this.endDate = passEndDate;
                this.numberDays = (endDate - startDate).Days;

                GetNumberItems();
                GetProductAnalysis();
                GetOrderAnalysis();
                
                Console.WriteLine("Refreshed data: {0} - {1}", passStartDate.ToString(), passEndDate.ToString());
                return true;
            }

            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", passStartDate.ToString(), passEndDate.ToString());
                return false;
            }
        }
    }
}
