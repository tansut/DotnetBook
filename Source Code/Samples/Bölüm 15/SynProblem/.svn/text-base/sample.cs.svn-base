using System;
using System.Threading;


namespace DotNetKitabý
{
    class Program
    {

        class Test
        {
            public static int Toplam = 0;
        }

        static void KontrolEt()
        {
            Test.Toplam = 12;

            Thread.Sleep(10);

            int sonuc = Test.Toplam;

            if (sonuc == 12)
            {
                Console.WriteLine("{0} iþ parçacýðý doðru deðeri elde etti.",
                    Thread.CurrentThread.ManagedThreadId);
            }
            else
            {
                Console.WriteLine("{0} numaralý iþ parçacýðý hatalý deðer elde etti.",
                    Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("{0} numaralý iþ parçasý deðeri {1} olarak okudu",
                    Thread.CurrentThread.ManagedThreadId, sonuc);
            }
        }

        static void Degistir()
        {
            Console.WriteLine("Toplam deðeri {0} iþ parçasý tarafýndan deðiþtirildi.", Thread.CurrentThread.ManagedThreadId);
            Test.Toplam = 13;
        }

        static void Main(string[] args)
        {
            KontrolEt();

            ThreadStart ts = new ThreadStart(Degistir);

            Thread t = new Thread(ts);
            t.Start();

            KontrolEt();

            Console.ReadLine();


        }
    }
}
