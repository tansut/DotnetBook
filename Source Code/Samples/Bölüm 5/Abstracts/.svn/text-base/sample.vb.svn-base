Imports System.Globalization
Imports System.Threading
Imports System.Text
Imports System.Collections
Imports System
Imports System.IO

MustInherit Class TemelKullanýcý
    Private _ad As String

    Protected Sub New(ByVal ad As String)
        Me._ad = ad
        Console.WriteLine("TemelKullanýcý Oluþturuldu")
    End Sub

    Public Property Ad() As String
        Get
            Return _ad
        End Get
        Protected Set(ByVal value As String)
            _ad = value
        End Set
    End Property

End Class

MustInherit Class YetkiliKullanýcý
    Inherits TemelKullanýcý

    Protected Sub New(ByVal ad As String)
        MyBase.New(ad)
        Console.WriteLine("YetkiliKullanýcý oluþturuldu")
    End Sub



    Public MustOverride _
    ReadOnly Property _
     YetkiDuzeyi() As Integer

    Public MustOverride _
    Function _
     YetkiSahibiMi(ByVal iþlem _
     As String) As Boolean

End Class

Class YöneticiKullanýcý
    Inherits YetkiliKullanýcý

    Public Sub New(ByVal ad As String)
        MyBase.New(ad)
        Console.WriteLine("YöneticiKullanýcý oluþturuldu")
    End Sub

    Private Shared yetkiListesi _
      As ArrayList


    Shared Sub New()
        yetkiListesi = _
           New ArrayList
        With yetkiListesi
            .Add("Seçmen Ekleme")
            .Add("Seçmen Silme")
        End With

    End Sub

    Public Overrides _
    ReadOnly Property _
      YetkiDuzeyi() As Integer
        Get
            Return 5
        End Get
    End Property

    Public Overrides _
    Function YetkiSahibiMi(ByVal iþlem _
                          As String) As Boolean
        Return yetkiListesi.IndexOf(iþlem) >= 0
    End Function
End Class

Class Program

    Public Shared Sub Main(ByVal args() As String)
    End Sub
End Class