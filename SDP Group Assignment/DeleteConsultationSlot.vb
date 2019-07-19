Imports System.Data.OleDb
Imports System.Net.Mail
Public Class DeleteConsultationSlot
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim sql As String
    Dim dr As OleDbDataReader
    Dim but As String
    Dim day As String
    Dim ST As String
    Dim CK As String

    Private Sub DeleteConsultationSlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='8-9' and DayOfTheWeek='Monday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then

            btn1.Text = "Not Available"
            btn1.BackColor = Color.Red
            btn1.Enabled = False


            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='8-9' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='8-9' and [DayOfTheWeek]='Monday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='8-9' and [DayOfTheWeek]='Monday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='8-9' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn1.BackColor = Color.Red
                    btn1.Enabled = False
                Else
                    btn1.Text = "Published"
                    btn1.BackColor = Color.LightPink
                    btn1.Enabled = True
                End If
            End If

        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='9-10' and DayOfTheWeek='Monday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn2.Text = "Not Available"
            btn2.BackColor = Color.Red
            btn2.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='9-10' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='9-10' and [DayOfTheWeek]='Monday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='9-10' and [DayOfTheWeek]='Monday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='9-10' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn2.BackColor = Color.Red
                    btn2.Enabled = False
                Else
                    btn2.Text = "Published"
                    btn2.BackColor = Color.LightPink
                    btn2.Enabled = True
                End If
            End If

        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='10-11' and DayOfTheWeek='Monday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then

            btn3.Text = "Not Available"
            btn3.BackColor = Color.Red
            btn3.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='10-11' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='10-11' and [DayOfTheWeek]='Monday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='10.11' and [DayOfTheWeek]='Monday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='10-11' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn3.BackColor = Color.Red
                    btn3.Enabled = False
                Else
                    btn3.Text = "Published"
                    btn3.BackColor = Color.LightPink
                    btn3.Enabled = True
                End If
            End If

        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Monday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn4.Text = "Not Available"
            btn4.BackColor = Color.Red
            btn4.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='11-12' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='11-12' and [DayOfTheWeek]='Monday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='11-12' and [DayOfTheWeek]='Monday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='11-12' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn4.BackColor = Color.Red
                    btn4.Enabled = False
                Else
                    btn4.Text = "Published"
                    btn4.BackColor = Color.LightPink
                    btn4.Enabled = True
                End If
            End If


        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='13-14' and DayOfTheWeek='Monday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn5.Text = "Not Available"
            btn5.BackColor = Color.Red
            btn5.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='13-14' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='13-14' and [DayOfTheWeek]='Monday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='13-14' and [DayOfTheWeek]='Monday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='13-14' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn5.BackColor = Color.Red
                    btn5.Enabled = False
                Else
                    btn5.Text = "Published"
                    btn5.BackColor = Color.LightPink
                    btn5.Enabled = True
                End If
            End If


        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='14-15' and DayOfTheWeek='Monday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn6.Text = "Not Available"
            btn6.BackColor = Color.Red
            btn6.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='14-15' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='14-15' and [DayOfTheWeek]='Monday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='14-15' and [DayOfTheWeek]='Monday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='14-15' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn6.BackColor = Color.Red
                    btn6.Enabled = False
                Else
                    btn6.Text = "Published"
                    btn6.BackColor = Color.LightPink
                    btn6.Enabled = True
                End If
            End If

        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='15-16' and DayOfTheWeek='Monday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then

            dr.Read()

            btn7.Text = "Not Available"
            btn7.BackColor = Color.Red
            btn7.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='15-16' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='15-16' and [DayOfTheWeek]='Monday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='15-16' and [DayOfTheWeek]='Monday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='15-16' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn7.BackColor = Color.Red
                    btn7.Enabled = False
                Else
                    btn7.Text = "Published"
                    btn7.BackColor = Color.LightPink
                    btn7.Enabled = True
                End If
            End If

        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='16-17' and DayOfTheWeek='Monday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn8.Text = "Not Available"
            btn8.BackColor = Color.Red
            btn8.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='16-17' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='16-17' and [DayOfTheWeek]='Monday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='16-17' and [DayOfTheWeek]='Monday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='16-17' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn8.BackColor = Color.Red
                    btn8.Enabled = False
                Else
                    btn8.Text = "Published"
                    btn8.BackColor = Color.LightPink
                    btn8.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='17-18' and DayOfTheWeek='Monday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn9.Text = "Not Available"
            btn9.BackColor = Color.Red
            btn9.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='17-18' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='17-18' and [DayOfTheWeek]='Monday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='17-18' and [DayOfTheWeek]='Monday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='17-18' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn9.BackColor = Color.Red
                    btn9.Enabled = False
                Else
                    btn9.Text = "Published"
                    btn9.BackColor = Color.LightPink
                    btn9.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='8-9' and DayOfTheWeek='Tuesday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then



            btn10.Text = "Not Available"
            btn10.BackColor = Color.Red
            btn10.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='8-9' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='8-9' and [DayOfTheWeek]='Tuesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='8-9' and [DayOfTheWeek]='Tuesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='8-9' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn10.BackColor = Color.Red
                    btn10.Enabled = False
                Else
                    btn10.Text = "Published"
                    btn10.BackColor = Color.LightPink
                    btn9.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='9-10' and DayOfTheWeek='Tuesday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn11.Text = "Not Available"
            btn11.BackColor = Color.Red
            btn11.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='9-10' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='9-10' and [DayOfTheWeek]='Tuesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='9-10' and [DayOfTheWeek]='Tuesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='9-10' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn11.BackColor = Color.Red
                    btn11.Enabled = False
                Else
                    btn11.Text = "Published"
                    btn11.BackColor = Color.LightPink
                    btn11.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='10-11' and DayOfTheWeek='Tuesday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn12.Text = "Not Available"
            btn12.BackColor = Color.Red
            btn12.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='10-11' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='8-9' and [DayOfTheWeek]='Tuesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='10-11' and [DayOfTheWeek]='Tuesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='10-11' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn12.BackColor = Color.Red
                    btn12.Enabled = False
                Else
                    btn12.Text = "Published"
                    btn12.BackColor = Color.LightPink
                    btn12.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Tuesday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then



            btn13.Text = "Not Available"
            btn13.BackColor = Color.Red
            btn13.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='11-12' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='11-12' and [DayOfTheWeek]='Tuesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='11-12' and [DayOfTheWeek]='Tuesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='11-12' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn13.BackColor = Color.Red
                    btn13.Enabled = False

                Else
                    btn13.Text = "Published"
                    btn13.BackColor = Color.LightPink
                    btn13.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='13-14' and DayOfTheWeek='Tuesday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn14.Text = "Not Available"
            btn14.BackColor = Color.Red
            btn14.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='13-14' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='13-14' and [DayOfTheWeek]='Tuesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='13-14' and [DayOfTheWeek]='Tuesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='13-14' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn14.BackColor = Color.Red
                    btn14.Enabled = False
                Else
                    btn14.Text = "Published"
                    btn14.BackColor = Color.LightPink
                    btn14.Enabled = True
                End If
            End If

        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='14-15' and DayOfTheWeek='Tuesday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn15.Text = "Not Available"
            btn15.BackColor = Color.Red
            btn15.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='14-15' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='14-15' and [DayOfTheWeek]='Tuesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='14-15' and [DayOfTheWeek]='Tuesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='14-15' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn15.BackColor = Color.Red
                    btn15.Enabled = False
                Else
                    btn15.Text = "Published"
                    btn15.BackColor = Color.LightPink
                    btn15.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='15-16' and DayOfTheWeek='Tuesday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn16.Text = "Not Available"
            btn16.BackColor = Color.Red
            btn16.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='15-16' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='15-16' and [DayOfTheWeek]='Tuesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='15-16' and [DayOfTheWeek]='Tuesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='15-16' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn16.BackColor = Color.Red
                    btn16.Enabled = False
                Else
                    btn16.Text = "Published"
                    btn16.BackColor = Color.LightPink
                    btn16.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='16-17' and DayOfTheWeek='Tuesday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn17.Text = "Not Available"
            btn17.BackColor = Color.Red
            btn17.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='16-17' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='16-17' and [DayOfTheWeek]='Tuesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='16-17' and [DayOfTheWeek]='Tuesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='16-17' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn17.BackColor = Color.Red
                    btn17.Enabled = False
                Else
                    btn17.Text = "Published"
                    btn17.BackColor = Color.LightPink
                    btn17.Enabled = True
                End If
            End If

        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='17-18' and DayOfTheWeek='Tuesday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn18.Text = "Not Available"
            btn18.BackColor = Color.Red
            btn18.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='17-18' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='17-18' and [DayOfTheWeek]='Tuesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='17-18' and [DayOfTheWeek]='Tuesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='17-18' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn18.BackColor = Color.Red
                    btn18.Enabled = False
                Else
                    btn18.Text = "Published"
                    btn18.BackColor = Color.LightPink
                    btn18.Enabled = True
                End If
            End If

        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='8-9' and DayOfTheWeek='Wednesday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn19.Text = "Not Available"
            btn19.BackColor = Color.Red
            btn19.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='8-9' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='8-9' and [DayOfTheWeek]='Wednesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='8-9' and [DayOfTheWeek]='Wednesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='8-9' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn19.BackColor = Color.Red
                    btn19.Enabled = False
                Else
                    btn19.Text = "Published"
                    btn19.BackColor = Color.LightPink
                    btn19.Enabled = True
                End If
            End If

        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='9-10' and DayOfTheWeek='Wednesday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn20.Text = "Not Available"
            btn20.BackColor = Color.Red
            btn20.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='9-10' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='9-10' and [DayOfTheWeek]='Wednesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='9-10' and [DayOfTheWeek]='Wednesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='9-10' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn20.BackColor = Color.Red
                    btn20.Enabled = False
                Else
                    btn20.Text = "Published"
                    btn20.BackColor = Color.LightPink
                    btn20.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='10-11' and DayOfTheWeek='Wednesday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn21.Text = "Not Available"
            btn21.BackColor = Color.Red
            btn21.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='10-11' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='10-11' and [DayOfTheWeek]='Wednesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='10-11' and [DayOfTheWeek]='Wednesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='10-11' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn21.BackColor = Color.Red
                    btn21.Enabled = False
                Else
                    btn21.Text = "Published"
                    btn21.BackColor = Color.LightPink
                    btn21.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Wednesday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn22.Text = "Not Available"
            btn22.BackColor = Color.Red
            btn22.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='11-12' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='11-12' and [DayOfTheWeek]='Wednesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='11-12' and [DayOfTheWeek]='Wednesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='11-12' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn22.BackColor = Color.Red
                    btn22.Enabled = False
                Else
                    btn22.Text = "Published"
                    btn22.BackColor = Color.LightPink
                    btn22.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='13-14' and DayOfTheWeek='Wednesday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn23.Text = "Not Available"
            btn23.BackColor = Color.Red
            btn23.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='13-14' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='13-14' and [DayOfTheWeek]='Wednesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='13-14' and [DayOfTheWeek]='Wednesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='13-14' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn23.BackColor = Color.Red
                    btn23.Enabled = False
                Else
                    btn23.Text = "Published"
                    btn23.BackColor = Color.LightPink
                    btn23.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='14-15' and DayOfTheWeek='Wednesday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then

            btn24.Text = "Not Available"
            btn24.BackColor = Color.Red
            btn24.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='14-15' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='14-15' and [DayOfTheWeek]='Wednesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='14-15' and [DayOfTheWeek]='Wednesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else


            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='15-16' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn24.BackColor = Color.Red
                    btn24.Enabled = False
                Else
                    btn24.Text = "Published"
                    btn24.BackColor = Color.LightPink
                    btn24.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='15-16' and DayOfTheWeek='Wednesday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then
            btn25.Text = "Not Available"
            btn25.BackColor = Color.Red
            btn25.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='15-16' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='15-16' and [DayOfTheWeek]='Wednesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='15-16' and [DayOfTheWeek]='Wednesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='15-16' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn25.BackColor = Color.Red
                    btn25.Enabled = False
                Else
                    btn25.Text = "Published"
                    btn25.BackColor = Color.LightPink
                    btn25.Enabled = True
                End If
            End If

        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='16-17' and DayOfTheWeek='Wednesday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn26.Text = "Not Available"
            btn26.BackColor = Color.Red
            btn26.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='16-17' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='16-17' and [DayOfTheWeek]='Wednesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='16-17' and [DayOfTheWeek]='Wednesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='16-17' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn26.BackColor = Color.Red
                    btn26.Enabled = False
                Else
                    btn26.Text = "Published"
                    btn26.BackColor = Color.LightPink
                    btn26.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='17-18' and DayOfTheWeek='Wednesday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn27.Text = "Not Available"
            btn27.BackColor = Color.Red
            btn27.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='17-18' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='17-18' and [DayOfTheWeek]='Wednesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='17-18' and [DayOfTheWeek]='Wednesday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='17-18' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn27.BackColor = Color.Red
                    btn27.Enabled = False
                Else
                    btn27.Text = "Published"
                    btn27.BackColor = Color.LightPink
                    btn27.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='8-9' and DayOfTheWeek='Thursday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn28.Text = "Not Available"
            btn28.BackColor = Color.Red
            btn28.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='8-9' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='8-9' and [DayOfTheWeek]='Thursday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='8-9' and [DayOfTheWeek]='Thursday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='8-9' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn28.BackColor = Color.Red
                    btn28.Enabled = False
                Else
                    btn28.Text = "Published"
                    btn28.BackColor = Color.LightPink
                    btn28.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='9-10' and DayOfTheWeek='Thursday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then

            btn29.Text = "Not Available"
            btn29.BackColor = Color.Red
            btn29.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='9-10' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='8-9' and [DayOfTheWeek]='Thursday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='9-10' and [DayOfTheWeek]='Thursday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='9-10' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn29.BackColor = Color.Red
                    btn29.Enabled = False
                Else
                    btn29.Text = "Published"
                    btn29.BackColor = Color.LightPink
                    btn29.Enabled = True
                End If
            End If

        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='10-11' and DayOfTheWeek='Thursday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then

            btn30.Text = "Not Available"
            btn30.BackColor = Color.Red
            btn30.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='10-11' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='10-11' and [DayOfTheWeek]='Thursday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='10-11' and [DayOfTheWeek]='Thursday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='10-11' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn30.BackColor = Color.Red
                    btn30.Enabled = False
                Else
                    btn30.Text = "Published"
                    btn30.BackColor = Color.LightPink
                    btn30.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Thursday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then
            btn31.Text = "Not Available"
            btn31.BackColor = Color.Red
            btn31.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='11-12' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='11-12' and [DayOfTheWeek]='Thursday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='11-12' and [DayOfTheWeek]='Thursday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='11-12' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn31.BackColor = Color.Red
                    btn31.Enabled = False
                Else
                    btn31.Text = "Published"
                    btn31.BackColor = Color.LightPink
                    btn31.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='13-14' and DayOfTheWeek='Thursday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn32.Text = "Not Available"
            btn32.BackColor = Color.Red
            btn32.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='13-14' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='13-14' and [DayOfTheWeek]='Thursday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='13-14' and [DayOfTheWeek]='Thursday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If

        Else


            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='13-14' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn32.BackColor = Color.Red
                    btn32.Enabled = False
                Else
                    btn32.Text = "Published"
                    btn32.BackColor = Color.LightPink
                    btn32.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='14-15' and DayOfTheWeek='Thursday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn33.Text = "Not Available"
            btn33.BackColor = Color.Red
            btn33.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='14-15' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='14-15' and [DayOfTheWeek]='Thursday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='14-15' and [DayOfTheWeek]='Thursday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else


            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='14-15' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn33.BackColor = Color.Red
                    btn33.Enabled = False
                Else
                    btn33.Text = "Published"
                    btn33.BackColor = Color.LightPink
                    btn33.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='15-16' and DayOfTheWeek='Thursday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn34.Text = "Not Available"
            btn34.BackColor = Color.Red
            btn34.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='15-16' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='15-16' and [DayOfTheWeek]='Thursday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='15-16' and [DayOfTheWeek]='Thursday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='15-16' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn34.BackColor = Color.Red
                    btn34.Enabled = False
                Else
                    btn34.Text = "Published"
                    btn34.BackColor = Color.LightPink
                    btn34.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='16-17' and DayOfTheWeek='Thursday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then

            btn35.Text = "Not Available"
            btn35.BackColor = Color.Red
            btn35.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='16-17' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='16-17' and [DayOfTheWeek]='Thursday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='16-17' and [DayOfTheWeek]='Thursday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='16-17' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn35.BackColor = Color.Red
                    btn35.Enabled = False
                Else
                    btn35.Text = "Published"
                    btn35.BackColor = Color.LightPink
                    btn35.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='17-18' and DayOfTheWeek='Thursday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn36.Text = "Not Available"
            btn36.BackColor = Color.Red
            btn36.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='17-18' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='17-18' and [DayOfTheWeek]='Thursday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='17-18' and [DayOfTheWeek]='Thursday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='17-18' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn36.BackColor = Color.Red
                    btn36.Enabled = False
                Else
                    btn36.Text = "Published"
                    btn36.BackColor = Color.LightPink
                    btn36.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='8-9' and DayOfTheWeek='Friday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then

            btn37.Text = "Not Available"
            btn37.BackColor = Color.Red
            btn37.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='8-9' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='8-9' and [DayOfTheWeek]='Friday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='8-9' and [DayOfTheWeek]='Friday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='8-9' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn37.BackColor = Color.Red
                    btn37.Enabled = False
                Else
                    btn37.Text = "Published"
                    btn37.BackColor = Color.LightPink
                    btn37.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='9-10' and DayOfTheWeek='Friday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn38.Text = "Not Available"
            btn38.BackColor = Color.Red
            btn38.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='9-10' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='9-10' and [DayOfTheWeek]='Friday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='9-10' and [DayOfTheWeek]='Friday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else


            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='9-10' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn38.BackColor = Color.Red
                    btn38.Enabled = False
                Else
                    btn38.Text = "Published"
                    btn38.BackColor = Color.LightPink
                    btn38.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='10-11' and DayOfTheWeek='Friday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn39.Text = "Not Available"
            btn39.BackColor = Color.Red
            btn39.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='10-11' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='10-11' and [DayOfTheWeek]='Friday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='10-11' and [DayOfTheWeek]='Friday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='10-11' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn39.BackColor = Color.Red
                    btn39.Enabled = False
                Else
                    btn39.Text = "Published"
                    btn39.BackColor = Color.LightPink
                    btn39.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Friday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn40.Text = "Not Available"
            btn40.BackColor = Color.Red
            btn40.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='11-12' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='11-12' and [DayOfTheWeek]='Friday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='11-12' and [DayOfTheWeek]='Friday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='11-12' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn40.BackColor = Color.Red
                    btn40.Enabled = False
                Else
                    btn40.Text = "Published"
                    btn40.BackColor = Color.LightPink
                    btn40.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='13-14' and DayOfTheWeek='Friday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn41.Text = "Not Available"
            btn41.BackColor = Color.Red
            btn41.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='13-14' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='13-14' and [DayOfTheWeek]='Friday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='13-14' and [DayOfTheWeek]='Friday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='13-14' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn41.BackColor = Color.Red
                    btn41.Enabled = False
                Else
                    btn41.Text = "Published"
                    btn41.BackColor = Color.LightPink
                    btn41.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='14-15' and DayOfTheWeek='Friday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn42.Text = "Not Available"
            btn42.BackColor = Color.Red
            btn42.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='14-15' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='14-15' and [DayOfTheWeek]='Friday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='14-15' and [DayOfTheWeek]='Friday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='14-15' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn42.BackColor = Color.Red
                    btn42.Enabled = False
                Else
                    btn42.Text = "Published"
                    btn42.BackColor = Color.LightPink
                    btn42.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='15-16' and DayOfTheWeek='Friday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn43.Text = "Not Available"
            btn43.BackColor = Color.Red
            btn43.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='15-16' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='15-16' and [DayOfTheWeek]='Friday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='15-16' and [DayOfTheWeek]='Friday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='15-16' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn43.BackColor = Color.Red
                    btn43.Enabled = False
                Else
                    btn43.Text = "Published"
                    btn43.BackColor = Color.LightPink
                    btn43.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='16-17' and DayOfTheWeek='Friday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn44.Text = "Not Available"
            btn44.BackColor = Color.Red
            btn44.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='16-17' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='16-17' and [DayOfTheWeek]='Friday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='16-17' and [DayOfTheWeek]='Friday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='16-17' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn44.BackColor = Color.Red
                    btn44.Enabled = False
                Else
                    btn44.Text = "Published"
                    btn44.BackColor = Color.LightPink
                    btn44.Enabled = True
                End If
            End If
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='17-18' and DayOfTheWeek='Friday'"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@LN", b)
        cmd.Parameters.AddWithValue("@WK", bb)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then


            btn45.Text = "Not Available"
            btn45.BackColor = Color.Red
            btn45.Enabled = False
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time='17-18' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='17-18' and [DayOfTheWeek]='Friday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]='17-18' and [DayOfTheWeek]='Friday'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.ExecuteNonQuery()
            End If
        Else

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='17-18' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn45.BackColor = Color.Red
                    btn45.Enabled = False
                Else
                    btn45.Text = "Published"
                    btn45.BackColor = Color.LightPink
                    btn45.Enabled = True
                End If
            End If
        End If
        conn.Close()
        'Dim datenow As DateTime = System.DateTime.Now
        'Dim i As Integer = 0
        'While (i < 10)
        '    If datenow.DayOfWeek = DayOfWeek.Monday Then
        '        cboWeekYear.Items.Add(datenow.ToString("dd/MM/yyyy"))
        '        i = i + 1
        '    End If
        '    datenow = datenow.AddDays(1)
        'End While
        'Dim x As String
        'Dim i As String
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        'conn.Open() 'opens the connection
        'sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='8-9' and DayOfTheWeek='Monday'"
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LN", b)
        'cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        'dr = cmd.ExecuteReader
        'If (dr.HasRows) Then
        '    x = dr.Item("Course")
        '    i = dr.Item("ClassVenue")
        '    dr.Read()
        '    If x = "" Then
        '        btn1.Text = ""
        '    Else
        '        btn1.Text = x
        '        conn.Close()
        '    End If
        'End If
        If btn1.BackColor <> Color.LightPink Then
            btn1.Enabled = False

        End If
        If btn2.BackColor <> Color.LightPink Then
            btn2.Enabled = False

        End If
        If btn3.BackColor <> Color.LightPink Then
            btn3.Enabled = False

        End If
        If btn4.BackColor <> Color.LightPink Then
            btn4.Enabled = False

        End If
        If btn5.BackColor <> Color.LightPink Then
            btn5.Enabled = False

        End If
        If btn6.BackColor <> Color.LightPink Then
            btn6.Enabled = False

        End If
        If btn7.BackColor <> Color.LightPink Then
            btn7.Enabled = False

        End If
        If btn8.BackColor <> Color.LightPink Then
            btn8.Enabled = False

        End If
        If btn9.BackColor <> Color.LightPink Then
            btn9.Enabled = False

        End If
        If btn10.BackColor <> Color.LightPink Then
            btn10.Enabled = False

        End If
        If btn11.BackColor <> Color.LightPink Then
            btn11.Enabled = False

        End If
        If btn12.BackColor <> Color.LightPink Then
            btn12.Enabled = False

        End If
        If btn13.BackColor <> Color.LightPink Then
            btn13.Enabled = False

        End If
        If btn14.BackColor <> Color.LightPink Then
            btn14.Enabled = False

        End If
        If btn15.BackColor <> Color.LightPink Then
            btn15.Enabled = False

        End If
        If btn16.BackColor <> Color.LightPink Then
            btn16.Enabled = False

        End If
        If btn17.BackColor <> Color.LightPink Then
            btn17.Enabled = False

        End If
        If btn18.BackColor <> Color.LightPink Then
            btn18.Enabled = False

        End If
        If btn19.BackColor <> Color.LightPink Then
            btn19.Enabled = False

        End If
        If btn20.BackColor <> Color.LightPink Then
            btn20.Enabled = False

        End If
        If btn21.BackColor <> Color.LightPink Then
            btn21.Enabled = False

        End If
        If btn22.BackColor <> Color.LightPink Then
            btn22.Enabled = False

        End If
        If btn23.BackColor <> Color.LightPink Then
            btn23.Enabled = False

        End If
        If btn24.BackColor <> Color.LightPink Then
            btn24.Enabled = False

        End If
        If btn25.BackColor <> Color.LightPink Then
            btn25.Enabled = False

        End If
        If btn26.BackColor <> Color.LightPink Then
            btn26.Enabled = False

        End If
        If btn27.BackColor <> Color.LightPink Then
            btn27.Enabled = False

        End If
        If btn28.BackColor <> Color.LightPink Then
            btn28.Enabled = False

        End If
        If btn29.BackColor <> Color.LightPink Then
            btn29.Enabled = False

        End If
        If btn30.BackColor <> Color.LightPink Then
            btn30.Enabled = False

        End If
        If btn31.BackColor <> Color.LightPink Then
            btn31.Enabled = False

        End If
        If btn32.BackColor <> Color.LightPink Then
            btn32.Enabled = False

        End If
        If btn33.BackColor <> Color.LightPink Then
            btn33.Enabled = False

        End If
        If btn34.BackColor <> Color.LightPink Then
            btn34.Enabled = False

        End If
        If btn35.BackColor <> Color.LightPink Then
            btn35.Enabled = False

        End If
        If btn36.BackColor <> Color.LightPink Then
            btn36.Enabled = False

        End If
        If btn37.BackColor <> Color.LightPink Then
            btn37.Enabled = False

        End If
        If btn38.BackColor <> Color.LightPink Then
            btn38.Enabled = False

        End If
        If btn39.BackColor <> Color.LightPink Then
            btn39.Enabled = False

        End If
        If btn40.BackColor <> Color.LightPink Then
            btn40.Enabled = False

        End If
        If btn41.BackColor <> Color.LightPink Then
            btn41.Enabled = False

        End If
        If btn41.BackColor <> Color.LightPink Then
            btn41.Enabled = False

        End If
        If btn42.BackColor <> Color.LightPink Then
            btn42.Enabled = False

        End If
        If btn43.BackColor <> Color.LightPink Then
            btn43.Enabled = False

        End If
        If btn44.BackColor <> Color.LightPink Then
            btn44.Enabled = False

        End If
        If btn45.BackColor <> Color.LightPink Then
            btn45.Enabled = False

        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If lblDOTW.Text = "" Or lblTime.Text = "" Then
            MessageBox.Show("Please Don't Leave The Field Blank!")
        Else
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where LecturerName=@LN and Week=@WK and Time=@TM and DayOfTheWeek=@DOTW"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)
            cmd.Parameters.AddWithValue("@TM", lblTime.Text)
            cmd.Parameters.AddWithValue("@DOTW", lblDOTW.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
                conn.Open()
                sql = "DELETE * StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]=@TM and [DayOfTheWeek]=@DOTW"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.Parameters.AddWithValue("@TM", lblTime.Text)
                cmd.Parameters.AddWithValue("@DOTW", lblDOTW.Text)
                cmd.ExecuteNonQuery()
                conn.Close()
                conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
                conn.Open()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]=@CD and [DayOfTheWeek]=@DOTW"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.Parameters.AddWithValue("@CD", lblTime.Text)
                cmd.Parameters.AddWithValue("@DOTW", lblDOTW.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Delete Successfully. Enter Next Consultation Slot Details.")
                ClearAll()
                conn.Close()
                Me.Close()
                LecturerMainPage.Show()
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
                    e_mail.Body = "Student, your consultation schedule has been deleted! Please refer to you lecturer!"
                    Smtp_Server.Send(e_mail)
                    MsgBox("Mail Sent")

                Catch error_t As Exception
                    MsgBox(error_t.ToString)
                End Try
            Else
                conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
                conn.Open()
                sql = "DELETE * FROM ConsultationHour WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]=@CD and [DayOfTheWeek]=@DOTW"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@LN", b)
                cmd.Parameters.AddWithValue("@CD", lblTime.Text)
                cmd.Parameters.AddWithValue("@DOTW", lblDOTW.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Delete Successfully. Enter Next Consultation Slot Details.")
                ClearAll()
                conn.Close()
                Me.Close()
                LecturerMainPage.Show()

            End If
            conn.Close()


        End If


        'btn1.BackColor = DefaultBackColor
        'btn2.BackColor = DefaultBackColor
        'btn3.BackColor = DefaultBackColor
        'btn4.BackColor = DefaultBackColor
        'btn5.BackColor = DefaultBackColor
        'btn6.BackColor = DefaultBackColor
        'btn7.BackColor = DefaultBackColor
        'btn8.BackColor = DefaultBackColor
        'btn9.BackColor = DefaultBackColor
        'btn10.BackColor = DefaultBackColor
        'btn11.BackColor = DefaultBackColor
        'btn12.BackColor = DefaultBackColor
        'btn13.BackColor = DefaultBackColor
        'btn14.BackColor = DefaultBackColor
        'btn15.BackColor = DefaultBackColor
        'btn16.BackColor = DefaultBackColor
        'btn17.BackColor = DefaultBackColor
        'btn18.BackColor = DefaultBackColor
        'btn19.BackColor = DefaultBackColor
        'btn20.BackColor = DefaultBackColor
        'btn21.BackColor = DefaultBackColor
        'btn22.BackColor = DefaultBackColor
        'btn23.BackColor = DefaultBackColor
        'btn24.BackColor = DefaultBackColor
        'btn25.BackColor = DefaultBackColor
        'btn26.BackColor = DefaultBackColor
        'btn27.BackColor = DefaultBackColor
        'btn28.BackColor = DefaultBackColor
        'btn29.BackColor = DefaultBackColor
        'btn30.BackColor = DefaultBackColor
        'btn31.BackColor = DefaultBackColor
        'btn32.BackColor = DefaultBackColor
        'btn33.BackColor = DefaultBackColor
        'btn34.BackColor = DefaultBackColor
        'btn35.BackColor = DefaultBackColor
        'btn36.BackColor = DefaultBackColor
        'btn37.BackColor = DefaultBackColor
        'btn38.BackColor = DefaultBackColor
        'btn39.BackColor = DefaultBackColor
        'btn40.BackColor = DefaultBackColor
        'btn41.BackColor = DefaultBackColor
        'btn42.BackColor = DefaultBackColor
        'btn43.BackColor = DefaultBackColor
        'btn44.BackColor = DefaultBackColor
        'btn45.BackColor = DefaultBackColor

        conn.Close()
    End Sub
    Sub ClearAll()
        lblDOTW.Text = ""
        lblTime.Text = ""
    End Sub

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn10.Click, btn11.Click, btn12.Click, btn13.Click, btn14.Click, btn15.Click, btn16.Click, btn17.Click, btn18.Click, btn19.Click, btn20.Click, btn21.Click, btn22.Click, btn23.Click, btn24.Click, btn25.Click, btn26.Click, btn27.Click, btn28.Click, btn29.Click, btn30.Click, btn31.Click, btn32.Click, btn33.Click, btn34.Click, btn35.Click, btn36.Click, btn37.Click, btn38.Click, btn39.Click, btn40.Click, btn41.Click, btn42.Click, btn43.Click, btn44.Click, btn45.Click
        Select Case DirectCast(sender, Button).Name

            Case "btn1"
                lblDOTW.Text = "Monday"
                lblTime.Text = "8-9"
            Case "btn2"
                lblDOTW.Text = "Monday"
                lblTime.Text = "9-10"
            Case "btn3"
                lblDOTW.Text = "Monday"
                lblTime.Text = "10-11"
            Case "btn4"
                lblDOTW.Text = "Monday"
                lblTime.Text = "11-12"
            Case "btn5"
                lblDOTW.Text = "Monday"
                lblTime.Text = "13-14"
            Case "btn6"
                lblDOTW.Text = "Monday"
                lblTime.Text = "14-15"
            Case "btn7"
                lblDOTW.Text = "Monday"
                lblTime.Text = "15-16"
            Case "btn8"
                lblDOTW.Text = "Monday"
                lblTime.Text = "16-17"
            Case "btn9"
                lblDOTW.Text = "Monday"
                lblTime.Text = "17-18"
            Case "btn10"
                lblDOTW.Text = "Tuesday"
                lblTime.Text = "8-9"
            Case "btn11"
                lblDOTW.Text = "Tuesday"
                lblTime.Text = "9-10"
            Case "btn12"
                lblDOTW.Text = "Tuesday"
                lblTime.Text = "10-11"
            Case "btn13"
                lblDOTW.Text = "Tuesday"
                lblTime.Text = "11-12"
            Case "btn14"
                lblDOTW.Text = "Tuesday"
                lblTime.Text = "13-14"
            Case "btn15"
                lblDOTW.Text = "Tuesday"
                lblTime.Text = "14-15"
            Case "btn16"
                lblDOTW.Text = "Tuesday"
                lblTime.Text = "15-16"
            Case "btn17"
                lblDOTW.Text = "Tuesday"
                lblTime.Text = "16-17"
            Case "btn18"
                lblDOTW.Text = "Tuesday"
                lblTime.Text = "17-18"
            Case "btn19"
                lblDOTW.Text = "Wednesday"
                lblTime.Text = "8-9"
            Case "btn20"
                lblDOTW.Text = "Wednesday"
                lblTime.Text = "9-10"
            Case "btn21"
                lblDOTW.Text = "Wednesday"
                lblTime.Text = "10-11"
            Case "btn22"
                lblDOTW.Text = "Wednesday"
                lblTime.Text = "11-12"
            Case "btn23"
                lblDOTW.Text = "Wednesday"
                lblTime.Text = "13-14"
            Case "btn24"
                lblDOTW.Text = "Wednesday"
                lblTime.Text = "14-15"
            Case "btn25"
                lblDOTW.Text = "Wednesday"
                lblTime.Text = "15-16"
            Case "btn26"
                lblDOTW.Text = "Wednesday"
                lblTime.Text = "16-17"
            Case "btn27"
                lblDOTW.Text = "Wednesday"
                lblTime.Text = "17-18"
            Case "btn28"
                lblDOTW.Text = "Thursday"
                lblTime.Text = "8-9"
            Case "btn29"
                lblDOTW.Text = "Thursday"
                lblTime.Text = "9-10"
            Case "btn30"
                lblDOTW.Text = "Thursday"
                lblTime.Text = "10-11"
            Case "btn31"
                lblDOTW.Text = "Thursday"
                lblTime.Text = "11-12"
            Case "btn32"
                lblDOTW.Text = "Thursday"
                lblTime.Text = "13-14"
            Case "btn33"
                lblDOTW.Text = "Thursday"
                lblTime.Text = "14-15"
            Case "btn34"
                lblDOTW.Text = "Thursday"
                lblTime.Text = "15-16"
            Case "btn35"
                lblDOTW.Text = "Thursday"
                lblTime.Text = "16-17"
            Case "btn36"
                lblDOTW.Text = "Thursday"
                lblTime.Text = "17-18"
            Case "btn37"
                lblDOTW.Text = "Friday"
                lblTime.Text = "8-9"
            Case "btn38"
                lblDOTW.Text = "Friday"
                lblTime.Text = "9-10"
            Case "btn39"
                lblDOTW.Text = "Friday"
                lblTime.Text = "10-11"
            Case "btn40"
                lblDOTW.Text = "Friday"
                lblTime.Text = "11-12"
            Case "btn41"
                lblDOTW.Text = "Friday"
                lblTime.Text = "13-14"
            Case "btn42"
                lblDOTW.Text = "Friday"
                lblTime.Text = "14-15"
            Case "btn43"
                lblDOTW.Text = "Friday"
                lblTime.Text = "15-16"
            Case "btn44"
                lblDOTW.Text = "Friday"
                lblTime.Text = "16-17"
            Case "btn45"
                lblDOTW.Text = "Friday"
                lblTime.Text = "17-18"

        End Select
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        LecturerMainPage.Show()
    End Sub
End Class