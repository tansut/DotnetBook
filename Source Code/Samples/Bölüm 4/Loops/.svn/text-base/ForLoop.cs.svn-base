namespace DotNetKitabý.ForLoop
{
    using System.Globalization;
    using System.Threading;
    using System.Text;
    using System.Collections.Generic;
    using System;

    class Program
    {
        static bool kontrolEt(int x)
        {
            return x < 5 ? true : false;
        }

        static void yazdýr(ref int x)
        {
            Console.WriteLine((x++).ToString());
        }

        static void Main(string[] args)
        {

            for (int i = 0, j = 5, m = 5;
                kontrolEt(i); 
                i++, j += 2, yazdýr(ref m))
            {
                Console.WriteLine("i={0}", i.ToString());
            }
        }
    }
}