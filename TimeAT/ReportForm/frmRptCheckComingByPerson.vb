Imports System.Data
Imports System.Data.SqlClient
Imports TimeAttendance.utils

Public Class frmRptCheckComingByPerson
    Dim gdata As New GetData
    Private Sub frmRptCheckComingByPerson_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
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
        txtDateST.Text = Format(Date.Now, "dd/MM/yyyy")
        txtDateSP.Text = Format(Date.Now, "dd/MM/yyyy")
        'Call LoadDepartment()

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
        ReportPrint = Report.PringCheckComingByPerson
        'Dim Rpt As New frmViewReport
        'Rpt.ShowDialog()
    End Sub

    'Private Sub LoadDepartment()
    '    Dim Da As SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim strSQL As String = ""
    '    strSQL = "Select DeptID,Department from Department Order By DeptID"
    '    Da = New SqlDataAdapter(strSQL, Conn)
    '    Da.Fill(Ds, "data")
    '    With Ds.Tables("data")
    '        If .Rows.Count = 0 Then
    '            cboDepartment.Items.Clear()
    '            'cboDepartment.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
    '        Else
    '            cboDepartment.Items.Clear()
    '            'cboDepartment.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
    '            For Each dr As DataRow In .Rows
    '                cboDepartment.Items.Add(dr("Department"))
    '            Next
    '        End If
    '    End With
    'End Sub

    Function GetDeptID(ByVal Department As String) As String
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select DeptID" & _
                " From Department " & _
                " Where Department = '" & Department.Trim & "'"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("DeptID")
            End If
        End With
    End Function

    Private Sub cboDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '   lblDeptID.Text = GetDeptID(cboDepartment.Text.Trim)
    End Sub

    Private Sub cboCompany_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompany.SelectedIndexChanged
        Call LoadDepartment()
        Call LoadDivision()
    End Sub

    'Private Sub LoadDivision()
    '    Dim DA As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim Strsql As String = ""

    '    Strsql = "select DivId,Division" & _
    '        " from DiviSion "

    '    If cboCompany.SelectedIndex > 0 Then
    '        Strsql &= " Where DivId In (Select DivId From Emp " & _
    '                                " Where WorkStatus  = 'W' and " & _
    '                                        " CompanyId = '" & GetData.GetCompanyId(cboCompany.Text) & "')"
    '    End If

    '    Strsql = Strsql & " Order By Division"

    '    DA = New SqlDataAdapter(Strsql, Conn)
    '    DA.Fill(Ds, "data")

    '    cboDivision.Items.Clear()
    '    cboDivision.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
    '    With Ds.Tables("data")
    '        For Each Dr As DataRow In .Rows
    '            cboDivision.Items.Add(Dr("Division"))
    '        Next
    '        cboDivision.SelectedIndex = 0
    '    End With
    'End Sub

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

    Private Sub txtCode1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode1.GotFocus
        txtNameSearch.Text = ""
    End Sub

    Private Sub txtCode1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtShowName.Text = gdata.GetShowEmpName(txtCode1.Text.Trim)
            txtShowName.Focus()
        End If
    End Sub

    Private Sub txtCode1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode1.LostFocus
        txtShowName.Text = gdata.GetShowEmpName(txtCode1.Text.Trim)
        txtShowName.Focus()
    End Sub

    Private Sub txtCode1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode1.TextChanged

    End Sub

    Private Sub txtNameSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNameSearch.GotFocus
        txtCode1.Text = ""
    End Sub

    Private Sub txtNameSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNameSearch.TextChanged

    End Sub
End Class