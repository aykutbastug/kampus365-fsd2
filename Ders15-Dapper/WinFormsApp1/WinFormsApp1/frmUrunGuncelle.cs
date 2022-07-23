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
    public partial class frmUrunGuncelle : Form
    {
        public frmUrunGuncelle()
        {
            InitializeComponent();
        }
        string connectionString = "server=AYKUTBASTUG-ZEN;DATABASE=Northwind;Trusted_Connection=true;";

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("ProductId", txtProductId.Text);
                parameters.Add("ProductName", txtProductName.Text);
                parameters.Add("SupplierID", cmbSupplier.SelectedValue);
                parameters.Add("CategoryID", cmbCategory.SelectedValue);
                parameters.Add("QuantityPerUnit", txtQuantityPerUnit.Text);
                parameters.Add("UnitPrice", nupUnitPrice.Value);
                parameters.Add("UnitsInStock", nupUnitsInStock.Value);
                parameters.Add("UnitsOnOrder", nupUnitsOnOrder.Value);
                parameters.Add("ReorderLevel", nupReorderLevel.Value);
                parameters.Add("Discontinued", chkDiscontinued.Checked);


                int sonuc = connection.Execute("sp_UrunuGuncelle", parameters, commandType: CommandType.StoredProcedure);

                if (sonuc > 0)
                    this.Close();
                else
                    MessageBox.Show("Ürün güncellenemedi.");
            }
        }

        private void frmUrunGuncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
