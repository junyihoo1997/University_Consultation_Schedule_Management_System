Imports System.Data.OleDb
Public Class Feedback
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim DBDataAdapter As OleDbDataAdapter
    Dim sql As String
    Dim A As DataTable
    Dim dr As OleDbDataReader
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        StudentMainPage.Show()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtAppID.Text = "" Or txtWeek.Text = "" Or txtDay.Text = "" Or txtTime.Text = "" Or RichTextBox1.Text = "" Then
            MessageBox.Show("One field or more is Empty! Please Enter Correctly!")
        Else
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open()
            sql = "INSERT INTO FEEDBACK([AppointmentID],[Week],[Day],[Time],[Comments]) VALUES (@APPID,@WK,@DY,@TM,@CM)"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@APPID", txtAppID.Text)
            cmd.Parameters.AddWithValue("@WK", txtWeek.Text)
            cmd.Parameters.AddWithValue("@DY", txtDay.Text)
            cmd.Parameters.AddWithValue("@TM", txtTime.Text)
            cmd.Parameters.AddWithValue("@CM", RichTextBox1.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Feedback Submit Successfully. Enter Next Feedback Details.")
            conn.Close()
            ClearAll()
        End If

    End Sub
    Sub ClearAll()
        txtAppID.Text = ""
        txtWeek.Text = ""
        txtDay.Text = ""
        txtTime.Text = ""
        RichTextBox1.Clear()
    End Sub
    Private Sub dgvView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvView.CellDoubleClick
        Dim row As Integer = e.RowIndex
        If row = -1 Then
            Exit Sub
        End If
        txtAppID.Text = dgvView.Rows(row).Cells(0).Value
        txtWeek.Text = dgvView.Rows(row).Cells(7).Value
        txtDay.Text = dgvView.Rows(row).Cells(3).Value
        txtTime.Text = dgvView.Rows(row).Cells(6).Value
    End Sub

    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;"
        conn = New OleDbConnection(sql)
        DBDataAdapter = New OleDbDataAdapter()
        a = New DataTable()
        cmd = New OleDbCommand("StudentConsultationRecord")
        cmd.CommandType = CommandType.TableDirect
        DBDataAdapter.SelectCommand = cmd
        DBDataAdapter.SelectCommand.Connection = conn
        conn.Open()
        DBDataAdapter.Fill(A)
        dgvView.DataSource = A
        conn.Close()
        A.DefaultView.RowFilter = "Status Like '%" & "Approved" & "%'"
    End Sub

    Private Sub txtAppID_GotFocus(sender As Object, e As EventArgs)
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(txtAppID, "Please Enter Appointment ID Here !")
    End Sub

    Private Sub txtWeek_GotFocus(sender As Object, e As EventArgs)
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(txtWeek, "Please Enter Week Here !")
    End Sub

    Private Sub txtDay_GotFocus(sender As Object, e As EventArgs)
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(txtDay, "Please Enter Day Here !")
    End Sub

    Private Sub txtTime_GotFocus(sender As Object, e As EventArgs)
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(txtTime, "Please Enter Time Here !")
    End Sub

    Private Sub RichTextBox1_GotFocus(sender As Object, e As EventArgs) Handles RichTextBox1.GotFocus
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(RichTextBox1, "Please Enter Comments Here !")
    End Sub
End Class