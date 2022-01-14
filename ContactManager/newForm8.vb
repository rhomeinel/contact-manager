Public Class newForm8

    Private Sub Call_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Call_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Call_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Contact_DBDataSet)

    End Sub

    Private Sub newForm8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Contact_DBDataSet.Call_TB' table. You can move, or remove it, as needed.
        Dim Call_ID As String = Me.Tag

        Try
            Me.Call_TBTableAdapter.FillBy(Me.Contact_DBDataSet.Call_TB, CType(Call_ID, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub C_IDTextBox_TextChanged(sender As Object, e As EventArgs) Handles C_IDTextBox.TextChanged

    End Sub

    Private Sub Caller_IDTextBox_TextChanged(sender As Object, e As EventArgs) Handles Caller_IDTextBox.TextChanged

    End Sub

    Private Sub C_IDLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CallDataDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles CallDataDateTimePicker.ValueChanged

    End Sub

    Private Sub EndTimeDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles EndTimeDateTimePicker.ValueChanged

    End Sub

    Private Sub CallDataLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EndTimeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StartTimeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Caller_IDLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class