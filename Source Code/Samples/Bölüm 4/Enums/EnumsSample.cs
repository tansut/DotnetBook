using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetKitabý.Enums
{
    [Flags]
    public enum Hak
    {
        Okuma = 1,
        Yazma = 2,
        Silme = 4,
        Tümü = Okuma | Yazma | Silme
    }

    class Program
    {
        static void hakYazdýr(Hak hak)
        {
            if ((hak & Hak.Tümü) == Hak.Tümü)
                Console.WriteLine("Tüm haklar mevcut");
            else
            {
                if ((hak & Hak.Okuma) == Hak.Okuma)
                    Console.WriteLine("Okuma hakký mevcut");
                if ((hak & Hak.Yazma) == Hak.Yazma)
                    Console.WriteLine("Yazma hakký mevcut");
                if ((hak & Hak.Silme) == Hak.Silme)
                    Console.WriteLine("Silme hakký mevcut");
            }
        }

        static void Main(string[] args)
        {
            Hak hak1 = 0;
            Console.WriteLine("Hak1:");
            hakYazdýr(hak1);
            Hak hak2 = Hak.Okuma | Hak.Silme;
            Console.WriteLine("Hak2:");
            hakYazdýr(hak2);
            Hak hak3 = Hak.Tümü;
            Console.WriteLine("Hak3:");
            hakYazdýr(hak3);
            Hak hak4 = Hak.Tümü & ~Hak.Okuma;
            Console.WriteLine("Hak4:");
            hakYazdýr(hak4);
            Hak hak5 = Hak.Okuma | Hak.Silme | Hak.Yazma;
            Console.WriteLine("Hak5:");
            hakYazdýr(hak5);
            Console.ReadLine();
        }
    }
}