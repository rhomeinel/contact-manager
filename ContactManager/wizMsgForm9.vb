Public Class wizMsgForm9

    Private Sub Message_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Message_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Message_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Contact_DBDataSet)

    End Sub

    Private Sub wizMsgForm9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Contact_DBDataSet.Message_TB' table. You can move, or remove it, as needed.
        Me.Message_TBTableAdapter.Fill(Me.Contact_DBDataSet.Message_TB)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Dim Param1 As Object = New Object()
            Me.Message_TBTableAdapter.FillBy(Me.Contact_DBDataSet.Message_TB, Param1)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click

    End Sub
End Class