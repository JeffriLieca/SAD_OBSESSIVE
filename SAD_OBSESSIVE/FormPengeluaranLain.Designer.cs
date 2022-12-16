
namespace SAD_OBSESSIVE
{
    partial class FormPengeluaranLain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPengeluaranLain));
            this.dgvLain = new System.Windows.Forms.DataGridView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.cBoxKet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imageListMenu = new System.Windows.Forms.ImageList(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.roundButtonObses = new WindowsFormsApplication1.RoundButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonChart = new System.Windows.Forms.Button();
            this.buttonProfitLoss = new System.Windows.Forms.Button();
            this.buttonMarketing = new System.Windows.Forms.Button();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonExpenses = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLain)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLain
            // 
            this.dgvLain.AllowUserToAddRows = false;
            this.dgvLain.AllowUserToDeleteRows = false;
            this.dgvLain.AllowUserToResizeRows = false;
            this.dgvLain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLain.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dgvLain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLain.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLain.EnableHeadersVisualStyles = false;
            this.dgvLain.GridColor = System.Drawing.Color.SaddleBrown;
            this.dgvLain.Location = new System.Drawing.Point(318, 257);
            this.dgvLain.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLain.Name = "dgvLain";
            this.dgvLain.ReadOnly = true;
            this.dgvLain.RowHeadersVisible = false;
            this.dgvLain.RowHeadersWidth = 51;
            this.dgvLain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLain.Size = new System.Drawing.Size(1093, 661);
            this.dgvLain.TabIndex = 0;
            this.dgvLain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvent_CellContentClick);
            this.dgvLain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvent_CellContentClick);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Chocolate;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.Location = new System.Drawing.Point(1491, 394);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 73);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Chocolate;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Location = new System.Drawing.Point(1491, 527);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 73);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Chocolate;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Location = new System.Drawing.Point(1491, 269);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 73);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // cBoxKet
            // 
            this.cBoxKet.FormattingEnabled = true;
            this.cBoxKet.Location = new System.Drawing.Point(419, 194);
            this.cBoxKet.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxKet.Name = "cBoxKet";
            this.cBoxKet.Size = new System.Drawing.Size(160, 24);
            this.cBoxKet.TabIndex = 7;
            this.cBoxKet.SelectedIndexChanged += new System.EventHandler(this.cBoxKet_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Keterangan :";
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
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.AutoSize = true;
            this.panel8.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel8.Controls.Add(this.roundButtonObses);
            this.panel8.Controls.Add(this.pictureBox2);
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
            this.roundButtonObses.TabIndex = 3;
            this.roundButtonObses.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(700, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 70);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
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
            // FormPengeluaranLain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBoxKet);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dgvLain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPengeluaranLain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pengeluaran Lain";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMarketing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLain)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLain;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox cBoxKet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageListMenu;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonChart;
        private System.Windows.Forms.Button buttonProfitLoss;
        private System.Windows.Forms.Button buttonMarketing;
        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonExpenses;
        private System.Windows.Forms.Button buttonHome;
        private WindowsFormsApplication1.RoundButton roundButtonObses;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}