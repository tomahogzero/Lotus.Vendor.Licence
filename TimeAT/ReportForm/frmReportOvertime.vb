Imports System.Data
Imports System.Data.SqlClient

Public Class frmReportOvertime

    Private Sub frmReportOvertime_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        fReportOvertime = Nothing
    End Sub

    Private Sub frmReportOvertime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadSite()
        Call LoadDepartment()
        Call LoadPosition()
    End Sub

    Private Sub LoadSite()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select Workingplace From Emp " & _
                " Group By Workingplace" & _
                " Order By Workingplace"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            cboSite.Items.Clear()
            cboDepartment.Items.Add("")
            Dim I As Integer
            For I = 0 To .Rows.Count - 1
                cboSite.Items.Add(.Rows(I).Item("WorkingPlace"))
            Next
            Ds.Clear()
        End With
    End Sub

    Private Sub LoadPosition()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select Position From Emp " & _
                " Group By Position" & _
                " Order By Position"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            cboPosition.Items.Clear()
            cboPosition.Items.Add("")
            Dim I As Integer
            For I = 0 To .Rows.Count - 1
                cboPosition.Items.Add(.Rows(I).Item("Position"))
            Next
            Ds.Clear()
        End With
    End Sub

    Private Sub LoadDepartment()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select Department From Department" & _
                " Order By Department"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            cboDepartment.Items.Clear()
            cboDepartment.Items.Add("")
            Dim I As Integer
            For I = 0 To .Rows.Count - 1
                cboDepartment.Items.Add(.Rows(I).Item("Department"))
            Next
            Ds.Clear()
        End With
    End Sub

    Private Sub cboDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepartment.SelectedIndexChanged
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select DeptId From Department" & _
                " Where Department = '" & cboDepartment.Text.Trim & "' " & _
                " Order By Department"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            lblDeptId.Text = ""
            Dim I As Integer
            For I = 0 To .Rows.Count - 1
                lblDeptId.Text = .Rows(I).Item("DeptId")
            Next
            Ds.Clear()
        End With
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
                txtFname.Text = ""
                txtLname.Text = ""
                Ds.Clear()
                Exit Sub
            Else
                txtFname.Text = .Rows(0).Item("FName")
                txtLname.Text = .Rows(0).Item("LName")
            End If
            Ds.Clear()
        End With
    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        'ReportPrint = Report.PrintOvertime
        'Dim Rpt As New frmViewReport
        'Rpt.ShowDialog()
    End Sub
End Class