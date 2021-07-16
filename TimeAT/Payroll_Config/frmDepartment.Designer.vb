<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDepartment
    ' Inherits System.Windows.Forms.Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepartment))
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.GcHoliday = New DevExpress.XtraGrid.GridControl()
        Me.GvHoliday = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldateyear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldaystop = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colremarkyear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cboTransport_detail = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboUnitName = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btn_exit = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_clear = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_del = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Edit = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblDivision = New DevExpress.XtraEditors.LabelControl()
        Me.cboDivision = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtDeptId = New DevExpress.XtraEditors.TextEdit()
        Me.lblDepartment = New DevExpress.XtraEditors.LabelControl()
        Me.txtDepartment = New DevExpress.XtraEditors.TextEdit()
        Me.lblDeptId = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GcHoliday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvHoliday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeptId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        resources.ApplyResources(Me.Highlighter1, "Highlighter1")
        '
        'btnExit
        '
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.Highlighter1.SetHighlightColor(Me.btnExit, CType(resources.GetObject("btnExit.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.btnExit, CType(resources.GetObject("btnExit.HighlightOnFocus"), Boolean))
        Me.btnExit.ImageOptions.Image = CType(resources.GetObject("btnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnExit.Name = "btnExit"
        '
        'btnClear
        '
        resources.ApplyResources(Me.btnClear, "btnClear")
        Me.Highlighter1.SetHighlightColor(Me.btnClear, CType(resources.GetObject("btnClear.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.btnClear, CType(resources.GetObject("btnClear.HighlightOnFocus"), Boolean))
        Me.btnClear.ImageOptions.Image = CType(resources.GetObject("btnClear.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClear.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnClear.Name = "btnClear"
        '
        'btnDelete
        '
        resources.ApplyResources(Me.btnDelete, "btnDelete")
        Me.Highlighter1.SetHighlightColor(Me.btnDelete, CType(resources.GetObject("btnDelete.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.btnDelete, CType(resources.GetObject("btnDelete.HighlightOnFocus"), Boolean))
        Me.btnDelete.ImageOptions.Image = CType(resources.GetObject("btnDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnDelete.Name = "btnDelete"
        '
        'btnEdit
        '
        resources.ApplyResources(Me.btnEdit, "btnEdit")
        Me.Highlighter1.SetHighlightColor(Me.btnEdit, CType(resources.GetObject("btnEdit.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.btnEdit, CType(resources.GetObject("btnEdit.HighlightOnFocus"), Boolean))
        Me.btnEdit.ImageOptions.Image = CType(resources.GetObject("btnEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnEdit.Name = "btnEdit"
        '
        'btnAdd
        '
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        Me.Highlighter1.SetHighlightColor(Me.btnAdd, CType(resources.GetObject("btnAdd.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.btnAdd, CType(resources.GetObject("btnAdd.HighlightOnFocus"), Boolean))
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("btnAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnAdd.Name = "btnAdd"
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
        Me.Highlighter1.SetHighlightColor(Me.GcHoliday, CType(resources.GetObject("GcHoliday.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.GcHoliday, CType(resources.GetObject("GcHoliday.HighlightOnFocus"), Boolean))
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
        Me.GvHoliday.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colrow, Me.coldateyear, Me.GridColumn1, Me.coldaystop, Me.colremarkyear})
        Me.GvHoliday.GridControl = Me.GcHoliday
        Me.GvHoliday.Name = "GvHoliday"
        Me.GvHoliday.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.GvHoliday.OptionsView.ColumnAutoWidth = False
        Me.GvHoliday.OptionsView.ShowAutoFilterRow = True
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
        Me.colrow.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem()})
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
        Me.coldateyear.FieldName = "DeptId"
        Me.coldateyear.Name = "coldateyear"
        Me.coldateyear.OptionsColumn.AllowEdit = False
        Me.coldateyear.OptionsColumn.ReadOnly = True
        Me.coldateyear.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem()})
        '
        'coldaystop
        '
        resources.ApplyResources(Me.coldaystop, "coldaystop")
        Me.coldaystop.FieldName = "Department"
        Me.coldaystop.Name = "coldaystop"
        Me.coldaystop.OptionsColumn.AllowEdit = False
        Me.coldaystop.OptionsColumn.ReadOnly = True
        '
        'colremarkyear
        '
        resources.ApplyResources(Me.colremarkyear, "colremarkyear")
        Me.colremarkyear.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.colremarkyear.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colremarkyear.FieldName = "LastUpdate"
        Me.colremarkyear.Name = "colremarkyear"
        Me.colremarkyear.OptionsColumn.AllowEdit = False
        Me.colremarkyear.OptionsColumn.ReadOnly = True
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
        'btn_exit
        '
        resources.ApplyResources(Me.btn_exit, "btn_exit")
        Me.Highlighter1.SetHighlightColor(Me.btn_exit, CType(resources.GetObject("btn_exit.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.btn_exit, CType(resources.GetObject("btn_exit.HighlightOnFocus"), Boolean))
        Me.btn_exit.ImageOptions.Image = CType(resources.GetObject("btn_exit.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_exit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_exit.Name = "btn_exit"
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
        'btn_del
        '
        resources.ApplyResources(Me.btn_del, "btn_del")
        Me.Highlighter1.SetHighlightColor(Me.btn_del, CType(resources.GetObject("btn_del.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.btn_del, CType(resources.GetObject("btn_del.HighlightOnFocus"), Boolean))
        Me.btn_del.ImageOptions.Image = CType(resources.GetObject("btn_del.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_del.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_del.Name = "btn_del"
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
        'btn_save
        '
        resources.ApplyResources(Me.btn_save, "btn_save")
        Me.Highlighter1.SetHighlightColor(Me.btn_save, CType(resources.GetObject("btn_save.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.btn_save, CType(resources.GetObject("btn_save.HighlightOnFocus"), Boolean))
        Me.btn_save.ImageOptions.Image = CType(resources.GetObject("btn_save.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_save.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_save.Name = "btn_save"
        '
        'PanelControl1
        '
        resources.ApplyResources(Me.PanelControl1, "PanelControl1")
        Me.PanelControl1.Controls.Add(Me.lblDivision)
        Me.PanelControl1.Controls.Add(Me.cboDivision)
        Me.PanelControl1.Controls.Add(Me.txtDeptId)
        Me.PanelControl1.Controls.Add(Me.lblDepartment)
        Me.PanelControl1.Controls.Add(Me.txtDepartment)
        Me.PanelControl1.Controls.Add(Me.lblDeptId)
        Me.Highlighter1.SetHighlightColor(Me.PanelControl1, CType(resources.GetObject("PanelControl1.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.PanelControl1, CType(resources.GetObject("PanelControl1.HighlightOnFocus"), Boolean))
        Me.PanelControl1.Name = "PanelControl1"
        '
        'lblDivision
        '
        resources.ApplyResources(Me.lblDivision, "lblDivision")
        Me.Highlighter1.SetHighlightColor(Me.lblDivision, CType(resources.GetObject("lblDivision.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.lblDivision, CType(resources.GetObject("lblDivision.HighlightOnFocus"), Boolean))
        Me.lblDivision.Name = "lblDivision"
        '
        'cboDivision
        '
        resources.ApplyResources(Me.cboDivision, "cboDivision")
        Me.cboDivision.EnterMoveNextControl = True
        Me.Highlighter1.SetHighlightColor(Me.cboDivision, CType(resources.GetObject("cboDivision.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.cboDivision, CType(resources.GetObject("cboDivision.HighlightOnFocus"), Boolean))
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
        'txtDeptId
        '
        resources.ApplyResources(Me.txtDeptId, "txtDeptId")
        Me.txtDeptId.EnterMoveNextControl = True
        Me.Highlighter1.SetHighlightColor(Me.txtDeptId, CType(resources.GetObject("txtDeptId.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.txtDeptId, CType(resources.GetObject("txtDeptId.HighlightOnFocus"), Boolean))
        Me.txtDeptId.Name = "txtDeptId"
        Me.txtDeptId.Properties.AccessibleDescription = resources.GetString("txtDeptId.Properties.AccessibleDescription")
        Me.txtDeptId.Properties.AccessibleName = resources.GetString("txtDeptId.Properties.AccessibleName")
        Me.txtDeptId.Properties.AutoHeight = CType(resources.GetObject("txtDeptId.Properties.AutoHeight"), Boolean)
        Me.txtDeptId.Properties.Mask.AutoComplete = CType(resources.GetObject("txtDeptId.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDeptId.Properties.Mask.BeepOnError = CType(resources.GetObject("txtDeptId.Properties.Mask.BeepOnError"), Boolean)
        Me.txtDeptId.Properties.Mask.EditMask = resources.GetString("txtDeptId.Properties.Mask.EditMask")
        Me.txtDeptId.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDeptId.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDeptId.Properties.Mask.MaskType = CType(resources.GetObject("txtDeptId.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDeptId.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtDeptId.Properties.Mask.PlaceHolder"), Char)
        Me.txtDeptId.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtDeptId.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtDeptId.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDeptId.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDeptId.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDeptId.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDeptId.Properties.NullValuePrompt = resources.GetString("txtDeptId.Properties.NullValuePrompt")
        Me.txtDeptId.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtDeptId.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'lblDepartment
        '
        resources.ApplyResources(Me.lblDepartment, "lblDepartment")
        Me.Highlighter1.SetHighlightColor(Me.lblDepartment, CType(resources.GetObject("lblDepartment.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.lblDepartment, CType(resources.GetObject("lblDepartment.HighlightOnFocus"), Boolean))
        Me.lblDepartment.Name = "lblDepartment"
        '
        'txtDepartment
        '
        resources.ApplyResources(Me.txtDepartment, "txtDepartment")
        Me.txtDepartment.EnterMoveNextControl = True
        Me.Highlighter1.SetHighlightColor(Me.txtDepartment, CType(resources.GetObject("txtDepartment.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.txtDepartment, CType(resources.GetObject("txtDepartment.HighlightOnFocus"), Boolean))
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
        '
        'lblDeptId
        '
        resources.ApplyResources(Me.lblDeptId, "lblDeptId")
        Me.Highlighter1.SetHighlightColor(Me.lblDeptId, CType(resources.GetObject("lblDeptId.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.lblDeptId, CType(resources.GetObject("lblDeptId.HighlightOnFocus"), Boolean))
        Me.lblDeptId.Name = "lblDeptId"
        '
        'frmDepartment
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GcHoliday)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_Edit)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Highlighter1.SetHighlightColor(Me, CType(resources.GetObject("$this.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me, CType(resources.GetObject("$this.HighlightOnFocus"), Boolean))
        Me.Name = "frmDepartment"
        CType(Me.GcHoliday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvHoliday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeptId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GcHoliday As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvHoliday As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colrow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldateyear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldaystop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colremarkyear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cboTransport_detail As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboUnitName As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lblDepartment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDeptId As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDepartment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeptId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_exit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_clear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_del As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblDivision As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboDivision As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
