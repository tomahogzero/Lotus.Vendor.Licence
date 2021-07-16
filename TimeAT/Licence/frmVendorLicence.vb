Imports TimeAttendance.utils
Imports System.IO
Imports System.Globalization

Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Threading.Thread
Imports DevExpress.XtraReports.UI
Imports DevExpress.LookAndFeel

Public Class frmVendorLicence
    Protected dbMgr As New DBManager
    Protected dbConnStr As String = dbMgr.getConnString

    Dim gData As New GetData
    Dim LockID As Boolean = True
    Public StatusEmp As String = "W"

    Dim id As Integer = 0

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()


        CurrentThread.CurrentCulture = New CultureInfo("en-US")
        CurrentThread.CurrentUICulture = New CultureInfo("en-US")

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmEmp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName & " v." & Application.ProductVersion
        ' txtDateStartWork.EditValue = Now.Date
        txtlic_StartDate.EditValue = Now.Date
        txtlic_ExpireDate.EditValue = Now.Date.AddYears(1)

        Call EnaCmd(True, False, False)
        Call LoadVendor()
        Call LoadInvoice()

        Call LoadProcess()
        Call LoadProcessLog()

        Call LoadDivision()
        Call LoadSection()
    End Sub

    Private Sub LoadStatus()
        'txtStatus.Items.Add("โสด")
        'txtStatus.Items.Add("สมรส")
        'txtStatus.Items.Add("หม่าย")
        'txtStatus.Items.Add("หย่าร้าง")
        'txtStatus.Items.Add("แยกกันอยู่")
    End Sub

    Public Sub EnaCmd(ByVal Add As Boolean, ByVal Edit As Boolean, ByVal Delete As Boolean)
        btnAdd.Enabled = Add
        btnEdit.Enabled = Edit
        btnDelete.Enabled = Delete
    End Sub

    Public Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Trim(txtVendorId.Text) = "" Then
            MsgBox("กรุณาป้อน Vendor Code", MsgBoxStyle.Information, Me.Text)
            txtVendorId.Focus()
            Exit Sub
        End If

        If Trim(txtVendorName.Text) = "" Then
            MsgBox("กรุณาป้อนชื่อ Vendor", MsgBoxStyle.Information, Me.Text)
            txtVendorName.Focus()
            Exit Sub
        End If

        Dim res As String = Vendor_Input(txtVendorId.Text.Trim,
                                         txtAllVendorId.Text.Trim,
                                         txtVendorName.Text.Trim,
                                         txtAddress1.Text.Trim, txtAddress2.Text.Trim,
                                         txtzipcode.Text.Trim,
                                         txtEmail.Text.Trim,
                                         txttel.Text.Trim,
                                         txtlic_StartDate.EditValue,
                                         txtlic_ExpireDate.EditValue,
                                         txtLicence.Text,
                                         txtLicenceKey.Text.Trim,
                                         cboDivision.EditValue,
                                         cboSection.EditValue,
                                         txtContract_no.Text.Trim,
                                         txtContract_Date.EditValue,
                                         txtContract_at.Text.Trim,
                                         txtJuristic_Person_Registration_No.Text.Trim,
                                         txtSign_Contract_Name1.Text.Trim,
                                         txtSign_Contract_Position1.Text.Trim,
                                         txtSign_Contract_Tel1.Text.Trim,
                                         txtSign_Contract_Name2.Text.Trim,
                                         txtSign_Contract_Position2.Text.Trim,
                                         txtSign_Contract_Tel2.Text.Trim,
                                         txtContract_Name.Text.Trim,
                                         txtContract_Position.Text.Trim,
                                         txtContract_EMail.Text.Trim,
                                         txtContract_Tel.Text.Trim,
                                         0, txtRemark.Text.Trim)

        If res <> "" Then
            MsgBox(res, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        '  MsgManager.ShowDialog(Me, "Messages", Me.Text, "Save_Complete", MessageBoxIcon.Information)
        MsgBox("บันทึกเรียบร้อย", MsgBoxStyle.Information, "บันทึก")

        Call LoadVendor()
        Call EnaCmd(True, False, False)
        Call btnClear_Click(Me, System.EventArgs.Empty)

    End Sub

    Public Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        If Trim(txtVendorId.Text) = "" Then
            MsgBox("กรุณาป้อน Vendor Code", MsgBoxStyle.Information, Me.Text)
            txtVendorId.Focus()
            Exit Sub
        End If

        If Trim(txtVendorName.Text) = "" Then
            MsgBox("กรุณาป้อนชื่อ Vendor", MsgBoxStyle.Information, Me.Text)
            txtVendorName.Focus()
            Exit Sub
        End If

        If txtlic_StartDate.EditValue Is Nothing Then

        End If

        Dim res As String = Vendor_Update(id,
                                            txtVendorId.Text.Trim,
                                            txtAllVendorId.Text.Trim,
                                            txtVendorName.Text.Trim,
                                            txtAddress1.Text.Trim,
                                            txtAddress2.Text.Trim,
                                            txtzipcode.Text.Trim,
                                            txtEmail.Text.Trim,
                                            txttel.Text.Trim,
                                            IIf(IsDBNull(txtlic_StartDate.EditValue), Nothing, txtlic_StartDate.EditValue),
                                            IIf(IsDBNull(txtlic_ExpireDate.EditValue), Nothing, txtlic_ExpireDate.EditValue),
                                            txtLicence.Text,
                                            txtLicenceKey.Text.Trim,
                                            cboDivision.EditValue,
                                            cboSection.EditValue,
                                            txtContract_no.Text.Trim,
                                            txtContract_Date.EditValue,
                                            txtContract_at.Text.Trim,
                                            txtJuristic_Person_Registration_No.Text.Trim,
                                            txtSign_Contract_Name1.Text.Trim,
                                            txtSign_Contract_Position1.Text.Trim,
                                            txtSign_Contract_Tel1.Text.Trim,
                                            txtSign_Contract_Name2.Text.Trim,
                                            txtSign_Contract_Position2.Text.Trim,
                                            txtSign_Contract_Tel2.Text.Trim,
                                            txtContract_Name.Text.Trim,
                                            txtContract_Position.Text.Trim,
                                            txtContract_EMail.Text.Trim,
                                            txtContract_Tel.Text.Trim,
                                            txtRemark.Text.Trim)

        MsgBox("แก้ไขข้อมูลเรียบร้อย", MsgBoxStyle.Information, "แก้ไข")
        Call LoadVendor()
        Call EnaCmd(True, False, False)
        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Public Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        '   If MsgManager.ConfirmDialog(Me, "Messages", Me.Text, "Del_Confirm_Msg", MessageBoxIcon.Information) = DialogResult.Cancel Then Exit Sub
        If MsgBox("คุณต้องลบข้อมูลหรือไม่", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = vbNo Then Exit Sub

        'If MsgBox(My.Resources.res_warning_message_spacial.Quit_job, MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = vbNo Then Exit Sub
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
        Data.Add(id) : strType &= "I"

        strSQL = "Delete From vendor_group " &
                " Where vendorgroupid = @P1 "

        Try

            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)

        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Me.Text)
            Exit Sub
        End Try



        'MsgManager.ShowDialog(Me, "Messages", Me.Text, "Del_Complete", MessageBoxIcon.Information)

        MsgBox("ลบข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information, "ลบ")
        Call btnClear_Click(Me, System.EventArgs.Empty)
        Call LoadVendor()
        Call EnaCmd(True, False, False)
    End Sub

    Public Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call LoadVendor()
        Call clearData()
        Call EnaCmd(True, False, False)

        id = 0
        txtVendorId.Enabled = True
        txtVendorId.Text = ""
        txtVendorId.Focus()
    End Sub

    Public Function Vendor_Input(VendorId As String, AllVendorId As String, vendor_name As String, address1 As String, address2 As String, zipcode As String, email As String, tel As String, lic_start_date As DateTime, lic_expire_date As DateTime, account As Double, licenceKey As String, divisionid As Double, sectionid As Double, contract_no As String, contract_date As DateTime, contract_at As String, juristic_person_registration_no As String, sign_contract_name As String, sign_contract_position As String, sign_contract_tel As String, sign_contract_name2 As String, sign_contract_position2 As String, sign_contract_tel2 As String, contract_name As String, contract_position As String, contract_email As String, contract_tel As String, processid As Double, remark As String) As String
        Dim cn As New SqlConnection
        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim data As New ArrayList
        Dim strType As String = ""
        Dim strSQL As String = ""

        strSQL = "Insert Into vendor_group(VendorId,AllVendorId,vendor_name,address1,address2,zipcode,email,tel,lic_start_date,lic_expire_date,account,licenceKey,divisionid,sectionid,contract_no,contract_date,contract_at,juristic_person_registration_no,sign_contract_name,sign_contract_position,sign_contract_tel,sign_contract_name2,sign_contract_position2,sign_contract_tel2,contract_name,contract_position,contract_email,contract_tel,processid,remark) " &
                                        "Values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12,@P13,@P14,@P15,@P16,@P17,@P18,@P19,@P20,@P21,@P22,@P23,@P24,@P25,@P26,@P27,@P28,@P29,@P30)"

        Try
            data.Clear() : strType = ""
            data.Add(VendorId) : strType &= "T"
            data.Add(AllVendorId) : strType &= "T"
            data.Add(vendor_name) : strType &= "T"
            data.Add(address1) : strType &= "T"
            data.Add(address2) : strType &= "T"
            data.Add(zipcode) : strType &= "T"
            data.Add(email) : strType &= "T"
            data.Add(tel) : strType &= "T"

            If lic_start_date = Nothing Then
                data.Add(DBNull.Value) : strType &= "T"
            Else
                data.Add(Format(lic_start_date, "yyyy/MM/dd HH:mm:ss")) : strType &= "T"
            End If


            If lic_expire_date = Nothing Then
                data.Add(DBNull.Value) : strType &= "T"
            Else
                data.Add(Format(lic_expire_date, "yyyy/MM/dd HH:mm:ss")) : strType &= "T"
            End If

            data.Add(account) : strType &= "S"
            data.Add(licenceKey) : strType &= "T"
            data.Add(divisionid) : strType &= "S"
            data.Add(sectionid) : strType &= "S"
            data.Add(contract_no) : strType &= "T"

            If contract_date = Nothing Then
                data.Add(DBNull.Value) : strType &= "T"
            Else
                data.Add(Format(contract_date, "yyyy/MM/dd HH:mm:ss")) : strType &= "T"
            End If

            data.Add(contract_at) : strType &= "T"
            data.Add(juristic_person_registration_no) : strType &= "T"
            data.Add(sign_contract_name) : strType &= "T"
            data.Add(sign_contract_position) : strType &= "T"
            data.Add(sign_contract_tel) : strType &= "T"
            data.Add(sign_contract_name2) : strType &= "T"
            data.Add(sign_contract_position2) : strType &= "T"
            data.Add(sign_contract_tel2) : strType &= "T"
            data.Add(contract_name) : strType &= "T"
            data.Add(contract_position) : strType &= "T"
            data.Add(contract_email) : strType &= "T"
            data.Add(contract_tel) : strType &= "T"
            data.Add(processid) : strType &= "S"
            data.Add(remark) : strType &= "T"

            db.OpenDatabase(cn, True)
            db.ExecuteCommand(cn, dCmd, strSQL, strType, data)
            db.OpenDatabase(cn, False)
            Return ""
        Catch ex As Exception
            db.OpenDatabase(cn, False)
            Return ex.Message
        End Try

    End Function

    Public Function Vendor_Update(vendorgroupid As Double, VendorId As String, AllVendorId As String, vendor_name As String, address1 As String, address2 As String, zipcode As String, email As String, tel As String, lic_start_date As DateTime, lic_expire_date As DateTime, account As Double, licenceKey As String, divisionid As Double, sectionid As Double, contract_no As String, contract_date As DateTime, contract_at As String, juristic_person_registration_no As String, sign_contract_name As String, sign_contract_position As String, sign_contract_tel As String, sign_contract_name2 As String, sign_contract_position2 As String, sign_contract_tel2 As String, contract_name As String, contract_position As String, contract_email As String, contract_tel As String, remark As String) As String
        Dim cn As New SqlConnection
        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim data As New ArrayList
        Dim strType As String = ""
        Dim strSQL As String = ""

        strSQL = "Update vendor_group Set " &
                          "VendorId = @P2" &
                          ",AllVendorId = @P3" &
                          ",vendor_name = @P4" &
                          ",address1 = @P5" &
                          ",address2 = @P6" &
                          ",zipcode = @P7" &
                          ",email = @P8" &
                          ",tel = @P9" &
                          ",lic_start_date = @P10" &
                          ",lic_expire_date = @P11" &
                          ",account = @P12" &
                          ",licenceKey = @P13" &
                          ",divisionid = @P14" &
                          ",sectionid = @P15" &
                          ",contract_no = @P16" &
                          ",contract_date = @P17" &
                          ",contract_at = @P18" &
                          ",juristic_person_registration_no = @P19" &
                          ",sign_contract_name = @P20" &
                          ",sign_contract_position = @P21" &
                          ",sign_contract_tel = @P22" &
                          ",sign_contract_name2 = @P23" &
                          ",sign_contract_position2 = @P24" &
                          ",sign_contract_tel2 = @P25" &
                          ",contract_name = @P26" &
                          ",contract_position = @P27" &
                          ",contract_email = @P28" &
                          ",contract_tel = @P29" &
                          ",remark = @P30" &
                          ",updatedate = getdate()" &
                  " Where vendorgroupid = @P1"

        Try
            data.Clear() : strType = ""
            data.Add(vendorgroupid) : strType &= "S"
            data.Add(VendorId) : strType &= "T"
            data.Add(AllVendorId) : strType &= "T"
            data.Add(vendor_name) : strType &= "T"
            data.Add(address1) : strType &= "T"
            data.Add(address2) : strType &= "T"
            data.Add(zipcode) : strType &= "T"
            data.Add(email) : strType &= "T"
            data.Add(tel) : strType &= "T"

            If lic_start_date = Nothing Then
                data.Add(DBNull.Value) : strType &= "T"
            Else
                data.Add(Format(lic_start_date, "yyyy/MM/dd HH:mm:ss")) : strType &= "T"
            End If


            If lic_expire_date = Nothing Then
                data.Add(DBNull.Value) : strType &= "T"
            Else
                data.Add(Format(lic_expire_date, "yyyy/MM/dd HH:mm:ss")) : strType &= "T"
            End If

            data.Add(account) : strType &= "S"
            data.Add(licenceKey) : strType &= "T"
            data.Add(divisionid) : strType &= "S"
            data.Add(sectionid) : strType &= "S"
            data.Add(contract_no) : strType &= "T"

            If contract_date = Nothing Then
                data.Add(DBNull.Value) : strType &= "T"
            Else
                data.Add(Format(contract_date, "yyyy/MM/dd HH:mm:ss")) : strType &= "T"
            End If

            data.Add(contract_at) : strType &= "T"
            data.Add(juristic_person_registration_no) : strType &= "T"
            data.Add(sign_contract_name) : strType &= "T"
            data.Add(sign_contract_position) : strType &= "T"
            data.Add(sign_contract_tel) : strType &= "T"
            data.Add(sign_contract_name2) : strType &= "T"
            data.Add(sign_contract_position2) : strType &= "T"
            data.Add(sign_contract_tel2) : strType &= "T"
            data.Add(contract_name) : strType &= "T"
            data.Add(contract_position) : strType &= "T"
            data.Add(contract_email) : strType &= "T"
            data.Add(contract_tel) : strType &= "T"
            data.Add(remark) : strType &= "T"

            db.OpenDatabase(cn, True)
            db.ExecuteCommand(cn, dCmd, strSQL, strType, data)
            db.OpenDatabase(cn, False)
            Return ""
        Catch ex As Exception
            db.OpenDatabase(cn, False)
            Return ex.Message
        End Try

    End Function

    Public Shared Function Vendor_Delete(vendorgroupid As Double) As String
        Dim cn As New SqlConnection
        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim data As New ArrayList
        Dim strType As String = ""
        Dim strSQL As String = ""

        strSQL = "Delete From vendor_group  Where vendorgroupid = @P1"

        Try
            data.Clear() : strType = ""
            data.Add(vendorgroupid) : strType &= "S"

            db.OpenDatabase(cn, True)
            db.ExecuteCommand(cn, dCmd, strSQL, strType, data)
            db.OpenDatabase(cn, False)
            Return ""
        Catch ex As Exception
            db.OpenDatabase(cn, False)
            Return ex.Message
        End Try
    End Function

    Private Sub clearData()
        id = 0
        txtVendorId.Text = ""
        txtAllVendorId.Text = ""
        txtVendorName.Text = ""
        txtAddress1.Text = ""
        txtAddress2.Text = ""
        txtzipcode.Text = ""
        txttel.Text = ""
        txtEmail.Text = ""
        cboDivision.EditValue = 0
        cboSection.EditValue = 0

        txtlic_StartDate.EditValue = Now.Date
        txtlic_ExpireDate.EditValue = Now.Date.AddYears(1)
        txtLicence.Text = 5
        txtLicenceKey.Text = ""

        txtContract_no.Text = ""
        txtContract_Date.EditValue = Now.Date
        txtContract_at.Text = ""
        txtJuristic_Person_Registration_No.Text = ""

        txtSign_Contract_Name1.Text = ""
        txtSign_Contract_Position1.Text = ""
        txtSign_Contract_Tel1.Text = ""

        txtSign_Contract_Name2.Text = ""
        txtSign_Contract_Position2.Text = ""
        txtSign_Contract_Tel2.Text = ""

        txtContract_Name.Text = ""
        txtContract_Position.Text = ""
        txtContract_Tel.Text = ""
        txtContract_EMail.Text = ""
        txtRemark.Text = ""
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

        strSQL = "Select * from EmpGroup" &
                " Where GroupId = @P1"

        db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")


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


        db.ExecuteCommand(Conn, dCmd, strSQL)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")


        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return "01"
            Else
                Dim dr As DataRow = .Rows(0)
                Return Format(dr("MaxID") + 1, "00")
            End If
        End With
    End Function

    Private Sub cmdRefresh_Click(sender As System.Object, e As System.EventArgs) Handles cmdRefresh.Click
        'Dim frm As New frmImportExcel
        'frm.StartPosition = FormStartPosition.CenterParent
        'frm.ShowDialog()
        'PG1.Visible = True
        'cmdRefresh.Enabled = False
        'cboCompany.Enabled = False
        'Call LoadData()

        'cmdRefresh.Enabled = True
        'cboCompany.Enabled = True

        'PG1.Visible = False
        Call LoadVendor()

    End Sub

    Private Sub PrintReportAll()
        Dim dbMgr As New DBManager

        For Each i As Long In GvEmp.GetSelectedRows
            Dim dr As DataRow = GvEmp.GetDataRow(i)

            Dim VendorId As String = dr("VendorId")
            Dim FileName As String = dbMgr.PDF_Path_Contract & "\" & VendorId & "-Contract.Pdf"

            PrintReport(VendorId, FileName)
        Next
    End Sub

    Private Sub PrintReportAll_Invoice()
        Dim dbMgr As New DBManager

        For Each i As Long In gvInvoice.GetSelectedRows
            Dim dr As DataRow = gvInvoice.GetDataRow(i)

            Dim vendorid As String = dr("VendorId")
            Dim bookno As String = dr("bookno")
            Dim idno As String = dr("idno")
            Dim FileName As String = dbMgr.PDF_Path_Invoice & "\Invoice-" & bookno & "-" & idno & "-" & vendorid & ".Pdf"

            PrintReport_Invoice(bookno, idno, FileName)
        Next
    End Sub

    Private Sub Update_Statusl_All(processid As Integer)
        Dim dbMgr As New DBManager

        For Each i As Long In GvEmp.GetSelectedRows
            Dim dr As DataRow = GvEmp.GetDataRow(i)

            Dim vendorgroupid As Integer = dr("vendorgroupid")
            update_status(vendorgroupid, processid)
        Next
    End Sub

    Private Sub Update_Licence_StartDate_All(d As DateTime)
        Dim dbMgr As New DBManager

        For Each i As Long In GvEmp.GetSelectedRows
            Dim dr As DataRow = GvEmp.GetDataRow(i)

            Dim vendorgroupid As Integer = dr("vendorgroupid")
            update_lic_startdate(vendorgroupid, d)
        Next
    End Sub

    Private Sub Update_Licence_ExpireDate_All(d As DateTime)
        Dim dbMgr As New DBManager

        For Each i As Long In GvEmp.GetSelectedRows
            Dim dr As DataRow = GvEmp.GetDataRow(i)

            Dim vendorgroupid As Integer = dr("vendorgroupid")
            update_lic_expiredate(vendorgroupid, d)
        Next
    End Sub

    Private Sub Update_Licence_ExpireDate_1Y_All()
        Dim dbMgr As New DBManager

        For Each i As Long In GvEmp.GetSelectedRows
            Dim dr As DataRow = GvEmp.GetDataRow(i)

            Dim vendorgroupid As Integer = dr("vendorgroupid")
            update_lic_expiredate_1y(vendorgroupid)
        Next
    End Sub



    Private Sub Update_Contract_at_All(contract_at As String)
        Dim dbMgr As New DBManager

        For Each i As Long In GvEmp.GetSelectedRows
            Dim dr As DataRow = GvEmp.GetDataRow(i)

            Dim vendorgroupid As Integer = dr("vendorgroupid")
            update_contract_at(vendorgroupid, contract_at)
        Next
    End Sub

    Private Sub Update_LicenceKey_All()
        Dim dbMgr As New DBManager

        For Each i As Long In GvEmp.GetSelectedRows
            Dim dr As DataRow = GvEmp.GetDataRow(i)

            If IsDBNull(dr("lic_start_date")) = False And
                IsDBNull(dr("lic_expire_date")) = False And
                IsDBNull(dr("account")) = False Then

                Dim vendorgroupid As Integer = dr("vendorgroupid")
                Dim vendorid As String = dr("VendorId")
                Dim lic_date_st As DateTime = dr("lic_start_date")
                Dim lic_date_sp As DateTime = dr("lic_expire_date")
                Dim account As Integer = dr("account")

                Dim key As String = LicenceKeyGen(vendorid, lic_date_st, lic_date_sp, account)
                update_licence_key(vendorgroupid, key)
            End If

            'update_contract_at(vendorgroupid, contract_at)
        Next
    End Sub

    Private Sub Export_Vendor_to_CSV_all(filename As String)
        Dim dbMgr As New DBManager

        ' export header
        export_csv(filename, "vendorid", "address1", "address2", "zipcode", "tax", "licenceKey", "tel", "email", "division", "section", "contract_name", "contract_tel", "contract_email", "AllVendorId")


        For Each i As Long In GvEmp.GetSelectedRows
            Dim dr As DataRow = GvEmp.GetDataRow(i)

            Dim vendorgroupid As Integer = dr("vendorgroupid")
            Dim vendorid As String = dr("VendorId")
            Dim address1 As String = dr("address1")
            Dim address2 As String = dr("address2")
            Dim zipcode As String = dr("zipcode")
            Dim tax As String = dr("juristic_person_registration_no")
            Dim licenceKey As String = dr("licenceKey")
            Dim tel As String = dr("tel")
            Dim email As String = dr("email")
            Dim division As String = dr("division")
            Dim section As String = dr("section_name")
            Dim contract_name As String = dr("contract_name")
            Dim contract_tel As String = dr("contract_tel")
            Dim contract_email As String = dr("contract_email")
            Dim AllVendorId As String = dr("AllVendorId")

            export_csv(filename, vendorid, address1, address2, zipcode, tax, licenceKey, tel, email, division, section, contract_name, contract_tel, contract_email, AllVendorId)
            'update_contract_at(vendorgroupid, contract_at)
        Next
    End Sub

    Private Sub PrintReport(VendorId As String, FileName As String)
        Dim dbMgr As New DBManager
        Dim report As New report_ContractApp
        Dim rptformular As String = ""


        report.SqlDataSource1.Connection.ConnectionString = dbMgr.getConnString

        rptformular = "[VendorId] = '" & VendorId & "'"

        report.RequestParameters = False
        report.FilterString = rptformular


        If chkPreviewContract.Checked = False Then
            report.ExportToPdf(FileName)
        Else
            Using printTool As New ReportPrintTool(report)
                printTool.AutoShowParametersPanel = False
                '   AddHandler printTool.PrintingSystem.StartPrint, New DevExpress.XtraPrinting.PrintDocumentEventHandler(AddressOf PrintingSystem_StartPrint)

                printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default)
            End Using
        End If
    End Sub

    Private Sub PrintReport_Invoice(bookno As String, idno As String, FileName As String)
        Dim dbMgr As New DBManager
        Dim report As New report_Invoice
        Dim rptformular As String = ""


        report.SqlDataSource1.Connection.ConnectionString = dbMgr.getConnString

        rptformular = "[bookno] = '" & bookno & "' And [idno] = '" & idno & "'"

        report.RequestParameters = False
        report.FilterString = rptformular

        If chkPreviewInvoice.Checked = False Then
            report.ExportToPdf(FileName)
        Else
            Using printTool As New ReportPrintTool(report)
                printTool.AutoShowParametersPanel = False
                '   AddHandler printTool.PrintingSystem.StartPrint, New DevExpress.XtraPrinting.PrintDocumentEventHandler(AddressOf PrintingSystem_StartPrint)

                printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default)
            End Using
        End If
    End Sub

    Private Sub OptEmpcode_CheckedChanged(sender As System.Object, e As System.EventArgs)
        'txtCode.Text = ""
        'txtFname.Text = ""
        'txtCode.Focus()
    End Sub

    Private Sub OptEmpName_CheckedChanged(sender As System.Object, e As System.EventArgs)
        'txtFname.Text = ""
        'txtCode.Text = ""
        'txtFname.Focus()
    End Sub

    Private Sub cboCompany_Click(sender As Object, e As System.EventArgs)
        'cmdRefresh.Enabled = False
        'cboCompany.Enabled = False

        'Call LoadData()

        'cmdRefresh.Enabled = True
        'cboCompany.Enabled = True
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
        '  Call LoadEmpGroup()
        Call LoadBank()
    End Sub

    Private Sub LoadBank()
        '        On Error GoTo Err
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim Db As New db

        Strsql = "Select BankId,BankName From Bank" &
                        " Order By BankId"

        Db.ExecuteCommand(Conn, dcmd, Strsql)
        Da.SelectCommand = dcmd
        Da.Fill(Ds, "data")



        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                ' cboBank.Items.Clear()
            Else
                '  cboBank.Items.Clear()
                '  cboBank.Items.Add("")
                For Each dr As DataRow In .Rows
                    '    cboBank.Items.Add(dr("BankName"))
                Next

            End If
        End With
    End Sub

    Private Sub LoadDefault()
        'cboOt.SelectedIndex = 0
        'txtStatus.SelectedIndex = 0
        'cboSoldierStatus.SelectedIndex = 0
        'cboSex.SelectedIndex = 0
    End Sub

    Private Sub txtCode_D_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            '   Call LoadData_Detail(e, System.EventArgs.Empty)
        End If
    End Sub


    Private Sub LoadVendor()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        strSQL = "select row_number() over(order by VendorId) as row,g.*,d.division,s.section_name,isnull(p.process,'') as process " &
                " From vendor_group g " &
                    " left join division d " &
                        " On g.divisionid = d.divisionid " &
                    " left join section s " &
                        " on g.sectionid = s.sectionid" &
                    " left join process_status p" &
                        " on g.processid = p.processid" &
                " Order by VendorId"

        '   
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")


        GcEmp.DataSource = Ds
        GcEmp.DataMember = "data"


    End Sub

    Private Sub LoadInvoice()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        strSQL = "select product_buy.bookno," &
                        " product_buy.idno," &
                        " product_buy.invoicedate," &
                        " duedate As duedate," &
                        " dbo.f_due_date_str(DATEADD(day,15,product_buy.invoicedate)) as duedate_str," &
                        " product_buy.productid, " &
                        " product.productname as product_name," &
                        " product_buy.qty, product_buy.price, " &
                        " product_buy.qty*product_buy.price as total," &
                        " (product_buy.qty * round((product_buy.price * 0.07), 2)) As vat, " &
                        " (product_buy.qty*product_buy.price) + " &
                        " (product_buy.qty * round((product_buy.price * 0.07), 2)) As endtotal, " &
                        " dbo.fThaibaht_Thainumber((product_buy.qty*product_buy.price) + " &
                        " (product_buy.qty * round((product_buy.price * 0.07), 2))) as endTotal_Thaibath," &
                        " product.unit," &
                        " vendor_group.vendor_name, " &
                        " vendor_group.juristic_person_registration_no," &
                        " vendor_group.address1, " &
                        " vendor_group.address2," &
                        " vendor_group.zipcode, " &
                        " vendor_group.contract_no," &
                        " vendor_group.VendorId" &
                " from ((dbo.product_buy product_buy" &
                    " inner Join dbo.vendor_group vendor_group" &
                        " on (vendor_group.vendorgroupid = product_buy.vendorgroupid))" &
                    " inner Join dbo.product product" &
                        " on (product.productid = product_buy.productid))" &
                " order by product_buy.invoicedate desc,product_buy.bookno desc,product_buy.idno desc"
        '   
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")


        gcInvoice.DataSource = Ds
        gcInvoice.DataMember = "data"

    End Sub

    Private Sub LoadProcess()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        strSQL = "select * from process_status"

        '   
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")


        cboProcessAll.Properties.DataSource = Ds.Tables("data")
        cboProcessAll.Properties.DisplayMember = "process"
        cboProcessAll.Properties.ValueMember = "processid"
    End Sub

    Private Sub LoadDivision()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        strSQL = "select * from division"

        '   
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")


        cboDivision.Properties.DataSource = Ds.Tables("data")
        cboDivision.Properties.DisplayMember = "division"
        cboDivision.Properties.ValueMember = "divisionid"

        cboDivision.EditValue = 0
    End Sub

    Private Sub LoadSection()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        strSQL = "select * from section"

        '   
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")


        cboSection.Properties.DataSource = Ds.Tables("data")
        cboSection.Properties.DisplayMember = "section_name"
        cboSection.Properties.ValueMember = "sectionid"

        cboSection.EditValue = 0
    End Sub

    Private Sub LoadProcessLog()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        strSQL = "select ROW_NUMBER() over(order by t.transaction_date desc) as row," &
                    " p.process,t.transaction_date,v.VendorId,v.vendor_name" &
                " from status_transaction t" &
                    " inner Join process_status p" &
                        " on t.processid = p.processid" &
                    " inner Join vendor_group v" &
                        " on t.vendorgroupid = v.vendorgroupid" &
                " order by t.transaction_date desc"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")


        gcProcessLog.DataSource = Ds
        gcProcessLog.DataMember = "data"
    End Sub


    Public Sub LoadEmp_byCode(id As Integer)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""
        Dim dcmd As New SqlCommand
        Dim db As New db

        Strsql = "select v.*,isnull(p.process,'') as process" &
                " from vendor_group v" &
                    " left join process_status p " &
                        " on v.processid = p.processid " &
                " where v.vendorgroupid = " & id

        db.ExecuteCommand(Conn, dcmd, Strsql)
        Da.SelectCommand = dcmd
        Da.Fill(Ds, "data")


        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Call EnaCmd(True, False, False)
                Exit Sub
            Else
                txtVendorId.Text = .Rows(0).Item("vendorid")
                txtAllVendorId.Text = .Rows(0).Item("allvendorid")
                txtVendorName.Text = .Rows(0).Item("vendor_name")
                txtAddress1.Text = .Rows(0).Item("address1")
                txtAddress2.Text = .Rows(0).Item("address2")
                txtzipcode.Text = .Rows(0).Item("zipcode")
                txttel.Text = .Rows(0).Item("tel")
                txtEmail.Text = .Rows(0).Item("email")
                cboDivision.EditValue = .Rows(0).Item("divisionid")
                cboSection.EditValue = .Rows(0).Item("sectionid")

                txtlic_StartDate.EditValue = .Rows(0).Item("lic_start_date")
                txtlic_ExpireDate.EditValue = .Rows(0).Item("lic_expire_date")
                txtLicence.Text = .Rows(0).Item("account")
                txtLicenceKey.Text = .Rows(0).Item("licenceKey")

                txtContract_no.Text = .Rows(0).Item("contract_no")
                txtContract_Date.EditValue = .Rows(0).Item("contract_date")
                txtContract_at.Text = .Rows(0).Item("contract_at")
                txtJuristic_Person_Registration_No.Text = .Rows(0).Item("juristic_person_registration_no")

                txtSign_Contract_Name1.Text = .Rows(0).Item("sign_contract_name")
                txtSign_Contract_Position1.Text = .Rows(0).Item("sign_contract_position")
                txtSign_Contract_Tel1.Text = .Rows(0).Item("sign_contract_tel")

                txtSign_Contract_Name2.Text = .Rows(0).Item("sign_contract_name2")
                txtSign_Contract_Position2.Text = .Rows(0).Item("sign_contract_position2")
                txtSign_Contract_Tel2.Text = .Rows(0).Item("sign_contract_tel2")

                txtContract_Name.Text = .Rows(0).Item("contract_name")
                txtContract_Position.Text = .Rows(0).Item("contract_position")
                txtContract_Tel.Text = .Rows(0).Item("contract_tel")
                txtContract_EMail.Text = .Rows(0).Item("contract_email")
                txtRemark.Text = .Rows(0).Item("remark")
            End If


        End With
        Call EnaCmd(False, True, True)
    End Sub


    Private Sub update_status(vendorgroupid As Integer, processid As Integer)
        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList
        Dim workstatus As String = ""

        '' ข้อมูลที่หัว ====================================================================

        Data.Clear() : strType = ""
        Data.Add(vendorgroupid) : strType &= "I"
        Data.Add(processid) : strType &= "I"

        strSQL = "exec sp_update_status @P1,@P2"
        Try
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Me.Text)
            Exit Sub
        End Try
    End Sub

    Private Sub update_lic_startdate(vendorgroupid As Integer, d As DateTime)
        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList
        Dim workstatus As String = ""

        '' ข้อมูลที่หัว ====================================================================

        Data.Clear() : strType = ""
        Data.Add(vendorgroupid) : strType &= "I"
        Data.Add(Format(d, "yyyy/MM/dd")) : strType &= "T"

        strSQL = "update vendor_group set lic_start_date = @P2 where vendorgroupid = @P1"

        Try
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Me.Text)
            Exit Sub
        End Try
    End Sub

    Private Sub update_lic_expiredate(vendorgroupid As Integer, d As DateTime)
        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList
        Dim workstatus As String = ""

        '' ข้อมูลที่หัว ====================================================================

        Data.Clear() : strType = ""
        Data.Add(vendorgroupid) : strType &= "I"
        Data.Add(Format(d, "yyyy/MM/dd")) : strType &= "T"

        strSQL = "update vendor_group set lic_expire_date = @P2 where vendorgroupid = @P1"

        Try
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Me.Text)
            Exit Sub
        End Try
    End Sub

    Private Sub update_lic_expiredate_1y(vendorgroupid As Integer)
        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList
        Dim workstatus As String = ""

        '' ข้อมูลที่หัว ====================================================================

        Data.Clear() : strType = ""
        Data.Add(vendorgroupid) : strType &= "I"

        strSQL = "update vendor_group set lic_expire_date = dateadd(year,1,lic_start_date) where vendorgroupid = @P1"

        Try
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Me.Text)
            Exit Sub
        End Try
    End Sub

    Private Sub update_contract_at(vendorgroupid As Integer, contract_at As String)
        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList
        Dim workstatus As String = ""

        '' ข้อมูลที่หัว ====================================================================

        Data.Clear() : strType = ""
        Data.Add(vendorgroupid) : strType &= "I"
        Data.Add(contract_at) : strType &= "T"

        strSQL = "update vendor_group set contract_at = @P2 where vendorgroupid = @P1"

        Try
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Me.Text)
            Exit Sub
        End Try
    End Sub

    Private Sub update_licence_key(vendorgroupid As Integer, licencekey As String)
        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList
        Dim workstatus As String = ""

        '' ข้อมูลที่หัว ====================================================================

        Data.Clear() : strType = ""
        Data.Add(vendorgroupid) : strType &= "I"
        Data.Add(licencekey) : strType &= "T"

        strSQL = "update vendor_group set licenceKey = @P2 where vendorgroupid = @P1"

        Try
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Me.Text)
            Exit Sub
        End Try
    End Sub

    Private Sub export_csv(filename As String,
                                        vendorid As String,
                                        address1 As String,
                                        address2 As String,
                                        zipcode As String,
                                        tax As String,
                                        licenceKey As String,
                                        tel As String,
                                        email As String,
                                        division As String,
                                        section As String,
                                        contract_name As String,
                                        contract_tel As String,
                                        contract_email As String,
                                        AllVendorId As String)

        Dim data As String = vendorid & "|" &
                                address1 & "|" &
                                        address2 & "|" &
                                        zipcode & "|" &
                                        tax & "|" &
                                        tel & "|" &
                                        email & "|" &
                                        licenceKey & "|" &
                                        division & "|" &
                                        section & "|" &
                                        contract_name & "|" &
                                        contract_tel & "|" &
                                        contract_email & "|" &
                                        AllVendorId

        FileIO.FileIO.WriteToFile(filename, data & vbNewLine)
    End Sub

    Private Sub txtCode_D_LostFocus(sender As Object, e As EventArgs) Handles txtVendorId.LostFocus, txtAllVendorId.LostFocus
        'Call LoadEmp_byCode(txtVendorCode.Text.Trim)
    End Sub

    Private Sub GcEmp_Click(sender As Object, e As EventArgs) Handles GcEmp.Click

    End Sub

    Private Sub GvEmp_DoubleClick(sender As Object, e As EventArgs) Handles GvEmp.DoubleClick
        Try
            Dim gv As GridView = CType(sender, GridView)

            '   If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "Code")) = True Then Exit Sub

            Dim vendorgroupid As Integer = gv.GetRowCellValue(gv.FocusedRowHandle, "vendorgroupid")

            id = vendorgroupid

            LoadEmp_byCode(vendorgroupid)


            Call EnaCmd(False, True, True)
            XtraTabControl1.SelectedTabPageIndex = 1
            txtVendorName.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGenKey_Click(sender As Object, e As EventArgs) Handles btnGenKey.Click
        If txtVendorId.Text.Trim = "" Then
            MsgBox("กรุณาป้อน Vendor Code ด้วย", MsgBoxStyle.Information, Me.Text)
            txtVendorId.Focus()
            Exit Sub
        End If

        txtLicenceKey.Text = LicenceKeyGen(txtVendorId.Text.Trim, txtlic_StartDate.EditValue, txtlic_ExpireDate.EditValue, txtLicence.Text)
    End Sub

    Private Function LicenceKeyGen(vendorid As String, lic_date_st As DateTime, lic_date_sp As DateTime, licenceAccount As Integer) As String
        Dim vendorcode As String = vendorid
        Dim datest As String = Format(lic_date_st, "yyyy-MM-dd")
        Dim dateexpire As String = Format(lic_date_sp, "yyyy-MM-dd")
        Dim licence As Integer = licenceAccount

        Dim keydata As String = vendorcode & "," & datest & "," & dateexpire & "," & licence

        Dim keygen As String = dbMgr.getEncryptStr_Lic(keydata)

        Return keygen
        'txtDecript.Text = dbMgr.getDecryptStr_Lic(keygen)
    End Function

    Private Function LicenceKeyGen_b(data As String) As String


        Dim keygen As String = dbMgr.getEncryptStr_Lic(data)

        Return keygen
        'txtDecript.Text = dbMgr.getDecryptStr_Lic(keygen)
    End Function

    Private Sub btnCopyLicence_Click(sender As Object, e As EventArgs) Handles btnCopyLicence.Click
        If txtLicenceKey.Text <> "" Then
            Clipboard.SetText(txtLicenceKey.Text)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btngen_Click(sender As Object, e As EventArgs)
        'txten.Text = dbMgr.getEncryptStr_Lic(txtdata.Text)
    End Sub

    Private Sub PanelControl2_Paint(sender As Object, e As PaintEventArgs) Handles PanelControl2.Paint

    End Sub

    Private Sub btnPrintContract_Click(sender As Object, e As EventArgs) Handles btnPrintContract.Click
        Call PrintReportAll()
        MsgBox("พิมพ์สัญญาเรียบร้อยแล้ว", MsgBoxStyle.Information, Me.Text)
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim frm As New frmImportExcel
        frm.StartPosition = FormStartPosition.CenterParent
        frm.ShowDialog()
    End Sub

    Private Sub btnRefreshInvoice_Click(sender As Object, e As EventArgs) Handles btnRefreshInvoice.Click
        Call LoadInvoice()
    End Sub

    Private Sub btnPrintInvoice_Click(sender As Object, e As EventArgs) Handles btnPrintInvoice.Click
        Call PrintReportAll_Invoice()
        MsgBox("พิมพ์ใบแจ้งหนี้เรียบร้อยแล้ว", MsgBoxStyle.Information, Me.Text)
    End Sub

    Private Sub btnEditProcess_Click(sender As Object, e As EventArgs) Handles btnEditProcess.Click
        If MsgBox("คุณต้องแก้ไขข้อมูล สถานะ หรือไม่", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = vbNo Then Exit Sub

        If cboProcessAll.EditValue Is Nothing Then Exit Sub
        Call Update_Statusl_All(cboProcessAll.EditValue)
        MsgBox("เช็คสถานะการทำงานเรียบร้อยแล้ว", MsgBoxStyle.Information, Me.Text)
        Call LoadVendor()
        Call LoadProcessLog()
    End Sub

    Private Sub btnRefreshLog_Click(sender As Object, e As EventArgs) Handles btnRefreshLog.Click
        Call LoadProcessLog()
    End Sub

    Private Sub btnEdit_lic_Startdate_Click(sender As Object, e As EventArgs) Handles btnEdit_lic_Startdate.Click
        If MsgBox("คุณต้องแก้ไขข้อมูล วันที่ทำสัญญา หรือไม่", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = vbNo Then Exit Sub

        Call Update_Licence_StartDate_All(txtlic_startdate_all.EditValue)
        MsgBox("แก้ไขเรียบร้อยแล้ว", MsgBoxStyle.Information, Me.Text)
        Call LoadVendor()
    End Sub

    Private Sub btnEdit_lic_Expiredate_Click(sender As Object, e As EventArgs) Handles btnEdit_lic_Expiredate.Click
        If MsgBox("คุณต้องแก้ไขข้อมูล วันหมดอายุ หรือไม่", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = vbNo Then Exit Sub
        Call Update_Licence_ExpireDate_All(txtlic_expiredate_all.EditValue)
        MsgBox("แก้ไขเรียบร้อยแล้ว", MsgBoxStyle.Information, Me.Text)
        Call LoadVendor()
    End Sub

    Private Sub btnEdit_lic_Expiredate_1Y_Click(sender As Object, e As EventArgs) Handles btnEdit_lic_Expiredate_1Y.Click
        If MsgBox("คุณต้องแก้ไขข้อมูล วันหมดอายุ(คำนวณ 1 ปี) หรือไม่", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = vbNo Then Exit Sub
        Call Update_Licence_ExpireDate_1Y_All()
        MsgBox("แก้ไขเรียบร้อยแล้ว", MsgBoxStyle.Information, Me.Text)
        Call LoadVendor()
    End Sub

    Private Sub btnEdit_contract_at_Click(sender As Object, e As EventArgs) Handles btnEdit_contract_at.Click
        If MsgBox("คุณต้องแก้ไขข้อมูล ทำสัญญาที่.. หรือไม่", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = vbNo Then Exit Sub
        Call Update_Contract_at_All(txtcontract_at_all.Text.Trim)
        MsgBox("แก้ไขเรียบร้อยแล้ว", MsgBoxStyle.Information, Me.Text)
        Call LoadVendor()
    End Sub

    Private Sub btnAutoGenLicenceKey_Click(sender As Object, e As EventArgs) Handles btnAutoGenLicenceKey.Click
        If MsgBox("คุณต้อง Gen. Licence Key หรือไม่", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = vbNo Then Exit Sub
        Call Update_LicenceKey_All()
        MsgBox("แก้ไขเรียบร้อยแล้ว", MsgBoxStyle.Information, Me.Text)
        Call LoadVendor()
    End Sub

    Private Sub btnExportLicence_Click(sender As Object, e As EventArgs) Handles btnExportLicence.Click
        If MsgBox("คุณต้อง Export CSV หรือไม่", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = vbNo Then Exit Sub

        Dim fileName As String = ""

        With SaveFileDialog1
            .Filter = "CSV File|*.csv"
            If .ShowDialog() = DialogResult.No Then Exit Sub
            fileName = .FileName
        End With

        Call Export_Vendor_to_CSV_all(fileName)

        MsgBox("แก้ไขเรียบร้อยแล้ว", MsgBoxStyle.Information, Me.Text)
        Call LoadVendor()
    End Sub

    Private Sub btnSave_Invoice_Click(sender As Object, e As EventArgs) Handles btnSave_Invoice.Click
        If txtBookNo.Text.Trim = "" Or txtIdno.Text.Trim = "" Then
            MsgBox("กรุณาเลือกรายการที่ต้องการแก้ไข", MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        If IsNumeric(txtSet.Text) = False Then txtSet.Text = "0"

        If CInt(txtSet.Text) <= 0 Then
            MsgBox("กรุณาป้อนจำนวนด้วย", MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList


        '' ข้อมูลที่หัว ====================================================================

        Data.Clear() : strType = ""
        Data.Add(txtBookNo.Text) : strType &= "T"
        Data.Add(txtIdno.Text) : strType &= "T"
        Data.Add(txtSet.Text) : strType &= "I"
        Data.Add(Format(txtDueDate.EditValue, "yyyy/MM/dd")) : strType &= "T"

        strSQL = "update product_buy set qty = @P3,duedate = @P4" &
                    " where bookno = @P1 and idno = @P2"
        Try
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        Call LoadInvoice()
        Call clear_invocie_edit()
    End Sub

    Private Sub clear_invocie_edit()
        txtBookNo.Text = ""
        txtIdno.Text = ""
        txtSet.Text = 1
        txtvendor_name_invoice.Text = ""
    End Sub

    Private Sub gvInvoice_DoubleClick(sender As Object, e As EventArgs) Handles gvInvoice.DoubleClick
        Try
            Dim gv As GridView = CType(sender, GridView)

            If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "bookno")) = True Then Exit Sub

            Dim bookno As String = gv.GetRowCellValue(gv.FocusedRowHandle, "bookno")
            Dim idno As String = gv.GetRowCellValue(gv.FocusedRowHandle, "idno")
            Dim vendor_name As String = gv.GetRowCellValue(gv.FocusedRowHandle, "vendor_name")
            Dim qty As Integer = gv.GetRowCellValue(gv.FocusedRowHandle, "qty")
            Dim duedate As DateTime = gv.GetRowCellValue(gv.FocusedRowHandle, "duedate")

            txtBookNo.Text = bookno
            txtIdno.Text = idno
            txtSet.Text = qty
            txtDueDate.EditValue = duedate
            txtvendor_name_invoice.Text = vendor_name
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        TextEdit2.Text = LicenceKeyGen_b(TextEdit1.Text)
    End Sub
End Class

