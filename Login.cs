using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientTextMe
{
    public partial class Login : Form
    {
        ServiceTextMe.Service1 service = new ServiceTextMe.Service1();
        public Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxNM.Text;
            string password = textBoxPS.Text;
            string kategori = service.Login(username, password);
            if (kategori == "Admin")
            {
                HalamanAdmin ha = new HalamanAdmin();
                this.Hide();
                ha.Show();
            }
            else if (kategori != "gagal")
            {
                
                HalamanUser hu = new HalamanUser();
                this.Hide();
                hu.Username.Text = kategori;
                hu.Show();
            }
            else
            {
                MessageBox.Show("Username and Password Invalid, Silahkan hubungi admin");
                textBoxNM.Clear();
                textBoxPS.Clear();
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            this.Hide();
            fm1.Show();

        }
    }
}
