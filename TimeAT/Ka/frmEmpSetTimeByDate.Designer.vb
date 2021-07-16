<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpSetTimeByDate
    '  Inherits System.Windows.Forms.Form
    Inherits DevExpress.XtraEditors.XtraForm
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpSetTimeByDate))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.grpLeft = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.GcEmp = New DevExpress.XtraGrid.GridControl()
        Me.GvEmp = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colempcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_department = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cboTransport_detail = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboUnitName = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboDivision = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.rdByDeptName = New System.Windows.Forms.RadioButton()
        Me.rdByName = New System.Windows.Forms.RadioButton()
        Me.rdByDeptCode = New System.Windows.Forms.RadioButton()
        Me.rdByCode = New System.Windows.Forms.RadioButton()
        Me.cboDepartment = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.pnlNormalKa = New System.Windows.Forms.Panel()
        Me.rdGPAll = New System.Windows.Forms.RadioButton()
        Me.rdGP_Normal = New System.Windows.Forms.RadioButton()
        Me.rdGPByDate = New System.Windows.Forms.RadioButton()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.grpRight = New DevExpress.XtraEditors.GroupControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.cd_month = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.GcEmpKa = New DevExpress.XtraGrid.GridControl()
        Me.GvEmpKa = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GcKaByDay = New DevExpress.XtraGrid.GridControl()
        Me.gvKaByDay = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnDeleteKaByEmp = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lblCode = New DevExpress.XtraEditors.LabelControl()
        Me.txtDepartment = New DevExpress.XtraEditors.TextEdit()
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblKA = New DevExpress.XtraEditors.LabelControl()
        Me.txtYear = New DevExpress.XtraEditors.TextEdit()
        Me.cboKa = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.cboMonth = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblKaCode = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.ProgressBarX1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.pnlApp = New System.Windows.Forms.Panel()
        Me.ProgressBarX2 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.grpLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLeft.SuspendLayout()
        CType(Me.GcEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.grpRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRight.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.cd_month.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GcEmpKa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvEmpKa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GcKaByDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvKaByDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlApp.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        resources.ApplyResources(Me.SplitContainerControl1, "SplitContainerControl1")
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        resources.ApplyResources(Me.SplitContainerControl1.Panel1, "SplitContainerControl1.Panel1")
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.grpLeft)
        resources.ApplyResources(Me.SplitContainerControl1.Panel2, "SplitContainerControl1.Panel2")
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.grpRight)
        Me.SplitContainerControl1.SplitterPosition = 625
        '
        'grpLeft
        '
        resources.ApplyResources(Me.grpLeft, "grpLeft")
        Me.grpLeft.Controls.Add(Me.LabelControl7)
        Me.grpLeft.Controls.Add(Me.LabelControl6)
        Me.grpLeft.Controls.Add(Me.GcEmp)
        Me.grpLeft.Controls.Add(Me.cboDivision)
        Me.grpLeft.Controls.Add(Me.GroupControl1)
        Me.grpLeft.Controls.Add(Me.cboDepartment)
        Me.grpLeft.Controls.Add(Me.btnAdd)
        Me.grpLeft.Controls.Add(Me.GroupControl4)
        Me.grpLeft.Controls.Add(Me.btnRefresh)
        Me.grpLeft.Name = "grpLeft"
        '
        'LabelControl7
        '
        resources.ApplyResources(Me.LabelControl7, "LabelControl7")
        Me.LabelControl7.Name = "LabelControl7"
        '
        'LabelControl6
        '
        resources.ApplyResources(Me.LabelControl6, "LabelControl6")
        Me.LabelControl6.Name = "LabelControl6"
        '
        'GcEmp
        '
        resources.ApplyResources(Me.GcEmp, "GcEmp")
        Me.GcEmp.EmbeddedNavigator.AccessibleDescription = resources.GetString("GcEmp.EmbeddedNavigator.AccessibleDescription")
        Me.GcEmp.EmbeddedNavigator.AccessibleName = resources.GetString("GcEmp.EmbeddedNavigator.AccessibleName")
        Me.GcEmp.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GcEmp.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GcEmp.EmbeddedNavigator.Anchor = CType(resources.GetObject("GcEmp.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GcEmp.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GcEmp.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GcEmp.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GcEmp.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GcEmp.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GcEmp.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GcEmp.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GcEmp.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GcEmp.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GcEmp.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GcEmp.EmbeddedNavigator.ToolTip = resources.GetString("GcEmp.EmbeddedNavigator.ToolTip")
        Me.GcEmp.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GcEmp.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GcEmp.EmbeddedNavigator.ToolTipTitle = resources.GetString("GcEmp.EmbeddedNavigator.ToolTipTitle")
        Me.GcEmp.MainView = Me.GvEmp
        Me.GcEmp.Name = "GcEmp"
        Me.GcEmp.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.BtnDel, Me.cboTransport_detail, Me.cboUnitName})
        Me.GcEmp.TabStop = False
        Me.GcEmp.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvEmp})
        '
        'GvEmp
        '
        Me.GvEmp.Appearance.HeaderPanel.Font = CType(resources.GetObject("GvEmp.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GvEmp.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GvEmp.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GvEmp.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GvEmp.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GvEmp.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GvEmp.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GvEmp.Appearance.HeaderPanel.Image = CType(resources.GetObject("GvEmp.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GvEmp.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvEmp.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GvEmp.Appearance.Row.FontSizeDelta"), Integer)
        Me.GvEmp.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GvEmp.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GvEmp.Appearance.Row.GradientMode = CType(resources.GetObject("GvEmp.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GvEmp.Appearance.Row.Image = CType(resources.GetObject("GvEmp.Appearance.Row.Image"), System.Drawing.Image)
        Me.GvEmp.Appearance.Row.Options.UseFont = True
        resources.ApplyResources(Me.GvEmp, "GvEmp")
        Me.GvEmp.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colrow, Me.colempcode, Me.colProductName, Me.collname, Me.GridColumn1, Me.col_department, Me.GridColumn11})
        Me.GvEmp.GridControl = Me.GcEmp
        Me.GvEmp.Name = "GvEmp"
        Me.GvEmp.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.GvEmp.OptionsSelection.MultiSelect = True
        Me.GvEmp.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GvEmp.OptionsView.ColumnAutoWidth = False
        Me.GvEmp.OptionsView.ShowAutoFilterRow = True
        Me.GvEmp.OptionsView.ShowGroupPanel = False
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
        '
        'colempcode
        '
        Me.colempcode.AppearanceCell.FontSizeDelta = CType(resources.GetObject("colempcode.AppearanceCell.FontSizeDelta"), Integer)
        Me.colempcode.AppearanceCell.FontStyleDelta = CType(resources.GetObject("colempcode.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.colempcode.AppearanceCell.GradientMode = CType(resources.GetObject("colempcode.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.colempcode.AppearanceCell.Image = CType(resources.GetObject("colempcode.AppearanceCell.Image"), System.Drawing.Image)
        Me.colempcode.AppearanceCell.Options.UseTextOptions = True
        Me.colempcode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colempcode.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("colempcode.AppearanceHeader.FontSizeDelta"), Integer)
        Me.colempcode.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("colempcode.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.colempcode.AppearanceHeader.GradientMode = CType(resources.GetObject("colempcode.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.colempcode.AppearanceHeader.Image = CType(resources.GetObject("colempcode.AppearanceHeader.Image"), System.Drawing.Image)
        Me.colempcode.AppearanceHeader.Options.UseTextOptions = True
        Me.colempcode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colempcode, "colempcode")
        Me.colempcode.FieldName = "Code"
        Me.colempcode.Name = "colempcode"
        Me.colempcode.OptionsColumn.AllowEdit = False
        '
        'colProductName
        '
        resources.ApplyResources(Me.colProductName, "colProductName")
        Me.colProductName.FieldName = "Fname"
        Me.colProductName.Name = "colProductName"
        Me.colProductName.OptionsColumn.AllowEdit = False
        '
        'collname
        '
        resources.ApplyResources(Me.collname, "collname")
        Me.collname.FieldName = "Lname"
        Me.collname.Name = "collname"
        Me.collname.OptionsColumn.AllowEdit = False
        '
        'GridColumn1
        '
        resources.ApplyResources(Me.GridColumn1, "GridColumn1")
        Me.GridColumn1.FieldName = "Division"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'col_department
        '
        resources.ApplyResources(Me.col_department, "col_department")
        Me.col_department.FieldName = "Department"
        Me.col_department.Name = "col_department"
        Me.col_department.OptionsColumn.AllowEdit = False
        '
        'GridColumn11
        '
        resources.ApplyResources(Me.GridColumn11, "GridColumn11")
        Me.GridColumn11.FieldName = "Position"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.OptionsColumn.ReadOnly = True
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
        'GroupControl1
        '
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Controls.Add(Me.rdByDeptName)
        Me.GroupControl1.Controls.Add(Me.rdByName)
        Me.GroupControl1.Controls.Add(Me.rdByDeptCode)
        Me.GroupControl1.Controls.Add(Me.rdByCode)
        Me.GroupControl1.Name = "GroupControl1"
        '
        'rdByDeptName
        '
        resources.ApplyResources(Me.rdByDeptName, "rdByDeptName")
        Me.rdByDeptName.Name = "rdByDeptName"
        Me.rdByDeptName.UseVisualStyleBackColor = True
        '
        'rdByName
        '
        resources.ApplyResources(Me.rdByName, "rdByName")
        Me.rdByName.Name = "rdByName"
        Me.rdByName.UseVisualStyleBackColor = True
        '
        'rdByDeptCode
        '
        resources.ApplyResources(Me.rdByDeptCode, "rdByDeptCode")
        Me.rdByDeptCode.Name = "rdByDeptCode"
        Me.rdByDeptCode.UseVisualStyleBackColor = True
        '
        'rdByCode
        '
        resources.ApplyResources(Me.rdByCode, "rdByCode")
        Me.rdByCode.Checked = True
        Me.rdByCode.Name = "rdByCode"
        Me.rdByCode.TabStop = True
        Me.rdByCode.UseVisualStyleBackColor = True
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
        'btnAdd
        '
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        Me.btnAdd.Appearance.Font = CType(resources.GetObject("btnAdd.Appearance.Font"), System.Drawing.Font)
        Me.btnAdd.Appearance.FontSizeDelta = CType(resources.GetObject("btnAdd.Appearance.FontSizeDelta"), Integer)
        Me.btnAdd.Appearance.FontStyleDelta = CType(resources.GetObject("btnAdd.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.btnAdd.Appearance.GradientMode = CType(resources.GetObject("btnAdd.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.btnAdd.Appearance.Image = CType(resources.GetObject("btnAdd.Appearance.Image"), System.Drawing.Image)
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("btnAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnAdd.Name = "btnAdd"
        '
        'GroupControl4
        '
        resources.ApplyResources(Me.GroupControl4, "GroupControl4")
        Me.GroupControl4.Controls.Add(Me.pnlNormalKa)
        Me.GroupControl4.Controls.Add(Me.rdGPAll)
        Me.GroupControl4.Controls.Add(Me.rdGP_Normal)
        Me.GroupControl4.Controls.Add(Me.rdGPByDate)
        Me.GroupControl4.Name = "GroupControl4"
        '
        'pnlNormalKa
        '
        resources.ApplyResources(Me.pnlNormalKa, "pnlNormalKa")
        Me.pnlNormalKa.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlNormalKa.Name = "pnlNormalKa"
        '
        'rdGPAll
        '
        resources.ApplyResources(Me.rdGPAll, "rdGPAll")
        Me.rdGPAll.Checked = True
        Me.rdGPAll.Name = "rdGPAll"
        Me.rdGPAll.TabStop = True
        Me.rdGPAll.UseVisualStyleBackColor = True
        '
        'rdGP_Normal
        '
        resources.ApplyResources(Me.rdGP_Normal, "rdGP_Normal")
        Me.rdGP_Normal.Name = "rdGP_Normal"
        Me.rdGP_Normal.UseVisualStyleBackColor = True
        '
        'rdGPByDate
        '
        resources.ApplyResources(Me.rdGPByDate, "rdGPByDate")
        Me.rdGPByDate.Name = "rdGPByDate"
        Me.rdGPByDate.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        resources.ApplyResources(Me.btnRefresh, "btnRefresh")
        Me.btnRefresh.Appearance.Font = CType(resources.GetObject("btnRefresh.Appearance.Font"), System.Drawing.Font)
        Me.btnRefresh.Appearance.FontSizeDelta = CType(resources.GetObject("btnRefresh.Appearance.FontSizeDelta"), Integer)
        Me.btnRefresh.Appearance.FontStyleDelta = CType(resources.GetObject("btnRefresh.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.btnRefresh.Appearance.GradientMode = CType(resources.GetObject("btnRefresh.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.btnRefresh.Appearance.Image = CType(resources.GetObject("btnRefresh.Appearance.Image"), System.Drawing.Image)
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.ImageOptions.Image = CType(resources.GetObject("btnRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnRefresh.Name = "btnRefresh"
        '
        'grpRight
        '
        resources.ApplyResources(Me.grpRight, "grpRight")
        Me.grpRight.Controls.Add(Me.XtraTabControl1)
        Me.grpRight.Controls.Add(Me.PanelControl1)
        Me.grpRight.Name = "grpRight"
        '
        'XtraTabControl1
        '
        resources.ApplyResources(Me.XtraTabControl1, "XtraTabControl1")
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        resources.ApplyResources(Me.XtraTabPage1, "XtraTabPage1")
        Me.XtraTabPage1.Controls.Add(Me.cd_month)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage1.Controls.Add(Me.GroupControl5)
        Me.XtraTabPage1.Controls.Add(Me.btnRemove)
        Me.XtraTabPage1.Controls.Add(Me.btnSave)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        '
        'cd_month
        '
        resources.ApplyResources(Me.cd_month, "cd_month")
        Me.cd_month.CalendarTimeProperties.AccessibleDescription = resources.GetString("cd_month.CalendarTimeProperties.AccessibleDescription")
        Me.cd_month.CalendarTimeProperties.AccessibleName = resources.GetString("cd_month.CalendarTimeProperties.AccessibleName")
        Me.cd_month.CalendarTimeProperties.AutoHeight = CType(resources.GetObject("cd_month.CalendarTimeProperties.AutoHeight"), Boolean)
        Me.cd_month.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cd_month.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cd_month.CalendarTimeProperties.Mask.AutoComplete = CType(resources.GetObject("cd_month.CalendarTimeProperties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.cd_month.CalendarTimeProperties.Mask.BeepOnError = CType(resources.GetObject("cd_month.CalendarTimeProperties.Mask.BeepOnError"), Boolean)
        Me.cd_month.CalendarTimeProperties.Mask.EditMask = resources.GetString("cd_month.CalendarTimeProperties.Mask.EditMask")
        Me.cd_month.CalendarTimeProperties.Mask.IgnoreMaskBlank = CType(resources.GetObject("cd_month.CalendarTimeProperties.Mask.IgnoreMaskBlank"), Boolean)
        Me.cd_month.CalendarTimeProperties.Mask.MaskType = CType(resources.GetObject("cd_month.CalendarTimeProperties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.cd_month.CalendarTimeProperties.Mask.PlaceHolder = CType(resources.GetObject("cd_month.CalendarTimeProperties.Mask.PlaceHolder"), Char)
        Me.cd_month.CalendarTimeProperties.Mask.SaveLiteral = CType(resources.GetObject("cd_month.CalendarTimeProperties.Mask.SaveLiteral"), Boolean)
        Me.cd_month.CalendarTimeProperties.Mask.ShowPlaceHolders = CType(resources.GetObject("cd_month.CalendarTimeProperties.Mask.ShowPlaceHolders"), Boolean)
        Me.cd_month.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("cd_month.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.cd_month.CalendarTimeProperties.NullValuePrompt = resources.GetString("cd_month.CalendarTimeProperties.NullValuePrompt")
        Me.cd_month.CalendarTimeProperties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("cd_month.CalendarTimeProperties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.cd_month.HighlightTodayCell = DevExpress.Utils.DefaultBoolean.[False]
        Me.cd_month.HighlightTodayCellWhenSelected = False
        Me.cd_month.InactiveDaysVisibility = DevExpress.XtraEditors.Controls.CalendarInactiveDaysVisibility.Hidden
        Me.cd_month.Name = "cd_month"
        Me.cd_month.SelectionMode = DevExpress.XtraEditors.Repository.CalendarSelectionMode.Multiple
        Me.cd_month.ShowHeader = False
        Me.cd_month.ShowTodayButton = False
        Me.cd_month.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.MonthView
        '
        'LabelControl10
        '
        resources.ApplyResources(Me.LabelControl10, "LabelControl10")
        Me.LabelControl10.Appearance.FontSizeDelta = CType(resources.GetObject("LabelControl10.Appearance.FontSizeDelta"), Integer)
        Me.LabelControl10.Appearance.FontStyleDelta = CType(resources.GetObject("LabelControl10.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.LabelControl10.Appearance.GradientMode = CType(resources.GetObject("LabelControl10.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.LabelControl10.Appearance.Image = CType(resources.GetObject("LabelControl10.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl10.Appearance.Options.UseTextOptions = True
        Me.LabelControl10.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl10.Name = "LabelControl10"
        '
        'LabelControl5
        '
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Appearance.FontSizeDelta = CType(resources.GetObject("LabelControl5.Appearance.FontSizeDelta"), Integer)
        Me.LabelControl5.Appearance.FontStyleDelta = CType(resources.GetObject("LabelControl5.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.LabelControl5.Appearance.GradientMode = CType(resources.GetObject("LabelControl5.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.LabelControl5.Appearance.Image = CType(resources.GetObject("LabelControl5.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl5.Name = "LabelControl5"
        '
        'LabelControl4
        '
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Name = "LabelControl4"
        '
        'GroupControl5
        '
        resources.ApplyResources(Me.GroupControl5, "GroupControl5")
        Me.GroupControl5.Controls.Add(Me.GcEmpKa)
        Me.GroupControl5.Name = "GroupControl5"
        '
        'GcEmpKa
        '
        resources.ApplyResources(Me.GcEmpKa, "GcEmpKa")
        Me.GcEmpKa.EmbeddedNavigator.AccessibleDescription = resources.GetString("GcEmpKa.EmbeddedNavigator.AccessibleDescription")
        Me.GcEmpKa.EmbeddedNavigator.AccessibleName = resources.GetString("GcEmpKa.EmbeddedNavigator.AccessibleName")
        Me.GcEmpKa.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GcEmpKa.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GcEmpKa.EmbeddedNavigator.Anchor = CType(resources.GetObject("GcEmpKa.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GcEmpKa.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GcEmpKa.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GcEmpKa.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GcEmpKa.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GcEmpKa.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GcEmpKa.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GcEmpKa.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GcEmpKa.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GcEmpKa.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GcEmpKa.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GcEmpKa.EmbeddedNavigator.ToolTip = resources.GetString("GcEmpKa.EmbeddedNavigator.ToolTip")
        Me.GcEmpKa.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GcEmpKa.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GcEmpKa.EmbeddedNavigator.ToolTipTitle = resources.GetString("GcEmpKa.EmbeddedNavigator.ToolTipTitle")
        Me.GcEmpKa.MainView = Me.GvEmpKa
        Me.GcEmpKa.Name = "GcEmpKa"
        Me.GcEmpKa.TabStop = False
        Me.GcEmpKa.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvEmpKa})
        '
        'GvEmpKa
        '
        Me.GvEmpKa.Appearance.HeaderPanel.Font = CType(resources.GetObject("GvEmpKa.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GvEmpKa.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GvEmpKa.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GvEmpKa.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GvEmpKa.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GvEmpKa.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GvEmpKa.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GvEmpKa.Appearance.HeaderPanel.Image = CType(resources.GetObject("GvEmpKa.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GvEmpKa.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvEmpKa.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GvEmpKa.Appearance.Row.FontSizeDelta"), Integer)
        Me.GvEmpKa.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GvEmpKa.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GvEmpKa.Appearance.Row.GradientMode = CType(resources.GetObject("GvEmpKa.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GvEmpKa.Appearance.Row.Image = CType(resources.GetObject("GvEmpKa.Appearance.Row.Image"), System.Drawing.Image)
        Me.GvEmpKa.Appearance.Row.Options.UseFont = True
        resources.ApplyResources(Me.GvEmpKa, "GvEmpKa")
        Me.GvEmpKa.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGNo, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn12, Me.GridColumn5, Me.GridColumn13})
        Me.GvEmpKa.GridControl = Me.GcEmpKa
        Me.GvEmpKa.Name = "GvEmpKa"
        Me.GvEmpKa.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.GvEmpKa.OptionsSelection.MultiSelect = True
        Me.GvEmpKa.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GvEmpKa.OptionsView.ColumnAutoWidth = False
        Me.GvEmpKa.OptionsView.ShowAutoFilterRow = True
        Me.GvEmpKa.OptionsView.ShowGroupPanel = False
        '
        'colGNo
        '
        Me.colGNo.AppearanceCell.FontSizeDelta = CType(resources.GetObject("colGNo.AppearanceCell.FontSizeDelta"), Integer)
        Me.colGNo.AppearanceCell.FontStyleDelta = CType(resources.GetObject("colGNo.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.colGNo.AppearanceCell.GradientMode = CType(resources.GetObject("colGNo.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.colGNo.AppearanceCell.Image = CType(resources.GetObject("colGNo.AppearanceCell.Image"), System.Drawing.Image)
        Me.colGNo.AppearanceCell.Options.UseTextOptions = True
        Me.colGNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGNo.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("colGNo.AppearanceHeader.FontSizeDelta"), Integer)
        Me.colGNo.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("colGNo.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.colGNo.AppearanceHeader.GradientMode = CType(resources.GetObject("colGNo.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.colGNo.AppearanceHeader.Image = CType(resources.GetObject("colGNo.AppearanceHeader.Image"), System.Drawing.Image)
        Me.colGNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colGNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colGNo, "colGNo")
        Me.colGNo.FieldName = "row"
        Me.colGNo.Name = "colGNo"
        Me.colGNo.OptionsColumn.AllowEdit = False
        Me.colGNo.OptionsColumn.TabStop = False
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GridColumn2.AppearanceCell.FontSizeDelta"), Integer)
        Me.GridColumn2.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GridColumn2.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridColumn2.AppearanceCell.GradientMode = CType(resources.GetObject("GridColumn2.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn2.AppearanceCell.Image = CType(resources.GetObject("GridColumn2.AppearanceCell.Image"), System.Drawing.Image)
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GridColumn2.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GridColumn2.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GridColumn2.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridColumn2.AppearanceHeader.GradientMode = CType(resources.GetObject("GridColumn2.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn2.AppearanceHeader.Image = CType(resources.GetObject("GridColumn2.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn2, "GridColumn2")
        Me.GridColumn2.FieldName = "Code"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        '
        'GridColumn3
        '
        resources.ApplyResources(Me.GridColumn3, "GridColumn3")
        Me.GridColumn3.FieldName = "Fname"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        '
        'GridColumn4
        '
        resources.ApplyResources(Me.GridColumn4, "GridColumn4")
        Me.GridColumn4.FieldName = "Lname"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        '
        'GridColumn12
        '
        resources.ApplyResources(Me.GridColumn12, "GridColumn12")
        Me.GridColumn12.FieldName = "Division"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        '
        'GridColumn5
        '
        resources.ApplyResources(Me.GridColumn5, "GridColumn5")
        Me.GridColumn5.FieldName = "Department"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        '
        'GridColumn13
        '
        resources.ApplyResources(Me.GridColumn13, "GridColumn13")
        Me.GridColumn13.FieldName = "Position"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        '
        'btnRemove
        '
        resources.ApplyResources(Me.btnRemove, "btnRemove")
        Me.btnRemove.Appearance.Font = CType(resources.GetObject("btnRemove.Appearance.Font"), System.Drawing.Font)
        Me.btnRemove.Appearance.FontSizeDelta = CType(resources.GetObject("btnRemove.Appearance.FontSizeDelta"), Integer)
        Me.btnRemove.Appearance.FontStyleDelta = CType(resources.GetObject("btnRemove.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.btnRemove.Appearance.GradientMode = CType(resources.GetObject("btnRemove.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.btnRemove.Appearance.Image = CType(resources.GetObject("btnRemove.Appearance.Image"), System.Drawing.Image)
        Me.btnRemove.Appearance.Options.UseFont = True
        Me.btnRemove.ImageOptions.Image = CType(resources.GetObject("btnRemove.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRemove.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnRemove.Name = "btnRemove"
        '
        'btnSave
        '
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.Appearance.Font = CType(resources.GetObject("btnSave.Appearance.Font"), System.Drawing.Font)
        Me.btnSave.Appearance.FontSizeDelta = CType(resources.GetObject("btnSave.Appearance.FontSizeDelta"), Integer)
        Me.btnSave.Appearance.FontStyleDelta = CType(resources.GetObject("btnSave.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.btnSave.Appearance.GradientMode = CType(resources.GetObject("btnSave.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.btnSave.Appearance.Image = CType(resources.GetObject("btnSave.Appearance.Image"), System.Drawing.Image)
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnSave.Name = "btnSave"
        '
        'XtraTabPage2
        '
        resources.ApplyResources(Me.XtraTabPage2, "XtraTabPage2")
        Me.XtraTabPage2.Controls.Add(Me.GcKaByDay)
        Me.XtraTabPage2.Controls.Add(Me.btnDeleteKaByEmp)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Controls.Add(Me.lblCode)
        Me.XtraTabPage2.Controls.Add(Me.txtDepartment)
        Me.XtraTabPage2.Controls.Add(Me.txtName)
        Me.XtraTabPage2.Controls.Add(Me.txtCode)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        '
        'GcKaByDay
        '
        resources.ApplyResources(Me.GcKaByDay, "GcKaByDay")
        Me.GcKaByDay.EmbeddedNavigator.AccessibleDescription = resources.GetString("GcKaByDay.EmbeddedNavigator.AccessibleDescription")
        Me.GcKaByDay.EmbeddedNavigator.AccessibleName = resources.GetString("GcKaByDay.EmbeddedNavigator.AccessibleName")
        Me.GcKaByDay.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GcKaByDay.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GcKaByDay.EmbeddedNavigator.Anchor = CType(resources.GetObject("GcKaByDay.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GcKaByDay.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GcKaByDay.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GcKaByDay.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GcKaByDay.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GcKaByDay.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GcKaByDay.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GcKaByDay.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GcKaByDay.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GcKaByDay.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GcKaByDay.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GcKaByDay.EmbeddedNavigator.ToolTip = resources.GetString("GcKaByDay.EmbeddedNavigator.ToolTip")
        Me.GcKaByDay.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GcKaByDay.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GcKaByDay.EmbeddedNavigator.ToolTipTitle = resources.GetString("GcKaByDay.EmbeddedNavigator.ToolTipTitle")
        Me.GcKaByDay.MainView = Me.gvKaByDay
        Me.GcKaByDay.Name = "GcKaByDay"
        Me.GcKaByDay.TabStop = False
        Me.GcKaByDay.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvKaByDay})
        '
        'gvKaByDay
        '
        Me.gvKaByDay.Appearance.HeaderPanel.Font = CType(resources.GetObject("gvKaByDay.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.gvKaByDay.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("gvKaByDay.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.gvKaByDay.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("gvKaByDay.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.gvKaByDay.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("gvKaByDay.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.gvKaByDay.Appearance.HeaderPanel.Image = CType(resources.GetObject("gvKaByDay.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.gvKaByDay.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvKaByDay.Appearance.Row.FontSizeDelta = CType(resources.GetObject("gvKaByDay.Appearance.Row.FontSizeDelta"), Integer)
        Me.gvKaByDay.Appearance.Row.FontStyleDelta = CType(resources.GetObject("gvKaByDay.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.gvKaByDay.Appearance.Row.GradientMode = CType(resources.GetObject("gvKaByDay.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.gvKaByDay.Appearance.Row.Image = CType(resources.GetObject("gvKaByDay.Appearance.Row.Image"), System.Drawing.Image)
        Me.gvKaByDay.Appearance.Row.Options.UseFont = True
        resources.ApplyResources(Me.gvKaByDay, "gvKaByDay")
        Me.gvKaByDay.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.gvKaByDay.GridControl = Me.GcKaByDay
        Me.gvKaByDay.Name = "gvKaByDay"
        Me.gvKaByDay.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.gvKaByDay.OptionsSelection.MultiSelect = True
        Me.gvKaByDay.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gvKaByDay.OptionsView.ColumnAutoWidth = False
        Me.gvKaByDay.OptionsView.ShowAutoFilterRow = True
        Me.gvKaByDay.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GridColumn6.AppearanceCell.FontSizeDelta"), Integer)
        Me.GridColumn6.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GridColumn6.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridColumn6.AppearanceCell.GradientMode = CType(resources.GetObject("GridColumn6.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn6.AppearanceCell.Image = CType(resources.GetObject("GridColumn6.AppearanceCell.Image"), System.Drawing.Image)
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GridColumn6.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GridColumn6.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GridColumn6.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridColumn6.AppearanceHeader.GradientMode = CType(resources.GetObject("GridColumn6.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn6.AppearanceHeader.Image = CType(resources.GetObject("GridColumn6.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn6, "GridColumn6")
        Me.GridColumn6.FieldName = "row"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.TabStop = False
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GridColumn7.AppearanceCell.FontSizeDelta"), Integer)
        Me.GridColumn7.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GridColumn7.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridColumn7.AppearanceCell.GradientMode = CType(resources.GetObject("GridColumn7.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn7.AppearanceCell.Image = CType(resources.GetObject("GridColumn7.AppearanceCell.Image"), System.Drawing.Image)
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GridColumn7.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GridColumn7.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GridColumn7.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridColumn7.AppearanceHeader.GradientMode = CType(resources.GetObject("GridColumn7.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn7.AppearanceHeader.Image = CType(resources.GetObject("GridColumn7.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn7, "GridColumn7")
        Me.GridColumn7.FieldName = "dOfW_str"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GridColumn8.AppearanceCell.FontSizeDelta"), Integer)
        Me.GridColumn8.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GridColumn8.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridColumn8.AppearanceCell.GradientMode = CType(resources.GetObject("GridColumn8.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn8.AppearanceCell.Image = CType(resources.GetObject("GridColumn8.AppearanceCell.Image"), System.Drawing.Image)
        Me.GridColumn8.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GridColumn8.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GridColumn8.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GridColumn8.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridColumn8.AppearanceHeader.GradientMode = CType(resources.GetObject("GridColumn8.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn8.AppearanceHeader.Image = CType(resources.GetObject("GridColumn8.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn8, "GridColumn8")
        Me.GridColumn8.FieldName = "ka_date"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GridColumn9.AppearanceCell.FontSizeDelta"), Integer)
        Me.GridColumn9.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GridColumn9.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridColumn9.AppearanceCell.GradientMode = CType(resources.GetObject("GridColumn9.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn9.AppearanceCell.Image = CType(resources.GetObject("GridColumn9.AppearanceCell.Image"), System.Drawing.Image)
        Me.GridColumn9.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GridColumn9.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GridColumn9.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GridColumn9.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridColumn9.AppearanceHeader.GradientMode = CType(resources.GetObject("GridColumn9.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn9.AppearanceHeader.Image = CType(resources.GetObject("GridColumn9.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn9, "GridColumn9")
        Me.GridColumn9.FieldName = "ka_code"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GridColumn10.AppearanceCell.FontSizeDelta"), Integer)
        Me.GridColumn10.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GridColumn10.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridColumn10.AppearanceCell.GradientMode = CType(resources.GetObject("GridColumn10.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn10.AppearanceCell.Image = CType(resources.GetObject("GridColumn10.AppearanceCell.Image"), System.Drawing.Image)
        Me.GridColumn10.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GridColumn10.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GridColumn10.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GridColumn10.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridColumn10.AppearanceHeader.GradientMode = CType(resources.GetObject("GridColumn10.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn10.AppearanceHeader.Image = CType(resources.GetObject("GridColumn10.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn10, "GridColumn10")
        Me.GridColumn10.FieldName = "KaName"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        '
        'btnDeleteKaByEmp
        '
        resources.ApplyResources(Me.btnDeleteKaByEmp, "btnDeleteKaByEmp")
        Me.btnDeleteKaByEmp.ImageOptions.Image = CType(resources.GetObject("btnDeleteKaByEmp.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDeleteKaByEmp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnDeleteKaByEmp.Name = "btnDeleteKaByEmp"
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        '
        'lblCode
        '
        resources.ApplyResources(Me.lblCode, "lblCode")
        Me.lblCode.Name = "lblCode"
        '
        'txtDepartment
        '
        resources.ApplyResources(Me.txtDepartment, "txtDepartment")
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Properties.AccessibleDescription = resources.GetString("txtDepartment.Properties.AccessibleDescription")
        Me.txtDepartment.Properties.AccessibleName = resources.GetString("txtDepartment.Properties.AccessibleName")
        Me.txtDepartment.Properties.AutoHeight = CType(resources.GetObject("txtDepartment.Properties.AutoHeight"), Boolean)
        Me.txtDepartment.Properties.Mask.AutoComplete = CType(resources.GetObject("txtDepartment.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDepartment.Properties.Mask.BeepOnError = CType(resources.GetObject("txtDepartment.Properties.Mask.BeepOnError"), Boolean)
        Me.txtDepartment.Properties.Mask.EditMask = resources.GetString("txtDepartment.Properties.Mask.EditMask")
        Me.txtDepartment.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDepartment.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDepartment.Properties.Mask.MaskType = CType(resources.GetObject("txtDepartment.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDepartment.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtDepartment.Properties.Mask.PlaceHolder"), Char)
        Me.txtDepartment.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtDepartment.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtDepartment.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDepartment.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDepartment.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDepartment.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDepartment.Properties.NullValuePrompt = resources.GetString("txtDepartment.Properties.NullValuePrompt")
        Me.txtDepartment.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtDepartment.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.txtDepartment.Properties.ReadOnly = True
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
        'txtCode
        '
        resources.ApplyResources(Me.txtCode, "txtCode")
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.AccessibleDescription = resources.GetString("txtCode.Properties.AccessibleDescription")
        Me.txtCode.Properties.AccessibleName = resources.GetString("txtCode.Properties.AccessibleName")
        Me.txtCode.Properties.AutoHeight = CType(resources.GetObject("txtCode.Properties.AutoHeight"), Boolean)
        Me.txtCode.Properties.Mask.AutoComplete = CType(resources.GetObject("txtCode.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtCode.Properties.Mask.BeepOnError = CType(resources.GetObject("txtCode.Properties.Mask.BeepOnError"), Boolean)
        Me.txtCode.Properties.Mask.EditMask = resources.GetString("txtCode.Properties.Mask.EditMask")
        Me.txtCode.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtCode.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtCode.Properties.Mask.MaskType = CType(resources.GetObject("txtCode.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtCode.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtCode.Properties.Mask.PlaceHolder"), Char)
        Me.txtCode.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtCode.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtCode.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtCode.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtCode.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtCode.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtCode.Properties.NullValuePrompt = resources.GetString("txtCode.Properties.NullValuePrompt")
        Me.txtCode.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtCode.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.txtCode.Properties.ReadOnly = True
        '
        'PanelControl1
        '
        resources.ApplyResources(Me.PanelControl1, "PanelControl1")
        Me.PanelControl1.Controls.Add(Me.lblKA)
        Me.PanelControl1.Controls.Add(Me.txtYear)
        Me.PanelControl1.Controls.Add(Me.cboKa)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.cboMonth)
        Me.PanelControl1.Controls.Add(Me.lblKaCode)
        Me.PanelControl1.Name = "PanelControl1"
        '
        'lblKA
        '
        resources.ApplyResources(Me.lblKA, "lblKA")
        Me.lblKA.Name = "lblKA"
        '
        'txtYear
        '
        resources.ApplyResources(Me.txtYear, "txtYear")
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
        'cboKa
        '
        resources.ApplyResources(Me.cboKa, "cboKa")
        Me.cboKa.Name = "cboKa"
        Me.cboKa.Properties.AccessibleDescription = resources.GetString("cboKa.Properties.AccessibleDescription")
        Me.cboKa.Properties.AccessibleName = resources.GetString("cboKa.Properties.AccessibleName")
        Me.cboKa.Properties.AutoHeight = CType(resources.GetObject("cboKa.Properties.AutoHeight"), Boolean)
        Me.cboKa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboKa.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboKa.Properties.DropDownRows = 15
        Me.cboKa.Properties.NullValuePrompt = resources.GetString("cboKa.Properties.NullValuePrompt")
        Me.cboKa.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("cboKa.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.cboKa.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'LabelControl8
        '
        resources.ApplyResources(Me.LabelControl8, "LabelControl8")
        Me.LabelControl8.Name = "LabelControl8"
        '
        'cboMonth
        '
        resources.ApplyResources(Me.cboMonth, "cboMonth")
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
        'lblKaCode
        '
        resources.ApplyResources(Me.lblKaCode, "lblKaCode")
        Me.lblKaCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblKaCode.Name = "lblKaCode"
        '
        'GroupBox2
        '
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'btnExit
        '
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.ImageOptions.Image = CType(resources.GetObject("btnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnExit.Name = "btnExit"
        '
        'ProgressBarX1
        '
        resources.ApplyResources(Me.ProgressBarX1, "ProgressBarX1")
        '
        '
        '
        Me.ProgressBarX1.BackgroundStyle.Class = ""
        Me.ProgressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBarX1.Name = "ProgressBarX1"
        Me.ProgressBarX1.TextVisible = True
        '
        'pnlApp
        '
        resources.ApplyResources(Me.pnlApp, "pnlApp")
        Me.pnlApp.Controls.Add(Me.SplitContainerControl1)
        Me.pnlApp.Name = "pnlApp"
        '
        'ProgressBarX2
        '
        resources.ApplyResources(Me.ProgressBarX2, "ProgressBarX2")
        '
        '
        '
        Me.ProgressBarX2.BackgroundStyle.Class = ""
        Me.ProgressBarX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBarX2.Name = "ProgressBarX2"
        Me.ProgressBarX2.TextVisible = True
        '
        'frmEmpSetTimeByDate
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlApp)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.ProgressBarX2)
        Me.Controls.Add(Me.ProgressBarX1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmEmpSetTimeByDate"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.grpLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLeft.ResumeLayout(False)
        Me.grpLeft.PerformLayout()
        CType(Me.GcEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.grpRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRight.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.cd_month.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.GcEmpKa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvEmpKa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.GcKaByDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvKaByDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlApp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblKaCode As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdGP_Normal As System.Windows.Forms.RadioButton
    Friend WithEvents rdGPByDate As System.Windows.Forms.RadioButton
    Friend WithEvents rdGPAll As System.Windows.Forms.RadioButton
    Friend WithEvents pnlNormalKa As System.Windows.Forms.Panel
    Friend WithEvents rdByDeptName As System.Windows.Forms.RadioButton
    Friend WithEvents rdByDeptCode As System.Windows.Forms.RadioButton
    Friend WithEvents rdByName As System.Windows.Forms.RadioButton
    Friend WithEvents rdByCode As System.Windows.Forms.RadioButton
    Friend WithEvents cboDivision As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboDepartment As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GcEmp As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvEmp As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colrow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colempcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_department As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cboTransport_detail As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboUnitName As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProgressBarX1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cboKa As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboMonth As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtYear As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GcEmpKa As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvEmpKa As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colGNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GcKaByDay As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvKaByDay As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDeleteKaByEmp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDepartment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlApp As Panel
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents grpLeft As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpRight As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ProgressBarX2 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblKA As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cd_month As DevExpress.XtraEditors.Controls.CalendarControl
End Class
