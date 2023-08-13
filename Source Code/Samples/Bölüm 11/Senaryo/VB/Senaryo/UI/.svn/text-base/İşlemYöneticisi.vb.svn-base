Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Model
Imports System.Reflection


NotInheritable Class İşlemYöneticisi

    Private Sub New()

    End Sub

    Private Shared Function YetkisiVarMı(ByVal operasyonAd As String) As Boolean
        Return True
    End Function

    Private Shared Sub YetkiKontrol(ByVal m As MemberInfo)
        Dim attrList() As Object
        attrList = m.GetCustomAttributes(False)
        Dim yetki As YetkiAttribute = Nothing
        For Each o As Object In attrList
            If (TypeOf (o) Is YetkiAttribute) Then
                yetki = CType(o, YetkiAttribute)
                If Not YetkisiVarMı(yetki.Operasyon) Then
                    Throw New ApplicationException(String.Format("{0} yetkiniz bulunmamaktadır", yetki.Operasyon))
                End If
            End If
        Next
        If (yetki Is Nothing) Then
            Throw New ApplicationException("Metot yetki tanımı yapılmamıştır")
        End If
    End Sub

    Public Shared Function İşlemYap(ByVal operasyonKodu As String, ByVal ParamArray parametreler() As Object) As Object
        Dim op As Operasyon
        op = OperasyonListesi.Liste(operasyonKodu)
        Dim a As Assembly
        a = Assembly.Load(op.Assembly)
        Dim işSınıfı As Type
        işSınıfı = a.GetType(op.Sınıf, True)
        Dim işMetodu As MethodInfo
        işMetodu = işSınıfı.GetMethod(op.Metot)
        YetkiKontrol(işMetodu)
        Dim işNesnesi As Object
        işNesnesi = Activator.CreateInstance(işSınıfı)
        Try
            Return işMetodu.Invoke(işNesnesi, parametreler)
        Catch exc As TargetInvocationException
            Throw exc.InnerException
        End Try
    End Function
End Class
