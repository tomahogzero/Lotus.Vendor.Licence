Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports TimeAttendance.utils

Public Class frmEmpOTDeducByDay

    Private Sub frmEmpOTDeducByDay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDate.EditValue = Now.Date

        ProgressBarX1.Visible = False

        Call SearchData.LoadDivision(Me, cboDivision, True)
        Call SearchData.LoadDivision(Me, cboDivision_Cal, True)
        Call SearchData.LoadDepartment(Me, cboDepartment, "", True)
        Call SearchData.LoadDepartment(Me, cboDepartment_Cal, "", True)
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
                " Where WorkStatus = 'W' " &
                        " and emp.code not in (select EmpId from TimeEmpOT_Deduc_ByDay " &
                                            " Where Convert(nVarchar(10),Date,111) = '" & Format(txtDate.EditValue, "yyyy/MM/dd") & "')"


        If cboDivision.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Department.DivId,'') = '" & GetData.GetDivisionId(cboDivision.Text.Trim) & "'"
        End If

        If cboDepartment.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Emp.DeptId,'') = '" & GetData.GetDepartmentId(cboDepartment.Text.Trim) & "'"
        End If

        strSQL &= LoadEmpdev_order_by()

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

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
            query &= " Order By Department.Department,Emp.Code"
        End If

        If rdByDeptName.Checked = True Then
            query &= " Order By Div.Division,Department.Department,Fname,Lname"
        End If
        Return query
    End Function

    Private Sub LoadEmpOT_DeducDev()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "Select row_number() over("
        strSQL &= LoadEmpOT_DeducDev_order_by()
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
                        " Position = Isnull(Emp.Position,'')," &
                        " OT = Isnull(TDeduc.OT,0) " &
                " From TimeEmpOT_Deduc_ByDay TDeduc " &
                        " Left Join Emp " &
                            " On TDeduc.EmpId = Emp.Code " &
                        " Left Join Department " &
                            " On Emp.DeptId = Department.DeptId " &
                        " Left Join Division Div " &
                            " On Department.DivId = Div.DivId " &
                " Where Convert(nVarchar(10),Date,111) = '" & Format(txtDate.EditValue, "yyyy/MM/dd") & "'"


        If cboDivision_Cal.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Department.DivId,'') = '" & GetData.GetDivisionId(cboDivision_Cal.Text.Trim) & "'"
        End If

        If cboDepartment_Cal.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Emp.DeptId,'') = '" & GetData.GetDepartmentId(cboDepartment_Cal.Text.Trim) & "'"
        End If

        strSQL &= LoadEmpOT_DeducDev_order_by()

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        GcEmp_OT.DataSource = Ds
        GcEmp_OT.DataMember = "Data"
    End Sub

    Function LoadEmpOT_DeducDev_order_by() As String
        Dim query As String = ""
        If rdByCode_Date.Checked = True Then
            query &= " Order By Emp.Code"
        End If

        If rdByName_Date.Checked = True Then
            query &= " Order By Fname,Lname"
        End If

        If rdByDeptCode_Date.Checked = True Then
            query &= " Order By Div.Division,Department.Department,Fname,Lname"
        End If

        If rdByDeptName_Date.Checked = True Then
            query &= " Order By Div.Division,Department.Department,Fname,Lname"
        End If
        Return query
    End Function

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Call LoadEmp()
        'Call LoadEmpOT_Deduc()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If IsNumeric(txtOT.Text) = False Then
            MsgBox(My.Resources.res_warning_message.correct_number, MsgBoxStyle.Information, Me.Text)
            txtOT.Text = ""
            txtOT.Focus()
            Exit Sub
        End If

        ProgressBarX1.Visible = True
        btnSave.Enabled = False

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

                    strSQL = "Delete From TimeEmpOT_Deduc_ByDay " &
                        " where EmpId in (" & code & ") and " &
                                " Convert(nVarchar(10),Date,111) = '" & Format(txtDate.EditValue, "yyyy/MM/dd") & "' "
                    dCmd.Connection = Conn
                    dCmd.CommandText = strSQL
                    dCmd.ExecuteNonQuery()



                    'strSQL = "Insert Into TimeEmpOT_Deduc_ByDay(EmpId,Date,OT) " &
                    '        " Values(" &
                    '            "  '" & dr("Code").ToString & "'," &
                    '            " '" & Format(txtDate.EditValue, "yyyy/MM/dd") & "'," &
                    '            " " & txtOT.Text & ")"


                    strSQL = "Insert Into TimeEmpOT_Deduc_ByDay(EmpId,Date,OT) " &
                            " select code,'" & Format(txtDate.EditValue, "yyyy/MM/dd") & "'," &
                            " " & txtOT.Text & " " &
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
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try


        btnSave.Enabled = True

        '    Call LoadEmpOT_Deduc()
        Call LoadEmpdev()
        Call LoadEmpOT_DeducDev()
        ProgressBarX1.Visible = False
    End Sub



    Private Sub btnDeleteOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteOT.Click
        'If MsgBox("คุณต้องการลบข้อมูล OT หรือไม่", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then Exit Sub
        'If MsgManager.ConfirmDialog(Me, "frmEmpOTDeducByDayRS", Me.Text, "Delete_OT",
        'MessageBoxIcon.Information) = DialogResult.Cancel Then Exit Sub

        ProgressBarX1.Visible = True
        btnDeleteOT.Enabled = False

        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Tn As SqlTransaction

        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try

            ProgressBarX1.Value = 0
            ProgressBarX1.Maximum = GvEmp_OT.GetSelectedRows.Count - 1


            Dim code As String = ""
            Dim rec As Integer = 1

            For Each i As Long In GvEmp_OT.GetSelectedRows

                Dim dr As DataRow = GvEmp_OT.GetDataRow(i)
                ProgressBarX1.Value = i + 1
                ProgressBarX1.Text = i & "/" & ProgressBarX1.Maximum


                If code <> "" Then
                    code &= ","
                End If

                code &= "'" & dr("Code").ToString & "'"

                ' เช็คกรณีเลือก Customer ไม่เหมือนกัน ให้มี Alet แจ้งเตือน  ***************************************
                '     If cForm.fAp.GvAp.RowCount = 0 Then ' เช็คถ้ายังไม่มีการป้อนรายการ

                If (rec Mod 1000) = 0 Or rec >= GvEmp_OT.GetSelectedRows.Count Then

                    strSQL = "Delete From TimeEmpOT_Deduc_ByDay " &
                        " where EmpId in (" & code & ") and " &
                                " Convert(nVarchar(10),Date,111) = '" & Format(txtDate.EditValue, "yyyy/MM/dd") & "' "
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
            Tn.Rollback()
            btnDeleteOT.Enabled = True
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try


        btnDeleteOT.Enabled = True

        Call LoadEmpdev()
        Call LoadEmpOT_DeducDev()

        ProgressBarX1.Visible = False
    End Sub

    Private Sub btnRefreshOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshOT.Click
        ' Call LoadEmpOT_Deduc()
        Call LoadEmpOT_DeducDev()
    End Sub

    Private Sub btnRefreshF_Click(sender As Object, e As EventArgs) Handles btnRefreshF.Click
        'Call LoadEmp()
        'Call LoadEmpOT_Deduc()

        '   ProgressBarX1.Visible = True

        Call LoadEmpdev()
        'Call LoadEmpOT_DeducDev()
        '  ProgressBarX1.Visible = False

    End Sub

    Private Sub GvEmp_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GvEmp.CustomDrawCell
        If e.Column.Name = "colrow" Then
            If e.RowHandle < -1 Then
                e.DisplayText = "0"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If

    End Sub

    Private Sub GvEmp_Cal_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GvEmp_OT.CustomDrawCell
        If e.Column.Name = "GridColumn1" Then
            If e.RowHandle < -1 Then
                e.DisplayText = "0"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If

    End Sub

    Private Sub txtDate_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtDate.EditValueChanging

    End Sub
    Private Sub txtDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.EditValueChanged
        Call LoadEmpdev()
        Call LoadEmpOT_DeducDev()
    End Sub

    Private Sub frmEmpOTDeducByDay_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        SplitContainerControl1.SplitterPosition = pnlApp.Width / 2
    End Sub

    Private Sub SplitContainerControl1_SplitterPositionChanged(sender As Object, e As EventArgs) Handles SplitContainerControl1.SplitterPositionChanged
        grpLeft.Width = SplitContainerControl1.Panel1.Width - grpLeft.Left - 2
        grpRight.Width = SplitContainerControl1.Panel2.Width - grpRight.Left - 2
    End Sub

    Private Sub cboDivision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDivision.SelectedIndexChanged
        Call SearchData.LoadDepartment(Me, cboDepartment, GetData.GetDivisionId(cboDivision.Text.Trim), True)
    End Sub

    Private Sub cboDivision_Cal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDivision_Cal.SelectedIndexChanged
        Call SearchData.LoadDepartment(Me, cboDepartment_Cal, GetData.GetDivisionId(cboDivision_Cal.Text.Trim), True)
    End Sub
End Class