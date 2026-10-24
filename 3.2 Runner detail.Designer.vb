<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Runnerdetail
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
        Me.grid = New System.Windows.Forms.DataGridView
        Me.btdl = New System.Windows.Forms.Button
        Me.lbsb = New System.Windows.Forms.Label
        Me.cbbsb = New System.Windows.Forms.ComboBox
        Me.bts = New System.Windows.Forms.Button
        Me.tbs = New System.Windows.Forms.TextBox
        Me.btsa = New System.Windows.Forms.Button
        Me.btb = New System.Windows.Forms.Button
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(10, 44)
        Me.grid.Name = "grid"
        Me.grid.RowTemplate.Height = 23
        Me.grid.Size = New System.Drawing.Size(520, 228)
        Me.grid.TabIndex = 1
        '
        'btdl
        '
        Me.btdl.Location = New System.Drawing.Point(289, 286)
        Me.btdl.Name = "btdl"
        Me.btdl.Size = New System.Drawing.Size(75, 25)
        Me.btdl.TabIndex = 3
        Me.btdl.Text = "Delete"
        Me.btdl.UseVisualStyleBackColor = True
        '
        'lbsb
        '
        Me.lbsb.AutoSize = True
        Me.lbsb.Location = New System.Drawing.Point(40, 286)
        Me.lbsb.Name = "lbsb"
        Me.lbsb.Size = New System.Drawing.Size(40, 13)
        Me.lbsb.TabIndex = 3
        Me.lbsb.Text = "Sort by"
        '
        'cbbsb
        '
        Me.cbbsb.FormattingEnabled = True
        Me.cbbsb.Items.AddRange(New Object() {"RunnerID", "FirstName", "SecondName", "DOB", "Weight", "Runnerusername"})
        Me.cbbsb.Location = New System.Drawing.Point(105, 286)
        Me.cbbsb.Name = "cbbsb"
        Me.cbbsb.Size = New System.Drawing.Size(121, 21)
        Me.cbbsb.TabIndex = 4
        '
        'bts
        '
        Me.bts.Location = New System.Drawing.Point(141, 13)
        Me.bts.Name = "bts"
        Me.bts.Size = New System.Drawing.Size(75, 25)
        Me.bts.TabIndex = 1
        Me.bts.Text = "Search"
        Me.bts.UseVisualStyleBackColor = True
        '
        'tbs
        '
        Me.tbs.Location = New System.Drawing.Point(26, 14)
        Me.tbs.Name = "tbs"
        Me.tbs.Size = New System.Drawing.Size(109, 20)
        Me.tbs.TabIndex = 6
        Me.tbs.Text = "ID or Surname..."
        '
        'btsa
        '
        Me.btsa.Location = New System.Drawing.Point(244, 11)
        Me.btsa.Name = "btsa"
        Me.btsa.Size = New System.Drawing.Size(75, 25)
        Me.btsa.TabIndex = 2
        Me.btsa.Text = "Show all"
        Me.btsa.UseVisualStyleBackColor = True
        '
        'btb
        '
        Me.btb.Location = New System.Drawing.Point(420, 286)
        Me.btb.Name = "btb"
        Me.btb.Size = New System.Drawing.Size(75, 25)
        Me.btb.TabIndex = 4
        Me.btb.Text = "Back"
        Me.btb.UseVisualStyleBackColor = True
        '
        'Runnerdetail
        '
        Me.AcceptButton = Me.bts
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 338)
        Me.Controls.Add(Me.btb)
        Me.Controls.Add(Me.btsa)
        Me.Controls.Add(Me.tbs)
        Me.Controls.Add(Me.bts)
        Me.Controls.Add(Me.cbbsb)
        Me.Controls.Add(Me.lbsb)
        Me.Controls.Add(Me.btdl)
        Me.Controls.Add(Me.grid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Runnerdetail"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Runner detail"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents btdl As System.Windows.Forms.Button
    Friend WithEvents lbsb As System.Windows.Forms.Label
    Friend WithEvents cbbsb As System.Windows.Forms.ComboBox
    Friend WithEvents bts As System.Windows.Forms.Button
    Friend WithEvents tbs As System.Windows.Forms.TextBox
    Friend WithEvents btsa As System.Windows.Forms.Button
    Friend WithEvents btb As System.Windows.Forms.Button

End Class
