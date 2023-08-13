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
            Console.WriteLine("{0} i� par�ac��� do�ru de�eri elde etti.", _
                    Thread.CurrentThread.ManagedThreadId)
        Else
            Console.WriteLine("{0} numaral� i� par�ac��� hatal� de�er elde etti.", _
                    Thread.CurrentThread.ManagedThreadId)
            Console.WriteLine("{0} numaral� i� par�as� de�eri {1} olarak okudu", _
                    Thread.CurrentThread.ManagedThreadId, sonuc)
        End If
    End Sub

    Shared Sub Degistir()
        Console.WriteLine("Toplam de�eri {0} i� par�as� taraf�ndan de�i�tirildi.", Thread.CurrentThread.ManagedThreadId)
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