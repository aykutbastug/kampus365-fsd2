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
    public partial class frmHarcamalar : Form
    {
        public frmHarcamalar()
        {
            InitializeComponent();
        }

        HarcamaDbContext db = new HarcamaDbContext();
        private void btnHarcamaEkle_Click(object sender, EventArgs e)
        {
            frmHarcamaEkle frm = new frmHarcamaEkle();
            frm.ShowDialog();
        }

        private void btnListeyiYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Harcamalar
                                            .Include(h => h.Sube)
                                            .Include(h => h.Personel)
                                            .Select(h =>
                                                new
                                                {
                                                    Id = h.Id,
                                                    SubeAdi = h.Sube.SubeAdi,
                                                    PersonelAdi = h.Personel.AdiSoyadi,
                                                    FisNo = h.FisNo,
                                                    HarcamaTarihi = h.HarcamaTarihi.ToShortDateString()
                                                })
                                            .ToList();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            int harcamaId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            var harcamaDetaylari = db.HarcamaDetaylari
                                                    .Where(x => x.HarcamaId == harcamaId)                                                    
                                                    .Select(x => 
                                                        new
                                                        {
                                                            Aciklama = x.Aciklama,
                                                            Tutar = x.Tutar
                                                        })
                                                    .ToList();

            dataGridView2.DataSource = harcamaDetaylari;

            lblHarcamaToplami.Text = db.HarcamaDetaylari
                                        .Where(x => x.HarcamaId == harcamaId)
                                        .Sum(x => x.Tutar)
                                        .ToString("n2");
        }
    }
}
