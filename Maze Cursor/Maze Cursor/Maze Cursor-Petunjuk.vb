Public Class Maze_Cursor_Petunjuk

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub

    Private Sub Maze_Cursor_Petunjuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        panel_checkpoint.Visible = False
        panel_hantubiru.Visible = False
        panel_hantuijo.Visible = False
        panel_start_finish.Visible = False
        panel_tembok.Visible = True
    End Sub
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Me.Hide()
    End Sub

    Private Sub Back_green_Click(sender As Object, e As EventArgs) Handles Back_green.Click
        panel_checkpoint.Visible = False
        panel_hantubiru.Visible = True
        panel_hantuijo.Visible = False
        panel_start_finish.Visible = False
        panel_tembok.Visible = False
    End Sub

    Private Sub Next_Wall_Click(sender As Object, e As EventArgs) Handles Next_Wall.Click
        panel_checkpoint.Visible = True
        panel_hantubiru.Visible = False
        panel_hantuijo.Visible = False
        panel_start_finish.Visible = False
        panel_tembok.Visible = False
    End Sub

    Private Sub Back_Blue_Click(sender As Object, e As EventArgs) Handles Back_Blue.Click
        panel_checkpoint.Visible = False
        panel_hantubiru.Visible = False
        panel_hantuijo.Visible = False
        panel_start_finish.Visible = True
        panel_tembok.Visible = False
    End Sub

    Private Sub Next_Blue_Click(sender As Object, e As EventArgs) Handles Next_Blue.Click
        panel_checkpoint.Visible = False
        panel_hantubiru.Visible = False
        panel_hantuijo.Visible = True
        panel_start_finish.Visible = False
        panel_tembok.Visible = False
    End Sub

    Private Sub Back_Start_Click(sender As Object, e As EventArgs) Handles Back_Start.Click
        panel_checkpoint.Visible = True
        panel_hantubiru.Visible = False
        panel_hantuijo.Visible = False
        panel_start_finish.Visible = False
        panel_tembok.Visible = False
    End Sub

    Private Sub Next_Start_Click(sender As Object, e As EventArgs) Handles Next_Start.Click
        panel_checkpoint.Visible = False
        panel_hantubiru.Visible = True
        panel_hantuijo.Visible = False
        panel_start_finish.Visible = False
        panel_tembok.Visible = False
    End Sub

    Private Sub Back_Checkpoint_Click(sender As Object, e As EventArgs) Handles Back_Checkpoint.Click
        panel_checkpoint.Visible = False
        panel_hantubiru.Visible = False
        panel_hantuijo.Visible = False
        panel_start_finish.Visible = False
        panel_tembok.Visible = True
    End Sub

    Private Sub Next_Checkpoint_Click(sender As Object, e As EventArgs) Handles Next_Checkpoint.Click
        panel_checkpoint.Visible = False
        panel_hantubiru.Visible = False
        panel_hantuijo.Visible = False
        panel_start_finish.Visible = True
        panel_tembok.Visible = False
    End Sub
End Class