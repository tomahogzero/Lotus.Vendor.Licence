Imports System.Data
Imports System.Data.SqlClient

Imports DevComponents.DotNetBar
Imports DevComponents.AdvTree
Imports System.Data.OleDb

Imports System.IO
Imports System.Globalization
Imports TimeAttendance.utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Data

Public Class frmGenGroupMenuMasterHD
    Protected dbMgr As New DBManager
    Protected dbConnStr As String = dbMgr.getConnString

    'Private Sub frmGenGroupMenuMasterHD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    btnDelete.Visible = False
    '    btnEdit.Visible = False
    '    '  btnAdd.Visible = False
    '    btnClear.Visible = False
    '    btnPrint.Visible = False
    '    btnSearch.Visible = False

    'btnAdd.Visible = True

    'PG.Visible = True
    'Call LoadDataPattern()
    'PG.Visible = False

    'btnAdd.Text = "บันทึก"
    '   End Sub

    Public Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If lblPermissionName.Text = "" Then
            ' MsgBox("กรุณาดับเบิ้ลคลิ๊กกลุ่มสิทธิ์เพื่อทำการกำหนดกลุ่มสิทธิ์", MsgBoxStyle.Information, Me.Text)
            MsgBox(My.Resources.res_warning_message_spacial.permissionGroup_selectdata, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        '  ปรับปรุงยอด
        Call UpdateStatusMenu(mnuDailyUpdate.Tag, lblPermissionName.Text.Trim, IIf(mnuDailyUpdate.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuPermissionTimeAtt.Tag, lblPermissionName.Text.Trim, IIf(mnuPermissionTimeAtt.Checked, 1, 0), 0, 0, IIf(mnuPermissionTimeAtt_Excel.Checked, 1, 0))
        Call UpdateStatusMenu(mnuManageTime.Tag, lblPermissionName.Text.Trim, IIf(mnuManageTime.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuOvertime.Tag, lblPermissionName.Text.Trim, IIf(mnuOvertime.Checked, 1, 0), 0, 0, IIf(mnuOvertime_Excel.Checked, 1, 0))
        Call UpdateStatusMenu(mnuLateTime.Tag, lblPermissionName.Text.Trim, IIf(mnuLateTime.Checked, 1, 0), 0, 0, IIf(mnuLateTime_Excel.Checked, 1, 0))
        Call UpdateStatusMenu(mnuabsenceTime.Tag, lblPermissionName.Text.Trim, IIf(mnuabsenceTime.Checked, 1, 0), 0, 0, IIf(mnuabsenceTime_Excel.Checked, 1, 0))
        Call UpdateStatusMenu(mnuInputLeaveData.Tag, lblPermissionName.Text.Trim, IIf(mnuInputLeaveData.Checked, 1, 0), IIf(mnuInputLeaveData_Approve.Checked, 1, 0), 0, 0)


        ' ตั้งค่า
        Call UpdateStatusMenu(mnuConfiguration.Tag, lblPermissionName.Text.Trim, IIf(mnuConfiguration.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuMConfig.Tag, lblPermissionName.Text.Trim, IIf(mnuMConfig.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuCompanyCenter.Tag, lblPermissionName.Text.Trim, IIf(mnuCompanyCenter.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnumodelcalculations.Tag, lblPermissionName.Text.Trim, IIf(mnumodelcalculations.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuEmp.Tag, lblPermissionName.Text.Trim, IIf(mnuEmp.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuDivision.Tag, lblPermissionName.Text.Trim, IIf(mnuDivision.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuDepartment.Tag, lblPermissionName.Text.Trim, IIf(mnuDepartment.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuMWorkTime.Tag, lblPermissionName.Text.Trim, IIf(mnuMWorkTime.Checked, 1, 0), 0, 0, 0)
        '    Call UpdateStatusMenu(mnuworkinggroup.Tag, lblPermissionName.Text.Trim, IIf(mnuworkinggroup.Checked, 1, 0), 0, 0,0)
        Call UpdateStatusMenu(mnuSpacialKa.Tag, lblPermissionName.Text.Trim, IIf(mnuSpacialKa.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuDeterminedTime.Tag, lblPermissionName.Text.Trim, IIf(mnuDeterminedTime.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuDeterminedTimeEmp.Tag, lblPermissionName.Text.Trim, IIf(mnuDeterminedTimeEmp.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuDeterminedTimeEmpByOne.Tag, lblPermissionName.Text.Trim, IIf(mnuDeterminedTimeEmpByOne.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuDeterminedTimeEmpByDate.Tag, lblPermissionName.Text.Trim, IIf(mnuDeterminedTimeEmpByDate.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuMOpenCalculate.Tag, lblPermissionName.Text.Trim, IIf(mnuMOpenCalculate.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuProcessOT.Tag, lblPermissionName.Text.Trim, IIf(mnuProcessOT.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnucalculationLate.Tag, lblPermissionName.Text.Trim, IIf(mnucalculationLate.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnucalculationAbs.Tag, lblPermissionName.Text.Trim, IIf(mnucalculationAbs.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuMVacationHolYear.Tag, lblPermissionName.Text.Trim, IIf(mnuMVacationHolYear.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuSetLeave.Tag, lblPermissionName.Text.Trim, IIf(mnuSetLeave.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuSetabsenceTimeByYear.Tag, lblPermissionName.Text.Trim, IIf(mnuSetabsenceTimeByYear.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuSetholiday.Tag, lblPermissionName.Text.Trim, IIf(mnuSetholiday.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(MenuWorkHolidaySpacial.Tag, lblPermissionName.Text.Trim, IIf(MenuWorkHolidaySpacial.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuMOtherCondition.Tag, lblPermissionName.Text.Trim, IIf(mnuMOtherCondition.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuOT.Tag, lblPermissionName.Text.Trim, IIf(mnuOT.Checked, 1, 0), 0, 0, 0)
        '    Call UpdateStatusMenu(mnuOTBasic.Tag, lblPermissionName.Text.Trim, IIf(mnuOTBasic.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnusetOT.Tag, lblPermissionName.Text.Trim, IIf(mnusetOT.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnusetdelaytime1.Tag, lblPermissionName.Text.Trim, IIf(mnusetdelaytime1.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnusetdelayOT.Tag, lblPermissionName.Text.Trim, IIf(mnusetdelayOT.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuSetCancelDelayOTByDay.Tag, lblPermissionName.Text.Trim, IIf(mnuSetCancelDelayOTByDay.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuOTbyDay.Tag, lblPermissionName.Text.Trim, IIf(mnuOTbyDay.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnulimitOT.Tag, lblPermissionName.Text.Trim, IIf(mnulimitOT.Checked, 1, 0), 0, 0, 0)


        ' รายงาน
        Call UpdateStatusMenu(mnuReport.Tag, lblPermissionName.Text.Trim, IIf(mnuReport.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnurptTimeWork.Tag, lblPermissionName.Text.Trim, IIf(mnurptTimeWork.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnurptEmpWorkDetail1_M.Tag, lblPermissionName.Text.Trim, IIf(mnurptEmpWorkDetail1_M.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnurptAllemployeework2.Tag, lblPermissionName.Text.Trim, IIf(mnurptAllemployeework2.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnurptScheduleWorkAllEmp2.Tag, lblPermissionName.Text.Trim, IIf(mnurptScheduleWorkAllEmp2.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnurptemployeeByDate.Tag, lblPermissionName.Text.Trim, IIf(mnurptemployeeByDate.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(munOvertimeLeage.Tag, lblPermissionName.Text.Trim, IIf(munOvertimeLeage.Checked, 1, 0), 0, 0, 0)


        ' กำหนดสิทธิ์
        Call UpdateStatusMenu(mnuPermission.Tag, lblPermissionName.Text.Trim, IIf(mnuPermission.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuUserPass.Tag, lblPermissionName.Text.Trim, IIf(mnuUserPass.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuPerPattern.Tag, lblPermissionName.Text.Trim, IIf(mnuPerPattern.Checked, 1, 0), 0, 0, 0)
        Call UpdateStatusMenu(mnuPerUser.Tag, lblPermissionName.Text.Trim, IIf(mnuPerUser.Checked, 1, 0), 0, 0, 0)

        '    MsgManager.ShowDialog(Me, "Messages", Me.Text, "Save_Complete", MessageBoxIcon.Information)

        ' MsgBox("บันทึกการกำหนดกลุ่มเมนูเรียบร้อย", MsgBoxStyle.Information, "บันทึก")
        MsgBox(My.Resources.res_warning_message.save_complete, MsgBoxStyle.Information, Me.Text)
    End Sub

    Private Sub btnAdd_P_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd_P.Click
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim Tn As SqlTransaction
        Dim db As New db
        '  Dim Strtype As String = ""
        '  Dim data As New ArrayList
        Dim dcmd As New SqlCommand

        If txtPermissionName.Text = "" Then
            ' MsgBox("กรุณากำหนดหัวข้อใหม่", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly)
            '  MsgManager.ShowDialog(Me, "Messages", Me.Text, "InPutPatternName", MessageBoxIcon.Information)
            '  MsgBox("กรุณาป้อนชื่อกลุ่มสิทธิ์", MsgBoxStyle.Information, "ชื่อกลุ่มสิทธิ์")
            MsgBox(My.Resources.res_warning_message_spacial.permission_please_input_groupname, MsgBoxStyle.Information, Me.Text)
            txtPermissionName.Focus()
            Exit Sub
        End If


        If txtPermissionName.Text.Trim <> txtPermisionName_Old.Text.Trim Then
            If ChkGroupSame(txtPermissionName.Text.Trim) = True Then ' เช็คว่ามีชื่อ UserLogIn นี้มาแล้วหรือไม่
                '  MsgBox("ชื่อกลุ่มมีอยู่แล้ว", MsgBoxStyle.Information, "ชื่อกลุ่มซ้ำ")
                MsgBox(My.Resources.res_warning_message_spacial.permission_groupsame, MsgBoxStyle.Information, Me.Text)
                txtPermissionName.SelectAll()
                txtPermissionName.Focus()
                Exit Sub
            End If
        End If


        Dim Grpid_Auto As Integer = GenGroupId_Auto()
        'Call OpenConnect(True)
        Tn = Conn.BeginTransaction
        dcmd.Transaction = Tn
        Try



            Strsql = "Insert Into genmenu_configgroup(GrpId,GrpName) Values (" & Grpid_Auto & ",'" & txtPermissionName.Text.Trim & "')"
            dcmd.Connection = Conn
            dcmd.CommandText = Strsql
            dcmd.ExecuteNonQuery()



            Strsql = "Insert Into Genmenu_Pattern(Menu_Id,PatternName,Menu_Name, " &
                            " Menu_NameEng,Menu_LinkFrom,APP,GrpId,Export_Excel) " &
                          " Select Menu_Id,'" & txtPermissionName.Text.Trim & "',Menu_Name,Menu_NameEng,Menu_LinkFrom,APP," & Grpid_Auto & ",0 " &
                          " From GenCreateMenu_Master " &
                          " Where App='" & App_Project & "'"


            ' OpenConnect(True)
            dcmd.Connection = Conn
            dcmd.CommandText = Strsql
            dcmd.ExecuteNonQuery()

            Tn.Commit()
            ' Call OpenConnect(False)
            ' MsgBox("บันทึกเรียบร้อย", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "แจ้งให้ทราบ")
            '     MsgManager.ShowDialog(Me, "Messages", Me.Text, "Save_Complete", MessageBoxIcon.Information)
            '   MsgBox("บันทึกเรียบร้อย", MsgBoxStyle.Information, "บันทึก")
            MsgBox(My.Resources.res_warning_message.save_complete, MsgBoxStyle.Information, Me.Text)

        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message)
        End Try
        '    fMainMenu.PG2.Visible = True
        '  Call LoadMenu()
        Call LoadDataPattern()
        Call Enacmd(True, False, False)
        txtPermissionName.Text = ""
        lblPermissionName.Text = ""
        txtPermissionName.Focus()
        '  fMainMenu.PG2.Visible = False
    End Sub

    Private Sub INSERT_PerGroup()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim Tn As SqlTransaction
        Dim db As New db
        Dim dcmd As New SqlCommand
        Dim Grpid_Auto As Integer = GenGroupId_Auto()
        Tn = Conn.BeginTransaction
        dcmd.Transaction = Tn
        Try
            Strsql = "Insert Into genmenu_configgroup(GrpId,GrpName) Values (" & Grpid_Auto & ",'" & txtPermissionName.Text.Trim & "')"
            dcmd.Connection = Conn
            dcmd.CommandText = Strsql
            dcmd.ExecuteNonQuery()
            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message)
        End Try
    End Sub

    Function GenGroupId_Auto() As Integer
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        '   Dim Tn As SqlTransaction
        Dim db As New db
        Dim dcmd As New SqlCommand

        '    Tn = Conn.BeginTransaction
        '   dcmd.Transaction = Tn
        Strsql = "Select Isnull(Max(GrpId),'') as GrpId from genmenu_configgroup "
        ' Try
        Da = New SqlDataAdapter(Strsql, Conn)
        Da.Fill(Ds, "DATA")

        With Ds.Tables("DATA")
            If .Rows.Count = 0 Then
                Return 1
            Else
                Return .Rows(0).Item("GrpId") + 1
            End If
        End With
        ' Catch ex As Exception
        '  Return False

        '   End Try
    End Function

    Function ChkUserLogin(ByVal UserLogInName As String) As Boolean
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strsql As String = ""

        strsql = "Select * from " &
                    " Genmenu_pattern " &
                    " Where PatternName='" & UserLogInName.Trim & "' " &
                            " And APP='" & App_Project.Trim & "'"

        Try
            'OpenConnect(True)
            Da = New SqlDataAdapter(strsql, Conn)
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
            Return False

        End Try
        txtPermissionName.Text = ""

    End Function

    Function ChkGroupSame(ByVal GrpName As String) As Boolean
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strsql As String = ""

        strsql = "Select * from genmenu_configgroup  where GrpName='" & GrpName & "'"

        Try
            'OpenConnect(True)
            Da = New SqlDataAdapter(strsql, Conn)
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
            Return False

        End Try

    End Function

    Private Sub LoadDataPattern()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strsql As String = ""
        'Dim arrData() As String
        'Dim List As ListViewItem

        'strsql = "Select ROW_NUMBER() OVER(ORDER BY p.PatternName) as row, PatternName = Isnull(p.PatternName,''),p.GrpId  " &
        '            " from genmenu_pattern p " &
        '                    " Left Join genmenu_configgroup mc" &
        '                                " On p.GrpId=Mc.GrpId " &
        '            " Where p.PatternName<>'sa'  " &
        '                    " And p.APP='" & App_Project.Trim & "'" &
        '            " Group by p.PatternName,p.GrpId"

        strsql = "Select ROW_NUMBER() OVER(ORDER BY GrpName) as row,* from genmenu_configgroup  "

        Try
            'OpenConnect(True)
            Da = New SqlDataAdapter(strsql, Conn)
            Da.Fill(Ds, "data")

            GcpermissionLogin.DataSource = Ds
            GcpermissionLogin.DataMember = "data"
            'OpenConnect(False)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly)

        End Try
    End Sub

    'Private Sub LoadData()
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim Strsql As String = ""

    '    Strsql = "Select Menu_Id,Menu_Name,No_Pic " &
    '             " from GenCreateMenu_Master " &
    '             " Where App='" & App_Project.Trim & "' And " &
    '                    " St_MenuMain = 1" &
    '             " Order by RunningNo"

    '    Try
    '        Da = New SqlDataAdapter(Strsql, Conn)
    '        Da.Fill(Ds, "DATA")

    '        With Ds.Tables("DATA")
    '            If .Rows.Count = 0 Then
    '                AdvTree2.Nodes.Clear()
    '            Else
    '                'หาข้อมูลหลักก่อน
    '                AdvTree2.Nodes.Clear()

    '                ' mark ple 25/07/2019
    '                'fMainMenuHD.PG2.Maximum = .Rows.Count
    '                Dim i As Integer = 0
    '                For Each Dr As DataRow In .Rows


    '                    Dim M_Id As String
    '                    Dim nd As New DevComponents.AdvTree.Node
    '                    Dim Cx1 As New DevComponents.AdvTree.Cell
    '                    Dim Cx2 As New DevComponents.AdvTree.Cell


    '                    ' กำหนดตำแหน่ง Icon อันนี้อยู่ตอนกำหนด Config ว่าจะให้เป็นรูปไหน อยู่ที่ตัวเลขที่กำหนด เฉพาะเมนูหลัก
    '                    If Dr("No_PiC") = 1 Then
    '                        '   nd.Image = Global.Warehouse.My.Resources.Resources.Settings_icon_24
    '                    ElseIf Dr("No_PiC") = 2 Then
    '                        '  nd.Image = Global.Warehouse.My.Resources.Resources.Document_icon_x_24
    '                    ElseIf Dr("No_PiC") = 3 Then
    '                        '  nd.Image = Global.Warehouse.My.Resources.Resources.wire_transfer_icon_24
    '                    ElseIf Dr("No_PiC") = 4 Then
    '                        '  nd.Image = Global.Warehouse.My.Resources.Resources.Printer_icon_24
    '                    ElseIf Dr("No_PiC") = 5 Then
    '                        '  nd.Image = Global.Warehouse.My.Resources.Resources.Office_Custome_M_24
    '                    End If


    '                    M_Id = Dr("Menu_Id")

    '                    'Chkbox หน้าเมนูหลัก
    '                    nd.CheckBoxThreeState = True
    '                    nd.CheckBoxVisible = True



    '                    Cx1.Text = Dr("Menu_Id")
    '                    Cx2.Text = Dr("Menu_Name")

    '                    ' เช็คการกำหนดสิทธิ์
    '                    If ChkPermision_FromMenu_Id(M_Id, lblPermissionName.Text.Trim) = True Then
    '                        nd.Checked = True
    '                    Else
    '                        nd.Checked = False
    '                    End If
    '                    '================


    '                    ' Treeview1.NodeStyle.BackColor = Color.Green
    '                    AdvTree2.Nodes.Add(nd)

    '                    '   AdvTree2.Nodes(i).Cells.Add(Cx1)
    '                    AdvTree2.Nodes(i).Cells.Add(Cx2)


    '                    Call LoadShowData(nd, Cx1.Text)  ' 
    '                    i += 1
    '                    ' fMainMenu.PG2.Value = i
    '                Next

    '            End If

    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub LoadMenu()
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim Strsql As String = ""

    '    Strsql = "Select Menu_Id,Menu_Name,No_Pic " &
    '             " from GenCreateMenu_Master " &
    '             " Where  App='" & App_Project.Trim & "' And " &
    '                        " St_MenuMain = 1 " &
    '             " Order by runningno"

    '    Try
    '        Da = New SqlDataAdapter(Strsql, Conn)
    '        Da.Fill(Ds, "DATA")

    '        With Ds.Tables("DATA")
    '            If .Rows.Count = 0 Then
    '                AdvTree2.Nodes.Clear()
    '            Else
    '                'หาข้อมูลหลักก่อน
    '                AdvTree2.Nodes.Clear()

    '                ' fMainMenuHD.PG2.Maximum = .Rows.Count
    '                PG.Maximum = .Rows.Count
    '                Dim i As Integer = 0
    '                For Each Dr As DataRow In .Rows


    '                    Dim M_Id As String
    '                    Dim nd As New DevComponents.AdvTree.Node
    '                    Dim Cx1 As New DevComponents.AdvTree.Cell
    '                    Dim Cx2 As New DevComponents.AdvTree.Cell


    '                    ' กำหนดตำแหน่ง Icon อันนี้อยู่ตอนกำหนด Config ว่าจะให้เป็นรูปไหน อยู่ที่ตัวเลขที่กำหนด เฉพาะเมนูหลัก
    '                    If Dr("No_PiC") = 1 Then
    '                        nd.Image = Global.TimeAttendance.My.Resources.Resources.Design_Database_development
    '                    ElseIf Dr("No_PiC") = 2 Then
    '                        nd.Image = Global.TimeAttendance.My.Resources.Resources.Icojam_Blue_Bits_User_settings
    '                    ElseIf Dr("No_PiC") = 3 Then
    '                        nd.Image = Global.TimeAttendance.My.Resources.Resources.Matter_Books
    '                    ElseIf Dr("No_PiC") = 4 Then
    '                        nd.Image = Global.TimeAttendance.My.Resources.Resources.Rafiqul_Hassan_Blogger_Key
    '                    Else
    '                        nd.Image = Nothing
    '                    End If

    '                    M_Id = Dr("Menu_Id")

    '                    'Chkbox หน้าเมนูหลัก
    '                    nd.CheckBoxThreeState = False
    '                    nd.CheckBoxVisible = True

    '                    Cx1.Text = Dr("Menu_Id")

    '                    Cx2.Text = Dr("Menu_Name")
    '                    Cx2.Tag = Dr("Menu_Id")

    '                    AdvTree2.Nodes.Add(nd)
    '                    AdvTree2.Nodes(i).Cells.Add(Cx2)

    '                    Call LoadShowMenu(nd, Cx1.Text)
    '                    i += 1
    '                    ' fMainMenuHD.PG2.Value = i
    '                    PG.Value = i
    '                Next

    '            End If

    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    '   End Sub

    ' เช็คการกำหนดการใช้สิทธิ์การใช้เมนูว่าบันทึก หรือกำหนไว้หรือยัง
    Function ChkPermision_FromMenu_Id(ByVal MenuId As String, ByVal PatternName As String) As Boolean
        Dim DA As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strsql As String = ""

        strsql = " Select Menu_Id from Genmenu_Pattern " &
                 " Where  APP='" & App_Project.Trim & "' And " &
                        " PatternName='" & PatternName.Trim & "' And " &
                        " Menu_Id='" & MenuId.Trim & "' And " &
                        " Menu_Use=1"


        Try
            DA = New SqlDataAdapter(strsql, Conn)
            DA.Fill(Ds, "DATA")

            With Ds.Tables("DATA")
                If .Rows.Count = 0 Then
                    Return False
                Else
                    Return True
                End If
            End With
        Catch ex As Exception
            Return False
        End Try


    End Function

    'Private Sub LoadShowData(ByVal nd As DevComponents.AdvTree.Node, ByVal MenuId As String)
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim Strsql As String = ""
    '    Dim dcmd As New SqlCommand

    '    Strsql = "Select M.S_Id" &
    '     " from GenMenu_Group M Left Join " &
    '             " GenCreateMenu_Master MT " &
    '                    " On M.M_Id=Mt.Menu_Id " &
    '     " Where APP='" & App_Project.Trim & "' And " &
    '                " M_Id='" & MenuId & "'" &
    '     " Order by M.M_Id,M.S_Id"

    '    Try
    '        'OpenConnect(True)
    '        Da = New SqlDataAdapter(Strsql, Conn)
    '        Da.Fill(Ds, "DATA")
    '        'OpenConnect(False)

    '        Dim I As Integer = 0
    '        With Ds.Tables("DATA")

    '            For Each Dr As DataRow In .Rows
    '                Dim Time As String = ""

    '                ' หาชื่อเมนูย่อย
    '                Dim S_Id As String
    '                Dim MenuName As String
    '                S_Id = Dr("S_Id")
    '                MenuName = GetNameMenu(Dr("S_Id"))


    '                Dim ndd As New DevComponents.AdvTree.Node

    '                ' Chkbox หน้าเมนู ย่อย
    '                ndd.CheckBoxThreeState = False
    '                ndd.CheckBoxVisible = True


    '                ' เช็คการกำหนดสิทธิ์ - ของเมนู ว่าได้มีการกำหนดการใช้ไว้หรือไม่
    '                If ChkPermision_FromMenu_Id(S_Id, lblPermissionName.Text.Trim) = True Then
    '                    ndd.Checked = True
    '                Else
    '                    ndd.Checked = False
    '                End If
    '                '================


    '                ndd.Text = MenuName
    '                ndd.VerticalCellLayoutAlignment = eHorizontalAlign.Center
    '                nd.Nodes.Add(ndd)


    '                Dim Cell_ As New DevComponents.AdvTree.Cell
    '                ' เช็คการกำหนดผู้อนุมัติในเมนู ว่ามีหรือไม่---------------------------------------------------------
    '                If ChkStatus_FormApprove(S_Id) = True Then
    '                    Cell_.CheckBoxThreeState = True
    '                    Cell_.CheckBoxVisible = True
    '                    Cell_.StyleMouseOver = Nothing
    '                    ' Cell_.Text = "สิทธิการอนุมัติ"
    '                    Cell_.Text = MsgManager.ShowLabel(Me, "Labels", "Approve") ' "ทำงาน"

    '                    'แสดงข้อมุลการบันทึก ว่ากำหนด หรือไม่
    '                    If ChkStatus_Approve(S_Id, lblPermissionName.Text.Trim) = True Then
    '                        Cell_.Checked = True
    '                    Else
    '                        Cell_.Checked = False
    '                    End If
    '                End If
    '                ndd.Cells.Add(Cell_)




    '                Dim Cell_1 As New DevComponents.AdvTree.Cell
    '                'เช็คว่ามีการกำหนดให้ฟอร์มนั้นกำหนด ReadOnly หรือไม่----------------------------------------------
    '                If ChkStatus_ReadOnly(S_Id) = True Then
    '                    Cell_1.CheckBoxThreeState = True
    '                    Cell_1.CheckBoxVisible = True
    '                    Cell_1.StyleMouseOver = Nothing
    '                    Cell_1.Text = "ReadOnly"


    '                    'แสดงข้อมุลการบันทึก ว่ากำหนด หรือไม่
    '                    If ChkStatus_ChkReadOnly(S_Id, lblPermissionName.Text.Trim) = True Then
    '                        Cell_1.Checked = True
    '                    Else
    '                        Cell_1.Checked = False
    '                    End If
    '                End If
    '                ndd.Cells.Add(Cell_1)

    '                If ChkMainGroupMenu(S_Id.Trim) = True Then
    '                    Call LoadShowData(ndd, S_Id)
    '                End If

    '            Next

    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    '    End Try

    'End Sub

    'Private Sub LoadShowMenu(ByVal nd As DevComponents.AdvTree.Node, ByVal MenuId As String)
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim Strsql As String = ""
    '    Dim dcmd As New SqlCommand

    '    Strsql = "select * from GenMenu_Group " &
    '             " where APP='" & App_Project.Trim & "' " &
    '                 " And  M_Id='" & MenuId.Trim & "'" &
    '             " Order by M_Id,S_Id"



    '    Try
    '        'OpenConnect(True)
    '        Da = New SqlDataAdapter(Strsql, Conn)
    '        Da.Fill(Ds, "DATA")
    '        'OpenConnect(False)

    '        Dim I As Integer = 0
    '        With Ds.Tables("DATA")

    '            For Each Dr As DataRow In .Rows
    '                Dim Time As String = ""
    '                I += 1
    '                ' หาชื่อเมนูย่อย
    '                Dim S_Id As String
    '                Dim MenuName As String
    '                S_Id = Dr("S_Id")
    '                MenuName = GetNameMenu(Dr("S_Id"))

    '                Dim ndd As New DevComponents.AdvTree.Node
    '                ' Chkbox หน้าเมนู ย่อย
    '                ndd.CheckBoxThreeState = False
    '                ndd.CheckBoxVisible = True


    '                ndd.Text = MenuName
    '                ndd.Tag = S_Id
    '                ndd.VerticalCellLayoutAlignment = eHorizontalAlign.Center
    '                nd.Nodes.Add(ndd)


    '                Dim Cell_ As New DevComponents.AdvTree.Cell
    '                ' เช็คการกำหนดผู้อนุมัติในเมนู ว่ามีหรือไม่---------------------------------------------------------
    '                If ChkStatus_FormApprove(S_Id) = True Then
    '                    Cell_.CheckBoxThreeState = False
    '                    Cell_.CheckBoxVisible = True
    '                    Cell_.StyleMouseOver = Nothing
    '                    Cell_.Text = MsgManager.ShowLabel(Me, "Labels", "Approve") ' "สิทธิการอนุมัติ"
    '                End If
    '                ndd.Cells.Add(Cell_)



    '                Dim Cell_1 As New DevComponents.AdvTree.Cell
    '                '  เช็คว่ามีการกำหนดให้ฟอร์มนั้นกำหนด ReadOnly หรือไม่----------------------------------------------
    '                If ChkStatus_ReadOnly(S_Id) = True Then
    '                    Cell_1.CheckBoxThreeState = False
    '                    Cell_1.CheckBoxVisible = True
    '                    Cell_1.StyleMouseOver = Nothing
    '                    Cell_1.Text = "ReadOnly"

    '                End If
    '                ndd.Cells.Add(Cell_1)


    '                ' เช็คถ้าไม่มีเมนูย่อยก็ไม่ต้องทำ
    '                If ChkMainGroupMenu(S_Id.Trim) = True Then
    '                    Call LoadShowMenu(ndd, S_Id)
    '                End If

    '            Next

    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    '    End Try

    'End Sub



    Function ChkMainGroupMenu(ByVal M_Id As String) As Boolean
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select * from GenMenu_Group " &
                 " Where  APP='" & App_Project.Trim & "' And " &
                 " M_Id='" & M_Id.Trim & "'" &
                 " Order by M_Id,S_Id"

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
            Return False
        End Try
    End Function

    Function ChkStatus_FormApprove(ByVal MenuId As String) As Boolean
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select Menu_Id from GenCreateMenu_Master " &
                 " Where  APP='" & App_Project.Trim & "' And " &
                        " Menu_Id='" & MenuId.Trim & "'And " &
                        " Form_Approve=1"

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

    Function ChkStatus_Approve(ByVal MenuName As String, ByVal PatternName As String) As Boolean
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select Menu_Id from GenMenu_Pattern " &
                 " Where  APP='" & App_Project.Trim & "' And " &
                        " Menu_Id='" & MenuName.Trim & "'And " &
                        " Menu_Approve=1 And " &
                        " PatternName='" & PatternName.Trim & "'"

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

    Function ChkStatus_ChkReadOnly(ByVal MenuName As String, ByVal PatternName As String) As Boolean
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select Menu_Id from GenMenu_Pattern " &
                 " Where  APP='" & App_Project.Trim & "' And " &
                        " Menu_Id='" & MenuName.Trim & "'And " &
                        " Menu_ReadOnly=1 And " &
                        " PatternName='" & PatternName.Trim & "'"

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

    Function ChkStatus_ReadOnly(ByVal MenuId As String) As Boolean
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select Menu_Id from GenCreateMenu_Master " &
                 " Where APP='" & App_Project.Trim & "' And " &
                        " Menu_Id='" & MenuId.Trim & "'And " &
                        " Menu_ReadOnly=1"

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


    Function GetNameMenu(ByVal MenuId As String) As String
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim Strsql As String

        Strsql = "Select Menu_Name " &
                 " from GenCreateMenu_Master " &
                 " Where  APP='" & App_Project.Trim & "' And " &
                                " Menu_Id='" & MenuId.Trim & "'"

        Try
            DA = New SqlDataAdapter(Strsql, Conn)
            DA.Fill(DS, "DATa")

            With DS.Tables("DATA")
                If .Rows.Count = 0 Then
                    Return ""
                Else
                    Return .Rows(0).Item("Menu_Name")
                End If
            End With
        Catch ex As Exception
            Return ""
        End Try
    End Function


    'Private Sub lblPermissionName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    'Call LoadData()
    '    'Call LoadMenu()

    '    PG.Visible = True
    '    ' mark ple 25/07/2019
    '    'fMainMenuHD.PG2.Visible = True
    '    If AdvTree2.Nodes.Count = 1 Then
    '        '  Call LoadMenu()
    '    End If
    '    Call GetData()
    '    PG.Visible = False
    '    ' fMainMenuHD.PG2.Visible = True
    'End Sub


    'Private Sub SubNodes(ByVal nd As DevComponents.AdvTree.Node)
    '    Dim MenuName As String = ""
    '    Dim MenuId As String = ""
    '    Dim ChkMenu As String = ""
    '    Dim MenuApprove As String = ""
    '    Dim MenuReadOnly As String = ""
    '    Dim ndd As New DevComponents.AdvTree.Node
    '    Dim i As Integer = 0
    '    'PG.Value = 0
    '    'PG.Maximum = nd.Nodes.Count
    '    'fMainMenu.PG2.Value = 0
    '    'fMainMenu.PG2.Maximum = nd.Nodes.Count



    '    For i = 0 To nd.Nodes.Count - 1
    '        'PG.Value = i + 1
    '        'fMainMenu.PG2.Value = i + 1

    '        MenuName = nd.Nodes(i).Cells(0).Text  ' Head
    '        MenuId = nd.Nodes(i).Cells(0).Tag  ' Head
    '        ' เมนู
    '        If nd.Nodes(i).Cells(0).Checked = True Then
    '            ChkMenu = True  ' เลือก
    '        Else
    '            ChkMenu = False ' ไม่เลือก
    '        End If

    '        ' อนุมัติ
    '        If nd.Nodes(i).Cells(1).Checked = True Then
    '            MenuApprove = True  ' เลือก
    '        Else
    '            MenuApprove = False ' ไม่เลือก
    '        End If

    '        ' ReadOnly
    '        If nd.Nodes(i).Cells(2).Checked = True Then
    '            MenuReadOnly = True  ' เลือก
    '        Else
    '            MenuReadOnly = False ' ไม่เลือก
    '        End If


    '        ' Update Head
    '        '    UpdateStatusMenu(MenuId.Trim, lblPermissionName1.Text.Trim, ChkMenu, MenuApprove, MenuReadOnly,)

    '        '  fMainMenu.PG2.Value = i

    '        Call SubNodes(nd.Nodes(i))
    '    Next


    'End Sub


    Private Sub UpdateStatusMenu(ByVal MenuId As String, ByVal UserName As String,
                                ByVal ChkUse As Boolean,
                                ByVal ChkApprove As Boolean,
                                ByVal ChkReadOnly As Boolean,
                                ByVal Export_Excel As Boolean)

        Dim Dcmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String = ""
        Dim Data As New ArrayList
        Dim db As New db
        Try

            Data.Clear() : strType = ""
            Data.Add(UserName.Trim) : strType &= "T"
            Data.Add(MenuId.Trim) : strType &= "T"
            Data.Add(ChkUse) : strType &= "B"
            Data.Add(ChkApprove) : strType &= "B"
            Data.Add(ChkReadOnly) : strType &= "B"
            Data.Add(App_Project.Trim) : strType &= "T"
            Data.Add(Export_Excel) : strType &= "B"

            strSQL = "Update  GenMenu_Pattern Set Menu_Use=@P3,Menu_Approve=@P4,Menu_ReadOnly=@P5,Export_Excel=@P7 " &
                                    " Where PatternName=@P1 And " &
                                    " Menu_Id=@P2 And " &
                                    " APP=@P6"

            '  Call OpenConnect(True)
            db.ExecuteCommand(Conn, Dcmd, strSQL, strType, Data)
            '  Call OpenConnect(False)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
            Exit Sub
        End Try
    End Sub


    'Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
    '    'Dim MenuName As String = ""
    '    'Dim MenuId As String = ""
    '    'Dim ChkMenu As Boolean
    '    'Dim nnd As New DevComponents.AdvTree.Node
    '    'Dim i As Integer
    '    'With AdvTree2
    '    '    For i = 0 To .Nodes.Count - 1
    '    '        MenuName = .Nodes(i).Cells(2).Text  ' Head
    '    '        MenuId = .Nodes(i).Cells(1).Text  ' Head

    '    '        ' เลือกหรือไม่
    '    '        If .Nodes(i).Checked = True Then
    '    '            ChkMenu = True  ' เลือก
    '    '        Else
    '    '            ChkMenu = False ' ไม่เลือก
    '    '        End If


    '    '        ' Update Head
    '    '        UpdateStatusMenu(MenuId.Trim, txtPermissionName.Text.Trim, ChkMenu, False, False)

    '    '        Call SubNodes(.Nodes(i))
    '    '    Next
    '    'End With
    '    'MsgBox("บันทึกเมนูต้นแบบเรียบร้อย", MsgBoxStyle.Information, "เมนูต้นแบบ")
    'End Sub





    Private Sub btnDel_P_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel_P.Click
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim Tn As SqlTransaction
        Dim db As New db
        Dim Strtype As String = ""
        Dim data As New ArrayList
        Dim dcmd As New SqlCommand

        '    If MsgBox("ต้องการลบกลุ่มสิทธิ์" & txtPermissionName.Text & "   หรือไม่", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "ลบ") = vbNo Then Exit Sub

        If MsgBox(My.Resources.res_warning_message.Confirm_Del, MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = vbNo Then Exit Sub


        If txtPermissionName.Text = "" Then
            Exit Sub
        End If
        'If txtPermissionName.Text = "sa" Then
        '    MsgBox("ไม่สามารถลบข้อมูล {sa} ได้เนื่องจากระบบได้กำหนดเป็นค่าเริ่มต้น")
        '    Exit Sub
        'End If

        ' Call OpenConnect(True)
        Tn = Conn.BeginTransaction
        dcmd.Transaction = Tn

        Try
            data.Clear() : Strtype = ""
            data.Add(txtPermissionName.Text.Trim) : Strtype &= "T"
            data.Add(App_Project.Trim) : Strtype &= "T"

            Strsql = "Delete From GenMenu_Pattern " &
                     " Where  PatternName=@P1 And " &
                           " APP='" & App_Project.Trim & "' "
            db.ExecuteCommand(Conn, dcmd, Strsql, Strtype, data)


            data.Clear() : Strtype = ""
            data.Add(txtGrpId.Text.Trim) : Strtype &= "T"

            Strsql = "Delete From genmenu_configgroup " &
                     " Where  GrpId=@P1"
            db.ExecuteCommand(Conn, dcmd, Strsql, Strtype, data)

            Tn.Commit()
            ' Call OpenConnect(False)
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message)
        End Try
        Call LoadDataPattern()
        Call Enacmd(True, False, False)
        txtPermissionName.Text = ""
        lblPermissionName.Text = ""
        txtPermissionName.Focus()
    End Sub

    'Private Sub GetData()
    '    Dim MenuId As String = ""
    '    For i As Integer = 0 To AdvTree2.Nodes.Count - 1
    '        '  MenuId = AdvTree2.Nodes(i).Cells(0).Tag
    '        MenuId = AdvTree2.Nodes(i).Cells(1).Tag

    '        If ChkData(MenuId.Trim, lblPermissionName1.Text.Trim) = True Then
    '            AdvTree2.Nodes(i).Checked = True
    '            '  AdvTree2.Nodes(i).Cells(1).Checked = True
    '        Else
    '            AdvTree2.Nodes(i).Checked = False
    '            '  AdvTree2.Nodes(i).Cells(1).Checked = False
    '        End If

    '        If AdvTree2.Nodes(i).Nodes.Count > 0 Then
    '            Call SubTree(AdvTree2.Nodes(i))
    '        End If
    '    Next
    'End Sub

    'Private Sub SubTree(ByVal nd As DevComponents.AdvTree.Node)
    '    Dim MenuId As String = ""

    '    '  fMainMenuHD.PG2.Value = 0
    '    PG.Value = 0
    '    For i As Integer = 0 To nd.Nodes.Count - 1
    '        ' fMainMenuHD.PG2.Maximum = nd.Nodes.Count - 1
    '        PG.Maximum = nd.Nodes.Count - 1
    '        MenuId = nd.Nodes(i).Tag

    '        'เช็คเมนู ว่าใช้หรือไม่ =================================================
    '        If ChkData(MenuId.Trim, lblPermissionName1.Text.Trim) = True Then
    '            '  nd.Nodes(i).Cells(1).Checked = True
    '            nd.Nodes(i).Checked = True
    '        Else
    '            ' nd.Nodes(i).Cells(1).Checked = False
    '            nd.Nodes(i).Checked = False
    '        End If
    '        '==================================================================


    '        ' เช็คว่ามี การกำหนด Nodes ย่อย หรือไม่  เช่น  Readonnly  อนุมัติ
    '        Dim J As Integer = 0
    '        Dim MenuSubName As String = ""

    '        If nd.Nodes(i).Cells(1).Text <> "" Then
    '            '   For J = 0 To nd.Nodes(i).Cells.Count - 1
    '            '  MenuSubName = nd.Nodes(i).Cells(1).Text

    '            ' Approve
    '            If ChkStatus_Approve(MenuId, lblPermissionName1.Text.Trim) = True Then
    '                nd.Nodes(i).Cells(2).Checked = True
    '            Else
    '                nd.Nodes(i).Cells(2).Checked = False
    '            End If


    '            ' ReadOnly
    '            If ChkStatus_ChkReadOnly(MenuId, lblPermissionName1.Text.Trim) = True Then
    '                nd.Nodes(i).Cells(3).Checked = True
    '            Else
    '                nd.Nodes(i).Cells(3).Checked = False
    '            End If

    '            '    Next
    '        End If
    '        '===================================================


    '        If nd.Nodes(i).Nodes.Count > 0 Then
    '            Call SubTree(nd.Nodes(i))
    '        End If

    '        '  fMainMenuHD.PG2.Value = i
    '        PG.Value = i
    '    Next

    'End Sub

    'Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Call GetData()
    'End Sub

    Function ChkData(ByVal MenuId As String, ByVal PatternName As String) As Boolean
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select * from GenMenu_Pattern " &
                 " Where APP='" & App_Project.Trim & "' And " &
                        " Menu_Id='" & MenuId.Trim & "' And  " &
                        " Menu_Use=1 And " &
                        " PatternName='" & PatternName.Trim & "'"

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

    Private Sub lblPermissionName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lstPermissionLogIn_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstPermissionLogIn.DoubleClick
        With lstPermissionLogIn
            Dim i As Integer
            For i = 0 To lstPermissionLogIn.SelectedItems.Count - 1
                lblPermissionName1.Text = lstPermissionLogIn.SelectedItems(i).SubItems(1).Text.Trim
                '  txtPermissionName.Text = lstPermissionLogIn.SelectedItems(i).SubItems(1).Text.Trim
            Next
        End With
        '  DataGridView1.Rows.Clear()
        ' mark ple 25/07/2019
        'fMainMenuHD.PG2.Value = 0
        '   Call lblPermissionName_LostFocus(Me, System.EventArgs.Empty)
        'fMainMenuHD.PG2.Visible = False
    End Sub

    Private Sub lstPermissionLogIn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstPermissionLogIn.SelectedIndexChanged
        With lstPermissionLogIn
            Dim i As Integer
            For i = 0 To lstPermissionLogIn.SelectedItems.Count - 1
                ' lblPermissionName1.Text = lstPermissionLogIn.SelectedItems(i).SubItems(1).Text.Trim
                txtPermissionName.Text = lstPermissionLogIn.SelectedItems(i).SubItems(1).Text.Trim
            Next
        End With
    End Sub

    Private Sub btnPlusAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        AdvTree2.CollapseAll()
    End Sub

    Private Sub BtnExpland_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        AdvTree2.ExpandAll()
    End Sub

    Private Sub GroupPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupPanel1.Click

    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        AdvTree2.CollapseAll()
    End Sub

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        AdvTree2.ExpandAll()
    End Sub

    Private Sub lblPermissionName1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPermissionName1.Click

    End Sub

    Private Sub lblPermissionName1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPermissionName1.LostFocus
        ''  fMainMenuHD.PG2.Visible = True
        'PG.Visible = True
        'If AdvTree2.Nodes.Count = 1 Then
        '    Call LoadMenu()
        'End If
        'Call GetData()
        ''  fMainMenuHD.PG2.Visible = False
        'PG.Value = False
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Dim frm As New frmSetUserLoginHD
        ' frm.ShowDialog()



    End Sub

    Private Sub chkmnuDailyUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles mnuDailyUpdate.CheckedChanged
        If mnuDailyUpdate.Checked = True Then
            mnuPermissionTimeAtt.Checked = True
            mnuPermissionTimeAtt_Excel.Checked = True
            mnuManageTime.Checked = True
            mnuOvertime.Checked = True
            mnuOvertime_Excel.Checked = True
            mnuLateTime.Checked = True
            mnuLateTime_Excel.Checked = True
            mnuabsenceTime.Checked = True
            mnuabsenceTime_Excel.Checked = True
            mnuInputLeaveData.Checked = True
        Else

            mnuPermissionTimeAtt.Checked = False
            mnuPermissionTimeAtt_Excel.Checked = False
            mnuManageTime.Checked = False
            mnuOvertime.Checked = False
            mnuOvertime_Excel.Checked = False
            mnuLateTime.Checked = False
            mnuLateTime_Excel.Checked = False
            mnuabsenceTime.Checked = False
            mnuabsenceTime_Excel.Checked = False
            mnuInputLeaveData.Checked = False
        End If
    End Sub


    Private Sub chkmnuPermission_CheckedChanged(sender As Object, e As EventArgs) Handles mnuPermission.CheckedChanged
        If mnuPermission.Checked = True Then
            mnuUserPass.Checked = True
            mnuPerPattern.Checked = True
            mnuPerUser.Checked = True
        Else
            mnuUserPass.Checked = False
            mnuPerPattern.Checked = False
            mnuPerUser.Checked = False
        End If
    End Sub

    Private Sub chkmnureportalltime_CheckedChanged(sender As Object, e As EventArgs)
        'If mnureportalltime.Checked = True Then
        '    mnurptAllemployeework2.Checked = True
        '    mnurptScheduleWorkAllEmp2.Checked = True
        'Else
        '    mnurptAllemployeework2.Checked = False
        '    mnurptScheduleWorkAllEmp2.Checked = False
        'End If
    End Sub

    Private Sub chkmnuConfiguration_CheckedChanged(sender As Object, e As EventArgs) Handles mnuMConfig.CheckedChanged
        If mnuMConfig.Checked = True Then
            mnuCompanyCenter.Checked = True
            mnumodelcalculations.Checked = True
            mnuEmp.Checked = True
            mnuDivision.Checked = True
            mnuDepartment.Checked = True
        Else
            mnuCompanyCenter.Checked = False
            mnumodelcalculations.Checked = False
            mnuEmp.Checked = False
            mnuDivision.Checked = False
            mnuDepartment.Checked = False
        End If
    End Sub

    Private Sub chkmnuMainConfiguration_CheckedChanged(sender As Object, e As EventArgs) Handles mnuConfiguration.CheckedChanged
        If mnuConfiguration.Checked = True Then
            mnuMConfig.Checked = True
            mnuCompanyCenter.Checked = True
            mnumodelcalculations.Checked = True
            mnuMWorkTime.Checked = True
            '    mnuworkinggroup.Checked = True
            mnuSpacialKa.Checked = True
            mnuDeterminedTime.Checked = True
            mnuDeterminedTimeEmp.Checked = True
            mnuDeterminedTimeEmpByOne.Checked = True
            mnuDeterminedTimeEmpByDate.Checked = True
            mnuMOpenCalculate.Checked = True
            mnuProcessOT.Checked = True
            mnucalculationLate.Checked = True
            mnucalculationAbs.Checked = True
            mnuMVacationHolYear.Checked = True
            mnuSetLeave.Checked = True
            mnuSetabsenceTimeByYear.Checked = True
            mnuSetholiday.Checked = True
            MenuWorkHolidaySpacial.Checked = True
            mnuMOtherCondition.Checked = True
            mnuOT.Checked = True
            '   mnuOTBasic.Checked = True
            mnusetOT.Checked = True
            mnusetdelaytime1.Checked = True
            mnusetdelayOT.Checked = True
            mnuSetCancelDelayOTByDay.Checked = True
            mnuOTbyDay.Checked = True
            mnulimitOT.Checked = True
        Else
            mnuMConfig.Checked = False
            mnuCompanyCenter.Checked = False
            mnumodelcalculations.Checked = False
            mnuMWorkTime.Checked = False
            '   mnuworkinggroup.Checked = False
            mnuSpacialKa.Checked = False
            mnuDeterminedTime.Checked = False
            mnuDeterminedTimeEmp.Checked = False
            mnuDeterminedTimeEmpByOne.Checked = False
            mnuDeterminedTimeEmpByDate.Checked = False
            mnuMOpenCalculate.Checked = False
            mnuProcessOT.Checked = False
            mnucalculationLate.Checked = False
            mnucalculationAbs.Checked = False
            mnuMVacationHolYear.Checked = False
            mnuSetLeave.Checked = False
            mnuSetabsenceTimeByYear.Checked = False
            mnuSetholiday.Checked = False
            MenuWorkHolidaySpacial.Checked = False
            mnuMOtherCondition.Checked = False
            mnuOT.Checked = False
            '    mnuOTBasic.Checked = False
            mnusetOT.Checked = False
            mnusetdelaytime1.Checked = False
            mnusetdelayOT.Checked = False
            mnuSetCancelDelayOTByDay.Checked = False
            mnuOTbyDay.Checked = False
            mnulimitOT.Checked = False
        End If
    End Sub

    Private Sub chkmnuDateworktime_CheckedChanged(sender As Object, e As EventArgs) Handles mnuMWorkTime.CheckedChanged
        If mnuMWorkTime.Checked = True Then
            '    mnuworkinggroup.Checked = True
            mnuSpacialKa.Checked = True
            mnuDeterminedTime.Checked = True
            mnuDeterminedTimeEmp.Checked = True
            mnuDeterminedTimeEmpByOne.Checked = True
            mnuDeterminedTimeEmpByDate.Checked = True
        Else
            '    mnuworkinggroup.Checked = False
            mnuSpacialKa.Checked = False
            mnuDeterminedTime.Checked = False
            mnuDeterminedTimeEmp.Checked = False
            mnuDeterminedTimeEmpByOne.Checked = False
            mnuDeterminedTimeEmpByDate.Checked = False
        End If
    End Sub

    Private Sub chkmnuDeterminedTimeEmp_CheckedChanged(sender As Object, e As EventArgs) Handles mnuDeterminedTimeEmp.CheckedChanged
        If mnuDeterminedTimeEmp.Checked = True Then
            mnuDeterminedTimeEmpByOne.Checked = True
            mnuDeterminedTimeEmpByDate.Checked = True
        Else
            mnuDeterminedTimeEmpByOne.Checked = False
            mnuDeterminedTimeEmpByDate.Checked = False
        End If
    End Sub

    Private Sub chkmnuconfigCal_CheckedChanged(sender As Object, e As EventArgs) Handles mnuMOpenCalculate.CheckedChanged
        If mnuMOpenCalculate.Checked = True Then
            mnuProcessOT.Checked = True
            mnucalculationLate.Checked = True
            mnucalculationAbs.Checked = True
        Else
            mnuProcessOT.Checked = False
            mnucalculationLate.Checked = False
            mnucalculationAbs.Checked = False
        End If
    End Sub

    Private Sub chkmnuHoldayYear_CheckedChanged(sender As Object, e As EventArgs) Handles mnuMVacationHolYear.CheckedChanged
        If mnuMVacationHolYear.Checked = True Then
            mnuSetLeave.Checked = True
            mnuSetabsenceTimeByYear.Checked = True
            mnuSetholiday.Checked = True
            MenuWorkHolidaySpacial.Checked = True
        Else
            mnuSetLeave.Checked = False
            mnuSetabsenceTimeByYear.Checked = False
            mnuSetholiday.Checked = False
            MenuWorkHolidaySpacial.Checked = False
        End If
    End Sub

    Private Sub chkmnuConditions_CheckedChanged(sender As Object, e As EventArgs) Handles mnuMOtherCondition.CheckedChanged
        If mnuMOtherCondition.Checked = True Then
            mnuOT.Checked = True
            '   mnuOTBasic.Checked = True
            mnusetOT.Checked = True
            mnusetdelaytime1.Checked = True
            mnusetdelayOT.Checked = True
            mnuSetCancelDelayOTByDay.Checked = True
            mnuOTbyDay.Checked = True
            mnulimitOT.Checked = True
        Else
            mnuOT.Checked = False
            '    mnuOTBasic.Checked = False
            mnusetOT.Checked = False
            mnusetdelaytime1.Checked = False
            mnusetdelayOT.Checked = False
            mnuSetCancelDelayOTByDay.Checked = False
            mnuOTbyDay.Checked = False
            mnulimitOT.Checked = False
        End If
    End Sub

    Private Sub mnuOT_CheckedChanged(sender As Object, e As EventArgs) Handles mnuOT.CheckedChanged
        If mnuOT.Checked = True Then
            '  mnuOTBasic.Checked = True
            mnusetOT.Checked = True
            mnusetdelaytime1.Checked = True
            mnusetdelayOT.Checked = True
            mnuSetCancelDelayOTByDay.Checked = True
            mnuOTbyDay.Checked = True
        Else
            '   mnuOTBasic.Checked = False
            mnusetOT.Checked = False
            mnusetdelaytime1.Checked = False
            mnusetdelayOT.Checked = False
            mnuSetCancelDelayOTByDay.Checked = False
            mnuOTbyDay.Checked = False
        End If
    End Sub

    Private Sub chkmnusetOT_CheckedChanged(sender As Object, e As EventArgs) Handles mnusetOT.CheckedChanged
        If mnusetOT.Checked = True Then
            mnusetdelaytime1.Checked = True
            mnusetdelayOT.Checked = True
            mnuSetCancelDelayOTByDay.Checked = True
        Else
            mnusetdelaytime1.Checked = False
            mnusetdelayOT.Checked = False
            mnuSetCancelDelayOTByDay.Checked = False
        End If
    End Sub

    Private Sub chkmnumainreport_CheckedChanged(sender As Object, e As EventArgs) Handles mnuReport.CheckedChanged
        If mnuReport.Checked = True Then

            mnurptTimeWork.Checked = True
            mnurptEmpWorkDetail1_M.Checked = True
            mnurptAllemployeework2.Checked = True
            mnurptScheduleWorkAllEmp2.Checked = True
            mnurptemployeeByDate.Checked = True
            munOvertimeLeage.Checked = True

        Else
            mnurptTimeWork.Checked = False
            mnurptEmpWorkDetail1_M.Checked = False
            mnurptAllemployeework2.Checked = False
            mnurptScheduleWorkAllEmp2.Checked = False
            mnurptemployeeByDate.Checked = False
            munOvertimeLeage.Checked = False

        End If
    End Sub

    Private Sub Enacmd(Add As Boolean, Edit As Boolean, del As Boolean)
        btnAdd_P.Enabled = Add
        btnEdit_P.Enabled = Edit
        btnDel_P.Enabled = del
    End Sub

    Private Sub frmGenGroupMenuMasterHD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadDataPattern()
        Call Enacmd(True, False, False)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub GcpermissionLogin_Click(sender As Object, e As EventArgs) Handles GcpermissionLogin.Click

    End Sub

    Private Sub GvpermissionLogin_DoubleClick(sender As Object, e As EventArgs) Handles GvpermissionLogin.DoubleClick
        Try
            Dim gv As GridView = CType(sender, GridView)

            '   If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "Code")) = True Then Exit Sub
            txtGrpId.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "GrpId")
            lblPermissionName.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "GrpName")
            Call LoadCheckPermision() ' โหลดข้อมุลที่กำหนดไป
            tabMenu.SelectedTabPageIndex = 0

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDel_P_Click_1(sender As Object, e As EventArgs) Handles btnDel_P.Click

    End Sub

    Private Sub GvpermissionLogin_Click(sender As Object, e As EventArgs) Handles GvpermissionLogin.Click
        Try
            Dim gv As GridView = CType(sender, GridView)

            '   If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "Code")) = True Then Exit Sub
            txtGrpId.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "GrpId")
            txtPermissionName.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "GrpName")
            txtPermisionName_Old.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "GrpName")
            Call Enacmd(False, True, True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkmnumainreport_CheckedChanged_1(sender As Object, e As EventArgs)

        'If mnumainreport.Checked = True Then
        '    mnurptTimeWork.Checked = True
        '    mnurptEmpWorkDetail1_M.Checked = True
        '    mnureportalltime.Checked = True
        '    mnurptAllemployeework2.Checked = True
        '    mnurptScheduleWorkAllEmp2.Checked = True
        '    mnurptemployeeByDate.Checked = True
        '    munOvertimeLeage.Checked = True

        'Else
        '    mnumainreport.Checked = False
        '    mnurptTimeWork.Checked = False
        '    mnurptEmpWorkDetail1_M.Checked = False
        '    mnureportalltime.Checked = False
        '    mnurptAllemployeework2.Checked = False
        '    mnurptScheduleWorkAllEmp2.Checked = False
        '    mnurptemployeeByDate.Checked = False
        '    munOvertimeLeage.Checked = False

        'End If
    End Sub

    Function LoadCheckboxPermision(ByVal MenuId As String, ByVal PatternName As String) As Boolean
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""



        Strsql = "Select Menu_Use" &
                 " from GenMenu_Pattern  " &
                 " where patternname='" & PatternName.Trim & "' " &
                        " And Menu_Id='" & MenuId.Trim & "'  " &
                        " And APP='" & App_Project.Trim & "'" &
                        " And Menu_Use=1 "

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

    Function GetCheckMenuBoolean(ByVal Menu_Id As String, ByVal Dt As DataTable) As Boolean
        '  Dim DW As DataView = Dt.DefaultView
        Dim DW As New DataView(Dt)
        DW.RowFilter = "Menu_Id='" & Menu_Id.Trim & "'"
        If DW.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Function GetCheckExportExcelBoolean(ByVal Menu_Id As String, ByVal Dt As DataTable) As Boolean
        '  Dim DW As DataView = Dt.DefaultView
        Dim DW As New DataView(Dt)
        DW.RowFilter = "Menu_Id='" & Menu_Id & "' And Export_excel=1"
        If DW.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Function GetCheckApproveBoolean(ByVal Menu_Id As String, ByVal Dt As DataTable) As Boolean
        '  Dim DW As DataView = Dt.DefaultView
        Dim DW As New DataView(Dt)
        DW.RowFilter = "Menu_Id='" & Menu_Id & "' And Menu_Approve=1"
        If DW.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Function getDTPermision(GrpId As Integer) As DataTable
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""


        Strsql = "Select * " &
                 " from GenMenu_Pattern  " &
                 " where Grpid=" & GrpId & " " &
                        " And APP='" & App_Project.Trim & "'" &
                        " And Menu_Use=1 "

        Da = New SqlDataAdapter(Strsql, Conn)
        Da.Fill(Ds, "DATA")

        Return Ds.Tables("DATA")
    End Function



    Private Sub LoadCheckPermision()
        Dim dt As DataTable = getDTPermision(txtGrpId.EditValue)

        '  ปรับปรุงยอด
        mnuDailyUpdate.Checked = GetCheckMenuBoolean(mnuDailyUpdate.Tag, dt)

        mnuPermissionTimeAtt.Checked = GetCheckMenuBoolean(mnuPermissionTimeAtt.Tag, dt)
        mnuPermissionTimeAtt_Excel.Checked = GetCheckExportExcelBoolean(mnuPermissionTimeAtt.Tag, dt) ' Export excel
        mnuManageTime.Checked = GetCheckMenuBoolean(mnuManageTime.Tag, dt)
        mnuOvertime.Checked = GetCheckMenuBoolean(mnuOvertime.Tag, dt)
        mnuOvertime_Excel.Checked = GetCheckExportExcelBoolean(mnuOvertime.Tag, dt) ' Export Excel
        mnuLateTime.Checked = GetCheckMenuBoolean(mnuLateTime.Tag, dt)
        mnuLateTime_Excel.Checked = GetCheckExportExcelBoolean(mnuLateTime.Tag, dt) ' Export Excel
        mnuabsenceTime.Checked = GetCheckMenuBoolean(mnuabsenceTime.Tag, dt)
        mnuabsenceTime_Excel.Checked = GetCheckExportExcelBoolean(mnuabsenceTime.Tag, dt)  ' Export Excel
        mnuInputLeaveData.Checked = GetCheckMenuBoolean(mnuInputLeaveData.Tag, dt)
        mnuInputLeaveData_Approve.Checked = GetCheckApproveBoolean(mnuInputLeaveData.Tag, dt)



        ' ตั้งค่า
        mnuConfiguration.Checked = GetCheckMenuBoolean(mnuConfiguration.Tag, dt)  ' ตั้งค่าระบบ
        mnuMConfig.Checked = GetCheckMenuBoolean(mnuMConfig.Tag, dt) ' ตั้งค่าระบบ
        mnuCompanyCenter.Checked = GetCheckMenuBoolean(mnuCompanyCenter.Tag, dt) ' ข้อมูลบริษัท
        mnumodelcalculations.Checked = GetCheckMenuBoolean(mnumodelcalculations.Tag, dt) ' กำหนดรูปแบบการคำนวณ
        mnuEmp.Checked = GetCheckMenuBoolean(mnuEmp.Tag, dt)   ' กำหนดข้อมุลพนักงาน
        mnuDivision.Checked = GetCheckMenuBoolean(mnuDivision.Tag, dt)     ' กำหนดฝ่าย
        mnuDepartment.Checked = GetCheckMenuBoolean(mnuDepartment.Tag, dt) ' กำหนดแผนก
        mnuMWorkTime.Checked = GetCheckMenuBoolean(mnuMWorkTime.Tag, dt) ' เวลาทำงาน
        '   mnuworkinggroup.Checked = GetCheckMenuBoolean(mnuworkinggroup.Tag, dt) ' กำหนดกลุ่มเวลาทำงาน - ปกติ/ตามวัน
        mnuSpacialKa.Checked = GetCheckMenuBoolean(mnuSpacialKa.Tag, dt) ' กำหนดพนักงานกะพิเศษ(กะ 8 ชม. นับเวลาเข้าเป็นหลัก)
        mnuDeterminedTime.Checked = GetCheckMenuBoolean(mnuDeterminedTime.Tag, dt) ' กำหนดเวลาทำงาน
        mnuDeterminedTimeEmp.Checked = GetCheckMenuBoolean(mnuDeterminedTimeEmp.Tag, dt) ' กำหนดเวลาให้กับพนักงาน
        mnuDeterminedTimeEmpByOne.Checked = GetCheckMenuBoolean(mnuDeterminedTimeEmpByOne.Tag, dt) ' กำหนดเวลาทำงานพืนฐานพนักงานแต่ละคน
        mnuDeterminedTimeEmpByDate.Checked = GetCheckMenuBoolean(mnuDeterminedTimeEmpByDate.Tag, dt) ' กำหนดเวลาตามวันที่
        mnuMOpenCalculate.Checked = GetCheckMenuBoolean(mnuMOpenCalculate.Tag, dt) ' กำหนดพนักงานคำนวณ OT/สาย /ขาด
        mnuProcessOT.Checked = GetCheckMenuBoolean(mnuProcessOT.Tag, dt) ' กำหนดพนักงานคำนวณ OT/ กำหนดรูปแบบการคำนวณ OT
        mnucalculationLate.Checked = GetCheckMenuBoolean(mnucalculationLate.Tag, dt) ' กำหนดพนักงานคำนวณ สาย
        mnucalculationAbs.Checked = GetCheckMenuBoolean(mnucalculationAbs.Tag, dt) ' กำหนดพนักงานคำนวณ ขาด
        mnuMVacationHolYear.Checked = GetCheckMenuBoolean(mnuMVacationHolYear.Tag, dt) ' ข้อมูลลา / วันหยุดประจำปี
        mnuSetLeave.Checked = GetCheckMenuBoolean(mnuSetLeave.Tag, dt) ' ตั้งค่าระบบ
        mnuSetabsenceTimeByYear.Checked = GetCheckMenuBoolean(mnuSetabsenceTimeByYear.Tag, dt) ' ตั้งค่าระบบ
        mnuSetholiday.Checked = GetCheckMenuBoolean(mnuSetholiday.Tag, dt) ' กำหนดข้อมูลการลา
        MenuWorkHolidaySpacial.Checked = GetCheckMenuBoolean(MenuWorkHolidaySpacial.Tag, dt) ' กำหนดสิทธิการลาในแต่ละปี
        mnuMOtherCondition.Checked = GetCheckMenuBoolean(mnuMOtherCondition.Tag, dt) ' กำหนดวันหยุดประจำปี
        mnuOT.Checked = GetCheckMenuBoolean(mnuOT.Tag, dt) ' กำหนดวันทำงานพิเศษ - วันหยุดพิเศษ
        '     mnuOTBasic.Checked = GetCheckMenuBoolean(mnuOTBasic.Tag, dt) ' กำหนดเงือนไข OT พื้นฐาน
        mnusetOT.Checked = GetCheckMenuBoolean(mnusetOT.Tag, dt) ' กำหนดเวลาหน่วงการทำ OT
        mnusetdelaytime1.Checked = GetCheckMenuBoolean(mnusetdelaytime1.Tag, dt) ' กำหนดพนักงาน ใช้เวลาหน่วง
        mnusetdelayOT.Checked = GetCheckMenuBoolean(mnusetdelayOT.Tag, dt) ' กำหนดเวลาหน่วงการทำ OT
        mnuSetCancelDelayOTByDay.Checked = GetCheckMenuBoolean(mnuSetCancelDelayOTByDay.Tag, dt) ' กำหนดพนักงาน ยกเลิกการหน่วง รายวัน
        mnuOTbyDay.Checked = GetCheckMenuBoolean(mnuOTbyDay.Tag, dt) ' คีร์ข้อมูล OT หักพิเศษรายวัน ตามรายบุคคล
        mnulimitOT.Checked = GetCheckMenuBoolean(mnulimitOT.Tag, dt) ' กำหนดการจำกัดชัวโมง OT


        ' รายงาน
        mnuReport.Checked = GetCheckMenuBoolean(mnuReport.Tag, dt)
        mnurptTimeWork.Checked = GetCheckMenuBoolean(mnurptTimeWork.Tag, dt)
        mnurptEmpWorkDetail1_M.Checked = GetCheckMenuBoolean(mnurptEmpWorkDetail1_M.Tag, dt)
        mnurptAllemployeework2.Checked = GetCheckMenuBoolean(mnurptAllemployeework2.Tag, dt)
        mnurptScheduleWorkAllEmp2.Checked = GetCheckMenuBoolean(mnurptScheduleWorkAllEmp2.Tag, dt)
        mnurptemployeeByDate.Checked = GetCheckMenuBoolean(mnurptemployeeByDate.Tag, dt)
        munOvertimeLeage.Checked = GetCheckMenuBoolean(munOvertimeLeage.Tag, dt)


        ' กำหนดสิทธิ์
        mnuPermission.Checked = GetCheckMenuBoolean(mnuPermission.Tag, dt)
        mnuUserPass.Checked = GetCheckMenuBoolean(mnuUserPass.Tag, dt)
        mnuPerPattern.Checked = GetCheckMenuBoolean(mnuPerPattern.Tag, dt)
        mnuPerUser.Checked = GetCheckMenuBoolean(mnuPerUser.Tag, dt)


    End Sub

    Private Sub XtraScrollableControl2_Click(sender As Object, e As EventArgs) Handles XtraScrollableControl2.Click

    End Sub

    Private Sub XtraScrollableControl2_Resize(sender As Object, e As EventArgs) Handles XtraScrollableControl2.Resize
        Dim height As Integer = 0

        'For Each control As Control In Me.flowLayoutPanel.Controls

        '    If control.Location.Y + control.Size.Height > height Then
        '        height = control.Location.Y + control.Size.Height
        '    End If
        'Next

        'height += Me.flowLayoutPanel.Padding.Bottom
        'Dim width As Integer = Me.xtraScrollableControl.Width - SystemInformation.VerticalScrollBarWidth
        'Me.flowLayoutPanel.Size = New Size(width, height)
    End Sub

    Private Sub btnReSavePattern_Click(sender As Object, e As EventArgs) Handles btnReSavePattern.Click
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim Tn As SqlTransaction
        Dim db As New db
        '  Dim Strtype As String = ""
        '  Dim data As New ArrayList
        Dim dcmd As New SqlCommand

        If txtPermissionName.Text = "" Then
            ' MsgBox("กรุณากำหนดหัวข้อใหม่", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly)
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "InPutPatternName", MessageBoxIcon.Information)
            Exit Sub
        End If

        'If ChkUserLogin(txtPermissionName.Text.Trim) = True Then ' เช็คว่ามีชื่อ UserLogIn นี้มาแล้วหรือไม่
        '    ' MsgBox("ชือนี้ได้บันทึกไปแล้วกรุณาเปลี่ยนชื่อ", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "แจ้งให้ทราบ")
        '    MsgManager.ShowDialog(Me, "Messages", Me.Text, "NamePatternSame", MessageBoxIcon.Information)
        '    Exit Sub
        'End If


        'Call OpenConnect(True)
        Tn = Conn.BeginTransaction
        dcmd.Transaction = Tn
        Try


            Strsql = "Delete From GenMenu_Pattern " &
                     " Where  PatternName='" & txtPermissionName.Text.Trim & "' And " &
                           " APP='" & App_Project.Trim & "' "
            dcmd.Connection = Conn
            dcmd.CommandText = Strsql
            dcmd.ExecuteNonQuery()


            Strsql = "Insert Into Genmenu_Pattern(Menu_Id,PatternName,Menu_Name, " &
                      " Menu_NameEng,Menu_LinkFrom,APP) " &
                   " Select Menu_Id,'" & txtPermissionName.Text.Trim & "',Menu_Name,Menu_NameEng,Menu_LinkFrom,APP " &
                   " From GenCreateMenu_Master "


            ' OpenConnect(True)
            dcmd.Connection = Conn
            dcmd.CommandText = Strsql
            dcmd.ExecuteNonQuery()

            Tn.Commit()
            ' Call OpenConnect(False)
            ' MsgBox("บันทึกเรียบร้อย", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "แจ้งให้ทราบ")
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Save_Complete", MessageBoxIcon.Information)

        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message)
        End Try
        '    fMainMenu.PG2.Visible = True
        '  Call LoadMenu()
        Call LoadDataPattern()
        '  fMainMenu.PG2.Visible = False
    End Sub

    Private Sub txtPermissionName_EditValueChanged(sender As Object, e As EventArgs) Handles txtPermissionName.EditValueChanged, txtGrpId.EditValueChanged, txtPermisionName_Old.EditValueChanged

    End Sub

    Private Sub txtPermissionName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPermissionName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If btnAdd_P.Enabled = True Then
                btnAdd_P.Focus()
            Else
                btnEdit_P.Focus()
            End If
        End If
    End Sub

    Private Sub txtPermissionName_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtPermissionName.ButtonClick
        Call Enacmd(True, False, False)
        txtPermissionName.Text = ""
        lblPermissionName.Text = ""
        txtPermissionName.Focus()
    End Sub

    Private Sub GvpermissionLogin_CustomSummaryCalculate(sender As Object, e As CustomSummaryEventArgs) Handles GvpermissionLogin.CustomSummaryCalculate

    End Sub

    Private Sub btnEdit_P_Click_1(sender As Object, e As EventArgs) Handles btnEdit_P.Click
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim Tn As SqlTransaction
        Dim db As New db
        '  Dim Strtype As String = ""
        '  Dim data As New ArrayList
        Dim dcmd As New SqlCommand

        If txtPermissionName.Text = "" Then
            ' MsgBox("กรุณากำหนดหัวข้อใหม่", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly)
            '  MsgManager.ShowDialog(Me, "Messages", Me.Text, "InPutPatternName", MessageBoxIcon.Information)
            '  MsgBox("กรุณาป้อนชื่อกลุ่มสิทธิ์", MsgBoxStyle.Information, "ชื่อกลุ่มสิทธิ์")
            MsgBox(My.Resources.res_warning_message_spacial.permission_please_input_groupname, MsgBoxStyle.Information, Me.Text)
            txtPermissionName.Focus()
            Exit Sub
        End If

        If txtPermissionName.Text.Trim <> txtPermisionName_Old.Text.Trim Then
            If ChkGroupSame(txtPermissionName.Text.Trim) = True Then ' เช็คว่ามีชื่อ UserLogIn นี้มาแล้วหรือไม่
                '   MsgBox("ชื่อกลุ่มมีอยู่แล้ว", MsgBoxStyle.Information, "ชื่อกลุ่มซ้ำ")
                MsgBox(My.Resources.res_warning_message_spacial.permission_groupsame, MsgBoxStyle.Information, Me.Text)
                txtPermissionName.SelectAll()
                txtPermissionName.Focus()
                Exit Sub
            End If
        End If




        'Call OpenConnect(True)
        Tn = Conn.BeginTransaction
        dcmd.Transaction = Tn
        Try

            Strsql = "update genmenu_configgroup set GrpName ='" & txtPermissionName.Text.Trim & "' where GrpId=" & txtGrpId.EditValue & ""
            dcmd.Connection = Conn
            dcmd.CommandText = Strsql
            dcmd.ExecuteNonQuery()

            Tn.Commit()
            '    MsgBox("แก้ไขชื่อกลุ่มสิทธิ์เรียบร้อย", MsgBoxStyle.Information, "แก้ไข")
            MsgBox(My.Resources.res_warning_message.edit_complete, MsgBoxStyle.Information, Me.Text)

        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message)
        End Try
        Call LoadDataPattern()
        Call Enacmd(True, False, False)
        txtPermissionName.Text = ""
        lblPermissionName.Text = ""
        txtPermissionName.Focus()
    End Sub
End Class