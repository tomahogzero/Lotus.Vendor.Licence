Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports TimeAttendance.utils

Public Class frmOvertime
    Dim Date_IN_update As String = ""
    Dim codeEmp_Update As String = ""

    Dim dsTime As DataSet
    Dim editRow As Integer = 0

    Private Sub frmOvertime_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        fOvertime = Nothing
    End Sub

    Private Sub frmOvertime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '   txtMonthYear.Text = Format(cboMonth.SelectedIndex + 1, "00") & "/" & txtYear.Text.Trim

        '  Call LoadMonth()
        Call SearchData.LoadMonth(cboMonth, False, True)
        txtYear.Text = Date.Now.Year
        '    cboMonth.SelectedIndex = Date.Now.Month - 1
        txtDatesp.EditValue = Now.Date
        txtDateSt.EditValue = Now.Date

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

        DateSt = cDateTime.dbDate(txtDateSt.EditValue)
        DateSp = cDateTime.dbDate(txtDatesp.EditValue)


        'btnProcess.Text = "ประมวลผล..."

        'If IsDate(DateSt.Trim) = False Then
        '    'MsgBox("¡ÃØ³Ò»éÍ¹ÇÑ¹·ÕèãËé¶Ù¡µéÍ§´éÇÂ", MsgBoxStyle.Information, Me.Text)
        '    MsgManager.ShowDialog(Me, "frmOvertimeRS", Me.Text, "Check_Date", MessageBoxIcon.Information)
        '    txtDateSt.Focus()
        '    Exit Sub
        'End If

        'If IsDate(DateSp.Trim) = False Then
        '    'MsgBox("¡ÃØ³Ò»éÍ¹ÇÑ¹·ÕèãËé¶Ù¡µéÍ§´éÇÂ", MsgBoxStyle.Information, Me.Text)
        '    MsgManager.ShowDialog(Me, "frmOvertimeRS", Me.Text, "Check_Date", MessageBoxIcon.Information)
        '    txtDatesp.Focus()
        '    Exit Sub
        'End If

        'If IsDate(ConvertDate("01/" & txtMonthYear.Text.Trim)) = False Then
        '    'MsgBox("¡ÃØ³ÒÃÐºØà´×Í¹·ÕèµéÍ§¡ÒÃ¨èÒÂãËé¶Ù¡µéÍ§´éÇÂ", MsgBoxStyle.Information, Me.Text)
        '    MsgManager.ShowDialog(Me, "frmOvertimeRS", Me.Text, "Check_Month", MessageBoxIcon.Information)
        '    txtMonthYear.Focus()
        '    txtMonthYear.SelectAll()
        '    Exit Sub
        'End If


        ''START
        '' START

        'btnProcess.Enabled = False
        'Dim dCmd As New SqlCommand

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
        '        Call CalOT(Format(I, "yyyy/MM/dd"), txtMonthYear.Text)
        '        I = DateAdd(DateInterval.Day, 1, I)
        '        ProgressBar1.Value += 1
        '    Loop
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        '    btnProcess.Text = "2. ประมวลผล"
        '    btnProcess.Enabled = True
        'End Try

        ''STOP

        'btnProcess.Text = "2. ประมวลผล"
        'btnProcess.Enabled = True

        'ProgressBar2.Value = 0
        'ProgressBar1.Value = 0
        'ProgressBar2.Text = ""

        Call btnRefresh_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub CalOT(ByVal calDate As String, month_year As String)
        Dim dcmd As New SqlCommand
        Dim strSQL As String

        strSQL = "exec spTimeGenOT '" & calDate & "','" & month_year & "'"

        dcmd.Connection = Conn
        dcmd.CommandText = strSQL
        dcmd.ExecuteNonQuery()


        'Dim Da As New SqlDataAdapter
        'Dim Ds As New DataSet
        'Dim strSQL As String
        'Dim arrDATA() As String
        'Dim List As ListViewItem

        ''strSQL = "Select * " & _
        ''    " From (" & _
        ''         " Select Timework.DateIn,Timework.Code," & _
        ''                " EmpName = Emp.Fname + '   ' + Emp.Lname," & _
        ''                " Emp.DeptId," & _
        ''                " TimeOut = Replace(Convert(nVarchar(16)," & _
        ''                                            "dbo.fGetTimeOut(TimeWork.Code,Convert(nVarchar(10),Timework.DateIn,111))" & _
        ''                                            ",120),'-','/'), " & _
        ''                " Ot1_5 = dbo.fOtHourOut(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111),1.5)," & _
        ''                " Ot1 = dbo.fOtHolDay(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111),1)," & _
        ''                " Ot2 = dbo.fOtHolDay(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111),2)," & _
        ''                " Ot3 = dbo.fOtHourOut(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111),3)," & _
        ''                " OtBahtHol_H = dbo.fOtHolDayB(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111))," & _
        ''                " OtBahtH = dbo.fOtHourOutB(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111))" & _
        ''         " From TimeWork Inner Join Emp On Timework.Code = Emp.Code " & _
        ''         " Where 1 = 1 "
        'Dim OT As String
        'OT = "OT"
        'strSQL = "Select * " &
        '            " From (" &
        '                 " Select Timework.DateIn,Timework.Code," &
        '                        " EmpName = Emp.Fname + '   ' + Emp.Lname," &
        '                        " Emp.DeptId," &
        '                        " TimeOut = Replace(Convert(nVarchar(16)," &
        '                                                    "dbo.fGetTimeOut(TimeWork.Code,Convert(nVarchar(10),Timework.DateIn,111))" &
        '                                                    ",120),'-','/'), " &
        '                        " Ot_H = dbo.fOtHourOut(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111),1.5)," &
        '                        " Ot_D = dbo.fOtHolDay(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111),1)," &
        '                        " OTH_Rate = dbo.fGetOT_Rate(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111),'OT')," &
        '                        " OTD_Rate = dbo.fGetOT_Rate(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111),'T')," &
        '                        " OtBahtHol_H = dbo.fOtHolDayB(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111))," &
        '                        " OtBahtH = dbo.fOtHourOutB(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111))," &
        '                        " WKEnd = dbo.fIsWKEnd(Timework.Code,Convert(nVarchar(10),Timework.DateIn,111))," &
        '                        " Hol = dbo.fIsHoliday_Hol(Convert(nVarchar(10),Timework.DateIn,111))" &
        '                 " From TimeWork Inner Join Emp On Timework.Code = Emp.Code " &
        '                 " Where 1 = 1 "

        'If cboCompany.SelectedIndex > 0 Then
        '    strSQL &= " and isnull(Emp.CompanyId,'') = '" & GetData.GetCompanyId(cboCompany.Text.Trim) & "'"
        'End If
        'strSQL &= " and Convert(nvarchar(10),Timework.dateIn,111) Between '" & calDate.Trim & "' and '" & calDate.Trim & "'" &
        '                 ") as Ot "

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
        '    ProgressBar2.Maximum = .Rows.Count
        '    ProgressBar2.Value = 0
        '    If .Rows.Count = 0 Then
        '        'MsgBox("äÁè¾º¢éÍÁÙÅ", MsgBoxStyle.Information, Me.Text)
        '        Ds.Clear()
        '        btnProcess.Enabled = True
        '        Exit Sub
        '    End If
        '    For I = 0 To .Rows.Count - 1
        '        Dim dr As DataRow = .Rows(I)
        '        'If IsDBNull(.Rows(I).Item("TimeOut")) = False Then
        '        '    'MsgBox(.Rows(I).Item("TimeOut"))
        '        '    'Call CalAllowanceAuto(txtMonthYear.Text.Trim, _
        '        '    '                                        .Rows(I).Item("Code"), _
        '        '    '                                        Format(.Rows(I).Item("DateIn"), "yyyy/MM/dd"), _
        '        '    '                                        .Rows(I).Item("TimeOut"))
        '        'End If

        '        Dim OTBH As Integer = dr("OTBahtHol_H") + dr("OTBahtH")
        '        Dim OTH As Single = OTBH / 60

        '        Dim OTB As Single = 0
        '        Dim Period As Single = 0
        '        Dim OT_H As Single = dr("OT_H")
        '        Dim OT_D As Single = dr("OT_D")
        '        Dim OTD_Rate As Single = dr("OTD_Rate")
        '        Dim OTH_Rate As Single = dr("OTH_Rate")
        '        Dim WKEnd As String = ""
        '        Dim Hol As String = ""

        '        Dim OtIdx As Integer = GetData.GetOTTypeIdx(dr("Code"))

        '        ' áºº ·Õè 2 ¨èÒÂ Ot ä»ÍÂÙè Rate à´ÕÂÇ
        '        'If OtIdx = 2 Then
        '        '    Dim OTFixed As Single = GetData.GetOTFixedRate
        '        '    Select Case OTFixed
        '        '        Case 1
        '        '            OT1 = OT1 + OT15 + OT2 + OT3

        '        '            OT15 = 0
        '        '            OT2 = 0
        '        '            OT3 = 0
        '        '        Case 1.5
        '        '            OT15 = OT1 + OT15 + OT2 + OT3

        '        '            OT1 = 0
        '        '            OT2 = 0
        '        '            OT3 = 0
        '        '        Case 2
        '        '            OT2 = OT1 + OT15 + OT2 + OT3

        '        '            OT1 = 0
        '        '            OT15 = 0
        '        '            OT3 = 0
        '        '        Case 3
        '        '            OT3 = OT1 + OT15 + OT2 + OT3

        '        '            OT1 = 0
        '        '            OT15 = 0
        '        '            OT2 = 0
        '        '    End Select
        '        'End If

        '        ' áºº ·Õè 3 ¨èÒÂ Ot ä» ¤Ù³ Fixed Rate ã¹ OT

        '        ' ¨èÒÂà»ç¹ ¤Òº
        '        If OtIdx = 4 Then
        '            Period = GetOTPeriod(dr("Code"), OTH, Format(dr("DateIn"), "yyyy/MM/dd"))
        '        End If

        '        ' ¨èÒÂà»ç¹ à§Ô¹
        '        If OtIdx = 5 Then
        '            OTB = GetOTBaht(dr("Code"), OTH, Format(dr("DateIn"), "yyyy/MM/dd"))
        '        End If

        '        If dr("WKEnd") = True Then
        '            WKEnd = "/"
        '        Else
        '            WKEnd = ""
        '        End If

        '        If dr("Hol") = True Then
        '            Hol = "/"
        '        Else
        '            Hol = ""
        '        End If



        '        'arrDATA = New String() {I + 1, _
        '        '                        Format(dr("DateIn"), "dd/MM/yyyy"), _
        '        '                        dr("Code"), _
        '        '                        dr("EmpName"), _
        '        '                        dr("DeptId"), _
        '        '                        OT15, _
        '        '                        OT1, _
        '        '                        OT2, _
        '        '                        OT3, _
        '        '                        OTBH, _
        '        '                        OTH, _
        '        '                        Format(OTB, "#,##0.00"), _
        '        '                        Period}

        '        arrDATA = New String() {I + 1,
        '                               Format(dr("DateIn"), "dd/MM/yyyy"),
        '                               dr("Code"),
        '                               dr("EmpName"),
        '                               dr("DeptId"),
        '                               OT_D,
        '                               OT_H,
        '                               OTD_Rate,
        '                               OTH_Rate,
        '                               OTBH,
        '                               OTH,
        '                               Format(OTB, "#,##0.00"),
        '                               Period, WKEnd, Hol}

        '        List = New ListViewItem(arrDATA)
        '        lstOvertime.Items.Add(List)
        '        ProgressBar2.Value = I + 1
        '    Next
        'End With
    End Sub

    Function GetOTBaht(ByVal Code As String, ByVal OT As Integer, ByVal DateIn As String) As Single
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select Baht= dbo.fCalOtBaht('" & Code.Trim & "'," & OT & ",'" & DateIn.Trim & "')"
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

    Function GetOTPeriod(ByVal Code As String, ByVal OT As Single, ByVal DateIn As String) As Single
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select Baht= dbo.fCalOtPeriod('" & Code.Trim & "'," & OT & ",'" & DateIn.Trim & "')"
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

    Private Sub CalAllowanceAuto(ByVal MonthYear As String, ByVal Code As String, ByVal DateIn As String, ByVal TimeOut As String)
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Try
            strSQL = "Exec spTimeGenAutoAllowance '" & MonthYear.Trim & "','" & Code.Trim & "','" & DateIn.Trim & "','" & TimeOut.Trim & "'"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub loadDatadev()
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
        DateSp = cDateTime.dbDate(txtDatesp.EditValue)
        strSQL = "Select top 50000 row_number() over("
        strSQL &= loadDatadev_order_by()
        strSQL &= " ) As row," &
                " * " &
                " From (" &
                     " Select TimeOvertime.DateIn,TimeOvertime.Code,"
        If cValGolbal.Lang = "TH" Then
            strSQL &= " EmpName =Emp.Title + emp.Fname + '   ' + emp.Lname,"
        Else
            strSQL &= " EmpName =Emp.Title + ' ' + emp.Fname + '   ' + emp.Lname,"
        End If

        strSQL &= " Emp.DeptId,OT1,Ot2,OT15,OT3,OTBaht_H,OTBaht,OTH,OTPeriod," &
                            " TimeOverTime.OT_Time,TimeOverTime.OT_Time_Rate, " &
                            " TimeOverTime.OT_OverTime,TimeOverTime.OT_OverTime_Rate, " &
                            " WKEnd = Isnull(TimeOvertime.WKEnd,0)," &
                            " Hol = Isnull(TimeOvertime.Hol,0)" &
                            ",isnull(dept.department,'') as department" &
                     " From TimeOvertime Inner Join Emp On TimeOvertime.Code = Emp.Code" &
                            " left join department dept " &
                                " on emp.deptid = dept.deptid " &
                     " Where 1 = 1 "
        strSQL &= " and Convert(nvarchar(10),TimeOvertime.dateIn,111) Between '" & DateSt.Trim & "' and '" & DateSp.Trim & "'"

        If code <> "" Then
            strSQL &= " and TimeOvertime.Code = '" & code & "' "
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

        strSQL &= ") As Ot"

        strSQL &= loadDatadev_order_by()

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")

        dsTime = Ds

        gcTimeWork.DataSource = dsTime
        gcTimeWork.DataMember = "Data"
    End Sub

    Function loadDatadev_order_by() As String
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

    Private Sub loadDatadevByCode(Code As String, datein As String)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "Select row_number() over("
        strSQL &= loadDatadev_order_by()
        strSQL &= " ) As row," &
                " * " &
                " From (" &
                     " Select TimeOvertime.DateIn,TimeOvertime.Code," &
                            " EmpName = Emp.Fname + '   ' + Emp.Lname," &
                            " Emp.DeptId,OT1,Ot2,OT15,OT3,OTBaht_H,OTBaht,OTH,OTPeriod," &
                            " TimeOverTime.OT_Time,TimeOverTime.OT_Time_Rate, " &
                            " TimeOverTime.OT_OverTime,TimeOverTime.OT_OverTime_Rate, " &
                            " WKEnd = Isnull(TimeOvertime.WKEnd,0)," &
                            " Hol = Isnull(TimeOvertime.Hol,0)" &
                            ",isnull(dept.department,'') as department" &
                     " From TimeOvertime Inner Join Emp On TimeOvertime.Code = Emp.Code" &
                            " left join department dept " &
                                " on emp.deptid = dept.deptid " &
                     " Where 1 = 1 "
        strSQL &= " and Convert(nvarchar(10),TimeOvertime.dateIn,111) = '" & datein.Trim & "'"

        strSQL &= " and TimeOvertime.Code = '" & code & "' "

        strSQL &= ") As Ot"

        strSQL &= loadDatadev_order_by()

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
                    dr(0).Item("OT_Time") = .Rows(0).Item("OT_Time")
                    dr(0).Item("OT_OverTime") = .Rows(0).Item("OT_OverTime")
                    dr(0).Item("WKEnd") = .Rows(0).Item("WKEnd")
                    dr(0).Item("Hol") = .Rows(0).Item("Hol")
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
        'txtDateSt.EditValue = CDate(ar.Item(0))
        'txtDatesp.EditValue = CDate(ar.Item(1))

        txtDateSt.EditValue = CDate(ar.Item(0))
        txtDatesp.EditValue = CDate(ar.Item(1))

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
        ''DateSt = "11/" & Format(newMonth, "00") & "/" & newYear
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
        Call loadDatadev()
        btnRefresh.Enabled = True
    End Sub

    Private Sub GvVacation_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles gvTimeWork.CustomDrawCell
        If e.Column.Name = "colrow" Then
            If e.RowHandle < -1 Then
                e.DisplayText = "0"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If

    End Sub

    Private Sub gvTimeWork_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles gvTimeWork.ValidatingEditor
        '   If txtQudId.Text = "" Or txtQudId.Text = "-1" Then Exit Sub

        Dim view As GridView = CType(sender, GridView)
        Select Case view.FocusedColumn.FieldName


      '      Case "OT_Time"
            'Dim productCode = Convert.ToDouble(e.Value)
            'If productCode = Nothing Then
            '    e.Valid = False
            '    e.ErrorText = "กรุณาป้อนรหัสสินค้า"
            'End If
            ' Call UpdateRecord(CDbl(txtQudId.EditValue), "productCode", CStr(e.Value))
            '    Call UpdateRecord_QuId(CLng(txtQudId.EditValue), "productid", CLng(e.Value))

         '   gvTimeWork.DeleteRow(gvTimeWork.FocusedRowHandle)
               ' Call SetFocusToNewItemRow()


            'Case "unitid"
            '    Dim unitid = Convert.ToInt32(e.Value)
            '    If unitid = 0 Then
            '        e.Valid = False
            '        e.ErrorText = "กรุณาป้อนหน่วยนับ"
            '    End If
            '    Call UpdateRecord_QuId(CLng(txtQudId.EditValue), "unitid", CLng(e.Value))


            Case "OT_Time"
                If IsNumeric(e.Value) = False Then
                    e.Valid = False
                    e.ErrorText = "กรุณาป้อนเฉพาะตัวเลข"
                    Exit Sub
                End If

                Dim OT_Time = Convert.ToDouble(e.Value)
                If OT_Time < 0 Then
                    e.Valid = False
                    e.ErrorText = "จำนวนที่ป้อนไม่น้อยกว่า 0"
                    Exit Sub
                End If
                '    Call UpdateRecord_Amt(CLng(txtQudId.Text), "price", CDbl(e.Value))
                Call UpdateRecord_OT_Time("OT_Time", Date_IN_update, codeEmp_Update, e.Value)

            Case "OT_OverTime"
                If IsNumeric(e.Value) = False Then
                    e.Valid = False
                    e.ErrorText = "กรุณาป้อนเฉพาะตัวเลข"
                    Exit Sub
                End If

                Dim OT_Time = Convert.ToDouble(e.Value)
                If OT_Time < 0 Then
                    e.Valid = False
                    e.ErrorText = "จำนวนที่ป้อนไม่น้อยกว่า 0"
                    Exit Sub
                End If
                '    Call UpdateRecord_Amt(CLng(txtQudId.Text), "price", CDbl(e.Value))
                Call UpdateRecord_OT_Time("OT_OverTime", Date_IN_update, codeEmp_Update, e.Value)

            Case "OT_Time_Rate"
                If IsNumeric(e.Value) = False Then
                    e.Valid = False
                    e.ErrorText = "กรุณาป้อนเฉพาะตัวเลข"
                    Exit Sub
                End If

                Dim OT_Time = Convert.ToDouble(e.Value)
                If OT_Time < 0 Then
                    e.Valid = False
                    e.ErrorText = "จำนวนที่ป้อนไม่น้อยกว่า 0"
                    Exit Sub
                End If
                '    Call UpdateRecord_Amt(CLng(txtQudId.Text), "price", CDbl(e.Value))
                Call UpdateRecord_OT_Time("OT_Time_Rate", Date_IN_update, codeEmp_Update, e.Value)

            Case "OT_OverTime_Rate"
                If IsNumeric(e.Value) = False Then
                    e.Valid = False
                    e.ErrorText = "กรุณาป้อนเฉพาะตัวเลข"
                    Exit Sub
                End If

                Dim OT_Time = Convert.ToDouble(e.Value)
                If OT_Time < 0 Then
                    e.Valid = False
                    e.ErrorText = "จำนวนที่ป้อนไม่น้อยกว่า 0"
                    Exit Sub
                End If
                '    Call UpdateRecord_Amt(CLng(txtQudId.Text), "price", CDbl(e.Value))
                Call UpdateRecord_OT_Time("OT_OverTime_Rate", Date_IN_update, codeEmp_Update, e.Value)

            Case "OTBaht_H"
                If IsNumeric(e.Value) = False Then
                    e.Valid = False
                    e.ErrorText = "กรุณาป้อนเฉพาะตัวเลข"
                    Exit Sub
                End If

                Dim OT_Time = Convert.ToDouble(e.Value)
                If OT_Time < 0 Then
                    e.Valid = False
                    e.ErrorText = "จำนวนที่ป้อนไม่น้อยกว่า 0"
                    Exit Sub
                End If
                '    Call UpdateRecord_Amt(CLng(txtQudId.Text), "price", CDbl(e.Value))
                Call UpdateRecord_OT_Time("OTBaht_H", Date_IN_update, codeEmp_Update, e.Value)

            Case "OTH"
                If IsNumeric(e.Value) = False Then
                    e.Valid = False
                    e.ErrorText = "กรุณาป้อนเฉพาะตัวเลข"
                    Exit Sub
                End If

                Dim OT_Time = Convert.ToDouble(e.Value)
                If OT_Time < 0 Then
                    e.Valid = False
                    e.ErrorText = "จำนวนที่ป้อนไม่น้อยกว่า 0"
                    Exit Sub
                End If
                '    Call UpdateRecord_Amt(CLng(txtQudId.Text), "price", CDbl(e.Value))
                Call UpdateRecord_OT_Time("OTH", Date_IN_update, codeEmp_Update, e.Value)

            Case "OTBaht"
                If IsNumeric(e.Value) = False Then
                    e.Valid = False
                    e.ErrorText = "กรุณาป้อนเฉพาะตัวเลข"
                    Exit Sub
                End If

                Dim OT_Time = Convert.ToDouble(e.Value)
                If OT_Time < 0 Then
                    e.Valid = False
                    e.ErrorText = "จำนวนที่ป้อนไม่น้อยกว่า 0"
                    Exit Sub
                End If
                '    Call UpdateRecord_Amt(CLng(txtQudId.Text), "price", CDbl(e.Value))
                Call UpdateRecord_OT_Time("OTBaht", Date_IN_update, codeEmp_Update, e.Value)

            Case "OTPeriod"
                If IsNumeric(e.Value) = False Then
                    e.Valid = False
                    e.ErrorText = "กรุณาป้อนเฉพาะตัวเลข"
                    Exit Sub
                End If

                Dim OT_Time = Convert.ToDouble(e.Value)
                If OT_Time < 0 Then
                    e.Valid = False
                    e.ErrorText = "จำนวนที่ป้อนไม่น้อยกว่า 0"
                    Exit Sub
                End If
                '    Call UpdateRecord_Amt(CLng(txtQudId.Text), "price", CDbl(e.Value))
                Call UpdateRecord_OT_Time("OTPeriod", Date_IN_update, codeEmp_Update, e.Value)
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


        strSQL = "Update TimeOverTime  Set " & FieldName & " =" & Values_ & " Where convert(nvarchar(10),datein,111)='" & Format(date_in_update, "yyyy/MM/dd") & "' And Code='" & codeEmp & "' "


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

    Private Sub gcTimeWork_Click(sender As Object, e As EventArgs) Handles gcTimeWork.Click

    End Sub

    'Private Sub gvTimeWork_Click(sender As Object, e As EventArgs) Handles gvTimeWork.Click
    '    'Try
    '    '    Dim gv As GridView = CType(sender, GridView)

    '    '    '   If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "Code")) = True Then Exit Sub

    '    '    Date_IN_update = Format(CDate(gv.GetRowCellValue(gv.FocusedRowHandle, "DateIn")), "yyyy/MM/dd")
    '    '    codeEmp_Update = gv.GetRowCellValue(gv.FocusedRowHandle, "Code")

    '    'Catch ex As Exception
    '    '    MsgBox(ex.Message)
    '    'End Try
    'End Sub

    Private Sub gvUsername_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvTimeWork.FocusedRowChanged
        Try
            Date_IN_update = gvTimeWork.GetRowCellValue(e.FocusedRowHandle, "DateIn").ToString
            codeEmp_Update = gvTimeWork.GetRowCellValue(e.FocusedRowHandle, "Code").ToString
            '  lblTextFindProductCode.Text = GvQu.GetRowCellValue(e.FocusedRowHandle, "productCode").ToString
        Catch ex As Exception
            Date_IN_update = ""
            codeEmp_Update = ""
        End Try

    End Sub

    Private Sub gvUsername_FocusedRowLoaded(sender As Object, e As RowEventArgs) Handles gvTimeWork.FocusedRowLoaded
        Try
            Date_IN_update = gvTimeWork.GetRowCellValue(e.RowHandle, "DateIn").ToString
            codeEmp_Update = gvTimeWork.GetRowCellValue(e.RowHandle, "Code").ToString
        Catch ex As Exception
            Date_IN_update = ""
            codeEmp_Update = ""
        End Try
    End Sub

    Private Sub gvUsername_FocusedRowObjectChanged(sender As Object, e As FocusedRowObjectChangedEventArgs) Handles gvTimeWork.FocusedRowObjectChanged
        Try
            Date_IN_update = gvTimeWork.GetRowCellValue(e.RowHandle, "DateIn").ToString
            codeEmp_Update = gvTimeWork.GetRowCellValue(e.FocusedRowHandle, "Code").ToString
        Catch ex As Exception
            Date_IN_update = ""
            codeEmp_Update = ""
        End Try
    End Sub

    Private Sub btnTodate_Click(sender As Object, e As EventArgs) Handles btnTodate.Click
        txtDatesp.EditValue = txtDateSt.EditValue
    End Sub

    Private Sub gvTimeWork_DoubleClick(sender As Object, e As EventArgs) Handles gvTimeWork.DoubleClick
        'With lstOvertime
        '    If .SelectedItems.Count = 0 Then Exit Sub
        '    Dim frm As New frmEditTime

        '    ' LoadTime
        '    frm.txtDate.Text = .SelectedItems(0).SubItems(1).Text
        '    frm.txtCode.Text = .SelectedItems(0).SubItems(2).Text
        '    Call frm.txtCode_LostFocus(Me, System.EventArgs.Empty)
        '    frm.StartPosition = FormStartPosition.CenterScreen
        '    frm.ShowDialog()
        '    frm.BringToFront()
        'End With


        Try
            Dim gv As GridView = CType(sender, GridView)

            If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "Code")) = True Then Exit Sub

            'Date_IN_update = Format(CDate(gv.GetRowCellValue(gv.FocusedRowHandle, "DateIn")), "yyyy/MM/dd")
            'codeEmp_Update = gv.GetRowCellValue(gv.FocusedRowHandle, "Code")

            Dim frm As New frmEditTime

            ' LoadTime
            editRow = gv.GetRowCellValue(gv.FocusedRowHandle, "row")
            frm.txtDate.EditValue = gv.GetRowCellValue(gv.FocusedRowHandle, "DateIn")
            frm.txtCode.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Code")
            Call frm.txtCode_LostFocus(Me, System.EventArgs.Empty)
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            frm.BringToFront()

            Call loadDatadevByCode(gv.GetRowCellValue(gv.FocusedRowHandle, "Code"), Format(gv.GetRowCellValue(gv.FocusedRowHandle, "DateIn"), "yyyy/MM/dd"))

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            cExport.Export_GridView(SaveFileDialog1, gvTimeWork, cboExport)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub btnCurrentDate_Click(sender As Object, e As EventArgs) Handles btnCurrentDate.Click
        txtDatesp.EditValue = Now.Date
        txtDateSt.EditValue = Now.Date
    End Sub

    Private Sub btnAllMonth_Click(sender As Object, e As EventArgs) Handles btnAllMonth.Click
        cboMonth_SelectedIndexChanged(Me, EventArgs.Empty)
    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles txtCode1.EditValueChanged

    End Sub

    Private Sub txtCode1_LostFocus(sender As Object, e As EventArgs) Handles txtCode1.LostFocus
        txtName.Text = GetData.GetShowEmpName(txtCode1.Text.Trim)
    End Sub

    Private Sub cboDivision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDivision.SelectedIndexChanged
        Call SearchData.LoadDepartment(Me, cboDepartment, GetData.GetDivisionId(cboDivision.Text.Trim), True)
    End Sub
End Class