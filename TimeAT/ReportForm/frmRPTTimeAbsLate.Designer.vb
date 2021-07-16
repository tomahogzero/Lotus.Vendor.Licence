<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTTimeAbsLate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTTimeAbsLate))
        Me.btnReport = New DevComponents.DotNetBar.ButtonX()
        Me.btnExit = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNameSearch = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtEmpId = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.cboBroker = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboEmpGroup = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboPosition = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboSection = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboDepartment = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboDivision = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboCompany = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rdContractor = New System.Windows.Forms.RadioButton()
        Me.rdDay = New System.Windows.Forms.RadioButton()
        Me.rdMonth = New System.Windows.Forms.RadioButton()
        Me.rdAll = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtDateStart = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.txtDateStop = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.txtDateStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateStop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'PanelEx2
        '
        resources.ApplyResources(Me.PanelEx2, "PanelEx2")
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.GroupBox1)
        Me.PanelEx2.Controls.Add(Me.ProgressBar1)
        Me.PanelEx2.Controls.Add(Me.btnExit)
        Me.PanelEx2.Controls.Add(Me.btnReport)
        Me.PanelEx2.Controls.Add(Me.cboBroker)
        Me.PanelEx2.Controls.Add(Me.cboEmpGroup)
        Me.PanelEx2.Controls.Add(Me.cboPosition)
        Me.PanelEx2.Controls.Add(Me.cboSection)
        Me.PanelEx2.Controls.Add(Me.cboDepartment)
        Me.PanelEx2.Controls.Add(Me.cboDivision)
        Me.PanelEx2.Controls.Add(Me.cboCompany)
        Me.PanelEx2.Controls.Add(Me.GroupBox5)
        Me.PanelEx2.Controls.Add(Me.Label4)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNameSearch)
        Me.GroupBox1.Controls.Add(Me.txtEmpId)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
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
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
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
        'cboPosition
        '
        Me.cboPosition.DisplayMember = "Text"
        Me.cboPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPosition.FormattingEnabled = True
        resources.ApplyResources(Me.cboPosition, "cboPosition")
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cboSection
        '
        Me.cboSection.DisplayMember = "Text"
        Me.cboSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSection.FormattingEnabled = True
        resources.ApplyResources(Me.cboSection, "cboSection")
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cboDepartment
        '
        Me.cboDepartment.DisplayMember = "Text"
        Me.cboDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDepartment.FormattingEnabled = True
        resources.ApplyResources(Me.cboDepartment, "cboDepartment")
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cboDivision
        '
        Me.cboDivision.DisplayMember = "Text"
        Me.cboDivision.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboDivision.FormattingEnabled = True
        resources.ApplyResources(Me.cboDivision, "cboDivision")
        Me.cboDivision.Name = "cboDivision"
        Me.cboDivision.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
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
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.txtDateStart)
        Me.GroupPanel2.Controls.Add(Me.txtDateStop)
        Me.GroupPanel2.Controls.Add(Me.LabelX6)
        Me.GroupPanel2.Controls.Add(Me.LabelX2)
        resources.ApplyResources(Me.GroupPanel2, "GroupPanel2")
        Me.GroupPanel2.Name = "GroupPanel2"
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuUnusedSide2
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
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Center
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
        'frmRPTTimeAbsLate
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.PanelEx2)
        Me.Name = "frmRPTTimeAbsLate"
        Me.PanelEx2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.txtDateStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateStop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReport As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ProgressBar1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents cboBroker As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboEmpGroup As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboPosition As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboSection As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboDepartment As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboDivision As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboCompany As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rdContractor As System.Windows.Forms.RadioButton
    Friend WithEvents rdDay As System.Windows.Forms.RadioButton
    Friend WithEvents rdMonth As System.Windows.Forms.RadioButton
    Friend WithEvents rdAll As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtDateStart As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents txtDateStop As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNameSearch As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtEmpId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
