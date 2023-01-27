Public Class Iteratie
    Dim nummer As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myForm As New Form1
        myForm.Show()
        Me.Close()

    End Sub

    Private Sub Iteratie_load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Dim numberString As String = ""
        Dim som As Integer = 0
        For number As Integer = 1 To 10
            numberString += " " & number
            som += number
        Next

        MsgBox(numberString & Environment.NewLine & som)

    End Sub

    Private Sub oefening2()
        Dim waarde As Double = 0
        Dim posWaarde As Double = 0
        Dim posCount As Integer = 0
        Dim negWaarde As Double = 0
        Dim negCount As Integer = 0
        Dim nulCount As Integer = 0
        Dim posGem As Double = 0
        Dim negGem As Double = 0


        Do Until waarde = 99
            waarde = InputBox("geef een waarde")

            If waarde > 0 Then
                posCount += 1
                posWaarde += waarde
            ElseIf (waarde < 0) Then
                negCount += 1
                negWaarde += waarde
            Else
                nulCount += 1
            End If

        Loop

        posGem = posWaarde / posCount
        negGem = negWaarde / negCount



    End Sub

    Private Sub oefening3()

        Dim wis = -1
        Dim boek = -1
        Dim inf = -1

        Do While wis < 0 Or wis > 20
            wis = InputBox("geef nieuwe waarde voor wiskunde")
            MsgBox(wis)
        Loop
        Do While boek < 0 Or boek > 20
            boek = InputBox("geef nieuwe waarde voor boek")
            MsgBox(boek)
        Loop

        Do While inf < 0 Or inf > 20
            inf = InputBox("geef nieuwe waarde voor inf")
            MsgBox(inf)
        Loop



    End Sub

    Private Sub oefening4()

    End Sub

    Private Sub oefening5()

    End Sub

    Private Sub oefening6()

    End Sub

    Private Sub oefening7()

    End Sub

    Private Sub oefening8()

    End Sub

    Private Sub oefening9()

    End Sub

    Private Sub oefening10()

    End Sub

    Private Sub oefening11()

    End Sub

    Private Sub oefening12()

    End Sub

    Private Sub oefening13()

    End Sub

    Private Sub oefening14()

    End Sub

    Private Sub oefening15()

    End Sub
End Class