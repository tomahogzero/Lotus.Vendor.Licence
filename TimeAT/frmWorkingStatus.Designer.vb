<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkingStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorkingStatus))
        Me.lstWorkingStatus = New System.Windows.Forms.ListView()
        Me.colNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNoPay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRemark = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboAttCode = New System.Windows.Forms.ComboBox()
        Me.rdNoPay = New System.Windows.Forms.RadioButton()
        Me.rdPay = New System.Windows.Forms.RadioButton()
        Me.txtAttDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GcWorkingStatus = New DevExpress.XtraGrid.GridControl()
        Me.GvWorkingStatus = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode_lar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription_lar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReduc_lar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotdeduc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colremark_lar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cboTransport_detail = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboUnitName = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lblDescription = New DevExpress.XtraEditors.LabelControl()
        Me.lblCode = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemark = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        CType(Me.GcWorkingStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvWorkingStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstWorkingStatus
        '
        Me.lstWorkingStatus.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNo, Me.colCode, Me.colDescription, Me.colPay, Me.colNoPay, Me.colRemark, Me.ColumnHeader1})
        Me.lstWorkingStatus.FullRowSelect = True
        Me.lstWorkingStatus.GridLines = True
        resources.ApplyResources(Me.lstWorkingStatus, "lstWorkingStatus")
        Me.lstWorkingStatus.Name = "lstWorkingStatus"
        Me.lstWorkingStatus.UseCompatibleStateImageBehavior = False
        Me.lstWorkingStatus.View = System.Windows.Forms.View.Details
        '
        'colNo
        '
        resources.ApplyResources(Me.colNo, "colNo")
        '
        'colCode
        '
        resources.ApplyResources(Me.colCode, "colCode")
        '
        'colDescription
        '
        resources.ApplyResources(Me.colDescription, "colDescription")
        '
        'colPay
        '
        resources.ApplyResources(Me.colPay, "colPay")
        '
        'colNoPay
        '
        resources.ApplyResources(Me.colNoPay, "colNoPay")
        '
        'colRemark
        '
        resources.ApplyResources(Me.colRemark, "colRemark")
        '
        'ColumnHeader1
        '
        resources.ApplyResources(Me.ColumnHeader1, "ColumnHeader1")
        '
        'cboAttCode
        '
        Me.cboAttCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAttCode.FormattingEnabled = True
        resources.ApplyResources(Me.cboAttCode, "cboAttCode")
        Me.cboAttCode.Name = "cboAttCode"
        '
        'rdNoPay
        '
        resources.ApplyResources(Me.rdNoPay, "rdNoPay")
        Me.rdNoPay.Name = "rdNoPay"
        Me.rdNoPay.UseVisualStyleBackColor = True
        '
        'rdPay
        '
        resources.ApplyResources(Me.rdPay, "rdPay")
        Me.rdPay.Checked = True
        Me.rdPay.Name = "rdPay"
        Me.rdPay.TabStop = True
        Me.rdPay.UseVisualStyleBackColor = True
        '
        'txtAttDescription
        '
        resources.ApplyResources(Me.txtAttDescription, "txtAttDescription")
        Me.txtAttDescription.Name = "txtAttDescription"
        Me.txtAttDescription.ReadOnly = True
        Me.txtAttDescription.TabStop = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'GcWorkingStatus
        '
        resources.ApplyResources(Me.GcWorkingStatus, "GcWorkingStatus")
        Me.GcWorkingStatus.MainView = Me.GvWorkingStatus
        Me.GcWorkingStatus.Name = "GcWorkingStatus"
        Me.GcWorkingStatus.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.BtnDel, Me.cboTransport_detail, Me.cboUnitName})
        Me.GcWorkingStatus.TabStop = False
        Me.GcWorkingStatus.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvWorkingStatus})
        '
        'GvWorkingStatus
        '
        Me.GvWorkingStatus.Appearance.HeaderPanel.Font = CType(resources.GetObject("GvWorkingStatus.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GvWorkingStatus.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvWorkingStatus.Appearance.Row.Options.UseFont = True
        Me.GvWorkingStatus.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colrow, Me.colcode_lar, Me.colDescription_lar, Me.colReduc_lar, Me.colNotdeduc, Me.colremark_lar, Me.GridColumn1})
        Me.GvWorkingStatus.GridControl = Me.GcWorkingStatus
        Me.GvWorkingStatus.Name = "GvWorkingStatus"
        Me.GvWorkingStatus.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.GvWorkingStatus.OptionsView.ColumnAutoWidth = False
        Me.GvWorkingStatus.OptionsView.ShowGroupPanel = False
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
        'colcode_lar
        '
        Me.colcode_lar.AppearanceCell.Options.UseTextOptions = True
        Me.colcode_lar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colcode_lar.AppearanceHeader.Options.UseTextOptions = True
        Me.colcode_lar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colcode_lar, "colcode_lar")
        Me.colcode_lar.FieldName = "Code"
        Me.colcode_lar.Name = "colcode_lar"
        Me.colcode_lar.OptionsColumn.AllowEdit = False
        '
        'colDescription_lar
        '
        resources.ApplyResources(Me.colDescription_lar, "colDescription_lar")
        Me.colDescription_lar.FieldName = "Description"
        Me.colDescription_lar.Name = "colDescription_lar"
        Me.colDescription_lar.OptionsColumn.AllowEdit = False
        '
        'colReduc_lar
        '
        Me.colReduc_lar.AppearanceCell.Options.UseTextOptions = True
        Me.colReduc_lar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colReduc_lar.AppearanceHeader.Options.UseTextOptions = True
        Me.colReduc_lar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colReduc_lar, "colReduc_lar")
        Me.colReduc_lar.FieldName = "Pay"
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
        Me.colNotdeduc.FieldName = "Nopay"
        Me.colNotdeduc.Name = "colNotdeduc"
        Me.colNotdeduc.OptionsColumn.AllowEdit = False
        '
        'colremark_lar
        '
        resources.ApplyResources(Me.colremark_lar, "colremark_lar")
        Me.colremark_lar.FieldName = "Remark"
        Me.colremark_lar.Name = "colremark_lar"
        Me.colremark_lar.OptionsColumn.AllowEdit = False
        '
        'GridColumn1
        '
        resources.ApplyResources(Me.GridColumn1, "GridColumn1")
        Me.GridColumn1.FieldName = "AttCode"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
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
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.lblDescription)
        Me.GroupControl1.Controls.Add(Me.lblCode)
        Me.GroupControl1.Controls.Add(Me.cboAttCode)
        Me.GroupControl1.Controls.Add(Me.rdNoPay)
        Me.GroupControl1.Controls.Add(Me.rdPay)
        Me.GroupControl1.Controls.Add(Me.txtAttDescription)
        Me.GroupControl1.Controls.Add(Me.txtRemark)
        Me.GroupControl1.Controls.Add(Me.txtDescription)
        Me.GroupControl1.Controls.Add(Me.txtCode)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Name = "GroupControl1"
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        '
        'lblDescription
        '
        resources.ApplyResources(Me.lblDescription, "lblDescription")
        Me.lblDescription.Name = "lblDescription"
        '
        'lblCode
        '
        resources.ApplyResources(Me.lblCode, "lblCode")
        Me.lblCode.Name = "lblCode"
        '
        'txtRemark
        '
        Me.txtRemark.EnterMoveNextControl = True
        resources.ApplyResources(Me.txtRemark, "txtRemark")
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Properties.MaxLength = 100
        '
        'txtDescription
        '
        Me.txtDescription.EnterMoveNextControl = True
        resources.ApplyResources(Me.txtDescription, "txtDescription")
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.MaxLength = 70
        '
        'txtCode
        '
        Me.txtCode.EnterMoveNextControl = True
        resources.ApplyResources(Me.txtCode, "txtCode")
        Me.txtCode.Name = "txtCode"
        '
        'frmWorkingStatus
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GcWorkingStatus)
        Me.Controls.Add(Me.lstWorkingStatus)
        Me.KeyPreview = True
        Me.Name = "frmWorkingStatus"
        CType(Me.GcWorkingStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvWorkingStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstWorkingStatus As System.Windows.Forms.ListView
    Friend WithEvents colNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPay As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDescription As System.Windows.Forms.ColumnHeader
    Friend WithEvents colRemark As System.Windows.Forms.ColumnHeader
    Friend WithEvents rdNoPay As System.Windows.Forms.RadioButton
    Friend WithEvents rdPay As System.Windows.Forms.RadioButton
    Friend WithEvents colCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents colNoPay As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboAttCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAttDescription As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GcWorkingStatus As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvWorkingStatus As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colrow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode_lar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription_lar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReduc_lar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotdeduc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colremark_lar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cboTransport_detail As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboUnitName As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtRemark As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDescription As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCode As DevExpress.XtraEditors.LabelControl
End Class
