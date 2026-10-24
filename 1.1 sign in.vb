Imports System.Windows.Forms
Imports System.Data.OleDb

Public Class signin
    Dim dblo As String = (System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Database.accdb")) 'Find the location of the Access database 
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dblo)
    Dim adp As New OleDb.OleDbDataAdapter("SELECT * FROM adminpassword", con)
    Dim datat As New DataTable
    Dim cb As New OleDbCommandBuilder(adp)
    Dim adminpassword As String
    Dim runnerid As String = Nothing
    Dim Currentposition As String = Nothing


    Private Sub signin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        adp.Fill(datat)
        If datat.Rows.Count = 1 Then
            adminpassword = datat.Rows(0).Item(0)
        End If
    End Sub


    Private Sub sib_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sib.Click


        con.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM persondetail WHERE Runnerusername=@usr", con)
        'create a query to find all of the identical usenames
        cmd.Parameters.AddWithValue("@usr", untb.Text)
        'insert the username to search for into the query
        Dim reader As OleDbDataReader = cmd.ExecuteReader
        'search
        Dim usernameExists As Boolean = reader.Read()
        'true if there's an identical username

        If usernameExists = False Then 'if the usernaeme doesn't exist, an error message will be shown
            MsgBox("Username doesn't exist")
        Else
            ' retreive the password with the username
            Dim cmd2 As New OleDbCommand("SELECT Runnerpassword FROM persondetail WHERE Runnerusername=@usr", con)
            cmd2.Parameters.AddWithValue("@usr", untb.Text)

            'insert the username to search for into the query
            Dim reader2 As OleDbDataReader = cmd2.ExecuteReader
            'search
            Dim pw As String = Nothing

            While reader2.Read()

                pw = reader2(0)

            End While


            If Not pwtx.Text = pw Then 'if the password doesn't match

                MsgBox("Wrong password")
            Else
                'retreive the RunerID

                Dim cmd3 As New OleDbCommand("SELECT RunnerID FROM persondetail WHERE Runnerusername=@usr", con)
                cmd3.Parameters.AddWithValue("@usr", untb.Text)

                'insert the username to search for into the query
                Dim reader3 As OleDbDataReader = cmd3.ExecuteReader
                'search


                While reader3.Read()

                    runnerid = reader3(0)

                End While

                ' Show runner ID on user homepage
                UserHome.rnid.Text = runnerid



                showranking() 'retrieve the runner's ranking

                UserHome.lbcp.Text = "Current position:" & Currentposition


                UserHome.Show()



                Me.Close()
            End If
        End If




        con.Close()
    End Sub


    Private Sub showranking()
        adp.SelectCommand.CommandText = "SELECT * FROM ranking where runnerid =" & runnerid
        datat.Clear()
        adp.Fill(datat)
        If datat.Rows(0).Item("runnerposition") IsNot DBNull.Value Then
            Currentposition = datat.Rows(0).Item("runnerposition")
        End If


    End Sub
    Private Sub subt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subt.Click

        account.Show()

        Me.Close()

    End Sub




    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPageA.Enter
        If adminpassword = Nothing Then 'check whether the admin's password has been set or not
            Do While adminpassword = ("")

                adminpassword = InputBox("please set admin's password").ToString 'show an input to ask user to input/set admin's password
                If adminpassword = ("") Then 'keep requesting until the password is set
                    MessageBox.Show(" you have to set the admin password")
                End If
            Loop

            'add admin's password to database
            datat.Rows.Add(adminpassword)
            adp.Update(datat)

        End If
    End Sub


    Private Sub TabPage2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPageA.Enter
        Me.AcceptButton = btali 'change accept button to admin login button


    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPageR.Enter
        Me.AcceptButton = sib 'change accept button to runner sign in button
    End Sub

    Private Sub btali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btali.Click
        'check if the password enter is correct.
        If adminpassword = tbsp.Text Then
            Adminhome.Show()
            Me.Close()

        ElseIf Not adminpassword = tbsp.Text Then
            MessageBox.Show("Incorrect password")
        End If
    End Sub

    Private Sub tbsp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbsp.TextChanged

    End Sub

    Private Sub lbcp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbcp.Click
        'if admin click change password label
        If InputBox("please enter old password") = adminpassword Then
            Dim np As String = InputBox("please enter the new password")
            If Not np = Nothing Then
                datat.Rows(0).Item(0) = np 'if nothing is inputed, the password will keep the same
                adminpassword = np
            Else
                MessageBox.Show("Password not changed")
            End If
        Else
            MessageBox.Show("Wrong password")
        End If


    End Sub

    Private Sub signin_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'when the user re-open this page, all the text input wil be cleared.
        untb.Text = Nothing
        pwtx.Text = Nothing
        tbsp.Text = Nothing

    End Sub

End Class
