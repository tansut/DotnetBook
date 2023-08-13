Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.Collections.ObjectModel
Imports System.Text
Imports System.IO
Imports System.Net

Class Program

    Shared Sub Main(ByVal args() As String)

        Dim istek As HttpWebRequest

        istek = CType(HttpWebRequest.Create("http://www.dotnetturk.com"), HttpWebRequest)

        istek.Method = "POST"

        Dim girdi As Stream = istek.GetRequestStream()

        Dim girdiBytes() As Byte = Encoding.UTF8.GetBytes("Ara=deneme&Tip=1")

        girdi.Write(girdiBytes, 0, girdiBytes.Length)

        girdi.Close()

        Dim resp As WebResponse = istek.GetResponse()

        Dim cikti As Stream = resp.GetResponseStream()

        Dim ciktiBytes() As Byte = New Byte(100) {}

        Dim okunan As Integer = cikti.Read(ciktiBytes, 0, ciktiBytes.Length)

        While okunan > 0
            Console.Write(Encoding.UTF8.GetString(ciktiBytes, 0, okunan))
            okunan = cikti.Read(ciktiBytes, 0, ciktiBytes.Length)
        End While

        Console.ReadLine()




    End Sub


End Class