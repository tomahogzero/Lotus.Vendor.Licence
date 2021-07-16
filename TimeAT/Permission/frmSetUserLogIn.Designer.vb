<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSetUserLogIn
    '  Inherits frmBasicPage2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetUserLogIn))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.grpLeft = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GcEmp = New DevExpress.XtraGrid.GridControl()
        Me.GvEmp = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode_lar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cboTransport_detail = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboUnitName = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btnShowData = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbDivistionId = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbDepartMent = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.grpRight = New DevExpress.XtraEditors.GroupControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cboPerGroupName = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblPerGroupName = New System.Windows.Forms.Label()
        Me.btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Gcmenu_use = New DevExpress.XtraGrid.GridControl()
        Me.Gvmenu_use = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.grpEditMenubyOne = New DevExpress.XtraEditors.PanelControl()
        Me.btnEditMenu_byOne = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNameedit = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodeEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabMenu = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.mnuDailyUpdate = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuInputLeaveData = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuManageTime = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuPermissionTimeAtt = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuabsenceTime = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuOvertime = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuLateTime = New DevExpress.XtraEditors.CheckEdit()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraScrollableControl2 = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.mnuEmp = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuDepartment = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuDivision = New DevExpress.XtraEditors.CheckEdit()
        Me.MenuWorkHolidaySpacial = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuConfiguration = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuSetholiday = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuMConfig = New DevExpress.XtraEditors.CheckEdit()
        Me.mnucalculationAbs = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuCompanyCenter = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuSetCancelDelayOTByDay = New DevExpress.XtraEditors.CheckEdit()
        Me.mnumodelcalculations = New DevExpress.XtraEditors.CheckEdit()
        Me.mnusetdelayOT = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuMWorkTime = New DevExpress.XtraEditors.CheckEdit()
        Me.mnusetdelaytime1 = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuMOpenCalculate = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuOTbyDay = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuMVacationHolYear = New DevExpress.XtraEditors.CheckEdit()
        Me.mnusetOT = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuMOtherCondition = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuOTBasic = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuworkinggroup = New DevExpress.XtraEditors.CheckEdit()
        Me.mnulimitOT = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuSpacialKa = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuSetabsenceTimeByYear = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuDeterminedTime = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuOT = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuDeterminedTimeEmp = New DevExpress.XtraEditors.CheckEdit()
        Me.mnucalculationLate = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuDeterminedTimeEmpByOne = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuSetLeave = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuDeterminedTimeEmpByDate = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuProcessOT = New DevExpress.XtraEditors.CheckEdit()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraScrollableControl3 = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.mnurptScheduleWorkAllEmp2 = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuReport = New DevExpress.XtraEditors.CheckEdit()
        Me.munOvertimeLeage = New DevExpress.XtraEditors.CheckEdit()
        Me.mnurptTimeWork = New DevExpress.XtraEditors.CheckEdit()
        Me.mnurptAllemployeework2 = New DevExpress.XtraEditors.CheckEdit()
        Me.mnurptemployeeByDate = New DevExpress.XtraEditors.CheckEdit()
        Me.mnurptEmpWorkDetail1_M = New DevExpress.XtraEditors.CheckEdit()
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraScrollableControl4 = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.mnuPerUser = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuPermission = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuPerPattern = New DevExpress.XtraEditors.CheckEdit()
        Me.mnuUserPass = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.PG = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.lblEmpId = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblName = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.AdvTree2 = New DevComponents.AdvTree.AdvTree()
        Me.Node3 = New DevComponents.AdvTree.Node()
        Me.NodeConnector3 = New DevComponents.AdvTree.NodeConnector()
        Me.ElementStyle2 = New DevComponents.DotNetBar.ElementStyle()
        Me.lstEmp = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.colNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.collastname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Bar3 = New DevComponents.DotNetBar.Bar()
        Me.btnPlusAll = New DevComponents.DotNetBar.ButtonX()
        Me.BtnExpland = New DevComponents.DotNetBar.ButtonX()
        Me.ControlContainerItem1 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.ControlContainerItem2 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.btnNotAll = New DevComponents.DotNetBar.ButtonX()
        Me.btnAll = New DevComponents.DotNetBar.ButtonX()
        Me.btnexit = New DevExpress.XtraEditors.SimpleButton()
        Me.ProgressBarX1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.pnlApp = New System.Windows.Forms.Panel()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.grpLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLeft.SuspendLayout()
        CType(Me.GcEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDivistionId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDepartMent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRight.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cboPerGroupName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.Gcmenu_use, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gvmenu_use, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.grpEditMenubyOne, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEditMenubyOne.SuspendLayout()
        CType(Me.txtNameedit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodeEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMenu.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.XtraScrollableControl1.SuspendLayout()
        CType(Me.mnuDailyUpdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuInputLeaveData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuManageTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuPermissionTimeAtt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuabsenceTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuOvertime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuLateTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        Me.XtraScrollableControl2.SuspendLayout()
        CType(Me.mnuEmp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuDivision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuWorkHolidaySpacial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuConfiguration.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuSetholiday.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuMConfig.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnucalculationAbs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuCompanyCenter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuSetCancelDelayOTByDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnumodelcalculations.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnusetdelayOT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuMWorkTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnusetdelaytime1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuMOpenCalculate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuOTbyDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuMVacationHolYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnusetOT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuMOtherCondition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuOTBasic.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuworkinggroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnulimitOT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuSpacialKa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuSetabsenceTimeByYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuDeterminedTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuOT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuDeterminedTimeEmp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnucalculationLate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuDeterminedTimeEmpByOne.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuSetLeave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuDeterminedTimeEmpByDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuProcessOT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage5.SuspendLayout()
        Me.XtraScrollableControl3.SuspendLayout()
        CType(Me.mnurptScheduleWorkAllEmp2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuReport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.munOvertimeLeage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnurptTimeWork.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnurptAllemployeework2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnurptemployeeByDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnurptEmpWorkDetail1_M.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage6.SuspendLayout()
        Me.XtraScrollableControl4.SuspendLayout()
        CType(Me.mnuPerUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuPermission.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuPerPattern.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuUserPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.AdvTree2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar3.SuspendLayout()
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
        Me.grpLeft.Controls.Add(Me.LabelControl2)
        Me.grpLeft.Controls.Add(Me.LabelControl1)
        Me.grpLeft.Controls.Add(Me.GcEmp)
        Me.grpLeft.Controls.Add(Me.btnShowData)
        Me.grpLeft.Controls.Add(Me.cmbDivistionId)
        Me.grpLeft.Controls.Add(Me.btnAdd)
        Me.grpLeft.Controls.Add(Me.cmbDepartMent)
        Me.grpLeft.Name = "grpLeft"
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
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
        Me.GvEmp.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colrow, Me.GridColumn15, Me.GridColumn7, Me.colcode_lar, Me.GridColumn1, Me.GridColumn2, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13})
        Me.GvEmp.GridControl = Me.GcEmp
        Me.GvEmp.Name = "GvEmp"
        Me.GvEmp.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.GvEmp.OptionsSelection.MultiSelect = True
        Me.GvEmp.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GvEmp.OptionsView.ColumnAutoWidth = False
        Me.GvEmp.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
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
        'GridColumn15
        '
        Me.GridColumn15.AppearanceCell.BackColor = CType(resources.GetObject("GridColumn15.AppearanceCell.BackColor"), System.Drawing.Color)
        Me.GridColumn15.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GridColumn15.AppearanceCell.FontSizeDelta"), Integer)
        Me.GridColumn15.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GridColumn15.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridColumn15.AppearanceCell.GradientMode = CType(resources.GetObject("GridColumn15.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn15.AppearanceCell.Image = CType(resources.GetObject("GridColumn15.AppearanceCell.Image"), System.Drawing.Image)
        Me.GridColumn15.AppearanceCell.Options.UseBackColor = True
        resources.ApplyResources(Me.GridColumn15, "GridColumn15")
        Me.GridColumn15.FieldName = "GroupPer"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.BackColor = CType(resources.GetObject("GridColumn7.AppearanceCell.BackColor"), System.Drawing.Color)
        Me.GridColumn7.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GridColumn7.AppearanceCell.FontSizeDelta"), Integer)
        Me.GridColumn7.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GridColumn7.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridColumn7.AppearanceCell.GradientMode = CType(resources.GetObject("GridColumn7.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn7.AppearanceCell.Image = CType(resources.GetObject("GridColumn7.AppearanceCell.Image"), System.Drawing.Image)
        Me.GridColumn7.AppearanceCell.Options.UseBackColor = True
        resources.ApplyResources(Me.GridColumn7, "GridColumn7")
        Me.GridColumn7.FieldName = "username"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        '
        'colcode_lar
        '
        resources.ApplyResources(Me.colcode_lar, "colcode_lar")
        Me.colcode_lar.FieldName = "UserID"
        Me.colcode_lar.Name = "colcode_lar"
        Me.colcode_lar.OptionsColumn.AllowEdit = False
        Me.colcode_lar.OptionsColumn.ReadOnly = True
        '
        'GridColumn1
        '
        resources.ApplyResources(Me.GridColumn1, "GridColumn1")
        Me.GridColumn1.FieldName = "Fname"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'GridColumn2
        '
        resources.ApplyResources(Me.GridColumn2, "GridColumn2")
        Me.GridColumn2.FieldName = "Lname"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        '
        'GridColumn11
        '
        resources.ApplyResources(Me.GridColumn11, "GridColumn11")
        Me.GridColumn11.FieldName = "Division"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        '
        'GridColumn12
        '
        resources.ApplyResources(Me.GridColumn12, "GridColumn12")
        Me.GridColumn12.FieldName = "Department"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        '
        'GridColumn13
        '
        resources.ApplyResources(Me.GridColumn13, "GridColumn13")
        Me.GridColumn13.FieldName = "Position"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.OptionsColumn.ReadOnly = True
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
        'btnShowData
        '
        resources.ApplyResources(Me.btnShowData, "btnShowData")
        Me.btnShowData.Appearance.FontSizeDelta = CType(resources.GetObject("btnShowData.Appearance.FontSizeDelta"), Integer)
        Me.btnShowData.Appearance.FontStyleDelta = CType(resources.GetObject("btnShowData.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.btnShowData.Appearance.GradientMode = CType(resources.GetObject("btnShowData.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.btnShowData.Appearance.Image = CType(resources.GetObject("btnShowData.Appearance.Image"), System.Drawing.Image)
        Me.btnShowData.Appearance.Options.UseTextOptions = True
        Me.btnShowData.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnShowData.ImageOptions.Image = CType(resources.GetObject("btnShowData.ImageOptions.Image"), System.Drawing.Image)
        Me.btnShowData.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnShowData.Name = "btnShowData"
        '
        'cmbDivistionId
        '
        resources.ApplyResources(Me.cmbDivistionId, "cmbDivistionId")
        Me.cmbDivistionId.Name = "cmbDivistionId"
        Me.cmbDivistionId.Properties.AccessibleDescription = resources.GetString("cmbDivistionId.Properties.AccessibleDescription")
        Me.cmbDivistionId.Properties.AccessibleName = resources.GetString("cmbDivistionId.Properties.AccessibleName")
        Me.cmbDivistionId.Properties.AutoHeight = CType(resources.GetObject("cmbDivistionId.Properties.AutoHeight"), Boolean)
        Me.cmbDivistionId.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbDivistionId.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbDivistionId.Properties.DropDownRows = 15
        Me.cmbDivistionId.Properties.NullValuePrompt = resources.GetString("cmbDivistionId.Properties.NullValuePrompt")
        Me.cmbDivistionId.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("cmbDivistionId.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.cmbDivistionId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
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
        'cmbDepartMent
        '
        resources.ApplyResources(Me.cmbDepartMent, "cmbDepartMent")
        Me.cmbDepartMent.Name = "cmbDepartMent"
        Me.cmbDepartMent.Properties.AccessibleDescription = resources.GetString("cmbDepartMent.Properties.AccessibleDescription")
        Me.cmbDepartMent.Properties.AccessibleName = resources.GetString("cmbDepartMent.Properties.AccessibleName")
        Me.cmbDepartMent.Properties.AutoHeight = CType(resources.GetObject("cmbDepartMent.Properties.AutoHeight"), Boolean)
        Me.cmbDepartMent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbDepartMent.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbDepartMent.Properties.DropDownRows = 15
        Me.cmbDepartMent.Properties.NullValuePrompt = resources.GetString("cmbDepartMent.Properties.NullValuePrompt")
        Me.cmbDepartMent.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("cmbDepartMent.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.cmbDepartMent.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'grpRight
        '
        resources.ApplyResources(Me.grpRight, "grpRight")
        Me.grpRight.Controls.Add(Me.PanelControl1)
        Me.grpRight.Controls.Add(Me.btnRemove)
        Me.grpRight.Controls.Add(Me.XtraTabControl1)
        Me.grpRight.Name = "grpRight"
        '
        'PanelControl1
        '
        resources.ApplyResources(Me.PanelControl1, "PanelControl1")
        Me.PanelControl1.Controls.Add(Me.cboPerGroupName)
        Me.PanelControl1.Controls.Add(Me.lblPerGroupName)
        Me.PanelControl1.Name = "PanelControl1"
        '
        'cboPerGroupName
        '
        resources.ApplyResources(Me.cboPerGroupName, "cboPerGroupName")
        Me.cboPerGroupName.EnterMoveNextControl = True
        Me.cboPerGroupName.Name = "cboPerGroupName"
        Me.cboPerGroupName.Properties.AccessibleDescription = resources.GetString("cboPerGroupName.Properties.AccessibleDescription")
        Me.cboPerGroupName.Properties.AccessibleName = resources.GetString("cboPerGroupName.Properties.AccessibleName")
        Me.cboPerGroupName.Properties.AutoHeight = CType(resources.GetObject("cboPerGroupName.Properties.AutoHeight"), Boolean)
        Me.cboPerGroupName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboPerGroupName.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboPerGroupName.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("cboPerGroupName.Properties.Columns"), resources.GetString("cboPerGroupName.Properties.Columns1"))})
        Me.cboPerGroupName.Properties.NullText = resources.GetString("cboPerGroupName.Properties.NullText")
        Me.cboPerGroupName.Properties.NullValuePrompt = resources.GetString("cboPerGroupName.Properties.NullValuePrompt")
        Me.cboPerGroupName.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("cboPerGroupName.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.cboPerGroupName.Properties.ShowHeader = False
        '
        'lblPerGroupName
        '
        resources.ApplyResources(Me.lblPerGroupName, "lblPerGroupName")
        Me.lblPerGroupName.Name = "lblPerGroupName"
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
        'XtraTabControl1
        '
        resources.ApplyResources(Me.XtraTabControl1, "XtraTabControl1")
        Me.XtraTabControl1.AppearancePage.HeaderActive.Font = CType(resources.GetObject("XtraTabControl1.AppearancePage.HeaderActive.Font"), System.Drawing.Font)
        Me.XtraTabControl1.AppearancePage.HeaderActive.FontSizeDelta = CType(resources.GetObject("XtraTabControl1.AppearancePage.HeaderActive.FontSizeDelta"), Integer)
        Me.XtraTabControl1.AppearancePage.HeaderActive.FontStyleDelta = CType(resources.GetObject("XtraTabControl1.AppearancePage.HeaderActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.XtraTabControl1.AppearancePage.HeaderActive.GradientMode = CType(resources.GetObject("XtraTabControl1.AppearancePage.HeaderActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.XtraTabControl1.AppearancePage.HeaderActive.Image = CType(resources.GetObject("XtraTabControl1.AppearancePage.HeaderActive.Image"), System.Drawing.Image)
        Me.XtraTabControl1.AppearancePage.HeaderActive.Options.UseFont = True
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        resources.ApplyResources(Me.XtraTabPage1, "XtraTabPage1")
        Me.XtraTabPage1.Controls.Add(Me.Gcmenu_use)
        Me.XtraTabPage1.Image = CType(resources.GetObject("XtraTabPage1.Image"), System.Drawing.Image)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        '
        'Gcmenu_use
        '
        resources.ApplyResources(Me.Gcmenu_use, "Gcmenu_use")
        Me.Gcmenu_use.EmbeddedNavigator.AccessibleDescription = resources.GetString("Gcmenu_use.EmbeddedNavigator.AccessibleDescription")
        Me.Gcmenu_use.EmbeddedNavigator.AccessibleName = resources.GetString("Gcmenu_use.EmbeddedNavigator.AccessibleName")
        Me.Gcmenu_use.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("Gcmenu_use.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.Gcmenu_use.EmbeddedNavigator.Anchor = CType(resources.GetObject("Gcmenu_use.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Gcmenu_use.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("Gcmenu_use.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.Gcmenu_use.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("Gcmenu_use.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.Gcmenu_use.EmbeddedNavigator.ImeMode = CType(resources.GetObject("Gcmenu_use.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Gcmenu_use.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("Gcmenu_use.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.Gcmenu_use.EmbeddedNavigator.TextLocation = CType(resources.GetObject("Gcmenu_use.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.Gcmenu_use.EmbeddedNavigator.ToolTip = resources.GetString("Gcmenu_use.EmbeddedNavigator.ToolTip")
        Me.Gcmenu_use.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("Gcmenu_use.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.Gcmenu_use.EmbeddedNavigator.ToolTipTitle = resources.GetString("Gcmenu_use.EmbeddedNavigator.ToolTipTitle")
        Me.Gcmenu_use.MainView = Me.Gvmenu_use
        Me.Gcmenu_use.Name = "Gcmenu_use"
        Me.Gcmenu_use.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.Gcmenu_use.TabStop = False
        Me.Gcmenu_use.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gvmenu_use})
        '
        'Gvmenu_use
        '
        Me.Gvmenu_use.Appearance.HeaderPanel.Font = CType(resources.GetObject("Gvmenu_use.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.Gvmenu_use.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("Gvmenu_use.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.Gvmenu_use.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("Gvmenu_use.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.Gvmenu_use.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("Gvmenu_use.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.Gvmenu_use.Appearance.HeaderPanel.Image = CType(resources.GetObject("Gvmenu_use.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.Gvmenu_use.Appearance.HeaderPanel.Options.UseFont = True
        Me.Gvmenu_use.Appearance.Row.FontSizeDelta = CType(resources.GetObject("Gvmenu_use.Appearance.Row.FontSizeDelta"), Integer)
        Me.Gvmenu_use.Appearance.Row.FontStyleDelta = CType(resources.GetObject("Gvmenu_use.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.Gvmenu_use.Appearance.Row.GradientMode = CType(resources.GetObject("Gvmenu_use.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.Gvmenu_use.Appearance.Row.Image = CType(resources.GetObject("Gvmenu_use.Appearance.Row.Image"), System.Drawing.Image)
        Me.Gvmenu_use.Appearance.Row.Options.UseFont = True
        resources.ApplyResources(Me.Gvmenu_use, "Gvmenu_use")
        Me.Gvmenu_use.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn14, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.Gvmenu_use.GridControl = Me.Gcmenu_use
        Me.Gvmenu_use.Name = "Gvmenu_use"
        Me.Gvmenu_use.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.Gvmenu_use.OptionsSelection.MultiSelect = True
        Me.Gvmenu_use.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.Gvmenu_use.OptionsView.ColumnAutoWidth = False
        Me.Gvmenu_use.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.Gvmenu_use.OptionsView.ShowAutoFilterRow = True
        Me.Gvmenu_use.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GridColumn3.AppearanceCell.FontSizeDelta"), Integer)
        Me.GridColumn3.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GridColumn3.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridColumn3.AppearanceCell.GradientMode = CType(resources.GetObject("GridColumn3.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn3.AppearanceCell.Image = CType(resources.GetObject("GridColumn3.AppearanceCell.Image"), System.Drawing.Image)
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GridColumn3.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GridColumn3.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GridColumn3.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridColumn3.AppearanceHeader.GradientMode = CType(resources.GetObject("GridColumn3.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn3.AppearanceHeader.Image = CType(resources.GetObject("GridColumn3.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn3, "GridColumn3")
        Me.GridColumn3.FieldName = "row"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.TabStop = False
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceCell.BackColor = CType(resources.GetObject("GridColumn14.AppearanceCell.BackColor"), System.Drawing.Color)
        Me.GridColumn14.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GridColumn14.AppearanceCell.FontSizeDelta"), Integer)
        Me.GridColumn14.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GridColumn14.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridColumn14.AppearanceCell.GradientMode = CType(resources.GetObject("GridColumn14.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn14.AppearanceCell.Image = CType(resources.GetObject("GridColumn14.AppearanceCell.Image"), System.Drawing.Image)
        Me.GridColumn14.AppearanceCell.Options.UseBackColor = True
        resources.ApplyResources(Me.GridColumn14, "GridColumn14")
        Me.GridColumn14.FieldName = "username"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        '
        'GridColumn4
        '
        resources.ApplyResources(Me.GridColumn4, "GridColumn4")
        Me.GridColumn4.FieldName = "UserID"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        '
        'GridColumn5
        '
        resources.ApplyResources(Me.GridColumn5, "GridColumn5")
        Me.GridColumn5.FieldName = "Fname"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        '
        'GridColumn6
        '
        resources.ApplyResources(Me.GridColumn6, "GridColumn6")
        Me.GridColumn6.FieldName = "Lname"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        '
        'GridColumn8
        '
        resources.ApplyResources(Me.GridColumn8, "GridColumn8")
        Me.GridColumn8.FieldName = "Division"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        '
        'GridColumn9
        '
        resources.ApplyResources(Me.GridColumn9, "GridColumn9")
        Me.GridColumn9.FieldName = "Department"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.ReadOnly = True
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
        'XtraTabPage2
        '
        resources.ApplyResources(Me.XtraTabPage2, "XtraTabPage2")
        Me.XtraTabPage2.Controls.Add(Me.grpEditMenubyOne)
        Me.XtraTabPage2.Controls.Add(Me.tabMenu)
        Me.XtraTabPage2.Image = CType(resources.GetObject("XtraTabPage2.Image"), System.Drawing.Image)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.PageVisible = False
        '
        'grpEditMenubyOne
        '
        resources.ApplyResources(Me.grpEditMenubyOne, "grpEditMenubyOne")
        Me.grpEditMenubyOne.Controls.Add(Me.btnEditMenu_byOne)
        Me.grpEditMenubyOne.Controls.Add(Me.txtNameedit)
        Me.grpEditMenubyOne.Controls.Add(Me.txtCodeEdit)
        Me.grpEditMenubyOne.Controls.Add(Me.Label2)
        Me.grpEditMenubyOne.Name = "grpEditMenubyOne"
        '
        'btnEditMenu_byOne
        '
        resources.ApplyResources(Me.btnEditMenu_byOne, "btnEditMenu_byOne")
        Me.btnEditMenu_byOne.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnEditMenu_byOne.Name = "btnEditMenu_byOne"
        '
        'txtNameedit
        '
        resources.ApplyResources(Me.txtNameedit, "txtNameedit")
        Me.txtNameedit.Name = "txtNameedit"
        Me.txtNameedit.Properties.AccessibleDescription = resources.GetString("txtNameedit.Properties.AccessibleDescription")
        Me.txtNameedit.Properties.AccessibleName = resources.GetString("txtNameedit.Properties.AccessibleName")
        Me.txtNameedit.Properties.Appearance.BackColor = CType(resources.GetObject("txtNameedit.Properties.Appearance.BackColor"), System.Drawing.Color)
        Me.txtNameedit.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtNameedit.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtNameedit.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtNameedit.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtNameedit.Properties.Appearance.GradientMode = CType(resources.GetObject("txtNameedit.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtNameedit.Properties.Appearance.Image = CType(resources.GetObject("txtNameedit.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtNameedit.Properties.Appearance.Options.UseBackColor = True
        Me.txtNameedit.Properties.AutoHeight = CType(resources.GetObject("txtNameedit.Properties.AutoHeight"), Boolean)
        Me.txtNameedit.Properties.Mask.AutoComplete = CType(resources.GetObject("txtNameedit.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtNameedit.Properties.Mask.BeepOnError = CType(resources.GetObject("txtNameedit.Properties.Mask.BeepOnError"), Boolean)
        Me.txtNameedit.Properties.Mask.EditMask = resources.GetString("txtNameedit.Properties.Mask.EditMask")
        Me.txtNameedit.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtNameedit.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtNameedit.Properties.Mask.MaskType = CType(resources.GetObject("txtNameedit.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtNameedit.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtNameedit.Properties.Mask.PlaceHolder"), Char)
        Me.txtNameedit.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtNameedit.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtNameedit.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtNameedit.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtNameedit.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtNameedit.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtNameedit.Properties.NullValuePrompt = resources.GetString("txtNameedit.Properties.NullValuePrompt")
        Me.txtNameedit.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtNameedit.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'txtCodeEdit
        '
        resources.ApplyResources(Me.txtCodeEdit, "txtCodeEdit")
        Me.txtCodeEdit.Name = "txtCodeEdit"
        Me.txtCodeEdit.Properties.AccessibleDescription = resources.GetString("txtCodeEdit.Properties.AccessibleDescription")
        Me.txtCodeEdit.Properties.AccessibleName = resources.GetString("txtCodeEdit.Properties.AccessibleName")
        Me.txtCodeEdit.Properties.Appearance.BackColor = CType(resources.GetObject("txtCodeEdit.Properties.Appearance.BackColor"), System.Drawing.Color)
        Me.txtCodeEdit.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtCodeEdit.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtCodeEdit.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtCodeEdit.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtCodeEdit.Properties.Appearance.GradientMode = CType(resources.GetObject("txtCodeEdit.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtCodeEdit.Properties.Appearance.Image = CType(resources.GetObject("txtCodeEdit.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtCodeEdit.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodeEdit.Properties.AutoHeight = CType(resources.GetObject("txtCodeEdit.Properties.AutoHeight"), Boolean)
        Me.txtCodeEdit.Properties.Mask.AutoComplete = CType(resources.GetObject("txtCodeEdit.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtCodeEdit.Properties.Mask.BeepOnError = CType(resources.GetObject("txtCodeEdit.Properties.Mask.BeepOnError"), Boolean)
        Me.txtCodeEdit.Properties.Mask.EditMask = resources.GetString("txtCodeEdit.Properties.Mask.EditMask")
        Me.txtCodeEdit.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtCodeEdit.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtCodeEdit.Properties.Mask.MaskType = CType(resources.GetObject("txtCodeEdit.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtCodeEdit.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtCodeEdit.Properties.Mask.PlaceHolder"), Char)
        Me.txtCodeEdit.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtCodeEdit.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtCodeEdit.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtCodeEdit.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtCodeEdit.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtCodeEdit.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtCodeEdit.Properties.NullValuePrompt = resources.GetString("txtCodeEdit.Properties.NullValuePrompt")
        Me.txtCodeEdit.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtCodeEdit.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'tabMenu
        '
        resources.ApplyResources(Me.tabMenu, "tabMenu")
        Me.tabMenu.AppearancePage.HeaderActive.Font = CType(resources.GetObject("tabMenu.AppearancePage.HeaderActive.Font"), System.Drawing.Font)
        Me.tabMenu.AppearancePage.HeaderActive.FontSizeDelta = CType(resources.GetObject("tabMenu.AppearancePage.HeaderActive.FontSizeDelta"), Integer)
        Me.tabMenu.AppearancePage.HeaderActive.FontStyleDelta = CType(resources.GetObject("tabMenu.AppearancePage.HeaderActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.tabMenu.AppearancePage.HeaderActive.GradientMode = CType(resources.GetObject("tabMenu.AppearancePage.HeaderActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.tabMenu.AppearancePage.HeaderActive.Image = CType(resources.GetObject("tabMenu.AppearancePage.HeaderActive.Image"), System.Drawing.Image)
        Me.tabMenu.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabMenu.Name = "tabMenu"
        Me.tabMenu.SelectedTabPage = Me.XtraTabPage3
        Me.tabMenu.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5, Me.XtraTabPage6})
        '
        'XtraTabPage3
        '
        resources.ApplyResources(Me.XtraTabPage3, "XtraTabPage3")
        Me.XtraTabPage3.Appearance.Header.Font = CType(resources.GetObject("XtraTabPage3.Appearance.Header.Font"), System.Drawing.Font)
        Me.XtraTabPage3.Appearance.Header.FontSizeDelta = CType(resources.GetObject("XtraTabPage3.Appearance.Header.FontSizeDelta"), Integer)
        Me.XtraTabPage3.Appearance.Header.FontStyleDelta = CType(resources.GetObject("XtraTabPage3.Appearance.Header.FontStyleDelta"), System.Drawing.FontStyle)
        Me.XtraTabPage3.Appearance.Header.GradientMode = CType(resources.GetObject("XtraTabPage3.Appearance.Header.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.XtraTabPage3.Appearance.Header.Image = CType(resources.GetObject("XtraTabPage3.Appearance.Header.Image"), System.Drawing.Image)
        Me.XtraTabPage3.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage3.Appearance.HeaderActive.Font = CType(resources.GetObject("XtraTabPage3.Appearance.HeaderActive.Font"), System.Drawing.Font)
        Me.XtraTabPage3.Appearance.HeaderActive.FontSizeDelta = CType(resources.GetObject("XtraTabPage3.Appearance.HeaderActive.FontSizeDelta"), Integer)
        Me.XtraTabPage3.Appearance.HeaderActive.FontStyleDelta = CType(resources.GetObject("XtraTabPage3.Appearance.HeaderActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.XtraTabPage3.Appearance.HeaderActive.GradientMode = CType(resources.GetObject("XtraTabPage3.Appearance.HeaderActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.XtraTabPage3.Appearance.HeaderActive.Image = CType(resources.GetObject("XtraTabPage3.Appearance.HeaderActive.Image"), System.Drawing.Image)
        Me.XtraTabPage3.Appearance.HeaderActive.Options.UseFont = True
        Me.XtraTabPage3.Controls.Add(Me.XtraScrollableControl1)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        '
        'XtraScrollableControl1
        '
        resources.ApplyResources(Me.XtraScrollableControl1, "XtraScrollableControl1")
        Me.XtraScrollableControl1.Appearance.BackColor = CType(resources.GetObject("XtraScrollableControl1.Appearance.BackColor"), System.Drawing.Color)
        Me.XtraScrollableControl1.Appearance.FontSizeDelta = CType(resources.GetObject("XtraScrollableControl1.Appearance.FontSizeDelta"), Integer)
        Me.XtraScrollableControl1.Appearance.FontStyleDelta = CType(resources.GetObject("XtraScrollableControl1.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.XtraScrollableControl1.Appearance.GradientMode = CType(resources.GetObject("XtraScrollableControl1.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.XtraScrollableControl1.Appearance.Image = CType(resources.GetObject("XtraScrollableControl1.Appearance.Image"), System.Drawing.Image)
        Me.XtraScrollableControl1.Appearance.Options.UseBackColor = True
        Me.XtraScrollableControl1.Controls.Add(Me.mnuDailyUpdate)
        Me.XtraScrollableControl1.Controls.Add(Me.mnuInputLeaveData)
        Me.XtraScrollableControl1.Controls.Add(Me.mnuManageTime)
        Me.XtraScrollableControl1.Controls.Add(Me.mnuPermissionTimeAtt)
        Me.XtraScrollableControl1.Controls.Add(Me.mnuabsenceTime)
        Me.XtraScrollableControl1.Controls.Add(Me.mnuOvertime)
        Me.XtraScrollableControl1.Controls.Add(Me.mnuLateTime)
        Me.XtraScrollableControl1.Name = "XtraScrollableControl1"
        '
        'mnuDailyUpdate
        '
        resources.ApplyResources(Me.mnuDailyUpdate, "mnuDailyUpdate")
        Me.mnuDailyUpdate.Name = "mnuDailyUpdate"
        Me.mnuDailyUpdate.Properties.AccessibleDescription = resources.GetString("mnuDailyUpdate.Properties.AccessibleDescription")
        Me.mnuDailyUpdate.Properties.AccessibleName = resources.GetString("mnuDailyUpdate.Properties.AccessibleName")
        Me.mnuDailyUpdate.Properties.Appearance.Font = CType(resources.GetObject("mnuDailyUpdate.Properties.Appearance.Font"), System.Drawing.Font)
        Me.mnuDailyUpdate.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuDailyUpdate.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuDailyUpdate.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuDailyUpdate.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuDailyUpdate.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuDailyUpdate.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuDailyUpdate.Properties.Appearance.Image = CType(resources.GetObject("mnuDailyUpdate.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuDailyUpdate.Properties.Appearance.Options.UseFont = True
        Me.mnuDailyUpdate.Properties.AutoHeight = CType(resources.GetObject("mnuDailyUpdate.Properties.AutoHeight"), Boolean)
        Me.mnuDailyUpdate.Properties.Caption = resources.GetString("mnuDailyUpdate.Properties.Caption")
        Me.mnuDailyUpdate.Properties.DisplayValueChecked = resources.GetString("mnuDailyUpdate.Properties.DisplayValueChecked")
        Me.mnuDailyUpdate.Properties.DisplayValueGrayed = resources.GetString("mnuDailyUpdate.Properties.DisplayValueGrayed")
        Me.mnuDailyUpdate.Properties.DisplayValueUnchecked = resources.GetString("mnuDailyUpdate.Properties.DisplayValueUnchecked")
        Me.mnuDailyUpdate.Properties.ImageIndexChecked = 0
        Me.mnuDailyUpdate.Properties.ImageIndexGrayed = 1
        Me.mnuDailyUpdate.Properties.ImageIndexUnchecked = 2
        Me.mnuDailyUpdate.Tag = "MN01004"
        '
        'mnuInputLeaveData
        '
        resources.ApplyResources(Me.mnuInputLeaveData, "mnuInputLeaveData")
        Me.mnuInputLeaveData.Name = "mnuInputLeaveData"
        Me.mnuInputLeaveData.Properties.AccessibleDescription = resources.GetString("mnuInputLeaveData.Properties.AccessibleDescription")
        Me.mnuInputLeaveData.Properties.AccessibleName = resources.GetString("mnuInputLeaveData.Properties.AccessibleName")
        Me.mnuInputLeaveData.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuInputLeaveData.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuInputLeaveData.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuInputLeaveData.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuInputLeaveData.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuInputLeaveData.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuInputLeaveData.Properties.Appearance.Image = CType(resources.GetObject("mnuInputLeaveData.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuInputLeaveData.Properties.Appearance.Options.UseFont = True
        Me.mnuInputLeaveData.Properties.AutoHeight = CType(resources.GetObject("mnuInputLeaveData.Properties.AutoHeight"), Boolean)
        Me.mnuInputLeaveData.Properties.Caption = resources.GetString("mnuInputLeaveData.Properties.Caption")
        Me.mnuInputLeaveData.Properties.DisplayValueChecked = resources.GetString("mnuInputLeaveData.Properties.DisplayValueChecked")
        Me.mnuInputLeaveData.Properties.DisplayValueGrayed = resources.GetString("mnuInputLeaveData.Properties.DisplayValueGrayed")
        Me.mnuInputLeaveData.Properties.DisplayValueUnchecked = resources.GetString("mnuInputLeaveData.Properties.DisplayValueUnchecked")
        Me.mnuInputLeaveData.Properties.PictureChecked = CType(resources.GetObject("mnuInputLeaveData.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuInputLeaveData.Tag = "MN01012"
        '
        'mnuManageTime
        '
        resources.ApplyResources(Me.mnuManageTime, "mnuManageTime")
        Me.mnuManageTime.Name = "mnuManageTime"
        Me.mnuManageTime.Properties.AccessibleDescription = resources.GetString("mnuManageTime.Properties.AccessibleDescription")
        Me.mnuManageTime.Properties.AccessibleName = resources.GetString("mnuManageTime.Properties.AccessibleName")
        Me.mnuManageTime.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuManageTime.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuManageTime.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuManageTime.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuManageTime.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuManageTime.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuManageTime.Properties.Appearance.Image = CType(resources.GetObject("mnuManageTime.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuManageTime.Properties.Appearance.Options.UseFont = True
        Me.mnuManageTime.Properties.AutoHeight = CType(resources.GetObject("mnuManageTime.Properties.AutoHeight"), Boolean)
        Me.mnuManageTime.Properties.Caption = resources.GetString("mnuManageTime.Properties.Caption")
        Me.mnuManageTime.Properties.DisplayValueChecked = resources.GetString("mnuManageTime.Properties.DisplayValueChecked")
        Me.mnuManageTime.Properties.DisplayValueGrayed = resources.GetString("mnuManageTime.Properties.DisplayValueGrayed")
        Me.mnuManageTime.Properties.DisplayValueUnchecked = resources.GetString("mnuManageTime.Properties.DisplayValueUnchecked")
        Me.mnuManageTime.Properties.PictureChecked = CType(resources.GetObject("mnuManageTime.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuManageTime.Tag = "MN01007"
        '
        'mnuPermissionTimeAtt
        '
        resources.ApplyResources(Me.mnuPermissionTimeAtt, "mnuPermissionTimeAtt")
        Me.mnuPermissionTimeAtt.Name = "mnuPermissionTimeAtt"
        Me.mnuPermissionTimeAtt.Properties.AccessibleDescription = resources.GetString("mnuPermissionTimeAtt.Properties.AccessibleDescription")
        Me.mnuPermissionTimeAtt.Properties.AccessibleName = resources.GetString("mnuPermissionTimeAtt.Properties.AccessibleName")
        Me.mnuPermissionTimeAtt.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuPermissionTimeAtt.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuPermissionTimeAtt.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuPermissionTimeAtt.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuPermissionTimeAtt.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuPermissionTimeAtt.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuPermissionTimeAtt.Properties.Appearance.Image = CType(resources.GetObject("mnuPermissionTimeAtt.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuPermissionTimeAtt.Properties.Appearance.Options.UseFont = True
        Me.mnuPermissionTimeAtt.Properties.AutoHeight = CType(resources.GetObject("mnuPermissionTimeAtt.Properties.AutoHeight"), Boolean)
        Me.mnuPermissionTimeAtt.Properties.Caption = resources.GetString("mnuPermissionTimeAtt.Properties.Caption")
        Me.mnuPermissionTimeAtt.Properties.DisplayValueChecked = resources.GetString("mnuPermissionTimeAtt.Properties.DisplayValueChecked")
        Me.mnuPermissionTimeAtt.Properties.DisplayValueGrayed = resources.GetString("mnuPermissionTimeAtt.Properties.DisplayValueGrayed")
        Me.mnuPermissionTimeAtt.Properties.DisplayValueUnchecked = resources.GetString("mnuPermissionTimeAtt.Properties.DisplayValueUnchecked")
        Me.mnuPermissionTimeAtt.Properties.PictureChecked = CType(resources.GetObject("mnuPermissionTimeAtt.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuPermissionTimeAtt.Tag = "MN01006"
        '
        'mnuabsenceTime
        '
        resources.ApplyResources(Me.mnuabsenceTime, "mnuabsenceTime")
        Me.mnuabsenceTime.Name = "mnuabsenceTime"
        Me.mnuabsenceTime.Properties.AccessibleDescription = resources.GetString("mnuabsenceTime.Properties.AccessibleDescription")
        Me.mnuabsenceTime.Properties.AccessibleName = resources.GetString("mnuabsenceTime.Properties.AccessibleName")
        Me.mnuabsenceTime.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuabsenceTime.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuabsenceTime.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuabsenceTime.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuabsenceTime.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuabsenceTime.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuabsenceTime.Properties.Appearance.Image = CType(resources.GetObject("mnuabsenceTime.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuabsenceTime.Properties.Appearance.Options.UseFont = True
        Me.mnuabsenceTime.Properties.AutoHeight = CType(resources.GetObject("mnuabsenceTime.Properties.AutoHeight"), Boolean)
        Me.mnuabsenceTime.Properties.Caption = resources.GetString("mnuabsenceTime.Properties.Caption")
        Me.mnuabsenceTime.Properties.DisplayValueChecked = resources.GetString("mnuabsenceTime.Properties.DisplayValueChecked")
        Me.mnuabsenceTime.Properties.DisplayValueGrayed = resources.GetString("mnuabsenceTime.Properties.DisplayValueGrayed")
        Me.mnuabsenceTime.Properties.DisplayValueUnchecked = resources.GetString("mnuabsenceTime.Properties.DisplayValueUnchecked")
        Me.mnuabsenceTime.Properties.PictureChecked = CType(resources.GetObject("mnuabsenceTime.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuabsenceTime.Tag = "MN01010"
        '
        'mnuOvertime
        '
        resources.ApplyResources(Me.mnuOvertime, "mnuOvertime")
        Me.mnuOvertime.Name = "mnuOvertime"
        Me.mnuOvertime.Properties.AccessibleDescription = resources.GetString("mnuOvertime.Properties.AccessibleDescription")
        Me.mnuOvertime.Properties.AccessibleName = resources.GetString("mnuOvertime.Properties.AccessibleName")
        Me.mnuOvertime.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuOvertime.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuOvertime.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuOvertime.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuOvertime.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuOvertime.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuOvertime.Properties.Appearance.Image = CType(resources.GetObject("mnuOvertime.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuOvertime.Properties.Appearance.Options.UseFont = True
        Me.mnuOvertime.Properties.AutoHeight = CType(resources.GetObject("mnuOvertime.Properties.AutoHeight"), Boolean)
        Me.mnuOvertime.Properties.Caption = resources.GetString("mnuOvertime.Properties.Caption")
        Me.mnuOvertime.Properties.DisplayValueChecked = resources.GetString("mnuOvertime.Properties.DisplayValueChecked")
        Me.mnuOvertime.Properties.DisplayValueGrayed = resources.GetString("mnuOvertime.Properties.DisplayValueGrayed")
        Me.mnuOvertime.Properties.DisplayValueUnchecked = resources.GetString("mnuOvertime.Properties.DisplayValueUnchecked")
        Me.mnuOvertime.Properties.PictureChecked = CType(resources.GetObject("mnuOvertime.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuOvertime.Tag = "MN01008"
        '
        'mnuLateTime
        '
        resources.ApplyResources(Me.mnuLateTime, "mnuLateTime")
        Me.mnuLateTime.Name = "mnuLateTime"
        Me.mnuLateTime.Properties.AccessibleDescription = resources.GetString("mnuLateTime.Properties.AccessibleDescription")
        Me.mnuLateTime.Properties.AccessibleName = resources.GetString("mnuLateTime.Properties.AccessibleName")
        Me.mnuLateTime.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuLateTime.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuLateTime.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuLateTime.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuLateTime.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuLateTime.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuLateTime.Properties.Appearance.Image = CType(resources.GetObject("mnuLateTime.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuLateTime.Properties.Appearance.Options.UseFont = True
        Me.mnuLateTime.Properties.AutoHeight = CType(resources.GetObject("mnuLateTime.Properties.AutoHeight"), Boolean)
        Me.mnuLateTime.Properties.Caption = resources.GetString("mnuLateTime.Properties.Caption")
        Me.mnuLateTime.Properties.DisplayValueChecked = resources.GetString("mnuLateTime.Properties.DisplayValueChecked")
        Me.mnuLateTime.Properties.DisplayValueGrayed = resources.GetString("mnuLateTime.Properties.DisplayValueGrayed")
        Me.mnuLateTime.Properties.DisplayValueUnchecked = resources.GetString("mnuLateTime.Properties.DisplayValueUnchecked")
        Me.mnuLateTime.Properties.PictureChecked = CType(resources.GetObject("mnuLateTime.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuLateTime.Tag = "MN01009"
        '
        'XtraTabPage4
        '
        resources.ApplyResources(Me.XtraTabPage4, "XtraTabPage4")
        Me.XtraTabPage4.Appearance.Header.Font = CType(resources.GetObject("XtraTabPage4.Appearance.Header.Font"), System.Drawing.Font)
        Me.XtraTabPage4.Appearance.Header.FontSizeDelta = CType(resources.GetObject("XtraTabPage4.Appearance.Header.FontSizeDelta"), Integer)
        Me.XtraTabPage4.Appearance.Header.FontStyleDelta = CType(resources.GetObject("XtraTabPage4.Appearance.Header.FontStyleDelta"), System.Drawing.FontStyle)
        Me.XtraTabPage4.Appearance.Header.GradientMode = CType(resources.GetObject("XtraTabPage4.Appearance.Header.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.XtraTabPage4.Appearance.Header.Image = CType(resources.GetObject("XtraTabPage4.Appearance.Header.Image"), System.Drawing.Image)
        Me.XtraTabPage4.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage4.Appearance.HeaderActive.Font = CType(resources.GetObject("XtraTabPage4.Appearance.HeaderActive.Font"), System.Drawing.Font)
        Me.XtraTabPage4.Appearance.HeaderActive.FontSizeDelta = CType(resources.GetObject("XtraTabPage4.Appearance.HeaderActive.FontSizeDelta"), Integer)
        Me.XtraTabPage4.Appearance.HeaderActive.FontStyleDelta = CType(resources.GetObject("XtraTabPage4.Appearance.HeaderActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.XtraTabPage4.Appearance.HeaderActive.GradientMode = CType(resources.GetObject("XtraTabPage4.Appearance.HeaderActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.XtraTabPage4.Appearance.HeaderActive.Image = CType(resources.GetObject("XtraTabPage4.Appearance.HeaderActive.Image"), System.Drawing.Image)
        Me.XtraTabPage4.Appearance.HeaderActive.Options.UseFont = True
        Me.XtraTabPage4.Controls.Add(Me.XtraScrollableControl2)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        '
        'XtraScrollableControl2
        '
        resources.ApplyResources(Me.XtraScrollableControl2, "XtraScrollableControl2")
        Me.XtraScrollableControl2.Appearance.BackColor = CType(resources.GetObject("XtraScrollableControl2.Appearance.BackColor"), System.Drawing.Color)
        Me.XtraScrollableControl2.Appearance.FontSizeDelta = CType(resources.GetObject("XtraScrollableControl2.Appearance.FontSizeDelta"), Integer)
        Me.XtraScrollableControl2.Appearance.FontStyleDelta = CType(resources.GetObject("XtraScrollableControl2.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.XtraScrollableControl2.Appearance.GradientMode = CType(resources.GetObject("XtraScrollableControl2.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.XtraScrollableControl2.Appearance.Image = CType(resources.GetObject("XtraScrollableControl2.Appearance.Image"), System.Drawing.Image)
        Me.XtraScrollableControl2.Appearance.Options.UseBackColor = True
        Me.XtraScrollableControl2.Controls.Add(Me.mnuEmp)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuDepartment)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuDivision)
        Me.XtraScrollableControl2.Controls.Add(Me.MenuWorkHolidaySpacial)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuConfiguration)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuSetholiday)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuMConfig)
        Me.XtraScrollableControl2.Controls.Add(Me.mnucalculationAbs)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuCompanyCenter)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuSetCancelDelayOTByDay)
        Me.XtraScrollableControl2.Controls.Add(Me.mnumodelcalculations)
        Me.XtraScrollableControl2.Controls.Add(Me.mnusetdelayOT)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuMWorkTime)
        Me.XtraScrollableControl2.Controls.Add(Me.mnusetdelaytime1)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuMOpenCalculate)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuOTbyDay)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuMVacationHolYear)
        Me.XtraScrollableControl2.Controls.Add(Me.mnusetOT)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuMOtherCondition)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuOTBasic)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuworkinggroup)
        Me.XtraScrollableControl2.Controls.Add(Me.mnulimitOT)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuSpacialKa)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuSetabsenceTimeByYear)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuDeterminedTime)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuOT)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuDeterminedTimeEmp)
        Me.XtraScrollableControl2.Controls.Add(Me.mnucalculationLate)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuDeterminedTimeEmpByOne)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuSetLeave)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuDeterminedTimeEmpByDate)
        Me.XtraScrollableControl2.Controls.Add(Me.mnuProcessOT)
        Me.XtraScrollableControl2.Name = "XtraScrollableControl2"
        '
        'mnuEmp
        '
        resources.ApplyResources(Me.mnuEmp, "mnuEmp")
        Me.mnuEmp.Name = "mnuEmp"
        Me.mnuEmp.Properties.AccessibleDescription = resources.GetString("mnuEmp.Properties.AccessibleDescription")
        Me.mnuEmp.Properties.AccessibleName = resources.GetString("mnuEmp.Properties.AccessibleName")
        Me.mnuEmp.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuEmp.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuEmp.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuEmp.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuEmp.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuEmp.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuEmp.Properties.Appearance.Image = CType(resources.GetObject("mnuEmp.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuEmp.Properties.Appearance.Options.UseFont = True
        Me.mnuEmp.Properties.AutoHeight = CType(resources.GetObject("mnuEmp.Properties.AutoHeight"), Boolean)
        Me.mnuEmp.Properties.Caption = resources.GetString("mnuEmp.Properties.Caption")
        Me.mnuEmp.Properties.DisplayValueChecked = resources.GetString("mnuEmp.Properties.DisplayValueChecked")
        Me.mnuEmp.Properties.DisplayValueGrayed = resources.GetString("mnuEmp.Properties.DisplayValueGrayed")
        Me.mnuEmp.Properties.DisplayValueUnchecked = resources.GetString("mnuEmp.Properties.DisplayValueUnchecked")
        Me.mnuEmp.Properties.PictureChecked = CType(resources.GetObject("mnuEmp.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuEmp.Tag = "MN02005-1"
        '
        'mnuDepartment
        '
        resources.ApplyResources(Me.mnuDepartment, "mnuDepartment")
        Me.mnuDepartment.Name = "mnuDepartment"
        Me.mnuDepartment.Properties.AccessibleDescription = resources.GetString("mnuDepartment.Properties.AccessibleDescription")
        Me.mnuDepartment.Properties.AccessibleName = resources.GetString("mnuDepartment.Properties.AccessibleName")
        Me.mnuDepartment.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuDepartment.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuDepartment.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuDepartment.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuDepartment.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuDepartment.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuDepartment.Properties.Appearance.Image = CType(resources.GetObject("mnuDepartment.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuDepartment.Properties.Appearance.Options.UseFont = True
        Me.mnuDepartment.Properties.AutoHeight = CType(resources.GetObject("mnuDepartment.Properties.AutoHeight"), Boolean)
        Me.mnuDepartment.Properties.Caption = resources.GetString("mnuDepartment.Properties.Caption")
        Me.mnuDepartment.Properties.DisplayValueChecked = resources.GetString("mnuDepartment.Properties.DisplayValueChecked")
        Me.mnuDepartment.Properties.DisplayValueGrayed = resources.GetString("mnuDepartment.Properties.DisplayValueGrayed")
        Me.mnuDepartment.Properties.DisplayValueUnchecked = resources.GetString("mnuDepartment.Properties.DisplayValueUnchecked")
        Me.mnuDepartment.Properties.PictureChecked = CType(resources.GetObject("mnuDepartment.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuDepartment.Tag = "MN02005-3"
        '
        'mnuDivision
        '
        resources.ApplyResources(Me.mnuDivision, "mnuDivision")
        Me.mnuDivision.Name = "mnuDivision"
        Me.mnuDivision.Properties.AccessibleDescription = resources.GetString("mnuDivision.Properties.AccessibleDescription")
        Me.mnuDivision.Properties.AccessibleName = resources.GetString("mnuDivision.Properties.AccessibleName")
        Me.mnuDivision.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuDivision.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuDivision.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuDivision.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuDivision.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuDivision.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuDivision.Properties.Appearance.Image = CType(resources.GetObject("mnuDivision.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuDivision.Properties.Appearance.Options.UseFont = True
        Me.mnuDivision.Properties.AutoHeight = CType(resources.GetObject("mnuDivision.Properties.AutoHeight"), Boolean)
        Me.mnuDivision.Properties.Caption = resources.GetString("mnuDivision.Properties.Caption")
        Me.mnuDivision.Properties.DisplayValueChecked = resources.GetString("mnuDivision.Properties.DisplayValueChecked")
        Me.mnuDivision.Properties.DisplayValueGrayed = resources.GetString("mnuDivision.Properties.DisplayValueGrayed")
        Me.mnuDivision.Properties.DisplayValueUnchecked = resources.GetString("mnuDivision.Properties.DisplayValueUnchecked")
        Me.mnuDivision.Properties.PictureChecked = CType(resources.GetObject("mnuDivision.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuDivision.Tag = "MN02005-2"
        '
        'MenuWorkHolidaySpacial
        '
        resources.ApplyResources(Me.MenuWorkHolidaySpacial, "MenuWorkHolidaySpacial")
        Me.MenuWorkHolidaySpacial.Name = "MenuWorkHolidaySpacial"
        Me.MenuWorkHolidaySpacial.Properties.AccessibleDescription = resources.GetString("MenuWorkHolidaySpacial.Properties.AccessibleDescription")
        Me.MenuWorkHolidaySpacial.Properties.AccessibleName = resources.GetString("MenuWorkHolidaySpacial.Properties.AccessibleName")
        Me.MenuWorkHolidaySpacial.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("MenuWorkHolidaySpacial.Properties.Appearance.FontSizeDelta"), Integer)
        Me.MenuWorkHolidaySpacial.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("MenuWorkHolidaySpacial.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.MenuWorkHolidaySpacial.Properties.Appearance.GradientMode = CType(resources.GetObject("MenuWorkHolidaySpacial.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.MenuWorkHolidaySpacial.Properties.Appearance.Image = CType(resources.GetObject("MenuWorkHolidaySpacial.Properties.Appearance.Image"), System.Drawing.Image)
        Me.MenuWorkHolidaySpacial.Properties.Appearance.Options.UseFont = True
        Me.MenuWorkHolidaySpacial.Properties.AutoHeight = CType(resources.GetObject("MenuWorkHolidaySpacial.Properties.AutoHeight"), Boolean)
        Me.MenuWorkHolidaySpacial.Properties.Caption = resources.GetString("MenuWorkHolidaySpacial.Properties.Caption")
        Me.MenuWorkHolidaySpacial.Properties.DisplayValueChecked = resources.GetString("MenuWorkHolidaySpacial.Properties.DisplayValueChecked")
        Me.MenuWorkHolidaySpacial.Properties.DisplayValueGrayed = resources.GetString("MenuWorkHolidaySpacial.Properties.DisplayValueGrayed")
        Me.MenuWorkHolidaySpacial.Properties.DisplayValueUnchecked = resources.GetString("MenuWorkHolidaySpacial.Properties.DisplayValueUnchecked")
        Me.MenuWorkHolidaySpacial.Properties.PictureChecked = CType(resources.GetObject("MenuWorkHolidaySpacial.Properties.PictureChecked"), System.Drawing.Image)
        Me.MenuWorkHolidaySpacial.Tag = "MN02020"
        '
        'mnuConfiguration
        '
        resources.ApplyResources(Me.mnuConfiguration, "mnuConfiguration")
        Me.mnuConfiguration.Name = "mnuConfiguration"
        Me.mnuConfiguration.Properties.AccessibleDescription = resources.GetString("mnuConfiguration.Properties.AccessibleDescription")
        Me.mnuConfiguration.Properties.AccessibleName = resources.GetString("mnuConfiguration.Properties.AccessibleName")
        Me.mnuConfiguration.Properties.Appearance.Font = CType(resources.GetObject("mnuConfiguration.Properties.Appearance.Font"), System.Drawing.Font)
        Me.mnuConfiguration.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuConfiguration.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuConfiguration.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuConfiguration.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuConfiguration.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuConfiguration.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuConfiguration.Properties.Appearance.Image = CType(resources.GetObject("mnuConfiguration.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuConfiguration.Properties.Appearance.Options.UseFont = True
        Me.mnuConfiguration.Properties.AutoHeight = CType(resources.GetObject("mnuConfiguration.Properties.AutoHeight"), Boolean)
        Me.mnuConfiguration.Properties.Caption = resources.GetString("mnuConfiguration.Properties.Caption")
        Me.mnuConfiguration.Properties.DisplayValueChecked = resources.GetString("mnuConfiguration.Properties.DisplayValueChecked")
        Me.mnuConfiguration.Properties.DisplayValueGrayed = resources.GetString("mnuConfiguration.Properties.DisplayValueGrayed")
        Me.mnuConfiguration.Properties.DisplayValueUnchecked = resources.GetString("mnuConfiguration.Properties.DisplayValueUnchecked")
        Me.mnuConfiguration.Properties.ImageIndexChecked = 0
        Me.mnuConfiguration.Properties.ImageIndexGrayed = 1
        Me.mnuConfiguration.Properties.ImageIndexUnchecked = 2
        Me.mnuConfiguration.Tag = "MN01013"
        '
        'mnuSetholiday
        '
        resources.ApplyResources(Me.mnuSetholiday, "mnuSetholiday")
        Me.mnuSetholiday.Name = "mnuSetholiday"
        Me.mnuSetholiday.Properties.AccessibleDescription = resources.GetString("mnuSetholiday.Properties.AccessibleDescription")
        Me.mnuSetholiday.Properties.AccessibleName = resources.GetString("mnuSetholiday.Properties.AccessibleName")
        Me.mnuSetholiday.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuSetholiday.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuSetholiday.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuSetholiday.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuSetholiday.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuSetholiday.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuSetholiday.Properties.Appearance.Image = CType(resources.GetObject("mnuSetholiday.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuSetholiday.Properties.Appearance.Options.UseFont = True
        Me.mnuSetholiday.Properties.AutoHeight = CType(resources.GetObject("mnuSetholiday.Properties.AutoHeight"), Boolean)
        Me.mnuSetholiday.Properties.Caption = resources.GetString("mnuSetholiday.Properties.Caption")
        Me.mnuSetholiday.Properties.DisplayValueChecked = resources.GetString("mnuSetholiday.Properties.DisplayValueChecked")
        Me.mnuSetholiday.Properties.DisplayValueGrayed = resources.GetString("mnuSetholiday.Properties.DisplayValueGrayed")
        Me.mnuSetholiday.Properties.DisplayValueUnchecked = resources.GetString("mnuSetholiday.Properties.DisplayValueUnchecked")
        Me.mnuSetholiday.Properties.PictureChecked = CType(resources.GetObject("mnuSetholiday.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuSetholiday.Tag = "MN02019"
        '
        'mnuMConfig
        '
        resources.ApplyResources(Me.mnuMConfig, "mnuMConfig")
        Me.mnuMConfig.Name = "mnuMConfig"
        Me.mnuMConfig.Properties.AccessibleDescription = resources.GetString("mnuMConfig.Properties.AccessibleDescription")
        Me.mnuMConfig.Properties.AccessibleName = resources.GetString("mnuMConfig.Properties.AccessibleName")
        Me.mnuMConfig.Properties.Appearance.Font = CType(resources.GetObject("mnuMConfig.Properties.Appearance.Font"), System.Drawing.Font)
        Me.mnuMConfig.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuMConfig.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuMConfig.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuMConfig.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuMConfig.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuMConfig.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuMConfig.Properties.Appearance.Image = CType(resources.GetObject("mnuMConfig.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuMConfig.Properties.Appearance.Options.UseFont = True
        Me.mnuMConfig.Properties.AutoHeight = CType(resources.GetObject("mnuMConfig.Properties.AutoHeight"), Boolean)
        Me.mnuMConfig.Properties.Caption = resources.GetString("mnuMConfig.Properties.Caption")
        Me.mnuMConfig.Properties.DisplayValueChecked = resources.GetString("mnuMConfig.Properties.DisplayValueChecked")
        Me.mnuMConfig.Properties.DisplayValueGrayed = resources.GetString("mnuMConfig.Properties.DisplayValueGrayed")
        Me.mnuMConfig.Properties.DisplayValueUnchecked = resources.GetString("mnuMConfig.Properties.DisplayValueUnchecked")
        Me.mnuMConfig.Properties.PictureChecked = CType(resources.GetObject("mnuMConfig.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuMConfig.Tag = "MN01014"
        '
        'mnucalculationAbs
        '
        resources.ApplyResources(Me.mnucalculationAbs, "mnucalculationAbs")
        Me.mnucalculationAbs.Name = "mnucalculationAbs"
        Me.mnucalculationAbs.Properties.AccessibleDescription = resources.GetString("mnucalculationAbs.Properties.AccessibleDescription")
        Me.mnucalculationAbs.Properties.AccessibleName = resources.GetString("mnucalculationAbs.Properties.AccessibleName")
        Me.mnucalculationAbs.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnucalculationAbs.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnucalculationAbs.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnucalculationAbs.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnucalculationAbs.Properties.Appearance.GradientMode = CType(resources.GetObject("mnucalculationAbs.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnucalculationAbs.Properties.Appearance.Image = CType(resources.GetObject("mnucalculationAbs.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnucalculationAbs.Properties.Appearance.Options.UseFont = True
        Me.mnucalculationAbs.Properties.AutoHeight = CType(resources.GetObject("mnucalculationAbs.Properties.AutoHeight"), Boolean)
        Me.mnucalculationAbs.Properties.Caption = resources.GetString("mnucalculationAbs.Properties.Caption")
        Me.mnucalculationAbs.Properties.DisplayValueChecked = resources.GetString("mnucalculationAbs.Properties.DisplayValueChecked")
        Me.mnucalculationAbs.Properties.DisplayValueGrayed = resources.GetString("mnucalculationAbs.Properties.DisplayValueGrayed")
        Me.mnucalculationAbs.Properties.DisplayValueUnchecked = resources.GetString("mnucalculationAbs.Properties.DisplayValueUnchecked")
        Me.mnucalculationAbs.Properties.PictureChecked = CType(resources.GetObject("mnucalculationAbs.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnucalculationAbs.Tag = "MN02015"
        '
        'mnuCompanyCenter
        '
        resources.ApplyResources(Me.mnuCompanyCenter, "mnuCompanyCenter")
        Me.mnuCompanyCenter.Name = "mnuCompanyCenter"
        Me.mnuCompanyCenter.Properties.AccessibleDescription = resources.GetString("mnuCompanyCenter.Properties.AccessibleDescription")
        Me.mnuCompanyCenter.Properties.AccessibleName = resources.GetString("mnuCompanyCenter.Properties.AccessibleName")
        Me.mnuCompanyCenter.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuCompanyCenter.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuCompanyCenter.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuCompanyCenter.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuCompanyCenter.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuCompanyCenter.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuCompanyCenter.Properties.Appearance.Image = CType(resources.GetObject("mnuCompanyCenter.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuCompanyCenter.Properties.Appearance.Options.UseFont = True
        Me.mnuCompanyCenter.Properties.AutoHeight = CType(resources.GetObject("mnuCompanyCenter.Properties.AutoHeight"), Boolean)
        Me.mnuCompanyCenter.Properties.Caption = resources.GetString("mnuCompanyCenter.Properties.Caption")
        Me.mnuCompanyCenter.Properties.DisplayValueChecked = resources.GetString("mnuCompanyCenter.Properties.DisplayValueChecked")
        Me.mnuCompanyCenter.Properties.DisplayValueGrayed = resources.GetString("mnuCompanyCenter.Properties.DisplayValueGrayed")
        Me.mnuCompanyCenter.Properties.DisplayValueUnchecked = resources.GetString("mnuCompanyCenter.Properties.DisplayValueUnchecked")
        Me.mnuCompanyCenter.Properties.PictureChecked = CType(resources.GetObject("mnuCompanyCenter.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuCompanyCenter.Tag = "MN02004"
        '
        'mnuSetCancelDelayOTByDay
        '
        resources.ApplyResources(Me.mnuSetCancelDelayOTByDay, "mnuSetCancelDelayOTByDay")
        Me.mnuSetCancelDelayOTByDay.Name = "mnuSetCancelDelayOTByDay"
        Me.mnuSetCancelDelayOTByDay.Properties.AccessibleDescription = resources.GetString("mnuSetCancelDelayOTByDay.Properties.AccessibleDescription")
        Me.mnuSetCancelDelayOTByDay.Properties.AccessibleName = resources.GetString("mnuSetCancelDelayOTByDay.Properties.AccessibleName")
        Me.mnuSetCancelDelayOTByDay.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuSetCancelDelayOTByDay.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuSetCancelDelayOTByDay.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuSetCancelDelayOTByDay.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuSetCancelDelayOTByDay.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuSetCancelDelayOTByDay.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuSetCancelDelayOTByDay.Properties.Appearance.Image = CType(resources.GetObject("mnuSetCancelDelayOTByDay.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuSetCancelDelayOTByDay.Properties.Appearance.Options.UseFont = True
        Me.mnuSetCancelDelayOTByDay.Properties.AutoHeight = CType(resources.GetObject("mnuSetCancelDelayOTByDay.Properties.AutoHeight"), Boolean)
        Me.mnuSetCancelDelayOTByDay.Properties.Caption = resources.GetString("mnuSetCancelDelayOTByDay.Properties.Caption")
        Me.mnuSetCancelDelayOTByDay.Properties.DisplayValueChecked = resources.GetString("mnuSetCancelDelayOTByDay.Properties.DisplayValueChecked")
        Me.mnuSetCancelDelayOTByDay.Properties.DisplayValueGrayed = resources.GetString("mnuSetCancelDelayOTByDay.Properties.DisplayValueGrayed")
        Me.mnuSetCancelDelayOTByDay.Properties.DisplayValueUnchecked = resources.GetString("mnuSetCancelDelayOTByDay.Properties.DisplayValueUnchecked")
        Me.mnuSetCancelDelayOTByDay.Properties.PictureChecked = CType(resources.GetObject("mnuSetCancelDelayOTByDay.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuSetCancelDelayOTByDay.Tag = "MN02027"
        '
        'mnumodelcalculations
        '
        resources.ApplyResources(Me.mnumodelcalculations, "mnumodelcalculations")
        Me.mnumodelcalculations.Name = "mnumodelcalculations"
        Me.mnumodelcalculations.Properties.AccessibleDescription = resources.GetString("mnumodelcalculations.Properties.AccessibleDescription")
        Me.mnumodelcalculations.Properties.AccessibleName = resources.GetString("mnumodelcalculations.Properties.AccessibleName")
        Me.mnumodelcalculations.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnumodelcalculations.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnumodelcalculations.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnumodelcalculations.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnumodelcalculations.Properties.Appearance.GradientMode = CType(resources.GetObject("mnumodelcalculations.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnumodelcalculations.Properties.Appearance.Image = CType(resources.GetObject("mnumodelcalculations.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnumodelcalculations.Properties.Appearance.Options.UseFont = True
        Me.mnumodelcalculations.Properties.AutoHeight = CType(resources.GetObject("mnumodelcalculations.Properties.AutoHeight"), Boolean)
        Me.mnumodelcalculations.Properties.Caption = resources.GetString("mnumodelcalculations.Properties.Caption")
        Me.mnumodelcalculations.Properties.DisplayValueChecked = resources.GetString("mnumodelcalculations.Properties.DisplayValueChecked")
        Me.mnumodelcalculations.Properties.DisplayValueGrayed = resources.GetString("mnumodelcalculations.Properties.DisplayValueGrayed")
        Me.mnumodelcalculations.Properties.DisplayValueUnchecked = resources.GetString("mnumodelcalculations.Properties.DisplayValueUnchecked")
        Me.mnumodelcalculations.Properties.PictureChecked = CType(resources.GetObject("mnumodelcalculations.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnumodelcalculations.Tag = "MN02005"
        '
        'mnusetdelayOT
        '
        resources.ApplyResources(Me.mnusetdelayOT, "mnusetdelayOT")
        Me.mnusetdelayOT.Name = "mnusetdelayOT"
        Me.mnusetdelayOT.Properties.AccessibleDescription = resources.GetString("mnusetdelayOT.Properties.AccessibleDescription")
        Me.mnusetdelayOT.Properties.AccessibleName = resources.GetString("mnusetdelayOT.Properties.AccessibleName")
        Me.mnusetdelayOT.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnusetdelayOT.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnusetdelayOT.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnusetdelayOT.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnusetdelayOT.Properties.Appearance.GradientMode = CType(resources.GetObject("mnusetdelayOT.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnusetdelayOT.Properties.Appearance.Image = CType(resources.GetObject("mnusetdelayOT.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnusetdelayOT.Properties.Appearance.Options.UseFont = True
        Me.mnusetdelayOT.Properties.AutoHeight = CType(resources.GetObject("mnusetdelayOT.Properties.AutoHeight"), Boolean)
        Me.mnusetdelayOT.Properties.Caption = resources.GetString("mnusetdelayOT.Properties.Caption")
        Me.mnusetdelayOT.Properties.DisplayValueChecked = resources.GetString("mnusetdelayOT.Properties.DisplayValueChecked")
        Me.mnusetdelayOT.Properties.DisplayValueGrayed = resources.GetString("mnusetdelayOT.Properties.DisplayValueGrayed")
        Me.mnusetdelayOT.Properties.DisplayValueUnchecked = resources.GetString("mnusetdelayOT.Properties.DisplayValueUnchecked")
        Me.mnusetdelayOT.Properties.PictureChecked = CType(resources.GetObject("mnusetdelayOT.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnusetdelayOT.Tag = "MN02026"
        '
        'mnuMWorkTime
        '
        resources.ApplyResources(Me.mnuMWorkTime, "mnuMWorkTime")
        Me.mnuMWorkTime.Name = "mnuMWorkTime"
        Me.mnuMWorkTime.Properties.AccessibleDescription = resources.GetString("mnuMWorkTime.Properties.AccessibleDescription")
        Me.mnuMWorkTime.Properties.AccessibleName = resources.GetString("mnuMWorkTime.Properties.AccessibleName")
        Me.mnuMWorkTime.Properties.Appearance.Font = CType(resources.GetObject("mnuMWorkTime.Properties.Appearance.Font"), System.Drawing.Font)
        Me.mnuMWorkTime.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuMWorkTime.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuMWorkTime.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuMWorkTime.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuMWorkTime.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuMWorkTime.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuMWorkTime.Properties.Appearance.Image = CType(resources.GetObject("mnuMWorkTime.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuMWorkTime.Properties.Appearance.Options.UseFont = True
        Me.mnuMWorkTime.Properties.AutoHeight = CType(resources.GetObject("mnuMWorkTime.Properties.AutoHeight"), Boolean)
        Me.mnuMWorkTime.Properties.Caption = resources.GetString("mnuMWorkTime.Properties.Caption")
        Me.mnuMWorkTime.Properties.DisplayValueChecked = resources.GetString("mnuMWorkTime.Properties.DisplayValueChecked")
        Me.mnuMWorkTime.Properties.DisplayValueGrayed = resources.GetString("mnuMWorkTime.Properties.DisplayValueGrayed")
        Me.mnuMWorkTime.Properties.DisplayValueUnchecked = resources.GetString("mnuMWorkTime.Properties.DisplayValueUnchecked")
        Me.mnuMWorkTime.Properties.PictureChecked = CType(resources.GetObject("mnuMWorkTime.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuMWorkTime.Tag = "MN02006"
        '
        'mnusetdelaytime1
        '
        resources.ApplyResources(Me.mnusetdelaytime1, "mnusetdelaytime1")
        Me.mnusetdelaytime1.Name = "mnusetdelaytime1"
        Me.mnusetdelaytime1.Properties.AccessibleDescription = resources.GetString("mnusetdelaytime1.Properties.AccessibleDescription")
        Me.mnusetdelaytime1.Properties.AccessibleName = resources.GetString("mnusetdelaytime1.Properties.AccessibleName")
        Me.mnusetdelaytime1.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnusetdelaytime1.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnusetdelaytime1.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnusetdelaytime1.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnusetdelaytime1.Properties.Appearance.GradientMode = CType(resources.GetObject("mnusetdelaytime1.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnusetdelaytime1.Properties.Appearance.Image = CType(resources.GetObject("mnusetdelaytime1.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnusetdelaytime1.Properties.Appearance.Options.UseFont = True
        Me.mnusetdelaytime1.Properties.AutoHeight = CType(resources.GetObject("mnusetdelaytime1.Properties.AutoHeight"), Boolean)
        Me.mnusetdelaytime1.Properties.Caption = resources.GetString("mnusetdelaytime1.Properties.Caption")
        Me.mnusetdelaytime1.Properties.DisplayValueChecked = resources.GetString("mnusetdelaytime1.Properties.DisplayValueChecked")
        Me.mnusetdelaytime1.Properties.DisplayValueGrayed = resources.GetString("mnusetdelaytime1.Properties.DisplayValueGrayed")
        Me.mnusetdelaytime1.Properties.DisplayValueUnchecked = resources.GetString("mnusetdelaytime1.Properties.DisplayValueUnchecked")
        Me.mnusetdelaytime1.Properties.PictureChecked = CType(resources.GetObject("mnusetdelaytime1.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnusetdelaytime1.Tag = "MN02025"
        '
        'mnuMOpenCalculate
        '
        resources.ApplyResources(Me.mnuMOpenCalculate, "mnuMOpenCalculate")
        Me.mnuMOpenCalculate.Name = "mnuMOpenCalculate"
        Me.mnuMOpenCalculate.Properties.AccessibleDescription = resources.GetString("mnuMOpenCalculate.Properties.AccessibleDescription")
        Me.mnuMOpenCalculate.Properties.AccessibleName = resources.GetString("mnuMOpenCalculate.Properties.AccessibleName")
        Me.mnuMOpenCalculate.Properties.Appearance.Font = CType(resources.GetObject("mnuMOpenCalculate.Properties.Appearance.Font"), System.Drawing.Font)
        Me.mnuMOpenCalculate.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuMOpenCalculate.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuMOpenCalculate.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuMOpenCalculate.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuMOpenCalculate.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuMOpenCalculate.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuMOpenCalculate.Properties.Appearance.Image = CType(resources.GetObject("mnuMOpenCalculate.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuMOpenCalculate.Properties.Appearance.Options.UseFont = True
        Me.mnuMOpenCalculate.Properties.AutoHeight = CType(resources.GetObject("mnuMOpenCalculate.Properties.AutoHeight"), Boolean)
        Me.mnuMOpenCalculate.Properties.Caption = resources.GetString("mnuMOpenCalculate.Properties.Caption")
        Me.mnuMOpenCalculate.Properties.DisplayValueChecked = resources.GetString("mnuMOpenCalculate.Properties.DisplayValueChecked")
        Me.mnuMOpenCalculate.Properties.DisplayValueGrayed = resources.GetString("mnuMOpenCalculate.Properties.DisplayValueGrayed")
        Me.mnuMOpenCalculate.Properties.DisplayValueUnchecked = resources.GetString("mnuMOpenCalculate.Properties.DisplayValueUnchecked")
        Me.mnuMOpenCalculate.Properties.PictureChecked = CType(resources.GetObject("mnuMOpenCalculate.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuMOpenCalculate.Tag = "MN02012"
        '
        'mnuOTbyDay
        '
        resources.ApplyResources(Me.mnuOTbyDay, "mnuOTbyDay")
        Me.mnuOTbyDay.Name = "mnuOTbyDay"
        Me.mnuOTbyDay.Properties.AccessibleDescription = resources.GetString("mnuOTbyDay.Properties.AccessibleDescription")
        Me.mnuOTbyDay.Properties.AccessibleName = resources.GetString("mnuOTbyDay.Properties.AccessibleName")
        Me.mnuOTbyDay.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuOTbyDay.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuOTbyDay.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuOTbyDay.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuOTbyDay.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuOTbyDay.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuOTbyDay.Properties.Appearance.Image = CType(resources.GetObject("mnuOTbyDay.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuOTbyDay.Properties.Appearance.Options.UseFont = True
        Me.mnuOTbyDay.Properties.AutoHeight = CType(resources.GetObject("mnuOTbyDay.Properties.AutoHeight"), Boolean)
        Me.mnuOTbyDay.Properties.Caption = resources.GetString("mnuOTbyDay.Properties.Caption")
        Me.mnuOTbyDay.Properties.DisplayValueChecked = resources.GetString("mnuOTbyDay.Properties.DisplayValueChecked")
        Me.mnuOTbyDay.Properties.DisplayValueGrayed = resources.GetString("mnuOTbyDay.Properties.DisplayValueGrayed")
        Me.mnuOTbyDay.Properties.DisplayValueUnchecked = resources.GetString("mnuOTbyDay.Properties.DisplayValueUnchecked")
        Me.mnuOTbyDay.Properties.PictureChecked = CType(resources.GetObject("mnuOTbyDay.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuOTbyDay.Tag = "MN02029"
        '
        'mnuMVacationHolYear
        '
        resources.ApplyResources(Me.mnuMVacationHolYear, "mnuMVacationHolYear")
        Me.mnuMVacationHolYear.Name = "mnuMVacationHolYear"
        Me.mnuMVacationHolYear.Properties.AccessibleDescription = resources.GetString("mnuMVacationHolYear.Properties.AccessibleDescription")
        Me.mnuMVacationHolYear.Properties.AccessibleName = resources.GetString("mnuMVacationHolYear.Properties.AccessibleName")
        Me.mnuMVacationHolYear.Properties.Appearance.Font = CType(resources.GetObject("mnuMVacationHolYear.Properties.Appearance.Font"), System.Drawing.Font)
        Me.mnuMVacationHolYear.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuMVacationHolYear.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuMVacationHolYear.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuMVacationHolYear.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuMVacationHolYear.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuMVacationHolYear.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuMVacationHolYear.Properties.Appearance.Image = CType(resources.GetObject("mnuMVacationHolYear.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuMVacationHolYear.Properties.Appearance.Options.UseFont = True
        Me.mnuMVacationHolYear.Properties.AutoHeight = CType(resources.GetObject("mnuMVacationHolYear.Properties.AutoHeight"), Boolean)
        Me.mnuMVacationHolYear.Properties.Caption = resources.GetString("mnuMVacationHolYear.Properties.Caption")
        Me.mnuMVacationHolYear.Properties.DisplayValueChecked = resources.GetString("mnuMVacationHolYear.Properties.DisplayValueChecked")
        Me.mnuMVacationHolYear.Properties.DisplayValueGrayed = resources.GetString("mnuMVacationHolYear.Properties.DisplayValueGrayed")
        Me.mnuMVacationHolYear.Properties.DisplayValueUnchecked = resources.GetString("mnuMVacationHolYear.Properties.DisplayValueUnchecked")
        Me.mnuMVacationHolYear.Properties.PictureChecked = CType(resources.GetObject("mnuMVacationHolYear.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuMVacationHolYear.Tag = "MN02016"
        '
        'mnusetOT
        '
        resources.ApplyResources(Me.mnusetOT, "mnusetOT")
        Me.mnusetOT.Name = "mnusetOT"
        Me.mnusetOT.Properties.AccessibleDescription = resources.GetString("mnusetOT.Properties.AccessibleDescription")
        Me.mnusetOT.Properties.AccessibleName = resources.GetString("mnusetOT.Properties.AccessibleName")
        Me.mnusetOT.Properties.Appearance.Font = CType(resources.GetObject("mnusetOT.Properties.Appearance.Font"), System.Drawing.Font)
        Me.mnusetOT.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnusetOT.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnusetOT.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnusetOT.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnusetOT.Properties.Appearance.GradientMode = CType(resources.GetObject("mnusetOT.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnusetOT.Properties.Appearance.Image = CType(resources.GetObject("mnusetOT.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnusetOT.Properties.Appearance.Options.UseFont = True
        Me.mnusetOT.Properties.AutoHeight = CType(resources.GetObject("mnusetOT.Properties.AutoHeight"), Boolean)
        Me.mnusetOT.Properties.Caption = resources.GetString("mnusetOT.Properties.Caption")
        Me.mnusetOT.Properties.DisplayValueChecked = resources.GetString("mnusetOT.Properties.DisplayValueChecked")
        Me.mnusetOT.Properties.DisplayValueGrayed = resources.GetString("mnusetOT.Properties.DisplayValueGrayed")
        Me.mnusetOT.Properties.DisplayValueUnchecked = resources.GetString("mnusetOT.Properties.DisplayValueUnchecked")
        Me.mnusetOT.Properties.PictureChecked = CType(resources.GetObject("mnusetOT.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnusetOT.Tag = "MN02024"
        '
        'mnuMOtherCondition
        '
        resources.ApplyResources(Me.mnuMOtherCondition, "mnuMOtherCondition")
        Me.mnuMOtherCondition.Name = "mnuMOtherCondition"
        Me.mnuMOtherCondition.Properties.AccessibleDescription = resources.GetString("mnuMOtherCondition.Properties.AccessibleDescription")
        Me.mnuMOtherCondition.Properties.AccessibleName = resources.GetString("mnuMOtherCondition.Properties.AccessibleName")
        Me.mnuMOtherCondition.Properties.Appearance.Font = CType(resources.GetObject("mnuMOtherCondition.Properties.Appearance.Font"), System.Drawing.Font)
        Me.mnuMOtherCondition.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuMOtherCondition.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuMOtherCondition.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuMOtherCondition.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuMOtherCondition.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuMOtherCondition.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuMOtherCondition.Properties.Appearance.Image = CType(resources.GetObject("mnuMOtherCondition.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuMOtherCondition.Properties.Appearance.Options.UseFont = True
        Me.mnuMOtherCondition.Properties.AutoHeight = CType(resources.GetObject("mnuMOtherCondition.Properties.AutoHeight"), Boolean)
        Me.mnuMOtherCondition.Properties.Caption = resources.GetString("mnuMOtherCondition.Properties.Caption")
        Me.mnuMOtherCondition.Properties.DisplayValueChecked = resources.GetString("mnuMOtherCondition.Properties.DisplayValueChecked")
        Me.mnuMOtherCondition.Properties.DisplayValueGrayed = resources.GetString("mnuMOtherCondition.Properties.DisplayValueGrayed")
        Me.mnuMOtherCondition.Properties.DisplayValueUnchecked = resources.GetString("mnuMOtherCondition.Properties.DisplayValueUnchecked")
        Me.mnuMOtherCondition.Properties.PictureChecked = CType(resources.GetObject("mnuMOtherCondition.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuMOtherCondition.Tag = "MN02021"
        '
        'mnuOTBasic
        '
        resources.ApplyResources(Me.mnuOTBasic, "mnuOTBasic")
        Me.mnuOTBasic.Name = "mnuOTBasic"
        Me.mnuOTBasic.Properties.AccessibleDescription = resources.GetString("mnuOTBasic.Properties.AccessibleDescription")
        Me.mnuOTBasic.Properties.AccessibleName = resources.GetString("mnuOTBasic.Properties.AccessibleName")
        Me.mnuOTBasic.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuOTBasic.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuOTBasic.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuOTBasic.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuOTBasic.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuOTBasic.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuOTBasic.Properties.Appearance.Image = CType(resources.GetObject("mnuOTBasic.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuOTBasic.Properties.Appearance.Options.UseFont = True
        Me.mnuOTBasic.Properties.AutoHeight = CType(resources.GetObject("mnuOTBasic.Properties.AutoHeight"), Boolean)
        Me.mnuOTBasic.Properties.Caption = resources.GetString("mnuOTBasic.Properties.Caption")
        Me.mnuOTBasic.Properties.DisplayValueChecked = resources.GetString("mnuOTBasic.Properties.DisplayValueChecked")
        Me.mnuOTBasic.Properties.DisplayValueGrayed = resources.GetString("mnuOTBasic.Properties.DisplayValueGrayed")
        Me.mnuOTBasic.Properties.DisplayValueUnchecked = resources.GetString("mnuOTBasic.Properties.DisplayValueUnchecked")
        Me.mnuOTBasic.Properties.PictureChecked = CType(resources.GetObject("mnuOTBasic.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuOTBasic.Tag = "MN02023"
        '
        'mnuworkinggroup
        '
        resources.ApplyResources(Me.mnuworkinggroup, "mnuworkinggroup")
        Me.mnuworkinggroup.Name = "mnuworkinggroup"
        Me.mnuworkinggroup.Properties.AccessibleDescription = resources.GetString("mnuworkinggroup.Properties.AccessibleDescription")
        Me.mnuworkinggroup.Properties.AccessibleName = resources.GetString("mnuworkinggroup.Properties.AccessibleName")
        Me.mnuworkinggroup.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuworkinggroup.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuworkinggroup.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuworkinggroup.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuworkinggroup.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuworkinggroup.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuworkinggroup.Properties.Appearance.Image = CType(resources.GetObject("mnuworkinggroup.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuworkinggroup.Properties.Appearance.Options.UseFont = True
        Me.mnuworkinggroup.Properties.AutoHeight = CType(resources.GetObject("mnuworkinggroup.Properties.AutoHeight"), Boolean)
        Me.mnuworkinggroup.Properties.Caption = resources.GetString("mnuworkinggroup.Properties.Caption")
        Me.mnuworkinggroup.Properties.DisplayValueChecked = resources.GetString("mnuworkinggroup.Properties.DisplayValueChecked")
        Me.mnuworkinggroup.Properties.DisplayValueGrayed = resources.GetString("mnuworkinggroup.Properties.DisplayValueGrayed")
        Me.mnuworkinggroup.Properties.DisplayValueUnchecked = resources.GetString("mnuworkinggroup.Properties.DisplayValueUnchecked")
        Me.mnuworkinggroup.Properties.PictureChecked = CType(resources.GetObject("mnuworkinggroup.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuworkinggroup.Tag = "MN02007"
        '
        'mnulimitOT
        '
        resources.ApplyResources(Me.mnulimitOT, "mnulimitOT")
        Me.mnulimitOT.Name = "mnulimitOT"
        Me.mnulimitOT.Properties.AccessibleDescription = resources.GetString("mnulimitOT.Properties.AccessibleDescription")
        Me.mnulimitOT.Properties.AccessibleName = resources.GetString("mnulimitOT.Properties.AccessibleName")
        Me.mnulimitOT.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnulimitOT.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnulimitOT.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnulimitOT.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnulimitOT.Properties.Appearance.GradientMode = CType(resources.GetObject("mnulimitOT.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnulimitOT.Properties.Appearance.Image = CType(resources.GetObject("mnulimitOT.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnulimitOT.Properties.Appearance.Options.UseFont = True
        Me.mnulimitOT.Properties.AutoHeight = CType(resources.GetObject("mnulimitOT.Properties.AutoHeight"), Boolean)
        Me.mnulimitOT.Properties.Caption = resources.GetString("mnulimitOT.Properties.Caption")
        Me.mnulimitOT.Properties.DisplayValueChecked = resources.GetString("mnulimitOT.Properties.DisplayValueChecked")
        Me.mnulimitOT.Properties.DisplayValueGrayed = resources.GetString("mnulimitOT.Properties.DisplayValueGrayed")
        Me.mnulimitOT.Properties.DisplayValueUnchecked = resources.GetString("mnulimitOT.Properties.DisplayValueUnchecked")
        Me.mnulimitOT.Properties.PictureChecked = CType(resources.GetObject("mnulimitOT.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnulimitOT.Tag = "MN02030"
        '
        'mnuSpacialKa
        '
        resources.ApplyResources(Me.mnuSpacialKa, "mnuSpacialKa")
        Me.mnuSpacialKa.Name = "mnuSpacialKa"
        Me.mnuSpacialKa.Properties.AccessibleDescription = resources.GetString("mnuSpacialKa.Properties.AccessibleDescription")
        Me.mnuSpacialKa.Properties.AccessibleName = resources.GetString("mnuSpacialKa.Properties.AccessibleName")
        Me.mnuSpacialKa.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuSpacialKa.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuSpacialKa.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuSpacialKa.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuSpacialKa.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuSpacialKa.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuSpacialKa.Properties.Appearance.Image = CType(resources.GetObject("mnuSpacialKa.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuSpacialKa.Properties.Appearance.Options.UseFont = True
        Me.mnuSpacialKa.Properties.AutoHeight = CType(resources.GetObject("mnuSpacialKa.Properties.AutoHeight"), Boolean)
        Me.mnuSpacialKa.Properties.Caption = resources.GetString("mnuSpacialKa.Properties.Caption")
        Me.mnuSpacialKa.Properties.DisplayValueChecked = resources.GetString("mnuSpacialKa.Properties.DisplayValueChecked")
        Me.mnuSpacialKa.Properties.DisplayValueGrayed = resources.GetString("mnuSpacialKa.Properties.DisplayValueGrayed")
        Me.mnuSpacialKa.Properties.DisplayValueUnchecked = resources.GetString("mnuSpacialKa.Properties.DisplayValueUnchecked")
        Me.mnuSpacialKa.Properties.PictureChecked = CType(resources.GetObject("mnuSpacialKa.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuSpacialKa.Tag = "MN02031"
        '
        'mnuSetabsenceTimeByYear
        '
        resources.ApplyResources(Me.mnuSetabsenceTimeByYear, "mnuSetabsenceTimeByYear")
        Me.mnuSetabsenceTimeByYear.Name = "mnuSetabsenceTimeByYear"
        Me.mnuSetabsenceTimeByYear.Properties.AccessibleDescription = resources.GetString("mnuSetabsenceTimeByYear.Properties.AccessibleDescription")
        Me.mnuSetabsenceTimeByYear.Properties.AccessibleName = resources.GetString("mnuSetabsenceTimeByYear.Properties.AccessibleName")
        Me.mnuSetabsenceTimeByYear.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuSetabsenceTimeByYear.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuSetabsenceTimeByYear.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuSetabsenceTimeByYear.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuSetabsenceTimeByYear.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuSetabsenceTimeByYear.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuSetabsenceTimeByYear.Properties.Appearance.Image = CType(resources.GetObject("mnuSetabsenceTimeByYear.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuSetabsenceTimeByYear.Properties.Appearance.Options.UseFont = True
        Me.mnuSetabsenceTimeByYear.Properties.AutoHeight = CType(resources.GetObject("mnuSetabsenceTimeByYear.Properties.AutoHeight"), Boolean)
        Me.mnuSetabsenceTimeByYear.Properties.Caption = resources.GetString("mnuSetabsenceTimeByYear.Properties.Caption")
        Me.mnuSetabsenceTimeByYear.Properties.DisplayValueChecked = resources.GetString("mnuSetabsenceTimeByYear.Properties.DisplayValueChecked")
        Me.mnuSetabsenceTimeByYear.Properties.DisplayValueGrayed = resources.GetString("mnuSetabsenceTimeByYear.Properties.DisplayValueGrayed")
        Me.mnuSetabsenceTimeByYear.Properties.DisplayValueUnchecked = resources.GetString("mnuSetabsenceTimeByYear.Properties.DisplayValueUnchecked")
        Me.mnuSetabsenceTimeByYear.Properties.PictureChecked = CType(resources.GetObject("mnuSetabsenceTimeByYear.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuSetabsenceTimeByYear.Tag = "MN02018"
        '
        'mnuDeterminedTime
        '
        resources.ApplyResources(Me.mnuDeterminedTime, "mnuDeterminedTime")
        Me.mnuDeterminedTime.Name = "mnuDeterminedTime"
        Me.mnuDeterminedTime.Properties.AccessibleDescription = resources.GetString("mnuDeterminedTime.Properties.AccessibleDescription")
        Me.mnuDeterminedTime.Properties.AccessibleName = resources.GetString("mnuDeterminedTime.Properties.AccessibleName")
        Me.mnuDeterminedTime.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuDeterminedTime.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuDeterminedTime.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuDeterminedTime.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuDeterminedTime.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuDeterminedTime.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuDeterminedTime.Properties.Appearance.Image = CType(resources.GetObject("mnuDeterminedTime.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuDeterminedTime.Properties.Appearance.Options.UseFont = True
        Me.mnuDeterminedTime.Properties.AutoHeight = CType(resources.GetObject("mnuDeterminedTime.Properties.AutoHeight"), Boolean)
        Me.mnuDeterminedTime.Properties.Caption = resources.GetString("mnuDeterminedTime.Properties.Caption")
        Me.mnuDeterminedTime.Properties.DisplayValueChecked = resources.GetString("mnuDeterminedTime.Properties.DisplayValueChecked")
        Me.mnuDeterminedTime.Properties.DisplayValueGrayed = resources.GetString("mnuDeterminedTime.Properties.DisplayValueGrayed")
        Me.mnuDeterminedTime.Properties.DisplayValueUnchecked = resources.GetString("mnuDeterminedTime.Properties.DisplayValueUnchecked")
        Me.mnuDeterminedTime.Properties.PictureChecked = CType(resources.GetObject("mnuDeterminedTime.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuDeterminedTime.Tag = "MN02008"
        '
        'mnuOT
        '
        resources.ApplyResources(Me.mnuOT, "mnuOT")
        Me.mnuOT.Name = "mnuOT"
        Me.mnuOT.Properties.AccessibleDescription = resources.GetString("mnuOT.Properties.AccessibleDescription")
        Me.mnuOT.Properties.AccessibleName = resources.GetString("mnuOT.Properties.AccessibleName")
        Me.mnuOT.Properties.Appearance.Font = CType(resources.GetObject("mnuOT.Properties.Appearance.Font"), System.Drawing.Font)
        Me.mnuOT.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuOT.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuOT.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuOT.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuOT.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuOT.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuOT.Properties.Appearance.Image = CType(resources.GetObject("mnuOT.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuOT.Properties.Appearance.Options.UseFont = True
        Me.mnuOT.Properties.AutoHeight = CType(resources.GetObject("mnuOT.Properties.AutoHeight"), Boolean)
        Me.mnuOT.Properties.Caption = resources.GetString("mnuOT.Properties.Caption")
        Me.mnuOT.Properties.DisplayValueChecked = resources.GetString("mnuOT.Properties.DisplayValueChecked")
        Me.mnuOT.Properties.DisplayValueGrayed = resources.GetString("mnuOT.Properties.DisplayValueGrayed")
        Me.mnuOT.Properties.DisplayValueUnchecked = resources.GetString("mnuOT.Properties.DisplayValueUnchecked")
        Me.mnuOT.Properties.PictureChecked = CType(resources.GetObject("mnuOT.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuOT.Tag = "MN02022"
        '
        'mnuDeterminedTimeEmp
        '
        resources.ApplyResources(Me.mnuDeterminedTimeEmp, "mnuDeterminedTimeEmp")
        Me.mnuDeterminedTimeEmp.Name = "mnuDeterminedTimeEmp"
        Me.mnuDeterminedTimeEmp.Properties.AccessibleDescription = resources.GetString("mnuDeterminedTimeEmp.Properties.AccessibleDescription")
        Me.mnuDeterminedTimeEmp.Properties.AccessibleName = resources.GetString("mnuDeterminedTimeEmp.Properties.AccessibleName")
        Me.mnuDeterminedTimeEmp.Properties.Appearance.Font = CType(resources.GetObject("mnuDeterminedTimeEmp.Properties.Appearance.Font"), System.Drawing.Font)
        Me.mnuDeterminedTimeEmp.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuDeterminedTimeEmp.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuDeterminedTimeEmp.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuDeterminedTimeEmp.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuDeterminedTimeEmp.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuDeterminedTimeEmp.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuDeterminedTimeEmp.Properties.Appearance.Image = CType(resources.GetObject("mnuDeterminedTimeEmp.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuDeterminedTimeEmp.Properties.Appearance.Options.UseFont = True
        Me.mnuDeterminedTimeEmp.Properties.AutoHeight = CType(resources.GetObject("mnuDeterminedTimeEmp.Properties.AutoHeight"), Boolean)
        Me.mnuDeterminedTimeEmp.Properties.Caption = resources.GetString("mnuDeterminedTimeEmp.Properties.Caption")
        Me.mnuDeterminedTimeEmp.Properties.DisplayValueChecked = resources.GetString("mnuDeterminedTimeEmp.Properties.DisplayValueChecked")
        Me.mnuDeterminedTimeEmp.Properties.DisplayValueGrayed = resources.GetString("mnuDeterminedTimeEmp.Properties.DisplayValueGrayed")
        Me.mnuDeterminedTimeEmp.Properties.DisplayValueUnchecked = resources.GetString("mnuDeterminedTimeEmp.Properties.DisplayValueUnchecked")
        Me.mnuDeterminedTimeEmp.Properties.PictureChecked = CType(resources.GetObject("mnuDeterminedTimeEmp.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuDeterminedTimeEmp.Tag = "MN02009"
        '
        'mnucalculationLate
        '
        resources.ApplyResources(Me.mnucalculationLate, "mnucalculationLate")
        Me.mnucalculationLate.Name = "mnucalculationLate"
        Me.mnucalculationLate.Properties.AccessibleDescription = resources.GetString("mnucalculationLate.Properties.AccessibleDescription")
        Me.mnucalculationLate.Properties.AccessibleName = resources.GetString("mnucalculationLate.Properties.AccessibleName")
        Me.mnucalculationLate.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnucalculationLate.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnucalculationLate.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnucalculationLate.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnucalculationLate.Properties.Appearance.GradientMode = CType(resources.GetObject("mnucalculationLate.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnucalculationLate.Properties.Appearance.Image = CType(resources.GetObject("mnucalculationLate.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnucalculationLate.Properties.Appearance.Options.UseFont = True
        Me.mnucalculationLate.Properties.AutoHeight = CType(resources.GetObject("mnucalculationLate.Properties.AutoHeight"), Boolean)
        Me.mnucalculationLate.Properties.Caption = resources.GetString("mnucalculationLate.Properties.Caption")
        Me.mnucalculationLate.Properties.DisplayValueChecked = resources.GetString("mnucalculationLate.Properties.DisplayValueChecked")
        Me.mnucalculationLate.Properties.DisplayValueGrayed = resources.GetString("mnucalculationLate.Properties.DisplayValueGrayed")
        Me.mnucalculationLate.Properties.DisplayValueUnchecked = resources.GetString("mnucalculationLate.Properties.DisplayValueUnchecked")
        Me.mnucalculationLate.Properties.PictureChecked = CType(resources.GetObject("mnucalculationLate.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnucalculationLate.Tag = "MN02014"
        '
        'mnuDeterminedTimeEmpByOne
        '
        resources.ApplyResources(Me.mnuDeterminedTimeEmpByOne, "mnuDeterminedTimeEmpByOne")
        Me.mnuDeterminedTimeEmpByOne.Name = "mnuDeterminedTimeEmpByOne"
        Me.mnuDeterminedTimeEmpByOne.Properties.AccessibleDescription = resources.GetString("mnuDeterminedTimeEmpByOne.Properties.AccessibleDescription")
        Me.mnuDeterminedTimeEmpByOne.Properties.AccessibleName = resources.GetString("mnuDeterminedTimeEmpByOne.Properties.AccessibleName")
        Me.mnuDeterminedTimeEmpByOne.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuDeterminedTimeEmpByOne.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuDeterminedTimeEmpByOne.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuDeterminedTimeEmpByOne.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuDeterminedTimeEmpByOne.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuDeterminedTimeEmpByOne.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuDeterminedTimeEmpByOne.Properties.Appearance.Image = CType(resources.GetObject("mnuDeterminedTimeEmpByOne.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuDeterminedTimeEmpByOne.Properties.Appearance.Options.UseFont = True
        Me.mnuDeterminedTimeEmpByOne.Properties.AutoHeight = CType(resources.GetObject("mnuDeterminedTimeEmpByOne.Properties.AutoHeight"), Boolean)
        Me.mnuDeterminedTimeEmpByOne.Properties.Caption = resources.GetString("mnuDeterminedTimeEmpByOne.Properties.Caption")
        Me.mnuDeterminedTimeEmpByOne.Properties.DisplayValueChecked = resources.GetString("mnuDeterminedTimeEmpByOne.Properties.DisplayValueChecked")
        Me.mnuDeterminedTimeEmpByOne.Properties.DisplayValueGrayed = resources.GetString("mnuDeterminedTimeEmpByOne.Properties.DisplayValueGrayed")
        Me.mnuDeterminedTimeEmpByOne.Properties.DisplayValueUnchecked = resources.GetString("mnuDeterminedTimeEmpByOne.Properties.DisplayValueUnchecked")
        Me.mnuDeterminedTimeEmpByOne.Properties.PictureChecked = CType(resources.GetObject("mnuDeterminedTimeEmpByOne.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuDeterminedTimeEmpByOne.Tag = "MN02010"
        '
        'mnuSetLeave
        '
        resources.ApplyResources(Me.mnuSetLeave, "mnuSetLeave")
        Me.mnuSetLeave.Name = "mnuSetLeave"
        Me.mnuSetLeave.Properties.AccessibleDescription = resources.GetString("mnuSetLeave.Properties.AccessibleDescription")
        Me.mnuSetLeave.Properties.AccessibleName = resources.GetString("mnuSetLeave.Properties.AccessibleName")
        Me.mnuSetLeave.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuSetLeave.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuSetLeave.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuSetLeave.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuSetLeave.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuSetLeave.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuSetLeave.Properties.Appearance.Image = CType(resources.GetObject("mnuSetLeave.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuSetLeave.Properties.Appearance.Options.UseFont = True
        Me.mnuSetLeave.Properties.AutoHeight = CType(resources.GetObject("mnuSetLeave.Properties.AutoHeight"), Boolean)
        Me.mnuSetLeave.Properties.Caption = resources.GetString("mnuSetLeave.Properties.Caption")
        Me.mnuSetLeave.Properties.DisplayValueChecked = resources.GetString("mnuSetLeave.Properties.DisplayValueChecked")
        Me.mnuSetLeave.Properties.DisplayValueGrayed = resources.GetString("mnuSetLeave.Properties.DisplayValueGrayed")
        Me.mnuSetLeave.Properties.DisplayValueUnchecked = resources.GetString("mnuSetLeave.Properties.DisplayValueUnchecked")
        Me.mnuSetLeave.Properties.PictureChecked = CType(resources.GetObject("mnuSetLeave.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuSetLeave.Tag = "MN02017"
        '
        'mnuDeterminedTimeEmpByDate
        '
        resources.ApplyResources(Me.mnuDeterminedTimeEmpByDate, "mnuDeterminedTimeEmpByDate")
        Me.mnuDeterminedTimeEmpByDate.Name = "mnuDeterminedTimeEmpByDate"
        Me.mnuDeterminedTimeEmpByDate.Properties.AccessibleDescription = resources.GetString("mnuDeterminedTimeEmpByDate.Properties.AccessibleDescription")
        Me.mnuDeterminedTimeEmpByDate.Properties.AccessibleName = resources.GetString("mnuDeterminedTimeEmpByDate.Properties.AccessibleName")
        Me.mnuDeterminedTimeEmpByDate.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuDeterminedTimeEmpByDate.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuDeterminedTimeEmpByDate.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuDeterminedTimeEmpByDate.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuDeterminedTimeEmpByDate.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuDeterminedTimeEmpByDate.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuDeterminedTimeEmpByDate.Properties.Appearance.Image = CType(resources.GetObject("mnuDeterminedTimeEmpByDate.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuDeterminedTimeEmpByDate.Properties.Appearance.Options.UseFont = True
        Me.mnuDeterminedTimeEmpByDate.Properties.AutoHeight = CType(resources.GetObject("mnuDeterminedTimeEmpByDate.Properties.AutoHeight"), Boolean)
        Me.mnuDeterminedTimeEmpByDate.Properties.Caption = resources.GetString("mnuDeterminedTimeEmpByDate.Properties.Caption")
        Me.mnuDeterminedTimeEmpByDate.Properties.DisplayValueChecked = resources.GetString("mnuDeterminedTimeEmpByDate.Properties.DisplayValueChecked")
        Me.mnuDeterminedTimeEmpByDate.Properties.DisplayValueGrayed = resources.GetString("mnuDeterminedTimeEmpByDate.Properties.DisplayValueGrayed")
        Me.mnuDeterminedTimeEmpByDate.Properties.DisplayValueUnchecked = resources.GetString("mnuDeterminedTimeEmpByDate.Properties.DisplayValueUnchecked")
        Me.mnuDeterminedTimeEmpByDate.Properties.PictureChecked = CType(resources.GetObject("mnuDeterminedTimeEmpByDate.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuDeterminedTimeEmpByDate.Tag = "MN02011"
        '
        'mnuProcessOT
        '
        resources.ApplyResources(Me.mnuProcessOT, "mnuProcessOT")
        Me.mnuProcessOT.Name = "mnuProcessOT"
        Me.mnuProcessOT.Properties.AccessibleDescription = resources.GetString("mnuProcessOT.Properties.AccessibleDescription")
        Me.mnuProcessOT.Properties.AccessibleName = resources.GetString("mnuProcessOT.Properties.AccessibleName")
        Me.mnuProcessOT.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuProcessOT.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuProcessOT.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuProcessOT.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuProcessOT.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuProcessOT.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuProcessOT.Properties.Appearance.Image = CType(resources.GetObject("mnuProcessOT.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuProcessOT.Properties.Appearance.Options.UseFont = True
        Me.mnuProcessOT.Properties.AutoHeight = CType(resources.GetObject("mnuProcessOT.Properties.AutoHeight"), Boolean)
        Me.mnuProcessOT.Properties.Caption = resources.GetString("mnuProcessOT.Properties.Caption")
        Me.mnuProcessOT.Properties.DisplayValueChecked = resources.GetString("mnuProcessOT.Properties.DisplayValueChecked")
        Me.mnuProcessOT.Properties.DisplayValueGrayed = resources.GetString("mnuProcessOT.Properties.DisplayValueGrayed")
        Me.mnuProcessOT.Properties.DisplayValueUnchecked = resources.GetString("mnuProcessOT.Properties.DisplayValueUnchecked")
        Me.mnuProcessOT.Properties.PictureChecked = CType(resources.GetObject("mnuProcessOT.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuProcessOT.Tag = "MN02013"
        '
        'XtraTabPage5
        '
        resources.ApplyResources(Me.XtraTabPage5, "XtraTabPage5")
        Me.XtraTabPage5.Appearance.Header.Font = CType(resources.GetObject("XtraTabPage5.Appearance.Header.Font"), System.Drawing.Font)
        Me.XtraTabPage5.Appearance.Header.FontSizeDelta = CType(resources.GetObject("XtraTabPage5.Appearance.Header.FontSizeDelta"), Integer)
        Me.XtraTabPage5.Appearance.Header.FontStyleDelta = CType(resources.GetObject("XtraTabPage5.Appearance.Header.FontStyleDelta"), System.Drawing.FontStyle)
        Me.XtraTabPage5.Appearance.Header.GradientMode = CType(resources.GetObject("XtraTabPage5.Appearance.Header.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.XtraTabPage5.Appearance.Header.Image = CType(resources.GetObject("XtraTabPage5.Appearance.Header.Image"), System.Drawing.Image)
        Me.XtraTabPage5.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage5.Appearance.HeaderActive.Font = CType(resources.GetObject("XtraTabPage5.Appearance.HeaderActive.Font"), System.Drawing.Font)
        Me.XtraTabPage5.Appearance.HeaderActive.FontSizeDelta = CType(resources.GetObject("XtraTabPage5.Appearance.HeaderActive.FontSizeDelta"), Integer)
        Me.XtraTabPage5.Appearance.HeaderActive.FontStyleDelta = CType(resources.GetObject("XtraTabPage5.Appearance.HeaderActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.XtraTabPage5.Appearance.HeaderActive.GradientMode = CType(resources.GetObject("XtraTabPage5.Appearance.HeaderActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.XtraTabPage5.Appearance.HeaderActive.Image = CType(resources.GetObject("XtraTabPage5.Appearance.HeaderActive.Image"), System.Drawing.Image)
        Me.XtraTabPage5.Appearance.HeaderActive.Options.UseFont = True
        Me.XtraTabPage5.Controls.Add(Me.XtraScrollableControl3)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        '
        'XtraScrollableControl3
        '
        resources.ApplyResources(Me.XtraScrollableControl3, "XtraScrollableControl3")
        Me.XtraScrollableControl3.Appearance.BackColor = CType(resources.GetObject("XtraScrollableControl3.Appearance.BackColor"), System.Drawing.Color)
        Me.XtraScrollableControl3.Appearance.FontSizeDelta = CType(resources.GetObject("XtraScrollableControl3.Appearance.FontSizeDelta"), Integer)
        Me.XtraScrollableControl3.Appearance.FontStyleDelta = CType(resources.GetObject("XtraScrollableControl3.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.XtraScrollableControl3.Appearance.GradientMode = CType(resources.GetObject("XtraScrollableControl3.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.XtraScrollableControl3.Appearance.Image = CType(resources.GetObject("XtraScrollableControl3.Appearance.Image"), System.Drawing.Image)
        Me.XtraScrollableControl3.Appearance.Options.UseBackColor = True
        Me.XtraScrollableControl3.Controls.Add(Me.mnurptScheduleWorkAllEmp2)
        Me.XtraScrollableControl3.Controls.Add(Me.mnuReport)
        Me.XtraScrollableControl3.Controls.Add(Me.munOvertimeLeage)
        Me.XtraScrollableControl3.Controls.Add(Me.mnurptTimeWork)
        Me.XtraScrollableControl3.Controls.Add(Me.mnurptAllemployeework2)
        Me.XtraScrollableControl3.Controls.Add(Me.mnurptemployeeByDate)
        Me.XtraScrollableControl3.Controls.Add(Me.mnurptEmpWorkDetail1_M)
        Me.XtraScrollableControl3.Name = "XtraScrollableControl3"
        '
        'mnurptScheduleWorkAllEmp2
        '
        resources.ApplyResources(Me.mnurptScheduleWorkAllEmp2, "mnurptScheduleWorkAllEmp2")
        Me.mnurptScheduleWorkAllEmp2.Name = "mnurptScheduleWorkAllEmp2"
        Me.mnurptScheduleWorkAllEmp2.Properties.AccessibleDescription = resources.GetString("mnurptScheduleWorkAllEmp2.Properties.AccessibleDescription")
        Me.mnurptScheduleWorkAllEmp2.Properties.AccessibleName = resources.GetString("mnurptScheduleWorkAllEmp2.Properties.AccessibleName")
        Me.mnurptScheduleWorkAllEmp2.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnurptScheduleWorkAllEmp2.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnurptScheduleWorkAllEmp2.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnurptScheduleWorkAllEmp2.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnurptScheduleWorkAllEmp2.Properties.Appearance.GradientMode = CType(resources.GetObject("mnurptScheduleWorkAllEmp2.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnurptScheduleWorkAllEmp2.Properties.Appearance.Image = CType(resources.GetObject("mnurptScheduleWorkAllEmp2.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnurptScheduleWorkAllEmp2.Properties.Appearance.Options.UseFont = True
        Me.mnurptScheduleWorkAllEmp2.Properties.AutoHeight = CType(resources.GetObject("mnurptScheduleWorkAllEmp2.Properties.AutoHeight"), Boolean)
        Me.mnurptScheduleWorkAllEmp2.Properties.Caption = resources.GetString("mnurptScheduleWorkAllEmp2.Properties.Caption")
        Me.mnurptScheduleWorkAllEmp2.Properties.DisplayValueChecked = resources.GetString("mnurptScheduleWorkAllEmp2.Properties.DisplayValueChecked")
        Me.mnurptScheduleWorkAllEmp2.Properties.DisplayValueGrayed = resources.GetString("mnurptScheduleWorkAllEmp2.Properties.DisplayValueGrayed")
        Me.mnurptScheduleWorkAllEmp2.Properties.DisplayValueUnchecked = resources.GetString("mnurptScheduleWorkAllEmp2.Properties.DisplayValueUnchecked")
        Me.mnurptScheduleWorkAllEmp2.Properties.PictureChecked = CType(resources.GetObject("mnurptScheduleWorkAllEmp2.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnurptScheduleWorkAllEmp2.Tag = "MN03026"
        '
        'mnuReport
        '
        resources.ApplyResources(Me.mnuReport, "mnuReport")
        Me.mnuReport.Name = "mnuReport"
        Me.mnuReport.Properties.AccessibleDescription = resources.GetString("mnuReport.Properties.AccessibleDescription")
        Me.mnuReport.Properties.AccessibleName = resources.GetString("mnuReport.Properties.AccessibleName")
        Me.mnuReport.Properties.Appearance.Font = CType(resources.GetObject("mnuReport.Properties.Appearance.Font"), System.Drawing.Font)
        Me.mnuReport.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuReport.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuReport.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuReport.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuReport.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuReport.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuReport.Properties.Appearance.Image = CType(resources.GetObject("mnuReport.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuReport.Properties.Appearance.Options.UseFont = True
        Me.mnuReport.Properties.AutoHeight = CType(resources.GetObject("mnuReport.Properties.AutoHeight"), Boolean)
        Me.mnuReport.Properties.Caption = resources.GetString("mnuReport.Properties.Caption")
        Me.mnuReport.Properties.DisplayValueChecked = resources.GetString("mnuReport.Properties.DisplayValueChecked")
        Me.mnuReport.Properties.DisplayValueGrayed = resources.GetString("mnuReport.Properties.DisplayValueGrayed")
        Me.mnuReport.Properties.DisplayValueUnchecked = resources.GetString("mnuReport.Properties.DisplayValueUnchecked")
        Me.mnuReport.Properties.ImageIndexChecked = 0
        Me.mnuReport.Properties.ImageIndexGrayed = 1
        Me.mnuReport.Properties.ImageIndexUnchecked = 2
        Me.mnuReport.Tag = "MN03020"
        '
        'munOvertimeLeage
        '
        resources.ApplyResources(Me.munOvertimeLeage, "munOvertimeLeage")
        Me.munOvertimeLeage.Name = "munOvertimeLeage"
        Me.munOvertimeLeage.Properties.AccessibleDescription = resources.GetString("munOvertimeLeage.Properties.AccessibleDescription")
        Me.munOvertimeLeage.Properties.AccessibleName = resources.GetString("munOvertimeLeage.Properties.AccessibleName")
        Me.munOvertimeLeage.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("munOvertimeLeage.Properties.Appearance.FontSizeDelta"), Integer)
        Me.munOvertimeLeage.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("munOvertimeLeage.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.munOvertimeLeage.Properties.Appearance.GradientMode = CType(resources.GetObject("munOvertimeLeage.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.munOvertimeLeage.Properties.Appearance.Image = CType(resources.GetObject("munOvertimeLeage.Properties.Appearance.Image"), System.Drawing.Image)
        Me.munOvertimeLeage.Properties.Appearance.Options.UseFont = True
        Me.munOvertimeLeage.Properties.AutoHeight = CType(resources.GetObject("munOvertimeLeage.Properties.AutoHeight"), Boolean)
        Me.munOvertimeLeage.Properties.Caption = resources.GetString("munOvertimeLeage.Properties.Caption")
        Me.munOvertimeLeage.Properties.DisplayValueChecked = resources.GetString("munOvertimeLeage.Properties.DisplayValueChecked")
        Me.munOvertimeLeage.Properties.DisplayValueGrayed = resources.GetString("munOvertimeLeage.Properties.DisplayValueGrayed")
        Me.munOvertimeLeage.Properties.DisplayValueUnchecked = resources.GetString("munOvertimeLeage.Properties.DisplayValueUnchecked")
        Me.munOvertimeLeage.Properties.PictureChecked = CType(resources.GetObject("munOvertimeLeage.Properties.PictureChecked"), System.Drawing.Image)
        Me.munOvertimeLeage.Tag = "MN03028"
        '
        'mnurptTimeWork
        '
        resources.ApplyResources(Me.mnurptTimeWork, "mnurptTimeWork")
        Me.mnurptTimeWork.Name = "mnurptTimeWork"
        Me.mnurptTimeWork.Properties.AccessibleDescription = resources.GetString("mnurptTimeWork.Properties.AccessibleDescription")
        Me.mnurptTimeWork.Properties.AccessibleName = resources.GetString("mnurptTimeWork.Properties.AccessibleName")
        Me.mnurptTimeWork.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnurptTimeWork.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnurptTimeWork.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnurptTimeWork.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnurptTimeWork.Properties.Appearance.GradientMode = CType(resources.GetObject("mnurptTimeWork.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnurptTimeWork.Properties.Appearance.Image = CType(resources.GetObject("mnurptTimeWork.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnurptTimeWork.Properties.Appearance.Options.UseFont = True
        Me.mnurptTimeWork.Properties.AutoHeight = CType(resources.GetObject("mnurptTimeWork.Properties.AutoHeight"), Boolean)
        Me.mnurptTimeWork.Properties.Caption = resources.GetString("mnurptTimeWork.Properties.Caption")
        Me.mnurptTimeWork.Properties.DisplayValueChecked = resources.GetString("mnurptTimeWork.Properties.DisplayValueChecked")
        Me.mnurptTimeWork.Properties.DisplayValueGrayed = resources.GetString("mnurptTimeWork.Properties.DisplayValueGrayed")
        Me.mnurptTimeWork.Properties.DisplayValueUnchecked = resources.GetString("mnurptTimeWork.Properties.DisplayValueUnchecked")
        Me.mnurptTimeWork.Properties.PictureChecked = CType(resources.GetObject("mnurptTimeWork.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnurptTimeWork.Tag = "MN03022"
        '
        'mnurptAllemployeework2
        '
        resources.ApplyResources(Me.mnurptAllemployeework2, "mnurptAllemployeework2")
        Me.mnurptAllemployeework2.Name = "mnurptAllemployeework2"
        Me.mnurptAllemployeework2.Properties.AccessibleDescription = resources.GetString("mnurptAllemployeework2.Properties.AccessibleDescription")
        Me.mnurptAllemployeework2.Properties.AccessibleName = resources.GetString("mnurptAllemployeework2.Properties.AccessibleName")
        Me.mnurptAllemployeework2.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnurptAllemployeework2.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnurptAllemployeework2.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnurptAllemployeework2.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnurptAllemployeework2.Properties.Appearance.GradientMode = CType(resources.GetObject("mnurptAllemployeework2.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnurptAllemployeework2.Properties.Appearance.Image = CType(resources.GetObject("mnurptAllemployeework2.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnurptAllemployeework2.Properties.Appearance.Options.UseFont = True
        Me.mnurptAllemployeework2.Properties.AutoHeight = CType(resources.GetObject("mnurptAllemployeework2.Properties.AutoHeight"), Boolean)
        Me.mnurptAllemployeework2.Properties.Caption = resources.GetString("mnurptAllemployeework2.Properties.Caption")
        Me.mnurptAllemployeework2.Properties.DisplayValueChecked = resources.GetString("mnurptAllemployeework2.Properties.DisplayValueChecked")
        Me.mnurptAllemployeework2.Properties.DisplayValueGrayed = resources.GetString("mnurptAllemployeework2.Properties.DisplayValueGrayed")
        Me.mnurptAllemployeework2.Properties.DisplayValueUnchecked = resources.GetString("mnurptAllemployeework2.Properties.DisplayValueUnchecked")
        Me.mnurptAllemployeework2.Properties.PictureChecked = CType(resources.GetObject("mnurptAllemployeework2.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnurptAllemployeework2.Tag = "MN03025"
        '
        'mnurptemployeeByDate
        '
        resources.ApplyResources(Me.mnurptemployeeByDate, "mnurptemployeeByDate")
        Me.mnurptemployeeByDate.Name = "mnurptemployeeByDate"
        Me.mnurptemployeeByDate.Properties.AccessibleDescription = resources.GetString("mnurptemployeeByDate.Properties.AccessibleDescription")
        Me.mnurptemployeeByDate.Properties.AccessibleName = resources.GetString("mnurptemployeeByDate.Properties.AccessibleName")
        Me.mnurptemployeeByDate.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnurptemployeeByDate.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnurptemployeeByDate.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnurptemployeeByDate.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnurptemployeeByDate.Properties.Appearance.GradientMode = CType(resources.GetObject("mnurptemployeeByDate.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnurptemployeeByDate.Properties.Appearance.Image = CType(resources.GetObject("mnurptemployeeByDate.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnurptemployeeByDate.Properties.Appearance.Options.UseFont = True
        Me.mnurptemployeeByDate.Properties.AutoHeight = CType(resources.GetObject("mnurptemployeeByDate.Properties.AutoHeight"), Boolean)
        Me.mnurptemployeeByDate.Properties.Caption = resources.GetString("mnurptemployeeByDate.Properties.Caption")
        Me.mnurptemployeeByDate.Properties.DisplayValueChecked = resources.GetString("mnurptemployeeByDate.Properties.DisplayValueChecked")
        Me.mnurptemployeeByDate.Properties.DisplayValueGrayed = resources.GetString("mnurptemployeeByDate.Properties.DisplayValueGrayed")
        Me.mnurptemployeeByDate.Properties.DisplayValueUnchecked = resources.GetString("mnurptemployeeByDate.Properties.DisplayValueUnchecked")
        Me.mnurptemployeeByDate.Properties.PictureChecked = CType(resources.GetObject("mnurptemployeeByDate.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnurptemployeeByDate.Tag = "MN03027"
        '
        'mnurptEmpWorkDetail1_M
        '
        resources.ApplyResources(Me.mnurptEmpWorkDetail1_M, "mnurptEmpWorkDetail1_M")
        Me.mnurptEmpWorkDetail1_M.Name = "mnurptEmpWorkDetail1_M"
        Me.mnurptEmpWorkDetail1_M.Properties.AccessibleDescription = resources.GetString("mnurptEmpWorkDetail1_M.Properties.AccessibleDescription")
        Me.mnurptEmpWorkDetail1_M.Properties.AccessibleName = resources.GetString("mnurptEmpWorkDetail1_M.Properties.AccessibleName")
        Me.mnurptEmpWorkDetail1_M.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnurptEmpWorkDetail1_M.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnurptEmpWorkDetail1_M.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnurptEmpWorkDetail1_M.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnurptEmpWorkDetail1_M.Properties.Appearance.GradientMode = CType(resources.GetObject("mnurptEmpWorkDetail1_M.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnurptEmpWorkDetail1_M.Properties.Appearance.Image = CType(resources.GetObject("mnurptEmpWorkDetail1_M.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnurptEmpWorkDetail1_M.Properties.Appearance.Options.UseFont = True
        Me.mnurptEmpWorkDetail1_M.Properties.AutoHeight = CType(resources.GetObject("mnurptEmpWorkDetail1_M.Properties.AutoHeight"), Boolean)
        Me.mnurptEmpWorkDetail1_M.Properties.Caption = resources.GetString("mnurptEmpWorkDetail1_M.Properties.Caption")
        Me.mnurptEmpWorkDetail1_M.Properties.DisplayValueChecked = resources.GetString("mnurptEmpWorkDetail1_M.Properties.DisplayValueChecked")
        Me.mnurptEmpWorkDetail1_M.Properties.DisplayValueGrayed = resources.GetString("mnurptEmpWorkDetail1_M.Properties.DisplayValueGrayed")
        Me.mnurptEmpWorkDetail1_M.Properties.DisplayValueUnchecked = resources.GetString("mnurptEmpWorkDetail1_M.Properties.DisplayValueUnchecked")
        Me.mnurptEmpWorkDetail1_M.Properties.PictureChecked = CType(resources.GetObject("mnurptEmpWorkDetail1_M.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnurptEmpWorkDetail1_M.Tag = "MN03023"
        '
        'XtraTabPage6
        '
        resources.ApplyResources(Me.XtraTabPage6, "XtraTabPage6")
        Me.XtraTabPage6.Appearance.Header.Font = CType(resources.GetObject("XtraTabPage6.Appearance.Header.Font"), System.Drawing.Font)
        Me.XtraTabPage6.Appearance.Header.FontSizeDelta = CType(resources.GetObject("XtraTabPage6.Appearance.Header.FontSizeDelta"), Integer)
        Me.XtraTabPage6.Appearance.Header.FontStyleDelta = CType(resources.GetObject("XtraTabPage6.Appearance.Header.FontStyleDelta"), System.Drawing.FontStyle)
        Me.XtraTabPage6.Appearance.Header.GradientMode = CType(resources.GetObject("XtraTabPage6.Appearance.Header.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.XtraTabPage6.Appearance.Header.Image = CType(resources.GetObject("XtraTabPage6.Appearance.Header.Image"), System.Drawing.Image)
        Me.XtraTabPage6.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage6.Appearance.HeaderActive.Font = CType(resources.GetObject("XtraTabPage6.Appearance.HeaderActive.Font"), System.Drawing.Font)
        Me.XtraTabPage6.Appearance.HeaderActive.FontSizeDelta = CType(resources.GetObject("XtraTabPage6.Appearance.HeaderActive.FontSizeDelta"), Integer)
        Me.XtraTabPage6.Appearance.HeaderActive.FontStyleDelta = CType(resources.GetObject("XtraTabPage6.Appearance.HeaderActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.XtraTabPage6.Appearance.HeaderActive.GradientMode = CType(resources.GetObject("XtraTabPage6.Appearance.HeaderActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.XtraTabPage6.Appearance.HeaderActive.Image = CType(resources.GetObject("XtraTabPage6.Appearance.HeaderActive.Image"), System.Drawing.Image)
        Me.XtraTabPage6.Appearance.HeaderActive.Options.UseFont = True
        Me.XtraTabPage6.Controls.Add(Me.XtraScrollableControl4)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        '
        'XtraScrollableControl4
        '
        resources.ApplyResources(Me.XtraScrollableControl4, "XtraScrollableControl4")
        Me.XtraScrollableControl4.Appearance.BackColor = CType(resources.GetObject("XtraScrollableControl4.Appearance.BackColor"), System.Drawing.Color)
        Me.XtraScrollableControl4.Appearance.FontSizeDelta = CType(resources.GetObject("XtraScrollableControl4.Appearance.FontSizeDelta"), Integer)
        Me.XtraScrollableControl4.Appearance.FontStyleDelta = CType(resources.GetObject("XtraScrollableControl4.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.XtraScrollableControl4.Appearance.GradientMode = CType(resources.GetObject("XtraScrollableControl4.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.XtraScrollableControl4.Appearance.Image = CType(resources.GetObject("XtraScrollableControl4.Appearance.Image"), System.Drawing.Image)
        Me.XtraScrollableControl4.Appearance.Options.UseBackColor = True
        Me.XtraScrollableControl4.Controls.Add(Me.mnuPerUser)
        Me.XtraScrollableControl4.Controls.Add(Me.mnuPermission)
        Me.XtraScrollableControl4.Controls.Add(Me.mnuPerPattern)
        Me.XtraScrollableControl4.Controls.Add(Me.mnuUserPass)
        Me.XtraScrollableControl4.Name = "XtraScrollableControl4"
        '
        'mnuPerUser
        '
        resources.ApplyResources(Me.mnuPerUser, "mnuPerUser")
        Me.mnuPerUser.Name = "mnuPerUser"
        Me.mnuPerUser.Properties.AccessibleDescription = resources.GetString("mnuPerUser.Properties.AccessibleDescription")
        Me.mnuPerUser.Properties.AccessibleName = resources.GetString("mnuPerUser.Properties.AccessibleName")
        Me.mnuPerUser.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuPerUser.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuPerUser.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuPerUser.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuPerUser.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuPerUser.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuPerUser.Properties.Appearance.Image = CType(resources.GetObject("mnuPerUser.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuPerUser.Properties.Appearance.Options.UseFont = True
        Me.mnuPerUser.Properties.AutoHeight = CType(resources.GetObject("mnuPerUser.Properties.AutoHeight"), Boolean)
        Me.mnuPerUser.Properties.Caption = resources.GetString("mnuPerUser.Properties.Caption")
        Me.mnuPerUser.Properties.DisplayValueChecked = resources.GetString("mnuPerUser.Properties.DisplayValueChecked")
        Me.mnuPerUser.Properties.DisplayValueGrayed = resources.GetString("mnuPerUser.Properties.DisplayValueGrayed")
        Me.mnuPerUser.Properties.DisplayValueUnchecked = resources.GetString("mnuPerUser.Properties.DisplayValueUnchecked")
        Me.mnuPerUser.Properties.PictureChecked = CType(resources.GetObject("mnuPerUser.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuPerUser.Tag = "MN05006"
        '
        'mnuPermission
        '
        resources.ApplyResources(Me.mnuPermission, "mnuPermission")
        Me.mnuPermission.Name = "mnuPermission"
        Me.mnuPermission.Properties.AccessibleDescription = resources.GetString("mnuPermission.Properties.AccessibleDescription")
        Me.mnuPermission.Properties.AccessibleName = resources.GetString("mnuPermission.Properties.AccessibleName")
        Me.mnuPermission.Properties.Appearance.Font = CType(resources.GetObject("mnuPermission.Properties.Appearance.Font"), System.Drawing.Font)
        Me.mnuPermission.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuPermission.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuPermission.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuPermission.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuPermission.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuPermission.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuPermission.Properties.Appearance.Image = CType(resources.GetObject("mnuPermission.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuPermission.Properties.Appearance.Options.UseFont = True
        Me.mnuPermission.Properties.AutoHeight = CType(resources.GetObject("mnuPermission.Properties.AutoHeight"), Boolean)
        Me.mnuPermission.Properties.Caption = resources.GetString("mnuPermission.Properties.Caption")
        Me.mnuPermission.Properties.DisplayValueChecked = resources.GetString("mnuPermission.Properties.DisplayValueChecked")
        Me.mnuPermission.Properties.DisplayValueGrayed = resources.GetString("mnuPermission.Properties.DisplayValueGrayed")
        Me.mnuPermission.Properties.DisplayValueUnchecked = resources.GetString("mnuPermission.Properties.DisplayValueUnchecked")
        Me.mnuPermission.Properties.ImageIndexChecked = 0
        Me.mnuPermission.Properties.ImageIndexGrayed = 1
        Me.mnuPermission.Properties.ImageIndexUnchecked = 2
        Me.mnuPermission.Tag = "MN05003"
        '
        'mnuPerPattern
        '
        resources.ApplyResources(Me.mnuPerPattern, "mnuPerPattern")
        Me.mnuPerPattern.Name = "mnuPerPattern"
        Me.mnuPerPattern.Properties.AccessibleDescription = resources.GetString("mnuPerPattern.Properties.AccessibleDescription")
        Me.mnuPerPattern.Properties.AccessibleName = resources.GetString("mnuPerPattern.Properties.AccessibleName")
        Me.mnuPerPattern.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuPerPattern.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuPerPattern.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuPerPattern.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuPerPattern.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuPerPattern.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuPerPattern.Properties.Appearance.Image = CType(resources.GetObject("mnuPerPattern.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuPerPattern.Properties.Appearance.Options.UseFont = True
        Me.mnuPerPattern.Properties.AutoHeight = CType(resources.GetObject("mnuPerPattern.Properties.AutoHeight"), Boolean)
        Me.mnuPerPattern.Properties.Caption = resources.GetString("mnuPerPattern.Properties.Caption")
        Me.mnuPerPattern.Properties.DisplayValueChecked = resources.GetString("mnuPerPattern.Properties.DisplayValueChecked")
        Me.mnuPerPattern.Properties.DisplayValueGrayed = resources.GetString("mnuPerPattern.Properties.DisplayValueGrayed")
        Me.mnuPerPattern.Properties.DisplayValueUnchecked = resources.GetString("mnuPerPattern.Properties.DisplayValueUnchecked")
        Me.mnuPerPattern.Properties.PictureChecked = CType(resources.GetObject("mnuPerPattern.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuPerPattern.Tag = "MN05005"
        '
        'mnuUserPass
        '
        resources.ApplyResources(Me.mnuUserPass, "mnuUserPass")
        Me.mnuUserPass.Name = "mnuUserPass"
        Me.mnuUserPass.Properties.AccessibleDescription = resources.GetString("mnuUserPass.Properties.AccessibleDescription")
        Me.mnuUserPass.Properties.AccessibleName = resources.GetString("mnuUserPass.Properties.AccessibleName")
        Me.mnuUserPass.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("mnuUserPass.Properties.Appearance.FontSizeDelta"), Integer)
        Me.mnuUserPass.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("mnuUserPass.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.mnuUserPass.Properties.Appearance.GradientMode = CType(resources.GetObject("mnuUserPass.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.mnuUserPass.Properties.Appearance.Image = CType(resources.GetObject("mnuUserPass.Properties.Appearance.Image"), System.Drawing.Image)
        Me.mnuUserPass.Properties.Appearance.Options.UseFont = True
        Me.mnuUserPass.Properties.AutoHeight = CType(resources.GetObject("mnuUserPass.Properties.AutoHeight"), Boolean)
        Me.mnuUserPass.Properties.Caption = resources.GetString("mnuUserPass.Properties.Caption")
        Me.mnuUserPass.Properties.DisplayValueChecked = resources.GetString("mnuUserPass.Properties.DisplayValueChecked")
        Me.mnuUserPass.Properties.DisplayValueGrayed = resources.GetString("mnuUserPass.Properties.DisplayValueGrayed")
        Me.mnuUserPass.Properties.DisplayValueUnchecked = resources.GetString("mnuUserPass.Properties.DisplayValueUnchecked")
        Me.mnuUserPass.Properties.PictureChecked = CType(resources.GetObject("mnuUserPass.Properties.PictureChecked"), System.Drawing.Image)
        Me.mnuUserPass.Tag = "MN05004"
        '
        'GroupPanel2
        '
        resources.ApplyResources(Me.GroupPanel2, "GroupPanel2")
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.TabControl1)
        Me.GroupPanel2.Name = "GroupPanel2"
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.Class = ""
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.Class = ""
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.Class = ""
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'TabControl1
        '
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.SelectedTabIndex = 1
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Tabs.Add(Me.TabItem2)
        '
        'TabControlPanel1
        '
        resources.ApplyResources(Me.TabControlPanel1, "TabControlPanel1")
        Me.TabControlPanel1.Controls.Add(Me.PG)
        Me.TabControlPanel1.Controls.Add(Me.LabelX3)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'PG
        '
        resources.ApplyResources(Me.PG, "PG")
        '
        '
        '
        Me.PG.BackgroundStyle.Class = ""
        Me.PG.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PG.Name = "PG"
        '
        'LabelX3
        '
        resources.ApplyResources(Me.LabelX3, "LabelX3")
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        resources.ApplyResources(Me.TabItem1, "TabItem1")
        '
        'TabControlPanel2
        '
        resources.ApplyResources(Me.TabControlPanel2, "TabControlPanel2")
        Me.TabControlPanel2.Controls.Add(Me.lblEmpId)
        Me.TabControlPanel2.Controls.Add(Me.lblName)
        Me.TabControlPanel2.Controls.Add(Me.LabelX9)
        Me.TabControlPanel2.Controls.Add(Me.LabelX4)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabItem = Me.TabItem2
        '
        'lblEmpId
        '
        resources.ApplyResources(Me.lblEmpId, "lblEmpId")
        '
        '
        '
        Me.lblEmpId.Border.Class = "TextBoxBorder"
        Me.lblEmpId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblEmpId.ButtonCustom.DisplayPosition = CType(resources.GetObject("lblEmpId.ButtonCustom.DisplayPosition"), Integer)
        Me.lblEmpId.ButtonCustom.Image = CType(resources.GetObject("lblEmpId.ButtonCustom.Image"), System.Drawing.Image)
        Me.lblEmpId.ButtonCustom.Text = resources.GetString("lblEmpId.ButtonCustom.Text")
        Me.lblEmpId.ButtonCustom2.DisplayPosition = CType(resources.GetObject("lblEmpId.ButtonCustom2.DisplayPosition"), Integer)
        Me.lblEmpId.ButtonCustom2.Image = CType(resources.GetObject("lblEmpId.ButtonCustom2.Image"), System.Drawing.Image)
        Me.lblEmpId.ButtonCustom2.Text = resources.GetString("lblEmpId.ButtonCustom2.Text")
        Me.lblEmpId.Name = "lblEmpId"
        '
        'lblName
        '
        resources.ApplyResources(Me.lblName, "lblName")
        Me.lblName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.lblName.BackgroundStyle.Class = ""
        Me.lblName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblName.Name = "lblName"
        '
        'LabelX9
        '
        resources.ApplyResources(Me.LabelX9, "LabelX9")
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.Class = ""
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX4
        '
        resources.ApplyResources(Me.LabelX4, "LabelX4")
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        resources.ApplyResources(Me.TabItem2, "TabItem2")
        '
        'AdvTree2
        '
        resources.ApplyResources(Me.AdvTree2, "AdvTree2")
        Me.AdvTree2.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.AdvTree2.AllowDrop = True
        Me.AdvTree2.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.AdvTree2.BackgroundStyle.Class = "TreeBorderKey"
        Me.AdvTree2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AdvTree2.Name = "AdvTree2"
        Me.AdvTree2.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node3})
        Me.AdvTree2.NodesConnector = Me.NodeConnector3
        Me.AdvTree2.NodeStyle = Me.ElementStyle2
        Me.AdvTree2.PathSeparator = ";"
        Me.AdvTree2.Styles.Add(Me.ElementStyle2)
        '
        'Node3
        '
        Me.Node3.Expanded = True
        Me.Node3.Name = "Node3"
        resources.ApplyResources(Me.Node3, "Node3")
        '
        'NodeConnector3
        '
        Me.NodeConnector3.LineColor = System.Drawing.SystemColors.ControlText
        '
        'ElementStyle2
        '
        Me.ElementStyle2.Class = ""
        Me.ElementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle2.Name = "ElementStyle2"
        Me.ElementStyle2.TextColor = System.Drawing.SystemColors.ControlText
        '
        'lstEmp
        '
        resources.ApplyResources(Me.lstEmp, "lstEmp")
        '
        '
        '
        Me.lstEmp.Border.Class = "ListViewBorder"
        Me.lstEmp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lstEmp.CheckBoxes = True
        Me.lstEmp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNo, Me.colcode, Me.colname, Me.collastname})
        Me.lstEmp.FullRowSelect = True
        Me.lstEmp.GridLines = True
        Me.lstEmp.Name = "lstEmp"
        Me.lstEmp.UseCompatibleStateImageBehavior = False
        Me.lstEmp.View = System.Windows.Forms.View.Details
        '
        'colNo
        '
        resources.ApplyResources(Me.colNo, "colNo")
        '
        'colcode
        '
        resources.ApplyResources(Me.colcode, "colcode")
        '
        'colname
        '
        resources.ApplyResources(Me.colname, "colname")
        '
        'collastname
        '
        resources.ApplyResources(Me.collastname, "collastname")
        '
        'Bar3
        '
        resources.ApplyResources(Me.Bar3, "Bar3")
        Me.Bar3.AntiAlias = True
        Me.Bar3.Controls.Add(Me.btnPlusAll)
        Me.Bar3.Controls.Add(Me.BtnExpland)
        Me.Bar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ControlContainerItem1, Me.ControlContainerItem2})
        Me.Bar3.Name = "Bar3"
        Me.Bar3.Stretch = True
        Me.Bar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar3.TabStop = False
        '
        'btnPlusAll
        '
        resources.ApplyResources(Me.btnPlusAll, "btnPlusAll")
        Me.btnPlusAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPlusAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPlusAll.Image = Global.TimeAttendance.My.Resources.Resources.Alarm_Plus_1_
        Me.btnPlusAll.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btnPlusAll.Name = "btnPlusAll"
        Me.btnPlusAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'BtnExpland
        '
        resources.ApplyResources(Me.BtnExpland, "BtnExpland")
        Me.BtnExpland.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnExpland.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnExpland.Image = Global.TimeAttendance.My.Resources.Resources.Alarm_Minus
        Me.BtnExpland.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.BtnExpland.Name = "BtnExpland"
        Me.BtnExpland.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ControlContainerItem1
        '
        Me.ControlContainerItem1.AllowItemResize = False
        resources.ApplyResources(Me.ControlContainerItem1, "ControlContainerItem1")
        Me.ControlContainerItem1.Control = Me.btnPlusAll
        Me.ControlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem1.Name = "ControlContainerItem1"
        '
        'ControlContainerItem2
        '
        Me.ControlContainerItem2.AllowItemResize = False
        resources.ApplyResources(Me.ControlContainerItem2, "ControlContainerItem2")
        Me.ControlContainerItem2.Control = Me.BtnExpland
        Me.ControlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem2.Name = "ControlContainerItem2"
        '
        'btnNotAll
        '
        resources.ApplyResources(Me.btnNotAll, "btnNotAll")
        Me.btnNotAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNotAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNotAll.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnNotAll.Name = "btnNotAll"
        Me.btnNotAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'btnAll
        '
        resources.ApplyResources(Me.btnAll, "btnAll")
        Me.btnAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAll.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'btnexit
        '
        resources.ApplyResources(Me.btnexit, "btnexit")
        Me.btnexit.ImageOptions.Image = CType(resources.GetObject("btnexit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnexit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnexit.Name = "btnexit"
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
        'frmSetUserLogIn
        '
        resources.ApplyResources(Me, "$this")
        Me.Appearance.FontSizeDelta = CType(resources.GetObject("frmSetUserLogIn.Appearance.FontSizeDelta"), Integer)
        Me.Appearance.FontStyleDelta = CType(resources.GetObject("frmSetUserLogIn.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.Appearance.GradientMode = CType(resources.GetObject("frmSetUserLogIn.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.Appearance.Image = CType(resources.GetObject("frmSetUserLogIn.Appearance.Image"), System.Drawing.Image)
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlApp)
        Me.Controls.Add(Me.ProgressBarX1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.Bar3)
        Me.Controls.Add(Me.lstEmp)
        Me.Controls.Add(Me.AdvTree2)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Name = "frmSetUserLogIn"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.grpLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLeft.ResumeLayout(False)
        Me.grpLeft.PerformLayout()
        CType(Me.GcEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDivistionId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDepartMent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRight.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.cboPerGroupName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.Gcmenu_use, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gvmenu_use, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.grpEditMenubyOne, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEditMenubyOne.ResumeLayout(False)
        CType(Me.txtNameedit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodeEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMenu.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraScrollableControl1.ResumeLayout(False)
        CType(Me.mnuDailyUpdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuInputLeaveData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuManageTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuPermissionTimeAtt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuabsenceTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuOvertime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuLateTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraScrollableControl2.ResumeLayout(False)
        CType(Me.mnuEmp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuDivision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuWorkHolidaySpacial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuConfiguration.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuSetholiday.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuMConfig.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnucalculationAbs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuCompanyCenter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuSetCancelDelayOTByDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnumodelcalculations.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnusetdelayOT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuMWorkTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnusetdelaytime1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuMOpenCalculate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuOTbyDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuMVacationHolYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnusetOT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuMOtherCondition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuOTBasic.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuworkinggroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnulimitOT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuSpacialKa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuSetabsenceTimeByYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuDeterminedTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuOT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuDeterminedTimeEmp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnucalculationLate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuDeterminedTimeEmpByOne.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuSetLeave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuDeterminedTimeEmpByDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuProcessOT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage5.ResumeLayout(False)
        Me.XtraScrollableControl3.ResumeLayout(False)
        CType(Me.mnurptScheduleWorkAllEmp2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuReport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.munOvertimeLeage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnurptTimeWork.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnurptAllemployeework2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnurptemployeeByDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnurptEmpWorkDetail1_M.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage6.ResumeLayout(False)
        Me.XtraScrollableControl4.ResumeLayout(False)
        CType(Me.mnuPerUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuPermission.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuPerPattern.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuUserPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.AdvTree2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar3.ResumeLayout(False)
        Me.pnlApp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents AdvTree2 As DevComponents.AdvTree.AdvTree
    Friend WithEvents Node3 As DevComponents.AdvTree.Node
    Friend WithEvents NodeConnector3 As DevComponents.AdvTree.NodeConnector
    Friend WithEvents ElementStyle2 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents lstEmp As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents colNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colcode As System.Windows.Forms.ColumnHeader
    Friend WithEvents colname As System.Windows.Forms.ColumnHeader
    Friend WithEvents collastname As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAll As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNotAll As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PG As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents btnPlusAll As DevComponents.DotNetBar.ButtonX
    ' Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents BtnExpland As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ControlContainerItem1 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents ControlContainerItem2 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents lblName As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents lblEmpId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Bar3 As DevComponents.DotNetBar.Bar
    Friend WithEvents GcEmp As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvEmp As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colrow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode_lar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cboTransport_detail As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboUnitName As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnexit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnShowData As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbDivistionId As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbDepartMent As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblPerGroupName As Label
    Friend WithEvents Gcmenu_use As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gvmenu_use As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabMenu As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents mnuDailyUpdate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuInputLeaveData As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuManageTime As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuPermissionTimeAtt As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuabsenceTime As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuOvertime As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuLateTime As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraScrollableControl2 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents MenuWorkHolidaySpacial As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuConfiguration As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuSetholiday As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuMConfig As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnucalculationAbs As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuCompanyCenter As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuSetCancelDelayOTByDay As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnumodelcalculations As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnusetdelayOT As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuMWorkTime As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnusetdelaytime1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuMOpenCalculate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuOTbyDay As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuMVacationHolYear As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnusetOT As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuMOtherCondition As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuOTBasic As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuworkinggroup As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnulimitOT As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuSpacialKa As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuSetabsenceTimeByYear As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuDeterminedTime As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuOT As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuDeterminedTimeEmp As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnucalculationLate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuDeterminedTimeEmpByOne As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuSetLeave As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuDeterminedTimeEmpByDate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuProcessOT As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraScrollableControl3 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents mnurptScheduleWorkAllEmp2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuReport As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents munOvertimeLeage As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnurptTimeWork As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnurptAllemployeework2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnurptemployeeByDate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnurptEmpWorkDetail1_M As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraScrollableControl4 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents mnuPerUser As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuPermission As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuPerPattern As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuUserPass As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProgressBarX1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grpEditMenubyOne As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnEditMenu_byOne As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNameedit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodeEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlApp As Panel
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents grpLeft As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpRight As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mnuEmp As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuDepartment As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mnuDivision As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboPerGroupName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
