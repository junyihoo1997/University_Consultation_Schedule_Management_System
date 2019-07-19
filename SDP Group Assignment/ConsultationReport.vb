Partial Class ConsultationReport
    Partial Public Class StudentConsultationRecordDataTable
        Private Sub StudentConsultationRecordDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.AppointmentIDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class

Namespace ConsultationReportTableAdapters

    Partial Public Class StudentConsultationRecordTableAdapter
    End Class
End Namespace
