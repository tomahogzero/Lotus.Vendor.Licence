<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLate
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLate))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuVacation = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblDeptId = New System.Windows.Forms.Label()
        Me.rdName = New System.Windows.Forms.RadioButton()
        Me.rdCode = New System.Windows.Forms.RadioButton()
        Me.rdDate = New System.Windows.Forms.RadioButton()
        Me.rdDept = New System.Windows.Forms.RadioButton()
        Me.gcOvertime = New DevExpress.XtraGrid.GridControl()
        Me.gvOvertime = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.clNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clEmpName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clDeptCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clTime1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clTime3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clTime4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClearData = New DevExpress.XtraEditors.SimpleButton()
        Me.btnProcess = New DevExpress.XtraEditors.SimpleButton()
        Me.chkLateOnly = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnCurrentDate = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAllMonth = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTodate = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtYear = New DevExpress.XtraEditors.TextEdit()
        Me.cboMonth = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDateSp = New DevExpress.XtraEditors.DateEdit()
        Me.txtDateSt = New DevExpress.XtraEditors.DateEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNameSearch = New DevExpress.XtraEditors.TextEdit()
        Me.txtCode1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cboDivision = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboDepartment = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.ProgressBar1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.ProgressBar2 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.cboExport = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.gcOvertime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvOvertime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkLateOnly.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateSp.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateSp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateSt.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateSt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.cboExport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuVacation})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        '
        'mnuVacation
        '
        Me.mnuVacation.Name = "mnuVacation"
        resources.ApplyResources(Me.mnuVacation, "mnuVacation")
        '
        'lblDeptId
        '
        resources.ApplyResources(Me.lblDeptId, "lblDeptId")
        Me.lblDeptId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDeptId.Name = "lblDeptId"
        '
        'rdName
        '
        resources.ApplyResources(Me.rdName, "rdName")
        Me.rdName.Name = "rdName"
        Me.rdName.UseVisualStyleBackColor = True
        '
        'rdCode
        '
        resources.ApplyResources(Me.rdCode, "rdCode")
        Me.rdCode.Name = "rdCode"
        Me.rdCode.UseVisualStyleBackColor = True
        '
        'rdDate
        '
        resources.ApplyResources(Me.rdDate, "rdDate")
        Me.rdDate.Checked = True
        Me.rdDate.Name = "rdDate"
        Me.rdDate.TabStop = True
        Me.rdDate.UseVisualStyleBackColor = True
        '
        'rdDept
        '
        resources.ApplyResources(Me.rdDept, "rdDept")
        Me.rdDept.Name = "rdDept"
        Me.rdDept.UseVisualStyleBackColor = True
        '
        'gcOvertime
        '
        resources.ApplyResources(Me.gcOvertime, "gcOvertime")
        Me.gcOvertime.MainView = Me.gvOvertime
        Me.gcOvertime.Name = "gcOvertime"
        Me.gcOvertime.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvOvertime})
        '
        'gvOvertime
        '
        Me.gvOvertime.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clNo, Me.clDate, Me.colEmpCode, Me.clEmpName, Me.clDeptCode, Me.clTime1, Me.clTime3, Me.clTime4})
        Me.gvOvertime.GridControl = Me.gcOvertime
        Me.gvOvertime.Name = "gvOvertime"
        Me.gvOvertime.OptionsView.ColumnAutoWidth = False
        Me.gvOvertime.OptionsView.ShowAutoFilterRow = True
        Me.gvOvertime.OptionsView.ShowGroupPanel = False
        '
        'clNo
        '
        Me.clNo.AppearanceCell.Options.UseTextOptions = True
        Me.clNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clNo.AppearanceHeader.Options.UseTextOptions = True
        Me.clNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.clNo, "clNo")
        Me.clNo.FieldName = "row"
        Me.clNo.Name = "clNo"
        Me.clNo.OptionsColumn.AllowEdit = False
        Me.clNo.OptionsColumn.ReadOnly = True
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
        Me.clDate.GroupFormat.FormatString = "dd/MM/yyyy"
        Me.clDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.clDate.Name = "clDate"
        Me.clDate.OptionsColumn.AllowEdit = False
        Me.clDate.OptionsColumn.ReadOnly = True
        '
        'colEmpCode
        '
        Me.colEmpCode.AppearanceCell.Options.UseTextOptions = True
        Me.colEmpCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmpCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colEmpCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colEmpCode, "colEmpCode")
        Me.colEmpCode.FieldName = "Code"
        Me.colEmpCode.Name = "colEmpCode"
        Me.colEmpCode.OptionsColumn.AllowEdit = False
        Me.colEmpCode.OptionsColumn.ReadOnly = True
        '
        'clEmpName
        '
        resources.ApplyResources(Me.clEmpName, "clEmpName")
        Me.clEmpName.FieldName = "EmpName"
        Me.clEmpName.Name = "clEmpName"
        Me.clEmpName.OptionsColumn.AllowEdit = False
        Me.clEmpName.OptionsColumn.ReadOnly = True
        '
        'clDeptCode
        '
        Me.clDeptCode.AppearanceHeader.Options.UseTextOptions = True
        Me.clDeptCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.clDeptCode, "clDeptCode")
        Me.clDeptCode.FieldName = "department"
        Me.clDeptCode.Name = "clDeptCode"
        Me.clDeptCode.OptionsColumn.AllowEdit = False
        Me.clDeptCode.OptionsColumn.ReadOnly = True
        '
        'clTime1
        '
        Me.clTime1.AppearanceCell.Options.UseTextOptions = True
        Me.clTime1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clTime1.AppearanceHeader.Options.UseTextOptions = True
        Me.clTime1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        resources.ApplyResources(Me.clTime1, "clTime1")
        Me.clTime1.FieldName = "Late_str"
        Me.clTime1.Name = "clTime1"
        Me.clTime1.OptionsColumn.AllowEdit = False
        Me.clTime1.OptionsColumn.ReadOnly = True
        '
        'clTime3
        '
        Me.clTime3.AppearanceCell.Options.UseTextOptions = True
        Me.clTime3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clTime3.AppearanceHeader.Options.UseTextOptions = True
        Me.clTime3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        resources.ApplyResources(Me.clTime3, "clTime3")
        Me.clTime3.FieldName = "LateOut_str"
        Me.clTime3.Name = "clTime3"
        Me.clTime3.OptionsColumn.AllowEdit = False
        '
        'clTime4
        '
        Me.clTime4.AppearanceCell.Options.UseTextOptions = True
        Me.clTime4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clTime4.AppearanceHeader.Options.UseTextOptions = True
        Me.clTime4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        resources.ApplyResources(Me.clTime4, "clTime4")
        Me.clTime4.FieldName = "TotalLate_str"
        Me.clTime4.Name = "clTime4"
        Me.clTime4.OptionsColumn.AllowEdit = False
        Me.clTime4.OptionsColumn.ReadOnly = True
        '
        'btnExit
        '
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.ImageOptions.Image = CType(resources.GetObject("btnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnExit.Name = "btnExit"
        '
        'btnRefresh
        '
        resources.ApplyResources(Me.btnRefresh, "btnRefresh")
        Me.btnRefresh.ImageOptions.Image = CType(resources.GetObject("btnRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnRefresh.Name = "btnRefresh"
        '
        'btnClearData
        '
        Me.btnClearData.ImageOptions.Image = CType(resources.GetObject("btnClearData.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClearData.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnClearData, "btnClearData")
        Me.btnClearData.Name = "btnClearData"
        '
        'btnProcess
        '
        Me.btnProcess.ImageOptions.Image = CType(resources.GetObject("btnProcess.ImageOptions.Image"), System.Drawing.Image)
        Me.btnProcess.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnProcess, "btnProcess")
        Me.btnProcess.Name = "btnProcess"
        '
        'chkLateOnly
        '
        resources.ApplyResources(Me.chkLateOnly, "chkLateOnly")
        Me.chkLateOnly.Name = "chkLateOnly"
        Me.chkLateOnly.Properties.Caption = resources.GetString("chkLateOnly.Properties.Caption")
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnCurrentDate)
        Me.GroupControl1.Controls.Add(Me.btnAllMonth)
        Me.GroupControl1.Controls.Add(Me.btnTodate)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtYear)
        Me.GroupControl1.Controls.Add(Me.cboMonth)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtDateSp)
        Me.GroupControl1.Controls.Add(Me.txtDateSt)
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Name = "GroupControl1"
        '
        'btnCurrentDate
        '
        resources.ApplyResources(Me.btnCurrentDate, "btnCurrentDate")
        Me.btnCurrentDate.Name = "btnCurrentDate"
        '
        'btnAllMonth
        '
        resources.ApplyResources(Me.btnAllMonth, "btnAllMonth")
        Me.btnAllMonth.Name = "btnAllMonth"
        '
        'btnTodate
        '
        resources.ApplyResources(Me.btnTodate, "btnTodate")
        Me.btnTodate.Name = "btnTodate"
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        '
        'txtYear
        '
        resources.ApplyResources(Me.txtYear, "txtYear")
        Me.txtYear.Name = "txtYear"
        '
        'cboMonth
        '
        resources.ApplyResources(Me.cboMonth, "cboMonth")
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboMonth.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboMonth.Properties.DropDownRows = 15
        Me.cboMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        '
        'txtDateSp
        '
        resources.ApplyResources(Me.txtDateSp, "txtDateSp")
        Me.txtDateSp.EnterMoveNextControl = True
        Me.txtDateSp.Name = "txtDateSp"
        Me.txtDateSp.Properties.Appearance.Options.UseFont = True
        Me.txtDateSp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateSp.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateSp.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateSp.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateSp.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtDateSp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDateSp.Properties.Mask.EditMask = resources.GetString("txtDateSp.Properties.Mask.EditMask")
        Me.txtDateSp.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDateSp.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        '
        'txtDateSt
        '
        resources.ApplyResources(Me.txtDateSt, "txtDateSt")
        Me.txtDateSt.EnterMoveNextControl = True
        Me.txtDateSt.Name = "txtDateSt"
        Me.txtDateSt.Properties.Appearance.Options.UseFont = True
        Me.txtDateSt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateSt.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateSt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateSt.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtDateSt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDateSt.Properties.Mask.EditMask = resources.GetString("txtDateSt.Properties.Mask.EditMask")
        Me.txtDateSt.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDateSt.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        '
        'GroupControl3
        '
        resources.ApplyResources(Me.GroupControl3, "GroupControl3")
        Me.GroupControl3.Controls.Add(Me.rdDept)
        Me.GroupControl3.Controls.Add(Me.rdDate)
        Me.GroupControl3.Controls.Add(Me.rdName)
        Me.GroupControl3.Controls.Add(Me.rdCode)
        Me.GroupControl3.Name = "GroupControl3"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.LabelControl11)
        Me.GroupControl2.Controls.Add(Me.btnExit)
        Me.GroupControl2.Controls.Add(Me.txtName)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Controls.Add(Me.GroupControl3)
        Me.GroupControl2.Controls.Add(Me.btnRefresh)
        Me.GroupControl2.Controls.Add(Me.txtNameSearch)
        Me.GroupControl2.Controls.Add(Me.txtCode1)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.cboDivision)
        Me.GroupControl2.Controls.Add(Me.lblDeptId)
        Me.GroupControl2.Controls.Add(Me.cboDepartment)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        resources.ApplyResources(Me.GroupControl2, "GroupControl2")
        Me.GroupControl2.Name = "GroupControl2"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Options.UseTextOptions = True
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        resources.ApplyResources(Me.LabelControl11, "LabelControl11")
        Me.LabelControl11.Name = "LabelControl11"
        '
        'txtName
        '
        resources.ApplyResources(Me.txtName, "txtName")
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.ReadOnly = True
        Me.txtName.TabStop = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Options.UseTextOptions = True
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        resources.ApplyResources(Me.LabelControl10, "LabelControl10")
        Me.LabelControl10.Name = "LabelControl10"
        '
        'txtNameSearch
        '
        resources.ApplyResources(Me.txtNameSearch, "txtNameSearch")
        Me.txtNameSearch.EnterMoveNextControl = True
        Me.txtNameSearch.Name = "txtNameSearch"
        '
        'txtCode1
        '
        Me.txtCode1.EnterMoveNextControl = True
        resources.ApplyResources(Me.txtCode1, "txtCode1")
        Me.txtCode1.Name = "txtCode1"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Name = "LabelControl4"
        '
        'cboDivision
        '
        resources.ApplyResources(Me.cboDivision, "cboDivision")
        Me.cboDivision.EnterMoveNextControl = True
        Me.cboDivision.Name = "cboDivision"
        Me.cboDivision.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboDivision.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboDivision.Properties.DropDownRows = 15
        Me.cboDivision.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'cboDepartment
        '
        resources.ApplyResources(Me.cboDepartment, "cboDepartment")
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboDepartment.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboDepartment.Properties.DropDownRows = 15
        Me.cboDepartment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Name = "LabelControl5"
        '
        'GroupControl4
        '
        resources.ApplyResources(Me.GroupControl4, "GroupControl4")
        Me.GroupControl4.Controls.Add(Me.LabelControl3)
        Me.GroupControl4.Controls.Add(Me.ProgressBar1)
        Me.GroupControl4.Controls.Add(Me.ProgressBar2)
        Me.GroupControl4.Name = "GroupControl4"
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        '
        'ProgressBar1
        '
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        '
        '
        '
        Me.ProgressBar1.BackgroundStyle.Class = ""
        Me.ProgressBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.TextVisible = True
        '
        'ProgressBar2
        '
        resources.ApplyResources(Me.ProgressBar2, "ProgressBar2")
        '
        '
        '
        Me.ProgressBar2.BackgroundStyle.Class = ""
        Me.ProgressBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.TextVisible = True
        '
        'LabelControl6
        '
        resources.ApplyResources(Me.LabelControl6, "LabelControl6")
        Me.LabelControl6.Name = "LabelControl6"
        '
        'btnExport
        '
        resources.ApplyResources(Me.btnExport, "btnExport")
        Me.btnExport.Name = "btnExport"
        '
        'cboExport
        '
        resources.ApplyResources(Me.cboExport, "cboExport")
        Me.cboExport.Name = "cboExport"
        Me.cboExport.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboExport.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboExport.Properties.Items.AddRange(New Object() {resources.GetString("cboExport.Properties.Items"), resources.GetString("cboExport.Properties.Items1")})
        Me.cboExport.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("f26bc9b7-bbf7-4880-83a7-ac9ca459cb0b")
        resources.ApplyResources(Me.DockPanel1, "DockPanel1")
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.AllowFloating = False
        Me.DockPanel1.Options.FloatOnDblClick = False
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(388, 200)
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.btnProcess)
        Me.DockPanel1_Container.Controls.Add(Me.chkLateOnly)
        Me.DockPanel1_Container.Controls.Add(Me.btnClearData)
        Me.DockPanel1_Container.Controls.Add(Me.GroupControl2)
        Me.DockPanel1_Container.Controls.Add(Me.GroupControl1)
        resources.ApplyResources(Me.DockPanel1_Container, "DockPanel1_Container")
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.btnExport)
        Me.PanelControl1.Controls.Add(Me.cboExport)
        resources.ApplyResources(Me.PanelControl1, "PanelControl1")
        Me.PanelControl1.Name = "PanelControl1"
        '
        'LabelControl7
        '
        resources.ApplyResources(Me.LabelControl7, "LabelControl7")
        Me.LabelControl7.Appearance.Font = CType(resources.GetObject("LabelControl7.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseTextOptions = True
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.Name = "LabelControl7"
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'frmLate
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gcOvertime)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmLate"
        Me.Tag = "MN01009"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.gcOvertime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvOvertime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkLateOnly.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateSp.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateSp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateSt.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateSt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.cboExport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblDeptId As System.Windows.Forms.Label
    Friend WithEvents rdName As System.Windows.Forms.RadioButton
    Friend WithEvents rdCode As System.Windows.Forms.RadioButton
    Friend WithEvents rdDate As System.Windows.Forms.RadioButton
    Friend WithEvents rdDept As System.Windows.Forms.RadioButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuVacation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gcOvertime As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvOvertime As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clEmpName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clDeptCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clTime1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clTime3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clTime4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClearData As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnProcess As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkLateOnly As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnTodate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtYear As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboMonth As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDateSp As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDateSt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboDepartment As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ProgressBar1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents ProgressBar2 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboExport As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnCurrentDate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAllMonth As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCode1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboDivision As DevExpress.XtraEditors.ComboBoxEdit
End Class
