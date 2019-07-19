Public Class SelectWeek
    Private Sub SelectWeek_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnWeek_Click(sender As Object, e As EventArgs) Handles btnWeek.Click
        If cboWeekYear.Text = "" Or cboWeekYear.Text = "Week / Year" Then
            MessageBox.Show("Field is Empty! Please Enter Again!")
        Else
            bb = cboWeekYear.Text
            MessageBox.Show("Week is Selected! Entering to Publish Consultation Page!")
            PublishConsultationSchedule.Show()
            Me.Close()
        End If

    End Sub

    Private Sub cboWeekYear_GotFocus(sender As Object, e As EventArgs) Handles cboWeekYear.GotFocus
        ToolTipBaloon.IsBalloon = True
        ToolTipBaloon.InitialDelay = 10
        ToolTipBaloon.SetToolTip(cboWeekYear, "Please Select Week Here !")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        LecturerMainPage.Show()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If cboWeekYear.Text = "" Or cboWeekYear.Text = "Week / Year" Then
            MessageBox.Show("Field is Empty! Please Enter Again!")
        Else
            bb = cboWeekYear.Text
            MessageBox.Show("Week is Selected! Entering to Delete Consultation Page!")
            DeleteConsultationSlot.Show()
            Me.Close()
        End If
    End Sub

    Private Sub cboWeekYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboWeekYear.SelectedIndexChanged

    End Sub
End Class