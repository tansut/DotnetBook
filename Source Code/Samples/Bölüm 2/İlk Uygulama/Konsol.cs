using System;

namespace DotNetKitabý.ÖrnekUygulamalar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Herhangi bir deðer giriniz:");
            string okunanMetin = Console.ReadLine();
            Console.WriteLine(
                string.Format("Tarih-Saat:{0}, Girilen Deðer:{1}",
                    DateTime.Now.ToString(), 
                    okunanMetin));
        }
    }
}