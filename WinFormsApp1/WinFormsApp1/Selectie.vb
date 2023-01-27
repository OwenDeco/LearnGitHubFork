Public Class Selectie
    Dim nummer As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myForm As New Form1
        myForm.Show()
        Me.Close()
    End Sub

    Private Sub Selectie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        nummer = InputBox("welke oefening testen wij?")
        selectOef(nummer)

    End Sub

    Private Sub selectOef(nummer)
        Select Case nummer
            Case 1
                oefening1()
            Case 2
                oefening2()
            Case 3
                oefening3()
            Case 4
                oefening4()
            Case 5
                oefening5()
            Case 6
                oefening6()
            Case 7
                oefening7()
            Case 8
                oefening8()
            Case 9
                oefening9()
            Case 10
                oefening10()
            Case 11
                oefening11()
            Case 12
                oefening12()
            Case 13
                oefening13()
            Case 14
                oefening14()
            Case 15
                oefening15()

        End Select
    End Sub


    Private Sub oefening1()
        Dim tempkelvin As Double = InputBox("geef temperatuur mee in Kelvin")

        If (tempkelvin >= 0) Then
            Dim tempCel As Double = tempkelvin - 273.15
            MsgBox(Math.Round(tempCel, 2) & " Graden")
        Else
            MsgBox("De temperatuur in Kelvin moet positief zijn")
        End If
    End Sub

    Private Sub oefening2()

        Dim bedrag As Double = InputBox("geef een bedrag in")
        Dim korting As Double = bedrag - (bedrag / 100 * 3)

        If (bedrag > 5000) Then
            MsgBox(korting)
        Else
            MsgBox(bedrag)
        End If

    End Sub

    Private Sub oefening3()

        Dim wis As Integer = InputBox("wiskunde cijfer")
        Dim boek As Integer = InputBox("boekhouden cijfer")
        Dim inf As Integer = InputBox("Informatica cijfer")

        If wis < 6 And (boek + inf < 12) Then
            MsgBox("niet geslaagd voor beiden")
        ElseIf wis < 6 Then
            MsgBox("niet geslaagd voor wis")
        ElseIf (boek + inf < 12) Then
            MsgBox("niet geslaagd voor boek/inf")
        Else
            MsgBox("gj geslaagd!")
        End If




    End Sub

    Private Sub oefening4()
        Dim getal1 As Integer = InputBox("getal 1")
        Dim getal2 As Integer = InputBox("getal 2")

        If (getal1 > getal2) Then
            MsgBox(getal1 / getal2)
        Else
            MsgBox(getal2 / getal1)
        End If
    End Sub

    Private Sub oefening5()
        Dim getal1 = InputBox("getal 1")
        Dim getal2 = InputBox("getal 2")
        Dim getal3 = InputBox("getal 3")

        If getal1 < getal2 Then
            If getal1 < getal3 Then
                If getal2 < getal3 Then
                    MsgBox(getal3 & " " & getal2 & " " & getal1)
                Else
                    MsgBox(getal2 & " " & getal3 & " " & getal1)
                End If
            Else
                If getal1 < getal2 Then
                    MsgBox(getal2 & " " & getal1 & "" & getal3)
                Else
                    MsgBox(getal1 & " " & getal2 & "" & getal3)
                End If

            End If
        Else
            If getal1 < getal3 Then
                MsgBox(getal3 & " " & getal1 & " " & getal2)
            Else
                MsgBox(getal1 & " " & getal3 & " " & getal2)
            End If
        End If
    End Sub

    Private Sub oefening6()
        Dim aantalKinderen As Integer = InputBox("geef aantal kinderen")
        Dim maandloon As Integer = InputBox("geef salaris")
        Dim bedrag As Double

        If (aantalKinderen >= 5) Then
            bedrag = 125 + (aantalKinderen - 4) * 45
        ElseIf (aantalKinderen >= 3) Then
            bedrag = 50 + (aantalKinderen - 2) * 37.5
        Else
            bedrag = aantalKinderen * 25
        End If

        If (maandloon <= 500) Then
            bedrag *= 1.25
        ElseIf (maandloon > 2000) Then
            bedrag *= 0.75
        End If

        If (bedrag / aantalKinderen < 25) Then
            bedrag = 25 * aantalKinderen
        End If

        MsgBox(Math.Round(bedrag, 2))

    End Sub

    Private Sub oefening7()
        Dim jaartal As Integer = InputBox("geef jaartal")
        If (jaartal Mod 4 = 0) And (jaartal Mod 100 <> 0) Then

            MsgBox("schrikkeljaar check!")

        ElseIf (jaartal Mod 400 = 0) Then
            MsgBox("schrikkeljaar check!")
        Else
            MsgBox("geen schrikkeljaar :(")
        End If


    End Sub

    Private Sub oefening8()

    End Sub

    Private Sub oefening9()

    End Sub

    Private Sub oefening10()

    End Sub

    Private Sub oefening11()
        Dim getal As Integer = 0
        Dim totalOneven As Integer = 0
        For i As Integer = 1 To 5 Step 1
            getal = InputBox("geef waarde " & i & " in")
            If getal Mod 2 <> 0 Then
                totalOneven += getal
            End If
        Next

        MsgBox(totalOneven)


    End Sub

    Private Sub oefening12()
        Dim getal1 As Integer = InputBox("getal1")
        Dim getal2 As Integer = InputBox("getal2")

        If getal1 Mod getal2 = 0 Then
            MsgBox("getal1 is een meervoud van getal2")
        ElseIf getal2 Mod getal1 = 0 Then
            MsgBox("getal 2 is een meervoud van getal 1")
        Else
            MsgBox("geen meervouden")

        End If

    End Sub

    Private Sub oefening13()

    End Sub

    Private Sub oefening14()

    End Sub

    Private Sub oefening15()

    End Sub
End Class