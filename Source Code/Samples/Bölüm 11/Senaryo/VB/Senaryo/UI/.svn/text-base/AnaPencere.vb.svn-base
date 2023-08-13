Imports Model
Public Class AnaPencere

    Private Sub btnMüþteriEkle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMüþteriEkle.Click
        Try
            ÝþlemYöneticisi.ÝþlemYap("MüþteriEkle", New Müþteri(Long.Parse(ctlMüþteriTcNo.Text), ctlMüþteriAd.Text, ctlMüþteriSoyad.Text))
            MessageBox.Show("Müþteri eklendi")
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try

    End Sub

    Private Sub btnMüþteriSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMüþteriSil.Click
        Try
            ÝþlemYöneticisi.ÝþlemYap("MüþteriSil", Long.Parse(ctlMüþteriTcNo.Text))
            MessageBox.Show("Müþteri silindi")
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try
    End Sub

    Private Sub ctlTümMüþteriListesi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctlTümMüþteriListesi.Click
        Try
            ctlMüþteriGv.DataSource = ÝþlemYöneticisi.ÝþlemYap("MüþteriListele")
            MessageBox.Show("Müþteri listeleme yapýldý")
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try
    End Sub

    Private Sub btnMüþteriAra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMüþteriAra.Click
        Try
            ctlMüþteriGv.DataSource = ÝþlemYöneticisi.ÝþlemYap("MüþteriAra", ctlMüþteriAra.Text)
            MessageBox.Show("Müþteri sorgusu yapýldý")
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try

    End Sub
End Class
