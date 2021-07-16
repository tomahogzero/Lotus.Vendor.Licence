Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports DevExpress.XtraGrid.Views.Base
Imports TimeAttendance.utils

Public Class frmEmpCalOTConfig

    Private Sub frmEmpCalOT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBarX1.Visible = False

        cboOTType.SelectedIndex = 0

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
        strSQL = "select Division " &
                " From Division " &
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


    Private Sub LoadEmpGroup()
        'Dim Da As SqlDataAdapter
        'Dim Ds As New DataSet
        'Dim strSQL As String = ""
        'strSQL = "select GroupName " & _
        '        " From EmpGroup " & _
        '        " Order By GroupName"

        'Da = New SqlDataAdapter(strSQL, Conn)
        'Da.Fill(Ds, "data")
        'With Ds.Tables("data")
        '    cboEmpGroup.Items.Clear()
        '    cboEmpGroup.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))

        '    cboEmpGroup_Cal.Items.Clear()
        '    cboEmpGroup_Cal.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
        '    For Each dr As DataRow In .Rows
        '        cboEmpGroup.Items.Add(dr("GroupName"))
        '        cboEmpGroup_Cal.Items.Add(dr("GroupName"))
        '    Next
        '    cboEmpGroup.SelectedIndex = 0
        '    cboEmpGroup_Cal.SelectedIndex = 0
        'End With
    End Sub


    Private Sub LoadEmpdev()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "Select row_number() over("
        strSQL &= LoadEmpdev_order_by()
        strSQL &= " ) As row," &
                        " Emp.Code,"

        If cValGolbal.Lang = "TH" Then
            strSQL &= "isnull(Emp.title,'') + isnull(emp.Fname,'') as Fname"
        Else
            strSQL &= "isnull(Emp.title,'') + ' ' + isnull(emp.Fname,'') as Fname"
        End If

        strSQL &= ",Lname, " &
                        " Division = Isnull(Div.Division,''), " &
                        " Department = Isnull(Department.Department,''), " &
                        " Position = Isnull(Emp.Position,'')" &
                " From Emp Left Join Department " &
                            " On Emp.DeptId = Department.DeptId " &
                        " Left Join Division Div " &
                            " On Department.DivId = Div.DivId " &
                        " Left Join Company_sub cs" &
                            " On Emp.CompanyID = cs.CompanyID " &
                        " Left Join EmpConfigOT EOT " &
                            " On Emp.Code = EOT.EmpCode " &
                " Where WorkStatus = 'W' and isnull(Emp.OT,0) = 0 "

        If cboDivision.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Department.DivId,'') = '" & GetData.GetDivisionId(cboDivision.Text.Trim) & "'"
        End If

        If cboDepartment.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Emp.DeptId,'') = '" & GetData.GetDepartmentId(cboDepartment.Text.Trim) & "'"
        End If

        strSQL &= LoadEmpdev_order_by()

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")

        GcEmp.DataSource = Ds
        GcEmp.DataMember = "Data"
    End Sub

    Function LoadEmpdev_order_by() As String
        Dim query As String = ""
        If rdByCode.Checked = True Then
            query &= " Order By Emp.Code"
        End If

        If rdByName.Checked = True Then
            query &= " Order By Fname,Lname"
        End If

        If rdByDeptCode.Checked = True Then
            query &= " Order By Div.Division,Department.Department,Fname,Lname"
        End If

        If rdByDeptName.Checked = True Then
            query &= " Order By Div.Division,Department.Department,Fname,Lname"
        End If
        Return query

    End Function



    Private Sub LoadEmpKaDate_dev()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        'Dim arrData() As String
        'Dim List As ListViewItem
        strSQL = "Select row_number() over("
        strSQL &= LoadEmpKaDate_dev_order_by()
        strSQL &= " ) As row," &
                        " Emp.Code,"

        If cValGolbal.Lang = "TH" Then
            strSQL &= "isnull(Emp.title,'') + isnull(emp.Fname,'') as Fname"
        Else
            strSQL &= "isnull(Emp.title,'') + ' ' + isnull(emp.Fname,'') as Fname"
        End If

        strSQL &= ",Lname, " &
                        " Division = Isnull(Div.Division,''), " &
                        " Department = Isnull(Department.Department,''), " &
                        " Position = Isnull(Emp.Position,'')" &
                " From Emp Left Join Department " &
                            " On Emp.DeptId = Department.DeptId " &
                        " Left Join Division Div " &
                            " On Department.DivId = Div.DivId " &
                        " Left Join Company_sub cs" &
                            " On Emp.CompanyID = cs.CompanyID " &
                        " Left Join EmpConfigOT EOT " &
                            " On Emp.Code = EOT.EmpCode " &
                " Where WorkStatus = 'W' and isnull(Emp.OT,0) = 1"

        If cboDivision_Cal.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Department.DivId,'') = '" & GetData.GetDivisionId(cboDivision_Cal.Text.Trim) & "'"
        End If

        If cboDepartment_Cal.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Emp.DeptId,'') = '" & GetData.GetDepartmentId(cboDepartment_Cal.Text.Trim) & "'"
        End If

        strSQL &= LoadEmpKaDate_dev_order_by()


        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")

        GcEmp_Cal.DataSource = Ds
        GcEmp_Cal.DataMember = "Data"
    End Sub

    Function LoadEmpKaDate_dev_order_by() As String
        Dim query As String = ""
        If rdByCode_Date.Checked = True Then
            query &= " Order By Emp.Code"
        End If

        If rdByName_Date.Checked = True Then
            query &= " Order By Fname,Lname"
        End If

        If rdByDeptCode_Date.Checked = True Then
            query &= " Order By Div.Division,Department.Department,Emp.Code"
        End If

        If rdByDeptName_Date.Checked = True Then
            query &= " Order By Div.Division,Department.Department,Fname,Lname"
        End If
        Return query
    End Function

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        btnRefresh.Enabled = False
        '   Call LoadEmp()
        Call LoadEmpdev()
        btnRefresh.Enabled = True
    End Sub

    Private Sub btnRefresh_Date_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh_Cal.Click
        btnRefresh_Cal.Enabled = False
        '   Call LoadEmpKaDate()
        Call LoadEmpKaDate_dev()
        btnRefresh_Cal.Enabled = True
    End Sub


    Private Sub btnNoneSelectAll_Date_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoneSelectAll_Date.Click
        With lstEmp_Cal
            For i As Integer = 0 To .Items.Count - 1
                .Items(i).Checked = False
            Next
        End With
    End Sub

    Private Sub btnSelectAll_Date_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll_Date.Click
        With lstEmp_Cal
            For i As Integer = 0 To .Items.Count - 1
                .Items(i).Checked = True
            Next
        End With
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        '  If lstEmp.CheckedItems.Count = 0 Then Exit Sub

        Dim OtID As Integer = cboOTType.SelectedIndex + 1

        If OtID = 0 Then

            MsgBox(My.Resources.res_warning_message_spacial.Select_Cal_OT, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If
        ProgressBarX1.Visible = True

        btnRemove.Enabled = False
        btnAdd.Enabled = False




        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Tn As SqlTransaction

        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            ProgressBarX1.Value = 0
            ProgressBarX1.Maximum = GvEmp.GetSelectedRows.Count - 1

            Dim code As String = ""
            Dim rec As Integer = 1

            For Each i As Long In GvEmp.GetSelectedRows

                Dim dr As DataRow = GvEmp.GetDataRow(i)
                ProgressBarX1.Value = i + 1
                ProgressBarX1.Text = i & "/" & ProgressBarX1.Maximum


                If code <> "" Then
                    code &= ","
                End If

                code &= "'" & dr("Code").ToString & "'"

                ' เช็คกรณีเลือก Customer ไม่เหมือนกัน ให้มี Alet แจ้งเตือน  ***************************************
                '     If cForm.fAp.GvAp.RowCount = 0 Then ' เช็คถ้ายังไม่มีการป้อนรายการ

                If (rec Mod 1000) = 0 Or rec >= GvEmp.GetSelectedRows.Count Then

                    strSQL = "Update Emp Set OT = 1 " &
                              " where code in (" & code & ")"
                    dCmd.Connection = Conn
                    dCmd.CommandText = strSQL
                    dCmd.ExecuteNonQuery()

                    ' Delete OT Config
                    strSQL = "Delete From EmpConfigOT " &
                                " where Empcode in (" & code & ")"
                    dCmd.Connection = Conn
                    dCmd.CommandText = strSQL
                    dCmd.ExecuteNonQuery()

                    ' Add OT Config
                    'strSQL = "Insert Into EmpConfigOT(EmpCode,OTID) " &
                    '                    " Values(" &
                    '                        "'" & dr("Code").ToString & "'," & OtID & ")"
                    'dCmd.Connection = Conn
                    'dCmd.CommandText = strSQL
                    'dCmd.ExecuteNonQuery()


                    strSQL = "Insert Into EmpConfigOT(EmpCode,OTID) " &
                            " select code,1" &
                            " from emp " &
                            " where code in (" & code & ")"
                    dCmd.Connection = Conn
                    dCmd.CommandText = strSQL
                    dCmd.ExecuteNonQuery()

                    code = ""
                    Application.DoEvents()
                End If
                rec += 1
            Next
            Tn.Commit()



        Catch ex As Exception

            btnRemove.Enabled = True
            btnAdd.Enabled = True
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try

        btnRemove.Enabled = True
        btnAdd.Enabled = True
        Call btnRefresh_Click(Me, System.EventArgs.Empty)
        Call btnRefresh_Date_Click(Me, System.EventArgs.Empty)

        ProgressBarX1.Visible = False
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        '  If lstEmp_Cal.CheckedItems.Count = 0 Then Exit Sub


        ProgressBarX1.Visible = True

        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Tn As SqlTransaction


        btnAdd.Enabled = False
        btnRemove.Enabled = False


        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            ProgressBarX1.Value = 0
            ProgressBarX1.Maximum = gvEmp_Cal.GetSelectedRows.Count - 1

            Dim code As String = ""
            Dim rec As Integer = 1

            For Each i As Long In gvEmp_Cal.GetSelectedRows
                Dim dr As DataRow = gvEmp_Cal.GetDataRow(i)
                ProgressBarX1.Value = i + 1
                ProgressBarX1.Text = i & "/" & ProgressBarX1.Maximum

                If code <> "" Then
                    code &= ","
                End If

                code &= "'" & dr("Code").ToString & "'"


                If (rec Mod 1000) = 0 Or rec >= gvEmp_Cal.GetSelectedRows.Count Then

                    strSQL = "Update Emp Set OT = 0 " &
                         " where code in (" & code & ")"
                    dCmd.Connection = Conn
                    dCmd.CommandText = strSQL
                    dCmd.ExecuteNonQuery()

                    ' Delete OT Config
                    strSQL = "Delete From EmpConfigOT " &
                        " where Empcode in (" & code & ")"
                    dCmd.Connection = Conn
                    dCmd.CommandText = strSQL
                    dCmd.ExecuteNonQuery()

                    code = ""
                    Application.DoEvents()
                End If
                rec += 1
            Next
            Tn.Commit()


        Catch ex As Exception

            btnAdd.Enabled = True
            btnRemove.Enabled = True

            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try

        btnAdd.Enabled = True
        btnRemove.Enabled = True


        Call btnRefresh_Click(Me, System.EventArgs.Empty)
        Call btnRefresh_Date_Click(Me, System.EventArgs.Empty)

        ProgressBarX1.Visible = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub



    Private Sub Gveemp_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GvEmp.CustomDrawCell
        If e.Column.Name = "colrow" Then
            If e.RowHandle < -1 Then
                e.DisplayText = "0"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If

    End Sub

    Private Sub gvEmp_Cal_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles gvEmp_Cal.CustomDrawCell
        If e.Column.Name = "GridColumn1" Then
            If e.RowHandle < -1 Then
                e.DisplayText = "0"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If

    End Sub

    Private Sub cboDivision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDivision.SelectedIndexChanged
        Call SearchData.LoadDepartment(Me, cboDepartment, GetData.GetDivisionId(cboDivision.Text.Trim), True)
    End Sub



    Private Sub rdByDeptCode_Date_CheckedChanged(sender As Object, e As EventArgs) Handles rdByDeptCode_Date.CheckedChanged

    End Sub

    Private Sub frmEmpCalOTConfig_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        SplitContainerControl1.SplitterPosition = pnlApp.Width / 2
    End Sub

    Private Sub SplitContainerControl1_SplitterPositionChanged(sender As Object, e As EventArgs) Handles SplitContainerControl1.SplitterPositionChanged
        grpLeft.Width = SplitContainerControl1.Panel1.Width - grpLeft.Left - 2
        grpRight.Width = SplitContainerControl1.Panel2.Width - grpRight.Left - 2
    End Sub

    Private Sub cboDivision_Cal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDivision_Cal.SelectedIndexChanged
        Call SearchData.LoadDepartment(Me, cboDepartment_Cal, GetData.GetDivisionId(cboDivision_Cal.Text.Trim), True)
    End Sub
End Class