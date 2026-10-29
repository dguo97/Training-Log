<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class racedatabase
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
        Me.btst = New System.Windows.Forms.Button
        Me.btb = New System.Windows.Forms.Button
        Me.btanr = New System.Windows.Forms.Button
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.AllowUserToOrderColumns = True
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(23, 2)
        Me.grid.Name = "grid"
        Me.grid.RowTemplate.Height = 23
        Me.grid.Size = New System.Drawing.Size(679, 401)
        Me.grid.TabIndex = 5
        '
        'btst
        '
        Me.btst.Location = New System.Drawing.Point(722, 145)
        Me.btst.Name = "btst"
        Me.btst.Size = New System.Drawing.Size(75, 38)
        Me.btst.TabIndex = 6
        Me.btst.Text = "Select team"
        Me.btst.UseVisualStyleBackColor = True
        '
        'btb
        '
        Me.btb.Location = New System.Drawing.Point(722, 268)
        Me.btb.Name = "btb"
        Me.btb.Size = New System.Drawing.Size(75, 25)
        Me.btb.TabIndex = 7
        Me.btb.Text = "Back"
        Me.btb.UseVisualStyleBackColor = True
        '
        'btanr
        '
        Me.btanr.Location = New System.Drawing.Point(722, 52)
        Me.btanr.Name = "btanr"
        Me.btanr.Size = New System.Drawing.Size(75, 41)
        Me.btanr.TabIndex = 8
        Me.btanr.Text = "Add new race"
        Me.btanr.UseVisualStyleBackColor = True
        '
        'racedatabase
        '
        Me.AcceptButton = Me.btst
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 429)
        Me.Controls.Add(Me.btanr)
        Me.Controls.Add(Me.btb)
        Me.Controls.Add(Me.btst)
        Me.Controls.Add(Me.grid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "racedatabase"
        Me.ShowInTaskbar = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Race"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents btst As System.Windows.Forms.Button
    Friend WithEvents btb As System.Windows.Forms.Button
    Friend WithEvents btanr As System.Windows.Forms.Button

End Class
