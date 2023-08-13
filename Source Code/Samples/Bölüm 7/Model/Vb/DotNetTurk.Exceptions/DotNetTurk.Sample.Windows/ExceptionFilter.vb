Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DotNetTurk.Exceptions
Namespace DotNetTurk.Sample.Windows
    Class ExceptionFilter
        Implements IExceptionFilter

        Public Function Filter(ByVal exc As Exception) As Boolean Implements IExceptionFilter.Filter
            If TypeOf (exc) Is ApplicationSecurityException Then
                Return True
            ElseIf TypeOf (exc) Is UserException Then
                Return False
            ElseIf TypeOf (exc) Is TechnicalException Then
                Return True
            Else
                Return True
            End If
        End Function
    End Class
End Namespace
