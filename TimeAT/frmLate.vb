Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports TimeAttendance.utils

Public Class frmLate
    Dim Date_IN_update As String = ""
    Dim codeEmp_Update As String = ""

    Dim dsTime As DataSet
    Dim editRow As Integer = 0

    Private Sub frmLate_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        fLate = Nothing
    End Sub

    Private Sub frmLate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '   Call LoadMonth()

        Call SearchData.LoadMonth(cboMonth, False, True)
        txtYear.Text = Date.Now.Year
        '  cboMonth.SelectedIndex = Date.Now.Month - 1
        txtDateSt.EditValue = Now.Date
        txtDateSp.EditValue = Now.Date

        Call SearchData.LoadDivision(Me, cboDivision, True)
        Call SearchData.LoadDepartment(Me, cboDepartment, "", True)

        If GetData.GetPermision_export_excel(modStartup.UserId, Me.Tag) = True Or U_Username = "sa" Then
            cboExport.Enabled = True
            btnExport.Enabled = True
        Else
            cboExport.Enabled = False
            btnExport.Enabled = False
        End If

        cboExport.SelectedIndex = 1
    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        'Dim Da As New SqlDataAdapter
        'Dim Ds As New DataSet
        'Dim DateSt As DateTime
        'Dim DateSp As DateTime
        ''Dim arrDATA() As String
        ''Dim List As ListViewItem


        'btnProcess.Text = "ประมวลผล..."


        'If IsDate(txtDateSp.EditValue) = False Then
        '    'MsgBox("กรุณาป้อนวันที่ให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
        '    MsgManager.ShowDialog(Me, "frmLateRS", Me.Text, "Check_Date", MessageBoxIcon.Information)
        '    txtDateSt.Focus()
        '    Exit Sub
        'End If

        'If IsDate(txtDateSp.EditValue) = False Then
        '    'MsgBox("กรุณาป้อนวันที่ให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
        '    MsgManager.ShowDialog(Me, "frmLateRS", Me.Text, "Check_Date", MessageBoxIcon.Information)
        '    txtDateSp.Focus()
        '    Exit Sub
        'End If

        'DateSt = txtDateSt.EditValue
        'DateSp = txtDateSp.EditValue


        '' START

        'btnProcess.Enabled = False
        'Dim dCmd As New SqlCommand

        'ProgressBar1.Maximum = DateDiff(DateInterval.Day, DateSt, DateSp) + 1
        'ProgressBar1.Value = 0

        'Try
        '    Dim I As Date
        '    I = DateSt
        '    Do Until I > DateSp
        '        ProgressBar2.Text = Format(I, "dd/MM/yyyy")
        '        Application.DoEvents()
        '        Call CalLate(Format(I, "yyyy/MM/dd"), "")
        '        I = DateAdd(DateInterval.Day, 1, I)
        '        ProgressBar1.Value += 1
        '    Loop
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        '    btnProcess.Text = "2. ประมวลผล"
        '    btnProcess.Enabled = True
        'End Try
        ''MsgBox("Process Complete", MsgBoxStyle.Information, Me.Text)
        '' STOP
        'btnProcess.Text = "2. ประมวลผล"
        'btnProcess.Enabled = True
        'ProgressBar2.Value = 0
        'ProgressBar1.Value = 0
        'ProgressBar2.Text = ""

        'btnProcess.Enabled = True

        'Call btnRefresh_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub CalLate(ByVal CalDate As String, month_year As String)

        Dim dcmd As New SqlCommand
        Dim strSQL As String

        strSQL = "exec spTimeGenLate '" & CalDate & "','" & month_year & "'"

        dcmd.Connection = Conn
        dcmd.CommandText = strSQL
        dcmd.ExecuteNonQuery()


        'Dim Da As New SqlDataAdapter
        'Dim Ds As New DataSet
        'Dim arrDATA() As String
        'Dim List As New ListViewItem

        'StrSql = "Select * " &
        '            " From (" &
        '                 " Select Timework.DateIn,Timework.Code," &
        '                        " EmpName = Emp.Fname + '   ' + Emp.Lname," &
        '                        " Emp.DeptId," &
        '                        " Late = Isnull(dbo.fLate(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111)),0)" &
        '                        " ,LateReal = Isnull(dbo.fLateReal(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111)),0)" &
        '                        " ,LateTime3 = Isnull(dbo.fLate_time3(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111)),0)" &
        '                        " ,LateRealTime3 = Isnull(dbo.fLateReal_Time3(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111)),0)" &
        '                        " ,LateOut = Isnull(dbo.fLateOut(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111)),0)" &
        '                 " From TimeWork Inner Join Emp On Timework.Code = Emp.Code" &
        '                 " Where Convert(nvarchar(10),Timework.dateIn,111) Between '" & CalDate.Trim & "' and '" & CalDate.Trim & "'" &
        '                 ") as Ot"

        ''" ,LateVal = dbo.fLateValcationMorning(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111)," & _
        '' " Replace(Convert(nVarchar(16),Time1,120),'-','/')," & _
        '' " Replace(Convert(nVarchar(16),Time2,120),'-','/'))" & _

        ''" ,LateRec = dbo.fLateRec(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111)," & _
        '' " Replace(Convert(nVarchar(16),Time1,120),'-','/')," & _
        '' " Replace(Convert(nVarchar(16),Time2,120),'-','/'))" & _

        ''" ,LateOutVal = dbo.fLateValcationAfternoon(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111)," & _
        '' " Replace(Convert(nVarchar(16),Time1,120),'-','/')," & _
        '' " Replace(Convert(nVarchar(16),Time2,120),'-','/'))" & _

        ''" ,LateAll = dbo.fLateRecord(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111)," & _
        ''         " Replace(Convert(nVarchar(16),Time1,120),'-','/')," & _
        ''         " Replace(Convert(nVarchar(16),Time2,120),'-','/'))" & _
        ''" ,LateOutAll = dbo.fLateOutRecord(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111)," & _
        ''         " Replace(Convert(nVarchar(16),Time1,120),'-','/')," & _
        ''         " Replace(Convert(nVarchar(16),Time2,120),'-','/'))" & _

        'If lblDeptId.Text.Trim <> "" Then
        '    strSQL &= " and Ot.DeptId = '" & lblDeptId.Text.Trim & "'"
        'End If

        'If rdDate.Checked = True Then
        '    strSQL &= " Order By Ot.DateIn,Ot.Code"
        'End If
        'If rdCode.Checked = True Then
        '    strSQL &= " Order By Ot.Code,Ot.DateIn"
        'End If
        'If rdName.Checked = True Then
        '    strSQL &= " Order By Ot.EmpName,Ot.DateIn"
        'End If
        'If rdDept.Checked = True Then
        '    strSQL &= " Order By Ot.DeptId,Ot.DateIn,Ot.Code"
        'End If

        'btnProcess.Enabled = False

        'Da = New SqlDataAdapter(strSQL, Conn)
        'Da.Fill(Ds, "Data")
        'With Ds.Tables("Data")
        '    Dim I As Integer

        '    If .Rows.Count = 0 Then
        '        'MsgBox("ไม่พบข้อมูล", MsgBoxStyle.Information, Me.Text)
        '        Ds.Clear()
        '        Exit Sub
        '    End If
        '    ProgressBar2.Maximum = .Rows.Count
        '    For I = 0 To .Rows.Count - 1
        '        Dim LateRec As String = "/"
        '        Dim LateReal As Single
        '        Dim LateRealTime3 As Single
        '        Dim LateTime3 As Single
        '        Dim Late As Single
        '        Dim LateOut As Single
        '        Dim LateVal As Single
        '        Dim LateOutVal As Single
        '        ''Dim LateReccord As Single
        '        ''Dim LateOutRec As Single

        '        'If IsDBNull(.Rows(I).Item("LateRec")) = True Then
        '        '    LateRec = "/"
        '        'Else
        '        '    If .Rows(I).Item("LateRec") = True Then
        '        '        LateRec = "/"
        '        '    Else
        '        '        LateRec = ""
        '        '    End If
        '        'End If

        '        If .Rows(I).Item("code") = "GS06" Then
        '            Dim a As Integer = 0
        '        End If

        '        LateReal = .Rows(I).Item("LateReal")
        '        LateRealTime3 = .Rows(I).Item("LateRealTime3")
        '        Late = .Rows(I).Item("Late")
        '        LateTime3 = .Rows(I).Item("LateTime3")
        '        LateOut = .Rows(I).Item("LateOut")
        '        LateVal = 0 ' .Rows(I).Item("LateVal")
        '        LateOutVal = 0 ' .Rows(I).Item("LateOutVal")

        '        ''LateReccord = .Rows(I).Item("LateAll")
        '        ''LateOutRec = .Rows(I).Item("LateOutAll")

        '        'If .Rows(I).Item("Code") = "00001" And Format(.Rows(I).Item("DateIn"), "dd/MM/yyyy") = "18/06/2009" Then
        '        '    MsgBox(.Rows(I).Item("Code"), MsgBoxStyle.Information, Me.Text)
        '        'End If

        '        'If Late + LateVal > 0 Then
        '        '    Late = 0
        '        'Else
        '        '    Late = Late + LateVal
        '        'End If

        '        'If LateOut + LateOutVal > 0 Then
        '        '    LateOut = 0
        '        'Else
        '        '    LateOut = LateOut + LateOutVal
        '        'End If

        '        '' คิดทั้งหมด

        '        'If LateReccord + LateVal > 0 Then
        '        '    LateReccord = 0
        '        'Else
        '        '    LateReccord = LateReccord + LateVal
        '        'End If

        '        'If LateOutRec + LateOutVal > 0 Then
        '        '    LateOutRec = 0
        '        'Else
        '        '    LateOutRec = LateOutRec + LateOutVal
        '        'End If

        '        Dim LateBaht As Single = GetLateBaht(.Rows(I).Item("Code"), Late, Format(.Rows(I).Item("DateIn"), "yyyy/MM/dd"))

        '        arrDATA = New String() {I + 1,
        '                                Format(.Rows(I).Item("DateIn"), "dd/MM/yyyy"),
        '                                .Rows(I).Item("Code"),
        '                                .Rows(I).Item("EmpName"),
        '                                .Rows(I).Item("DeptId"),
        '                                LateReal,
        '                                Late,
        '                                LateRealTime3,
        '                                LateTime3,
        '                                LateOut,
        '                                LateRec.Trim,
        '                                Late + LateOut,
        '                                Format(LateBaht, "#,##0.00")}
        '        List = New ListViewItem(arrDATA)
        '        lstOvertime.Items.Add(List)
        '        ProgressBar2.Value = I + 1
        '    Next
        '    Ds.Clear()
        'End With
    End Sub

    Private Sub LoadDataDev()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim DateSt As String
        Dim DateSp As String
        'Dim arrDATA() As String
        'Dim List As ListViewItem

        Dim divid As String = GetData.GetDivisionId(cboDivision.Text.Trim)
        Dim deptid As String = GetData.GetDepartmentId(cboDepartment.Text.Trim)
        Dim code As String = txtCode1.Text.Trim
        Dim namesearch As String = txtNameSearch.Text.Trim


        DateSt = cDateTime.dbDate(txtDateSt.EditValue)
        DateSp = cDateTime.dbDate(txtDateSp.EditValue)


        strSQL = "Select top 50000 row_number() over("
        strSQL &= LoadDataDev_Oder_by()
        strSQL &= " ) As row," &
                " * " &
                " From (" &
                     " Select TimeLate.DateIn,TimeLate.Code,"

        If cValGolbal.Lang = "TH" Then
            strSQL &= " EmpName =Emp.Title + emp.Fname + '   ' + emp.Lname,"
        Else
            strSQL &= " EmpName =Emp.Title + ' ' + emp.Fname + '   ' + emp.Lname,"
        End If

        strSQL &= " isnull(dept.department,'') as department," &
                            " Emp.DeptId,LateReal,Late,LateOut,LateBaht," &
                            " Recording = Isnull(Recording,0), " &
                            " TotalLate = Isnull(TotalLate,0), " &
                            " Latesum=Late + LateOut, " &
                            " Late_str = dbo.fconvert_min_to_hmm(Late)," &
                            " LateOut_str = dbo.fconvert_min_to_hmm(LateOut)," &
                            " TotalLate_str = dbo.fconvert_min_to_hmm(Late + LateOut)" &
                     " From TimeLate " &
                            " Inner Join Emp " &
                                    " On TimeLate.Code = Emp.Code" &
                            " left join Department dept " &
                                " on emp.deptid = dept.deptid " &
                     " Where Convert(nvarchar(10),TimeLate.dateIn,111) Between '" & DateSt.Trim & "' and '" & DateSp.Trim & "'"

        If code <> "" Then
            strSQL &= " and TimeLate.Code = '" & code & "' "
        End If
        If code = "" Then
            If namesearch <> "" Then
                strSQL &= " and Emp.Fname + Emp.Lname Like '%" & namesearch & "%'"
            End If

            If deptid <> "" Then
                strSQL &= " and Emp.DeptId = '" & deptid & "'"
            End If

            If divid <> "" Then
                strSQL &= " and dept.DivId = '" & divid & "'"
            End If

        End If

        strSQL &= ") as Ot"

        '     strSQL &= " Where 1 = 1 "


        '  ") as Ot" &

        strSQL &= LoadDataDev_Oder_by()


        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")

        dsTime = Ds

        gcOvertime.DataSource = dsTime
        gcOvertime.DataMember = "Data"

    End Sub

    Function LoadDataDev_Oder_by() As String
        Dim query As String = ""
        If rdDate.Checked = True Then
            query &= " Order By Ot.DateIn,Ot.Code"
        End If
        If rdCode.Checked = True Then
            query &= " Order By Ot.Code,Ot.DateIn"
        End If
        If rdName.Checked = True Then
            query &= " Order By Ot.EmpName,Ot.DateIn"
        End If
        If rdDept.Checked = True Then
            query &= " Order By Ot.DeptId,Ot.DateIn,Ot.Code"
        End If
        Return query
    End Function

    Private Sub LoadMonth()
        Dim I As Integer
        cboMonth.Properties.Items.Clear()
        For I = 1 To 12
            'cboMonth.Items.Add(MonthNameThai(I))
            cboMonth.Properties.Items.Add(MonthName(Me, I))
        Next
    End Sub

    Private Sub LoadDataDevByCode(Code As String, datein As String)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim DateSt As String = ""
        Dim DateSp As String = ""
        'Dim arrDATA() As String
        'Dim List As ListViewItem

        strSQL = "Select top 50000 row_number() over("
        strSQL &= LoadDataDev_Oder_by()
        strSQL &= " ) As row," &
                " * " &
                " From (" &
                     " Select TimeLate.DateIn,TimeLate.Code,"
        If cValGolbal.Lang = "TH" Then
            strSQL &= " EmpName =Emp.Title + emp.Fname + '   ' + emp.Lname,"
        Else
            strSQL &= " EmpName =Emp.Title + ' ' + emp.Fname + '   ' + emp.Lname,"
        End If

        strSQL &= " isnull(dept.department,'') as department," &
                            " Emp.DeptId,LateReal,Late,LateOut,LateBaht," &
                            " Recording = Isnull(Recording,0), " &
                            " TotalLate = Isnull(TotalLate,0), " &
                            " Latesum=Late + LateOut " &
                     " From TimeLate " &
                            " Inner Join Emp " &
                                    " On TimeLate.Code = Emp.Code" &
                            " left join Department dept " &
                                " on emp.deptid = dept.deptid " &
                     " Where Convert(nvarchar(10),TimeLate.dateIn,111) = '" & datein.Trim & "'"


        strSQL &= " and TimeLate.Code = '" & code & "' "


        strSQL &= ") as Ot"

        '     strSQL &= " Where 1 = 1 "


        '  ") as Ot" &

        strSQL &= LoadDataDev_Oder_by()


        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Dim dr() As DataRow = dsTime.Tables(0).Select("row=" & editRow & "")
                If dr.Length > 0 Then
                    dsTime.Tables(0).Rows.Remove(dr(0))
                End If
            Else
                Dim dr() As DataRow = dsTime.Tables(0).Select("row=" & editRow & "")
                If dr.Length > 0 Then
                    dr(0).Item("Late") = .Rows(0).Item("Late")
                    dr(0).Item("LateOut") = .Rows(0).Item("LateOut")
                    dr(0).Item("TotalLate") = .Rows(0).Item("TotalLate")
                End If
            End If

        End With

    End Sub



    Private Sub LoadDepartment()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select Department From Department" &
                " Order By Department"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            cboDepartment.Properties.Items.Clear()
            cboDepartment.Properties.Items.Add("")
            Dim I As Integer
            For I = 0 To .Rows.Count - 1
                cboDepartment.Properties.Items.Add(.Rows(I).Item("Department"))
            Next
            Ds.Clear()
        End With
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMonth.SelectedIndexChanged
        If IsNumeric(txtYear.Text.Trim) = False Then Exit Sub
        Dim newMonth As String
        Dim newYear As String
        newMonth = Format(cboMonth.SelectedIndex + 1, "00")
        newYear = txtYear.Text.Trim
        Dim ar As New ArrayList
        ar = GetDayMonth(newMonth, newYear)
        txtDateSt.Text = ar.Item(0)
        txtDateSp.Text = ar.Item(1)



        'Dim DateSt As String
        'Dim newMonth As Integer
        'Dim newYear As String
        'If cboMonth.SelectedIndex = 0 Then
        '    newMonth = 12
        '    newYear = CInt(txtYear.Text) - 1
        'Else
        '    newMonth = cboMonth.SelectedIndex
        '    newYear = txtYear.Text.Trim
        'End If
        'DateSt = "01/" & Format(cboMonth.SelectedIndex + 1, "00") & "/" & txtYear.Text.Trim
        'txtDateSt.Text = DateSt
        'txtDateSp.Text = Format(MonthEnd(ConvertDate(DateSt)).Day, "00") & Format(cboMonth.SelectedIndex + 1, "00") & "/" & txtYear.Text.Trim
        'txtMonthYear.Text = Format(cboMonth.SelectedIndex + 1, "00") & "/" & txtYear.Text.Trim
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

        btnRefresh.Enabled = False
        '   Call LoadData()
        Call LoadDataDev()
        btnRefresh.Enabled = True

    End Sub


    Private Sub cboSite_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Function GetLateBaht(ByVal Code As String, ByVal Late As String, ByVal DateIn As String) As Single
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select Baht= dbo.fCalLateBaht('" & Code.Trim & "'," & Late & ",'" & DateIn.Trim & "')"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Return .Rows(0).Item("Baht")
            End If
        End With
    End Function

    Private Sub gcOvertime_Click(sender As Object, e As EventArgs) Handles gcOvertime.Click

    End Sub

    Private Sub gvOvertime_DoubleClick(sender As Object, e As EventArgs) Handles gvOvertime.DoubleClick
        'Dim frm As New frmEditTime

        '' LoadTime
        'frm.txtDate.Text = .SelectedItems(0).SubItems(1).Text
        'frm.txtCode.Text = .SelectedItems(0).SubItems(2).Text
        'Call frm.txtCode_LostFocus(Me, System.EventArgs.Empty)
        'frm.StartPosition = FormStartPosition.CenterScreen
        'frm.ShowDialog()
        'frm.BringToFront()


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

            Call LoadDataDevByCode(gv.GetRowCellValue(gv.FocusedRowHandle, "Code"), Format(gv.GetRowCellValue(gv.FocusedRowHandle, "DateIn"), "yyyy/MM/dd"))

        Catch ex As Exception

        End Try
    End Sub

    Private Sub LabelControl3_Click(sender As Object, e As EventArgs) Handles LabelControl3.Click

    End Sub

    Private Sub gvOvertime_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles gvOvertime.ValidatingEditor
        Dim view As GridView = CType(sender, GridView)
        Select Case view.FocusedColumn.FieldName


            Case "LateOut"
                If IsNumeric(e.Value) = False Then
                    e.Valid = False
                    '  e.ErrorText = "กรุณาป้อนเฉพาะตัวเลข"
                    e.ErrorText = My.Resources.res_warning_message.amount_please_input_number_only
                    Exit Sub
                End If

                Dim LateReal = Convert.ToDouble(e.Value)
                If LateReal < 0 Then
                    e.Valid = False
                    '  e.ErrorText = "จำนวนที่ป้อนไม่น้อยกว่า 0"
                    e.ErrorText = My.Resources.res_warning_message.amount_littel_zero
                    Exit Sub
                End If
                '    Call UpdateRecord_Amt(CLng(txtQudId.Text), "price", CDbl(e.Value))
                Call UpdateRecord_OT_Time("LateOut", Date_IN_update, codeEmp_Update, e.Value)

            Case "Late"
                If IsNumeric(e.Value) = False Then
                    e.Valid = False
                    '  e.ErrorText = "กรุณาป้อนเฉพาะตัวเลข"
                    e.ErrorText = My.Resources.res_warning_message.amount_please_input_number_only
                    Exit Sub
                End If

                Dim Late = Convert.ToDouble(e.Value)
                If Late < 0 Then
                    e.Valid = False
                    e.ErrorText = My.Resources.res_warning_message.amount_littel_zero
                    Exit Sub
                End If
                '    Call UpdateRecord_Amt(CLng(txtQudId.Text), "price", CDbl(e.Value))
                Call UpdateRecord_OT_Time("Late", Date_IN_update, codeEmp_Update, e.Value)


        End Select
    End Sub

    Public Sub UpdateRecord_OT_Time(FieldName As String, date_in_update As DateTime, codeEmp As String, Values_ As Double)
        Dim cn As New SqlConnection
        Dim db As New db
        Dim dCmd As New SqlCommand
        '     Dim Result As New ResponseResult
        Dim data As New ArrayList
        Dim strType As String = ""
        Dim strSQL As String = ""


        strSQL = "Update TimeLate  Set " & FieldName & " =" & Values_ & " Where convert(nvarchar(10),datein,111)='" & Format(date_in_update, "yyyy/MM/dd") & "' And Code='" & codeEmp & "' "


        Try

            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            'db.OpenDatabase(cn, True)
            'db.ExecuteCommand(cn, dCmd, strSQL, strType, data)
            'db.OpenDatabase(cn, False)
        Catch ex As Exception
            'Result.Success = False
            'Result.ErrorMessage = ex.Message
            '   Return Result
        End Try

    End Sub

    Private Sub gvUsername_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvOvertime.FocusedRowChanged
        Try
            Date_IN_update = gvOvertime.GetRowCellValue(e.FocusedRowHandle, "DateIn").ToString
            codeEmp_Update = gvOvertime.GetRowCellValue(e.FocusedRowHandle, "Code").ToString
            '  lblTextFindProductCode.Text = GvQu.GetRowCellValue(e.FocusedRowHandle, "productCode").ToString
        Catch ex As Exception
            Date_IN_update = ""
            codeEmp_Update = ""
        End Try

    End Sub

    Private Sub gvUsername_FocusedRowLoaded(sender As Object, e As RowEventArgs) Handles gvOvertime.FocusedRowLoaded
        Try
            Date_IN_update = gvOvertime.GetRowCellValue(e.RowHandle, "DateIn").ToString
            codeEmp_Update = gvOvertime.GetRowCellValue(e.RowHandle, "Code").ToString
        Catch ex As Exception
            Date_IN_update = ""
            codeEmp_Update = ""
        End Try
    End Sub

    Private Sub gvUsername_FocusedRowObjectChanged(sender As Object, e As FocusedRowObjectChangedEventArgs) Handles gvOvertime.FocusedRowObjectChanged
        Try
            Date_IN_update = gvOvertime.GetRowCellValue(e.RowHandle, "DateIn").ToString
            codeEmp_Update = gvOvertime.GetRowCellValue(e.FocusedRowHandle, "Code").ToString
        Catch ex As Exception
            Date_IN_update = ""
            codeEmp_Update = ""
        End Try
    End Sub

    Private Sub cboDepartment_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboDepartment.SelectedIndexChanged

    End Sub

    Private Sub gvOvertime_Click(sender As Object, e As EventArgs) Handles gvOvertime.Click

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            cExport.Export_GridView(SaveFileDialog1, gvOvertime, cboExport)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub btnTodate_Click(sender As Object, e As EventArgs) Handles btnTodate.Click
        txtDateSp.EditValue = txtDateSt.EditValue
    End Sub

    Private Sub btnCurrentDate_Click(sender As Object, e As EventArgs) Handles btnCurrentDate.Click
        txtDateSt.EditValue = Now.Date
        txtDateSp.EditValue = Now.Date
    End Sub

    Private Sub btnAllMonth_Click(sender As Object, e As EventArgs) Handles btnAllMonth.Click
        cboMonth_SelectedIndexChanged(Me, EventArgs.Empty)
    End Sub

    Private Sub txtCode1_EditValueChanged(sender As Object, e As EventArgs) Handles txtCode1.EditValueChanged

    End Sub

    Private Sub txtCode1_LostFocus(sender As Object, e As EventArgs) Handles txtCode1.LostFocus
        txtName.Text = GetData.GetShowEmpName(txtCode1.Text.Trim)
    End Sub

    Private Sub cboDivision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDivision.SelectedIndexChanged
        Call SearchData.LoadDepartment(Me, cboDepartment, GetData.GetDivisionId(cboDivision.Text.Trim), True)
    End Sub

    Private Sub btnClearData_Click(sender As Object, e As EventArgs) Handles btnClearData.Click

    End Sub
End Class