Imports System.Threading


Public Class Program

    Class Test
        Public Shared Toplam As Integer = 0
    End Class


    Shared Sub KontrolEt()
        Test.Toplam = 12

        Thread.Sleep(10)

        Dim sonuc As Integer = Test.Toplam

        If sonuc = 12 Then
            Console.WriteLine("{0} iþ parçacýðý doðru deðeri elde etti.", _
                    Thread.CurrentThread.ManagedThreadId)
        Else
            Console.WriteLine("{0} numaralý iþ parçacýðý hatalý deðer elde etti.", _
                    Thread.CurrentThread.ManagedThreadId)
            Console.WriteLine("{0} numaralý iþ parçasý deðeri {1} olarak okudu", _
                    Thread.CurrentThread.ManagedThreadId, sonuc)
        End If
    End Sub

    Shared Sub Degistir()
        Console.WriteLine("Toplam deðeri {0} iþ parçasý tarafýndan deðiþtirildi.", Thread.CurrentThread.ManagedThreadId)
        Test.Toplam = 13
    End Sub

    Shared Sub Main(ByVal args() As String)
        KontrolEt()

        Dim ts As ThreadStart = New ThreadStart(AddressOf Degistir)

        Dim t As Thread = New Thread(ts)
        t.Start()

        KontrolEt()

        Console.ReadLine()


    End Sub


End Class