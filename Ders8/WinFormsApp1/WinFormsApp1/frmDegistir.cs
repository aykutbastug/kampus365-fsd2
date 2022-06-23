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
    public partial class frmDegistir : Form
    {
        Form1 form1;
        public frmDegistir(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void frmDegistir_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.textBox1.Text = form1.textBox1.Text.Replace(textBox1.Text, textBox2.Text);
            form1.textBox1.SelectionStart = 0;
            form1.textBox1.SelectionLength = 0;
            form1.textBox1.Focus();
        }

        private void frmDegistir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(button1, null);
            else if (e.KeyCode == Keys.Escape)
                button2_Click(button2, null);
        }
    }
}
