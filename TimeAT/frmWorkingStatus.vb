Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports TimeAttendance.utils

Public Class frmWorkingStatus
    Private Sub ClearData()
        txtCode.Text = ""
        txtDescription.Text = ""
        txtRemark.Text = ""
        rdPay.Checked = True
    End Sub

    Private Sub EnaCmd(ByVal Add As Boolean, ByVal Edit As Boolean, ByVal Delete As Boolean)
        btnAdd.Enabled = Add
        btnEdit.Enabled = Edit
        btnDelete.Enabled = Delete
    End Sub

    Private Sub LoadData()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim List As New ListViewItem
        Dim arrData() As String

        strSQL = "Select * From TimeWorkingStatus" & _
                " Order by Code"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            Dim I As Integer
            lstWorkingStatus.Items.Clear()
            For I = 0 To .Rows.Count - 1
                Dim Pay As String
                Dim NoPay As String
                If .Rows(I).Item("Pay") = True Then
                    Pay = "/"
                    NoPay = ""
                Else
                    Pay = ""
                    NoPay = "/"
                End If
                arrData = New String() {I + 1,
                                        .Rows(I).Item("Code"),
                                        .Rows(I).Item("Description"),
                                        NoPay, Pay,
                                        .Rows(I).Item("Remark"),
                                        .Rows(I).Item("AttCode")}
                List = New ListViewItem(arrData)
                lstWorkingStatus.Items.Add(List)
            Next
            Ds.Clear()
        End With
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If txtCode.Text.Trim = "" Then
            'MsgBox("กรุณาป้อนรหัสด้วย", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmWorkingStatusRS", Me.Text, "Insert_ID", MessageBoxIcon.Information)
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblCode.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtCode.Focus()
            Exit Sub
        End If

        If txtDescription.Text.Trim = "" Then
            'MsgBox("กรุณาป้อนรายละเอียดด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmWorkingStatusRS", Me.Text, "Insert_Detail", MessageBoxIcon.Information)
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblDescription.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtDescription.Focus()
            txtDescription.SelectAll()
            Exit Sub
        End If

        'If cboAttCode.Text.Trim = "" Then
        '    MsgBox("กรุณาเลือก Code Link Payroll ด้วย", MsgBoxStyle.Information, Me.Text)
        '    cboAttCode.Focus()
        '    Exit Sub
        'End If

        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            strSQL = "Delete From TimeWorkingStatus" &
                    " Where Code = '" & txtCode.Text.Trim & "'"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            strSQL = "Insert Into TimeWorkingStatus(Code,Description,Remark,Pay,AttCode) Values(" &
                    " '" & txtCode.Text.Trim & "'," &
                    " '" & txtDescription.Text.Trim & "'," &
                    " '" & txtRemark.Text.Trim & "'," &
                    " " & IIf(rdPay.Checked = True, 1, 0) & "," &
                    " '" & cboAttCode.Text.Trim & "')"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
        Call btnClear_Click(Me, System.EventArgs.Empty)
        '319007
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call ClearData()
        '   Call LoadData()
        Call LoadDataDev()
        Call EnaCmd(True, False, False)
        txtCode.Focus()
    End Sub

    Private Sub frmWorkingStatus_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        fWorkingStatus = Nothing
    End Sub

    Private Sub frmWorkingStatus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        'If Asc(e.KeyChar) = 13 Then
        '    'If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
        '    If TypeOf Me.ActiveControl Is TextBox Then
        '        Dim tb As TextBox = DirectCast(Me.ActiveControl, TextBox)
        '        If tb.Multiline AndAlso tb.AcceptsReturn Then
        '            e.Handled = False
        '            Exit Sub
        '        End If
        '    End If
        '    e.Handled = True
        '    Dim oform As Form = Me.FindForm
        '    oform.SelectNextControl(oform.ActiveControl, True, True, True, True)
        '    oform.ActiveControl.Focus()
        'End If
    End Sub

    Private Sub frmWorkingStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GvWorkingStatus.Columns("AttCode").Visible = False
        Call ClearData()
        '  Call LoadData()
        Call LoadDataDev()
        Call LoadAttCode()
        Call EnaCmd(True, False, False)
    End Sub

    Private Sub LoadAttCode()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select Code from Attendant Order By RecOrder"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            Dim I As Integer
            cboAttCode.Items.Clear()
            cboAttCode.Items.Add("")
            For I = 0 To .Rows.Count - 1
                cboAttCode.Items.Add(.Rows(I).Item("Code"))
            Next
            Ds.Clear()
        End With
    End Sub

    Private Sub lstWorkingStatus_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstWorkingStatus.DoubleClick
        With lstWorkingStatus
            If .SelectedItems.Count = 0 Then Exit Sub
            txtCode.Text = .SelectedItems(0).SubItems(1).Text.Trim
            Call txtCode_LostFocus(Me, System.EventArgs.Empty)

            'cboAttCode.Text = .SelectedItems(0).SubItems(2).Text.Trim
            'txtDescription.Text = .SelectedItems(0).SubItems(3).Text.Trim
            'txtRemark.Text = .SelectedItems(0).SubItems(5).Text.Trim
            'If .SelectedItems(0).SubItems(4).Text.Trim = "/" Then
            '    rdPay.Checked = True
            'Else
            '    rdNoPay.Checked = True
            'End If
            Call EnaCmd(False, True, True)
        End With
    End Sub

    Private Sub lstWorkingStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstWorkingStatus.SelectedIndexChanged

    End Sub

    Private Sub txtCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.LostFocus

        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "Select * From TimeWorkingStatus tw Left Join  Emp E" &
                            " on tw.Code = E.Code " &
                " Where tw.Code = '" & txtCode.Text.Trim & "' "

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            If .Rows.Count = 0 Then
                txtDescription.Text = ""
                txtRemark.Text = ""
                rdPay.Checked = True
                cboAttCode.SelectedIndex = -1
                Call EnaCmd(True, False, False)
                Ds.Clear()
                Exit Sub
            End If
            txtDescription.Text = .Rows(0).Item("Description")
            txtRemark.Text = .Rows(0).Item("Remark")
            cboAttCode.SelectedItem = .Rows(0).Item("AttCode")
            If .Rows(0).Item("Pay") = 0 Then
                rdNoPay.Checked = True
            Else
                rdPay.Checked = True
            End If
            Call EnaCmd(False, True, True)
            Ds.Clear()
        End With

    End Sub



    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        If txtCode.Text.Trim = "" Then
            'MsgBox("กรุณาป้อนรหัสด้วย", MsgBoxStyle.Information, Me.Text)
            '    MsgManager.ShowDialog(Me, "frmWorkingStatusRS", Me.Text, "Insert_ID", MessageBoxIcon.Information)
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblCode.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtCode.Focus()
            Exit Sub
        End If

        If txtDescription.Text.Trim = "" Then
            'MsgBox("กรุณาป้อนรายละเอียดด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmWorkingStatusRS", Me.Text, "Insert_Detail", MessageBoxIcon.Information)
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblDescription.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtDescription.Focus()
            txtDescription.SelectAll()
            Exit Sub
        End If

        'If cboAttCode.Text.Trim = "" Then
        '    MsgBox("กรุณาเลือก Code Link Payroll ด้วย", MsgBoxStyle.Information, Me.Text)
        '    cboAttCode.Focus()
        '    Exit Sub
        'End If

        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn

        Try
            strSQL = "Delete From TimeWorkingStatus" &
                    " Where Code = '" & txtCode.Text.Trim & "' "
            'and   " & _
            '                        " Code In (Select Code From Emp Where CompanyID like '" & IIf(ComId.Trim = "", "%", ComId.Trim) & "')"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            strSQL = "Insert Into TimeWorkingStatus(Code,Description,Remark,Pay,AttCode) Values(" &
                    " '" & txtCode.Text.Trim & "'," &
                    " '" & txtDescription.Text.Trim & "'," &
                    " '" & txtRemark.Text.Trim & "'," &
                    " " & IIf(rdPay.Checked = True, 1, 0) & "," &
                    " '" & cboAttCode.Text.Trim & "')"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If txtCode.Text.Trim = "" Then
            '    MsgManager.ShowDialog(Me, "frmWorkingStatusRS", Me.Text, "Insert_ID", MessageBoxIcon.Information)
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblCode.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            'MsgBox("กรุณาป้อนรหัสด้วย", MsgBoxStyle.Information, Me.Text)
            txtCode.Focus()
            Exit Sub
        End If

        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn

        Try
            strSQL = "Delete From TimeWorkingStatus" &
                    " Where Code = '" & txtCode.Text.Trim & "' "
            'and " & _
            '                        " Code In (Select Code From Emp Where CompanyID like '" & IIf(ComId.Trim = "", "%", ComId.Trim) & "')"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cboAttCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAttCode.SelectedIndexChanged
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select Code,Description " & _
                " From Attendant " & _
                " Where Code = '" & cboAttCode.Text.Trim & "' " & _
                " Order By RecOrder"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            Dim I As Integer
            txtAttDescription.Text = ""
            For I = 0 To .Rows.Count - 1
                txtAttDescription.Text = .Rows(I).Item("Description")
            Next
            Ds.Clear()
        End With
    End Sub


    Private Sub LoadDataDev()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim List As New ListViewItem
        '    Dim arrData() As String

        strSQL = "Select ROW_NUMBER() OVER(ORDER BY Code) as row, Code,Description,Remark, " &
                            " Pay =case " &
                                    " when isnull(pay,0) = 0 then '/'  " &
                                    " Else ''  " &
                                    " End,  " &
                           " Nopay =case " &
                                " when isnull(pay,0) = 1 then '/'" &
                                " Else  ''  " &
                                " End," &
                          " AttCode  " &
                " from TimeWorkingStatus" &
                " Order by Code"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")


        GcWorkingStatus.DataSource = Ds
        GcWorkingStatus.DataMember = "Data"
    End Sub

    Private Sub GvHoliday_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GvWorkingStatus.CustomDrawCell
        If e.Column.Name = "colrow" Then
            If e.RowHandle < -1 Then
                e.DisplayText = "0"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If

    End Sub



    Private Sub GvWorkingStatus_DoubleClick(sender As Object, e As EventArgs) Handles GvWorkingStatus.DoubleClick
        Try
            Dim gv As GridView = CType(sender, GridView)

            '   If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "Code")) = True Then Exit Sub

            txtCode.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Code")
            txtDescription.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Description")
            txtRemark.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Remark")

            'If gv.GetRowCellValue(gv.FocusedRowHandle, "Pay") = 0 Then
            '    rdNoPay.Checked = True
            'Else
            '    rdPay.Checked = True
            'End If

            txtCode.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Code")
            Call txtCode_LostFocus(Me, System.EventArgs.Empty)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GcWorkingStatus_Click(sender As Object, e As EventArgs) Handles GcWorkingStatus.Click

    End Sub
End Class