Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class report_CheckComing
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