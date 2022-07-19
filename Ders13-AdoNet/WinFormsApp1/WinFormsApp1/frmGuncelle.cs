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
    public partial class frmGuncelle : Form
    {
        public frmGuncelle()
        {
            InitializeComponent();
        }
        string connectionString = "server=AYKUTBASTUG-ZEN;database=Ders13;Trusted_Connection=true;";
        SqlConnection connection;

        private void frmGuncelle_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("UpdateKisi", connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("Id", txtKayitNo.Text);
            sqlCommand.Parameters.AddWithValue("Telefon", txtTelefon.Text);
            sqlCommand.Parameters.AddWithValue("AdiSoyadi", txtAdiSoyadi.Text);
            sqlCommand.Parameters.AddWithValue("Email", txtEmail.Text);
            sqlCommand.Parameters.AddWithValue("SehirId", cmbSehir.SelectedValue);

            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }
    }
}
