Imports System.Windows.Forms
Imports System.Data.OleDb

Public Class race
    Dim dblo As String = (System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Database.accdb"))
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dblo)
    Dim datat As New DataTable
    Dim adp As New OleDb.OleDbDataAdapter("SELECT runnerid FROM ranking", con)
    Dim cb As New OleDbCommandBuilder(adp)


    Private Sub race_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        adp.Fill(datat)
        'add all runners' ID into Runner ID list box
        'the number of repetitions = the number of records
        Dim i As Integer = datat.Rows.Count - 1
        Do
            RunnerID.Items.Add(datat.Rows(i).Item("runnerid"))
            i = i - 1
        Loop Until (i = -1)

    End Sub
    Private Sub Runners_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunnerID.SelectedIndexChanged
        'when an item in the runner ID list box is selected/clicked
        Dim position As Integer
        If RunnerID.SelectedItem Then
            rankinglist.Items.Add(RunnerID.SelectedItem) 'add the selected item to rankinglist list box
            position = Positionlist.Items.Count + 1 'work out the position of the runner by adding the number of items in the rankinglist by 1
            Positionlist.Items.Add(position) 'add the position of the runner to position list

            RunnerID.Items.Remove(RunnerID.SelectedItem) 'remove the item from runner ID list box 
        End If

    End Sub


    Private Sub rankinglist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rankinglist.SelectedIndexChanged
        If rankinglist.SelectedItem Then 'show the positionof the runner on positionlist if the runerid on rankinglist got selected
            Positionlist.SelectedIndex = rankinglist.SelectedIndex
        End If
    End Sub

    Private Sub P_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Positionlist.SelectedIndexChanged
        If Positionlist.SelectedItem Then 'show the corresponding runner on rankinglist after the position on positionlist got selected
            rankinglist.SelectedIndex = Positionlist.SelectedIndex
        End If
    End Sub
    'Dim canClose As Boolean = False
    Private Sub account_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        racedatabase.Show()

    End Sub


    Private Sub bts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bts.Click

        If Positionlist.Items.Count < 2 Then 'a race normally involve two or more than two runners
            MessageBox.Show("Please select at least two runners")
        Else

            Dim answer As DialogResult

            answer = MessageBox.Show("Are you sure you want to add this race?", "Adding race", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'use a messagebox to confirm that the user add the race.

            If answer = Windows.Forms.DialogResult.No Then
                Exit Sub 'the following code won't run if user click "no" button on the message box
            End If
            If answer = Windows.Forms.DialogResult.Yes Then

                If RunnerID.Items.Count > 0 Then
                    Dim i As Integer = RunnerID.Items.Count - 1
                    Do

                        adp.SelectCommand.CommandText = "SELECT * FROM ranking where runnerid =" & RunnerID.Items.Item(i) 'select the record with the same ID as the one in the list box
                        Dim datat As New DataTable
                        datat.Clear()

                        adp.Fill(datat)

                        datat.Rows(0).Item("lastraceposition") = DBNull.Value
                        'as these runners didn't get selected and still on the runner ID list, so I assune they didn't take part in the race, and their last race position will be blank


                        i = i - 1
                        adp.Update(datat)
                    Loop Until (i < 0)
                End If

                'update the records for those whose ID are in the Ranking list

                Dim pi As Integer = rankinglist.Items.Count - 1
                Dim c As Integer = rankinglist.Items.Count

                Do

                    adp.SelectCommand.CommandText = "SELECT * FROM ranking where runnerid =" & rankinglist.Items(pi)
                    Dim datat As New DataTable
                    datat.Clear()

                    adp.Fill(datat)

                    datat.Rows(0).Item("lastraceposition") = pi + 1 'the last race position is the same as the number of times that the code repeated, (it starts at 0 and add one each time)
                    '
                    If IsDBNull(datat.Rows(0).Item("points")) Then
                        'if the runner hasn't done any race, the data for points will be null, set it to 0 will avoding the errors from further arithmetical calculations 
                        datat.Rows(0).Item("points") = 0
                    End If
                    datat.Rows(0).Item("points") = datat.Rows(0).Item("points") + (c - pi) 'the bigger the number of the position, the less the point gained

                    adp.Update(datat)
                    pi = pi - 1
                Loop Until (pi < 0)

            End If
            racedatabase.Show()

            Me.Close()

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btc.Click
        racedatabase.Show()

        Me.Close()

    End Sub

End Class
