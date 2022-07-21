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
    }
}