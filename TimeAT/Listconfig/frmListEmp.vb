
Imports System.Data
Imports System.Data.SqlClient

Imports TimeAttendance.utils
Imports System.IO
Imports System.Globalization
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmListEmp
    Protected dbMgr As New DBManager
    Protected dbConnStr As String = dbMgr.getConnString
    Dim gData As New GetData

    Private Sub frmListEmp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call LoadData()
        'Call loadDep()
        'Call loadDiv()
        'Call loadSec()
        ' Call loadPos()
    End Sub


    'Public Overrides Sub btnSearch_Click(sender As Object, e As System.EventArgs) Handles btns
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim strSQL As String
    '    Dim db As New db


    '    Dim arrData() As String
    '    Dim List As ListViewItem

    '    strSQL = "select e.Code , e.fName , e.LName ,  DivId = isnull(div.Division,'') ,  " & _
    '              " DepId = isnull(dep.Department,'') ,   " & _
    '              " SecId = isnull(sec.Section,''),   e.LastUpdate   " & _
    '            " from Emp e  " & _
    '              " Left Join Division div  " & _
    '                    " on e.DivId = div.DivId  " & _
    '              " Left Join Department dep   " & _
    '                    " on e.DeptId = dep.DeptId  " & _
    '              " left Join Section sec  " & _
    '                    " on e.SecId = sec.SecId " & _
    '        " Where 1=1 "

    '    If ChkCode.Checked = True Then
    '        strSQL &= " and e.Code like '%" & txtCode.Text.Trim & "%' "

    '    ElseIf txtName.Text.Trim <> "" Then
    '        strSQL &= " and e.fName like '%" & txtName.Text.Trim & "%' "

    '    ElseIf ChkLname.Checked = True = True Then
    '        strSQL &= " and e.LName like '%" & txtLname.Text.Trim & "%' "

    '    ElseIf ChkGrouptype.Checked = True Then ' หาตามกรุ๊ป
    '        If txtDivId.Text.Trim <> "" Then
    '            strSQL &= " and e.DivId like '%" & txtDivId.Text.Trim & "%' "
    '        End If
    '        If txtDepId.Text.Trim <> "" Then
    '            strSQL &= " and e.DeptId like '%" & txtDepId.Text.Trim & "%' "
    '        End If
    '        'If txtPosId.Text.Trim <> "" Then
    '        '    strSQL &= " and e.PositionId like '%" & txtPosId.Text.Trim & "%' "
    '        'End If
    '        If txtSecId.Text.Trim <> "" Then
    '            strSQL &= " and e.SecId like '%" & txtSecId.Text.Trim & "%' "
    '        End If
    '    End If



    '    Try
    '        ' Call OpenConnect(True)
    '        Da = New SqlDataAdapter(strSQL, Conn)
    '        Da.Fill(Ds, "data")
    '        '  Call OpenConnect(False)

    '        With Ds.Tables("data")
    '            lstShow.BeginUpdate()
    '            lstShow.Items.Clear()
    '            Dim I As Integer = 0
    '            For Each drw As DataRow In .Rows
    '                I += 1
    '                arrData = New String() {I, _
    '                                        drw("Code"), _
    '                                        drw("fName"), _
    '                                        drw("LName"), _
    '                                        drw("DivId"), _
    '                                        drw("DepId"), _
    '                                        drw("SecId")}
    '                List = New ListViewItem(arrData)
    '                lstShow.Items.Add(List)
    '            Next
    '            lstShow.EndUpdate()
    '        End With
    '    Catch ex As Exception
    '        lstShow.EndUpdate()
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    '        Exit Sub
    '    End Try
    'End Sub


    Private Sub LoadData()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        'Dim arrData() As String
        'Dim List As ListViewItem

        strSQL = "select ROW_NUMBER() OVER(ORDER BY Code) as row, " &
                        " e.Code , e.Fname , e.Lname ,  Division = isnull(div.Division,'') , " &
                        " Department = isnull(dep.Department,'') , " &
                        " Section = isnull(sec.Section,''),   e.LastUpdate,  " &
                        " e.Position " &
                 " from Emp e " &
                      " Left Join Department dep " &
                            " on e.DeptId = dep.DeptId  " &
                      " Left Join Division div   " &
                            " on dep.DivId = div.DivId  " &
                      " left Join Section sec  " &
                 " on e.SecId = sec.SecId "


        Try
            '   Call OpenConnect(True)
            Da = New SqlDataAdapter(strSQL, Conn)
            Da.Fill(Ds, "data")
            '   Call OpenConnect(False)


            GcUser.DataSource = Ds
            GcUser.DataMember = "data"

            'With Ds.Tables("data")
            '    lstShow.BeginUpdate()
            '    lstShow.Items.Clear()
            '    Dim I As Integer = 0
            '    For Each drw As DataRow In .Rows
            '        I += 1
            '        arrData = New String() {I,
            '                                drw("Code"),
            '                                drw("Fname"),
            '                                drw("Lname"),
            '                                drw("Division"),
            '                                drw("Department"),
            '                                drw("Position")}

            '        List = New ListViewItem(arrData)
            '        lstShow.Items.Add(List)
            '    Next
            '    lstShow.EndUpdate()
            'End With
        Catch ex As Exception
            lstShow.EndUpdate()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
    End Sub

    'Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
    '    Me.Close()
    'End Sub

    Private Sub cboDivId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDivId.SelectedIndexChanged
        txtDivId.Text = GetData.GetDivisionId(cboDivId.SelectedItem)
    End Sub

    Private Sub cboDepId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepId.SelectedIndexChanged
        txtDepId.Text = GetData.GetDepartmentId(cboDepId.SelectedItem)
    End Sub

    Private Sub cboSecId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSecId.SelectedIndexChanged
        txtSecId.Text = GetData.GetSectionID(cboSecId.SelectedItem)
    End Sub

    Private Sub cboPosId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPosId.SelectedIndexChanged
        '  txtPosId.Text = gData.GetPosId(cboPosId.SelectedItem)
    End Sub

    Private Sub loadDiv()

        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "select DivId,Division " & _
                 " from division " & _
                 " Order By DivId"

        Try
            Da = New SqlDataAdapter(strSQL, Conn)
            Da.Fill(Ds, "data")
            With Ds.Tables("data")
                cboDivId.Items.Clear()
                cboDivId.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
                For Each dr As DataRow In .Rows
                    cboDivId.Items.Add(dr("Division"))
                Next
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cboDivId.SelectedIndex = 0

    End Sub

    Private Sub loadDep()

        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "select DeptId,Department " & _
                 " from Department " & _
                 " Order By DeptId"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            cboDepId.Items.Clear()
            cboDepId.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            For Each dr As DataRow In .Rows
                cboDepId.Items.Add(dr("Department"))
            Next
        End With
        cboDepId.SelectedIndex = 0

    End Sub

    Private Sub loadSec()

        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "select SecId,Section " & _
                 " from Section " & _
                 " Order By SecId"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            cboSecId.Items.Clear()
            cboSecId.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            For Each dr As DataRow In .Rows
                cboSecId.Items.Add(dr("Section"))
            Next
        End With
        cboSecId.SelectedIndex = 0

    End Sub

    Private Sub loadPos()

        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "select PositionId,PositionName " & _
                 " from Position " & _
                 " Order By PositionId"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            cboPosId.Items.Clear()
            cboPosId.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            For Each dr As DataRow In .Rows
                cboPosId.Items.Add(dr("PositionName"))
            Next
        End With
        cboPosId.SelectedIndex = 0

    End Sub

    Private Sub btnBrowsDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowsDiv.Click
        'ListDivision = Division.LEmp
        'Dim frm As New frmListDivision
        'frm.ShowDialog()
    End Sub

    Private Sub btnBrowsDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowsDep.Click
        'ListDivision = Department.LEmp
        'Dim frm As New frmListDepartment
        'frm.ShowDialog()
    End Sub

    Private Sub btnBrowsSec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowsSec.Click
        'ListDivision = Section.LEmp
        'Dim frm As New frmListSection
        'frm.ShowDialog()
    End Sub

    Private Sub btnBrowsPos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowsPos.Click
        'ListDivision = Position.LEmp
        'Dim frm As New frmListPosition
        'frm.ShowDialog()
    End Sub

    Private Sub lstShow_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstShow.DoubleClick
        With lstShow
            If .SelectedItems.Count = 0 Then Exit Sub
            Select Case ListEmp
                Case Emp.Permission
                    fPermission.txtCode.Text = .SelectedItems(0).SubItems(1).Text.Trim
                    fPermission.txtCode_LostFocus(Me, System.EventArgs.Empty)
            End Select
        End With
        Me.Close()
    End Sub

    Private Sub lstShow_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstShow.SelectedIndexChanged

    End Sub

    Private Sub ChkCode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCode.CheckedChanged
        txtCode.Text = ""
        txtName.Text = ""
        txtLname.Text = ""
        GroupType.Enabled = False
        txtCode.Focus()


    End Sub

    Private Sub ChkName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkName.CheckedChanged
        txtCode.Text = ""
        txtName.Text = ""
        txtLname.Text = ""
        GroupType.Enabled = False
        txtName.Focus()
    End Sub

    Private Sub ChkLname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkLname.CheckedChanged
        txtCode.Text = ""
        txtName.Text = ""
        txtLname.Text = ""
        GroupType.Enabled = False
        txtLname.Focus()
    End Sub

    Private Sub ChkGrouptype_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkGrouptype.CheckedChanged
        txtCode.Text = ""
        txtName.Text = ""
        txtLname.Text = ""
        GroupType.Enabled = True

    End Sub

    'Private Sub txtCode_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCode.TextChanged
    '    Call btnSearch_Click(Me, System.EventArgs.Empty)
    'End Sub

    'Private Sub txtName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtName.TextChanged
    '    Call btnSearch_Click(Me, System.EventArgs.Empty)
    'End Sub

    'Private Sub txtLname_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLname.TextChanged
    '    Call btnSearch_Click(Me, System.EventArgs.Empty)
    'End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub GcUser_Click(sender As Object, e As EventArgs) Handles GcUser.Click

    End Sub

    Private Sub GvUser_DoubleClick(sender As Object, e As EventArgs) Handles GvUser.DoubleClick


        Try
            Dim gv As GridView = CType(sender, GridView)

            If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "Code")) = True Then Exit Sub

            Select Case ListEmp
                Case Emp.Permission
                    fPermission.txtCode.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Code")
                    fPermission.txtCode_LostFocus(Me, System.EventArgs.Empty)
            End Select

        Catch ex As Exception

        End Try
        Me.Close()
    End Sub


End Class