namespace DotNetKitabý.Delegates
{
    using System.Globalization;
    using System.Threading;
    using System.Text;
    using System.Collections.Generic;
    using System;
    using System.IO;
    using System.Collections;
    using System.Web;

    class USBPort
    {
        public enum UsbDurum {
            Açýk,
            Kapalý
        }

        private UsbDurum durum = UsbDurum.Kapalý;

        public delegate void UsbDurumEventHandler(UsbDurum status);
        private UsbDurumEventHandler durumDelegesi = null;


        public void Aç()
        {
            durum = UsbDurum.Açýk;
            if (durumDelegesi != null)
                durumDelegesi(UsbDurum.Açýk);
        }

        public void Kapat()
        {
            durum = UsbDurum.Kapalý;
            if (durumDelegesi != null)
                durumDelegesi(UsbDurum.Kapalý);
        }

        public void DurumEventHandlerEkle(UsbDurumEventHandler handler)
        {
            durumDelegesi += handler;
        }

        public void DurumEventHandlerÇýkar(UsbDurumEventHandler handler)
        {
            durumDelegesi -= handler;
        }

    }

    static class Program
    {
        static void DurumGoster(USBPort.UsbDurum durum)
        {
            Console.WriteLine("USB Port Durumu Deðiþti");
            Console.WriteLine("Yeni Durum: {0}", durum);
        }

        static void DurumLogla(USBPort.UsbDurum durum)
        {
            Console.WriteLine("Yeni durum kaydedildi");
            Console.WriteLine("Kaydedilen durum: {0}", durum);
        }

        static void Main(string[] args)
        {
            USBPort port = new USBPort();
            port.DurumEventHandlerEkle(DurumGoster);
            port.DurumEventHandlerEkle(DurumLogla);

            port.Aç();
            port.Kapat();

            Console.ReadLine();

        }

    }
}