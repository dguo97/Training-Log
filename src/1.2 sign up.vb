Imports System.Windows.Forms
Imports System.Data.OleDb

Public Class account
    Dim dblo As String = (System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Database.accdb")) 'Find the location of the Access database 
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dblo) 'create the connection to the database 
    Dim id As Integer



    Private Sub dbopen() 'procedure open the connection 
        con.Open()
    End Sub

    Private Sub dbclose() 'procedure close the connection
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bts.Click
        Dim em As String = "Error" 'dim a string which contain all the error messages.
        Dim i As Integer = 0
        'First name verfication
        If fntb.Text.Length < 2 Then 'name should not contain digits or be less than three charaters
            em = em & vbNewLine & "first name needs to contain at least two letters" 'error message will add to the string if data entered is not valid


            fntb.BackColor = Color.DarkRed ' and the textbox colour will change to red


        Else

            Do
                i = i + 1
                If Not Char.IsLetter(fntb.Text.Chars(i)) Then
                    em = em & vbNewLine & "first name can't contain digits"
                    fntb.BackColor = Color.DarkRed
                End If

            Loop Until Char.IsDigit(fntb.Text.Chars(i)) = True Or i = fntb.Text.Length - 1
        End If

        'Second name verfication
        If sntb.Text.Length < 2 Then

            em = em & vbNewLine & "second name needs to contain at least two letters"
            sntb.BackColor = Color.DarkRed

        Else
            i = 0
            Do

                i = i + 1
                If Not Char.IsLetter(sntb.Text.Chars(i)) Then
                    em = em & vbNewLine & "second name can't contain digits"
                    sntb.BackColor = Color.DarkRed
                End If

            Loop Until Char.IsDigit(sntb.Text.Chars(i)) = True Or i = sntb.Text.Length - 1
        

        End If

        'phone number verification
        If Not pntb.Text Like "0##########" Then 'phone number should contaion 11 digits and starts with 0
            em = em & vbNewLine & "phone number needs to contain 11 digits and begin with 0"
            pntb.BackColor = Color.DarkRed
        End If


        pctb.Text = pctb.Text.ToUpper() 'capitalise the text in the postcide database
        'postcode code verfication
        If (pctb.Text.Length = 7 And Not pctb.Text Like "[A-Z][A-Z]# #[A-Z][A-Z]") Or (pctb.Text.Length = 8 And Not pctb.Text Like "[A-Z][A-Z]## #[A-Z][A-Z]") Or pctb.Text.Length < 7 Then
            'post code should be LLD DLL or LLDD DLL. L=letter, D=digit
            em = em & vbNewLine & "Please enter the correct post code format: 'LLD DLL' or 'LLDD DLL'. L=letter, D=digit"
            pctb.BackColor = Color.DarkRed
        End If

        utb.Text = Trim(utb.Text) 'trim the text in username textbox, i.e. remove all the space
        If utb.Text = "" Then 'check if the username is empty
            em = em & vbNewLine & "Username can't be empty"
        Else


            'check if username exits
            con.Open()
            Dim cmd As New OleDbCommand("SELECT * FROM persondetail WHERE Runnerusername=@usr", con)
            'create a query to find all of the identical usenames
            cmd.Parameters.AddWithValue("@usr", utb.Text)
            'insert the username to search for into the query
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            'search
            Dim usernameExists As Boolean = reader.Read()
            'true if there's an identical username
            If usernameExists = True Then

                em = em & vbNewLine & "Username already exists"
                utb.BackColor = Color.DarkRed
            End If
            con.Close()


        End If


        'passsword verfication

        If Not pwtb.Text = tbcpw.Text Then
            em = em & vbNewLine & "passwords don't match" 'the password should mathch confirm password' text
            tbcpw.BackColor = Color.DarkRed
        ElseIf tbcpw.Text.Length < 4 Then
            em = em & vbNewLine & "passwords need to contain at least 4 characters"
            pwtb.BackColor = Color.DarkRed
            tbcpw.BackColor = Color.DarkRed

        End If



        If Not em = "Error" Then
            MessageBox.Show(em) 'error message will show if the em string contains the error message
        Else 'else, it will add record to the database



            dbopen() 'open the connection
            Dim datat As New DataTable 'bulild a datatable in VB
            Dim adp As New OleDb.OleDbDataAdapter("SELECT * FROM persondetail", con) 'build an adapter so the database in Access can be reteived
            Dim cb As New OleDbCommandBuilder(adp) 'create an adapter to adapt data on Access
            adp.Fill(datat) 'fill the datatable with the data that retrieve from adpater
            Dim dtnr As DataRow = datat.NewRow() 'create a new row for adding the items afterward

            'adding data to the new row

            dtnr("FirstName") = fntb.Text
            dtnr("SecondName") = sntb.Text
            dtnr("HouseNumber") = hnnp.Text
            dtnr("Postcode") = pctb.Text
            dtnr("PhoneNumber") = pntb.Text
            dtnr("DOB") = DOBtp.Text
            dtnr("Weight") = wnp.Text
            dtnr("runnerusername") = utb.Text
            dtnr("runnerpassword") = pwtb.Text

            datat.Rows.Add(dtnr)
            'update the database in Access
            adp.Update(datat)


            datat.Clear() 'datatable need to be cleared in case user add another record

            ' I need a new empty record with the same ID number in Ranking database
            'as the ID number is auto-generated (add 1 each time), so the new id will be the maxium number
            'find max number
            adp.SelectCommand.CommandText = "select* from persondetail where runnerid = (select max(RunnerID) from persondetail)"

            adp.Fill(datat)
            id = datat.Rows(0).Item(0)
            'add new record
            updatetable()
            signin.Show()


            Me.Close()
            con.Close()
            colour()
        End If

    End Sub

    Private Sub updatetable() 'add new record to the 'ranking' database
        Dim adp As New OleDb.OleDbDataAdapter("SELECT * FROM ranking", con)
        Dim cn As New OleDbCommandBuilder(adp)
        Dim datat As New DataTable
        adp.Fill(datat)
        datat.Rows.Add(id, datat.Rows.Count + 1)      'add the record with the runner ID, add the postion of the runner which is the number of exsiting runners +1
        adp.Update(datat)


    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        signin.Show() 'show the sign in page when button is clicked

        Me.Close() 'close current form

    End Sub

    Private Sub colour() 'procedure change all the textboxes's backcolour to white
        pwtb.BackColor = Color.White
        pctb.BackColor = Color.White
        utb.BackColor = Color.White
        tbcpw.BackColor = Color.White
        pntb.BackColor = Color.White
        fntb.BackColor = Color.White
        hnnp.BackColor = Color.White
        sntb.BackColor = Color.White
    End Sub
    Private Sub account_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        colour() 'after the form close, all the texboxes's backcolour will change to white
        signin.Show()
    End Sub


    Private Sub pntb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pntb.TextChanged
        pntb.BackColor = Color.White 'when the text in the textbox change, the texboxes's backcolour will be white
    End Sub

    Private Sub utb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles utb.TextChanged
        utb.BackColor = Color.White
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbcpw.TextChanged
        tbcpw.BackColor = Color.White

    End Sub
    Private Sub pwtb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pwtb.TextChanged
        pwtb.BackColor = Color.White
    End Sub
    Private Sub pctb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctb.TextChanged
        pctb.BackColor = Color.White
    End Sub

    Private Sub fntb_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fntb.TextChanged
        fntb.BackColor = Color.White
    End Sub

    Private Sub sntb_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sntb.TextChanged
        sntb.BackColor = Color.White
    End Sub

    Private Sub hnnp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hnnp.ValueChanged
        hnnp.BackColor = Color.White
    End Sub

    Private Sub account_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class









