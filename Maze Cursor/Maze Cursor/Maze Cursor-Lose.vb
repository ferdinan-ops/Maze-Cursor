Public Class Maze_Cursor_Lose

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Maze_Cursor_Game.Label2.Text = 60
        Maze_Cursor_Game.GunaCircleProgressBar1.ProgressMaxColor = Color.FromArgb(0, 192, 192)
        Maze_Cursor_Game.GunaCircleProgressBar1.ProgressMinColor = Color.FromArgb(0, 192, 0)
        Maze_Cursor_Game.Label2.ForeColor = Color.FromArgb(0, 192, 0)
        Maze_Cursor_Game.Kanan_Samping1.Enabled = False
        Maze_Cursor_Game.Kanan_Samping2.Enabled = False
        Maze_Cursor_Game.kanan_lblgerak2.Enabled = False
        Maze_Cursor_Game.Atas_lblgerak.Enabled = False
        Maze_Cursor_Game.Timer2.Enabled = False
        Maze_Cursor_Game.Timer4.Enabled = False
        Me.Hide()
    End Sub

    Private Sub Maze_Cursor_Lose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub
End Class