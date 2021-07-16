Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports TimeAttendance.utils

Public Class frmSetBarcode

    Private Sub frmSetBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
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

    Private Sub frmSetBarcode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadDepartment()
        Call LoadCompany()
        Call LoadEmp()
        Call LoadEmpdev()

        If ComId <> "" Then
            cboCompany.Enabled = False
            cboCompany.SelectedItem = ComName
        End If
    End Sub

    Private Sub LoadEmp()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        Dim arrData() As String
        Dim List As ListViewItem

        strSQL = "select E.Code,E.Fname,E.Lname, " &
                        " Barcode = Isnull(B.Barcode,'')," &
                        " Department = Isnull(D.Department,'')" &
                " From Emp E Left Join EmpSetBarcode B " &
                                " On E.Code = B.Code " &
                            " Left Join Department D " &
                                " On E.DeptID = D.DeptId " &
                            " Left Join Company_sub cs" &
                                " on E.CompanyID = cs.CompanyID " &
                " Where WorkStatus = 'W' "

        If cboCompany.SelectedIndex > 0 Then
            strSQL &= " and isnull(e.CompanyId,'') = '" & GetData.GetCompanyId(cboCompany.Text.Trim) & "'"
        End If


        If txtEmpNameSearch.Text.Trim <> "" Then
            strSQL &= " and (E.Fname Like '%" & txtEmpNameSearch.Text.Trim & "%' Or " &
                            " E.LName Like '%" & txtEmpNameSearch.Text.Trim & "%')"
        End If

        If cboDepartment.SelectedIndex > 0 Then
            strSQL &= " and E.DeptID = '" & lblDeptID.Text.Trim & "'"
        End If

        strSQL &= " Order By E.DeptID,E.Code"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            'lstEmp.BeginUpdate()
            If .Rows.Count = 0 Then
                lstEmp.Items.Clear()
            Else
                lstEmp.Items.Clear()
                For Each dr As DataRow In .Rows
                    arrData = New String() {lstEmp.Items.Count + 1,
                                            dr("Code"),
                                            dr("Fname"),
                                            dr("LName"),
                                            dr("Barcode"),
                                            dr("Department")}
                    List = New ListViewItem(arrData)
                    lstEmp.Items.Add(List)
                Next
            End If
            'lstEmp.EndUpdate()
        End With
    End Sub

    Private Sub LoadEmpdev()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "select E.Code,E.Fname,E.Lname, " &
                        " Barcode = Isnull(B.Barcode,'')," &
                        " Department = Isnull(D.Department,'')" &
                " From Emp E Left Join EmpSetBarcode B " &
                                " On E.Code = B.Code " &
                            " Left Join Department D " &
                                " On E.DeptID = D.DeptId " &
                            " Left Join Company_sub cs" &
                                " on E.CompanyID = cs.CompanyID " &
                " Where WorkStatus = 'W' "

        If cboCompany.SelectedIndex > 0 Then
            strSQL &= " and isnull(e.CompanyId,'') = '" & GetData.GetCompanyId(cboCompany.Text.Trim) & "'"
        End If


        If txtEmpNameSearch.Text.Trim <> "" Then
            strSQL &= " and (E.Fname Like '%" & txtEmpNameSearch.Text.Trim & "%' Or " &
                            " E.LName Like '%" & txtEmpNameSearch.Text.Trim & "%')"
        End If

        If cboDepartment.SelectedIndex > 0 Then
            strSQL &= " and E.DeptID = '" & lblDeptID.Text.Trim & "'"
        End If

        strSQL &= " Order By E.DeptID,E.Code"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")

        GcEmpbarcode.DataSource = Ds
        GcEmpbarcode.DataMember = "Data"
    End Sub

    Private Sub LoadDepartment()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "Select DeptID,Department from Department Order By DeptID"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                cboDepartment.Items.Clear()
                cboDepartment.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            Else
                cboDepartment.Items.Clear()
                cboDepartment.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
                For Each dr As DataRow In .Rows
                    cboDepartment.Items.Add(dr("Department"))
                Next
            End If
        End With
    End Sub

    Function GetDeptID(ByVal Department As String) As String
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select DeptID" & _
                " From Department " & _
                " Where Department = '" & Department.Trim & "'"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("DeptID")
            End If
        End With
    End Function

    Function BarcodeIsExist(ByVal Code As String, ByVal Barcode As String) As Boolean
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select Barcode" & _
                " From EmpSetBarcode " & _
                " Where Barcode = '" & Barcode.Trim & "' and " & _
                        " Code <> '" & Code.Trim & "'"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        End With
    End Function

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call LoadEmp()
    End Sub

    Private Sub cboDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepartment.SelectedIndexChanged, cboCompany.SelectedIndexChanged
        lblDeptID.Text = GetDeptID(cboDepartment.Text.Trim)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.LostFocus
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select EmpName = E.Fname + '   ' + E.Lname, " &
                        " Barcode = Isnull(B.Barcode,'')" &
                " From Emp E Left Join EmpSetBarcode B " &
                                " On E.Code = B.Code " &
                " Where E.Code = '" & txtCode.Text.Trim & "'"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                lblEmpName.Text = ""
                txtBarcode.Text = ""
            Else
                lblEmpName.Text = .Rows(0).Item("EmpName")
                txtBarcode.Text = .Rows(0).Item("Barcode")
                txtBarcode.Text.Trim()
                txtBarcode.Focus()
            End If
        End With
    End Sub



    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If lblEmpName.Text.Trim = "" Then
            'MsgBox("กรุณาป้อนรหัสพนักงานด้วย", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmSetBarcodeRS", Me.Text, "Insert_EmpID", MessageBoxIcon.Information)
            txtCode.Focus()
            Exit Sub
        End If
        If txtBarcode.Text.Trim = "" Then
            'MsgBox("กรุณาป้อน Barcode ด้วย", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmSetBarcodeRS", Me.Text, "Insert_Brcode", MessageBoxIcon.Information)
            txtBarcode.Focus()
            Exit Sub
        End If

        If BarcodeIsExist(txtCode.Text, txtBarcode.Text.Trim) = True Then
            'MsgBox("Barcode นี้ถูกใช้แล้ว กรุณาเปลี่ยนใหม่", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmSetBarcodeRS", Me.Text, "Barcode_Use", MessageBoxIcon.Information)
            txtBarcode.Focus()
            Exit Sub
        End If

        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            strSQL = "Delete From EmpSetBarcode " &
                    " Where Code = '" & txtCode.Text.Trim & "'"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            strSQL = "Insert Into EmpSetBarcode(Code,Barcode) Values(" &
                        "'" & txtCode.Text.Trim & "'," &
                        "'" & txtBarcode.Text.Trim & "')"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try
        Call LoadEmp()
        Call LoadEmpdev()
        Call ClearDATA()
    End Sub

    Private Sub ClearDATA()
        txtCode.Text = ""
        lblEmpName.Text = ""
        txtBarcode.Text = ""
    End Sub

    Private Sub lstEmp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEmp.SelectedIndexChanged
        With lstEmp
            If .SelectedItems.Count = 0 Then Exit Sub
            txtCode.Text = .SelectedItems(0).SubItems(1).Text.Trim
            Call txtCode_LostFocus(Me, System.EventArgs.Empty)
        End With
    End Sub

    Private Sub btnAutoGenBarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoGenBarcode.Click
        'If MsgBox("คุณต้องการใช้รหัส Barcode เหมือนกับ รหัสพนักงานจริงๆหรือไม่", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then
        '    Exit Sub
        'End If

        If MsgManager.ConfirmDialog(Me, "frmSetBarcodeRS", Me.Text, "Barcode_Same_EmpCode",
        MessageBoxIcon.Information) = DialogResult.Cancel Then Exit Sub


        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            strSQL = "Delete From EmpSetBarcode "
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            strSQL = "Insert Into EmpSetBarcode(Code,Barcode) " &
                    " Select Code,Code From Emp "
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try
        MsgManager.ShowDialog(Me, "frmSetBarcodeRS", Me.Text, "Gen_Barcode_Complete", MessageBoxIcon.Information)
        'MsgBox("Gen Barcode เรียบร้อยแล้ว", MsgBoxStyle.Information, Me.Text)
        Call btnSearch_Click(Me, System.EventArgs.Empty)
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
            Dim I As Integer
            For I = 0 To .Rows.Count - 1
                cboCompany.Items.Add(.Rows(I).Item("CompanyName"))
            Next
            Ds.Clear()
            cboCompany.SelectedIndex = 0
        End With
    End Sub

    Private Sub Gvempbarcode_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles Gvempbarcode.CustomDrawCell
        If e.Column.Name = "colrow" Then
            If e.RowHandle < -1 Then
                e.DisplayText = "0"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If

    End Sub

    Private Sub txtCode_EditValueChanged(sender As Object, e As EventArgs) Handles txtCode.EditValueChanged

    End Sub

    Private Sub txtBarcode_EditValueChanged(sender As Object, e As EventArgs) Handles txtBarcode.EditValueChanged

    End Sub

    Private Sub txtCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtBarcode.Focus()
            txtBarcode.SelectAll()
        End If
    End Sub

    Private Sub txtBarcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBarcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnSave.Focus()
        End If
    End Sub
End Class