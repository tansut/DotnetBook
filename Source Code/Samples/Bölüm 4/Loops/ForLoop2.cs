namespace DotNetKitabý.ForLoop
{
    using System.Globalization;
    using System.Threading;
    using System.Text;
    using System.Collections.Generic;
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            string fileName = Console.ReadLine();

            for (StreamReader reader = new StreamReader(fileName, true); 
                !reader.EndOfStream; 
                Console.WriteLine(reader.ReadLine()));
                  
        }
    }
}