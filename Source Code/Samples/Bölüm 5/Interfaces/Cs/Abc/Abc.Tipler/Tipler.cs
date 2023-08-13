using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Tipler
{
    public struct Kitap
    {
        public string Isbn;
        public string Ad;
        public string Yazar;
        public string Konu;
        public float Fiyat;
    }

    public interface IKitapDeposu
    {
        string DepoAd
        {
            get;
        }

        Kitap[] AramaYap(string konu);

        void SiparisGonder(string isbn);
    }

}
