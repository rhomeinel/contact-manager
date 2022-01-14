Public Class newForm7

    Private Sub Person_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Person_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Person_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Contact_DBDataSet)

    End Sub

    Private Sub newwForm7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Contact_DBDataSet.Call_TB' table. You can move, or remove it, as needed.
        Me.Call_TBTableAdapter.Fill(Me.Contact_DBDataSet.Call_TB)
        'TODO: This line of code loads data into the 'Contact_DBDataSet.Person_TB' table. You can move, or remove it, as needed.
        Me.Person_TBTableAdapter.Fill(Me.Contact_DBDataSet.Person_TB)

    End Sub
    Private Sub Call_TBDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles Call_TBDataGridView.CellContentClick
        If e.ColumnIndex = 5 Then
            'View call button clicked 
            'Gwt the ID of the selected Message
            Dim i As Integer = e.RowIndex
            Dim row As DataGridViewRow = Call_TBDataGridView.Rows(i)
            Dim cell As DataGridViewCell = row.Cells(1)
            Dim Call_ID As String = cell.Value

            'Display the new newForm8
            Dim callForm As New newForm8
            callForm.Tag = call_ID
            callForm.ShowDialog()
        End If
    End Sub
End Class