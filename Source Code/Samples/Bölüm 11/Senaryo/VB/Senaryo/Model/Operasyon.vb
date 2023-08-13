Imports System
Imports System.Collections.Generic
Imports System.Text


Public NotInheritable Class Operasyon

    Private _kod As String

    Private _ad As String

    Private _assembly As String

    Private _sýnýf As String

    Private _metot As String

    Friend Sub New(ByVal kod As String, ByVal ad As String, ByVal assembly As String, ByVal sýnýf As String, ByVal metot As String)
        _kod = kod
        _ad = ad
        _assembly = assembly
        _sýnýf = sýnýf
        _metot = metot
    End Sub

    Public Property Kod() As String
        Get
            Return _kod
        End Get
        Set(ByVal value As String)
            _kod = value
        End Set
    End Property

    Public Property Ad() As String
        Get
            Return _ad
        End Get
        Set(ByVal value As String)
            _ad = value
        End Set
    End Property

    Public Property Assembly() As String
        Get
            Return _assembly
        End Get
        Set(ByVal value As String)
            _assembly = value
        End Set
    End Property

    Public Property Sýnýf() As String
        Get
            Return _sýnýf
        End Get
        Set(ByVal value As String)
            _sýnýf = value
        End Set
    End Property

    Public Property Metot() As String
        Get
            Return _metot
        End Get
        Set(ByVal value As String)
            _metot = value
        End Set
    End Property
End Class
