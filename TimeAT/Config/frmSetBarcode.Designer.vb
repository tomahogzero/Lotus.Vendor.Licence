<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetBarcode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetBarcode))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstEmp = New System.Windows.Forms.ListView()
        Me.colNO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Barcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDepartment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboCompany = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GcEmpbarcode = New DevExpress.XtraGrid.GridControl()
        Me.Gvempbarcode = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colempcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbarcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_department = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cboTransport_detail = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboUnitName = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtEmpNameSearch = New System.Windows.Forms.TextBox()
        Me.lblDeptID = New DevExpress.XtraEditors.TextEdit()
        Me.cboDepartment = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.lblEmpName = New DevExpress.XtraEditors.TextEdit()
        Me.btnAutoGenBarcode = New DevExpress.XtraEditors.SimpleButton()
        Me.txtBarcode = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GcEmpbarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gvempbarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.lblDeptID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.lblEmpName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.lstEmp)
        Me.GroupBox1.Controls.Add(Me.cboCompany)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'lstEmp
        '
        resources.ApplyResources(Me.lstEmp, "lstEmp")
        Me.lstEmp.CheckBoxes = True
        Me.lstEmp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNO, Me.colCode, Me.colName, Me.colSName, Me.Barcode, Me.colDepartment})
        Me.lstEmp.FullRowSelect = True
        Me.lstEmp.GridLines = True
        Me.lstEmp.Name = "lstEmp"
        Me.lstEmp.UseCompatibleStateImageBehavior = False
        Me.lstEmp.View = System.Windows.Forms.View.Details
        '
        'colNO
        '
        resources.ApplyResources(Me.colNO, "colNO")
        '
        'colCode
        '
        resources.ApplyResources(Me.colCode, "colCode")
        '
        'colName
        '
        resources.ApplyResources(Me.colName, "colName")
        '
        'colSName
        '
        resources.ApplyResources(Me.colSName, "colSName")
        '
        'Barcode
        '
        resources.ApplyResources(Me.Barcode, "Barcode")
        '
        'colDepartment
        '
        resources.ApplyResources(Me.colDepartment, "colDepartment")
        '
        'cboCompany
        '
        Me.cboCompany.FormattingEnabled = True
        resources.ApplyResources(Me.cboCompany, "cboCompany")
        Me.cboCompany.Name = "cboCompany"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'GcEmpbarcode
        '
        resources.ApplyResources(Me.GcEmpbarcode, "GcEmpbarcode")
        Me.GcEmpbarcode.MainView = Me.Gvempbarcode
        Me.GcEmpbarcode.Name = "GcEmpbarcode"
        Me.GcEmpbarcode.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.BtnDel, Me.cboTransport_detail, Me.cboUnitName})
        Me.GcEmpbarcode.TabStop = False
        Me.GcEmpbarcode.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gvempbarcode})
        '
        'Gvempbarcode
        '
        Me.Gvempbarcode.Appearance.HeaderPanel.Font = CType(resources.GetObject("Gvempbarcode.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.Gvempbarcode.Appearance.HeaderPanel.Options.UseFont = True
        Me.Gvempbarcode.Appearance.Row.Font = CType(resources.GetObject("Gvempbarcode.Appearance.Row.Font"), System.Drawing.Font)
        Me.Gvempbarcode.Appearance.Row.Options.UseFont = True
        Me.Gvempbarcode.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colrow, Me.colempcode, Me.colProductName, Me.collname, Me.colbarcode, Me.col_department})
        Me.Gvempbarcode.GridControl = Me.GcEmpbarcode
        Me.Gvempbarcode.Name = "Gvempbarcode"
        Me.Gvempbarcode.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.Gvempbarcode.OptionsSelection.MultiSelect = True
        Me.Gvempbarcode.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.Gvempbarcode.OptionsView.ColumnAutoWidth = False
        Me.Gvempbarcode.OptionsView.ShowAutoFilterRow = True
        Me.Gvempbarcode.OptionsView.ShowGroupPanel = False
        '
        'colrow
        '
        Me.colrow.AppearanceCell.Options.UseTextOptions = True
        Me.colrow.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colrow.AppearanceHeader.Options.UseTextOptions = True
        Me.colrow.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colrow, "colrow")
        Me.colrow.Name = "colrow"
        Me.colrow.OptionsColumn.AllowEdit = False
        Me.colrow.OptionsColumn.TabStop = False
        '
        'colempcode
        '
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
        'colbarcode
        '
        resources.ApplyResources(Me.colbarcode, "colbarcode")
        Me.colbarcode.FieldName = "Barcode"
        Me.colbarcode.Name = "colbarcode"
        Me.colbarcode.OptionsColumn.AllowEdit = False
        '
        'col_department
        '
        resources.ApplyResources(Me.col_department, "col_department")
        Me.col_department.FieldName = "Department"
        Me.col_department.Name = "col_department"
        Me.col_department.OptionsColumn.AllowEdit = False
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
        'GroupBox2
        '
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.txtEmpNameSearch)
        Me.GroupBox2.Controls.Add(Me.lblDeptID)
        Me.GroupBox2.Controls.Add(Me.cboDepartment)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'btnSearch
        '
        resources.ApplyResources(Me.btnSearch, "btnSearch")
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtEmpNameSearch
        '
        resources.ApplyResources(Me.txtEmpNameSearch, "txtEmpNameSearch")
        Me.txtEmpNameSearch.Name = "txtEmpNameSearch"
        '
        'lblDeptID
        '
        Me.lblDeptID.EnterMoveNextControl = True
        resources.ApplyResources(Me.lblDeptID, "lblDeptID")
        Me.lblDeptID.Name = "lblDeptID"
        '
        'cboDepartment
        '
        Me.cboDepartment.FormattingEnabled = True
        resources.ApplyResources(Me.cboDepartment, "cboDepartment")
        Me.cboDepartment.Name = "cboDepartment"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'GroupControl1
        '
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Appearance.Font = CType(resources.GetObject("GroupControl1.Appearance.Font"), System.Drawing.Font)
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Font = CType(resources.GetObject("GroupControl1.AppearanceCaption.Font"), System.Drawing.Font)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GcEmpbarcode)
        Me.GroupControl1.Name = "GroupControl1"
        '
        'GroupControl2
        '
        resources.ApplyResources(Me.GroupControl2, "GroupControl2")
        Me.GroupControl2.Controls.Add(Me.lblEmpName)
        Me.GroupControl2.Controls.Add(Me.btnAutoGenBarcode)
        Me.GroupControl2.Controls.Add(Me.txtBarcode)
        Me.GroupControl2.Controls.Add(Me.Label6)
        Me.GroupControl2.Controls.Add(Me.txtCode)
        Me.GroupControl2.Controls.Add(Me.Label9)
        Me.GroupControl2.Name = "GroupControl2"
        '
        'lblEmpName
        '
        resources.ApplyResources(Me.lblEmpName, "lblEmpName")
        Me.lblEmpName.Name = "lblEmpName"
        Me.lblEmpName.Properties.Appearance.BackColor = CType(resources.GetObject("lblEmpName.Properties.Appearance.BackColor"), System.Drawing.Color)
        Me.lblEmpName.Properties.Appearance.Options.UseBackColor = True
        '
        'btnAutoGenBarcode
        '
        Me.btnAutoGenBarcode.Appearance.Font = CType(resources.GetObject("btnAutoGenBarcode.Appearance.Font"), System.Drawing.Font)
        Me.btnAutoGenBarcode.Appearance.Options.UseFont = True
        Me.btnAutoGenBarcode.ImageOptions.Image = CType(resources.GetObject("btnAutoGenBarcode.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAutoGenBarcode.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnAutoGenBarcode, "btnAutoGenBarcode")
        Me.btnAutoGenBarcode.Name = "btnAutoGenBarcode"
        Me.btnAutoGenBarcode.TabStop = False
        '
        'txtBarcode
        '
        Me.txtBarcode.EnterMoveNextControl = True
        resources.ApplyResources(Me.txtBarcode, "txtBarcode")
        Me.txtBarcode.Name = "txtBarcode"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'txtCode
        '
        Me.txtCode.EnterMoveNextControl = True
        resources.ApplyResources(Me.txtCode, "txtCode")
        Me.txtCode.Name = "txtCode"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'btnExit
        '
        Me.btnExit.Appearance.Font = CType(resources.GetObject("btnExit.Appearance.Font"), System.Drawing.Font)
        Me.btnExit.Appearance.Options.UseFont = True
        Me.btnExit.ImageOptions.Image = CType(resources.GetObject("btnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = CType(resources.GetObject("btnSave.Appearance.Font"), System.Drawing.Font)
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.Name = "btnSave"
        '
        'frmSetBarcode
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "frmSetBarcode"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GcEmpbarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gvempbarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.lblDeptID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.lblEmpName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBarcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstEmp As System.Windows.Forms.ListView
    Friend WithEvents colNO As System.Windows.Forms.ColumnHeader
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Barcode As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDepartment As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtEmpNameSearch As System.Windows.Forms.TextBox
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboCompany As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GcEmpbarcode As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gvempbarcode As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colrow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colempcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboUnitName As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BtnDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cboTransport_detail As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents collname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_department As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As Label
    Friend WithEvents lblDeptID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBarcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents lblEmpName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAutoGenBarcode As DevExpress.XtraEditors.SimpleButton
End Class
