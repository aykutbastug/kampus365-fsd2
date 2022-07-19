using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = "server=AYKUTBASTUG-ZEN;database=Ders13;Trusted_Connection=true;";
        //string connectionString = "server=AYKUTBASTUG-ZEN;database=Ders13;user Id=sa;Password=123456;";
        SqlConnection connection;

        private void button1_Click(object sender, EventArgs e)
        {
            frmKisiEkle frm = new frmKisiEkle();
            frm.ShowDialog();
            KisileriDoldur();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KisileriDoldur();
        }

        private void KisileriDoldur()
        {
            connection = new SqlConnection(connectionString);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from [dbo].[ViewKisiListesi]", connection);

            DataTable dataTable = new DataTable();
            connection.Open();
            sqlDataAdapter.Fill(dataTable);
            connection.Close();
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            lblKayitNo.Text = "";
            lblTelefon.Text = "";
            lblAdiSoyadi.Text = "";
            lblEmail.Text = "";
            lblSehir.Text = "";

            if (dataGridView1.SelectedRows.Count == 0)
                return;

            lblKayitNo.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            lblTelefon.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            lblAdiSoyadi.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            lblEmail.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            lblSehir.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(lblAdiSoyadi.Text + " isimli kişiyi silmek istiyor musunuz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;


            SqlCommand sqlCommand = new SqlCommand("delete from dbo.Kisiler where Id=@Id", connection);
            sqlCommand.Parameters.AddWithValue("Id", lblKayitNo.Text);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Kayıt silindi.");
            KisileriDoldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from dbo.Sehirler order by Adi", connection);

            frmGuncelle frm = new frmGuncelle();

            DataTable dataTable = new DataTable();
            connection.Open();
            sqlDataAdapter.Fill(dataTable);
            connection.Close();
            frm.cmbSehir.DataSource = dataTable;


            frm.txtKayitNo.Text = lblKayitNo.Text;
            frm.txtTelefon.Text = lblTelefon.Text;
            frm.txtAdiSoyadi.Text = lblAdiSoyadi.Text;
            frm.txtEmail.Text = lblEmail.Text;
            frm.cmbSehir.Text = lblSehir.Text;

            frm.ShowDialog();
            KisileriDoldur();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btnGuncelle_Click(btnGuncelle, null);
        }
    }
}