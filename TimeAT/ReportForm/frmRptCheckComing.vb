Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraReports.UI
Imports TimeAttendance.utils

Public Class frmRptCheckComing
    Dim gdata As New GetData
    Dim db As New DBManager

    Private Sub frmRptTimeSheet_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        fReportTimeSheet = Nothing
    End Sub

    Private Sub frmRptTimeSheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' txtMonthYear.EditValue = Format(Date.Now, "dd/MM/yyyy")
        txtDate.EditValue = Now.Date

        Call SearchData.LoadDivision(Me, cboDivision, True)
        Call SearchData.LoadDepartment(Me, cboDepartment, "", True)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        'ReportPrint = Report.PringCheckComing
        'Dim Rpt As New frmViewReport
        'Rpt.ShowDialog()
        btnReport.Enabled = False

        Call PrintReport()
        'If cValGolbal.Lang = "EN" Then
        '    Call PrintReport_Eng()
        'Else
        '    Call PrintReport()
        'End If

        btnReport.Enabled = True
    End Sub

    Private Sub PrintReport()
        Dim report As New report_CheckComing
        Dim rptformular As String = ""


        report.SqlDataSource1.Connection.ConnectionString = db.getConnString

        rptformular = "1 = 1"

        '[Fname] Like 'Supant'

        If txtCode1.Text <> "" Then  ' หาจากรหัส
            rptformular &= " And [Code]='" & txtCode1.Text.Trim & "'"
        ElseIf txtNameSearch.Text <> "" Then  ' ค้นหาตามชื่อ
            rptformular &= " And [Fname] Like '%" & txtNameSearch.Text.Trim & "%'"

        Else
            If cboDivision.SelectedIndex > 0 Then ' division
                Dim Division_Id As String = ""
                Division_Id = GetData.GetDivisionId(cboDivision.Text) ' ËÒ ÃËÑÊ ½èÒÂ
                rptformular &= " And  [DivId] = '" & Division_Id.Trim & "'"
            End If

            If cboDepartment.SelectedIndex > 0 Then ' แผนก
                Dim Department_Id As String = ""
                Department_Id = GetData.GetDepartmentId(cboDepartment.Text) ' ËÒá¼¹¡
                rptformular &= " And   [DeptId]='" & Department_Id.Trim & "'"
            End If

        End If


        Dim strdata As String = ""
        Dim strDt As String = ""
        Dim strdateUse As String = ""
        'strYear2 = YearName(Me)
        strdata = cDateTime.dbDate(txtDate.EditValue)


        Dim Companyname As String = ""
        Companyname = GetData.GetCompanyName ' 

        report.Parameters("companyname").Value = "" & Companyname & ""
        report.Parameters("Headname").Value = Me.Text ' "รายงานลงเวลาการทำงาน"
        If cValGolbal.Lang = "TH" Then
            report.Parameters("cCheckDate").Value = "วันที่ : " & txtDate.Text.Trim & ""
        Else
            report.Parameters("cCheckDate").Value = "Date : " & txtDate.Text.Trim & ""
        End If
        report.Parameters("paradate").Value = "" & strdata & ""

        report.Parameters("Lang").Value = cValGolbal.Lang

        'Time sheet working


        report.RequestParameters = False
        report.FilterString = rptformular

        Using printTool As New ReportPrintTool(report)
            printTool.AutoShowParametersPanel = False
            '   AddHandler printTool.PrintingSystem.StartPrint, New DevExpress.XtraPrinting.PrintDocumentEventHandler(AddressOf PrintingSystem_StartPrint)

            printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default)
        End Using
    End Sub
    Private Sub PrintReport_Eng()
        Dim report As New report_CheckComing_Eng
        Dim rptformular As String = ""


        report.SqlDataSource1.Connection.ConnectionString = db.getConnString

        rptformular = "1 = 1"

        '[Fname] Like 'Supant'

        If txtCode1.Text <> "" Then  ' หาจากรหัส
            rptformular &= " And [Code]='" & txtCode1.Text.Trim & "'"
        ElseIf txtNameSearch.Text <> "" Then  ' ค้นหาตามชื่อ
            rptformular &= " And [Fname] Like '%" & txtNameSearch.Text.Trim & "%'"

        Else
            If cboDivision.SelectedIndex > 0 Then ' division
                Dim Division_Id As String = ""
                Division_Id = GetData.GetDivisionId(cboDivision.Text) ' ËÒ ÃËÑÊ ½èÒÂ
                rptformular &= " And  [DivId] = '" & Division_Id.Trim & "'"
            End If

            If cboDepartment.SelectedIndex > 0 Then ' แผนก
                Dim Department_Id As String = ""
                Department_Id = GetData.GetDepartmentId(cboDepartment.Text) ' ËÒá¼¹¡
                rptformular &= " And   [DeptId]='" & Department_Id.Trim & "'"
            End If

        End If


        Dim strdata As String = ""
        Dim strDt As String = ""
        Dim strdateUse As String = ""
        'strYear2 = YearName(Me)
        strdata = cDateTime.dbDate(txtDate.EditValue)




        Dim Companyname As String = ""
        Companyname = GetData.GetCompanyName ' 

        report.Parameters("companyname").Value = "" & Companyname & ""
        report.Parameters("Headname").Value = Me.Text ' "รายงานลงเวลาการทำงาน"
        report.Parameters("cCheckDate").Value = "Date : " & txtDate.Text & ""
        report.Parameters("paradate").Value = "" & strdata & ""

        'Time sheet working



        report.RequestParameters = False
        report.FilterString = rptformular

        Using printTool As New ReportPrintTool(report)
            printTool.AutoShowParametersPanel = False
            '   AddHandler printTool.PrintingSystem.StartPrint, New DevExpress.XtraPrinting.PrintDocumentEventHandler(AddressOf PrintingSystem_StartPrint)

            printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default)
        End Using
    End Sub
    Private Sub LoadDepartment()

        '--------------------------------------------
        Dim DA As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = "select DeptId,Department " &
            " from department "

        'If cboCompany.SelectedIndex > 0 Then
        '    Strsql &= " Where DeptId In (Select DeptId From Emp " &
        '                            " Where WorkStatus  = 'W' and " &
        '                                    " CompanyId = '" & GetData.GetCompanyId(cboCompany.Text) & "')"
        'End If

        Strsql = Strsql & " Order By Department"

        DA = New SqlDataAdapter(Strsql, Conn)
        DA.Fill(Ds, "data")

        cboDepartment.Properties.Items.Clear()
        cboDepartment.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
        With Ds.Tables("data")
            For Each Dr As DataRow In .Rows
                cboDepartment.Properties.Items.Add(Dr("Department"))
            Next
            If cboDepartment.Properties.Items.Count > 0 Then
                cboDepartment.SelectedIndex = 0
            End If

        End With
    End Sub

    Private Sub LoadDivision()

        Dim DA As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = "select DivId,Division" &
            " from DiviSion "


        Strsql = Strsql & " Order By Division"

        DA = New SqlDataAdapter(Strsql, Conn)
        DA.Fill(Ds, "data")


        cboDivision.Properties.Items.Clear()
        cboDivision.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
        With Ds.Tables("data")
            For Each Dr As DataRow In .Rows
                cboDivision.Properties.Items.Add(Dr("Division"))
            Next

            If cboDivision.Properties.Items.Count > 0 Then
                cboDivision.SelectedIndex = 0
            End If

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


    Private Sub txtNameSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNameSearch.GotFocus
        txtCode1.Text = ""
        txtShowName.Text = ""
    End Sub

    Private Sub txtNameSearch_LostFocus(sender As Object, e As EventArgs) Handles txtNameSearch.LostFocus

    End Sub

    Private Sub btnCurrentDate_Click(sender As Object, e As EventArgs) Handles btnCurrentDate.Click
        txtDate.EditValue = Now.Date
    End Sub

    Private Sub cboDivision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDivision.SelectedIndexChanged
        Call SearchData.LoadDepartment(Me, cboDepartment, GetData.GetDivisionId(cboDivision.Text.Trim), True)
    End Sub
End Class