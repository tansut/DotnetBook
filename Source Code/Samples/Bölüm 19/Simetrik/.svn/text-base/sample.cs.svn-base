using System;
using System.Threading;
using System.Text;
using System.Diagnostics;
using System.Security.Principal;
using System.Security.Cryptography;
using System.IO;


namespace DotNetKitabý
{

    class Program
    {
        private const string IV = "0123456789ABCDRE";
        static void Sifrele(byte[] anahtar)
        {
            using (FileStream f = new FileStream(@"c:\x.dat", FileMode.Open))
            {
                RijndaelManaged aes = new RijndaelManaged();
                aes.Key = anahtar;
                aes.IV = Encoding.ASCII.GetBytes(IV);

                ICryptoTransform t = aes.CreateEncryptor();

                byte[] duzMetin = new byte[1024];

                using (FileStream hedef = new FileStream(@"c:\x.sif", FileMode.Create))
                {
                    using (CryptoStream cs = new CryptoStream(hedef, t, CryptoStreamMode.Write))
                    {
                        int okunan;
                        while ((okunan = f.Read(duzMetin, 0, duzMetin.Length)) > 0)
                        {
                            cs.Write(duzMetin, 0, okunan);
                        }
                        cs.Close();
                    }
                    hedef.Close();
                }
                f.Close();
            }
        }

        static void Coz(byte[] anahtar)
        {
            using (FileStream f = new FileStream(@"c:\x.sif", FileMode.Open))
            {
                RijndaelManaged aes = new RijndaelManaged();
                aes.Key = anahtar;
                aes.IV = Encoding.ASCII.GetBytes(IV);

                ICryptoTransform t = aes.CreateDecryptor();

                byte[] düzMetin = new byte[1024];

                using (FileStream hedef = new FileStream(@"c:\x.dat", FileMode.Create))
                {
                    using (CryptoStream cs = new CryptoStream(f, t, CryptoStreamMode.Read))
                    {
                        int okunan;
                        while ((okunan = cs.Read(düzMetin, 0, düzMetin.Length)) > 0)
                        {
                            hedef.Write(düzMetin, 0, okunan);
                        }
                        cs.Close();
                    }
                    hedef.Close();
                }
                f.Close();
            }
        }

        public static void Main()
        {
            Console.WriteLine("Þifre giriniz:");
            string sifre = Console.ReadLine();
            byte[] salt = Encoding.ASCII.GetBytes(sifre);

            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(sifre, salt);

            byte[] anahtar = rfc.GetBytes(32);

            Console.WriteLine("Þifreleniyor ...");
            Sifrele(anahtar);

            Console.WriteLine("Çözülüyor ...");
            Coz(anahtar);


        }





    }


}

