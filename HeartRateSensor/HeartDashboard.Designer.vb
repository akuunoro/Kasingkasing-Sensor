<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HeartDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lb_title = New System.Windows.Forms.Label()
        Me.btn_exit = New FontAwesome.Sharp.IconButton()
        Me.btn_maximize = New FontAwesome.Sharp.IconButton()
        Me.btn_minimize = New FontAwesome.Sharp.IconButton()
        Me.btn_icon = New System.Windows.Forms.Button()
        Me.dtp_savedate = New System.Windows.Forms.DateTimePicker()
        Me.dgv_patients = New System.Windows.Forms.DataGridView()
        Me.chart_bpm = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lbl_bpm = New System.Windows.Forms.Label()
        Me.btn_startread = New FontAwesome.Sharp.IconButton()
        Me.btn_save = New FontAwesome.Sharp.IconButton()
        Me.btn_clear = New FontAwesome.Sharp.IconButton()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_age = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_age = New System.Windows.Forms.Label()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.serial_port_heart = New System.IO.Ports.SerialPort(Me.components)
        CType(Me.dgv_patients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chart_bpm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_title
        '
        Me.lb_title.AutoSize = True
        Me.lb_title.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_title.ForeColor = System.Drawing.Color.Cyan
        Me.lb_title.Location = New System.Drawing.Point(82, 4)
        Me.lb_title.Margin = New System.Windows.Forms.Padding(0)
        Me.lb_title.Name = "lb_title"
        Me.lb_title.Size = New System.Drawing.Size(444, 41)
        Me.lb_title.TabIndex = 15
        Me.lb_title.Text = "Kasing-kasing Detector"
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_exit.IconChar = FontAwesome.Sharp.IconChar.X
        Me.btn_exit.IconColor = System.Drawing.Color.Cyan
        Me.btn_exit.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btn_exit.IconSize = 25
        Me.btn_exit.Location = New System.Drawing.Point(1025, 4)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(83, 55)
        Me.btn_exit.TabIndex = 14
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'btn_maximize
        '
        Me.btn_maximize.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_maximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_maximize.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_maximize.IconChar = FontAwesome.Sharp.IconChar.SquareFull
        Me.btn_maximize.IconColor = System.Drawing.Color.Cyan
        Me.btn_maximize.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btn_maximize.IconSize = 25
        Me.btn_maximize.Location = New System.Drawing.Point(940, 4)
        Me.btn_maximize.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_maximize.Name = "btn_maximize"
        Me.btn_maximize.Size = New System.Drawing.Size(84, 55)
        Me.btn_maximize.TabIndex = 13
        Me.btn_maximize.UseVisualStyleBackColor = False
        '
        'btn_minimize
        '
        Me.btn_minimize.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_minimize.IconChar = FontAwesome.Sharp.IconChar.Minus
        Me.btn_minimize.IconColor = System.Drawing.Color.Cyan
        Me.btn_minimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_minimize.Location = New System.Drawing.Point(856, 4)
        Me.btn_minimize.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(84, 55)
        Me.btn_minimize.TabIndex = 12
        Me.btn_minimize.UseVisualStyleBackColor = False
        '
        'btn_icon
        '
        Me.btn_icon.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_icon.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_icon.Image = Global.HeartRateSensor.My.Resources.Resources.heart__35x35_
        Me.btn_icon.Location = New System.Drawing.Point(14, 4)
        Me.btn_icon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_icon.Name = "btn_icon"
        Me.btn_icon.Size = New System.Drawing.Size(65, 44)
        Me.btn_icon.TabIndex = 16
        Me.btn_icon.UseVisualStyleBackColor = False
        '
        'dtp_savedate
        '
        Me.dtp_savedate.CalendarFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_savedate.CalendarForeColor = System.Drawing.Color.Cyan
        Me.dtp_savedate.CalendarMonthBackground = System.Drawing.Color.DarkSlateBlue
        Me.dtp_savedate.CalendarTitleBackColor = System.Drawing.SystemColors.GrayText
        Me.dtp_savedate.CalendarTitleForeColor = System.Drawing.Color.Cyan
        Me.dtp_savedate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_savedate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_savedate.Location = New System.Drawing.Point(943, 84)
        Me.dtp_savedate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_savedate.Name = "dtp_savedate"
        Me.dtp_savedate.Size = New System.Drawing.Size(148, 35)
        Me.dtp_savedate.TabIndex = 17
        '
        'dgv_patients
        '
        Me.dgv_patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_patients.Location = New System.Drawing.Point(670, 401)
        Me.dgv_patients.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgv_patients.Name = "dgv_patients"
        Me.dgv_patients.RowHeadersWidth = 51
        Me.dgv_patients.RowTemplate.Height = 24
        Me.dgv_patients.Size = New System.Drawing.Size(421, 275)
        Me.dgv_patients.TabIndex = 18
        '
        'chart_bpm
        '
        ChartArea2.Name = "ChartArea1"
        Me.chart_bpm.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chart_bpm.Legends.Add(Legend2)
        Me.chart_bpm.Location = New System.Drawing.Point(29, 125)
        Me.chart_bpm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chart_bpm.Name = "chart_bpm"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chart_bpm.Series.Add(Series2)
        Me.chart_bpm.Size = New System.Drawing.Size(613, 545)
        Me.chart_bpm.TabIndex = 19
        Me.chart_bpm.Text = "Chart1"
        '
        'lbl_bpm
        '
        Me.lbl_bpm.AutoSize = True
        Me.lbl_bpm.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.lbl_bpm.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bpm.ForeColor = System.Drawing.Color.Cyan
        Me.lbl_bpm.Location = New System.Drawing.Point(24, 84)
        Me.lbl_bpm.Name = "lbl_bpm"
        Me.lbl_bpm.Size = New System.Drawing.Size(75, 33)
        Me.lbl_bpm.TabIndex = 20
        Me.lbl_bpm.Text = "bpm"
        '
        'btn_startread
        '
        Me.btn_startread.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_startread.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_startread.ForeColor = System.Drawing.Color.BlueViolet
        Me.btn_startread.IconChar = FontAwesome.Sharp.IconChar.Heartbeat
        Me.btn_startread.IconColor = System.Drawing.Color.Red
        Me.btn_startread.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btn_startread.Location = New System.Drawing.Point(532, 66)
        Me.btn_startread.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_startread.Name = "btn_startread"
        Me.btn_startread.Size = New System.Drawing.Size(110, 51)
        Me.btn_startread.TabIndex = 21
        Me.btn_startread.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.ForeColor = System.Drawing.Color.BlueViolet
        Me.btn_save.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus
        Me.btn_save.IconColor = System.Drawing.Color.LimeGreen
        Me.btn_save.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btn_save.IconSize = 30
        Me.btn_save.Location = New System.Drawing.Point(670, 66)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(81, 55)
        Me.btn_save.TabIndex = 22
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.ForeColor = System.Drawing.Color.BlueViolet
        Me.btn_clear.IconChar = FontAwesome.Sharp.IconChar.X
        Me.btn_clear.IconColor = System.Drawing.Color.LimeGreen
        Me.btn_clear.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btn_clear.IconSize = 30
        Me.btn_clear.Location = New System.Drawing.Point(765, 66)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(81, 55)
        Me.btn_clear.TabIndex = 23
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.txt_name.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.ForeColor = System.Drawing.Color.Cyan
        Me.txt_name.Location = New System.Drawing.Point(670, 170)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(420, 39)
        Me.txt_name.TabIndex = 24
        '
        'txt_age
        '
        Me.txt_age.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.txt_age.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_age.ForeColor = System.Drawing.Color.Cyan
        Me.txt_age.Location = New System.Drawing.Point(670, 254)
        Me.txt_age.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(420, 39)
        Me.txt_age.TabIndex = 25
        '
        'txt_address
        '
        Me.txt_address.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.txt_address.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.ForeColor = System.Drawing.Color.Cyan
        Me.txt_address.Location = New System.Drawing.Point(670, 338)
        Me.txt_address.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(420, 39)
        Me.txt_address.TabIndex = 26
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.lbl_name.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.Cyan
        Me.lbl_name.Location = New System.Drawing.Point(665, 132)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(103, 33)
        Me.lbl_name.TabIndex = 27
        Me.lbl_name.Text = "Name:"
        '
        'lbl_age
        '
        Me.lbl_age.AutoSize = True
        Me.lbl_age.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.lbl_age.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_age.ForeColor = System.Drawing.Color.Cyan
        Me.lbl_age.Location = New System.Drawing.Point(665, 216)
        Me.lbl_age.Name = "lbl_age"
        Me.lbl_age.Size = New System.Drawing.Size(77, 33)
        Me.lbl_age.TabIndex = 28
        Me.lbl_age.Text = "Age:"
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.lbl_address.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.ForeColor = System.Drawing.Color.Cyan
        Me.lbl_address.Location = New System.Drawing.Point(665, 300)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(135, 33)
        Me.lbl_address.TabIndex = 29
        Me.lbl_address.Text = "Address:"
        '
        'serial_port_heart
        '
        Me.serial_port_heart.PortName = "COM5"
        '
        'HeartDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(1105, 691)
        Me.Controls.Add(Me.lbl_address)
        Me.Controls.Add(Me.lbl_age)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.txt_age)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_startread)
        Me.Controls.Add(Me.lbl_bpm)
        Me.Controls.Add(Me.chart_bpm)
        Me.Controls.Add(Me.dgv_patients)
        Me.Controls.Add(Me.dtp_savedate)
        Me.Controls.Add(Me.btn_icon)
        Me.Controls.Add(Me.lb_title)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_maximize)
        Me.Controls.Add(Me.btn_minimize)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "HeartDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HeartDashboard"
        CType(Me.dgv_patients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chart_bpm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_exit As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_maximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents lb_title As Label
    Friend WithEvents btn_icon As Button
    Friend WithEvents dtp_savedate As DateTimePicker
    Friend WithEvents dgv_patients As DataGridView
    Friend WithEvents chart_bpm As DataVisualization.Charting.Chart
    Friend WithEvents lbl_bpm As Label
    Friend WithEvents btn_startread As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_save As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_clear As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_age As TextBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_age As Label
    Friend WithEvents lbl_address As Label
    Friend WithEvents serial_port_heart As IO.Ports.SerialPort
End Class
