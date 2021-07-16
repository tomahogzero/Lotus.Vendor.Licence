Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraReports.UI
Imports TimeAttendance.utils

Public Class frmRpt_OTreport
    Dim db As New DBManager
    Dim gdata As New GetData
    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click



        ' Call GenTimeSheet()

        If IsDate(cDateTime.dbDate(txtDateStart.EditValue)) = False Then
            'MsgBox("กรุณาป้อนวันที่ให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmRpt_OTreportRS", Me.Text, "Check_Date", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
            txtDateStart.Focus()
            Exit Sub
        End If
        If IsDate(cDateTime.dbDate(txtDateStop.EditValue)) = False Then
            'MsgBox("กรุณาป้อนวันที่ให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmRpt_OTreportRS", Me.Text, "Check_Date", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
            txtDateStop.Focus()
            Exit Sub
        End If

        If chkFixedWHour.Checked = True Then
            If IsNumeric(txtFixedWHour.Text) = False Then
                'MsgBox("กรุณาป้อนตัวเลขให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
                '   MsgManager.ShowDialog(Me, "frmRpt_OTreportRS", Me.Text, "Check_Number", MessageBoxIcon.Information)
                MsgBox(My.Resources.res_warning_message.correct_number, MsgBoxStyle.Information, Me.Text)
                txtFixedWHour.Focus()
                Exit Sub
            End If
        End If

        If DateDiff(DateInterval.Day, txtDateStart.EditValue, txtDateStop.EditValue) > 31 Then
            '  MsgBox("ช่วงเวลาเกิน 31 วัน กรุณาเลือกใหม่", MsgBoxStyle.Information, Me.Text)
            MsgBox(My.Resources.res_warning_message_spacial.Report_Overtime_31, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If


        Dim divid As String = GetData.GetDivisionId(cboDivision.Text.Trim)
        Dim deptid As String = GetData.GetDepartmentId(cboDepartment.Text.Trim)
        If divid.Trim = "" And
                deptid.Trim = "" And
                txtCode1.Text.Trim = "" And
                txtNameSearch.Text.Trim = "" Then
            '    MsgBox("กรุณาเลือกข้อมูลที่ต้องการค้นหาก่อนออกรายงาน", MsgBoxStyle.Information, Me.Text)
            MsgBox(My.Resources.res_warning_message_spacial.Report_Selectdata, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        btnReport.Text = MsgManager.ShowLabel(Me, "rptTimeSheetRS", "Wait")
        btnReport.Enabled = False
        Call gen_otreport()
        btnReport.Text = MsgManager.ShowLabel(Me, "rptTimeSheetRS", "rpt")
        btnReport.Enabled = True

        'ReportPrint = Report.Print_OTReport
        'Dim Rpt As New frmViewReport
        'Rpt.ShowDialog()


        Call printreport()

        'If cValGolbal.Lang = "EN" Then
        '    Call printreport_Eng()
        'Else
        '    Call printreport()
        'End If

    End Sub



    Private Sub printreport()
        Dim strDate As String = ""

        If cValGolbal.Lang = "TH" Then
            strDate = "ประจำวันที่"
        Else
            strDate = "Date"
        End If

        Dim report As New report_OTReport
        Dim rptformular As String = ""
        Dim strComNm As String = ""


        Dim H1 As String = ""
        Dim H2 As String = ""
        Dim H3 As String = ""
        Dim H4 As String = ""
        Dim H5 As String = ""
        Dim H6 As String = ""
        Dim H7 As String = ""
        Dim H8 As String = ""
        Dim H9 As String = ""
        Dim H10 As String = ""
        Dim H11 As String = ""
        Dim H12 As String = ""
        Dim H13 As String = ""
        Dim H14 As String = ""
        Dim H15 As String = ""
        Dim H16 As String = ""
        Dim H17 As String = ""
        Dim H18 As String = ""
        Dim H19 As String = ""
        Dim H20 As String = ""
        Dim H21 As String = ""
        Dim H22 As String = ""
        Dim H23 As String = ""
        Dim H24 As String = ""
        Dim H25 As String = ""
        Dim H26 As String = ""
        Dim H27 As String = ""
        Dim H28 As String = ""
        Dim H29 As String = ""
        Dim H30 As String = ""
        Dim H31 As String = ""



        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "select * " &
                    " from Hrpt_OTreport "
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                H1 = ""
                H2 = ""
                H3 = ""
                H4 = ""
                H5 = ""
                H6 = ""
                H7 = ""
                H8 = ""
                H9 = ""
                H10 = ""
                H11 = ""
                H12 = ""
                H13 = ""
                H14 = ""
                H15 = ""
                H16 = ""
                H17 = ""
                H18 = ""
                H19 = ""
                H20 = ""
                H21 = ""
                H22 = ""
                H23 = ""
                H24 = ""
                H25 = ""
                H26 = ""
                H27 = ""
                H28 = ""
                H29 = ""
                H30 = ""
                H31 = ""
            Else
                H1 = .Rows(0).Item("H1")
                H2 = .Rows(0).Item("H2")
                H3 = .Rows(0).Item("H3")
                H4 = .Rows(0).Item("H4")
                H5 = .Rows(0).Item("H5")
                H6 = .Rows(0).Item("H6")
                H7 = .Rows(0).Item("H7")
                H8 = .Rows(0).Item("H8")
                H9 = .Rows(0).Item("H9")
                H10 = .Rows(0).Item("H10")
                H11 = .Rows(0).Item("H11")
                H12 = .Rows(0).Item("H12")
                H13 = .Rows(0).Item("H13")
                H14 = .Rows(0).Item("H14")
                H15 = .Rows(0).Item("H15")
                H16 = .Rows(0).Item("H16")
                H17 = .Rows(0).Item("H17")
                H18 = .Rows(0).Item("H18")
                H19 = .Rows(0).Item("H19")
                H20 = .Rows(0).Item("H20")
                H21 = .Rows(0).Item("H21")
                H22 = .Rows(0).Item("H22")
                H23 = .Rows(0).Item("H23")
                H24 = .Rows(0).Item("H24")
                H25 = .Rows(0).Item("H25")
                H26 = .Rows(0).Item("H26")
                H27 = .Rows(0).Item("H27")
                H28 = .Rows(0).Item("H28")
                H29 = .Rows(0).Item("H29")
                H30 = .Rows(0).Item("H30")
                H31 = .Rows(0).Item("H31")
            End If
        End With


        report.SqlDataSource1.Connection.ConnectionString = db.getConnString


        rptformular = 1 = "1"
        rptformular &= " And   [WorkStatus]='W'"
        If txtCode1.Text <> "" Then  ' ¤é¹ËÒµÒÁÃËÑÊ
            rptformular &= " And [code]='" & txtCode1.Text.Trim & "'"
        End If
        If txtNameSearch.Text <> "" Then  ' ¤é¹ËÒµÒÁª×èÍ
            rptformular &= " And [Fname] Like '%" & txtNameSearch.Text.Trim & "%'"
        End If

        If cboDivision.SelectedIndex > 0 Then ' ¶éÒàÅ×Í¡½èÒÂ·Ñé§ËÁ´
            Dim Division_Id As String = ""
            Division_Id = GetData.GetDivisionId(cboDivision.Text) ' ËÒ ÃËÑÊ ½èÒÂ
            rptformular &= " And  [DivId] = '" & Division_Id.Trim & "'"
        End If

        If cboDepartment.SelectedIndex > 0 Then ' ¶éÒàÅ×Í¡á¼¹¡ ·Ñé§ËÁ´
            Dim Department_Id As String = ""
            Department_Id = GetData.GetDepartmentId(cboDepartment.Text) ' ËÒá¼¹¡
            rptformular &= " And   [DeptId]='" & Department_Id.Trim & "'"
        End If


        If chkDay.Checked = True Then
            ' áÊ´§ ·ÕèÁÕ¢éÍÁÙÅ ÇÑ¹·Ó§Ò¹ > 0
            rptformular &= " and ([d1]+[d2]+[d3]+" &
                                 "[d4]+[d5]+[d6]+" &
                                 "[d7]+[d8]+[d9]+" &
                                 "[d10]+[d11]+[d12]+" &
                                 "[d13]+[d14]+[d15]+" &
                                 "[d16]+[d17]+[d18]+" &
                                 "[d19]+[d20]+[d21]+" &
                                 "[d22]+[d23]+[d24]+" &
                                 "[d25]+[d26]+[d27]+" &
                                 "[d28]+[d29]+[d30]+" &
                                 "[d31]" &
                                " ) > 0 "
        End If


        If chkOT.Checked = True Then

            ' áÊ´§ ·ÕèÁÕ¢éÍÁÙÅ OT > 0
            rptformular &= " and ([oth1]+[oth2]+[oth3]+" &
                                 "[oth4]+[oth5]+[oth6]+" &
                                 "[oth7]+[oth8]+[oth9]+" &
                                 "[oth10]+[oth11]+[oth12]+" &
                                 "[oth13]+[oth14]+[oth15]+" &
                                 "[oth16]+[oth17]+[oth18]+" &
                                 "[oth19]+[oth20]+[oth21]+" &
                                 "[oth22]+[oth23]+[oth24]+" &
                                 "[oth25]+[oth26]+[oth27]+" &
                                 "[oth28]+[oth29]+[oth30]+" &
                                 "[oth31]" &
                                " ) > 0 "
        End If

        '   [code] = '11' And [Fname] Like '11' And [CompanyID] = '001' And [DivId] = '1' And [DeptId] = '11' And [Position] = '11' 
        '   And [GroupId] = '11' And [WageType] = '11' And [Contractor] = True And [d1] = 44.0m And [oth1] = 11.0m

        Dim strdata As String = ""
        Dim strDt As String = ""
        Dim strdateUse As String = ""

        'strDt = Format(CDate(txtDateStart.Text), "dd/MM/yyyy")
        'strdateUse = Format(CDate(txtDateStart.Text), "yyyy/MM/dd")


        Dim Companyname As String = ""
        Companyname = GetData.GetCompanyName ' 

        'report.Parameters("companyname").Value = "" & Companyname & ""
        Dim allhead As String = Me.Text ' "รายงานค่าล่วงเวลาทำงาน"
        report.Parameters("rpthead").Value = "" & allhead & ""
        report.Parameters("companyname").Value = "" & Companyname & ""
        '   report.Parameters("headdate").Value = "ประจำวันที่" & " " & "" & strDt & ""
        report.Parameters("head_f_month").Value = strDate & " : " & "" & txtDateStart.Text & " - " & txtDateStop.Text & ""
        '   Cry.DataDefinition.FormulaFields("rpt_Monthly").Text = "'" & MsgManager.ShowLabel(Me, "cryRPT_OTreportRS", "rpt_Monthly") & " " & txtDateStart.Text & " - " & txtDateStop.Text & "'"



        report.Parameters("H1").Value = "" & H1 & ""
        report.Parameters("H2").Value = "" & H2 & ""
        report.Parameters("H3").Value = "" & H3 & ""
        report.Parameters("H4").Value = "" & H4 & ""
        report.Parameters("H5").Value = "" & H5 & ""
        report.Parameters("H6").Value = "" & H6 & ""
        report.Parameters("H7").Value = "" & H7 & ""
        report.Parameters("H8").Value = "" & H8 & ""
        report.Parameters("H9").Value = "" & H9 & ""
        report.Parameters("H10").Value = "" & H10 & ""
        report.Parameters("H11").Value = "" & H11 & ""
        report.Parameters("H12").Value = "" & H12 & ""
        report.Parameters("H13").Value = "" & H13 & ""
        report.Parameters("H14").Value = "" & H14 & ""
        report.Parameters("H15").Value = "" & H15 & ""
        report.Parameters("H16").Value = "" & H16 & ""
        report.Parameters("H17").Value = "" & H17 & ""
        report.Parameters("H18").Value = "" & H18 & ""
        report.Parameters("H19").Value = "" & H19 & ""
        report.Parameters("H20").Value = "" & H20 & "'"
        report.Parameters("H21").Value = "" & H21 & ""
        report.Parameters("H22").Value = "" & H22 & ""
        report.Parameters("H23").Value = "" & H23 & ""
        report.Parameters("H24").Value = "" & H24 & ""
        report.Parameters("H25").Value = "" & H25 & ""
        report.Parameters("H26").Value = "" & H26 & ""
        report.Parameters("H27").Value = "" & H27 & ""
        report.Parameters("H28").Value = "" & H28 & ""
        report.Parameters("H29").Value = "" & H29 & ""
        report.Parameters("H30").Value = "" & H30 & ""
        report.Parameters("H31").Value = "" & H31 & ""




        report.RequestParameters = False
        report.FilterString = rptformular

        Using printTool As New ReportPrintTool(report)
            printTool.AutoShowParametersPanel = False
            '   AddHandler printTool.PrintingSystem.StartPrint, New DevExpress.XtraPrinting.PrintDocumentEventHandler(AddressOf PrintingSystem_StartPrint)

            printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default)
        End Using
    End Sub

    Private Sub printreport_Eng()
        Dim report As New report_OTReport_Eng
        Dim rptformular As String = ""
        Dim strComNm As String = ""


        Dim H1 As String = ""
        Dim H2 As String = ""
        Dim H3 As String = ""
        Dim H4 As String = ""
        Dim H5 As String = ""
        Dim H6 As String = ""
        Dim H7 As String = ""
        Dim H8 As String = ""
        Dim H9 As String = ""
        Dim H10 As String = ""
        Dim H11 As String = ""
        Dim H12 As String = ""
        Dim H13 As String = ""
        Dim H14 As String = ""
        Dim H15 As String = ""
        Dim H16 As String = ""
        Dim H17 As String = ""
        Dim H18 As String = ""
        Dim H19 As String = ""
        Dim H20 As String = ""
        Dim H21 As String = ""
        Dim H22 As String = ""
        Dim H23 As String = ""
        Dim H24 As String = ""
        Dim H25 As String = ""
        Dim H26 As String = ""
        Dim H27 As String = ""
        Dim H28 As String = ""
        Dim H29 As String = ""
        Dim H30 As String = ""
        Dim H31 As String = ""



        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "select * " &
                    " from Hrpt_OTreport "
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                H1 = ""
                H2 = ""
                H3 = ""
                H4 = ""
                H5 = ""
                H6 = ""
                H7 = ""
                H8 = ""
                H9 = ""
                H10 = ""
                H11 = ""
                H12 = ""
                H13 = ""
                H14 = ""
                H15 = ""
                H16 = ""
                H17 = ""
                H18 = ""
                H19 = ""
                H20 = ""
                H21 = ""
                H22 = ""
                H23 = ""
                H24 = ""
                H25 = ""
                H26 = ""
                H27 = ""
                H28 = ""
                H29 = ""
                H30 = ""
                H31 = ""
            Else
                H1 = .Rows(0).Item("H1")
                H2 = .Rows(0).Item("H2")
                H3 = .Rows(0).Item("H3")
                H4 = .Rows(0).Item("H4")
                H5 = .Rows(0).Item("H5")
                H6 = .Rows(0).Item("H6")
                H7 = .Rows(0).Item("H7")
                H8 = .Rows(0).Item("H8")
                H9 = .Rows(0).Item("H9")
                H10 = .Rows(0).Item("H10")
                H11 = .Rows(0).Item("H11")
                H12 = .Rows(0).Item("H12")
                H13 = .Rows(0).Item("H13")
                H14 = .Rows(0).Item("H14")
                H15 = .Rows(0).Item("H15")
                H16 = .Rows(0).Item("H16")
                H17 = .Rows(0).Item("H17")
                H18 = .Rows(0).Item("H18")
                H19 = .Rows(0).Item("H19")
                H20 = .Rows(0).Item("H20")
                H21 = .Rows(0).Item("H21")
                H22 = .Rows(0).Item("H22")
                H23 = .Rows(0).Item("H23")
                H24 = .Rows(0).Item("H24")
                H25 = .Rows(0).Item("H25")
                H26 = .Rows(0).Item("H26")
                H27 = .Rows(0).Item("H27")
                H28 = .Rows(0).Item("H28")
                H29 = .Rows(0).Item("H29")
                H30 = .Rows(0).Item("H30")
                H31 = .Rows(0).Item("H31")
            End If
        End With


        report.SqlDataSource1.Connection.ConnectionString = db.getConnString


        rptformular = 1 = "1"
        rptformular &= " And   [WorkStatus]='W'"
        If txtCode1.Text <> "" Then  ' ¤é¹ËÒµÒÁÃËÑÊ
            rptformular &= " And [code]='" & txtCode1.Text.Trim & "'"
        End If
        If txtNameSearch.Text <> "" Then  ' ¤é¹ËÒµÒÁª×èÍ
            rptformular &= " And [Fname] Like '%" & txtNameSearch.Text.Trim & "%'"
        End If

        If cboDivision.SelectedIndex > 0 Then ' ¶éÒàÅ×Í¡½èÒÂ·Ñé§ËÁ´
            Dim Division_Id As String = ""
            Division_Id = GetData.GetDivisionId(cboDivision.Text) ' ËÒ ÃËÑÊ ½èÒÂ
            rptformular &= " And  [DivId] = '" & Division_Id.Trim & "'"
        End If

        If cboDepartment.SelectedIndex > 0 Then ' ¶éÒàÅ×Í¡á¼¹¡ ·Ñé§ËÁ´
            Dim Department_Id As String = ""
            Department_Id = GetData.GetDepartmentId(cboDepartment.Text) ' ËÒá¼¹¡
            rptformular &= " And   [DeptId]='" & Department_Id.Trim & "'"
        End If


        If chkDay.Checked = True Then
            ' áÊ´§ ·ÕèÁÕ¢éÍÁÙÅ ÇÑ¹·Ó§Ò¹ > 0
            rptformular &= " and ([d1]+[d2]+[d3]+" &
                                 "[d4]+[d5]+[d6]+" &
                                 "[d7]+[d8]+[d9]+" &
                                 "[d10]+[d11]+[d12]+" &
                                 "[d13]+[d14]+[d15]+" &
                                 "[d16]+[d17]+[d18]+" &
                                 "[d19]+[d20]+[d21]+" &
                                 "[d22]+[d23]+[d24]+" &
                                 "[d25]+[d26]+[d27]+" &
                                 "[d28]+[d29]+[d30]+" &
                                 "[d31]" &
                                " ) > 0 "
        End If


        If chkOT.Checked = True Then

            ' áÊ´§ ·ÕèÁÕ¢éÍÁÙÅ OT > 0
            rptformular &= " and ([oth1]+[oth2]+[oth3]+" &
                                 "[oth4]+[oth5]+[oth6]+" &
                                 "[oth7]+[oth8]+[oth9]+" &
                                 "[oth10]+[oth11]+[oth12]+" &
                                 "[oth13]+[oth14]+[oth15]+" &
                                 "[oth16]+[oth17]+[oth18]+" &
                                 "[oth19]+[oth20]+[oth21]+" &
                                 "[oth22]+[oth23]+[oth24]+" &
                                 "[oth25]+[oth26]+[oth27]+" &
                                 "[oth28]+[oth29]+[oth30]+" &
                                 "[oth31]" &
                                " ) > 0 "
        End If

        '   [code] = '11' And [Fname] Like '11' And [CompanyID] = '001' And [DivId] = '1' And [DeptId] = '11' And [Position] = '11' 
        '   And [GroupId] = '11' And [WageType] = '11' And [Contractor] = True And [d1] = 44.0m And [oth1] = 11.0m

        Dim strdata As String = ""
        Dim strDt As String = ""
        Dim strdateUse As String = ""

        'strDt = Format(CDate(txtDateStart.Text), "dd/MM/yyyy")
        'strdateUse = Format(CDate(txtDateStart.Text), "yyyy/MM/dd")


        Dim Companyname As String = ""
        Companyname = GetData.GetCompanyName ' 

        'report.Parameters("companyname").Value = "" & Companyname & ""
        Dim allhead As String = Me.Text  ' "รายงานค่าล่วงเวลาทำงาน"
        report.Parameters("rpthead").Value = "" & allhead & ""
        report.Parameters("companyname").Value = "" & Companyname & ""
        '   report.Parameters("headdate").Value = "ประจำวันที่" & " " & "" & strDt & ""
        report.Parameters("head_f_month").Value = "Date  " & "" & txtDateStart.Text & " - " & txtDateStop.Text & ""
        '   Cry.DataDefinition.FormulaFields("rpt_Monthly").Text = "'" & MsgManager.ShowLabel(Me, "cryRPT_OTreportRS", "rpt_Monthly") & " " & txtDateStart.Text & " - " & txtDateStop.Text & "'"



        report.Parameters("H1").Value = "" & H1 & ""
        report.Parameters("H2").Value = "" & H2 & ""
        report.Parameters("H3").Value = "" & H3 & ""
        report.Parameters("H4").Value = "" & H4 & ""
        report.Parameters("H5").Value = "" & H5 & ""
        report.Parameters("H6").Value = "" & H6 & ""
        report.Parameters("H7").Value = "" & H7 & ""
        report.Parameters("H8").Value = "" & H8 & ""
        report.Parameters("H9").Value = "" & H9 & ""
        report.Parameters("H10").Value = "" & H10 & ""
        report.Parameters("H11").Value = "" & H11 & ""
        report.Parameters("H12").Value = "" & H12 & ""
        report.Parameters("H13").Value = "" & H13 & ""
        report.Parameters("H14").Value = "" & H14 & ""
        report.Parameters("H15").Value = "" & H15 & ""
        report.Parameters("H16").Value = "" & H16 & ""
        report.Parameters("H17").Value = "" & H17 & ""
        report.Parameters("H18").Value = "" & H18 & ""
        report.Parameters("H19").Value = "" & H19 & ""
        report.Parameters("H20").Value = "" & H20 & "'"
        report.Parameters("H21").Value = "" & H21 & ""
        report.Parameters("H22").Value = "" & H22 & ""
        report.Parameters("H23").Value = "" & H23 & ""
        report.Parameters("H24").Value = "" & H24 & ""
        report.Parameters("H25").Value = "" & H25 & ""
        report.Parameters("H26").Value = "" & H26 & ""
        report.Parameters("H27").Value = "" & H27 & ""
        report.Parameters("H28").Value = "" & H28 & ""
        report.Parameters("H29").Value = "" & H29 & ""
        report.Parameters("H30").Value = "" & H30 & ""
        report.Parameters("H31").Value = "" & H31 & ""




        report.RequestParameters = False
        report.FilterString = rptformular

        Using printTool As New ReportPrintTool(report)
            printTool.AutoShowParametersPanel = False
            '   AddHandler printTool.PrintingSystem.StartPrint, New DevExpress.XtraPrinting.PrintDocumentEventHandler(AddressOf PrintingSystem_StartPrint)

            printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default)
        End Using
    End Sub

    Private Sub gen_otreport()


        Dim datest As String = cDateTime.dbDate(txtDateStart.EditValue)
        Dim datesp As String = cDateTime.dbDate(txtDateStop.EditValue)


        Call gen_otreport_genhead(datest, datesp)


        Dim deptid As String = GetData.GetDepartmentId(cboDepartment.Text.Trim)
        Dim divid As String = GetData.GetDivisionId(cboDivision.Text.Trim)

        Dim dcmd As New SqlCommand
        Dim tn As SqlTransaction

        tn = Conn.BeginTransaction
        dcmd.Transaction = tn
        Try

            Call gen_otreport_addemp(dcmd, datest, datesp,
                                     txtCode1.Text.Trim,
                                     txtNameSearch.Text.Trim,
                                     deptid,
                                     divid,
                                     cValGolbal.Lang)

            Call gen_otreport_calculate(dcmd, datest, datesp)

            Call gen_otreport_sumary(dcmd, datest, datesp)


            tn.Commit()
        Catch ex As Exception
            tn.Rollback()
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub GenTimeSheet()
        Dim dCmd As New SqlCommand

        Dim DateST As Date = txtDateStart.EditValue
        Dim DateSP As Date = txtDateStop.EditValue

        Dim dRun As Date = DateST
        Dim DT As DataTable = GetDTEmp(dCmd, Format(DateST, "yyyy/MM/dd"), Format(DateSP, "yyyy/MM/dd"))

        PbOverall.Value = 0
        PbOverall.Maximum = (DateDiff(DateInterval.Day, DateST, DateSP)) + 1

        PbOverall.Visible = True

        Dim I As Integer = 0
        Dim D As Integer = 0
        Do Until dRun > DateSP
            D += 1

            If D > 31 Then Exit Do
            'lblStatus1.Text = "วันที่ " & Format(dRun, "dd/MM/yyyy")
            PbOverall.Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "Date2") & Format(dRun, "dd/MM/yyyy")
            Application.DoEvents()

            Call UpdateData_OT(dCmd, Format(dRun, "yyyy/MM/dd"), "", D)

            dRun = dRun.AddDays(1)
            PbOverall.Value += 1
        Loop

        Call GetUpdate_OT_Sumary(dCmd, cDateTime.dbDate(DateST), cDateTime.dbDate(DateSP))

        PbOverall.Visible = False
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub GenCodeEmp()
        Dim dCmd As New SqlCommand
        If txtDateStart.Text = "  /  /" Or txtDateStop.Text = "  /  /" Then
            MsgManager.ShowDialog(Me, "frmRpt_OTreportRS", Me.Text, "Insert_Date", MessageBoxIcon.Information)
            'MsgBox("กรุณาป้อนวันที่ด้วย", MsgBoxStyle.OkOnly, "ผิดพลาด")
            Exit Sub
        End If


        Dim DateST As Date = cDateTime.dbDate(txtDateStart.EditValue)
        Dim DateSP As Date = cDateTime.dbDate(txtDateStop.EditValue)

        'Try
        Call ClearData(dCmd)

        Dim i As Integer = "0"
        Dim dRun As Date = DateST
        Dim Hdate As String = ""


        Do Until dRun > DateSP

            ' For Each dr As DataRow In DT.Rows
            i += 1
            Hdate = "H" & i
            If i > "31" Then
                Exit Do
            End If

            If ChkDataNull_HotReport() = False Then
                StrSql = "Insert into Hrpt_Otreport  (" & Hdate & ")Values ('" & Mid(Format(dRun, "dd/MM/yyyy"), 1, 2) & "')"
            Else
                StrSql = "Update Hrpt_Otreport Set " & Hdate & "='" & Mid(Format(dRun, "dd/MM/yyyy"), 1, 2) & "'"
            End If


            dCmd.Connection = Conn
            dCmd.CommandText = StrSql
            dCmd.ExecuteNonQuery()
            ' Call UpdateData(dCmd, Format(dRun, "yyyy/MM/dd"), dr("Code"))

            'Next
            dRun = dRun.AddDays(1)

        Loop

        Call AddEmpToTemp(dCmd)
        'Call InsertDataFrist(dCmd)
        'Call GetUpdate_OTAll(dCmd, Format(DateST, "yyyy/MM/dd"), Format(DateSP, "yyyy/MM/dd"))

        'Dim DT As DataTable = GetDTEmp(dCmd, Format(DateST, "yyyy/MM/dd"), Format(DateSP, "yyyy/MM/dd"))
        'PB_Emp.Value = 1
        'PB_Emp.Maximum = DT.Rows.Count
        'For Each dr As DataRow In DT.Rows
        '    'Call InsertDataFrist(dCmd, dr("Code"), dr("OtId"), dr("Salary"))
        '    Call GetUpdate_OTAll(dCmd, dr("Code"), Format(DateST, "yyyy/MM/dd"), Format(DateSP, "yyyy/MM/dd"))
        '    PB_Emp.Value += 1
        'Next

    End Sub

    Private Sub InsertDataFrist(ByVal dCmd As SqlCommand)
        Dim db As New db


        StrSql = "update Rpt_OTreport set OT = isnull(ot.ChkOT,0)" &
                " From Rpt_OTreport rpt inner Join (" &
                            " select emp.Code,ChkOT = isnull(case eot.OtID" &
                                                        " when 1 then 0" &
                                                        " when 2 then 0" &
                                                        " when 3 then 35" &
                                                        " when 4 then 100" &
                                                        " when 5 then 0" &
                                                        " Else 0 End,0)" &
                            " from Emp Inner join empconfigOt eot" &
                                " On emp.code=eot.empcode) ot" &
                        " On rpt.Code = ot.Code"
        db.ExecuteCommand(Conn, dCmd, StrSql)

    End Sub

    Private Sub ClearData(ByVal dCmd As SqlCommand)
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet

        strSQL = "Delete From rpt_Otreport"
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()


        strSQL = "Delete From Hrpt_Otreport"
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()
    End Sub

    Private Sub AddEmpToTemp(ByVal dCmd As SqlCommand)
        Dim strSQL As String
        Dim DA As New SqlDataAdapter
        Dim Ds As New DataSet

        'Dim DivId As String = GetDivId(cboDivision1.Text.Trim)
        'Dim DeptId As String = GetDeptId(cboDepartment1.Text.Trim)
        'Dim SecId As String = GetSecId(cboSection.Text.Trim)
        Dim Company_Id As String = GetData.GetCompanyId(cboCompany.Text.Trim)
        Dim Division_Id As String = GetData.GetDivisionId(cboDivision.Text.Trim)
        Dim Department_Id As String = GetData.GetDepartmentId(cboDepartment.Text.Trim)
        Dim EmpGroup_Id As String = GetData.GetEmpGroupId(cboEmpGroup.Text.Trim)


        strSQL = " Insert into Rpt_OTreport(Code)" &
                    "select Code" &
                    " From Emp left join department " &
                            " on emp.deptid = department.deptid " &
                          " left join division div " &
                            " on department.divid = div.divid " &
                 " Where WorkStatus='W' "


        If txtCode1.Text <> "" Then   ' ค้นหาเฉพาะรหัสพนักงาน
            strSQL &= " And Emp.Code='" & txtCode1.Text.Trim & "'"
        End If
        If txtNameSearch.Text <> "" Then  ' ค้นหาเฉพาะชื่อ
            strSQL &= " And Emp.Fname like '%" & txtNameSearch.Text.Trim & "%'"
        End If

        If txtCode1.Text.Trim = "" And txtNameSearch.Text.Trim = "" And Division_Id <> "" Then  ' ฝ่าย
            strSQL &= " and Department.DivId = '" & Division_Id.Trim & "'"
        End If
        '   If txtCode1.Text.Trim = "" And txtNameSearch.Text.Trim = "" And (Department_Id.Trim <> "" Or Department_Id.Trim <> "000") Then '  แผนก
        If txtCode1.Text.Trim = "" And txtNameSearch.Text.Trim = "" And (Department_Id.Trim <> "") Then '  แผนก
            strSQL &= " and Emp.DeptId = '" & Department_Id.Trim & "'"
        End If


        strSQL &= " Order by Code"

        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()

        'DA.SelectCommand = dCmd
        'DA.Fill(Ds, "data")
        'Return Ds.Tables("data")
    End Sub

    Function GetDTEmp(ByVal dCmd As SqlCommand, ByVal DateST As String, ByVal DateSP As String) As DataTable
        Dim strSQL As String
        Dim DA As New SqlDataAdapter
        Dim Ds As New DataSet

        'Dim DivId As String = GetDivId(cboDivision1.Text.Trim)
        'Dim DeptId As String = GetDeptId(cboDepartment1.Text.Trim)
        'Dim SecId As String = GetSecId(cboSection.Text.Trim)

        Dim Division_Id As String = GetData.GetDivisionId(cboDivision.Text.Trim)
        Dim Department_Id As String = GetData.GetDepartmentId(cboDepartment.Text.Trim)



        strSQL = "select Code,department.divid,emp.Deptid,Secid,Groupid,Position," &
                            " Fname, Lname, WorkStatus, CompanyId, Brokerid, " &
                            " OtId=0,Salary" &
                    " From Emp left join department " &
                            " on emp.deptid = department.deptid " &
                          " left join division div " &
                            " on department.divid = div.divid " &
                 " Where WorkStatus='W' "


        If txtCode1.Text <> "" Then   ' ค้นหาเฉพาะรหัสพนักงาน
            strSQL &= " And Emp.Code='" & txtCode1.Text.Trim & "'"
        End If
        If txtNameSearch.Text <> "" Then  ' ค้นหาเฉพาะชื่อ
            strSQL &= " And Emp.Fname like '%" & txtNameSearch.Text.Trim & "%'"
        End If

        If txtCode1.Text.Trim = "" And txtNameSearch.Text.Trim = "" And Division_Id <> "" Then  ' ฝ่าย
            strSQL &= " and Department.DivId = '" & Division_Id.Trim & "'"
        End If
        '   If txtCode1.Text.Trim = "" And txtNameSearch.Text.Trim = "" And (Department_Id.Trim <> "" Or Department_Id.Trim <> "000") Then '  แผนก
        If txtCode1.Text.Trim = "" And txtNameSearch.Text.Trim = "" And (Department_Id.Trim <> "") Then '  แผนก
            strSQL &= " and Emp.DeptId = '" & Department_Id.Trim & "'"
        End If

        strSQL &= " Order by Code"

        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()
        DA.SelectCommand = dCmd
        DA.Fill(Ds, "data")
        Return Ds.Tables("data")
    End Function


    Private Sub gen_otreport_genhead(datest As Date, datesp As Date)
        Dim dCmd As New SqlCommand
        'If txtDateStart.Text = "  /  /" Or txtDateStop.Text = "  /  /" Then
        '    MsgManager.ShowDialog(Me, "frmRpt_OTreportRS", Me.Text, "Insert_Date", MessageBoxIcon.Information)
        '    'MsgBox("กรุณาป้อนวันที่ด้วย", MsgBoxStyle.OkOnly, "ผิดพลาด")
        '    Exit Sub
        'End If


        'Dim DateST As Date = cDateTime.dbDate(txtDateStart.EditValue)
        'Dim DateSP As Date = cDateTime.dbDate(txtDateStop.EditValue)

        'Try
        Call ClearData(dCmd)

        Dim i As Integer = "0"
        Dim dRun As Date = datest
        Dim Hdate As String = ""


        Do Until dRun > datesp

            ' For Each dr As DataRow In DT.Rows
            i += 1
            Hdate = "H" & i
            If i > "31" Then
                Exit Do
            End If

            If ChkDataNull_HotReport() = False Then
                StrSql = "Insert into Hrpt_Otreport  (" & Hdate & ")Values ('" & Mid(Format(dRun, "dd/MM/yyyy"), 1, 2) & "')"
            Else
                StrSql = "Update Hrpt_Otreport Set " & Hdate & "='" & Mid(Format(dRun, "dd/MM/yyyy"), 1, 2) & "'"
            End If


            dCmd.Connection = Conn
            dCmd.CommandText = StrSql
            dCmd.ExecuteNonQuery()
            ' Call UpdateData(dCmd, Format(dRun, "yyyy/MM/dd"), dr("Code"))

            'Next
            dRun = dRun.AddDays(1)

        Loop
    End Sub

    Private Sub gen_otreport_addemp(ByVal dCmd As SqlCommand, ByVal datest As String, ByVal datesp As String,
                                    code As String,
                                    name As String,
                                    deptid As String,
                                    divid As String,
                                    lang As String)
        Dim db As New db

        StrSql = "exec sp_rpt_otreport_addemp '" & datest & "','" & datesp & "'" &
                                            ",'" & code & "'" &
                                            ",'" & name & "'" &
                                            ",'" & deptid & "'" &
                                            ",'" & divid & "'" &
                                            ",'" & lang & "'"


        db.ExecuteCommand(Conn, dCmd, StrSql)

    End Sub

    Private Sub gen_otreport_calculate(ByVal dCmd As SqlCommand, ByVal datest As String, ByVal datesp As String)
        Dim db As New db

        Dim process_no As Integer = 0

        Dim dt As DataTable = get_dt_otreport_processno(dCmd)

        PbOverall.Value = 0
        PbOverall.Maximum = dt.Rows.Count
        Application.DoEvents()

        For Each dr As DataRow In dt.Rows
            process_no = dr("rec")
            StrSql = "exec sp_rpt_otreport_calculate '" & datest & "','" & datesp & "'" &
                                    "," & process_no & ""

            db.ExecuteCommand(Conn, dCmd, StrSql)
            PbOverall.Value += 1
        Next
    End Sub

    Private Sub gen_otreport_sumary(ByVal dCmd As SqlCommand, ByVal datest As String, ByVal datesp As String)
        Dim db As New db

        StrSql = "exec sp_rpt_otreport_sumary '" & datest & "','" & datesp & "'"

        db.ExecuteCommand(Conn, dCmd, StrSql)

    End Sub

    Function get_dt_otreport_processno(ByVal dCmd As SqlCommand) As DataTable
        Dim db As New db
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        StrSql = "select rec from Rpt_OTreport " &
                    " group by rec" &
                    " order by rec"

        db.ExecuteCommand(Conn, dCmd, StrSql)
        da.SelectCommand = dCmd
        da.Fill(ds, "data")
        Return ds.Tables("data")
    End Function


    Function DateInIsExist(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String) As Boolean
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet

        strSQL = "Select Code From TimeOvertime " &
                " Where Convert(nVarchar(10),DateIn,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "'"
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        End With
    End Function

    Private Sub UpdateData_OT(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String, ByVal D As Integer)
        GetUpdate_OT(dCmd, DateIn, Code, D)  ' Insert OT การทำงาน
        GetUpdate_Hour(dCmd, DateIn, Code, D) ' insert เวลาที่ทำงาน คิดเป็นชั่วโมง
    End Sub

    Private Sub GetUpdate_OT(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String, ByVal D As Integer)

        Dim db As New db

        Dim Day_Name As String = ""
        Dim HOL_Name As String = ""
        Dim OTD_Name As String = ""
        Day_Name = "OTH" & D
        HOL_Name = "Hol" & D
        OTD_Name = "OTD" & D

        StrSql = "update Rpt_OTreport set " & Day_Name & " = isnull(ot.OT_Amt,0)" &
                                        "," & HOL_Name & " = isnull(ot.hol,0) " &
                                        "," & OTD_Name & " = isnull(ot.otd,0) " &
                " From Rpt_OTreport rpt inner Join (" &
                            " select tot.Code,OT_Amt = tot.OT_Overtime" &
                                         ",otd = tot.OT_Time" &
                                         ",hol = case when WKEnd = 1 or Hol = 1 then 1 " &
                                                " else 0 end " &
                            " from timeOvertime tot" &
                            " Where convert(nvarchar(10),Datein,111)= '" & DateIn & "') ot" &
                        " On rpt.Code = ot.Code"
        db.ExecuteCommand(Conn, dCmd, Strsql)
        'WKEnd,Hol
    End Sub

    Private Sub GetUpdate_OT_Sumary(ByVal dCmd As SqlCommand, ByVal datest As String, ByVal datesp As String)
        Dim db As New db
        Dim Day_Name As String = ""


        StrSql = "exec spRpt_OTReport_SumaryOT '" & datest & "','" & datesp & "'"

        db.ExecuteCommand(Conn, dCmd, StrSql)

    End Sub

    Private Sub GetUpdate_Hour(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String, ByVal D As Integer)

        Dim db As New db

        Dim Day_name As String = ""
        Day_name = "D" & D   ' หาลำกับวันที


        StrSql = "update Rpt_OTreport set " & Day_name & " = isnull(tw.hour_day,0)" &
        " From Rpt_OTreport rpt inner Join (" &
                    "select code,hour_day = Isnull(work_hour_in_ka,0) " &
                    " from timework " &
                    " Where convert(nvarchar(10),Datein,111) = '" & DateIn & "') tw" &
                " On rpt.Code = tw.Code"
        db.ExecuteCommand(Conn, dCmd, Strsql)

    End Sub


    Private Function GetOT(ByVal dCmd As SqlCommand, ByVal Code As String, ByVal dateST As String, ByVal dateSP As String, ByVal Ot_Rate As Single, ByVal OtDay As Boolean) As Single
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim db As New db
        Dim OTName As String = ""
        Dim OT_Amt As String = ""

        Dim strType As String = ""
        Dim Data As New ArrayList

        Dim strFieldOT As String = ""
        Dim strFieldOT_Rate As String = ""

        If OtDay = True Then
            strFieldOT = "OT_time"
            strFieldOT_Rate = "OT_time_Rate"
        Else
            strFieldOT = "OT_Overtime"
            strFieldOT_Rate = "OT_Overtime_Rate"
        End If


        Strsql = "select OT =isnull(sum(" & strFieldOT & "),0) " &
                " from timeOvertime " &
                " Where convert(nvarchar(10),Datein,111) between '" & dateST.Trim & "' and '" & dateSP.Trim & "' " &
                            " And Code='" & Code.Trim & "' and OT_Overtime_Rate = " & Ot_Rate

        Try
            dCmd.Connection = Conn
            dCmd.CommandText = Strsql
            dCmd.ExecuteNonQuery()

            Da.SelectCommand = dCmd
            Da.Fill(Ds, "DATA")

            With Ds.Tables("DATA")
                If .Rows.Count = 0 Then
                    Return 0
                Else
                    Return .Rows(0).Item("ot")
                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "ผิดพลาด")
            Return 0
            Exit Function
        End Try
    End Function


    Private Sub GetUpdate_OTAll(ByVal dCmd As SqlCommand, ByVal DateST As String, ByVal DateSP As String)

        'Dim Strsql As String = ""
        Dim db As New db

        'Dim strType As String = ""
        'Dim Data As New ArrayList

        'Dim ot15 As Single = GetOT(dCmd, Code, DateST, DateSP, 1.5, True) + GetOT(dCmd, Code, DateST, DateSP, 1.5, False)
        'Dim ot2 As Single = GetOT(dCmd, Code, DateST, DateSP, 2, True) + GetOT(dCmd, Code, DateST, DateSP, 2, False)
        'Dim ot3 As Single = GetOT(dCmd, Code, DateST, DateSP, 3, True) + GetOT(dCmd, Code, DateST, DateSP, 3, False)

        'Data.Clear() : strType = ""
        'Data.Add(Code.Trim) : strType &= "T"
        'Data.Add(ot15) : strType &= "S"
        'Data.Add(ot2) : strType &= "S"
        'Data.Add(ot3) : strType &= "S"

        'Strsql = "Update rpt_Otreport Set OT15=@P2,OT2=@P3,OT3=@P4 where Code=@P1"
        'db.ExecuteCommand(Conn, dCmd, Strsql, strType, Data)


        StrSql = "update rpt_otreport set OT15 = isnull(ott15.OT,0) + isnull(ot15.OT,0)," &
                        " ot2 = isnull(ott2.OT, 0) + isnull(ot2.OT, 0)," &
                        " OT3 =  isnull(ott3.OT,0) + isnull(ot3.OT,0)" &
                " From rpt_otreport rpt" &
                    " left join (" &
                            " Select Code, OT = isnull(sum(OT_time), 0) " &
                            " from timeOvertime " &
                            " Where Convert(nvarchar(10), Datein, 111) between '" & DateST & "' and '" & DateSP & "' " &
                                    " And OT_time_Rate =  1.5" &
                            " group by code) ott15" &
                        " On rpt.Code = ott15.Code" &
                    " left join (" &
                            " Select Code,OT =isnull(sum(OT_time),0) " &
                            " from timeOvertime " &
                            " Where Convert(nvarchar(10), Datein, 111) between '" & DateST & "' and '" & DateSP & "' " &
                                    " And OT_time_Rate = 2" &
                            " group by code) ott2" &
                        " On rpt.Code = ott2.Code" &
                    " left join (" &
                            " Select Code,OT =isnull(sum(OT_time),0) " &
                            " from timeOvertime " &
                            " Where Convert(nvarchar(10), Datein, 111) between '" & DateST & "' and '" & DateSP & "' " &
                                    " And OT_time_Rate = 3" &
                            " group by code) ott3" &
                        " On rpt.Code = ott3.Code" &
                    " left join (" &
                            " Select Code,OT =isnull(sum(OT_Overtime),0) " &
                            " from timeOvertime " &
                            " Where Convert(nvarchar(10), Datein, 111) between '" & DateST & "' and '" & DateSP & "' " &
                                    " And OT_Overtime_Rate =  1.5" &
                            " group by code) as ot15" &
                        " On rpt.Code = ot15.Code" &
                    " left join (" &
                            " Select Code,OT =isnull(sum(OT_Overtime),0) " &
                            " from timeOvertime " &
                            " Where Convert(nvarchar(10), Datein, 111) between '" & DateST & "' and '" & DateSP & "' " &
                                    " And OT_Overtime_Rate =  2" &
                            " group by code) as ot2" &
                        " On rpt.Code = ot2.Code" &
                    " left join (" &
                            " Select Code,OT =isnull(sum(OT_Overtime),0) " &
                            " from timeOvertime " &
                            " Where Convert(nvarchar(10), Datein, 111) between '" & DateST & "' and '" & DateSP & "' " &
                                    " And OT_Overtime_Rate =  3" &
                            " group by code) as ot3" &
                        " On rpt.Code = ot3.Code"
        db.ExecuteCommand(Conn, dCmd, StrSql)
    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmRpt_OTreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '   Call LoadMonth()

        Call SearchData.LoadMonth(cboMonth, False, True)
        txtYear.Text = Date.Now.Year
        '  cboMonth.SelectedIndex = Date.Now.Month - 1

        txtDateStart.EditValue = Now.Date
        txtDateStop.EditValue = Now.Date

        Call SearchData.LoadDivision(Me, cboDivision, True)
        Call SearchData.LoadDepartment(Me, cboDepartment, "", True)
    End Sub

    Private Sub LoadMonth()
        Dim I As Integer
        cboMonth.Properties.Items.Clear()
        For I = 1 To 12
            'cboMonth.Items.Add(MonthNameThai(I))
            cboMonth.Properties.Items.Add(MonthName(Me, I))
        Next
    End Sub

    Private Sub LoadDepartment()

        '--------------------------------------------
        Dim DA As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = "select DeptId,Department " & _
            " from department "

        If cboCompany.SelectedIndex > 0 Then
            Strsql &= " Where DeptId In (Select DeptId From Emp " & _
                                    " Where WorkStatus  = 'W' and " & _
                                            " CompanyId = '" & GetData.GetCompanyId(cboCompany.Text) & "')"
        End If

        Strsql = Strsql & " Order By Department"

        DA = New SqlDataAdapter(Strsql, Conn)
        DA.Fill(Ds, "data")

        cboDepartment.Properties.Items.Clear()
        cboDepartment.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
        With Ds.Tables("data")
            For Each Dr As DataRow In .Rows
                cboDepartment.Properties.Items.Add(Dr("Department"))
            Next
            If cboDepartment.Properties.Items.Count > 0 Then
                cboDepartment.SelectedIndex = 0
            End If

        End With
    End Sub

    Private Sub LoadDivision()

        Dim DA As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = "select DivId,Division" & _
            " from DiviSion "

        If cboCompany.SelectedIndex > 0 Then
            Strsql &= " Where DivId In (Select DivId From Emp " & _
                                    " Where WorkStatus  = 'W' and " & _
                                            " CompanyId = '" & GetData.GetCompanyId(cboCompany.Text) & "')"
        End If

        Strsql = Strsql & " Order By Division"

        DA = New SqlDataAdapter(Strsql, Conn)
        DA.Fill(Ds, "data")

        cboDivision.Properties.Items.Clear()
        cboDivision.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
        With Ds.Tables("data")
            For Each Dr As DataRow In .Rows
                cboDivision.Properties.Items.Add(Dr("Division"))
            Next

            If cboDivision.Properties.Items.Count > 0 Then
                cboDivision.SelectedIndex = 0
            End If

        End With
    End Sub


    'Private Sub txtNameSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNameSearch.GotFocus
    '    txtCode1.Text = ""
    'End Sub



    'Private Sub txtCode1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode1.GotFocus, txtFixedWHour.GotFocus
    '    txtNameSearch.Text = ""
    'End Sub



    Function ChkDataNull_HotReport()
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select * from Hrpt_Otreport"

        Try
            DA = New SqlDataAdapter(Strsql, Conn)
            DA.Fill(DS, "DATA")

            With DS.Tables("DATA")
                If .Rows.Count = 0 Then
                    Return False
                Else
                    Return True
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub btnTodate_Click(sender As Object, e As EventArgs) Handles btnTodate.Click
        txtDateStop.EditValue = txtDateStart.EditValue
    End Sub

    Private Sub btnAllMonth_Click(sender As Object, e As EventArgs) Handles btnAllMonth.Click
        Call cboMonth_SelectedIndexChanged(Me, EventArgs.Empty)
    End Sub

    Private Sub btnCurrentDate_Click(sender As Object, e As EventArgs) Handles btnCurrentDate.Click
        txtDateStart.EditValue = Now.Date
        txtDateStop.EditValue = Now.Date
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged
        If IsNumeric(txtYear.Text.Trim) = False Then Exit Sub
        Dim newMonth As String
        Dim newYear As String
        newMonth = Format(cboMonth.SelectedIndex + 1, "00")
        newYear = txtYear.Text.Trim
        'End If
        Dim ar As New ArrayList
        ar = GetDayMonth(newMonth, newYear)
        txtDateStart.EditValue = CDate(ar.Item(0))
        txtDateStop.EditValue = CDate(ar.Item(1))
    End Sub

    Private Sub txtCode1_EditValueChanged(sender As Object, e As EventArgs) Handles txtCode1.EditValueChanged

    End Sub

    Private Sub txtCode1_LostFocus(sender As Object, e As EventArgs) Handles txtCode1.LostFocus
        txtName.Text = GetData.GetShowEmpName(txtCode1.Text.Trim)
    End Sub

    Private Sub cboDivision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDivision.SelectedIndexChanged
        Call SearchData.LoadDepartment(Me, cboDepartment, GetData.GetDivisionId(cboDivision.Text.Trim), True)
    End Sub
End Class