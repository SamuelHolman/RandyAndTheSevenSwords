Public Class MainMenu

    Public Name As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If txtName.Text = "" Then
            MessageBox.Show("Enter a name, please")
        Else
            Name = txtName.Text
        End If


        StartingArea.Show()

    End Sub
End Class
