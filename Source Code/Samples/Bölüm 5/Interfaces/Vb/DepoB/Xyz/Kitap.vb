﻿Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Abc.Tipler

Namespace Xyz
    Public Class Sorgu
        Implements IKitapDeposu

        Public ReadOnly Property DepoAd() As String Implements IKitapDeposu.DepoAd
            Get
                Return "B Deposu, BBB Ltd. Şti"
            End Get
        End Property

        Public Function AramaYap(ByVal konu As String) As Kitap() Implements IKitapDeposu.AramaYap
            Dim k As Kitap = New Kitap
            k.Ad = "Örnek B Depo Kitabı"
            k.Fiyat = 67
            k.Isbn = "9012341234111"
            k.Konu = "Örnek B Depo Kitap Konusu"
            k.Yazar = "B Depo Kitabı Yazarı"
            Return New Kitap() {k}
        End Function

        Public Sub SiparisGonder(ByVal isbn As String) Implements IKitapDeposu.SiparisGonder

        End Sub

    End Class
End Namespace
