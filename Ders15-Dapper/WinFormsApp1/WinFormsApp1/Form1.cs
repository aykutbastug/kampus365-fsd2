namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void müşteriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriListesi frm = new frmMusteriListesi();
            frm.Show();
        }

        private void müşteriLoglarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriLoglari frm = new frmMusteriLoglari();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void ürünListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrunListesi frm = new frmUrunListesi();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}