using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.IO.Ports;
using System.IO;
using System.IO.IsolatedStorage;
using System.Net;

namespace DotNetKitabý
{
    class Program
    {

        static void Main(string[] args)
        {

            HttpWebRequest istek;

            istek = HttpWebRequest.Create("http://www.dotnetturk.com") as HttpWebRequest;

            istek.Method = "POST";

            Stream girdi = istek.GetRequestStream();

            byte [] girdiBytes = Encoding.UTF8.GetBytes("Ara=deneme&Tip=1");

            girdi.Write(girdiBytes, 0, girdiBytes.Length);

            girdi.Close();

            WebResponse resp = istek.GetResponse();

            Stream cikti = resp.GetResponseStream();

            byte[] ciktiBytes = new byte[100];

            int okunan;

            while ((okunan = cikti.Read(ciktiBytes, 0, ciktiBytes.Length)) > 0) {
                Console.Write(Encoding.UTF8.GetString(ciktiBytes, 0, okunan));
            }

            Console.ReadLine();
        }


    }
}
