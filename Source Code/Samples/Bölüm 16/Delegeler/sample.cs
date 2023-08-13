using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;


namespace DotNetKitabý
{
    class Program
    {

        delegate WebResponse GetWebResponse();
        static object sync = new object();
        static int tamamlanan = 0;
        public static void Main()
        {
            HttpWebRequest req;
            GetWebResponse resp;
            AsyncCallback callBack;
            for (int i = 0; i < 10; i++)
            {
                req = (HttpWebRequest)HttpWebRequest.Create("http://www.xxx.com/indir.aspx?Id=" + i.ToString());
                resp = req.GetResponse;

                callBack = new AsyncCallback(IslemTamamlandi);
                Thread.Sleep(10);
                resp.BeginInvoke(callBack, resp);
            }

            Console.WriteLine("Ýþlemin tamamlanmasý bekleniyor ...");

            lock (sync)
            {
                while (tamamlanan < 10)
                {
                    Thread.Sleep(10);
                    Monitor.Wait(sync);
                }
            }

            Console.WriteLine("Ýþlem tamamlandý");

            Console.ReadLine();
        }

        static void IslemTamamlandi(IAsyncResult sonuc)
        {
            Console.WriteLine("{0} numaralý iþ parçacýðý tamamlandý ...", Thread.CurrentThread.ManagedThreadId);
            GetWebResponse r = (GetWebResponse)sonuc.AsyncState;

            try
            {
                using (WebResponse resp = r.EndInvoke(sonuc))
                {
                    using (StreamReader reader = new StreamReader(resp.GetResponseStream()))
                    {
                        Console.WriteLine(reader.ReadToEnd());
                        reader.Close();
                    }
                    resp.Close();
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            lock (sync)
            {
                tamamlanan++;
                Monitor.Pulse(sync);
            }

        }



    }


}

