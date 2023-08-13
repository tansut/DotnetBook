using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public sealed class Operasyon
    {
        private string kod;

        public string Kod
        {
            get
            {
                return kod;
            }
            set
            {
                kod = value;
            }
        }
        private string ad;

        public string Ad
        {
            get
            {
                return ad;
            }
            set
            {
                ad = value;
            }
        }
        private string assembly;

        public string Assembly
        {
            get
            {
                return assembly;
            }
            set
            {
                assembly = value;
            }
        }
        private string sýnýf;

        public string Sýnýf
        {
            get
            {
                return sýnýf;
            }
            set
            {
                sýnýf = value;
            }
        }
        private string metot;

        public string Metot
        {
            get
            {
                return metot;
            }
            set
            {
                metot = value;
            }
        }

        internal Operasyon(string kod, string ad, string assembly, string sýnýf, string metot)
        {
            this.kod = kod;
            this.ad = ad;
            this.assembly = assembly;
            this.sýnýf = sýnýf;
            this.metot = metot;
        }

    }
}
