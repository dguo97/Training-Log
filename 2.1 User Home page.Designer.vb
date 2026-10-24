<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserHome
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
        Me.btp = New System.Windows.Forms.Button
        Me.btti = New System.Windows.Forms.Button
        Me.btlo = New System.Windows.Forms.Button
        Me.rnid = New System.Windows.Forms.Label
        Me.btcc = New System.Windows.Forms.Button
        Me.lbcp = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btp
        '
        Me.btp.Location = New System.Drawing.Point(27, 55)
        Me.btp.Name = "btp"
        Me.btp.Size = New System.Drawing.Size(75, 25)
        Me.btp.TabIndex = 1
        Me.btp.Text = "Profile"
        Me.btp.UseVisualStyleBackColor = True
        '
        'btti
        '
        Me.btti.Location = New System.Drawing.Point(27, 114)
        Me.btti.Name = "btti"
        Me.btti.Size = New System.Drawing.Size(75, 35)
        Me.btti.TabIndex = 2
        Me.btti.Text = "Training information"
        Me.btti.UseVisualStyleBackColor = True
        '
        'btlo
        '
        Me.btlo.Location = New System.Drawing.Point(27, 228)
        Me.btlo.Name = "btlo"
        Me.btlo.Size = New System.Drawing.Size(75, 25)
        Me.btlo.TabIndex = 4
        Me.btlo.Text = "log out"
        Me.btlo.UseVisualStyleBackColor = True
        '
        'rnid
        '
        Me.rnid.AutoSize = True
        Me.rnid.Location = New System.Drawing.Point(140, 96)
        Me.rnid.Name = "rnid"
        Me.rnid.Size = New System.Drawing.Size(56, 13)
        Me.rnid.TabIndex = 4
        Me.rnid.Text = "Runner ID"
        '
        'btcc
        '
        Me.btcc.Location = New System.Drawing.Point(27, 174)
        Me.btcc.Name = "btcc"
        Me.btcc.Size = New System.Drawing.Size(75, 35)
        Me.btcc.TabIndex = 3
        Me.btcc.Text = "Calories Calc"
        Me.btcc.UseVisualStyleBackColor = True
        '
        'lbcp
        '
        Me.lbcp.AutoSize = True
        Me.lbcp.Location = New System.Drawing.Point(140, 174)
        Me.lbcp.Name = "lbcp"
        Me.lbcp.Size = New System.Drawing.Size(83, 13)
        Me.lbcp.TabIndex = 5
        Me.lbcp.Text = "Current position:"
        '
        'UserHome
        '
        Me.AcceptButton = Me.btti
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 295)
        Me.Controls.Add(Me.lbcp)
        Me.Controls.Add(Me.btcc)
        Me.Controls.Add(Me.rnid)
        Me.Controls.Add(Me.btlo)
        Me.Controls.Add(Me.btti)
        Me.Controls.Add(Me.btp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "UserHome"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Runner Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btp As System.Windows.Forms.Button
    Friend WithEvents btti As System.Windows.Forms.Button
    Friend WithEvents btlo As System.Windows.Forms.Button
    Friend WithEvents rnid As System.Windows.Forms.Label
    Friend WithEvents btcc As System.Windows.Forms.Button
    Friend WithEvents lbcp As System.Windows.Forms.Label

End Class
