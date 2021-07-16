<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOtDeductRate
    '   Inherits System.Windows.Forms.Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOtDeductRate))
        Me.lstOtRate = New System.Windows.Forms.ListView()
        Me.colNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTimeFrom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTimeTo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTotalHour = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLastUpdate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.txtPay = New DevExpress.XtraEditors.TextEdit()
        Me.txtMnStop = New DevExpress.XtraEditors.TextEdit()
        Me.txtMnStart = New DevExpress.XtraEditors.TextEdit()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.GcOtRate = New DevExpress.XtraGrid.GridControl()
        Me.GvOtRate = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode_lar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription_lar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReduc_lar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotdeduc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colremark_lar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cboTransport_detail = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboUnitName = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lblCode = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtPay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMnStop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMnStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcOtRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvOtRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstOtRate
        '
        resources.ApplyResources(Me.lstOtRate, "lstOtRate")
        Me.lstOtRate.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNo, Me.colCode, Me.colTimeFrom, Me.colTimeTo, Me.colTotalHour, Me.colLastUpdate})
        Me.lstOtRate.FullRowSelect = True
        Me.lstOtRate.GridLines = True
        Me.lstOtRate.Name = "lstOtRate"
        Me.lstOtRate.UseCompatibleStateImageBehavior = False
        Me.lstOtRate.View = System.Windows.Forms.View.Details
        '
        'colNo
        '
        resources.ApplyResources(Me.colNo, "colNo")
        '
        'colCode
        '
        resources.ApplyResources(Me.colCode, "colCode")
        '
        'colTimeFrom
        '
        resources.ApplyResources(Me.colTimeFrom, "colTimeFrom")
        '
        'colTimeTo
        '
        resources.ApplyResources(Me.colTimeTo, "colTimeTo")
        '
        'colTotalHour
        '
        resources.ApplyResources(Me.colTotalHour, "colTotalHour")
        '
        'colLastUpdate
        '
        resources.ApplyResources(Me.colLastUpdate, "colLastUpdate")
        '
        'SaveFileDialog1
        '
        resources.ApplyResources(Me.SaveFileDialog1, "SaveFileDialog1")
        '
        'txtPay
        '
        resources.ApplyResources(Me.txtPay, "txtPay")
        Me.txtPay.EnterMoveNextControl = True
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Properties.AccessibleDescription = resources.GetString("txtPay.Properties.AccessibleDescription")
        Me.txtPay.Properties.AccessibleName = resources.GetString("txtPay.Properties.AccessibleName")
        Me.txtPay.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtPay.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtPay.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtPay.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtPay.Properties.Appearance.GradientMode = CType(resources.GetObject("txtPay.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtPay.Properties.Appearance.Image = CType(resources.GetObject("txtPay.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtPay.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPay.Properties.AutoHeight = CType(resources.GetObject("txtPay.Properties.AutoHeight"), Boolean)
        Me.txtPay.Properties.DisplayFormat.FormatString = "n0"
        Me.txtPay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPay.Properties.EditFormat.FormatString = "n0"
        Me.txtPay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPay.Properties.Mask.AutoComplete = CType(resources.GetObject("txtPay.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtPay.Properties.Mask.BeepOnError = CType(resources.GetObject("txtPay.Properties.Mask.BeepOnError"), Boolean)
        Me.txtPay.Properties.Mask.EditMask = resources.GetString("txtPay.Properties.Mask.EditMask")
        Me.txtPay.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtPay.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtPay.Properties.Mask.MaskType = CType(resources.GetObject("txtPay.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtPay.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtPay.Properties.Mask.PlaceHolder"), Char)
        Me.txtPay.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtPay.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtPay.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtPay.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtPay.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtPay.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtPay.Properties.NullValuePrompt = resources.GetString("txtPay.Properties.NullValuePrompt")
        Me.txtPay.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtPay.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'txtMnStop
        '
        resources.ApplyResources(Me.txtMnStop, "txtMnStop")
        Me.txtMnStop.EnterMoveNextControl = True
        Me.txtMnStop.Name = "txtMnStop"
        Me.txtMnStop.Properties.AccessibleDescription = resources.GetString("txtMnStop.Properties.AccessibleDescription")
        Me.txtMnStop.Properties.AccessibleName = resources.GetString("txtMnStop.Properties.AccessibleName")
        Me.txtMnStop.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtMnStop.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtMnStop.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtMnStop.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtMnStop.Properties.Appearance.GradientMode = CType(resources.GetObject("txtMnStop.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtMnStop.Properties.Appearance.Image = CType(resources.GetObject("txtMnStop.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtMnStop.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMnStop.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMnStop.Properties.AutoHeight = CType(resources.GetObject("txtMnStop.Properties.AutoHeight"), Boolean)
        Me.txtMnStop.Properties.Mask.AutoComplete = CType(resources.GetObject("txtMnStop.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtMnStop.Properties.Mask.BeepOnError = CType(resources.GetObject("txtMnStop.Properties.Mask.BeepOnError"), Boolean)
        Me.txtMnStop.Properties.Mask.EditMask = resources.GetString("txtMnStop.Properties.Mask.EditMask")
        Me.txtMnStop.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtMnStop.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtMnStop.Properties.Mask.MaskType = CType(resources.GetObject("txtMnStop.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtMnStop.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtMnStop.Properties.Mask.PlaceHolder"), Char)
        Me.txtMnStop.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtMnStop.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtMnStop.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtMnStop.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtMnStop.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtMnStop.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtMnStop.Properties.NullValuePrompt = resources.GetString("txtMnStop.Properties.NullValuePrompt")
        Me.txtMnStop.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtMnStop.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'txtMnStart
        '
        resources.ApplyResources(Me.txtMnStart, "txtMnStart")
        Me.txtMnStart.EnterMoveNextControl = True
        Me.txtMnStart.Name = "txtMnStart"
        Me.txtMnStart.Properties.AccessibleDescription = resources.GetString("txtMnStart.Properties.AccessibleDescription")
        Me.txtMnStart.Properties.AccessibleName = resources.GetString("txtMnStart.Properties.AccessibleName")
        Me.txtMnStart.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtMnStart.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtMnStart.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtMnStart.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtMnStart.Properties.Appearance.GradientMode = CType(resources.GetObject("txtMnStart.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtMnStart.Properties.Appearance.Image = CType(resources.GetObject("txtMnStart.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtMnStart.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMnStart.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMnStart.Properties.AutoHeight = CType(resources.GetObject("txtMnStart.Properties.AutoHeight"), Boolean)
        Me.txtMnStart.Properties.Mask.AutoComplete = CType(resources.GetObject("txtMnStart.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtMnStart.Properties.Mask.BeepOnError = CType(resources.GetObject("txtMnStart.Properties.Mask.BeepOnError"), Boolean)
        Me.txtMnStart.Properties.Mask.EditMask = resources.GetString("txtMnStart.Properties.Mask.EditMask")
        Me.txtMnStart.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtMnStart.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtMnStart.Properties.Mask.MaskType = CType(resources.GetObject("txtMnStart.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtMnStart.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtMnStart.Properties.Mask.PlaceHolder"), Char)
        Me.txtMnStart.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtMnStart.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtMnStart.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtMnStart.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtMnStart.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtMnStart.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtMnStart.Properties.NullValuePrompt = resources.GetString("txtMnStart.Properties.NullValuePrompt")
        Me.txtMnStart.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtMnStart.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'txtCode
        '
        resources.ApplyResources(Me.txtCode, "txtCode")
        Me.txtCode.EnterMoveNextControl = True
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
        '
        'btnExit
        '
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.ImageOptions.Image = CType(resources.GetObject("btnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnExit.Name = "btnExit"
        '
        'btnClear
        '
        resources.ApplyResources(Me.btnClear, "btnClear")
        Me.btnClear.ImageOptions.Image = CType(resources.GetObject("btnClear.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClear.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnClear.Name = "btnClear"
        '
        'btnDelete
        '
        resources.ApplyResources(Me.btnDelete, "btnDelete")
        Me.btnDelete.ImageOptions.Image = CType(resources.GetObject("btnDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnDelete.Name = "btnDelete"
        '
        'btnEdit
        '
        resources.ApplyResources(Me.btnEdit, "btnEdit")
        Me.btnEdit.ImageOptions.Image = CType(resources.GetObject("btnEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnEdit.Name = "btnEdit"
        '
        'btnAdd
        '
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("btnAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnAdd.Name = "btnAdd"
        '
        'GcOtRate
        '
        resources.ApplyResources(Me.GcOtRate, "GcOtRate")
        Me.GcOtRate.EmbeddedNavigator.AccessibleDescription = resources.GetString("GcOtRate.EmbeddedNavigator.AccessibleDescription")
        Me.GcOtRate.EmbeddedNavigator.AccessibleName = resources.GetString("GcOtRate.EmbeddedNavigator.AccessibleName")
        Me.GcOtRate.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GcOtRate.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GcOtRate.EmbeddedNavigator.Anchor = CType(resources.GetObject("GcOtRate.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GcOtRate.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GcOtRate.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GcOtRate.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GcOtRate.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GcOtRate.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GcOtRate.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GcOtRate.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GcOtRate.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GcOtRate.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GcOtRate.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GcOtRate.EmbeddedNavigator.ToolTip = resources.GetString("GcOtRate.EmbeddedNavigator.ToolTip")
        Me.GcOtRate.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GcOtRate.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GcOtRate.EmbeddedNavigator.ToolTipTitle = resources.GetString("GcOtRate.EmbeddedNavigator.ToolTipTitle")
        Me.GcOtRate.MainView = Me.GvOtRate
        Me.GcOtRate.Name = "GcOtRate"
        Me.GcOtRate.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.BtnDel, Me.cboTransport_detail, Me.cboUnitName})
        Me.GcOtRate.TabStop = False
        Me.GcOtRate.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvOtRate})
        '
        'GvOtRate
        '
        Me.GvOtRate.Appearance.HeaderPanel.Font = CType(resources.GetObject("GvOtRate.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GvOtRate.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GvOtRate.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GvOtRate.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GvOtRate.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GvOtRate.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GvOtRate.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GvOtRate.Appearance.HeaderPanel.Image = CType(resources.GetObject("GvOtRate.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GvOtRate.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvOtRate.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GvOtRate.Appearance.Row.FontSizeDelta"), Integer)
        Me.GvOtRate.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GvOtRate.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GvOtRate.Appearance.Row.GradientMode = CType(resources.GetObject("GvOtRate.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GvOtRate.Appearance.Row.Image = CType(resources.GetObject("GvOtRate.Appearance.Row.Image"), System.Drawing.Image)
        Me.GvOtRate.Appearance.Row.Options.UseFont = True
        resources.ApplyResources(Me.GvOtRate, "GvOtRate")
        Me.GvOtRate.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colrow, Me.colcode_lar, Me.colDescription_lar, Me.colReduc_lar, Me.colNotdeduc, Me.colremark_lar})
        Me.GvOtRate.GridControl = Me.GcOtRate
        Me.GvOtRate.Name = "GvOtRate"
        Me.GvOtRate.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.GvOtRate.OptionsView.ColumnAutoWidth = False
        Me.GvOtRate.OptionsView.ShowGroupPanel = False
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
        '
        'colDescription_lar
        '
        resources.ApplyResources(Me.colDescription_lar, "colDescription_lar")
        Me.colDescription_lar.FieldName = "MnST"
        Me.colDescription_lar.Name = "colDescription_lar"
        Me.colDescription_lar.OptionsColumn.AllowEdit = False
        '
        'colReduc_lar
        '
        Me.colReduc_lar.AppearanceCell.FontSizeDelta = CType(resources.GetObject("colReduc_lar.AppearanceCell.FontSizeDelta"), Integer)
        Me.colReduc_lar.AppearanceCell.FontStyleDelta = CType(resources.GetObject("colReduc_lar.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.colReduc_lar.AppearanceCell.GradientMode = CType(resources.GetObject("colReduc_lar.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.colReduc_lar.AppearanceCell.Image = CType(resources.GetObject("colReduc_lar.AppearanceCell.Image"), System.Drawing.Image)
        Me.colReduc_lar.AppearanceCell.Options.UseTextOptions = True
        Me.colReduc_lar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colReduc_lar.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("colReduc_lar.AppearanceHeader.FontSizeDelta"), Integer)
        Me.colReduc_lar.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("colReduc_lar.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.colReduc_lar.AppearanceHeader.GradientMode = CType(resources.GetObject("colReduc_lar.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.colReduc_lar.AppearanceHeader.Image = CType(resources.GetObject("colReduc_lar.AppearanceHeader.Image"), System.Drawing.Image)
        Me.colReduc_lar.AppearanceHeader.Options.UseTextOptions = True
        Me.colReduc_lar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colReduc_lar, "colReduc_lar")
        Me.colReduc_lar.FieldName = "MnSP"
        Me.colReduc_lar.Name = "colReduc_lar"
        Me.colReduc_lar.OptionsColumn.AllowEdit = False
        '
        'colNotdeduc
        '
        Me.colNotdeduc.AppearanceCell.FontSizeDelta = CType(resources.GetObject("colNotdeduc.AppearanceCell.FontSizeDelta"), Integer)
        Me.colNotdeduc.AppearanceCell.FontStyleDelta = CType(resources.GetObject("colNotdeduc.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.colNotdeduc.AppearanceCell.GradientMode = CType(resources.GetObject("colNotdeduc.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.colNotdeduc.AppearanceCell.Image = CType(resources.GetObject("colNotdeduc.AppearanceCell.Image"), System.Drawing.Image)
        Me.colNotdeduc.AppearanceCell.Options.UseTextOptions = True
        Me.colNotdeduc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNotdeduc.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("colNotdeduc.AppearanceHeader.FontSizeDelta"), Integer)
        Me.colNotdeduc.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("colNotdeduc.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.colNotdeduc.AppearanceHeader.GradientMode = CType(resources.GetObject("colNotdeduc.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.colNotdeduc.AppearanceHeader.Image = CType(resources.GetObject("colNotdeduc.AppearanceHeader.Image"), System.Drawing.Image)
        Me.colNotdeduc.AppearanceHeader.Options.UseTextOptions = True
        Me.colNotdeduc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colNotdeduc, "colNotdeduc")
        Me.colNotdeduc.FieldName = "Deduc"
        Me.colNotdeduc.Name = "colNotdeduc"
        Me.colNotdeduc.OptionsColumn.AllowEdit = False
        '
        'colremark_lar
        '
        resources.ApplyResources(Me.colremark_lar, "colremark_lar")
        Me.colremark_lar.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.colremark_lar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colremark_lar.FieldName = "LastUpdate"
        Me.colremark_lar.Name = "colremark_lar"
        Me.colremark_lar.OptionsColumn.AllowEdit = False
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
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.lblCode)
        Me.PanelControl1.Controls.Add(Me.txtCode)
        Me.PanelControl1.Controls.Add(Me.txtMnStart)
        Me.PanelControl1.Controls.Add(Me.txtMnStop)
        Me.PanelControl1.Controls.Add(Me.txtPay)
        Me.PanelControl1.Name = "PanelControl1"
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Appearance.FontSizeDelta = CType(resources.GetObject("LabelControl3.Appearance.FontSizeDelta"), Integer)
        Me.LabelControl3.Appearance.FontStyleDelta = CType(resources.GetObject("LabelControl3.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.LabelControl3.Appearance.GradientMode = CType(resources.GetObject("LabelControl3.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.LabelControl3.Appearance.Image = CType(resources.GetObject("LabelControl3.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Name = "LabelControl3"
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Appearance.FontSizeDelta = CType(resources.GetObject("LabelControl2.Appearance.FontSizeDelta"), Integer)
        Me.LabelControl2.Appearance.FontStyleDelta = CType(resources.GetObject("LabelControl2.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.LabelControl2.Appearance.GradientMode = CType(resources.GetObject("LabelControl2.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.LabelControl2.Appearance.Image = CType(resources.GetObject("LabelControl2.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Name = "LabelControl2"
        '
        'LabelControl4
        '
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Appearance.FontSizeDelta = CType(resources.GetObject("LabelControl4.Appearance.FontSizeDelta"), Integer)
        Me.LabelControl4.Appearance.FontStyleDelta = CType(resources.GetObject("LabelControl4.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.LabelControl4.Appearance.GradientMode = CType(resources.GetObject("LabelControl4.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.LabelControl4.Appearance.Image = CType(resources.GetObject("LabelControl4.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Name = "LabelControl4"
        '
        'lblCode
        '
        resources.ApplyResources(Me.lblCode, "lblCode")
        Me.lblCode.Appearance.FontSizeDelta = CType(resources.GetObject("lblCode.Appearance.FontSizeDelta"), Integer)
        Me.lblCode.Appearance.FontStyleDelta = CType(resources.GetObject("lblCode.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.lblCode.Appearance.GradientMode = CType(resources.GetObject("lblCode.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.lblCode.Appearance.Image = CType(resources.GetObject("lblCode.Appearance.Image"), System.Drawing.Image)
        Me.lblCode.Appearance.Options.UseTextOptions = True
        Me.lblCode.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblCode.Name = "lblCode"
        '
        'frmOtDeductRate
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GcOtRate)
        Me.Controls.Add(Me.lstOtRate)
        Me.KeyPreview = True
        Me.Name = "frmOtDeductRate"
        CType(Me.txtPay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMnStop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMnStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcOtRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvOtRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstOtRate As System.Windows.Forms.ListView
    Friend WithEvents colNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTimeFrom As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTimeTo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTotalHour As System.Windows.Forms.ColumnHeader
    Friend WithEvents colLastUpdate As System.Windows.Forms.ColumnHeader
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtPay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMnStop As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMnStart As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GcOtRate As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvOtRate As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colrow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode_lar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription_lar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReduc_lar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotdeduc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colremark_lar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cboTransport_detail As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboUnitName As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
