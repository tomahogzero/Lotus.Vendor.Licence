Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports TimeAttendance.utils

Public Class frmKa_Spacial

    Private Sub frmKaGroupUse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ProgressBarX1.Visible = False

        Call SearchData.LoadDivision(Me, cboDivision, True)
        Call SearchData.LoadDepartment(Me, cboDepartment, "", True)

        Call SearchData.LoadDivision(Me, cboDivision_Cal, True)
        Call SearchData.LoadDepartment(Me, cboDepartment_Cal, "", True)
    End Sub

    Private Sub LoadDepartment()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select Department " & _
                " From Department " & _
                " Order By Department"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            cboDepartment.Properties.Items.Clear()
            cboDepartment.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))

            cboDepartment_Cal.Properties.Items.Clear()
            cboDepartment_Cal.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            For Each dr As DataRow In .Rows
                cboDepartment.Properties.Items.Add(dr("Department"))
                cboDepartment_Cal.Properties.Items.Add(dr("Department"))
            Next
            cboDepartment.SelectedIndex = 0
            cboDepartment_Cal.SelectedIndex = 0
        End With
    End Sub

    Private Sub LoadDivision()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select Division " & _
                " From Division " & _
                " Order By Division"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            cboDivision.Properties.Items.Clear()
            cboDivision.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))

            cboDivision_Cal.Properties.Items.Clear()
            cboDivision_Cal.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            For Each dr As DataRow In .Rows
                cboDivision.Properties.Items.Add(dr("Division"))
                cboDivision_Cal.Properties.Items.Add(dr("Division"))
            Next
            cboDivision.SelectedIndex = 0
            cboDivision_Cal.SelectedIndex = 0
        End With
    End Sub

    Private Sub LoadPosition()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select Position " & _
                " From Emp " & _
                " Group By Position " & _
                " Order By Position"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            cboPosition.Properties.Items.Clear()
            cboPosition.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))

            '   cboPosition_Cal.Properties.Items.Clear()
            '   cboPosition_Cal.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            For Each dr As DataRow In .Rows
                cboPosition.Properties.Items.Add(dr("Position"))
                '    cboPosition_Cal.Properties.Items.Add(dr("Position"))
            Next
            '  cboPosition.SelectedIndex = 0
            '  cboPosition_Cal.SelectedIndex = 0
        End With
    End Sub

    Private Sub LoadEmpGroup()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select GroupName " & _
                " From EmpGroup " & _
                " Order By GroupName"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            cboEmpGroup.Items.Clear()
            cboEmpGroup.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))

            cboEmpGroup_Cal.Items.Clear()
            cboEmpGroup_Cal.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            For Each dr As DataRow In .Rows
                cboEmpGroup.Items.Add(dr("GroupName"))
                cboEmpGroup_Cal.Items.Add(dr("GroupName"))
            Next
            cboEmpGroup.SelectedIndex = 0
            cboEmpGroup_Cal.SelectedIndex = 0
        End With
    End Sub

    Private Sub LoadCompany()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select CompanyName From Company_Sub "
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            cboCompany.Items.Clear()
            cboCompany.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))

            cboCompany_Cal.Items.Clear()
            cboCompany_Cal.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            Dim I As Integer
            For I = 0 To .Rows.Count - 1
                cboCompany.Items.Add(.Rows(I).Item("CompanyName"))

                cboCompany_Cal.Items.Add(.Rows(I).Item("CompanyName"))
            Next
            Ds.Clear()
            cboCompany.SelectedIndex = 0
            cboCompany_Cal.SelectedIndex = 0
        End With
    End Sub

    Private Sub LoadEmp()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        'Dim arrData() As String
        'Dim List As ListViewItem

        strSQL = "Select row_number() over("
        strSQL &= LoadEmp_order_by()
        strSQL &= " ) As row," &
                        " Code,"

        If cValGolbal.Lang = "TH" Then
            strSQL &= "isnull(Emp.title,'') + isnull(emp.Fname,'') as Fname"
        Else
            strSQL &= "isnull(Emp.title,'') + ' ' + isnull(emp.Fname,'') as Fname"
        End If

        strSQL &= ",Lname, " &
                        " Department = Isnull(Department.Department,'') " &
                        " ,Department.DivId,isnull(div.division,'') as Division" &
                        " ,emp.Position" &
                " From Emp Left Join Department " &
                            " On Emp.DeptId = Department.DeptId " &
                        " left join division div " &
                            " on Department.DivId = div.divid" &
                " Where WorkStatus = 'W' and Isnull(Ka_Spacial,0) = 0 "

        'If cboCompany.SelectedIndex > 0 Then
        '    strSQL &= " and isnull(Emp.CompanyId,'') = '" & GetData.GetCompanyId(cboCompany.Text.Trim) & "'"
        'End If

        If cboDivision.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Department.DivId,'') = '" & GetData.GetDivisionId(cboDivision.Text.Trim) & "'"
        End If

        If cboDepartment.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Emp.DeptId,'') = '" & GetData.GetDepartmentId(cboDepartment.Text.Trim) & "'"
        End If

        'If cboPosition.SelectedIndex > 0 Then
        '    strSQL &= " and Isnull(Emp.Position,'') = '" & cboPosition.Text.Trim & "'"
        'End If

        'If cboEmpGroup.SelectedIndex > 0 Then
        '    strSQL &= " and Isnull(Emp.GroupId,'') = '" & GetData.GetEmpGroupId(cboEmpGroup.Text.Trim) & "'"
        'End If

        'If rdMonth.Checked = True Then
        '    strSQL &= " and Emp.WageType = 'M'"
        'End If

        'If rdDay.Checked = True Then
        '    strSQL &= " and Emp.WageType = 'D' and Contractor = 0"
        'End If

        'If rdContractor.Checked = True Then
        '    strSQL &= " and Emp.WageType = 'D' and Contractor = 1"
        'End If

        'If txtNameSearch.Text.Trim <> "" Then
        '    strSQL &= " and (Fname + LName) Like '%" & Replace(txtNameSearch.Text.Trim, " ", "") & "%'"
        'End If


        strSQL &= LoadEmp_order_by()

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")


        GcEmp.DataSource = Ds
        GcEmp.DataMember = "Data"
    End Sub

    Function LoadEmp_order_by() As String
        Dim query As String = ""
        If rdByCode.Checked = True Then
            query &= " Order By Emp.Code"
        End If

        If rdByName.Checked = True Then
            query &= " Order By Fname,Lname"
        End If

        If rdByDeptCode.Checked = True Then
            query &= " Order By Div.Division,Department.Department,Emp.Code"
        End If

        If rdByDeptName.Checked = True Then
            query &= " Order By Div.Division,Department.Department,Fname,Lname"
        End If
        Return query


    End Function

    Private Sub LoadEmpKaDate()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        'Dim arrData() As String
        'Dim List As ListViewItem

        strSQL = "Select row_number() over("
        strSQL &= LoadEmpKaDate_order_by()
        strSQL &= " ) As row," &
                        " Code,"

        If cValGolbal.Lang = "TH" Then
            strSQL &= "isnull(Emp.title,'') + isnull(emp.Fname,'') as Fname"
        Else
            strSQL &= "isnull(Emp.title,'') + ' ' + isnull(emp.Fname,'') as Fname"
        End If

        strSQL &= ",Lname, " &
                        " Division = Isnull(Div.Division,''), " &
                        " Department = Isnull(Department.Department,''), " &
                        " Position = Isnull(Emp.Position,'')," &
                        " GroupName = Isnull(EG.GroupName,'') " &
                " From Emp Left Join Department " &
                            " On Emp.DeptId = Department.DeptId " &
                        " Left Join Division Div " &
                            " On Department.DivId = Div.DivId " &
                        " Left Join Company_sub cs" &
                            " On Emp.CompanyID = cs.CompanyID " &
                        " Left Join EmpConfigOT EOT " &
                            " On Emp.Code = EOT.EmpCode " &
                        " Left Join EmpGroup EG " &
                            " On Emp.GroupId = EG.GroupId " &
                " Where WorkStatus = 'W' and Isnull(Ka_Spacial,0) = 1 "

        'If cboCompany_Cal.SelectedIndex > 0 Then
        '    strSQL &= " and isnull(Emp.CompanyId,'') = '" & GetData.GetCompanyId(cboCompany_Cal.Text.Trim) & "'"
        'End If

        If cboDivision_Cal.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Department.DivId,'') = '" & GetData.GetDivisionId(cboDivision_Cal.Text.Trim) & "'"
        End If

        If cboDepartment_Cal.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Emp.DeptId,'') = '" & GetData.GetDepartmentId(cboDepartment_Cal.Text.Trim) & "'"
        End If

        'If cboPosition_Cal.SelectedIndex > 0 Then
        '    strSQL &= " and Isnull(Emp.Position,'') = '" & cboPosition_Cal.Text.Trim & "'"
        'End If

        'If cboEmpGroup.SelectedIndex > 0 Then
        '    strSQL &= " and Isnull(Emp.GroupId,'') = '" & GetData.GetEmpGroupId(cboEmpGroup_Cal.Text.Trim) & "'"
        'End If

        'If rdMonth_Cal.Checked = True Then
        '    strSQL &= " and Emp.WageType = 'M'"
        'End If

        'If rdDay_Cal.Checked = True Then
        '    strSQL &= " and Emp.WageType = 'D' and Contractor = 0"
        'End If

        'If rdContractor_Cal.Checked = True Then
        '    strSQL &= " and Emp.WageType = 'D' and Contractor = 1"
        'End If

        'If txtNameSearch_Cal.Text.Trim <> "" Then
        '    strSQL &= " and (Fname + LName) Like '%" & Replace(txtNameSearch_Cal.Text.Trim, " ", "") & "%'"
        'End If


        strSQL &= LoadEmpKaDate_order_by()

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        GcEmp_Cal.DataSource = Ds
        GcEmp_Cal.DataMember = "Data"
    End Sub

    Function LoadEmpKaDate_order_by() As String
        Dim query As String = ""
        If rdByCode_Cal.Checked = True Then
            query &= " Order By Emp.Code"
        End If

        If rdByName_Cal.Checked = True Then
            query &= " Order By Fname,Lname"
        End If

        If rdByDeptCode_Cal.Checked = True Then
            query &= " Order By Div.Division,Department.Department,Emp.Code"
        End If

        If rdByDeptName_Cal.Checked = True Then
            query &= " Order By Div.Division,Department.Department,Fname,Lname"
        End If
        Return query
    End Function

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        btnRefresh.Enabled = False
        Call LoadEmp()
        btnRefresh.Enabled = True
    End Sub

    Private Sub btnRefresh_Date_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh_Cal.Click
        btnRefresh_Cal.Enabled = False
        Call LoadEmpKaDate()
        btnRefresh_Cal.Enabled = True
    End Sub

    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        With lstEmp
            For i As Integer = 0 To .Items.Count - 1
                .Items(i).Checked = True
            Next
        End With
    End Sub

    Private Sub btnNoneSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoneSelectAll.Click
        With lstEmp
            For i As Integer = 0 To .Items.Count - 1
                .Items(i).Checked = False
            Next
        End With
    End Sub

    Private Sub btnNoneSelectAll_Date_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoneSelectAll_Cal.Click
        With lstEmp_Cal
            For i As Integer = 0 To .Items.Count - 1
                .Items(i).Checked = False
            Next
        End With
    End Sub

    Private Sub btnSelectAll_Date_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll_Cal.Click
        With lstEmp_Cal
            For i As Integer = 0 To .Items.Count - 1
                .Items(i).Checked = True
            Next
        End With
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        '    If lstEmp.CheckedItems.Count = 0 Then Exit Sub
        ProgressBarX1.Visible = True

        btnAdd.Enabled = False
        btnRemove.Enabled = False

        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Tn As SqlTransaction

        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            'For i As Integer = 0 To lstEmp.CheckedItems.Count - 1
            '    strSQL = "Update Emp Set Ka_Spacial = 1 " &
            '            " Where Code = '" & lstEmp.CheckedItems(i).SubItems(1).Text.Trim & "'"
            '    dCmd.Connection = Conn
            '    dCmd.CommandText = strSQL
            '    dCmd.ExecuteNonQuery()
            'Next
            'Tn.Commit()

            Dim code As String = ""
            Dim rec As Integer = 1

            ProgressBarX1.Value = 0
            ProgressBarX1.Maximum = GvEmp.GetSelectedRows.Count - 1

            For Each i As Long In GvEmp.GetSelectedRows

                Dim dr As DataRow = GvEmp.GetDataRow(i)
                ProgressBarX1.Value = i + 1
                ProgressBarX1.Text = i & "/" & ProgressBarX1.Maximum

                If code <> "" Then
                    code &= ","
                End If

                code &= "'" & dr("Code").ToString & "'"


                If (rec Mod 1000) = 0 Or rec >= GvEmp.GetSelectedRows.Count Then
                    strSQL = "Update Emp Set Ka_Spacial = 1 " &
                        " where code in (" & code & ")"
                    dCmd.Connection = Conn
                    dCmd.CommandText = strSQL
                    dCmd.ExecuteNonQuery()

                    code = ""
                    Application.DoEvents()
                End If

                rec += 1


                'strSQL = "Update Emp Set Ka_Spacial = 1 " &
                '        " Where Code = '" & dr("Code").ToString & "'"
                'dCmd.Connection = Conn
                'dCmd.CommandText = strSQL
                'dCmd.ExecuteNonQuery()
            Next
            Tn.Commit()
            btnAdd.Enabled = True
            btnRemove.Enabled = True

        Catch ex As Exception
            btnAdd.Enabled = True
            btnRemove.Enabled = True
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try
        Call btnRefresh_Click(Me, System.EventArgs.Empty)
        Call btnRefresh_Date_Click(Me, System.EventArgs.Empty)
        ProgressBarX1.Visible = False
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        '    If lstEmp_Cal.CheckedItems.Count = 0 Then Exit Sub

        ProgressBarX1.Visible = True
        btnAdd.Enabled = False
        btnRemove.Enabled = False

        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Tn As SqlTransaction

        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            'For i As Integer = 0 To lstEmp_Cal.CheckedItems.Count - 1
            '    strSQL = "Update Emp Set Ka_Spacial = 0 " &
            '            " Where Code = '" & lstEmp_Cal.CheckedItems(i).SubItems(1).Text.Trim & "'"
            '    dCmd.Connection = Conn
            '    dCmd.CommandText = strSQL
            '    dCmd.ExecuteNonQuery()
            'Next
            'Tn.Commit()

            Dim code As String = ""
            Dim rec As Integer = 1

            ProgressBarX1.Value = 0
            ProgressBarX1.Maximum = GvEmp_Cal.GetSelectedRows.Count - 1

            For Each i As Long In GvEmp_Cal.GetSelectedRows

                Dim dr As DataRow = GvEmp_Cal.GetDataRow(i)
                ProgressBarX1.Value = i + 1
                ProgressBarX1.Text = i & "/" & ProgressBarX1.Maximum

                If code <> "" Then
                    code &= ","
                End If

                code &= "'" & dr("Code").ToString & "'"


                If (rec Mod 1000) = 0 Or rec >= GvEmp_Cal.GetSelectedRows.Count Then

                    strSQL = "Update Emp Set Ka_Spacial = 0 " &
                        " where code in (" & code & ")"
                    dCmd.Connection = Conn
                    dCmd.CommandText = strSQL
                    dCmd.ExecuteNonQuery()

                    code = ""
                    Application.DoEvents()
                End If
                rec += 1

                'strSQL = "Update Emp Set Ka_Spacial = 0 " &
                '        " Where Code =  '" & dr("Code").ToString & "'"
                'dCmd.Connection = Conn
                'dCmd.CommandText = strSQL
                'dCmd.ExecuteNonQuery()
            Next
            Tn.Commit()
            btnAdd.Enabled = True
            btnRemove.Enabled = True

        Catch ex As Exception
            btnAdd.Enabled = True
            btnRemove.Enabled = True
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try
        Call btnRefresh_Click(Me, System.EventArgs.Empty)
        Call btnRefresh_Date_Click(Me, System.EventArgs.Empty)
        ProgressBarX1.Visible = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnshowHide_Click(sender As Object, e As EventArgs) Handles btnshowHide.Click
        'If btnshowHide.Text = "ซ่อนค้นหา" Then
        '    btnshowHide.Text = "แสดงค้นหา"
        '    spcon.SplitterPosition = 0
        'Else
        '    btnshowHide.Text = "ซ่อนค้นหา"
        '    spcon.SplitterPosition = 109
        'End If
    End Sub

    Private Sub btnHide_cal_Click(sender As Object, e As EventArgs) Handles btnHide_cal.Click
        If btnHide_cal.Text = "ซ่อนค้นหา" Then
            btnHide_cal.Text = "แสดงค้นหา"
            '  spcon_cal.SplitterPosition = 0
        Else
            btnHide_cal.Text = "ซ่อนค้นหา"
            ' spcon_cal.SplitterPosition = 109
        End If
    End Sub

    Private Sub frmKa_Spacial_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        SplitContainerControl1.SplitterPosition = panelApp.Width / 2
    End Sub

    Private Sub SplitContainerControl1_SplitterPositionChanged(sender As Object, e As EventArgs) Handles SplitContainerControl1.SplitterPositionChanged
        grpLeft.Width = SplitContainerControl1.Panel1.Width - grpLeft.Left - 2
        GrpRight.Width = SplitContainerControl1.Panel2.Width - GrpRight.Left - 2
    End Sub

    Private Sub cboDivision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDivision.SelectedIndexChanged
        Call SearchData.LoadDepartment(Me, cboDepartment, GetData.GetDivisionId(cboDivision.Text.Trim), True)
    End Sub

    Private Sub cboDivision_Cal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDivision_Cal.SelectedIndexChanged
        Call SearchData.LoadDepartment(Me, cboDepartment_Cal, GetData.GetDivisionId(cboDivision_Cal.Text.Trim), True)
    End Sub
End Class