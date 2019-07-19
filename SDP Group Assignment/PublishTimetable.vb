Imports System.Data.OleDb
Imports System.Net.Mail
Imports System
Public Class PublishTimetable
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim sql As String
    Dim dr As OleDbDataReader
    Dim a As String
    Dim ButtonClick As Boolean = False
    Dim buton1 As Boolean = False
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles rtbNote.TextChanged

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        AdminMainPage.Show()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    'Private Sub pb1_Click(sender As Object, e As EventArgs)
    '    pb1.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb1_MouseLeave(sender As Object, e As EventArgs)
    '    pb1.BackColor = Color.White
    'End Sub
    'Private Sub pb1_MouseClick(sender As Object, e As EventArgs) Handles pb1.Click
    '    cboDayOfTheWeek.Text = "Monday"
    '    cboClassDuration.Text = "8-9"
    'End Sub

    'Private Sub pb2_Click(sender As Object, e As EventArgs)
    '    pb2.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb2_MouseLeave(sender As Object, e As EventArgs)
    '    pb2.BackColor = Color.White
    'End Sub
    'Private Sub pb2_MouseClick(sender As Object, e As EventArgs) Handles pb2.Click
    '    cboDayOfTheWeek.Text = "Monday"
    '    cboClassDuration.Text = "9-10"
    'End Sub
    'Private Sub pb3_Click(sender As Object, e As EventArgs)
    '    pb3.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb3_MouseLeave(sender As Object, e As EventArgs)
    '    pb3.BackColor = Color.White
    'End Sub
    'Private Sub pb3_MouseClick(sender As Object, e As EventArgs) Handles pb3.Click
    '    cboDayOfTheWeek.Text = "Monday"
    '    cboClassDuration.Text = "10-11"
    'End Sub
    'Private Sub pb4_Click(sender As Object, e As EventArgs)
    '    pb4.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb4_MouseLeave(sender As Object, e As EventArgs)
    '    pb4.BackColor = Color.White
    'End Sub
    'Private Sub pb4_MouseClick(sender As Object, e As EventArgs) Handles pb4.Click
    '    cboDayOfTheWeek.Text = "Monday"
    '    cboClassDuration.Text = "11-12"
    'End Sub
    'Private Sub pb5_Click(sender As Object, e As EventArgs)
    '    pb5.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb5_MouseLeave(sender As Object, e As EventArgs)
    '    pb5.BackColor = Color.White
    'End Sub
    'Private Sub pb5_MouseClick(sender As Object, e As EventArgs) Handles pb5.Click
    '    cboDayOfTheWeek.Text = "Monday"
    '    cboClassDuration.Text = "13-14"
    'End Sub
    'Private Sub pb6_Click(sender As Object, e As EventArgs)
    '    pb6.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb6_MouseLeave(sender As Object, e As EventArgs)
    '    pb6.BackColor = Color.White
    'End Sub
    'Private Sub pb6_MouseClick(sender As Object, e As EventArgs) Handles pb6.Click
    '    cboDayOfTheWeek.Text = "Monday"
    '    cboClassDuration.Text = "14-15"
    'End Sub
    'Private Sub pb7_Click(sender As Object, e As EventArgs)
    '    pb7.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb7_MouseLeave(sender As Object, e As EventArgs)
    '    pb7.BackColor = Color.White
    'End Sub
    'Private Sub pb7_MouseClick(sender As Object, e As EventArgs) Handles pb7.Click
    '    cboDayOfTheWeek.Text = "Monday"
    '    cboClassDuration.Text = "15-16"
    'End Sub
    'Private Sub pb8_Click(sender As Object, e As EventArgs)
    '    pb8.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb8_MouseLeave(sender As Object, e As EventArgs)
    '    pb8.BackColor = Color.White
    'End Sub
    'Private Sub pb8_MouseClick(sender As Object, e As EventArgs) Handles pb8.Click
    '    cboDayOfTheWeek.Text = "Monday"
    '    cboClassDuration.Text = "16-17"
    'End Sub
    'Private Sub pb9_Click(sender As Object, e As EventArgs)
    '    pb9.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb9_MouseLeave(sender As Object, e As EventArgs)
    '    pb9.BackColor = Color.White
    'End Sub
    'Private Sub pb9_MouseClick(sender As Object, e As EventArgs) Handles pb9.Click
    '    cboDayOfTheWeek.Text = "Monday"
    '    cboClassDuration.Text = "17-18"
    'End Sub
    'Private Sub pb10_Click(sender As Object, e As EventArgs)
    '    pb10.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb10_MouseLeave(sender As Object, e As EventArgs)
    '    pb10.BackColor = Color.White
    'End Sub
    'Private Sub pb10_MouseClick(sender As Object, e As EventArgs) Handles pb10.Click
    '    cboDayOfTheWeek.Text = "Tuesday"
    '    cboClassDuration.Text = "8-9"
    'End Sub

    'Private Sub pb11_Click(sender As Object, e As EventArgs)
    '    pb11.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb11_MouseLeave(sender As Object, e As EventArgs)
    '    pb11.BackColor = Color.White
    'End Sub
    'Private Sub pb11_MouseClick(sender As Object, e As EventArgs) Handles pb11.Click
    '    cboDayOfTheWeek.Text = "Tuesday"
    '    cboClassDuration.Text = "9-10"
    'End Sub
    'Private Sub pb12_Click(sender As Object, e As EventArgs)
    '    pb12.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb12_MouseLeave(sender As Object, e As EventArgs)
    '    pb12.BackColor = Color.White
    'End Sub
    'Private Sub pb12_MouseClick(sender As Object, e As EventArgs) Handles pb12.Click
    '    cboDayOfTheWeek.Text = "Tuesday"
    '    cboClassDuration.Text = "10-11"
    'End Sub
    'Private Sub pb13_Click(sender As Object, e As EventArgs)
    '    pb13.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb13_MouseLeave(sender As Object, e As EventArgs)
    '    pb13.BackColor = Color.White
    'End Sub
    'Private Sub pb13_MouseClick(sender As Object, e As EventArgs) Handles pb13.Click
    '    cboDayOfTheWeek.Text = "Tuesday"
    '    cboClassDuration.Text = "11-12"
    'End Sub
    'Private Sub pb14_Click(sender As Object, e As EventArgs)
    '    pb14.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb14_MouseLeave(sender As Object, e As EventArgs)
    '    pb14.BackColor = Color.White
    'End Sub
    'Private Sub pb14_MouseClick(sender As Object, e As EventArgs) Handles pb14.Click
    '    cboDayOfTheWeek.Text = "Tuesday"
    '    cboClassDuration.Text = "13-14"
    'End Sub
    'Private Sub pb15_Click(sender As Object, e As EventArgs)
    '    pb15.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb15_MouseLeave(sender As Object, e As EventArgs)
    '    pb15.BackColor = Color.White
    'End Sub
    'Private Sub pb15_MouseClick(sender As Object, e As EventArgs) Handles pb15.Click
    '    cboDayOfTheWeek.Text = "Tuesday"
    '    cboClassDuration.Text = "14-15"
    'End Sub
    'Private Sub pb16_Click(sender As Object, e As EventArgs)
    '    pb16.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb16_MouseLeave(sender As Object, e As EventArgs)
    '    pb16.BackColor = Color.White
    'End Sub
    'Private Sub pb16_MouseClick(sender As Object, e As EventArgs) Handles pb16.Click
    '    cboDayOfTheWeek.Text = "Tuesday"
    '    cboClassDuration.Text = "15-16"
    'End Sub
    'Private Sub pb17_Click(sender As Object, e As EventArgs)
    '    pb17.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb17_MouseLeave(sender As Object, e As EventArgs)
    '    pb17.BackColor = Color.White
    'End Sub
    'Private Sub pb17_MouseClick(sender As Object, e As EventArgs) Handles pb17.Click
    '    cboDayOfTheWeek.Text = "Tuesday"
    '    cboClassDuration.Text = "16-17"
    'End Sub
    'Private Sub pb18_Click(sender As Object, e As EventArgs)
    '    pb18.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb18_MouseLeave(sender As Object, e As EventArgs)
    '    pb18.BackColor = Color.White
    'End Sub
    'Private Sub pb18_MouseClick(sender As Object, e As EventArgs) Handles pb18.Click
    '    cboDayOfTheWeek.Text = "Tuesday"
    '    cboClassDuration.Text = "17-18"
    'End Sub
    'Private Sub pb19_Click(sender As Object, e As EventArgs)
    '    pb19.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb19_MouseLeave(sender As Object, e As EventArgs)
    '    pb19.BackColor = Color.White
    'End Sub
    'Private Sub pb19_MouseClick(sender As Object, e As EventArgs) Handles pb19.Click
    '    cboDayOfTheWeek.Text = "Wednesday"
    '    cboClassDuration.Text = "8-9"
    'End Sub

    'Private Sub pb20_Click(sender As Object, e As EventArgs)
    '    pb20.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb20_MouseLeave(sender As Object, e As EventArgs)
    '    pb20.BackColor = Color.White
    'End Sub
    'Private Sub pb20_MouseClick(sender As Object, e As EventArgs) Handles pb20.Click
    '    cboDayOfTheWeek.Text = "Wednesday"
    '    cboClassDuration.Text = "9-10"
    'End Sub
    'Private Sub pb21_Click(sender As Object, e As EventArgs)
    '    pb21.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb21_MouseLeave(sender As Object, e As EventArgs)
    '    pb21.BackColor = Color.White
    'End Sub
    'Private Sub pb21_MouseClick(sender As Object, e As EventArgs) Handles pb21.Click
    '    cboDayOfTheWeek.Text = "Wednesday"
    '    cboClassDuration.Text = "10-11"
    'End Sub
    'Private Sub pb22_Click(sender As Object, e As EventArgs)
    '    pb22.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb22_MouseLeave(sender As Object, e As EventArgs)
    '    pb22.BackColor = Color.White
    'End Sub
    'Private Sub pb22_MouseClick(sender As Object, e As EventArgs) Handles pb22.Click
    '    cboDayOfTheWeek.Text = "Wednesday"
    '    cboClassDuration.Text = "11-12"
    'End Sub
    'Private Sub pb23_Click(sender As Object, e As EventArgs)
    '    pb23.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb23_MouseLeave(sender As Object, e As EventArgs)
    '    pb23.BackColor = Color.White
    'End Sub
    'Private Sub pb23_MouseClick(sender As Object, e As EventArgs) Handles pb23.Click
    '    cboDayOfTheWeek.Text = "Wednesday"
    '    cboClassDuration.Text = "13-14"
    'End Sub
    'Private Sub pb24_Click(sender As Object, e As EventArgs)
    '    pb24.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb24_MouseLeave(sender As Object, e As EventArgs)
    '    pb24.BackColor = Color.White
    'End Sub
    'Private Sub pb24_MouseClick(sender As Object, e As EventArgs) Handles pb24.Click
    '    cboDayOfTheWeek.Text = "Wednesday"
    '    cboClassDuration.Text = "14-15"
    'End Sub
    'Private Sub pb25_Click(sender As Object, e As EventArgs)
    '    pb25.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb25_MouseLeave(sender As Object, e As EventArgs)
    '    pb25.BackColor = Color.White
    'End Sub
    'Private Sub pb25_MouseClick(sender As Object, e As EventArgs) Handles pb25.Click
    '    cboDayOfTheWeek.Text = "Wednesday"
    '    cboClassDuration.Text = "15-16"
    'End Sub
    'Private Sub pb26_Click(sender As Object, e As EventArgs)
    '    pb26.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb26_MouseLeave(sender As Object, e As EventArgs)
    '    pb26.BackColor = Color.White
    'End Sub
    'Private Sub pb26_MouseClick(sender As Object, e As EventArgs) Handles pb26.Click
    '    cboDayOfTheWeek.Text = "Wednesday"
    '    cboClassDuration.Text = "16-17"
    'End Sub
    'Private Sub pb27_Click(sender As Object, e As EventArgs)
    '    pb27.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb27_MouseLeave(sender As Object, e As EventArgs)
    '    pb27.BackColor = Color.White
    'End Sub
    'Private Sub pb27_MouseClick(sender As Object, e As EventArgs) Handles pb27.Click
    '    cboDayOfTheWeek.Text = "Wednesday"
    '    cboClassDuration.Text = "17-18"
    'End Sub
    'Private Sub pb28_Click(sender As Object, e As EventArgs)
    '    pb28.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb28_MouseLeave(sender As Object, e As EventArgs)
    '    pb28.BackColor = Color.White
    'End Sub
    'Private Sub pb28_MouseClick(sender As Object, e As EventArgs) Handles pb28.Click
    '    cboDayOfTheWeek.Text = "Thursday"
    '    cboClassDuration.Text = "8-9"
    'End Sub

    'Private Sub pb29_Click(sender As Object, e As EventArgs)
    '    pb29.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb29_MouseLeave(sender As Object, e As EventArgs)
    '    pb29.BackColor = Color.White
    'End Sub
    'Private Sub pb29_MouseClick(sender As Object, e As EventArgs) Handles pb29.Click
    '    cboDayOfTheWeek.Text = "Thursday"
    '    cboClassDuration.Text = "9-10"
    'End Sub
    'Private Sub pb30_Click(sender As Object, e As EventArgs)
    '    pb30.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb30_MouseLeave(sender As Object, e As EventArgs)
    '    pb30.BackColor = Color.White
    'End Sub
    'Private Sub pb30_MouseClick(sender As Object, e As EventArgs) Handles pb30.Click
    '    cboDayOfTheWeek.Text = "Thursday"
    '    cboClassDuration.Text = "10-11"
    'End Sub
    'Private Sub pb31_Click(sender As Object, e As EventArgs)
    '    pb31.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb31_MouseLeave(sender As Object, e As EventArgs)
    '    pb31.BackColor = Color.White
    'End Sub
    'Private Sub pb31_MouseClick(sender As Object, e As EventArgs) Handles pb31.Click
    '    cboDayOfTheWeek.Text = "Thursday"
    '    cboClassDuration.Text = "11-12"
    'End Sub
    'Private Sub pb32_Click(sender As Object, e As EventArgs)
    '    pb32.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb32_MouseLeave(sender As Object, e As EventArgs)
    '    pb32.BackColor = Color.White
    'End Sub
    'Private Sub pb32_MouseClick(sender As Object, e As EventArgs) Handles pb32.Click
    '    cboDayOfTheWeek.Text = "Thursday"
    '    cboClassDuration.Text = "13-14"
    'End Sub
    'Private Sub pb33_Click(sender As Object, e As EventArgs)
    '    pb33.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb33_MouseLeave(sender As Object, e As EventArgs)
    '    pb33.BackColor = Color.White
    'End Sub
    'Private Sub pb33_MouseClick(sender As Object, e As EventArgs) Handles pb33.Click
    '    cboDayOfTheWeek.Text = "Thursday"
    '    cboClassDuration.Text = "14-15"
    'End Sub
    'Private Sub pb34_Click(sender As Object, e As EventArgs)
    '    pb34.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb34_MouseLeave(sender As Object, e As EventArgs)
    '    pb34.BackColor = Color.White
    'End Sub
    'Private Sub pb34_MouseClick(sender As Object, e As EventArgs) Handles pb34.Click
    '    cboDayOfTheWeek.Text = "Thursday"
    '    cboClassDuration.Text = "15-16"
    'End Sub
    'Private Sub pb35_Click(sender As Object, e As EventArgs)
    '    pb35.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb35_MouseLeave(sender As Object, e As EventArgs)
    '    pb35.BackColor = Color.White
    'End Sub
    'Private Sub pb35_MouseClick(sender As Object, e As EventArgs) Handles pb35.Click
    '    cboDayOfTheWeek.Text = "Thursday"
    '    cboClassDuration.Text = "16-17"
    'End Sub
    'Private Sub pb36_Click(sender As Object, e As EventArgs)
    '    pb36.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb36_MouseLeave(sender As Object, e As EventArgs)
    '    pb36.BackColor = Color.White
    'End Sub
    'Private Sub pb36_MouseClick(sender As Object, e As EventArgs) Handles pb36.Click
    '    cboDayOfTheWeek.Text = "Thursday"
    '    cboClassDuration.Text = "17-18"
    'End Sub
    'Private Sub pb37_Click(sender As Object, e As EventArgs)
    '    pb37.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb37_MouseLeave(sender As Object, e As EventArgs)
    '    pb37.BackColor = Color.White
    'End Sub
    'Private Sub pb37_MouseClick(sender As Object, e As EventArgs) Handles pb37.Click
    '    cboDayOfTheWeek.Text = "Friday"
    '    cboClassDuration.Text = "8-9"
    'End Sub

    'Private Sub pb38_Click(sender As Object, e As EventArgs)
    '    pb38.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb38_MouseLeave(sender As Object, e As EventArgs)
    '    pb38.BackColor = Color.White
    'End Sub
    'Private Sub pb38_MouseClick(sender As Object, e As EventArgs) Handles pb38.Click
    '    cboDayOfTheWeek.Text = "Friday"
    '    cboClassDuration.Text = "9-10"
    'End Sub
    'Private Sub pb39_Click(sender As Object, e As EventArgs)
    '    pb39.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb39_MouseLeave(sender As Object, e As EventArgs)
    '    pb39.BackColor = Color.White
    'End Sub
    'Private Sub pb39_MouseClick(sender As Object, e As EventArgs) Handles pb39.Click
    '    cboDayOfTheWeek.Text = "Friday"
    '    cboClassDuration.Text = "10-11"
    'End Sub
    'Private Sub pb40_Click(sender As Object, e As EventArgs)
    '    pb40.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb40_MouseLeave(sender As Object, e As EventArgs)
    '    pb40.BackColor = Color.White
    'End Sub
    'Private Sub pb40_MouseClick(sender As Object, e As EventArgs) Handles pb40.Click
    '    cboDayOfTheWeek.Text = "Friday"
    '    cboClassDuration.Text = "11-12"
    'End Sub
    'Private Sub pb41_Click(sender As Object, e As EventArgs)
    '    pb41.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb41_MouseLeave(sender As Object, e As EventArgs)
    '    pb41.BackColor = Color.White
    'End Sub
    'Private Sub pb41_MouseClick(sender As Object, e As EventArgs) Handles pb41.Click
    '    cboDayOfTheWeek.Text = "Friday"
    '    cboClassDuration.Text = "13-14"
    'End Sub
    'Private Sub pb42_Click(sender As Object, e As EventArgs)
    '    pb42.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb42_MouseLeave(sender As Object, e As EventArgs)
    '    pb42.BackColor = Color.White
    'End Sub
    'Private Sub pb42_MouseClick(sender As Object, e As EventArgs) Handles pb42.Click
    '    cboDayOfTheWeek.Text = "Friday"
    '    cboClassDuration.Text = "14-15"
    'End Sub
    'Private Sub pb43_Click(sender As Object, e As EventArgs)
    '    pb43.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb43_MouseLeave(sender As Object, e As EventArgs)
    '    pb43.BackColor = Color.White
    'End Sub
    'Private Sub pb43_MouseClick(sender As Object, e As EventArgs) Handles pb43.Click
    '    cboDayOfTheWeek.Text = "Friday"
    '    cboClassDuration.Text = "15-16"
    'End Sub
    'Private Sub pb44_Click(sender As Object, e As EventArgs)
    '    pb44.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb44_MouseLeave(sender As Object, e As EventArgs)
    '    pb44.BackColor = Color.White
    'End Sub
    'Private Sub pb44_MouseClick(sender As Object, e As EventArgs) Handles pb44.Click
    '    cboDayOfTheWeek.Text = "Friday"
    '    cboClassDuration.Text = "16-17"
    'End Sub
    'Private Sub pb45_Click(sender As Object, e As EventArgs)
    '    pb45.BackColor = Color.LightSkyBlue
    'End Sub
    'Private Sub pb45_MouseLeave(sender As Object, e As EventArgs)
    '    pb45.BackColor = Color.White
    'End Sub
    'Private Sub pb45_MouseClick(sender As Object, e As EventArgs) Handles pb45.Click
    '    cboDayOfTheWeek.Text = "Friday"
    '    cboClassDuration.Text = "17-18"
    'End Sub

    Private Sub btnSaveData_Click(sender As Object, e As EventArgs) Handles btnSaveData.Click
        If txtCourse.Text = "" Or cboDayOfTheWeek.Text = "" Or cboClassDuration.Text = "" Or txtClassVenue.Text = "" Or cboWeekYear.Text = "" Or txtLecturerName.Text = "" Then
            MessageBox.Show("One Field is Empty! Please Enter Correctly!")
        Else
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Week=@WK and ClassDuration=@CD and DayOfTheWeek=DOTW and ClassVenue=@CV"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)
            cmd.Parameters.AddWithValue("@CD", cboClassDuration.Text)
            cmd.Parameters.AddWithValue("@DOTW", cboDayOfTheWeek.Text)
            cmd.Parameters.AddWithValue("@CV", txtClassVenue.Text)
            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                MessageBox.Show("The Room Has Been Used By Other Lecturer!")
            Else
                conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
                conn.Open() 'opens the connection
                sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration=@CD and DayOfTheWeek=DOTW"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
                cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)
                cmd.Parameters.AddWithValue("@CD", cboClassDuration.Text)
                cmd.Parameters.AddWithValue("@DOTW", cboDayOfTheWeek.Text)
                dr = cmd.ExecuteReader
                If (dr.HasRows) Then

                    dr.Read()
                    MessageBox.Show("You Can't Save Course In The Same Slot!")
                Else
                    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
                    conn.Open()
                    sql = "INSERT INTO TIMETABLE([Lecturer],[Course],[DayOfTheWeek],[ClassDuration],[ClassVenue],[Week],[IntakeSize]) VALUES (@LTR,@CR,@DOTW,@DR,@CV,@WK,@IS)"
                    cmd = New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@LTR", txtLecturerName.Text)
                    cmd.Parameters.AddWithValue("@CR", txtCourse.Text)
                    cmd.Parameters.AddWithValue("@DOTW", cboDayOfTheWeek.Text)
                    cmd.Parameters.AddWithValue("@DR", cboClassDuration.Text)
                    cmd.Parameters.AddWithValue("@CV", txtClassVenue.Text)
                    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)
                    cmd.Parameters.AddWithValue("@IS", cboIntakeSize.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Timetable Published Successfully. Enter Next Timetable Details.")
                    conn.Close()
                    ClearAll()
                    ClearTimeTable()
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
                        e_mail.Body = "Timetable has been published! Please login to the system to see more details!"
                        Smtp_Server.Send(e_mail)
                        MsgBox("Mail Sent")

                    Catch error_t As Exception
                        MsgBox(error_t.ToString)
                    End Try


                    conn.Close()
                End If



        End If
        End If
    End Sub
    Sub ClearTimeTable()
        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""
        btn10.Text = ""
        btn11.Text = ""
        btn12.Text = ""
        btn13.Text = ""
        btn14.Text = ""
        btn15.Text = ""
        btn16.Text = ""
        btn17.Text = ""
        btn18.Text = ""
        btn19.Text = ""
        btn20.Text = ""
        btn21.Text = ""
        btn22.Text = ""
        btn23.Text = ""
        btn24.Text = ""
        btn25.Text = ""
        btn26.Text = ""
        btn27.Text = ""
        btn28.Text = ""
        btn29.Text = ""
        btn30.Text = ""
        btn31.Text = ""
        btn32.Text = ""
        btn33.Text = ""
        btn34.Text = ""
        btn35.Text = ""
        btn36.Text = ""
        btn37.Text = ""
        btn38.Text = ""
        btn39.Text = ""
        btn40.Text = ""
        btn41.Text = ""
        btn42.Text = ""
        btn43.Text = ""
        btn44.Text = ""
        btn45.Text = ""
        lbl1.Text = ""
        lbl2.Text = ""
        lbl3.Text = ""
        lbl4.Text = ""
        lbl5.Text = ""
        lbl6.Text = ""
        lbl7.Text = ""
        lbl8.Text = ""
        lbl9.Text = ""
        lbl10.Text = ""
        lbl11.Text = ""
        lbl12.Text = ""
        lbl13.Text = ""
        lbl14.Text = ""
        lbl15.Text = ""
        lbl16.Text = ""
        lbl17.Text = ""
        lbl18.Text = ""
        lbl19.Text = ""
        lbl20.Text = ""
        lbl21.Text = ""
        lbl22.Text = ""
        lbl23.Text = ""
        lbl24.Text = ""
        lbl25.Text = ""
        lbl26.Text = ""
        lbl27.Text = ""
        lbl28.Text = ""
        lbl29.Text = ""
        lbl30.Text = ""
        lbl31.Text = ""
        lbl32.Text = ""
        lbl33.Text = ""
        lbl34.Text = ""
        lbl35.Text = ""
        lbl36.Text = ""
        lbl37.Text = ""
        lbl38.Text = ""
        lbl39.Text = ""
        lbl40.Text = ""
        lbl41.Text = ""
        lbl42.Text = ""
        lbl43.Text = ""
        lbl44.Text = ""
        lbl45.Text = ""
    End Sub
    Sub ClearAll()
        cboIntakeSize.ResetText()
        cboWeekYear.ResetText()
        txtLecturerName.ResetText()
        txtCourse.ResetText()
        cboDayOfTheWeek.ResetText()
        cboClassDuration.ResetText()
        txtClassVenue.ResetText()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearAll()
    End Sub

    Private Sub PublishTimetable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datenow As DateTime = System.DateTime.Now
        Dim i As Integer = 0
        While (i < 10)
            If datenow.DayOfWeek = DayOfWeek.Monday Then
                cboWeekYear.Items.Add(datenow.ToString("dd/MM/yyyy"))
                i = i + 1
            End If
            datenow = datenow.AddDays(1)
        End While

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select Name FROM LoginAccount Where Role='Lecturer'"
        cmd = New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader
        While dr.Read

            Dim halo = dr.Item("Name")
            txtLecturerName.Items.Add(halo)
        End While
        conn.Close()
        'If ButtonClick = True Then
        '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        '    conn.Open()
        '    sql = "SELECT ClassDuration FROM Timetable WHERE Week=@WK and Lecturer=@LN and DayOfTheWeek=@DOTW"
        '    cmd = New OleDbCommand(sql, conn)
        '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)
        '    cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        '    cmd.Parameters.AddWithValue("@DOTW", Label8.Text)
        '    dr = cmd.ExecuteReader
        '    If (dr.HasRows) Then
        '        dr.Read()
        '        a = dr.Item("ClassDuration")
        '        If a = "8-9" Then
        '            lbl1.Text = dr.Item("Course")
        '            pb1.BackColor = Color.Red
        '        Else
        '            pb1.BackColor = Color.White
        '        End If
        '    End If
        'End If


        'While (i < 5)
        '    If datenow.DayOfWeek = DayOfWeek.Wednesday Then
        '        cboDayOfTheWeek.Items.Add(datenow.ToString("dd/MM/yyyy"))
        '        i = i + 1
        '    End If
        '    datenow = datenow.AddDays(1)
        'End While
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open()
        'sql = "SELECT * FROM Timetable WHERE ParkingSpaceID='Lv3-02'"
        'cmd = New OleDbCommand(sql, conn)
        'ABC = cmd.ExecuteReader
        'ABC.Read()
        'a = ABC.Item("Course")
        'If a = "Assigned" Then
        '    btn2.BackColor = Color.Red
        'Else
        '    btn2.BackColor = Color.Blue
        'End If
        'conn.Close()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtLecturerName.Text = "" Or cboWeekYear.Text = "" Then
            MessageBox.Show("Please Select Lecturer Name and Week/Year to Search Timetable!")
        Else
            btn1.Text = ""
            btn2.Text = ""
            btn3.Text = ""
            btn4.Text = ""
            btn5.Text = ""
            btn6.Text = ""
            btn7.Text = ""
            btn8.Text = ""
            btn9.Text = ""
            btn10.Text = ""
            btn11.Text = ""
            btn12.Text = ""
            btn13.Text = ""
            btn14.Text = ""
            btn15.Text = ""
            btn16.Text = ""
            btn17.Text = ""
            btn18.Text = ""
            btn19.Text = ""
            btn20.Text = ""
            btn21.Text = ""
            btn22.Text = ""
            btn23.Text = ""
            btn24.Text = ""
            btn25.Text = ""
            btn26.Text = ""
            btn27.Text = ""
            btn28.Text = ""
            btn29.Text = ""
            btn30.Text = ""
            btn31.Text = ""
            btn32.Text = ""
            btn33.Text = ""
            btn34.Text = ""
            btn35.Text = ""
            btn36.Text = ""
            btn37.Text = ""
            btn38.Text = ""
            btn39.Text = ""
            btn40.Text = ""
            btn41.Text = ""
            btn42.Text = ""
            btn43.Text = ""
            btn44.Text = ""
            btn45.Text = ""
            lbl1.Text = ""
            lbl2.Text = ""
            lbl3.Text = ""
            lbl4.Text = ""
            lbl5.Text = ""
            lbl6.Text = ""
            lbl7.Text = ""
            lbl8.Text = ""
            lbl9.Text = ""
            lbl10.Text = ""
            lbl11.Text = ""
            lbl12.Text = ""
            lbl13.Text = ""
            lbl14.Text = ""
            lbl15.Text = ""
            lbl16.Text = ""
            lbl17.Text = ""
            lbl18.Text = ""
            lbl19.Text = ""
            lbl20.Text = ""
            lbl21.Text = ""
            lbl22.Text = ""
            lbl23.Text = ""
            lbl24.Text = ""
            lbl25.Text = ""
            lbl26.Text = ""
            lbl27.Text = ""
            lbl28.Text = ""
            lbl29.Text = ""
            lbl30.Text = ""
            lbl31.Text = ""
            lbl32.Text = ""
            lbl33.Text = ""
            lbl34.Text = ""
            lbl35.Text = ""
            lbl36.Text = ""
            lbl37.Text = ""
            lbl38.Text = ""
            lbl39.Text = ""
            lbl40.Text = ""
            lbl41.Text = ""
            lbl42.Text = ""
            lbl43.Text = ""
            lbl44.Text = ""
            lbl45.Text = ""
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='8-9' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn1.Text = dr.Item("Course")
                lbl1.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='9-10' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn2.Text = dr.Item("Course")
                lbl2.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='10-11' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn3.Text = dr.Item("Course")
                lbl3.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn4.Text = dr.Item("Course")
                lbl4.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='13-14' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn5.Text = dr.Item("Course")
                lbl5.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='14-15' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn6.Text = dr.Item("Course")
                lbl6.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='15-16' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn7.Text = dr.Item("Course")
                lbl7.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='16-17' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn8.Text = dr.Item("Course")
                lbl8.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='17-18' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn9.Text = dr.Item("Course")
                lbl9.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='8-9' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn10.Text = dr.Item("Course")
                lbl10.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='9-10' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn11.Text = dr.Item("Course")
                lbl11.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='10-11' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn12.Text = dr.Item("Course")
                lbl12.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn13.Text = dr.Item("Course")
                lbl13.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='13-14' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn14.Text = dr.Item("Course")
                lbl14.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='14-15' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn15.Text = dr.Item("Course")
                lbl15.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='15-16' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn16.Text = dr.Item("Course")
                lbl16.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='16-17' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn17.Text = dr.Item("Course")
                lbl17.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='17-18' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn18.Text = dr.Item("Course")
                lbl18.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='8-9' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn19.Text = dr.Item("Course")
                lbl19.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='9-10' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn20.Text = dr.Item("Course")
                lbl20.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='10-11' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn21.Text = dr.Item("Course")
                lbl21.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn22.Text = dr.Item("Course")
                lbl22.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='13-14' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn23.Text = dr.Item("Course")
                lbl23.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='14-15' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn24.Text = dr.Item("Course")
                lbl24.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='15-16' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn25.Text = dr.Item("Course")
                lbl25.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='16-17' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn26.Text = dr.Item("Course")
                lbl26.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='17-18' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn27.Text = dr.Item("Course")
                lbl27.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='8-9' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn28.Text = dr.Item("Course")
                lbl28.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='9-10' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn29.Text = dr.Item("Course")
                lbl29.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='10-11' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn30.Text = dr.Item("Course")
                lbl30.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn31.Text = dr.Item("Course")
                lbl31.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn32.Text = dr.Item("Course")
                lbl32.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='14-15' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn33.Text = dr.Item("Course")
                lbl33.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='15-16' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn34.Text = dr.Item("Course")
                lbl34.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='16-17' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn35.Text = dr.Item("Course")
                lbl35.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='17-18' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn36.Text = dr.Item("Course")
                lbl36.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='8-9' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn37.Text = dr.Item("Course")
                lbl37.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='9-10' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn38.Text = dr.Item("Course")
                lbl38.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='10-11' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn39.Text = dr.Item("Course")
                lbl39.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn40.Text = dr.Item("Course")
                lbl40.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='13-14' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn41.Text = dr.Item("Course")
                lbl41.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='14-15' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn42.Text = dr.Item("Course")
                lbl42.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='15-16' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn43.Text = dr.Item("Course")
                lbl43.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='16-17' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn44.Text = dr.Item("Course")
                lbl44.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='17-18' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn45.Text = dr.Item("Course")
                lbl45.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
        End If

        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        ''sql = "Select * From Timetable where Lecturer='" & txtLecturerName.Text & "' And Week='" & cboWeekYear.Text & "'"
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and btnname"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)
        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then
        '    dr.Read()
        '    aa = dr.Item("btnname")
        '    If aa = "btn1" Then
        '        btn1.Text = dr.Item("Course")
        '        lbl1.Text = dr.Item("ClassVenue")
        '    ElseIf aa = "btn2" Then
        '        btn2.Text = dr.Item("Course")
        '        lbl2.Text = dr.Item("ClassVenue")
        '    End If

        'End If
        'conn.Close()
        'btn1.PerformClick()
        'btn2.PerformClick()
        'btn3.PerformClick()
        'btn4.PerformClick()
        'btn5.PerformClick()
        'btn6.PerformClick()
        'btn7.PerformClick()
        'btn8.PerformClick()
        'btn9.PerformClick()
        'btn10.PerformClick()
        'btn11.PerformClick()
        'btn12.PerformClick()
        'btn13.PerformClick()
        'btn14.PerformClick()
        'btn15.PerformClick()
        'btn16.PerformClick()
        'btn17.PerformClick()
        'btn18.PerformClick()
        'btn19.PerformClick()
        'btn20.PerformClick()
        'btn21.PerformClick()
        'btn22.PerformClick()
        'btn23.PerformClick()
        'btn24.PerformClick()
        'btn25.PerformClick()
        'btn26.PerformClick()
        'btn27.PerformClick()
        'btn28.PerformClick()
        'btn29.PerformClick()
        'btn30.PerformClick()
        'btn31.PerformClick()
        'btn32.PerformClick()
        'btn33.PerformClick()
        'btn34.PerformClick()
        'btn35.PerformClick()
        'btn36.PerformClick()
        'btn37.PerformClick()
        'btn38.PerformClick()
        'btn39.PerformClick()
        'btn40.PerformClick()
        'btn41.PerformClick()
        'btn42.PerformClick()
        'btn43.PerformClick()
        'btn44.PerformClick()
        'btn45.PerformClick()

        ''btn1.Enabled = True
        'If ButtonClick = True Then
        '    buton1 = True
        'End If
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select Course FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='8-9' and DayOfTheWeek='Monday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn1.Text = dr.Item("Course")


        'End If
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open()
        'sql = "SELECT Course FROM Timetable WHERE Week=@WK and Lecturer=@LN and DayOfTheWeek='Monday' and ClassDuration='8-9'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then
        '    dr.Read()
        '    lbl1.Text = dr.Item("Course")
        '    pb1.BackColor = Color.Red
        'End If


    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtCourse.Text = "" Or cboDayOfTheWeek.Text = "" Or cboClassDuration.Text = "" Or txtClassVenue.Text = "" Or cboWeekYear.Text = "" Or txtLecturerName.Text = "" Then
            MessageBox.Show("One Field is Empty! Please Enter Correctly!")
        Else

            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
                conn.Open()
            sql = "UPDATE Timetable SET [Course]=@CR,[ClassVenue]=@CV,[IntakeSize]=@IS WHERE [Week]=@WK and [Lecturer]=@LN and [ClassDuration]=@CD and [DayOfTheWeek]=@DOTW"
            cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@CR", txtCourse.Text)
                cmd.Parameters.AddWithValue("@CV", txtClassVenue.Text)
                cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)
                cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
                cmd.Parameters.AddWithValue("@CD", cboClassDuration.Text)
            cmd.Parameters.AddWithValue("@DOTW", cboDayOfTheWeek.Text)
            cmd.Parameters.AddWithValue("@IS", cboIntakeSize.Text)
            cmd.ExecuteNonQuery()


            MessageBox.Show("Update Successfully. Enter Next Timetable Details.")
            ClearAll()
            ClearTimeTable()
            conn.Close()

        End If
    End Sub


    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        cboDayOfTheWeek.Text = "Monday"
        cboClassDuration.Text = "8-9"

        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='8-9' and DayOfTheWeek='Monday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn1.Text = dr.Item("Course")
        '    lbl1.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        cboDayOfTheWeek.Text = "Monday"
        cboClassDuration.Text = "9-10"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='9-10' and DayOfTheWeek='Monday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn2.Text = dr.Item("Course")
        '    lbl2.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        cboDayOfTheWeek.Text = "Monday"
        cboClassDuration.Text = "10-11"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='10-11' and DayOfTheWeek='Monday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn3.Text = dr.Item("Course")
        '    lbl3.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        cboDayOfTheWeek.Text = "Monday"
        cboClassDuration.Text = "11-12"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Monday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn4.Text = dr.Item("Course")
        '    lbl4.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        cboDayOfTheWeek.Text = "Monday"
        cboClassDuration.Text = "13-14"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='13-14' and DayOfTheWeek='Monday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn5.Text = dr.Item("Course")
        '    lbl5.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        cboDayOfTheWeek.Text = "Monday"
        cboClassDuration.Text = "14-15"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='14-15' and DayOfTheWeek='Monday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn6.Text = dr.Item("Course")
        '    lbl6.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        cboDayOfTheWeek.Text = "Monday"
        cboClassDuration.Text = "15-16"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='15-16' and DayOfTheWeek='Monday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn7.Text = dr.Item("Course")
        '    lbl7.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        cboDayOfTheWeek.Text = "Monday"
        cboClassDuration.Text = "16-17"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='16-17' and DayOfTheWeek='Monday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn8.Text = dr.Item("Course")
        '    lbl8.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        cboDayOfTheWeek.Text = "Monday"
        cboClassDuration.Text = "17-18"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='17-18' and DayOfTheWeek='Monday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn9.Text = dr.Item("Course")
        '    lbl9.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        cboDayOfTheWeek.Text = "Tuesday"
        cboClassDuration.Text = "8-9"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='8-9' and DayOfTheWeek='Tuesday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn10.Text = dr.Item("Course")
        '    lbl10.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        cboDayOfTheWeek.Text = "Tuesday"
        cboClassDuration.Text = "9-10"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='9-10' and DayOfTheWeek='Tuesday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn11.Text = dr.Item("Course")
        '    lbl11.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        cboDayOfTheWeek.Text = "Tuesday"
        cboClassDuration.Text = "10-11"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='10-11' and DayOfTheWeek='Tuesday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn12.Text = dr.Item("Course")
        '    lbl12.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click
        cboDayOfTheWeek.Text = "Tuesday"
        cboClassDuration.Text = "11-12"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Tuesday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn13.Text = dr.Item("Course")
        '    lbl13.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn14_Click(sender As Object, e As EventArgs) Handles btn14.Click
        cboDayOfTheWeek.Text = "Tuesday"
        cboClassDuration.Text = "13-14"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='13-14' and DayOfTheWeek='Tuesday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn14.Text = dr.Item("Course")
        '    lbl14.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn15_Click(sender As Object, e As EventArgs) Handles btn15.Click
        cboDayOfTheWeek.Text = "Tuesday"
        cboClassDuration.Text = "14-15"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='14-15' and DayOfTheWeek='Tuesday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn15.Text = dr.Item("Course")
        '    lbl15.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn16_Click(sender As Object, e As EventArgs) Handles btn16.Click
        cboDayOfTheWeek.Text = "Tuesday"
        cboClassDuration.Text = "15-16"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='15-16' and DayOfTheWeek='Tuesday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn16.Text = dr.Item("Course")
        '    lbl16.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn17_Click(sender As Object, e As EventArgs) Handles btn17.Click
        cboDayOfTheWeek.Text = "Tuesday"
        cboClassDuration.Text = "16-17"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='16-17' and DayOfTheWeek='Tuesday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn17.Text = dr.Item("Course")
        '    lbl17.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn18_Click(sender As Object, e As EventArgs) Handles btn18.Click
        cboDayOfTheWeek.Text = "Tuesday"
        cboClassDuration.Text = "17-18"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='17-18' and DayOfTheWeek='Tuesday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn18.Text = dr.Item("Course")
        '    lbl18.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn19_Click(sender As Object, e As EventArgs) Handles btn19.Click
        cboDayOfTheWeek.Text = "Wednesday"
        cboClassDuration.Text = "8-9"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='8-9' and DayOfTheWeek='Wednesday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn19.Text = dr.Item("Course")
        '    lbl19.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click
        cboDayOfTheWeek.Text = "Wednesday"
        cboClassDuration.Text = "9-10"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='9-10' and DayOfTheWeek='Wednesday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn20.Text = dr.Item("Course")
        '    lbl20.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn21_Click(sender As Object, e As EventArgs) Handles btn21.Click
        cboDayOfTheWeek.Text = "Wednesday"
        cboClassDuration.Text = "10-11"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='10-11' and DayOfTheWeek='Wednesday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn21.Text = dr.Item("Course")
        '    lbl21.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn22_Click(sender As Object, e As EventArgs) Handles btn22.Click
        cboDayOfTheWeek.Text = "Wednesday"
        cboClassDuration.Text = "11-12"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Wednesday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn22.Text = dr.Item("Course")
        '    lbl22.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn23_Click(sender As Object, e As EventArgs) Handles btn23.Click
        cboDayOfTheWeek.Text = "Wednesday"
        cboClassDuration.Text = "13-14"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='13-14' and DayOfTheWeek='Wednesday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn23.Text = dr.Item("Course")
        '    lbl23.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn24_Click(sender As Object, e As EventArgs) Handles btn24.Click
        cboDayOfTheWeek.Text = "Wednesday"
        cboClassDuration.Text = "14-15"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='14-15' and DayOfTheWeek='Wednesday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn24.Text = dr.Item("Course")
        '    lbl24.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn25_Click(sender As Object, e As EventArgs) Handles btn25.Click
        cboDayOfTheWeek.Text = "Wednesday"
        cboClassDuration.Text = "15-16"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='15-16' and DayOfTheWeek='Wednesday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn25.Text = dr.Item("Course")
        '    lbl25.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn26_Click(sender As Object, e As EventArgs) Handles btn26.Click
        cboDayOfTheWeek.Text = "Wednesday"
        cboClassDuration.Text = "16-17"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='16-17' and DayOfTheWeek='Wednesday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn26.Text = dr.Item("Course")
        '    lbl26.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn27_Click(sender As Object, e As EventArgs) Handles btn27.Click
        cboDayOfTheWeek.Text = "Wednesday"
        cboClassDuration.Text = "17-18"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='17-18' and DayOfTheWeek='Wednesday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn27.Text = dr.Item("Course")
        '    lbl27.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn28_Click(sender As Object, e As EventArgs) Handles btn28.Click
        cboDayOfTheWeek.Text = "Thursday"
        cboClassDuration.Text = "8-9"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='8-9' and DayOfTheWeek='Thursday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn28.Text = dr.Item("Course")
        '    lbl28.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn29_Click(sender As Object, e As EventArgs) Handles btn29.Click
        cboDayOfTheWeek.Text = "Thursday"
        cboClassDuration.Text = "9-10"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='9-10' and DayOfTheWeek='Thursday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn29.Text = dr.Item("Course")
        '    lbl29.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn30_Click(sender As Object, e As EventArgs) Handles btn30.Click
        cboDayOfTheWeek.Text = "Thursday"
        cboClassDuration.Text = "10-11"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='10-11' and DayOfTheWeek='Thursday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn30.Text = dr.Item("Course")
        '    lbl30.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn31_Click(sender As Object, e As EventArgs) Handles btn31.Click
        cboDayOfTheWeek.Text = "Thursday"
        cboClassDuration.Text = "11-12"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Thursday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn31.Text = dr.Item("Course")
        '    lbl31.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn32_Click(sender As Object, e As EventArgs) Handles btn32.Click
        cboDayOfTheWeek.Text = "Thursday"
        cboClassDuration.Text = "13-14"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Thursday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn32.Text = dr.Item("Course")
        '    lbl32.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn33_Click(sender As Object, e As EventArgs) Handles btn33.Click
        cboDayOfTheWeek.Text = "Thursday"
        cboClassDuration.Text = "14-15"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='14-15' and DayOfTheWeek='Thursday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn33.Text = dr.Item("Course")
        '    lbl33.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn34_Click(sender As Object, e As EventArgs) Handles btn34.Click
        cboDayOfTheWeek.Text = "Thursday"
        cboClassDuration.Text = "15-16"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='15-16' and DayOfTheWeek='Thursday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn34.Text = dr.Item("Course")
        '    lbl34.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn35_Click(sender As Object, e As EventArgs) Handles btn35.Click
        cboDayOfTheWeek.Text = "Thursday"
        cboClassDuration.Text = "16-17"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='16-17' and DayOfTheWeek='Thursday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn35.Text = dr.Item("Course")
        '    lbl35.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn36_Click(sender As Object, e As EventArgs) Handles btn36.Click
        cboDayOfTheWeek.Text = "Thursday"
        cboClassDuration.Text = "17-18"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='17-18' and DayOfTheWeek='Thursday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn36.Text = dr.Item("Course")
        '    lbl36.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn37_Click(sender As Object, e As EventArgs) Handles btn37.Click
        cboDayOfTheWeek.Text = "Friday"
        cboClassDuration.Text = "8-9"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='8-9' and DayOfTheWeek='Friday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn37.Text = dr.Item("Course")
        '    lbl37.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn38_Click(sender As Object, e As EventArgs) Handles btn38.Click
        cboDayOfTheWeek.Text = "Friday"
        cboClassDuration.Text = "9-10"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='9-10' and DayOfTheWeek='Friday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn38.Text = dr.Item("Course")
        '    lbl38.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn39_Click(sender As Object, e As EventArgs) Handles btn39.Click
        cboDayOfTheWeek.Text = "Friday"
        cboClassDuration.Text = "10-11"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='10-11' and DayOfTheWeek='Friday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn39.Text = dr.Item("Course")
        '    lbl39.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn40_Click(sender As Object, e As EventArgs) Handles btn40.Click
        cboDayOfTheWeek.Text = "Friday"
        cboClassDuration.Text = "11-12"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Friday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn40.Text = dr.Item("Course")
        '    lbl40.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn41_Click(sender As Object, e As EventArgs) Handles btn41.Click
        cboDayOfTheWeek.Text = "Friday"
        cboClassDuration.Text = "13-14"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='13-14' and DayOfTheWeek='Friday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn41.Text = dr.Item("Course")
        '    lbl41.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn42_Click(sender As Object, e As EventArgs) Handles btn42.Click
        cboDayOfTheWeek.Text = "Friday"
        cboClassDuration.Text = "14-15"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='14-15' and DayOfTheWeek='Friday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn42.Text = dr.Item("Course")
        '    lbl42.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn43_Click(sender As Object, e As EventArgs) Handles btn43.Click
        cboDayOfTheWeek.Text = "Friday"
        cboClassDuration.Text = "15-16"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='15-16' and DayOfTheWeek='Friday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn43.Text = dr.Item("Course")
        '    lbl43.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn44_Click(sender As Object, e As EventArgs) Handles btn44.Click
        cboDayOfTheWeek.Text = "Friday"
        cboClassDuration.Text = "16-17"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='16-17' and DayOfTheWeek='Friday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn44.Text = dr.Item("Course")
        '    lbl44.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub btn45_Click(sender As Object, e As EventArgs) Handles btn45.Click
        cboDayOfTheWeek.Text = "Friday"
        cboClassDuration.Text = "17-18"
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='17-18' and DayOfTheWeek='Friday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then

        '    dr.Read()
        '    btn45.Text = dr.Item("Course")
        '    lbl45.Text = dr.Item("ClassVenue")
        'End If
        'conn.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtLecturerName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboWeekYear_GotFocus(sender As Object, e As EventArgs) Handles cboWeekYear.GotFocus
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(cboWeekYear, "Please Select Week Here !")
    End Sub

    Private Sub txtLecturerName_GotFocus(sender As Object, e As EventArgs) Handles txtLecturerName.GotFocus
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(txtLecturerName, "Please Select Lecturer Here !")
    End Sub

    Private Sub txtCourse_GotFocus(sender As Object, e As EventArgs)
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(txtCourse, "Please Enter Course Here !")
    End Sub

    Private Sub cboDayOfTheWeek_GotFocus(sender As Object, e As EventArgs) Handles cboDayOfTheWeek.GotFocus
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(cboDayOfTheWeek, "Please Select Day Here !")
    End Sub

    Private Sub cboClassDuration_GotFocus(sender As Object, e As EventArgs) Handles cboClassDuration.GotFocus
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(cboClassDuration, "Please Select Duration Here !")
    End Sub

    Private Sub txtClassVenue_GotFocus(sender As Object, e As EventArgs) Handles txtClassVenue.GotFocus
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(txtClassVenue, "Please Select Class Venue Here !")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If cboDayOfTheWeek.Text = "" Or cboClassDuration.Text = "" Or cboWeekYear.Text = "" Or txtLecturerName.Text = "" Then
            MessageBox.Show("One Field is Empty! Please Enter Correctly!")
        Else
            Dim reply As DialogResult

            reply = MessageBox.Show("Do you sure you want to delete the timetable?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If reply = DialogResult.Yes Then

                conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
                conn.Open()
                sql = "DELETE * FROM Timetable WHERE [Week]=@WK and [Lecturer]=@LN and [ClassDuration]=@CD and [DayOfTheWeek]=@DOTW"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)
                cmd.Parameters.AddWithValue("@LN", txtLecturerName.Text)
                cmd.Parameters.AddWithValue("@CD", cboClassDuration.Text)
                cmd.Parameters.AddWithValue("@DOTW", cboDayOfTheWeek.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Delete Successfully. Enter Next Timetable Details.")
                ClearAll()
                ClearTimeTable()
                conn.Close()
                PublishTimetable_Load(e, e)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""
        btn10.Text = ""
        btn11.Text = ""
        btn12.Text = ""
        btn13.Text = ""
        btn14.Text = ""
        btn15.Text = ""
        btn16.Text = ""
        btn17.Text = ""
        btn18.Text = ""
        btn19.Text = ""
        btn20.Text = ""
        btn21.Text = ""
        btn22.Text = ""
        btn23.Text = ""
        btn24.Text = ""
        btn25.Text = ""
        btn26.Text = ""
        btn27.Text = ""
        btn28.Text = ""
        btn29.Text = ""
        btn30.Text = ""
        btn31.Text = ""
        btn32.Text = ""
        btn33.Text = ""
        btn34.Text = ""
        btn35.Text = ""
        btn36.Text = ""
        btn37.Text = ""
        btn38.Text = ""
        btn39.Text = ""
        btn40.Text = ""
        btn41.Text = ""
        btn42.Text = ""
        btn43.Text = ""
        btn44.Text = ""
        btn45.Text = ""
        lbl1.Text = ""
        lbl2.Text = ""
        lbl3.Text = ""
        lbl4.Text = ""
        lbl5.Text = ""
        lbl6.Text = ""
        lbl7.Text = ""
        lbl8.Text = ""
        lbl9.Text = ""
        lbl10.Text = ""
        lbl11.Text = ""
        lbl12.Text = ""
        lbl13.Text = ""
        lbl14.Text = ""
        lbl15.Text = ""
        lbl16.Text = ""
        lbl17.Text = ""
        lbl18.Text = ""
        lbl19.Text = ""
        lbl20.Text = ""
        lbl21.Text = ""
        lbl22.Text = ""
        lbl23.Text = ""
        lbl24.Text = ""
        lbl25.Text = ""
        lbl26.Text = ""
        lbl27.Text = ""
        lbl28.Text = ""
        lbl29.Text = ""
        lbl30.Text = ""
        lbl31.Text = ""
        lbl32.Text = ""
        lbl33.Text = ""
        lbl34.Text = ""
        lbl35.Text = ""
        lbl36.Text = ""
        lbl37.Text = ""
        lbl38.Text = ""
        lbl39.Text = ""
        lbl40.Text = ""
        lbl41.Text = ""
        lbl42.Text = ""
        lbl43.Text = ""
        lbl44.Text = ""
        lbl45.Text = ""
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub
End Class