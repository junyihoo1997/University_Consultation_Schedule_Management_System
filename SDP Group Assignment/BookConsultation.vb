Imports System.Data.OleDb
Public Class BookConsultation
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim sql As String
    Dim dr As OleDbDataReader
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        StudentMainPage.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cboLecturer.Text = "Lecturer" Or cboLecturer.Text = "" Or cboWeek.Text = "" Or cboWeek.Text = "Week" Then
            MessageBox.Show("Press Select Before Proceed!")

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
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='8-9' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn1.Text = dr.Item("SlotStatus")
                lbl1.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='9-10' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn2.Text = dr.Item("SlotStatus")
                lbl2.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='10-11' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn3.Text = dr.Item("SlotStatus")
                lbl3.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='11-12' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn4.Text = dr.Item("SlotStatus")
                lbl4.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='13-14' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn5.Text = dr.Item("SlotStatus")
                lbl5.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='14-15' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn6.Text = dr.Item("SlotStatus")
                lbl6.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='15-16' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn7.Text = dr.Item("SlotStatus")
                lbl7.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='16-17' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn8.Text = dr.Item("SlotStatus")
                lbl8.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='17-18' and DayOfTheWeek='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn9.Text = dr.Item("SlotStatus")
                lbl9.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='8-9' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn10.Text = dr.Item("SlotStatus")
                lbl10.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='9-10' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn11.Text = dr.Item("SlotStatus")
                lbl11.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='10-11' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn12.Text = dr.Item("SlotStatus")
                lbl12.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='11-12' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn13.Text = dr.Item("SlotStatus")
                lbl13.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='13-14' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn14.Text = dr.Item("SlotStatus")
                lbl14.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='14-15' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn15.Text = dr.Item("SlotStatus")
                lbl15.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='15-16' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn16.Text = dr.Item("SlotStatus")
                lbl16.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='16-17' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn17.Text = dr.Item("SlotStatus")
                lbl17.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='17-18' and DayOfTheWeek='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn18.Text = dr.Item("SlotStatus")
                lbl18.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='8-9' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn19.Text = dr.Item("SlotStatus")
                lbl19.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='9-10' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn20.Text = dr.Item("SlotStatus")
                lbl20.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='10-11' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn21.Text = dr.Item("SlotStatus")
                lbl21.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='11-12' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn22.Text = dr.Item("SlotStatus")
                lbl22.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='13-14' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn23.Text = dr.Item("SlotStatus")
                lbl23.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='14-15' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn24.Text = dr.Item("SlotStatus")
                lbl24.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='15-16' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn25.Text = dr.Item("SlotStatus")
                lbl25.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='16-17' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn26.Text = dr.Item("SlotStatus")
                lbl26.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='17-18' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn27.Text = dr.Item("SlotStatus")
                lbl27.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='8-9' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn28.Text = dr.Item("SlotStatus")
                lbl28.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='9-10' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn29.Text = dr.Item("SlotStatus")
                lbl29.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='10-11' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn30.Text = dr.Item("SlotStatus")
                lbl30.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='11-12' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn31.Text = dr.Item("SlotStatus")
                lbl31.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='13-14' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn32.Text = dr.Item("SlotStatus")
                lbl32.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='14-15' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn33.Text = dr.Item("SlotStatus")
                lbl33.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='15-16' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn34.Text = dr.Item("SlotStatus")
                lbl34.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='16-17' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn35.Text = dr.Item("SlotStatus")
                lbl35.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='17-18' and DayOfTheWeek='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn36.Text = dr.Item("SlotStatus")
                lbl36.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='8-9' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn37.Text = dr.Item("SlotStatus")
                lbl37.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='9-10' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn38.Text = dr.Item("SlotStatus")
                lbl38.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='10-11' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn39.Text = dr.Item("SlotStatus")
                lbl39.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='11-12' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn40.Text = dr.Item("SlotStatus")
                lbl40.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='13-14' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn41.Text = dr.Item("SlotStatus")
                lbl41.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='14-15' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn42.Text = dr.Item("SlotStatus")
                lbl42.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='15-16' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn43.Text = dr.Item("SlotStatus")
                lbl43.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='16-17' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn44.Text = dr.Item("SlotStatus")
                lbl44.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='17-18' and DayOfTheWeek='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                btn45.Text = dr.Item("SlotStatus")
                lbl45.Text = dr.Item("ClassVenue")
            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='8-9' and [DayOfTheWeek]='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn1.Text = "Booked"
                    lbl1.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='9-10' and [DayOfTheWeek]='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn2.Text = "Booked"
                    lbl2.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='10-11' and [DayOfTheWeek]='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn3.Text = "Booked"
                    lbl3.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='11-12' and [DayOfTheWeek]='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn4.Text = "Booked"
                    lbl4.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='13-14' and [DayOfTheWeek]='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn5.Text = "Booked"
                    lbl5.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='14-15' and [DayOfTheWeek]='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn6.Text = "Booked"
                    lbl6.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='15-16' and [DayOfTheWeek]='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn7.Text = "Booked"
                    lbl7.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='16-17' and [DayOfTheWeek]='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn8.Text = "Booked"
                    lbl8.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='17-18' and [DayOfTheWeek]='Monday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn9.Text = "Booked"
                    lbl9.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='8-9' and [DayOfTheWeek]='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn10.Text = "Booked"
                    lbl10.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='9-10' and [DayOfTheWeek]='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn11.Text = "Booked"
                    lbl11.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='10-11' and [DayOfTheWeek]='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn12.Text = "Booked"
                    lbl12.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='11-12' and [DayOfTheWeek]='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn13.Text = "Booked"
                    lbl13.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='13-14' and [DayOfTheWeek]='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn14.Text = "Booked"
                    lbl14.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='14-15' and [DayOfTheWeek]='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn15.Text = "Booked"
                    lbl15.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='15-16' and [DayOfTheWeek]='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn16.Text = "Booked"
                    lbl16.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='16-17' and [DayOfTheWeek]='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn17.Text = "Booked"
                    lbl17.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='17-18' and [DayOfTheWeek]='Tuesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn18.Text = "Booked"
                    lbl18.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='8-9' and [DayOfTheWeek]='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn19.Text = "Booked"
                    lbl19.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='9-10' and [DayOfTheWeek]='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn20.Text = "Booked"
                    lbl20.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='10-11' and [DayOfTheWeek]='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn21.Text = "Booked"
                    lbl21.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='11-12' and [DayOfTheWeek]='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn22.Text = "Booked"
                    lbl22.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='13-14' and [DayOfTheWeek]='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn23.Text = "Booked"
                    lbl23.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='14-15' and [DayOfTheWeek]='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn24.Text = "Booked"
                    lbl24.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='15-16' and [DayOfTheWeek]='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn25.Text = "Booked"
                    lbl25.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='16-17' and [DayOfTheWeek]='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn26.Text = "Booked"
                    lbl26.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='17-18' and [DayOfTheWeek]='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn27.Text = "Booked"
                    lbl27.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='8-9' and [DayOfTheWeek]='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn28.Text = "Booked"
                    lbl28.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='9-10' and [DayOfTheWeek]='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn29.Text = "Booked"
                    lbl29.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='10-11' and [DayOfTheWeek]='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn30.Text = "Booked"
                    lbl30.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='11-12' and [DayOfTheWeek]='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn31.Text = "Booked"
                    lbl31.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='13-14' and [DayOfTheWeek]='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn32.Text = "Booked"
                    lbl32.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='14-15' and [DayOfTheWeek]='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn33.Text = "Booked"
                    lbl33.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='15-16' and [DayOfTheWeek]='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn34.Text = "Booked"
                    lbl34.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='16-17' and [DayOfTheWeek]='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn35.Text = "Booked"
                    lbl35.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='17-18' and [DayOfTheWeek]='Thursday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn36.Text = "Booked"
                    lbl36.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='8-9' and [DayOfTheWeek]='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn37.Text = "Booked"
                    lbl37.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='9-10' and [DayOfTheWeek]='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn38.Text = "Booked"
                    lbl38.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='10-11' and [DayOfTheWeek]='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn39.Text = "Booked"
                    lbl39.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='11-12' and [DayOfTheWeek]='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn40.Text = "Booked"
                    lbl40.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='13-14' and [DayOfTheWeek]='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn41.Text = "Booked"
                    lbl41.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='14-15' and [DayOfTheWeek]='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn42.Text = "Booked"
                    lbl42.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='15-16' and [DayOfTheWeek]='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn43.Text = "Booked"
                    lbl43.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='16-17' and [DayOfTheWeek]='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn44.Text = "Booked"
                    lbl44.Text = "Booked"
                End If

            End If
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]='17-18' and [DayOfTheWeek]='Friday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                If dr.Item("Status") = "" Then
                Else
                    btn45.Text = "Booked"
                    lbl45.Text = "Booked"
                End If

            End If
            conn.Close()
            If btn1.Text = "Available" Then
                btn1.BackgroundImage = My.Resources.correct

            Else
                btn1.BackgroundImage = My.Resources.wrong

                btn1.Enabled = False
            End If
            If btn2.Text = "Available" Then
                btn2.BackgroundImage = My.Resources.correct
            Else
                btn2.BackgroundImage = My.Resources.wrong
                btn2.Enabled = False
            End If
            If btn3.Text = "Available" Then
                btn3.BackgroundImage = My.Resources.correct
            Else
                btn3.BackgroundImage = My.Resources.wrong
                btn3.Enabled = False
            End If
            If btn4.Text = "Available" Then
                btn4.BackgroundImage = My.Resources.correct
            Else
                btn4.BackgroundImage = My.Resources.wrong
                btn4.Enabled = False
            End If
            If btn5.Text = "Available" Then
                btn5.BackgroundImage = My.Resources.correct
            Else
                btn5.BackgroundImage = My.Resources.wrong
                btn5.Enabled = False
            End If
            If btn6.Text = "Available" Then
                btn6.BackgroundImage = My.Resources.correct
            Else
                btn6.BackgroundImage = My.Resources.wrong
                btn6.Enabled = False
            End If
            If btn7.Text = "Available" Then
                btn7.BackgroundImage = My.Resources.correct
            Else
                btn7.BackgroundImage = My.Resources.wrong
                btn7.Enabled = False
            End If
            If btn8.Text = "Available" Then
                btn8.BackgroundImage = My.Resources.correct
            Else
                btn8.BackgroundImage = My.Resources.wrong
                btn8.Enabled = False
            End If
            If btn9.Text = "Available" Then
                btn9.BackgroundImage = My.Resources.correct
            Else
                btn9.BackgroundImage = My.Resources.wrong
                btn9.Enabled = False
            End If
            If btn10.Text = "Available" Then
                btn10.BackgroundImage = My.Resources.correct
            Else
                btn10.BackgroundImage = My.Resources.wrong
                btn10.Enabled = False
            End If
            If btn11.Text = "Available" Then
                btn11.BackgroundImage = My.Resources.correct
            Else
                btn11.BackgroundImage = My.Resources.wrong
                btn11.Enabled = False
            End If
            If btn12.Text = "Available" Then
                btn12.BackgroundImage = My.Resources.correct
            Else
                btn12.BackgroundImage = My.Resources.wrong
                btn12.Enabled = False
            End If
            If btn13.Text = "Available" Then
                btn13.BackgroundImage = My.Resources.correct
            Else
                btn13.BackgroundImage = My.Resources.wrong
                btn13.Enabled = False
            End If
            If btn14.Text = "Available" Then
                btn14.BackgroundImage = My.Resources.correct
            Else
                btn14.BackgroundImage = My.Resources.wrong
                btn14.Enabled = False
            End If
            If btn15.Text = "Available" Then
                btn15.BackgroundImage = My.Resources.correct
            Else
                btn15.BackgroundImage = My.Resources.wrong
                btn15.Enabled = False
            End If
            If btn16.Text = "Available" Then
                btn16.BackgroundImage = My.Resources.correct
            Else
                btn16.BackgroundImage = My.Resources.wrong
                btn16.Enabled = False
            End If
            If btn17.Text = "Available" Then
                btn17.BackgroundImage = My.Resources.correct
            Else
                btn17.BackgroundImage = My.Resources.wrong
                btn17.Enabled = False
            End If
            If btn18.Text = "Available" Then
                btn18.BackgroundImage = My.Resources.correct
            Else
                btn18.BackgroundImage = My.Resources.wrong
                btn18.Enabled = False
            End If
            If btn19.Text = "Available" Then
                btn19.BackgroundImage = My.Resources.correct
            Else
                btn19.BackgroundImage = My.Resources.wrong
                btn19.Enabled = False
            End If
            If btn20.Text = "Available" Then
                btn20.BackgroundImage = My.Resources.correct
            Else
                btn20.BackgroundImage = My.Resources.wrong
                btn20.Enabled = False
            End If
            If btn21.Text = "Available" Then
                btn21.BackgroundImage = My.Resources.correct
            Else
                btn21.BackgroundImage = My.Resources.wrong
                btn21.Enabled = False
            End If
            If btn22.Text = "Available" Then
                btn22.BackgroundImage = My.Resources.correct
            Else
                btn22.BackgroundImage = My.Resources.wrong
                btn22.Enabled = False
            End If
            If btn23.Text = "Available" Then
                btn23.BackgroundImage = My.Resources.correct
            Else
                btn23.BackgroundImage = My.Resources.wrong
                btn23.Enabled = False
            End If
            If btn24.Text = "Available" Then
                btn24.BackgroundImage = My.Resources.correct
            Else
                btn24.BackgroundImage = My.Resources.wrong
                btn24.Enabled = False
            End If
            If btn25.Text = "Available" Then
                btn25.BackgroundImage = My.Resources.correct
            Else
                btn25.BackgroundImage = My.Resources.wrong
                btn25.Enabled = False
            End If
            If btn26.Text = "Available" Then
                btn26.BackgroundImage = My.Resources.correct
            Else
                btn26.BackgroundImage = My.Resources.wrong
                btn26.Enabled = False
            End If
            If btn27.Text = "Available" Then
                btn27.BackgroundImage = My.Resources.correct
            Else
                btn27.BackgroundImage = My.Resources.wrong
                btn27.Enabled = False
            End If
            If btn28.Text = "Available" Then
                btn28.BackgroundImage = My.Resources.correct
            Else
                btn28.BackgroundImage = My.Resources.wrong
                btn28.Enabled = False
            End If
            If btn29.Text = "Available" Then
                btn29.BackgroundImage = My.Resources.correct
            Else
                btn29.BackgroundImage = My.Resources.wrong
                btn29.Enabled = False
            End If
            If btn30.Text = "Available" Then
                btn30.BackgroundImage = My.Resources.correct
            Else
                btn30.BackgroundImage = My.Resources.wrong
                btn30.Enabled = False
            End If
            If btn31.Text = "Available" Then
                btn31.BackgroundImage = My.Resources.correct
            Else
                btn31.BackgroundImage = My.Resources.wrong
                btn31.Enabled = False
            End If
            If btn32.Text = "Available" Then
                btn32.BackgroundImage = My.Resources.correct
            Else
                btn32.BackgroundImage = My.Resources.wrong
                btn32.Enabled = False
            End If
            If btn33.Text = "Available" Then
                btn33.BackgroundImage = My.Resources.correct
            Else
                btn33.BackgroundImage = My.Resources.wrong
                btn33.Enabled = False
            End If
            If btn34.Text = "Available" Then
                btn34.BackgroundImage = My.Resources.correct
            Else
                btn34.BackgroundImage = My.Resources.wrong
                btn34.Enabled = False
            End If
            If btn35.Text = "Available" Then
                btn35.BackgroundImage = My.Resources.correct
            Else
                btn35.BackgroundImage = My.Resources.wrong
                btn35.Enabled = False
            End If
            If btn36.Text = "Available" Then
                btn36.BackgroundImage = My.Resources.correct
            Else
                btn36.BackgroundImage = My.Resources.wrong
                btn36.Enabled = False
            End If
            If btn37.Text = "Available" Then
                btn37.BackgroundImage = My.Resources.correct
            Else
                btn37.BackgroundImage = My.Resources.wrong
                btn37.Enabled = False
            End If
            If btn38.Text = "Available" Then
                btn38.BackgroundImage = My.Resources.correct
            Else
                btn38.BackgroundImage = My.Resources.wrong
                btn38.Enabled = False
            End If
            If btn39.Text = "Available" Then
                btn39.BackgroundImage = My.Resources.correct
            Else
                btn39.BackgroundImage = My.Resources.wrong
                btn39.Enabled = False
            End If
            If btn40.Text = "Available" Then
                btn40.BackgroundImage = My.Resources.correct
            Else
                btn40.BackgroundImage = My.Resources.wrong
                btn40.Enabled = False
            End If
            If btn41.Text = "Available" Then
                btn41.BackgroundImage = My.Resources.correct
            Else
                btn41.BackgroundImage = My.Resources.wrong
                btn41.Enabled = False
            End If
            If btn42.Text = "Available" Then
                btn42.BackgroundImage = My.Resources.correct
            Else
                btn42.BackgroundImage = My.Resources.wrong
                btn42.Enabled = False
            End If
            If btn43.Text = "Available" Then
                btn43.BackgroundImage = My.Resources.correct
            Else
                btn43.BackgroundImage = My.Resources.wrong
                btn43.Enabled = False
            End If
            If btn44.Text = "Available" Then
                btn44.BackgroundImage = My.Resources.correct
            Else
                btn44.BackgroundImage = My.Resources.wrong
                btn44.Enabled = False
            End If
            If btn45.Text = "Available" Then
                btn45.BackgroundImage = My.Resources.correct
            Else
                btn45.BackgroundImage = My.Resources.wrong
                btn45.Enabled = False
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
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        cboDayOfTheWeek.Text = "Monday"
        cboTime.Text = "8-9"
        lblVenue.Text = lbl1.Text
    End Sub

    Private Sub BookConsultation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtID.Text = ID
        txtName.Text = b
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
        conn.Open() 'opens the connection
        sql = "Select Name FROM LoginAccount Where Role='Lecturer'"
        cmd = New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader
        While dr.Read
            Dim datacbo = dr.Item("Name")
            cboLecturer.Items.Add(datacbo)
        End While
        conn.Close()
        Dim datenow As DateTime = System.DateTime.Now
        Dim i As Integer = 0
        While (i < 10)
            If datenow.DayOfWeek = DayOfWeek.Monday Then
                cboWeek.Items.Add(datenow.ToString("dd/MM/yyyy"))
                i = i + 1
            End If
            datenow = datenow.AddDays(1)
        End While


    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtName.Text = "" Or txtID.Text = "" Or txtReason.Text = "" Or lblVenue.Text = "" Or cboWeek.Text = "" Or cboLecturer.Text = "" Or cboDayOfTheWeek.Text = "" Or cboTime.Text = "" Then
            MessageBox.Show("Please don't leave the field blank!")
        Else

            Dim HAHA As String
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open()
            sql = "INSERT INTO StudentConsultationRecord ([StudentName],[StudentID],[DayOfTheWeek],[Venue],[Reason],[Time],[Week],[Status],[LecturerName]) VALUES (@SN,@SID,@DOTW,@VN,@RS,@TM,@WK,@ST,@LN)"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@SN", b)
            cmd.Parameters.AddWithValue("@SID", txtID.Text)
            cmd.Parameters.AddWithValue("@DOTW", cboDayOfTheWeek.Text)
            cmd.Parameters.AddWithValue("@VN", lblVenue.Text)
            cmd.Parameters.AddWithValue("@RS", txtReason.Text)
            cmd.Parameters.AddWithValue("@TM", cboTime.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)
            cmd.Parameters.AddWithValue("@ST", "Waiting Approval")
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Consultation Booked Successfully. Enter Next Consultation Details.")
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open()
            sql = "UPDATE ConsultationHour SET [SlotStatus]=@SS WHERE [Week]=@WK and [Lecturer]=@LN and [ConsultationDuration]=@CD and [DayOfTheWeek]=@DOTW"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@SS", "Assigned")
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@CD", cboTime.Text)
            cmd.Parameters.AddWithValue("@DOTW", cboDayOfTheWeek.Text)
            cmd.ExecuteNonQuery()
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM StudentConsultationRecord Where [LecturerName]=@LN and [Week]=@WK and [Time]=@CD and [DayOfTheWeek]=@DOTW and [StudentName]=@NM and [StudentID]=@ID"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", cboLecturer.Text)
            cmd.Parameters.AddWithValue("@WK", cboWeek.Text)
            cmd.Parameters.AddWithValue("@CD", cboTime.Text)
            cmd.Parameters.AddWithValue("@DOTW", cboDayOfTheWeek.Text)
            cmd.Parameters.AddWithValue("@NM", txtName.Text)
            cmd.Parameters.AddWithValue("@ID", txtID.Text)
            dr = cmd.ExecuteReader()
            If (dr.HasRows) Then
                dr.Read()
                HAHA = dr.Item("AppointmentID")
                MessageBox.Show("Your Appointment ID is ： " + HAHA)
            End If

            conn.Close()
            Clear()
            btnSearch.PerformClick()
        End If
    End Sub
    Sub Clear()
        txtReason.Clear()
        lblVenue.Text = ""
        cboDayOfTheWeek.Text = ""
        cboTime.Text = ""
    End Sub

    Private Sub cboLecturer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLecturer.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        cboDayOfTheWeek.Text = "Monday"
        cboTime.Text = "9-10"
        lblVenue.Text = lbl2.Text
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        cboDayOfTheWeek.Text = "Monday"
        cboTime.Text = "10-11"
        lblVenue.Text = lbl3.Text
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        cboDayOfTheWeek.Text = "Monday"
        cboTime.Text = "11-12"
        lblVenue.Text = lbl4.Text
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        cboDayOfTheWeek.Text = "Monday"
        cboTime.Text = "13-14"
        lblVenue.Text = lbl5.Text
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        cboDayOfTheWeek.Text = "Monday"
        cboTime.Text = "14-15"
        lblVenue.Text = lbl6.Text
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        cboDayOfTheWeek.Text = "Monday"
        cboTime.Text = "15-16"
        lblVenue.Text = lbl7.Text
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        cboDayOfTheWeek.Text = "Monday"
        cboTime.Text = "16-17"
        lblVenue.Text = lbl8.Text
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        cboDayOfTheWeek.Text = "Monday"
        cboTime.Text = "17-18"
        lblVenue.Text = lbl9.Text
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        cboDayOfTheWeek.Text = "Tuesday"
        cboTime.Text = "8-9"
        lblVenue.Text = lbl10.Text
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        cboDayOfTheWeek.Text = "Tuesday"
        cboTime.Text = "9-10"
        lblVenue.Text = lbl11.Text
    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        cboDayOfTheWeek.Text = "Tuesday"
        cboTime.Text = "10-11"
        lblVenue.Text = lbl12.Text
    End Sub

    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click
        cboDayOfTheWeek.Text = "Tuesday"
        cboTime.Text = "11-12"
        lblVenue.Text = lbl13.Text
    End Sub

    Private Sub btn14_Click(sender As Object, e As EventArgs) Handles btn14.Click
        cboDayOfTheWeek.Text = "Tuesday"
        cboTime.Text = "13-14"
        lblVenue.Text = lbl14.Text
    End Sub

    Private Sub btn15_Click(sender As Object, e As EventArgs) Handles btn15.Click
        cboDayOfTheWeek.Text = "Tuesday"
        cboTime.Text = "14-15"
        lblVenue.Text = lbl15.Text
    End Sub

    Private Sub btn16_Click(sender As Object, e As EventArgs) Handles btn16.Click
        cboDayOfTheWeek.Text = "Tuesday"
        cboTime.Text = "15-16"
        lblVenue.Text = lbl16.Text
    End Sub

    Private Sub btn17_Click(sender As Object, e As EventArgs) Handles btn17.Click
        cboDayOfTheWeek.Text = "Tuesday"
        cboTime.Text = "16-17"
        lblVenue.Text = lbl17.Text
    End Sub

    Private Sub btn18_Click(sender As Object, e As EventArgs) Handles btn18.Click
        cboDayOfTheWeek.Text = "Tuesday"
        cboTime.Text = "17-18"
        lblVenue.Text = lbl18.Text
    End Sub

    Private Sub btn19_Click(sender As Object, e As EventArgs) Handles btn19.Click
        cboDayOfTheWeek.Text = "Wednesday"
        cboTime.Text = "8-9"
        lblVenue.Text = lbl19.Text
    End Sub

    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click
        cboDayOfTheWeek.Text = "Wednesday"
        cboTime.Text = "9-10"
        lblVenue.Text = lbl20.Text
    End Sub

    Private Sub btn21_Click(sender As Object, e As EventArgs) Handles btn21.Click
        cboDayOfTheWeek.Text = "Wednesday"
        cboTime.Text = "10-11"
        lblVenue.Text = lbl21.Text
    End Sub

    Private Sub btn22_Click(sender As Object, e As EventArgs) Handles btn22.Click
        cboDayOfTheWeek.Text = "Wednesday"
        cboTime.Text = "11-12"
        lblVenue.Text = lbl22.Text
    End Sub

    Private Sub btn23_Click(sender As Object, e As EventArgs) Handles btn23.Click
        cboDayOfTheWeek.Text = "Wednesday"
        cboTime.Text = "13-14"
        lblVenue.Text = lbl23.Text
    End Sub

    Private Sub btn24_Click(sender As Object, e As EventArgs) Handles btn24.Click
        cboDayOfTheWeek.Text = "Wednesday"
        cboTime.Text = "14-15"
        lblVenue.Text = lbl24.Text
    End Sub

    Private Sub btn25_Click(sender As Object, e As EventArgs) Handles btn25.Click
        cboDayOfTheWeek.Text = "Wednesday"
        cboTime.Text = "15-16"
        lblVenue.Text = lbl25.Text
    End Sub

    Private Sub btn26_Click(sender As Object, e As EventArgs) Handles btn26.Click
        cboDayOfTheWeek.Text = "Wednesday"
        cboTime.Text = "16-17"
        lblVenue.Text = lbl26.Text
    End Sub

    Private Sub btn27_Click(sender As Object, e As EventArgs) Handles btn27.Click
        cboDayOfTheWeek.Text = "Wednesday"
        cboTime.Text = "17-18"
        lblVenue.Text = lbl27.Text
    End Sub

    Private Sub btn28_Click(sender As Object, e As EventArgs) Handles btn28.Click
        cboDayOfTheWeek.Text = "Thursday"
        cboTime.Text = "8-9"
        lblVenue.Text = lbl28.Text
    End Sub

    Private Sub btn29_Click(sender As Object, e As EventArgs) Handles btn29.Click
        cboDayOfTheWeek.Text = "Thursday"
        cboTime.Text = "9-10"
        lblVenue.Text = lbl29.Text
    End Sub

    Private Sub btn30_Click(sender As Object, e As EventArgs) Handles btn30.Click
        cboDayOfTheWeek.Text = "Thursday"
        cboTime.Text = "10-11"
        lblVenue.Text = lbl30.Text
    End Sub

    Private Sub btn31_Click(sender As Object, e As EventArgs) Handles btn31.Click
        cboDayOfTheWeek.Text = "Thursday"
        cboTime.Text = "11-12"
        lblVenue.Text = lbl31.Text
    End Sub

    Private Sub btn32_Click(sender As Object, e As EventArgs) Handles btn32.Click
        cboDayOfTheWeek.Text = "Thursday"
        cboTime.Text = "13-14"
        lblVenue.Text = lbl32.Text
    End Sub

    Private Sub btn33_Click(sender As Object, e As EventArgs) Handles btn33.Click
        cboDayOfTheWeek.Text = "Thursday"
        cboTime.Text = "14-15"
        lblVenue.Text = lbl33.Text
    End Sub

    Private Sub btn34_Click(sender As Object, e As EventArgs) Handles btn34.Click
        cboDayOfTheWeek.Text = "Thursday"
        cboTime.Text = "15-16"
        lblVenue.Text = lbl34.Text
    End Sub

    Private Sub btn35_Click(sender As Object, e As EventArgs) Handles btn35.Click
        cboDayOfTheWeek.Text = "Thursday"
        cboTime.Text = "16-17"
        lblVenue.Text = lbl35.Text
    End Sub

    Private Sub btn36_Click(sender As Object, e As EventArgs) Handles btn36.Click
        cboDayOfTheWeek.Text = "Thursday"
        cboTime.Text = "17-18"
        lblVenue.Text = lbl36.Text
    End Sub

    Private Sub btn37_Click(sender As Object, e As EventArgs) Handles btn37.Click
        cboDayOfTheWeek.Text = "Friday"
        cboTime.Text = "8-9"
        lblVenue.Text = lbl37.Text
    End Sub

    Private Sub btn38_Click(sender As Object, e As EventArgs) Handles btn38.Click
        cboDayOfTheWeek.Text = "Friday"
        cboTime.Text = "9-10"
        lblVenue.Text = lbl38.Text
    End Sub

    Private Sub btn39_Click(sender As Object, e As EventArgs) Handles btn39.Click
        cboDayOfTheWeek.Text = "Friday"
        cboTime.Text = "10-11"
        lblVenue.Text = lbl39.Text
    End Sub

    Private Sub btn40_Click(sender As Object, e As EventArgs) Handles btn40.Click
        cboDayOfTheWeek.Text = "Friday"
        cboTime.Text = "11-12"
        lblVenue.Text = lbl40.Text
    End Sub

    Private Sub btn41_Click(sender As Object, e As EventArgs) Handles btn41.Click
        cboDayOfTheWeek.Text = "Friday"
        cboTime.Text = "13-14"
        lblVenue.Text = lbl41.Text
    End Sub

    Private Sub btn42_Click(sender As Object, e As EventArgs) Handles btn42.Click
        cboDayOfTheWeek.Text = "Friday"
        cboTime.Text = "14-15"
        lblVenue.Text = lbl42.Text
    End Sub

    Private Sub btn43_Click(sender As Object, e As EventArgs) Handles btn43.Click
        cboDayOfTheWeek.Text = "Friday"
        cboTime.Text = "15-16"
        lblVenue.Text = lbl43.Text
    End Sub

    Private Sub btn44_Click(sender As Object, e As EventArgs) Handles btn44.Click
        cboDayOfTheWeek.Text = "Friday"
        cboTime.Text = "16-17"
        lblVenue.Text = lbl44.Text
    End Sub

    Private Sub btn45_Click(sender As Object, e As EventArgs) Handles btn45.Click
        cboDayOfTheWeek.Text = "Friday"
        cboTime.Text = "17-18"
        lblVenue.Text = lbl45.Text
    End Sub

    Private Sub txtName_GotFocus(sender As Object, e As EventArgs)
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(txtName, "Please Enter Your Name Here !")
    End Sub

    Private Sub txtID_GotFocus(sender As Object, e As EventArgs)
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(txtID, "Please Enter Your ID Here !")
    End Sub

    Private Sub txtReason_GotFocus(sender As Object, e As EventArgs) Handles txtReason.GotFocus
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(txtReason, "Please Enter Reason Here !")
    End Sub

    Private Sub cboDayOfTheWeek_GotFocus(sender As Object, e As EventArgs)
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(cboDayOfTheWeek, "Please Select Day Here !")
    End Sub

    Private Sub cboTime_GotFocus(sender As Object, e As EventArgs)
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(cboTime, "Please Select Time Here !")
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btn10_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class