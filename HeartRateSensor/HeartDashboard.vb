
Imports System.IO.Ports
Imports System.IO
Public Class HeartDashboard
    Dim currentBPM As Integer = 0
    Dim csvPath As String = "patients.csv"



    Private Sub HeartDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rounded_btn()
        rounded_utils(btn_exit, btn_maximize, btn_minimize)


        With dtp_savedate
            .CalendarMonthBackground = Color.Indigo
            .CalendarForeColor = Color.Cyan
            .CalendarTitleBackColor = Color.DarkSlateBlue
            .CalendarTitleForeColor = Color.Cyan
            .CalendarTrailingForeColor = Color.LightBlue
            .BackColor = Color.Indigo
            .ForeColor = Color.Cyan
            .Font = New Font("Arial", 12, FontStyle.Regular)
        End With

        Try
            serial_port_heart.PortName = "COM5"   ' Set port name before opening
            serial_port_heart.BaudRate = 9600     ' Set baud rate before opening
            If Not serial_port_heart.IsOpen Then
                serial_port_heart.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Error opening serial port: " & ex.Message)
        End Try

        ' FOR GRAPH'
        chart_bpm.Series.Clear()
        chart_bpm.Series.Add("BPM")
        chart_bpm.Series("BPM").ChartType = DataVisualization.Charting.SeriesChartType.Line
        chart_bpm.ChartAreas(0).AxisX.Title = "Time"
        chart_bpm.ChartAreas(0).AxisY.Title = "BPM"

        lbl_bpm.Text = "BPM: --"
        dtp_savedate.Value = DateTime.Now
        LoadPatientRecords()
    End Sub

    Private Sub serial_port_heart_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles serial_port_heart.DataReceived
        Try
            Dim data As String = serial_port_heart.ReadLine().Trim()
            Dim parts = data.Split(","c)

            If parts.Length = 2 Then
                Dim bpmVal As Integer

                If Integer.TryParse(parts(0), bpmVal) Then
                    currentBPM = bpmVal
                    Dim status As String = parts(1)

                    Me.Invoke(Sub()
                                  lbl_bpm.Text = $"BPM: {currentBPM} ({status})"
                                  chart_bpm.Series("BPM").Points.AddY(currentBPM)
                              End Sub)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error reading from serial: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_startread_Click(sender As Object, e As EventArgs) Handles btn_startread.Click
        If Not serial_port_heart.IsOpen Then
            Try
                serial_port_heart.Open()
                MessageBox.Show("Started reading from Arduino.")
            Catch ex As Exception
                MessageBox.Show("Could not open COM port: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Already reading.")
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_name.Text = "" Or txt_age.Text = "" Or txt_address.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Dim dateSaved As String = dtp_savedate.Value.ToString("yyyy-MM-dd")

        ' Get BPM values from chart
        Dim bpmList As New List(Of String)
        For Each pt As DataVisualization.Charting.DataPoint In chart_bpm.Series("BPM").Points
            bpmList.Add(pt.YValues(0).ToString())
        Next

        If bpmList.Count = 0 Then
            MessageBox.Show("No BPM data to save.")
            Return
        End If

        Dim bpmCSV As String = String.Join(",", bpmList)
        Dim line As String = $"{txt_name.Text},{txt_age.Text},{txt_address.Text},{dateSaved},{bpmCSV}"
        File.AppendAllText(csvPath, line & Environment.NewLine)
        MessageBox.Show("Patient record saved!")

        LoadPatientRecords()
        ClearFields()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txt_name.Clear()
        txt_age.Clear()
        txt_address.Clear()
        dtp_savedate.Value = DateTime.Now
        lbl_bpm.Text = "BPM: --"
        chart_bpm.Series("BPM").Points.Clear()
    End Sub

    Private Sub LoadPatientRecords()
        dgv_patients.Rows.Clear()
        dgv_patients.Columns.Clear()

        If Not File.Exists(csvPath) Then Return

        dgv_patients.Columns.Add("Name", "Name")
        dgv_patients.Columns.Add("Age", "Age")
        dgv_patients.Columns.Add("Address", "Address")
        dgv_patients.Columns.Add("Date", "Date")
        dgv_patients.Columns.Add("BPMs", "BPMs")

        Dim lines = File.ReadAllLines(csvPath)
        For Each line As String In lines
            Dim fields = line.Split(","c)
            If fields.Length >= 5 Then
                Dim bpmValues As String = String.Join(",", fields.Skip(4))
                dgv_patients.Rows.Add(fields(0), fields(1), fields(2), fields(3), bpmValues)
            End If
        Next
    End Sub

    Private Sub dgv_patients_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_patients.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgv_patients.Rows(e.RowIndex)
            txt_name.Text = row.Cells(0).Value.ToString()
            txt_age.Text = row.Cells(1).Value.ToString()
            txt_address.Text = row.Cells(2).Value.ToString()
            dtp_savedate.Value = DateTime.Parse(row.Cells(3).Value.ToString())

            chart_bpm.Series("BPM").Points.Clear()
            Dim bpmValues = row.Cells(4).Value.ToString().Split(","c)
            For Each bpm In bpmValues
                If Integer.TryParse(bpm, Nothing) Then
                    chart_bpm.Series("BPM").Points.AddY(CInt(bpm))
                End If
            Next

            lbl_bpm.Text = "BPM: " & bpmValues.Last()
        End If
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

    Private Sub dgv_patients_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_patients.CellContentClick

    End Sub

    Private Sub chart_bpm_Click(sender As Object, e As EventArgs) Handles chart_bpm.Click

    End Sub
End Class
