using System;
using System.Collections.Generic;
using System.Text;
using İşKatmanı.İşVarlıkları;
using System.Web;

namespace İşKatmanı.İşNesneleri
{
    public static class SepetYöneticisi
    {
        public static SepetListesi Liste
        {
            get
            {
                if (HttpContext.Current.Session["Sepet"] == null)
                    HttpContext.Current.Session["Sepet"] = new SepetListesi();

                SepetListesi liste = (SepetListesi)HttpContext.Current.Session["Sepet"];
                return liste;

            }
        }

        public static void Ekle(int ürünId, int adet)
        {
            

            Sepet sepet;

            if (ÜrünVarmı(ürünId))
            {
                sepet = Liste[ürünId];
                sepet.Adet += adet;
            }
            else
            {
                ÜrünİşSınıfı işNesnesi = new ÜrünİşSınıfı();
                Ürün.ÜrünRow ürün = işNesnesi.GetirÜrün(ürünId);
                sepet = new Sepet(ürünId, ürün.Ad, adet, ürün.Ucret);
                Liste.Add(sepet);
            }


            
        }

        public static void Sil(int ürünId)
        {
            Liste.Remove(ürünId);
        }

        public static void Temizle()
        {
            HttpContext.Current.Session["Sepet"] = null;
        }
        
        public static bool ÜrünVarmı(int ürünId)
        {
            Sepet temp = new Sepet(ürünId, "", 0, 0);
            return Liste.IndexOf(temp) > -1;
        }
    }
}
