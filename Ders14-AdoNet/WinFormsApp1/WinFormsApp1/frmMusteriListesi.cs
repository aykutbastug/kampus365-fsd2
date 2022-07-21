using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmMusteriListesi : Form
    {
        public frmMusteriListesi()
        {
            InitializeComponent();
        }

        string connectionString = "server=AYKUTBASTUG-ZEN;DATABASE=Northwind;Trusted_Connection=true;";
        SqlConnection connection;

        private void frmMusteriListesi_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            MusteriListesiniDoldur();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            MusteriListesiniDoldur();
        }

        private void MusteriListesiniDoldur()
        {            
            SqlDataAdapter adapter = new SqlDataAdapter("sp_CustomerSearch", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("metin", txtAra.Text);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void müşteriyiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            frmMusteriDuzenle frm = new frmMusteriDuzenle();
            frm.txtCustomerID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            frm.txtCompanyName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            frm.txtContactName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            frm.txtContactTitle.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            frm.txtAddress.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            frm.txtCity.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            frm.txtRegion.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            frm.txtPostalCode.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            frm.txtCountry.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            frm.txtPhone.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            frm.txtFax.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();

            frm.ShowDialog();
            MusteriListesiniDoldur();
        }

        private void müşteriyiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            SqlCommand command = new SqlCommand("delete from dbo.Customers where CustomerID=@CustomerID", connection);
            command.Parameters.AddWithValue("CustomerID", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri kaydı silindi");
            MusteriListesiniDoldur();
        }
    }
}
