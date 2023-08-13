Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Model


Public Class MüşteriİşSınıfı

    Private Shared liste As MüşteriListesi = New MüşteriListesi()

    <Yetki("Müşteri Ekleme")> _
    Public Sub Ekle(ByVal müşteri As Müşteri)
        Try
            liste.Add(müşteri)
        Catch exc As ArgumentException
            Throw New ApplicationException("Aynı T.C. No ile müşteri bulunmaktadır")
        End Try
    End Sub

    <Yetki("Müşteri Arama")> _
    Public Function Ara(ByVal ad As String) As MüşteriListesi
        Return liste.Filtrele(ad)
    End Function

    <Yetki("Müşteri Silme")> _
    Public Sub Sil(ByVal tcNo As Long)
        liste.Remove(tcNo)
    End Sub
    <Yetki("Müşteri Arama")> _
    Public Function Listele() As MüşteriListesi
        Return liste.Filtrele(String.Empty)
    End Function
End Class
