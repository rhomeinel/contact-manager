Imports System.Data.OleDb
Public Class frmViewCalls
    Dim con As New OleDbConnection
    Dim daadp As New OleDbDataAdapter
    Dim das As New DataSet
    Dim connString As String
    Dim personSQL As String
    Dim CallSQL As String
    Dim inc As Integer

    Private Sub frmViewCalls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connString = "Provider=Microsoft.ACE.OLEDB.12.0; Data source='Contact_DB.accdb'"
        con.ConnectionString = connString

        Dim call_ID As String
        call_ID = Me.Tag.ToString
        Dim callSQL As String = "SELECT * FROM Call_tB WHERE C_ID=?"
        Dim cmdCall As New OleDbCommand(callSQL, con)
        cmdCall.CommandType = CommandType.Text
        cmdCall.Parameters.AddWithValue("C_ID", call_ID)
        con.Open()
        daadp.SelectCommand = cmdCall
        daadp.Fill(das, "selectedCall")
        con.Close()
        displayCall()
    End Sub
    'method to display Calls
    Private Sub displayCall()

        txtCaller.Text = das.Tables("selectedCall").Rows(inc).Item(0)
        txtcCallerID.Text = das.Tables("selectedCall").Rows(inc).Item(1)
        txtStartTime.Text = das.Tables("selectedCall").Rows(inc).Item(2)
        txtEndTime.Text = das.Tables("selectedCall").Rows(inc).Item(3)
        txtcDate.Text = das.Tables("selectedCall").Rows(inc).Item(4)
    End Sub
End Class