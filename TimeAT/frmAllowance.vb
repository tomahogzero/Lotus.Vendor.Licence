Imports System.Data
Imports System.Data.SqlClient
Imports TimeAttendance.utils

Public Class frmAllowance
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Public Sub txtCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.LostFocus
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim strSQL As String

        strSQL = "Select Code,Fname,Lname,Emp.DeptId,Department,Workingplace" & _
                " From Emp Left Join Department On Emp.DeptId = Department.DeptId " & _
                " Where Code = '" & txtCode.Text.Trim & "' "

        If ComId.Trim <> "" Then
            strSQL &= " and isnull(Emp.CompanyId,'') = '" & ComId.Trim & "'"
        End If


        DA = New SqlDataAdapter(strSQL, Conn)
        DA.Fill(DS, "Data")
        With DS.Tables("Data")
            If .Rows.Count = 0 Then
                txtCode.Text = ""
                txtName.Text = ""
                txtDeptId.Text = ""
                txtDepartment.Text = ""
                txtSite.Text = ""
                Exit Sub
            End If
            txtCode.Text = .Rows(0).Item("Code")
            txtName.Text = .Rows(0).Item("Fname") & "   " & .Rows(0).Item("Lname")
            txtDeptId.Text = .Rows(0).Item("DeptId")
            txtDepartment.Text = .Rows(0).Item("Department")
            txtSite.Text = .Rows(0).Item("Workingplace")
            DS.Clear()
        End With

        Call LoadDataAllowance()
    End Sub


    Private Sub LoadDataAllowance()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        ' LoadDataAllowance

        Dim arrDATA() As String
        Dim List As New ListViewItem

        strSQL = "Select taw.id,taw.Code," & _
                            " EmpName = Emp.Fname + '   ' + Emp.Lname," & _
                            " Emp.DeptId," & _
                            " Allowance = Isnull(aw.Description,'')," & _
                            " taw.Total, " & _
                            " Status = Case Taw.Status " & _
                                " When 'M' Then 'Manual' " & _
                                " When 'A' Then 'Auto' " & _
                                " Else '' " & _
                                " End, " & _
                            " Taw.AutoDate,Taw.Remark " & _
                    " From TimeAllowance Taw Left Join Allowance Aw " & _
                         " On Taw.awCode = Aw.Code " & _
                          " Left Join Emp " & _
                         " On Taw.Code = Emp.Code " & _
                 " Where Month_Year = '" & txtMonthYear.Text.Trim & "' "

        If ComId.Trim <> "" Then
            strSQL &= " and isnull(Emp.CompanyId,'') = '" & ComId.Trim & "'"
        End If

        If rdByPerson.Checked = True Then
            strSQL &= " and taw.Code = '" & txtCode.Text.Trim & "'"
        End If

        If rdByDept.Checked = True Then
            strSQL &= " and emp.DeptId = '" & lblDeptId.Text.Trim & "'"
        End If

        strSQL &= " Order By taw.Code,aw.Description"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            Dim I As Integer
            lstAllowance.Items.Clear()
            For I = 0 To .Rows.Count - 1
                arrDATA = New String() {I + 1, _
                                        .Rows(I).Item("Id").ToString, _
                                        .Rows(I).Item("Code"), _
                                        .Rows(I).Item("EmpName"), _
                                        .Rows(I).Item("DeptId"), _
                                        .Rows(I).Item("Allowance"), _
                                        .Rows(I).Item("Total"), _
                                        .Rows(I).Item("Status"), _
                                        Format(.Rows(I).Item("AutoDate"), "dd/MM/yyyy"), _
                                        .Rows(I).Item("Remark")}
                List = New ListViewItem(arrDATA)
                lstAllowance.Items.Add(List)
            Next
            Ds.Clear()
        End With
    End Sub


    Private Sub LoadDataAllowanceAll()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        ' LoadDataAllowance

        Dim arrDATA() As String
        Dim List As New ListViewItem

        strSQL = "Select taw.Code," & _
                            " EmpName = Emp.Fname + '   ' + Emp.Lname," & _
                            " Emp.DeptId," & _
                            " Allowance = Isnull(aw.Description,'')," & _
                            " Total = Sum(taw.Total) " & _
                    " From TimeAllowance Taw Left Join Allowance Aw " & _
                                " On Taw.awCode = Aw.Code " & _
                          " Left Join Emp " & _
                                " On Taw.Code = Emp.Code " & _
                 " Where Month_Year = '" & txtMonthYear.Text.Trim & "'"

        If ComId.Trim <> "" Then
            strSQL &= " and isnull(Emp.CompanyId,'') = '" & ComId.Trim & "'"
        End If

        strSQL &= " Group By taw.Code," & _
                            " Emp.Fname + '   ' + Emp.Lname," & _
                            " Emp.DeptId," & _
                            " Isnull(aw.Description,'')"

        If rdawCode.Checked = True Then
            strSQL &= " Order By Isnull(aw.Description,''),taw.Code"
        Else
            strSQL &= " Order By taw.code,Isnull(aw.Description,'')"
        End If


        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            Dim I As Integer
            lstAllData.Items.Clear()
            For I = 0 To .Rows.Count - 1
                arrDATA = New String() {I + 1, _
                                        "", _
                                        .Rows(I).Item("Code"), _
                                        .Rows(I).Item("EmpName"), _
                                        .Rows(I).Item("DeptId"), _
                                        .Rows(I).Item("Allowance"), _
                                        .Rows(I).Item("Total")}
                List = New ListViewItem(arrDATA)
                lstAllData.Items.Add(List)
            Next
            Ds.Clear()
        End With
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call ClearVacation()
        Call LoadDataAllowance()
        txtCode.Focus()
        txtCode.SelectAll()
        'Call EnaCmd(True, False, False)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim dCmd As New SqlCommand
        Dim strSQL As String

        If IsDate(ConvertDate("01/" & txtMonthYear.Text.Trim)) = False Then
            'MsgBox("กรุณาป้อนประจำเดือนให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmAllowanceRS", Me.Text, "Check_Month", MessageBoxIcon.Information)
            txtMonthYear.Focus()
            Exit Sub
        End If

        If rdByPerson.Checked = True Then
            If txtName.Text.Trim = "" Then
                '   MsgManager.ShowDialog(Me, "frmAllowanceRS", Me.Text, "Insert_EmpID", MessageBoxIcon.Information)
                'MsgBox("กรุณาป้อนรหัสพนักงานด้วย", MsgBoxStyle.Information, Me.Text)
                txtCode.Focus()
                Exit Sub
            End If
        End If

        If rdByDept.Checked = True Then
            If lblDeptId.Text.Trim = "" Then
                'MsgBox("กรุณาเลือกแผนกด้วย", MsgBoxStyle.Information, Me.Text)
                '   MsgManager.ShowDialog(Me, "frmAllowanceRS", Me.Text, "Select_Dep", MessageBoxIcon.Information)
                cboDepartment.Focus()
                Exit Sub
            End If
        End If

        If lblawCode.Text.Trim = "" Then
            'MsgBox("กรุณาเลือก Allowance ด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmAllowanceRS", Me.Text, "Select_Allowance", MessageBoxIcon.Information)
            cboAllowance.Focus()
            Exit Sub
        End If

        If IsNumeric(txtTotal.Text.Trim) = False Then
            'MsgBox("กรุณาป้อนตัวเลขให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmAllowanceRS", Me.Text, "Check_Number", MessageBoxIcon.Information)
            txtTotal.Focus()
            Exit Sub
        End If

        If CDbl(txtTotal.Text) = 0 Then
            'MsgBox("กรุณาป้อนยอดเงินด้วย", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmAllowanceRS", Me.Text, "Insert_Money", MessageBoxIcon.Information)
            txtTotal.Focus()
            Exit Sub
        End If

        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn

        Try
            If rdByPerson.Checked = True Then

                strSQL = "Delete TimeAllowance" & _
                        " Where Month_Year = '" & txtMonthYear.Text.Trim & "' and " & _
                                "Code =  '" & txtCode.Text.Trim & "' and " & _
                                "awCode = '" & lblawCode.Text.Trim & "' and " & _
                                "Status = 'M' and   " & _
                                " Code In (Select Code From Emp Where CompanyID like '" & IIf(ComId.Trim = "", "%", ComId.Trim) & "')"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()

                strSQL = "Insert Into TimeAllowance(Month_Year,Code,awCode,Total,Status,AutoDate,Remark) Values(" & _
                        " '" & txtMonthYear.Text.Trim & "'," & _
                        " '" & txtCode.Text.Trim & "'," & _
                        " '" & lblawCode.Text.Trim & "'," & _
                        " " & txtTotal.Text.Trim & ",'M',Getdate(),'')"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()

                ' Clear Default
                strSQL = "Delete TimeAwDefault" & _
                        " Where awBy = 'P' and Code_Dept = '" & txtCode.Text.Trim & "' and " & _
                                " awCode = '" & lblawCode.Text.Trim & "'and   " & _
                                " Code In (Select Code From Emp Where CompanyID like '" & IIf(ComId.Trim = "", "%", ComId.Trim) & "')"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()

                ' Insert Default
                strSQL = "Insert Into TimeAwDefault(awBy,Code_Dept,awCode,Total) Values(" & _
                        " 'P','" & txtCode.Text.Trim & "','" & lblawCode.Text.Trim & "'," & _
                        " " & txtTotal.Text.Trim & ")"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()
            Else

                strSQL = "Delete TimeAllowance" & _
                        " Where Month_Year = '" & txtMonthYear.Text.Trim & "' and " & _
                                "awCode = '" & lblawCode.Text.Trim & "' and " & _
                                "Code In (Select Code From Emp Where DeptId = '" & lblDeptId.Text.Trim & "') and   " & _
                                " Code In (Select Code From Emp Where CompanyID like '" & IIf(ComId.Trim = "", "%", ComId.Trim) & "')"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()

                strSQL = "Insert Into TimeAllowance(Month_Year,Code,awCode,Total)" & _
                        " Select '" & txtMonthYear.Text.Trim & "',Code," & _
                                " '" & lblawCode.Text.Trim & "'," & _
                                " " & txtTotal.Text.Trim & _
                        " From Emp " & _
                        " Where DeptId = '" & lblDeptId.Text.Trim & "' and Workstatus = 'W'"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()

                ' Clear Default
                strSQL = "Delete TimeAwDefault" & _
                        " Where awBy = 'D' and Code_Dept = '" & lblDeptId.Text.Trim & "' and " & _
                                " awCode = '" & lblawCode.Text.Trim & "' and  " & _
                                " Code In (Select Code From Emp Where CompanyID like '" & IIf(ComId.Trim = "", "%", ComId.Trim) & "')"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()

                ' Insert Default
                strSQL = "Insert Into TimeAwDefault(awBy,Code_Dept,awCode,Total) Values(" & _
                        " 'D','" & lblDeptId.Text.Trim & "','" & lblawCode.Text.Trim & "'," & _
                        " " & txtTotal.Text.Trim & ")"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()

            End If
            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub ClearVacation()
        lblId.Text = ""
        txtTotal.Text = ""
    End Sub

    Private Sub frmAllowance_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        fAllowance = Nothing
    End Sub

    Private Sub frmAllowance_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmAllowance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            If TypeOf Me.ActiveControl Is TextBox Then
                Dim tb As TextBox = DirectCast(Me.ActiveControl, TextBox)
                If tb.Multiline AndAlso tb.AcceptsReturn Then
                    e.Handled = False
                    Exit Sub
                End If
            End If
            e.Handled = True
            Dim oform As Form = Me.FindForm
            oform.SelectNextControl(oform.ActiveControl, True, True, True, True)
            oform.ActiveControl.Focus()
        End If
    End Sub

    Private Sub frmAllowance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtMonthYear.Text = Format(Date.Now, "MM/yyyy")
        Call LoadAllowance()
        Call LoadDertment()
        Call LoadDataAllowanceAll()
        Call EnaCmd(True, False, False)
    End Sub

    Private Sub EnaCmd(ByVal Add As Boolean, ByVal Edit As Boolean, ByVal Delete As Boolean)
        btnAdd.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim dCmd As New SqlCommand
        Dim strSQL As String

        If IsDate(ConvertDate("01/" & txtMonthYear.Text.Trim)) = False Then
            'MsgBox("กรุณาป้อนประจำเดือนให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmAllowanceRS", Me.Text, "Check_Month", MessageBoxIcon.Information)
            txtMonthYear.Focus()
            Exit Sub
        End If

        If rdByPerson.Checked = True Then
            If txtName.Text.Trim = "" Then
                'MsgBox("กรุณาป้อนรหัสพนักงานด้วย", MsgBoxStyle.Information, Me.Text)
                MsgManager.ShowDialog(Me, "frmAllowanceRS", Me.Text, "Insert_EmpID", MessageBoxIcon.Information)
                txtCode.Focus()
                Exit Sub
            End If
        End If

        If rdByDept.Checked = True Then
            If lblDeptId.Text.Trim = "" Then
                'MsgBox("กรุณาเลือกแผนกด้วย", MsgBoxStyle.Information, Me.Text)
                MsgManager.ShowDialog(Me, "frmAllowanceRS", Me.Text, "Select_Dep", MessageBoxIcon.Information)
                cboDepartment.Focus()
                Exit Sub
            End If
        End If

        If lblawCode.Text.Trim = "" Then
            'MsgBox("กรุณาเลือก Allowance ด้วย", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmAllowanceRS", Me.Text, "Select_Allowance", MessageBoxIcon.Information)
            cboAllowance.Focus()
            Exit Sub
        End If

        If IsNumeric(txtTotal.Text.Trim) = False Then
            'MsgBox("กรุณาป้อนตัวเลขให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmAllowanceRS", Me.Text, "Check_Number", MessageBoxIcon.Information)
            txtTotal.Focus()
            Exit Sub
        End If

        If CDbl(txtTotal.Text) = 0 Then
            'MsgBox("กรุณาป้อนยอดเงินด้วย", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmAllowanceRS", Me.Text, "Insert_Money", MessageBoxIcon.Information)
            txtTotal.Focus()
            Exit Sub
        End If

        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            If rdByPerson.Checked = True Then

                strSQL = "Delete TimeAllowance" & _
                        " Where Month_Year = '" & txtMonthYear.Text.Trim & "' and " & _
                                "Code =  '" & txtCode.Text.Trim & "' and " & _
                                "awCode = '" & lblawCode.Text.Trim & "' and   " & _
                                " Code In (Select Code From Emp Where CompanyID like '" & IIf(ComId.Trim = "", "%", ComId.Trim) & "')"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()

                strSQL = "Insert Into TimeAllowance(Month_Year,Code,awCode,Total) Values" & _
                        " '" & txtMonthYear.Text.Trim & "'," & _
                        " '" & txtCode.Text.Trim & "'," & _
                        " '" & lblawCode.Text.Trim & "'," & _
                        " " & txtTotal.Text.Trim & ")"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()
            Else
                strSQL = "Delete TimeAllowance" & _
                        " Where Month_Year = '" & txtMonthYear.Text.Trim & "' and " & _
                                "awCode = '" & lblawCode.Text.Trim & "' and " & _
                                "Code = (Select Code From Emp Where DeptId = '" & lblDeptId.Text.Trim & "') and   " & _
                                " Code In (Select Code From Emp Where CompanyID like '" & IIf(ComId.Trim = "", "%", ComId.Trim) & "')"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()

                strSQL = "Insert Into TimeAllowance(Month_Year,Code,awCode,Total)" & _
                        " Select '" & txtMonthYear.Text.Trim & "',Code," & _
                                " '" & lblawCode.Text.Trim & "'," & _
                                " " & txtTotal.Text.Trim & _
                        " From Emp " & _
                        " Where DeptId = '" & lblDeptId.Text.Trim & "' and Workstatus = 'W'"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()
            End If
            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim dCmd As New SqlCommand
        Dim strSQL As String

        If IsDate(ConvertDate("01/" & txtMonthYear.Text.Trim)) = False Then
            'MsgBox("กรุณาป้อนประจำเดือนให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmAllowanceRS", Me.Text, "Check_Month", MessageBoxIcon.Information)
            txtMonthYear.Focus()
            Exit Sub
        End If


        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            Dim I As Integer
            For I = 0 To lstAllowance.CheckedItems.Count - 1
                strSQL = "Delete TimeAllowance" & _
                        " Where Id = '" & lstAllowance.CheckedItems(I).SubItems(1).Text.Trim & "' and " & _
                                " Code In (Select Code From Emp Where CompanyID like '" & ComId & "')"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()
            Next

            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub txtTime_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtTime_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub LoadAllowance()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select Code,Description from Allowance Order By Description"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            cboAllowance.Items.Clear()
            Dim I As Integer
            For I = 0 To .Rows.Count - 1
                cboAllowance.Items.Add(.Rows(I).Item("Description"))
            Next
            Ds.Clear()
        End With
    End Sub

    Private Sub cboAllowance_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAllowance.SelectedIndexChanged
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select Code,Description " & _
                " from Allowance " & _
                " Where RTrim(Description) = '" & cboAllowance.Text & "' " & _
                " Order By Description"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            Dim I As Integer
            lblawCode.Text = ""
            For I = 0 To .Rows.Count - 1
                lblawCode.Text = .Rows(I).Item("Code")
            Next
            Ds.Clear()
        End With
    End Sub

    Private Sub lstVacation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAllowance.SelectedIndexChanged
        'With lstAllowance
        '    If .SelectedItems.Count = 0 Then Exit Sub
        '    rdByPerson.Checked = True
        '    lblId.Text = .SelectedItems(0).SubItems(1).Text.Trim
        '    txtCode.Text = .SelectedItems(0).SubItems(2).Text.Trim
        '    Call txtCode_LostFocus(Me, System.EventArgs.Empty)
        '    dim I as 
        '    cboAllowance.SelectedItem = .SelectedItems(0).SubItems(5).Text.Trim
        '    txtTotal.Text = .SelectedItems(0).SubItems(6).Text.Trim
        '    Call EnaCmd(False, True, True)
        'End With
    End Sub

    Private Sub txtDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtDate_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub LoadDertment()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select DeptId,Department From Department Order By DeptId"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            Dim I As Integer
            cboDepartment.Items.Clear()
            For I = 0 To .Rows.Count - 1
                cboDepartment.Items.Add(.Rows(I).Item("Department"))
            Next
            Ds.Clear()
        End With
    End Sub

    Private Sub cboDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepartment.SelectedIndexChanged
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select DeptId,Department " & _
                " From Department " & _
                " Where Department = '" & Replace(cboDepartment.Text.Trim, "'", "''") & "'" & _
                " Order By DeptId"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            Dim I As Integer
            lblDeptId.Text = ""
            For I = 0 To .Rows.Count - 1
                lblDeptId.Text = .Rows(I).Item("DeptId")
            Next
            Ds.Clear()
        End With
        Call LoadDataAllowance()
    End Sub

    Private Sub rdByPerson_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdByPerson.CheckedChanged
        If rdByPerson.Checked = True Then
            pnlEmp.Enabled = True
            pnlDept.Enabled = False
        End If
    End Sub

    Private Sub rdByDept_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdByDept.CheckedChanged
        If rdByDept.Checked = True Then
            pnlEmp.Enabled = False
            pnlDept.Enabled = True
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Call LoadDataAllowanceAll()
    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged

    End Sub

    Private Sub btnLoadDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadDefault.Click
        Dim dCmd As New SqlCommand
        Dim strSQL As String

        If IsDate(ConvertDate("01/" & txtMonthYear.Text.Trim)) = False Then
            'MsgBox("กรุณาป้อนประจำเดือนให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            'Check_Month
            MsgManager.ShowDialog(Me, "frmAllowanceRS", Me.Text, "Check_Month", MessageBoxIcon.Information)
            txtMonthYear.Focus()
            Exit Sub
        End If

        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            ' By Department
            strSQL = "Delete " & _
                    " From TimeAllowance " & _
                    " Where TimeAllowance.Status = 'M' and TimeAllowance.Month_Year = '" & txtMonthYear.Text.Trim & "' and " & _
                            " (Code + '-' + awCode) In " & _
                             " (Select Code + '-' + awCode " & _
                             " From Emp Inner Join TimeAwDefault Aw " & _
                                  " On Emp.DeptId = aw.Code_Dept and " & _
                                      " aw.awBy = 'D' " & _
                             " Where Workstatus = 'W') and " & _
                                " Code In (Select Code From Emp Where CompanyID like '" & IIf(ComId.Trim = "", "%", ComId.Trim) & "')"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            strSQL = "Insert Into TimeAllowance(Month_Year,Code,awCode,Total,Status) " & _
                    " Select '" & txtMonthYear.Text.Trim & "',Code, " & _
                            " awCode, " & _
                            " Total ," & _
                            " 'M' " & _
                    " From Emp Inner Join TimeAwDefault Aw " & _
                         " On Emp.DeptId = Aw.Code_Dept and " & _
                             " Aw.awBy = 'D' " & _
                    " Where Workstatus = 'W' " & _
                    " Order by Code "
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            ' By Person
            strSQL = "Delete" & _
                    " From TimeAllowance " & _
                    " Where TimeAllowance.Status = 'M' and TimeAllowance.Month_Year = '" & txtMonthYear.Text.Trim & "' and " & _
                                " (Code + '-' + awCode) In " & _
                                        " (Select Code + '-' + awCode " & _
                                        " From TimeAwDefault" & _
                                     " Where awBy = 'P') and   " & _
                                " Code In (Select Code From Emp Where CompanyID like '" & IIf(ComId.Trim = "", "%", ComId.Trim) & "')"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            strSQL = "Insert Into TimeAllowance(Month_Year,Code,awCode,Total,Status) " & _
                     " Select '" & txtMonthYear.Text.Trim & "',Code_Dept, " & _
                                " awCode, " & _
                                " Total,'M' " & _
                    " From TimeAwDefault " & _
                    " Where awBy = 'P' "
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()
            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
        'MsgBox("Load ข้อมูลสำเร็จแล้ว", MsgBoxStyle.Information, Me.Text)
        MsgManager.ShowDialog(Me, "frmAllowanceRS", Me.Text, "Load_Success", MessageBoxIcon.Information)
        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub lstAllData_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstAllData.DoubleClick
        With lstAllData
            If .SelectedItems.Count = 0 Then Exit Sub
            rdawCode.Checked = True
            txtCode.Text = .SelectedItems(0).SubItems(2).Text.Trim
            txtCode_LostFocus(Me, System.EventArgs.Empty)
            TabControl1.SelectedIndex = 0
        End With
    End Sub

    Private Sub lstAllData_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAllData.SelectedIndexChanged

    End Sub
End Class