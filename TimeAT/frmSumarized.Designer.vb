<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSumarized
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSumarized))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.txtMonthYear = New System.Windows.Forms.MaskedTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lblDeptId = New System.Windows.Forms.Label
        Me.cboDepartment = New System.Windows.Forms.ComboBox
        Me.cboSite = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtLname = New System.Windows.Forms.TextBox
        Me.txtFname = New System.Windows.Forms.TextBox
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.rdDept = New System.Windows.Forms.RadioButton
        Me.rdName = New System.Windows.Forms.RadioButton
        Me.rdCode = New System.Windows.Forms.RadioButton
        Me.lstSumaried = New System.Windows.Forms.ListView
        Me.colNo = New System.Windows.Forms.ColumnHeader
        Me.colDate = New System.Windows.Forms.ColumnHeader
        Me.colCode = New System.Windows.Forms.ColumnHeader
        Me.colName = New System.Windows.Forms.ColumnHeader
        Me.colDepartment = New System.Windows.Forms.ColumnHeader
        Me.Late = New System.Windows.Forms.ColumnHeader
        Me.colLatOut = New System.Windows.Forms.ColumnHeader
        Me.colRecording = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuChkOvertime = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCheckLate = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCheckAbsent = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCheckAllowance = New System.Windows.Forms.ToolStripMenuItem
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = Nothing
        Me.GroupBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackgroundImage = Nothing
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.txtMonthYear)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = Nothing
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.AccessibleDescription = Nothing
        Me.btnExit.AccessibleName = Nothing
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.BackgroundImage = Nothing
        Me.btnExit.Font = Nothing
        Me.btnExit.Name = "btnExit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtMonthYear
        '
        Me.txtMonthYear.AccessibleDescription = Nothing
        Me.txtMonthYear.AccessibleName = Nothing
        resources.ApplyResources(Me.txtMonthYear, "txtMonthYear")
        Me.txtMonthYear.BackgroundImage = Nothing
        Me.txtMonthYear.Font = Nothing
        Me.txtMonthYear.Name = "txtMonthYear"
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Font = Nothing
        Me.Label3.Name = "Label3"
        '
        'GroupBox4
        '
        Me.GroupBox4.AccessibleDescription = Nothing
        Me.GroupBox4.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.BackgroundImage = Nothing
        Me.GroupBox4.Controls.Add(Me.lblDeptId)
        Me.GroupBox4.Controls.Add(Me.cboDepartment)
        Me.GroupBox4.Controls.Add(Me.cboSite)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.btnSearch)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtLname)
        Me.GroupBox4.Controls.Add(Me.txtFname)
        Me.GroupBox4.Controls.Add(Me.txtCode)
        Me.GroupBox4.Font = Nothing
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'lblDeptId
        '
        Me.lblDeptId.AccessibleDescription = Nothing
        Me.lblDeptId.AccessibleName = Nothing
        resources.ApplyResources(Me.lblDeptId, "lblDeptId")
        Me.lblDeptId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDeptId.Font = Nothing
        Me.lblDeptId.Name = "lblDeptId"
        '
        'cboDepartment
        '
        Me.cboDepartment.AccessibleDescription = Nothing
        Me.cboDepartment.AccessibleName = Nothing
        resources.ApplyResources(Me.cboDepartment, "cboDepartment")
        Me.cboDepartment.BackgroundImage = Nothing
        Me.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartment.Font = Nothing
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Name = "cboDepartment"
        '
        'cboSite
        '
        Me.cboSite.AccessibleDescription = Nothing
        Me.cboSite.AccessibleName = Nothing
        resources.ApplyResources(Me.cboSite, "cboSite")
        Me.cboSite.BackgroundImage = Nothing
        Me.cboSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSite.Font = Nothing
        Me.cboSite.FormattingEnabled = True
        Me.cboSite.Name = "cboSite"
        '
        'Label8
        '
        Me.Label8.AccessibleDescription = Nothing
        Me.Label8.AccessibleName = Nothing
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Font = Nothing
        Me.Label8.Name = "Label8"
        '
        'Label7
        '
        Me.Label7.AccessibleDescription = Nothing
        Me.Label7.AccessibleName = Nothing
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Font = Nothing
        Me.Label7.Name = "Label7"
        '
        'btnSearch
        '
        Me.btnSearch.AccessibleDescription = Nothing
        Me.btnSearch.AccessibleName = Nothing
        resources.ApplyResources(Me.btnSearch, "btnSearch")
        Me.btnSearch.BackColor = System.Drawing.Color.MistyRose
        Me.btnSearch.BackgroundImage = Nothing
        Me.btnSearch.Font = Nothing
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AccessibleDescription = Nothing
        Me.Label6.AccessibleName = Nothing
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Font = Nothing
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        Me.Label5.AccessibleDescription = Nothing
        Me.Label5.AccessibleName = Nothing
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Font = Nothing
        Me.Label5.Name = "Label5"
        '
        'txtLname
        '
        Me.txtLname.AccessibleDescription = Nothing
        Me.txtLname.AccessibleName = Nothing
        resources.ApplyResources(Me.txtLname, "txtLname")
        Me.txtLname.BackgroundImage = Nothing
        Me.txtLname.Font = Nothing
        Me.txtLname.Name = "txtLname"
        '
        'txtFname
        '
        Me.txtFname.AccessibleDescription = Nothing
        Me.txtFname.AccessibleName = Nothing
        resources.ApplyResources(Me.txtFname, "txtFname")
        Me.txtFname.BackgroundImage = Nothing
        Me.txtFname.Font = Nothing
        Me.txtFname.Name = "txtFname"
        '
        'txtCode
        '
        Me.txtCode.AccessibleDescription = Nothing
        Me.txtCode.AccessibleName = Nothing
        resources.ApplyResources(Me.txtCode, "txtCode")
        Me.txtCode.BackgroundImage = Nothing
        Me.txtCode.Font = Nothing
        Me.txtCode.Name = "txtCode"
        '
        'GroupBox3
        '
        Me.GroupBox3.AccessibleDescription = Nothing
        Me.GroupBox3.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.BackgroundImage = Nothing
        Me.GroupBox3.Controls.Add(Me.btnRefresh)
        Me.GroupBox3.Controls.Add(Me.rdDept)
        Me.GroupBox3.Controls.Add(Me.rdName)
        Me.GroupBox3.Controls.Add(Me.rdCode)
        Me.GroupBox3.Font = Nothing
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.AccessibleDescription = Nothing
        Me.btnRefresh.AccessibleName = Nothing
        resources.ApplyResources(Me.btnRefresh, "btnRefresh")
        Me.btnRefresh.BackgroundImage = Nothing
        Me.btnRefresh.Font = Nothing
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'rdDept
        '
        Me.rdDept.AccessibleDescription = Nothing
        Me.rdDept.AccessibleName = Nothing
        resources.ApplyResources(Me.rdDept, "rdDept")
        Me.rdDept.BackgroundImage = Nothing
        Me.rdDept.Font = Nothing
        Me.rdDept.Name = "rdDept"
        Me.rdDept.UseVisualStyleBackColor = True
        '
        'rdName
        '
        Me.rdName.AccessibleDescription = Nothing
        Me.rdName.AccessibleName = Nothing
        resources.ApplyResources(Me.rdName, "rdName")
        Me.rdName.BackgroundImage = Nothing
        Me.rdName.Font = Nothing
        Me.rdName.Name = "rdName"
        Me.rdName.UseVisualStyleBackColor = True
        '
        'rdCode
        '
        Me.rdCode.AccessibleDescription = Nothing
        Me.rdCode.AccessibleName = Nothing
        resources.ApplyResources(Me.rdCode, "rdCode")
        Me.rdCode.BackgroundImage = Nothing
        Me.rdCode.Checked = True
        Me.rdCode.Font = Nothing
        Me.rdCode.Name = "rdCode"
        Me.rdCode.TabStop = True
        Me.rdCode.UseVisualStyleBackColor = True
        '
        'lstSumaried
        '
        Me.lstSumaried.AccessibleDescription = Nothing
        Me.lstSumaried.AccessibleName = Nothing
        resources.ApplyResources(Me.lstSumaried, "lstSumaried")
        Me.lstSumaried.BackgroundImage = Nothing
        Me.lstSumaried.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNo, Me.colDate, Me.colCode, Me.colName, Me.colDepartment, Me.Late, Me.colLatOut, Me.colRecording})
        Me.lstSumaried.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lstSumaried.Font = Nothing
        Me.lstSumaried.FullRowSelect = True
        Me.lstSumaried.GridLines = True
        Me.lstSumaried.Name = "lstSumaried"
        Me.lstSumaried.UseCompatibleStateImageBehavior = False
        Me.lstSumaried.View = System.Windows.Forms.View.Details
        '
        'colNo
        '
        resources.ApplyResources(Me.colNo, "colNo")
        '
        'colDate
        '
        resources.ApplyResources(Me.colDate, "colDate")
        '
        'colCode
        '
        resources.ApplyResources(Me.colCode, "colCode")
        '
        'colName
        '
        resources.ApplyResources(Me.colName, "colName")
        '
        'colDepartment
        '
        resources.ApplyResources(Me.colDepartment, "colDepartment")
        '
        'Late
        '
        resources.ApplyResources(Me.Late, "Late")
        '
        'colLatOut
        '
        resources.ApplyResources(Me.colLatOut, "colLatOut")
        '
        'colRecording
        '
        resources.ApplyResources(Me.colRecording, "colRecording")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.AccessibleDescription = Nothing
        Me.ContextMenuStrip1.AccessibleName = Nothing
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        Me.ContextMenuStrip1.BackgroundImage = Nothing
        Me.ContextMenuStrip1.Font = Nothing
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuChkOvertime, Me.mnuCheckLate, Me.mnuCheckAbsent, Me.mnuCheckAllowance})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        '
        'mnuChkOvertime
        '
        Me.mnuChkOvertime.AccessibleDescription = Nothing
        Me.mnuChkOvertime.AccessibleName = Nothing
        resources.ApplyResources(Me.mnuChkOvertime, "mnuChkOvertime")
        Me.mnuChkOvertime.BackgroundImage = Nothing
        Me.mnuChkOvertime.Name = "mnuChkOvertime"
        Me.mnuChkOvertime.ShortcutKeyDisplayString = Nothing
        '
        'mnuCheckLate
        '
        Me.mnuCheckLate.AccessibleDescription = Nothing
        Me.mnuCheckLate.AccessibleName = Nothing
        resources.ApplyResources(Me.mnuCheckLate, "mnuCheckLate")
        Me.mnuCheckLate.BackgroundImage = Nothing
        Me.mnuCheckLate.Name = "mnuCheckLate"
        Me.mnuCheckLate.ShortcutKeyDisplayString = Nothing
        '
        'mnuCheckAbsent
        '
        Me.mnuCheckAbsent.AccessibleDescription = Nothing
        Me.mnuCheckAbsent.AccessibleName = Nothing
        resources.ApplyResources(Me.mnuCheckAbsent, "mnuCheckAbsent")
        Me.mnuCheckAbsent.BackgroundImage = Nothing
        Me.mnuCheckAbsent.Name = "mnuCheckAbsent"
        Me.mnuCheckAbsent.ShortcutKeyDisplayString = Nothing
        '
        'mnuCheckAllowance
        '
        Me.mnuCheckAllowance.AccessibleDescription = Nothing
        Me.mnuCheckAllowance.AccessibleName = Nothing
        resources.ApplyResources(Me.mnuCheckAllowance, "mnuCheckAllowance")
        Me.mnuCheckAllowance.BackgroundImage = Nothing
        Me.mnuCheckAllowance.Name = "mnuCheckAllowance"
        Me.mnuCheckAllowance.ShortcutKeyDisplayString = Nothing
        '
        'ProgressBar1
        '
        Me.ProgressBar1.AccessibleDescription = Nothing
        Me.ProgressBar1.AccessibleName = Nothing
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        Me.ProgressBar1.BackgroundImage = Nothing
        Me.ProgressBar1.Font = Nothing
        Me.ProgressBar1.Name = "ProgressBar1"
        '
        'frmSumarized
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lstSumaried)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = Nothing
        Me.Icon = Nothing
        Me.Name = "frmSumarized"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMonthYear As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDeptId As System.Windows.Forms.Label
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents cboSite As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdDept As System.Windows.Forms.RadioButton
    Friend WithEvents rdName As System.Windows.Forms.RadioButton
    Friend WithEvents rdCode As System.Windows.Forms.RadioButton
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lstSumaried As System.Windows.Forms.ListView
    Friend WithEvents colNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDepartment As System.Windows.Forms.ColumnHeader
    Friend WithEvents Late As System.Windows.Forms.ColumnHeader
    Friend WithEvents colLatOut As System.Windows.Forms.ColumnHeader
    Friend WithEvents colRecording As System.Windows.Forms.ColumnHeader
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuChkOvertime As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCheckLate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCheckAbsent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCheckAllowance As System.Windows.Forms.ToolStripMenuItem
End Class
