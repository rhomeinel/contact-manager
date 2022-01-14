Public Class newForm6

    Private Sub Person_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Person_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Person_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Contact_DBDataSet)

    End Sub

    Private Sub newForm6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Contact_DBDataSet.Person_TB' table. You can move, or remove it, as needed.
        Me.Person_TBTableAdapter.Fill(Me.Contact_DBDataSet.Person_TB)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.Person_TBTableAdapter.FillBy(Me.Contact_DBDataSet.Person_TB, CType(P_IDToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Person_TBTableAdapter.Fill(Me.Contact_DBDataSet.Person_TB)
    End Sub
End Class