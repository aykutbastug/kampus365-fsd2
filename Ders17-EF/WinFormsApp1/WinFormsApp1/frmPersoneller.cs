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
    public partial class frmPersoneller : Form
    {
        public frmPersoneller()
        {
            InitializeComponent();
        }

        HarcamaDbContext db = new HarcamaDbContext();

        private void frmPersoneller_Load(object sender, EventArgs e)
        {
            cmbSube.DataSource = db.Subeler.ToList();
            cmbSube.DisplayMember = "SubeAdi";
            cmbSube.ValueMember = "Id";

            ListeyiDoldur();
        }

        private void ListeyiDoldur()
        {
            dataGridView1.DataSource = db.Personeller.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel { 
                AdiSoyadi = txtAdiSoyadi.Text,
                Email = txtEmail.Text,
                Telefon = txtTelefon.Text,
                SubeId = int.Parse(cmbSube.SelectedValue.ToString())
            };

            db.Personeller.Add(personel);
            db.SaveChanges();
            ListeyiDoldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            int personelId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            Personel personel = db.Personeller.FirstOrDefault(x => x.Id == personelId);
            personel.Telefon = txtTelefon.Text;
            personel.AdiSoyadi = txtAdiSoyadi.Text;
            personel.Email = txtEmail.Text;
            personel.SubeId = int.Parse(cmbSube.SelectedValue.ToString());

            db.Personeller.Update(personel);
            db.SaveChanges();

            ListeyiDoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            int personelId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            Personel personel = db.Personeller.FirstOrDefault(x => x.Id == personelId);

            db.Personeller.Remove(personel);
            db.SaveChanges();
            ListeyiDoldur();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            cmbSube.SelectedIndex = -1;
            txtAdiSoyadi.Text = "";
            txtEmail.Text = "";
            txtTelefon.Text = "";

            if (dataGridView1.SelectedRows.Count == 0)
                return;

            int personelId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            Personel personel = db.Personeller.FirstOrDefault(x => x.Id == personelId);

            cmbSube.SelectedValue = personel.SubeId;
            txtAdiSoyadi.Text = personel.AdiSoyadi;
            txtEmail.Text = personel.Email;
            txtTelefon.Text = personel.Telefon;
        }
    }
}
