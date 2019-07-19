Imports System.Data.OleDb

Public Class PublishConsultationSchedule
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim sql As String
    Dim dr As OleDbDataReader
    Dim but As String
    Dim day As String
    Dim ST As String
    Dim CK As String
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        LecturerMainPage.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    'Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
    '    btn1.Text = "Available"
    '    If btnRelease.PerformClick = True Then

    '    End If
    'End Sub

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn10.Click, btn11.Click, btn12.Click, btn13.Click, btn14.Click, btn15.Click, btn16.Click, btn17.Click, btn18.Click, btn19.Click, btn20.Click, btn21.Click, btn22.Click, btn23.Click, btn24.Click, btn25.Click, btn26.Click, btn27.Click, btn28.Click, btn29.Click, btn30.Click, btn31.Click, btn32.Click, btn33.Click, btn34.Click, btn35.Click, btn36.Click, btn37.Click, btn38.Click, btn39.Click, btn40.Click, btn41.Click, btn42.Click, btn43.Click, btn44.Click, btn45.Click
        Select Case DirectCast(sender, Button).Name

            Case "btn1"
                btn1.Text = "Available"
                btn1.BackColor = Color.LightGreen
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn2"
                btn2.Text = "Available"
                btn2.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn3"
                btn3.Text = "Available"
                btn3.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn4"
                btn4.Text = "Available"
                btn4.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn5"
                btn5.Text = "Available"
                btn5.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn6"
                btn6.Text = "Available"
                btn6.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn7"
                btn7.Text = "Available"
                btn7.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn8"
                btn8.Text = "Available"
                btn8.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn9"
                btn9.Text = "Available"
                btn9.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn10"
                btn10.Text = "Available"
                btn10.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn11"
                btn11.Text = "Available"
                btn11.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn12"
                btn12.Text = "Available"
                btn12.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn13"
                btn13.Text = "Available"
                btn13.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn14"
                btn14.Text = "Available"
                btn14.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn15"
                btn15.Text = "Available"
                btn15.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn16"
                btn16.Text = "Available"
                btn16.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn17"
                btn17.Text = "Available"
                btn17.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn18"
                btn18.Text = "Available"
                btn18.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn19"
                btn19.Text = "Available"
                btn19.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn20"
                btn20.Text = "Available"
                btn20.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn21"
                btn21.Text = "Available"
                btn21.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn22"
                btn22.Text = "Available"
                btn22.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn23"
                btn23.Text = "Available"
                btn23.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn24"
                btn24.Text = "Available"
                btn24.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn25"
                btn25.Text = "Available"
                btn25.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn26"
                btn26.Text = "Available"
                btn26.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn27"
                btn27.Text = "Available"
                btn27.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If

                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn28"
                btn28.Text = "Available"
                btn28.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn29"
                btn29.Text = "Available"
                btn29.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn30"
                btn30.Text = "Available"
                btn30.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn31"
                btn31.Text = "Available"
                btn31.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn32"
                btn32.Text = "Available"
                btn32.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn33"
                btn33.Text = "Available"
                btn33.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn34"
                btn34.Text = "Available"
                btn34.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn35"
                btn35.Text = "Available"
                btn35.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn36"
                btn36.Text = "Available"
                btn36.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If

            Case "btn37"
                btn37.Text = "Available"
                btn37.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn38"
                btn38.Text = "Available"
                btn38.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn39"
                btn39.Text = "Available"
                btn39.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn40"
                btn40.Text = "Available"
                btn40.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn41"
                btn41.Text = "Available"
                btn41.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn42"
                btn42.Text = "Available"
                btn42.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn43"
                btn43.Text = "Available"
                btn43.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn44"
                btn44.Text = "Available"
                btn44.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn45.BackColor = Color.LightGreen Then
                    btn45.BackColor = Color.Transparent
                    btn45.Text = ""
                Else

                End If
            Case "btn45"
                btn45.Text = "Available"
                btn45.BackColor = Color.LightGreen
                If btn1.BackColor = Color.LightGreen Then
                    btn1.BackColor = Color.Transparent
                    btn1.Text = ""
                Else
                End If
                If btn2.BackColor = Color.LightGreen Then
                    btn2.BackColor = Color.Transparent
                    btn2.Text = ""
                Else
                End If
                If btn3.BackColor = Color.LightGreen Then
                    btn3.BackColor = Color.Transparent
                    btn3.Text = ""
                Else
                End If
                If btn4.BackColor = Color.LightGreen Then
                    btn4.BackColor = Color.Transparent
                    btn4.Text = ""
                Else
                End If
                If btn5.BackColor = Color.LightGreen Then
                    btn5.BackColor = Color.Transparent
                    btn5.Text = ""
                Else
                End If
                If btn6.BackColor = Color.LightGreen Then
                    btn6.BackColor = Color.Transparent
                    btn6.Text = ""
                Else
                End If
                If btn7.BackColor = Color.LightGreen Then
                    btn7.BackColor = Color.Transparent
                    btn7.Text = ""
                Else
                End If
                If btn8.BackColor = Color.LightGreen Then
                    btn8.BackColor = Color.Transparent
                    btn8.Text = ""
                Else
                End If
                If btn9.BackColor = Color.LightGreen Then
                    btn9.BackColor = Color.Transparent
                    btn9.Text = ""
                Else
                End If
                If btn10.BackColor = Color.LightGreen Then
                    btn10.BackColor = Color.Transparent
                    btn10.Text = ""
                Else
                End If
                If btn11.BackColor = Color.LightGreen Then
                    btn11.BackColor = Color.Transparent
                    btn11.Text = ""
                Else
                End If
                If btn12.BackColor = Color.LightGreen Then
                    btn12.BackColor = Color.Transparent
                    btn12.Text = ""
                Else
                End If
                If btn13.BackColor = Color.LightGreen Then
                    btn13.BackColor = Color.Transparent
                    btn13.Text = ""
                Else
                End If
                If btn14.BackColor = Color.LightGreen Then
                    btn14.BackColor = Color.Transparent
                    btn14.Text = ""
                Else
                End If
                If btn15.BackColor = Color.LightGreen Then
                    btn15.BackColor = Color.Transparent
                    btn15.Text = ""
                Else
                End If
                If btn16.BackColor = Color.LightGreen Then
                    btn16.BackColor = Color.Transparent
                    btn16.Text = ""
                Else
                End If
                If btn17.BackColor = Color.LightGreen Then
                    btn17.BackColor = Color.Transparent
                    btn17.Text = ""
                Else
                End If
                If btn18.BackColor = Color.LightGreen Then
                    btn18.BackColor = Color.Transparent
                    btn18.Text = ""
                Else
                End If
                If btn19.BackColor = Color.LightGreen Then
                    btn19.BackColor = Color.Transparent
                    btn19.Text = ""
                Else
                End If
                If btn20.BackColor = Color.LightGreen Then
                    btn20.BackColor = Color.Transparent
                    btn20.Text = ""
                Else
                End If
                If btn21.BackColor = Color.LightGreen Then
                    btn21.BackColor = Color.Transparent
                    btn21.Text = ""
                Else
                End If
                If btn22.BackColor = Color.LightGreen Then
                    btn22.BackColor = Color.Transparent
                    btn22.Text = ""
                Else
                End If
                If btn23.BackColor = Color.LightGreen Then
                    btn23.BackColor = Color.Transparent
                    btn23.Text = ""
                Else
                End If
                If btn24.BackColor = Color.LightGreen Then
                    btn24.BackColor = Color.Transparent
                    btn24.Text = ""
                Else
                End If
                If btn25.BackColor = Color.LightGreen Then
                    btn25.BackColor = Color.Transparent
                    btn25.Text = ""
                Else
                End If
                If btn26.BackColor = Color.LightGreen Then
                    btn26.BackColor = Color.Transparent
                    btn26.Text = ""
                Else
                End If
                If btn27.BackColor = Color.LightGreen Then
                    btn27.BackColor = Color.Transparent
                    btn27.Text = ""
                Else
                End If
                If btn28.BackColor = Color.LightGreen Then
                    btn28.BackColor = Color.Transparent
                    btn28.Text = ""
                Else
                End If
                If btn29.BackColor = Color.LightGreen Then
                    btn29.BackColor = Color.Transparent
                    btn29.Text = ""
                Else
                End If
                If btn30.BackColor = Color.LightGreen Then
                    btn30.BackColor = Color.Transparent
                    btn30.Text = ""
                Else
                End If
                If btn31.BackColor = Color.LightGreen Then
                    btn31.BackColor = Color.Transparent
                    btn31.Text = ""
                Else
                End If
                If btn32.BackColor = Color.LightGreen Then
                    btn32.BackColor = Color.Transparent
                    btn32.Text = ""
                Else
                End If
                If btn33.BackColor = Color.LightGreen Then
                    btn33.BackColor = Color.Transparent
                    btn33.Text = ""
                Else
                End If
                If btn34.BackColor = Color.LightGreen Then
                    btn34.BackColor = Color.Transparent
                    btn34.Text = ""
                Else
                End If
                If btn35.BackColor = Color.LightGreen Then
                    btn35.BackColor = Color.Transparent
                    btn35.Text = ""
                Else
                End If
                If btn36.BackColor = Color.LightGreen Then
                    btn36.BackColor = Color.Transparent
                    btn36.Text = ""
                Else
                End If
                If btn37.BackColor = Color.LightGreen Then
                    btn37.BackColor = Color.Transparent
                    btn37.Text = ""
                Else
                End If
                If btn38.BackColor = Color.LightGreen Then
                    btn38.BackColor = Color.Transparent
                    btn38.Text = ""
                Else
                End If
                If btn39.BackColor = Color.LightGreen Then
                    btn39.BackColor = Color.Transparent
                    btn39.Text = ""
                Else
                End If
                If btn40.BackColor = Color.LightGreen Then
                    btn40.BackColor = Color.Transparent
                    btn40.Text = ""
                Else
                End If
                If btn41.BackColor = Color.LightGreen Then
                    btn41.BackColor = Color.Transparent
                    btn41.Text = ""
                Else
                End If
                If btn42.BackColor = Color.LightGreen Then
                    btn42.BackColor = Color.Transparent
                    btn42.Text = ""
                Else
                End If
                If btn43.BackColor = Color.LightGreen Then
                    btn43.BackColor = Color.Transparent
                    btn43.Text = ""
                Else
                End If
                If btn44.BackColor = Color.LightGreen Then
                    btn44.BackColor = Color.Transparent
                    btn44.Text = ""
                Else
                End If
        End Select
    End Sub

    Private Sub btnRelease_Click(sender As Object, e As EventArgs) Handles btnRelease.Click
        If txtClassVenue.Text = "" Then
            MessageBox.Show("Please Enter The Class Venue Before Publish!")
        Else
            If btn1.BackColor = Color.LightGreen Then
                but = "8-9"
                day = "Monday"
                ST = "Available"
            ElseIf btn2.BackColor = Color.LightGreen Then
                but = "9-10"
                day = "Monday"
                ST = "Available"
            ElseIf btn3.BackColor = Color.LightGreen Then
                but = "10-11"
                day = "Monday"
                ST = "Available"
            ElseIf btn4.BackColor = Color.LightGreen Then
                but = "11-12"
                day = "Monday"
                ST = "Available"
            ElseIf btn5.BackColor = Color.LightGreen Then
                but = "13-14"
                day = "Monday"
                ST = "Available"
            ElseIf btn6.BackColor = Color.LightGreen Then
                but = "14-15"
                day = "Monday"
                ST = "Available"
            ElseIf btn7.BackColor = Color.LightGreen Then
                but = "15-16"
                day = "Monday"
                ST = "Available"
            ElseIf btn8.BackColor = Color.LightGreen Then
                but = "16-17"
                day = "Monday"
                ST = "Available"
            ElseIf btn9.BackColor = Color.LightGreen Then
                but = "17-18"
                day = "Monday"
                ST = "Available"
            ElseIf btn10.BackColor = Color.LightGreen Then
                but = "8-9"
                day = "Tuesday"
                ST = "Available"
            ElseIf btn11.BackColor = Color.LightGreen Then
                but = "9-10"
                day = "Tuesday"
                ST = "Available"
            ElseIf btn12.BackColor = Color.LightGreen Then
                but = "10-11"
                day = "Tuesday"
                ST = "Available"
            ElseIf btn13.BackColor = Color.LightGreen Then
                but = "11-12"
                day = "Tuesday"
                ST = "Available"
            ElseIf btn14.BackColor = Color.LightGreen Then
                but = "13-14"
                day = "Tuesday"
                ST = "Available"
            ElseIf btn15.BackColor = Color.LightGreen Then
                but = "14-15"
                day = "Tuesday"
                ST = "Available"
            ElseIf btn16.BackColor = Color.LightGreen Then
                but = "15-16"
                day = "Tuesday"
                ST = "Available"
            ElseIf btn17.BackColor = Color.LightGreen Then
                but = "16-17"
                day = "Tuesday"
                ST = "Available"
            ElseIf btn18.BackColor = Color.LightGreen Then
                but = "17-18"
                day = "Tuesday"
                ST = "Available"
            ElseIf btn19.BackColor = Color.LightGreen Then
                but = "8-9"
                day = "Wednesday"
                ST = "Available"
            ElseIf btn20.BackColor = Color.LightGreen Then
                but = "9-10"
                day = "Wednesday"
                ST = "Available"
            ElseIf btn21.BackColor = Color.LightGreen Then
                but = "10-11"
                day = "Wednesday"
                ST = "Available"
            ElseIf btn22.BackColor = Color.LightGreen Then
                but = "11-12"
                day = "Wednesday"
                ST = "Available"
            ElseIf btn23.BackColor = Color.LightGreen Then
                but = "13-14"
                day = "Wednesday"
                ST = "Available"
            ElseIf btn24.BackColor = Color.LightGreen Then
                but = "14-15"
                day = "Wednesday"
                ST = "Available"
            ElseIf btn25.BackColor = Color.LightGreen Then
                but = "15-16"
                day = "Wednesday"
                ST = "Available"
            ElseIf btn26.BackColor = Color.LightGreen Then
                but = "16-17"
                day = "Wednesday"
                ST = "Available"
            ElseIf btn27.BackColor = Color.LightGreen Then
                but = "17-18"
                day = "Wednesday"
                ST = "Available"
            ElseIf btn28.BackColor = Color.LightGreen Then
                but = "8-9"
                day = "Thursday"
                ST = "Available"
            ElseIf btn29.BackColor = Color.LightGreen Then
                but = "9-10"
                day = "Thursday"
                ST = "Available"
            ElseIf btn30.BackColor = Color.LightGreen Then
                but = "10-11"
                day = "Thursday"
                ST = "Available"
            ElseIf btn31.BackColor = Color.LightGreen Then
                but = "11-12"
                day = "Thursday"
                ST = "Available"
            ElseIf btn32.BackColor = Color.LightGreen Then
                but = "13-14"
                day = "Thursday"
                ST = "Available"
            ElseIf btn33.BackColor = Color.LightGreen Then
                but = "14-15"
                day = "Thursday"
                ST = "Available"
            ElseIf btn34.BackColor = Color.LightGreen Then
                but = "15-16"
                day = "Thursday"
                ST = "Available"
            ElseIf btn35.BackColor = Color.LightGreen Then
                but = "16-17"
                day = "Thursday"
                ST = "Available"
            ElseIf btn36.BackColor = Color.LightGreen Then
                but = "17-18"
                day = "Thursday"
                ST = "Available"
            ElseIf btn37.BackColor = Color.LightGreen Then
                but = "8-9"
                day = "Friday"
                ST = "Available"
            ElseIf btn38.BackColor = Color.LightGreen Then
                but = "9-10"
                day = "Friday"
                ST = "Available"
            ElseIf btn39.BackColor = Color.LightGreen Then
                but = "10-11"
                day = "Friday"
                ST = "Available"
            ElseIf btn40.BackColor = Color.LightGreen Then
                but = "11-12"
                day = "Friday"
                ST = "Available"
            ElseIf btn41.BackColor = Color.LightGreen Then
                but = "13-14"
                day = "Friday"
                ST = "Available"
            ElseIf btn42.BackColor = Color.LightGreen Then
                but = "14-15"
                day = "Friday"
                ST = "Available"
            ElseIf btn43.BackColor = Color.LightGreen Then
                but = "15-16"
                day = "Friday"
                ST = "Available"
            ElseIf btn44.BackColor = Color.LightGreen Then
                but = "16-17"
                day = "Friday"
                ST = "Available"
            ElseIf btn45.BackColor = Color.LightGreen Then
                but = "17-18"
                day = "Friday"
                ST = "Available"
            End If
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
            conn.Open() 'opens the connection
            sql = "Select * FROM ConsultationHour Where Week=@WK and ConsultationDuration=@CD and DayOfTheWeek=DOTW and ClassVenue=@CV"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@WK", bb)
            cmd.Parameters.AddWithValue("@CD", but)
            cmd.Parameters.AddWithValue("@DOTW", day)
            cmd.Parameters.AddWithValue("@CV", txtClassVenue.Text)
            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                MessageBox.Show("The Room Has Been Used By Other Lecturer!")
            Else
                conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SDPassignment.accdb;Persist Security Info=False;")
                conn.Open()
                sql = "INSERT INTO CONSULTATIONHOUR(Lecturer,DayOfTheWeek,ConsultationDuration,Week,SlotStatus,ClassVenue) VALUES (@LTR,@DOTW,@CD,@WK,@Status,@CV)"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@LTR", b)
                cmd.Parameters.AddWithValue("@DOTW", day)
                cmd.Parameters.AddWithValue("@CD", but)
                cmd.Parameters.AddWithValue("@WK", bb)
                cmd.Parameters.AddWithValue("@Status", ST)
                cmd.Parameters.AddWithValue("@CV", txtClassVenue.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Consultation Slot Published Successfully. Enter Next Consultation Details.")
                PublishConsultationSchedule_Load(e, e)
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
            End If


        End If
    End Sub


    Private Sub PublishConsultationSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    btn1.Text = "Available"
                    btn1.BackColor = Color.LightGreen
                Else
                    btn1.Text = "Published"
                    btn1.BackColor = Color.LightPink
                    btn1.Enabled = False
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
                    btn2.Text = "Available"
                    btn2.BackColor = Color.LightGreen
                Else
                    btn2.Text = "Published"
                    btn2.BackColor = Color.LightPink
                    btn2.Enabled = False
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
                    btn3.Text = "Available"
                    btn3.BackColor = Color.LightGreen
                Else
                    btn3.Text = "Published"
                    btn3.BackColor = Color.LightPink
                    btn3.Enabled = False
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
                    btn4.Text = "Available"
                    btn4.BackColor = Color.LightGreen
                Else
                    btn4.Text = "Published"
                    btn4.BackColor = Color.LightPink
                    btn4.Enabled = False
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
                    btn5.Text = "Available"
                    btn5.BackColor = Color.LightGreen
                Else
                    btn5.Text = "Published"
                    btn5.BackColor = Color.LightPink
                    btn5.Enabled = False
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
                    btn6.Text = "Available"
                    btn6.BackColor = Color.LightGreen
                Else
                    btn6.Text = "Published"
                    btn6.BackColor = Color.LightPink
                    btn6.Enabled = False
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
                    btn7.Text = "Available"
                    btn7.BackColor = Color.LightGreen
                Else
                    btn7.Text = "Published"
                    btn7.BackColor = Color.LightPink
                    btn7.Enabled = False
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
                    btn8.Text = "Available"
                    btn8.BackColor = Color.LightGreen
                Else
                    btn8.Text = "Published"
                    btn8.BackColor = Color.LightPink
                    btn8.Enabled = False
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
                    btn9.Text = "Available"
                    btn9.BackColor = Color.LightGreen
                Else
                    btn9.Text = "Published"
                    btn9.BackColor = Color.LightPink
                    btn9.Enabled = False
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
                    btn10.Text = "Available"
                    btn10.BackColor = Color.LightGreen
                Else
                    btn10.Text = "Published"
                    btn10.BackColor = Color.LightPink
                    btn10.Enabled = False
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
                    btn11.Text = "Available"
                    btn11.BackColor = Color.LightGreen
                Else
                    btn11.Text = "Published"
                    btn11.BackColor = Color.LightPink
                    btn11.Enabled = False
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

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='10-11' and [DayOfTheWeek]='Tuesday'"
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
                    btn12.Text = "Available"
                    btn12.BackColor = Color.LightGreen
                Else
                    btn12.Text = "Published"
                    btn12.BackColor = Color.LightPink
                    btn12.Enabled = False
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
                    btn13.Text = "Available"
                    btn13.BackColor = Color.LightGreen
                Else
                    btn13.Text = "Published"
                    btn13.BackColor = Color.LightPink
                    btn13.Enabled = False
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
                    btn14.Text = "Available"
                    btn14.BackColor = Color.LightGreen
                Else
                    btn14.Text = "Published"
                    btn14.BackColor = Color.LightPink
                    btn14.Enabled = False
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
                    btn15.Text = "Available"
                    btn15.BackColor = Color.LightGreen
                Else
                    btn15.Text = "Published"
                    btn15.BackColor = Color.LightPink
                    btn15.Enabled = False
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
                    btn16.Text = "Available"
                    btn16.BackColor = Color.LightGreen
                Else
                    btn16.Text = "Published"
                    btn16.BackColor = Color.LightPink
                    btn16.Enabled = False
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
                    btn17.Text = "Available"
                    btn17.BackColor = Color.LightGreen
                Else
                    btn17.Text = "Published"
                    btn17.BackColor = Color.LightPink
                    btn17.Enabled = False
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
                    btn18.Text = "Available"
                    btn18.BackColor = Color.LightGreen
                Else
                    btn18.Text = "Published"
                    btn18.BackColor = Color.LightPink
                    btn18.Enabled = False
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
                    btn19.Text = "Available"
                    btn19.BackColor = Color.LightGreen
                Else
                    btn19.Text = "Published"
                    btn19.BackColor = Color.LightPink
                    btn19.Enabled = False
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
                    btn20.Text = "Available"
                    btn20.BackColor = Color.LightGreen
                Else
                    btn20.Text = "Published"
                    btn20.BackColor = Color.LightPink
                    btn20.Enabled = False
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
                    btn21.Text = "Available"
                    btn21.BackColor = Color.LightGreen
                Else
                    btn21.Text = "Published"
                    btn21.BackColor = Color.LightPink
                    btn21.Enabled = False
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
                    btn22.Text = "Available"
                    btn22.BackColor = Color.LightGreen
                Else
                    btn22.Text = "Published"
                    btn22.BackColor = Color.LightPink
                    btn22.Enabled = False
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
                    btn23.Text = "Available"
                    btn23.BackColor = Color.LightGreen
                Else
                    btn23.Text = "Published"
                    btn23.BackColor = Color.LightPink
                    btn23.Enabled = False
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

            sql = "Select * FROM ConsultationHour Where Lecturer=@LN and Week=@WK and ConsultationDuration='14-15' and DayOfTheWeek='Wednesday'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@LN", b)
            cmd.Parameters.AddWithValue("@WK", bb)

            dr = cmd.ExecuteReader
            If (dr.HasRows) Then

                dr.Read()
                If dr.Item("SlotStatus") = "" Then
                    btn24.Text = "Available"
                    btn24.BackColor = Color.LightGreen
                Else
                    btn24.Text = "Published"
                    btn24.BackColor = Color.LightPink
                    btn24.Enabled = False
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
                    btn25.Text = "Available"
                    btn25.BackColor = Color.LightGreen
                Else
                    btn25.Text = "Published"
                    btn25.BackColor = Color.LightPink
                    btn25.Enabled = False
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
                    btn26.Text = "Available"
                    btn26.BackColor = Color.LightGreen
                Else
                    btn26.Text = "Published"
                    btn26.BackColor = Color.LightPink
                    btn26.Enabled = False
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
                    btn27.Text = "Available"
                    btn27.BackColor = Color.LightGreen
                Else
                    btn27.Text = "Published"
                    btn27.BackColor = Color.LightPink
                    btn27.Enabled = False
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
                    btn28.Text = "Available"
                    btn28.BackColor = Color.LightGreen
                Else
                    btn28.Text = "Published"
                    btn28.BackColor = Color.LightPink
                    btn28.Enabled = False
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

                sql = "DELETE * FROM StudentConsultationRecord WHERE [Week]=@WK and [LecturerName]=@LN and [Time]='9-10' and [DayOfTheWeek]='Thursday'"
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
                    btn29.Text = "Available"
                    btn29.BackColor = Color.LightGreen
                Else
                    btn29.Text = "Published"
                    btn29.BackColor = Color.LightPink
                    btn29.Enabled = False
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
                    btn30.Text = "Available"
                    btn30.BackColor = Color.LightGreen
                Else
                    btn30.Text = "Published"
                    btn30.BackColor = Color.LightPink
                    btn30.Enabled = False
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
                    btn31.Text = "Available"
                    btn31.BackColor = Color.LightGreen
                Else
                    btn31.Text = "Published"
                    btn31.BackColor = Color.LightPink
                    btn31.Enabled = False
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
                    btn32.Text = "Available"
                    btn32.BackColor = Color.LightGreen
                Else
                    btn32.Text = "Published"
                    btn32.BackColor = Color.LightPink
                    btn32.Enabled = False
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
                    btn33.Text = "Available"
                    btn33.BackColor = Color.LightGreen
                Else
                    btn33.Text = "Published"
                    btn33.BackColor = Color.LightPink
                    btn33.Enabled = False
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
                    btn34.Text = "Available"
                    btn34.BackColor = Color.LightGreen
                Else
                    btn34.Text = "Published"
                    btn34.BackColor = Color.LightPink
                    btn34.Enabled = False
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
                    btn35.Text = "Available"
                    btn35.BackColor = Color.LightGreen
                Else
                    btn35.Text = "Published"
                    btn35.BackColor = Color.LightPink
                    btn35.Enabled = False
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
                    btn36.Text = "Available"
                    btn36.BackColor = Color.LightGreen
                Else
                    btn36.Text = "Published"
                    btn36.BackColor = Color.LightPink
                    btn36.Enabled = False
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
                    btn37.Text = "Available"
                    btn37.BackColor = Color.LightGreen
                Else
                    btn37.Text = "Published"
                    btn37.BackColor = Color.LightPink
                    btn37.Enabled = False
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
                    btn38.Text = "Available"
                    btn38.BackColor = Color.LightGreen
                Else
                    btn38.Text = "Published"
                    btn38.BackColor = Color.LightPink
                    btn38.Enabled = False
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
                    btn39.Text = "Available"
                    btn39.BackColor = Color.LightGreen
                Else
                    btn39.Text = "Published"
                    btn39.BackColor = Color.LightPink
                    btn39.Enabled = False
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
                    btn40.Text = "Available"
                    btn40.BackColor = Color.LightGreen
                Else
                    btn40.Text = "Published"
                    btn40.BackColor = Color.LightPink
                    btn40.Enabled = False
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
                    btn41.Text = "Available"
                    btn41.BackColor = Color.LightGreen
                Else
                    btn41.Text = "Published"
                    btn41.BackColor = Color.LightPink
                    btn41.Enabled = False
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
                    btn42.Text = "Available"
                    btn42.BackColor = Color.LightGreen
                Else
                    btn42.Text = "Published"
                    btn42.BackColor = Color.LightPink
                    btn42.Enabled = False
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
                    btn43.Text = "Available"
                    btn43.BackColor = Color.LightGreen
                Else
                    btn43.Text = "Published"
                    btn43.BackColor = Color.LightPink
                    btn43.Enabled = False
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
                    btn44.Text = "Available"
                    btn44.BackColor = Color.LightGreen
                Else
                    btn44.Text = "Published"
                    btn44.BackColor = Color.LightPink
                    btn44.Enabled = False
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
                    btn45.Text = "Available"
                    btn45.BackColor = Color.LightGreen
                Else
                    btn45.Text = "Published"
                    btn45.BackColor = Color.LightPink
                    btn45.Enabled = False
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


    End Sub

    Private Sub cboWeekYear_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub cboWeekYear_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If btn1.BackColor = Color.LightGreen Then
            btn1.BackColor = Color.Transparent
            btn1.Text = ""
        Else
        End If
        If btn2.BackColor = Color.LightGreen Then
            btn2.BackColor = Color.Transparent
            btn2.Text = ""
        Else
        End If
        If btn3.BackColor = Color.LightGreen Then
            btn3.BackColor = Color.Transparent
            btn3.Text = ""
        Else
        End If
        If btn4.BackColor = Color.LightGreen Then
            btn4.BackColor = Color.Transparent
            btn4.Text = ""
        Else
        End If
        If btn5.BackColor = Color.LightGreen Then
            btn5.BackColor = Color.Transparent
            btn5.Text = ""
        Else
        End If
        If btn6.BackColor = Color.LightGreen Then
            btn6.BackColor = Color.Transparent
            btn6.Text = ""
        Else
        End If
        If btn7.BackColor = Color.LightGreen Then
            btn7.BackColor = Color.Transparent
            btn7.Text = ""
        Else
        End If
        If btn8.BackColor = Color.LightGreen Then
            btn8.BackColor = Color.Transparent
            btn8.Text = ""
        Else
        End If
        If btn9.BackColor = Color.LightGreen Then
            btn9.BackColor = Color.Transparent
            btn9.Text = ""
        Else
        End If
        If btn10.BackColor = Color.LightGreen Then
            btn10.BackColor = Color.Transparent
            btn10.Text = ""
        Else
        End If
        If btn11.BackColor = Color.LightGreen Then
            btn11.BackColor = Color.Transparent
            btn11.Text = ""
        Else
        End If
        If btn12.BackColor = Color.LightGreen Then
            btn12.BackColor = Color.Transparent
            btn12.Text = ""
        Else
        End If
        If btn13.BackColor = Color.LightGreen Then
            btn13.BackColor = Color.Transparent
            btn13.Text = ""
        Else
        End If
        If btn14.BackColor = Color.LightGreen Then
            btn14.BackColor = Color.Transparent
            btn14.Text = ""
        Else
        End If
        If btn15.BackColor = Color.LightGreen Then
            btn15.BackColor = Color.Transparent
            btn15.Text = ""
        Else
        End If
        If btn16.BackColor = Color.LightGreen Then
            btn16.BackColor = Color.Transparent
            btn16.Text = ""
        Else
        End If
        If btn17.BackColor = Color.LightGreen Then
            btn17.BackColor = Color.Transparent
            btn17.Text = ""
        Else
        End If
        If btn18.BackColor = Color.LightGreen Then
            btn18.BackColor = Color.Transparent
            btn18.Text = ""
        Else
        End If
        If btn19.BackColor = Color.LightGreen Then
            btn19.BackColor = Color.Transparent
            btn19.Text = ""
        Else
        End If
        If btn20.BackColor = Color.LightGreen Then
            btn20.BackColor = Color.Transparent
            btn20.Text = ""
        Else
        End If
        If btn21.BackColor = Color.LightGreen Then
            btn21.BackColor = Color.Transparent
            btn21.Text = ""
        Else
        End If
        If btn22.BackColor = Color.LightGreen Then
            btn22.BackColor = Color.Transparent
            btn22.Text = ""
        Else
        End If
        If btn23.BackColor = Color.LightGreen Then
            btn23.BackColor = Color.Transparent
            btn23.Text = ""
        Else
        End If
        If btn24.BackColor = Color.LightGreen Then
            btn24.BackColor = Color.Transparent
            btn24.Text = ""
        Else
        End If
        If btn25.BackColor = Color.LightGreen Then
            btn25.BackColor = Color.Transparent
            btn25.Text = ""
        Else
        End If
        If btn26.BackColor = Color.LightGreen Then
            btn26.BackColor = Color.Transparent
            btn26.Text = ""
        Else
        End If
        If btn27.BackColor = Color.LightGreen Then
            btn27.BackColor = Color.Transparent
            btn27.Text = ""
        Else
        End If
        If btn28.BackColor = Color.LightGreen Then
            btn28.BackColor = Color.Transparent
            btn28.Text = ""
        Else
        End If
        If btn29.BackColor = Color.LightGreen Then
            btn29.BackColor = Color.Transparent
            btn29.Text = ""
        Else
        End If
        If btn30.BackColor = Color.LightGreen Then
            btn30.BackColor = Color.Transparent
            btn30.Text = ""
        Else
        End If
        If btn31.BackColor = Color.LightGreen Then
            btn31.BackColor = Color.Transparent
            btn31.Text = ""
        Else
        End If
        If btn32.BackColor = Color.LightGreen Then
            btn32.BackColor = Color.Transparent
            btn32.Text = ""
        Else
        End If
        If btn33.BackColor = Color.LightGreen Then
            btn33.BackColor = Color.Transparent
            btn33.Text = ""
        Else
        End If
        If btn34.BackColor = Color.LightGreen Then
            btn34.BackColor = Color.Transparent
            btn34.Text = ""
        Else
        End If
        If btn35.BackColor = Color.LightGreen Then
            btn35.BackColor = Color.Transparent
            btn35.Text = ""
        Else
        End If
        If btn36.BackColor = Color.LightGreen Then
            btn36.BackColor = Color.Transparent
            btn36.Text = ""
        Else
        End If
        If btn37.BackColor = Color.LightGreen Then
            btn37.BackColor = Color.Transparent
            btn37.Text = ""
        Else
        End If
        If btn38.BackColor = Color.LightGreen Then
            btn38.BackColor = Color.Transparent
            btn38.Text = ""
        Else
        End If
        If btn39.BackColor = Color.LightGreen Then
            btn39.BackColor = Color.Transparent
            btn39.Text = ""
        Else
        End If
        If btn40.BackColor = Color.LightGreen Then
            btn40.BackColor = Color.Transparent
            btn40.Text = ""
        Else
        End If
        If btn41.BackColor = Color.LightGreen Then
            btn41.BackColor = Color.Transparent
            btn41.Text = ""
        Else
        End If
        If btn42.BackColor = Color.LightGreen Then
            btn42.BackColor = Color.Transparent
            btn42.Text = ""
        Else
        End If
        If btn43.BackColor = Color.LightGreen Then
            btn43.BackColor = Color.Transparent
            btn43.Text = ""
        Else
        End If
        If btn44.BackColor = Color.LightGreen Then
            btn44.BackColor = Color.Transparent
            btn44.Text = ""
        Else
        End If
        If btn45.BackColor = Color.LightGreen Then
            btn45.BackColor = Color.Transparent
            btn45.Text = ""
        Else

        End If
    End Sub
End Class