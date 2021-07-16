Imports System.Data
Imports System.Data.SqlClient
Imports TimeAttendance.utils

Public Class frmRptMaxOT

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        ReportPrint = Report.PrintMaxOT
        'Dim rpt As New frmViewReport
        'rpt.Show()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub GroupPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupPanel1.Click

    End Sub

    Private Sub frmRptMaxOT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboYear.Text = Now.Year

        '  Call LoadCompany()
        Call LoadDivision()
        Call LoadDepartment()
        Call LoadSection()
        'Call LoadPosition()
        'Call LoadEmpGroup()
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

    Private Sub LoadSection()

        '--------------------------------------------
        Dim DA As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = "select SecId,Section " & _
            " from Section "

        If cboSection.SelectedIndex > 0 Then
            Strsql &= " Where SecId In (Select SecId From Section " & _
                                    " Where WorkStatus  = 'W' and " & _
                                            " CompanyId = '" & GetData.GetCompanyId(cboCompany.Text) & "')"
        End If

        Strsql = Strsql & " Order By Section"

        DA = New SqlDataAdapter(Strsql, Conn)
        DA.Fill(Ds, "data")

        cboSection.Items.Clear()
        cboSection.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
        With Ds.Tables("data")
            For Each Dr As DataRow In .Rows
                cboSection.Items.Add(Dr("Section"))
            Next
            cboSection.SelectedIndex = 0
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

    Private Sub txtCode1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode1.TextChanged

    End Sub

    Private Sub txtNameSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNameSearch.GotFocus
        txtCode1.Text = ""
    End Sub

    Private Sub txtNameSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNameSearch.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click, Label5.Click

    End Sub
End Class