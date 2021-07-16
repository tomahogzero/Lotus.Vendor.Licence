Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports TimeAttendance.utils

Public Class frmTimeKa
    ' Inherits System.Windows.Forms.Form
    Inherits DevExpress.XtraEditors.XtraForm
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents colDeptId As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstSubjectGroup As System.Windows.Forms.ListView
    Friend WithEvents colTimeST As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTimeSP As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMon As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTue As System.Windows.Forms.ColumnHeader
    Friend WithEvents colWed As System.Windows.Forms.ColumnHeader
    Friend WithEvents colThu As System.Windows.Forms.ColumnHeader
    Friend WithEvents colFri As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSat As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSun As System.Windows.Forms.ColumnHeader
    Friend WithEvents colRestST As System.Windows.Forms.ColumnHeader
    Friend WithEvents colRestSP As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTimeSP_Next As System.Windows.Forms.ColumnHeader
    Friend WithEvents colRestST_NextD As System.Windows.Forms.ColumnHeader
    Friend WithEvents colRestSP_NextD As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTimeEndDay As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTimeEndDay_NextD As System.Windows.Forms.ColumnHeader
    Friend WithEvents colStartDay As System.Windows.Forms.ColumnHeader
    Friend WithEvents colStartDay_PD As System.Windows.Forms.ColumnHeader
    Friend WithEvents GcSubjectGroup As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvSubjectGroup As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colrow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode_lar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription_lar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReduc_lar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotdeduc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colremark_lar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cboTransport_detail As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboUnitName As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtGroupId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtGroupName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTimeST As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkTimeSP_NextDay As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkMidDayStop_NextDay As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkMidDayStart_NextDay As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkTimeEndDay_NextDay As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtStartDay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkStartDay_PD As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtEndDay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTimeSP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMidDayStop As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMidDayStart As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkSunday As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSaturday As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkFriday As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkThursday As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkWednesday As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTuesday As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkMonDay As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblGroupName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblGroupId As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkKA_flexible As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkka_default As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtKa_flexible_hour As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTimeST_To As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents colProgram As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimeKa))
        Me.lstSubjectGroup = New System.Windows.Forms.ListView()
        Me.colDeptId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colProgram = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTimeST = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRestST = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRestST_NextD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRestSP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRestSP_NextD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTimeSP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTimeSP_Next = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colStartDay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colStartDay_PD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTimeEndDay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTimeEndDay_NextD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colWed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colThu = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colFri = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSun = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GcSubjectGroup = New DevExpress.XtraGrid.GridControl()
        Me.GvSubjectGroup = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode_lar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription_lar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReduc_lar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotdeduc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colremark_lar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cboTransport_detail = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboUnitName = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.txtGroupId = New DevExpress.XtraEditors.TextEdit()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.chkKA_flexible = New DevExpress.XtraEditors.CheckEdit()
        Me.txtGroupName = New DevExpress.XtraEditors.TextEdit()
        Me.lblGroupName = New DevExpress.XtraEditors.LabelControl()
        Me.lblGroupId = New DevExpress.XtraEditors.LabelControl()
        Me.chkka_default = New DevExpress.XtraEditors.CheckEdit()
        Me.txtTimeST = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtKa_flexible_hour = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.chkTimeSP_NextDay = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.chkMidDayStop_NextDay = New DevExpress.XtraEditors.CheckEdit()
        Me.chkMidDayStart_NextDay = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.chkTimeEndDay_NextDay = New DevExpress.XtraEditors.CheckEdit()
        Me.txtStartDay = New DevExpress.XtraEditors.TextEdit()
        Me.chkStartDay_PD = New DevExpress.XtraEditors.CheckEdit()
        Me.txtEndDay = New DevExpress.XtraEditors.TextEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTimeSP = New DevExpress.XtraEditors.TextEdit()
        Me.txtMidDayStop = New DevExpress.XtraEditors.TextEdit()
        Me.txtMidDayStart = New DevExpress.XtraEditors.TextEdit()
        Me.txtTimeST_To = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.chkSunday = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.chkSaturday = New DevExpress.XtraEditors.CheckEdit()
        Me.chkFriday = New DevExpress.XtraEditors.CheckEdit()
        Me.chkThursday = New DevExpress.XtraEditors.CheckEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkWednesday = New DevExpress.XtraEditors.CheckEdit()
        Me.chkTuesday = New DevExpress.XtraEditors.CheckEdit()
        Me.chkMonDay = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.GcSubjectGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvSubjectGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGroupId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.chkKA_flexible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGroupName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkka_default.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTimeST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtKa_flexible_hour.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTimeSP_NextDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMidDayStop_NextDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMidDayStart_NextDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.chkTimeEndDay_NextDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStartDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkStartDay_PD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTimeSP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMidDayStop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMidDayStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTimeST_To.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSunday.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSaturday.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFriday.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkThursday.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkWednesday.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTuesday.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMonDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstSubjectGroup
        '
        Me.lstSubjectGroup.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDeptId, Me.colProgram, Me.colTimeST, Me.colRestST, Me.colRestST_NextD, Me.colRestSP, Me.colRestSP_NextD, Me.colTimeSP, Me.colTimeSP_Next, Me.colStartDay, Me.colStartDay_PD, Me.colTimeEndDay, Me.colTimeEndDay_NextD, Me.colMon, Me.colTue, Me.colWed, Me.colThu, Me.colFri, Me.colSat, Me.colSun})
        Me.lstSubjectGroup.FullRowSelect = True
        Me.lstSubjectGroup.GridLines = True
        resources.ApplyResources(Me.lstSubjectGroup, "lstSubjectGroup")
        Me.lstSubjectGroup.Name = "lstSubjectGroup"
        Me.lstSubjectGroup.UseCompatibleStateImageBehavior = False
        Me.lstSubjectGroup.View = System.Windows.Forms.View.Details
        '
        'colDeptId
        '
        resources.ApplyResources(Me.colDeptId, "colDeptId")
        '
        'colProgram
        '
        resources.ApplyResources(Me.colProgram, "colProgram")
        '
        'colTimeST
        '
        resources.ApplyResources(Me.colTimeST, "colTimeST")
        '
        'colRestST
        '
        resources.ApplyResources(Me.colRestST, "colRestST")
        '
        'colRestST_NextD
        '
        resources.ApplyResources(Me.colRestST_NextD, "colRestST_NextD")
        '
        'colRestSP
        '
        resources.ApplyResources(Me.colRestSP, "colRestSP")
        '
        'colRestSP_NextD
        '
        resources.ApplyResources(Me.colRestSP_NextD, "colRestSP_NextD")
        '
        'colTimeSP
        '
        resources.ApplyResources(Me.colTimeSP, "colTimeSP")
        '
        'colTimeSP_Next
        '
        resources.ApplyResources(Me.colTimeSP_Next, "colTimeSP_Next")
        '
        'colStartDay
        '
        resources.ApplyResources(Me.colStartDay, "colStartDay")
        '
        'colStartDay_PD
        '
        resources.ApplyResources(Me.colStartDay_PD, "colStartDay_PD")
        '
        'colTimeEndDay
        '
        resources.ApplyResources(Me.colTimeEndDay, "colTimeEndDay")
        '
        'colTimeEndDay_NextD
        '
        resources.ApplyResources(Me.colTimeEndDay_NextD, "colTimeEndDay_NextD")
        '
        'colMon
        '
        resources.ApplyResources(Me.colMon, "colMon")
        '
        'colTue
        '
        resources.ApplyResources(Me.colTue, "colTue")
        '
        'colWed
        '
        resources.ApplyResources(Me.colWed, "colWed")
        '
        'colThu
        '
        resources.ApplyResources(Me.colThu, "colThu")
        '
        'colFri
        '
        resources.ApplyResources(Me.colFri, "colFri")
        '
        'colSat
        '
        resources.ApplyResources(Me.colSat, "colSat")
        '
        'colSun
        '
        resources.ApplyResources(Me.colSun, "colSun")
        '
        'GcSubjectGroup
        '
        resources.ApplyResources(Me.GcSubjectGroup, "GcSubjectGroup")
        Me.GcSubjectGroup.MainView = Me.GvSubjectGroup
        Me.GcSubjectGroup.Name = "GcSubjectGroup"
        Me.GcSubjectGroup.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.BtnDel, Me.cboTransport_detail, Me.cboUnitName})
        Me.GcSubjectGroup.TabStop = False
        Me.GcSubjectGroup.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvSubjectGroup})
        '
        'GvSubjectGroup
        '
        Me.GvSubjectGroup.Appearance.HeaderPanel.Font = CType(resources.GetObject("GvSubjectGroup.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GvSubjectGroup.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvSubjectGroup.Appearance.Row.Options.UseFont = True
        Me.GvSubjectGroup.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colrow, Me.GridColumn3, Me.colcode_lar, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.colDescription_lar, Me.GridColumn19, Me.colReduc_lar, Me.colNotdeduc, Me.colremark_lar, Me.GridColumn1, Me.GridColumn2, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15})
        Me.GvSubjectGroup.GridControl = Me.GcSubjectGroup
        Me.GvSubjectGroup.Name = "GvSubjectGroup"
        Me.GvSubjectGroup.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.GvSubjectGroup.OptionsView.ColumnAutoWidth = False
        Me.GvSubjectGroup.OptionsView.ShowGroupPanel = False
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
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn3, "GridColumn3")
        Me.GridColumn3.FieldName = "KA_Code"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        '
        'colcode_lar
        '
        Me.colcode_lar.AppearanceHeader.Options.UseTextOptions = True
        Me.colcode_lar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colcode_lar, "colcode_lar")
        Me.colcode_lar.FieldName = "KaName"
        Me.colcode_lar.Name = "colcode_lar"
        Me.colcode_lar.OptionsColumn.AllowEdit = False
        '
        'GridColumn16
        '
        Me.GridColumn16.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn16.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn16.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn16.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn16, "GridColumn16")
        Me.GridColumn16.FieldName = "ka_default"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.OptionsColumn.ReadOnly = True
        '
        'GridColumn17
        '
        Me.GridColumn17.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn17.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn17, "GridColumn17")
        Me.GridColumn17.FieldName = "ka_flexible"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.OptionsColumn.ReadOnly = True
        '
        'GridColumn18
        '
        Me.GridColumn18.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn18.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn18, "GridColumn18")
        Me.GridColumn18.DisplayFormat.FormatString = "n1"
        Me.GridColumn18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn18.FieldName = "ka_flexible_hour"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.OptionsColumn.ReadOnly = True
        '
        'colDescription_lar
        '
        Me.colDescription_lar.AppearanceCell.Options.UseTextOptions = True
        Me.colDescription_lar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDescription_lar.AppearanceHeader.Options.UseTextOptions = True
        Me.colDescription_lar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colDescription_lar, "colDescription_lar")
        Me.colDescription_lar.DisplayFormat.FormatString = "HH:mm"
        Me.colDescription_lar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDescription_lar.FieldName = "TimeST"
        Me.colDescription_lar.Name = "colDescription_lar"
        Me.colDescription_lar.OptionsColumn.AllowEdit = False
        Me.colDescription_lar.OptionsColumn.ReadOnly = True
        '
        'GridColumn19
        '
        Me.GridColumn19.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn19.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn19.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn19.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn19, "GridColumn19")
        Me.GridColumn19.DisplayFormat.FormatString = "HH:mm"
        Me.GridColumn19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn19.FieldName = "TimeST_to"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        Me.GridColumn19.OptionsColumn.ReadOnly = True
        '
        'colReduc_lar
        '
        Me.colReduc_lar.AppearanceCell.Options.UseTextOptions = True
        Me.colReduc_lar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colReduc_lar.AppearanceHeader.Options.UseTextOptions = True
        Me.colReduc_lar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colReduc_lar, "colReduc_lar")
        Me.colReduc_lar.DisplayFormat.FormatString = "HH:mm"
        Me.colReduc_lar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colReduc_lar.FieldName = "RestST"
        Me.colReduc_lar.Name = "colReduc_lar"
        Me.colReduc_lar.OptionsColumn.AllowEdit = False
        '
        'colNotdeduc
        '
        Me.colNotdeduc.AppearanceCell.Options.UseTextOptions = True
        Me.colNotdeduc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNotdeduc.AppearanceHeader.Options.UseTextOptions = True
        Me.colNotdeduc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colNotdeduc, "colNotdeduc")
        Me.colNotdeduc.FieldName = "RestST_ND"
        Me.colNotdeduc.Name = "colNotdeduc"
        Me.colNotdeduc.OptionsColumn.AllowEdit = False
        '
        'colremark_lar
        '
        Me.colremark_lar.AppearanceCell.Options.UseTextOptions = True
        Me.colremark_lar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colremark_lar.AppearanceHeader.Options.UseTextOptions = True
        Me.colremark_lar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colremark_lar, "colremark_lar")
        Me.colremark_lar.DisplayFormat.FormatString = "HH:mm"
        Me.colremark_lar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colremark_lar.FieldName = "RestSP"
        Me.colremark_lar.Name = "colremark_lar"
        Me.colremark_lar.OptionsColumn.AllowEdit = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn1, "GridColumn1")
        Me.GridColumn1.DisplayFormat.FormatString = "n2"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "RestSP_ND"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn2, "GridColumn2")
        Me.GridColumn2.DisplayFormat.FormatString = "HH:mm"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "TimeSP"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn4, "GridColumn4")
        Me.GridColumn4.FieldName = "TimeSP_ND"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn5, "GridColumn5")
        Me.GridColumn5.DisplayFormat.FormatString = "HH:mm"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn5.FieldName = "StartDay"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn6, "GridColumn6")
        Me.GridColumn6.FieldName = "StartDay_PD"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn7, "GridColumn7")
        Me.GridColumn7.DisplayFormat.FormatString = "HH:mm"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn7.FieldName = "EndDay"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn8, "GridColumn8")
        Me.GridColumn8.FieldName = "EndDay_ND"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn9, "GridColumn9")
        Me.GridColumn9.FieldName = "Monday"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn10, "GridColumn10")
        Me.GridColumn10.FieldName = "Tuesday"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn11, "GridColumn11")
        Me.GridColumn11.FieldName = "Wednesday"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn12.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn12, "GridColumn12")
        Me.GridColumn12.FieldName = "Thursday"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn13.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn13, "GridColumn13")
        Me.GridColumn13.FieldName = "Friday"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn14.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn14, "GridColumn14")
        Me.GridColumn14.FieldName = "Saturday"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn15.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn15, "GridColumn15")
        Me.GridColumn15.FieldName = "Sunday"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
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
        'txtGroupId
        '
        resources.ApplyResources(Me.txtGroupId, "txtGroupId")
        Me.txtGroupId.Name = "txtGroupId"
        '
        'btnExit
        '
        Me.btnExit.ImageOptions.Image = CType(resources.GetObject("btnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.Name = "btnExit"
        '
        'btnRefresh
        '
        Me.btnRefresh.ImageOptions.Image = CType(resources.GetObject("btnRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnRefresh, "btnRefresh")
        Me.btnRefresh.Name = "btnRefresh"
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
        'PanelControl1
        '
        resources.ApplyResources(Me.PanelControl1, "PanelControl1")
        Me.PanelControl1.Controls.Add(Me.chkKA_flexible)
        Me.PanelControl1.Controls.Add(Me.txtGroupName)
        Me.PanelControl1.Controls.Add(Me.lblGroupName)
        Me.PanelControl1.Controls.Add(Me.lblGroupId)
        Me.PanelControl1.Controls.Add(Me.chkka_default)
        Me.PanelControl1.Controls.Add(Me.txtGroupId)
        Me.PanelControl1.Name = "PanelControl1"
        '
        'chkKA_flexible
        '
        resources.ApplyResources(Me.chkKA_flexible, "chkKA_flexible")
        Me.chkKA_flexible.Name = "chkKA_flexible"
        Me.chkKA_flexible.Properties.Caption = resources.GetString("chkKA_flexible.Properties.Caption")
        '
        'txtGroupName
        '
        resources.ApplyResources(Me.txtGroupName, "txtGroupName")
        Me.txtGroupName.Name = "txtGroupName"
        '
        'lblGroupName
        '
        resources.ApplyResources(Me.lblGroupName, "lblGroupName")
        Me.lblGroupName.Name = "lblGroupName"
        '
        'lblGroupId
        '
        resources.ApplyResources(Me.lblGroupId, "lblGroupId")
        Me.lblGroupId.Name = "lblGroupId"
        '
        'chkka_default
        '
        resources.ApplyResources(Me.chkka_default, "chkka_default")
        Me.chkka_default.Name = "chkka_default"
        Me.chkka_default.Properties.Caption = resources.GetString("chkka_default.Properties.Caption")
        '
        'txtTimeST
        '
        resources.ApplyResources(Me.txtTimeST, "txtTimeST")
        Me.txtTimeST.Name = "txtTimeST"
        Me.txtTimeST.Properties.Mask.EditMask = resources.GetString("txtTimeST.Properties.Mask.EditMask")
        Me.txtTimeST.Properties.Mask.MaskType = CType(resources.GetObject("txtTimeST.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        '
        'GroupControl1
        '
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Controls.Add(Me.txtKa_flexible_hour)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.chkTimeSP_NextDay)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.chkMidDayStop_NextDay)
        Me.GroupControl1.Controls.Add(Me.chkMidDayStart_NextDay)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Controls.Add(Me.txtTimeSP)
        Me.GroupControl1.Controls.Add(Me.txtMidDayStop)
        Me.GroupControl1.Controls.Add(Me.txtMidDayStart)
        Me.GroupControl1.Controls.Add(Me.txtTimeST_To)
        Me.GroupControl1.Controls.Add(Me.txtTimeST)
        Me.GroupControl1.Name = "GroupControl1"
        '
        'txtKa_flexible_hour
        '
        resources.ApplyResources(Me.txtKa_flexible_hour, "txtKa_flexible_hour")
        Me.txtKa_flexible_hour.Name = "txtKa_flexible_hour"
        Me.txtKa_flexible_hour.Properties.Appearance.Options.UseTextOptions = True
        Me.txtKa_flexible_hour.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtKa_flexible_hour.Properties.DisplayFormat.FormatString = "n1"
        Me.txtKa_flexible_hour.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtKa_flexible_hour.Properties.Mask.EditMask = resources.GetString("txtKa_flexible_hour.Properties.Mask.EditMask")
        Me.txtKa_flexible_hour.Properties.Mask.MaskType = CType(resources.GetObject("txtKa_flexible_hour.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = CType(resources.GetObject("LabelControl2.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl2.Appearance.Options.UseFont = True
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = CType(resources.GetObject("LabelControl1.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl1.Appearance.Options.UseFont = True
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        '
        'LabelControl10
        '
        resources.ApplyResources(Me.LabelControl10, "LabelControl10")
        Me.LabelControl10.Name = "LabelControl10"
        '
        'LabelControl6
        '
        resources.ApplyResources(Me.LabelControl6, "LabelControl6")
        Me.LabelControl6.Name = "LabelControl6"
        '
        'LabelControl9
        '
        resources.ApplyResources(Me.LabelControl9, "LabelControl9")
        Me.LabelControl9.Name = "LabelControl9"
        '
        'LabelControl5
        '
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Name = "LabelControl5"
        '
        'LabelControl8
        '
        resources.ApplyResources(Me.LabelControl8, "LabelControl8")
        Me.LabelControl8.Name = "LabelControl8"
        '
        'chkTimeSP_NextDay
        '
        resources.ApplyResources(Me.chkTimeSP_NextDay, "chkTimeSP_NextDay")
        Me.chkTimeSP_NextDay.Name = "chkTimeSP_NextDay"
        Me.chkTimeSP_NextDay.Properties.Caption = resources.GetString("chkTimeSP_NextDay.Properties.Caption")
        '
        'LabelControl11
        '
        resources.ApplyResources(Me.LabelControl11, "LabelControl11")
        Me.LabelControl11.Name = "LabelControl11"
        '
        'LabelControl7
        '
        resources.ApplyResources(Me.LabelControl7, "LabelControl7")
        Me.LabelControl7.Name = "LabelControl7"
        '
        'chkMidDayStop_NextDay
        '
        resources.ApplyResources(Me.chkMidDayStop_NextDay, "chkMidDayStop_NextDay")
        Me.chkMidDayStop_NextDay.Name = "chkMidDayStop_NextDay"
        Me.chkMidDayStop_NextDay.Properties.Caption = resources.GetString("chkMidDayStop_NextDay.Properties.Caption")
        '
        'chkMidDayStart_NextDay
        '
        resources.ApplyResources(Me.chkMidDayStart_NextDay, "chkMidDayStart_NextDay")
        Me.chkMidDayStart_NextDay.Name = "chkMidDayStart_NextDay"
        Me.chkMidDayStart_NextDay.Properties.Caption = resources.GetString("chkMidDayStart_NextDay.Properties.Caption")
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.chkTimeEndDay_NextDay)
        Me.GroupControl2.Controls.Add(Me.txtStartDay)
        Me.GroupControl2.Controls.Add(Me.chkStartDay_PD)
        Me.GroupControl2.Controls.Add(Me.txtEndDay)
        Me.GroupControl2.Controls.Add(Me.Label14)
        Me.GroupControl2.Controls.Add(Me.Label15)
        resources.ApplyResources(Me.GroupControl2, "GroupControl2")
        Me.GroupControl2.Name = "GroupControl2"
        '
        'chkTimeEndDay_NextDay
        '
        resources.ApplyResources(Me.chkTimeEndDay_NextDay, "chkTimeEndDay_NextDay")
        Me.chkTimeEndDay_NextDay.Name = "chkTimeEndDay_NextDay"
        Me.chkTimeEndDay_NextDay.Properties.Caption = resources.GetString("chkTimeEndDay_NextDay.Properties.Caption")
        '
        'txtStartDay
        '
        resources.ApplyResources(Me.txtStartDay, "txtStartDay")
        Me.txtStartDay.Name = "txtStartDay"
        Me.txtStartDay.Properties.Mask.EditMask = resources.GetString("txtStartDay.Properties.Mask.EditMask")
        Me.txtStartDay.Properties.Mask.MaskType = CType(resources.GetObject("txtStartDay.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        '
        'chkStartDay_PD
        '
        resources.ApplyResources(Me.chkStartDay_PD, "chkStartDay_PD")
        Me.chkStartDay_PD.Name = "chkStartDay_PD"
        Me.chkStartDay_PD.Properties.Caption = resources.GetString("chkStartDay_PD.Properties.Caption")
        '
        'txtEndDay
        '
        resources.ApplyResources(Me.txtEndDay, "txtEndDay")
        Me.txtEndDay.Name = "txtEndDay"
        Me.txtEndDay.Properties.Mask.EditMask = resources.GetString("txtEndDay.Properties.Mask.EditMask")
        Me.txtEndDay.Properties.Mask.MaskType = CType(resources.GetObject("txtEndDay.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'txtTimeSP
        '
        resources.ApplyResources(Me.txtTimeSP, "txtTimeSP")
        Me.txtTimeSP.Name = "txtTimeSP"
        Me.txtTimeSP.Properties.Mask.EditMask = resources.GetString("txtTimeSP.Properties.Mask.EditMask")
        Me.txtTimeSP.Properties.Mask.MaskType = CType(resources.GetObject("txtTimeSP.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        '
        'txtMidDayStop
        '
        resources.ApplyResources(Me.txtMidDayStop, "txtMidDayStop")
        Me.txtMidDayStop.Name = "txtMidDayStop"
        Me.txtMidDayStop.Properties.Mask.EditMask = resources.GetString("txtMidDayStop.Properties.Mask.EditMask")
        Me.txtMidDayStop.Properties.Mask.MaskType = CType(resources.GetObject("txtMidDayStop.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        '
        'txtMidDayStart
        '
        resources.ApplyResources(Me.txtMidDayStart, "txtMidDayStart")
        Me.txtMidDayStart.Name = "txtMidDayStart"
        Me.txtMidDayStart.Properties.Mask.EditMask = resources.GetString("txtMidDayStart.Properties.Mask.EditMask")
        Me.txtMidDayStart.Properties.Mask.MaskType = CType(resources.GetObject("txtMidDayStart.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        '
        'txtTimeST_To
        '
        resources.ApplyResources(Me.txtTimeST_To, "txtTimeST_To")
        Me.txtTimeST_To.Name = "txtTimeST_To"
        Me.txtTimeST_To.Properties.Mask.EditMask = resources.GetString("txtTimeST_To.Properties.Mask.EditMask")
        Me.txtTimeST_To.Properties.Mask.MaskType = CType(resources.GetObject("txtTimeST_To.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        '
        'GroupControl3
        '
        resources.ApplyResources(Me.GroupControl3, "GroupControl3")
        Me.GroupControl3.Controls.Add(Me.CheckEdit1)
        Me.GroupControl3.Controls.Add(Me.chkSunday)
        Me.GroupControl3.Controls.Add(Me.CheckEdit2)
        Me.GroupControl3.Controls.Add(Me.chkSaturday)
        Me.GroupControl3.Controls.Add(Me.chkFriday)
        Me.GroupControl3.Controls.Add(Me.chkThursday)
        Me.GroupControl3.Controls.Add(Me.Label5)
        Me.GroupControl3.Controls.Add(Me.chkWednesday)
        Me.GroupControl3.Controls.Add(Me.chkTuesday)
        Me.GroupControl3.Controls.Add(Me.chkMonDay)
        Me.GroupControl3.Name = "GroupControl3"
        '
        'CheckEdit1
        '
        resources.ApplyResources(Me.CheckEdit1, "CheckEdit1")
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = resources.GetString("CheckEdit1.Properties.Caption")
        Me.CheckEdit1.Properties.ReadOnly = True
        '
        'chkSunday
        '
        resources.ApplyResources(Me.chkSunday, "chkSunday")
        Me.chkSunday.Name = "chkSunday"
        Me.chkSunday.Properties.Caption = resources.GetString("chkSunday.Properties.Caption")
        '
        'CheckEdit2
        '
        resources.ApplyResources(Me.CheckEdit2, "CheckEdit2")
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Caption = resources.GetString("CheckEdit2.Properties.Caption")
        Me.CheckEdit2.Properties.ReadOnly = True
        '
        'chkSaturday
        '
        resources.ApplyResources(Me.chkSaturday, "chkSaturday")
        Me.chkSaturday.Name = "chkSaturday"
        Me.chkSaturday.Properties.Caption = resources.GetString("chkSaturday.Properties.Caption")
        '
        'chkFriday
        '
        resources.ApplyResources(Me.chkFriday, "chkFriday")
        Me.chkFriday.Name = "chkFriday"
        Me.chkFriday.Properties.Caption = resources.GetString("chkFriday.Properties.Caption")
        '
        'chkThursday
        '
        resources.ApplyResources(Me.chkThursday, "chkThursday")
        Me.chkThursday.Name = "chkThursday"
        Me.chkThursday.Properties.Caption = resources.GetString("chkThursday.Properties.Caption")
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'chkWednesday
        '
        resources.ApplyResources(Me.chkWednesday, "chkWednesday")
        Me.chkWednesday.Name = "chkWednesday"
        Me.chkWednesday.Properties.Caption = resources.GetString("chkWednesday.Properties.Caption")
        '
        'chkTuesday
        '
        resources.ApplyResources(Me.chkTuesday, "chkTuesday")
        Me.chkTuesday.Name = "chkTuesday"
        Me.chkTuesday.Properties.Caption = resources.GetString("chkTuesday.Properties.Caption")
        '
        'chkMonDay
        '
        resources.ApplyResources(Me.chkMonDay, "chkMonDay")
        Me.chkMonDay.Name = "chkMonDay"
        Me.chkMonDay.Properties.Caption = resources.GetString("chkMonDay.Properties.Caption")
        '
        'frmTimeKa
        '
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GcSubjectGroup)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lstSubjectGroup)
        Me.Controls.Add(Me.btnRefresh)
        Me.KeyPreview = True
        Me.Name = "frmTimeKa"
        CType(Me.GcSubjectGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvSubjectGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGroupId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.chkKA_flexible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGroupName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkka_default.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTimeST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtKa_flexible_hour.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTimeSP_NextDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMidDayStop_NextDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMidDayStart_NextDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.chkTimeEndDay_NextDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStartDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkStartDay_PD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTimeSP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMidDayStop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMidDayStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTimeST_To.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSunday.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSaturday.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFriday.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkThursday.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkWednesday.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTuesday.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMonDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmDepartment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ClearData()
        '  Call LoadData()
        Call LoadDatadev()
        Call EnaCmd(True, False, False)
        txtGroupId.Focus()

        Call Enable_flexible() ' เปิดปิด ช่องป้อนเวลาเข้าออกตามกะ
    End Sub

    Private Sub Enable_flexible()
        If chkKA_flexible.Checked = True Then
            txtTimeST_To.Enabled = True
            txtMidDayStart.Enabled = False
            txtMidDayStart.Text = ""
            chkMidDayStart_NextDay.Enabled = False
            txtMidDayStop.Enabled = False
            txtMidDayStop.Text = ""
            chkMidDayStop_NextDay.Enabled = False
            txtTimeSP.Enabled = False
            txtTimeSP.Text = ""
            chkTimeSP_NextDay.Enabled = False

            txtKa_flexible_hour.Enabled = True
        Else
            txtTimeST_To.Enabled = False
            txtTimeST_To.Text = ""
            txtMidDayStart.Enabled = True
            chkMidDayStart_NextDay.Enabled = True
            txtMidDayStop.Enabled = True
            chkMidDayStop_NextDay.Enabled = True
            txtTimeSP.Enabled = True
            chkTimeSP_NextDay.Enabled = True

            txtKa_flexible_hour.Enabled = False
        End If

    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearData()
        txtGroupId.Text = ""
        txtGroupName.Text = ""
        txtTimeST.Text = ""
        txtTimeST_To.Text = ""
        txtTimeSP.Text = ""
        txtStartDay.Text = "00:00"
        txtEndDay.Text = "23:59"

        txtMidDayStart.Text = ""
        txtMidDayStop.Text = ""

        txtKa_flexible_hour.Text = "0"

        chkka_default.Checked = False
        chkKA_flexible.Checked = False

        chkMidDayStart_NextDay.Checked = False
        chkMidDayStop_NextDay.Checked = False
        chkTimeSP_NextDay.Checked = False
        chkStartDay_PD.Checked = False
        chkTimeEndDay_NextDay.Checked = False


        ' Clear DATE Of Week
        chkMonDay.Checked = True
        chkTuesday.Checked = True
        chkWednesday.Checked = True
        chkThursday.Checked = True
        chkFriday.Checked = True
        chkSaturday.Checked = False
        chkSunday.Checked = False
    End Sub

    Private Sub EnaCmd(ByVal Add As Boolean, ByVal Edit As Boolean, ByVal Delete As Boolean)
        btnAdd.Enabled = Add
        btnEdit.Enabled = Edit
        btnDelete.Enabled = Delete
    End Sub

    Private Sub LoadData()
        Dim DA As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select KA_Code,KaName," &
                            " TimeST,TimeST_to,TimeSP,RestST,RestSP,StartDay,EndDay," &
                            " RestST_ND = Isnull(RestST_ND,0)," &
                            " RestSP_ND = Isnull(RestSP_ND,0)," &
                            " TimeSP_ND = Isnull(TimeSP_ND,0)," &
                            " StartDay_PD = Isnull(StartDay_PD,0)," &
                            " EndDay_ND = Isnull(EndDay_ND,0)," &
                            " Monday = Isnull(Monday,0)," &
                            " Tuesday = Isnull(Tuesday,0)," &
                            " Wednesday = Isnull(Wednesday,0)," &
                            " Thursday = Isnull(Thursday,0)," &
                            " Friday = Isnull(Friday,0)," &
                            " Saturday = Isnull(Saturday,0)," &
                            " Sunday = Isnull(Sunday,0) " &
                " from TimeKa " &
                " Order By TimeST"
        DA = New SqlDataAdapter(strSQL, Conn)
        DA.Fill(Ds, "TimeKa")
        With Ds.Tables("TimeKa")
            If .Rows.Count = 0 Then
                Ds.Clear()
                lstSubjectGroup.Items.Clear()
                Exit Sub
            End If
            Dim I As Integer
            Dim arrData() As String
            Dim List As ListViewItem
            lstSubjectGroup.Items.Clear()
            For I = 0 To .Rows.Count - 1
                arrData = New String() { .Rows(I).Item("KA_Code"),
                                    .Rows(I).Item("KaName"),
                                    Format(.Rows(I).Item("TimeST"), "HH:mm"),
                                    Format(.Rows(I).Item("RestST"), "HH:mm"),
                                    IIf(.Rows(I).Item("RestST_ND"), "/", ""),
                                    Format(.Rows(I).Item("RestSP"), "HH:mm"),
                                    IIf(.Rows(I).Item("RestSP_ND"), "/", ""),
                                    Format(.Rows(I).Item("TimeSP"), "HH:mm"),
                                    IIf(.Rows(I).Item("TimeSP_ND"), "/", ""),
                                    Format(.Rows(I).Item("StartDay"), "HH:mm"),
                                    IIf(.Rows(I).Item("StartDay_PD"), "/", ""),
                                    Format(.Rows(I).Item("EndDay"), "HH:mm"),
                                    IIf(.Rows(I).Item("EndDay_ND"), "/", ""),
                                    IIf(.Rows(I).Item("Monday"), "x", ""),
                                    IIf(.Rows(I).Item("Tuesday"), "x", ""),
                                    IIf(.Rows(I).Item("Wednesday"), "x", ""),
                                    IIf(.Rows(I).Item("Thursday"), "x", ""),
                                    IIf(.Rows(I).Item("Friday"), "x", ""),
                                    IIf(.Rows(I).Item("Saturday"), "x", ""),
                                    IIf(.Rows(I).Item("Sunday"), "x", "")}
                List = New ListViewItem(arrData)
                lstSubjectGroup.Items.Add(List)
            Next
            Ds.Clear()
        End With
    End Sub

    Private Sub LoadDatadev()
        Dim DA As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select ROW_NUMBER() OVER(ORDER By TimeST) as row," &
                            " KA_Code,KaName," &
                            " ka_default=Isnull(ka_default,0)," &
                            " ka_flexible=Isnull(ka_flexible,0)," &
                            " ka_flexible_hour=Isnull(ka_flexible_hour,0), " &
                            " TimeST,TimeST_to,TimeSP,RestST,RestSP,StartDay,EndDay," &
                            " RestST_ND = Isnull(RestST_ND,0)," &
                            " RestSP_ND = Isnull(RestSP_ND,0)," &
                            " TimeSP_ND = Isnull(TimeSP_ND,0)," &
                            " StartDay_PD = Isnull(StartDay_PD,0)," &
                            " EndDay_ND = Isnull(EndDay_ND,0)," &
                            " Monday = Isnull(Monday,0)," &
                            " Tuesday = Isnull(Tuesday,0)," &
                            " Wednesday = Isnull(Wednesday,0)," &
                            " Thursday = Isnull(Thursday,0)," &
                            " Friday = Isnull(Friday,0)," &
                            " Saturday = Isnull(Saturday,0)," &
                            " Sunday = Isnull(Sunday,0) " &
                " from TimeKa " &
                " Order By TimeST"



        DA = New SqlDataAdapter(strSQL, Conn)
        DA.Fill(Ds, "Data")


        GcSubjectGroup.DataSource = Ds
        GcSubjectGroup.DataMember = "Data"

        'DA = New SqlDataAdapter(strSQL, Conn)
        'DA.Fill(Ds, "TimeKa")

        'GcSubjectGroup.DataSource = Ds
        'GcSubjectGroup.DataMember = "Data"
    End Sub



    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Call ClearData()
        '   Call LoadData()
        Call LoadDatadev()
        Call EnaCmd(True, False, False)
        'txtGroupId.Text = AutoId()
        txtGroupId.Focus()
    End Sub


    Private Sub txtGroupId_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGroupId.LostFocus
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim strSQL As String
        strSQL = "Select KA_Code,KaName," &
                            " ka_default," &
                            " ka_flexible," &
                            " ka_flexible_hour," &
                            " TimeST,TimeST_to,TimeSP," &
                            " RestST,RestSP,StartDay,EndDay," &
                            " RestST_ND = Isnull(RestST_ND,0)," &
                            " RestSP_ND = Isnull(RestSP_ND,0)," &
                            " TimeSP_ND = Isnull(TimeSP_ND,0)," &
                            " StartDay_PD = Isnull(StartDay_PD,0)," &
                            " EndDay_ND = Isnull(EndDay_ND,0)," &
                            " Monday = Isnull(Monday,0)," &
                            " Tuesday = Isnull(Tuesday,0)," &
                            " Wednesday = Isnull(Wednesday,0)," &
                            " Thursday = Isnull(Thursday,0)," &
                            " Friday = Isnull(Friday,0)," &
                            " Saturday = Isnull(Saturday,0)," &
                            " Sunday = Isnull(Sunday,0) " &
                " from TimeKa " &
                " Where KA_Code = '" & txtGroupId.Text.Trim & "'"
        DA = New SqlDataAdapter(strSQL, Conn)
        DA.Fill(DS, "TimeKa")
        With DS.Tables("TimeKa")
            If .Rows.Count = 0 Then
                DS.Clear()
                txtGroupName.Text = ""
                Call EnaCmd(True, False, False)
                Exit Sub
            End If
            txtGroupName.Text = .Rows(0).Item("KaName")
            txtTimeST.Text = Format(.Rows(0).Item("TimeST"), "HH:mm")
            txtTimeST_To.Text = Format(.Rows(0).Item("TimeST_to"), "HH:mm")
            txtTimeSP.Text = Format(.Rows(0).Item("TimeSP"), "HH:mm")
            txtMidDayStart.Text = Format(.Rows(0).Item("RestST"), "HH:mm")
            txtMidDayStop.Text = Format(.Rows(0).Item("RestSP"), "HH:mm")
            txtStartDay.Text = Format(.Rows(0).Item("StartDay"), "HH:mm")
            txtEndDay.Text = Format(.Rows(0).Item("EndDay"), "HH:mm")

            txtKa_flexible_hour.EditValue = .Rows(0).Item("ka_flexible_hour")

            If .Rows(0).Item("ka_default") = True Then
                chkka_default.Checked = True
            Else
                chkka_default.Checked = False
            End If

            If .Rows(0).Item("ka_flexible") = True Then
                chkKA_flexible.Checked = True
            Else
                chkKA_flexible.Checked = False
            End If


            If .Rows(0).Item("TimeSP_ND") = True Then
                chkTimeSP_NextDay.Checked = True
            Else
                chkTimeSP_NextDay.Checked = False
            End If

            If .Rows(0).Item("RestST_ND") = True Then
                chkMidDayStart_NextDay.Checked = True
            Else
                chkMidDayStart_NextDay.Checked = False
            End If

            If .Rows(0).Item("RestSP_ND") = True Then
                chkMidDayStop_NextDay.Checked = True
            Else
                chkMidDayStop_NextDay.Checked = False
            End If

            If .Rows(0).Item("StartDay_PD") = True Then
                chkStartDay_PD.Checked = True
            Else
                chkStartDay_PD.Checked = False
            End If

            If .Rows(0).Item("EndDay_ND") = True Then
                chkTimeEndDay_NextDay.Checked = True
            Else
                chkTimeEndDay_NextDay.Checked = False
            End If

            'Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
            If .Rows(0).Item("Monday") = True Then
                chkMonDay.Checked = True
            Else
                chkMonDay.Checked = False
            End If

            If .Rows(0).Item("Tuesday") = True Then
                chkTuesday.Checked = True
            Else
                chkTuesday.Checked = False
            End If

            If .Rows(0).Item("Wednesday") = True Then
                chkWednesday.Checked = True
            Else
                chkWednesday.Checked = False
            End If

            If .Rows(0).Item("Thursday") = True Then
                chkThursday.Checked = True
            Else
                chkThursday.Checked = False
            End If

            If .Rows(0).Item("Friday") = True Then
                chkFriday.Checked = True
            Else
                chkFriday.Checked = False
            End If

            If .Rows(0).Item("Saturday") = True Then
                chkSaturday.Checked = True
            Else
                chkSaturday.Checked = False
            End If

            If .Rows(0).Item("Sunday") = True Then
                chkSunday.Checked = True
            Else
                chkSunday.Checked = False
            End If

            Call chkKA_flexible_CheckedChanged(Me, EventArgs.Empty)

            DS.Clear()
            Call EnaCmd(False, True, True)
        End With
    End Sub

    Function AutoId() As String
        Dim DaAuto As New SqlDataAdapter
        Dim DsAuto As New DataSet
        Dim strSQL As String
        Dim Id As String
        strSQL = "Select Isnull(Max(KA_Code),'000') as MaxId From TimeKa Where Isnumeric(KA_Code) = 1"
        DaAuto = New SqlDataAdapter(strSQL, Conn)
        DaAuto.Fill(DsAuto, "MaxId")
        With DsAuto.Tables("MaxId")
            Id = Format(Val(.Rows(0).Item("MaxId")) + 1, "000")
        End With
        DsAuto.Clear()
        Return Id.Trim
    End Function



    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtGroupId.Text.Trim = "" Then
            'MsgBox("กรุณาป้อนรหัสด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmTimeKaRS", Me.Text, "Insert_ID", MessageBoxIcon.Information)
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblGroupId.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtGroupId.Focus()
            Exit Sub
        End If
        If txtGroupName.Text.Trim = "" Then
            'MsgBox("กรุณาป้อนชื่อรอบการทำงานด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmTimeKaRS", Me.Text, "Insert_WorkName", MessageBoxIcon.Information)
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblGroupName.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtGroupName.Focus()
            Exit Sub
        End If

        ' เวลาเข้า
        If txtTimeST.Text.Trim = "" Then
            '   MsgBox("กรุณาป้อนเวลาเข้าด้วย", MsgBoxStyle.Information, Me.Text)
            MsgBox(My.Resources.res_warning_message_spacial.please_input_TimeIN, MsgBoxStyle.Information, Me.Text)
            txtTimeST.Focus()
            Exit Sub
        End If
        If IsDate("1900/01/01 " & txtTimeST.Text.Trim) = False Then
            'MsgBox("กรุณาป้อนเวลาให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmTimeKaRS", Me.Text, "Check_Time", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.check_time, MsgBoxStyle.Information, Me.Text)
            txtTimeST.Focus()
            Exit Sub
        End If

        'If txtTimeST_To.Text.Trim = "" Then
        '    MsgBox("กรุณาป้อนเวลาช่วงเวลาเข้า(flexible hour)ด้วย", MsgBoxStyle.Information, Me.Text)
        '    txtTimeST_To.Focus()
        '    Exit Sub
        'End If

        If IsDate("1900/01/01 " & txtTimeST_To.Text.Trim) = False Then
            'MsgBox("กรุณาป้อนเวลาให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmTimeKaRS", Me.Text, "Check_Time", MessageBoxIcon.Information)
            '   MsgBox(My.Resources.res_warning_message.check_time, MsgBoxStyle.Information, Me.Text)
            txtTimeST_To.Focus()
            Exit Sub
        End If

        ' เวลาพัก
        'If txtMidDayStart.Text.Trim = "" Then
        '    MsgBox("กรุณาป้อนเวลาเริ่มพักด้วย", MsgBoxStyle.Information, Me.Text)
        '    txtMidDayStart.Focus()
        '    Exit Sub
        'End If
        If IsDate("1900/01/01 " & txtMidDayStart.Text.Trim) = False Then
            'MsgBox("กรุณาป้อนเวลาให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmTimeKaRS", Me.Text, "Check_Time", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.check_time, MsgBoxStyle.Information, Me.Text)
            txtMidDayStart.Focus()
            Exit Sub
        End If

        ' เวลาเริ่มพัก
        'If txtMidDayStop.Text.Trim = "" Then
        '    MsgBox("กรุณาป้อนเวลาเลิกพักด้วย", MsgBoxStyle.Information, Me.Text)
        '    txtMidDayStop.Focus()
        '    Exit Sub
        'End If
        If IsDate("1900/01/01 " & txtMidDayStop.Text.Trim) = False Then
            'MsgBox("กรุณาป้อนเวลาให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmTimeKaRS", Me.Text, "Check_Time", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.check_time, MsgBoxStyle.Information, Me.Text)
            txtMidDayStop.Focus()
            Exit Sub
        End If

        ' เวลาออก
        'If txtTimeSP.Text.Trim = "" Then
        '    MsgBox("กรุณาป้อนเวลาเวลาออกด้วย", MsgBoxStyle.Information, Me.Text)
        '    txtTimeSP.Focus()
        '    Exit Sub
        'End If
        If IsDate("1900/01/01 " & txtTimeSP.Text.Trim) = False Then
            'MsgBox("กรุณาป้อนเวลาให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            ' MsgManager.ShowDialog(Me, "frmTimeKaRS", Me.Text, "Check_Time", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.check_time, MsgBoxStyle.Information, Me.Text)
            txtTimeSP.Focus()
            Exit Sub
        End If

        ' เวลาเริ่มต้นวัน
        'If txtStartDay.Text.Trim = "" Then
        '    MsgBox("กรุณาป้อนเวลาเริ่มรอบวันด้วย", MsgBoxStyle.Information, Me.Text)
        '    txtStartDay.Focus()
        '    Exit Sub
        'End If
        If IsDate("1900/01/01 " & txtStartDay.Text.Trim) = False Then
            'MsgBox("กรุณาป้อนเวลาให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmTimeKaRS", Me.Text, "Check_Time", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.check_time, MsgBoxStyle.Information, Me.Text)
            txtStartDay.Focus()
            Exit Sub
        End If

        'If txtEndDay.Text.Trim = "" Then
        '    MsgBox("กรุณาป้อนเวลาสิ้นสุดรอบวันด้วย", MsgBoxStyle.Information, Me.Text)
        '    txtEndDay.Focus()
        '    Exit Sub
        'End If
        If IsDate("1900/01/01 " & txtEndDay.Text.Trim) = False Then
            'MsgBox("กรุณาป้อนเวลาให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmTimeKaRS", Me.Text, "Check_Time", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.check_time, MsgBoxStyle.Information, Me.Text)
            txtEndDay.Focus()
            Exit Sub
        End If

        If IsNumeric(txtKa_flexible_hour.Text) = False Then txtKa_flexible_hour.Text = "0"

        If chkKA_flexible.Checked = True Then

            If CSng(txtKa_flexible_hour.Text) <= 0 Then
                '  MsgBox("จน.ชม.ทำงานควรมากกว่า 0", MsgBoxStyle.Information, Me.Text)
                MsgBox(My.Resources.res_warning_message_spacial.Amount_hr_over_zero, MsgBoxStyle.Information, Me.Text)
                txtKa_flexible_hour.Focus()
                Exit Sub
            End If
        Else


        End If



        Dim Dcmd As New SqlCommand
        Dim strSQL As String
        Try

            If chkka_default.Checked = True Then
                strSQL = "Update TimeKa Set ka_default = 0 "

                Dcmd.Connection = Conn
                Dcmd.CommandText = strSQL
                Dcmd.ExecuteNonQuery()
            End If



            strSQL = "Insert Into TimeKa(KA_Code,KaName," &
                            " TimeST,TimeST_to,TimeSP,RestST,RestSP,StartDay,EndDay," &
                            " TimeSP_ND,RestST_ND,RestSP_ND,StartDay_PD,EndDay_ND," &
                            " Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday, " &
                            " ka_default,ka_flexible,ka_flexible_hour) Values (" &
                     "'" & txtGroupId.Text.Trim & "','" & txtGroupName.Text.Trim & "'," &
                     "'" & txtTimeST.Text.Trim & "','" & txtTimeST_To.Text.Trim & "','" & txtTimeSP.Text.Trim & "'," &
                     "'" & txtMidDayStart.Text.Trim & "','" & txtMidDayStop.Text.Trim & "'," &
                     "'" & txtStartDay.Text.Trim & "'," &
                     "'" & txtEndDay.Text.Trim & "'," &
                     " " & IIf(chkMidDayStart_NextDay.Checked = True, 1, 0) & "," &
                     " " & IIf(chkMidDayStop_NextDay.Checked = True, 1, 0) & "," &
                     " " & IIf(chkTimeSP_NextDay.Checked = True, 1, 0) & "," &
                     " " & IIf(chkStartDay_PD.Checked = True, 1, 0) & "," &
                     " " & IIf(chkTimeEndDay_NextDay.Checked = True, 1, 0) & "," &
                     " " & IIf(chkMonDay.Checked = True, 1, 0) & "," &
                     " " & IIf(chkTuesday.Checked = True, 1, 0) & "," &
                     " " & IIf(chkWednesday.Checked = True, 1, 0) & "," &
                     " " & IIf(chkThursday.Checked = True, 1, 0) & "," &
                     " " & IIf(chkFriday.Checked = True, 1, 0) & "," &
                     " " & IIf(chkSaturday.Checked = True, 1, 0) & "," &
                     " " & IIf(chkSunday.Checked = True, 1, 0) & "," &
                     " " & IIf(chkka_default.Checked = True, 1, 0) & "," &
                     " " & IIf(chkKA_flexible.Checked = True, 1, 0) & "," &
                     " " & txtKa_flexible_hour.EditValue & ")"
            Dcmd.Connection = Conn
            Dcmd.CommandText = strSQL
            Dcmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
            Exit Sub
        End Try
        Call btnRefresh_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub txtGroupName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGroupName.GotFocus
        txtGroupName.SelectAll()
    End Sub

    Private Sub lstSubjectGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSubjectGroup.SelectedIndexChanged
        With lstSubjectGroup
            If .Items.Count = 0 Then Exit Sub
            If .SelectedItems.Count = 0 Then Exit Sub
            txtGroupId.Text = .SelectedItems(0).SubItems(0).Text.Trim
            Call txtGroupId_LostFocus(Me, System.EventArgs.Empty)
            txtGroupName.Focus()
            Call EnaCmd(False, True, True)
        End With
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtGroupName.Text.Trim = "" Then
            'MsgBox("กรุณาป้อนชื่อแผนด้วย", MsgBoxStyle.Information, Me.Text)
            '    MsgManager.ShowDialog(Me, "frmTimeKaRS", Me.Text, "Insert_PlanName", MessageBoxIcon.Information)
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblGroupName.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtGroupName.Focus()
            Exit Sub
        End If
        If IsDate("1900/01/01 " & txtTimeST.Text.Trim) = False Then
            'MsgBox("กรุณาป้อนเวลาให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmTimeKaRS", Me.Text, "Check_Time", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.check_time, MsgBoxStyle.Information, Me.Text)
            txtTimeST.Focus()
            Exit Sub
        End If

        If IsDate("1900/01/01 " & txtTimeST_To.Text.Trim) = False Then
            'MsgBox("กรุณาป้อนเวลาให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmTimeKaRS", Me.Text, "Check_Time", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.check_time, MsgBoxStyle.Information, Me.Text)
            txtTimeST_To.Focus()
            Exit Sub
        End If

        If IsDate("1900/01/01 " & txtTimeSP.Text.Trim) = False Then
            'MsgBox("กรุณาป้อนเวลาให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmTimeKaRS", Me.Text, "Check_Time", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.check_time, MsgBoxStyle.Information, Me.Text)
            txtTimeSP.Focus()
            Exit Sub
        End If

        If IsDate("1900/01/01 " & txtStartDay.Text.Trim) = False Then
            'MsgBox("กรุณาป้อนเวลาให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmTimeKaRS", Me.Text, "Check_Time", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.check_time, MsgBoxStyle.Information, Me.Text)
            txtStartDay.Focus()
            Exit Sub
        End If

        If IsDate("1900/01/01 " & txtEndDay.Text.Trim) = False Then
            'MsgBox("กรุณาป้อนเวลาให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmTimeKaRS", Me.Text, "Check_Time", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.check_time, MsgBoxStyle.Information, Me.Text)
            txtEndDay.Focus()
            Exit Sub
        End If

        If IsDate("1900/01/01 " & txtMidDayStart.Text.Trim) = False Then
            'MsgBox("กรุณาป้อนเวลาให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmTimeKaRS", Me.Text, "Check_Time", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.check_time, MsgBoxStyle.Information, Me.Text)
            txtMidDayStart.Focus()
            Exit Sub
        End If

        If IsDate("1900/01/01 " & txtMidDayStop.Text.Trim) = False Then
            'MsgBox("กรุณาป้อนเวลาให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmTimeKaRS", Me.Text, "Check_Time", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.check_time, MsgBoxStyle.Information, Me.Text)
            txtMidDayStop.Focus()
            Exit Sub
        End If

        If IsNumeric(txtKa_flexible_hour.Text) = False Then txtKa_flexible_hour.Text = "0"

        If chkKA_flexible.Checked = True Then
            If CSng(txtKa_flexible_hour.Text) <= 0 Then
                '   MsgBox("จน.ชม.ทำงานควรมากกว่า 0", MsgBoxStyle.Information, Me.Text)
                MsgBox(My.Resources.res_warning_message_spacial.Amount_hr_over_zero, MsgBoxStyle.Information, Me.Text)
                txtKa_flexible_hour.Focus()
                Exit Sub
            End If
        End If

        Dim Dcmd As New SqlCommand
        Dim strSQL As String
        Try


            If chkka_default.Checked = True Then
                strSQL = "Update TimeKa Set ka_default = 0 "

                Dcmd.Connection = Conn
                Dcmd.CommandText = strSQL
                Dcmd.ExecuteNonQuery()
            End If

            strSQL = "Update TimeKa Set KaName = '" & txtGroupName.Text.Trim & "'" &
                                        " ,TimeST = '" & txtTimeST.Text.Trim & "'" &
                                        " ,TimeST_to = '" & txtTimeST_To.Text.Trim & "'" &
                                        " ,TimeSP = '" & txtTimeSP.Text.Trim & "'" &
                                        " ,RestST = '" & txtMidDayStart.Text.Trim & "'" &
                                        " ,RestSP = '" & txtMidDayStop.Text.Trim & "'" &
                                        " ,StartDay = '" & txtStartDay.Text.Trim & "'" &
                                        " ,EndDay = '" & txtEndDay.Text.Trim & "'" &
                                        " ,RestST_ND = " & IIf(chkMidDayStart_NextDay.Checked = True, 1, 0) &
                                        " ,RestSP_ND = " & IIf(chkMidDayStop_NextDay.Checked = True, 1, 0) &
                                        " ,TimeSP_ND = " & IIf(chkTimeSP_NextDay.Checked = True, 1, 0) &
                                        " ,StartDay_PD = " & IIf(chkStartDay_PD.Checked = True, 1, 0) &
                                        " ,EndDay_ND = " & IIf(chkTimeEndDay_NextDay.Checked = True, 1, 0) &
                                        " ,Monday = " & IIf(chkMonDay.Checked = True, 1, 0) &
                                        " ,Tuesday = " & IIf(chkTuesday.Checked = True, 1, 0) &
                                        " ,Wednesday = " & IIf(chkWednesday.Checked = True, 1, 0) &
                                        " ,Thursday = " & IIf(chkThursday.Checked = True, 1, 0) &
                                        " ,Friday = " & IIf(chkFriday.Checked = True, 1, 0) &
                                        " ,Saturday = " & IIf(chkSaturday.Checked = True, 1, 0) &
                                        " ,Sunday =" & IIf(chkSunday.Checked = True, 1, 0) &
                                        " ,ka_default =" & IIf(chkka_default.Checked = True, 1, 0) &
                                        " ,ka_flexible =" & IIf(chkKA_flexible.Checked = True, 1, 0) &
                                        " ,ka_flexible_hour =" & txtKa_flexible_hour.EditValue & " " &
                    " Where KA_Code = '" & txtGroupId.Text.Trim & "'"
            Dcmd.Connection = Conn
            Dcmd.CommandText = strSQL
            Dcmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
            Exit Sub
        End Try
        Call btnRefresh_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim Dcmd As New SqlCommand
        Dim strSQL As String
        '  If MsgBox("คุณต้องการลบข้อมูลนี้หรือไม่", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then Exit Sub
        If MsgBox(My.Resources.res_warning_message.Confirm_Del, MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = vbNo Then Exit Sub

        'If MsgManager.ConfirmDialog(Me, "frmTimeKaRS", Me.Text, "Confirm_Del",
        'MessageBoxIcon.Information) = DialogResult.Cancel Then Exit Sub
        'If IsUse(txtGroupId.Text.Trim) = True Then
        '    MsgBox("ข้อมูลนี้ไฟล์ข้อมูลพนักงานใช้งานอยู่ไม่สามารถลบได้", MsgBoxStyle.Information, Me.Text)
        '    Exit Sub
        'End If
        Try
            strSQL = "Delete From TimeKa Where KA_Code = '" & txtGroupId.Text.Trim & "'"
            Dcmd.Connection = Conn
            Dcmd.CommandText = strSQL
            Dcmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
            Exit Sub
        End Try
        Call btnRefresh_Click(Me, System.EventArgs.Empty)
    End Sub

    Function IsUse(ByVal GroupId As String) As Boolean
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim strSQL As String
        Dim Use As Boolean
        strSQL = "Select Code From Emp Where KA_Code = '" & GroupId.Trim & "'"
        DA = New SqlDataAdapter(strSQL, Conn)
        DA.Fill(DS, "Emp")
        If DS.Tables("Emp").Rows.Count = 0 Then
            Use = False
        Else
            Use = True
        End If
        DS.Clear()
        Return Use
    End Function

    Private Sub frmSubjectGroup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        On Error Resume Next
        If Asc(e.KeyChar) = 13 Then
            'If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            If TypeOf Me.ActiveControl Is TextBox Then
                Dim tb As TextBox = DirectCast(Me.ActiveControl, TextBox)
                If tb.Multiline AndAlso tb.AcceptsReturn Then
                    e.Handled = False
                    Exit Sub
                End If
            End If
            e.Handled = True
            Dim oform As Form = Me.FindForm
            oform.SelectNextControl(oform.ActiveControl, True, True, True, True)
            oform.ActiveControl.Focus()
        End If
    End Sub

    Private Sub chkMidDayStart_NextDay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMidDayStart_NextDay.CheckedChanged
        If chkMidDayStart_NextDay.Checked = True Then
            chkMidDayStop_NextDay.Checked = True
            chkTimeSP_NextDay.Checked = True
            chkTimeEndDay_NextDay.Checked = True

            chkMidDayStop_NextDay.Enabled = False
            chkTimeSP_NextDay.Enabled = False
            chkTimeEndDay_NextDay.Enabled = False
        Else
            chkMidDayStop_NextDay.Checked = False
            chkTimeSP_NextDay.Checked = False
            chkTimeEndDay_NextDay.Checked = False

            chkMidDayStop_NextDay.Enabled = True
            chkTimeSP_NextDay.Enabled = True
            chkTimeEndDay_NextDay.Enabled = True
        End If
    End Sub

    Private Sub chkMidDayStop_NextDay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMidDayStop_NextDay.CheckedChanged
        If chkMidDayStop_NextDay.Checked = True Then
            chkTimeSP_NextDay.Checked = True
            chkTimeEndDay_NextDay.Checked = True

            chkTimeSP_NextDay.Enabled = False
            chkTimeEndDay_NextDay.Enabled = False
        Else
            chkTimeSP_NextDay.Checked = False
            chkTimeEndDay_NextDay.Checked = False

            chkTimeSP_NextDay.Enabled = True
            chkTimeEndDay_NextDay.Enabled = True
        End If
    End Sub

    Private Sub chkTimeSP_NextDay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTimeSP_NextDay.CheckedChanged
        If chkTimeSP_NextDay.Checked = True Then
            chkTimeEndDay_NextDay.Checked = True

            chkTimeEndDay_NextDay.Enabled = False
        Else
            chkTimeEndDay_NextDay.Checked = False

            chkTimeEndDay_NextDay.Enabled = True
        End If
    End Sub

    'Private Sub GvVacation_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GvSubjectGroup.CustomDrawCell
    '    If e.Column.Name = "colrow" Then
    '        If e.RowHandle < -1 Then
    '            e.DisplayText = "0"
    '        Else
    '            e.DisplayText = (e.RowHandle + 1).ToString
    '        End If
    '    End If

    'End Sub

    Private Sub GcSubjectGroup_Click(sender As Object, e As EventArgs) Handles GcSubjectGroup.Click

    End Sub

    Private Sub GvSubjectGroup_DoubleClick(sender As Object, e As EventArgs) Handles GvSubjectGroup.DoubleClick
        'With lstSubjectGroup
        '    If .Items.Count = 0 Then Exit Sub
        '    If .SelectedItems.Count = 0 Then Exit Sub
        '    txtGroupId.Text = .SelectedItems(0).SubItems(0).Text.Trim
        '    Call txtGroupId_LostFocus(Me, System.EventArgs.Empty)
        '    txtGroupName.Focus()
        '    Call EnaCmd(False, True, True)
        'End With


        Try
            Dim gv As GridView = CType(sender, GridView)
            txtGroupId.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "KA_Code")
            Call txtGroupId_LostFocus(Me, System.EventArgs.Empty)
            txtGroupName.Focus()
            Call EnaCmd(False, True, True)

        Catch ex As Exception

        End Try


    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub chkKA_flexible_CheckedChanged(sender As Object, e As EventArgs) Handles chkKA_flexible.CheckedChanged
        Call Enable_flexible() ' เปิดปิด ช่องป้อนเวลาเข้าออกตามกะ
    End Sub

    Private Sub txtGroupId_EditValueChanged(sender As Object, e As EventArgs) Handles txtGroupId.EditValueChanged

    End Sub
End Class
