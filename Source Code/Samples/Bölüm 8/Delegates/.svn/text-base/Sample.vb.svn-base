Imports System.Globalization
Imports System.Threading
Imports System.Text
Imports System.Collections
Imports System
Imports System.IO



Class USBPort

    Public Enum UsbDurum

        Açýk

        Kapalý

    End Enum

    Private durum As UsbDurum = UsbDurum.Kapalý

    Public Delegate Sub UsbDurumEventHandler(ByVal status As UsbDurum)

    Private durumDelegesi As UsbDurumEventHandler = Nothing

    Public Sub Aç()
        durum = UsbDurum.Açýk
        If Not durumDelegesi Is Nothing Then
            durumDelegesi(UsbDurum.Açýk)
        End If
    End Sub

    Public Sub Kapat()
        durum = UsbDurum.Kapalý
        If Not durumDelegesi Is Nothing Then
            durumDelegesi(UsbDurum.Kapalý)
        End If
    End Sub

    Public Sub DurumEventHandlerEkle(ByVal handler As UsbDurumEventHandler)
        Dim temp As System.Delegate
        temp = System.Delegate.Combine(durumDelegesi, handler)
        durumDelegesi = CType(temp, UsbDurumEventHandler)

    End Sub

    Public Sub DurumEventHandlerÇýkar(ByVal handler As UsbDurumEventHandler)
        Dim temp As System.Delegate
        temp = System.Delegate.Remove(durumDelegesi, handler)
        durumDelegesi = CType(temp, UsbDurumEventHandler)
    End Sub




End Class
Class Program

    Shared Sub DurumGoster(ByVal durum As USBPort.UsbDurum)
        Console.WriteLine("USB Port Durumu Deðiþti")
        Console.WriteLine("Yeni Durum: {0}", durum)
    End Sub

    Shared Sub DurumLogla(ByVal durum As USBPort.UsbDurum)
        Console.WriteLine("Yeni durum kaydedildi")
        Console.WriteLine("Kaydedilen durum: {0}", durum)
    End Sub

    Shared Sub Main(ByVal args() As String)
        Dim port As USBPort = New USBPort
        port.DurumEventHandlerEkle(AddressOf DurumGoster)
        port.DurumEventHandlerEkle(AddressOf DurumLogla)
        port.Aç()
        port.Kapat()
        Console.ReadLine()
    End Sub
End Class





