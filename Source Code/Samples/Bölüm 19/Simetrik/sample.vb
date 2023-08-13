Imports System.Threading
Imports System.Text
Imports System.Diagnostics
Imports System.Security.Cryptography
Imports System.IO


Class Program
    Private Const IV As String = "0123456789ABCDRE"
    Shared Sub Sifrele(ByVal anahtar() As Byte)
        Using f As FileStream = New FileStream("c:\x.dat", FileMode.Open)
            Dim aes As RijndaelManaged = New RijndaelManaged()
            aes.Key = anahtar
            aes.IV = Encoding.ASCII.GetBytes(IV)

            Dim t As ICryptoTransform = aes.CreateEncryptor()

            Dim duzMetin(1023) As Byte

            Using hedef As FileStream = New FileStream("c:\x.sif", FileMode.Create)

                Using cs As CryptoStream = New CryptoStream(hedef, t, CryptoStreamMode.Write)

                    Dim okunan As Integer = f.Read(duzMetin, 0, duzMetin.Length)
                    While okunan > 0
                        cs.Write(duzMetin, 0, okunan)
                        okunan = f.Read(duzMetin, 0, duzMetin.Length)
                    End While
                    cs.Close()
                End Using
                hedef.Close()
            End Using
            f.Close()
        End Using
    End Sub

    Shared Sub Coz(ByVal anahtar() As Byte)
        Using f As FileStream = New FileStream("c:\x.sif", FileMode.Open)

            Dim aes As RijndaelManaged = New RijndaelManaged()
            aes.Key = anahtar
            aes.IV = Encoding.ASCII.GetBytes(IV)

            Dim t As ICryptoTransform = aes.CreateDecryptor()

            Dim düzMetin(1023) As Byte

            Using hedef As FileStream = New FileStream("c:\x.dat", FileMode.Create)

                Using cs As CryptoStream = New CryptoStream(f, t, CryptoStreamMode.Read)

                    Dim okunan As Integer = cs.Read(düzMetin, 0, düzMetin.Length)
                    While okunan > 0
                        hedef.Write(düzMetin, 0, okunan)
                        okunan = cs.Read(düzMetin, 0, düzMetin.Length)
                    End While
                    cs.Close()
                End Using
                hedef.Close()
            End Using
            f.Close()
        End Using
    End Sub

    Public Shared Sub Main()
        Console.WriteLine("Þifre giriniz:")
        Dim sifre As String = Console.ReadLine()
        Dim salt() As Byte = Encoding.ASCII.GetBytes(sifre)

        Dim rfc As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(sifre, salt)

        Dim anahtar() As Byte = rfc.GetBytes(32)

        Console.WriteLine("Þifreleniyor ...")
        Sifrele(anahtar)

        Console.WriteLine("Çözülüyor ...")
        Coz(anahtar)



        Console.ReadLine()

    End Sub





End Class

