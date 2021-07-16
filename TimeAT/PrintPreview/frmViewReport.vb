Imports System.Data
Imports System.Data.SqlClient
Imports TimeAttendance.utils

'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared

Public Class frmViewReport

    Private Sub frmViewReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If ReportPrint = Report.PrintOTSheet Then
            Dim Cry As New rptTimeSheet
            Cry.SetDatabaseLogon(sysUsername, sysPassword)
            Me.Text = "Time Sheet"
            Cry.DataDefinition.FormulaFields("T_Work").Text = MsgManager.ShowLabel(Me, "rptTimeSheetRS", "T_Work")
            Cry.DataDefinition.FormulaFields("No").Text = MsgManager.ShowLabel(Me, "rptTimeSheetRS", "No")
            Cry.DataDefinition.FormulaFields("Day").Text = MsgManager.ShowLabel(Me, "rptTimeSheetRS", "Day")
            Cry.DataDefinition.FormulaFields("In").Text = MsgManager.ShowLabel(Me, "rptTimeSheetRS", "In_Text")
            Cry.DataDefinition.FormulaFields("Out").Text = MsgManager.ShowLabel(Me, "rptTimeSheetRS", "Out")
            Cry.DataDefinition.FormulaFields("Late1").Text = MsgManager.ShowLabel(Me, "rptTimeSheetRS", "Late1")
            Cry.DataDefinition.FormulaFields("Late2").Text = MsgManager.ShowLabel(Me, "rptTimeSheetRS", "Late2")
            Cry.DataDefinition.FormulaFields("Abs").Text = MsgManager.ShowLabel(Me, "rptTimeSheetRS", "Abs")
            CrystalReportViewer1.ReportSource = Cry
            'CrystalReportViewer1.RefreshReport()
            Exit Sub
        End If

        '  Report all employee's work  -------------------------------------------------------------------------------------------------------
        If ReportPrint = Report.PrintTimeWork Then
            Dim Cry As New rptEmpTimeWork
            Dim rptformular As String = ""
            Cry.SetDatabaseLogon(sysUsername, sysPassword)
            Me.Text = "รายงานตามเวลาเข้าออก"
            Cry.DataDefinition.FormulaFields("DateFrom").Text = "'จากวันที่ : " & fRptAllEmpWork.txtDateStart.Text.Trim & " to  " & fRptAllEmpWork.txtDateStop.Text.Trim & "'"

            rptformular = "1=1"

            If fRptAllEmpWork.txtCode1.Text <> "" Then  ' ค้นหาตามรหัส
                rptformular &= " And {Emp.Code}='" & fRptAllEmpWork.txtCode1.Text.Trim & "'"
            ElseIf fRptAllEmpWork.txtNameSearch.Text <> "" Then  ' ค้นหาตามชื่อ
                rptformular &= " And {Emp.fname} like '*" & fRptAllEmpWork.txtNameSearch.Text.Trim & "*'"
            Else

                If fRptAllEmpWork.cboCompany.SelectedIndex > 0 Then ' ถ้าไม่เลือกบริษัททั้งหมด
                    Dim Company_Id As String
                    Company_Id = GetData.GetCompanyId(fRptAllEmpWork.cboCompany.Text) ' หา รหัส Id ของ Company_Sub
                    rptformular &= " And {Emp.CompanyID} = '" & Company_Id.Trim & "'"
                End If

                If fRptAllEmpWork.cboDivision.SelectedIndex > 0 Then ' ถ้าเลือกฝ่ายทั้งหมด
                    Dim Division_Id As String = ""
                    Division_Id = GetData.GetDivisionId(fRptAllEmpWork.cboDivision.Text) ' หา รหัส ฝ่าย
                    rptformular &= " And  {Emp.DivId} = '" & Division_Id.Trim & "'"
                End If

                If fRptAllEmpWork.cboDepartment.SelectedIndex > 0 Then ' ถ้าเลือกแผนก ทั้งหมด
                    Dim Department_Id As String = ""
                    Department_Id = GetData.GetDepartmentId(fRptAllEmpWork.cboDepartment.Text) ' หาแผนก
                    rptformular &= " And   {Emp.DeptId}='" & Department_Id.Trim & "'"
                End If

                If fRptAllEmpWork.cboPosition.SelectedIndex > 0 Then ' ถ้าเลือกตำแหน่งทั้งหมด
                    rptformular &= " And  {Emp.Position}='" & fRptAllEmpWork.cboPosition.Text.Trim & "'"
                End If

                If fRptAllEmpWork.cboEmpGroup.SelectedIndex > 0 Then ' ถ้าเลือกกลุ่มทั้งหมด
                    Dim EmpGroup_Id As String = ""
                    EmpGroup_Id = GetData.GetEmpGroupId(fRptAllEmpWork.cboEmpGroup.Text.Trim)  ' หากลุ่ม
                    rptformular &= " And  {Emp.GroupId}='" & EmpGroup_Id.Trim & "'"
                End If


                If fRptAllEmpWork.rdMonth.Checked = True Then ' เลือกรายเดือน
                    rptformular &= " And {Emp.WageType}='M'"
                End If

                If fRptAllEmpWork.rdDay.Checked = True Then ' เลือกทั้งรายวัน
                    rptformular &= " And {Emp.WageType}='D'"
                End If

                If fRptAllEmpWork.rdContractor.Checked = True Then ' เลือกรายเหมา
                    rptformular &= " And {Emp.WageType}='D' And {Emp.Contractor}=True"
                End If

            End If



            Cry.DataDefinition.RecordSelectionFormula = rptformular
            CrystalReportViewer1.ReportSource = Cry
            'CrystalReportViewer1.RefreshReport()
            Exit Sub
        End If


        ' รายงานเวลาการทำงานของพนักงาน(แบบละเอียด) ------------------------------------------------------------------------------------------------------
        If ReportPrint = Report.PrintTimeWork_Detail Then
            Dim Cry As New rptEmpTimeWork_Detail
            Dim rptformular As String = ""
            Cry.SetDatabaseLogon(sysUsername, sysPassword)

            'Cry.DataDefinition.FormulaFields("DateFrom").Text = "'From Date " & fRptAllEmpWork.txtDateStart.Text.Trim & " to " & fRptAllEmpWork.txtDateStop.Text.Trim & "'"

            rptformular = 1 = "1"

            If fRptAllEmpWork_Detail.txtCode1.Text <> "" Then  ' ค้นหาตามรหัส
                rptformular &= " And {Emp.Code}='" & fRptAllEmpWork_Detail.txtCode1.Text.Trim & "'"
            ElseIf fRptAllEmpWork_Detail.txtNameSearch.Text <> "" Then  ' ค้นหาตามชื่อ
                rptformular &= " And {Emp.fname} like '*" & fRptAllEmpWork_Detail.txtNameSearch.Text.Trim & "*'"
            Else

                If fRptAllEmpWork_Detail.cboCompany.SelectedIndex > 0 Then ' ถ้าไม่เลือกบริษัททั้งหมด
                    Dim Company_Id As String
                    Company_Id = GetData.GetCompanyId(fRptAllEmpWork_Detail.cboCompany.Text) ' หา รหัส Id ของ Company_Sub
                    rptformular &= " And {Emp.CompanyID} = '" & Company_Id.Trim & "'"
                End If

                If fRptAllEmpWork_Detail.cboDivision.SelectedIndex > 0 Then ' ถ้าเลือกฝ่ายทั้งหมด
                    Dim Division_Id As String = ""
                    Division_Id = GetData.GetDivisionId(fRptAllEmpWork_Detail.cboDivision.Text) ' หา รหัส ฝ่าย
                    rptformular &= " And  {Emp.DivId} = '" & Division_Id.Trim & "'"
                End If

                If fRptAllEmpWork_Detail.cboDepartment.SelectedIndex > 0 Then ' ถ้าเลือกแผนก ทั้งหมด
                    Dim Department_Id As String = ""
                    Department_Id = GetData.GetDepartmentId(fRptAllEmpWork_Detail.cboDepartment.Text) ' หาแผนก
                    rptformular &= " And   {Emp.DeptId}='" & Department_Id.Trim & "'"
                End If

                If fRptAllEmpWork_Detail.cboPosition.SelectedIndex > 0 Then ' ถ้าเลือกตำแหน่งทั้งหมด
                    rptformular &= " And  {Emp.Position}='" & fRptAllEmpWork_Detail.cboPosition.Text.Trim & "'"
                End If

                If fRptAllEmpWork_Detail.cboEmpGroup.SelectedIndex > 0 Then ' ถ้าเลือกกลุ่มทั้งหมด
                    Dim EmpGroup_Id As String = ""
                    EmpGroup_Id = GetData.GetEmpGroupId(fRptAllEmpWork_Detail.cboEmpGroup.Text.Trim)  ' หากลุ่ม
                    rptformular &= " And  {Emp.GroupId}='" & EmpGroup_Id.Trim & "'"
                End If


                If fRptAllEmpWork_Detail.rdMonth.Checked = True Then ' เลือกรายเดือน
                    rptformular &= " And {Emp.WageType}='M'"
                End If

                If fRptAllEmpWork_Detail.rdDay.Checked = True Then ' เลือกทั้งรายวัน
                    rptformular &= " And {Emp.WageType}='D'"
                End If

                If fRptAllEmpWork_Detail.rdContractor.Checked = True Then ' เลือกรายเหมา
                    rptformular &= " And {Emp.WageType}='D' And {Emp.Contractor}=True"
                End If

            End If

            Cry.DataDefinition.FormulaFields("Absent").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "Absent")
            Cry.DataDefinition.FormulaFields("Com").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "Com")
            Cry.DataDefinition.FormulaFields("Date").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "Date_Text")
            Cry.DataDefinition.FormulaFields("Dep").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "Dep")
            Cry.DataDefinition.FormulaFields("Div").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "Div")
            Cry.DataDefinition.FormulaFields("Forgot_2").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "Forgot_2")
            Cry.DataDefinition.FormulaFields("ID").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "ID")
            Cry.DataDefinition.FormulaFields("In").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "In_Text")
            Cry.DataDefinition.FormulaFields("Ka").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "Ka")
            Cry.DataDefinition.FormulaFields("Late").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "Late")
            Cry.DataDefinition.FormulaFields("Late_OT").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "Late_OT")
            Cry.DataDefinition.FormulaFields("Late_R").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "Late_R")
            Cry.DataDefinition.FormulaFields("Leave").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "Leave")
            Cry.DataDefinition.FormulaFields("Leave_Pay").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "Leave_Pay")
            Cry.DataDefinition.FormulaFields("Name_Last").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "Name_Last")
            Cry.DataDefinition.FormulaFields("Out").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "Out")
            Cry.DataDefinition.FormulaFields("rpt_head").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "rpt_head")
            Cry.DataDefinition.FormulaFields("Rec").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "Rec")
            Cry.DataDefinition.FormulaFields("Work").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "Work")
            Cry.DataDefinition.FormulaFields("Work_R").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "Work_R")

            Cry.DataDefinition.RecordSelectionFormula = rptformular
            'Me.Text = "รายงานการทำงานของพนักงาน (แบบละเอียด)"
            Me.Text = MsgManager.ShowLabel(Me, "HTFReportForm", "HTFrptEmpTimeWork_Detail")
            CrystalReportViewer1.ReportSource = Cry
            'CrystalReportViewer1.RefreshReport()
            Exit Sub
        End If



        ' บัญชีลงเวลาปฎบัติงาน --------------------------------------------------------------------------------------
        If ReportPrint = Report.PringCheckComing Then
            Dim strData As String = ""
            Dim strDay As String = ""
            Dim strYear As String = ""
            Dim IntMonth As Integer = 0
            Dim strDT As String = ""
            Dim strYear2 As String = ""

            Dim Cry As New rptCheckComing
            Cry.SetDatabaseLogon(sysUsername, sysPassword)
            Dim CheckDate As String
            Dim Rptformular As String = ""
            strYear2 = YearName(Me)
            'strData = CStr(Format(CDate(fRptCheckComing.txtMonthYear.Text.Trim), "yyyy/MM/dd"))
            strData = (ConvertDate(fRptCheckComing.txtMonthYear.Text.Trim))
            strYear = Mid(strData.Trim, 1, 4)
            strDay = Mid(strData.Trim, 9, 2)
            IntMonth = CInt(Mid(strData.Trim, 9, 2))
            'strDT = strDay & " " & MonthName(Me, IntMonth) & " " & CStr(CInt(strYear) + CInt(strYear2))
            strDT = Format(CDate(strData), "dd/MM/yyyy")
            CheckDate = ConvertDate(fRptCheckComing.txtMonthYear.Text.Trim)
            Cry.SetParameterValue("@Date", CheckDate.Trim)

            Cry.DataDefinition.FormulaFields("cCheckDate").Text = "'" & strDT & "'"

            'Dim Code1 As String
            'Dim Code2 As String
            'If fRptCheckComing.chkCheckAll.Checked = True Then
            '    Code1 = "0"
            '    Code2 = "99999"
            'Else
            '    Code1 = fRptCheckComing.txtCode1.Text.Trim
            '    Code2 = fRptCheckComing.txtCode2.Text.Trim
            'End If


            'Cry.SetParameterValue("@Code1", Code1.Trim)
            'Cry.SetParameterValue("@Code2", Code2.Trim)

            Rptformular = 1 = "1"

            If fRptCheckComing.txtCode1.Text <> "" Then  ' ค้นหาตามรหัส
                Rptformular &= " And {spTimeCheckComing;1.Code}='" & fRptCheckComing.txtCode1.Text.Trim & "'"
            ElseIf fRptCheckComing.txtNameSearch.Text <> "" Then  ' ค้นหาตามชื่อ
                Rptformular &= " And {spTimeCheckComing;1.fname} like '*" & fRptCheckComing.txtNameSearch.Text.Trim & "*'"
            Else

                If fRptCheckComing.cboCompany.SelectedIndex > 0 Then ' ถ้าไม่เลือกบริษัททั้งหมด
                    Dim Company_Id As String
                    Company_Id = GetData.GetCompanyId(fRptCheckComing.cboCompany.Text) ' หา รหัส Id ของ Company_Sub
                    Rptformular &= " And {spTimeCheckComing;1.CompanyID} = '" & Company_Id.Trim & "'"
                End If

                If fRptCheckComing.cboDivision.SelectedIndex > 0 Then ' ถ้าเลือกฝ่ายทั้งหมด
                    Dim Division_Id As String = ""
                    Division_Id = GetData.GetDivisionId(fRptCheckComing.cboDivision.Text) ' หา รหัส ฝ่าย
                    Rptformular &= " And  {spTimeCheckComing;1.DivId} = '" & Division_Id.Trim & "'"
                End If

                If fRptCheckComing.cboDepartment.SelectedIndex > 0 Then ' ถ้าเลือกแผนก ทั้งหมด
                    Dim Department_Id As String = ""
                    Department_Id = GetData.GetDepartmentId(fRptCheckComing.cboDepartment.Text) ' หาแผนก
                    Rptformular &= " And   {spTimeCheckComing;1.DeptId}='" & Department_Id.Trim & "'"
                End If

                If fRptCheckComing.cboPosition.SelectedIndex > 0 Then ' ถ้าเลือกตำแหน่งทั้งหมด
                    Rptformular &= " And  {spTimeCheckComing;1.Position}='" & fRptCheckComing.cboPosition.Text.Trim & "'"
                End If

                If fRptCheckComing.cboEmpGroup.SelectedIndex > 0 Then ' ถ้าเลือกกลุ่มทั้งหมด
                    Dim EmpGroup_Id As String = ""
                    EmpGroup_Id = GetData.GetEmpGroupId(fRptCheckComing.cboEmpGroup.Text.Trim)  ' หากลุ่ม
                    Rptformular &= " And  {spTimeCheckComing;1.GroupId}='" & EmpGroup_Id.Trim & "'"
                End If


                If fRptCheckComing.rdMonth.Checked = True Then ' เลือกรายเดือน
                    Rptformular &= " And {spTimeCheckComing;1.WageType}='M'"
                End If

                If fRptCheckComing.rdDay.Checked = True Then ' เลือกทั้งรายวัน
                    Rptformular &= " And {spTimeCheckComing;1.WageType}='D'"
                End If

                If fRptCheckComing.rdContractor.Checked = True Then ' เลือกรายเหมา
                    Rptformular &= " And {spTimeCheckComing;1.WageType}='D' And {spTimeCheckComing;1.Contractor}=True"
                End If

            End If

            'MsgManager.ShowLabel(Me, "rptCheckComingRS", "Col")
            '(Me, "frmAbsRS", Me.Text, "Check_Date", MessageBoxIcon.Information)
            Cry.DataDefinition.FormulaFields("Col").Text = MsgManager.ShowLabel(Me, "rptCheckComingRS", "Col")
            Cry.DataDefinition.FormulaFields("Manager").Text = MsgManager.ShowLabel(Me, "rptCheckComingRS", "Manager")
            Cry.DataDefinition.FormulaFields("Name_Last").Text = MsgManager.ShowLabel(Me, "rptCheckComingRS", "Name_Last")
            Cry.DataDefinition.FormulaFields("Remark").Text = MsgManager.ShowLabel(Me, "rptCheckComingRS", "Remark")
            Cry.DataDefinition.FormulaFields("rpt_head").Text = MsgManager.ShowLabel(Me, "rptCheckComingRS", "rpt_head")
            Cry.DataDefinition.FormulaFields("Signature").Text = MsgManager.ShowLabel(Me, "rptCheckComingRS", "Signature")
            Cry.DataDefinition.FormulaFields("T_in").Text = MsgManager.ShowLabel(Me, "rptCheckComingRS", "T_in")
            Cry.DataDefinition.FormulaFields("T_out").Text = MsgManager.ShowLabel(Me, "rptCheckComingRS", "T_out")
            Cry.DataDefinition.FormulaFields("EmpCode").Text = MsgManager.ShowLabel(Me, "rptCheckComingRS", "EmpCode")

            Cry.DataDefinition.RecordSelectionFormula = Rptformular

            'Me.Text = "บัญชีลงเวลาทำงาน"
            Me.Text = MsgManager.ShowLabel(Me, "HTFReportForm", "HTFrptCheckComing")
            CrystalReportViewer1.ReportSource = Cry
            'CrystalReportViewer1.RefreshReport()
            Exit Sub

        End If



        ' รายงานแสดงเวลาทำงาน------------------------------------------------------------------------------
        If ReportPrint = Report.PringCheckComingByPerson Then
            Dim Cry As New rptEmpTimeINOUT
            Cry.SetDatabaseLogon(sysUsername, sysPassword)
            Dim Header As String
            Dim Formular As String = ""
            With fRptCheckComingByPerson
                Header = Replace(MsgManager.ShowLabel(Me, "rptEmpTimeINOUTRS", "Date_St") & _
                                .txtDateST.Text.Trim & MsgManager.ShowLabel(Me, "rptEmpTimeINOUTRS", "Date_To") & _
                                .txtDateSP.Text.Trim, "'", "")

                Formular = "({vTimework_INOUT.DateIn} >= #" & ConvertDate(.txtDateST.Text.Trim) & " 00:00" & "# and " & _
                            "{vTimework_INOUT.DateIn} <= #" & ConvertDate(.txtDateSP.Text.Trim) & " 23:59" & "#)"


                If fRptCheckComingByPerson.txtCode1.Text <> "" Then  ' ค้นหาตามรหัส
                    Formular &= " And {Emp.Code}='" & fRptCheckComingByPerson.txtCode1.Text.Trim & "'"
                ElseIf fRptCheckComingByPerson.txtNameSearch.Text <> "" Then  ' ค้นหาตามชื่อ
                    Formular &= " And {Emp.fname} like '*" & fRptCheckComingByPerson.txtNameSearch.Text.Trim & "*'"
                Else

                    If fRptCheckComingByPerson.cboCompany.SelectedIndex > 0 Then ' ถ้าไม่เลือกบริษัททั้งหมด
                        Dim Company_Id As String
                        Company_Id = GetData.GetCompanyId(fRptCheckComingByPerson.cboCompany.Text) ' หา รหัส Id ของ Company_Sub
                        Formular &= " And {Emp.CompanyID} = '" & Company_Id.Trim & "'"
                    End If

                    If fRptCheckComingByPerson.cboDivision.SelectedIndex > 0 Then ' ถ้าเลือกฝ่ายทั้งหมด
                        Dim Division_Id As String = ""
                        Division_Id = GetData.GetDivisionId(fRptCheckComingByPerson.cboDivision.Text) ' หา รหัส ฝ่าย
                        Formular &= " And  {Emp.DivId} = '" & Division_Id.Trim & "'"
                    End If

                    If fRptCheckComingByPerson.cboDepartment.SelectedIndex > 0 Then ' ถ้าเลือกแผนก ทั้งหมด
                        Dim Department_Id As String = ""
                        Department_Id = GetData.GetDepartmentId(fRptCheckComingByPerson.cboDepartment.Text) ' หาแผนก
                        Formular &= " And   {Emp.DeptId}='" & Department_Id.Trim & "'"
                    End If

                    If fRptCheckComingByPerson.cboPosition.SelectedIndex > 0 Then ' ถ้าเลือกตำแหน่งทั้งหมด
                        Formular &= " And  {Emp.Position}='" & fRptCheckComingByPerson.cboPosition.Text.Trim & "'"
                    End If

                    If fRptCheckComingByPerson.cboEmpGroup.SelectedIndex > 0 Then ' ถ้าเลือกกลุ่มทั้งหมด
                        Dim EmpGroup_Id As String = ""
                        EmpGroup_Id = GetData.GetEmpGroupId(fRptCheckComingByPerson.cboEmpGroup.Text.Trim)  ' หากลุ่ม
                        Formular &= " And  {Emp.GroupId}='" & EmpGroup_Id.Trim & "'"
                    End If


                    If fRptCheckComingByPerson.rdMonth.Checked = True Then ' เลือกรายเดือน
                        Formular &= " And {Emp.WageType}='M'"
                    End If

                    If fRptCheckComingByPerson.rdDay.Checked = True Then ' เลือกทั้งรายวัน
                        Formular &= " And {Emp.WageType}='D'"
                    End If

                    If fRptCheckComingByPerson.rdContractor.Checked = True Then ' เลือกรายเหมา
                        Formular &= " And {Emp.WageType}='D' And {Emp.Contractor}=True"
                    End If
                End If


            End With
            'rptEmpTimeINOUT

            Cry.DataDefinition.FormulaFields("Header").Text = "'" & Header.Trim & "'"
            Cry.DataDefinition.FormulaFields("Date").Text = MsgManager.ShowLabel(Me, "rptEmpTimeINOUTRS", "Date_Text")
            Cry.DataDefinition.FormulaFields("Dep").Text = MsgManager.ShowLabel(Me, "rptEmpTimeINOUTRS", "Dep")
            Cry.DataDefinition.FormulaFields("Emp_ID").Text = MsgManager.ShowLabel(Me, "rptEmpTimeINOUTRS", "Emp_ID")
            Cry.DataDefinition.FormulaFields("Late").Text = MsgManager.ShowLabel(Me, "rptEmpTimeINOUTRS", "Late")
            Cry.DataDefinition.FormulaFields("M_Late").Text = MsgManager.ShowLabel(Me, "rptEmpTimeINOUTRS", "M_Late")
            Cry.DataDefinition.FormulaFields("O_Before").Text = MsgManager.ShowLabel(Me, "rptEmpTimeINOUTRS", "O_Before")
            Cry.DataDefinition.FormulaFields("rpt_head").Text = MsgManager.ShowLabel(Me, "rptEmpTimeINOUTRS", "rpt_head")
            Cry.DataDefinition.FormulaFields("T_Out").Text = MsgManager.ShowLabel(Me, "rptEmpTimeINOUTRS", "T_Out")
            Cry.DataDefinition.FormulaFields("T_In").Text = MsgManager.ShowLabel(Me, "rptEmpTimeINOUTRS", "T_In")
            Cry.DataDefinition.FormulaFields("T_Late").Text = MsgManager.ShowLabel(Me, "rptEmpTimeINOUTRS", "T_Late")
            Cry.DataDefinition.RecordSelectionFormula = Formular


            'Me.Text = "บัญชีลงเวลาทำงาน"
            Me.Text = MsgManager.ShowLabel(Me, "HTFReportForm", "HTFrptEmpTimeINOUT")
            CrystalReportViewer1.ReportSource = Cry
            'CrystalReportViewer1.RefreshReport()
            Exit Sub
        End If



        If ReportPrint = Report.PrintOvertime Then
            Dim Cry As New rptOtByPersonSuamry
            Cry.SetDatabaseLogon(sysUsername, sysPassword)
            Dim cHead As String
            cHead = "For Month " & fReportOvertime.txtMonthYear.Text.Trim
            Cry.DataDefinition.FormulaFields("cMonthly").Text = "'" & cHead.Trim & "'"

            Dim RptFormular As String = ""
            Dim Start As Boolean = False
            RptFormular = "{TimeOvertime.Month_Year} = '" & fReportOvertime.txtMonthYear.Text.Trim & "' and " & _
                            " ({TimeOvertime.OT1} <> 0 Or {TimeOvertime.OT15} <> 0 Or {TimeOvertime.OT3} <> 0)"

            If fReportOvertime.cboSite.Text.Trim <> "" Then
                RptFormular &= " and {Emp.Workingplace} = '" & fReportOvertime.cboSite.Text.Trim & "'"
            End If

            If fReportOvertime.txtCode.Text.Trim <> "" Then
                RptFormular &= " and {Emp.Code} = '" & fReportOvertime.txtCode.Text.Trim & "'"
            End If

            If fReportOvertime.cboDepartment.Text.Trim <> "" Then
                RptFormular &= " and {Emp.DeptId} = '" & fReportOvertime.lblDeptId.Text.Trim & "'"
            End If

            If fReportOvertime.cboPosition.Text.Trim <> "" Then
                RptFormular &= " and {Emp.Position} = '" & fReportOvertime.cboPosition.Text.Trim & "'"
            End If
            Cry.DataDefinition.RecordSelectionFormula = RptFormular
            Me.Text = "Overtime Report"
            CrystalReportViewer1.ReportSource = Cry
            'CrystalReportViewer1.RefreshReport()
            Exit Sub
        End If

        If ReportPrint = Report.PrintAllowance Then
            Dim Cry As New rptAllowance
            Cry.SetDatabaseLogon(sysUsername, sysPassword)
            Dim cHead As String
            cHead = "Monthly " & fReportAllowance.txtMonthYear.Text.Trim
            Cry.DataDefinition.FormulaFields("cMonthly").Text = "'" & cHead.Trim & "'"

            Dim RptFormular As String = ""
            Dim Start As Boolean = False
            RptFormular = "{TimeAllowance.Month_Year} = '" & fReportAllowance.txtMonthYear.Text.Trim & "'"

            If fReportAllowance.cboSite.Text.Trim <> "" Then
                RptFormular &= " and {Emp.Workingplace} = '" & fReportAllowance.cboSite.Text.Trim & "'"
            End If

            If fReportAllowance.txtCode.Text.Trim <> "" Then
                RptFormular &= " and {Emp.Code} = '" & fReportAllowance.txtCode.Text.Trim & "'"
            End If

            If fReportAllowance.cboDepartment.Text.Trim <> "" Then
                RptFormular &= " and {Emp.DeptId} = '" & fReportAllowance.lblDeptId.Text.Trim & "'"
            End If

            If fReportAllowance.cboPosition.Text.Trim <> "" Then
                RptFormular &= " and {Emp.Position} = '" & fReportAllowance.cboPosition.Text.Trim & "'"
            End If
            Cry.DataDefinition.RecordSelectionFormula = RptFormular
            Me.Text = "Allowance Report"
            CrystalReportViewer1.ReportSource = Cry
            'CrystalReportViewer1.RefreshReport()
            Exit Sub
        End If

        If ReportPrint = Report.PrintSumary Then
            Dim Cry As New rptSumary
            Cry.SetDatabaseLogon(sysUsername, sysPassword)

            Cry.SetParameterValue("@Month_Year", fReportSumary.txtMonthYear.Text.Trim)

            Dim cHead As String
            cHead = "Monthly " & fReportSumary.txtMonthYear.Text.Trim
            Cry.DataDefinition.FormulaFields("cMonthly").Text = "'" & cHead.Trim & "'"

            Dim RptFormular As String = ""
            Dim Start As Boolean = False
            RptFormular = "1 = 1"

            If fReportSumary.cboSite.Text.Trim <> "" Then
                RptFormular &= " and {spTimeSumary;1.Workingplace} = '" & fReportSumary.cboSite.Text.Trim & "'"
            End If

            If fReportSumary.txtCode.Text.Trim <> "" Then
                RptFormular &= " and {spTimeSumary;1.Code} = '" & fReportSumary.txtCode.Text.Trim & "'"
            End If

            If fReportSumary.cboDepartment.Text.Trim <> "" Then
                RptFormular &= " and {spTimeSumary;1.DeptId} = '" & fReportSumary.lblDeptId.Text.Trim & "'"
            End If

            If fReportSumary.cboPosition.Text.Trim <> "" Then
                RptFormular &= " and {spTimeSumary;1.Position} = '" & fReportSumary.cboPosition.Text.Trim & "'"
            End If
            Cry.DataDefinition.RecordSelectionFormula = RptFormular
            Me.Text = "Sumary Report"
            CrystalReportViewer1.ReportSource = Cry
            'CrystalReportViewer1.RefreshReport()
            Exit Sub
        End If

        If ReportPrint = Report.PrintMonthlySumary Then
            Dim Cry As New rptSumaryMonth
            Cry.SetDatabaseLogon(sysUsername, sysPassword)

            Cry.SetParameterValue("@MonthYear", fReportMonthlySumary.txtMonthYear.Text.Trim)

            'Me.Text = "สรุปยอดประจำเดือน"
            Me.Text = MsgManager.ShowLabel(Me, "HTFReportForm", "HTFrptSumary")
            CrystalReportViewer1.ReportSource = Cry
            'CrystalReportViewer1.RefreshReport()
            Exit Sub
        End If


        'รายงานสรุปขาด -  ลา------------------------------------------------------------------------------------
        If ReportPrint = Report.PrintSumAbsLateByMonth Then
            Dim Cry As New rptTimeSumAbsLateByMonth
            Cry.SetDatabaseLogon(sysUsername, sysPassword)

            '   Dim Head_Dept As String
            Dim Head_Date As String = ""
            Dim RptFormular As String = ""

            With fRptTimeSumAbsentLate
                Cry.SetParameterValue("@DateST", ConvertDate(.txtDateSt.Text.Trim))
                Cry.SetParameterValue("@DateSP", ConvertDate(.txtDateSp.Text.Trim))

                Head_Date = Replace(MsgManager.ShowLabel(Me, "rptTimeSumAbsLateByMonthRS", "Head_Date") _
                & .cboMonth.Text.Trim & " " & .txtYear.Text.Trim & " ( " & .txtDateSt.Text.Trim & " - " _
                & .txtDateSp.Text.Trim & " )", "'", "")
              

                '    Cry.DataDefinition.FormulaFields("Head_Dept").Text = "'" & Head_Dept & "'"
                Cry.DataDefinition.FormulaFields("Head_Date").Text = "'" & Head_Date & "'"
            End With

            RptFormular = " 1 = 1"

            If fRptTimeSumAbsentLate.txtCode1.Text <> "" Then  ' ค้นหาตามรหัส

                RptFormular &= " And {spTimeRPT_AbsentLate_Bath;1.Code}='" & fRptTimeSumAbsentLate.txtCode1.Text.Trim & "'"
            ElseIf fRptTimeSumAbsentLate.txtNameSearch.Text <> "" Then  ' ค้นหาตามชื่อ
                RptFormular &= " And {spTimeRPT_AbsentLate_Bath;1.fname} like '*" & fRptTimeSumAbsentLate.txtNameSearch.Text.Trim & "*'"
            Else

                If fRptTimeSumAbsentLate.cboCompany.SelectedIndex > 0 Then ' ถ้าไม่เลือกบริษัททั้งหมด
                    Dim Company_Id As String
                    Company_Id = GetData.GetCompanyId(fRptTimeSumAbsentLate.cboCompany.Text) ' หา รหัส Id ของ Company_Sub
                    RptFormular &= " And {spTimeRPT_AbsentLate_Bath;1.CompanyID} = '" & Company_Id.Trim & "'"
                End If

                If fRptTimeSumAbsentLate.cboDivision.SelectedIndex > 0 Then ' ถ้าเลือกฝ่ายทั้งหมด
                    Dim Division_Id As String = ""
                    Division_Id = GetData.GetDivisionId(fRptTimeSumAbsentLate.cboDivision.Text) ' หา รหัส ฝ่าย
                    RptFormular &= " And  {spTimeRPT_AbsentLate_Bath;1.DivId} = '" & Division_Id.Trim & "'"
                End If

                If fRptTimeSumAbsentLate.cboDepartment.SelectedIndex > 0 Then ' ถ้าเลือกแผนก ทั้งหมด
                    Dim Department_Id As String = ""
                    Department_Id = GetData.GetDepartmentId(fRptTimeSumAbsentLate.cboDepartment.Text) ' หาแผนก
                    RptFormular &= " And   {spTimeRPT_AbsentLate_Bath;1.DeptId}='" & Department_Id.Trim & "'"
                End If

                If fRptTimeSumAbsentLate.cboPosition.SelectedIndex > 0 Then ' ถ้าเลือกตำแหน่งทั้งหมด
                    RptFormular &= " And  {spTimeRPT_AbsentLate_Bath;1.Position}='" & fRptTimeSumAbsentLate.cboPosition.Text.Trim & "'"
                End If

                If fRptTimeSumAbsentLate.cboEmpGroup.SelectedIndex > 0 Then ' ถ้าเลือกกลุ่มทั้งหมด
                    Dim EmpGroup_Id As String = ""
                    EmpGroup_Id = GetData.GetEmpGroupId(fRptTimeSumAbsentLate.cboEmpGroup.Text.Trim)  ' หากลุ่ม
                    RptFormular &= " And  {spTimeRPT_AbsentLate_Bath;1.GroupId}='" & EmpGroup_Id.Trim & "'"
                End If


                If fRptTimeSumAbsentLate.rdMonth.Checked = True Then ' เลือกรายเดือน
                    RptFormular &= " And {spTimeRPT_AbsentLate_Bath;1.WageType}='M'"
                End If

                If fRptTimeSumAbsentLate.rdDay.Checked = True Then ' เลือกทั้งรายวัน
                    RptFormular &= " And {spTimeRPT_AbsentLate_Bath;1.WageType}='D'"
                End If

                If fRptTimeSumAbsentLate.rdContractor.Checked = True Then ' เลือกรายเหมา
                    RptFormular &= " And {spTimeRPT_AbsentLate_Bath;1.WageType}='D' And {spTimeRPT_AbsentLate_Bath;1.Contractor}=True"
                End If
            End If

            Cry.DataDefinition.FormulaFields("Abs").Text = MsgManager.ShowLabel(Me, "rptTimeSumAbsLateByMonthRS", "Abs")
            Cry.DataDefinition.FormulaFields("Abs_B").Text = MsgManager.ShowLabel(Me, "rptTimeSumAbsLateByMonthRS", "Abs_B")
            'Cry.DataDefinition.FormulaFields("Head_Date").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_DetailRS", "Head_Date")
            Cry.DataDefinition.FormulaFields("Head_Dept").Text = MsgManager.ShowLabel(Me, "rptTimeSumAbsLateByMonthRS", "Head_Dept")
            Cry.DataDefinition.FormulaFields("ID").Text = MsgManager.ShowLabel(Me, "rptTimeSumAbsLateByMonthRS", "ID")
            Cry.DataDefinition.FormulaFields("Late_B").Text = MsgManager.ShowLabel(Me, "rptTimeSumAbsLateByMonthRS", "Late_B")
            Cry.DataDefinition.FormulaFields("Late_D").Text = MsgManager.ShowLabel(Me, "rptTimeSumAbsLateByMonthRS", "Late_D")
            Cry.DataDefinition.FormulaFields("LateOut").Text = MsgManager.ShowLabel(Me, "rptTimeSumAbsLateByMonthRS", "LateOut")
            Cry.DataDefinition.FormulaFields("LateOut_B").Text = MsgManager.ShowLabel(Me, "rptTimeSumAbsLateByMonthRS", "LateOut_B")
            Cry.DataDefinition.FormulaFields("Name_Last").Text = MsgManager.ShowLabel(Me, "rptTimeSumAbsLateByMonthRS", "Name_Last")
            Cry.DataDefinition.FormulaFields("rpt_head").Text = MsgManager.ShowLabel(Me, "rptTimeSumAbsLateByMonthRS", "rpt_head")
            Cry.DataDefinition.FormulaFields("Rec").Text = MsgManager.ShowLabel(Me, "rptTimeSumAbsLateByMonthRS", "Rec")
            Cry.DataDefinition.FormulaFields("Total_B").Text = MsgManager.ShowLabel(Me, "rptTimeSumAbsLateByMonthRS", "Total_B")
            Cry.DataDefinition.FormulaFields("Total_Text").Text = MsgManager.ShowLabel(Me, "rptTimeSumAbsLateByMonthRS", "Total_Text")

            Cry.DataDefinition.RecordSelectionFormula = RptFormular

            'Me.Text = "รายงานสรุปยอด สาย - ขาด (บาท) รายเดือน"
            Me.Text = MsgManager.ShowLabel(Me, "HTFReportForm", "HTFrptTimeSumAbsLateByMonth")
            CrystalReportViewer1.ReportSource = Cry
            'CrystalReportViewer1.RefreshReport()
            Exit Sub
        End If


        'รายงานตารางเวลาการทำงาน-------------------------------------------------------------------------------------------------
        If ReportPrint = Report.PrintTimeTableByMonth Then
            Dim Cry As New rptTimeTableByMonth
            Cry.SetDatabaseLogon(sysUsername, sysPassword)

            Dim Head_Dept As String = ""
            Dim Head_Date As String = ""
            Dim RptFormular As String = ""

            With fRptTimeTableByMonth

                'If .rdByDept.Checked = True Then
                '    Head_Dept = "ตารางการทำงาน (" & .cboSite.Text.Trim & ")"
                '    RptFormular = "{Emp.WorkingPlace} = '" & .cboSite.Text.Trim & "'"
                'Else
                '    Head_Dept = "ตารางการทำงาน"
                '    RptFormular = ""
                'End If

                'Head_Date = MsgManager.ShowLabel(Me, "rptTimeTableByMonthRS", "Head_F_Month") & " " _
                '                & .cboMonth.Text.Trim & " " & MsgManager.ShowLabel(Me, "rptTimeTableByMonthRS", "Head_F_Month2") & _
                '                 CInt(LeftText(.txtDateSt.Text.Trim, 2)) & " " & _
                '                MonthName(Me, CInt(Mid(.txtDateSt.Text.Trim, 4, 2))) & " " & MsgManager.ShowLabel(Me, "MonthLang", "PS") & _
                '                CStr(CInt(RightText(.txtDateSt.Text.Trim, 4)) + CInt(YearName(Me))) & " - " & _
                '                CInt(LeftText(.txtDateSp.Text.Trim, 2)) & " " & _
                '                MonthName(Me, CInt(Mid(.txtDateSp.Text.Trim, 4, 2))) & " " & MsgManager.ShowLabel(Me, "MonthLang", "PS") & _
                '                CStr(CInt(RightText(.txtDateSt.Text.Trim, 4)) + CInt(YearName(Me)))

                'Head_Date = Format(CDate(ConvertDate(.txtDateSt.Text)), "dd MMMM yyyy") & " - " &
                '            Format(CDate(ConvertDate(.txtDateSp.Text)), "dd MMMM yyyy")
                Head_Date = .txtDateSt.Text & " - " &
                            .txtDateSp.Text
                'RightText(.txtDateSp.Text.Trim, 4)

                Cry.DataDefinition.FormulaFields("CompanyName").Text = "'" & GetCompanyName.Trim & "'"
                Cry.DataDefinition.FormulaFields("Head_Site").Text = "'" & Head_Dept & "'"
                Cry.DataDefinition.FormulaFields("Head_F_Month").Text = "'" & Head_Date & "'"
                Cry.DataDefinition.FormulaFields("H_Month").Text = "'" & .cboMonth.Text.Trim & "'"


                Cry.DataDefinition.FormulaFields("Abs").Text = MsgManager.ShowLabel(Me, "rptTimeTableByMonthRS", "Abs")
                Cry.DataDefinition.FormulaFields("Come").Text = MsgManager.ShowLabel(Me, "rptTimeTableByMonthRS", "Come")
                Cry.DataDefinition.FormulaFields("ID").Text = MsgManager.ShowLabel(Me, "rptTimeTableByMonthRS", "ID")
                Cry.DataDefinition.FormulaFields("Name_Last").Text = MsgManager.ShowLabel(Me, "rptTimeTableByMonthRS", "Name_Last")
                Cry.DataDefinition.FormulaFields("Rec").Text = MsgManager.ShowLabel(Me, "rptTimeTableByMonthRS", "Rec")
                Cry.DataDefinition.FormulaFields("Remark").Text = MsgManager.ShowLabel(Me, "rptTimeTableByMonthRS", "Remark")


            End With


            RptFormular = 1 = "1"

            If fRptTimeTableByMonth.txtEmpId.Text <> "" Then  ' ค้นหาตามรหัส

                RptFormular &= " And {RPT_TimeTableByMonthAllEmp.Code}='" & fRptTimeTableByMonth.txtEmpId.Text.Trim & "'"
            ElseIf fRptTimeTableByMonth.txtNameSearch.Text <> "" Then  ' ค้นหาตามชื่อ
                RptFormular &= " And {Emp.fname} like '*" & fRptTimeTableByMonth.txtNameSearch.Text.Trim & "*'"
            Else

                If fRptTimeTableByMonth.cboCompany.SelectedIndex > 0 Then ' ถ้าไม่เลือกบริษัททั้งหมด
                    Dim Company_Id As String
                    Company_Id = GetData.GetCompanyId(fRptTimeTableByMonth.cboCompany.Text) ' หา รหัส Id ของ Company_Sub
                    RptFormular &= " And {Emp.CompanyID} = '" & Company_Id.Trim & "'"
                End If

                If fRptTimeTableByMonth.cboDivision.SelectedIndex > 0 Then ' ถ้าเลือกฝ่ายทั้งหมด
                    Dim Division_Id As String = ""
                    Division_Id = GetData.GetDivisionId(fRptTimeTableByMonth.cboDivision.Text) ' หา รหัส ฝ่าย
                    RptFormular &= " And  {Emp.DivId} = '" & Division_Id.Trim & "'"
                End If

                If fRptTimeTableByMonth.cboDepartment.SelectedIndex > 0 Then ' ถ้าเลือกแผนก ทั้งหมด
                    Dim Department_Id As String = ""
                    Department_Id = GetData.GetDepartmentId(fRptTimeTableByMonth.cboDepartment.Text) ' หาแผนก
                    RptFormular &= " And   {Emp.DeptId}='" & Department_Id.Trim & "'"
                End If

                If fRptTimeTableByMonth.cboSection.SelectedIndex > 0 Then ' ส่วน
                    Dim Section_Id As String = ""
                    Section_Id = GetData.GetSectionID(fRptTimeTableByMonth.cboSection.Text) ' หารหัสส่วน
                    RptFormular &= " And   {Emp.SecId}='" & Section_Id.Trim & "'"
                End If

                If fRptTimeTableByMonth.cboPosition.SelectedIndex > 0 Then ' ถ้าเลือกตำแหน่งทั้งหมด
                    RptFormular &= " And  {Emp.Position}='" & fRptTimeTableByMonth.cboPosition.Text.Trim & "'"
                End If

                If fRptTimeTableByMonth.cboEmpGroup.SelectedIndex > 0 Then ' ถ้าเลือกกลุ่มทั้งหมด
                    Dim EmpGroup_Id As String = ""
                    EmpGroup_Id = GetData.GetEmpGroupId(fRptTimeTableByMonth.cboEmpGroup.Text.Trim)  ' หากลุ่ม
                    RptFormular &= " And  {Emp.GroupId}='" & EmpGroup_Id.Trim & "'"
                End If

                If fRptTimeTableByMonth.cboBroker.SelectedIndex > 0 Then ' สายรถ
                    Dim Broker_Id As String = ""
                    Broker_Id = GetData.GetBrokerId(fRptTimeTableByMonth.cboBroker.Text.Trim)  ' หาสายรถ
                    RptFormular &= " And  {Emp.Brokerid}='" & Broker_Id.Trim & "'"
                End If


                If fRptTimeTableByMonth.rdMonth.Checked = True Then ' เลือกรายเดือน
                    RptFormular &= " And {Emp.WageType}='M'"
                End If

                If fRptTimeTableByMonth.rdDay.Checked = True Then ' เลือกทั้งรายวัน
                    RptFormular &= " And {Emp.WageType}='D'"
                End If

                If fRptTimeTableByMonth.rdContractor.Checked = True Then ' เลือกรายเหมา
                    RptFormular &= " And {Emp.WageType}='D' And {Emp.Contractor}=True"
                End If
            End If


            Cry.DataDefinition.RecordSelectionFormula = RptFormular
            Me.Text = MsgManager.ShowLabel(Me, "HTFReportForm", "HTFrptTimeTableByMonth")
            'Me.Text = "รายงานตารางการทำงาน"
            CrystalReportViewer1.ReportSource = Cry
            'CrystalReportViewer1.RefreshReport()
            Exit Sub
        End If


        'รายงานตารางทำงานของพนักงานแบบสรุป ----------------------------------------------------------------------------
        If ReportPrint = Report.PrintTimeworkSumary Then
            Dim Cry As New cryTimeworkSummarize
            Dim Rptformular As String = ""
            Cry.SetDatabaseLogon(sysUsername, sysPassword)
            'ConvertDate(fRptWageSumary.txtDateStart.Text)

            Dim Da As New SqlDataAdapter
            Dim Ds As New DataSet
            Dim StrSql As String
            Dim VC As String = ""
            Dim VCC As String = ""

            StrSql = "select vCalType1,vCalType2,vCalType3,vCalType4,vCalType5,vCalType6,vCalType7,vCalType8,absCalType " & _
                        " from RPT_TimeworkSumarize_Config"
            Da = New SqlDataAdapter(StrSql, Conn)
            Da.Fill(Ds, "data")
            With Ds.Tables("data")
                If .Rows.Count = 0 Then
                    'Return
                    For i As Integer = 1 To 8
                        VCC = "vCal" & CStr(i) & "C"
                        Cry.DataDefinition.FormulaFields(VCC).Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Min")
                    Next

                    Cry.DataDefinition.FormulaFields("absCalc").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Hour")

                Else

                    Dim dr As DataRow = .Rows(0)

                    For i As Integer = 1 To 8
                        VC = "vCalType" & CStr(i)
                        VCC = "vCal" & CStr(i) & "C"

                        If dr(VC) = "D" Then
                            Cry.DataDefinition.FormulaFields(VCC).Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Day")
                        ElseIf dr(VC) = "H" Then
                            Cry.DataDefinition.FormulaFields(VCC).Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Hour")
                        Else
                            Cry.DataDefinition.FormulaFields(VCC).Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Min")
                        End If

                    Next
                    If dr("absCalType") = "D" Then
                        Cry.DataDefinition.FormulaFields("absCalc").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Day")
                    Else
                        Cry.DataDefinition.FormulaFields("absCalc").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Hour")
                    End If

                End If
            End With

            Dim Type As String = ""
            With fRptTimeWorkSumary



                Cry.DataDefinition.FormulaFields("DateST").Text = "'" & Format(.txtDateStart.Value, "dd/MM/yyyy") & "'"
                Cry.DataDefinition.FormulaFields("DateSP").Text = "'" & Format(.txtDateStop.Value, "dd/MM/yyyy") & "'"
                Cry.DataDefinition.FormulaFields("Section").Text = "'" & .cboSection.Text & "'"
                Cry.DataDefinition.FormulaFields("Department").Text = "'" & .cboDepartment.Text & "'"
                Cry.DataDefinition.FormulaFields("Division").Text = "'" & .cboDivision.Text & "'"
                Cry.DataDefinition.FormulaFields("CompanyName").Text = "'" & GetCompanyName.Trim & "'"


                Cry.DataDefinition.FormulaFields("Amt").Text = MsgManager.ShowLabel(Me, "cryTimeworkSummarizeRS", "Amt")
                Cry.DataDefinition.FormulaFields("Col").Text = MsgManager.ShowLabel(Me, "cryTimeworkSummarizeRS", "Col")
                Cry.DataDefinition.FormulaFields("Date_To").Text = MsgManager.ShowLabel(Me, "cryTimeworkSummarizeRS", "Date_To")
                Cry.DataDefinition.FormulaFields("Dep").Text = MsgManager.ShowLabel(Me, "cryTimeworkSummarizeRS", "Dep")
                Cry.DataDefinition.FormulaFields("Div").Text = MsgManager.ShowLabel(Me, "cryTimeworkSummarizeRS", "Div")
                Cry.DataDefinition.FormulaFields("Day").Text = MsgManager.ShowLabel(Me, "cryTimeworkSummarizeRS", "Day")
                Cry.DataDefinition.FormulaFields("ID").Text = MsgManager.ShowLabel(Me, "cryTimeworkSummarizeRS", "ID")
                Cry.DataDefinition.FormulaFields("Emp").Text = MsgManager.ShowLabel(Me, "cryTimeworkSummarizeRS", "Emp")
                Cry.DataDefinition.FormulaFields("Emp_Amt").Text = MsgManager.ShowLabel(Me, "cryTimeworkSummarizeRS", "Emp_Amt")
                Cry.DataDefinition.FormulaFields("Late").Text = MsgManager.ShowLabel(Me, "cryTimeworkSummarizeRS", "Late")
                Cry.DataDefinition.FormulaFields("kon").Text = MsgManager.ShowLabel(Me, "cryTimeworkSummarizeRS", "kon")
                Cry.DataDefinition.FormulaFields("Min").Text = MsgManager.ShowLabel(Me, "cryTimeworkSummarizeRS", "Min")
                Cry.DataDefinition.FormulaFields("Name_Last").Text = MsgManager.ShowLabel(Me, "cryTimeworkSummarizeRS", "Name_Last")
                Cry.DataDefinition.FormulaFields("rpt_head_strat").Text = MsgManager.ShowLabel(Me, "cryTimeworkSummarizeRS", "rpt_head_strat")
                Cry.DataDefinition.FormulaFields("Sec").Text = MsgManager.ShowLabel(Me, "cryTimeworkSummarizeRS", "Sec")
                Cry.DataDefinition.FormulaFields("T_Time").Text = MsgManager.ShowLabel(Me, "cryTimeworkSummarizeRS", "T_Time")
                Cry.DataDefinition.FormulaFields("Work").Text = MsgManager.ShowLabel(Me, "cryTimeworkSummarizeRS", "Work")


                Cry.Refresh()
            End With

            Rptformular = 1 = "1"

            If fRptTimeWorkSumary.txtEmpId.Text <> "" Then  ' ค้นหาตามรหัส

                Rptformular &= " And {Rpt_timeworksumarize.Code}='" & fRptTimeWorkSumary.txtEmpId.Text.Trim & "'"
            ElseIf fRptTimeWorkSumary.txtNameSearch.Text <> "" Then  ' ค้นหาตามชื่อ
                Rptformular &= " And {Emp.fname} like '*" & fRptTimeWorkSumary.txtNameSearch.Text.Trim & "*'"
            Else

                If fRptTimeWorkSumary.cboCompany.SelectedIndex > 0 Then ' ถ้าไม่เลือกบริษัททั้งหมด
                    Dim Company_Id As String
                    Company_Id = GetData.GetCompanyId(fRptTimeWorkSumary.cboCompany.Text) ' หา รหัส Id ของ Company_Sub
                    Rptformular &= " And {Emp.CompanyID} = '" & Company_Id.Trim & "'"
                End If

                If fRptTimeWorkSumary.cboDivision.SelectedIndex > 0 Then ' ถ้าเลือกฝ่ายทั้งหมด
                    Dim Division_Id As String = ""
                    Division_Id = GetData.GetDivisionId(fRptTimeWorkSumary.cboDivision.Text) ' หา รหัส ฝ่าย
                    Rptformular &= " And  {Emp.DivId} = '" & Division_Id.Trim & "'"
                End If

                If fRptTimeWorkSumary.cboDepartment.SelectedIndex > 0 Then ' ถ้าเลือกแผนก ทั้งหมด
                    Dim Department_Id As String = ""
                    Department_Id = GetData.GetDepartmentId(fRptTimeWorkSumary.cboDepartment.Text) ' หาแผนก
                    Rptformular &= " And   {Emp.DeptId}='" & Department_Id.Trim & "'"
                End If

                If fRptTimeWorkSumary.cboSection.SelectedIndex > 0 Then ' ส่วน
                    Dim Section_Id As String = ""
                    Section_Id = GetData.GetSectionID(fRptTimeWorkSumary.cboSection.Text) ' หารหัสส่วน
                    Rptformular &= " And   {Emp.SecId}='" & Section_Id.Trim & "'"
                End If

                If fRptTimeWorkSumary.cboPosition.SelectedIndex > 0 Then ' ถ้าเลือกตำแหน่งทั้งหมด
                    Rptformular &= " And  {Emp.Position}='" & fRptTimeWorkSumary.cboPosition.Text.Trim & "'"
                End If

                If fRptTimeWorkSumary.cboEmpGroup.SelectedIndex > 0 Then ' ถ้าเลือกกลุ่มทั้งหมด
                    Dim EmpGroup_Id As String = ""
                    EmpGroup_Id = GetData.GetEmpGroupId(fRptTimeWorkSumary.cboEmpGroup.Text.Trim)  ' หากลุ่ม
                    Rptformular &= " And  {Emp.GroupId}='" & EmpGroup_Id.Trim & "'"
                End If

                If fRptTimeWorkSumary.cboBroker.SelectedIndex > 0 Then ' สายรถ
                    Dim Broker_Id As String = ""
                    Broker_Id = GetData.GetBrokerId(fRptTimeWorkSumary.cboBroker.Text.Trim)  ' หาสายรถ
                    Rptformular &= " And  {Emp.Brokerid}='" & Broker_Id.Trim & "'"
                End If


                If fRptTimeWorkSumary.rdMonth.Checked = True Then ' เลือกรายเดือน
                    Rptformular &= " And {Emp.WageType}='M'"
                End If

                If fRptTimeWorkSumary.rdDay.Checked = True Then ' เลือกทั้งรายวัน
                    Rptformular &= " And {Emp.WageType}='D'"
                End If

                If fRptTimeWorkSumary.rdContractor.Checked = True Then ' เลือกรายเหมา
                    Rptformular &= " And {Emp.WageType}='D' And {Emp.Contractor}=True"
                End If
            End If


            Cry.DataDefinition.RecordSelectionFormula = Rptformular
            CrystalReportViewer1.ReportSource = Cry
            'Me.Text = "รายงานการทำงานของพนักงาน(แบบสรุป)"
            Me.Text = MsgManager.ShowLabel(Me, "HTFReportForm", "HTFcryTimeworkSummarize")
            Exit Sub
        End If


        'รายงานพนักงานไม่มาทำงาน------------------------------------------------------------------------------------------
        If ReportPrint = Report.PrintTimeAbsent Then
            Dim Cry As New cryTimeAbsent
            Cry.SetDatabaseLogon(sysUsername, sysPassword)
            'ConvertDate(fRptWageSumary.txtDateStart.Text)
            Dim HType As String = fRPT_TimeAbsent.HType


            Dim Type As String = ""
            With fRPT_TimeAbsent
                Cry.DataDefinition.FormulaFields("Abs").Text = MsgManager.ShowLabel(Me, "cryTimeAbsentRS", "Abs")
                Cry.DataDefinition.FormulaFields("Date_To").Text = MsgManager.ShowLabel(Me, "cryTimeAbsentRS", "Date_To")
                Cry.DataDefinition.FormulaFields("rpt_head").Text = MsgManager.ShowLabel(Me, "cryTimeAbsentRS", "rpt_head")
                Cry.DataDefinition.FormulaFields("Datestart").Text = MsgManager.ShowLabel(Me, "cryTimeAbsentRS", "Datestart")
                Cry.DataDefinition.FormulaFields("Emp_Abs").Text = MsgManager.ShowLabel(Me, "cryTimeAbsentRS", "Emp_Abs")
                Cry.DataDefinition.FormulaFields("Emp_Amt").Text = MsgManager.ShowLabel(Me, "cryTimeAbsentRS", "Emp_Amt")
                Cry.DataDefinition.FormulaFields("Per_Emp_abs").Text = MsgManager.ShowLabel(Me, "cryTimeAbsentRS", "Per_Emp_abs")
                Cry.DataDefinition.FormulaFields("DateST").Text = "'" & Format(.txtDateStart.Value, "dd/MM/yyyy") & "'"
                Cry.DataDefinition.FormulaFields("DateSP").Text = "'" & Format(.txtDateStop.Value, "dd/MM/yyyy") & "'"
                Cry.DataDefinition.FormulaFields("DDSName").Text = "'" & HType & "'"
                Cry.Refresh()

            End With

            CrystalReportViewer1.ReportSource = Cry
            Me.Text = MsgManager.ShowLabel(Me, "HTFReportForm", "HTFcryTimeAbsent")
            'Me.Text = "จำนวนพนักงานไม่มาทำงาน"
            Exit Sub
        End If


        ' รายงาน่ขาดลา ของพนักงานแบบสรุป ข--------------------------------------------------------------------
        If ReportPrint = Report.PrintTimeAbsLate Then
            Dim Cry As New cryTimeAbsLate
            Dim RptFormular As String = ""
            Cry.SetDatabaseLogon(sysUsername, sysPassword)
            'ConvertDate(fRptWageSumary.txtDateStart.Text)



            Dim Type As String = ""
            With fRPT_TimeAbLate

                Dim Da As New SqlDataAdapter
                Dim Ds As New DataSet
                Dim StrSql As String
                Dim VC As String = ""
                Dim VCC As String = ""

                StrSql = "select vCType1,vCType2,vCType3,vCType4,vCType5,vCType6,vCType7,vCType8,vCType9,vCType10,absCType " & _
                            " from RPT_TimeAbsLate_Config"
                Da = New SqlDataAdapter(StrSql, Conn)
                Da.Fill(Ds, "data")
                With Ds.Tables("data")
                    If .Rows.Count = 0 Then
                        'Return
                        For i As Integer = 1 To 10
                            VCC = "vCal" & CStr(i) & "C"
                            Cry.DataDefinition.FormulaFields(VCC).Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Min")
                        Next

                        Cry.DataDefinition.FormulaFields("absCalc").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Hour")

                    Else

                        Dim dr As DataRow = .Rows(0)

                        For i As Integer = 1 To 10
                            VC = "vCType" & CStr(i)
                            VCC = "vCal" & CStr(i) & "C"

                            If dr(VC) = "D" Then
                                Cry.DataDefinition.FormulaFields(VCC).Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Day")
                            ElseIf dr(VC) = "H" Then
                                Cry.DataDefinition.FormulaFields(VCC).Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Hour")
                            Else
                                Cry.DataDefinition.FormulaFields(VCC).Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Min")
                            End If

                        Next
                        If dr("absCType") = "D" Then
                            Cry.DataDefinition.FormulaFields("absCalc").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Day")
                        Else
                            Cry.DataDefinition.FormulaFields("absCalc").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Hour")
                        End If

                    End If
                End With

                Cry.DataDefinition.FormulaFields("DateST").Text = "'" & Format(.txtDateStart.Value, "dd/MM/yyyy") & "'"
                Cry.DataDefinition.FormulaFields("DateSP").Text = "'" & Format(.txtDateStop.Value, "dd/MM/yyyy") & "'"
                Cry.DataDefinition.FormulaFields("Section").Text = "'" & .cboSection.Text & "'"
                Cry.DataDefinition.FormulaFields("Department").Text = "'" & .cboDepartment.Text & "'"
                Cry.DataDefinition.FormulaFields("Division").Text = "'" & .cboDivision.Text & "'"
                Cry.DataDefinition.FormulaFields("CompanyName").Text = "'" & GetCompanyName.Trim & "'"

                Cry.DataDefinition.FormulaFields("rpt_head").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "rpt_head")
                Cry.DataDefinition.FormulaFields("Sec").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Sec")
                Cry.DataDefinition.FormulaFields("Dep").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Dep")
                Cry.DataDefinition.FormulaFields("Div").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Div")
                Cry.DataDefinition.FormulaFields("Date_To").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Date_To")
                Cry.DataDefinition.FormulaFields("Rec").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Rec")
                Cry.DataDefinition.FormulaFields("ID").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "ID")
                Cry.DataDefinition.FormulaFields("Name_Last").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Name_Last")
                Cry.DataDefinition.FormulaFields("Work").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Work")
                Cry.DataDefinition.FormulaFields("Vac").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Vac")
                Cry.DataDefinition.FormulaFields("Late").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Late")
                Cry.DataDefinition.FormulaFields("Emp").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Emp")
                Cry.DataDefinition.FormulaFields("Day").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Day")
                Cry.DataDefinition.FormulaFields("Amt").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Amt")
                Cry.DataDefinition.FormulaFields("Min").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Min")
                Cry.DataDefinition.FormulaFields("Avg").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Avg")
                Cry.DataDefinition.FormulaFields("Emp_Amt").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "Emp_Amt")
                Cry.DataDefinition.FormulaFields("kon").Text = MsgManager.ShowLabel(Me, "cryTimeAbsLateRS", "kon")
                Cry.Refresh()
            End With


            RptFormular = 1 = "1"

            If fRPT_TimeAbLate.txtEmpId.Text <> "" Then  ' ค้นหาตามรหัส

                RptFormular &= " And {rpt_timeabslate.Code}='" & fRPT_TimeAbLate.txtEmpId.Text.Trim & "'"
            ElseIf fRPT_TimeAbLate.txtNameSearch.Text <> "" Then  ' ค้นหาตามชื่อ
                RptFormular &= " And {Emp.fname} like '*" & fRPT_TimeAbLate.txtNameSearch.Text.Trim & "*'"
            Else

                If fRPT_TimeAbLate.cboCompany.SelectedIndex > 0 Then ' ถ้าไม่เลือกบริษัททั้งหมด
                    Dim Company_Id As String
                    Company_Id = GetData.GetCompanyId(fRPT_TimeAbLate.cboCompany.Text) ' หา รหัส Id ของ Company_Sub
                    RptFormular &= " And {Emp.CompanyID} = '" & Company_Id.Trim & "'"
                End If

                If fRPT_TimeAbLate.cboDivision.SelectedIndex > 0 Then ' ถ้าเลือกฝ่ายทั้งหมด
                    Dim Division_Id As String = ""
                    Division_Id = GetData.GetDivisionId(fRPT_TimeAbLate.cboDivision.Text) ' หา รหัส ฝ่าย
                    RptFormular &= " And  {Emp.DivId} = '" & Division_Id.Trim & "'"
                End If

                If fRPT_TimeAbLate.cboDepartment.SelectedIndex > 0 Then ' ถ้าเลือกแผนก ทั้งหมด
                    Dim Department_Id As String = ""
                    Department_Id = GetData.GetDepartmentId(fRPT_TimeAbLate.cboDepartment.Text) ' หาแผนก
                    RptFormular &= " And   {Emp.DeptId}='" & Department_Id.Trim & "'"
                End If

                If fRPT_TimeAbLate.cboSection.SelectedIndex > 0 Then ' ส่วน
                    Dim Section_Id As String = ""
                    Section_Id = GetData.GetSectionID(fRPT_TimeAbLate.cboSection.Text) ' หารหัสส่วน
                    RptFormular &= " And   {Emp.SecId}='" & Section_Id.Trim & "'"
                End If

                If fRPT_TimeAbLate.cboPosition.SelectedIndex > 0 Then ' ถ้าเลือกตำแหน่งทั้งหมด
                    RptFormular &= " And  {Emp.Position}='" & fRPT_TimeAbLate.cboPosition.Text.Trim & "'"
                End If

                If fRPT_TimeAbLate.cboEmpGroup.SelectedIndex > 0 Then ' ถ้าเลือกกลุ่มทั้งหมด
                    Dim EmpGroup_Id As String = ""
                    EmpGroup_Id = GetData.GetEmpGroupId(fRPT_TimeAbLate.cboEmpGroup.Text.Trim)  ' หากลุ่ม
                    RptFormular &= " And  {Emp.GroupId}='" & EmpGroup_Id.Trim & "'"
                End If

                If fRPT_TimeAbLate.cboBroker.SelectedIndex > 0 Then ' สายรถ
                    Dim Broker_Id As String = ""
                    Broker_Id = GetData.GetBrokerId(fRPT_TimeAbLate.cboBroker.Text.Trim)  ' หาสายรถ
                    RptFormular &= " And  {Emp.Brokerid}='" & Broker_Id.Trim & "'"
                End If


                If fRPT_TimeAbLate.rdMonth.Checked = True Then ' เลือกรายเดือน
                    RptFormular &= " And {Emp.WageType}='M'"
                End If

                If fRPT_TimeAbLate.rdDay.Checked = True Then ' เลือกทั้งรายวัน
                    RptFormular &= " And {Emp.WageType}='D'"
                End If

                If fRPT_TimeAbLate.rdContractor.Checked = True Then ' เลือกรายเหมา
                    RptFormular &= " And {Emp.WageType}='D' And {Emp.Contractor}=True"
                End If
            End If


            Cry.DataDefinition.RecordSelectionFormula = RptFormular


            CrystalReportViewer1.ReportSource = Cry
            'Me.Text = "รายงาน มาสาย/ลา/ขาด ของพนักงาน(แบบสรุป)"
            Me.Text = MsgManager.ShowLabel(Me, "HTFReportForm", "HTFcryTimeAbsLate")
            Exit Sub
        End If


        'รายงาน ชั่วโมง O.T. สูงสุด/วัน/สัปดาห์  ประจำปี -------------------------------------------------------------------------------------
        If ReportPrint = Report.PrintMaxOT Then
            Dim Cry As New cryRPT_MaxOT
            Dim Rptformular As String = ""

            Cry.SetDatabaseLogon(sysUsername, sysPassword)

            Dim Type As String = ""
            With fRPTMaxOT

                Cry.DataDefinition.FormulaFields("Day").Text = MsgManager.ShowLabel(Me, "cryRPT_MaxOTRS", "Day")
                Cry.DataDefinition.FormulaFields("Div").Text = MsgManager.ShowLabel(Me, "cryRPT_MaxOTRS", "Div")
                Cry.DataDefinition.FormulaFields("M1").Text = MsgManager.ShowLabel(Me, "cryRPT_MaxOTRS", "M1")
                Cry.DataDefinition.FormulaFields("M10").Text = MsgManager.ShowLabel(Me, "cryRPT_MaxOTRS", "M10")
                Cry.DataDefinition.FormulaFields("M11").Text = MsgManager.ShowLabel(Me, "cryRPT_MaxOTRS", "M11")
                Cry.DataDefinition.FormulaFields("M12").Text = MsgManager.ShowLabel(Me, "cryRPT_MaxOTRS", "M12")
                Cry.DataDefinition.FormulaFields("M2").Text = MsgManager.ShowLabel(Me, "cryRPT_MaxOTRS", "M2")
                Cry.DataDefinition.FormulaFields("M3").Text = MsgManager.ShowLabel(Me, "cryRPT_MaxOTRS", "M3")
                Cry.DataDefinition.FormulaFields("M4").Text = MsgManager.ShowLabel(Me, "cryRPT_MaxOTRS", "M4")
                Cry.DataDefinition.FormulaFields("M5").Text = MsgManager.ShowLabel(Me, "cryRPT_MaxOTRS", "M5")
                Cry.DataDefinition.FormulaFields("M6").Text = MsgManager.ShowLabel(Me, "cryRPT_MaxOTRS", "M6")
                Cry.DataDefinition.FormulaFields("M7").Text = MsgManager.ShowLabel(Me, "cryRPT_MaxOTRS", "M7")
                Cry.DataDefinition.FormulaFields("M8").Text = MsgManager.ShowLabel(Me, "cryRPT_MaxOTRS", "M8")
                Cry.DataDefinition.FormulaFields("M9").Text = MsgManager.ShowLabel(Me, "cryRPT_MaxOTRS", "M9")
                Cry.DataDefinition.FormulaFields("T_all").Text = MsgManager.ShowLabel(Me, "cryRPT_MaxOTRS", "T_all")
                Cry.DataDefinition.FormulaFields("T_work").Text = MsgManager.ShowLabel(Me, "cryRPT_MaxOTRS", "T_work")
                Cry.DataDefinition.FormulaFields("rpt_head").Text = MsgManager.ShowLabel(Me, "cryRPT_MaxOTRS", "rpt_head")
                Cry.DataDefinition.FormulaFields("Week").Text = MsgManager.ShowLabel(Me, "cryRPT_MaxOTRS", "Week")

                Cry.DataDefinition.FormulaFields("Year").Text = "'" & .cboYear.Text.Trim & "'"
                Cry.SetParameterValue("@Year", .cboYear.Text.Trim)

            End With

            Rptformular = 1 = "1"

            If fRPTMaxOT.cboDivision.SelectedIndex > 0 Then ' ถ้าเลือกฝ่าย
                Dim Division_Id As String = ""
                Division_Id = GetData.GetDivisionId(fRPTMaxOT.cboDivision.Text) ' หา รหัส ฝ่าย
                Rptformular &= " And  {spRPT_MaxOT;1.DivId} = '" & Division_Id.Trim & "'"
            End If

            If fRPTMaxOT.cboDepartment.SelectedIndex > 0 Then ' ถ้าเลือกแผนก
                Dim Department_Id As String = ""
                Department_Id = GetData.GetDepartmentId(fRPTMaxOT.cboDepartment.Text) ' หาแผนก
                Rptformular &= " And   {spRPT_MaxOT;1.DeptId}='" & Department_Id.Trim & "'"
            End If

            If fRPTMaxOT.cboSection.SelectedIndex > 0 Then ' ถ้าเลือกส่วน
                Dim Section_Id As String = ""
                Section_Id = GetData.GetSectionID(fRPTMaxOT.cboSection.Text) ' หาแผนก
                Rptformular &= " And   {spRPT_MaxOT;1.Secid}='" & Section_Id.Trim & "'"
            End If

            Cry.DataDefinition.RecordSelectionFormula = Rptformular

            CrystalReportViewer1.ReportSource = Cry
            'Me.Text = "รายงาน ชั่วโมง O.T. สูงสุด/วัน/สัปดาห์  ประจำปี"
            Me.Text = MsgManager.ShowLabel(Me, "HTFReportForm", "HTFcryRPT_MaxOT")
            Exit Sub
        End If



        'รายงานสรุปการหยุดงานประจำปี เดือน 1 - 6  -------------------------------------------------------------------------------------------------------------------------
        If ReportPrint = Report.PrintSummarizeVacationByYear1 Then
            Dim Cry As New cryRPT_SummarizeVacationByYear_Config
            Dim Rptformular As String = ""
            'Cry.SetDatabaseLogon(sysUsername, sysPassword)
            Cry.SetDatabaseLogon(sysUsername, sysPassword)

            Dim Type As String = ""
            With fRPT_SummarizeVacationByYear
                Dim Da As New SqlDataAdapter
                Dim Ds As New DataSet
                Dim StrSql As String

                StrSql = "select vCol1,vCol2,vCol3,vCol4,vCol5," & _
                                " vCalType1,vCalType2,vCalType3,vCalType4,vCalType5,absCalType " & _
                            " from RPT_SummarizeVacationByYear_Config"
                Da = New SqlDataAdapter(StrSql, Conn)
                Da.Fill(Ds, "data")
                With Ds.Tables("data")
                    If .Rows.Count = 0 Then
                        Return
                    Else
                        Dim dr As DataRow = .Rows(0)

                        Cry.DataDefinition.FormulaFields("C1").Text = "'" & dr("vCol1") & "'"
                        Cry.DataDefinition.FormulaFields("C2").Text = "'" & dr("vCol2") & "'"
                        Cry.DataDefinition.FormulaFields("C3").Text = "'" & dr("vCol3") & "'"
                        Cry.DataDefinition.FormulaFields("C4").Text = "'" & dr("vCol4") & "'"
                        Cry.DataDefinition.FormulaFields("C5").Text = "'" & dr("vCol5") & "'"

                        Cry.DataDefinition.FormulaFields("Type1").Text = "'" & IIf(dr("vCalType1").ToString.Trim = "H", "ชม.", "วัน") & "'"
                        Cry.DataDefinition.FormulaFields("Type2").Text = "'" & IIf(dr("vCalType2").ToString.Trim = "H", "ชม.", "วัน") & "'"
                        Cry.DataDefinition.FormulaFields("Type3").Text = "'" & IIf(dr("vCalType3").ToString.Trim = "H", "ชม.", "วัน") & "'"
                        Cry.DataDefinition.FormulaFields("Type4").Text = "'" & IIf(dr("vCalType4").ToString.Trim = "H", "ชม.", "วัน") & "'"
                        Cry.DataDefinition.FormulaFields("Type5").Text = "'" & IIf(dr("vCalType5").ToString.Trim = "H", "ชม.", "วัน") & "'"
                        Cry.DataDefinition.FormulaFields("Type6").Text = "'" & IIf(dr("absCalType").ToString.Trim = "H", "ชม.", "วัน") & "'"

                    End If
                End With

                Cry.DataDefinition.FormulaFields("rpt_head").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_ConfigRS", "rpt_head")
                Cry.DataDefinition.FormulaFields("Rec").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_ConfigRS", "Rec")
                Cry.DataDefinition.FormulaFields("ID").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_ConfigRS", "ID")
                Cry.DataDefinition.FormulaFields("Name_Last").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_ConfigRS", "Name_Last")
                Cry.DataDefinition.FormulaFields("Min").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_ConfigRS", "Min")
                Cry.DataDefinition.FormulaFields("Late").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_ConfigRS", "Late")
                Cry.DataDefinition.FormulaFields("Abs").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_ConfigRS", "Abs")
                Cry.DataDefinition.FormulaFields("M1").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_ConfigRS", "M1")
                Cry.DataDefinition.FormulaFields("M2").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_ConfigRS", "M2")
                Cry.DataDefinition.FormulaFields("M3").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_ConfigRS", "M3")
                Cry.DataDefinition.FormulaFields("M4").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_ConfigRS", "M4")
                Cry.DataDefinition.FormulaFields("M5").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_ConfigRS", "M5")
                Cry.DataDefinition.FormulaFields("M6").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_ConfigRS", "M6")
                Cry.DataDefinition.FormulaFields("Total").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_ConfigRS", "Total")
              


                Cry.DataDefinition.FormulaFields("Year").Text = "'" & .cboYear.Text.Trim & "'"
                Cry.SetParameterValue("@Year", .cboYear.Text.Trim)
            End With


            'Rptformular = 1 = "1"
            Rptformular = "1=1"

            If fRPT_SummarizeVacationByYear.txtCode1.Text <> "" Then  ' ค้นหาตามรหัส
                Rptformular &= " And {spRPT_SummarizeVacationByYear_Config;1.Code}='" & fRPT_SummarizeVacationByYear.txtCode1.Text.Trim & "'"
            ElseIf fRPT_SummarizeVacationByYear.txtNameSearch.Text <> "" Then  ' ค้นหาตามชื่อ
                Rptformular &= " And {spRPT_SummarizeVacationByYear_Config;1.fname} like '*" & fRPT_SummarizeVacationByYear.txtNameSearch.Text.Trim & "*'"
            Else

                If fRPT_SummarizeVacationByYear.cboCompany.SelectedIndex > 0 Then ' ถ้าไม่เลือกบริษัททั้งหมด
                    Dim Company_Id As String
                    Company_Id = GetData.GetCompanyId(fRPT_SummarizeVacationByYear.cboCompany.Text) ' หา รหัส Id ของ Company_Sub
                    Rptformular &= " And {spRPT_SummarizeVacationByYear_Config;1.CompanyID} = '" & Company_Id.Trim & "'"
                End If

                If fRPT_SummarizeVacationByYear.cboDivision.SelectedIndex > 0 Then ' ถ้าเลือกฝ่ายทั้งหมด
                    Dim Division_Id As String = ""
                    Division_Id = GetData.GetDivisionId(fRPT_SummarizeVacationByYear.cboDivision.Text) ' หา รหัส ฝ่าย
                    Rptformular &= " And  {spRPT_SummarizeVacationByYear_Config;1.DivId} = '" & Division_Id.Trim & "'"
                End If

                If fRPT_SummarizeVacationByYear.cboDepartment.SelectedIndex > 0 Then ' ถ้าเลือกแผนก ทั้งหมด
                    Dim Department_Id As String = ""
                    Department_Id = GetData.GetDepartmentId(fRPT_SummarizeVacationByYear.cboDepartment.Text) ' หาแผนก
                    Rptformular &= " And   {spRPT_SummarizeVacationByYear_Config;1.DeptId}='" & Department_Id.Trim & "'"
                End If

                If fRPT_SummarizeVacationByYear.cboPosition.SelectedIndex > 0 Then ' ถ้าเลือกตำแหน่งทั้งหมด
                    Rptformular &= " And  {spRPT_SummarizeVacationByYear_Config;1.Position}='" & fRPT_SummarizeVacationByYear.cboPosition.Text.Trim & "'"
                End If

                If fRPT_SummarizeVacationByYear.cboEmpGroup.SelectedIndex > 0 Then ' ถ้าเลือกกลุ่มทั้งหมด
                    Dim EmpGroup_Id As String = ""
                    EmpGroup_Id = GetData.GetEmpGroupId(fRPTMaxOT.cboEmpGroup.Text.Trim)  ' หากลุ่ม
                    Rptformular &= " And  {spRPT_SummarizeVacationByYear_Config;1.GroupId}='" & EmpGroup_Id.Trim & "'"
                End If


                If fRPT_SummarizeVacationByYear.rdMonth.Checked = True Then ' เลือกรายเดือน
                    Rptformular &= " And {spRPT_SummarizeVacationByYear_Config;1.WageType}='M'"
                End If

                If fRPT_SummarizeVacationByYear.rdDay.Checked = True Then ' เลือกทั้งรายวัน
                    Rptformular &= " And {spRPT_SummarizeVacationByYear_Config;1.WageType}='D'"
                End If

                If fRPT_SummarizeVacationByYear.rdContractor.Checked = True Then ' เลือกรายเหมา
                    Rptformular &= " And {spRPT_SummarizeVacationByYear_Config;1.WageType}='D' " & _
                                    " And {spRPT_SummarizeVacationByYear_Config;1.Contractor}=True"
                End If

            End If
            Cry.DataDefinition.RecordSelectionFormula = Rptformular

            CrystalReportViewer1.ReportSource = Cry
            'Me.Text = "รายงานสรุปการหยุดงานประจำปี"
            Me.Text = MsgManager.ShowLabel(Me, "HTFReportForm", "HTFcryRPT_SummarizeVacationByYear_Config")
            Exit Sub
        End If


        ' รายงานสรุปการหยุดงานประจำปี  เดือน 7-12 ------------------------------------------------------------------------------------------------------------
        If ReportPrint = Report.PrintSummarizeVacationByYear2 Then
            Dim Rptformular As String = ""
            Dim Cry As New cryRPT_SummarizeVacationByYear_Config2
            'Cry.SetDatabaseLogon(sysUsername, sysPassword)
            Cry.SetDatabaseLogon(sysUsername, sysPassword)

            Dim Type As String = ""
            With fRPT_SummarizeVacationByYear
                Dim Da As New SqlDataAdapter
                Dim Ds As New DataSet
                Dim StrSql As String

                StrSql = "select vCol1,vCol2,vCol3,vCol4,vCol5," & _
                                " vCalType1,vCalType2,vCalType3,vCalType4,vCalType5,absCalType " & _
                            " from RPT_SummarizeVacationByYear_Config"
                Da = New SqlDataAdapter(StrSql, Conn)
                Da.Fill(Ds, "data")
                With Ds.Tables("data")
                    If .Rows.Count = 0 Then
                        Return
                    Else
                        Dim dr As DataRow = .Rows(0)

                        Cry.DataDefinition.FormulaFields("C1").Text = "'" & dr("vCol1") & "'"
                        Cry.DataDefinition.FormulaFields("C2").Text = "'" & dr("vCol2") & "'"
                        Cry.DataDefinition.FormulaFields("C3").Text = "'" & dr("vCol3") & "'"
                        Cry.DataDefinition.FormulaFields("C4").Text = "'" & dr("vCol4") & "'"
                        Cry.DataDefinition.FormulaFields("C5").Text = "'" & dr("vCol5") & "'"

                        Cry.DataDefinition.FormulaFields("Type1").Text = "'" & IIf(dr("vCalType1").ToString.Trim = "H", "ชม.", "วัน") & "'"
                        Cry.DataDefinition.FormulaFields("Type2").Text = "'" & IIf(dr("vCalType2").ToString.Trim = "H", "ชม.", "วัน") & "'"
                        Cry.DataDefinition.FormulaFields("Type3").Text = "'" & IIf(dr("vCalType3").ToString.Trim = "H", "ชม.", "วัน") & "'"
                        Cry.DataDefinition.FormulaFields("Type4").Text = "'" & IIf(dr("vCalType4").ToString.Trim = "H", "ชม.", "วัน") & "'"
                        Cry.DataDefinition.FormulaFields("Type5").Text = "'" & IIf(dr("vCalType5").ToString.Trim = "H", "ชม.", "วัน") & "'"
                        Cry.DataDefinition.FormulaFields("Type6").Text = "'" & IIf(dr("absCalType").ToString.Trim = "H", "ชม.", "วัน") & "'"


                    End If
                End With

                Cry.DataDefinition.FormulaFields("rpt_head").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_Config2RS", "rpt_head")
                Cry.DataDefinition.FormulaFields("Rec").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_Config2RS", "Rec")
                Cry.DataDefinition.FormulaFields("ID").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_Config2RS", "ID")
                Cry.DataDefinition.FormulaFields("Name_Last").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_Config2RS", "Name_Last")
                Cry.DataDefinition.FormulaFields("Min").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_Config2RS", "Min")
                Cry.DataDefinition.FormulaFields("Late").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_Config2RS", "Late")
                Cry.DataDefinition.FormulaFields("Abs").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_Config2RS", "Abs")
                Cry.DataDefinition.FormulaFields("M1").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_Config2RS", "M1")
                Cry.DataDefinition.FormulaFields("M2").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_Config2RS", "M2")
                Cry.DataDefinition.FormulaFields("M3").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_Config2RS", "M3")
                Cry.DataDefinition.FormulaFields("M4").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_Config2RS", "M4")
                Cry.DataDefinition.FormulaFields("M5").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_Config2RS", "M5")
                Cry.DataDefinition.FormulaFields("M6").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_Config2RS", "M6")
                Cry.DataDefinition.FormulaFields("Total").Text = MsgManager.ShowLabel(Me, "cryRPT_SummarizeVacationByYear_Config2RS", "Total")


                Cry.DataDefinition.FormulaFields("Year").Text = "'" & .cboYear.Text.Trim & "'"
                Cry.SetParameterValue("@Year", .cboYear.Text.Trim)
            End With


            'Rptformular = 1 = "1"
            Rptformular = "1=1"

            If fRPT_SummarizeVacationByYear.txtCode1.Text <> "" Then  ' ค้นหาตามรหัส
                Rptformular &= " And {spRPT_SummarizeVacationByYear_Config2;1.Code}='" & fRPT_SummarizeVacationByYear.txtCode1.Text.Trim & "'"
            ElseIf fRPT_SummarizeVacationByYear.txtNameSearch.Text <> "" Then  ' ค้นหาตามชื่อ
                Rptformular &= " And {spRPT_SummarizeVacationByYear_Config2;1.fname} like '*" & fRPT_SummarizeVacationByYear.txtNameSearch.Text.Trim & "*'"
            Else

                If fRPT_SummarizeVacationByYear.cboCompany.SelectedIndex > 0 Then ' ถ้าไม่เลือกบริษัททั้งหมด
                    Dim Company_Id As String
                    Company_Id = GetData.GetCompanyId(fRPT_SummarizeVacationByYear.cboCompany.Text) ' หา รหัส Id ของ Company_Sub
                    Rptformular &= " And {spRPT_SummarizeVacationByYear_Config2;1.CompanyID} = '" & Company_Id.Trim & "'"
                End If

                If fRPT_SummarizeVacationByYear.cboDivision.SelectedIndex > 0 Then ' ถ้าเลือกฝ่ายทั้งหมด
                    Dim Division_Id As String = ""
                    Division_Id = GetData.GetDivisionId(fRPT_SummarizeVacationByYear.cboDivision.Text) ' หา รหัส ฝ่าย
                    Rptformular &= " And  {spRPT_SummarizeVacationByYear_Config2;1.DivId} = '" & Division_Id.Trim & "'"
                End If

                If fRPT_SummarizeVacationByYear.cboDepartment.SelectedIndex > 0 Then ' ถ้าเลือกแผนก ทั้งหมด
                    Dim Department_Id As String = ""
                    Department_Id = GetData.GetDepartmentId(fRPT_SummarizeVacationByYear.cboDepartment.Text) ' หาแผนก
                    Rptformular &= " And   {spRPT_SummarizeVacationByYear_Config2;1.DeptId}='" & Department_Id.Trim & "'"
                End If

                If fRPT_SummarizeVacationByYear.cboPosition.SelectedIndex > 0 Then ' ถ้าเลือกตำแหน่งทั้งหมด
                    Rptformular &= " And  {spRPT_SummarizeVacationByYear_Config2;1.Position}='" & fRPT_SummarizeVacationByYear.cboPosition.Text.Trim & "'"
                End If

                If fRPT_SummarizeVacationByYear.cboEmpGroup.SelectedIndex > 0 Then ' ถ้าเลือกกลุ่มทั้งหมด
                    Dim EmpGroup_Id As String = ""
                    EmpGroup_Id = GetData.GetEmpGroupId(fRPTMaxOT.cboEmpGroup.Text.Trim)  ' หากลุ่ม
                    Rptformular &= " And  {spRPT_SummarizeVacationByYear_Config2;1.GroupId}='" & EmpGroup_Id.Trim & "'"
                End If


                If fRPT_SummarizeVacationByYear.rdMonth.Checked = True Then ' เลือกรายเดือน
                    Rptformular &= " And {spRPT_SummarizeVacationByYear_Config2;1.WageType}='M'"
                End If

                If fRPT_SummarizeVacationByYear.rdDay.Checked = True Then ' เลือกทั้งรายวัน
                    Rptformular &= " And {spRPT_SummarizeVacationByYear_Config2;1.WageType}='D'"
                End If

                If fRPT_SummarizeVacationByYear.rdContractor.Checked = True Then ' เลือกรายเหมา
                    Rptformular &= " And {spRPT_SummarizeVacationByYear_Config2;1.WageType}='D' " & _
                                    " And {spRPT_SummarizeVacationByYear_Config2;1.Contractor}=True"
                End If

            End If
            Cry.DataDefinition.RecordSelectionFormula = Rptformular

            CrystalReportViewer1.ReportSource = Cry
            'Me.Text = "รายงานสรุปการหยุดงานประจำปี"
            Me.Text = MsgManager.ShowLabel(Me, "HTFReportForm", "HTFcryRPT_SummarizeVacationByYear_Config2")
            Exit Sub
        End If


        ' รายงานการลาขาดสายของพนักงาน ประจำวันที่ --------------------------------------------------------------
        If ReportPrint = Report.PrintEmpValAbsLateByDate Then
            Dim Cry As New cryCountAbsent
            Dim Rptformular As String = ""
            Cry.SetDatabaseLogon(sysUsername, sysPassword)

            With fRPTEmpValAbsLateByDate
                Cry.DataDefinition.FormulaFields("Abstract_Absent").Text = MsgManager.ShowLabel(Me, "cryCountAbsentRS", "Abstract_Absent")
                Cry.DataDefinition.FormulaFields("Cal_Abs").Text = MsgManager.ShowLabel(Me, "cryCountAbsentRS", "Cal_Abs")
                Cry.DataDefinition.FormulaFields("Dep").Text = MsgManager.ShowLabel(Me, "cryCountAbsentRS", "Dep")
                Cry.DataDefinition.FormulaFields("Div").Text = MsgManager.ShowLabel(Me, "cryCountAbsentRS", "Div")
                Cry.DataDefinition.FormulaFields("Examiner").Text = MsgManager.ShowLabel(Me, "cryCountAbsentRS", "Examiner")
                Cry.DataDefinition.FormulaFields("Sec").Text = MsgManager.ShowLabel(Me, "cryCountAbsentRS", "Sec")
                Cry.DataDefinition.FormulaFields("T_Absent").Text = MsgManager.ShowLabel(Me, "cryCountAbsentRS", "T_Absent")
                Cry.DataDefinition.FormulaFields("rtp_head").Text = MsgManager.ShowLabel(Me, "cryCountAbsentRS", "rpt_head")
                Cry.DataDefinition.FormulaFields("T_Late").Text = MsgManager.ShowLabel(Me, "cryCountAbsentRS", "T_Late")
                Cry.DataDefinition.FormulaFields("Vac").Text = MsgManager.ShowLabel(Me, "cryCountAbsentRS", "Vac")
                '     Cry.DataDefinition.FormulaFields("DateDaily").Text = "'" & Format(.txtDateStart.Value, "dd/MM/yyyy") & "'"
                '     Cry.SetParameterValue("@DateIn", Format(.txtDateStart.Value, "yyyy/MM/dd"))

                Dim Type As String = ""
                If .rdMonth.Checked = True Then
                    Type = "M"
                ElseIf .rdDay.Checked = True Then
                    Type = "D"
                ElseIf .rdContractor.Checked = True Then
                    Type = "C"
                Else
                    Type = "A"
                End If

                Cry.SetParameterValue("@Type", Type)
            End With

            'Rptformular = 1 = "1"
            Rptformular = "1=1"

            'If fRPTEmpValAbsLateByDate.txtCode1.Text <> "" Then  ' ค้นหาตามรหัส
            '    Rptformular &= " And {spRPT_TimeAbslateValCountDaily;1.CodeEmp}='" & fRPTEmpValAbsLateByDate.txtCode1.Text.Trim & "'"
            'ElseIf fRPTEmpValAbsLateByDate.txtNameSearch.Text <> "" Then  ' ค้นหาตามชื่อ
            '    Rptformular &= " And {spRPT_TimeAbslateValCountDaily;1.fname} like '*" & fRPTEmpValAbsLateByDate.txtNameSearch.Text.Trim & "*'"
            'Else

            'If fRPTEmpValAbsLateByDate.cboCompany.SelectedIndex > 0 Then ' ถ้าไม่เลือกบริษัททั้งหมด
            '    Dim Company_Id As String
            '    Company_Id = GetData.GetCompanyId(fRPTEmpValAbsLateByDate.cboCompany.Text) ' หา รหัส Id ของ Company_Sub
            '    Rptformular &= " And {spRPT_TimeAbslateValCountDaily;emp.CompanyID} = '" & Company_Id.Trim & "'"
            'End If

            If fRPTEmpValAbsLateByDate.cboDivision1.SelectedIndex > 0 Then ' ถ้าเลือกฝ่ายทั้งหมด
                Dim Division_Id As String = ""
                Division_Id = GetData.GetDivisionId(fRPTEmpValAbsLateByDate.cboDivision1.Text) ' หา รหัส ฝ่าย
                Rptformular &= " And  {spRPT_TimeAbslateValCountDaily;1.DivId} = '" & Division_Id.Trim & "'"
            End If

            If fRPTEmpValAbsLateByDate.cboDepartment1.SelectedIndex > 0 Then ' ถ้าเลือกแผนก ทั้งหมด
                Dim Department_Id As String = ""
                Department_Id = GetData.GetDepartmentId(fRPTEmpValAbsLateByDate.cboDepartment1.Text) ' หาแผนก
                Rptformular &= " And   {spRPT_TimeAbslateValCountDaily;1.DeptId}='" & Department_Id.Trim & "'"
            End If

            'If fRPTEmpValAbsLateByDate.cboPosition.SelectedIndex > 0 Then ' ถ้าเลือกตำแหน่งทั้งหมด
            '    Rptformular &= " And  {spRPT_TimeAbslateValCountDaily;1.Position}='" & fRPTEmpValAbsLateByDate.cboPosition.Text.Trim & "'"
            'End If

            'If fRPTEmpValAbsLateByDate.cboEmpGroup.SelectedIndex > 0 Then ' ถ้าเลือกกลุ่มทั้งหมด
            '    Dim EmpGroup_Id As String = ""
            '    EmpGroup_Id = GetData.GetEmpGroupId(fRPTEmpValAbsLateByDate.cboEmpGroup.Text.Trim)  ' หากลุ่ม
            '    Rptformular &= " And  {spRPT_TimeAbslateValCountDaily;1.GroupId}='" & EmpGroup_Id.Trim & "'"
            'End If


            'If fRPTEmpValAbsLateByDate.rdMonth.Checked = True Then ' เลือกรายเดือน
            '    Rptformular &= " And {spRPT_TimeAbslateValCountDaily;1.WageType}='M'"
            'End If

            'If fRPTEmpValAbsLateByDate.rdDay.Checked = True Then ' เลือกทั้งรายวัน
            '    Rptformular &= " And {spRPT_TimeAbslateValCountDaily;1.WageType}='D'"
            'End If

            'If fRPTEmpValAbsLateByDate.rdContractor.Checked = True Then ' เลือกรายเหมา
            '    Rptformular &= " And {spRPT_TimeAbslateValCountDaily;1.WageType}='D' And {spRPT_TimeAbslateValCountDaily;1.Contractor}=True"
            'End If

            'End If

            Cry.DataDefinition.RecordSelectionFormula = Rptformular
            CrystalReportViewer1.ReportSource = Cry
            '   Me.Text = MsgManager.ShowLabel(Me, "HTFReportForm", "HTFcryCountAbsent") & " : " & Format(fRPTEmpValAbsLateByDate.txtDateStart.Value, "dd/MM/yyyy")
            'Me.Text = "รายงานการลาขาดสายของพนักงาน ประจำวันที่ " & Format(fRPTEmpValAbsLateByDate.txtDateStart.Value, "dd/MM/yyyy")
            Exit Sub
        End If

        '-------------------------------------------------------------------------------
        If ReportPrint = Report.PrintAbsentByEmp Then
            Dim Cry As New cryAbsentByEmp
            Dim Rptformular As String = ""
            Cry.SetDatabaseLogon(sysUsername, sysPassword)

            With fRPTEmpValAbsLateByDate
                '     Dim Header As String = MsgManager.ShowLabel(Me, "cryAbsentByEmpRS", "Header") & Format(.txtDateStart.Value, "dd/MM/yyyy")
                '  Rptformular = "{TimeAbsent.DateIn} = #" & Format(.txtDateStart.Value, "yyyy/MM/dd") & "#"

                '   Cry.DataDefinition.FormulaFields("Header").Text = "'" & Header & "'"
            End With

            Cry.DataDefinition.FormulaFields("Absent").Text = MsgManager.ShowLabel(Me, "cryAbsentByEmpRS", "Absent")
            Cry.DataDefinition.FormulaFields("amt").Text = MsgManager.ShowLabel(Me, "cryAbsentByEmpRS", "amt")
            Cry.DataDefinition.FormulaFields("Department").Text = MsgManager.ShowLabel(Me, "cryAbsentByEmpRS", "Department")
            Cry.DataDefinition.FormulaFields("ID").Text = MsgManager.ShowLabel(Me, "cryAbsentByEmpRS", "ID")
            Cry.DataDefinition.FormulaFields("kon").Text = MsgManager.ShowLabel(Me, "cryAbsentByEmpRS", "kom")
            Cry.DataDefinition.FormulaFields("Last_Name").Text = MsgManager.ShowLabel(Me, "cryAbsentByEmpRS", "Last_Name")
            Cry.DataDefinition.FormulaFields("rpt_head").Text = MsgManager.ShowLabel(Me, "cryAbsentByEmpRS", "rpt_head")
            Cry.DataDefinition.FormulaFields("Name").Text = MsgManager.ShowLabel(Me, "cryAbsentByEmpRS", "Name")

            Cry.DataDefinition.RecordSelectionFormula = Rptformular
            CrystalReportViewer1.ReportSource = Cry
            '   Me.Text = MsgManager.ShowLabel(Me, "HTFReportForm", "HTFcryAbsentByEmp") & Format(fRPTEmpValAbsLateByDate.txtDateStart.Value, "dd/MM/yyyy")
            'Me.Text = "รายงานพนักงานขาดงาน ประจำวันที่ " & Format(fRPTEmpValAbsLateByDate.txtDateStart.Value, "dd/MM/yyyy")
            Exit Sub
        End If


        '-------------------------------------------------------------------------------------------------------------
        If ReportPrint = Report.PrintTimeWork_Detail2 Then
            Dim Cry As New rptEmpTimeWork_Detail_2
            Dim Rptformular As String = ""
            Cry.SetDatabaseLogon(sysUsername, sysPassword)
            'Me.Text = "รายงานการทำงานของพนักงาน  (แบบที่ 2)"
            Me.Text = MsgManager.ShowLabel(Me, "HTFReportForm", "HTFrptEmpTimeWork_Detail_2")
            'Cry.DataDefinition.FormulaFields("DateFrom").Text = "'From Date " & fRptAllEmpWork.txtDateStart.Text.Trim & " to " & fRptAllEmpWork.txtDateStop.Text.Trim & "'"

            With fRptAllEmpWork_Detail2
                Rptformular = "({RPT_EmpWork2.DateIn} >= #" & ConvertDate(.txtDateStart.Text.Trim) & " 00:00" & "# and " & _
                               "{RPT_EmpWork2.DateIn} <= #" & ConvertDate(.txtDateStop.Text.Trim) & " 23:59" & "#)"
            End With

            '  Rptformular = 1 = "1"

            If fRptAllEmpWork_Detail2.txtCode1.Text <> "" Then  ' ค้นหาตามรหัส
                Rptformular &= " And {RPT_EmpWork2.code}='" & fRptAllEmpWork_Detail2.txtCode1.Text.Trim & "'"
            ElseIf fRptAllEmpWork_Detail2.txtNameSearch.Text <> "" Then  ' ค้นหาตามชื่อ
                Rptformular &= " And {Emp.fname} like '*" & fRptAllEmpWork_Detail2.txtNameSearch.Text.Trim & "*'"
            Else

                If fRptAllEmpWork_Detail2.cboCompany.SelectedIndex > 0 Then ' ถ้าไม่เลือกบริษัททั้งหมด
                    Dim Company_Id As String
                    Company_Id = GetData.GetCompanyId(fRptAllEmpWork_Detail2.cboCompany.Text) ' หา รหัส Id ของ Company_Sub
                    Rptformular &= " And {Emp.CompanyID} = '" & Company_Id.Trim & "'"
                End If

                If fRptAllEmpWork_Detail2.cboDivision.SelectedIndex > 0 Then ' ถ้าเลือกฝ่ายทั้งหมด
                    Dim Division_Id As String = ""
                    Division_Id = GetData.GetDivisionId(fRptAllEmpWork_Detail2.cboDivision.Text) ' หา รหัส ฝ่าย
                    Rptformular &= " And  {Emp.DivId} = '" & Division_Id.Trim & "'"
                End If

                If fRptAllEmpWork_Detail2.cboDepartment.SelectedIndex > 0 Then ' ถ้าเลือกแผนก ทั้งหมด
                    Dim Department_Id As String = ""
                    Department_Id = GetData.GetDepartmentId(fRptAllEmpWork_Detail2.cboDepartment.Text) ' หาแผนก
                    Rptformular &= " And   {Emp.DeptId}='" & Department_Id.Trim & "'"
                End If

                If fRptAllEmpWork_Detail2.cboPosition.SelectedIndex > 0 Then ' ถ้าเลือกตำแหน่งทั้งหมด
                    Rptformular &= " And  {Emp.Position}='" & fRptAllEmpWork_Detail2.cboPosition.Text.Trim & "'"
                End If

                If fRptAllEmpWork_Detail2.cboEmpGroup.SelectedIndex > 0 Then ' ถ้าเลือกกลุ่มทั้งหมด
                    Dim EmpGroup_Id As String = ""
                    EmpGroup_Id = GetData.GetEmpGroupId(fRptAllEmpWork_Detail2.cboEmpGroup.Text.Trim)  ' หากลุ่ม
                    Rptformular &= " And  {Emp.GroupId}='" & EmpGroup_Id.Trim & "'"
                End If


                If fRptAllEmpWork_Detail2.rdMonth.Checked = True Then ' เลือกรายเดือน
                    Rptformular &= " And {Emp.WageType}='M'"
                End If

                If fRptAllEmpWork_Detail2.rdDay.Checked = True Then ' เลือกทั้งรายวัน
                    Rptformular &= " And {Emp.WageType}='D'"
                End If

                If fRptAllEmpWork_Detail2.rdContractor.Checked = True Then ' เลือกรายเหมา
                    Rptformular &= " And {Emp.WageType}='D' And {Emp.Contractor}=True"
                End If

            End If

            Cry.DataDefinition.FormulaFields("Holiday").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_Detail_2RS", "Holiday")
            Cry.DataDefinition.FormulaFields("Hour").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_Detail_2RS", "Hour")
            Cry.DataDefinition.FormulaFields("Day").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_Detail_2RS", "Day")
            Cry.DataDefinition.FormulaFields("Dep").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_Detail_2RS", "Dep")
            Cry.DataDefinition.FormulaFields("Div").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_Detail_2RS", "Div")
            Cry.DataDefinition.FormulaFields("DT").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_Detail_2RS", "DT")
            Cry.DataDefinition.FormulaFields("ID").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_Detail_2RS", "ID")
            Cry.DataDefinition.FormulaFields("In").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_Detail_2RS", "In_Text")
            Cry.DataDefinition.FormulaFields("Ka").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_Detail_2RS", "Ka")
            Cry.DataDefinition.FormulaFields("Late").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_Detail_2RS", "Late")
            Cry.DataDefinition.FormulaFields("Leave").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_Detail_2RS", "Leave")
            Cry.DataDefinition.FormulaFields("Name_Last").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_Detail_2RS", "Name_Last")
            Cry.DataDefinition.FormulaFields("Normal").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_Detail_2RS", "Normal")
            Cry.DataDefinition.FormulaFields("OT").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_Detail_2RS", "OT")
            Cry.DataDefinition.FormulaFields("Out").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_Detail_2RS", "Out")
            Cry.DataDefinition.FormulaFields("rpt_head").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_Detail_2RS", "rpt_head")
            Cry.DataDefinition.FormulaFields("Rec").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_Detail_2RS", "Rec")
            Cry.DataDefinition.FormulaFields("Sec").Text = MsgManager.ShowLabel(Me, "rptEmpTimeWork_Detail_2RS", "Sec")

            Cry.DataDefinition.RecordSelectionFormula = Rptformular
            CrystalReportViewer1.ReportSource = Cry
            'CrystalReportViewer1.RefreshReport()
            Exit Sub
        End If


        ' รายงานค่าล่วงเวลา-------------------------------------------------------------------------------------------------------------
        If ReportPrint = Report.Print_OTReport Then
            Dim Cry As New cryRPT_OTreport
            Dim Rptformular As String = ""
            Cry.SetDatabaseLogon(sysUsername, sysPassword)
            Me.Text = MsgManager.ShowLabel(Me, "HTFReportForm", "HTFcryRPT_OTreport")

            'Me.Text = "รายงานค่าล่วงเวลาทำงาน (ตามช่วงเวลา)"
            Cry.DataDefinition.FormulaFields("Company").Text = "'" & Format(fRpt_OTreport.cboCompany.Text.Trim) & "'"

            'With fRpt_OTreport
            '    Rptformular = "({Timework.DateIn} >= #" & ConvertDate(.txtDateStart.Text.Trim) & " 00:00" & "# and " & _
            '                   "{Timework.DateIn} <= #" & ConvertDate(.txtDateStop.Text.Trim) & " 23:59" & "#)"
            'End With

            Rptformular = 1 = "1"
            Rptformular &= " And  {Emp.WorkStatus}='W'"
            If fRpt_OTreport.txtCode1.Text <> "" Then  ' ค้นหาตามรหัส
                Rptformular &= " And {Emp.code}='" & fRpt_OTreport.txtCode1.Text.Trim & "'"
            End If
            If fRpt_OTreport.txtNameSearch.Text <> "" Then  ' ค้นหาตามชื่อ
                Rptformular &= " And {Emp.fname} like '*" & fRpt_OTreport.txtNameSearch.Text.Trim & "*'"
            End If

            If fRpt_OTreport.cboCompany.SelectedIndex > 0 Then ' ถ้าไม่เลือกบริษัททั้งหมด
                Dim Company_Id As String
                Company_Id = GetData.GetCompanyId(fRpt_OTreport.cboCompany.Text) ' หา รหัส Id ของ Company_Sub
                Rptformular &= " And {Emp.CompanyID} = '" & Company_Id.Trim & "'"
            End If

            If fRpt_OTreport.cboDivision.SelectedIndex > 0 Then ' ถ้าเลือกฝ่ายทั้งหมด
                Dim Division_Id As String = ""
                Division_Id = GetData.GetDivisionId(fRpt_OTreport.cboDivision.Text) ' หา รหัส ฝ่าย
                Rptformular &= " And  {Emp.DivId} = '" & Division_Id.Trim & "'"
            End If

            If fRpt_OTreport.cboDepartment.SelectedIndex > 0 Then ' ถ้าเลือกแผนก ทั้งหมด
                Dim Department_Id As String = ""
                Department_Id = GetData.GetDepartmentId(fRpt_OTreport.cboDepartment.Text) ' หาแผนก
                Rptformular &= " And   {Emp.DeptId}='" & Department_Id.Trim & "'"
            End If

            If fRpt_OTreport.cboPosition.SelectedIndex > 0 Then ' ถ้าเลือกตำแหน่งทั้งหมด
                Rptformular &= " And  {Emp.Position}='" & fRpt_OTreport.cboPosition.Text.Trim & "'"
            End If

            If fRpt_OTreport.cboEmpGroup.SelectedIndex > 0 Then ' ถ้าเลือกกลุ่มทั้งหมด
                Dim EmpGroup_Id As String = ""
                EmpGroup_Id = GetData.GetEmpGroupId(fRpt_OTreport.cboEmpGroup.Text.Trim)  ' หากลุ่ม
                Rptformular &= " And  {Emp.GroupId}='" & EmpGroup_Id.Trim & "'"
            End If


            If fRpt_OTreport.rdMonth.Checked = True Then ' เลือกรายเดือน
                Rptformular &= " And {Emp.WageType}='M'"
            End If

            If fRpt_OTreport.rdDay.Checked = True Then ' เลือกทั้งรายวัน
                Rptformular &= " And {Emp.WageType}='D' And {Emp.Contractor}=False"
            End If

            If fRpt_OTreport.rdContractor.Checked = True Then ' เลือกรายเหมา
                Rptformular &= " And {Emp.WageType}='D' And {Emp.Contractor}=True"
            End If

            If fRpt_OTreport.chkDay.Checked = True Then
                ' แสดง ที่มีข้อมูล วันทำงาน > 0
                Rptformular &= " and ({Rpt_OTreport.D1}+{Rpt_OTreport.D2}+{Rpt_OTreport.D3}+" & _
                                 "{Rpt_OTreport.D4}+{Rpt_OTreport.D5}+{Rpt_OTreport.D6}+" & _
                                 "{Rpt_OTreport.D7}+{Rpt_OTreport.D8}+{Rpt_OTreport.D9}+" & _
                                 "{Rpt_OTreport.D10}+{Rpt_OTreport.D11}+{Rpt_OTreport.D12}+" & _
                                 "{Rpt_OTreport.D13}+{Rpt_OTreport.D14}+{Rpt_OTreport.D15}+" & _
                                 "{Rpt_OTreport.D16}+{Rpt_OTreport.D17}+{Rpt_OTreport.D18}+" & _
                                 "{Rpt_OTreport.D19}+{Rpt_OTreport.D20}+{Rpt_OTreport.D21}+" & _
                                 "{Rpt_OTreport.D22}+{Rpt_OTreport.D23}+{Rpt_OTreport.D24}+" & _
                                 "{Rpt_OTreport.D25}+{Rpt_OTreport.D26}+{Rpt_OTreport.D27}+" & _
                                 "{Rpt_OTreport.D28}+{Rpt_OTreport.D29}+{Rpt_OTreport.D30}+" & _
                                 "{Rpt_OTreport.D31}" & _
                                " ) > 0 "
            End If


            If fRpt_OTreport.chkOT.Checked = True Then

                ' แสดง ที่มีข้อมูล OT > 0
                Rptformular &= " and ({Rpt_OTreport.OTH1}+{Rpt_OTreport.OTH2}+{Rpt_OTreport.OTH3}+" & _
                                 "{Rpt_OTreport.OTH4}+{Rpt_OTreport.OTH5}+{Rpt_OTreport.OTH6}+" & _
                                 "{Rpt_OTreport.OTH7}+{Rpt_OTreport.OTH8}+{Rpt_OTreport.OTH9}+" & _
                                 "{Rpt_OTreport.OTH10}+{Rpt_OTreport.OTH11}+{Rpt_OTreport.OTH12}+" & _
                                 "{Rpt_OTreport.OTH13}+{Rpt_OTreport.OTH14}+{Rpt_OTreport.OTH15}+" & _
                                 "{Rpt_OTreport.OTH16}+{Rpt_OTreport.OTH17}+{Rpt_OTreport.OTH18}+" & _
                                 "{Rpt_OTreport.OTH19}+{Rpt_OTreport.OTH20}+{Rpt_OTreport.OTH21}+" & _
                                 "{Rpt_OTreport.OTH22}+{Rpt_OTreport.OTH23}+{Rpt_OTreport.OTH24}+" & _
                                 "{Rpt_OTreport.OTH25}+{Rpt_OTreport.OTH26}+{Rpt_OTreport.OTH27}+" & _
                                 "{Rpt_OTreport.OTH28}+{Rpt_OTreport.OTH29}+{Rpt_OTreport.OTH30}+" & _
                                 "{Rpt_OTreport.OTH31}" & _
                                " ) > 0 "
            End If

            Cry.DataDefinition.FormulaFields("Catch").Text = MsgManager.ShowLabel(Me, "cryRPT_OTreportRS", "Catch_Text")
            Cry.DataDefinition.FormulaFields("Date").Text = MsgManager.ShowLabel(Me, "cryRPT_OTreportRS", "Date_Text")
            Cry.DataDefinition.FormulaFields("Day_hour").Text = MsgManager.ShowLabel(Me, "cryRPT_OTreportRS", "Day_hour")
            Cry.DataDefinition.FormulaFields("ID").Text = MsgManager.ShowLabel(Me, "cryRPT_OTreportRS", "ID")
            Cry.DataDefinition.FormulaFields("Name_Last").Text = MsgManager.ShowLabel(Me, "cryRPT_OTreportRS", "Name_Last")
            Cry.DataDefinition.FormulaFields("OT").Text = MsgManager.ShowLabel(Me, "cryRPT_OTreportRS", "OT")
            Cry.DataDefinition.FormulaFields("ot_15").Text = MsgManager.ShowLabel(Me, "cryRPT_OTreportRS", "ot_15")
            Cry.DataDefinition.FormulaFields("ot_35").Text = MsgManager.ShowLabel(Me, "cryRPT_OTreportRS", "ot_35")
            Cry.DataDefinition.FormulaFields("OT_H").Text = MsgManager.ShowLabel(Me, "cryRPT_OTreportRS", "OT_H")
            Cry.DataDefinition.FormulaFields("Total").Text = MsgManager.ShowLabel(Me, "cryRPT_OTreportRS", "Total")
            Cry.DataDefinition.FormulaFields("rpt_head").Text = MsgManager.ShowLabel(Me, "cryRPT_OTreportRS", "rpt_head")
            Cry.DataDefinition.FormulaFields("Wage").Text = MsgManager.ShowLabel(Me, "cryRPT_OTreportRS", "Wage")
            Cry.DataDefinition.FormulaFields("Work_H").Text = MsgManager.ShowLabel(Me, "cryRPT_OTreportRS", "Work_H")

            Cry.DataDefinition.FormulaFields("rpt_Monthly").Text = "'" & MsgManager.ShowLabel(Me, "cryRPT_OTreportRS", "rpt_Monthly") & " " & fRpt_OTreport.txtDateStart.Text & " - " & fRpt_OTreport.txtDateStop.Text & "'"

            Cry.DataDefinition.RecordSelectionFormula = Rptformular
            CrystalReportViewer1.ReportSource = Cry
            'CrystalReportViewer1.RefreshReport()
            Exit Sub
        End If

    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class