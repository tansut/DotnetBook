Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Resources
Imports System.Reflection
Imports System.Threading
Imports System.Globalization
Module Program

    Sub Main(ByVal args() As String)
        Dim r As ResourceManager
        r = New ResourceManager("kaynaklar", Assembly.GetExecutingAssembly)
        Console.WriteLine("Aktif Kültür: {0}", Thread.CurrentThread.CurrentUICulture.ToString)
        Console.WriteLine(r.GetString("Onay"))
        Dim trCulture As CultureInfo
        trCulture = New CultureInfo("tr-TR")
        Thread.CurrentThread.CurrentUICulture = trCulture
        Console.WriteLine("Aktif Kültür: {0}", Thread.CurrentThread.CurrentUICulture.ToString)
        Console.WriteLine(r.GetString("Onay"))
        Dim enCulture As CultureInfo
        enCulture = New CultureInfo("en-US")
        Console.WriteLine("Türkçe:{0}", r.GetString("Onay", trCulture))
        Console.WriteLine("Ýngilizce:{0}", r.GetString("Onay", enCulture))
        Console.ReadLine()
    End Sub
End Module
