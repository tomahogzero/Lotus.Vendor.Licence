Imports System.Data
Imports System.Data.SqlClient
Imports TimeAttendance.utils

Public Class frmRptTimeSheet

    Private Sub frmRptTimeSheet_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        fReportTimeSheet = Nothing
    End Sub

    Private Sub frmRptTimeSheet_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
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

    Private Sub frmRptTimeSheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtMonthYear.Text = Format(Date.Now, "MM/yyyy")

        Call LoadCompany()

        If ComId <> "" Then
            cboCompany.Enabled = False

            cboCompany.SelectedItem = ComName
        End If

        Call LoadDivision()
        Call LoadDepartment()
        Call LoadPosition()
        Call LoadEmpGroup()

        Call LoadDATA()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        btnReport.Text = MsgManager.ShowLabel(Me, "rptTimeSheetRS", "Wait")
        btnReport.Enabled = False
        Call GenTimeSheet()
        btnReport.Text = MsgManager.ShowLabel(Me, "rptTimeSheetRS", "rpt")
        btnReport.Enabled = True

        ReportPrint = Report.PrintOTSheet
        'Dim Rpt As New frmViewReport
        'Rpt.ShowDialog()
    End Sub

    Private Sub GenTimeSheet()
        Dim dCmd As New SqlCommand
        Dim strSQL As String

        'Cry.SetParameterValue("@Month_Year", fReportTimeSheet.txtMonthYear.Text.Trim, "rptTimeSheetAw")
        'Cry.SetParameterValue("@Code1", fReportTimeSheet.txtCode1.Text.Trim, "rptTimeSheetAw")
        'Cry.SetParameterValue("@Code2", fReportTimeSheet.txtCode2.Text.Trim, "rptTimeSheetAw")


        With lstEMP
            strSQL = "Delete From RPT_TimeSheet"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            strSQL = "Delete From RPT_TimeSheet_Aw"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            Dim ar As New ArrayList
            Dim DateST As String
            Dim DateSP As String
            Dim Lang As String
            If rdTh.Checked = True Then
                Lang = "TH"
            Else
                Lang = "EN"
            End If

            ar = GetDayMonth(LeftText(txtMonthYear.Text.Trim, 2), RightText(txtMonthYear.Text.Trim, 4))
            DateST = ar.Item(0)
            DateSP = ar.Item(1)
            For i As Integer = 0 To .CheckedItems.Count - 1
                btnReport.Text = MsgManager.ShowLabel(Me, "rptTimeSheetRS", "Process") & i + 1 & "/" & .CheckedItems.Count
                Application.DoEvents()
                'spTimeGenTimeSheet @MonthYear nVarchar(7),@MonthName nVarchar(20),@Year nVarchar(4),@Code1 nVarchar(10) AS

                strSQL = "exec spTimeGenTimeSheet " & _
                                " '" & txtMonthYear.Text.Trim & "'," & _
                                " '" & MonthNameThai(CInt(Mid(fReportTimeSheet.txtMonthYear.Text.Trim, 1, 2))) & "'," & _
                                " '" & Mid(fReportTimeSheet.txtMonthYear.Text.Trim, 4, 4) & "'," & _
                                " '" & .CheckedItems(i).SubItems(1).Text.Trim & "'," & _
                                " '" & DateST.Trim & "','" & DateSP.Trim & "'," & _
                                " '" & Lang.Trim & "'"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()

                strSQL = "exec spTimeSheetAw " & _
                                " '" & txtMonthYear.Text.Trim & "'," & _
                                " '" & .CheckedItems(i).SubItems(1).Text.Trim & "'"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()
            Next
        End With
    End Sub

    Private Sub btnSelectALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectALL.Click
        With lstEMP
            For i As Integer = 0 To .Items.Count - 1
                .Items(i).Checked = True
            Next
        End With
    End Sub

    Private Sub btnNoneSelectALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoneSelectALL.Click
        With lstEMP
            For i As Integer = 0 To .Items.Count - 1
                .Items(i).Checked = False
            Next
        End With
    End Sub

    Private Sub LoadDATA()
        Dim strSQL As String = ""
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim arrDATA() As String
        Dim List As ListViewItem

        strSQL = "Select Code,Fname,Lname " &
                " From Emp Left Join Department " &
                        " On Emp.DeptId = Department.DeptId " &
                    " left join Division div " &
                        " on department.divid = div.divid " &
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

        If cboPosition.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Emp.Position,'') = '" & cboPosition.Text.Trim & "'"
        End If

        If cboEmpGroup.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Emp.GroupId,'') = '" & GetData.GetEmpGroupId(cboEmpGroup.Text.Trim) & "'"
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

        If txtCode.Text.Trim <> "" Then
            strSQL &= " and Code Like '%" & txtCode.Text.Trim & "%'"
        End If
        If txtCode.Text = "" And txtName.Text.Trim <> "" Then
            'strSQL &= " and FName Like '%" & txtName.Text.Trim & "%' Or " & _
            '            " LName Like '%" & txtName.Text.Trim & "%'"
            strSQL &= " and LTrim(RTrim(Emp.FName)) + LTrim(Rtrim(Emp.Lname)) Like '%" & Replace(txtName.Text.Trim, " ", "") & "%' "
        End If

        If rdByCode.Checked = True Then
            strSQL &= " Order By Emp.Code"
        End If

        If rdByName.Checked = True Then
            strSQL &= " Order By Fname,Lname"
        End If

        If rdByDeptCode.Checked = True Then
            strSQL &= " Order By Department.Department,Emp.Code"
        End If

        If rdByDeptName.Checked = True Then
            strSQL &= " Order By Department.Department,Fname,Lname"
        End If


        'strSQL &= " Order By Code "
        DA = New SqlDataAdapter(strSQL, Conn)
        DA.Fill(DS, "data")
        With DS.Tables("data")
            lstEMP.Items.Clear()
            For Each dr As DataRow In .Rows
                arrDATA = New String() {lstEMP.Items.Count + 1, _
                                        dr("Code"), _
                                        dr("FName"), _
                                        dr("LName")}
                List = New ListViewItem(arrDATA)
                lstEMP.Items.Add(List)
                lstEMP.Items(lstEMP.Items.Count - 1).Checked = True
            Next
        End With
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call LoadDATA()
    End Sub

    Private Sub txtCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.LostFocus
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select Code,Fname,Lname From Emp" & _
                " Where Code = '" & txtCode.Text.Trim & "'"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            If .Rows.Count = 0 Then
                txtCode.Text = ""
                txtName.Text = ""
                Ds.Clear()
                Exit Sub
            Else
                txtName.Text = .Rows(0).Item("FName") & "   " & .Rows(0).Item("LName")
            End If
            Ds.Clear()
        End With
    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter, GroupBox3.Enter

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdTh.CheckedChanged

    End Sub

    'Private Sub LoadDepartment()
    '    Dim Da As SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim strSQL As String = ""
    '    strSQL = "select Department " & _
    '            " From Department " & _
    '            " Order By Department"

    '    Da = New SqlDataAdapter(strSQL, Conn)
    '    Da.Fill(Ds, "data")
    '    With Ds.Tables("data")
    '        cboDepartment.Items.Clear()
    '        cboDepartment.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))

    '        For Each dr As DataRow In .Rows
    '            cboDepartment.Items.Add(dr("Department"))
    '        Next
    '        cboDepartment.SelectedIndex = 0
    '    End With
    'End Sub

    'Private Sub LoadDivision()
    '    Dim Da As SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim strSQL As String = ""
    '    strSQL = "select Division " & _
    '            " From Division " & _
    '            " Order By Division"

    '    Da = New SqlDataAdapter(strSQL, Conn)
    '    Da.Fill(Ds, "data")
    '    With Ds.Tables("data")
    '        cboDivision.Items.Clear()
    '        cboDivision.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))

    '        For Each dr As DataRow In .Rows
    '            cboDivision.Items.Add(dr("Division"))
    '        Next
    '        cboDivision.SelectedIndex = 0
    '    End With
    'End Sub

    Private Sub LoadPosition()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select Position " & _
                " From Emp "


        If cboCompany.SelectedIndex > 0 Then
            strSQL &= " Where Position In (Select Position From Emp " & _
                                    " Where WorkStatus  = 'W' and " & _
                                            " CompanyId = '" & GetData.GetCompanyId(cboCompany.Text) & "')"
        End If

        strSQL = strSQL & " Group by Position Order By Position"

        '" Group By Position " & _
        '" Order By Position"

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
                " From EmpGroup "


        If cboCompany.SelectedIndex > 0 Then
            strSQL &= " Where GroupId In (Select GroupId From Emp " & _
                                    " Where WorkStatus  = 'W' and " & _
                                            " CompanyId = '" & GetData.GetCompanyId(cboCompany.Text) & "')"
        End If

        strSQL = strSQL & " Order By GroupName"

        '" Order By GroupName"

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
        Call LoadDivision()
        Call LoadDepartment()
        Call LoadPosition()
        Call LoadEmpGroup()
    End Sub


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
End Class