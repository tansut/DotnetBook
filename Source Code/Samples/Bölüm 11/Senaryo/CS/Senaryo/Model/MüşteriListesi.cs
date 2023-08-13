using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Model
{
    public class MüşteriListesi: KeyedCollection<long, Müşteri>
    {
        protected override long GetKeyForItem(Müşteri item)
        {
            return item.TcNo;
        }

        public MüşteriListesi Filtrele(string ad)
        {
            MüşteriListesi liste = new MüşteriListesi();
            foreach (Müşteri m in this) {
                if (m.Ad.StartsWith(ad, StringComparison.InvariantCultureIgnoreCase))
                    liste.Add(m);
            }
            return liste;
        }
    }
}
