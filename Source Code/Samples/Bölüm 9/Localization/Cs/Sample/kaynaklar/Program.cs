using System;
using System.Collections.Generic;
using System.Text;
using System.Resources;
using System.Reflection;
using System.Threading;
using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            ResourceManager r;
            r = new ResourceManager("kaynaklar", Assembly.GetExecutingAssembly());
            Console.WriteLine("Aktif Kültür: {0}", Thread.CurrentThread.CurrentUICulture.ToString());       
            Console.WriteLine(r.GetString("Onay"));
            CultureInfo trCulture;
            trCulture = new CultureInfo("tr-TR");
            Thread.CurrentThread.CurrentUICulture = trCulture;

            Console.WriteLine("Aktif Kültür: {0}", Thread.CurrentThread.CurrentUICulture.ToString());
            Console.WriteLine(r.GetString("Onay"));

            CultureInfo enCulture;
            enCulture = new CultureInfo("en-US");
            Console.WriteLine("Türkçe:{0}", r.GetString("Onay", trCulture));
            Console.WriteLine("Ýngilizce:{0}", r.GetString("Onay", enCulture));
            Console.ReadLine();
            
        }
    }
