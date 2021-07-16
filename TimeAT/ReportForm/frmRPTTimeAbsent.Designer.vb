<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTTimeAbsent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTTimeAbsent))
        Me.txtDateStart = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.txtDateStop = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.btnReport = New DevComponents.DotNetBar.ButtonX
        Me.btnExit = New DevComponents.DotNetBar.ButtonX
        Me.cboSection = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.cboDepartment = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.cboDivision = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.ProcessBar1 = New DevComponents.DotNetBar.Controls.ProgressBarX
        Me.cbDivision = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.cbDepartment = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.cbSection = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.cboCompany = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.Label6 = New System.Windows.Forms.Label
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        CType(Me.txtDateStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateStop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDateStart
        '
        Me.txtDateStart.AccessibleDescription = Nothing
        Me.txtDateStart.AccessibleName = Nothing
        resources.ApplyResources(Me.txtDateStart, "txtDateStart")
        Me.txtDateStart.BackgroundImage = Nothing
        '
        '
        '
        Me.txtDateStart.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtDateStart.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDateStart.ButtonClear.DisplayPosition = CType(resources.GetObject("txtDateStart.ButtonClear.DisplayPosition"), Integer)
        Me.txtDateStart.ButtonClear.Image = Nothing
        Me.txtDateStart.ButtonClear.Text = resources.GetString("txtDateStart.ButtonClear.Text")
        Me.txtDateStart.ButtonCustom.DisplayPosition = CType(resources.GetObject("txtDateStart.ButtonCustom.DisplayPosition"), Integer)
        Me.txtDateStart.ButtonCustom.Image = Nothing
        Me.txtDateStart.ButtonCustom.Text = resources.GetString("txtDateStart.ButtonCustom.Text")
        Me.txtDateStart.ButtonCustom2.DisplayPosition = CType(resources.GetObject("txtDateStart.ButtonCustom2.DisplayPosition"), Integer)
        Me.txtDateStart.ButtonCustom2.Image = Nothing
        Me.txtDateStart.ButtonCustom2.Text = resources.GetString("txtDateStart.ButtonCustom2.Text")
        Me.txtDateStart.ButtonDropDown.DisplayPosition = CType(resources.GetObject("txtDateStart.ButtonDropDown.DisplayPosition"), Integer)
        Me.txtDateStart.ButtonDropDown.Image = Nothing
        Me.txtDateStart.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.txtDateStart.ButtonDropDown.Text = resources.GetString("txtDateStart.ButtonDropDown.Text")
        Me.txtDateStart.ButtonDropDown.Visible = True
        Me.txtDateStart.ButtonFreeText.DisplayPosition = CType(resources.GetObject("txtDateStart.ButtonFreeText.DisplayPosition"), Integer)
        Me.txtDateStart.ButtonFreeText.Image = Nothing
        Me.txtDateStart.ButtonFreeText.Text = resources.GetString("txtDateStart.ButtonFreeText.Text")
        Me.txtDateStart.CommandParameter = Nothing
        Me.txtDateStart.Font = Nothing
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
        Me.txtDateStart.MonthCalendar.Category = resources.GetString("txtDateStart.MonthCalendar.Category")
        Me.txtDateStart.MonthCalendar.ClearButtonVisible = True
        Me.txtDateStart.MonthCalendar.CommandParameter = Nothing
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
        Me.txtDateStart.MonthCalendar.DayNames = Nothing
        Me.txtDateStart.MonthCalendar.Description = resources.GetString("txtDateStart.MonthCalendar.Description")
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
        Me.txtDateStart.MonthCalendar.Tag = resources.GetString("txtDateStart.MonthCalendar.Tag")
        Me.txtDateStart.MonthCalendar.Text = resources.GetString("txtDateStart.MonthCalendar.Text")
        Me.txtDateStart.MonthCalendar.TodayButtonVisible = True
        Me.txtDateStart.MonthCalendar.Tooltip = resources.GetString("txtDateStart.MonthCalendar.Tooltip")
        Me.txtDateStart.MonthCalendar.WeeklyMarkedDays = CType(resources.GetObject("txtDateStart.MonthCalendar.WeeklyMarkedDays"), System.DayOfWeek())
        Me.txtDateStart.Name = "txtDateStart"
        Me.txtDateStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'LabelX2
        '
        Me.LabelX2.AccessibleDescription = Nothing
        Me.LabelX2.AccessibleName = Nothing
        resources.ApplyResources(Me.LabelX2, "LabelX2")
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.BackgroundImage = Nothing
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.CommandParameter = Nothing
        Me.LabelX2.Font = Nothing
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtDateStop
        '
        Me.txtDateStop.AccessibleDescription = Nothing
        Me.txtDateStop.AccessibleName = Nothing
        resources.ApplyResources(Me.txtDateStop, "txtDateStop")
        Me.txtDateStop.BackgroundImage = Nothing
        '
        '
        '
        Me.txtDateStop.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtDateStop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDateStop.ButtonClear.DisplayPosition = CType(resources.GetObject("txtDateStop.ButtonClear.DisplayPosition"), Integer)
        Me.txtDateStop.ButtonClear.Image = Nothing
        Me.txtDateStop.ButtonClear.Text = resources.GetString("txtDateStop.ButtonClear.Text")
        Me.txtDateStop.ButtonCustom.DisplayPosition = CType(resources.GetObject("txtDateStop.ButtonCustom.DisplayPosition"), Integer)
        Me.txtDateStop.ButtonCustom.Image = Nothing
        Me.txtDateStop.ButtonCustom.Text = resources.GetString("txtDateStop.ButtonCustom.Text")
        Me.txtDateStop.ButtonCustom2.DisplayPosition = CType(resources.GetObject("txtDateStop.ButtonCustom2.DisplayPosition"), Integer)
        Me.txtDateStop.ButtonCustom2.Image = Nothing
        Me.txtDateStop.ButtonCustom2.Text = resources.GetString("txtDateStop.ButtonCustom2.Text")
        Me.txtDateStop.ButtonDropDown.DisplayPosition = CType(resources.GetObject("txtDateStop.ButtonDropDown.DisplayPosition"), Integer)
        Me.txtDateStop.ButtonDropDown.Image = Nothing
        Me.txtDateStop.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.txtDateStop.ButtonDropDown.Text = resources.GetString("txtDateStop.ButtonDropDown.Text")
        Me.txtDateStop.ButtonDropDown.Visible = True
        Me.txtDateStop.ButtonFreeText.DisplayPosition = CType(resources.GetObject("txtDateStop.ButtonFreeText.DisplayPosition"), Integer)
        Me.txtDateStop.ButtonFreeText.Image = Nothing
        Me.txtDateStop.ButtonFreeText.Text = resources.GetString("txtDateStop.ButtonFreeText.Text")
        Me.txtDateStop.CommandParameter = Nothing
        Me.txtDateStop.Font = Nothing
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
        Me.txtDateStop.MonthCalendar.Category = resources.GetString("txtDateStop.MonthCalendar.Category")
        Me.txtDateStop.MonthCalendar.ClearButtonVisible = True
        Me.txtDateStop.MonthCalendar.CommandParameter = Nothing
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
        Me.txtDateStop.MonthCalendar.DayNames = Nothing
        Me.txtDateStop.MonthCalendar.Description = resources.GetString("txtDateStop.MonthCalendar.Description")
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
        Me.txtDateStop.MonthCalendar.Tag = resources.GetString("txtDateStop.MonthCalendar.Tag")
        Me.txtDateStop.MonthCalendar.Text = resources.GetString("txtDateStop.MonthCalendar.Text")
        Me.txtDateStop.MonthCalendar.TodayButtonVisible = True
        Me.txtDateStop.MonthCalendar.Tooltip = resources.GetString("txtDateStop.MonthCalendar.Tooltip")
        Me.txtDateStop.MonthCalendar.WeeklyMarkedDays = CType(resources.GetObject("txtDateStop.MonthCalendar.WeeklyMarkedDays"), System.DayOfWeek())
        Me.txtDateStop.Name = "txtDateStop"
        Me.txtDateStop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'btnReport
        '
        Me.btnReport.AccessibleDescription = Nothing
        Me.btnReport.AccessibleName = Nothing
        Me.btnReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        resources.ApplyResources(Me.btnReport, "btnReport")
        Me.btnReport.BackgroundImage = Nothing
        Me.btnReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnReport.CommandParameter = Nothing
        Me.btnReport.Font = Nothing
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'btnExit
        '
        Me.btnExit.AccessibleDescription = Nothing
        Me.btnExit.AccessibleName = Nothing
        Me.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.BackgroundImage = Nothing
        Me.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExit.CommandParameter = Nothing
        Me.btnExit.Font = Nothing
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cboSection
        '
        Me.cboSection.AccessibleDescription = Nothing
        Me.cboSection.AccessibleName = Nothing
        resources.ApplyResources(Me.cboSection, "cboSection")
        Me.cboSection.BackgroundImage = Nothing
        Me.cboSection.CommandParameter = Nothing
        Me.cboSection.DisplayMember = "Text"
        Me.cboSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSection.Font = Nothing
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'LabelX5
        '
        Me.LabelX5.AccessibleDescription = Nothing
        Me.LabelX5.AccessibleName = Nothing
        resources.ApplyResources(Me.LabelX5, "LabelX5")
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        Me.LabelX5.BackgroundImage = Nothing
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.CommandParameter = Nothing
        Me.LabelX5.Font = Nothing
        Me.LabelX5.Name = "LabelX5"
        '
        'cboDepartment
        '
        Me.cboDepartment.AccessibleDescription = Nothing
        Me.cboDepartment.AccessibleName = Nothing
        resources.ApplyResources(Me.cboDepartment, "cboDepartment")
        Me.cboDepartment.BackgroundImage = Nothing
        Me.cboDepartment.CommandParameter = Nothing
        Me.cboDepartment.DisplayMember = "Text"
        Me.cboDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartment.Font = Nothing
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'LabelX4
        '
        Me.LabelX4.AccessibleDescription = Nothing
        Me.LabelX4.AccessibleName = Nothing
        resources.ApplyResources(Me.LabelX4, "LabelX4")
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.BackgroundImage = Nothing
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.CommandParameter = Nothing
        Me.LabelX4.Font = Nothing
        Me.LabelX4.Name = "LabelX4"
        '
        'cboDivision
        '
        Me.cboDivision.AccessibleDescription = Nothing
        Me.cboDivision.AccessibleName = Nothing
        resources.ApplyResources(Me.cboDivision, "cboDivision")
        Me.cboDivision.BackgroundImage = Nothing
        Me.cboDivision.CommandParameter = Nothing
        Me.cboDivision.DisplayMember = "Text"
        Me.cboDivision.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivision.Font = Nothing
        Me.cboDivision.FormattingEnabled = True
        Me.cboDivision.Name = "cboDivision"
        Me.cboDivision.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'LabelX3
        '
        Me.LabelX3.AccessibleDescription = Nothing
        Me.LabelX3.AccessibleName = Nothing
        resources.ApplyResources(Me.LabelX3, "LabelX3")
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.BackgroundImage = Nothing
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.CommandParameter = Nothing
        Me.LabelX3.Font = Nothing
        Me.LabelX3.Name = "LabelX3"
        '
        'ProcessBar1
        '
        Me.ProcessBar1.AccessibleDescription = Nothing
        Me.ProcessBar1.AccessibleName = Nothing
        resources.ApplyResources(Me.ProcessBar1, "ProcessBar1")
        Me.ProcessBar1.BackgroundImage = Nothing
        '
        '
        '
        Me.ProcessBar1.BackgroundStyle.Class = ""
        Me.ProcessBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProcessBar1.Font = Nothing
        Me.ProcessBar1.Name = "ProcessBar1"
        Me.ProcessBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.ProcessBar1.TextVisible = True
        '
        'cbDivision
        '
        Me.cbDivision.AccessibleDescription = Nothing
        Me.cbDivision.AccessibleName = Nothing
        resources.ApplyResources(Me.cbDivision, "cbDivision")
        Me.cbDivision.BackColor = System.Drawing.Color.Transparent
        Me.cbDivision.BackgroundImage = Nothing
        '
        '
        '
        Me.cbDivision.BackgroundStyle.Class = ""
        Me.cbDivision.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbDivision.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.cbDivision.Checked = True
        Me.cbDivision.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbDivision.CheckValue = "Y"
        Me.cbDivision.CommandParameter = Nothing
        Me.cbDivision.Font = Nothing
        Me.cbDivision.Name = "cbDivision"
        Me.cbDivision.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cbDepartment
        '
        Me.cbDepartment.AccessibleDescription = Nothing
        Me.cbDepartment.AccessibleName = Nothing
        resources.ApplyResources(Me.cbDepartment, "cbDepartment")
        Me.cbDepartment.BackColor = System.Drawing.Color.Transparent
        Me.cbDepartment.BackgroundImage = Nothing
        '
        '
        '
        Me.cbDepartment.BackgroundStyle.Class = ""
        Me.cbDepartment.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbDepartment.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.cbDepartment.CommandParameter = Nothing
        Me.cbDepartment.Font = Nothing
        Me.cbDepartment.Name = "cbDepartment"
        Me.cbDepartment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cbSection
        '
        Me.cbSection.AccessibleDescription = Nothing
        Me.cbSection.AccessibleName = Nothing
        resources.ApplyResources(Me.cbSection, "cbSection")
        Me.cbSection.BackColor = System.Drawing.Color.Transparent
        Me.cbSection.BackgroundImage = Nothing
        '
        '
        '
        Me.cbSection.BackgroundStyle.Class = ""
        Me.cbSection.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbSection.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.cbSection.CommandParameter = Nothing
        Me.cbSection.Font = Nothing
        Me.cbSection.Name = "cbSection"
        Me.cbSection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cboCompany
        '
        Me.cboCompany.AccessibleDescription = Nothing
        Me.cboCompany.AccessibleName = Nothing
        resources.ApplyResources(Me.cboCompany, "cboCompany")
        Me.cboCompany.BackgroundImage = Nothing
        Me.cboCompany.CommandParameter = Nothing
        Me.cboCompany.DisplayMember = "Text"
        Me.cboCompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompany.Font = Nothing
        Me.cboCompany.FormattingEnabled = True
        Me.cboCompany.Name = "cboCompany"
        Me.cboCompany.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'Label6
        '
        Me.Label6.AccessibleDescription = Nothing
        Me.Label6.AccessibleName = Nothing
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = Nothing
        Me.Label6.Name = "Label6"
        '
        'LabelX6
        '
        Me.LabelX6.AccessibleDescription = Nothing
        Me.LabelX6.AccessibleName = Nothing
        resources.ApplyResources(Me.LabelX6, "LabelX6")
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        Me.LabelX6.BackgroundImage = Nothing
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.CommandParameter = Nothing
        Me.LabelX6.Font = Nothing
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = Nothing
        Me.GroupBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackgroundImage = Nothing
        Me.GroupBox1.Controls.Add(Me.txtDateStart)
        Me.GroupBox1.Controls.Add(Me.txtDateStop)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX6)
        Me.GroupBox1.Font = Nothing
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleDescription = Nothing
        Me.GroupBox2.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.BackgroundImage = Nothing
        Me.GroupBox2.Controls.Add(Me.cboCompany)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cbDivision)
        Me.GroupBox2.Controls.Add(Me.cbSection)
        Me.GroupBox2.Controls.Add(Me.cbDepartment)
        Me.GroupBox2.Font = Nothing
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'frmRPTTimeAbsent
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.ProcessBar1)
        Me.Icon = Nothing
        Me.Name = "frmRPTTimeAbsent"
        CType(Me.txtDateStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateStop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtDateStart As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDateStop As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents btnReport As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cboSection As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboDepartment As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboDivision As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ProcessBar1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents cbDivision As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbDepartment As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbSection As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cboCompany As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
