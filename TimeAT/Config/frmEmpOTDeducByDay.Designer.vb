﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmpOTDeducByDay
    'Inherits System.Windows.Forms.Form
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpOTDeducByDay))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.grpLeft = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtOT = New DevExpress.XtraEditors.TextEdit()
        Me.btnRefreshF = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.GcEmp = New DevExpress.XtraGrid.GridControl()
        Me.GvEmp = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colempcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_department = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cboTransport_detail = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboUnitName = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboDivision = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboDepartment = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.rdByDeptName = New System.Windows.Forms.RadioButton()
        Me.rdByCode = New System.Windows.Forms.RadioButton()
        Me.rdByDeptCode = New System.Windows.Forms.RadioButton()
        Me.rdByName = New System.Windows.Forms.RadioButton()
        Me.grpRight = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btnDeleteOT = New DevExpress.XtraEditors.SimpleButton()
        Me.GcEmp_OT = New DevExpress.XtraGrid.GridControl()
        Me.GvEmp_OT = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btnRefreshOT = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.rdByDeptName_Date = New System.Windows.Forms.RadioButton()
        Me.rdByName_Date = New System.Windows.Forms.RadioButton()
        Me.rdByDeptCode_Date = New System.Windows.Forms.RadioButton()
        Me.rdByCode_Date = New System.Windows.Forms.RadioButton()
        Me.cboDepartment_Cal = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboDivision_Cal = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtDate = New DevExpress.XtraEditors.DateEdit()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.ProgressBarX1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.pnlApp = New System.Windows.Forms.Panel()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.grpLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLeft.SuspendLayout()
        CType(Me.txtOT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grpRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRight.SuspendLayout()
        CType(Me.GcEmp_OT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvEmp_OT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.cboDepartment_Cal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDivision_Cal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHead.SuspendLayout()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainerControl1.SplitterPosition = 630
        '
        'grpLeft
        '
        resources.ApplyResources(Me.grpLeft, "grpLeft")
        Me.grpLeft.Controls.Add(Me.LabelControl2)
        Me.grpLeft.Controls.Add(Me.LabelControl7)
        Me.grpLeft.Controls.Add(Me.LabelControl6)
        Me.grpLeft.Controls.Add(Me.LabelControl1)
        Me.grpLeft.Controls.Add(Me.txtOT)
        Me.grpLeft.Controls.Add(Me.btnRefreshF)
        Me.grpLeft.Controls.Add(Me.btnSave)
        Me.grpLeft.Controls.Add(Me.GcEmp)
        Me.grpLeft.Controls.Add(Me.cboDivision)
        Me.grpLeft.Controls.Add(Me.cboDepartment)
        Me.grpLeft.Controls.Add(Me.GroupControl1)
        Me.grpLeft.Name = "grpLeft"
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
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
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        '
        'txtOT
        '
        resources.ApplyResources(Me.txtOT, "txtOT")
        Me.txtOT.EnterMoveNextControl = True
        Me.txtOT.Name = "txtOT"
        Me.txtOT.Properties.AccessibleDescription = resources.GetString("txtOT.Properties.AccessibleDescription")
        Me.txtOT.Properties.AccessibleName = resources.GetString("txtOT.Properties.AccessibleName")
        Me.txtOT.Properties.AutoHeight = CType(resources.GetObject("txtOT.Properties.AutoHeight"), Boolean)
        Me.txtOT.Properties.Mask.AutoComplete = CType(resources.GetObject("txtOT.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtOT.Properties.Mask.BeepOnError = CType(resources.GetObject("txtOT.Properties.Mask.BeepOnError"), Boolean)
        Me.txtOT.Properties.Mask.EditMask = resources.GetString("txtOT.Properties.Mask.EditMask")
        Me.txtOT.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtOT.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtOT.Properties.Mask.MaskType = CType(resources.GetObject("txtOT.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtOT.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtOT.Properties.Mask.PlaceHolder"), Char)
        Me.txtOT.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtOT.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtOT.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtOT.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtOT.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtOT.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtOT.Properties.NullValuePrompt = resources.GetString("txtOT.Properties.NullValuePrompt")
        Me.txtOT.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtOT.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'btnRefreshF
        '
        resources.ApplyResources(Me.btnRefreshF, "btnRefreshF")
        Me.btnRefreshF.Appearance.Font = CType(resources.GetObject("btnRefreshF.Appearance.Font"), System.Drawing.Font)
        Me.btnRefreshF.Appearance.FontSizeDelta = CType(resources.GetObject("btnRefreshF.Appearance.FontSizeDelta"), Integer)
        Me.btnRefreshF.Appearance.FontStyleDelta = CType(resources.GetObject("btnRefreshF.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.btnRefreshF.Appearance.GradientMode = CType(resources.GetObject("btnRefreshF.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.btnRefreshF.Appearance.Image = CType(resources.GetObject("btnRefreshF.Appearance.Image"), System.Drawing.Image)
        Me.btnRefreshF.Appearance.Options.UseFont = True
        Me.btnRefreshF.ImageOptions.Image = CType(resources.GetObject("btnRefreshF.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefreshF.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnRefreshF.Name = "btnRefreshF"
        '
        'btnSave
        '
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnSave.Name = "btnSave"
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
        Me.GvEmp.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colrow, Me.colempcode, Me.colProductName, Me.collname, Me.GridColumn7, Me.col_department, Me.GridColumn8})
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
        'GridColumn8
        '
        resources.ApplyResources(Me.GridColumn8, "GridColumn8")
        Me.GridColumn8.FieldName = "Position"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
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
        'grpRight
        '
        resources.ApplyResources(Me.grpRight, "grpRight")
        Me.grpRight.Controls.Add(Me.LabelControl5)
        Me.grpRight.Controls.Add(Me.LabelControl4)
        Me.grpRight.Controls.Add(Me.btnDeleteOT)
        Me.grpRight.Controls.Add(Me.GcEmp_OT)
        Me.grpRight.Controls.Add(Me.LabelControl3)
        Me.grpRight.Controls.Add(Me.btnRefreshOT)
        Me.grpRight.Controls.Add(Me.GroupControl4)
        Me.grpRight.Controls.Add(Me.cboDepartment_Cal)
        Me.grpRight.Controls.Add(Me.cboDivision_Cal)
        Me.grpRight.Controls.Add(Me.txtDate)
        Me.grpRight.Name = "grpRight"
        '
        'LabelControl5
        '
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Name = "LabelControl5"
        '
        'LabelControl4
        '
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Name = "LabelControl4"
        '
        'btnDeleteOT
        '
        resources.ApplyResources(Me.btnDeleteOT, "btnDeleteOT")
        Me.btnDeleteOT.ImageOptions.Image = CType(resources.GetObject("btnDeleteOT.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDeleteOT.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnDeleteOT.Name = "btnDeleteOT"
        '
        'GcEmp_OT
        '
        resources.ApplyResources(Me.GcEmp_OT, "GcEmp_OT")
        Me.GcEmp_OT.EmbeddedNavigator.AccessibleDescription = resources.GetString("GcEmp_OT.EmbeddedNavigator.AccessibleDescription")
        Me.GcEmp_OT.EmbeddedNavigator.AccessibleName = resources.GetString("GcEmp_OT.EmbeddedNavigator.AccessibleName")
        Me.GcEmp_OT.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GcEmp_OT.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GcEmp_OT.EmbeddedNavigator.Anchor = CType(resources.GetObject("GcEmp_OT.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GcEmp_OT.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GcEmp_OT.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GcEmp_OT.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GcEmp_OT.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GcEmp_OT.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GcEmp_OT.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GcEmp_OT.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GcEmp_OT.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GcEmp_OT.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GcEmp_OT.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GcEmp_OT.EmbeddedNavigator.ToolTip = resources.GetString("GcEmp_OT.EmbeddedNavigator.ToolTip")
        Me.GcEmp_OT.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GcEmp_OT.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GcEmp_OT.EmbeddedNavigator.ToolTipTitle = resources.GetString("GcEmp_OT.EmbeddedNavigator.ToolTipTitle")
        Me.GcEmp_OT.MainView = Me.GvEmp_OT
        Me.GcEmp_OT.Name = "GcEmp_OT"
        Me.GcEmp_OT.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.GcEmp_OT.TabStop = False
        Me.GcEmp_OT.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvEmp_OT})
        '
        'GvEmp_OT
        '
        Me.GvEmp_OT.Appearance.HeaderPanel.Font = CType(resources.GetObject("GvEmp_OT.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GvEmp_OT.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GvEmp_OT.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GvEmp_OT.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GvEmp_OT.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GvEmp_OT.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GvEmp_OT.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GvEmp_OT.Appearance.HeaderPanel.Image = CType(resources.GetObject("GvEmp_OT.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GvEmp_OT.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvEmp_OT.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GvEmp_OT.Appearance.Row.FontSizeDelta"), Integer)
        Me.GvEmp_OT.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GvEmp_OT.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GvEmp_OT.Appearance.Row.GradientMode = CType(resources.GetObject("GvEmp_OT.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GvEmp_OT.Appearance.Row.Image = CType(resources.GetObject("GvEmp_OT.Appearance.Row.Image"), System.Drawing.Image)
        Me.GvEmp_OT.Appearance.Row.Options.UseFont = True
        resources.ApplyResources(Me.GvEmp_OT, "GvEmp_OT")
        Me.GvEmp_OT.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn6, Me.GridColumn9, Me.GridColumn5, Me.GridColumn10})
        Me.GvEmp_OT.GridControl = Me.GcEmp_OT
        Me.GvEmp_OT.Name = "GvEmp_OT"
        Me.GvEmp_OT.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.GvEmp_OT.OptionsSelection.MultiSelect = True
        Me.GvEmp_OT.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GvEmp_OT.OptionsView.ColumnAutoWidth = False
        Me.GvEmp_OT.OptionsView.ShowAutoFilterRow = True
        Me.GvEmp_OT.OptionsView.ShowGroupPanel = False
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
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GridColumn6.AppearanceCell.FontSizeDelta"), Integer)
        Me.GridColumn6.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GridColumn6.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridColumn6.AppearanceCell.GradientMode = CType(resources.GetObject("GridColumn6.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn6.AppearanceCell.Image = CType(resources.GetObject("GridColumn6.AppearanceCell.Image"), System.Drawing.Image)
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn6.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GridColumn6.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GridColumn6.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GridColumn6.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridColumn6.AppearanceHeader.GradientMode = CType(resources.GetObject("GridColumn6.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn6.AppearanceHeader.Image = CType(resources.GetObject("GridColumn6.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn6, "GridColumn6")
        Me.GridColumn6.FieldName = "OT"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn9
        '
        resources.ApplyResources(Me.GridColumn9, "GridColumn9")
        Me.GridColumn9.FieldName = "Division"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        '
        'GridColumn5
        '
        resources.ApplyResources(Me.GridColumn5, "GridColumn5")
        Me.GridColumn5.FieldName = "Department"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        '
        'GridColumn10
        '
        resources.ApplyResources(Me.GridColumn10, "GridColumn10")
        Me.GridColumn10.FieldName = "Position"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.OptionsColumn.ReadOnly = True
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
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        '
        'btnRefreshOT
        '
        resources.ApplyResources(Me.btnRefreshOT, "btnRefreshOT")
        Me.btnRefreshOT.Appearance.Font = CType(resources.GetObject("btnRefreshOT.Appearance.Font"), System.Drawing.Font)
        Me.btnRefreshOT.Appearance.FontSizeDelta = CType(resources.GetObject("btnRefreshOT.Appearance.FontSizeDelta"), Integer)
        Me.btnRefreshOT.Appearance.FontStyleDelta = CType(resources.GetObject("btnRefreshOT.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.btnRefreshOT.Appearance.GradientMode = CType(resources.GetObject("btnRefreshOT.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.btnRefreshOT.Appearance.Image = CType(resources.GetObject("btnRefreshOT.Appearance.Image"), System.Drawing.Image)
        Me.btnRefreshOT.Appearance.Options.UseFont = True
        Me.btnRefreshOT.ImageOptions.Image = CType(resources.GetObject("btnRefreshOT.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefreshOT.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnRefreshOT.Name = "btnRefreshOT"
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
        'pnlHead
        '
        resources.ApplyResources(Me.pnlHead, "pnlHead")
        Me.pnlHead.Controls.Add(Me.btnExit)
        Me.pnlHead.Controls.Add(Me.ProgressBarX1)
        Me.pnlHead.Name = "pnlHead"
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'pnlApp
        '
        resources.ApplyResources(Me.pnlApp, "pnlApp")
        Me.pnlApp.Controls.Add(Me.SplitContainerControl1)
        Me.pnlApp.Name = "pnlApp"
        '
        'frmEmpOTDeducByDay
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlApp)
        Me.Controls.Add(Me.pnlHead)
        Me.Name = "frmEmpOTDeducByDay"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.grpLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLeft.ResumeLayout(False)
        Me.grpLeft.PerformLayout()
        CType(Me.txtOT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.grpRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRight.ResumeLayout(False)
        Me.grpRight.PerformLayout()
        CType(Me.GcEmp_OT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvEmp_OT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.cboDepartment_Cal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDivision_Cal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHead.ResumeLayout(False)
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlApp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rdByDeptName As System.Windows.Forms.RadioButton
    Friend WithEvents rdByDeptCode As System.Windows.Forms.RadioButton
    Friend WithEvents rdByName As System.Windows.Forms.RadioButton
    Friend WithEvents rdByCode As System.Windows.Forms.RadioButton
    Friend WithEvents PanelEx5 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents cboDivision As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboDepartment As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnRefreshF As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents ProgressBarX1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents txtDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtOT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GcEmp_OT As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvEmp_OT As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDeleteOT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRefreshOT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlHead As Panel
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents pnlApp As Panel
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents grpLeft As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpRight As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdByDeptName_Date As RadioButton
    Friend WithEvents rdByName_Date As RadioButton
    Friend WithEvents rdByDeptCode_Date As RadioButton
    Friend WithEvents rdByCode_Date As RadioButton
    Friend WithEvents cboDepartment_Cal As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboDivision_Cal As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
End Class
