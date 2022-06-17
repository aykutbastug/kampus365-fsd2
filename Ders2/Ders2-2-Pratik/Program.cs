namespace Ders2_2_Pratik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BOM oyunu
            //int bomSayisi;

            //do
            //{
            //    Console.WriteLine("BOM sayısını giriniz : ");
            //    bomSayisi = 6;
            //    //bool sayiMi = false;
            //    bool sayiMi = int.TryParse(Console.ReadLine(), out bomSayisi);


            //    //try
            //    //{
            //    //    bomSayisi = int.Parse(Console.ReadLine());
            //    //    sayiMi = true;
            //    //}
            //    //catch (Exception ex)
            //    //{
            //    //    sayiMi=false;
            //    //}



            //    if (!sayiMi)
            //        Console.WriteLine("Sayısal bir değer girmediniz..");

            //} while (bomSayisi < 2 && bomSayisi > 25);


            //Console.WriteLine();
            //int i = 1;
            //for (i = 1; i < 100; i++)
            //{               

            //    if (i % 2 == 1)
            //    {
            //        if (i % bomSayisi == 0)
            //        {
            //            Console.WriteLine("Bilgisayar : BOM");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Bilgisayar : " + i);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sıra sende : ");
            //        string kullanici = Console.ReadLine();

            //        if (i % bomSayisi == 0)
            //        {
            //            if (kullanici != "bom")
            //            {
            //                Console.WriteLine("kaybettiniz..");
            //                break;
            //            }
            //        }
            //        else
            //        {
            //            if (int.Parse(kullanici) != i)
            //            {
            //                Console.WriteLine("kaybettiniz..");
            //                break;
            //            }
            //        }
            //    }
            //}

            //if (i > 100)
            //    Console.WriteLine("oyun berabere..");

            //Console.WriteLine("Oyun Bitti!"); 
            #endregion

            #region girilen 3 sınav notunun ortalamasını ekrana yazan ve karşılık gelen harf notunu gösteren uygulama
            //1 => 3 tane sınav notu girilecek. (NOT: sınav notları double olabilir. ondalıklı sayı)
            //2 => notların ortalaması alınacak.
            //3 => ortalama 60 ve üzeriyse geçtiniz yazacak.
            //4 => ortalama 60 altındaysa kaldınız yazacak.


            //0-44 > FF
            //45-59 > DD
            //60-79 > BB
            //80- > AA


            //double sinavNotu1, sinavNotu2, sinavNotu3, notOrtalamasi;

            //Console.WriteLine("1. Sınav Notunu Girin : ");
            //sinavNotu1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("2. Sınav Notunu Girin : ");
            //sinavNotu2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("3. Sınav Notunu Girin : ");
            //sinavNotu3 = Convert.ToDouble(Console.ReadLine());

            //notOrtalamasi = (sinavNotu1 + sinavNotu2 + sinavNotu3) / 3;


            //if (notOrtalamasi >= 0 && notOrtalamasi <= 44)
            //    Console.WriteLine("Notunuz : FF");
            //else if (notOrtalamasi >= 45 && notOrtalamasi <= 59)
            //    Console.WriteLine("Notunuz : DD");
            //else if (notOrtalamasi >= 60 && notOrtalamasi <= 79)
            //    Console.WriteLine("Notunuz : BB");
            //else
            //    Console.WriteLine("Notunuz : AA");

            //if (notOrtalamasi >= 60)
            //{
            //    Console.WriteLine("Geçtiniz. Not ortalamanız = " + notOrtalamasi);
            //}
            //else
            //    Console.WriteLine("Kaldınız. Not ortalamanız = " + notOrtalamasi); 
            #endregion

            #region SWITCH kullanaran trafik ışığı örneği
            //0 = > SWITCH kullanıcılacak
            //1 => kullanıcıdan trafik ışığının rengini isteyecek (kırmızı, sarı, yeşil)
            //2 => kırmızı yazdıysak "Bekleyin" yazacak
            //3 => sarı yazdıysak "Hazır Ol" yazacak
            //4 => yeşil yazdıysak "Geçebilirsiniz" yazacak.
            //5 => farklı bir değer yazarsak "hatalı bir renk girdiniz" şeklinde uyarı verecek


            //Console.WriteLine("Trafik lamba rengini giriniz. (kırmızı, sarı, yeşil)");
            //string lambaRengi = Console.ReadLine();

            //switch (lambaRengi)
            //{
            //    case "kirmizi":
            //        Console.WriteLine("Lütfen Bekleyin");
            //        break;
            //    case "sari":
            //        Console.WriteLine("Hazır olun");
            //        break;
            //    case "yesil":
            //        Console.WriteLine("Geçebilirsiniz");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı bir renk girdiniz");
            //        break;
            //}


            //if (lambaRengi == "kirmizi")
            //    Console.WriteLine("Lütfen Bekleyin");
            //else if (lambaRengi == "sari")
            //    Console.WriteLine("Hazır olun");
            //else if (lambaRengi == "yesil")
            //    Console.WriteLine("Geçebilirsiniz");
            //else
            //    Console.WriteLine("Hatalı bir renk girdiniz"); 
            #endregion

            #region switch örneği
            //switch (DateTime.Now.DayOfWeek)
            //{
            //    case DayOfWeek.Sunday:
            //    case DayOfWeek.Saturday:
            //        Console.WriteLine("Haftasonu");
            //        break;
            //    case DayOfWeek.Monday:
            //    case DayOfWeek.Tuesday:
            //    case DayOfWeek.Wednesday:
            //    case DayOfWeek.Thursday:
            //    case DayOfWeek.Friday:
            //        Console.WriteLine("haftaiçi");
            //        break;
            //    default:
            //        break;
            //} 
            #endregion

            #region a'dan z'ye kadar olan tüm harfleri yan yana yazdıma
            //for (char i = 'a'; i <= 'z'; i++)
            //{
            //    Console.Write(i);
            //}

            //Console.WriteLine();
            //Console.WriteLine(); 
            #endregion


            //girilen bir sayıya kadar olan bütün sayıların toplamanın, 3 ve 3'ün katları olan sayılatın toplamına bölümü ekrana yazdıran uygulamacık.

            Console.WriteLine("Bir sayı giriniz : ");
            double sayi = int.Parse(Console.ReadLine());

            double sayilarinToplami = 0;
            double katlarinToplami = 0;

            for (int i = 1; i <= sayi; i++)
            {
                sayilarinToplami += i;

                if (i % 3 == 0)
                    katlarinToplami += i;
            }

            double sonuc = sayilarinToplami / katlarinToplami;

            Console.WriteLine("Sonuç : " + sonuc);
        }
    }
}