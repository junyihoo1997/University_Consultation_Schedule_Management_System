Imports System.Data.OleDb
Public Class StudentMainPage
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim sql As String
    Dim dr As OleDbDataReader
    Dim a As String
    Private Sub btnBookConsultation_Click(sender As Object, e As EventArgs)
        Me.Close()
        BookConsultation.Show()
    End Sub

    Private Sub btnViewLecturerTimetable_Click(sender As Object, e As EventArgs)
        Me.Close()
        ViewLecturerTimetable.Show()
    End Sub

    Private Sub btnFeedback_Click(sender As Object, e As EventArgs)
        Me.Close()
        Feedback.Show()
    End Sub

    Private Sub btnNortification_Click(sender As Object, e As EventArgs)

        StudentViewConsultationSlot.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs)
        Dim x = MessageBox.Show("Student are you sure you want to log out?", "Student are you sure you want to log out?", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If x = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Login.Show()
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub pb2_Click(sender As Object, e As EventArgs) Handles pb2.Click
        Application.Exit()
    End Sub

    Private Sub pb1_Click(sender As Object, e As EventArgs) Handles pb1.Click
        Dim x = MessageBox.Show("Student are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If x = System.Windows.Forms.DialogResult.Yes Then
            nor1 = 0
            Me.Close()
            Login.Show()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pb2.Click
        Application.Exit()
    End Sub



    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
        ViewLecturerTimetable.Show()
    End Sub

    Private Sub lbl1_Click(sender As Object, e As EventArgs) Handles lbl1.Click
        Me.Close()
        ViewLecturerTimetable.Show()
    End Sub

    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        Me.Close()
        ViewLecturerTimetable.Show()
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        Panel1.BackColor = Color.DarkGray
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        Panel1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub lbl1_MouseEnter(sender As Object, e As EventArgs) Handles lbl1.MouseEnter
        Panel1.BackColor = Color.DarkGray
    End Sub

    Private Sub lbl1_MouseLeave(sender As Object, e As EventArgs) Handles lbl1.MouseLeave
        Panel1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter
        Panel1.BackColor = Color.DarkGray
    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave
        Panel1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
        BookConsultation.Show()
    End Sub

    Private Sub lbl2_Click(sender As Object, e As EventArgs) Handles lbl2.Click
        Me.Close()
        BookConsultation.Show()
    End Sub

    Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick
        Me.Close()
        BookConsultation.Show()
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        Panel3.BackColor = Color.DarkGray
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        Panel3.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub lbl2_MouseEnter(sender As Object, e As EventArgs) Handles lbl2.MouseEnter
        Panel3.BackColor = Color.DarkGray
    End Sub

    Private Sub lbl2_MouseLeave(sender As Object, e As EventArgs) Handles lbl2.MouseLeave
        Panel3.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Panel3_MouseEnter(sender As Object, e As EventArgs) Handles Panel3.MouseEnter
        Panel3.BackColor = Color.DarkGray
    End Sub

    Private Sub Panel3_MouseLeave(sender As Object, e As EventArgs) Handles Panel3.MouseLeave
        Panel3.BackColor = Color.WhiteSmoke
    End Sub




    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
        Feedback.Show()
    End Sub

    Private Sub lbl3_Click(sender As Object, e As EventArgs) Handles lbl3.Click
        Me.Close()
        Feedback.Show()
    End Sub

    Private Sub Panel4_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel4.MouseClick
        Me.Close()
        Feedback.Show()
    End Sub

    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox5.MouseEnter
        Panel4.BackColor = Color.DarkGray
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        Panel4.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub lbl3_MouseEnter(sender As Object, e As EventArgs) Handles lbl3.MouseEnter
        Panel4.BackColor = Color.DarkGray
    End Sub

    Private Sub lbl3_MouseLeave(sender As Object, e As EventArgs) Handles lbl3.MouseLeave
        Panel4.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Panel4_MouseEnter(sender As Object, e As EventArgs) Handles Panel4.MouseEnter
        Panel4.BackColor = Color.DarkGray
    End Sub

    Private Sub Panel4_MouseLeave(sender As Object, e As EventArgs) Handles Panel4.MouseLeave
        Panel4.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub StudentMainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM StudentConsultationRecord Where [StudentName]=@SN and [Status]='Approved'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@SN", b)
        dr = cmd.ExecuteReader()
        If (dr.HasRows) Then

            norti.BackgroundImage = My.Resources.nortificationactive
            If nor1 = 1 Then

                norti.BackgroundImage = My.Resources.nortificationnonactive
            End If

        Else
                norti.BackgroundImage = My.Resources.nortificationnonactive


        End If

        conn.Close()
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
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) 

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) 
        Me.Close()
        StudentViewConsultationSlot.Show()
    End Sub

    Private Sub norti_Click(sender As Object, e As EventArgs) Handles norti.Click

        StudentViewConsultationSlot.Show()

        nor1 = 1
        StudentMainPage_Load(e, e)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lbl4.Click
        Me.Close()
        StudentCancelConsultation.Show()
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        Me.Close()
        StudentCancelConsultation.Show()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        StudentCancelConsultation.Show()
    End Sub
    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        Panel5.BackColor = Color.DarkGray
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Panel5.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub lbl4_MouseEnter(sender As Object, e As EventArgs) Handles lbl4.MouseEnter
        Panel5.BackColor = Color.DarkGray
    End Sub

    Private Sub lbl4_MouseLeave(sender As Object, e As EventArgs) Handles lbl4.MouseLeave
        Panel5.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Panel5_MouseEnter(sender As Object, e As EventArgs) Handles Panel5.MouseEnter
        Panel5.BackColor = Color.DarkGray
    End Sub

    Private Sub Panel5_MouseLeave(sender As Object, e As EventArgs) Handles Panel5.MouseLeave
        Panel5.BackColor = Color.WhiteSmoke
    End Sub
End Class