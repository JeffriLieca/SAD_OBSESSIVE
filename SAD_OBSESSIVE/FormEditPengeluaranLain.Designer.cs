
namespace SAD_OBSESSIVE
{
    partial class FormEditPengeluaranLain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBNamaLain = new System.Windows.Forms.TextBox();
            this.tBHargaLain = new System.Windows.Forms.TextBox();
            this.tBJumlahLain = new System.Windows.Forms.TextBox();
            this.dTPLain = new System.Windows.Forms.DateTimePicker();
            this.cBoxKet = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Pengeluaran Lain :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keterangan :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Awal :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Jumlah  :";
            // 
            // tBNamaLain
            // 
            this.tBNamaLain.Location = new System.Drawing.Point(254, 38);
            this.tBNamaLain.Name = "tBNamaLain";
            this.tBNamaLain.Size = new System.Drawing.Size(208, 22);
            this.tBNamaLain.TabIndex = 8;
            // 
            // tBHargaLain
            // 
            this.tBHargaLain.Enabled = false;
            this.tBHargaLain.Location = new System.Drawing.Point(254, 101);
            this.tBHargaLain.Name = "tBHargaLain";
            this.tBHargaLain.Size = new System.Drawing.Size(131, 22);
            this.tBHargaLain.TabIndex = 9;
            // 
            // tBJumlahLain
            // 
            this.tBJumlahLain.Enabled = false;
            this.tBJumlahLain.Location = new System.Drawing.Point(254, 138);
            this.tBJumlahLain.Name = "tBJumlahLain";
            this.tBJumlahLain.Size = new System.Drawing.Size(100, 22);
            this.tBJumlahLain.TabIndex = 10;
            // 
            // dTPLain
            // 
            this.dTPLain.Enabled = false;
            this.dTPLain.Location = new System.Drawing.Point(254, 172);
            this.dTPLain.Name = "dTPLain";
            this.dTPLain.Size = new System.Drawing.Size(200, 22);
            this.dTPLain.TabIndex = 13;
            // 
            // cBoxKet
            // 
            this.cBoxKet.FormattingEnabled = true;
            this.cBoxKet.Location = new System.Drawing.Point(254, 66);
            this.cBoxKet.Name = "cBoxKet";
            this.cBoxKet.Size = new System.Drawing.Size(208, 24);
            this.cBoxKet.TabIndex = 15;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Lime;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Location = new System.Drawing.Point(568, 271);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 40);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Location = new System.Drawing.Point(465, 271);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 40);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormEditPengeluaranLain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 343);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.cBoxKet);
            this.Controls.Add(this.dTPLain);
            this.Controls.Add(this.tBJumlahLain);
            this.Controls.Add(this.tBHargaLain);
            this.Controls.Add(this.tBNamaLain);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEditPengeluaranLain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Pengeluaran Lain";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditPengeluaranLain_FormClosed);
            this.Load += new System.EventHandler(this.FormAddMarketing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBNamaLain;
        private System.Windows.Forms.TextBox tBHargaLain;
        private System.Windows.Forms.TextBox tBJumlahLain;
        private System.Windows.Forms.DateTimePicker dTPLain;
        private System.Windows.Forms.ComboBox cBoxKet;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}