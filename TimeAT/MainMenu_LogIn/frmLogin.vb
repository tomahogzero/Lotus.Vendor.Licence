Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class frmLogin
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnLogin = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtServer = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(76, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Name : "
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(148, 10)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(198, 20)
        Me.txtUserName.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(148, 36)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(198, 20)
        Me.txtPassword.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(76, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password : "
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Wheat
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.Location = New System.Drawing.Point(2, 92)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(233, 54)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Wheat
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(237, 92)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(114, 54)
        Me.btnExit.TabIndex = 4
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PowderBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.txtUserName)
        Me.Panel1.Controls.Add(Me.txtServer)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(349, 88)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 60)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(148, 62)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(198, 20)
        Me.txtServer.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(76, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Server : "
        '
        'frmLogin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(352, 148)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadDefaultLogIn()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If ConnectDatabaseServer(txtUserName.Text.Trim, txtPassword.Text.Trim, txtServer.Text.Trim) = False Then
            MsgBox("Username & Password ���١��ͧ", MsgBoxStyle.Information, "LogIn")
            PassLogin = False
            Exit Sub
        End If
        cUsername = txtUserName.Text.Trim
        cPassword = txtPassword.Text.Trim
        Server = txtServer.Text.Trim
        Call SaveDefaultLogIn(Server, cUsername)
        PassLogin = True
        Call LoadPermission(cUsername.Trim)

        If cUsername <> "sa" Then
            Call CheckViewCompany()
        End If
        Me.Close()
    End Sub

    Private Sub CheckViewCompany()
        Dim strSQL As String = ""
        Dim dCmd As New SqlCommand
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet

        strSQL = " Select ViewCompany from MainConfig "
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")

        With Ds.Tables("Data")
            Dim CheckView As String = .Rows(0).Item("ViewCompany")
            CView = .Rows(0).Item("ViewCompany")
            If CheckView = True Then
                Try
                    'If fConfigViewCompany Is Nothing Then
                    '    fConfigViewCompany = New frmConfigViewCompany
                    'Else
                    '    If fConfigViewCompany.IsDisposed = True Then
                    '        fConfigViewCompany = New frmConfigViewCompany
                    '    End If
                    'End If
                    'fConfigViewCompany.StartPosition = FormStartPosition.CenterParent
                    'fConfigViewCompany.ShowDialog()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
                End Try
            End If
        End With
    End Sub

    Private Sub txtUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserName.TextChanged

    End Sub

    Private Sub txtUserName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtServer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtServer.KeyPress
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub frmLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        txtUserName.Focus()
    End Sub

    Private Sub LoadDefaultLogIn()
        Dim FileName As String
        Dim Rec As Integer = 0
        On Error GoTo Err
        FileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Default.INI"
        If System.IO.File.Exists(FileName) Then
            Dim Sr As New System.IO.StreamReader(FileName)
            Do While Sr.Peek() >= 0
                If Rec = 0 Then
                    txtServer.Text = Sr.ReadLine()
                ElseIf Rec = 1 Then
                    txtUserName.Text = Sr.ReadLine()
                End If
                Rec += 1
            Loop
            Sr.Close()
        End If
        Exit Sub

Err:
        MessageBox.Show(Err.Number & " " & Err.Description)
    End Sub

    Private Sub SaveDefaultLogIn(ByVal ServerName As String, ByVal Username As String)
        Dim FileName As String
        On Error GoTo Err
        FileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Default.INI"
        If Not System.IO.File.Exists(FileName) Then
            Dim file As New System.IO.StreamWriter(FileName, True)
            file.WriteLine(ServerName)
            file.WriteLine(Username)
            file.Close()
        Else
            System.IO.File.Delete(FileName)
            Dim file As New System.IO.StreamWriter(FileName, True)
            file.WriteLine(ServerName)
            file.WriteLine(Username)
            file.Close()
        End If
        Exit Sub
Err:
        MessageBox.Show(Err.Number & " " & Err.Description)
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


        strSQL = "select sp.* " & _
                      " from PermissionTimeAtt sp inner join [user] u " & _
                                  " on sp.idcode = u.UserID " & _
                      " where u.username = '" & Username.Trim & "'"
        Try
            Dim c As New db
            c.ExecuteCommand(Conn, dCmd, strSQL)
            Da.SelectCommand = dCmd
            Da.Fill(Ds, "data")

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

End Class

