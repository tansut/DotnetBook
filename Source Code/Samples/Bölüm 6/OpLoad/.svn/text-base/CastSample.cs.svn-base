namespace DotNetKitabý.TypeCasts
{
    using System.Globalization;
    using System.Threading;
    using System.Text;
    using System.Collections.Generic;
    using System;
    using System.IO;
    using System.Collections;



    class Daire
    {
        private int r;
        public Daire(int r)
        {
            this.r = r;
        }

        public override bool Equals(object o)
        {
            if (o is Daire)
            {
                Daire obj = (Daire)o;
                return obj.r == this.r;
            }
            return false;
        }

        public static Daire operator +(Daire d1, Daire d2)
        {
            return new Daire(d1.r + d2.r);
        }

        public static bool operator ==(Daire d1, Daire d2)
        {
            return d1.r == d2.r;
        }

        public static bool operator !=(Daire d1, Daire d2)
        {
            return d1.r != d2.r;
        }

        public static bool operator <(Daire d1, Daire d2)
        {
            return d1.r < d2.r;
        }

        public static bool operator >(Daire d1, Daire d2)
        {
            return d1.r > d2.r;
        }
    }

    class Elips
    {
        private int r1;
        private int r2;
        public Elips(int r1, int r2)
        {
            this.r1 = r1;
            this.r2 = r2;
        }

        public static explicit operator Daire(Elips e)
        {
            return new Daire(System.Math.Min(e.r1, e.r2));
        }

        public static implicit operator int(Elips e)
        {
            return 12;
        }

    }


    static class Program
    {
        static void Main(string[] args)
        {
            Daire d1 = new Daire(4);
            Daire d2 = new Daire(3);
            Daire d3 = d1 + d2;

            Daire d4 = new Daire(4);
            Daire d5 = d2;
            Console.WriteLine("d4 EÞÝT d1: {0}", d4 == d1);
            Console.WriteLine("d5 EÞÝT d2: {0}", d5 == d2);
            Console.WriteLine("d3 EÞÝT d1 + d2: {0}", d3 == d1 + d2);
            Console.WriteLine("d4 REF EÞÝT d1: {0}", d4.Equals(d1));
            Console.WriteLine("d5 REF EÞÝT d2: {0}", d5.Equals(d2));
            Console.WriteLine("d2 BÜYÜK d1: {0}", d2 > d1);
            Console.WriteLine("d3 KÜÇÜK d1: {0}", d3 < d1);

            Console.ReadLine();
        }

    }
}