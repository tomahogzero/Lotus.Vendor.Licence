Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports TimeAttendance.utils

Public Class frmHolidayYear_New

    Private Sub frmHolidayYear_New_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        fHolidayYear = Nothing
    End Sub

    Private Sub frmHolidayYear_New_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GcHoliday.DataSource = Nothing

        txtyear.Text = Date.Now.Year
        Call ClearData()
        '   Call LoadData()
        Call Loaddatadev()
        Call EnaCmd(True, False, False)
    End Sub

    Private Sub ClearData()
        txtDate.DateTime = Nothing
        txtDate.Text = ""
        txtDescription.Text = ""
        txtRemark.Text = ""
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
        Dim Year As Integer
        Dim List As New ListViewItem
        Dim arrData() As String
        If IsNumeric(txtyear.Text.Trim) = False Then
            Year = 0
        Else
            Year = txtyear.Text.Trim
        End If

        strSQL = "Select * From TimeHolidayYear"
        If rdYear.Checked = True Then
            strSQL &= " Where Year([Date]) = " & Year
        End If
        strSQL &= " Order By [Date]"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            Dim I As Integer
            lstHoliday.Items.Clear()
            For I = 0 To .Rows.Count - 1
                arrData = New String() {I + 1,
                                        Format(.Rows(I).Item("Date"), "dd/MM/yyyy"),
                                        .Rows(I).Item("Description"),
                                        .Rows(I).Item("Remark")}
                List = New ListViewItem(arrData)
                lstHoliday.Items.Add(List)
            Next
            Ds.Clear()
        End With
    End Sub

    Private Sub Loaddatadev()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim Year As Integer

        If IsNumeric(txtyear.Text.Trim) = False Then
            Year = 0
        Else
            Year = txtyear.Text.Trim
        End If

        strSQL = "Select ROW_NUMBER() OVER(ORDER BY [Date]) as row,*  " &
                  " From TimeHolidayYear"
        If rdYear.Checked = True Then
            strSQL &= " Where Year([Date]) = " & Year
        End If
        strSQL &= " Order By [Date]"


        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")

        GcHoliday.DataSource = Ds
        GcHoliday.DataMember = "Data"
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If IsDate(ConvertDate(txtDate.Text)) = False Then
            MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
            txtDate.Focus()
            txtDate.SelectAll()
            Exit Sub
        End If
        If txtDescription.Text.Trim = "" Then
            MsgBox(My.Resources.res_warning_message_spacial.Check_Holiday, MsgBoxStyle.Information, Me.Text)
            txtDescription.Focus()
            txtDescription.SelectAll()
            Exit Sub
        End If

        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            strSQL = "Delete From TimeHolidayYear" &
                    " Where Convert(nVarchar(10),[Date],111) = '" & ConvertDate(txtDate.Text.Trim) & "'"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            strSQL = "Insert Into TimeHolidayYear([Date],Description,Remark) Values(" &
                    " '" & ConvertDate(txtDate.Text.Trim) & "'," &
                    " '" & txtDescription.Text.Trim & "'," &
                    " '" & txtRemark.Text.Trim & "')"
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

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call ClearData()
        '     Call LoadData()
        Call Loaddatadev()



        txtDate.Focus()
        txtDate.SelectAll()
        Call EnaCmd(True, False, False)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            strSQL = "Delete From TimeHolidayYear" &
                    " Where Convert(nVarchar(10),[Date],111) = '" & ConvertDate(txtDate.Text.Trim) & "'"
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

    Private Sub txtDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.LostFocus
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select * From TimeHolidayYear" &
                " Where Convert(nVarchar(10),[Date],111) = '" & ConvertDate(txtDate.Text.Trim) & "'"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Call EnaCmd(True, False, False)
                Ds.Clear()
                Exit Sub
            End If
            txtDescription.Text = .Rows(0).Item("Description")
            txtRemark.Text = .Rows(0).Item("Remark")
            Ds.Clear()
            Call EnaCmd(False, True, True)
        End With
    End Sub



    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        '   Call LoadData()
        Call Loaddatadev()
    End Sub

    Private Sub rdYear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdYear.CheckedChanged
        '  Call LoadData()
        txtyear.Text = ""
        txtyear.Focus()
        Call Loaddatadev()
    End Sub

    Private Sub rdAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdAll.CheckedChanged
        '  Call LoadData()
        Call Loaddatadev()
    End Sub

    Private Sub lstHoliday_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstHoliday.DoubleClick
        With lstHoliday
            If .SelectedItems.Count = 0 Then Exit Sub
            txtDate.Text = .SelectedItems(0).SubItems(1).Text.Trim
            txtDescription.Text = .SelectedItems(0).SubItems(2).Text.Trim
            txtRemark.Text = .SelectedItems(0).SubItems(3).Text.Trim
            Call EnaCmd(False, True, True)
        End With
    End Sub

    Private Sub lstHoliday_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstHoliday.SelectedIndexChanged

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If IsDate(ConvertDate(txtDate.Text)) = False Then
            MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
            txtDate.Focus()
            txtDate.SelectAll()
            Exit Sub
        End If
        If txtDescription.Text.Trim = "" Then
            MsgBox(My.Resources.res_warning_message_spacial.Check_Holiday, MsgBoxStyle.Information, Me.Text)
            txtDescription.Focus()
            txtDescription.SelectAll()
            Exit Sub
        End If

        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            strSQL = "Delete From TimeHolidayYear" &
                    " Where Convert(nVarchar(10),[Date],111) = '" & ConvertDate(txtDate.Text.Trim) & "'"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            strSQL = "Insert Into TimeHolidayYear([Date],Description,Remark) Values(" &
                    " '" & ConvertDate(txtDate.Text.Trim) & "'," &
                    " '" & txtDescription.Text.Trim & "'," &
                    " '" & txtRemark.Text.Trim & "')"
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

    Private Sub GvHoliday_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GvHoliday.CustomDrawCell
        If e.Column.Name = "colrow" Then
            If e.RowHandle < -1 Then
                e.DisplayText = "0"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If

    End Sub

    Private Sub txtyear_EditValueChanged(sender As Object, e As EventArgs) Handles txtyear.EditValueChanged

    End Sub

    Private Sub txtyear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtyear.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnRefresh.Focus()
        End If
    End Sub

    Private Sub GvHoliday_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GvHoliday.ValidateRow

        Dim date_ As String = ""
        Dim Description As String = ""
        Dim Remark As String = ""


        '' เช็คกรณีที่ยังไม่ได้เลือกบิล Qu
        'If CLng(txtQUID.EditValue) < 1 Then
        '    MsgBox("กรุณาเปิดบิลใหม่ก่อนทำการป้อนรายการสินค้า", MsgBoxStyle.Information, "แจ้งให้ทราบ")
        '    txtQuotationNo.Focus()
        '    e.Valid = False
        '    Exit Sub
        'End If

        If GvHoliday.GetRowCellValue(e.RowHandle, "Date") Is DBNull.Value Then
            date_ = ""
        Else
            date_ = CStr(GvHoliday.GetRowCellValue(e.RowHandle, "Date"))
        End If

        If GvHoliday.GetRowCellValue(e.RowHandle, "Description") Is DBNull.Value Then
            Description = ""
        Else
            Description = CStr(GvHoliday.GetRowCellValue(e.RowHandle, "Description"))
        End If


        If GvHoliday.GetRowCellValue(e.RowHandle, "Remark") Is DBNull.Value Then
            Remark = ""
        Else
            Remark = CStr(GvHoliday.GetRowCellValue(e.RowHandle, "Remark"))
        End If






        '   เริ่มเช็คเงือนไขการบันทีก
        If date_ = "" Then
            SendKeys.Send("{ESC}")
            '  Call LoadData_ByQUID(GcQu, CLng(txtQUID.EditValue))  ' โหลด Sub
            e.Valid = False
            Exit Sub
        End If

        If Description = "" Then
            MsgBox("กรุณาป้อนวันหยุด", MsgBoxStyle.Exclamation, "ผิดพลาด")
            e.Valid = False
            Exit Sub
        End If



        'If productCode = "" Then
        '    '    MsgBox("กรุณาป้อนรหัสสินค้า", MsgBoxStyle.Exclamation, "ผิดพลาด")
        '    'GvQu.FocusedRowHandle = 1
        '    'GvQu.FocusedColumn = GvQu.VisibleColumns(1)
        '    'GvQu.ShowEditor()
        '    '  e.ErrorText = "กรุณาป้อนรหัสสินค้า"

        '    GvQu.DeleteRow(GvQu.FocusedRowHandle)
        '    Call SetFocusToNewItemRow()
        '    e.Valid = False
        '    Exit Sub
        'End If



        e.Valid = True ' ผ่านสามารถบันทึกได้

        If date_ <> "" And Description <> "" Then
            ' บันทึก ***********************************************************************************
            Dim dCmd As New SqlCommand
            Dim strSQL As String
            Dim Tn As SqlTransaction
            Tn = Conn.BeginTransaction
            dCmd.Transaction = Tn
            Try
                strSQL = "Delete From TimeHolidayYear" &
                    " Where Convert(nVarchar(10),[Date],111) = '" & ConvertDate(txtDate.Text.Trim) & "'"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()

                strSQL = "Insert Into TimeHolidayYear([Date],Description,Remark) Values(" &
                    " '" & ConvertDate(date_).Trim & "'," &
                    " '" & Description.Trim & "'," &
                    " '" & Remark.Trim & "')"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()

                Tn.Commit()
            Catch ex As Exception
                Tn.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
                Exit Sub
            End Try
        Else

            ' แก้ไข **************************************
            Dim dCmd As New SqlCommand
            Dim strSQL As String
            Dim Tn As SqlTransaction
            Tn = Conn.BeginTransaction
            dCmd.Transaction = Tn
            Try
                strSQL = "Delete From TimeHolidayYear" &
                        " Where Convert(nVarchar(10),[Date],111) = '" & ConvertDate(txtDate.Text.Trim) & "'"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()

                strSQL = "Insert Into TimeHolidayYear([Date],Description,Remark) Values(" &
                        " '" & ConvertDate(txtDate.Text.Trim) & "'," &
                        " '" & txtDescription.Text.Trim & "'," &
                        " '" & txtRemark.Text.Trim & "')"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()

                Tn.Commit()
            Catch ex As Exception
                Tn.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
                Exit Sub
            End Try

        End If
        ' โหลดข้อมูล

        'GvQu.FocusedRowHandle = 2
        'GvQu.FocusedColumn = GvQu.VisibleColumns(2)
        'GvQu.ShowEditor()

    End Sub



    'Private Sub gvHoliday_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GvHoliday.FocusedRowChanged
    '    Try
    '        txtDate.DateTime = Format(GvHoliday.GetRowCellValue(e.FocusedRowHandle, "Date"), "dd/MM/yyyy")
    '        txtDescription.Text = GvHoliday.GetRowCellValue(e.FocusedRowHandle, "Description").ToString
    '        txtRemark.Text = GvHoliday.GetRowCellValue(e.FocusedRowHandle, "Remark").ToString
    '        '  rowIndex = e.FocusedRowHandle
    '        '  lblTextFindProductCode.Text = GvQu.GetRowCellValue(e.FocusedRowHandle, "productCode").ToString
    '    Catch ex As Exception
    '        txtDate.Text = ""
    '        txtDescription.Text = ""
    '        txtRemark.Text = ""
    '        '   rowIndex = -2
    '    End Try

    'End Sub

    'Private Sub gvHoliday_FocusedRowLoaded(sender As Object, e As RowEventArgs) Handles GvHoliday.FocusedRowLoaded
    '    Try
    '        txtDate.DateTime = Format(GvHoliday.GetRowCellValue(e.RowHandle, "Date"), "dd/MM/yyyy")
    '        txtDescription.Text = GvHoliday.GetRowCellValue(e.RowHandle, "Description").ToString
    '        txtRemark.Text = GvHoliday.GetRowCellValue(e.RowHandle, "Remark").ToString
    '        '  rowIndex = e.RowHandle
    '    Catch ex As Exception
    '        txtDate.Text = ""
    '        txtDescription.Text = ""
    '        txtRemark.Text = ""
    '        '   rowIndex = -2
    '    End Try
    'End Sub

    'Private Sub gvHoliday_FocusedRowObjectChanged(sender As Object, e As FocusedRowObjectChangedEventArgs) Handles GvHoliday.FocusedRowObjectChanged
    '    Try
    '        txtDate.DateTime = Format(GvHoliday.GetRowCellValue(e.FocusedRowHandle, "Date"), "dd/MM/yyyy")
    '        txtDescription.Text = GvHoliday.GetRowCellValue(e.FocusedRowHandle, "Description").ToString
    '        txtRemark.Text = GvHoliday.GetRowCellValue(e.FocusedRowHandle, "Remark").ToString
    '        '    rowIndex = e.RowHandle
    '    Catch ex As Exception
    '        txtDate.Text = ""
    '        txtDescription.Text = ""
    '        txtRemark.Text = ""
    '    End Try

    'End Sub




    Private Sub GvHoliday_DoubleClick(sender As Object, e As EventArgs) Handles GvHoliday.DoubleClick
        Try
            Dim gv As GridView = CType(sender, GridView)

            '   If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "Code")) = True Then Exit Sub

            txtDate.EditValue = gv.GetRowCellValue(gv.FocusedRowHandle, "Date")
            txtDescription.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Description")
            txtRemark.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Remark")
            Call EnaCmd(False, True, True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GcHoliday_Click(sender As Object, e As EventArgs) Handles GcHoliday.Click

    End Sub

    Private Sub frmHolidayYear_New_Validated(sender As Object, e As EventArgs) Handles Me.Validated

    End Sub
End Class