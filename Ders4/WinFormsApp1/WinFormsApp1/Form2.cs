using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int not1 = txtNot1.Text.Length == 0 ? 0 : int.Parse(txtNot1.Text);
            int not2 = txtNot2.Text.Length == 0 ? 0 : int.Parse(txtNot2.Text);

            int not3 = 0;
            if (txtNot3.TextLength == 0)
                not3 = 0;
            else
                not3 = int.Parse(txtNot3.Text);


            int ortalama = (not1 + not2 + not3) / 3;

            lblOrtalama.Text = ortalama.ToString();
        }

        private void txtNot1_TextChanged(object sender, EventArgs e)
        {
            btnHesapla_Click(btnHesapla, e);
        }
    }
}
