Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraReports.UI
Imports TimeAttendance.utils

Public Class frmRptAllEmpWork_Detail
    Dim gData As New GetData
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

        'Call LoadDivision()
        'Call LoadDepartment()
        'Call LoadSection()
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

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        If IsDate(ConvertDate(txtDateStart.Text.Trim)) = False Then
            'MsgBox("¡ÃØ³Ò»éÍ¹ÇÑ¹·ÕèãËé¶Ù¡µéÍ§´éÇÂ", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmRptAllEmpWorkRS", Me.Text, "Check_Day", MessageBoxIcon.Information)
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
            ' MsgBox("ช่วงเวลาเกิน 31 วัน กรุณาเลือกใหม่", MsgBoxStyle.Information, Me.Text)
            MsgBox(My.Resources.res_warning_message_spacial.Report_Overtime_31, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If


        Dim divid As String = GetData.GetDivisionId(cboDivision.Text.Trim)
        Dim deptid As String = GetData.GetDepartmentId(cboDepartment.Text.Trim)
        If divid.Trim = "" And
                deptid.Trim = "" And
                txtCode1.Text.Trim = "" And
                txtNameSearch.Text.Trim = "" Then
            '  MsgBox("กรุณาเลือกข้อมูลที่ต้องการค้นหาก่อนออกรายงาน", MsgBoxStyle.Information, Me.Text)
            MsgBox(My.Resources.res_warning_message_spacial.Report_Selectdata, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        btnReport.Text = MsgManager.ShowLabel(Me, "rptTimeSheetRS", "Wait")
        btnReport.Enabled = False
        Call GenTimeSheet()
        btnReport.Text = MsgManager.ShowLabel(Me, "rptTimeSheetRS", "rpt")
        btnReport.Enabled = True

        'MsgBox("OK")

        'ReportPrint = Report.PrintTimeWork_Detail
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


        Dim rptformular As String = ""

        Dim report As New report_EmpTimeWork_detail
        Dim subReport As New subreport_VacationRemark

        report.SqlDataSource1.Connection.ConnectionString = db.getConnString
        subReport.SqlDataSource1.Connection.ConnectionString = db.getConnString

        '   report.Parameters("Headname").Value = "รายงานเวลาทำงานของพนักงาน(แบบละเอียด)"

        '  report.RequestParameters = False

        rptformular = "1 =1"

        If txtCode1.Text <> "" Then  ' ¤é¹ËÒµÒÁÃËÑÊ
            '  rptformular &= " And {Emp.Code}='" & txtCode1.Text.Trim & "'"
            rptformular &= "  And [Code] ='" & txtCode1.Text.Trim & "'"
        ElseIf txtNameSearch.Text <> "" Then  ' ¤é¹ËÒµÒÁª×èÍ
            ' rptformular &= " And {Emp.fname} like '*" & txtNameSearch.Text.Trim & "*'"
            rptformular &= " And [Fname] Like '%" & txtNameSearch.Text.Trim & "%'"
        Else

            If cboCompany.SelectedIndex > 0 Then ' ¶éÒäÁèàÅ×Í¡ºÃÔÉÑ··Ñé§ËÁ´
                Dim Company_Id As String
                Company_Id = GetData.GetCompanyId(cboCompany.Text) ' ËÒ ÃËÑÊ Id ¢Í§ Company_Sub
                rptformular &= " And [CompanyID] = '" & Company_Id.Trim & "'"
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

        End If



        Dim Companyname As String = ""
        Companyname = GetData.GetCompanyName ' 

        report.Parameters("companyname").Value = "" & Companyname & ""
        report.Parameters("headname").Value = Me.Text  ' "รายงานเวลาทำงานของพนักงาน(แบบละเอียด)"

        If txtDateStart.EditValue = txtDateStop.EditValue Then
            report.Parameters("headDate").Value = strDate & " : " & cDateTime.showDate(txtDateStart.EditValue)
        Else
            report.Parameters("headDate").Value = strDate & " : " & cDateTime.showDate(txtDateStart.EditValue) & " - " & cDateTime.showDate(txtDateStop.EditValue)
        End If


        report.RequestParameters = False

        report.FilterString = rptformular

        report.XrSubreport1.ReportSource = subReport

        Using printTool As New ReportPrintTool(report)

            printTool.AutoShowParametersPanel = False
            '     AddHandler printTool.PrintingSystem.StartPrint, New DevExpress.XtraPrinting.PrintDocumentEventHandler(AddressOf PrintingSystem_StartPrint)

            printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default)
        End Using '
    End Sub
    Private Sub printreport_Eng()
        Dim rptformular As String = ""

        Dim report As New report_EmpTimeWork_detail_Eng
        report.SqlDataSource1.Connection.ConnectionString = db.getConnString

        '   report.Parameters("Headname").Value = "รายงานเวลาทำงานของพนักงาน(แบบละเอียด)"

        '  report.RequestParameters = False

        rptformular = "1 =1"

        If txtCode1.Text <> "" Then  ' ¤é¹ËÒµÒÁÃËÑÊ
            '  rptformular &= " And {Emp.Code}='" & txtCode1.Text.Trim & "'"
            rptformular &= "  And [Code] ='" & txtCode1.Text.Trim & "'"
        ElseIf txtNameSearch.Text <> "" Then  ' ¤é¹ËÒµÒÁª×èÍ
            ' rptformular &= " And {Emp.fname} like '*" & txtNameSearch.Text.Trim & "*'"
            rptformular &= " And [Fname] Like '%" & txtNameSearch.Text.Trim & "%'"
        Else

            If cboCompany.SelectedIndex > 0 Then ' ¶éÒäÁèàÅ×Í¡ºÃÔÉÑ··Ñé§ËÁ´
                Dim Company_Id As String
                Company_Id = GetData.GetCompanyId(cboCompany.Text) ' ËÒ ÃËÑÊ Id ¢Í§ Company_Sub
                rptformular &= " And [CompanyID] = '" & Company_Id.Trim & "'"
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

        End If



        Dim Companyname As String = ""
        Companyname = GetData.GetCompanyName ' 

        report.Parameters("companyname").Value = "" & Companyname & ""
        report.Parameters("headname").Value = Me.Text ' "รายงานเวลาทำงานของพนักงาน(แบบละเอียด)"

        If txtDateStart.EditValue = txtDateStop.EditValue Then
            report.Parameters("headDate").Value = "Date : " & cDateTime.showDate(txtDateStart.EditValue)
        Else
            report.Parameters("headDate").Value = "Date : " & cDateTime.showDate(txtDateStart.EditValue) & " - " & cDateTime.showDate(txtDateStop.EditValue)
        End If


        report.RequestParameters = False

        report.FilterString = rptformular

        Using printTool As New ReportPrintTool(report)

            printTool.AutoShowParametersPanel = False
            '     AddHandler printTool.PrintingSystem.StartPrint, New DevExpress.XtraPrinting.PrintDocumentEventHandler(AddressOf PrintingSystem_StartPrint)

            printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default)
        End Using '
    End Sub

    Private Sub GenTimeSheet()
        Dim dCmd As New SqlCommand

        Dim DateST As Date = txtDateStart.EditValue
        Dim DateSP As Date = txtDateStop.EditValue

        'Try
        Call ClearData(dCmd)

        Dim dRun As Date = DateST
        ' only emp is not come in this day.
        'Dim DT As DataTable = GetDTEmp(dCmd, Format(DateST, "yyyy/MM/dd"), Format(DateSP, "yyyy/MM/dd"))
        'GetDTEmp(dCmd, Format(DateST, "yyyy/MM/dd"), Format(DateSP, "yyyy/MM/dd"))

        PbOverall.Value = 0
        PbOverall.Maximum = (DateDiff(DateInterval.Day, DateST, DateSP)) + 1

        PbOverall.Visible = True
        PB_Emp.Visible = True

        Dim I As Integer = 0
        Do Until dRun > DateSP
            'lblStatus1.Text = "ÇÑ¹·Õè " & Format(dRun, "dd/MM/yyyy")
            'PbOverall.Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "Date2") & Format(dRun, "dd/MM/yyyy")
            'Application.DoEvents()

            Dim DT As DataTable = GetDTEmp(dCmd, Format(dRun, "yyyy/MM/dd"))
            I = 0
            PB_Emp.Value = 0
            PB_Emp.Maximum = DT.Rows.Count
            For Each dr As DataRow In DT.Rows
                I += 1
                PB_Emp.Value = I
                'lblStatus2.Text = " ¾¹Ñ¡§Ò¹ : " & I & "/" & DT.Rows.Count
                'PB_Emp.Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "emp") & I & "/" & DT.Rows.Count

                Application.DoEvents()

                'If DateInIsExist(dCmd, Format(dRun, "yyyy/MM/dd"), dr("Code")) = False Then
                Call InsertBlankDay(dCmd, Format(dRun, "yyyy/MM/dd"), dr("Code"))
                'End If
            Next

            Call InsertData(dCmd, Format(dRun, "yyyy/MM/dd"), "")

            dRun = dRun.AddDays(1)
            PbOverall.Value += 1

            'Application.DoEvents()
        Loop
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        '    Exit Sub
        'End Try


        PbOverall.Visible = True
        PB_Emp.Visible = True
    End Sub

    Function GetDTEmp(ByVal dCmd As SqlCommand, ByVal DateST As String) As DataTable
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

        'Dim newID As String = GetData.getNewID()

        'strSQL = "Insert into rpt_emp_getreport(id,code) " &
        '         " select '" & newID & "',Code From (select Code from Emp " &
        '                            " Where WorkStatus = 'W' " &
        '                            " Group By Code" &
        '                            " Union " &
        '                            " Select Code From TimeWork" &
        '                            " Where Convert(nVarchar(10),DateIn,111) Between '" & DateST.Trim & "' and '" & DateSP.Trim & "'" &
        '                            " Group By Code) as Emp " &
        '        " Where Code In (Select Code From Emp " &
        '                        " Where 1=1"

        'strSQL = "select Code From (select Code from Emp " &
        '                            " Where WorkStatus = 'W' " &
        '                            " Group By Code" &
        '                            " Union " &
        '                            " Select Code From TimeWork" &
        '                            " Where Convert(nVarchar(10),DateIn,111) Between '" & DateST.Trim & "' and '" & DateSP.Trim & "'" &
        '                            " Group By Code) as Emp " &
        '        " Where Code In (Select Code " &
        '                        " From Emp left join department " &
        '                                " on emp.deptid = department.deptid " &
        '                              " left join division div " &
        '                                " on department.divid = div.divid " &
        '                        " Where 1=1"

        strSQL = "select emp.Code " &
                " from Emp " &
                    " left join timework tw " &
                        " on emp.code = tw.code " &
                            " and convert(nvarchar(10),tw.datein,111) = '" & DateST & "'" &
                    " left join department " &
                        " on emp.deptid = department.deptid " &
                " where emp.workstatus = 'W' and tw.code is null"


        '                    " Where WorkStatus = 'W' " &
        '                    " Group By Code" &
        '                    " Union " &
        '                    " Select Code From TimeWork" &
        '                    " Where Convert(nVarchar(10),DateIn,111) Between '" & DateST.Trim & "' and '" & DateSP.Trim & "'" &
        '                    " Group By Code) as Emp " &
        '" Where Code In (Select Code " &
        '                " From Emp left join department " &
        '                        " on emp.deptid = department.deptid " &
        '                      " left join division div " &
        '                        " on department.divid = div.divid " &
        '                " Where 1=1"

        If txtCode1.Text <> "" Then   ' ¤é¹ËÒà©¾ÒÐÃËÑÊ¾¹Ñ¡§Ò¹
            strSQL &= " And Emp.Code='" & txtCode1.Text.Trim & "'"
        ElseIf txtNameSearch.Text <> "" Then  ' ¤é¹ËÒà©¾ÒÐª×èÍ
            strSQL &= " And Emp.Fname like '%" & txtNameSearch.Text.Trim & "%'"
        Else

            If Division_Id <> "" Then  ' ½èÒÂ
                strSQL &= " and Department.DivId = '" & Division_Id.Trim & "'"
            End If
            If Department_Id.Trim <> "" Then '  á¼¹¡
                strSQL &= " and Emp.DeptId = '" & Department_Id.Trim & "'"
            End If

        End If

        'strSQL &= ")"

        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()
        DA.SelectCommand = dCmd
        DA.Fill(Ds, "data")
        Return Ds.Tables("data")
    End Function

    Private Sub ClearData(ByVal dCmd As SqlCommand)
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet

        strSQL = "Delete From RPT_EmpWork"
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()
    End Sub

    Function DateInIsExist(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String) As Boolean
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet

        strSQL = "Select Code From TimeWork " & _
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

    Private Sub InsertBlankDay(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String)
        Dim strSQL As String
        Dim DayOfWeek As Integer = CDate(DateIn).DayOfWeek
        Dim strDayOfWeek As String = ""

        Select Case DayOfWeek
            Case 0 '"ÍÒ"
                strDayOfWeek = My.Resources.res_day.Sun
            Case 1 '"¨."
                strDayOfWeek = My.Resources.res_day.Mon
            Case 2 '"Í."
                strDayOfWeek = My.Resources.res_day.Tue
            Case 3 '"¾."
                strDayOfWeek = My.Resources.res_day.Wed
            Case 4 '"¾Ä."
                strDayOfWeek = My.Resources.res_day.Thu
            Case 5 '"È."
                strDayOfWeek = My.Resources.res_day.Fri
            Case 6 '"Ê."
                strDayOfWeek = My.Resources.res_day.Sat
            Case Else
                strDayOfWeek = ""
        End Select

        Dim KaCode As String = GetKa(Code.Trim, DateIn.Trim).Trim

        Dim Holiday As String = GetHoliday(dCmd, DateIn)
        Dim fixedWork As Boolean = GetFixedWork(dCmd, DateIn)
        Dim valcation As String = GetVacationName(dCmd, DateIn.Trim, Code.Trim).Trim
        Dim VacationName As String = ""
        Dim valCode As String = ""

        If valcation.Trim <> "" Then
            Dim val() As String = valcation.Split(",")
            valCode = val(0)
            VacationName = val(1)
        End If

        If fixedWork = True Then
            Holiday = ""
        Else
            If Holiday = "" Then
                If GetEndofWeek(dCmd, DayOfWeek, KaCode) = False Then
                    'If VacationName.Trim <> "" Then
                    '    Holiday = VacationName
                    'Else
                    '    If KaCode.Trim = "" Then   ' àªç¤¡Ã³ÕäÁèä´é¡ÓË¹´ ¡Ð¡ÒÃ·Ó§Ò¹
                    '        Holiday = My.Resources.res_simple_label.noShift
                    '    Else
                    '        Holiday = My.Resources.res_simple_label.Holiday
                    '    End If
                    'End If
                    'End If
                    If KaCode.Trim = "" Then   ' àªç¤¡Ã³ÕäÁèä´é¡ÓË¹´ ¡Ð¡ÒÃ·Ó§Ò¹
                        Holiday = My.Resources.res_simple_label.noShift
                    Else
                        Holiday = My.Resources.res_simple_label.Holiday
                    End If
                End If
            End If
        End If


        strSQL = "Insert Into RPT_EmpWork(Code,KaCode,DateIn,DayOfWeek," &
                        " Time1,Time2,Time3,Time4,Time5,Time6,Time7,Time8,Time9,Time10," &
                        " DayDo,OT1,OT15,OT2,OT3," &
                        " Val,ValPay,Absent,Late,LateOt,CardForGet,Early,WorkTime,LateTotal,Holiday,valCode,Vacation) " &
                    "select" &
                                " Emp.code" &
                                " ,'" & KaCode.Trim & "'" &
                                " ,'" & DateIn.Trim & "'" &
                                " ,'" & strDayOfWeek & "'" &
                                " ,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null" &
                                " ,0,0,0,0,0" &
                                " ,isnull(val.amt,0),0," & GetAbsent(dCmd, DateIn, Code) & ",0,0,0,0,0,0" &
                                " ,'" & Holiday & "'" &
                                " ,'" & valCode & "'" &
                                " ,'" & VacationName & "'" &
                    " From emp" &
                            " left join TimeVacation val" &
                                " On emp.code = val.code And" &
                                   " convert(nvarchar(10),val.ValDate,111) =  '" & DateIn & "'" &
                    " where emp.code = '" & Code & "'"
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()

        'strSQL = "Insert Into RPT_EmpWork(Code,KaCode,DateIn,DayOfWeek," & _
        '                " Time1,Time2,Time3,Time4,Time5,Time6,Time7,Time8,Time9,Time10," & _
        '                " DayDo,OT1,OT15,OT2,OT3," & _
        '                " Val,ValPay,Absent,Late,LateOt,CardForGet,Early,WorkTime,LateTotal,Holiday) " & _
        '                " Values(" & _
        '                " '" & Code.Trim & "'," & _
        '                " '" & KaCode.Trim & "'," & _
        '                " '" & DateIn.Trim & "'," & _
        '                " '" & strDayOfWeek & "'," & _
        '                " Null,Null,Null,Null,Null,Null,Null,Null,Null,Null," & _
        '                " 0,0,0,0,0," & _
        '                " 0,0," & GetAbsent(dCmd, DateIn, Code) & ",0,0,0,0,0,0," & _
        '                " '" & Holiday & "')"
        'dCmd.Connection = Conn
        'dCmd.CommandText = strSQL
        'dCmd.ExecuteNonQuery()
    End Sub

    Private Sub InsertData(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String)
        Dim strSQL As String
        Dim db As New db

        Dim strType As String = ""
        Dim Data As New ArrayList

        Dim Time As Date
        Dim DayOfWeek As Integer = CDate(DateIn).DayOfWeek
        Dim strDayOfWeek As String = ""


        strSQL = " Insert Into RPT_EmpWork(Code,KaCode,DateIn,DayOfWeek," & vbCrLf &
                                        " Time1,Time2,Time3,Time4," & vbCrLf &
                                        " DayDo,OT1,OT15,OT3," & vbCrLf &
                                        " Val,Absent,Late,LateOt,WorkTime,Holiday,valCode,Vacation) " & vbCrLf &
                 " select tw.code,tw.KaCode,tw.datein," & vbCrLf &
                                            " dOfW_str = case datepart(dw,ka_date)" &
                                                                 " when 1 then '" & My.Resources.res_day.Sun & "'" & vbCrLf &
                                                                 " when 2 then '" & My.Resources.res_day.Mon & "'" & vbCrLf &
                                                                 " when 3 then '" & My.Resources.res_day.Thu & "'" & vbCrLf &
                                                                 " when 4 then '" & My.Resources.res_day.Wed & "'" & vbCrLf &
                                                                 " when 5 then '" & My.Resources.res_day.Thu & "'" & vbCrLf &
                                                                 " when 6 then '" & My.Resources.res_day.Fri & "'" & vbCrLf &
                                                                 " when 7 then '" & My.Resources.res_day.Sat & "'" & vbCrLf &
                                                                 " Else '' End" & vbCrLf &
                                            " ,tw.time1,tw.time2,tw.time3,tw.Time4,1 as daydo" & vbCrLf &
                                            " ,ot1 =  isnull(ot.OT_Time,0)" & vbCrLf &
                                            " ,ot15 =  isnull(case when isnull(ot.wkend,0) = 0 and isnull(ot.hol,0) = 0 then ot.OT_OverTime else 0 end,0)" & vbCrLf &
                                            " ,ot3 =  isnull(case when isnull(ot.wkend,0) = 1 or isnull(ot.hol,0) = 1 then ot.OT_OverTime else 0 end,0)" & vbCrLf &
                                            " ,val = isnull(val.Amt,0)" & vbCrLf &
                                            " ,absent =  isnull(case when abs(tabs.Absent) = 8 then 1 else 0 end,0)" & vbCrLf &
                                            " ,late = isnull(late.Late,0)" & vbCrLf &
                                            " ,LateOut = isnull(late.lateout,0)" & vbCrLf &
                                            " ,worktime = tw.work_hour_full" & vbCrLf &
                                            " ,holiday = case when ot.WKEnd = 1 or ot.Hol = 1 and isnull(hy.Description,'') = '' then '" & My.Resources.res_simple_label.Hol & "'" & vbCrLf &
                                                            " else isnull(hy.Description,'') end" & vbCrLf &
                                            " ,ValCode = isnull(val.ValId,'')" & vbCrLf &
                                            " ,Vacation = isnull(v.Description,'')" & vbCrLf &
                                        " from timework tw" & vbCrLf &
                                                " left join TimeOvertime ot" & vbCrLf &
                                                    " On tw.code = ot.code And" & vbCrLf &
                                                        " tw.DateIn = ot.DateIn" & vbCrLf &
                                                " left join TimeVacation val" & vbCrLf &
                                                    " On tw.code = val.code And" & vbCrLf &
                                                        " tw.DateIn = val.ValDate" & vbCrLf &
                                                " left join TimeWorkingStatus v" & vbCrLf &
                                                    " on val.valId = v.code" & vbCrLf &
                                                " left join TimeAbsent tabs" & vbCrLf &
                                                    " On tw.code = tabs.code And" & vbCrLf &
                                                        " tw.datein = tabs.DateIn" & vbCrLf &
                                                " left join TimeLate late" & vbCrLf &
                                                    " On tw.code = late.code And" & vbCrLf &
                                                        " tw.datein = late.DateIn" & vbCrLf &
                                                " left join TimeHolidayYear hy" & vbCrLf &
                                                    " On tw.DateIn = hy.Date" & vbCrLf &
                " where convert(nvarchar(10),tw.datein,111) = '" & DateIn & "'"
        db.ExecuteCommand(Conn, dCmd, strSQL)
    End Sub

    Function GetKa(ByVal Code As String, ByVal strDate As String) As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select KaCode = Isnull(dbo.fGetKaCode_Edit('" & Code.Trim & "','" & strDate.Trim & "'),'')"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("KaCode")
            End If
        End With
    End Function

    Function GetTime(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String, ByVal No As Integer) As Date
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet

        strSQL = "Select Time" & No & " From TimeWork " & _
                " Where Convert(nVarchar(10),DateIn,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "'"
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return Nothing
            Else
                If IsDBNull(.Rows(0).Item(0)) = True Then
                    Return Nothing
                Else
                    Return .Rows(0).Item(0)
                End If
            End If
        End With
    End Function

    Function GetDayDo(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String) As Single
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db

        'strSQL = "select Absent= Isnull(Absent,0) from TimeAbsent " & _
        '        " Where Convert(nVarchar(10),DateIn,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "'"

        strSQL = "select DayDo = isnull(dbo.fDayDo('',0,'" & Code.Trim & "','" & DateIn.Trim & "','" & DateIn.Trim & "'),0)"

        db.ExecuteCommand(Conn, dCmd, strSQL)

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                If DateInIsExist(dCmd, DateIn, Code) = True Then
                    Return 8
                Else
                    Return 0
                End If
            Else
                If IsDBNull(.Rows(0).Item(0)) = True Then
                    If DateInIsExist(dCmd, DateIn, Code) = True Then
                        Return 8
                    Else
                        Return 0
                    End If
                Else
                    Return .Rows(0).Item("DayDo")
                    'Return 8 - Math.Abs(.Rows(0).Item(0))
                End If
            End If
        End With
    End Function

    Function GetOT(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String, ByVal OT As Single) As Single
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db

        'strSQL = "select OT1 = isnull(OT1,0)," & _
        '                " OT15 = isnull(OT15,0)," & _
        '                " OT2 = isnull(OT2,0)," & _
        '                " OT3 = isnull(OT3,0) " & _
        '        " from TimeOvertime " & _
        '        " Where Convert(nVarchar(10),DateIn,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "'"

        strSQL = "select OT = isnull(OT_Overtime,0) " & _
                " from TimeOvertime " & _
                " Where Convert(nVarchar(10),DateIn,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "'" & _
                        " and Ot_Overtime_Rate  = " & OT & ""

        db.ExecuteCommand(Conn, dCmd, strSQL)

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Return .Rows(0).Item("OT")
            End If
        End With
    End Function

    Function GetOT_Day(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String, ByVal OT As Single) As Single
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db

        'strSQL = "select OT1 = isnull(OT1,0)," & _
        '                " OT15 = isnull(OT15,0)," & _
        '                " OT2 = isnull(OT2,0)," & _
        '                " OT3 = isnull(OT3,0) " & _
        '        " from TimeOvertime " & _
        '        " Where Convert(nVarchar(10),DateIn,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "'"

        strSQL = "select OT = isnull(OT_time,0) " & _
                " from TimeOvertime " & _
                " Where Convert(nVarchar(10),DateIn,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "'" & _
                        " and Ot_time_Rate  = " & OT & ""

        db.ExecuteCommand(Conn, dCmd, strSQL)

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Return .Rows(0).Item("OT")
            End If
        End With
    End Function

    Function GetVacationPay(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String, ByVal Pay As Boolean) As Single
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db

        strSQL = "select Amt = Isnull(v.Amt,0) " & _
                " from TimeVacation v Left Join TimeWorkingStatus w " & _
                        " on v.ValId = w.Code " & _
                " Where Convert(nVarchar(10),v.ValDate,111) = '" & DateIn.Trim & "' " & _
                        " and v.Code = '" & Code.Trim & "' and w.Pay = 1"
        db.ExecuteCommand(Conn, dCmd, strSQL)

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                If Pay = False Then
                    Return .Rows(0).Item("Amt")
                Else
                    Return .Rows(0).Item("Amt")
                End If
            End If
        End With
    End Function

    Function GetVacationNotPay(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String, ByVal Pay As Boolean) As Single
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db

        strSQL = "select Amt = Isnull(v.Amt,0) " & _
                " from TimeVacation v Left Join TimeWorkingStatus w " & _
                        " on v.ValId = w.Code " & _
                " Where Convert(nVarchar(10),v.ValDate,111) = '" & DateIn.Trim & "' " & _
                        " and v.Code = '" & Code.Trim & "' and w.Pay = 0"
        db.ExecuteCommand(Conn, dCmd, strSQL)

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                If Pay = False Then
                    Return .Rows(0).Item("Amt")
                Else
                    Return .Rows(0).Item("Amt")
                End If
            End If
        End With
    End Function

    Function GetAbsent(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String) As Single
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db

        strSQL = "select Absent from TimeAbsent " & _
                " Where Abs(Absent) = 8 and Convert(nVarchar(10),DateIn,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "'"
        db.ExecuteCommand(Conn, dCmd, strSQL)

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Return 1
            End If
        End With
    End Function

    Function GetLate(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String) As Single
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db

        strSQL = "select Late = Isnull(Late,0) from TimeLate " & _
                " Where Convert(nVarchar(10),DateIn,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "'"
        db.ExecuteCommand(Conn, dCmd, strSQL)

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Return .Rows(0).Item("Late")
            End If
        End With
    End Function

    Function GetTimeWork(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String) As String
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db

        'strSQL = "select DayDoHour = isnull(dbo.fGetDayDo_Hour(Code,Convert(nVarchar(10),DateIn,111)) from TimeWork " & _
        '        " Where Convert(nVarchar(10),DateIn,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "'"

        strSQL = "Exec spGetDayDo_Hour '" & Code.Trim & "','" & DateIn.Trim & "'"
        db.ExecuteCommand(Conn, dCmd, strSQL)
        Da.SelectCommand = dCmd

        Da.Fill(Ds, "data")
        With Ds.Tables("data")

            Dim Time As Single = 0
            Dim T As Single = 0
            If .Rows.Count = 0 Then
                Return "0"
            Else
                Dim dr As DataRow = .Rows(0)
                Return dr("DayDo")
            End If
        End With
    End Function

    Function GetCardForget(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String) As Integer
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet

        strSQL = "Select Code From TimeWork " & _
                " Where Convert(nVarchar(10),DateIn,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "' and " & _
                        " (TimeE1 = 0 and " & _
                        " TimeE2 = 0 and " & _
                        " TimeE3 = 0 and " & _
                        " TimeE4 = 0 and " & _
                        " TimeE5 = 0 and " & _
                        " TimeE6 = 0 and " & _
                        " TimeE7 = 0 and " & _
                        " TimeE8 = 0 and " & _
                        " TimeE9 = 0 and " & _
                        " TimeE10 = 0 and " & _
                        " TimeE11 = 0 and " & _
                        " TimeE12 = 0) "
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 1
            Else
                Return 0
            End If
        End With
    End Function

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub cboDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Private Sub LoadDivision()
    '    Dim strSQL As String
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim db As New db
    '    Dim dCmd As New SqlCommand

    '    strSQL = "Select * From Division Order By DivId"
    '    db.ExecuteCommand(Conn, dCmd, strSQL)

    '    Da.SelectCommand = dCmd
    '    Da.Fill(Ds, "data")
    '    With Ds.Tables("data")
    '        cboDivision1.Items.Clear()
    '        cboDivision1.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
    '        For Each dr As DataRow In .Rows
    '            cboDivision1.Items.Add(dr("Division"))
    '        Next
    '    End With
    'End Sub

    Function GetDivId(ByVal Division As String) As String
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db
        Dim dCmd As New SqlCommand

        strSQL = "Select DivId From Division " & _
                " Where Division = '" & Division.Trim & "'"
        db.ExecuteCommand(Conn, dCmd, strSQL)

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("DivId")
            End If
        End With
    End Function


    'Private Sub LoadDepartment()
    '    Dim strSQL As String
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim db As New db
    '    Dim dCmd As New SqlCommand

    '    strSQL = "Select * From Department Order By DeptId"
    '    db.ExecuteCommand(Conn, dCmd, strSQL)

    '    Da.SelectCommand = dCmd
    '    Da.Fill(Ds, "data")
    '    With Ds.Tables("data")
    '        cboDepartment1.Items.Clear()
    '        cboDepartment1.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
    '        For Each dr As DataRow In .Rows
    '            cboDepartment1.Items.Add(dr("Department"))
    '        Next
    '    End With
    'End Sub

    Function GetDeptId(ByVal Department As String) As String
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db
        Dim dCmd As New SqlCommand

        strSQL = "Select DeptId From Department " & _
                " Where Department = '" & Department.Trim & "'"
        db.ExecuteCommand(Conn, dCmd, strSQL)

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("DeptId")
            End If
        End With
    End Function

    'Private Sub LoadSection()
    '    Dim strSQL As String
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim db As New db
    '    Dim dCmd As New SqlCommand

    '    strSQL = "Select * From Section Order By SecId"
    '    db.ExecuteCommand(Conn, dCmd, strSQL)

    '    Da.SelectCommand = dCmd
    '    Da.Fill(Ds, "data")
    '    With Ds.Tables("data")
    '        cboSection.Items.Clear()
    '        cboSection.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
    '        For Each dr As DataRow In .Rows
    '            cboSection.Items.Add(dr("Section"))
    '        Next
    '    End With
    'End Sub

    Function GetSecId(ByVal Section As String) As String
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db
        Dim dCmd As New SqlCommand

        strSQL = "Select SecId From Section " & _
                " Where Section = '" & Section.Trim & "'"
        db.ExecuteCommand(Conn, dCmd, strSQL)

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("SecId")
            End If
        End With
    End Function

    Private Sub txtDateStop_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Function GetHoliday(ByVal dCmd As SqlCommand, ByVal DateIn As String) As String
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet

        strSQL = "select Description from TimeHolidayYear " &
                  " Where Convert(nVarchar(10),Date,111) = '" & DateIn.Trim & "' "
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                If IsDBNull(.Rows(0).Item(0)) = True Then
                    Return ""
                Else
                    Return .Rows(0).Item(0)
                End If
            End If
        End With
    End Function

    Function GetFixedWork(ByVal dCmd As SqlCommand, ByVal DateIn As String) As Boolean
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet

        strSQL = "select DateTimeWork from TimeWork_Spa_Config " &
                  " Where Convert(nVarchar(10),DateTimeWork,111) = '" & DateIn.Trim & "' "
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
                'If IsDBNull(.Rows(0).Item(0)) = True Then
                '    Return ""
                'Else
                '    Return .Rows(0).Item(0)
                'End If
            End If
        End With
    End Function

    Function GetVacationName(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String) As String
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db

        strSQL = "select v.ValId, Description = Isnull(w.Description,'') " &
                " from TimeVacation v Left Join TimeWorkingStatus w " &
                        " on v.ValId = w.Code " &
                " Where Convert(nVarchar(10),v.ValDate,111) = '" & DateIn.Trim & "' " &
                        " and v.Code = '" & Code.Trim & "'"
        db.ExecuteCommand(Conn, dCmd, strSQL)

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("ValId") & "," & .Rows(0).Item("Description")
            End If
        End With
    End Function

    Function GetEndofWeek(ByVal dCmd As SqlCommand, ByVal DayofWeek As String, ByVal KaCode As String) As Boolean
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = "Select Day = "

        Select Case DayofWeek.Trim
            Case "0"
                strSQL &= "Sunday"
            Case "1"
                strSQL &= "Monday"
            Case "2"
                strSQL &= "Tuesday"
            Case "3"
                strSQL &= "Wednesday"
            Case "4"
                strSQL &= "Thursday"
            Case "5"
                strSQL &= "Friday"
            Case "6"
                strSQL &= "Saturday"
            Case Else
                Return False
        End Select
        strSQL &= " from timeka " & _
                  " Where ka_code='" & KaCode.Trim & "'"
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()
        Da.SelectCommand = dCmd

        Da.Fill(Ds, "DATA")
        With Ds.Tables("DATA")
            If .Rows.Count = 0 Then
                Return False
            Else
                Dim dr As DataRow = .Rows(0)
                If dr("day") = True Then
                    Return True
                Else
                    Return False
                End If
            End If
        End With
    End Function

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

        Strsql = "select DivId,Division" &
            " from DiviSion "

        If cboCompany.SelectedIndex > 0 Then
            Strsql &= " Where DivId In (Select DivId From Emp " &
                                    " Where WorkStatus  = 'W' and " &
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

    Private Sub txtCode1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'txtNameSearch.Text = ""
    End Sub

    Private Sub txtNameSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'txtCode1.Text = ""
    End Sub

    Private Sub txtNameSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtCode1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtName.Text = gData.GetShowEmpName(txtCode1.Text.Trim)
        End If
    End Sub

    Private Sub txtCode1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode1.LostFocus
        txtName.Text = gData.GetShowEmpName(txtCode1.Text.Trim)
    End Sub

    Private Sub btnAllMonth_Click(sender As Object, e As EventArgs) Handles btnAllMonth.Click
        Call cboMonth_SelectedIndexChanged(Me, EventArgs.Empty)
    End Sub

    Private Sub btnToDate_Click(sender As Object, e As EventArgs) Handles btnToDate.Click
        txtDateStop.EditValue = txtDateStart.EditValue
    End Sub

    Private Sub txtCode1_EditValueChanged(sender As Object, e As EventArgs) Handles txtCode1.EditValueChanged

    End Sub

    Private Sub cboDivision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDivision.SelectedIndexChanged
        Call SearchData.LoadDepartment(Me, cboDepartment, GetData.GetDivisionId(cboDivision.Text.Trim), True)
    End Sub
End Class








