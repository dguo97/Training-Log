Imports System.Windows.Forms
Imports System.Data.OleDb


Public Class profile
    'connect the database in Access
    Dim dblo As String = (System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Database.accdb"))
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dblo)

    Dim datat As New DataTable


    Dim runnerid As String = UserHome.rnid.Text 'retrieve RunnerID from the user homepage, so the system will know which record need to retrieve from Access.

    Dim adp As New OleDb.OleDbDataAdapter("SELECT * FROM persondetail where RunnerID =" & runnerid, con)
    'retrieve the record with the Runner ID from database by using dirct access.
    Dim cb As New OleDbCommandBuilder(adp)


    Dim viewonly As Boolean
    'set a boolean variable which will be able to decide wheather users can edit the texts on the textboxes or not


    Private Sub profile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load ' when the form is loading


        adp.Fill(datat) 'fill the a datatable with the data from the access

        'show every items on the record on the corresponding textbox
        fntb.Text = datat.Rows(0).Item("firstname")
        sntb.Text = datat.Rows(0).Item("secondname")
        hnnp.Text = datat.Rows(0).Item("housenumber")
        pctb.Text = datat.Rows(0).Item("postcode")
        pntb.Text = datat.Rows(0).Item("phonenumber")
        DOBtp.Text = datat.Rows(0).Item("dob")
        wnp.Text = datat.Rows(0).Item("weight")

        viewonly = False  'set the boolean as false
        protect() 'call the procedure

    End Sub

    Private Sub protect()
        'disable all the textboxes to avoid the accidental change
        fntb.Enabled = viewonly
        sntb.Enabled = viewonly
        hnnp.Enabled = viewonly
        pctb.Enabled = viewonly
        pntb.Enabled = viewonly
        DOBtp.Enabled = viewonly
        wnp.Enabled = viewonly
        'set all the textboxes back colour white when the user enter the form, or after user make the sensiable and valid change to the data
        If viewonly = False Then
            fntb.BackColor = Color.White
            sntb.BackColor = Color.White
            hnnp.BackColor = Color.White
            pctb.BackColor = Color.White
            pntb.BackColor = Color.White
            DOBtp.BackColor = Color.White
            wnp.BackColor = Color.White
        End If
    End Sub








    'the validations for the data, which are the same as them on sign in form 
    Private Sub bts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bts.Click
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
            em = em & vbNewLine & "phone number needs to contain"
            pntb.BackColor = Color.DarkRed
        End If


        pctb.Text = pctb.Text.ToUpper() 'capitalise the text in the postcide database
        'postcode code verfication
        If (pctb.Text.Length = 7 And Not pctb.Text Like "[A-Z][A-Z]# #[A-Z][A-Z]") Or (pctb.Text.Length = 8 And Not pctb.Text Like "[A-Z][A-Z]## #[A-Z][A-Z]") Or pctb.Text.Length < 7 Then
            'post code should be LLD DLL or LLDD DLL. L=letter, D=digit
            em = em & vbNewLine & "Please enter the correct post code format: 'LLD DLL' or 'LLDD DLL'. L=letter, D=digit"
            pctb.BackColor = Color.DarkRed
        End If

        If Not em = "Error" Then
            MessageBox.Show(em)
        Else
            datat.Rows(0).Item("firstname") = fntb.Text
            datat.Rows(0).Item("secondname") = sntb.Text
            datat.Rows(0).Item("housenumber") = hnnp.Text
            datat.Rows(0).Item("postcode") = pctb.Text
            datat.Rows(0).Item("phonenumber") = pntb.Text
            datat.Rows(0).Item("dob") = DOBtp.Text
            datat.Rows(0).Item("weight") = wnp.Text


            adp.Update(datat)
            viewonly = False
            protect()

        End If
    End Sub


    Private Sub bte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bte.Click
        viewonly = True
        protect() 'enable all the textbox when button edit is clicked

    End Sub


    Private Sub btback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btback.Click
        UserHome.Show()
        Me.Close()
    End Sub


    Private Sub pctb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctb.TextChanged
        pctb.BackColor = Color.White  'change the textbox backcolour to white when the text is changed
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
    Private Sub pntb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pntb.TextChanged
        pntb.BackColor = Color.White
    End Sub
End Class








