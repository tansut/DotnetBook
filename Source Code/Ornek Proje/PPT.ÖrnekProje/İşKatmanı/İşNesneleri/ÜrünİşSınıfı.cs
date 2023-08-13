using System;
using System.Collections.Generic;
using System.Text;
using İşKatmanı.İşVarlıkları.ÜrünTableAdapters;
using System.Security.Permissions;
using System.ComponentModel;

namespace İşKatmanı.İşNesneleri
{
    [System.ComponentModel.DataObjectAttribute(true)]
    public class ÜrünİşSınıfı
    {
        [DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public İşKatmanı.İşVarlıkları.Ürün.ÜrünDataTable GetirÜrünler(string Ad, string sira, int baslangicSatir, int maxSatir)
        {
            ÜrünTableAdapter adapter = new ÜrünTableAdapter();
            return adapter.GetirÜrünler(Ad, sira, baslangicSatir, maxSatir);
        }

        [DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        [PrincipalPermission(SecurityAction.Demand, Role = "Yönetici")]
        public int Ekle(ref int Id, string Ad, int StokAdet, string ResimBaglanti, decimal Ucret)
        {
            ÜrünTableAdapter adapter = new ÜrünTableAdapter();
            return adapter.Insert(ref Id, Ad, StokAdet, ResimBaglanti, Ucret);
        }

        [DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        [PrincipalPermission(SecurityAction.Demand, Role = "Yönetici")]
        public int Sil(int Id)
        {
            ÜrünTableAdapter adapter = new ÜrünTableAdapter();
            return adapter.Delete(Id);
        }

        [DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        [PrincipalPermission(SecurityAction.Demand, Role = "Yönetici")]
        public int Update(int Id, string Ad, int StokAdet, string ResimBaglanti, decimal ucret)
        {
            ÜrünTableAdapter adapter = new ÜrünTableAdapter();
            return adapter.Update(Id, Ad, StokAdet, ResimBaglanti, ucret);
        }

        public int GetirÜrünSayısı(string ad, string sira, int baslangicSatir, int maxSatir)
        {
            ÜrünTableAdapter adapter = new ÜrünTableAdapter();
            return (int)adapter.GetirÜrünSayısı(ad);
        }

        [DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public İşKatmanı.İşVarlıkları.Ürün.ÜrünRow GetirÜrün(int id)
        {
            ÜrünTableAdapter adapter = new ÜrünTableAdapter();
            return adapter.GetirIdIle(id)[0];
        }

    }
}
