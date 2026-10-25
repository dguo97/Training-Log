Imports System.Windows.Forms
Imports System.Data.OleDb

Public Class Compare
    Dim dblo As String = (System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Database.accdb"))
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dblo)
    Dim datata As New DataTable 'dim 4 table for each option in the combo box
    Dim datatr As New DataTable
    Dim datatc As New DataTable
    Dim datats As New DataTable
    Dim adp As New OleDb.OleDbDataAdapter
    Dim cb As New OleDbCommandBuilder(adp)

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gridrefresh() 'the procedure will be activated whenever user select a new item in the combo box 
    End Sub

    Private Sub gridrefresh()

        If cbatvt.SelectedIndex = 0 Then 'when the user select the first item (running)
            running()

        ElseIf cbatvt.SelectedIndex = 1 Then
            cycling()

        ElseIf cbatvt.SelectedIndex = 2 Then
            swimming()

        ElseIf cbatvt.SelectedIndex = 3 Then
            allactivities()

        End If


    End Sub

    Private Sub running()
        datatr.Clear() 'the datatable is cleared in case there is original data
        Dim adp As New OleDb.OleDbDataAdapter("SELECT RunnerID,Runningtime,RunningSpeed, trainingdate FROM traininginformation where not (Runningtime = 0) ", con)
        'only disply the RunnerID,Runningtime,RunningSpeed and trainingdate field, also hide the records where the running time is 0

        adp.Fill(datatr)

        grid.DataSource = datatr

    End Sub
    Private Sub cycling()
        datatc.Clear()

        Dim adp As New OleDb.OleDbDataAdapter("SELECT RunnerID,Cyclingspeed,Cyclingtime, trainingdate FROM traininginformation where not (Cyclingtime = 0)", con)

        adp.Fill(datatc)


        grid.DataSource = datatc
    End Sub
    Private Sub swimming()
        datats.Clear()

        Dim adp As New OleDb.OleDbDataAdapter("SELECT RunnerID,Swimmingstyle,swimmingtime, trainingdate FROM traininginformation where not (swimmingtime = 0)", con)

        adp.Fill(datats)
        grid.DataSource = datats
    End Sub


    Private Sub allactivities()

        Dim adp As New OleDb.OleDbDataAdapter("SELECT * FROM traininginformation ", con)
        datata.Clear()

        adp.Fill(datata)

        grid.DataSource = datata

    End Sub


    Private Sub cbbsb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbsb.SelectedIndexChanged

        If grid.DataSource IsNot Nothing Then

            grid.Sort(grid.Columns(cbbsb.SelectedItem), System.ComponentModel.ListSortDirection.Ascending)
            'sort the grid in order of the idem the selected in 'sort by' combo box if there are records in the data grid view
        End If
    End Sub

    Private Sub btb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btb.Click

        usertrainingi.Show()
        Me.Close()

    End Sub

    Private Sub Cba_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbatvt.SelectedIndexChanged
        gridrefresh()
    End Sub

    Private Sub Compare_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
