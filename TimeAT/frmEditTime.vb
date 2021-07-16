Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports TimeAttendance.utils

Public Class frmEditTime
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        txtDate.EditValue = Now.Date
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Enum TimeIO
        Time_IN
        Time_OUT
    End Enum

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Public Sub txtCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.LostFocus
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim strSQL As String
        strSQL = "Select Code,Fname,Lname," &
                        " DeptID = Isnull(Emp.DeptId,'')," &
                        " Department = Isnull(Department,'')," &
                        " isnull(emp.Ka_Spacial,0) as ka_spacial" &
                " From Emp Left Join Department On Emp.DeptId = Department.DeptId " &
                " Where Code = '" & txtCode.Text.Trim & "' and " &
                        " Emp.CompanyID like '" & IIf(ComId.Trim = "", "%", ComId.Trim) & "' "
        DA = New SqlDataAdapter(strSQL, Conn)
        DA.Fill(DS, "Data")
        With DS.Tables("Data")
            If .Rows.Count = 0 Then
                txtCode.Text = ""
                txtName.Text = ""
                txtDeptId.Text = ""
                txtDepartment.Text = ""
                txtSite.Text = ""
                chkka_spaical.Checked = False
                Call LoadTime()
                Exit Sub
            End If
            txtCode.Text = .Rows(0).Item("Code")
            txtName.Text = .Rows(0).Item("Fname") & "   " & .Rows(0).Item("Lname")
            txtDeptId.Text = .Rows(0).Item("DeptId")
            txtDepartment.Text = .Rows(0).Item("Department")
            chkka_spaical.Checked = .Rows(0).Item("ka_spacial")
            DS.Clear()
        End With

        Call LoadEmpKa(txtCode.Text.Trim, cDateTime.dbDate(txtDate.EditValue))
        Call LoadTime()
    End Sub

    Private Sub LoadEmpKa(ByVal Code As String, ByVal strDate As String)
        Dim KaCode As String

        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select KaCode = Isnull(dbo.fGetKaCode_Edit('" & Code.Trim & "','" & strDate.Trim & "'),'')"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                KaCode = ""
            Else
                KaCode = .Rows(0).Item("KaCode")
            End If
        End With
        Call LoadKa(KaCode)
    End Sub


    Private Sub LoadTime()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        ' LoadTime
        If IsDate(cDateTime.dbDate(txtDate.EditValue)) = False Then
            Exit Sub
        End If



        Dim DateST As String = GetKaScope(lblKaCode.Text.Trim, cDateTime.dbDate(txtDate.EditValue), txtStartDay.Text, IIf(chkStartDay_PD.Checked, 1, 0), TimeIO.Time_IN)
        Dim DateSP As String = GetKaScope(lblKaCode.Text.Trim, cDateTime.dbDate(txtDate.EditValue), txtEndDay.Text, IIf(chkTimeEndDay_NextDay.Checked, 1, 0), TimeIO.Time_OUT)

        strSQL = "Select ROW_NUMBER() OVER(ORDER BY DateIn) as row, Id,Code," &
                        " [DateIn] = convert(date,DateIn)," &
                        " [tmDate] = Convert(nVarchar(10),DateIn,111)," &
                        " [tmTime] = Right(Convert(nVarchar(16),DateIn,120),5) " &
                        " ,SystemGet" &
                " From TimeMaster " &
                " Where Code = '" & txtCode.Text.Trim & "' and " &
                        " Replace(Convert(nVarchar(16),DateIn,120),'-','/') Between '" & DateST.Trim & "' and '" & DateSP.Trim & "'" &
                " Order By DateIn"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")

        gcTimeEdit.DataSource = Ds
        gcTimeEdit.DataMember = "Data"

        'With Ds.Tables("Data")
        '    Dim I As Integer
        '    lstTimeEdit.Items.Clear()
        '    For I = 0 To .Rows.Count - 1
        '        arrDATA = New String() {I + 1,
        '                                .Rows(I).Item("ID").ToString,
        '                                ConvertDate(.Rows(I).Item("tmDate")),
        '                                .Rows(I).Item("tmTime")}
        '        List = New ListViewItem(arrDATA)
        '        lstTimeEdit.Items.Add(List)
        '    Next
        '    Ds.Clear()
        'End With
    End Sub


    Private Sub lstTimeEdit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTimeEdit.SelectedIndexChanged
        With lstTimeEdit
            If .SelectedItems.Count = 0 Then Exit Sub
            txtTime.Text = .SelectedItems(0).SubItems(3).Text.Trim
            If CDate(ConvertDate(txtDate.Text)) = CDate(ConvertDate(.SelectedItems(0).SubItems(2).Text.Trim)) Then
                chkNextDay.Checked = False
                chkPreviousDay.Checked = False
            ElseIf CDate(ConvertDate(txtDate.Text)) < CDate(ConvertDate(.SelectedItems(0).SubItems(2).Text.Trim)) Then
                chkNextDay.Checked = True
                chkPreviousDay.Checked = False
            ElseIf CDate(ConvertDate(txtDate.Text)) > CDate(ConvertDate(.SelectedItems(0).SubItems(2).Text.Trim)) Then
                chkNextDay.Checked = False
                chkPreviousDay.Checked = True
            End If
            lblId.Text = .SelectedItems(0).SubItems(1).Text.Trim
        End With
        Call EnaCmd(False, True, True)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call ClearTime()
        Call LoadTime()
        txtTime.Focus()
        Call EnaCmd(True, False, False)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If IsDate(cDateTime.dbDate(txtDate.EditValue)) = False Then
            'MsgBox("กรุณาป้อนวันที่ให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmEditTimeRS", Me.Text, "Check_Date", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
            txtDate.Focus()
            txtDate.SelectAll()
            Exit Sub
        End If

        If txtName.Text.Trim = "" Then
            'MsgBox("กรุณาป้อนรหัสพนักงานด้วย", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmEditTimeRS", Me.Text, "Insert_EmpID", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.Insert_EmpID, MsgBoxStyle.Information, Me.Text)
            txtCode.Focus()
            Exit Sub
        End If

        If IsDate("2007/01/01 " & txtTime.Text.Trim) = False Then
            'MsgBox("กรุณาป้อนเวลาให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmEditTimeRS", Me.Text, "Check_Day", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.Check_day, MsgBoxStyle.Information, Me.Text)
            txtTime.Focus()
            Exit Sub
        End If
        If chkNextDay.Checked = True And chkPreviousDay.Checked = True Then
            'MsgBox("กรุณาเลือกว่าจะเอา วันถัดไป หรือ จะเอาวันก่อนหน้า ให้เลือกอย่างใดอย่างหนึ่ง", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmEditTimeRS", Me.Text, "Select_Day", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message_spacial.Select_Day, MsgBoxStyle.Information, Me.Text)
            chkNextDay.Focus()
            Exit Sub
        End If

        Dim NewTime As String
        NewTime = GetCurDay(txtCode.Text.Trim, cDateTime.dbDate(txtDate.EditValue), txtTime.Text.Trim)
        'If chkNextDay.Checked = True Then
        '    NewTime = Format(DateAdd(DateInterval.Day, 1, CDate(NewTime)), "yyyy/MM/dd")
        'End If
        'If chkPreviousDay.Checked = True Then
        '    NewTime = Format(DateAdd(DateInterval.Day, -1, CDate(NewTime)), "yyyy/MM/dd")
        'End If
        NewTime = NewTime & " " & txtTime.Text.Trim

        Dim dCmd As New SqlCommand
        Dim strSQL As String

        Dim tn As SqlTransaction
        tn = Conn.BeginTransaction
        dCmd.Transaction = tn
        Try
            strSQL = "Insert Into TimeMaster(Code,DateIn,SystemGet) Values(" &
                    " '" & txtCode.Text.Trim & "'," &
                    " '" & NewTime.Trim & "'," &
                    " 'E')"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            Call cProcessTime.processTimeAll(dCmd, cDateTime.dbDate(txtDate.EditValue), txtCode.Text.Trim)

            tn.Commit()
        Catch ex As Exception
            tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
        'Call GenTimework()
        Call btnClear_Click(Me, System.EventArgs.Empty)
        Application.DoEvents()
    End Sub

    Function GetCurDay(ByVal Code As String, ByVal strDate As String, ByVal strTime As String) As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select curDate = isnull(dbo.fCurDay('" & Code.Trim & "','" & strDate & "','" & strTime.Trim & "'),'')"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return strDate
            Else
                Return .Rows(0).Item("curDate")
            End If
        End With
    End Function

    Private Sub ClearTime()
        lblId.Text = ""
        txtTime.Text = ""
        Application.DoEvents()
        chkNextDay.Checked = False
        chkPreviousDay.Checked = False
    End Sub

    Private Sub frmEditTime_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        fEditTime = Nothing
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
            oform.SelectNextControl(oform.ActiveControl, True, True, True, False)
            oform.ActiveControl.Focus()
        End If
    End Sub

    Private Sub ReadMenuManageTime_ReadOnly()  ' เมนูประมวลผลเวลาทำงาน
        fEditTime.btnAdd.Enabled = setPermission.ManageTime_ReadOnly
        fEditTime.btnAdd.Enabled = setPermission.ManageTime_ReadOnly


    End Sub



    Private Sub frmEditTime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call EnaCmd(True, False, False)

    End Sub

    Private Sub EnaCmd(ByVal Add As Boolean, ByVal Edit As Boolean, ByVal Delete As Boolean)
        If setPermission.ManageTime_ReadOnly = True Then  ' ปกติให้ดูได้
            btnAdd.Enabled = Add
            btnEdit.Enabled = Edit
            btnDelete.Enabled = Delete

        Else ' มีเงือนไข ให้ ReadOnly
            btnAdd.Enabled = False
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            btnClear.Enabled = False
        End If


    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click


        If IsDate(cDateTime.dbDate(txtDate.EditValue)) = False Then
            'MsgBox("กรุณาป้อนวันที่ให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmEditTimeRS", Me.Text, "Check_Date", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
            txtDate.Focus()
            txtDate.SelectAll()
            Exit Sub
        End If

        If txtName.Text.Trim = "" Then
            'MsgBox("กรุณาป้อนรหัสพนักงานด้วย", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmEditTimeRS", Me.Text, "Insert_EmpID", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.Insert_EmpID, MsgBoxStyle.Information, Me.Text)
            txtCode.Focus()
            Exit Sub
        End If

        If IsDate("2007/01/01 " & txtTime.Text.Trim) = False Then
            'MsgBox("กรุณาป้อนเวลาให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            txtTime.Focus()
            '    MsgManager.ShowDialog(Me, "frmEditTimeRS", Me.Text, "Check_Day", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.Check_day, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If
        If chkNextDay.Checked = True And chkPreviousDay.Checked = True Then
            'MsgBox("กรุณาเลือกว่าจะเอา วันถัดไป หรือ จะเอาวันก่อนหน้า ให้เลือกอย่างใดอย่างหนึ่ง", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmEditTimeRS", Me.Text, "Select_Day", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message_spacial.Select_Day, MsgBoxStyle.Information, Me.Text)
            chkNextDay.Focus()
            Exit Sub
        End If

        Dim NewTime As String
        'NewTime = ConvertDate(txtDate.Text)
        NewTime = GetCurDay(txtCode.Text.Trim, cDateTime.dbDate(txtDate.EditValue), txtTime.Text.Trim)
        'If chkNextDay.Checked = True Then
        '    NewTime = Format(DateAdd(DateInterval.Day, 1, CDate(NewTime)), "yyyy/MM/dd")
        'End If
        'If chkPreviousDay.Checked = True Then
        '    NewTime = Format(DateAdd(DateInterval.Day, -1, CDate(NewTime)), "yyyy/MM/dd")
        'End If
        NewTime = NewTime & " " & txtTime.Text.Trim

        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim tn As SqlTransaction
        tn = Conn.BeginTransaction
        dCmd.Transaction = tn
        Try
            strSQL = "Update TimeMaster Set " &
                            " DateIn = '" & NewTime.Trim & "'," &
                            " SystemGet = 'E'" &
                    " Where Id = '" & lblId.Text.Trim & "'"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            Call cProcessTime.processTimeAll(dCmd, cDateTime.dbDate(txtDate.EditValue), txtCode.Text.Trim)

            tn.Commit()
        Catch ex As Exception
            tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
        'Call GenTimework()
        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If IsDate(cDateTime.dbDate(txtDate.EditValue)) = False Then
            'MsgBox("กรุณาป้อนวันที่ให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmEditTimeRS", Me.Text, "Check_Date", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
            txtDate.Focus()
            txtDate.SelectAll()
            Exit Sub
        End If

        If txtName.Text.Trim = "" Then
            'MsgBox("กรุณาป้อนรหัสพนักงานด้วย", MsgBoxStyle.Information, Me.Text)
            '    MsgManager.ShowDialog(Me, "frmEditTimeRS", Me.Text, "Insert_EmpID", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.Insert_EmpID, MsgBoxStyle.Information, Me.Text)
            txtCode.Focus()
            Exit Sub
        End If

        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim tn As SqlTransaction
        tn = Conn.BeginTransaction
        dCmd.Transaction = tn

        Try
            If chkDelAll.Checked = False Then
                strSQL = "Delete TimeMaster " &
                                    " Where Id = '" & lblId.Text.Trim & "'"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()
            Else
                Dim I As Integer
                For Each ii As Long In gvTimeEdit.GetSelectedRows

                    Dim dr As DataRow = gvTimeEdit.GetDataRow(ii)

                    strSQL = "Delete TimeMaster " &
                                            " Where Id = '" & dr("Id").ToString & "'"
                    dCmd.Connection = Conn
                    dCmd.CommandText = strSQL
                    dCmd.ExecuteNonQuery()
                Next
            End If

            Call cProcessTime.processTimeAll(dCmd, cDateTime.dbDate(txtDate.EditValue), txtCode.Text.Trim)

            tn.Commit()
        Catch ex As Exception
            tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
        'Call GenTimework()
        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub GenTimework()
        Dim DateSt As Date
        Dim DateSp As Date

        DateSt = txtDate.EditValue
        DateSp = txtDate.EditValue

        Dim dCmd As New SqlCommand
        Dim Tn As SqlTransaction
        Dim strSQL As String = ""
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            Dim I As Date
            Dim code As String = txtCode.Text.Trim
            I = DateSt

            Dim err As String = ""
            err = cProcessTime.processTimeAll(Format(I, "yyyy/MM/dd"), code)

            If err.Trim <> "" Then
                MsgBox(err, MsgBoxStyle.Critical, Me.Text)
            End If

            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
    End Sub

    Private Sub LoadKa(ByVal KaCode As String)
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim strSQL As String
        strSQL = "Select KA_Code,KaName," &
                            " TimeST,TimeST_to,TimeSP," &
                            " RestST,RestSP,StartDay,EndDay," &
                            " RestST_ND = Isnull(RestST_ND,0)," &
                            " RestSP_ND = Isnull(RestSP_ND,0)," &
                            " TimeSP_ND = Isnull(TimeSP_ND,0)," &
                            " StartDay_PD = Isnull(StartDay_PD,0)," &
                            " EndDay_ND = Isnull(EndDay_ND,0)," &
                            " Monday = Isnull(Monday,0)," &
                            " Tuesday = Isnull(Tuesday,0)," &
                            " Wednesday = Isnull(Wednesday,0)," &
                            " Thursday = Isnull(Thursday,0)," &
                            " Friday = Isnull(Friday,0)," &
                            " Saturday = Isnull(Saturday,0)," &
                            " Sunday = Isnull(Sunday,0)," &
                            " ka_flexible = isnull(ka_flexible,0)," &
                            " ka_flexible_hour = isnull(ka_flexible_hour,0)" &
                " from TimeKa " &
                " Where KA_Code = '" & KaCode.Trim & "'"
        DA = New SqlDataAdapter(strSQL, Conn)
        DA.Fill(DS, "TimeKa")
        With DS.Tables("TimeKa")
            If .Rows.Count = 0 Then
                Call ClearKaData()
                Exit Sub
            End If
            lblKaCode.Text = KaCode.Trim
            txtTimeST.Text = Format(.Rows(0).Item("TimeST"), "HH:mm")
            txtTimeST_to.Text = Format(.Rows(0).Item("TimeST_to"), "HH:mm")
            txtTimeSP.Text = Format(.Rows(0).Item("TimeSP"), "HH:mm")
            txtMidDayStart.Text = Format(.Rows(0).Item("RestST"), "HH:mm")
            txtMidDayStop.Text = Format(.Rows(0).Item("RestSP"), "HH:mm")
            txtStartDay.Text = Format(.Rows(0).Item("StartDay"), "HH:mm")
            txtEndDay.Text = Format(.Rows(0).Item("EndDay"), "HH:mm")

            chkka_flexible.Checked = .Rows(0).Item("ka_flexible")
            txtFlexible_Hour.Text = .Rows(0).Item("ka_flexible_hour")

            If .Rows(0).Item("TimeSP_ND") = True Then
                chkTimeSP_NextDay.Checked = True
            Else
                chkTimeSP_NextDay.Checked = False
            End If

            If .Rows(0).Item("RestST_ND") = True Then
                chkMidDayStart_NextDay.Checked = True
            Else
                chkMidDayStart_NextDay.Checked = False
            End If

            If .Rows(0).Item("RestSP_ND") = True Then
                chkMidDayStop_NextDay.Checked = True
            Else
                chkMidDayStop_NextDay.Checked = False
            End If

            If .Rows(0).Item("StartDay_PD") = True Then
                chkStartDay_PD.Checked = True
            Else
                chkStartDay_PD.Checked = False
            End If

            If .Rows(0).Item("EndDay_ND") = True Then
                chkTimeEndDay_NextDay.Checked = True
            Else
                chkTimeEndDay_NextDay.Checked = False
            End If

            'Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
            If .Rows(0).Item("Monday") = True Then
                chkMonDay.Checked = True
            Else
                chkMonDay.Checked = False
            End If

            If .Rows(0).Item("Tuesday") = True Then
                chkTuesday.Checked = True
            Else
                chkTuesday.Checked = False
            End If

            If .Rows(0).Item("Wednesday") = True Then
                chkWednesday.Checked = True
            Else
                chkWednesday.Checked = False
            End If

            If .Rows(0).Item("Thursday") = True Then
                chkThursday.Checked = True
            Else
                chkThursday.Checked = False
            End If

            If .Rows(0).Item("Friday") = True Then
                chkFriday.Checked = True
            Else
                chkFriday.Checked = False
            End If

            If .Rows(0).Item("Saturday") = True Then
                chkSaturday.Checked = True
            Else
                chkSaturday.Checked = False
            End If

            If .Rows(0).Item("Sunday") = True Then
                chkSunday.Checked = True
            Else
                chkSunday.Checked = False
            End If
        End With
    End Sub

    Private Sub ClearKaData()
        lblKaCode.Text = ""
        txtTimeST.Text = ""
        txtTimeSP.Text = ""
        txtStartDay.Text = ""
        txtEndDay.Text = ""

        txtMidDayStart.Text = ""
        txtMidDayStop.Text = ""

        chkka_flexible.Checked = False
        txtFlexible_Hour.Text = ""

        chkMidDayStart_NextDay.Checked = False
        chkMidDayStop_NextDay.Checked = False
        chkTimeSP_NextDay.Checked = False
        chkStartDay_PD.Checked = False
        chkTimeEndDay_NextDay.Checked = False


        ' Clear DATE Of Week
        chkMonDay.Checked = False
        chkTuesday.Checked = False
        chkWednesday.Checked = False
        chkThursday.Checked = False
        chkFriday.Checked = False
        chkSaturday.Checked = False
        chkSunday.Checked = False
    End Sub



    Function GetKaScope(ByVal KaCode As String, ByVal DateIn As String, TimeST_SP As String, Previous_Next_Day As Integer, ByVal Time_IO As TimeIO) As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet

        Dim strSQL As String = ""
        Dim Type As String
        Select Case Time_IO
            Case TimeIO.Time_IN
                Type = "I"
                strSQL = "Select SC_Day = dbo.fGetScopeDay_Start('" & DateIn.Trim & "','" & KaCode.Trim & "','" & TimeST_SP.Trim & "'," & Previous_Next_Day & ")"
            Case Else
                Type = "O"
                strSQL = "Select SC_Day = dbo.fGetScopeDay_Stop('" & DateIn.Trim & "','" & KaCode.Trim & "','" & TimeST_SP.Trim & "'," & Previous_Next_Day & ")"
        End Select

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("SC_Day")
            End If
        End With
    End Function


    Private Sub txtTime_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTime.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim a As Integer = 0
        End If
    End Sub

    Private Sub txtCode_EditValueChanged(sender As Object, e As EventArgs) Handles txtCode.EditValueChanged

    End Sub

    Private Sub gvTimeEdit_DoubleClick(sender As Object, e As EventArgs) Handles gvTimeEdit.DoubleClick
        Try
            Dim gv As GridView = CType(sender, GridView)

            If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "Code")) = True Then Exit Sub


            txtTime.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "tmTime")
            If txtDate.EditValue = gv.GetRowCellValue(gv.FocusedRowHandle, "DateIn") Then
                chkNextDay.Checked = False
                chkPreviousDay.Checked = False
            ElseIf txtDate.EditValue < gv.GetRowCellValue(gv.FocusedRowHandle, "DateIn") Then
                chkNextDay.Checked = True
                chkPreviousDay.Checked = False
            ElseIf txtDate.EditValue > gv.GetRowCellValue(gv.FocusedRowHandle, "DateIn") Then
                chkNextDay.Checked = False
                chkPreviousDay.Checked = True
            End If
            lblId.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Id").ToString

            Call EnaCmd(False, True, True)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub gvTimeEdit_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles gvTimeEdit.RowCellStyle
        Try
            Dim gv As GridView = CType(sender, GridView)


            If gv.GetRowCellValue(e.RowHandle, "SystemGet") = "E" Then
                e.Appearance.ForeColor = Color.Blue
            End If

            'Select Case e.Column.FieldName.ToLower
            '    Case "systemget"

            'End Select
        Catch ex As Exception

        End Try
    End Sub
End Class