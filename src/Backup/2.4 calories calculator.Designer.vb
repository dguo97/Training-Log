<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cal
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
        Me.btb = New System.Windows.Forms.Button
        Me.stn = New System.Windows.Forms.NumericUpDown
        Me.swcb = New System.Windows.Forms.ComboBox
        Me.cl = New System.Windows.Forms.Label
        Me.ctn = New System.Windows.Forms.NumericUpDown
        Me.cscb = New System.Windows.Forms.ComboBox
        Me.swl = New System.Windows.Forms.Label
        Me.tl = New System.Windows.Forms.Label
        Me.rtn = New System.Windows.Forms.NumericUpDown
        Me.rl = New System.Windows.Forms.Label
        Me.sl = New System.Windows.Forms.Label
        Me.rscb = New System.Windows.Forms.ComboBox
        Me.npw = New System.Windows.Forms.NumericUpDown
        Me.LBW = New System.Windows.Forms.Label
        Me.styl = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.stn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ctn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btb, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(157, 271)
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
        'btb
        '
        Me.btb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btb.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btb.Location = New System.Drawing.Point(76, 3)
        Me.btb.Name = "btb"
        Me.btb.Size = New System.Drawing.Size(67, 21)
        Me.btb.TabIndex = 1
        Me.btb.Text = "Back"
        '
        'stn
        '
        Me.stn.DecimalPlaces = 1
        Me.stn.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.stn.Location = New System.Drawing.Point(211, 165)
        Me.stn.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.stn.Name = "stn"
        Me.stn.Size = New System.Drawing.Size(82, 21)
        Me.stn.TabIndex = 25
        '
        'swcb
        '
        Me.swcb.AllowDrop = True
        Me.swcb.FormattingEnabled = True
        Me.swcb.Items.AddRange(New Object() {"Freestyle, slow", "Freestyle, fast", "Backstroke", "Breaststroke", "Butterfly"})
        Me.swcb.Location = New System.Drawing.Point(93, 164)
        Me.swcb.Name = "swcb"
        Me.swcb.Size = New System.Drawing.Size(95, 20)
        Me.swcb.TabIndex = 24
        '
        'cl
        '
        Me.cl.AutoSize = True
        Me.cl.Location = New System.Drawing.Point(30, 105)
        Me.cl.Name = "cl"
        Me.cl.Size = New System.Drawing.Size(47, 12)
        Me.cl.TabIndex = 23
        Me.cl.Text = "Cycling"
        '
        'ctn
        '
        Me.ctn.DecimalPlaces = 1
        Me.ctn.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.ctn.Location = New System.Drawing.Point(211, 98)
        Me.ctn.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.ctn.Name = "ctn"
        Me.ctn.Size = New System.Drawing.Size(82, 21)
        Me.ctn.TabIndex = 22
        '
        'cscb
        '
        Me.cscb.AllowDrop = True
        Me.cscb.FormattingEnabled = True
        Me.cscb.Items.AddRange(New Object() {"<10 mph, Leisure cycling", "10 -11.9 mph, gentle,", "12 -13.9 mph, moderate", "14 -15.9 mph, vigorous", "16 -20 mph, very fast", ">20mph, racing"})
        Me.cscb.Location = New System.Drawing.Point(93, 98)
        Me.cscb.Name = "cscb"
        Me.cscb.Size = New System.Drawing.Size(95, 20)
        Me.cscb.TabIndex = 21
        '
        'swl
        '
        Me.swl.AutoSize = True
        Me.swl.Location = New System.Drawing.Point(18, 164)
        Me.swl.Name = "swl"
        Me.swl.Size = New System.Drawing.Size(53, 12)
        Me.swl.TabIndex = 20
        Me.swl.Text = "swimming"
        '
        'tl
        '
        Me.tl.AutoSize = True
        Me.tl.Location = New System.Drawing.Point(211, 22)
        Me.tl.Name = "tl"
        Me.tl.Size = New System.Drawing.Size(41, 12)
        Me.tl.TabIndex = 19
        Me.tl.Text = "Time/h"
        '
        'rtn
        '
        Me.rtn.DecimalPlaces = 1
        Me.rtn.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.rtn.Location = New System.Drawing.Point(211, 46)
        Me.rtn.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.rtn.Name = "rtn"
        Me.rtn.Size = New System.Drawing.Size(82, 21)
        Me.rtn.TabIndex = 18
        '
        'rl
        '
        Me.rl.AutoSize = True
        Me.rl.Location = New System.Drawing.Point(23, 54)
        Me.rl.Name = "rl"
        Me.rl.Size = New System.Drawing.Size(47, 12)
        Me.rl.TabIndex = 17
        Me.rl.Text = "Running"
        '
        'sl
        '
        Me.sl.AutoSize = True
        Me.sl.Location = New System.Drawing.Point(113, 23)
        Me.sl.Name = "sl"
        Me.sl.Size = New System.Drawing.Size(35, 12)
        Me.sl.TabIndex = 16
        Me.sl.Text = "Speed"
        '
        'rscb
        '
        Me.rscb.AllowDrop = True
        Me.rscb.FormattingEnabled = True
        Me.rscb.Items.AddRange(New Object() {"5 mph (12 minute mile)", "6 mph (10 minute mile)", "7mph(8.5 minute mile)", "8mph(7.5 minute mile)", "9mph(6.5 minute mile)", "10 mph (6 minute mile)"})
        Me.rscb.Location = New System.Drawing.Point(93, 46)
        Me.rscb.Name = "rscb"
        Me.rscb.Size = New System.Drawing.Size(95, 20)
        Me.rscb.TabIndex = 15
        '
        'npw
        '
        Me.npw.Location = New System.Drawing.Point(93, 226)
        Me.npw.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.npw.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.npw.Name = "npw"
        Me.npw.Size = New System.Drawing.Size(55, 21)
        Me.npw.TabIndex = 26
        Me.npw.Value = New Decimal(New Integer() {75, 0, 0, 0})
        '
        'LBW
        '
        Me.LBW.AutoSize = True
        Me.LBW.Location = New System.Drawing.Point(32, 234)
        Me.LBW.Name = "LBW"
        Me.LBW.Size = New System.Drawing.Size(41, 12)
        Me.LBW.TabIndex = 27
        Me.LBW.Text = "Weight"
        '
        'styl
        '
        Me.styl.AutoSize = True
        Me.styl.Location = New System.Drawing.Point(113, 135)
        Me.styl.Name = "styl"
        Me.styl.Size = New System.Drawing.Size(35, 12)
        Me.styl.TabIndex = 28
        Me.styl.Text = "Style"
        '
        'cal
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btb
        Me.ClientSize = New System.Drawing.Size(315, 309)
        Me.Controls.Add(Me.styl)
        Me.Controls.Add(Me.LBW)
        Me.Controls.Add(Me.npw)
        Me.Controls.Add(Me.stn)
        Me.Controls.Add(Me.swcb)
        Me.Controls.Add(Me.cl)
        Me.Controls.Add(Me.ctn)
        Me.Controls.Add(Me.cscb)
        Me.Controls.Add(Me.swl)
        Me.Controls.Add(Me.tl)
        Me.Controls.Add(Me.rtn)
        Me.Controls.Add(Me.rl)
        Me.Controls.Add(Me.sl)
        Me.Controls.Add(Me.rscb)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cal"
        Me.ShowInTaskbar = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calories Calculator"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.stn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ctn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents btb As System.Windows.Forms.Button
    Friend WithEvents stn As System.Windows.Forms.NumericUpDown
    Friend WithEvents swcb As System.Windows.Forms.ComboBox
    Friend WithEvents cl As System.Windows.Forms.Label
    Friend WithEvents ctn As System.Windows.Forms.NumericUpDown
    Friend WithEvents cscb As System.Windows.Forms.ComboBox
    Friend WithEvents swl As System.Windows.Forms.Label
    Friend WithEvents tl As System.Windows.Forms.Label
    Friend WithEvents rtn As System.Windows.Forms.NumericUpDown
    Friend WithEvents rl As System.Windows.Forms.Label
    Friend WithEvents sl As System.Windows.Forms.Label
    Friend WithEvents rscb As System.Windows.Forms.ComboBox
    Friend WithEvents npw As System.Windows.Forms.NumericUpDown
    Friend WithEvents LBW As System.Windows.Forms.Label
    Friend WithEvents styl As System.Windows.Forms.Label

End Class
