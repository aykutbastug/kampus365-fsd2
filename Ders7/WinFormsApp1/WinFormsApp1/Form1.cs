namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Kisi> Kisiler = new List<Kisi>();
        public bool DegislikYapildiMi = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            #region fake kayıtlar
            //Kisiler.Add(new Kisi
            //{
            //    Telefon = "0543 375 8551",
            //    AdiSoyadi = "Aykut BAŞTUĞ",
            //    Cinsiyet = true,
            //    Grup = "İş"
            //});

            //Kisiler.Add(new Kisi
            //{
            //    Telefon = "0543 123 1234",
            //    AdiSoyadi = "Murat BAŞEREN",
            //    Cinsiyet = true,
            //    Grup = "İş"
            //});

            //Kisiler.Add(new Kisi
            //{
            //    Telefon = "0543 111 2345",
            //    AdiSoyadi = "Betül YANIK",
            //    Cinsiyet = false,
            //    Grup = "Arkadaş"
            //}); 
            #endregion


            //ListeyiDoldur();

            btnOku_Click(btnOku, null);
        }

        public void ListeyiDoldur()
        {
            lvKisiler.Items.Clear();

            foreach (var kisi in Kisiler)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] { kisi.AdiSoyadi, kisi.Telefon, kisi.AdiSoyadi, kisi.Grup });
                //listViewItem.ImageIndex = kisi.Cinsiyet ? 1 : 0;
                listViewItem.ImageKey = kisi.Cinsiyet ? "bay" : "bayan";

                //listViewItem.ImageIndex = kisi.Cinsiyet == true ? 1 : 0;

                //if (kisi.Cinsiyet == true)
                //    listViewItem.ImageIndex = 1;
                //else
                //    listViewItem.ImageIndex = 0;


                lvKisiler.Items.Add(listViewItem);
            }
        }

        private void rbtnDetayliGorunum_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDetayliGorunum.Checked)
                lvKisiler.View = View.Details;
            else if (rbtnBuyukSimge.Checked)
                lvKisiler.View = View.LargeIcon;
            else if (rbtnKucukSimge.Checked)
                lvKisiler.View = View.SmallIcon;
            else if (rbtnListe.Checked)
                lvKisiler.View = View.List;
            else if (rbtnDoseme.Checked)
                lvKisiler.View = View.Tile;
        }

        private void rbtnDoseme_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDoseme.Checked)
                lvKisiler.View = View.Tile;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\kisiler.txt";

            string[] kisiler = new string[Kisiler.Count];

            int i = 0;
            foreach (var kisi in Kisiler)
            {
                //kisiler[i] = $"telefon|adısoyadı|grup|cinsiyet";
                kisiler[i] = $"{kisi.Telefon}|{kisi.AdiSoyadi}|{kisi.Grup}|{kisi.Cinsiyet.ToString()}";
                i++;
            }

            File.WriteAllLines(path, kisiler);
            DegislikYapildiMi = false;
            MessageBox.Show($"Kişiler listesi '{path}' uzantısında kayıt edildi.");
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\kisiler.txt";

            if (!File.Exists(path))
            {
                MessageBox.Show("kisiler.txt dosyası bulunamadı..");
                return;
            }

            
            Kisiler.Clear();

            foreach (var item in File.ReadAllLines(path))
            {
                string[] dizi = item.Split('|');
                if (string.IsNullOrEmpty(dizi[0]))
                    continue;

                Kisiler.Add(new Kisi { 
                    Telefon = dizi[0],
                    AdiSoyadi = dizi[1],
                    Grup = dizi[2],
                    Cinsiyet = dizi[3] == "True" ? true : false
                });
            }

            ListeyiDoldur();
            DegislikYapildiMi = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmYeniKisiEkle frm = new frmYeniKisiEkle(this);
            frm.ShowDialog();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (txtBul.TextLength == 0)
            {
                btnFiltreyiKaldir_Click(null, null);
                return;
            }

            lvKisiler.Items.Clear();

            foreach (var kisi in Kisiler)
            {
                if (kisi.AdiSoyadi.ToLower().Contains(txtBul.Text.ToLower()) || kisi.Telefon.ToLower().Contains(txtBul.Text.ToLower()))
                {
                    ListViewItem li = new ListViewItem(new string[] { kisi.AdiSoyadi, kisi.Telefon, kisi.AdiSoyadi, kisi.Grup });
                    li.ImageKey = kisi.Cinsiyet ? "bay" : "bayan";
                    lvKisiler.Items.Add(li);
                }
            }
        }

        private void btnFiltreyiKaldir_Click(object sender, EventArgs e)
        {
            txtBul.Text = "";
            ListeyiDoldur();
        }

        private void txtBul_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtBul_KeyUp(object sender, KeyEventArgs e)
        {
            btnBul_Click(null, null);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DegislikYapildiMi)
            {
                if (MessageBox.Show("Formu kapatırsanız değişikler kaybolacak.\nYinede formu kapatmak istiyor musunuz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }
    }
}