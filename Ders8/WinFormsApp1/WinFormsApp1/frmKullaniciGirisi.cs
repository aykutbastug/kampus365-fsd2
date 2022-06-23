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
    public partial class frmKullaniciGirisi : Form
    {
        Form1 form1;
        public frmKullaniciGirisi(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void frmKullaniciGirisi_Load(object sender, EventArgs e)
        {

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "aykut" && txtSifre.Text == "1234")
            {
                form1.Ozellikler.LoginOlundumu = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını veya şifresini hatalı girdiniz..");
            }
        }

        private void frmKullaniciGirisi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGirisYap_Click(btnGirisYap, null);
            else if (e.KeyCode == Keys.Escape)
                btnVazgec_Click(btnVazgec, null);
        }
    }
}
