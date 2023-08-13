Imports System.Globalization
Imports System.Threading
Imports System.Text
Imports System.Collections
Imports System
Imports System.IO

MustInherit Class TemelKullanıcı
    Private _ad As String

    Protected Sub New(ByVal ad As String)
        Me._ad = ad
        Console.WriteLine("TemelKullanıcı Oluşturuldu")
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

MustInherit Class YetkiliKullanıcı
    Inherits TemelKullanıcı

    Protected Sub New(ByVal ad As String)
        MyBase.New(ad)
        Console.WriteLine("YetkiliKullanıcı oluşturuldu")
    End Sub



    Public MustOverride _
    ReadOnly Property _
     YetkiDuzeyi() As Integer

    Public MustOverride _
    Function _
     YetkiSahibiMi(ByVal işlem _
     As String) As Boolean

End Class

Class YöneticiKullanıcı
    Inherits YetkiliKullanıcı

    Public Sub New(ByVal ad As String)
        MyBase.New(ad)
        Console.WriteLine("YöneticiKullanıcı oluşturuldu")
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
    Function YetkiSahibiMi(ByVal işlem _
                          As String) As Boolean
        Return yetkiListesi.IndexOf(işlem) >= 0
    End Function
End Class

Class Program

    Public Shared Sub Main(ByVal args() As String)
    End Sub
End Class