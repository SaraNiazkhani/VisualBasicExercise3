Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Exercise3
    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click

        Dim num As Integer
        num = Val(NumTextBox.Text)

        If (num > 0) Then
            ResultLabel.Text = "مثبت"
        ElseIf (num < 0) Then
            ResultLabel.Text = "منفی"
        Else
            ResultLabel.Text = "صفر"
        End If


    End Sub

    Private Sub EndButton_Click(sender As Object, e As EventArgs) Handles EndButton.Click
        ResultLabel.Text = "پایان"
    End Sub
End Class
