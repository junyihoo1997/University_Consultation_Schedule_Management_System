Imports System.Data.OleDb
Imports System.Net.Mail
Public Class ConsultationRecord
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim DBDataAdapter As OleDbDataAdapter
    Dim sql As String
    Dim A As DataTable
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        LecturerMainPage.Show()
    End Sub

    Private Sub ConsultationRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;"
        conn = New OleDbConnection(sql)
        DBDataAdapter = New OleDbDataAdapter()
        A = New DataTable()
        cmd = New OleDbCommand("StudentConsultationRecord")
        cmd.CommandType = CommandType.TableDirect
        DBDataAdapter.SelectCommand = cmd
        DBDataAdapter.SelectCommand.Connection = conn
        conn.Open()
        DBDataAdapter.Fill(A)
        dgvView.DataSource = A
        conn.Close()
        A.DefaultView.RowFilter = "LecturerName Like '%" & b& & "%'"
    End Sub

    Private Sub dgvView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvView.CellContentClick

    End Sub

    Private Sub dgvView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvView.CellDoubleClick
        Dim row As Integer = e.RowIndex
        If row = -1 Then
            Exit Sub
        End If
        txtAppointmentID2.Text = dgvView.Rows(row).Cells(0).Value
        txtStudentName.Text = dgvView.Rows(row).Cells(1).Value
        txtStudentID.Text = dgvView.Rows(row).Cells(2).Value
        txtDate.Text = dgvView.Rows(row).Cells(3).Value
        txtTime.Text = dgvView.Rows(row).Cells(6).Value
        txtVenue.Text = dgvView.Rows(row).Cells(4).Value
        txtReason.Text = dgvView.Rows(row).Cells(5).Value
        txtStatus.Text = dgvView.Rows(row).Cells(8).Value
        txtWeek.Text = dgvView.Rows(row).Cells(7).Value
    End Sub

    Private Sub btnApproved_Click(sender As Object, e As EventArgs) Handles btnApproved.Click
        If txtAppointmentID2.Text = "" Or txtStudentName.Text = "" Or txtStudentID.Text = "" Or txtDate.Text = "" Or txtTime.Text = "" Or txtVenue.Text = "" Or txtReason.Text = "" Or txtWeek.Text = "" Or txtStatus.Text = "" Then
            MessageBox.Show("One Field Or More Field is Empty! Please Enter Correctly!")
        Else
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open()
            sql = "UPDATE StudentConsultationRecord SET [Status]=@ST WHERE [AppointmentID]=@AID"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@ST", "Approved")
            cmd.Parameters.AddWithValue("@AID", txtAppointmentID2.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Consultation Approved Successfully and An Email Has Been Send to Student Mailbox. Approve Next Consultation Record!")
            ClearAll()
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
                e_mail.To.Add("junyi_hoo1997@hotmail.com")
                e_mail.Subject = "Email Sending"
                e_mail.IsBodyHtml = False
                e_mail.Body = "Your consultation record has been approved"
                Smtp_Server.Send(e_mail)
                MsgBox("Mail Sent")

            Catch error_t As Exception
                MsgBox(error_t.ToString)
            End Try
        End If

    End Sub
    Sub ClearAll()
        txtTime.Clear()
        txtAppointmentID2.Clear()
        txtDate.Clear()
        txtReason.Clear()
        txtStudentID.Clear()
        txtStudentName.Clear()
        txtVenue.Clear()
        txtWeek.Clear()
        txtStatus.Clear()
    End Sub

    Private Sub btnNotApproved_Click(sender As Object, e As EventArgs) Handles btnNotApproved.Click
        If txtAppointmentID2.Text = "" Or txtStudentName.Text = "" Or txtStudentID.Text = "" Or txtDate.Text = "" Or txtTime.Text = "" Or txtVenue.Text = "" Or txtReason.Text = "" Or txtWeek.Text = "" Or txtStatus.Text = "" Then
            MessageBox.Show("One Field Or More Field is Empty! Please Enter Correctly!")
        Else
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open()
            sql = "UPDATE StudentConsultationRecord SET [Status]=@ST WHERE [AppointmentID]=@AID"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@ST", "Not Approved")
            cmd.Parameters.AddWithValue("@AID", txtAppointmentID2.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Consultation Not Approved Successfully!")
            ClearAll()
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
                e_mail.To.Add("junyi_hoo1997@hotmail.com")
                e_mail.Subject = "Email Sending"
                e_mail.IsBodyHtml = False
                e_mail.Body = "Your consultation record has been rejected"
                Smtp_Server.Send(e_mail)
                MsgBox("Mail Sent")

            Catch error_t As Exception
                MsgBox(error_t.ToString)
            End Try
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        sql = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;"
        conn = New OleDbConnection(sql)
        DBDataAdapter = New OleDbDataAdapter()
        A = New DataTable()
        cmd = New OleDbCommand("StudentConsultationRecord")
        cmd.CommandType = CommandType.TableDirect
        DBDataAdapter.SelectCommand = cmd
        DBDataAdapter.SelectCommand.Connection = conn
        conn.Open()
        DBDataAdapter.Fill(A)
        dgvView.DataSource = A
        conn.Close()
        A.DefaultView.RowFilter = "LecturerName Like '%" & b& & "%'"
    End Sub

    Private Sub txtAppointmentID2_GotFocus(sender As Object, e As EventArgs) Handles txtAppointmentID2.GotFocus
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(txtAppointmentID2, "Please Enter Appointment ID Here !")
    End Sub

    Private Sub txtStudentName_GotFocus(sender As Object, e As EventArgs) Handles txtStudentName.GotFocus
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(txtStudentName, "Please Enter Student Name Here !")
    End Sub

    Private Sub txtStudentID_GotFocus(sender As Object, e As EventArgs) Handles txtStudentID.GotFocus
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(txtStudentID, "Please Enter Student ID Here !")
    End Sub

    Private Sub txtDate_GotFocus(sender As Object, e As EventArgs) Handles txtDate.GotFocus
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(txtDate, "Please Enter Date Here !")
    End Sub

    Private Sub txtTime_GotFocus(sender As Object, e As EventArgs) Handles txtTime.GotFocus
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(txtTime, "Please Enter Time Here !")
    End Sub

    Private Sub txtVenue_GotFocus(sender As Object, e As EventArgs) Handles txtVenue.GotFocus
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(txtVenue, "Please Enter Class Venue Here !")
    End Sub

    Private Sub txtReason_GotFocus(sender As Object, e As EventArgs) Handles txtReason.GotFocus
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(txtReason, "Please Enter Reason Here !")
    End Sub

    Private Sub txtWeek_GotFocus(sender As Object, e As EventArgs) Handles txtWeek.GotFocus
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(txtWeek, "Please Enter Week Here !")
    End Sub

    Private Sub txtStatus_GotFocus(sender As Object, e As EventArgs) Handles txtStatus.GotFocus
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(txtStatus, "Please Enter Status Here !")
    End Sub
End Class