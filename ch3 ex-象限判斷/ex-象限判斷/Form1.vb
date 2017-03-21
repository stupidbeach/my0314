Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim X As Double = Val(TextBox1.Text)
        Dim Y As Double = Val(TextBox2.Text)
        If ((X > 0) And (Y > 0)) Then
            TextBox3.Text = "第一象限"
        End If
        If ((X < 0) And (Y > 0)) Then
            TextBox3.Text = "第二象限"
        End If
        If ((X < 0) And (Y < 0)) Then
            TextBox3.Text = "第三象限"
        End If
        If ((X > 0) And (Y < 0)) Then
            TextBox3.Text = "第四象限"
        End If
        If ((X = 0) Or (Y = 0)) Then
            TextBox3.Text = "在座標軸上"
        End If
    End Sub
End Class
