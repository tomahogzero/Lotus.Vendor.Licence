Imports System.Data
Imports System.Data.SqlClient
Imports TimeAttendance.utils

Public Class frmRptAllEmpWork_Detail2

    Private Sub frmRptAllEmpWork_Detail2_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        fReportTimeSheet = Nothing
    End Sub

    Private Sub frmRptAllEmpWork_Detail2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
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

    Private Sub frmRptAllEmpWork_Detail2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'txtDateStart.Text = Format(Date.Now, "MM/yyyy")
        'Call LoadDATA()

        Call LoadCompany()
        Call LoadDivision()
        Call LoadDepartment()
        Call LoadPosition()
        Call LoadEmpGroup()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        If IsDate(ConvertDate(txtDateStart.Text.Trim)) = False Then
            'MsgBox("กรุณาป้อนวันที่ให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmRptAllEmpWorkRS", Me.Text, "Check_Day", MessageBoxIcon.Information)
            txtDateStart.Focus()
            Exit Sub
        End If
        If IsDate(ConvertDate(txtDateStop.Text.Trim)) = False Then
            'MsgBox("กรุณาป้อนวันที่ให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmRptAllEmpWorkRS", Me.Text, "Check_Day", MessageBoxIcon.Information)
            txtDateStop.Focus()
            Exit Sub
        End If
        btnReport.Text = MsgManager.ShowLabel(Me, "rptTimeSheetRS", "Wait")
        btnReport.Enabled = False
        Call GenTimeSheet()
        btnReport.Text = MsgManager.ShowLabel(Me, "rptTimeSheetRS", "rpt")
        btnReport.Enabled = True

        'MsgBox("OK")

        'ReportPrint = Report.PrintTimeWork_Detail2
        'Dim Rpt As New frmViewReport
        'Rpt.ShowDialog()
    End Sub

    Private Sub GenTimeSheet()
        Dim dCmd As New SqlCommand

        Dim DateST As Date = ConvertDate(txtDateStart.Text.Trim)
        Dim DateSP As Date = ConvertDate(txtDateStop.Text.Trim)

        'Try
        Call ClearData(dCmd)

        Dim dRun As Date = DateST
        Dim DT As DataTable = GetDTEmp(dCmd, Format(DateST, "yyyy/MM/dd"), Format(DateSP, "yyyy/MM/dd"))

        PbOverall.Value = 0
        PbOverall.Maximum = (DateDiff(DateInterval.Day, DateST, DateSP)) + 1

        Dim I As Integer = 0
        Do Until dRun > DateSP
            'lblStatus1.Text = "วันที่ " & Format(dRun, "dd/MM/yyyy")
            PbOverall.Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "Date2") & Format(dRun, "dd/MM/yyyy")
            PbOverall.Value += 1
            Application.DoEvents()
            I = 0
            PB_Emp.Value = 0
            PB_Emp.Maximum = DT.Rows.Count
            For Each dr As DataRow In DT.Rows
                I += 1
                PB_Emp.Value = I
                'lblStatus2.Text = " พนักงาน : " & I & "/" & DT.Rows.Count
                PB_Emp.Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "emp") & I & "/" & DT.Rows.Count

                Application.DoEvents()

                If dr("Code") = "371030" Then
                    Dim a As Integer = 0
                End If

                If DateInIsExist(dCmd, Format(dRun, "yyyy/MM/dd"), dr("Code")) = False Then
                    Call InsertBlankDay(dCmd, Format(dRun, "yyyy/MM/dd"), dr("Code"))
                Else
                    Call InsertData(dCmd, Format(dRun, "yyyy/MM/dd"), dr("Code"))
                End If
            Next
            dRun = dRun.AddDays(1)
        Loop
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        '    Exit Sub
        'End Try
    End Sub

    Function GetDTEmp(ByVal dCmd As SqlCommand, ByVal DateST As String, ByVal DateSP As String) As DataTable
        Dim strSQL As String
        Dim DA As New SqlDataAdapter
        Dim Ds As New DataSet

        Dim CompanyId As String = GetData.GetCompanyId(cboCompany.Text.Trim)
        Dim DivId As String = GetData.GetDivisionId(cboDivision.Text.Trim)
        Dim DeptId As String = GetData.GetDepartmentId(cboDepartment.Text.Trim)
        Dim EmpGroupId As String = GetData.GetEmpGroupId(cboEmpGroup.Text.Trim)
        ' Dim SecId As String = GetSecId(cboSection.Text.Trim)


        strSQL = "select Code From (select Code from Emp " & _
                                    " Where WorkStatus = 'W' " & _
                                    " Group By Code" & _
                                    " Union " & _
                                    " Select Code From TimeWork" & _
                                    " Where Convert(nVarchar(10),DateIn,111) Between '" & DateST.Trim & "' and '" & DateSP.Trim & "'" & _
                                    " Group By Code) as Emp " & _
                " Where Code In (Select Code From Emp " & _
                                " Where 1=1"

        If txtCode1.Text <> "" Then ' ดูเฉพาะรหัสพนักงาน
            strSQL &= " and Code = '" & txtCode1.Text.Trim & "'"
        ElseIf txtNameSearch.Text <> "" Then  ' ดูเฉพาะชื่อที่ต้องการ
            strSQL &= " and Fname like '%" & txtNameSearch.Text.Trim & "%'"
        Else
            If cboCompany.SelectedIndex > 0 Then  ' บริษัท
                strSQL &= " and CompanyId = '" & CompanyId.Trim & "'"
            End If
            If cboDivision.SelectedIndex > 0 Then ' ฝ่าย
                strSQL &= " and DivId = '" & DivId.Trim & "'"
            End If
            If cboDepartment.SelectedIndex > 0 Then  '  แผนก
                strSQL &= " and DeptId = '" & DeptId.Trim & "'"
            End If
            If cboPosition.SelectedIndex > 0 Then  ' ตำแหน่ง
                strSQL &= " and Position = '" & cboPosition.Text.Trim & "'"
            End If
            If cboEmpGroup.SelectedIndex > 0 Then  ' กลุ่ม
                strSQL &= " and GroupId = '" & EmpGroupId.Trim & "'"
            End If
            If rdMonth.Checked = True Then  ' เฉพาะรายเดือน
                strSQL &= " and WageType = 'M' "
            End If
            If rdDay.Checked = True Then  ' เฉพาะรายวัน
                strSQL &= " and WageType = 'D' "
            End If
            If rdContractor.Checked = True Then  ' รายเหมา
                strSQL &= " and WageType = 'D' And Contractor='1' "
            End If

        End If





        strSQL &= ")"

        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()
        DA.SelectCommand = dCmd
        DA.Fill(Ds, "data")
        Return Ds.Tables("data")
    End Function

    Private Sub ClearData(ByVal dCmd As SqlCommand)
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet

        strSQL = "Delete From RPT_EmpWork2"
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()
    End Sub

    Function DateInIsExist(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String) As Boolean
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet

        strSQL = "Select Code From TimeWork " & _
                " Where Convert(nVarchar(10),DateIn,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "'"
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

    Private Sub InsertBlankDay(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String)
        Dim strSQL As String
        Dim DayOfWeek As Integer = CDate(DateIn).DayOfWeek
        Dim strDayOfWeek As String = ""

        Select Case DayOfWeek
            Case 0
                strDayOfWeek = "อา"
            Case 1
                strDayOfWeek = "จ."
            Case 2
                strDayOfWeek = "อ."
            Case 3
                strDayOfWeek = "พ."
            Case 4
                strDayOfWeek = "พฤ."
            Case 5
                strDayOfWeek = "ศ."
            Case 6
                strDayOfWeek = "ส."
            Case Else
                strDayOfWeek = ""
        End Select

        Dim KaCode As String = GetKa(Code.Trim, DateIn.Trim).Trim
        Dim Holiday As String = GetHoliday(dCmd, DateIn).Trim
        Dim Leave As String = (GetLeave(dCmd, DateIn, Code)).Trim
        Dim Normal As String = (GetNormal(dCmd, DateIn, Code)).Trim
        Dim OT As String = (GetOT(dCmd, DateIn, Code)).Trim
        Dim Cuttime As String = (GetCutTime(dCmd, DateIn, Code))
        If Holiday.Trim = "" Then
            If KaCode.Trim = "" Then   ' เช็คกรณีไม่ได้กำหนด กะการทำงาน
                'Holiday = "ไม่ได้กำหนดกะ"
                Holiday = "วันหยุด"
            Else
                Holiday = GetEmpHoliday(dCmd, Code, DateIn)
            End If

            'If GetEndofWeek(dCmd, DayOfWeek, KaCode) = False Then
            '    If KaCode = "" Then   ' เช็คกรณีไม่ได้กำหนด กะการทำงาน
            '        Holiday = "ไม่ได้กำหนดกะ"
            '    Else

            '    End If

            '    'End If

            'End If
        End If

        If Leave.Trim = "" Then
            'If GetChkVacation(dCmd, DateIn, Code) = True Then   ' ถ้าไม่มีในการกรอก การ ลา ป่วย ลากิจ ก็ให้ไปเช็คเพิ่มอีกว่าขาดงานหรือไม่
            If GetChkAbsent(dCmd, DateIn, Code) = True Then
                If Holiday = "" Then
                    Leave = "ขาดงาน"
                End If

                'End If
                'Else

            End If
        End If

        strSQL = "Insert Into RPT_EmpWork2(Code,KaCode,DateIn,DayOfWeek," & _
                        " Time1,Time2,Time3,Time4,Time5,Time6,Time7,Time8," & _
                        " Holiday,Leave,Normal,OT,CutTime)" & _
                        " Values(" & _
                        " '" & Code.Trim & "'," & _
                        " '" & KaCode.Trim & "'," & _
                        " '" & DateIn.Trim & "'," & _
                        " '" & strDayOfWeek & "'," & _
                        " Null,Null,Null,Null,Null,Null,Null,Null," & _
                        " '" & Holiday.Trim & "','" & Leave & "','" & Normal & "' , " & _
                        " '" & OT.Trim & "' ,'" & Cuttime.Trim & "' )"
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()
    End Sub

    Private Sub InsertData(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String)
        Dim strSQL As String
        Dim db As New db

        Dim strType As String = ""
        Dim Data As New ArrayList

        Dim Time As Date
        Dim DayOfWeek As Integer = CDate(DateIn).DayOfWeek
        Dim strDayOfWeek As String = ""

        Select Case DayOfWeek
            Case 0
                strDayOfWeek = "อา"
            Case 1
                strDayOfWeek = "จ."
            Case 2
                strDayOfWeek = "อ."
            Case 3
                strDayOfWeek = "พ."
            Case 4
                strDayOfWeek = "พฤ."
            Case 5
                strDayOfWeek = "ศ."
            Case 6
                strDayOfWeek = "ส."
            Case Else
                strDayOfWeek = ""
        End Select


        Data.Clear() : strType = ""
        Data.Add(Code) : strType &= "T"
        Data.Add(GetKa(Code.Trim, DateIn.Trim)) : strType &= "T"
        Data.Add(DateIn) : strType &= "T"
        Data.Add(strDayOfWeek) : strType &= "T"

        For i As Int16 = 1 To 8
            Time = GetTime(dCmd, DateIn, Code, i)
            If Time = Nothing Then
                Data.Add(DBNull.Value) : strType &= "T"
            Else
                Data.Add(Format(Time, "yyyy/MM/dd HH:mm:ss")) : strType &= "T"
            End If
        Next

        'Data.Add(GetDayDo(dCmd, DateIn, Code)) : strType &= "S"

        Data.Add(GetHoliday(dCmd, DateIn)) : strType &= "T"
        '     Data.Add(0) : strType &= "T"
        Data.Add(GetLeave(dCmd, DateIn, Code)) : strType &= "T"
        Data.Add(GetNormal(dCmd, DateIn, Code)) : strType &= "S"
        Data.Add(GetOT(dCmd, DateIn, Code)) : strType &= "S"
        Data.Add(GetLate(dCmd, DateIn, Code)) : strType &= "S"


        strSQL = "Insert Into RPT_EmpWork2(Code,KaCode,DateIn,DayOfWeek," & _
                        " Time1,Time2,Time3,Time4,Time5,Time6,Time7,Time8," & _
                        " Holiday,Leave,Normal,OT,CutTime)" & _
                        " Values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10," & _
                                " @P11,@P12,@P13,@P14,@P15,@P16,@P17)"
        db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
    End Sub

    Function GetKa(ByVal Code As String, ByVal strDate As String) As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select KaCode = Isnull(dbo.fGetKaCode_Edit('" & Code.Trim & "','" & strDate.Trim & "'),'')"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("KaCode")
            End If
        End With
    End Function

    Function GetTime(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String, ByVal No As Integer) As Date
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet

        strSQL = "Select Time" & No & " From TimeWork " & _
                " Where Convert(nVarchar(10),DateIn,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "'"
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return Nothing
            Else
                If IsDBNull(.Rows(0).Item(0)) = True Then
                    Return Nothing
                Else
                    Return .Rows(0).Item(0)
                End If
            End If
        End With
    End Function

    Function GetDayDo(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String) As Integer
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db

        strSQL = "select Absent= Isnull(Absent,0) from TimeAbsent " & _
                " Where Convert(nVarchar(10),DateIn,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "'"
        db.ExecuteCommand(Conn, dCmd, strSQL)

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                If DateInIsExist(dCmd, DateIn, Code) = True Then
                    Return 8
                Else
                    Return 0
                End If
            Else
                If IsDBNull(.Rows(0).Item(0)) = True Then
                    If DateInIsExist(dCmd, DateIn, Code) = True Then
                        Return 8
                    Else
                        Return 0
                    End If
                Else
                    Return 8 - Math.Abs(.Rows(0).Item(0))
                End If
            End If
        End With
    End Function

    Function GetOT(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String, ByVal OT As Integer) As Single
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db

        strSQL = "select OT1 = isnull(OT1,0)," & _
                        " OT15 = isnull(OT15,0)," & _
                        " OT2 = isnull(OT2,0)," & _
                        " OT3 = isnull(OT3,0) " & _
                " from TimeOvertime " & _
                " Where Convert(nVarchar(10),DateIn,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "'"
        db.ExecuteCommand(Conn, dCmd, strSQL)

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Select Case OT
                    Case 1
                        Return .Rows(0).Item("OT1")
                    Case 15
                        Return .Rows(0).Item("OT15")
                    Case 2
                        Return .Rows(0).Item("OT2")
                    Case 3
                        Return .Rows(0).Item("OT3")
                    Case Else
                        Return 0
                End Select
            End If
        End With
    End Function

    Function GetVacation(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String, ByVal Pay As Boolean) As Single
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db

        strSQL = "select Amt = Isnull(Amt,0) from TimeVacation " & _
                " Where Convert(nVarchar(10),ValDate,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "'"
        db.ExecuteCommand(Conn, dCmd, strSQL)

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                If Pay = False Then
                    Return .Rows(0).Item("Amt")
                Else
                    Return .Rows(0).Item("Amt")
                End If
            End If
        End With
    End Function

    Function GetAbsent(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String) As Single
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db

        strSQL = "select Absent from TimeAbsent " & _
                " Where Abs(Absent) = 8 and Convert(nVarchar(10),DateIn,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "'"
        db.ExecuteCommand(Conn, dCmd, strSQL)

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Return 1
            End If
        End With
    End Function

    Function GetLate(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String) As Single
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db

        strSQL = "select Late = Isnull(Late,0) from TimeLate " & _
                " Where Convert(nVarchar(10),DateIn,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "'"
        db.ExecuteCommand(Conn, dCmd, strSQL)

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Return .Rows(0).Item("Late")
            End If
        End With
    End Function

    Function GetTimeWork(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String) As String
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db

        'strSQL = "select DayDoHour = isnull(dbo.fGetDayDo_Hour(Code,Convert(nVarchar(10),DateIn,111)) from TimeWork " & _
        '        " Where Convert(nVarchar(10),DateIn,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "'"

        strSQL = "Exec spGetDayDo_Hour '" & Code.Trim & "','" & DateIn.Trim & "'"
        db.ExecuteCommand(Conn, dCmd, strSQL)
        Da.SelectCommand = dCmd

        Da.Fill(Ds, "data")
        With Ds.Tables("data")

            Dim Time As Single = 0
            Dim T As Single = 0
            If .Rows.Count = 0 Then
                Return "0"
            Else
                Dim dr As DataRow = .Rows(0)
                Return dr("DayDo")
            End If
        End With
    End Function

    Function GetCardForget(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String) As Integer
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet

        strSQL = "Select Code From TimeWork " & _
                " Where Convert(nVarchar(10),DateIn,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "' and " & _
                        " (TimeE1 = 0 and " & _
                        " TimeE2 = 0 and " & _
                        " TimeE3 = 0 and " & _
                        " TimeE4 = 0 and " & _
                        " TimeE5 = 0 and " & _
                        " TimeE6 = 0 and " & _
                        " TimeE7 = 0 and " & _
                        " TimeE8 = 0 and " & _
                        " TimeE9 = 0 and " & _
                        " TimeE10 = 0 and " & _
                        " TimeE11 = 0 and " & _
                        " TimeE12 = 0) "
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 1
            Else
                Return 0
            End If
        End With
    End Function

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub cboDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Private Sub LoadDivision()
    '    Dim strSQL As String
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim db As New db
    '    Dim dCmd As New SqlCommand

    '    strSQL = "Select * From Division Order By DivId"
    '    db.ExecuteCommand(Conn, dCmd, strSQL)

    '    Da.SelectCommand = dCmd
    '    Da.Fill(Ds, "data")
    '    With Ds.Tables("data")
    '        cboDivision.Items.Clear()
    '        cboDivision.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
    '        For Each dr As DataRow In .Rows
    '            cboDivision.Items.Add(dr("Division"))
    '        Next
    '    End With
    'End Sub

    Function GetDivId(ByVal Division As String) As String
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db
        Dim dCmd As New SqlCommand

        strSQL = "Select DivId From Division " & _
                " Where Division = '" & Division.Trim & "'"
        db.ExecuteCommand(Conn, dCmd, strSQL)

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("DivId")
            End If
        End With
    End Function


    'Private Sub LoadDepartment()
    '    Dim strSQL As String
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim db As New db
    '    Dim dCmd As New SqlCommand

    '    strSQL = "Select * From Department Order By DeptId"
    '    db.ExecuteCommand(Conn, dCmd, strSQL)

    '    Da.SelectCommand = dCmd
    '    Da.Fill(Ds, "data")
    '    With Ds.Tables("data")
    '        cboDepartment.Items.Clear()
    '        cboDepartment.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
    '        For Each dr As DataRow In .Rows
    '            cboDepartment.Items.Add(dr("Department"))
    '        Next
    '    End With
    'End Sub

    Function GetDeptId(ByVal Department As String) As String
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db
        Dim dCmd As New SqlCommand

        strSQL = "Select DeptId From Department " & _
                " Where Department = '" & Department.Trim & "'"
        db.ExecuteCommand(Conn, dCmd, strSQL)

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("DeptId")
            End If
        End With
    End Function

    'Private Sub LoadSection()
    '    Dim strSQL As String
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim db As New db
    '    Dim dCmd As New SqlCommand

    '    strSQL = "Select * From Section Order By SecId"
    '    db.ExecuteCommand(Conn, dCmd, strSQL)

    '    Da.SelectCommand = dCmd
    '    Da.Fill(Ds, "data")
    '    With Ds.Tables("data")
    '        cboSection.Items.Clear()
    '        cboSection.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
    '        For Each dr As DataRow In .Rows
    '            cboSection.Items.Add(dr("Section"))
    '        Next
    '    End With
    'End Sub

    Function GetSecId(ByVal Section As String) As String
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db
        Dim dCmd As New SqlCommand

        strSQL = "Select SecId From Section " & _
                " Where Section = '" & Section.Trim & "'"
        db.ExecuteCommand(Conn, dCmd, strSQL)

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("SecId")
            End If
        End With
    End Function

    Private Sub txtDateStop_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtDateStop.MaskInputRejected

    End Sub

    Function GetHoliday(ByVal dCmd As SqlCommand, ByVal DateIn As String) As String
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet

        strSQL = "select Description from TimeHolidayYear " & _
                  " Where Convert(nVarchar(10),Date,111) = '" & DateIn.Trim & "' "
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                If IsDBNull(.Rows(0).Item(0)) = True Then
                    Return ""
                Else
                    Return .Rows(0).Item(0)
                End If
            End If
        End With
    End Function

    Function GetEmpHoliday(ByVal dCmd As SqlCommand, ByVal Code As String, ByVal DateIn As String) As String
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet

        strSQL = "select Hol = dbo.fIsHolidayByEmp('" & DateIn.Trim & "','" & Code.Trim & "') "

        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                If IsDBNull(.Rows(0).Item(0)) = True Then
                    Return "วันหยุด"
                Else
                    Return ""
                End If
            End If
        End With
    End Function


    Function GetLeave(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String) As String
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet

        'strSQL = "select ts.Description" & _
        '         " from TimeVacation Tv Inner Join TimeWorkingStatus Ts " & _
        '         " On Tv.ValId=ts.Code " & _
        '         " Where Convert(nVarchar(10),tv.valdate,111) = '" & DateIn.Trim & "' And tv.Code='" & Code.Trim & "' "

        strSQL = "select ts.Description" & _
                 " from TimeVacation Tv Inner Join TimeWorkingStatus Ts " & _
           " On Tv.ValId=ts.Code " & _
                 " Where CONVERT(nvarchar(10),tv.ValDate,111)='" & DateIn.Trim & "' " & _
              " and tv.Code='" & Code.Trim & "' "

        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                If IsDBNull(.Rows(0).Item(0)) = True Then
                    Return ""
                Else
                    Return .Rows(0).Item(0)
                End If
            End If
        End With
    End Function

    Function GetNormal(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String) As String
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db

        'strSQL = "select DayDoHour = isnull(dbo.fGetDayDo_Hour(Code,Convert(nVarchar(10),DateIn,111)) from TimeWork " & _
        '        " Where Convert(nVarchar(10),DateIn,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "'"

        strSQL = "Exec spGetDayDo_Min '" & Code.Trim & "','" & DateIn.Trim & "'"
        db.ExecuteCommand(Conn, dCmd, strSQL)
        Da.SelectCommand = dCmd

        Da.Fill(Ds, "data")
        With Ds.Tables("data")

            Dim Time As Single = 0
            Dim T As Single = 0
            If .Rows.Count = 0 Then
                Return "0"
            Else
                Dim dr As DataRow = .Rows(0)
                Return Math.Round(dr("DayDo") / 60, 2)
            End If
        End With
    End Function

    Function GetOT(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String) As String
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db

        'strSQL = "select DayDoHour = isnull(dbo.fGetDayDo_Hour(Code,Convert(nVarchar(10),DateIn,111)) from TimeWork " & _
        '        " Where Convert(nVarchar(10),DateIn,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "'"

        'strSQL = "select OT=(OT1+OT2+OT15+OT3) *60" & _
        '         " from  TimeOvertime " & _
        '         " where Code ='" & Code.Trim & "' and CONVERT(nvarchar(10),DateIn,111)='" & DateIn.Trim & "'"

        strSQL = "select OT=((Case " & _
                             " When OT_Time_Rate > 0 Then OT_Time " & _
                             " Else 0 End) + " & _
                            " OT_OverTime) " & _
         " from  TimeOvertime " & _
         " where Code ='" & Code.Trim & "' and CONVERT(nvarchar(10),DateIn,111)='" & DateIn.Trim & "'"

        db.ExecuteCommand(Conn, dCmd, strSQL)
        Da.SelectCommand = dCmd

        Da.Fill(Ds, "data")
        With Ds.Tables("data")

            Dim Time As Single = 0
            Dim T As Single = 0
            If .Rows.Count = 0 Then
                Return "0"
            Else
                Dim dr As DataRow = .Rows(0)
                '   Return dr("OT")
                Return .Rows(0).Item(0)
            End If
        End With
    End Function

    Function GetCutTime(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String) As Single
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db

        strSQL = "select Late " & _
                 " from RPT_EmpWork " & _
                 " Where CONVERT(nvarchar(10),DateIn,111)='" & DateIn.Trim & "' " & _
                 " And Code='" & Code.Trim & "'"
        db.ExecuteCommand(Conn, dCmd, strSQL)

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return "0"
            Else
                Return .Rows(0).Item("Late")
            End If
        End With
    End Function

    'Function GetLate(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String) As Single
    '    Dim strSQL As String
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim db As New db

    '    strSQL = "select Late = Isnull(Late,0) from TimeLate " & _
    '            " Where Convert(nVarchar(10),DateIn,111) = '" & DateIn.Trim & "' and Code = '" & Code.Trim & "'"
    '    db.ExecuteCommand(Conn, dCmd, strSQL)

    '    Da.SelectCommand = dCmd
    '    Da.Fill(Ds, "data")
    '    With Ds.Tables("data")
    '        If .Rows.Count = 0 Then
    '            Return 0
    '        Else
    '            Return .Rows(0).Item("Late")
    '        End If
    '    End With
    'End Function

    Function GetEndofWeek(ByVal dCmd As SqlCommand, ByVal DayofWeek As String, ByVal KaCode As String) As Boolean
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = "Select Day = "

        Select Case DayofWeek.Trim
            Case "0"
                strSQL &= "Sunday"
            Case "1"
                strSQL &= "Monday"
            Case "2"
                strSQL &= "Tuesday"
            Case "3"
                strSQL &= "Wednesday"
            Case "4"
                strSQL &= "Thursday"
            Case "5"
                strSQL &= "Friday"
            Case "6"
                strSQL &= "Saturday"
            Case Else
                Return False
        End Select
        strSQL &= " from timeka " & _
                  " Where ka_code='" & KaCode.Trim & "'"
        dCmd.Connection = Conn
        dCmd.CommandText = strSQL
        dCmd.ExecuteNonQuery()
        Da.SelectCommand = dCmd

        Da.Fill(Ds, "DATA")
        With Ds.Tables("DATA")
            If .Rows.Count = 0 Then
                Return False
            Else
                Dim dr As DataRow = .Rows(0)
                If dr("day") = True Then
                    Return True
                Else
                    Return False
                End If
            End If
        End With
    End Function

    Function GetChkVacation(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String) As Boolean
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db

        strSQL = "select code " & _
                 " from TimeVacation " & _
                 " Where CONVERT(nvarchar(10),ValDate,111)='" & DateIn.Trim & "' " & _
                 " And Code='" & Code.Trim & "'"
        db.ExecuteCommand(Conn, dCmd, strSQL)

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return True    ' ถ้าไม่มีก็เอาไปเช็คอีกทีว่าขาดงานหรือไม่
            Else
                Return False  ' ออกไปเลย ปกติ
            End If
        End With
    End Function

    Function GetChkAbsent(ByVal dCmd As SqlCommand, ByVal DateIn As String, ByVal Code As String) As Boolean
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim db As New db

        strSQL = "select code " & _
                 " from TimeAbSent " & _
                 " Where CONVERT(nvarchar(10),DateIn,111)='" & DateIn.Trim & "' " & _
                 " And Code='" & Code.Trim & "'"
        db.ExecuteCommand(Conn, dCmd, strSQL)

        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return False    'ขาด
            Else
                Return True  ' ปกติ
            End If
        End With
    End Function


    Private Sub LoadDepartment()

        '--------------------------------------------
        Dim DA As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = "select DeptId,Department " & _
            " from department "

        If cboCompany.SelectedIndex > 0 Then
            Strsql &= " Where DeptId In (Select DeptId From Emp " & _
                                    " Where WorkStatus  = 'W' and " & _
                                            " CompanyId = '" & GetData.GetCompanyId(cboCompany.Text) & "')"
        End If

        Strsql = Strsql & " Order By Department"

        DA = New SqlDataAdapter(Strsql, Conn)
        DA.Fill(Ds, "data")

        cboDepartment.Items.Clear()
        cboDepartment.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
        With Ds.Tables("data")
            For Each Dr As DataRow In .Rows
                cboDepartment.Items.Add(Dr("Department"))
            Next
            cboDepartment.SelectedIndex = 0
        End With
    End Sub

    Private Sub LoadDivision()

        Dim DA As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = "select DivId,Division" & _
            " from DiviSion "

        If cboCompany.SelectedIndex > 0 Then
            Strsql &= " Where DivId In (Select DivId From Emp " & _
                                    " Where WorkStatus  = 'W' and " & _
                                            " CompanyId = '" & GetData.GetCompanyId(cboCompany.Text) & "')"
        End If

        Strsql = Strsql & " Order By Division"

        DA = New SqlDataAdapter(Strsql, Conn)
        DA.Fill(Ds, "data")

        cboDivision.Items.Clear()
        cboDivision.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
        With Ds.Tables("data")
            For Each Dr As DataRow In .Rows
                cboDivision.Items.Add(Dr("Division"))
            Next
            cboDivision.SelectedIndex = 0
        End With
    End Sub


    Private Sub LoadPosition()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select Position " & _
                " From Emp " & _
                " Group By Position " & _
                " Order By Position"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            cboPosition.Items.Clear()
            cboPosition.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))

            For Each dr As DataRow In .Rows
                cboPosition.Items.Add(dr("Position"))
            Next
            cboPosition.SelectedIndex = 0
        End With
    End Sub

    Private Sub LoadEmpGroup()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select GroupName " & _
                " From EmpGroup " & _
                " Order By GroupName"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            cboEmpGroup.Items.Clear()
            cboEmpGroup.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))

            For Each dr As DataRow In .Rows
                cboEmpGroup.Items.Add(dr("GroupName"))
            Next
            cboEmpGroup.SelectedIndex = 0
        End With
    End Sub

    Private Sub LoadCompany()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select CompanyName From Company_Sub "
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            cboCompany.Items.Clear()
            cboCompany.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))

            Dim I As Integer
            For I = 0 To .Rows.Count - 1
                cboCompany.Items.Add(.Rows(I).Item("CompanyName"))
            Next
            Ds.Clear()
            cboCompany.SelectedIndex = 0
        End With
    End Sub

    Private Sub cboCompany_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompany.SelectedIndexChanged
        Call LoadDepartment()
        Call LoadDivision()
    End Sub

    Private Sub txtCode1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode1.TextChanged

    End Sub

    Private Sub txtCode1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode1.GotFocus
        txtNameSearch.Text = ""
    End Sub

    Private Sub txtNameSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNameSearch.GotFocus
        txtCode1.Text = ""
    End Sub

    Private Sub txtNameSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNameSearch.TextChanged

    End Sub
End Class










