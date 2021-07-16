Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports Microsoft.Office.Interop
Imports TimeAttendance.utils

Public Class frmRPTTimeworkSumaryByWeek

    Dim ListOT As OT
    Dim ListvCol As vCol
    Dim ListvColType As vColType

    Enum vCol
        vCol1
        vCol2
        vCol3
        vCol4
        vCol5
    End Enum

    Enum OT
        OT1
        OT15
        OT2
        OT3
    End Enum

    Enum vColType
        vColType1
        vColType2
        vColType3
        vColType4
        vColType5
    End Enum

    Private Sub frmRPTTimeworkSumaryByWeek_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call LoadMonth()
        Call SearchData.LoadCompany(Me, cboCompany, True)
        Call SearchData.LoadDivision(Me, cboDivision, True)
        Call SearchData.LoadDepartment(Me, cboDepartment, "", True)
        Call SearchData.LoadSection(Me, cboSection, True)
        Call SearchData.LoadPosition(Me, cboPosition, True)
        '    Call SearchData.LoadEmpGroup(Me, cboEmpGroup, True)
        Call SearchData.LoadBroker(Me, cboBroker, True)
        txtYear.Text = Now.Year

    End Sub

    Private Sub LoadMonth()
        cboMonth.Items.Clear()
        For i As Integer = 1 To 12
            cboMonth.Items.Add(MonthName(Me, i))
        Next
    End Sub

    Private Sub LoadDivision()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "select DivId,Division from division Order By Division"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            cboDivision.Properties.Items.Clear()
            cboDivision.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            For Each dr As DataRow In .Rows
                cboDivision.Properties.Items.Add(dr("Division"))
            Next
        End With
    End Sub

    Private Sub LoadDepartment()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "select DeptId,Department from department Order By Department"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            cboDepartment.Properties.Items.Clear()
            cboDepartment.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            For Each dr As DataRow In .Rows
                cboDepartment.Properties.Items.Add(dr("Department"))
            Next
        End With
    End Sub

    Private Sub LoadSection()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "select SecId,Section from Section Order By Section"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            cboSection.Properties.Items.Clear()
            cboSection.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            For Each dr As DataRow In .Rows
                cboSection.Properties.Items.Add(dr("Section"))
            Next
        End With
    End Sub

    'Private Sub LoadGroupID()
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim strSQL As String
    '    strSQL = "select groupid,groupname from empgroup order by groupid"
    '    Da = New SqlDataAdapter(strSQL, Conn)
    '    Da.Fill(Ds, "data")
    '    With Ds.Tables("data")
    '        cboGroupID.Items.Clear()
    '        cboGroupID.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
    '        For Each dr As DataRow In .Rows
    '            cboGroupID.Items.Add(dr("groupname"))
    '        Next
    '    End With
    'End Sub


    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Call PrintExcel()
    End Sub

    Function GetDaydo(ByVal Code As String, ByVal DateST As String, ByVal DateSP As String) As Single
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "select daydo=isnull(dbo.fdaydo('',0,'" & Code & "','" & DateST & "','" & DateSP & "'),0)"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Return .Rows(0).Item("Daydo")
            End If
        End With
    End Function

    Function GetOT(ByVal Code As String, ByVal DateSt As String, ByVal DateSP As String, ByVal Ot As OT) As Single
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "select ot1=isnull(sum(ot1),0),ot15=isnull(sum(ot15),0),ot2=isnull(sum(ot2),0),ot3=isnull(sum(ot3),0)" & _
                     " from timeovertime" & _
                        " where code ='" & Code & "'" & _
                            " and convert(nvarchar(10),datein,111)" & _
                                " between '" & DateSt & "' and '" & DateSP & "'"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Select Case Ot
                    Case frmRPTTimeworkSumary.OT.OT1
                        Return .Rows(0).Item("ot1")
                    Case frmRPTTimeworkSumary.OT.OT15
                        Return .Rows(0).Item("ot15")
                    Case frmRPTTimeworkSumary.OT.OT2
                        Return .Rows(0).Item("ot2")
                    Case frmRPTTimeworkSumary.OT.OT3
                        Return .Rows(0).Item("ot3")
                    Case Else
                        Return (0)
                End Select
            End If
        End With
    End Function

    Function GetLateCount(ByVal Code As String, ByVal DateST As String, ByVal DateSP As String) As Single
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "select late = count(late) from timelate" & _
                        " where late > 0 and code ='" & Code & "'" & _
                            " and convert(nvarchar(10),datein,111)" & _
                                " between '" & DateST & "' and '" & DateSP & "'"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Return .Rows(0).Item("late")
            End If
        End With
    End Function

    Function GetLateMin(ByVal Code As String, ByVal DateST As String, ByVal DateSP As String) As Single
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "select late = isnull(sum(late),0) from timelate" & _
                        " where code ='" & Code & "'" & _
                            " and convert(nvarchar(10),datein,111)" & _
                                " between '" & DateST & "' and '" & DateSP & "'"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Return .Rows(0).Item("late")
            End If
        End With
    End Function

    Function GetAbs(ByVal Code As String, ByVal DateST As String, ByVal DateSP As String) As Single
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "select Absent = isnull(sum(abs(Absent)),0) from timeabsent" & _
                        " where code ='" & Code & "'" & _
                            " and convert(nvarchar(10),datein,111)" & _
                                " between '" & DateST & "' and '" & DateSP & "'"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Return .Rows(0).Item("Absent")
            End If
        End With
    End Function

    Function GetTimevacation(ByVal Code As String, ByVal DateST As String, ByVal DateSP As String, ByVal Col As Integer) As Single
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim a As ArrayList = GetValId_Type(Col)
        Dim ValId As String = a.Item(0)
        Dim Type As String = a.Item(1)

        strSQL = "select amt = isnull(sum(amt),0) from timevacation" & _
                        " where ValId = '" & ValId & "' and " & _
                                " code ='" & Code & "'" & _
                                " and convert(nvarchar(10),valdate,111)" & _
                                        " between '" & DateST & "' and '" & DateSP & "'"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                If Type = "D" Then
                    Return .Rows(0).Item("amt") / 8
                Else
                    Return .Rows(0).Item("amt")
                End If
            End If
        End With
    End Function

    Function GetValId_Type(ByVal Col As Integer) As ArrayList
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim a As New ArrayList

        strSQL = "select ValId = ValId_Col" & Col & ",vType = vCalType" & Col & "" & _
                                   " from dbo.RPT_TimeworkSumarize_Config"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                a.Clear()
                a.Add("")
                a.Add("")
            Else
                Dim dr As DataRow = .Rows(0)
                a.Clear()
                a.Add(dr("ValId"))
                a.Add(dr("vType"))
            End If
        End With
        Return a
    End Function

    Function GetDTEmp() As DataTable
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = " select e.divid, " & _
                        " division = isnull(div.division,''), " & _
                        " e.deptid, " & _
                        " department = isnull(dept.department,''), " & _
                        " e.secid, " & _
                        " section = isnull(sec.section,''), " & _
                        " e.code, " & _
                        " e.title," & _
                        " e.fname, " & _
                        " e.lname, " & _
                        " e.datein, " & _
                        " e.GroupId," & _
                        " e.Position," & _
                        " e.WageType," & _
                        " e.Contractor, " & _
                        " e.CompanyId," & _
                        " e.BrokerId" & _
                " from emp e left join division div " & _
                        " on e.divid = div.divid " & _
                     " left join department dept " & _
                        " on e.deptid = dept.deptid " & _
                     " left join section sec " & _
                        " on e.secid = sec.secid " & _
                " where WorkStatus = 'W' "

        'If cboGroupID.SelectedIndex > 0 Then
        '    strSQL &= " and GroupID = '" & GetData.GetEmpGroupId(cboGroupID.Text.Trim) & "'"
        'End If

        'If cboDivision.SelectedIndex > 0 Then
        '    strSQL &= " and e.divid = '" & GetData.GetDivisionId(cboDivision.Text.Trim) & "'"
        'End If

        'If cboDepartment.SelectedIndex > 0 Then
        '    strSQL &= " and div.divid = '" & GetData.GetDepartmentId(cboDepartment.Text.Trim) & "'"
        'End If

        'If cboSection.SelectedIndex > 0 Then
        '    strSQL &= " and sec.secid = '" & GetData.GetSectionID(cboSection.Text.Trim) & "'"
        'End If

        If cboCompany.SelectedIndex > 0 Then
            strSQL &= " and isnull(e.CompanyId,'') = '" & GetData.GetCompanyId(cboCompany.Text.Trim) & "'"
        End If

        If cboDivision.SelectedIndex > 0 Then
            strSQL &= " and Isnull(e.DivId,'') = '" & GetData.GetDivisionId(cboDivision.Text.Trim) & "'"
        End If

        If cboDepartment.SelectedIndex > 0 Then
            strSQL &= " and Isnull(e.DeptId,'') = '" & GetData.GetDepartmentId(cboDepartment.Text.Trim) & "'"
        End If

        If cboSection.SelectedIndex > 0 Then
            strSQL &= " and Isnull(e.SecId,'') = '" & GetData.GetSectionID(cboSection.Text.Trim) & "'"
        End If

        If cboPosition.SelectedIndex > 0 Then
            strSQL &= " and Isnull(e.Position,'') = '" & cboPosition.Text.Trim & "'"
        End If

        If cboEmpGroup.SelectedIndex > 0 Then
            strSQL &= " and Isnull(e.GroupId,'') = '" & GetData.GetEmpGroupId(cboEmpGroup.Text.Trim) & "'"
        End If

        If cboBroker.SelectedIndex > 0 Then
            strSQL &= " and Isnull(e.BrokerId,'') = '" & GetData.GetBrokerId(cboBroker.Text.Trim) & "'"
        End If

        If rdMonth.Checked = True Then
            strSQL &= " and e.WageType = 'M'"
        End If

        If rdDay.Checked = True Then
            strSQL &= " and e.WageType = 'D' and Contractor = 0"
        End If

        If rdContractor.Checked = True Then
            strSQL &= " and e.WageType = 'D' and Contractor = 1"
        End If

        If txtEmpId.Text.Trim <> "" Then
            strSQL &= " and e.Code Like '%" & Replace(txtEmpId.Text.Trim, " ", "") & "%'"
        End If

        If txtNameSearch.Text.Trim <> "" Then
            strSQL &= " and (e.Fname + e.LName) Like '%" & Replace(txtNameSearch.Text.Trim, " ", "") & "%'"
        End If

        strSQL &= " Order By e.Code"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        Return Ds.Tables("Data")

    End Function

    Function GetOT(ByVal datein As String, ByVal code As String) As Single

        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "select OT = isnull(sum(OT_Time + OT_Overtime),'0') " & _
                " from TimeOvertime " & _
                " where convert(nvarchar(10),Datein , 111)= '" & datein & "' " & _
                        " and code = '" & code & "' "
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("Data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Return .Rows(0).Item("OT")
            End If
        End With
    End Function

    Function GetDay(ByVal monthyear As String, ByVal week As Integer, ByVal code As String, ByVal datestart As String, ByVal datestop As String) As Single
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "select timeofdate = Isnull(dbo.fDayDo('" & monthyear & "'," & week & ",'" & code & "','" & datestart & "','" & datestop & "'),0)"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Return .Rows(0).Item("timeofdate") * 8
            End If
        End With

    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub PrintExcel()
        System.Threading.Thread.CurrentThread.CurrentCulture = _
               System.Globalization.CultureInfo.CreateSpecificCulture("en-US")

        Dim FileName As String
        With SaveFileDialog1
            .Filter = "Excel File |*.XLS"
            .ShowDialog()
            FileName = Replace(.FileName.Trim, ".xls", "")
            If FileName.Trim = "" Then
                'MsgBox("กรุณาป้อนชื่อไฟล์ด้วย", MsgBoxStyle.Information, Me.Text)
                MsgManager.ShowDialog(Me, "frmRPTTimeworkSumaryByWeekRS", Me.Text, "Insert_FineName", MessageBoxIcon.Information)
                Exit Sub
            End If
        End With

        Dim app As New Excel.Application
        Dim exbook As Excel.Workbook
        Dim exsheet As Excel.Worksheet

        exbook = app.Workbooks.Add
        exsheet = exbook.Sheets(1)

        exsheet.Range("A1", "FF10000").Font.Size = 8
        exsheet.Range("A1").ColumnWidth = 6
        exsheet.Range("B1").ColumnWidth = 8
        exsheet.Range("C1").ColumnWidth = 8
        exsheet.Range("D1", "FF1").ColumnWidth = 8


        'exsheet.Cells(1, 1).value = "รายงานชั่วโมงทำงานปกติ +ชั่วโมง O.T./ต่อสัปดาห์"
        exsheet.Cells(1, 1).value = MsgManager.ShowLabel(Me, "HTFReportForm", "OTByWeek")
        Dim yearIn As Integer = txtYear.Text.Trim
        Dim monthIn As Integer = cboMonth.SelectedIndex + 1


        Call GenHead(exsheet, DateSerial(yearIn, monthIn, 1), 3)


        Dim dtemp As DataTable = GetDTEmp()
        CExcel.ExcelSetColumnWidth(exsheet, 5, 6, 8)
        exsheet.Cells(3, 2).value = cboDivision.SelectedItem : CExcel.ExcelMeargeColumn(exsheet, 3, 2, 3, 5) : CExcel.GenCenterAlignmentCenter(exsheet, 3, 2, 3, 5)
        exsheet.Cells(4, 2).value = cboSection.SelectedItem : CExcel.ExcelMeargeColumn(exsheet, 4, 2, 4, 5) : CExcel.GenCenterAlignmentCenter(exsheet, 4, 2, 4, 5)
        exsheet.Cells(4, 1).value = MsgManager.ShowLabel(Me, "ExcelRS", "No") : CExcel.ExcelBoarder(exsheet, 4, 1, 4, 1, True)
        exsheet.Cells(5, 3).value = MsgManager.ShowLabel(Me, "ExcelRS", "Name") : CExcel.ExcelBoarder(exsheet, 5, 3, 5, 3, True)
        exsheet.Cells(5, 4).value = MsgManager.ShowLabel(Me, "ExcelRS", "LastNae") : CExcel.ExcelBoarder(exsheet, 5, 4, 5, 4, True)
        exsheet.Cells(5, 5).value = MsgManager.ShowLabel(Me, "ExcelRS", "Code") : CExcel.ExcelBoarder(exsheet, 5, 5, 5, 5, True)
        exsheet.Cells(5, 6).value = MsgManager.ShowLabel(Me, "ExcelRS", "Working") : CExcel.ExcelBoarder(exsheet, 5, 6, 5, 6, True)
        'exsheet.Cells(4, 1).value = "ลำดับ" : CExcel.ExcelBoarder(exsheet, 4, 1, 4, 1, True)
        'exsheet.Cells(5, 3).value = "ชื่อ" : CExcel.ExcelBoarder(exsheet, 5, 3, 5, 3, True)
        'exsheet.Cells(5, 4).value = "สกุล" : CExcel.ExcelBoarder(exsheet, 5, 4, 5, 4, True)
        'exsheet.Cells(5, 5).value = "รหัส" : CExcel.ExcelBoarder(exsheet, 5, 5, 5, 5, True)
        'exsheet.Cells(5, 6).value = "วันที่เข้างาน" : CExcel.ExcelBoarder(exsheet, 5, 6, 5, 6, True)

        Dim rw As Integer = 6
        Dim i As Integer = 1
        Dim tdate As String = yearIn & "/" & monthIn & "/1"
        Dim cDW As Integer = 0
        Dim sumot As Double = 0
        Dim sumallot As Double = 0
        Dim sumAmt As Double = 0
        Dim sumallAmt As Double = 0

        ProcessBar.Value = 0
        ProcessBar.Maximum = dtemp.Rows.Count

        For Each dremp As DataRow In dtemp.Rows
            ProcessBar.Value = dtemp.Rows.IndexOf(dremp) + 1

            Dim Percent As Single = ((ProcessBar.Value * 100) / ProcessBar.Maximum)
            ProcessBar.Text = ProcessBar.Value & "/" & ProcessBar.Maximum & " (" & Format(Percent, "#.00") & "%)"

            exsheet.Cells(rw, 1).value = i
            exsheet.Cells(rw, 2).value = dremp("title")
            exsheet.Cells(rw, 3).value = dremp("fname")
            exsheet.Cells(rw, 4).value = dremp("lname")
            exsheet.Cells(rw, 5).value = dremp("code")
            If IsDBNull(dremp("datein")) = True Then
                exsheet.Cells(rw, 6).value = ""
            Else
                exsheet.Cells(rw, 6).value = "'" & Format(dremp("datein"), "dd/MM/yyyy")
            End If


            CExcel.ExcelBoarder(exsheet, rw, 1, rw, 1, True)
            CExcel.ExcelBoarder(exsheet, rw, 2, rw, 2, True)
            CExcel.ExcelBoarder(exsheet, rw, 3, rw, 3, True)
            CExcel.ExcelBoarder(exsheet, rw, 4, rw, 4, True)
            CExcel.ExcelBoarder(exsheet, rw, 5, rw, 5, True)
            CExcel.ExcelBoarder(exsheet, rw, 6, rw, 6, True)

            Dim col As Integer = 7
            Dim endMonth As Integer = MonthEnd(tdate).Day
            Dim monthyear As String = monthIn & "/" & yearIn

            sumallot = 0
            sumallAmt = 0


            Dim dRun As Date
            Dim dST As Date = ConvertDate(txtDateSt.Text)
            Dim dSP As Date = ConvertDate(txtDateSp.Text)
            dRun = dST

            ProgressBarX1.Value = 0
            ProgressBarX1.Maximum = DateDiff(DateInterval.Day, dST, dSP)

            Dim k As Integer = 0
            Do Until dRun > dSP
                k += 1
                ProgressBarX1.Value = k
                ProgressBarX1.Text = k & "/" & ProgressBarX1.Maximum

                Dim datein As String = Format(DateSerial(yearIn, monthIn, k), "yyyy/MM/dd")
                cDW = dRun.DayOfWeek ' DateSerial(yearIn, monthIn, k).DayOfWeek

                Dim AmtOt As Single = GetOT(datein, dremp("code"))
                Dim Amt As Single = GetDay("", 0, dremp("code"), Format(dRun, "yyyy/MM/dd"), Format(dRun, "yyyy/MM/dd"))

                If Amt = 8 Then Amt = 9
                If Amt = 4 Then Amt = 4.5

                exsheet.Cells(rw, col).value = Amt
                exsheet.Cells(rw, col + 1).value = AmtOt

                CExcel.ExcelBoarder(exsheet, rw, col, rw, col, True)
                CExcel.ExcelBoarder(exsheet, rw, col + 1, rw, col + 1, True)

                sumot += AmtOt
                sumAmt += Amt
                sumallot += AmtOt
                sumallAmt += Amt
                If cDW = 6 Then
                    exsheet.Cells(rw, col + 2).value = sumAmt
                    exsheet.Cells(rw + 1, col + 2).value = "=sum(" & CExcel.GenColumnExcel(rw, col + 2) & ":" & CExcel.GenColumnExcel(rw - (dtemp.Rows.Count - 1), col + 2)

                    CExcel.ExcelBoarder(exsheet, rw, col + 2, rw, col + 2, True)
                    CExcel.ExcelBoarder(exsheet, rw + 1, col + 2, rw + 1, col + 2, True)

                    exsheet.Cells(rw, col + 3).value = sumot
                    exsheet.Cells(rw + 1, col + 3).value = "=sum(" & CExcel.GenColumnExcel(rw, col + 3) & ":" & CExcel.GenColumnExcel(rw - (dtemp.Rows.Count - 1), col + 3)

                    CExcel.ExcelBoarder(exsheet, rw, col + 3, rw, col + 3, True)
                    CExcel.ExcelBoarder(exsheet, rw + 1, col + 3, rw + 1, col + 3, True)

                    exsheet.Cells(rw, col + 4).value = sumAmt + sumot
                    exsheet.Cells(rw + 1, col + 4).value = "=sum(" & CExcel.GenColumnExcel(rw, col + 4) & ":" & CExcel.GenColumnExcel(rw - (dtemp.Rows.Count - 1), col + 4)

                    CExcel.ExcelBoarder(exsheet, rw, col + 4, rw, col + 4, True)
                    CExcel.ExcelBoarder(exsheet, rw + 1, col + 4, rw + 1, col + 4, True)

                    col += 3
                    sumot = 0
                    sumAmt = 0
                ElseIf dRun = dSP Then ' k = endMonth Then
                    exsheet.Cells(rw, col + 2).value = sumAmt
                    exsheet.Cells(rw + 1, col + 2).value = "=sum(" & CExcel.GenColumnExcel(rw, col + 2) & ":" & CExcel.GenColumnExcel(rw - (dtemp.Rows.Count - 1), col + 2)

                    CExcel.ExcelBoarder(exsheet, rw, col + 2, rw, col + 2, True)
                    CExcel.ExcelBoarder(exsheet, rw + 1, col + 2, rw + 1, col + 2, True)

                    exsheet.Cells(rw, col + 3).value = sumot
                    exsheet.Cells(rw + 1, col + 3).value = "=sum(" & CExcel.GenColumnExcel(rw, col + 3) & ":" & CExcel.GenColumnExcel(rw - (dtemp.Rows.Count - 1), col + 3)

                    CExcel.ExcelBoarder(exsheet, rw, col + 3, rw, col + 3, True)
                    CExcel.ExcelBoarder(exsheet, rw + 1, col + 3, rw + 1, col + 3, True)

                    exsheet.Cells(rw, col + 4).value = sumAmt + sumot
                    exsheet.Cells(rw + 1, col + 4).value = "=sum(" & CExcel.GenColumnExcel(rw, col + 4) & ":" & CExcel.GenColumnExcel(rw - (dtemp.Rows.Count - 1), col + 4)

                    CExcel.ExcelBoarder(exsheet, rw, col + 4, rw, col + 4, True)
                    CExcel.ExcelBoarder(exsheet, rw + 1, col + 4, rw + 1, col + 4, True)

                    col += 3
                    sumot = 0
                    sumAmt = 0
                End If
                col += 2
                dRun = dRun.AddDays(1)

            Loop

            exsheet.Cells(rw, col + 1).value = sumallAmt
            exsheet.Cells(rw + 1, col + 1).value = "=sum(" & CExcel.GenColumnExcel(rw, col + 1) & ":" & CExcel.GenColumnExcel(rw - (dtemp.Rows.Count - 1), col + 1)

            CExcel.ExcelBoarder(exsheet, rw, col + 1, rw, col + 1, True)
            CExcel.ExcelBoarder(exsheet, rw + 1, col + 1, rw + 1, col + 1, True)

            exsheet.Cells(rw, col + 2).value = sumallot
            exsheet.Cells(rw + 1, col + 2).value = "=sum(" & CExcel.GenColumnExcel(rw, col + 2) & ":" & CExcel.GenColumnExcel(rw - (dtemp.Rows.Count - 1), col + 2)

            CExcel.ExcelBoarder(exsheet, rw, col + 2, rw, col + 2, True)
            CExcel.ExcelBoarder(exsheet, rw + 1, col + 2, rw + 1, col + 2, True)

            exsheet.Cells(rw, col + 3).value = sumallot + sumallAmt
            exsheet.Cells(rw + 1, col + 3).value = "=sum(" & CExcel.GenColumnExcel(rw, col + 3) & ":" & CExcel.GenColumnExcel(rw - (dtemp.Rows.Count - 1), col + 3)

            CExcel.ExcelBoarder(exsheet, rw, col + 3, rw, col + 3, True)
            CExcel.ExcelBoarder(exsheet, rw + 1, col + 3, rw + 1, col + 3, True)

            rw += 1
            i += 1

        Next
        exsheet.Cells(rw, 2).value = MsgManager.ShowLabel(Me, "ExcelRS", "Total") : CExcel.ExcelMeargeColumn(exsheet, rw, 2, rw, 6) : CExcel.GenCenterAlignmentLeft(exsheet, rw, 2, rw, 6)

        CExcel.ExcelBoarder(exsheet, rw, 2, rw, 2, True)

        exbook.SaveAs(FileName.Trim)
        app.Visible = True

        exbook = Nothing
        exsheet = Nothing

    End Sub

    Private Sub GenHead(ByVal xSheet As Excel.Worksheet, ByVal dDate As Date, ByVal rw As Integer)
        ' Format(dDate, "yyyy/MM/dd")
        Dim endMonth As Integer = MonthEnd(dDate).Day
        Dim cDW As Integer = 0

        Dim Col As Integer = 7

        Dim dRun As Date
        Dim dST As Date = ConvertDate(txtDateSt.Text)
        Dim dSP As Date = ConvertDate(txtDateSp.Text)
        dRun = dST

        Dim k As Integer = 0
        Dim i As Integer = 0
        Do Until dRun > dSP
            i += 1
            CExcel.ExcelSetColumnWidth(xSheet, rw, Col, 5)
            CExcel.ExcelSetColumnWidth(xSheet, rw, Col + 1, 5)
            cDW = dRun.DayOfWeek ' DateSerial(dDate.Year, dDate.Month, i).DayOfWeek
            xSheet.Cells(rw, Col).value = GetSrtDayOfWeek(cDW)

            CExcel.ExcelMeargeColumn(xSheet, rw, Col, rw, Col + 1) : CExcel.GenCenterAlignmentCenter(xSheet, rw, Col, rw, Col)
            CExcel.ExcelMeargeColumn(xSheet, rw + 1, Col, rw + 1, Col + 1) : CExcel.GenCenterAlignmentCenter(xSheet, rw + 1, Col, rw + 1, Col)

            CExcel.ExcelBoarder(xSheet, rw, Col, rw, Col + 1, True)
            CExcel.ExcelBoarder(xSheet, rw + 1, Col, rw + 1, Col + 1, True)

            xSheet.Cells(rw + 1, Col).value = dRun.Day 'i
            xSheet.Cells(rw + 2, Col).value = MsgManager.ShowLabel(Me, "ExcelRS", "Day") : CExcel.GenCenterAlignmentCenter(xSheet, rw + 2, Col, rw + 2, Col)
            xSheet.Cells(rw + 2, Col + 1).value = MsgManager.ShowLabel(Me, "ExcelRS", "OT") : CExcel.GenCenterAlignmentCenter(xSheet, rw + 2, Col + 1, rw + 2, Col + 1)

            CExcel.ExcelBoarder(xSheet, rw + 1, Col, rw + 1, Col, True)
            CExcel.ExcelBoarder(xSheet, rw + 2, Col, rw + 2, Col, True)
            CExcel.ExcelBoarder(xSheet, rw + 3, Col + 1, rw + 3, Col + 1, True)


            If cDW = 6 Then
                xSheet.Cells(rw, Col + 2).value = MsgManager.ShowLabel(Me, "ExcelRS", "Hour") : CExcel.ExcelBoarder(xSheet, rw, Col + 2, rw, Col + 2, True)
                xSheet.Cells(rw + 1, Col + 2).value = MsgManager.ShowLabel(Me, "ExcelRS", "Work") : CExcel.ExcelBoarder(xSheet, rw + 1, Col + 2, rw + 1, Col + 2, True)
                xSheet.Cells(rw + 2, Col + 2).value = MsgManager.ShowLabel(Me, "ExcelRS", "Normal") : CExcel.ExcelBoarder(xSheet, rw + 2, Col + 2, rw + 2, Col + 2, True)
                xSheet.Cells(rw, Col + 3).value = MsgManager.ShowLabel(Me, "ExcelRS", "HourOT") : CExcel.ExcelBoarder(xSheet, rw, Col + 3, rw, Col + 3, True)
                xSheet.Cells(rw + 1, Col + 3).value = MsgManager.ShowLabel(Me, "ExcelRS", "OT") : CExcel.ExcelBoarder(xSheet, rw + 1, Col + 3, rw + 1, Col + 3, True)
                xSheet.Cells(rw, Col + 4).value = MsgManager.ShowLabel(Me, "ExcelRS", "Total") : CExcel.ExcelBoarder(xSheet, rw, Col + 4, rw, Col + 4, True)
                xSheet.Cells(rw + 1, Col + 4).value = MsgManager.ShowLabel(Me, "ExcelRS", "Hour") : CExcel.ExcelBoarder(xSheet, rw + 1, Col + 4, rw + 1, Col + 4, True)
                xSheet.Cells(rw + 2, Col + 4).value = MsgManager.ShowLabel(Me, "ExcelRS", "Work") : CExcel.ExcelBoarder(xSheet, rw + 2, Col + 4, rw + 2, Col + 4, True)


                Col += 3


            ElseIf dRun = dSP Then 'i = endMonth Then
                xSheet.Cells(rw, Col + 2).value = MsgManager.ShowLabel(Me, "ExcelRS", "Hour") : CExcel.ExcelBoarder(xSheet, rw, Col + 2, rw, Col + 2, True)
                xSheet.Cells(rw + 1, Col + 2).value = MsgManager.ShowLabel(Me, "ExcelRS", "Work") : CExcel.ExcelBoarder(xSheet, rw + 1, Col + 2, rw + 1, Col + 2, True)
                xSheet.Cells(rw + 2, Col + 2).value = MsgManager.ShowLabel(Me, "ExcelRS", "Normal") : CExcel.ExcelBoarder(xSheet, rw + 2, Col + 2, rw + 2, Col + 2, True)
                xSheet.Cells(rw, Col + 3).value = MsgManager.ShowLabel(Me, "ExcelRS", "HourOT") : CExcel.ExcelBoarder(xSheet, rw, Col + 3, rw, Col + 3, True)
                xSheet.Cells(rw + 1, Col + 3).value = MsgManager.ShowLabel(Me, "ExcelRS", "OT") : CExcel.ExcelBoarder(xSheet, rw + 1, Col + 3, rw + 1, Col + 3, True)
                xSheet.Cells(rw, Col + 4).value = MsgManager.ShowLabel(Me, "ExcelRS", "Total") : CExcel.ExcelBoarder(xSheet, rw, Col + 4, rw, Col + 4, True)
                xSheet.Cells(rw + 1, Col + 4).value = MsgManager.ShowLabel(Me, "ExcelRS", "Hour") : CExcel.ExcelBoarder(xSheet, rw + 1, Col + 4, rw + 1, Col + 4, True)
                xSheet.Cells(rw + 2, Col + 4).value = MsgManager.ShowLabel(Me, "ExcelRS", "Work") : CExcel.ExcelBoarder(xSheet, rw + 2, Col + 4, rw + 2, Col + 4, True)
                Col += 3

            End If
            Col += 2
            dRun = dRun.AddDays(1)
        Loop

        'For i As Integer = 1 To endMonth

        'Next
        xSheet.Cells(rw, Col + 1).value = MsgManager.ShowLabel(Me, "ExcelRS", "Total") : CExcel.ExcelBoarder(xSheet, rw, Col + 1, rw, Col + 1, True)
        xSheet.Cells(rw + 1, Col + 1).value = MsgManager.ShowLabel(Me, "ExcelRS", "Hour") : CExcel.ExcelBoarder(xSheet, rw + 1, Col + 1, rw + 1, Col + 1, True)
        xSheet.Cells(rw + 2, Col + 1).value = MsgManager.ShowLabel(Me, "ExcelRS", "Nwork") : CExcel.ExcelBoarder(xSheet, rw + 2, Col + 1, rw + 2, Col + 1, True)

        xSheet.Cells(rw, Col + 2).value = MsgManager.ShowLabel(Me, "ExcelRS", "Total") : CExcel.ExcelBoarder(xSheet, rw, Col + 2, rw, Col + 2, True)
        xSheet.Cells(rw + 1, Col + 2).value = MsgManager.ShowLabel(Me, "ExcelRS", "Hour") : CExcel.ExcelBoarder(xSheet, rw + 1, Col + 2, rw + 1, Col + 2, True)
        xSheet.Cells(rw + 2, Col + 2).value = MsgManager.ShowLabel(Me, "ExcelRS", "OT") : CExcel.ExcelBoarder(xSheet, rw + 2, Col + 2, rw + 2, Col + 2, True)

        xSheet.Cells(rw, Col + 3).value = MsgManager.ShowLabel(Me, "ExcelRS", "Total") : CExcel.ExcelBoarder(xSheet, rw, Col + 3, rw, Col + 3, True)
        xSheet.Cells(rw + 1, Col + 3).value = MsgManager.ShowLabel(Me, "ExcelRS", "Hour") : CExcel.ExcelBoarder(xSheet, rw + 1, Col + 3, rw + 1, Col + 3, True)
        xSheet.Cells(rw + 2, Col + 3).value = MsgManager.ShowLabel(Me, "ExcelRS", "TotalW") : CExcel.ExcelBoarder(xSheet, rw + 2, Col + 3, rw + 2, Col + 3, True)
    End Sub

    Private Sub cboCompany_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompany.SelectedIndexChanged
        Dim CompanyId As String = GetData.GetCompanyId(cboCompany.Text.Trim)

        Call SearchData.LoadDivision(Me, cboDivision, True)
        Call SearchData.LoadDepartment(Me, cboDepartment, "", True)
        Call SearchData.LoadSection(Me, cboSection, True)
        Call SearchData.LoadPosition(Me, cboPosition, True)
        '  Call SearchData.LoadEmpGroup(Me, cboEmpGroup, True)
        Call SearchData.LoadBroker(Me, cboBroker, True)
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMonth.SelectedIndexChanged
        Dim newMonth As String
        Dim newYear As String
        newMonth = Format(cboMonth.SelectedIndex + 1, "00")
        newYear = txtYear.Text.Trim
        Dim ar As New ArrayList
        ar = GetDayMonth(newMonth, newYear)
        'txtDateSt.EditValue = CDate(ar.Item(0))
        'txtDatesp.EditValue = CDate(ar.Item(1))
    End Sub

    Private Sub txtEmpId_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmpId.GotFocus
        txtNameSearch.Text = ""
    End Sub

    Private Sub txtEmpId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmpId.TextChanged

    End Sub

    Private Sub txtNameSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNameSearch.GotFocus
        txtEmpId.Text = ""
    End Sub

    Private Sub txtNameSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNameSearch.TextChanged

    End Sub
End Class