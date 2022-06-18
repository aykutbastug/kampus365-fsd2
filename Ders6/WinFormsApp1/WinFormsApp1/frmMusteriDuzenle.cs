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
    public partial class frmMusteriDuzenle : Form
    {
        public Musteri SeciliMusteri { get; set; } = new Musteri();
        frmMusteriListesi musteriListesiFormu;
        public frmMusteriDuzenle(frmMusteriListesi musteriListesiFormu)
        {
            InitializeComponent();
            this.musteriListesiFormu = musteriListesiFormu;
        }

        private void frmMusteriDuzenle_Load(object sender, EventArgs e)
        {
            VerileriDoldur();
        }

        private void VerileriDoldur()
        {
            txtMusteriKodu.Text = SeciliMusteri.MusteriKodu;
            txtAdi.Text = SeciliMusteri.Adi;
            txtSoyadi.Text = SeciliMusteri.Soyadi;
            dateDogumtarihi.Value = SeciliMusteri.DogumTarihi;
            cmbCinsiyet.Text = SeciliMusteri.Cinsiyet;


            maskCepTelefonu.Text = SeciliMusteri.CepTelefonu;
            maskIsTelefonu.Text = SeciliMusteri.IsTelefonu;
            txtEmail.Text = SeciliMusteri.Email;
            cmbIl.Text = SeciliMusteri.Sehir;
            txtAdres.Text = SeciliMusteri.Adres;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            VerileriDoldur();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (SeciliMusteri.MusteriKodu != txtMusteriKodu.Text)
            {
                if (Form1.MusteriListesi.ContainsKey(txtMusteriKodu.Text))
                {
                    MessageBox.Show("Müşteri kodu zaten kayıtlı..");
                    return;
                }
            }


            Musteri musteri = new Musteri();
            musteri.MusteriKodu = txtMusteriKodu.Text;
            musteri.Adi = txtAdi.Text;
            musteri.Soyadi = txtSoyadi.Text;
            musteri.DogumTarihi = dateDogumtarihi.Value;
            musteri.Cinsiyet = cmbCinsiyet.Text;
            
            musteri.CepTelefonu = maskCepTelefonu.Text;
            musteri.IsTelefonu = maskIsTelefonu.Text;
            musteri.Email = txtEmail.Text;
            musteri.Sehir = cmbIl.Text;
            musteri.Adres = txtAdres.Text;


            Form1.MusteriListesi.Remove(SeciliMusteri.MusteriKodu);
            Form1.MusteriListesi.Add(txtMusteriKodu.Text, musteri);

            musteriListesiFormu.ListeyiDoldur();
            this.Close();
        }
    }
}
