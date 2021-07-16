Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports TimeAttendance.utils

Public Class frmPrivilegeVal

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Public Sub txtCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.LostFocus
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim strSQL As String

        strSQL = "Select Code,Fname,Lname,Emp.DeptId,Department,Workingplace" &
                " From Emp Left Join Department On Emp.DeptId = Department.DeptId " &
                " Where Code = '" & txtCode.Text.Trim & "' and " &
                    " Emp.CompanyId like '" & IIf(ComId.Trim = "", "%", ComId.Trim) & "' "

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
    End Sub




    Private Sub LoadVacationDev()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim List As New ListViewItem
        '    Dim arrData() As String

        strSQL = "Select ROW_NUMBER() OVER(ORDER BY Pri.Code Desc) as row, Pri.Id,Pri.Year,Pri.Code," &
                        " Title = Isnull(Emp.Title,''),"

        If cValGolbal.Lang = "TH" Then
            strSQL &= "isnull(Emp.title,'') + isnull(emp.Fname,'') as FName"
        Else
            strSQL &= "isnull(Emp.title,'') + ' ' + isnull(emp.Fname,'') as FName"
        End If

        strSQL &= ",LName = Isnull(Emp.LName,'')," &
                        " Pri.ValCode," &
                        " Description = Isnull(TimeWorkingStatus.Description,'')," &
                        " Amt = Isnull(Amt,0), " &
                        " AmtUse = isnull((select Sum(Amt)/8 " &
                                    " from TimeVacation " &
                                    " where year(ValDate) = '" & txtYearly.Text.Trim & "' and " &
                                    " Code = Pri.Code and ValId = Pri.ValCode),0)" &
                        " , Amtremain= isnull(amt,0) -  isnull((select Sum(Amt)/8 " &
                                   " From TimeVacation  Where Year(ValDate) = '" & txtYearly.Text.Trim & "' " &
                                               " And Code = Pri.Code And ValId = Pri.ValCode),0) " &
                " From TimePrivilege_Val Pri " &
                        " Left Join Emp " &
                            " On Pri.Code = Emp.Code " &
                        " Left Join TimeWorkingStatus " &
                            " On Pri.ValCode = TimeWorkingStatus.Code " &
                " Where Pri.Year = '" & txtYearly.Text.Trim & "' and " &
                        " Emp.CompanyID like '" & IIf(ComId.Trim = "", "%", ComId.Trim) & "' "

        strSQL &= " Order By Pri.Code Desc"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")


        GcVacation.DataSource = Ds
        GcVacation.DataMember = "Data"
    End Sub



    Private Sub lstVacation_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstVacation.DoubleClick
        'With lstVacation
        '    If .SelectedItems.Count = 0 Then Exit Sub
        '    lblId.Text = .SelectedItems(0).SubItems(1).Text.Trim
        '    txtCode.Text = .SelectedItems(0).SubItems(2).Text.Trim
        '   cboWorkingStatus.SelectedItem = .SelectedItems(0).SubItems(5).Text.Trim
        '    txtAmt.Text = .SelectedItems(0).SubItems(6).Text.Trim
        '    txtCode_LostFocus(Me, System.EventArgs.Empty)
        '    Call EnaCmd(False, True, True)
        'End With



    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call ClearVacation()
        '   Call LoadVacation()
        Call LoadVacationDev()
        txtCode.Focus()
        txtCode.SelectAll()
        Call EnaCmd(True, False, False)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim dCmd As New SqlCommand
        Dim strSQL As String

        If txtYearly.Text.Trim = "" Then
            'MsgBox("¡ÃØ³Ò»éÍ¹»Õ´éÇÂ", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmPrivilegeValRS", Me.Text, "Check_Year", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.Check_Year, MsgBoxStyle.Information, Me.Text)
            txtYearly.Focus()
            Exit Sub
        End If

        If IsNumeric(txtYearly.Text.Trim) = False Then
            'MsgBox("¡ÃØ³Ò»éÍ¹»Õà»ç¹µÑÇàÅ¢ãËé¶Ù¡µéÍ§´éÇÂ", MsgBoxStyle.Information, Me.Text)
            '    MsgManager.ShowDialog(Me, "frmPrivilegeValRS", Me.Text, "Check_Num_Year", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.Check_Year, MsgBoxStyle.Information, Me.Text)
            txtYearly.Focus()
            Exit Sub
        End If

        If txtName.Text.Trim = "" Then
            'MsgBox("¡ÃØ³Ò»éÍ¹ÃËÑÊ¾¹Ñ¡§Ò¹´éÇÂ", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmPrivilegeValRS", Me.Text, "Insert_EmpID", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.Insert_EmpID, MsgBoxStyle.Information, Me.Text)

            txtCode.Focus()
            Exit Sub
        End If

        If lblValCode.Text.Trim = "" Then
            'MsgBox("¡ÃØ³ÒàÅ×Í¡»ÃÐàÀ·¡ÒÃÅÒ´éÇÂ", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmPrivilegeValRS", Me.Text, "Select_Type_Abs", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message_spacial.Select_Type_Abs, MsgBoxStyle.Information, Me.Text)
            cboWorkingStatus.Focus()
            Exit Sub
        End If

        If IsNumeric(txtAmt.Text.Trim) = False Then
            'MsgBox("¡ÃØ³Ò»éÍ¹µÑÇàÅ¢ãËé¶Ù¡µéÍ§´éÇÂ", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmPrivilegeValRS", Me.Text, "Check_Number", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.correct_number, MsgBoxStyle.Information, Me.Text)
            txtAmt.Focus()
            Exit Sub
        End If


        Try
            strSQL = "Insert Into TimePrivilege_Val(Year,Code,ValCode,Amt) Values(" &
                    " '" & txtYearly.Text.Trim & "'," &
                    " '" & txtCode.Text.Trim & "'," &
                    " '" & lblValCode.Text.Trim & "'," &
                    " " & txtAmt.Text.Trim & ")"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub ClearVacation()
        lblId.Text = ""
        txtCode.Text = ""
        Call txtCode_LostFocus(Me, System.EventArgs.Empty)
        txtAmt.Text = ""
    End Sub

    Private Sub frmEditTime_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        fVacation = Nothing
    End Sub

    Private Sub frmEditTime_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmEditTime_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
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

    Private Sub frmPrivilegeVal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtYearly.Text = Date.Now.Year
        Call LoadWorkingStatus()
        '    Call LoadVacation()
        Call LoadVacationDev()
        Call EnaCmd(True, False, False)
    End Sub

    Private Sub EnaCmd(ByVal Add As Boolean, ByVal Edit As Boolean, ByVal Delete As Boolean)
        btnAdd.Enabled = Add
        btnEdit.Enabled = Edit
        btnDelete.Enabled = Delete
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim dCmd As New SqlCommand
        Dim strSQL As String

        If txtYearly.Text.Trim = "" Then
            'MsgBox("¡ÃØ³Ò»éÍ¹»Õ´éÇÂ", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmPrivilegeValRS", Me.Text, "Check_Year", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.Check_Year, MsgBoxStyle.Information, Me.Text)
            txtYearly.Focus()
            Exit Sub
        End If

        If IsNumeric(txtYearly.Text.Trim) = False Then
            'MsgBox("¡ÃØ³Ò»éÍ¹»Õà»ç¹µÑÇàÅ¢ãËé¶Ù¡µéÍ§´éÇÂ", MsgBoxStyle.Information, Me.Text)
            'MsgManager.ShowDialog(Me, "frmPrivilegeValRS", Me.Text, "Check_Num_Year", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.Check_Year, MsgBoxStyle.Information, Me.Text)
            txtYearly.Focus()
            Exit Sub
        End If

        If txtName.Text.Trim = "" Then
            'MsgBox("¡ÃØ³Ò»éÍ¹ÃËÑÊ¾¹Ñ¡§Ò¹´éÇÂ", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmPrivilegeValRS", Me.Text, "Insert_EmpID", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.Insert_EmpID, MsgBoxStyle.Information, Me.Text)
            txtCode.Focus()
            Exit Sub
        End If

        If lblValCode.Text.Trim = "" Then
            'MsgBox("¡ÃØ³ÒàÅ×Í¡»ÃÐàÀ·¡ÒÃÅÒ´éÇÂ", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmPrivilegeValRS", Me.Text, "Select_Type_Abs", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message_spacial.Select_Type_Abs, MsgBoxStyle.Information, Me.Text)
            cboWorkingStatus.Focus()
            Exit Sub
        End If

        If IsNumeric(txtAmt.Text.Trim) = False Then
            'MsgBox("¡ÃØ³Ò»éÍ¹µÑÇàÅ¢ãËé¶Ù¡µéÍ§´éÇÂ", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmPrivilegeValRS", Me.Text, "Check_Number", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.correct_number, MsgBoxStyle.Information, Me.Text)
            txtAmt.Focus()
            Exit Sub
        End If


        Try
            strSQL = "Update TimePrivilege_Val Set " &
                                " Year = '" & txtYearly.Text.Trim & "'," &
                                " Code = '" & txtCode.Text.Trim & "'," &
                                " ValCode = '" & lblValCode.Text.Trim & "'," &
                                " Amt = " & txtAmt.Text &
                    " Where ID = " & lblId.Text
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim dCmd As New SqlCommand
        Dim strSQL As String

        If txtName.Text.Trim = "" Then
            'MsgBox("¡ÃØ³Ò»éÍ¹ÃËÑÊ¾¹Ñ¡§Ò¹´éÇÂ", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmPrivilegeValRS", Me.Text, "Insert_EmpID", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.Insert_EmpID, MsgBoxStyle.Information, Me.Text)
            txtCode.Focus()
            Exit Sub
        End If

        Try
            strSQL = "Delete From TimePrivilege_Val " &
              " Where id = " & lblId.Text.Trim
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub txtTime_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub LoadWorkingStatus()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select Code,Description,Pay from TimeWorkingstatus Order By Description"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            cboWorkingStatus.Properties.Items.Clear()
            Dim I As Integer
            For I = 0 To .Rows.Count - 1
                cboWorkingStatus.Properties.Items.Add(.Rows(I).Item("Description"))
            Next
            Ds.Clear()
        End With
    End Sub

    Private Sub cboWorkingStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboWorkingStatus.SelectedIndexChanged
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select Code,Description,Pay " &
                " from TimeWorkingstatus " &
                " Where Description = '" & cboWorkingStatus.Text.Trim & "' " &
                " Order By Description"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            Dim I As Integer
            lblValCode.Text = ""
            For I = 0 To .Rows.Count - 1
                lblValCode.Text = .Rows(I).Item("Code")
            Next
            Ds.Clear()
        End With
    End Sub

    Private Sub lstVacation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstVacation.SelectedIndexChanged

    End Sub


    'Private Sub rdSpa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    txtAmt.Enabled = True
    'End Sub

    'Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Call LoadVacation()
    'End Sub



    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btnshowHide.Click
        'If pnlBottom.Visible = True Then
        '    btnshowHide.Text = "ย่อรายการ"
        '    ' ขยาย
        '    pnlBottom.Visible = False

        '    Dim s As Size
        '    s.Width = Pnldetail.Size.Width
        '    s.Height = Me.Height - Pnldetail.Top - 10
        '    Pnldetail.Size = s
        'Else
        '    btnshowHide.Text = "ขยายรายการ"

        '    ' ย่อ
        '    Dim s As Size
        '    s.Width = Pnldetail.Size.Width
        '    s.Height = Me.Height - Pnldetail.Top - pnlBottom.Size.Height - 50
        '    Pnldetail.Size = s

        '    pnlBottom.Visible = True
        'End If
    End Sub

    'Private Sub GvVacation_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GvVacation.CustomDrawCell
    '    If e.Column.Name = "colrow" Then
    '        If e.RowHandle < -1 Then
    '            e.DisplayText = "0"
    '        Else
    '            e.DisplayText = (e.RowHandle + 1).ToString
    '        End If
    '    End If

    'End Sub

    Private Sub GcVacation_Click(sender As Object, e As EventArgs) Handles GcVacation.Click

    End Sub

    Private Sub GvVacation_DoubleClick(sender As Object, e As EventArgs) Handles GvVacation.DoubleClick
        Try
            Dim gv As GridView = CType(sender, GridView)

            '   If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "Code")) = True Then Exit Sub

            lblId.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Id")
            txtCode.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Code")
            cboWorkingStatus.SelectedItem = gv.GetRowCellValue(gv.FocusedRowHandle, "Description")
            txtAmt.EditValue = gv.GetRowCellValue(gv.FocusedRowHandle, "Amt")


            txtCode.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Code")
            Call txtCode_LostFocus(Me, System.EventArgs.Empty)
            Call EnaCmd(False, True, True)
        Catch ex As Exception

        End Try
    End Sub
End Class