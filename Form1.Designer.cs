
namespace ClientTextMe
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.idmess = new System.Windows.Forms.Label();
            this.mess = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxidPengguna = new System.Windows.Forms.TextBox();
            this.touser = new System.Windows.Forms.Label();
            this.btKirim = new System.Windows.Forms.Button();
            this.dtpengguna = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.textmeDBDataSet = new ClientTextMe.textmeDBDataSet();
            this.penggunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.penggunaTableAdapter = new ClientTextMe.textmeDBDataSetTableAdapters.PenggunaTableAdapter();
            this.penggunaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.btClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtpengguna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textmeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penggunaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penggunaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send Message";
            // 
            // idmess
            // 
            this.idmess.AutoSize = true;
            this.idmess.Location = new System.Drawing.Point(22, 98);
            this.idmess.Name = "idmess";
            this.idmess.Size = new System.Drawing.Size(82, 17);
            this.idmess.TabIndex = 1;
            this.idmess.Text = "ID Message";
            // 
            // mess
            // 
            this.mess.AutoSize = true;
            this.mess.Location = new System.Drawing.Point(22, 129);
            this.mess.Name = "mess";
            this.mess.Size = new System.Drawing.Size(65, 17);
            this.mess.TabIndex = 2;
            this.mess.Text = "Message";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(134, 98);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(205, 22);
            this.textBoxID.TabIndex = 3;
            // 
            // textBoxidPengguna
            // 
            this.textBoxidPengguna.Location = new System.Drawing.Point(134, 250);
            this.textBoxidPengguna.Name = "textBoxidPengguna";
            this.textBoxidPengguna.Size = new System.Drawing.Size(205, 22);
            this.textBoxidPengguna.TabIndex = 5;
            // 
            // touser
            // 
            this.touser.AutoSize = true;
            this.touser.Location = new System.Drawing.Point(22, 250);
            this.touser.Name = "touser";
            this.touser.Size = new System.Drawing.Size(88, 17);
            this.touser.TabIndex = 6;
            this.touser.Text = "id Pengguna";
            // 
            // btKirim
            // 
            this.btKirim.Location = new System.Drawing.Point(25, 278);
            this.btKirim.Name = "btKirim";
            this.btKirim.Size = new System.Drawing.Size(314, 42);
            this.btKirim.TabIndex = 7;
            this.btKirim.Text = "Kirim";
            this.btKirim.UseVisualStyleBackColor = true;
            this.btKirim.Click += new System.EventHandler(this.btKirim_Click);
            // 
            // dtpengguna
            // 
            this.dtpengguna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtpengguna.Location = new System.Drawing.Point(361, 98);
            this.dtpengguna.Name = "dtpengguna";
            this.dtpengguna.RowHeadersWidth = 51;
            this.dtpengguna.RowTemplate.Height = 24;
            this.dtpengguna.Size = new System.Drawing.Size(484, 265);
            this.dtpengguna.TabIndex = 8;
            this.dtpengguna.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtpengguna_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "List Pengguna";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(773, 45);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(72, 37);
            this.btLogin.TabIndex = 10;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // textmeDBDataSet
            // 
            this.textmeDBDataSet.DataSetName = "textmeDBDataSet";
            this.textmeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // penggunaBindingSource
            // 
            this.penggunaBindingSource.DataMember = "Pengguna";
            this.penggunaBindingSource.DataSource = this.textmeDBDataSet;
            // 
            // penggunaTableAdapter
            // 
            this.penggunaTableAdapter.ClearBeforeFill = true;
            // 
            // penggunaBindingSource1
            // 
            this.penggunaBindingSource1.DataMember = "Pengguna";
            this.penggunaBindingSource1.DataSource = this.textmeDBDataSet;
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Location = new System.Drawing.Point(134, 126);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(205, 118);
            this.richTextBoxMessage.TabIndex = 12;
            this.richTextBoxMessage.Text = "";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(25, 326);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(314, 37);
            this.btClear.TabIndex = 13;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 375);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.richTextBoxMessage);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpengguna);
            this.Controls.Add(this.btKirim);
            this.Controls.Add(this.touser);
            this.Controls.Add(this.textBoxidPengguna);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.mess);
            this.Controls.Add(this.idmess);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TextMe";
            ((System.ComponentModel.ISupportInitialize)(this.dtpengguna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textmeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penggunaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penggunaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idmess;
        private System.Windows.Forms.Label mess;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxidPengguna;
        private System.Windows.Forms.Label touser;
        private System.Windows.Forms.Button btKirim;
        private System.Windows.Forms.DataGridView dtpengguna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLogin;
        private textmeDBDataSet textmeDBDataSet;
        private System.Windows.Forms.BindingSource penggunaBindingSource;
        private textmeDBDataSetTableAdapters.PenggunaTableAdapter penggunaTableAdapter;
        private System.Windows.Forms.BindingSource penggunaBindingSource1;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.Button btClear;
    }
}

