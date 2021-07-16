<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTSumaryWagePerDay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTSumaryWagePerDay))
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cboEmpGroup = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.cboSection = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.cboDepartment = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.cboCompany = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.cboDivision = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.txtDateStart = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.btnReport = New DevComponents.DotNetBar.ButtonX
        Me.btnExit = New DevComponents.DotNetBar.ButtonX
        Me.GroupPanel1.SuspendLayout()
        CType(Me.txtDateStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.AccessibleDescription = Nothing
        Me.GroupPanel1.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupPanel1, "GroupPanel1")
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.cboEmpGroup)
        Me.GroupPanel1.Controls.Add(Me.LabelX6)
        Me.GroupPanel1.Controls.Add(Me.cboSection)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.LabelX5)
        Me.GroupPanel1.Controls.Add(Me.cboDepartment)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.cboCompany)
        Me.GroupPanel1.Controls.Add(Me.cboDivision)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Font = Nothing
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
        'cboEmpGroup
        '
        Me.cboEmpGroup.AccessibleDescription = Nothing
        Me.cboEmpGroup.AccessibleName = Nothing
        resources.ApplyResources(Me.cboEmpGroup, "cboEmpGroup")
        Me.cboEmpGroup.BackgroundImage = Nothing
        Me.cboEmpGroup.CommandParameter = Nothing
        Me.cboEmpGroup.DisplayMember = "Text"
        Me.cboEmpGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboEmpGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpGroup.Font = Nothing
        Me.cboEmpGroup.FormattingEnabled = True
        Me.cboEmpGroup.Name = "cboEmpGroup"
        Me.cboEmpGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
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
        'cboCompany
        '
        Me.cboCompany.AccessibleDescription = Nothing
        Me.cboCompany.AccessibleName = Nothing
        resources.ApplyResources(Me.cboCompany, "cboCompany")
        Me.cboCompany.BackgroundImage = Nothing
        Me.cboCompany.CommandParameter = Nothing
        Me.cboCompany.DisplayMember = "Text"
        Me.cboCompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompany.Font = Nothing
        Me.cboCompany.FormattingEnabled = True
        Me.cboCompany.Name = "cboCompany"
        Me.cboCompany.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
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
        'LabelX1
        '
        Me.LabelX1.AccessibleDescription = Nothing
        Me.LabelX1.AccessibleName = Nothing
        resources.ApplyResources(Me.LabelX1, "LabelX1")
        Me.LabelX1.BackgroundImage = Nothing
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.CommandParameter = Nothing
        Me.LabelX1.Font = Nothing
        Me.LabelX1.Name = "LabelX1"
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
        'frmRPTSumaryWagePerDay
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.txtDateStart)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = Nothing
        Me.Icon = Nothing
        Me.Name = "frmRPTSumaryWagePerDay"
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.txtDateStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtDateStart As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboDivision As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboSection As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboDepartment As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnReport As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cboEmpGroup As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboCompany As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
