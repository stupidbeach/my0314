Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dbBMI As Double
        dbBMI = Val(TextBox1.Text) / Val(TextBox2.Text) ^ 2
        TextBox3.Text = dbBMI
        If dbBMI < 18 Then
            TextBox4.Text = "體重過輕"
        ElseIf dbBMI < 24 Then
            TextBox4.Text = "體重正常"
        ElseIf dbBMI < 27 Then
            TextBox4.Text = "體重過重"
        Else : TextBox4.Text = "體重肥胖"
        End If

    End Sub
End Class
