Imports System.Reflection
Imports System.Resources
Imports System.Globalization


Public Class Form1

    Private Sub ctlResXCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctlResXCreate.Click
        Using writer As ResXResourceWriter = _
        New ResXResourceWriter("c:\kaynaklar.resx")
            writer.AddResource("IleriBtn", "Ýleri")
            Dim img As Image = Image.FromFile("c:\ornek.jpg")
            writer.AddResource("Resim", img)
            writer.Generate()
            writer.Close()
        End Using

    End Sub

    Private Sub ctlReadResX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctlReadResX.Click
        If (ctlFileOpen.ShowDialog() = DialogResult.OK) Then
            Using reader As ResXResourceReader = New ResXResourceReader(ctlFileOpen.FileName)
                For Each entry As DictionaryEntry In reader
                    MessageBox.Show(String.Format("{0}-{1}", entry.Key, entry.Value))
                Next
                reader.Close()
            End Using
        End If

    End Sub

    Private Sub ctlResourceCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctlResourceCreate.Click
        Using writer As ResourceWriter = _
        New ResourceWriter("c:\kaynaklar.resx")
            writer.AddResource("IleriBtn", "Ýleri")
            Dim img As Image = Image.FromFile("c:\ornek.jpg")
            writer.AddResource("Resim", img)
            writer.Generate()
            writer.Close()
        End Using
    End Sub

    Private Sub ctlResourceRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctlResourceRead.Click
        Dim r As ResourceManager
        r = New ResourceManager("kaynaklar", [Assembly].GetExecutingAssembly())
        r.GetString("IleriBtn", New CultureInfo("de-DE"))
        Dim img As Image

        img = CType(r.GetObject("Resim"), Bitmap)


        If (ctlFileOpen.ShowDialog() = DialogResult.OK) Then
            Using reader As ResourceReader = New ResourceReader(ctlFileOpen.FileName)
                For Each entry As DictionaryEntry In reader
                    MessageBox.Show(String.Format("{0}-{1}", entry.Key, entry.Value))
                Next
                reader.Close()
            End Using
        End If
    End Sub
End Class
