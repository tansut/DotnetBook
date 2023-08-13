namespace DotNetKitabý.Abstracts
{
    using System.Globalization;
    using System.Threading;
    using System.Text;
    using System.Collections.Generic;
    using System;
    using System.IO;
    using System.Collections;

    abstract class TemelKullanýcý
    {
        private string ad;

        protected TemelKullanýcý(string ad)
        {
            this.ad = ad;
            Console.WriteLine("TemelKullanýcý Oluþturuldu");
        }

        public string Ad
        {
            get
            {
                return ad;
            }

            protected set
            {
                ad = value;
            }
        }
    }

    abstract class YetkiliKullanýcý :
      TemelKullanýcý
    {

        protected YetkiliKullanýcý(string ad)
            : base(ad)
        {
            Console.WriteLine("YetkiliKullanýcý oluþturuldu");
        }

        public abstract int YetkiDuzeyi
        {
            get;
        }

        public abstract bool YetkiSahibiMi(string iþlem);
    }

    class YöneticiKullanýcý :
      YetkiliKullanýcý
    {
        private static ArrayList yetkiListesi;


        public YöneticiKullanýcý(string ad)
            : base(ad)
        {
            Console.WriteLine("YöneticiKullanýcý oluþturuldu");
        }

        static YöneticiKullanýcý()
        {
            yetkiListesi = new ArrayList();
            yetkiListesi.Add("Seçmen Ekleme");
            yetkiListesi.Add("Seçmen Silme");
        }

        public override int YetkiDuzeyi
        {
            get
            {
                return 5;
            }
        }

        public override bool YetkiSahibiMi(string iþlem)
        {
            return yetkiListesi.IndexOf(iþlem) >= 0;
        }
    }


    static class Program
    {
        public static void Main(string[] args)
        {

        }

    }
}