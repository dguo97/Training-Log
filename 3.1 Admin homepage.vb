Imports System.Windows.Forms
'this form has the similar code as user home page
Public Class Adminhome



    Private Sub btrd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btrd.Click
        Runnerdetail.Show() 'show the runnerdetail form

        Me.Hide() 'hide the admin homepage

    End Sub

    Private Sub btti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btti.Click
        atrainingi.Show()

        Me.Hide()

    End Sub

    Private Sub btr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btr.Click
        racedatabase.Show()

        Me.Hide()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btb.Click
        signin.Show()

        Me.Hide()


    End Sub



    Private Sub accountFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'exit the program
        Application.Exit()



    End Sub



End Class
