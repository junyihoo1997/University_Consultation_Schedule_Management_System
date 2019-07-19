Imports System.Data.OleDb
Public Class LecturerMainPage
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim sql As String
    Dim dr As OleDbDataReader
    Dim a As String
    Private Sub btnViewTimetable_Click(sender As Object, e As EventArgs)
        Me.Close()
        ViewTimetable.Show()
    End Sub

    Private Sub btnPublishConsultationSchedule_Click(sender As Object, e As EventArgs)
        Me.Close()
        SelectWeek.Show()
    End Sub

    Private Sub btnConsultationRecord_Click(sender As Object, e As EventArgs)
        Me.Close()
        ConsultationRecord.Show()
    End Sub



    Private Sub btnLogOut_Click(sender As Object, e As EventArgs)
        Dim x = MessageBox.Show("Lecturer are you sure you want to log out?", "Lecturer are you sure you want to log out?", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If x = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Login.Show()
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim x = MessageBox.Show("Lecturer are you sure you want to log out?", "Lecturer are you sure you want to log out?", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If x = System.Windows.Forms.DialogResult.Yes Then
            nor2 = 0
            Me.Close()
            Login.Show()
        End If
    End Sub



    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles p1.Click
        Me.Close()
        ViewTimetable.Show()
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles p1.MouseEnter
        pn1.BackColor = Color.DarkGray
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles p1.MouseLeave
        pn1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub pn1_MouseClick(sender As Object, e As MouseEventArgs) Handles pn1.MouseClick
        Me.Close()
        ViewTimetable.Show()
    End Sub

    Private Sub pn1_MouseEnter(sender As Object, e As EventArgs) Handles pn1.MouseEnter
        pn1.BackColor = Color.DarkGray
    End Sub

    Private Sub pn1_MouseLeave(sender As Object, e As EventArgs) Handles pn1.MouseLeave
        pn1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub lbl1_Click(sender As Object, e As EventArgs) Handles lbl1.Click
        Me.Close()
        ViewTimetable.Show()
    End Sub

    Private Sub lbl1_MouseEnter(sender As Object, e As EventArgs) Handles lbl1.MouseEnter
        pn1.BackColor = Color.DarkGray
    End Sub

    Private Sub lbl1_MouseLeave(sender As Object, e As EventArgs) Handles lbl1.MouseLeave
        pn1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub p2_Click(sender As Object, e As EventArgs) Handles p2.Click
        Me.Close()
        SelectWeek.Show()
    End Sub

    Private Sub p2_MouseEnter(sender As Object, e As EventArgs) Handles p2.MouseEnter
        pn2.BackColor = Color.DarkGray
    End Sub

    Private Sub p2_MouseLeave(sender As Object, e As EventArgs) Handles p2.MouseLeave
        pn2.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub pn2_MouseClick(sender As Object, e As MouseEventArgs) Handles pn2.MouseClick
        Me.Close()
        SelectWeek.Show()
    End Sub

    Private Sub pn2_MouseEnter(sender As Object, e As EventArgs) Handles pn2.MouseEnter
        pn2.BackColor = Color.DarkGray
    End Sub

    Private Sub pn2_MouseLeave(sender As Object, e As EventArgs) Handles pn2.MouseLeave
        pn2.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub lbl2_Click(sender As Object, e As EventArgs) Handles lbl2.Click
        Me.Close()
        SelectWeek.Show()
    End Sub

    Private Sub lbl2_MouseEnter(sender As Object, e As EventArgs) Handles lbl2.MouseEnter
        pn2.BackColor = Color.DarkGray
    End Sub

    Private Sub lbl2_MouseLeave(sender As Object, e As EventArgs) Handles lbl2.MouseLeave
        pn2.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub p3_Click(sender As Object, e As EventArgs) Handles p3.Click
        Me.Close()
        ConsultationRecord.Show()
    End Sub

    Private Sub p3_MouseEnter(sender As Object, e As EventArgs) Handles p3.MouseEnter
        pn3.BackColor = Color.DarkGray
    End Sub

    Private Sub p3_MouseLeave(sender As Object, e As EventArgs) Handles p3.MouseLeave
        pn3.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub pn3_MouseClick(sender As Object, e As MouseEventArgs) Handles pn3.MouseClick
        Me.Close()
        ConsultationRecord.Show()
    End Sub

    Private Sub pn3_MouseEnter(sender As Object, e As EventArgs) Handles pn3.MouseEnter
        pn3.BackColor = Color.DarkGray
    End Sub

    Private Sub pn3_MouseLeave(sender As Object, e As EventArgs) Handles pn3.MouseLeave
        pn3.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub lbl3_Click(sender As Object, e As EventArgs) Handles lbl3.Click
        Me.Close()
        ConsultationRecord.Show()
    End Sub

    Private Sub lbl3_MouseEnter(sender As Object, e As EventArgs) Handles lbl3.MouseEnter
        pn3.BackColor = Color.DarkGray
    End Sub

    Private Sub lbl3_MouseLeave(sender As Object, e As EventArgs) Handles lbl3.MouseLeave
        pn3.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.BackColor = Color.DarkGray
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.BackColor = Color.DarkGray
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub LecturerMainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        '    sql = "DELETE * FROM Timetable WHERE [Week]=@WK"
        '    cmd = New OleDbCommand(sql, conn)
        '    cmd.Parameters.AddWithValue("@WK", lbhaha.Items(sii))
        '    cmd.ExecuteNonQuery()
        '    conn.Close()
        'Next
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where [Lecturer]=@LTR"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LTR", b)
        dr = cmd.ExecuteReader()
        If (dr.HasRows) Then
            dr.Read()
            If dr.Item("ClassVenue") = "" Then
                norti.BackgroundImage = My.Resources.nortificationnonactive
            Else

                norti.BackgroundImage = My.Resources.nortificationactive
                If nor2 = 1 Then
                    norti.BackgroundImage = My.Resources.nortificationnonactive
                End If

            End If

        End If
        conn.Close()
    End Sub

    Private Sub norti_Click_1(sender As Object, e As EventArgs) Handles norti.Click
        LecturerNortification.Show()
        nor2 = 1
        LecturerMainPage_Load(e, e)
    End Sub
End Class