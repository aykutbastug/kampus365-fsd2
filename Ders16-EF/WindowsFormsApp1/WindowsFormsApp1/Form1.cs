using MFramework.Services.FakeData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> Sayilar = new List<int>();
        List<string> Isimler = new List<string>();
        List<Employee> Employees = new List<Employee>();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadNumberData_Click(object sender, EventArgs e)
        {
            Sayilar = new List<int>();
            for (int i = 1; i < 51; i++)
            {
                Sayilar.Add(i);
            }

            listBox1.DataSource = Sayilar;
        }

        private void btnLoadStringData_Click(object sender, EventArgs e)
        {
            Isimler = new List<string>();
            for (int i = 0; i < 50; i++)
            {
                Isimler.Add(NameData.GetFullName());
            }

            listBox1.DataSource = Isimler;
        }

        private void btnLoadClassData_Click(object sender, EventArgs e)
        {
            Employees = new List<Employee>();

            for (int i = 0; i < 20; i++)
            {
                Employee emp = new Employee
                {
                    Id = i,
                    Name = NameData.GetFirstName(),
                    Surname = NameData.GetSurname(),
                    Title = NameData.GetTitleName(),
                    Company = NameData.GetCompanyName(),
                    Age = NumberData.GetNumber(20, 55),
                    Salary = NumberData.GetNumber(5000, 25000),
                    BirthDate = DateTimeData.GetDatetime()
                };

                Employees.Add(emp);

                //Employees.Add(new Employee {
                //    Id = i,
                //    Name = NameData.GetFirstName(),
                //    Surname = NameData.GetSurname(),
                //    Title = NameData.GetTitleName(),
                //    Company = NameData.GetCompanyName(),
                //    Age = NumberData.GetNumber(20, 55),
                //    Salary = NumberData.GetNumber(5000, 25000),
                //    BirthDate = DateTimeData.GetDatetime()
                //});
            }

            listBox1.DataSource = Employees;
            listBox1.ValueMember = "Id";
            listBox1.DisplayMember = "Name";

            dataGridView1.DataSource = Employees;
        }


        //X ile başlayan kayıtlar
        private void button1_Click(object sender, EventArgs e)
        {
            //var sonuc = from sayi in Sayilar
            //                  where sayi > 5
            //                  orderby Sayilar descending
            //                  select sayi;


            //List<string> sonuc = Isimler.Where(i => i.StartsWith("A")).ToList();
            List<string> sonuc = Isimler.Where(i => i.EndsWith("d")).ToList();
            listBox2.DataSource = sonuc;
        }

        //karakter sayısı 13 den büyük olanlar
        private void button2_Click(object sender, EventArgs e)
        {
            List<string> sonuc = Isimler.Where(i => i.Length > 13).ToList();
            listBox2.DataSource = sonuc;
        }


        //A-Z ye kayıtları sırala
        private void button3_Click(object sender, EventArgs e)
        {
            List<string> sonuc = Isimler.Where(i => i.Length > 10).OrderBy(x => x).ToList();
            listBox2.DataSource = sonuc;
        }


        //Z-A ya kayıtları sırala
        private void button4_Click(object sender, EventArgs e)
        {
            List<string> sonuc = Isimler.Where(i => i.Length > 10).OrderByDescending(metin => metin).ToList();
            listBox2.DataSource = sonuc;
        }


        //x den büyük olan kayıtları getir
        private void button8_Click(object sender, EventArgs e)
        {
            List<int> sonuc = Sayilar.Where(x => x > 5).ToList();
            listBox2.DataSource = sonuc;
        }

        //toplam/max/min/ortalama
        private void button7_Click(object sender, EventArgs e)
        {
            int sayilarinToplami = Sayilar.Sum(x => x);
            MessageBox.Show("Sayıların Toplamı = " + sayilarinToplami);

            int enBuyukSayi = Sayilar.Max(x => x);
            MessageBox.Show("En Büyük Sayı = " + enBuyukSayi);

            int enKucukSayi = Sayilar.Min(x => x);
            MessageBox.Show("En Küçük Sayı = " + enKucukSayi);

            double ortalama = Sayilar.Average(x => x);
            MessageBox.Show("Sayıların Ortalaması = " + ortalama);
        }

        //çift sayıların toplamı
        private void button6_Click(object sender, EventArgs e)
        {
            List<int> sonuc = Sayilar.Where(x => x % 2 == 0).ToList();
            listBox2.DataSource = sonuc;

            //int ciftSayilarinToplami = sonuc.Sum(x => x);
            int ciftSayilarinToplami = sonuc.Where(x => x % 2 == 0).Sum(x => x);
            MessageBox.Show("Çift Sayıların Toplamı = " + ciftSayilarinToplami);
        }


        private void ListBox2Doldur(List<Employee> sonuc)
        {
            listBox2.DataSource = sonuc;
            listBox2.DisplayMember = "Name";
            listBox2.ValueMember = "Id";
        }


        //Adı a ile başlayan personeller
        private void button11_Click(object sender, EventArgs e)
        {
            List<Employee> sonuc = Employees.Where(emp => emp.Name.StartsWith("A")).ToList();
            ListBox2Doldur(sonuc);
        }
        

        //soyadının karakter sayısı 7 den büyük olanlar
        private void button10_Click(object sender, EventArgs e)
        {
            List<Employee> sonuc = Employees.Where(emp => emp.Surname.Length > 7).ToList();
            ListBox2Doldur(sonuc);
        }


        //kayıtları sıralı a-z
        private void button9_Click(object sender, EventArgs e)
        {
            ListBox2Doldur(Employees.OrderBy(emp => emp.Name).ToList());
        }

        //kayıtları sıralı z-a
        private void button5_Click(object sender, EventArgs e)
        {
            ListBox2Doldur(Employees.OrderByDescending(emp => emp.Name).ToList());
        }

        //en büyük yaş
        private void button12_Click(object sender, EventArgs e)
        {
            int enBuyukyas = Employees.Max(emp => emp.Age);

            MessageBox.Show("En Büyük Yaş = " + enBuyukyas);
        }

        //en düşük maaaş
        private void button13_Click(object sender, EventArgs e)
        {
            int enDusukMaas = ((int)Employees.Min(emp => emp.Salary));
            MessageBox.Show("En Düşük Maaş = " + enDusukMaas);
        }

        //personel maaş toplamı
        private void button14_Click(object sender, EventArgs e)
        {
            decimal maasToplami = Employees.Sum(emp => emp.Salary);
            MessageBox.Show("Maaş Toplamı = " + maasToplami);
        }


        //personel yaş ortalaması
        private void button15_Click(object sender, EventArgs e)
        {
            double yasOrtalamasi = Employees.Average(emp => emp.Age);
            MessageBox.Show("Yaş Ortalaması = " + yasOrtalamasi);
            MessageBox.Show("Yaş Ortalaması = " + yasOrtalamasi.ToString("n4"));
        }

        //kaç farklı şirket sayısı var
        private void button16_Click(object sender, EventArgs e)
        {
            int sirketSayisi = Employees.Select(x => x.Company).Distinct().Count();
            MessageBox.Show("Şirket Sayısı = " + sirketSayisi);
        }
    }
}
