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
    public partial class HalamanAdmin : Form
    {
        ServiceTextMe.Service1 service = new ServiceTextMe.Service1();
        public HalamanAdmin()
        {
            InitializeComponent();
            TampilData();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void btRegistrasi_Click(object sender, EventArgs e)
        {
            string IDpengguna = textBoxIDpengguna.Text;
            string NamaPengguna = textBoxNamaPengguna.Text;
            string PasswordPengguna = textBoxPasswordPengguna.Text;

            var a = service.registrasiUser(IDpengguna, NamaPengguna, PasswordPengguna);

            if (textBoxIDpengguna.Text == "" || textBoxNamaPengguna.Text == "" || textBoxPasswordPengguna.Text == "")
            {
                MessageBox.Show("semua data wajib diisi");
            }
            else
            {
                MessageBox.Show(a);
                Refresh();
                TampilData();
            }

        }

        public void TampilData()
        {
            var list = service.listUsername();
            dtPengguna.DataSource = list;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
