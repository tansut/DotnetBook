using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;


namespace DotNetKitabý
{
    class Test
    {
        private object sync = new object();
        private bool sinyalGeldiMi;

        public void IslemYap()
        {
            lock (sync)
            {
                Console.WriteLine("Sinyal bekleniyor ... {0}", sinyalGeldiMi);
                Monitor.Wait(sync);
                Console.WriteLine("Sinyal geldi ... {0}", sinyalGeldiMi);
            }
        }

        public void SinyalIlet()
        {
            lock (sync)
            {
                sinyalGeldiMi = true;
                Console.WriteLine("Sinyal iletiliyor ...");
                Monitor.Pulse(sync);
            }
        }
    }

    class Program
    {

        public static void Main()
        {
            Test testObj = new Test();
            new Thread(t.IslemYap).Start();

            Thread.Sleep(1000);

            t.SinyalIlet();

            Console.ReadLine();
        }






    }




}

