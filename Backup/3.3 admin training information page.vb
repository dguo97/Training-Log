Imports System.Windows.Forms
Imports System.Data.OleDb

Public Class atrainingi
    Dim dblo As String = (System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Database.accdb")) 'Find the location of the Access database 
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dblo)
    Dim datat As New DataTable
    Dim adp As New OleDb.OleDbDataAdapter("SELECT * FROM traininginformation", con)
    Dim cb As New OleDbCommandBuilder(adp)





    Private Sub atrainingi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'show the data on the data grid view 
        adp.Fill(datat)
        grid.DataSource = datat
    End Sub


    Private Sub account_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Adminhome.Show()  'show the admin homepage if current form is closed
    End Sub


    Private Sub cbbsb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbsb.SelectedIndexChanged             'when the user pick an item in the 'sort by' combo box 
        If grid.DataSource IsNot Nothing Then   'check if there are records in the data grid view

            grid.Sort(grid.Columns(cbbsb.SelectedItem), System.ComponentModel.ListSortDirection.Ascending)   'sort the data in the data grid view based on the item
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btb.Click
        Me.Close()       'close the form when back button is clicked
    End Sub

End Class
