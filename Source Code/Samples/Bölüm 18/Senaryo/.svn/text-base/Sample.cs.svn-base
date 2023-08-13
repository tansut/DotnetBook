using System;
using System.Threading;
using System.Text;
using System.Diagnostics;


namespace DotNetKitabý
{
    enum TestTipi
    {
        StringTest,
        StringBuilderTest
    }

    class PerformansTest
    {
        private const string KategoriAd = "String Performans Testleri";
        private const string OrtalamaIslemSayisiAd = "Ýþlem Sayýsý/sn";
        private const string ToplamIslemSayisiAd = "Toplam Ýþlem Sayýsý";
        private const string OrtalamaIslemSuresiAd = "Ortalama Ýþlem Süresi";
        private const string OrtalamaIslemSuresiTemelAd = "Ortalama Ýþlem Süresi Temel Sayaç";

        private PerformanceCounter ortalamaIslemSayisiSayaci;
        private PerformanceCounter toplamIslemSayisiSayaci;
        private PerformanceCounter ortalamaIslemSuresiSayaci;
        private PerformanceCounter ortalamaIslemSuresiTemelSayaci;



        private TestTipi tip;


        private static void Olustur()
        {
            if (PerformanceCounterCategory.Exists(KategoriAd))
                PerformanceCounterCategory.Delete(KategoriAd);

            CounterCreationData pc1 = new CounterCreationData(OrtalamaIslemSayisiAd, "", PerformanceCounterType.RateOfCountsPerSecond32);
            CounterCreationData pc2 = new CounterCreationData(ToplamIslemSayisiAd, "", PerformanceCounterType.NumberOfItems32);

            CounterCreationData pc3 = new CounterCreationData(OrtalamaIslemSuresiAd, "", PerformanceCounterType.AverageTimer32);
            CounterCreationData pc4 = new CounterCreationData(OrtalamaIslemSuresiTemelAd, "", PerformanceCounterType.AverageBase);

            CounterCreationDataCollection coll = new CounterCreationDataCollection();

            coll.Add(pc1);
            coll.Add(pc2);
            coll.Add(pc3);
            coll.Add(pc4);

            PerformanceCounterCategory.Create(KategoriAd, "", PerformanceCounterCategoryType.MultiInstance, coll);
        }

        static PerformansTest()
        {
            if (!PerformanceCounterCategory.Exists(KategoriAd))
                Olustur();
        }

        public PerformansTest(TestTipi tip)
        {
            this.tip = tip;
        }

        private void SayacNesneleriOlustur()
        {

            ortalamaIslemSayisiSayaci = new PerformanceCounter(KategoriAd, OrtalamaIslemSayisiAd, Thread.CurrentThread.Name, false);
            toplamIslemSayisiSayaci = new PerformanceCounter(KategoriAd, ToplamIslemSayisiAd, Thread.CurrentThread.Name, false);
            ortalamaIslemSuresiSayaci = new PerformanceCounter(KategoriAd, OrtalamaIslemSuresiAd, Thread.CurrentThread.Name, false);
            ortalamaIslemSuresiTemelSayaci = new PerformanceCounter(KategoriAd, OrtalamaIslemSuresiTemelAd, Thread.CurrentThread.Name, false);

        }

        private void OrnekleriYokEt()
        {
            ortalamaIslemSayisiSayaci.RemoveInstance();
            toplamIslemSayisiSayaci.RemoveInstance();
            ortalamaIslemSuresiSayaci.RemoveInstance();
            ortalamaIslemSuresiTemelSayaci.RemoveInstance();
        }

        private void Artir(long tik)
        {
            toplamIslemSayisiSayaci.Increment();
            ortalamaIslemSayisiSayaci.Increment();
            ortalamaIslemSuresiSayaci.IncrementBy(tik);
            ortalamaIslemSuresiTemelSayaci.Increment();
        }


        public void Basla()
        {
            SayacNesneleriOlustur();

            StringBuilder sb = new StringBuilder();

            string sonuc = string.Empty;

            long tikSayisi;

            for (int i = 0; i < 300000; i++)
            {
                tikSayisi = DateTime.Now.Ticks;
                for (int j = 0; j < 1000; j++)
                {
                    if (tip == TestTipi.StringBuilderTest)
                    {
                        sb.Append("01234");
                    }
                    else
                        sonuc = sonuc + "01234";
                }

                Artir(DateTime.Now.Ticks - tikSayisi);
                sb.Remove(0, sb.Length);
                sonuc = string.Empty;
            }

            OrnekleriYokEt();

            Console.Write("{0} testi tamamlandý ...", Thread.CurrentThread.Name);
        }



    }

    class Program
    {

        public static void Main()
        {
            PerformansTest stringTest = new PerformansTest(TestTipi.StringTest);
            PerformansTest sbTest = new PerformansTest(TestTipi.StringBuilderTest);

            Thread stringThread = new Thread(stringTest.Basla);
            Thread sbThread = new Thread(sbTest.Basla);

            stringThread.Name = "String";
            sbThread.Name = "StringBuilder";

            stringThread.Start();
            sbThread.Start();

            Console.WriteLine("Ýþlemin tamamlanmasý bekleniyor ...");

            stringThread.Join();
            sbThread.Join();

            Console.ReadLine();

        }





    }


}

