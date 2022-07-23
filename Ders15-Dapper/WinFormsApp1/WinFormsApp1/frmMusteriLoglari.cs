using Dapper;
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
    public partial class frmMusteriLoglari : Form
    {
        public frmMusteriLoglari()
        {
            InitializeComponent();
        }

        string connectionString = "server=AYKUTBASTUG-ZEN;DATABASE=Northwind;Trusted_Connection=true;";
        private void frmMusteriLoglari_Load(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "select [Process], [ProcessDate], [CustomerID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Fax] from [dbo].[Log_Customers] order by CustomerID, ProcessDate";


                List<MusteriLog> loglar = connection.Query<MusteriLog>(sql).ToList();
                dataGridView1.DataSource = loglar;
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<MusteriLog> loglar = connection.Query<MusteriLog>("sp_MusteriLoglariniFiltrele",
                    new {
                        CustomerId = txtMusteriNo.Text,
                        sdate = dateStartDate.Value,
                        fdate = dateEndDate.Value
                    }, commandType: CommandType.StoredProcedure
                    ).ToList();

                dataGridView1.DataSource = loglar;
            }
        }
    }

    public class MusteriLog
    {
        public string Process { get; set; }
        public DateTime ProcessDate { get; set; }
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
    }
}

