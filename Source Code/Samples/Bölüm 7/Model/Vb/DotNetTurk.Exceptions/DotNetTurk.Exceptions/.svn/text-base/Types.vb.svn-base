Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Configuration
Namespace DotNetTurk.Exceptions



    <System.Serializable()> _
    Public Class UserException
        Inherits ApplicationException

        Public Sub New()

        End Sub

        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub

        Public Sub New(ByVal message As String, ByVal inner As Exception)
            MyBase.New(message, inner)
        End Sub

        Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
        End Sub
    End Class

    <System.Serializable()> _
    Public Class TechnicalException
        Inherits ApplicationException

        Public Sub New()

        End Sub

        Public Sub New(ByVal message As String)
            MyBase.New(message)

        End Sub

        Public Sub New(ByVal message As String, ByVal inner As Exception)
            MyBase.New(message, inner)

        End Sub

        Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)

        End Sub
    End Class

    <System.Serializable()> _
    Public Class ApplicationSecurityException
        Inherits UserException

        Public Sub New()

        End Sub

        Public Sub New(ByVal message As String)
            MyBase.New(message)

        End Sub

        Public Sub New(ByVal message As String, ByVal inner As Exception)
            MyBase.New(message, inner)

        End Sub

        Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)

        End Sub
    End Class

    Public Interface IExceptionPublisher

        Sub Publish(ByVal exc As Exception)
    End Interface

    Public Interface IExceptionFilter

        Function Filter(ByVal exc As Exception) As Boolean
    End Interface

    Public NotInheritable Class ExceptionManager

        Private Shared publisher As IExceptionPublisher

        Private Shared filter As IExceptionFilter

        Shared Sub New()
            Dim type As Type = type.GetType(ConfigurationManager.AppSettings("ExceptionPublisher"), True)
            publisher = CType(Activator.CreateInstance(type), IExceptionPublisher)
            type = type.GetType(ConfigurationManager.AppSettings("ExceptionFilter"), True)
            filter = CType(Activator.CreateInstance(type), IExceptionFilter)
        End Sub

        Private Sub New()
            MyBase.New()

        End Sub

        Public Shared Sub Publish(ByVal exc As Exception)
            If filter.Filter(exc) Then
                publisher.Publish(exc)
            End If
        End Sub

        Public Shared Function Convert(ByVal exc As Exception) As ApplicationException
            If TypeOf (exc) Is UserException Then
                Return CType(exc, UserException)
            ElseIf TypeOf (exc) Is TechnicalException Then
                Return CType(exc, TechnicalException)
            Else
                Return New TechnicalException("Sistemde teknik hata oluþtu.", exc)
            End If
        End Function
    End Class
End Namespace
