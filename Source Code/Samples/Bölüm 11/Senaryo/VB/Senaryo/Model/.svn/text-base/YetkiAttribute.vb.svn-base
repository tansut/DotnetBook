Imports System
Imports System.Collections.Generic
Imports System.Text


<AttributeUsage(AttributeTargets.Method)> _
Public NotInheritable Class YetkiAttribute
    Inherits Attribute

    Private _operasyon As String

    Public Sub New(ByVal yetki As String)
        _operasyon = yetki
    End Sub

    Public ReadOnly Property Operasyon() As String
        Get
            Return _operasyon
        End Get
    End Property
End Class
