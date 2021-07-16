Imports System.Data
Imports System.Data.SqlClient

Public Class frmSumarized
    Dim MaxAw As Integer = 0

    Private Sub frmSumarized_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        fSumarized = Nothing
    End Sub
    Private Sub frmSumarized_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtMonthYear.Text = Format(Now.Date, "MM/yyyy")
        Call CreateColumn()
        Call LoadSite()
        Call LoadDepartment()
    End Sub

    Private Sub CreateColumn()
        With lstSumaried
            .Columns.Clear()
            .Columns.Add("No", 40, HorizontalAlignment.Left)
            .Columns.Add("���ʾ��.", 77, HorizontalAlignment.Center)
            .Columns.Add("���� - ʡ��", 250, HorizontalAlignment.Left)
            .Columns.Add("����Ἱ�", 70, HorizontalAlignment.Center)
            .Columns.Add("�Թ��͹", 70, HorizontalAlignment.Right)
            .Columns.Add("OT 1x", 50, HorizontalAlignment.Right)
            .Columns.Add("OT 1.5x", 50, HorizontalAlignment.Right)
            .Columns.Add("OT 3x", 50, HorizontalAlignment.Right)
            .Columns.Add("", 20, HorizontalAlignment.Center)

            Dim Da As New SqlDataAdapter
            Dim Ds As New DataSet
            Dim strSQL As String
            strSQL = "Select Code,Description from Allowance Order By Code"
            Da = New SqlDataAdapter(strSQL, Conn)
            Da.Fill(Ds, "Data")
            Dim I As Integer
            MaxAw = Ds.Tables("Data").Rows.Count
            For I = 0 To Ds.Tables("Data").Rows.Count - 1
                .Columns.Add(Ds.Tables("Data").Rows(I).Item("Code").ToString & "(�)", 70, HorizontalAlignment.Right)
            Next
            Ds.Clear()
            .Columns.Add("", 20, HorizontalAlignment.Center)
            .Columns.Add("Abs(�ѹ)", 55, HorizontalAlignment.Right)
            .Columns.Add("Late(��.)", 55, HorizontalAlignment.Right)
            .Columns.Add("", 20, HorizontalAlignment.Center)
            .Columns.Add("Abs(�)", 60, HorizontalAlignment.Right)
            .Columns.Add("Late(�)", 60, HorizontalAlignment.Right)
        End With

    End Sub

    Private Sub LoadData()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim arrDATA() As String
        Dim List As ListViewItem

        strSQL = "Select Emp.Code,EmpName = Fname + '   ' + Lname," & _
                            " DeptId," & _
                            " Salary," & _
                            " OT1 = Isnull(OT1,0)," & _
                            " OT15 = Isnull(OT15,0)," & _
                            " OT3 = Isnull(OT3,0)," & _
                            " Late = Abs(Isnull(Late,0))," & _
                            " Absent = Abs(Isnull(Absent, 0))" & _
                " From Emp Left Join " & _
                                " (Select Code," & _
                                       " Sum(OT1) as OT1," & _
                                       " Sum(OT15) as OT15," & _
                                       " Sum(OT3) as OT3" & _
                                " From TimeOvertime" & _
                                " Where Month_Year = '" & txtMonthYear.Text.Trim & "'" & _
                                " Group By Code) as OT " & _
                        " On Emp.Code = OT.Code" & _
                        " Left Join (Select Code,Sum(Late + LateOut) as Late" & _
                                " From TimeLate" & _
                                " Where Month_Year = '" & txtMonthYear.Text.Trim & "'" & _
                                " Group By Code) as Late" & _
                        " On Emp.Code = Late.Code" & _
                        " Left Join (Select Code,Sum(Absent) as Absent" & _
                                " From TimeAbsent" & _
                                " Where Month_Year = '" & txtMonthYear.Text.Trim & "'" & _
                                " Group By Code) as Absent" & _
                        " On Emp.Code = Absent.Code" & _
                " Where WorkStatus = 'W'"

        If rdCode.Checked = True Then
            strSQL &= " Order By Emp.Code"
        End If
        If rdName.Checked = True Then
            strSQL &= " Order By Emp.Fname,Emp.Lname"
        End If
        If rdDept.Checked = True Then
            strSQL &= " Order By Emp.DeptId"
        End If
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            Dim I As Integer
            ProgressBar1.Maximum = .Rows.Count
            ProgressBar1.Value = 0
            lstSumaried.Items.Clear()
            For I = 0 To .Rows.Count - 1
                Dim SalaryDay As Double
                Dim Absent As Double
                Dim Late As Double
                Absent = .Rows(I).Item("Absent") / 8
                Late = .Rows(I).Item("Late")
                SalaryDay = .Rows(I).Item("Salary") / 30 / 8
                arrDATA = New String() {I + 1, _
                                        .Rows(I).Item("Code"), _
                                        .Rows(I).Item("Empname"), _
                                        .Rows(I).Item("DeptId"), _
                                        Format(.Rows(I).Item("Salary"), "#,##0.00"), _
                                        Format(.Rows(I).Item("OT1"), "#0.0"), _
                                        Format(.Rows(I).Item("OT15"), "#0.0"), _
                                        Format(.Rows(I).Item("OT3"), "#0.0"), _
                                         ""}
                List = New ListViewItem(arrDATA)
                lstSumaried.Items.Add(List)
                Dim J As Integer
                For J = 1 To MaxAw
                    lstSumaried.Items(I).SubItems.Add(Format(LoadAllowance(.Rows(I).Item("Code"), Replace(lstSumaried.Columns(J + 8).Text.Trim, "(�)", "")), "#,##0.00"))
                Next
                lstSumaried.Items(I).SubItems.Add("")
                lstSumaried.Items(I).SubItems.Add(Format(Absent, "#0.00"))
                lstSumaried.Items(I).SubItems.Add(Format(Late, "#0.00"))
                lstSumaried.Items(I).SubItems.Add("")
                lstSumaried.Items(I).SubItems.Add(Format(Absent * SalaryDay, "#,##0.00"))
                lstSumaried.Items(I).SubItems.Add(Format(Late * SalaryDay, "#,##0.00"))
                ProgressBar1.Value = I
            Next
            Ds.Clear()
        End With
        ' Load Allowance
    End Sub


    Private Sub LoadDataSearch()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim arrDATA() As String
        Dim List As ListViewItem

        strSQL = "Select Emp.Code,EmpName = Fname + '   ' + Lname," & _
                            " DeptId," & _
                            " Salary," & _
                            " OT1 = Isnull(OT1,0)," & _
                            " OT15 = Isnull(OT15,0)," & _
                            " OT3 = Isnull(OT3,0)," & _
                            " Late = Abs(Isnull(Late,0)/60)," & _
                            " Absent = Abs(Isnull(Absent, 0))" & _
                " From Emp Left Join " & _
                                " (Select Code," & _
                                       " Sum(OT1) as OT1," & _
                                       " Sum(OT15) as OT15," & _
                                       " Sum(OT3) as OT3" & _
                                " From TimeOvertime" & _
                                " Where Month_Year = '" & txtMonthYear.Text.Trim & "'" & _
                                " Group By Code) as OT " & _
                        " On Emp.Code = OT.Code" & _
                        " Left Join (Select Code,Sum(Late + LateOut) as Late" & _
                                " From TimeLate" & _
                                " Where Month_Year = '" & txtMonthYear.Text.Trim & "'" & _
                                " Group By Code) as Late" & _
                        " On Emp.Code = Late.Code" & _
                        " Left Join (Select Code,Sum(Absent) as Absent" & _
                                " From TimeAbsent" & _
                                " Where Month_Year = '" & txtMonthYear.Text.Trim & "'" & _
                                " Group By Code) as Absent" & _
                        " On Emp.Code = Absent.Code" & _
                " Where WorkStatus = 'W'"

        If cboSite.Text.Trim <> "" Then
            strSQL &= " and Emp.WorkingPlace = '" & cboSite.Text.Trim & "'"
        End If
        If txtCode.Text.Trim <> "" Then
            strSQL &= " and Emp.Code = '" & txtCode.Text.Trim & "' "
        End If
        If txtCode.Text.Trim = "" Then
            If txtFname.Text.Trim <> "" Then
                strSQL &= " and Emp.Fname Like '%" & txtFname.Text.Trim & "%'"
            End If
            If txtLname.Text.Trim <> "" Then
                strSQL &= " and Emp.Lname Like '%" & txtLname.Text.Trim & "%'"
            End If
        End If
        If lblDeptId.Text.Trim <> "" Then
            strSQL &= " and Emp.DeptId = '" & lblDeptId.Text.Trim & "'"
        End If

        If rdCode.Checked = True Then
            strSQL &= " Order By Emp.Code"
        End If
        If rdName.Checked = True Then
            strSQL &= " Order By Emp.Fname,Emp.Lname"
        End If
        If rdDept.Checked = True Then
            strSQL &= " Order By Emp.DeptId"
        End If
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            Dim I As Integer
            ProgressBar1.Maximum = .Rows.Count
            ProgressBar1.Value = 0
            lstSumaried.Items.Clear()
            For I = 0 To .Rows.Count - 1
                Dim SalaryDay As Double
                Dim Absent As Double
                Dim Late As Double
                Absent = .Rows(I).Item("Absent") / 8
                Late = .Rows(I).Item("Late")
                SalaryDay = .Rows(I).Item("Salary") / 30 / 8
                arrDATA = New String() {I + 1, _
                                        .Rows(I).Item("Code"), _
                                        .Rows(I).Item("Empname"), _
                                        .Rows(I).Item("DeptId"), _
                                        Format(.Rows(I).Item("Salary"), "#,##0.00"), _
                                        Format(.Rows(I).Item("OT1"), "#0.0"), _
                                        Format(.Rows(I).Item("OT15"), "#0.0"), _
                                        Format(.Rows(I).Item("OT3"), "#0.0"), _
                                         ""}
                List = New ListViewItem(arrDATA)
                lstSumaried.Items.Add(List)
                Dim J As Integer
                For J = 1 To MaxAw
                    lstSumaried.Items(I).SubItems.Add(Format(LoadAllowance(.Rows(I).Item("Code"), Replace(lstSumaried.Columns(J + 8).Text.Trim, "(�)", "")), "#,##0.00"))
                Next
                lstSumaried.Items(I).SubItems.Add("")
                lstSumaried.Items(I).SubItems.Add(Format(Absent, "#0.00"))
                lstSumaried.Items(I).SubItems.Add(Format(Late, "#0.00"))
                lstSumaried.Items(I).SubItems.Add("")
                lstSumaried.Items(I).SubItems.Add(Format(Absent * SalaryDay, "#,##0.00"))
                lstSumaried.Items(I).SubItems.Add(Format(Late * SalaryDay, "#,##0.00"))
                ProgressBar1.Value = I
            Next
            Ds.Clear()
        End With
        ' Load Allowance
    End Sub

    Function LoadAllowance(ByVal Code As String, ByVal awCode As String) As Double
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim Total As Double = 0
        strSQL = "Select Total = Isnull(Sum(Total),0) " & _
                " From TimeAllowance " & _
                " Where Code = '" & Code.Trim & "' and awCode = '" & awCode.Trim & "' and " & _
                        " Month_Year = '" & txtMonthYear.Text.Trim & "' "
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        Dim I As Integer
        For I = 0 To Ds.Tables("Data").Rows.Count - 1
            Total = Ds.Tables("Data").Rows(I).Item("Total")
        Next
        Ds.Clear()
        Return Total
    End Function

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Call LoadData()
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

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call LoadDataSearch()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub mnuChkOvertime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChkOvertime.Click
        Dim oYear As String
        Dim oMonth As String

        Dim DateSt As String
        Dim DateSp As String

        Dim newMonth As Integer
        Dim newYear As String

        oYear = Mid(txtMonthYear.Text.Trim, 4, 4)
        oMonth = Mid(txtMonthYear.Text.Trim, 1, 2)

        If oMonth = 1 Then
            newMonth = 12
            newYear = CInt(oYear) - 1
        Else
            newMonth = CInt(oMonth) - 1
            newYear = oYear
        End If
        DateSt = "11/" & Format(newMonth, "00") & "/" & newYear
        DateSp = "10/" & oMonth.Trim & "/" & oYear.Trim


        With lstSumaried
            If .SelectedItems.Count = 0 Then Exit Sub
            Dim frm As New frmOvertime
            frm.WindowState = FormWindowState.Maximized

            frm.txtCode.Text = .SelectedItems(0).SubItems(1).Text.Trim
            Call frm.txtCode_LostFocus(Me, System.EventArgs.Empty)
            frm.txtDateSt.Text = DateSt.Trim
            frm.txtDateSp.Text = DateSp.Trim

            Call frm.btnSearch_Click(Me, System.EventArgs.Empty)

            frm.ShowDialog()
            frm.BringToFront()
        End With
    End Sub

    Private Sub mnuCheckLate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCheckLate.Click
        Dim oYear As String
        Dim oMonth As String

        Dim DateSt As String
        Dim DateSp As String

        Dim newMonth As Integer
        Dim newYear As String

        oYear = Mid(txtMonthYear.Text.Trim, 4, 4)
        oMonth = Mid(txtMonthYear.Text.Trim, 1, 2)

        If oMonth = 1 Then
            newMonth = 12
            newYear = CInt(oYear) - 1
        Else
            newMonth = CInt(oMonth) - 1
            newYear = oYear
        End If
        DateSt = "11/" & Format(newMonth, "00") & "/" & newYear
        DateSp = "10/" & oMonth.Trim & "/" & oYear.Trim


        With lstSumaried
            If .SelectedItems.Count = 0 Then Exit Sub
            Dim frm As New frmLate
            frm.WindowState = FormWindowState.Maximized

            frm.txtCode.Text = .SelectedItems(0).SubItems(1).Text.Trim
            Call frm.txtCode_LostFocus(Me, System.EventArgs.Empty)
            frm.txtDateSt.Text = DateSt.Trim
            frm.txtDateSp.Text = DateSp.Trim

            Call frm.btnSearch_Click(Me, System.EventArgs.Empty)

            frm.ShowDialog()
            frm.BringToFront()
        End With
    End Sub

    Private Sub mnuCheckAbsent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCheckAbsent.Click
        Dim oYear As String
        Dim oMonth As String

        Dim DateSt As String
        Dim DateSp As String

        Dim newMonth As Integer
        Dim newYear As String

        oYear = Mid(txtMonthYear.Text.Trim, 4, 4)
        oMonth = Mid(txtMonthYear.Text.Trim, 1, 2)

        If oMonth = 1 Then
            newMonth = 12
            newYear = CInt(oYear) - 1
        Else
            newMonth = CInt(oMonth) - 1
            newYear = oYear
        End If
        DateSt = "11/" & Format(newMonth, "00") & "/" & newYear
        DateSp = "10/" & oMonth.Trim & "/" & oYear.Trim


        With lstSumaried
            If .SelectedItems.Count = 0 Then Exit Sub
            Dim frm As New frmAbs
            frm.WindowState = FormWindowState.Maximized

            frm.txtCode.Text = .SelectedItems(0).SubItems(1).Text.Trim
            Call frm.txtCode_LostFocus(Me, System.EventArgs.Empty)
            frm.txtDateSt.Text = DateSt.Trim
            frm.txtDateSp.Text = DateSp.Trim

            Call frm.btnSearch_Click(Me, System.EventArgs.Empty)

            frm.ShowDialog()
            frm.BringToFront()
        End With
    End Sub

    Private Sub mnuCheckAllowance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCheckAllowance.Click
        With lstSumaried
            If .SelectedItems.Count = 0 Then Exit Sub
            Dim frm As New frmAllowance
            frm.WindowState = FormWindowState.Maximized

            frm.txtMonthYear.Text = txtMonthYear.Text.Trim
            frm.txtCode.Text = .SelectedItems(0).SubItems(1).Text.Trim
            Call frm.txtCode_LostFocus(Me, System.EventArgs.Empty)
            frm.ShowDialog()
            frm.BringToFront()
        End With
    End Sub

    Private Sub lstSumaried_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSumaried.SelectedIndexChanged

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
End Class