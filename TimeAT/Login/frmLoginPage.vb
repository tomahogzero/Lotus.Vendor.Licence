Imports TimeAttendance.utils
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Threading.Thread
Imports System.Configuration
Imports System.Threading


Public Class frmLoginPage

    Dim dbMgr As New DBManager

    Sub New()
        'Select Case cValGolbal.Lang
        '    Case "TH"  '-- Thai
        '        CurrentThread.CurrentCulture = New CultureInfo("th-TH")
        '        CurrentThread.CurrentUICulture = New CultureInfo("th-TH")
        '    Case "EN"  '-- English
        '        CurrentThread.CurrentCulture = New CultureInfo("en-US")
        '        CurrentThread.CurrentUICulture = New CultureInfo("en-US")
        'End Select

        ' This call is required by the designer.
        InitializeComponent()

        'If constdef.cLanguage.Language = "MULTI" Then
        '    lblLang.Visible = True
        '    cboLang.Visible = True

        '    Dim s As New Size
        '    s.Width = Me.Width
        '    s.Height = 248
        '    Me.Size = s
        'Else
        '    lblLang.Visible = False
        '    cboLang.Visible = False
        '    Dim s As New Size
        '    s.Width = Me.Width
        '    s.Height = 219
        '    Me.Size = s
        'End If

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        Dim db As New DBManager

        Select Case cboLang.SelectedIndex
            Case 0  '-- Thai
                CurrentThread.CurrentCulture = New CultureInfo("th-TH")
                CurrentThread.CurrentUICulture = New CultureInfo("th-TH")
                cValGolbal.Lang = "TH"
            Case 1  '-- English
                CurrentThread.CurrentCulture = New CultureInfo("en-US")
                CurrentThread.CurrentUICulture = New CultureInfo("en-US")
                cValGolbal.Lang = "EN"
        End Select

        cValGolbal.selCultureInfo = CurrentThread.CurrentUICulture

        If txtPassword.Text.Trim = "" Then
            MsgBox("กรุณาป้อน Password ด้วย", MsgBoxStyle.Information, Me.Text)
            'MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblPassword.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtPassword.Focus()
            Exit Sub
        End If

        If txtUsername.Text.Trim = sysUsername.Trim And
        txtPassword.Text.Trim = sysPassword.Trim Then
            'MainMenu
            U_Username = "sa"
            Call SaveDefaultUserlogin()
            Call LoadPermission("sa")
            LogUserPass = True
            Me.Close()
            Exit Sub
        End If


        ' If UserLogIn(txtUserName.Text.Trim, _
        '  dbMgr.getEncryptStr(txtPassword.Text.Trim)) = True Then
        If UserLogIn(txtUsername.Text.Trim,
               dbMgr.getEncryptStr(txtPassword.Text.Trim)) = True Then
            Call SaveDefaultUserlogin()
            '  Call LoadPermission(txtUserName.Text.Trim)
            LogUserPass = True
            Me.Close()
            Exit Sub
        Else

            'MsgBox("คุณไม่มีสิทธิ์เข้าใจโปรแกรม อาจเป็นเพราะ Username หรือ Password ไม่ถูกต้อง", MsgBoxStyle.Information, Me.Text)
            MsgBox(My.Resources.res_warning_message_spacial.login_user_password_fail, MsgBoxStyle.Information, Me.Text)
            txtUsername.Focus()
            Exit Sub
        End If


        'If ChkGenPermision(IDUser.Trim) = False Then
        '    MsgBox("เนื่องจากยังไม่มีการกำหนสิทธิ์การใช้เมนู" & Chr(10) & _
        '           " จึงไม่สามารถเข้าระบบได้ กรุณาแจ้งผู้ดูแล", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "แจ้งให้ทราบ")
        '    Exit Sub
        'End If

    End Sub

    Private Sub LoadPermission(ByVal Username As String)

        Dim strSQL As String = ""
        Dim dCmd As New SqlCommand
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet

        If Username.Trim = "sa" Then
            setPermission.DailyUpdate = True
            setPermission.ImportData = True
            setPermission.Processingtime = True
            setPermission.ManageTime = True
            setPermission.SizeConfig = True
            setPermission.Overtime = True
            setPermission.LateTime = True
            setPermission.absenceTime = True
            setPermission.Allowance = True
            setPermission.InputLeaveData = True
            setPermission.Configuration = True
            setPermission.modelcalculations = True
            setPermission.workinggroup = True
            setPermission.DeterminedTime = True
            setPermission.DeterminedTimeEmpByOne = True
            setPermission.DeterminedTimeEmpByDate = True
            setPermission.setBarcode = True
            setPermission.ProcessOT = True
            setPermission.calculationLate = True
            setPermission.calculationBreak = True
            setPermission.Setholiday = True
            setPermission.SetLeave = True
            setPermission.SetabsenceTimeByYear = True
            setPermission.setconditionsLate = True
            setPermission.conditionslate = True
            setPermission.conditionslatesomeone = True
            setPermission.conditionslatebyRate = True
            setPermission.setOT = True
            setPermission.setdelaytime = True
            setPermission.setdelayOT = True
            setPermission.setovertimepay = True
            setPermission.setAllowance = True
            setPermission.LinkCodePayroll = True
            setPermission.Report = True
            setPermission.rptTimeWork = True
            setPermission.rptTimeWorkLateByOne = True
            setPermission.rptTimeSheet = True
            setPermission.rptAllemployeework = True
            setPermission.rptEmployeework = True
            setPermission.rptEmpWorkDetail1 = True
            setPermission.rptEmpWorkDetail2 = True
            setPermission.rptOT = True
            setPermission.rptSumaryMonth = True
            setPermission.rptScheduleWorkAllEmp = True
            setPermission.SummaryScheduleWorkAllEmp = True
            setPermission.ConfigSummaryScheduleWorkAllEmp = True
            setPermission.rptSummaryScheduleWorkAllEmp = True
            setPermission.EmpNotWork = True
            setPermission.ConfigEmpNotWork = True
            setPermission.rptEmpNotWork = True
            setPermission.rptemployeeByDate = True
            setPermission.Sumaryemployee = True
            setPermission.ConfogSumaryemployee = True
            setPermission.rptSumaryemployee = True
            setPermission.rptMaximumOThoursdaysweeksyear = True
            setPermission.rptNormalworkinghoursOTByWeek = True
            setPermission.SumaryHolidayInYears = True
            setPermission.ConfigSumaryHolidayInYears = True
            setPermission.rptSumaryHolidayInYears = True
            setPermission.prtAllowance = True
            setPermission.prtAllowance = True
            setPermission.RptSumaryByMonth = True
            setPermission.Windows = True

            setPermission.Permission = True
            setPermission.ConfigPermission = True
            setPermission.RptSumaryByYear = True
            setPermission.Exitx = True
            setPermission.TimeWork = True
            setPermission.rptrptSumaryMonthLateByBath = True
            setPermission.DeterminedTimeEmp = True


            'ReadOnly
            setPermission.ManageTime_ReadOnly = True
            setPermission.PermissionTimeAtt_ReadOnly = True
            Exit Sub
        End If


        strSQL = "select sp.* " &
                      " from PermissionTimeAtt sp inner join [user] u " &
                                  " on sp.idcode = u.UserID " &
                      " where u.username = '" & Username.Trim & "'"
        Try
            Dim c As New db
            'Call OpenConnect(True)
            c.ExecuteCommand(Conn, dCmd, strSQL)
            Da.SelectCommand = dCmd
            Da.Fill(Ds, "data")
            'Call OpenConnect(False)

            With Ds.Tables("data")
                If .Rows.Count = 0 Then
                    setPermission.DailyUpdate = False
                    setPermission.ImportData = False
                    setPermission.ImportData = False
                    setPermission.ManageTime = False
                    setPermission.Overtime = False
                    setPermission.LateTime = False
                    setPermission.absenceTime = False
                    setPermission.Allowance = False
                    setPermission.InputLeaveData = False
                    setPermission.Configuration = False
                    setPermission.modelcalculations = False
                    setPermission.workinggroup = False
                    setPermission.DeterminedTime = False
                    setPermission.DeterminedTimeEmpByOne = False
                    setPermission.DeterminedTimeEmpByDate = False
                    setPermission.setBarcode = False
                    setPermission.ProcessOT = False
                    setPermission.setdelayOT = False
                    setPermission.calculationLate = False
                    setPermission.calculationBreak = False
                    setPermission.Setholiday = False
                    setPermission.SetLeave = False
                    setPermission.SetabsenceTimeByYear = False
                    setPermission.setconditionsLate = False
                    setPermission.conditionslate = False
                    setPermission.conditionslatesomeone = False
                    setPermission.conditionslatebyRate = False
                    setPermission.setOT = False
                    setPermission.setdelaytime = False
                    setPermission.setovertimepay = False
                    setPermission.setAllowance = False
                    setPermission.LinkCodePayroll = False
                    setPermission.Report = False
                    setPermission.rptTimeWork = False
                    setPermission.rptTimeWorkLateByOne = False
                    setPermission.rptTimeSheet = False
                    setPermission.Permission = False
                    setPermission.rptAllemployeework = False
                    setPermission.rptEmployeework = False
                    setPermission.rptEmpWorkDetail1 = False
                    setPermission.rptEmpWorkDetail2 = False
                    setPermission.rptOT = False

                    setPermission.rptSumaryMonth = False
                    setPermission.RptSumaryByYear = False
                    setPermission.rptScheduleWorkAllEmp = False
                    setPermission.SummaryScheduleWorkAllEmp = False
                    setPermission.ConfigSummaryScheduleWorkAllEmp = False
                    setPermission.rptSummaryScheduleWorkAllEmp = False
                    setPermission.EmpNotWork = False
                    setPermission.ConfigEmpNotWork = False
                    setPermission.rptEmpNotWork = False
                    setPermission.rptemployeeByDate = False
                    setPermission.Sumaryemployee = False
                    setPermission.ConfogSumaryemployee = False
                    setPermission.rptSumaryemployee = False
                    setPermission.rptMaximumOThoursdaysweeksyear = False
                    setPermission.rptNormalworkinghoursOTByWeek = False
                    setPermission.SumaryHolidayInYears = False
                    setPermission.ConfigSumaryHolidayInYears = False
                    setPermission.rptSumaryHolidayInYears = False
                    setPermission.prtAllowance = False
                    setPermission.RptSumary = False
                    setPermission.RptSumaryByMonth = False

                    setPermission.Windows = False
                    setPermission.Permission = False
                    setPermission.ConfigPermission = False

                    setPermission.Exitx = False
                    setPermission.TimeWork = False
                    setPermission.rptrptSumaryMonthLateByBath = False
                    setPermission.DeterminedTimeEmp = False


                    'ReadOnly
                    setPermission.PermissionTimeAtt_ReadOnly = False
                    setPermission.ManageTime_ReadOnly = False
                Else
                    Dim dr As DataRow = .Rows(0)
                    setPermission.DailyUpdate = dr("DailyUpdate")
                    setPermission.ImportData = dr("ImportData")
                    setPermission.Processingtime = dr("Processingtime")
                    setPermission.ManageTime = dr("ManageTime")
                    setPermission.Overtime = dr("Overtime")
                    setPermission.LateTime = dr("LateTime")
                    setPermission.absenceTime = dr("absenceTime")
                    setPermission.Allowance = dr("Allowance")
                    setPermission.InputLeaveData = dr("InputLeaveData")
                    setPermission.Configuration = dr("Configuration")
                    setPermission.modelcalculations = dr("modelcalculations")
                    setPermission.workinggroup = dr("workinggroup")
                    setPermission.DeterminedTime = dr("DeterminedTime")
                    setPermission.DeterminedTimeEmpByOne = dr("DeterminedTimeEmpByOne")
                    setPermission.DeterminedTimeEmpByDate = dr("DeterminedTimeEmpByDate")
                    setPermission.setBarcode = dr("setBarcode")
                    setPermission.ProcessOT = dr("ProcessOT")
                    setPermission.calculationLate = dr("calculationLate")
                    setPermission.calculationBreak = dr("calculationBreak")
                    setPermission.Setholiday = dr("Setholiday")
                    setPermission.SetLeave = dr("SetLeave")
                    setPermission.SetabsenceTimeByYear = dr("SetabsenceTimeByYear")
                    setPermission.setconditionsLate = dr("setconditionsLate")
                    setPermission.conditionslate = dr("conditionslate")
                    setPermission.conditionslatesomeone = dr("conditionslatesomeone")
                    setPermission.conditionslatebyRate = dr("conditionslatebyRate")
                    setPermission.setOT = dr("setOT")
                    setPermission.setdelayOT = dr("setdelayOT")
                    setPermission.setdelaytime = dr("setdelaytime")
                    setPermission.setdelaytime = dr("setdelaytime")
                    setPermission.setovertimepay = dr("setovertimepay")
                    setPermission.setAllowance = dr("setAllowance")
                    setPermission.LinkCodePayroll = dr("LinkCodePayroll")
                    setPermission.Report = dr("Report")
                    setPermission.rptTimeWork = dr("rptTimeWork")
                    setPermission.rptTimeWorkLateByOne = dr("rptTimeWorkLateByOne")
                    setPermission.rptTimeSheet = dr("rptTimeSheet")
                    setPermission.Permission = dr("Permission")
                    setPermission.rptAllemployeework = dr("rptAllemployeework")
                    setPermission.rptEmployeework = dr("rptEmployeework")
                    setPermission.rptEmpWorkDetail1 = dr("rptEmpWorkDetail1")
                    setPermission.rptEmpWorkDetail2 = dr("rptEmpWorkDetail2")
                    setPermission.rptOT = dr("rptOT")
                    setPermission.rptSumaryMonth = dr("rptSumaryMonth")
                    setPermission.rptScheduleWorkAllEmp = dr("rptScheduleWorkAllEmp")
                    setPermission.SummaryScheduleWorkAllEmp = dr("SummaryScheduleWorkAllEmp")
                    setPermission.ConfigSummaryScheduleWorkAllEmp = dr("ConfigSummaryScheduleWorkAllEmp")
                    setPermission.rptSummaryScheduleWorkAllEmp = dr("rptSummaryScheduleWorkAllEmp")
                    setPermission.EmpNotWork = dr("EmpNotWork")
                    setPermission.ConfigEmpNotWork = dr("ConfigEmpNotWork")
                    setPermission.rptEmpNotWork = dr("rptEmpNotWork")
                    setPermission.rptemployeeByDate = dr("rptemployeeByDate")
                    setPermission.Sumaryemployee = dr("Sumaryemployee")
                    setPermission.ConfogSumaryemployee = dr("ConfogSumaryemployee")
                    setPermission.rptSumaryemployee = dr("rptSumaryemployee")
                    setPermission.rptMaximumOThoursdaysweeksyear = dr("rptMaximumOThoursdaysweeksyear")
                    setPermission.rptNormalworkinghoursOTByWeek = dr("rptNormalworkinghoursOTByWeek")
                    setPermission.SumaryHolidayInYears = dr("SumaryHolidayInYears")
                    setPermission.ConfigSumaryHolidayInYears = dr("ConfigSumaryHolidayInYears")
                    setPermission.rptSumaryHolidayInYears = dr("rptSumaryHolidayInYears")
                    setPermission.prtAllowance = dr("prtAllowance")
                    setPermission.RptSumary = dr("RptSumary")
                    setPermission.RptSumaryByMonth = dr("RptSumaryByMonth")

                    setPermission.Windows = dr("Windows")
                    setPermission.Permission = dr("Permission")
                    setPermission.ConfigPermission = dr("ConfigPermission")
                    setPermission.Exitx = dr("Exitx")
                    setPermission.TimeWork = dr("TimeWork")
                    setPermission.rptrptSumaryMonthLateByBath = dr("rptrptSumaryMonthLateByBath")
                    setPermission.DeterminedTimeEmp = dr("DeterminedTimeEmp")
                    setPermission.RptSumaryByYear = dr("RptSumaryByYear")

                    'ReadOnly
                    setPermission.PermissionTimeAtt_ReadOnly = dr("PermissionTimeAtt_ReadOnly")
                    setPermission.ManageTime_ReadOnly = dr("ManageTime_ReadOnly")


                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub


    Private Sub SaveDefaultUserlogin()
        Dim dbMgr As New DBManager
        Dim Config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

        ' UserName
        Config.AppSettings.Settings.Remove("dfUserName")
        Config.AppSettings.Settings.Add("dfUserName", txtUsername.Text.Trim)
        Config.AppSettings.Settings.Remove("DefaultCulture")
        Select Case cboLang.SelectedIndex
            Case 0
                Config.AppSettings.Settings.Add("DefaultCulture", "TH")
            Case 1
                Config.AppSettings.Settings.Add("DefaultCulture", "EN")
            Case Else
                Config.AppSettings.Settings.Add("DefaultCulture", "TH")
        End Select
        ' Modify/Refresh App Setting
        Config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("appSettings")
    End Sub

    Function UserLogIn(ByVal Username As String, ByVal Password As String) As Boolean
        '8?F:DA>:00(/
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList
        Dim db As New db
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim dCmd As New SqlCommand

        Try
            Data.Clear() : strType = ""
            Data.Add(Username.Trim) : strType &= "T"
            Data.Add(Password.Trim) : strType &= "T"


            strSQL = "Select Username,Password,UserId From [User]" &
                    " Where Username = @P1 and Password = @P2 "

            'Call OpenConnect(True)
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
            Da.SelectCommand = dCmd
            Da.Fill(Ds, "data")
            'Call OpenConnect(False)

            With Ds.Tables("data")
                If .Rows.Count = 0 Then
                    U_Username = ""
                    UserId = ""
                    Return False
                Else
                    Dim Dr As DataRow = .Rows(0)
                    U_Username = Dr("Username")
                    UserId = Dr("UserId")
                    Return True
                End If
            End With
        Catch ex As Exception
            ' MsgBox("รหัสผ่านไม่ถูกต้องกรุณาตรวจสอบอีกครั้ง", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "LogIn")
            'MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub frmLoginPage_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Call OpenConnect(False)
    End Sub


    Private Sub frmLoginPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Dim dbMgr As New DBManager

        txtUsername.Text = dbMgr.getdfUserName

        sysUsername = dbMgr.getUserName.Trim
        sysPassword = dbMgr.getPassword.Trim

        lblServerName.Text = dbMgr.getServerName

        Call loadLang()

        'Call OpenConnect(True)
        txtUsername.Focus()

    End Sub

    Private Sub loadLang()
        cboLang.Properties.Items.Add("ไทย")
        cboLang.Properties.Items.Add("English")

        If cValGolbal.Lang = "TH" Then
            cboLang.SelectedIndex = 0
        Else
            cboLang.SelectedIndex = 1
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'Call OpenConnect(False)
        Application.Exit()
    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtUserName_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtPassword.Focus()
            txtPassword.SelectAll()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) 
        MsgBox(GetData.encript_password(txtPassword.Text))
    End Sub
End Class