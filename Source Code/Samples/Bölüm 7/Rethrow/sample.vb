Imports System.Globalization
Imports System.Threading
Imports System.Text
Imports System.Collections
Imports System
Imports System.IO


Class Program

    Shared Sub Test()
        Throw New InvalidDataException("X")
    End Sub

    Shared Sub Test1()
        Try
            Test()
        Catch
            Throw
        End Try
    End Sub

    Shared Sub Test2()
        Try
            Test()
        Catch exc As Exception
            Throw
        End Try
    End Sub

    Shared Sub Test3()
        Try
            Test()
        Catch exc As Exception
            Throw exc
        End Try
    End Sub

    Shared Sub Main(ByVal args() As String)
        Try
            Test2()
        Catch exc As Exception
            Console.WriteLine(exc.StackTrace)
        End Try

        Console.WriteLine("-------------------------------------")

        Try
            Test3()
        Catch exc As Exception
            Console.WriteLine(exc.StackTrace)
        End Try
        Console.ReadLine()
    End Sub


End Class

