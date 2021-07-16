Option Compare Text

Imports System.Data
Imports System.Data.SqlClient

Public Class frmRightManagementControl


    Private m_SortingColumn As ColumnHeader

    Dim DailyUpdate As Boolean = False
    Dim ImportData As Boolean = False
    Dim Processingtime As Boolean = False
    Dim ManageTime As Boolean = False
    Dim Overtime As Boolean = False
    Dim LateTime As Boolean = False
    Dim absenceTime As Boolean = False
    Dim Allowance As Boolean = False
    Dim InputLeaveData As Boolean = False
    Dim Configuration As Boolean = False

    Dim modelcalculations As Boolean = False
    Dim workinggroup As Boolean = False
    Dim DeterminedTime As Boolean = False
    Dim DeterminedTimeEmp As Boolean = False
    Dim DeterminedTimeEmpByOne As Boolean = False
    Dim DeterminedTimeEmpByDate As Boolean = False
    Dim setBarcode As Boolean = False
    Dim ProcessOT As Boolean = False
    Dim calculationLate As Boolean = False
    Dim calculationBreak As Boolean = False
    Dim Setholiday As Boolean = False

    Dim SetLeave As Boolean = False
    Dim SetabsenceTimeByYear As Boolean = False
    Dim setconditionsLate As Boolean = False
    Dim conditionslate As Boolean = False
    Dim conditionslatesomeone As Boolean = False
    Dim conditionslatebyRate As Boolean = False
    Dim setOT As Boolean = False

    Dim setdelaytime As Boolean = False

    Dim setdelayOT As Boolean = False
    Dim setovertimepay As Boolean = False
    Dim setAllowance As Boolean = False
    Dim LinkCodePayroll As Boolean = False
    Dim Report As Boolean = False
    Dim rptTimeWork As Boolean = False
    Dim rptTimeWorkLateByOne As Boolean = False
    Dim rptTimeSheet As Boolean = False

    Dim rptAllemployeework As Boolean = False
    Dim rptEmployeework As Boolean = False
    Dim rptEmpWorkDetail1 As Boolean = False
    Dim rptEmpWorkDetail2 As Boolean = False
    Dim rptOT As Boolean = False
    Dim rptSumaryMonth As Boolean = False

    Dim rptScheduleWorkAllEmp As Boolean = False
    Dim SummaryScheduleWorkAllEmp As Boolean = False
    Dim ConfigSummaryScheduleWorkAllEmp As Boolean = False
    Dim rptSummaryScheduleWorkAllEmp As Boolean = False
    Dim EmpNotWork As Boolean = False
    Dim ConfigEmpNotWork As Boolean = False
    Dim rptEmpNotWork As Boolean = False
    Dim rptemployeeByDate As Boolean = False

    Dim Sumaryemployee As Boolean = False
    Dim ConfogSumaryemployee As Boolean = False

    Dim rptSumaryemployee As Boolean = False
    Dim rptMaximumOThoursdaysweeksyear As Boolean = False
    Dim rptNormalworkinghoursOTByWeek As Boolean = False
    Dim SumaryHolidayInYears As Boolean = False
    Dim ConfigSumaryHolidayInYears As Boolean = False
    Dim rptSumaryHolidayInYears As Boolean = False
    Dim prtAllowance As Boolean = False
    Dim RptSumary As Boolean = False
    Dim RptSumaryByMonth As Boolean = False
    Dim Windows As Boolean = False
    Dim Permission As Boolean = False
    Dim ConfigPermission As Boolean = False
    Dim Exitx As Boolean = False
    Dim TimeWork As Boolean = False
    Dim rptrptSumaryMonthLateByBath As Boolean = False
    Dim RptSumaryByYear As Boolean = False

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click, btnEdit.Click
        If txtStaffId.Text.Trim = "" Then
            MsgBox("Please Select User", MsgBoxStyle.Information, Me.Text)
            txtStaffId.Focus()
            Exit Sub
        End If


        Dim UserID As String = txtStaffId.Text.Trim

        With TreeView1
            Call ResetData()
            For i As Integer = 0 To .Nodes.Count - 1
                Call CheckBeforeSave_Detail(.Nodes(i))
                If .Nodes(i).Nodes.Count > 0 Then
                    Call CheckBeforeSave(.Nodes(i))
                End If
            Next
        End With

        Dim strSQL As String = ""
        Dim dCmd As New SqlCommand
        Dim data As New ArrayList
        Dim strType As String = ""
        strSQL = "insert into PermissionTimeAtt" & _
                    " (IdCode, DailyUpdate, ImportData, Processingtime, ManageTime, " & _
                    " Overtime, LateTime, absenceTime, Allowance, InputLeaveData, " & _
                    " Configuration, modelcalculations, workinggroup, DeterminedTime, DeterminedTimeEmp, " & _
                    " DeterminedTimeEmpByOne,DeterminedTimeEmpByDate, setBarcode, ProcessOT, calculationLate,  " & _
                    " calculationBreak, Setholiday, SetLeave, SetabsenceTimeByYear,setconditionsLate," & _
                    " conditionslate, conditionslatesomeone, conditionslatebyRate, setOT, setdelaytime," & _
                    " setdelayOT, setovertimepay, setAllowance, LinkCodePayroll,Report, " & _
                    " rptTimeWork,rptTimeWorkLateByOne,rptTimeSheet,rptAllemployeework, rptEmployeework,  " & _
                    " rptEmpWorkDetail1, rptEmpWorkDetail2,rptOT,rptSumaryMonth,rptScheduleWorkAllEmp," & _
                    " SummaryScheduleWorkAllEmp,ConfigSummaryScheduleWorkAllEmp,rptSummaryScheduleWorkAllEmp,EmpNotWork,ConfigEmpNotWork," & _
                    " rptEmpNotWork,rptemployeeByDate,Sumaryemployee,ConfogSumaryemployee,rptSumaryemployee," & _
                    " rptMaximumOThoursdaysweeksyear,rptNormalworkinghoursOTByWeek, SumaryHolidayInYears,ConfigSumaryHolidayInYears,rptSumaryHolidayInYears," & _
                    " prtAllowance,RptSumary,RptSumaryByMonth,Windows,Permission, " & _
                    " ConfigPermission , Exitx , TimeWork ,rptrptSumaryMonthLateByBath ,RptSumaryByYear,PermissionTimeAtt_ReadOnly,ManageTime_ReadOnly)" & _
                " values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10," & _
                " @P11,@P12,@P13,@P14,@P15,@P16,@P17,@P18,@P19,@P20," & _
                " @P21,@P22,@P23,@P24,@P25,@P26,@P27,@P28,@P29,@P30," & _
                " @P31,@P32,@P33,@P34,@P35,@P36,@P37,@P38,@P39,@P40," & _
                " @P41,@P42,@P43,@P44,@P45,@P46,@P47,@P48,@P49,@P50," & _
                " @P51,@P52,@P53,@P54,@P55,@P56,@P57,@P58,@P59,@P60, " & _
                " @P61,@P62,@P63,@P64,@P65,@P66,@P67,@P68,@P69,@P70, " & _
                " @P71,@P72)"

        '     data.Add(GetDeptId(cboDepartmentName.Text.Trim))
        data.Add(UserID) : strType = "T"
        data.Add(DailyUpdate) : strType &= "B"
        data.Add(ImportData) : strType &= "B"
        data.Add(Processingtime) : strType &= "B"
        data.Add(ManageTime) : strType &= "B"

        data.Add(Overtime) : strType &= "B"
        data.Add(LateTime) : strType &= "B"
        data.Add(absenceTime) : strType &= "B"
        data.Add(Allowance) : strType &= "B"
        data.Add(InputLeaveData) : strType &= "B"

        data.Add(Configuration) : strType &= "B"
        data.Add(modelcalculations) : strType &= "B"
        data.Add(workinggroup) : strType &= "B"
        data.Add(DeterminedTime) : strType &= "B"
        data.Add(DeterminedTimeEmp) : strType &= "B"

        data.Add(DeterminedTimeEmpByOne) : strType &= "B"
        data.Add(DeterminedTimeEmpByDate) : strType &= "B"
        data.Add(setBarcode) : strType &= "B"
        data.Add(ProcessOT) : strType &= "B"
        data.Add(calculationLate) : strType &= "B"

        data.Add(calculationBreak) : strType &= "B"
        data.Add(Setholiday) : strType &= "B"
        data.Add(SetLeave) : strType &= "B"
        data.Add(SetabsenceTimeByYear) : strType &= "B"
        data.Add(setconditionsLate) : strType &= "B"

        data.Add(conditionslate) : strType &= "B"
        data.Add(conditionslatesomeone) : strType &= "B"
        data.Add(conditionslatebyRate) : strType &= "B"
        data.Add(setOT) : strType &= "B"
        data.Add(setdelaytime) : strType &= "B"

        data.Add(setdelayOT) : strType &= "B"
        data.Add(setovertimepay) : strType &= "B"
        data.Add(setAllowance) : strType &= "B"
        data.Add(LinkCodePayroll) : strType &= "B"
        data.Add(Report) : strType &= "B"

        data.Add(rptTimeWork) : strType &= "B"
        data.Add(rptTimeWorkLateByOne) : strType &= "B"
        data.Add(rptTimeSheet) : strType &= "B"
        data.Add(rptAllemployeework) : strType &= "B"
        data.Add(rptEmployeework) : strType &= "B"

        data.Add(rptEmpWorkDetail1) : strType &= "B"
        data.Add(rptEmpWorkDetail2) : strType &= "B"
        data.Add(rptOT) : strType &= "B"
        data.Add(rptSumaryMonth) : strType &= "B"
        data.Add(rptScheduleWorkAllEmp) : strType &= "B"

        data.Add(SummaryScheduleWorkAllEmp) : strType &= "B"
        data.Add(ConfigSummaryScheduleWorkAllEmp) : strType &= "B"
        data.Add(rptSummaryScheduleWorkAllEmp) : strType &= "B"
        data.Add(EmpNotWork) : strType &= "B"
        data.Add(ConfigEmpNotWork) : strType &= "B"

        data.Add(rptEmpNotWork) : strType &= "B"
        data.Add(rptemployeeByDate) : strType &= "B"
        data.Add(Sumaryemployee) : strType &= "B"
        data.Add(ConfogSumaryemployee) : strType &= "B"
        data.Add(rptSumaryemployee) : strType &= "B"

        data.Add(rptMaximumOThoursdaysweeksyear) : strType &= "B"
        data.Add(rptNormalworkinghoursOTByWeek) : strType &= "B"
        data.Add(SumaryHolidayInYears) : strType &= "B"
        data.Add(ConfigSumaryHolidayInYears) : strType &= "B"
        data.Add(rptSumaryHolidayInYears) : strType &= "B"

        data.Add(prtAllowance) : strType &= "B"
        data.Add(RptSumary) : strType &= "B"
        data.Add(RptSumaryByMonth) : strType &= "B"
        data.Add(Windows) : strType &= "B"
        data.Add(Permission) : strType &= "B"

        data.Add(ConfigPermission) : strType &= "B"
        data.Add(Exitx) : strType &= "B"
        data.Add(TimeWork) : strType &= "B"
        data.Add(rptrptSumaryMonthLateByBath) : strType &= "B"
        data.Add(RptSumaryByYear) : strType &= "B"
        data.Add(IIf(chkPermissionTimeAtt.Checked = True, False, True)) : strType &= "B"
        data.Add(IIf(chkManageTime.Checked = True, False, True)) : strType &= "B"


        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            Dim strSQL1 As String = "delete from PermissionTimeAtt where idcode = @P1"
            Dim D1 As New ArrayList
            D1.Add(UserID)

            Dim strSQL2 As String = "delete from PermissionTimeAtt_Company where idcode = @P1"
            Dim D2 As New ArrayList
            D2.Add(UserID)

            Dim c As New db

            c.ExecuteCommand(Conn, dCmd, strSQL2, "T", D2)
            c.ExecuteCommand(Conn, dCmd, strSQL1, "T", D1)
            c.ExecuteCommand(Conn, dCmd, strSQL, strType, data)
            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try
        Call AddPermisstion_company()
        MsgBox("Save Completed", MsgBoxStyle.Information, Me.Text)
        'Call Enacmd(False, True, True)


        '  Call btnRefresh_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub AddPermisstion_company()

        If LstCompany.CheckedItems.Count = 0 Then Exit Sub

        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Code As String = txtStaffId.Text.Trim
        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn

        Try
            For i As Integer = 0 To LstCompany.CheckedItems.Count - 1
                strSQL = " Insert Into PermissionTimeAtt_Company (CompanyID,IdCode) Values " & _
                        "( '" & LstCompany.CheckedItems(i).SubItems(1).Text.Trim & "','" & Code & "') "

                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()
            Next


            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try


    End Sub

    Private Sub frmRightManagementControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadUser()
        Call Enacmd(True, False, False)
        Call LoadCompany()
        TreeView1.ExpandAll()
    End Sub

    Private Sub LoadCompany()
        Dim strSQL As String = ""
        Dim dCmd As New SqlCommand
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim arrData() As String
        Dim List As ListViewItem

        strSQL = " Select CompanyID , CompanyName from Company_Sub  " & _
            " order by CompanyID "

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")

        With Ds.Tables("Data")
            LstCompany.Items.Clear()
            Dim I As Integer
            For I = 0 To .Rows.Count - 1

                arrData = New String() {I + 1, _
                                      .Rows(I).Item("CompanyID"), _
                                       .Rows(I).Item("CompanyName")}
                List = New ListViewItem(arrData)
                LstCompany.Items.Add(List)

            Next
            Ds.Clear()
        End With

    End Sub

    Private Sub LoadUser()
        Dim strSQL As String = ""
        Dim dCmd As New SqlCommand
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim arrData() As String
        Dim List As ListViewItem
        strSQL = "select e.Code  , Title = isnull(e.Title,'') , Fname = ISNULL(e.Fname,'') , Lname = ISNULL(e.Lname,'') " & _
                      " , UserName = isnull(u.UserName,'') " & _
              " from emp e Inner Join [user] u" & _
                      " On e.Code = u.UserId" & _
              " where WorkStatus = 'W' " & _
              " order by Code "

        Try
            Dim c As New db
            c.ExecuteCommand(Conn, dCmd, strSQL)
            Da.SelectCommand = dCmd
            Da.Fill(Ds, "data")
            lstUser.Items.Clear()
            For Each dr As DataRow In Ds.Tables("data").Rows
                arrData = New String() {dr("code"), _
                                        dr("Fname"), _
                                        dr("Lname"), _
                                        dr("Username")}
                List = New ListViewItem(arrData)
                lstUser.Items.Add(List)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub LoadPermission(ByVal Id As String)
        Dim strSQL As String = ""
        Dim dCmd As New SqlCommand
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet

        strSQL = "select * from PermissionTimeAtt where idCode = '" & Id & "'"
        Try
            Dim c As New db
            c.ExecuteCommand(Conn, dCmd, strSQL)
            Da.SelectCommand = dCmd
            Da.Fill(Ds, "data")

            With Ds.Tables("data")
                If .Rows.Count = 0 Then
                    Call ResetTreeview()
                    'Call Enacmd(True, False, False)
                Else
                    Call ResetTreeview()
                    Dim dr As DataRow = .Rows(0)

                    Call LoadPermission_Main(dr)
                    'Call Enacmd(False, True, True)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub LoadPermission_Main(ByVal Dr As DataRow)
        For i As Integer = 0 To TreeView1.Nodes.Count - 1
            Call LoadPermission_Detail(Dr, TreeView1.Nodes(i))
            If TreeView1.Nodes(i).Nodes.Count > 0 Then
                Call LoadPermission_Sub(Dr, TreeView1.Nodes(i))
            End If
        Next
    End Sub

    Private Sub LoadPermission_Sub(ByVal dr As DataRow, ByVal nd As TreeNode)
        For i As Integer = 0 To nd.Nodes.Count - 1
            Call LoadPermission_Detail(dr, nd.Nodes(i))
            If nd.Nodes(i).Nodes.Count > 0 Then
                Call LoadPermission_Sub(dr, nd.Nodes(i))
            End If
        Next
    End Sub

    Private Sub LoadPermission_Detail(ByVal dr As DataRow, ByVal nd As TreeNode)
        Select Case nd.Name.Trim
            Case "DailyUpdate"
                nd.Checked = dr("DailyUpdate")
            Case "ImportData"
                nd.Checked = dr("ImportData")
            Case "Processingtime"
                nd.Checked = dr("Processingtime")
            Case "ManageTime"
                nd.Checked = dr("ManageTime")
            Case "Overtime"
                nd.Checked = dr("Overtime")
            Case "LateTime"
                nd.Checked = dr("LateTime")
            Case "absenceTime"
                nd.Checked = dr("absenceTime")
            Case "Allowance"
                nd.Checked = dr("Allowance")
            Case "InputLeaveData"
                nd.Checked = dr("InputLeaveData")
            Case "Configuration"
                nd.Checked = dr("Configuration")
            Case "modelcalculations"
                nd.Checked = dr("modelcalculations")
            Case "workinggroup"
                nd.Checked = dr("workinggroup")
            Case "DeterminedTime"
                nd.Checked = dr("DeterminedTime")
            Case "DeterminedTimeEmp"
                nd.Checked = dr("DeterminedTimeEmp")
            Case "DeterminedTimeEmpByOne"
                nd.Checked = dr("DeterminedTimeEmpByOne")
            Case "DeterminedTimeEmpByDate"
                nd.Checked = dr("DeterminedTimeEmpByDate")
            Case "setBarcode"
                nd.Checked = dr("setBarcode")
            Case "ProcessOT"
                nd.Checked = dr("ProcessOT")
            Case "calculationLate"
                nd.Checked = dr("calculationLate")
            Case "calculationBreak"
                nd.Checked = dr("calculationBreak")
            Case "Setholiday"
                nd.Checked = dr("Setholiday")
            Case "SetLeave"
                nd.Checked = dr("SetLeave")
            Case "SetabsenceTimeByYear"
                nd.Checked = dr("SetabsenceTimeByYear")
            Case "setconditionsLate"
                nd.Checked = dr("setconditionsLate")
            Case "conditionslate"
                nd.Checked = dr("conditionslate")
            Case "conditionslatesomeone"
                nd.Checked = dr("conditionslatesomeone")
            Case "conditionslatebyRate"
                nd.Checked = dr("conditionslatebyRate")
            Case "setOT"
                nd.Checked = dr("setOT")
            Case "setdelaytime"
                nd.Checked = dr("setdelaytime")
            Case "setdelayOT"
                nd.Checked = dr("setdelayOT")
            Case "setovertimepay"
                nd.Checked = dr("setovertimepay")
            Case "setAllowance"
                nd.Checked = dr("setAllowance")
            Case "LinkCodePayroll"
                nd.Checked = dr("LinkCodePayroll")
            Case "Report"
                nd.Checked = dr("Report")
            Case "rptTimeWork"
                nd.Checked = dr("rptTimeWork")
            Case "rptTimeWorkLateByOne"
                nd.Checked = dr("rptTimeWorkLateByOne")
            Case "rptTimeSheet"
                nd.Checked = dr("rptTimeSheet")
            Case "rptAllemployeework"
                nd.Checked = dr("rptAllemployeework")
            Case "rptEmployeework"
                nd.Checked = dr("rptEmployeework")
            Case "rptEmpWorkDetail1"
                nd.Checked = dr("rptEmpWorkDetail1")
            Case "rptEmpWorkDetail2"
                nd.Checked = dr("rptEmpWorkDetail2")
            Case "rptOT"
                nd.Checked = dr("rptOT")
            Case "rptSumaryMonth"
                nd.Checked = dr("rptSumaryMonth")
            Case "rptScheduleWorkAllEmp"
                nd.Checked = dr("rptScheduleWorkAllEmp")
            Case "SummaryScheduleWorkAllEmp"
                nd.Checked = dr("SummaryScheduleWorkAllEmp")
            Case "ConfigSummaryScheduleWorkAllEmp"
                nd.Checked = dr("ConfigSummaryScheduleWorkAllEmp")
            Case "rptSummaryScheduleWorkAllEmp"
                nd.Checked = dr("rptSummaryScheduleWorkAllEmp")
            Case "EmpNotWork"
                nd.Checked = dr("EmpNotWork")
            Case "ConfigEmpNotWork"
                nd.Checked = dr("ConfigEmpNotWork")
            Case "rptEmpNotWork"
                nd.Checked = dr("rptEmpNotWork")
            Case "rptemployeeByDate"
                nd.Checked = dr("rptemployeeByDate")
            Case "Sumaryemployee"
                nd.Checked = dr("Sumaryemployee")
            Case "ConfogSumaryemployee"
                nd.Checked = dr("ConfogSumaryemployee")
            Case "rptSumaryemployee"
                nd.Checked = dr("rptSumaryemployee")
            Case "rptMaximumOThoursdaysweeksyear"
                nd.Checked = dr("rptMaximumOThoursdaysweeksyear")
            Case "rptNormalworkinghoursOTByWeek"
                nd.Checked = dr("rptNormalworkinghoursOTByWeek")
            Case "SumaryHolidayInYears"
                nd.Checked = dr("SumaryHolidayInYears")
            Case "ConfigSumaryHolidayInYears"
                nd.Checked = dr("ConfigSumaryHolidayInYears")
            Case "rptSumaryHolidayInYears"
                nd.Checked = dr("rptSumaryHolidayInYears")
            Case "prtAllowance"
                nd.Checked = dr("prtAllowance")
            Case "RptSumary"
                nd.Checked = dr("RptSumary")
            Case "RptSumaryByMonth"
                nd.Checked = dr("RptSumaryByMonth")
            Case "Windows"
                nd.Checked = dr("Windows")
            Case "Permission"
                nd.Checked = dr("Permission")
            Case "ConfigPermission"
                nd.Checked = dr("ConfigPermission")
            Case "TimeWork"
                nd.Checked = dr("TimeWork")
            Case "rptrptSumaryMonthLateByBath"
                nd.Checked = dr("rptrptSumaryMonthLateByBath")
            Case "Exitx"
                nd.Checked = dr("Exitx")
            Case "RptSumaryByYear"
                nd.Checked = dr("RptSumaryByYear")

        End Select
    End Sub

    Private Sub Enacmd(ByVal Add As Boolean, ByVal Edit As Boolean, ByVal Delete As Boolean)
        btnAdd.Enabled = Add
        btnEdit.Enabled = Edit
        btnDelete.Enabled = Delete
    End Sub

    Private Sub lstUser_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lstUser.ColumnClick
        Dim Lst As ListView = CType(sender, ListView)
        Dim new_sorting_column As ColumnHeader = _
                                    Lst.Columns(e.Column)
        Dim sort_order As System.Windows.Forms.SortOrder
        If m_SortingColumn Is Nothing Then
            sort_order = SortOrder.Ascending
        Else
            If new_sorting_column.Equals(m_SortingColumn) Then
                If m_SortingColumn.Text.StartsWith("> ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                sort_order = SortOrder.Ascending
            End If

            m_SortingColumn.Text = m_SortingColumn.Text.Substring(2)
        End If

        m_SortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text = "> " & m_SortingColumn.Text
        Else
            m_SortingColumn.Text = "< " & m_SortingColumn.Text
        End If

        Lst.ListViewItemSorter = New ListViewComparer(e.Column, sort_order)

        Lst.Sort()
    End Sub

    Private Sub lstUser_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstUser.DoubleClick
        With lstUser
            If .SelectedItems.Count = 0 Then Exit Sub
            txtStaffId.Text = .SelectedItems(0).SubItems(0).Text.Trim
            txtFirstName.Text = .SelectedItems(0).SubItems(1).Text.Trim
            txtLname.Text = .SelectedItems(0).SubItems(2).Text.Trim
            txtUserName.Text = .SelectedItems(0).SubItems(3).Text.Trim
            Call LoadPermission(txtStaffId.Text.Trim)
            Call LoadPermission_Company(txtStaffId.Text.Trim)
            Call LoadPermision_ReadOnly()
        End With
    End Sub

    Private Sub LoadPermision_ReadOnly()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim Dcmd As New SqlCommand

        Strsql = "Select idCode,PermissionTimeAtt_ReadOnly,Managetime_ReadOnly " & _
                 " From PermissionTimeAtt " & _
                 " Where idcode='" & txtStaffId.Text.Trim & "'"

        Try
            '  OpenConnect(True)
            Da = New SqlDataAdapter(Strsql, Conn)
            Da.Fill(Ds, "DATA")
            '   OpenConnect(False)

            With Ds.Tables("DATA")
                If .Rows.Count = 0 Then
                    Exit Sub
                End If
                Dim A As Boolean
                Dim B As Boolean
                A = .Rows(0).Item("PermissionTimeAtt_ReadOnly") + 1
                B = .Rows(0).Item("ManageTime_readOnly") + 1

                chkPermissionTimeAtt.Checked = A
                chkManageTime.Checked = B
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub LoadPermission_Company(ByVal Code As String)

        Dim strSQL As String = ""
        Dim dCmd As New SqlCommand
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet


        strSQL = " Select CompanyID from PermissionTimeAtt_Company where IdCode = '" & Code & "' "

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")

        With Ds.Tables("Data")
            LstCompany.SelectedItems.Clear()
            Dim I As Integer
            For I = 0 To .Rows.Count - 1
                Dim CheckCode As String = .Rows(I).Item("CompanyID")

                For J As Integer = 0 To LstCompany.Items.Count - 1
                    If CheckCode = LstCompany.Items(J).SubItems(1).Text Then

                        LstCompany.Items(J).Checked = True

                        Exit For
                    End If

                Next

            Next

            Ds.Clear()
        End With



    End Sub

    Private Sub ResetTreeview()
        With TreeView1
            For i As Integer = 0 To .Nodes.Count - 1
                .Nodes(i).Checked = False
                Call ResetTreeview_Sub(.Nodes(i))
                'For j As Integer = 0 To .Nodes(i).Nodes.Count - 1
                '    .Nodes(i).Nodes(j).Checked = False
                '    For k As Integer = 0 To .Nodes(i).Nodes(j).Nodes.Count - 1
                '        .Nodes(i).Nodes(j).Nodes(k).Checked = False
                '        For l As Integer = 0 To .Nodes(i).Nodes(j).Nodes(l).Nodes.Count - 1
                '            .Nodes(i).Nodes(j).Nodes(k).Nodes(l).Checked = False
                '        Next
                '    Next
                'Next
            Next
        End With
    End Sub

    Private Sub ResetTreeview_Sub(ByVal nd As TreeNode)
        For ii As Integer = 0 To nd.Nodes.Count - 1
            nd.Nodes(ii).Checked = False
            If nd.Nodes(ii).Nodes.Count > 0 Then
                Call ResetTreeview_Sub(nd.Nodes(ii))
            End If
        Next
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Call ClearData()
        Call ResetTreeview()
        'Call Enacmd(True, False, False)
        Call LoadCompany()
    End Sub

    Private Sub ClearData()
        txtStaffId.Text = ""
        txtFirstName.Text = ""
        txtLname.Text = ""
        txtUserName.Text = ""
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtStaffId.Text.Trim = "" Then
            MsgBox("Please Select User", MsgBoxStyle.Information, Me.Text)
            txtStaffId.Focus()
            Exit Sub
        End If


        Dim strSQL As String = ""
        Dim dCmd As New SqlCommand
        strSQL = "delete Permission " & _
                " where IdCode = " & txtStaffId.Text.Trim

        Try
            Dim c As New db
            c.ExecuteCommand(Conn, dCmd, strSQL)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try

        MsgBox("Update Completed", MsgBoxStyle.Information, Me.Text)
        Call btnRefresh_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub CheckBeforeSave(ByVal nd As TreeNode)
        For i As Integer = 0 To nd.Nodes.Count - 1
            Call CheckBeforeSave_Detail(nd.Nodes(i))
            If nd.Nodes(i).Nodes.Count > 0 Then
                Call CheckBeforeSave(nd.Nodes(i))
            End If
        Next
    End Sub

    Private Sub CheckBeforeSave_Detail(ByVal nd As TreeNode)
        If nd.Checked = True Then
            Select Case nd.Name.Trim
                Case "DailyUpdate"
                    DailyUpdate = True
                Case "ImportData"
                    ImportData = True
                Case "Processingtime"
                    Processingtime = True
                Case "ManageTime"
                    ManageTime = True
                Case "Overtime"
                    Overtime = True
                Case "LateTime"
                    LateTime = True
                Case "absenceTime"
                    absenceTime = True
                Case "Allowance"
                    Allowance = True
                Case "InputLeaveData"
                    InputLeaveData = True
                Case "Configuration"
                    Configuration = True
                Case "modelcalculations"
                    modelcalculations = True
                Case "workinggroup"
                    workinggroup = True
                Case "DeterminedTime"
                    DeterminedTime = True
                Case "DeterminedTimeEmp"
                    DeterminedTimeEmp = True
                Case "DeterminedTimeEmpByOne"
                    DeterminedTimeEmpByOne = True
                Case "DeterminedTimeEmpByDate"
                    DeterminedTimeEmpByDate = True
                Case "setBarcode"
                    setBarcode = True
                Case "ProcessOT"
                    ProcessOT = True
                Case "calculationLate"
                    calculationLate = True
                Case "calculationBreak"
                    calculationBreak = True
                Case "Setholiday"
                    Setholiday = True
                Case "SetLeave"
                    SetLeave = True
                Case "SetabsenceTimeByYear"
                    SetabsenceTimeByYear = True
                Case "setconditionsLate"
                    setconditionsLate = True
                Case "conditionslate"
                    conditionslate = True
                Case "conditionslatesomeone"
                    conditionslatesomeone = True
                Case "conditionslatebyRate"
                    conditionslatebyRate = True
                Case "setOT"
                    setOT = True
                Case "setdelaytime"
                    setdelaytime = True
                Case "setdelayOT"
                    setdelayOT = True
                Case "setovertimepay"
                    setovertimepay = True
                Case "setAllowance"
                    setAllowance = True
                Case "LinkCodePayroll"
                    LinkCodePayroll = True
                Case "Report"
                    Report = True
                Case "rptTimeWork"
                    rptTimeWork = True
                Case "rptTimeWorkLateByOne"
                    rptTimeWorkLateByOne = True
                Case "rptTimeSheet"
                    rptTimeSheet = True
                Case "rptAllemployeework"
                    rptAllemployeework = True
                Case "rptEmployeework"
                    rptEmployeework = True
                Case "rptEmpWorkDetail1"
                    rptEmpWorkDetail1 = True
                Case "rptEmpWorkDetail2"
                    rptEmpWorkDetail2 = True
                Case "rptOT"
                    rptOT = True
                Case "rptSumaryMonth"
                    rptSumaryMonth = True
                Case "rptScheduleWorkAllEmp"
                    rptScheduleWorkAllEmp = True
                Case "SummaryScheduleWorkAllEmp"
                    SummaryScheduleWorkAllEmp = True
                Case "ConfigSummaryScheduleWorkAllEmp"
                    ConfigSummaryScheduleWorkAllEmp = True
                Case "rptSummaryScheduleWorkAllEmp"
                    rptSummaryScheduleWorkAllEmp = True
                Case "EmpNotWork"
                    EmpNotWork = True
                Case "ConfigEmpNotWork"
                    ConfigEmpNotWork = True
                Case "rptEmpNotWork"
                    rptEmpNotWork = True
                Case "rptemployeeByDate"
                    rptemployeeByDate = True
                Case "Sumaryemployee"
                    Sumaryemployee = True
                Case "ConfogSumaryemployee"
                    ConfogSumaryemployee = True
                Case "rptSumaryemployee"
                    rptSumaryemployee = True
                Case "rptMaximumOThoursdaysweeksyear"
                    rptMaximumOThoursdaysweeksyear = True
                Case "rptNormalworkinghoursOTByWeek"
                    rptNormalworkinghoursOTByWeek = True
                Case "SumaryHolidayInYears"
                    SumaryHolidayInYears = True
                Case "ConfigSumaryHolidayInYears"
                    ConfigSumaryHolidayInYears = True
                Case "rptSumaryHolidayInYears"
                    rptSumaryHolidayInYears = True
                Case "prtAllowance"
                    prtAllowance = True
                Case "RptSumary"
                    RptSumary = True
                Case "RptSumaryByMonth"
                    RptSumaryByMonth = True
                Case "Windows"
                    Windows = True
                Case "Permission"
                    Permission = True
                Case "ConfigPermission"
                    ConfigPermission = True
                Case "Exitx"
                    Exitx = True
                Case "TimeWork"
                    TimeWork = True
                Case "rptrptSumaryMonthLateByBath"
                    rptrptSumaryMonthLateByBath = True
                Case "RptSumaryByYear"
                    RptSumaryByYear = True
            End Select
        End If
    End Sub

    Private Sub lstUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUser.SelectedIndexChanged

    End Sub


    Private Sub ResetData()

        DailyUpdate = False
        ImportData = False
        Processingtime = False
        ManageTime = False
        Overtime = False
        LateTime = False
        absenceTime = False
        Allowance = False
        InputLeaveData = False
        Configuration = False
        modelcalculations = False
        workinggroup = False
        DeterminedTime = False

        DeterminedTimeEmp = False
        DeterminedTimeEmpByOne = False
        DeterminedTimeEmpByDate = False
        setBarcode = False
        ProcessOT = False
        calculationLate = False
        calculationBreak = False

        calculationBreak = False

        SetLeave = False
        SetabsenceTimeByYear = False
        setconditionsLate = False
        conditionslate = False
        conditionslatesomeone = False
        conditionslatebyRate = False
        setOT = False

        setdelaytime = False

        setdelayOT = False
        setovertimepay = False
        setAllowance = False
        LinkCodePayroll = False
        Report = False
        rptTimeWork = False
        rptTimeWorkLateByOne = False
        rptTimeSheet = False

        rptAllemployeework = False
        rptEmployeework = False
        rptEmpWorkDetail1 = False
        rptEmpWorkDetail2 = False
        rptOT = False
        rptSumaryMonth = False

        rptScheduleWorkAllEmp = False
        SummaryScheduleWorkAllEmp = False
        ConfigSummaryScheduleWorkAllEmp = False
        rptSummaryScheduleWorkAllEmp = False
        EmpNotWork = False
        ConfigEmpNotWork = False
        rptEmpNotWork = False
        rptemployeeByDate = False

        Sumaryemployee = False
        ConfogSumaryemployee = False

        rptSumaryemployee = False
        rptMaximumOThoursdaysweeksyear = False
        rptNormalworkinghoursOTByWeek = False
        SumaryHolidayInYears = False
        ConfigSumaryHolidayInYears = False
        rptSumaryHolidayInYears = False
        prtAllowance = False
        RptSumary = False
        RptSumaryByMonth = False
        Windows = False

        Permission = False
        ConfigPermission = False
        Exitx = False
        TimeWork = False
        rptrptSumaryMonthLateByBath = False
        RptSumaryByYear = False
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub

    Private Sub txtStaffId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStaffId.TextChanged

    End Sub
End Class