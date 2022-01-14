Public Class wizmsgForm10

    Private Sub Person_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Person_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Person_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Contact_DBDataSet)

    End Sub

    Private Sub wizmsgForm10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Contact_DBDataSet.Message_TB' table. You can move, or remove it, as needed.
        Me.Message_TBTableAdapter.Fill(Me.Contact_DBDataSet.Message_TB)
        'TODO: This line of code loads data into the 'Contact_DBDataSet.Person_TB' table. You can move, or remove it, as needed.
        Me.Person_TBTableAdapter.Fill(Me.Contact_DBDataSet.Person_TB)

    End Sub

    Private Sub Message_TBDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Message_TBDataGridView.CellContentClick
        If e.ColumnIndex = 4 Then
            'View call button clicked 
            'Gwt the ID of the selected Message
            Dim i As Integer = e.RowIndex
            Dim row As DataGridViewRow = Message_TBDataGridView.Rows(i)
            Dim cell As DataGridViewCell = row.Cells(1)
            Dim Message_ID As String = cell.Value

            'Display the new wizMsgForm11
            Dim messageForm As New wizMsgForm11
            messageForm.Tag = Message_ID
            messageForm.ShowDialog()
        End If
    End Sub
End Class