Public Class P_PROJECT
    Dim drag As Boolean
    Dim mousex, mousey As Integer
    Dim A1, A2, A3, A4, A5 As Integer
    Dim All As String
    Private Sub Move_Window(sender As Object, e As MouseEventArgs) Handles bar.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Move_Pos_Window(sender As Object, e As MouseEventArgs) Handles bar.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Stay_Window(sender As Object, e As MouseEventArgs) Handles bar.MouseUp
        drag = False
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles CloseBtn.MouseClick
        End
    End Sub
    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles CloseBtn.MouseEnter
        CloseBtn.BackColor = Color.FromArgb(231, 76, 60)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles Button.Click
        Rule.BringToFront()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        QP1.BringToFront()
    End Sub

    Private Sub Y1_Click(sender As Object, e As EventArgs) Handles Y1.Click
        A1 = 1
        QP2.BringToFront()
    End Sub
    Private Sub N1_Click(sender As Object, e As EventArgs) Handles N1.Click
        QP2.BringToFront()
    End Sub
    Private Sub Y2_Click(sender As Object, e As EventArgs) Handles Y2.Click
        A2 = 2
        QP3.BringToFront()
    End Sub
    Private Sub N2_Click(sender As Object, e As EventArgs) Handles N2.Click
        QP3.BringToFront()
    End Sub
    Private Sub Y3_Click(sender As Object, e As EventArgs) Handles Y3.Click
        A3 = 4
        QP4.BringToFront()
    End Sub
    Private Sub N3_Click(sender As Object, e As EventArgs) Handles N3.Click
        QP4.BringToFront()
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        A1 = 0
        A2 = 0
        A3 = 0
        A4 = 0
        A5 = 0
        Welcome.BringToFront()
    End Sub

    Private Sub Y4_Click(sender As Object, e As EventArgs) Handles Y4.Click
        A4 = 8
        QP5.BringToFront()
    End Sub
    Private Sub N4_Click(sender As Object, e As EventArgs) Handles N4.Click
        QP5.BringToFront()
    End Sub
    Private Sub Y5_Click(sender As Object, e As EventArgs) Handles Y5.Click
        A5 = 16
        All = Str(A1 + A2 + A3 + A4 + A5)
        Result.Text = "วันเกิดของคุณคือวันที่ " + All
        Show_Result.BringToFront()
    End Sub
    Private Sub N5_Click(sender As Object, e As EventArgs) Handles N5.Click
        All = Str(A1 + A2 + A3 + A4 + A5)
        Result.Text = "วันเกิดของคุณคือวันที่ " + All
        Show_Result.BringToFront()
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles CloseBtn.MouseLeave
        CloseBtn.BackColor = Color.FromArgb(44, 62, 80)
    End Sub
End Class
