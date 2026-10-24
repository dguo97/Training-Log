<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class workingout
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.rscb = New System.Windows.Forms.ComboBox
        Me.dtp = New System.Windows.Forms.DateTimePicker
        Me.dtl = New System.Windows.Forms.Label
        Me.sl = New System.Windows.Forms.Label
        Me.rl = New System.Windows.Forms.Label
        Me.rtn = New System.Windows.Forms.NumericUpDown
        Me.tl = New System.Windows.Forms.Label
        Me.swl = New System.Windows.Forms.Label
        Me.cscb = New System.Windows.Forms.ComboBox
        Me.ctn = New System.Windows.Forms.NumericUpDown
        Me.cl = New System.Windows.Forms.Label
        Me.styl = New System.Windows.Forms.Label
        Me.swcb = New System.Windows.Forms.ComboBox
        Me.stn = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.IDl = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.rtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ctn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(171, 249)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 27)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 21)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 21)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'rscb
        '
        Me.rscb.AllowDrop = True
        Me.rscb.FormattingEnabled = True
        Me.rscb.Items.AddRange(New Object() {"5 mph (12 minute mile)", "6 mph (10 minute mile)", "7mph(8.5 minute mile)", "8mph(7.5 minute mile)", "9mph(6.5 minute mile)", "10 mph (6 minute mile)"})
        Me.rscb.Location = New System.Drawing.Point(94, 90)
        Me.rscb.Name = "rscb"
        Me.rscb.Size = New System.Drawing.Size(95, 20)
        Me.rscb.TabIndex = 1
        '
        'dtp
        '
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp.Location = New System.Drawing.Point(222, 22)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(95, 21)
        Me.dtp.TabIndex = 2
        '
        'dtl
        '
        Me.dtl.AutoSize = True
        Me.dtl.Location = New System.Drawing.Point(172, 26)
        Me.dtl.Name = "dtl"
        Me.dtl.Size = New System.Drawing.Size(29, 12)
        Me.dtl.TabIndex = 3
        Me.dtl.Text = "Date"
        '
        'sl
        '
        Me.sl.AutoSize = True
        Me.sl.Location = New System.Drawing.Point(114, 67)
        Me.sl.Name = "sl"
        Me.sl.Size = New System.Drawing.Size(35, 12)
        Me.sl.TabIndex = 4
        Me.sl.Text = "Speed"
        '
        'rl
        '
        Me.rl.AutoSize = True
        Me.rl.Location = New System.Drawing.Point(24, 98)
        Me.rl.Name = "rl"
        Me.rl.Size = New System.Drawing.Size(47, 12)
        Me.rl.TabIndex = 5
        Me.rl.Text = "Running"
        '
        'rtn
        '
        Me.rtn.DecimalPlaces = 1
        Me.rtn.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.rtn.Location = New System.Drawing.Point(212, 90)
        Me.rtn.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.rtn.Name = "rtn"
        Me.rtn.Size = New System.Drawing.Size(82, 21)
        Me.rtn.TabIndex = 6
        '
        'tl
        '
        Me.tl.AutoSize = True
        Me.tl.Location = New System.Drawing.Point(212, 66)
        Me.tl.Name = "tl"
        Me.tl.Size = New System.Drawing.Size(41, 12)
        Me.tl.TabIndex = 7
        Me.tl.Text = "Time/h"
        '
        'swl
        '
        Me.swl.AutoSize = True
        Me.swl.Location = New System.Drawing.Point(18, 208)
        Me.swl.Name = "swl"
        Me.swl.Size = New System.Drawing.Size(53, 12)
        Me.swl.TabIndex = 8
        Me.swl.Text = "swimming"
        '
        'cscb
        '
        Me.cscb.AllowDrop = True
        Me.cscb.FormattingEnabled = True
        Me.cscb.Items.AddRange(New Object() {"<10 mph, Leisure cycling", "10 -11.9 mph, gentle,", "12 -13.9 mph, moderate", "14 -15.9 mph, vigorous", "16 -20 mph, very fast", ">20mph, racing"})
        Me.cscb.Location = New System.Drawing.Point(94, 142)
        Me.cscb.Name = "cscb"
        Me.cscb.Size = New System.Drawing.Size(95, 20)
        Me.cscb.TabIndex = 9
        '
        'ctn
        '
        Me.ctn.DecimalPlaces = 1
        Me.ctn.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.ctn.Location = New System.Drawing.Point(212, 142)
        Me.ctn.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.ctn.Name = "ctn"
        Me.ctn.Size = New System.Drawing.Size(82, 21)
        Me.ctn.TabIndex = 10
        '
        'cl
        '
        Me.cl.AutoSize = True
        Me.cl.Location = New System.Drawing.Point(24, 150)
        Me.cl.Name = "cl"
        Me.cl.Size = New System.Drawing.Size(47, 12)
        Me.cl.TabIndex = 11
        Me.cl.Text = "Cycling"
        '
        'styl
        '
        Me.styl.AutoSize = True
        Me.styl.Location = New System.Drawing.Point(112, 185)
        Me.styl.Name = "styl"
        Me.styl.Size = New System.Drawing.Size(35, 12)
        Me.styl.TabIndex = 12
        Me.styl.Text = "Style"
        '
        'swcb
        '
        Me.swcb.AllowDrop = True
        Me.swcb.FormattingEnabled = True
        Me.swcb.Items.AddRange(New Object() {"Freestyle, slow", "Freestyle, fast", "Backstroke", "Breaststroke", "Butterfly"})
        Me.swcb.Location = New System.Drawing.Point(94, 208)
        Me.swcb.Name = "swcb"
        Me.swcb.Size = New System.Drawing.Size(95, 20)
        Me.swcb.TabIndex = 13
        '
        'stn
        '
        Me.stn.DecimalPlaces = 1
        Me.stn.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.stn.Location = New System.Drawing.Point(212, 209)
        Me.stn.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.stn.Name = "stn"
        Me.stn.Size = New System.Drawing.Size(82, 21)
        Me.stn.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 12)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ID:"
        '
        'IDl
        '
        Me.IDl.AutoSize = True
        Me.IDl.Location = New System.Drawing.Point(82, 35)
        Me.IDl.Name = "IDl"
        Me.IDl.Size = New System.Drawing.Size(0, 12)
        Me.IDl.TabIndex = 17
        '
        'workingout
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(329, 288)
        Me.Controls.Add(Me.IDl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.stn)
        Me.Controls.Add(Me.swcb)
        Me.Controls.Add(Me.styl)
        Me.Controls.Add(Me.cl)
        Me.Controls.Add(Me.ctn)
        Me.Controls.Add(Me.cscb)
        Me.Controls.Add(Me.swl)
        Me.Controls.Add(Me.tl)
        Me.Controls.Add(Me.rtn)
        Me.Controls.Add(Me.rl)
        Me.Controls.Add(Me.sl)
        Me.Controls.Add(Me.dtl)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.rscb)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "workingout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New training"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.rtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ctn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents rscb As System.Windows.Forms.ComboBox
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtl As System.Windows.Forms.Label
    Friend WithEvents sl As System.Windows.Forms.Label
    Friend WithEvents rl As System.Windows.Forms.Label
    Friend WithEvents rtn As System.Windows.Forms.NumericUpDown
    Friend WithEvents tl As System.Windows.Forms.Label
    Friend WithEvents swl As System.Windows.Forms.Label
    Friend WithEvents cscb As System.Windows.Forms.ComboBox
    Friend WithEvents ctn As System.Windows.Forms.NumericUpDown
    Friend WithEvents cl As System.Windows.Forms.Label
    Friend WithEvents styl As System.Windows.Forms.Label
    Friend WithEvents swcb As System.Windows.Forms.ComboBox
    Friend WithEvents stn As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IDl As System.Windows.Forms.Label

End Class
