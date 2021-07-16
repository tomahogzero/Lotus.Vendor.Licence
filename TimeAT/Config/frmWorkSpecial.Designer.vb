<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkSpecial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorkSpecial))
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.lstHol = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.lstWork = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.ColNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColRemark = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDate_Work = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemark_Work = New DevExpress.XtraEditors.TextEdit()
        Me.GcWork = New DevExpress.XtraGrid.GridControl()
        Me.GvWork = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode_lar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription_lar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cboTransport_detail = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboUnitName = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btnAdd_W = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear_W = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDel_W = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDate_Hol = New DevExpress.XtraEditors.DateEdit()
        Me.txtRemart_Hol = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.GcHol = New DevExpress.XtraGrid.GridControl()
        Me.GvHol = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btnAdd_H = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear_H = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDel_H = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtDate_Work.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate_Work.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemark_Work.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtDate_Hol.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate_Hol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemart_Hol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcHol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvHol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.lstHol)
        Me.GroupPanel2.Controls.Add(Me.LabelX4)
        Me.GroupPanel2.Controls.Add(Me.LabelX2)
        resources.ApplyResources(Me.GroupPanel2, "GroupPanel2")
        Me.GroupPanel2.Name = "GroupPanel2"
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
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
        Me.GroupPanel2.TitleImage = Global.TimeAttendance.My.Resources.Resources.Dapino_Summer_Holiday_Sun
        '
        'lstHol
        '
        Me.lstHol.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.lstHol.Border.Class = "ListViewBorder"
        Me.lstHol.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lstHol.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        resources.ApplyResources(Me.lstHol, "lstHol")
        Me.lstHol.FullRowSelect = True
        Me.lstHol.GridLines = True
        Me.lstHol.Name = "lstHol"
        Me.lstHol.UseCompatibleStateImageBehavior = False
        Me.lstHol.View = System.Windows.Forms.View.Details
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
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
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
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.lstWork)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        resources.ApplyResources(Me.GroupPanel1, "GroupPanel1")
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
        Me.GroupPanel1.TitleImage = Global.TimeAttendance.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Categories_applications_office
        '
        'lstWork
        '
        Me.lstWork.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.lstWork.Border.Class = "ListViewBorder"
        Me.lstWork.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lstWork.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColNumber, Me.ColDate, Me.ColRemark})
        resources.ApplyResources(Me.lstWork, "lstWork")
        Me.lstWork.FullRowSelect = True
        Me.lstWork.GridLines = True
        Me.lstWork.Name = "lstWork"
        Me.lstWork.UseCompatibleStateImageBehavior = False
        Me.lstWork.View = System.Windows.Forms.View.Details
        '
        'ColNumber
        '
        resources.ApplyResources(Me.ColNumber, "ColNumber")
        '
        'ColDate
        '
        resources.ApplyResources(Me.ColDate, "ColDate")
        '
        'ColRemark
        '
        resources.ApplyResources(Me.ColRemark, "ColRemark")
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
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
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
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'GroupControl1
        '
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.AppearanceCaption.Font = CType(resources.GetObject("GroupControl1.AppearanceCaption.Font"), System.Drawing.Font)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.PanelControl1)
        Me.GroupControl1.Controls.Add(Me.GcWork)
        Me.GroupControl1.Controls.Add(Me.btnAdd_W)
        Me.GroupControl1.Controls.Add(Me.btnClear_W)
        Me.GroupControl1.Controls.Add(Me.btnDel_W)
        Me.GroupControl1.Name = "GroupControl1"
        '
        'PanelControl1
        '
        resources.ApplyResources(Me.PanelControl1, "PanelControl1")
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txtDate_Work)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtRemark_Work)
        Me.PanelControl1.Name = "PanelControl1"
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        '
        'txtDate_Work
        '
        resources.ApplyResources(Me.txtDate_Work, "txtDate_Work")
        Me.txtDate_Work.EnterMoveNextControl = True
        Me.txtDate_Work.Name = "txtDate_Work"
        Me.txtDate_Work.Properties.Appearance.Options.UseFont = True
        Me.txtDate_Work.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDate_Work.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDate_Work.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDate_Work.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDate_Work.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtDate_Work.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDate_Work.Properties.Mask.EditMask = resources.GetString("txtDate_Work.Properties.Mask.EditMask")
        Me.txtDate_Work.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDate_Work.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        '
        'txtRemark_Work
        '
        Me.txtRemark_Work.EnterMoveNextControl = True
        resources.ApplyResources(Me.txtRemark_Work, "txtRemark_Work")
        Me.txtRemark_Work.Name = "txtRemark_Work"
        '
        'GcWork
        '
        resources.ApplyResources(Me.GcWork, "GcWork")
        Me.GcWork.MainView = Me.GvWork
        Me.GcWork.Name = "GcWork"
        Me.GcWork.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.BtnDel, Me.cboTransport_detail, Me.cboUnitName})
        Me.GcWork.TabStop = False
        Me.GcWork.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvWork})
        '
        'GvWork
        '
        Me.GvWork.Appearance.HeaderPanel.Font = CType(resources.GetObject("GvWork.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GvWork.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvWork.Appearance.Row.Options.UseFont = True
        Me.GvWork.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colrow, Me.colcode_lar, Me.colDescription_lar})
        Me.GvWork.GridControl = Me.GcWork
        Me.GvWork.Name = "GvWork"
        Me.GvWork.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.GvWork.OptionsView.ColumnAutoWidth = False
        Me.GvWork.OptionsView.ShowGroupPanel = False
        '
        'colrow
        '
        Me.colrow.AppearanceCell.Options.UseTextOptions = True
        Me.colrow.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colrow.AppearanceHeader.Options.UseTextOptions = True
        Me.colrow.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colrow, "colrow")
        Me.colrow.FieldName = "row"
        Me.colrow.Name = "colrow"
        Me.colrow.OptionsColumn.AllowEdit = False
        Me.colrow.OptionsColumn.TabStop = False
        '
        'colcode_lar
        '
        Me.colcode_lar.AppearanceCell.Options.UseTextOptions = True
        Me.colcode_lar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colcode_lar.AppearanceHeader.Options.UseTextOptions = True
        Me.colcode_lar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colcode_lar, "colcode_lar")
        Me.colcode_lar.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colcode_lar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colcode_lar.FieldName = "DateTimeWork"
        Me.colcode_lar.Name = "colcode_lar"
        Me.colcode_lar.OptionsColumn.AllowEdit = False
        '
        'colDescription_lar
        '
        resources.ApplyResources(Me.colDescription_lar, "colDescription_lar")
        Me.colDescription_lar.FieldName = "Remark"
        Me.colDescription_lar.Name = "colDescription_lar"
        Me.colDescription_lar.OptionsColumn.AllowEdit = False
        '
        'BtnDel
        '
        resources.ApplyResources(Me.BtnDel, "BtnDel")
        Me.BtnDel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("BtnDel.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
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
        'btnAdd_W
        '
        Me.btnAdd_W.ImageOptions.Image = CType(resources.GetObject("btnAdd_W.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd_W.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnAdd_W, "btnAdd_W")
        Me.btnAdd_W.Name = "btnAdd_W"
        '
        'btnClear_W
        '
        Me.btnClear_W.ImageOptions.Image = CType(resources.GetObject("btnClear_W.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClear_W.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnClear_W, "btnClear_W")
        Me.btnClear_W.Name = "btnClear_W"
        '
        'btnDel_W
        '
        Me.btnDel_W.ImageOptions.Image = CType(resources.GetObject("btnDel_W.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDel_W.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnDel_W, "btnDel_W")
        Me.btnDel_W.Name = "btnDel_W"
        '
        'GroupControl2
        '
        resources.ApplyResources(Me.GroupControl2, "GroupControl2")
        Me.GroupControl2.AppearanceCaption.Font = CType(resources.GetObject("GroupControl2.AppearanceCaption.Font"), System.Drawing.Font)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.PanelControl2)
        Me.GroupControl2.Controls.Add(Me.GcHol)
        Me.GroupControl2.Controls.Add(Me.btnAdd_H)
        Me.GroupControl2.Controls.Add(Me.btnClear_H)
        Me.GroupControl2.Controls.Add(Me.btnDel_H)
        Me.GroupControl2.Name = "GroupControl2"
        '
        'PanelControl2
        '
        resources.ApplyResources(Me.PanelControl2, "PanelControl2")
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.txtDate_Hol)
        Me.PanelControl2.Controls.Add(Me.txtRemart_Hol)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Name = "PanelControl2"
        '
        'LabelControl4
        '
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Name = "LabelControl4"
        '
        'txtDate_Hol
        '
        resources.ApplyResources(Me.txtDate_Hol, "txtDate_Hol")
        Me.txtDate_Hol.EnterMoveNextControl = True
        Me.txtDate_Hol.Name = "txtDate_Hol"
        Me.txtDate_Hol.Properties.Appearance.Options.UseFont = True
        Me.txtDate_Hol.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDate_Hol.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDate_Hol.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDate_Hol.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDate_Hol.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtDate_Hol.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDate_Hol.Properties.Mask.EditMask = resources.GetString("txtDate_Hol.Properties.Mask.EditMask")
        Me.txtDate_Hol.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDate_Hol.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        '
        'txtRemart_Hol
        '
        Me.txtRemart_Hol.EnterMoveNextControl = True
        resources.ApplyResources(Me.txtRemart_Hol, "txtRemart_Hol")
        Me.txtRemart_Hol.Name = "txtRemart_Hol"
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        '
        'GcHol
        '
        resources.ApplyResources(Me.GcHol, "GcHol")
        Me.GcHol.MainView = Me.GvHol
        Me.GcHol.Name = "GcHol"
        Me.GcHol.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.GcHol.TabStop = False
        Me.GcHol.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvHol})
        '
        'GvHol
        '
        Me.GvHol.Appearance.HeaderPanel.Font = CType(resources.GetObject("GvHol.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GvHol.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvHol.Appearance.Row.Options.UseFont = True
        Me.GvHol.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.GvHol.GridControl = Me.GcHol
        Me.GvHol.Name = "GvHol"
        Me.GvHol.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.GvHol.OptionsView.ColumnAutoWidth = False
        Me.GvHol.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn1, "GridColumn1")
        Me.GridColumn1.FieldName = "row"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.TabStop = False
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn2, "GridColumn2")
        Me.GridColumn2.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "DateTimeHoliday"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        '
        'GridColumn3
        '
        resources.ApplyResources(Me.GridColumn3, "GridColumn3")
        Me.GridColumn3.FieldName = "Remark"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        '
        'RepositoryItemButtonEdit1
        '
        resources.ApplyResources(Me.RepositoryItemButtonEdit1, "RepositoryItemButtonEdit1")
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemButtonEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        Me.RepositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepositoryItemLookUpEdit1
        '
        resources.ApplyResources(Me.RepositoryItemLookUpEdit1, "RepositoryItemLookUpEdit1")
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("RepositoryItemLookUpEdit1.Columns"), CType(resources.GetObject("RepositoryItemLookUpEdit1.Columns1"), Integer), resources.GetString("RepositoryItemLookUpEdit1.Columns2"))})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "TransName"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "transcomId"
        '
        'RepositoryItemLookUpEdit2
        '
        resources.ApplyResources(Me.RepositoryItemLookUpEdit2, "RepositoryItemLookUpEdit2")
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEdit2.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("RepositoryItemLookUpEdit2.Columns"), resources.GetString("RepositoryItemLookUpEdit2.Columns1"))})
        Me.RepositoryItemLookUpEdit2.DisplayMember = "unit"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "unitid"
        '
        'btnAdd_H
        '
        Me.btnAdd_H.ImageOptions.Image = CType(resources.GetObject("btnAdd_H.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd_H.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnAdd_H, "btnAdd_H")
        Me.btnAdd_H.Name = "btnAdd_H"
        '
        'btnClear_H
        '
        Me.btnClear_H.ImageOptions.Image = CType(resources.GetObject("btnClear_H.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClear_H.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnClear_H, "btnClear_H")
        Me.btnClear_H.Name = "btnClear_H"
        '
        'btnDel_H
        '
        Me.btnDel_H.ImageOptions.Image = CType(resources.GetObject("btnDel_H.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDel_H.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnDel_H, "btnDel_H")
        Me.btnDel_H.Name = "btnDel_H"
        '
        'btnExit
        '
        Me.btnExit.ImageOptions.Image = CType(resources.GetObject("btnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.Name = "btnExit"
        '
        'frmWorkSpecial
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Name = "frmWorkSpecial"
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtDate_Work.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate_Work.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemark_Work.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtDate_Hol.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate_Hol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemart_Hol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcHol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvHol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lstWork As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents ColNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColRemark As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstHol As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnAdd_W As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear_W As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDel_W As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd_H As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear_H As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDel_H As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GcWork As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvWork As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colrow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode_lar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription_lar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cboTransport_detail As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboUnitName As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtRemark_Work As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDate_Work As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtDate_Hol As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtRemart_Hol As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GcHol As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvHol As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
