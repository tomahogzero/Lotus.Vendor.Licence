Imports TimeAttendance.utils
Imports System.IO
Imports System.Globalization

Imports System.Data
Imports System.Data.SqlClient

Public Class frmEmp
    Protected dbMgr As New DBManager
    Protected dbConnStr As String = dbMgr.getConnString

    Dim gData As New GetData
    Dim LockID As Boolean = True

    Private Sub frmEmp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnSearch.Visible = False
        btnPrint.Visible = False

        TabMoveToEmpOut.Visible = True  ' ย้ายพนักงานลาออกแสดง
        If StatusEmp = "T" Then  ' กรณีที่เป็นฟอร์มลาออก
            btnAdd.Visible = False
            btnClear.Visible = False
            TabMoveToEmpOut.Visible = False  ' ย้ายพนักงานลาออกซ่อน
        End If

        Call LoadTitleThai_Eng()  ' คำนำหน้าชื่อ
        Call LoadStatus()
        Call LoadCompany()
        Call LoadWeek()
        Call LoadBank()
        Call LoadBroker()
        Call LoadEmpGroup()
        '  Call LoadData()
        Call ClearData(True)
        PG1.Visible = False

        Call btnTrain_Clear_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub LoadStatus()
        txtStatus.Items.Add("โสด")
        txtStatus.Items.Add("สมรส")
        txtStatus.Items.Add("หม่าย")
        txtStatus.Items.Add("หย่าร้าง")
        txtStatus.Items.Add("แยกกันอยู่")
    End Sub

    Public Overrides Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Trim(txtCode_D.Text) = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_CodeEmp", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtCode.Focus()
            Exit Sub
        End If
        If Trim(txtDivID.Text) = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_DivId", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtDivID.Focus()
            Exit Sub
        End If
        If Trim(txtDeptId.Text) = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_DeptId", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtDeptId.Focus()
            Exit Sub
        End If

        If Trim(txtSecId_Det.Text) = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_Section", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtSecId_Det.Focus()
            Exit Sub
        End If

        If Trim(txtFname_Det.Text) = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_EmpFName", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtFname_Det.Focus()
            Exit Sub
        End If
        'If Trim(txtLname.Text) = "" Then
        '    MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_EmpLname", MessageBoxIcon.Information)
        '    TabControl2.SelectedTabIndex = 0
        '    txtLname.Focus()
        '    Exit Sub
        'End If


        If IsDate(ConvertDate(txtDateIn.Text)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_DateIn", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtDateIn.Focus()
            Exit Sub
        End If
        If txtBirth.Text <> "  /  /" And IsDate(ConvertDate(txtBirth.Text)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_Birth", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtBirth.Focus()
            Exit Sub
        End If
        'If txtDatePro.Text <> "  /  / And IsDate(ConvertDate(txtDatePro.Text)) = False Then" Then
        '    MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_DatePro", MessageBoxIcon.Information)
        '    TabControl2.SelectedTabIndex = 0
        '    txtDatePro.Focus()
        '    Exit Sub
        'End If
        If txtDateExpire.Text <> "  /  /" And IsDate(ConvertDate(txtDateExpire.Text)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_DateExpire", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtDateExpire.Focus()
            Exit Sub
        End If
        'If txtDateExpire.Text <> "  /  /" And IsDate(ConvertDate(txtDateExpire.Text)) = False Then
        '    MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_DeptId", MessageBoxIcon.Information)
        '    TabControl2.SelectedTabIndex = 0
        '    txtDateExpire.Focus()
        '    Exit Sub
        'End If

        If Trim(txtSalary.Text) = "" Then txtSalary.Text = 0
        If IsNumeric(txtSalary.Text) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_Salary", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtSalary.Focus()
            Exit Sub
        End If
        If Trim(txtBonus.Text) = "" Then txtBonus.Text = 0
        If IsNumeric(txtBonus.Text) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_Bonus", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtBonus.Focus()
            Exit Sub
        End If

        If Trim(txtSonEdu.Text) = "" Then txtSonEdu.Text = 0
        If IsNumeric(txtSonEdu.Text) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_SonEdu", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtSonEdu.Focus()
            Exit Sub
        End If
        If Trim(txtSonNonEdu.Text) = "" Then txtSonNonEdu.Text = 0
        If IsNumeric(txtSonNonEdu.Text) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_SonNonEdu", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtSonNonEdu.Focus()
            Exit Sub
        End If
        If txtforeignDate.Text <> "  /  /" And IsDate(ConvertDate(txtforeignDate.Text)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_ForeignDate", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 2
            txtforeignDate.Focus()
            Exit Sub
        End If
        If txtDriveDate.Text <> "  /  /" And IsDate(ConvertDate(txtDriveDate.Text)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_DriveDate", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 2
            txtDriveDate.Focus()
            Exit Sub
        End If
        If txtSoldierDate.Text <> "  /  /" And IsDate(ConvertDate(txtSoldierDate.Text)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_SoldierDate", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 2
            txtSoldierDate.Focus()
            Exit Sub
        End If


        Dim CompanyID As String
        Dim EmpBankId As String
        CompanyID = LoadCompanyID(cmbCompanyName.Text)
        EmpBankId = GetBankID(Trim(cboBank.Text))


        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList


        Data.Clear() : strType = ""
        Data.Add(txtCode_D.Text.Trim) : strType &= "T"
        Data.Add(txtAccountCode.Text.Trim) : strType &= "T"
        Data.Add(cboTitle.Text.Trim) : strType &= "T"
        Data.Add(txtFname_Det.Text.Trim) : strType &= "T"
        Data.Add(txtLname.Text.Trim) : strType &= "T"
        Data.Add(cboTitleEng.Text.Trim) : strType &= "T"
        Data.Add(txtFnameEng.Text.Trim) : strType &= "T"
        Data.Add(txtLnameEng.Text.Trim) : strType &= "T"
        Data.Add(txtNickName.Text.Trim) : strType &= "T"
        Data.Add(txtWorkingPlace.Text.Trim) : strType &= "T"
        Data.Add(txtDivID.Text.Trim) : strType &= "T"
        Data.Add(txtDeptId.Text.Trim) : strType &= "T"
        Data.Add(txtSecId_Det.Text.Trim) : strType &= "T"
        Data.Add(txtPosition.Text.Trim) : strType &= "T"
        '14

        ' ข้อมูลส่วนตัว ส่วนที่ 1

        If txtDateIn.Text = "  /  /" Then
            Data.Add(DBNull.Value) : strType &= "T"
        Else
            '  Dim bb As String
            ' bb = ConvertDate(ConvertDate_Eng(txtDateIn.Text.Trim))
            ' Data.Add(ConvertDate(Format(ConvertDate_Eng(txtDateIn.Text.Trim), "dd/MM/yyyy"))) : strType &= "T"
            Data.Add(ConvertDate(txtDateIn.Text.Trim)) : strType &= "T"

        End If

        If txtTermiDate.Text = "  /  /" Then
            Data.Add(DBNull.Value) : strType &= "T"
        Else
            '  Data.Add(ConvertDate(Format(txtTermiDate.Text.Trim), "dd/MM/yyyy"))) : strType &= "T"
            Data.Add(ConvertDate(txtTermiDate.Text.Trim)) : strType &= "T"
        End If

        If txtDatePro.Text = "  /  /" Then
            Data.Add(DBNull.Value) : strType &= "T"
        Else
            '  Data.Add(ConvertDate(Format(txtDatePro.Text.Trim), "dd/MM/yyyy"))) : strType &= "T"
            Data.Add(ConvertDate(txtDatePro.Text.Trim)) : strType &= "T"
        End If

        If txtBirth.Text = "  /  /" Then
            Data.Add(DBNull.Value) : strType &= "T"
        Else
            '   Data.Add(ConvertDate(Format(txtBirth.Text.Trim), "dd/MM/yyyy"))) : strType &= "T"
            Data.Add(ConvertDate(txtBirth.Text.Trim)) : strType &= "T"
        End If

        Data.Add(txtAddress.Text.Trim) : strType &= "T"
        Data.Add(txtIdCard.Text.Trim) : strType &= "T"
        Data.Add(IIf(cboSex.SelectedIndex = 0, "M", "F")) : strType &= "T"

        If txtDateExpire.Text = "  /  /" Then
            Data.Add(DBNull.Value) : strType &= "T"
        Else
            '  Data.Add(ConvertDate(Format(txtDateExpire.Text.Trim), "dd/MM/yyyy"))) : strType &= "T"
            Data.Add(ConvertDate(txtDateExpire.Text.Trim)) : strType &= "T"
        End If


        Data.Add(txtPlaceIdCard.Text.Trim) : strType &= "T"
        Data.Add(txtTaxId.Text.Trim) : strType &= "T"
        Data.Add(txtEducation.Text.Trim) : strType &= "T"
        Data.Add(txtMarryName.Text.Trim) : strType &= "T"
        Data.Add(IIf(cboMateSpit.SelectedIndex = 0, 0, 1)) : strType &= "B"
        '13  = 27
        ' ส่วนที่ 2
        Data.Add(txtMarryWorkCom.Text.Trim) : strType &= "T"
        Data.Add(txtBankId.Text.Trim) : strType &= "T"
        Data.Add(txtTypeBank.Text.Trim) : strType &= "T"
        Data.Add(txtSocTax.Text.Trim) : strType &= "T"
        Data.Add(txtStatus.Text.Trim) : strType &= "T"
        Data.Add(IIf(OptMonth.Checked = True, "M", "D")) : strType &= "T"
        Data.Add(IIf(chkContractor.Checked = True, 1, 0)) : strType &= "B"
        Data.Add(txtSalary.Text.Trim) : strType &= "T"
        Data.Add(txtBonus.Text.Trim) : strType &= "T"
        Data.Add(GetWeek_Code(cboWeek.Text.Trim)) : strType &= "T"
        Data.Add(gData.GetGroupId(cboEmpGroup.Text.Trim)) : strType &= "T"
        Data.Add(IIf(optCash.Checked = True, "B", "C")) : strType &= "T"
        Data.Add(EmpBankId.Trim) : strType &= "T"
        Data.Add(CompanyID.Trim) : strType &= "T"
        Data.Add(gData.getBrokerId(cboBroker.Text.Trim)) : strType &= "T"
        '15  =42

        '  Math.Round(Int(txtA_ENT.Text), 2)
        ' ข้อมูลบุตร และ ข้อมูลคำนวณภาษี =====================================================================
        Data.Add(Math.Round(Int(txtPremium.Text), 2)) : strType &= "T"
        Data.Add(Math.Round(Int(txtPremium.Text), 2)) : strType &= "T"
        Data.Add(Math.Round(Int(txtLoan.Text), 2)) : strType &= "T"
        Data.Add(Math.Round(Int(txtDonate.Text), 2)) : strType &= "T"
        Data.Add(Math.Round(Int(txtCapitalSumary.Text), 2)) : strType &= "T"

        Data.Add(cboPremiumMStart.SelectedItem.ToString) : strType &= "T"
        Data.Add(cboLoanMStart.SelectedItem.ToString) : strType &= "T"
        Data.Add(cboDonateMStart.SelectedItem.ToString) : strType &= "T"
        Data.Add(txtSonEdu.Text.Trim) : strType &= "T"
        Data.Add(txtSonNonEdu.Text.Trim) : strType &= "T"
        Data.Add(IIf(chkCalSocTax.Checked = True, 1, 0)) : strType &= "B"
        '11 = 53
        ' Text ข้อมูลที่เก็บชื่อลูก กับอายุลูก แยกไปทำอีกที่เพราะว่ามันต้อง Delete และ Insert เข้าไปใหม่


        ' อื่นๆ  ส่วนที่ 1=============================================================

        Data.Add(txtRace.Text.Trim) : strType &= "T"
        Data.Add(txtNationalily.Text.Trim) : strType &= "T"
        Data.Add(txtReligion.Text.Trim) : strType &= "T"
        Data.Add(txtTelContract.Text.Trim) : strType &= "T"
        Data.Add(txtforeignNo.Text.Trim) : strType &= "T"

        If txtforeignDate.Text = "  /  /" Then
            Data.Add(DBNull.Value) : strType &= "T"
        Else
            '    Data.Add(ConvertDate(Format(txtforeignDate.Text.Trim), "dd/MM/yyyy"))) : strType &= "T"
            Data.Add(ConvertDate(txtforeignDate.Text.Trim)) : strType &= "T"
        End If
        Data.Add(txtDriveNo.Text.Trim) : strType &= "T"

        If txtDriveDate.Text = "  /  /" Then
            Data.Add(DBNull.Value) : strType &= "T"
        Else
            '   Data.Add(ConvertDate(Format(txtDriveDate.Text.Trim, "dd/MM/yyyy"))) : strType &= "T"
            Data.Add(ConvertDate(txtDriveDate.Text.Trim)) : strType &= "T"
        End If

        Data.Add(txtDrivePlace.Text.Trim) : strType &= "T"
        Data.Add(cboSoldierStatus.Text.Trim) : strType &= "T"

        If txtSoldierDate.Text = "  /  /" Then
            Data.Add(DBNull.Value) : strType &= "T"
        Else
            '   Data.Add(ConvertDate(Format(txtSoldierDate.Text.Trim, "dd/MM/yyyy"))) : strType &= "T"
            Data.Add(ConvertDate(txtSoldierDate.Text.Trim)) : strType &= "T"
        End If

        ' 11 =  64
        ' ส่วนที่ 2

        Data.Add(txtFatherName.Text.Trim) : strType &= "T"
        Data.Add(txtFatherIdCard.Text.Trim) : strType &= "T"
        Data.Add(IIf(chkFatherCalTax.Checked = True, 1, 0)) : strType &= "B"

        Data.Add(txtMatherName.Text.Trim) : strType &= "T"
        Data.Add(txtMatherIdCard.Text.Trim) : strType &= "T"
        Data.Add(IIf(chkMatherCalTax.Checked = True, 1, 0)) : strType &= "B"

        Data.Add(txtFatherNameMate.Text.Trim) : strType &= "T"
        Data.Add(txtFatherIdCardMate.Text.Trim) : strType &= "T"
        Data.Add(IIf(chkFatherCalTaxMate.Checked = True, 1, 0)) : strType &= "B"

        Data.Add(txtMatherNameMate.Text.Trim) : strType &= "T"
        Data.Add(txtMatherIdCardMate.Text.Trim) : strType &= "T"
        Data.Add(IIf(chkMatherCalTaxMate.Checked = True, 1, 0)) : strType &= "B"

        Data.Add(txtGuaranteeName.Text.Trim) : strType &= "T"
        Data.Add(txtGuanWork.Text.Trim) : strType &= "T"
        Data.Add(txtErContract.Text.Trim) : strType &= "T"
        Data.Add(txtEr_Tel.Text.Trim) : strType &= "T"
        Data.Add(txtEduSpacial.Text.Trim) : strType &= "T"
        Data.Add(txtRemark.Text.Trim) : strType &= "T"
        Data.Add(IIf(chkPro_Fund.Checked = True, 1, 0)) : strType &= "B"
        '19 = 83

        ' Attendant
        Data.Add(IIf(cboOt.SelectedIndex = 0, 1, 0)) : strType &= "B"
        Data.Add(IIf(chkCalLate.Checked = True, 1, 0)) : strType &= "B"
        Data.Add(IIf(chkCalOtDeduc.Checked = True, 1, 0)) : strType &= "B"

        strSQL = "Insert Into Emp(Code,AccountCode,title,Fname,Lname,TitleEng,FnameEng,LnameEng,NickName,WorkingPlace, " & _
                                " DivId,DeptId,SecId,Position,DateIn,Termidate,DatePro,Birthday,Address,IdCard, " & _
                                " Sex,DateExpire,PlaceIdCard,TaxId,Education,MarryName,MateSpit,MarryWorkCom,BankId,TypeBank, " & _
                                " SocTaxId,Status,WageType,Contractor,Salary,Bonus,WK_Code,GroupId,PayType,EmpBankId, " & _
                                " CompanyId,BrokerId,A_Ent,Premium,Loan,Donate,CapitalSumary,PremiumMstart,LoanMstart,DonateMstart, " & _
                                " SonEdu,SonNonEdu,CalSocTax,Race,Nationality,Religion,TelContract,ForeignNo,ForeignDate,DriverNo, " & _
                                " DriverDate,DriverPlace,SoldierStatus,SoldierDate,FatherName,FatherIdCard,FatherCalTax,MatherName,MatherIdCard,MatherCalTax, " & _
                                " FatherNameMate,FatherIdCardMate,FatherCalTaxMate,MatherNameMate,MatherIdCardMate,MatherCalTaxMate,GuaranTeeName,GuaranWork,ErconTract,Er_Tel, " & _
                                " EduSpacial,Remark,Pro_Fund,OT,CalLate,CalOTDeduc)" & _
                                     " Values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10, " & _
                                                " @P11,@P12,@P13,@P14,@P15,@P16,@P17,@P18,@P19,@P20, " & _
                                                " @P21,@P22,@P23,@P24,@P25,@P26,@P27,@P28,@P29,@P30, " & _
                                                " @P31,@P32,@P33,@P34,@P35,@P36,@P37,@P38,@P39,@P40, " & _
                                                " @P41,@P42,@P43,@P44,@P45,@P46,@P47,@P48,@P49,@P50, " & _
                                                " @P51,@P52,@P53,@P54,@P55,@P56,@P57,@P58,@P59,@P60, " & _
                                                " @P61,@P62,@P63,@P64,@P65,@P66,@P67,@P68,@P69,@P70, " & _
                                                " @P71,@P72,@P73,@P74,@P75,@P76,@P77,@P78,@P79,@P80, " & _
                                                " @P81,@P82,@P83,@P84,@P85,@P86)"
        ' 86 ฟิวล์
        Try
            Call dbMgr.OpenDatabase(Conn, True)
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
            Call dbMgr.OpenDatabase(Conn, False)
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Me.Text)
            Exit Sub
        End Try


        ' Delete Son --------------------
        Call Delet_Son(txtCode_D.Text.Trim)

        ' Insert Son ----------------------
        Call Insert_Son(txtCode_D.Text.Trim)

        ' Training
        Call Delete_Training(txtCode_D.Text.Trim)
        Call Insert_Training(txtCode_D.Text.Trim)


        ' InsertBarcode ของพนักงาน ======================
        Try
            Data.Clear() : strType = ""
            Data.Add(txtCode_D.Text.Trim) : strType &= "T"
            Data.Add(txtBarcode.Text.Trim) : strType &= "T"

            strSQL = "Insert Into EmpSetBarcode (Code,Barcode) Values (@P1,@P2)"

            Call dbMgr.OpenDatabase(Conn, True)
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
            Call dbMgr.OpenDatabase(Conn, False)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        MsgManager.ShowDialog(Me, "Messages", Me.Text, "Save_Complete", MessageBoxIcon.Information)

        Call LoadData_Detail(e, System.EventArgs.Empty)
        Call EnaCmd(False, True, True)
    End Sub

    Public Overrides Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Dim aa As String = txtStatus.Text

        If Trim(txtCode_D.Text) = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_CodeEmp", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtCode.Focus()
            Exit Sub
        End If
        If Trim(txtDivID.Text) = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_DivId", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtDivID.Focus()
            Exit Sub
        End If
        If Trim(txtDeptId.Text) = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_DeptId", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtDeptId.Focus()
            Exit Sub
        End If

        If Trim(txtSecId_Det.Text) = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_Section", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtSecId_Det.Focus()
            Exit Sub
        End If

        If Trim(txtFname_Det.Text) = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_EmpFName", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtFname_Det.Focus()
            Exit Sub
        End If
        'If Trim(txtLname.Text) = "" Then
        '    MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_EmpLname", MessageBoxIcon.Information)
        '    TabControl2.SelectedTabIndex = 0
        '    txtLname.Focus()
        '    Exit Sub
        'End If


        If IsDate(ConvertDate(txtDateIn.Text)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_DateIn", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtDateIn.Focus()
            Exit Sub
        End If
        If txtBirth.Text <> "  /  /" And IsDate(ConvertDate(txtBirth.Text)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_Birth", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtBirth.Focus()
            Exit Sub
        End If
        If txtDatePro.Text <> "  /  /" And IsDate(ConvertDate(txtDatePro.Text)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_DatePro", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtDatePro.Focus()
            Exit Sub
        End If
        If txtDateExpire.Text <> "  /  /" And IsDate(ConvertDate(txtDateExpire.Text)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_DateExpire", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtDateExpire.Focus()
            Exit Sub
        End If
        If txtDateExpire.Text <> "  /  /" And IsDate(ConvertDate(txtDateExpire.Text)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_DeptId", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtDateExpire.Focus()
            Exit Sub
        End If
        If Trim(txtSalary.Text) = "" Then txtSalary.Text = 0
        If IsNumeric(txtSalary.Text) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_Salary", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtSalary.Focus()
            Exit Sub
        End If
        If Trim(txtBonus.Text) = "" Then txtBonus.Text = 0
        If IsNumeric(txtBonus.Text) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_Bonus", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtBonus.Focus()
            Exit Sub
        End If

        If Trim(txtSonEdu.Text) = "" Then txtSonEdu.Text = 0
        If IsNumeric(txtSonEdu.Text) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_SonEdu", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtSonEdu.Focus()
            Exit Sub
        End If
        If Trim(txtSonNonEdu.Text) = "" Then txtSonNonEdu.Text = 0
        If IsNumeric(txtSonNonEdu.Text) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_SonNonEdu", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 0
            txtSonNonEdu.Focus()
            Exit Sub
        End If
        If txtforeignDate.Text <> "  /  /" And IsDate(ConvertDate(txtforeignDate.Text)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_ForeignDate", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 2
            txtforeignDate.Focus()
            Exit Sub
        End If
        If txtDriveDate.Text <> "  /  /" And IsDate(ConvertDate(txtDriveDate.Text)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_DriveDate", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 2
            txtDriveDate.Focus()
            Exit Sub
        End If
        If txtSoldierDate.Text <> "  /  /" And IsDate(ConvertDate(txtSoldierDate.Text)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_SoldierDate", MessageBoxIcon.Information)
            TabControl2.SelectedTabIndex = 2
            txtSoldierDate.Focus()
            Exit Sub
        End If


        '  เอาไว้ใช้กับการ Update สำหรับพนักงานที่ออกไปแล้ว
        If lblWorkStatus.Text = "T" Then
            If txtTermiDate.Text <> "  /  /" And IsDate(ConvertDate(txtTermiDate.Text)) = False Then
                MsgManager.ShowDialog(Me, "Messages", Me.Text, "Input_TermiDate", MessageBoxIcon.Information)
                txtSoldierDate.Focus()
                Exit Sub
            End If
        End If


        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList


        Dim CompanyID As String
        Dim EmpBankId As String
        CompanyID = LoadCompanyID(cmbCompanyName.Text)
        EmpBankId = GetBankID(Trim(cboBank.Text))

        '  Try
        ' เรียงจากซ้ายไปขวา  จากบนลงล่าง
        ' ข้อมูลที่หัว ====================================================================

        Data.Clear() : strType = ""
        Data.Add(txtCode_D.Text.Trim) : strType &= "T"
        Data.Add(txtAccountCode.Text.Trim) : strType &= "T"
        Data.Add(cboTitle.Text.Trim) : strType &= "T"
        Data.Add(txtFname_Det.Text.Trim) : strType &= "T"
        Data.Add(txtLname.Text.Trim) : strType &= "T"
        Data.Add(cboTitleEng.Text.Trim) : strType &= "T"
        Data.Add(txtFnameEng.Text.Trim) : strType &= "T"
        Data.Add(txtLnameEng.Text.Trim) : strType &= "T"
        Data.Add(txtNickName.Text.Trim) : strType &= "T"
        Data.Add(txtWorkingPlace.Text.Trim) : strType &= "T"
        Data.Add(txtDivID.Text.Trim) : strType &= "T"
        Data.Add(txtDeptId.Text.Trim) : strType &= "T"
        Data.Add(txtSecId_Det.Text.Trim) : strType &= "T"
        Data.Add(txtPosition.Text.Trim) : strType &= "T"
        '14

        ' ข้อมูลส่วนตัว ส่วนที่ 1

        If txtDateIn.Text = "  /  /" Then
            Data.Add(DBNull.Value) : strType &= "T"
        Else
            '  Dim bb As String
            ' bb = ConvertDate(txtDateIn.Text.Trim)
            ' Data.Add(ConvertDate(Format(txtDateIn.Text.Trim, "dd/MM/yyyy"))) : strType &= "T"
            Data.Add(ConvertDate(txtDateIn.Text.Trim)) : strType &= "T"

        End If

        If txtTermiDate.Text = "  /  /" Then
            Data.Add(DBNull.Value) : strType &= "T"
        Else
            '  Data.Add(ConvertDate(Format(txtTermiDate.Text.Trim, "dd/MM/yyyy"))) : strType &= "T"
            Data.Add(ConvertDate(txtTermiDate.Text.Trim)) : strType &= "T"
        End If

        If txtDatePro.Text = "  /  /" Then
            Data.Add(DBNull.Value) : strType &= "T"
        Else
            '  Data.Add(ConvertDate(Format(txtDatePro.Text.Trim, "dd/MM/yyyy"))) : strType &= "T"
            Data.Add(ConvertDate(txtDatePro.Text.Trim)) : strType &= "T"
        End If

        If txtBirth.Text = "  /  /" Then
            Data.Add(DBNull.Value) : strType &= "T"
        Else
            '   Data.Add(ConvertDate(Format(txtBirth.Text.Trim, "dd/MM/yyyy"))) : strType &= "T"
            Data.Add(ConvertDate(txtBirth.Text.Trim)) : strType &= "T"
        End If

        Data.Add(txtAddress.Text.Trim) : strType &= "T"
        Data.Add(txtIdCard.Text.Trim) : strType &= "T"
        Data.Add(IIf(cboSex.SelectedIndex = 0, "M", "F")) : strType &= "T"

        If txtDateExpire.Text = "  /  /" Then
            Data.Add(DBNull.Value) : strType &= "T"
        Else
            '  Data.Add(ConvertDate(Format(txtDateExpire.Text.Trim, "dd/MM/yyyy"))) : strType &= "T"
            Data.Add(ConvertDate(txtDateExpire.Text.Trim)) : strType &= "T"
        End If


        Data.Add(txtPlaceIdCard.Text.Trim) : strType &= "T"
        Data.Add(txtTaxId.Text.Trim) : strType &= "T"
        Data.Add(txtEducation.Text.Trim) : strType &= "T"
        Data.Add(txtMarryName.Text.Trim) : strType &= "T"
        Data.Add(IIf(cboMateSpit.SelectedIndex = 0, 0, 1)) : strType &= "B"
        '13  = 27
        ' ส่วนที่ 2
        Data.Add(txtMarryWorkCom.Text.Trim) : strType &= "T"
        Data.Add(txtBankId.Text.Trim) : strType &= "T"
        Data.Add(txtTypeBank.Text.Trim) : strType &= "T"
        Data.Add(txtSocTax.Text.Trim) : strType &= "T"
        Data.Add(txtStatus.Text.Trim) : strType &= "T"
        Data.Add(IIf(OptMonth.Checked = True, "M", "D")) : strType &= "T"
        Data.Add(IIf(chkContractor.Checked = True, 1, 0)) : strType &= "B"
        Data.Add(txtSalary.Text.Trim) : strType &= "T"
        Data.Add(txtBonus.Text.Trim) : strType &= "T"
        Data.Add(GetWeek_Code(cboWeek.Text.Trim)) : strType &= "T"
        Data.Add(gData.GetGroupId(cboEmpGroup.Text.Trim)) : strType &= "T"
        Data.Add(IIf(optCash.Checked = True, "B", "C")) : strType &= "T"
        Data.Add(EmpBankId.Trim) : strType &= "T"
        Data.Add(CompanyID.Trim) : strType &= "T"
        Data.Add(gData.getBrokerId(cboBroker.Text.Trim)) : strType &= "T"
        '15  =42


        '  Math.Round(Int(txtA_ENT.Text), 2)
        ' ข้อมูลบุตร และ ข้อมูลคำนวณภาษี =====================================================================
        Data.Add(Math.Round(Int(txtPremium.Text), 2)) : strType &= "T"
        Data.Add(Math.Round(Int(txtPremium.Text), 2)) : strType &= "T"
        Data.Add(Math.Round(Int(txtLoan.Text), 2)) : strType &= "T"
        Data.Add(Math.Round(Int(txtDonate.Text), 2)) : strType &= "T"
        Data.Add(Math.Round(Int(txtCapitalSumary.Text), 2)) : strType &= "T"

        Data.Add(cboPremiumMStart.SelectedItem.ToString) : strType &= "T"
        Data.Add(cboLoanMStart.SelectedItem.ToString) : strType &= "T"
        Data.Add(cboDonateMStart.SelectedItem.ToString) : strType &= "T"
        Data.Add(txtSonEdu.Text.Trim) : strType &= "T"
        Data.Add(txtSonNonEdu.Text.Trim) : strType &= "T"
        Data.Add(IIf(chkCalSocTax.Checked = True, 1, 0)) : strType &= "B"
        '11 = 53
        ' Text ข้อมูลที่เก็บชื่อลูก กับอายุลูก แยกไปทำอีกที่เพราะว่ามันต้อง Delete และ Insert เข้าไปใหม่


        ' อื่นๆ  ส่วนที่ 1=============================================================

        Data.Add(txtRace.Text.Trim) : strType &= "T"
        Data.Add(txtNationalily.Text.Trim) : strType &= "T"
        Data.Add(txtReligion.Text.Trim) : strType &= "T"
        Data.Add(txtTelContract.Text.Trim) : strType &= "T"
        Data.Add(txtforeignNo.Text.Trim) : strType &= "T"

        If txtforeignDate.Text = "  /  /" Then
            Data.Add(DBNull.Value) : strType &= "T"
        Else
            '    Data.Add(ConvertDate(Format(txtforeignDate.Text.Trim, "dd/MM/yyyy"))) : strType &= "T"
            Data.Add(ConvertDate(txtforeignDate.Text.Trim)) : strType &= "T"
        End If
        Data.Add(txtDriveNo.Text.Trim) : strType &= "T"

        If txtDriveDate.Text = "  /  /" Then
            Data.Add(DBNull.Value) : strType &= "T"
        Else
            '   Data.Add(ConvertDate(Format(txtDriveDate.Text.Trim, "dd/MM/yyyy"))) : strType &= "T"
            Data.Add(ConvertDate(txtDriveDate.Text.Trim)) : strType &= "T"
        End If

        Data.Add(txtDrivePlace.Text.Trim) : strType &= "T"
        Data.Add(cboSoldierStatus.Text.Trim) : strType &= "T"

        If txtSoldierDate.Text = "  /  /" Then
            Data.Add(DBNull.Value) : strType &= "T"
        Else
            '   Data.Add(ConvertDate(Format(txtSoldierDate.Text.Trim, "dd/MM/yyyy"))) : strType &= "T"
            Data.Add(ConvertDate(txtSoldierDate.Text.Trim)) : strType &= "T"
        End If

        ' 11 =  64
        ' ส่วนที่ 2

        Data.Add(txtFatherName.Text.Trim) : strType &= "T"
        Data.Add(txtFatherIdCard.Text.Trim) : strType &= "T"
        Data.Add(IIf(chkFatherCalTax.Checked = True, 1, 0)) : strType &= "B"

        Data.Add(txtMatherName.Text.Trim) : strType &= "T"
        Data.Add(txtMatherIdCard.Text.Trim) : strType &= "T"
        Data.Add(IIf(chkMatherCalTax.Checked = True, 1, 0)) : strType &= "B"

        Data.Add(txtFatherNameMate.Text.Trim) : strType &= "T"
        Data.Add(txtFatherIdCardMate.Text.Trim) : strType &= "T"
        Data.Add(IIf(chkFatherCalTaxMate.Checked = True, 1, 0)) : strType &= "B"

        Data.Add(txtMatherNameMate.Text.Trim) : strType &= "T"
        Data.Add(txtMatherIdCardMate.Text.Trim) : strType &= "T"
        Data.Add(IIf(chkMatherCalTaxMate.Checked = True, 1, 0)) : strType &= "B"

        Data.Add(txtGuaranteeName.Text.Trim) : strType &= "T"
        Data.Add(txtGuanWork.Text.Trim) : strType &= "T"
        Data.Add(txtErContract.Text.Trim) : strType &= "T"
        Data.Add(txtEr_Tel.Text.Trim) : strType &= "T"
        Data.Add(txtEduSpacial.Text.Trim) : strType &= "T"
        Data.Add(txtRemark.Text.Trim) : strType &= "T"
        Data.Add(IIf(chkPro_Fund.Checked = True, 1, 0)) : strType &= "B"
        '19 = 83

        ' Attendant
        Data.Add(IIf(cboOt.SelectedIndex = 0, 1, 0)) : strType &= "B"
        Data.Add(IIf(chkCalLate.Checked = True, 1, 0)) : strType &= "B"
        Data.Add(IIf(chkCalOtDeduc.Checked = True, 1, 0)) : strType &= "B"

        '3 =86

        strSQL = "Update Emp Set AccountCode = @P2,Title=@P3,Fname=@P4,Lname=@P5, " & _
                                " TitleEng=@P6,FnameEng=@P7,LnameEng=@P8,NickName=@P9,WorkingPlace=@P10, " & _
                                " Divid=@P11,Deptid=@P12,SecId=@P13,Position=@P14,DateIn=@P15, " & _
                                " Termidate=@P16,DatePro=@P17,Birthday=@P18,Address=@P19,IDCard=@P20, " & _
                                " Sex=@P21,DateExpire=@P22,Placeidcard=@P23,TaxId=@P24,Education=@P25, " & _
                                " MarryName=@P26,Matespit=@P27,MarryWorkcom=@P28,BankId=@P29,TypeBank=@P30," & _
                                " SocTaxId=@P31,Status=@P32,WageType=@P33,Contractor=@P34,Salary=@P35, " & _
                                " Bonus=@P36,Wk_Code=@P37,GroupId=@P38,Paytype=@P39,EmpBankId=@P40, " & _
                                " CompanyId=@P41,BrokerId=@P42,A_Ent=@P43,Premium=@P44,Loan=@P45, " & _
                                " Donate=@P46,Capitalsumary=@P47,premiumMstart=@P48,LoanMstart=@P49,donateMstart=@P50, " & _
                                " SonEdu=@P51, SonNonedu=@P52,CalSocTax=@P53,Race=@P54,Nationality=@P55, " & _
                                " Religion=@P56,TelContract=@P57,foreignNo=@P58,foreignDate=@P59,DriverNo=@P60, " & _
                                " DriverDate=@P61,DriverPlace=@P62,SoldierStatus=@P63,SoldierDate=@P64,FatherName=@P65, " & _
                                " FatherIdCard=@P66,FatherCalTax=@P67,MatherName=@P68,MatherIdcard=@P69,MatherCalTax=@P70, " & _
                                " FatherNameMate=@P71,FatherIdCardMate=@P72,FatherCalTaxMate=@P73,MatherNameMate=@P74,MatherIdCardMate=@P75, " & _
                                " MatherCalTaxMate=@P76,GuaranteeName=@P77,GuaranWork=@P78,ErContract=@P79,Er_Tel=@P80, " & _
                                " Eduspacial=@P81,Remark=@P82,Pro_Fund=@P83,OT=@P84,CalLate=@P85,CalOtdeduc=@P86" & _
                 " Where Code = @P1 "
        Try

            Call dbMgr.OpenDatabase(Conn, True)
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
            Call dbMgr.OpenDatabase(Conn, False)
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Me.Text)
            Exit Sub
        End Try



        ' Delete Son --------------------
        Call Delet_Son(txtCode_D.Text.Trim)

        ' Insert Son ----------------------
        Call Insert_Son(txtCode_D.Text.Trim)

        ' Training
        Call Delete_Training(txtCode_D.Text.Trim)
        Call Insert_Training(txtCode_D.Text.Trim)


        ' InsertBarcode ของพนักงาน ======================
        Try
            Data.Clear() : strType = ""
            Data.Add(txtCode_D.Text.Trim) : strType &= "T"
            Data.Add(txtBarcode.Text.Trim) : strType &= "T"

            strSQL = "Update EmpSetBarcode Set Barcode = @P2" & _
                    " Where Code = @P1 "

            Call dbMgr.OpenDatabase(Conn, True)
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
            Call dbMgr.OpenDatabase(Conn, False)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        MsgManager.ShowDialog(Me, "Messages", Me.Text, "Edit_Complete", MessageBoxIcon.Information)
        ' Call btnClear_Click(Me, System.EventArgs.Empty)
        Call LoadData_Detail(e, System.EventArgs.Empty)
        Call EnaCmd(False, True, True)
    End Sub

    Private Sub Delet_Son(Code As String)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim db As New db
        Dim dcmd As New SqlCommand
        Dim StrType As String = ""
        Dim Data As New ArrayList

        Try
            Dim SqlDel As String = ""
            Data.Clear() : strType = ""
            Data.Add(txtCode_D.Text.Trim) : strType &= "T"

            Strsql = "Delete from Son" & _
                    " Where code = @P1 "
            Call dbMgr.OpenDatabase(Conn, True)
            db.ExecuteCommand(Conn, dCmd, Strsql, strType, Data)
            Call dbMgr.OpenDatabase(Conn, False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' Delete Son

    End Sub


    Private Sub LoadTitleThai_Eng()
        cboTitle.Items.Add("นาย")
        cboTitle.Items.Add("นาง")
        cboTitle.Items.Add("นางสาว")
        cboTitle.Items.Add("Mr.")
        cboTitle.Items.Add("Mrs.")
        cboTitle.Items.Add("Miss")


        cboTitleEng.Items.Add("Mr.")
        cboTitleEng.Items.Add("Mrs.")
        cboTitleEng.Items.Add("Miss")
        cboTitleEng.Items.Add("นาย")
        cboTitleEng.Items.Add("นาง")
        cboTitleEng.Items.Add("นางสาว")

    End Sub

    Private Sub Insert_Son(code As String)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim db As New db
        Dim dcmd As New SqlCommand
        Dim StrType As String = ""
        Dim Data As New ArrayList
        ' Insert Son
        Dim i As Integer = 0




        If (txtSonName1.Text = "" And txtSonName2.Text = "" And txtSonName3.Text = "" _
            And txtSonName4.Text = "" And txtSonName5.Text = "") Then
        Else
            If txtSonName1.Text <> "" Then
                Data.Clear() : StrType = ""
                Data.Add(txtCode_D.Text.Trim) : StrType &= "T"
                Data.Add(txtSonName1.Text.Trim) : StrType &= "T"
                Data.Add(txtSonAge1.Text.Trim) : StrType &= "S"

                Strsql = "Insert into Son (code,SonName,Age) values (@P1,@P2,@P3)"

                Call dbMgr.OpenDatabase(Conn, True)
                db.ExecuteCommand(Conn, dcmd, Strsql, StrType, Data)
                Call dbMgr.OpenDatabase(Conn, False)
            End If

            If txtSonName2.Text <> "" Then
                Data.Clear() : StrType = ""
                Data.Add(txtCode_D.Text.Trim) : StrType &= "T"
                Data.Add(txtSonName2.Text.Trim) : StrType &= "T"
                Data.Add(txtSonAge2.Text.Trim) : StrType &= "S"

                Strsql = "Insert into Son (code,SonName,Age) values (@P1,@P2,@P3)"

                Call dbMgr.OpenDatabase(Conn, True)
                db.ExecuteCommand(Conn, dcmd, Strsql, StrType, Data)
                Call dbMgr.OpenDatabase(Conn, False)
            End If
            If txtSonName3.Text <> "" Then
                Data.Clear() : StrType = ""
                Data.Add(txtCode_D.Text.Trim) : StrType &= "T"
                Data.Add(txtSonName3.Text.Trim) : StrType &= "T"
                Data.Add(txtSonAge3.Text.Trim) : StrType &= "S"

                Strsql = "Insert into Son (code,SonName,Age) values (@P1,@P2,@P3)"

                Call dbMgr.OpenDatabase(Conn, True)
                db.ExecuteCommand(Conn, dcmd, Strsql, StrType, Data)
                Call dbMgr.OpenDatabase(Conn, False)
            End If
            If txtSonName4.Text <> "" Then
                Data.Clear() : StrType = ""
                Data.Add(txtCode_D.Text.Trim) : StrType &= "T"
                Data.Add(txtSonName4.Text.Trim) : StrType &= "T"
                Data.Add(txtSonAge4.Text.Trim) : StrType &= "S"

                Strsql = "Insert into Son (code,SonName,Age) values (@P1,@P2,@P3)"

                Call dbMgr.OpenDatabase(Conn, True)
                db.ExecuteCommand(Conn, dcmd, Strsql, StrType, Data)
                Call dbMgr.OpenDatabase(Conn, False)
            End If
            If txtSonName5.Text <> "" Then
                Data.Clear() : StrType = ""
                Data.Add(txtCode_D.Text.Trim) : StrType &= "T"
                Data.Add(txtSonName5.Text.Trim) : StrType &= "T"
                Data.Add(txtSonAge5.Text.Trim) : StrType &= "S"

                Strsql = "Insert into Son (code,SonName,Age) values (@P1,@P2,@P3)"

                Call dbMgr.OpenDatabase(Conn, True)
                db.ExecuteCommand(Conn, dcmd, Strsql, StrType, Data)
                Call dbMgr.OpenDatabase(Conn, False)
            End If
        End If
    End Sub

    Public Overrides Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If MsgManager.ConfirmDialog(Me, "Messages", Me.Text, "Del_Confirm_Msg", MessageBoxIcon.Information) = Windows.Forms.DialogResult.Cancel Then Exit Sub

        'If txtSecId.Text.Trim = "" Then
        '    MsgManager.ShowDialog(Me, "Messages", Me.Text, "ID_IsBlank", MessageBoxIcon.Information)
        '    txtSecId.Focus()
        '    Exit Sub
        'End If

        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList

        Data.Clear() : strType = ""
        Data.Add(txtCode_D.Text.Trim) : strType &= "T"

        strSQL = "Delete From Emp " & _
                " Where Code = @P1 "

        Try
            Call dbMgr.OpenDatabase(Conn, True)
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
            Call dbMgr.OpenDatabase(Conn, False)
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Me.Text)
            Exit Sub
        End Try


        Data.Clear() : strType = ""
        Data.Add(txtCode_D.Text.Trim) : strType &= "T"

        strSQL = "Delete From empsetbarcode " & _
                " Where Code = @P1 "

        Try
            Call dbMgr.OpenDatabase(Conn, True)
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
            Call dbMgr.OpenDatabase(Conn, False)
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Me.Text)
            Exit Sub
        End Try


        ' Delete Son
        Call Delet_Son(txtCode_D.Text.Trim)

        ' Training
        Call Delete_Training(txtCode_D.Text.Trim)

        MsgManager.ShowDialog(Me, "Messages", Me.Text, "Del_Complete", MessageBoxIcon.Information)
        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Public Overrides Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Call LoadData()
        Call ClearData(True)
        Call EnaCmd(True, False, False)

        Call btnTrain_Clear_Click(Me, System.EventArgs.Empty)

        TabControl1.SelectedTabIndex = 1
        txtCode_D.Enabled = True
        txtCode_D.Text = ""
        PicBox.Image = Nothing
        ' txtCode_D.Text = AutoNumber()
        txtCode_D.Focus()
    End Sub

    Private Sub lstData_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstData.DoubleClick
        If LstData.SelectedItems.Count = 0 Then Exit Sub
        Call LoadAllData()
        TabControl1.SelectedTabIndex = 1

        With LstData
            If .SelectedItems.Count = 0 Then Exit Sub
            lblCurRecord.Text = LstData.Items.IndexOf(.SelectedItems(0))
        End With

        For i = 0 To LstData.SelectedItems.Count - 1
            txtCode_D.Text = LstData.SelectedItems(i).SubItems(1).Text.Trim
        Next

        Call LoadData_Detail(e, System.EventArgs.Empty)
        Call EnaCmd(False, True, True)
    End Sub

    Private Sub ClearData(ByVal ClearAll As Boolean)
        'If ClearAll = True Then
        '    txtSecId.Text = AutoId()
        'End If
        '  txtSection.Text = ""
        'txtCode_D.Text = ""
        txtBarcode.Text = ""
        txtAccountCode.Text = ""
        cboTitle.SelectedIndex = 0
        txtFname_Det.Text = ""
        txtLname.Text = ""
        cboTitleEng.Text = ""
        txtFnameEng.Text = ""
        txtLnameEng.Text = ""
        txtNickName.Text = ""
        txtWorkingPlace.Text = ""
        txtDivID.Text = ""
        txtDivision.Text = ""
        txtDeptId.Text = ""
        txtDepartment.Text = ""
        txtSecId_Det.Text = ""
        txtSection_Det.Text = ""
        txtPosition.Text = ""


        ' ข้อมูลส่วนตัว
        txtDateIn.Text = ""
        txtTermiDate.Text = ""
        txtWorkAge.Text = ""
        txtDatePro.Text = ""
        txtBirth.Text = ""
        txtAge.Text = ""
        txtAddress.Text = ""
        txtIdCard.Text = ""
        cboSex.SelectedIndex = 0
        txtDateExpire.Text = ""
        txtPlaceIdCard.Text = ""
        txtTaxId.Text = ""
        txtEducation.Text = ""
        txtMarryName.Text = ""
        cboMateSpit.SelectedIndex = 0
        txtMarryWorkCom.Text = ""
        txtBankId.Text = ""
        txtTypeBank.Text = ""
        txtSocTax.Text = ""
        txtStatus.Text = ""
        txtSocTax.Text = ""
        txtStatus.Text = ""
        OptMonth.Checked = True
        chkContractor.Checked = False
        txtSalary.Text = ""
        txtBonus.Text = ""
        cboWeek.SelectedIndex = 0
        cboEmpGroup.Text = ""
        optBank.Checked = True
        cboBank.SelectedIndex = 0
        cmbCompanyName.SelectedIndex = 1
        cboBroker.SelectedIndex = 0

        ' ซ่อน text วันที่ลาออก 
        txtTermiDate.Visible = False
        lblTermiDate.Visible = False
        ' สถานนะทำงาน
        lblWorkStatus.Text = "W"



        ' บุตร ข้อมูลคำนวณภาษี
        txtA_ENT.Text = "0"
        txtPremium.Text = "0"
        txtLoan.Text = "0"
        txtDonate.Text = "0"
        txtCapitalSumary.Text = "0"
        cboPremiumMStart.SelectedIndex = 0
        cboLoanMStart.SelectedIndex = 0
        cboDonateMStart.SelectedIndex = 0
        txtSonEdu.Text = "0"
        txtSonNonEdu.Text = "0"
        txtSonName1.Text = ""
        txtSonName2.Text = ""
        txtSonName3.Text = ""
        txtSonName4.Text = ""
        txtSonName5.Text = ""
        txtSonAge1.Text = "0"
        txtSonAge2.Text = "0"
        txtSonAge3.Text = "0"
        txtSonAge4.Text = "0"
        txtSonAge5.Text = "0"
        chkCalSocTax.Checked = False


        ' อื่นๆๆ
        txtRace.Text = ""
        txtNationalily.Text = ""
        txtReligion.Text = ""
        txtTelContract.Text = ""
        txtforeignNo.Text = ""
        txtDriveNo.Text = ""
        txtDrivePlace.Text = ""
        cboSoldierStatus.SelectedIndex = 0
        txtFatherName.Text = ""
        txtMatherName.Text = ""
        txtFatherNameMate.Text = ""
        txtMatherNameMate.Text = ""
        txtGuaranteeName.Text = ""
        txtErContract.Text = ""
        txtEduSpacial.Text = ""
        txtRemark.Text = ""
        txtforeignDate.Text = ""
        txtDriveDate.Text = ""
        txtSoldierDate.Text = ""
        txtFatherIdCard.Text = ""
        txtMatherIdCard.Text = ""
        txtFatherIdCardMate.Text = ""
        txtMatherIdCardMate.Text = ""
        txtGuanWork.Text = ""
        txtEr_Tel.Text = ""
        chkPro_Fund.Checked = False


        ' ยอดเงินสะสม
        cboYear.Text = ""
        lblAccGrossTax.Text = ""
        lblAccBonus.Text = ""
        lblAccTax.Text = ""
        lblAccGrossSoc.Text = ""
        lblAccSocTax.Text = ""
        lblAccuPF.Text = ""
        lblAccuPFAll.Text = ""
        lstMonthly.Items.Clear()

        txtMonth_Year.Text = ""
        txtGrossTax.Text = ""
        txtTax.Text = ""
        txtGrossSoc.Text = ""
        txteSocTax.Text = ""
        txteRemark.Text = ""
        lstAdd.Items.Clear()

        ' VISA  / PASSPORT
        txtVisa_IssuedDate.Text = ""
        txtVisa_ExperiedDate.Text = ""
        lstVisa.Items.Clear()
        txtpp_NO.Text = ""
        txtpp_Issueddate.Text = ""
        txtpp_Experieddate.Text = ""
        lstPassport.Items.Clear()

        ' Attendant
        cboOt.SelectedIndex = 0
        chkCalLate.Checked = False
        chkCalOtDeduc.Checked = False

        'สิทธิการลาในแต่ละปี
        cboPrivilegeYear.Text = ""
        lstPrivilege.Items.Clear()




    End Sub

    Private Sub LoadData()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        strSQL = "Select emp.code,Barcode = Isnull(b.barcode,''), Title + Fname + '  ' + Lname as FullName," & _
                                        " DeptId," & _
                                        " DateIn=Isnull(DateIn,'')," & _
                                        " WorkingPlace,LastUpdate " & _
                                        " ,CompanyName = Isnull(C.CompanyName,'') " & _
                    " From Emp Left Join Company_Sub C " & _
                                                " On Emp.CompanyId = C.CompanyId " & _
                                        " Left Join EmpSetBarcode B " & _
                                                " On Emp.Code = B.Code " & _
                    " Where 1=1"


        If StatusEmp = "W" Then
            strSQL &= " And WorkStatus='W'"
        ElseIf StatusEmp = "T" Then
            strSQL &= " And WorkStatus='T'"
        End If

        If cboCompany.SelectedIndex > 0 Then
            strSQL &= " and Emp.CompanyId = '" & GetCompanyID(Trim(cboCompany.Text)) & "'"
        End If


        If txtCode.Text <> "" Then
            strSQL &= " And Emp.Code like'%" & txtCode.Text & "%' "
        End If

        If txtFname.Text <> "" Then
            strSQL &= " And Emp.Fname like '%" & txtFname.Text & "%'"
        End If

        If optCode.Checked = True Then
            strSQL &= " Order By Code"
        ElseIf optDept.Checked = True Then
            strSQL &= " Order By DeptId,Code"
        ElseIf optCompany.Checked = True Then
            strSQL &= " Order By Emp.CompanyId,Code"
        Else
            strSQL &= " Order By Fname,DeptId,Code"
        End If


        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dCmd, strSQL)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)

        Dim list As ListViewItem = Nothing
        Dim arrData() As String = Nothing
        With Ds.Tables("data")
            lstData.BeginUpdate()
            lstData.Items.Clear()
            Dim date_Work As String = ""
            Dim Date_ As String = ""
            Dim I As Integer
            Dim DateIn_ As Date
            PG1.Maximum = .Rows.Count

            Dim DateNow As DateTime
            DateNow = Now
            For Each dr As DataRow In .Rows
                I += 1
                PG1.Value = I
                Date_ = dr("datein")
                If Date_ = "" Then
                    date_Work = ""
                Else
                    date_Work = CalAge(dr("dateIn"), DateNow)
                End If
                DateIn_ = dr("DateIn")

                arrData = New String() {LstData.Items.Count + 1, _
                                        dr("Code"), _
                                        dr("Barcode"), _
                                        dr("FullName"), _
                                        dr("DeptId"), _
                                        Format(DateIn_, "dd/MM/yyyy"), _
                                        date_Work.Trim, _
                                        dr("CompanyName"), _
                                        dr("WorkingPlace"), _
                                        Format(dr("LastUpdate"), "dd/MM/yyyy HH:mm:ss")}
                list = New ListViewItem(arrData)
                LstData.Items.Add(list)
            Next
            lstData.EndUpdate()
        End With
    End Sub

    Public Function CalAge(DateFrom As Date, DateTo As Date) As String
        ' Dim DayAll As Single
        Dim y As Integer
        Dim M As Integer
        Dim D As Integer
        Dim stY As Integer
        Dim stM As Integer
        Dim stD As Integer
        Dim spY As Integer
        Dim spM As Integer
        Dim spD As Integer
        stY = Year(DateTo)
        stM = Month(DateTo)
        '  stD = Day(DateTo)
        stD = DateTo.Day

        spY = Year(DateFrom)
        spM = Month(DateFrom)
        ' spD = Day(DateFrom)
        spD = DateFrom.Day

        ' Day
        If stD < spD Then
            stM = stM - 1
            stD = stD + 30
        End If
        D = stD - spD
        ' Month
        If stM < spM Then
            stY = stY - 1
            stM = stM + 12
        End If
        M = stM - spM
        ' Year
        y = stY - spY

        '        DayAll = DateDiff("d", DateFrom, DateTo)
        '        Y = DayAll \ 365
        '        M = (DayAll Mod 365) \ 30
        '        D = ((DayAll Mod 365) Mod 30) Mod 30
        Return y & " y. " & M & " m." & D & " d."
    End Function

    Private Sub LoadItem(ByVal ID As String)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        Dim Data As New ArrayList
        Dim strType As String = ""

        Data.Clear() : strType = ""
        Data.Add(ID) : strType &= "T"

        strSQL = "Select * from Emp " & _
                " Where code = @P1"
        Try
            Call dbMgr.OpenDatabase(Conn, True)
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
            Da.SelectCommand = dCmd
            Da.Fill(Ds, "data")
            Call dbMgr.OpenDatabase(Conn, False)
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Me.Text)
            Exit Sub
        End Try

        With Ds.Tables("Data")
            If .Rows.Count = 0 Then
                Call ClearData(False)
                Call EnaCmd(True, False, False)
                Exit Sub
            End If

            Call EnaCmd(False, True, True)

            Dim dr As DataRow = .Rows(0)
            'txtSecId.Text = dr("GroupId")
            'txtSection.Text = dr("GroupName")
            txtCode_D.Text = dr("Code")
        End With

    End Sub

    'Private Sub txtDivId_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSecId.LostFocus
    '    ' Call LoadItem(txtSecId.Text.Trim)
    'End Sub

    Function IsID_IsExist(ByVal ID As String) As Boolean
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        Dim Data As New ArrayList
        Dim strType As String = ""

        Data.Clear() : strType = ""
        Data.Add(ID) : strType &= "T"

        strSQL = "Select * from EmpGroup" & _
                " Where GroupId = @P1"
        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        End With
    End Function

    'Private Sub txtDivId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSecId.TextChanged

    'End Sub

    Function AutoId() As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        strSQL = "Select Max(GroupId) as maxId From EmpGroup"

        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dCmd, strSQL)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return "01"
            Else
                Dim dr As DataRow = .Rows(0)
                Return Format(dr("MaxID") + 1, "00")
            End If
        End With
    End Function

    Private Sub LoadCompany()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        Strsql = "select CompanyID,CompanyName from Company_Sub Order By CompanyID"
        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dCmd, strsql)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)


        cboCompany.Items.Clear()
        cmbCompanyName.Items.Clear()
        cboCompany.Items.Add(MsgManager.ShowLabel(Me, "Labels", "All"))  ' ทั้งหมด
        cmbCompanyName.Items.Add("")
        With Ds.Tables("data")

            For Each dr As DataRow In .Rows
                cboCompany.Items.Add(dr("CompanyName"))
                cmbCompanyName.Items.Add(dr("CompanyName"))
            Next
        End With
        If cboCompany.Items.Count >= 1 Then
            cboCompany.SelectedIndex = 1
        End If

        If cmbCompanyName.Items.Count >= 1 Then
            cmbCompanyName.SelectedIndex = 1
        End If


    End Sub

    Private Sub LoadCompany_Detail()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        Strsql = "Select CompanyName From Company_Sub Order By CompanyName"
        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dCmd, strSQL)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)

        cmbCompanyName.Items.Clear()
        cmbCompanyName.Items.Add("")
        With Ds.Tables("data")

            For Each dr As DataRow In .Rows
                cmbCompanyName.Items.Add(dr("CompanyName"))
            Next
        End With
    End Sub


    Function GetCompanyID(CompanyName As String) As String
        Dim Strsql As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim dcmd As New SqlCommand
        Dim db As New db

        Strsql = "select Top 1 CompanyID,CompanyName " & _
                    " from Company_Sub " & _
                    " Where CompanyName = '" & Trim(CompanyName) & "' " & _
                    " Order By CompanyID"

        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dCmd, Strsql)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("CompanyID")
            End If
        End With
    End Function

    Private Sub cmdRefresh_Click(sender As System.Object, e As System.EventArgs) Handles cmdRefresh.Click
        PG1.Visible = True
        cmdRefresh.Enabled = False
        cboCompany.Enabled = False
        Call LoadData()

        cmdRefresh.Enabled = True
        cboCompany.Enabled = True

        PG1.Visible = False
    End Sub

    Private Sub cmdSearch_Click(sender As System.Object, e As System.EventArgs) Handles cmdSearch.Click
        ''  Dim itmFound As ListItem
        'If OptEmpcode.Value = True Then
        '    itmFound = lstEmp.FindItem(Trim(txtCode.Text), lvwSubItem, , 1)
        '    If itmFound Is Nothing Then
        '        txtCode.SetFocus()
        '        Call HL_Text()
        '        Exit Sub
        '    Else
        '        itmFound.EnsureVisible()
        '        itmFound.Selected = True
        '        lstEmp.SetFocus()
        '    End If
        'ElseIf OptEmpName.Value = True Then
        ' Call LoadData_Like()
        Call LoadData()
        'End If
    End Sub

    Public Sub LoadData_Like()  ' ค้นหาตามชื่อ like
        Dim Strsql As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim dcmd As New SqlCommand
        Dim db As New db
        Dim arrdata() As String
        Dim List As ListViewItem

        Strsql = "Select emp.code,Barcode = Isnull(b.barcode,''), Title + Fname + '  ' + Lname as FullName,DeptId,DateIn,WorkingPlace,LastUpdate " & _
                                        " ,CompanyName = Isnull(C.CompanyName,'') " & _
                    " From Emp Left Join Company_Sub C " & _
                                                " On Emp.CompanyId = C.CompanyId " & _
                                        " Left Join EmpSetBarcode B " & _
                                                " On Emp.Code = B.Code " & _
                    " Where 1=1"


        If StatusEmp = "W" Then
            Strsql &= " And WorkStatus='W'"
        ElseIf StatusEmp = "T" Then
            Strsql &= " And WorkStatus='T'"
        End If

        If OptEmpcode.Checked = True Then
            Strsql &= "And Emp.code ='" & txtCode.Text & "'"
        ElseIf OptEmpName.Checked = True Then
            Strsql &= " And Emp.Fname like '%" & txtFname.Text & "%'"
        End If



        If cboCompany.SelectedIndex > 0 Then
            Strsql &= " and Emp.CompanyId = '" & GetCompanyID(Trim(cboCompany.Text)) & "'"
        End If

        If optCode.Checked = True Then
            Strsql &= " Order By Code"
        ElseIf optDept.Checked = True Then
            Strsql &= " Order By DeptId,Code"
        ElseIf optCompany.Checked = True Then
            Strsql &= " Order By Emp.CompanyId,Code"
        Else
            Strsql &= " Order By Fname,DeptId,Code"
        End If

        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dCmd, Strsql)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                lstData.Items.Clear()
                Exit Sub
            End If

            Dim I As Single
            Dim Date_ As String
            Dim date_Work As String
            I = 0
            PG1.Value = 0
            PG1.Maximum = .Rows.Count
            lstData.Items.Clear()

            For Each Dr As DataRow In .Rows
                I = I + 1
                PG1.Value = I

                Date_ = Dr("datein")
                If Date_ = "" Then
                    date_Work = ""
                Else
                    date_Work = CalAge(Dr("DateIn"), Format(Now, "dd/MM/yyyy"))
                End If

                arrData = New String() {lstData.Items.Count + 1, _
                                        Dr("Code"), _
                                        Dr("Barcode"), _
                                        Dr("FullName"), _
                                        Dr("DeptId"), _
                                        Format(Dr("DateIn"), "dd/MM/yyyy"), _
                                        date_Work, _
                                        Dr("CompanyName"), _
                                        Dr("WorkingPlace"), _
                                        Format(Dr("LastUpdate"), "dd/MM/yyyy")}
                List = New ListViewItem(arrData)
                lstData.Items.Add(List)
            Next

        End With

        Call SetItemDefault()
    End Sub


    Public Sub SetItemDefault()
        If IsNumeric(lblCurRecord.Text) = True Then
            Dim CurRec As Integer
            CurRec = CInt(lblCurRecord.Text)
            'If lstData.Items.Count >= CurRec And CurRec > 0 Then
            '    'itmX = lstData.Items(CurRec)
            '    'lstData.ListItems(CurRec).Selected = True
            '    'resultant = lstData.Items(CurRec).EnsureVisible = True
            'End If
        End If
    End Sub

    Private Sub OptEmpcode_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles OptEmpcode.CheckedChanged
        txtCode.Text = ""
        txtFname.Text = ""
        txtCode.Focus()
    End Sub

    Private Sub OptEmpName_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles OptEmpName.CheckedChanged
        txtFname.Text = ""
        txtCode.Text = ""
        txtFname.Focus()
    End Sub

    Private Sub cboCompany_Click(sender As Object, e As System.EventArgs) Handles cboCompany.Click
        'cmdRefresh.Enabled = False
        'cboCompany.Enabled = False

        'Call LoadData()

        'cmdRefresh.Enabled = True
        'cboCompany.Enabled = True
    End Sub

    Private Sub cboCompany_CursorChanged(sender As Object, e As System.EventArgs) Handles cboCompany.CursorChanged
        cmdRefresh.Enabled = False
        cboCompany.Enabled = False

        Call LoadData()

        cmdRefresh.Enabled = True
        cboCompany.Enabled = True
    End Sub


    Private Sub frmEmp_Load_1(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'btnSearch.Visible = False
        'btnPrint.Visible = False

        ''เฉพาะหน้าแรก
        'Call LoadCompany()
        'Call LoadData()
        'Call ClearData(True)
    End Sub


    Private Sub LoadAllData()
        Call LoadEmpGroup()
        Call LoadBank()

        If cboBank.Items.Count > 0 Then
            cboBank.SelectedIndex = 0
        End If
        cboEmpGroup.SelectedIndex = -1

        cboPremiumMStart.SelectedIndex = 0
        cboLoanMStart.SelectedIndex = 0
        cboDonateMStart.SelectedIndex = 0
        cboSex.SelectedIndex = 0


        Call LoadCompany_Detail()
        '   cmdMoveToTerminate.Visible = True

        Call LoadWeek()
        cboWeek.SelectedIndex = 0
        TabControl2.SelectedTabIndex = 0

        ' Add Year
        Call AddYear()
        Call LoadBroker()
    End Sub

    Private Sub AddYear()
        Dim I As Integer
        cboYear.Items.Clear()
        cboPrivilegeYear.Items.Clear()
        For I = -2 To 2
            cboYear.Items.Add(Format(Now, "yyyy") - I)
            cboPrivilegeYear.Items.Add(Format(Now, "yyyy") - I)
        Next
    End Sub

    Private Sub LoadBroker()
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db

        strsql = "select brokerName " & _
                " From BrokerGroup" & _
                " Order By BrokerId"

        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dCmd, strsql)
        da.SelectCommand = dCmd
        da.Fill(ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)

        With ds.Tables("data")
            cboBroker.Items.Clear()
            '     cboBroker.AddItem ("")

            For Each dr As DataRow In .Rows
                cboBroker.Items.Add(dr("BrokerName"))
            Next

        End With
    End Sub

    Private Sub LoadWeek()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db

        Strsql = "Select WK_Name From SAL_Week Order By WK_Code"

        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dCmd, Strsql)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                cboWeek.Items.Clear()
            Else
                cboWeek.Items.Clear()
                For Each dr As DataRow In .Rows
                    cboWeek.Items.Add(dr("WK_Name"))
                Next
            End If

        End With
    End Sub

    Private Sub LoadEmpGroup()
        '        On Error GoTo Err
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db

        Strsql = "Select GroupId,GroupName From EmpGroup" & _
                        " Order By GroupId"
        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dCmd, Strsql)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                cboEmpGroup.Items.Clear()
                cboEmpGroup.Items.Add("")
            Else
                cboEmpGroup.Items.Clear()
                cboEmpGroup.Items.Add("")
                For Each dr As DataRow In .Rows
                    cboEmpGroup.Items.Add(dr("GroupName"))
                Next
            End If
        End With
    End Sub

    Private Sub LoadBank()
        '        On Error GoTo Err
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim Db As New db

        Strsql = "Select BankId,BankName From Bank" & _
                        " Order By BankId"
        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dCmd, Strsql)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)


        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                cboBank.Items.Clear()
            Else
                cboBank.Items.Clear()
                '  cboBank.Items.Add("")
                For Each dr As DataRow In .Rows
                    cboBank.Items.Add(dr("BankName"))
                Next

            End If
        End With
    End Sub

    Private Sub LoadDefault()
        cboOt.SelectedIndex = 0
        txtStatus.SelectedIndex = 0
        cboSoldierStatus.SelectedIndex = 0
        cboSex.SelectedIndex = 0
    End Sub

    Private Sub LoadData_Detail(sender As Object, e As System.EventArgs)
        Dim strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        strsql = "Select " & _
                                    " Emp.Code,Barcode = Isnull(B.Barcode,'')," & _
                                    " DivId, DeptId,SecId = Isnull(SecId,'')," & _
                                    " WorkingPlace," & _
                                    " GroupName = Isnull(G.GroupName,'')," & _
                                    " Title, Fname, Lname,TitleEng, FnameEng, LnameEng," & _
                                    " NickName = Isnull(NickName,''),Sex = Isnull(Sex,'F'),DateIn,DatePro, BirthDay,Emp. Address, IdCard, DateExpire, PlaceIdCard, [Position], Emp.TaxId, Ot," & _
                                    " Education, Emp.BankId, TypeBank, Emp.SocTaxId, Status, MateSpit, MarryName, MarryWorkCom," & _
                                    " WageType,Contractor,Salary, Bonus, SonEdu, SonNonEdu, Race, Nationality," & _
                                    " Religion, TelContract, foreignNo, foreignDate, DriverNo, DriverDate, DriverPlace," & _
                                    " SoldierStatus, SoldierDate, FatherName, FatherIdCard, FatherCalTax, " & _
                                    " MatherName, MatherIdCard, MatherCalTax, FatherNameMate, FatherIdCardMate," & _
                                    " FatherCalTaxMate, MatherNameMate, MatherIdCardMate," & _
                                    " MatherCalTaxMate, GuaranteeName, GuaranWork, ErContract, Er_Tel, EduSpacial," & _
                                    " Remark, WorkStatus, TermiDate, Premium, PremiumMStart, Loan, " & _
                                    " LoanMStart , Donate, DonateMStart, CapitalSumary, A_ENT, LastUpdate," & _
                                    " Pro_Fund, CalSocTax, AccountCode, CalLate, CountLate, Emp.CompanyId, " & _
                                    " Convert(nVarchar(10),Getdate(),111) as SystemDate " & _
                                    " ,CompanyName = Isnull(C.CompanyName,''), " & _
                                    " CalLate = Isnull(CalLate,0), " & _
                                    " SalWeek = Isnull(Sal_Week.wk_Name,0) ," & _
                                    " PayType = Isnull(PayType,''), " & _
                                    " BrokerId = Isnull(BrokerId,'00'), "
        strsql &= " CalOTDeduc = Isnull(CalOtDeduc,0), " & _
                                " BankName = Isnull(Bank.BankName,'') "
        strsql &= " From Emp Left Join Company_Sub C  " & _
                                " On Emp.CompanyID = C.CompanyID " & _
                                " Left Join SAL_Week " & _
                                        " On Emp.wk_Code = SAL_Week.wk_Code " & _
                                " Left Join EmpSetBarcode B " & _
                                        " On Emp.Code = B.Code " & _
                                " Left Join EmpGroup G " & _
                                        " On Emp.GroupId = G.GroupId " & _
                                " Left Join Bank " & _
                                        " On Emp.EmpBankId = Bank.BankId " & _
        " Where Emp.code = '" & Trim(txtCode_D.Text) & "'"

        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dcmd, strsql)
        Da.SelectCommand = dcmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Call ClearData(True)
                Exit Sub
            End If

            Call LoadEmpImg()

            txtCode_D.Enabled = False

            For Each dr As DataRow In .Rows
                txtBarcode.Text = IIf(IsDBNull(dr("Barcode")), "", dr("Barcode"))

                txtDivID.Text = IIf(IsDBNull(dr("DIvId")), "", dr("DIvId")) : Call txtDivID_LostFocus(e, System.EventArgs.Empty)
                txtDeptId.Text = IIf(IsDBNull(dr("DeptId")), "", dr("DeptId")) : Call txtDeptId_LostFocus(e, System.EventArgs.Empty)
                txtSecId_Det.Text = IIf(IsDBNull(dr("SecId")), "", dr("SecId")) : Call txtSecId_Det_LostFocus(e, System.EventArgs.Empty)

                txtAccountCode.Text = IIf(IsDBNull(dr("AccountCode")), "", dr("AccountCode"))
                txtWorkingPlace.Text = IIf(IsDBNull(dr("WorkingPlace")), "", dr("WorkingPlace"))

                Dim I As Integer
                cboEmpGroup.SelectedIndex = -1
                For I = 0 To cboEmpGroup.Items.Count - 1
                    If cboEmpGroup.Items(I) = dr("GroupName") Then
                        cboEmpGroup.SelectedIndex = I
                    End If
                Next

                cboTitle.Text = IIf(IsDBNull(dr("Title")), "", dr("Title"))
                txtFname_Det.Text = IIf(IsDBNull(dr("Fname")), "", dr("Fname"))
                txtLname.Text = IIf(IsDBNull(dr("Lname")), "", dr("Lname"))
                cboTitleEng.Text = IIf(IsDBNull(dr("TitleEng")), "", dr("TitleEng"))
                txtFnameEng.Text = IIf(IsDBNull(dr("FnameEng")), "", dr("FnameEng"))
                txtLnameEng.Text = IIf(IsDBNull(dr("LnameEng")), "", dr("LnameEng"))
                txtNickName.Text = IIf(IsDBNull(dr("NickName")), "", dr("NickName"))

                Dim Sex As String
                Sex = IIf(IsDBNull(dr("Sex")), "", dr("Sex"))

                If Sex = "M" Then
                    cboSex.SelectedIndex = 0
                Else
                    cboSex.SelectedIndex = 1
                End If

                ' CompanyName
                cmbCompanyName.SelectedIndex = 0
                For I = 0 To cmbCompanyName.Items.Count - 1
                    If Trim(cmbCompanyName.Items(I)) = dr("CompanyName") Then
                        cmbCompanyName.SelectedIndex = I
                    End If
                Next

                ' Bank
                cboBank.SelectedIndex = 0
                For I = 0 To cboBank.Items.Count - 1
                    If Trim(cboBank.Items(I)) = dr("BankName") Then
                        cboBank.SelectedIndex = I
                    End If
                Next

                If IsDBNull(dr("DateIn")) = True Then
                    txtDateIn.Text = ""
                Else
                    txtDateIn.Text = Format(dr("DateIn"), "dd/MM/yyyy")
                End If

                If IsDBNull(dr("DatePro")) = True Then
                    txtDatePro.Text = ""
                Else
                    txtDatePro.Text = Format(dr("DatePro"), "dd/MM/yyyy")
                End If

                Call txtDateIn_LostFocus(e, System.EventArgs.Empty)
                If IsDBNull(dr("BirthDay")) = True Then
                    txtBirth.Text = ""
                Else
                    txtBirth.Text = Format(dr("BirthDay"), "dd/MM/yyyy")
                End If
                Call txtBirth_LostFocus(e, System.EventArgs.Empty)
                txtAddress.Text = IIf(IsDBNull(dr("Address")), "", dr("Address"))
                txtIdCard.Text = IIf(IsDBNull(dr("IdCard")), "", dr("IdCard"))


                If IsDBNull(dr("DateExpire")) = True Then
                    txtDateExpire.Text = ""
                Else
                    txtDateExpire.Text = Format(dr("DateExpire"), "dd/MM/yyyy")
                End If


                txtPlaceIdCard.Text = IIf(IsDBNull(dr("PlaceIdCard")), "", dr("PlaceIdCard"))
                txtPosition.Text = IIf(IsDBNull(dr("Position")), "", dr("Position"))
                txtTaxId.Text = IIf(IsDBNull(dr("TaxId")), "", dr("TaxId"))
                If dr("Ot") = True Or dr("Ot") = 1 Then
                    cboOt.SelectedIndex = 0
                Else
                    cboOt.SelectedIndex = 1
                End If
                txtEducation.Text = IIf(IsDBNull(dr("Education")), "", dr("Education"))
                txtBankId.Text = IIf(IsDBNull(dr("BankId")), "", dr("BankId"))
                txtTypeBank.Text = IIf(IsDBNull(dr("TypeBank")), "", dr("TypeBank"))
                txtSocTax.Text = IIf(IsDBNull(dr("SocTaxId")), "", dr("SocTaxId"))
                cboMateSpit.SelectedIndex = IIf(IIf(IsDBNull(dr("MateSpit")), 0, dr("MateSpit")), 1, 0)

                If IsDBNull(dr("Status")) = True Or dr("Status") = "" Then
                    txtStatus.SelectedIndex = -1
                Else
                    txtStatus.Text = dr("Status")
                End If

                txtMarryName.Text = IIf(IsDBNull(dr("MarryName")), "", dr("MarryName"))
                txtMarryWorkCom.Text = IIf(IsDBNull(dr("MarryWorkCom")), "", dr("MarryWorkCom"))

                If (IIf(IsDBNull(dr("WageType")), "M", dr("WageType"))) = "M" Then
                    OptMonth.Checked = True
                Else
                    OptDay.Checked = True
                End If

                If dr("Contractor") = True Then
                    chkContractor.Checked = 1
                Else
                    chkContractor.Checked = 0
                End If

                txtSalary.Text = Format(IIf(IsDBNull(dr("Salary")), 0, dr("Salary")), "#,#0")
                txtBonus.Text = Format(IIf(IsDBNull(dr("Bonus")), 0, dr("Bonus")), "#,#0")
                cboWeek.SelectedIndex = -1
                For ii = 0 To cboWeek.Items.Count - 1
                    If cboWeek.Items(ii) = dr("SalWeek") Then
                        cboWeek.SelectedIndex = ii
                        Exit For
                    End If
                Next

                ' PayType ประเภทการจ่ายเงิน 'B' : ยอดเข้า Bank , 'C' : Cash จ่ายเห็นเงินสด
                If dr("PayType") = "B" Then
                    optBank.Checked = True
                Else
                    optCash.Checked = True
                End If
                ' เพิ่มฟิวล์ใหม่ 31/05/2005
                txtA_ENT.Text = IIf(IsDBNull(dr("A_ENT")), 0, dr("A_ENT"))
                txtPremium.Text = Format(IIf(IsDBNull(dr("Premium")), 0, dr("Premium")), "#,#0.00")
                txtLoan.Text = Format(IIf(IsDBNull(dr("Loan")), 0, dr("Loan")), "#,#0.00")
                txtDonate.Text = Format(IIf(IsDBNull(dr("Donate")), 0, dr("Donate")), "#,#0.00")
                txtCapitalSumary.Text = Format(IIf(IsDBNull(dr("CapitalSumary")), 0, dr("CapitalSumary")), "#,#0.00")
                txtSonEdu.Text = IIf(IsDBNull(dr("SonEdu")), 0, dr("SonEdu"))
                txtSonNonEdu.Text = IIf(IsDBNull(dr("SonNonEdu")), 0, dr("SonNonEdu"))
                txtRace.Text = IIf(IsDBNull(dr("Race")), "", dr("Race"))
                txtNationalily.Text = IIf(IsDBNull(dr("Nationality")), "", dr("Nationality"))
                txtReligion.Text = IIf(IsDBNull(dr("Religion")), "", dr("Religion"))
                txtTelContract.Text = IIf(IsDBNull(dr("TelContract")), "", dr("TelContract"))
                txtforeignNo.Text = IIf(IsDBNull(dr("foreignNo")), "", dr("foreignNo"))
                cboPremiumMStart.Text = IIf(IsDBNull(dr("PremiumMStart")), 1, dr("PremiumMStart"))
                cboLoanMStart.Text = IIf(IsDBNull(dr("LoanMStart")), 1, dr("LoanMStart"))
                cboDonateMStart.Text = IIf(IsDBNull(dr("DonateMStart")), 1, dr("DonateMStart"))
                If IsDBNull(dr("foreignDate")) = True Then
                    txtforeignDate.Text = ""
                Else
                    txtforeignDate.Text = Format(dr("foreignDate"), "dd/MM/yyyy")
                End If

                txtDriveNo.Text = IIf(IsDBNull(dr("DriverNo")), "", dr("DriverNo"))

                If IsDBNull(dr("DriverDate")) = True Then
                    txtDriveDate.Text = ""
                Else
                    txtDriveDate.Text = Format(dr("DriverDate"), "dd/MM/yyyy")
                End If
                txtDrivePlace.Text = IIf(IsDBNull(dr("DriverPlace")), "", dr("DriverPlace"))
                If IsDBNull(dr("SoldierStatus")) = True Or (dr("SoldierStatus")) = "" Then
                    cboSoldierStatus.SelectedIndex = -1
                Else
                    cboSoldierStatus.Text = dr("SoldierStatus")
                End If
                If IsDBNull(dr("SoldierDate")) = True Then
                    txtSoldierDate.Text = ""
                Else
                    txtSoldierDate.Text = Format(dr("SoldierDate"), "dd/MM/yyyy")
                End If
                txtFatherName.Text = IIf(IsDBNull(dr("FatherName")), "", dr("FatherName"))
                txtMatherName.Text = IIf(IsDBNull(dr("MatherName")), "", dr("MatherName"))
                txtFatherNameMate.Text = IIf(IsDBNull(dr("FatherNameMate")), "", dr("FatherNameMate"))
                txtMatherNameMate.Text = IIf(IsDBNull(dr("MatherNameMate")), "", dr("MatherNameMate"))
                txtFatherIdCard.Text = IIf(IsDBNull(dr("FatherIdCard")), "", dr("FatherIdCard"))
                txtMatherIdCard.Text = IIf(IsDBNull(dr("MatherIdCard")), "", dr("MatherIdCard"))
                txtFatherIdCardMate.Text = IIf(IsDBNull(dr("FatherIdCardMate")), "", dr("FatherIdCardMate"))
                txtMatherIdCardMate.Text = IIf(IsDBNull(dr("MatherIdCardMate")), "", dr("MatherIdCardMate"))


                If dr("FatherCalTax") = True Then
                    chkFatherCalTax.Checked = 1
                Else
                    chkFatherCalTax.Checked = 0
                End If
                If dr("MatherCalTax") = True Then
                    chkMatherCalTax.Checked = 1
                Else
                    chkMatherCalTax.Checked = 0
                End If

                If dr("FatherCalTaxMate") = True Then
                    chkFatherCalTaxMate.Checked = 1
                Else
                    chkFatherCalTaxMate.Checked = 0
                End If
                If dr("MatherCalTaxMate") = True Then
                    chkMatherCalTaxMate.Checked = 1
                Else
                    chkMatherCalTaxMate.Checked = 0
                End If


                txtGuaranteeName.Text = IIf(IsDBNull(dr("GuaranteeName")), "", dr("GuaranteeName"))
                txtGuanWork.Text = IIf(IsDBNull(dr("GuaranWork")), "", dr("GuaranWork"))
                txtErContract.Text = IIf(IsDBNull(dr("ErContract")), "", dr("ErContract"))
                txtEr_Tel.Text = IIf(IsDBNull(dr("Er_Tel")), "", dr("Er_Tel"))
                txtEduSpacial.Text = IIf(IsDBNull(dr("EduSpacial")), "", dr("EduSpacial"))
                txtRemark.Text = IIf(IsDBNull(dr("Remark")), "", dr("Remark"))
                lblWorkStatus.Text = IIf(IsDBNull(dr("workstatus")), "W", dr("workstatus"))
                lblWorkStatus.Tag = IIf(IsDBNull(dr("workstatus")), "W", dr("workstatus"))
                ''    lblStatus.Caption = "E"

                cboBroker.Text = gData.GetBrokerName(dr("BrokerId"))
                If (lblWorkStatus.Text) = "T" Then
                    Me.Text = MsgManager.ShowLabel(Me, "Labels", "DatabaseEmpOut") ' "ฐานข้อมูลพนักงานลาออก"
                    txtTermiDate.Text = Format(dr("TermiDate"), "dd/MM/yyyy")
                    '     txtTermiDate_LostFocus()
                    txtTermiDate.Visible = True
                    lblTermiDate.Visible = True
                    ' cmdMoveToTerminate.Visible = False
                Else
                    Me.Text = MsgManager.ShowLabel(Me, "Labels", "DatabaseEmp") ' "ฐานข้อมูลพนักงาน"
                    txtTermiDate.Text = ""
                    txtTermiDate.Visible = False
                    lblTermiDate.Visible = False
                    '  cmdMoveToTerminate.Visible = True
                End If
                If dr("Pro_Fund") = True Then
                    chkPro_Fund.Checked = 1
                Else
                    chkPro_Fund.Checked = 0
                End If

                If dr("CalSocTax") = True Then
                    chkCalSocTax.Checked = 1
                Else
                    chkCalSocTax.Checked = 0
                End If

                If dr("CalLate") = True Then
                    chkCalLate.Checked = 1
                Else
                    chkCalLate.Checked = 0
                End If

                If dr("CalOtDeduc") = True Then
                    chkCalOtDeduc.Checked = 1
                Else
                    chkCalOtDeduc.Checked = 0
                End If

            Next

        End With


        cboYear.Text = Format(Now, "yyyy")
        cboPrivilegeYear.Text = Format(Now, "yyyy")
        Call cboYear_Click(e, System.EventArgs.Empty)
        Call LoadYearTax()
        Call cboPrivilegeYear_Click(e, System.EventArgs.Empty)
        Call LoadDetailSon(txtCode_D.Text.Trim) ' แสดงข้อมูลบุตร ใน Tab บุตรและคำนวณภาษี
        Call LoadTraining(txtCode_D.Text.Trim)


        ' load Visa --------------------------
        Call LoadVisa(txtCode_D.Text.Trim)

        ' Load Passport ---------------------------
        Call LoadPassport(txtCode_D.Text.Trim)
        Call EnaCmd(False, True, True)
    End Sub

    Private Sub txtCode_D_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode_D.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call LoadData_Detail(e, System.EventArgs.Empty)
        End If
    End Sub



    Private Sub txtCode_D_LostFocus(sender As Object, e As System.EventArgs) Handles txtCode_D.LostFocus
        Call LoadData_Detail(e, System.EventArgs.Empty)
    End Sub

    Private Sub LoadYearTax()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim dcmd As New SqlCommand
        Dim db As New db
        Dim Strsql As String = ""

        Strsql = "Exec spPayrollYear '" & Trim(txtCode.Text) & "'"

        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dCmd, Strsql)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)
        With Ds.Tables("data")
            If .Rows.Count Then
                cboYear.Items.Clear()
                Exit Sub
            End If
            cboYear.Items.Clear()
            For Each dr As DataRow In .Rows
                cboYear.Items.Add(dr("Year"))
            Next
        End With
    End Sub

    Private Sub LoadDetailSon(code As String)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim dcmd As New SqlCommand
        Dim db As New db
        Dim Strsql As String = ""

        txtSonName1.Text = ""
        txtSonName2.Text = ""
        txtSonName3.Text = ""
        txtSonName4.Text = ""
        txtSonName5.Text = ""

        txtSonAge1.Text = ""
        txtSonAge2.Text = ""
        txtSonAge3.Text = ""
        txtSonAge4.Text = ""
        txtSonAge5.Text = ""

        Strsql = "Select * from Son where code='" & code.Trim & "'  "

        Try

            Call dbMgr.OpenDatabase(Conn, True)
            db.ExecuteCommand(Conn, dcmd, Strsql)
            Da.SelectCommand = dcmd
            Da.Fill(Ds, "data")
            Call dbMgr.OpenDatabase(Conn, False)
            With Ds.Tables("data")
                If .Rows.Count = 0 Then
                    Exit Sub
                End If

                For Each dr As DataRow In .Rows

                    If txtSonName1.Text = "" Then
                        txtSonName1.Text = dr("Sonname")
                        txtSonAge1.Text = Format(dr("Age"), "#,##")
                        GoTo Son
                    End If

                    If txtSonName2.Text = "" Then
                        txtSonName2.Text = dr("Sonname")
                        txtSonAge2.Text = Format(dr("Age"), "#,##")
                        GoTo Son
                    End If

                    If txtSonName3.Text = "" Then
                        txtSonName3.Text = dr("Sonname")
                        txtSonAge3.Text = Format(dr("Age"), "#,##")
                        GoTo Son
                    End If

                    If txtSonName4.Text = "" Then
                        txtSonName4.Text = dr("Sonname")
                        txtSonAge4.Text = Format(dr("Age"), "#,##")
                        GoTo Son
                    End If

                    If txtSonName5.Text = "" Then
                        txtSonName5.Text = dr("Sonname")
                        txtSonAge5.Text = Format(dr("Age"), "#,##")
                        GoTo Son
                    End If

son:
                Next
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboPrivilegeYear_Click(sender As Object, e As System.EventArgs) Handles cboPrivilegeYear.Click
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strsql As String = ""
        Dim db As New db
        Dim dcmd As New SqlCommand
        Dim arrdata() As String
        Dim List As ListViewItem

        strsql = "select Description = Isnull(WS.Description,'')," & _
                                        " Amt = Isnull(Amt,0)," & _
                                        " AmtUse = isnull((select Sum(Amt)/8 " & _
                                                    " from TimeVacation " & _
                                                    " where year(ValDate) = '" & Trim(cboPrivilegeYear.Text) & "' and " & _
                                                                    " Code = Val.Code and ValId = Val.ValCode),0)" & _
                        " from TimePrivilege_Val Val inner Join timeworkingstatus WS " & _
                                    " on Val.ValCode = WS.Code " & _
                        " Where Val.[Year] = '" & Trim(cboPrivilegeYear.Text) & "' and " & _
                                            " Val.Code = '" & Trim(txtCode_D.Text) & "'"

        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dcmd, strsql)
        da.SelectCommand = dcmd
        da.Fill(ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)


        With ds.Tables("data")
            If .Rows.Count = 0 Then
                lstPrivilege.Items.Clear()
            Else
                lstPrivilege.BeginUpdate()
                lstPrivilege.Items.Clear()
                Dim I As Integer = 0
                For Each drw As DataRow In .Rows
                    I += 1
                    arrdata = New String() {I, _
                                            drw("Description"), _
                                            Format(IIf(IsDBNull(drw("Amt")), 0, drw("Amt")), "#,##0.0"), _
                                            Format(IIf(IsDBNull(drw("Amt")), 0, drw("AmtUse")), "#,##0.0"), _
                                            Format(IIf(IsDBNull(drw("Amt")), 0, drw("Amt") - drw("AmtUse")), "#,##0.0")}
                    List = New ListViewItem(arrdata)
                    lstPrivilege.Items.Add(List)
                Next
                lstPrivilege.EndUpdate()
            End If
        End With
    End Sub

    Private Sub cboPrivilegeYear_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboPrivilegeYear.SelectedIndexChanged
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strsql As String = ""
        Dim db As New db
        Dim dcmd As New SqlCommand
        Dim arrdata() As String
        Dim List As ListViewItem

        strsql = "select Description = Isnull(WS.Description,'')," & _
                                        " Amt = Isnull(Amt,0)," & _
                                        " AmtUse = isnull((select Sum(Amt)/8 " & _
                                                    " from TimeVacation " & _
                                                    " where year(ValDate) = '" & Trim(cboPrivilegeYear.Text) & "' and " & _
                                                                    " Code = Val.Code and ValId = Val.ValCode),0)" & _
                        " from TimePrivilege_Val Val inner Join timeworkingstatus WS " & _
                                    " on Val.ValCode = WS.Code " & _
                        " Where Val.[Year] = '" & Trim(cboPrivilegeYear.Text) & "' and " & _
                                            " Val.Code = '" & Trim(txtCode_D.Text) & "'"

        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dcmd, strsql)
        da.SelectCommand = dcmd
        da.Fill(ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)


        With ds.Tables("data")
            If .Rows.Count = 0 Then
                lstPrivilege.Items.Clear()
            Else
                lstPrivilege.BeginUpdate()
                lstPrivilege.Items.Clear()
                Dim I As Integer = 0
                For Each drw As DataRow In .Rows
                    I += 1
                    arrdata = New String() {I, _
                                            drw("Description"), _
                                            Format(IIf(IsDBNull(drw("Amt")), 0, drw("Amt")), "#,##0.0"), _
                                            Format(IIf(IsDBNull(drw("Amt")), 0, drw("AmtUse")), "#,##0.0"), _
                                            Format(IIf(IsDBNull(drw("Amt")), 0, drw("Amt") - drw("AmtUse")), "#,##0.0")}
                    List = New ListViewItem(arrdata)
                    lstPrivilege.Items.Add(List)
                Next
                lstPrivilege.EndUpdate()
            End If



        End With
    End Sub

    Public Sub txtDivID_LostFocus(sender As Object, e As System.EventArgs) Handles txtDivID.LostFocus
        If (txtDivID.Text.Trim) = "" Then Exit Sub
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strsql As String = ""
        Dim db As New db
        Dim dcmd As New SqlCommand

        strsql = "Select * from Division where DivId = '" & Trim(txtDivID.Text) & "'"
        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dcmd, strsql)
        da.SelectCommand = dcmd
        da.Fill(ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)


        With ds.Tables("data")
            If .Rows.Count = 0 Then
                ' MsgBox("ไม่มีรหัสฝ่ายนี้กรุณากรอกใหม่", vbInformation, Me.Text)
                MsgManager.ShowDialog(Me, "Messages", Me.Text, "DeptIdNull", MessageBoxIcon.Information)
                txtDivID.Focus()
                txtDivision.Text = ""
                Exit Sub
            End If
            txtDivision.Text = .Rows(0).Item("Division")
        End With
    End Sub

    Public Sub txtSecId_Det_LostFocus(sender As Object, e As System.EventArgs) Handles txtSecId_Det.LostFocus
        If Trim(txtSecId_Det.Text) = "" Then Exit Sub
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strsql As String = ""
        Dim db As New db
        Dim dcmd As New SqlCommand

        strsql = "Select * from Section where SecId = '" & Trim(txtSecId_Det.Text) & "'"
        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dcmd, strsql)
        da.SelectCommand = dcmd
        da.Fill(ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)

        With ds.Tables("data")
            If .Rows.Count = 0 Then
                '(MsgBox("ไม่มีรหัสส่วนนี้กรุณากรอกใหม่", vbInformation, Me.Text))
                MsgManager.ShowDialog(Me, "Messages", Me.Text, "DeptIdNull", MessageBoxIcon.Information)
                txtSecId_Det.Focus()
                txtSection_Det.Text = ""
                Exit Sub
            End If
            txtSection_Det.Text = .Rows(0).Item("Section")
        End With
    End Sub

    Public Sub txtDeptId_LostFocus(sender As Object, e As System.EventArgs) Handles txtDeptId.LostFocus
        If Trim(txtDeptId.Text) = "" Then Exit Sub
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strsql As String = ""
        Dim db As New db
        Dim dcmd As New SqlCommand

        strsql = "Select * from Department where DeptId = '" & Trim(txtDeptId.Text) & "'"
        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dcmd, strsql)
        da.SelectCommand = dcmd
        da.Fill(ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)

        With ds.Tables("data")
            If .Rows.Count = 0 Then
                '  MsgBox("ไม่มีรหัสแผนกกรุณากรอกใหม่", vbInformation, Me.Text)
                MsgManager.ShowDialog(Me, "Messages", Me.Text, "DeptIdNull", MessageBoxIcon.Information)
                txtDeptId.Focus()
                txtDepartment.Text = ""
                Exit Sub
            End If
            txtDepartment.Text = .Rows(0).Item("Department")
        End With
    End Sub


    Private Sub txtDateIn_LostFocus(sender As Object, e As System.EventArgs) Handles txtDateIn.LostFocus
        '    txtDateIn.Text = Format(txtDateIn.Text.Trim, "")
        If lblWorkStatus.Text = "W" Then
            If IsDate(ConvertDate(txtDateIn.Text)) = False Then
                txtWorkAge.Text = ""
            Else
                'txtWorkAge.Text = frmEmp.CalAge(ConvertDate(txtDateIn.Text), Date)
                txtWorkAge.Text = CalAge(ConvertDate(txtDateIn.Text.Trim), Now)

                '  txtWorkAge.Text = CalAge("1982/11/14", Now)
            End If
        Else
            If IsDate(ConvertDate(txtDateIn.Text)) = False Or IsDate(ConvertDate(txtTermiDate.Text)) = False Then
                txtWorkAge.Text = ""
            Else
                txtWorkAge.Text = CalAge(ConvertDate(txtDateIn.Text), ConvertDate(txtTermiDate.Text))
            End If
        End If
    End Sub

    Private Sub txtBirth_LostFocus(sender As Object, e As System.EventArgs) Handles txtBirth.LostFocus, txtDateExpire.LostFocus
        If IsDate(ConvertDate(txtBirth.Text)) = False Then
            txtAge.Text = ""
        Else
            '  txtAge.Text = DateDiff("d", CDate(ConvertDate(txtBirth.Text)), Format(Now, "dd/MM/yyyy")) \ 365
            txtAge.Text = DateDiff("d", CDate(ConvertDate(txtBirth.Text)), Now) \ 365
        End If
    End Sub

    Private Sub cmdNext_Click(sender As System.Object, e As System.EventArgs) Handles cmdNext.Click
        If txtCode_D.Text = "" Then Exit Sub


        If IsNumeric(lblCurRecord.Text) = True Then
            Dim CurRec As Integer
            CurRec = CInt(lblCurRecord.Text)

            CurRec = CurRec + 1
            lblCurRecord.Text = CurRec
            If CurRec >= 0 And CurRec <= LstData.Items.Count - 1 Then
                txtCode_D.Text = LstData.Items(CurRec).SubItems(1).Text.Trim
                Call txtCode_D_LostFocus(e, System.EventArgs.Empty)
            Else
                If CurRec > LstData.Items.Count - 1 Then
                    lblCurRecord.Text = LstData.Items.Count - 1
                End If
                If CurRec < 0 Then
                    lblCurRecord.Text = 0
                End If
            End If
        End If

    End Sub

    Private Sub cmdPrevious_Click(sender As System.Object, e As System.EventArgs) Handles cmdPrevious.Click
        If txtCode_D.Text = "" Then Exit Sub

        If IsNumeric(lblCurRecord.Text) = True Then
            Dim CurRec As Integer
            CurRec = CInt(lblCurRecord.Text)

            CurRec = CurRec - 1
            lblCurRecord.Text = CurRec
            If CurRec >= 0 And CurRec <= LstData.Items.Count Then
                txtCode_D.Text = LstData.Items(CurRec).SubItems(1).Text.Trim
                Call txtCode_D_LostFocus(e, System.EventArgs.Empty)
            Else
                If CurRec > LstData.Items.Count Then
                    lblCurRecord.Text = LstData.Items.Count
                End If
                If CurRec < 0 Then
                    lblCurRecord.Text = 0
                End If
            End If
        End If

    End Sub

    Function GetWeek_Code(WK_Name As String) As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db

        Strsql = "Select WK_Code " & _
                        " From SAL_Week " & _
                        " Where WK_Name = " & WK_Name.Trim & " "

        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dcmd, Strsql)
        Da.SelectCommand = dcmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("WK_Code")
            End If
        End With
    End Function

    Private Sub cboYear_Click(sender As Object, e As System.EventArgs) Handles cboYear.Click
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim sqlstm As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db



        Call LoadProFundAcc(cboYear.Text, Trim(txtCode_D.Text))
        lblAccBonus.Text = Format(SumBonus, "#,##0.00")

        '   Dim rsAcc As New ADODB.Recordset
        Strsql = "Exec spTaxAcc '" & cboYear.Text.Trim & "','" & txtCode_D.Text.Trim & "'"

        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dcmd, Strsql)
        Da.SelectCommand = dcmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                lblAccGrossTax.Text = 0
                lblAccTax.Text = 0
                lblAccGrossSoc.Text = 0
                lblAccSocTax.Text = 0
                Exit Sub
            End If
            For Each dr As DataRow In .Rows
                lblAccGrossTax.Text = Format(IIf(IsDBNull(dr("GrossTax")), 0, dr("GrossTax")), "#,##0.00")
                lblAccTax.Text = Format(IIf(IsDBNull(dr("Tax")), 0, dr("Tax")), "#,##0.00")
                lblAccGrossSoc.Text = Format(IIf(IsDBNull(dr("GrossSoc")), 0, dr("GrossSoc")), "#,##0.00")
                lblAccSocTax.Text = Format(IIf(IsDBNull(dr("SocTax")), 0, dr("SocTax")), "#,##0.00")
            Next


        End With

        Call Tax_Detail()
        Call LoadTaxAdd()
    End Sub

    Private Sub Tax_Detail()
        ' Load Detail===============================================================================
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim sqlstm As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db

        Dim arrData() As String
        Dim List As ListViewItem

        sqlstm = "Exec spTaxPerMonth '" & cboYear.Text.Trim & "','" & txtCode_D.Text.Trim & "'"

        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dcmd, sqlstm)
        Da.SelectCommand = dcmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                lstMonthly.Items.Clear()
                Exit Sub
            End If

            lstMonthly.BeginUpdate()
            lstMonthly.Items.Clear()
            Dim I As Integer = 0
            For Each drw As DataRow In .Rows
                I += 1
                arrData = New String() {I, _
                                        drw("Month_Year"), _
                                        Format(IIf(IsDBNull(drw("GrossTax")), 0, drw("GrossTax")), "#,##0.00"), _
                                        Format(IIf(IsDBNull(drw("Tax")), 0, drw("Tax")), "#,##0.00"), _
                                        Format(IIf(IsDBNull(drw("GrossSoc")), 0, drw("GrossSoc")), "#,##0.00"), _
                                        Format(IIf(IsDBNull(drw("SocTax")), 0, drw("SocTax")), "#,##0.00")}
                List = New ListViewItem(arrData)
                lstMonthly.Items.Add(List)
            Next
            lstMonthly.EndUpdate()
        End With
    End Sub

    Private Sub LoadTaxAdd()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db

        Dim arrData() As String
        Dim List As ListViewItem

        Strsql = "Select * " & _
                    " From TaxAdd " & _
                    " Where Right(Month_Year,4) = '" & cboYear.Text.Trim & "' and" & _
                                " Code = '" & txtCode_D.Text.Trim & "'" & _
                    " Order By Right(Month_year,4),Left(Month_Year,2)"

        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dcmd, Strsql)
        Da.SelectCommand = dcmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                lstAdd.Items.Clear()
                Exit Sub
            End If

            lstAdd.BeginUpdate()
            lstAdd.Items.Clear()
            Dim I As Integer = 0
            For Each drw As DataRow In .Rows
                I += 1
                arrData = New String() {I, _
                                        drw("Month_Year"), _
                                        Format(IIf(IsDBNull(drw("GrossTax")), 0, drw("GrossTax")), "#,##0.00"), _
                                        Format(IIf(IsDBNull(drw("Tax")), 0, drw("Tax")), "#,##0.00"), _
                                        Format(IIf(IsDBNull(drw("GrossSoc")), 0, drw("GrossSoc")), "#,##0.00"), _
                                        Format(IIf(IsDBNull(drw("SocTax")), 0, drw("SocTax")), "#,##0.00"), _
                                        IIf(IsDBNull(drw("Remark")), "", drw("Remark"))}
                List = New ListViewItem(arrData)
                lstAdd.Items.Add(List)
            Next
            lstAdd.EndUpdate()

        End With
    End Sub


    Function SumBonus() As Double
        Dim Year_ As String = ""
        Dim MY_ As String = ""
        Dim Code_ As String = ""

        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db


        Code_ = txtCode_D.Text.Trim
        Year_ = cboYear.Text.Trim

        strsql = "select Isnull(Sum(Bonus),0) as GrossTax " & _
                    " From Bonus " & _
                    " Where Right(Month_Year,4) = '" & Trim(Year_) & "' and Code = '" & Trim(Code_) & "' "

        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dcmd, StrSql)
        Da.SelectCommand = dcmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)

        Try
            With Ds.Tables("data")
                If .Rows.Count = 0 Then
                    Return 0
                Else
                    Return .Rows(0).Item("GrossTax")
                End If
            End With

        Catch ex As Exception
            Return 0
        End Try


        '   rsAccu.Close()
    End Function

    Private Sub LoadProFundAcc(Year_ As String, Code As String)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db

        Strsql = "select Isnull(sum([P/F]),0) as PF ," & _
                            " PF_All = (Select Isnull(Sum([P/F]),0) From Payroll Where Code = '" & Trim(Code) & "') " & _
                    " From payroll where Right(Month_Year,4) = '" & Trim(cboYear.Text) & "' and Code = '" & Trim(Code) & "'"

        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dcmd, Strsql)
        Da.SelectCommand = dcmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                lblAccuPF.Text = "0.00"
                lblAccuPFAll.Text = "0.00"
                Exit Sub
            End If
            lblAccuPF.Text = Format(.Rows(0).Item("PF"), "#,##0.00")
            lblAccuPFAll.Text = Format(.Rows(0).Item("PF_ALL"), "#,##0.00")
        End With
    End Sub

    Private Sub LoadVisa(Code As String)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db
        Dim arrdata() As String
        Dim List As ListViewItem

        Strsql = "Select Id,Issueddate,ExperiedDate,type_noneb,type_multiple " & _
                " from visa " & _
                " where empid = '" & Code.Trim & "'"

        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dcmd, Strsql)
        Da.SelectCommand = dcmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                lstVisa.Items.Clear()
                Exit Sub
            End If

            lstVisa.BeginUpdate()
            lstVisa.Items.Clear()
            Dim I As Integer = 0
            Dim issueddate_ As DateTime
            Dim Experieddate_ As DateTime

            For Each drw As DataRow In .Rows
                I += 1
                issueddate_ = drw("Issueddate")
                Experieddate_ = drw("Experieddate")

                arrdata = New String() {I, _
                        drw("Id"), _
                        Format(issueddate_, "dd/MM/yyyy"), _
                        Format(Experieddate_, "dd/MM/yyyy"), _
                        IIf(drw("type_noneb"), "/", ""), _
                        IIf(drw("type_multiple"), "/", "")}
                List = New ListViewItem(arrdata)
                lstVisa.Items.Add(List)
            Next
            lstVisa.EndUpdate()
        End With
    End Sub

    'Private Sub LoadPassport(code As String)
    '    Dim Da As New SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim Strsql As String = ""
    '    Dim dcmd As New SqlCommand
    '    Dim db As New db
    '    Dim arrdata() As String
    '    Dim List As ListViewItem

    '    Strsql = "Select PassportNo,Issueddate,ExperiedDate,type_noneb,type_multiple " & _
    '            " from Passport " & _
    '            " where empid = '" & code.Trim & "'"
    '    Call dbMgr.OpenDatabase(Conn, True)
    '    db.ExecuteCommand(Conn, dcmd, Strsql)
    '    Da.SelectCommand = dcmd
    '    Da.Fill(Ds, "data")
    '    Call dbMgr.OpenDatabase(Conn, False)

    '    With Ds.Tables("data")
    '        If .Rows.Count = 0 Then
    '            lstPassport.Items.Clear()
    '            Exit Sub
    '        End If

    '        lstPassport.BeginUpdate()
    '        lstPassport.Items.Clear()
    '        Dim I As Integer = 0
    '        For Each drw As DataRow In .Rows
    '            I += 1
    '            arrdata = New String() {I, _
    '                                    drw("PassportNo"), _
    '                                    Format(drw("Issueddate"), "dd/MM/yyyy"), _
    '                                    Format(drw("Experieddate"), "dd/MM/yyyy"), _
    '                                    IIf(drw("type_noneb"), "/", ""), _
    '                                    IIf(drw("type_multiple"), "/", "")}
    '            List = New ListViewItem(arrdata)
    '            lstPassport.Items.Add(List)
    '        Next
    '        lstPassport.EndUpdate()
    '    End With

    'End Sub

    Private Sub cmdAddTax_Click(sender As System.Object, e As System.EventArgs) Handles cmdAddTax.Click

        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db

        Dim strType As String
        Dim Data As New ArrayList


        'Dim arrdata() As String
        'Dim List As ListViewItem

        'If IsDate(ConvertDate("01/" & txtMonth_Year.Text)) = False Then
        '    MsgBox("¡ÃØ³Ò»éÍ¹à´×Í¹ãËé¶Ù¡µéÍ§´éÇÂ", vbInformation, Me.Caption)
        '    txtMonth_Year.SetFocus()
        '    Exit Sub
        'End If
        'If Trim(txtGrossTax.Text) = "" Then txtGrossTax.Text = 0
        'If IsNumeric(txtGrossTax.Text) = False Then
        '    MsgBox("¡ÃØ³Ò»éÍ¹µÑÇàÅ¢ãËé¶Ù¡µéÍ§´éÇÂ", vbInformation, Me.Caption)
        '    txtGrossTax.SetFocus()
        '    Exit Sub
        'End If
        'If Trim(txtTax.Text) = "" Then txtTax.Text = 0
        'If IsNumeric(txtTax.Text) = False Then
        '    MsgBox("¡ÃØ³Ò»éÍ¹µÑÇàÅ¢ãËé¶Ù¡µéÍ§´éÇÂ", vbInformation, Me.Caption)
        '    txtTax.SetFocus()
        '    Exit Sub
        'End If
        'If Trim(txtGrossSoc.Text) = "" Then txtGrossSoc.Text = 0
        'If IsNumeric(txtGrossSoc.Text) = False Then
        '    MsgBox("¡ÃØ³Ò»éÍ¹µÑÇàÅ¢ãËé¶Ù¡µéÍ§´éÇÂ", vbInformation, Me.Caption)
        '    txtGrossSoc.SetFocus()
        '    Exit Sub
        'End If
        'If Trim(txteSocTax.Text) = "" Then txteSocTax.Text = 0
        'If IsNumeric(txteSocTax.Text) = False Then
        '    MsgBox("¡ÃØ³Ò»éÍ¹µÑÇàÅ¢ãËé¶Ù¡µéÍ§´éÇÂ", vbInformation, Me.Caption)
        '    txteSocTax.SetFocus()
        '    Exit Sub
        'End If
        'If Val(txtGrossTax.Text) = 0 And Val(txtTax.Text) = 0 And Val(txtGrossSoc.Text) = 0 And Val(txteSocTax.Text) = 0 Then
        '    MsgBox("¡ÃØ³Ò»éÍ¹¢éÍÁÙÅ´éÇÂ", vbInformation, Me.Caption)
        '    txtGrossTax.SetFocus()
        '    Exit Sub
        'End If

        Try
            Data.Clear() : strType = ""
            Data.Add(txtMonth_Year.Text.Trim) : strType &= "T"
            Data.Add(txtCode_D.Text.Trim) : strType &= "T"


            Strsql = "Delete From TaxAdd Where Month_Year = @P1 and Code = @P2"

            Call dbMgr.OpenDatabase(Conn, True)
            db.ExecuteCommand(Conn, dcmd, Strsql, strType, Data)
            Call dbMgr.OpenDatabase(Conn, False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        Try
            Data.Clear() : strType = ""
            Data.Add(txtMonth_Year.Text.Trim) : strType &= "T"
            Data.Add(txtCode_D.Text.Trim) : strType &= "T"
            Data.Add(txtGrossTax.Text.Trim) : strType &= "T"
            Data.Add(txtTax.Text.Trim) : strType &= "T"
            Data.Add(txtGrossSoc.Text.Trim) : strType &= "T"
            Data.Add(txteSocTax.Text.Trim) : strType &= "T"
            Data.Add(txtRemark.Text.Trim) : strType &= "T"

            Strsql = "Insert Into TaxAdd(Month_Year,Code,GrossTax,Tax,GrossSoc,SocTax,Remark) Values " & _
                                            "(@P1,@P2,@P3,@P4,@P5,@P6,@P7)"

            Call dbMgr.OpenDatabase(Conn, True)
            db.ExecuteCommand(Conn, dcmd, Strsql, strType, Data)
            Call dbMgr.OpenDatabase(Conn, False)

            Call cboYear_Click(e, System.EventArgs.Empty)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call ClearTxt_DetailTax()

    End Sub

    Private Sub ClearTxt_DetailTax()
        txtMonth_Year.Text = ""
        txtGrossTax.Text = ""
        txtTax.Text = ""
        txtGrossSoc.Text = ""
        txteSocTax.Text = ""
        txteRemark.Text = ""
    End Sub

    Private Sub cmdDelTax_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelTax.Click
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db
        Dim data As New ArrayList
        Dim strtype As String = ""

        For I = 0 To lstAdd.Items.Count - 1
            If lstAdd.Items(I).Checked = True Then


                Data.Clear() : strType = ""
                data.Add(lstAdd.Items(I).SubItems(1).Text) : strtype &= "T"
                Data.Add(txtCode_D.Text.Trim) : strType &= "T"

                Strsql = "Delete from TaxAdd Where Month_Year = @P1 and Code = @P2"

                Call dbMgr.OpenDatabase(Conn, True)
                db.ExecuteCommand(Conn, dcmd, Strsql, strType, Data)
                Call dbMgr.OpenDatabase(Conn, False)

            End If
        Next
        Call cboYear_Click(e, System.EventArgs.Empty)
    End Sub

    Private Sub cmdVisa_Add_Click(sender As System.Object, e As System.EventArgs) Handles cmdVisa_Add.Click
        If txtCode_D.Text = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Select_Emp_Code", MessageBoxIcon.Information)
            Exit Sub
        End If

        If IsDate(ConvertDate(txtVisa_IssuedDate.Text)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "InputDate_Ture", MessageBoxIcon.Information)
            txtVisa_IssuedDate.Focus()
            Exit Sub
        End If
        If IsDate(ConvertDate(txtVisa_ExperiedDate.Text)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "InputDate_Ture", MessageBoxIcon.Information)
            txtVisa_ExperiedDate.Focus()
            Exit Sub
        End If

        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db

        Dim strType As String
        Dim Data As New ArrayList

        Try
            Data.Clear() : strType = ""
            Data.Add(txtCode_D.Text.Trim) : strType &= "T"
            Data.Add(ConvertDate(txtVisa_IssuedDate.Text)) : strType &= "T"
            Data.Add(ConvertDate(txtVisa_ExperiedDate.Text)) : strType &= "T"
            Data.Add(IIf(optVisa_NoneB.Checked = True, 1, 0)) : strType &= "T"
            Data.Add(IIf(optVisa_Multiple.Checked = True, 1, 0)) : strType &= "T"


            Strsql = "Insert Into Visa(EmpId,IssuedDate,ExperiedDate,Type_NoneB,Type_Multiple) Values " & _
                                            "(@P1,@P2,@P3,@P4,@P5)"

            Call dbMgr.OpenDatabase(Conn, True)
            db.ExecuteCommand(Conn, dcmd, Strsql, strType, Data)
            Call dbMgr.OpenDatabase(Conn, False)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Call cmdVisa_Refresh_Click(e, System.EventArgs.Empty)
    End Sub

    Private Sub cmdVisa_Refresh_Click(sender As System.Object, e As System.EventArgs) Handles cmdVisa_Refresh.Click
        txtVisa_IssuedDate.Text = "__/__/____"
        txtVisa_ExperiedDate.Text = "__/__/____"
        optVisa_NoneB.Checked = True
        Call LoadVisa(txtCode_D.Text)


        Call EndBtnVisa(True, False, False)
    End Sub


    Private Sub EndBtnVisa(Add As Boolean, Edit As Boolean, Delete As Boolean)
        cmdVisa_Add.Enabled = Add
        cmdVisa_Edit.Enabled = Edit
        cmdVisa_Delete.Enabled = Delete
    End Sub

    Private Sub cmdVisa_Edit_Click(sender As System.Object, e As System.EventArgs) Handles cmdVisa_Edit.Click

        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db

        Dim strType As String
        Dim Data As New ArrayList

        If txtCode_D.Text = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Select_Emp_Code", MessageBoxIcon.Information)
            Exit Sub
        End If

        If IsDate(ConvertDate(txtVisa_IssuedDate.Text)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "InputDate_Ture", MessageBoxIcon.Information)
            txtVisa_IssuedDate.Focus()
            Exit Sub
        End If
        If IsDate(ConvertDate(txtVisa_ExperiedDate.Text)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "InputDate_Ture", MessageBoxIcon.Information)
            txtVisa_ExperiedDate.Focus()
            Exit Sub
        End If
        Try
            Data.Clear() : strType = ""
            Data.Add(lblVisa_Id.Text.Trim) : strType &= "T"
            Data.Add(txtCode_D.Text.Trim) : strType &= "T"
            Data.Add(ConvertDate(txtVisa_IssuedDate.Text)) : strType &= "T"
            Data.Add(ConvertDate(txtVisa_ExperiedDate.Text)) : strType &= "T"
            '    Data.Add(IIf(optVisa_NoneB.Checked = 1, 1, 0)) : strType &= "T"

            If optVisa_NoneB.Checked = True Then
                Data.Add(1) : strType &= "T"
            Else
                Data.Add(0) : strType &= "T"
            End If

            If optVisa_Multiple.Checked = True Then
                Data.Add(1) : strType &= "T"
            Else
                Data.Add(0) : strType &= "T"
            End If


            '  Data.Add(IIf(optVisa_Multiple.Checked = 1, 1, 0)) : strType &= "T"

            Strsql = "Update Visa Set IssuedDate = @P3, " & _
                                        " ExperiedDate = @P4," & _
                                        " Type_NoneB = @P5, " & _
                                        " Type_Multiple =@P6 " & _
                            " where id = @P1 "

            Call dbMgr.OpenDatabase(Conn, True)
            db.ExecuteCommand(Conn, dcmd, Strsql, strType, Data)
            Call dbMgr.OpenDatabase(Conn, False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call cmdVisa_Refresh_Click(e, System.EventArgs.Empty)

    End Sub

    Private Sub cmdVisa_Delete_Click(sender As System.Object, e As System.EventArgs) Handles cmdVisa_Delete.Click
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db

        Dim strType As String
        Dim Data As New ArrayList


        If txtCode_D.Text = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Select_Emp_Code", MessageBoxIcon.Information)
            Exit Sub
        End If


        Data.Clear() : strType = ""
        Data.Add(lblVisa_Id.Text.Trim) : strType &= "T"

        Strsql = "Delete Visa " & _
                        " where id = @P1"
        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dcmd, Strsql, strType, Data)
        Call dbMgr.OpenDatabase(Conn, False)

        Call cmdVisa_Refresh_Click(e, System.EventArgs.Empty)
    End Sub

    Private Sub lstVisa_DoubleClick(sender As Object, e As System.EventArgs) Handles lstVisa.DoubleClick
        If lstVisa.SelectedItems.Count = 0 Then Exit Sub
        lblVisa_Id.Text = lstVisa.SelectedItems(0).SubItems(1).Text.Trim
        txtVisa_IssuedDate.Text = lstVisa.SelectedItems(0).SubItems(2).Text.Trim
        txtVisa_ExperiedDate.Text = lstVisa.SelectedItems(0).SubItems(3).Text.Trim
        optVisa_NoneB.Checked = IIf(lstVisa.SelectedItems(0).SubItems(4).Text = "/", True, False)
        optVisa_Multiple.Checked = IIf(lstVisa.SelectedItems(0).SubItems(5).Text = "/", True, False)

        Call EndBtnVisa(False, True, True)
    End Sub

    Private Sub lstVisa_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstVisa.SelectedIndexChanged

    End Sub

    Private Sub cmdPP_Add_Click(sender As System.Object, e As System.EventArgs) Handles cmdPP_Add.Click
        If txtCode_D.Text = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Select_Emp_Code", MessageBoxIcon.Information)
            Exit Sub
        End If

        If IsDate(ConvertDate(txtpp_Issueddate.Text)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "InputDate_Ture", MessageBoxIcon.Information)
            txtVisa_IssuedDate.Focus()
            Exit Sub
        End If
        If IsDate(ConvertDate(txtpp_Experieddate.Text)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "InputDate_Ture", MessageBoxIcon.Information)
            txtVisa_ExperiedDate.Focus()
            Exit Sub
        End If

        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db

        Dim strType As String
        Dim Data As New ArrayList

        Try
            Data.Clear() : strType = ""
            Data.Add(txtCode_D.Text.Trim) : strType &= "T"
            Data.Add(txtpp_NO.Text.Trim) : strType &= "T"
            Data.Add(ConvertDate(txtpp_Issueddate.Text)) : strType &= "T"
            Data.Add(ConvertDate(txtpp_Experieddate.Text)) : strType &= "T"
            Data.Add(IIf(optPP_NoneB.Checked = True, 1, 0)) : strType &= "T"
            Data.Add(IIf(optPP_Multiple.Checked = True, 1, 0)) : strType &= "T"


            Strsql = "Insert Into Passport(EmpId,PassportNo,IssuedDate,ExperiedDate,Type_NoneB,Type_Multiple) Values " & _
                                            "(@P1,@P2,@P3,@P4,@P5,@P6)"

            Call dbMgr.OpenDatabase(Conn, True)
            db.ExecuteCommand(Conn, dcmd, Strsql, strType, Data)
            Call dbMgr.OpenDatabase(Conn, False)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Call cmdPP_Refresh_Click(e, System.EventArgs.Empty)
    End Sub

    Private Sub cmdPP_Refresh_Click(sender As System.Object, e As System.EventArgs) Handles cmdPP_Refresh.Click
        txtpp_NO.Text = ""
        txtpp_NO.Enabled = True
        txtpp_Issueddate.Text = "__/__/____"
        txtpp_Experieddate.Text = "__/__/____"
        optPP_NoneB.Checked = True
        Call LoadPassport(txtCode_D.Text.Trim)
        'If frmEditEmp.txtCode.Enabled = True Then
        '    Call EndBtnPassport(False, False, False)
        'Else
        '    Call EndBtnPassport(True, False, False)
        'End If
        Call EndBtnPassport(True, False, False)
    End Sub

    Public Sub LoadPassport(Code As String)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db
        Dim arrdata() As String
        Dim List As ListViewItem

        Strsql = "Select PassportNo,Issueddate,ExperiedDate,type_noneb,type_multiple " & _
                " from Passport " & _
                " where empid = '" & Code.Trim & "'"

        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dcmd, Strsql)
        Da.SelectCommand = dcmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                lstPassport.Items.Clear()
                Exit Sub
            End If

            lstPassport.BeginUpdate()
            lstPassport.Items.Clear()
            Dim I As Integer = 0
            Dim Issueddate_ As DateTime
            Dim Experieddate_ As DateTime
            For Each drw As DataRow In .Rows
                I += 1
                Issueddate_ = drw("Issueddate")
                Experieddate_ = drw("Experieddate")

                arrdata = New String() {I, _
                                        drw("PassportNo"), _
                                        Format(Issueddate_, "dd/MM/yyyy"), _
                                        Experieddate_, _
                                        IIf(drw("type_noneb"), "/", ""), _
                                        IIf(drw("type_multiple"), "/", "")}

                'arrdata = New String() {I, _
                '                      drw("PassportNo"), _
                '                      ConvertDate_Eng(drw("Issueddate")), _
                '                      ConvertDate_Eng(drw("Experieddate")), _
                '                      IIf(drw("type_noneb"), "/", ""), _
                '                      IIf(drw("type_multiple"), "/", "")}

                List = New ListViewItem(arrdata)
                lstPassport.Items.Add(List)
            Next
            lstPassport.EndUpdate()
        End With

    End Sub


    Private Sub EndBtnPassport(Add As Boolean, Edit As Boolean, Delete As Boolean)
        cmdPP_Add.Enabled = Add
        cmdPP_Edit.Enabled = Edit
        cmdPP_Delete.Enabled = Delete
    End Sub

    Private Sub cmdPP_Edit_Click(sender As System.Object, e As System.EventArgs) Handles cmdPP_Edit.Click

        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db

        Dim strType As String
        Dim Data As New ArrayList

        If txtCode_D.Text = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Select_Emp_Code", MessageBoxIcon.Information)
            Exit Sub
        End If

        If IsDate(ConvertDate(txtpp_Issueddate.Text)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "InputDate_Ture", MessageBoxIcon.Information)
            txtVisa_IssuedDate.Focus()
            Exit Sub
        End If
        If IsDate(ConvertDate(txtpp_Experieddate.Text)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "InputDate_Ture", MessageBoxIcon.Information)
            txtVisa_ExperiedDate.Focus()
            Exit Sub
        End If

        Try
            Data.Clear() : strType = ""
            Data.Add(txtCode_D.Text.Trim) : strType &= "T"
            Data.Add(txtpp_NO.Text.Trim) : strType &= "T"
            Data.Add(ConvertDate(txtpp_Issueddate.Text)) : strType &= "T"
            Data.Add(ConvertDate(txtpp_Experieddate.Text)) : strType &= "T"
            Data.Add(IIf(optPP_NoneB.Checked = True, 1, 0)) : strType &= "T"
            Data.Add(IIf(optPP_Multiple.Checked = True, 1, 0)) : strType &= "T"

            'If optVisa_NoneB.Checked = True Then
            '    Data.Add(1) : strType &= "T"
            'Else
            '    Data.Add(0) : strType &= "T"
            'End If

            'If optVisa_Multiple.Checked = True Then
            '    Data.Add(1) : strType &= "T"
            'Else
            '    Data.Add(0) : strType &= "T"
            'End If


            Strsql = "Update Passport Set IssuedDate = @P3, " & _
                                        " ExperiedDate = @P4," & _
                                        " Type_NoneB = @P5, " & _
                                        " Type_Multiple =@P6 " & _
                            " where EmpId = @P1 And PassportNo = @P2 "

            Call dbMgr.OpenDatabase(Conn, True)
            db.ExecuteCommand(Conn, dcmd, Strsql, strType, Data)
            Call dbMgr.OpenDatabase(Conn, False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Call cmdPP_Refresh_Click(e, System.EventArgs.Empty)
    End Sub

    Private Sub cmdPP_Delete_Click(sender As System.Object, e As System.EventArgs) Handles cmdPP_Delete.Click
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db

        Dim strType As String
        Dim Data As New ArrayList


        If txtCode_D.Text = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Select_Emp_Code", MessageBoxIcon.Information)
            Exit Sub
        End If


        Data.Clear() : strType = ""
        Data.Add(txtCode_D.Text.Trim) : strType &= "T"
        Data.Add(txtpp_NO.Text.Trim) : strType &= "T"

        Strsql = "Delete Passport " & _
                        " where EmpId = @P1 And PassportNo=@P2"
        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dcmd, Strsql, strType, Data)
        Call dbMgr.OpenDatabase(Conn, False)

        Call cmdPP_Refresh_Click(e, System.EventArgs.Empty)
    End Sub

    Private Sub lstPassport_DoubleClick(sender As Object, e As System.EventArgs) Handles lstPassport.DoubleClick
        If lstPassport.SelectedItems.Count = 0 Then Exit Sub
        txtpp_NO.Text = lstPassport.SelectedItems(0).SubItems(1).Text.Trim
        txtpp_Issueddate.Text = lstPassport.SelectedItems(0).SubItems(2).Text.Trim
        txtpp_Experieddate.Text = lstPassport.SelectedItems(0).SubItems(3).Text.Trim
        optPP_NoneB.Checked = IIf(lstPassport.SelectedItems(0).SubItems(4).Text = "/", True, False)
        optPP_Multiple.Checked = IIf(lstPassport.SelectedItems(0).SubItems(5).Text = "/", True, False)

        txtpp_NO.Enabled = False
        Call EndBtnPassport(False, True, True)
    End Sub

    Private Sub lstPassport_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstPassport.SelectedIndexChanged

    End Sub

    Private Sub txtSonAge2_GotFocus(sender As Object, e As System.EventArgs) Handles txtSonAge2.GotFocus
        txtSonAge2.SelectAll()
    End Sub

    Private Sub txtSonAge2_LostFocus(sender As Object, e As System.EventArgs) Handles txtSonAge2.LostFocus
        If IsNumeric(txtSonAge2.Text) = False Then
            txtSonAge2.Text = "0"
        End If

        If txtSonAge2.Text = "" Then
            txtSonAge2.Text = "0"
        End If
    End Sub

    Private Sub txtSonAge2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSonAge2.TextChanged

    End Sub

    Private Sub txtSonAge1_GotFocus(sender As Object, e As System.EventArgs) Handles txtSonAge1.GotFocus
        txtSonAge1.SelectAll()
    End Sub

    Private Sub txtSonAge1_LostFocus(sender As Object, e As System.EventArgs) Handles txtSonAge1.LostFocus
        If IsNumeric(txtSonAge1.Text) = False Then
            txtSonAge1.Text = "0"
        End If

        If txtSonAge1.Text = "" Then
            txtSonAge1.Text = "0"
        End If
    End Sub

    Private Sub txtSonAge1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSonAge1.TextChanged

    End Sub

    Private Sub txtAddress_GotFocus(sender As Object, e As System.EventArgs) Handles txtAddress.GotFocus
        txtAddress.SelectAll()
    End Sub

    Private Sub txtSalary_GotFocus(sender As Object, e As System.EventArgs) Handles txtSalary.GotFocus
        txtSalary.SelectAll()
    End Sub

    Private Sub txtCapitalSumary_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCapitalSumary.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtSonEdu.Focus()
        End If
    End Sub

    Private Sub txtSonNonEdu_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtSonNonEdu.Focus()
        End If
    End Sub

    Private Sub LoadEmpImg()
        Dim PicPath As String
        PicPath = LoadPicPath() & "\" & txtCode_D.Text & ".jpg"
        If Dir(PicPath) <> "" Then
            PicBox.Image = New Bitmap(PicPath)
        Else
            PicBox.Image = Nothing
        End If

    End Sub

    Public Function LoadPicPath() As String
        '//Public Const PathPicture = "\\w2ksrv\HrDepartment\empPicture\"
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db
        Strsql = "Select Isnull(PicPath,'') as PicPath From Company"

        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dcmd, Strsql)
        Da.SelectCommand = dcmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("PicPath")
            End If
        End With
    End Function

    Private Sub txtSonEdu_LostFocus(sender As Object, e As System.EventArgs)
        If IsNumeric(txtSonEdu.Text) = False Then
            txtSonEdu.Text = "0"
        End If

        If txtSonEdu.Text = "" Then
            txtSonEdu.Text = "0"
        End If
    End Sub

    Private Sub txtSonEdu_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub txtSonNonEdu_LostFocus(sender As Object, e As System.EventArgs)
        If IsNumeric(txtSonNonEdu.Text) = False Then
            txtSonNonEdu.Text = "0"
        End If

        If txtSonNonEdu.Text = "" Then
            txtSonNonEdu.Text = "0"
        End If
    End Sub

    Private Sub txtSonNonEdu_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub txtSonAge3_LostFocus(sender As Object, e As System.EventArgs) Handles txtSonAge3.LostFocus

        If IsNumeric(txtSonAge3.Text) = False Then
            txtSonAge3.Text = "0"
        End If

        If txtSonAge3.Text = "" Then
            txtSonAge3.Text = "0"
        End If
    End Sub

    Private Sub txtSonAge3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSonAge3.TextChanged

    End Sub

    Private Sub txtSonAge4_LostFocus(sender As Object, e As System.EventArgs) Handles txtSonAge4.LostFocus
        If IsNumeric(txtSonAge4.Text) = False Then
            txtSonAge4.Text = "0"
        End If

        If txtSonAge4.Text = "" Then
            txtSonAge4.Text = "0"
        End If
    End Sub

    Private Sub txtSonAge4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSonAge4.TextChanged

    End Sub

    Private Sub txtSonAge5_LostFocus(sender As Object, e As System.EventArgs) Handles txtSonAge5.LostFocus
        If IsNumeric(txtSonAge5.Text) = False Then
            txtSonAge5.Text = "0"
        End If

        If txtSonAge5.Text = "" Then
            txtSonAge5.Text = "0"
        End If
    End Sub

    Function AutoNumber() As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db

        Strsql = "select Isnull(max(code),0)+1 as NewCode from emp"

        Try
            Call dbMgr.OpenDatabase(Conn, True)
            db.ExecuteCommand(Conn, dcmd, Strsql)
            Da.SelectCommand = dcmd
            Da.Fill(Ds, "data")
            Call dbMgr.OpenDatabase(Conn, False)

            With Ds.Tables("data")
                If .Rows.Count = 0 Then
                    Return "00001"
                Else
                    Return Format(.Rows(0).Item("Newcode"), "00000")
                End If
            End With

        Catch ex As Exception
            Return "000001"
        End Try


    End Function


    Private Sub cmdDivBrowse_Click(sender As System.Object, e As System.EventArgs) Handles cmdDivBrowse.Click
        ListDivision = Devision.Emp

        Try
            If fListDivision Is Nothing Then
                fListDivision = New frmListDivision
            Else
                If fListDivision.IsDisposed = True Then
                    fListDivision = New frmListDivision
                End If
            End If


            fListDivision.StartPosition = FormStartPosition.CenterScreen
            fListDivision.BringToFront()
            fListDivision.Show()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try


    End Sub

    Private Sub cmdDeptBrowse_Click(sender As System.Object, e As System.EventArgs) Handles cmdDeptBrowse.Click
        ListDepartment = Department.Emp

        Try
            If fListDepartment Is Nothing Then
                fListDepartment = New frmListDepartment
            Else
                If fListDepartment.IsDisposed = True Then
                    fListDepartment = New frmListDepartment
                End If
            End If


            fListDepartment.StartPosition = FormStartPosition.CenterScreen
            fListDepartment.BringToFront()
            fListDepartment.Show()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnSection_Click(sender As System.Object, e As System.EventArgs) Handles btnSection.Click
        ListSection = Section.Emp

        Try
            If fListSection Is Nothing Then
                fListSection = New frmListSection
            Else
                If fListSection.IsDisposed = True Then
                    fListSection = New frmListSection
                End If
            End If


            fListSection.StartPosition = FormStartPosition.CenterScreen
            fListSection.BringToFront()
            fListSection.Show()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub txtDivID_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDivID.TextChanged

    End Sub

    Private Sub cmdConfirm_Click(sender As System.Object, e As System.EventArgs) Handles cmdConfirm.Click

        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList

        Data.Clear() : strType = ""
        Data.Add(txtCode_D.Text.Trim) : strType &= "T"
        Data.Add(ConvertDate(txtTermiDate_Move.Text.Trim)) : strType &= "T"
        Data.Add("T") : strType &= "T"

        strSQL = "Update Emp Set WorkStatus = @P3,TermiDate = @P2,LastUpdate = GetDate() " & _
                       " Where Code = @P1"



        Try
            Call dbMgr.OpenDatabase(Conn, True)
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
            Call dbMgr.OpenDatabase(Conn, False)
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Me.Text)
            Exit Sub
        End Try



        ' เพิ่มเติมจากเดิม บันทึกลงตาราง  OutOfWork----------------------------------------
        Data.Clear() : strType = ""
        Data.Add(txtCode_D.Text.Trim) : strType &= "T"
        Data.Add(txtFname_Det.Text.Trim) : strType &= "T"
        Data.Add(txtDeptId.Text.Trim) : strType &= "T"
        Data.Add(ConvertDate(txtDateIn.Text.Trim)) : strType &= "T"
        Data.Add(ConvertDate(txtTermiDate_Move.Text.Trim)) : strType &= "T"
        Data.Add("O") : strType &= "T"
        strSQL = "Insert Into OutOfwork (EmpId,Fname,DepartMent,dateFwork,DateOut,StatusInOut) Values (" & _
                                                  " @P1,@P2,@P3,@P4,@P5,@P6)"



        Try
            Call dbMgr.OpenDatabase(Conn, True)
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
            Call dbMgr.OpenDatabase(Conn, False)
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Me.Text)
            Exit Sub
        End Try

        Call LoadData_Detail(e, System.EventArgs.Empty)
        MsgManager.ShowDialog(Me, "Messages", Me.Text, "MoveEmp", MessageBoxIcon.Information)
    End Sub

    Private Sub LstData_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LstData.SelectedIndexChanged

    End Sub

    Private Sub btnTrain_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrain_Clear.Click
        txtTrainigName.Text = ""
        txtTrainingDateST.Text = ""
        txtTrainingDateSP.Text = ""
        txtTrainingDay.Text = ""
        txtTrainingRemark.Text = ""

        Call EnaTraining(True, False, False)
    End Sub

    Private Sub EnaTraining(ByVal Add As Boolean, ByVal Edit As Boolean, ByVal Delete As Boolean)
        btnTrain_Add.Enabled = Add
        btnTrain_Edit.Enabled = Edit
        btnTrain_Delete.Enabled = Delete
    End Sub

    Private Sub btnTrain_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrain_Add.Click
        If txtTrainigName.Text.Trim = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "กรุณาป้อน อบรมเรื่อง", MessageBoxIcon.Information)
            txtTrainigName.Focus()
            Exit Sub
        End If
        If IsDate(ConvertDate(txtTrainingDateST.Text.Trim)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "กรุณาป้อนวันที่ให้ถูกต้องด้วย", MessageBoxIcon.Information)
            txtTrainingDateST.Focus()
            Exit Sub
        End If
        If IsDate(ConvertDate(txtTrainingDateSP.Text.Trim)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "กรุณาป้อนวันที่ให้ถูกต้องด้วย", MessageBoxIcon.Information)
            txtTrainingDateSP.Focus()
            Exit Sub
        End If

        Dim arrData() As String
        Dim List As ListViewItem
        Dim day As Integer = DateDiff(DateInterval.Day, CDate(ConvertDate(txtTrainingDateST.Text.Trim)), CDate(ConvertDate(txtTrainingDateSP.Text.Trim))) + 1

        arrData = New String() {lstTraining.Items.Count + 1, _
                                txtTrainigName.Text.Trim, _
                                txtTrainingDateST.Text.Trim, _
                                txtTrainingDateSP.Text.Trim, _
                                day, _
                                txtTrainingRemark.Text.Trim}
        List = New ListViewItem(arrData)
        lstTraining.Items.Add(List)

        Call btnTrain_Clear_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub btnTrain_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrain_Edit.Click
        If txtTrainigName.Text.Trim = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "กรุณาป้อน อบรมเรื่อง", MessageBoxIcon.Information)
            txtTrainigName.Focus()
            Exit Sub
        End If
        If IsDate(ConvertDate(txtTrainingDateST.Text.Trim)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "กรุณาป้อนวันที่ให้ถูกต้องด้วย", MessageBoxIcon.Information)
            txtTrainingDateST.Focus()
            Exit Sub
        End If
        If IsDate(ConvertDate(txtTrainingDateSP.Text.Trim)) = False Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "กรุณาป้อนวันที่ให้ถูกต้องด้วย", MessageBoxIcon.Information)
            txtTrainingDateSP.Focus()
            Exit Sub
        End If


        Dim day As Integer = DateDiff(DateInterval.Day, CDate(ConvertDate(txtTrainingDateST.Text.Trim)), CDate(ConvertDate(txtTrainingDateSP.Text.Trim))) + 1


        With lstTraining
            Dim RwId As Integer = CInt(txtTraining_RowId.Text)
            .Items(RwId).SubItems(1).Text = txtTrainigName.Text.Trim
            .Items(RwId).SubItems(2).Text = txtTrainingDateST.Text.Trim()
            .Items(RwId).SubItems(3).Text = txtTrainingDateSP.Text.Trim()
            .Items(RwId).SubItems(4).Text = txtTrainingDay.Text.Trim()
            .Items(RwId).SubItems(5).Text = txtTrainingRemark.Text.Trim
        End With

        Call btnTrain_Clear_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub btnTrain_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrain_Delete.Click
        If txtTraining_RowId.Text.Trim = "" Then
            MsgManager.ShowDialog(Me, "Messages", Me.Text, "Please_select_data", MessageBoxIcon.Information)
            Exit Sub
        End If

        With lstTraining
            Dim RwId As Integer = CInt(txtTraining_RowId.Text)

            .Items.RemoveAt(RwId)

            ' reset row
            For i As Integer = 0 To .Items.Count - 1
                .Items(i).SubItems(0).Text = i + 1
            Next
        End With

        Call btnTrain_Clear_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub lstTraining_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstTraining.DoubleClick
        With lstTraining
            If .SelectedItems.Count = 0 Then Exit Sub
            txtTraining_RowId.Text = .Items.IndexOf(.SelectedItems(0))

            txtTrainigName.Text = .SelectedItems(0).SubItems(1).Text.Trim
            txtTrainingDateST.Text = .SelectedItems(0).SubItems(2).Text.Trim
            txtTrainingDateSP.Text = .SelectedItems(0).SubItems(3).Text.Trim
            txtTrainingDay.Text = .SelectedItems(0).SubItems(4).Text.Trim
            txtTrainingRemark.Text = .SelectedItems(0).SubItems(5).Text.Trim

            Call EnaTraining(False, True, True)

        End With
    End Sub

    Private Sub LoadTraining(ByVal code As String)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim dcmd As New SqlCommand
        Dim db As New db
        Dim Strsql As String = ""

        Strsql = "Select * from Training where code=N'" & code.Trim & "'  "

        Try

            Call dbMgr.OpenDatabase(Conn, True)
            db.ExecuteCommand(Conn, dcmd, Strsql)
            Da.SelectCommand = dcmd
            Da.Fill(Ds, "data")
            Call dbMgr.OpenDatabase(Conn, False)
            With Ds.Tables("data")
                'If .Rows.Count = 0 Then
                '    Exit Sub
                'End If

                Dim arrDATA() As String
                Dim List As ListViewItem

                lstTraining.Items.Clear()

                For Each dr As DataRow In .Rows
  
                    Dim day As Integer = DateDiff(DateInterval.Day, dr("DateST"), dr("DateSP")) + 1


                    arrDATA = New String() {lstTraining.Items.Count + 1, _
                                             dr("TrainingName"), _
                                             Format(dr("DateST"), "dd/MM/yyyy"), _
                                             Format(dr("DateSP"), "dd/MM/yyyy"), _
                                             day, _
                                             dr("Remark")}
                    List = New ListViewItem(arrDATA)
                    lstTraining.Items.Add(List)
                Next
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Insert_Training(ByVal code As String)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim db As New db
        Dim dcmd As New SqlCommand
        Dim StrType As String = ""
        Dim Data As New ArrayList
        ' Insert Son
        'Dim i As Integer = 0

        With lstTraining
            For i As Integer = 0 To .Items.Count - 1
                Data.Clear() : StrType = ""
                Data.Add(txtCode_D.Text.Trim) : StrType &= "T"
                Data.Add(.Items(i).SubItems(1).Text.Trim) : StrType &= "T"

                If .Items(i).SubItems(2).Text.Trim = "" Then
                    Data.Add(DBNull.Value) : StrType &= "T"
                Else
                    Data.Add(ConvertDate(.Items(i).SubItems(2).Text.Trim)) : StrType &= "T"
                End If

                If .Items(i).SubItems(3).Text.Trim = "" Then
                    Data.Add(DBNull.Value) : StrType &= "T"
                Else
                    Data.Add(ConvertDate(.Items(i).SubItems(3).Text.Trim)) : StrType &= "T"
                End If

                Data.Add(.Items(i).SubItems(5).Text.Trim) : StrType &= "T"


                Strsql = "Insert into Training(code,TrainingName,DateST,DateSP,Remark) values (@P1,@P2,@P3,@P4,@P5)"

                Call dbMgr.OpenDatabase(Conn, True)
                db.ExecuteCommand(Conn, dcmd, Strsql, StrType, Data)
                Call dbMgr.OpenDatabase(Conn, False)
            Next
        End With

    End Sub

    Private Sub Delete_Training(ByVal Code As String)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim db As New db
        Dim dcmd As New SqlCommand
        Dim StrType As String = ""
        Dim Data As New ArrayList

        Try
            Dim SqlDel As String = ""
            Data.Clear() : StrType = ""
            Data.Add(txtCode_D.Text.Trim) : StrType &= "T"

            Strsql = "Delete from Training" & _
                    " Where code = @P1 "
            Call dbMgr.OpenDatabase(Conn, True)
            db.ExecuteCommand(Conn, dcmd, Strsql, StrType, Data)
            Call dbMgr.OpenDatabase(Conn, False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' Delete Son

    End Sub

    Private Sub lstTraining_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTraining.SelectedIndexChanged

    End Sub

    Private Sub txtTrainingDateST_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTrainingDateST.LostFocus
        txtTrainingDateSP.Text = txtTrainingDateST.Text.Trim

        If IsDate(ConvertDate(txtTrainingDateST.Text.Trim)) = False Then
            Exit Sub
        End If
        If IsDate(ConvertDate(txtTrainingDateSP.Text.Trim)) = False Then
            Exit Sub
        End If

        Dim day As Integer = DateDiff(DateInterval.Day, CDate(ConvertDate(txtTrainingDateST.Text.Trim)), CDate(ConvertDate(txtTrainingDateSP.Text.Trim))) + 1

        txtTrainingDay.Text = day
    End Sub

    Private Sub txtTrainingDateST_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtTrainingDateST.MaskInputRejected

    End Sub

    Private Sub txtTrainingDateSP_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTrainingDateSP.LostFocus
        If IsDate(ConvertDate(txtTrainingDateST.Text.Trim)) = False Then
            Exit Sub
        End If
        If IsDate(ConvertDate(txtTrainingDateSP.Text.Trim)) = False Then
            Exit Sub
        End If

        Dim day As Integer = DateDiff(DateInterval.Day, CDate(ConvertDate(txtTrainingDateST.Text.Trim)), CDate(ConvertDate(txtTrainingDateSP.Text.Trim))) + 1

        txtTrainingDay.Text = day
    End Sub

    Private Sub txtTrainingDateSP_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtTrainingDateSP.MaskInputRejected

    End Sub

    Private Sub txtCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.GotFocus
        txtFname.Text = ""
    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged

    End Sub

    Private Sub txtFname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFname.GotFocus
        txtCode.Text = ""
    End Sub

    Private Sub txtFname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFname.TextChanged

    End Sub

   
End Class

