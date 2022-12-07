
namespace SAD_OBSESSIVE
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.buttonThisMonth = new System.Windows.Forms.Button();
            this.buttonLast30Days = new System.Windows.Forms.Button();
            this.buttonLast7Days = new System.Windows.Forms.Button();
            this.buttonToday = new System.Windows.Forms.Button();
            this.buttonCustom = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNumOrders = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTotalRev = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTotalPro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chartKiri = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartKanan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTotProduct = new System.Windows.Forms.Label();
            this.labelTotStock = new System.Windows.Forms.Label();
            this.labelTotTerjual = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartKiri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKanan)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(34, 31);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(125, 22);
            this.dtpStartDate.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(174, 31);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(124, 22);
            this.dtpEndDate.TabIndex = 3;
            // 
            // buttonThisMonth
            // 
            this.buttonThisMonth.Location = new System.Drawing.Point(871, 33);
            this.buttonThisMonth.Name = "buttonThisMonth";
            this.buttonThisMonth.Size = new System.Drawing.Size(103, 23);
            this.buttonThisMonth.TabIndex = 4;
            this.buttonThisMonth.Text = "This Month";
            this.buttonThisMonth.UseVisualStyleBackColor = true;
            // 
            // buttonLast30Days
            // 
            this.buttonLast30Days.Location = new System.Drawing.Point(748, 33);
            this.buttonLast30Days.Name = "buttonLast30Days";
            this.buttonLast30Days.Size = new System.Drawing.Size(107, 23);
            this.buttonLast30Days.TabIndex = 5;
            this.buttonLast30Days.Text = "Last 30 Days";
            this.buttonLast30Days.UseVisualStyleBackColor = true;
            // 
            // buttonLast7Days
            // 
            this.buttonLast7Days.Location = new System.Drawing.Point(628, 33);
            this.buttonLast7Days.Name = "buttonLast7Days";
            this.buttonLast7Days.Size = new System.Drawing.Size(104, 23);
            this.buttonLast7Days.TabIndex = 6;
            this.buttonLast7Days.Text = "Last 7 Days";
            this.buttonLast7Days.UseVisualStyleBackColor = true;
            // 
            // buttonToday
            // 
            this.buttonToday.Location = new System.Drawing.Point(535, 33);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(75, 23);
            this.buttonToday.TabIndex = 7;
            this.buttonToday.Text = "Today";
            this.buttonToday.UseVisualStyleBackColor = true;
            // 
            // buttonCustom
            // 
            this.buttonCustom.Location = new System.Drawing.Point(439, 33);
            this.buttonCustom.Name = "buttonCustom";
            this.buttonCustom.Size = new System.Drawing.Size(75, 23);
            this.buttonCustom.TabIndex = 8;
            this.buttonCustom.Text = "Custom";
            this.buttonCustom.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(350, 31);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(46, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelNumOrders);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(34, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 65);
            this.panel1.TabIndex = 10;
            // 
            // labelNumOrders
            // 
            this.labelNumOrders.AutoSize = true;
            this.labelNumOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumOrders.Location = new System.Drawing.Point(27, 30);
            this.labelNumOrders.Name = "labelNumOrders";
            this.labelNumOrders.Size = new System.Drawing.Size(79, 32);
            this.labelNumOrders.TabIndex = 1;
            this.labelNumOrders.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of Orders";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelTotalRev);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(219, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 62);
            this.panel2.TabIndex = 11;
            // 
            // labelTotalRev
            // 
            this.labelTotalRev.AutoSize = true;
            this.labelTotalRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRev.Location = new System.Drawing.Point(18, 17);
            this.labelTotalRev.Name = "labelTotalRev";
            this.labelTotalRev.Size = new System.Drawing.Size(95, 32);
            this.labelTotalRev.TabIndex = 1;
            this.labelTotalRev.Text = "30000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Revenue";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelTotalPro);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(549, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 84);
            this.panel3.TabIndex = 11;
            // 
            // labelTotalPro
            // 
            this.labelTotalPro.AutoSize = true;
            this.labelTotalPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPro.Location = new System.Drawing.Point(25, 33);
            this.labelTotalPro.Name = "labelTotalPro";
            this.labelTotalPro.Size = new System.Drawing.Size(95, 32);
            this.labelTotalPro.TabIndex = 1;
            this.labelTotalPro.Text = "13000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Profit";
            // 
            // chartKiri
            // 
            chartArea3.Name = "ChartArea1";
            this.chartKiri.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Name = "Legend1";
            this.chartKiri.Legends.Add(legend3);
            this.chartKiri.Location = new System.Drawing.Point(24, 165);
            this.chartKiri.Name = "chartKiri";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartKiri.Series.Add(series3);
            this.chartKiri.Size = new System.Drawing.Size(519, 300);
            this.chartKiri.TabIndex = 12;
            title3.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Gross Revenue";
            this.chartKiri.Titles.Add(title3);
            this.chartKiri.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chartKanan
            // 
            chartArea4.Name = "ChartArea1";
            this.chartKanan.ChartAreas.Add(chartArea4);
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Name = "Legend1";
            this.chartKanan.Legends.Add(legend4);
            this.chartKanan.Location = new System.Drawing.Point(594, 211);
            this.chartKanan.Name = "chartKanan";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartKanan.Series.Add(series4);
            this.chartKanan.Size = new System.Drawing.Size(335, 227);
            this.chartKanan.TabIndex = 13;
            title4.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Title1";
            title4.Text = "Top 5 Product";
            this.chartKanan.Titles.Add(title4);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelTotTerjual);
            this.panel4.Controls.Add(this.labelTotStock);
            this.panel4.Controls.Add(this.labelTotProduct);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(67, 472);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Product :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Stock :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total Produk Terjual :";
            // 
            // labelTotProduct
            // 
            this.labelTotProduct.AutoSize = true;
            this.labelTotProduct.Location = new System.Drawing.Point(173, 36);
            this.labelTotProduct.Name = "labelTotProduct";
            this.labelTotProduct.Size = new System.Drawing.Size(24, 17);
            this.labelTotProduct.TabIndex = 3;
            this.labelTotProduct.Text = "10";
            this.labelTotProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotStock
            // 
            this.labelTotStock.AutoSize = true;
            this.labelTotStock.Location = new System.Drawing.Point(165, 53);
            this.labelTotStock.Name = "labelTotStock";
            this.labelTotStock.Size = new System.Drawing.Size(32, 17);
            this.labelTotStock.TabIndex = 4;
            this.labelTotStock.Text = "121";
            this.labelTotStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotTerjual
            // 
            this.labelTotTerjual.AutoSize = true;
            this.labelTotTerjual.Location = new System.Drawing.Point(173, 70);
            this.labelTotTerjual.Name = "labelTotTerjual";
            this.labelTotTerjual.Size = new System.Drawing.Size(24, 17);
            this.labelTotTerjual.TabIndex = 5;
            this.labelTotTerjual.Text = "34";
            this.labelTotTerjual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 657);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.chartKanan);
            this.Controls.Add(this.chartKiri);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCustom);
            this.Controls.Add(this.buttonToday);
            this.Controls.Add(this.buttonLast7Days);
            this.Controls.Add(this.buttonLast30Days);
            this.Controls.Add(this.buttonThisMonth);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartKiri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKanan)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button buttonThisMonth;
        private System.Windows.Forms.Button buttonLast30Days;
        private System.Windows.Forms.Button buttonLast7Days;
        private System.Windows.Forms.Button buttonToday;
        private System.Windows.Forms.Button buttonCustom;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNumOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTotalRev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTotalPro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKiri;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKanan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelTotTerjual;
        private System.Windows.Forms.Label labelTotStock;
        private System.Windows.Forms.Label labelTotProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}

