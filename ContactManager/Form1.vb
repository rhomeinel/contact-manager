Imports System.Data.OleDb
Public Class Form1
    Dim con As New OleDbConnection
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim conString As String
    Dim sql As String
    Dim maxRows As Integer
    Dim dsNewRow As DataRow
    Dim inc As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            conString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source='Contact_DB.accdb'"
            con = New OleDbConnection(conString)
            con.Open()
            sql = "select * from Person_TB"
            da = New OleDbDataAdapter(sql, con)
            da.Fill(ds, "AddressBook")
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        NavigateRecord()
        DisableControl()
        btnCancel.Enabled = False
        btnCommit.Enabled = False
        btnSave.Enabled = False

    End Sub

    Private Sub NavigateRecord()
        txtID.Text = ds.Tables("AddressBook").Rows(inc).Item(0)
        txtFirstName.Text = ds.Tables("AddressBook").Rows(inc).Item(1)
        txtLastName.Text = ds.Tables("AddressBook").Rows(inc).Item(2)
        comGender.Text = ds.Tables("AddressBook").Rows(inc).Item(3)
        dateDOB.Text = ds.Tables("AddressBook").Rows(inc).Item(4)
        txtEmail.Text = ds.Tables("AddressBook").Rows(inc).Item(5)
        txtPhone.Text = ds.Tables("AddressBook").Rows(inc).Item(6)
        txtAddress.Text = ds.Tables("AddressBook").Rows(inc).Item(7)
        txtDetails.Text = ds.Tables("AddressBook").Rows(inc).Item(8)
        maxRows = ds.Tables("AddressBook").Rows.Count
    End Sub

    Private Sub DisableControl()
        txtFirstName.ReadOnly = True
        txtLastName.ReadOnly = True
        comGender.Enabled = False
        dateDOB.Enabled = False
        txtEmail.ReadOnly = True
        txtPhone.ReadOnly = True
        txtAddress.ReadOnly = True
        txtDetails.ReadOnly = True
    End Sub


    Private Sub EnableControl()
        txtFirstName.Text = ""
        txtLastName.Text = ""
        comGender.Text = "Male"
        dateDOB.Value = Today()
        txtEmail.Text = ""
        txtPhone.Text = ""
        txtAddress.Text = ""
        txtDetails.Text = ""
    End Sub


    Private Sub ClearRecords()
        txtFirstName.ReadOnly = False
        txtLastName.ReadOnly = False
        comGender.Enabled = True
        dateDOB.Enabled = True
        txtEmail.ReadOnly = False
        txtPhone.ReadOnly = False
        txtAddress.ReadOnly = False
        txtDetails.ReadOnly = False
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        If inc <> 0 Then
            inc = 0
            NavigateRecord()
        Else

            MessageBox.Show("This is the first record")
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Try
            If inc <> maxRows - 1 Then
                inc = maxRows - 1
                NavigateRecord()
            Else

                MessageBox.Show("This is the end of the record")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If inc <> maxRows - 1 Then
            inc = inc + 1
            NavigateRecord()
        Else

            MessageBox.Show("This is the last record")
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If inc <> 0 Then
            inc = inc - 1
            NavigateRecord()
        Else

            MessageBox.Show("This is the end of the record")
        End If
    End Sub

    Private Sub addRecord()
        dsNewRow.Item(1) = txtFirstName.Text
        dsNewRow.Item(2) = txtLastName.Text
        dsNewRow.Item(3) = comGender.Text
        dsNewRow.Item(4) = dateDOB.Text
        dsNewRow.Item(5) = txtEmail.Text
        dsNewRow.Item(6) = txtPhone.Text
        dsNewRow.Item(7) = txtAddress.Text
        dsNewRow.Item(8) = txtDetails.Text

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnCommit.Enabled = True
        btnAdd.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        EnableControl()
        ClearRecords()

    End Sub

    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        Dim cb As New OleDbCommandBuilder(da)
        Try
            dsNewRow = ds.Tables("AddressBook").NewRow()
            addRecord()
            ds.Tables("AddressBook").Rows.Add(dsNewRow)
            da.Update(ds, "AddressBook")
            MessageBox.Show("Record Saved")
            btnCommit.Enabled = False
            btnAdd.Enabled = True
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnCancel.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Form1_Load(Me, New System.EventArgs)
        NavigateRecord()
    End Sub

    Private Sub AllContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllContactToolStripMenuItem.Click

    End Sub

    Private Sub CallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CallToolStripMenuItem.Click
        Dim Person_ID As String = txtID.Text
        'txtID is the textbox that contains the ID of the selected contact
        Dim callFrom As New frmViewContactCalls
        callFrom.Tag = Person_ID
        callFrom.ShowDialog()

    End Sub

    Private Sub MessagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MessageToolStripMenuItem.Click
        Dim Person_ID As String = txtID.Text
        'txtID is the textbox that contains the ID of the selected contact
        Dim messageFrom As New frmViewContactMessages
        messageFrom.Tag = Person_ID
        messageFrom.ShowDialog()
    End Sub
    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub dateDOB_ValueChanged(sender As Object, e As EventArgs) Handles dateDOB.ValueChanged

    End Sub

    Private Sub comGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comGender.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
