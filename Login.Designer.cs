
namespace ClientTextMe
{
    partial class Login
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
            this.textBoxNM = new System.Windows.Forms.TextBox();
            this.textBoxPS = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // textBoxNM
            // 
            this.textBoxNM.Location = new System.Drawing.Point(101, 52);
            this.textBoxNM.Name = "textBoxNM";
            this.textBoxNM.Size = new System.Drawing.Size(169, 22);
            this.textBoxNM.TabIndex = 2;
            // 
            // textBoxPS
            // 
            this.textBoxPS.Location = new System.Drawing.Point(100, 115);
            this.textBoxPS.Name = "textBoxPS";
            this.textBoxPS.Size = new System.Drawing.Size(170, 22);
            this.textBoxPS.TabIndex = 3;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(169, 168);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(101, 40);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(15, 168);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(94, 40);
            this.btBack.TabIndex = 5;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 237);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.textBoxPS);
            this.Controls.Add(this.textBoxNM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNM;
        private System.Windows.Forms.TextBox textBoxPS;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btBack;
    }
}