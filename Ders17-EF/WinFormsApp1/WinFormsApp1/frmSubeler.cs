using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class frmSubeler : Form
    {
        public frmSubeler()
        {
            InitializeComponent();
        }

        

        private void frmSubeler_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }

        private void ListeyiDoldur()
        {
            HarcamaDbContext db = new HarcamaDbContext();
            dataGridView1.DataSource = db.Subeler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            HarcamaDbContext db = new HarcamaDbContext();
            Sube sube = new Sube { 
                Adres = txtAdres.Text,
                Email = txtEmail.Text,
                SubeAdi = txtSubeAdi.Text,
                Telefon = txtTelefon.Text
            };

            db.Subeler.Add(sube);
            db.SaveChanges();

            ListeyiDoldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            HarcamaDbContext db = new HarcamaDbContext();
            int subeId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            //database den seçili şube Id ye ait kaydı çekiyoruz
            Sube sube = db.Subeler
                            .Where(s => s.Id == subeId)
                            .FirstOrDefault();

            sube.SubeAdi = txtSubeAdi.Text;
            sube.Adres = txtAdres.Text;
            sube.Email = txtEmail.Text;
            sube.Telefon = txtTelefon.Text;
            db.Subeler.Update(sube);
            db.SaveChanges();

            ListeyiDoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            if (MessageBox.Show($"{dataGridView1.SelectedRows[0].Cells[1].Value.ToString()} isimli şubeyi silmek istiyor musunuzz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            HarcamaDbContext db = new HarcamaDbContext();

            int subeId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            //database den seçili şube Id ye ait kaydı çekiyoruz
            Sube sube = db.Subeler
                            .Where(s => s.Id == subeId)
                            .FirstOrDefault();

            db.Subeler.Remove(sube);
            db.SaveChanges();

            ListeyiDoldur();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = "";
            }

            if (dataGridView1.SelectedRows.Count == 0)
                return;

            HarcamaDbContext db = new HarcamaDbContext();
            int subeId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            //database den seçili şube Id ye ait kaydı çekiyoruz
            Sube sube = db.Subeler
                            .Include(x => x.Personeller)
                            .Where(s => s.Id == subeId)
                            .FirstOrDefault();


            txtSubeAdi.Text = sube.SubeAdi;
            txtAdres.Text = sube.Adres;
            txtEmail.Text = sube.Email;
            txtTelefon.Text = sube.Telefon;

            dataGridView2.DataSource = sube.Personeller;
        }
    }
}
