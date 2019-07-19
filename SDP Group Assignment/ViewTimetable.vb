Imports System.Data.OleDb
Public Class ViewTimetable
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim sql As String
    Dim dr As OleDbDataReader
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        LecturerMainPage.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cboWeekYear.Text = "" Or cboWeekYear.Text = "Week" Then
            MessageBox.Show("Field is Empty! Please Select Again!")
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
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
        cmd.Parameters.AddWithValue("@LN", Label1.Text)
        cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

        dr = cmd.ExecuteReader
        If (dr.HasRows) Then

            dr.Read()
            btn45.Text = dr.Item("Course")
            lbl45.Text = dr.Item("ClassVenue")
        End If
        conn.Close()
        End If
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
    End Sub
    'Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='8-9' and DayOfTheWeek='Monday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn1.Text = dr.Item("Course")
    '        lbl1.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='9-10' and DayOfTheWeek='Monday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn2.Text = dr.Item("Course")
    '        lbl2.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='10-11' and DayOfTheWeek='Monday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn3.Text = dr.Item("Course")
    '        lbl3.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Monday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn4.Text = dr.Item("Course")
    '        lbl4.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='13-14' and DayOfTheWeek='Monday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn5.Text = dr.Item("Course")
    '        lbl5.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='14-15' and DayOfTheWeek='Monday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn6.Text = dr.Item("Course")
    '        lbl6.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='15-16' and DayOfTheWeek='Monday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn7.Text = dr.Item("Course")
    '        lbl7.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='16-17' and DayOfTheWeek='Monday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn8.Text = dr.Item("Course")
    '        lbl8.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='17-18' and DayOfTheWeek='Monday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn9.Text = dr.Item("Course")
    '        lbl9.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='8-9' and DayOfTheWeek='Tuesday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn10.Text = dr.Item("Course")
    '        lbl10.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='9-10' and DayOfTheWeek='Tuesday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn11.Text = dr.Item("Course")
    '        lbl11.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='10-11' and DayOfTheWeek='Tuesday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn12.Text = dr.Item("Course")
    '        lbl12.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Tuesday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn13.Text = dr.Item("Course")
    '        lbl13.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn14_Click(sender As Object, e As EventArgs) Handles btn14.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='13-14' and DayOfTheWeek='Tuesday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn14.Text = dr.Item("Course")
    '        lbl14.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn15_Click(sender As Object, e As EventArgs) Handles btn15.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='14-15' and DayOfTheWeek='Tuesday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn15.Text = dr.Item("Course")
    '        lbl15.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn16_Click(sender As Object, e As EventArgs) Handles btn16.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='15-16' and DayOfTheWeek='Tuesday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn16.Text = dr.Item("Course")
    '        lbl16.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn17_Click(sender As Object, e As EventArgs) Handles btn17.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='16-17' and DayOfTheWeek='Tuesday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn17.Text = dr.Item("Course")
    '        lbl17.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn18_Click(sender As Object, e As EventArgs) Handles btn18.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='17-18' and DayOfTheWeek='Tuesday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn18.Text = dr.Item("Course")
    '        lbl18.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn19_Click(sender As Object, e As EventArgs) Handles btn19.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='8-9' and DayOfTheWeek='Wednesday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn19.Text = dr.Item("Course")
    '        lbl19.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='9-10' and DayOfTheWeek='Wednesday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn20.Text = dr.Item("Course")
    '        lbl20.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn21_Click(sender As Object, e As EventArgs) Handles btn21.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='10-11' and DayOfTheWeek='Wednesday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn21.Text = dr.Item("Course")
    '        lbl21.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn22_Click(sender As Object, e As EventArgs) Handles btn22.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Wednesday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn22.Text = dr.Item("Course")
    '        lbl22.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn23_Click(sender As Object, e As EventArgs) Handles btn23.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='13-14' and DayOfTheWeek='Wednesday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn23.Text = dr.Item("Course")
    '        lbl23.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn24_Click(sender As Object, e As EventArgs) Handles btn24.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='14-15' and DayOfTheWeek='Wednesday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn24.Text = dr.Item("Course")
    '        lbl24.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn25_Click(sender As Object, e As EventArgs) Handles btn25.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='15-16' and DayOfTheWeek='Wednesday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn25.Text = dr.Item("Course")
    '        lbl25.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn26_Click(sender As Object, e As EventArgs) Handles btn26.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='16-17' and DayOfTheWeek='Wednesday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn26.Text = dr.Item("Course")
    '        lbl26.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn27_Click(sender As Object, e As EventArgs) Handles btn27.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='17-18' and DayOfTheWeek='Wednesday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn27.Text = dr.Item("Course")
    '        lbl27.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn28_Click(sender As Object, e As EventArgs) Handles btn28.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='8-9' and DayOfTheWeek='Thursday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn28.Text = dr.Item("Course")
    '        lbl28.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn29_Click(sender As Object, e As EventArgs) Handles btn29.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='9-10' and DayOfTheWeek='Thursday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn29.Text = dr.Item("Course")
    '        lbl29.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn30_Click(sender As Object, e As EventArgs) Handles btn30.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='10-11' and DayOfTheWeek='Thursday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn30.Text = dr.Item("Course")
    '        lbl30.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn31_Click(sender As Object, e As EventArgs) Handles btn31.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Thursday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn31.Text = dr.Item("Course")
    '        lbl31.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn32_Click(sender As Object, e As EventArgs) Handles btn32.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Thursday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn32.Text = dr.Item("Course")
    '        lbl32.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn33_Click(sender As Object, e As EventArgs) Handles btn33.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='14-15' and DayOfTheWeek='Thursday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn33.Text = dr.Item("Course")
    '        lbl33.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn34_Click(sender As Object, e As EventArgs) Handles btn34.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='15-16' and DayOfTheWeek='Thursday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn34.Text = dr.Item("Course")
    '        lbl34.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn35_Click(sender As Object, e As EventArgs) Handles btn35.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='16-17' and DayOfTheWeek='Thursday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn35.Text = dr.Item("Course")
    '        lbl35.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn36_Click(sender As Object, e As EventArgs) Handles btn36.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='17-18' and DayOfTheWeek='Thursday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn36.Text = dr.Item("Course")
    '        lbl36.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn37_Click(sender As Object, e As EventArgs) Handles btn37.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='8-9' and DayOfTheWeek='Friday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn37.Text = dr.Item("Course")
    '        lbl37.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn38_Click(sender As Object, e As EventArgs) Handles btn38.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='9-10' and DayOfTheWeek='Friday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn38.Text = dr.Item("Course")
    '        lbl38.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn39_Click(sender As Object, e As EventArgs) Handles btn39.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='10-11' and DayOfTheWeek='Friday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn39.Text = dr.Item("Course")
    '        lbl39.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn40_Click(sender As Object, e As EventArgs) Handles btn40.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='11-12' and DayOfTheWeek='Friday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn40.Text = dr.Item("Course")
    '        lbl40.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn41_Click(sender As Object, e As EventArgs) Handles btn41.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='13-14' and DayOfTheWeek='Friday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn41.Text = dr.Item("Course")
    '        lbl41.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn42_Click(sender As Object, e As EventArgs) Handles btn42.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='14-15' and DayOfTheWeek='Friday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn42.Text = dr.Item("Course")
    '        lbl42.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn43_Click(sender As Object, e As EventArgs) Handles btn43.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='15-16' and DayOfTheWeek='Friday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn43.Text = dr.Item("Course")
    '        lbl43.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn44_Click(sender As Object, e As EventArgs) Handles btn44.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='16-17' and DayOfTheWeek='Friday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn44.Text = dr.Item("Course")
    '        lbl44.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    'Private Sub btn45_Click(sender As Object, e As EventArgs) Handles btn45.Click
    '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
    '    conn.Open() 'opens the connection
    '    sql = "Select * FROM Timetable Where Lecturer=@LN and Week=@WK and ClassDuration='17-18' and DayOfTheWeek='Friday'"
    '    cmd = New OleDbCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@LN", Label1.Text)
    '    cmd.Parameters.AddWithValue("@WK", cboWeekYear.Text)

    '    dr = cmd.ExecuteReader
    '    If (dr.HasRows) Then

    '        dr.Read()
    '        btn45.Text = dr.Item("Course")
    '        lbl45.Text = dr.Item("ClassVenue")
    '    End If
    '    conn.Close()
    'End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ViewTimetable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = b
        Dim datenow As DateTime = System.DateTime.Now
        Dim i As Integer = 0
        While (i < 10)
            If datenow.DayOfWeek = DayOfWeek.Monday Then
                cboWeekYear.Items.Add(datenow.ToString("dd/MM/yyyy"))
                i = i + 1
            End If
            datenow = datenow.AddDays(1)
        End While
    End Sub

    Private Sub cboWeekYear_GotFocus(sender As Object, e As EventArgs) Handles cboWeekYear.GotFocus
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(cboWeekYear, "Please Select Week Here !")
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class