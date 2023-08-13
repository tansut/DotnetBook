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

        static FileInfo[] TumDosyalariAl(string ustKlasor)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(ustKlasor);

            DirectoryInfo[] dirList = dirInfo.GetDirectories();

            List<FileInfo> list = new List<FileInfo>();

            FileInfo [] fileList = dirInfo.GetFiles();

            list.AddRange(fileList);

            foreach (DirectoryInfo info in dirList)
                list.AddRange(TumDosyalariAl(info.FullName));

            return list.ToArray();
        }



        static void Main(string[] args)
        {

            Console.Write("Klasör giriniz:");
            
            string dirName = Console.ReadLine();

            if (dirName.Length == 0)
                return;

            FileInfo [] files =  TumDosyalariAl(dirName);

            foreach (FileInfo f in files)
                Console.WriteLine(f.FullName);

            Console.WriteLine("Toplam {0} adet dosya bulundu.", files.Length);


            Console.ReadLine();
        }
    }
}
