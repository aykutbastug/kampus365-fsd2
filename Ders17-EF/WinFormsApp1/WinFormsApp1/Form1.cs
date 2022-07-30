using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HarcamaDbContext db = new HarcamaDbContext();
            db.Subeler.ToList();
        }

        private void btnSubeler_Click(object sender, EventArgs e)
        {
            frmSubeler frm = new frmSubeler();
            frm.ShowDialog();
        }

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            frmPersoneller frm = new frmPersoneller();
            frm.ShowDialog();
        }

        private void btnHarcamalar_Click(object sender, EventArgs e)
        {
            frmHarcamalar frm = new frmHarcamalar();
            frm.Show();
        }

        private void btnVerileriYenile_Click(object sender, EventArgs e)
        {
            VerileriYenile();
        }

        private void VerileriYenile()
        {
            HarcamaDbContext db = new HarcamaDbContext();
            lblToplamHarcama.Text = db.HarcamaDetaylari.Sum(x => x.Tutar).ToString("n2");
            lblToplamSubeSayisi.Text = db.Subeler.Count() + " Adet";
            lblToplamPersonelSayisi.Text = db.Personeller.Count() + " Kişi";


            var liste = db.HarcamaDetaylari
                            .Include(x => x.Harcama)
                            .Include(y => y.Harcama.Sube)
                            .GroupBy(a => a.Harcama.Sube.SubeAdi)
                            .Select(z =>
                                new { 
                                    SubeAdi = z.Key,
                                    HarcamaToplami = z.Sum(x => x.Tutar)
                                })
                            .ToList();

            dataGridView1.DataSource = liste;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            VerileriYenile();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            HarcamaDbContext db = new HarcamaDbContext();
            Sube sube = db.Subeler.Where(x => x.SubeAdi == dataGridView1.SelectedRows[0].Cells[0].Value.ToString()).FirstOrDefault();

            frmSubeHarcamalari frm = new frmSubeHarcamalari(sube.Id);
            frm.ShowDialog();
        }
    }
}