namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static decimal BirinciSayi { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSonuc.Focus();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtSonuc.Text = txtSonuc.Text + btn.Text;
            txtSonuc.Focus();
            txtSonuc.SelectionStart = txtSonuc.TextLength;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtSonuc.TextLength == 0)
                return;

            if (txtSonuc.TextLength == 1)
            {
                txtSonuc.Text = "";
                return;
            }

            txtSonuc.Text = txtSonuc.Text.Substring(0, txtSonuc.TextLength - 1);
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            if (txtSonuc.TextLength == 0)
                return;

            BirinciSayiyiYaz();
            btnEsittir.Tag = "+";
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (txtSonuc.TextLength == 0)
                return;
            BirinciSayiyiYaz();
            btnEsittir.Tag = "-";
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            if (txtSonuc.TextLength == 0)
                return;
            BirinciSayiyiYaz();
            btnEsittir.Tag = "/";
        }

        private void btnCarma_Click(object sender, EventArgs e)
        {
            if (txtSonuc.TextLength == 0)
                return;
            BirinciSayiyiYaz();
            btnEsittir.Tag = "*";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            if (txtSonuc.TextLength == 0)
                return;
            BirinciSayiyiYaz();
            btnEsittir.Tag = "";
        }


        private void BirinciSayiyiYaz()
        {
            BirinciSayi = decimal.Parse(txtSonuc.Text);
            txtSonuc.Text = "";
            txtSonuc.Focus();
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            decimal sonuc = 0;

            if (btnEsittir.Tag.ToString() == "+")
                sonuc = BirinciSayi + decimal.Parse(txtSonuc.Text);
            else if (btnEsittir.Tag.ToString() == "-")
                sonuc = BirinciSayi - decimal.Parse(txtSonuc.Text);
            else if (btnEsittir.Tag.ToString() == "/")
                sonuc = BirinciSayi / decimal.Parse(txtSonuc.Text);
            else if (btnEsittir.Tag.ToString() == "*")
                sonuc = BirinciSayi * decimal.Parse(txtSonuc.Text);

            txtSonuc.Text = sonuc.ToString();
        }

        private void txtSonuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\\r")
                btn1_Click(btnEsittir, new EventArgs());

                if (!char.IsNumber(e.KeyChar) && e.KeyChar.ToString() != ",")
                e.Handled = true;

            if (e.KeyChar.ToString() == "," && txtSonuc.Text.Contains(","))
                e.Handled = true;
        }
    }
}