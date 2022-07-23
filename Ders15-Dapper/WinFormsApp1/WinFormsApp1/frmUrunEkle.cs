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
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }

        string connectionString = "server=AYKUTBASTUG-ZEN;DATABASE=Northwind;Trusted_Connection=true;";

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "select SupplierID, CompanyName from dbo.Suppliers";
                List<dynamic> tedarikciler = connection.Query(sql).ToList();

                cmbSupplier.DataSource = tedarikciler;
                cmbSupplier.ValueMember = "SupplierID";
                cmbSupplier.DisplayMember = "CompanyName";


                sql = "select CategoryID, CategoryName from dbo.Categories";
                List<dynamic> kategoriler = connection.Query(sql).ToList();

                cmbCategory.DataSource = kategoriler;
                cmbCategory.ValueMember = "CategoryID";
                cmbCategory.DisplayMember = "CategoryName";
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int sonuc = connection.Execute("sp_UrunEkle", 
                    new
                    {
                        ProductName = txtProductName.Text,
                        SupplierID = cmbSupplier.SelectedValue,
                        CategoryID = cmbCategory.SelectedValue,
                        QuantityPerUnit = txtQuantityPerUnit.Text,
                        UnitPrice = nupUnitPrice.Value,
                        UnitsInStock = nupUnitsInStock.Value,
                        UnitsOnOrder = nupUnitsOnOrder.Value,
                        ReorderLevel = nupReorderLevel.Value,
                        Discontinued = chkDiscontinued.Checked
                    },
                    commandType: CommandType.StoredProcedure);


                if (sonuc == 0)
                    MessageBox.Show("Kayıt eklenemedi.");
                else
                    this.Close();
            }
        }
    }
}
