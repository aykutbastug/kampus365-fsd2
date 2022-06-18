namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Dictionary<string, Musteri> MusteriListesi = new Dictionary<string, Musteri>();

        private void Form1_Load(object sender, EventArgs e)
        {
            MusteriListesi.Add("0001", new Musteri() {  MusteriKodu = "0001", Adi = "Adı 1", Soyadi = "Soaydı 1", Sehir = "ANKARA", Adres = "adres 1", CepTelefonu = "5431111111", IsTelefonu = "5551111111", Cinsiyet = "Erkek", DogumTarihi = DateTime.Today.AddDays(-30), Email = "musteri1@deneme.com" });


            MusteriListesi.Add("0002", new Musteri() { MusteriKodu = "0002", Adi = "Adı 2", Soyadi = "Soaydı 2", Sehir = "İSTANBUL", Adres = "adres 2", CepTelefonu = "5432222222", IsTelefonu = "55522222222", Cinsiyet = "Erkek", DogumTarihi = DateTime.Today.AddDays(-18), Email = "musteri2@deneme.com" });

            MusteriListesi.Add("0003", new Musteri() { MusteriKodu = "0003", Adi = "Adı 3", Soyadi = "Soaydı 3", Sehir = "İZMİR", Adres = "adres 3", CepTelefonu = "5433333333", IsTelefonu = "5553333333", Cinsiyet = "Kadın", DogumTarihi = DateTime.Today.AddDays(-23), Email = "musteri3@deneme.com" });

        }

        frmMusteriListesi musteriListesiFormu = new frmMusteriListesi();
        private void müşteriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            //musteriListesi.ShowDialog();
            musteriListesiFormu.MdiParent = this;
            musteriListesiFormu.WindowState = FormWindowState.Maximized;
            musteriListesiFormu.Show();
        }

        private void uygumadanÇıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yeniMüşteriOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriOlustur musteriOlustur = new frmMusteriOlustur(musteriListesiFormu);
            musteriOlustur.MdiParent = this;
            musteriOlustur.Show();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHakkinda hakkinda = new frmHakkinda();
            hakkinda.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Uygulamadan çıkmak istiyor musunuz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }
    }
}