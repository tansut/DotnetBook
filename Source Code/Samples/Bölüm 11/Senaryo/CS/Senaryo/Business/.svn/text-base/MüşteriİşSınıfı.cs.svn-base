using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace İş
{
    public class MüşteriİşSınıfı
    {
        private static MüşteriListesi liste = new MüşteriListesi();

        [Yetki("Müşteri Ekleme")]
        public void Ekle(Müşteri müşteri)
        {
            try
            {
                liste.Add(müşteri);
            }
            catch (ArgumentException)
            {
                throw new ApplicationException("Aynı T.C. No ile müşteri bulunmaktadır");
            }
        }

        [Yetki("Müşteri Arama")]
        public MüşteriListesi Ara(string ad)
        {
            return liste.Filtrele(ad);
        }

        [Yetki("Müşteri Silme")]
        public void Sil(long tcNo)
        {
            liste.Remove(tcNo);
        }

        [Yetki("Müşteri Arama")]
        public MüşteriListesi Listele() {
            return liste.Filtrele(string.Empty);
        }
    }
}
