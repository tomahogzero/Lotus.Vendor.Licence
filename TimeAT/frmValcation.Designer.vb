<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVacation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVacation))
        Me.cboWorkingStatus = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtAmtRemain = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.txtYear = New DevExpress.XtraEditors.TextEdit()
        Me.rdAll = New System.Windows.Forms.RadioButton()
        Me.rdYear = New System.Windows.Forms.RadioButton()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblValCode = New System.Windows.Forms.Label()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDay = New DevExpress.XtraEditors.TextEdit()
        Me.txtAmt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.rdSpa_Between = New System.Windows.Forms.RadioButton()
        Me.rdSpa_IO_In = New System.Windows.Forms.RadioButton()
        Me.btnToDate = New DevExpress.XtraEditors.SimpleButton()
        Me.rdByRange = New System.Windows.Forms.RadioButton()
        Me.txtDateSP = New DevExpress.XtraEditors.DateEdit()
        Me.rdByDay = New System.Windows.Forms.RadioButton()
        Me.txtDateST = New DevExpress.XtraEditors.DateEdit()
        Me.txtDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.rdAfternoon = New System.Windows.Forms.RadioButton()
        Me.rdMorning = New System.Windows.Forms.RadioButton()
        Me.rdSpa = New System.Windows.Forms.RadioButton()
        Me.rdHaftDay = New System.Windows.Forms.RadioButton()
        Me.rdFullDay = New System.Windows.Forms.RadioButton()
        Me.GcVacation = New DevExpress.XtraGrid.GridControl()
        Me.GvVacation = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colempcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_department = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cboTransport_detail = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboUnitName = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.pnlDedug = New System.Windows.Forms.Panel()
        Me.lstVacation = New System.Windows.Forms.ListView()
        Me.colNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAmt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colFullDay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colHaftDay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSpa_IO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDepartment = New DevExpress.XtraEditors.TextEdit()
        Me.txtDeptId = New DevExpress.XtraEditors.TextEdit()
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete_Sel = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.tbVacationHaftDay = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.rdSpa_IO_Out = New System.Windows.Forms.RadioButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemark = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.cboWorkingStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmtRemain.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateSP.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateSP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateST.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcVacation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvVacation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeptId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.tbVacationHaftDay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbVacationHaftDay.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboWorkingStatus
        '
        Me.cboWorkingStatus.EnterMoveNextControl = True
        resources.ApplyResources(Me.cboWorkingStatus, "cboWorkingStatus")
        Me.cboWorkingStatus.Name = "cboWorkingStatus"
        Me.cboWorkingStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboWorkingStatus.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboWorkingStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("cboWorkingStatus.Properties.Columns"), resources.GetString("cboWorkingStatus.Properties.Columns1"))})
        Me.cboWorkingStatus.Properties.NullText = resources.GetString("cboWorkingStatus.Properties.NullText")
        Me.cboWorkingStatus.Properties.ShowHeader = False
        '
        'txtAmtRemain
        '
        resources.ApplyResources(Me.txtAmtRemain, "txtAmtRemain")
        Me.txtAmtRemain.Name = "txtAmtRemain"
        Me.txtAmtRemain.Properties.ReadOnly = True
        '
        'LabelControl8
        '
        resources.ApplyResources(Me.LabelControl8, "LabelControl8")
        Me.LabelControl8.Name = "LabelControl8"
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        '
        'GroupControl7
        '
        resources.ApplyResources(Me.GroupControl7, "GroupControl7")
        Me.GroupControl7.Controls.Add(Me.txtYear)
        Me.GroupControl7.Controls.Add(Me.rdAll)
        Me.GroupControl7.Controls.Add(Me.rdYear)
        Me.GroupControl7.Controls.Add(Me.lblId)
        Me.GroupControl7.Controls.Add(Me.lblValCode)
        Me.GroupControl7.Controls.Add(Me.btnRefresh)
        Me.GroupControl7.Name = "GroupControl7"
        '
        'txtYear
        '
        resources.ApplyResources(Me.txtYear, "txtYear")
        Me.txtYear.Name = "txtYear"
        '
        'rdAll
        '
        resources.ApplyResources(Me.rdAll, "rdAll")
        Me.rdAll.Name = "rdAll"
        Me.rdAll.UseVisualStyleBackColor = True
        '
        'rdYear
        '
        resources.ApplyResources(Me.rdYear, "rdYear")
        Me.rdYear.Checked = True
        Me.rdYear.Name = "rdYear"
        Me.rdYear.TabStop = True
        Me.rdYear.UseVisualStyleBackColor = True
        '
        'lblId
        '
        Me.lblId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.lblId, "lblId")
        Me.lblId.Name = "lblId"
        '
        'lblValCode
        '
        Me.lblValCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.lblValCode, "lblValCode")
        Me.lblValCode.Name = "lblValCode"
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
        'txtDay
        '
        resources.ApplyResources(Me.txtDay, "txtDay")
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Properties.ReadOnly = True
        '
        'txtAmt
        '
        resources.ApplyResources(Me.txtAmt, "txtAmt")
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Properties.ReadOnly = True
        '
        'LabelControl11
        '
        resources.ApplyResources(Me.LabelControl11, "LabelControl11")
        Me.LabelControl11.Name = "LabelControl11"
        '
        'LabelControl10
        '
        resources.ApplyResources(Me.LabelControl10, "LabelControl10")
        Me.LabelControl10.Name = "LabelControl10"
        '
        'LabelControl9
        '
        resources.ApplyResources(Me.LabelControl9, "LabelControl9")
        Me.LabelControl9.Name = "LabelControl9"
        '
        'rdSpa_Between
        '
        resources.ApplyResources(Me.rdSpa_Between, "rdSpa_Between")
        Me.rdSpa_Between.Name = "rdSpa_Between"
        Me.rdSpa_Between.UseVisualStyleBackColor = True
        '
        'rdSpa_IO_In
        '
        resources.ApplyResources(Me.rdSpa_IO_In, "rdSpa_IO_In")
        Me.rdSpa_IO_In.Checked = True
        Me.rdSpa_IO_In.Name = "rdSpa_IO_In"
        Me.rdSpa_IO_In.TabStop = True
        Me.rdSpa_IO_In.UseVisualStyleBackColor = True
        '
        'btnToDate
        '
        resources.ApplyResources(Me.btnToDate, "btnToDate")
        Me.btnToDate.Name = "btnToDate"
        '
        'rdByRange
        '
        resources.ApplyResources(Me.rdByRange, "rdByRange")
        Me.rdByRange.Name = "rdByRange"
        Me.rdByRange.UseVisualStyleBackColor = True
        '
        'txtDateSP
        '
        resources.ApplyResources(Me.txtDateSP, "txtDateSP")
        Me.txtDateSP.EnterMoveNextControl = True
        Me.txtDateSP.Name = "txtDateSP"
        Me.txtDateSP.Properties.Appearance.Options.UseFont = True
        Me.txtDateSP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateSP.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateSP.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateSP.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateSP.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtDateSP.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDateSP.Properties.Mask.EditMask = resources.GetString("txtDateSP.Properties.Mask.EditMask")
        Me.txtDateSP.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDateSP.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        '
        'rdByDay
        '
        resources.ApplyResources(Me.rdByDay, "rdByDay")
        Me.rdByDay.Checked = True
        Me.rdByDay.Name = "rdByDay"
        Me.rdByDay.TabStop = True
        Me.rdByDay.UseVisualStyleBackColor = True
        '
        'txtDateST
        '
        resources.ApplyResources(Me.txtDateST, "txtDateST")
        Me.txtDateST.EnterMoveNextControl = True
        Me.txtDateST.Name = "txtDateST"
        Me.txtDateST.Properties.Appearance.Options.UseFont = True
        Me.txtDateST.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateST.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateST.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateST.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateST.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtDateST.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDateST.Properties.Mask.EditMask = resources.GetString("txtDateST.Properties.Mask.EditMask")
        Me.txtDateST.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDateST.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        '
        'txtDate
        '
        resources.ApplyResources(Me.txtDate, "txtDate")
        Me.txtDate.EnterMoveNextControl = True
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Properties.Appearance.Options.UseFont = True
        Me.txtDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDate.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDate.Properties.Mask.EditMask = resources.GetString("txtDate.Properties.Mask.EditMask")
        Me.txtDate.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDate.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
        'rdAfternoon
        '
        resources.ApplyResources(Me.rdAfternoon, "rdAfternoon")
        Me.rdAfternoon.Name = "rdAfternoon"
        Me.rdAfternoon.UseVisualStyleBackColor = True
        '
        'rdMorning
        '
        resources.ApplyResources(Me.rdMorning, "rdMorning")
        Me.rdMorning.Checked = True
        Me.rdMorning.Name = "rdMorning"
        Me.rdMorning.TabStop = True
        Me.rdMorning.UseVisualStyleBackColor = True
        '
        'rdSpa
        '
        resources.ApplyResources(Me.rdSpa, "rdSpa")
        Me.rdSpa.Name = "rdSpa"
        Me.rdSpa.UseVisualStyleBackColor = True
        '
        'rdHaftDay
        '
        resources.ApplyResources(Me.rdHaftDay, "rdHaftDay")
        Me.rdHaftDay.Name = "rdHaftDay"
        Me.rdHaftDay.UseVisualStyleBackColor = True
        '
        'rdFullDay
        '
        resources.ApplyResources(Me.rdFullDay, "rdFullDay")
        Me.rdFullDay.Checked = True
        Me.rdFullDay.Name = "rdFullDay"
        Me.rdFullDay.TabStop = True
        Me.rdFullDay.UseVisualStyleBackColor = True
        '
        'GcVacation
        '
        resources.ApplyResources(Me.GcVacation, "GcVacation")
        Me.GcVacation.MainView = Me.GvVacation
        Me.GcVacation.Name = "GcVacation"
        Me.GcVacation.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.BtnDel, Me.cboTransport_detail, Me.cboUnitName})
        Me.GcVacation.TabStop = False
        Me.GcVacation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvVacation})
        '
        'GvVacation
        '
        Me.GvVacation.Appearance.HeaderPanel.Font = CType(resources.GetObject("GvVacation.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GvVacation.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvVacation.Appearance.Row.Options.UseFont = True
        Me.GvVacation.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colrow, Me.GridColumn4, Me.GridColumn1, Me.GridColumn2, Me.colempcode, Me.colProductName, Me.collname, Me.col_department, Me.GridColumn3, Me.GridColumn5})
        Me.GvVacation.GridControl = Me.GcVacation
        Me.GvVacation.Name = "GvVacation"
        Me.GvVacation.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.GvVacation.OptionsSelection.MultiSelect = True
        Me.GvVacation.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GvVacation.OptionsView.ColumnAutoWidth = False
        Me.GvVacation.OptionsView.ShowAutoFilterRow = True
        Me.GvVacation.OptionsView.ShowGroupPanel = False
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
        'GridColumn4
        '
        resources.ApplyResources(Me.GridColumn4, "GridColumn4")
        Me.GridColumn4.FieldName = "Id"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn1
        '
        resources.ApplyResources(Me.GridColumn1, "GridColumn1")
        Me.GridColumn1.FieldName = "ValId"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn2, "GridColumn2")
        Me.GridColumn2.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "ValDate"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        '
        'colempcode
        '
        resources.ApplyResources(Me.colempcode, "colempcode")
        Me.colempcode.FieldName = "Description"
        Me.colempcode.Name = "colempcode"
        Me.colempcode.OptionsColumn.AllowEdit = False
        '
        'colProductName
        '
        Me.colProductName.AppearanceCell.Options.UseTextOptions = True
        Me.colProductName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colProductName.AppearanceHeader.Options.UseTextOptions = True
        Me.colProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colProductName, "colProductName")
        Me.colProductName.FieldName = "Amt"
        Me.colProductName.Name = "colProductName"
        Me.colProductName.OptionsColumn.AllowEdit = False
        '
        'collname
        '
        Me.collname.AppearanceCell.Options.UseTextOptions = True
        Me.collname.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.collname.AppearanceHeader.Options.UseTextOptions = True
        Me.collname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.collname, "collname")
        Me.collname.FieldName = "fullday_str"
        Me.collname.Name = "collname"
        Me.collname.OptionsColumn.AllowEdit = False
        '
        'col_department
        '
        Me.col_department.AppearanceCell.Options.UseTextOptions = True
        Me.col_department.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_department.AppearanceHeader.Options.UseTextOptions = True
        Me.col_department.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.col_department, "col_department")
        Me.col_department.FieldName = "halfday_str"
        Me.col_department.Name = "col_department"
        Me.col_department.OptionsColumn.AllowEdit = False
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn3, "GridColumn3")
        Me.GridColumn3.FieldName = "spa_str"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        '
        'GridColumn5
        '
        resources.ApplyResources(Me.GridColumn5, "GridColumn5")
        Me.GridColumn5.FieldName = "remark"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
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
        'pnlDedug
        '
        resources.ApplyResources(Me.pnlDedug, "pnlDedug")
        Me.pnlDedug.Name = "pnlDedug"
        '
        'lstVacation
        '
        resources.ApplyResources(Me.lstVacation, "lstVacation")
        Me.lstVacation.CheckBoxes = True
        Me.lstVacation.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNo, Me.colId, Me.colDate, Me.colTime, Me.colAmt, Me.colFullDay, Me.colHaftDay, Me.colSpa_IO})
        Me.lstVacation.FullRowSelect = True
        Me.lstVacation.GridLines = True
        Me.lstVacation.Name = "lstVacation"
        Me.lstVacation.UseCompatibleStateImageBehavior = False
        Me.lstVacation.View = System.Windows.Forms.View.Details
        '
        'colNo
        '
        resources.ApplyResources(Me.colNo, "colNo")
        '
        'colId
        '
        resources.ApplyResources(Me.colId, "colId")
        '
        'colDate
        '
        resources.ApplyResources(Me.colDate, "colDate")
        '
        'colTime
        '
        resources.ApplyResources(Me.colTime, "colTime")
        '
        'colAmt
        '
        resources.ApplyResources(Me.colAmt, "colAmt")
        '
        'colFullDay
        '
        resources.ApplyResources(Me.colFullDay, "colFullDay")
        '
        'colHaftDay
        '
        resources.ApplyResources(Me.colHaftDay, "colHaftDay")
        '
        'colSpa_IO
        '
        resources.ApplyResources(Me.colSpa_IO, "colSpa_IO")
        '
        'PanelControl1
        '
        resources.ApplyResources(Me.PanelControl1, "PanelControl1")
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.txtDepartment)
        Me.PanelControl1.Controls.Add(Me.txtDeptId)
        Me.PanelControl1.Controls.Add(Me.txtName)
        Me.PanelControl1.Controls.Add(Me.txtCode)
        Me.PanelControl1.Name = "PanelControl1"
        '
        'LabelControl6
        '
        resources.ApplyResources(Me.LabelControl6, "LabelControl6")
        Me.LabelControl6.Name = "LabelControl6"
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
        'txtDepartment
        '
        resources.ApplyResources(Me.txtDepartment, "txtDepartment")
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Properties.ReadOnly = True
        Me.txtDepartment.TabStop = False
        '
        'txtDeptId
        '
        resources.ApplyResources(Me.txtDeptId, "txtDeptId")
        Me.txtDeptId.Name = "txtDeptId"
        Me.txtDeptId.Properties.ReadOnly = True
        Me.txtDeptId.TabStop = False
        '
        'txtName
        '
        resources.ApplyResources(Me.txtName, "txtName")
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.ReadOnly = True
        Me.txtName.TabStop = False
        '
        'txtCode
        '
        resources.ApplyResources(Me.txtCode, "txtCode")
        Me.txtCode.Name = "txtCode"
        '
        'btnExit
        '
        Me.btnExit.ImageOptions.Image = CType(resources.GetObject("btnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.Name = "btnExit"
        '
        'btnClear
        '
        Me.btnClear.ImageOptions.Image = CType(resources.GetObject("btnClear.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClear.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnClear, "btnClear")
        Me.btnClear.Name = "btnClear"
        '
        'btnDelete
        '
        Me.btnDelete.ImageOptions.Image = CType(resources.GetObject("btnDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnDelete, "btnDelete")
        Me.btnDelete.Name = "btnDelete"
        '
        'btnEdit
        '
        Me.btnEdit.ImageOptions.Image = CType(resources.GetObject("btnEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnEdit, "btnEdit")
        Me.btnEdit.Name = "btnEdit"
        '
        'btnAdd
        '
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("btnAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        Me.btnAdd.Name = "btnAdd"
        '
        'btnDelete_Sel
        '
        Me.btnDelete_Sel.ImageOptions.Image = CType(resources.GetObject("btnDelete_Sel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelete_Sel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnDelete_Sel, "btnDelete_Sel")
        Me.btnDelete_Sel.Name = "btnDelete_Sel"
        '
        'LabelControl13
        '
        resources.ApplyResources(Me.LabelControl13, "LabelControl13")
        Me.LabelControl13.Name = "LabelControl13"
        '
        'LabelControl16
        '
        resources.ApplyResources(Me.LabelControl16, "LabelControl16")
        Me.LabelControl16.Name = "LabelControl16"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnToDate)
        Me.PanelControl2.Controls.Add(Me.rdByDay)
        Me.PanelControl2.Controls.Add(Me.txtDateST)
        Me.PanelControl2.Controls.Add(Me.rdByRange)
        Me.PanelControl2.Controls.Add(Me.txtDate)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.txtDateSP)
        resources.ApplyResources(Me.PanelControl2, "PanelControl2")
        Me.PanelControl2.Name = "PanelControl2"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.rdSpa)
        Me.PanelControl3.Controls.Add(Me.rdFullDay)
        Me.PanelControl3.Controls.Add(Me.rdHaftDay)
        resources.ApplyResources(Me.PanelControl3, "PanelControl3")
        Me.PanelControl3.Name = "PanelControl3"
        '
        'tbVacationHaftDay
        '
        resources.ApplyResources(Me.tbVacationHaftDay, "tbVacationHaftDay")
        Me.tbVacationHaftDay.Name = "tbVacationHaftDay"
        Me.tbVacationHaftDay.SelectedTabPage = Me.XtraTabPage1
        Me.tbVacationHaftDay.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.rdAfternoon)
        Me.XtraTabPage1.Controls.Add(Me.rdMorning)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        resources.ApplyResources(Me.XtraTabPage1, "XtraTabPage1")
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.rdSpa_Between)
        Me.XtraTabPage2.Controls.Add(Me.rdSpa_IO_Out)
        Me.XtraTabPage2.Controls.Add(Me.rdSpa_IO_In)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        resources.ApplyResources(Me.XtraTabPage2, "XtraTabPage2")
        '
        'rdSpa_IO_Out
        '
        resources.ApplyResources(Me.rdSpa_IO_Out, "rdSpa_IO_Out")
        Me.rdSpa_IO_Out.Name = "rdSpa_IO_Out"
        Me.rdSpa_IO_Out.UseVisualStyleBackColor = True
        '
        'LabelControl7
        '
        resources.ApplyResources(Me.LabelControl7, "LabelControl7")
        Me.LabelControl7.Name = "LabelControl7"
        '
        'LabelControl12
        '
        resources.ApplyResources(Me.LabelControl12, "LabelControl12")
        Me.LabelControl12.Name = "LabelControl12"
        '
        'txtRemark
        '
        resources.ApplyResources(Me.txtRemark, "txtRemark")
        Me.txtRemark.Name = "txtRemark"
        '
        'LabelControl14
        '
        resources.ApplyResources(Me.LabelControl14, "LabelControl14")
        Me.LabelControl14.Name = "LabelControl14"
        '
        'LabelControl15
        '
        resources.ApplyResources(Me.LabelControl15, "LabelControl15")
        Me.LabelControl15.Name = "LabelControl15"
        '
        'frmVacation
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.tbVacationHaftDay)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.GcVacation)
        Me.Controls.Add(Me.txtAmt)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.btnDelete_Sel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cboWorkingStatus)
        Me.Controls.Add(Me.pnlDedug)
        Me.Controls.Add(Me.txtAmtRemain)
        Me.Controls.Add(Me.lstVacation)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.GroupControl7)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl13)
        Me.KeyPreview = True
        Me.Name = "frmVacation"
        CType(Me.cboWorkingStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmtRemain.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        Me.GroupControl7.PerformLayout()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateSP.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateSP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateST.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcVacation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvVacation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeptId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.tbVacationHaftDay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbVacationHaftDay.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lstVacation As System.Windows.Forms.ListView
    Friend WithEvents colNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents rdAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdYear As System.Windows.Forms.RadioButton
    Friend WithEvents lblValCode As System.Windows.Forms.Label
    Friend WithEvents colAmt As System.Windows.Forms.ColumnHeader
    Friend WithEvents colId As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlDedug As System.Windows.Forms.Panel
    Friend WithEvents rdHaftDay As System.Windows.Forms.RadioButton
    Friend WithEvents rdFullDay As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents rdAfternoon As System.Windows.Forms.RadioButton
    Friend WithEvents rdMorning As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rdSpa As System.Windows.Forms.RadioButton
    Friend WithEvents colFullDay As System.Windows.Forms.ColumnHeader
    Friend WithEvents colHaftDay As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rdByRange As System.Windows.Forms.RadioButton
    Friend WithEvents rdByDay As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rdSpa_Between As System.Windows.Forms.RadioButton
    Friend WithEvents rdSpa_IO_In As System.Windows.Forms.RadioButton
    Friend WithEvents colSpa_IO As System.Windows.Forms.ColumnHeader
    Friend WithEvents GcVacation As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvVacation As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colrow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colempcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_department As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cboTransport_detail As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboUnitName As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDepartment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeptId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RdoHourOT_Null As RadioButton
    Friend WithEvents RdoHourOT_All As RadioButton
    Friend WithEvents RdoHourOT_In As RadioButton
    Friend WithEvents btnToDate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDateSP As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDateST As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmtRemain As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtYear As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete_Sel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboWorkingStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tbVacationHaftDay As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents rdSpa_IO_Out As RadioButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRemark As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
End Class
