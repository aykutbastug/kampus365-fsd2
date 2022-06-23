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
    public partial class frmBul : Form
    {
        Form1 form1;
        public frmBul(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void frmBul_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pos = form1.textBox1.Text.IndexOf(textBox1.Text);
            if (pos != -1)
            {
                form1.textBox1.SelectionStart = pos;
                form1.textBox1.SelectionLength = textBox1.TextLength;
                form1.textBox1.Focus();
            }
        }

        private void frmBul_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(button1, null);
            else if (e.KeyCode == Keys.Escape)
                button2_Click(button2, null);
        }
    }
}
