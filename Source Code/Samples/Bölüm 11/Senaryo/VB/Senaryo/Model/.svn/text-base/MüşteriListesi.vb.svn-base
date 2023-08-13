Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Text


Public Class MüşteriListesi
    Inherits KeyedCollection(Of Long, Müşteri)

    Protected Overrides Function GetKeyForItem(ByVal item As Müşteri) As Long
        Return Item.TcNo
    End Function

    Public Function Filtrele(ByVal ad As String) As MüşteriListesi
        Dim liste As MüşteriListesi
        liste = New MüşteriListesi()
        For Each m As Müşteri In Me
            If m.Ad.StartsWith(ad, StringComparison.InvariantCultureIgnoreCase) Then
                liste.Add(m)
            End If
        Next
        Return liste
    End Function
End Class
