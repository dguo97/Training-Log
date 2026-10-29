<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adminhome
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
        Me.btrd = New System.Windows.Forms.Button
        Me.btti = New System.Windows.Forms.Button
        Me.btr = New System.Windows.Forms.Button
        Me.btb = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btrd
        '
        Me.btrd.Location = New System.Drawing.Point(33, 32)
        Me.btrd.Name = "btrd"
        Me.btrd.Size = New System.Drawing.Size(138, 33)
        Me.btrd.TabIndex = 1
        Me.btrd.Text = "Runners' detail"
        Me.btrd.UseVisualStyleBackColor = True
        '
        'btti
        '
        Me.btti.Location = New System.Drawing.Point(33, 90)
        Me.btti.Name = "btti"
        Me.btti.Size = New System.Drawing.Size(138, 34)
        Me.btti.TabIndex = 2
        Me.btti.Text = "Training information"
        Me.btti.UseVisualStyleBackColor = True
        '
        'btr
        '
        Me.btr.Location = New System.Drawing.Point(33, 149)
        Me.btr.Name = "btr"
        Me.btr.Size = New System.Drawing.Size(138, 40)
        Me.btr.TabIndex = 3
        Me.btr.Text = "Race&_Select team"
        Me.btr.UseVisualStyleBackColor = True
        '
        'btb
        '
        Me.btb.Location = New System.Drawing.Point(33, 214)
        Me.btb.Name = "btb"
        Me.btb.Size = New System.Drawing.Size(138, 37)
        Me.btb.TabIndex = 4
        Me.btb.Text = "Back"
        Me.btb.UseVisualStyleBackColor = True
        '
        'Adminhome
        '
        Me.AcceptButton = Me.btr
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(205, 291)
        Me.Controls.Add(Me.btb)
        Me.Controls.Add(Me.btr)
        Me.Controls.Add(Me.btti)
        Me.Controls.Add(Me.btrd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Adminhome"
        Me.ShowInTaskbar = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Home"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btrd As System.Windows.Forms.Button
    Friend WithEvents btti As System.Windows.Forms.Button
    Friend WithEvents btb As System.Windows.Forms.Button
    Friend WithEvents btr As System.Windows.Forms.Button

End Class
