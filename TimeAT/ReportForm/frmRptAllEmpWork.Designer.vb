<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptAllEmpWork
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptAllEmpWork))
        Me.txtDateStop = New DevExpress.XtraEditors.DateEdit()
        Me.txtDateStart = New DevExpress.XtraEditors.DateEdit()
        Me.cboCompany = New System.Windows.Forms.ComboBox()
        Me.cboEmpGroup = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnCurrentDate = New DevExpress.XtraEditors.SimpleButton()
        Me.cboMonth = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnAllMonth = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtYear = New DevExpress.XtraEditors.TextEdit()
        Me.btnToDate = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.cboDepartment = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboDivision = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.txtShowName = New DevExpress.XtraEditors.TextEdit()
        Me.txtNameSearch = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCode1 = New DevExpress.XtraEditors.TextEdit()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnReport = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtDateStop.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateStop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cboMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.txtShowName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDateStop
        '
        resources.ApplyResources(Me.txtDateStop, "txtDateStop")
        Me.txtDateStop.EnterMoveNextControl = True
        Me.txtDateStop.Name = "txtDateStop"
        Me.txtDateStop.Properties.AccessibleDescription = resources.GetString("txtDateStop.Properties.AccessibleDescription")
        Me.txtDateStop.Properties.AccessibleName = resources.GetString("txtDateStop.Properties.AccessibleName")
        Me.txtDateStop.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtDateStop.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtDateStop.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtDateStop.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtDateStop.Properties.Appearance.GradientMode = CType(resources.GetObject("txtDateStop.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtDateStop.Properties.Appearance.Image = CType(resources.GetObject("txtDateStop.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtDateStop.Properties.Appearance.Options.UseFont = True
        Me.txtDateStop.Properties.AutoHeight = CType(resources.GetObject("txtDateStop.Properties.AutoHeight"), Boolean)
        Me.txtDateStop.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateStop.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateStop.Properties.CalendarTimeProperties.AccessibleDescription = resources.GetString("txtDateStop.Properties.CalendarTimeProperties.AccessibleDescription")
        Me.txtDateStop.Properties.CalendarTimeProperties.AccessibleName = resources.GetString("txtDateStop.Properties.CalendarTimeProperties.AccessibleName")
        Me.txtDateStop.Properties.CalendarTimeProperties.AutoHeight = CType(resources.GetObject("txtDateStop.Properties.CalendarTimeProperties.AutoHeight"), Boolean)
        Me.txtDateStop.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateStop.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateStop.Properties.CalendarTimeProperties.Mask.AutoComplete = CType(resources.GetObject("txtDateStop.Properties.CalendarTimeProperties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDateStop.Properties.CalendarTimeProperties.Mask.BeepOnError = CType(resources.GetObject("txtDateStop.Properties.CalendarTimeProperties.Mask.BeepOnError"), Boolean)
        Me.txtDateStop.Properties.CalendarTimeProperties.Mask.EditMask = resources.GetString("txtDateStop.Properties.CalendarTimeProperties.Mask.EditMask")
        Me.txtDateStop.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDateStop.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDateStop.Properties.CalendarTimeProperties.Mask.MaskType = CType(resources.GetObject("txtDateStop.Properties.CalendarTimeProperties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDateStop.Properties.CalendarTimeProperties.Mask.PlaceHolder = CType(resources.GetObject("txtDateStop.Properties.CalendarTimeProperties.Mask.PlaceHolder"), Char)
        Me.txtDateStop.Properties.CalendarTimeProperties.Mask.SaveLiteral = CType(resources.GetObject("txtDateStop.Properties.CalendarTimeProperties.Mask.SaveLiteral"), Boolean)
        Me.txtDateStop.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDateStop.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDateStop.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDateStop.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDateStop.Properties.CalendarTimeProperties.NullValuePrompt = resources.GetString("txtDateStop.Properties.CalendarTimeProperties.NullValuePrompt")
        Me.txtDateStop.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtDateStop.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.txtDateStop.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtDateStop.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDateStop.Properties.Mask.AutoComplete = CType(resources.GetObject("txtDateStop.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDateStop.Properties.Mask.BeepOnError = CType(resources.GetObject("txtDateStop.Properties.Mask.BeepOnError"), Boolean)
        Me.txtDateStop.Properties.Mask.EditMask = resources.GetString("txtDateStop.Properties.Mask.EditMask")
        Me.txtDateStop.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDateStop.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDateStop.Properties.Mask.MaskType = CType(resources.GetObject("txtDateStop.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDateStop.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtDateStop.Properties.Mask.PlaceHolder"), Char)
        Me.txtDateStop.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtDateStop.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtDateStop.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDateStop.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDateStop.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDateStop.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDateStop.Properties.NullValuePrompt = resources.GetString("txtDateStop.Properties.NullValuePrompt")
        Me.txtDateStop.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtDateStop.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'txtDateStart
        '
        resources.ApplyResources(Me.txtDateStart, "txtDateStart")
        Me.txtDateStart.EnterMoveNextControl = True
        Me.txtDateStart.Name = "txtDateStart"
        Me.txtDateStart.Properties.AccessibleDescription = resources.GetString("txtDateStart.Properties.AccessibleDescription")
        Me.txtDateStart.Properties.AccessibleName = resources.GetString("txtDateStart.Properties.AccessibleName")
        Me.txtDateStart.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtDateStart.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtDateStart.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtDateStart.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtDateStart.Properties.Appearance.GradientMode = CType(resources.GetObject("txtDateStart.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtDateStart.Properties.Appearance.Image = CType(resources.GetObject("txtDateStart.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtDateStart.Properties.Appearance.Options.UseFont = True
        Me.txtDateStart.Properties.AutoHeight = CType(resources.GetObject("txtDateStart.Properties.AutoHeight"), Boolean)
        Me.txtDateStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateStart.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateStart.Properties.CalendarTimeProperties.AccessibleDescription = resources.GetString("txtDateStart.Properties.CalendarTimeProperties.AccessibleDescription")
        Me.txtDateStart.Properties.CalendarTimeProperties.AccessibleName = resources.GetString("txtDateStart.Properties.CalendarTimeProperties.AccessibleName")
        Me.txtDateStart.Properties.CalendarTimeProperties.AutoHeight = CType(resources.GetObject("txtDateStart.Properties.CalendarTimeProperties.AutoHeight"), Boolean)
        Me.txtDateStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateStart.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateStart.Properties.CalendarTimeProperties.Mask.AutoComplete = CType(resources.GetObject("txtDateStart.Properties.CalendarTimeProperties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDateStart.Properties.CalendarTimeProperties.Mask.BeepOnError = CType(resources.GetObject("txtDateStart.Properties.CalendarTimeProperties.Mask.BeepOnError"), Boolean)
        Me.txtDateStart.Properties.CalendarTimeProperties.Mask.EditMask = resources.GetString("txtDateStart.Properties.CalendarTimeProperties.Mask.EditMask")
        Me.txtDateStart.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDateStart.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDateStart.Properties.CalendarTimeProperties.Mask.MaskType = CType(resources.GetObject("txtDateStart.Properties.CalendarTimeProperties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDateStart.Properties.CalendarTimeProperties.Mask.PlaceHolder = CType(resources.GetObject("txtDateStart.Properties.CalendarTimeProperties.Mask.PlaceHolder"), Char)
        Me.txtDateStart.Properties.CalendarTimeProperties.Mask.SaveLiteral = CType(resources.GetObject("txtDateStart.Properties.CalendarTimeProperties.Mask.SaveLiteral"), Boolean)
        Me.txtDateStart.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDateStart.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDateStart.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDateStart.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDateStart.Properties.CalendarTimeProperties.NullValuePrompt = resources.GetString("txtDateStart.Properties.CalendarTimeProperties.NullValuePrompt")
        Me.txtDateStart.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtDateStart.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.txtDateStart.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtDateStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDateStart.Properties.Mask.AutoComplete = CType(resources.GetObject("txtDateStart.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDateStart.Properties.Mask.BeepOnError = CType(resources.GetObject("txtDateStart.Properties.Mask.BeepOnError"), Boolean)
        Me.txtDateStart.Properties.Mask.EditMask = resources.GetString("txtDateStart.Properties.Mask.EditMask")
        Me.txtDateStart.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDateStart.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDateStart.Properties.Mask.MaskType = CType(resources.GetObject("txtDateStart.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDateStart.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtDateStart.Properties.Mask.PlaceHolder"), Char)
        Me.txtDateStart.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtDateStart.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtDateStart.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDateStart.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDateStart.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDateStart.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDateStart.Properties.NullValuePrompt = resources.GetString("txtDateStart.Properties.NullValuePrompt")
        Me.txtDateStart.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtDateStart.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'cboCompany
        '
        resources.ApplyResources(Me.cboCompany, "cboCompany")
        Me.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompany.FormattingEnabled = True
        Me.cboCompany.Name = "cboCompany"
        '
        'cboEmpGroup
        '
        resources.ApplyResources(Me.cboEmpGroup, "cboEmpGroup")
        Me.cboEmpGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpGroup.FormattingEnabled = True
        Me.cboEmpGroup.Name = "cboEmpGroup"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'GroupControl1
        '
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Controls.Add(Me.btnCurrentDate)
        Me.GroupControl1.Controls.Add(Me.cboMonth)
        Me.GroupControl1.Controls.Add(Me.btnAllMonth)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtYear)
        Me.GroupControl1.Controls.Add(Me.btnToDate)
        Me.GroupControl1.Controls.Add(Me.txtDateStop)
        Me.GroupControl1.Controls.Add(Me.txtDateStart)
        Me.GroupControl1.Name = "GroupControl1"
        '
        'btnCurrentDate
        '
        resources.ApplyResources(Me.btnCurrentDate, "btnCurrentDate")
        Me.btnCurrentDate.Name = "btnCurrentDate"
        '
        'cboMonth
        '
        resources.ApplyResources(Me.cboMonth, "cboMonth")
        Me.cboMonth.EnterMoveNextControl = True
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
        'btnAllMonth
        '
        resources.ApplyResources(Me.btnAllMonth, "btnAllMonth")
        Me.btnAllMonth.Name = "btnAllMonth"
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Appearance.FontSizeDelta = CType(resources.GetObject("LabelControl1.Appearance.FontSizeDelta"), Integer)
        Me.LabelControl1.Appearance.FontStyleDelta = CType(resources.GetObject("LabelControl1.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.LabelControl1.Appearance.GradientMode = CType(resources.GetObject("LabelControl1.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.LabelControl1.Appearance.Image = CType(resources.GetObject("LabelControl1.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Name = "LabelControl1"
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        '
        'txtYear
        '
        resources.ApplyResources(Me.txtYear, "txtYear")
        Me.txtYear.EnterMoveNextControl = True
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
        'btnToDate
        '
        resources.ApplyResources(Me.btnToDate, "btnToDate")
        Me.btnToDate.Name = "btnToDate"
        '
        'GroupControl2
        '
        resources.ApplyResources(Me.GroupControl2, "GroupControl2")
        Me.GroupControl2.Controls.Add(Me.cboDepartment)
        Me.GroupControl2.Controls.Add(Me.cboDivision)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Name = "GroupControl2"
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
        'LabelControl4
        '
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Appearance.FontSizeDelta = CType(resources.GetObject("LabelControl4.Appearance.FontSizeDelta"), Integer)
        Me.LabelControl4.Appearance.FontStyleDelta = CType(resources.GetObject("LabelControl4.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.LabelControl4.Appearance.GradientMode = CType(resources.GetObject("LabelControl4.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.LabelControl4.Appearance.Image = CType(resources.GetObject("LabelControl4.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Name = "LabelControl4"
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Appearance.FontSizeDelta = CType(resources.GetObject("LabelControl3.Appearance.FontSizeDelta"), Integer)
        Me.LabelControl3.Appearance.FontStyleDelta = CType(resources.GetObject("LabelControl3.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.LabelControl3.Appearance.GradientMode = CType(resources.GetObject("LabelControl3.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.LabelControl3.Appearance.Image = CType(resources.GetObject("LabelControl3.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Name = "LabelControl3"
        '
        'GroupControl4
        '
        resources.ApplyResources(Me.GroupControl4, "GroupControl4")
        Me.GroupControl4.Controls.Add(Me.txtShowName)
        Me.GroupControl4.Controls.Add(Me.txtNameSearch)
        Me.GroupControl4.Controls.Add(Me.LabelControl6)
        Me.GroupControl4.Controls.Add(Me.LabelControl5)
        Me.GroupControl4.Controls.Add(Me.txtCode1)
        Me.GroupControl4.Name = "GroupControl4"
        '
        'txtShowName
        '
        resources.ApplyResources(Me.txtShowName, "txtShowName")
        Me.txtShowName.Name = "txtShowName"
        Me.txtShowName.Properties.AccessibleDescription = resources.GetString("txtShowName.Properties.AccessibleDescription")
        Me.txtShowName.Properties.AccessibleName = resources.GetString("txtShowName.Properties.AccessibleName")
        Me.txtShowName.Properties.AutoHeight = CType(resources.GetObject("txtShowName.Properties.AutoHeight"), Boolean)
        Me.txtShowName.Properties.Mask.AutoComplete = CType(resources.GetObject("txtShowName.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtShowName.Properties.Mask.BeepOnError = CType(resources.GetObject("txtShowName.Properties.Mask.BeepOnError"), Boolean)
        Me.txtShowName.Properties.Mask.EditMask = resources.GetString("txtShowName.Properties.Mask.EditMask")
        Me.txtShowName.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtShowName.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtShowName.Properties.Mask.MaskType = CType(resources.GetObject("txtShowName.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtShowName.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtShowName.Properties.Mask.PlaceHolder"), Char)
        Me.txtShowName.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtShowName.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtShowName.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtShowName.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtShowName.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtShowName.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtShowName.Properties.NullValuePrompt = resources.GetString("txtShowName.Properties.NullValuePrompt")
        Me.txtShowName.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtShowName.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.txtShowName.Properties.ReadOnly = True
        '
        'txtNameSearch
        '
        resources.ApplyResources(Me.txtNameSearch, "txtNameSearch")
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
        'LabelControl6
        '
        resources.ApplyResources(Me.LabelControl6, "LabelControl6")
        Me.LabelControl6.Appearance.FontSizeDelta = CType(resources.GetObject("LabelControl6.Appearance.FontSizeDelta"), Integer)
        Me.LabelControl6.Appearance.FontStyleDelta = CType(resources.GetObject("LabelControl6.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.LabelControl6.Appearance.GradientMode = CType(resources.GetObject("LabelControl6.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.LabelControl6.Appearance.Image = CType(resources.GetObject("LabelControl6.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl6.Appearance.Options.UseTextOptions = True
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.Name = "LabelControl6"
        '
        'LabelControl5
        '
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Appearance.FontSizeDelta = CType(resources.GetObject("LabelControl5.Appearance.FontSizeDelta"), Integer)
        Me.LabelControl5.Appearance.FontStyleDelta = CType(resources.GetObject("LabelControl5.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.LabelControl5.Appearance.GradientMode = CType(resources.GetObject("LabelControl5.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.LabelControl5.Appearance.Image = CType(resources.GetObject("LabelControl5.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Name = "LabelControl5"
        '
        'txtCode1
        '
        resources.ApplyResources(Me.txtCode1, "txtCode1")
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
        'frmRptAllEmpWork
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.cboEmpGroup)
        Me.Controls.Add(Me.cboCompany)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.KeyPreview = True
        Me.Name = "frmRptAllEmpWork"
        CType(Me.txtDateStop.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateStop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cboMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.txtShowName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboCompany As System.Windows.Forms.ComboBox
    Friend WithEvents cboEmpGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDateStop As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDateStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboDepartment As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboDivision As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtShowName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNameSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCode1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCurrentDate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboMonth As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnAllMonth As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtYear As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnToDate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
