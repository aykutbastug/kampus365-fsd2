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
    public partial class frmMusteriSil : Form
    {
        string SilineccekMusteriKodu;
        frmMusteriListesi musteriListesiFormu;
        public frmMusteriSil(string silineccekMusteriKodu, frmMusteriListesi musteriListesiFormu)
        {
            InitializeComponent();
            SilineccekMusteriKodu = silineccekMusteriKodu;
            this.musteriListesiFormu = musteriListesiFormu;
        }

        private void frmMusteriSil_Load(object sender, EventArgs e)
        {

        }

        private void btnHayir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnEvet_Click(object sender, EventArgs e)
        {
            Form1.MusteriListesi.Remove(SilineccekMusteriKodu);
            musteriListesiFormu.ListeyiDoldur();
            this.Close();
        }
    }
}
