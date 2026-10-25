<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compare
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
        Me.cbatvt = New System.Windows.Forms.ComboBox
        Me.lbsb = New System.Windows.Forms.Label
        Me.cbbsb = New System.Windows.Forms.ComboBox
        Me.grid = New System.Windows.Forms.DataGridView
        Me.btb = New System.Windows.Forms.Button
        Me.lbactivities = New System.Windows.Forms.Label
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbatvt
        '
        Me.cbatvt.FormattingEnabled = True
        Me.cbatvt.Items.AddRange(New Object() {"Running", "Cycling", "Swimming", "Allactivities"})
        Me.cbatvt.Location = New System.Drawing.Point(93, 22)
        Me.cbatvt.Name = "cbatvt"
        Me.cbatvt.Size = New System.Drawing.Size(96, 20)
        Me.cbatvt.TabIndex = 1
        '
        'lbsb
        '
        Me.lbsb.AutoSize = True
        Me.lbsb.Location = New System.Drawing.Point(275, 30)
        Me.lbsb.Name = "lbsb"
        Me.lbsb.Size = New System.Drawing.Size(47, 12)
        Me.lbsb.TabIndex = 2
        Me.lbsb.Text = "Sort by"
        '
        'cbbsb
        '
        Me.cbbsb.FormattingEnabled = True
        Me.cbbsb.Items.AddRange(New Object() {"trainingdate", "RunnerID"})
        Me.cbbsb.Location = New System.Drawing.Point(348, 22)
        Me.cbbsb.Name = "cbbsb"
        Me.cbbsb.Size = New System.Drawing.Size(121, 20)
        Me.cbbsb.TabIndex = 3
        '
        'grid
        '
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(28, 62)
        Me.grid.Name = "grid"
        Me.grid.RowTemplate.Height = 23
        Me.grid.Size = New System.Drawing.Size(488, 192)
        Me.grid.TabIndex = 4
        '
        'btb
        '
        Me.btb.Location = New System.Drawing.Point(441, 262)
        Me.btb.Name = "btb"
        Me.btb.Size = New System.Drawing.Size(75, 23)
        Me.btb.TabIndex = 5
        Me.btb.Text = "Back"
        Me.btb.UseVisualStyleBackColor = True
        '
        'lbactivities
        '
        Me.lbactivities.AutoSize = True
        Me.lbactivities.Location = New System.Drawing.Point(26, 25)
        Me.lbactivities.Name = "lbactivities"
        Me.lbactivities.Size = New System.Drawing.Size(65, 12)
        Me.lbactivities.TabIndex = 6
        Me.lbactivities.Text = "Activities"
        '
        'Compare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 297)
        Me.Controls.Add(Me.lbactivities)
        Me.Controls.Add(Me.btb)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cbbsb)
        Me.Controls.Add(Me.lbsb)
        Me.Controls.Add(Me.cbatvt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Compare"
        Me.ShowInTaskbar = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Compare"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbatvt As System.Windows.Forms.ComboBox
    Friend WithEvents lbsb As System.Windows.Forms.Label
    Friend WithEvents cbbsb As System.Windows.Forms.ComboBox
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents btb As System.Windows.Forms.Button
    Friend WithEvents lbactivities As System.Windows.Forms.Label

End Class
