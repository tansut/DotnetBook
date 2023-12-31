namespace DotNetKitabı.Abstracts
{
    using System.Globalization;
    using System.Threading;
    using System.Text;
    using System.Collections.Generic;
    using System;
    using System.IO;
    using System.Collections;

    abstract class TemelKullanıcı
    {
        private string ad;

        protected TemelKullanıcı(string ad)
        {
            this.ad = ad;
            Console.WriteLine("TemelKullanıcı Oluşturuldu");
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

    abstract class YetkiliKullanıcı :
      TemelKullanıcı
    {

        protected YetkiliKullanıcı(string ad)
            : base(ad)
        {
            Console.WriteLine("YetkiliKullanıcı oluşturuldu");
        }

        public abstract int YetkiDuzeyi
        {
            get;
        }

        public abstract bool YetkiSahibiMi(string işlem);
    }

    class YöneticiKullanıcı :
      YetkiliKullanıcı
    {
        private static ArrayList yetkiListesi;


        public YöneticiKullanıcı(string ad)
            : base(ad)
        {
            Console.WriteLine("YöneticiKullanıcı oluşturuldu");
        }

        static YöneticiKullanıcı()
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

        public override bool YetkiSahibiMi(string işlem)
        {
            return yetkiListesi.IndexOf(işlem) >= 0;
        }
    }


    static class Program
    {
        public static void Main(string[] args)
        {

        }

    }
}