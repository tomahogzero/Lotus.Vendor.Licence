Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data
Imports System.Data.OleDb
Imports TimeAttendance.utils


Module ModSystem
    'Public Conn As SqlClient.SqlConnection = New SqlConnection
    Public Conn As SqlConnection = New SqlConnection
    Public conn1 As OleDb.OleDbConnection
    Public StrSql As String
    Public IsTableLoad As Boolean = False
    Public DsTable As DataSet = New DataSet
    Public DaTable As SqlDataAdapter

    '�������
    Declare Function GetVolumeInformation Lib "kernel32" Alias "GetVolumeInformationA" (ByVal lpRootPathName As String, ByVal lpVolumeNameBuffer As String, ByVal nVolumeNameSize As Integer, ByRef lpVolumeSerialNumber As Integer, ByRef lpMaximumComponentLength As Integer, ByRef lpFileSystemFlags As Integer, ByVal lpFileSystemNameBuffer As String, ByVal nFileSystemNameSize As Integer) As Integer
    Public KeySet As String = "Shell"
    Public TimeRemain As Integer
    Public uMax As String = 365
    Public PublicKey As String = "PPSMSRPTOMAHOGZERO"
    Public SubKey As String = "{AD1B99BE-85D5-40AF-B28E-1B113473B187}"
    Public PubKey As String = "PPSMSRPTOMAHOGZERO"
    Public CountKeySet As String = "MSWC.xml"
    Public CountSubKey As String = "{D89A7BD6-DFD5-4EC1-BCEE-DB692E03FD10}"
    Public DevId As String = Microsoft.VisualBasic.Left(fCheckSerial.Trim, 8)
    Public ComId As String = ""
    Public CView As Boolean
    Public ComName As String

    Public App_Project As String = "AT"

    ' Login
    Public PassLogin As Boolean = False
    Public DataBaseName As String = "Payroll"
    Public cUsername As String
    Public cPassword As String
    Public Server As String
    Public SendTypeMaterial As TypeMaterial
    Public UserName As String
    Public Password As String
    ' From
    'Public fMain As New frmMainMenu
    ' Public fMainMenu As frmMainMenu
    Public fMainMenuHD As frmMainMenuDev

    ' Config from Payroll
    Public fCompany As frmCompany
    Public fEmp As frmVendorLicence
    Public fDepartment As frmDepartment
    Public fDivision As frmDivision
    Public fDivision_List As frmDivision_List
    Public fDepartment_List As frmDepartment_List


    Public fGetText As frmGetText
    Public fWorkingTime As frmWorkingTime
    Public fHolidayYear As frmHolidayYear_New
    Public fWorkingStatus As frmWorkingStatus
    Public fTimework As frmTimework
    Public fEditTime As frmEditTime
    Public fOvertime As frmOvertime
    Public fLate As frmLate
    Public fAbsent As frmAbs
    Public fVacation As frmVacation
    Public fAllowance As frmAllowance
    Public fReportTimeSheet As frmRptTimeSheet
    'Public fSumarized As frmSumarized
    Public fTimeKa As frmTimeKa
    Public fEmpSetTime As frmEmpSetTime
    Public fSetBarcode As frmSetBarcode
    Public fEmpSetTimeByDate As frmEmpSetTimeByDate
    Public fKaGroupUse As frmKaGroupUse
    Public fKa_Spacial As frmKa_Spacial
    Public fMainConfig As frmMainConfig
    Public fEmpCalOTConfig As frmEmpCalOTConfig
    Public fEmpCalLate As frmEmpCalLate
    Public fEmpCalAbs As frmEmpCalAbs
    Public fOtDeductRate As frmOtDeductRate
    Public fEmpCalOTDeducRate_CancelByDate As frmEmpCalOTDeducRate_CancelByDate
    Public fEmpCalOTDeducRate As frmEmpCalOTDeducRate
    Public fRptAllEmpWork_Detail2 As frmRptAllEmpWork_Detail2
    Public fLimitHourOT As frmLimitHourOT

    Public fReportOvertime As frmReportOvertime
    Public fReportAllowance As frmReportAllowance
    Public fReportSumary As frmReportSumary
    Public fRptCheckComing As frmRptCheckComing
    Public fRptCheckComingByPerson As frmRptCheckComingByPerson
    Public fReportMonthlySumary As frmReportMonthlySumary
    Public fReportYearlySumary As frmReportYearlySumary
    Public fRptAllEmpWork As frmRptAllEmpWork
    Public fRptTimeSumAbsentLate As frmRptTimeSumAbsentLate
    Public fRptTimeTableByMonth As frmRptTimeTableByMonth
    Public fPrivilegeVal As frmPrivilegeVal
    Public fRptAllEmpWork_Detail As frmRptAllEmpWork_Detail
    Public fRptTimeWorkSumary_Config As frmRptTimeWorkSumary_Config
    Public fRptTimeWorkSumary As frmRPTTimeworkSumary
    Public fRPT_TimeAbsent As frmRPTTimeAbsent
    Public fRPT_TimeAbsent_Config As frmRptTimeAbsent_Config
    Public fRPT_TimeAbLate As frmRPTTimeAbsLate
    Public fRPT_TimeAbsLate_Config As frmRptTimeAbsLate_Config
    Public fRPTMaxOT As frmRptMaxOT
    Public fRPT_SummarizeVacationByYear As frmRPTSummarizeVacationByYear
    Public fRPTSummarizeVacationByYear_Config As frmRPTSummarizeVacationByYear_Config
    Public fRPTTimeworkSumaryByWeek As frmRPTTimeworkSumaryByWeek
    Public fRPTEmpValAbsLateByDate As frmRPTEmpValAbsLateByDate
    Public fRPTSumaryWagePerDay As frmRPTSumaryWagePerDay
    Public fEmpOTDeducByDay As frmEmpOTDeducByDay
    Public fRpt_OTreport As frmRpt_OTreport
    Public fWorkSpecial As frmWorkSpecial  ' config ��˹��ѹ�ӧҹ�����


    ' import
    Public fImportEmpProfile As frmImportEmpProfile

    'Permission
    Public fRightManagementControl As frmRightManagementControl
    'Public fUser As frmUser
    Public fSetUserLogIn As frmSetUserLogIn
    Public fGenGroupMenuMasterHD As frmGenGroupMenuMasterHD
    Public fGenMenuMaster As frmGenMenuMaster
    Public fPermission As frmPermission



    ' Report
    Public ReportPrint As Report

    ' Picture
    Public ImageFullScreen As Drawing.Image

    ' List From
    Public ListCompetitorControl As TextBox
    Public ListCalendarControl As TextBox
    Public ListlblCompetitorNameControl As Label

    ' PassData
    Public PayWorningMaxId As Integer = 0

    Public ListEmp As Emp

    Public Enum Report
        PrintOTSheet
        PrintTimeWork
        PrintTimeWork_Detail
        PrintTimeWork_Detail2
        PrintOvertime
        PrintAllowance
        PrintSumary
        PringCheckComing
        PringCheckComingByPerson
        PrintMonthlySumary
        PrintYearlySumary
        PrintSumAbsLateByMonth
        PrintTimeTableByMonth
        PrintTimeworkSumary
        PrintTimeAbsent
        PrintTimeAbsLate
        PrintMaxOT
        PrintSummarizeVacationByYear1
        PrintSummarizeVacationByYear2
        PrintEmpValAbsLateByDate
        PrintAbsentByEmp
        PrintSumaryWagePerDay
        Print_OTReport

    End Enum

    Public Enum ListTeacherFrom
        PayTerm
    End Enum

    Public Enum TypeMaterial
        Cut = 0
        Sew = 1
        Decorate = 2
    End Enum

    Public Enum FormatDateType
        None
        ToPS
        ToKS
    End Enum

    Public Enum Emp
        Permission
    End Enum


    'Sub Main()
    '    Dim fLogin As New frmLogin
    '    Application.Run(fLogin)
    '    fLogin.txtUserName.Focus()
    '    If PassLogin = True Then
    '        Dim fMain As New frmMainMenu
    '        Application.Run(fMain)
    '    End If
    'End Sub

    Public Function ConnectDatabaseServer(ByVal UserName As String, ByVal Password As String, ByVal Server As String) As Boolean
        Try
            'Conn.ConnectionString = "DSN=Garment;Uid=" & UserName & ";Pwd=" & Password & ";"
            Conn.ConnectionString = "Server=" & Server.Trim & ";Database=Payroll;User ID=" & UserName.Trim & ";Password=" & Password.Trim & ";"
            Conn.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try
        'Conn.ConnectionString = "Server=NoteBook_Indra;Database=Garment;User ID=SA;Password=SYSTEM;"
        'Conn.ConnectionString = "Server=COMPAQ2005;Database=Garment;User ID=SA;Password=SYSTEM;"
    End Function

    ' Mark Check
    'Public Sub OpenConnect(ByVal OpenCn As Boolean)
    '    If OpenCn = True Then
    '        If Conn.State = ConnectionState.Open = False Then
    '            ConnectDatabaseServer(sysUsername, sysPassword, sysServer)
    '        End If
    '    Else
    '        Conn.Close()
    '    End If
    'End Sub

    Public Function AutoId(ByVal FieldId As String, ByVal Table As String) As Integer
        Dim Str As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Str = "Select Isnull(Max(" & FieldId & "),0) + 1 as MaxId From " & Table
        Da = New SqlDataAdapter(Str, Conn)
        Da.Fill(Ds, "MaxId")
        If Ds.Tables("MaxId").Rows.Count = 0 Then
            Return 1
        Else
            Return Ds.Tables("MaxId").Rows(0).Item("MaxId")
        End If
        Ds.Clear()
    End Function

    Public Function ConvertDate(ByVal Date_ As String) As String
        'If InStr(Date_, "/", CompareMethod.Text) = 0 Then
        '    Date_ = Mid(Date_, 1, 2) & "/" & Mid(Date_, 3, 2) & "/" & Mid(Date_, 5, 4)
        'End If
        If Right(Microsoft.VisualBasic.Left(Date_, 3), 1) = "/" Then ' �ѹ/��͹/��
            ConvertDate = Microsoft.VisualBasic.Right(Date_, 4) & "/" & Microsoft.VisualBasic.Right(Left(Date_, 5), 2) & "/" & Microsoft.VisualBasic.Left(Date_, 2)
        Else
            ConvertDate = Microsoft.VisualBasic.Right(Date_, 2) & "/" & Microsoft.VisualBasic.Right(Left(Date_, 7), 2) & "/" & Microsoft.VisualBasic.Left(Date_, 4)
        End If
    End Function

    Public Sub ClearAllText(ByVal Act As Form)
        Dim Contrl As Control
        Dim i As Int16
        For Each Contrl In Act.Controls
            If (TypeOf Contrl Is Control) And Contrl.Controls.Count > 0 Then
                For i = 0 To Contrl.Controls.Count - 1
                    If (TypeOf Contrl.Controls.Item(i) Is TextBox) Or _
                        (TypeOf Contrl.Controls.Item(i) Is ComboBox) Then
                        Contrl.Controls.Item(i).Text = ""
                    End If
                Next
            End If
        Next Contrl
    End Sub
    Function NullText(ByVal Ob As Object) As String
        If IsDBNull(Ob) Then
            NullText = ""
        Else
            NullText = Ob
        End If
    End Function
    Function NullDate(ByVal Ob As Object) As Date
        If IsDBNull(Ob) Then
            NullDate = DateAdd(DateInterval.Year, 543, Date.Now.Date)
        Else
            NullDate = DateAdd(DateInterval.Year, 543, CDate(Format(Ob, "yyyy/MM/dd")))
        End If
    End Function

    Function ConvertDateType(ByVal DateTime As Date, ByVal DateFormat As FormatDateType) As Date
        If DateFormat = FormatDateType.ToKS Then
            Return DateAdd(DateInterval.Year, -543, DateTime)
        ElseIf DateFormat = FormatDateType.ToPS Then
            Return DateAdd(DateInterval.Year, 543, DateTime)
        Else
            Return DateTime
        End If
    End Function

    Function MonthEnd(ByVal DateTime As Date) As Date
        Dim strDate As String
        strDate = Format(DateTime, "yyyy/MM/dd")
        strDate = Mid(strDate, 1, 8) & "01"
        Return DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, CDate(strDate)))
    End Function

    Function YearName(ByVal obj As Object) As String
        '---- 2Lang 28/03/2013 -----

        Return MsgManager.ShowLabel(obj, "MonthLang", "Year")

    End Function

    Function MonthName(ByVal obj As Object, ByVal intMonth As Integer) As String
        '---- 2Lang 28/03/2013 -----
        Select Case intMonth
            Case 1
                Return MsgManager.ShowLabel(obj, "MonthLang", "M1")
            Case 2
                Return MsgManager.ShowLabel(obj, "MonthLang", "M2")
            Case 3
                Return MsgManager.ShowLabel(obj, "MonthLang", "M3")
            Case 4
                Return MsgManager.ShowLabel(obj, "MonthLang", "M4")
            Case 5
                Return MsgManager.ShowLabel(obj, "MonthLang", "M5")
            Case 6
                Return MsgManager.ShowLabel(obj, "MonthLang", "M6")
            Case 7
                Return MsgManager.ShowLabel(obj, "MonthLang", "M7")
            Case 8
                Return MsgManager.ShowLabel(obj, "MonthLang", "M8")
            Case 9
                Return MsgManager.ShowLabel(obj, "MonthLang", "M9")
            Case 10
                Return MsgManager.ShowLabel(obj, "MonthLang", "M10")
            Case 11
                Return MsgManager.ShowLabel(obj, "MonthLang", "M11")
            Case 12
                Return MsgManager.ShowLabel(obj, "MonthLang", "M12")
            Case Else
                Return ""
        End Select
    End Function

    Function MonthNameThai(ByVal intMonth As Integer) As String
        Select Case intMonth
            Case 1
                Return "January"
            Case 2
                Return "February"
            Case 3
                Return "March"
            Case 4
                Return "April"
            Case 5
                Return "May"
            Case 6
                Return "June"
            Case 7
                Return "July"
            Case 8
                Return "August"
            Case 9
                Return "September"
            Case 10
                Return "October"
            Case 11
                Return "November"
            Case 12
                Return "December"
            Case Else
                Return ""
        End Select
    End Function

    Function MonthNameThaiLang(ByVal intMonth As Integer) As String
        Select Case intMonth
            Case 1
                Return "���Ҥ�"
            Case 2
                Return "����Ҿѹ��"
            Case 3
                Return "�չҤ�"
            Case 4
                Return "����¹"
            Case 5
                Return "����Ҥ�"
            Case 6
                Return "�Զع�¹"
            Case 7
                Return "�á�Ҥ�"
            Case 8
                Return "�ԧ�Ҥ�"
            Case 9
                Return "�ѹ��¹"
            Case 10
                Return "���Ҥ�"
            Case 11
                Return "��Ȩԡ�¹"
            Case 12
                Return "�ѹ�Ҥ�"
            Case Else
                Return ""
        End Select
    End Function

    Function GetSrtDayOfWeek(ByVal Dw As Integer) As String
        Select Case Dw
            Case 0
                Return "��."
            Case 1
                Return "�."
            Case 2
                Return "�"
            Case 3
                Return "�."
            Case 4
                Return "��."
            Case 5
                Return "�."
            Case 6
                Return "�."
            Case Else
                Return ""
        End Select
    End Function

    Function ConvertMonthNameThaiLang(ByVal intMonth As String) As String
        Select Case intMonth
            Case "���Ҥ�"
                Return "1"
            Case "����Ҿѹ��"
                Return "2"
            Case "�չҤ�"
                Return "3"
            Case "����¹"
                Return "4"
            Case "����Ҥ�"
                Return "5"
            Case "�Զع�¹"
                Return "6"
            Case "�á�Ҥ�"
                Return "7"
            Case "�ԧ�Ҥ�"
                Return "8"
            Case "�ѹ��¹"
                Return "9"
            Case "���Ҥ�"
                Return "10"
            Case "��Ȩԡ�¹"
                Return "11"
            Case "�ѹ�Ҥ�"
                Return "12"
            Case Else
                Return ""
        End Select
    End Function

    Function RightText(ByVal Text As String, ByVal Length As Integer) As String
        Return Right(Text, Length)
    End Function

    Function LeftText(ByVal Text As String, ByVal Length As Integer) As String
        Return Left(Text, Length)
    End Function

    Function GetDayMonth(ByVal Month As String, ByVal Year As String) As ArrayList
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim ar As New ArrayList
        strSQL = "Exec spDateSTSPMonth '" & Month.Trim & "','" & Year.Trim & "'"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                ar.Clear()
                ar.Add("")
                ar.Add("")
            Else
                Dim dr As DataRow = .Rows(0)
                ar.Clear()
                ar.Add(dr("DateST"))
                ar.Add(dr("DateSP"))
            End If
            Return ar
        End With
    End Function


    Function GetTextType() As Integer
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "select GetText from mainconfig"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 1
            Else
                If IsDBNull(.Rows(0).Item("GetText")) = True Then
                    Return 1
                Else
                    Return .Rows(0).Item("GetText")
                End If
            End If
        End With
    End Function

    Function GetCompanyName() As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select CompanyName from Company"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                If IsDBNull(.Rows(0).Item("CompanyName")) = True Then
                    Return ""
                Else
                    Return .Rows(0).Item("CompanyName")
                End If
            End If
        End With
    End Function

    Public Function fCheckSerial() As String
        Dim snstr As Object = Nothing
        Dim retval As Object = Nothing
        Dim sysflags As Object = Nothing
        Dim maxcomplen As Object = Nothing
        Dim sn As Object = Nothing
        Dim sysname As Object = Nothing
        Dim volname As Object = Nothing

        volname = Space(256)
        sysname = Space(256)

        retval = GetVolumeInformation("C:\", volname, Len(volname), sn, maxcomplen, sysflags, sysname, Len(sysname))

        snstr = Trim(Hex(sn))

        fCheckSerial = snstr
    End Function

    Public Function Rep_Cote(ByVal Data As String) As String
        Return Replace(Data, "'", "''")
    End Function

    Public Structure setPermission
        'Declare data members
        Public Shared DailyUpdate As Boolean = False
        Public Shared ImportData As Boolean = False
        Public Shared Processingtime As Boolean = False
        Public Shared ManageTime As Boolean = False
        Public Shared SizeConfig As Boolean = False
        Public Shared Overtime As Boolean = False
        Public Shared LateTime As Boolean = False
        Public Shared absenceTime As Boolean = False
        Public Shared Allowance As Boolean = False
        Public Shared InputLeaveData As Boolean = False
        Public Shared Configuration As Boolean = False
        Public Shared modelcalculations As Boolean = False
        Public Shared DeterminedTimeEmp As Boolean = False
        Public Shared RptSumaryByYear As Boolean = False

        Public Shared workinggroup As Boolean = False
        Public Shared DeterminedTime As Boolean = False
        Public Shared DeterminedTimeEmpByOne As Boolean = False
        Public Shared DeterminedTimeEmpByDate As Boolean = False
        Public Shared setBarcode As Boolean = False
        Public Shared ProcessOT As Boolean = False
        Public Shared calculationLate As Boolean = False
        Public Shared calculationBreak As Boolean = False
        Public Shared Setholiday As Boolean = False
        Public Shared SetLeave As Boolean = False
        Public Shared SetabsenceTimeByYear As Boolean = False
        Public Shared setconditionsLate As Boolean = False
        Public Shared conditionslate As Boolean = False
        Public Shared conditionslatesomeone As Boolean = False
        Public Shared conditionslatebyRate As Boolean = False
        Public Shared setOT As Boolean = False
        Public Shared setdelaytime As Boolean = False
        Public Shared setdelayOT As Boolean = False
        Public Shared setovertimepay As Boolean = False
        Public Shared setAllowance As Boolean = False
        Public Shared LinkCodePayroll As Boolean = False
        Public Shared Report As Boolean = False
        Public Shared rptTimeWork As Boolean = False
        Public Shared rptTimeWorkLateByOne As Boolean = False
        Public Shared rptTimeSheet As Boolean = False
        Public Shared rptAllemployeework As Boolean = False
        Public Shared rptEmployeework As Boolean = False
        Public Shared rptEmpWorkDetail1 As Boolean = False
        Public Shared rptEmpWorkDetail2 As Boolean = False
        Public Shared rptOT As Boolean = False
        Public Shared rptSumaryMonth As Boolean = False
        Public Shared rptScheduleWorkAllEmp As Boolean = False
        Public Shared SummaryScheduleWorkAllEmp As Boolean = False
        Public Shared ConfigSummaryScheduleWorkAllEmp As Boolean = False
        Public Shared rptSummaryScheduleWorkAllEmp As Boolean = False
        Public Shared EmpNotWork As Boolean = False
        Public Shared ConfigEmpNotWork As Boolean = False
        Public Shared rptEmpNotWork As Boolean = False
        Public Shared rptemployeeByDate As Boolean = False
        Public Shared Sumaryemployee As Boolean = False
        Public Shared ConfogSumaryemployee As Boolean = False
        Public Shared rptSumaryemployee As Boolean = False
        Public Shared rptMaximumOThoursdaysweeksyear As Boolean = False
        Public Shared rptNormalworkinghoursOTByWeek As Boolean = False
        Public Shared SumaryHolidayInYears As Boolean = False
        Public Shared ConfigSumaryHolidayInYears As Boolean = False
        Public Shared rptSumaryHolidayInYears As Boolean = False
        Public Shared prtAllowance As Boolean = False
        Public Shared RptSumary As Boolean = False
        Public Shared RptSumaryByMonth As Boolean = False
        Public Shared Windows As Boolean = False
        Public Shared Permission As Boolean = False
        Public Shared ConfigPermission As Boolean = False
        Public Shared Exitx As Boolean = False
        Public Shared TimeWork As Boolean = False
        Public Shared rptrptSumaryMonthLateByBath As Boolean = False

        ' ReadOnly
        Public Shared PermissionTimeAtt_ReadOnly As Boolean = True  ' ���� �����ż����ҷӧҹ
        Public Shared ManageTime_ReadOnly As Boolean = True   ' ���� ���� / ������ҷӧҹ

        Public a As Integer
    End Structure


End Module
