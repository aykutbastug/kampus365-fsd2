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

        private void btnHarcamaEkle_Click(object sender, EventArgs e)
        {
            frmHarcamaEkle frm = new frmHarcamaEkle();
            frm.ShowDialog();
        }

        private void btnListeyiYenile_Click(object sender, EventArgs e)
        {
            HarcamaDbContext db = new HarcamaDbContext();
            //dataGridView1.DataSource = db.
        }
    }
}
