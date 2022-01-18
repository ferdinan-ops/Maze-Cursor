Public Class Maze_Cursor_Game
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        MoveToStart()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub GunaTransfarantPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaTransfarantPictureBox1.Click
        Maze_Cursor_Petunjuk.Show()
    End Sub

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        Kanan_Samping1.Enabled = True
        Kanan_Samping2.Enabled = True
        kanan_lblgerak2.Enabled = True
        Atas_lblgerak.Enabled = True
        Timer2.Enabled = True
        Timer4.Enabled = True
        MoveToStart()
        GunaCircleProgressBar1.Animated = True
        If Timer1.Enabled = True Then
            Timer1.Start()
        Else
            Label2.Text = 60
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Timer1.Interval = 1000
        If Label2.Text = 4 Then
            Label2.ForeColor = Color.Red
            Label2.Text = Val(Label2.Text) - 1
            GunaCircleProgressBar1.ProgressMaxColor = Color.Red
            GunaCircleProgressBar1.ProgressMinColor = Color.MistyRose
        ElseIf Label2.Text = 0 Then
            Timer1.Enabled = False
            GunaCircleProgressBar1.Animated = False
            Kanan_Samping1.Enabled = False
            Kanan_Samping2.Enabled = False
            kanan_lblgerak2.Enabled = False
            Atas_lblgerak.Enabled = False
            Timer2.Enabled = False
            Timer4.Enabled = False
            If GunaTransfarantPictureBox2.Visible = False And GunaTransfarantPictureBox3.Visible = True Then
                Maze_Cursor_Score1.Show()
                GunaTransfarantPictureBox5.Visible = True
            ElseIf GunaTransfarantPictureBox3.Visible = False And GunaTransfarantPictureBox2.Visible = False Then
                Maze_Cursor_Score2.Show()
                GunaTransfarantPictureBox7.Visible = True
                GunaTransfarantPictureBox5.Visible = True
            Else
                Maze_Cursor_Lose.Show()
            End If

        Else
            Label2.Text = Val(Label2.Text) - 1
        End If
    End Sub

    Private Sub MoveToStart()
        Dim StartingPoint = GunaPanel1.Location
        StartingPoint.Offset(20, 5)
        Cursor.Position = PointToScreen(StartingPoint)
    End Sub
    Private Sub MoveToSecond()
        Dim StartingPoint = GunaPanel1.Location
        StartingPoint.Offset(203, 373)
        Cursor.Position = PointToScreen(StartingPoint)
    End Sub
    Private Sub MoveToThird()
        Dim StartingPoint = GunaPanel1.Location
        StartingPoint.Offset(410, 264)
        Cursor.Position = PointToScreen(StartingPoint)
    End Sub
    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Samping2.MouseEnter, Samping1.MouseEnter, atas2.MouseEnter, Atas1.MouseEnter, Label99.MouseEnter, Label98.MouseEnter, Label97.MouseEnter, Label96.MouseEnter, Label95.MouseEnter, Label94.MouseEnter, Label93.MouseEnter, Label92.MouseEnter, Label91.MouseEnter, Label90.MouseEnter, Label9.MouseEnter, Label89.MouseEnter, Label88.MouseEnter, Label87.MouseEnter, Label86.MouseEnter, Label85.MouseEnter, Label84.MouseEnter, Label83.MouseEnter, Label82.MouseEnter, Label81.MouseEnter, Label80.MouseEnter, Label8.MouseEnter, Label79.MouseEnter, Label78.MouseEnter, Label77.MouseEnter, Label76.MouseEnter, Label75.MouseEnter, Label74.MouseEnter, Label73.MouseEnter, Label72.MouseEnter, Label71.MouseEnter, Label70.MouseEnter, Label7.MouseEnter, Label69.MouseEnter, Label68.MouseEnter, Label67.MouseEnter, Label66.MouseEnter, Label65.MouseEnter, Label64.MouseEnter, Label63.MouseEnter, Label62.MouseEnter, Label61.MouseEnter, Label60.MouseEnter, Label6.MouseEnter, Label59.MouseEnter, Label58.MouseEnter, Label57.MouseEnter, Label56.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label52.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label49.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label130.MouseEnter, Label13.MouseEnter, Label128.MouseEnter, Label127.MouseEnter, Label126.MouseEnter, Label125.MouseEnter, Label124.MouseEnter, Label123.MouseEnter, Label122.MouseEnter, Label121.MouseEnter, Label120.MouseEnter, Label119.MouseEnter, Label118.MouseEnter, Label117.MouseEnter, Label116.MouseEnter, Label115.MouseEnter, Label114.MouseEnter, Label113.MouseEnter, Label112.MouseEnter, Label111.MouseEnter, Label110.MouseEnter, Label11.MouseEnter, Label109.MouseEnter, Label108.MouseEnter, Label107.MouseEnter, Label106.MouseEnter, Label105.MouseEnter, Label104.MouseEnter, Label103.MouseEnter, Label102.MouseEnter, Label101.MouseEnter, Label100.MouseEnter, Label10.MouseEnter
        If GunaTransfarantPictureBox2.Visible = False And GunaTransfarantPictureBox3.Visible = True Then
            MoveToSecond()
        ElseIf GunaTransfarantPictureBox3.Visible = False And GunaTransfarantPictureBox2.Visible = False Then
            MoveToThird()
        Else
            MoveToStart()
        End If
    End Sub

    Private Sub Maze_Cursor_Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GunaTransfarantPictureBox2.Visible = True
        GunaTransfarantPictureBox3.Visible = True
    End Sub

    Private Sub Finish_MouseEnter(sender As Object, e As EventArgs) Handles Finish.MouseEnter
        If GunaTransfarantPictureBox2.Visible = False And GunaTransfarantPictureBox3.Visible = False Then
            Timer1.Stop()
            GunaCircleProgressBar1.Animated = False
            Kanan_Samping1.Enabled = False
            Kanan_Samping2.Enabled = False
            kanan_lblgerak2.Enabled = False
            Atas_lblgerak.Enabled = False
            Timer2.Enabled = False
            Timer4.Enabled = False
            Maze_Cursor_Score3.Show()
            GunaTransfarantPictureBox8.Visible = True
            GunaTransfarantPictureBox7.Visible = True
            GunaTransfarantPictureBox5.Visible = True
        Else
            MoveToStart()
        End If
    End Sub

    Private Sub GunaTransfarantPictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles GunaTransfarantPictureBox2.MouseEnter
        GunaTransfarantPictureBox2.Visible = False
    End Sub

    Private Sub GunaTransfarantPictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles GunaTransfarantPictureBox3.MouseEnter
        GunaTransfarantPictureBox3.Visible = False
    End Sub

    Private Sub Kanan_Samping1_Tick(sender As Object, e As EventArgs) Handles Kanan_Samping1.Tick
        If Samping1.Left < 348 Then
            Samping1.Left = Samping1.Left + 10
        Else
            Kanan_Samping1.Enabled = False
            Kiri_Samping1.Enabled = True
        End If
    End Sub

    Private Sub Kiri_Samping1_Tick(sender As Object, e As EventArgs) Handles Kiri_Samping1.Tick
        If Samping1.Left > 249 Then
            Samping1.Left = Samping1.Left - 10
        Else
            Kiri_Samping1.Enabled = False
            Kanan_Samping1.Enabled = True
        End If
    End Sub

    Private Sub Kanan_Samping2_Tick(sender As Object, e As EventArgs) Handles Kanan_Samping2.Tick
        If Samping2.Left < 577 Then
            Samping2.Left = Samping2.Left + 10
        Else
            Kanan_Samping2.Enabled = False
            Kiri_Samping2.Enabled = True
        End If
    End Sub

    Private Sub Kiri_Samping2_Tick(sender As Object, e As EventArgs) Handles Kiri_Samping2.Tick
        If Samping2.Left > 467 Then
            Samping2.Left = Samping2.Left - 10
        Else
            Kiri_Samping2.Enabled = False
            Kanan_Samping2.Enabled = True
        End If
    End Sub

    Private Sub kanan_lblgerak2_Tick(sender As Object, e As EventArgs) Handles kanan_lblgerak2.Tick
        If lbl_gerak2.Left < 353 Then
            lbl_gerak2.Left = lbl_gerak2.Left + 3
        Else
            kanan_lblgerak2.Enabled = False
            kiri_lblgerak2.Enabled = True
        End If
    End Sub

    Private Sub kiri_lblgerak2_Tick(sender As Object, e As EventArgs) Handles kiri_lblgerak2.Tick
        If lbl_gerak2.Left > 301 Then
            lbl_gerak2.Left = lbl_gerak2.Left - 3
        Else
            kiri_lblgerak2.Enabled = False
            kanan_lblgerak2.Enabled = True
        End If
    End Sub

    Private Sub Atas_lblgerak_Tick(sender As Object, e As EventArgs) Handles Atas_lblgerak.Tick
        If lbl_gerak.Top > 10 Then
            lbl_gerak.Top = lbl_gerak.Top - 3
        Else
            Atas_lblgerak.Enabled = False
            Bawah_lblgerak.Enabled = True
        End If
    End Sub

    Private Sub Bawah_lblgerak_Tick(sender As Object, e As EventArgs) Handles Bawah_lblgerak.Tick
        If lbl_gerak.Top < 87 Then
            lbl_gerak.Top = lbl_gerak.Top + 3
        Else
            Bawah_lblgerak.Enabled = False
            Atas_lblgerak.Enabled = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Atas1.Top > 98 Then
            Atas1.Top = Atas1.Top - 10
        Else
            Timer2.Enabled = False
            Timer3.Enabled = True
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Atas1.Top < 202 Then
            Atas1.Top = Atas1.Top + 10
        Else
            Timer3.Enabled = False
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If atas2.Top > 365 Then
            atas2.Top = atas2.Top - 8
        Else
            Timer4.Enabled = False
            Timer5.Enabled = True
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If atas2.Top < 395 Then
            atas2.Top = atas2.Top + 8
        Else
            Timer5.Enabled = False
            Timer4.Enabled = True
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class