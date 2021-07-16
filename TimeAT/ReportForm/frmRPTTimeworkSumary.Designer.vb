<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTTimeworkSumary
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTTimeworkSumary))
        Me.txtDateStart = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtDateStop = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.btnReport = New DevComponents.DotNetBar.ButtonX()
        Me.btnExit = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.ProgressBar1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.txtNameSearch = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtEmpId = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cboBroker = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboEmpGroup = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboCompany = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rdContractor = New System.Windows.Forms.RadioButton()
        Me.rdDay = New System.Windows.Forms.RadioButton()
        Me.rdMonth = New System.Windows.Forms.RadioButton()
        Me.rdAll = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboPosition = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboDepartment = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboDivision = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboSection = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.txtDateStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateStop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel3.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.cboPosition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDateStart
        '
        '
        '
        '
        Me.txtDateStart.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtDateStart.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDateStart.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.txtDateStart.ButtonDropDown.Visible = True
        resources.ApplyResources(Me.txtDateStart, "txtDateStart")
        Me.txtDateStart.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.txtDateStart.IsPopupCalendarOpen = False
        '
        '
        '
        Me.txtDateStart.MonthCalendar.AnnuallyMarkedDates = CType(resources.GetObject("txtDateStart.MonthCalendar.AnnuallyMarkedDates"), Date())
        '
        '
        '
        Me.txtDateStart.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.txtDateStart.MonthCalendar.BackgroundStyle.Class = ""
        Me.txtDateStart.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDateStart.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.txtDateStart.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txtDateStart.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.txtDateStart.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.txtDateStart.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtDateStart.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txtDateStart.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.txtDateStart.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.txtDateStart.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDateStart.MonthCalendar.DisplayMonth = New Date(2012, 1, 1, 0, 0, 0, 0)
        Me.txtDateStart.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.txtDateStart.MonthCalendar.MarkedDates = CType(resources.GetObject("txtDateStart.MonthCalendar.MarkedDates"), Date())
        Me.txtDateStart.MonthCalendar.MonthlyMarkedDates = CType(resources.GetObject("txtDateStart.MonthCalendar.MonthlyMarkedDates"), Date())
        '
        '
        '
        Me.txtDateStart.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.txtDateStart.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.txtDateStart.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.txtDateStart.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.txtDateStart.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDateStart.MonthCalendar.TodayButtonVisible = True
        Me.txtDateStart.MonthCalendar.WeeklyMarkedDays = CType(resources.GetObject("txtDateStart.MonthCalendar.WeeklyMarkedDays"), System.DayOfWeek())
        Me.txtDateStart.Name = "txtDateStart"
        Me.txtDateStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
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
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtDateStop
        '
        '
        '
        '
        Me.txtDateStop.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtDateStop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDateStop.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.txtDateStop.ButtonDropDown.Visible = True
        resources.ApplyResources(Me.txtDateStop, "txtDateStop")
        Me.txtDateStop.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.txtDateStop.IsPopupCalendarOpen = False
        '
        '
        '
        Me.txtDateStop.MonthCalendar.AnnuallyMarkedDates = CType(resources.GetObject("txtDateStop.MonthCalendar.AnnuallyMarkedDates"), Date())
        '
        '
        '
        Me.txtDateStop.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.txtDateStop.MonthCalendar.BackgroundStyle.Class = ""
        Me.txtDateStop.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDateStop.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.txtDateStop.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txtDateStop.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.txtDateStop.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.txtDateStop.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtDateStop.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txtDateStop.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.txtDateStop.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.txtDateStop.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDateStop.MonthCalendar.DisplayMonth = New Date(2012, 1, 1, 0, 0, 0, 0)
        Me.txtDateStop.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.txtDateStop.MonthCalendar.MarkedDates = CType(resources.GetObject("txtDateStop.MonthCalendar.MarkedDates"), Date())
        Me.txtDateStop.MonthCalendar.MonthlyMarkedDates = CType(resources.GetObject("txtDateStop.MonthCalendar.MonthlyMarkedDates"), Date())
        '
        '
        '
        Me.txtDateStop.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.txtDateStop.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.txtDateStop.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.txtDateStop.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.txtDateStop.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDateStop.MonthCalendar.TodayButtonVisible = True
        Me.txtDateStop.MonthCalendar.WeeklyMarkedDays = CType(resources.GetObject("txtDateStop.MonthCalendar.WeeklyMarkedDays"), System.DayOfWeek())
        Me.txtDateStop.Name = "txtDateStop"
        Me.txtDateStop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'btnReport
        '
        Me.btnReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.btnReport, "btnReport")
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'btnExit
        '
        Me.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'GroupPanel3
        '
        Me.GroupPanel3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.txtDateStart)
        Me.GroupPanel3.Controls.Add(Me.txtDateStop)
        Me.GroupPanel3.Controls.Add(Me.LabelX1)
        Me.GroupPanel3.Controls.Add(Me.LabelX2)
        resources.ApplyResources(Me.GroupPanel3, "GroupPanel3")
        Me.GroupPanel3.Name = "GroupPanel3"
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuUnusedSide2
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
        'PanelEx2
        '
        resources.ApplyResources(Me.PanelEx2, "PanelEx2")
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.cboPosition)
        Me.PanelEx2.Controls.Add(Me.cboSection)
        Me.PanelEx2.Controls.Add(Me.cboDepartment)
        Me.PanelEx2.Controls.Add(Me.cboDivision)
        Me.PanelEx2.Controls.Add(Me.ProgressBar1)
        Me.PanelEx2.Controls.Add(Me.txtNameSearch)
        Me.PanelEx2.Controls.Add(Me.btnExit)
        Me.PanelEx2.Controls.Add(Me.txtEmpId)
        Me.PanelEx2.Controls.Add(Me.btnReport)
        Me.PanelEx2.Controls.Add(Me.cboBroker)
        Me.PanelEx2.Controls.Add(Me.cboEmpGroup)
        Me.PanelEx2.Controls.Add(Me.cboCompany)
        Me.PanelEx2.Controls.Add(Me.Label3)
        Me.PanelEx2.Controls.Add(Me.GroupBox5)
        Me.PanelEx2.Controls.Add(Me.Label4)
        Me.PanelEx2.Controls.Add(Me.Label10)
        Me.PanelEx2.Controls.Add(Me.Label5)
        Me.PanelEx2.Controls.Add(Me.Label6)
        Me.PanelEx2.Controls.Add(Me.Label7)
        Me.PanelEx2.Controls.Add(Me.Label8)
        Me.PanelEx2.Controls.Add(Me.Label11)
        Me.PanelEx2.Controls.Add(Me.Label12)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.Color.WhiteSmoke
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        '
        'ProgressBar1
        '
        '
        '
        '
        Me.ProgressBar1.BackgroundStyle.Class = ""
        Me.ProgressBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.TextVisible = True
        '
        'txtNameSearch
        '
        '
        '
        '
        Me.txtNameSearch.Border.Class = "TextBoxBorder"
        Me.txtNameSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.txtNameSearch, "txtNameSearch")
        Me.txtNameSearch.Name = "txtNameSearch"
        '
        'txtEmpId
        '
        '
        '
        '
        Me.txtEmpId.Border.Class = "TextBoxBorder"
        Me.txtEmpId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.txtEmpId, "txtEmpId")
        Me.txtEmpId.Name = "txtEmpId"
        '
        'cboBroker
        '
        Me.cboBroker.DisplayMember = "Text"
        Me.cboBroker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboBroker.FormattingEnabled = True
        resources.ApplyResources(Me.cboBroker, "cboBroker")
        Me.cboBroker.Name = "cboBroker"
        Me.cboBroker.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cboEmpGroup
        '
        Me.cboEmpGroup.DisplayMember = "Text"
        Me.cboEmpGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboEmpGroup.FormattingEnabled = True
        resources.ApplyResources(Me.cboEmpGroup, "cboEmpGroup")
        Me.cboEmpGroup.Name = "cboEmpGroup"
        Me.cboEmpGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cboCompany
        '
        Me.cboCompany.DisplayMember = "Text"
        Me.cboCompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompany.FormattingEnabled = True
        resources.ApplyResources(Me.cboCompany, "cboCompany")
        Me.cboCompany.Name = "cboCompany"
        Me.cboCompany.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rdContractor)
        Me.GroupBox5.Controls.Add(Me.rdDay)
        Me.GroupBox5.Controls.Add(Me.rdMonth)
        Me.GroupBox5.Controls.Add(Me.rdAll)
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        '
        'rdContractor
        '
        resources.ApplyResources(Me.rdContractor, "rdContractor")
        Me.rdContractor.Name = "rdContractor"
        Me.rdContractor.UseVisualStyleBackColor = True
        '
        'rdDay
        '
        resources.ApplyResources(Me.rdDay, "rdDay")
        Me.rdDay.Name = "rdDay"
        Me.rdDay.UseVisualStyleBackColor = True
        '
        'rdMonth
        '
        resources.ApplyResources(Me.rdMonth, "rdMonth")
        Me.rdMonth.Name = "rdMonth"
        Me.rdMonth.UseVisualStyleBackColor = True
        '
        'rdAll
        '
        resources.ApplyResources(Me.rdAll, "rdAll")
        Me.rdAll.Checked = True
        Me.rdAll.Name = "rdAll"
        Me.rdAll.TabStop = True
        Me.rdAll.UseVisualStyleBackColor = True
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
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
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'cboPosition
        '
        resources.ApplyResources(Me.cboPosition, "cboPosition")
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboPosition.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboPosition.Properties.DropDownRows = 15
        Me.cboPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'cboDepartment
        '
        resources.ApplyResources(Me.cboDepartment, "cboDepartment")
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboDepartment.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboDepartment.Properties.DropDownRows = 15
        Me.cboDepartment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'cboDivision
        '
        resources.ApplyResources(Me.cboDivision, "cboDivision")
        Me.cboDivision.Name = "cboDivision"
        Me.cboDivision.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboDivision.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboDivision.Properties.DropDownRows = 15
        Me.cboDivision.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'cboSection
        '
        resources.ApplyResources(Me.cboSection, "cboSection")
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("ComboBoxEdit1.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboSection.Properties.DropDownRows = 15
        Me.cboSection.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'frmRPTTimeworkSumary
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.GroupPanel3)
        Me.Name = "frmRPTTimeworkSumary"
        CType(Me.txtDateStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateStop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel3.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.cboPosition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtDateStart As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDateStop As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents btnReport As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ProgressBar1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents txtNameSearch As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtEmpId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cboBroker As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboEmpGroup As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboCompany As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rdContractor As System.Windows.Forms.RadioButton
    Friend WithEvents rdDay As System.Windows.Forms.RadioButton
    Friend WithEvents rdMonth As System.Windows.Forms.RadioButton
    Friend WithEvents rdAll As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboPosition As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboSection As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboDepartment As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboDivision As DevExpress.XtraEditors.ComboBoxEdit
End Class
