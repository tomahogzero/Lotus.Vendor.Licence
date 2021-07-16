<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpCalAbs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpCalAbs))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.grpLeft = New DevExpress.XtraEditors.GroupControl()
        Me.cboDivision = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.cboDepartment = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.rdByDeptName = New System.Windows.Forms.RadioButton()
        Me.rdByName = New System.Windows.Forms.RadioButton()
        Me.rdByDeptCode = New System.Windows.Forms.RadioButton()
        Me.rdByCode = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GcEmp = New DevExpress.XtraGrid.GridControl()
        Me.GvEmp = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colempcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_department = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cboTransport_detail = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboUnitName = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.grpRight = New DevExpress.XtraEditors.GroupControl()
        Me.cboDivision_Date = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboDepartment_Date = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GcEmpdate = New DevExpress.XtraGrid.GridControl()
        Me.GvEmpdate = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.rdByDeptName_Date = New System.Windows.Forms.RadioButton()
        Me.rdByDeptCode_Date = New System.Windows.Forms.RadioButton()
        Me.rdByCode_Date = New System.Windows.Forms.RadioButton()
        Me.rdByName_Date = New System.Windows.Forms.RadioButton()
        Me.btnRefresh_Date = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboCompany = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNoneSelectAll = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lstEmp = New System.Windows.Forms.ListView()
        Me.colNO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDepartment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNameSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboCompany_date = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnNoneSelectAll_Date = New System.Windows.Forms.Button()
        Me.btnSelectAll_Date = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lstEmp_Date = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNameSearch_Date = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.pnlApp = New System.Windows.Forms.Panel()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.grpLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLeft.SuspendLayout()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GcEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRight.SuspendLayout()
        CType(Me.cboDivision_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDepartment_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcEmpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvEmpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.grpLeft.Controls.Add(Me.cboDivision)
        Me.grpLeft.Controls.Add(Me.Label16)
        Me.grpLeft.Controls.Add(Me.btnAdd)
        Me.grpLeft.Controls.Add(Me.cboDepartment)
        Me.grpLeft.Controls.Add(Me.btnRefresh)
        Me.grpLeft.Controls.Add(Me.GroupControl1)
        Me.grpLeft.Controls.Add(Me.Label14)
        Me.grpLeft.Controls.Add(Me.GcEmp)
        Me.grpLeft.Name = "grpLeft"
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
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
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
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
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
        Me.GvEmp.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colrow, Me.colempcode, Me.colProductName, Me.collname, Me.GridColumn7, Me.col_department, Me.GridColumn6})
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
        'GridColumn7
        '
        resources.ApplyResources(Me.GridColumn7, "GridColumn7")
        Me.GridColumn7.FieldName = "Division"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        '
        'col_department
        '
        resources.ApplyResources(Me.col_department, "col_department")
        Me.col_department.FieldName = "Department"
        Me.col_department.Name = "col_department"
        Me.col_department.OptionsColumn.AllowEdit = False
        '
        'GridColumn6
        '
        resources.ApplyResources(Me.GridColumn6, "GridColumn6")
        Me.GridColumn6.FieldName = "Position"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
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
        'grpRight
        '
        resources.ApplyResources(Me.grpRight, "grpRight")
        Me.grpRight.Controls.Add(Me.cboDivision_Date)
        Me.grpRight.Controls.Add(Me.btnRemove)
        Me.grpRight.Controls.Add(Me.Label6)
        Me.grpRight.Controls.Add(Me.cboDepartment_Date)
        Me.grpRight.Controls.Add(Me.GcEmpdate)
        Me.grpRight.Controls.Add(Me.GroupControl3)
        Me.grpRight.Controls.Add(Me.btnRefresh_Date)
        Me.grpRight.Controls.Add(Me.Label5)
        Me.grpRight.Name = "grpRight"
        '
        'cboDivision_Date
        '
        resources.ApplyResources(Me.cboDivision_Date, "cboDivision_Date")
        Me.cboDivision_Date.Name = "cboDivision_Date"
        Me.cboDivision_Date.Properties.AccessibleDescription = resources.GetString("cboDivision_Date.Properties.AccessibleDescription")
        Me.cboDivision_Date.Properties.AccessibleName = resources.GetString("cboDivision_Date.Properties.AccessibleName")
        Me.cboDivision_Date.Properties.AutoHeight = CType(resources.GetObject("cboDivision_Date.Properties.AutoHeight"), Boolean)
        Me.cboDivision_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboDivision_Date.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboDivision_Date.Properties.DropDownRows = 15
        Me.cboDivision_Date.Properties.NullValuePrompt = resources.GetString("cboDivision_Date.Properties.NullValuePrompt")
        Me.cboDivision_Date.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("cboDivision_Date.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.cboDivision_Date.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
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
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'cboDepartment_Date
        '
        resources.ApplyResources(Me.cboDepartment_Date, "cboDepartment_Date")
        Me.cboDepartment_Date.Name = "cboDepartment_Date"
        Me.cboDepartment_Date.Properties.AccessibleDescription = resources.GetString("cboDepartment_Date.Properties.AccessibleDescription")
        Me.cboDepartment_Date.Properties.AccessibleName = resources.GetString("cboDepartment_Date.Properties.AccessibleName")
        Me.cboDepartment_Date.Properties.AutoHeight = CType(resources.GetObject("cboDepartment_Date.Properties.AutoHeight"), Boolean)
        Me.cboDepartment_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboDepartment_Date.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboDepartment_Date.Properties.DropDownRows = 15
        Me.cboDepartment_Date.Properties.NullValuePrompt = resources.GetString("cboDepartment_Date.Properties.NullValuePrompt")
        Me.cboDepartment_Date.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("cboDepartment_Date.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.cboDepartment_Date.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'GcEmpdate
        '
        resources.ApplyResources(Me.GcEmpdate, "GcEmpdate")
        Me.GcEmpdate.EmbeddedNavigator.AccessibleDescription = resources.GetString("GcEmpdate.EmbeddedNavigator.AccessibleDescription")
        Me.GcEmpdate.EmbeddedNavigator.AccessibleName = resources.GetString("GcEmpdate.EmbeddedNavigator.AccessibleName")
        Me.GcEmpdate.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GcEmpdate.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GcEmpdate.EmbeddedNavigator.Anchor = CType(resources.GetObject("GcEmpdate.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GcEmpdate.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GcEmpdate.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GcEmpdate.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GcEmpdate.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GcEmpdate.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GcEmpdate.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GcEmpdate.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GcEmpdate.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GcEmpdate.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GcEmpdate.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GcEmpdate.EmbeddedNavigator.ToolTip = resources.GetString("GcEmpdate.EmbeddedNavigator.ToolTip")
        Me.GcEmpdate.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GcEmpdate.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GcEmpdate.EmbeddedNavigator.ToolTipTitle = resources.GetString("GcEmpdate.EmbeddedNavigator.ToolTipTitle")
        Me.GcEmpdate.MainView = Me.GvEmpdate
        Me.GcEmpdate.Name = "GcEmpdate"
        Me.GcEmpdate.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.GcEmpdate.TabStop = False
        Me.GcEmpdate.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvEmpdate})
        '
        'GvEmpdate
        '
        Me.GvEmpdate.Appearance.HeaderPanel.Font = CType(resources.GetObject("GvEmpdate.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GvEmpdate.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GvEmpdate.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GvEmpdate.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GvEmpdate.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GvEmpdate.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GvEmpdate.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GvEmpdate.Appearance.HeaderPanel.Image = CType(resources.GetObject("GvEmpdate.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GvEmpdate.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvEmpdate.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GvEmpdate.Appearance.Row.FontSizeDelta"), Integer)
        Me.GvEmpdate.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GvEmpdate.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GvEmpdate.Appearance.Row.GradientMode = CType(resources.GetObject("GvEmpdate.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GvEmpdate.Appearance.Row.Image = CType(resources.GetObject("GvEmpdate.Appearance.Row.Image"), System.Drawing.Image)
        Me.GvEmpdate.Appearance.Row.Options.UseFont = True
        resources.ApplyResources(Me.GvEmpdate, "GvEmpdate")
        Me.GvEmpdate.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn8, Me.GridColumn5, Me.GridColumn9})
        Me.GvEmpdate.GridControl = Me.GcEmpdate
        Me.GvEmpdate.Name = "GvEmpdate"
        Me.GvEmpdate.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.GvEmpdate.OptionsSelection.MultiSelect = True
        Me.GvEmpdate.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GvEmpdate.OptionsView.ColumnAutoWidth = False
        Me.GvEmpdate.OptionsView.ShowAutoFilterRow = True
        Me.GvEmpdate.OptionsView.ShowGroupPanel = False
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
        'GridColumn8
        '
        resources.ApplyResources(Me.GridColumn8, "GridColumn8")
        Me.GridColumn8.FieldName = "Division"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        '
        'GridColumn5
        '
        resources.ApplyResources(Me.GridColumn5, "GridColumn5")
        Me.GridColumn5.FieldName = "Department"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        '
        'GridColumn9
        '
        resources.ApplyResources(Me.GridColumn9, "GridColumn9")
        Me.GridColumn9.FieldName = "Position"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.ReadOnly = True
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
        'GroupControl3
        '
        resources.ApplyResources(Me.GroupControl3, "GroupControl3")
        Me.GroupControl3.Controls.Add(Me.rdByDeptName_Date)
        Me.GroupControl3.Controls.Add(Me.rdByDeptCode_Date)
        Me.GroupControl3.Controls.Add(Me.rdByCode_Date)
        Me.GroupControl3.Controls.Add(Me.rdByName_Date)
        Me.GroupControl3.Name = "GroupControl3"
        '
        'rdByDeptName_Date
        '
        resources.ApplyResources(Me.rdByDeptName_Date, "rdByDeptName_Date")
        Me.rdByDeptName_Date.Name = "rdByDeptName_Date"
        Me.rdByDeptName_Date.UseVisualStyleBackColor = True
        '
        'rdByDeptCode_Date
        '
        resources.ApplyResources(Me.rdByDeptCode_Date, "rdByDeptCode_Date")
        Me.rdByDeptCode_Date.Name = "rdByDeptCode_Date"
        Me.rdByDeptCode_Date.UseVisualStyleBackColor = True
        '
        'rdByCode_Date
        '
        resources.ApplyResources(Me.rdByCode_Date, "rdByCode_Date")
        Me.rdByCode_Date.Checked = True
        Me.rdByCode_Date.Name = "rdByCode_Date"
        Me.rdByCode_Date.TabStop = True
        Me.rdByCode_Date.UseVisualStyleBackColor = True
        '
        'rdByName_Date
        '
        resources.ApplyResources(Me.rdByName_Date, "rdByName_Date")
        Me.rdByName_Date.Name = "rdByName_Date"
        Me.rdByName_Date.UseVisualStyleBackColor = True
        '
        'btnRefresh_Date
        '
        resources.ApplyResources(Me.btnRefresh_Date, "btnRefresh_Date")
        Me.btnRefresh_Date.Appearance.Font = CType(resources.GetObject("btnRefresh_Date.Appearance.Font"), System.Drawing.Font)
        Me.btnRefresh_Date.Appearance.FontSizeDelta = CType(resources.GetObject("btnRefresh_Date.Appearance.FontSizeDelta"), Integer)
        Me.btnRefresh_Date.Appearance.FontStyleDelta = CType(resources.GetObject("btnRefresh_Date.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.btnRefresh_Date.Appearance.GradientMode = CType(resources.GetObject("btnRefresh_Date.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.btnRefresh_Date.Appearance.Image = CType(resources.GetObject("btnRefresh_Date.Appearance.Image"), System.Drawing.Image)
        Me.btnRefresh_Date.Appearance.Options.UseFont = True
        Me.btnRefresh_Date.ImageOptions.Image = CType(resources.GetObject("btnRefresh_Date.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefresh_Date.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnRefresh_Date.Name = "btnRefresh_Date"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.cboCompany)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnNoneSelectAll)
        Me.GroupBox1.Controls.Add(Me.btnSelectAll)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.lstEmp)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtNameSearch)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'cboCompany
        '
        resources.ApplyResources(Me.cboCompany, "cboCompany")
        Me.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompany.FormattingEnabled = True
        Me.cboCompany.Name = "cboCompany"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'btnNoneSelectAll
        '
        resources.ApplyResources(Me.btnNoneSelectAll, "btnNoneSelectAll")
        Me.btnNoneSelectAll.Name = "btnNoneSelectAll"
        Me.btnNoneSelectAll.UseVisualStyleBackColor = True
        '
        'btnSelectAll
        '
        resources.ApplyResources(Me.btnSelectAll, "btnSelectAll")
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'lstEmp
        '
        resources.ApplyResources(Me.lstEmp, "lstEmp")
        Me.lstEmp.CheckBoxes = True
        Me.lstEmp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNO, Me.colCode, Me.colName, Me.colSName, Me.colDepartment})
        Me.lstEmp.FullRowSelect = True
        Me.lstEmp.GridLines = True
        Me.lstEmp.Name = "lstEmp"
        Me.lstEmp.UseCompatibleStateImageBehavior = False
        Me.lstEmp.View = System.Windows.Forms.View.Details
        '
        'colNO
        '
        resources.ApplyResources(Me.colNO, "colNO")
        '
        'colCode
        '
        resources.ApplyResources(Me.colCode, "colCode")
        '
        'colName
        '
        resources.ApplyResources(Me.colName, "colName")
        '
        'colSName
        '
        resources.ApplyResources(Me.colSName, "colSName")
        '
        'colDepartment
        '
        resources.ApplyResources(Me.colDepartment, "colDepartment")
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'txtNameSearch
        '
        resources.ApplyResources(Me.txtNameSearch, "txtNameSearch")
        Me.txtNameSearch.Name = "txtNameSearch"
        '
        'GroupBox2
        '
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Controls.Add(Me.cboCompany_date)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnNoneSelectAll_Date)
        Me.GroupBox2.Controls.Add(Me.btnSelectAll_Date)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.lstEmp_Date)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtNameSearch_Date)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'cboCompany_date
        '
        resources.ApplyResources(Me.cboCompany_date, "cboCompany_date")
        Me.cboCompany_date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompany_date.FormattingEnabled = True
        Me.cboCompany_date.Name = "cboCompany_date"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'btnNoneSelectAll_Date
        '
        resources.ApplyResources(Me.btnNoneSelectAll_Date, "btnNoneSelectAll_Date")
        Me.btnNoneSelectAll_Date.Name = "btnNoneSelectAll_Date"
        Me.btnNoneSelectAll_Date.UseVisualStyleBackColor = True
        '
        'btnSelectAll_Date
        '
        resources.ApplyResources(Me.btnSelectAll_Date, "btnSelectAll_Date")
        Me.btnSelectAll_Date.Name = "btnSelectAll_Date"
        Me.btnSelectAll_Date.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'lstEmp_Date
        '
        resources.ApplyResources(Me.lstEmp_Date, "lstEmp_Date")
        Me.lstEmp_Date.CheckBoxes = True
        Me.lstEmp_Date.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lstEmp_Date.FullRowSelect = True
        Me.lstEmp_Date.GridLines = True
        Me.lstEmp_Date.Name = "lstEmp_Date"
        Me.lstEmp_Date.UseCompatibleStateImageBehavior = False
        Me.lstEmp_Date.View = System.Windows.Forms.View.Details
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
        'ColumnHeader5
        '
        resources.ApplyResources(Me.ColumnHeader5, "ColumnHeader5")
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txtNameSearch_Date
        '
        resources.ApplyResources(Me.txtNameSearch_Date, "txtNameSearch_Date")
        Me.txtNameSearch_Date.Name = "txtNameSearch_Date"
        '
        'ProgressBar1
        '
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        '
        '
        '
        Me.ProgressBar1.BackgroundStyle.Class = ""
        Me.ProgressBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.TextVisible = True
        '
        'btnExit
        '
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.ImageOptions.Image = CType(resources.GetObject("btnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnExit.Name = "btnExit"
        '
        'pnlApp
        '
        resources.ApplyResources(Me.pnlApp, "pnlApp")
        Me.pnlApp.Controls.Add(Me.SplitContainerControl1)
        Me.pnlApp.Name = "pnlApp"
        '
        'frmEmpCalAbs
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlApp)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmEmpCalAbs"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.grpLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLeft.ResumeLayout(False)
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GcEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRight.ResumeLayout(False)
        CType(Me.cboDivision_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDepartment_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcEmpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvEmpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnlApp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNoneSelectAll As System.Windows.Forms.Button
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdByDeptName As System.Windows.Forms.RadioButton
    Friend WithEvents rdByDeptCode As System.Windows.Forms.RadioButton
    Friend WithEvents rdByName As System.Windows.Forms.RadioButton
    Friend WithEvents rdByCode As System.Windows.Forms.RadioButton
    Friend WithEvents lstEmp As System.Windows.Forms.ListView
    Friend WithEvents colNO As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDepartment As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNameSearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNoneSelectAll_Date As System.Windows.Forms.Button
    Friend WithEvents btnSelectAll_Date As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdByDeptName_Date As System.Windows.Forms.RadioButton
    Friend WithEvents rdByDeptCode_Date As System.Windows.Forms.RadioButton
    Friend WithEvents rdByName_Date As System.Windows.Forms.RadioButton
    Friend WithEvents rdByCode_Date As System.Windows.Forms.RadioButton
    Friend WithEvents lstEmp_Date As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNameSearch_Date As System.Windows.Forms.TextBox
    Friend WithEvents cboCompany As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboCompany_date As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As DevComponents.DotNetBar.Controls.ProgressBarX
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
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label14 As Label
    Friend WithEvents cboDepartment As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents grpLeft As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GcEmpdate As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvEmpdate As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnRefresh_Date As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As Label
    Friend WithEvents cboDepartment_Date As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents grpRight As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboDivision As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label16 As Label
    Friend WithEvents cboDivision_Date As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlApp As Panel
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
End Class
