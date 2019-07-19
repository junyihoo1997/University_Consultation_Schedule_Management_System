Imports System.Data.OleDb
Public Class AdminViewFeedback
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim DBDataAdapter As OleDbDataAdapter
    Dim sql As String
    Dim A As DataTable
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        AdminMainPage.Show()
    End Sub

    Private Sub AdminViewFeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;"
        conn = New OleDbConnection(sql)
        DBDataAdapter = New OleDbDataAdapter()
        A = New DataTable()
        cmd = New OleDbCommand("Feedback")
        cmd.CommandType = CommandType.TableDirect
        DBDataAdapter.SelectCommand = cmd
        DBDataAdapter.SelectCommand.Connection = conn
        conn.Open()
        DBDataAdapter.Fill(A)
        dgvView.DataSource = A
        conn.Close()
    End Sub

    Private Sub dgvView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvView.CellContentClick

    End Sub
End Class