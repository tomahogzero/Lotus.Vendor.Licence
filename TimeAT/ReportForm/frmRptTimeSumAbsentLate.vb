Imports System.Data
Imports System.Data.SqlClient
Imports TimeAttendance.utils

Public Class frmRptTimeSumAbsentLate
    Private Sub frmRptTimeSumAbsentLate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadMonth()
        txtYear.Text = Date.Now.Year
        cboMonth.SelectedIndex = Date.Now.Month - 1

        'Call LoadDepartment()
        'cboDepartment.Enabled = False

        Call LoadCompany()
        Call LoadDivision()
        Call LoadDepartment()
        Call LoadPosition()
        Call LoadEmpGroup()
    End Sub

    Private Sub LoadMonth()
        Dim I As Integer
        cboMonth.Items.Clear()
        For I = 1 To 12
            cboMonth.Items.Add(MonthNameThai(I))
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
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        ReportPrint = Report.PrintSumAbsLateByMonth
        'Dim Rpt As New frmViewReport
        'Rpt.ShowDialog()
    End Sub

    'Private Sub LoadDepartment()
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim strSQL As String
    '    strSQL = "Select Department From Department" & _
    '            " Order By Department"
    '    Da = New SqlDataAdapter(strSQL, Conn)
    '    Da.Fill(Ds, "Data")
    '    With Ds.Tables("Data")
    '        cboDepartment.Items.Clear()
    '        cboDepartment.Items.Add("")
    '        Dim I As Integer
    '        For I = 0 To .Rows.Count - 1
    '            cboDepartment.Items.Add(.Rows(I).Item("Department"))
    '        Next
    '        Ds.Clear()
    '    End With
    'End Sub

    'Private Sub cboDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim strSQL As String
    '    strSQL = "Select DeptId From Department" & _
    '            " Where Department = '" & cboDepartment.Text.Trim & "' " & _
    '            " Order By Department"
    '    Da = New SqlDataAdapter(strSQL, Conn)
    '    Da.Fill(Ds, "Data")
    '    With Ds.Tables("Data")
    '        lblDeptId.Text = ""
    '        Dim I As Integer
    '        For I = 0 To .Rows.Count - 1
    '            lblDeptId.Text = .Rows(I).Item("DeptId")
    '        Next
    '        Ds.Clear()
    '    End With
    'End Sub

    Private Sub rdByDept_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cboDepartment.Enabled = True
    End Sub

    Private Sub rdAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cboDepartment.Enabled = False
    End Sub


    Private Sub LoadDepartment()

        '--------------------------------------------
        Dim DA As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        strSQL = "select DeptId,Department " & _
            " from department "

        If cboCompany.SelectedIndex > 0 Then
            Strsql &= " Where DeptId In (Select DeptId From Emp " & _
                                    " Where WorkStatus  = 'W' and " & _
                                            " CompanyId = '" & GetData.GetCompanyId(cboCompany.Text) & "')"
        End If

        strSQL = strSQL & " Order By Department"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

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

    Private Sub txtCode1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode1.GotFocus
        txtNameSearch.Text = ""
    End Sub

    Private Sub txtNameSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNameSearch.GotFocus
        txtCode1.Text = ""
    End Sub

    Private Sub txtNameSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNameSearch.TextChanged

    End Sub
End Class