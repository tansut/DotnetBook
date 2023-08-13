namespace DotNetKitabý.Statics
{
    using System.Globalization;
    using System.Threading;
    using System.Text;
    using System.Collections.Generic;
    using System;
    using System.IO;
    using System.Collections;


    class NesneFabrikasi
    {
        private static 
            ArrayList list = new ArrayList();
        public static int ToplamNesne
        {
            get
            {
                return list.Count;
            }
        }
        public static object Uret()
        {
            object o = new object();
            list.Add(o);
            return o;
        }
        private NesneFabrikasi()
        {
        }
    }


    static class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                object o = NesneFabrikasi.Uret();
            }
            Console.WriteLine(NesneFabrikasi.ToplamNesne.ToString());
            Console.ReadLine();
        }
    }
}