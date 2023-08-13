Imports System.Globalization
Imports System.Threading
Imports System.Text
Imports System.Collections.Generic
Imports System
Imports System.IO

Public Class RandomList
    Public Function Uret() _
      As String()
        Dim list As _
           ArrayList = New ArrayList
        Dim r _
           As Random = New Random
        Dim max _
          As Integer = r.Next(1000)
        For i As Integer = 0 To max - 1
            list.Add(r.Next.ToString)
        Next
        Return _
          CType(list.ToArray(GetType(System.String)), String())
    End Function
End Class

Class Program

    Shared Sub Main(ByVal args() As String)
        Dim l As RandomList = _
           New RandomList()
        Dim sl() _
          As String = l.Uret()
        For Each s As String In sl
            Console.Write("{0} ", s)
        Next
        Console.ReadLine()
    End Sub
End Class





