using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using System.Text;

namespace Model
{
    public sealed class OperasyonListesi: KeyedCollection<string, Operasyon>
    {
        private static OperasyonListesi liste;

        public static OperasyonListesi Liste
        {
            get
            {
                return liste;
            }
        }

        static OperasyonListesi()
        {
            liste = new OperasyonListesi();
            liste.Add(new Operasyon("MüþteriEkle", "Müþteri Ekleme", "Ýþ", "Ýþ.MüþteriÝþSýnýfý", "Ekle"));
            liste.Add(new Operasyon("MüþteriAra", "Müþteri Arama", "Ýþ", "Ýþ.MüþteriÝþSýnýfý", "Ara"));
            liste.Add(new Operasyon("MüþteriSil", "Müþteri Silme", "Ýþ", "Ýþ.MüþteriÝþSýnýfý", "Sil"));
            liste.Add(new Operasyon("MüþteriListele", "Müþteri Arama", "Ýþ", "Ýþ.MüþteriÝþSýnýfý", "Listele"));

        }

        protected override string GetKeyForItem(Operasyon item)
        {
            return item.Kod;
        }

        private OperasyonListesi()
        {
        }


    }
}
