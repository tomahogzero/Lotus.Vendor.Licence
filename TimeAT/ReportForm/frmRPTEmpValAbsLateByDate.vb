Imports System.Data.SqlClient
Imports System.Data
Imports TimeAttendance.utils
Imports DevExpress.XtraReports.UI
Imports DevExpress.LookAndFeel

Public Class frmRPTEmpValAbsLateByDate
    Dim gdata As New GetData
    Dim db As New DBManager
    Private Sub frmRPTTimeAbsent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDateStart.EditValue = Now.Date

        Call SearchData.LoadDivision(Me, cboDivision1, True)
        Call SearchData.LoadDepartment(Me, cboDepartment1, "", True)
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        btnReport.Enabled = False

        Call PrintReportAbsLatebydate()

        'If cValGolbal.Lang = "EN" Then
        '    Call PrintReportAbsLatebydate_Eng()
        'Else
        '    Call PrintReportAbsLatebydate()
        'End If

        btnReport.Enabled = True

    End Sub



    Private Sub PrintReportAbsLatebydate()

        Dim strDate As String = ""

        If cValGolbal.Lang = "TH" Then
            strDate = "ประจำวันที่"
        Else
            strDate = "Date"
        End If

        Dim report As New report_CountAbsent
        Dim rptformular As String = ""
        Dim strComNm As String = ""



        report.SqlDataSource1.Connection.ConnectionString = db.getConnString

        rptformular = 1 = "1"


        Dim Type As String = "A"

        '      Cry.SetParameterValue("@Type", Type)
        '      End With

        'Rptformular = 1 = "1"
        strComNm = My.Computer.Name.ToString



        rptformular = "1=1"



        If fRPTEmpValAbsLateByDate.cboDivision1.SelectedIndex > 0 Then ' ¶éÒàÅ×Í¡½èÒÂ·Ñé§ËÁ´
            Dim Division_Id As String = ""
            Division_Id = GetData.GetDivisionId(fRPTEmpValAbsLateByDate.cboDivision1.Text) ' ËÒ ÃËÑÊ ½èÒÂ
            rptformular &= " And  [DivId] = '" & Division_Id.Trim & "'"
        End If

        If fRPTEmpValAbsLateByDate.cboDepartment1.SelectedIndex > 0 Then ' ¶éÒàÅ×Í¡á¼¹¡ ·Ñé§ËÁ´
            Dim Department_Id As String = ""
            Department_Id = GetData.GetDepartmentId(fRPTEmpValAbsLateByDate.cboDepartment1.Text) ' ËÒá¼¹¡
            rptformular &= " And   [DeptId]='" & Department_Id.Trim & "'"
        End If

        '  [DivId] = '01' And [DeptId] = '11'


        Dim strdata As String = ""
        Dim strDt As String = ""
        Dim strdateUse As String = ""

        strDt = cDateTime.showDate(txtDateStart.EditValue)
        strdateUse = cDateTime.dbDate(txtDateStart.EditValue)


        Call Gendata_Store(strdateUse, Type, strComNm)

        Dim Companyname As String = ""
        Companyname = GetData.GetCompanyName ' 

        'report.Parameters("companyname").Value = "" & Companyname & ""
        Dim allhead As String = Me.Text ' "รายงานการลาขาดสายของพนักงาน ประจำวัน"
        report.Parameters("companyname").Value = "" & Companyname & ""
        report.Parameters("headname").Value = "" & allhead & ""
        report.Parameters("paradate").Value = "" & strdateUse & ""
        report.Parameters("type_use").Value = "" & Type & ""

        report.Parameters("headDate").Value = strDate & " : " & strDt

        report.RequestParameters = False
        report.FilterString = rptformular

        Using printTool As New ReportPrintTool(report)
            printTool.AutoShowParametersPanel = False
            '   AddHandler printTool.PrintingSystem.StartPrint, New DevExpress.XtraPrinting.PrintDocumentEventHandler(AddressOf PrintingSystem_StartPrint)

            printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default)
        End Using
    End Sub
    Private Sub PrintReportAbsLatebydate_Eng()
        Dim report As New report_CountAbsent_Eng
        Dim rptformular As String = ""
        Dim strComNm As String = ""



        report.SqlDataSource1.Connection.ConnectionString = db.getConnString

        rptformular = 1 = "1"


        Dim Type As String = "A"

        '      Cry.SetParameterValue("@Type", Type)
        '      End With

        'Rptformular = 1 = "1"
        strComNm = My.Computer.Name.ToString



        rptformular = "1=1"



        If fRPTEmpValAbsLateByDate.cboDivision1.SelectedIndex > 0 Then ' ¶éÒàÅ×Í¡½èÒÂ·Ñé§ËÁ´
            Dim Division_Id As String = ""
            Division_Id = GetData.GetDivisionId(fRPTEmpValAbsLateByDate.cboDivision1.Text) ' ËÒ ÃËÑÊ ½èÒÂ
            rptformular &= " And  [DivId] = '" & Division_Id.Trim & "'"
        End If

        If fRPTEmpValAbsLateByDate.cboDepartment1.SelectedIndex > 0 Then ' ¶éÒàÅ×Í¡á¼¹¡ ·Ñé§ËÁ´
            Dim Department_Id As String = ""
            Department_Id = GetData.GetDepartmentId(fRPTEmpValAbsLateByDate.cboDepartment1.Text) ' ËÒá¼¹¡
            rptformular &= " And   [DeptId]='" & Department_Id.Trim & "'"
        End If

        '  [DivId] = '01' And [DeptId] = '11'


        Dim strdata As String = ""
        Dim strDt As String = ""
        Dim strdateUse As String = ""

        strDt = cDateTime.showDate(txtDateStart.EditValue)
        strdateUse = cDateTime.dbDate(txtDateStart.EditValue)


        Call Gendata_Store(strdateUse, Type, strComNm)

        Dim Companyname As String = ""
        Companyname = GetData.GetCompanyName ' 

        'report.Parameters("companyname").Value = "" & Companyname & ""
        Dim allhead As String = Me.Text ' "รายงานการลาขาดสายของพนักงาน ประจำวัน"
        report.Parameters("companyname").Value = "" & Companyname & ""
        report.Parameters("headname").Value = "" & allhead & ""
        report.Parameters("paradate").Value = "" & strdateUse & ""
        report.Parameters("type_use").Value = "" & Type & ""

        report.Parameters("headDate").Value = "Date : " & txtDateStart.Text.Trim

        report.RequestParameters = False
        report.FilterString = rptformular

        Using printTool As New ReportPrintTool(report)
            printTool.AutoShowParametersPanel = False
            '   AddHandler printTool.PrintingSystem.StartPrint, New DevExpress.XtraPrinting.PrintDocumentEventHandler(AddressOf PrintingSystem_StartPrint)

            printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default)
        End Using
    End Sub
    Private Sub Gendata_Store(dateIN As String, type As String, comname As String)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dcmd As New SqlCommand
        strSQL = "exec spRPT_TimeAbslateValCountDialy '" & dateIN & "','" & type & "' ,' " & comname & "'"
        dcmd.Connection = Conn
        dcmd.CommandText = strSQL
        dcmd.ExecuteNonQuery()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cboDivision1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDivision1.SelectedIndexChanged
        Call SearchData.LoadDepartment(Me, cboDepartment1, GetData.GetDivisionId(cboDivision1.Text.Trim), True)
    End Sub

    Private Sub btnCurrentDate_Click(sender As Object, e As EventArgs) Handles btnCurrentDate.Click
        txtDateStart.EditValue = Now.Date
    End Sub



    'Private Sub rdShowByEmp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdShowByEmp.CheckedChanged
    '    GroupBox3.Enabled = False
    '    GroupBox5.Enabled = False
    'End Sub

    'Private Sub rdSumarize_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdSumarize.CheckedChanged
    '    GroupBox3.Enabled = True
    '    GroupBox5.Enabled = True
    'End Sub


End Class