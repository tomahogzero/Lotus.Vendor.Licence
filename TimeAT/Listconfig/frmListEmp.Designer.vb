<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListEmp
    'Inherits System.Windows.Forms.Form
    '  Inherits frmBasicPage2

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListEmp))
        Me.lstShow = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.colNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colUnitId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colUnit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cboPosId = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btnBrowsPos = New DevComponents.DotNetBar.ButtonX()
        Me.GroupType = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cboSecId = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboDepId = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboDivId = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.btnBrowsSec = New DevComponents.DotNetBar.ButtonX()
        Me.ChkGrouptype = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.btnBrowsDep = New DevComponents.DotNetBar.ButtonX()
        Me.ChkLname = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.btnBrowsDiv = New DevComponents.DotNetBar.ButtonX()
        Me.ChkName = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.txtSecId = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.txtPosId = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtDepId = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ChkCode = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.txtDivId = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtLname = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GcUser = New DevExpress.XtraGrid.GridControl()
        Me.GvUser = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode_lar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReduc_lar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotdeduc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colremark_lar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cboTransport_detail = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboUnitName = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupType.SuspendLayout()
        CType(Me.GcUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstShow
        '
        resources.ApplyResources(Me.lstShow, "lstShow")
        '
        '
        '
        Me.lstShow.Border.Class = "ListViewBorder"
        Me.lstShow.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lstShow.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNo, Me.colUnitId, Me.colUnit, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstShow.FullRowSelect = True
        Me.lstShow.GridLines = True
        Me.lstShow.MultiSelect = False
        Me.lstShow.Name = "lstShow"
        Me.lstShow.UseCompatibleStateImageBehavior = False
        Me.lstShow.View = System.Windows.Forms.View.Details
        '
        'colNo
        '
        resources.ApplyResources(Me.colNo, "colNo")
        '
        'colUnitId
        '
        resources.ApplyResources(Me.colUnitId, "colUnitId")
        '
        'colUnit
        '
        resources.ApplyResources(Me.colUnit, "colUnit")
        '
        'ColumnHeader1
        '
        resources.ApplyResources(Me.ColumnHeader1, "ColumnHeader1")
        '
        'ColumnHeader2
        '
        resources.ApplyResources(Me.ColumnHeader2, "ColumnHeader2")
        '
        'ColumnHeader3
        '
        resources.ApplyResources(Me.ColumnHeader3, "ColumnHeader3")
        '
        'ColumnHeader4
        '
        resources.ApplyResources(Me.ColumnHeader4, "ColumnHeader4")
        '
        'GroupPanel1
        '
        resources.ApplyResources(Me.GroupPanel1, "GroupPanel1")
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.cboPosId)
        Me.GroupPanel1.Controls.Add(Me.btnBrowsPos)
        Me.GroupPanel1.Controls.Add(Me.GroupType)
        Me.GroupPanel1.Controls.Add(Me.btnBrowsSec)
        Me.GroupPanel1.Controls.Add(Me.ChkGrouptype)
        Me.GroupPanel1.Controls.Add(Me.btnBrowsDep)
        Me.GroupPanel1.Controls.Add(Me.ChkLname)
        Me.GroupPanel1.Controls.Add(Me.btnBrowsDiv)
        Me.GroupPanel1.Controls.Add(Me.ChkName)
        Me.GroupPanel1.Controls.Add(Me.txtSecId)
        Me.GroupPanel1.Controls.Add(Me.LabelX10)
        Me.GroupPanel1.Controls.Add(Me.txtPosId)
        Me.GroupPanel1.Controls.Add(Me.txtDepId)
        Me.GroupPanel1.Controls.Add(Me.ChkCode)
        Me.GroupPanel1.Controls.Add(Me.txtDivId)
        Me.GroupPanel1.Controls.Add(Me.txtLname)
        Me.GroupPanel1.Controls.Add(Me.txtName)
        Me.GroupPanel1.Controls.Add(Me.txtCode)
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
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
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
        'cboPosId
        '
        resources.ApplyResources(Me.cboPosId, "cboPosId")
        Me.cboPosId.DisplayMember = "Text"
        Me.cboPosId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPosId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPosId.FormattingEnabled = True
        Me.cboPosId.Name = "cboPosId"
        Me.cboPosId.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'btnBrowsPos
        '
        resources.ApplyResources(Me.btnBrowsPos, "btnBrowsPos")
        Me.btnBrowsPos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBrowsPos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBrowsPos.Name = "btnBrowsPos"
        Me.btnBrowsPos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'GroupType
        '
        resources.ApplyResources(Me.GroupType, "GroupType")
        Me.GroupType.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupType.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupType.Controls.Add(Me.cboSecId)
        Me.GroupType.Controls.Add(Me.cboDepId)
        Me.GroupType.Controls.Add(Me.cboDivId)
        Me.GroupType.Controls.Add(Me.LabelX13)
        Me.GroupType.Controls.Add(Me.LabelX12)
        Me.GroupType.Controls.Add(Me.LabelX11)
        Me.GroupType.Name = "GroupType"
        '
        '
        '
        Me.GroupType.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupType.Style.BackColorGradientAngle = 90
        Me.GroupType.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupType.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupType.Style.BorderBottomWidth = 1
        Me.GroupType.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupType.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupType.Style.BorderLeftWidth = 1
        Me.GroupType.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupType.Style.BorderRightWidth = 1
        Me.GroupType.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupType.Style.BorderTopWidth = 1
        Me.GroupType.Style.Class = ""
        Me.GroupType.Style.CornerDiameter = 4
        Me.GroupType.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupType.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupType.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupType.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupType.StyleMouseDown.Class = ""
        Me.GroupType.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupType.StyleMouseOver.Class = ""
        Me.GroupType.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'cboSecId
        '
        resources.ApplyResources(Me.cboSecId, "cboSecId")
        Me.cboSecId.DisplayMember = "Text"
        Me.cboSecId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSecId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSecId.FormattingEnabled = True
        Me.cboSecId.Name = "cboSecId"
        Me.cboSecId.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cboDepId
        '
        resources.ApplyResources(Me.cboDepId, "cboDepId")
        Me.cboDepId.DisplayMember = "Text"
        Me.cboDepId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDepId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepId.FormattingEnabled = True
        Me.cboDepId.Name = "cboDepId"
        Me.cboDepId.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cboDivId
        '
        resources.ApplyResources(Me.cboDivId, "cboDivId")
        Me.cboDivId.DisplayMember = "Text"
        Me.cboDivId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDivId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivId.FormattingEnabled = True
        Me.cboDivId.Name = "cboDivId"
        Me.cboDivId.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'LabelX13
        '
        resources.ApplyResources(Me.LabelX13, "LabelX13")
        Me.LabelX13.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX13.BackgroundStyle.Class = ""
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX12
        '
        resources.ApplyResources(Me.LabelX12, "LabelX12")
        Me.LabelX12.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX12.BackgroundStyle.Class = ""
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX11
        '
        resources.ApplyResources(Me.LabelX11, "LabelX11")
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX11.BackgroundStyle.Class = ""
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'btnBrowsSec
        '
        resources.ApplyResources(Me.btnBrowsSec, "btnBrowsSec")
        Me.btnBrowsSec.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBrowsSec.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBrowsSec.Name = "btnBrowsSec"
        Me.btnBrowsSec.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ChkGrouptype
        '
        resources.ApplyResources(Me.ChkGrouptype, "ChkGrouptype")
        Me.ChkGrouptype.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ChkGrouptype.BackgroundStyle.Class = ""
        Me.ChkGrouptype.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChkGrouptype.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.ChkGrouptype.Checked = True
        Me.ChkGrouptype.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkGrouptype.CheckValue = "Y"
        Me.ChkGrouptype.Name = "ChkGrouptype"
        Me.ChkGrouptype.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'btnBrowsDep
        '
        resources.ApplyResources(Me.btnBrowsDep, "btnBrowsDep")
        Me.btnBrowsDep.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBrowsDep.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBrowsDep.Name = "btnBrowsDep"
        Me.btnBrowsDep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ChkLname
        '
        resources.ApplyResources(Me.ChkLname, "ChkLname")
        Me.ChkLname.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ChkLname.BackgroundStyle.Class = ""
        Me.ChkLname.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChkLname.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.ChkLname.Name = "ChkLname"
        Me.ChkLname.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'btnBrowsDiv
        '
        resources.ApplyResources(Me.btnBrowsDiv, "btnBrowsDiv")
        Me.btnBrowsDiv.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBrowsDiv.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBrowsDiv.Name = "btnBrowsDiv"
        Me.btnBrowsDiv.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ChkName
        '
        resources.ApplyResources(Me.ChkName, "ChkName")
        Me.ChkName.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ChkName.BackgroundStyle.Class = ""
        Me.ChkName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChkName.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.ChkName.Name = "ChkName"
        Me.ChkName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'txtSecId
        '
        resources.ApplyResources(Me.txtSecId, "txtSecId")
        '
        '
        '
        Me.txtSecId.Border.Class = "TextBoxBorder"
        Me.txtSecId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSecId.ButtonCustom.DisplayPosition = CType(resources.GetObject("txtSecId.ButtonCustom.DisplayPosition"), Integer)
        Me.txtSecId.ButtonCustom.Image = CType(resources.GetObject("txtSecId.ButtonCustom.Image"), System.Drawing.Image)
        Me.txtSecId.ButtonCustom.Text = resources.GetString("txtSecId.ButtonCustom.Text")
        Me.txtSecId.ButtonCustom2.DisplayPosition = CType(resources.GetObject("txtSecId.ButtonCustom2.DisplayPosition"), Integer)
        Me.txtSecId.ButtonCustom2.Image = CType(resources.GetObject("txtSecId.ButtonCustom2.Image"), System.Drawing.Image)
        Me.txtSecId.ButtonCustom2.Text = resources.GetString("txtSecId.ButtonCustom2.Text")
        Me.txtSecId.Name = "txtSecId"
        Me.txtSecId.ReadOnly = True
        '
        'LabelX10
        '
        resources.ApplyResources(Me.LabelX10, "LabelX10")
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.Class = ""
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtPosId
        '
        resources.ApplyResources(Me.txtPosId, "txtPosId")
        '
        '
        '
        Me.txtPosId.Border.Class = "TextBoxBorder"
        Me.txtPosId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPosId.ButtonCustom.DisplayPosition = CType(resources.GetObject("txtPosId.ButtonCustom.DisplayPosition"), Integer)
        Me.txtPosId.ButtonCustom.Image = CType(resources.GetObject("txtPosId.ButtonCustom.Image"), System.Drawing.Image)
        Me.txtPosId.ButtonCustom.Text = resources.GetString("txtPosId.ButtonCustom.Text")
        Me.txtPosId.ButtonCustom2.DisplayPosition = CType(resources.GetObject("txtPosId.ButtonCustom2.DisplayPosition"), Integer)
        Me.txtPosId.ButtonCustom2.Image = CType(resources.GetObject("txtPosId.ButtonCustom2.Image"), System.Drawing.Image)
        Me.txtPosId.ButtonCustom2.Text = resources.GetString("txtPosId.ButtonCustom2.Text")
        Me.txtPosId.Name = "txtPosId"
        Me.txtPosId.ReadOnly = True
        '
        'txtDepId
        '
        resources.ApplyResources(Me.txtDepId, "txtDepId")
        '
        '
        '
        Me.txtDepId.Border.Class = "TextBoxBorder"
        Me.txtDepId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDepId.ButtonCustom.DisplayPosition = CType(resources.GetObject("txtDepId.ButtonCustom.DisplayPosition"), Integer)
        Me.txtDepId.ButtonCustom.Image = CType(resources.GetObject("txtDepId.ButtonCustom.Image"), System.Drawing.Image)
        Me.txtDepId.ButtonCustom.Text = resources.GetString("txtDepId.ButtonCustom.Text")
        Me.txtDepId.ButtonCustom2.DisplayPosition = CType(resources.GetObject("txtDepId.ButtonCustom2.DisplayPosition"), Integer)
        Me.txtDepId.ButtonCustom2.Image = CType(resources.GetObject("txtDepId.ButtonCustom2.Image"), System.Drawing.Image)
        Me.txtDepId.ButtonCustom2.Text = resources.GetString("txtDepId.ButtonCustom2.Text")
        Me.txtDepId.Name = "txtDepId"
        Me.txtDepId.ReadOnly = True
        '
        'ChkCode
        '
        resources.ApplyResources(Me.ChkCode, "ChkCode")
        Me.ChkCode.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ChkCode.BackgroundStyle.Class = ""
        Me.ChkCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChkCode.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.ChkCode.Name = "ChkCode"
        Me.ChkCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'txtDivId
        '
        resources.ApplyResources(Me.txtDivId, "txtDivId")
        '
        '
        '
        Me.txtDivId.Border.Class = "TextBoxBorder"
        Me.txtDivId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDivId.ButtonCustom.DisplayPosition = CType(resources.GetObject("txtDivId.ButtonCustom.DisplayPosition"), Integer)
        Me.txtDivId.ButtonCustom.Image = CType(resources.GetObject("txtDivId.ButtonCustom.Image"), System.Drawing.Image)
        Me.txtDivId.ButtonCustom.Text = resources.GetString("txtDivId.ButtonCustom.Text")
        Me.txtDivId.ButtonCustom2.DisplayPosition = CType(resources.GetObject("txtDivId.ButtonCustom2.DisplayPosition"), Integer)
        Me.txtDivId.ButtonCustom2.Image = CType(resources.GetObject("txtDivId.ButtonCustom2.Image"), System.Drawing.Image)
        Me.txtDivId.ButtonCustom2.Text = resources.GetString("txtDivId.ButtonCustom2.Text")
        Me.txtDivId.Name = "txtDivId"
        Me.txtDivId.ReadOnly = True
        '
        'txtLname
        '
        resources.ApplyResources(Me.txtLname, "txtLname")
        '
        '
        '
        Me.txtLname.Border.Class = "TextBoxBorder"
        Me.txtLname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtLname.ButtonCustom.DisplayPosition = CType(resources.GetObject("txtLname.ButtonCustom.DisplayPosition"), Integer)
        Me.txtLname.ButtonCustom.Image = CType(resources.GetObject("txtLname.ButtonCustom.Image"), System.Drawing.Image)
        Me.txtLname.ButtonCustom.Text = resources.GetString("txtLname.ButtonCustom.Text")
        Me.txtLname.ButtonCustom2.DisplayPosition = CType(resources.GetObject("txtLname.ButtonCustom2.DisplayPosition"), Integer)
        Me.txtLname.ButtonCustom2.Image = CType(resources.GetObject("txtLname.ButtonCustom2.Image"), System.Drawing.Image)
        Me.txtLname.ButtonCustom2.Text = resources.GetString("txtLname.ButtonCustom2.Text")
        Me.txtLname.Name = "txtLname"
        '
        'txtName
        '
        resources.ApplyResources(Me.txtName, "txtName")
        '
        '
        '
        Me.txtName.Border.Class = "TextBoxBorder"
        Me.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtName.ButtonCustom.DisplayPosition = CType(resources.GetObject("txtName.ButtonCustom.DisplayPosition"), Integer)
        Me.txtName.ButtonCustom.Image = CType(resources.GetObject("txtName.ButtonCustom.Image"), System.Drawing.Image)
        Me.txtName.ButtonCustom.Text = resources.GetString("txtName.ButtonCustom.Text")
        Me.txtName.ButtonCustom2.DisplayPosition = CType(resources.GetObject("txtName.ButtonCustom2.DisplayPosition"), Integer)
        Me.txtName.ButtonCustom2.Image = CType(resources.GetObject("txtName.ButtonCustom2.Image"), System.Drawing.Image)
        Me.txtName.ButtonCustom2.Text = resources.GetString("txtName.ButtonCustom2.Text")
        Me.txtName.Name = "txtName"
        '
        'txtCode
        '
        resources.ApplyResources(Me.txtCode, "txtCode")
        '
        '
        '
        Me.txtCode.Border.Class = "TextBoxBorder"
        Me.txtCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCode.ButtonCustom.DisplayPosition = CType(resources.GetObject("txtCode.ButtonCustom.DisplayPosition"), Integer)
        Me.txtCode.ButtonCustom.Image = CType(resources.GetObject("txtCode.ButtonCustom.Image"), System.Drawing.Image)
        Me.txtCode.ButtonCustom.Text = resources.GetString("txtCode.ButtonCustom.Text")
        Me.txtCode.ButtonCustom2.DisplayPosition = CType(resources.GetObject("txtCode.ButtonCustom2.DisplayPosition"), Integer)
        Me.txtCode.ButtonCustom2.Image = CType(resources.GetObject("txtCode.ButtonCustom2.Image"), System.Drawing.Image)
        Me.txtCode.ButtonCustom2.Text = resources.GetString("txtCode.ButtonCustom2.Text")
        Me.txtCode.Name = "txtCode"
        '
        'GcUser
        '
        resources.ApplyResources(Me.GcUser, "GcUser")
        Me.GcUser.EmbeddedNavigator.AccessibleDescription = resources.GetString("GcUser.EmbeddedNavigator.AccessibleDescription")
        Me.GcUser.EmbeddedNavigator.AccessibleName = resources.GetString("GcUser.EmbeddedNavigator.AccessibleName")
        Me.GcUser.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GcUser.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GcUser.EmbeddedNavigator.Anchor = CType(resources.GetObject("GcUser.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GcUser.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GcUser.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GcUser.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GcUser.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GcUser.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GcUser.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GcUser.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GcUser.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GcUser.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GcUser.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GcUser.EmbeddedNavigator.ToolTip = resources.GetString("GcUser.EmbeddedNavigator.ToolTip")
        Me.GcUser.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GcUser.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GcUser.EmbeddedNavigator.ToolTipTitle = resources.GetString("GcUser.EmbeddedNavigator.ToolTipTitle")
        Me.GcUser.MainView = Me.GvUser
        Me.GcUser.Name = "GcUser"
        Me.GcUser.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.BtnDel, Me.cboTransport_detail, Me.cboUnitName})
        Me.GcUser.TabStop = False
        Me.GcUser.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvUser})
        '
        'GvUser
        '
        Me.GvUser.Appearance.HeaderPanel.Font = CType(resources.GetObject("GvUser.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GvUser.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GvUser.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GvUser.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GvUser.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GvUser.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GvUser.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GvUser.Appearance.HeaderPanel.Image = CType(resources.GetObject("GvUser.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GvUser.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvUser.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GvUser.Appearance.Row.FontSizeDelta"), Integer)
        Me.GvUser.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GvUser.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GvUser.Appearance.Row.GradientMode = CType(resources.GetObject("GvUser.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GvUser.Appearance.Row.Image = CType(resources.GetObject("GvUser.Appearance.Row.Image"), System.Drawing.Image)
        Me.GvUser.Appearance.Row.Options.UseFont = True
        resources.ApplyResources(Me.GvUser, "GvUser")
        Me.GvUser.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colrow, Me.colcode_lar, Me.colReduc_lar, Me.colNotdeduc, Me.GridColumn1, Me.colremark_lar, Me.GridColumn2})
        Me.GvUser.GridControl = Me.GcUser
        Me.GvUser.Name = "GvUser"
        Me.GvUser.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.GvUser.OptionsView.ColumnAutoWidth = False
        Me.GvUser.OptionsView.ShowAutoFilterRow = True
        Me.GvUser.OptionsView.ShowGroupPanel = False
        '
        'colrow
        '
        Me.colrow.AppearanceCell.FontSizeDelta = CType(resources.GetObject("colrow.AppearanceCell.FontSizeDelta"), Integer)
        Me.colrow.AppearanceCell.FontStyleDelta = CType(resources.GetObject("colrow.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.colrow.AppearanceCell.GradientMode = CType(resources.GetObject("colrow.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.colrow.AppearanceCell.Image = CType(resources.GetObject("colrow.AppearanceCell.Image"), System.Drawing.Image)
        Me.colrow.AppearanceCell.Options.UseTextOptions = True
        Me.colrow.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colrow.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("colrow.AppearanceHeader.FontSizeDelta"), Integer)
        Me.colrow.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("colrow.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.colrow.AppearanceHeader.GradientMode = CType(resources.GetObject("colrow.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.colrow.AppearanceHeader.Image = CType(resources.GetObject("colrow.AppearanceHeader.Image"), System.Drawing.Image)
        Me.colrow.AppearanceHeader.Options.UseTextOptions = True
        Me.colrow.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colrow, "colrow")
        Me.colrow.FieldName = "row"
        Me.colrow.Name = "colrow"
        Me.colrow.OptionsColumn.AllowEdit = False
        Me.colrow.OptionsColumn.TabStop = False
        Me.colrow.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem()})
        '
        'colcode_lar
        '
        Me.colcode_lar.AppearanceCell.FontSizeDelta = CType(resources.GetObject("colcode_lar.AppearanceCell.FontSizeDelta"), Integer)
        Me.colcode_lar.AppearanceCell.FontStyleDelta = CType(resources.GetObject("colcode_lar.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.colcode_lar.AppearanceCell.GradientMode = CType(resources.GetObject("colcode_lar.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.colcode_lar.AppearanceCell.Image = CType(resources.GetObject("colcode_lar.AppearanceCell.Image"), System.Drawing.Image)
        Me.colcode_lar.AppearanceCell.Options.UseTextOptions = True
        Me.colcode_lar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colcode_lar.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("colcode_lar.AppearanceHeader.FontSizeDelta"), Integer)
        Me.colcode_lar.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("colcode_lar.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.colcode_lar.AppearanceHeader.GradientMode = CType(resources.GetObject("colcode_lar.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.colcode_lar.AppearanceHeader.Image = CType(resources.GetObject("colcode_lar.AppearanceHeader.Image"), System.Drawing.Image)
        Me.colcode_lar.AppearanceHeader.Options.UseTextOptions = True
        Me.colcode_lar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colcode_lar, "colcode_lar")
        Me.colcode_lar.FieldName = "Code"
        Me.colcode_lar.Name = "colcode_lar"
        Me.colcode_lar.OptionsColumn.AllowEdit = False
        Me.colcode_lar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem()})
        '
        'colReduc_lar
        '
        resources.ApplyResources(Me.colReduc_lar, "colReduc_lar")
        Me.colReduc_lar.FieldName = "Fname"
        Me.colReduc_lar.Name = "colReduc_lar"
        Me.colReduc_lar.OptionsColumn.AllowEdit = False
        Me.colReduc_lar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem()})
        '
        'colNotdeduc
        '
        resources.ApplyResources(Me.colNotdeduc, "colNotdeduc")
        Me.colNotdeduc.FieldName = "Lname"
        Me.colNotdeduc.Name = "colNotdeduc"
        Me.colNotdeduc.OptionsColumn.AllowEdit = False
        Me.colNotdeduc.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem()})
        '
        'GridColumn1
        '
        resources.ApplyResources(Me.GridColumn1, "GridColumn1")
        Me.GridColumn1.FieldName = "Division"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem()})
        '
        'colremark_lar
        '
        resources.ApplyResources(Me.colremark_lar, "colremark_lar")
        Me.colremark_lar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colremark_lar.FieldName = "Department"
        Me.colremark_lar.Name = "colremark_lar"
        Me.colremark_lar.OptionsColumn.AllowEdit = False
        Me.colremark_lar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem()})
        '
        'GridColumn2
        '
        resources.ApplyResources(Me.GridColumn2, "GridColumn2")
        Me.GridColumn2.FieldName = "Position"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem()})
        '
        'BtnDel
        '
        resources.ApplyResources(Me.BtnDel, "BtnDel")
        Me.BtnDel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("BtnDel.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.BtnDel.Mask.AutoComplete = CType(resources.GetObject("BtnDel.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.BtnDel.Mask.BeepOnError = CType(resources.GetObject("BtnDel.Mask.BeepOnError"), Boolean)
        Me.BtnDel.Mask.EditMask = resources.GetString("BtnDel.Mask.EditMask")
        Me.BtnDel.Mask.IgnoreMaskBlank = CType(resources.GetObject("BtnDel.Mask.IgnoreMaskBlank"), Boolean)
        Me.BtnDel.Mask.MaskType = CType(resources.GetObject("BtnDel.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.BtnDel.Mask.PlaceHolder = CType(resources.GetObject("BtnDel.Mask.PlaceHolder"), Char)
        Me.BtnDel.Mask.SaveLiteral = CType(resources.GetObject("BtnDel.Mask.SaveLiteral"), Boolean)
        Me.BtnDel.Mask.ShowPlaceHolders = CType(resources.GetObject("BtnDel.Mask.ShowPlaceHolders"), Boolean)
        Me.BtnDel.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("BtnDel.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'cboTransport_detail
        '
        resources.ApplyResources(Me.cboTransport_detail, "cboTransport_detail")
        Me.cboTransport_detail.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboTransport_detail.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboTransport_detail.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("cboTransport_detail.Columns"), CType(resources.GetObject("cboTransport_detail.Columns1"), Integer), resources.GetString("cboTransport_detail.Columns2"))})
        Me.cboTransport_detail.DisplayMember = "TransName"
        Me.cboTransport_detail.Name = "cboTransport_detail"
        Me.cboTransport_detail.ValueMember = "transcomId"
        '
        'cboUnitName
        '
        resources.ApplyResources(Me.cboUnitName, "cboUnitName")
        Me.cboUnitName.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboUnitName.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboUnitName.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("cboUnitName.Columns"), resources.GetString("cboUnitName.Columns1"))})
        Me.cboUnitName.DisplayMember = "unit"
        Me.cboUnitName.Name = "cboUnitName"
        Me.cboUnitName.ValueMember = "unitid"
        '
        'btnExit
        '
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.ImageOptions.Image = CType(resources.GetObject("btnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnExit.Name = "btnExit"
        '
        'frmListEmp
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GcUser)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.lstShow)
        Me.Name = "frmListEmp"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupType.ResumeLayout(False)
        CType(Me.GcUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    'Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonX
    'Friend WithEvents btnClear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lstShow As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents colNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colUnitId As System.Windows.Forms.ColumnHeader
    Friend WithEvents colUnit As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cboPosId As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btnBrowsPos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupType As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cboSecId As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboDepId As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboDivId As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnBrowsSec As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ChkGrouptype As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents btnBrowsDep As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ChkLname As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents btnBrowsDiv As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ChkName As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents txtSecId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPosId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtDepId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ChkCode As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents txtDivId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtLname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GcUser As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvUser As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colrow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode_lar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReduc_lar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotdeduc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colremark_lar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cboTransport_detail As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboUnitName As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
End Class
