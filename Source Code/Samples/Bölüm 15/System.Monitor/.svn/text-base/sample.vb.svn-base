Imports System.Threading

Class Program

    Class Test

        Private sync As Object = New Object()

        Private sinyalGeldiMi As Boolean

        Public Sub IslemYap()
            SyncLock sync
                Console.WriteLine("Sinyal bekleniyor ... {0}", sinyalGeldiMi)
                Monitor.Wait(sync)
                Console.WriteLine("Sinyal geldi ... {0}", sinyalGeldiMi)
            End SyncLock
        End Sub

        Public Sub SinyalIlet()
            SyncLock sync
                sinyalGeldiMi = True
                Console.WriteLine("Sinyal iletiliyor ...")
                Monitor.Pulse(sync)
            End SyncLock

        End Sub
    End Class


    Shared Sub Main(ByVal args() As String)
        Dim testObj As Test = New Test()
        Dim t As Thread = New Thread(AddressOf testObj.IslemYap)
        t.Start()
        Thread.Sleep(1000)
        testObj.SinyalIlet()
        Console.ReadLine()
    End Sub

End Class
