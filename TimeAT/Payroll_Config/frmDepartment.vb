Imports TimeAttendance.utils
Imports System.IO
Imports System.Globalization

Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmDepartment
    Protected dbMgr As New DBManager
    Protected dbConnStr As String = dbMgr.getConnString

    Dim LockID As Boolean = True

    Private Sub frmDepartment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadData()
        '  Call ClearData(True)
        btn_clear_Click(e, EventArgs.Empty)


        Call SearchData.LoadDivision(Me, cboDivision, False)
    End Sub

    'Public Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
    '    Call LoadData()
    '    Call ClearData(True)
    '    Call EnaCmd(True, False, False)
    '    txtDepartment.Focus()
    'End Sub

    Public Sub EnaCmd(ByVal Add As Boolean, ByVal Edit As Boolean, ByVal Delete As Boolean)
        btn_save.Enabled = Add
        btn_Edit.Enabled = Edit
        btn_del.Enabled = Delete
    End Sub

    Private Sub lstData_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        'If lstData.SelectedItems.Count = 0 Then Exit Sub
        'Call LoadItem(lstData.SelectedItems(0).SubItems(1).Text.Trim)
        'TabControl1.SelectedTabIndex = 1
    End Sub


    Private Sub lstData_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ClearData(ByVal ClearAll As Boolean)
        If ClearAll = True Then
            '  txtDeptId.Text = AutoId()
        End If
        txtDepartment.Text = ""

    End Sub

    Private Sub LoadData()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        strSQL = "Select ROW_NUMBER() OVER(ORDER BY div.division,DeptId) as row" &
                        " ,isnull(div.division,'') as Division" &
                        " ,dept.* " &
                " from Department dept " &
                        " left join division div " &
                            " on dept.divid = div.divid " &
                " Order by div.division,DeptId"
        '   
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")


        GcHoliday.DataSource = Ds
        GcHoliday.DataMember = "data"


    End Sub

    Private Sub LoadItem(ByVal ID As String)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        Dim Data As New ArrayList
        Dim strType As String = ""

        Data.Clear() : strType = ""
        Data.Add(ID) : strType &= "T"

        strSQL = "Select ROW_NUMBER() OVER(ORDER BY DeptId) as row" &
                        " ,isnull(div.division,'') as Division" &
                        " ,dept.* " &
                " from Department dept " &
                        " left join division div " &
                            " on dept.divid = div.divid " &
                " Where DeptId = @P1"
        Try
            '   
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
            Da.SelectCommand = dCmd
            Da.Fill(Ds, "data")
            '  
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Me.Text)
            Exit Sub
        End Try

        With Ds.Tables("Data")
            If .Rows.Count = 0 Then
                Call ClearData(False)
                Call EnaCmd(True, False, False)
                Exit Sub
            End If

            Call EnaCmd(False, True, True)

            Dim dr As DataRow = .Rows(0)

            cboDivision.SelectedIndex = 0
            cboDivision.SelectedText = dr("Division")
            txtDeptId.Text = dr("DeptId")
            txtDepartment.Text = dr("Department")

        End With

    End Sub

    Private Sub txtDivId_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Call LoadItem(txtDeptId.Text.Trim)
    End Sub

    Function IsID_IsExist(ByVal ID As String) As Boolean
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        Dim Data As New ArrayList
        Dim strType As String = ""

        Data.Clear() : strType = ""
        Data.Add(ID) : strType &= "T"

        strSQL = "Select * from Department" &
                " Where DeptId = @P1"
        '  
        db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        '  

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        End With
    End Function


    Function AutoId() As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        strSQL = "Select Max(DeptId) as maxId From Department"

        '   
        db.ExecuteCommand(Conn, dCmd, strSQL)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        '   

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return "001"
            Else
                Dim dr As DataRow = .Rows(0)
                Return Format(dr("MaxID") + 1, "000")
            End If
        End With
    End Function

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If txtDeptId.Text.Trim = "" Then
            'MsgBox("กรุณาป้อนวันหยุดด้วย", MsgBoxStyle.Information, Me.Text)

            '  MsgBox("กรุุณาป้อนรหัสแผนก", MsgBoxStyle.Information, Me.Text)
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblDeptId.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtDeptId.Focus()
            txtDeptId.SelectAll()
            Exit Sub
        End If

        If txtDepartment.Text.Trim = "" Then
            'MsgBox("กรุณาป้อนวันหยุดด้วย", MsgBoxStyle.Information, Me.Text)

            '  MsgBox("กรุุณาป้อนชื่อแผนก", MsgBoxStyle.Information, Me.Text)
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(txtDepartment.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtDepartment.Focus()
            txtDepartment.SelectAll()
            Exit Sub
        End If

        Dim divid As String = GetData.GetDivisionId(cboDivision.Text.Trim)

        If divid = "" Then
            '   MsgBox("กรุุณาเลือกฝ่าย", MsgBoxStyle.Information, Me.Text)
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblDivision.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            cboDivision.Focus()
            Exit Sub
        End If

        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Tn As SqlTransaction

        '     
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try

            strSQL = "Insert Into Department(divid,DeptId,Status,Department,LastUpdate) Values(" &
                    " '" & divid & "'," &
                    " '" & txtDeptId.Text.Trim & "'," &
                    " '' ," &
                    " '" & txtDepartment.Text.Trim & "'," &
                    " getdate())"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            Tn.Commit()
            '     
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)

            Exit Sub
        End Try
        Call btn_clear_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub GcHoliday_Click(sender As Object, e As EventArgs) Handles GcHoliday.Click

    End Sub

    Private Sub GvHoliday_DoubleClick(sender As Object, e As EventArgs) Handles GvHoliday.DoubleClick
        Try
            Dim gv As GridView = CType(sender, GridView)

            '   If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "Code")) = True Then Exit Sub
            cboDivision.SelectedIndex = -1
            cboDivision.SelectedItem = gv.GetRowCellValue(gv.FocusedRowHandle, "Division").ToString.Trim
            txtDeptId.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "DeptId")
            txtDepartment.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Department")

            Call EnaCmd(False, True, True)

            txtDeptId.Enabled = False
            txtDepartment.SelectAll()
            txtDepartment.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Call EnaCmd(True, False, False)
        Call LoadData()
        txtDepartment.Enabled = True
        txtDeptId.Enabled = True
        txtDeptId.Text = ""
        txtDepartment.Text = ""
        'txtDeptId.Focus()
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        If txtDepartment.Text.Trim = "" Then
            'MsgBox("กรุณาป้อนวันหยุดด้วย", MsgBoxStyle.Information, Me.Text)

            '      MsgBox("กรุุณาป้อนชื่อแผนก", MsgBoxStyle.Information, Me.Text)
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblDepartment.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtDepartment.Focus()
            txtDepartment.SelectAll()
            Exit Sub
        End If

        Dim divid As String = GetData.GetDivisionId(cboDivision.Text.Trim)

        If divid = "" Then
            '  MsgBox("กรุุณาเลือกฝ่าย", MsgBoxStyle.Information, Me.Text)
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblDivision.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            cboDivision.Focus()
            Exit Sub
        End If

        Dim dCmd As New SqlCommand
        Dim strSQL As String

        '   
        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            strSQL = "update Department set Department='" & txtDepartment.Text.Trim & "'" &
                                            ",divid = '" & divid & "'" &
                    " Where deptId='" & txtDeptId.Text.Trim & "'"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            Tn.Commit()

            '    
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            '  
            Exit Sub
        End Try

        '   MsgBox("แก้ไขข้อมูลเรียบร้อย", MsgBoxStyle.Information, "แก้ไข")
        MsgBox(My.Resources.res_warning_message.edit_complete, MsgBoxStyle.Information, Me.Text)
        Call LoadData()
        Call btn_clear_Click(Me, System.EventArgs.Empty)

    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        '  If MsgBox("ต้องการลบข้อมูล แผนกหรือไม่", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "แก้ไข") = MsgBoxResult.No Then Exit Sub
        If MsgBox(My.Resources.res_warning_message.Confirm_Del, MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then Exit Sub

        Dim dCmd As New SqlCommand
        Dim strSQL As String

        '    
        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            strSQL = "delete from Department where deptid='" & txtDeptId.Text.Trim & "'"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            Tn.Commit()

            '  
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            '    
            Exit Sub
        End Try

        Call LoadData()
        Call btn_clear_Click(Me, System.EventArgs.Empty)

    End Sub

    Private Sub txtDepartment_EditValueChanged(sender As Object, e As EventArgs) Handles txtDepartment.EditValueChanged

    End Sub

    Private Sub txtDepartment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDepartment.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If btn_save.Enabled = True Then
                btn_save.Focus()
            Else
                btn_Edit.Focus()
            End If
        End If
    End Sub

    Private Sub XtraTabControl1_Click(sender As Object, e As EventArgs)

    End Sub
End Class