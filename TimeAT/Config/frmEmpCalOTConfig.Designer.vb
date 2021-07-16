<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpCalOTConfig
    'Inherits System.Windows.Forms.Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpCalOTConfig))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.grpLeft = New DevExpress.XtraEditors.GroupControl()
        Me.GcEmp = New DevExpress.XtraGrid.GridControl()
        Me.GvEmp = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colempcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_department = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.cboDivision = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.rdByDeptName = New System.Windows.Forms.RadioButton()
        Me.rdByName = New System.Windows.Forms.RadioButton()
        Me.rdByDeptCode = New System.Windows.Forms.RadioButton()
        Me.rdByCode = New System.Windows.Forms.RadioButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.cboDepartment = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.grpRight = New DevExpress.XtraEditors.GroupControl()
        Me.cboOTType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.rdByDeptName_Date = New System.Windows.Forms.RadioButton()
        Me.rdByName_Date = New System.Windows.Forms.RadioButton()
        Me.rdByDeptCode_Date = New System.Windows.Forms.RadioButton()
        Me.rdByCode_Date = New System.Windows.Forms.RadioButton()
        Me.GcEmp_Cal = New DevExpress.XtraGrid.GridControl()
        Me.gvEmp_Cal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDivition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPosition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnRefresh_Cal = New DevExpress.XtraEditors.SimpleButton()
        Me.cboDepartment_Cal = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboDivision_Cal = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNameSearch_Cal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstEmp_Cal = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboCompany_Cal = New System.Windows.Forms.ComboBox()
        Me.cboEmpGroup_Cal = New System.Windows.Forms.ComboBox()
        Me.btnSelectAll_Date = New System.Windows.Forms.Button()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.btnNoneSelectAll_Date = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProgressBarX1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.pnlApp = New System.Windows.Forms.Panel()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.grpLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLeft.SuspendLayout()
        CType(Me.GcEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRight.SuspendLayout()
        CType(Me.cboOTType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GcEmp_Cal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvEmp_Cal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDepartment_Cal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDivision_Cal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainerControl1.SplitterPosition = 626
        '
        'grpLeft
        '
        resources.ApplyResources(Me.grpLeft, "grpLeft")
        Me.grpLeft.Controls.Add(Me.GcEmp)
        Me.grpLeft.Controls.Add(Me.btnRefresh)
        Me.grpLeft.Controls.Add(Me.cboDivision)
        Me.grpLeft.Controls.Add(Me.Label16)
        Me.grpLeft.Controls.Add(Me.Label14)
        Me.grpLeft.Controls.Add(Me.GroupControl3)
        Me.grpLeft.Controls.Add(Me.btnAdd)
        Me.grpLeft.Controls.Add(Me.cboDepartment)
        Me.grpLeft.Name = "grpLeft"
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
        Me.GvEmp.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colrow, Me.colempcode, Me.colProductName, Me.collname, Me.GridColumn6, Me.col_department, Me.GridColumn7})
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
        'GridColumn6
        '
        resources.ApplyResources(Me.GridColumn6, "GridColumn6")
        Me.GridColumn6.FieldName = "Division"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        '
        'col_department
        '
        resources.ApplyResources(Me.col_department, "col_department")
        Me.col_department.FieldName = "Department"
        Me.col_department.Name = "col_department"
        Me.col_department.OptionsColumn.AllowEdit = False
        '
        'GridColumn7
        '
        resources.ApplyResources(Me.GridColumn7, "GridColumn7")
        Me.GridColumn7.FieldName = "Position"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
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
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'GroupControl3
        '
        resources.ApplyResources(Me.GroupControl3, "GroupControl3")
        Me.GroupControl3.Controls.Add(Me.rdByDeptName)
        Me.GroupControl3.Controls.Add(Me.rdByName)
        Me.GroupControl3.Controls.Add(Me.rdByDeptCode)
        Me.GroupControl3.Controls.Add(Me.rdByCode)
        Me.GroupControl3.Name = "GroupControl3"
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
        'grpRight
        '
        resources.ApplyResources(Me.grpRight, "grpRight")
        Me.grpRight.Controls.Add(Me.cboOTType)
        Me.grpRight.Controls.Add(Me.Label17)
        Me.grpRight.Controls.Add(Me.GroupControl4)
        Me.grpRight.Controls.Add(Me.GcEmp_Cal)
        Me.grpRight.Controls.Add(Me.btnRefresh_Cal)
        Me.grpRight.Controls.Add(Me.cboDepartment_Cal)
        Me.grpRight.Controls.Add(Me.Label9)
        Me.grpRight.Controls.Add(Me.btnRemove)
        Me.grpRight.Controls.Add(Me.Label8)
        Me.grpRight.Controls.Add(Me.cboDivision_Cal)
        Me.grpRight.Controls.Add(Me.Label10)
        Me.grpRight.Name = "grpRight"
        '
        'cboOTType
        '
        resources.ApplyResources(Me.cboOTType, "cboOTType")
        Me.cboOTType.Name = "cboOTType"
        Me.cboOTType.Properties.AccessibleDescription = resources.GetString("cboOTType.Properties.AccessibleDescription")
        Me.cboOTType.Properties.AccessibleName = resources.GetString("cboOTType.Properties.AccessibleName")
        Me.cboOTType.Properties.AutoHeight = CType(resources.GetObject("cboOTType.Properties.AutoHeight"), Boolean)
        Me.cboOTType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboOTType.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboOTType.Properties.DropDownRows = 15
        Me.cboOTType.Properties.Items.AddRange(New Object() {resources.GetString("cboOTType.Properties.Items"), resources.GetString("cboOTType.Properties.Items1"), resources.GetString("cboOTType.Properties.Items2"), resources.GetString("cboOTType.Properties.Items3"), resources.GetString("cboOTType.Properties.Items4")})
        Me.cboOTType.Properties.NullValuePrompt = resources.GetString("cboOTType.Properties.NullValuePrompt")
        Me.cboOTType.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("cboOTType.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.cboOTType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.Name = "Label17"
        '
        'GroupControl4
        '
        resources.ApplyResources(Me.GroupControl4, "GroupControl4")
        Me.GroupControl4.Controls.Add(Me.rdByDeptName_Date)
        Me.GroupControl4.Controls.Add(Me.rdByName_Date)
        Me.GroupControl4.Controls.Add(Me.rdByDeptCode_Date)
        Me.GroupControl4.Controls.Add(Me.rdByCode_Date)
        Me.GroupControl4.Name = "GroupControl4"
        '
        'rdByDeptName_Date
        '
        resources.ApplyResources(Me.rdByDeptName_Date, "rdByDeptName_Date")
        Me.rdByDeptName_Date.Name = "rdByDeptName_Date"
        Me.rdByDeptName_Date.UseVisualStyleBackColor = True
        '
        'rdByName_Date
        '
        resources.ApplyResources(Me.rdByName_Date, "rdByName_Date")
        Me.rdByName_Date.Name = "rdByName_Date"
        Me.rdByName_Date.UseVisualStyleBackColor = True
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
        Me.GcEmp_Cal.MainView = Me.gvEmp_Cal
        Me.GcEmp_Cal.Name = "GcEmp_Cal"
        Me.GcEmp_Cal.TabStop = False
        Me.GcEmp_Cal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvEmp_Cal})
        '
        'gvEmp_Cal
        '
        Me.gvEmp_Cal.Appearance.HeaderPanel.Font = CType(resources.GetObject("gvEmp_Cal.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.gvEmp_Cal.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("gvEmp_Cal.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.gvEmp_Cal.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("gvEmp_Cal.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.gvEmp_Cal.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("gvEmp_Cal.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.gvEmp_Cal.Appearance.HeaderPanel.Image = CType(resources.GetObject("gvEmp_Cal.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.gvEmp_Cal.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvEmp_Cal.Appearance.Row.FontSizeDelta = CType(resources.GetObject("gvEmp_Cal.Appearance.Row.FontSizeDelta"), Integer)
        Me.gvEmp_Cal.Appearance.Row.FontStyleDelta = CType(resources.GetObject("gvEmp_Cal.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.gvEmp_Cal.Appearance.Row.GradientMode = CType(resources.GetObject("gvEmp_Cal.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.gvEmp_Cal.Appearance.Row.Image = CType(resources.GetObject("gvEmp_Cal.Appearance.Row.Image"), System.Drawing.Image)
        Me.gvEmp_Cal.Appearance.Row.Options.UseFont = True
        resources.ApplyResources(Me.gvEmp_Cal, "gvEmp_Cal")
        Me.gvEmp_Cal.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.colDivition, Me.GridColumn5, Me.colPosition})
        Me.gvEmp_Cal.GridControl = Me.GcEmp_Cal
        Me.gvEmp_Cal.Name = "gvEmp_Cal"
        Me.gvEmp_Cal.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.gvEmp_Cal.OptionsSelection.MultiSelect = True
        Me.gvEmp_Cal.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gvEmp_Cal.OptionsView.ColumnAutoWidth = False
        Me.gvEmp_Cal.OptionsView.ShowAutoFilterRow = True
        Me.gvEmp_Cal.OptionsView.ShowGroupPanel = False
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
        'colDivition
        '
        resources.ApplyResources(Me.colDivition, "colDivition")
        Me.colDivition.FieldName = "Division"
        Me.colDivition.Name = "colDivition"
        '
        'GridColumn5
        '
        resources.ApplyResources(Me.GridColumn5, "GridColumn5")
        Me.GridColumn5.FieldName = "Department"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        '
        'colPosition
        '
        resources.ApplyResources(Me.colPosition, "colPosition")
        Me.colPosition.FieldName = "Position"
        Me.colPosition.Name = "colPosition"
        Me.colPosition.OptionsColumn.AllowEdit = False
        Me.colPosition.OptionsColumn.ReadOnly = True
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
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
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
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
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
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'btnExit
        '
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.ImageOptions.Image = CType(resources.GetObject("btnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnExit.Name = "btnExit"
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
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'lstEmp_Cal
        '
        resources.ApplyResources(Me.lstEmp_Cal, "lstEmp_Cal")
        Me.lstEmp_Cal.CheckBoxes = True
        Me.lstEmp_Cal.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader8})
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
        'cboCompany_Cal
        '
        resources.ApplyResources(Me.cboCompany_Cal, "cboCompany_Cal")
        Me.cboCompany_Cal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompany_Cal.FormattingEnabled = True
        Me.cboCompany_Cal.Name = "cboCompany_Cal"
        '
        'cboEmpGroup_Cal
        '
        resources.ApplyResources(Me.cboEmpGroup_Cal, "cboEmpGroup_Cal")
        Me.cboEmpGroup_Cal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpGroup_Cal.FormattingEnabled = True
        Me.cboEmpGroup_Cal.Name = "cboEmpGroup_Cal"
        '
        'btnSelectAll_Date
        '
        resources.ApplyResources(Me.btnSelectAll_Date, "btnSelectAll_Date")
        Me.btnSelectAll_Date.Name = "btnSelectAll_Date"
        Me.btnSelectAll_Date.UseVisualStyleBackColor = True
        '
        'ProgressBar2
        '
        resources.ApplyResources(Me.ProgressBar2, "ProgressBar2")
        Me.ProgressBar2.ForeColor = System.Drawing.Color.Yellow
        Me.ProgressBar2.Name = "ProgressBar2"
        '
        'btnNoneSelectAll_Date
        '
        resources.ApplyResources(Me.btnNoneSelectAll_Date, "btnNoneSelectAll_Date")
        Me.btnNoneSelectAll_Date.Name = "btnNoneSelectAll_Date"
        Me.btnNoneSelectAll_Date.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Controls.Add(Me.btnNoneSelectAll_Date)
        Me.GroupBox2.Controls.Add(Me.ProgressBar2)
        Me.GroupBox2.Controls.Add(Me.btnSelectAll_Date)
        Me.GroupBox2.Controls.Add(Me.cboEmpGroup_Cal)
        Me.GroupBox2.Controls.Add(Me.cboCompany_Cal)
        Me.GroupBox2.Controls.Add(Me.lstEmp_Cal)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtNameSearch_Cal)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
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
        'frmEmpCalOTConfig
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlApp)
        Me.Controls.Add(Me.ProgressBarX1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmEmpCalOTConfig"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.grpLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLeft.ResumeLayout(False)
        CType(Me.GcEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRight.ResumeLayout(False)
        CType(Me.cboOTType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.GcEmp_Cal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvEmp_Cal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDepartment_Cal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDivision_Cal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnlApp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rdByDeptName As System.Windows.Forms.RadioButton
    Friend WithEvents rdByDeptCode As System.Windows.Forms.RadioButton
    Friend WithEvents rdByName As System.Windows.Forms.RadioButton
    Friend WithEvents rdByCode As System.Windows.Forms.RadioButton
    Friend WithEvents rdByDeptName_Date As System.Windows.Forms.RadioButton
    Friend WithEvents rdByDeptCode_Date As System.Windows.Forms.RadioButton
    Friend WithEvents rdByName_Date As System.Windows.Forms.RadioButton
    Friend WithEvents rdByCode_Date As System.Windows.Forms.RadioButton
    Friend WithEvents cboDepartment As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboDivision As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GcEmp As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvEmp As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colrow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colempcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_department As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GcEmp_Cal As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvEmp_Cal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDivition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPosition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnRefresh_Cal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboDepartment_Cal As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboOTType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label17 As Label
    Friend WithEvents cboDivision_Cal As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNameSearch_Cal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lstEmp_Cal As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents cboCompany_Cal As ComboBox
    Friend WithEvents cboEmpGroup_Cal As ComboBox
    Friend WithEvents btnSelectAll_Date As Button
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents btnNoneSelectAll_Date As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ProgressBarX1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents pnlApp As Panel
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents grpLeft As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpRight As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label9 As Label
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
End Class
