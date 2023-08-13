Imports System

Namespace DotNetKitabý.ÖrnekUygulamalar
    Module Program
        Sub Main()
            Dim okunanMetin As String
            Console.WriteLine("Herhangi bir deðer giriniz:")
            okunanMetin = Console.ReadLine()
            Console.WriteLine(String.Format("Tarih-Saat:{0}, Girilen Deðer:{1}", _
                DateTime.Now.ToString(), _
                okunanMetin))
        End Sub
    End Module
End Namespace