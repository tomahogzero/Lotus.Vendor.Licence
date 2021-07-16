<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTimework
    ' Inherits System.Windows.Forms.Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimework))
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.btnProcess = New DevExpress.XtraEditors.SimpleButton()
        Me.chkINOUT = New DevExpress.XtraEditors.CheckEdit()
        Me.grpCheckErr = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTimeNear = New DevExpress.XtraEditors.TextEdit()
        Me.btnChkTimeNear = New DevExpress.XtraEditors.SimpleButton()
        Me.btnChkErrTimeOdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnChkErrTimeOver = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.lblDeptId = New System.Windows.Forms.Label()
        Me.cboDepartment = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.grpMonth = New DevExpress.XtraEditors.GroupControl()
        Me.btnCurrentDate = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.btnAllMonth = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btnToDate = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDatest = New DevExpress.XtraEditors.DateEdit()
        Me.txtYear = New DevExpress.XtraEditors.TextEdit()
        Me.cboMonth = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtdatesp = New DevExpress.XtraEditors.DateEdit()
        Me.ProgressBar1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.rdDept = New System.Windows.Forms.RadioButton()
        Me.rdDate = New System.Windows.Forms.RadioButton()
        Me.rdCode = New System.Windows.Forms.RadioButton()
        Me.rdName = New System.Windows.Forms.RadioButton()
        Me.gcTimeWork = New DevExpress.XtraGrid.GridControl()
        Me.gvTimeWork = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.clNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clEmpName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clDeptCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clTime1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clTime2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clTime3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clTime4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.cboExport = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.pnlExport = New DevExpress.XtraEditors.PanelControl()
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.grpSearchBy = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNameSearch = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCode1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.cboDivision = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.grpLog = New DevExpress.XtraEditors.GroupControl()
        Me.lbLog = New DevExpress.XtraEditors.ListBoxControl()
        Me.lblProcessDate = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        CType(Me.chkINOUT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpCheckErr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCheckErr.SuspendLayout()
        CType(Me.txtTimeNear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMonth.SuspendLayout()
        CType(Me.txtDatest.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDatest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdatesp.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdatesp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gcTimeWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTimeWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboExport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlExport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlExport.SuspendLayout()
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.grpSearchBy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearchBy.SuspendLayout()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLog.SuspendLayout()
        CType(Me.lbLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        resources.ApplyResources(Me.btnRefresh, "btnRefresh")
        Me.btnRefresh.ImageOptions.Image = CType(resources.GetObject("btnRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnRefresh.Name = "btnRefresh"
        '
        'btnProcess
        '
        resources.ApplyResources(Me.btnProcess, "btnProcess")
        Me.btnProcess.ImageOptions.Image = CType(resources.GetObject("btnProcess.ImageOptions.Image"), System.Drawing.Image)
        Me.btnProcess.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnProcess.Name = "btnProcess"
        '
        'chkINOUT
        '
        resources.ApplyResources(Me.chkINOUT, "chkINOUT")
        Me.chkINOUT.Name = "chkINOUT"
        Me.chkINOUT.Properties.Caption = resources.GetString("chkINOUT.Properties.Caption")
        '
        'grpCheckErr
        '
        resources.ApplyResources(Me.grpCheckErr, "grpCheckErr")
        Me.grpCheckErr.Controls.Add(Me.LabelControl7)
        Me.grpCheckErr.Controls.Add(Me.txtTimeNear)
        Me.grpCheckErr.Controls.Add(Me.btnChkTimeNear)
        Me.grpCheckErr.Controls.Add(Me.btnChkErrTimeOdd)
        Me.grpCheckErr.Controls.Add(Me.chkINOUT)
        Me.grpCheckErr.Controls.Add(Me.btnChkErrTimeOver)
        Me.grpCheckErr.Name = "grpCheckErr"
        '
        'LabelControl7
        '
        resources.ApplyResources(Me.LabelControl7, "LabelControl7")
        Me.LabelControl7.Name = "LabelControl7"
        '
        'txtTimeNear
        '
        resources.ApplyResources(Me.txtTimeNear, "txtTimeNear")
        Me.txtTimeNear.Name = "txtTimeNear"
        Me.txtTimeNear.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTimeNear.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        '
        'btnChkTimeNear
        '
        resources.ApplyResources(Me.btnChkTimeNear, "btnChkTimeNear")
        Me.btnChkTimeNear.Appearance.Options.UseFont = True
        Me.btnChkTimeNear.Appearance.Options.UseTextOptions = True
        Me.btnChkTimeNear.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnChkTimeNear.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnChkTimeNear.Name = "btnChkTimeNear"
        '
        'btnChkErrTimeOdd
        '
        resources.ApplyResources(Me.btnChkErrTimeOdd, "btnChkErrTimeOdd")
        Me.btnChkErrTimeOdd.Appearance.Options.UseFont = True
        Me.btnChkErrTimeOdd.Appearance.Options.UseTextOptions = True
        Me.btnChkErrTimeOdd.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnChkErrTimeOdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnChkErrTimeOdd.Name = "btnChkErrTimeOdd"
        '
        'btnChkErrTimeOver
        '
        Me.btnChkErrTimeOver.Appearance.Options.UseFont = True
        Me.btnChkErrTimeOver.Appearance.Options.UseTextOptions = True
        Me.btnChkErrTimeOver.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnChkErrTimeOver.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnChkErrTimeOver, "btnChkErrTimeOver")
        Me.btnChkErrTimeOver.Name = "btnChkErrTimeOver"
        '
        'btnExit
        '
        Me.btnExit.ImageOptions.Image = CType(resources.GetObject("btnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.Name = "btnExit"
        '
        'lblDeptId
        '
        resources.ApplyResources(Me.lblDeptId, "lblDeptId")
        Me.lblDeptId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDeptId.Name = "lblDeptId"
        '
        'cboDepartment
        '
        resources.ApplyResources(Me.cboDepartment, "cboDepartment")
        Me.cboDepartment.EnterMoveNextControl = True
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboDepartment.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboDepartment.Properties.DropDownRows = 15
        Me.cboDepartment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'grpMonth
        '
        resources.ApplyResources(Me.grpMonth, "grpMonth")
        Me.grpMonth.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.grpMonth.Controls.Add(Me.btnCurrentDate)
        Me.grpMonth.Controls.Add(Me.LabelControl8)
        Me.grpMonth.Controls.Add(Me.btnAllMonth)
        Me.grpMonth.Controls.Add(Me.LabelControl3)
        Me.grpMonth.Controls.Add(Me.btnProcess)
        Me.grpMonth.Controls.Add(Me.btnToDate)
        Me.grpMonth.Controls.Add(Me.txtDatest)
        Me.grpMonth.Controls.Add(Me.txtYear)
        Me.grpMonth.Controls.Add(Me.cboMonth)
        Me.grpMonth.Controls.Add(Me.txtdatesp)
        Me.grpMonth.Name = "grpMonth"
        '
        'btnCurrentDate
        '
        resources.ApplyResources(Me.btnCurrentDate, "btnCurrentDate")
        Me.btnCurrentDate.Name = "btnCurrentDate"
        '
        'LabelControl8
        '
        resources.ApplyResources(Me.LabelControl8, "LabelControl8")
        Me.LabelControl8.Name = "LabelControl8"
        '
        'btnAllMonth
        '
        resources.ApplyResources(Me.btnAllMonth, "btnAllMonth")
        Me.btnAllMonth.Name = "btnAllMonth"
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        '
        'btnToDate
        '
        resources.ApplyResources(Me.btnToDate, "btnToDate")
        Me.btnToDate.Name = "btnToDate"
        '
        'txtDatest
        '
        resources.ApplyResources(Me.txtDatest, "txtDatest")
        Me.txtDatest.EnterMoveNextControl = True
        Me.txtDatest.Name = "txtDatest"
        Me.txtDatest.Properties.Appearance.Options.UseFont = True
        Me.txtDatest.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDatest.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDatest.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDatest.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDatest.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtDatest.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDatest.Properties.Mask.EditMask = resources.GetString("txtDatest.Properties.Mask.EditMask")
        Me.txtDatest.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDatest.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        '
        'txtYear
        '
        Me.txtYear.EnterMoveNextControl = True
        resources.ApplyResources(Me.txtYear, "txtYear")
        Me.txtYear.Name = "txtYear"
        '
        'cboMonth
        '
        Me.cboMonth.EnterMoveNextControl = True
        resources.ApplyResources(Me.cboMonth, "cboMonth")
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboMonth.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboMonth.Properties.DropDownRows = 15
        Me.cboMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'txtdatesp
        '
        resources.ApplyResources(Me.txtdatesp, "txtdatesp")
        Me.txtdatesp.EnterMoveNextControl = True
        Me.txtdatesp.Name = "txtdatesp"
        Me.txtdatesp.Properties.Appearance.Options.UseFont = True
        Me.txtdatesp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtdatesp.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtdatesp.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtdatesp.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtdatesp.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtdatesp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtdatesp.Properties.Mask.EditMask = resources.GetString("txtdatesp.Properties.Mask.EditMask")
        Me.txtdatesp.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtdatesp.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        '
        'GroupControl1
        '
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.rdDept)
        Me.GroupControl1.Controls.Add(Me.rdDate)
        Me.GroupControl1.Controls.Add(Me.rdCode)
        Me.GroupControl1.Controls.Add(Me.rdName)
        Me.GroupControl1.Name = "GroupControl1"
        '
        'rdDept
        '
        resources.ApplyResources(Me.rdDept, "rdDept")
        Me.rdDept.Name = "rdDept"
        Me.rdDept.UseVisualStyleBackColor = True
        '
        'rdDate
        '
        Me.rdDate.Checked = True
        resources.ApplyResources(Me.rdDate, "rdDate")
        Me.rdDate.Name = "rdDate"
        Me.rdDate.TabStop = True
        Me.rdDate.UseVisualStyleBackColor = True
        '
        'rdCode
        '
        resources.ApplyResources(Me.rdCode, "rdCode")
        Me.rdCode.Name = "rdCode"
        Me.rdCode.UseVisualStyleBackColor = True
        '
        'rdName
        '
        resources.ApplyResources(Me.rdName, "rdName")
        Me.rdName.Name = "rdName"
        Me.rdName.UseVisualStyleBackColor = True
        '
        'gcTimeWork
        '
        resources.ApplyResources(Me.gcTimeWork, "gcTimeWork")
        Me.gcTimeWork.MainView = Me.gvTimeWork
        Me.gcTimeWork.Name = "gcTimeWork"
        Me.gcTimeWork.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTimeWork})
        '
        'gvTimeWork
        '
        Me.gvTimeWork.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clNo, Me.clDate, Me.colEmpCode, Me.clEmpName, Me.clDeptCode, Me.clTime1, Me.clTime2, Me.clTime3, Me.clTime4, Me.GridColumn1, Me.GridColumn2})
        Me.gvTimeWork.GridControl = Me.gcTimeWork
        Me.gvTimeWork.Name = "gvTimeWork"
        Me.gvTimeWork.OptionsView.ColumnAutoWidth = False
        Me.gvTimeWork.OptionsView.ShowAutoFilterRow = True
        Me.gvTimeWork.OptionsView.ShowGroupPanel = False
        '
        'clNo
        '
        Me.clNo.AppearanceCell.Options.UseTextOptions = True
        Me.clNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
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
        Me.clDeptCode.FieldName = "Department"
        Me.clDeptCode.Name = "clDeptCode"
        Me.clDeptCode.OptionsColumn.AllowEdit = False
        Me.clDeptCode.OptionsColumn.ReadOnly = True
        '
        'clTime1
        '
        Me.clTime1.AppearanceCell.Options.UseTextOptions = True
        Me.clTime1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clTime1.AppearanceHeader.Options.UseTextOptions = True
        Me.clTime1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.clTime1, "clTime1")
        Me.clTime1.DisplayFormat.FormatString = "HH:mm"
        Me.clTime1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.clTime1.FieldName = "Time1"
        Me.clTime1.Name = "clTime1"
        Me.clTime1.OptionsColumn.AllowEdit = False
        Me.clTime1.OptionsColumn.ReadOnly = True
        '
        'clTime2
        '
        Me.clTime2.AppearanceCell.Options.UseTextOptions = True
        Me.clTime2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clTime2.AppearanceHeader.Options.UseTextOptions = True
        Me.clTime2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.clTime2, "clTime2")
        Me.clTime2.DisplayFormat.FormatString = "HH:mm"
        Me.clTime2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.clTime2.FieldName = "Time2"
        Me.clTime2.Name = "clTime2"
        Me.clTime2.OptionsColumn.AllowEdit = False
        Me.clTime2.OptionsColumn.ReadOnly = True
        '
        'clTime3
        '
        Me.clTime3.AppearanceCell.Options.UseTextOptions = True
        Me.clTime3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clTime3.AppearanceHeader.Options.UseTextOptions = True
        Me.clTime3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.clTime3, "clTime3")
        Me.clTime3.DisplayFormat.FormatString = "HH:mm"
        Me.clTime3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.clTime3.FieldName = "Time3"
        Me.clTime3.Name = "clTime3"
        Me.clTime3.OptionsColumn.AllowEdit = False
        Me.clTime3.OptionsColumn.ReadOnly = True
        '
        'clTime4
        '
        Me.clTime4.AppearanceCell.Options.UseTextOptions = True
        Me.clTime4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clTime4.AppearanceHeader.Options.UseTextOptions = True
        Me.clTime4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.clTime4, "clTime4")
        Me.clTime4.DisplayFormat.FormatString = "HH:mm"
        Me.clTime4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.clTime4.FieldName = "Time4"
        Me.clTime4.Name = "clTime4"
        Me.clTime4.OptionsColumn.AllowEdit = False
        Me.clTime4.OptionsColumn.ReadOnly = True
        '
        'GridColumn1
        '
        resources.ApplyResources(Me.GridColumn1, "GridColumn1")
        Me.GridColumn1.FieldName = "Position"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        '
        'GridColumn2
        '
        resources.ApplyResources(Me.GridColumn2, "GridColumn2")
        Me.GridColumn2.FieldName = "Division"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
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
        'LabelControl4
        '
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Appearance.Font = CType(resources.GetObject("LabelControl4.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Name = "LabelControl4"
        '
        'pnlExport
        '
        Me.pnlExport.Controls.Add(Me.LabelControl1)
        Me.pnlExport.Controls.Add(Me.cboExport)
        Me.pnlExport.Controls.Add(Me.btnExport)
        Me.pnlExport.Controls.Add(Me.LabelControl4)
        resources.ApplyResources(Me.pnlExport, "pnlExport")
        Me.pnlExport.Name = "pnlExport"
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
        Me.DockPanel2.FloatLocation = New System.Drawing.Point(802, 298)
        Me.DockPanel2.FloatSize = New System.Drawing.Size(470, 351)
        Me.DockPanel2.ID = New System.Guid("3a7fe2e2-8b77-4cd9-b734-cebea9d7abb3")
        resources.ApplyResources(Me.DockPanel2, "DockPanel2")
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel2.SavedIndex = 1
        Me.DockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'DockPanel2_Container
        '
        resources.ApplyResources(Me.DockPanel2_Container, "DockPanel2_Container")
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        '
        'DockPanel1
        '
        resources.ApplyResources(Me.DockPanel1, "DockPanel1")
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("775293ef-078d-4bd2-8c78-ff5d83e4a0c2")
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.AllowFloating = False
        Me.DockPanel1.Options.FloatOnDblClick = False
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(393, 200)
        Me.DockPanel1.TabsPosition = DevExpress.XtraBars.Docking.TabsPosition.Left
        Me.DockPanel1.TabsScroll = True
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.grpSearchBy)
        Me.DockPanel1_Container.Controls.Add(Me.btnExit)
        Me.DockPanel1_Container.Controls.Add(Me.grpMonth)
        Me.DockPanel1_Container.Controls.Add(Me.grpCheckErr)
        resources.ApplyResources(Me.DockPanel1_Container, "DockPanel1_Container")
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        '
        'grpSearchBy
        '
        resources.ApplyResources(Me.grpSearchBy, "grpSearchBy")
        Me.grpSearchBy.Controls.Add(Me.LabelControl11)
        Me.grpSearchBy.Controls.Add(Me.txtName)
        Me.grpSearchBy.Controls.Add(Me.LabelControl10)
        Me.grpSearchBy.Controls.Add(Me.txtNameSearch)
        Me.grpSearchBy.Controls.Add(Me.LabelControl9)
        Me.grpSearchBy.Controls.Add(Me.txtCode1)
        Me.grpSearchBy.Controls.Add(Me.LabelControl6)
        Me.grpSearchBy.Controls.Add(Me.cboDivision)
        Me.grpSearchBy.Controls.Add(Me.cboDepartment)
        Me.grpSearchBy.Controls.Add(Me.btnRefresh)
        Me.grpSearchBy.Controls.Add(Me.lblDeptId)
        Me.grpSearchBy.Controls.Add(Me.GroupControl1)
        Me.grpSearchBy.Name = "grpSearchBy"
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
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Options.UseTextOptions = True
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        resources.ApplyResources(Me.LabelControl9, "LabelControl9")
        Me.LabelControl9.Name = "LabelControl9"
        '
        'txtCode1
        '
        Me.txtCode1.EnterMoveNextControl = True
        resources.ApplyResources(Me.txtCode1, "txtCode1")
        Me.txtCode1.Name = "txtCode1"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Options.UseTextOptions = True
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        resources.ApplyResources(Me.LabelControl6, "LabelControl6")
        Me.LabelControl6.Name = "LabelControl6"
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
        'grpLog
        '
        resources.ApplyResources(Me.grpLog, "grpLog")
        Me.grpLog.Controls.Add(Me.ProgressBar1)
        Me.grpLog.Controls.Add(Me.lbLog)
        Me.grpLog.Controls.Add(Me.lblProcessDate)
        Me.grpLog.Controls.Add(Me.LabelControl5)
        Me.grpLog.Name = "grpLog"
        '
        'lbLog
        '
        resources.ApplyResources(Me.lbLog, "lbLog")
        Me.lbLog.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbLog.Name = "lbLog"
        '
        'lblProcessDate
        '
        resources.ApplyResources(Me.lblProcessDate, "lblProcessDate")
        Me.lblProcessDate.Name = "lblProcessDate"
        '
        'LabelControl5
        '
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Name = "LabelControl5"
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 592)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(1193, 25)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(50, 20)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.HiddenPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel2})
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 125)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Nothing
        Me.TabbedControlGroup1.SelectedTabPageIndex = -1
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(905, 179)
        '
        'frmTimework
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpLog)
        Me.Controls.Add(Me.gcTimeWork)
        Me.Controls.Add(Me.pnlExport)
        Me.Controls.Add(Me.DockPanel1)
        Me.KeyPreview = True
        Me.Name = "frmTimework"
        Me.ShowIcon = False
        Me.Tag = "MN01006"
        CType(Me.chkINOUT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpCheckErr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCheckErr.ResumeLayout(False)
        Me.grpCheckErr.PerformLayout()
        CType(Me.txtTimeNear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpMonth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMonth.ResumeLayout(False)
        Me.grpMonth.PerformLayout()
        CType(Me.txtDatest.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDatest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdatesp.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdatesp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.gcTimeWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTimeWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboExport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlExport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlExport.ResumeLayout(False)
        Me.pnlExport.PerformLayout()
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.grpSearchBy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearchBy.ResumeLayout(False)
        Me.grpSearchBy.PerformLayout()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLog.ResumeLayout(False)
        Me.grpLog.PerformLayout()
        CType(Me.lbLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rdDate As System.Windows.Forms.RadioButton
    Friend WithEvents rdDept As System.Windows.Forms.RadioButton
    Friend WithEvents rdName As System.Windows.Forms.RadioButton
    Friend WithEvents rdCode As System.Windows.Forms.RadioButton
    Friend WithEvents lblDeptId As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents gcTimeWork As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTimeWork As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clEmpName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clDeptCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clTime1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clTime2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clTime3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clTime4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboExport As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colEmpCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtYear As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboMonth As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpMonth As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboDepartment As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents chkINOUT As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnProcess As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpCheckErr As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTimeNear As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnChkTimeNear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnChkErrTimeOver As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnChkErrTimeOdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtdatesp As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDatest As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnToDate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCurrentDate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAllMonth As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlExport As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents ProgressBar1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpSearchBy As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboDivision As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCode1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grpLog As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbLog As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents lblProcessDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
End Class
