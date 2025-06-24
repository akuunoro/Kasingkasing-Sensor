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
        Me.lb_title = New System.Windows.Forms.Label()
        Me.btn_exit = New FontAwesome.Sharp.IconButton()
        Me.btn_maximize = New FontAwesome.Sharp.IconButton()
        Me.btn_minimize = New FontAwesome.Sharp.IconButton()
        Me.btn_icon = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lb_title
        '
        Me.lb_title.AutoSize = True
        Me.lb_title.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_title.ForeColor = System.Drawing.Color.Cyan
        Me.lb_title.Location = New System.Drawing.Point(73, 3)
        Me.lb_title.Margin = New System.Windows.Forms.Padding(0)
        Me.lb_title.Name = "lb_title"
        Me.lb_title.Size = New System.Drawing.Size(362, 35)
        Me.lb_title.TabIndex = 15
        Me.lb_title.Text = "Kasingkasing Detector"
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
        Me.btn_exit.Location = New System.Drawing.Point(911, 3)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(74, 44)
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
        Me.btn_maximize.Location = New System.Drawing.Point(836, 3)
        Me.btn_maximize.Name = "btn_maximize"
        Me.btn_maximize.Size = New System.Drawing.Size(75, 44)
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
        Me.btn_minimize.Location = New System.Drawing.Point(761, 3)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(75, 44)
        Me.btn_minimize.TabIndex = 12
        Me.btn_minimize.UseVisualStyleBackColor = False
        '
        'btn_icon
        '
        Me.btn_icon.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_icon.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_icon.Image = Global.HeartRateSensor.My.Resources.Resources.heart__35x35_
        Me.btn_icon.Location = New System.Drawing.Point(12, 3)
        Me.btn_icon.Name = "btn_icon"
        Me.btn_icon.Size = New System.Drawing.Size(58, 35)
        Me.btn_icon.TabIndex = 16
        Me.btn_icon.UseVisualStyleBackColor = False
        '
        'HeartDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(982, 553)
        Me.Controls.Add(Me.btn_icon)
        Me.Controls.Add(Me.lb_title)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_maximize)
        Me.Controls.Add(Me.btn_minimize)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HeartDashboard"
        Me.Text = "HeartDashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_exit As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_maximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents lb_title As Label
    Friend WithEvents btn_icon As Button
End Class
