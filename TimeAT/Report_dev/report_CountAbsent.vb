Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class report_CountAbsent
    Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
        Try
            Dim totalEmp As Double = Convert.ToDouble(GetCurrentColumnValue("totalEmp").ToString())
            Dim Come As Double = Convert.ToDouble(GetCurrentColumnValue("Come").ToString())
            Dim Late As Double = Convert.ToDouble(GetCurrentColumnValue("TimeLate").ToString())
            Dim Vacation As Double = Convert.ToDouble(GetCurrentColumnValue("Vacation").ToString())
            Dim Absent As Double = Convert.ToDouble(GetCurrentColumnValue("TimeAbsent").ToString())

            lbComePer.Text = calPer(totalEmp, Come)
            lbLatePer.Text = calPer(totalEmp, Late)
            lbVaPer.Text = calPer(totalEmp, Vacation)
            lbAbsentPer.Text = calPer(totalEmp, Absent)
        Catch ex As Exception

        End Try
    End Sub

    Function calPer(total As Double, data As Double) As String
        Dim ret As Double = 0
        If total > 0 Then
            ret = Math.Round((data * 100) / total, 2)
        Else
            ret = 0
        End If

        Return Format(ret, "#0.00")
    End Function


    Private Sub ReportFooter_BeforePrint(sender As Object, e As PrintEventArgs) Handles ReportFooter.BeforePrint
        Try
            Dim totalEmp As Double = Convert.ToDouble(lblTotalEmp.Summary.GetResult)
            Dim Come As Double = Convert.ToDouble(lbTotalCome.Summary.GetResult)
            Dim Late As Double = Convert.ToDouble(lbTotalLate.Summary.GetResult)
            Dim Vacation As Double = Convert.ToDouble(lbTotalVacation.Summary.GetResult)
            Dim Absent As Double = Convert.ToDouble(lbTotalAbsent.Summary.GetResult)

            lbTotalComePer.Text = calPer(totalEmp, Come)
            lbTotalLatePer.Text = calPer(totalEmp, Late)
            lbTotalVaPer.Text = calPer(totalEmp, Vacation)
            lbTotalAbsPer.Text = calPer(totalEmp, Absent)
        Catch ex As Exception

        End Try


        'Dim totalEmp As Double = Convert.ToDouble(lblTotalEmp.Summary.GetResult())
        'Dim va As Double = Convert.ToDouble(lblTotalVa.Summary.GetResult())
        'Dim late As Double = Convert.ToDouble(lblTotalLate.Summary.GetResult())
        'Dim abs As Double = Convert.ToDouble(lblTotalAbs.Summary.GetResult())
        'Dim total As Double = Convert.ToDouble(lblTotalAll.Summary.GetResult())

        'Dim va_per As Double = (va * 100) / totalEmp
        'Dim late_per As Double = (late * 100) / totalEmp
        'Dim abs_per As Double = (abs * 100) / totalEmp
        'Dim total_per As Double = (total * 100) / totalEmp
        'lbLatePer.Text = late_per.ToString("#0.00")
        'lbVacPer.Text = va_per.ToString("#0.00")
        'lbAbsPer.Text = abs_per.ToString("#0.00")
        ''lbTotalPer.Text = total_per.ToString("#0.00")

    End Sub

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