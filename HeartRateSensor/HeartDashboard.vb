Public Class HeartDashboard
    Private Sub HeartDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rounded_btn()
        rounded_utils(btn_exit, btn_maximize, btn_minimize)
    End Sub
    Private Sub rounded_btn(ParamArray btnArr() As Button)


        For Each btn As Button In btnArr
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = Color.Indigo
            btn.ForeColor = Color.Cyan
            btn.FlatAppearance.MouseOverBackColor = Color.LightBlue
            btn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue

            btn.Cursor = Cursors.Hand
            btn.Font = New Font("Showcard Gothic", 20, FontStyle.Bold)

            AddHandler btn.MouseEnter, Sub(s, e) btn.ForeColor = Color.Black
            AddHandler btn.MouseLeave, Sub(s, e) btn.ForeColor = Color.Cyan
            AddHandler btn.MouseDown, Sub(s, e) btn.ForeColor = Color.White
            AddHandler btn.MouseUp, Sub(s, e) btn.ForeColor = Color.Black

            Dim radius As New Drawing2D.GraphicsPath
            radius.StartFigure()

            ' Top-left
            radius.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
            radius.AddLine(10, 0, btn.Width - 20, 0)

            ' Top-right
            radius.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
            radius.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)

            ' Bottom-right
            radius.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)

            ' Bottom-left
            radius.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
            radius.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)

            radius.CloseFigure()
            btn.Region = New Region(radius)
        Next
    End Sub

    Private Sub rounded_utils(ParamArray btnArr1() As Button)

        For Each btn As Button In btnArr1
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = Color.DarkSlateBlue
            btn.ForeColor = Color.Cyan
            btn.FlatAppearance.MouseOverBackColor = Color.LightBlue
            btn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue

            btn.Cursor = Cursors.Hand
            btn.Font = New Font("Showcard Gothic", 20, FontStyle.Bold)
            Dim iconBtn As FontAwesome.Sharp.IconButton = CType(btn, FontAwesome.Sharp.IconButton)
            iconBtn.IconColor = Color.Cyan


            AddHandler btn.MouseEnter, Sub(s, e)
                                           btn.ForeColor = Color.Black
                                           iconBtn.IconColor = Color.Black
                                       End Sub
            AddHandler btn.MouseLeave, Sub(s, e)
                                           btn.ForeColor = Color.Cyan
                                           iconBtn.IconColor = Color.Cyan
                                       End Sub
            AddHandler btn.MouseDown, Sub(s, e)
                                          btn.ForeColor = Color.MediumPurple
                                          iconBtn.IconColor = Color.MediumPurple
                                      End Sub
            AddHandler btn.MouseUp, Sub(s, e)
                                        btn.ForeColor = Color.Cyan
                                        iconBtn.IconColor = Color.Cyan
                                    End Sub

        Next
    End Sub


    Private Sub Btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub

    Private Sub Btn_maximize_Click(sender As Object, e As EventArgs) Handles btn_maximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


End Class
