Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.Collections.ObjectModel
Imports System.Text
Imports System.IO


Class Program

    Shared Function TumDosyalariAl(ByVal ustKlasor As String) As FileInfo()

        Dim dirInfo As DirectoryInfo = New DirectoryInfo(ustKlasor)

        Dim dirList() As DirectoryInfo = dirInfo.GetDirectories()

        Dim list As List(Of FileInfo) = New List(Of FileInfo)()

        Dim fileList() As FileInfo = dirInfo.GetFiles()

        list.AddRange(fileList)

        Dim info As DirectoryInfo
        For Each info In dirList
            list.AddRange(TumDosyalariAl(info.FullName))
        Next

        Return list.ToArray()
    End Function




    Shared Sub Main()

        Console.Write("Klasör giriniz:")

        Dim dirName As String = Console.ReadLine()

        If dirName.Length = 0 Then
            Return
        End If

        Dim files() As FileInfo = TumDosyalariAl(dirName)

        Dim f As FileInfo
        For Each f In files
            Console.WriteLine(f.FullName)
        Next

        Console.WriteLine("Toplam {0} adet dosya bulundu.", files.Length)


        Console.ReadLine()


    End Sub

End Class