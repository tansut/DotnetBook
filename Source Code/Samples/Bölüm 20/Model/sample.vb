   Public NotInheritable Class ProjeIdentity
        Implements IIdentity

        Private _kullaniciAdi As String

        Private _ePostaAdresi As String

        Friend Sub New(ByVal kullanici As String, ByVal ePosta As String)

            Me._kullaniciAdi = kullanici
            Me._ePostaAdresi = ePosta
        End Sub

        Public ReadOnly Property AuthenticationType() As String Implements IIdentity.AuthenticationType
            Get
                Return "Proje Kimlik Dogrulama Yöntemi"
            End Get
        End Property

        Public ReadOnly Property IsAuthenticated() As Boolean Implements IIdentity.IsAuthenticated
            Get
                Return True
            End Get
        End Property

        Public ReadOnly Property Name() As String Implements IIdentity.Name
            Get
                Return _kullaniciAdi
            End Get
        End Property

        Public ReadOnly Property EPostaAdresi() As String
            Get
                Return _ePostaAdresi
            End Get
        End Property
    End Class
    Public NotInheritable Class ProjePrincipal
        Implements IPrincipal

        Private _identity As ProjeIdentity

        Private _roller As List(Of String)

        Friend Sub New(ByVal identity As ProjeIdentity, ByVal roller() As String)
            MyBase.New()
            Me._identity = identity
            Me._roller = New List(Of String)(roller)
        End Sub

        Public ReadOnly Property Identity() As IIdentity Implements IPrincipal.Identity
            Get
                Return Identity
            End Get
        End Property

        Public Function IsInRole(ByVal role As String) As Boolean Implements IPrincipal.IsInRole
            Return _roller.IndexOf(role) >= 0
        End Function
    End Class

    Public NotInheritable Class KimlikYoneticisi

        Public Shared ReadOnly Property Principal() As ProjePrincipal
            Get
                Return CType(Thread.CurrentPrincipal, ProjePrincipal)
            End Get
        End Property

        Public Shared ReadOnly Property Identity() As ProjeIdentity
            Get
                Return CType(Principal.Identity, ProjeIdentity)
            End Get
        End Property

        Public Shared Sub Dogrula(ByVal kullaniciAd As String, ByVal sifre As String)
            Dim identity As ProjeIdentity = New ProjeIdentity(kullaniciAd, "xxx@xxx.com")
            Dim roller() As String = New String() {"Yönetici"}
            Dim principal As IPrincipal = New ProjePrincipal(identity, roller)
            Thread.CurrentPrincipal = principal
        End Sub

        Private Sub New()

        End Sub
    End Class