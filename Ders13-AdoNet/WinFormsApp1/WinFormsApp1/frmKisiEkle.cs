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
    public partial class frmKisiEkle : Form
    {
        public frmKisiEkle()
        {
            InitializeComponent();
        }

        string connectionString = "server=AYKUTBASTUG-ZEN;database=Ders13;Trusted_Connection=true;";
        //string connectionString = "server=AYKUTBASTUG-ZEN;database=Ders13;user Id=sa;Password=123456;";
        SqlConnection connection;

        private void KisiEkle_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from dbo.Sehirler order by Adi", connection);

            DataTable dataTable = new DataTable();
            connection.Open();
            sqlDataAdapter.Fill(dataTable);
            connection.Close();

            cmbSehir.DataSource = dataTable;
            cmbSehir.ValueMember = "Id";
            cmbSehir.DisplayMember = "Adi";

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {            
            if (txtAdiSoyadi.TextLength == 0)
            {
                MessageBox.Show("Adı soyadı girmediniz...");
                return;
            }

            if (txtTelefon.TextLength == 0)
            {
                MessageBox.Show("Telefon girmediniz...");
                return;
            }


            //SqlCommand command = new SqlCommand("TelefonKontrol", connection);
            //command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.AddWithValue("Telefon", txtTelefon.Text);
            //connection.Open();
            //int kayitSayisi = (int)command.ExecuteScalar();
            //connection.Close();

            //if (kayitSayisi > 0)
            //{
            //    MessageBox.Show("Telefon numarası zaten kayıtlı.");
            //    return;
            //}


            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from dbo.Kisiler where Telefon=@Telefon", connection);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("Telefon", txtTelefon.Text);

            DataTable dataTable = new DataTable();
            connection.Open();
            sqlDataAdapter.Fill(dataTable);
            connection.Close();

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show($"{txtTelefon.Text} telefon numarası {dataTable.Rows[0]["AdiSoyadi"].ToString()}  isimli kişiye kayıtlı..");
                return ;
            }


            string sqlQuery = "insert into [dbo].[Kisiler] ([AdiSoyadi], [Telefon], [Email], [SehirId]) values (@AdiSoyadi, @Telefon, @Email, @SehirId)";
            SqlCommand cmd = new SqlCommand(sqlQuery, connection);
            cmd.Parameters.AddWithValue("AdiSoyadi", txtAdiSoyadi.Text);
            cmd.Parameters.AddWithValue("Telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("SehirId", cmbSehir.SelectedValue);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSehir.SelectedIndex < 0)
                return;

            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from dbo.Ilceler where SehirId=@SehirId", connection);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("SehirId", cmbSehir.SelectedValue);

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                cmbIlce.DataSource = dataTable;
            }
            catch {; }
        }
    }
}
