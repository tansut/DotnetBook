Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Threading
Imports System.Globalization
Imports System.IO

Namespace DotNetKitabý.Loops
    Class Program
        Shared Sub Main(ByVal args() As String)
            Console.WriteLine("Dosya adý giriniz:")
            Dim fileName As String = Console.ReadLine()
            If Not String.IsNullOrEmpty(fileName) And File.Exists(fileName) Then
                Dim reader As StreamReader = New StreamReader(fileName, True)

                While Not reader.EndOfStream
                    Console.WriteLine(reader.ReadLine())
                End While

                reader.Close()
            End If

            Console.ReadLine()

        End Sub
    End Class
End Namespace