using System;
using System.Collections.Generic;
using System.Text;
using İşKatmanı.İşVarlıkları;
using System.Security.Authentication;
using Kütüphane.Web;

namespace İşKatmanı.İşNesneleri
{
    public class KimlikDogrulamaİşSınıfı
    {
        public void GirişYap(string ad, string şifre, bool kalıcı)
        {
            KullanıcıİşSınıfı işNesnesi = new KullanıcıİşSınıfı();
            Kullanıcı.KullanıcıDataTable tablo = işNesnesi.GetirKullanıcı(ad);
            if (tablo.Rows.Count == 0)
                throw new AuthenticationException("Geçersiz kullanıcı / şifre");
            KimlikDoğrulamaModülü modül = new KimlikDoğrulamaModülü();
            modül.KullanıcıDoğrula(tablo[0].Ad, şifre, tablo[0].OzetSifre, tablo[0].Tuz, tablo[0].Rol, kalıcı);
            tablo[0].SonGiris = DateTime.Now;
            işNesnesi.Güncelle(tablo);
        }
    }
}
