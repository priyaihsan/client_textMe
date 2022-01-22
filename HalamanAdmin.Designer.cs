
namespace ClientTextMe
{
    partial class HalamanAdmin
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
            this.dtPengguna = new System.Windows.Forms.DataGridView();
            this.btBack = new System.Windows.Forms.Button();
            this.btRegistrasi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIDpengguna = new System.Windows.Forms.TextBox();
            this.textBoxNamaPengguna = new System.Windows.Forms.TextBox();
            this.textBoxPasswordPengguna = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtPengguna)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Pengguna";
            // 
            // dtPengguna
            // 
            this.dtPengguna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPengguna.Location = new System.Drawing.Point(11, 74);
            this.dtPengguna.Name = "dtPengguna";
            this.dtPengguna.RowHeadersWidth = 51;
            this.dtPengguna.RowTemplate.Height = 24;
            this.dtPengguna.Size = new System.Drawing.Size(446, 222);
            this.dtPengguna.TabIndex = 1;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(330, 33);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(127, 29);
            this.btBack.TabIndex = 2;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btRegistrasi
            // 
            this.btRegistrasi.Location = new System.Drawing.Point(12, 502);
            this.btRegistrasi.Name = "btRegistrasi";
            this.btRegistrasi.Size = new System.Drawing.Size(224, 30);
            this.btRegistrasi.TabIndex = 3;
            this.btRegistrasi.Text = "Registrasi";
            this.btRegistrasi.UseVisualStyleBackColor = true;
            this.btRegistrasi.Click += new System.EventHandler(this.btRegistrasi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Pengguna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // textBoxIDpengguna
            // 
            this.textBoxIDpengguna.Location = new System.Drawing.Point(105, 361);
            this.textBoxIDpengguna.Name = "textBoxIDpengguna";
            this.textBoxIDpengguna.Size = new System.Drawing.Size(131, 22);
            this.textBoxIDpengguna.TabIndex = 7;
            // 
            // textBoxNamaPengguna
            // 
            this.textBoxNamaPengguna.Location = new System.Drawing.Point(101, 405);
            this.textBoxNamaPengguna.Name = "textBoxNamaPengguna";
            this.textBoxNamaPengguna.Size = new System.Drawing.Size(135, 22);
            this.textBoxNamaPengguna.TabIndex = 8;
            // 
            // textBoxPasswordPengguna
            // 
            this.textBoxPasswordPengguna.Location = new System.Drawing.Point(100, 453);
            this.textBoxPasswordPengguna.Name = "textBoxPasswordPengguna";
            this.textBoxPasswordPengguna.Size = new System.Drawing.Size(138, 22);
            this.textBoxPasswordPengguna.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Registrasi pengguna";
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(259, 357);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(198, 30);
            this.btDelete.TabIndex = 11;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Delete Pengguna";
            // 
            // HalamanAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPasswordPengguna);
            this.Controls.Add(this.textBoxNamaPengguna);
            this.Controls.Add(this.textBoxIDpengguna);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btRegistrasi);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.dtPengguna);
            this.Controls.Add(this.label1);
            this.Name = "HalamanAdmin";
            this.Text = "HalamanAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dtPengguna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtPengguna;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btRegistrasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIDpengguna;
        private System.Windows.Forms.TextBox textBoxNamaPengguna;
        private System.Windows.Forms.TextBox textBoxPasswordPengguna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label label6;
    }
}