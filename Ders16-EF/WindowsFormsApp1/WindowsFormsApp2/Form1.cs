using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DatabaseContext db = new DatabaseContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Category> categories = db.Categories.ToList();
            dataGridView1.DataSource = categories;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Category category = new Category { 
                CategoryName = txtCategoryName.Text,
                Description = txtDescription.Text                
            };

            db.Categories.Add(category);
            db.SaveChanges();

            button1_Click(button1, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int categoryId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            Category category = db.Categories.FirstOrDefault(c => c.CategoryId == categoryId);

            if (category != null)
            {
                category.CategoryName = txtCategoryName.Text;
                category.Description = txtDescription.Text;
                category.UpdatedDate = DateTime.Now;

                db.SaveChanges();
                button1_Click(button1, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int categoryId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            Category category = db.Categories.FirstOrDefault(c => c.CategoryId == categoryId);

            db.Categories.Remove(category);
            db.SaveChanges();
            button1_Click(button1, null);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtCategoryName.Text = "";
            txtDescription.Text = "";

            if (dataGridView1.SelectedRows.Count == 0)
                return;

            txtCategoryName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtDescription.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
