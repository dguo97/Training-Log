Imports System.Windows.Forms
Imports System.Data.OleDb


Public Class Runnerdetail
    ' connect the Access database:persondetail

    Dim dblo As String = (System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Database.accdb")) 'Find the location of the Access database 
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dblo)
    Dim datat As New DataTable
    Dim adp As New OleDb.OleDbDataAdapter("SELECT * FROM persondetail", con)    'select all the records in the database
    Dim cb As New OleDbCommandBuilder(adp)

    Private Sub Runnerd_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        adp.Fill(datat)   'store the data that retrieve from Access
        grid.DataSource = datat  'show the data from
        grid.Columns("runnerpassword").Visible = False  'hide the runners' password column, so the admin can't see the runners' password
    End Sub

    Private Sub btsch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bts.Click

        If IsNumeric(tbs.Text) = True Then  'check if the data user input is numbers
            adp.SelectCommand.CommandText = "SELECT * FROM persondetail where RunnerID =" & tbs.Text  'if the user input digit data, then the system is going to find the runner detail record with the same ID number

        Else
            adp.SelectCommand.CommandText = "SELECT * FROM persondetail where SecondName ='" & tbs.Text & "'" 'if the user didn't input digit data, then the system is going to find the runner detail record(s) with the surname

        End If

        datat.Clear()    'clear the database in case there's already data in it


        adp.Fill(datat)
        If datat.Rows.Count > 0 Then 'check if there is more than 0 records

            grid.DataSource = datat   'if there is more than 0 recoreds, than the data will be shown on the data grid view





            '
        Else
            MessageBox.Show("Please enter a correct ID or a surname") 'else the error message will be shown.
        End If

    End Sub

    Private Sub tbs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbs.Click
        If tbs.Text = "ID or Surname..." Then      'check if the hint text is still on the textbox when user press it
            tbs.Text = Nothing   'if it is, then the text will be cleared, so the users can input their data
        End If
    End Sub

    'deleting a runner detail record code, which is similar to the code for deleting traning information record
    Private Sub btdl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdl.Click
        Try
            Dim answer As DialogResult   'declare a variable for dialog result(the button that user press after the message box pop out)
            If datat.Rows.Count = 0 Then        'check if there is any records
                MessageBox.Show("There are no records to delete.", "Delete record", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf grid.SelectedRows.Count < 1 Then    'if the user didn't select a record
                MsgBox("Please select a record")

            Else
                'if user did select a record
                answer = MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                'detect the button the user ckicked and store it

                If answer = Windows.Forms.DialogResult.Yes Then   'if user click yes


                    Dim id As Integer = grid.SelectedRows(0).Cells("runnerid").Value     'detect the runner's ID number and store it


                    Dim record() As DataRow = datat.Select("Runnerid ='" & id & "'")      'find the record with the ID number
                    Dim index As Integer = datat.Rows.IndexOf(record(0))    'find the index of the record

                    datat.Rows(index).Delete()       'delete the record with it's index in datatable

                    adp.Update(datat) 'update the adapter with the datatable so the reocord will be deleted in Access, too


                    MessageBox.Show("The record has been deleted", "Delete record", MessageBoxButtons.OK, MessageBoxIcon.Information)      'tell the user that the record has been deleted
                    grid.DataSource = datat
                    'show the updated record

                Else

                    MessageBox.Show("The record has NOT been deleted", "Delete record", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'tell the user that the record hasn't been deleted

                End If

            End If
        Catch ex As Exception    'if the user didn't select a record properly, e.g. user select a null record.
            MessageBox.Show("An error has occurred while deleting record")

        End Try

    End Sub

    Private Sub cbbsb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbsb.SelectedIndexChanged

        If grid.DataSource IsNot Nothing Then

            grid.Sort(grid.Columns(cbbsb.SelectedItem), System.ComponentModel.ListSortDirection.Ascending)
            ' when the user select an item in the 'sort by' combo box, the date in the grid will be sorted base on the item  the user chose
        End If
    End Sub

    Private Sub btsa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsa.Click
        adp.SelectCommand.CommandText = "SELECT * FROM persondetail "  'when 'show all' button is pressed, the system is going to select all the records, and display on the grid view.
        datat.Clear()
        adp.Fill(datat)
        grid.DataSource = datat
    End Sub



    Private Sub account_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Adminhome.Show()   'when this form is closed, the admin homepage will be shown.
    End Sub



    Private Sub btb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btb.Click
        Me.Close()
        ' when back button is pressed, this form will close
    End Sub

    Private Sub Runnerdetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
