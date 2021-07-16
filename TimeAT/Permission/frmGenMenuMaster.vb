Imports System.Data
Imports System.Data.SqlClient
Public Class frmGenMenuMaster
    Dim MenuId As String

    Private Sub btnAddAuto_Click(sender As System.Object, e As System.EventArgs) Handles btnAddAuto.Click
        ' mark ple 25/07/2019
        'For Each HeadMenu As ToolStripMenuItem In fMainMenuHD.MenuStrip.Items
        '    SetStatusChildMenu_Insert(HeadMenu)
        'Next

    End Sub

    Private Sub SetStatusChildMenu_Insert(ByVal HeadMenu As ToolStripMenuItem)
        Dim Dcmd As New SqlCommand
        Dim mnuChild As ToolStripMenuItem
        Dim NameMenu As String = ""
        Dim ChkMenu As Boolean = True
        Dim NameMenu_Text As String = ""
        Dim MenuHide As String = ""
        '   Dim HeadMenuMain As String = ""

        Try
            For i As Integer = 0 To HeadMenu.DropDownItems.Count - 1
                If TypeOf HeadMenu.DropDownItems(i) Is ToolStripMenuItem Then
                    mnuChild = DirectCast(HeadMenu.DropDownItems(i), ToolStripMenuItem)
                    NameMenu = HeadMenu.DropDownItems(i).Tag  ' ชื่อจาก Tag
                    NameMenu_Text = HeadMenu.DropDownItems(i).Text  ' ชื่อจาก TEXT
                    '      MenuHide = HeadMenu.DropDownItems(i).Visible  ' เช็คว่าเมนูที่เขียนได้มีการซ่อนไว้มั้ย ถ้ามีก็ไม่เอามา


                    '------------------------------------------------------------------
                    If mnuChild.HasDropDownItems Then
                        ' mnuChild.Enabled = False  '/// I'm Show Recursive Function wed wed wed
                        '  If MenuHide = False Then  ' ถ้าไม่ได้ซ่อน ก็เอาไปหาตัวย่อยอีก
                        SetStatusChildMenu_Insert(HeadMenu.DropDownItems(i))
                        'End If

                    Else
                        If ChkSameMenu(Dcmd, NameMenu.Trim, NameMenu_Text.Trim) = False Then  ' เช็คว่ามีเมนูนี้หรือยัง ถ้ายังก็บันทึกไป
                            'If MenuHide = False Then ' ถ้ามีการซ่อนไว้ก็ไม่ต้อเอามา
                            '      Call InsertMenu(Dcmd, NameMenu.Trim, NameMenu_Text.Trim, HeadMenu.Text)  ' บันทึกเข้าไป
                            'End If
                        End If
                    End If

                    '----------------------------------------------------------------------
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try


    End Sub

    Function ChkSameMenu(ByVal Dcmd As SqlCommand, ByVal MenuLinkFrom As String, ByVal MenuThai As String) As Boolean
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select * " & _
                 " from menuMaster_temp  " & _
                 " Where  Menu_LinkFrom='" & MenuLinkFrom.Trim & "' And " & _
                        " Menu_Name='" & MenuThai.Trim & "'"

        Try
            'OpenConnect(True)
            Dcmd.Connection = Conn
            Dcmd.CommandText = Strsql
            Dcmd.ExecuteNonQuery()
            DA.SelectCommand = Dcmd
            DA.Fill(DS, "DATA")
            'OpenConnect(False)

            With DS.Tables("DATA")
                If .Rows.Count = 0 Then
                    Return False
                Else
                    Return True
                End If
            End With
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Private Sub InsertMenu(ByVal Dcmd As SqlCommand, _
    '                     ByVal MenuEng As String, _
    '                     ByVal MenuThai As String, _
    '                     ByVal HeadMenu As String)

    '    Dim strSQL As String
    '    Dim strType As String
    '    ' Dim dCmd As New SqlCommand
    '    Dim data As New ArrayList
    '    Dim db As New db
    '    Dim Tn As SqlTransaction
    '    '    Dim arrData() As String
    '    '   Dim List As ListViewItem
    '    '   Dim Menuid As String

    '    ' Call LoadCode()
    '    Call OpenConnect(True)
    '    Tn = Conn.BeginTransaction
    '    Dcmd.Transaction = Tn

    '    Try
    '        data.Clear() : strType = ""
    '        '  data.Add(CompanyID.Trim) : strType &= "T"
    '        data.Add("1") : strType &= "T"
    '        data.Add(MenuThai.Trim) : strType &= "T"
    '        data.Add(MenuEng.Trim) : strType &= "T"
    '        data.Add(MenuEng.Trim) : strType &= "T"   ' มาจาก Tag เลยใช้ MenuEng เหมือนกัน
    '        '   data.Add(IDUser.Trim) : strType &= "T"


    '        strSQL = "Insert Into menuMaster_temp(Menu_Id,Menu_Name,Menu_NameEng,Menu_LinkFrom" & _
    '                            " ) " & _
    '                            " Values(@P1,@P2,@P3,@P4)"
    '        db.ExecuteCommand(Conn, Dcmd, strSQL, strType, data)


    '        Tn.Commit()
    '        Call OpenConnect(False)
    '    Catch ex As Exception
    '        Tn.Rollback()
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    '        Exit Sub
    '    End Try

    'End Sub

    'Private Sub LoadCode()
    '    Dim code As String = GetData.GetID(CompanyID.Trim, "GenMenuMaster", "Menu_Id", 2)
    '    MenuId = code
    '    '   txtMenuId.Text = code
    'End Sub

    Private Sub txtMenuNameEng_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMenuNameEng.TextChanged, txtNo_Pic.TextChanged

    End Sub

    Private Sub AddMenuToDataBase(StMenuHead As Boolean, _
                                  MenuHead As String, _
                                  MenuNameThai As String, _
                                  MenuTag As String) ' ค่าเริ่มต้นของ NumberHead เป็น 0
        Dim ChkApp As Boolean
        Dim MenuMain As Boolean
        Dim ReadOnly_ As Boolean
        Dim RunningMenu As String = ""


        RunningMenu = ChkAutoNumber(MenuHead.Trim) 'ตาม Running ตาม Head


        ' กำหนดให้เป็นฟอร์มที่มีผู้อนุมัติได้
        If ChkFormApprove.Checked = True Then
            ChkApp = True
        Else
            ChkApp = False
        End If

        'กำหนดว่าเป็นเมนุหลักหรือไม่
        If StMenuHead = True Then
            MenuMain = True
        Else
            MenuMain = False
        End If


        If ChkReadOnly.Checked = True Then
            ReadOnly_ = True
        Else
            ReadOnly_ = False
        End If

        Dim strSQL As String
        Dim strType As String
        Dim dCmd As New SqlCommand
        Dim data As New ArrayList
        Dim db As New db

        Try
            data.Clear() : strType = ""
            data.Add(RunningMenu.Trim) : strType &= "T"
            data.Add(MenuNameThai.Trim) : strType &= "T"
            data.Add(MenuTag.Trim) : strType &= "T"
            data.Add(MenuTag.Trim) : strType &= "T"
            data.Add(UserId.Trim) : strType &= "T"
            data.Add(ChkApp) : strType &= "B"
            data.Add(MenuMain) : strType &= "B"
            data.Add(ReadOnly_) : strType &= "B"
            data.Add(App_Project) : strType &= "T"

            strSQL = "Insert Into GenCreateMenu_Master(Menu_Id,Menu_Name,Menu_NameEng,Menu_LinkFrom,UserUpdate,Form_Approve,St_MenuMain,Menu_ReadOnly,APP)" & _
                                       " Values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)"
            '    Call OpenConnect(True)
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, data)
            '    Call OpenConnect(False)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
        'btnClear_Click(Me, System.EventArgs.Empty)
        'Call EnaCmd(True, False, False)
    End Sub

    Function ChkAutoNumber(ByVal HeadNumber As String) As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim db As New db

        strSQL = "Select Max(menu_Id) as MenuNum" & _
                 " from GenCreateMenu_Master " & _
                 " Where Left(Menu_Id,4)='" & HeadNumber.Trim & "' "
        Try
            '   Call OpenConnect(True)
            Da = New SqlDataAdapter(strSQL, Conn)
            Da.Fill(Ds, "data")
            '   Call OpenConnect(False)

            With Ds.Tables("data")
                If .Rows.Count = 0 Then
                    Return HeadNumber
                Else
                    If IsDBNull(.Rows(0).Item("MenuNum")) = True Then
                        Return HeadNumber
                    Else
                        Dim CountNum As Integer
                        Dim NoId As Integer
                        CountNum = Len(.Rows(0).Item("MenuNum"))

                        If CountNum = 4 Then ' เป็นเมนูหลัก
                            Return .Rows(0).Item("MenuNum") & "001"
                        Else
                            NoId = RightText(.Rows(0).Item("MenuNum"), 3) + 1
                            Return HeadNumber & Format(NoId, "000")
                        End If

                    End If

                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Code is Exist")
            Return HeadNumber
            Exit Function
        End Try
    End Function

    Function CountRunning() As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim db As New db

        strSQL = "Select count(menu_Id) as MenuNum" & _
                 " from GenCreateMenu_Master"

        Try
            '  Call OpenConnect(True)
            Da = New SqlDataAdapter(strSQL, Conn)
            Da.Fill(Ds, "data")
            '   Call OpenConnect(False)

            With Ds.Tables("data")
                If .Rows.Count = 0 Then
                    Return 0
                Else
                    Return CSng(.Rows(0).Item("MenuNum")) + 1

                End If
            End With

        Catch ex As Exception
            Return 0
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Code is Exist")
        End Try
    End Function

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim ChkApp As Boolean
        Dim MenuMain As Boolean
        Dim ReadOnly_ As Boolean
        '   Dim code As String = GetData.GetID(CompanyID.Trim, "GenMenu_Master", "MenuId", 2)


        If txtMenuId.Text.Trim = "" Then
            MsgBox("กรุณาป้อนรหัสเมนู" & Me.Text.Trim & "ด้วย", MsgBoxStyle.Information, Me.Text)
            txtMenuName.Focus()
            Exit Sub
        End If

        If txtMenuName.Text.Trim = "" Then
            MsgBox("กรุณาป้อนชื่อ" & Me.Text.Trim & "ด้วย", MsgBoxStyle.Information, Me.Text)
            txtMenuName.Focus()
            Exit Sub
        End If

        'If NameIsExist(txtMenuName.Text.Trim, txtOldMenuName.Text.Trim) = True Then
        '    MsgBox("ชื่อ" & Me.Text.Trim & "มีแล้วกรุณาป้อนชื่อใหม่", MsgBoxStyle.Information, Me.Text)
        '    txtMenuName.Focus()
        '    Exit Sub
        'End If


        ' กำหนดให้เป็นฟอร์มที่มีผู้อนุมัติได้
        If ChkFormApprove.Checked = True Then
            ChkApp = True
        Else
            ChkApp = False
        End If

        'กำหนดว่าเป็นเมนุหลักหรือไม่
        If ChkMenuMain.Checked = True Then
            MenuMain = True
        Else
            MenuMain = False
        End If


        If ChkReadOnly.Checked = True Then
            ReadOnly_ = True
        Else
            ReadOnly_ = False
        End If

        Dim strSQL As String
        Dim strType As String
        Dim dCmd As New SqlCommand
        Dim data As New ArrayList
        Dim db As New db
        Dim Running As Integer = 0

        Running = CountRunning()

        Try
            data.Clear() : strType = ""
            data.Add(Running) : strType &= "T"
            data.Add(txtMenuId.Text.Trim) : strType &= "T"
            data.Add(txtMenuName.Text.Trim) : strType &= "T"
            data.Add(txtMenuNameEng.Text.Trim) : strType &= "T"
            data.Add(txtMenuNameEng.Text.Trim) : strType &= "T"
            data.Add(txtNo_Pic.Text.Trim) : strType &= "T"
            data.Add(UserId.Trim) : strType &= "T"
            data.Add(ChkApp) : strType &= "B"
            data.Add(MenuMain) : strType &= "B"
            data.Add(ReadOnly_) : strType &= "B"
            data.Add(App_Project) : strType &= "T"

            strSQL = "Insert Into GenCreateMenu_Master(RunningNo,Menu_Id,Menu_Name,Menu_NameEng,Menu_LinkFrom,No_Pic,UserUpdate,Form_Approve,St_MenuMain,Menu_ReadOnly,APP)" & _
                                       " Values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11)"
            '   Call OpenConnect(True)
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, data)
            '   Call OpenConnect(False)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
        btnClear_Click(Me, System.EventArgs.Empty)
        Call EnaCmd(True, False, False)
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        Dim chkApp As Boolean
        Dim MenuMain As Boolean
        Dim ReadOnly_ As Boolean
        If txtMenuId.Text.Trim = "" Then
            MsgBox("กรุณาป้อนรหัส" & Me.Text.Trim & "ด้วย", MsgBoxStyle.Information, Me.Text)
            txtMenuId.Focus()
            Exit Sub
        End If

        'If ComIdIsExist(txtMenuId.Text.Trim, txtOldMenuId.Text.Trim) = True Then
        '    MsgBox("รหัส" & Me.Text.Trim & "ซ้ำกรุณากรอกใหม่", MsgBoxStyle.Information, Me.Text)
        '    txtMenuId.Focus() 
        '    Exit Sub
        'End If

        If txtMenuName.Text.Trim = "" Then
            MsgBox("กรุณาป้อนชื่อ" & Me.Text.Trim & "ด้วย", MsgBoxStyle.Information, Me.Text)
            txtMenuName.Focus()
            Exit Sub
        End If

        'If NameIsExist(txtMenuName.Text.Trim, txtOldMenuName.Text.Trim) = True Then
        '    MsgBox("ชื่อ" & Me.Text.Trim & "มีแล้วกรุณาป้อนชื่อใหม่", MsgBoxStyle.Information, Me.Text)
        '    txtMenuName.Focus()
        '    Exit Sub
        'End If

        ' กำหนดการอนุมัติ
        If ChkFormApprove.Checked = True Then
            chkApp = True
        Else
            chkApp = False
        End If

        'กำหนดเมนูหลัก
        If ChkMenuMain.Checked = True Then
            MenuMain = True
        Else
            MenuMain = False
        End If

        If ChkReadOnly.Checked = True Then
            ReadOnly_ = True
        Else
            ReadOnly_ = False
        End If



        Dim strSQL As String
        Dim strType As String
        Dim dCmd As New SqlCommand
        Dim data As New ArrayList
        Dim db As New db

        Try
            data.Clear() : strType = ""
            data.Add(txtMenuId.Text.Trim) : strType &= "T"
            data.Add(txtMenuName.Text.Trim) : strType &= "T"
            data.Add(txtMenuNameEng.Text.Trim) : strType &= "T"
            data.Add(txtMenuNameEng.Text.Trim) : strType &= "T"
            data.Add(chkApp) : strType &= "B"
            data.Add(MenuMain) : strType &= "B"
            data.Add(ReadOnly_) : strType &= "B"
            data.Add(UserId.Trim) : strType &= "T"
            data.Add(App_Project) : strType &= "T"
            data.Add(txtNo_Pic.Text.Trim) : strType &= "T"

            ' สำหรับต้นแบบเมนู -----------------------------------------------------------
            strSQL = "Update GenCreateMenu_Master Set Menu_Name=@P2, " & _
                                        " Menu_NameEng= @P3," & _
                                        " Menu_LinkFrom = @P4," & _
                                        " Form_Approve=@P5, " & _
                                        " St_MenuMain=@P6," & _
                                        " Menu_ReadOnly=@P7, " & _
                                        " UserUpdate=@P8," & _
                                        " No_Pic=@P10" & _
                      " Where  Menu_Id = @P1 And APP=@P9"

            '   Call OpenConnect(True)
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, data)
            '   Call OpenConnect(False)


            '' สำหรับ User -----------------------------------------------------------
            'strSQL = "Update GenMenu Set MenuGroup=@P3, " & _
            '                            " MenuName= @P4," & _
            '                            " UserUpdate = @P5," & _
            '                            " LastUpdate = GetDate(), " & _
            '                            " MenuNameEng=@P6, " & _
            '                            " Form_Approve=@P7 " & _
            '                        " Where ComId = @P1 and MenuId = @P2"

            'Call OpenConnect(True)
            'db.ExecuteCommand(Conn, dCmd, strSQL, strType, data)
            'Call OpenConnect(False)



            '' สำหรับ การ LogIn -----------------------------------------------------------
            'strSQL = "Update GenMenu_LogIn Set MenuGroup=@P3, " & _
            '                            " MenuName= @P4," & _
            '                            " UserUpdate = @P5," & _
            '                            " LastUpdate = GetDate(), " & _
            '                            " MenuNameEng=@P6, " & _
            '                            " Form_Approve=@P7 " & _
            '                        " Where ComId = @P1 and MenuId = @P2"

            'Call OpenConnect(True)
            'db.ExecuteCommand(Conn, dCmd, strSQL, strType, data)
            'Call OpenConnect(False)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
        btnClear_Click(Me, System.EventArgs.Empty)
        Call EnaCmd(True, False, False)
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If MsgBox("คุณต้องการลบข้อมูลนี้จริงๆหรือไม่?", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, "ลบข้อมูล") = MsgBoxResult.No Then Exit Sub

        If txtMenuId.Text.Trim = "" Then
            MsgBox("กรุณาป้อนรหัส" & Me.Text.Trim & "ด้วย", MsgBoxStyle.Information, Me.Text)
            txtMenuId.Focus()
            Exit Sub
        End If

        Dim strSQL As String
        Dim strType As String
        Dim dCmd As New SqlCommand
        Dim data As New ArrayList
        Dim db As New db

        Try
            data.Clear() : strType = ""
            data.Add(txtMenuId.Text.Trim) : strType &= "T"
            data.Add(App_Project) : strType &= "T"

            ' สำหรับต้นแบบเมนู  --------------------------------------------
            strSQL = "Delete From GenCreateMenu_Master " & _
                    " Where  Menu_Id = @P1 And APP=@P2"

            ' Call OpenConnect(True)
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, data)
            '   Call OpenConnect(False)

            '' สำหรับเมนู---------------------------------------------------
            'strSQL = "Delete From GenMenu_LogIn " & _
            '        " Where ComId = @P1 and MenuId = @P2"

            'Call OpenConnect(True)
            'db.ExecuteCommand(Conn, dCmd, strSQL, strType, data)
            'Call OpenConnect(False)

            '' ตอนกำหนดเมนู---------------------------------------------------
            'strSQL = "Delete From GenMenu " & _
            '        " Where ComId = @P1 and MenuId = @P2"

            'Call OpenConnect(True)
            'db.ExecuteCommand(Conn, dCmd, strSQL, strType, data)
            'Call OpenConnect(False)


        Catch ex As Exception
            'MsgBox(ErrChangeText(Err.Number, ex.Message), MsgBoxStyle.Critical, Me.Text)
            MsgBox(ex.Message)
            Exit Sub
        End Try
        Call btnClear_Click(Me, System.EventArgs.Empty)
        Call EnaCmd(True, False, False)
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        Call ClearData(True)
        Call LoadData()
        '    Call LoadCode()
        Call EnaCmd(True, False, False)
        '  Call LoadMenuId()
        txtMenuId.Focus()
    End Sub


    Private Sub ClearData(ByVal ClearUnitID As Boolean)
        'If ClearUnitID = True Then
        '    txtMenuId.Text = ""
        'End If
        txtOldMenuId.Text = ""
        txtMenuName.Text = ""
        txtMenuNameEng.Text = ""

        txtNo_Pic.Text = ""

        ChkFormApprove.Checked = False
        ChkMenuMain.Checked = False
        ChkReadOnly.Checked = False
    End Sub

    Private Sub LoadData()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        Dim arrData() As String
        Dim List As ListViewItem

        strSQL = "Select RunningNo, " & _
                        " Menu_Id," & _
                        " Menu_Name, " & _
                        " Menu_NameEng," & _
                        " Menu_LinkFrom, " & _
                        " St_MenuMain, " & _
                        " Form_Approve," & _
                        " Menu_ReadOnly, " & _
                        " No_Pic, " & _
                        " App " & _
                " From GenCreateMenu_Master " & _
                " Where App='" & App_Project.Trim & "'" & _
                " Order by Menu_Id"
        'If chkByGroup.Checked = True Then
        '    strSQL &= ""
        'End If


        Try
            ' Call OpenConnect(True)
            Da = New SqlDataAdapter(strSQL, Conn)
            Da.Fill(Ds, "data")
            '   Call OpenConnect(False)

            With Ds.Tables("data")
                lstMenu.BeginUpdate()
                lstMenu.Items.Clear()
                Dim I As Integer = 0
                For Each drw As DataRow In .Rows
                    I += 1
                    arrData = New String() {I, _
                                            drw("RunningNo"), _
                                            drw("Menu_Id"), _
                                            drw("Menu_Name"), _
                                            drw("Menu_NameEng"), _
                                            drw("Menu_LinkFrom"), _
                                            drw("No_Pic"), _
                                            "", _
                                            IIf(drw("Form_Approve") = True, "/", ""), _
                                            IIf(drw("Menu_ReadOnly") = True, "/", ""), _
                                            IIf(drw("St_MenuMain") = True, "/", "")}

                    List = New ListViewItem(arrData)
                    lstMenu.Items.Add(List)
                Next
                lstMenu.EndUpdate()
            End With
        Catch ex As Exception
            lstMenu.EndUpdate()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
    End Sub

    Private Sub LoadCode()
        'Dim code As String = GetData.GetID(CompanyID.Trim, "GenMenu_Master", "MenuId", 2)
        'MenuId = code
        'txtMenuId.Text = code
    End Sub

    Function newText(ByVal Data As String) As String
        Return Replace(Data, "'", "''")
    End Function

    Function ComIdIsExist(ByVal UnitId As String, ByVal OldUnitId As String) As Boolean
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim db As New db

        strSQL = "Select Menu_Id From GenCreateMenu_Master " & _
                " Where Menu_ID = '" & newText(UnitId.Trim) & "' And " & _
                     " App='" & App_Project & "'"
        Try
            '   Call OpenConnect(True)
            Da = New SqlDataAdapter(strSQL, Conn)
            Da.Fill(Ds, "data")
            '   Call OpenConnect(False)

            With Ds.Tables("data")
                If .Rows.Count = 0 Then
                    Return False
                Else
                    Return True
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Code is Exist")
            Return False
            Exit Function
        End Try
    End Function

    Private Sub EnaCmd(ByVal Add As Boolean, ByVal Edit As Boolean, ByVal Delete As Boolean)
        btnAdd.Enabled = Add
        btnEdit.Enabled = Edit
        btnDelete.Enabled = Delete
    End Sub

    Private Sub LoadMenu()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select Menu_Id,Menu_Name " & _
                 " From GenCreateMenu_Master " & _
                 " Where App='" & App_Project.Trim & "' " & _
                 " Order by Menu_Id"

        Try
            Da = New SqlDataAdapter(Strsql, Conn)
            Da.Fill(Ds, "DATA")

            With Ds.Tables("DATA")
                If .Rows.Count = 0 Then
                    CboSaveGroup.Text = ""
                    CboSubMenu.Text = ""
                Else
                    CboMenuMain.Items.Clear()
                    CboSubMenu.Items.Clear()

                    CboMenuMain.Items.Add("")
                    CboSubMenu.Items.Add("")
                    For Each Dr As DataRow In .Rows
                        CboMenuMain.Items.Add(Dr("Menu_Name"))
                        CboSubMenu.Items.Add(Dr("Menu_Name"))
                    Next
                End If
            End With
        Catch ex As Exception

        End Try



    End Sub

    Function GetMenuId(MenuName As String) As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select * from GenCreateMenu_Master " & _
                 " Where  Menu_Name='" & Rep_Cote(MenuName.Trim) & "'And " & _
                 " APP='" & App_Project.Trim & "'"

        Try
            Da = New SqlDataAdapter(Strsql, Conn)
            Da.Fill(Ds, "DATA")

            With Ds.Tables("DATA")
                If .Rows.Count = 0 Then
                    Return ""
                Else
                    Return .Rows(0).Item("Menu_Id")
                End If
            End With
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub CboMenuMain_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CboMenuMain.SelectedIndexChanged
        txtMainId.Text = GetMenuId(CboMenuMain.Text.Trim)
    End Sub

    Private Sub CboSubMenu_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CboSubMenu.SelectedIndexChanged
        txtSubId.Text = GetMenuId(CboSubMenu.Text.Trim)
    End Sub

    Private Sub lstGroupMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call LoadMenu()
        Call LoadData() ' ข้อมูลเมนู
        Call LoadGroupMenu()  ' กลุ่มเมนู
        If lstMenu.Items.Count = 0 Then
            BtnGenMenuAuto.Enabled = True
        Else
            BtnGenMenuAuto.Enabled = False
        End If
    End Sub

    Private Sub CboSaveGroup_Click(sender As System.Object, e As System.EventArgs) Handles CboSaveGroup.Click
        Dim strSQL As String
        Dim strType As String
        Dim dCmd As New SqlCommand
        Dim data As New ArrayList
        Dim db As New db
        Dim Tn As SqlTransaction
        '    Dim arrData() As String
        '   Dim List As ListViewItem


        If ChkDATASame(txtMainId.Text.Trim, txtSubId.Text.Trim) = True Then
            MsgBox("รหัสซ้ำ")
            Exit Sub
        End If

        '  Call OpenConnect(True)
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn

        Try
            data.Clear() : strType = ""
            data.Add(txtMainId.Text.Trim) : strType &= "T"
            data.Add(txtSubId.Text.Trim) : strType &= "T"
            data.Add(CboMenuMain.Text.Trim) : strType &= "T"
            data.Add(CboSubMenu.Text.Trim) : strType &= "T"
            data.Add(UserId.Trim) : strType &= "T"
            data.Add(App_Project) : strType &= "T"

            strSQL = "Insert Into GenMenu_Group(M_Id,S_ID,MainMenuName,SubMenuName,UserUpdate,APP) " & _
                                " Values(@P1,@P2,@P3,@P4,@P5,@P6)"
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, data)


            Tn.Commit()
            '    Call OpenConnect(False)
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try

        Call LoadGroupMenu()
    End Sub

    Function ChkDATASame(M As String, S As String) As Boolean
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim Strsql As String = ""

        Strsql = " Select * " & _
                 " From GenMenu_Group " & _
                 " Where M_Id='" & M & "' And " & _
                            " S_ID='" & S & "' And " & _
                            " App='" & App_Project.Trim & "'"

        Try
            DA = New SqlDataAdapter(Strsql, Conn)
            DA.Fill(DS, "DATA")

            With DS.Tables("DATA")
                If .Rows.Count = 0 Then
                    Return False
                Else
                    Return True
                End If
            End With
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub BtnDelGroup_Click(sender As System.Object, e As System.EventArgs) Handles BtnDelGroup.Click
        Dim strSQL As String
        Dim strType As String
        Dim dCmd As New SqlCommand
        Dim data As New ArrayList
        Dim db As New db
        Dim Tn As SqlTransaction
        '    Dim arrData() As String
        '   Dim List As ListViewItem

        '  Call OpenConnect(True)
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn

        Try
            data.Clear() : strType = ""
            data.Add(txtMainId.Text.Trim) : strType &= "T"
            data.Add(txtSubId.Text.Trim) : strType &= "T"
            data.Add(App_Project.Trim) : strType &= "T"


            strSQL = "Delete From GenMenu_Group " & _
                     " Where  M_ID=@P1 And  " & _
                                " S_ID=@P2 And " & _
                                " APP=@P3"

            db.ExecuteCommand(Conn, dCmd, strSQL, strType, data)


            Tn.Commit()
            '   Call OpenConnect(False)
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try

        Call LoadGroupMenu()
    End Sub

    Private Sub LoadGroupMenu()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        Dim arrData() As String
        Dim List As ListViewItem

        strSQL = "select * " & _
                 " From GenMenu_Group " & _
                 " Where  App='" & App_Project.Trim & "' " & _
                 " Order by M_Id"

        Try
            '   Call OpenConnect(True)
            Da = New SqlDataAdapter(strSQL, Conn)
            Da.Fill(Ds, "data")
            '  Call OpenConnect(False)

            With Ds.Tables("data")
                lstMenuGroup.BeginUpdate()
                lstMenuGroup.Items.Clear()
                Dim I As Integer = 0
                For Each drw As DataRow In .Rows
                    I += 1
                    arrData = New String() {I, _
                                            drw("M_Id"), _
                                            drw("S_ID"), _
                                            drw("MainMenuName"), _
                                            drw("SubMenuName")}

                    List = New ListViewItem(arrData)
                    lstMenuGroup.Items.Add(List)
                Next
                lstMenuGroup.EndUpdate()

            End With
        Catch ex As Exception
            lstMenuGroup.EndUpdate()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
    End Sub

    Private Sub lstMenu_DoubleClick(sender As Object, e As System.EventArgs) Handles lstMenu.DoubleClick
        With lstMenu
            If .SelectedItems.Count = 0 Then Exit Sub
            txtMenuId.Text = .SelectedItems(0).SubItems(2).Text.Trim
            txtMenuName.Text = .SelectedItems(0).SubItems(3).Text.Trim
            txtMenuNameEng.Text = .SelectedItems(0).SubItems(4).Text.Trim
            txtNo_Pic.Text = .SelectedItems(0).SubItems(6).Text.Trim

            If .SelectedItems(0).SubItems(8).Text.Trim = "/" Then  ' อนุมัติ
                ChkFormApprove.Checked = True
            Else
                ChkFormApprove.Checked = False
            End If

            If .SelectedItems(0).SubItems(9).Text.Trim = "/" Then  ' ReadOnly
                ChkReadOnly.Checked = True
            Else
                ChkReadOnly.Checked = False
            End If

            If .SelectedItems(0).SubItems(10).Text.Trim = "/" Then  ' กำหนดว่าเป็นเมนูหลักหรือไม่
                ChkMenuMain.Checked = True
            Else
                ChkMenuMain.Checked = False
            End If

            ' Call txtMenuId_LostFocus(Me, System.EventArgs.Empty)
            '  TabControl1.SelectedTabIndex = 1

            Call EnaCmd(False, True, True)
        End With
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        Call LoadMenu()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lstMenu_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstMenu.SelectedIndexChanged

    End Sub

    Private Sub lstMenuGroup_DoubleClick(sender As Object, e As System.EventArgs) Handles lstMenuGroup.DoubleClick
        With lstMenuGroup
            If .SelectedItems.Count = 0 Then Exit Sub
            txtMainId.Text = .SelectedItems(0).SubItems(1).Text.Trim
            txtSubId.Text = .SelectedItems(0).SubItems(2).Text.Trim

            CboMenuMain.Text = .SelectedItems(0).SubItems(3).Text.Trim
            CboSubMenu.Text = .SelectedItems(0).SubItems(4).Text.Trim
        End With

    End Sub


    Private Sub chkByGroup_CheckedChanged(sender As System.Object, e As System.EventArgs)
        Call LoadData()
    End Sub

    Private Sub ChkByItem_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkByItem.CheckedChanged
        Call LoadData()
    End Sub


    Private Sub CheckGenMenu_Master()
        Dim I As Integer = 0
        Dim M As String = ""

        ' mark ple 25/07/2019
        'For Each HeadMenu As ToolStripMenuItem In fMainMenuHD.MenuStrip.Items
        '    I += 1
        '    M = "MN" & Format(I, "00")
        '    If HeadMenu.Name <> "" Then
        '        Check_SetStatusChildMenu(HeadMenu, HeadMenu, M)
        '    End If
        'Next
    End Sub

    Private Sub Check_SetStatusChildMenu(ByVal HeadMenu As ToolStripMenuItem, MainHead As ToolStripMenuItem, NumberMenu As String)

        Dim mnuChild As ToolStripMenuItem
        Dim NameMenu As String = ""
        Dim ChkMenu As Boolean = True
        Dim ChkMenuSub As Boolean = True
        Dim H_Menu As String = ""
        Dim Sub_Menu As String = ""
        Dim HeadMenu_H As String = ""
        Dim ChkMenu_InMaster As String = ""
        Dim MenuComplete As Boolean = False
        Dim Head_MN As String = ""
        Dim MenuSub_Right As String = ""
        'Dim MenuH_Right As String
        Dim MenuThai As String = ""
        Dim ChkHead As String = ""
        Dim HeadMenuThai As String = ""
        Dim MainMenu As String = ""

        HeadMenuThai = HeadMenu.Text
        Head_MN = HeadMenu.Name ' ของเดิมเป็น Tag
        MainMenu = MainHead.Name ' ของเดิมเป็น Tag

        Try
            For i As Integer = 0 To HeadMenu.DropDownItems.Count - 1
                If TypeOf HeadMenu.DropDownItems(i) Is ToolStripMenuItem Then
                    mnuChild = DirectCast(HeadMenu.DropDownItems(i), ToolStripMenuItem)
                    NameMenu = HeadMenu.DropDownItems(i).Name ' ของเดิมเป็น Tag
                    Sub_Menu = GetMenu_Link(HeadMenu.DropDownItems(i).Text) ' ไว้ใช้เช็คเมนูย่อย ระหว่าง เมนูฟอร์ม กันเมนูใน DB
                    MenuSub_Right = RightText(NameMenu, 2) ' หา 2 ตัวท้าย เมนู เช่น M1, M2 
                    MenuThai = HeadMenu.DropDownItems(i).Text

                    '    'Insert Menu
                    Dim A As String = Head_MN
                    Dim B As String = MainMenu
                    If A = B Then ' ถ้าเป็นเมนูหลัก
                        AddMenuToDataBase(True, NumberMenu, HeadMenuThai.Trim, Head_MN)
                        AddMenuToDataBase(False, NumberMenu, mnuChild.Text, NameMenu)
                    Else
                        AddMenuToDataBase(False, NumberMenu, MenuThai.Trim, NameMenu)
                    End If
                    Head_MN = ""

                    ' ตัวย่อยเมนู ======================================================================
                    '-------------------------------------------------------

                    If mnuChild.HasDropDownItems Then
                        ' mnuChild.Enabled = False  '/// I'm Show Recursive Function wed wed wed
                        Check_SetStatusChildMenu(HeadMenu.DropDownItems(i), MainHead, NumberMenu)
                    Else

                    End If

                    '----------------------------------------------------------
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "แจ้งให้ทราบ")
        End Try
    End Sub

    Function GetVisibleMenu(MenuLink As String, Dt As DataTable) As Boolean
        '  Dim DW As DataView = Dt.DefaultView
        Dim DW As New DataView(Dt)
        DW.RowFilter = "Menu_LinkFrom='" & MenuLink.Trim & "'"
        If DW.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Function getDTPermision(UserId As String) As DataTable
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = " Select * " & _
                 " From GenMenu_User " & _
                 " Where  APP='" & App_Project.Trim & "' And " & _
                        " Menu_Use=1 And " & _
                        " UserId='" & UserId.Trim & "' And " & _
                        " Menu_Id in (Select Menu_Id " & _
                                        " from GenCreateMenu_Master " & _
                                        " Where  app='" & App_Project.Trim & "')"


        Da = New SqlDataAdapter(Strsql, Conn)
        Da.Fill(Ds, "DATA")

        Return Ds.Tables("DATA")
    End Function

    Function getDTSaPermision() As DataTable
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = " Select * " & _
                " from GenCreateMenu_Master " & _
                " Where app='" & App_Project.Trim & "'"

        Da = New SqlDataAdapter(Strsql, Conn)
        Da.Fill(Ds, "DATA")

        Return Ds.Tables("DATA")
    End Function

    Function GetMenu_Link(MenuName As String) As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = " Select Menu_LinkFrom " & _
                 " From GenCreateMenu_Master " & _
                 " Where  APP='" & App_Project.Trim & "' And " & _
                        " Menu_Name='" & MenuName.Trim & "'"

        Try
            Da = New SqlDataAdapter(Strsql, Conn)
            Da.Fill(Ds, "DATA")

            With Ds.Tables("DATA")
                If .Rows.Count = 0 Then
                    Return ""
                Else
                    Return .Rows(0).Item("Menu_LinkFrom")
                End If
            End With
        Catch ex As Exception
            Return ""
        End Try
    End Function

    
    Private Sub BtnGenMenuAuto_Click(sender As System.Object, e As System.EventArgs) Handles BtnGenMenuAuto.Click
        Call CheckGenMenu_Master()
        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub btnRunning_Click(sender As System.Object, e As System.EventArgs) Handles btnRunning.Click
        Dim strSQL As String
        Dim strType As String
        Dim dCmd As New SqlCommand
        Dim data As New ArrayList
        Dim db As New db

        If lstMenu.Items.Count = 0 Then
            MsgBox("ไม่มีข้อมูลให้เรียง", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Dim i As Integer
        Dim J As Integer = 0
        For i = 0 To lstMenu.Items.Count - 1
            J += 1

            Try
                data.Clear() : strType = ""
                data.Add(J) : strType &= "S"
                data.Add(lstMenu.Items(i).SubItems(2).Text) : strType &= "T"
                data.Add(App_Project) : strType &= "T"
                ' สำหรับต้นแบบเมนู -----------------------------------------------------------
                strSQL = "Update GenCreateMenu_Master Set RunningNo=@P1 " & _
                          " Where  Menu_Id = @P2 And APP=@P3"

                '       Call OpenConnect(True)
                db.ExecuteCommand(Conn, dCmd, strSQL, strType, data)
                '     Call OpenConnect(False)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Next
    End Sub

    Private Sub btnPageMenu_Click(sender As System.Object, e As System.EventArgs) Handles btnPageMenu.Click
    

        'Dim frm As New frmGenMenu_MasterOnPage
        'frm.ShowDialog()
    End Sub
End Class