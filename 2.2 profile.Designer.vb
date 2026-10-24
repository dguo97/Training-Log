<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.sntb = New System.Windows.Forms.TextBox
        Me.hnnp = New System.Windows.Forms.NumericUpDown
        Me.fnl = New System.Windows.Forms.Label
        Me.snl = New System.Windows.Forms.Label
        Me.wnp = New System.Windows.Forms.NumericUpDown
        Me.hnl = New System.Windows.Forms.Label
        Me.fntb = New System.Windows.Forms.TextBox
        Me.DOBtp = New System.Windows.Forms.DateTimePicker
        Me.pntb = New System.Windows.Forms.TextBox
        Me.pcl = New System.Windows.Forms.Label
        Me.dobl = New System.Windows.Forms.Label
        Me.pnl = New System.Windows.Forms.Label
        Me.pctb = New System.Windows.Forms.TextBox
        Me.wl = New System.Windows.Forms.Label
        Me.bte = New System.Windows.Forms.Button
        Me.btback = New System.Windows.Forms.Button
        Me.bts = New System.Windows.Forms.Button
        CType(Me.hnnp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wnp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sntb
        '
        Me.sntb.Location = New System.Drawing.Point(165, 54)
        Me.sntb.MaxLength = 10
        Me.sntb.Name = "sntb"
        Me.sntb.Size = New System.Drawing.Size(68, 21)
        Me.sntb.TabIndex = 30
        '
        'hnnp
        '
        Me.hnnp.Location = New System.Drawing.Point(165, 83)
        Me.hnnp.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.hnnp.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.hnnp.Name = "hnnp"
        Me.hnnp.Size = New System.Drawing.Size(68, 21)
        Me.hnnp.TabIndex = 33
        Me.hnnp.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'fnl
        '
        Me.fnl.AutoSize = True
        Me.fnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fnl.Location = New System.Drawing.Point(48, 27)
        Me.fnl.Name = "fnl"
        Me.fnl.Size = New System.Drawing.Size(67, 15)
        Me.fnl.TabIndex = 20
        Me.fnl.Text = "First Name"
        '
        'snl
        '
        Me.snl.AutoSize = True
        Me.snl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.snl.Location = New System.Drawing.Point(29, 54)
        Me.snl.Name = "snl"
        Me.snl.Size = New System.Drawing.Size(86, 15)
        Me.snl.TabIndex = 21
        Me.snl.Text = "Second Name"
        '
        'wnp
        '
        Me.wnp.Location = New System.Drawing.Point(165, 228)
        Me.wnp.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.wnp.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.wnp.Name = "wnp"
        Me.wnp.Size = New System.Drawing.Size(57, 21)
        Me.wnp.TabIndex = 32
        Me.wnp.Value = New Decimal(New Integer() {75, 0, 0, 0})
        '
        'hnl
        '
        Me.hnl.AutoSize = True
        Me.hnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hnl.Location = New System.Drawing.Point(29, 83)
        Me.hnl.Name = "hnl"
        Me.hnl.Size = New System.Drawing.Size(91, 15)
        Me.hnl.TabIndex = 22
        Me.hnl.Text = "House Number"
        '
        'fntb
        '
        Me.fntb.Location = New System.Drawing.Point(165, 27)
        Me.fntb.MaxLength = 20
        Me.fntb.Name = "fntb"
        Me.fntb.Size = New System.Drawing.Size(137, 21)
        Me.fntb.TabIndex = 27
        '
        'DOBtp
        '
        Me.DOBtp.CalendarForeColor = System.Drawing.SystemColors.Desktop
        Me.DOBtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOBtp.Location = New System.Drawing.Point(165, 183)
        Me.DOBtp.Name = "DOBtp"
        Me.DOBtp.Size = New System.Drawing.Size(136, 21)
        Me.DOBtp.TabIndex = 31
        '
        'pntb
        '
        Me.pntb.Location = New System.Drawing.Point(166, 149)
        Me.pntb.Name = "pntb"
        Me.pntb.Size = New System.Drawing.Size(136, 21)
        Me.pntb.TabIndex = 28
        '
        'pcl
        '
        Me.pcl.AutoSize = True
        Me.pcl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pcl.Location = New System.Drawing.Point(57, 119)
        Me.pcl.Name = "pcl"
        Me.pcl.Size = New System.Drawing.Size(63, 15)
        Me.pcl.TabIndex = 23
        Me.pcl.Text = "Post Code"
        '
        'dobl
        '
        Me.dobl.AutoSize = True
        Me.dobl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dobl.Location = New System.Drawing.Point(83, 183)
        Me.dobl.Name = "dobl"
        Me.dobl.Size = New System.Drawing.Size(33, 15)
        Me.dobl.TabIndex = 26
        Me.dobl.Text = "DOB"
        '
        'pnl
        '
        Me.pnl.AutoSize = True
        Me.pnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl.Location = New System.Drawing.Point(29, 150)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(91, 15)
        Me.pnl.TabIndex = 24
        Me.pnl.Text = "Phone Number"
        '
        'pctb
        '
        Me.pctb.Location = New System.Drawing.Point(165, 115)
        Me.pctb.Name = "pctb"
        Me.pctb.Size = New System.Drawing.Size(92, 21)
        Me.pctb.TabIndex = 29
        '
        'wl
        '
        Me.wl.AutoSize = True
        Me.wl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wl.Location = New System.Drawing.Point(69, 228)
        Me.wl.Name = "wl"
        Me.wl.Size = New System.Drawing.Size(45, 15)
        Me.wl.TabIndex = 25
        Me.wl.Text = "Weight"
        '
        'bte
        '
        Me.bte.Location = New System.Drawing.Point(76, 284)
        Me.bte.Name = "bte"
        Me.bte.Size = New System.Drawing.Size(75, 23)
        Me.bte.TabIndex = 2
        Me.bte.Text = "Edit"
        Me.bte.UseVisualStyleBackColor = True
        '
        'btback
        '
        Me.btback.Location = New System.Drawing.Point(243, 284)
        Me.btback.Name = "btback"
        Me.btback.Size = New System.Drawing.Size(75, 23)
        Me.btback.TabIndex = 3
        Me.btback.Text = "Back"
        Me.btback.UseVisualStyleBackColor = True
        '
        'bts
        '
        Me.bts.Location = New System.Drawing.Point(157, 284)
        Me.bts.Name = "bts"
        Me.bts.Size = New System.Drawing.Size(75, 23)
        Me.bts.TabIndex = 1
        Me.bts.Text = "Save"
        Me.bts.UseVisualStyleBackColor = True
        '
        'profile
        '
        Me.AcceptButton = Me.bts
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 323)
        Me.Controls.Add(Me.bts)
        Me.Controls.Add(Me.btback)
        Me.Controls.Add(Me.bte)
        Me.Controls.Add(Me.sntb)
        Me.Controls.Add(Me.hnnp)
        Me.Controls.Add(Me.fnl)
        Me.Controls.Add(Me.snl)
        Me.Controls.Add(Me.wnp)
        Me.Controls.Add(Me.hnl)
        Me.Controls.Add(Me.fntb)
        Me.Controls.Add(Me.DOBtp)
        Me.Controls.Add(Me.pntb)
        Me.Controls.Add(Me.pcl)
        Me.Controls.Add(Me.dobl)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.pctb)
        Me.Controls.Add(Me.wl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "profile"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Profile"
        CType(Me.hnnp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wnp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sntb As System.Windows.Forms.TextBox
    Friend WithEvents hnnp As System.Windows.Forms.NumericUpDown
    Friend WithEvents fnl As System.Windows.Forms.Label
    Friend WithEvents snl As System.Windows.Forms.Label
    Friend WithEvents wnp As System.Windows.Forms.NumericUpDown
    Friend WithEvents hnl As System.Windows.Forms.Label
    Friend WithEvents fntb As System.Windows.Forms.TextBox
    Friend WithEvents DOBtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents pntb As System.Windows.Forms.TextBox
    Friend WithEvents pcl As System.Windows.Forms.Label
    Friend WithEvents dobl As System.Windows.Forms.Label
    Friend WithEvents pnl As System.Windows.Forms.Label
    Friend WithEvents pctb As System.Windows.Forms.TextBox
    Friend WithEvents wl As System.Windows.Forms.Label
    Friend WithEvents bte As System.Windows.Forms.Button
    Friend WithEvents btback As System.Windows.Forms.Button
    Friend WithEvents bts As System.Windows.Forms.Button

End Class
