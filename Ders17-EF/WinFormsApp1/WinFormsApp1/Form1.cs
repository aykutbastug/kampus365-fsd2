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
    }
}