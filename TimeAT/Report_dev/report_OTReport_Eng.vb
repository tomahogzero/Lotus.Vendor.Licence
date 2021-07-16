Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class report_OTReport_Eng
    'Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
    '    Dim a As Double = 0
    '    a = GetCurrentColumnValue("SumD").ToString()

    '    lbTotal.Text = a / 8
    'End Sub


    Private Sub PageHeader_BeforePrint(sender As Object, e As PrintEventArgs) Handles PageHeader.BeforePrint
        'E:\#TimeAtt-final
        Try
            'Dim path As String = "E:\#TimeAtt-final\logo2.jpg"
            'pcLogo.Image = Image.FromFile(path)

            pcLogo.Image = cImage.getCompanyLogo
        Catch ex As Exception

        End Try

    End Sub
End Class