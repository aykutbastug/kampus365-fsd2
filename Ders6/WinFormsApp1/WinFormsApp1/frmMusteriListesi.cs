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
    public partial class frmMusteriListesi : Form
    {
        public frmMusteriListesi()
        {
            InitializeComponent();
        }

        private void frmMusteriListesi_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }

        private void listMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Temizle();

            if (listMusteriler.SelectedItems.Count == 0)
                return;

            string musteriKodu = listMusteriler.SelectedItem.ToString().Split('-')[0].TrimEnd();
            Musteri musteri = Form1.MusteriListesi.GetValueOrDefault(musteriKodu);

            lblMusteriKodu.Text = musteri.MusteriKodu;
            lblAdi.Text = musteri.Adi;
            lblSoyadi.Text = musteri.Soyadi;
            lblDogumTarihi.Text = musteri.DogumTarihi.ToShortDateString();
            lblCinsiyet.Text = musteri.Cinsiyet;

            lblCepTelefonu.Text = musteri.CepTelefonu;
            lblIsTelefonu.Text = musteri.IsTelefonu;
            lblEmailAdresi.Text = musteri.Email;
            lblIl.Text = musteri.Sehir;
            lblAdres.Text = musteri.Adres;

        }

        public void ListeyiDoldur()
        {
            listMusteriler.Items.Clear();
            foreach (var musteri in Form1.MusteriListesi.Values)
            {
                listMusteriler.Items.Add($"{musteri.MusteriKodu} - {musteri.Adi} {musteri.Soyadi}");
            }
        }

        private void Temizle()
        {
            lblAdi.Text = "";
            lblSoyadi.Text = "";
            lblMusteriKodu.Text = "";
            lblDogumTarihi.Text = "";
            lblCinsiyet.Text = "";


            lblCepTelefonu.Text = "";
            lblIsTelefonu.Text = "";
            lblEmailAdresi.Text = "";
            lblIl.Text = "";
            lblAdres.Text = "";
        }

        private void btnYeniMusteriEkle_Click(object sender, EventArgs e)
        {
            frmMusteriOlustur musteriOlustur = new frmMusteriOlustur(this);
            musteriOlustur.MdiParent = this.MdiParent;
            musteriOlustur.Show();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (listMusteriler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Müşteri kaydı seçmediniz..");
                return;
            }

            DuzenleFormunuAc();
        }

        private void DuzenleFormunuAc()
        {
            string seciliMusteriKodu = listMusteriler.SelectedItems[0].ToString().Split('-')[0].TrimEnd();

            frmMusteriDuzenle musteriDuzenle = new frmMusteriDuzenle(this);
            musteriDuzenle.SeciliMusteri = Form1.MusteriListesi.GetValueOrDefault(seciliMusteriKodu);
            //musteriDuzenle.MdiParent = this.MdiParent;
            musteriDuzenle.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listMusteriler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Müşteri seçmediniz..");
                return;
            }

            string seciliMusteriKodu = listMusteriler.SelectedItems[0].ToString().Split('-')[0].TrimEnd();

            frmMusteriSil musteriSil = new frmMusteriSil(seciliMusteriKodu, this);
            musteriSil.lblMusteriBilgisi.Text = musteriSil.lblMusteriBilgisi.Text.Replace("{MusteriAdiSoyadi}", lblAdi.Text + " " + lblSoyadi.Text);

            musteriSil.ShowDialog();
        }

        private void listMusteriler_DoubleClick(object sender, EventArgs e)
        {
            if (listMusteriler.SelectedItems.Count == 0)
                return;

            DuzenleFormunuAc();
        }
    }
}
