<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainConfig
    Inherits frmBasicPage3

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainConfig))
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.optPayrollTotal2Digit = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.ChkTime = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.optPayrollTotalNoDigit = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.txtPicPath = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtVisaWornning = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        resources.ApplyResources(Me.GroupPanel1, "GroupPanel1")
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.optPayrollTotal2Digit)
        Me.GroupPanel1.Controls.Add(Me.ChkTime)
        Me.GroupPanel1.Controls.Add(Me.optPayrollTotalNoDigit)
        Me.GroupPanel1.Controls.Add(Me.txtPicPath)
        Me.GroupPanel1.Controls.Add(Me.txtVisaWornning)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX5)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
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
        'optPayrollTotal2Digit
        '
        resources.ApplyResources(Me.optPayrollTotal2Digit, "optPayrollTotal2Digit")
        Me.optPayrollTotal2Digit.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.optPayrollTotal2Digit.BackgroundStyle.Class = ""
        Me.optPayrollTotal2Digit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.optPayrollTotal2Digit.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.optPayrollTotal2Digit.Checked = True
        Me.optPayrollTotal2Digit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optPayrollTotal2Digit.CheckValue = "Y"
        Me.optPayrollTotal2Digit.Name = "optPayrollTotal2Digit"
        Me.optPayrollTotal2Digit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ChkTime
        '
        resources.ApplyResources(Me.ChkTime, "ChkTime")
        Me.ChkTime.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ChkTime.BackgroundStyle.Class = ""
        Me.ChkTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChkTime.Name = "ChkTime"
        Me.ChkTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ChkTime.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'optPayrollTotalNoDigit
        '
        resources.ApplyResources(Me.optPayrollTotalNoDigit, "optPayrollTotalNoDigit")
        Me.optPayrollTotalNoDigit.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.optPayrollTotalNoDigit.BackgroundStyle.Class = ""
        Me.optPayrollTotalNoDigit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.optPayrollTotalNoDigit.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.optPayrollTotalNoDigit.Name = "optPayrollTotalNoDigit"
        Me.optPayrollTotalNoDigit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'txtPicPath
        '
        resources.ApplyResources(Me.txtPicPath, "txtPicPath")
        '
        '
        '
        Me.txtPicPath.Border.Class = "TextBoxBorder"
        Me.txtPicPath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPicPath.ButtonCustom.DisplayPosition = CType(resources.GetObject("txtPicPath.ButtonCustom.DisplayPosition"), Integer)
        Me.txtPicPath.ButtonCustom.Image = CType(resources.GetObject("txtPicPath.ButtonCustom.Image"), System.Drawing.Image)
        Me.txtPicPath.ButtonCustom.Text = resources.GetString("txtPicPath.ButtonCustom.Text")
        Me.txtPicPath.ButtonCustom2.DisplayPosition = CType(resources.GetObject("txtPicPath.ButtonCustom2.DisplayPosition"), Integer)
        Me.txtPicPath.ButtonCustom2.Image = CType(resources.GetObject("txtPicPath.ButtonCustom2.Image"), System.Drawing.Image)
        Me.txtPicPath.ButtonCustom2.Text = resources.GetString("txtPicPath.ButtonCustom2.Text")
        Me.txtPicPath.Name = "txtPicPath"
        '
        'txtVisaWornning
        '
        resources.ApplyResources(Me.txtVisaWornning, "txtVisaWornning")
        '
        '
        '
        Me.txtVisaWornning.Border.Class = "TextBoxBorder"
        Me.txtVisaWornning.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtVisaWornning.ButtonCustom.DisplayPosition = CType(resources.GetObject("txtVisaWornning.ButtonCustom.DisplayPosition"), Integer)
        Me.txtVisaWornning.ButtonCustom.Image = CType(resources.GetObject("txtVisaWornning.ButtonCustom.Image"), System.Drawing.Image)
        Me.txtVisaWornning.ButtonCustom.Text = resources.GetString("txtVisaWornning.ButtonCustom.Text")
        Me.txtVisaWornning.ButtonCustom2.DisplayPosition = CType(resources.GetObject("txtVisaWornning.ButtonCustom2.DisplayPosition"), Integer)
        Me.txtVisaWornning.ButtonCustom2.Image = CType(resources.GetObject("txtVisaWornning.ButtonCustom2.Image"), System.Drawing.Image)
        Me.txtVisaWornning.ButtonCustom2.Text = resources.GetString("txtVisaWornning.ButtonCustom2.Text")
        Me.txtVisaWornning.Name = "txtVisaWornning"
        '
        'LabelX2
        '
        resources.ApplyResources(Me.LabelX2, "LabelX2")
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Name = "LabelX2"
        '
        'LabelX4
        '
        resources.ApplyResources(Me.LabelX4, "LabelX4")
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Indigo
        Me.LabelX4.Name = "LabelX4"
        '
        'LabelX5
        '
        resources.ApplyResources(Me.LabelX5, "LabelX5")
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Name = "LabelX5"
        '
        'LabelX3
        '
        resources.ApplyResources(Me.LabelX3, "LabelX3")
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Name = "LabelX3"
        '
        'LabelX1
        '
        resources.ApplyResources(Me.LabelX1, "LabelX1")
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Name = "LabelX1"
        '
        'frmMainConfig
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupPanel1)
        Me.Name = "frmMainConfig"
        Me.Controls.SetChildIndex(Me.GroupPanel1, 0)
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents optPayrollTotal2Digit As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents optPayrollTotalNoDigit As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents txtPicPath As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtVisaWornning As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ChkTime As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
