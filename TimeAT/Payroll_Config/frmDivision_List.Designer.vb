<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDivision_List
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDivision_List))
        Me.GcDivision_List = New DevExpress.XtraGrid.GridControl()
        Me.GvDivision_list = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldateyear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldaystop = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cboTransport_detail = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboUnitName = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btn_exit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GcDivision_List, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvDivision_list, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GcDivision_List
        '
        Me.GcDivision_List.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GcDivision_List.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GcDivision_List.Location = New System.Drawing.Point(12, 46)
        Me.GcDivision_List.MainView = Me.GvDivision_list
        Me.GcDivision_List.Name = "GcDivision_List"
        Me.GcDivision_List.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.BtnDel, Me.cboTransport_detail, Me.cboUnitName})
        Me.GcDivision_List.Size = New System.Drawing.Size(529, 495)
        Me.GcDivision_List.TabIndex = 41
        Me.GcDivision_List.TabStop = False
        Me.GcDivision_List.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvDivision_list})
        '
        'GvDivision_list
        '
        Me.GvDivision_list.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GvDivision_list.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvDivision_list.Appearance.Row.Options.UseFont = True
        Me.GvDivision_list.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colrow, Me.coldateyear, Me.coldaystop})
        Me.GvDivision_list.GridControl = Me.GcDivision_List
        Me.GvDivision_list.Name = "GvDivision_list"
        Me.GvDivision_list.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.GvDivision_list.OptionsView.ColumnAutoWidth = False
        Me.GvDivision_list.OptionsView.ShowAutoFilterRow = True
        Me.GvDivision_list.OptionsView.ShowGroupPanel = False
        '
        'colrow
        '
        Me.colrow.AppearanceCell.Options.UseTextOptions = True
        Me.colrow.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colrow.AppearanceHeader.Options.UseTextOptions = True
        Me.colrow.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colrow.Caption = "ลำดับ"
        Me.colrow.FieldName = "row"
        Me.colrow.Name = "colrow"
        Me.colrow.OptionsColumn.AllowEdit = False
        Me.colrow.OptionsColumn.TabStop = False
        Me.colrow.Visible = True
        Me.colrow.VisibleIndex = 0
        Me.colrow.Width = 41
        '
        'coldateyear
        '
        Me.coldateyear.AppearanceCell.Options.UseTextOptions = True
        Me.coldateyear.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coldateyear.AppearanceHeader.Options.UseTextOptions = True
        Me.coldateyear.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coldateyear.Caption = "รหัสฝ่าย"
        Me.coldateyear.FieldName = "DivId"
        Me.coldateyear.Name = "coldateyear"
        Me.coldateyear.OptionsColumn.AllowEdit = False
        Me.coldateyear.OptionsColumn.ReadOnly = True
        Me.coldateyear.Visible = True
        Me.coldateyear.VisibleIndex = 1
        Me.coldateyear.Width = 92
        '
        'coldaystop
        '
        Me.coldaystop.Caption = "ชื่อฝ่าย"
        Me.coldaystop.FieldName = "Division"
        Me.coldaystop.Name = "coldaystop"
        Me.coldaystop.OptionsColumn.AllowEdit = False
        Me.coldaystop.OptionsColumn.ReadOnly = True
        Me.coldaystop.Visible = True
        Me.coldaystop.VisibleIndex = 2
        Me.coldaystop.Width = 360
        '
        'BtnDel
        '
        Me.BtnDel.AutoHeight = False
        Me.BtnDel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'cboTransport_detail
        '
        Me.cboTransport_detail.AutoHeight = False
        Me.cboTransport_detail.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTransport_detail.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TransName", 30, "บริษัทขนส่ง")})
        Me.cboTransport_detail.DisplayMember = "TransName"
        Me.cboTransport_detail.Name = "cboTransport_detail"
        Me.cboTransport_detail.NullText = ""
        Me.cboTransport_detail.ValueMember = "transcomId"
        '
        'cboUnitName
        '
        Me.cboUnitName.AutoHeight = False
        Me.cboUnitName.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUnitName.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("unit", "หน่วยนับ")})
        Me.cboUnitName.DisplayMember = "unit"
        Me.cboUnitName.Name = "cboUnitName"
        Me.cboUnitName.NullText = ""
        Me.cboUnitName.ValueMember = "unitid"
        '
        'btn_exit
        '
        Me.btn_exit.ImageOptions.Image = CType(resources.GetObject("btn_exit.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_exit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_exit.Location = New System.Drawing.Point(12, 12)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(101, 28)
        Me.btn_exit.TabIndex = 42
        Me.btn_exit.Text = "ออก"
        '
        'frmDivision_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 553)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.GcDivision_List)
        Me.Name = "frmDivision_List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกฝ่าย"
        CType(Me.GcDivision_List, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvDivision_list, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GcDivision_List As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvDivision_list As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colrow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldateyear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldaystop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cboTransport_detail As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboUnitName As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btn_exit As DevExpress.XtraEditors.SimpleButton
End Class
