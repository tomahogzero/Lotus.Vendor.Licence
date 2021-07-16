Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraReports.UI
Imports TimeAttendance.utils

Public Class frmRptAllEmpWork
    Dim gdata As New GetData
    Dim db As New DBManager
    Private Sub frmRptAllEmpWork_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        fReportTimeSheet = Nothing
    End Sub

    Private Sub frmRptAllEmpWork_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            If TypeOf Me.ActiveControl Is TextBox Then
                Dim tb As TextBox = DirectCast(Me.ActiveControl, TextBox)
                If tb.Multiline AndAlso tb.AcceptsReturn Then
                    e.Handled = False
                    Exit Sub
                End If
            End If
            e.Handled = True
            Dim oform As Form = Me.FindForm
            oform.SelectNextControl(oform.ActiveControl, True, True, True, True)
            oform.ActiveControl.Focus()
        End If
    End Sub

    Private Sub frmRptAllEmpWork_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'txtDateStart.Text = Format(Date.Now, "MM/yyyy")
        'Call LoadDATA()
        '    Call LoadMonth()

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


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        If IsDate(ConvertDate(txtDateStart.Text.Trim)) = False Then
            'MsgBox("¡ÃØ³Ò»éÍ¹ÇÑ¹·ÕèãËé¶Ù¡µéÍ§´éÇÂ", MsgBoxStyle.Information, Me.Text)
            ' MsgManager.ShowDialog(Me, "frmRptAllEmpWorkRS", Me.Text, "Check_Day", MessageBoxIcon.Information)
            'MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
            MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
            txtDateStart.Focus()
            Exit Sub
        End If
        If IsDate(ConvertDate(txtDateStop.Text.Trim)) = False Then
            'MsgBox("¡ÃØ³Ò»éÍ¹ÇÑ¹·ÕèãËé¶Ù¡µéÍ§´éÇÂ", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmRptAllEmpWorkRS", Me.Text, "Check_Day", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
            txtDateStop.Focus()
            Exit Sub
        End If

        If DateDiff(DateInterval.Day, txtDateStart.EditValue, txtDateStop.EditValue) > 31 Then
            '     MsgBox("ช่วงเวลาเกิน 31 วัน กรุณาเลือกใหม่", MsgBoxStyle.Information, Me.Text)
            MsgBox(My.Resources.res_warning_message_spacial.Report_Overtime_31, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If


        Dim divid As String = GetData.GetDivisionId(cboDivision.Text.Trim)
        Dim deptid As String = GetData.GetDepartmentId(cboDepartment.Text.Trim)
        If divid.Trim = "" And
                deptid.Trim = "" And
                txtCode1.Text.Trim = "" And
                txtNameSearch.Text.Trim = "" Then
            '   MsgBox("กรุณาเลือกข้อมูลที่ต้องการค้นหาก่อนออกรายงาน", MsgBoxStyle.Information, Me.Text)
            MsgBox(My.Resources.res_warning_message_spacial.Report_Selectdata, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If



        btnReport.Text = MsgManager.ShowLabel(Me, "rptTimeSheetRS", "Wait")
        btnReport.Enabled = False
        Call GenTimeSheet()
        Call GenTimeSheet_UpdateDayOfWeek()
        btnReport.Text = MsgManager.ShowLabel(Me, "rptTimeSheetRS", "rpt")
        btnReport.Enabled = True

        'ReportPrint = Report.PrintTimeWork
        'Dim Rpt As New frmViewReport
        'Rpt.ShowDialog()

        Call PrintReport()

        'If cValGolbal.Lang = "EN" Then
        '    Call PrintReport_Eng()
        'Else
        '    Call PrintReport()
        'End If

    End Sub

    Private Sub PrintReport()

        Dim strDate As String = ""

        If cValGolbal.Lang = "TH" Then
            strDate = "ประจำวันที่"
        Else
            strDate = "Date"
        End If

        Dim report As New report_EmpTimeWork
        Dim rptformular As String = ""


        report.SqlDataSource1.Connection.ConnectionString = db.getConnString


        rptformular = "1=1"

        If txtCode1.Text <> "" Then  ' ¤é¹ËÒµÒÁÃËÑÊ
            rptformular &= " And [code]='" & txtCode1.Text.Trim & "'"
        ElseIf txtNameSearch.Text <> "" Then  ' ¤é¹ËÒµÒÁª×èÍ
            rptformular &= " And [Fname] Like '%" & txtNameSearch.Text.Trim & "%'"
        Else

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

        End If


        Dim Companyname As String = ""
        Companyname = GetData.GetCompanyName ' 

        report.Parameters("companyname").Value = "" & Companyname & ""
        report.Parameters("headname").Value = Me.Text ' "รายงานตามเวลาเข้าออก"

        If (txtDateStart.EditValue = txtDateStop.EditValue) Then
            report.Parameters("head_f_month").Value = strDate & " : " & txtDateStart.EditValue
        Else
            report.Parameters("head_f_month").Value = strDate & " : " & "" & txtDateStart.EditValue & " - " & txtDateStop.EditValue & ""
        End If

        'Cry.DataDefinition.FormulaFields("DateFrom").Text = "'จากวันที่ : " & txtDateStart.Text.Trim & " ถึง  " & txtDateStop.Text.Trim & "'"

        report.RequestParameters = False
        report.FilterString = rptformular

        Using printTool As New ReportPrintTool(report)
            printTool.AutoShowParametersPanel = False
            '   AddHandler printTool.PrintingSystem.StartPrint, New DevExpress.XtraPrinting.PrintDocumentEventHandler(AddressOf PrintingSystem_StartPrint)

            printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default)
        End Using
    End Sub
    Private Sub PrintReport_Eng()
        Dim report As New report_EmpTimeWork_Eng
        Dim rptformular As String = ""


        report.SqlDataSource1.Connection.ConnectionString = db.getConnString


        rptformular = "1=1"

        If txtCode1.Text <> "" Then  ' ¤é¹ËÒµÒÁÃËÑÊ
            rptformular &= " And [code]='" & txtCode1.Text.Trim & "'"
        ElseIf txtNameSearch.Text <> "" Then  ' ¤é¹ËÒµÒÁª×èÍ
            rptformular &= " And [Fname] Like '%" & txtNameSearch.Text.Trim & "%'"
        Else

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

        End If


        Dim Companyname As String = ""
        Companyname = GetData.GetCompanyName ' 

        report.Parameters("companyname").Value = "" & Companyname & ""
        report.Parameters("headname").Value = Me.Text ' "รายงานตามเวลาเข้าออก"

        Dim date_str As String

        If (txtDateStart.EditValue = txtDateStop.EditValue) Then
            date_str = "Date : " & txtDateStart.EditValue
        Else
            date_str = "Date : " & txtDateStart.Text & " - " & txtDateStop.Text
        End If

        report.Parameters("head_f_month").Value = date_str

        'Cry.DataDefinition.FormulaFields("DateFrom").Text = "'จากวันที่ : " & txtDateStart.Text.Trim & " ถึง  " & txtDateStop.Text.Trim & "'"

        report.RequestParameters = False
        report.FilterString = rptformular

        Using printTool As New ReportPrintTool(report)
            printTool.AutoShowParametersPanel = False
            '   AddHandler printTool.PrintingSystem.StartPrint, New DevExpress.XtraPrinting.PrintDocumentEventHandler(AddressOf PrintingSystem_StartPrint)

            printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default)
        End Using
    End Sub
    Private Sub GenTimeSheet()
        Dim dCmd As New SqlCommand
        Dim strSQL As String

        Dim code As String = ""
        Dim name As String = ""
        Dim divid As String = ""
        Dim deptid As String = ""

        code = txtCode1.Text
        name = txtNameSearch.Text
        divid = GetData.GetDivisionId(cboDivision.Text)
        deptid = GetData.GetDepartmentId(cboDepartment.Text)


        Try
            strSQL = "exec spTimeGenRPT_Timework '" & ConvertDate(txtDateStart.Text.Trim) & "'," &
                                                " '" & ConvertDate(txtDateStop.Text.Trim) & "'," &
                                                " '" & divid & "'," &
                                                " '" & deptid & "'," &
                                                " '" & code & "'," &
                                                " '" & name & "'"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
            Exit Sub
        End Try
    End Sub

    Private Sub GenTimeSheet_UpdateDayOfWeek()
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim db As New db

        Dim code As String = ""
        Dim name As String = ""
        Dim divid As String = ""
        Dim deptid As String = ""

        code = txtCode1.Text
        name = txtNameSearch.Text
        divid = GetData.GetDivisionId(cboDivision.Text)
        deptid = GetData.GetDepartmentId(cboDepartment.Text)


        Try
            strSQL = "update RPT_EmpWork set [DayOfWeek] = '" & My.Resources.res_day.Mon & "'" &
                    " where [DayOfWeek] = 'จ.'"
            db.ExecuteCommand(Conn, dCmd, strSQL)


            strSQL = "update RPT_EmpWork set [DayOfWeek] = '" & My.Resources.res_day.Tue & "'" &
                    " where [DayOfWeek] = 'อ.'"
            db.ExecuteCommand(Conn, dCmd, strSQL)


            strSQL = "update RPT_EmpWork set [DayOfWeek] = '" & My.Resources.res_day.Wed & "'" &
                    " where [DayOfWeek] = 'พ.'"
            db.ExecuteCommand(Conn, dCmd, strSQL)

            strSQL = "update RPT_EmpWork set [DayOfWeek] = '" & My.Resources.res_day.Thu & "'" &
                    " where [DayOfWeek] = 'พฤ.'"
            db.ExecuteCommand(Conn, dCmd, strSQL)

            strSQL = "update RPT_EmpWork set [DayOfWeek] = '" & My.Resources.res_day.Fri & "'" &
                    " where [DayOfWeek] = 'ศ.'"
            db.ExecuteCommand(Conn, dCmd, strSQL)

            strSQL = "update RPT_EmpWork set [DayOfWeek] = '" & My.Resources.res_day.Sat & "'" &
                    " where [DayOfWeek] = 'ส.'"
            db.ExecuteCommand(Conn, dCmd, strSQL)

            strSQL = "update RPT_EmpWork set [DayOfWeek] = '" & My.Resources.res_day.Sun & "'" &
                    " where [DayOfWeek] = 'อา.'"
            db.ExecuteCommand(Conn, dCmd, strSQL)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
            Exit Sub
        End Try
    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
            'cboDepartment.SelectedIndex = 0
            If (cboDepartment.Properties.Items.Count > 0) Then cboDepartment.SelectedIndex = 0

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
            'cboDivision.SelectedIndex = 0
            If (cboDivision.Properties.Items.Count > 0) Then cboDivision.SelectedIndex = 0
        End With
    End Sub


    Private Sub cboCompany_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompany.SelectedIndexChanged
        Call LoadDepartment()
        Call LoadDivision()
    End Sub

    Private Sub txtCode1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode1.GotFocus
        txtNameSearch.Text = ""
    End Sub

    Private Sub txtCode1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtShowName.Text = gdata.GetShowEmpName(txtCode1.Text.Trim)
        End If
    End Sub

    Private Sub txtCode1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode1.LostFocus
        txtShowName.Text = gdata.GetShowEmpName(txtCode1.Text.Trim)
        txtShowName.Focus()
    End Sub

    Private Sub txtCode1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtNameSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNameSearch.GotFocus
        txtCode1.Text = ""
        txtShowName.Text = ""
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

    Private Sub btnAllMonth_Click(sender As Object, e As EventArgs) Handles btnAllMonth.Click
        Call cboMonth_SelectedIndexChanged(Me, EventArgs.Empty)
    End Sub

    Private Sub btnCurrentDate_Click(sender As Object, e As EventArgs) Handles btnCurrentDate.Click
        txtDateStart.EditValue = Now.Date
    End Sub

    Private Sub btnToDate_Click(sender As Object, e As EventArgs) Handles btnToDate.Click
        txtDateStop.EditValue = txtDateStart.EditValue
    End Sub

    Private Sub cboDivision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDivision.SelectedIndexChanged
        Call SearchData.LoadDepartment(Me, cboDepartment, GetData.GetDivisionId(cboDivision.Text.Trim), True)
    End Sub
End Class