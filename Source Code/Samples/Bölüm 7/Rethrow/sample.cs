namespace DotNetKitabý.Exceptions
{
    using System.Globalization;
    using System.Threading;
    using System.Text;
    using System.Collections.Generic;
    using System;
    using System.IO;
    using System.Collections;
    using System.Web;


    static class Program
    {
        

        static void Test()
        {
           throw new InvalidDataException("X");
        }

        static void Test1()
        {
            try
            {
                Test();
            }
            catch 
            {
                throw;
            }
        }

        static void Test2()
        {
            try
            {
                Test();
            }
            catch (Exception exc)
            {
                
                throw;
            }
        }

        static void Test3()
        {
            try
            {
                Test();
            }
            catch (Exception exc)
            {

                throw exc;
            }
        }


        static void Main(string[] args)
        {
            try
            {
                Test2();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.StackTrace);
            }

            Console.WriteLine("---------------------------------------------");

            try
            {
                Test3();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.StackTrace);
            }

            Console.ReadLine();
        }

    }
}