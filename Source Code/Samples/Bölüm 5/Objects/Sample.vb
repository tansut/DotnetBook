Imports System.Globalization
Imports System.Threading
Imports System.Text
Imports System.Collections
Imports System
Imports System.IO



Class Test

    Public Shared Sub A(ByRef o _
                       As Object)
        o = 12
    End Sub

    Public Shared Sub B(ByRef o _
                       As Object)
        o = New StringBuilder
    End Sub

    Public Shared Sub C(ByVal o _
                       As Object)
        o = 12
    End Sub

    Public Shared Sub D(ByVal o _
                       As Object)
        If TypeOf (o) Is _
          StringBuilder Then
            CType(o, StringBuilder).Append("Test String" + vbTab)
        End If
    End Sub

    Public Shared Sub E(ByRef o As Object)
        If TypeOf (o) Is StringBuilder Then
            CType(o, StringBuilder).Append("Test String" + vbTab)
        End If
    End Sub
End Class
Class Program

    Shared Sub Bilgi(ByVal o As Object)
        Console.WriteLine("{0}" + vbTab + "{1}", o.GetType.Name, o.ToString)
    End Sub

    Shared Sub Main(ByVal args() As String)
        Dim o As Object
        Test.A(o)
        Bilgi(o)
        Test.B(o)
        Bilgi(o)
        Test.C(o)
        Bilgi(o)
        Test.D(o)
        Bilgi(o)
        Test.E(o)
        Bilgi(o)
        Console.ReadLine()
    End Sub
End Class





