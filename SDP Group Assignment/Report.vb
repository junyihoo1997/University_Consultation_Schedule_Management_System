Imports System.Data.OleDb
Public Class Report
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim sql As String


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        AdminMainPage.Show()
    End Sub

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        sql = "SELECT AppointmentID, StudentName, StudentID, DayOfTheWeek, Venue, Reason, [Time], Week, LecturerName, Status From StudentConsultationRecord Where (Status = 'Approved')"
        Dim hahaha As New DataSet
        Dim lol As New OleDb.OleDbDataAdapter(sql, conn)
        conn.Open()
        lol.Fill(hahaha, "StudentConsultationRecord")
        conn.Close()
        Dim DTTB As DataTable = hahaha.Tables("StudentConsultationRecord")
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", DTTB))
        ReportViewer1.LocalReport.ReportPath = IO.Path.Combine(IO.Directory.GetParent(IO.Directory.GetParent(IO.Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName, "Consultation.rdlc")
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class