Imports System.Globalization
Imports System.Threading
Imports System.Text
Imports System.Collections
Imports System
Imports System.IO



Class USBPort

    Public Enum UsbDurum

        A��k

        Kapal�

    End Enum

    Private durum As UsbDurum = UsbDurum.Kapal�

    Public Delegate Sub UsbDurumEventHandler(ByVal status As UsbDurum)

    Private durumDelegesi As UsbDurumEventHandler = Nothing

    Public Sub A�()
        durum = UsbDurum.A��k
        If Not durumDelegesi Is Nothing Then
            durumDelegesi(UsbDurum.A��k)
        End If
    End Sub

    Public Sub Kapat()
        durum = UsbDurum.Kapal�
        If Not durumDelegesi Is Nothing Then
            durumDelegesi(UsbDurum.Kapal�)
        End If
    End Sub

    Public Sub DurumEventHandlerEkle(ByVal handler As UsbDurumEventHandler)
        Dim temp As System.Delegate
        temp = System.Delegate.Combine(durumDelegesi, handler)
        durumDelegesi = CType(temp, UsbDurumEventHandler)

    End Sub

    Public Sub DurumEventHandler��kar(ByVal handler As UsbDurumEventHandler)
        Dim temp As System.Delegate
        temp = System.Delegate.Remove(durumDelegesi, handler)
        durumDelegesi = CType(temp, UsbDurumEventHandler)
    End Sub




End Class
Class Program

    Shared Sub DurumGoster(ByVal durum As USBPort.UsbDurum)
        Console.WriteLine("USB Port Durumu De�i�ti")
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
        port.A�()
        port.Kapat()
        Console.ReadLine()
    End Sub
End Class





