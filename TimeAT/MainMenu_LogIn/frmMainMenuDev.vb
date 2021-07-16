Imports System.Windows.Forms
Imports TimeAttendance.utils
Imports System.IO
Imports System.Globalization
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.LookAndFeel

Public Class frmMainMenuDev
    Protected dbMgr As New DBManager
    Protected dbConnStr As String = dbMgr.getConnString

    Dim gData As New GetData

    Private Sub frmMainMenuDev_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ver() As String
        ver = Application.ProductVersion.Split(".")
        Me.Text = "Time Attendance v." & ver(0) & "." & ver(1) & "." & ver(2)

        RibbonControl.Minimized = True

        If U_Username <> "sa" Then

            Call LoadGetvisibleMenu()
        End If

        'Call checkGenMenuMasterOnPage()

        'T_Code.Text = UserId
        'T_Name.Text = GetEmpName(UserId.Trim)
    End Sub



    Function GetVisibleMenuVisibility(ByVal Menu_Id As String, ByVal Dt As DataTable) As DevExpress.XtraBars.BarItemVisibility
        '  Dim DW As DataView = Dt.DefaultView
        Dim DW As New DataView(Dt)
        DW.RowFilter = "Menu_Id='" & Menu_Id.Trim & "'"
        If DW.Count = 0 Then
            Return DevExpress.XtraBars.BarItemVisibility.Never
        Else
            Return DevExpress.XtraBars.BarItemVisibility.Always
        End If
    End Function

    Function GetVisibleMenuBoolean(ByVal Menu_Id As String, ByVal Dt As DataTable) As Boolean
        '  Dim DW As DataView = Dt.DefaultView
        Dim DW As New DataView(Dt)
        DW.RowFilter = "Menu_Id='" & Menu_Id.Trim & "'"
        If DW.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Function getDTPermision(ByVal GrpId As Integer) As DataTable
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Dim Grp_id As Integer = GetGrpId_byUser(UserId)  ' หากลุ่มสิทธิ์จาก  User ที่ login 


        Strsql = "Select Menu_id,Menu_Use ,* " &
                 " From GenMenu_Pattern " &
                    " where grpid=" & Grp_id & " And Menu_use=1 "

        Da = New SqlDataAdapter(Strsql, Conn)
        Da.Fill(Ds, "DATA")

        Return Ds.Tables("DATA")
    End Function

    Function GetGrpId_byUser(ByVal code As String) As Integer
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = "select GrpId from [User] where userid='" & code & "'"

        Try
            'OpenConnect(True)
            Da = New SqlDataAdapter(Strsql, Conn)
            Da.Fill(Ds, "DATA")
            'OpenConnect(False)

            With Ds.Tables("DATA")
                If .Rows.Count = 0 Then
                    Return 0
                Else
                    Return .Rows(0).Item("GrpId")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub Default_StyleChanged()

        Call SaveSkin()

    End Sub

    Private Sub SaveSkin()
        Dim Config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

        Try

            Config.AppSettings.Settings.Remove("SkinName")
            Config.AppSettings.Settings.Add("SkinName", LookAndFeel.ActiveSkinName)

            '<add key="SkinName" value="Office 2010 Black"/>

            ' Modify/Refresh App Setting
            Config.Save(ConfigurationSaveMode.Modified)
            ConfigurationManager.RefreshSection("appSettings")

            cValGolbal.SkinName = LookAndFeel.ActiveSkinName
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Error")
            Exit Sub
        End Try

        'MsgBox("บันทึกเรียบร้อยแล้ว", MsgBoxStyle.Information, Me.Text)
    End Sub

    Private Sub mnuSkin_GalleryItemClick(sender As Object, e As GalleryItemClickEventArgs) Handles mnuSkin.GalleryItemClick
        AddHandler UserLookAndFeel.Default.StyleChanged, New EventHandler(AddressOf Default_StyleChanged)
    End Sub

    Private Sub mnuPermissionTimeAtt_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuPermissionTimeAtt.ItemClick
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

    Private Sub mnuManageTime_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuManageTime.ItemClick
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

    Private Sub mnuOvertime_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuOvertime.ItemClick
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

    Private Sub mnuLateTime_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuLateTime.ItemClick
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

    Private Sub mnuabsenceTime_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuabsenceTime.ItemClick
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

    Private Sub mnuInputLeaveData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuInputLeaveData.ItemClick
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

    Private Sub mnuCompanyCenter_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuCompanyCenter.ItemClick
        Try
            If fCompany Is Nothing Then
                fCompany = New frmCompany
            Else
                If fCompany.IsDisposed = True Then
                    fCompany = New frmCompany
                End If
            End If
            fCompany.BringToFront()
            fCompany.MdiParent = Me
            '  fRptTimeTableByMonth.WindowState = FormWindowState.Maximized
            fCompany.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnumodelcalculations_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnumodelcalculations.ItemClick
        Try
            If fMainConfig Is Nothing Then
                fMainConfig = New frmMainConfig
            Else
                If fMainConfig.IsDisposed = True Then
                    fMainConfig = New frmMainConfig
                End If
            End If
            'fMainConfig.BringToFront()
            'fMainConfig.MdiParent = Me
            'fMainConfig.WindowState = FormWindowState.Maximized
            'fMainConfig.Show()

            fMainConfig.BringToFront()
            fMainConfig.MdiParent = Me
            fMainConfig.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuworkinggroup_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuworkinggroup.ItemClick
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

    Private Sub mnuSpacialKa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSpacialKa.ItemClick
        Try
            If fKa_Spacial Is Nothing Then
                fKa_Spacial = New frmKa_Spacial
            Else
                If fKa_Spacial.IsDisposed = True Then
                    fKa_Spacial = New frmKa_Spacial
                End If
            End If
            fKa_Spacial.BringToFront()
            fKa_Spacial.MdiParent = Me
            fKa_Spacial.WindowState = FormWindowState.Maximized
            fKa_Spacial.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuDeterminedTime_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuDeterminedTime.ItemClick
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
            fTimeKa.WindowState = FormWindowState.Maximized
            fTimeKa.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuDeterminedTimeEmpByOne_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuDeterminedTimeEmpByOne.ItemClick
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

    Private Sub mnuDeterminedTimeEmpByDate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuDeterminedTimeEmpByDate.ItemClick
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

    Private Sub mnurptTimeWork_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnurptTimeWork.ItemClick
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

    Private Sub mnurptEmpWorkDetail1_M_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnurptEmpWorkDetail1_M.ItemClick
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
            fRptAllEmpWork_Detail.WindowState = FormWindowState.Normal
            fRptAllEmpWork_Detail.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnurptAllemployeework2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnurptAllemployeework2.ItemClick
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
            fRptAllEmpWork.WindowState = FormWindowState.Normal
            fRptAllEmpWork.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnurptScheduleWorkAllEmp2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnurptScheduleWorkAllEmp2.ItemClick
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

    Private Sub mnurptemployeeByDate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnurptemployeeByDate.ItemClick
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
            fRPTEmpValAbsLateByDate.WindowState = FormWindowState.Normal
            fRPTEmpValAbsLateByDate.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub munOvertimeLeage_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles munOvertimeLeage.ItemClick
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

    Private Sub mnuUserPass_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuUserPass.ItemClick
        Try
            If fPermission Is Nothing Then
                fPermission = New frmPermission
            Else
                If fPermission.IsDisposed = True Then
                    fPermission = New frmPermission
                End If
            End If
            fPermission.WindowState = FormWindowState.Maximized
            fPermission.MdiParent = fMainMenuHD
            fPermission.BringToFront()
            fPermission.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuPerPattern_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuPerPattern.ItemClick
        Try
            If fGenGroupMenuMasterHD Is Nothing Then
                fGenGroupMenuMasterHD = New frmGenGroupMenuMasterHD
            Else
                If fGenGroupMenuMasterHD.IsDisposed = True Then
                    fGenGroupMenuMasterHD = New frmGenGroupMenuMasterHD
                End If
            End If

            fGenGroupMenuMasterHD.MdiParent = fMainMenuHD
            fGenGroupMenuMasterHD.BringToFront()
            fGenGroupMenuMasterHD.WindowState = FormWindowState.Maximized
            fGenGroupMenuMasterHD.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuPerUser_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuPerUser.ItemClick
        Try
            If fSetUserLogIn Is Nothing Then
                fSetUserLogIn = New frmSetUserLogIn
            Else
                If fSetUserLogIn.IsDisposed = True Then
                    fSetUserLogIn = New frmSetUserLogIn
                End If
            End If

            fSetUserLogIn.MdiParent = fMainMenuHD
            fSetUserLogIn.BringToFront()
            fSetUserLogIn.WindowState = FormWindowState.Maximized
            fSetUserLogIn.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuProcessOT_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuProcessOT.ItemClick
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

    Private Sub mnucalculationLate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnucalculationLate.ItemClick
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

    Private Sub mnucalculationAbs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnucalculationAbs.ItemClick
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

    Private Sub mnuSetLeave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSetLeave.ItemClick
        Try
            If fWorkingStatus Is Nothing Then
                fWorkingStatus = New frmWorkingStatus
            Else
                If fWorkingStatus.IsDisposed = True Then
                    fWorkingStatus = New frmWorkingStatus
                End If
            End If

            'fWorkingStatus.MdiParent = Me
            'fWorkingStatus.Show()

            fWorkingStatus.BringToFront()
            fWorkingStatus.MdiParent = Me
            fWorkingStatus.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuSetabsenceTimeByYear_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSetabsenceTimeByYear.ItemClick
        Try
            If fPrivilegeVal Is Nothing Then
                fPrivilegeVal = New frmPrivilegeVal
            Else
                If fPrivilegeVal.IsDisposed = True Then
                    fPrivilegeVal = New frmPrivilegeVal
                End If
            End If
            'fPrivilegeVal.BringToFront()
            'fPrivilegeVal.MdiParent = Me
            'fPrivilegeVal.WindowState = FormWindowState.Maximized
            'fPrivilegeVal.Show()

            fPrivilegeVal.BringToFront()
            fPrivilegeVal.MdiParent = Me
            fPrivilegeVal.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuSetholiday_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSetholiday.ItemClick
        Try
            If fHolidayYear Is Nothing Then
                fHolidayYear = New frmHolidayYear_New
            Else
                If fHolidayYear.IsDisposed = True Then
                    fHolidayYear = New frmHolidayYear_New
                End If
            End If
            'fHolidayYear.MdiParent = Me
            'fHolidayYear.Show()

            fHolidayYear.BringToFront()
            fHolidayYear.MdiParent = Me
            fHolidayYear.Show()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuOTBasic_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuOTBasic.ItemClick

    End Sub

    Private Sub mnusetdelaytime(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnusetdelaytime1.ItemClick
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

    Private Sub mnusetdelayOT_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnusetdelayOT.ItemClick
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

    Private Sub mnuSetCancelDelayOTByDay_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSetCancelDelayOTByDay.ItemClick
        Try
            If fEmpCalOTDeducRate_CancelByDate Is Nothing Then
                fEmpCalOTDeducRate_CancelByDate = New frmEmpCalOTDeducRate_CancelByDate
            Else
                If fEmpCalOTDeducRate_CancelByDate.IsDisposed = True Then
                    fEmpCalOTDeducRate_CancelByDate = New frmEmpCalOTDeducRate_CancelByDate
                End If
            End If
            fEmpCalOTDeducRate_CancelByDate.MdiParent = Me
            fEmpCalOTDeducRate_CancelByDate.WindowState = FormWindowState.Maximized
            fEmpCalOTDeducRate_CancelByDate.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub


    Private Sub mnuOTbyDay_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuOTbyDay.ItemClick
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

    Private Sub MenuWorkHolidaySpacial_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles MenuWorkHolidaySpacial.ItemClick
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

    Private Sub mnuOTbyDay1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuOTbyDay1.ItemClick
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

    Private Sub mnulimitOT_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnulimitOT.ItemClick
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

    Private Sub mnuMasterConfig_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuMasterConfig.ItemClick
        Try
            If fGenMenuMaster Is Nothing Then
                fGenMenuMaster = New frmGenMenuMaster
            Else
                If fGenMenuMaster.IsDisposed = True Then
                    fGenMenuMaster = New frmGenMenuMaster
                End If
            End If
            fGenMenuMaster.MdiParent = fMainMenuHD
            fGenMenuMaster.BringToFront()
            '  fRpt_EmpDetail.WindowState = FormWindowState.Maximized
            fGenMenuMaster.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub


    Private Sub LoadGetvisibleMenu()
        Dim dt As DataTable = getDTPermision(UserId.Trim)

        '  ปรับปรุงยอด

        mnuDailyUpdate.Visible = GetVisibleMenuBoolean(mnuDailyUpdate.Tag, dt)
        mnuPermissionTimeAtt.Visibility = GetVisibleMenuVisibility(mnuPermissionTimeAtt.Tag, dt)
        mnuManageTime.Visibility = GetVisibleMenuVisibility(mnuManageTime.Tag, dt)
        mnuOvertime.Visibility = GetVisibleMenuVisibility(mnuOvertime.Tag, dt)
        mnuLateTime.Visibility = GetVisibleMenuVisibility(mnuLateTime.Tag, dt)
        mnuabsenceTime.Visibility = GetVisibleMenuVisibility(mnuabsenceTime.Tag, dt)
        mnuInputLeaveData.Visibility = GetVisibleMenuVisibility(mnuInputLeaveData.Tag, dt)



        ' ตั้งค่า
        mnuConfiguration.Visible = GetVisibleMenuBoolean(mnuConfiguration.Tag, dt)
        mnuMConfig.Visible = GetVisibleMenuBoolean(mnuMConfig.Tag, dt)
        mnuCompanyCenter.Visibility = GetVisibleMenuVisibility(mnuCompanyCenter.Tag, dt)
        mnumodelcalculations.Visibility = GetVisibleMenuVisibility(mnumodelcalculations.Tag, dt)
        mnuEmp.Visibility = GetVisibleMenuVisibility(mnuEmp.Tag, dt)
        mnuDivision.Visibility = GetVisibleMenuVisibility(mnuDivision.Tag, dt)
        mnuDepartment.Visibility = GetVisibleMenuVisibility(mnuDepartment.Tag, dt)
        mnuMWorkTime.Visible = GetVisibleMenuBoolean(mnuMWorkTime.Tag, dt)
        '    mnuworkinggroup.Visibility = GetVisibleMenuVisibility(mnuworkinggroup.Tag, dt)  ซ่อนเอาไว้ ไม่ได้ใช้
        mnuSpacialKa.Visibility = GetVisibleMenuVisibility(mnuSpacialKa.Tag, dt)
        mnuDeterminedTime.Visibility = GetVisibleMenuVisibility(mnuDeterminedTime.Tag, dt)
        mnuDeterminedTimeEmp.Visibility = GetVisibleMenuVisibility(mnuDeterminedTimeEmp.Tag, dt)
        mnuDeterminedTimeEmpByOne.Visibility = GetVisibleMenuVisibility(mnuDeterminedTimeEmpByOne.Tag, dt)
        mnuDeterminedTimeEmpByDate.Visibility = GetVisibleMenuVisibility(mnuDeterminedTimeEmpByDate.Tag, dt)
        mnuMOpenCalculate.Visible = GetVisibleMenuBoolean(mnuMOpenCalculate.Tag, dt)
        mnuProcessOT.Visibility = GetVisibleMenuVisibility(mnuProcessOT.Tag, dt)
        mnucalculationLate.Visibility = GetVisibleMenuVisibility(mnucalculationLate.Tag, dt)
        mnucalculationAbs.Visibility = GetVisibleMenuVisibility(mnucalculationAbs.Tag, dt)
        mnuMVacationHolYear.Visible = GetVisibleMenuBoolean(mnuMVacationHolYear.Tag, dt)
        mnuSetLeave.Visibility = GetVisibleMenuVisibility(mnuSetLeave.Tag, dt)
        mnuSetabsenceTimeByYear.Visibility = GetVisibleMenuVisibility(mnuSetabsenceTimeByYear.Tag, dt)
        mnuSetholiday.Visibility = GetVisibleMenuVisibility(mnuSetholiday.Tag, dt)
        MenuWorkHolidaySpacial.Visibility = GetVisibleMenuVisibility(MenuWorkHolidaySpacial.Tag, dt)
        mnuMOtherCondition.Visible = GetVisibleMenuBoolean(mnuMOtherCondition.Tag, dt)
        mnuOT.Visibility = GetVisibleMenuVisibility(mnuOT.Tag, dt)
        '    mnuOTBasic.Visibility = GetVisibleMenuVisibility(mnuOTBasic.Tag, dt)  ซ่อนเอาไว้ ยังไม่ใช้
        mnusetOT.Visibility = GetVisibleMenuVisibility(mnusetOT.Tag, dt)
        mnusetdelaytime1.Visibility = GetVisibleMenuVisibility(mnusetdelaytime1.Tag, dt)
        mnusetdelayOT.Visibility = GetVisibleMenuVisibility(mnusetdelayOT.Tag, dt)
        mnuSetCancelDelayOTByDay.Visibility = GetVisibleMenuVisibility(mnuSetCancelDelayOTByDay.Tag, dt)
        mnuOTbyDay.Visibility = GetVisibleMenuVisibility(mnuOTbyDay.Tag, dt)
        mnulimitOT.Visibility = GetVisibleMenuVisibility(mnulimitOT.Tag, dt)


        ' รายงาน
        mnuReport.Visible = GetVisibleMenuBoolean(mnuReport.Tag, dt)
        mnurptTimeWork.Visibility = GetVisibleMenuVisibility(mnurptTimeWork.Tag, dt)
        mnurptEmpWorkDetail1_M.Visibility = GetVisibleMenuVisibility(mnurptEmpWorkDetail1_M.Tag, dt)
        mnurptAllemployeework2.Visibility = GetVisibleMenuVisibility(mnurptAllemployeework2.Tag, dt)
        mnurptScheduleWorkAllEmp2.Visibility = GetVisibleMenuVisibility(mnurptScheduleWorkAllEmp2.Tag, dt)
        mnurptemployeeByDate.Visibility = GetVisibleMenuVisibility(mnurptemployeeByDate.Tag, dt)
        munOvertimeLeage.Visibility = GetVisibleMenuVisibility(munOvertimeLeage.Tag, dt)


        ' กำหนดสิทธิ์
        mnuPermission.Visible = GetVisibleMenuBoolean(mnuPermission.Tag, dt)
        mnuUserPass.Visibility = GetVisibleMenuVisibility(mnuUserPass.Tag, dt)
        mnuPerPattern.Visibility = GetVisibleMenuVisibility(mnuPerPattern.Tag, dt)
        mnuPerUser.Visibility = GetVisibleMenuVisibility(mnuPerUser.Tag, dt)


    End Sub

    Function GevVisibleMenu(ByVal MenuId As String, ByVal Empcode As String) As Boolean
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""


        Strsql = "Select *  " &
               " from GenMenu_User " &
                    " Where  app='" & App_Project.Trim & "' " &
                            " And userid='" & Empcode & "'" &
                            " And menu_id='" & MenuId & "' " &
                            " And Menu_Use=1"

        Try
            'OpenConnect(True)
            Da = New SqlDataAdapter(Strsql, Conn)
            Da.Fill(Ds, "DATA")
            'OpenConnect(False)

            With Ds.Tables("DATA")
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

    Function GevVisibleMenu_1(ByVal MenuId As String, ByVal Empcode As String) As Integer
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""


        Strsql = "select *  " &
               " from GenMenu_User " &
                    " Where  app='" & App_Project.Trim & "' " &
                            " And userid='" & Empcode & "'" &
                            " And menu_id='" & MenuId & "' " &
                            " And Menu_Use=1"

        Try
            'OpenConnect(True)
            Da = New SqlDataAdapter(Strsql, Conn)
            Da.Fill(Ds, "DATA")
            'OpenConnect(False)

            With Ds.Tables("DATA")
                If .Rows.Count = 0 Then
                    Return 1
                Else
                    Return 0
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function



    Private Sub mnuEmp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuEmp.ItemClick

        Try
            If fEmp Is Nothing Then
                fEmp = New frmVendorLicence
            Else
                If fEmp.IsDisposed = True Then
                    fEmp = New frmVendorLicence
                End If
            End If
            fEmp.MdiParent = Me
            fEmp.WindowState = FormWindowState.Maximized
            fEmp.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuDivision_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuDivision.ItemClick
        Try
            If fDivision Is Nothing Then
                fDivision = New frmDivision
            Else
                If fDivision.IsDisposed = True Then
                    fDivision = New frmDivision
                End If
            End If
            fDivision.MdiParent = Me
            fDivision.WindowState = FormWindowState.Normal
            fDivision.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try


    End Sub

    Private Sub mnuDepartment_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuDepartment.ItemClick



        Try
            If fDepartment Is Nothing Then
                fDepartment = New frmDepartment
            Else
                If fDepartment.IsDisposed = True Then
                    fDepartment = New frmDepartment
                End If
            End If
            fDepartment.MdiParent = Me
            fDepartment.WindowState = FormWindowState.Normal
            fDepartment.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuExitApp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuExitApp.ItemClick
        Me.Close()
    End Sub
End Class