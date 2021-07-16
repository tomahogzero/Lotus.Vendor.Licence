Imports System.Data.SqlClient
Imports System.Data
Imports TimeAttendance.utils

Public Class frmRPTSumaryWagePerDay

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
        Call LoadCompany()
        Call LoadDivision()
        Call LoadDepartment()
        Call LoadSection()
        Call LoadGroupID()

    End Sub

    Private Sub LoadCompany()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "select CompanyID,CompanyName from Company_Sub Order By CompanyId"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            cboCompany.Items.Clear()
            cboCompany.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            For Each dr As DataRow In .Rows
                cboCompany.Items.Add(dr("CompanyName"))
            Next
        End With
    End Sub

    Private Sub LoadDivision()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "select DivId,Division from division Order By Division"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            cboDivision.Items.Clear()
            cboDivision.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            For Each dr As DataRow In .Rows
                cboDivision.Items.Add(dr("Division"))
            Next
        End With
    End Sub

    Private Sub LoadDepartment()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "select DeptId,Department " & _
                " from department "

        If cboCompany.SelectedIndex > 0 Then
            strSQL &= " Where DeptId In (Select DeptId From Emp Where WorkStatus = 'W' and CompanyId = '" & GetData.GetCompanyId(cboCompany.Text.Trim) & "')"
        End If
        strSQL &= " Order By Department"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            cboDepartment.Items.Clear()
            cboDepartment.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            For Each dr As DataRow In .Rows
                cboDepartment.Items.Add(dr("Department"))
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
            cboSection.Items.Clear()
            cboSection.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            For Each dr As DataRow In .Rows
                cboSection.Items.Add(dr("Section"))
            Next
        End With
    End Sub

    Private Sub LoadGroupID()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "select groupid,groupname from empgroup order by groupid"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            cboEmpGroup.Items.Clear()
            cboEmpGroup.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            For Each dr As DataRow In .Rows
                cboEmpGroup.Items.Add(dr("groupname"))
            Next
        End With
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        ReportPrint = Report.PrintSumaryWagePerDay
        'Dim rpt As New frmViewReport
        'rpt.Show()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cboCompany_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompany.SelectedIndexChanged
        Call LoadDepartment()
    End Sub
End Class