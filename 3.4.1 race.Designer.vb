<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class race
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
        Me.RunnerID = New System.Windows.Forms.ListBox
        Me.rankinglist = New System.Windows.Forms.ListBox
        Me.lbrankinglist = New System.Windows.Forms.Label
        Me.lbRunnerid = New System.Windows.Forms.Label
        Me.Positionlist = New System.Windows.Forms.ListBox
        Me.bts = New System.Windows.Forms.Button
        Me.btc = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'RunnerID
        '
        Me.RunnerID.FormattingEnabled = True
        Me.RunnerID.ItemHeight = 12
        Me.RunnerID.Location = New System.Drawing.Point(244, 55)
        Me.RunnerID.Name = "RunnerID"
        Me.RunnerID.Size = New System.Drawing.Size(120, 172)
        Me.RunnerID.TabIndex = 1
        '
        'rankinglist
        '
        Me.rankinglist.FormattingEnabled = True
        Me.rankinglist.ItemHeight = 12
        Me.rankinglist.Location = New System.Drawing.Point(84, 55)
        Me.rankinglist.Name = "rankinglist"
        Me.rankinglist.Size = New System.Drawing.Size(101, 172)
        Me.rankinglist.TabIndex = 2
        '
        'lbrankinglist
        '
        Me.lbrankinglist.AutoSize = True
        Me.lbrankinglist.Location = New System.Drawing.Point(97, 20)
        Me.lbrankinglist.Name = "lbrankinglist"
        Me.lbrankinglist.Size = New System.Drawing.Size(71, 12)
        Me.lbrankinglist.TabIndex = 3
        Me.lbrankinglist.Text = "rankinglist"
        '
        'lbRunnerid
        '
        Me.lbRunnerid.AutoSize = True
        Me.lbRunnerid.Location = New System.Drawing.Point(278, 32)
        Me.lbRunnerid.Name = "lbRunnerid"
        Me.lbRunnerid.Size = New System.Drawing.Size(53, 12)
        Me.lbRunnerid.TabIndex = 4
        Me.lbRunnerid.Text = "RunnerID"
        '
        'Positionlist
        '
        Me.Positionlist.FormattingEnabled = True
        Me.Positionlist.ItemHeight = 12
        Me.Positionlist.Location = New System.Drawing.Point(17, 55)
        Me.Positionlist.Name = "Positionlist"
        Me.Positionlist.Size = New System.Drawing.Size(45, 172)
        Me.Positionlist.TabIndex = 5
        '
        'bts
        '
        Me.bts.Location = New System.Drawing.Point(205, 263)
        Me.bts.Name = "bts"
        Me.bts.Size = New System.Drawing.Size(75, 23)
        Me.bts.TabIndex = 6
        Me.bts.Text = "&Save"
        Me.bts.UseVisualStyleBackColor = True
        '
        'btc
        '
        Me.btc.Location = New System.Drawing.Point(289, 263)
        Me.btc.Name = "btc"
        Me.btc.Size = New System.Drawing.Size(75, 23)
        Me.btc.TabIndex = 10
        Me.btc.Text = "Cancel"
        Me.btc.UseVisualStyleBackColor = True
        '
        'race
        '
        Me.AcceptButton = Me.bts
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 304)
        Me.Controls.Add(Me.btc)
        Me.Controls.Add(Me.bts)
        Me.Controls.Add(Me.Positionlist)
        Me.Controls.Add(Me.lbRunnerid)
        Me.Controls.Add(Me.lbrankinglist)
        Me.Controls.Add(Me.rankinglist)
        Me.Controls.Add(Me.RunnerID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "race"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Race"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RunnerID As System.Windows.Forms.ListBox
    Friend WithEvents rankinglist As System.Windows.Forms.ListBox
    Friend WithEvents lbrankinglist As System.Windows.Forms.Label
    Friend WithEvents lbRunnerid As System.Windows.Forms.Label
    Friend WithEvents Positionlist As System.Windows.Forms.ListBox
    Friend WithEvents bts As System.Windows.Forms.Button
    Friend WithEvents btc As System.Windows.Forms.Button

End Class
