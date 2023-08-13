Imports System.Threading
Imports System.Text
Imports System.Diagnostics

Enum TestTipi
    StringTest
    StringBuilderTest
End Enum

Class PerformansTest
    Private Const KategoriAd As String = "String Performans Testleri"
    Private Const OrtalamaIslemSayisiAd As String = "Ýþlem Sayýsý / sn"
    Private Const ToplamIslemSayisiAd As String = "Toplam iþlem Sayýsý"
    Private Const OrtalamaIslemSuresiAd As String = "Ortalama Ýþlem Süresi"
    Private Const OrtalamaIslemSuresiTemelAd As String = "Ortalama Ýþlem Süresi Temel Sayacý"

    Private ortalamaIslemSayisiSayaci As PerformanceCounter
    Private toplamIslemSayisiSayaci As PerformanceCounter
    Private ortalamaIslemSuresiSayaci As PerformanceCounter
    Private ortalamaIslemSuresiTemelSayaci As PerformanceCounter

    Private tip As TestTipi

    Shared Sub New()
        If Not PerformanceCounterCategory.Exists(KategoriAd) Then
            Olustur()
        End If
    End Sub

    Public Sub New(ByVal tip As TestTipi)
        Me.tip = tip
    End Sub

    Private Shared Sub Olustur()
        If PerformanceCounterCategory.Exists(KategoriAd) Then
            PerformanceCounterCategory.Delete(KategoriAd)
        End If
        Dim pc1 As CounterCreationData = New CounterCreationData(OrtalamaIslemSayisiAd, "", PerformanceCounterType.RateOfCountsPerSecond32)
        Dim pc2 As CounterCreationData = New CounterCreationData(ToplamIslemSayisiAd, "", PerformanceCounterType.NumberOfItems32)
        Dim pc3 As CounterCreationData = New CounterCreationData(OrtalamaIslemSuresiAd, "", PerformanceCounterType.AverageTimer32)
        Dim pc4 As CounterCreationData = New CounterCreationData(OrtalamaIslemSuresiTemelAd, "", PerformanceCounterType.AverageBase)
        Dim coll As CounterCreationDataCollection = New CounterCreationDataCollection
        coll.Add(pc1)
        coll.Add(pc2)
        coll.Add(pc3)
        coll.Add(pc4)
        PerformanceCounterCategory.Create(KategoriAd, "", PerformanceCounterCategoryType.MultiInstance, coll)
    End Sub

    Private Sub SayacNesneleriOlustur()
        ortalamaIslemSayisiSayaci = New PerformanceCounter(KategoriAd, OrtalamaIslemSayisiAd, Thread.CurrentThread.Name, False)
        toplamIslemSayisiSayaci = New PerformanceCounter(KategoriAd, ToplamIslemSayisiAd, Thread.CurrentThread.Name, False)
        ortalamaIslemSuresiSayaci = New PerformanceCounter(KategoriAd, OrtalamaIslemSuresiAd, Thread.CurrentThread.Name, False)
        ortalamaIslemSuresiTemelSayaci = New PerformanceCounter(KategoriAd, OrtalamaIslemSuresiTemelAd, Thread.CurrentThread.Name, False)
    End Sub

    Private Sub OrnekleriYokEt()
        ortalamaIslemSayisiSayaci.RemoveInstance()
        toplamIslemSayisiSayaci.RemoveInstance()
        ortalamaIslemSuresiSayaci.RemoveInstance()
        ortalamaIslemSuresiTemelSayaci.RemoveInstance()
    End Sub

    Private Sub Artir(ByVal tik As Long)
        ortalamaIslemSayisiSayaci.Increment()
        toplamIslemSayisiSayaci.Increment()
        ortalamaIslemSuresiSayaci.IncrementBy(tik)
        ortalamaIslemSuresiTemelSayaci.Increment()
    End Sub

    Public Sub Basla()
        SayacNesneleriOlustur()
        Dim sb As StringBuilder = New StringBuilder
        Dim sonuc As String = String.Empty
        Dim tikSayisi As Long
        For i As Integer = 1 To 300000

            tikSayisi = DateTime.Now.Ticks
            For j As Integer = 1 To 1000
                If (tip = TestTipi.StringBuilderTest) Then
                    sb.Append("01234")
                Else
                    sonuc = (sonuc + "01234")
                End If

            Next
            Artir((DateTime.Now.Ticks - tikSayisi))
        Next
        OrnekleriYokEt()
        Console.Write("{0} testi tamamlandý ...", Thread.CurrentThread.Name)
    End Sub
End Class

Class Program
    Public Shared Sub Main()
        Dim stringTest As PerformansTest = New PerformansTest(TestTipi.StringTest)
        Dim sbTest As PerformansTest = New PerformansTest(TestTipi.StringBuilderTest)
        Dim stringThread As Thread = New Thread(AddressOf stringTest.Basla)
        Dim sbThread As Thread = New Thread(AddressOf sbTest.Basla)
        stringThread.Name = "String"
        sbThread.Name = "StringBuilder"
        stringThread.Start()
        sbThread.Start()
        Console.WriteLine("Ýþlemin tamamlanmasý bekleniyor ...")
        stringThread.Join()
        sbThread.Join()
        Console.ReadLine()
    End Sub
End Class