Public Class Maze_Cursor

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        End
    End Sub

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        Me.Hide()
        Maze_Cursor_Game.Show()
    End Sub

    Private Sub Maze_Cursor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GunaButton7.BackColor = Color.FromArgb(142, 44, 77)
    End Sub
End Class