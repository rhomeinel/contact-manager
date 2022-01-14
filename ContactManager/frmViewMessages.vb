Imports System.Data.OleDb
Public Class frmViewMessages
    Dim con As New OleDbConnection
    Dim daadp As New OleDbDataAdapter
    Dim das As New DataSet
    Dim connString As String
    Dim personSQL As String
    Dim messageSQL As String
    Dim inc As Integer

    Private Sub frmViewMessages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connString = "Provider=Microsoft.ACE.OLEDB.12.0; Data source='Contact_DB.accdb'"
        con.ConnectionString = connString
        Dim Message_ID As String
        Message_ID = Me.Tag.ToString
        Dim messageSQL As String = "SELECT * FROM Message_tB WHERE M_ID=?"
        Dim cmdMessage As New OleDbCommand(messageSQL, con)

        cmdMessage.CommandType = CommandType.Text
        cmdMessage.Parameters.AddWithValue("M_ID", Message_ID)
        con.Open()
        cmdMessage.ExecuteNonQuery()
        daadp.SelectCommand = cmdMessage
        daadp.Fill(das, "selectedMessage")
        con.Close()
        displayMessage()
    End Sub
    'function to do display messages in the controls
    Private Sub displayMessage()
        txtMID.Text = das.Tables("selectedMessage").Rows(inc).Item(0)
        txtSender.Text = das.Tables("selectedMessage").Rows(inc).Item(1)
        txtDate.Text = das.Tables("selectedMessage").Rows(inc).Item(2)
        txtContant.Text = das.Tables("selectedMessage").Rows(inc).Item(3)
    End Sub
End Class