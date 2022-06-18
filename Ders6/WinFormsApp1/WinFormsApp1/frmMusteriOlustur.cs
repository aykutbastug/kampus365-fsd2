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
    public partial class frmMusteriOlustur : Form
    {
        frmMusteriListesi frmListe;

        public frmMusteriOlustur(frmMusteriListesi frmListe)
        {
            InitializeComponent();
            this.frmListe = frmListe;
        }

        private void frmMusteriOlustur_Load(object sender, EventArgs e)
        {
            btnMusteriKoduUret_Click(btnMusteriKoduUret, null);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (var item in txtMusteriKodu.Text.ToCharArray())
            {
                if (!char.IsNumber(item))
                {
                    MessageBox.Show("Müşteri kodunda sadece sayı girebilirsiniz..");
                    return;
                }

            }

            if (Form1.MusteriListesi.ContainsKey(txtMusteriKodu.Text))
            {
                MessageBox.Show("Müşteri kodu kullanılmaktadır.");
                return;
            }


            Musteri yeniMusteri = new Musteri();
            yeniMusteri.MusteriKodu = txtMusteriKodu.Text;
            yeniMusteri.Adi = txtAdi.Text;
            yeniMusteri.Soyadi = txtSoyadi.Text;
            yeniMusteri.DogumTarihi = dateDogumtarihi.Value;
            yeniMusteri.Cinsiyet = cmbCinsiyet.Text;

            yeniMusteri.CepTelefonu = maskCepTelefonu.Text;
            yeniMusteri.IsTelefonu = maskIsTelefonu.Text;
            yeniMusteri.Email = txtEmail.Text;
            yeniMusteri.Sehir = cmbIl.Text;
            yeniMusteri.Adres = txtAdres.Text;

            Form1.MusteriListesi.Add(txtMusteriKodu.Text, yeniMusteri);
            frmListe.ListeyiDoldur();
            this.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (var control in groupBox1.Controls)
            {
                if (control is TextBox)
                    (control as TextBox).Text = "";

                if (control is DateTimePicker)
                    (control as DateTimePicker).Value = DateTime.Today;

                if (control is ComboBox)
                    (control as ComboBox).SelectedIndex = -1;

            }

            foreach (var control in groupBox2.Controls)
            {
                if (control is TextBox)
                    (control as TextBox).Text = "";

                if (control is MaskedTextBox)
                    (control as MaskedTextBox).Text = "";

                if (control is ComboBox)
                    (control as ComboBox).SelectedIndex = -1;

            }

            txtMusteriKodu.Focus();
        }

        private void btnMusteriKoduUret_Click(object sender, EventArgs e)
        {
            int enbuyukSayi = 0;
            foreach (var item in Form1.MusteriListesi.Keys)
            {
                int sayi = int.Parse(item);
                if (sayi > enbuyukSayi)
                {
                    enbuyukSayi = sayi;
                }
            }

            string yeniKod = (enbuyukSayi + 1).ToString().PadLeft(4, '0');
            txtMusteriKodu.Text = yeniKod;
        }
    }
}
