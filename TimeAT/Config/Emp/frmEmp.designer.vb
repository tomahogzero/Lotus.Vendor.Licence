<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmp
    Inherits frmBasicPage2

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmp))
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PG1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.cboCompany = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cmdRefresh = New DevComponents.DotNetBar.ButtonX()
        Me.optCompany = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.optName = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.optDept = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.optCode = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX129 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX125 = New DevComponents.DotNetBar.LabelX()
        Me.cmdSearch = New DevComponents.DotNetBar.ButtonX()
        Me.txtFname = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.OptEmpName = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.OptEmpcode = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.LstData = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.colNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colEmpId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColCardId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDepartmentId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColStartWork = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColExp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColCompany = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColWorkingPlace = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColUpdate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.TabControl2 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel()
        Me.txtDateExpire = New System.Windows.Forms.MaskedTextBox()
        Me.txtBirth = New System.Windows.Forms.MaskedTextBox()
        Me.txtDatePro = New System.Windows.Forms.MaskedTextBox()
        Me.txtTermiDate = New System.Windows.Forms.MaskedTextBox()
        Me.txtDateIn = New System.Windows.Forms.MaskedTextBox()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.GroupPanel15 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.chkContractor = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.OptDay = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.OptMonth = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.txtSalary = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX39 = New DevComponents.DotNetBar.LabelX()
        Me.txtBonus = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.optBank = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.optCash = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cboBank = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboBroker = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmbCompanyName = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtIdCard = New System.Windows.Forms.MaskedTextBox()
        Me.txtTypeBank = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtBankId = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSocTax = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtMarryWorkCom = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtMarryName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtTaxId = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cboWeek = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboEmpGroup = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtStatus = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboMateSpit = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.ComboItem10 = New DevComponents.Editors.ComboItem()
        Me.cboSex = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.txtAge = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtWorkAge = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtEducation = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAddress = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPlaceIdCard = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX42 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX37 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX32 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX29 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX28 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX33 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX38 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX45 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX41 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX44 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX43 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX40 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX36 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX35 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX34 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX26 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX31 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX25 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX30 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX27 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX24 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX23 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX22 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX()
        Me.lblTermiDate = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.TabItem3 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel11 = New DevComponents.DotNetBar.TabControlPanel()
        Me.lstTraining = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.colTraningNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTraningName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTraningDateST = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTraningDateSP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTraningDay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTraningRemark = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnTrain_Clear = New DevComponents.DotNetBar.ButtonX()
        Me.btnTrain_Delete = New DevComponents.DotNetBar.ButtonX()
        Me.btnTrain_Edit = New DevComponents.DotNetBar.ButtonX()
        Me.btnTrain_Add = New DevComponents.DotNetBar.ButtonX()
        Me.txtTrainingDateSP = New System.Windows.Forms.MaskedTextBox()
        Me.txtTrainingDateST = New System.Windows.Forms.MaskedTextBox()
        Me.txtTrainingRemark = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtTrainingDay = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtTraining_RowId = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtTrainigName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX128 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX123 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX127 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX124 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX126 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX122 = New DevComponents.DotNetBar.LabelX()
        Me.TabItem10 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel8 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GroupPanel10 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX115 = New DevComponents.DotNetBar.LabelX()
        Me.cboPrivilegeYear = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.GroupPanel9 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.lstPrivilege = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColTypeWage = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDayCount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDayUse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColTotalDay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabItem8 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel()
        Me.chkCalSocTax = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupPanel5 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtSonEdu = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX59 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX62 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX60 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX61 = New DevComponents.DotNetBar.LabelX()
        Me.txtSonNonEdu = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cboDonateMStart = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem30 = New DevComponents.Editors.ComboItem()
        Me.ComboItem31 = New DevComponents.Editors.ComboItem()
        Me.ComboItem32 = New DevComponents.Editors.ComboItem()
        Me.ComboItem33 = New DevComponents.Editors.ComboItem()
        Me.ComboItem34 = New DevComponents.Editors.ComboItem()
        Me.ComboItem35 = New DevComponents.Editors.ComboItem()
        Me.ComboItem36 = New DevComponents.Editors.ComboItem()
        Me.cboLoanMStart = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem23 = New DevComponents.Editors.ComboItem()
        Me.ComboItem24 = New DevComponents.Editors.ComboItem()
        Me.ComboItem25 = New DevComponents.Editors.ComboItem()
        Me.ComboItem26 = New DevComponents.Editors.ComboItem()
        Me.ComboItem27 = New DevComponents.Editors.ComboItem()
        Me.ComboItem28 = New DevComponents.Editors.ComboItem()
        Me.ComboItem29 = New DevComponents.Editors.ComboItem()
        Me.cboPremiumMStart = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem16 = New DevComponents.Editors.ComboItem()
        Me.ComboItem17 = New DevComponents.Editors.ComboItem()
        Me.ComboItem18 = New DevComponents.Editors.ComboItem()
        Me.ComboItem19 = New DevComponents.Editors.ComboItem()
        Me.ComboItem20 = New DevComponents.Editors.ComboItem()
        Me.ComboItem21 = New DevComponents.Editors.ComboItem()
        Me.ComboItem22 = New DevComponents.Editors.ComboItem()
        Me.LabelX54 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX53 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX47 = New DevComponents.DotNetBar.LabelX()
        Me.txtSonAge5 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSonAge4 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX72 = New DevComponents.DotNetBar.LabelX()
        Me.txtSonAge3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX71 = New DevComponents.DotNetBar.LabelX()
        Me.txtSonAge2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX70 = New DevComponents.DotNetBar.LabelX()
        Me.txtSonAge1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX69 = New DevComponents.DotNetBar.LabelX()
        Me.txtSonName5 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX68 = New DevComponents.DotNetBar.LabelX()
        Me.txtSonName4 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX67 = New DevComponents.DotNetBar.LabelX()
        Me.txtSonName3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX66 = New DevComponents.DotNetBar.LabelX()
        Me.txtSonName2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX65 = New DevComponents.DotNetBar.LabelX()
        Me.txtSonName1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX64 = New DevComponents.DotNetBar.LabelX()
        Me.txtCapitalSumary = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX63 = New DevComponents.DotNetBar.LabelX()
        Me.txtDonate = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX52 = New DevComponents.DotNetBar.LabelX()
        Me.txtLoan = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX51 = New DevComponents.DotNetBar.LabelX()
        Me.txtA_ENT = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPremium = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX50 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX49 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX58 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX57 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX56 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX55 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX48 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX46 = New DevComponents.DotNetBar.LabelX()
        Me.TabItem4 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel5 = New DevComponents.DotNetBar.TabControlPanel()
        Me.txtSoldierDate = New System.Windows.Forms.MaskedTextBox()
        Me.txtDriveDate = New System.Windows.Forms.MaskedTextBox()
        Me.txtforeignDate = New System.Windows.Forms.MaskedTextBox()
        Me.chkPro_Fund = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkMatherCalTaxMate = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkFatherCalTaxMate = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkMatherCalTax = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkFatherCalTax = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.txtMatherIdCardMate = New System.Windows.Forms.MaskedTextBox()
        Me.LabelX92 = New DevComponents.DotNetBar.LabelX()
        Me.txtFatherIdCardMate = New System.Windows.Forms.MaskedTextBox()
        Me.LabelX91 = New DevComponents.DotNetBar.LabelX()
        Me.txtMatherIdCard = New System.Windows.Forms.MaskedTextBox()
        Me.LabelX90 = New DevComponents.DotNetBar.LabelX()
        Me.txtFatherIdCard = New System.Windows.Forms.MaskedTextBox()
        Me.LabelX89 = New DevComponents.DotNetBar.LabelX()
        Me.cboSoldierStatus = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem37 = New DevComponents.Editors.ComboItem()
        Me.ComboItem38 = New DevComponents.Editors.ComboItem()
        Me.LabelX82 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX97 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX81 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX80 = New DevComponents.DotNetBar.LabelX()
        Me.txtReligion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX75 = New DevComponents.DotNetBar.LabelX()
        Me.txtRace = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNationalily = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX74 = New DevComponents.DotNetBar.LabelX()
        Me.txtMatherNameMate = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX88 = New DevComponents.DotNetBar.LabelX()
        Me.txtRemark = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX96 = New DevComponents.DotNetBar.LabelX()
        Me.txtEduSpacial = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX95 = New DevComponents.DotNetBar.LabelX()
        Me.txtErContract = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX87 = New DevComponents.DotNetBar.LabelX()
        Me.txtEr_Tel = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX94 = New DevComponents.DotNetBar.LabelX()
        Me.txtGuanWork = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX93 = New DevComponents.DotNetBar.LabelX()
        Me.txtGuaranteeName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX86 = New DevComponents.DotNetBar.LabelX()
        Me.txtFatherNameMate = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX85 = New DevComponents.DotNetBar.LabelX()
        Me.txtMatherName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX84 = New DevComponents.DotNetBar.LabelX()
        Me.txtFatherName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX83 = New DevComponents.DotNetBar.LabelX()
        Me.txtDrivePlace = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX79 = New DevComponents.DotNetBar.LabelX()
        Me.txtDriveNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX78 = New DevComponents.DotNetBar.LabelX()
        Me.txtforeignNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX77 = New DevComponents.DotNetBar.LabelX()
        Me.txtTelContract = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX76 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX73 = New DevComponents.DotNetBar.LabelX()
        Me.TabItem5 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel6 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GroupPanel7 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX113 = New DevComponents.DotNetBar.LabelX()
        Me.lstAdd = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdDelTax = New DevComponents.DotNetBar.ButtonX()
        Me.cmdAddTax = New DevComponents.DotNetBar.ButtonX()
        Me.txtMonth_Year = New System.Windows.Forms.MaskedTextBox()
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX106 = New DevComponents.DotNetBar.LabelX()
        Me.txteRemark = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX111 = New DevComponents.DotNetBar.LabelX()
        Me.txteSocTax = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX110 = New DevComponents.DotNetBar.LabelX()
        Me.txtGrossSoc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX109 = New DevComponents.DotNetBar.LabelX()
        Me.txtTax = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX108 = New DevComponents.DotNetBar.LabelX()
        Me.txtGrossTax = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX107 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel6 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX112 = New DevComponents.DotNetBar.LabelX()
        Me.lstMonthly = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.ColNo_ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColMonth = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVatCal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColVat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColPricePKS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColPKS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboYear = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX98 = New DevComponents.DotNetBar.LabelX()
        Me.lblAccuPFAll = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX105 = New DevComponents.DotNetBar.LabelX()
        Me.lblAccuPF = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX104 = New DevComponents.DotNetBar.LabelX()
        Me.lblAccSocTax = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX103 = New DevComponents.DotNetBar.LabelX()
        Me.lblAccGrossSoc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX102 = New DevComponents.DotNetBar.LabelX()
        Me.lblAccTax = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX101 = New DevComponents.DotNetBar.LabelX()
        Me.lblAccBonus = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX100 = New DevComponents.DotNetBar.LabelX()
        Me.lblAccGrossTax = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX99 = New DevComponents.DotNetBar.LabelX()
        Me.TabItem6 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel7 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GroupPanel13 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cmdPP_Refresh = New DevComponents.DotNetBar.ButtonX()
        Me.cmdPP_Delete = New DevComponents.DotNetBar.ButtonX()
        Me.txtpp_Experieddate = New System.Windows.Forms.MaskedTextBox()
        Me.cmdPP_Edit = New DevComponents.DotNetBar.ButtonX()
        Me.lstPassport = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColPassportNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdPP_Add = New DevComponents.DotNetBar.ButtonX()
        Me.txtpp_Issueddate = New System.Windows.Forms.MaskedTextBox()
        Me.GroupPanel14 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.optPP_Multiple = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.optPP_NoneB = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.lblPassportId = New DevComponents.DotNetBar.LabelX()
        Me.LabelX118 = New DevComponents.DotNetBar.LabelX()
        Me.txtpp_NO = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX120 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX119 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel11 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cmdVisa_Refresh = New DevComponents.DotNetBar.ButtonX()
        Me.cmdVisa_Delete = New DevComponents.DotNetBar.ButtonX()
        Me.cmdVisa_Edit = New DevComponents.DotNetBar.ButtonX()
        Me.cmdVisa_Add = New DevComponents.DotNetBar.ButtonX()
        Me.txtVisa_ExperiedDate = New System.Windows.Forms.MaskedTextBox()
        Me.txtVisa_IssuedDate = New System.Windows.Forms.MaskedTextBox()
        Me.lstVisa = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CalId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColIssuedDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColExperiedDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CalTypeOfVisa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColTypeMultiple = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupPanel12 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.optVisa_Multiple = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.optVisa_NoneB = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.lblVisa_Id = New DevComponents.DotNetBar.LabelX()
        Me.LabelX116 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX117 = New DevComponents.DotNetBar.LabelX()
        Me.TabItem7 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel9 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GroupPanel8 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.chkCalOtDeduc = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkCalLate = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cboOt = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem39 = New DevComponents.Editors.ComboItem()
        Me.ComboItem40 = New DevComponents.Editors.ComboItem()
        Me.LabelX114 = New DevComponents.DotNetBar.LabelX()
        Me.TabItem9 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel10 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GroupPanel16 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cmdCancel = New DevComponents.DotNetBar.ButtonX()
        Me.cmdConfirm = New DevComponents.DotNetBar.ButtonX()
        Me.txtTermiDate_Move = New System.Windows.Forms.MaskedTextBox()
        Me.LabelX121 = New DevComponents.DotNetBar.LabelX()
        Me.TabMoveToEmpOut = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCurRecord = New DevComponents.DotNetBar.LabelX()
        Me.cmdNext = New DevComponents.DotNetBar.ButtonX()
        Me.cmdPrevious = New DevComponents.DotNetBar.ButtonX()
        Me.cmdDeptBrowse = New DevComponents.DotNetBar.ButtonX()
        Me.btnSection = New DevComponents.DotNetBar.ButtonX()
        Me.cmdDivBrowse = New DevComponents.DotNetBar.ButtonX()
        Me.cboTitleEng = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboTitle = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtAccountCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtLname = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtLnameEng = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtWorkingPlace = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPosition = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSecId_Det = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtDepartment = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtDeptId = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSection_Det = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtDivision = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtDivID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNickName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtFnameEng = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCode_D = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtBarcode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtFname_Det = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX()
        Me.lblWorkStatus = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabControlPanel3.SuspendLayout()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel15.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        Me.TabControlPanel11.SuspendLayout()
        Me.TabControlPanel8.SuspendLayout()
        Me.GroupPanel10.SuspendLayout()
        Me.GroupPanel9.SuspendLayout()
        Me.TabControlPanel4.SuspendLayout()
        Me.GroupPanel5.SuspendLayout()
        Me.TabControlPanel5.SuspendLayout()
        Me.TabControlPanel6.SuspendLayout()
        Me.GroupPanel7.SuspendLayout()
        Me.GroupPanel6.SuspendLayout()
        Me.TabControlPanel7.SuspendLayout()
        Me.GroupPanel13.SuspendLayout()
        Me.GroupPanel14.SuspendLayout()
        Me.GroupPanel11.SuspendLayout()
        Me.GroupPanel12.SuspendLayout()
        Me.TabControlPanel9.SuspendLayout()
        Me.GroupPanel8.SuspendLayout()
        Me.TabControlPanel10.SuspendLayout()
        Me.GroupPanel16.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Tabs.Add(Me.TabItem2)
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.GroupPanel3)
        Me.TabControlPanel1.Controls.Add(Me.GroupPanel2)
        Me.TabControlPanel1.Controls.Add(Me.GroupPanel1)
        Me.TabControlPanel1.Controls.Add(Me.LstData)
        resources.ApplyResources(Me.TabControlPanel1, "TabControlPanel1")
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'GroupPanel3
        '
        resources.ApplyResources(Me.GroupPanel3, "GroupPanel3")
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.PG1)
        Me.GroupPanel3.Controls.Add(Me.LabelX3)
        Me.GroupPanel3.Controls.Add(Me.cboCompany)
        Me.GroupPanel3.Name = "GroupPanel3"
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.Class = ""
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.Class = ""
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.Class = ""
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'PG1
        '
        resources.ApplyResources(Me.PG1, "PG1")
        '
        '
        '
        Me.PG1.BackgroundStyle.Class = ""
        Me.PG1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PG1.Name = "PG1"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX3, "LabelX3")
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cboCompany
        '
        Me.cboCompany.DisplayMember = "Text"
        Me.cboCompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompany.FormattingEnabled = True
        resources.ApplyResources(Me.cboCompany, "cboCompany")
        Me.cboCompany.Name = "cboCompany"
        Me.cboCompany.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'GroupPanel2
        '
        resources.ApplyResources(Me.GroupPanel2, "GroupPanel2")
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.cmdRefresh)
        Me.GroupPanel2.Controls.Add(Me.optCompany)
        Me.GroupPanel2.Controls.Add(Me.optName)
        Me.GroupPanel2.Controls.Add(Me.optDept)
        Me.GroupPanel2.Controls.Add(Me.optCode)
        Me.GroupPanel2.Name = "GroupPanel2"
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.Class = ""
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.Class = ""
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.Class = ""
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'cmdRefresh
        '
        Me.cmdRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdRefresh.ImageFixedSize = New System.Drawing.Size(25, 25)
        resources.ApplyResources(Me.cmdRefresh, "cmdRefresh")
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'optCompany
        '
        Me.optCompany.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.optCompany.BackgroundStyle.Class = ""
        Me.optCompany.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.optCompany.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        resources.ApplyResources(Me.optCompany, "optCompany")
        Me.optCompany.Name = "optCompany"
        Me.optCompany.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'optName
        '
        Me.optName.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.optName.BackgroundStyle.Class = ""
        Me.optName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.optName.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        resources.ApplyResources(Me.optName, "optName")
        Me.optName.Name = "optName"
        Me.optName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'optDept
        '
        Me.optDept.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.optDept.BackgroundStyle.Class = ""
        Me.optDept.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.optDept.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        resources.ApplyResources(Me.optDept, "optDept")
        Me.optDept.Name = "optDept"
        Me.optDept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'optCode
        '
        Me.optCode.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.optCode.BackgroundStyle.Class = ""
        Me.optCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.optCode.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.optCode.Checked = True
        Me.optCode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optCode.CheckValue = "Y"
        resources.ApplyResources(Me.optCode, "optCode")
        Me.optCode.Name = "optCode"
        Me.optCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'GroupPanel1
        '
        resources.ApplyResources(Me.GroupPanel1, "GroupPanel1")
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LabelX129)
        Me.GroupPanel1.Controls.Add(Me.LabelX125)
        Me.GroupPanel1.Controls.Add(Me.cmdSearch)
        Me.GroupPanel1.Controls.Add(Me.txtFname)
        Me.GroupPanel1.Controls.Add(Me.txtCode)
        Me.GroupPanel1.Controls.Add(Me.OptEmpName)
        Me.GroupPanel1.Controls.Add(Me.OptEmpcode)
        Me.GroupPanel1.Name = "GroupPanel1"
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'LabelX129
        '
        Me.LabelX129.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX129.BackgroundStyle.Class = ""
        Me.LabelX129.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX129, "LabelX129")
        Me.LabelX129.Name = "LabelX129"
        Me.LabelX129.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX125
        '
        Me.LabelX125.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX125.BackgroundStyle.Class = ""
        Me.LabelX125.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX125, "LabelX125")
        Me.LabelX125.Name = "LabelX125"
        Me.LabelX125.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cmdSearch
        '
        Me.cmdSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdSearch.ImageFixedSize = New System.Drawing.Size(30, 30)
        resources.ApplyResources(Me.cmdSearch, "cmdSearch")
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'txtFname
        '
        '
        '
        '
        Me.txtFname.Border.Class = "TextBoxBorder"
        Me.txtFname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.txtFname, "txtFname")
        Me.txtFname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFname.Name = "txtFname"
        '
        'txtCode
        '
        '
        '
        '
        Me.txtCode.Border.Class = "TextBoxBorder"
        Me.txtCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.txtCode, "txtCode")
        Me.txtCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCode.Name = "txtCode"
        '
        'OptEmpName
        '
        Me.OptEmpName.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.OptEmpName.BackgroundStyle.Class = ""
        Me.OptEmpName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.OptEmpName.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        resources.ApplyResources(Me.OptEmpName, "OptEmpName")
        Me.OptEmpName.Name = "OptEmpName"
        Me.OptEmpName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'OptEmpcode
        '
        Me.OptEmpcode.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.OptEmpcode.BackgroundStyle.Class = ""
        Me.OptEmpcode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.OptEmpcode.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        resources.ApplyResources(Me.OptEmpcode, "OptEmpcode")
        Me.OptEmpcode.Name = "OptEmpcode"
        Me.OptEmpcode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'LstData
        '
        resources.ApplyResources(Me.LstData, "LstData")
        '
        '
        '
        Me.LstData.Border.Class = "ListViewBorder"
        Me.LstData.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LstData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNo, Me.colEmpId, Me.ColCardId, Me.colName, Me.ColDepartmentId, Me.ColStartWork, Me.ColExp, Me.ColCompany, Me.ColWorkingPlace, Me.ColUpdate})
        Me.LstData.FullRowSelect = True
        Me.LstData.GridLines = True
        Me.LstData.MultiSelect = False
        Me.LstData.Name = "LstData"
        Me.LstData.UseCompatibleStateImageBehavior = False
        Me.LstData.View = System.Windows.Forms.View.Details
        '
        'colNo
        '
        resources.ApplyResources(Me.colNo, "colNo")
        '
        'colEmpId
        '
        resources.ApplyResources(Me.colEmpId, "colEmpId")
        '
        'ColCardId
        '
        resources.ApplyResources(Me.ColCardId, "ColCardId")
        '
        'colName
        '
        resources.ApplyResources(Me.colName, "colName")
        '
        'ColDepartmentId
        '
        resources.ApplyResources(Me.ColDepartmentId, "ColDepartmentId")
        '
        'ColStartWork
        '
        resources.ApplyResources(Me.ColStartWork, "ColStartWork")
        '
        'ColExp
        '
        resources.ApplyResources(Me.ColExp, "ColExp")
        '
        'ColCompany
        '
        resources.ApplyResources(Me.ColCompany, "ColCompany")
        '
        'ColWorkingPlace
        '
        resources.ApplyResources(Me.ColWorkingPlace, "ColWorkingPlace")
        '
        'ColUpdate
        '
        resources.ApplyResources(Me.ColUpdate, "ColUpdate")
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        resources.ApplyResources(Me.TabItem1, "TabItem1")
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.TabControl2)
        Me.TabControlPanel2.Controls.Add(Me.GroupBox2)
        resources.ApplyResources(Me.TabControlPanel2, "TabControlPanel2")
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabItem = Me.TabItem2
        '
        'TabControl2
        '
        Me.TabControl2.CanReorderTabs = True
        Me.TabControl2.Controls.Add(Me.TabControlPanel3)
        Me.TabControl2.Controls.Add(Me.TabControlPanel11)
        Me.TabControl2.Controls.Add(Me.TabControlPanel8)
        Me.TabControl2.Controls.Add(Me.TabControlPanel4)
        Me.TabControl2.Controls.Add(Me.TabControlPanel5)
        Me.TabControl2.Controls.Add(Me.TabControlPanel6)
        Me.TabControl2.Controls.Add(Me.TabControlPanel7)
        Me.TabControl2.Controls.Add(Me.TabControlPanel9)
        Me.TabControl2.Controls.Add(Me.TabControlPanel10)
        resources.ApplyResources(Me.TabControl2, "TabControl2")
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedTabFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.SelectedTabIndex = 0
        Me.TabControl2.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
        Me.TabControl2.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl2.Tabs.Add(Me.TabItem3)
        Me.TabControl2.Tabs.Add(Me.TabItem4)
        Me.TabControl2.Tabs.Add(Me.TabItem5)
        Me.TabControl2.Tabs.Add(Me.TabItem6)
        Me.TabControl2.Tabs.Add(Me.TabItem7)
        Me.TabControl2.Tabs.Add(Me.TabItem9)
        Me.TabControl2.Tabs.Add(Me.TabItem8)
        Me.TabControl2.Tabs.Add(Me.TabMoveToEmpOut)
        Me.TabControl2.Tabs.Add(Me.TabItem10)
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.Controls.Add(Me.txtDateExpire)
        Me.TabControlPanel3.Controls.Add(Me.txtBirth)
        Me.TabControlPanel3.Controls.Add(Me.txtDatePro)
        Me.TabControlPanel3.Controls.Add(Me.txtTermiDate)
        Me.TabControlPanel3.Controls.Add(Me.txtDateIn)
        Me.TabControlPanel3.Controls.Add(Me.PicBox)
        Me.TabControlPanel3.Controls.Add(Me.GroupPanel15)
        Me.TabControlPanel3.Controls.Add(Me.GroupPanel4)
        Me.TabControlPanel3.Controls.Add(Me.cboBroker)
        Me.TabControlPanel3.Controls.Add(Me.cmbCompanyName)
        Me.TabControlPanel3.Controls.Add(Me.txtIdCard)
        Me.TabControlPanel3.Controls.Add(Me.txtTypeBank)
        Me.TabControlPanel3.Controls.Add(Me.txtBankId)
        Me.TabControlPanel3.Controls.Add(Me.txtSocTax)
        Me.TabControlPanel3.Controls.Add(Me.txtMarryWorkCom)
        Me.TabControlPanel3.Controls.Add(Me.txtMarryName)
        Me.TabControlPanel3.Controls.Add(Me.txtTaxId)
        Me.TabControlPanel3.Controls.Add(Me.cboWeek)
        Me.TabControlPanel3.Controls.Add(Me.cboEmpGroup)
        Me.TabControlPanel3.Controls.Add(Me.txtStatus)
        Me.TabControlPanel3.Controls.Add(Me.cboMateSpit)
        Me.TabControlPanel3.Controls.Add(Me.cboSex)
        Me.TabControlPanel3.Controls.Add(Me.txtAge)
        Me.TabControlPanel3.Controls.Add(Me.txtWorkAge)
        Me.TabControlPanel3.Controls.Add(Me.txtEducation)
        Me.TabControlPanel3.Controls.Add(Me.txtAddress)
        Me.TabControlPanel3.Controls.Add(Me.txtPlaceIdCard)
        Me.TabControlPanel3.Controls.Add(Me.LabelX42)
        Me.TabControlPanel3.Controls.Add(Me.LabelX37)
        Me.TabControlPanel3.Controls.Add(Me.LabelX32)
        Me.TabControlPanel3.Controls.Add(Me.LabelX29)
        Me.TabControlPanel3.Controls.Add(Me.LabelX28)
        Me.TabControlPanel3.Controls.Add(Me.LabelX33)
        Me.TabControlPanel3.Controls.Add(Me.LabelX38)
        Me.TabControlPanel3.Controls.Add(Me.LabelX45)
        Me.TabControlPanel3.Controls.Add(Me.LabelX41)
        Me.TabControlPanel3.Controls.Add(Me.LabelX44)
        Me.TabControlPanel3.Controls.Add(Me.LabelX43)
        Me.TabControlPanel3.Controls.Add(Me.LabelX40)
        Me.TabControlPanel3.Controls.Add(Me.LabelX36)
        Me.TabControlPanel3.Controls.Add(Me.LabelX35)
        Me.TabControlPanel3.Controls.Add(Me.LabelX34)
        Me.TabControlPanel3.Controls.Add(Me.LabelX26)
        Me.TabControlPanel3.Controls.Add(Me.LabelX31)
        Me.TabControlPanel3.Controls.Add(Me.LabelX25)
        Me.TabControlPanel3.Controls.Add(Me.LabelX30)
        Me.TabControlPanel3.Controls.Add(Me.LabelX27)
        Me.TabControlPanel3.Controls.Add(Me.LabelX24)
        Me.TabControlPanel3.Controls.Add(Me.LabelX2)
        Me.TabControlPanel3.Controls.Add(Me.LabelX23)
        Me.TabControlPanel3.Controls.Add(Me.LabelX22)
        Me.TabControlPanel3.Controls.Add(Me.LabelX20)
        Me.TabControlPanel3.Controls.Add(Me.LabelX21)
        Me.TabControlPanel3.Controls.Add(Me.lblTermiDate)
        Me.TabControlPanel3.Controls.Add(Me.LabelX1)
        resources.ApplyResources(Me.TabControlPanel3, "TabControlPanel3")
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabItem = Me.TabItem3
        '
        'txtDateExpire
        '
        resources.ApplyResources(Me.txtDateExpire, "txtDateExpire")
        Me.txtDateExpire.Name = "txtDateExpire"
        '
        'txtBirth
        '
        resources.ApplyResources(Me.txtBirth, "txtBirth")
        Me.txtBirth.Name = "txtBirth"
        '
        'txtDatePro
        '
        resources.ApplyResources(Me.txtDatePro, "txtDatePro")
        Me.txtDatePro.Name = "txtDatePro"
        '
        'txtTermiDate
        '
        resources.ApplyResources(Me.txtTermiDate, "txtTermiDate")
        Me.txtTermiDate.Name = "txtTermiDate"
        '
        'txtDateIn
        '
        resources.ApplyResources(Me.txtDateIn, "txtDateIn")
        Me.txtDateIn.Name = "txtDateIn"
        '
        'PicBox
        '
        resources.ApplyResources(Me.PicBox, "PicBox")
        Me.PicBox.Name = "PicBox"
        Me.PicBox.TabStop = False
        '
        'GroupPanel15
        '
        Me.GroupPanel15.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel15.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel15.Controls.Add(Me.chkContractor)
        Me.GroupPanel15.Controls.Add(Me.OptDay)
        Me.GroupPanel15.Controls.Add(Me.OptMonth)
        Me.GroupPanel15.Controls.Add(Me.txtSalary)
        Me.GroupPanel15.Controls.Add(Me.LabelX39)
        Me.GroupPanel15.Controls.Add(Me.txtBonus)
        resources.ApplyResources(Me.GroupPanel15, "GroupPanel15")
        Me.GroupPanel15.Name = "GroupPanel15"
        '
        '
        '
        Me.GroupPanel15.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel15.Style.BackColorGradientAngle = 90
        Me.GroupPanel15.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel15.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel15.Style.BorderBottomWidth = 1
        Me.GroupPanel15.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel15.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel15.Style.BorderLeftWidth = 1
        Me.GroupPanel15.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel15.Style.BorderRightWidth = 1
        Me.GroupPanel15.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel15.Style.BorderTopWidth = 1
        Me.GroupPanel15.Style.Class = ""
        Me.GroupPanel15.Style.CornerDiameter = 4
        Me.GroupPanel15.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel15.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel15.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel15.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel15.StyleMouseDown.Class = ""
        Me.GroupPanel15.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel15.StyleMouseOver.Class = ""
        Me.GroupPanel15.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'chkContractor
        '
        Me.chkContractor.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkContractor.BackgroundStyle.Class = ""
        Me.chkContractor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.chkContractor, "chkContractor")
        Me.chkContractor.Name = "chkContractor"
        Me.chkContractor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'OptDay
        '
        Me.OptDay.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.OptDay.BackgroundStyle.Class = ""
        Me.OptDay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.OptDay.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        resources.ApplyResources(Me.OptDay, "OptDay")
        Me.OptDay.Name = "OptDay"
        Me.OptDay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'OptMonth
        '
        Me.OptMonth.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.OptMonth.BackgroundStyle.Class = ""
        Me.OptMonth.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.OptMonth.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        resources.ApplyResources(Me.OptMonth, "OptMonth")
        Me.OptMonth.Name = "OptMonth"
        Me.OptMonth.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'txtSalary
        '
        '
        '
        '
        Me.txtSalary.Border.Class = "TextBoxBorder"
        Me.txtSalary.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtSalary, CType(resources.GetObject("txtSalary.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtSalary, "txtSalary")
        Me.txtSalary.Name = "txtSalary"
        '
        'LabelX39
        '
        Me.LabelX39.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX39.BackgroundStyle.Class = ""
        Me.LabelX39.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX39, "LabelX39")
        Me.LabelX39.Name = "LabelX39"
        Me.LabelX39.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtBonus
        '
        '
        '
        '
        Me.txtBonus.Border.Class = "TextBoxBorder"
        Me.txtBonus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtBonus, CType(resources.GetObject("txtBonus.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtBonus, "txtBonus")
        Me.txtBonus.Name = "txtBonus"
        '
        'GroupPanel4
        '
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.optBank)
        Me.GroupPanel4.Controls.Add(Me.optCash)
        Me.GroupPanel4.Controls.Add(Me.cboBank)
        resources.ApplyResources(Me.GroupPanel4, "GroupPanel4")
        Me.GroupPanel4.Name = "GroupPanel4"
        '
        '
        '
        Me.GroupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel4.Style.BackColorGradientAngle = 90
        Me.GroupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderBottomWidth = 1
        Me.GroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderLeftWidth = 1
        Me.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderRightWidth = 1
        Me.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderTopWidth = 1
        Me.GroupPanel4.Style.Class = ""
        Me.GroupPanel4.Style.CornerDiameter = 4
        Me.GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel4.StyleMouseDown.Class = ""
        Me.GroupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel4.StyleMouseOver.Class = ""
        Me.GroupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'optBank
        '
        Me.optBank.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.optBank.BackgroundStyle.Class = ""
        Me.optBank.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.optBank.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        resources.ApplyResources(Me.optBank, "optBank")
        Me.optBank.Name = "optBank"
        Me.optBank.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'optCash
        '
        Me.optCash.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.optCash.BackgroundStyle.Class = ""
        Me.optCash.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.optCash.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        resources.ApplyResources(Me.optCash, "optCash")
        Me.optCash.Name = "optCash"
        Me.optCash.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cboBank
        '
        Me.cboBank.DisplayMember = "Text"
        Me.cboBank.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBank.FormattingEnabled = True
        resources.ApplyResources(Me.cboBank, "cboBank")
        Me.cboBank.Name = "cboBank"
        Me.cboBank.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cboBroker
        '
        Me.cboBroker.DisplayMember = "Text"
        Me.cboBroker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboBroker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBroker.FormattingEnabled = True
        resources.ApplyResources(Me.cboBroker, "cboBroker")
        Me.cboBroker.Name = "cboBroker"
        Me.cboBroker.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cmbCompanyName
        '
        Me.cmbCompanyName.DisplayMember = "Text"
        Me.cmbCompanyName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompanyName.FormattingEnabled = True
        resources.ApplyResources(Me.cmbCompanyName, "cmbCompanyName")
        Me.cmbCompanyName.Name = "cmbCompanyName"
        Me.cmbCompanyName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'txtIdCard
        '
        resources.ApplyResources(Me.txtIdCard, "txtIdCard")
        Me.txtIdCard.Name = "txtIdCard"
        '
        'txtTypeBank
        '
        '
        '
        '
        Me.txtTypeBank.Border.Class = "TextBoxBorder"
        Me.txtTypeBank.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtTypeBank, CType(resources.GetObject("txtTypeBank.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtTypeBank, "txtTypeBank")
        Me.txtTypeBank.Name = "txtTypeBank"
        '
        'txtBankId
        '
        '
        '
        '
        Me.txtBankId.Border.Class = "TextBoxBorder"
        Me.txtBankId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtBankId, CType(resources.GetObject("txtBankId.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtBankId, "txtBankId")
        Me.txtBankId.Name = "txtBankId"
        '
        'txtSocTax
        '
        '
        '
        '
        Me.txtSocTax.Border.Class = "TextBoxBorder"
        Me.txtSocTax.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtSocTax, CType(resources.GetObject("txtSocTax.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtSocTax, "txtSocTax")
        Me.txtSocTax.Name = "txtSocTax"
        '
        'txtMarryWorkCom
        '
        '
        '
        '
        Me.txtMarryWorkCom.Border.Class = "TextBoxBorder"
        Me.txtMarryWorkCom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtMarryWorkCom, CType(resources.GetObject("txtMarryWorkCom.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtMarryWorkCom, "txtMarryWorkCom")
        Me.txtMarryWorkCom.Name = "txtMarryWorkCom"
        '
        'txtMarryName
        '
        '
        '
        '
        Me.txtMarryName.Border.Class = "TextBoxBorder"
        Me.txtMarryName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtMarryName, CType(resources.GetObject("txtMarryName.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtMarryName, "txtMarryName")
        Me.txtMarryName.Name = "txtMarryName"
        '
        'txtTaxId
        '
        '
        '
        '
        Me.txtTaxId.Border.Class = "TextBoxBorder"
        Me.txtTaxId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtTaxId, CType(resources.GetObject("txtTaxId.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtTaxId, "txtTaxId")
        Me.txtTaxId.Name = "txtTaxId"
        '
        'cboWeek
        '
        Me.cboWeek.DisplayMember = "Text"
        Me.cboWeek.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWeek.FormattingEnabled = True
        resources.ApplyResources(Me.cboWeek, "cboWeek")
        Me.cboWeek.Name = "cboWeek"
        Me.cboWeek.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cboEmpGroup
        '
        Me.cboEmpGroup.DisplayMember = "Text"
        Me.cboEmpGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboEmpGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpGroup.FormattingEnabled = True
        resources.ApplyResources(Me.cboEmpGroup, "cboEmpGroup")
        Me.cboEmpGroup.Name = "cboEmpGroup"
        Me.cboEmpGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'txtStatus
        '
        Me.txtStatus.DisplayMember = "Text"
        Me.txtStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtStatus.FormattingEnabled = True
        resources.ApplyResources(Me.txtStatus, "txtStatus")
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cboMateSpit
        '
        Me.cboMateSpit.DisplayMember = "Text"
        Me.cboMateSpit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboMateSpit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMateSpit.FormattingEnabled = True
        resources.ApplyResources(Me.cboMateSpit, "cboMateSpit")
        Me.cboMateSpit.Items.AddRange(New Object() {Me.ComboItem9, Me.ComboItem10})
        Me.cboMateSpit.Name = "cboMateSpit"
        Me.cboMateSpit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ComboItem9
        '
        resources.ApplyResources(Me.ComboItem9, "ComboItem9")
        '
        'ComboItem10
        '
        resources.ApplyResources(Me.ComboItem10, "ComboItem10")
        '
        'cboSex
        '
        Me.cboSex.DisplayMember = "Text"
        Me.cboSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSex.FormattingEnabled = True
        resources.ApplyResources(Me.cboSex, "cboSex")
        Me.cboSex.Items.AddRange(New Object() {Me.ComboItem7, Me.ComboItem8})
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ComboItem7
        '
        resources.ApplyResources(Me.ComboItem7, "ComboItem7")
        '
        'ComboItem8
        '
        resources.ApplyResources(Me.ComboItem8, "ComboItem8")
        '
        'txtAge
        '
        '
        '
        '
        Me.txtAge.Border.Class = "TextBoxBorder"
        Me.txtAge.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtAge, CType(resources.GetObject("txtAge.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtAge, "txtAge")
        Me.txtAge.Name = "txtAge"
        '
        'txtWorkAge
        '
        '
        '
        '
        Me.txtWorkAge.Border.Class = "TextBoxBorder"
        Me.txtWorkAge.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtWorkAge, CType(resources.GetObject("txtWorkAge.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtWorkAge, "txtWorkAge")
        Me.txtWorkAge.Name = "txtWorkAge"
        '
        'txtEducation
        '
        '
        '
        '
        Me.txtEducation.Border.Class = "TextBoxBorder"
        Me.txtEducation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtEducation, CType(resources.GetObject("txtEducation.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtEducation, "txtEducation")
        Me.txtEducation.Name = "txtEducation"
        '
        'txtAddress
        '
        '
        '
        '
        Me.txtAddress.Border.Class = "TextBoxBorder"
        Me.txtAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtAddress, CType(resources.GetObject("txtAddress.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtAddress, "txtAddress")
        Me.txtAddress.Name = "txtAddress"
        '
        'txtPlaceIdCard
        '
        '
        '
        '
        Me.txtPlaceIdCard.Border.Class = "TextBoxBorder"
        Me.txtPlaceIdCard.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtPlaceIdCard, CType(resources.GetObject("txtPlaceIdCard.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtPlaceIdCard, "txtPlaceIdCard")
        Me.txtPlaceIdCard.Name = "txtPlaceIdCard"
        '
        'LabelX42
        '
        Me.LabelX42.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX42.BackgroundStyle.Class = ""
        Me.LabelX42.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX42, "LabelX42")
        Me.LabelX42.Name = "LabelX42"
        Me.LabelX42.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX37
        '
        Me.LabelX37.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX37.BackgroundStyle.Class = ""
        Me.LabelX37.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX37, "LabelX37")
        Me.LabelX37.Name = "LabelX37"
        Me.LabelX37.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX32
        '
        Me.LabelX32.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX32.BackgroundStyle.Class = ""
        Me.LabelX32.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX32, "LabelX32")
        Me.LabelX32.Name = "LabelX32"
        Me.LabelX32.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX29
        '
        Me.LabelX29.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX29.BackgroundStyle.Class = ""
        Me.LabelX29.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX29, "LabelX29")
        Me.LabelX29.Name = "LabelX29"
        Me.LabelX29.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX28
        '
        Me.LabelX28.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX28.BackgroundStyle.Class = ""
        Me.LabelX28.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX28, "LabelX28")
        Me.LabelX28.Name = "LabelX28"
        Me.LabelX28.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX33
        '
        Me.LabelX33.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX33.BackgroundStyle.Class = ""
        Me.LabelX33.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX33, "LabelX33")
        Me.LabelX33.Name = "LabelX33"
        Me.LabelX33.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX38
        '
        Me.LabelX38.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX38.BackgroundStyle.Class = ""
        Me.LabelX38.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX38, "LabelX38")
        Me.LabelX38.Name = "LabelX38"
        Me.LabelX38.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX45
        '
        Me.LabelX45.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX45.BackgroundStyle.Class = ""
        Me.LabelX45.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX45, "LabelX45")
        Me.LabelX45.Name = "LabelX45"
        Me.LabelX45.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX41
        '
        Me.LabelX41.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX41.BackgroundStyle.Class = ""
        Me.LabelX41.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX41, "LabelX41")
        Me.LabelX41.Name = "LabelX41"
        Me.LabelX41.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX44
        '
        Me.LabelX44.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX44.BackgroundStyle.Class = ""
        Me.LabelX44.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX44, "LabelX44")
        Me.LabelX44.Name = "LabelX44"
        Me.LabelX44.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX43
        '
        Me.LabelX43.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX43.BackgroundStyle.Class = ""
        Me.LabelX43.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX43, "LabelX43")
        Me.LabelX43.Name = "LabelX43"
        Me.LabelX43.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX40
        '
        Me.LabelX40.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX40.BackgroundStyle.Class = ""
        Me.LabelX40.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX40, "LabelX40")
        Me.LabelX40.Name = "LabelX40"
        Me.LabelX40.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX36
        '
        Me.LabelX36.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX36.BackgroundStyle.Class = ""
        Me.LabelX36.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX36, "LabelX36")
        Me.LabelX36.Name = "LabelX36"
        Me.LabelX36.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX35
        '
        Me.LabelX35.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX35.BackgroundStyle.Class = ""
        Me.LabelX35.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX35, "LabelX35")
        Me.LabelX35.Name = "LabelX35"
        Me.LabelX35.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX34
        '
        Me.LabelX34.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX34.BackgroundStyle.Class = ""
        Me.LabelX34.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX34, "LabelX34")
        Me.LabelX34.Name = "LabelX34"
        Me.LabelX34.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX26
        '
        Me.LabelX26.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX26.BackgroundStyle.Class = ""
        Me.LabelX26.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX26, "LabelX26")
        Me.LabelX26.Name = "LabelX26"
        Me.LabelX26.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX31
        '
        Me.LabelX31.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX31.BackgroundStyle.Class = ""
        Me.LabelX31.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX31, "LabelX31")
        Me.LabelX31.Name = "LabelX31"
        Me.LabelX31.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX25
        '
        Me.LabelX25.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX25.BackgroundStyle.Class = ""
        Me.LabelX25.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX25, "LabelX25")
        Me.LabelX25.Name = "LabelX25"
        Me.LabelX25.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX30
        '
        Me.LabelX30.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX30.BackgroundStyle.Class = ""
        Me.LabelX30.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX30, "LabelX30")
        Me.LabelX30.Name = "LabelX30"
        Me.LabelX30.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX27
        '
        Me.LabelX27.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX27.BackgroundStyle.Class = ""
        Me.LabelX27.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX27, "LabelX27")
        Me.LabelX27.Name = "LabelX27"
        Me.LabelX27.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX24
        '
        Me.LabelX24.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX24.BackgroundStyle.Class = ""
        Me.LabelX24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX24, "LabelX24")
        Me.LabelX24.Name = "LabelX24"
        Me.LabelX24.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX2, "LabelX2")
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX23
        '
        Me.LabelX23.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX23.BackgroundStyle.Class = ""
        Me.LabelX23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX23, "LabelX23")
        Me.LabelX23.Name = "LabelX23"
        '
        'LabelX22
        '
        Me.LabelX22.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX22.BackgroundStyle.Class = ""
        Me.LabelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX22, "LabelX22")
        Me.LabelX22.Name = "LabelX22"
        Me.LabelX22.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX20
        '
        Me.LabelX20.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX20.BackgroundStyle.Class = ""
        Me.LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX20, "LabelX20")
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX21
        '
        Me.LabelX21.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX21.BackgroundStyle.Class = ""
        Me.LabelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX21, "LabelX21")
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblTermiDate
        '
        Me.lblTermiDate.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblTermiDate.BackgroundStyle.Class = ""
        Me.lblTermiDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.lblTermiDate, "lblTermiDate")
        Me.lblTermiDate.Name = "lblTermiDate"
        Me.lblTermiDate.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX1, "LabelX1")
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'TabItem3
        '
        Me.TabItem3.AttachedControl = Me.TabControlPanel3
        Me.TabItem3.Name = "TabItem3"
        resources.ApplyResources(Me.TabItem3, "TabItem3")
        '
        'TabControlPanel11
        '
        Me.TabControlPanel11.Controls.Add(Me.lstTraining)
        Me.TabControlPanel11.Controls.Add(Me.btnTrain_Clear)
        Me.TabControlPanel11.Controls.Add(Me.btnTrain_Delete)
        Me.TabControlPanel11.Controls.Add(Me.btnTrain_Edit)
        Me.TabControlPanel11.Controls.Add(Me.btnTrain_Add)
        Me.TabControlPanel11.Controls.Add(Me.txtTrainingDateSP)
        Me.TabControlPanel11.Controls.Add(Me.txtTrainingDateST)
        Me.TabControlPanel11.Controls.Add(Me.txtTrainingRemark)
        Me.TabControlPanel11.Controls.Add(Me.txtTrainingDay)
        Me.TabControlPanel11.Controls.Add(Me.txtTraining_RowId)
        Me.TabControlPanel11.Controls.Add(Me.txtTrainigName)
        Me.TabControlPanel11.Controls.Add(Me.LabelX128)
        Me.TabControlPanel11.Controls.Add(Me.LabelX123)
        Me.TabControlPanel11.Controls.Add(Me.LabelX127)
        Me.TabControlPanel11.Controls.Add(Me.LabelX124)
        Me.TabControlPanel11.Controls.Add(Me.LabelX126)
        Me.TabControlPanel11.Controls.Add(Me.LabelX122)
        resources.ApplyResources(Me.TabControlPanel11, "TabControlPanel11")
        Me.TabControlPanel11.Name = "TabControlPanel11"
        Me.TabControlPanel11.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel11.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel11.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel11.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel11.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel11.Style.GradientAngle = 90
        Me.TabControlPanel11.TabItem = Me.TabItem10
        '
        'lstTraining
        '
        resources.ApplyResources(Me.lstTraining, "lstTraining")
        '
        '
        '
        Me.lstTraining.Border.Class = "ListViewBorder"
        Me.lstTraining.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lstTraining.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colTraningNo, Me.colTraningName, Me.colTraningDateST, Me.colTraningDateSP, Me.colTraningDay, Me.colTraningRemark})
        Me.lstTraining.FullRowSelect = True
        Me.lstTraining.GridLines = True
        Me.lstTraining.MultiSelect = False
        Me.lstTraining.Name = "lstTraining"
        Me.lstTraining.UseCompatibleStateImageBehavior = False
        Me.lstTraining.View = System.Windows.Forms.View.Details
        '
        'colTraningNo
        '
        resources.ApplyResources(Me.colTraningNo, "colTraningNo")
        '
        'colTraningName
        '
        resources.ApplyResources(Me.colTraningName, "colTraningName")
        '
        'colTraningDateST
        '
        resources.ApplyResources(Me.colTraningDateST, "colTraningDateST")
        '
        'colTraningDateSP
        '
        resources.ApplyResources(Me.colTraningDateSP, "colTraningDateSP")
        '
        'colTraningDay
        '
        resources.ApplyResources(Me.colTraningDay, "colTraningDay")
        '
        'colTraningRemark
        '
        resources.ApplyResources(Me.colTraningRemark, "colTraningRemark")
        '
        'btnTrain_Clear
        '
        Me.btnTrain_Clear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnTrain_Clear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.btnTrain_Clear, "btnTrain_Clear")
        Me.btnTrain_Clear.Name = "btnTrain_Clear"
        Me.btnTrain_Clear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'btnTrain_Delete
        '
        Me.btnTrain_Delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnTrain_Delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.btnTrain_Delete, "btnTrain_Delete")
        Me.btnTrain_Delete.Name = "btnTrain_Delete"
        Me.btnTrain_Delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'btnTrain_Edit
        '
        Me.btnTrain_Edit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnTrain_Edit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.btnTrain_Edit, "btnTrain_Edit")
        Me.btnTrain_Edit.Name = "btnTrain_Edit"
        Me.btnTrain_Edit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'btnTrain_Add
        '
        Me.btnTrain_Add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnTrain_Add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.btnTrain_Add, "btnTrain_Add")
        Me.btnTrain_Add.Name = "btnTrain_Add"
        Me.btnTrain_Add.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'txtTrainingDateSP
        '
        resources.ApplyResources(Me.txtTrainingDateSP, "txtTrainingDateSP")
        Me.txtTrainingDateSP.Name = "txtTrainingDateSP"
        '
        'txtTrainingDateST
        '
        resources.ApplyResources(Me.txtTrainingDateST, "txtTrainingDateST")
        Me.txtTrainingDateST.Name = "txtTrainingDateST"
        '
        'txtTrainingRemark
        '
        '
        '
        '
        Me.txtTrainingRemark.Border.Class = "TextBoxBorder"
        Me.txtTrainingRemark.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtTrainingRemark, CType(resources.GetObject("txtTrainingRemark.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtTrainingRemark, "txtTrainingRemark")
        Me.txtTrainingRemark.Name = "txtTrainingRemark"
        '
        'txtTrainingDay
        '
        '
        '
        '
        Me.txtTrainingDay.Border.Class = "TextBoxBorder"
        Me.txtTrainingDay.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtTrainingDay, CType(resources.GetObject("txtTrainingDay.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtTrainingDay, "txtTrainingDay")
        Me.txtTrainingDay.Name = "txtTrainingDay"
        Me.txtTrainingDay.ReadOnly = True
        Me.txtTrainingDay.TabStop = False
        '
        'txtTraining_RowId
        '
        '
        '
        '
        Me.txtTraining_RowId.Border.Class = "TextBoxBorder"
        Me.txtTraining_RowId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtTraining_RowId, CType(resources.GetObject("txtTraining_RowId.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtTraining_RowId, "txtTraining_RowId")
        Me.txtTraining_RowId.Name = "txtTraining_RowId"
        '
        'txtTrainigName
        '
        '
        '
        '
        Me.txtTrainigName.Border.Class = "TextBoxBorder"
        Me.txtTrainigName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtTrainigName, CType(resources.GetObject("txtTrainigName.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtTrainigName, "txtTrainigName")
        Me.txtTrainigName.Name = "txtTrainigName"
        '
        'LabelX128
        '
        Me.LabelX128.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX128.BackgroundStyle.Class = ""
        Me.LabelX128.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX128, "LabelX128")
        Me.LabelX128.Name = "LabelX128"
        Me.LabelX128.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX123
        '
        Me.LabelX123.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX123.BackgroundStyle.Class = ""
        Me.LabelX123.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX123, "LabelX123")
        Me.LabelX123.Name = "LabelX123"
        '
        'LabelX127
        '
        Me.LabelX127.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX127.BackgroundStyle.Class = ""
        Me.LabelX127.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX127, "LabelX127")
        Me.LabelX127.Name = "LabelX127"
        Me.LabelX127.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX124
        '
        Me.LabelX124.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX124.BackgroundStyle.Class = ""
        Me.LabelX124.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX124, "LabelX124")
        Me.LabelX124.Name = "LabelX124"
        Me.LabelX124.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX126
        '
        Me.LabelX126.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX126.BackgroundStyle.Class = ""
        Me.LabelX126.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX126, "LabelX126")
        Me.LabelX126.Name = "LabelX126"
        Me.LabelX126.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX122
        '
        Me.LabelX122.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX122.BackgroundStyle.Class = ""
        Me.LabelX122.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX122, "LabelX122")
        Me.LabelX122.Name = "LabelX122"
        Me.LabelX122.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'TabItem10
        '
        Me.TabItem10.AttachedControl = Me.TabControlPanel11
        Me.TabItem10.Name = "TabItem10"
        resources.ApplyResources(Me.TabItem10, "TabItem10")
        '
        'TabControlPanel8
        '
        Me.TabControlPanel8.Controls.Add(Me.GroupPanel10)
        Me.TabControlPanel8.Controls.Add(Me.GroupPanel9)
        resources.ApplyResources(Me.TabControlPanel8, "TabControlPanel8")
        Me.TabControlPanel8.Name = "TabControlPanel8"
        Me.TabControlPanel8.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel8.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel8.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel8.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel8.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel8.Style.GradientAngle = 90
        Me.TabControlPanel8.TabItem = Me.TabItem8
        '
        'GroupPanel10
        '
        resources.ApplyResources(Me.GroupPanel10, "GroupPanel10")
        Me.GroupPanel10.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel10.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel10.Controls.Add(Me.LabelX115)
        Me.GroupPanel10.Controls.Add(Me.cboPrivilegeYear)
        Me.GroupPanel10.Name = "GroupPanel10"
        '
        '
        '
        Me.GroupPanel10.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel10.Style.BackColorGradientAngle = 90
        Me.GroupPanel10.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel10.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel10.Style.BorderBottomWidth = 1
        Me.GroupPanel10.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel10.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel10.Style.BorderLeftWidth = 1
        Me.GroupPanel10.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel10.Style.BorderRightWidth = 1
        Me.GroupPanel10.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel10.Style.BorderTopWidth = 1
        Me.GroupPanel10.Style.Class = ""
        Me.GroupPanel10.Style.CornerDiameter = 4
        Me.GroupPanel10.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel10.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel10.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel10.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel10.StyleMouseDown.Class = ""
        Me.GroupPanel10.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel10.StyleMouseOver.Class = ""
        Me.GroupPanel10.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'LabelX115
        '
        Me.LabelX115.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX115.BackgroundStyle.Class = ""
        Me.LabelX115.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX115, "LabelX115")
        Me.LabelX115.Name = "LabelX115"
        Me.LabelX115.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cboPrivilegeYear
        '
        Me.cboPrivilegeYear.DisplayMember = "Text"
        Me.cboPrivilegeYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPrivilegeYear.FormattingEnabled = True
        resources.ApplyResources(Me.cboPrivilegeYear, "cboPrivilegeYear")
        Me.cboPrivilegeYear.Name = "cboPrivilegeYear"
        Me.cboPrivilegeYear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'GroupPanel9
        '
        Me.GroupPanel9.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel9.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel9.Controls.Add(Me.lstPrivilege)
        resources.ApplyResources(Me.GroupPanel9, "GroupPanel9")
        Me.GroupPanel9.Name = "GroupPanel9"
        '
        '
        '
        Me.GroupPanel9.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel9.Style.BackColorGradientAngle = 90
        Me.GroupPanel9.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel9.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel9.Style.BorderBottomWidth = 1
        Me.GroupPanel9.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel9.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel9.Style.BorderLeftWidth = 1
        Me.GroupPanel9.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel9.Style.BorderRightWidth = 1
        Me.GroupPanel9.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel9.Style.BorderTopWidth = 1
        Me.GroupPanel9.Style.Class = ""
        Me.GroupPanel9.Style.CornerDiameter = 4
        Me.GroupPanel9.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel9.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        '
        '
        '
        Me.GroupPanel9.StyleMouseDown.Class = ""
        Me.GroupPanel9.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel9.StyleMouseOver.Class = ""
        Me.GroupPanel9.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'lstPrivilege
        '
        '
        '
        '
        Me.lstPrivilege.Border.Class = "ListViewBorder"
        Me.lstPrivilege.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lstPrivilege.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColTypeWage, Me.ColDayCount, Me.ColDayUse, Me.ColTotalDay})
        resources.ApplyResources(Me.lstPrivilege, "lstPrivilege")
        Me.lstPrivilege.FullRowSelect = True
        Me.lstPrivilege.GridLines = True
        Me.lstPrivilege.MultiSelect = False
        Me.lstPrivilege.Name = "lstPrivilege"
        Me.lstPrivilege.UseCompatibleStateImageBehavior = False
        Me.lstPrivilege.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        resources.ApplyResources(Me.ColumnHeader9, "ColumnHeader9")
        '
        'ColTypeWage
        '
        resources.ApplyResources(Me.ColTypeWage, "ColTypeWage")
        '
        'ColDayCount
        '
        resources.ApplyResources(Me.ColDayCount, "ColDayCount")
        '
        'ColDayUse
        '
        resources.ApplyResources(Me.ColDayUse, "ColDayUse")
        '
        'ColTotalDay
        '
        resources.ApplyResources(Me.ColTotalDay, "ColTotalDay")
        '
        'TabItem8
        '
        Me.TabItem8.AttachedControl = Me.TabControlPanel8
        Me.TabItem8.Name = "TabItem8"
        resources.ApplyResources(Me.TabItem8, "TabItem8")
        '
        'TabControlPanel4
        '
        Me.TabControlPanel4.Controls.Add(Me.chkCalSocTax)
        Me.TabControlPanel4.Controls.Add(Me.GroupPanel5)
        Me.TabControlPanel4.Controls.Add(Me.cboDonateMStart)
        Me.TabControlPanel4.Controls.Add(Me.cboLoanMStart)
        Me.TabControlPanel4.Controls.Add(Me.cboPremiumMStart)
        Me.TabControlPanel4.Controls.Add(Me.LabelX54)
        Me.TabControlPanel4.Controls.Add(Me.LabelX53)
        Me.TabControlPanel4.Controls.Add(Me.LabelX47)
        Me.TabControlPanel4.Controls.Add(Me.txtSonAge5)
        Me.TabControlPanel4.Controls.Add(Me.txtSonAge4)
        Me.TabControlPanel4.Controls.Add(Me.LabelX72)
        Me.TabControlPanel4.Controls.Add(Me.txtSonAge3)
        Me.TabControlPanel4.Controls.Add(Me.LabelX71)
        Me.TabControlPanel4.Controls.Add(Me.txtSonAge2)
        Me.TabControlPanel4.Controls.Add(Me.LabelX70)
        Me.TabControlPanel4.Controls.Add(Me.txtSonAge1)
        Me.TabControlPanel4.Controls.Add(Me.LabelX69)
        Me.TabControlPanel4.Controls.Add(Me.txtSonName5)
        Me.TabControlPanel4.Controls.Add(Me.LabelX68)
        Me.TabControlPanel4.Controls.Add(Me.txtSonName4)
        Me.TabControlPanel4.Controls.Add(Me.LabelX67)
        Me.TabControlPanel4.Controls.Add(Me.txtSonName3)
        Me.TabControlPanel4.Controls.Add(Me.LabelX66)
        Me.TabControlPanel4.Controls.Add(Me.txtSonName2)
        Me.TabControlPanel4.Controls.Add(Me.LabelX65)
        Me.TabControlPanel4.Controls.Add(Me.txtSonName1)
        Me.TabControlPanel4.Controls.Add(Me.LabelX64)
        Me.TabControlPanel4.Controls.Add(Me.txtCapitalSumary)
        Me.TabControlPanel4.Controls.Add(Me.LabelX63)
        Me.TabControlPanel4.Controls.Add(Me.txtDonate)
        Me.TabControlPanel4.Controls.Add(Me.LabelX52)
        Me.TabControlPanel4.Controls.Add(Me.txtLoan)
        Me.TabControlPanel4.Controls.Add(Me.LabelX51)
        Me.TabControlPanel4.Controls.Add(Me.txtA_ENT)
        Me.TabControlPanel4.Controls.Add(Me.txtPremium)
        Me.TabControlPanel4.Controls.Add(Me.LabelX50)
        Me.TabControlPanel4.Controls.Add(Me.LabelX49)
        Me.TabControlPanel4.Controls.Add(Me.LabelX58)
        Me.TabControlPanel4.Controls.Add(Me.LabelX57)
        Me.TabControlPanel4.Controls.Add(Me.LabelX56)
        Me.TabControlPanel4.Controls.Add(Me.LabelX55)
        Me.TabControlPanel4.Controls.Add(Me.LabelX48)
        Me.TabControlPanel4.Controls.Add(Me.LabelX46)
        resources.ApplyResources(Me.TabControlPanel4, "TabControlPanel4")
        Me.TabControlPanel4.Name = "TabControlPanel4"
        Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel4.Style.GradientAngle = 90
        Me.TabControlPanel4.TabItem = Me.TabItem4
        '
        'chkCalSocTax
        '
        Me.chkCalSocTax.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkCalSocTax.BackgroundStyle.Class = ""
        Me.chkCalSocTax.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.chkCalSocTax, "chkCalSocTax")
        Me.chkCalSocTax.Name = "chkCalSocTax"
        Me.chkCalSocTax.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'GroupPanel5
        '
        Me.GroupPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel5.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel5.Controls.Add(Me.txtSonEdu)
        Me.GroupPanel5.Controls.Add(Me.LabelX59)
        Me.GroupPanel5.Controls.Add(Me.LabelX62)
        Me.GroupPanel5.Controls.Add(Me.LabelX60)
        Me.GroupPanel5.Controls.Add(Me.LabelX61)
        Me.GroupPanel5.Controls.Add(Me.txtSonNonEdu)
        resources.ApplyResources(Me.GroupPanel5, "GroupPanel5")
        Me.GroupPanel5.Name = "GroupPanel5"
        '
        '
        '
        Me.GroupPanel5.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel5.Style.BackColorGradientAngle = 90
        Me.GroupPanel5.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel5.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderBottomWidth = 1
        Me.GroupPanel5.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel5.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderLeftWidth = 1
        Me.GroupPanel5.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderRightWidth = 1
        Me.GroupPanel5.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderTopWidth = 1
        Me.GroupPanel5.Style.Class = ""
        Me.GroupPanel5.Style.CornerDiameter = 4
        Me.GroupPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel5.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel5.StyleMouseDown.Class = ""
        Me.GroupPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel5.StyleMouseOver.Class = ""
        Me.GroupPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'txtSonEdu
        '
        '
        '
        '
        Me.txtSonEdu.Border.Class = "TextBoxBorder"
        Me.txtSonEdu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtSonEdu, CType(resources.GetObject("txtSonEdu.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtSonEdu, "txtSonEdu")
        Me.txtSonEdu.Name = "txtSonEdu"
        '
        'LabelX59
        '
        Me.LabelX59.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX59.BackgroundStyle.Class = ""
        Me.LabelX59.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX59, "LabelX59")
        Me.LabelX59.Name = "LabelX59"
        '
        'LabelX62
        '
        Me.LabelX62.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX62.BackgroundStyle.Class = ""
        Me.LabelX62.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX62, "LabelX62")
        Me.LabelX62.Name = "LabelX62"
        Me.LabelX62.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX60
        '
        Me.LabelX60.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX60.BackgroundStyle.Class = ""
        Me.LabelX60.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX60, "LabelX60")
        Me.LabelX60.Name = "LabelX60"
        Me.LabelX60.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX61
        '
        Me.LabelX61.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX61.BackgroundStyle.Class = ""
        Me.LabelX61.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX61, "LabelX61")
        Me.LabelX61.Name = "LabelX61"
        '
        'txtSonNonEdu
        '
        '
        '
        '
        Me.txtSonNonEdu.Border.Class = "TextBoxBorder"
        Me.txtSonNonEdu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtSonNonEdu, CType(resources.GetObject("txtSonNonEdu.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtSonNonEdu, "txtSonNonEdu")
        Me.txtSonNonEdu.Name = "txtSonNonEdu"
        '
        'cboDonateMStart
        '
        Me.cboDonateMStart.DisplayMember = "Text"
        Me.cboDonateMStart.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDonateMStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDonateMStart.FormattingEnabled = True
        resources.ApplyResources(Me.cboDonateMStart, "cboDonateMStart")
        Me.cboDonateMStart.Items.AddRange(New Object() {Me.ComboItem30, Me.ComboItem31, Me.ComboItem32, Me.ComboItem33, Me.ComboItem34, Me.ComboItem35, Me.ComboItem36})
        Me.cboDonateMStart.Name = "cboDonateMStart"
        Me.cboDonateMStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ComboItem30
        '
        resources.ApplyResources(Me.ComboItem30, "ComboItem30")
        '
        'ComboItem31
        '
        resources.ApplyResources(Me.ComboItem31, "ComboItem31")
        '
        'ComboItem32
        '
        resources.ApplyResources(Me.ComboItem32, "ComboItem32")
        '
        'ComboItem33
        '
        resources.ApplyResources(Me.ComboItem33, "ComboItem33")
        '
        'ComboItem34
        '
        resources.ApplyResources(Me.ComboItem34, "ComboItem34")
        '
        'ComboItem35
        '
        resources.ApplyResources(Me.ComboItem35, "ComboItem35")
        '
        'ComboItem36
        '
        resources.ApplyResources(Me.ComboItem36, "ComboItem36")
        '
        'cboLoanMStart
        '
        Me.cboLoanMStart.DisplayMember = "Text"
        Me.cboLoanMStart.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboLoanMStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLoanMStart.FormattingEnabled = True
        resources.ApplyResources(Me.cboLoanMStart, "cboLoanMStart")
        Me.cboLoanMStart.Items.AddRange(New Object() {Me.ComboItem23, Me.ComboItem24, Me.ComboItem25, Me.ComboItem26, Me.ComboItem27, Me.ComboItem28, Me.ComboItem29})
        Me.cboLoanMStart.Name = "cboLoanMStart"
        Me.cboLoanMStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ComboItem23
        '
        resources.ApplyResources(Me.ComboItem23, "ComboItem23")
        '
        'ComboItem24
        '
        resources.ApplyResources(Me.ComboItem24, "ComboItem24")
        '
        'ComboItem25
        '
        resources.ApplyResources(Me.ComboItem25, "ComboItem25")
        '
        'ComboItem26
        '
        resources.ApplyResources(Me.ComboItem26, "ComboItem26")
        '
        'ComboItem27
        '
        resources.ApplyResources(Me.ComboItem27, "ComboItem27")
        '
        'ComboItem28
        '
        resources.ApplyResources(Me.ComboItem28, "ComboItem28")
        '
        'ComboItem29
        '
        resources.ApplyResources(Me.ComboItem29, "ComboItem29")
        '
        'cboPremiumMStart
        '
        Me.cboPremiumMStart.DisplayMember = "Text"
        Me.cboPremiumMStart.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPremiumMStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPremiumMStart.FormattingEnabled = True
        resources.ApplyResources(Me.cboPremiumMStart, "cboPremiumMStart")
        Me.cboPremiumMStart.Items.AddRange(New Object() {Me.ComboItem16, Me.ComboItem17, Me.ComboItem18, Me.ComboItem19, Me.ComboItem20, Me.ComboItem21, Me.ComboItem22})
        Me.cboPremiumMStart.Name = "cboPremiumMStart"
        Me.cboPremiumMStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ComboItem16
        '
        resources.ApplyResources(Me.ComboItem16, "ComboItem16")
        '
        'ComboItem17
        '
        resources.ApplyResources(Me.ComboItem17, "ComboItem17")
        '
        'ComboItem18
        '
        resources.ApplyResources(Me.ComboItem18, "ComboItem18")
        '
        'ComboItem19
        '
        resources.ApplyResources(Me.ComboItem19, "ComboItem19")
        '
        'ComboItem20
        '
        resources.ApplyResources(Me.ComboItem20, "ComboItem20")
        '
        'ComboItem21
        '
        resources.ApplyResources(Me.ComboItem21, "ComboItem21")
        '
        'ComboItem22
        '
        resources.ApplyResources(Me.ComboItem22, "ComboItem22")
        '
        'LabelX54
        '
        Me.LabelX54.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX54.BackgroundStyle.Class = ""
        Me.LabelX54.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX54, "LabelX54")
        Me.LabelX54.Name = "LabelX54"
        Me.LabelX54.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX53
        '
        Me.LabelX53.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX53.BackgroundStyle.Class = ""
        Me.LabelX53.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX53, "LabelX53")
        Me.LabelX53.Name = "LabelX53"
        Me.LabelX53.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX47
        '
        Me.LabelX47.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX47.BackgroundStyle.Class = ""
        Me.LabelX47.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX47, "LabelX47")
        Me.LabelX47.Name = "LabelX47"
        Me.LabelX47.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtSonAge5
        '
        '
        '
        '
        Me.txtSonAge5.Border.Class = "TextBoxBorder"
        Me.txtSonAge5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtSonAge5, CType(resources.GetObject("txtSonAge5.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtSonAge5, "txtSonAge5")
        Me.txtSonAge5.Name = "txtSonAge5"
        '
        'txtSonAge4
        '
        '
        '
        '
        Me.txtSonAge4.Border.Class = "TextBoxBorder"
        Me.txtSonAge4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtSonAge4, CType(resources.GetObject("txtSonAge4.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtSonAge4, "txtSonAge4")
        Me.txtSonAge4.Name = "txtSonAge4"
        '
        'LabelX72
        '
        Me.LabelX72.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX72.BackgroundStyle.Class = ""
        Me.LabelX72.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX72, "LabelX72")
        Me.LabelX72.Name = "LabelX72"
        Me.LabelX72.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtSonAge3
        '
        '
        '
        '
        Me.txtSonAge3.Border.Class = "TextBoxBorder"
        Me.txtSonAge3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtSonAge3, CType(resources.GetObject("txtSonAge3.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtSonAge3, "txtSonAge3")
        Me.txtSonAge3.Name = "txtSonAge3"
        '
        'LabelX71
        '
        Me.LabelX71.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX71.BackgroundStyle.Class = ""
        Me.LabelX71.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX71, "LabelX71")
        Me.LabelX71.Name = "LabelX71"
        Me.LabelX71.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtSonAge2
        '
        '
        '
        '
        Me.txtSonAge2.Border.Class = "TextBoxBorder"
        Me.txtSonAge2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtSonAge2, CType(resources.GetObject("txtSonAge2.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtSonAge2, "txtSonAge2")
        Me.txtSonAge2.Name = "txtSonAge2"
        '
        'LabelX70
        '
        Me.LabelX70.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX70.BackgroundStyle.Class = ""
        Me.LabelX70.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX70, "LabelX70")
        Me.LabelX70.Name = "LabelX70"
        Me.LabelX70.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtSonAge1
        '
        '
        '
        '
        Me.txtSonAge1.Border.Class = "TextBoxBorder"
        Me.txtSonAge1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtSonAge1, CType(resources.GetObject("txtSonAge1.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtSonAge1, "txtSonAge1")
        Me.txtSonAge1.Name = "txtSonAge1"
        '
        'LabelX69
        '
        Me.LabelX69.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX69.BackgroundStyle.Class = ""
        Me.LabelX69.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX69, "LabelX69")
        Me.LabelX69.Name = "LabelX69"
        Me.LabelX69.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtSonName5
        '
        '
        '
        '
        Me.txtSonName5.Border.Class = "TextBoxBorder"
        Me.txtSonName5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtSonName5, CType(resources.GetObject("txtSonName5.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtSonName5, "txtSonName5")
        Me.txtSonName5.Name = "txtSonName5"
        '
        'LabelX68
        '
        Me.LabelX68.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX68.BackgroundStyle.Class = ""
        Me.LabelX68.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX68, "LabelX68")
        Me.LabelX68.Name = "LabelX68"
        Me.LabelX68.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtSonName4
        '
        '
        '
        '
        Me.txtSonName4.Border.Class = "TextBoxBorder"
        Me.txtSonName4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtSonName4, CType(resources.GetObject("txtSonName4.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtSonName4, "txtSonName4")
        Me.txtSonName4.Name = "txtSonName4"
        '
        'LabelX67
        '
        Me.LabelX67.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX67.BackgroundStyle.Class = ""
        Me.LabelX67.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX67, "LabelX67")
        Me.LabelX67.Name = "LabelX67"
        Me.LabelX67.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtSonName3
        '
        '
        '
        '
        Me.txtSonName3.Border.Class = "TextBoxBorder"
        Me.txtSonName3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtSonName3, CType(resources.GetObject("txtSonName3.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtSonName3, "txtSonName3")
        Me.txtSonName3.Name = "txtSonName3"
        '
        'LabelX66
        '
        Me.LabelX66.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX66.BackgroundStyle.Class = ""
        Me.LabelX66.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX66, "LabelX66")
        Me.LabelX66.Name = "LabelX66"
        Me.LabelX66.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtSonName2
        '
        '
        '
        '
        Me.txtSonName2.Border.Class = "TextBoxBorder"
        Me.txtSonName2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtSonName2, CType(resources.GetObject("txtSonName2.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtSonName2, "txtSonName2")
        Me.txtSonName2.Name = "txtSonName2"
        '
        'LabelX65
        '
        Me.LabelX65.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX65.BackgroundStyle.Class = ""
        Me.LabelX65.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX65, "LabelX65")
        Me.LabelX65.Name = "LabelX65"
        Me.LabelX65.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtSonName1
        '
        '
        '
        '
        Me.txtSonName1.Border.Class = "TextBoxBorder"
        Me.txtSonName1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtSonName1, CType(resources.GetObject("txtSonName1.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtSonName1, "txtSonName1")
        Me.txtSonName1.Name = "txtSonName1"
        '
        'LabelX64
        '
        Me.LabelX64.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX64.BackgroundStyle.Class = ""
        Me.LabelX64.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX64, "LabelX64")
        Me.LabelX64.Name = "LabelX64"
        Me.LabelX64.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtCapitalSumary
        '
        '
        '
        '
        Me.txtCapitalSumary.Border.Class = "TextBoxBorder"
        Me.txtCapitalSumary.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtCapitalSumary, CType(resources.GetObject("txtCapitalSumary.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtCapitalSumary, "txtCapitalSumary")
        Me.txtCapitalSumary.Name = "txtCapitalSumary"
        '
        'LabelX63
        '
        Me.LabelX63.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX63.BackgroundStyle.Class = ""
        Me.LabelX63.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX63, "LabelX63")
        Me.LabelX63.Name = "LabelX63"
        Me.LabelX63.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtDonate
        '
        '
        '
        '
        Me.txtDonate.Border.Class = "TextBoxBorder"
        Me.txtDonate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtDonate, CType(resources.GetObject("txtDonate.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtDonate, "txtDonate")
        Me.txtDonate.Name = "txtDonate"
        '
        'LabelX52
        '
        Me.LabelX52.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX52.BackgroundStyle.Class = ""
        Me.LabelX52.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX52, "LabelX52")
        Me.LabelX52.Name = "LabelX52"
        Me.LabelX52.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtLoan
        '
        '
        '
        '
        Me.txtLoan.Border.Class = "TextBoxBorder"
        Me.txtLoan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtLoan, CType(resources.GetObject("txtLoan.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtLoan, "txtLoan")
        Me.txtLoan.Name = "txtLoan"
        '
        'LabelX51
        '
        Me.LabelX51.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX51.BackgroundStyle.Class = ""
        Me.LabelX51.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX51, "LabelX51")
        Me.LabelX51.Name = "LabelX51"
        Me.LabelX51.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtA_ENT
        '
        '
        '
        '
        Me.txtA_ENT.Border.Class = "TextBoxBorder"
        Me.txtA_ENT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtA_ENT, CType(resources.GetObject("txtA_ENT.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtA_ENT, "txtA_ENT")
        Me.txtA_ENT.Name = "txtA_ENT"
        '
        'txtPremium
        '
        '
        '
        '
        Me.txtPremium.Border.Class = "TextBoxBorder"
        Me.txtPremium.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtPremium, CType(resources.GetObject("txtPremium.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtPremium, "txtPremium")
        Me.txtPremium.Name = "txtPremium"
        '
        'LabelX50
        '
        Me.LabelX50.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX50.BackgroundStyle.Class = ""
        Me.LabelX50.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX50, "LabelX50")
        Me.LabelX50.Name = "LabelX50"
        Me.LabelX50.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX49
        '
        Me.LabelX49.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX49.BackgroundStyle.Class = ""
        Me.LabelX49.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX49, "LabelX49")
        Me.LabelX49.Name = "LabelX49"
        Me.LabelX49.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX58
        '
        Me.LabelX58.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX58.BackgroundStyle.Class = ""
        Me.LabelX58.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX58, "LabelX58")
        Me.LabelX58.Name = "LabelX58"
        '
        'LabelX57
        '
        Me.LabelX57.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX57.BackgroundStyle.Class = ""
        Me.LabelX57.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX57, "LabelX57")
        Me.LabelX57.Name = "LabelX57"
        '
        'LabelX56
        '
        Me.LabelX56.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX56.BackgroundStyle.Class = ""
        Me.LabelX56.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX56, "LabelX56")
        Me.LabelX56.Name = "LabelX56"
        '
        'LabelX55
        '
        Me.LabelX55.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX55.BackgroundStyle.Class = ""
        Me.LabelX55.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX55, "LabelX55")
        Me.LabelX55.Name = "LabelX55"
        '
        'LabelX48
        '
        Me.LabelX48.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX48.BackgroundStyle.Class = ""
        Me.LabelX48.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX48, "LabelX48")
        Me.LabelX48.Name = "LabelX48"
        '
        'LabelX46
        '
        Me.LabelX46.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX46.BackgroundStyle.Class = ""
        Me.LabelX46.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX46, "LabelX46")
        Me.LabelX46.Name = "LabelX46"
        Me.LabelX46.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'TabItem4
        '
        Me.TabItem4.AttachedControl = Me.TabControlPanel4
        Me.TabItem4.Name = "TabItem4"
        resources.ApplyResources(Me.TabItem4, "TabItem4")
        '
        'TabControlPanel5
        '
        Me.TabControlPanel5.Controls.Add(Me.txtSoldierDate)
        Me.TabControlPanel5.Controls.Add(Me.txtDriveDate)
        Me.TabControlPanel5.Controls.Add(Me.txtforeignDate)
        Me.TabControlPanel5.Controls.Add(Me.chkPro_Fund)
        Me.TabControlPanel5.Controls.Add(Me.chkMatherCalTaxMate)
        Me.TabControlPanel5.Controls.Add(Me.chkFatherCalTaxMate)
        Me.TabControlPanel5.Controls.Add(Me.chkMatherCalTax)
        Me.TabControlPanel5.Controls.Add(Me.chkFatherCalTax)
        Me.TabControlPanel5.Controls.Add(Me.txtMatherIdCardMate)
        Me.TabControlPanel5.Controls.Add(Me.LabelX92)
        Me.TabControlPanel5.Controls.Add(Me.txtFatherIdCardMate)
        Me.TabControlPanel5.Controls.Add(Me.LabelX91)
        Me.TabControlPanel5.Controls.Add(Me.txtMatherIdCard)
        Me.TabControlPanel5.Controls.Add(Me.LabelX90)
        Me.TabControlPanel5.Controls.Add(Me.txtFatherIdCard)
        Me.TabControlPanel5.Controls.Add(Me.LabelX89)
        Me.TabControlPanel5.Controls.Add(Me.cboSoldierStatus)
        Me.TabControlPanel5.Controls.Add(Me.LabelX82)
        Me.TabControlPanel5.Controls.Add(Me.LabelX97)
        Me.TabControlPanel5.Controls.Add(Me.LabelX81)
        Me.TabControlPanel5.Controls.Add(Me.LabelX80)
        Me.TabControlPanel5.Controls.Add(Me.txtReligion)
        Me.TabControlPanel5.Controls.Add(Me.LabelX75)
        Me.TabControlPanel5.Controls.Add(Me.txtRace)
        Me.TabControlPanel5.Controls.Add(Me.txtNationalily)
        Me.TabControlPanel5.Controls.Add(Me.LabelX74)
        Me.TabControlPanel5.Controls.Add(Me.txtMatherNameMate)
        Me.TabControlPanel5.Controls.Add(Me.LabelX88)
        Me.TabControlPanel5.Controls.Add(Me.txtRemark)
        Me.TabControlPanel5.Controls.Add(Me.LabelX96)
        Me.TabControlPanel5.Controls.Add(Me.txtEduSpacial)
        Me.TabControlPanel5.Controls.Add(Me.LabelX95)
        Me.TabControlPanel5.Controls.Add(Me.txtErContract)
        Me.TabControlPanel5.Controls.Add(Me.LabelX87)
        Me.TabControlPanel5.Controls.Add(Me.txtEr_Tel)
        Me.TabControlPanel5.Controls.Add(Me.LabelX94)
        Me.TabControlPanel5.Controls.Add(Me.txtGuanWork)
        Me.TabControlPanel5.Controls.Add(Me.LabelX93)
        Me.TabControlPanel5.Controls.Add(Me.txtGuaranteeName)
        Me.TabControlPanel5.Controls.Add(Me.LabelX86)
        Me.TabControlPanel5.Controls.Add(Me.txtFatherNameMate)
        Me.TabControlPanel5.Controls.Add(Me.LabelX85)
        Me.TabControlPanel5.Controls.Add(Me.txtMatherName)
        Me.TabControlPanel5.Controls.Add(Me.LabelX84)
        Me.TabControlPanel5.Controls.Add(Me.txtFatherName)
        Me.TabControlPanel5.Controls.Add(Me.LabelX83)
        Me.TabControlPanel5.Controls.Add(Me.txtDrivePlace)
        Me.TabControlPanel5.Controls.Add(Me.LabelX79)
        Me.TabControlPanel5.Controls.Add(Me.txtDriveNo)
        Me.TabControlPanel5.Controls.Add(Me.LabelX78)
        Me.TabControlPanel5.Controls.Add(Me.txtforeignNo)
        Me.TabControlPanel5.Controls.Add(Me.LabelX77)
        Me.TabControlPanel5.Controls.Add(Me.txtTelContract)
        Me.TabControlPanel5.Controls.Add(Me.LabelX76)
        Me.TabControlPanel5.Controls.Add(Me.LabelX73)
        resources.ApplyResources(Me.TabControlPanel5, "TabControlPanel5")
        Me.TabControlPanel5.Name = "TabControlPanel5"
        Me.TabControlPanel5.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel5.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel5.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel5.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel5.Style.GradientAngle = 90
        Me.TabControlPanel5.TabItem = Me.TabItem5
        '
        'txtSoldierDate
        '
        resources.ApplyResources(Me.txtSoldierDate, "txtSoldierDate")
        Me.txtSoldierDate.Name = "txtSoldierDate"
        '
        'txtDriveDate
        '
        resources.ApplyResources(Me.txtDriveDate, "txtDriveDate")
        Me.txtDriveDate.Name = "txtDriveDate"
        '
        'txtforeignDate
        '
        resources.ApplyResources(Me.txtforeignDate, "txtforeignDate")
        Me.txtforeignDate.Name = "txtforeignDate"
        '
        'chkPro_Fund
        '
        Me.chkPro_Fund.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkPro_Fund.BackgroundStyle.Class = ""
        Me.chkPro_Fund.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.chkPro_Fund, "chkPro_Fund")
        Me.chkPro_Fund.Name = "chkPro_Fund"
        Me.chkPro_Fund.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'chkMatherCalTaxMate
        '
        Me.chkMatherCalTaxMate.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkMatherCalTaxMate.BackgroundStyle.Class = ""
        Me.chkMatherCalTaxMate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.chkMatherCalTaxMate, "chkMatherCalTaxMate")
        Me.chkMatherCalTaxMate.Name = "chkMatherCalTaxMate"
        Me.chkMatherCalTaxMate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'chkFatherCalTaxMate
        '
        Me.chkFatherCalTaxMate.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkFatherCalTaxMate.BackgroundStyle.Class = ""
        Me.chkFatherCalTaxMate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.chkFatherCalTaxMate, "chkFatherCalTaxMate")
        Me.chkFatherCalTaxMate.Name = "chkFatherCalTaxMate"
        Me.chkFatherCalTaxMate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'chkMatherCalTax
        '
        Me.chkMatherCalTax.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkMatherCalTax.BackgroundStyle.Class = ""
        Me.chkMatherCalTax.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.chkMatherCalTax, "chkMatherCalTax")
        Me.chkMatherCalTax.Name = "chkMatherCalTax"
        Me.chkMatherCalTax.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'chkFatherCalTax
        '
        Me.chkFatherCalTax.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkFatherCalTax.BackgroundStyle.Class = ""
        Me.chkFatherCalTax.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.chkFatherCalTax, "chkFatherCalTax")
        Me.chkFatherCalTax.Name = "chkFatherCalTax"
        Me.chkFatherCalTax.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'txtMatherIdCardMate
        '
        resources.ApplyResources(Me.txtMatherIdCardMate, "txtMatherIdCardMate")
        Me.txtMatherIdCardMate.Name = "txtMatherIdCardMate"
        '
        'LabelX92
        '
        Me.LabelX92.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX92.BackgroundStyle.Class = ""
        Me.LabelX92.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX92, "LabelX92")
        Me.LabelX92.Name = "LabelX92"
        Me.LabelX92.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtFatherIdCardMate
        '
        resources.ApplyResources(Me.txtFatherIdCardMate, "txtFatherIdCardMate")
        Me.txtFatherIdCardMate.Name = "txtFatherIdCardMate"
        '
        'LabelX91
        '
        Me.LabelX91.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX91.BackgroundStyle.Class = ""
        Me.LabelX91.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX91, "LabelX91")
        Me.LabelX91.Name = "LabelX91"
        Me.LabelX91.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtMatherIdCard
        '
        resources.ApplyResources(Me.txtMatherIdCard, "txtMatherIdCard")
        Me.txtMatherIdCard.Name = "txtMatherIdCard"
        '
        'LabelX90
        '
        Me.LabelX90.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX90.BackgroundStyle.Class = ""
        Me.LabelX90.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX90, "LabelX90")
        Me.LabelX90.Name = "LabelX90"
        Me.LabelX90.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtFatherIdCard
        '
        resources.ApplyResources(Me.txtFatherIdCard, "txtFatherIdCard")
        Me.txtFatherIdCard.Name = "txtFatherIdCard"
        '
        'LabelX89
        '
        Me.LabelX89.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX89.BackgroundStyle.Class = ""
        Me.LabelX89.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX89, "LabelX89")
        Me.LabelX89.Name = "LabelX89"
        Me.LabelX89.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cboSoldierStatus
        '
        Me.cboSoldierStatus.DisplayMember = "Text"
        Me.cboSoldierStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSoldierStatus.FormattingEnabled = True
        resources.ApplyResources(Me.cboSoldierStatus, "cboSoldierStatus")
        Me.cboSoldierStatus.Items.AddRange(New Object() {Me.ComboItem37, Me.ComboItem38})
        Me.cboSoldierStatus.Name = "cboSoldierStatus"
        Me.cboSoldierStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ComboItem37
        '
        resources.ApplyResources(Me.ComboItem37, "ComboItem37")
        '
        'ComboItem38
        '
        resources.ApplyResources(Me.ComboItem38, "ComboItem38")
        '
        'LabelX82
        '
        Me.LabelX82.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX82.BackgroundStyle.Class = ""
        Me.LabelX82.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX82, "LabelX82")
        Me.LabelX82.Name = "LabelX82"
        Me.LabelX82.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX97
        '
        Me.LabelX97.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX97.BackgroundStyle.Class = ""
        Me.LabelX97.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX97, "LabelX97")
        Me.LabelX97.Name = "LabelX97"
        Me.LabelX97.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX81
        '
        Me.LabelX81.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX81.BackgroundStyle.Class = ""
        Me.LabelX81.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX81, "LabelX81")
        Me.LabelX81.Name = "LabelX81"
        Me.LabelX81.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX80
        '
        Me.LabelX80.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX80.BackgroundStyle.Class = ""
        Me.LabelX80.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX80, "LabelX80")
        Me.LabelX80.Name = "LabelX80"
        Me.LabelX80.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtReligion
        '
        '
        '
        '
        Me.txtReligion.Border.Class = "TextBoxBorder"
        Me.txtReligion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtReligion, CType(resources.GetObject("txtReligion.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtReligion, "txtReligion")
        Me.txtReligion.Name = "txtReligion"
        '
        'LabelX75
        '
        Me.LabelX75.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX75.BackgroundStyle.Class = ""
        Me.LabelX75.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX75, "LabelX75")
        Me.LabelX75.Name = "LabelX75"
        Me.LabelX75.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtRace
        '
        '
        '
        '
        Me.txtRace.Border.Class = "TextBoxBorder"
        Me.txtRace.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtRace, CType(resources.GetObject("txtRace.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtRace, "txtRace")
        Me.txtRace.Name = "txtRace"
        '
        'txtNationalily
        '
        '
        '
        '
        Me.txtNationalily.Border.Class = "TextBoxBorder"
        Me.txtNationalily.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtNationalily, CType(resources.GetObject("txtNationalily.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtNationalily, "txtNationalily")
        Me.txtNationalily.Name = "txtNationalily"
        '
        'LabelX74
        '
        Me.LabelX74.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX74.BackgroundStyle.Class = ""
        Me.LabelX74.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX74, "LabelX74")
        Me.LabelX74.Name = "LabelX74"
        Me.LabelX74.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtMatherNameMate
        '
        '
        '
        '
        Me.txtMatherNameMate.Border.Class = "TextBoxBorder"
        Me.txtMatherNameMate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtMatherNameMate, CType(resources.GetObject("txtMatherNameMate.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtMatherNameMate, "txtMatherNameMate")
        Me.txtMatherNameMate.Name = "txtMatherNameMate"
        '
        'LabelX88
        '
        Me.LabelX88.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX88.BackgroundStyle.Class = ""
        Me.LabelX88.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX88, "LabelX88")
        Me.LabelX88.Name = "LabelX88"
        Me.LabelX88.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtRemark
        '
        '
        '
        '
        Me.txtRemark.Border.Class = "TextBoxBorder"
        Me.txtRemark.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtRemark, CType(resources.GetObject("txtRemark.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtRemark, "txtRemark")
        Me.txtRemark.Name = "txtRemark"
        '
        'LabelX96
        '
        Me.LabelX96.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX96.BackgroundStyle.Class = ""
        Me.LabelX96.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX96, "LabelX96")
        Me.LabelX96.Name = "LabelX96"
        Me.LabelX96.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtEduSpacial
        '
        '
        '
        '
        Me.txtEduSpacial.Border.Class = "TextBoxBorder"
        Me.txtEduSpacial.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtEduSpacial, CType(resources.GetObject("txtEduSpacial.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtEduSpacial, "txtEduSpacial")
        Me.txtEduSpacial.Name = "txtEduSpacial"
        '
        'LabelX95
        '
        Me.LabelX95.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX95.BackgroundStyle.Class = ""
        Me.LabelX95.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX95, "LabelX95")
        Me.LabelX95.Name = "LabelX95"
        Me.LabelX95.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtErContract
        '
        '
        '
        '
        Me.txtErContract.Border.Class = "TextBoxBorder"
        Me.txtErContract.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtErContract, CType(resources.GetObject("txtErContract.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtErContract, "txtErContract")
        Me.txtErContract.Name = "txtErContract"
        '
        'LabelX87
        '
        Me.LabelX87.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX87.BackgroundStyle.Class = ""
        Me.LabelX87.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX87, "LabelX87")
        Me.LabelX87.Name = "LabelX87"
        Me.LabelX87.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtEr_Tel
        '
        '
        '
        '
        Me.txtEr_Tel.Border.Class = "TextBoxBorder"
        Me.txtEr_Tel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtEr_Tel, CType(resources.GetObject("txtEr_Tel.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtEr_Tel, "txtEr_Tel")
        Me.txtEr_Tel.Name = "txtEr_Tel"
        '
        'LabelX94
        '
        Me.LabelX94.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX94.BackgroundStyle.Class = ""
        Me.LabelX94.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX94, "LabelX94")
        Me.LabelX94.Name = "LabelX94"
        Me.LabelX94.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtGuanWork
        '
        '
        '
        '
        Me.txtGuanWork.Border.Class = "TextBoxBorder"
        Me.txtGuanWork.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtGuanWork, CType(resources.GetObject("txtGuanWork.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtGuanWork, "txtGuanWork")
        Me.txtGuanWork.Name = "txtGuanWork"
        '
        'LabelX93
        '
        Me.LabelX93.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX93.BackgroundStyle.Class = ""
        Me.LabelX93.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX93, "LabelX93")
        Me.LabelX93.Name = "LabelX93"
        Me.LabelX93.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtGuaranteeName
        '
        '
        '
        '
        Me.txtGuaranteeName.Border.Class = "TextBoxBorder"
        Me.txtGuaranteeName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtGuaranteeName, CType(resources.GetObject("txtGuaranteeName.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtGuaranteeName, "txtGuaranteeName")
        Me.txtGuaranteeName.Name = "txtGuaranteeName"
        '
        'LabelX86
        '
        Me.LabelX86.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX86.BackgroundStyle.Class = ""
        Me.LabelX86.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX86, "LabelX86")
        Me.LabelX86.Name = "LabelX86"
        Me.LabelX86.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtFatherNameMate
        '
        '
        '
        '
        Me.txtFatherNameMate.Border.Class = "TextBoxBorder"
        Me.txtFatherNameMate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtFatherNameMate, CType(resources.GetObject("txtFatherNameMate.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtFatherNameMate, "txtFatherNameMate")
        Me.txtFatherNameMate.Name = "txtFatherNameMate"
        '
        'LabelX85
        '
        Me.LabelX85.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX85.BackgroundStyle.Class = ""
        Me.LabelX85.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX85, "LabelX85")
        Me.LabelX85.Name = "LabelX85"
        Me.LabelX85.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtMatherName
        '
        '
        '
        '
        Me.txtMatherName.Border.Class = "TextBoxBorder"
        Me.txtMatherName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtMatherName, CType(resources.GetObject("txtMatherName.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtMatherName, "txtMatherName")
        Me.txtMatherName.Name = "txtMatherName"
        '
        'LabelX84
        '
        Me.LabelX84.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX84.BackgroundStyle.Class = ""
        Me.LabelX84.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX84, "LabelX84")
        Me.LabelX84.Name = "LabelX84"
        Me.LabelX84.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtFatherName
        '
        '
        '
        '
        Me.txtFatherName.Border.Class = "TextBoxBorder"
        Me.txtFatherName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtFatherName, CType(resources.GetObject("txtFatherName.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtFatherName, "txtFatherName")
        Me.txtFatherName.Name = "txtFatherName"
        '
        'LabelX83
        '
        Me.LabelX83.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX83.BackgroundStyle.Class = ""
        Me.LabelX83.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX83, "LabelX83")
        Me.LabelX83.Name = "LabelX83"
        Me.LabelX83.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtDrivePlace
        '
        '
        '
        '
        Me.txtDrivePlace.Border.Class = "TextBoxBorder"
        Me.txtDrivePlace.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtDrivePlace, CType(resources.GetObject("txtDrivePlace.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtDrivePlace, "txtDrivePlace")
        Me.txtDrivePlace.Name = "txtDrivePlace"
        '
        'LabelX79
        '
        Me.LabelX79.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX79.BackgroundStyle.Class = ""
        Me.LabelX79.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX79, "LabelX79")
        Me.LabelX79.Name = "LabelX79"
        Me.LabelX79.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtDriveNo
        '
        '
        '
        '
        Me.txtDriveNo.Border.Class = "TextBoxBorder"
        Me.txtDriveNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtDriveNo, CType(resources.GetObject("txtDriveNo.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtDriveNo, "txtDriveNo")
        Me.txtDriveNo.Name = "txtDriveNo"
        '
        'LabelX78
        '
        Me.LabelX78.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX78.BackgroundStyle.Class = ""
        Me.LabelX78.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX78, "LabelX78")
        Me.LabelX78.Name = "LabelX78"
        Me.LabelX78.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtforeignNo
        '
        '
        '
        '
        Me.txtforeignNo.Border.Class = "TextBoxBorder"
        Me.txtforeignNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtforeignNo, CType(resources.GetObject("txtforeignNo.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtforeignNo, "txtforeignNo")
        Me.txtforeignNo.Name = "txtforeignNo"
        '
        'LabelX77
        '
        Me.LabelX77.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX77.BackgroundStyle.Class = ""
        Me.LabelX77.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX77, "LabelX77")
        Me.LabelX77.Name = "LabelX77"
        Me.LabelX77.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtTelContract
        '
        '
        '
        '
        Me.txtTelContract.Border.Class = "TextBoxBorder"
        Me.txtTelContract.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtTelContract, CType(resources.GetObject("txtTelContract.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtTelContract, "txtTelContract")
        Me.txtTelContract.Name = "txtTelContract"
        '
        'LabelX76
        '
        Me.LabelX76.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX76.BackgroundStyle.Class = ""
        Me.LabelX76.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX76, "LabelX76")
        Me.LabelX76.Name = "LabelX76"
        Me.LabelX76.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX73
        '
        Me.LabelX73.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX73.BackgroundStyle.Class = ""
        Me.LabelX73.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX73, "LabelX73")
        Me.LabelX73.Name = "LabelX73"
        Me.LabelX73.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'TabItem5
        '
        Me.TabItem5.AttachedControl = Me.TabControlPanel5
        Me.TabItem5.Name = "TabItem5"
        resources.ApplyResources(Me.TabItem5, "TabItem5")
        '
        'TabControlPanel6
        '
        Me.TabControlPanel6.Controls.Add(Me.GroupPanel7)
        Me.TabControlPanel6.Controls.Add(Me.GroupPanel6)
        resources.ApplyResources(Me.TabControlPanel6, "TabControlPanel6")
        Me.TabControlPanel6.Name = "TabControlPanel6"
        Me.TabControlPanel6.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel6.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel6.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel6.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel6.Style.GradientAngle = 90
        Me.TabControlPanel6.TabItem = Me.TabItem6
        '
        'GroupPanel7
        '
        Me.GroupPanel7.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel7.Controls.Add(Me.LabelX113)
        Me.GroupPanel7.Controls.Add(Me.lstAdd)
        Me.GroupPanel7.Controls.Add(Me.cmdDelTax)
        Me.GroupPanel7.Controls.Add(Me.cmdAddTax)
        Me.GroupPanel7.Controls.Add(Me.txtMonth_Year)
        Me.GroupPanel7.Controls.Add(Me.LabelX19)
        Me.GroupPanel7.Controls.Add(Me.LabelX106)
        Me.GroupPanel7.Controls.Add(Me.txteRemark)
        Me.GroupPanel7.Controls.Add(Me.LabelX111)
        Me.GroupPanel7.Controls.Add(Me.txteSocTax)
        Me.GroupPanel7.Controls.Add(Me.LabelX110)
        Me.GroupPanel7.Controls.Add(Me.txtGrossSoc)
        Me.GroupPanel7.Controls.Add(Me.LabelX109)
        Me.GroupPanel7.Controls.Add(Me.txtTax)
        Me.GroupPanel7.Controls.Add(Me.LabelX108)
        Me.GroupPanel7.Controls.Add(Me.txtGrossTax)
        Me.GroupPanel7.Controls.Add(Me.LabelX107)
        resources.ApplyResources(Me.GroupPanel7, "GroupPanel7")
        Me.GroupPanel7.Name = "GroupPanel7"
        '
        '
        '
        Me.GroupPanel7.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel7.Style.BackColorGradientAngle = 90
        Me.GroupPanel7.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel7.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderBottomWidth = 1
        Me.GroupPanel7.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel7.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderLeftWidth = 1
        Me.GroupPanel7.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderRightWidth = 1
        Me.GroupPanel7.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderTopWidth = 1
        Me.GroupPanel7.Style.Class = ""
        Me.GroupPanel7.Style.CornerDiameter = 4
        Me.GroupPanel7.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel7.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel7.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel7.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel7.StyleMouseDown.Class = ""
        Me.GroupPanel7.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel7.StyleMouseOver.Class = ""
        Me.GroupPanel7.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'LabelX113
        '
        Me.LabelX113.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.LabelX113.BackgroundStyle.Class = ""
        Me.LabelX113.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX113, "LabelX113")
        Me.LabelX113.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelX113.Name = "LabelX113"
        '
        'lstAdd
        '
        '
        '
        '
        Me.lstAdd.Border.Class = "ListViewBorder"
        Me.lstAdd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lstAdd.CheckBoxes = True
        Me.lstAdd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader8})
        Me.lstAdd.FullRowSelect = True
        Me.lstAdd.GridLines = True
        resources.ApplyResources(Me.lstAdd, "lstAdd")
        Me.lstAdd.MultiSelect = False
        Me.lstAdd.Name = "lstAdd"
        Me.lstAdd.UseCompatibleStateImageBehavior = False
        Me.lstAdd.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        resources.ApplyResources(Me.ColumnHeader1, "ColumnHeader1")
        '
        'ColumnHeader2
        '
        resources.ApplyResources(Me.ColumnHeader2, "ColumnHeader2")
        '
        'ColumnHeader3
        '
        resources.ApplyResources(Me.ColumnHeader3, "ColumnHeader3")
        '
        'ColumnHeader4
        '
        resources.ApplyResources(Me.ColumnHeader4, "ColumnHeader4")
        '
        'ColumnHeader5
        '
        resources.ApplyResources(Me.ColumnHeader5, "ColumnHeader5")
        '
        'ColumnHeader6
        '
        resources.ApplyResources(Me.ColumnHeader6, "ColumnHeader6")
        '
        'ColumnHeader8
        '
        resources.ApplyResources(Me.ColumnHeader8, "ColumnHeader8")
        '
        'cmdDelTax
        '
        Me.cmdDelTax.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdDelTax.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.cmdDelTax, "cmdDelTax")
        Me.cmdDelTax.Name = "cmdDelTax"
        Me.cmdDelTax.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cmdAddTax
        '
        Me.cmdAddTax.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAddTax.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.cmdAddTax, "cmdAddTax")
        Me.cmdAddTax.Name = "cmdAddTax"
        Me.cmdAddTax.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'txtMonth_Year
        '
        resources.ApplyResources(Me.txtMonth_Year, "txtMonth_Year")
        Me.txtMonth_Year.Name = "txtMonth_Year"
        '
        'LabelX19
        '
        Me.LabelX19.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX19.BackgroundStyle.Class = ""
        Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        resources.ApplyResources(Me.LabelX19, "LabelX19")
        Me.LabelX19.Name = "LabelX19"
        '
        'LabelX106
        '
        Me.LabelX106.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX106.BackgroundStyle.Class = ""
        Me.LabelX106.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX106, "LabelX106")
        Me.LabelX106.Name = "LabelX106"
        Me.LabelX106.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txteRemark
        '
        '
        '
        '
        Me.txteRemark.Border.Class = "TextBoxBorder"
        Me.txteRemark.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txteRemark, CType(resources.GetObject("txteRemark.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txteRemark, "txteRemark")
        Me.txteRemark.Name = "txteRemark"
        '
        'LabelX111
        '
        Me.LabelX111.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX111.BackgroundStyle.Class = ""
        Me.LabelX111.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX111, "LabelX111")
        Me.LabelX111.Name = "LabelX111"
        Me.LabelX111.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txteSocTax
        '
        '
        '
        '
        Me.txteSocTax.Border.Class = "TextBoxBorder"
        Me.txteSocTax.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txteSocTax, CType(resources.GetObject("txteSocTax.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txteSocTax, "txteSocTax")
        Me.txteSocTax.Name = "txteSocTax"
        '
        'LabelX110
        '
        Me.LabelX110.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX110.BackgroundStyle.Class = ""
        Me.LabelX110.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX110, "LabelX110")
        Me.LabelX110.Name = "LabelX110"
        Me.LabelX110.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtGrossSoc
        '
        '
        '
        '
        Me.txtGrossSoc.Border.Class = "TextBoxBorder"
        Me.txtGrossSoc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtGrossSoc, CType(resources.GetObject("txtGrossSoc.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtGrossSoc, "txtGrossSoc")
        Me.txtGrossSoc.Name = "txtGrossSoc"
        '
        'LabelX109
        '
        Me.LabelX109.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX109.BackgroundStyle.Class = ""
        Me.LabelX109.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX109, "LabelX109")
        Me.LabelX109.Name = "LabelX109"
        Me.LabelX109.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtTax
        '
        '
        '
        '
        Me.txtTax.Border.Class = "TextBoxBorder"
        Me.txtTax.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtTax, CType(resources.GetObject("txtTax.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtTax, "txtTax")
        Me.txtTax.Name = "txtTax"
        '
        'LabelX108
        '
        Me.LabelX108.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX108.BackgroundStyle.Class = ""
        Me.LabelX108.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX108, "LabelX108")
        Me.LabelX108.Name = "LabelX108"
        Me.LabelX108.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtGrossTax
        '
        '
        '
        '
        Me.txtGrossTax.Border.Class = "TextBoxBorder"
        Me.txtGrossTax.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtGrossTax, CType(resources.GetObject("txtGrossTax.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtGrossTax, "txtGrossTax")
        Me.txtGrossTax.Name = "txtGrossTax"
        '
        'LabelX107
        '
        Me.LabelX107.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX107.BackgroundStyle.Class = ""
        Me.LabelX107.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX107, "LabelX107")
        Me.LabelX107.Name = "LabelX107"
        Me.LabelX107.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'GroupPanel6
        '
        Me.GroupPanel6.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel6.Controls.Add(Me.LabelX112)
        Me.GroupPanel6.Controls.Add(Me.lstMonthly)
        Me.GroupPanel6.Controls.Add(Me.cboYear)
        Me.GroupPanel6.Controls.Add(Me.LabelX98)
        Me.GroupPanel6.Controls.Add(Me.lblAccuPFAll)
        Me.GroupPanel6.Controls.Add(Me.LabelX105)
        Me.GroupPanel6.Controls.Add(Me.lblAccuPF)
        Me.GroupPanel6.Controls.Add(Me.LabelX104)
        Me.GroupPanel6.Controls.Add(Me.lblAccSocTax)
        Me.GroupPanel6.Controls.Add(Me.LabelX103)
        Me.GroupPanel6.Controls.Add(Me.lblAccGrossSoc)
        Me.GroupPanel6.Controls.Add(Me.LabelX102)
        Me.GroupPanel6.Controls.Add(Me.lblAccTax)
        Me.GroupPanel6.Controls.Add(Me.LabelX101)
        Me.GroupPanel6.Controls.Add(Me.lblAccBonus)
        Me.GroupPanel6.Controls.Add(Me.LabelX100)
        Me.GroupPanel6.Controls.Add(Me.lblAccGrossTax)
        Me.GroupPanel6.Controls.Add(Me.LabelX99)
        resources.ApplyResources(Me.GroupPanel6, "GroupPanel6")
        Me.GroupPanel6.Name = "GroupPanel6"
        '
        '
        '
        Me.GroupPanel6.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel6.Style.BackColorGradientAngle = 90
        Me.GroupPanel6.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel6.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderBottomWidth = 1
        Me.GroupPanel6.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel6.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderLeftWidth = 1
        Me.GroupPanel6.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderRightWidth = 1
        Me.GroupPanel6.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderTopWidth = 1
        Me.GroupPanel6.Style.Class = ""
        Me.GroupPanel6.Style.CornerDiameter = 4
        Me.GroupPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel6.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel6.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel6.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel6.StyleMouseDown.Class = ""
        Me.GroupPanel6.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel6.StyleMouseOver.Class = ""
        Me.GroupPanel6.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'LabelX112
        '
        Me.LabelX112.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.LabelX112.BackgroundStyle.Class = ""
        Me.LabelX112.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX112, "LabelX112")
        Me.LabelX112.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelX112.Name = "LabelX112"
        '
        'lstMonthly
        '
        '
        '
        '
        Me.lstMonthly.Border.Class = "ListViewBorder"
        Me.lstMonthly.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lstMonthly.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColNo_, Me.ColMonth, Me.colVatCal, Me.ColVat, Me.ColPricePKS, Me.ColPKS})
        Me.lstMonthly.FullRowSelect = True
        Me.lstMonthly.GridLines = True
        resources.ApplyResources(Me.lstMonthly, "lstMonthly")
        Me.lstMonthly.MultiSelect = False
        Me.lstMonthly.Name = "lstMonthly"
        Me.lstMonthly.UseCompatibleStateImageBehavior = False
        Me.lstMonthly.View = System.Windows.Forms.View.Details
        '
        'ColNo_
        '
        resources.ApplyResources(Me.ColNo_, "ColNo_")
        '
        'ColMonth
        '
        resources.ApplyResources(Me.ColMonth, "ColMonth")
        '
        'colVatCal
        '
        resources.ApplyResources(Me.colVatCal, "colVatCal")
        '
        'ColVat
        '
        resources.ApplyResources(Me.ColVat, "ColVat")
        '
        'ColPricePKS
        '
        resources.ApplyResources(Me.ColPricePKS, "ColPricePKS")
        '
        'ColPKS
        '
        resources.ApplyResources(Me.ColPKS, "ColPKS")
        '
        'cboYear
        '
        Me.cboYear.DisplayMember = "Text"
        Me.cboYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboYear.FormattingEnabled = True
        resources.ApplyResources(Me.cboYear, "cboYear")
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'LabelX98
        '
        Me.LabelX98.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX98.BackgroundStyle.Class = ""
        Me.LabelX98.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX98, "LabelX98")
        Me.LabelX98.Name = "LabelX98"
        Me.LabelX98.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblAccuPFAll
        '
        '
        '
        '
        Me.lblAccuPFAll.Border.Class = "TextBoxBorder"
        Me.lblAccuPFAll.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.lblAccuPFAll, CType(resources.GetObject("lblAccuPFAll.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.lblAccuPFAll, "lblAccuPFAll")
        Me.lblAccuPFAll.Name = "lblAccuPFAll"
        Me.lblAccuPFAll.ReadOnly = True
        '
        'LabelX105
        '
        Me.LabelX105.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX105.BackgroundStyle.Class = ""
        Me.LabelX105.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX105, "LabelX105")
        Me.LabelX105.Name = "LabelX105"
        Me.LabelX105.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblAccuPF
        '
        '
        '
        '
        Me.lblAccuPF.Border.Class = "TextBoxBorder"
        Me.lblAccuPF.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.lblAccuPF, CType(resources.GetObject("lblAccuPF.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.lblAccuPF, "lblAccuPF")
        Me.lblAccuPF.Name = "lblAccuPF"
        Me.lblAccuPF.ReadOnly = True
        '
        'LabelX104
        '
        Me.LabelX104.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX104.BackgroundStyle.Class = ""
        Me.LabelX104.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX104, "LabelX104")
        Me.LabelX104.Name = "LabelX104"
        Me.LabelX104.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblAccSocTax
        '
        '
        '
        '
        Me.lblAccSocTax.Border.Class = "TextBoxBorder"
        Me.lblAccSocTax.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.lblAccSocTax, CType(resources.GetObject("lblAccSocTax.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.lblAccSocTax, "lblAccSocTax")
        Me.lblAccSocTax.Name = "lblAccSocTax"
        Me.lblAccSocTax.ReadOnly = True
        '
        'LabelX103
        '
        Me.LabelX103.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX103.BackgroundStyle.Class = ""
        Me.LabelX103.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX103, "LabelX103")
        Me.LabelX103.Name = "LabelX103"
        Me.LabelX103.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblAccGrossSoc
        '
        '
        '
        '
        Me.lblAccGrossSoc.Border.Class = "TextBoxBorder"
        Me.lblAccGrossSoc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.lblAccGrossSoc, CType(resources.GetObject("lblAccGrossSoc.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.lblAccGrossSoc, "lblAccGrossSoc")
        Me.lblAccGrossSoc.Name = "lblAccGrossSoc"
        Me.lblAccGrossSoc.ReadOnly = True
        '
        'LabelX102
        '
        Me.LabelX102.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX102.BackgroundStyle.Class = ""
        Me.LabelX102.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX102, "LabelX102")
        Me.LabelX102.Name = "LabelX102"
        Me.LabelX102.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblAccTax
        '
        '
        '
        '
        Me.lblAccTax.Border.Class = "TextBoxBorder"
        Me.lblAccTax.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.lblAccTax, CType(resources.GetObject("lblAccTax.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.lblAccTax, "lblAccTax")
        Me.lblAccTax.Name = "lblAccTax"
        Me.lblAccTax.ReadOnly = True
        '
        'LabelX101
        '
        Me.LabelX101.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX101.BackgroundStyle.Class = ""
        Me.LabelX101.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX101, "LabelX101")
        Me.LabelX101.Name = "LabelX101"
        Me.LabelX101.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblAccBonus
        '
        '
        '
        '
        Me.lblAccBonus.Border.Class = "TextBoxBorder"
        Me.lblAccBonus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.lblAccBonus, CType(resources.GetObject("lblAccBonus.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.lblAccBonus, "lblAccBonus")
        Me.lblAccBonus.Name = "lblAccBonus"
        Me.lblAccBonus.ReadOnly = True
        '
        'LabelX100
        '
        Me.LabelX100.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX100.BackgroundStyle.Class = ""
        Me.LabelX100.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX100, "LabelX100")
        Me.LabelX100.Name = "LabelX100"
        Me.LabelX100.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblAccGrossTax
        '
        '
        '
        '
        Me.lblAccGrossTax.Border.Class = "TextBoxBorder"
        Me.lblAccGrossTax.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.lblAccGrossTax, CType(resources.GetObject("lblAccGrossTax.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.lblAccGrossTax, "lblAccGrossTax")
        Me.lblAccGrossTax.Name = "lblAccGrossTax"
        Me.lblAccGrossTax.ReadOnly = True
        '
        'LabelX99
        '
        Me.LabelX99.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX99.BackgroundStyle.Class = ""
        Me.LabelX99.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX99, "LabelX99")
        Me.LabelX99.Name = "LabelX99"
        Me.LabelX99.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'TabItem6
        '
        Me.TabItem6.AttachedControl = Me.TabControlPanel6
        Me.TabItem6.Name = "TabItem6"
        resources.ApplyResources(Me.TabItem6, "TabItem6")
        '
        'TabControlPanel7
        '
        Me.TabControlPanel7.Controls.Add(Me.GroupPanel13)
        Me.TabControlPanel7.Controls.Add(Me.GroupPanel11)
        resources.ApplyResources(Me.TabControlPanel7, "TabControlPanel7")
        Me.TabControlPanel7.Name = "TabControlPanel7"
        Me.TabControlPanel7.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel7.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel7.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel7.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel7.Style.GradientAngle = 90
        Me.TabControlPanel7.TabItem = Me.TabItem7
        '
        'GroupPanel13
        '
        Me.GroupPanel13.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel13.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel13.Controls.Add(Me.cmdPP_Refresh)
        Me.GroupPanel13.Controls.Add(Me.cmdPP_Delete)
        Me.GroupPanel13.Controls.Add(Me.txtpp_Experieddate)
        Me.GroupPanel13.Controls.Add(Me.cmdPP_Edit)
        Me.GroupPanel13.Controls.Add(Me.lstPassport)
        Me.GroupPanel13.Controls.Add(Me.cmdPP_Add)
        Me.GroupPanel13.Controls.Add(Me.txtpp_Issueddate)
        Me.GroupPanel13.Controls.Add(Me.GroupPanel14)
        Me.GroupPanel13.Controls.Add(Me.lblPassportId)
        Me.GroupPanel13.Controls.Add(Me.LabelX118)
        Me.GroupPanel13.Controls.Add(Me.txtpp_NO)
        Me.GroupPanel13.Controls.Add(Me.LabelX120)
        Me.GroupPanel13.Controls.Add(Me.LabelX119)
        resources.ApplyResources(Me.GroupPanel13, "GroupPanel13")
        Me.GroupPanel13.Name = "GroupPanel13"
        '
        '
        '
        Me.GroupPanel13.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel13.Style.BackColorGradientAngle = 90
        Me.GroupPanel13.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel13.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel13.Style.BorderBottomWidth = 1
        Me.GroupPanel13.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel13.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel13.Style.BorderLeftWidth = 1
        Me.GroupPanel13.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel13.Style.BorderRightWidth = 1
        Me.GroupPanel13.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel13.Style.BorderTopWidth = 1
        Me.GroupPanel13.Style.Class = ""
        Me.GroupPanel13.Style.CornerDiameter = 4
        Me.GroupPanel13.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel13.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel13.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel13.StyleMouseDown.Class = ""
        Me.GroupPanel13.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel13.StyleMouseOver.Class = ""
        Me.GroupPanel13.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'cmdPP_Refresh
        '
        Me.cmdPP_Refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdPP_Refresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.cmdPP_Refresh, "cmdPP_Refresh")
        Me.cmdPP_Refresh.Name = "cmdPP_Refresh"
        Me.cmdPP_Refresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cmdPP_Delete
        '
        Me.cmdPP_Delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdPP_Delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.cmdPP_Delete, "cmdPP_Delete")
        Me.cmdPP_Delete.Name = "cmdPP_Delete"
        Me.cmdPP_Delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'txtpp_Experieddate
        '
        resources.ApplyResources(Me.txtpp_Experieddate, "txtpp_Experieddate")
        Me.txtpp_Experieddate.Name = "txtpp_Experieddate"
        '
        'cmdPP_Edit
        '
        Me.cmdPP_Edit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdPP_Edit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.cmdPP_Edit, "cmdPP_Edit")
        Me.cmdPP_Edit.Name = "cmdPP_Edit"
        Me.cmdPP_Edit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'lstPassport
        '
        '
        '
        '
        Me.lstPassport.Border.Class = "ListViewBorder"
        Me.lstPassport.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lstPassport.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColPassportNo, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader16, Me.ColumnHeader17})
        Me.lstPassport.FullRowSelect = True
        Me.lstPassport.GridLines = True
        resources.ApplyResources(Me.lstPassport, "lstPassport")
        Me.lstPassport.MultiSelect = False
        Me.lstPassport.Name = "lstPassport"
        Me.lstPassport.UseCompatibleStateImageBehavior = False
        Me.lstPassport.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        resources.ApplyResources(Me.ColumnHeader11, "ColumnHeader11")
        '
        'ColPassportNo
        '
        resources.ApplyResources(Me.ColPassportNo, "ColPassportNo")
        '
        'ColumnHeader13
        '
        resources.ApplyResources(Me.ColumnHeader13, "ColumnHeader13")
        '
        'ColumnHeader14
        '
        resources.ApplyResources(Me.ColumnHeader14, "ColumnHeader14")
        '
        'ColumnHeader16
        '
        resources.ApplyResources(Me.ColumnHeader16, "ColumnHeader16")
        '
        'ColumnHeader17
        '
        resources.ApplyResources(Me.ColumnHeader17, "ColumnHeader17")
        '
        'cmdPP_Add
        '
        Me.cmdPP_Add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdPP_Add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.cmdPP_Add, "cmdPP_Add")
        Me.cmdPP_Add.Name = "cmdPP_Add"
        Me.cmdPP_Add.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'txtpp_Issueddate
        '
        resources.ApplyResources(Me.txtpp_Issueddate, "txtpp_Issueddate")
        Me.txtpp_Issueddate.Name = "txtpp_Issueddate"
        '
        'GroupPanel14
        '
        Me.GroupPanel14.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel14.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel14.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel14.Controls.Add(Me.optPP_Multiple)
        Me.GroupPanel14.Controls.Add(Me.optPP_NoneB)
        resources.ApplyResources(Me.GroupPanel14, "GroupPanel14")
        Me.GroupPanel14.Name = "GroupPanel14"
        '
        '
        '
        Me.GroupPanel14.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel14.Style.BackColorGradientAngle = 90
        Me.GroupPanel14.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel14.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel14.Style.BorderBottomWidth = 1
        Me.GroupPanel14.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel14.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel14.Style.BorderLeftWidth = 1
        Me.GroupPanel14.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel14.Style.BorderRightWidth = 1
        Me.GroupPanel14.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel14.Style.BorderTopWidth = 1
        Me.GroupPanel14.Style.Class = ""
        Me.GroupPanel14.Style.CornerDiameter = 4
        Me.GroupPanel14.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel14.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        '
        '
        '
        Me.GroupPanel14.StyleMouseDown.Class = ""
        Me.GroupPanel14.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel14.StyleMouseOver.Class = ""
        Me.GroupPanel14.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'optPP_Multiple
        '
        Me.optPP_Multiple.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.optPP_Multiple.BackgroundStyle.Class = ""
        Me.optPP_Multiple.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.optPP_Multiple.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        resources.ApplyResources(Me.optPP_Multiple, "optPP_Multiple")
        Me.optPP_Multiple.Name = "optPP_Multiple"
        Me.optPP_Multiple.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'optPP_NoneB
        '
        Me.optPP_NoneB.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.optPP_NoneB.BackgroundStyle.Class = ""
        Me.optPP_NoneB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.optPP_NoneB.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.optPP_NoneB.Checked = True
        Me.optPP_NoneB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optPP_NoneB.CheckValue = "Y"
        resources.ApplyResources(Me.optPP_NoneB, "optPP_NoneB")
        Me.optPP_NoneB.Name = "optPP_NoneB"
        Me.optPP_NoneB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'lblPassportId
        '
        Me.lblPassportId.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblPassportId.BackgroundStyle.Class = ""
        Me.lblPassportId.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.lblPassportId, "lblPassportId")
        Me.lblPassportId.Name = "lblPassportId"
        Me.lblPassportId.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX118
        '
        Me.LabelX118.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX118.BackgroundStyle.Class = ""
        Me.LabelX118.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX118, "LabelX118")
        Me.LabelX118.Name = "LabelX118"
        Me.LabelX118.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtpp_NO
        '
        '
        '
        '
        Me.txtpp_NO.Border.Class = "TextBoxBorder"
        Me.txtpp_NO.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.txtpp_NO, "txtpp_NO")
        Me.Highlighter1.SetHighlightOnFocus(Me.txtpp_NO, CType(resources.GetObject("txtpp_NO.HighlightOnFocus"), Boolean))
        Me.txtpp_NO.Name = "txtpp_NO"
        '
        'LabelX120
        '
        Me.LabelX120.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX120.BackgroundStyle.Class = ""
        Me.LabelX120.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX120, "LabelX120")
        Me.LabelX120.Name = "LabelX120"
        Me.LabelX120.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX119
        '
        Me.LabelX119.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX119.BackgroundStyle.Class = ""
        Me.LabelX119.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX119, "LabelX119")
        Me.LabelX119.Name = "LabelX119"
        Me.LabelX119.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'GroupPanel11
        '
        Me.GroupPanel11.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel11.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel11.Controls.Add(Me.cmdVisa_Refresh)
        Me.GroupPanel11.Controls.Add(Me.cmdVisa_Delete)
        Me.GroupPanel11.Controls.Add(Me.cmdVisa_Edit)
        Me.GroupPanel11.Controls.Add(Me.cmdVisa_Add)
        Me.GroupPanel11.Controls.Add(Me.txtVisa_ExperiedDate)
        Me.GroupPanel11.Controls.Add(Me.txtVisa_IssuedDate)
        Me.GroupPanel11.Controls.Add(Me.lstVisa)
        Me.GroupPanel11.Controls.Add(Me.GroupPanel12)
        Me.GroupPanel11.Controls.Add(Me.lblVisa_Id)
        Me.GroupPanel11.Controls.Add(Me.LabelX116)
        Me.GroupPanel11.Controls.Add(Me.LabelX117)
        resources.ApplyResources(Me.GroupPanel11, "GroupPanel11")
        Me.GroupPanel11.Name = "GroupPanel11"
        '
        '
        '
        Me.GroupPanel11.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel11.Style.BackColorGradientAngle = 90
        Me.GroupPanel11.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel11.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel11.Style.BorderBottomWidth = 1
        Me.GroupPanel11.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel11.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel11.Style.BorderLeftWidth = 1
        Me.GroupPanel11.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel11.Style.BorderRightWidth = 1
        Me.GroupPanel11.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel11.Style.BorderTopWidth = 1
        Me.GroupPanel11.Style.Class = ""
        Me.GroupPanel11.Style.CornerDiameter = 4
        Me.GroupPanel11.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel11.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel11.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel11.StyleMouseDown.Class = ""
        Me.GroupPanel11.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel11.StyleMouseOver.Class = ""
        Me.GroupPanel11.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'cmdVisa_Refresh
        '
        Me.cmdVisa_Refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdVisa_Refresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.cmdVisa_Refresh, "cmdVisa_Refresh")
        Me.cmdVisa_Refresh.Name = "cmdVisa_Refresh"
        Me.cmdVisa_Refresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cmdVisa_Delete
        '
        Me.cmdVisa_Delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdVisa_Delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.cmdVisa_Delete, "cmdVisa_Delete")
        Me.cmdVisa_Delete.Name = "cmdVisa_Delete"
        Me.cmdVisa_Delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cmdVisa_Edit
        '
        Me.cmdVisa_Edit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdVisa_Edit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.cmdVisa_Edit, "cmdVisa_Edit")
        Me.cmdVisa_Edit.Name = "cmdVisa_Edit"
        Me.cmdVisa_Edit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cmdVisa_Add
        '
        Me.cmdVisa_Add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdVisa_Add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.cmdVisa_Add, "cmdVisa_Add")
        Me.cmdVisa_Add.Name = "cmdVisa_Add"
        Me.cmdVisa_Add.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'txtVisa_ExperiedDate
        '
        resources.ApplyResources(Me.txtVisa_ExperiedDate, "txtVisa_ExperiedDate")
        Me.txtVisa_ExperiedDate.Name = "txtVisa_ExperiedDate"
        '
        'txtVisa_IssuedDate
        '
        resources.ApplyResources(Me.txtVisa_IssuedDate, "txtVisa_IssuedDate")
        Me.txtVisa_IssuedDate.Name = "txtVisa_IssuedDate"
        '
        'lstVisa
        '
        '
        '
        '
        Me.lstVisa.Border.Class = "ListViewBorder"
        Me.lstVisa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lstVisa.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.CalId, Me.ColIssuedDate, Me.ColExperiedDate, Me.CalTypeOfVisa, Me.ColTypeMultiple})
        Me.lstVisa.FullRowSelect = True
        Me.lstVisa.GridLines = True
        resources.ApplyResources(Me.lstVisa, "lstVisa")
        Me.lstVisa.MultiSelect = False
        Me.lstVisa.Name = "lstVisa"
        Me.lstVisa.UseCompatibleStateImageBehavior = False
        Me.lstVisa.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        resources.ApplyResources(Me.ColumnHeader10, "ColumnHeader10")
        '
        'CalId
        '
        resources.ApplyResources(Me.CalId, "CalId")
        '
        'ColIssuedDate
        '
        resources.ApplyResources(Me.ColIssuedDate, "ColIssuedDate")
        '
        'ColExperiedDate
        '
        resources.ApplyResources(Me.ColExperiedDate, "ColExperiedDate")
        '
        'CalTypeOfVisa
        '
        resources.ApplyResources(Me.CalTypeOfVisa, "CalTypeOfVisa")
        '
        'ColTypeMultiple
        '
        resources.ApplyResources(Me.ColTypeMultiple, "ColTypeMultiple")
        '
        'GroupPanel12
        '
        Me.GroupPanel12.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel12.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel12.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel12.Controls.Add(Me.optVisa_Multiple)
        Me.GroupPanel12.Controls.Add(Me.optVisa_NoneB)
        resources.ApplyResources(Me.GroupPanel12, "GroupPanel12")
        Me.GroupPanel12.Name = "GroupPanel12"
        '
        '
        '
        Me.GroupPanel12.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel12.Style.BackColorGradientAngle = 90
        Me.GroupPanel12.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel12.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel12.Style.BorderBottomWidth = 1
        Me.GroupPanel12.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel12.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel12.Style.BorderLeftWidth = 1
        Me.GroupPanel12.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel12.Style.BorderRightWidth = 1
        Me.GroupPanel12.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel12.Style.BorderTopWidth = 1
        Me.GroupPanel12.Style.Class = ""
        Me.GroupPanel12.Style.CornerDiameter = 4
        Me.GroupPanel12.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel12.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel12.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel12.StyleMouseDown.Class = ""
        Me.GroupPanel12.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel12.StyleMouseOver.Class = ""
        Me.GroupPanel12.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'optVisa_Multiple
        '
        Me.optVisa_Multiple.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.optVisa_Multiple.BackgroundStyle.Class = ""
        Me.optVisa_Multiple.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.optVisa_Multiple.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        resources.ApplyResources(Me.optVisa_Multiple, "optVisa_Multiple")
        Me.optVisa_Multiple.Name = "optVisa_Multiple"
        Me.optVisa_Multiple.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'optVisa_NoneB
        '
        Me.optVisa_NoneB.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.optVisa_NoneB.BackgroundStyle.Class = ""
        Me.optVisa_NoneB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.optVisa_NoneB.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.optVisa_NoneB.Checked = True
        Me.optVisa_NoneB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optVisa_NoneB.CheckValue = "Y"
        resources.ApplyResources(Me.optVisa_NoneB, "optVisa_NoneB")
        Me.optVisa_NoneB.Name = "optVisa_NoneB"
        Me.optVisa_NoneB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'lblVisa_Id
        '
        Me.lblVisa_Id.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblVisa_Id.BackgroundStyle.Class = ""
        Me.lblVisa_Id.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.lblVisa_Id, "lblVisa_Id")
        Me.lblVisa_Id.Name = "lblVisa_Id"
        Me.lblVisa_Id.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX116
        '
        Me.LabelX116.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX116.BackgroundStyle.Class = ""
        Me.LabelX116.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX116, "LabelX116")
        Me.LabelX116.Name = "LabelX116"
        Me.LabelX116.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX117
        '
        Me.LabelX117.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX117.BackgroundStyle.Class = ""
        Me.LabelX117.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX117, "LabelX117")
        Me.LabelX117.Name = "LabelX117"
        Me.LabelX117.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'TabItem7
        '
        Me.TabItem7.AttachedControl = Me.TabControlPanel7
        Me.TabItem7.Name = "TabItem7"
        resources.ApplyResources(Me.TabItem7, "TabItem7")
        '
        'TabControlPanel9
        '
        Me.TabControlPanel9.Controls.Add(Me.GroupPanel8)
        resources.ApplyResources(Me.TabControlPanel9, "TabControlPanel9")
        Me.TabControlPanel9.Name = "TabControlPanel9"
        Me.TabControlPanel9.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel9.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel9.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel9.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel9.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel9.Style.GradientAngle = 90
        Me.TabControlPanel9.TabItem = Me.TabItem9
        '
        'GroupPanel8
        '
        Me.GroupPanel8.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel8.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel8.Controls.Add(Me.chkCalOtDeduc)
        Me.GroupPanel8.Controls.Add(Me.chkCalLate)
        Me.GroupPanel8.Controls.Add(Me.cboOt)
        Me.GroupPanel8.Controls.Add(Me.LabelX114)
        resources.ApplyResources(Me.GroupPanel8, "GroupPanel8")
        Me.GroupPanel8.Name = "GroupPanel8"
        '
        '
        '
        Me.GroupPanel8.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel8.Style.BackColorGradientAngle = 90
        Me.GroupPanel8.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel8.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel8.Style.BorderBottomWidth = 1
        Me.GroupPanel8.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel8.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel8.Style.BorderLeftWidth = 1
        Me.GroupPanel8.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel8.Style.BorderRightWidth = 1
        Me.GroupPanel8.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel8.Style.BorderTopWidth = 1
        Me.GroupPanel8.Style.Class = ""
        Me.GroupPanel8.Style.CornerDiameter = 4
        Me.GroupPanel8.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel8.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel8.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel8.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel8.StyleMouseDown.Class = ""
        Me.GroupPanel8.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel8.StyleMouseOver.Class = ""
        Me.GroupPanel8.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'chkCalOtDeduc
        '
        Me.chkCalOtDeduc.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkCalOtDeduc.BackgroundStyle.Class = ""
        Me.chkCalOtDeduc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.chkCalOtDeduc, "chkCalOtDeduc")
        Me.chkCalOtDeduc.Name = "chkCalOtDeduc"
        Me.chkCalOtDeduc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'chkCalLate
        '
        Me.chkCalLate.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkCalLate.BackgroundStyle.Class = ""
        Me.chkCalLate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.chkCalLate, "chkCalLate")
        Me.chkCalLate.Name = "chkCalLate"
        Me.chkCalLate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cboOt
        '
        Me.cboOt.DisplayMember = "Text"
        Me.cboOt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboOt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOt.FormattingEnabled = True
        resources.ApplyResources(Me.cboOt, "cboOt")
        Me.cboOt.Items.AddRange(New Object() {Me.ComboItem39, Me.ComboItem40})
        Me.cboOt.Name = "cboOt"
        Me.cboOt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ComboItem39
        '
        resources.ApplyResources(Me.ComboItem39, "ComboItem39")
        '
        'ComboItem40
        '
        resources.ApplyResources(Me.ComboItem40, "ComboItem40")
        '
        'LabelX114
        '
        Me.LabelX114.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX114.BackgroundStyle.Class = ""
        Me.LabelX114.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX114, "LabelX114")
        Me.LabelX114.Name = "LabelX114"
        Me.LabelX114.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'TabItem9
        '
        Me.TabItem9.AttachedControl = Me.TabControlPanel9
        Me.TabItem9.Name = "TabItem9"
        resources.ApplyResources(Me.TabItem9, "TabItem9")
        '
        'TabControlPanel10
        '
        Me.TabControlPanel10.Controls.Add(Me.GroupPanel16)
        resources.ApplyResources(Me.TabControlPanel10, "TabControlPanel10")
        Me.TabControlPanel10.Name = "TabControlPanel10"
        Me.TabControlPanel10.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel10.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel10.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel10.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel10.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel10.Style.GradientAngle = 90
        Me.TabControlPanel10.TabItem = Me.TabMoveToEmpOut
        '
        'GroupPanel16
        '
        resources.ApplyResources(Me.GroupPanel16, "GroupPanel16")
        Me.GroupPanel16.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel16.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel16.Controls.Add(Me.cmdCancel)
        Me.GroupPanel16.Controls.Add(Me.cmdConfirm)
        Me.GroupPanel16.Controls.Add(Me.txtTermiDate_Move)
        Me.GroupPanel16.Controls.Add(Me.LabelX121)
        Me.GroupPanel16.Name = "GroupPanel16"
        '
        '
        '
        Me.GroupPanel16.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel16.Style.BackColorGradientAngle = 90
        Me.GroupPanel16.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel16.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel16.Style.BorderBottomWidth = 1
        Me.GroupPanel16.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel16.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel16.Style.BorderLeftWidth = 1
        Me.GroupPanel16.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel16.Style.BorderRightWidth = 1
        Me.GroupPanel16.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel16.Style.BorderTopWidth = 1
        Me.GroupPanel16.Style.Class = ""
        Me.GroupPanel16.Style.CornerDiameter = 4
        Me.GroupPanel16.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel16.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel16.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel16.StyleMouseDown.Class = ""
        Me.GroupPanel16.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel16.StyleMouseOver.Class = ""
        Me.GroupPanel16.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'cmdCancel
        '
        Me.cmdCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.cmdCancel, "cmdCancel")
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cmdConfirm
        '
        Me.cmdConfirm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdConfirm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.cmdConfirm, "cmdConfirm")
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'txtTermiDate_Move
        '
        resources.ApplyResources(Me.txtTermiDate_Move, "txtTermiDate_Move")
        Me.txtTermiDate_Move.Name = "txtTermiDate_Move"
        '
        'LabelX121
        '
        Me.LabelX121.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX121.BackgroundStyle.Class = ""
        Me.LabelX121.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX121, "LabelX121")
        Me.LabelX121.Name = "LabelX121"
        Me.LabelX121.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'TabMoveToEmpOut
        '
        Me.TabMoveToEmpOut.AttachedControl = Me.TabControlPanel10
        Me.TabMoveToEmpOut.Name = "TabMoveToEmpOut"
        resources.ApplyResources(Me.TabMoveToEmpOut, "TabMoveToEmpOut")
        '
        'GroupBox2
        '
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblCurRecord)
        Me.GroupBox2.Controls.Add(Me.cmdNext)
        Me.GroupBox2.Controls.Add(Me.cmdPrevious)
        Me.GroupBox2.Controls.Add(Me.cmdDeptBrowse)
        Me.GroupBox2.Controls.Add(Me.btnSection)
        Me.GroupBox2.Controls.Add(Me.cmdDivBrowse)
        Me.GroupBox2.Controls.Add(Me.cboTitleEng)
        Me.GroupBox2.Controls.Add(Me.cboTitle)
        Me.GroupBox2.Controls.Add(Me.LabelX8)
        Me.GroupBox2.Controls.Add(Me.LabelX10)
        Me.GroupBox2.Controls.Add(Me.LabelX12)
        Me.GroupBox2.Controls.Add(Me.LabelX14)
        Me.GroupBox2.Controls.Add(Me.LabelX16)
        Me.GroupBox2.Controls.Add(Me.LabelX15)
        Me.GroupBox2.Controls.Add(Me.LabelX13)
        Me.GroupBox2.Controls.Add(Me.LabelX11)
        Me.GroupBox2.Controls.Add(Me.LabelX9)
        Me.GroupBox2.Controls.Add(Me.LabelX7)
        Me.GroupBox2.Controls.Add(Me.LabelX17)
        Me.GroupBox2.Controls.Add(Me.LabelX6)
        Me.GroupBox2.Controls.Add(Me.LabelX4)
        Me.GroupBox2.Controls.Add(Me.txtAccountCode)
        Me.GroupBox2.Controls.Add(Me.txtLname)
        Me.GroupBox2.Controls.Add(Me.txtLnameEng)
        Me.GroupBox2.Controls.Add(Me.txtWorkingPlace)
        Me.GroupBox2.Controls.Add(Me.txtPosition)
        Me.GroupBox2.Controls.Add(Me.txtSecId_Det)
        Me.GroupBox2.Controls.Add(Me.txtDepartment)
        Me.GroupBox2.Controls.Add(Me.txtDeptId)
        Me.GroupBox2.Controls.Add(Me.txtSection_Det)
        Me.GroupBox2.Controls.Add(Me.txtDivision)
        Me.GroupBox2.Controls.Add(Me.txtDivID)
        Me.GroupBox2.Controls.Add(Me.txtNickName)
        Me.GroupBox2.Controls.Add(Me.txtFnameEng)
        Me.GroupBox2.Controls.Add(Me.txtCode_D)
        Me.GroupBox2.Controls.Add(Me.txtBarcode)
        Me.GroupBox2.Controls.Add(Me.txtFname_Det)
        Me.GroupBox2.Controls.Add(Me.LabelX18)
        Me.GroupBox2.Controls.Add(Me.lblWorkStatus)
        Me.GroupBox2.Controls.Add(Me.LabelX5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'lblCurRecord
        '
        '
        '
        '
        Me.lblCurRecord.BackgroundStyle.Class = ""
        Me.lblCurRecord.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.lblCurRecord, "lblCurRecord")
        Me.lblCurRecord.Name = "lblCurRecord"
        '
        'cmdNext
        '
        Me.cmdNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.cmdNext, "cmdNext")
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cmdPrevious
        '
        Me.cmdPrevious.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdPrevious.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.cmdPrevious, "cmdPrevious")
        Me.cmdPrevious.Name = "cmdPrevious"
        Me.cmdPrevious.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cmdDeptBrowse
        '
        Me.cmdDeptBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdDeptBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.cmdDeptBrowse, "cmdDeptBrowse")
        Me.cmdDeptBrowse.Name = "cmdDeptBrowse"
        Me.cmdDeptBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'btnSection
        '
        Me.btnSection.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSection.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.btnSection, "btnSection")
        Me.btnSection.Name = "btnSection"
        Me.btnSection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cmdDivBrowse
        '
        Me.cmdDivBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdDivBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.cmdDivBrowse, "cmdDivBrowse")
        Me.cmdDivBrowse.Name = "cmdDivBrowse"
        Me.cmdDivBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cboTitleEng
        '
        Me.cboTitleEng.DisplayMember = "Text"
        Me.cboTitleEng.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTitleEng.FormattingEnabled = True
        resources.ApplyResources(Me.cboTitleEng, "cboTitleEng")
        Me.cboTitleEng.Name = "cboTitleEng"
        Me.cboTitleEng.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cboTitle
        '
        Me.cboTitle.DisplayMember = "Text"
        Me.cboTitle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTitle.FormattingEnabled = True
        resources.ApplyResources(Me.cboTitle, "cboTitle")
        Me.cboTitle.Name = "cboTitle"
        Me.cboTitle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.Class = ""
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX8, "LabelX8")
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.Class = ""
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX10, "LabelX10")
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX12.BackgroundStyle.Class = ""
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX12, "LabelX12")
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX14.BackgroundStyle.Class = ""
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX14, "LabelX14")
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX16
        '
        Me.LabelX16.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX16.BackgroundStyle.Class = ""
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX16, "LabelX16")
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX15.BackgroundStyle.Class = ""
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX15, "LabelX15")
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX13.BackgroundStyle.Class = ""
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX13, "LabelX13")
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX11.BackgroundStyle.Class = ""
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX11, "LabelX11")
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.Class = ""
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX9, "LabelX9")
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.Class = ""
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX7, "LabelX7")
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX17
        '
        Me.LabelX17.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX17.BackgroundStyle.Class = ""
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX17, "LabelX17")
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX6, "LabelX6")
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX4, "LabelX4")
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtAccountCode
        '
        '
        '
        '
        Me.txtAccountCode.Border.Class = "TextBoxBorder"
        Me.txtAccountCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtAccountCode, CType(resources.GetObject("txtAccountCode.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtAccountCode, "txtAccountCode")
        Me.txtAccountCode.Name = "txtAccountCode"
        '
        'txtLname
        '
        '
        '
        '
        Me.txtLname.Border.Class = "TextBoxBorder"
        Me.txtLname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtLname, CType(resources.GetObject("txtLname.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtLname, "txtLname")
        Me.txtLname.Name = "txtLname"
        '
        'txtLnameEng
        '
        '
        '
        '
        Me.txtLnameEng.Border.Class = "TextBoxBorder"
        Me.txtLnameEng.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtLnameEng, CType(resources.GetObject("txtLnameEng.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtLnameEng, "txtLnameEng")
        Me.txtLnameEng.Name = "txtLnameEng"
        '
        'txtWorkingPlace
        '
        '
        '
        '
        Me.txtWorkingPlace.Border.Class = "TextBoxBorder"
        Me.txtWorkingPlace.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtWorkingPlace, CType(resources.GetObject("txtWorkingPlace.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtWorkingPlace, "txtWorkingPlace")
        Me.txtWorkingPlace.Name = "txtWorkingPlace"
        '
        'txtPosition
        '
        '
        '
        '
        Me.txtPosition.Border.Class = "TextBoxBorder"
        Me.txtPosition.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtPosition, CType(resources.GetObject("txtPosition.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtPosition, "txtPosition")
        Me.txtPosition.Name = "txtPosition"
        '
        'txtSecId_Det
        '
        '
        '
        '
        Me.txtSecId_Det.Border.Class = "TextBoxBorder"
        Me.txtSecId_Det.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtSecId_Det, CType(resources.GetObject("txtSecId_Det.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtSecId_Det, "txtSecId_Det")
        Me.txtSecId_Det.Name = "txtSecId_Det"
        '
        'txtDepartment
        '
        '
        '
        '
        Me.txtDepartment.Border.Class = "TextBoxBorder"
        Me.txtDepartment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtDepartment, CType(resources.GetObject("txtDepartment.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtDepartment, "txtDepartment")
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.ReadOnly = True
        '
        'txtDeptId
        '
        '
        '
        '
        Me.txtDeptId.Border.Class = "TextBoxBorder"
        Me.txtDeptId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtDeptId, CType(resources.GetObject("txtDeptId.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtDeptId, "txtDeptId")
        Me.txtDeptId.Name = "txtDeptId"
        '
        'txtSection_Det
        '
        '
        '
        '
        Me.txtSection_Det.Border.Class = "TextBoxBorder"
        Me.txtSection_Det.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtSection_Det, CType(resources.GetObject("txtSection_Det.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtSection_Det, "txtSection_Det")
        Me.txtSection_Det.Name = "txtSection_Det"
        Me.txtSection_Det.ReadOnly = True
        '
        'txtDivision
        '
        '
        '
        '
        Me.txtDivision.Border.Class = "TextBoxBorder"
        Me.txtDivision.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtDivision, CType(resources.GetObject("txtDivision.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtDivision, "txtDivision")
        Me.txtDivision.Name = "txtDivision"
        Me.txtDivision.ReadOnly = True
        '
        'txtDivID
        '
        '
        '
        '
        Me.txtDivID.Border.Class = "TextBoxBorder"
        Me.txtDivID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtDivID, CType(resources.GetObject("txtDivID.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtDivID, "txtDivID")
        Me.txtDivID.Name = "txtDivID"
        '
        'txtNickName
        '
        '
        '
        '
        Me.txtNickName.Border.Class = "TextBoxBorder"
        Me.txtNickName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtNickName, CType(resources.GetObject("txtNickName.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtNickName, "txtNickName")
        Me.txtNickName.Name = "txtNickName"
        '
        'txtFnameEng
        '
        '
        '
        '
        Me.txtFnameEng.Border.Class = "TextBoxBorder"
        Me.txtFnameEng.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtFnameEng, CType(resources.GetObject("txtFnameEng.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtFnameEng, "txtFnameEng")
        Me.txtFnameEng.Name = "txtFnameEng"
        '
        'txtCode_D
        '
        '
        '
        '
        Me.txtCode_D.Border.Class = "TextBoxBorder"
        Me.txtCode_D.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtCode_D, CType(resources.GetObject("txtCode_D.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtCode_D, "txtCode_D")
        Me.txtCode_D.Name = "txtCode_D"
        '
        'txtBarcode
        '
        '
        '
        '
        Me.txtBarcode.Border.Class = "TextBoxBorder"
        Me.txtBarcode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtBarcode, CType(resources.GetObject("txtBarcode.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtBarcode, "txtBarcode")
        Me.txtBarcode.Name = "txtBarcode"
        '
        'txtFname_Det
        '
        '
        '
        '
        Me.txtFname_Det.Border.Class = "TextBoxBorder"
        Me.txtFname_Det.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.txtFname_Det, CType(resources.GetObject("txtFname_Det.HighlightOnFocus"), Boolean))
        resources.ApplyResources(Me.txtFname_Det, "txtFname_Det")
        Me.txtFname_Det.Name = "txtFname_Det"
        '
        'LabelX18
        '
        Me.LabelX18.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX18.BackgroundStyle.Class = ""
        Me.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX18, "LabelX18")
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblWorkStatus
        '
        Me.lblWorkStatus.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblWorkStatus.BackgroundStyle.Class = ""
        Me.lblWorkStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.lblWorkStatus, "lblWorkStatus")
        Me.lblWorkStatus.Name = "lblWorkStatus"
        Me.lblWorkStatus.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX5, "LabelX5")
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        resources.ApplyResources(Me.TabItem2, "TabItem2")
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        resources.ApplyResources(Me.Highlighter1, "Highlighter1")
        '
        'frmEmp
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmEmp"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabControlPanel3.ResumeLayout(False)
        Me.TabControlPanel3.PerformLayout()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel15.ResumeLayout(False)
        Me.GroupPanel4.ResumeLayout(False)
        Me.TabControlPanel11.ResumeLayout(False)
        Me.TabControlPanel11.PerformLayout()
        Me.TabControlPanel8.ResumeLayout(False)
        Me.GroupPanel10.ResumeLayout(False)
        Me.GroupPanel9.ResumeLayout(False)
        Me.TabControlPanel4.ResumeLayout(False)
        Me.GroupPanel5.ResumeLayout(False)
        Me.TabControlPanel5.ResumeLayout(False)
        Me.TabControlPanel5.PerformLayout()
        Me.TabControlPanel6.ResumeLayout(False)
        Me.GroupPanel7.ResumeLayout(False)
        Me.GroupPanel7.PerformLayout()
        Me.GroupPanel6.ResumeLayout(False)
        Me.TabControlPanel7.ResumeLayout(False)
        Me.GroupPanel13.ResumeLayout(False)
        Me.GroupPanel13.PerformLayout()
        Me.GroupPanel14.ResumeLayout(False)
        Me.GroupPanel11.ResumeLayout(False)
        Me.GroupPanel11.PerformLayout()
        Me.GroupPanel12.ResumeLayout(False)
        Me.TabControlPanel9.ResumeLayout(False)
        Me.GroupPanel8.ResumeLayout(False)
        Me.TabControlPanel10.ResumeLayout(False)
        Me.GroupPanel16.ResumeLayout(False)
        Me.GroupPanel16.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents LstData As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents colNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colEmpId As System.Windows.Forms.ColumnHeader
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cmdRefresh As DevComponents.DotNetBar.ButtonX
    Friend WithEvents optCompany As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents optName As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents optDept As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents optCode As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cmdSearch As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtFname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents OptEmpName As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents OptEmpcode As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboCompany As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ColCardId As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDepartmentId As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColStartWork As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColExp As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColCompany As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColWorkingPlace As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColUpdate As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PG1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtFname_Det As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtLname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtFnameEng As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtLnameEng As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNickName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtWorkingPlace As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDivID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSecId_Det As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDeptId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPosition As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboTitle As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboTitleEng As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmdDivBrowse As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSection As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdDeptBrowse As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtDepartment As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSection_Det As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtDivision As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TabControl2 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem3 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem4 As DevComponents.DotNetBar.TabItem
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTaxId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cboSex As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtPlaceIdCard As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtIdCard As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtAge As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtWorkAge As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX28 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX26 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX25 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX27 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX24 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX23 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX22 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTermiDate As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtEducation As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX29 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX30 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMarryName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX31 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboMateSpit As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX32 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX33 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX35 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX34 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSocTax As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtStatus As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX37 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX38 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX36 As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkContractor As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents OptDay As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents OptMonth As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX39 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboWeek As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboEmpGroup As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX42 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX41 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX40 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents optBank As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents optCash As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cmbCompanyName As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX43 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboBroker As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX45 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX44 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmdNext As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdPrevious As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cboBank As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents GroupPanel5 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cboDonateMStart As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboLoanMStart As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboPremiumMStart As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX47 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCapitalSumary As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtDonate As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX52 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtLoan As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX51 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPremium As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX50 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX49 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX58 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX57 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX56 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX55 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX48 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX46 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSonAge5 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSonAge4 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX72 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSonAge3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX71 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSonAge2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX70 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSonAge1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX69 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSonName5 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX68 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX67 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSonName3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX66 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSonName2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX65 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSonName1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX64 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX63 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX54 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX53 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabControlPanel5 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents chkPro_Fund As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkFatherCalTax As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents txtMatherIdCardMate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelX92 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtFatherIdCardMate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelX91 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMatherIdCard As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelX90 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtFatherIdCard As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelX89 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboSoldierStatus As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX82 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX97 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX81 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX80 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtReligion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX75 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNationalily As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX74 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMatherNameMate As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX88 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtRemark As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX96 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtEduSpacial As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX95 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtErContract As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX87 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtEr_Tel As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX94 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtGuanWork As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX93 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtGuaranteeName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX86 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtFatherNameMate As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX85 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMatherName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX84 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtFatherName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX83 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDrivePlace As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX79 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDriveNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX78 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtforeignNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX77 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTelContract As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX76 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX73 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabItem5 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel6 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem6 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel7 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem7 As DevComponents.DotNetBar.TabItem
    Friend WithEvents txtMonth_Year As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboYear As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX98 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblAccGrossTax As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX99 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel6 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblAccuPFAll As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX105 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblAccuPF As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX104 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblAccSocTax As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX103 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblAccGrossSoc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX102 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblAccTax As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX101 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblAccBonus As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX100 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel7 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cmdDelTax As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAddTax As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX106 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txteRemark As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX111 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txteSocTax As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX110 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtGrossSoc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX109 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTax As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX108 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtGrossTax As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX107 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lstMonthly As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents ColNo_ As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColMonth As System.Windows.Forms.ColumnHeader
    Friend WithEvents colVatCal As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColVat As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColPricePKS As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColPKS As System.Windows.Forms.ColumnHeader
    Friend WithEvents LabelX113 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX112 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lstAdd As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabControlPanel8 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents GroupPanel10 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX115 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboPrivilegeYear As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents GroupPanel9 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lstPrivilege As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColTypeWage As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDayCount As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDayUse As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColTotalDay As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabItem8 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel9 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents GroupPanel8 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents chkCalOtDeduc As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkCalLate As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cboOt As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX114 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabItem9 As DevComponents.DotNetBar.TabItem
    Friend WithEvents GroupPanel13 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel14 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents optPP_Multiple As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents optPP_NoneB As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX118 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX119 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel11 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lstVisa As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CalId As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColIssuedDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColExperiedDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents CalTypeOfVisa As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColTypeMultiple As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupPanel12 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents optVisa_Multiple As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents optVisa_NoneB As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX116 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX117 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtpp_Experieddate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lstPassport As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColPassportNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtpp_Issueddate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelX120 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtVisa_ExperiedDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtVisa_IssuedDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtAccountCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCode_D As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtBarcode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtBonus As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtTypeBank As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtBankId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSalary As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtMarryWorkCom As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtAddress As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanel15 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtA_ENT As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtRace As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ComboItem30 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem31 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem32 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem33 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem34 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem35 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem36 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem23 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem24 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem25 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem26 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem27 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem28 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem29 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem16 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem17 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem18 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem19 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem20 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem21 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem22 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem37 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem38 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem39 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem40 As DevComponents.Editors.ComboItem
    Friend WithEvents chkMatherCalTaxMate As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkFatherCalTaxMate As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkMatherCalTax As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents lblWorkStatus As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblCurRecord As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmdPP_Refresh As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdPP_Delete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdPP_Edit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdPP_Add As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdVisa_Refresh As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdVisa_Delete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdVisa_Edit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdVisa_Add As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblVisa_Id As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblPassportId As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSonName4 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Public WithEvents txtpp_NO As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents chkCalSocTax As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents PicBox As System.Windows.Forms.PictureBox
    Friend WithEvents txtSonEdu As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX59 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX62 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX60 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX61 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSonNonEdu As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TabControlPanel10 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabMoveToEmpOut As DevComponents.DotNetBar.TabItem
    Friend WithEvents GroupPanel16 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cmdConfirm As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtTermiDate_Move As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelX121 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBirth As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDatePro As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTermiDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDateIn As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDateExpire As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmdCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtSoldierDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDriveDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtforeignDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TabControlPanel11 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents lstTraining As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents colTraningNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTraningName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTraningDateST As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTraningDateSP As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTraningDay As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTraningRemark As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnTrain_Clear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnTrain_Delete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnTrain_Edit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnTrain_Add As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtTrainingDateSP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTrainingDateST As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTrainingRemark As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtTrainingDay As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtTraining_RowId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtTrainigName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX128 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX123 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX127 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX124 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX126 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX122 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabItem10 As DevComponents.DotNetBar.TabItem
    Friend WithEvents LabelX129 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX125 As DevComponents.DotNetBar.LabelX
End Class
