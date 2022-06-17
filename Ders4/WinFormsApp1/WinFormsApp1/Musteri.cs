using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Musteri
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        public string Email { get; set; }

        public string Cinsiyet { get; set; }

        public DateTime DogumTarihi { get; set; }

        public Musteri(string adi, string soyadi, string email, string cinsiyet, DateTime dogumTarihi)
        {
            Adi = adi;
            Soyadi = soyadi;
            Email = email;
            Cinsiyet = cinsiyet;
            DogumTarihi = dogumTarihi;
        }
    }
}
