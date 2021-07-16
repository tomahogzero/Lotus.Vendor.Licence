<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptTimeTableByMonth
    '  Inherits System.Windows.Forms.Form
    Inherits DevExpress.XtraEditors.XtraForm
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptTimeTableByMonth))
        Me.txtDateSp = New DevExpress.XtraEditors.DateEdit()
        Me.txtDateSt = New DevExpress.XtraEditors.DateEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboBroker = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboEmpGroup = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboCompany = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnCurrentDate = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAllMonth = New DevExpress.XtraEditors.SimpleButton()
        Me.btnToDate = New DevExpress.XtraEditors.SimpleButton()
        Me.txtYear = New DevExpress.XtraEditors.TextEdit()
        Me.cboMonth = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.cboDivision = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboDepartment = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        Me.txtCode1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtNameSearch = New DevExpress.XtraEditors.TextEdit()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnReport = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtDateSp.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateSp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateSt.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateSt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDateSp
        '
        resources.ApplyResources(Me.txtDateSp, "txtDateSp")
        Me.txtDateSp.EnterMoveNextControl = True
        Me.txtDateSp.Name = "txtDateSp"
        Me.txtDateSp.Properties.AccessibleDescription = resources.GetString("txtDateSp.Properties.AccessibleDescription")
        Me.txtDateSp.Properties.AccessibleName = resources.GetString("txtDateSp.Properties.AccessibleName")
        Me.txtDateSp.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtDateSp.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtDateSp.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtDateSp.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtDateSp.Properties.Appearance.GradientMode = CType(resources.GetObject("txtDateSp.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtDateSp.Properties.Appearance.Image = CType(resources.GetObject("txtDateSp.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtDateSp.Properties.Appearance.Options.UseFont = True
        Me.txtDateSp.Properties.AutoHeight = CType(resources.GetObject("txtDateSp.Properties.AutoHeight"), Boolean)
        Me.txtDateSp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateSp.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateSp.Properties.CalendarTimeProperties.AccessibleDescription = resources.GetString("txtDateSp.Properties.CalendarTimeProperties.AccessibleDescription")
        Me.txtDateSp.Properties.CalendarTimeProperties.AccessibleName = resources.GetString("txtDateSp.Properties.CalendarTimeProperties.AccessibleName")
        Me.txtDateSp.Properties.CalendarTimeProperties.AutoHeight = CType(resources.GetObject("txtDateSp.Properties.CalendarTimeProperties.AutoHeight"), Boolean)
        Me.txtDateSp.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateSp.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateSp.Properties.CalendarTimeProperties.Mask.AutoComplete = CType(resources.GetObject("txtDateSp.Properties.CalendarTimeProperties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDateSp.Properties.CalendarTimeProperties.Mask.BeepOnError = CType(resources.GetObject("txtDateSp.Properties.CalendarTimeProperties.Mask.BeepOnError"), Boolean)
        Me.txtDateSp.Properties.CalendarTimeProperties.Mask.EditMask = resources.GetString("txtDateSp.Properties.CalendarTimeProperties.Mask.EditMask")
        Me.txtDateSp.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDateSp.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDateSp.Properties.CalendarTimeProperties.Mask.MaskType = CType(resources.GetObject("txtDateSp.Properties.CalendarTimeProperties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDateSp.Properties.CalendarTimeProperties.Mask.PlaceHolder = CType(resources.GetObject("txtDateSp.Properties.CalendarTimeProperties.Mask.PlaceHolder"), Char)
        Me.txtDateSp.Properties.CalendarTimeProperties.Mask.SaveLiteral = CType(resources.GetObject("txtDateSp.Properties.CalendarTimeProperties.Mask.SaveLiteral"), Boolean)
        Me.txtDateSp.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDateSp.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDateSp.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDateSp.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDateSp.Properties.CalendarTimeProperties.NullValuePrompt = resources.GetString("txtDateSp.Properties.CalendarTimeProperties.NullValuePrompt")
        Me.txtDateSp.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtDateSp.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.txtDateSp.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtDateSp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDateSp.Properties.Mask.AutoComplete = CType(resources.GetObject("txtDateSp.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDateSp.Properties.Mask.BeepOnError = CType(resources.GetObject("txtDateSp.Properties.Mask.BeepOnError"), Boolean)
        Me.txtDateSp.Properties.Mask.EditMask = resources.GetString("txtDateSp.Properties.Mask.EditMask")
        Me.txtDateSp.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDateSp.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDateSp.Properties.Mask.MaskType = CType(resources.GetObject("txtDateSp.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDateSp.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtDateSp.Properties.Mask.PlaceHolder"), Char)
        Me.txtDateSp.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtDateSp.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtDateSp.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDateSp.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDateSp.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDateSp.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDateSp.Properties.NullValuePrompt = resources.GetString("txtDateSp.Properties.NullValuePrompt")
        Me.txtDateSp.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtDateSp.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'txtDateSt
        '
        resources.ApplyResources(Me.txtDateSt, "txtDateSt")
        Me.txtDateSt.EnterMoveNextControl = True
        Me.txtDateSt.Name = "txtDateSt"
        Me.txtDateSt.Properties.AccessibleDescription = resources.GetString("txtDateSt.Properties.AccessibleDescription")
        Me.txtDateSt.Properties.AccessibleName = resources.GetString("txtDateSt.Properties.AccessibleName")
        Me.txtDateSt.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtDateSt.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtDateSt.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtDateSt.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtDateSt.Properties.Appearance.GradientMode = CType(resources.GetObject("txtDateSt.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtDateSt.Properties.Appearance.Image = CType(resources.GetObject("txtDateSt.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtDateSt.Properties.Appearance.Options.UseFont = True
        Me.txtDateSt.Properties.AutoHeight = CType(resources.GetObject("txtDateSt.Properties.AutoHeight"), Boolean)
        Me.txtDateSt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateSt.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateSt.Properties.CalendarTimeProperties.AccessibleDescription = resources.GetString("txtDateSt.Properties.CalendarTimeProperties.AccessibleDescription")
        Me.txtDateSt.Properties.CalendarTimeProperties.AccessibleName = resources.GetString("txtDateSt.Properties.CalendarTimeProperties.AccessibleName")
        Me.txtDateSt.Properties.CalendarTimeProperties.AutoHeight = CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.AutoHeight"), Boolean)
        Me.txtDateSt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateSt.Properties.CalendarTimeProperties.Mask.AutoComplete = CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDateSt.Properties.CalendarTimeProperties.Mask.BeepOnError = CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.Mask.BeepOnError"), Boolean)
        Me.txtDateSt.Properties.CalendarTimeProperties.Mask.EditMask = resources.GetString("txtDateSt.Properties.CalendarTimeProperties.Mask.EditMask")
        Me.txtDateSt.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDateSt.Properties.CalendarTimeProperties.Mask.MaskType = CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDateSt.Properties.CalendarTimeProperties.Mask.PlaceHolder = CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.Mask.PlaceHolder"), Char)
        Me.txtDateSt.Properties.CalendarTimeProperties.Mask.SaveLiteral = CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.Mask.SaveLiteral"), Boolean)
        Me.txtDateSt.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDateSt.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDateSt.Properties.CalendarTimeProperties.NullValuePrompt = resources.GetString("txtDateSt.Properties.CalendarTimeProperties.NullValuePrompt")
        Me.txtDateSt.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.txtDateSt.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtDateSt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDateSt.Properties.Mask.AutoComplete = CType(resources.GetObject("txtDateSt.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDateSt.Properties.Mask.BeepOnError = CType(resources.GetObject("txtDateSt.Properties.Mask.BeepOnError"), Boolean)
        Me.txtDateSt.Properties.Mask.EditMask = resources.GetString("txtDateSt.Properties.Mask.EditMask")
        Me.txtDateSt.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDateSt.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDateSt.Properties.Mask.MaskType = CType(resources.GetObject("txtDateSt.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDateSt.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtDateSt.Properties.Mask.PlaceHolder"), Char)
        Me.txtDateSt.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtDateSt.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtDateSt.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDateSt.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDateSt.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDateSt.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDateSt.Properties.NullValuePrompt = resources.GetString("txtDateSt.Properties.NullValuePrompt")
        Me.txtDateSt.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtDateSt.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'ProgressBar1
        '
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        '
        '
        '
        Me.ProgressBar1.BackgroundStyle.Class = ""
        Me.ProgressBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBar1.Name = "ProgressBar1"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'cboBroker
        '
        resources.ApplyResources(Me.cboBroker, "cboBroker")
        Me.cboBroker.DisplayMember = "Text"
        Me.cboBroker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboBroker.FormattingEnabled = True
        Me.cboBroker.Name = "cboBroker"
        Me.cboBroker.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cboEmpGroup
        '
        resources.ApplyResources(Me.cboEmpGroup, "cboEmpGroup")
        Me.cboEmpGroup.DisplayMember = "Text"
        Me.cboEmpGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboEmpGroup.FormattingEnabled = True
        Me.cboEmpGroup.Name = "cboEmpGroup"
        Me.cboEmpGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cboCompany
        '
        resources.ApplyResources(Me.cboCompany, "cboCompany")
        Me.cboCompany.DisplayMember = "Text"
        Me.cboCompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompany.FormattingEnabled = True
        Me.cboCompany.Name = "cboCompany"
        Me.cboCompany.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'GroupControl1
        '
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Controls.Add(Me.btnCurrentDate)
        Me.GroupControl1.Controls.Add(Me.btnAllMonth)
        Me.GroupControl1.Controls.Add(Me.btnToDate)
        Me.GroupControl1.Controls.Add(Me.txtYear)
        Me.GroupControl1.Controls.Add(Me.cboMonth)
        Me.GroupControl1.Controls.Add(Me.txtDateSp)
        Me.GroupControl1.Controls.Add(Me.txtDateSt)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Name = "GroupControl1"
        '
        'btnCurrentDate
        '
        resources.ApplyResources(Me.btnCurrentDate, "btnCurrentDate")
        Me.btnCurrentDate.Name = "btnCurrentDate"
        '
        'btnAllMonth
        '
        resources.ApplyResources(Me.btnAllMonth, "btnAllMonth")
        Me.btnAllMonth.Name = "btnAllMonth"
        '
        'btnToDate
        '
        resources.ApplyResources(Me.btnToDate, "btnToDate")
        Me.btnToDate.Name = "btnToDate"
        '
        'txtYear
        '
        resources.ApplyResources(Me.txtYear, "txtYear")
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Properties.AccessibleDescription = resources.GetString("txtYear.Properties.AccessibleDescription")
        Me.txtYear.Properties.AccessibleName = resources.GetString("txtYear.Properties.AccessibleName")
        Me.txtYear.Properties.AutoHeight = CType(resources.GetObject("txtYear.Properties.AutoHeight"), Boolean)
        Me.txtYear.Properties.Mask.AutoComplete = CType(resources.GetObject("txtYear.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtYear.Properties.Mask.BeepOnError = CType(resources.GetObject("txtYear.Properties.Mask.BeepOnError"), Boolean)
        Me.txtYear.Properties.Mask.EditMask = resources.GetString("txtYear.Properties.Mask.EditMask")
        Me.txtYear.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtYear.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtYear.Properties.Mask.MaskType = CType(resources.GetObject("txtYear.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtYear.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtYear.Properties.Mask.PlaceHolder"), Char)
        Me.txtYear.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtYear.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtYear.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtYear.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtYear.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtYear.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtYear.Properties.NullValuePrompt = resources.GetString("txtYear.Properties.NullValuePrompt")
        Me.txtYear.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtYear.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'cboMonth
        '
        resources.ApplyResources(Me.cboMonth, "cboMonth")
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Properties.AccessibleDescription = resources.GetString("cboMonth.Properties.AccessibleDescription")
        Me.cboMonth.Properties.AccessibleName = resources.GetString("cboMonth.Properties.AccessibleName")
        Me.cboMonth.Properties.AutoHeight = CType(resources.GetObject("cboMonth.Properties.AutoHeight"), Boolean)
        Me.cboMonth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboMonth.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboMonth.Properties.DropDownRows = 15
        Me.cboMonth.Properties.NullValuePrompt = resources.GetString("cboMonth.Properties.NullValuePrompt")
        Me.cboMonth.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("cboMonth.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.cboMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'GroupControl2
        '
        resources.ApplyResources(Me.GroupControl2, "GroupControl2")
        Me.GroupControl2.Controls.Add(Me.cboDivision)
        Me.GroupControl2.Controls.Add(Me.cboDepartment)
        Me.GroupControl2.Controls.Add(Me.Label5)
        Me.GroupControl2.Controls.Add(Me.Label12)
        Me.GroupControl2.Name = "GroupControl2"
        '
        'cboDivision
        '
        resources.ApplyResources(Me.cboDivision, "cboDivision")
        Me.cboDivision.Name = "cboDivision"
        Me.cboDivision.Properties.AccessibleDescription = resources.GetString("cboDivision.Properties.AccessibleDescription")
        Me.cboDivision.Properties.AccessibleName = resources.GetString("cboDivision.Properties.AccessibleName")
        Me.cboDivision.Properties.AutoHeight = CType(resources.GetObject("cboDivision.Properties.AutoHeight"), Boolean)
        Me.cboDivision.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboDivision.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboDivision.Properties.DropDownRows = 15
        Me.cboDivision.Properties.NullValuePrompt = resources.GetString("cboDivision.Properties.NullValuePrompt")
        Me.cboDivision.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("cboDivision.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.cboDivision.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'cboDepartment
        '
        resources.ApplyResources(Me.cboDepartment, "cboDepartment")
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Properties.AccessibleDescription = resources.GetString("cboDepartment.Properties.AccessibleDescription")
        Me.cboDepartment.Properties.AccessibleName = resources.GetString("cboDepartment.Properties.AccessibleName")
        Me.cboDepartment.Properties.AutoHeight = CType(resources.GetObject("cboDepartment.Properties.AutoHeight"), Boolean)
        Me.cboDepartment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboDepartment.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboDepartment.Properties.DropDownRows = 15
        Me.cboDepartment.Properties.NullValuePrompt = resources.GetString("cboDepartment.Properties.NullValuePrompt")
        Me.cboDepartment.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("cboDepartment.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.cboDepartment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'GroupControl4
        '
        resources.ApplyResources(Me.GroupControl4, "GroupControl4")
        Me.GroupControl4.Controls.Add(Me.txtName)
        Me.GroupControl4.Controls.Add(Me.txtCode1)
        Me.GroupControl4.Controls.Add(Me.txtNameSearch)
        Me.GroupControl4.Controls.Add(Me.Label14)
        Me.GroupControl4.Controls.Add(Me.Label13)
        Me.GroupControl4.Name = "GroupControl4"
        '
        'txtName
        '
        resources.ApplyResources(Me.txtName, "txtName")
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.AccessibleDescription = resources.GetString("txtName.Properties.AccessibleDescription")
        Me.txtName.Properties.AccessibleName = resources.GetString("txtName.Properties.AccessibleName")
        Me.txtName.Properties.AutoHeight = CType(resources.GetObject("txtName.Properties.AutoHeight"), Boolean)
        Me.txtName.Properties.Mask.AutoComplete = CType(resources.GetObject("txtName.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtName.Properties.Mask.BeepOnError = CType(resources.GetObject("txtName.Properties.Mask.BeepOnError"), Boolean)
        Me.txtName.Properties.Mask.EditMask = resources.GetString("txtName.Properties.Mask.EditMask")
        Me.txtName.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtName.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtName.Properties.Mask.MaskType = CType(resources.GetObject("txtName.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtName.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtName.Properties.Mask.PlaceHolder"), Char)
        Me.txtName.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtName.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtName.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtName.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtName.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtName.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtName.Properties.NullValuePrompt = resources.GetString("txtName.Properties.NullValuePrompt")
        Me.txtName.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtName.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.txtName.Properties.ReadOnly = True
        '
        'txtCode1
        '
        resources.ApplyResources(Me.txtCode1, "txtCode1")
        Me.txtCode1.EnterMoveNextControl = True
        Me.txtCode1.Name = "txtCode1"
        Me.txtCode1.Properties.AccessibleDescription = resources.GetString("txtCode1.Properties.AccessibleDescription")
        Me.txtCode1.Properties.AccessibleName = resources.GetString("txtCode1.Properties.AccessibleName")
        Me.txtCode1.Properties.AutoHeight = CType(resources.GetObject("txtCode1.Properties.AutoHeight"), Boolean)
        Me.txtCode1.Properties.Mask.AutoComplete = CType(resources.GetObject("txtCode1.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtCode1.Properties.Mask.BeepOnError = CType(resources.GetObject("txtCode1.Properties.Mask.BeepOnError"), Boolean)
        Me.txtCode1.Properties.Mask.EditMask = resources.GetString("txtCode1.Properties.Mask.EditMask")
        Me.txtCode1.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtCode1.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtCode1.Properties.Mask.MaskType = CType(resources.GetObject("txtCode1.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtCode1.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtCode1.Properties.Mask.PlaceHolder"), Char)
        Me.txtCode1.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtCode1.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtCode1.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtCode1.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtCode1.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtCode1.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtCode1.Properties.NullValuePrompt = resources.GetString("txtCode1.Properties.NullValuePrompt")
        Me.txtCode1.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtCode1.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'txtNameSearch
        '
        resources.ApplyResources(Me.txtNameSearch, "txtNameSearch")
        Me.txtNameSearch.EnterMoveNextControl = True
        Me.txtNameSearch.Name = "txtNameSearch"
        Me.txtNameSearch.Properties.AccessibleDescription = resources.GetString("txtNameSearch.Properties.AccessibleDescription")
        Me.txtNameSearch.Properties.AccessibleName = resources.GetString("txtNameSearch.Properties.AccessibleName")
        Me.txtNameSearch.Properties.AutoHeight = CType(resources.GetObject("txtNameSearch.Properties.AutoHeight"), Boolean)
        Me.txtNameSearch.Properties.Mask.AutoComplete = CType(resources.GetObject("txtNameSearch.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtNameSearch.Properties.Mask.BeepOnError = CType(resources.GetObject("txtNameSearch.Properties.Mask.BeepOnError"), Boolean)
        Me.txtNameSearch.Properties.Mask.EditMask = resources.GetString("txtNameSearch.Properties.Mask.EditMask")
        Me.txtNameSearch.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtNameSearch.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtNameSearch.Properties.Mask.MaskType = CType(resources.GetObject("txtNameSearch.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtNameSearch.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtNameSearch.Properties.Mask.PlaceHolder"), Char)
        Me.txtNameSearch.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtNameSearch.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtNameSearch.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtNameSearch.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtNameSearch.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtNameSearch.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtNameSearch.Properties.NullValuePrompt = resources.GetString("txtNameSearch.Properties.NullValuePrompt")
        Me.txtNameSearch.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtNameSearch.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'btnExit
        '
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.Appearance.Font = CType(resources.GetObject("btnExit.Appearance.Font"), System.Drawing.Font)
        Me.btnExit.Appearance.FontSizeDelta = CType(resources.GetObject("btnExit.Appearance.FontSizeDelta"), Integer)
        Me.btnExit.Appearance.FontStyleDelta = CType(resources.GetObject("btnExit.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.btnExit.Appearance.GradientMode = CType(resources.GetObject("btnExit.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.btnExit.Appearance.Image = CType(resources.GetObject("btnExit.Appearance.Image"), System.Drawing.Image)
        Me.btnExit.Appearance.Options.UseFont = True
        Me.btnExit.ImageOptions.Image = CType(resources.GetObject("btnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnExit.Name = "btnExit"
        '
        'btnReport
        '
        resources.ApplyResources(Me.btnReport, "btnReport")
        Me.btnReport.Appearance.Font = CType(resources.GetObject("btnReport.Appearance.Font"), System.Drawing.Font)
        Me.btnReport.Appearance.FontSizeDelta = CType(resources.GetObject("btnReport.Appearance.FontSizeDelta"), Integer)
        Me.btnReport.Appearance.FontStyleDelta = CType(resources.GetObject("btnReport.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.btnReport.Appearance.GradientMode = CType(resources.GetObject("btnReport.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.btnReport.Appearance.Image = CType(resources.GetObject("btnReport.Appearance.Image"), System.Drawing.Image)
        Me.btnReport.Appearance.Options.UseFont = True
        Me.btnReport.ImageOptions.Image = CType(resources.GetObject("btnReport.ImageOptions.Image"), System.Drawing.Image)
        Me.btnReport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnReport.Name = "btnReport"
        '
        'frmRptTimeTableByMonth
        '
        resources.ApplyResources(Me, "$this")
        Me.Appearance.FontSizeDelta = CType(resources.GetObject("frmRptTimeTableByMonth.Appearance.FontSizeDelta"), Integer)
        Me.Appearance.FontStyleDelta = CType(resources.GetObject("frmRptTimeTableByMonth.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.Appearance.GradientMode = CType(resources.GetObject("frmRptTimeTableByMonth.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.Appearance.Image = CType(resources.GetObject("frmRptTimeTableByMonth.Appearance.Image"), System.Drawing.Image)
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.cboBroker)
        Me.Controls.Add(Me.cboEmpGroup)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboCompany)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Name = "frmRptTimeTableByMonth"
        CType(Me.txtDateSp.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateSp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateSt.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateSt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboBroker As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboEmpGroup As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboCompany As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDateSp As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDateSt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboDivision As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboDepartment As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNameSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtYear As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboMonth As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnCurrentDate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAllMonth As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnToDate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCode1 As DevExpress.XtraEditors.TextEdit
End Class
