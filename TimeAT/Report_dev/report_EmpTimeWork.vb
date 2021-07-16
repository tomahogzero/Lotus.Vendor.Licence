﻿Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class report_EmpTimeWork
    Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
        Try
            Dim Late As Double = Convert.ToDouble(GetCurrentColumnValue("Late").ToString())
            Dim LateOut As Double = 0
            Dim TimeWork As Double = Convert.ToDouble(GetCurrentColumnValue("WorkTime").ToString())

            If IsDBNull(GetCurrentColumnValue("Early")) = False Then
                LateOut = Convert.ToDouble(GetCurrentColumnValue("Early"))
            End If

            lblTestLate.Text = getTimeStr(Late)
            lblTestLateOut.Text = getTimeStr(LateOut)
            lblTestTimework.Text = getTimeStr(TimeWork)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub GroupFooter1_BeforePrint(sender As Object, e As PrintEventArgs) Handles GroupFooter1.BeforePrint
        Try
            Dim Late As Double = Convert.ToDouble(lbSumLate.Summary.GetResult)
            Dim LateOut As Double = Convert.ToDouble(lbSumLateOut.Summary.GetResult)
            Dim TimeWork As Double = Convert.ToDouble(lbSumWorkTime.Summary.GetResult)

            lbSumTotalLate.Text = getTimeStr(Late)
            lbSumTotalLateOut.Text = getTimeStr(LateOut)
            lbSumTotalTimework.Text = getTimeStr(TimeWork)
        Catch ex As Exception

        End Try

    End Sub

    Function getTimeStr(data As Double) As String
        Dim h As Double = 0
        Dim m As Double = 0
        Dim min As Double = data

        Dim ret As String = ""

        m = min Mod 60
        h = (min - m) / 60

        ret = Format(h, "#0") & ":" & Format(m, "00")
        Return ret
    End Function


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