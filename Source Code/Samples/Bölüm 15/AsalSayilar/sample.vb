Imports System.Threading




Public Class Program




    Class Test

        Public Shared Toplam As Integer = 0
        Public Shared ReadOnly max As Integer = 10000
        Public Shared Sayi As Integer = Max
    End Class




    Public Shared Function AsalSayimi(ByVal sayi As Integer) As Boolean

        For i As Integer = 2 To sayi \ 2 + 1
            If sayi Mod i = 0 Then
                Return False
            End If
        Next
        Return True
    End Function


    Shared Sub AsalBul()
        Dim sayi As Integer = Interlocked.Decrement(Test.Sayi)

        While sayi > 2

            If AsalSayimi(sayi) Then
                Interlocked.Increment(Test.Toplam)
                Console.WriteLine("{0}, iþ parçacýðý {1} tarafýnfan bulundu.", sayi, Thread.CurrentThread.ManagedThreadId)
            End If

            sayi = Interlocked.Decrement(Test.Sayi)
        End While

    End Sub

    Shared Sub Main(ByVal args() As String)
        Dim list(9) As Thread

        Dim ts As ThreadStart = New ThreadStart(AddressOf AsalBul)

        For i As Integer = 0 To 9
            Dim t As Thread = New Thread(ts)
            list(i) = t
            t.Start()
        Next


        For Each t As Thread In list
            t.Join()
        Next

        Console.WriteLine("{0} deðerinden küçük toplam {1} asal sayý bulunmaktadýr.", _
                Test.max, Test.Toplam)


        Console.ReadLine()


    End Sub

    '----------------------------------------------------------------
    ' Converted from C# to VB .NET using CSharpToVBConverter(1.2).
    ' Developed by: Kamal Patel (http://www.KamalPatel.net) 
    '----------------------------------------------------------------



End Class