Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.Collections.ObjectModel
Imports System.Text
Imports System.IO


Class Program

    Shared Sub Main(ByVal args() As String)

        Dim w As FileSystemWatcher

        w = New FileSystemWatcher("c:\test", "*.config")

        AddHandler w.Error, AddressOf w_Error
        AddHandler w.Created, AddressOf DosyaIslemi
        AddHandler w.Deleted, AddressOf DosyaIslemi
        AddHandler w.Changed, AddressOf DosyaIslemi
        AddHandler w.Renamed, AddressOf w_Rename

        w.EnableRaisingEvents = True

        Console.WriteLine("Ýzlenen klasör: {0}", w.Path)
        Console.WriteLine("Ýzlemeyi durdurmak için <enter> tuþu ...")

        Console.ReadLine()

        w.EnableRaisingEvents = False



    End Sub

    Shared Sub DosyaIslemi(ByVal sender As Object, ByVal e As FileSystemEventArgs)
        Console.WriteLine("Dosya iþlemi bilgileri:")
        Console.WriteLine("Ýþlem: {0}", e.ChangeType)
        Console.WriteLine("Bütünleþik dosya adý: {0}", e.FullPath)
        Console.WriteLine("Dosya adý: {0}", e.Name)
    End Sub

    Shared Sub w_Error(ByVal sender As Object, ByVal e As ErrorEventArgs)
        Console.WriteLine("Hata: {0}", e.GetException().Message)
    End Sub

    Shared Sub w_Rename(ByVal sender As Object, ByVal e As RenamedEventArgs)
        Console.WriteLine("Yeniden adlandýrma: {0}->{1}", e.OldName, e.Name)

    End Sub

End Class