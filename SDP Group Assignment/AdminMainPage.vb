Imports System.Speech.Synthesis
Imports System.Data.OleDb
Public Class AdminMainPage
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim sql As String
    Dim dr As OleDbDataReader
    Dim a As String

    Private Sub btnViewFeedback_Click(sender As Object, e As EventArgs)
        Me.Close()
        AdminViewFeedback.Show()
    End Sub

    Private Sub btnPublishTimetable_Click(sender As Object, e As EventArgs)
        Me.Close()
        PublishTimetable.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs)
        Me.Close()
        Report.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl1.Click

    End Sub




    Private Sub pb1_Click(sender As Object, e As EventArgs) Handles pb1.Click
        p1.Location = New Size(0, 0)
        pb1.Hide()


    End Sub

    Private Sub pb1_MouseEnter(sender As Object, e As EventArgs) Handles pb1.MouseEnter
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(pb1, "Navigation Bar")
    End Sub



    Private Sub AdminMainPage_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        p1.Location = New Size(-170, 0)
        Panel1.BackColor = Color.WhiteSmoke
        Panel3.BackColor = Color.WhiteSmoke
        Panel4.BackColor = Color.WhiteSmoke
        pb1.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim x = MessageBox.Show("Admin are you sure you want to log out?", "Admin are you sure you want to log out?", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If x = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Login.Show()
        End If
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.BackColor = Color.DarkGray
        p1.Location = New Size(-170, 0)
        Panel1.BackColor = Color.WhiteSmoke
        Panel3.BackColor = Color.WhiteSmoke
        Panel4.BackColor = Color.WhiteSmoke
        pb1.Show()
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.BackColor = Color.DarkGray
        p1.Location = New Size(-170, 0)
        Panel1.BackColor = Color.WhiteSmoke
        Panel3.BackColor = Color.WhiteSmoke
        Panel4.BackColor = Color.WhiteSmoke
        pb1.Show()
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackColor = Color.WhiteSmoke
    End Sub


    Private Sub Panel2_MouseEnter(sender As Object, e As EventArgs) Handles Panel2.MouseEnter
        p1.Location = New Size(-170, 0)
        Panel1.BackColor = Color.WhiteSmoke
        Panel3.BackColor = Color.WhiteSmoke
        Panel4.BackColor = Color.WhiteSmoke
        pb1.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles pt1.Click
        Me.Close()
        PublishTimetable.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles pt2.Click
        Me.Close()
        AdminViewFeedback.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles pt3.Click

        Report.Show()
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles pt1.MouseEnter
        pt1.Size = New Size(90, 83)
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles pt1.MouseLeave
        pt1.Size = New Size(82, 75)
    End Sub
    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles pt2.MouseEnter
        pt2.Size = New Size(90, 83)
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles pt2.MouseLeave
        pt2.Size = New Size(82, 75)
    End Sub
    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles pt3.MouseEnter
        pt3.Size = New Size(90, 83)
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles pt3.MouseLeave
        pt3.Size = New Size(82, 75)
    End Sub





    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter
        Panel1.BackColor = Color.DarkGray
    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave
        Panel1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        Me.Close()
        PublishTimetable.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()
        PublishTimetable.Show()
    End Sub

    Private Sub Label6_MouseEnter(sender As Object, e As EventArgs) Handles Label6.MouseEnter
        Panel1.BackColor = Color.DarkGray
    End Sub

    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles Label6.MouseLeave
        Panel1.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick
        Me.Close()
        AdminViewFeedback.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()
        AdminViewFeedback.Show()
    End Sub

    Private Sub Label7_MouseEnter(sender As Object, e As EventArgs) Handles Label7.MouseEnter
        Panel3.BackColor = Color.DarkGray
    End Sub

    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles Label7.MouseLeave
        Panel3.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub Panel4_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel4.MouseClick
        Me.Close()
        Report.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()
        Report.Show()
    End Sub

    Private Sub Label8_MouseEnter(sender As Object, e As EventArgs) Handles Label8.MouseEnter
        Panel4.BackColor = Color.DarkGray
    End Sub

    Private Sub Label8_MouseLeave(sender As Object, e As EventArgs) Handles Label8.MouseLeave
        Panel4.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub AdminMainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim datenow2 As DateTime = System.DateTime.Now
        'Dim si As Integer = 0
        'Dim sii As Integer = 0
        'While (si < 10)
        '    If datenow2.DayOfWeek = DayOfWeek.Monday Then
        '        lbhaha.Items.Add(datenow2.ToString("dd/MM/yyyy"))
        '        si = si + 1
        '    End If
        '    datenow2 = datenow2.AddDays(-1)
        'End While
        'For sii = 0 To 9
        '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        '    conn.Open()
        '    Sql = "DELETE * FROM Timetable WHERE [Week]=@WK"
        '    cmd = New OleDbCommand(Sql, conn)
        '    cmd.Parameters.AddWithValue("@WK", lbhaha.Items(sii))
        '    cmd.ExecuteNonQuery()
        '    conn.Close()
        'Next
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class