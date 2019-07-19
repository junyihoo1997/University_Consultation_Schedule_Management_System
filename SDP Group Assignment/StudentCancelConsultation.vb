Imports System.Data.OleDb
Imports System.Net.Mail
Public Class StudentCancelConsultation
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim DBDataAdapter As OleDbDataAdapter
    Dim sql As String
    Dim A As DataTable
    Dim dr As OleDbDataReader
    Private Sub StudentCancelConsultation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtAppID.Text = "" Then
            MessageBox.Show("Please Select Appointment ID!")
        Else
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
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If txtAppID.Text = "" Or lblStudentName.Text = "" Or lblSID.Text = "" Or lblDOTW.Text = "" Or lblVenue.Text = "" Or lblReason.Text = "" Or lblTime.Text = "" Or lblWK.Text = "" Or lblStatus.Text = "" Or lblLN.Text = "" Then
            MessageBox.Show("Please Select Consultation To Proceed!")
        Else
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open()
            sql = "DELETE * FROM StudentConsultationRecord WHERE [AppointmentID]=@APPID"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@APPID", txtAppID.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Cancel Successfully. Enter Next Cancel Details.")
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open()
            sql = "DELETE * FROM ConsultationHour WHERE [DayOfTheWeek]=@DOTW and [ConsultationDuration]=@CD and [Week]=@WK and [Lecturer]=@LTR"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@DOTW", lblDOTW.Text)
            cmd.Parameters.AddWithValue("@CD", lblTime.Text)
            cmd.Parameters.AddWithValue("@WK", lblWK.Text)
            cmd.Parameters.AddWithValue("@LTR", lblLN.Text)
            cmd.ExecuteNonQuery()
            conn.Close()
            Try
                Dim Smtp_Server As New SmtpClient
                Dim e_mail As New MailMessage()
                Smtp_Server.UseDefaultCredentials = False
                Smtp_Server.Credentials = New Net.NetworkCredential("mytoys20032017@gmail.com", "abc1234567890")
                Smtp_Server.Port = 587
                Smtp_Server.EnableSsl = True
                Smtp_Server.Host = "smtp.gmail.com"

                e_mail = New MailMessage()
                e_mail.From = New MailAddress("mytoys20032017@gmail.com")
                e_mail.To.Add("junyi_hoo1997@gmail.com")
                e_mail.Subject = "Email Sending"
                e_mail.IsBodyHtml = False
                e_mail.Body = "Your student cancel the consultation slot!"
                Smtp_Server.Send(e_mail)
                MsgBox("Mail Sent")

            Catch error_t As Exception
                MsgBox(error_t.ToString)
            End Try
            CLearAll()
            StudentCancelConsultation_Load(e, e)
        End If

    End Sub
    Sub ClearAll()
        txtAppID.Clear()
        lblSID.Text=""
        lblStudentName.Text = ""
        lblDOTW.Text = ""
        lblVenue.Text = ""
        lblReason.Text = ""
        lblTime.Text = ""
        lblWK.Text = ""
        lblStatus.Text = ""
        lblLN.Text = ""
    End Sub
End Class