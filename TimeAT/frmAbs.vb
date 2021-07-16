Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports TimeAttendance.utils

Public Class frmAbs
    Dim Date_IN_update As String = ""
    Dim codeEmp_Update As String = ""

    Dim dsTime As DataSet
    Dim editRow As Integer = 0

    Private Sub frmAbs_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        fAbsent = Nothing
    End Sub

    Private Sub frmAbs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '    Call LoadMonth()
        Call SearchData.LoadMonth(cboMonth, False, True)
        txtYear.Text = Date.Now.Year
        '   cboMonth.SelectedIndex = Date.Now.Month - 1
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
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim DateSt As String
        Dim DateSp As String

        '   btnProcess.Text = "ประมวลผล..."
        btnProcess.Text = My.Resources.res_warning_message_spacial.Procress_label
        DateSt = cDateTime.dbDate(txtDateSt.EditValue)
        DateSp = cDateTime.dbDate(txtDateSp.EditValue)

        If IsDate(DateSt.Trim) = False Then
            'MsgBox("กรุณาป้อนวันที่ให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmAbsRS", Me.Text, "Check_Date", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
            txtDateSt.Focus()
            Exit Sub
        End If

        If IsDate(DateSp.Trim) = False Then
            'MsgBox("กรุณาป้อนวันที่ให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmAbsRS", Me.Text, "Check_Date", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
            txtDateSp.Focus()
            Exit Sub
        End If


        ''START
        'Dim dCmd As New SqlCommand

        'btnProcess.Enabled = False

        'ProgressBar1.Maximum = DateDiff(DateInterval.Day, CDate(DateSt), CDate(DateSp)) + 1
        'ProgressBar1.Value = 0
        'lstOvertime.Items.Clear()
        'Try
        '    Dim I As Date
        '    I = DateSt
        '    Do Until I > DateSp
        '        lblDateProcess.Text = Format(I, "dd/MM/yyyy")
        '        ProgressBar2.Text = Format(I, "dd/MM/yyyy")
        '        Application.DoEvents()
        '        Call CalABS(Format(I, "yyyy/MM/dd"), txtMonthYear.Text)
        '        I = DateAdd(DateInterval.Day, 1, I)
        '        ProgressBar1.Value += 1
        '    Loop
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        '    btnProcess.Text = "2. ประมวลผล"
        '    btnProcess.Enabled = True
        'End Try
        ''STOP


        'btnProcess.Text = "2.ประมวลผล"
        'btnProcess.Enabled = True

        'ProgressBar2.Text = ""
        'ProgressBar1.Value = 0
        'ProgressBar2.Value = 0

        Call btnRefresh_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub CalABS(ByVal CalDate As String, month_year As String)
        'Dim Da As New SqlDataAdapter
        'Dim Ds As New DataSet
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        'Dim arrDATA() As String
        'Dim List As ListViewItem


        strSQL = "Exec spTimeAbs '" & CalDate & "','" & CalDate & "','" & month_year & "'"

        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()

        'Da = New SqlDataAdapter(strSQL, Conn)
        'Da.Fill(Ds, "Data")
        'With Ds.Tables("Data")
        '    Dim I As Integer
        '    ProgressBar2.Maximum = .Rows.Count
        '    ProgressBar2.Value = 0
        '    If .Rows.Count = 0 Then
        '        'MsgBox("ไม่พบข้อมูล", MsgBoxStyle.Information, Me.Text)
        '        Ds.Clear()
        '        'btnProcess.Enabled = True
        '        Exit Sub
        '    End If
        '    For I = 0 To .Rows.Count - 1
        '        arrDATA = New String() {I + 1,
        '                                Format(.Rows(I).Item("DateIn"), "dd/MM/yyyy"),
        '                                .Rows(I).Item("Code"),
        '                                .Rows(I).Item("EmpName"),
        '                                .Rows(I).Item("DeptId"),
        '                                .Rows(I).Item("Absent")}
        '        List = New ListViewItem(arrDATA)
        '        lstOvertime.Items.Add(List)
        '        ProgressBar2.Value = I + 1
        '    Next
        'End With
    End Sub


    Private Sub LoadDataDev()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim DateSt As String
        Dim DateSp As String

        Dim divid As String = GetData.GetDivisionId(cboDivision.Text.Trim)
        Dim deptid As String = GetData.GetDepartmentId(cboDepartment.Text.Trim)
        Dim code As String = txtCode1.Text.Trim
        Dim namesearch As String = txtNameSearch.Text.Trim

        DateSt = cDateTime.dbDate(txtDateSt.EditValue)
        DateSp = cDateTime.dbDate(txtDateSp.EditValue)

        strSQL = "Select top 50000 row_number() over("
        strSQL &= LoadDataDev_order_by()
        strSQL &= " ) As row," &
                " * " &
                " From (" &
                     " Select TimeAbsent.DateIn,TimeAbsent.Code,"
        If cValGolbal.Lang = "TH" Then
            strSQL &= " EmpName =Emp.Title + emp.Fname + '   ' + emp.Lname,"
        Else
            strSQL &= " EmpName =Emp.Title + ' ' + emp.Fname + '   ' + emp.Lname,"
        End If

        strSQL &= " Emp.DeptId,abs(Absent) as Absent," &
                            " isnull(dept.department,'') as department" &
                     " From TimeAbsent Inner Join Emp On TimeAbsent.Code = Emp.Code" &
                            " left join department dept " &
                                    " on emp.deptid = dept.deptid" &
                " Where Convert(nVarchar(10),TimeAbsent.DateIn,111) " &
                    " between '" & DateSt & "' and '" & DateSp & "'"

        If code <> "" Then
            strSQL &= " and TimeAbsent.Code = '" & code & "' "
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




        strSQL &= LoadDataDev_order_by()

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")

        dsTime = Ds

        gcOvertime.DataSource = dsTime
        gcOvertime.DataMember = "Data"
    End Sub

    Function LoadDataDev_order_by() As String
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


    Private Sub LoadDataDevByCode(Code As String, datein As String)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "Select row_number() over("
        strSQL &= LoadDataDev_order_by()
        strSQL &= " ) As row," &
                " * " &
                " From (" &
                     " Select TimeAbsent.DateIn,TimeAbsent.Code,"
        If cValGolbal.Lang = "TH" Then
            strSQL &= " EmpName =Emp.Title + emp.Fname + '   ' + emp.Lname,"
        Else
            strSQL &= " EmpName =Emp.Title + ' ' + emp.Fname + '   ' + emp.Lname,"
        End If

        strSQL &= " Emp.DeptId,Absent," &
                            " isnull(dept.department,'') as department" &
                     " From TimeAbsent Inner Join Emp On TimeAbsent.Code = Emp.Code" &
                            " left join department dept " &
                                    " on emp.deptid = dept.deptid" &
                " Where Convert(nVarchar(10),TimeAbsent.DateIn,111) " &
                    " = '" & datein & "'"

        strSQL &= " and TimeAbsent.Code = '" & code & "' "


            strSQL &= ") as Ot"




        strSQL &= LoadDataDev_order_by()

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
                    dr(0).Item("Absent") = .Rows(0).Item("Absent")
                End If
            End If

        End With
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
        Dim newMonth As String
        Dim newYear As String
        newMonth = Format(cboMonth.SelectedIndex + 1, "00")
        newYear = txtYear.Text.Trim
        Dim ar As New ArrayList
        ar = GetDayMonth(newMonth, newYear)
        txtDateSt.EditValue = CDate(ar.Item(0))
        txtDateSp.EditValue = CDate(ar.Item(1))

        'txtMonthYear.Text = Format(cboMonth.SelectedIndex + 1, "00") & "/" & txtYear.Text.Trim

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
        Call LoadDataDev()
        btnRefresh.Enabled = True
    End Sub


    Private Sub btnClearData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearData.Click
        'Dim dCMD As New SqlCommand
        'Dim strSQL As String
        ''If MsgBox("คุณต้องการลบข้อมูลขาดงานทั้งหมดหรือไม่", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then Exit Sub

        'If MsgManager.ConfirmDialog(Me, "frmAbsRS", Me.Text, "Del_Abs",
        'MessageBoxIcon.Information) = DialogResult.Cancel Then Exit Sub

        'Try
        '    strSQL = "Delete From TimeAbsent Where Month_year = '" & txtMonthYear.Text.Trim & "'"
        '    dCMD.Connection = Conn
        '    dCMD.CommandText = strSQL
        '    dCMD.ExecuteNonQuery()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        '    Exit Sub
        'End Try
        ''MsgBox("ลบข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information, Me.Text)
        'MsgManager.ShowDialog(Me, "frmAbsRS", Me.Text, "Delete_Complete", MessageBoxIcon.Information)
    End Sub

    Private Sub gcOvertime_Click(sender As Object, e As EventArgs) Handles gcOvertime.Click

    End Sub

    Private Sub btnTodate_Click(sender As Object, e As EventArgs) Handles btnTodate.Click
        txtDateSp.EditValue = txtDateSt.EditValue
    End Sub

    Private Sub gvOvertime_DoubleClick(sender As Object, e As EventArgs) Handles gvOvertime.DoubleClick
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

    Private Sub gvOvertime_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles gvOvertime.ValidatingEditor
        Dim view As GridView = CType(sender, GridView)
        Select Case view.FocusedColumn.FieldName


            'Case "Absent"
            '    If IsNumeric(e.Value) = False Then
            '        e.Valid = False
            '        e.ErrorText = "กรุณาป้อนเฉพาะตัวเลข"
            '        Exit Sub
            '    End If
            '    Call UpdateRecord_OT_Time("Absent", Date_IN_update, codeEmp_Update, e.Value)



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


        strSQL = "Update TimeAbsent  Set " & FieldName & " =" & Values_ & " Where convert(nvarchar(10),datein,111)='" & Format(date_in_update, "yyyy/MM/dd") & "' And Code='" & codeEmp & "' "


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

    'Private Sub gvOvertime_Click(sender As Object, e As EventArgs) Handles gvOvertime.Click
    '    Try
    '        Dim gv As GridView = CType(sender, GridView)

    '        If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "Code")) = True Then Exit Sub

    '        Dim frm As New frmEditTime

    '        ' LoadTime
    '        Date_IN_update = gv.GetRowCellValue(gv.FocusedRowHandle, "DateIn")
    '        codeEmp_Update = gv.GetRowCellValue(gv.FocusedRowHandle, "Code")
    '        'Call frm.txtCode_LostFocus(Me, System.EventArgs.Empty)
    '        'frm.StartPosition = FormStartPosition.CenterScreen
    '        'frm.ShowDialog()
    '        'frm.BringToFront()

    '    Catch ex As Exception

    '    End Try
    'End Sub

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

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            cExport.Export_GridView(SaveFileDialog1, gvOvertime, cboExport)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub btnCurrentDate_Click(sender As Object, e As EventArgs) Handles btnCurrentDate.Click
        txtDateSt.EditValue = Now.Date
        txtDateSp.EditValue = Now.Date
    End Sub

    Private Sub btnAllMonth_Click(sender As Object, e As EventArgs) Handles btnAllMonth.Click
        cboMonth_SelectedIndexChanged(Me, System.EventArgs.Empty)
    End Sub

    Private Sub txtCode1_LostFocus(sender As Object, e As EventArgs) Handles txtCode1.LostFocus
        txtName.Text = GetData.GetShowEmpName(txtCode1.Text.Trim)
    End Sub

    Private Sub cboDivision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDivision.SelectedIndexChanged
        Call SearchData.LoadDepartment(Me, cboDepartment, GetData.GetDivisionId(cboDivision.Text.Trim), True)
    End Sub
End Class