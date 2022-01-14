Imports System.Data.OleDb
Public Class frmViewContactCalls
    Dim con As New OleDbConnection
    Dim daadp As New OleDbDataAdapter
    Dim das As New DataSet
    Dim connString As String
    Dim personSQL As String
    Dim CallSQL As String
    Dim inc As Integer

    Private Sub frmViewContactCalls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connString = "Provider=Microsoft.ACE.OLEDB.12.0; Data source='Contact_DB.accdb'"
        con.ConnectionString = connString
        'Method use to store the Id of the selected contact passed from form1
        Dim person_ID As String
        person_ID = Me.Tag.ToString
        'The parameterized querry to fectch data on the selected contact
        Dim personSQL As String = "SELECT * FROM Person_TB WHERE P_ID=?"
        Dim cmdperson As New OleDbCommand(personSQL, con)
        cmdperson.CommandType = CommandType.Text
        'Creating the parameter and passing the value of the selected contact
        cmdperson.Parameters.AddWithValue("P_ID", person_ID)
        con.Open()
        cmdperson.ExecuteNonQuery()
        daadp.SelectCommand = cmdperson
        daadp.Fill(das, "selectedPerson")
        'The parameterized querry to fetch data on the Calls made by the selected contact
        Dim callSQL As String = "SELECT * FROM Call_TB WHERE C_ID=?"
        Dim cmdCalls As New OleDbCommand(callSQL, con)
        cmdCalls.CommandType = CommandType.Text
        'Creating the parameter and passing the value of the selected ID
        cmdCalls.Parameters.AddWithValue("Caller_ID", person_ID)
        cmdCalls.ExecuteNonQuery()
        daadp.SelectCommand = cmdperson
        daadp.Fill(das, "selectedPersonCalls")
        con.Close()
        showData()
    End Sub
    'Method to show data
    Private Sub showData()
        txtID.Text = das.Tables("selectedPerson").Rows(inc).Item(0)
        txtFirstName.Text = das.Tables("selectedperson").Rows(inc).Item(1)
        txtLastName.Text = das.Tables("selectedperson").Rows(inc).Item(2)
        comGender.Text = das.Tables("selectedperson").Rows(inc).Item(3)
        dateDOB.Value = das.Tables("selectedperson").Rows(inc).Item(4)
        txtEmail.Text = das.Tables("selectedperson").Rows(inc).Item(5)
        txtPhone.Text = das.Tables("selectedperson").Rows(inc).Item(6)
        txtAddress.Text = das.Tables("selectedperson").Rows(inc).Item(7)
        txtDetails.Text = das.Tables("selectedperson").Rows(inc).Item(8)
        'link the datagridview controls to the selectedPersonCalls in the dataset
        dgvCalls.DataSource = das.Tables("selectedPersonCalls")
        'Display the inserted (ViewCalls) column as the the last column in DataGridView
        dgvCalls.Columns("ViewCall").DisplayIndex = 5
    End Sub

    Private Sub dgvCalls_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCalls.CellContentClick
        If e.ColumnIndex = 0 Then
            'Viewcall button clicked
            'Get ID of the selected call
            Dim i As Integer = e.RowIndex
            Dim row As DataGridViewRow = dgvCalls.Rows(i)
            Dim cell As DataGridViewCell = row.Cells(1)
            Dim callID As String = cell.Value
            'Display the View contact Calls form
            Dim callForm As New frmViewCalls
            callForm.Tag = callID
            callForm.ShowDialog()
        End If
    End Sub

End Class