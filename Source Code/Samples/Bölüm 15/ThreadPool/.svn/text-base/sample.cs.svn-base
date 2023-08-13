using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;


namespace DotNetKitabý
{
    class Program
    {
        private static object sync = new object();
        private static int calisanIsParcacikSayisi = 100;

        static void IslemYap(object veri)
        {
            Console.WriteLine("Veri: {0}, Ýþ Parçacýðý: {1}", veri, Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1000);
            lock (sync)
            {
                calisanIsParcacikSayisi--;
                Monitor.Pulse(sync);
            }
        }


        public static void Main()
        {
            WaitCallback callBack = new WaitCallback(IslemYap);
            for (int i = 0; i < calisanIsParcacikSayisi; i++)
                ThreadPool.QueueUserWorkItem(callBack, i);
            Console.WriteLine("Ýþlerin tamamlanmasý bekleniyor ...");

            lock (sync)
            {
                while (calisanIsParcacikSayisi > 0)
                    Monitor.Wait(sync);
            }

            Console.WriteLine("Ýþler tamamlandý ...");
        }

    }




}

