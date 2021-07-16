<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRpt_OTreport
    '  Inherits System.Windows.Forms.Form
    Inherits DevExpress.XtraEditors.XtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRpt_OTreport))
        Me.txtDateStop = New DevExpress.XtraEditors.DateEdit()
        Me.PbOverall = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.txtDateStart = New DevExpress.XtraEditors.DateEdit()
        Me.PB_Emp = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.cboCompany = New System.Windows.Forms.ComboBox()
        Me.cboEmpGroup = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnCurrentDate = New DevExpress.XtraEditors.SimpleButton()
        Me.cboMonth = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnAllMonth = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtYear = New DevExpress.XtraEditors.TextEdit()
        Me.btnTodate = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.cboDepartment = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboDivision = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.chkOT = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDay = New DevExpress.XtraEditors.CheckEdit()
        Me.txtFixedWHour = New DevExpress.XtraEditors.TextEdit()
        Me.chkFixedWHour = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        Me.txtNameSearch = New DevExpress.XtraEditors.TextEdit()
        Me.txtCode1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
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
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.chkOT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFixedWHour.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFixedWHour.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'PbOverall
        '
        resources.ApplyResources(Me.PbOverall, "PbOverall")
        '
        '
        '
        Me.PbOverall.BackgroundStyle.Class = ""
        Me.PbOverall.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PbOverall.Name = "PbOverall"
        Me.PbOverall.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
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
        'PB_Emp
        '
        resources.ApplyResources(Me.PB_Emp, "PB_Emp")
        '
        '
        '
        Me.PB_Emp.BackgroundStyle.Class = ""
        Me.PB_Emp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PB_Emp.Name = "PB_Emp"
        Me.PB_Emp.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
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
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
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
        Me.GroupControl1.Controls.Add(Me.btnTodate)
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
        Me.LabelControl2.Appearance.FontSizeDelta = CType(resources.GetObject("LabelControl2.Appearance.FontSizeDelta"), Integer)
        Me.LabelControl2.Appearance.FontStyleDelta = CType(resources.GetObject("LabelControl2.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.LabelControl2.Appearance.GradientMode = CType(resources.GetObject("LabelControl2.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.LabelControl2.Appearance.Image = CType(resources.GetObject("LabelControl2.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
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
        'btnTodate
        '
        resources.ApplyResources(Me.btnTodate, "btnTodate")
        Me.btnTodate.Name = "btnTodate"
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
        'GroupControl3
        '
        resources.ApplyResources(Me.GroupControl3, "GroupControl3")
        Me.GroupControl3.Controls.Add(Me.chkOT)
        Me.GroupControl3.Controls.Add(Me.chkDay)
        Me.GroupControl3.Name = "GroupControl3"
        '
        'chkOT
        '
        resources.ApplyResources(Me.chkOT, "chkOT")
        Me.chkOT.Name = "chkOT"
        Me.chkOT.Properties.AccessibleDescription = resources.GetString("chkOT.Properties.AccessibleDescription")
        Me.chkOT.Properties.AccessibleName = resources.GetString("chkOT.Properties.AccessibleName")
        Me.chkOT.Properties.AutoHeight = CType(resources.GetObject("chkOT.Properties.AutoHeight"), Boolean)
        Me.chkOT.Properties.Caption = resources.GetString("chkOT.Properties.Caption")
        Me.chkOT.Properties.DisplayValueChecked = resources.GetString("chkOT.Properties.DisplayValueChecked")
        Me.chkOT.Properties.DisplayValueGrayed = resources.GetString("chkOT.Properties.DisplayValueGrayed")
        Me.chkOT.Properties.DisplayValueUnchecked = resources.GetString("chkOT.Properties.DisplayValueUnchecked")
        '
        'chkDay
        '
        resources.ApplyResources(Me.chkDay, "chkDay")
        Me.chkDay.Name = "chkDay"
        Me.chkDay.Properties.AccessibleDescription = resources.GetString("chkDay.Properties.AccessibleDescription")
        Me.chkDay.Properties.AccessibleName = resources.GetString("chkDay.Properties.AccessibleName")
        Me.chkDay.Properties.AutoHeight = CType(resources.GetObject("chkDay.Properties.AutoHeight"), Boolean)
        Me.chkDay.Properties.Caption = resources.GetString("chkDay.Properties.Caption")
        Me.chkDay.Properties.DisplayValueChecked = resources.GetString("chkDay.Properties.DisplayValueChecked")
        Me.chkDay.Properties.DisplayValueGrayed = resources.GetString("chkDay.Properties.DisplayValueGrayed")
        Me.chkDay.Properties.DisplayValueUnchecked = resources.GetString("chkDay.Properties.DisplayValueUnchecked")
        '
        'txtFixedWHour
        '
        resources.ApplyResources(Me.txtFixedWHour, "txtFixedWHour")
        Me.txtFixedWHour.Name = "txtFixedWHour"
        Me.txtFixedWHour.Properties.AccessibleDescription = resources.GetString("txtFixedWHour.Properties.AccessibleDescription")
        Me.txtFixedWHour.Properties.AccessibleName = resources.GetString("txtFixedWHour.Properties.AccessibleName")
        Me.txtFixedWHour.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtFixedWHour.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtFixedWHour.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtFixedWHour.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtFixedWHour.Properties.Appearance.GradientMode = CType(resources.GetObject("txtFixedWHour.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtFixedWHour.Properties.Appearance.Image = CType(resources.GetObject("txtFixedWHour.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtFixedWHour.Properties.Appearance.Options.UseTextOptions = True
        Me.txtFixedWHour.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtFixedWHour.Properties.AutoHeight = CType(resources.GetObject("txtFixedWHour.Properties.AutoHeight"), Boolean)
        Me.txtFixedWHour.Properties.Mask.AutoComplete = CType(resources.GetObject("txtFixedWHour.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtFixedWHour.Properties.Mask.BeepOnError = CType(resources.GetObject("txtFixedWHour.Properties.Mask.BeepOnError"), Boolean)
        Me.txtFixedWHour.Properties.Mask.EditMask = resources.GetString("txtFixedWHour.Properties.Mask.EditMask")
        Me.txtFixedWHour.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtFixedWHour.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtFixedWHour.Properties.Mask.MaskType = CType(resources.GetObject("txtFixedWHour.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtFixedWHour.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtFixedWHour.Properties.Mask.PlaceHolder"), Char)
        Me.txtFixedWHour.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtFixedWHour.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtFixedWHour.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtFixedWHour.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtFixedWHour.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtFixedWHour.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtFixedWHour.Properties.NullValuePrompt = resources.GetString("txtFixedWHour.Properties.NullValuePrompt")
        Me.txtFixedWHour.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtFixedWHour.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'chkFixedWHour
        '
        resources.ApplyResources(Me.chkFixedWHour, "chkFixedWHour")
        Me.chkFixedWHour.Name = "chkFixedWHour"
        Me.chkFixedWHour.Properties.AccessibleDescription = resources.GetString("chkFixedWHour.Properties.AccessibleDescription")
        Me.chkFixedWHour.Properties.AccessibleName = resources.GetString("chkFixedWHour.Properties.AccessibleName")
        Me.chkFixedWHour.Properties.AutoHeight = CType(resources.GetObject("chkFixedWHour.Properties.AutoHeight"), Boolean)
        Me.chkFixedWHour.Properties.Caption = resources.GetString("chkFixedWHour.Properties.Caption")
        Me.chkFixedWHour.Properties.DisplayValueChecked = resources.GetString("chkFixedWHour.Properties.DisplayValueChecked")
        Me.chkFixedWHour.Properties.DisplayValueGrayed = resources.GetString("chkFixedWHour.Properties.DisplayValueGrayed")
        Me.chkFixedWHour.Properties.DisplayValueUnchecked = resources.GetString("chkFixedWHour.Properties.DisplayValueUnchecked")
        '
        'GroupControl4
        '
        resources.ApplyResources(Me.GroupControl4, "GroupControl4")
        Me.GroupControl4.Controls.Add(Me.txtName)
        Me.GroupControl4.Controls.Add(Me.txtNameSearch)
        Me.GroupControl4.Controls.Add(Me.txtCode1)
        Me.GroupControl4.Controls.Add(Me.LabelControl6)
        Me.GroupControl4.Controls.Add(Me.LabelControl5)
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
        'frmRpt_OTreport
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtFixedWHour)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.chkFixedWHour)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.PbOverall)
        Me.Controls.Add(Me.PB_Emp)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.cboEmpGroup)
        Me.Controls.Add(Me.cboCompany)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmRpt_OTreport"
        CType(Me.txtDateStop.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateStop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.cboMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.chkOT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFixedWHour.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFixedWHour.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboCompany As System.Windows.Forms.ComboBox
    Friend WithEvents cboEmpGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PbOverall As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents PB_Emp As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDateStop As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDateStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboDepartment As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboDivision As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNameSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCode1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkOT As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkDay As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkFixedWHour As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtFixedWHour As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnTodate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCurrentDate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboMonth As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnAllMonth As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtYear As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
