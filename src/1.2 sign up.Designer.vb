<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class account
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
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.fnl = New System.Windows.Forms.Label
        Me.snl = New System.Windows.Forms.Label
        Me.hnl = New System.Windows.Forms.Label
        Me.pcl = New System.Windows.Forms.Label
        Me.pnl = New System.Windows.Forms.Label
        Me.wl = New System.Windows.Forms.Label
        Me.dofl = New System.Windows.Forms.Label
        Me.fntb = New System.Windows.Forms.TextBox
        Me.pntb = New System.Windows.Forms.TextBox
        Me.sntb = New System.Windows.Forms.TextBox
        Me.bts = New System.Windows.Forms.Button
        Me.DOBtp = New System.Windows.Forms.DateTimePicker
        Me.wnp = New System.Windows.Forms.NumericUpDown
        Me.hnnp = New System.Windows.Forms.NumericUpDown
        Me.pctb = New System.Windows.Forms.TextBox
        Me.unl = New System.Windows.Forms.Label
        Me.pwl = New System.Windows.Forms.Label
        Me.lbcp = New System.Windows.Forms.Label
        Me.utb = New System.Windows.Forms.TextBox
        Me.pwtb = New System.Windows.Forms.TextBox
        Me.tbcpw = New System.Windows.Forms.TextBox
        CType(Me.wnp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hnnp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(223, 413)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 11
        Me.Cancel_Button.Text = "Cancel"
        '
        'fnl
        '
        Me.fnl.AutoSize = True
        Me.fnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fnl.Location = New System.Drawing.Point(58, 30)
        Me.fnl.Name = "fnl"
        Me.fnl.Size = New System.Drawing.Size(67, 15)
        Me.fnl.TabIndex = 1
        Me.fnl.Text = "First Name"
        '
        'snl
        '
        Me.snl.AutoSize = True
        Me.snl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.snl.Location = New System.Drawing.Point(39, 60)
        Me.snl.Name = "snl"
        Me.snl.Size = New System.Drawing.Size(86, 15)
        Me.snl.TabIndex = 2
        Me.snl.Text = "Second Name"
        '
        'hnl
        '
        Me.hnl.AutoSize = True
        Me.hnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hnl.Location = New System.Drawing.Point(34, 91)
        Me.hnl.Name = "hnl"
        Me.hnl.Size = New System.Drawing.Size(91, 15)
        Me.hnl.TabIndex = 3
        Me.hnl.Text = "House Number"
        '
        'pcl
        '
        Me.pcl.AutoSize = True
        Me.pcl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pcl.Location = New System.Drawing.Point(62, 132)
        Me.pcl.Name = "pcl"
        Me.pcl.Size = New System.Drawing.Size(63, 15)
        Me.pcl.TabIndex = 4
        Me.pcl.Text = "Post Code"
        '
        'pnl
        '
        Me.pnl.AutoSize = True
        Me.pnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl.Location = New System.Drawing.Point(34, 163)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(91, 15)
        Me.pnl.TabIndex = 5
        Me.pnl.Text = "Phone Number"
        '
        'wl
        '
        Me.wl.AutoSize = True
        Me.wl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wl.Location = New System.Drawing.Point(80, 247)
        Me.wl.Name = "wl"
        Me.wl.Size = New System.Drawing.Size(45, 15)
        Me.wl.TabIndex = 6
        Me.wl.Text = "Weight"
        '
        'dofl
        '
        Me.dofl.AutoSize = True
        Me.dofl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dofl.Location = New System.Drawing.Point(92, 199)
        Me.dofl.Name = "dofl"
        Me.dofl.Size = New System.Drawing.Size(33, 15)
        Me.dofl.TabIndex = 7
        Me.dofl.Text = "DOB"
        '
        'fntb
        '
        Me.fntb.Location = New System.Drawing.Point(170, 30)
        Me.fntb.MaxLength = 20
        Me.fntb.Name = "fntb"
        Me.fntb.Size = New System.Drawing.Size(120, 20)
        Me.fntb.TabIndex = 0
        '
        'pntb
        '
        Me.pntb.Location = New System.Drawing.Point(171, 163)
        Me.pntb.Name = "pntb"
        Me.pntb.Size = New System.Drawing.Size(91, 20)
        Me.pntb.TabIndex = 4
        '
        'sntb
        '
        Me.sntb.Location = New System.Drawing.Point(170, 60)
        Me.sntb.MaxLength = 10
        Me.sntb.Name = "sntb"
        Me.sntb.Size = New System.Drawing.Size(68, 20)
        Me.sntb.TabIndex = 1
        '
        'bts
        '
        Me.bts.Location = New System.Drawing.Point(137, 413)
        Me.bts.Name = "bts"
        Me.bts.Size = New System.Drawing.Size(75, 23)
        Me.bts.TabIndex = 10
        Me.bts.Text = "Save"
        Me.bts.UseVisualStyleBackColor = True
        '
        'DOBtp
        '
        Me.DOBtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOBtp.Location = New System.Drawing.Point(170, 199)
        Me.DOBtp.MaxDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.DOBtp.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DOBtp.Name = "DOBtp"
        Me.DOBtp.Size = New System.Drawing.Size(101, 20)
        Me.DOBtp.TabIndex = 5
        Me.DOBtp.Value = New Date(2008, 1, 1, 0, 0, 0, 0)
        '
        'wnp
        '
        Me.wnp.Location = New System.Drawing.Point(170, 248)
        Me.wnp.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.wnp.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.wnp.Name = "wnp"
        Me.wnp.Size = New System.Drawing.Size(57, 20)
        Me.wnp.TabIndex = 6
        Me.wnp.Value = New Decimal(New Integer() {75, 0, 0, 0})
        '
        'hnnp
        '
        Me.hnnp.Location = New System.Drawing.Point(170, 91)
        Me.hnnp.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.hnnp.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.hnnp.Name = "hnnp"
        Me.hnnp.Size = New System.Drawing.Size(68, 20)
        Me.hnnp.TabIndex = 2
        Me.hnnp.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'pctb
        '
        Me.pctb.Location = New System.Drawing.Point(170, 126)
        Me.pctb.Name = "pctb"
        Me.pctb.Size = New System.Drawing.Size(75, 20)
        Me.pctb.TabIndex = 3
        '
        'unl
        '
        Me.unl.AutoSize = True
        Me.unl.Location = New System.Drawing.Point(72, 286)
        Me.unl.Name = "unl"
        Me.unl.Size = New System.Drawing.Size(55, 13)
        Me.unl.TabIndex = 20
        Me.unl.Text = "Username"
        '
        'pwl
        '
        Me.pwl.AutoSize = True
        Me.pwl.Location = New System.Drawing.Point(72, 321)
        Me.pwl.Name = "pwl"
        Me.pwl.Size = New System.Drawing.Size(53, 13)
        Me.pwl.TabIndex = 21
        Me.pwl.Text = "Password"
        '
        'lbcp
        '
        Me.lbcp.AutoSize = True
        Me.lbcp.Location = New System.Drawing.Point(24, 361)
        Me.lbcp.Name = "lbcp"
        Me.lbcp.Size = New System.Drawing.Size(90, 13)
        Me.lbcp.TabIndex = 22
        Me.lbcp.Text = "Confirm password"
        '
        'utb
        '
        Me.utb.Location = New System.Drawing.Point(171, 286)
        Me.utb.Name = "utb"
        Me.utb.Size = New System.Drawing.Size(100, 20)
        Me.utb.TabIndex = 7
        '
        'pwtb
        '
        Me.pwtb.Location = New System.Drawing.Point(170, 321)
        Me.pwtb.Name = "pwtb"
        Me.pwtb.Size = New System.Drawing.Size(100, 20)
        Me.pwtb.TabIndex = 8
        '
        'tbcpw
        '
        Me.tbcpw.Location = New System.Drawing.Point(170, 361)
        Me.tbcpw.Name = "tbcpw"
        Me.tbcpw.Size = New System.Drawing.Size(100, 20)
        Me.tbcpw.TabIndex = 9
        '
        'account
        '
        Me.AcceptButton = Me.bts
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(316, 464)
        Me.Controls.Add(Me.tbcpw)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.pwtb)
        Me.Controls.Add(Me.utb)
        Me.Controls.Add(Me.lbcp)
        Me.Controls.Add(Me.pwl)
        Me.Controls.Add(Me.unl)
        Me.Controls.Add(Me.sntb)
        Me.Controls.Add(Me.hnnp)
        Me.Controls.Add(Me.fnl)
        Me.Controls.Add(Me.bts)
        Me.Controls.Add(Me.snl)
        Me.Controls.Add(Me.wnp)
        Me.Controls.Add(Me.hnl)
        Me.Controls.Add(Me.fntb)
        Me.Controls.Add(Me.DOBtp)
        Me.Controls.Add(Me.pntb)
        Me.Controls.Add(Me.pcl)
        Me.Controls.Add(Me.dofl)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.pctb)
        Me.Controls.Add(Me.wl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "account"
        Me.ShowInTaskbar = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign up"
        CType(Me.wnp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hnnp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents fnl As System.Windows.Forms.Label
    Friend WithEvents snl As System.Windows.Forms.Label
    Friend WithEvents hnl As System.Windows.Forms.Label
    Friend WithEvents pcl As System.Windows.Forms.Label
    Friend WithEvents pnl As System.Windows.Forms.Label
    Friend WithEvents wl As System.Windows.Forms.Label
    Friend WithEvents dofl As System.Windows.Forms.Label
    Friend WithEvents fntb As System.Windows.Forms.TextBox
    Friend WithEvents pntb As System.Windows.Forms.TextBox
    Friend WithEvents sntb As System.Windows.Forms.TextBox
    Friend WithEvents bts As System.Windows.Forms.Button
    Friend WithEvents wnp As System.Windows.Forms.NumericUpDown
    Friend WithEvents hnnp As System.Windows.Forms.NumericUpDown
    Friend WithEvents pctb As System.Windows.Forms.TextBox
    Friend WithEvents unl As System.Windows.Forms.Label
    Friend WithEvents pwl As System.Windows.Forms.Label
    Friend WithEvents lbcp As System.Windows.Forms.Label
    Friend WithEvents utb As System.Windows.Forms.TextBox
    Friend WithEvents pwtb As System.Windows.Forms.TextBox
    Friend WithEvents tbcpw As System.Windows.Forms.TextBox
    Protected WithEvents DOBtp As System.Windows.Forms.DateTimePicker

End Class
