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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Musteri[] musteriListesi = new Musteri[15];

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            musteriListesi[listMusteriListesi.Items.Count] = new Musteri(txtAdi.Text, txtSoyadi.Text, txtEmail.Text, cmbCinsiyet.Text, dateDogumTarihi.Value);

            MusteriListesiniDoldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            musteriListesi[listMusteriListesi.SelectedIndex] = new Musteri(txtAdi.Text, txtSoyadi.Text, txtEmail.Text, cmbCinsiyet.Text, dateDogumTarihi.Value);

            MusteriListesiniDoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listMusteriListesi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Müşteri seçmediniz...");
                return;
            }

            if (MessageBox.Show("Seçili olan müşteriyi silmek istiyor musunuz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

            musteriListesi[listMusteriListesi.SelectedIndex] = null;
            MusteriListesiniDoldur();
        }

        private void MusteriListesiniDoldur()
        {
            listMusteriListesi.Items.Clear();

            foreach (var musteri in musteriListesi)
            {
                if (musteri != null)
                    listMusteriListesi.Items.Add(musteri.Adi + " " + musteri.Soyadi);
            }

            Temizle();
        }

        private void Temizle()
        {
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            txtEmail.Text = "";
            cmbCinsiyet.SelectedIndex = 0;
            dateDogumTarihi.Value = DateTime.Today;
        }

        private void listMusteriListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Temizle();

            if (listMusteriListesi.SelectedIndex < 0)
                return;

            Musteri musteri = musteriListesi[listMusteriListesi.SelectedIndex];

            txtAdi.Text = musteri.Adi;
            txtSoyadi.Text = musteri.Soyadi;
            txtEmail.Text = musteri.Email;
            cmbCinsiyet.Text = musteri.Cinsiyet;
            dateDogumTarihi.Value = musteri.DogumTarihi;
        }
    }
}
