<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usertrainingi
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
        Me.btant = New System.Windows.Forms.Button
        Me.btcp = New System.Windows.Forms.Button
        Me.grid = New System.Windows.Forms.DataGridView
        Me.btb = New System.Windows.Forms.Button
        Me.btrf = New System.Windows.Forms.Button
        Me.bts = New System.Windows.Forms.Button
        Me.btd = New System.Windows.Forms.Button
        Me.btp = New System.Windows.Forms.Button
        Me.PrintDialog = New System.Windows.Forms.PrintDialog
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btant
        '
        Me.btant.Location = New System.Drawing.Point(65, 355)
        Me.btant.Name = "btant"
        Me.btant.Size = New System.Drawing.Size(75, 41)
        Me.btant.TabIndex = 1
        Me.btant.Text = "Add new training"
        Me.btant.UseVisualStyleBackColor = True
        '
        'btcp
        '
        Me.btcp.Location = New System.Drawing.Point(177, 355)
        Me.btcp.Name = "btcp"
        Me.btcp.Size = New System.Drawing.Size(81, 41)
        Me.btcp.TabIndex = 2
        Me.btcp.Text = "Compare"
        Me.btcp.UseVisualStyleBackColor = True
        '
        'grid
        '
        Me.grid.AllowUserToOrderColumns = True
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(12, 13)
        Me.grid.Name = "grid"
        Me.grid.RowTemplate.Height = 23
        Me.grid.Size = New System.Drawing.Size(767, 323)
        Me.grid.TabIndex = 3
        '
        'btb
        '
        Me.btb.Location = New System.Drawing.Point(674, 355)
        Me.btb.Name = "btb"
        Me.btb.Size = New System.Drawing.Size(79, 41)
        Me.btb.TabIndex = 7
        Me.btb.Text = "Back"
        Me.btb.UseVisualStyleBackColor = True
        '
        'btrf
        '
        Me.btrf.Location = New System.Drawing.Point(528, 366)
        Me.btrf.Name = "btrf"
        Me.btrf.Size = New System.Drawing.Size(75, 23)
        Me.btrf.TabIndex = 5
        Me.btrf.Text = "Refresh"
        Me.btrf.UseVisualStyleBackColor = True
        '
        'bts
        '
        Me.bts.Location = New System.Drawing.Point(291, 355)
        Me.bts.Name = "bts"
        Me.bts.Size = New System.Drawing.Size(88, 41)
        Me.bts.TabIndex = 3
        Me.bts.Text = "STATS"
        Me.bts.UseVisualStyleBackColor = True
        '
        'btd
        '
        Me.btd.Location = New System.Drawing.Point(428, 364)
        Me.btd.Name = "btd"
        Me.btd.Size = New System.Drawing.Size(75, 25)
        Me.btd.TabIndex = 4
        Me.btd.Text = "Delete"
        Me.btd.UseVisualStyleBackColor = True
        '
        'btp
        '
        Me.btp.Location = New System.Drawing.Point(630, 366)
        Me.btp.Name = "btp"
        Me.btp.Size = New System.Drawing.Size(27, 23)
        Me.btp.TabIndex = 6
        Me.btp.Text = "P"
        Me.btp.UseVisualStyleBackColor = True
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'PrintDocument
        '
        '
        'usertrainingi
        '
        Me.AcceptButton = Me.btant
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 434)
        Me.Controls.Add(Me.btp)
        Me.Controls.Add(Me.btd)
        Me.Controls.Add(Me.bts)
        Me.Controls.Add(Me.btrf)
        Me.Controls.Add(Me.btb)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.btcp)
        Me.Controls.Add(Me.btant)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "usertrainingi"
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Training Information(R)"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btant As System.Windows.Forms.Button
    Friend WithEvents btcp As System.Windows.Forms.Button
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents btb As System.Windows.Forms.Button
    Friend WithEvents btrf As System.Windows.Forms.Button
    Friend WithEvents bts As System.Windows.Forms.Button
    Friend WithEvents btd As System.Windows.Forms.Button
    Friend WithEvents btp As System.Windows.Forms.Button
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument As System.Drawing.Printing.PrintDocument

End Class
