Imports System

Namespace DotNetKitab�.�rnekUygulamalar
    Module Program
        Sub Main()
            Dim okunanMetin As String
            Console.WriteLine("Herhangi bir de�er giriniz:")
            okunanMetin = Console.ReadLine()
            Console.WriteLine(String.Format("Tarih-Saat:{0}, Girilen De�er:{1}", _
                DateTime.Now.ToString(), _
                okunanMetin))
        End Sub
    End Module
End Namespace