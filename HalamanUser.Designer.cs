
namespace ClientTextMe
{
    partial class HalamanUser
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
            this.dtmessage = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btSend = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIDMess = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtmessage)).BeginInit();
            this.SuspendLayout();
            // 
            // dtmessage
            // 
            this.dtmessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtmessage.Location = new System.Drawing.Point(12, 159);
            this.dtmessage.Name = "dtmessage";
            this.dtmessage.RowHeadersWidth = 51;
            this.dtmessage.Size = new System.Drawing.Size(480, 188);
            this.dtmessage.TabIndex = 0;
            this.dtmessage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtmessage_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "List Pesan ";
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(367, 110);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(125, 33);
            this.btSend.TabIndex = 2;
            this.btSend.Text = "Send Message";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(12, 406);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(183, 33);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "Delete Message";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(131, 33);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(46, 17);
            this.Username.TabIndex = 4;
            this.Username.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selamat Datang ";
            // 
            // textBoxIDMess
            // 
            this.textBoxIDMess.Location = new System.Drawing.Point(100, 365);
            this.textBoxIDMess.Name = "textBoxIDMess";
            this.textBoxIDMess.Size = new System.Drawing.Size(95, 22);
            this.textBoxIDMess.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Message";
            // 
            // HalamanUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 454);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIDMess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtmessage);
            this.Name = "HalamanUser";
            this.Text = "HalamanUser";
            ((System.ComponentModel.ISupportInitialize)(this.dtmessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtmessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btDelete;
        public System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIDMess;
        private System.Windows.Forms.Label label3;
    }
}