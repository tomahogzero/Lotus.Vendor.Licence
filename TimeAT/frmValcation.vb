Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports TimeAttendance.utils

Public Class frmVacation

    Dim ar As ArrayList = GetData.GetHourHaftDay

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Public Sub txtCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.LostFocus
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim strSQL As String

        strSQL = "Select Code,Fname,Lname,Emp.DeptId,Department,Workingplace,Isnull(remark,'') as remark" &
                " From Emp Left Join Department On Emp.DeptId = Department.DeptId " &
                " Where Code = '" & txtCode.Text.Trim & "'"
        DA = New SqlDataAdapter(strSQL, Conn)
        DA.Fill(DS, "Data")
        With DS.Tables("Data")
            If .Rows.Count = 0 Then
                txtCode.Text = ""
                txtName.Text = ""
                txtDeptId.Text = ""
                txtDepartment.Text = ""
                txtRemark.Text = ""
                Exit Sub
            End If
            txtCode.Text = .Rows(0).Item("Code")
            txtName.Text = .Rows(0).Item("Fname") & "   " & .Rows(0).Item("Lname")
            txtDeptId.Text = .Rows(0).Item("DeptId")
            txtDepartment.Text = .Rows(0).Item("Department")
            txtRemark.Text = .Rows(0).Item("remark")
            DS.Clear()
        End With

        '  Call LoadVacation()
        Call LoadVacationDev()

        If rdByDay.Checked = True Then
            If IsDate(txtDate.EditValue) Then
                Call LoadValRemain(cDateTime.dbDate(txtDate.EditValue))
            Else
                txtAmtRemain.Text = "-"
            End If
        End If

    End Sub


    Private Sub LoadVacation()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        ' LoadVacation

        Dim arrDATA() As String
        Dim List As New ListViewItem
        If IsNumeric(txtYear.Text.Trim) = False Then txtYear.Text = Now.Year
        strSQL = "Select TimeVacation.Code,Timevacation.Id,ValDate,ValId," &
                        " isnull(TimeWorkingStatus.Description,'') as Description,Amt," &
                        " Fullday = isnull(TimeVacation.Fullday,'F')," &
                        " Haftday = isnull(TimeVacation.Haftday,'M'), " &
                        " Spa_IO = Isnull(TimeVacation.Spa_IO,0) " &
                " From TimeVacation " &
                        " Left Join TimeWorkingStatus " &
                            " On TimeVacation.ValId = TimeWorkingStatus.Code " &
                " Where TimeVacation.Code = '" & txtCode.Text.Trim & "'"




        If rdYear.Checked = True Then
            strSQL &= " and Year(ValDate) = " & txtYear.Text.Trim & ""
        End If

        strSQL &= " Order By ValDate Desc"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            Dim I As Integer
            lstVacation.Items.Clear()
            For I = 0 To .Rows.Count - 1
                Dim fullday As String = ""
                Dim haftday As String = ""
                Dim Spa_IO As String = ""

                Select Case .Rows(I).Item("Haftday").ToString
                    Case "M"
                        '  haftday = "ช่วงเช้า"
                        haftday = My.Resources.res_valcation.haftday_morning
                    Case "A"
                        '  haftday = "ช่วงบ่าย"
                        haftday = My.Resources.res_valcation.haftday_afternoon
                End Select

                Select Case .Rows(I).Item("Fullday").ToString
                    Case "F"
                        '  fullday = "เต็มวัน"
                        fullday = My.Resources.res_valcation.fullday
                        haftday = ""
                    Case "H"
                        '  fullday = "ครึ่งวัน"
                        fullday = My.Resources.res_valcation.haftday
                    Case "S"
                        '  fullday = "ลาพิเศษ"
                        fullday = My.Resources.res_valcation.spa_leave
                End Select

                If .Rows(I).Item("Spa_IO") = True Then
                    Spa_IO = "/"
                Else
                    Spa_IO = ""
                End If

                arrDATA = New String() {I + 1,
                                        .Rows(I).Item("Id").ToString,
                                        Format(.Rows(I).Item("ValDate"), "dd/MM/yyyy"),
                                        .Rows(I).Item("Description"),
                                        .Rows(I).Item("Amt"),
                                        fullday.Trim,
                                        haftday.Trim,
                                        Spa_IO}
                List = New ListViewItem(arrDATA)
                lstVacation.Items.Add(List)
            Next
            Ds.Clear()
        End With
    End Sub

    Private Sub LoadVacationDev()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        ' LoadVacation

        'Dim arrDATA() As String
        'Dim List As New ListViewItem
        If IsNumeric(txtYear.Text.Trim) = False Then txtYear.Text = Now.Year
        'strSQL = "Select TimeVacation.Code,Timevacation.Id,ValDate,ValId," &
        '                " TimeWorkingStatus.Description,Amt," &
        '                " Fullday = isnull(TimeVacation.Fullday,'F')," &
        '                " Haftday = isnull(TimeVacation.Haftday,'M'), " &
        '                " Spa_IO = Isnull(TimeVacation.Spa_IO,0) " &
        '        " From TimeVacation " &
        '                " Left Join TimeWorkingStatus " &
        '                    " On TimeVacation.ValId = TimeWorkingStatus.Code " &
        '        " Where TimeVacation.Code = '" & txtCode.Text.Trim & "'"


        strSQL = "Select  ROW_NUMBER() OVER(Order by ValDate Desc) as row, " &
                        " v.Code,v.Id,ValDate,ValId," &
                        " isnull(TimeWorkingStatus.Description,'') as Description,Amt,Spa_IO,isnull(v.remark,'') as remark " &
                      " ,isnull(v.FullDay,'') as Fullday" &
                      " ,isnull(v.Haftday,'') as Haftday" &
                      " ,isnull(v.spa_hour_in,0) as spa_hour_in" &
                      " ,isnull(v.spa_hour_out,0) as spa_hour_out" &
                      " ,fullday_str = case " &
                                    " when v.Fullday = 'F' then '" & My.Resources.res_valcation.fullday & "' " &
                                    " When v.Fullday = 'H' then '" & My.Resources.res_valcation.haftday & "'" &
                                    " when v.Fullday = 'S' then '" & My.Resources.res_valcation.Leave_Hr & "'" &
                                    " else '' end" &
                        ",halfday_str = case " &
                                    " when v.Fullday = 'F' then ''" &
                                    " when v.Fullday = 'H' and v.Haftday = 'M' then '" & My.Resources.res_valcation.haftday_morning & "' " &
                                    " when v.Fullday = 'H' and v.Haftday = 'A' then '" & My.Resources.res_valcation.haftday_afternoon & "'" &
                                    " else '' end" &
                        ",spa_str = case " &
                                    " when v.Fullday in ('F','H') then ''" &
                                    " when v.Fullday = 'S' and isnull(v.spa_hour_in,0) = 1 then '" & My.Resources.res_valcation.spa_morning & "'" &
                                    " when v.Fullday = 'S' and isnull(v.spa_hour_out,0) = 1 then '" & My.Resources.res_valcation.spa_afternoom & "'" &
                                    " else '' end" &
                " From TimeVacation v " &
                        " Left Join TimeWorkingStatus " &
                            " On v.ValId = TimeWorkingStatus.Code " &
                " Where v.Code = '" & txtCode.Text.Trim & "'"

        If rdYear.Checked = True Then
            strSQL &= " and Year(ValDate) = " & txtYear.Text.Trim & ""
        End If

        strSQL &= " Order By ValDate Desc"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")

        GcVacation.DataSource = Ds
        GcVacation.DataMember = "Data"
    End Sub


    Private Sub txtDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.GotFocus
        txtDate.SelectAll()
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call ClearVacation()
        Call LoadVacation()
        txtCode.Focus()
        txtCode.SelectAll()
        Call EnaCmd(True, False, False)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim dCmd As New SqlCommand
        Dim strSQL As String

        Dim Replace As Boolean = False



        If rdByDay.Checked = True Then
            If IsDate(txtDate.EditValue) = False Then
                'MsgBox("กรุณาป้อนวันที่ให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
                '   MsgManager.ShowDialog(Me, "frmVacationRS", Me.Text, "Check_Date", MessageBoxIcon.Information)
                MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
                txtDate.Focus()
                txtDate.SelectAll()
                Exit Sub
            End If

            If VacationIsExist(dCmd, txtCode.Text.Trim, cDateTime.dbDate(txtDate.EditValue), cDateTime.dbDate(txtDate.EditValue)) = True Then

                'If MsgManager.ConfirmDialog(Me, "frmVacationRS", Me.Text, "Repleace_Data",
                '    MessageBoxIcon.Information) = DialogResult.OK Then
                If MsgBox(My.Resources.res_warning_message_spacial.repleace_Data, MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = vbNo Then
                    Replace = True
                Else
                    Replace = False
                End If

                'If MsgBox("มีข้อมูลอยู่แล้วคุณต้องการเขียนข้อมูลทับหรือเปล่า", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                '    Replace = True
                'Else
                '    Replace = False
                'End If
            End If
        Else
            If IsDate(txtDateST.EditValue) = False Then
                'MsgBox("กรุณาป้อนวันที่ให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
                '  MsgManager.ShowDialog(Me, "frmVacationRS", Me.Text, "Check_Date", MessageBoxIcon.Information)
                MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
                txtDateST.Focus()
                txtDateST.SelectAll()
                Exit Sub
            End If
            If IsDate(txtDateSP.EditValue) = False Then
                'MsgBox("กรุณาป้อนวันที่ให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
                '   MsgManager.ShowDialog(Me, "frmVacationRS", Me.Text, "Check_Date", MessageBoxIcon.Information)
                MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
                txtDateSP.Focus()
                txtDateSP.SelectAll()
                Exit Sub
            End If

            If CDate(cDateTime.dbDate(txtDateSP.EditValue)) < CDate(cDateTime.dbDate(txtDateST.EditValue)) Then
                'MsgBox("วันสุดท้ายน้อยกว่าวันที่เริ่มต้นกรุณากรอกใหม่", MsgBoxStyle.Information, Me.Text)
                '  MsgManager.ShowDialog(Me, "frmVacationRS", Me.Text, "Insert_Data_Again", MessageBoxIcon.Information)

                MsgBox(My.Resources.res_warning_message_spacial.Insert_Data_Again, MsgBoxStyle.Information, Me.Text)
                txtDateSP.Focus()
                Exit Sub
            End If

            If VacationIsExist(dCmd, txtCode.Text.Trim, cDateTime.dbDate(txtDateST.EditValue), cDateTime.dbDate(txtDateSP.EditValue)) = True Then
                'If MsgBox("มีข้อมูลอยู่ในระหว่างช่วงที่กำหนด คุณต้องการเขียนข้อมูลทับหรือเปล่า", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                '    Replace = True
                'Else
                '    Replace = False
                'End If

                'If MsgManager.ConfirmDialog(Me, "frmVacationRS", Me.Text, "Repleace_Data_2",
                '   MessageBoxIcon.Information) = DialogResult.OK Then

                If MsgBox(My.Resources.res_warning_message_spacial.Repleace_Data_2, MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) Then
                    Replace = True
                Else
                    Replace = False
                End If
            End If
        End If


        If txtName.Text.Trim = "" Then
            'MsgBox("กรุณาป้อนรหัสพนักงานด้วย", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmVacationRS", Me.Text, "Insert_EmpID", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.Insert_EmpID, MsgBoxStyle.Information, Me.Text)
            txtCode.Focus()
            Exit Sub
        End If

        If lblValCode.Text.Trim = "" Then
            'MsgBox("กรุณาเลือกประเภทการลาด้วย", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmVacationRS", Me.Text, "Select_Vacation", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message_spacial.Select_Vacation, MsgBoxStyle.Information, Me.Text)
            cboWorkingStatus.Focus()
            Exit Sub
        End If


        If txtAmtRemain.Text = "0" Then  ' ถือว่ามีการกำหนดสิทธิการลาแล้ว   แต่ถ้าเป็น   (-) ขีด   ให้ปล่อยให้ป้อนได้เลย 
            'MsgBox("ไม่สามารถบันทึกข้อมูลได้เนื่องจากสิทธิในการลาหมด", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "วันลาหมด")
            '  MsgManager.ShowDialog(Me, "frmVacationRS", Me.Text, "Save_Failed", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message_spacial.Save_Failed, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If


        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            Dim Fullday As String = "F"
            Dim Haftday As String = "M"
            If rdFullDay.Checked = True Then
                Fullday = "F"
            ElseIf rdHaftDay.Checked = True Then
                Fullday = "H"
            ElseIf rdSpa.Checked = True Then
                Fullday = "S"
            End If

            If rdMorning.Checked = True Then
                Haftday = "M"
            ElseIf rdAfternoon.Checked = True Then
                Haftday = "A"
            End If

            If rdByDay.Checked = True Then
                If VacationIsExist(dCmd, txtCode.Text.Trim, cDateTime.dbDate(txtDate.EditValue), cDateTime.dbDate(txtDate.EditValue)) = True Then
                    If Replace = True Then
                        strSQL = "Delete From TimeVacation" &
                                " Where Code = '" & txtCode.Text.Trim & "' and " &
                                        " Convert(nVarchar(10),ValDate,111) = '" & cDateTime.dbDate(txtDate.EditValue) & "'"
                        dCmd.Connection = Conn
                        dCmd.CommandText = strSQL
                        dCmd.ExecuteNonQuery()

                        strSQL = "Insert Into TimeVacation(Code,ValDate,ValId,Amt,Fullday,Haftday,spa_hour_in,spa_hour_out,remark) Values(" &
                                    " '" & txtCode.Text.Trim & "'," &
                                    " '" & cDateTime.dbDate(txtDate.EditValue) & "'," &
                                    " '" & lblValCode.Text.Trim & "'," &
                                    " " & txtAmt.Text.Trim & "," &
                                    " '" & Fullday.Trim & "','" & Haftday.Trim & "'," &
                                    " " & IIf(rdSpa_IO_In.Checked, 1, 0) & "," &
                                    " " & IIf(rdSpa_IO_Out.Checked, 1, 0) & ", " &
                                    " '" & txtRemark.Text.Trim & "')"
                        dCmd.Connection = Conn
                        dCmd.CommandText = strSQL
                        dCmd.ExecuteNonQuery()
                    End If
                Else
                    strSQL = "Insert Into TimeVacation(Code,ValDate,ValId,Amt,Fullday,Haftday,spa_hour_in,spa_hour_out,remark) Values(" &
                                    " '" & txtCode.Text.Trim & "'," &
                                    " '" & cDateTime.dbDate(txtDate.EditValue) & "'," &
                                    " '" & lblValCode.Text.Trim & "'," &
                                    " " & txtAmt.Text.Trim & "," &
                                    " '" & Fullday.Trim & "','" & Haftday.Trim & "'," &
                                    " " & IIf(rdSpa_IO_In.Checked, 1, 0) & "," &
                                    " " & IIf(rdSpa_IO_Out.Checked, 1, 0) & ", " &
                                    " '" & txtRemark.Text.Trim & "')"
                    dCmd.Connection = Conn
                    dCmd.CommandText = strSQL
                    dCmd.ExecuteNonQuery()
                End If

                Call cProcessTime.processAbs(dCmd, cDateTime.dbDate(txtDate.EditValue), txtCode.Text.Trim)
            Else
                Dim dSt As DateTime = cDateTime.dbDate(txtDateST.EditValue)
                Dim dSp As DateTime = cDateTime.dbDate(txtDateSP.EditValue)
                Dim dR As DateTime = dSt
                Do Until dR > dSp
                    Call LoadValRemain(dCmd, Format(dR, "yyyy/MM/dd"))

                    If txtAmtRemain.Text = "0" Then  ' ถือว่ามีการกำหนดสิทธิการลาแล้ว   แต่ถ้าเป็น   (-) ขีด   ให้ปล่อยให้ป้อนได้เลย 
                        ' MsgManager.ShowDialog(Me, "frmVacationRS", Me.Text, "Save_Failed_Vacation", MessageBoxIcon.Exclamation)
                        'MsgBox("ไม่สามารถบันทึกข้อมูลได้เนื่องจากสิทธิในการลาหมด เนื่องจากช่วงเวลาที่กำหนดเกินสิทธิที่ได้กำหนดไว้", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "วันลาหมด")

                        MsgBox(My.Resources.res_warning_message_spacial.Save_Failed_Vacation, MsgBoxStyle.Information, Me.Text)
                        Tn.Rollback()
                        Exit Sub
                    End If

                    If VacationIsExist(dCmd, txtCode.Text.Trim, dR, dR) = True Then
                        If Replace = True Then
                            strSQL = "Delete From TimeVacation" &
                                    " Where Code = '" & txtCode.Text.Trim & "' and " &
                                            " Convert(nVarchar(10),ValDate,111) = '" & Format(dR, "yyyy/MM/dd") & "'"
                            dCmd.Connection = Conn
                            dCmd.CommandText = strSQL
                            dCmd.ExecuteNonQuery()

                            strSQL = "Insert Into TimeVacation(Code,ValDate,ValId,Amt,Fullday,Haftday,spa_hour_in,spa_hour_out,remark) Values(" &
                                    " '" & txtCode.Text.Trim & "'," &
                                    " '" & Format(dR, "yyyy/MM/dd") & "'," &
                                    " '" & lblValCode.Text.Trim & "'," &
                                    " " & txtAmt.Text.Trim & "," &
                                    " '" & Fullday.Trim & "','" & Haftday.Trim & "'," &
                                    " " & IIf(rdSpa_IO_In.Checked, 1, 0) & "," &
                                    " " & IIf(rdSpa_IO_Out.Checked, 1, 0) & ", " &
                                    " '" & txtRemark.Text.Trim & "')"
                            dCmd.Connection = Conn
                            dCmd.CommandText = strSQL
                            dCmd.ExecuteNonQuery()
                        End If
                    Else
                        strSQL = "Insert Into TimeVacation(Code,ValDate,ValId,Amt,Fullday,Haftday,spa_hour_in,spa_hour_out,remark) Values(" &
                                " '" & txtCode.Text.Trim & "'," &
                                " '" & Format(dR, "yyyy/MM/dd") & "'," &
                                " '" & lblValCode.Text.Trim & "'," &
                                " " & txtAmt.Text.Trim & "," &
                                " '" & Fullday.Trim & "','" & Haftday.Trim & "'," &
                                    " " & IIf(rdSpa_IO_In.Checked, 1, 0) & "," &
                                    " " & IIf(rdSpa_IO_Out.Checked, 1, 0) & ", " &
                                    " '" & txtRemark.Text.Trim & "')"
                        dCmd.Connection = Conn
                        dCmd.CommandText = strSQL
                        dCmd.ExecuteNonQuery()
                    End If

                    Call cProcessTime.processAbs(dCmd, cDateTime.dbDate(dR), txtCode.Text.Trim)

                    dR = dR.AddDays(1)
                Loop
            End If
            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Function VacationIsExist(ByVal dCmd As SqlCommand, ByVal Code As String, ByVal DateST As Date, ByVal DateSP As Date) As Boolean
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        strSQL = "Select Code From TimeVacation " &
                " Where Code = '" & Code.Trim & "' and " &
                        " Convert(nvarchar(10),ValDate,111) Between '" & Format(DateST, "yyyy/MM/dd") & "' and " &
                                " '" & Format(DateSP, "yyyy/MM/dd") & "'"
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        End With
    End Function

    Private Sub ClearVacation()
        lblId.Text = ""
        txtDate.Text = ""
        txtDateST.Text = ""
        txtDateSP.Text = ""
        rdFullDay.Checked = True
        rdMorning.Checked = True
        txtDate.Refresh()
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

    Private Sub frmEditTime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbVacationHaftDay.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False

        txtDate.EditValue = Now.Date
        txtDateST.EditValue = Now.Date
        txtDateSP.EditValue = Now.Date
        txtYear.Text = Date.Now.Year
        Call LoadWorkingStatus()
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

        If IsDate(txtDate.EditValue) = False Then
            'MsgBox("กรุณาป้อนวันที่ให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmVacationRS", Me.Text, "Check_Date", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
            txtDate.Focus()
            txtDate.SelectAll()
            Exit Sub
        End If

        If txtName.Text.Trim = "" Then
            'MsgBox("กรุณาป้อนรหัสพนักงานด้วย", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmVacationRS", Me.Text, "Insert_EmpID", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.Insert_EmpID, MsgBoxStyle.Information, Me.Text)
            txtCode.Focus()
            Exit Sub
        End If

        If lblValCode.Text.Trim = "" Then
            'MsgBox("กรุณาเลือกประเภทการลาด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmVacationRS", Me.Text, "Select_Vacation", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message_spacial.Select_Vacation, MsgBoxStyle.Information, Me.Text)
            cboWorkingStatus.Focus()
            Exit Sub
        End If

        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            Dim Fullday As String = "F"
            Dim Haftday As String = "M"
            If rdFullDay.Checked = True Then
                Fullday = "F"
            ElseIf rdHaftDay.Checked = True Then
                Fullday = "H"
            ElseIf rdSpa.Checked = True Then
                Fullday = "S"
            End If

            If rdMorning.Checked = True Then
                Haftday = "M"
            ElseIf rdAfternoon.Checked = True Then
                Haftday = "A"
            End If

            strSQL = "Update TimeVacation Set ValDate = '" & cDateTime.dbDate(txtDate.EditValue) & "'," &
                                    " ValId = '" & lblValCode.Text.Trim & "'," &
                                    " Amt = " & txtAmt.Text.Trim & ", " &
                                    " Fullday = '" & Fullday.Trim & "'," &
                                    " haftday = '" & Haftday.Trim & "', " &
                                    " spa_hour_in = " & IIf(rdSpa_IO_In.Checked, 1, 0) & "," &
                                    " spa_hour_out = " & IIf(rdSpa_IO_Out.Checked, 1, 0) & ", " &
                                    " remark='" & txtRemark.Text.Trim & "'" &
                    " Where Id = '" & lblId.Text.Trim & "'"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()


            Call cProcessTime.processAbs(dCmd, cDateTime.dbDate(txtDate.EditValue), txtCode.Text.Trim)

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

        If IsDate(txtDate.EditValue) = False Then
            'MsgBox("กรุณาป้อนวันที่ให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmVacationRS", Me.Text, "Check_Date", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
            txtDate.Focus()
            txtDate.SelectAll()
            Exit Sub
        End If

        If txtName.Text.Trim = "" Then
            'MsgBox("กรุณาป้อนรหัสพนักงานด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmVacationRS", Me.Text, "Insert_EmpID", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.Insert_EmpID, MsgBoxStyle.Information, Me.Text)
            txtCode.Focus()
            Exit Sub
        End If


        Try
            strSQL = "Delete TimeVacation " &
              " Where id = '" & lblId.Text.Trim & "'"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()


            Call cProcessTime.processAbs(dCmd, cDateTime.dbDate(txtDate.EditValue), txtCode.Text.Trim)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub



    Private Sub LoadWorkingStatus()
        'Dim Da As New SqlDataAdapter
        'Dim Ds As New DataSet
        'Dim strSQL As String
        'strSQL = "Select Code,Description,Pay from TimeWorkingstatus Order By Description"
        'Da = New SqlDataAdapter(strSQL, Conn)
        'Da.Fill(Ds, "Data")
        'With Ds.Tables("Data")
        '    cboWorkingStatus.Properties.Items.Clear()
        '    Dim I As Integer
        '    For I = 0 To .Rows.Count - 1
        '        cboWorkingStatus.Properties.Items.Add(.Rows(I).Item("Description"))
        '    Next
        '    Ds.Clear()
        'End With

        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select Code,"

        strSQL &= "Description,"
        'If cValGolbal.Lang = "TH" Then
        '    strSQL &= "Description,"
        'Else
        '    strSQL &= "Description_Eng as Description,"
        'End If

        strSQL &= "Pay " &
                " from TimeWorkingstatus " &
                " Order By Description"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")

        cboWorkingStatus.Properties.DataSource = Ds.Tables("Data")
        cboWorkingStatus.Properties.DisplayMember = "Description"
        cboWorkingStatus.Properties.ValueMember = "Code"

        If Ds.Tables("Data").Rows.Count > 0 Then
            cboWorkingStatus.EditValue = Ds.Tables("Data").Rows(0).Item("Code")
        End If
    End Sub

    Private Sub cboWorkingStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
            rdFullDay.Checked = True
            rdMorning.Checked = True
            Ds.Clear()
        End With

        If rdByDay.Checked = True Then
            If IsDate(txtDate.EditValue) Then
                Call LoadValRemain(cDateTime.dbDate(txtDate.EditValue))
            Else
                txtAmtRemain.Text = "-"
            End If
        End If
    End Sub

    Private Sub lstVacation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstVacation.SelectedIndexChanged

    End Sub

    Private Sub txtDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.LostFocus
        If rdByDay.Checked = True Then
            If IsDate(txtDate.EditValue) Then
                Call LoadValRemain(cDateTime.dbDate(txtDate.EditValue))
            Else
                txtAmtRemain.Text = "-"
            End If
        End If
    End Sub


    Private Sub rdFullDay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdFullDay.CheckedChanged
        If rdFullDay.Checked = True Then
            txtAmt.Text = 8
            txtDay.Text = 1
            tbVacationHaftDay.Visible = False
        Else
            tbVacationHaftDay.Visible = True
            txtAmt.Text = 8
            txtDay.Text = 1
            'txtAmt.Enabled = False
            'txtDay.Enabled = False
        End If
        txtAmt.Enabled = False
        txtDay.Enabled = False
    End Sub

    Private Sub rdHaftDay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdHaftDay.CheckedChanged
        If rdHaftDay.Checked = True Then
            tbVacationHaftDay.Visible = True
            tbVacationHaftDay.SelectedTabPageIndex = 0

            If rdMorning.Checked = True Then
                txtAmt.Text = ar(0)
                txtDay.Text = 0.5
                txtAmt.Enabled = False
            Else
                txtAmt.Text = ar(1)
                txtDay.Text = 0.5
                txtAmt.Enabled = False
            End If
            'Else
            '    If rdMorning.Checked = True Then
            '        txtAmt.Text = ar(0)
            '        txtDay.Text = 0.5
            '    Else
            '        txtAmt.Text = ar(1)
            '        txtDay.Text = 0.5
            '    End If
            txtAmt.Enabled = False
            txtDay.Enabled = False
        End If
    End Sub

    Private Sub txtAmt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmt.LostFocus
        If IsNumeric(txtAmt.Text) = False Then txtDay.Text = 0 : Exit Sub
        If CSng(txtAmt.Text) > 8 Then
            'MsgBox("จำนวนชม.ที่ชดเชยไม่ควร 4 ชม.กรุณาตรวจสอบด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmVacationRS", Me.Text, "Check_Hour", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message_spacial.Check_Hour, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If
        txtDay.Text = CSng(txtAmt.Text.Trim) / 8
    End Sub


    Private Sub rdSpa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdSpa.CheckedChanged
        tbVacationHaftDay.SelectedTabPageIndex = 1
        txtAmt.Enabled = True
        txtAmt.ReadOnly = False
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        '  Call LoadVacation()
        Call LoadVacationDev()
    End Sub

    Function GetValcationRemain(ByVal strDate As String) As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        Dim Year As String
        Dim Code As String
        Dim ValCode As String

        Dim Remain As Single = 0


        Year = CDate(strDate).Year

        If txtCode.Text.Trim = "" Then
            Return -1
        Else
            Code = txtCode.Text.Trim
        End If

        If lblValCode.Text.Trim = "" Then
            Return -1
        Else
            ValCode = lblValCode.Text.Trim
        End If




        strSQL = "select Remain = isnull(dbo.fValRemain_Str('" & Year.Trim & "','" & Code.Trim & "','" & ValCode & "'),-1)"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return "-"
            Else
                Return .Rows(0).Item("Remain")
            End If
        End With
    End Function

    Function GetValcationRemain(ByVal dCmd As SqlCommand, ByVal strDate As String) As Single
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        Dim Year As String
        Dim Code As String
        Dim ValCode As String

        Dim Remain As Single = 0


        Year = CDate(strDate).Year

        If txtCode.Text.Trim = "" Then
            Return -1
        Else
            Code = txtCode.Text.Trim
        End If

        If lblValCode.Text.Trim = "" Then
            Return -1
        Else
            ValCode = lblValCode.Text.Trim
        End If




        strSQL = "select Remain = isnull(dbo.fValRemain('" & Year.Trim & "','" & Code.Trim & "','" & ValCode & "'),-1)"
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()
        Da.SelectCommand = dCmd
        'Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return -1
            Else
                Return .Rows(0).Item("Remain")
            End If
        End With
    End Function

    Private Sub LoadValRemain(ByVal strDate As String)
        Dim Remain As String = GetValcationRemain(strDate)
        If Remain = "-" Then
            txtAmtRemain.Text = "-"
        Else
            txtAmtRemain.Text = Remain
        End If
    End Sub

    Private Sub LoadValRemain(ByVal dCmd As SqlCommand, ByVal strDate As String)
        Dim Remain As Single = GetValcationRemain(dCmd, strDate)
        If Remain = -1 Then
            txtAmtRemain.Text = "-"
        Else
            txtAmtRemain.Text = Remain
        End If
    End Sub

    Private Sub rdByRange_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdByRange.CheckedChanged
        If rdByRange.Checked = True Then
            rdFullDay.Checked = True
            rdFullDay.Enabled = False
            rdHaftDay.Enabled = False
            rdSpa.Enabled = False
            txtDate.Text = ""
        End If
    End Sub

    Private Sub rdByDay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdByDay.CheckedChanged
        If rdByDay.Checked = True Then
            rdFullDay.Enabled = True
            rdHaftDay.Enabled = True
            rdSpa.Enabled = True

            txtDateST.Text = ""
            txtDateSP.Text = ""
        End If

        If rdByDay.Checked = True Then
            If IsDate(txtDate.EditValue) Then
                Call LoadValRemain(cDateTime.dbDate(txtDate.EditValue))
            Else
                txtAmtRemain.Text = "-"
            End If
        End If
    End Sub

    Private Sub btnDelete_Sel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete_Sel.Click
        'If MsgBox("คุณต้องการลบข้อมูลที่เลือกไว้จริงๆ หรือไม่", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then Exit Sub
        'If MsgManager.ConfirmDialog(Me, "frmVacationRS", Me.Text, "Confirm_Del",
        'MessageBoxIcon.Information) = DialogResult.Cancel Then Exit Sub

        If MsgBox(My.Resources.res_warning_message.Confirm_Del, MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = vbNo Then Exit Sub

        Dim dCmd As New SqlCommand
        Dim strSQL As String



        '    If lstVacation.CheckedItems.Count = 0 Then
        '    'MsgBox("กรุณาเลือกข้อมูลที่ต้องการลบด้วย", MsgBoxStyle.Information, Me.Text)
        '    MsgManager.ShowDialog(Me, "frmVacationRS", Me.Text, "Select_Del", MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        'Dim Tn As SqlTransaction
        'Tn = Conn.BeginTransaction
        'dCmd.Transaction = Tn
        'Try
        '    For i As Integer = 0 To lstVacation.CheckedItems.Count - 1
        '        strSQL = "Delete TimeVacation " &
        '                " Where id = '" & lstVacation.CheckedItems(i).SubItems(1).Text.Trim & "'"
        '        dCmd.Connection = Conn
        '        dCmd.CommandText = strSQL
        '        dCmd.ExecuteNonQuery()
        '    Next
        '    Tn.Commit()
        'Catch ex As Exception
        '    Tn.Rollback()
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        '    Exit Sub
        'End Try


        Dim Tn As SqlTransaction

        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            GvVacation.GetRowCellValue(GvVacation.FocusedRowHandle, "Id").ToString()

            For Each i As Long In GvVacation.GetSelectedRows

                Dim dr As DataRow = GvVacation.GetDataRow(i)
                'ลบข้อมูลเดิมออก
                strSQL = "Delete TimeVacation  Where id = '" & dr("Id").ToString & "'"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()

            Next
            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try

        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub rdMorning_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdMorning.CheckedChanged, rdSpa_IO_In.CheckedChanged, rdSpa_IO_Out.CheckedChanged
        Call rdHaftDay_CheckedChanged(Me, System.EventArgs.Empty)
    End Sub

    Private Sub rdAfternoon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdAfternoon.CheckedChanged, rdSpa_Between.CheckedChanged
        Call rdHaftDay_CheckedChanged(Me, System.EventArgs.Empty)
    End Sub


    Private Sub GvVacation_DoubleClick(sender As Object, e As EventArgs) Handles GvVacation.DoubleClick
        Try
            Dim gv As GridView = CType(sender, GridView)

            If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "Code")) = True Then Exit Sub

            Dim fullDay As String = ""

            lblId.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Id").ToString
            txtDate.EditValue = gv.GetRowCellValue(gv.FocusedRowHandle, "ValDate")
            cboWorkingStatus.EditValue = gv.GetRowCellValue(gv.FocusedRowHandle, "ValId")

            fullDay = gv.GetRowCellValue(gv.FocusedRowHandle, "Fullday")
            Select Case fullDay
                Case "F"
                    rdFullDay.Checked = True
                Case "H"
                    rdHaftDay.Checked = True
                Case "S"
                    rdSpa.Checked = True
                Case Else
                    rdFullDay.Checked = True
            End Select
            Select Case gv.GetRowCellValue(gv.FocusedRowHandle, "Haftday")
                Case "M"
                    rdMorning.Checked = True
                Case "A"
                    rdAfternoon.Checked = True
                Case Else
                    rdMorning.Checked = True
            End Select


            rdSpa_Between.Checked = True

            If gv.GetRowCellValue(gv.FocusedRowHandle, "spa_hour_in") = True Then
                rdSpa_IO_In.Checked = True
            End If

            If gv.GetRowCellValue(gv.FocusedRowHandle, "spa_hour_out") = True Then
                rdSpa_IO_Out.Checked = True
            End If


            txtAmt.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Amt")
            txtRemark.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "remark")
            txtAmt_LostFocus(Me, System.EventArgs.Empty)
            Call EnaCmd(False, True, True)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnToDate_Click(sender As Object, e As EventArgs) Handles btnToDate.Click
        txtDateSP.EditValue = txtDateST.EditValue
    End Sub

    'Private Sub btnshowHide_Click(sender As Object, e As EventArgs)
    '    If btnshowHide.Text = "ซ่อนค้นหา" Then
    '        btnshowHide.Text = "แสดงค้นหา"
    '        spcon.SplitterPosition = 0
    '    Else
    '        btnshowHide.Text = "ซ่อนค้นหา"
    '        spcon.SplitterPosition = 319
    '    End If
    'End Sub

    Private Sub txtCode_EditValueChanged(sender As Object, e As EventArgs) Handles txtCode.EditValueChanged

    End Sub

    Private Sub cboWorkingStatus_EditValueChanged(sender As Object, e As EventArgs) Handles cboWorkingStatus.EditValueChanged
        If cboWorkingStatus.EditValue Is Nothing Then
            lblValCode.Text = ""
        Else
            lblValCode.Text = cboWorkingStatus.EditValue
        End If


        rdFullDay.Checked = True
        rdMorning.Checked = True


        If rdByDay.Checked = True Then
            If IsDate(txtDate.EditValue) Then
                Call LoadValRemain(cDateTime.dbDate(txtDate.EditValue))
            Else
                txtAmtRemain.Text = "-"
            End If
        End If
    End Sub

    Private Sub GcVacation_Click(sender As Object, e As EventArgs) Handles GcVacation.Click

    End Sub

    Private Sub GvVacation_Disposed(sender As Object, e As EventArgs) Handles GvVacation.Disposed

    End Sub

    Private Sub lblValCode_Click(sender As Object, e As EventArgs) Handles lblValCode.Click

    End Sub
End Class