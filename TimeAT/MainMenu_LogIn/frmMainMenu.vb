Imports System.Data
Imports System.Data.SqlClient

Public Class frmMainMenu
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuImportData As System.Windows.Forms.MenuItem
    Friend WithEvents mnuConfiguration As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSetholiday As System.Windows.Forms.MenuItem
    Friend WithEvents mnucalculationBreak As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSetLeave As System.Windows.Forms.MenuItem
    Friend WithEvents mnusetovertimepay As System.Windows.Forms.MenuItem
    Friend WithEvents mnuconditionslate As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPermissionTimeAtt As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuManageTime As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOvertime As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLateTime As System.Windows.Forms.MenuItem
    Friend WithEvents mnuabsenceTime As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInputLeaveData As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAllowance As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReport As System.Windows.Forms.MenuItem
    Friend WithEvents mnurptTimeSheet As System.Windows.Forms.MenuItem
    Friend WithEvents mnurptSumaryMonth As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents mnurptOT As System.Windows.Forms.MenuItem
    Friend WithEvents mnuprtAllowance As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRptSumary As System.Windows.Forms.MenuItem
    Friend WithEvents mnusetAllowance As System.Windows.Forms.MenuItem
    Friend WithEvents mnurptTimeWork As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRptSumaryByMonth As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRptSumaryByYear As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDeterminedTime As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDeterminedTimeEmpByOne As System.Windows.Forms.MenuItem
    Friend WithEvents mnusetBarcode As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents mnurptTimeWorkLateByOne As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLinkCodePayroll As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDeterminedTimeEmp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDeterminedTimeEmpByDate As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTimeWork As System.Windows.Forms.MenuItem
    Friend WithEvents mnuworkinggroup As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents mnumodelcalculations As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuconditionslatesomeone As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWindows As System.Windows.Forms.MenuItem
    Friend WithEvents mnuProcessOT As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents mnucalculationLate As System.Windows.Forms.MenuItem
    Friend WithEvents mnurptAllemployeework As System.Windows.Forms.MenuItem
    Friend WithEvents mnurptrptSumaryMonthLateByBath As System.Windows.Forms.MenuItem
    Friend WithEvents mnurptScheduleWorkAllEmp As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSetabsenceTimeByYear As System.Windows.Forms.MenuItem
    Friend WithEvents mnusetOT As System.Windows.Forms.MenuItem
    Friend WithEvents mnusetdelayOT As System.Windows.Forms.MenuItem
    Friend WithEvents mnusetdelaytime As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    Friend WithEvents mnurptEmpWorkDetail1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSummaryScheduleWorkAllEmp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuConfigSummaryScheduleWorkAllEmp As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem60 As System.Windows.Forms.MenuItem
    Friend WithEvents mnurptSummaryScheduleWorkAllEmp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEmpNotWork As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSumaryemployee As System.Windows.Forms.MenuItem
    Friend WithEvents mnuConfigEmpNotWork As System.Windows.Forms.MenuItem
    Friend WithEvents mnurptEmpNotWork As System.Windows.Forms.MenuItem
    Friend WithEvents mnuConfogSumaryemployee As System.Windows.Forms.MenuItem
    Friend WithEvents mnurptSumaryemployee As System.Windows.Forms.MenuItem
    Friend WithEvents mnurptMaximumOThoursdaysweeksyear As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSumaryHolidayInYears As System.Windows.Forms.MenuItem
    Friend WithEvents mnuConfigSumaryHolidayInYears As System.Windows.Forms.MenuItem
    Friend WithEvents mnurptSumaryHolidayInYears As System.Windows.Forms.MenuItem
    Friend WithEvents mnurptNormalworkinghoursOTByWeek As System.Windows.Forms.MenuItem
    Friend WithEvents mnusetconditionsLate As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem62 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuconditionslatebyRate As System.Windows.Forms.MenuItem
    Friend WithEvents mnurptemployeeByDate As System.Windows.Forms.MenuItem
    Friend WithEvents mnurptEmployeework As System.Windows.Forms.MenuItem
    Friend WithEvents mnurptEmpWorkDetail2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPermission As System.Windows.Forms.MenuItem
    Friend WithEvents mnuConfigPermission As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSetCancelDelayOTByDay As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSumaryWagePerDay As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOTbyDay As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuWorkHolidaySpacial As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents mnucalculationAbs As System.Windows.Forms.MenuItem
    Friend WithEvents TimeKaMove As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDailyUpdate As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuDailyUpdate = New System.Windows.Forms.MenuItem
        Me.mnuImportData = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.mnuPermissionTimeAtt = New System.Windows.Forms.MenuItem
        Me.mnuManageTime = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.mnuOvertime = New System.Windows.Forms.MenuItem
        Me.mnuLateTime = New System.Windows.Forms.MenuItem
        Me.mnuabsenceTime = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.mnuAllowance = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.mnuInputLeaveData = New System.Windows.Forms.MenuItem
        Me.mnuConfiguration = New System.Windows.Forms.MenuItem
        Me.mnumodelcalculations = New System.Windows.Forms.MenuItem
        Me.MenuItem46 = New System.Windows.Forms.MenuItem
        Me.mnuTimeWork = New System.Windows.Forms.MenuItem
        Me.mnuworkinggroup = New System.Windows.Forms.MenuItem
        Me.MenuItem44 = New System.Windows.Forms.MenuItem
        Me.mnuDeterminedTime = New System.Windows.Forms.MenuItem
        Me.mnuDeterminedTimeEmp = New System.Windows.Forms.MenuItem
        Me.mnuDeterminedTimeEmpByOne = New System.Windows.Forms.MenuItem
        Me.mnuDeterminedTimeEmpByDate = New System.Windows.Forms.MenuItem
        Me.MenuItem34 = New System.Windows.Forms.MenuItem
        Me.mnusetBarcode = New System.Windows.Forms.MenuItem
        Me.MenuItem36 = New System.Windows.Forms.MenuItem
        Me.mnuProcessOT = New System.Windows.Forms.MenuItem
        Me.mnucalculationLate = New System.Windows.Forms.MenuItem
        Me.mnucalculationAbs = New System.Windows.Forms.MenuItem
        Me.MenuItem50 = New System.Windows.Forms.MenuItem
        Me.mnucalculationBreak = New System.Windows.Forms.MenuItem
        Me.mnuSetholiday = New System.Windows.Forms.MenuItem
        Me.MenuItem53 = New System.Windows.Forms.MenuItem
        Me.mnuSetLeave = New System.Windows.Forms.MenuItem
        Me.mnuSetabsenceTimeByYear = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.mnusetovertimepay = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.mnusetOT = New System.Windows.Forms.MenuItem
        Me.mnusetdelaytime = New System.Windows.Forms.MenuItem
        Me.MenuItem55 = New System.Windows.Forms.MenuItem
        Me.mnusetdelayOT = New System.Windows.Forms.MenuItem
        Me.mnuSetCancelDelayOTByDay = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.mnuOTbyDay = New System.Windows.Forms.MenuItem
        Me.mnusetconditionsLate = New System.Windows.Forms.MenuItem
        Me.mnuconditionslate = New System.Windows.Forms.MenuItem
        Me.MenuItem62 = New System.Windows.Forms.MenuItem
        Me.mnuconditionslatesomeone = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.mnuconditionslatebyRate = New System.Windows.Forms.MenuItem
        Me.mnusetAllowance = New System.Windows.Forms.MenuItem
        Me.mnuLinkCodePayroll = New System.Windows.Forms.MenuItem
        Me.MenuWorkHolidaySpacial = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.TimeKaMove = New System.Windows.Forms.MenuItem
        Me.mnuReport = New System.Windows.Forms.MenuItem
        Me.mnurptTimeWork = New System.Windows.Forms.MenuItem
        Me.mnurptTimeWorkLateByOne = New System.Windows.Forms.MenuItem
        Me.mnurptTimeSheet = New System.Windows.Forms.MenuItem
        Me.mnurptAllemployeework = New System.Windows.Forms.MenuItem
        Me.mnuSumaryWagePerDay = New System.Windows.Forms.MenuItem
        Me.mnurptEmployeework = New System.Windows.Forms.MenuItem
        Me.mnurptEmpWorkDetail1 = New System.Windows.Forms.MenuItem
        Me.mnurptEmpWorkDetail2 = New System.Windows.Forms.MenuItem
        Me.mnurptOT = New System.Windows.Forms.MenuItem
        Me.mnurptSumaryMonth = New System.Windows.Forms.MenuItem
        Me.mnurptrptSumaryMonthLateByBath = New System.Windows.Forms.MenuItem
        Me.mnurptScheduleWorkAllEmp = New System.Windows.Forms.MenuItem
        Me.mnuSummaryScheduleWorkAllEmp = New System.Windows.Forms.MenuItem
        Me.mnuConfigSummaryScheduleWorkAllEmp = New System.Windows.Forms.MenuItem
        Me.MenuItem60 = New System.Windows.Forms.MenuItem
        Me.mnurptSummaryScheduleWorkAllEmp = New System.Windows.Forms.MenuItem
        Me.mnuEmpNotWork = New System.Windows.Forms.MenuItem
        Me.mnuConfigEmpNotWork = New System.Windows.Forms.MenuItem
        Me.mnurptEmpNotWork = New System.Windows.Forms.MenuItem
        Me.mnurptemployeeByDate = New System.Windows.Forms.MenuItem
        Me.mnuSumaryemployee = New System.Windows.Forms.MenuItem
        Me.mnuConfogSumaryemployee = New System.Windows.Forms.MenuItem
        Me.mnurptSumaryemployee = New System.Windows.Forms.MenuItem
        Me.mnurptMaximumOThoursdaysweeksyear = New System.Windows.Forms.MenuItem
        Me.mnurptNormalworkinghoursOTByWeek = New System.Windows.Forms.MenuItem
        Me.mnuSumaryHolidayInYears = New System.Windows.Forms.MenuItem
        Me.mnuConfigSumaryHolidayInYears = New System.Windows.Forms.MenuItem
        Me.mnurptSumaryHolidayInYears = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.mnuprtAllowance = New System.Windows.Forms.MenuItem
        Me.mnuRptSumary = New System.Windows.Forms.MenuItem
        Me.MenuItem30 = New System.Windows.Forms.MenuItem
        Me.mnuRptSumaryByMonth = New System.Windows.Forms.MenuItem
        Me.mnuRptSumaryByYear = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.mnuWindows = New System.Windows.Forms.MenuItem
        Me.mnuPermission = New System.Windows.Forms.MenuItem
        Me.mnuConfigPermission = New System.Windows.Forms.MenuItem
        Me.mnuExit = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuDailyUpdate, Me.mnuConfiguration, Me.mnuReport, Me.mnuWindows, Me.mnuPermission, Me.mnuExit})
        '
        'mnuDailyUpdate
        '
        Me.mnuDailyUpdate.Index = 0
        Me.mnuDailyUpdate.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuImportData, Me.MenuItem11, Me.mnuPermissionTimeAtt, Me.mnuManageTime, Me.MenuItem12, Me.mnuOvertime, Me.mnuLateTime, Me.mnuabsenceTime, Me.MenuItem20, Me.mnuAllowance, Me.MenuItem17, Me.mnuInputLeaveData})
        resources.ApplyResources(Me.mnuDailyUpdate, "mnuDailyUpdate")
        '
        'mnuImportData
        '
        Me.mnuImportData.Index = 0
        resources.ApplyResources(Me.mnuImportData, "mnuImportData")
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        resources.ApplyResources(Me.MenuItem11, "MenuItem11")
        '
        'mnuPermissionTimeAtt
        '
        Me.mnuPermissionTimeAtt.Index = 2
        resources.ApplyResources(Me.mnuPermissionTimeAtt, "mnuPermissionTimeAtt")
        '
        'mnuManageTime
        '
        Me.mnuManageTime.Index = 3
        resources.ApplyResources(Me.mnuManageTime, "mnuManageTime")
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 4
        resources.ApplyResources(Me.MenuItem12, "MenuItem12")
        '
        'mnuOvertime
        '
        Me.mnuOvertime.Index = 5
        resources.ApplyResources(Me.mnuOvertime, "mnuOvertime")
        '
        'mnuLateTime
        '
        Me.mnuLateTime.Index = 6
        resources.ApplyResources(Me.mnuLateTime, "mnuLateTime")
        '
        'mnuabsenceTime
        '
        Me.mnuabsenceTime.Index = 7
        resources.ApplyResources(Me.mnuabsenceTime, "mnuabsenceTime")
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 8
        resources.ApplyResources(Me.MenuItem20, "MenuItem20")
        '
        'mnuAllowance
        '
        Me.mnuAllowance.Index = 9
        resources.ApplyResources(Me.mnuAllowance, "mnuAllowance")
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 10
        resources.ApplyResources(Me.MenuItem17, "MenuItem17")
        '
        'mnuInputLeaveData
        '
        Me.mnuInputLeaveData.Index = 11
        resources.ApplyResources(Me.mnuInputLeaveData, "mnuInputLeaveData")
        '
        'mnuConfiguration
        '
        Me.mnuConfiguration.Index = 1
        Me.mnuConfiguration.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnumodelcalculations, Me.MenuItem46, Me.mnuTimeWork, Me.MenuItem34, Me.mnusetBarcode, Me.MenuItem36, Me.mnuProcessOT, Me.mnucalculationLate, Me.mnucalculationAbs, Me.MenuItem50, Me.mnucalculationBreak, Me.mnuSetholiday, Me.MenuItem53, Me.mnuSetLeave, Me.mnuSetabsenceTimeByYear, Me.MenuItem16, Me.MenuItem3, Me.mnusetconditionsLate, Me.mnusetAllowance, Me.mnuLinkCodePayroll, Me.MenuWorkHolidaySpacial, Me.MenuItem9, Me.TimeKaMove})
        resources.ApplyResources(Me.mnuConfiguration, "mnuConfiguration")
        '
        'mnumodelcalculations
        '
        Me.mnumodelcalculations.Index = 0
        resources.ApplyResources(Me.mnumodelcalculations, "mnumodelcalculations")
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 1
        resources.ApplyResources(Me.MenuItem46, "MenuItem46")
        '
        'mnuTimeWork
        '
        Me.mnuTimeWork.Index = 2
        Me.mnuTimeWork.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuworkinggroup, Me.MenuItem44, Me.mnuDeterminedTime, Me.mnuDeterminedTimeEmp})
        resources.ApplyResources(Me.mnuTimeWork, "mnuTimeWork")
        '
        'mnuworkinggroup
        '
        Me.mnuworkinggroup.Index = 0
        resources.ApplyResources(Me.mnuworkinggroup, "mnuworkinggroup")
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 1
        resources.ApplyResources(Me.MenuItem44, "MenuItem44")
        '
        'mnuDeterminedTime
        '
        Me.mnuDeterminedTime.Index = 2
        resources.ApplyResources(Me.mnuDeterminedTime, "mnuDeterminedTime")
        '
        'mnuDeterminedTimeEmp
        '
        Me.mnuDeterminedTimeEmp.Index = 3
        Me.mnuDeterminedTimeEmp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuDeterminedTimeEmpByOne, Me.mnuDeterminedTimeEmpByDate})
        resources.ApplyResources(Me.mnuDeterminedTimeEmp, "mnuDeterminedTimeEmp")
        '
        'mnuDeterminedTimeEmpByOne
        '
        Me.mnuDeterminedTimeEmpByOne.Index = 0
        resources.ApplyResources(Me.mnuDeterminedTimeEmpByOne, "mnuDeterminedTimeEmpByOne")
        '
        'mnuDeterminedTimeEmpByDate
        '
        Me.mnuDeterminedTimeEmpByDate.Index = 1
        resources.ApplyResources(Me.mnuDeterminedTimeEmpByDate, "mnuDeterminedTimeEmpByDate")
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 3
        resources.ApplyResources(Me.MenuItem34, "MenuItem34")
        '
        'mnusetBarcode
        '
        Me.mnusetBarcode.Index = 4
        resources.ApplyResources(Me.mnusetBarcode, "mnusetBarcode")
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 5
        resources.ApplyResources(Me.MenuItem36, "MenuItem36")
        '
        'mnuProcessOT
        '
        Me.mnuProcessOT.Index = 6
        resources.ApplyResources(Me.mnuProcessOT, "mnuProcessOT")
        '
        'mnucalculationLate
        '
        Me.mnucalculationLate.Index = 7
        resources.ApplyResources(Me.mnucalculationLate, "mnucalculationLate")
        '
        'mnucalculationAbs
        '
        Me.mnucalculationAbs.Index = 8
        resources.ApplyResources(Me.mnucalculationAbs, "mnucalculationAbs")
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 9
        resources.ApplyResources(Me.MenuItem50, "MenuItem50")
        '
        'mnucalculationBreak
        '
        Me.mnucalculationBreak.Index = 10
        resources.ApplyResources(Me.mnucalculationBreak, "mnucalculationBreak")
        '
        'mnuSetholiday
        '
        Me.mnuSetholiday.Index = 11
        resources.ApplyResources(Me.mnuSetholiday, "mnuSetholiday")
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 12
        resources.ApplyResources(Me.MenuItem53, "MenuItem53")
        '
        'mnuSetLeave
        '
        Me.mnuSetLeave.Index = 13
        resources.ApplyResources(Me.mnuSetLeave, "mnuSetLeave")
        '
        'mnuSetabsenceTimeByYear
        '
        Me.mnuSetabsenceTimeByYear.Index = 14
        resources.ApplyResources(Me.mnuSetabsenceTimeByYear, "mnuSetabsenceTimeByYear")
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 15
        resources.ApplyResources(Me.MenuItem16, "MenuItem16")
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 16
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem7, Me.MenuItem1, Me.MenuItem4, Me.mnusetOT, Me.MenuItem5, Me.mnuOTbyDay})
        resources.ApplyResources(Me.MenuItem3, "MenuItem3")
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 0
        resources.ApplyResources(Me.MenuItem7, "MenuItem7")
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 1
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnusetovertimepay, Me.MenuItem2})
        resources.ApplyResources(Me.MenuItem1, "MenuItem1")
        '
        'mnusetovertimepay
        '
        Me.mnusetovertimepay.Index = 0
        resources.ApplyResources(Me.mnusetovertimepay, "mnusetovertimepay")
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        resources.ApplyResources(Me.MenuItem2, "MenuItem2")
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        resources.ApplyResources(Me.MenuItem4, "MenuItem4")
        '
        'mnusetOT
        '
        Me.mnusetOT.Index = 3
        Me.mnusetOT.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnusetdelaytime, Me.MenuItem55, Me.mnusetdelayOT, Me.mnuSetCancelDelayOTByDay})
        resources.ApplyResources(Me.mnusetOT, "mnusetOT")
        '
        'mnusetdelaytime
        '
        Me.mnusetdelaytime.Index = 0
        resources.ApplyResources(Me.mnusetdelaytime, "mnusetdelaytime")
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 1
        resources.ApplyResources(Me.MenuItem55, "MenuItem55")
        '
        'mnusetdelayOT
        '
        Me.mnusetdelayOT.Index = 2
        resources.ApplyResources(Me.mnusetdelayOT, "mnusetdelayOT")
        '
        'mnuSetCancelDelayOTByDay
        '
        Me.mnuSetCancelDelayOTByDay.Index = 3
        resources.ApplyResources(Me.mnuSetCancelDelayOTByDay, "mnuSetCancelDelayOTByDay")
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        resources.ApplyResources(Me.MenuItem5, "MenuItem5")
        '
        'mnuOTbyDay
        '
        Me.mnuOTbyDay.Index = 5
        resources.ApplyResources(Me.mnuOTbyDay, "mnuOTbyDay")
        '
        'mnusetconditionsLate
        '
        Me.mnusetconditionsLate.Index = 17
        Me.mnusetconditionsLate.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuconditionslate, Me.MenuItem62, Me.mnuconditionslatesomeone, Me.MenuItem8, Me.mnuconditionslatebyRate})
        resources.ApplyResources(Me.mnusetconditionsLate, "mnusetconditionsLate")
        '
        'mnuconditionslate
        '
        Me.mnuconditionslate.Index = 0
        resources.ApplyResources(Me.mnuconditionslate, "mnuconditionslate")
        '
        'MenuItem62
        '
        Me.MenuItem62.Index = 1
        resources.ApplyResources(Me.MenuItem62, "MenuItem62")
        '
        'mnuconditionslatesomeone
        '
        Me.mnuconditionslatesomeone.Index = 2
        resources.ApplyResources(Me.mnuconditionslatesomeone, "mnuconditionslatesomeone")
        '
        'MenuItem8
        '
        resources.ApplyResources(Me.MenuItem8, "MenuItem8")
        Me.MenuItem8.Index = 3
        '
        'mnuconditionslatebyRate
        '
        Me.mnuconditionslatebyRate.Index = 4
        resources.ApplyResources(Me.mnuconditionslatebyRate, "mnuconditionslatebyRate")
        '
        'mnusetAllowance
        '
        Me.mnusetAllowance.Index = 18
        resources.ApplyResources(Me.mnusetAllowance, "mnusetAllowance")
        '
        'mnuLinkCodePayroll
        '
        Me.mnuLinkCodePayroll.Index = 19
        resources.ApplyResources(Me.mnuLinkCodePayroll, "mnuLinkCodePayroll")
        '
        'MenuWorkHolidaySpacial
        '
        Me.MenuWorkHolidaySpacial.Index = 20
        resources.ApplyResources(Me.MenuWorkHolidaySpacial, "MenuWorkHolidaySpacial")
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 21
        resources.ApplyResources(Me.MenuItem9, "MenuItem9")
        '
        'TimeKaMove
        '
        Me.TimeKaMove.Index = 22
        resources.ApplyResources(Me.TimeKaMove, "TimeKaMove")
        '
        'mnuReport
        '
        Me.mnuReport.Index = 2
        Me.mnuReport.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnurptTimeWork, Me.mnurptTimeWorkLateByOne, Me.mnurptTimeSheet, Me.mnurptAllemployeework, Me.mnuSumaryWagePerDay, Me.mnurptEmployeework, Me.mnurptOT, Me.mnurptSumaryMonth, Me.mnurptrptSumaryMonthLateByBath, Me.mnurptScheduleWorkAllEmp, Me.mnuSummaryScheduleWorkAllEmp, Me.mnuEmpNotWork, Me.mnurptemployeeByDate, Me.mnuSumaryemployee, Me.mnurptMaximumOThoursdaysweeksyear, Me.mnurptNormalworkinghoursOTByWeek, Me.mnuSumaryHolidayInYears, Me.MenuItem24, Me.mnuprtAllowance, Me.mnuRptSumary, Me.MenuItem30, Me.mnuRptSumaryByMonth, Me.mnuRptSumaryByYear, Me.MenuItem6})
        resources.ApplyResources(Me.mnuReport, "mnuReport")
        '
        'mnurptTimeWork
        '
        Me.mnurptTimeWork.Index = 0
        resources.ApplyResources(Me.mnurptTimeWork, "mnurptTimeWork")
        '
        'mnurptTimeWorkLateByOne
        '
        Me.mnurptTimeWorkLateByOne.Index = 1
        resources.ApplyResources(Me.mnurptTimeWorkLateByOne, "mnurptTimeWorkLateByOne")
        '
        'mnurptTimeSheet
        '
        Me.mnurptTimeSheet.Index = 2
        resources.ApplyResources(Me.mnurptTimeSheet, "mnurptTimeSheet")
        '
        'mnurptAllemployeework
        '
        Me.mnurptAllemployeework.Index = 3
        resources.ApplyResources(Me.mnurptAllemployeework, "mnurptAllemployeework")
        '
        'mnuSumaryWagePerDay
        '
        Me.mnuSumaryWagePerDay.Index = 4
        resources.ApplyResources(Me.mnuSumaryWagePerDay, "mnuSumaryWagePerDay")
        '
        'mnurptEmployeework
        '
        Me.mnurptEmployeework.Index = 5
        Me.mnurptEmployeework.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnurptEmpWorkDetail1, Me.mnurptEmpWorkDetail2})
        resources.ApplyResources(Me.mnurptEmployeework, "mnurptEmployeework")
        '
        'mnurptEmpWorkDetail1
        '
        Me.mnurptEmpWorkDetail1.Index = 0
        resources.ApplyResources(Me.mnurptEmpWorkDetail1, "mnurptEmpWorkDetail1")
        '
        'mnurptEmpWorkDetail2
        '
        Me.mnurptEmpWorkDetail2.Index = 1
        resources.ApplyResources(Me.mnurptEmpWorkDetail2, "mnurptEmpWorkDetail2")
        '
        'mnurptOT
        '
        Me.mnurptOT.Index = 6
        resources.ApplyResources(Me.mnurptOT, "mnurptOT")
        '
        'mnurptSumaryMonth
        '
        Me.mnurptSumaryMonth.Index = 7
        resources.ApplyResources(Me.mnurptSumaryMonth, "mnurptSumaryMonth")
        '
        'mnurptrptSumaryMonthLateByBath
        '
        Me.mnurptrptSumaryMonthLateByBath.Index = 8
        resources.ApplyResources(Me.mnurptrptSumaryMonthLateByBath, "mnurptrptSumaryMonthLateByBath")
        '
        'mnurptScheduleWorkAllEmp
        '
        Me.mnurptScheduleWorkAllEmp.Index = 9
        resources.ApplyResources(Me.mnurptScheduleWorkAllEmp, "mnurptScheduleWorkAllEmp")
        '
        'mnuSummaryScheduleWorkAllEmp
        '
        Me.mnuSummaryScheduleWorkAllEmp.Index = 10
        Me.mnuSummaryScheduleWorkAllEmp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuConfigSummaryScheduleWorkAllEmp, Me.MenuItem60, Me.mnurptSummaryScheduleWorkAllEmp})
        resources.ApplyResources(Me.mnuSummaryScheduleWorkAllEmp, "mnuSummaryScheduleWorkAllEmp")
        '
        'mnuConfigSummaryScheduleWorkAllEmp
        '
        Me.mnuConfigSummaryScheduleWorkAllEmp.Index = 0
        resources.ApplyResources(Me.mnuConfigSummaryScheduleWorkAllEmp, "mnuConfigSummaryScheduleWorkAllEmp")
        '
        'MenuItem60
        '
        Me.MenuItem60.Index = 1
        resources.ApplyResources(Me.MenuItem60, "MenuItem60")
        '
        'mnurptSummaryScheduleWorkAllEmp
        '
        Me.mnurptSummaryScheduleWorkAllEmp.Index = 2
        resources.ApplyResources(Me.mnurptSummaryScheduleWorkAllEmp, "mnurptSummaryScheduleWorkAllEmp")
        '
        'mnuEmpNotWork
        '
        Me.mnuEmpNotWork.Index = 11
        Me.mnuEmpNotWork.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuConfigEmpNotWork, Me.mnurptEmpNotWork})
        resources.ApplyResources(Me.mnuEmpNotWork, "mnuEmpNotWork")
        '
        'mnuConfigEmpNotWork
        '
        Me.mnuConfigEmpNotWork.Index = 0
        resources.ApplyResources(Me.mnuConfigEmpNotWork, "mnuConfigEmpNotWork")
        '
        'mnurptEmpNotWork
        '
        Me.mnurptEmpNotWork.Index = 1
        resources.ApplyResources(Me.mnurptEmpNotWork, "mnurptEmpNotWork")
        '
        'mnurptemployeeByDate
        '
        Me.mnurptemployeeByDate.Index = 12
        resources.ApplyResources(Me.mnurptemployeeByDate, "mnurptemployeeByDate")
        '
        'mnuSumaryemployee
        '
        Me.mnuSumaryemployee.Index = 13
        Me.mnuSumaryemployee.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuConfogSumaryemployee, Me.mnurptSumaryemployee})
        resources.ApplyResources(Me.mnuSumaryemployee, "mnuSumaryemployee")
        '
        'mnuConfogSumaryemployee
        '
        Me.mnuConfogSumaryemployee.Index = 0
        resources.ApplyResources(Me.mnuConfogSumaryemployee, "mnuConfogSumaryemployee")
        '
        'mnurptSumaryemployee
        '
        Me.mnurptSumaryemployee.Index = 1
        resources.ApplyResources(Me.mnurptSumaryemployee, "mnurptSumaryemployee")
        '
        'mnurptMaximumOThoursdaysweeksyear
        '
        Me.mnurptMaximumOThoursdaysweeksyear.Index = 14
        resources.ApplyResources(Me.mnurptMaximumOThoursdaysweeksyear, "mnurptMaximumOThoursdaysweeksyear")
        '
        'mnurptNormalworkinghoursOTByWeek
        '
        Me.mnurptNormalworkinghoursOTByWeek.Index = 15
        resources.ApplyResources(Me.mnurptNormalworkinghoursOTByWeek, "mnurptNormalworkinghoursOTByWeek")
        '
        'mnuSumaryHolidayInYears
        '
        Me.mnuSumaryHolidayInYears.Index = 16
        Me.mnuSumaryHolidayInYears.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuConfigSumaryHolidayInYears, Me.mnurptSumaryHolidayInYears})
        resources.ApplyResources(Me.mnuSumaryHolidayInYears, "mnuSumaryHolidayInYears")
        '
        'mnuConfigSumaryHolidayInYears
        '
        Me.mnuConfigSumaryHolidayInYears.Index = 0
        resources.ApplyResources(Me.mnuConfigSumaryHolidayInYears, "mnuConfigSumaryHolidayInYears")
        '
        'mnurptSumaryHolidayInYears
        '
        Me.mnurptSumaryHolidayInYears.Index = 1
        resources.ApplyResources(Me.mnurptSumaryHolidayInYears, "mnurptSumaryHolidayInYears")
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 17
        resources.ApplyResources(Me.MenuItem24, "MenuItem24")
        '
        'mnuprtAllowance
        '
        Me.mnuprtAllowance.Index = 18
        resources.ApplyResources(Me.mnuprtAllowance, "mnuprtAllowance")
        '
        'mnuRptSumary
        '
        Me.mnuRptSumary.Index = 19
        resources.ApplyResources(Me.mnuRptSumary, "mnuRptSumary")
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 20
        resources.ApplyResources(Me.MenuItem30, "MenuItem30")
        '
        'mnuRptSumaryByMonth
        '
        Me.mnuRptSumaryByMonth.Index = 21
        resources.ApplyResources(Me.mnuRptSumaryByMonth, "mnuRptSumaryByMonth")
        '
        'mnuRptSumaryByYear
        '
        Me.mnuRptSumaryByYear.Index = 22
        resources.ApplyResources(Me.mnuRptSumaryByYear, "mnuRptSumaryByYear")
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 23
        resources.ApplyResources(Me.MenuItem6, "MenuItem6")
        '
        'mnuWindows
        '
        Me.mnuWindows.Index = 3
        Me.mnuWindows.MdiList = True
        resources.ApplyResources(Me.mnuWindows, "mnuWindows")
        '
        'mnuPermission
        '
        Me.mnuPermission.Index = 4
        Me.mnuPermission.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuConfigPermission})
        resources.ApplyResources(Me.mnuPermission, "mnuPermission")
        '
        'mnuConfigPermission
        '
        Me.mnuConfigPermission.Index = 0
        resources.ApplyResources(Me.mnuConfigPermission, "mnuConfigPermission")
        '
        'mnuExit
        '
        Me.mnuExit.Index = 5
        resources.ApplyResources(Me.mnuExit, "mnuExit")
        '
        'frmMainMenu
        '
        resources.ApplyResources(Me, "$this")
        Me.BackColor = System.Drawing.Color.White
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMainMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub setPer()
        mnuDailyUpdate.Enabled = setPermission.DailyUpdate
        mnuImportData.Enabled = setPermission.ImportData
        mnuPermissionTimeAtt.Enabled = setPermission.Processingtime
        mnuManageTime.Enabled = setPermission.ManageTime
        mnuOvertime.Enabled = setPermission.Overtime
        mnuLateTime.Enabled = setPermission.LateTime
        mnuabsenceTime.Enabled = setPermission.absenceTime
        mnuAllowance.Enabled = setPermission.Allowance
        mnuInputLeaveData.Enabled = setPermission.InputLeaveData
        mnuConfiguration.Enabled = setPermission.Configuration
        mnuTimeWork.Enabled = setPermission.TimeWork
        mnuworkinggroup.Enabled = setPermission.workinggroup
        mnuDeterminedTime.Enabled = setPermission.DeterminedTime
        mnumodelcalculations.Enabled = setPermission.modelcalculations
        mnuDeterminedTimeEmp.Enabled = setPermission.DeterminedTimeEmp
        mnuDeterminedTimeEmpByOne.Enabled = setPermission.DeterminedTimeEmpByOne
        mnuDeterminedTimeEmpByDate.Enabled = setPermission.DeterminedTimeEmpByDate
        mnusetBarcode.Enabled = setPermission.setBarcode
        mnuProcessOT.Enabled = setPermission.ProcessOT
        mnucalculationLate.Enabled = setPermission.calculationLate
        mnucalculationBreak.Enabled = setPermission.calculationBreak
        mnuSetholiday.Enabled = setPermission.Setholiday
        mnuSetLeave.Enabled = setPermission.SetLeave
        mnuSetabsenceTimeByYear.Enabled = setPermission.SetabsenceTimeByYear
        mnusetconditionsLate.Enabled = setPermission.setconditionsLate
        mnuconditionslate.Enabled = setPermission.conditionslate
        mnuconditionslatesomeone.Enabled = setPermission.conditionslatesomeone
        mnuconditionslatebyRate.Enabled = setPermission.conditionslatebyRate
        mnusetOT.Enabled = setPermission.setOT
        mnusetdelaytime.Enabled = setPermission.setdelaytime
        mnusetdelayOT.Enabled = setPermission.setdelayOT
        mnusetovertimepay.Enabled = setPermission.setovertimepay
        mnusetAllowance.Enabled = setPermission.setAllowance
        mnuLinkCodePayroll.Enabled = setPermission.LinkCodePayroll
        mnuReport.Enabled = setPermission.Report
        mnurptTimeWork.Enabled = setPermission.rptTimeWork
        mnurptTimeWorkLateByOne.Enabled = setPermission.rptTimeWorkLateByOne
        mnurptTimeSheet.Enabled = setPermission.rptTimeSheet
        mnurptAllemployeework.Enabled = setPermission.rptAllemployeework
        mnurptEmployeework.Enabled = setPermission.rptEmployeework
        mnurptEmpWorkDetail1.Enabled = setPermission.rptEmpWorkDetail1
        mnurptEmpWorkDetail2.Enabled = setPermission.rptEmpWorkDetail2
        mnurptOT.Enabled = setPermission.rptOT
        mnurptSumaryMonth.Enabled = setPermission.rptSumaryMonth
        mnurptrptSumaryMonthLateByBath.Enabled = setPermission.rptrptSumaryMonthLateByBath
        mnurptScheduleWorkAllEmp.Enabled = setPermission.rptScheduleWorkAllEmp

        mnuSummaryScheduleWorkAllEmp.Enabled = setPermission.SummaryScheduleWorkAllEmp
        mnuConfigSummaryScheduleWorkAllEmp.Enabled = setPermission.ConfigSummaryScheduleWorkAllEmp
        mnurptSummaryScheduleWorkAllEmp.Enabled = setPermission.rptSummaryScheduleWorkAllEmp
        mnuEmpNotWork.Enabled = setPermission.EmpNotWork
        mnuConfigEmpNotWork.Enabled = setPermission.ConfigEmpNotWork
        mnurptEmpNotWork.Enabled = setPermission.rptEmpNotWork
        mnurptemployeeByDate.Enabled = setPermission.rptemployeeByDate
        mnuSumaryemployee.Enabled = setPermission.Sumaryemployee

        mnuConfogSumaryemployee.Enabled = setPermission.ConfogSumaryemployee

        mnurptSumaryemployee.Enabled = setPermission.rptSumaryemployee
        mnurptMaximumOThoursdaysweeksyear.Enabled = setPermission.rptMaximumOThoursdaysweeksyear
        mnurptNormalworkinghoursOTByWeek.Enabled = setPermission.rptNormalworkinghoursOTByWeek
        mnuSumaryHolidayInYears.Enabled = setPermission.SumaryHolidayInYears
        mnuConfigSumaryHolidayInYears.Enabled = setPermission.ConfigSumaryHolidayInYears
        mnurptSumaryHolidayInYears.Enabled = setPermission.rptSumaryHolidayInYears
        mnuprtAllowance.Enabled = setPermission.prtAllowance
        mnuRptSumary.Enabled = setPermission.RptSumary
        mnuRptSumaryByMonth.Enabled = setPermission.RptSumaryByMonth
        mnuWindows.Enabled = setPermission.Windows

        mnuPermission.Enabled = setPermission.Permission
        mnuConfigPermission.Enabled = setPermission.ConfigPermission
        mnuRptSumaryByYear.Enabled = setPermission.RptSumaryByYear




    End Sub

    Private Sub ReadMenuPermissionTimeAtt_ReadOnly()  ' เมนูประมวลผลเวลาทำงาน
        fTimework.btnProcess.Enabled = setPermission.PermissionTimeAtt_ReadOnly
        fTimework.btnAutoFixInOut.Enabled = setPermission.PermissionTimeAtt_ReadOnly
        fTimework.btnAutoGenTimeByPerson.Enabled = setPermission.PermissionTimeAtt_ReadOnly
    End Sub

    Private Sub ReadMenuManagetime_ReadOnly()   'เมนู แก้ไขเวลาทำงาน
        'fTimework.btnProcess.Enabled = setPermission.PermissionTimeAtt_ReadOnly
        'fTimework.btnAutoFixInOut.Enabled = setPermission.PermissionTimeAtt_ReadOnly
        'fTimework.btnAutoGenTimeByPerson.Enabled = setPermission.PermissionTimeAtt_ReadOnly
    End Sub



    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImportData.Click
        Try
            If fGetText Is Nothing Then
                fGetText = New frmGetText
            Else
                If fGetText.IsDisposed = True Then
                    fGetText = New frmGetText
                End If
            End If
            fGetText.MdiParent = Me
            fGetText.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnucalculationBreak.Click
        Try
            If fWorkingTime Is Nothing Then
                fWorkingTime = New frmWorkingTime
            Else
                If fWorkingTime.IsDisposed = True Then
                    fWorkingTime = New frmWorkingTime
                End If
            End If
            fWorkingTime.MdiParent = Me
            fWorkingTime.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetholiday.Click
        'Try
        '    If fHolidayYear Is Nothing Then
        '        fHolidayYear = New frmHolidayYear
        '    Else
        '        If fHolidayYear.IsDisposed = True Then
        '            fHolidayYear = New frmHolidayYear
        '        End If
        '    End If
        '    fHolidayYear.MdiParent = Me
        '    fHolidayYear.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        'End Try

        Try
            If fHolidayYear Is Nothing Then
                fHolidayYear = New frmHolidayYear_New
            Else
                If fHolidayYear.IsDisposed = True Then
                    fHolidayYear = New frmHolidayYear_New
                End If
            End If
            fHolidayYear.MdiParent = Me
            fHolidayYear.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetLeave.Click
        Try
            If fWorkingStatus Is Nothing Then
                fWorkingStatus = New frmWorkingStatus
            Else
                If fWorkingStatus.IsDisposed = True Then
                    fWorkingStatus = New frmWorkingStatus
                End If
            End If
            fWorkingStatus.MdiParent = Me
            fWorkingStatus.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnusetovertimepay.Click
        Try
            If fOTRate Is Nothing Then
                fOTRate = New frmOTRate
            Else
                If fOTRate.IsDisposed = True Then
                    fOTRate = New frmOTRate
                End If
            End If
            fOTRate.MdiParent = Me
            fOTRate.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuconditionslate.Click
        Try
            If fLateRate Is Nothing Then
                fLateRate = New frmLateRate
            Else
                If fLateRate.IsDisposed = True Then
                    fLateRate = New frmLateRate
                End If
            End If
            fLateRate.MdiParent = Me
            fLateRate.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        If fLateSpaRate Is Nothing Then
            fLateSpaRate = New frmLateSpaRate
            fLateSpaRate.MdiParent = Me
            fLateSpaRate.WindowState = FormWindowState.Maximized
            fLateSpaRate.Show()
            fLateSpaRate.BringToFront()
        Else
            fLateSpaRate.MdiParent = Me
            fLateSpaRate.WindowState = FormWindowState.Maximized
            fLateSpaRate.Show()
            fLateSpaRate.BringToFront()
        End If
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPermissionTimeAtt.Click
        If fTimework Is Nothing Then
            fTimework = New frmTimework
            fTimework.MdiParent = Me
            fTimework.WindowState = FormWindowState.Maximized
            fTimework.Show()
            fTimework.BringToFront()
        Else
            fTimework.MdiParent = Me
            fTimework.WindowState = FormWindowState.Maximized
            fTimework.Show()
            fTimework.BringToFront()
        End If
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuManageTime.Click
        If fEditTime Is Nothing Then
            fEditTime = New frmEditTime
            fEditTime.MdiParent = Me
            fEditTime.Show()
            fEditTime.BringToFront()
        Else
            fEditTime.MdiParent = Me
            fEditTime.Show()
            fEditTime.BringToFront()
        End If
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOvertime.Click
        If fOvertime Is Nothing Then
            fOvertime = New frmOvertime
            fOvertime.MdiParent = Me
            fOvertime.WindowState = FormWindowState.Maximized
            fOvertime.Show()
            fOvertime.BringToFront()
        Else
            fOvertime.MdiParent = Me
            fOvertime.WindowState = FormWindowState.Maximized
            fOvertime.Show()
            fOvertime.BringToFront()
        End If
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLateTime.Click
        If fLate Is Nothing Then
            fLate = New frmLate
            fLate.MdiParent = Me
            fLate.WindowState = FormWindowState.Maximized
            fLate.Show()
            fLate.BringToFront()
        Else
            fLate.MdiParent = Me
            fLate.WindowState = FormWindowState.Maximized
            fLate.Show()
            fLate.BringToFront()
        End If
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuabsenceTime.Click
        If fAbsent Is Nothing Then
            fAbsent = New frmAbs
            fAbsent.MdiParent = Me
            fAbsent.WindowState = FormWindowState.Maximized
            fAbsent.Show()
            fAbsent.BringToFront()
        Else
            fAbsent.MdiParent = Me
            fAbsent.WindowState = FormWindowState.Maximized
            fAbsent.Show()
            fAbsent.BringToFront()
        End If
    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInputLeaveData.Click
        If fVacation Is Nothing Then
            fVacation = New frmVacation
            fVacation.MdiParent = Me
            fVacation.WindowState = FormWindowState.Maximized
            fVacation.Show()
            fVacation.BringToFront()
        Else
            fVacation.MdiParent = Me
            fVacation.WindowState = FormWindowState.Maximized
            fVacation.Show()
            fVacation.BringToFront()
        End If
    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAllowance.Click
        If fAllowance Is Nothing Then
            fAllowance = New frmAllowance
            fAllowance.MdiParent = Me
            fAllowance.WindowState = FormWindowState.Maximized
            fAllowance.Show()
            fAllowance.BringToFront()
        Else
            fAllowance.MdiParent = Me
            fAllowance.WindowState = FormWindowState.Maximized
            fAllowance.Show()
            fAllowance.BringToFront()
        End If
    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptTimeSheet.Click
        Try
            If fReportTimeSheet Is Nothing Then
                fReportTimeSheet = New frmRptTimeSheet
            Else
                If fReportTimeSheet.IsDisposed = True Then
                    fReportTimeSheet = New frmRptTimeSheet
                End If
            End If
            fReportTimeSheet.MdiParent = Me
            fReportTimeSheet.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptSumaryMonth.Click
        Try
            If fSumarized Is Nothing Then
                fSumarized = New frmSumarized
            Else
                If fSumarized.IsDisposed = True Then
                    fSumarized = New frmSumarized
                End If
            End If
            fSumarized.MdiParent = Me
            fSumarized.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptOT.Click
        Try
            If fReportOvertime Is Nothing Then
                fReportOvertime = New frmReportOvertime
            Else
                If fReportOvertime.IsDisposed = True Then
                    fReportOvertime = New frmReportOvertime
                End If
            End If
            fReportOvertime.MdiParent = Me
            fReportOvertime.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuprtAllowance.Click
        Try
            If fReportAllowance Is Nothing Then
                fReportAllowance = New frmReportAllowance
            Else
                If fReportAllowance.IsDisposed = True Then
                    fReportAllowance = New frmReportAllowance
                End If
            End If
            fReportAllowance.MdiParent = Me
            fReportAllowance.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRptSumary.Click
        Try
            If fReportSumary Is Nothing Then
                fReportSumary = New frmReportSumary
            Else
                If fReportSumary.IsDisposed = True Then
                    fReportSumary = New frmReportSumary
                End If
            End If
            fReportSumary.MdiParent = Me
            fReportSumary.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnusetAllowance.Click
        Try
            If fAutoAwRate Is Nothing Then
                fAutoAwRate = New frmAutoAwRate
            Else
                If fAutoAwRate.IsDisposed = True Then
                    fAutoAwRate = New frmAutoAwRate
                End If
            End If
            fAutoAwRate.MdiParent = Me
            fAutoAwRate.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptTimeWork.Click
        Try
            If fRptCheckComing Is Nothing Then
                fRptCheckComing = New frmRptCheckComing
            Else
                If fRptCheckComing.IsDisposed = True Then
                    fRptCheckComing = New frmRptCheckComing
                End If
            End If
            fRptCheckComing.MdiParent = Me
            fRptCheckComing.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRptSumaryByMonth.Click
        Try
            If fReportMonthlySumary Is Nothing Then
                fReportMonthlySumary = New frmReportMonthlySumary
            Else
                If fReportMonthlySumary.IsDisposed = True Then
                    fReportMonthlySumary = New frmReportMonthlySumary
                End If
            End If
            fReportMonthlySumary.MdiParent = Me
            fReportMonthlySumary.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRptSumaryByYear.Click
        Try
            If fReportYearlySumary Is Nothing Then
                fReportYearlySumary = New frmReportYearlySumary
            Else
                If fReportYearlySumary.IsDisposed = True Then
                    fReportYearlySumary = New frmReportYearlySumary
                End If
            End If
            fReportYearlySumary.MdiParent = Me
            fReportYearlySumary.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

    End Sub

    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeterminedTime.Click
        Try
            If fTimeKa Is Nothing Then
                fTimeKa = New frmTimeKa
            Else
                If fTimeKa.IsDisposed = True Then
                    fTimeKa = New frmTimeKa
                End If
            End If
            fTimeKa.BringToFront()
            fTimeKa.MdiParent = Me
            fTimeKa.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeterminedTimeEmpByOne.Click
        Try
            If fEmpSetTime Is Nothing Then
                fEmpSetTime = New frmEmpSetTime
            Else
                If fEmpSetTime.IsDisposed = True Then
                    fEmpSetTime = New frmEmpSetTime
                End If
            End If
            fEmpSetTime.BringToFront()
            fEmpSetTime.MdiParent = Me
            fEmpSetTime.WindowState = FormWindowState.Maximized
            fEmpSetTime.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnusetBarcode.Click
        Try
            If fSetBarcode Is Nothing Then
                fSetBarcode = New frmSetBarcode
            Else
                If fSetBarcode.IsDisposed = True Then
                    fSetBarcode = New frmSetBarcode
                End If
            End If
            fSetBarcode.BringToFront()
            fSetBarcode.MdiParent = Me
            fSetBarcode.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptTimeWorkLateByOne.Click
        Try
            If fRptCheckComingByPerson Is Nothing Then
                fRptCheckComingByPerson = New frmRptCheckComingByPerson
            Else
                If fRptCheckComingByPerson.IsDisposed = True Then
                    fRptCheckComingByPerson = New frmRptCheckComingByPerson
                End If
            End If
            fRptCheckComingByPerson.BringToFront()
            fRptCheckComingByPerson.MdiParent = Me
            fRptCheckComingByPerson.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub frmMainMenu_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Call OpenConnect(False)
    End Sub

    Private Sub frmMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call setPer()
    End Sub

    Private Sub MenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLinkCodePayroll.Click
        Try
            If fLinkCodeToPayroll Is Nothing Then
                fLinkCodeToPayroll = New frmLinkCodeToPayroll
            Else
                If fLinkCodeToPayroll.IsDisposed = True Then
                    fLinkCodeToPayroll = New frmLinkCodeToPayroll
                End If
            End If
            fLinkCodeToPayroll.BringToFront()
            fLinkCodeToPayroll.MdiParent = Me
            fLinkCodeToPayroll.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeterminedTimeEmpByDate.Click
        Try
            If fEmpSetTimeByDate Is Nothing Then
                fEmpSetTimeByDate = New frmEmpSetTimeByDate
            Else
                If fEmpSetTimeByDate.IsDisposed = True Then
                    fEmpSetTimeByDate = New frmEmpSetTimeByDate
                End If
            End If
            fEmpSetTimeByDate.BringToFront()
            fEmpSetTimeByDate.MdiParent = Me
            fEmpSetTimeByDate.WindowState = FormWindowState.Maximized
            fEmpSetTimeByDate.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuworkinggroup.Click
        Try
            If fKaGroupUse Is Nothing Then
                fKaGroupUse = New frmKaGroupUse
            Else
                If fKaGroupUse.IsDisposed = True Then
                    fKaGroupUse = New frmKaGroupUse
                End If
            End If
            fKaGroupUse.BringToFront()
            fKaGroupUse.MdiParent = Me
            fKaGroupUse.WindowState = FormWindowState.Maximized
            fKaGroupUse.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnumodelcalculations.Click
        Try
            If fMainConfig Is Nothing Then
                fMainConfig = New frmMainConfig
            Else
                If fMainConfig.IsDisposed = True Then
                    fMainConfig = New frmMainConfig
                End If
            End If
            fMainConfig.BringToFront()
            fMainConfig.MdiParent = Me
            fMainConfig.WindowState = FormWindowState.Maximized
            fMainConfig.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuconditionslatesomeone.Click
        Try
            If fLateRateCash Is Nothing Then
                fLateRateCash = New frmLateRateCash
            Else
                If fLateRateCash.IsDisposed = True Then
                    fLateRateCash = New frmLateRateCash
                End If
            End If
            fLateRateCash.BringToFront()
            fLateRateCash.MdiParent = Me
            fLateRateCash.WindowState = FormWindowState.Maximized
            fLateRateCash.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProcessOT.Click
        'Try
        '    If fEmpCalOT Is Nothing Then
        '        fEmpCalOT = New frmEmpCalOT
        '    Else
        '        If fEmpCalOT.IsDisposed = True Then
        '            fEmpCalOT = New frmEmpCalOT
        '        End If
        '    End If
        '    fEmpCalOT.BringToFront()
        '    fEmpCalOT.MdiParent = Me
        '    fEmpCalOT.WindowState = FormWindowState.Maximized
        '    fEmpCalOT.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        'End Try

        Try
            If fEmpCalOTConfig Is Nothing Then
                fEmpCalOTConfig = New frmEmpCalOTConfig
            Else
                If fEmpCalOTConfig.IsDisposed = True Then
                    fEmpCalOTConfig = New frmEmpCalOTConfig
                End If
            End If
            fEmpCalOTConfig.BringToFront()
            fEmpCalOTConfig.MdiParent = Me
            fEmpCalOTConfig.WindowState = FormWindowState.Maximized
            fEmpCalOTConfig.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnucalculationLate.Click
        Try
            If fEmpCalLate Is Nothing Then
                fEmpCalLate = New frmEmpCalLate
            Else
                If fEmpCalLate.IsDisposed = True Then
                    fEmpCalLate = New frmEmpCalLate
                End If
            End If
            fEmpCalLate.BringToFront()
            fEmpCalLate.MdiParent = Me
            fEmpCalLate.WindowState = FormWindowState.Maximized
            fEmpCalLate.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuReportEmpWork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptAllemployeework.Click
        Try
            If fRptAllEmpWork Is Nothing Then
                fRptAllEmpWork = New frmRptAllEmpWork
            Else
                If fRptAllEmpWork.IsDisposed = True Then
                    fRptAllEmpWork = New frmRptAllEmpWork
                End If
            End If
            fRptAllEmpWork.BringToFront()
            fRptAllEmpWork.MdiParent = Me
            fRptAllEmpWork.WindowState = FormWindowState.Maximized
            fRptAllEmpWork.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuRptSumLateAbsByMonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptrptSumaryMonthLateByBath.Click
        Try
            If fRptTimeSumAbsentLate Is Nothing Then
                fRptTimeSumAbsentLate = New frmRptTimeSumAbsentLate
            Else
                If fRptTimeSumAbsentLate.IsDisposed = True Then
                    fRptTimeSumAbsentLate = New frmRptTimeSumAbsentLate
                End If
            End If
            fRptTimeSumAbsentLate.BringToFront()
            fRptTimeSumAbsentLate.MdiParent = Me
            '       fRptTimeSumAbsentLate.WindowState = FormWindowState.Maximized
            fRptTimeSumAbsentLate.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuRPT_TimeTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptScheduleWorkAllEmp.Click
        Try
            If fRptTimeTableByMonth Is Nothing Then
                fRptTimeTableByMonth = New frmRptTimeTableByMonth
            Else
                If fRptTimeTableByMonth.IsDisposed = True Then
                    fRptTimeTableByMonth = New frmRptTimeTableByMonth
                End If
            End If
            fRptTimeTableByMonth.BringToFront()
            fRptTimeTableByMonth.MdiParent = Me
            '  fRptTimeTableByMonth.WindowState = FormWindowState.Maximized
            fRptTimeTableByMonth.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetabsenceTimeByYear.Click
        Try
            If fPrivilegeVal Is Nothing Then
                fPrivilegeVal = New frmPrivilegeVal
            Else
                If fPrivilegeVal.IsDisposed = True Then
                    fPrivilegeVal = New frmPrivilegeVal
                End If
            End If
            fPrivilegeVal.BringToFront()
            fPrivilegeVal.MdiParent = Me
            fPrivilegeVal.WindowState = FormWindowState.Maximized
            fPrivilegeVal.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuConfigOTDeduc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnusetdelayOT.Click
        Try
            If fOtDeductRate Is Nothing Then
                fOtDeductRate = New frmOtDeductRate
            Else
                If fOtDeductRate.IsDisposed = True Then
                    fOtDeductRate = New frmOtDeductRate
                End If
            End If
            fOtDeductRate.BringToFront()
            fOtDeductRate.MdiParent = Me
            fOtDeductRate.WindowState = FormWindowState.Maximized
            fOtDeductRate.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuConfigOTDeducByDept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnusetdelaytime.Click
        Try
            If fEmpCalOTDeducRate Is Nothing Then
                fEmpCalOTDeducRate = New frmEmpCalOTDeducRate
            Else
                If fEmpCalOTDeducRate.IsDisposed = True Then
                    fEmpCalOTDeducRate = New frmEmpCalOTDeducRate
                End If
            End If
            fEmpCalOTDeducRate.BringToFront()
            fEmpCalOTDeducRate.MdiParent = Me
            fEmpCalOTDeducRate.WindowState = FormWindowState.Maximized
            fEmpCalOTDeducRate.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptEmpWorkDetail1.Click
        Try
            If fRptAllEmpWork_Detail Is Nothing Then
                fRptAllEmpWork_Detail = New frmRptAllEmpWork_Detail
            Else
                If fRptAllEmpWork_Detail.IsDisposed = True Then
                    fRptAllEmpWork_Detail = New frmRptAllEmpWork_Detail
                End If
            End If
            fRptAllEmpWork_Detail.BringToFront()
            fRptAllEmpWork_Detail.MdiParent = Me
            fRptAllEmpWork_Detail.WindowState = FormWindowState.Maximized
            fRptAllEmpWork_Detail.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuTimeworkSumary_Config_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConfigSummaryScheduleWorkAllEmp.Click
        Try
            If fRptTimeWorkSumary_Config Is Nothing Then
                fRptTimeWorkSumary_Config = New frmRptTimeWorkSumary_Config
            Else
                If fRptTimeWorkSumary_Config.IsDisposed = True Then
                    fRptTimeWorkSumary_Config = New frmRptTimeWorkSumary_Config
                End If
            End If
            fRptTimeWorkSumary_Config.BringToFront()
            fRptTimeWorkSumary_Config.MdiParent = Me
            fRptTimeWorkSumary_Config.WindowState = FormWindowState.Maximized
            fRptTimeWorkSumary_Config.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuTimeworkSumary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptSummaryScheduleWorkAllEmp.Click
        Try
            If fRptTimeWorkSumary Is Nothing Then
                fRptTimeWorkSumary = New frmRPTTimeworkSumary
            Else
                If fRptTimeWorkSumary.IsDisposed = True Then
                    fRptTimeWorkSumary = New frmRPTTimeworkSumary
                End If
            End If
            fRptTimeWorkSumary.BringToFront()
            fRptTimeWorkSumary.MdiParent = Me
            '     fRptTimeWorkSumary.WindowState = FormWindowState.Maximized
            fRptTimeWorkSumary.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

    End Sub

    Private Sub mnuRPT_TimeAbsent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptEmpNotWork.Click
        Try
            If fRPT_TimeAbsent Is Nothing Then
                fRPT_TimeAbsent = New frmRPTTimeAbsent
            Else
                If fRPT_TimeAbsent.IsDisposed = True Then
                    fRPT_TimeAbsent = New frmRPTTimeAbsent
                End If
            End If
            fRPT_TimeAbsent.BringToFront()
            fRPT_TimeAbsent.MdiParent = Me
            '   fRPT_TimeAbsent.WindowState = FormWindowState.Maximized
            fRPT_TimeAbsent.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuRPT_TimeAbsent_Config_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConfigEmpNotWork.Click
        Try
            If fRPT_TimeAbsent_Config Is Nothing Then
                fRPT_TimeAbsent_Config = New frmRptTimeAbsent_Config
            Else
                If fRPT_TimeAbsent_Config.IsDisposed = True Then
                    fRPT_TimeAbsent_Config = New frmRptTimeAbsent_Config
                End If
            End If
            fRPT_TimeAbsent_Config.BringToFront()
            fRPT_TimeAbsent_Config.MdiParent = Me
            fRPT_TimeAbsent_Config.WindowState = FormWindowState.Maximized
            fRPT_TimeAbsent_Config.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuRPT_TimeAbsLate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptSumaryemployee.Click
        Try
            If fRPT_TimeAbLate Is Nothing Then
                fRPT_TimeAbLate = New frmRPTTimeAbsLate
            Else
                If fRPT_TimeAbLate.IsDisposed = True Then
                    fRPT_TimeAbLate = New frmRPTTimeAbsLate
                End If
            End If
            fRPT_TimeAbLate.BringToFront()
            fRPT_TimeAbLate.MdiParent = Me
            '   fRPT_TimeAbLate.WindowState = FormWindowState.Maximized
            fRPT_TimeAbLate.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuRPT_TimeAbsLate_Config_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConfogSumaryemployee.Click
        Try
            If fRPT_TimeAbsLate_Config Is Nothing Then
                fRPT_TimeAbsLate_Config = New frmRptTimeAbsLate_Config
            Else
                If fRPT_TimeAbsLate_Config.IsDisposed = True Then
                    fRPT_TimeAbsLate_Config = New frmRptTimeAbsLate_Config
                End If
            End If
            fRPT_TimeAbsLate_Config.BringToFront()
            fRPT_TimeAbsLate_Config.MdiParent = Me
            fRPT_TimeAbsLate_Config.WindowState = FormWindowState.Maximized
            fRPT_TimeAbsLate_Config.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub


    Private Sub mnuRPT_MaxOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptMaximumOThoursdaysweeksyear.Click
        Try
            If fRPTMaxOT Is Nothing Then
                fRPTMaxOT = New frmRptMaxOT
            Else
                If fRPTMaxOT.IsDisposed = True Then
                    fRPTMaxOT = New frmRptMaxOT
                End If
            End If
            fRPTMaxOT.BringToFront()
            fRPTMaxOT.MdiParent = Me
            '    fRPTMaxOT.WindowState = FormWindowState.Maximized
            fRPTMaxOT.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuRPT_SummarizeVacationByYear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSumaryHolidayInYears.Click

    End Sub

    Private Sub MenuItem59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptSumaryHolidayInYears.Click
        Try
            If fRPT_SummarizeVacationByYear Is Nothing Then
                fRPT_SummarizeVacationByYear = New frmRPTSummarizeVacationByYear
            Else
                If fRPT_SummarizeVacationByYear.IsDisposed = True Then
                    fRPT_SummarizeVacationByYear = New frmRPTSummarizeVacationByYear
                End If
            End If
            fRPT_SummarizeVacationByYear.BringToFront()
            fRPT_SummarizeVacationByYear.MdiParent = Me
            fRPT_SummarizeVacationByYear.WindowState = FormWindowState.Maximized
            fRPT_SummarizeVacationByYear.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConfigSumaryHolidayInYears.Click
        Try
            If fRPTSummarizeVacationByYear_Config Is Nothing Then
                fRPTSummarizeVacationByYear_Config = New frmRPTSummarizeVacationByYear_Config
            Else
                If fRPTSummarizeVacationByYear_Config.IsDisposed = True Then
                    fRPTSummarizeVacationByYear_Config = New frmRPTSummarizeVacationByYear_Config
                End If
            End If
            fRPTSummarizeVacationByYear_Config.BringToFront()
            fRPTSummarizeVacationByYear_Config.MdiParent = Me
            fRPTSummarizeVacationByYear_Config.WindowState = FormWindowState.Maximized
            fRPTSummarizeVacationByYear_Config.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuTimeworksumarybyweek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptNormalworkinghoursOTByWeek.Click
        Try
            If fRPTTimeworkSumaryByWeek Is Nothing Then
                fRPTTimeworkSumaryByWeek = New frmRPTTimeworkSumaryByWeek
            Else
                If fRPTTimeworkSumaryByWeek.IsDisposed = True Then
                    fRPTTimeworkSumaryByWeek = New frmRPTTimeworkSumaryByWeek
                End If
            End If
            fRPTTimeworkSumaryByWeek.BringToFront()
            fRPTTimeworkSumaryByWeek.MdiParent = Me
            '     fRPTTimeworkSumaryByWeek.WindowState = FormWindowState.Maximized
            fRPTTimeworkSumaryByWeek.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuRPT_EmpValAbsLateByDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptemployeeByDate.Click
        Try
            If fRPTEmpValAbsLateByDate Is Nothing Then
                fRPTEmpValAbsLateByDate = New frmRPTEmpValAbsLateByDate
            Else
                If fRPTEmpValAbsLateByDate.IsDisposed = True Then
                    fRPTEmpValAbsLateByDate = New frmRPTEmpValAbsLateByDate
                End If
            End If
            fRPTEmpValAbsLateByDate.BringToFront()
            fRPTEmpValAbsLateByDate.MdiParent = Me
            fRPTEmpValAbsLateByDate.WindowState = FormWindowState.Maximized
            fRPTEmpValAbsLateByDate.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuRPT_Timework2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptEmpWorkDetail2.Click
        Try
            If fRptAllEmpWork_Detail2 Is Nothing Then
                fRptAllEmpWork_Detail2 = New frmRptAllEmpWork_Detail2
            Else
                If fRptAllEmpWork_Detail2.IsDisposed = True Then
                    fRptAllEmpWork_Detail2 = New frmRptAllEmpWork_Detail2
                End If
            End If
            fRptAllEmpWork_Detail2.BringToFront()
            fRptAllEmpWork_Detail2.MdiParent = Me
            fRptAllEmpWork_Detail2.WindowState = FormWindowState.Maximized
            fRptAllEmpWork_Detail2.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptEmployeework.Click

    End Sub

    Private Sub mnuCaseLateByTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuconditionslatebyRate.Click
        Try
            If fCaseLatebyTime Is Nothing Then
                fCaseLatebyTime = New frmCaseLatebyTime
            Else
                If fCaseLatebyTime.IsDisposed = True Then
                    fCaseLatebyTime = New frmCaseLatebyTime
                End If
            End If
            fCaseLatebyTime.BringToFront()
            fCaseLatebyTime.MdiParent = Me
            fCaseLatebyTime.WindowState = FormWindowState.Maximized
            fCaseLatebyTime.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me.Close()
        Call OpenConnect(False)
        Application.Exit()
    End Sub

    Private Sub MenuItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConfigPermission.Click
        Try
            If fUser Is Nothing Then
                fUser = New frmUser
            Else
                If fUser.IsDisposed = True Then
                    fUser = New frmUser
                End If
            End If
            fUser.WindowState = FormWindowState.Maximized
            fUser.MdiParent = Me
            fUser.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Try
            If fOTRate_Period Is Nothing Then
                fOTRate_Period = New frmOTRate_Period
            Else
                If fOTRate_Period.IsDisposed = True Then
                    fOTRate_Period = New frmOTRate_Period
                End If
            End If
            fOTRate_Period.MdiParent = Me
            fOTRate_Period.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuSetCancelDelayOTByDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetCancelDelayOTByDay.Click
        'fEmpCalOTDeducRate_CancelByDate
        Try
            If fEmpCalOTDeducRate_CancelByDate Is Nothing Then
                fEmpCalOTDeducRate_CancelByDate = New frmEmpCalOTDeducRate_CancelByDate
            Else
                If fEmpCalOTDeducRate_CancelByDate.IsDisposed = True Then
                    fEmpCalOTDeducRate_CancelByDate = New frmEmpCalOTDeducRate_CancelByDate
                End If
            End If
            fEmpCalOTDeducRate_CancelByDate.MdiParent = Me
            fEmpCalOTDeducRate_CancelByDate.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuSumaryWagePerDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSumaryWagePerDay.Click
        Try
            If fRPTSumaryWagePerDay Is Nothing Then
                fRPTSumaryWagePerDay = New frmRPTSumaryWagePerDay
            Else
                If fRPTSumaryWagePerDay.IsDisposed = True Then
                    fRPTSumaryWagePerDay = New frmRPTSumaryWagePerDay
                End If
            End If
            fRPTSumaryWagePerDay.MdiParent = Me
            fRPTSumaryWagePerDay.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuOTbyDay_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOTbyDay.Click
        Try
            If fEmpOTDeducByDay Is Nothing Then
                fEmpOTDeducByDay = New frmEmpOTDeducByDay
            Else
                If fEmpOTDeducByDay.IsDisposed = True Then
                    fEmpOTDeducByDay = New frmEmpOTDeducByDay
                End If
            End If
            fEmpOTDeducByDay.MdiParent = Me
            fEmpOTDeducByDay.WindowState = FormWindowState.Maximized
            fEmpOTDeducByDay.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click

        Try
            If fRpt_OTreport Is Nothing Then
                fRpt_OTreport = New frmRpt_OTreport
            Else
                If fRpt_OTreport.IsDisposed = True Then
                    fRpt_OTreport = New frmRpt_OTreport
                End If
            End If
            fRpt_OTreport.MdiParent = Me
            fRpt_OTreport.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click

    End Sub

    Private Sub MenuItem7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Try
            If fRpt_OTreport Is Nothing Then
                fCal_OT_Rate = New frmCal_OT_Rate
            Else
                If fCal_OT_Rate.IsDisposed = True Then
                    fCal_OT_Rate = New frmCal_OT_Rate
                End If
            End If
            fCal_OT_Rate.MdiParent = Me
            fCal_OT_Rate.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub MenuWorkHolidaySpacial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuWorkHolidaySpacial.Click
        Try
            If fWorkSpecial Is Nothing Then
                fWorkSpecial = New frmWorkSpecial
            Else
                If fWorkSpecial.IsDisposed = True Then
                    fWorkSpecial = New frmWorkSpecial
                End If
            End If
            fWorkSpecial.MdiParent = Me
            fWorkSpecial.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

   
    Private Sub MenuItem9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click

        Try
            If fLimitHourOT Is Nothing Then
                fLimitHourOT = New frmLimitHourOT
            Else
                If fLimitHourOT.IsDisposed = True Then
                    fLimitHourOT = New frmLimitHourOT
                End If
            End If
            fLimitHourOT.MdiParent = Me
            fLimitHourOT.WindowState = FormWindowState.Maximized
            fLimitHourOT.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try


    End Sub

    Private Sub mnuReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReport.Click

    End Sub

    Private Sub mnucalculationAbs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnucalculationAbs.Click
        Try
            If fEmpCalAbs Is Nothing Then
                fEmpCalAbs = New frmEmpCalAbs
            Else
                If fEmpCalAbs.IsDisposed = True Then
                    fEmpCalAbs = New frmEmpCalAbs
                End If
            End If
            fEmpCalAbs.BringToFront()
            fEmpCalAbs.MdiParent = Me
            fEmpCalAbs.WindowState = FormWindowState.Maximized
            fEmpCalAbs.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuWindows_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWindows.Click

    End Sub

   
  
    Private Sub TimeKaMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeKaMove.Click
        Try
            If fTimeKa_Move Is Nothing Then
                fTimeKa_Move = New frmTimeKa_Move
            Else
                If fTimeKa_Move.IsDisposed = True Then
                    fTimeKa_Move = New frmTimeKa_Move
                End If
            End If
            fTimeKa_Move.BringToFront()
            fTimeKa_Move.MdiParent = Me
            fTimeKa_Move.WindowState = FormWindowState.Maximized
            fTimeKa_Move.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
End Class
