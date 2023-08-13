Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Text


Public NotInheritable Class OperasyonListesi
    Inherits KeyedCollection(Of String, Operasyon)


    Private Shared _liste As OperasyonListesi

    Shared Sub New()
        _liste = New OperasyonListesi()
        _liste.Add(New Operasyon("MüþteriEkle", "Müþteri Ekleme", "Ýþ", "Ýþ.MüþteriÝþSýnýfý", "Ekle"))
        _liste.Add(New Operasyon("MüþteriAra", "Müþteri Arama", "Ýþ", "Ýþ.MüþteriÝþSýnýfý", "Ara"))
        _liste.Add(New Operasyon("MüþteriSil", "Müþteri Silme", "Ýþ", "Ýþ.MüþteriÝþSýnýfý", "Sil"))
        _liste.Add(New Operasyon("MüþteriListele", "Müþteri Arama", "Ýþ", "Ýþ.MüþteriÝþSýnýfý", "Listele"))
    End Sub

    Private Sub New()

    End Sub

    Public Shared ReadOnly Property Liste() As OperasyonListesi
        Get
            Return _liste
        End Get
    End Property

    Protected Overrides Function GetKeyForItem(ByVal item As Operasyon) As String
        Return item.Kod
    End Function
End Class
