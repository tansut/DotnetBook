Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Threading
Imports System.Globalization

Namespace DotNetKitabý.Strings
    Class Program
        Shared Sub Main(ByVal args() As String)
            Dim s1 As String = "i"
            Dim s2 As String = "Ý"
            Dim s3 As String = "I"
            Dim s4 As String = "ý"

            Console.WriteLine("Aktif Kültür: {0}", _
                Thread.CurrentThread.CurrentCulture.DisplayName)

            Dim b1 As Boolean = String.Compare(s1, s2) = 0
            Dim b2 As Boolean = String.Compare(s1, s2, True) = 0
            Dim b3 As Boolean = String.Compare(s1, s3) = 0
            Dim b4 As Boolean = String.Compare(s1, s2, StringComparison.InvariantCultureIgnoreCase) = 0
            Dim b5 As Boolean = String.Compare(s1, s3, StringComparison.InvariantCultureIgnoreCase) = 0
            Dim b6 As Boolean = String.Compare(s1, s2, True, CultureInfo.InvariantCulture) = 0
            Dim b7 As Boolean = String.Compare(s4, s3, True) = 0
            Dim b8 As Boolean = String.Compare(s4, s3, True, CultureInfo.InvariantCulture) = 0
            Dim b9 As Boolean = String.Compare(s1, s2, StringComparison.CurrentCultureIgnoreCase) = 0

            Console.WriteLine("B1: {0}", b1)
            Console.WriteLine("B2: {0}", b2)
            Console.WriteLine("B3: {0}", b3)
            Console.WriteLine("B4: {0}", b4)
            Console.WriteLine("B5: {0}", b5)
            Console.WriteLine("B6: {0}", b6)
            Console.WriteLine("B7: {0}", b7)
            Console.WriteLine("B8: {0}", b8)
            Console.WriteLine("B9: {0}", b9)

            Dim s As String = "Ali"
            If s.ToLowerInvariant() = "ali" Then
                Console.WriteLine("OK")
            End If
            If String.Compare(s, "ALI", StringComparison.InvariantCultureIgnoreCase) = 0 Then
                Console.WriteLine("OK")
            End If

            Console.ReadLine()
        End Sub
    End Class
End Namespace