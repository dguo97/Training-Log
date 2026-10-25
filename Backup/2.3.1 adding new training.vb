Imports System.Windows.Forms
Imports System.Data.OleDb

Public Class workingout

    Dim dblo As String = (System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Database.accdb")) 'Find the location of the Access database 
    'connect to Access
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dblo)
    Dim datat As New DataTable

    Dim runnerid As String = UserHome.rnid.Text  'retrieve the runnerid from the user homepage
    Dim adp As New OleDb.OleDbDataAdapter("SELECT * FROM traininginformation where RunnerID =" & runnerid, con)
    Dim cb As New OleDbCommandBuilder(adp)





    Dim calories As Single = 0 'declare a variable that is going to add up the calories burned from all the exercises

    Private Sub calcalories()     'procedure that calculate the calories
        ' create another adpter which get the weight of the runner
        Dim adp1 As New OleDb.OleDbDataAdapter("SELECT * FROM persondetail where RunnerID =" & runnerid, con)
        Dim datat1 As New DataTable
        adp1.Fill(datat1)

        Dim weight As Single
        'delcare the weight as a decimal number which store the value from the database
        weight = datat1.Rows(0).Item("weight")
        Dim ratio = weight / 80   'set the ratio = weight / 80, as these figure are based on the people with weight of 80kg


        Select Case rscb.SelectedIndex 'detect the index of the item user selects on the combo box
            Case 0 'add up the corresponding calories 
                calories = calories + 472 * ratio * rtn.Value
            Case 1
                calories = calories + 590 * ratio * rtn.Value
            Case 2
                calories = calories + 679 * ratio * rtn.Value
            Case 3
                calories = calories + 797 * ratio * rtn.Value
            Case 4
                calories = calories + 885 * ratio * rtn.Value
            Case 5
                calories = calories + 944 * ratio * rtn.Value
        End Select


        Select Case cscb.SelectedIndex
            Case 0
                calories = calories + 236 * ratio * ctn.Value
            Case 1
                calories = calories + 354 * ratio * ctn.Value
            Case 2
                calories = calories + 472 * ratio * ctn.Value
            Case 3
                calories = calories + 590 * ratio * ctn.Value
            Case 4
                calories = calories + 708 * ratio * ctn.Value
            Case 5
                calories = calories + 944 * ratio * ctn.Value

        End Select

        Select Case swcb.SelectedIndex
            Case 0
                calories = calories + 413 * ratio * stn.Value
            Case 1
                calories = calories + 590 * ratio * stn.Value
            Case 2
                calories = calories + 413 * ratio * stn.Value
            Case 3
                calories = calories + 590 * ratio * stn.Value
            Case 4
                calories = calories + 649 * ratio * stn.Value


        End Select




    End Sub

    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IDl.Text = UserHome.rnid.Text 'set the lable text as the RunnerID from user homepage
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim m As String = Nothing        'set a string which is going to contain all the error message
        If Not rtn.Value = 0 And rscb.Text = Nothing Then      'if the user input the time for the exercise, then the speed /style of that exercise has to be input too.
            m = ("Please select running speed")
        End If
        If Not ctn.Value = 0 And cscb.Text = Nothing Then
            m = (m & vbNewLine & "Please select cycling speed")
        End If
        If Not stn.Value = 0 And swcb.Text = Nothing Then
            m = (m & vbNewLine & "Please select swimming style")
        End If



        If Not m = Nothing Then    'if the string contain any of the error message.

            MessageBox.Show(m)
        ElseIf stn.Value = 0 And ctn.Value = 0 And rtn.Value = 0 Then

            MsgBox("Please enter at least one activity")  'the error message will be shown if the total training time is 0


        Else

            If rtn.Value = 0 Then  'if the training time is 0, the correspinding textbox for the exercise will be cleared.
                rscb.Text = Nothing
            End If
            If ctn.Value = 0 Then
                cscb.Text = Nothing
            End If
            If stn.Value = 0 Then
                swcb.Text = Nothing
            End If



            adp.Fill(datat)

            con.Open() 'open the connection

            'add the training information into the database.
            Dim dtnr As DataRow = datat.NewRow()

            dtnr("RunnerID") = runnerid
            dtnr("trainingdate") = dtp.Text

            dtnr("runningtime") = rtn.Value
            dtnr("RunningSpeed") = rscb.Text
            dtnr("Cyclingspeed") = cscb.Text
            dtnr("Cyclingtime") = ctn.Value
            dtnr("Swimmingstyle") = swcb.Text
            dtnr("swimmingtime") = stn.Value

            'call the procedure to calculate the total calories burned, and save it to database.
            calcalories()
            dtnr("caloriesburned") = calories

            datat.Rows.Add(dtnr)

            adp.Update(datat)

            con.Close()
            usertrainingi.Show() ' show the training information page.
            Me.Close() 'close the form and run the code in 'formclosing'event




        End If



    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        Me.Close()
    End Sub



    Private Sub account_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        usertrainingi.Show() 'show the usertraining information page.
    End Sub


End Class

























'MessageBox.Show(Year(Today) - Year(dtp.Text))dtp.Text = Today
