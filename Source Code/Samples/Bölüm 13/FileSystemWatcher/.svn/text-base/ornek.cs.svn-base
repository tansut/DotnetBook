using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.IO.Ports;
using System.IO;
using System.IO.IsolatedStorage;

namespace DotNetKitabý
{

    class Program
    {

        static void Main(string[] args)
        {

            FileSystemWatcher w;

            w = new FileSystemWatcher(@"c:\test", "*.config");


            w.Error += w_Error;
            w.Created += DosyaIslemi;
            w.Deleted += DosyaIslemi;
            w.Changed += DosyaIslemi;
            w.Renamed += w_Renamed;

            w.EnableRaisingEvents = true;

            Console.WriteLine("Ýzlenen klasör: {0}", w.Path);
            Console.WriteLine("Ýzlemeyi durdurmak için <enter> tuþu ...");

            Console.ReadLine();

            w.EnableRaisingEvents = false;



        }

        static void w_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("Yeniden adlandýrma: {0}->{1}", e.OldName, e.Name);   
        }

        static void DosyaIslemi(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Dosya iþlemi bilgileri:");
            Console.WriteLine("Ýþlem: {0}", e.ChangeType);
            Console.WriteLine("Bütünleþik dosya adý: {0}", e.FullPath);
            Console.WriteLine("Dosya adý: {0}", e.Name);
        }

        static void w_Error(object sender, ErrorEventArgs e)
        {
            Console.WriteLine("Hata: {0}", e.GetException().Message);
        }
    }
}
