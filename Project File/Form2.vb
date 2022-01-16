Public Class Form2

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'Cheking for House Number
        If TxtHNum1.Text = "" Then
            MessageBox.Show("You Can't Blank House Number")
            Exit Sub
        End If

        'Cheking for Street Name
        If TxtSNam2.Text = "" Then
            MessageBox.Show("You Can't Blank Street Name")
            Exit Sub
        End If

        'Cheking for Town/City Name
        If TxtTwn3.Text = "" Then
            MessageBox.Show("You Can't Blank Town/City Name")
            Exit Sub
        End If

        'Cheking for Post Code
        If TxtPCod4.Text = "" Then
            MessageBox.Show("You Can't Blank Post Code")
            Exit Sub
        End If

        Dim Spacefound As Boolean
        Spacefound = Spacecheck(TxtPCod4.Text)
        If Spacefound Then
            MessageBox.Show("Post Code No. Can't Contain Any Space")
            Exit Sub
        End If

        Dim p As String
        p = TxtPCod4.Text
        For k = 0 To p.Length - 1
            Dim Charnum As String
            Charnum = p.Substring(k, 1)
            If Not IsNumeric(Charnum) Then
                MessageBox.Show("Post Code No. Can't Contain any Character")
                Exit Sub
            End If
        Next

        'Cheking for Card Number
        If TxtCrd5.Text = "" Then
            MessageBox.Show("You Can't Blank Card Number")
            Exit Sub
        End If

        If TxtCrd5.TextLength < 16 Then
            MessageBox.Show("You Can't Use Less Than 16 Digit In Card Number")
            Exit Sub
        End If

        If TxtCrd5.TextLength > 16 Then
            MessageBox.Show("You Can't Use More than 16 Digit In Card Number")
            Exit Sub
        End If

        'Cheking for Space Found, Char Check etc.
        Spacefound = Spacecheck(TxtCrd5.Text)

        If Spacefound Then
            MessageBox.Show("Space Not allowed In Card Number")
            Exit Sub
        End If

        Dim z As String
        z = TxtCrd5.Text
        For D = 0 To z.Length - 1
            Dim Charnu As String
            Charnu = z.Substring(D, 1)
            If Not IsNumeric(Charnu) Then
                MessageBox.Show("Card No Can't Contain Any Character")
                Exit Sub
            End If
        Next
        MessageBox.Show("Your Purchased Has Been Processed Successfully")
        TxtHNum1.Text = String.Empty
        TxtSNam2.Text = String.Empty
        TxtTwn3.Text = String.Empty
        TxtPCod4.Text = String.Empty
        TxtCrd5.Text = String.Empty
        Exit Sub
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Thanks For Visit")
        Application.Exit()
    End Sub
End Class