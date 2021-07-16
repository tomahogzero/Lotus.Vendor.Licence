Imports TimeAttendance.utils
Imports System.IO
Imports System.Globalization

Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmDivision
    Protected dbMgr As New DBManager
    Protected dbConnStr As String = dbMgr.getConnString

    Dim LockID As Boolean = True

    Private Sub frmCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadData()
        '  Call ClearData(True)
        btn_clear_Click(e, EventArgs.Empty)

    End Sub

    Public Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txtDivid.Text.Trim = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "ID_IsBlank", MessageBoxIcon.Information)
            txtDivid.Focus()
            Exit Sub
        End If

        If IsID_IsExist(txtDivid.Text.Trim) = True Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "ID_IsExist", MessageBoxIcon.Information)
            txtDivid.Focus()
            Exit Sub
        End If

        If txtDivision.Text.Trim = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Name_IsBlank", MessageBoxIcon.Information)
            txtDivision.Focus()
            Exit Sub
        End If

        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList

        Data.Clear() : strType = ""
        Data.Add(txtDivid.Text.Trim) : strType &= "T"
        Data.Add(txtDivision.Text.Trim) : strType &= "T"

        strSQL = "Insert Into Division(DivId,Division) Values " &
                            " (@P1,@P2)"
        Try
            '   
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
            ' 
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Me.Text)
            Exit Sub
        End Try

        MsgManager.ShowDialog(Me, "Messages", Me.Text, "Save_Complete", MessageBoxIcon.Information)

        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Public Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txtDivid.Text.Trim = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "ID_IsBlank", MessageBoxIcon.Information)
            txtDivid.Focus()
            Exit Sub
        End If

        If txtDivision.Text.Trim = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Name_IsBlank", MessageBoxIcon.Information)
            txtDivision.Focus()
            Exit Sub
        End If

        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList

        Data.Clear() : strType = ""
        Data.Add(txtDivid.Text.Trim) : strType &= "T"
        Data.Add(txtDivision.Text.Trim) : strType &= "T"

        strSQL = "Update Division Set Division = @P2 " &
                " Where DivID = @P1 "

        Try
            '  
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
            '  
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Me.Text)
            Exit Sub
        End Try

        MsgManager.ShowDialog(Me, "Messages", Me.Text, "Edit_Complete", MessageBoxIcon.Information)

        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Public Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If MsgManager.ConfirmDialog(Me, "Messages", Me.Text, "Del_Confirm_Msg", MessageBoxIcon.Information) = DialogResult.Cancel Then Exit Sub

        If txtDivid.Text.Trim = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "ID_IsBlank", MessageBoxIcon.Information)
            txtDivid.Focus()
            Exit Sub
        End If

        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList

        Data.Clear() : strType = ""
        Data.Add(txtDivid.Text.Trim) : strType &= "T"

        strSQL = "Delete From Division " &
                " Where DivId = @P1 "

        Try
            '  
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
            '  
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Me.Text)
            Exit Sub
        End Try

        MsgManager.ShowDialog(Me, "Messages", Me.Text, "Del_Complete", MessageBoxIcon.Information)

        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Public Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Call LoadData()
        Call ClearData(True)
        '  Call EnaCmd(True, False, False)
        txtDivision.Focus()
    End Sub


    Private Sub lstData_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ClearData(ByVal ClearAll As Boolean)
        If ClearAll = True Then
            txtDivid.Text = AutoId()
        End If
        txtDivision.Text = ""
    End Sub

    Private Sub LoadData()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        strSQL = "Select ROW_NUMBER() OVER(ORDER BY DivId) as row,* from Division Order by DivId"
        '   
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")


        GcDivision.DataSource = Ds
        GcDivision.DataMember = "data"

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

        strSQL = "Select * from Division " &
                " Where DivId = @P1"
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
                '  Call EnaCmd(True, False, False)
                Exit Sub
            End If

            ' Call EnaCmd(False, True, True)

            Dim dr As DataRow = .Rows(0)
            txtDivid.Text = dr("DivId")
            txtDivision.Text = dr("Division")
        End With

    End Sub

    Private Sub txtDivId_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDivid.LostFocus
        Call LoadItem(txtDivid.Text.Trim)
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

        strSQL = "Select * from Division" &
                " Where DivId = @P1"
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

    Private Sub txtDivId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Function AutoId() As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        strSQL = "Select Max(DivId) as maxId From Division"

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

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txtDivid.Text.Trim = "" Then
            'MsgBox("กรุณาป้อนวันหยุดด้วย", MsgBoxStyle.Information, Me.Text)

            '   MsgBox("กรุุณาป้อนรหัสฝ่าย", MsgBoxStyle.Information, "ป้อน")
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblDivid.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtDivid.Focus()
            txtDivid.SelectAll()
            Exit Sub
        End If

        If txtDivision.Text.Trim = "" Then
            'MsgBox("กรุณาป้อนวันหยุดด้วย", MsgBoxStyle.Information, Me.Text)

            '   MsgBox("กรุุณาป้อนชื่อฝ่าย", MsgBoxStyle.Information, "ป้อน")
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblDivision.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtDivision.Focus()
            txtDivision.SelectAll()
            Exit Sub
        End If

        If IsID_IsExist(txtDivid.Text.Trim) = True Then
            '    MsgManager.ShowDialog(Me, "Messages", Me.Text, "ID_IsExist", MessageBoxIcon.Information)
            '  MsgBox(My.Resources.res_warning_message.Same_data, MsgBoxStyle.Information, Me.Text)
            MsgBox(String.Format(My.Resources.res_warning_message.Same_data, Replace(lblDivid.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtDivid.Focus()
            Exit Sub
        End If



        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Tn As SqlTransaction

        '    
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try

            strSQL = "Insert Into Division(Divid,Division) Values(" &
                    " '" & txtDivid.Text.Trim & "'," &
                    " '" & txtDivision.Text.Trim & "')"
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
        Call btn_clear_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        Dim dCmd As New SqlCommand
        Dim strSQL As String

        '  
        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            strSQL = "update Division set Division='" & txtDivision.Text.Trim & "'" &
                    " Where DivId='" & txtDivid.Text.Trim & "'"
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
        '
        '    MsgBox("แก้ไขข้อมูลเรียบร้อย", MsgBoxStyle.Information, "แก้ไข")
        MsgBox(My.Resources.res_warning_message.edit_complete, MsgBoxStyle.Information, Me.Text)
        Call LoadData()
        Call btn_clear_Click(Me, System.EventArgs.Empty)

    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        '   If MsgBox("ต้องการลบข้อมูล แผนกหรือไม่", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "แก้ไข") = MsgBoxResult.No Then Exit Sub
        If MsgBox(My.Resources.res_warning_message.Confirm_Del, MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then Exit Sub

        Dim dCmd As New SqlCommand
        Dim strSQL As String

        '   
        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            strSQL = "delete from Division where DivId='" & txtDivid.Text.Trim & "'"
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

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Call EnaCmd(True, False, False)
        Call LoadData()
        txtDivision.Enabled = True
        txtDivid.Enabled = True
        txtDivid.Text = ""
        txtDivision.Text = ""
        txtDivid.Focus()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Public Sub EnaCmd(ByVal Add As Boolean, ByVal Edit As Boolean, ByVal Delete As Boolean)
        btn_save.Enabled = Add
        btn_Edit.Enabled = Edit
        btn_del.Enabled = Delete
    End Sub

    Private Sub GcDivision_Click(sender As Object, e As EventArgs) Handles GcDivision.Click

    End Sub

    Private Sub GvDivision_DoubleClick(sender As Object, e As EventArgs) Handles GvDivision.DoubleClick
        Try
            Dim gv As GridView = CType(sender, GridView)

            '   If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "Code")) = True Then Exit Sub

            txtDivid.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "DivId")
            txtDivision.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Division")

            Call EnaCmd(False, True, True)

            txtDivid.Enabled = False
            txtDivision.SelectAll()
            txtDivision.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDivision_EditValueChanged(sender As Object, e As EventArgs) Handles txtDivision.EditValueChanged

    End Sub

    Private Sub txtDivision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDivision.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If btn_save.Enabled = True Then
                btn_save.Focus()
            Else
                btn_Edit.Focus()
            End If
        End If
    End Sub
End Class