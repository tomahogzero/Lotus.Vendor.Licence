<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmImportDevice
    Inherits System.Windows.Forms.Form

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
        Me.txtFileName = New DevExpress.XtraEditors.TextEdit()
        Me.btnBrowse = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.btnImport = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.gcDevice = New DevExpress.XtraGrid.GridControl()
        Me.gvDevice = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn52 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn53 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn54 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn55 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn56 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn57 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn59 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn60 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn61 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn62 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn63 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn64 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn65 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn66 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn67 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn68 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn69 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn70 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn71 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemLookUpEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDevice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDevice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFileName
        '
        Me.txtFileName.EnterMoveNextControl = True
        Me.txtFileName.Location = New System.Drawing.Point(81, 43)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Properties.ReadOnly = True
        Me.txtFileName.Size = New System.Drawing.Size(448, 20)
        Me.txtFileName.TabIndex = 45
        '
        'btnBrowse
        '
        Me.btnBrowse.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnBrowse.Location = New System.Drawing.Point(535, 41)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(76, 22)
        Me.btnBrowse.TabIndex = 44
        Me.btnBrowse.Text = "เลือกไฟล์"
        '
        'LabelControl31
        '
        Me.LabelControl31.Appearance.Options.UseTextOptions = True
        Me.LabelControl31.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl31.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl31.Location = New System.Drawing.Point(12, 46)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl31.TabIndex = 46
        Me.LabelControl31.Text = "File : "
        '
        'btnImport
        '
        Me.btnImport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnImport.Location = New System.Drawing.Point(6, 3)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(118, 34)
        Me.btnImport.TabIndex = 44
        Me.btnImport.Text = "Import"
        '
        'btnExit
        '
        Me.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnExit.Location = New System.Drawing.Point(301, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(73, 34)
        Me.btnExit.TabIndex = 44
        Me.btnExit.Text = "Close"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'gcDevice
        '
        Me.gcDevice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcDevice.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.gcDevice.Location = New System.Drawing.Point(6, 69)
        Me.gcDevice.MainView = Me.gvDevice
        Me.gcDevice.Name = "gcDevice"
        Me.gcDevice.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit4, Me.RepositoryItemLookUpEdit7, Me.RepositoryItemLookUpEdit8})
        Me.gcDevice.Size = New System.Drawing.Size(1058, 548)
        Me.gcDevice.TabIndex = 122
        Me.gcDevice.TabStop = False
        Me.gcDevice.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDevice})
        '
        'gvDevice
        '
        Me.gvDevice.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvDevice.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvDevice.Appearance.Row.Options.UseFont = True
        Me.gvDevice.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn52, Me.GridColumn1, Me.GridColumn53, Me.GridColumn54, Me.GridColumn55, Me.GridColumn56, Me.GridColumn57, Me.GridColumn59, Me.GridColumn60, Me.GridColumn61, Me.GridColumn62, Me.GridColumn63, Me.GridColumn64, Me.GridColumn65, Me.GridColumn66, Me.GridColumn67, Me.GridColumn68, Me.GridColumn69, Me.GridColumn70, Me.GridColumn71})
        Me.gvDevice.GridControl = Me.gcDevice
        Me.gvDevice.Name = "gvDevice"
        Me.gvDevice.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.gvDevice.OptionsSelection.MultiSelect = True
        Me.gvDevice.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gvDevice.OptionsView.ColumnAutoWidth = False
        Me.gvDevice.OptionsView.ShowAutoFilterRow = True
        Me.gvDevice.OptionsView.ShowFooter = True
        Me.gvDevice.OptionsView.ShowGroupPanel = False
        '
        'GridColumn52
        '
        Me.GridColumn52.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn52.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn52.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn52.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn52.Caption = "No."
        Me.GridColumn52.FieldName = "row"
        Me.GridColumn52.Name = "GridColumn52"
        Me.GridColumn52.OptionsColumn.AllowEdit = False
        Me.GridColumn52.OptionsColumn.ReadOnly = True
        Me.GridColumn52.OptionsColumn.TabStop = False
        Me.GridColumn52.Visible = True
        Me.GridColumn52.VisibleIndex = 1
        Me.GridColumn52.Width = 41
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Update Status"
        Me.GridColumn1.FieldName = "updatestatus"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 99
        '
        'GridColumn53
        '
        Me.GridColumn53.Caption = "Fleet"
        Me.GridColumn53.FieldName = "Fleet"
        Me.GridColumn53.Name = "GridColumn53"
        Me.GridColumn53.OptionsColumn.AllowEdit = False
        Me.GridColumn53.Visible = True
        Me.GridColumn53.VisibleIndex = 4
        Me.GridColumn53.Width = 145
        '
        'GridColumn54
        '
        Me.GridColumn54.Caption = "Last Seen"
        Me.GridColumn54.FieldName = "LastSeen"
        Me.GridColumn54.Name = "GridColumn54"
        Me.GridColumn54.OptionsColumn.AllowEdit = False
        Me.GridColumn54.Visible = True
        Me.GridColumn54.VisibleIndex = 5
        Me.GridColumn54.Width = 145
        '
        'GridColumn55
        '
        Me.GridColumn55.Caption = "Device"
        Me.GridColumn55.FieldName = "Device"
        Me.GridColumn55.Name = "GridColumn55"
        Me.GridColumn55.OptionsColumn.AllowEdit = False
        Me.GridColumn55.Visible = True
        Me.GridColumn55.VisibleIndex = 6
        Me.GridColumn55.Width = 145
        '
        'GridColumn56
        '
        Me.GridColumn56.Caption = "Agent Version"
        Me.GridColumn56.FieldName = "AgentVersion"
        Me.GridColumn56.Name = "GridColumn56"
        Me.GridColumn56.OptionsColumn.AllowEdit = False
        Me.GridColumn56.Visible = True
        Me.GridColumn56.VisibleIndex = 7
        Me.GridColumn56.Width = 145
        '
        'GridColumn57
        '
        Me.GridColumn57.Caption = "Location"
        Me.GridColumn57.FieldName = "Location"
        Me.GridColumn57.Name = "GridColumn57"
        Me.GridColumn57.OptionsColumn.AllowEdit = False
        Me.GridColumn57.Visible = True
        Me.GridColumn57.VisibleIndex = 8
        Me.GridColumn57.Width = 145
        '
        'GridColumn59
        '
        Me.GridColumn59.Caption = "Battery Level"
        Me.GridColumn59.FieldName = "BatteryLevel"
        Me.GridColumn59.Name = "GridColumn59"
        Me.GridColumn59.OptionsColumn.AllowEdit = False
        Me.GridColumn59.Visible = True
        Me.GridColumn59.VisibleIndex = 9
        Me.GridColumn59.Width = 145
        '
        'GridColumn60
        '
        Me.GridColumn60.Caption = "Last Online"
        Me.GridColumn60.FieldName = "LastOnline"
        Me.GridColumn60.Name = "GridColumn60"
        Me.GridColumn60.OptionsColumn.AllowEdit = False
        Me.GridColumn60.Visible = True
        Me.GridColumn60.VisibleIndex = 10
        Me.GridColumn60.Width = 145
        '
        'GridColumn61
        '
        Me.GridColumn61.Caption = "Manufacturer"
        Me.GridColumn61.FieldName = "Manufacturer"
        Me.GridColumn61.Name = "GridColumn61"
        Me.GridColumn61.OptionsColumn.AllowEdit = False
        Me.GridColumn61.Visible = True
        Me.GridColumn61.VisibleIndex = 11
        Me.GridColumn61.Width = 145
        '
        'GridColumn62
        '
        Me.GridColumn62.Caption = "Model"
        Me.GridColumn62.FieldName = "Model"
        Me.GridColumn62.Name = "GridColumn62"
        Me.GridColumn62.OptionsColumn.AllowEdit = False
        Me.GridColumn62.Visible = True
        Me.GridColumn62.VisibleIndex = 12
        Me.GridColumn62.Width = 145
        '
        'GridColumn63
        '
        Me.GridColumn63.Caption = "MAC Address"
        Me.GridColumn63.FieldName = "MACAddress"
        Me.GridColumn63.Name = "GridColumn63"
        Me.GridColumn63.OptionsColumn.AllowEdit = False
        Me.GridColumn63.Visible = True
        Me.GridColumn63.VisibleIndex = 13
        Me.GridColumn63.Width = 145
        '
        'GridColumn64
        '
        Me.GridColumn64.Caption = "Ethernet MAC Address"
        Me.GridColumn64.FieldName = "EthernetMACAddress"
        Me.GridColumn64.Name = "GridColumn64"
        Me.GridColumn64.OptionsColumn.AllowEdit = False
        Me.GridColumn64.Visible = True
        Me.GridColumn64.VisibleIndex = 14
        Me.GridColumn64.Width = 145
        '
        'GridColumn65
        '
        Me.GridColumn65.Caption = "IP Address"
        Me.GridColumn65.FieldName = "IPAddress"
        Me.GridColumn65.Name = "GridColumn65"
        Me.GridColumn65.OptionsColumn.AllowEdit = False
        Me.GridColumn65.Visible = True
        Me.GridColumn65.VisibleIndex = 15
        Me.GridColumn65.Width = 145
        '
        'GridColumn66
        '
        Me.GridColumn66.Caption = "Available Memory"
        Me.GridColumn66.FieldName = "AvailableMemory"
        Me.GridColumn66.Name = "GridColumn66"
        Me.GridColumn66.OptionsColumn.AllowEdit = False
        Me.GridColumn66.Visible = True
        Me.GridColumn66.VisibleIndex = 16
        Me.GridColumn66.Width = 145
        '
        'GridColumn67
        '
        Me.GridColumn67.Caption = "Available Storage"
        Me.GridColumn67.FieldName = "AvailableStorage"
        Me.GridColumn67.Name = "GridColumn67"
        Me.GridColumn67.OptionsColumn.AllowEdit = False
        Me.GridColumn67.Visible = True
        Me.GridColumn67.VisibleIndex = 17
        Me.GridColumn67.Width = 145
        '
        'GridColumn68
        '
        Me.GridColumn68.Caption = "Serial Number"
        Me.GridColumn68.FieldName = "SerialNumber"
        Me.GridColumn68.Name = "GridColumn68"
        Me.GridColumn68.OptionsColumn.AllowEdit = False
        Me.GridColumn68.Visible = True
        Me.GridColumn68.VisibleIndex = 18
        Me.GridColumn68.Width = 145
        '
        'GridColumn69
        '
        Me.GridColumn69.Caption = "IMEI"
        Me.GridColumn69.FieldName = "IMEI"
        Me.GridColumn69.Name = "GridColumn69"
        Me.GridColumn69.OptionsColumn.AllowEdit = False
        Me.GridColumn69.Visible = True
        Me.GridColumn69.VisibleIndex = 19
        Me.GridColumn69.Width = 145
        '
        'GridColumn70
        '
        Me.GridColumn70.Caption = "SSID"
        Me.GridColumn70.FieldName = "SSID"
        Me.GridColumn70.Name = "GridColumn70"
        Me.GridColumn70.OptionsColumn.AllowEdit = False
        Me.GridColumn70.Visible = True
        Me.GridColumn70.VisibleIndex = 20
        Me.GridColumn70.Width = 145
        '
        'GridColumn71
        '
        Me.GridColumn71.Caption = "APPSerialNo"
        Me.GridColumn71.FieldName = "APPSerialNo"
        Me.GridColumn71.Name = "GridColumn71"
        Me.GridColumn71.Visible = True
        Me.GridColumn71.VisibleIndex = 3
        Me.GridColumn71.Width = 145
        '
        'RepositoryItemButtonEdit4
        '
        Me.RepositoryItemButtonEdit4.AutoHeight = False
        Me.RepositoryItemButtonEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.RepositoryItemButtonEdit4.Name = "RepositoryItemButtonEdit4"
        Me.RepositoryItemButtonEdit4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepositoryItemLookUpEdit7
        '
        Me.RepositoryItemLookUpEdit7.AutoHeight = False
        Me.RepositoryItemLookUpEdit7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit7.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TransName", 30, "บริษัทขนส่ง")})
        Me.RepositoryItemLookUpEdit7.DisplayMember = "TransName"
        Me.RepositoryItemLookUpEdit7.Name = "RepositoryItemLookUpEdit7"
        Me.RepositoryItemLookUpEdit7.NullText = ""
        Me.RepositoryItemLookUpEdit7.ValueMember = "transcomId"
        '
        'RepositoryItemLookUpEdit8
        '
        Me.RepositoryItemLookUpEdit8.AutoHeight = False
        Me.RepositoryItemLookUpEdit8.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit8.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("unit", "หน่วยนับ")})
        Me.RepositoryItemLookUpEdit8.DisplayMember = "unit"
        Me.RepositoryItemLookUpEdit8.Name = "RepositoryItemLookUpEdit8"
        Me.RepositoryItemLookUpEdit8.NullText = ""
        Me.RepositoryItemLookUpEdit8.ValueMember = "unitid"
        '
        'btnSave
        '
        Me.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnSave.Location = New System.Drawing.Point(130, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(118, 34)
        Me.btnSave.TabIndex = 44
        Me.btnSave.Text = "Save"
        '
        'frmImportDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 623)
        Me.Controls.Add(Me.gcDevice)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.LabelControl31)
        Me.Name = "frmImportDevice"
        Me.Text = "Import Device From CSV"
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDevice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDevice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtFileName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents gcDevice As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDevice As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn52 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn53 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn54 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn55 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn56 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn57 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn59 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn60 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn61 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn62 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn63 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn64 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn65 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn66 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn67 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn68 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn69 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn70 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn71 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemLookUpEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
End Class
