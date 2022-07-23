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
    public partial class frmUrunListesi : Form
    {
        public frmUrunListesi()
        {
            InitializeComponent();
        }

        string connectionString = "server=AYKUTBASTUG-ZEN;DATABASE=Northwind;Trusted_Connection=true;";

        private void frmUrunListesi_Load(object sender, EventArgs e)
        {
            UrunListesiniDoldur();
        }

        private void UrunListesiniDoldur()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                List<Product> urunler = connection.Query<Product>("sp_UrunListesi", commandType: CommandType.StoredProcedure).ToList();
                dataGridView1.DataSource = urunler;
            }
        }

        private void yeniÜrünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrunEkle frm = new frmUrunEkle();
            frm.ShowDialog();
            UrunListesiniDoldur();
        }

        private void seçiliÜrünüGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmUrunGuncelle frm = new frmUrunGuncelle();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "select SupplierID, CompanyName from dbo.Suppliers";
                List<dynamic> tedarikciler = connection.Query(sql).ToList();

                frm.cmbSupplier.DataSource = tedarikciler;
                frm.cmbSupplier.ValueMember = "SupplierID";
                frm.cmbSupplier.DisplayMember = "CompanyName";


                sql = "select CategoryID, CategoryName from dbo.Categories";
                List<dynamic> kategoriler = connection.Query(sql).ToList();

                frm.cmbCategory.DataSource = kategoriler;
                frm.cmbCategory.ValueMember = "CategoryID";
                frm.cmbCategory.DisplayMember = "CategoryName";
            }


            frm.txtProductId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            frm.txtProductName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            frm.cmbSupplier.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            frm.cmbCategory.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            frm.txtQuantityPerUnit.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            frm.nupUnitPrice.Value = (decimal)dataGridView1.SelectedRows[0].Cells[7].Value;
            frm.nupUnitsInStock.Value = (int)dataGridView1.SelectedRows[0].Cells[8].Value;
            frm.nupUnitsOnOrder.Value = (int)dataGridView1.SelectedRows[0].Cells[9].Value;
            frm.nupReorderLevel.Value = (int)dataGridView1.SelectedRows[0].Cells[10].Value;
            frm.chkDiscontinued.Checked = (bool)dataGridView1.SelectedRows[0].Cells[11].Value;

            frm.ShowDialog();
            UrunListesiniDoldur();
        }

        private void seçiliÜrünüSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"{dataGridView1.SelectedRows[0].Cells[1].Value.ToString()} isimli ürünü silmek istediğinizden emin misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int sonuc = connection.Execute("delete from dbo.Products where ProductId=@id",
                        new
                        {
                            id = dataGridView1.SelectedRows[0].Cells[0].Value
                        }
                    );

                if (sonuc == 0)
                    MessageBox.Show("Ürün silinemedi.");
                else
                {
                    MessageBox.Show("Ürün silindi.");
                    UrunListesiniDoldur();
                }
            }
        }
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
}
