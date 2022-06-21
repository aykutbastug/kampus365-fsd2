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
    public partial class frmYeniKisiEkle : Form
    {
        private Form1 masterForm;
        public frmYeniKisiEkle(Form1 masterForm)
        {
            InitializeComponent();
            this.masterForm = masterForm;
        }

        private void frmYeniKisiEkle_Load(object sender, EventArgs e)
        {
            GruplariDoldur();
        }

        private void GruplariDoldur()
        {
            string path = Application.StartupPath + "\\gruplar.txt";
            string[] gruplar = File.ReadAllLines(path);

            cmbGrup.Items.Clear();
            foreach (var grup in gruplar)
            {
                cmbGrup.Items.Add(grup);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAdiSoyadi.Text.Contains("|") || txtTelefon.Text.Contains("|"))
            {
                MessageBox.Show("'|' özel karakterini kullanamazsınız..");

                if (txtAdiSoyadi.Text.Contains("|"))
                {
                    txtAdiSoyadi.Focus();
                    txtAdiSoyadi.SelectAll();
                }
                if (txtTelefon.Text.Contains("|"))
                {
                    txtTelefon.Focus();
                    txtTelefon.SelectAll();
                }
                return;
            }

            if (cmbCinsiyet.SelectedIndex < 0)
            {
                MessageBox.Show("Cinsiyet seçmeden kayıt yapamazsınız..");
                cmbCinsiyet.Focus();
                return;
            }

            if (cmbGrup.SelectedIndex < 0)
            {
                MessageBox.Show("Grup seçmeden kayıt yapamazsınız..");
                cmbGrup.Focus();
                return;
            }

            foreach (var kisi in masterForm.Kisiler)
            {
                if (kisi.AdiSoyadi == txtAdiSoyadi.Text)
                {
                    MessageBox.Show($"{kisi.AdiSoyadi} isimli kişi {kisi.Telefon} numarası ile zaten kayıtlı...");
                    return;
                }

                if (kisi.Telefon == txtTelefon.Text)
                {
                    MessageBox.Show($"{kisi.Telefon}  numaralı telefon {kisi.AdiSoyadi} isimli kişi olarak zaten kayıtlı...");
                    return;
                }
            }

            masterForm.Kisiler.Add(new Kisi { 
                AdiSoyadi = txtAdiSoyadi.Text,
                Telefon = txtTelefon.Text,
                Grup = cmbGrup.Text,
                Cinsiyet = cmbCinsiyet.Text == "Bay" ? true : false
            });

            masterForm.DegislikYapildiMi = true;   masterForm.DegislikYapildiMi = true;
            masterForm.ListeyiDoldur();
            this.Close();
        }

        private void frmYeniKisiEkle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            else if (e.KeyCode == Keys.Enter)
                btnKaydet_Click(btnKaydet, null);
        }

        private void btnGrupEkle_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

        }

        private void btnGrupIptal_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnGrupKaydet_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\gruplar.txt";
            List<string> gruplar = File.ReadAllLines(path).ToList();


            if (gruplar.Contains(txtGrup.Text))
            {
                MessageBox.Show($"{txtGrup.Text} isimli grup zaten kayıtlı..");
                return;
            }

            gruplar.Add(txtGrup.Text);
            File.WriteAllLines(path, gruplar);

            GruplariDoldur();
            panel1.Visible = false;
            cmbGrup.Text = txtGrup.Text;
        }
    }
}
