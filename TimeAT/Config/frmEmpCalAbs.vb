Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports DevExpress.XtraGrid.Views.Base
Imports TimeAttendance.utils

Public Class frmEmpCalAbs

    Private Sub frmEmpCalAbs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Visible = False
        Call SearchData.LoadDivision(Me, cboDivision, True)
        Call SearchData.LoadDepartment(Me, cboDepartment, "", True)

        Call SearchData.LoadDivision(Me, cboDivision_Date, True)
        Call SearchData.LoadDepartment(Me, cboDepartment_Date, "", True)

    End Sub

    Private Sub LoadDepartment()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select Department " &
                " From Department " &
                " Order By Department"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            cboDepartment.Properties.Items.Clear()
            cboDepartment.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))

            cboDepartment_Date.Properties.Items.Clear()
            cboDepartment_Date.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            For Each dr As DataRow In .Rows
                cboDepartment.Properties.Items.Add(dr("Department"))
                cboDepartment_Date.Properties.Items.Add(dr("Department"))
            Next
            cboDepartment.SelectedIndex = 0
            cboDepartment_Date.SelectedIndex = 0
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

            cboDivision_Date.Properties.Items.Clear()
            cboDivision_Date.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            For Each dr As DataRow In .Rows
                cboDivision.Properties.Items.Add(dr("Division"))
                cboDivision_Date.Properties.Items.Add(dr("Division"))
            Next
            cboDivision.SelectedIndex = 0
            cboDivision_Date.SelectedIndex = 0
        End With
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
                " Where Emp.WorkStatus = 'W' " &
                                " and Code In " &
                                " (Select Code From EmpNoCalAbs)"

        If cboDivision.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Department.DivId,'') = '" & GetData.GetDivisionId(cboDivision.Text.Trim) & "'"
        End If

        If cboDepartment.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Department.Department,'') = '" & cboDepartment.Text.Trim & "'"
        End If

        If txtNameSearch.Text.Trim <> "" Then
            strSQL &= " and (Fname + LName) Like '%" & Replace(txtNameSearch.Text.Trim, " ", "") & "%'"
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
            query &= " Order By emp.Code"
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

    Private Sub LoadEmpKaDate_dev()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

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
                " Where WorkStatus = 'W' and " &
                        " Code not In " &
                                " (Select Code From EmpNoCalAbs)"


        If cboDivision_Date.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Department.DivId,'') = '" & GetData.GetDivisionId(cboDivision_Date.Text.Trim) & "'"
        End If

        If cboDepartment_Date.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Department.Department,'') = '" & cboDepartment_Date.Text.Trim & "'"
        End If

        strSQL &= LoadEmpKaDate_dev_order_by()

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")

        GcEmpdate.DataSource = Ds
        GcEmpdate.DataMember = "Data"
    End Sub

    Function LoadEmpKaDate_dev_order_by() As String
        Dim query As String = ""
        If rdByCode_Date.Checked = True Then
            query &= " Order By Code"
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
        '    Call LoadEmp()
        Call LoadEmpdev()
    End Sub

    Private Sub btnRefresh_Date_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh_Date.Click
        '  Call LoadEmpKaDate()
        Call LoadEmpKaDate_dev()
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

    Private Sub btnNoneSelectAll_Date_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoneSelectAll_Date.Click
        With lstEmp_Date
            For i As Integer = 0 To .Items.Count - 1
                .Items(i).Checked = False
            Next
        End With
    End Sub

    Private Sub btnSelectAll_Date_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll_Date.Click
        With lstEmp_Date
            For i As Integer = 0 To .Items.Count - 1
                .Items(i).Checked = True
            Next
        End With
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        '   If lstEmp.CheckedItems.Count = 0 Then Exit Sub
        ProgressBar1.Visible = True

        btnAdd.Enabled = False
        btnRemove.Enabled = False

        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Tn As SqlTransaction

        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try


            ProgressBar1.Value = 0
            ProgressBar1.Maximum = GvEmp.GetSelectedRows.Count - 1


            Dim code As String = ""
            Dim rec As Integer = 1
            For Each i As Long In GvEmp.GetSelectedRows

                Dim dr As DataRow = GvEmp.GetDataRow(i)
                ProgressBar1.Value = i + 1
                ProgressBar1.Text = i & "/" & ProgressBar1.Maximum

                If code <> "" Then
                    code &= ","
                End If

                code &= "'" & dr("Code").ToString & "'"

                If (rec Mod 1000) = 0 Or rec >= GvEmp.GetSelectedRows.Count Then


                    strSQL = "Delete From EmpNoCalAbs " &
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
        ProgressBar1.Visible = False
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        '      If lstEmp_Date.CheckedItems.Count = 0 Then Exit Sub
        ProgressBar1.Visible = True
        btnRemove.Enabled = False
        btnAdd.Enabled = False

        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Tn As SqlTransaction

        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try

            ProgressBar1.Value = 0
            ProgressBar1.Maximum = GvEmpdate.GetSelectedRows.Count - 1

            Dim code As String = ""
            Dim rec As Integer = 1

            For Each i As Long In GvEmpdate.GetSelectedRows

                Dim dr As DataRow = GvEmpdate.GetDataRow(i)
                ProgressBar1.Value = i + 1
                ProgressBar1.Text = i & "/" & ProgressBar1.Maximum

                If code <> "" Then
                    code &= ","
                End If

                code &= "'" & dr("Code").ToString & "'"

                If (rec Mod 1000) = 0 Or rec >= GvEmpdate.GetSelectedRows.Count Then

                    'strSQL = "Insert Into EmpNoCalAbs(Code) Values('" & dr("Code").ToString & "')"
                    'dCmd.Connection = Conn
                    'dCmd.CommandText = strSQL
                    'dCmd.ExecuteNonQuery()



                    strSQL = "Insert Into EmpNoCalAbs(Code) " &
                            " select code" &
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
        ProgressBar1.Visible = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
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

            cboCompany_date.Items.Clear()
            cboCompany_date.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            Dim I As Integer
            For I = 0 To .Rows.Count - 1
                cboCompany.Items.Add(.Rows(I).Item("CompanyName"))

                cboCompany_date.Items.Add(.Rows(I).Item("CompanyName"))
            Next
            Ds.Clear()
            cboCompany.SelectedIndex = 0
        End With
    End Sub

    Private Sub frmEmpCalAbs_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        SplitContainerControl1.SplitterPosition = pnlApp.Width / 2
    End Sub

    Private Sub SplitContainerControl1_SplitterPositionChanged(sender As Object, e As EventArgs) Handles SplitContainerControl1.SplitterPositionChanged
        grpLeft.Width = SplitContainerControl1.Panel1.Width - grpLeft.Left - 2
        grpRight.Width = SplitContainerControl1.Panel2.Width - grpRight.Left - 2
    End Sub

    Private Sub cboDivision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDivision.SelectedIndexChanged
        Call SearchData.LoadDepartment(Me, cboDepartment, GetData.GetDivisionId(cboDivision.Text.Trim), True)
    End Sub

    Private Sub cboDivision_Date_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDivision_Date.SelectedIndexChanged
        Call SearchData.LoadDepartment(Me, cboDepartment_Date, GetData.GetDivisionId(cboDivision_Date.Text.Trim), True)
    End Sub

    'Private Sub Gveemp_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GvEmp.CustomDrawCell
    '    If e.Column.Name = "colrow" Then
    '        If e.RowHandle < -1 Then
    '            e.DisplayText = "0"
    '        Else
    '            e.DisplayText = (e.RowHandle + 1).ToString
    '        End If
    '    End If

    'End Sub

    'Private Sub GvEmpdate_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GvEmpdate.CustomDrawCell
    '    If e.Column.Name = "GridColumn1" Then
    '        If e.RowHandle < -1 Then
    '            e.DisplayText = "0"
    '        Else
    '            e.DisplayText = (e.RowHandle + 1).ToString
    '        End If
    '    End If

    'End Sub

End Class