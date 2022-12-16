
namespace SAD_OBSESSIVE
{
    partial class FormHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistory));
            this.dGVPenjualan = new System.Windows.Forms.DataGridView();
            this.dGVDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRefund = new System.Windows.Forms.Button();
            this.roundButtonBack = new WindowsFormsApplication1.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPenjualan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVPenjualan
            // 
            this.dGVPenjualan.AllowUserToAddRows = false;
            this.dGVPenjualan.AllowUserToDeleteRows = false;
            this.dGVPenjualan.AllowUserToResizeRows = false;
            this.dGVPenjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVPenjualan.BackgroundColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVPenjualan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVPenjualan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVPenjualan.GridColor = System.Drawing.Color.SaddleBrown;
            this.dGVPenjualan.Location = new System.Drawing.Point(119, 63);
            this.dGVPenjualan.Name = "dGVPenjualan";
            this.dGVPenjualan.ReadOnly = true;
            this.dGVPenjualan.RowHeadersVisible = false;
            this.dGVPenjualan.RowHeadersWidth = 51;
            this.dGVPenjualan.RowTemplate.Height = 24;
            this.dGVPenjualan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVPenjualan.Size = new System.Drawing.Size(674, 194);
            this.dGVPenjualan.TabIndex = 0;
            this.dGVPenjualan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVPenjualan_CellContentClick);
            this.dGVPenjualan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVPenjualan_CellContentClick);
            // 
            // dGVDetail
            // 
            this.dGVDetail.AllowUserToAddRows = false;
            this.dGVDetail.AllowUserToDeleteRows = false;
            this.dGVDetail.AllowUserToResizeRows = false;
            this.dGVDetail.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dGVDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGVDetail.Location = new System.Drawing.Point(119, 350);
            this.dGVDetail.Name = "dGVDetail";
            this.dGVDetail.ReadOnly = true;
            this.dGVDetail.RowHeadersVisible = false;
            this.dGVDetail.RowHeadersWidth = 51;
            this.dGVDetail.RowTemplate.Height = 24;
            this.dGVDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDetail.Size = new System.Drawing.Size(916, 188);
            this.dGVDetail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Penjualan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Detail Penjualan";
            // 
            // buttonRefund
            // 
            this.buttonRefund.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonRefund.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefund.Location = new System.Drawing.Point(907, 132);
            this.buttonRefund.Name = "buttonRefund";
            this.buttonRefund.Size = new System.Drawing.Size(75, 72);
            this.buttonRefund.TabIndex = 4;
            this.buttonRefund.Text = "Refund";
            this.buttonRefund.UseVisualStyleBackColor = false;
            this.buttonRefund.Click += new System.EventHandler(this.buttonRefund_Click);
            // 
            // roundButtonBack
            // 
            this.roundButtonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButtonBack.BackgroundImage")));
            this.roundButtonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roundButtonBack.FlatAppearance.BorderSize = 0;
            this.roundButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButtonBack.ForeColor = System.Drawing.Color.Transparent;
            this.roundButtonBack.Location = new System.Drawing.Point(12, 12);
            this.roundButtonBack.Name = "roundButtonBack";
            this.roundButtonBack.Size = new System.Drawing.Size(55, 63);
            this.roundButtonBack.TabIndex = 5;
            this.roundButtonBack.UseVisualStyleBackColor = true;
            this.roundButtonBack.Click += new System.EventHandler(this.roundButtonBack_Click);
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 575);
            this.Controls.Add(this.roundButtonBack);
            this.Controls.Add(this.buttonRefund);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVDetail);
            this.Controls.Add(this.dGVPenjualan);
            this.Name = "FormHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History Penjualan";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHistory_FormClosed);
            this.Load += new System.EventHandler(this.FormHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPenjualan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVPenjualan;
        private System.Windows.Forms.DataGridView dGVDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRefund;
        private WindowsFormsApplication1.RoundButton roundButtonBack;
    }
}