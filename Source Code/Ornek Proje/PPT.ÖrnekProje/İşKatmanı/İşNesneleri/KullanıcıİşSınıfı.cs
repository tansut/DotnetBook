using System;
using System.Collections.Generic;
using System.Text;
using İşKatmanı.İşVarlıkları;
using İşKatmanı.İşVarlıkları.KullanıcıTableAdapters;
using Kütüphane.Web;
using System.Security.Permissions;
using System.ComponentModel;

namespace İşKatmanı.İşNesneleri
{
    [System.ComponentModel.DataObjectAttribute(true)]
    public class KullanıcıİşSınıfı
    {
        [DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        [PrincipalPermission(SecurityAction.Demand, Role = "Yönetici")]
        public Kullanıcı.KullanıcıDataTable Ara(string ad, string sira, int baslangicSatir, int maxSatir)
        {
            KullanıcıTableAdapter adapter = new KullanıcıTableAdapter();
            return adapter.GetirKullanıcılar(ad, sira, baslangicSatir, maxSatir);
        }

        [DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        [PrincipalPermission(SecurityAction.Demand, Role = "Yönetici")]
        public int Ekle(ref int id, string ad, string şifre, string rol) {
            KullanıcıTableAdapter adapter = new KullanıcıTableAdapter();
            string tuz, ozetSifre;

            KimlikDoğrulamaModülü modül = new KimlikDoğrulamaModülü();
            modül.OzetHesapla(şifre, out ozetSifre, out tuz);

            return adapter.Insert(ref id, ad, ozetSifre, tuz, null, rol);
        }

        [DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        [PrincipalPermission(SecurityAction.Demand, Role = "Yönetici")]
        public int Sil(int id)
        {
            KullanıcıTableAdapter adapter = new KullanıcıTableAdapter();
            return adapter.Delete(id);
        }

        [PrincipalPermission(SecurityAction.Demand, Authenticated=true)]
        internal int Güncelle(Kullanıcı.KullanıcıDataTable table)
        {
            KullanıcıTableAdapter adapter = new KullanıcıTableAdapter();
            return adapter.Update(table);
        }

        [PrincipalPermission(SecurityAction.Demand, Role="Yönetici")]
        public int GetirKullanıcıSayısı(string ad, string sira, int baslangicSatir, int maxSatir)
        {
          KullanıcıTableAdapter adapter = new KullanıcıTableAdapter();
          return (int)adapter.GetirKullanıcıSayısı(ad);
        }

        public Kullanıcı.KullanıcıDataTable GetirKullanıcı(string ad)
        {
            KullanıcıTableAdapter adapter = new KullanıcıTableAdapter();
            return adapter.GetirKullanıcı(ad);
        }

    }
}
