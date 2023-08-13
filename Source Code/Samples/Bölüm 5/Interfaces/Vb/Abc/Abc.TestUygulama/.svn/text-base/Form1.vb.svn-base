Imports System.IO
Imports Abc.Tipler
Public Class Form1
    Dim ortaklar As ArrayList = New ArrayList

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim r As StreamReader = _
          New StreamReader("Ortaklar.txt")

        While Not r.EndOfStream
            Dim line As String = r.ReadLine
            If line.StartsWith("#") Then
                Continue While
            End If
            Dim depo As IKitapDeposu = _
               CType(Activator.CreateInstance(Type.GetType(line)), _
                 IKitapDeposu)
            If (Not (depo) Is Nothing) Then
                ortaklar.Add(depo)
            End If
        End While
        For i As Integer = 0 To ortaklar.Count - 1
            ctlPartners.Items.Add(CType(ortaklar(i), IKitapDeposu).DepoAd)
        Next

    End Sub



    Private Sub ListeyeEkle(ByVal sonuclar() As Kitap)
        For Each sonuc As Kitap In sonuclar
            ctlResults.Items.Add(String.Format("{0}, {1}", sonuc.Ad, sonuc.Isbn))
        Next
    End Sub

    Private Sub ctlSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctlSearch.Click
        ctlResults.Items.Clear()
        For i As Integer = 0 To ortaklar.Count - 1
            Dim sonuc() As Kitap = CType(ortaklar(i), IKitapDeposu).AramaYap(ctlText.Text)
            If (Not (sonuc) Is Nothing) Then
                ListeyeEkle(sonuc)
            End If            
        Next

    End Sub
End Class
