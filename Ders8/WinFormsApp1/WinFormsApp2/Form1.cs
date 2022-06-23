using Ganss.Excel;
using System.Text.Json;
using System.Xml.Serialization;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReadExcel_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            ExcelMapper excelMapper = new ExcelMapper("kisiler.xlsx");
            excelMapper.HeaderRow = true;

            var kisiler = excelMapper.Fetch<Kisi>();

            foreach (var kisi in kisiler)
            {

                ListViewItem li = new ListViewItem(new string[] { kisi.Telefon, kisi.AdiSoyadi, kisi.Meslek, "", "" });
                listView1.Items.Add(li);
            }
        }

        private void btnReadXml_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Kisi>));
            FileStream fs = new FileStream("kisiler.xml", FileMode.Open);
            var kisiler = serializer.Deserialize(fs);
            fs.Close();

            listView1.Items.Clear();
            foreach (var kisi in (List<Kisi>)kisiler)
            {

                ListViewItem li = new ListViewItem(new string[] { kisi.Telefon, kisi.AdiSoyadi, kisi.Meslek, "", "" });
                listView1.Items.Add(li);
            }
        }

        private void btnReadJson_Click(object sender, EventArgs e)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.IncludeFields = true;
            options.PropertyNameCaseInsensitive = true;
            options.WriteIndented = true;

            string json = File.ReadAllText("kisiler.json");

            var kisiler = JsonSerializer.Deserialize<List<Kisi>>(json, options);

            listView1.Items.Clear();
            foreach (var kisi in kisiler)
            {

                ListViewItem li = new ListViewItem(new string[] { kisi.Telefon, kisi.AdiSoyadi, kisi.Meslek, "", "" });
                listView1.Items.Add(li);
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Liste boş...");
                return;
            }


            for (int i = 0; i < listView1.Items.Count; i++)
            {
                string telefon = listView1.Items[i].Text;
                string adiSoyadi = listView1.Items[i].SubItems[1].Text;
                string meslek = listView1.Items[i].SubItems[2].Text;

                if (adiSoyadi.Contains("Hasan"))
                {
                    try
                    {
                        Convert.ToDouble("aaa");
                    }
                    catch (Exception ex)
                    {
                        listView1.Items[i].SubItems[3].Text = "Hatalı";
                        listView1.Items[i].SubItems[4].Text = ex.Message;
                    }
                }
                else
                {
                    listView1.Items[i].SubItems[3].Text = "Başarılı";
                    listView1.Items[i].SubItems[4].Text = txtSmsMetni.Text.Replace("{AdiSoyadi}", adiSoyadi);
                }
            }

            MessageBox.Show("SMS Gönderim işlemi tamamlandı.\nİşlem sonuçlarını listede görebilrisiniz.");
        }

        private void btnWriteExcel_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Liste boş..");
                return;
            }            

            ExcelMapper excelMapper = new ExcelMapper();
            excelMapper.Save("IslemSonucu.xlsx", ResultOlustur(), "Sonuc");

            File.Open("IslemSonucu.xlsx", FileMode.Open);
        }

        private void btnWriteXml_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Liste boş..");
                return;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Sonuc>));
            FileStream fileStream = new FileStream("IslemSonucu.xml", FileMode.Create);
            serializer.Serialize(fileStream, ResultOlustur());
            fileStream.Close();

            File.Open("IslemSonucu.xml", FileMode.Open);
        }

        private void btnWriteJson_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Liste boş..");
                return;
            }

            JsonSerializerOptions options = new JsonSerializerOptions();
            options.IncludeFields = true;
            options.PropertyNameCaseInsensitive = true;
            options.WriteIndented = true;


            string json = JsonSerializer.Serialize<List<Sonuc>>(ResultOlustur(), options);
            File.WriteAllText("IslemSonucu.json", json);

            File.Open("IslemSonucu.json", FileMode.Open);
        }

        private List<Sonuc> ResultOlustur()
        {
            List<Sonuc> result = new List<Sonuc>();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                result.Add(new Sonuc
                {
                    Telefon = listView1.Items[i].Text,
                    AdiSoyadi = listView1.Items[i].SubItems[1].Text,
                    Meslek = listView1.Items[i].SubItems[2].Text,
                    IslemSonucu = listView1.Items[i].SubItems[3].Text,
                    Aciklama = listView1.Items[i].SubItems[4].Text
                });
            }

            return result;
        }
    }
}