<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditTime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditTime))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSite = New System.Windows.Forms.TextBox()
        Me.chkPreviousDay = New System.Windows.Forms.CheckBox()
        Me.chkNextDay = New System.Windows.Forms.CheckBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lstTimeEdit = New System.Windows.Forms.ListView()
        Me.colNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gcTimeEdit = New DevExpress.XtraGrid.GridControl()
        Me.gvTimeEdit = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.clNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clEmpName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDepartment = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDeptId = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        Me.txtTime = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.lblKaCode = New System.Windows.Forms.Label()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.chkTimeEndDay_NextDay = New DevExpress.XtraEditors.CheckEdit()
        Me.chkStartDay_PD = New DevExpress.XtraEditors.CheckEdit()
        Me.txtEndDay = New DevExpress.XtraEditors.TextEdit()
        Me.txtStartDay = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.chkTimeSP_NextDay = New DevExpress.XtraEditors.CheckEdit()
        Me.chkMidDayStop_NextDay = New DevExpress.XtraEditors.CheckEdit()
        Me.chkMidDayStart_NextDay = New DevExpress.XtraEditors.CheckEdit()
        Me.txtTimeSP = New DevExpress.XtraEditors.TextEdit()
        Me.chkka_flexible = New DevExpress.XtraEditors.CheckEdit()
        Me.chkka_spaical = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMidDayStop = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMidDayStart = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFlexible_Hour = New DevExpress.XtraEditors.TextEdit()
        Me.txtTimeST_to = New DevExpress.XtraEditors.TextEdit()
        Me.txtTimeST = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.chkSunday = New DevExpress.XtraEditors.CheckEdit()
        Me.chkSaturday = New DevExpress.XtraEditors.CheckEdit()
        Me.chkFriday = New DevExpress.XtraEditors.CheckEdit()
        Me.chkThursday = New DevExpress.XtraEditors.CheckEdit()
        Me.chkWednesday = New DevExpress.XtraEditors.CheckEdit()
        Me.chkTuesday = New DevExpress.XtraEditors.CheckEdit()
        Me.chkMonDay = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDelAll = New DevExpress.XtraEditors.CheckEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.gcTimeEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTimeEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeptId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.chkTimeEndDay_NextDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkStartDay_PD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStartDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTimeSP_NextDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMidDayStop_NextDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMidDayStart_NextDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTimeSP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkka_flexible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkka_spaical.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMidDayStop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMidDayStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFlexible_Hour.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTimeST_to.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTimeST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.chkSunday.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSaturday.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFriday.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkThursday.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkWednesday.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTuesday.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMonDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDelAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'txtSite
        '
        resources.ApplyResources(Me.txtSite, "txtSite")
        Me.txtSite.Name = "txtSite"
        Me.txtSite.ReadOnly = True
        Me.txtSite.TabStop = False
        '
        'chkPreviousDay
        '
        resources.ApplyResources(Me.chkPreviousDay, "chkPreviousDay")
        Me.chkPreviousDay.Name = "chkPreviousDay"
        Me.chkPreviousDay.TabStop = False
        Me.chkPreviousDay.UseVisualStyleBackColor = True
        '
        'chkNextDay
        '
        resources.ApplyResources(Me.chkNextDay, "chkNextDay")
        Me.chkNextDay.Name = "chkNextDay"
        Me.chkNextDay.TabStop = False
        Me.chkNextDay.UseVisualStyleBackColor = True
        '
        'lblId
        '
        resources.ApplyResources(Me.lblId, "lblId")
        Me.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblId.Name = "lblId"
        '
        'lstTimeEdit
        '
        resources.ApplyResources(Me.lstTimeEdit, "lstTimeEdit")
        Me.lstTimeEdit.CheckBoxes = True
        Me.lstTimeEdit.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNo, Me.colId, Me.colDate, Me.colTime})
        Me.lstTimeEdit.FullRowSelect = True
        Me.lstTimeEdit.GridLines = True
        Me.lstTimeEdit.Name = "lstTimeEdit"
        Me.lstTimeEdit.UseCompatibleStateImageBehavior = False
        Me.lstTimeEdit.View = System.Windows.Forms.View.Details
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
        'gcTimeEdit
        '
        resources.ApplyResources(Me.gcTimeEdit, "gcTimeEdit")
        Me.gcTimeEdit.MainView = Me.gvTimeEdit
        Me.gcTimeEdit.Name = "gcTimeEdit"
        Me.gcTimeEdit.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTimeEdit})
        '
        'gvTimeEdit
        '
        Me.gvTimeEdit.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clNo, Me.colEmpCode, Me.clDate, Me.clEmpName})
        Me.gvTimeEdit.GridControl = Me.gcTimeEdit
        Me.gvTimeEdit.Name = "gvTimeEdit"
        Me.gvTimeEdit.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.gvTimeEdit.OptionsSelection.MultiSelect = True
        Me.gvTimeEdit.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gvTimeEdit.OptionsView.ColumnAutoWidth = False
        Me.gvTimeEdit.OptionsView.ShowAutoFilterRow = True
        Me.gvTimeEdit.OptionsView.ShowGroupPanel = False
        '
        'clNo
        '
        resources.ApplyResources(Me.clNo, "clNo")
        Me.clNo.FieldName = "row"
        Me.clNo.Name = "clNo"
        Me.clNo.OptionsColumn.AllowEdit = False
        Me.clNo.OptionsColumn.ReadOnly = True
        '
        'colEmpCode
        '
        Me.colEmpCode.AppearanceCell.Options.UseTextOptions = True
        Me.colEmpCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmpCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colEmpCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colEmpCode, "colEmpCode")
        Me.colEmpCode.FieldName = "id"
        Me.colEmpCode.Name = "colEmpCode"
        Me.colEmpCode.OptionsColumn.AllowEdit = False
        Me.colEmpCode.OptionsColumn.ReadOnly = True
        '
        'clDate
        '
        Me.clDate.AppearanceCell.Options.UseTextOptions = True
        Me.clDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clDate.AppearanceHeader.Options.UseTextOptions = True
        Me.clDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.clDate, "clDate")
        Me.clDate.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.clDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.clDate.FieldName = "DateIn"
        Me.clDate.Name = "clDate"
        Me.clDate.OptionsColumn.AllowEdit = False
        Me.clDate.OptionsColumn.ReadOnly = True
        '
        'clEmpName
        '
        Me.clEmpName.AppearanceHeader.Options.UseTextOptions = True
        Me.clEmpName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.clEmpName, "clEmpName")
        Me.clEmpName.DisplayFormat.FormatString = "HH:mm"
        Me.clEmpName.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.clEmpName.FieldName = "tmTime"
        Me.clEmpName.Name = "clEmpName"
        Me.clEmpName.OptionsColumn.AllowEdit = False
        Me.clEmpName.OptionsColumn.ReadOnly = True
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
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtDate)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtDepartment)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtDeptId)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtName)
        Me.GroupControl1.Controls.Add(Me.txtCode)
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Name = "GroupControl1"
        '
        'LabelControl4
        '
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Name = "LabelControl4"
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        '
        'txtDepartment
        '
        resources.ApplyResources(Me.txtDepartment, "txtDepartment")
        Me.txtDepartment.Name = "txtDepartment"
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        '
        'txtDeptId
        '
        resources.ApplyResources(Me.txtDeptId, "txtDeptId")
        Me.txtDeptId.Name = "txtDeptId"
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        '
        'txtName
        '
        resources.ApplyResources(Me.txtName, "txtName")
        Me.txtName.Name = "txtName"
        '
        'txtTime
        '
        resources.ApplyResources(Me.txtTime, "txtTime")
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Properties.Mask.EditMask = resources.GetString("txtTime.Properties.Mask.EditMask")
        Me.txtTime.Properties.Mask.MaskType = CType(resources.GetObject("txtTime.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        '
        'LabelControl5
        '
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Name = "LabelControl5"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.chkPreviousDay)
        Me.GroupControl2.Controls.Add(Me.txtTime)
        Me.GroupControl2.Controls.Add(Me.chkNextDay)
        Me.GroupControl2.Controls.Add(Me.lblId)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        resources.ApplyResources(Me.GroupControl2, "GroupControl2")
        Me.GroupControl2.Name = "GroupControl2"
        '
        'GroupControl3
        '
        resources.ApplyResources(Me.GroupControl3, "GroupControl3")
        Me.GroupControl3.Controls.Add(Me.lblKaCode)
        Me.GroupControl3.Controls.Add(Me.GroupControl4)
        Me.GroupControl3.Controls.Add(Me.chkTimeSP_NextDay)
        Me.GroupControl3.Controls.Add(Me.chkMidDayStop_NextDay)
        Me.GroupControl3.Controls.Add(Me.chkMidDayStart_NextDay)
        Me.GroupControl3.Controls.Add(Me.txtTimeSP)
        Me.GroupControl3.Controls.Add(Me.chkka_flexible)
        Me.GroupControl3.Controls.Add(Me.chkka_spaical)
        Me.GroupControl3.Controls.Add(Me.LabelControl9)
        Me.GroupControl3.Controls.Add(Me.txtMidDayStop)
        Me.GroupControl3.Controls.Add(Me.LabelControl8)
        Me.GroupControl3.Controls.Add(Me.txtMidDayStart)
        Me.GroupControl3.Controls.Add(Me.LabelControl7)
        Me.GroupControl3.Controls.Add(Me.txtFlexible_Hour)
        Me.GroupControl3.Controls.Add(Me.txtTimeST_to)
        Me.GroupControl3.Controls.Add(Me.txtTimeST)
        Me.GroupControl3.Controls.Add(Me.LabelControl12)
        Me.GroupControl3.Controls.Add(Me.LabelControl13)
        Me.GroupControl3.Controls.Add(Me.LabelControl14)
        Me.GroupControl3.Controls.Add(Me.LabelControl6)
        Me.GroupControl3.Name = "GroupControl3"
        '
        'lblKaCode
        '
        Me.lblKaCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.lblKaCode, "lblKaCode")
        Me.lblKaCode.Name = "lblKaCode"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.chkTimeEndDay_NextDay)
        Me.GroupControl4.Controls.Add(Me.chkStartDay_PD)
        Me.GroupControl4.Controls.Add(Me.txtEndDay)
        Me.GroupControl4.Controls.Add(Me.txtStartDay)
        Me.GroupControl4.Controls.Add(Me.LabelControl11)
        Me.GroupControl4.Controls.Add(Me.LabelControl10)
        resources.ApplyResources(Me.GroupControl4, "GroupControl4")
        Me.GroupControl4.Name = "GroupControl4"
        '
        'chkTimeEndDay_NextDay
        '
        resources.ApplyResources(Me.chkTimeEndDay_NextDay, "chkTimeEndDay_NextDay")
        Me.chkTimeEndDay_NextDay.Name = "chkTimeEndDay_NextDay"
        Me.chkTimeEndDay_NextDay.Properties.Caption = resources.GetString("chkTimeEndDay_NextDay.Properties.Caption")
        Me.chkTimeEndDay_NextDay.Properties.ReadOnly = True
        '
        'chkStartDay_PD
        '
        resources.ApplyResources(Me.chkStartDay_PD, "chkStartDay_PD")
        Me.chkStartDay_PD.Name = "chkStartDay_PD"
        Me.chkStartDay_PD.Properties.Caption = resources.GetString("chkStartDay_PD.Properties.Caption")
        Me.chkStartDay_PD.Properties.ReadOnly = True
        '
        'txtEndDay
        '
        resources.ApplyResources(Me.txtEndDay, "txtEndDay")
        Me.txtEndDay.Name = "txtEndDay"
        Me.txtEndDay.Properties.Mask.EditMask = resources.GetString("txtEndDay.Properties.Mask.EditMask")
        Me.txtEndDay.Properties.Mask.MaskType = CType(resources.GetObject("txtEndDay.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtEndDay.Properties.ReadOnly = True
        '
        'txtStartDay
        '
        resources.ApplyResources(Me.txtStartDay, "txtStartDay")
        Me.txtStartDay.Name = "txtStartDay"
        Me.txtStartDay.Properties.Mask.EditMask = resources.GetString("txtStartDay.Properties.Mask.EditMask")
        Me.txtStartDay.Properties.Mask.MaskType = CType(resources.GetObject("txtStartDay.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtStartDay.Properties.ReadOnly = True
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Options.UseTextOptions = True
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        resources.ApplyResources(Me.LabelControl11, "LabelControl11")
        Me.LabelControl11.Name = "LabelControl11"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Options.UseTextOptions = True
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        resources.ApplyResources(Me.LabelControl10, "LabelControl10")
        Me.LabelControl10.Name = "LabelControl10"
        '
        'chkTimeSP_NextDay
        '
        resources.ApplyResources(Me.chkTimeSP_NextDay, "chkTimeSP_NextDay")
        Me.chkTimeSP_NextDay.Name = "chkTimeSP_NextDay"
        Me.chkTimeSP_NextDay.Properties.Caption = resources.GetString("chkTimeSP_NextDay.Properties.Caption")
        Me.chkTimeSP_NextDay.Properties.ReadOnly = True
        '
        'chkMidDayStop_NextDay
        '
        resources.ApplyResources(Me.chkMidDayStop_NextDay, "chkMidDayStop_NextDay")
        Me.chkMidDayStop_NextDay.Name = "chkMidDayStop_NextDay"
        Me.chkMidDayStop_NextDay.Properties.Caption = resources.GetString("chkMidDayStop_NextDay.Properties.Caption")
        Me.chkMidDayStop_NextDay.Properties.ReadOnly = True
        '
        'chkMidDayStart_NextDay
        '
        resources.ApplyResources(Me.chkMidDayStart_NextDay, "chkMidDayStart_NextDay")
        Me.chkMidDayStart_NextDay.Name = "chkMidDayStart_NextDay"
        Me.chkMidDayStart_NextDay.Properties.Caption = resources.GetString("chkMidDayStart_NextDay.Properties.Caption")
        Me.chkMidDayStart_NextDay.Properties.ReadOnly = True
        '
        'txtTimeSP
        '
        resources.ApplyResources(Me.txtTimeSP, "txtTimeSP")
        Me.txtTimeSP.Name = "txtTimeSP"
        Me.txtTimeSP.Properties.Mask.EditMask = resources.GetString("txtTimeSP.Properties.Mask.EditMask")
        Me.txtTimeSP.Properties.Mask.MaskType = CType(resources.GetObject("txtTimeSP.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtTimeSP.Properties.ReadOnly = True
        '
        'chkka_flexible
        '
        resources.ApplyResources(Me.chkka_flexible, "chkka_flexible")
        Me.chkka_flexible.Name = "chkka_flexible"
        Me.chkka_flexible.Properties.Caption = resources.GetString("chkka_flexible.Properties.Caption")
        Me.chkka_flexible.Properties.ReadOnly = True
        '
        'chkka_spaical
        '
        resources.ApplyResources(Me.chkka_spaical, "chkka_spaical")
        Me.chkka_spaical.Name = "chkka_spaical"
        Me.chkka_spaical.Properties.Caption = resources.GetString("chkka_spaical.Properties.Caption")
        Me.chkka_spaical.Properties.ReadOnly = True
        '
        'LabelControl9
        '
        resources.ApplyResources(Me.LabelControl9, "LabelControl9")
        Me.LabelControl9.Name = "LabelControl9"
        '
        'txtMidDayStop
        '
        resources.ApplyResources(Me.txtMidDayStop, "txtMidDayStop")
        Me.txtMidDayStop.Name = "txtMidDayStop"
        Me.txtMidDayStop.Properties.Mask.EditMask = resources.GetString("txtMidDayStop.Properties.Mask.EditMask")
        Me.txtMidDayStop.Properties.Mask.MaskType = CType(resources.GetObject("txtMidDayStop.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtMidDayStop.Properties.ReadOnly = True
        '
        'LabelControl8
        '
        resources.ApplyResources(Me.LabelControl8, "LabelControl8")
        Me.LabelControl8.Name = "LabelControl8"
        '
        'txtMidDayStart
        '
        resources.ApplyResources(Me.txtMidDayStart, "txtMidDayStart")
        Me.txtMidDayStart.Name = "txtMidDayStart"
        Me.txtMidDayStart.Properties.Mask.EditMask = resources.GetString("txtMidDayStart.Properties.Mask.EditMask")
        Me.txtMidDayStart.Properties.Mask.MaskType = CType(resources.GetObject("txtMidDayStart.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtMidDayStart.Properties.ReadOnly = True
        '
        'LabelControl7
        '
        resources.ApplyResources(Me.LabelControl7, "LabelControl7")
        Me.LabelControl7.Name = "LabelControl7"
        '
        'txtFlexible_Hour
        '
        resources.ApplyResources(Me.txtFlexible_Hour, "txtFlexible_Hour")
        Me.txtFlexible_Hour.Name = "txtFlexible_Hour"
        Me.txtFlexible_Hour.Properties.Mask.EditMask = resources.GetString("txtFlexible_Hour.Properties.Mask.EditMask")
        Me.txtFlexible_Hour.Properties.Mask.MaskType = CType(resources.GetObject("txtFlexible_Hour.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtFlexible_Hour.Properties.ReadOnly = True
        '
        'txtTimeST_to
        '
        resources.ApplyResources(Me.txtTimeST_to, "txtTimeST_to")
        Me.txtTimeST_to.Name = "txtTimeST_to"
        Me.txtTimeST_to.Properties.Mask.EditMask = resources.GetString("txtTimeST_to.Properties.Mask.EditMask")
        Me.txtTimeST_to.Properties.Mask.MaskType = CType(resources.GetObject("txtTimeST_to.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtTimeST_to.Properties.ReadOnly = True
        '
        'txtTimeST
        '
        resources.ApplyResources(Me.txtTimeST, "txtTimeST")
        Me.txtTimeST.Name = "txtTimeST"
        Me.txtTimeST.Properties.Mask.EditMask = resources.GetString("txtTimeST.Properties.Mask.EditMask")
        Me.txtTimeST.Properties.Mask.MaskType = CType(resources.GetObject("txtTimeST.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtTimeST.Properties.ReadOnly = True
        '
        'LabelControl12
        '
        resources.ApplyResources(Me.LabelControl12, "LabelControl12")
        Me.LabelControl12.Name = "LabelControl12"
        '
        'LabelControl13
        '
        resources.ApplyResources(Me.LabelControl13, "LabelControl13")
        Me.LabelControl13.Name = "LabelControl13"
        '
        'LabelControl14
        '
        resources.ApplyResources(Me.LabelControl14, "LabelControl14")
        Me.LabelControl14.Name = "LabelControl14"
        '
        'LabelControl6
        '
        resources.ApplyResources(Me.LabelControl6, "LabelControl6")
        Me.LabelControl6.Name = "LabelControl6"
        '
        'GroupControl5
        '
        resources.ApplyResources(Me.GroupControl5, "GroupControl5")
        Me.GroupControl5.Controls.Add(Me.chkSunday)
        Me.GroupControl5.Controls.Add(Me.chkSaturday)
        Me.GroupControl5.Controls.Add(Me.chkFriday)
        Me.GroupControl5.Controls.Add(Me.chkThursday)
        Me.GroupControl5.Controls.Add(Me.chkWednesday)
        Me.GroupControl5.Controls.Add(Me.chkTuesday)
        Me.GroupControl5.Controls.Add(Me.chkMonDay)
        Me.GroupControl5.Name = "GroupControl5"
        '
        'chkSunday
        '
        resources.ApplyResources(Me.chkSunday, "chkSunday")
        Me.chkSunday.Name = "chkSunday"
        Me.chkSunday.Properties.Caption = resources.GetString("chkSunday.Properties.Caption")
        Me.chkSunday.Properties.ReadOnly = True
        '
        'chkSaturday
        '
        resources.ApplyResources(Me.chkSaturday, "chkSaturday")
        Me.chkSaturday.Name = "chkSaturday"
        Me.chkSaturday.Properties.Caption = resources.GetString("chkSaturday.Properties.Caption")
        Me.chkSaturday.Properties.ReadOnly = True
        '
        'chkFriday
        '
        resources.ApplyResources(Me.chkFriday, "chkFriday")
        Me.chkFriday.Name = "chkFriday"
        Me.chkFriday.Properties.Caption = resources.GetString("chkFriday.Properties.Caption")
        Me.chkFriday.Properties.ReadOnly = True
        '
        'chkThursday
        '
        resources.ApplyResources(Me.chkThursday, "chkThursday")
        Me.chkThursday.Name = "chkThursday"
        Me.chkThursday.Properties.Caption = resources.GetString("chkThursday.Properties.Caption")
        Me.chkThursday.Properties.ReadOnly = True
        '
        'chkWednesday
        '
        resources.ApplyResources(Me.chkWednesday, "chkWednesday")
        Me.chkWednesday.Name = "chkWednesday"
        Me.chkWednesday.Properties.Caption = resources.GetString("chkWednesday.Properties.Caption")
        Me.chkWednesday.Properties.ReadOnly = True
        '
        'chkTuesday
        '
        resources.ApplyResources(Me.chkTuesday, "chkTuesday")
        Me.chkTuesday.Name = "chkTuesday"
        Me.chkTuesday.Properties.Caption = resources.GetString("chkTuesday.Properties.Caption")
        Me.chkTuesday.Properties.ReadOnly = True
        '
        'chkMonDay
        '
        resources.ApplyResources(Me.chkMonDay, "chkMonDay")
        Me.chkMonDay.Name = "chkMonDay"
        Me.chkMonDay.Properties.Caption = resources.GetString("chkMonDay.Properties.Caption")
        Me.chkMonDay.Properties.ReadOnly = True
        '
        'chkDelAll
        '
        resources.ApplyResources(Me.chkDelAll, "chkDelAll")
        Me.chkDelAll.Name = "chkDelAll"
        Me.chkDelAll.Properties.Caption = resources.GetString("chkDelAll.Properties.Caption")
        '
        'PanelControl1
        '
        resources.ApplyResources(Me.PanelControl1, "PanelControl1")
        Me.PanelControl1.Controls.Add(Me.chkDelAll)
        Me.PanelControl1.Name = "PanelControl1"
        '
        'frmEditTime
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GroupControl5)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.gcTimeEdit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSite)
        Me.Controls.Add(Me.lstTimeEdit)
        Me.KeyPreview = True
        Me.Name = "frmEditTime"
        CType(Me.gcTimeEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTimeEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeptId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.chkTimeEndDay_NextDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkStartDay_PD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStartDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTimeSP_NextDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMidDayStop_NextDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMidDayStart_NextDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTimeSP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkka_flexible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkka_spaical.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMidDayStop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMidDayStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFlexible_Hour.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTimeST_to.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTimeST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.chkSunday.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSaturday.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFriday.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkThursday.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkWednesday.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTuesday.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMonDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDelAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSite As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkPreviousDay As System.Windows.Forms.CheckBox
    Friend WithEvents chkNextDay As System.Windows.Forms.CheckBox
    Friend WithEvents lstTimeEdit As System.Windows.Forms.ListView
    Friend WithEvents colNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents colId As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents gcTimeEdit As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTimeEdit As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clEmpName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDepartment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeptId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkTimeEndDay_NextDay As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkStartDay_PD As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtEndDay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStartDay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkTimeSP_NextDay As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkMidDayStop_NextDay As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkMidDayStart_NextDay As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtTimeSP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMidDayStop As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMidDayStart As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTimeST As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkSunday As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSaturday As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkFriday As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkThursday As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkWednesday As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTuesday As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkMonDay As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkDelAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblKaCode As Label
    Friend WithEvents chkka_flexible As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkka_spaical As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtFlexible_Hour As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTimeST_to As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
End Class
