Imports System.Globalization
Imports System.Threading
Imports System.Text
Imports System.Collections.Generic
Imports System
Imports System.IO


Class NesneFabrikasi

    Private Shared list _
      As ArrayList = New ArrayList

    Private Sub New()

    End Sub

    Public Shared ReadOnly _
      Property ToplamNesne() _
               As Integer
        Get
            Return list.Count
        End Get
    End Property

    Public Shared Function Uret() _
                           As Object
        Dim o As Object = New Object
        list.Add(o)
        Return o
    End Function
End Class

Class Program
    Shared Sub Main(ByVal args() As String)
        For i As Integer = 0 To 4
            Dim o As Object = _
                  NesneFabrikasi.Uret
            i = (i + 1)
        Next
        Console.WriteLine(NesneFabrikasi.ToplamNesne.ToString)
    End Sub
End Class




