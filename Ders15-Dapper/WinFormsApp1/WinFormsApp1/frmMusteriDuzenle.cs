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
    public partial class frmMusteriDuzenle : Form
    {
        public frmMusteriDuzenle()
        {
            InitializeComponent();
        }

        private void frmMusteriDuzenle_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string connectionString = "server=AYKUTBASTUG-ZEN;DATABASE=Northwind;Trusted_Connection=true;";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("sp_CustomerInsert", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("CustomerID", txtCustomerID.Text);
            command.Parameters.AddWithValue("CompanyName", txtCompanyName.Text);
            command.Parameters.AddWithValue("ContactName", txtContactName.Text);
            command.Parameters.AddWithValue("ContactTitle", txtContactTitle.Text);
            command.Parameters.AddWithValue("Address", txtAddress.Text);
            command.Parameters.AddWithValue("City", txtCity.Text);
            command.Parameters.AddWithValue("Region", txtRegion.Text);
            command.Parameters.AddWithValue("PostalCode", txtPostalCode.Text);
            command.Parameters.AddWithValue("Country", txtCountry.Text);
            command.Parameters.AddWithValue("Phone", txtPhone.Text);
            command.Parameters.AddWithValue("Fax", txtFax.Text);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }
    }
}
