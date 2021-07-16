<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportEmpProfile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExportTemplate = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.txtRowSt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRowSP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstEmpProfile = New System.Windows.Forms.ListView()
        Me.colNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTitleEng = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colFirstnameEng = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLNameEng = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNickname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDivision = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDepartment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSection = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPosition = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colWorkStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colImportStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "บันทัดที่ : "
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(92, 7)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.ReadOnly = True
        Me.txtFileName.Size = New System.Drawing.Size(405, 20)
        Me.txtFileName.TabIndex = 1
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(503, 5)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "เลือก"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(12, 59)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(103, 23)
        Me.btnImport.TabIndex = 3
        Me.btnImport.Text = "นำเข้า"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(121, 59)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(141, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "บันทึกข้อมูล"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExportTemplate
        '
        Me.btnExportTemplate.Location = New System.Drawing.Point(361, 59)
        Me.btnExportTemplate.Name = "btnExportTemplate"
        Me.btnExportTemplate.Size = New System.Drawing.Size(136, 23)
        Me.btnExportTemplate.TabIndex = 4
        Me.btnExportTemplate.Text = "Export Template"
        Me.btnExportTemplate.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 88)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(910, 12)
        Me.ProgressBar1.TabIndex = 5
        '
        'txtRowSt
        '
        Me.txtRowSt.Location = New System.Drawing.Point(92, 33)
        Me.txtRowSt.Name = "txtRowSt"
        Me.txtRowSt.Size = New System.Drawing.Size(65, 20)
        Me.txtRowSt.TabIndex = 6
        Me.txtRowSt.Text = "2"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(163, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ถึง"
        '
        'txtRowSP
        '
        Me.txtRowSP.Location = New System.Drawing.Point(197, 33)
        Me.txtRowSP.Name = "txtRowSP"
        Me.txtRowSP.Size = New System.Drawing.Size(65, 20)
        Me.txtRowSP.TabIndex = 6
        Me.txtRowSP.Text = "10"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "เลือกไฟล์ : "
        '
        'lstEmpProfile
        '
        Me.lstEmpProfile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstEmpProfile.CheckBoxes = True
        Me.lstEmpProfile.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNo, Me.colImportStatus, Me.colCode, Me.colTitle, Me.colName, Me.colLname, Me.colTitleEng, Me.colFirstnameEng, Me.colLNameEng, Me.colNickname, Me.colSex, Me.colDivision, Me.colDepartment, Me.colSection, Me.colPosition, Me.colWorkStatus})
        Me.lstEmpProfile.FullRowSelect = True
        Me.lstEmpProfile.GridLines = True
        Me.lstEmpProfile.Location = New System.Drawing.Point(12, 106)
        Me.lstEmpProfile.Name = "lstEmpProfile"
        Me.lstEmpProfile.Size = New System.Drawing.Size(910, 371)
        Me.lstEmpProfile.TabIndex = 7
        Me.lstEmpProfile.UseCompatibleStateImageBehavior = False
        Me.lstEmpProfile.View = System.Windows.Forms.View.Details
        '
        'colNo
        '
        Me.colNo.Text = "ที่"
        Me.colNo.Width = 39
        '
        'colCode
        '
        Me.colCode.Text = "รหัสพนง."
        Me.colCode.Width = 81
        '
        'colTitle
        '
        Me.colTitle.Text = "คำนำหน้าชื่อ"
        Me.colTitle.Width = 73
        '
        'colName
        '
        Me.colName.Text = "ชื่อ"
        Me.colName.Width = 154
        '
        'colLname
        '
        Me.colLname.Text = "สกุล"
        Me.colLname.Width = 141
        '
        'colTitleEng
        '
        Me.colTitleEng.Text = "Title"
        Me.colTitleEng.Width = 64
        '
        'colFirstnameEng
        '
        Me.colFirstnameEng.Text = "First name"
        Me.colFirstnameEng.Width = 101
        '
        'colLNameEng
        '
        Me.colLNameEng.Text = "Last name"
        Me.colLNameEng.Width = 128
        '
        'colNickname
        '
        Me.colNickname.Text = "ชื่อเล่น"
        Me.colNickname.Width = 65
        '
        'colSex
        '
        Me.colSex.Text = "เพศ(M:ชาย,F:หญิง)"
        Me.colSex.Width = 108
        '
        'colDivision
        '
        Me.colDivision.Text = "ฝ่าย"
        Me.colDivision.Width = 148
        '
        'colDepartment
        '
        Me.colDepartment.Text = "แผนก"
        Me.colDepartment.Width = 169
        '
        'colSection
        '
        Me.colSection.Text = "ส่วน"
        Me.colSection.Width = 164
        '
        'colPosition
        '
        Me.colPosition.Text = "ตำแหน่ง"
        Me.colPosition.Width = 125
        '
        'colWorkStatus
        '
        Me.colWorkStatus.Text = "สถานะ(W:ทำงาน,T:ลาออก"
        Me.colWorkStatus.Width = 147
        '
        'colImportStatus
        '
        Me.colImportStatus.Text = "สถานะการนำเข้า"
        Me.colImportStatus.Width = 106
        '
        'frmImportEmpProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 489)
        Me.Controls.Add(Me.lstEmpProfile)
        Me.Controls.Add(Me.txtRowSP)
        Me.Controls.Add(Me.txtRowSt)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnExportTemplate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmImportEmpProfile"
        Me.Text = "นำเข้าข้อมูลพนักงาน"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExportTemplate As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents txtRowSt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRowSP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lstEmpProfile As ListView
    Friend WithEvents colNo As ColumnHeader
    Friend WithEvents colImportStatus As ColumnHeader
    Friend WithEvents colCode As ColumnHeader
    Friend WithEvents colTitle As ColumnHeader
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colLname As ColumnHeader
    Friend WithEvents colTitleEng As ColumnHeader
    Friend WithEvents colFirstnameEng As ColumnHeader
    Friend WithEvents colLNameEng As ColumnHeader
    Friend WithEvents colNickname As ColumnHeader
    Friend WithEvents colSex As ColumnHeader
    Friend WithEvents colDivision As ColumnHeader
    Friend WithEvents colDepartment As ColumnHeader
    Friend WithEvents colSection As ColumnHeader
    Friend WithEvents colPosition As ColumnHeader
    Friend WithEvents colWorkStatus As ColumnHeader
End Class
