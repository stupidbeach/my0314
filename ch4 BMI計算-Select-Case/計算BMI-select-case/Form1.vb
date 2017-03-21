Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dbBMI As Double
        dbBMI = Val(TextBox1.Text) / Val(TextBox2.Text) ^ 2
        TextBox3.Text = dbBMI
        Select Case dbBMI
            Case Is < 18
                TextBox4.Text = "體重過輕"
            Case Is < 24
                TextBox4.Text = "體重正常"
            Case Is < 27
                TextBox4.Text = "體重過重"
            Case Else
                TextBox4.Text = "體重肥胖"
        End Select
    End Sub
End Class
