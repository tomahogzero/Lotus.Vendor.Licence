Public Class frmReportMonthlySumary

    Private Sub frmReportMonthlySumary_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        fReportMonthlySumary = Nothing
    End Sub

    Private Sub frmReportMonthlySumary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        'ReportPrint = Report.PrintMonthlySumary
        'Dim Rpt As New frmViewReport
        'Rpt.ShowDialog()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class