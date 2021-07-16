'Imports TimeAttendance.utils
Imports TimeAttendance.utils
Imports System.IO
Imports System.Globalization

Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmPermission
    Protected dbMgr As New DBManager
    Protected dbConnStr As String = dbMgr.getConnString
    Private Sub frmPermission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call LoadData()
        Call Enacmd(True, False, False)
    End Sub

    Private Sub Enacmd(add As Boolean, Edit As Boolean, Del As Boolean)
        btnAdd.Enabled = add
        btnEdit.Enabled = Edit
        btnDelete.Enabled = Del
    End Sub

    'Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
    '    ListEmp = Emp.Permission
    '    Dim frm As New frmListEmp
    '    frm.ShowDialog()
    'End Sub


    Public Sub btnAdd_Click(sender As Object, e As System.EventArgs) Handles btnAdd.Click
        If txtUsername.Text.Trim = "" Then
            ' MsgBox("กรุณาป้อน Username ด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "Messages", Me.Text, "InputUserName", MessageBoxIcon.Information)
            '   MsgBox("กรุณาป้อนชื่อผู้ใช้งาน", MsgBoxStyle.Information, "ชื่อผู้ใช้งาน")
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblUsername.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtUsername.Focus()
            Exit Sub
        End If

        If UsernameIsExist(txtUsername.Text.Trim) = True Then
            ' MsgBox("Username ถูกใช้แล้วกรุณาเปลี่ยนใหม่", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "Messages", Me.Text, "UserNameInUse", MessageBoxIcon.Information)
            '  MsgBox("ชื่อผู้ใช้งานมีอยู่แล้ว", MsgBoxStyle.Information, "ชื่อผู้ใช้งาน")
            '      MsgBox(My.Resources.res_warning_message_spacial.Username_same, MsgBoxStyle.Information, Me.Text)
            MsgBox(String.Format(My.Resources.res_warning_message.Same_data, Replace(lblUsername.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtUsername.Focus()
            Exit Sub
        End If

        If UserIdIsExist(txtCode.Text.Trim) = True Then
            ' MsgBox("Username ถูกใช้แล้วกรุณาเปลี่ยนใหม่", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "Messages", Me.Text, "UserNameInUse", MessageBoxIcon.Information)
            '  MsgBox("รหัสพนักงานนี้มีอยู่แล้ว", MsgBoxStyle.Information, "รหัสซ้ำ")
            '   MsgBox(My.Resources.res_warning_message.Same_data, MsgBoxStyle.Information, Me.Text)
            MsgBox(String.Format(My.Resources.res_warning_message.Same_data, Replace(lblCode.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtUsername.Focus()
            Exit Sub
        End If

        If txtPassword.Text.Trim = "" Then
            ' MsgBox("กรุณาป้อน Password ด้วย", MsgBoxStyle.Information, Me.Text)
            ' MsgManager.ShowDialog(Me, "Messages", Me.Text, "InputPassword", MessageBoxIcon.Information)
            '   MsgBox("กรุณาป้อนรหัสผ่าน", MsgBoxStyle.Information, "รหัสผ่าน")
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblPassword.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtPassword.Focus()
            Exit Sub
        End If

        If txtConPass.Text.Trim = "" Then
            '  MsgBox("กรุณาป้อนรหัสผ่านอีกครั้งหนึ่ง", MsgBoxStyle.Information, Me.Text)
            '  MsgBox("กรุณาป้อนยืนยันรหัสผ่าน", MsgBoxStyle.Information, "ยืนยันรหัสผ่าน")
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblConPass.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtConPass.Focus()
            Exit Sub
        End If

        If txtPassword.Text.Trim <> txtConPass.Text.Trim Then
            '  MsgBox("รหัสผ่านไม่เหมือนกันกรุณากรอกใหม่", MsgBoxStyle.Information, Me.Text)
            '   MsgBox("ยืนยันรหัสผ่านไม่ตรงกับรหัสผ่าน", MsgBoxStyle.Information, "ป้อนใหม่")
            MsgBox(My.Resources.res_warning_message_spacial.password_notsame_confirmPassword, MsgBoxStyle.Information, Me.Text)
            txtConPass.Focus()
            Exit Sub
        End If

        If txtCode.Text.Trim = "" Then
            ' MsgBox("กรุณาป้อน Username ด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "Messages", Me.Text, "InputUserName", MessageBoxIcon.Information)
            '   MsgBox("กรุณาเลือกรหัสพนักงาน", MsgBoxStyle.Information, "รหัสพนักงาน")
            MsgBox(My.Resources.res_warning_message.Insert_EmpID, MsgBoxStyle.Information, Me.Text)
            btnshowemp.Focus()
            Exit Sub
        End If

        Dim Dcmd As New SqlCommand
        Dim strSQL As String = ""
        Dim strType As String = ""
        Dim Data As New ArrayList
        Dim db As New db
        Dim export_excel As Boolean = False
        Try


            Data.Clear() : strType = ""
            Data.Add(txtCode.Text.Trim) : strType &= "T"
            Data.Add(txtUsername.Text.Trim) : strType &= "T"
            ' Data.Add(GenCode.FinalEncript(TypeEn.EnCode, txtPassword.Text.Trim, PublicKey)) : strType &= "T"
            Data.Add(dbMgr.getEncryptStr(txtPassword.Text.Trim)) : strType &= "T"


            strSQL = "Insert Into [User](UserID,Username,Password) Values(@P1,@P2,@P3)"

            '     Call OpenConnect(True)
            db.ExecuteCommand(Conn, Dcmd, strSQL, strType, Data)
            '   Call OpenConnect(False)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
            Exit Sub
        End Try

        '    MsgManager.ShowDialog(Me, "Messages", Me.Text, "Save_Complete", MessageBoxIcon.Information)
        '  MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information, "บันทึก")
        MsgBox(My.Resources.res_warning_message.save_complete, MsgBoxStyle.Information, Me.Text)
        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Public Sub btnEdit_Click(sender As Object, e As System.EventArgs) Handles btnEdit.Click

        If txtUsername.Text.Trim = "" Then
            ' MsgBox("กรุณาป้อน Username ด้วย", MsgBoxStyle.Information, Me.Text)
            ' MsgManager.ShowDialog(Me, "Messages", Me.Text, "InputUserName", MessageBoxIcon.Information)
            '  MsgBox("กรุณาป้อนชื่อผู้ใช้งาน", MsgBoxStyle.Information, "ชื่อผู้ใช้งาน")
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblUsername.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtUsername.Focus()
            Exit Sub
        End If


        If txtCode.Text <> txtCode_Old.Text Then
            If UserIdIsExist(txtCode.Text.Trim) = True Then
                ' MsgBox("Username ถูกใช้แล้วกรุณาเปลี่ยนใหม่", MsgBoxStyle.Information, Me.Text)
                '  MsgManager.ShowDialog(Me, "Messages", Me.Text, "UserNameInUse", MessageBoxIcon.Information)
                '  MsgBox("รหัสพนักงานนี้มีอยู่แล้ว", MsgBoxStyle.Information, "รหัสซ้ำ")
                '    MsgBox(My.Resources.res_warning_message.Same_data, MsgBoxStyle.Information, Me.Text)
                MsgBox(String.Format(My.Resources.res_warning_message.Same_data, Replace(lblCode.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
                txtUsername.Focus()
                Exit Sub
            End If
        End If




        If txtPassword.Text.Trim <> txtConPass.Text.Trim Then
            '  MsgBox("รหัสผ่านไม่เหมือนกันกรุณากรอกใหม่", MsgBoxStyle.Information, Me.Text)
            '   MsgBox("ยืนยันรหัสผ่านไม่ตรงกับรหัสผ่าน", MsgBoxStyle.Information, "ป้อนใหม่")
            MsgBox(My.Resources.res_warning_message_spacial.password_notsame_confirmPassword, MsgBoxStyle.Information, Me.Text)
            txtConPass.Focus()
            Exit Sub
        End If



        Dim Dcmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String = ""
        Dim Data As New ArrayList
        Dim db As New db
        Dim export_excel As Boolean = False
        Try


            Data.Clear() : strType = ""
            Data.Add(txtCode.Text.Trim) : strType &= "T"
            Data.Add(txtUsername.Text.Trim) : strType &= "T"
            If txtPassword.Text.Trim <> "" Then
                Data.Add(dbMgr.getEncryptStr(txtPassword.Text.Trim)) : strType &= "T"
            End If


            strSQL = "Update [User] Set UserId = @P1 "

            If txtPassword.Text.Trim <> "" Then
                strSQL &= ",Password = @P3"
            End If
            strSQL &= " Where UserName = @P2"

            '     Call OpenConnect(True)
            db.ExecuteCommand(Conn, Dcmd, strSQL, strType, Data)
            '    Call OpenConnect(False)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
            Exit Sub
        End Try
        '   MsgManager.ShowDialog(Me, "Messages", Me.Text, "Edit_Complete", MessageBoxIcon.Information)
        '   MsgBox("แก้ไขข้อมูลเรียบร้อย", MsgBoxStyle.Information, "แก้ไข")
        MsgBox(My.Resources.res_warning_message.edit_complete, MsgBoxStyle.Information, Me.Text)
        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Public Sub btnDelete_Click(sender As Object, e As System.EventArgs) Handles btnDelete.Click
        ' If MsgBox("คุณต้องการลบข้อมูลนี้จริงๆหรือไม่?", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, "ลบข้อมูล") = MsgBoxResult.No Then Exit Sub
        If MsgManager.ConfirmDialog(Me, "Messages", Me.Text, "Del_Confirm_Msg", MessageBoxIcon.Information) = DialogResult.Cancel Then Exit Sub

        '   If MsgBox("ต้องการลบข้อมุลหรือไม่", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "ลบ") = vbNo Then Exit Sub
        If MsgBox(My.Resources.res_warning_message.Confirm_Del, MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = vbNo Then Exit Sub

        'If txtCode.Text.Trim = "" Then
        '    '   MsgBox("กรุณาป้อนรหัส" & Me.Text.Trim & "ด้วย", MsgBoxStyle.Information, Me.Text)
        '    '  MsgManager.ShowDialog(Me, "Messages", Me.Text, "InputEmp", MessageBoxIcon.Information)
        '    MsgBox("แก้ไขข้อมูลเรียบร้อย", MsgBoxStyle.Information, "แก้ไข")
        '    txtCode.Focus()
        '    Exit Sub
        'End If

        Dim strSQL As String
        Dim strType As String
        Dim dCmd As New SqlCommand
        Dim data As New ArrayList
        Dim db As New db

        Try
            data.Clear() : strType = ""
            data.Add(txtUsername.Text.Trim) : strType &= "T"

            strSQL = "Delete From [User] " &
                    " Where  UserName = @P1"

            '   Call OpenConnect(True)
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, data)
            '    Call OpenConnect(False)
        Catch ex As Exception
            '  MsgBox(ErrChangeText(Err.Number, ex.Message), MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
        '  MsgManager.ShowDialog(Me, "Messages", Me.Text, "Del_Complete", MessageBoxIcon.Information)
        '  MsgBox("แก้ไขข้อมูลเรียบร้อย", MsgBoxStyle.Information, "แก้ไข")
        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Function UserIdIsExist(ByVal UserId As String) As Boolean
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "Select * From [User]" &
                " Where Userid = '" & UserId.Trim & "'"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            If .Rows.Count > 0 Then
                Ds.Clear()
                Return True
            Else
                Ds.Clear()
                Return False
            End If
        End With
    End Function


    Public Sub btnClear_Click(sender As Object, e As System.EventArgs) Handles btnClear.Click
        Call LoadData()
        Call Enacmd(True, False, False)
        txtCode.Text = ""
        txtConPass.Text = ""
        txtPassword.Text = ""
        txtUsername.Text = ""
        lblEmpName.Text = ""

        ChkAllCompany.Checked = False
        txtUsername.Focus()
    End Sub



    'Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

    '    If txtUsername.Text.Trim = "" Then
    '        MsgBox("กรุณาป้อน Username ด้วย", MsgBoxStyle.Information, Me.Text)
    '        txtUsername.Focus()
    '        Exit Sub
    '    End If

    '    If UsernameIsExist(txtUsername.Text.Trim) = True Then
    '        MsgBox("Username ถูกใช้แล้วกรุณาเปลี่ยนใหม่", MsgBoxStyle.Information, Me.Text)
    '        txtUsername.Focus()
    '        Exit Sub
    '    End If

    '    If txtPassword.Text.Trim = "" Then
    '        MsgBox("กรุณาป้อน Password ด้วย", MsgBoxStyle.Information, Me.Text)
    '        txtPassword.Focus()
    '        Exit Sub
    '    End If

    '    If txtConPass.Text.Trim = "" Then
    '        MsgBox("กรุณาป้อนรหัสผ่านอีกครั้งหนึ่ง", MsgBoxStyle.Information, Me.Text)
    '        txtConPass.Focus()
    '        Exit Sub
    '    End If

    '    If txtPassword.Text.Trim <> txtConPass.Text.Trim Then
    '        MsgBox("รหัสผ่านไม่เหมือนกันกรุณากรอกใหม่", MsgBoxStyle.Information, Me.Text)
    '        txtPassword.Focus()
    '        Exit Sub
    '    End If

    '    Dim Dcmd As New SqlCommand
    '    Dim strSQL As String
    '    Dim strType As String = ""
    '    Dim Data As New ArrayList
    '    Dim db As New db
    '    Try


    '        Data.Clear() : strType = ""
    '        Data.Add(txtCode.Text.Trim) : strType &= "T"
    '        Data.Add(txtUsername.Text.Trim) : strType &= "T"
    '        Data.Add(GenCode.FinalEncript(TypeEn.EnCode, txtPassword.Text.Trim, PublicKey)) : strType &= "T"
    '        Data.Add(IIf(rdoSingle.Checked = True, "S", "G")) : strType &= "T"
    '        Data.Add(UserId.Trim) : strType &= "T"
    '        Data.Add(IIf(ChkAllCompany.Checked = True, 1, 0)) : strType &= "B"

    '        strSQL = "Insert Into UserConfig(UserID,Username,Password,Type,UserUpdate,MultiCompany) Values(@P1,@P2,@P3,@P4,@P5,@P6)"

    '        Call OpenConnect(True)
    '        db.ExecuteCommand(Conn, Dcmd, strSQL, strType, Data)
    '        Call OpenConnect(False)

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
    '        Exit Sub
    '    End Try

    '    If rdoSingle.Checked = True Then

    '    End If
    '    Call btnRefresh_Click(Me, System.EventArgs.Empty)

    'End Sub
    Private Sub LoadData()

        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""

        'Dim arrData() As String
        'Dim List As ListViewItem

        strSQL = " select ROW_NUMBER() OVER(ORDER BY u.username) as row, " &
                          " UserId = Isnull(u.UserID,'') , " &
                          " Username = Isnull(u.UserName,'') ,  " &
                          " Password = Isnull(u.Password,'') ,  " &
                          " Name = Isnull(e.Fname,'') ,  " &
                          " LName = Isnull(e.LName,'') ,  " &
                          " Department = Isnull(d.Department,'') " &
                " from [User] u  " &
                     " left Join Emp e  " &
                            " on u.UserID = e.code " &
                     " Left Join Department d  " &
                            " on e.DeptId = d.DeptId " &
                " Where e.Workstatus='W'"

        Try
            Da = New SqlDataAdapter(strSQL, Conn)
            Da.Fill(Ds, "Data")

            GcUser.DataSource = Ds
            GcUser.DataMember = "Data"


        Catch ex As Exception
            lstShow.EndUpdate()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try

    End Sub


    Function UsernameIsExist(ByVal Username As String) As Boolean
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "Select * From [User]" &
                " Where Username = '" & Username.Trim & "'"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            If .Rows.Count > 0 Then
                Ds.Clear()
                Return True
            Else
                Ds.Clear()
                Return False
            End If
        End With
    End Function

    Function UsernameIsExist(ByVal Username As String, ByVal OldUserName As String) As Boolean
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select * From UserConfig" &
                " Where Username <> '" & OldUserName.Trim & "' " &
                        " And UserName = '" & Username.Trim & "'"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            If .Rows.Count > 0 Then
                Ds.Clear()
                Return True
            Else
                Ds.Clear()
                Return False
            End If
        End With
    End Function



    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call LoadData()
        Call Enacmd(True, False, False)
        txtCode.Text = ""
        txtConPass.Text = ""
        txtPassword.Text = ""
        txtUsername.Text = ""
        ChkAllCompany.Checked = False

    End Sub
    'Private Sub EnaCmd(ByVal Add As Boolean, ByVal Edit As Boolean, ByVal Delete As Boolean)
    '    btnAdd.Enabled = Add
    '    btnEdit.Enabled = Edit
    '    btnDelete.Enabled = Delete

    'End Sub

    'Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
    '    Me.Close()
    'End Sub


    'Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
    '    If MsgBox("คุณต้องการลบข้อมูลนี้จริงๆหรือไม่?", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, "ลบข้อมูล") = MsgBoxResult.No Then Exit Sub

    '    If txtCode.Text.Trim = "" Then
    '        MsgBox("กรุณาป้อนรหัส" & Me.Text.Trim & "ด้วย", MsgBoxStyle.Information, Me.Text)
    '        txtCode.Focus()
    '        Exit Sub
    '    End If

    '    Dim strSQL As String
    '    Dim strType As String
    '    Dim dCmd As New SqlCommand
    '    Dim data As New ArrayList
    '    Dim db As New db

    '    Try
    '        data.Clear() : strType = ""
    '        data.Add(txtUsername.Text.Trim) : strType &= "T"

    '        strSQL = "Delete From UserConfig " & _
    '                " Where  UserName = @P1"

    '        Call OpenConnect(True)
    '        db.ExecuteCommand(Conn, dCmd, strSQL, strType, data)
    '        Call OpenConnect(False)
    '    Catch ex As Exception
    '        '  MsgBox(ErrChangeText(Err.Number, ex.Message), MsgBoxStyle.Critical, Me.Text)
    '        Exit Sub
    '    End Try
    '    Call btnRefresh_Click(Me, System.EventArgs.Empty)
    'End Sub

    'Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

    '    If txtUsername.Text.Trim = "" Then
    '        MsgBox("กรุณาป้อน Username ด้วย", MsgBoxStyle.Information, Me.Text)
    '        txtUsername.Focus()
    '        Exit Sub
    '    End If

    '    If UsernameIsExist(txtUsername.Text.Trim, txtOldUserName.Text.Trim) = True Then
    '        MsgBox("Username ถูกใช้แล้วกรุณาเปลี่ยนใหม่", MsgBoxStyle.Information, Me.Text)
    '        txtUsername.Focus()
    '        Exit Sub
    '    End If

    '    If txtPassword.Text.Trim <> "" Then
    '        If txtConPass.Text.Trim = "" Then
    '            MsgBox("กรุณาป้อนรหัสผ่านอีกครั้งหนึ่ง", MsgBoxStyle.Information, Me.Text)
    '            txtConPass.Focus()
    '            Exit Sub
    '        End If

    '        If txtPassword.Text.Trim <> txtConPass.Text.Trim Then
    '            MsgBox("รหัสผ่านไม่เหมือนกันกรุณากรอกใหม่", MsgBoxStyle.Information, Me.Text)
    '            txtPassword.Focus()
    '            Exit Sub
    '        End If
    '    End If

    '    Dim Dcmd As New SqlCommand
    '    Dim strSQL As String
    '    Dim strType As String = ""
    '    Dim Data As New ArrayList
    '    Dim db As New db
    '    Try


    '        Data.Clear() : strType = ""
    '        Data.Add(txtUsername.Text.Trim) : strType &= "T"
    '        Data.Add(txtCode.Text.Trim) : strType &= "T"
    '        Data.Add(IIf(rdoSingle.Checked = True, "S", "G")) : strType &= "T"
    '        If txtPassword.Text.Trim <> "" Then
    '            Data.Add(GenCode.FinalEncript(TypeEn.EnCode, txtPassword.Text.Trim, PublicKey)) : strType &= "T"
    '        End If
    '        Data.Add(IIf(ChkAllCompany.Checked = True, 1, 0)) : strType &= "B"

    '        strSQL = "Update UserConfig Set UserId = @P2," & _
    '                                    " Type = @P3 "
    '        If txtPassword.Text.Trim <> "" Then
    '            strSQL &= ",Password = @P4,MultiCompany=@P5"
    '        End If
    '        strSQL &= " Where UserName = @P1"

    '        Call OpenConnect(True)
    '        db.ExecuteCommand(Conn, Dcmd, strSQL, strType, Data)
    '        Call OpenConnect(False)

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
    '        Exit Sub
    '    End Try

    '    If rdoSingle.Checked = True Then

    '    End If
    '    Call btnRefresh_Click(Me, System.EventArgs.Empty)
    'End Sub

    Private Sub lstShow_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstShow.DoubleClick
        With lstShow
            If .SelectedItems.Count = 0 Then Exit Sub
            txtCode.Text = .SelectedItems(0).SubItems(1).Text.Trim : Call txtCode_LostFocus(Me, System.EventArgs.Empty)
            'txtConPass.Text = .SelectedItems(0).SubItems(7).Text.Trim
            'txtPassword.Text = .SelectedItems(0).SubItems(7).Text.Trim
            txtUsername.Text = .SelectedItems(0).SubItems(2).Text.Trim
            txtOldUserName.Text = .SelectedItems(0).SubItems(2).Text.Trim
            ' Dim Check As String = .SelectedItems(0).SubItems(8).Text.Trim

            Call Enacmd(False, True, True)
            txtPassword.Focus()
        End With
    End Sub

    Private Sub lstShow_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstShow.SelectedIndexChanged

    End Sub

    Public Sub txtCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""

        strSQL = "Select Title,Fname,LName From Emp" &
                " Where  Code = '" & txtCode.Text.Trim & "'"
        '  Call OpenConnect(True)
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        ' Call OpenConnect(False)

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                lblEmpName.Text = ""
            Else
                lblEmpName.Text = .Rows(0).Item("Title") & .Rows(0).Item("Fname") & "   " & .Rows(0).Item("LName")
            End If
        End With
    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnSetPermission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetPermission.Click
        'If txtUsername.Text = "" Then
        '    '  MsgBox("กรุณาเลือกรหัสพนักงาน", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "แจ้งให้ทราบ")
        '    MsgManager.ShowDialog(Me, "Messages", Me.Text, "Select_Emp_Code", MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        'Try
        '    If fSetUserLogIn Is Nothing Then
        '        fSetUserLogIn = New frmSetUserLogIn
        '    Else
        '        If fSetUserLogIn.IsDisposed = True Then
        '            fSetUserLogIn = New frmSetUserLogIn
        '        End If
        '    End If
        '    fSetUserLogIn.WindowState = FormWindowState.Normal

        '    '   fSetUser.MdiParent = Me
        '    fSetUserLogIn.BringToFront()
        '    fSetUserLogIn.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        'End Try

        'fSetUserLogIn.txtEmpId.Text = txtCode.Text.Trim
        '   Call fSetUserLogIn.txtEmpId_LostFocus(Me, System.EventArgs.Empty)
    End Sub



    Public Shared Function GetEmpName(IDUser As String) As String   ' หาชื่อ สกุล

        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim strsql As String = ""

        strsql = "Select * " & _
                " from employee " & _
                " where  idCode='" & IDUser.Trim & "'   "

        Try
            'OpenConnect(True)
            DA = New SqlDataAdapter(strsql, Conn)
            DA.Fill(DS, "DATA")
            'OpenConnect(False)

            With DS.Tables("DATA")
                If .Rows.Count = 0 Then
                    Return ""
                Else
                    Return .Rows(0).Item("Name") & "  -  " & .Rows(0).Item("SurName")
                End If
            End With
        Catch ex As Exception
            '   MsgBox(ex.Message)
            Return ""

        End Try

    End Function

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Dim ListEmp = Emp.Permission
        Dim frm As New frmListEmp
        frm.ShowDialog()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub GcUser_Click(sender As Object, e As EventArgs) Handles GcUser.Click

    End Sub

    Private Sub GcUser_DoubleClick(sender As Object, e As EventArgs) Handles GcUser.DoubleClick




        'With lstShow
        '    If .SelectedItems.Count = 0 Then Exit Sub
        '    txtCode.Text = .SelectedItems(0).SubItems(1).Text.Trim : Call txtCode_LostFocus(Me, System.EventArgs.Empty)
        '    'txtConPass.Text = .SelectedItems(0).SubItems(7).Text.Trim
        '    'txtPassword.Text = .SelectedItems(0).SubItems(7).Text.Trim
        '    txtUsername.Text = .SelectedItems(0).SubItems(2).Text.Trim
        '    txtOldUserName.Text = .SelectedItems(0).SubItems(2).Text.Trim
        '    ' Dim Check As String = .SelectedItems(0).SubItems(8).Text.Trim

        '    Call Enacmd(False, True, True)
        '    txtPassword.Focus()
        'End With
    End Sub

    Private Sub GvUser_DoubleClick(sender As Object, e As EventArgs) Handles GvUser.DoubleClick
        Try
            Dim gv As GridView = CType(sender, GridView)

            If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "UserId")) = True Then Exit Sub

            txtCode.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "UserId")
            txtCode_Old.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "UserId")
            Call txtCode_LostFocus(Me, System.EventArgs.Empty)

            txtUsername.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Username")
            txtOldUserName.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Name")
            Call Enacmd(False, True, True)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btnshowemp.Click
        Dim ListEmp = Emp.Permission
        Dim frm As New frmListEmp
        frm.ShowDialog()
    End Sub

    Private Sub txtConPass_EditValueChanged(sender As Object, e As EventArgs) Handles txtConPass.EditValueChanged

    End Sub
End Class