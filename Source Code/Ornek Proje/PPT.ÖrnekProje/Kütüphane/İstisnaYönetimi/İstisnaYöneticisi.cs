using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Kütüphane.İstisnaYönetimi
{
    public static class İstisnaYöneticisi
    {
        private static void Yayınla(Exception exc)
        {
            Exception temp = exc;
            StringBuilder sb = new StringBuilder();
            do
            {
                sb.Append(string.Format("İstisna Tipi: {0}, Kullanıcı: {1}\n",
                    temp.GetType().Name, Thread.CurrentPrincipal.Identity.Name));
                sb.Append(string.Format("Mesaj: {0}\n", temp.Message));
                sb.Append(string.Format("StackTrace: {0}", temp.StackTrace));
                sb.Append("------------------------------------------------\n\n");

                // . . .

                temp = temp.InnerException;

            } while (temp != null);

            EventLog.WriteEntry("PPT.NET", sb.ToString(), EventLogEntryType.Error);
        }

        private static ApplicationException Dönüştür(Exception exc)
        {
            if (exc is TeknikException)
                return (TeknikException)exc;
            else if (exc is KullanıcıException)
                return (KullanıcıException)exc;
            else if (exc is FormatException)
                return new KullanıcıException("Lütfen girdiğiniz değerleri kontrol ediniz. Bunun" +
                                              "bir hata sonucu oluştuğunu düşünüyorsanız teknik desteğe başvurunuz");
                return new TeknikException(exc);
        }

        public static ApplicationException Yonet(Exception exc, bool fırlat)
        {
            ApplicationException cExc = Dönüştür(exc);
            if (cExc is TeknikException)
                Yayınla(cExc);
            if (fırlat)
                throw cExc;
            else
                return cExc;
        }

        public static ApplicationException Yonet(Exception exc)
        {
            return Yonet(exc, false);
        }
    }
}
