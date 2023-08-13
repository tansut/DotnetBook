namespace DotNetKitabý.Strings
{
    using System.Globalization;
    using System.Threading;
    using System.Text;
    using System.Collections.Generic;
    using System;


    class Program
    {

        static void Main(string[] args)
        {
            string s1 = "i";
            string s2 = "0";
            string s3 = "I";
            string s4 = "1";
            Console.WriteLine("Aktif Kültür: {0}", Thread.CurrentThread.CurrentCulture.DisplayName);
            bool b1  = String.Compare(s1, s2) == 0;
            bool b2  = String.Compare(s1, s2, true) == 0;
            bool b3  = String.Compare(s1, s3) == 0;
            bool b4  = String.Compare(s1, s2, StringComparison.InvariantCultureIgnoreCase) == 0;
            bool b5  = String.Compare(s1, s3, StringComparison.InvariantCultureIgnoreCase) == 0;
            bool b6 = String.Compare(s1, s2, true, CultureInfo.InvariantCulture) == 0;
            bool b7 = String.Compare(s4, s3, true) == 0;
            bool b8 = String.Compare(s4, s3, true, CultureInfo.InvariantCulture) == 0;
            bool b9 = String.Compare(s1, s2, StringComparison.CurrentCultureIgnoreCase) == 0;
            Console.WriteLine("B1: {0}", b1);
            Console.WriteLine("B2: {0}", b2);
            Console.WriteLine("B3: {0}", b3);
            Console.WriteLine("B4: {0}", b4);
            Console.WriteLine("B5: {0}", b5);
            Console.WriteLine("B6: {0}", b6);
            Console.WriteLine("B7: {0}", b7);
            Console.WriteLine("B8: {0}", b8);
            Console.WriteLine("B9: {0}", b9);
            string s = "Ali";
            if ((s.ToLowerInvariant() == "ali"))
            {
                Console.WriteLine("OK");
            }
            if (string.Compare(s, "ALI", StringComparison.InvariantCultureIgnoreCase) == 0)
            {
                Console.WriteLine("OK");
            }
            Console.ReadLine();
        }
    }
}