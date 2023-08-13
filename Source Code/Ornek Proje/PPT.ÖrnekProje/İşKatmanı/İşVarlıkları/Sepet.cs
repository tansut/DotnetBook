using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace İşKatmanı.İşVarlıkları
{
    public class Sepet : IComparable<Sepet>
    {
        private int ürünId;

        public int ÜrünId
        {
            get
            {
                return ürünId;
            }
            set
            {
                ürünId = value;
            }
        }

        private string ürünAd;

        public string ÜrünAd
        {
            get
            {
                return ürünAd;
            }
            set
            {
                ürünAd = value;
            }
        }


        private int adet;

        public int Adet
        {
            get
            {
                return adet;
            }
            set
            {
                adet = value;
            }
        }

        private decimal ücret;

        public decimal Ücret
        {
            get
            {
                return ücret;
            }
            set
            {
                ücret = value;
            }
        }


        internal Sepet(int ürünId, string ürünAd, int adet, decimal ücret)
        {
            this.ürünId = ürünId;
            this.ürünAd = ürünAd;
            this.adet = adet;
            this.ücret = ücret;
        }


        #region IComparable<Sepet> Members

        public int CompareTo(Sepet other)
        {
            return this.ürünId == other.ürünId ? 0 : 1;
        }

        #endregion

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Sepet))
                return false;
            return this.ürünId == ((Sepet)obj).ürünId;
        }

        public decimal ToplamUcret
        {
            get
            {
                return ücret * adet;
            }
        }
    }

    public class SepetListesi : KeyedCollection<int, Sepet>
    {
        protected override int GetKeyForItem(Sepet item)
        {
            return item.ÜrünId;
        }


        internal SepetListesi()
            : base()
        {
        }

        public decimal ToplamUcret
        {
            get
            {
                decimal toplam = 0;
                foreach (Sepet s in this)
                    toplam += s.ToplamUcret;
                return toplam;
            }
        }
    }
}
