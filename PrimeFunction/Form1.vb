Public Class Form1

    Private Sub btnFactor_Click(sender As Object, e As EventArgs) Handles btnFactor.Click

        Dim lngNumber As Long
        Dim lngFactor As Long = 3
        Dim lngHighest As Long

        lngNumber = CLng(txtNumber.Text)

        lstFactors.Items.Clear()

        Do While (lngNumber Mod 2 = 0)

            lstFactors.Items.Add(2)
            lngNumber \= 2

        Loop

        Do While (lngFactor * lngFactor <= lngNumber)

            If (lngNumber Mod lngFactor = 0) Then

                lstFactors.Items.Add(lngFactor)
                lngNumber \= lngFactor

            Else

                lngFactor += 2

            End If

        Loop

        If (lngNumber > 1) Then lstFactors.Items.Add(lngNumber)

        lngHighest = lstFactors.Items.Count - 1

        lblHighest.Text = lstFactors.Items(lngHighest)

        lblIntro.Text = "and the highest prime" & ControlChars.CrLf & "factor of" & ControlChars.CrLf & txtNumber.Text.ToString & ControlChars.CrLf & "is:"

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub
End Class
