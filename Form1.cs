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
    public partial class Form1 : Form
    {
        ServiceTextMe.Service1 service = new ServiceTextMe.Service1();
        public Form1()
        {
            InitializeComponent();
            TampilData();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();

        }

        private void btKirim_Click(object sender, EventArgs e)
        {
            string IDMessage = textBoxID.Text;
            string Message = richTextBoxMessage.Text;
            int idPengguna = Convert.ToInt32(textBoxidPengguna.Text);

            var a = service.sendMessage(IDMessage, Message, idPengguna);
            

            if (textBoxID.Text == "" || richTextBoxMessage.Text == "" || textBoxidPengguna.Text == "")
            {
                MessageBox.Show("semua data wajib diisi");
            }
            else
            {
                MessageBox.Show(a);
                TampilData();
                Refresh();
            }
            
        }

        public void TampilData()
        {
            var list = service.listUsername();
            dtpengguna.DataSource = list;
        }

        public void Clear()
        {
            textBoxID.Clear();
            richTextBoxMessage.Clear();
            textBoxidPengguna.Clear();
        }
        public void dtpengguna_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = Convert.ToString(dtpengguna.Rows[e.RowIndex].Cells[0].Value);
            richTextBoxMessage.Text = Convert.ToString(dtpengguna.Rows[e.RowIndex].Cells[1].Value);
            textBoxidPengguna.Text = Convert.ToString(dtpengguna.Rows[e.RowIndex].Cells[2].Value);
        }

        public void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
