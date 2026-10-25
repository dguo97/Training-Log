Imports System.Windows.Forms
Imports System.Data.OleDb

Public Class usertrainingi

    Dim dblo As String = (System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Database.accdb"))
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dblo)
    Dim datat As New DataTable

    Dim runnerid As String = UserHome.rnid.Text 'get the runner ID which display on the user homepage.

    Dim adp As New OleDb.OleDbDataAdapter("SELECT * FROM traininginformation where RunnerID =" & runnerid, con)
    Dim cb As New OleDbCommandBuilder(adp)

    Private Sub Dialog2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        adp.Fill(datat)
        grid.DataSource = datat 'show the data from the datatable on the data grid view

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bts.Click

        If IsDBNull(datat) Or datat.Rows.Count = 0 Then 'check if the runner has got any record of training information
            MessageBox.Show("No training record found")
        Else

            'calculating statistic for runner's training information
            Dim rt As Single = 0
            Dim ct As Single = 0
            Dim st As Single = 0
            Dim tc As Single = 0
            Dim tt As Single = 0

            rt = datat.Compute("Sum(runningtime)", "RunnerID=" & runnerid)
            ct = datat.Compute("Sum(Cyclingtime)", "RunnerID=" & runnerid)
            st = datat.Compute("Sum(swimmingtime)", "RunnerID=" & runnerid)
            tt = rt + ct + st
            tc = datat.Compute("Sum(caloriesburned)", "RunnerID=" & runnerid)

            MessageBox.Show("Total running time/h: " & rt & vbNewLine & "Total cycling time/h: " & ct & vbNewLine & "Total swimming time/h: " & st & vbNewLine & "Total time" & tt & vbNewLine & "Total calories burned:" & tc)


        End If

    End Sub


    Private Sub btd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btd.Click
        Try
            'delete a record of training information.
            Dim answer As DialogResult 'record the button that the user click when a message box is shown
            If datat.Rows.Count = 0 Then

                MessageBox.Show("There are no records to delete.", "Delete record", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ' items in the bracket: message box' text, title, option

            ElseIf grid.SelectedRows.Count < 1 Then
                MsgBox("Please select a record")

            Else

                answer = MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


                If answer = Windows.Forms.DialogResult.Yes Then 'if user click Yes button



                    Dim id As Integer = grid.SelectedRows(0).Cells("trainingNO").Value 'get Training number of selected row as it is theprimary key 


                    Dim record() As DataRow = datat.Select("trainingNO ='" & id & "'") 'get the record of selected row
                    Dim index As Integer = datat.Rows.IndexOf(record(0)) 'find the index


                    datat.Rows(index).Delete() 'delete the record

                    adp.Update(datat)


                    MessageBox.Show("The record has been deleted", "Delete record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'update the data grid view
                    grid.DataSource = datat

                Else

                    MessageBox.Show("The record has NOT been deleted", "Delete record", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

            End If

        Catch ex As Exception    'if the user didn't select a record properly, e.g. user select a null record.
            MessageBox.Show("An error has occurred while deleting record")

        End Try


    End Sub

    Dim closingform As Boolean = True ' sometimes the form need be closed instead of hide, as close and re-open form will activate the 'form shown' event code, while hide the form won't activite it






    Private Sub abant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btant.Click


        workingout.Show()

        closingform = False
        Me.Close()
        'form need to be closed this time as adding a new training information will need to refresh the data grid view(the code is included in form shown code)

    End Sub
    Private Sub btcp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcp.Click
        Compare.Show()

        closingform = True
        Me.Hide() 'form doesn't need to close as the records won't change when comparing runner's performance

    End Sub

    Private Sub account_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        total()

        If closingform = True Then
            UserHome.Show()
        End If


    End Sub
    Private Sub btb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btb.Click
        UserHome.Show()

        Me.Close()

    End Sub


    'the date grid will be refreshed (retrieve from databasge)when the form is re-opened or refresh button is clicked
    Private Sub btrf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btrf.Click
        refreshData()
    End Sub
    Private Sub usertrainingi_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown 'form shown code
        refreshData()
    End Sub
    Private Sub refreshData()
        Dim dblo As String = (System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Database.accdb"))
        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dblo)
        Dim datat As New DataTable

        Dim adp As New OleDb.OleDbDataAdapter("SELECT * FROM traininginformation where RunnerID =" & runnerid, con)
        Dim cb As New OleDbCommandBuilder(adp)
        adp.Fill(datat)
        grid.DataSource = datat
    End Sub
    Private Sub total()
        'calculating statistic for runner's training information


        If Not (IsDBNull(datat) Or datat.Rows.Count = 0) Then 'check if the runner has got any record of training information




            Dim rt As Single = 0
            Dim ct As Single = 0
            Dim st As Single = 0
            Dim tc As Single = 0
            Dim tt As Single = 0

            rt = datat.Compute("Sum(runningtime)", "RunnerID=" & runnerid)
            ct = datat.Compute("Sum(Cyclingtime)", "RunnerID=" & runnerid)
            st = datat.Compute("Sum(swimmingtime)", "RunnerID=" & runnerid)
            tt = rt + ct + st
            tc = datat.Compute("Sum(caloriesburned)", "RunnerID=" & runnerid)

            Dim datatrace As New DataTable


            Dim adprace As New OleDb.OleDbDataAdapter("SELECT * FROM ranking where RunnerID =" & runnerid, con)
            Dim cbr As New OleDbCommandBuilder(adprace)
            adprace.Fill(datatrace)
            ' update these data to ranking database
            datatrace.Rows(0).Item("Totalcaloriesburned") = tc
            datatrace.Rows(0).Item("Totaltimeoftraining") = tt
            adprace.Update(datatrace)

        End If

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btp.Click
        PrintDocument.DefaultPageSettings.Landscape = True  'the orietation of the print document
        PrintDialog.Document = PrintDocument          'the print document that shows on the printing dialog  
        Dim result As DialogResult = PrintDialog.ShowDialog()      'ask the user for confirmation
        If result = Windows.Forms.DialogResult.OK Then               'print the document when user press 'OK'
            PrintDocument.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        Dim bm As New Bitmap(Me.grid.Width, Me.grid.Height)         'set the size of the document which is the same as the size of the data grid view
        grid.DrawToBitmap(bm, New Rectangle(0, 0, Me.grid.Width, Me.grid.Height))  'set the shape of the document, and the range of the form that is going to be printed
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub
End Class



