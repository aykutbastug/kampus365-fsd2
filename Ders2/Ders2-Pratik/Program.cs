namespace Ders2_Pratik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //try
            //{
            //    Console.WriteLine("Bir sayı girin : ");
            //    int sayi = int.Parse(Console.ReadLine());
            //    if (sayi % 2 == 0)
            //    {
            //        Console.WriteLine("Girdiğiniz sayı çifttir.");
            //    }
            //    else
            //        Console.WriteLine("Girilen sayı tektir");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("İşlem sırasında hata alındı. Mesaj : " + ex.Message);
            //    Console.WriteLine("Hata Detayı : " + ex.StackTrace);
            //}



            //1 => Oda karanlık mı ? E/H
            //2 => Kullanıcı "E" veya "H" harfine bassın. başka bir tuşa basarsa uygulama kapanmasın.
            //3 => E tuşuna basıldı ise "Işığı Aç" ekrana yazsın, "H" tuşuna basıldı ise "Işığı Kapat" yazsın.



            //string cevap;
            //do
            //{
            //    Console.WriteLine("Oda karanlık mı ? E/H");
            //    cevap = Console.ReadLine();

            //} while (cevap != "E" && cevap != "H");



            //if (cevap == "E")
            //    Console.WriteLine("Işığı Aç");
            //else if (cevap == "H")
            //    Console.WriteLine("Işığı Kapat");



            //1 => Kullanıcı adı istensin
            //2 => kullanıcı adı "bilgisayar" değilse uygulama kapanmadan tekrar kullanıcı adı sorsun.
            //3 => kullanıcı adı doğru ise şifre istesin
            //4 => şifre doğruysa (1234) giriş başarılı yazsın.
            //5 => şifre hatalı ise şifre hatalı yazsın uygulama kapansın.



            string kullaniciAdi;
            string sifre;

            do
            {

                Console.WriteLine("Kullanıcı adınızı giriniz..");
                kullaniciAdi = Console.ReadLine();

            } while (kullaniciAdi != "bilgisayar");


            Console.WriteLine(kullaniciAdi + "; Şifrenizi girin..");
            sifre = Console.ReadLine();

            if (sifre == "1234")
                Console.WriteLine("Üye giriş başarılı bir şekilde yapıldı.");
            else
                Console.WriteLine("Şifreniz hatalı..");
        }
    }
}