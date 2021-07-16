<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTEmpValAbsLateByDate
    ' Inherits System.Windows.Forms.Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTEmpValAbsLateByDate))
        Me.cboSection = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.cboDepartment = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.cboDivision = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtDateStart = New DevExpress.XtraEditors.DateEdit()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboDepartment1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboDivision1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnCurrentDate = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnReport = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtDateStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDepartment1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDivision1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboSection
        '
        Me.cboSection.DisplayMember = "Text"
        Me.cboSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cboSection, "cboSection")
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
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
        '
        'cboDepartment
        '
        Me.cboDepartment.DisplayMember = "Text"
        Me.cboDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cboDepartment, "cboDepartment")
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
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
        '
        'cboDivision
        '
        Me.cboDivision.DisplayMember = "Text"
        Me.cboDivision.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cboDivision, "cboDivision")
        Me.cboDivision.FormattingEnabled = True
        Me.cboDivision.Name = "cboDivision"
        Me.cboDivision.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
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
        '
        'txtDateStart
        '
        resources.ApplyResources(Me.txtDateStart, "txtDateStart")
        Me.txtDateStart.EnterMoveNextControl = True
        Me.txtDateStart.Name = "txtDateStart"
        Me.txtDateStart.Properties.Appearance.Options.UseFont = True
        Me.txtDateStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateStart.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateStart.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateStart.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtDateStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDateStart.Properties.Mask.EditMask = resources.GetString("txtDateStart.Properties.Mask.EditMask")
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX1, "LabelX1")
        Me.LabelX1.Name = "LabelX1"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'cboDepartment1
        '
        resources.ApplyResources(Me.cboDepartment1, "cboDepartment1")
        Me.cboDepartment1.Name = "cboDepartment1"
        Me.cboDepartment1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboDepartment1.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboDepartment1.Properties.DropDownRows = 15
        Me.cboDepartment1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'cboDivision1
        '
        resources.ApplyResources(Me.cboDivision1, "cboDivision1")
        Me.cboDivision1.Name = "cboDivision1"
        Me.cboDivision1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboDivision1.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboDivision1.Properties.DropDownRows = 15
        Me.cboDivision1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.cboDepartment1)
        Me.GroupControl1.Controls.Add(Me.cboDivision1)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label2)
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Name = "GroupControl1"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.btnCurrentDate)
        Me.GroupControl2.Controls.Add(Me.txtDateStart)
        Me.GroupControl2.Controls.Add(Me.LabelX1)
        resources.ApplyResources(Me.GroupControl2, "GroupControl2")
        Me.GroupControl2.Name = "GroupControl2"
        '
        'btnCurrentDate
        '
        resources.ApplyResources(Me.btnCurrentDate, "btnCurrentDate")
        Me.btnCurrentDate.Name = "btnCurrentDate"
        '
        'btnExit
        '
        Me.btnExit.Appearance.Font = CType(resources.GetObject("btnExit.Appearance.Font"), System.Drawing.Font)
        Me.btnExit.Appearance.Options.UseFont = True
        Me.btnExit.ImageOptions.Image = CType(resources.GetObject("btnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.Name = "btnExit"
        '
        'btnReport
        '
        Me.btnReport.Appearance.Font = CType(resources.GetObject("btnReport.Appearance.Font"), System.Drawing.Font)
        Me.btnReport.Appearance.Options.UseFont = True
        Me.btnReport.ImageOptions.Image = CType(resources.GetObject("btnReport.ImageOptions.Image"), System.Drawing.Image)
        Me.btnReport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnReport, "btnReport")
        Me.btnReport.Name = "btnReport"
        '
        'frmRPTEmpValAbsLateByDate
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frmRPTEmpValAbsLateByDate"
        CType(Me.txtDateStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDepartment1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDivision1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDateStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cboDepartment1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboDivision1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCurrentDate As DevExpress.XtraEditors.SimpleButton
    Private WithEvents cboSection As DevComponents.DotNetBar.Controls.ComboBoxEx
    Private WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Private WithEvents cboDepartment As DevComponents.DotNetBar.Controls.ComboBoxEx
    Private WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Private WithEvents cboDivision As DevComponents.DotNetBar.Controls.ComboBoxEx
    Private WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class
