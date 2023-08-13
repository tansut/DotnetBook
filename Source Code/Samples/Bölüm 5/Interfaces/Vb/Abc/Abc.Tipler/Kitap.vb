
Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace Abc.Tipler
    Public Structure Kitap

        Public Isbn As String

        Public Ad As String

        Public Yazar As String

        Public Konu As String

        Public Fiyat As Single
    End Structure

    Public Interface IKitapDeposu

        ReadOnly Property DepoAd() As String

        Function AramaYap(ByVal konu As String) As Kitap()

        Sub SiparisGonder(ByVal isbn As String)
    End Interface
End Namespace
