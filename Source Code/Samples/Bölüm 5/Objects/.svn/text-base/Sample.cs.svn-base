namespace DotNetKitabý.Objects
{
    using System.Globalization;
    using System.Threading;
    using System.Text;
    using System.Collections.Generic;
    using System;
    using System.IO;
    using System.Collections;

    class Test
    {
        public static void A(out object o)
        {
            o = 12;
        }

        public static void B(ref object o)
        {
            o = new StringBuilder();
        }

        public static void C(object o)
        {
            o = 12;
        }
        public static void D(object o)
        {
            if (o is StringBuilder)
                ((StringBuilder)o).Append("Test String\t");
        }

        public static void E(ref object o)
        {
            if (o is StringBuilder)
                ((StringBuilder)o).Append("Test String\t");
        }

    }

    static class Program
    {
        static void Bilgi(object o)
        {
            Console.WriteLine("{0}\t{1}", o.GetType().Name, o.ToString());
        }
        static void Main(string[] args)
        {
            object o;
            Test.A(out o);
            Bilgi(o);
            Test.B(ref o);
            Bilgi(o);
            Test.C(o);
            Bilgi(o);
            Test.D(o);
            Bilgi(o);
            Test.E(ref o);
            Bilgi(o);
            Console.ReadLine();
        }
    }
}