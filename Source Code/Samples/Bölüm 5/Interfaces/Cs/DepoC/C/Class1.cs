using System;
using System.Collections.Generic;
using System.Text;
using Abc.Tipler;

namespace Entegrasyonlar.Abc
{
    public class KitapSorgu : IKitapDeposu
    {
        #region IKitapDeposu Members

        public string DepoAd
        {
            get
            {
                return "C Deposu, CCC Ltd. Şti";
            }
        }

        public Kitap[] AramaYap(string konu)
        {
            Kitap k = new Kitap();
            k.Ad = "Örnek C Depo Kitabı";
            k.Fiyat = 67;
            k.Isbn = "9612341234111";
            k.Konu = "Örnek C Depo Kitap Konusu";
            k.Yazar = "C Depo Kitabı Yazarı";
            return new Kitap[] { k };
        }

        public void SiparisGonder(string isbn)
        {

        }

        #endregion
    }

}
