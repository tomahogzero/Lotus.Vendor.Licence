<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOvertime
    'Inherits System.Windows.Forms.Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOvertime))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblDeptId = New System.Windows.Forms.Label()
        Me.rdName = New System.Windows.Forms.RadioButton()
        Me.rdCode = New System.Windows.Forms.RadioButton()
        Me.rdDate = New System.Windows.Forms.RadioButton()
        Me.rdDept = New System.Windows.Forms.RadioButton()
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
        Me.clTime5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clTime6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clTime7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clTime8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clTime9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clTime10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDateSt = New DevExpress.XtraEditors.DateEdit()
        Me.cboMonth = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnCurrentDate = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAllMonth = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTodate = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtYear = New DevExpress.XtraEditors.TextEdit()
        Me.txtDatesp = New DevExpress.XtraEditors.DateEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNameSearch = New DevExpress.XtraEditors.TextEdit()
        Me.txtCode1 = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.cboDivision = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboDepartment = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClearData = New DevExpress.XtraEditors.SimpleButton()
        Me.btnProcess = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.cboExport = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.pnlExport = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        CType(Me.gcTimeWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTimeWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateSt.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateSt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDatesp.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDatesp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboExport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.pnlExport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlExport.SuspendLayout()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDeptId
        '
        resources.ApplyResources(Me.lblDeptId, "lblDeptId")
        Me.lblDeptId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDeptId.Name = "lblDeptId"
        Me.ToolTip1.SetToolTip(Me.lblDeptId, resources.GetString("lblDeptId.ToolTip"))
        '
        'rdName
        '
        resources.ApplyResources(Me.rdName, "rdName")
        Me.rdName.Name = "rdName"
        Me.ToolTip1.SetToolTip(Me.rdName, resources.GetString("rdName.ToolTip"))
        Me.rdName.UseVisualStyleBackColor = True
        '
        'rdCode
        '
        resources.ApplyResources(Me.rdCode, "rdCode")
        Me.rdCode.Name = "rdCode"
        Me.ToolTip1.SetToolTip(Me.rdCode, resources.GetString("rdCode.ToolTip"))
        Me.rdCode.UseVisualStyleBackColor = True
        '
        'rdDate
        '
        resources.ApplyResources(Me.rdDate, "rdDate")
        Me.rdDate.Checked = True
        Me.rdDate.Name = "rdDate"
        Me.rdDate.TabStop = True
        Me.ToolTip1.SetToolTip(Me.rdDate, resources.GetString("rdDate.ToolTip"))
        Me.rdDate.UseVisualStyleBackColor = True
        '
        'rdDept
        '
        resources.ApplyResources(Me.rdDept, "rdDept")
        Me.rdDept.Name = "rdDept"
        Me.ToolTip1.SetToolTip(Me.rdDept, resources.GetString("rdDept.ToolTip"))
        Me.rdDept.UseVisualStyleBackColor = True
        '
        'gcTimeWork
        '
        resources.ApplyResources(Me.gcTimeWork, "gcTimeWork")
        Me.gcTimeWork.EmbeddedNavigator.AccessibleDescription = resources.GetString("gcTimeWork.EmbeddedNavigator.AccessibleDescription")
        Me.gcTimeWork.EmbeddedNavigator.AccessibleName = resources.GetString("gcTimeWork.EmbeddedNavigator.AccessibleName")
        Me.gcTimeWork.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("gcTimeWork.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.gcTimeWork.EmbeddedNavigator.Anchor = CType(resources.GetObject("gcTimeWork.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.gcTimeWork.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("gcTimeWork.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.gcTimeWork.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("gcTimeWork.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.gcTimeWork.EmbeddedNavigator.ImeMode = CType(resources.GetObject("gcTimeWork.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.gcTimeWork.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("gcTimeWork.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.gcTimeWork.EmbeddedNavigator.TextLocation = CType(resources.GetObject("gcTimeWork.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.gcTimeWork.EmbeddedNavigator.ToolTip = resources.GetString("gcTimeWork.EmbeddedNavigator.ToolTip")
        Me.gcTimeWork.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("gcTimeWork.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.gcTimeWork.EmbeddedNavigator.ToolTipTitle = resources.GetString("gcTimeWork.EmbeddedNavigator.ToolTipTitle")
        Me.gcTimeWork.MainView = Me.gvTimeWork
        Me.gcTimeWork.Name = "gcTimeWork"
        Me.ToolTip1.SetToolTip(Me.gcTimeWork, resources.GetString("gcTimeWork.ToolTip"))
        Me.gcTimeWork.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTimeWork})
        '
        'gvTimeWork
        '
        resources.ApplyResources(Me.gvTimeWork, "gvTimeWork")
        Me.gvTimeWork.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clNo, Me.clDate, Me.colEmpCode, Me.clEmpName, Me.clDeptCode, Me.clTime1, Me.clTime2, Me.clTime3, Me.clTime4, Me.clTime5, Me.clTime6, Me.clTime7, Me.clTime8, Me.clTime9, Me.clTime10})
        Me.gvTimeWork.GridControl = Me.gcTimeWork
        Me.gvTimeWork.Name = "gvTimeWork"
        Me.gvTimeWork.OptionsView.ColumnAutoWidth = False
        Me.gvTimeWork.OptionsView.ShowAutoFilterRow = True
        Me.gvTimeWork.OptionsView.ShowGroupPanel = False
        '
        'clNo
        '
        Me.clNo.AppearanceCell.FontSizeDelta = CType(resources.GetObject("clNo.AppearanceCell.FontSizeDelta"), Integer)
        Me.clNo.AppearanceCell.FontStyleDelta = CType(resources.GetObject("clNo.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clNo.AppearanceCell.GradientMode = CType(resources.GetObject("clNo.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clNo.AppearanceCell.Image = CType(resources.GetObject("clNo.AppearanceCell.Image"), System.Drawing.Image)
        Me.clNo.AppearanceCell.Options.UseTextOptions = True
        Me.clNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clNo.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("clNo.AppearanceHeader.FontSizeDelta"), Integer)
        Me.clNo.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("clNo.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clNo.AppearanceHeader.GradientMode = CType(resources.GetObject("clNo.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clNo.AppearanceHeader.Image = CType(resources.GetObject("clNo.AppearanceHeader.Image"), System.Drawing.Image)
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
        Me.clDate.AppearanceCell.FontSizeDelta = CType(resources.GetObject("clDate.AppearanceCell.FontSizeDelta"), Integer)
        Me.clDate.AppearanceCell.FontStyleDelta = CType(resources.GetObject("clDate.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clDate.AppearanceCell.GradientMode = CType(resources.GetObject("clDate.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clDate.AppearanceCell.Image = CType(resources.GetObject("clDate.AppearanceCell.Image"), System.Drawing.Image)
        Me.clDate.AppearanceCell.Options.UseTextOptions = True
        Me.clDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clDate.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("clDate.AppearanceHeader.FontSizeDelta"), Integer)
        Me.clDate.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("clDate.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clDate.AppearanceHeader.GradientMode = CType(resources.GetObject("clDate.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clDate.AppearanceHeader.Image = CType(resources.GetObject("clDate.AppearanceHeader.Image"), System.Drawing.Image)
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
        Me.colEmpCode.AppearanceCell.FontSizeDelta = CType(resources.GetObject("colEmpCode.AppearanceCell.FontSizeDelta"), Integer)
        Me.colEmpCode.AppearanceCell.FontStyleDelta = CType(resources.GetObject("colEmpCode.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.colEmpCode.AppearanceCell.GradientMode = CType(resources.GetObject("colEmpCode.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.colEmpCode.AppearanceCell.Image = CType(resources.GetObject("colEmpCode.AppearanceCell.Image"), System.Drawing.Image)
        Me.colEmpCode.AppearanceCell.Options.UseTextOptions = True
        Me.colEmpCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmpCode.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("colEmpCode.AppearanceHeader.FontSizeDelta"), Integer)
        Me.colEmpCode.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("colEmpCode.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.colEmpCode.AppearanceHeader.GradientMode = CType(resources.GetObject("colEmpCode.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.colEmpCode.AppearanceHeader.Image = CType(resources.GetObject("colEmpCode.AppearanceHeader.Image"), System.Drawing.Image)
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
        Me.clDeptCode.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("clDeptCode.AppearanceHeader.FontSizeDelta"), Integer)
        Me.clDeptCode.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("clDeptCode.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clDeptCode.AppearanceHeader.GradientMode = CType(resources.GetObject("clDeptCode.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clDeptCode.AppearanceHeader.Image = CType(resources.GetObject("clDeptCode.AppearanceHeader.Image"), System.Drawing.Image)
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
        Me.clTime1.AppearanceCell.FontSizeDelta = CType(resources.GetObject("clTime1.AppearanceCell.FontSizeDelta"), Integer)
        Me.clTime1.AppearanceCell.FontStyleDelta = CType(resources.GetObject("clTime1.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clTime1.AppearanceCell.GradientMode = CType(resources.GetObject("clTime1.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clTime1.AppearanceCell.Image = CType(resources.GetObject("clTime1.AppearanceCell.Image"), System.Drawing.Image)
        Me.clTime1.AppearanceCell.Options.UseTextOptions = True
        Me.clTime1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clTime1.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("clTime1.AppearanceHeader.FontSizeDelta"), Integer)
        Me.clTime1.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("clTime1.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clTime1.AppearanceHeader.GradientMode = CType(resources.GetObject("clTime1.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clTime1.AppearanceHeader.Image = CType(resources.GetObject("clTime1.AppearanceHeader.Image"), System.Drawing.Image)
        Me.clTime1.AppearanceHeader.Options.UseTextOptions = True
        Me.clTime1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.clTime1, "clTime1")
        Me.clTime1.FieldName = "OT_Time"
        Me.clTime1.Name = "clTime1"
        Me.clTime1.OptionsColumn.AllowEdit = False
        Me.clTime1.OptionsColumn.ReadOnly = True
        '
        'clTime2
        '
        Me.clTime2.AppearanceCell.FontSizeDelta = CType(resources.GetObject("clTime2.AppearanceCell.FontSizeDelta"), Integer)
        Me.clTime2.AppearanceCell.FontStyleDelta = CType(resources.GetObject("clTime2.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clTime2.AppearanceCell.GradientMode = CType(resources.GetObject("clTime2.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clTime2.AppearanceCell.Image = CType(resources.GetObject("clTime2.AppearanceCell.Image"), System.Drawing.Image)
        Me.clTime2.AppearanceCell.Options.UseTextOptions = True
        Me.clTime2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clTime2.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("clTime2.AppearanceHeader.FontSizeDelta"), Integer)
        Me.clTime2.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("clTime2.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clTime2.AppearanceHeader.GradientMode = CType(resources.GetObject("clTime2.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clTime2.AppearanceHeader.Image = CType(resources.GetObject("clTime2.AppearanceHeader.Image"), System.Drawing.Image)
        Me.clTime2.AppearanceHeader.Options.UseTextOptions = True
        Me.clTime2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.clTime2, "clTime2")
        Me.clTime2.FieldName = "OT_OverTime"
        Me.clTime2.Name = "clTime2"
        Me.clTime2.OptionsColumn.AllowEdit = False
        Me.clTime2.OptionsColumn.ReadOnly = True
        '
        'clTime3
        '
        Me.clTime3.AppearanceCell.FontSizeDelta = CType(resources.GetObject("clTime3.AppearanceCell.FontSizeDelta"), Integer)
        Me.clTime3.AppearanceCell.FontStyleDelta = CType(resources.GetObject("clTime3.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clTime3.AppearanceCell.GradientMode = CType(resources.GetObject("clTime3.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clTime3.AppearanceCell.Image = CType(resources.GetObject("clTime3.AppearanceCell.Image"), System.Drawing.Image)
        Me.clTime3.AppearanceCell.Options.UseTextOptions = True
        Me.clTime3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clTime3.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("clTime3.AppearanceHeader.FontSizeDelta"), Integer)
        Me.clTime3.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("clTime3.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clTime3.AppearanceHeader.GradientMode = CType(resources.GetObject("clTime3.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clTime3.AppearanceHeader.Image = CType(resources.GetObject("clTime3.AppearanceHeader.Image"), System.Drawing.Image)
        Me.clTime3.AppearanceHeader.Options.UseTextOptions = True
        Me.clTime3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.clTime3, "clTime3")
        Me.clTime3.FieldName = "OT_Time_Rate"
        Me.clTime3.Name = "clTime3"
        Me.clTime3.OptionsColumn.AllowEdit = False
        Me.clTime3.OptionsColumn.ReadOnly = True
        '
        'clTime4
        '
        Me.clTime4.AppearanceCell.FontSizeDelta = CType(resources.GetObject("clTime4.AppearanceCell.FontSizeDelta"), Integer)
        Me.clTime4.AppearanceCell.FontStyleDelta = CType(resources.GetObject("clTime4.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clTime4.AppearanceCell.GradientMode = CType(resources.GetObject("clTime4.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clTime4.AppearanceCell.Image = CType(resources.GetObject("clTime4.AppearanceCell.Image"), System.Drawing.Image)
        Me.clTime4.AppearanceCell.Options.UseTextOptions = True
        Me.clTime4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clTime4.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("clTime4.AppearanceHeader.FontSizeDelta"), Integer)
        Me.clTime4.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("clTime4.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clTime4.AppearanceHeader.GradientMode = CType(resources.GetObject("clTime4.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clTime4.AppearanceHeader.Image = CType(resources.GetObject("clTime4.AppearanceHeader.Image"), System.Drawing.Image)
        Me.clTime4.AppearanceHeader.Options.UseTextOptions = True
        Me.clTime4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.clTime4, "clTime4")
        Me.clTime4.FieldName = "OT_OverTime_Rate"
        Me.clTime4.Name = "clTime4"
        Me.clTime4.OptionsColumn.AllowEdit = False
        Me.clTime4.OptionsColumn.ReadOnly = True
        '
        'clTime5
        '
        Me.clTime5.AppearanceCell.FontSizeDelta = CType(resources.GetObject("clTime5.AppearanceCell.FontSizeDelta"), Integer)
        Me.clTime5.AppearanceCell.FontStyleDelta = CType(resources.GetObject("clTime5.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clTime5.AppearanceCell.GradientMode = CType(resources.GetObject("clTime5.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clTime5.AppearanceCell.Image = CType(resources.GetObject("clTime5.AppearanceCell.Image"), System.Drawing.Image)
        Me.clTime5.AppearanceCell.Options.UseTextOptions = True
        Me.clTime5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clTime5.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("clTime5.AppearanceHeader.FontSizeDelta"), Integer)
        Me.clTime5.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("clTime5.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clTime5.AppearanceHeader.GradientMode = CType(resources.GetObject("clTime5.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clTime5.AppearanceHeader.Image = CType(resources.GetObject("clTime5.AppearanceHeader.Image"), System.Drawing.Image)
        Me.clTime5.AppearanceHeader.Options.UseTextOptions = True
        Me.clTime5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.clTime5, "clTime5")
        Me.clTime5.FieldName = "OTBaht_H"
        Me.clTime5.Name = "clTime5"
        Me.clTime5.OptionsColumn.AllowEdit = False
        Me.clTime5.OptionsColumn.ReadOnly = True
        '
        'clTime6
        '
        Me.clTime6.AppearanceCell.FontSizeDelta = CType(resources.GetObject("clTime6.AppearanceCell.FontSizeDelta"), Integer)
        Me.clTime6.AppearanceCell.FontStyleDelta = CType(resources.GetObject("clTime6.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clTime6.AppearanceCell.GradientMode = CType(resources.GetObject("clTime6.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clTime6.AppearanceCell.Image = CType(resources.GetObject("clTime6.AppearanceCell.Image"), System.Drawing.Image)
        Me.clTime6.AppearanceCell.Options.UseTextOptions = True
        Me.clTime6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clTime6.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("clTime6.AppearanceHeader.FontSizeDelta"), Integer)
        Me.clTime6.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("clTime6.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clTime6.AppearanceHeader.GradientMode = CType(resources.GetObject("clTime6.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clTime6.AppearanceHeader.Image = CType(resources.GetObject("clTime6.AppearanceHeader.Image"), System.Drawing.Image)
        Me.clTime6.AppearanceHeader.Options.UseTextOptions = True
        Me.clTime6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.clTime6, "clTime6")
        Me.clTime6.FieldName = "OTH"
        Me.clTime6.Name = "clTime6"
        Me.clTime6.OptionsColumn.AllowEdit = False
        Me.clTime6.OptionsColumn.ReadOnly = True
        '
        'clTime7
        '
        Me.clTime7.AppearanceCell.FontSizeDelta = CType(resources.GetObject("clTime7.AppearanceCell.FontSizeDelta"), Integer)
        Me.clTime7.AppearanceCell.FontStyleDelta = CType(resources.GetObject("clTime7.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clTime7.AppearanceCell.GradientMode = CType(resources.GetObject("clTime7.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clTime7.AppearanceCell.Image = CType(resources.GetObject("clTime7.AppearanceCell.Image"), System.Drawing.Image)
        Me.clTime7.AppearanceCell.Options.UseTextOptions = True
        Me.clTime7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clTime7.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("clTime7.AppearanceHeader.FontSizeDelta"), Integer)
        Me.clTime7.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("clTime7.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clTime7.AppearanceHeader.GradientMode = CType(resources.GetObject("clTime7.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clTime7.AppearanceHeader.Image = CType(resources.GetObject("clTime7.AppearanceHeader.Image"), System.Drawing.Image)
        Me.clTime7.AppearanceHeader.Options.UseTextOptions = True
        Me.clTime7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.clTime7, "clTime7")
        Me.clTime7.FieldName = "OTBaht"
        Me.clTime7.Name = "clTime7"
        Me.clTime7.OptionsColumn.AllowEdit = False
        Me.clTime7.OptionsColumn.ReadOnly = True
        '
        'clTime8
        '
        Me.clTime8.AppearanceCell.FontSizeDelta = CType(resources.GetObject("clTime8.AppearanceCell.FontSizeDelta"), Integer)
        Me.clTime8.AppearanceCell.FontStyleDelta = CType(resources.GetObject("clTime8.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clTime8.AppearanceCell.GradientMode = CType(resources.GetObject("clTime8.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clTime8.AppearanceCell.Image = CType(resources.GetObject("clTime8.AppearanceCell.Image"), System.Drawing.Image)
        Me.clTime8.AppearanceCell.Options.UseTextOptions = True
        Me.clTime8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clTime8.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("clTime8.AppearanceHeader.FontSizeDelta"), Integer)
        Me.clTime8.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("clTime8.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clTime8.AppearanceHeader.GradientMode = CType(resources.GetObject("clTime8.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clTime8.AppearanceHeader.Image = CType(resources.GetObject("clTime8.AppearanceHeader.Image"), System.Drawing.Image)
        Me.clTime8.AppearanceHeader.Options.UseTextOptions = True
        Me.clTime8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.clTime8, "clTime8")
        Me.clTime8.FieldName = "OTPeriod"
        Me.clTime8.Name = "clTime8"
        Me.clTime8.OptionsColumn.AllowEdit = False
        Me.clTime8.OptionsColumn.ReadOnly = True
        '
        'clTime9
        '
        Me.clTime9.AppearanceCell.FontSizeDelta = CType(resources.GetObject("clTime9.AppearanceCell.FontSizeDelta"), Integer)
        Me.clTime9.AppearanceCell.FontStyleDelta = CType(resources.GetObject("clTime9.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clTime9.AppearanceCell.GradientMode = CType(resources.GetObject("clTime9.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clTime9.AppearanceCell.Image = CType(resources.GetObject("clTime9.AppearanceCell.Image"), System.Drawing.Image)
        Me.clTime9.AppearanceCell.Options.UseTextOptions = True
        Me.clTime9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clTime9.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("clTime9.AppearanceHeader.FontSizeDelta"), Integer)
        Me.clTime9.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("clTime9.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clTime9.AppearanceHeader.GradientMode = CType(resources.GetObject("clTime9.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clTime9.AppearanceHeader.Image = CType(resources.GetObject("clTime9.AppearanceHeader.Image"), System.Drawing.Image)
        Me.clTime9.AppearanceHeader.Options.UseTextOptions = True
        Me.clTime9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.clTime9, "clTime9")
        Me.clTime9.FieldName = "WKEnd"
        Me.clTime9.Name = "clTime9"
        Me.clTime9.OptionsColumn.AllowEdit = False
        Me.clTime9.OptionsColumn.ReadOnly = True
        '
        'clTime10
        '
        Me.clTime10.AppearanceCell.FontSizeDelta = CType(resources.GetObject("clTime10.AppearanceCell.FontSizeDelta"), Integer)
        Me.clTime10.AppearanceCell.FontStyleDelta = CType(resources.GetObject("clTime10.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clTime10.AppearanceCell.GradientMode = CType(resources.GetObject("clTime10.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clTime10.AppearanceCell.Image = CType(resources.GetObject("clTime10.AppearanceCell.Image"), System.Drawing.Image)
        Me.clTime10.AppearanceCell.Options.UseTextOptions = True
        Me.clTime10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clTime10.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("clTime10.AppearanceHeader.FontSizeDelta"), Integer)
        Me.clTime10.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("clTime10.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.clTime10.AppearanceHeader.GradientMode = CType(resources.GetObject("clTime10.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.clTime10.AppearanceHeader.Image = CType(resources.GetObject("clTime10.AppearanceHeader.Image"), System.Drawing.Image)
        Me.clTime10.AppearanceHeader.Options.UseTextOptions = True
        Me.clTime10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.clTime10, "clTime10")
        Me.clTime10.FieldName = "Hol"
        Me.clTime10.Name = "clTime10"
        Me.clTime10.OptionsColumn.AllowEdit = False
        Me.clTime10.OptionsColumn.ReadOnly = True
        '
        'txtDateSt
        '
        resources.ApplyResources(Me.txtDateSt, "txtDateSt")
        Me.txtDateSt.EnterMoveNextControl = True
        Me.txtDateSt.Name = "txtDateSt"
        Me.txtDateSt.Properties.AccessibleDescription = resources.GetString("txtDateSt.Properties.AccessibleDescription")
        Me.txtDateSt.Properties.AccessibleName = resources.GetString("txtDateSt.Properties.AccessibleName")
        Me.txtDateSt.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtDateSt.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtDateSt.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtDateSt.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtDateSt.Properties.Appearance.GradientMode = CType(resources.GetObject("txtDateSt.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtDateSt.Properties.Appearance.Image = CType(resources.GetObject("txtDateSt.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtDateSt.Properties.Appearance.Options.UseFont = True
        Me.txtDateSt.Properties.AutoHeight = CType(resources.GetObject("txtDateSt.Properties.AutoHeight"), Boolean)
        Me.txtDateSt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateSt.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateSt.Properties.CalendarTimeProperties.AccessibleDescription = resources.GetString("txtDateSt.Properties.CalendarTimeProperties.AccessibleDescription")
        Me.txtDateSt.Properties.CalendarTimeProperties.AccessibleName = resources.GetString("txtDateSt.Properties.CalendarTimeProperties.AccessibleName")
        Me.txtDateSt.Properties.CalendarTimeProperties.AutoHeight = CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.AutoHeight"), Boolean)
        Me.txtDateSt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateSt.Properties.CalendarTimeProperties.Mask.AutoComplete = CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDateSt.Properties.CalendarTimeProperties.Mask.BeepOnError = CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.Mask.BeepOnError"), Boolean)
        Me.txtDateSt.Properties.CalendarTimeProperties.Mask.EditMask = resources.GetString("txtDateSt.Properties.CalendarTimeProperties.Mask.EditMask")
        Me.txtDateSt.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDateSt.Properties.CalendarTimeProperties.Mask.MaskType = CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDateSt.Properties.CalendarTimeProperties.Mask.PlaceHolder = CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.Mask.PlaceHolder"), Char)
        Me.txtDateSt.Properties.CalendarTimeProperties.Mask.SaveLiteral = CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.Mask.SaveLiteral"), Boolean)
        Me.txtDateSt.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDateSt.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDateSt.Properties.CalendarTimeProperties.NullValuePrompt = resources.GetString("txtDateSt.Properties.CalendarTimeProperties.NullValuePrompt")
        Me.txtDateSt.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtDateSt.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.txtDateSt.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtDateSt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDateSt.Properties.Mask.AutoComplete = CType(resources.GetObject("txtDateSt.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDateSt.Properties.Mask.BeepOnError = CType(resources.GetObject("txtDateSt.Properties.Mask.BeepOnError"), Boolean)
        Me.txtDateSt.Properties.Mask.EditMask = resources.GetString("txtDateSt.Properties.Mask.EditMask")
        Me.txtDateSt.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDateSt.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDateSt.Properties.Mask.MaskType = CType(resources.GetObject("txtDateSt.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDateSt.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtDateSt.Properties.Mask.PlaceHolder"), Char)
        Me.txtDateSt.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtDateSt.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtDateSt.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDateSt.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDateSt.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDateSt.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDateSt.Properties.NullValuePrompt = resources.GetString("txtDateSt.Properties.NullValuePrompt")
        Me.txtDateSt.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtDateSt.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.ToolTip1.SetToolTip(Me.txtDateSt, resources.GetString("txtDateSt.ToolTip"))
        '
        'cboMonth
        '
        resources.ApplyResources(Me.cboMonth, "cboMonth")
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Properties.AccessibleDescription = resources.GetString("cboMonth.Properties.AccessibleDescription")
        Me.cboMonth.Properties.AccessibleName = resources.GetString("cboMonth.Properties.AccessibleName")
        Me.cboMonth.Properties.AutoHeight = CType(resources.GetObject("cboMonth.Properties.AutoHeight"), Boolean)
        Me.cboMonth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboMonth.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboMonth.Properties.DropDownRows = 15
        Me.cboMonth.Properties.NullValuePrompt = resources.GetString("cboMonth.Properties.NullValuePrompt")
        Me.cboMonth.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("cboMonth.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.cboMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ToolTip1.SetToolTip(Me.cboMonth, resources.GetString("cboMonth.ToolTip1"))
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        Me.ToolTip1.SetToolTip(Me.LabelControl2, resources.GetString("LabelControl2.ToolTip1"))
        '
        'GroupControl1
        '
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Controls.Add(Me.btnCurrentDate)
        Me.GroupControl1.Controls.Add(Me.btnAllMonth)
        Me.GroupControl1.Controls.Add(Me.btnTodate)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtYear)
        Me.GroupControl1.Controls.Add(Me.cboMonth)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtDatesp)
        Me.GroupControl1.Controls.Add(Me.txtDateSt)
        Me.GroupControl1.Name = "GroupControl1"
        Me.ToolTip1.SetToolTip(Me.GroupControl1, resources.GetString("GroupControl1.ToolTip"))
        '
        'btnCurrentDate
        '
        resources.ApplyResources(Me.btnCurrentDate, "btnCurrentDate")
        Me.btnCurrentDate.Name = "btnCurrentDate"
        Me.ToolTip1.SetToolTip(Me.btnCurrentDate, resources.GetString("btnCurrentDate.ToolTip1"))
        '
        'btnAllMonth
        '
        resources.ApplyResources(Me.btnAllMonth, "btnAllMonth")
        Me.btnAllMonth.Name = "btnAllMonth"
        Me.ToolTip1.SetToolTip(Me.btnAllMonth, resources.GetString("btnAllMonth.ToolTip1"))
        '
        'btnTodate
        '
        resources.ApplyResources(Me.btnTodate, "btnTodate")
        Me.btnTodate.Name = "btnTodate"
        Me.ToolTip1.SetToolTip(Me.btnTodate, resources.GetString("btnTodate.ToolTip1"))
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        Me.ToolTip1.SetToolTip(Me.LabelControl1, resources.GetString("LabelControl1.ToolTip1"))
        '
        'txtYear
        '
        resources.ApplyResources(Me.txtYear, "txtYear")
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Properties.AccessibleDescription = resources.GetString("txtYear.Properties.AccessibleDescription")
        Me.txtYear.Properties.AccessibleName = resources.GetString("txtYear.Properties.AccessibleName")
        Me.txtYear.Properties.AutoHeight = CType(resources.GetObject("txtYear.Properties.AutoHeight"), Boolean)
        Me.txtYear.Properties.Mask.AutoComplete = CType(resources.GetObject("txtYear.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtYear.Properties.Mask.BeepOnError = CType(resources.GetObject("txtYear.Properties.Mask.BeepOnError"), Boolean)
        Me.txtYear.Properties.Mask.EditMask = resources.GetString("txtYear.Properties.Mask.EditMask")
        Me.txtYear.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtYear.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtYear.Properties.Mask.MaskType = CType(resources.GetObject("txtYear.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtYear.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtYear.Properties.Mask.PlaceHolder"), Char)
        Me.txtYear.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtYear.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtYear.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtYear.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtYear.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtYear.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtYear.Properties.NullValuePrompt = resources.GetString("txtYear.Properties.NullValuePrompt")
        Me.txtYear.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtYear.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.ToolTip1.SetToolTip(Me.txtYear, resources.GetString("txtYear.ToolTip1"))
        '
        'txtDatesp
        '
        resources.ApplyResources(Me.txtDatesp, "txtDatesp")
        Me.txtDatesp.EnterMoveNextControl = True
        Me.txtDatesp.Name = "txtDatesp"
        Me.txtDatesp.Properties.AccessibleDescription = resources.GetString("txtDatesp.Properties.AccessibleDescription")
        Me.txtDatesp.Properties.AccessibleName = resources.GetString("txtDatesp.Properties.AccessibleName")
        Me.txtDatesp.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtDatesp.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtDatesp.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtDatesp.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtDatesp.Properties.Appearance.GradientMode = CType(resources.GetObject("txtDatesp.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtDatesp.Properties.Appearance.Image = CType(resources.GetObject("txtDatesp.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtDatesp.Properties.Appearance.Options.UseFont = True
        Me.txtDatesp.Properties.AutoHeight = CType(resources.GetObject("txtDatesp.Properties.AutoHeight"), Boolean)
        Me.txtDatesp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDatesp.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDatesp.Properties.CalendarTimeProperties.AccessibleDescription = resources.GetString("txtDatesp.Properties.CalendarTimeProperties.AccessibleDescription")
        Me.txtDatesp.Properties.CalendarTimeProperties.AccessibleName = resources.GetString("txtDatesp.Properties.CalendarTimeProperties.AccessibleName")
        Me.txtDatesp.Properties.CalendarTimeProperties.AutoHeight = CType(resources.GetObject("txtDatesp.Properties.CalendarTimeProperties.AutoHeight"), Boolean)
        Me.txtDatesp.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDatesp.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDatesp.Properties.CalendarTimeProperties.Mask.AutoComplete = CType(resources.GetObject("txtDatesp.Properties.CalendarTimeProperties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDatesp.Properties.CalendarTimeProperties.Mask.BeepOnError = CType(resources.GetObject("txtDatesp.Properties.CalendarTimeProperties.Mask.BeepOnError"), Boolean)
        Me.txtDatesp.Properties.CalendarTimeProperties.Mask.EditMask = resources.GetString("txtDatesp.Properties.CalendarTimeProperties.Mask.EditMask")
        Me.txtDatesp.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDatesp.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDatesp.Properties.CalendarTimeProperties.Mask.MaskType = CType(resources.GetObject("txtDatesp.Properties.CalendarTimeProperties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDatesp.Properties.CalendarTimeProperties.Mask.PlaceHolder = CType(resources.GetObject("txtDatesp.Properties.CalendarTimeProperties.Mask.PlaceHolder"), Char)
        Me.txtDatesp.Properties.CalendarTimeProperties.Mask.SaveLiteral = CType(resources.GetObject("txtDatesp.Properties.CalendarTimeProperties.Mask.SaveLiteral"), Boolean)
        Me.txtDatesp.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDatesp.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDatesp.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDatesp.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDatesp.Properties.CalendarTimeProperties.NullValuePrompt = resources.GetString("txtDatesp.Properties.CalendarTimeProperties.NullValuePrompt")
        Me.txtDatesp.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtDatesp.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.txtDatesp.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtDatesp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDatesp.Properties.Mask.AutoComplete = CType(resources.GetObject("txtDatesp.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDatesp.Properties.Mask.BeepOnError = CType(resources.GetObject("txtDatesp.Properties.Mask.BeepOnError"), Boolean)
        Me.txtDatesp.Properties.Mask.EditMask = resources.GetString("txtDatesp.Properties.Mask.EditMask")
        Me.txtDatesp.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDatesp.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDatesp.Properties.Mask.MaskType = CType(resources.GetObject("txtDatesp.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDatesp.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtDatesp.Properties.Mask.PlaceHolder"), Char)
        Me.txtDatesp.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtDatesp.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtDatesp.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDatesp.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDatesp.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDatesp.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDatesp.Properties.NullValuePrompt = resources.GetString("txtDatesp.Properties.NullValuePrompt")
        Me.txtDatesp.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtDatesp.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.ToolTip1.SetToolTip(Me.txtDatesp, resources.GetString("txtDatesp.ToolTip"))
        '
        'GroupControl2
        '
        resources.ApplyResources(Me.GroupControl2, "GroupControl2")
        Me.GroupControl2.Controls.Add(Me.LabelControl11)
        Me.GroupControl2.Controls.Add(Me.txtName)
        Me.GroupControl2.Controls.Add(Me.btnRefresh)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Controls.Add(Me.txtNameSearch)
        Me.GroupControl2.Controls.Add(Me.txtCode1)
        Me.GroupControl2.Controls.Add(Me.GroupControl3)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.cboDivision)
        Me.GroupControl2.Controls.Add(Me.lblDeptId)
        Me.GroupControl2.Controls.Add(Me.cboDepartment)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Name = "GroupControl2"
        Me.ToolTip1.SetToolTip(Me.GroupControl2, resources.GetString("GroupControl2.ToolTip"))
        '
        'LabelControl11
        '
        resources.ApplyResources(Me.LabelControl11, "LabelControl11")
        Me.LabelControl11.Name = "LabelControl11"
        Me.ToolTip1.SetToolTip(Me.LabelControl11, resources.GetString("LabelControl11.ToolTip1"))
        '
        'txtName
        '
        resources.ApplyResources(Me.txtName, "txtName")
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.AccessibleDescription = resources.GetString("txtName.Properties.AccessibleDescription")
        Me.txtName.Properties.AccessibleName = resources.GetString("txtName.Properties.AccessibleName")
        Me.txtName.Properties.AutoHeight = CType(resources.GetObject("txtName.Properties.AutoHeight"), Boolean)
        Me.txtName.Properties.Mask.AutoComplete = CType(resources.GetObject("txtName.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtName.Properties.Mask.BeepOnError = CType(resources.GetObject("txtName.Properties.Mask.BeepOnError"), Boolean)
        Me.txtName.Properties.Mask.EditMask = resources.GetString("txtName.Properties.Mask.EditMask")
        Me.txtName.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtName.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtName.Properties.Mask.MaskType = CType(resources.GetObject("txtName.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtName.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtName.Properties.Mask.PlaceHolder"), Char)
        Me.txtName.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtName.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtName.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtName.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtName.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtName.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtName.Properties.NullValuePrompt = resources.GetString("txtName.Properties.NullValuePrompt")
        Me.txtName.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtName.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.txtName.Properties.ReadOnly = True
        Me.txtName.TabStop = False
        Me.ToolTip1.SetToolTip(Me.txtName, resources.GetString("txtName.ToolTip1"))
        '
        'btnRefresh
        '
        resources.ApplyResources(Me.btnRefresh, "btnRefresh")
        Me.btnRefresh.ImageOptions.Image = CType(resources.GetObject("btnRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnRefresh.Name = "btnRefresh"
        Me.ToolTip1.SetToolTip(Me.btnRefresh, resources.GetString("btnRefresh.ToolTip1"))
        '
        'LabelControl10
        '
        resources.ApplyResources(Me.LabelControl10, "LabelControl10")
        Me.LabelControl10.Name = "LabelControl10"
        Me.ToolTip1.SetToolTip(Me.LabelControl10, resources.GetString("LabelControl10.ToolTip1"))
        '
        'txtNameSearch
        '
        resources.ApplyResources(Me.txtNameSearch, "txtNameSearch")
        Me.txtNameSearch.EnterMoveNextControl = True
        Me.txtNameSearch.Name = "txtNameSearch"
        Me.txtNameSearch.Properties.AccessibleDescription = resources.GetString("txtNameSearch.Properties.AccessibleDescription")
        Me.txtNameSearch.Properties.AccessibleName = resources.GetString("txtNameSearch.Properties.AccessibleName")
        Me.txtNameSearch.Properties.AutoHeight = CType(resources.GetObject("txtNameSearch.Properties.AutoHeight"), Boolean)
        Me.txtNameSearch.Properties.Mask.AutoComplete = CType(resources.GetObject("txtNameSearch.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtNameSearch.Properties.Mask.BeepOnError = CType(resources.GetObject("txtNameSearch.Properties.Mask.BeepOnError"), Boolean)
        Me.txtNameSearch.Properties.Mask.EditMask = resources.GetString("txtNameSearch.Properties.Mask.EditMask")
        Me.txtNameSearch.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtNameSearch.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtNameSearch.Properties.Mask.MaskType = CType(resources.GetObject("txtNameSearch.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtNameSearch.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtNameSearch.Properties.Mask.PlaceHolder"), Char)
        Me.txtNameSearch.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtNameSearch.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtNameSearch.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtNameSearch.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtNameSearch.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtNameSearch.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtNameSearch.Properties.NullValuePrompt = resources.GetString("txtNameSearch.Properties.NullValuePrompt")
        Me.txtNameSearch.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtNameSearch.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.ToolTip1.SetToolTip(Me.txtNameSearch, resources.GetString("txtNameSearch.ToolTip1"))
        '
        'txtCode1
        '
        resources.ApplyResources(Me.txtCode1, "txtCode1")
        Me.txtCode1.EnterMoveNextControl = True
        Me.txtCode1.Name = "txtCode1"
        Me.txtCode1.Properties.AccessibleDescription = resources.GetString("txtCode1.Properties.AccessibleDescription")
        Me.txtCode1.Properties.AccessibleName = resources.GetString("txtCode1.Properties.AccessibleName")
        Me.txtCode1.Properties.AutoHeight = CType(resources.GetObject("txtCode1.Properties.AutoHeight"), Boolean)
        Me.txtCode1.Properties.Mask.AutoComplete = CType(resources.GetObject("txtCode1.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtCode1.Properties.Mask.BeepOnError = CType(resources.GetObject("txtCode1.Properties.Mask.BeepOnError"), Boolean)
        Me.txtCode1.Properties.Mask.EditMask = resources.GetString("txtCode1.Properties.Mask.EditMask")
        Me.txtCode1.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtCode1.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtCode1.Properties.Mask.MaskType = CType(resources.GetObject("txtCode1.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtCode1.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtCode1.Properties.Mask.PlaceHolder"), Char)
        Me.txtCode1.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtCode1.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtCode1.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtCode1.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtCode1.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtCode1.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtCode1.Properties.NullValuePrompt = resources.GetString("txtCode1.Properties.NullValuePrompt")
        Me.txtCode1.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtCode1.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.ToolTip1.SetToolTip(Me.txtCode1, resources.GetString("txtCode1.ToolTip1"))
        '
        'GroupControl3
        '
        resources.ApplyResources(Me.GroupControl3, "GroupControl3")
        Me.GroupControl3.Controls.Add(Me.rdDept)
        Me.GroupControl3.Controls.Add(Me.rdDate)
        Me.GroupControl3.Controls.Add(Me.rdName)
        Me.GroupControl3.Controls.Add(Me.rdCode)
        Me.GroupControl3.Name = "GroupControl3"
        Me.ToolTip1.SetToolTip(Me.GroupControl3, resources.GetString("GroupControl3.ToolTip"))
        '
        'LabelControl6
        '
        resources.ApplyResources(Me.LabelControl6, "LabelControl6")
        Me.LabelControl6.Name = "LabelControl6"
        Me.ToolTip1.SetToolTip(Me.LabelControl6, resources.GetString("LabelControl6.ToolTip1"))
        '
        'cboDivision
        '
        resources.ApplyResources(Me.cboDivision, "cboDivision")
        Me.cboDivision.EnterMoveNextControl = True
        Me.cboDivision.Name = "cboDivision"
        Me.cboDivision.Properties.AccessibleDescription = resources.GetString("cboDivision.Properties.AccessibleDescription")
        Me.cboDivision.Properties.AccessibleName = resources.GetString("cboDivision.Properties.AccessibleName")
        Me.cboDivision.Properties.AutoHeight = CType(resources.GetObject("cboDivision.Properties.AutoHeight"), Boolean)
        Me.cboDivision.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboDivision.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboDivision.Properties.DropDownRows = 15
        Me.cboDivision.Properties.NullValuePrompt = resources.GetString("cboDivision.Properties.NullValuePrompt")
        Me.cboDivision.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("cboDivision.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.cboDivision.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ToolTip1.SetToolTip(Me.cboDivision, resources.GetString("cboDivision.ToolTip1"))
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
        Me.ToolTip1.SetToolTip(Me.cboDepartment, resources.GetString("cboDepartment.ToolTip1"))
        '
        'LabelControl5
        '
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Name = "LabelControl5"
        Me.ToolTip1.SetToolTip(Me.LabelControl5, resources.GetString("LabelControl5.ToolTip1"))
        '
        'btnExit
        '
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.ImageOptions.Image = CType(resources.GetObject("btnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnExit.Name = "btnExit"
        Me.ToolTip1.SetToolTip(Me.btnExit, resources.GetString("btnExit.ToolTip1"))
        '
        'btnClearData
        '
        resources.ApplyResources(Me.btnClearData, "btnClearData")
        Me.btnClearData.ImageOptions.Image = CType(resources.GetObject("btnClearData.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClearData.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnClearData.Name = "btnClearData"
        Me.ToolTip1.SetToolTip(Me.btnClearData, resources.GetString("btnClearData.ToolTip1"))
        '
        'btnProcess
        '
        resources.ApplyResources(Me.btnProcess, "btnProcess")
        Me.btnProcess.ImageOptions.Image = CType(resources.GetObject("btnProcess.ImageOptions.Image"), System.Drawing.Image)
        Me.btnProcess.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnProcess.Name = "btnProcess"
        Me.ToolTip1.SetToolTip(Me.btnProcess, resources.GetString("btnProcess.ToolTip1"))
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        Me.ToolTip1.SetToolTip(Me.LabelControl3, resources.GetString("LabelControl3.ToolTip1"))
        '
        'btnExport
        '
        resources.ApplyResources(Me.btnExport, "btnExport")
        Me.btnExport.Name = "btnExport"
        Me.ToolTip1.SetToolTip(Me.btnExport, resources.GetString("btnExport.ToolTip1"))
        '
        'cboExport
        '
        resources.ApplyResources(Me.cboExport, "cboExport")
        Me.cboExport.Name = "cboExport"
        Me.cboExport.Properties.AccessibleDescription = resources.GetString("cboExport.Properties.AccessibleDescription")
        Me.cboExport.Properties.AccessibleName = resources.GetString("cboExport.Properties.AccessibleName")
        Me.cboExport.Properties.AutoHeight = CType(resources.GetObject("cboExport.Properties.AutoHeight"), Boolean)
        Me.cboExport.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboExport.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboExport.Properties.Items.AddRange(New Object() {resources.GetString("cboExport.Properties.Items"), resources.GetString("cboExport.Properties.Items1")})
        Me.cboExport.Properties.NullValuePrompt = resources.GetString("cboExport.Properties.NullValuePrompt")
        Me.cboExport.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("cboExport.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.cboExport.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ToolTip1.SetToolTip(Me.cboExport, resources.GetString("cboExport.ToolTip1"))
        '
        'DockPanel1
        '
        resources.ApplyResources(Me.DockPanel1, "DockPanel1")
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("a3e33bc5-8ba8-443a-941b-01dffef0c734")
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.AllowFloating = False
        Me.DockPanel1.Options.FloatOnDblClick = False
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(395, 200)
        Me.ToolTip1.SetToolTip(Me.DockPanel1, resources.GetString("DockPanel1.ToolTip"))
        '
        'DockPanel1_Container
        '
        resources.ApplyResources(Me.DockPanel1_Container, "DockPanel1_Container")
        Me.DockPanel1_Container.Controls.Add(Me.GroupControl1)
        Me.DockPanel1_Container.Controls.Add(Me.GroupControl2)
        Me.DockPanel1_Container.Controls.Add(Me.btnExit)
        Me.DockPanel1_Container.Controls.Add(Me.btnClearData)
        Me.DockPanel1_Container.Controls.Add(Me.btnProcess)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.ToolTip1.SetToolTip(Me.DockPanel1_Container, resources.GetString("DockPanel1_Container.ToolTip"))
        '
        'pnlExport
        '
        resources.ApplyResources(Me.pnlExport, "pnlExport")
        Me.pnlExport.Controls.Add(Me.LabelControl7)
        Me.pnlExport.Controls.Add(Me.LabelControl3)
        Me.pnlExport.Controls.Add(Me.cboExport)
        Me.pnlExport.Controls.Add(Me.btnExport)
        Me.pnlExport.Name = "pnlExport"
        Me.ToolTip1.SetToolTip(Me.pnlExport, resources.GetString("pnlExport.ToolTip"))
        '
        'LabelControl7
        '
        resources.ApplyResources(Me.LabelControl7, "LabelControl7")
        Me.LabelControl7.Appearance.Font = CType(resources.GetObject("LabelControl7.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl7.Appearance.FontSizeDelta = CType(resources.GetObject("LabelControl7.Appearance.FontSizeDelta"), Integer)
        Me.LabelControl7.Appearance.FontStyleDelta = CType(resources.GetObject("LabelControl7.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.LabelControl7.Appearance.GradientMode = CType(resources.GetObject("LabelControl7.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.LabelControl7.Appearance.Image = CType(resources.GetObject("LabelControl7.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Name = "LabelControl7"
        Me.ToolTip1.SetToolTip(Me.LabelControl7, resources.GetString("LabelControl7.ToolTip1"))
        '
        'SaveFileDialog1
        '
        resources.ApplyResources(Me.SaveFileDialog1, "SaveFileDialog1")
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'frmOvertime
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gcTimeWork)
        Me.Controls.Add(Me.pnlExport)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmOvertime"
        Me.Tag = "MN01008"
        Me.ToolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        CType(Me.gcTimeWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTimeWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateSt.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateSt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDatesp.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDatesp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.cboDivision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboExport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.pnlExport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlExport.ResumeLayout(False)
        Me.pnlExport.PerformLayout()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblDeptId As System.Windows.Forms.Label
    Friend WithEvents rdName As System.Windows.Forms.RadioButton
    Friend WithEvents rdCode As System.Windows.Forms.RadioButton
    Friend WithEvents rdDate As System.Windows.Forms.RadioButton
    Friend WithEvents rdDept As System.Windows.Forms.RadioButton
    Friend WithEvents gcTimeWork As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTimeWork As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clEmpName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clDeptCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clTime1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clTime2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clTime3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clTime4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clTime5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clTime6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clTime7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clTime8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clTime9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clTime10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDateSt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cboMonth As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtYear As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboDepartment As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClearData As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnProcess As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDatesp As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnTodate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboExport As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnCurrentDate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAllMonth As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCode1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboDivision As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents pnlExport As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
End Class
