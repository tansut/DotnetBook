using System;

namespace DotNetKitab�.�rnekUygulamalar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Herhangi bir de�er giriniz:");
            string okunanMetin = Console.ReadLine();
            Console.WriteLine(
                string.Format("Tarih-Saat:{0}, Girilen De�er:{1}",
                    DateTime.Now.ToString(), 
                    okunanMetin));
        }
    }
}