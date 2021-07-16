Imports System.Windows.Forms
Imports TimeAttendance.utils
Imports System.IO
Imports System.Globalization

Imports System.Data
Imports System.Data.SqlClient


Public Class frmMainMenuHD
    Protected dbMgr As New DBManager
    Protected dbConnStr As String = dbMgr.getConnString

    Dim gData As New GetData


    Private Sub frmMainMenuHD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "" & LoadCompanyName()
        ' V.2.12 LastUpdate: 04-07-2019  09:57

        Call CheckGenMenu_Master()
        '  Call checkGenMenuMasterOnPage()

        Call VisibleMenu()

        T_Code.Text = UserId
        T_Name.Text = GetEmpName(UserId.Trim)

        '
    End Sub

    Private Sub VisibleMenu()
        mnuLinkCodePayroll.Visible = False
        mnuImportMasterProfile.Visible = False
        mnuGEmp.Visible = False
        mnImportData.Visible = False
        ToolStripMenuItem8.Visible = False

        mnurptEmployeework.Visible = False

        mnuforProgramer.Visible = False

        mnuRptSumary.Visible = False
        mnuRptSumaryByMonth.Visible = False
        mnuRptSumaryByYear.Visible = False
        mnusetovertimekap.Visible = False
        mnuSumaryWagePerDay.Visible = False
        mnurptOT.Visible = False

        mnurptSumaryMonth.Visible = False
        mnuprtAllowance.Visible = False
        mnuLineUnderAwReport.Visible = False

        mnuAllowance.Visible = False

        ' ซ่อนเมนู ใหม่  24-09-2014
        mnurptEmpWorkDetail2.Visible = False
        mnuEmpNotWork.Visible = False
        mnuSumaryemployee.Visible = False
        mnurptMaximumOThoursdaysweeksyear.Visible = False
        mnuSumaryHolidayInYears.Visible = False

        ' ซ่อนเมนุ ใหม่ 16/12/2014 by ple
        mnucalculationBreak.Visible = False
        mnusetAllowance.Visible = False
        mnuMove_KaTime.Visible = False
        mnuOTetc.Visible = False
        mnusetconditionsLate.Visible = False
        mnurptTimeWorkLateByOne.Visible = False
        mnurptTimeSheet.Visible = False
        mnurptrptSumaryMonthLateByBath.Visible = False

        mnuLineUnderAwReport.Visible = False
        mnurptNormalworkinghoursOTByWeek.Visible = False
        ToolStripMenuItem22.Visible = False
        mnurptAllemployeework.Visible = False
        mnuSummaryScheduleWorkAllEmp.Visible = False
        mnurptScheduleWorkAllEmp.Visible = False
    End Sub

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripButton.Click
        '' Create a new instance of the child form.
        'Dim ChildForm As New System.Windows.Forms.Form
        '' Make it a child of this MDI form before showing it.
        'ChildForm.MdiParent = Me

        'm_ChildFormNumber += 1
        'ChildForm.Text = "Window " & m_ChildFormNumber

        'ChildForm.Show()

        '    Dim frm As New frmCompany_Sub
        '    frm.Show()
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Public Shared Function GetEmpName(ByVal IDUser As String) As String   ' หาชื่อ สกุล

        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim strsql As String = ""

        strsql = "Select * " & _
                " from Emp " & _
                " where  Code='" & IDUser.Trim & "'   "

        Try
            'OpenConnect(True)
            DA = New SqlDataAdapter(strsql, Conn)
            DA.Fill(DS, "DATA")
            'OpenConnect(False)

            With DS.Tables("DATA")
                If .Rows.Count = 0 Then
                    Return ""
                Else
                    Return .Rows(0).Item("FName") & "  -  " & .Rows(0).Item("LName")
                End If
            End With
        Catch ex As Exception
            '   MsgBox(ex.Message)
            Return ""

        End Try

    End Function



    'Private Sub checkGenMenuMasterOnPage()
    '    ' Dim MenuTaG As String = ""
    '    '  Dim BackColor_B As Color

    '    Try
    '        '  For Each c In Me.Bar1.Controls
    '        ' MsgBox(Bar1.Controls.Count)
    '        'If TypeOf c Is DevComponents.DotNetBar.Bar Then
    '        '    MsgBox(btnProduct.Text)
    '        '    'MsgBox("aa")
    '        'End If
    '        'If TypeOf c Is Global.DevComponents.DotNetBar.ButtonItem Then
    '        '    Dim btn As Global.DevComponents.DotNetBar.ButtonItem = CType(c, Global.DevComponents.DotNetBar.ButtonItem)
    '        '    MenuTaG = btn.Tag
    '        '  BackColor_B = btn.col


    '        If U_UserName = "sa" Then
    '            '  btn.Enabled = True
    '            btnProduct.Enabled = True
    '            BtnEmp.Enabled = True
    '            BtnTicKet.Enabled = True
    '            ButtonItem3.Enabled = True
    '            btnPayment.Enabled = True
    '        Else

    '            ' ปุ่ม Member =========================================
    '            If GetChkSt_MenuOnpage(btnProduct.Tag, UserId.Trim) = True Then
    '                btnProduct.Enabled = True
    '                'btn.BackColor = BackColor_B
    '            Else
    '                btnProduct.Enabled = False
    '                '  btn.BackColor = Color.DimGray
    '            End If


    '            ' ปุ่ม Emp =========================================
    '            If GetChkSt_MenuOnpage(BtnEmp.Tag, UserId.Trim) = True Then
    '                BtnEmp.Enabled = True
    '                'btn.BackColor = BackColor_B
    '            Else
    '                BtnEmp.Enabled = False
    '                '  btn.BackColor = Color.DimGray
    '            End If


    '            ' ปุ่ม ออกตั๋ว =========================================
    '            If GetChkSt_MenuOnpage(BtnTicKet.Tag, UserId.Trim) = True Then
    '                BtnTicKet.Enabled = True
    '                'btn.BackColor = BackColor_B
    '            Else
    '                BtnTicKet.Enabled = False
    '                '  btn.BackColor = Color.DimGray
    '            End If


    '            ' ปุ่ม ลงทะเบียนคอร์สใหม่  UpLevel =========================================
    '            If GetChkSt_MenuOnpage(ButtonItem3.Tag, UserId.Trim) = True Then
    '                ButtonItem3.Enabled = True
    '                'btn.BackColor = BackColor_B
    '            Else
    '                ButtonItem3.Enabled = False
    '                '  btn.BackColor = Color.DimGray
    '            End If


    '            ' ปุ่ม ขายหน้าร้าน   =========================================
    '            If GetChkSt_MenuOnpage(btnPayment.Tag, UserId.Trim) = True Then
    '                btnPayment.Enabled = True
    '                'btn.BackColor = BackColor_B
    '            Else
    '                btnPayment.Enabled = False
    '                '  btn.BackColor = Color.DimGray
    '            End If
    '        End If

    '        '  End If
    '        '   Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub

    Function GetChkSt_MenuOnpage(ByVal MenuTag As String, ByVal EmpId As String) As Boolean
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = " Select MenuLink " & _
                 " From GenMenu_UserOnPage " & _
                 " Where  APP='" & App_Project.Trim & "' And " & _
                        " MenuLink='" & MenuTag.Trim & "' And " & _
                        " St_Menu=1 And EmpId ='" & EmpId.Trim & "'"

        Try
            Da = New SqlDataAdapter(Strsql, Conn)
            Da.Fill(Ds, "DATA")

            With Ds.Tables("DATA")
                If .Rows.Count = 0 Then
                    Return False
                Else
                    Return True
                End If
            End With
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function LoadCompanyName() As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db
        Strsql = "Select Isnull(companyName,'') as CompanyName From Company"

        '
        db.ExecuteCommand(Conn, dcmd, Strsql)
        Da.SelectCommand = dcmd
        Da.Fill(Ds, "data")
        '
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("CompanyName")
            End If

        End With
    End Function

#Region "GenMenuโหลด หรือเช็คเมนู สิทธิ์ "  ' โหลด หรือเช็คเมนู สิทธิ์
    Private Sub CheckGenMenu_Master()
        For Each HeadMenu As ToolStripMenuItem In MenuStrip.Items
            Check_SetStatusChildMenu(HeadMenu)
        Next

    End Sub

    Private Sub Check_SetStatusChildMenu(ByVal HeadMenu As ToolStripMenuItem)

        Dim mnuChild As ToolStripMenuItem
        Dim NameMenu As String = ""
        Dim ChkMenu As Boolean = True
        Dim ChkMenuSub As Boolean = True
        Dim H_Menu As String = ""
        Dim Sub_Menu As String = ""
        Dim HeadMenu_H As String = ""
        Dim ChkMenu_InMaster As String = ""
        Dim MenuComplete As Boolean = False
        Dim Head_MN As String = ""
        ' Head_MN = HeadMenu.Text

        HeadMenu_H = GetMenu_Link(HeadMenu.Name) ' ไว้ใช้เช็คเมนูหลัก ระหว่าง เมนูฟอร์ม กันเมนูใน DB

        Dim DtPerSA As DataTable = getDTSaPermision() ' เมนูปกติด้านบน
        Dim DtPerUser As DataTable = getDTPermision(UserId.Trim) ' เมนูปกติด้านบน


        'Dim DtPerSAOnPage As DataTable = getDTSaPermisionOnPage() ' สำหรับเมนูรอง ที่ไม่ใช่เมนูหลัก ถ้าไม่ใช้ก็เอาออก
        'Dim DtPerUserOnPage As DataTable = getDTPermisionOnPage(UserId.Trim)  ' สำหรับเมนูรอง ที่ไม่ใช่เมนูหลัก ถ้าไม่ใช้ก็เอาออก

        Try
            For i As Integer = 0 To HeadMenu.DropDownItems.Count - 1
                If TypeOf HeadMenu.DropDownItems(i) Is ToolStripMenuItem Then
                    mnuChild = DirectCast(HeadMenu.DropDownItems(i), ToolStripMenuItem)
                    NameMenu = HeadMenu.DropDownItems(i).Name
                    Sub_Menu = GetMenu_Link(HeadMenu.DropDownItems(i).Name) ' ไว้ใช้เช็คเมนูย่อย ระหว่าง เมนูฟอร์ม กันเมนูใน DB

                    ' เช็คหัวบิลเมนู
                    '-----------------------------------------

                    '  ซ่อนไว้ก่อน()
                    If U_UserName <> "sa" Then ' ถ้ามีการกำหนดเมน User ไว้ใน DB
                        '    ''เช็คเมนู กับ DB ของเมนูหลัก
                        If MenuComplete = False Then ' ถ้าทำไปแล้วไม่ต้องทำอีก
                            HeadMenu.Visible = GetVisibleMenu(HeadMenu_H.Trim, DtPerUser)
                            MenuComplete = True
                        End If
                    Else
                        '    'สำหรับ SAเช็คเมนู กับ DB เพื่อซ่อน ===================================
                        If MenuComplete = False Then
                            '  HeadMenu.Visible = GetVisibleMenu(HeadMenu_H.Trim, DtPerSA)
                            HeadMenu.Visible = True  ' ใช้ชั่วคราว ของจริงอยู่อันบน
                            MenuComplete = True
                        End If


                        '    '============================================================
                    End If

                    'If HeadMenu.Name = "GenMenuProgrammer" Then
                    '    HeadMenu.Visible = False
                    'End If
                    '-------------------------------------------




                    ' ตัวย่อยเมนู ======================================================================
                    '-------------------------------------------------------

                    If mnuChild.HasDropDownItems Then
                        ' mnuChild.Enabled = False  '/// I'm Show Recursive Function wed wed wed
                        Check_SetStatusChildMenu(HeadMenu.DropDownItems(i))
                    Else

                        ' ซ่อนไว้ก่อน
                        If U_UserName <> "sa" Then ' ถ้ามีการกำหนดเมน User ไว้ใน DB
                            mnuChild.Visible = GetVisibleMenu(Sub_Menu.Trim, DtPerUser)
                        Else
                            ' mnuChild.Visible = GetVisibleMenu(Sub_Menu.Trim, DtPerSA)
                            mnuChild.Visible = True ' ใช้ชั่วคราว ของจริงอยู่ด้านบน
                        End If

                        If mnuChild.Name = "GenMenuProgrammer" Then
                            mnuChild.Visible = False
                        End If


                    End If

                    '----------------------------------------------------------
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "แจ้งให้ทราบ")
        End Try
    End Sub

    Function GetVisibleMenu(ByVal MenuLink As String, ByVal Dt As DataTable) As Boolean
        '  Dim DW As DataView = Dt.DefaultView
        Dim DW As New DataView(Dt)
        DW.RowFilter = "Menu_LinkFrom='" & MenuLink.Trim & "'"
        If DW.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    'Function GetVisibleMenuOnPage(MenuLink As String, Dt As DataTable) As Boolean
    '    '  Dim DW As DataView = Dt.DefaultView
    '    Dim DW As New DataView(Dt)
    '    DW.RowFilter = "Menu_Link='" & MenuLink.Trim & "'"
    '    If DW.Count = 0 Then
    '        Return False
    '    Else
    '        Return True
    '    End If
    'End Function

    Function getDTPermision(ByVal UserId As String) As DataTable
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = " Select * " & _
                 " From GenMenu_User " & _
                 " Where  APP='" & App_Project.Trim & "' And " & _
                        " Menu_Use=1 And " & _
                        " UserId='" & UserId.Trim & "' And " & _
                        " Menu_Id in (Select Menu_Id " & _
                                        " from GenCreateMenu_Master " & _
                                        " Where  app='" & App_Project.Trim & "')"


        Da = New SqlDataAdapter(Strsql, Conn)
        Da.Fill(Ds, "DATA")

        Return Ds.Tables("DATA")
    End Function

    Function getDTPermisionOnPage(ByVal UserId As String) As DataTable
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = " Select * " & _
                 " From GenMenu_UserOnPage " & _
                 " Where  APP='" & App_Project.Trim & "' And " & _
                        " St_Menu=1 And " & _
                        " EmpId='" & UserId.Trim & "' And " & _
                        " MenuId in (Select MenuId " & _
                                        " from GenMenu_MasterOnPage " & _
                                        " Where  app='" & App_Project.Trim & "')"


        Da = New SqlDataAdapter(Strsql, Conn)
        Da.Fill(Ds, "DATA")

        Return Ds.Tables("DATA")
    End Function

    Function getDTSaPermision() As DataTable
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = " Select * " & _
                " from GenCreateMenu_Master " & _
                " Where app='" & App_Project.Trim & "'"

        Da = New SqlDataAdapter(Strsql, Conn)
        Da.Fill(Ds, "DATA")

        Return Ds.Tables("DATA")
    End Function

    Function getDTSaPermisionOnPage() As DataTable
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = " Select * " & _
                " from GenMenu_MasterOnPage " & _
                " Where app='" & App_Project.Trim & "'"

        Da = New SqlDataAdapter(Strsql, Conn)
        Da.Fill(Ds, "DATA")

        Return Ds.Tables("DATA")
    End Function


    Function GetMenu_Link(ByVal Menu_Linkfrom As String) As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = " Select Menu_LinkFrom " & _
                 " From GenCreateMenu_Master " & _
                 " Where  APP='" & App_Project.Trim & "' And " & _
                        " Menu_Linkfrom='" & Menu_Linkfrom.Trim & "'"

        Try
            Da = New SqlDataAdapter(Strsql, Conn)
            Da.Fill(Ds, "DATA")

            With Ds.Tables("DATA")
                If .Rows.Count = 0 Then
                    Return ""
                Else
                    Return .Rows(0).Item("Menu_LinkFrom")
                End If
            End With
        Catch ex As Exception
            Return ""
        End Try
    End Function
#End Region

    'Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
    '    Application.Exit()
    'End Sub

    Private Sub CourseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigCourseStudy.Click
        'Try
        '    If fCourse Is Nothing Then
        '        fCourse = New frmCourse
        '    Else
        '        If fCourse.IsDisposed = True Then
        '            fCourse = New frmCourse
        '        End If
        '    End If
        '    fCourse.MdiParent = Me
        '    fCourse.BringToFront()
        '    fCourse.WindowState = FormWindowState.Maximized
        '    fCourse.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        'End Try
    End Sub

    Private Sub TypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    If fTypeMember Is Nothing Then
        '        fTypeMember = New frmTypeMember
        '    Else
        '        If fTypeMember.IsDisposed = True Then
        '            fTypeMember = New frmTypeMember
        '        End If
        '    End If
        '    fTypeMember.MdiParent = Me
        '    fTypeMember.BringToFront()
        '    fTypeMember.WindowState = FormWindowState.Maximized
        '    fTypeMember.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        'End Try
    End Sub


    Private Sub LevelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigCourseLevel.Click
        'Try
        '    If fLevel Is Nothing Then
        '        fLevel = New frmLevel
        '    Else
        '        If fLevel.IsDisposed = True Then
        '            fLevel = New frmLevel
        '        End If
        '    End If
        '    fLevel.MdiParent = Me
        '    fLevel.BringToFront()
        '    fLevel.WindowState = FormWindowState.Maximized
        '    fLevel.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        'End Try
    End Sub

    Private Sub ReToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    If fMemberProfile Is Nothing Then
        '        fMemberProfile = New frmMemberProfile
        '    Else
        '        If fMemberProfile.IsDisposed = True Then
        '            fMemberProfile = New frmMemberProfile
        '        End If
        '    End If
        '    fMemberProfile.MdiParent = Me
        '    fMemberProfile.BringToFront()
        '    fMemberProfile.WindowState = FormWindowState.Maximized
        '    fMemberProfile.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        'End Try
    End Sub


    Private Sub CoursePriceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    If fConfigPrice Is Nothing Then
        '        fConfigPrice = New frmConfigPrice
        '    Else
        '        If fConfigPrice.IsDisposed = True Then
        '            fConfigPrice = New frmConfigPrice
        '        End If
        '    End If
        '    fConfigPrice.MdiParent = Me
        '    fConfigPrice.BringToFront()
        '    fConfigPrice.WindowState = FormWindowState.Maximized
        '    fConfigPrice.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        'End Try
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    If fRegister Is Nothing Then
        '        fRegister = New frmRegister
        '    Else
        '        If fRegister.IsDisposed = True Then
        '            fRegister = New frmRegister
        '        End If
        '    End If
        '    fRegister.MdiParent = Me
        '    fRegister.BringToFront()
        '    fRegister.WindowState = FormWindowState.Maximized
        '    fRegister.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        'End Try
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigDepartment.Click
        'Try
        '    If fDepartment Is Nothing Then
        '        fDepartment = New frmDepartment
        '    Else
        '        If fDepartment.IsDisposed = True Then
        '            fDepartment = New frmDepartment
        '        End If
        '    End If
        '    fDepartment.MdiParent = Me
        '    fDepartment.BringToFront()
        '    fDepartment.WindowState = FormWindowState.Maximized
        '    fDepartment.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        'End Try
    End Sub

    Private Sub EmployeeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    If fEmp Is Nothing Then
        '        fEmp = New frmEmp
        '    Else
        '        If fEmp.IsDisposed = True Then
        '            fEmp = New frmEmp
        '        End If
        '    End If
        '    fEmp.MdiParent = Me
        '    fEmp.BringToFront()
        '    fEmp.WindowState = FormWindowState.Maximized
        '    fEmp.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        'End Try
    End Sub

    Private Sub MEMBERPROFILEToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Profile.Click
        'Try
        '    If fMemberProfile Is Nothing Then
        '        fMemberProfile = New frmMemberProfile
        '    Else
        '        If fMemberProfile.IsDisposed = True Then
        '            fMemberProfile = New frmMemberProfile
        '        End If
        '    End If
        '    fMemberProfile.MdiParent = Me
        '    fMemberProfile.BringToFront()
        '    fMemberProfile.WindowState = FormWindowState.Maximized
        '    fMemberProfile.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        'End Try
    End Sub

    Private Sub MenuRegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCash.Click
        'Try
        '    If fRegister Is Nothing Then
        '        fRegister = New frmRegister
        '    Else
        '        If fRegister.IsDisposed = True Then
        '            fRegister = New frmRegister
        '        End If
        '    End If
        '    fRegister.MdiParent = Me
        '    fRegister.BringToFront()
        '    fRegister.WindowState = FormWindowState.Maximized
        '    fRegister.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        'End Try
    End Sub

    Private Sub menuEmpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Emp.Click
        'Try
        '    If fEmp Is Nothing Then
        '        fEmp = New frmEmp
        '    Else
        '        If fEmp.IsDisposed = True Then
        '            fEmp = New frmEmp
        '        End If
        '    End If
        '    fEmp.MdiParent = Me
        '    fEmp.BringToFront()
        '    fEmp.WindowState = FormWindowState.Maximized
        '    fEmp.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        'End Try
    End Sub

    Private Sub TableTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TeachDayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigLearning.Click
        'Try
        '    If fTableTime Is Nothing Then
        '        fTableTime = New frmTableTime
        '    Else
        '        If fTableTime.IsDisposed = True Then
        '            fTableTime = New frmTableTime
        '        End If
        '    End If
        '    fTableTime.MdiParent = Me
        '    fTableTime.BringToFront()
        '    fTableTime.WindowState = FormWindowState.Maximized
        '    fTableTime.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        'End Try
    End Sub

    Private Sub TicketToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TicKet.Click
        'Try
        '    If fTicket Is Nothing Then
        '        fTicket = New frmTicket
        '    Else
        '        If fTicket.IsDisposed = True Then
        '            fTicket = New frmTicket
        '        End If
        '    End If
        '    fTicket.MdiParent = Me
        '    fTicket.BringToFront()
        '    fTicket.WindowState = FormWindowState.Maximized
        '    fTicket.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        'End Try
    End Sub

    '  Private Sub DETERMINECOURSELEVELADJUSTEDLEVELToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdjustLevel.Click
    'Try
    '    If fAdjustedLevel Is Nothing Then
    '        fAdjustedLevel = New frmAdjustedLevel
    '    Else
    '        If fAdjustedLevel.IsDisposed = True Then
    '            fAdjustedLevel = New frmAdjustedLevel
    '        End If
    '    End If
    '    fAdjustedLevel.MdiParent = Me
    '    fAdjustedLevel.BringToFront()
    '    fAdjustedLevel.WindowState = FormWindowState.Maximized
    '    fAdjustedLevel.Show()
    'Catch ex As Exception
    '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    'End Try
    '  End Sub

    'Private Sub btnProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduct.Click
    '    Try
    '        If fMemberProfile Is Nothing Then
    '            fMemberProfile = New frmMemberProfile
    '        Else
    '            If fMemberProfile.IsDisposed = True Then
    '                fMemberProfile = New frmMemberProfile
    '            End If
    '        End If
    '        fMemberProfile.MdiParent = Me
    '        fMemberProfile.BringToFront()
    '        fMemberProfile.WindowState = FormWindowState.Maximized
    '        fMemberProfile.Show()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    '    End Try
    'End Sub

    ' Private Sub BtnEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmp.Click
    'Try
    '    If fEmp Is Nothing Then
    '        fEmp = New frmEmp
    '    Else
    '        If fEmp.IsDisposed = True Then
    '            fEmp = New frmEmp
    '        End If
    '    End If
    '    fEmp.MdiParent = Me
    '    fEmp.BringToFront()
    '    fEmp.WindowState = FormWindowState.Maximized
    '    fEmp.Show()
    'Catch ex As Exception
    '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    'End Try
    ' End Sub

    ' Private Sub BtnTicKet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTicKet.Click
    'Try
    '    If fTicket Is Nothing Then
    '        fTicket = New frmTicket
    '    Else
    '        If fTicket.IsDisposed = True Then
    '            fTicket = New frmTicket
    '        End If
    '    End If
    '    fTicket.MdiParent = Me
    '    fTicket.BringToFront()
    '    fTicket.WindowState = FormWindowState.Maximized
    '    fTicket.Show()
    'Catch ex As Exception
    '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    'End Try
    '  End Sub

    ' Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
    'Try
    '    If fAdjustedLevel Is Nothing Then
    '        fAdjustedLevel = New frmAdjustedLevel
    '    Else
    '        If fAdjustedLevel.IsDisposed = True Then
    '            fAdjustedLevel = New frmAdjustedLevel
    '        End If
    '    End If
    '    fAdjustedLevel.MdiParent = Me
    '    fAdjustedLevel.BringToFront()
    '    fAdjustedLevel.WindowState = FormWindowState.Maximized
    '    fAdjustedLevel.Show()
    'Catch ex As Exception
    '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    'End Try
    '  End Sub

    ' Private Sub btnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayment.Click
    'Try
    '    If fRegister Is Nothing Then
    '        fRegister = New frmRegister
    '    Else
    '        If fRegister.IsDisposed = True Then
    '            fRegister = New frmRegister
    '        End If
    '    End If
    '    fRegister.MdiParent = Me
    '    fRegister.BringToFront()
    '    fRegister.WindowState = FormWindowState.Maximized
    '    fRegister.Show()
    'Catch ex As Exception
    '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    'End Try
    ' End Sub

    ' Private Sub SaveCourseDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddDataLearning.Click
    'Try
    '    If fCourseData Is Nothing Then
    '        fCourseData = New frmCourseData
    '    Else
    '        If fCourseData.IsDisposed = True Then
    '            fCourseData = New frmCourseData
    '        End If
    '    End If
    '    fCourseData.MdiParent = Me
    '    fCourseData.BringToFront()
    '    fCourseData.WindowState = FormWindowState.Maximized
    '    fCourseData.Show()
    'Catch ex As Exception
    '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    'End Try
    ' End Sub

    ' Private Sub AlertCourseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigAlert.Click
    'Try
    '    If fAlertCourse Is Nothing Then
    '        fAlertCourse = New frmAlertCourse
    '    Else
    '        If fAlertCourse.IsDisposed = True Then
    '            fAlertCourse = New frmAlertCourse
    '        End If
    '    End If
    '    fAlertCourse.MdiParent = Me
    '    fAlertCourse.BringToFront()
    '    fAlertCourse.WindowState = FormWindowState.Maximized
    '    fAlertCourse.Show()
    'Catch ex As Exception
    '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    'End Try
    ' End Sub


    ' Private Sub MenuMeberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RptMenber.Click
    'Try
    '    If fRptMember Is Nothing Then
    '        fRptMember = New frmRptMember
    '    Else
    '        If fRptMember.IsDisposed = True Then
    '            fRptMember = New frmRptMember
    '        End If
    '    End If
    '    fRptMember.MdiParent = Me
    '    fRptMember.BringToFront()
    '    ' fRptMember.WindowState = FormWindowState.Maximized
    '    fRptMember.Show()
    'Catch ex As Exception
    '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    'End Try
    ' End Sub

    ' Private Sub MenuMemberServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RptMemberIn.Click
    'Try
    '    If fRPTMemberService Is Nothing Then
    '        fRPTMemberService = New frmRPTMemberService
    '    Else
    '        If fRPTMemberService.IsDisposed = True Then
    '            fRPTMemberService = New frmRPTMemberService
    '        End If
    '    End If
    '    fRPTMemberService.MdiParent = Me
    '    fRPTMemberService.BringToFront()
    '    ' fRptMember.WindowState = FormWindowState.Maximized
    '    fRPTMemberService.Show()
    'Catch ex As Exception
    '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    'End Try
    'End Sub

    'Private Sub MenuRptDaliyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RptProfit.Click
    'Try
    '    If fRptDailyReport Is Nothing Then
    '        fRptDailyReport = New frmRptDailyReport
    '    Else
    '        If fRptDailyReport.IsDisposed = True Then
    '            fRptDailyReport = New frmRptDailyReport
    '        End If
    '    End If
    '    fRptDailyReport.MdiParent = Me
    '    fRptDailyReport.BringToFront()
    '    ' fRptMember.WindowState = FormWindowState.Maximized
    '    fRptDailyReport.Show()
    'Catch ex As Exception
    '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    'End Try
    ' End Sub

    '  Private Sub mnuStudyRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RptAddLearning.Click
    'Try
    '    If fRptStudyRecord Is Nothing Then
    '        fRptStudyRecord = New frmRptStudyRecord
    '    Else
    '        If fRptStudyRecord.IsDisposed = True Then
    '            fRptStudyRecord = New frmRptStudyRecord
    '        End If
    '    End If
    '    fRptStudyRecord.MdiParent = Me
    '    fRptStudyRecord.BringToFront()
    '    ' fRptMember.WindowState = FormWindowState.Maximized
    '    fRptStudyRecord.Show()
    'Catch ex As Exception
    '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    'End Try
    '  End Sub

    'Private Sub CancelBillCash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBillCash.Click
    '    Try
    '        If fCancelBillCash Is Nothing Then
    '            fCancelBillCash = New frmCancelBillCash
    '        Else
    '            If fCancelBillCash.IsDisposed = True Then
    '                fCancelBillCash = New frmCancelBillCash
    '            End If
    '        End If
    '        fCancelBillCash.MdiParent = Me
    '        fCancelBillCash.BringToFront()
    '        ' fRptMember.WindowState = FormWindowState.Maximized
    '        fCancelBillCash.Show()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    '    End Try
    'End Sub

    'Private Sub SlipReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlipReturn.Click
    '    Try
    '        If fReturnBill Is Nothing Then
    '            fReturnBill = New frmReturnBill
    '        Else
    '            If fReturnBill.IsDisposed = True Then
    '                fReturnBill = New frmReturnBill
    '            End If
    '        End If
    '        fReturnBill.MdiParent = Me
    '        fReturnBill.BringToFront()
    '        ' fRptMember.WindowState = FormWindowState.Maximized
    '        fReturnBill.Show()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    '    End Try
    'End Sub


    'Private Sub CancelTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelTicket.Click
    '    Try
    '        If fCancelTicket Is Nothing Then
    '            fCancelTicket = New frmCancelTicket
    '        Else
    '            If fCancelTicket.IsDisposed = True Then
    '                fCancelTicket = New frmCancelTicket
    '            End If
    '        End If
    '        fCancelTicket.MdiParent = Me
    '        fCancelTicket.BringToFront()
    '        ' fRptMember.WindowState = FormWindowState.Maximized
    '        fCancelTicket.Show()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    '    End Try
    'End Sub

    'Private Sub UserPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserPass.Click
    '    Try
    '        If fPermission Is Nothing Then
    '            fPermission = New frmPermission
    '        Else
    '            If fPermission.IsDisposed = True Then
    '                fPermission = New frmPermission
    '            End If
    '        End If
    '        fPermission.WindowState = FormWindowState.Maximized
    '        fPermission.MdiParent = fMainMenu
    '        fPermission.BringToFront()
    '        fPermission.Show()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    '    End Try
    'End Sub

    'Private Sub PerPattern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerPattern.Click
    '    Try
    '        If fGenGroupMenuMaster Is Nothing Then
    '            fGenGroupMenuMaster = New frmGenGroupMenuMaster
    '        Else
    '            If fGenGroupMenuMaster.IsDisposed = True Then
    '                fGenGroupMenuMaster = New frmGenGroupMenuMaster
    '            End If
    '        End If

    '        fGenGroupMenuMaster.MdiParent = fMainMenu
    '        fGenGroupMenuMaster.BringToFront()
    '        fGenGroupMenuMaster.WindowState = FormWindowState.Maximized
    '        fGenGroupMenuMaster.Show()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    '    End Try
    'End Sub

    'Private Sub PerUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerUser.Click
    '    Try
    '        If fSetUserLogIn Is Nothing Then
    '            fSetUserLogIn = New frmSetUserLogIn
    '        Else
    '            If fSetUserLogIn.IsDisposed = True Then
    '                fSetUserLogIn = New frmSetUserLogIn
    '            End If
    '        End If

    '        fSetUserLogIn.MdiParent = fMainMenu
    '        fSetUserLogIn.BringToFront()
    '        fSetUserLogIn.WindowState = FormWindowState.Maximized
    '        fSetUserLogIn.Show()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    '    End Try
    'End Sub

    'Private Sub GenMenuProgrammer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenMenuProgrammer.Click
    '    Try
    '        If fGenMenuMaster Is Nothing Then
    '            fGenMenuMaster = New frmGenMenuMaster
    '        Else
    '            If fGenMenuMaster.IsDisposed = True Then
    '                fGenMenuMaster = New frmGenMenuMaster
    '            End If
    '        End If
    '        fGenMenuMaster.MdiParent = fMainMenu
    '        fGenMenuMaster.BringToFront()
    '        '  fRpt_EmpDetail.WindowState = FormWindowState.Maximized
    '        fGenMenuMaster.Show()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    '    End Try
    'End Sub


    'Private Sub ขอมลToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Date_HD.Click

    'End Sub

   
    Private Sub mnuUserPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUserPass.Click
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

    Private Sub mnuPerPattern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPerPattern.Click
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

    Private Sub mnuPerUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPerUser.Click
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

    Private Sub mnurptTimeWork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptTimeWork.Click
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

    Private Sub mnurptTimeWorkLateByOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptTimeWorkLateByOne.Click
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

    Private Sub mnurptTimeSheet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptTimeSheet.Click
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

    Private Sub mnurptAllemployeework_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptAllemployeework.Click
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

    Private Sub mnurptEmployeework_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptEmployeework.Click

    End Sub

    Private Sub mnurptEmpWorkDetail1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptEmpWorkDetail1.Click
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

    Private Sub mnurptEmpWorkDetail2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptEmpWorkDetail2.Click
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

    Private Sub mnurptOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptOT.Click
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

    Private Sub mnurptSumaryMonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptSumaryMonth.Click
        'Try
        '    If fSumarized Is Nothing Then
        '        fSumarized = New frmSumarized
        '    Else
        '        If fSumarized.IsDisposed = True Then
        '            fSumarized = New frmSumarized
        '        End If
        '    End If
        '    fSumarized.MdiParent = Me
        '    fSumarized.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        'End Try
    End Sub

    Private Sub mnurptrptSumaryMonthLateByBath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptrptSumaryMonthLateByBath.Click
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

    Private Sub mnurptScheduleWorkAllEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptScheduleWorkAllEmp.Click
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

    Private Sub mnuConfigSummaryScheduleWorkAllEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConfigSummaryScheduleWorkAllEmp.Click
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

    Private Sub mnurptSummaryScheduleWorkAllEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptSummaryScheduleWorkAllEmp.Click
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

    Private Sub mnuConfigEmpNotWork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConfigEmpNotWork.Click
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

    Private Sub mnurptEmpNotWork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptEmpNotWork.Click
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

    Private Sub mnurptemployeeByDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptemployeeByDate.Click
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

    Private Sub mnuConfogSumaryemployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConfogSumaryemployee.Click
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

    Private Sub mnurptSumaryemployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptSumaryemployee.Click
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

    Private Sub mnurptMaximumOThoursdaysweeksyear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptMaximumOThoursdaysweeksyear.Click
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

    Private Sub mnurptNormalworkinghoursOTByWeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptNormalworkinghoursOTByWeek.Click
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

    Private Sub mnuConfigSumaryHolidayInYears_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConfigSumaryHolidayInYears.Click
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

    Private Sub mnurptSumaryHolidayInYears_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptSumaryHolidayInYears.Click
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

    Private Sub mnuprtAllowance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuprtAllowance.Click
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

    Private Sub mnuRptSumary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRptSumary.Click
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

    Private Sub mnuRptSumaryByMonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRptSumaryByMonth.Click
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

    Private Sub mnuRptSumaryByYear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRptSumaryByYear.Click
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

    Private Sub munOvertimeLeage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles munOvertimeLeage.Click
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

    Private Sub mnumodelcalculations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnumodelcalculations.Click
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

    Private Sub mnuworkinggroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuworkinggroup.Click
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

    Private Sub mnuDeterminedTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeterminedTime.Click
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

    Private Sub mnuDeterminedTimeEmpByOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeterminedTimeEmpByOne.Click
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

    Private Sub mnuDeterminedTimeEmpByDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeterminedTimeEmpByDate.Click
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

    Private Sub mnusetBarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnusetBarcode.Click
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
            fSetBarcode.WindowState = FormWindowState.Maximized
            fSetBarcode.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuProcessOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProcessOT.Click
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

    Private Sub mnucalculationLate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnucalculationLate.Click
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

    Private Sub mnucalculationBreak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnucalculationBreak.Click
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

    Private Sub mnuSetholiday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetholiday.Click
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

    Private Sub mnuSetLeave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetLeave.Click
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

    Private Sub mnuSetabsenceTimeByYear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetabsenceTimeByYear.Click
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

    Private Sub mnuOTBasic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOTBasic.Click
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

    Private Sub mnusetovertimepay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnusetovertimepay.Click
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

    Private Sub mnusetovertimekap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnusetovertimekap.Click
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

    Private Sub mnusetdelaytime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnusetdelaytime.Click
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

    Private Sub mnusetdelayOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnusetdelayOT.Click
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

    Private Sub mnuSetCancelDelayOTByDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetCancelDelayOTByDay.Click
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

    Private Sub mnuOTbyDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOTbyDay.Click
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

    Private Sub mnuconditionslate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuconditionslate.Click
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

    Private Sub mnuconditionslatesomeone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuconditionslatesomeone.Click
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

    Private Sub mnuconditionslatebyRateSpacal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuconditionslatebyRateSpacal.Click
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

    Private Sub mnuconditionslatebyRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuconditionslatebyRate.Click
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

    Private Sub mnusetAllowance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnusetAllowance.Click
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

    Private Sub mnuLinkCodePayroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLinkCodePayroll.Click
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

    Private Sub mnulimitOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnulimitOT.Click
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

    Private Sub mnImportData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnImportData.Click
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

    Private Sub mnuPermissionTimeAtt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPermissionTimeAtt.Click
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

    Private Sub mnuManageTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuManageTime.Click
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

    Private Sub mnuOvertime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOvertime.Click
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

    Private Sub mnuLateTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLateTime.Click
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

    Private Sub mnuabsenceTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuabsenceTime.Click
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

    Private Sub mnuAllowance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAllowance.Click
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

    Private Sub mnuInputLeaveData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInputLeaveData.Click
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

    
    Private Sub mnuforProgramer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuforProgramer.Click
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

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub mnuMove_KaTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMove_KaTime.Click
        Try
            If fTimeKa_Move Is Nothing Then
                fTimeKa_Move = New frmTimeKa_Move
            Else
                If fTimeKa_Move.IsDisposed = True Then
                    fTimeKa_Move = New frmTimeKa_Move
                End If
            End If
            fTimeKa_Move.MdiParent = fMainMenuHD
            fTimeKa_Move.BringToFront()
            '  fRpt_EmpDetail.WindowState = FormWindowState.Maximized
            fTimeKa_Move.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnuSpacialKa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSpacialKa.Click
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

    Private Sub mnuSummaryScheduleWorkAllEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSummaryScheduleWorkAllEmp.Click

    End Sub

    Private Sub mnuImportMasterProfile_Click(sender As Object, e As EventArgs) Handles mnuImportMasterProfile.Click
        Try
            If fImportEmpProfile Is Nothing Then
                fImportEmpProfile = New frmImportEmpProfile
            Else
                If fImportEmpProfile.IsDisposed = True Then
                    fImportEmpProfile = New frmImportEmpProfile
                End If
            End If
            fImportEmpProfile.BringToFront()
            fImportEmpProfile.MdiParent = Me
            fImportEmpProfile.WindowState = FormWindowState.Maximized
            fImportEmpProfile.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub mnurptEmpWorkDetail1_M_Click(sender As Object, e As EventArgs) Handles mnurptEmpWorkDetail1_M.Click
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

    Private Sub mnurptAllemployeework2_Click(sender As Object, e As EventArgs) Handles mnurptAllemployeework2.Click
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

    Private Sub mnurptScheduleWorkAllEmp2_Click(sender As Object, e As EventArgs) Handles mnurptScheduleWorkAllEmp2.Click
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

    Private Sub mnuCompanyCenter_Click(sender As Object, e As EventArgs) Handles mnuCompanyCenter.Click
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

    Private Sub mnuConfiguration_Click(sender As Object, e As EventArgs) Handles mnuConfiguration.Click

    End Sub

    Private Sub mnuSumaryemployee_Click(sender As Object, e As EventArgs) Handles mnuSumaryemployee.Click

    End Sub
End Class
