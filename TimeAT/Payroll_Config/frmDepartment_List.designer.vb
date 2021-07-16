<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDepartment_List
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepartment_List))
        Me.GcHoliday = New DevExpress.XtraGrid.GridControl()
        Me.GvHoliday = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldateyear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldaystop = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colremarkyear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cboTransport_detail = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboUnitName = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btn_exit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GcHoliday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvHoliday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        '
        'GridColumn1
        '
        resources.ApplyResources(Me.GridColumn1, "GridColumn1")
        Me.GridColumn1.FieldName = "Division"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
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
        Me.btn_exit.ImageOptions.Image = CType(resources.GetObject("btn_exit.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_exit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_exit.Name = "btn_exit"
        '
        'frmDepartment_List
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.GcHoliday)
        Me.Name = "frmDepartment_List"
        CType(Me.GcHoliday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvHoliday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GcHoliday As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvHoliday As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colrow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldateyear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldaystop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colremarkyear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cboTransport_detail As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboUnitName As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btn_exit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
