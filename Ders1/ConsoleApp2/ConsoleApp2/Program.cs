namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int sayi1 = 0;
            //int sayi2 = 0;

            //Console.WriteLine("1. Sayıyı Giriniz : ");
            //sayi1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2. Sayıyı Giriniz : ");
            //sayi2 = int.Parse(Console.ReadLine());

            //int toplam = sayi1 + sayi2;

            //Console.WriteLine("Girilen Sayıların Toplamı : " + toplam);



            int kenar = 0;
            Console.WriteLine("Kenar uzunluğunu giriniz : ");
            kenar = int.Parse(Console.ReadLine());
            kenar = Convert.ToInt32(Console.ReadLine());
            

            int alan = kenar * kenar;            
            int cevre = kenar * 4;


            Console.WriteLine("Karenin Alanı : " + alan + ".");
            Console.WriteLine("Karenin Çevresi : " + cevre.ToString() + ".");


        }
    }
}