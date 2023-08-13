using System;
using System.Collections.Generic;
using System.Text;
using Abc.Tipler;

namespace Xyz
{
    public class Sorgu : IKitapDeposu
    {
        #region IKitapDeposu Members

        public string DepoAd
        {
            get
            {
                return "B Deposu, BBB Ltd. Şti";
            }
        }

        public Kitap[] AramaYap(string konu)
        {
            Kitap k = new Kitap();
            k.Ad = "Örnek B Depo Kitabı";
            k.Fiyat = 67;
            k.Isbn = "0012371234111";
            k.Konu = "Örnek B Depo Kitap Konusu";
            k.Yazar = "B Depo Kitabı Yazarı";
            return new Kitap[] { k };
        }

        public void SiparisGonder(string isbn)
        {

        }

        #endregion
    }

}
