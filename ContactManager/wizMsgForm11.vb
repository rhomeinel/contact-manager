Public Class wizMsgForm11

    Private Sub Message_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Message_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Message_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Contact_DBDataSet)

    End Sub

    Private Sub wizMsgForm11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Contact_DBDataSet.Message_TB' table. You can move, or remove it, as needed.
        Dim Message_ID As String = Me.Tag

        Try
            Me.Message_TBTableAdapter.FillBy1(Me.Contact_DBDataSet.Message_TB, CType(Message_ID, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class