using System;
using System.Collections.Generic;
using System.Text;
using Abc.Tipler;

namespace ADeposu
{
    public class KitapEntegrasyon : IKitapDeposu
    {
        #region IKitapDeposu Members

        public string DepoAd
        {
            get
            {
                return "A Deposu, AAA Ltd. Şti";
            }
        }

        public Kitap[] AramaYap(string konu)
        {
            Kitap k = new Kitap();
            k.Ad = "Örnek A Depo Kitabı";
            k.Fiyat = 67;
            k.Isbn = "9012341234111";
            k.Konu = "Örnek A Depo Kitap Konusu";
            k.Yazar = "A Depo Kitabı Yazarı";
            return new Kitap[] { k };
        }

        public void SiparisGonder(string isbn)
        {
            
        }

        #endregion
    }
}
