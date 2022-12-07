
namespace SAD_OBSESSIVE
{
    partial class FormDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDisplay));
            this.dgvInvent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBoxProd = new System.Windows.Forms.PictureBox();
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
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvent
            // 
            this.dgvInvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvent.Location = new System.Drawing.Point(233, 127);
            this.dgvInvent.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInvent.Name = "dgvInvent";
            this.dgvInvent.RowHeadersWidth = 51;
            this.dgvInvent.Size = new System.Drawing.Size(539, 367);
            this.dgvInvent.TabIndex = 0;
            this.dgvInvent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvent_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(883, 399);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(100, 28);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(859, 158);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 28);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(859, 214);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(859, 101);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBoxProd
            // 
            this.pictureBoxProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxProd.BackgroundImage")));
            this.pictureBoxProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxProd.Location = new System.Drawing.Point(16, 172);
            this.pictureBoxProd.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProd.Name = "pictureBoxProd";
            this.pictureBoxProd.Size = new System.Drawing.Size(181, 182);
            this.pictureBoxProd.TabIndex = 6;
            this.pictureBoxProd.TabStop = false;
            // 
            // cBoxKategori
            // 
            this.cBoxKategori.FormattingEnabled = true;
            this.cBoxKategori.Location = new System.Drawing.Point(311, 42);
            this.cBoxKategori.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxKategori.Name = "cBoxKategori";
            this.cBoxKategori.Size = new System.Drawing.Size(160, 24);
            this.cBoxKategori.TabIndex = 7;
            this.cBoxKategori.SelectedIndexChanged += new System.EventHandler(this.cBoxKategori_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kategori :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vol. :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(692, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Size :";
            // 
            // cBoxVol
            // 
            this.cBoxVol.FormattingEnabled = true;
            this.cBoxVol.Location = new System.Drawing.Point(577, 42);
            this.cBoxVol.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxVol.Name = "cBoxVol";
            this.cBoxVol.Size = new System.Drawing.Size(79, 24);
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
            this.cBoxSize.Location = new System.Drawing.Point(744, 46);
            this.cBoxSize.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxSize.Name = "cBoxSize";
            this.cBoxSize.Size = new System.Drawing.Size(61, 24);
            this.cBoxSize.TabIndex = 13;
            this.cBoxSize.SelectedIndexChanged += new System.EventHandler(this.cBoxSize_SelectedIndexChanged);
            // 
            // textBoxSearchProd
            // 
            this.textBoxSearchProd.Location = new System.Drawing.Point(92, 46);
            this.textBoxSearchProd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchProd.Name = "textBoxSearchProd";
            this.textBoxSearchProd.Size = new System.Drawing.Size(132, 22);
            this.textBoxSearchProd.TabIndex = 14;
            this.textBoxSearchProd.TextChanged += new System.EventHandler(this.textBoxSearchProd_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Stok >";
            // 
            // tBStok
            // 
            this.tBStok.Location = new System.Drawing.Point(571, 97);
            this.tBStok.Margin = new System.Windows.Forms.Padding(4);
            this.tBStok.Name = "tBStok";
            this.tBStok.Size = new System.Drawing.Size(41, 22);
            this.tBStok.TabIndex = 16;
            this.tBStok.Text = "0";
            this.tBStok.TextChanged += new System.EventHandler(this.tBStok_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "label7";
            // 
            // FormDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label7);
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
            this.Controls.Add(this.pictureBoxProd);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInvent);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDisplay";
            this.Text = "FormDisplay";
            this.Load += new System.EventHandler(this.FormDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBoxProd;
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
        private System.Windows.Forms.Label label7;
    }
}