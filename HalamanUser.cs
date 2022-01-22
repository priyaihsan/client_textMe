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
    public partial class HalamanUser : Form
    {
        ServiceTextMe.Service1 service = new ServiceTextMe.Service1();
        public HalamanUser()
        {   
            InitializeComponent();
            TampilData();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            this.Hide();
            fm1.Show();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string IDMessage = textBoxIDMess.Text;
            var a = service.deleteMessage(IDMessage);
            MessageBox.Show(a);
            Clear();
            TampilData();
            
        }

        public void TampilData()
        {
            string getname = Username.Text;
            var list = service.listMessage(getname);
            dtmessage.DataSource = list;
        }

        public void Clear()
        {
            textBoxIDMess.Clear();
        }

        private void dtmessage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIDMess.Text = Convert.ToString(dtmessage.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}
