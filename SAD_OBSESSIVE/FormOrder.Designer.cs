
namespace SAD_OBSESSIVE
{
    partial class FormOrder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.imageListProd = new System.Windows.Forms.ImageList(this.components);
            this.cBoxKategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxVol = new System.Windows.Forms.ComboBox();
            this.cBoxSize = new System.Windows.Forms.ComboBox();
            this.textBoxSearchProd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBStok = new System.Windows.Forms.TextBox();
            this.panelProd = new System.Windows.Forms.Panel();
            this.panelCart = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dTPCart = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.roundButtonObses = new WindowsFormsApplication1.RoundButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageListMenu = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonExpenses = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.buttonMarketing = new System.Windows.Forms.Button();
            this.buttonProfitLoss = new System.Windows.Forms.Button();
            this.buttonChart = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListProd
            // 
            this.imageListProd.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListProd.ImageSize = new System.Drawing.Size(60, 60);
            this.imageListProd.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cBoxKategori
            // 
            this.cBoxKategori.FormattingEnabled = true;
            this.cBoxKategori.Location = new System.Drawing.Point(817, 148);
            this.cBoxKategori.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxKategori.Name = "cBoxKategori";
            this.cBoxKategori.Size = new System.Drawing.Size(165, 24);
            this.cBoxKategori.TabIndex = 7;
            this.cBoxKategori.SelectedIndexChanged += new System.EventHandler(this.cBoxKategori_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(740, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kategori :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(740, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vol. :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1028, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Size :";
            // 
            // cBoxVol
            // 
            this.cBoxVol.FormattingEnabled = true;
            this.cBoxVol.Location = new System.Drawing.Point(817, 186);
            this.cBoxVol.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxVol.Name = "cBoxVol";
            this.cBoxVol.Size = new System.Drawing.Size(94, 24);
            this.cBoxVol.TabIndex = 12;
            this.cBoxVol.SelectedIndexChanged += new System.EventHandler(this.cBoxVol_SelectedIndexChanged);
            // 
            // cBoxSize
            // 
            this.cBoxSize.FormattingEnabled = true;
            this.cBoxSize.Items.AddRange(new object[] {
            "",
            "XXS",
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.cBoxSize.Location = new System.Drawing.Point(1079, 147);
            this.cBoxSize.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxSize.Name = "cBoxSize";
            this.cBoxSize.Size = new System.Drawing.Size(66, 24);
            this.cBoxSize.TabIndex = 13;
            this.cBoxSize.SelectedIndexChanged += new System.EventHandler(this.cBoxSize_SelectedIndexChanged);
            // 
            // textBoxSearchProd
            // 
            this.textBoxSearchProd.Location = new System.Drawing.Point(380, 195);
            this.textBoxSearchProd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchProd.Name = "textBoxSearchProd";
            this.textBoxSearchProd.Size = new System.Drawing.Size(313, 22);
            this.textBoxSearchProd.TabIndex = 14;
            this.textBoxSearchProd.TextChanged += new System.EventHandler(this.textBoxSearchProd_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1023, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Stok >=";
            // 
            // tBStok
            // 
            this.tBStok.Location = new System.Drawing.Point(1082, 189);
            this.tBStok.Margin = new System.Windows.Forms.Padding(4);
            this.tBStok.Name = "tBStok";
            this.tBStok.Size = new System.Drawing.Size(63, 22);
            this.tBStok.TabIndex = 16;
            this.tBStok.Text = "1";
            this.tBStok.TextChanged += new System.EventHandler(this.tBStok_TextChanged);
            this.tBStok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBStok_KeyPress);
            // 
            // panelProd
            // 
            this.panelProd.AutoScroll = true;
            this.panelProd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelProd.Location = new System.Drawing.Point(302, 234);
            this.panelProd.Name = "panelProd";
            this.panelProd.Size = new System.Drawing.Size(1003, 741);
            this.panelProd.TabIndex = 18;
            // 
            // panelCart
            // 
            this.panelCart.AutoScroll = true;
            this.panelCart.BackColor = System.Drawing.Color.Silver;
            this.panelCart.Location = new System.Drawing.Point(1485, 234);
            this.panelCart.Name = "panelCart";
            this.panelCart.Size = new System.Drawing.Size(405, 647);
            this.panelCart.TabIndex = 19;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Red;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.Location = new System.Drawing.Point(1698, 943);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 59);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Lime;
            this.buttonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOK.Location = new System.Drawing.Point(1792, 944);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 56);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1506, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 33);
            this.label12.TabIndex = 1;
            this.label12.Text = "Cart";
            // 
            // dTPCart
            // 
            this.dTPCart.Location = new System.Drawing.Point(1485, 133);
            this.dTPCart.Name = "dTPCart";
            this.dTPCart.Size = new System.Drawing.Size(249, 22);
            this.dTPCart.TabIndex = 0;
            this.dTPCart.ValueChanged += new System.EventHandler(this.dTPCart_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1509, 899);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "Total :";
            // 
            // labelTotal
            // 
            this.labelTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTotal.Location = new System.Drawing.Point(1718, 899);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTotal.Size = new System.Drawing.Size(149, 21);
            this.labelTotal.TabIndex = 22;
            this.labelTotal.Text = "Rp. 100.000";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHistory.BackgroundImage")));
            this.buttonHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistory.Location = new System.Drawing.Point(1838, 178);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(52, 45);
            this.buttonHistory.TabIndex = 23;
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.AutoSize = true;
            this.panel8.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel8.Controls.Add(this.roundButtonObses);
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Location = new System.Drawing.Point(215, -1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1697, 100);
            this.panel8.TabIndex = 39;
            // 
            // roundButtonObses
            // 
            this.roundButtonObses.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.roundButtonObses.BackColor = System.Drawing.Color.Snow;
            this.roundButtonObses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButtonObses.BackgroundImage")));
            this.roundButtonObses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roundButtonObses.Enabled = false;
            this.roundButtonObses.FlatAppearance.BorderSize = 0;
            this.roundButtonObses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButtonObses.Location = new System.Drawing.Point(1580, 16);
            this.roundButtonObses.Name = "roundButtonObses";
            this.roundButtonObses.Size = new System.Drawing.Size(75, 72);
            this.roundButtonObses.TabIndex = 1;
            this.roundButtonObses.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(700, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 70);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imageListMenu
            // 
            this.imageListMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMenu.ImageStream")));
            this.imageListMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMenu.Images.SetKeyName(0, "download__3_-removebg-preview.png");
            this.imageListMenu.Images.SetKeyName(1, "download__1_-removebg-preview.png");
            this.imageListMenu.Images.SetKeyName(2, "download-removebg-preview.png");
            this.imageListMenu.Images.SetKeyName(3, "download__4_-removebg-preview.png");
            this.imageListMenu.Images.SetKeyName(4, "download__6_-removebg-preview.png");
            this.imageListMenu.Images.SetKeyName(5, "download__5_-removebg-preview.png");
            this.imageListMenu.Images.SetKeyName(6, "download__2_-removebg-preview.png");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(302, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 49);
            this.button1.TabIndex = 40;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.ImageKey = "download__3_-removebg-preview.png";
            this.buttonHome.ImageList = this.imageListMenu;
            this.buttonHome.Location = new System.Drawing.Point(29, 210);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonHome.Size = new System.Drawing.Size(168, 49);
            this.buttonHome.TabIndex = 36;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonExpenses
            // 
            this.buttonExpenses.BackColor = System.Drawing.SystemColors.Control;
            this.buttonExpenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExpenses.FlatAppearance.BorderSize = 0;
            this.buttonExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExpenses.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExpenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExpenses.ImageKey = "download__4_-removebg-preview.png";
            this.buttonExpenses.ImageList = this.imageListMenu;
            this.buttonExpenses.Location = new System.Drawing.Point(29, 540);
            this.buttonExpenses.Name = "buttonExpenses";
            this.buttonExpenses.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonExpenses.Size = new System.Drawing.Size(168, 49);
            this.buttonExpenses.TabIndex = 37;
            this.buttonExpenses.Text = "   Expenses";
            this.buttonExpenses.UseVisualStyleBackColor = false;
            this.buttonExpenses.Click += new System.EventHandler(this.buttonExpenses_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrder.FlatAppearance.BorderSize = 0;
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrder.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrder.ImageKey = "download__1_-removebg-preview.png";
            this.buttonOrder.ImageList = this.imageListMenu;
            this.buttonOrder.Location = new System.Drawing.Point(29, 320);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonOrder.Size = new System.Drawing.Size(168, 49);
            this.buttonOrder.TabIndex = 38;
            this.buttonOrder.Text = "Order";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonInventory
            // 
            this.buttonInventory.BackColor = System.Drawing.SystemColors.Control;
            this.buttonInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInventory.FlatAppearance.BorderSize = 0;
            this.buttonInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventory.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInventory.ImageKey = "download-removebg-preview.png";
            this.buttonInventory.ImageList = this.imageListMenu;
            this.buttonInventory.Location = new System.Drawing.Point(29, 430);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonInventory.Size = new System.Drawing.Size(168, 49);
            this.buttonInventory.TabIndex = 39;
            this.buttonInventory.Text = "     Inventory";
            this.buttonInventory.UseVisualStyleBackColor = false;
            this.buttonInventory.Click += new System.EventHandler(this.buttonInventory_Click);
            // 
            // buttonMarketing
            // 
            this.buttonMarketing.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMarketing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMarketing.FlatAppearance.BorderSize = 0;
            this.buttonMarketing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMarketing.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMarketing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMarketing.ImageKey = "download__6_-removebg-preview.png";
            this.buttonMarketing.ImageList = this.imageListMenu;
            this.buttonMarketing.Location = new System.Drawing.Point(29, 650);
            this.buttonMarketing.Name = "buttonMarketing";
            this.buttonMarketing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonMarketing.Size = new System.Drawing.Size(168, 49);
            this.buttonMarketing.TabIndex = 40;
            this.buttonMarketing.Text = "    Marketing";
            this.buttonMarketing.UseVisualStyleBackColor = false;
            this.buttonMarketing.Click += new System.EventHandler(this.buttonMarketing_Click);
            // 
            // buttonProfitLoss
            // 
            this.buttonProfitLoss.BackColor = System.Drawing.SystemColors.Control;
            this.buttonProfitLoss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProfitLoss.FlatAppearance.BorderSize = 0;
            this.buttonProfitLoss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfitLoss.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfitLoss.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfitLoss.ImageKey = "download__5_-removebg-preview.png";
            this.buttonProfitLoss.ImageList = this.imageListMenu;
            this.buttonProfitLoss.Location = new System.Drawing.Point(29, 760);
            this.buttonProfitLoss.Name = "buttonProfitLoss";
            this.buttonProfitLoss.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonProfitLoss.Size = new System.Drawing.Size(168, 49);
            this.buttonProfitLoss.TabIndex = 41;
            this.buttonProfitLoss.Text = "       Profit-Loss";
            this.buttonProfitLoss.UseVisualStyleBackColor = false;
            this.buttonProfitLoss.Click += new System.EventHandler(this.buttonProfitLoss_Click);
            // 
            // buttonChart
            // 
            this.buttonChart.BackColor = System.Drawing.SystemColors.Control;
            this.buttonChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChart.FlatAppearance.BorderSize = 0;
            this.buttonChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChart.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChart.ImageKey = "download__2_-removebg-preview.png";
            this.buttonChart.ImageList = this.imageListMenu;
            this.buttonChart.Location = new System.Drawing.Point(29, 870);
            this.buttonChart.Name = "buttonChart";
            this.buttonChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonChart.Size = new System.Drawing.Size(168, 49);
            this.buttonChart.TabIndex = 42;
            this.buttonChart.Text = "Chart";
            this.buttonChart.UseVisualStyleBackColor = false;
            this.buttonChart.Click += new System.EventHandler(this.buttonChart_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel7.AutoSize = true;
            this.panel7.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel7.Controls.Add(this.buttonChart);
            this.panel7.Controls.Add(this.buttonProfitLoss);
            this.panel7.Controls.Add(this.buttonMarketing);
            this.panel7.Controls.Add(this.buttonInventory);
            this.panel7.Controls.Add(this.buttonOrder);
            this.panel7.Controls.Add(this.buttonExpenses);
            this.panel7.Controls.Add(this.buttonHome);
            this.panel7.Location = new System.Drawing.Point(-9, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(238, 1034);
            this.panel7.TabIndex = 38;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.panelCart);
            this.Controls.Add(this.panelProd);
            this.Controls.Add(this.dTPCart);
            this.Controls.Add(this.tBStok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSearchProd);
            this.Controls.Add(this.cBoxSize);
            this.Controls.Add(this.cBoxVol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxKategori);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOrder_FormClosed);
            this.Load += new System.EventHandler(this.FormDisplay_Load);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cBoxKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxVol;
        private System.Windows.Forms.ComboBox cBoxSize;
        private System.Windows.Forms.TextBox textBoxSearchProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBStok;
        private System.Windows.Forms.Panel panelProd;
        private System.Windows.Forms.ImageList imageListProd;
        private System.Windows.Forms.Panel panelCart;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dTPCart;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageListMenu;
        private System.Windows.Forms.Button button1;
        private WindowsFormsApplication1.RoundButton roundButtonObses;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonExpenses;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.Button buttonMarketing;
        private System.Windows.Forms.Button buttonProfitLoss;
        private System.Windows.Forms.Button buttonChart;
        private System.Windows.Forms.Panel panel7;
    }
}