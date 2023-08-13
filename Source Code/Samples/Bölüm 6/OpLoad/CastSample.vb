Imports System.Globalization
Imports System.Threading
Imports System.Text
Imports System.Collections
Imports System
Imports System.IO



Class Daire

    Private r As Integer

    Public Overrides Function Equals(ByVal o As Object) As Boolean
        If TypeOf (o) Is Daire Then
            Dim obj As Daire = CType(o, Daire)
            Return obj.r = Me.r
        End If
        Return False
    End Function

    Public Sub New(ByVal r As Integer)
        Me.r = r
    End Sub

    Public Shared Operator +(ByVal d1 As Daire, ByVal d2 As Daire) As Daire
        Return New Daire(d1.r + d2.r)
    End Operator

    Public Shared Operator =(ByVal d1 As Daire, ByVal d2 As Daire) As Boolean
        Return d1.r = d2.r
    End Operator

    Public Shared Operator <>(ByVal d1 As Daire, ByVal d2 As Daire) As Boolean
        Return d1.r <> d2.r
    End Operator

    Public Shared Operator <(ByVal d1 As Daire, ByVal d2 As Daire) As Boolean
        Return d1.r < d2.r
    End Operator

    Public Shared Operator >(ByVal d1 As Daire, ByVal d2 As Daire) As Boolean
        Return d1.r > d2.r
    End Operator



End Class

Class Elips

    Private r1 As Integer

    Private r2 As Integer

    Public Sub New(ByVal r1 As Integer, ByVal r2 As Integer)
        Me.r1 = r1
        Me.r2 = r2
    End Sub

    Public Shared Narrowing Operator CType(ByVal e As Elips) As Daire
        Return New Daire(System.Math.Min(e.r1, e.r2))
    End Operator

End Class




Class Program

    Shared Sub Main(ByVal args() As String)
        Dim d1 As Daire = New Daire(4)
        Dim d2 As Daire = New Daire(3)
        Dim d3 As Daire = (d1 + d2)
        Dim d4 As Daire = New Daire(4)
        Dim d5 As Daire = d2
        Console.WriteLine("d4 EÞÝT d1: {0}", d4 = d1)
        Console.WriteLine("d5 EÞÝT d2: {0}", d5 = d2)
        Console.WriteLine("d3 EÞÝT d1 + d2: {0}", d3 = d1 + d2)
        Console.WriteLine("d4 REF EÞÝT d1: {0}", d4.Equals(d1))
        Console.WriteLine("d5 REF EÞÝT d2: {0}", d5.Equals(d2))
        Console.WriteLine("d2 BÜYÜK d1: {0}", d2 > d1)
        Console.WriteLine("d3 KÜÇÜK d1: {0}", d3 < d1)
        Console.ReadLine()


        Console.ReadLine()
    End Sub
End Class