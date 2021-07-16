<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDivision
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDivision))
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.GcDivision = New DevExpress.XtraGrid.GridControl()
        Me.GvDivision = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldateyear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldaystop = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cboTransport_detail = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboUnitName = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtDivid = New DevExpress.XtraEditors.TextEdit()
        Me.lblDivision = New DevExpress.XtraEditors.LabelControl()
        Me.txtDivision = New DevExpress.XtraEditors.TextEdit()
        Me.lblDivid = New DevExpress.XtraEditors.LabelControl()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_clear = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Edit = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_del = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_exit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GcDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtDivid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDivision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        resources.ApplyResources(Me.Highlighter1, "Highlighter1")
        '
        'GcDivision
        '
        resources.ApplyResources(Me.GcDivision, "GcDivision")
        Me.GcDivision.EmbeddedNavigator.AccessibleDescription = resources.GetString("GcDivision.EmbeddedNavigator.AccessibleDescription")
        Me.GcDivision.EmbeddedNavigator.AccessibleName = resources.GetString("GcDivision.EmbeddedNavigator.AccessibleName")
        Me.GcDivision.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GcDivision.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GcDivision.EmbeddedNavigator.Anchor = CType(resources.GetObject("GcDivision.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GcDivision.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GcDivision.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GcDivision.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GcDivision.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GcDivision.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GcDivision.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GcDivision.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GcDivision.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GcDivision.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GcDivision.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GcDivision.EmbeddedNavigator.ToolTip = resources.GetString("GcDivision.EmbeddedNavigator.ToolTip")
        Me.GcDivision.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GcDivision.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GcDivision.EmbeddedNavigator.ToolTipTitle = resources.GetString("GcDivision.EmbeddedNavigator.ToolTipTitle")
        Me.Highlighter1.SetHighlightColor(Me.GcDivision, CType(resources.GetObject("GcDivision.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.GcDivision, CType(resources.GetObject("GcDivision.HighlightOnFocus"), Boolean))
        Me.GcDivision.MainView = Me.GvDivision
        Me.GcDivision.Name = "GcDivision"
        Me.GcDivision.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.BtnDel, Me.cboTransport_detail, Me.cboUnitName})
        Me.GcDivision.TabStop = False
        Me.GcDivision.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvDivision})
        '
        'GvDivision
        '
        Me.GvDivision.Appearance.HeaderPanel.Font = CType(resources.GetObject("GvDivision.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GvDivision.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GvDivision.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GvDivision.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GvDivision.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GvDivision.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GvDivision.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GvDivision.Appearance.HeaderPanel.Image = CType(resources.GetObject("GvDivision.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GvDivision.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvDivision.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GvDivision.Appearance.Row.FontSizeDelta"), Integer)
        Me.GvDivision.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GvDivision.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GvDivision.Appearance.Row.GradientMode = CType(resources.GetObject("GvDivision.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GvDivision.Appearance.Row.Image = CType(resources.GetObject("GvDivision.Appearance.Row.Image"), System.Drawing.Image)
        Me.GvDivision.Appearance.Row.Options.UseFont = True
        resources.ApplyResources(Me.GvDivision, "GvDivision")
        Me.GvDivision.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colrow, Me.coldateyear, Me.coldaystop})
        Me.GvDivision.GridControl = Me.GcDivision
        Me.GvDivision.Name = "GvDivision"
        Me.GvDivision.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.GvDivision.OptionsView.ColumnAutoWidth = False
        Me.GvDivision.OptionsView.ShowAutoFilterRow = True
        Me.GvDivision.OptionsView.ShowGroupPanel = False
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
        Me.coldateyear.FieldName = "DivId"
        Me.coldateyear.Name = "coldateyear"
        Me.coldateyear.OptionsColumn.AllowEdit = False
        Me.coldateyear.OptionsColumn.ReadOnly = True
        '
        'coldaystop
        '
        resources.ApplyResources(Me.coldaystop, "coldaystop")
        Me.coldaystop.FieldName = "Division"
        Me.coldaystop.Name = "coldaystop"
        Me.coldaystop.OptionsColumn.AllowEdit = False
        Me.coldaystop.OptionsColumn.ReadOnly = True
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
        Me.PanelControl1.Controls.Add(Me.txtDivid)
        Me.PanelControl1.Controls.Add(Me.lblDivision)
        Me.PanelControl1.Controls.Add(Me.txtDivision)
        Me.PanelControl1.Controls.Add(Me.lblDivid)
        Me.Highlighter1.SetHighlightColor(Me.PanelControl1, CType(resources.GetObject("PanelControl1.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.PanelControl1, CType(resources.GetObject("PanelControl1.HighlightOnFocus"), Boolean))
        Me.PanelControl1.Name = "PanelControl1"
        '
        'txtDivid
        '
        resources.ApplyResources(Me.txtDivid, "txtDivid")
        Me.txtDivid.EnterMoveNextControl = True
        Me.Highlighter1.SetHighlightColor(Me.txtDivid, CType(resources.GetObject("txtDivid.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.txtDivid, CType(resources.GetObject("txtDivid.HighlightOnFocus"), Boolean))
        Me.txtDivid.Name = "txtDivid"
        Me.txtDivid.Properties.AccessibleDescription = resources.GetString("txtDivid.Properties.AccessibleDescription")
        Me.txtDivid.Properties.AccessibleName = resources.GetString("txtDivid.Properties.AccessibleName")
        Me.txtDivid.Properties.AutoHeight = CType(resources.GetObject("txtDivid.Properties.AutoHeight"), Boolean)
        Me.txtDivid.Properties.Mask.AutoComplete = CType(resources.GetObject("txtDivid.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDivid.Properties.Mask.BeepOnError = CType(resources.GetObject("txtDivid.Properties.Mask.BeepOnError"), Boolean)
        Me.txtDivid.Properties.Mask.EditMask = resources.GetString("txtDivid.Properties.Mask.EditMask")
        Me.txtDivid.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDivid.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDivid.Properties.Mask.MaskType = CType(resources.GetObject("txtDivid.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDivid.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtDivid.Properties.Mask.PlaceHolder"), Char)
        Me.txtDivid.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtDivid.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtDivid.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDivid.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDivid.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDivid.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDivid.Properties.NullValuePrompt = resources.GetString("txtDivid.Properties.NullValuePrompt")
        Me.txtDivid.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtDivid.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'lblDivision
        '
        resources.ApplyResources(Me.lblDivision, "lblDivision")
        Me.Highlighter1.SetHighlightColor(Me.lblDivision, CType(resources.GetObject("lblDivision.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.lblDivision, CType(resources.GetObject("lblDivision.HighlightOnFocus"), Boolean))
        Me.lblDivision.Name = "lblDivision"
        '
        'txtDivision
        '
        resources.ApplyResources(Me.txtDivision, "txtDivision")
        Me.txtDivision.EnterMoveNextControl = True
        Me.Highlighter1.SetHighlightColor(Me.txtDivision, CType(resources.GetObject("txtDivision.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.txtDivision, CType(resources.GetObject("txtDivision.HighlightOnFocus"), Boolean))
        Me.txtDivision.Name = "txtDivision"
        Me.txtDivision.Properties.AccessibleDescription = resources.GetString("txtDivision.Properties.AccessibleDescription")
        Me.txtDivision.Properties.AccessibleName = resources.GetString("txtDivision.Properties.AccessibleName")
        Me.txtDivision.Properties.AutoHeight = CType(resources.GetObject("txtDivision.Properties.AutoHeight"), Boolean)
        Me.txtDivision.Properties.Mask.AutoComplete = CType(resources.GetObject("txtDivision.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDivision.Properties.Mask.BeepOnError = CType(resources.GetObject("txtDivision.Properties.Mask.BeepOnError"), Boolean)
        Me.txtDivision.Properties.Mask.EditMask = resources.GetString("txtDivision.Properties.Mask.EditMask")
        Me.txtDivision.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDivision.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDivision.Properties.Mask.MaskType = CType(resources.GetObject("txtDivision.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDivision.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtDivision.Properties.Mask.PlaceHolder"), Char)
        Me.txtDivision.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtDivision.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtDivision.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDivision.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDivision.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDivision.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDivision.Properties.NullValuePrompt = resources.GetString("txtDivision.Properties.NullValuePrompt")
        Me.txtDivision.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtDivision.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'lblDivid
        '
        resources.ApplyResources(Me.lblDivid, "lblDivid")
        Me.Highlighter1.SetHighlightColor(Me.lblDivid, CType(resources.GetObject("lblDivid.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.lblDivid, CType(resources.GetObject("lblDivid.HighlightOnFocus"), Boolean))
        Me.lblDivid.Name = "lblDivid"
        '
        'btn_save
        '
        resources.ApplyResources(Me.btn_save, "btn_save")
        Me.Highlighter1.SetHighlightColor(Me.btn_save, CType(resources.GetObject("btn_save.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.btn_save, CType(resources.GetObject("btn_save.HighlightOnFocus"), Boolean))
        Me.btn_save.ImageOptions.Image = CType(resources.GetObject("btn_save.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_save.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_save.Name = "btn_save"
        '
        'btn_clear
        '
        resources.ApplyResources(Me.btn_clear, "btn_clear")
        Me.Highlighter1.SetHighlightColor(Me.btn_clear, CType(resources.GetObject("btn_clear.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.btn_clear, CType(resources.GetObject("btn_clear.HighlightOnFocus"), Boolean))
        Me.btn_clear.ImageOptions.Image = CType(resources.GetObject("btn_clear.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_clear.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_clear.Name = "btn_clear"
        '
        'btn_Edit
        '
        resources.ApplyResources(Me.btn_Edit, "btn_Edit")
        Me.Highlighter1.SetHighlightColor(Me.btn_Edit, CType(resources.GetObject("btn_Edit.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.btn_Edit, CType(resources.GetObject("btn_Edit.HighlightOnFocus"), Boolean))
        Me.btn_Edit.ImageOptions.Image = CType(resources.GetObject("btn_Edit.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Edit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_Edit.Name = "btn_Edit"
        '
        'btn_del
        '
        resources.ApplyResources(Me.btn_del, "btn_del")
        Me.Highlighter1.SetHighlightColor(Me.btn_del, CType(resources.GetObject("btn_del.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.btn_del, CType(resources.GetObject("btn_del.HighlightOnFocus"), Boolean))
        Me.btn_del.ImageOptions.Image = CType(resources.GetObject("btn_del.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_del.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_del.Name = "btn_del"
        '
        'btn_exit
        '
        resources.ApplyResources(Me.btn_exit, "btn_exit")
        Me.Highlighter1.SetHighlightColor(Me.btn_exit, CType(resources.GetObject("btn_exit.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.btn_exit, CType(resources.GetObject("btn_exit.HighlightOnFocus"), Boolean))
        Me.btn_exit.ImageOptions.Image = CType(resources.GetObject("btn_exit.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_exit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_exit.Name = "btn_exit"
        '
        'frmDivision
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GcDivision)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_Edit)
        Me.Controls.Add(Me.btn_del)
        Me.Highlighter1.SetHighlightColor(Me, CType(resources.GetObject("$this.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me, CType(resources.GetObject("$this.HighlightOnFocus"), Boolean))
        Me.Name = "frmDivision"
        CType(Me.GcDivision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvDivision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtDivid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDivision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents GcDivision As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvDivision As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colrow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldateyear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldaystop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colremarkyear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cboTransport_detail As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboUnitName As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtDivid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDivision As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDivision As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDivid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_clear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_del As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_exit As DevExpress.XtraEditors.SimpleButton
End Class
