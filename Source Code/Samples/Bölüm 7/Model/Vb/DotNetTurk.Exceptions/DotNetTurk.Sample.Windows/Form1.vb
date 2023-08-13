Imports DotNetTurk.Exceptions
Public Class Form1
    Private Sub ManageException(ByVal exc As Exception)
        Dim appExc As ApplicationException = ExceptionManager.Convert(exc)
        ExceptionManager.Publish(appExc)
        MessageBox.Show(appExc.Message)
    End Sub

    Private Sub BtnUserException_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUserException.Click
        Try
            Throw New UserException("Örnek Kullanýcý Hatasý")
        Catch exc As Exception
            ManageException(exc)
        End Try
    End Sub

    Private Sub btnTechnicalException_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTechnicalException.Click

        Try
            Throw New TechnicalException("Örnek Teknik Hata")
        Catch exc As Exception
            ManageException(exc)
        End Try
    End Sub

    Private Sub btnOtherException_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtherException.Click

        Try
            Dim list As ArrayList = Nothing
            list.Add("")
        Catch exc As Exception
            ManageException(exc)
        End Try
    End Sub
End Class
