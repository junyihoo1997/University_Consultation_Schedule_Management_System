Imports System.Data.OleDb
Public Class StudentViewConsultationSlot
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim DBDataAdapter As OleDbDataAdapter
    Dim sql As String
    Dim A As DataTable
    Dim dr As OleDbDataReader
    Private Sub StudentViewConsultationSlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;"
        conn = New OleDbConnection(sql)
        DBDataAdapter = New OleDbDataAdapter()
        A = New DataTable()
        sql = "Select * FROM StudentConsultationRecord Where StudentName=@SN"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@SN", b)
        cmd.CommandType = CommandType.Text
        DBDataAdapter.SelectCommand = cmd
        DBDataAdapter.SelectCommand.Connection = conn
        conn.Open()
        DBDataAdapter.Fill(A)
        dgvView.DataSource = A
        conn.Close()
        A.DefaultView.RowFilter = "StudentName Like '%" & b& & "%'"
    End Sub

    Private Sub dgvView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvView.CellContentClick
        Dim row As Integer = e.RowIndex
        If row = -1 Then
            Exit Sub
        End If
        txtAppID.Text = dgvView.Rows(row).Cells(0).Value
        lblStudentName.Text = dgvView.Rows(row).Cells(1).Value
        lblSID.Text = dgvView.Rows(row).Cells(2).Value
        lblDOTW.Text = dgvView.Rows(row).Cells(3).Value
        lblVenue.Text = dgvView.Rows(row).Cells(4).Value
        lblReason.Text = dgvView.Rows(row).Cells(5).Value
        lblTime.Text = dgvView.Rows(row).Cells(6).Value
        lblWK.Text = dgvView.Rows(row).Cells(7).Value
        lblStatus.Text = dgvView.Rows(row).Cells(8).Value
        lblLN.Text = dgvView.Rows(row).Cells(9).Value
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        StudentMainPage.Show()
        'PublishConsultationSchedule_Load(e, e)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM StudentConsultationRecord Where AppointmentID=@APPID"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@APPID", txtAppID.Text)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then

            dr.Read()
            lblStudentName.Text = dr.Item("StudentName")
            lblSID.Text = dr.Item("StudentID")
            lblDOTW.Text = dr.Item("DayOfTheWeek")
            lblVenue.Text = dr.Item("Venue")
            lblReason.Text = dr.Item("Reason")
            lblTime.Text = dr.Item("Time")
            lblWK.Text = dr.Item("Week")
            lblStatus.Text = dr.Item("Status")
            lblLN.Text = dr.Item("LecturerName")
        End If
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class