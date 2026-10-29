Imports System.Windows.Forms
Imports System.Data.OleDb

Public Class racedatabase
    Dim dblo As String = (System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Database.accdb")) 'Find the location of 
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dblo)
    Dim datat As New DataTable
    Dim adp As New OleDb.OleDbDataAdapter("SELECT * FROM ranking", con)
    Dim cb As New OleDbCommandBuilder(adp)
    Dim adpranking As New OleDb.OleDbDataAdapter("SELECT * FROM ranking", con)
    Dim cbranking As New OleDbCommandBuilder(adpranking)



    Private Sub racedatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

        refreshData()
        ranking()
    End Sub


    ' update the rankings on the datatable

    Private Sub ranking()
        Dim datatranking As New DataTable
        ' update the rankings of points
        grid.Sort(grid.Columns("points"), System.ComponentModel.ListSortDirection.Descending)
        'sort table in the data grid view in the order of points in the points column
        Dim i As Integer = 0
        '
        Dim runnerid As Integer 'runner ID is not defined as a specific value this time as it is assign to all the runner IDin the table
        Do Until i = grid.Rows.Count - 1
            runnerid = grid.Rows(i).Cells("runnerid").Value
            'use i as index, find the runner ID
            adpranking.SelectCommand.CommandText = "SELECT * FROM ranking where RunnerID =" & runnerid

            'find the record by runner ID
            datatranking.Clear()

            adpranking.Fill(datatranking)
            'the ranking of the points is the same as the number that those code repeated
            datatranking.Rows(0).Item("Rankingofpoints") = i + 1


            adpranking.Update(datatranking)

            i = i + 1
        Loop

        ' update the rankings of Totaltimeoftraining
        grid.Sort(grid.Columns("Totaltimeoftraining"), System.ComponentModel.ListSortDirection.Descending)

        i = 0

        Do Until i = grid.Rows.Count - 1
            runnerid = grid.Rows(i).Cells("runnerid").Value

            adpranking.SelectCommand.CommandText = "SELECT * FROM ranking where RunnerID =" & runnerid

            datatranking.Clear()

            adpranking.Fill(datatranking)

            datatranking.Rows(0).Item("Rankingoftime") = i + 1


            adpranking.Update(datatranking)

            i = i + 1
        Loop

        ' update the rankings of Totalcaloriesburned
        grid.Sort(grid.Columns("Totalcaloriesburned"), System.ComponentModel.ListSortDirection.Descending)

        i = 0


        Do Until i = grid.Rows.Count - 1
            runnerid = grid.Rows(i).Cells("RunnerID").Value

            adpranking.SelectCommand.CommandText = "SELECT * FROM ranking where RunnerID =" & runnerid

            datatranking.Clear()

            adpranking.Fill(datatranking)

            datatranking.Rows(0).Item("Rankingofcalories") = i + 1

            'as all the rankings have been found out, now the average ranking can be worked out

            datatranking.Rows(0).Item("Averageranking") = datatranking.Rows(0).Item("Rankingofcalories") / 3 + datatranking.Rows(0).Item("Rankingoftime") / 3 + datatranking.Rows(0).Item("Rankingofpoints") / 3


            adpranking.Update(datatranking)

            i = i + 1
        Loop

        datat.Clear()

        adp.Fill(datat)
        grid.DataSource = datat


        ' update the rankings of runnerposition

        grid.Sort(grid.Columns("Averageranking"), System.ComponentModel.ListSortDirection.Descending)

        i = 0

        Do Until i = grid.Rows.Count - 1


            runnerid = grid.Rows(i).Cells("RunnerID").Value

            adpranking.SelectCommand.CommandText = "SELECT * FROM ranking where RunnerID =" & runnerid

            datatranking.Clear()

            adpranking.Fill(datatranking)



            datatranking.Rows(0).Item("runnerposition") = i + 1

            adpranking.Update(datatranking)

            i = i + 1
        Loop


        'refresh the data on the grid view

        grid.DataSource = datat

    End Sub

    Private Sub btst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btst.Click
        If grid.DataSource IsNot Nothing Then

            grid.Sort(grid.Columns("runnerposition"), System.ComponentModel.ListSortDirection.Ascending)
            If grid.Rows.Count - 1 >= 8 Then 'the last row is the blank new row, so Rows.Count - 1 is the number of runners; with 8 or more runners the best eight are selected/highlighted to produce the team report
                Dim i As Integer = 0
                Do Until i = 8
                    grid.Rows(i).Selected = True
                    i = i + 1
                Loop

            Else
                MsgBox("There are fewer than 8 runners.")
            End If
        End If
    End Sub

    Dim closeform As Boolean = True 'decide whether the user should go back to admin homepage
    Private Sub account_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If closeform = True Then
            Adminhome.Show()
        End If


    End Sub
    Private Sub btb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btb.Click
        Adminhome.Show()
        closeform = True
        Me.Close()

    End Sub

    Private Sub btanr_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btanr.Click

        race.Show()
        closeform = False
        Me.Close()

    End Sub

    Private Sub racedatabase_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        refreshData()
        ranking()

    End Sub

    Private Sub refreshData()

        Dim dblo As String = (System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Database.accdb"))
        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dblo)
        Dim datat As New DataTable

        Dim adp As New OleDb.OleDbDataAdapter("SELECT * FROM ranking", con)
        Dim cb As New OleDbCommandBuilder(adp)
        adp.Fill(datat)
        grid.DataSource = datat

    End Sub




    Private Sub grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellContentClick

    End Sub

    Private Sub racedatabase_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
