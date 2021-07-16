<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTSummarizeVacationByYear
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTSummarizeVacationByYear))
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cboYear = New System.Windows.Forms.ComboBox
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.btnExit = New DevComponents.DotNetBar.ButtonX
        Me.btnReport = New DevComponents.DotNetBar.ButtonX
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rdContractor = New System.Windows.Forms.RadioButton
        Me.rdDay = New System.Windows.Forms.RadioButton
        Me.rdMonth = New System.Windows.Forms.RadioButton
        Me.rdAll = New System.Windows.Forms.RadioButton
        Me.cboCompany = New System.Windows.Forms.ComboBox
        Me.cboEmpGroup = New System.Windows.Forms.ComboBox
        Me.cboDivision = New System.Windows.Forms.ComboBox
        Me.cboPosition = New System.Windows.Forms.ComboBox
        Me.cboDepartment = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNameSearch = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCode1 = New System.Windows.Forms.TextBox
        Me.GroupPanel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.AccessibleDescription = Nothing
        Me.GroupPanel1.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupPanel1, "GroupPanel1")
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.cboYear)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
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
        'cboYear
        '
        Me.cboYear.AccessibleDescription = Nothing
        Me.cboYear.AccessibleName = Nothing
        resources.ApplyResources(Me.cboYear, "cboYear")
        Me.cboYear.BackgroundImage = Nothing
        Me.cboYear.Font = Nothing
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {resources.GetString("cboYear.Items"), resources.GetString("cboYear.Items1"), resources.GetString("cboYear.Items2"), resources.GetString("cboYear.Items3"), resources.GetString("cboYear.Items4"), resources.GetString("cboYear.Items5"), resources.GetString("cboYear.Items6"), resources.GetString("cboYear.Items7"), resources.GetString("cboYear.Items8"), resources.GetString("cboYear.Items9")})
        Me.cboYear.Name = "cboYear"
        '
        'LabelX1
        '
        Me.LabelX1.AccessibleDescription = Nothing
        Me.LabelX1.AccessibleName = Nothing
        resources.ApplyResources(Me.LabelX1, "LabelX1")
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
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
        'GroupBox5
        '
        Me.GroupBox5.AccessibleDescription = Nothing
        Me.GroupBox5.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.BackgroundImage = Nothing
        Me.GroupBox5.Controls.Add(Me.rdContractor)
        Me.GroupBox5.Controls.Add(Me.rdDay)
        Me.GroupBox5.Controls.Add(Me.rdMonth)
        Me.GroupBox5.Controls.Add(Me.rdAll)
        Me.GroupBox5.Font = Nothing
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        '
        'rdContractor
        '
        Me.rdContractor.AccessibleDescription = Nothing
        Me.rdContractor.AccessibleName = Nothing
        resources.ApplyResources(Me.rdContractor, "rdContractor")
        Me.rdContractor.BackgroundImage = Nothing
        Me.rdContractor.Font = Nothing
        Me.rdContractor.Name = "rdContractor"
        Me.rdContractor.UseVisualStyleBackColor = True
        '
        'rdDay
        '
        Me.rdDay.AccessibleDescription = Nothing
        Me.rdDay.AccessibleName = Nothing
        resources.ApplyResources(Me.rdDay, "rdDay")
        Me.rdDay.BackgroundImage = Nothing
        Me.rdDay.Font = Nothing
        Me.rdDay.Name = "rdDay"
        Me.rdDay.UseVisualStyleBackColor = True
        '
        'rdMonth
        '
        Me.rdMonth.AccessibleDescription = Nothing
        Me.rdMonth.AccessibleName = Nothing
        resources.ApplyResources(Me.rdMonth, "rdMonth")
        Me.rdMonth.BackgroundImage = Nothing
        Me.rdMonth.Font = Nothing
        Me.rdMonth.Name = "rdMonth"
        Me.rdMonth.UseVisualStyleBackColor = True
        '
        'rdAll
        '
        Me.rdAll.AccessibleDescription = Nothing
        Me.rdAll.AccessibleName = Nothing
        resources.ApplyResources(Me.rdAll, "rdAll")
        Me.rdAll.BackgroundImage = Nothing
        Me.rdAll.Checked = True
        Me.rdAll.Font = Nothing
        Me.rdAll.Name = "rdAll"
        Me.rdAll.TabStop = True
        Me.rdAll.UseVisualStyleBackColor = True
        '
        'cboCompany
        '
        Me.cboCompany.AccessibleDescription = Nothing
        Me.cboCompany.AccessibleName = Nothing
        resources.ApplyResources(Me.cboCompany, "cboCompany")
        Me.cboCompany.BackgroundImage = Nothing
        Me.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompany.Font = Nothing
        Me.cboCompany.FormattingEnabled = True
        Me.cboCompany.Name = "cboCompany"
        '
        'cboEmpGroup
        '
        Me.cboEmpGroup.AccessibleDescription = Nothing
        Me.cboEmpGroup.AccessibleName = Nothing
        resources.ApplyResources(Me.cboEmpGroup, "cboEmpGroup")
        Me.cboEmpGroup.BackgroundImage = Nothing
        Me.cboEmpGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpGroup.Font = Nothing
        Me.cboEmpGroup.FormattingEnabled = True
        Me.cboEmpGroup.Name = "cboEmpGroup"
        '
        'cboDivision
        '
        Me.cboDivision.AccessibleDescription = Nothing
        Me.cboDivision.AccessibleName = Nothing
        resources.ApplyResources(Me.cboDivision, "cboDivision")
        Me.cboDivision.BackgroundImage = Nothing
        Me.cboDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivision.Font = Nothing
        Me.cboDivision.FormattingEnabled = True
        Me.cboDivision.Name = "cboDivision"
        '
        'cboPosition
        '
        Me.cboPosition.AccessibleDescription = Nothing
        Me.cboPosition.AccessibleName = Nothing
        resources.ApplyResources(Me.cboPosition, "cboPosition")
        Me.cboPosition.BackgroundImage = Nothing
        Me.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPosition.Font = Nothing
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Name = "cboPosition"
        '
        'cboDepartment
        '
        Me.cboDepartment.AccessibleDescription = Nothing
        Me.cboDepartment.AccessibleName = Nothing
        resources.ApplyResources(Me.cboDepartment, "cboDepartment")
        Me.cboDepartment.BackgroundImage = Nothing
        Me.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartment.Font = Nothing
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Name = "cboDepartment"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Font = Nothing
        Me.Label1.Name = "Label1"
        '
        'Label6
        '
        Me.Label6.AccessibleDescription = Nothing
        Me.Label6.AccessibleName = Nothing
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Font = Nothing
        Me.Label6.Name = "Label6"
        '
        'Label7
        '
        Me.Label7.AccessibleDescription = Nothing
        Me.Label7.AccessibleName = Nothing
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Font = Nothing
        Me.Label7.Name = "Label7"
        '
        'Label8
        '
        Me.Label8.AccessibleDescription = Nothing
        Me.Label8.AccessibleName = Nothing
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Font = Nothing
        Me.Label8.Name = "Label8"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Font = Nothing
        Me.Label2.Name = "Label2"
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleDescription = Nothing
        Me.GroupBox2.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.BackgroundImage = Nothing
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtNameSearch)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtCode1)
        Me.GroupBox2.Font = Nothing
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Font = Nothing
        Me.Label3.Name = "Label3"
        '
        'txtNameSearch
        '
        Me.txtNameSearch.AccessibleDescription = Nothing
        Me.txtNameSearch.AccessibleName = Nothing
        resources.ApplyResources(Me.txtNameSearch, "txtNameSearch")
        Me.txtNameSearch.BackgroundImage = Nothing
        Me.txtNameSearch.Font = Nothing
        Me.txtNameSearch.Name = "txtNameSearch"
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = Nothing
        Me.Label4.AccessibleName = Nothing
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Font = Nothing
        Me.Label4.Name = "Label4"
        '
        'txtCode1
        '
        Me.txtCode1.AccessibleDescription = Nothing
        Me.txtCode1.AccessibleName = Nothing
        resources.ApplyResources(Me.txtCode1, "txtCode1")
        Me.txtCode1.BackgroundImage = Nothing
        Me.txtCode1.Font = Nothing
        Me.txtCode1.Name = "txtCode1"
        '
        'frmRPTSummarizeVacationByYear
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.cboCompany)
        Me.Controls.Add(Me.cboEmpGroup)
        Me.Controls.Add(Me.cboDivision)
        Me.Controls.Add(Me.cboPosition)
        Me.Controls.Add(Me.cboDepartment)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReport)
        Me.Font = Nothing
        Me.Icon = Nothing
        Me.Name = "frmRPTSummarizeVacationByYear"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnReport As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rdContractor As System.Windows.Forms.RadioButton
    Friend WithEvents rdDay As System.Windows.Forms.RadioButton
    Friend WithEvents rdMonth As System.Windows.Forms.RadioButton
    Friend WithEvents rdAll As System.Windows.Forms.RadioButton
    Friend WithEvents cboCompany As System.Windows.Forms.ComboBox
    Friend WithEvents cboEmpGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cboDivision As System.Windows.Forms.ComboBox
    Friend WithEvents cboPosition As System.Windows.Forms.ComboBox
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNameSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCode1 As System.Windows.Forms.TextBox
End Class
