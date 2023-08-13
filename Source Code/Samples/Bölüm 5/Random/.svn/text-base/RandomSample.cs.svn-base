namespace DotNetKitabý.Randoms
{
    using System.Globalization;
    using System.Threading;
    using System.Text;
    using System.Collections.Generic;
    using System;
    using System.IO;
    using System.Collections;

    public class RandomList
    {
        public string[] Uret()
        {
            ArrayList list = new ArrayList();
            Random r = new Random();
            int max = r.Next(1000);
            for (int i = 0; i < max; i++)
                list.Add(r.Next().ToString());
            return (string [])list.ToArray(typeof(string));
        }
    }

    static class Program
    {
        static void Main(string[] args)
        {
            RandomList l = new RandomList();
            string [] sl = l.Uret();
            foreach (string s in sl)
                Console.Write("{0} ", s);
            Console.ReadLine();
        }
    }
}