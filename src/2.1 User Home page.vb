Imports System.Windows.Forms

Public Class UserHome
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btp.Click
        'when the profile button is clicked, the profile form will be shown.
        profile.Show()
        Me.Hide() ' the current username homepage will be hidden
    End Sub

    Private Sub btcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcc.Click
        'when the calories calculator button is clicked, the calories calculator form will be shown.
        cal.Show()
        Me.Hide()

    End Sub


    Private Sub btti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btti.Click

        usertrainingi.Show() 'show trainning information page

        Me.Hide()

    End Sub


    Private Sub btlo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btlo.Click
        'when the log out button is clicked, the signin form will be shown.
        signin.Show()

        Me.Hide()
        'hide the form instead closing the form so the 'formclosing' event won't be activated.
    End Sub


    'form closing event
    Private Sub account_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'as the user can go back to the sign in page by clicking log out button, when the 'x' icon is clicked, the program will be closed
        Application.Exit()
    End Sub

    Private Sub rnid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rnid.Click

    End Sub
End Class
