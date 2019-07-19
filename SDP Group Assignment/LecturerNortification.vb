Imports System.Data.OleDb
Public Class LecturerNortification
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim DBDataAdapter As OleDbDataAdapter
    Dim sql As String
    Dim A As DataTable
    Dim dr As OleDbDataReader
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub LecturerNortification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;"
        conn = New OleDbConnection(sql)
        DBDataAdapter = New OleDbDataAdapter()
        A = New DataTable()
        sql = "Select * FROM Timetable Where Lecturer=@LTR"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LTR", b)
        cmd.CommandType = CommandType.Text
        DBDataAdapter.SelectCommand = cmd
        DBDataAdapter.SelectCommand.Connection = conn
        conn.Open()
        DBDataAdapter.Fill(A)
        dgvView.DataSource = A
        conn.Close()
        A.DefaultView.RowFilter = "Lecturer Like '%" & b& & "%'"
    End Sub


End Class