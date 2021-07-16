<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHolidayYear_New
    '  Inherits System.Windows.Forms.Form
    Inherits DevExpress.XtraEditors.XtraForm
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHolidayYear_New))
        Me.rdAll = New System.Windows.Forms.RadioButton()
        Me.rdYear = New System.Windows.Forms.RadioButton()
        Me.lstHoliday = New System.Windows.Forms.ListView()
        Me.colNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRemark = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GcHoliday = New DevExpress.XtraGrid.GridControl()
        Me.GvHoliday = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldateyear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldaystop = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colremarkyear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cboTransport_detail = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboUnitName = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtyear = New DevExpress.XtraEditors.TextEdit()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.txtRemark = New DevExpress.XtraEditors.TextEdit()
        Me.txtDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GcHoliday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvHoliday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtyear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdAll
        '
        resources.ApplyResources(Me.rdAll, "rdAll")
        Me.rdAll.Checked = True
        Me.rdAll.Name = "rdAll"
        Me.rdAll.TabStop = True
        Me.rdAll.UseVisualStyleBackColor = True
        '
        'rdYear
        '
        resources.ApplyResources(Me.rdYear, "rdYear")
        Me.rdYear.Name = "rdYear"
        Me.rdYear.UseVisualStyleBackColor = True
        '
        'lstHoliday
        '
        resources.ApplyResources(Me.lstHoliday, "lstHoliday")
        Me.lstHoliday.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNo, Me.colDate, Me.colDescription, Me.colRemark})
        Me.lstHoliday.FullRowSelect = True
        Me.lstHoliday.Name = "lstHoliday"
        Me.lstHoliday.UseCompatibleStateImageBehavior = False
        Me.lstHoliday.View = System.Windows.Forms.View.Details
        '
        'colNo
        '
        resources.ApplyResources(Me.colNo, "colNo")
        '
        'colDate
        '
        resources.ApplyResources(Me.colDate, "colDate")
        '
        'colDescription
        '
        resources.ApplyResources(Me.colDescription, "colDescription")
        '
        'colRemark
        '
        resources.ApplyResources(Me.colRemark, "colRemark")
        '
        'GcHoliday
        '
        resources.ApplyResources(Me.GcHoliday, "GcHoliday")
        Me.GcHoliday.EmbeddedNavigator.AccessibleDescription = resources.GetString("GcHoliday.EmbeddedNavigator.AccessibleDescription")
        Me.GcHoliday.EmbeddedNavigator.AccessibleName = resources.GetString("GcHoliday.EmbeddedNavigator.AccessibleName")
        Me.GcHoliday.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GcHoliday.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GcHoliday.EmbeddedNavigator.Anchor = CType(resources.GetObject("GcHoliday.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GcHoliday.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GcHoliday.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GcHoliday.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GcHoliday.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GcHoliday.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GcHoliday.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GcHoliday.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GcHoliday.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GcHoliday.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GcHoliday.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GcHoliday.EmbeddedNavigator.ToolTip = resources.GetString("GcHoliday.EmbeddedNavigator.ToolTip")
        Me.GcHoliday.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GcHoliday.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GcHoliday.EmbeddedNavigator.ToolTipTitle = resources.GetString("GcHoliday.EmbeddedNavigator.ToolTipTitle")
        Me.GcHoliday.MainView = Me.GvHoliday
        Me.GcHoliday.Name = "GcHoliday"
        Me.GcHoliday.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.BtnDel, Me.cboTransport_detail, Me.cboUnitName})
        Me.GcHoliday.TabStop = False
        Me.GcHoliday.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvHoliday})
        '
        'GvHoliday
        '
        Me.GvHoliday.Appearance.HeaderPanel.Font = CType(resources.GetObject("GvHoliday.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GvHoliday.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GvHoliday.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GvHoliday.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GvHoliday.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GvHoliday.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GvHoliday.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GvHoliday.Appearance.HeaderPanel.Image = CType(resources.GetObject("GvHoliday.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GvHoliday.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvHoliday.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GvHoliday.Appearance.Row.FontSizeDelta"), Integer)
        Me.GvHoliday.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GvHoliday.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GvHoliday.Appearance.Row.GradientMode = CType(resources.GetObject("GvHoliday.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GvHoliday.Appearance.Row.Image = CType(resources.GetObject("GvHoliday.Appearance.Row.Image"), System.Drawing.Image)
        Me.GvHoliday.Appearance.Row.Options.UseFont = True
        resources.ApplyResources(Me.GvHoliday, "GvHoliday")
        Me.GvHoliday.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colrow, Me.coldateyear, Me.coldaystop, Me.colremarkyear})
        Me.GvHoliday.GridControl = Me.GcHoliday
        Me.GvHoliday.Name = "GvHoliday"
        Me.GvHoliday.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.GvHoliday.OptionsView.ColumnAutoWidth = False
        Me.GvHoliday.OptionsView.ShowGroupPanel = False
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
        'coldateyear
        '
        Me.coldateyear.AppearanceCell.FontSizeDelta = CType(resources.GetObject("coldateyear.AppearanceCell.FontSizeDelta"), Integer)
        Me.coldateyear.AppearanceCell.FontStyleDelta = CType(resources.GetObject("coldateyear.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.coldateyear.AppearanceCell.GradientMode = CType(resources.GetObject("coldateyear.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.coldateyear.AppearanceCell.Image = CType(resources.GetObject("coldateyear.AppearanceCell.Image"), System.Drawing.Image)
        Me.coldateyear.AppearanceCell.Options.UseTextOptions = True
        Me.coldateyear.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coldateyear.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("coldateyear.AppearanceHeader.FontSizeDelta"), Integer)
        Me.coldateyear.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("coldateyear.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.coldateyear.AppearanceHeader.GradientMode = CType(resources.GetObject("coldateyear.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.coldateyear.AppearanceHeader.Image = CType(resources.GetObject("coldateyear.AppearanceHeader.Image"), System.Drawing.Image)
        Me.coldateyear.AppearanceHeader.Options.UseTextOptions = True
        Me.coldateyear.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.coldateyear, "coldateyear")
        Me.coldateyear.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.coldateyear.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldateyear.FieldName = "Date"
        Me.coldateyear.Name = "coldateyear"
        Me.coldateyear.OptionsColumn.AllowEdit = False
        '
        'coldaystop
        '
        resources.ApplyResources(Me.coldaystop, "coldaystop")
        Me.coldaystop.FieldName = "Description"
        Me.coldaystop.Name = "coldaystop"
        Me.coldaystop.OptionsColumn.AllowEdit = False
        '
        'colremarkyear
        '
        resources.ApplyResources(Me.colremarkyear, "colremarkyear")
        Me.colremarkyear.FieldName = "Remark"
        Me.colremarkyear.Name = "colremarkyear"
        Me.colremarkyear.OptionsColumn.AllowEdit = False
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
        'GroupControl1
        '
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Controls.Add(Me.txtyear)
        Me.GroupControl1.Controls.Add(Me.btnRefresh)
        Me.GroupControl1.Controls.Add(Me.rdAll)
        Me.GroupControl1.Controls.Add(Me.rdYear)
        Me.GroupControl1.Name = "GroupControl1"
        '
        'txtyear
        '
        resources.ApplyResources(Me.txtyear, "txtyear")
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Properties.AccessibleDescription = resources.GetString("txtyear.Properties.AccessibleDescription")
        Me.txtyear.Properties.AccessibleName = resources.GetString("txtyear.Properties.AccessibleName")
        Me.txtyear.Properties.AutoHeight = CType(resources.GetObject("txtyear.Properties.AutoHeight"), Boolean)
        Me.txtyear.Properties.Mask.AutoComplete = CType(resources.GetObject("txtyear.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtyear.Properties.Mask.BeepOnError = CType(resources.GetObject("txtyear.Properties.Mask.BeepOnError"), Boolean)
        Me.txtyear.Properties.Mask.EditMask = resources.GetString("txtyear.Properties.Mask.EditMask")
        Me.txtyear.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtyear.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtyear.Properties.Mask.MaskType = CType(resources.GetObject("txtyear.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtyear.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtyear.Properties.Mask.PlaceHolder"), Char)
        Me.txtyear.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtyear.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtyear.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtyear.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtyear.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtyear.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtyear.Properties.NullValuePrompt = resources.GetString("txtyear.Properties.NullValuePrompt")
        Me.txtyear.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtyear.Properties.NullValuePromptShowForEmptyValue"), Boolean)
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
        'btnAdd
        '
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("btnAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnAdd.Name = "btnAdd"
        '
        'btnEdit
        '
        resources.ApplyResources(Me.btnEdit, "btnEdit")
        Me.btnEdit.ImageOptions.Image = CType(resources.GetObject("btnEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnEdit.Name = "btnEdit"
        '
        'btnDelete
        '
        resources.ApplyResources(Me.btnDelete, "btnDelete")
        Me.btnDelete.ImageOptions.Image = CType(resources.GetObject("btnDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnDelete.Name = "btnDelete"
        '
        'btnClear
        '
        resources.ApplyResources(Me.btnClear, "btnClear")
        Me.btnClear.ImageOptions.Image = CType(resources.GetObject("btnClear.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClear.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnClear.Name = "btnClear"
        '
        'btnExit
        '
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.ImageOptions.Image = CType(resources.GetObject("btnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnExit.Name = "btnExit"
        '
        'txtDescription
        '
        resources.ApplyResources(Me.txtDescription, "txtDescription")
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.AccessibleDescription = resources.GetString("txtDescription.Properties.AccessibleDescription")
        Me.txtDescription.Properties.AccessibleName = resources.GetString("txtDescription.Properties.AccessibleName")
        Me.txtDescription.Properties.AutoHeight = CType(resources.GetObject("txtDescription.Properties.AutoHeight"), Boolean)
        Me.txtDescription.Properties.Mask.AutoComplete = CType(resources.GetObject("txtDescription.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDescription.Properties.Mask.BeepOnError = CType(resources.GetObject("txtDescription.Properties.Mask.BeepOnError"), Boolean)
        Me.txtDescription.Properties.Mask.EditMask = resources.GetString("txtDescription.Properties.Mask.EditMask")
        Me.txtDescription.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDescription.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDescription.Properties.Mask.MaskType = CType(resources.GetObject("txtDescription.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDescription.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtDescription.Properties.Mask.PlaceHolder"), Char)
        Me.txtDescription.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtDescription.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtDescription.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDescription.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDescription.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDescription.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDescription.Properties.NullValuePrompt = resources.GetString("txtDescription.Properties.NullValuePrompt")
        Me.txtDescription.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtDescription.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'txtRemark
        '
        resources.ApplyResources(Me.txtRemark, "txtRemark")
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Properties.AccessibleDescription = resources.GetString("txtRemark.Properties.AccessibleDescription")
        Me.txtRemark.Properties.AccessibleName = resources.GetString("txtRemark.Properties.AccessibleName")
        Me.txtRemark.Properties.AutoHeight = CType(resources.GetObject("txtRemark.Properties.AutoHeight"), Boolean)
        Me.txtRemark.Properties.Mask.AutoComplete = CType(resources.GetObject("txtRemark.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtRemark.Properties.Mask.BeepOnError = CType(resources.GetObject("txtRemark.Properties.Mask.BeepOnError"), Boolean)
        Me.txtRemark.Properties.Mask.EditMask = resources.GetString("txtRemark.Properties.Mask.EditMask")
        Me.txtRemark.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtRemark.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtRemark.Properties.Mask.MaskType = CType(resources.GetObject("txtRemark.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtRemark.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtRemark.Properties.Mask.PlaceHolder"), Char)
        Me.txtRemark.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtRemark.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtRemark.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtRemark.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtRemark.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtRemark.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtRemark.Properties.NullValuePrompt = resources.GetString("txtRemark.Properties.NullValuePrompt")
        Me.txtRemark.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtRemark.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'txtDate
        '
        resources.ApplyResources(Me.txtDate, "txtDate")
        Me.txtDate.EnterMoveNextControl = True
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Properties.AccessibleDescription = resources.GetString("txtDate.Properties.AccessibleDescription")
        Me.txtDate.Properties.AccessibleName = resources.GetString("txtDate.Properties.AccessibleName")
        Me.txtDate.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtDate.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtDate.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtDate.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtDate.Properties.Appearance.GradientMode = CType(resources.GetObject("txtDate.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtDate.Properties.Appearance.Image = CType(resources.GetObject("txtDate.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtDate.Properties.Appearance.Options.UseFont = True
        Me.txtDate.Properties.AutoHeight = CType(resources.GetObject("txtDate.Properties.AutoHeight"), Boolean)
        Me.txtDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDate.Properties.CalendarTimeProperties.AccessibleDescription = resources.GetString("txtDate.Properties.CalendarTimeProperties.AccessibleDescription")
        Me.txtDate.Properties.CalendarTimeProperties.AccessibleName = resources.GetString("txtDate.Properties.CalendarTimeProperties.AccessibleName")
        Me.txtDate.Properties.CalendarTimeProperties.AutoHeight = CType(resources.GetObject("txtDate.Properties.CalendarTimeProperties.AutoHeight"), Boolean)
        Me.txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDate.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDate.Properties.CalendarTimeProperties.Mask.AutoComplete = CType(resources.GetObject("txtDate.Properties.CalendarTimeProperties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDate.Properties.CalendarTimeProperties.Mask.BeepOnError = CType(resources.GetObject("txtDate.Properties.CalendarTimeProperties.Mask.BeepOnError"), Boolean)
        Me.txtDate.Properties.CalendarTimeProperties.Mask.EditMask = resources.GetString("txtDate.Properties.CalendarTimeProperties.Mask.EditMask")
        Me.txtDate.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDate.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDate.Properties.CalendarTimeProperties.Mask.MaskType = CType(resources.GetObject("txtDate.Properties.CalendarTimeProperties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDate.Properties.CalendarTimeProperties.Mask.PlaceHolder = CType(resources.GetObject("txtDate.Properties.CalendarTimeProperties.Mask.PlaceHolder"), Char)
        Me.txtDate.Properties.CalendarTimeProperties.Mask.SaveLiteral = CType(resources.GetObject("txtDate.Properties.CalendarTimeProperties.Mask.SaveLiteral"), Boolean)
        Me.txtDate.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDate.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDate.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDate.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDate.Properties.CalendarTimeProperties.NullValuePrompt = resources.GetString("txtDate.Properties.CalendarTimeProperties.NullValuePrompt")
        Me.txtDate.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtDate.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.txtDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDate.Properties.Mask.AutoComplete = CType(resources.GetObject("txtDate.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDate.Properties.Mask.BeepOnError = CType(resources.GetObject("txtDate.Properties.Mask.BeepOnError"), Boolean)
        Me.txtDate.Properties.Mask.EditMask = resources.GetString("txtDate.Properties.Mask.EditMask")
        Me.txtDate.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDate.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDate.Properties.Mask.MaskType = CType(resources.GetObject("txtDate.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDate.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtDate.Properties.Mask.PlaceHolder"), Char)
        Me.txtDate.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtDate.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtDate.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDate.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDate.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDate.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDate.Properties.NullValuePrompt = resources.GetString("txtDate.Properties.NullValuePrompt")
        Me.txtDate.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtDate.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        '
        'frmHolidayYear_New
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GcHoliday)
        Me.Controls.Add(Me.lstHoliday)
        Me.Name = "frmHolidayYear_New"
        CType(Me.GcHoliday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvHoliday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtyear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdYear As System.Windows.Forms.RadioButton
    Friend WithEvents lstHoliday As System.Windows.Forms.ListView
    Friend WithEvents colNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDescription As System.Windows.Forms.ColumnHeader
    Friend WithEvents colRemark As System.Windows.Forms.ColumnHeader
    Friend WithEvents GcHoliday As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvHoliday As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colrow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldateyear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldaystop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colremarkyear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cboTransport_detail As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboUnitName As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtyear As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRemark As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
