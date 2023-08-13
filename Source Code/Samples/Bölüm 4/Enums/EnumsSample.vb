Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace DotNetKitabý.Enums
    <Flags()> _
    Public Enum Hak

        Okuma = 1

        Yazma = 2

        Silme = 4

        Tümü = Okuma Or Yazma Or Silme
    End Enum

    Class Program

        Private Shared Sub hakYazdýr(ByVal hak As Hak)
            If ((hak And hak.Tümü) = hak.Tümü) Then
                Console.WriteLine("Tüm haklar mevcut")
            Else
                If ((hak And hak.Okuma) = hak.Okuma) Then
                    Console.WriteLine("Okuma hakký mevcut")
                End If
                If ((hak And hak.Yazma) = hak.Yazma) Then
                    Console.WriteLine("Yazma hakký mevcut")
                End If
                If ((hak And hak.Silme) = hak.Silme) Then
                    Console.WriteLine("Silme hakký mevcut")
                End If
            End If
        End Sub

        Shared Sub Main(ByVal args() As String)
            Dim hak1 As Hak = 0
            Console.WriteLine("Hak1:")
            hakYazdýr(hak1)
            Dim hak2 As Hak = (Hak.Okuma Or Hak.Silme)
            Console.WriteLine("Hak2:")
            hakYazdýr(hak2)
            Dim hak3 As Hak = Hak.Tümü
            Console.WriteLine("Hak3:")
            hakYazdýr(hak3)
            Dim hak4 As Hak = Hak.Tümü And Not Hak.Okuma
            Console.WriteLine("Hak4:")
            hakYazdýr(hak4)
            Dim hak5 As Hak = Hak.Okuma Or Hak.Silme Or Hak.Yazma
            Console.WriteLine("Hak5:")
            hakYazdýr(hak5)
            Console.ReadLine()
        End Sub
    End Class
End Namespace