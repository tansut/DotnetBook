Imports System.Threading

Class Program

    Shared sync As Object = New Object
    Shared calisanIsParcacikSayisi As Integer = 100


    Private Shared Sub IslemYap(ByVal veri As Object)
        Console.WriteLine("Veri: {0}, Ýþ Parçacýðý: {1}", veri, Thread.CurrentThread.ManagedThreadId)
        Thread.Sleep(1000)
        SyncLock sync
            calisanIsParcacikSayisi = calisanIsParcacikSayisi - 1
            Monitor.Pulse(sync)
        End SyncLock
    End Sub

    Public Shared Sub Main()
        Dim callBack As WaitCallback = New WaitCallback(AddressOf IslemYap)
        Dim i As Integer = 0
        Do While (i < calisanIsParcacikSayisi)
            ThreadPool.QueueUserWorkItem(callBack, i)
            i = (i + 1)
        Loop
        Console.WriteLine("Ýþlerin tamamlanmasý bekleniyor ...")
        SyncLock sync

            While (calisanIsParcacikSayisi > 0)
                Monitor.Wait(sync)

            End While

        End SyncLock

        Console.WriteLine("Ýþler tamamlandý ...")
    End Sub


End Class
