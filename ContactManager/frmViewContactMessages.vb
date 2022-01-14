Imports System.Data.OleDb
Public Class frmViewContactMessages
    Dim con As New OleDbConnection
    Dim daadp As New OleDbDataAdapter
    Dim das As New DataSet
    Dim connString As String
    Dim personSQL As String
    Dim messageSQL As String
    Dim inc As Integer
    'function to fetch data from person_tb
    Private Sub frmViewContactMessages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connString = "Provider=Microsoft.ACE.OLEDB.12.0; Data source='Contact_DB.accdb'"
        con.ConnectionString = connString
        'Function to store the ID of the selecetd contact from form1
        Dim person_ID As String
        person_ID = Me.Tag.ToString
        'parameterized querry to fetch data on the selected contact
        Dim personSQL As String = "SELECT * FROM Person_tB WHERE P_ID=?"
        Dim cmdPerson As New OleDbCommand(personSQL, con)
        cmdPerson.CommandType = CommandType.Text
        'creating the parameter and passing the value of the selected ID
        cmdPerson.Parameters.AddWithValue("P_ID", person_ID)
        con.Open()
        cmdPerson.ExecuteNonQuery()
        daadp.SelectCommand = cmdPerson
        daadp.Fill(das, "selectedPerson")
        'parameterized queery to fetch data on the messages sent by the selected contact
        Dim messageSQL As String = "SELECT * FROM Message_tB WHERE Sender_ID=?"
        Dim cmdMessage As New OleDbCommand(messageSQL, con)
        cmdMessage.CommandType = CommandType.Text
        'creating the parameter and passing the value of the selected ID
        cmdMessage.Parameters.AddWithValue("Sender_ID", person_ID)
        cmdMessage.ExecuteNonQuery()
        daadp.SelectCommand = cmdMessage
        daadp.Fill(das, "selectedPersonMessages")
        con.Close()
        showData()
    End Sub
    'method to show data and bound dataGridView to controls and display the insertd ViewMessage as last column
    Private Sub showData()
        txtID.Text = das.Tables("selectedPerson").Rows(inc).Item(0)
        txtFirstName.Text = das.Tables("selectedperson").Rows(inc).Item(1)
        txtLastName.Text = das.Tables("selectedperson").Rows(inc).Item(2)
        comGender.Text = das.Tables("selectedperson").Rows(inc).Item(3)
        dateDOB.Value = das.Tables("selectedperson").Rows(inc).Item(4)
        txtEmail.Text = das.Tables("selectedPerson").Rows(inc).Item(5)
        txtPhone.Text = das.Tables("selectedperson").Rows(inc).Item(6)
        txtAddress.Text = das.Tables("selectedperson").Rows(inc).Item(7)
        txtDetails.Text = das.Tables("selectedperson").Rows(inc).Item(8)

        'bound the datagridview controls to the selectedPersonMessage in the das dataset
        dgvMessages.DataSource = das.Tables("selectedPersonMessages")
        'display the inserted "viewMessage" as the last column in the datagridview
        dgvMessages.Columns("ViewMessage").DisplayIndex = 4
    End Sub
    'DataGridView methods
    Private Sub dgvMessages_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMessages.CellContentClick
        If e.ColumnIndex = 0 Then
            'ViewMessage button clicked
            'Get the ID of the selected Message
            Dim i As Integer = e.RowIndex
            Dim row As DataGridViewRow = dgvMessages.Rows(i)
            Dim cell As DataGridViewCell = row.Cells(1)
            Dim MessagaeID As String = cell.Value
            'display the ViewMessage form
            Dim messageForm As New frmViewMessages
            messageForm.Tag = MessagaeID
            messageForm.ShowDialog()
        End If
    End Sub
End Class