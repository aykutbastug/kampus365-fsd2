namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public NotDefteriOzellikleri Ozellikler = new NotDefteriOzellikleri();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ozellikler.DosyaAdi = "Yeni Not.txt";
            Ozellikler.DegisikliklerKayitEdilmi = false;

            this.Text = Ozellikler.DosyaAdi;


            frmKullaniciGirisi frm = new frmKullaniciGirisi(this);
            frm.ShowDialog();

            if (!Ozellikler.LoginOlundumu)
                Application.Exit();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Ozellikler.Path))
            {
                FileStream fileStream = new FileStream(Ozellikler.Path, FileMode.Create);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(textBox1.Text);
                streamWriter.Close();
                fileStream.Close();
            }
            else
            {
                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                    return;

                FileStream fileStream = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(textBox1.Text);
                streamWriter.Close();
                fileStream.Close();
            }


            Ozellikler.DegisikliklerKayitEdilmi = true;
            this.Text = this.Text.Replace("* ", "");
        }


        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            FileStream fileStream = new FileStream(saveFileDialog1.FileName, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(textBox1.Text);
            streamWriter.Close();
            fileStream.Close();

            string[] dizi = saveFileDialog1.FileName.Split('\\');

            this.Text = dizi[dizi.Length - 1];
            Ozellikler.DosyaAdi = dizi[dizi.Length - 1];
            Ozellikler.Path = saveFileDialog1.FileName;
            Ozellikler.DegisikliklerKayitEdilmi = true;
        }

        private void dosyaAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;


            FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);
            textBox1.Text = streamReader.ReadToEnd();
            streamReader.Close();
            fileStream.Close();

            string[] dizi = openFileDialog1.FileName.Split('\\');

            this.Text = dizi[dizi.Length - 1];
            Ozellikler.DosyaAdi = dizi[dizi.Length - 1];
            Ozellikler.Path = openFileDialog1.FileName;
            Ozellikler.DegisikliklerKayitEdilmi = true;
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void uygulamayıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Ozellikler.DegisikliklerKayitEdilmi)
            {
                if (MessageBox.Show("Yaptığınız değişikler kayıt edilmedi.\nYinede kapatmak istiyor musunuz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
            }
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Ozellikler.DegisikliklerKayitEdilmi = false;

            if (!this.Text.StartsWith("* "))
                this.Text = "* " + this.Text;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var marginBound = new RectangleF(e.MarginBounds.X, e.MarginBounds.Y, e.MarginBounds.Width, e.MarginBounds.Height);

            e.Graphics.DrawString(textBox1.Text, textBox1.Font, Brushes.Black, marginBound);

        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
                textBox1.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
                textBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                if (textBox1.SelectionLength > 0)
                {
                    textBox1.SelectionStart = textBox1.SelectionStart + textBox1.SelectionLength;
                }
                textBox1.Paste();
            }
        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void büyükHarferÇevirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
        }

        private void küçükHarfeÇevirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToLower();
        }

        private void bulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBul frm = new frmBul(this);
            frm.Show();
        }

        private void tümünüDeğiştriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDegistir frm = new frmDegistir(this);
            frm.Show();
        }
    }
}