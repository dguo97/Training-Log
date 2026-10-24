<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class atrainingi
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
        Me.cbbsb = New System.Windows.Forms.ComboBox
        Me.lbsb = New System.Windows.Forms.Label
        Me.grid = New System.Windows.Forms.DataGridView
        Me.btb = New System.Windows.Forms.Button
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbbsb
        '
        Me.cbbsb.FormattingEnabled = True
        Me.cbbsb.Items.AddRange(New Object() {"trainingdate", "RunnerID", "caloriesburned"})
        Me.cbbsb.Location = New System.Drawing.Point(108, 231)
        Me.cbbsb.Name = "cbbsb"
        Me.cbbsb.Size = New System.Drawing.Size(121, 20)
        Me.cbbsb.TabIndex = 8
        '
        'lbsb
        '
        Me.lbsb.AutoSize = True
        Me.lbsb.Location = New System.Drawing.Point(28, 231)
        Me.lbsb.Name = "lbsb"
        Me.lbsb.Size = New System.Drawing.Size(47, 12)
        Me.lbsb.TabIndex = 7
        Me.lbsb.Text = "Sort by"
        '
        'grid
        '
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(12, 24)
        Me.grid.Name = "grid"
        Me.grid.RowTemplate.Height = 23
        Me.grid.Size = New System.Drawing.Size(435, 182)
        Me.grid.TabIndex = 5
        '
        'btb
        '
        Me.btb.Location = New System.Drawing.Point(361, 231)
        Me.btb.Name = "btb"
        Me.btb.Size = New System.Drawing.Size(75, 21)
        Me.btb.TabIndex = 9
        Me.btb.Text = "Back"
        Me.btb.UseVisualStyleBackColor = True
        '
        'atrainingi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 271)
        Me.Controls.Add(Me.btb)
        Me.Controls.Add(Me.cbbsb)
        Me.Controls.Add(Me.lbsb)
        Me.Controls.Add(Me.grid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "atrainingi"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Training Information (A)"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbbsb As System.Windows.Forms.ComboBox
    Friend WithEvents lbsb As System.Windows.Forms.Label
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents btb As System.Windows.Forms.Button

End Class
