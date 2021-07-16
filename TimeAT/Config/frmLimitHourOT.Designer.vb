<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLimitHourOT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLimitHourOT))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.grpLeft = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.GcEmp = New DevExpress.XtraGrid.GridControl()
        Me.GvEmp = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colempcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_department = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cboTransport_detail = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboUnitName = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLimitHourOT = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.rdByDeptName = New System.Windows.Forms.RadioButton()
        Me.rdByCode = New System.Windows.Forms.RadioButton()
        Me.rdByDeptCode = New System.Windows.Forms.RadioButton()
        Me.rdByName = New System.Windows.Forms.RadioButton()
        Me.cboDivision = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.cboDepartment = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.grpRight = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.GcEmp_Cal = New DevExpress.XtraGrid.GridControl()
        Me.GvEmp_Cal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.rdByDeptName_Cal = New System.Windows.Forms.RadioButton()
        Me.rdByName_Cal = New System.Windows.Forms.RadioButton()
        Me.rdByDeptCode_Cal = New System.Windows.Forms.RadioButton()
        Me.rdByCode_Cal = New System.Windows.Forms.RadioButton()
        Me.btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.cboDivision_Cal = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnRefresh_Cal = New DevExpress.XtraEditors.SimpleButton()
        Me.cboDepartment_Cal = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.ProgressBarX1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.pnlApp = New System.Windows.Forms.Panel()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.grpLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLeft.SuspendLayout()
        CType(Me.GcEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtLimitHourOT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRight.SuspendLayout()
        CType(Me.GcEmp_Cal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvEmp_Cal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.cboDivision_Cal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDepartment_Cal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.grpLeft.Controls.Add(Me.LabelControl2)
        Me.grpLeft.Controls.Add(Me.LabelControl1)
        Me.grpLeft.Controls.Add(Me.btnAdd)
        Me.grpLeft.Controls.Add(Me.GcEmp)
        Me.grpLeft.Controls.Add(Me.PanelControl1)
        Me.grpLeft.Controls.Add(Me.GroupControl1)
        Me.grpLeft.Controls.Add(Me.cboDivision)
        Me.grpLeft.Controls.Add(Me.btnRefresh)
        Me.grpLeft.Controls.Add(Me.cboDepartment)
        Me.grpLeft.Name = "grpLeft"
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
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
        Me.GvEmp.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colrow, Me.colempcode, Me.colProductName, Me.collname, Me.GridColumn10, Me.col_department, Me.GridColumn11})
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
        'GridColumn10
        '
        resources.ApplyResources(Me.GridColumn10, "GridColumn10")
        Me.GridColumn10.FieldName = "Division"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.OptionsColumn.ReadOnly = True
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
        'PanelControl1
        '
        resources.ApplyResources(Me.PanelControl1, "PanelControl1")
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.txtLimitHourOT)
        Me.PanelControl1.Name = "PanelControl1"
        '
        'LabelControl6
        '
        resources.ApplyResources(Me.LabelControl6, "LabelControl6")
        Me.LabelControl6.Name = "LabelControl6"
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        '
        'txtLimitHourOT
        '
        resources.ApplyResources(Me.txtLimitHourOT, "txtLimitHourOT")
        Me.txtLimitHourOT.Name = "txtLimitHourOT"
        Me.txtLimitHourOT.Properties.AccessibleDescription = resources.GetString("txtLimitHourOT.Properties.AccessibleDescription")
        Me.txtLimitHourOT.Properties.AccessibleName = resources.GetString("txtLimitHourOT.Properties.AccessibleName")
        Me.txtLimitHourOT.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtLimitHourOT.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtLimitHourOT.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtLimitHourOT.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtLimitHourOT.Properties.Appearance.GradientMode = CType(resources.GetObject("txtLimitHourOT.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtLimitHourOT.Properties.Appearance.Image = CType(resources.GetObject("txtLimitHourOT.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtLimitHourOT.Properties.Appearance.Options.UseTextOptions = True
        Me.txtLimitHourOT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtLimitHourOT.Properties.AutoHeight = CType(resources.GetObject("txtLimitHourOT.Properties.AutoHeight"), Boolean)
        Me.txtLimitHourOT.Properties.Mask.AutoComplete = CType(resources.GetObject("txtLimitHourOT.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtLimitHourOT.Properties.Mask.BeepOnError = CType(resources.GetObject("txtLimitHourOT.Properties.Mask.BeepOnError"), Boolean)
        Me.txtLimitHourOT.Properties.Mask.EditMask = resources.GetString("txtLimitHourOT.Properties.Mask.EditMask")
        Me.txtLimitHourOT.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtLimitHourOT.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtLimitHourOT.Properties.Mask.MaskType = CType(resources.GetObject("txtLimitHourOT.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtLimitHourOT.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtLimitHourOT.Properties.Mask.PlaceHolder"), Char)
        Me.txtLimitHourOT.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtLimitHourOT.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtLimitHourOT.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtLimitHourOT.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtLimitHourOT.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtLimitHourOT.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtLimitHourOT.Properties.NullValuePrompt = resources.GetString("txtLimitHourOT.Properties.NullValuePrompt")
        Me.txtLimitHourOT.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtLimitHourOT.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'GroupControl1
        '
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Controls.Add(Me.rdByDeptName)
        Me.GroupControl1.Controls.Add(Me.rdByCode)
        Me.GroupControl1.Controls.Add(Me.rdByDeptCode)
        Me.GroupControl1.Controls.Add(Me.rdByName)
        Me.GroupControl1.Name = "GroupControl1"
        '
        'rdByDeptName
        '
        resources.ApplyResources(Me.rdByDeptName, "rdByDeptName")
        Me.rdByDeptName.Name = "rdByDeptName"
        Me.rdByDeptName.UseVisualStyleBackColor = True
        '
        'rdByCode
        '
        resources.ApplyResources(Me.rdByCode, "rdByCode")
        Me.rdByCode.Checked = True
        Me.rdByCode.Name = "rdByCode"
        Me.rdByCode.TabStop = True
        Me.rdByCode.UseVisualStyleBackColor = True
        '
        'rdByDeptCode
        '
        resources.ApplyResources(Me.rdByDeptCode, "rdByDeptCode")
        Me.rdByDeptCode.Name = "rdByDeptCode"
        Me.rdByDeptCode.UseVisualStyleBackColor = True
        '
        'rdByName
        '
        resources.ApplyResources(Me.rdByName, "rdByName")
        Me.rdByName.Name = "rdByName"
        Me.rdByName.UseVisualStyleBackColor = True
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
        'grpRight
        '
        resources.ApplyResources(Me.grpRight, "grpRight")
        Me.grpRight.Controls.Add(Me.LabelControl4)
        Me.grpRight.Controls.Add(Me.LabelControl5)
        Me.grpRight.Controls.Add(Me.GcEmp_Cal)
        Me.grpRight.Controls.Add(Me.GroupControl7)
        Me.grpRight.Controls.Add(Me.btnRemove)
        Me.grpRight.Controls.Add(Me.cboDivision_Cal)
        Me.grpRight.Controls.Add(Me.btnRefresh_Cal)
        Me.grpRight.Controls.Add(Me.cboDepartment_Cal)
        Me.grpRight.Name = "grpRight"
        '
        'LabelControl4
        '
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Name = "LabelControl4"
        '
        'LabelControl5
        '
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Name = "LabelControl5"
        '
        'GcEmp_Cal
        '
        resources.ApplyResources(Me.GcEmp_Cal, "GcEmp_Cal")
        Me.GcEmp_Cal.EmbeddedNavigator.AccessibleDescription = resources.GetString("GcEmp_Cal.EmbeddedNavigator.AccessibleDescription")
        Me.GcEmp_Cal.EmbeddedNavigator.AccessibleName = resources.GetString("GcEmp_Cal.EmbeddedNavigator.AccessibleName")
        Me.GcEmp_Cal.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GcEmp_Cal.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GcEmp_Cal.EmbeddedNavigator.Anchor = CType(resources.GetObject("GcEmp_Cal.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GcEmp_Cal.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GcEmp_Cal.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GcEmp_Cal.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GcEmp_Cal.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GcEmp_Cal.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GcEmp_Cal.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GcEmp_Cal.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GcEmp_Cal.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GcEmp_Cal.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GcEmp_Cal.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GcEmp_Cal.EmbeddedNavigator.ToolTip = resources.GetString("GcEmp_Cal.EmbeddedNavigator.ToolTip")
        Me.GcEmp_Cal.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GcEmp_Cal.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GcEmp_Cal.EmbeddedNavigator.ToolTipTitle = resources.GetString("GcEmp_Cal.EmbeddedNavigator.ToolTipTitle")
        Me.GcEmp_Cal.MainView = Me.GvEmp_Cal
        Me.GcEmp_Cal.Name = "GcEmp_Cal"
        Me.GcEmp_Cal.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.GcEmp_Cal.TabStop = False
        Me.GcEmp_Cal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvEmp_Cal})
        '
        'GvEmp_Cal
        '
        Me.GvEmp_Cal.Appearance.HeaderPanel.Font = CType(resources.GetObject("GvEmp_Cal.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GvEmp_Cal.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GvEmp_Cal.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GvEmp_Cal.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GvEmp_Cal.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GvEmp_Cal.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GvEmp_Cal.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GvEmp_Cal.Appearance.HeaderPanel.Image = CType(resources.GetObject("GvEmp_Cal.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GvEmp_Cal.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvEmp_Cal.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GvEmp_Cal.Appearance.Row.FontSizeDelta"), Integer)
        Me.GvEmp_Cal.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GvEmp_Cal.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GvEmp_Cal.Appearance.Row.GradientMode = CType(resources.GetObject("GvEmp_Cal.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GvEmp_Cal.Appearance.Row.Image = CType(resources.GetObject("GvEmp_Cal.Appearance.Row.Image"), System.Drawing.Image)
        Me.GvEmp_Cal.Appearance.Row.Options.UseFont = True
        resources.ApplyResources(Me.GvEmp_Cal, "GvEmp_Cal")
        Me.GvEmp_Cal.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn9, Me.GridColumn6, Me.GridColumn5, Me.GridColumn7})
        Me.GvEmp_Cal.GridControl = Me.GcEmp_Cal
        Me.GvEmp_Cal.Name = "GvEmp_Cal"
        Me.GvEmp_Cal.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.GvEmp_Cal.OptionsSelection.MultiSelect = True
        Me.GvEmp_Cal.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GvEmp_Cal.OptionsView.ColumnAutoWidth = False
        Me.GvEmp_Cal.OptionsView.ShowAutoFilterRow = True
        Me.GvEmp_Cal.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GridColumn1.AppearanceCell.FontSizeDelta"), Integer)
        Me.GridColumn1.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GridColumn1.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridColumn1.AppearanceCell.GradientMode = CType(resources.GetObject("GridColumn1.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn1.AppearanceCell.Image = CType(resources.GetObject("GridColumn1.AppearanceCell.Image"), System.Drawing.Image)
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GridColumn1.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GridColumn1.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GridColumn1.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridColumn1.AppearanceHeader.GradientMode = CType(resources.GetObject("GridColumn1.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn1.AppearanceHeader.Image = CType(resources.GetObject("GridColumn1.AppearanceHeader.Image"), System.Drawing.Image)
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
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GridColumn9.AppearanceCell.FontSizeDelta"), Integer)
        Me.GridColumn9.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GridColumn9.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridColumn9.AppearanceCell.GradientMode = CType(resources.GetObject("GridColumn9.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn9.AppearanceCell.Image = CType(resources.GetObject("GridColumn9.AppearanceCell.Image"), System.Drawing.Image)
        Me.GridColumn9.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        resources.ApplyResources(Me.GridColumn9, "GridColumn9")
        Me.GridColumn9.DisplayFormat.FormatString = "n1"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "OTLimit"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowFocus = False
        '
        'GridColumn6
        '
        resources.ApplyResources(Me.GridColumn6, "GridColumn6")
        Me.GridColumn6.FieldName = "Division"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        '
        'GridColumn5
        '
        resources.ApplyResources(Me.GridColumn5, "GridColumn5")
        Me.GridColumn5.FieldName = "Department"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        '
        'GridColumn7
        '
        resources.ApplyResources(Me.GridColumn7, "GridColumn7")
        Me.GridColumn7.FieldName = "Position "
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemButtonEdit1
        '
        resources.ApplyResources(Me.RepositoryItemButtonEdit1, "RepositoryItemButtonEdit1")
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemButtonEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemButtonEdit1.Mask.AutoComplete = CType(resources.GetObject("RepositoryItemButtonEdit1.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.RepositoryItemButtonEdit1.Mask.BeepOnError = CType(resources.GetObject("RepositoryItemButtonEdit1.Mask.BeepOnError"), Boolean)
        Me.RepositoryItemButtonEdit1.Mask.EditMask = resources.GetString("RepositoryItemButtonEdit1.Mask.EditMask")
        Me.RepositoryItemButtonEdit1.Mask.IgnoreMaskBlank = CType(resources.GetObject("RepositoryItemButtonEdit1.Mask.IgnoreMaskBlank"), Boolean)
        Me.RepositoryItemButtonEdit1.Mask.MaskType = CType(resources.GetObject("RepositoryItemButtonEdit1.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.RepositoryItemButtonEdit1.Mask.PlaceHolder = CType(resources.GetObject("RepositoryItemButtonEdit1.Mask.PlaceHolder"), Char)
        Me.RepositoryItemButtonEdit1.Mask.SaveLiteral = CType(resources.GetObject("RepositoryItemButtonEdit1.Mask.SaveLiteral"), Boolean)
        Me.RepositoryItemButtonEdit1.Mask.ShowPlaceHolders = CType(resources.GetObject("RepositoryItemButtonEdit1.Mask.ShowPlaceHolders"), Boolean)
        Me.RepositoryItemButtonEdit1.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("RepositoryItemButtonEdit1.Mask.UseMaskAsDisplayFormat"), Boolean)
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
        'GroupControl7
        '
        resources.ApplyResources(Me.GroupControl7, "GroupControl7")
        Me.GroupControl7.Controls.Add(Me.rdByDeptName_Cal)
        Me.GroupControl7.Controls.Add(Me.rdByName_Cal)
        Me.GroupControl7.Controls.Add(Me.rdByDeptCode_Cal)
        Me.GroupControl7.Controls.Add(Me.rdByCode_Cal)
        Me.GroupControl7.Name = "GroupControl7"
        '
        'rdByDeptName_Cal
        '
        resources.ApplyResources(Me.rdByDeptName_Cal, "rdByDeptName_Cal")
        Me.rdByDeptName_Cal.Name = "rdByDeptName_Cal"
        Me.rdByDeptName_Cal.UseVisualStyleBackColor = True
        '
        'rdByName_Cal
        '
        resources.ApplyResources(Me.rdByName_Cal, "rdByName_Cal")
        Me.rdByName_Cal.Name = "rdByName_Cal"
        Me.rdByName_Cal.UseVisualStyleBackColor = True
        '
        'rdByDeptCode_Cal
        '
        resources.ApplyResources(Me.rdByDeptCode_Cal, "rdByDeptCode_Cal")
        Me.rdByDeptCode_Cal.Name = "rdByDeptCode_Cal"
        Me.rdByDeptCode_Cal.UseVisualStyleBackColor = True
        '
        'rdByCode_Cal
        '
        resources.ApplyResources(Me.rdByCode_Cal, "rdByCode_Cal")
        Me.rdByCode_Cal.Checked = True
        Me.rdByCode_Cal.Name = "rdByCode_Cal"
        Me.rdByCode_Cal.TabStop = True
        Me.rdByCode_Cal.UseVisualStyleBackColor = True
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
        'cboDivision_Cal
        '
        resources.ApplyResources(Me.cboDivision_Cal, "cboDivision_Cal")
        Me.cboDivision_Cal.Name = "cboDivision_Cal"
        Me.cboDivision_Cal.Properties.AccessibleDescription = resources.GetString("cboDivision_Cal.Properties.AccessibleDescription")
        Me.cboDivision_Cal.Properties.AccessibleName = resources.GetString("cboDivision_Cal.Properties.AccessibleName")
        Me.cboDivision_Cal.Properties.AutoHeight = CType(resources.GetObject("cboDivision_Cal.Properties.AutoHeight"), Boolean)
        Me.cboDivision_Cal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboDivision_Cal.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboDivision_Cal.Properties.DropDownRows = 15
        Me.cboDivision_Cal.Properties.NullValuePrompt = resources.GetString("cboDivision_Cal.Properties.NullValuePrompt")
        Me.cboDivision_Cal.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("cboDivision_Cal.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.cboDivision_Cal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'btnRefresh_Cal
        '
        resources.ApplyResources(Me.btnRefresh_Cal, "btnRefresh_Cal")
        Me.btnRefresh_Cal.Appearance.Font = CType(resources.GetObject("btnRefresh_Cal.Appearance.Font"), System.Drawing.Font)
        Me.btnRefresh_Cal.Appearance.FontSizeDelta = CType(resources.GetObject("btnRefresh_Cal.Appearance.FontSizeDelta"), Integer)
        Me.btnRefresh_Cal.Appearance.FontStyleDelta = CType(resources.GetObject("btnRefresh_Cal.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.btnRefresh_Cal.Appearance.GradientMode = CType(resources.GetObject("btnRefresh_Cal.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.btnRefresh_Cal.Appearance.Image = CType(resources.GetObject("btnRefresh_Cal.Appearance.Image"), System.Drawing.Image)
        Me.btnRefresh_Cal.Appearance.Options.UseFont = True
        Me.btnRefresh_Cal.ImageOptions.Image = CType(resources.GetObject("btnRefresh_Cal.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefresh_Cal.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnRefresh_Cal.Name = "btnRefresh_Cal"
        '
        'cboDepartment_Cal
        '
        resources.ApplyResources(Me.cboDepartment_Cal, "cboDepartment_Cal")
        Me.cboDepartment_Cal.Name = "cboDepartment_Cal"
        Me.cboDepartment_Cal.Properties.AccessibleDescription = resources.GetString("cboDepartment_Cal.Properties.AccessibleDescription")
        Me.cboDepartment_Cal.Properties.AccessibleName = resources.GetString("cboDepartment_Cal.Properties.AccessibleName")
        Me.cboDepartment_Cal.Properties.AutoHeight = CType(resources.GetObject("cboDepartment_Cal.Properties.AutoHeight"), Boolean)
        Me.cboDepartment_Cal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboDepartment_Cal.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboDepartment_Cal.Properties.DropDownRows = 15
        Me.cboDepartment_Cal.Properties.NullValuePrompt = resources.GetString("cboDepartment_Cal.Properties.NullValuePrompt")
        Me.cboDepartment_Cal.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("cboDepartment_Cal.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.cboDepartment_Cal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
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
        'frmLimitHourOT
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlApp)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.ProgressBarX1)
        Me.Name = "frmLimitHourOT"
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
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtLimitHourOT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRight.ResumeLayout(False)
        Me.grpRight.PerformLayout()
        CType(Me.GcEmp_Cal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvEmp_Cal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        Me.GroupControl7.PerformLayout()
        CType(Me.cboDivision_Cal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDepartment_Cal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlApp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rdByDeptName_Cal As System.Windows.Forms.RadioButton
    Friend WithEvents rdByDeptCode_Cal As System.Windows.Forms.RadioButton
    Friend WithEvents rdByName_Cal As System.Windows.Forms.RadioButton
    Friend WithEvents rdByCode_Cal As System.Windows.Forms.RadioButton
    Friend WithEvents rdByDeptName As System.Windows.Forms.RadioButton
    Friend WithEvents rdByDeptCode As System.Windows.Forms.RadioButton
    Friend WithEvents rdByName As System.Windows.Forms.RadioButton
    Friend WithEvents rdByCode As System.Windows.Forms.RadioButton
    Friend WithEvents btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProgressBarX1 As DevComponents.DotNetBar.Controls.ProgressBarX
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
    Friend WithEvents cboDivision_Cal As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboDepartment_Cal As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnRefresh_Cal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GcEmp_Cal As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvEmp_Cal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtLimitHourOT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlApp As Panel
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents grpLeft As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpRight As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
