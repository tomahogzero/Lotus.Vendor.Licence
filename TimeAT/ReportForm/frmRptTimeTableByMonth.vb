Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraReports.UI
Imports TimeAttendance.utils

Public Class frmRptTimeTableByMonth
    Dim gdata As New GetData
    Dim db As New DBManager
    Private Sub frmRptTimeTableByMonth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '   Call LoadMonth()
        Call SearchData.LoadMonth(cboMonth, False, True)
        txtYear.Text = Date.Now.Year
        '  cboMonth.SelectedIndex = Date.Now.Month - 1

        txtDateSt.EditValue = Now.Date
        txtDateSp.EditValue = Now.Date

        Call SearchData.LoadDivision(Me, cboDivision, True)
        Call SearchData.LoadDepartment(Me, cboDepartment, "", True)

        '  Call SearchData.LoadEmpGroup(Me, cboEmpGroup, False)
        Call SearchData.LoadBroker(Me, cboBroker, False)
    End Sub

    Private Sub LoadMonth()
        Dim I As Integer
        cboMonth.Properties.Items.Clear()
        For I = 1 To 12
            cboMonth.Properties.Items.Add(MonthName(Me, I))
        Next
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMonth.SelectedIndexChanged
        If IsNumeric(txtYear.Text.Trim) = False Then Exit Sub
        Dim newMonth As String
        Dim newYear As String

        newMonth = Format(cboMonth.SelectedIndex + 1, "00")
        newYear = txtYear.Text.Trim

        Dim ar As New ArrayList
        ar = GetDayMonth(newMonth, newYear)
        txtDateSt.EditValue = CDate(ar.Item(0))
        txtDateSp.EditValue = CDate(ar.Item(1))
    End Sub



    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        If IsDate(ConvertDate(txtDateSt.Text.Trim)) = False Then
            'MsgBox("¡ÃØ³Ò»éÍ¹ÇÑ¹·ÕèãËé¶Ù¡µéÍ§´éÇÂ", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmRptAllEmpWorkRS", Me.Text, "Check_Day", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If
        If IsDate(ConvertDate(txtDateSp.Text.Trim)) = False Then
            'MsgBox("¡ÃØ³Ò»éÍ¹ÇÑ¹·ÕèãËé¶Ù¡µéÍ§´éÇÂ", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmRptAllEmpWorkRS", Me.Text, "Check_Day", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        If DateDiff(DateInterval.Day, txtDateSt.EditValue, txtDateSp.EditValue) > 31 Then
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
            '   MsgBox("กรุณาเลือกข้อมูลที่ต้องการค้นหาก่อนออกรายงาน", MsgBoxStyle.Information, Me.Text)
            MsgBox(My.Resources.res_warning_message_spacial.Report_Selectdata, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If


        btnReport.Enabled = False
        Call GenTimeTableStdStatus(cDateTime.dbDate(txtDateSt.EditValue), cDateTime.dbDate(txtDateSp.EditValue))

        Call PrintReport()

        'If cValGolbal.Lang = "EN" Then
        '    Call PrintReport_Eng()
        'Else
        '    Call PrintReport()
        'End If



        btnReport.Enabled = True

        'ReportPrint = Report.PrintTimeTableByMonth
        'Dim Rpt As New frmViewReport
        'Rpt.ShowDialog()
    End Sub

    Private Sub PrintReport()

        Dim strDate As String = ""

        If cValGolbal.Lang = "TH" Then
            strDate = "ประจำวันที่"
        Else
            strDate = "Date"
        End If

        Dim report As New report_TimeTableByMonth
        Dim rptformular As String = ""


        report.SqlDataSource1.Connection.ConnectionString = db.getConnString

        rptformular = 1 = "1"

        If txtCode1.Text <> "" Then  ' ¤é¹ËÒµÒÁÃËÑÊ

            rptformular &= " And [Code]='" & txtCode1.Text.Trim & "'"
        ElseIf txtNameSearch.Text <> "" Then  ' ¤é¹ËÒµÒÁª×èÍ
            rptformular &= " And [fname] Like '%" & txtNameSearch.Text.Trim & "%'"
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
        report.Parameters("headname").Value = Me.Text ' "รายงานตามวันทำงาน"
        '   report.Parameters("cCheckDate").Value = "" & strDt & ""
        report.Parameters("Head_f_month").Value = strDate & " : " & "" & cDateTime.showDate(txtDateSt.EditValue) & " - " & cDateTime.showDate(txtDateSp.EditValue) & ""
        '  report.Parameters("Head_f_month").Value = "แสรดดดดดด"


        Dim DayRun As Integer = 0
        Dim DateRun As String
        Dim dateST As String = cDateTime.dbDate(txtDateSt.EditValue)
        Dim dateSP As String = cDateTime.dbDate(txtDateSp.EditValue)
        DateRun = dateST
        Do Until DateRun > dateSP
            DayRun += 1

            Dim headName As String = "H" & DayRun
            report.Parameters(headName).Value = CDate(DateRun).Day

            DateRun = cDateTime.dbDate(CDate(DateRun).AddDays(1))
        Loop


        report.RequestParameters = False
        report.FilterString = ""

        Using printTool As New ReportPrintTool(report)
            printTool.AutoShowParametersPanel = False
            '   AddHandler printTool.PrintingSystem.StartPrint, New DevExpress.XtraPrinting.PrintDocumentEventHandler(AddressOf PrintingSystem_StartPrint)

            printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default)
        End Using
    End Sub
    Private Sub PrintReport_Eng()
        Dim report As New report_TimeTableByMonth_Eng
        Dim rptformular As String = ""


        report.SqlDataSource1.Connection.ConnectionString = db.getConnString

        rptformular = 1 = "1"

        If txtCode1.Text <> "" Then  ' ¤é¹ËÒµÒÁÃËÑÊ

            rptformular &= " And [Code]='" & txtCode1.Text.Trim & "'"
        ElseIf txtNameSearch.Text <> "" Then  ' ¤é¹ËÒµÒÁª×èÍ
            rptformular &= " And [fname] Like '%" & txtNameSearch.Text.Trim & "%'"
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
        report.Parameters("headname").Value = Me.Text ' "รายงานตามวันทำงาน"
        '   report.Parameters("cCheckDate").Value = "" & strDt & ""
        report.Parameters("Head_f_month").Value = "Date : " & "" & cDateTime.showDate(txtDateSt.EditValue) & " - " & cDateTime.showDate(txtDateSp.EditValue) & ""
        '  report.Parameters("Head_f_month").Value = "แสรดดดดดด"


        Dim DayRun As Integer = 0
        Dim DateRun As String
        Dim dateST As String = cDateTime.dbDate(txtDateSt.EditValue)
        Dim dateSP As String = cDateTime.dbDate(txtDateSp.EditValue)
        DateRun = dateST
        Do Until DateRun > dateSP
            DayRun += 1

            Dim headName As String = "H" & DayRun
            report.Parameters(headName).Value = CDate(DateRun).Day

            DateRun = cDateTime.dbDate(CDate(DateRun).AddDays(1))
        Loop


        report.RequestParameters = False
        report.FilterString = rptformular

        Using printTool As New ReportPrintTool(report)
            printTool.AutoShowParametersPanel = False
            '   AddHandler printTool.PrintingSystem.StartPrint, New DevExpress.XtraPrinting.PrintDocumentEventHandler(AddressOf PrintingSystem_StartPrint)

            printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default)
        End Using
    End Sub

    'Private Sub LoadSite()
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim strSQL As String
    '    strSQL = "Select Workingplace From Emp " & _
    '            " Group By Workingplace" & _
    '            " Order By Workingplace"
    '    Da = New SqlDataAdapter(strSQL, Conn)
    '    Da.Fill(Ds, "Data")
    '    With Ds.Tables("Data")
    '        cboSite.Items.Clear()
    '        cboSite.Items.Add("")
    '        Dim I As Integer
    '        For I = 0 To .Rows.Count - 1
    '            cboSite.Items.Add(.Rows(I).Item("WorkingPlace"))
    '        Next
    '        Ds.Clear()
    '    End With
    '  End Sub

    Private Sub GenTimeTableStdStatus(ByVal DateST As String, ByVal DateSP As String)
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim DateRun As String
        ' ClearData
        strSQL = "Delete From RPT_TimeTableByMonthAllEmp"
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()

        strSQL = "Delete From RPT_TimeTableByMonth_Head"
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()

        ' àµÃÕÂÁ Head
        strSQL = "Insert Into RPT_TimeTableByMonth_Head(H1) Values('')"
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()

        ' Create Head

        Call CreateHead(DateST, DateSP)

        ' GetEmp
        'Dim DsStd As DataSet = GetDsEmp()
        Dim query_emp As String = Get_Query_Emp()
        Dim I As Integer = 0

        ProgressBar1.Visible = True
        'ProgressBar1.Maximum = DsStd.Tables("data").Rows.Count
        'ProgressBar1.Value = 0
        'ProgressBar1.Text = ProgressBar1.Value & "/" & ProgressBar1.Maximum

        ProgressBar1.Maximum = DateDiff(DateInterval.Day, CDate(DateST), CDate(DateSP)) + 1
        ProgressBar1.Value = 0
        ProgressBar1.Text = ProgressBar1.Value & "/" & ProgressBar1.Maximum


        'For Each dr As DataRow In DsStd.Tables("data").Rows
        I += 1
        ' àµÃÕÂÁ Detail By Std
        strSQL = "Insert Into RPT_TimeTableByMonthAllEmp(Code)"
        strSQL &= " " & query_emp

        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()

        Dim DayRun As Integer = 0
        DateRun = DateST
        Do Until DateRun > DateSP
            ProgressBar1.Value += 1
            ProgressBar1.Text = ProgressBar1.Value & "/" & ProgressBar1.Maximum
            DayRun += 1
            ' Update Detail
            'strSQL = "Update RPT_TimeTableByMonthAllEmp " &
            '                        " Set D" & DayRun & "='" & GetStdStatus(dr("Code"), DateRun) & "'" &
            '        " From RPT_TimeTableByMonthAllEmp" &
            '                " Where Code = '" & dr("Code") & "'"
            strSQL = "Update RPT_TimeTableByMonthAllEmp " &
                                    " Set D" & DayRun & "= Isnull(dbo.fTimeTableGetStatus(RPT_TimeTableByMonthAllEmp.Code,'" & DateRun & "'),'')" &
                    " From RPT_TimeTableByMonthAllEmp" &
                            " inner join (" & query_emp & ") as emp" &
                                " on RPT_TimeTableByMonthAllEmp.Code = emp.Code"

            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            DateRun = Format(DateAdd(DateInterval.Day, 1, CDate(DateRun)), "yyyy/MM/dd")
        Loop

        ' Update Sumary Come,Absent
        strSQL = "Update RPT_TimeTableByMonthAllEmp " &
                                " Set Come = Isnull((c.D1+c.D2+c.D3+c.D4+c.D5+c.D6+c.D7+c.D8+c.D9+c.D10+c.D11+c.D12+c.D13+c.D14+c.D15+" &
                                                    " c.D16+c.D17+c.D18+c.D19+c.D20+c.D21+c.D22+c.D23+c.D24+c.D25+c.D26+c.D27+c.D28+" &
                                                    " c.D29+c.D30+c.D31),0) " &
                    " From RPT_TimeTableByMonthAllEmp" &
                            " inner join (" & query_emp & ") as emp" &
                                " on RPT_TimeTableByMonthAllEmp.Code = emp.Code" &
                            " inner join vTimeTableByMonth_Come c" &
                                " on RPT_TimeTableByMonthAllEmp.code = c.Code"
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()

        strSQL = "Update RPT_TimeTableByMonthAllEmp " &
                                " Set Abs = Isnull((c.D1+c.D2+c.D3+c.D4+c.D5+c.D6+c.D7+c.D8+c.D9+c.D10+c.D11+c.D12+c.D13+c.D14+c.D15+" &
                                                    " c.D16+c.D17+c.D18+c.D19+c.D20+c.D21+c.D22+c.D23+c.D24+c.D25+c.D26+c.D27+c.D28+" &
                                                    " c.D29+c.D30+c.D31),0) " &
                    " From RPT_TimeTableByMonthAllEmp" &
                            " inner join (" & query_emp & ") as emp" &
                                " on RPT_TimeTableByMonthAllEmp.Code = emp.Code" &
                            " inner join vTimeTableByMonth_Abs c" &
                                " on RPT_TimeTableByMonthAllEmp.code = c.Code"
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()

        'ProgressBar1.Value = I
        'ProgressBar1.Text = ProgressBar1.Value & "/" & ProgressBar1.Maximum
        'Next
        ProgressBar1.Visible = False
    End Sub

    Private Sub CreateHead(ByVal DateST As String, ByVal DateSP As String)
        ' Create Head
        Dim dCmd As New SqlCommand
        Dim DateRun As String
        Dim DayRun As Integer = 0
        DateRun = DateST
        Do Until DateRun > DateSP
            DayRun += 1
            ' GetHead
            StrSql = "Update RPT_TimeTableByMonth_Head " &
                            " Set H" & DayRun & "='" & CDate(DateRun).Day & "'"
            dCmd.Connection = Conn
            dCmd.CommandText = StrSql
            dCmd.ExecuteNonQuery()
            DateRun = Format(DateAdd(DateInterval.Day, 1, CDate(DateRun)), "yyyy/MM/dd")
        Loop
    End Sub

    Function GetDsEmp() As DataSet
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        Dim divid As String = ""
        Dim deptid As String = ""
        Dim secid As String = ""

        divid = GetData.GetDivisionId(cboDivision.Text.Trim)
        deptid = GetData.GetDepartmentId(cboDepartment.Text.Trim)


        strSQL = "Select Code " &
                    " From Emp left join department " &
                            " on emp.deptid = department.deptid " &
                          " left join division div " &
                            " on department.divid = div.divid " &
                    " Where WorkStatus = 'W' "


        If txtCode1.Text.Trim = "" And txtNameSearch.Text.Trim = "" And divid <> "" Then
            strSQL &= " and Isnull(Department.DivId,'') = '" & divid & "'"
        End If

        If txtCode1.Text.Trim = "" And txtNameSearch.Text.Trim = "" And deptid <> "" Then
            strSQL &= " and Isnull(Emp.DeptId,'') = '" & deptid & "'"
        End If

        If txtNameSearch.Text.Trim <> "" Then
            strSQL &= " and (Fname + LName) Like '%" & Replace(txtNameSearch.Text.Trim, " ", "") & "%'"
        End If

        strSQL &= " Order By Emp.Code"



        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        Return Ds
    End Function

    Function Get_Query_Emp() As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        Dim divid As String = ""
        Dim deptid As String = ""
        Dim secid As String = ""

        divid = GetData.GetDivisionId(cboDivision.Text.Trim)
        deptid = GetData.GetDepartmentId(cboDepartment.Text.Trim)


        strSQL = "Select Code " &
                    " From Emp left join department " &
                            " on emp.deptid = department.deptid " &
                          " left join division div " &
                            " on department.divid = div.divid " &
                    " Where WorkStatus = 'W' "

        If txtCode1.Text.Trim <> "" Then
            strSQL &= " and Isnull(emp.Code,'') = '" & txtCode1.Text.Trim & "'"
        Else
            If txtCode1.Text.Trim = "" And txtNameSearch.Text.Trim = "" And divid <> "" Then
                strSQL &= " and Isnull(Department.DivId,'') = '" & divid & "'"
            End If

            If txtCode1.Text.Trim = "" And txtNameSearch.Text.Trim = "" And deptid <> "" Then
                strSQL &= " and Isnull(Emp.DeptId,'') = '" & deptid & "'"
            End If

            If txtNameSearch.Text.Trim <> "" Then
                strSQL &= " and (Fname + LName) Like '%" & Replace(txtNameSearch.Text.Trim, " ", "") & "%'"
            End If
        End If
        Return strSQL

        'strSQL &= " Order By Emp.Code"



        'Da = New SqlDataAdapter(strSQL, Conn)
        'Da.Fill(Ds, "data")
        'Return Ds
    End Function

    Function GetStdStatus(ByVal Code As String, ByVal DateIn As String)
        Dim Da As New SqlDataAdapter
        Dim DS As New DataSet
        Dim strSQL As String

        strSQL = "select Status = Isnull(dbo.fTimeTableGetStatus('" & Code.Trim & "','" & DateIn.Trim & "'),'')"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(DS, "data")
        With DS.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("Status")
            End If
        End With
    End Function

    Function GetStdCome(ByVal Code As String) As Integer
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "select Code," &
                        " Come = Isnull((D1+D2+D3+D4+D5+D6+D7+D8+D9+D10+D11+D12+D13+D14+D15+" &
                                    " D16+D17+D18+D19+D20+D21+D22+D23+D24+D25+D26+D27+D28+" &
                                    " D29+D30+D31),0) " &
                " from vTimeTableByMonth_Come" &
                " Where Code = '" & Code.Trim & "'"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Return .Rows(0).Item("Come")
            End If
        End With
    End Function

    Function GetStdAbsent(ByVal Code As String) As Integer
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "select Code," &
                        " Absent = Isnull((D1+D2+D3+D4+D5+D6+D7+D8+D9+D10+D11+D12+D13+D14+D15+" &
                                    " D16+D17+D18+D19+D20+D21+D22+D23+D24+D25+D26+D27+D28+" &
                                    " D29+D30+D31),0) " &
                " from vTimeTableByMonth_Abs" &
                " Where Code = '" & Code.Trim & "'"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Return .Rows(0).Item("Absent")
            End If
        End With
    End Function


    Private Sub LoadDepartment()

        '--------------------------------------------
        Dim DA As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = "select DeptId,Department " &
            " from department "

        If cboCompany.SelectedIndex > 0 Then
            Strsql &= " Where DeptId In (Select DeptId From Emp " &
                                    " Where WorkStatus  = 'W' and " &
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
            cboDepartment.SelectedIndex = 0
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
            cboDivision.SelectedIndex = 0
        End With
    End Sub


    Private Sub cboCompany_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompany.SelectedIndexChanged
        Call LoadDepartment()
        Call LoadDivision()
    End Sub

    Private Sub txtCode1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        txtNameSearch.Text = ""
    End Sub

    Private Sub txtNameSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        ' txtCode1.Text = ""
    End Sub

    Private Sub cboCompany_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompany.SelectedIndexChanged
        Dim CompanyId As String = GetData.GetCompanyId(cboCompany.Text.Trim)

        Call SearchData.LoadDivision(Me, cboDivision, True)
        Call SearchData.LoadDepartment(Me, cboDepartment, "", True)

    End Sub



    Private Sub txtEmpId_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode1.GotFocus
        txtNameSearch.Text = ""
    End Sub


    Private Sub txtNameSearch_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNameSearch.GotFocus
        txtCode1.Text = ""
    End Sub



    Private Sub txtCode1_LostFocus(sender As Object, e As EventArgs) Handles txtCode1.LostFocus
        txtName.Text = gdata.GetShowEmpName(txtCode1.Text.Trim)
    End Sub

    Private Sub btnAllMonth_Click(sender As Object, e As EventArgs) Handles btnAllMonth.Click
        cboMonth_SelectedIndexChanged(Me, EventArgs.Empty)
    End Sub

    Private Sub btnCurrentDate_Click(sender As Object, e As EventArgs) Handles btnCurrentDate.Click
        txtDateSt.EditValue = Now.Date
        txtDateSp.EditValue = Now.Date
    End Sub

    Private Sub btnToDate_Click(sender As Object, e As EventArgs) Handles btnToDate.Click
        txtDateSp.EditValue = txtDateSt.EditValue
    End Sub

    Private Sub cboDivision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDivision.SelectedIndexChanged
        Call SearchData.LoadDepartment(Me, cboDepartment, GetData.GetDivisionId(cboDivision.Text.Trim), True)
    End Sub
End Class