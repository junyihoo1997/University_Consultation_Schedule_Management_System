Imports System.Data.OleDb
Public Class Login
    Dim Connection As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim sql As String
        If txtID.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("User ID or Password field is empty! Please Enter Again!")
        Else
            Connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            sql = "Select * From LoginAccount where ID='" & txtID.Text & "' And Password='" & txtPassword.Text & "'"
            Connection.Open()
            cmd = New OleDbCommand(sql, Connection)
            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                a = dr.Item("Role")
                b = dr.Item("Name")
                ID = dr.Item("ID")
                MessageBox.Show("Welcome", "Login Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If a = "Staff" Then
                    AdminMainPage.Show()
                ElseIf a = "Lecturer" Then
                    LecturerMainPage.Show()
                ElseIf a = "Student" Then
                    StudentMainPage.Show()
                End If


                If AdminMainPage.Visible Then
                    Me.Hide()
                ElseIf LecturerMainPage.Visible Then
                    Me.Hide()
                ElseIf StudentMainPage.Visible Then
                    Me.Hide()
                End If
            Else
                MessageBox.Show("User ID or Password Not Matched", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            ClearAll()
        End If

    End Sub
    Sub ClearAll()
        txtID.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim reply As DialogResult

        reply = MessageBox.Show("Do you want to exit the program?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If reply = DialogResult.Yes Then

            Application.Exit()

        End If
    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtID.GotFocus
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(txtID, "Please Enter Your Username Here !")
    End Sub
    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(txtPassword, "Please Enter Your Password Here !")
    End Sub


    Private Sub cboRole_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
