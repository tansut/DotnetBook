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
        private string s�n�f;

        public string S�n�f
        {
            get
            {
                return s�n�f;
            }
            set
            {
                s�n�f = value;
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

        internal Operasyon(string kod, string ad, string assembly, string s�n�f, string metot)
        {
            this.kod = kod;
            this.ad = ad;
            this.assembly = assembly;
            this.s�n�f = s�n�f;
            this.metot = metot;
        }

    }
}
