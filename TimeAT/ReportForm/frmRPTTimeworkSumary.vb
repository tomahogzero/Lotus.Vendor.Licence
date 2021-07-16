Imports System.Data.SqlClient
Imports System.Data
Imports TimeAttendance.utils

Public Class frmRPTTimeworkSumary

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

    Private Sub frmRPTTimeworkSumary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call SearchData.LoadCompany(Me, cboCompany, True)
        Call SearchData.LoadDivision(Me, cboDivision, True)
        Call SearchData.LoadDepartment(Me, cboDepartment, "", True)
        Call SearchData.LoadSection(Me, cboSection, True)
        Call SearchData.LoadPosition(Me, cboPosition, True)
        '    Call SearchData.LoadEmpGroup(Me, cboEmpGroup, True)
        Call SearchData.LoadBroker(Me, cboBroker, True)

    End Sub

    'Private Sub LoadDivision()
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim strSQL As String

    '    strSQL = "select DivId,Division from division Order By Division"
    '    Da = New SqlDataAdapter(strSQL, Conn)
    '    Da.Fill(Ds, "data")

    '    With Ds.Tables("data")
    '        cboDivision.Items.Clear()
    '        cboDivision.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
    '        For Each dr As DataRow In .Rows
    '            cboDivision.Items.Add(dr("Division"))
    '        Next
    '    End With
    'End Sub

    'Private Sub LoadDepartment()
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim strSQL As String

    '    strSQL = "select DeptId,Department from department Order By Department"
    '    Da = New SqlDataAdapter(strSQL, Conn)
    '    Da.Fill(Ds, "data")

    '    With Ds.Tables("data")
    '        cboDepartment.Items.Clear()
    '        cboDepartment.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
    '        For Each dr As DataRow In .Rows
    '            cboDepartment.Items.Add(dr("Department"))
    '        Next
    '    End With
    'End Sub

    'Private Sub LoadSection()
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim strSQL As String

    '    strSQL = "select SecId,Section from Section Order By Section"
    '    Da = New SqlDataAdapter(strSQL, Conn)
    '    Da.Fill(Ds, "data")

    '    With Ds.Tables("data")
    '        cboSection.Items.Clear()
    '        cboSection.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
    '        For Each dr As DataRow In .Rows
    '            cboSection.Items.Add(dr("Section"))
    '        Next
    '    End With
    'End Sub

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

    'Private Sub txtCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    StrSql = "Select Code,EmpName = isnull(Title,'') + isnull(Fname,'') + '   ' + isnull(Lname,'') " & _
    '            " From Emp " & _
    '            " Where Code = '" & txtCode.Text.Trim & "'"
    '    Da = New SqlDataAdapter(StrSql, Conn)
    '    Da.Fill(Ds, "data")
    '    With Ds.Tables("Data")
    '        If .Rows.Count = 0 Then
    '            lblEmpName.Text = ""
    '        Else
    '            lblEmpName.Text = .Rows(0).Item("EmpName")
    '        End If
    '    End With
    'End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Call GenData()

        ReportPrint = Report.PrintTimeworkSumary
        'Dim rpt As New frmViewReport
        'rpt.Show()

    End Sub

    Private Sub GenData()
        If txtDateStart.Value = Nothing Then
            'MsgBox("��س����͡��ǧ�ѹ������", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmRPTTimeworkSumaryRS", Me.Text, "Select_Date", MessageBoxIcon.Information)
            txtDateStart.Focus()
            Exit Sub
        End If

        If txtDateStop.Value = Nothing Then
            'MsgBox("��سһ�͹��ǧ�ѹ������", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmRPTTimeworkSumaryRS", Me.Text, "Insert_Date", MessageBoxIcon.Information)
            txtDateStop.Focus()
            Exit Sub
        End If

        Dim DTEmp As DataTable = GetDTEmp()

        Dim DateST As String = Format(txtDateStart.Value, "yyyy/MM/dd")
        Dim DateSP As String = Format(txtDateStop.Value, "yyyy/MM/dd")
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList
        Dim db As New db

        Try

            strSQL = " delete from Rpt_TimeWorkSumarize "
            db.ExecuteCommand(Conn, dCmd, strSQL)

            ProgressBar1.Value = 0
            ProgressBar1.Maximum = DTEmp.Rows.Count
            Dim i As Integer = 0
            ProgressBar1.Text = i & "/" & ProgressBar1.Maximum

            Dim OT1 As Single = 0
            Dim OT15 As Single = 0
            Dim OT2 As Single = 0
            Dim OT3 As Single = 0

            For Each dr As DataRow In DTEmp.Rows
                i += 1
                ProgressBar1.Text = i & "/" & ProgressBar1.Maximum
                ProgressBar1.Value = i

                OT1 = GetOT_OverTime(dr("Code"), DateST, DateSP, 1) + _
                        GetOT_Time(dr("Code"), DateST, DateSP, 1)

                OT15 = GetOT_OverTime(dr("Code"), DateST, DateSP, 1.5) + _
              GetOT_Time(dr("Code"), DateST, DateSP, 1.5)

                OT2 = GetOT_OverTime(dr("Code"), DateST, DateSP, 2) + _
              GetOT_Time(dr("Code"), DateST, DateSP, 2)

                OT3 = GetOT_OverTime(dr("Code"), DateST, DateSP, 3) + _
              GetOT_Time(dr("Code"), DateST, DateSP, 3)

                Data.Clear() : strType = ""
                Data.Add(dr("Code")) : strType &= "T"
                Data.Add(GetDaydo(dr("Code"), DateST, DateSP)) : strType &= "S"
                Data.Add(OT1) : strType &= "S"
                Data.Add(OT15) : strType &= "S"
                Data.Add(OT2) : strType &= "S"
                Data.Add(OT3) : strType &= "S"
                Data.Add(GetLateCount(dr("Code"), DateST, DateSP)) : strType &= "S"
                Data.Add(GetLateMin(dr("Code"), DateST, DateSP)) : strType &= "S"
                Data.Add(GetTimevacation(dr("Code"), DateST, DateSP, 1)) : strType &= "S"
                Data.Add(GetTimevacation(dr("Code"), DateST, DateSP, 2)) : strType &= "S"
                Data.Add(GetTimevacation(dr("Code"), DateST, DateSP, 3)) : strType &= "S"
                Data.Add(GetTimevacation(dr("Code"), DateST, DateSP, 4)) : strType &= "S"
                Data.Add(GetTimevacation(dr("Code"), DateST, DateSP, 5)) : strType &= "S"
                Data.Add(GetTimevacation(dr("Code"), DateST, DateSP, 6)) : strType &= "S"
                Data.Add(GetTimevacation(dr("Code"), DateST, DateSP, 7)) : strType &= "S"
                Data.Add(GetTimevacation(dr("Code"), DateST, DateSP, 8)) : strType &= "S"
                Data.Add(GetAbs(dr("Code"), DateST, DateSP)) : strType &= "S"

                strSQL = "Insert Into Rpt_TimeWorkSumarize(Code,DayDo,OT1,OT15,OT2,OT3,Late_Count,Late_Min,vCol1,vCol2,vCol3,vCol4,vCol5,vCol6,vCol7,vCol8,Absent)" & _
                        " Values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12,@P13,@P14,@P15,@P16,@P17)"

                db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)

            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try
    End Sub

    Function GetDTEmp() As DataTable
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "Select Code " & _
                " From Emp " & _
                " Where WorkStatus = 'W' "

        If cboCompany.SelectedIndex > 0 Then
            strSQL &= " and isnull(Emp.CompanyId,'') = '" & GetData.GetCompanyId(cboCompany.Text.Trim) & "'"
        End If

        If cboDivision.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Department.DivId,'') = '" & GetData.GetDivisionId(cboDivision.Text.Trim) & "'"
        End If

        If cboDepartment.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Emp.DeptId,'') = '" & GetData.GetDepartmentId(cboDepartment.Text.Trim) & "'"
        End If

        If cboSection.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Emp.SecId,'') = '" & GetData.GetSectionID(cboSection.Text.Trim) & "'"
        End If

        If cboPosition.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Emp.Position,'') = '" & cboPosition.Text.Trim & "'"
        End If

        If cboEmpGroup.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Emp.GroupId,'') = '" & GetData.GetEmpGroupId(cboEmpGroup.Text.Trim) & "'"
        End If

        If cboBroker.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Emp.BrokerId,'') = '" & GetData.GetBrokerId(cboBroker.Text.Trim) & "'"
        End If

        If rdMonth.Checked = True Then
            strSQL &= " and Emp.WageType = 'M'"
        End If

        If rdDay.Checked = True Then
            strSQL &= " and Emp.WageType = 'D' and Contractor = 0"
        End If

        If rdContractor.Checked = True Then
            strSQL &= " and Emp.WageType = 'D' and Contractor = 1"
        End If

        If txtEmpId.Text.Trim <> "" Then
            strSQL &= " and Emp.Code Like '%" & Replace(txtEmpId.Text.Trim, " ", "") & "%'"
        End If

        If txtNameSearch.Text.Trim <> "" Then
            strSQL &= " and (Fname + LName) Like '%" & Replace(txtNameSearch.Text.Trim, " ", "") & "%'"
        End If

        strSQL &= " Order By Emp.Code"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        Return Ds.Tables("Data")

    End Function

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

    Function GetOT_OverTime(ByVal Code As String, ByVal DateSt As String, ByVal DateSP As String, ByVal Ot_Rate As Single) As Single
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "select OT = isnull(SUM(Ot.OT_OverTime),0)" & _
                " from timeovertime OT " & _
                " where ot.Code = '" & Code.Trim & "' and " & _
                        " Convert(nvarchar(10), datein, 111) " & _
                            " between '" & DateSt & "' and '" & DateSP & "' " & _
                            " and (ot.OT_OverTime_Rate = " & Ot_Rate & ")"

        'strSQL = "select ot1=isnull(sum(ot1),0),ot15=isnull(sum(ot15),0),ot2=isnull(sum(ot2),0),ot3=isnull(sum(ot3),0)" & _
        '             " from timeovertime" & _
        '                " where code ='" & Code & "'" & _
        '                    " and convert(nvarchar(10),datein,111)" & _
        '                        " between '" & DateSt & "' and '" & DateSP & "'"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Return .Rows(0).Item("OT")
            End If
        End With
    End Function

    Function GetOT_Time(ByVal Code As String, ByVal DateSt As String, ByVal DateSP As String, ByVal Ot_Rate As Single) As Single
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "select OT = isnull(SUM(Ot.OT_Time),0)" & _
                " from timeovertime OT " & _
                " where ot.Code = '" & Code.Trim & "' and " & _
                        " Convert(nvarchar(10), datein, 111) " & _
                            " between '" & DateSt & "' and '" & DateSP & "' " & _
                            " and (ot.OT_Time_Rate = " & Ot_Rate & ")"

        'strSQL = "select ot1=isnull(sum(ot1),0),ot15=isnull(sum(ot15),0),ot2=isnull(sum(ot2),0),ot3=isnull(sum(ot3),0)" & _
        '             " from timeovertime" & _
        '                " where code ='" & Code & "'" & _
        '                    " and convert(nvarchar(10),datein,111)" & _
        '                        " between '" & DateSt & "' and '" & DateSP & "'"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Return .Rows(0).Item("OT")
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

        Dim Type As String = GetAbs_Type()

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
                If Type = "D" Then
                    Return .Rows(0).Item("Absent") / 8
                Else
                    Return .Rows(0).Item("Absent")
                End If

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

    Function GetAbs_Type() As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim a As New ArrayList

        strSQL = "select absCalType from dbo.RPT_TimeworkSumarize_Config"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return "D"
            Else
                Dim dr As DataRow = .Rows(0)
                Return dr("absCalType")
            End If
        End With
    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cboCompany_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompany.SelectedIndexChanged
        Dim CompanyId As String = GetData.GetCompanyId(cboCompany.Text.Trim)

        Call SearchData.LoadDivision(Me, cboDivision, True)
        Call SearchData.LoadDepartment(Me, cboDepartment, "", True)
        Call SearchData.LoadSection(Me, cboSection, True)
        Call SearchData.LoadPosition(Me, cboPosition, True)
        '   Call SearchData.LoadEmpGroup(Me, cboEmpGroup, True)
        Call SearchData.LoadBroker(Me, cboBroker, True)
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