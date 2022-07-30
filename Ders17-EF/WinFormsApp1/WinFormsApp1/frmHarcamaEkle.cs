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
    public partial class frmHarcamaEkle : Form
    {
        public frmHarcamaEkle()
        {
            InitializeComponent();
        }

        HarcamaDbContext db = new HarcamaDbContext();


        private void frmHarcamaEkle_Load(object sender, EventArgs e)
        {
            List<Sube> subeler = db.Subeler.ToList();
            cmbSube.DataSource = subeler;
            cmbSube.DisplayMember = "SubeAdi";
            cmbSube.ValueMember = "Id";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Harcama harcama = new Harcama { 
                FisNo = txtFisNo.Text,
                HarcamaTarihi = dateHarcamaTarihi.Value,
                PersonelId = int.Parse(cmbPersonel.SelectedValue.ToString()),
                SubeId = int.Parse(cmbSube.SelectedValue.ToString())                
            };
            db.Harcamalar.Add(harcama);
            db.SaveChanges();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[0].Value.ToString()))
                    continue;

                HarcamaDetay harcamaDetay = new HarcamaDetay {
                    Aciklama = dataGridView1.Rows[i].Cells[0].Value.ToString(),
                    Tutar = decimal.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()),
                    HarcamaId = harcama.Id
                };


                db.HarcamaDetaylari.Add(harcamaDetay);
            }

            
            db.SaveChanges();
            this.Close();
        }

        private void cmbSube_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSube.SelectedValue == null)
                return;

            int subeId = 0;
            if (cmbSube.SelectedValue is Sube)
                subeId = ((Sube)cmbSube.SelectedValue).Id;
            else
                subeId = int.Parse(cmbSube.SelectedValue.ToString());

            List<Personel> personeller = db.Personeller
                                                .Where(p => p.SubeId == subeId)
                                                .ToList();
            cmbPersonel.DataSource = personeller;
            cmbPersonel.DisplayMember = "AdiSoyadi";
            cmbPersonel.ValueMember = "Id";
        }
    }
}
