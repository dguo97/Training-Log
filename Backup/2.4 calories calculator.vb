Imports System.Windows.Forms

Public Class cal 'this form has the similar code as adding new training form.



    Dim calories As Integer = 0 'declare the variable to store the calories



    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'validations
        Dim m As String = Nothing

        If Not rtn.Value = 0 And rscb.Text = Nothing Then
            m = ("Please select running speed")
        End If

        If Not ctn.Value = 0 And cscb.Text = Nothing Then
            m = (m & vbNewLine & "Please select cycling speed")
        End If

        If Not stn.Value = 0 And swcb.Text = Nothing Then
            m = (m & vbNewLine & "Please select swimming style")
        End If


        If m = Nothing Then
            calories = 0
            calcalories()
            MessageBox.Show("calories burned:" & calories)

        Else
            MessageBox.Show(m)
        End If
    End Sub

    Private Sub calcalories()


        'calculating calories
        Dim weight As Single = npw.Value

        Dim ratio = weight / 80


        Select Case rscb.SelectedIndex
            Case 0
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

    Private Sub accountFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        UserHome.Show()
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btb.Click

        Me.Close()
    End Sub


End Class
