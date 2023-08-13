using System;
using System.Threading;
using System.Collections;


namespace DotNetKitabý
{
    class Program
    {

        class Test
        {
            
            public static int Toplam = 0;
            public const int Max = 10000;
            public static int Sayi = Max;
        }
        


        public static bool AsalSayimi(int sayi)
        {
            for (int i = 2; i < sayi / 2 + 1; i++)
            {
                if (sayi % i == 0)
                    return false;
            }
            return true;
        }


        static void AsalBul()
        {
            int sayi = Interlocked.Decrement(ref Test.Sayi);

            while (sayi > 2)
            {

                if (AsalSayimi(sayi))
                {
                    Interlocked.Increment(ref Test.Toplam);
                    Console.WriteLine("{0}, iþ parçacýðý {1} tarafýnfan bulundu.", sayi, Thread.CurrentThread.ManagedThreadId);
                }

                sayi = Interlocked.Decrement(ref Test.Sayi);                
            }

        }

        static void Main(string[] args)
        {
            Thread[] list = new Thread[10];

            ThreadStart ts = new ThreadStart(AsalBul);

            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(ts);
                list[i] = t;
                t.Start();
            }

            foreach (Thread t in list)
                t.Join();

            Console.WriteLine("{0} deðerinden küçük toplam {1} asal sayý bulunmaktadýr.",
                Test.Max, Test.Toplam);
            

            Console.ReadLine();


        }
    }
}
