Imports System.Data
Imports System.Data.SqlClient

Imports DevComponents.DotNetBar
Imports DevComponents.AdvTree
Imports System.Data.OleDb

'Imports TimeAttendance.utils
Imports System.IO
Imports System.Globalization
Imports TimeAttendance.utils
Imports System.Linq
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmSetUserLogIn
    Dim gData As New GetData
    Protected dbMgr As New DBManager
    Protected dbConnStr As String = dbMgr.getConnString
    Private Sub LoadDivision()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select * From Division Order by  Division"

        Da = New SqlDataAdapter(Strsql, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            cmbDivistionId.Properties.Items.Clear()
            cmbDivistionId.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))

            For Each dr As DataRow In .Rows
                cmbDivistionId.Properties.Items.Add(dr("Division"))
            Next
            cmbDivistionId.SelectedIndex = 0
        End With
    End Sub

    Private Sub LoadDepartMent()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select * From Department  Order by  Department"

        Da = New SqlDataAdapter(Strsql, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            cmbDepartMent.Properties.Items.Clear()
            cmbDepartMent.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))

            For Each dr As DataRow In .Rows
                cmbDepartMent.Properties.Items.Add(dr("Department"))
            Next
            cmbDepartMent.SelectedIndex = 0
        End With
    End Sub





    Private Sub frmSetUserLogIn_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ProgressBarX1.Visible = False
        Call LoadDivision()   'ฝ่าย
        Call LoadDepartMent()  'แผนก
        Call LoadPerGroupName()


        PG.Visible = False
        cmbDivistionId.SelectedIndex = 0
        cmbDepartMent.SelectedIndex = 0


        '   TabControl1.SelectedTabIndex = 0
        XtraTabControl1.SelectedTabPageIndex = 0
        tabMenu.SelectedTabPageIndex = 0
    End Sub

    Private Sub LoadPerGroupName()

        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        '  strSQL = "Select Code,"

        strSQL = "Select GrpId,GrpName " &
                    " from genmenu_configgroup"


        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")


        cboPerGroupName.Properties.DataSource = Ds.Tables("Data")
        cboPerGroupName.Properties.DisplayMember = "GrpName"
        cboPerGroupName.Properties.ValueMember = "GrpId"

    End Sub



    Private Sub btnShowData_Click(sender As System.Object, e As System.EventArgs) Handles btnShowData.Click
        Call LoadEmp() ' แสดงข้อุล ทีียังไม่ได้กำหนดสิทธิื

        '  Call LoadcofigEmpPermision() ' แสดงรายชื่อที่กำหนดสิทธิ์แล้ว
        grpEditMenubyOne.Enabled = False
        '   CboPremissionName.SelectedIndex = 0
        '     Call CboPremissionName_SelectedIndexChanged(e, EventArgs.Empty)
        txtCodeEdit.Text = ""
        txtNameedit.Text = ""
    End Sub

    Private Sub LoadEmp()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        'strSQL = "Select row_number() over(ORDER BY Code"
        'strSQL &= " ) As row," &
        '                " Emp.Code,isnull(emp.title,'') + isnull(emp.Fname,'') as Fname,Lname, " &
        '                " Division = Isnull(Div.Division,''), " &
        '                " Department = Isnull(Department.Department,''), " &
        '                " Position = Isnull(Emp.Position,'')," &
        '                " u.username" &
        '        " From [User] u " &
        '                " left join Emp " &
        '                    " on u.userid = emp.code " &
        '                " Left Join Department " &
        '                    " On Emp.DeptId = Department.DeptId " &
        '                " Left Join Division Div " &
        '                    " On Department.DivId = Div.DivId " &
        '        " Where WorkStatus = 'W' " &
        '                 " And u.UserID Not in (select Userid from GenMenu_User where app='" & App_Project.Trim & "') "


        'If cmbDivistionId.SelectedIndex > 0 Then
        '    strSQL &= " and Isnull(Department.DivId,'') = '" & GetData.GetDivisionId(cmbDivistionId.Text.Trim) & "'"
        'End If

        'If cmbDepartMent.SelectedIndex > 0 Then
        '    strSQL &= " and Isnull(Emp.DeptId,'') = '" & GetData.GetDepartmentId(cmbDepartMent.Text.Trim) & "'"
        'End If

        strSQL = "Select Row_Number() Over(ORDER BY U.UserID) as row, " &
                        " Isnull(Gc.grpname,'') as GroupPer,u.username,u.UserID,e.Fname " &
                        " ,e.Lname,di.Division,dp.Department,e.Position " &
                " From [User] u " &
                        " Left JOin Emp e " &
                            " On U.userid=e.Code " &
                        " Left Join Division di " &
                            " On e.DivId=di.DivId " &
                        " Left Join Department dp " &
                            " On e.DeptId=dp.DeptId " &
                        " Left JOin genmenu_groupuser gg " &
                            " On u.UserID=gg.Userid " &
                        " Left Join genmenu_configgroup Gc " &
                            " On U.Grpid=gc.grpid" &
               " Where 1=1 "

        If cmbDivistionId.SelectedIndex > 0 Then
            strSQL &= " and Isnull(e.DivId,'') = '" & GetData.GetDivisionId(cmbDivistionId.Text.Trim) & "'"
        End If

        If cmbDepartMent.SelectedIndex > 0 Then
            strSQL &= " and Isnull(e.DeptId,'') = '" & GetData.GetDepartmentId(cmbDepartMent.Text.Trim) & "'"
        End If

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")

        GcEmp.DataSource = Ds
        GcEmp.DataMember = "Data"
    End Sub

    Private Sub LoadEmp_permisionUse(Grpid As Integer)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String


        strSQL = "Select Row_Number() Over(ORDER BY U.UserID) as row, " &
                        " u.username, " &
                        " Code=u.UserID, " &
                        " e.Fname, " &
                        " e.Lname, " &
                        " di.Division,dp.Department,e.Position,Isnull(u.GrpId,'') as Grpid " &
                " From [User] u " &
                        " Left JOin Emp e " &
                            " On U.userid=e.Code " &
                        " Left Join Division di " &
                            " On e.DivId=di.DivId " &
                        " Left Join Department dp " &
                            " On e.DeptId=dp.DeptId " &
                        " Left JOin genmenu_groupuser gg " &
                            " On u.UserID=gg.Userid " &
                        " Left Join genmenu_configgroup Gc " &
                            " On gg.Grpid=gc.grpid " &
                " Where u.Grpid=" & Grpid & ""






        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")

        Gcmenu_use.DataSource = Ds
        Gcmenu_use.DataMember = "Data"
    End Sub

    Public Function getDeptId(ByVal Department As String) As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        Dim dCmd As New SqlCommand
        Dim db As New db

        Dim Data As New ArrayList
        Dim strType As String = ""

        Data.Clear() : strType = ""
        Data.Add(Department.Trim) : strType &= "T"

        strSQL = "Select DeptId, DepartmentName " &
                " from Department " &
                " Where DepartmentName = @P1"

        '    
        db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        '    


        With Ds.Tables("Data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Dim dr As DataRow = .Rows(0)
                Return dr("DeptId")
            End If
        End With
    End Function

    'Private Sub LoadEmpDetail()
    '    Dim DA As New SqlDataAdapter
    '    Dim DS As New DataSet
    '    Dim Strsql As String = ""
    '    Dim dcmd As New SqlCommand

    '    Strsql = "Select GM.Comid," & _
    '                     " GM.empid, " & _
    '                      " Tiele=Isnull(E.Title,''), " & _
    '                      " Name=Isnull(E.Name,''), " & _
    '                      " Lname=isnull(E.Lname,''), " & _
    '                      " Departmentid=isnull(E.DepartmentId,'')  " & _
    '            " from Genmenu GM  " & _
    '              " Left Join Emp E " & _
    '                  " On Gm.empid=E.empid " & _
    '                    " And gm.comid=e.comid " & _
    '            " Where GM.comid='" & CompanyID.Trim & "' And " & _
    '                            " GM.EmpId='" & txtEmpId.Text.Trim & "'"

    '    Try
    '        OpenConnect(True)
    '        DA = New SqlDataAdapter(Strsql, Conn)
    '        DA.Fill(DS, "DATA")
    '        OpenConnect(False)

    '        With DS.Tables("DATA")
    '            If .Rows.Count = 0 Then
    '                '   MsgBox("ไม่พบรหัสพนักงาน กรุณาตรวจสอบอีกครั้ง", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "แจ้งทราบ")
    '                ' Call LoadEmp(txtEmpId.Text)
    '                Exit Sub
    '            Else
    '                txtFname.Text = .Rows(0).Item("name") & "    " & .Rows(0).Item("Lname")
    '                ' txtDepartment.Text = GetData.GetDeartmentName(.Rows(0).Item("DepartmentId"), CompanyID.Trim)
    '            End If
    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub txtEmpId_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
    '    If Asc(e.KeyChar) = 13 Then
    '        '' Call LoadEmpDetail()
    '        txtFname.Text = GetEmpName(txtEmpId.Text.Trim)
    '    End If
    'End Sub

    'Public Shared Function GetEmpName(IDUser As String) As String   ' หาชื่อ สกุล

    '    Dim DA As New SqlDataAdapter
    '    Dim DS As New DataSet
    '    Dim strsql As String = ""

    '    strsql = "Select * " & _
    '            " from Emp " & _
    '            " where  Code='" & IDUser.Trim & "'   "

    '    Try
    '        OpenConnect(True)
    '        DA = New SqlDataAdapter(strsql, Conn)
    '        DA.Fill(DS, "DATA")
    '        OpenConnect(False)

    '        With DS.Tables("DATA")
    '            If .Rows.Count = 0 Then
    '                Return ""
    '            Else
    '                Return .Rows(0).Item("fName") & "  -  " & .Rows(0).Item("Lname")
    '            End If
    '        End With
    '    Catch ex As Exception
    '        '   MsgBox(ex.Message)
    '        Return ""

    '    End Try

    'End Function


    Public Shared Function GetEmpName(IDUser As String) As String   ' หาชื่อ สกุล

        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim strsql As String = ""

        strsql = "Select * " &
                " from Emp " &
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
                    Return .Rows(0).Item("fname") & "  -  " & .Rows(0).Item("LName")
                End If
            End With
        Catch ex As Exception
            '   MsgBox(ex.Message)
            Return ""

        End Try

    End Function

    Private Sub txtEmpId_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click
        Dim i As Integer = 0
        For i = 0 To lstEmp.Items.Count - 1
            If lstEmp.Items.Count > 0 Then
                lstEmp.Items(i).Checked = True
            End If
        Next
    End Sub

    Private Sub btnNotAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotAll.Click
        Dim i As Integer = 0
        For i = 0 To lstEmp.Items.Count - 1
            If lstEmp.Items.Count > 0 Then
                lstEmp.Items(i).Checked = False
            End If
        Next
    End Sub

    'Private Sub LoadData()
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim Strsql As String = ""

    '    Strsql = "Select Menu_Id,Menu_Name,NO_Pic " & _
    '             " from GenCreateMenu_Master " & _
    '             " Where APP='" & App_Project.Trim & "' And " & _
    '                    " St_MenuMain = 1"

    '    Try
    '        Da = New SqlDataAdapter(Strsql, Conn)
    '        Da.Fill(Ds, "DATA")

    '        With Ds.Tables("DATA")
    '            If .Rows.Count = 0 Then
    '                AdvTree2.Nodes.Clear()
    '            Else
    '                'หาข้อมูลหลักก่อน
    '                AdvTree2.Nodes.Clear()

    '                PG.Maximum = .Rows.Count
    '                Dim i As Integer = 0
    '                For Each Dr As DataRow In .Rows


    '                    Dim M_Id As String
    '                    Dim nd As New DevComponents.AdvTree.Node
    '                    Dim Cx1 As New DevComponents.AdvTree.Cell
    '                    Dim Cx2 As New DevComponents.AdvTree.Cell


    '                    ' กำหนดตำแหน่ง Icon อันนี้อยู่ตอนกำหนด Config ว่าจะให้เป็นรูปไหน อยู่ที่ตัวเลขที่กำหนด เฉพาะเมนูหลัก
    '                    If Dr("No_PiC") = 1 Then
    '                        ' nd.Image = Global.Warehouse.My.Resources.Resources.Settings_icon_24
    '                    ElseIf Dr("No_PiC") = 2 Then
    '                        ' nd.Image = Global.Warehouse.My.Resources.Resources.Document_icon_x_24
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
    '                    If ChkPermision_FromMenu_Id(M_Id, CboPremissionName.Text.Trim) = True Then
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
    '                    PG.Value = i
    '                Next

    '            End If

    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    ' เช็คการกำหนดการใช้สิทธิ์การใช้เมนูว่าบันทึก หรือกำหนไว้หรือยัง
    Function ChkPermision_FromMenu_Id(MenuId As String, PatternName As String) As Boolean
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

    Private Sub LoadShowData(ByVal nd As DevComponents.AdvTree.Node, ByVal MenuId As String)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand


        Strsql = "Select M.S_Id" &
                 " from GenMenu_Group M Left Join " &
                         " GenCreateMenu_Master MT " &
                                " On M.M_Id=Mt.Menu_Id " &
                                    " M.Comid=Mt.Comid " &
                 " Where  APP='" & App_Project.Trim & "' And " &
                        " M_Id='" & MenuId & "'" &
                 " Order by M.M_Id,M.S_Id"

        Try
            'OpenConnect(True)
            Da = New SqlDataAdapter(Strsql, Conn)
            Da.Fill(Ds, "DATA")
            'OpenConnect(False)

            Dim I As Integer = 0
            With Ds.Tables("DATA")

                For Each Dr As DataRow In .Rows
                    Dim Time As String = ""

                    ' หาชื่อเมนูย่อย
                    Dim S_Id As String
                    Dim MenuName As String


                    S_Id = Dr("S_Id")
                    MenuName = GetNameMenu(Dr("S_Id"))


                    Dim ndd As New DevComponents.AdvTree.Node

                    ' Chkbox หน้าเมนู ย่อย
                    ndd.CheckBoxThreeState = True
                    ndd.CheckBoxVisible = True


                    ' เช็คการกำหนดสิทธิ์ - ของเมนู ว่าได้มีการกำหนดการใช้ไว้หรือไม่
                    'If ChkPermision_FromMenu_Id(S_Id, CboPremissionName.Text.Trim) = True Then
                    '    ndd.Checked = True
                    'Else
                    '    ndd.Checked = False
                    'End If
                    '================


                    ndd.Text = MenuName
                    ndd.VerticalCellLayoutAlignment = eHorizontalAlign.Center
                    nd.Nodes.Add(ndd)


                    Dim Cell_ As New DevComponents.AdvTree.Cell
                    ' เช็คการกำหนดผู้อนุมัติในเมนู ว่ามีหรือไม่---------------------------------------------------------
                    If ChkStatus_FormApprove(S_Id) = True Then
                        Cell_.CheckBoxThreeState = True
                        Cell_.CheckBoxVisible = True
                        Cell_.StyleMouseOver = Nothing
                        Cell_.Text = MsgManager.ShowLabel(Me, "Labels", "Approve") ' "สิทธิการอนุมัติ"

                        ''แสดงข้อมุลการบันทึก ว่ากำหนด หรือไม่
                        'If ChkStatus_Approve(S_Id) = True Then
                        '    Cell_.Checked = True
                        'Else
                        '    Cell_.Checked = False
                        'End If
                    End If
                    ndd.Cells.Add(Cell_)


                    Dim Cell_1 As New DevComponents.AdvTree.Cell
                    'เช็คว่ามีการกำหนดให้ฟอร์มนั้นกำหนด ReadOnly หรือไม่----------------------------------------------
                    If ChkStatus_ReadOnly(S_Id) = True Then
                        Cell_1.CheckBoxThreeState = True
                        Cell_1.CheckBoxVisible = True
                        Cell_1.StyleMouseOver = Nothing
                        Cell_1.Text = "ReadOnly"


                        'แสดงข้อมุลการบันทึก ว่ากำหนด หรือไม่
                        'If ChkStatus_ChkReadOnly(S_Id) = True Then
                        '    Cell_1.Checked = True
                        'Else
                        '    Cell_1.Checked = False
                        'End If
                    End If
                    ndd.Cells.Add(Cell_1)

                    Call LoadShowData(ndd, S_Id)

                Next

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

    End Sub

    Function GetNameMenu(MenuId As String) As String
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

    Function ChkStatus_FormApprove(MenuId As String) As Boolean
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select Menu_Id " &
                 " From GenCreateMenu_Master " &
                 " Where  APP='" & App_Project.Trim & "' And " &
                        " Menu_Id='" & MenuId.Trim & "' And " &
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

    'Function ChkStatus_Approve(MenuId As String) As Boolean
    '    Dim DA As New SqlDataAdapter
    '    Dim DS As New DataSet
    '    Dim Strsql As String = ""

    '    Strsql = "Select Menu_Id from GenMenu_Pattern Where Menu_Id='" & MenuId.Trim & "'And Menu_Approve=1"

    '    Try
    '        DA = New SqlDataAdapter(Strsql, Conn)
    '        DA.Fill(DS, "DATA")

    '        With DS.Tables("DATA")
    '            If .Rows.Count = 0 Then
    '                Return False
    '            Else
    '                Return True
    '            End If
    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return False
    '    End Try
    'End Function

    'Function ChkStatus_ChkReadOnly(MenuId As String) As Boolean
    '    Dim DA As New SqlDataAdapter
    '    Dim DS As New DataSet
    '    Dim Strsql As String = ""

    '    Strsql = "Select Menu_Id from GenMenu_Pattern Where Menu_Id='" & MenuId.Trim & "'And Menu_ReadOnly=1"

    '    Try
    '        DA = New SqlDataAdapter(Strsql, Conn)
    '        DA.Fill(DS, "DATA")

    '        With DS.Tables("DATA")
    '            If .Rows.Count = 0 Then
    '                Return False
    '            Else
    '                Return True
    '            End If
    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return False
    '    End Try
    'End Function



    Function ChkStatus_ReadOnly(MenuId As String) As Boolean
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select Menu_Id " &
                 " From GenCreateMenu_Master " &
                 " Where  APP='" & App_Project.Trim & "' And " &
                        " Menu_Id='" & MenuId.Trim & "' " &
                        " And Menu_ReadOnly=1"

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

    'Private Sub LoadDataPattern()
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim strsql As String = ""


    '    strsql = "Select PatternName " &
    '                " from genmenu_pattern" &
    '                " Where  APP='" & App_Project.Trim & "' And " &
    '                        " PatternName<>'sa'  " &
    '                " Group by PatternName"

    '    Try
    '        'OpenConnect(True)
    '        Da = New SqlDataAdapter(strsql, Conn)
    '        Da.Fill(Ds, "DATA")
    '        'OpenConnect(False)

    '        With Ds.Tables("DATA")

    '            Dim I As Integer = 0
    '            CboPremissionName.Properties.Items.Clear()
    '            CboPremissionName.Properties.Items.Add("")
    '            For Each drw As DataRow In .Rows
    '                CboPremissionName.Properties.Items.Add(drw("Patternname"))
    '            Next

    '        End With

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly)

    '    End Try
    'End Sub

    Private Sub CboPremissionName_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

        '   Call LoadCheckPermision() ' แสดงข้อมุลการกำหนดเมนูไว้แล้ว


        Call LoadCheckPermision(False) ' แสดงการเช็คสิทธิ์
        ' Call LoadcofigEmpPermision()  ' แสดงข้อมุลที่เคยบันทึกไว้ ตาม กลุ่มสิทธิ์

        '   Call LoadcofigEmpPermision() ' แสดงข้อมูลพนักงานที่ได้กำหนดสิทธิ์ไว้แล้ว ตามกลุ่ม
    End Sub

    Function LoadCheckboxPermision(ByVal MenuId As String, ByVal PatternName As String) As Boolean
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        'Strsql = "Select * from GenMenu_Pattern " &
        '         " Where APP='" & App_Project.Trim & "' And " &
        '                " Menu_Id='" & MenuId.Trim & "' And  " &
        '                " Menu_Use=1 And " &
        '                " PatternName='" & PatternName.Trim & "'"

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

    Function getDTPermisionLoad(patternname As String) As DataTable
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""


        Strsql = "Select * " &
                 " from GenMenu_Pattern  " &
                 " where patternname='" & patternname.Trim & "' " &
                        " And APP='" & App_Project.Trim & "'" &
                        " And Menu_Use=1 "

        Da = New SqlDataAdapter(Strsql, Conn)
        Da.Fill(Ds, "DATA")

        Return Ds.Tables("DATA")
    End Function

    Function getDTPermision_User(UserId As String) As DataTable
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""


        Strsql = "select * " &
                 " from GenMenu_User " &
                 " where APP='" & App_Project.Trim & "'  " &
                        " And UserId ='" & UserId & "'  " &
                        " And menu_use=1 "

        Da = New SqlDataAdapter(Strsql, Conn)
        Da.Fill(Ds, "DATA")

        Return Ds.Tables("DATA")
    End Function

    Private Sub LoadCheckPermision(IsUser As Boolean)


        'Dim dt As DataTable
        ''If IsUser = True Then
        ''    dt = getDTPermision_User(CboPremissionName.Text.Trim)
        ''Else
        ''    dt = getDTPermisionLoad(CboPremissionName.Text.Trim)
        ''End If


        ''  ปรับปรุงยอด
        'mnuDailyUpdate.Checked = GetCheckMenuBoolean(mnuDailyUpdate.Tag, dt)
        'mnuPermissionTimeAtt.Checked = GetCheckMenuBoolean(mnuPermissionTimeAtt.Tag, dt)
        'mnuManageTime.Checked = GetCheckMenuBoolean(mnuManageTime.Tag, dt)
        'mnuOvertime.Checked = GetCheckMenuBoolean(mnuOvertime.Tag, dt)
        'mnuLateTime.Checked = GetCheckMenuBoolean(mnuLateTime.Tag, dt)
        'mnuabsenceTime.Checked = GetCheckMenuBoolean(mnuabsenceTime.Tag, dt)
        'mnuInputLeaveData.Checked = GetCheckMenuBoolean(mnuInputLeaveData.Tag, dt)



        '' ตั้งค่า
        'mnuConfiguration.Checked = GetCheckMenuBoolean(mnuConfiguration.Tag, dt)
        'mnuMConfig.Checked = GetCheckMenuBoolean(mnuMConfig.Tag, dt)
        'mnuCompanyCenter.Checked = GetCheckMenuBoolean(mnuCompanyCenter.Tag, dt)
        'mnumodelcalculations.Checked = GetCheckMenuBoolean(mnumodelcalculations.Tag, dt)
        'mnuEmp.Checked = GetCheckMenuBoolean(mnuEmp.Tag, dt)
        'mnuDivision.Checked = GetCheckMenuBoolean(mnuDivision.Tag, dt)
        'mnuDepartment.Checked = GetCheckMenuBoolean(mnuDepartment.Tag, dt)
        'mnuMWorkTime.Checked = GetCheckMenuBoolean(mnuMWorkTime.Tag, dt)
        'mnuworkinggroup.Checked = GetCheckMenuBoolean(mnuworkinggroup.Tag, dt)
        'mnuSpacialKa.Checked = GetCheckMenuBoolean(mnuSpacialKa.Tag, dt)
        'mnuDeterminedTime.Checked = GetCheckMenuBoolean(mnuDeterminedTime.Tag, dt)
        'mnuDeterminedTimeEmp.Checked = GetCheckMenuBoolean(mnuDeterminedTimeEmp.Tag, dt)
        'mnuDeterminedTimeEmpByOne.Checked = GetCheckMenuBoolean(mnuDeterminedTimeEmpByOne.Tag, dt)
        'mnuDeterminedTimeEmpByDate.Checked = GetCheckMenuBoolean(mnuDeterminedTimeEmpByDate.Tag, dt)
        'mnuMOpenCalculate.Checked = GetCheckMenuBoolean(mnuMOpenCalculate.Tag, dt)
        'mnuProcessOT.Checked = GetCheckMenuBoolean(mnuProcessOT.Tag, dt)
        'mnucalculationLate.Checked = GetCheckMenuBoolean(mnucalculationLate.Tag, dt)
        'mnucalculationAbs.Checked = GetCheckMenuBoolean(mnucalculationAbs.Tag, dt)
        'mnuMVacationHolYear.Checked = GetCheckMenuBoolean(mnuMVacationHolYear.Tag, dt)
        'mnuSetLeave.Checked = GetCheckMenuBoolean(mnuSetLeave.Tag, dt)
        'mnuSetabsenceTimeByYear.Checked = GetCheckMenuBoolean(mnuSetabsenceTimeByYear.Tag, dt)
        'mnuSetholiday.Checked = GetCheckMenuBoolean(mnuSetholiday.Tag, dt)
        'MenuWorkHolidaySpacial.Checked = GetCheckMenuBoolean(MenuWorkHolidaySpacial.Tag, dt)
        'mnuMOtherCondition.Checked = GetCheckMenuBoolean(mnuMOtherCondition.Tag, dt)
        'mnuOT.Checked = GetCheckMenuBoolean(mnuOT.Tag, dt)
        'mnuOTBasic.Checked = GetCheckMenuBoolean(mnuOTBasic.Tag, dt)
        'mnusetOT.Checked = GetCheckMenuBoolean(mnusetOT.Tag, dt)
        'mnusetdelaytime1.Checked = GetCheckMenuBoolean(mnusetdelaytime1.Tag, dt)
        'mnusetdelayOT.Checked = GetCheckMenuBoolean(mnusetdelayOT.Tag, dt)
        'mnuSetCancelDelayOTByDay.Checked = GetCheckMenuBoolean(mnuSetCancelDelayOTByDay.Tag, dt)
        'mnuOTbyDay.Checked = GetCheckMenuBoolean(mnuOTbyDay.Tag, dt)
        'mnulimitOT.Checked = GetCheckMenuBoolean(mnulimitOT.Tag, dt)


        '' รายงาน
        'mnuReport.Checked = GetCheckMenuBoolean(mnuReport.Tag, dt)
        'mnurptTimeWork.Checked = GetCheckMenuBoolean(mnurptTimeWork.Tag, dt)
        'mnurptEmpWorkDetail1_M.Checked = GetCheckMenuBoolean(mnurptEmpWorkDetail1_M.Tag, dt)
        'mnurptAllemployeework2.Checked = GetCheckMenuBoolean(mnurptAllemployeework2.Tag, dt)
        'mnurptScheduleWorkAllEmp2.Checked = GetCheckMenuBoolean(mnurptScheduleWorkAllEmp2.Tag, dt)
        'mnurptemployeeByDate.Checked = GetCheckMenuBoolean(mnurptemployeeByDate.Tag, dt)
        'munOvertimeLeage.Checked = GetCheckMenuBoolean(munOvertimeLeage.Tag, dt)


        '' กำหนดสิทธิ์
        'mnuPermission.Checked = GetCheckMenuBoolean(mnuPermission.Tag, dt)
        'mnuUserPass.Checked = GetCheckMenuBoolean(mnuUserPass.Tag, dt)
        'mnuPerPattern.Checked = GetCheckMenuBoolean(mnuPerPattern.Tag, dt)
        'mnuPerUser.Checked = GetCheckMenuBoolean(mnuPerUser.Tag, dt)


    End Sub


    Function LoadCheckboxPermision_byOne(ByVal Empcode As String, menu_id As String) As Boolean
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""


        Strsql = "select Menu_Use " &
                 " from GenMenu_User " &
                 " where APP='" & App_Project.Trim & "'  " &
                        " And UserId ='" & Empcode & "'  " &
                        " And menu_id='" & menu_id & "' " &
                        " And menu_use=1 "

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


    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs)
        Dim MenuName As String = ""
        Dim MenuId As String = ""
        Dim ChkMenu As Boolean
        Dim nnd As New DevComponents.AdvTree.Node
        Dim i As Integer
        Dim J As Integer
        Dim EmpId As String = ""


        If AdvTree2.Text = Nothing Then
            '  MsgBox("ยังไม่มีข้อมูลให้บันทึก", MsgBoxStyle.Critical, "ไม่มีข้อมูล")
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "DataAddNull", MessageBoxIcon.Information)
            Exit Sub
        End If

        ' เช็คการเลือก TAb
        If TabControl1.SelectedTabIndex = 0 Then  ' เลือก Tab Pattern
            For J = 0 To lstEmp.Items.Count - 1
                If lstEmp.Items(J).Checked = True Then
                    EmpId = lstEmp.Items(J).SubItems(1).Text

                    ' ลบข้อมูลก่อน แล้วค่อยบันทึกเข้าไปใหม่ ===============================
                    '    Call DeleteMenu_User(EmpId) ' เมนูหลักปกติ
                    '   Call DeleteMenu_UserOnPage(EmpId) ' เมนูหน้าฟอร์ม ถ้าไม่มีก็ mark ออก

                    ' เริ่มต้นเมนูหลัก ===================
                    With AdvTree2
                        For i = 0 To .Nodes.Count - 1
                            MenuName = .Nodes(i).Cells(1).Text  ' ชื่อเมนู
                            MenuId = .Nodes(i).Cells(1).Tag  ' รหัสเมนู
                            ' เลือกหรือไม่
                            If .Nodes(i).Cells(0).Checked = True Then
                                ChkMenu = True  ' เลือก
                            Else
                                ChkMenu = False ' ไม่เลือก
                            End If


                            '' สำหรับเมนูหน้าฟอร์ม ที่ไม่เกี่ยวกับเมนูด้านบน ถ้าไม่มีก็ Mark ออกไปเลย ==============================
                            'If ChkMenuOnPage(MenuId.Trim) = True Then
                            '    UpdateStatusMenuOnPage(MenuId.Trim, ChkMenu, EmpId.Trim)
                            'End If

                            ' Insert Headmenu -----------------------------------------------------------------------
                            '         UpdateStatusMenu(MenuId.Trim, CboPremissionName.Text.Trim, ChkMenu, False, False, EmpId.Trim)

                            Call SubNodes(.Nodes(i), EmpId.Trim)
                        Next

                    End With

                End If

            Next

        Else

            If lblName.Text = "" Then
                ' MsgBox("ไม่พบรหัสพนักงานนี้ กรุณาตรวจสอบใหม่อีกครั้ง", MsgBoxStyle.Critical, "ไม่พบพนักงาน")
                MsgManager.ShowDialog(Me, "Messages", Me.Text, "EmpNull", MessageBoxIcon.Information)
                Exit Sub
            End If
            ' เลือก Tab เฉพาะรายบุคคล
            ' ลบข้อมูลก่อน แล้วค่อยบันทึกเข้าไปใหม่ ===============================
            '  Call DeleteMenu_User(lblEmpId.Text.Trim)
            Call DeleteMenu_UserOnPage(lblEmpId.Text.Trim) ' เมนูหน้าฟอร์ม ถ้าไม่มีก็ mark ออก

            ' เริ่มต้นเมนูหลัก ===================
            With AdvTree2
                For i = 0 To .Nodes.Count - 1
                    MenuId = .Nodes(i).Cells(1).Tag  ' Head

                    ' เลือกหรือไม่
                    If .Nodes(i).Checked = True Then
                        ChkMenu = True  ' เลือก
                    Else
                        ChkMenu = False ' ไม่เลือก
                    End If

                    ' สำหรับเมนูหน้าฟอร์ม ที่ไม่เกี่ยวกับเมนูด้านบน ถ้าไม่มีก็ Mark ออกไปเลย ==============================
                    If ChkMenuOnPage(MenuId.Trim) = True Then
                        UpdateStatusMenuOnPage(MenuId.Trim, ChkMenu, lblEmpId.Text.Trim)
                    End If

                    ' Insert Headmenu -----------------------------------------------------------------------
                    '     UpdateStatusMenu(MenuId.Trim, CboPremissionName.Text.Trim, ChkMenu, False, False, lblEmpId.Text.Trim)

                    Call SubNodes(.Nodes(i), lblEmpId.Text.Trim)
                Next
            End With
        End If


        ' MsgBox("กำหนดสิทธิ์การใช้เมนูเรียบร้อย", MsgBoxStyle.Information, "กำหนดสิทธิ์")
        MsgManager.ShowDialog(Me, "Messages", Me.Text, "Save_Complete", MessageBoxIcon.Information)
    End Sub

    Function ChkData_OnListCheck() As Boolean
        Dim i As Integer

        For i = 0 To lstEmp.Items.Count - 1
            If lstEmp.Items(i).Checked = False Then
                Return False
                ' Exit For
            ElseIf lstEmp.Items(i).Checked = True Then
                Return True
                Exit For
            End If

        Next
        Return False
    End Function

    Private Sub SubNodes(ByVal nd As DevComponents.AdvTree.Node, EmpId As String)
        Dim MenuId As String = ""
        Dim ChkMenu As String = ""
        Dim MenuApprove As String = ""
        Dim MenuReadOnly As String = ""
        Dim ndd As New DevComponents.AdvTree.Node
        Dim i As Integer = 0

        For i = 0 To nd.Nodes.Count - 1
            MenuId = nd.Nodes(i).Cells(0).Tag  ' Head

            ' เมนู
            If nd.Nodes(i).Cells(0).Checked = True Then
                ChkMenu = True  ' เลือก
            Else
                ChkMenu = False ' ไม่เลือก
            End If

            ' อนุมัติ
            If nd.Nodes(i).Cells(1).Checked = True Then
                MenuApprove = True  ' เลือก
            Else
                MenuApprove = False ' ไม่เลือก
            End If

            ' ReadOnly
            If nd.Nodes(i).Cells(2).Checked = True Then
                MenuReadOnly = True  ' เลือก
            Else
                MenuReadOnly = False ' ไม่เลือก
            End If

            ' Update Head
            '      UpdateStatusMenu(MenuId.Trim, CboPremissionName.Text.Trim, ChkMenu, MenuApprove, MenuReadOnly, EmpId.Trim)


            ' สำหรับเมนูหน้าฟอร์ม ที่ไม่เกี่ยวกับเมนูด้านบน ซึ่งถ้าไม่ เมนุหน้าฟอร์ม ก็ mark ทิ้งได้เลย =========================
            If ChkMenuOnPage(MenuId.Trim) = True Then
                UpdateStatusMenuOnPage(MenuId.Trim, ChkMenu, EmpId.Trim)
            End If
            '===========================================================================================


            Call SubNodes(nd.Nodes(i), EmpId.Trim)
        Next

    End Sub

    Private Sub UpdateStatusMenuOnPage(MenuId_P As String,
                          ChkUse As Boolean,
                          EmpId As String)

        Dim Dcmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String = ""
        Dim Data As New ArrayList
        Dim db As New db
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet


        Dim MenuId As String = ""
        Dim Menu_Name As String = ""
        Dim Menu_NameEng As String = ""
        Dim Menu_LinkFrom As String = ""

        strSQL = "Select * " &
                 " From GenMenu_MasterOnPage " &
                 " Where  APP='" & App_Project.Trim & "' And " &
                        " MenuId='" & MenuId_P.Trim & "'"
        Try
            Da = New SqlDataAdapter(strSQL, Conn)
            Da.Fill(Ds, "DATA")

            With Ds.Tables("DATA")
                If .Rows.Count = 0 Then

                Else

                    For Each dr As DataRow In .Rows
                        'ข้อมูลที่ต้องมีของ Master
                        MenuId = dr("MenuId")
                        Menu_Name = dr("MenuName")
                        Menu_LinkFrom = dr("MenuLink")
                    Next

                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        '  เอาข้อมูลที่ได้มา บันทึกลง เมนูของ User
        Data.Clear() : strType = ""
        Data.Add(EmpId.Trim) : strType &= "T"
        Data.Add(MenuId.Trim) : strType &= "T"
        Data.Add(Menu_Name.Trim) : strType &= "T"
        Data.Add(Menu_LinkFrom.Trim) : strType &= "T"
        Data.Add(ChkUse) : strType &= "B"
        Data.Add(App_Project.Trim) : strType &= "T"

        strSQL = "Insert into GenMenu_UserOnPage(EmpId,MenuId,MenuName,MenuLink,St_Menu,App) Values  " &
                        "(@P1,@P2,@P3,@P4,@P5,@P6)"


        ' Call OpenConnect(True)
        db.ExecuteCommand(Conn, Dcmd, strSQL, strType, Data)
        ' Call OpenConnect(False)
        '==========================================================================


    End Sub

    Private Sub UpdateStatusMenu(MenuId_P As String, UserName As String,
                             ChkUse As Boolean,
                             ChkApprove As Boolean,
                             ChkReadOnly As Boolean,
                             EmpId As String)

        Dim Dcmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String = ""
        Dim Data As New ArrayList
        Dim db As New db
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet


        Dim MenuId As String = ""
        Dim Menu_Name As String = ""
        Dim Menu_NameEng As String = ""
        Dim Menu_LinkFrom As String = ""

        strSQL = "Select Menu_Id,Menu_Name,Menu_NameEng,Menu_LinkFrom " &
                 " From GenCreateMenu_Master " &
                 " Where  APP='" & App_Project.Trim & "' And " &
                        " Menu_Id='" & MenuId_P.Trim & "'"
        Try
            Da = New SqlDataAdapter(strSQL, Conn)
            Da.Fill(Ds, "DATA")

            With Ds.Tables("DATA")
                If .Rows.Count = 0 Then

                Else

                    For Each dr As DataRow In .Rows
                        'ข้อมูลที่ต้องมีของ Master
                        MenuId = dr("Menu_Id")
                        Menu_Name = dr("Menu_Name")
                        Menu_NameEng = dr("Menu_NameEng")
                        Menu_LinkFrom = dr("Menu_LinkFrom")
                    Next

                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        '  เอาข้อมูลที่ได้มา บันทึกลง เมนูของ User
        Data.Clear() : strType = ""
        Data.Add(EmpId.Trim) : strType &= "T"
        Data.Add(MenuId.Trim) : strType &= "T"
        Data.Add(Menu_Name.Trim) : strType &= "T"
        Data.Add(Menu_NameEng.Trim) : strType &= "T"
        Data.Add(Menu_LinkFrom.Trim) : strType &= "T"
        Data.Add(ChkUse) : strType &= "B"
        Data.Add(ChkApprove) : strType &= "B"
        Data.Add(ChkReadOnly) : strType &= "B"
        Data.Add(UserId.Trim) : strType &= "T"
        Data.Add(App_Project.Trim) : strType &= "T"

        strSQL = "Insert into Genmenu_User(UserId,Menu_Id,Menu_Name,Menu_NameEng, " &
                        " Menu_LinkFrom,Menu_Use,Menu_ReadOnly,Menu_Approve,UserUpdate,APP) Values  " &
                        "(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10)"


        '  Call OpenConnect(True)
        db.ExecuteCommand(Conn, Dcmd, strSQL, strType, Data)
        '   Call OpenConnect(False)
        '==========================================================================


    End Sub

    'Private Sub DeleteMenu_User(UserId As String) Handles 
    '    Dim strSQL As String
    '    Dim strType As String
    '    Dim dCmd As New SqlCommand
    '    Dim data As New ArrayList
    '    Dim db As New db

    '    '   Call OpenConnect(True)
    '    Try
    '        data.Clear() : strType = ""
    '        data.Add(UserId.Trim) : strType &= "T"
    '        data.Add(App_Project.Trim) : strType &= "T"

    '        ' ลบข้อมูล 
    '        strSQL = "Delete From Genmenu_User " &
    '                " Where  UserId  = @P1 And APP=@P2"
    '        db.ExecuteCommand(Conn, dCmd, strSQL, strType, data)
    '        '  Call OpenConnect(False)

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Exit Sub
    '    End Try
    'End Sub

    Private Sub DeleteMenu_UserOnPage(UserId As String)
        Dim strSQL As String
        Dim strType As String
        Dim dCmd As New SqlCommand
        Dim data As New ArrayList
        Dim db As New db

        ' Call OpenConnect(True)
        Try
            data.Clear() : strType = ""
            data.Add(UserId.Trim) : strType &= "T"
            data.Add(App_Project.Trim) : strType &= "T"

            ' ลบข้อมูล 
            strSQL = "Delete From GenMenu_UserOnPage " &
                    " Where  EmpId  = @P1 And APP=@P2"
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, data)
            '   Call OpenConnect(False)

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub LoadMenu()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select Menu_Id,Menu_Name,No_Pic " &
                 " from GenCreateMenu_Master " &
                 " Where  App='" & App_Project.Trim & "' And " &
                            " St_MenuMain = 1 " &
                 " Order by runningno"

        Try
            Da = New SqlDataAdapter(Strsql, Conn)
            Da.Fill(Ds, "DATA")

            With Ds.Tables("DATA")
                If .Rows.Count = 0 Then
                    AdvTree2.Nodes.Clear()
                Else
                    'หาข้อมูลหลักก่อน
                    AdvTree2.Nodes.Clear()

                    ' PG.Maximum = .Rows.Count
                    '
                    'fMainMenuHD.PG2.Maximum = .Rows.Count
                    '  PG.Maximum = .Rows.Count
                    Dim i As Integer = 0
                    For Each Dr As DataRow In .Rows


                        Dim M_Id As String
                        Dim nd As New DevComponents.AdvTree.Node
                        Dim Cx1 As New DevComponents.AdvTree.Cell
                        Dim Cx2 As New DevComponents.AdvTree.Cell


                        ' กำหนดตำแหน่ง Icon อันนี้อยู่ตอนกำหนด Config ว่าจะให้เป็นรูปไหน อยู่ที่ตัวเลขที่กำหนด เฉพาะเมนูหลัก
                        ' กำหนดตำแหน่ง Icon อันนี้อยู่ตอนกำหนด Config ว่าจะให้เป็นรูปไหน อยู่ที่ตัวเลขที่กำหนด เฉพาะเมนูหลัก
                        If Dr("No_PiC") = 1 Then
                            nd.Image = Global.TimeAttendance.My.Resources.Resources.Design_Database_development
                        ElseIf Dr("No_PiC") = 2 Then
                            nd.Image = Global.TimeAttendance.My.Resources.Resources.Icojam_Blue_Bits_User_settings
                        ElseIf Dr("No_PiC") = 3 Then
                            nd.Image = Global.TimeAttendance.My.Resources.Resources.Matter_Books
                        ElseIf Dr("No_PiC") = 4 Then
                            nd.Image = Global.TimeAttendance.My.Resources.Resources.Rafiqul_Hassan_Blogger_Key
                        Else
                            nd.Image = Nothing
                        End If

                        M_Id = Dr("Menu_Id")

                        'Chkbox หน้าเมนูหลัก
                        nd.CheckBoxThreeState = False
                        nd.CheckBoxVisible = True

                        Cx1.Text = Dr("Menu_Id")

                        Cx2.Text = Dr("Menu_Name")
                        Cx2.Tag = Dr("Menu_Id")

                        AdvTree2.Nodes.Add(nd)
                        AdvTree2.Nodes(i).Cells.Add(Cx2)

                        Call LoadShowMenu(nd, Cx1.Text)
                        i += 1
                        ' PG.Value = i
                        ' mark ple 25/07/2019
                        'fMainMenuHD.PG2.Value = i
                    Next

                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub LoadShowMenu(ByVal nd As DevComponents.AdvTree.Node, ByVal MenuId As String)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand

        Strsql = "select * from GenMenu_Group " &
                 " where APP='" & App_Project.Trim & "' " &
                     " And  M_Id='" & MenuId.Trim & "'" &
                 " Order by M_Id,S_Id"



        Try
            'OpenConnect(True)
            Da = New SqlDataAdapter(Strsql, Conn)
            Da.Fill(Ds, "DATA")
            'OpenConnect(False)

            Dim I As Integer = 0
            With Ds.Tables("DATA")

                For Each Dr As DataRow In .Rows
                    Dim Time As String = ""
                    I += 1
                    ' หาชื่อเมนูย่อย
                    Dim S_Id As String
                    Dim MenuName As String
                    S_Id = Dr("S_Id")
                    MenuName = GetNameMenu(Dr("S_Id"))

                    Dim ndd As New DevComponents.AdvTree.Node
                    ' Chkbox หน้าเมนู ย่อย
                    ndd.CheckBoxThreeState = False
                    ndd.CheckBoxVisible = True


                    ndd.Text = MenuName
                    ndd.Tag = S_Id
                    ndd.VerticalCellLayoutAlignment = eHorizontalAlign.Center
                    nd.Nodes.Add(ndd)


                    Dim Cell_ As New DevComponents.AdvTree.Cell
                    ' เช็คการกำหนดผู้อนุมัติในเมนู ว่ามีหรือไม่---------------------------------------------------------
                    If ChkStatus_FormApprove(S_Id) = True Then
                        Cell_.CheckBoxThreeState = False
                        Cell_.CheckBoxVisible = True
                        Cell_.StyleMouseOver = Nothing
                        Cell_.Text = MsgManager.ShowLabel(Me, "Labels", "Approve") ' "สิทธิการอนุมัติ"
                    End If
                    ndd.Cells.Add(Cell_)



                    Dim Cell_1 As New DevComponents.AdvTree.Cell
                    '  เช็คว่ามีการกำหนดให้ฟอร์มนั้นกำหนด ReadOnly หรือไม่----------------------------------------------
                    If ChkStatus_ReadOnly(S_Id) = True Then
                        Cell_1.CheckBoxThreeState = False
                        Cell_1.CheckBoxVisible = True
                        Cell_1.StyleMouseOver = Nothing
                        Cell_1.Text = "ReadOnly"

                    End If
                    ndd.Cells.Add(Cell_1)


                    ' เช็คถ้าไม่มีเมนูย่อยก็ไม่ต้องทำ
                    If ChkMainGroupMenu(S_Id.Trim) = True Then
                        Call LoadShowMenu(ndd, S_Id)
                    End If

                Next

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

    End Sub

    Function ChkMainGroupMenu(M_Id As String) As Boolean
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select * from GenMenu_Group " &
                 " Where APP='" & App_Project.Trim & "' And " &
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

    Function ChkMenuOnPage(Menu_Id As String) As Boolean
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select * from GenMenu_MasterOnPage " &
                 " Where APP='" & App_Project.Trim & "' And " &
                        " MenuId='" & Menu_Id.Trim & "'"

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

    Private Sub lstEmp_DoubleClick(sender As Object, e As System.EventArgs) Handles lstEmp.DoubleClick
        TabControl1.SelectedTabIndex = 1
        With lstEmp
            Dim i As Integer

            For i = 0 To lstEmp.SelectedItems.Count - 1
                lblEmpId.Text = lstEmp.SelectedItems(i).SubItems(1).Text.Trim
                lblName.Text = GetEmpName(lblEmpId.Text.Trim)
            Next
        End With

        If lblName.Text = "" Then
            ' MsgBox("ไม่พบรหัสพนักงาน", MsgBoxStyle.Information, "ไม่พบ")
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "EmpNull", MessageBoxIcon.Information)
            Exit Sub
        End If

        ' ถ้าไม่มี Pattern
        ' PG.Visible = True
        ' mark ple 25/07/2019
        'fMainMenuHD.PG2.Visible = True
        If AdvTree2.Nodes.Count = 1 Then
            Call LoadMenu()
        End If
        Call GetData_Tree_OnUser()
        ' PG.Visible = False
        ' mark ple 25/07/2019
        'fMainMenuHD.PG2.Visible = False
    End Sub

#Region "Menu for Pattern"

    Private Sub GetData_Tree()
        Dim MenuId As String = ""
        For i As Integer = 0 To AdvTree2.Nodes.Count - 1
            '  MenuId = AdvTree2.Nodes(i).Cells(0).Tag
            MenuId = AdvTree2.Nodes(i).Cells(1).Tag

            'If ChkData(MenuId.Trim, CboPremissionName.Text.Trim) = True Then
            '    AdvTree2.Nodes(i).Checked = True
            '    '  AdvTree2.Nodes(i).Cells(1).Checked = True
            'Else
            '    AdvTree2.Nodes(i).Checked = False
            '    '  AdvTree2.Nodes(i).Cells(1).Checked = False
            'End If

            If AdvTree2.Nodes(i).Nodes.Count > 0 Then
                Call SubTree(AdvTree2.Nodes(i))
            End If
        Next

    End Sub

    Private Sub SubTree(nd As DevComponents.AdvTree.Node)
        Dim MenuId As String = ""

        '  fMainMenuHD.PG2.Value = 0
        PG.Value = 0
        For i As Integer = 0 To nd.Nodes.Count - 1
            ' PG.Maximum = nd.Nodes.Count - 1
            '' mark ple 25/07/2019
            'fMainMenuHD.PG2.Maximum = nd.Nodes.Count - 1
            MenuId = nd.Nodes(i).Tag

            'เช็คเมนู ว่าใช้หรือไม่ =================================================
            'If ChkData(MenuId.Trim, CboPremissionName.Text.Trim) = True Then
            '    '  nd.Nodes(i).Cells(1).Checked = True
            '    nd.Nodes(i).Checked = True
            'Else
            '    ' nd.Nodes(i).Cells(1).Checked = False
            '    nd.Nodes(i).Checked = False
            'End If
            '==================================================================


            ' เช็คว่ามี การกำหนด Nodes ย่อย หรือไม่  เช่น  Readonnly  อนุมัติ
            Dim J As Integer = 0
            Dim MenuSubName As String = ""

            If nd.Nodes(i).Cells(1).Text <> "" Then

                '' Approve
                'If ChkStatus_Approve(MenuId, CboPremissionName.Text.Trim) = True Then
                '    nd.Nodes(i).Cells(2).Checked = True
                'Else
                '    nd.Nodes(i).Cells(2).Checked = False
                'End If


                '' ReadOnly
                'If ChkStatus_ChkReadOnly(MenuId, CboPremissionName.Text.Trim) = True Then
                '    nd.Nodes(i).Cells(3).Checked = True
                'Else
                '    nd.Nodes(i).Cells(3).Checked = False
                'End If

                '    Next
            End If
            '===================================================

            If nd.Nodes(i).Nodes.Count > 0 Then
                Call SubTree(nd.Nodes(i))
            End If

            PG.Value += 1
            ' fMainMenuHD.PG2.Value = i
        Next
    End Sub

    Function ChkData(MenuId As String, PatternName As String) As Boolean
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select Menu_Id from GenMenu_Pattern " &
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

    Function ChkStatus_Approve(MenuId As String, PatternName As String) As Boolean
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select Menu_Id from GenMenu_Pattern " &
                 " Where APP='" & App_Project.Trim & "' And " &
                        " Menu_Id='" & MenuId.Trim & "'And " &
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

    Function ChkStatus_ChkReadOnly(MenuId As String, PatternName As String) As Boolean
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select Menu_Id from GenMenu_Pattern " &
                 " Where APP='" & App_Project.Trim & "' And " &
                        " Menu_Id='" & MenuId.Trim & "'And " &
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
#End Region

#Region "Menu For User"

    Private Sub GetData_Tree_OnUser()
        Dim MenuId As String = ""
        For i As Integer = 0 To AdvTree2.Nodes.Count - 1
            MenuId = AdvTree2.Nodes(i).Cells(1).Tag

            If ChkData_OnUser(MenuId.Trim, lblEmpId.Text.Trim) = True Then
                AdvTree2.Nodes(i).Checked = True
                ' AdvTree2.Nodes(i).Cells(1).Checked = True
            Else
                AdvTree2.Nodes(i).Checked = False
                ' AdvTree2.Nodes(i).Cells(2).Checked = False
            End If



            If AdvTree2.Nodes(i).Nodes.Count > 0 Then
                Call SubTree_OnUser(AdvTree2.Nodes(i))
            End If
        Next
    End Sub

    Private Sub SubTree_OnUser(nd As DevComponents.AdvTree.Node)
        Dim MenuId As String = ""
        For i As Integer = 0 To nd.Nodes.Count - 1
            MenuId = nd.Nodes(i).Tag

            'เช็คเมนู ว่าใช้หรือไม่ =================================================
            If ChkData_OnUser(MenuId.Trim, lblEmpId.Text.Trim) = True Then
                nd.Nodes(i).Checked = True
                ' nd.Nodes(i).Cells(1).Checked = True
            Else
                nd.Nodes(i).Checked = False
                'nd.Nodes(i).Cells(1).Checked = False
            End If
            '==================================================================


            ' เช็คว่ามี การกำหนด Nodes ย่อย หรือไม่  เช่น  Readonnly  อนุมัติ
            Dim J As Integer = 0
            Dim MenuSubName As String = ""

            If nd.Nodes(i).Cells(1).Text <> "" Then
                '  For J = 1 To nd.Nodes(i).Cells.Count - 1
                'MenuSubName = nd.Nodes(i).Cells(J).Text

                ' Approve
                If ChkStatus_Approve_User(MenuId, lblEmpId.Text.Trim) = True Then
                    nd.Nodes(i).Cells(1).Checked = True
                Else
                    nd.Nodes(i).Cells(1).Checked = False
                End If


                ' ReadOnly
                If ChkStatus_ChkReadOnly_User(MenuId, lblEmpId.Text.Trim) = True Then
                    nd.Nodes(i).Cells(2).Checked = True
                Else
                    nd.Nodes(i).Cells(2).Checked = False
                End If

                '  Next
            End If
            '===================================================


            If nd.Nodes(i).Nodes.Count > 0 Then
                Call SubTree_OnUser(nd.Nodes(i))
            End If

        Next
    End Sub

    Function ChkData_OnUser(MenuId As String, UserId As String) As Boolean
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select Menu_Id from GenMenu_User " &
                 " Where APP='" & App_Project.Trim & "' And " &
                        " Menu_Id='" & MenuId.Trim & "' And  " &
                        " Menu_Use=1 And " &
                        " UserId='" & UserId.Trim & "'"

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

    Function ChkStatus_Approve_User(MenuId As String, UserId As String) As Boolean
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select Menu_Id from GenMenu_User " &
                 " Where  APP='" & App_Project.Trim & "' And " &
                        " Menu_Id='" & MenuId.Trim & "'And " &
                        " Menu_Approve=1 And " &
                        " UserId='" & UserId.Trim & "'"

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

    Function ChkStatus_ChkReadOnly_User(MenuId As String, UserId As String) As Boolean
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select Menu_Id from GenMenu_User " &
                 " Where APP='" & App_Project.Trim & "' And " &
                        " Menu_Id='" & MenuId.Trim & "'And " &
                        " Menu_ReadOnly=1 And " &
                        " UserId='" & UserId.Trim & "'"

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
#End Region

    Private Sub lstEmp_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles lstEmp.DragDrop

    End Sub


    Private Sub lstEmp_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstEmp.SelectedIndexChanged

    End Sub

    Private Sub btnPlusAll_Click(sender As System.Object, e As System.EventArgs) Handles btnPlusAll.Click
        AdvTree2.CollapseAll()

    End Sub

    Private Sub BtnExpland_Click(sender As System.Object, e As System.EventArgs) Handles BtnExpland.Click
        AdvTree2.ExpandAll()
    End Sub

    '  Private Sub LoadEmpName(EmpId As String)
    Private Sub aaa()

    End Sub

    Private Sub lblEmpId_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub lblEmpId_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles lblEmpId.KeyDown

    End Sub

    Private Sub lblEmpId_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles lblEmpId.KeyPress
        If Asc(e.KeyChar) = 13 Then
            lblName.Text = GetEmpName(lblEmpId.Text.Trim)

            If lblName.Text = "" Then
                ' MsgBox("ไม่พบรหัสพนักงาน", MsgBoxStyle.Information, "ไม่พบ")
                MsgManager.ShowDialog(Me, "Messages", Me.Text, "EmpNull", MessageBoxIcon.Information)
                Exit Sub
            End If


            If AdvTree2.Nodes.Count = 1 Then
                Call LoadMenu()
            End If
            ' Call LoadMenu()
            Call GetData_Tree_OnUser()
        End If
    End Sub


    Private Sub lblEmpId_TextChanged(sender As System.Object, e As System.EventArgs) Handles lblEmpId.TextChanged

    End Sub

    Private Sub TabControl1_Click(sender As System.Object, e As System.EventArgs) Handles TabControl1.Click

    End Sub

    Private Sub TabControl1_SelectedTabChanged(sender As Object, e As DevComponents.DotNetBar.TabStripTabChangedEventArgs) Handles TabControl1.SelectedTabChanged
        If TabControl1.SelectedTabIndex = 0 Then
            lblEmpId.Text = ""
            lblName.Text = ""
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs)
        Dim Dcmd As New SqlCommand
        Dim strSQL As String = ""
        Dim strType As String = ""
        Dim Data As New ArrayList
        Dim db As New db
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet


        Data.Clear() : strType = ""
        Data.Add(lblEmpId.Text.Trim) : strType &= "T"
        Data.Add(App_Project.Trim) : strType &= "T"

        strSQL = "Delete from  Genmenu_User where UserId=@P1 And APP=@P2 "
        '  Call OpenConnect(True)
        db.ExecuteCommand(Conn, Dcmd, strSQL, strType, Data)
        '  Call OpenConnect(False)




        Data.Clear() : strType = ""
        Data.Add(lblEmpId.Text.Trim) : strType &= "T"
        Data.Add(App_Project.Trim) : strType &= "T"

        strSQL = "Delete from  GenMenu_UserOnPage where EmpId=@P1 And APP=@P2 "
        '  Call OpenConnect(True)
        db.ExecuteCommand(Conn, Dcmd, strSQL, strType, Data)
        '  Call OpenConnect(False)
    End Sub

    Private Sub LabelX1_Click(sender As System.Object, e As System.EventArgs)

    End Sub



    Private Sub BtnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer = 0
        For i = 0 To lstEmp.Items.Count - 1
            If lstEmp.Items.Count > 0 Then
                lstEmp.Items(i).Checked = True
            End If
        Next
    End Sub

    Private Sub btnNotSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer = 0
        For i = 0 To lstEmp.Items.Count - 1
            If lstEmp.Items.Count > 0 Then
                lstEmp.Items(i).Checked = False
            End If
        Next
    End Sub

    Private Sub PG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PG.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim dCmd As New SqlCommand
        '  Dim strSQL As String
        Dim Tn As SqlTransaction


        If cboPerGroupName.Text = "" Then
            '  MsgBox("กรุณาเลือกกลุ่มสิทธิ์", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "กลุ่มสิทธิ์")
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblPerGroupName.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            cboPerGroupName.Focus()
            Exit Sub
        End If

        ProgressBarX1.Visible = True
        btnAdd.Enabled = False
        btnRemove.Enabled = False

        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try


            ProgressBarX1.Value = 0
            ProgressBarX1.Maximum = GvEmp.GetSelectedRows.Count - 1

            For Each i As Long In GvEmp.GetSelectedRows

                Dim dr As DataRow = GvEmp.GetDataRow(i)
                ProgressBarX1.Value = i + 1
                '     ProgressBarX1.Text = Format((i * 100) / ProgressBarX1.Maximum, "#0.00") & "%"
                ProgressBarX1.Text = i & "/" & ProgressBarX1.Maximum
                Application.DoEvents()


                ' บันทึกเมนูผุ้ใช้ ตาม สิทธิื์ที่เลือก วิ่งวนไปทีละคนตามที่เลือก
                Call InsertGroupMenu(dCmd, dr("UserID").ToString, cboPerGroupName.EditValue)

            Next
            Tn.Commit()
        Catch ex As Exception
            btnAdd.Enabled = True
            btnRemove.Enabled = True
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try

        '  MsgManager.ShowDialog(Me, "Messages", Me.Text, "Save_Complete", MessageBoxIcon.Information)

        '  MsgBox("บันทึกเข้ากลุ่มสิทธิ์เรียบร้อย", MsgBoxStyle.Information, Me.Text)

        MsgBox(My.Resources.res_warning_message.save_complete, MsgBoxStyle.Information, Me.Text)
        Call LoadEmp() ' แสดงข้อุล ทีียังไม่ได้กำหนดสิทธิื
        Call LoadEmp_permisionUse(cboPerGroupName.EditValue)  ' แสดงข้อมูลที่กำหนดด้านขวา

        XtraTabControl1.SelectedTabPageIndex = 0
        'txtCodeEdit.Text = ""
        'txtNameedit.Text = ""

        btnAdd.Enabled = True
        btnRemove.Enabled = True
        ProgressBarX1.Value = False
        ProgressBarX1.Value = 0

        ProgressBarX1.Visible = False
    End Sub

    Private Sub SaveMenu(dcmd As SqlCommand, empcode As String)
        ''  ปรับปรุงยอด
        'Call InsertMenu(dcmd, empcode, mnuDailyUpdate.Tag, mnuDailyUpdate.Text.Trim, mnuDailyUpdate.Name, IIf(mnuDailyUpdate.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuPermissionTimeAtt.Tag, mnuPermissionTimeAtt.Text.Trim, mnuPermissionTimeAtt.Name, IIf(mnuPermissionTimeAtt.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuManageTime.Tag, mnuManageTime.Text.Trim, mnuManageTime.Name, IIf(mnuManageTime.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuOvertime.Tag, mnuOvertime.Text.Trim, mnuOvertime.Name, IIf(mnuOvertime.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuLateTime.Tag, mnuLateTime.Text.Trim, mnuLateTime.Name, IIf(mnuLateTime.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuabsenceTime.Tag, mnuabsenceTime.Text.Trim, mnuabsenceTime.Name, IIf(mnuabsenceTime.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuInputLeaveData.Tag, mnuInputLeaveData.Text.Trim, mnuInputLeaveData.Name, IIf(mnuInputLeaveData.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)


        '' ตั้งค่า
        'Call InsertMenu(dcmd, empcode, mnuConfiguration.Tag, mnuConfiguration.Text.Trim, mnuConfiguration.Name, IIf(mnuConfiguration.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuMConfig.Tag, mnuMConfig.Text.Trim, mnuMConfig.Name, IIf(mnuMConfig.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuCompanyCenter.Tag, mnuCompanyCenter.Text.Trim, mnuCompanyCenter.Name, IIf(mnuCompanyCenter.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnumodelcalculations.Tag, mnumodelcalculations.Text.Trim, mnumodelcalculations.Name, IIf(mnumodelcalculations.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuEmp.Tag, mnuEmp.Text.Trim, mnuEmp.Name, IIf(mnuEmp.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuDivision.Tag, mnuDivision.Text.Trim, mnuDivision.Name, IIf(mnuDivision.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuDepartment.Tag, mnuDepartment.Text.Trim, mnuDepartment.Name, IIf(mnuDepartment.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuMWorkTime.Tag, mnuMWorkTime.Text.Trim, mnuMWorkTime.Name, IIf(mnuMWorkTime.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuworkinggroup.Tag, mnuworkinggroup.Text.Trim, mnuworkinggroup.Name, IIf(mnuworkinggroup.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuSpacialKa.Tag, mnuSpacialKa.Text.Trim, mnuSpacialKa.Name, IIf(mnuSpacialKa.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuDeterminedTime.Tag, mnuDeterminedTime.Text.Trim, mnuDeterminedTime.Name, IIf(mnuDeterminedTime.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuDeterminedTimeEmp.Tag, mnuDeterminedTimeEmp.Text.Trim, mnuDeterminedTimeEmp.Name, IIf(mnuDeterminedTimeEmp.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuDeterminedTimeEmpByOne.Tag, mnuDeterminedTimeEmpByOne.Text.Trim, mnuDeterminedTimeEmpByOne.Name, IIf(mnuDeterminedTimeEmpByOne.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuDeterminedTimeEmpByDate.Tag, mnuDeterminedTimeEmpByDate.Text.Trim, mnuDeterminedTimeEmpByDate.Name, IIf(mnuDeterminedTimeEmpByDate.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuMOpenCalculate.Tag, mnuMOpenCalculate.Text.Trim, mnuMOpenCalculate.Name, IIf(mnuMOpenCalculate.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuProcessOT.Tag, mnuProcessOT.Text.Trim, mnuProcessOT.Name, IIf(mnuProcessOT.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnucalculationLate.Tag, mnucalculationLate.Text.Trim, mnucalculationLate.Name, IIf(mnucalculationLate.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnucalculationAbs.Tag, mnucalculationAbs.Text.Trim, mnucalculationAbs.Name, IIf(mnucalculationAbs.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuMVacationHolYear.Tag, mnuMVacationHolYear.Text.Trim, mnuMVacationHolYear.Name, IIf(mnuMVacationHolYear.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuSetLeave.Tag, mnuSetLeave.Text.Trim, mnuSetLeave.Name, IIf(mnuSetLeave.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuSetabsenceTimeByYear.Tag, mnuSetabsenceTimeByYear.Text.Trim, mnuSetabsenceTimeByYear.Name, IIf(mnuSetabsenceTimeByYear.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuSetholiday.Tag, mnuSetholiday.Text.Trim, mnuSetholiday.Name, IIf(mnuSetholiday.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, MenuWorkHolidaySpacial.Tag, MenuWorkHolidaySpacial.Text.Trim, MenuWorkHolidaySpacial.Name, IIf(MenuWorkHolidaySpacial.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuMOtherCondition.Tag, mnuMOtherCondition.Text.Trim, mnuMOtherCondition.Name, IIf(mnuMOtherCondition.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuOT.Tag, mnuOT.Text.Trim, mnuOT.Name, IIf(mnuOT.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuOTBasic.Tag, mnuOTBasic.Text.Trim, mnuOTBasic.Name, IIf(mnuOTBasic.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnusetOT.Tag, mnusetOT.Text.Trim, mnusetOT.Name, IIf(mnusetOT.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnusetdelaytime1.Tag, mnusetdelaytime1.Text.Trim, mnusetdelaytime1.Name, IIf(mnusetdelaytime1.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnusetdelayOT.Tag, mnusetdelayOT.Text.Trim, mnusetdelayOT.Name, IIf(mnusetdelayOT.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuSetCancelDelayOTByDay.Tag, mnuSetCancelDelayOTByDay.Text.Trim, mnuSetCancelDelayOTByDay.Name, IIf(mnuSetCancelDelayOTByDay.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuOTbyDay.Tag, mnuOTbyDay.Text.Trim, mnuOTbyDay.Name, IIf(mnuOTbyDay.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnulimitOT.Tag, mnulimitOT.Text.Trim, mnulimitOT.Name, IIf(mnulimitOT.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)


        '' รายงาน
        'Call InsertMenu(dcmd, empcode, mnuReport.Tag, mnuReport.Text.Trim, mnuReport.Name, IIf(mnuReport.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnurptTimeWork.Tag, mnurptTimeWork.Text.Trim, mnurptTimeWork.Name, IIf(mnurptTimeWork.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnurptEmpWorkDetail1_M.Tag, mnurptEmpWorkDetail1_M.Text.Trim, mnurptEmpWorkDetail1_M.Name, IIf(mnurptEmpWorkDetail1_M.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnurptAllemployeework2.Tag, mnurptAllemployeework2.Text.Trim, mnurptAllemployeework2.Name, IIf(mnurptAllemployeework2.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnurptScheduleWorkAllEmp2.Tag, mnurptScheduleWorkAllEmp2.Text.Trim, mnurptScheduleWorkAllEmp2.Name, IIf(mnurptScheduleWorkAllEmp2.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnurptemployeeByDate.Tag, mnurptemployeeByDate.Text.Trim, mnurptemployeeByDate.Name, IIf(mnurptemployeeByDate.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, munOvertimeLeage.Tag, munOvertimeLeage.Text.Trim, munOvertimeLeage.Name, IIf(munOvertimeLeage.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)


        '' กำหนดสิทธิ์
        'Call InsertMenu(dcmd, empcode, mnuPermission.Tag, mnuPermission.Text.Trim, mnuPermission.Name, IIf(mnuPermission.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuUserPass.Tag, mnuUserPass.Text.Trim, mnuUserPass.Name, IIf(mnuUserPass.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuPerPattern.Tag, mnuPerPattern.Text.Trim, mnuPerPattern.Name, IIf(mnuPerPattern.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)
        'Call InsertMenu(dcmd, empcode, mnuPerUser.Tag, mnuPerUser.Text.Trim, mnuPerUser.Name, IIf(mnuPerUser.Checked, 1, 0), 0, 0, CboPremissionName.Text.Trim)



    End Sub

    Private Sub InsertMenu(ByVal dcmd As SqlCommand, ByVal EmpCode As String, ByVal Menu_Id As String,
                                 ByVal Menu_name_text As String,
                                 ByVal Menu_name As String,
                                 ByVal ChkUse As Boolean,
                                 ByVal ChkApprove As Boolean,
                                 ByVal ChkReadOnly As Boolean, GroupPerName As String)


        '  Dim Dcmd As New SqlCommand
        'Dim strSQL As String
        'Dim strType As String = ""
        'Dim Data As New ArrayList
        'Dim db As New db
        'Try

        '    Data.Clear() : strType = ""
        '    Data.Add(EmpCode.Trim) : strType &= "T"
        '    Data.Add(Menu_Id.Trim) : strType &= "T"
        '    Data.Add(Menu_name_text.Trim) : strType &= "T"
        '    Data.Add(Menu_name.Trim) : strType &= "T"
        '    Data.Add(ChkUse) : strType &= "B"
        '    Data.Add(ChkReadOnly) : strType &= "B"
        '    Data.Add(ChkApprove) : strType &= "B"
        '    Data.Add(App_Project.Trim) : strType &= "T"
        '    Data.Add(UserId.Trim) : strType &= "T"
        '    Data.Add(CboPremissionName.Text.Trim) : strType &= "T"
        '    strSQL = "Insert Into Genmenu_User (userid,menu_id,menu_name,menu_nameeng,menu_linkfrom,menu_use,Menu_readonly,menu_approve,app,lastupdate,userupdate,GroupPerName) values " &
        '              " (@P1,@P2,@P3,@P4,@P4,@P5,@P6,@P7,@P8,getdate(),@P9,@P10)"

        '    '  Call OpenConnect(True)
        '    db.ExecuteCommand(Conn, dcmd, strSQL, strType, Data)
        '    '   Call OpenConnect(False)

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub InsertGroupMenu(ByVal dcmd As SqlCommand, ByVal EmpCode As String, ByVal GrpId As Integer)

        Dim strSQL As String
        Dim strType As String = ""
        Dim Data As New ArrayList
        Dim db As New db
        Try

            ' ลบออกก่อน
            Data.Clear() : strType = ""
            Data.Add(EmpCode.Trim) : strType &= "T"
            strSQL = "Delete GenMenu_GroupUser where UserId=@P1 "
            db.ExecuteCommand(Conn, dcmd, strSQL, strType, Data)


            ' บันทึกเข้าไปใหม่
            Data.Clear() : strType = ""
            Data.Add(EmpCode.Trim) : strType &= "T"
            Data.Add(GrpId) : strType &= "I"

            strSQL = "Insert Into GenMenu_GroupUser (Userid,GrpId) values " &
                      " (@P1,@P2)"
            db.ExecuteCommand(Conn, dcmd, strSQL, strType, Data)


            ' Update ลง ตาราง USER 
            Data.Clear() : strType = ""
            Data.Add(EmpCode.Trim) : strType &= "T"
            Data.Add(GrpId) : strType &= "I"
            strSQL = "Update [User] set GrpId=@P2 where UserId=@P1 "
            db.ExecuteCommand(Conn, dcmd, strSQL, strType, Data)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
            Exit Sub
        End Try
    End Sub

    Private Sub DelMenu_byEmp(ByVal dcmd As SqlCommand, ByVal EmpCode As String, GrpId As Integer)


        '  Dim Dcmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String = ""
        Dim Data As New ArrayList
        Dim db As New db
        Try

            'Data.Clear() : strType = ""
            'Data.Add(EmpCode.Trim) : strType &= "T"
            'Data.Add(App_Project.Trim) : strType &= "T"
            'strSQL = "Delete GenMenu_User where app=@P2 And  userid=@P1"

            Data.Clear() : strType = ""
            Data.Add(EmpCode.Trim) : strType &= "T"
            strSQL = "Delete GenMenu_GroupUser where UserId=@P1 "


            ' Update ลง ตาราง USER 
            Data.Clear() : strType = ""
            Data.Add(EmpCode.Trim) : strType &= "T"
            Data.Add(0) : strType &= "I"
            strSQL = "Update [User] set GrpId=@P2 where UserId=@P1 "
            db.ExecuteCommand(Conn, dcmd, strSQL, strType, Data)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
            Exit Sub
        End Try
    End Sub

    'Private Sub LoadcofigEmpPermision()
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim strSQL As String

    '    strSQL = "Select  row_number() over(ORDER BY U.Userid) As row, " &
    '            " Code=u.UserId, " &
    '            " Fname = Isnull(e.Fname,''), " &
    '            " Lname = Isnull(e.Lname,''), " &
    '            " Divisoin = Isnull(d.Division,''), " &
    '            " Department = Isnull(de.Department,''), " &
    '            " Position = Isnull(e.Position,''),  " &
    '            " username=[User].Username " &
    '    " From genmenu_user  u  " &
    '            " Left join [User] " &
    '                    " On u.userid=[User].userid " &
    '            " Inner join  genmenu_pattern p " &
    '                     " On u.Menu_Id= p.Menu_Id " &
    '            " Left Join emp e " &
    '                    " On e.Code=u.UserId " &
    '            " Left Join Division d " &
    '                    " On e.DivId=d.DivId " &
    '            " Left Join Department de " &
    '                    " On e.DeptId=de.DeptId " &
    '    " Where u.app='" & App_Project & "'  " &
    '            " And u.GroupPerName='" & CboPremissionName.Text.Trim & "'" &
    '    " Group by u.UserId,Isnull(e.Fname,''),Isnull(e.Lname,''), " &
    '            " Isnull(d.Division,''),Isnull(de.Department,''),Isnull(e.Position,''),[User].Username" &
    '    " order by U.Userid"




    '    Da = New SqlDataAdapter(strSQL, Conn)
    '    Da.Fill(Ds, "Data")

    '    Gcmenu_use.DataSource = Ds
    '    Gcmenu_use.DataMember = "Data"

    'End Sub

    Private Sub chkmnuDailyUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles mnuDailyUpdate.CheckedChanged
        If mnuDailyUpdate.Checked = True Then
            mnuPermissionTimeAtt.Checked = True
            mnuManageTime.Checked = True
            mnuOvertime.Checked = True
            mnuLateTime.Checked = True
            mnuabsenceTime.Checked = True
            mnuInputLeaveData.Checked = True
        Else

            mnuPermissionTimeAtt.Checked = False
            mnuManageTime.Checked = False
            mnuOvertime.Checked = False
            mnuLateTime.Checked = False
            mnuabsenceTime.Checked = False
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

    Private Sub chkmnuConfiguration_CheckedChanged(sender As Object, e As EventArgs) Handles mnuMConfig.CheckedChanged
        If mnuMConfig.Checked = True Then
            mnuCompanyCenter.Checked = True
            mnumodelcalculations.Checked = True
        Else
            mnuCompanyCenter.Checked = False
            mnumodelcalculations.Checked = False
        End If
    End Sub

    Private Sub chkmnuMainConfiguration_CheckedChanged(sender As Object, e As EventArgs) Handles mnuConfiguration.CheckedChanged
        If mnuConfiguration.Checked = True Then
            mnuMConfig.Checked = True
            mnuCompanyCenter.Checked = True
            mnumodelcalculations.Checked = True
            mnuMWorkTime.Checked = True
            mnuworkinggroup.Checked = True
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
            mnuOTBasic.Checked = True
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
            mnuworkinggroup.Checked = False
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
            mnuOTBasic.Checked = False
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
            mnuworkinggroup.Checked = True
            mnuSpacialKa.Checked = True
            mnuDeterminedTime.Checked = True
            mnuDeterminedTimeEmp.Checked = True
            mnuDeterminedTimeEmpByOne.Checked = True
            mnuDeterminedTimeEmpByDate.Checked = True
        Else
            mnuworkinggroup.Checked = False
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
            mnuOTBasic.Checked = True
            mnusetOT.Checked = True
            mnusetdelaytime1.Checked = True
            mnusetdelayOT.Checked = True
            mnuSetCancelDelayOTByDay.Checked = True
            mnuOTbyDay.Checked = True
            mnulimitOT.Checked = True
        Else
            mnuOT.Checked = False
            mnuOTBasic.Checked = False
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
            mnuOTBasic.Checked = True
            mnusetOT.Checked = True
            mnusetdelaytime1.Checked = True
            mnusetdelayOT.Checked = True
            mnuSetCancelDelayOTByDay.Checked = True
            mnuOTbyDay.Checked = True
        Else
            mnuOTBasic.Checked = False
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


    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim dCmd As New SqlCommand
        '  Dim strSQL As String
        Dim Tn As SqlTransaction

        'If CSng(txtLimitHourOT.Text) < 1 Then
        '    'MsgBox("กรุณากำหนดจำนวนชั่วโมง OT ด้วย", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "กำหนดชั่วโมง")
        '    MsgManager.ShowDialog(Me, "frmLimitHourOTRS", Me.Text, "Config_OT", MessageBoxIcon.Information)
        '    txtLimitHourOT.Focus()
        '    Exit Sub
        'End If

        'If CboPremissionName.Text = "" Then
        '    MsgBox("กรุณาเลือกกลุ่มสิทธิ์", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "กลุ่มสิทธิ์")
        '    CboPremissionName.Focus()
        '    Exit Sub
        'End If

        ProgressBarX1.Visible = True
        btnAdd.Enabled = False
        btnRemove.Enabled = False

        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try


            ProgressBarX1.Value = 0
            ProgressBarX1.Maximum = Gvmenu_use.GetSelectedRows.Count - 1

            For Each i As Long In Gvmenu_use.GetSelectedRows

                Dim dr As DataRow = Gvmenu_use.GetDataRow(i)
                ProgressBarX1.Value = i + 1
                '     ProgressBarX1.Text = Format((i * 100) / ProgressBarX1.Maximum, "#0.00") & "%"
                ProgressBarX1.Text = i & "/" & ProgressBarX1.Maximum
                Application.DoEvents()


                ' ลบข้อมุลที่อยู่ออกก่อน เผื่อกรณีที่เลือกกลุ่มสิทธิใหม่  ซึง่จะได้ไม่ซ้ำ
                Call DelMenu_byEmp(dCmd, dr("Code").ToString, cboPerGroupName.EditValue)

            Next
            Tn.Commit()
        Catch ex As Exception
            btnAdd.Enabled = True
            btnRemove.Enabled = True
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try

        '   MsgManager.ShowDialog(Me, "Messages", Me.Text, "Save_Complete", MessageBoxIcon.Information)
        ' MsgBox("นำออกจากกลุ่มสิทธิ์เรียบร้อย", MsgBoxStyle.Information, Me.Text)

        MsgBox(My.Resources.res_warning_message_spacial.permission_exportdata, MsgBoxStyle.Information, Me.Text)

        Call LoadEmp() ' แสดงข้อุล ทีียังไม่ได้กำหนดสิทธิื
        Call LoadEmp_permisionUse(cboPerGroupName.EditValue)

        grpEditMenubyOne.Enabled = False
        txtCodeEdit.Text = ""
        txtNameedit.Text = ""

        btnAdd.Enabled = True
        btnRemove.Enabled = True
        ProgressBarX1.Value = False
        ProgressBarX1.Value = 0

        ProgressBarX1.Visible = False
    End Sub

    Private Sub Gcmenu_use_Click(sender As Object, e As EventArgs) Handles Gcmenu_use.Click

    End Sub

    Private Sub btnEditMenu_byOne_Click(sender As Object, e As EventArgs) Handles btnEditMenu_byOne.Click
        Dim dcmd As New SqlCommand
        ' ลบข้อมุลที่อยู่ออกก่อน เผื่อกรณีที่เลือกกลุ่มสิทธิใหม่  ซึง่จะได้ไม่ซ้ำ
        '  Call DelMenu_byEmp(dcmd, txtCodeEdit.Text.Trim)

        ' บันทึกเมนูผุ้ใช้ ตาม สิทธิื์ที่เลือก วิ่งวนไปทีละคนตามที่เลือก
        Call SaveMenu(dcmd, txtCodeEdit.Text.Trim)

        MsgBox("แก้ไขกำหนดสิทธิ์เรียบร้อย", MsgBoxStyle.Information, "สำเร็ว")
        ''
        XtraTabControl1.SelectedTabPageIndex = 0
        grpEditMenubyOne.Enabled = False
        txtCodeEdit.Text = ""
        txtNameedit.Text = ""

    End Sub

    Private Sub GcEmp_Click(sender As Object, e As EventArgs) Handles GcEmp.Click

    End Sub

    Private Sub Gvmenu_use_DoubleClick(sender As Object, e As EventArgs) Handles Gvmenu_use.DoubleClick
        Try
            Dim gv As GridView = CType(sender, GridView)

            '   If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "Code")) = True Then Exit Sub

            txtCodeEdit.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Code")
            txtNameedit.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Fname") & "  " & gv.GetRowCellValue(gv.FocusedRowHandle, "Lname")
            XtraTabControl1.SelectedTabPageIndex = 1
            tabMenu.SelectedTabPageIndex = 0
            grpEditMenubyOne.Enabled = True
            Call LoadCheckPermision(True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub XtraScrollableControl1_Click(sender As Object, e As EventArgs) Handles XtraScrollableControl1.Click

    End Sub

    Private Sub GvEmp_DoubleClick(sender As Object, e As EventArgs) Handles GvEmp.DoubleClick
        Try
            Dim gv As GridView = CType(sender, GridView)

            '   If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "Code")) = True Then Exit Sub

            txtCodeEdit.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Code")
            txtNameedit.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Fname") & "  " & gv.GetRowCellValue(gv.FocusedRowHandle, "Lname")
            XtraTabControl1.SelectedTabPageIndex = 1
            tabMenu.SelectedTabPageIndex = 0
            grpEditMenubyOne.Enabled = True
            Call LoadCheckPermision(True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmSetUserLogIn_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        SplitContainerControl1.SplitterPosition = pnlApp.Width / 2
    End Sub

    Private Sub SplitContainerControl1_SplitterPositionChanged(sender As Object, e As EventArgs) Handles SplitContainerControl1.SplitterPositionChanged
        grpLeft.Width = SplitContainerControl1.Panel1.Width - grpLeft.Left - 2
        grpRight.Width = SplitContainerControl1.Panel2.Width - grpRight.Left - 2
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub cboPerGroupName_EditValueChanged(sender As Object, e As EventArgs) Handles cboPerGroupName.EditValueChanged
        Call LoadEmp_permisionUse(cboPerGroupName.EditValue)
    End Sub
End Class