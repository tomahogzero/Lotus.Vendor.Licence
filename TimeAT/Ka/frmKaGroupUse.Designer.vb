<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKaGroupUse
    '  Inherits System.Windows.Forms.Form
    Inherits DevExpress.XtraEditors.XtraForm
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKaGroupUse))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.grpLeft = New DevExpress.XtraEditors.GroupControl()
        Me.GcEmp = New DevExpress.XtraGrid.GridControl()
        Me.GvEmp = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colempcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLDivision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_department = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLPosition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cboTransport_detail = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboUnitName = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboDivision = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.rdByDeptName = New System.Windows.Forms.RadioButton()
        Me.rdByCode = New System.Windows.Forms.RadioButton()
        Me.rdByDeptCode = New System.Windows.Forms.RadioButton()
        Me.rdByName = New System.Windows.Forms.RadioButton()
        Me.cboDepartment = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.grpRight = New DevExpress.XtraEditors.GroupControl()
        Me.cboDivision_Cal = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GcEmp_Cal = New DevExpress.XtraGrid.GridControl()
        Me.GvEmp_Cal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.rdByDeptName_Cal = New System.Windows.Forms.RadioButton()
        Me.rdByName_Cal = New System.Windows.Forms.RadioButton()
        Me.rdByDeptCode_Cal = New System.Windows.Forms.RadioButton()
        Me.rdByCode_Cal = New System.Windows.Forms.RadioButton()
        Me.cboDepartment_Cal = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnRefresh_Cal = New DevExpress.XtraEditors.SimpleButton()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstEmp = New System.Windows.Forms.ListView()
        Me.colNO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDepartment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.btnNoneSelectAll = New System.Windows.Forms.Button()
        Me.cboEmpGroup = New System.Windows.Forms.ComboBox()
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNameSearch = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboCompany = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboCompany_Cal = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstEmp_Cal = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboEmpGroup_Cal = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSelectAll_Cal = New System.Windows.Forms.Button()
        Me.btnNoneSelectAll_Cal = New System.Windows.Forms.Button()
        Me.ExpandablePanel2 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNameSearch_Cal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
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
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRight.SuspendLayout()
        CType(Me.cboDivision_Cal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcEmp_Cal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvEmp_Cal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.cboDepartment_Cal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ExpandablePanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ExpandablePanel2.SuspendLayout()
        Me.pnlApp.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        resources.ApplyResources(Me.SplitContainerControl1, "SplitContainerControl1")
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.grpLeft)
        resources.ApplyResources(Me.SplitContainerControl1.Panel1, "SplitContainerControl1.Panel1")
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.grpRight)
        resources.ApplyResources(Me.SplitContainerControl1.Panel2, "SplitContainerControl1.Panel2")
        Me.SplitContainerControl1.SplitterPosition = 701
        '
        'grpLeft
        '
        resources.ApplyResources(Me.grpLeft, "grpLeft")
        Me.grpLeft.Controls.Add(Me.GcEmp)
        Me.grpLeft.Controls.Add(Me.cboDivision)
        Me.grpLeft.Controls.Add(Me.btnAdd)
        Me.grpLeft.Controls.Add(Me.Label16)
        Me.grpLeft.Controls.Add(Me.GroupControl1)
        Me.grpLeft.Controls.Add(Me.cboDepartment)
        Me.grpLeft.Controls.Add(Me.btnRefresh)
        Me.grpLeft.Controls.Add(Me.Label17)
        Me.grpLeft.Name = "grpLeft"
        '
        'GcEmp
        '
        resources.ApplyResources(Me.GcEmp, "GcEmp")
        Me.GcEmp.MainView = Me.GvEmp
        Me.GcEmp.Name = "GcEmp"
        Me.GcEmp.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.BtnDel, Me.cboTransport_detail, Me.cboUnitName})
        Me.GcEmp.TabStop = False
        Me.GcEmp.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvEmp})
        '
        'GvEmp
        '
        Me.GvEmp.Appearance.HeaderPanel.Font = CType(resources.GetObject("GvEmp.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GvEmp.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvEmp.Appearance.Row.Options.UseFont = True
        Me.GvEmp.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colrow, Me.colempcode, Me.colProductName, Me.collname, Me.colLDivision, Me.col_department, Me.colLPosition})
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
        'colempcode
        '
        Me.colempcode.AppearanceCell.Options.UseTextOptions = True
        Me.colempcode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
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
        'colLDivision
        '
        resources.ApplyResources(Me.colLDivision, "colLDivision")
        Me.colLDivision.FieldName = "Division"
        Me.colLDivision.Name = "colLDivision"
        Me.colLDivision.OptionsColumn.AllowEdit = False
        Me.colLDivision.OptionsColumn.ReadOnly = True
        '
        'col_department
        '
        resources.ApplyResources(Me.col_department, "col_department")
        Me.col_department.FieldName = "Department"
        Me.col_department.Name = "col_department"
        Me.col_department.OptionsColumn.AllowEdit = False
        '
        'colLPosition
        '
        resources.ApplyResources(Me.colLPosition, "colLPosition")
        Me.colLPosition.FieldName = "Position"
        Me.colLPosition.Name = "colLPosition"
        Me.colLPosition.OptionsColumn.AllowEdit = False
        Me.colLPosition.OptionsColumn.ReadOnly = True
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
        'cboDivision
        '
        resources.ApplyResources(Me.cboDivision, "cboDivision")
        Me.cboDivision.Name = "cboDivision"
        Me.cboDivision.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboDivision.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboDivision.Properties.DropDownRows = 15
        Me.cboDivision.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'btnAdd
        '
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        Me.btnAdd.Appearance.Font = CType(resources.GetObject("btnAdd.Appearance.Font"), System.Drawing.Font)
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("btnAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnAdd.Name = "btnAdd"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.rdByDeptName)
        Me.GroupControl1.Controls.Add(Me.rdByCode)
        Me.GroupControl1.Controls.Add(Me.rdByDeptCode)
        Me.GroupControl1.Controls.Add(Me.rdByName)
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
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
        'cboDepartment
        '
        resources.ApplyResources(Me.cboDepartment, "cboDepartment")
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboDepartment.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboDepartment.Properties.DropDownRows = 15
        Me.cboDepartment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = CType(resources.GetObject("btnRefresh.Appearance.Font"), System.Drawing.Font)
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.ImageOptions.Image = CType(resources.GetObject("btnRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnRefresh, "btnRefresh")
        Me.btnRefresh.Name = "btnRefresh"
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.Name = "Label17"
        '
        'grpRight
        '
        resources.ApplyResources(Me.grpRight, "grpRight")
        Me.grpRight.Controls.Add(Me.cboDivision_Cal)
        Me.grpRight.Controls.Add(Me.GcEmp_Cal)
        Me.grpRight.Controls.Add(Me.Label18)
        Me.grpRight.Controls.Add(Me.btnRemove)
        Me.grpRight.Controls.Add(Me.GroupControl7)
        Me.grpRight.Controls.Add(Me.cboDepartment_Cal)
        Me.grpRight.Controls.Add(Me.btnRefresh_Cal)
        Me.grpRight.Controls.Add(Me.Label20)
        Me.grpRight.Name = "grpRight"
        '
        'cboDivision_Cal
        '
        resources.ApplyResources(Me.cboDivision_Cal, "cboDivision_Cal")
        Me.cboDivision_Cal.Name = "cboDivision_Cal"
        Me.cboDivision_Cal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboDivision_Cal.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboDivision_Cal.Properties.DropDownRows = 15
        Me.cboDivision_Cal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'GcEmp_Cal
        '
        resources.ApplyResources(Me.GcEmp_Cal, "GcEmp_Cal")
        Me.GcEmp_Cal.MainView = Me.GvEmp_Cal
        Me.GcEmp_Cal.Name = "GcEmp_Cal"
        Me.GcEmp_Cal.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.GcEmp_Cal.TabStop = False
        Me.GcEmp_Cal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvEmp_Cal})
        '
        'GvEmp_Cal
        '
        Me.GvEmp_Cal.Appearance.HeaderPanel.Font = CType(resources.GetObject("GvEmp_Cal.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GvEmp_Cal.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvEmp_Cal.Appearance.Row.Options.UseFont = True
        Me.GvEmp_Cal.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn6, Me.GridColumn5, Me.GridColumn7})
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
        'GridColumn6
        '
        resources.ApplyResources(Me.GridColumn6, "GridColumn6")
        Me.GridColumn6.FieldName = "Division"
        Me.GridColumn6.Name = "GridColumn6"
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
        Me.GridColumn7.FieldName = "Position"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
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
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.Name = "Label18"
        '
        'btnRemove
        '
        resources.ApplyResources(Me.btnRemove, "btnRemove")
        Me.btnRemove.Appearance.Font = CType(resources.GetObject("btnRemove.Appearance.Font"), System.Drawing.Font)
        Me.btnRemove.Appearance.Options.UseFont = True
        Me.btnRemove.ImageOptions.Image = CType(resources.GetObject("btnRemove.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRemove.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnRemove.Name = "btnRemove"
        '
        'GroupControl7
        '
        Me.GroupControl7.Controls.Add(Me.rdByDeptName_Cal)
        Me.GroupControl7.Controls.Add(Me.rdByName_Cal)
        Me.GroupControl7.Controls.Add(Me.rdByDeptCode_Cal)
        Me.GroupControl7.Controls.Add(Me.rdByCode_Cal)
        resources.ApplyResources(Me.GroupControl7, "GroupControl7")
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
        'cboDepartment_Cal
        '
        resources.ApplyResources(Me.cboDepartment_Cal, "cboDepartment_Cal")
        Me.cboDepartment_Cal.Name = "cboDepartment_Cal"
        Me.cboDepartment_Cal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboDepartment_Cal.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboDepartment_Cal.Properties.DropDownRows = 15
        Me.cboDepartment_Cal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'btnRefresh_Cal
        '
        Me.btnRefresh_Cal.Appearance.Font = CType(resources.GetObject("btnRefresh_Cal.Appearance.Font"), System.Drawing.Font)
        Me.btnRefresh_Cal.Appearance.Options.UseFont = True
        Me.btnRefresh_Cal.ImageOptions.Image = CType(resources.GetObject("btnRefresh_Cal.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefresh_Cal.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnRefresh_Cal, "btnRefresh_Cal")
        Me.btnRefresh_Cal.Name = "btnRefresh_Cal"
        '
        'Label20
        '
        resources.ApplyResources(Me.Label20, "Label20")
        Me.Label20.Name = "Label20"
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.lstEmp)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.cboEmpGroup)
        Me.GroupBox1.Controls.Add(Me.ExpandablePanel1)
        Me.GroupBox1.Controls.Add(Me.cboCompany)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'lstEmp
        '
        Me.lstEmp.CheckBoxes = True
        Me.lstEmp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNO, Me.colCode, Me.colName, Me.colSName, Me.colDepartment})
        resources.ApplyResources(Me.lstEmp, "lstEmp")
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSelectAll)
        Me.Panel1.Controls.Add(Me.btnNoneSelectAll)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'btnSelectAll
        '
        resources.ApplyResources(Me.btnSelectAll, "btnSelectAll")
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'btnNoneSelectAll
        '
        resources.ApplyResources(Me.btnNoneSelectAll, "btnNoneSelectAll")
        Me.btnNoneSelectAll.Name = "btnNoneSelectAll"
        Me.btnNoneSelectAll.UseVisualStyleBackColor = True
        '
        'cboEmpGroup
        '
        Me.cboEmpGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpGroup.FormattingEnabled = True
        resources.ApplyResources(Me.cboEmpGroup, "cboEmpGroup")
        Me.cboEmpGroup.Name = "cboEmpGroup"
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ExpandablePanel1.Controls.Add(Me.ProgressBar1)
        Me.ExpandablePanel1.Controls.Add(Me.GroupBox5)
        Me.ExpandablePanel1.Controls.Add(Me.Label7)
        Me.ExpandablePanel1.Controls.Add(Me.Label8)
        Me.ExpandablePanel1.Controls.Add(Me.txtNameSearch)
        Me.ExpandablePanel1.Controls.Add(Me.Label9)
        Me.ExpandablePanel1.Controls.Add(Me.GroupBox3)
        Me.ExpandablePanel1.Controls.Add(Me.Label10)
        resources.ApplyResources(Me.ExpandablePanel1, "ExpandablePanel1")
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.Style.BackColor2.Color = System.Drawing.Color.Transparent
        Me.ExpandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        '
        'ProgressBar1
        '
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        Me.ProgressBar1.Name = "ProgressBar1"
        '
        'GroupBox5
        '
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
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
        'txtNameSearch
        '
        resources.ApplyResources(Me.txtNameSearch, "txtNameSearch")
        Me.txtNameSearch.Name = "txtNameSearch"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'GroupBox3
        '
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'cboCompany
        '
        Me.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompany.FormattingEnabled = True
        resources.ApplyResources(Me.cboCompany, "cboCompany")
        Me.cboCompany.Name = "cboCompany"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'GroupBox2
        '
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Controls.Add(Me.cboCompany_Cal)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lstEmp_Cal)
        Me.GroupBox2.Controls.Add(Me.cboEmpGroup_Cal)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.ExpandablePanel2)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'cboCompany_Cal
        '
        resources.ApplyResources(Me.cboCompany_Cal, "cboCompany_Cal")
        Me.cboCompany_Cal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompany_Cal.FormattingEnabled = True
        Me.cboCompany_Cal.Name = "cboCompany_Cal"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'lstEmp_Cal
        '
        Me.lstEmp_Cal.CheckBoxes = True
        Me.lstEmp_Cal.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader8})
        resources.ApplyResources(Me.lstEmp_Cal, "lstEmp_Cal")
        Me.lstEmp_Cal.FullRowSelect = True
        Me.lstEmp_Cal.GridLines = True
        Me.lstEmp_Cal.Name = "lstEmp_Cal"
        Me.lstEmp_Cal.UseCompatibleStateImageBehavior = False
        Me.lstEmp_Cal.View = System.Windows.Forms.View.Details
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
        'ColumnHeader6
        '
        resources.ApplyResources(Me.ColumnHeader6, "ColumnHeader6")
        '
        'ColumnHeader5
        '
        resources.ApplyResources(Me.ColumnHeader5, "ColumnHeader5")
        '
        'ColumnHeader7
        '
        resources.ApplyResources(Me.ColumnHeader7, "ColumnHeader7")
        '
        'ColumnHeader8
        '
        resources.ApplyResources(Me.ColumnHeader8, "ColumnHeader8")
        '
        'cboEmpGroup_Cal
        '
        resources.ApplyResources(Me.cboEmpGroup_Cal, "cboEmpGroup_Cal")
        Me.cboEmpGroup_Cal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpGroup_Cal.FormattingEnabled = True
        Me.cboEmpGroup_Cal.Name = "cboEmpGroup_Cal"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnSelectAll_Cal)
        Me.Panel2.Controls.Add(Me.btnNoneSelectAll_Cal)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'btnSelectAll_Cal
        '
        resources.ApplyResources(Me.btnSelectAll_Cal, "btnSelectAll_Cal")
        Me.btnSelectAll_Cal.Name = "btnSelectAll_Cal"
        Me.btnSelectAll_Cal.UseVisualStyleBackColor = True
        '
        'btnNoneSelectAll_Cal
        '
        resources.ApplyResources(Me.btnNoneSelectAll_Cal, "btnNoneSelectAll_Cal")
        Me.btnNoneSelectAll_Cal.Name = "btnNoneSelectAll_Cal"
        Me.btnNoneSelectAll_Cal.UseVisualStyleBackColor = True
        '
        'ExpandablePanel2
        '
        Me.ExpandablePanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ExpandablePanel2.Controls.Add(Me.GroupBox4)
        Me.ExpandablePanel2.Controls.Add(Me.ProgressBar2)
        Me.ExpandablePanel2.Controls.Add(Me.GroupBox6)
        Me.ExpandablePanel2.Controls.Add(Me.Label1)
        Me.ExpandablePanel2.Controls.Add(Me.Label12)
        Me.ExpandablePanel2.Controls.Add(Me.txtNameSearch_Cal)
        Me.ExpandablePanel2.Controls.Add(Me.Label11)
        Me.ExpandablePanel2.Controls.Add(Me.Label2)
        resources.ApplyResources(Me.ExpandablePanel2, "ExpandablePanel2")
        Me.ExpandablePanel2.Name = "ExpandablePanel2"
        Me.ExpandablePanel2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel2.Style.BackColor2.Color = System.Drawing.Color.Transparent
        Me.ExpandablePanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel2.Style.GradientAngle = 90
        Me.ExpandablePanel2.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel2.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel2.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel2.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel2.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel2.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel2.TitleStyle.GradientAngle = 90
        '
        'GroupBox4
        '
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'ProgressBar2
        '
        resources.ApplyResources(Me.ProgressBar2, "ProgressBar2")
        Me.ProgressBar2.Name = "ProgressBar2"
        '
        'GroupBox6
        '
        resources.ApplyResources(Me.GroupBox6, "GroupBox6")
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'txtNameSearch_Cal
        '
        resources.ApplyResources(Me.txtNameSearch_Cal, "txtNameSearch_Cal")
        Me.txtNameSearch_Cal.Name = "txtNameSearch_Cal"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'btnExit
        '
        Me.btnExit.ImageOptions.Image = CType(resources.GetObject("btnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnExit, "btnExit")
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
        'frmKaGroupUse
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlApp)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.ProgressBarX1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmKaGroupUse"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.grpLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLeft.ResumeLayout(False)
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
        CType(Me.grpRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRight.ResumeLayout(False)
        CType(Me.cboDivision_Cal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcEmp_Cal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvEmp_Cal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        Me.GroupControl7.PerformLayout()
        CType(Me.cboDepartment_Cal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ExpandablePanel1.ResumeLayout(False)
        Me.ExpandablePanel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ExpandablePanel2.ResumeLayout(False)
        Me.ExpandablePanel2.PerformLayout()
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
    Friend WithEvents btnNoneSelectAll_Cal As System.Windows.Forms.Button
    Friend WithEvents btnSelectAll_Cal As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNameSearch_Cal As System.Windows.Forms.TextBox
    Friend WithEvents cboCompany As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboCompany_Cal As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cboEmpGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ExpandablePanel2 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cboEmpGroup_Cal As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents lstEmp_Cal As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdByDeptName_Cal As System.Windows.Forms.RadioButton
    Friend WithEvents rdByDeptCode_Cal As System.Windows.Forms.RadioButton
    Friend WithEvents rdByName_Cal As System.Windows.Forms.RadioButton
    Friend WithEvents rdByCode_Cal As System.Windows.Forms.RadioButton
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProgressBarX1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents cboDivision As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label16 As Label
    Friend WithEvents cboDepartment As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label17 As Label
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
    Friend WithEvents cboDivision_Cal As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label18 As Label
    Friend WithEvents cboDepartment_Cal As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label20 As Label
    Friend WithEvents btnRefresh_Cal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GcEmp_Cal As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvEmp_Cal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colLDivision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLPosition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlApp As Panel
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents grpLeft As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpRight As DevExpress.XtraEditors.GroupControl
End Class
