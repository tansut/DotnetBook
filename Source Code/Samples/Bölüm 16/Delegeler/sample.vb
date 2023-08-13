Imports System.Threading
Imports System.IO
Imports System.Net


Class Program
    Delegate Function GetWebResponse() As WebResponse
    Shared sync As Object = New Object

    Shared tamamlanan As Integer = 0

    Shared Sub Main(ByVal args As String())
        Dim req As HttpWebRequest
        Dim resp As GetWebResponse
        Dim callBack As AsyncCallback
        For i As Integer = 0 To 9

            req = CType(HttpWebRequest.Create(("http://www.xxx.com/indir.aspx?Id=" + i.ToString)), HttpWebRequest)
            resp = AddressOf req.GetResponse
            callBack = New AsyncCallback(AddressOf IslemTamamlandi)
            resp.BeginInvoke(callBack, resp)
        Next
        Console.WriteLine("Ýþlemin tamamlanmasý bekleniyor ...")
        SyncLock sync
            While (tamamlanan < 10)
                Thread.Sleep(10)
                Monitor.Wait(sync)

            End While

        End SyncLock
        Console.WriteLine("Ýþlem tamamlandý")
    End Sub

    Private Shared Sub IslemTamamlandi(ByVal sonuc As IAsyncResult)
        Console.WriteLine("{0} numaralý ii parçacýðý tamamlandý ...", Thread.CurrentThread.ManagedThreadId)
        Dim r As GetWebResponse = CType(sonuc.AsyncState, GetWebResponse)
        Try
            Using resp As WebResponse = r.EndInvoke(sonuc)
                Using reader As StreamReader = New StreamReader(resp.GetResponseStream)
                    Console.WriteLine(reader.ReadToEnd)
                    reader.Close()
                End Using
                resp.Close()
            End Using
        Catch exc As Exception
            Console.WriteLine(exc.Message)
        End Try
        SyncLock sync
            tamamlanan = tamamlanan + 1
            Monitor.Pulse(sync)

        End SyncLock
    End Sub


End Class




