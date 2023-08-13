using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Müşteri
    {
        private long tcNo;

        public long TcNo
        {
            get
            {
                return tcNo;
            }
            set
            {
                tcNo = value;
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
        private string soyad;

        public string Soyad
        {
            get
            {
                return soyad;
            }
            set
            {
                soyad = value;
            }
        }

        public Müşteri(long tcNo, string ad, string soyad)
        {
            this.tcNo = tcNo;
            this.ad = ad;
            this.soyad = soyad;
        }
    }
}
