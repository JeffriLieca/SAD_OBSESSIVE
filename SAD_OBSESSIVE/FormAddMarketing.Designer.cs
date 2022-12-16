
namespace SAD_OBSESSIVE
{
    partial class FormAddMarketing
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tBNamaMarketing = new System.Windows.Forms.TextBox();
            this.tBHargaMar = new System.Windows.Forms.TextBox();
            this.tBView = new System.Windows.Forms.TextBox();
            this.tBClick = new System.Windows.Forms.TextBox();
            this.tBReach = new System.Windows.Forms.TextBox();
            this.dTPAwal = new System.Windows.Forms.DateTimePicker();
            this.dTPAkhir = new System.Windows.Forms.DateTimePicker();
            this.cBoxPlat = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Marketing :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Platform :";
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
            this.label4.Location = new System.Drawing.Point(137, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Awal :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tanggal Akhir :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Jumlah View :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Jumlah Reach :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Jumlah Click :";
            // 
            // tBNamaMarketing
            // 
            this.tBNamaMarketing.Location = new System.Drawing.Point(254, 38);
            this.tBNamaMarketing.Name = "tBNamaMarketing";
            this.tBNamaMarketing.Size = new System.Drawing.Size(208, 22);
            this.tBNamaMarketing.TabIndex = 8;
            // 
            // tBHargaMar
            // 
            this.tBHargaMar.Location = new System.Drawing.Point(254, 101);
            this.tBHargaMar.Name = "tBHargaMar";
            this.tBHargaMar.Size = new System.Drawing.Size(131, 22);
            this.tBHargaMar.TabIndex = 9;
            this.tBHargaMar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBHargaMar_KeyPress);
            // 
            // tBView
            // 
            this.tBView.Location = new System.Drawing.Point(254, 215);
            this.tBView.Name = "tBView";
            this.tBView.Size = new System.Drawing.Size(100, 22);
            this.tBView.TabIndex = 10;
            this.tBView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBView_KeyPress);
            // 
            // tBClick
            // 
            this.tBClick.Location = new System.Drawing.Point(254, 300);
            this.tBClick.Name = "tBClick";
            this.tBClick.Size = new System.Drawing.Size(100, 22);
            this.tBClick.TabIndex = 11;
            this.tBClick.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBClick_KeyPress);
            // 
            // tBReach
            // 
            this.tBReach.Location = new System.Drawing.Point(254, 259);
            this.tBReach.Name = "tBReach";
            this.tBReach.Size = new System.Drawing.Size(100, 22);
            this.tBReach.TabIndex = 12;
            this.tBReach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBReach_KeyPress);
            // 
            // dTPAwal
            // 
            this.dTPAwal.Location = new System.Drawing.Point(254, 142);
            this.dTPAwal.Name = "dTPAwal";
            this.dTPAwal.Size = new System.Drawing.Size(241, 22);
            this.dTPAwal.TabIndex = 13;
            // 
            // dTPAkhir
            // 
            this.dTPAkhir.Location = new System.Drawing.Point(254, 176);
            this.dTPAkhir.Name = "dTPAkhir";
            this.dTPAkhir.Size = new System.Drawing.Size(241, 22);
            this.dTPAkhir.TabIndex = 14;
            this.dTPAkhir.ValueChanged += new System.EventHandler(this.dTPAkhir_ValueChanged);
            // 
            // cBoxPlat
            // 
            this.cBoxPlat.FormattingEnabled = true;
            this.cBoxPlat.Location = new System.Drawing.Point(254, 66);
            this.cBoxPlat.Name = "cBoxPlat";
            this.cBoxPlat.Size = new System.Drawing.Size(208, 24);
            this.cBoxPlat.TabIndex = 15;
            this.cBoxPlat.SelectedIndexChanged += new System.EventHandler(this.cBoxPlat_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Lime;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(664, 383);
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
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(535, 383);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 40);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAddMarketing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.cBoxPlat);
            this.Controls.Add(this.dTPAkhir);
            this.Controls.Add(this.dTPAwal);
            this.Controls.Add(this.tBReach);
            this.Controls.Add(this.tBClick);
            this.Controls.Add(this.tBView);
            this.Controls.Add(this.tBHargaMar);
            this.Controls.Add(this.tBNamaMarketing);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddMarketing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Marketing";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddMarketing_FormClosed);
            this.Load += new System.EventHandler(this.FormAddMarketing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBNamaMarketing;
        private System.Windows.Forms.TextBox tBHargaMar;
        private System.Windows.Forms.TextBox tBView;
        private System.Windows.Forms.TextBox tBClick;
        private System.Windows.Forms.TextBox tBReach;
        private System.Windows.Forms.DateTimePicker dTPAwal;
        private System.Windows.Forms.DateTimePicker dTPAkhir;
        private System.Windows.Forms.ComboBox cBoxPlat;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}