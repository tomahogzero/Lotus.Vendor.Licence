Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Microsoft.Office.Interop
Imports TimeAttendance.utils


Public Class frmTimework

    Dim dsTime As DataSet
    Dim editRow As Integer = 0

    Private Sub frmTimework_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        fTimework = Nothing
    End Sub

    Private Sub frmTimework_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                Call btnRefresh_Click(Me, System.EventArgs.Empty)
            Case Keys.F2
                Call btnChkErrTimeOdd_Click(Me, System.EventArgs.Empty)
            Case Keys.F3
                Call btnChkTimeNear_Click(Me, System.EventArgs.Empty)
        End Select
    End Sub

    Private Sub frmTimework_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
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

    Private Sub ReadMenuPermissionTimeAtt_ReadOnly()  ' àÁ¹Ù»ÃÐÁÇÅ¼ÅàÇÅÒ·Ó§Ò¹
        fTimework.btnProcess.Enabled = setPermission.PermissionTimeAtt_ReadOnly
    End Sub

    Private Sub EnableForm(Ena As Boolean)
        grpMonth.Enabled = Ena
        grpCheckErr.Enabled = Ena
        grpSearchBy.Enabled = Ena
        pnlExport.Enabled = Ena
        btnExit.Enabled = Ena
    End Sub


    Private Sub frmTimework_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




        Call ReadMenuPermissionTimeAtt_ReadOnly()

        Call SearchData.LoadMonth(cboMonth, False, True)

        'Call LoadMonth()
        txtYear.Text = Date.Now.Year
        cboMonth.SelectedIndex = Date.Now.Month - 1
        txtDatest.EditValue = Now.Date
        txtdatesp.EditValue = Now.Date

        Call SearchData.LoadDivision(Me, cboDivision, True)
        Call SearchData.LoadDepartment(Me, cboDepartment, "", True)


        'เช็คสิทธิ์ การ export excel
        If GetData.GetPermision_export_excel(modStartup.UserId, Me.Tag) = True Or U_Username = "sa" Then
            cboExport.Enabled = True
            btnExport.Enabled = True
        Else
            cboExport.Enabled = False
            btnExport.Enabled = False
        End If

        cboExport.SelectedIndex = 1
        'ToolTip1.Tag = "µÑÇÍÑ¡ÉÃÊÕ´Ó¤×Í ¢éÍÁÙÅ·ÕèÁÒ¨Ò¡à¤Ã×èÍ§ " & Chr(10) & "µÑÇÍÑ¡ÉÃÊÕ¹éÓà§Ô¹ ¤×Í ¢éÍÁÙÅ¤ÕÂìà¢éÒËÃ×Íá¡éä¢" & Chr(10) & " µÑÇÍÑ¡ÉÃÊÕá´§¤×Í ÃÙ´à¡Ô¹ 12 ¤ÃÑé§"
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtDateSt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        txtDatest.SelectAll()
    End Sub

    Private Sub txtDateSp_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        txtdatesp.SelectAll()
    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        '   If MsgBox("คุณต้องการประมวลผลเวลาทำงานจริงหรือไม่?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "ประมวลผล") = vbNo Then Exit Sub
        If MsgBox(My.Resources.res_warning_message_spacial.Ask_Procress, MsgBoxStyle.Information Or MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, Me.Text) = vbNo Then Exit Sub

        If IsDate(txtDatest.EditValue) = False Then
            MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
            txtDatest.Focus()
            txtDatest.SelectAll()
            Exit Sub
        End If
        If IsDate(txtdatesp.EditValue) = False Then
            MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
            txtdatesp.Focus()
            txtdatesp.SelectAll()
            Exit Sub
        End If
        Dim DateSt As Date
        Dim DateSp As Date
        Dim Code As String = ""

        DateSt = txtDatest.EditValue
        DateSp = txtdatesp.EditValue


        Dim dCmd As New SqlCommand
        'Dim Tn As SqlTransaction
        Dim strSQL As String = ""
        'Tn = Conn.BeginTransaction
        'dCmd.Transaction = Tn
        ProgressBar1.Maximum = DateDiff(DateInterval.Day, DateSt, DateSp) + 1
        ProgressBar1.Value = 0


        btnProcess.Enabled = False

        Try
            Dim Da As New SqlDataAdapter
            Dim Ds As New DataSet

            Call EnableForm(False)

            lblProcessDate.Text = ""
            lbLog.Items.Clear()
            grpLog.Visible = True
            grpLog.BringToFront()

            Application.DoEvents()

            ProgressBar1.Value = 0
            ProgressBar1.Maximum = DateDiff(DateInterval.Day, DateSt, DateSp)
            Dim I As Date
            I = DateSt
            Do Until I > DateSp
                lblProcessDate.Text = Format(I, "dd/MM/yyyy")
                ProgressBar1.Text = Format(I, "dd/MM/yyyy")
                Application.DoEvents()

                Dim err As String = ""
                err = cProcessTime.processTimeAll_withLog(Format(I, "yyyy/MM/dd"), "", lbLog)

                If err.Trim <> "" Then
                    MsgBox(err, MsgBoxStyle.Critical, Me.Text)
                End If

                I = DateAdd(DateInterval.Day, 1, I)
                ProgressBar1.Value += 1
                Application.DoEvents()
            Loop
            'Tn.Commit()
            btnProcess.Enabled = True
        Catch ex As Exception
            btnProcess.Enabled = True
            'Tn.Rollback()
            Call EnableForm(True)
            '  MsgBox("Code : " & Code & " " & ex.Message, MsgBoxStyle.Critical, Me.Text)
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try
        Call EnableForm(True)
        grpLog.Visible = False

        MsgBox(My.Resources.res_warning_message_spacial.Procress_complete, MsgBoxStyle.Information, Me.Text)

        btnRefresh_Click(Me, EventArgs.Empty)
        'Call LoadTimeworkSearch()

        ProgressBar1.Value = 0
        ProgressBar1.Text = ""
    End Sub


    Function getQueryTimeWorkMaster()
        Dim strsql As String
        strsql = "Select top 50000 row_number() over("
        strsql &= LoadTimeworkSearch_Order_by()
        strsql &= " ) As row," &
             " Timework.DateIn,Timework.Code,"

        If cValGolbal.Lang = "TH" Then
            strsql &= " EmpName =Emp.Title + emp.Fname + '   ' + emp.Lname,"
        Else
            strsql &= " EmpName =Emp.Title + ' ' + emp.Fname + '   ' + emp.Lname,"
        End If

        strsql &= " Emp.DeptId," &
             " isnull(Department.Department,'') as Department," &
             " isnull(div.Division,'') as Division," &
             " isnull(emp.Position,'') as Position," &
             " Time1," &
             " Time2," &
             " Time3," &
             " Time4," &
             " Time5," &
             " Time6," &
             " Time7," &
             " Time8," &
             " Time9," &
             " Time10," &
             " Time11," &
             " Time12," &
             " TimeE1 = Isnull(TimeE1,0)," &
             " TimeE2 = Isnull(TimeE2,0)," &
             " TimeE3 = Isnull(TimeE3,0)," &
             " TimeE4 = Isnull(TimeE4,0)," &
             " TimeE5 = Isnull(TimeE5,0)," &
             " TimeE6 = Isnull(TimeE6,0)," &
             " TimeE7 = Isnull(TimeE7,0)," &
             " TimeE8 = Isnull(TimeE8,0)," &
             " TimeE9 = Isnull(TimeE9,0)," &
             " TimeE10 = Isnull(TimeE10,0)," &
             " TimeE11 = Isnull(TimeE11,0)," &
             " TimeE12 = Isnull(TimeE12,0)," &
             " TimeOver = Isnull(TimeOver,0)," &
             " kacode = isnull(Timework.KaCode,'')" &
        " From TimeWork Inner Join Emp " &
                    " On TimeWork.Code = Emp.Code " &
                " Left join Department Department " &
                    " On emp.DeptId = Department.DeptId " &
                " Left join Division div " &
                    " On Department.divid = div.divid "
        Return strsql
    End Function

    '    " Time1 = Isnull(Convert(nVarchar(16),Time1,120),'')," &
    '" Time2 = Isnull(Convert(nVarchar(16),Time2,120),'')," &
    '" Time3 = Isnull(Convert(nVarchar(16),Time3,120),'')," &
    '" Time4 = Isnull(Convert(nVarchar(16),Time4,120),'')," &
    '" Time5 = Isnull(Convert(nVarchar(16),Time5,120),'')," &
    '" Time6 = Isnull(Convert(nVarchar(16),Time6,120),'')," &
    '" Time7 = Isnull(Convert(nVarchar(16),Time7,120),'')," &
    '" Time8 = Isnull(Convert(nVarchar(16),Time8,120),'')," &
    '" Time9 = Isnull(Convert(nVarchar(16),Time9,120),'')," &
    '" Time10 = Isnull(Convert(nVarchar(16),Time10,120),'')," &
    '" Time11 = Isnull(Convert(nVarchar(16),Time11,120),'')," &
    '" Time12 = Isnull(Convert(nVarchar(16),Time12,120),'')," &

    '" T1 = dbo.fConvertTimeToString(convert(nvarchar(10),timework.DateIn,111),Convert(nVarchar(16),Time1,120))," &
    '" T2 = dbo.fConvertTimeToString(convert(nvarchar(10),timework.DateIn,111),Convert(nVarchar(16),Time2,120))," &
    '" T3 = dbo.fConvertTimeToString(convert(nvarchar(10),timework.DateIn,111),Convert(nVarchar(16),Time3,120))," &
    '" T4 = dbo.fConvertTimeToString(convert(nvarchar(10),timework.DateIn,111),Convert(nVarchar(16),Time4,120))," &
    '" T5 = dbo.fConvertTimeToString(convert(nvarchar(10),timework.DateIn,111),Convert(nVarchar(16),Time5,120))," &
    '" T6 = dbo.fConvertTimeToString(convert(nvarchar(10),timework.DateIn,111),Convert(nVarchar(16),Time6,120))," &
    '" T7 = dbo.fConvertTimeToString(convert(nvarchar(10),timework.DateIn,111),Convert(nVarchar(16),Time7,120))," &
    '" T8 = dbo.fConvertTimeToString(convert(nvarchar(10),timework.DateIn,111),Convert(nVarchar(16),Time8,120))," &
    '" T9 = dbo.fConvertTimeToString(convert(nvarchar(10),timework.DateIn,111),Convert(nVarchar(16),Time9,120))," &
    '" T10 = dbo.fConvertTimeToString(convert(nvarchar(10),timework.DateIn,111),Convert(nVarchar(16),Time10,120))," &
    '" T11 = dbo.fConvertTimeToString(convert(nvarchar(10),timework.DateIn,111),Convert(nVarchar(16),Time11,120))," &
    '" T12 = dbo.fConvertTimeToString(convert(nvarchar(10),timework.DateIn,111),Convert(nVarchar(16),Time12,120))," &

    Private Sub LoadTimework()

        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = getQueryTimeWorkMaster() &
                " Where Convert(nVarchar(10),Timework.DateIn,111) " &
                    " Between '" & cDateTime.dbDate(txtDatest.EditValue) & "' and " &
                            " '" & cDateTime.dbDate(txtdatesp.EditValue) & "' "


        If rdDate.Checked = True Then
            strSQL &= " Order By Timework.DateIn,Timework.Code"
        End If
        If rdCode.Checked = True Then
            strSQL &= " Order By Timework.Code,Timework.DateIn"
        End If
        If rdName.Checked = True Then
            strSQL &= " Order By Emp.Fname,Emp.Lname,Timework.DateIn"
        End If
        If rdDept.Checked = True Then
            strSQL &= " Order By Emp.DeptId,Timework.DateIn,Timework.Code"
        End If
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")

        gcTimeWork.DataSource = Ds
        gcTimeWork.DataMember = "Data"


        'Dim List As ListViewItem
        'Dim arrDATA() As String

        'With Ds.Tables("Data")
        '    lstTimework.Items.Clear()
        '    Dim I As Integer
        '    ProgressBar1.Maximum = .Rows.Count
        '    ProgressBar1.Value = 0
        '    For I = 0 To .Rows.Count - 1
        '        Dim dr As DataRow = .Rows(I)
        '        Dim Time1 As String = GetNewTime(Format(.Rows(I).Item("DateIn"), "yyyy/MM/dd"), dr("Time1"))
        '        Dim Time2 As String = GetNewTime(Format(.Rows(I).Item("DateIn"), "yyyy/MM/dd"), dr("Time2"))
        '        Dim Time3 As String = GetNewTime(Format(.Rows(I).Item("DateIn"), "yyyy/MM/dd"), dr("Time3"))
        '        Dim Time4 As String = GetNewTime(Format(.Rows(I).Item("DateIn"), "yyyy/MM/dd"), dr("Time4"))
        '        Dim Time5 As String = GetNewTime(Format(.Rows(I).Item("DateIn"), "yyyy/MM/dd"), dr("Time5"))
        '        Dim Time6 As String = GetNewTime(Format(.Rows(I).Item("DateIn"), "yyyy/MM/dd"), dr("Time6"))
        '        Dim Time7 As String = GetNewTime(Format(.Rows(I).Item("DateIn"), "yyyy/MM/dd"), dr("Time7"))
        '        Dim Time8 As String = GetNewTime(Format(.Rows(I).Item("DateIn"), "yyyy/MM/dd"), dr("Time8"))
        '        Dim Time9 As String = GetNewTime(Format(.Rows(I).Item("DateIn"), "yyyy/MM/dd"), dr("Time9"))
        '        Dim Time10 As String = GetNewTime(Format(.Rows(I).Item("DateIn"), "yyyy/MM/dd"), dr("Time10"))
        '        Dim Time11 As String = GetNewTime(Format(.Rows(I).Item("DateIn"), "yyyy/MM/dd"), dr("Time11"))
        '        Dim Time12 As String = GetNewTime(Format(.Rows(I).Item("DateIn"), "yyyy/MM/dd"), dr("Time12"))

        '        arrDATA = New String() {I + 1,
        '                                Format(.Rows(I).Item("DateIn"), "dd/MM/yyyy"),
        '                                .Rows(I).Item("Code"),
        '                                .Rows(I).Item("EmpName"),
        '                                .Rows(I).Item("DeptId"),
        '                                Time1,
        '                                Time2,
        '                                Time3,
        '                                Time4,
        '                                Time5,
        '                                Time6,
        '                                Time7,
        '                                Time8,
        '                                Time9,
        '                                Time10,
        '                                Time11,
        '                                Time12}
        '        List = New ListViewItem(arrDATA)
        '        lstTimework.Items.Add(List)

        '        lstTimework.Items(I).UseItemStyleForSubItems = False


        '        If .Rows(I).Item("TimeOver") = True Then
        '            lstTimework.Items(I).ForeColor = Color.Red
        '        Else
        '            If .Rows(I).Item("TimeE1") = True Then
        '                lstTimework.Items(I).SubItems(5).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE2") = True Then
        '                lstTimework.Items(I).SubItems(6).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE3") = True Then
        '                lstTimework.Items(I).SubItems(7).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE4") = True Then
        '                lstTimework.Items(I).SubItems(8).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE5") = True Then
        '                lstTimework.Items(I).SubItems(9).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE6") = True Then
        '                lstTimework.Items(I).SubItems(10).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE7") = True Then
        '                lstTimework.Items(I).SubItems(11).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE8") = True Then
        '                lstTimework.Items(I).SubItems(12).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE9") = True Then
        '                lstTimework.Items(I).SubItems(13).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE10") = True Then
        '                lstTimework.Items(I).SubItems(14).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE11") = True Then
        '                lstTimework.Items(I).SubItems(15).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE12") = True Then
        '                lstTimework.Items(I).SubItems(16).ForeColor = Color.Blue
        '            End If
        '        End If
        '        ProgressBar1.Value = I + 1
        '    Next
        '    'Ds.Clear()
        'End With
    End Sub

    Function GetNewTime(ByVal DateIn As String, ByVal Time As String) As String
        If Time.Trim = "" Then
            Return ""
        End If

        Time = Replace(Time, "-", "/")

        Dim dTime As String = LeftText(Time, 10)

        If DateIn > dTime Then
            Return "<" & RightText(Time, 5)
        ElseIf DateIn < dTime Then
            Return RightText(Time, 5) & ">"
        ElseIf DateIn = dTime Then
            Return RightText(Time, 5)
        Else
            Return ""
        End If
    End Function


    Private Sub LoadTimeworkSearch()

        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim divid As String = GetData.GetDivisionId(cboDivision.Text.Trim)
        Dim deptid As String = GetData.GetDepartmentId(cboDepartment.Text.Trim)
        Dim code As String = txtCode1.Text.Trim
        Dim namesearch As String = txtNameSearch.Text.Trim

        strSQL = getQueryTimeWorkMaster() &
                " Where Convert(nVarchar(10),Timework.DateIn,111) " &
                    " Between '" & cDateTime.dbDate(txtDatest.EditValue) & "' and " &
                            " '" & cDateTime.dbDate(txtdatesp.EditValue) & "' "


        If code <> "" Then
            strSQL &= " and Timework.Code = '" & code & "' "
        End If
        If code = "" Then
            If namesearch <> "" Then
                strSQL &= " and Emp.Fname + Emp.Lname Like '%" & namesearch & "%'"
            End If

            If deptid <> "" Then
                strSQL &= " and Emp.DeptId = '" & deptid & "'"
            End If

            If divid <> "" Then
                strSQL &= " and Department.DivId = '" & divid & "'"
            End If

        End If



        strSQL &= LoadTimeworkSearch_Order_by()

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")


        dsTime = Ds

        gcTimeWork.DataSource = dsTime
        gcTimeWork.DataMember = "Data"


    End Sub

    Public Sub LoadTimeworkSearchByCode(Code As String, datein As String)

        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim divid As String = GetData.GetDivisionId(cboDivision.Text.Trim)
        Dim deptid As String = GetData.GetDepartmentId(cboDepartment.Text.Trim)
        Dim namesearch As String = txtNameSearch.Text.Trim

        strSQL = getQueryTimeWorkMaster() &
                " Where Convert(nVarchar(10),Timework.DateIn,111) " &
                    " = '" & datein & "'"
        strSQL &= " and Timework.Code = '" & Code & "' "

        strSQL &= LoadTimeworkSearch_Order_by()

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")


        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Dim dr() As DataRow = dsTime.Tables(0).Select("row=" & editRow & "")
                If dr.Length > 0 Then
                    dsTime.Tables(0).Rows.Remove(dr(0))
                End If
            Else
                Dim dr() As DataRow = dsTime.Tables(0).Select("row=" & editRow & "")
                If dr.Length > 0 Then
                    dr(0).Item("Time1") = .Rows(0).Item("Time1")
                    dr(0).Item("Time2") = .Rows(0).Item("Time2")
                    dr(0).Item("Time3") = .Rows(0).Item("Time3")
                    dr(0).Item("Time4") = .Rows(0).Item("Time4")
                End If
            End If

        End With
    End Sub

    Function LoadTimeworkSearch_Order_by() As String
        Dim query As String = ""
        If rdDate.Checked = True Then
            query &= " Order By Timework.DateIn,Timework.Code"
        End If
        If rdCode.Checked = True Then
            query &= " Order By Timework.Code,Timework.DateIn"
        End If
        If rdName.Checked = True Then
            query &= " Order By Emp.Fname,Emp.Lname,Timework.DateIn"
        End If
        If rdDept.Checked = True Then
            query &= " Order By Emp.DeptId,Timework.DateIn,Timework.Code"
        End If
        Return query
    End Function

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        '     Call LoadTimework()
        btnRefresh.Enabled = False
        Call LoadTimeworkSearch()
        btnRefresh.Enabled = True
    End Sub

    Private Sub LoadMonth()
        Dim I As Integer
        cboMonth.Properties.Items.Clear()
        For I = 1 To 12
            'cboMonth.Items.Add(MonthNameThai(I))
            cboMonth.Properties.Items.Add(MonthName(Me, I))
        Next
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMonth.SelectedIndexChanged
        If IsNumeric(txtYear.Text.Trim) = False Then Exit Sub
        'Dim DateSt As String
        Dim newMonth As String
        Dim newYear As String
        'If cboMonth.SelectedIndex = 0 Then
        '    newMonth = 12
        '    newYear = CInt(txtYear.Text) - 1
        'Else
        newMonth = Format(cboMonth.SelectedIndex + 1, "00")
        newYear = txtYear.Text.Trim
        'End If
        Dim ar As New ArrayList
        ar = GetDayMonth(newMonth, newYear)
        txtDatest.Text = ar.Item(0)
        txtdatesp.Text = ar.Item(1)

        'DateSt = "01/" & Format(cboMonth.SelectedIndex + 1, "00") & "/" & txtYear.Text.Trim
        'txtDateSt.Text = DateSt
        'txtDateSp.Text = Format(MonthEnd(ConvertDate(DateSt)).Day, "00") & Format(cboMonth.SelectedIndex + 1, "00") & "/" & txtYear.Text.Trim
    End Sub


    Private Sub btnChkErrTimeOdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChkErrTimeOdd.Click
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = getQueryTimeWorkMaster() &
                " Where Convert(nVarchar(10),Timework.DateIn,111) " &
                    " Between '" & cDateTime.dbDate(txtDatest.EditValue) & "' and " &
                            " '" & cDateTime.dbDate(txtdatesp.EditValue) & "' and " &
                            " ((Time1 Is Not Null and Time2 Is Null) Or " &
                            " (Time3 Is Not Null and Time4 Is Null) Or " &
                            " (Time5 Is Not Null and Time6 Is Null) Or " &
                            " (Time7 Is Not Null and Time8 Is Null) Or " &
                            " (Time9 Is Not Null and Time10 Is Null) Or" &
                            " (Time11 Is Not Null and Time12 Is Null))"


        If lblDeptId.Text.Trim <> "" Then
            strSQL &= " and Emp.DeptId = '" & lblDeptId.Text.Trim & "'"
        End If

        If rdDate.Checked = True Then
            strSQL &= " Order By Timework.DateIn,Timework.Code"
        End If
        If rdCode.Checked = True Then
            strSQL &= " Order By Timework.Code,Timework.DateIn"
        End If
        If rdName.Checked = True Then
            strSQL &= " Order By Emp.Fname,Emp.Lname,Timework.DateIn"
        End If
        If rdDept.Checked = True Then
            strSQL &= " Order By Emp.DeptId,Timework.DateIn,Timework.Code"
        End If
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")

        gcTimeWork.DataSource = Ds
        gcTimeWork.DataMember = "Data"

        'Dim List As ListViewItem
        'Dim arrDATA() As String

        'With Ds.Tables("Data")
        '    lstTimework.Items.Clear()
        '    Dim I As Integer
        '    ProgressBar1.Maximum = .Rows.Count
        '    ProgressBar1.Value = 0
        '    For I = 0 To .Rows.Count - 1
        '        arrDATA = New String() {I + 1,
        '                                Format(.Rows(I).Item("DateIn"), "dd/MM/yyyy"),
        '                                .Rows(I).Item("Code"),
        '                                .Rows(I).Item("EmpName"),
        '                                .Rows(I).Item("DeptId"),
        '                                .Rows(I).Item("Time1"),
        '                                .Rows(I).Item("Time2"),
        '                                .Rows(I).Item("Time3"),
        '                                .Rows(I).Item("Time4"),
        '                                .Rows(I).Item("Time5"),
        '                                .Rows(I).Item("Time6"),
        '                                .Rows(I).Item("Time7"),
        '                                .Rows(I).Item("Time8"),
        '                                .Rows(I).Item("Time9"),
        '                                .Rows(I).Item("Time10"),
        '                                .Rows(I).Item("Time11"),
        '                                .Rows(I).Item("Time12")}
        '        List = New ListViewItem(arrDATA)
        '        lstTimework.Items.Add(List)

        '        lstTimework.Items(I).UseItemStyleForSubItems = False

        '        If .Rows(I).Item("TimeOver") = True Then
        '            lstTimework.Items(I).ForeColor = Color.Red
        '        Else
        '            If .Rows(I).Item("TimeE1") = True Then
        '                lstTimework.Items(I).SubItems(5).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE2") = True Then
        '                lstTimework.Items(I).SubItems(6).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE3") = True Then
        '                lstTimework.Items(I).SubItems(7).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE4") = True Then
        '                lstTimework.Items(I).SubItems(8).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE5") = True Then
        '                lstTimework.Items(I).SubItems(9).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE6") = True Then
        '                lstTimework.Items(I).SubItems(10).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE7") = True Then
        '                lstTimework.Items(I).SubItems(11).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE8") = True Then
        '                lstTimework.Items(I).SubItems(12).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE9") = True Then
        '                lstTimework.Items(I).SubItems(13).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE10") = True Then
        '                lstTimework.Items(I).SubItems(14).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE11") = True Then
        '                lstTimework.Items(I).SubItems(15).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE12") = True Then
        '                lstTimework.Items(I).SubItems(16).ForeColor = Color.Blue
        '            End If
        '        End If
        '        ProgressBar1.Value = I + 1
        '    Next
        '    Ds.Clear()
        'End With
        'lstTimework.Focus()
    End Sub


    Private Sub btnChkTimeNear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChkTimeNear.Click
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim intTimeNear As Integer
        If IsNumeric(txtTimeNear.Text.Trim) = False Then
            txtTimeNear.Text = 15
        End If
        intTimeNear = txtTimeNear.Text

        strSQL = getQueryTimeWorkMaster() &
                " Where Convert(nVarchar(10),Timework.DateIn,111) " &
                    " Between '" & cDateTime.dbDate(txtDatest.EditValue) & "' and " &
                            " '" & cDateTime.dbDate(txtdatesp.EditValue) & "' and " &
                            " ((DateDiff(n,Time1,Time2) <= " & intTimeNear & ") Or" &
                          " (DateDiff(n,Time2,Time3) <= " & intTimeNear & ") Or " &
                          " (DateDiff(n,Time3,Time4) <= " & intTimeNear & ") Or " &
                          " (DateDiff(n,Time4,Time5) <= " & intTimeNear & ") Or " &
                          " (DateDiff(n,Time5,Time6) <= " & intTimeNear & ") Or " &
                            " (DateDiff(n,Time6,Time7) <= " & intTimeNear & ") Or " &
                            " (DateDiff(n,Time7,Time8) <= " & intTimeNear & ") Or " &
                            " (DateDiff(n,Time8,Time9) <= " & intTimeNear & ") Or " &
                            " (DateDiff(n,Time9,Time10) <= " & intTimeNear & ") Or " &
                            " (DateDiff(n,Time10,Time11) <= " & intTimeNear & ") Or " &
                            " (DateDiff(n,Time11,Time12) <= " & intTimeNear & "))"


        If lblDeptId.Text.Trim <> "" Then
            strSQL &= " and Emp.DeptId = '" & lblDeptId.Text.Trim & "'"
        End If

        If rdDate.Checked = True Then
            strSQL &= " Order By Timework.DateIn,Timework.Code"
        End If
        If rdCode.Checked = True Then
            strSQL &= " Order By Timework.Code,Timework.DateIn"
        End If
        If rdName.Checked = True Then
            strSQL &= " Order By Emp.Fname,Emp.Lname,Timework.DateIn"
        End If
        If rdDept.Checked = True Then
            strSQL &= " Order By Emp.DeptId,Timework.DateIn,Timework.Code"
        End If
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")

        gcTimeWork.DataSource = Ds
        gcTimeWork.DataMember = "Data"

        'Dim List As ListViewItem
        'Dim arrDATA() As String

        'With Ds.Tables("Data")
        '    lstTimework.Items.Clear()
        '    Dim I As Integer
        '    ProgressBar1.Maximum = .Rows.Count
        '    ProgressBar1.Value = 0
        '    For I = 0 To .Rows.Count - 1
        '        arrDATA = New String() {I + 1,
        '                                Format(.Rows(I).Item("DateIn"), "dd/MM/yyyy"),
        '                                .Rows(I).Item("Code"),
        '                                .Rows(I).Item("EmpName"),
        '                                .Rows(I).Item("DeptId"),
        '                                .Rows(I).Item("Time1"),
        '                                .Rows(I).Item("Time2"),
        '                                .Rows(I).Item("Time3"),
        '                                .Rows(I).Item("Time4"),
        '                                .Rows(I).Item("Time5"),
        '                                .Rows(I).Item("Time6"),
        '                                .Rows(I).Item("Time7"),
        '                                .Rows(I).Item("Time8"),
        '                                .Rows(I).Item("Time9"),
        '                                .Rows(I).Item("Time10"),
        '                                .Rows(I).Item("Time11"),
        '                                .Rows(I).Item("Time12")}
        '        List = New ListViewItem(arrDATA)
        '        lstTimework.Items.Add(List)

        '        lstTimework.Items(I).UseItemStyleForSubItems = False

        '        If .Rows(I).Item("TimeOver") = True Then
        '            lstTimework.Items(I).ForeColor = Color.Red
        '        Else
        '            If .Rows(I).Item("TimeE1") = True Then
        '                lstTimework.Items(I).SubItems(5).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE2") = True Then
        '                lstTimework.Items(I).SubItems(6).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE3") = True Then
        '                lstTimework.Items(I).SubItems(7).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE4") = True Then
        '                lstTimework.Items(I).SubItems(8).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE5") = True Then
        '                lstTimework.Items(I).SubItems(9).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE6") = True Then
        '                lstTimework.Items(I).SubItems(10).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE7") = True Then
        '                lstTimework.Items(I).SubItems(11).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE8") = True Then
        '                lstTimework.Items(I).SubItems(12).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE9") = True Then
        '                lstTimework.Items(I).SubItems(13).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE10") = True Then
        '                lstTimework.Items(I).SubItems(14).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE11") = True Then
        '                lstTimework.Items(I).SubItems(15).ForeColor = Color.Blue
        '            End If
        '            If .Rows(I).Item("TimeE12") = True Then
        '                lstTimework.Items(I).SubItems(16).ForeColor = Color.Blue
        '            End If
        '        End If
        '        ProgressBar1.Value = I + 1
        '    Next
        '    Ds.Clear()
        'End With
        'lstTimework.Focus()
    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cboDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepartment.SelectedIndexChanged
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select DeptId From Department" &
                " Where Department = '" & cboDepartment.Text.Trim & "' " &
                " Order By Department"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            lblDeptId.Text = ""
            Dim I As Integer
            For I = 0 To .Rows.Count - 1
                lblDeptId.Text = .Rows(I).Item("DeptId")
            Next
            Ds.Clear()
        End With
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call LoadTimeworkSearch()
    End Sub

    Function IsHoliday(ByVal dCmd As SqlCommand, ByVal chkDate As String) As Boolean
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select Hol = dbo.fIsHoliday('" & chkDate.Trim & "')"
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()
        Da.SelectCommand = dCmd
        'Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            If .Rows(0).Item("Hol") = True Then
                Return True
            Else
                Return False
            End If
        End With
    End Function

    Function LoadTimeSt(ByVal chkDate As String) As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select DayStart,DayStop from TimeWorkingtime"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            If .Rows.Count = 0 Then
                Return chkDate & " 08:00"
            Else
                Return chkDate & " " & .Rows(0).Item("DayStart")
            End If
        End With
    End Function

    Function LoadTimeSp(ByVal chkDate As String) As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select DayStart,DayStop from TimeWorkingtime"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            If .Rows.Count = 0 Then
                Return chkDate & " 17:00"
            Else
                Return chkDate & " " & .Rows(0).Item("DayStop")
            End If
        End With
    End Function

    Private Sub GenTimework(ByVal Code As String, ByVal strDateSt As String, ByVal strDateSp As String)
        Dim DateSt As Date
        Dim DateSp As Date

        DateSt = strDateSt
        DateSp = strDateSp

        Dim dCmd As New SqlCommand
        Dim Tn As SqlTransaction
        Dim strSQL As String
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            Dim I As Date
            I = DateSt

            strSQL = "Exec SpTimeGenTimeWorkByPerson '" & Code.Trim & "'," &
                                        " '" & Format(DateSt, "yyyy/MM/dd") & "'," &
                                        " '" & Format(DateSp, "yyyy/MM/dd") & "',1"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
    End Sub


    Private Sub txtYear_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYear.LostFocus
        Call cboMonth_SelectedIndexChanged(Me, System.EventArgs.Empty)
    End Sub

    Private Sub txtYear_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub gvTimeWork_CustomColumnDisplayText(sender As Object, e As CustomColumnDisplayTextEventArgs) Handles gvTimeWork.CustomColumnDisplayText
        If e.Column.Name = "clNo" Then
            If e.ListSourceRowIndex >= 0 Then
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString
            End If
        End If
    End Sub

    Private Sub gvTimeWork_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles gvTimeWork.RowCellStyle
        Try
            Dim gv As GridView = CType(sender, GridView)

            Select Case e.Column.FieldName
                Case "Time1", "Time2", "Time3", "Time4"
                    If gv.GetRowCellValue(e.RowHandle, Replace(e.Column.FieldName, "Time", "TimeE")) = True Then
                        e.Appearance.ForeColor = Color.Blue
                    End If
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub gvTimeWork_DoubleClick(sender As Object, e As EventArgs) Handles gvTimeWork.DoubleClick
        Try
            Dim gv As GridView = CType(sender, GridView)

            If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "Code")) = True Then Exit Sub

            Dim frm As New frmEditTime

            ' LoadTime
            editRow = gv.GetRowCellValue(gv.FocusedRowHandle, "row")
            frm.txtDate.EditValue = gv.GetRowCellValue(gv.FocusedRowHandle, "DateIn")
            frm.txtCode.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Code")
            Call frm.txtCode_LostFocus(Me, System.EventArgs.Empty)
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            frm.BringToFront()

            Call LoadTimeworkSearchByCode(gv.GetRowCellValue(gv.FocusedRowHandle, "Code"), Format(gv.GetRowCellValue(gv.FocusedRowHandle, "DateIn"), "yyyy/MM/dd"))

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            cExport.Export_GridView(SaveFileDialog1, gvTimeWork, cboExport)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub


    Private Sub btnToDate_Click(sender As Object, e As EventArgs) Handles btnToDate.Click
        txtdatesp.EditValue = txtDatest.EditValue
    End Sub

    Private Sub gcTimeWork_Click(sender As Object, e As EventArgs) Handles gcTimeWork.Click

    End Sub

    Private Sub btnAllMonth_Click(sender As Object, e As EventArgs) Handles btnAllMonth.Click
        cboMonth_SelectedIndexChanged(Me, EventArgs.Empty)
    End Sub

    Private Sub btnCurrentDate_Click(sender As Object, e As EventArgs) Handles btnCurrentDate.Click
        txtDatest.EditValue = Now.Date
        txtdatesp.EditValue = Now.Date
    End Sub

    Private Sub txtCode1_EditValueChanged(sender As Object, e As EventArgs) Handles txtCode1.EditValueChanged

    End Sub

    Private Sub txtCode1_LostFocus(sender As Object, e As EventArgs) Handles txtCode1.LostFocus
        txtName.Text = GetData.GetShowEmpName(txtCode1.Text.Trim)
    End Sub

    Private Sub cboDivision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDivision.SelectedIndexChanged
        Call SearchData.LoadDepartment(Me, cboDepartment, GetData.GetDivisionId(cboDivision.Text.Trim), True)
    End Sub
End Class