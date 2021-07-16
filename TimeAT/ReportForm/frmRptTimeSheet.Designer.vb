<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptTimeSheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptTimeSheet))
        Me.j = New System.Windows.Forms.GroupBox
        Me.txtMonthYear = New System.Windows.Forms.MaskedTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.rdByDeptName = New System.Windows.Forms.RadioButton
        Me.rdByDeptCode = New System.Windows.Forms.RadioButton
        Me.rdByName = New System.Windows.Forms.RadioButton
        Me.rdByCode = New System.Windows.Forms.RadioButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rdContractor = New System.Windows.Forms.RadioButton
        Me.rdDay = New System.Windows.Forms.RadioButton
        Me.rdMonth = New System.Windows.Forms.RadioButton
        Me.rdAll = New System.Windows.Forms.RadioButton
        Me.cboEmpGroup = New System.Windows.Forms.ComboBox
        Me.cboDivision = New System.Windows.Forms.ComboBox
        Me.cboPosition = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboDepartment = New System.Windows.Forms.ComboBox
        Me.cboCompany = New System.Windows.Forms.ComboBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnReport = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnNoneSelectALL = New System.Windows.Forms.Button
        Me.btnSelectALL = New System.Windows.Forms.Button
        Me.lstEMP = New System.Windows.Forms.ListView
        Me.colNo = New System.Windows.Forms.ColumnHeader
        Me.colCode = New System.Windows.Forms.ColumnHeader
        Me.colName = New System.Windows.Forms.ColumnHeader
        Me.colSName = New System.Windows.Forms.ColumnHeader
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rdEn = New System.Windows.Forms.RadioButton
        Me.rdTh = New System.Windows.Forms.RadioButton
        Me.j.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'j
        '
        Me.j.AccessibleDescription = Nothing
        Me.j.AccessibleName = Nothing
        resources.ApplyResources(Me.j, "j")
        Me.j.BackgroundImage = Nothing
        Me.j.Controls.Add(Me.txtMonthYear)
        Me.j.Controls.Add(Me.Label9)
        Me.j.Font = Nothing
        Me.j.Name = "j"
        Me.j.TabStop = False
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
        'Label9
        '
        Me.Label9.AccessibleDescription = Nothing
        Me.Label9.AccessibleName = Nothing
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Font = Nothing
        Me.Label9.Name = "Label9"
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleDescription = Nothing
        Me.GroupBox2.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.BackgroundImage = Nothing
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.cboEmpGroup)
        Me.GroupBox2.Controls.Add(Me.cboDivision)
        Me.GroupBox2.Controls.Add(Me.cboPosition)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cboDepartment)
        Me.GroupBox2.Controls.Add(Me.cboCompany)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtCode)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = Nothing
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.AccessibleDescription = Nothing
        Me.GroupBox6.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox6, "GroupBox6")
        Me.GroupBox6.BackgroundImage = Nothing
        Me.GroupBox6.Controls.Add(Me.rdByDeptName)
        Me.GroupBox6.Controls.Add(Me.rdByDeptCode)
        Me.GroupBox6.Controls.Add(Me.rdByName)
        Me.GroupBox6.Controls.Add(Me.rdByCode)
        Me.GroupBox6.Font = Nothing
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.TabStop = False
        '
        'rdByDeptName
        '
        Me.rdByDeptName.AccessibleDescription = Nothing
        Me.rdByDeptName.AccessibleName = Nothing
        resources.ApplyResources(Me.rdByDeptName, "rdByDeptName")
        Me.rdByDeptName.BackgroundImage = Nothing
        Me.rdByDeptName.Font = Nothing
        Me.rdByDeptName.Name = "rdByDeptName"
        Me.rdByDeptName.UseVisualStyleBackColor = True
        '
        'rdByDeptCode
        '
        Me.rdByDeptCode.AccessibleDescription = Nothing
        Me.rdByDeptCode.AccessibleName = Nothing
        resources.ApplyResources(Me.rdByDeptCode, "rdByDeptCode")
        Me.rdByDeptCode.BackgroundImage = Nothing
        Me.rdByDeptCode.Font = Nothing
        Me.rdByDeptCode.Name = "rdByDeptCode"
        Me.rdByDeptCode.UseVisualStyleBackColor = True
        '
        'rdByName
        '
        Me.rdByName.AccessibleDescription = Nothing
        Me.rdByName.AccessibleName = Nothing
        resources.ApplyResources(Me.rdByName, "rdByName")
        Me.rdByName.BackgroundImage = Nothing
        Me.rdByName.Font = Nothing
        Me.rdByName.Name = "rdByName"
        Me.rdByName.UseVisualStyleBackColor = True
        '
        'rdByCode
        '
        Me.rdByCode.AccessibleDescription = Nothing
        Me.rdByCode.AccessibleName = Nothing
        resources.ApplyResources(Me.rdByCode, "rdByCode")
        Me.rdByCode.BackgroundImage = Nothing
        Me.rdByCode.Checked = True
        Me.rdByCode.Font = Nothing
        Me.rdByCode.Name = "rdByCode"
        Me.rdByCode.TabStop = True
        Me.rdByCode.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.AccessibleDescription = Nothing
        Me.GroupBox5.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.BackgroundImage = Nothing
        Me.GroupBox5.Controls.Add(Me.rdContractor)
        Me.GroupBox5.Controls.Add(Me.rdDay)
        Me.GroupBox5.Controls.Add(Me.rdMonth)
        Me.GroupBox5.Controls.Add(Me.rdAll)
        Me.GroupBox5.Font = Nothing
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        '
        'rdContractor
        '
        Me.rdContractor.AccessibleDescription = Nothing
        Me.rdContractor.AccessibleName = Nothing
        resources.ApplyResources(Me.rdContractor, "rdContractor")
        Me.rdContractor.BackgroundImage = Nothing
        Me.rdContractor.Font = Nothing
        Me.rdContractor.Name = "rdContractor"
        Me.rdContractor.UseVisualStyleBackColor = True
        '
        'rdDay
        '
        Me.rdDay.AccessibleDescription = Nothing
        Me.rdDay.AccessibleName = Nothing
        resources.ApplyResources(Me.rdDay, "rdDay")
        Me.rdDay.BackgroundImage = Nothing
        Me.rdDay.Font = Nothing
        Me.rdDay.Name = "rdDay"
        Me.rdDay.UseVisualStyleBackColor = True
        '
        'rdMonth
        '
        Me.rdMonth.AccessibleDescription = Nothing
        Me.rdMonth.AccessibleName = Nothing
        resources.ApplyResources(Me.rdMonth, "rdMonth")
        Me.rdMonth.BackgroundImage = Nothing
        Me.rdMonth.Font = Nothing
        Me.rdMonth.Name = "rdMonth"
        Me.rdMonth.UseVisualStyleBackColor = True
        '
        'rdAll
        '
        Me.rdAll.AccessibleDescription = Nothing
        Me.rdAll.AccessibleName = Nothing
        resources.ApplyResources(Me.rdAll, "rdAll")
        Me.rdAll.BackgroundImage = Nothing
        Me.rdAll.Checked = True
        Me.rdAll.Font = Nothing
        Me.rdAll.Name = "rdAll"
        Me.rdAll.TabStop = True
        Me.rdAll.UseVisualStyleBackColor = True
        '
        'cboEmpGroup
        '
        Me.cboEmpGroup.AccessibleDescription = Nothing
        Me.cboEmpGroup.AccessibleName = Nothing
        resources.ApplyResources(Me.cboEmpGroup, "cboEmpGroup")
        Me.cboEmpGroup.BackgroundImage = Nothing
        Me.cboEmpGroup.Font = Nothing
        Me.cboEmpGroup.FormattingEnabled = True
        Me.cboEmpGroup.Name = "cboEmpGroup"
        '
        'cboDivision
        '
        Me.cboDivision.AccessibleDescription = Nothing
        Me.cboDivision.AccessibleName = Nothing
        resources.ApplyResources(Me.cboDivision, "cboDivision")
        Me.cboDivision.BackgroundImage = Nothing
        Me.cboDivision.Font = Nothing
        Me.cboDivision.FormattingEnabled = True
        Me.cboDivision.Name = "cboDivision"
        '
        'cboPosition
        '
        Me.cboPosition.AccessibleDescription = Nothing
        Me.cboPosition.AccessibleName = Nothing
        resources.ApplyResources(Me.cboPosition, "cboPosition")
        Me.cboPosition.BackgroundImage = Nothing
        Me.cboPosition.Font = Nothing
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Name = "cboPosition"
        '
        'Label6
        '
        Me.Label6.AccessibleDescription = Nothing
        Me.Label6.AccessibleName = Nothing
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Font = Nothing
        Me.Label6.Name = "Label6"
        '
        'Label7
        '
        Me.Label7.AccessibleDescription = Nothing
        Me.Label7.AccessibleName = Nothing
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Font = Nothing
        Me.Label7.Name = "Label7"
        '
        'Label8
        '
        Me.Label8.AccessibleDescription = Nothing
        Me.Label8.AccessibleName = Nothing
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Font = Nothing
        Me.Label8.Name = "Label8"
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = Nothing
        Me.Label4.AccessibleName = Nothing
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Font = Nothing
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Font = Nothing
        Me.Label3.Name = "Label3"
        '
        'cboDepartment
        '
        Me.cboDepartment.AccessibleDescription = Nothing
        Me.cboDepartment.AccessibleName = Nothing
        resources.ApplyResources(Me.cboDepartment, "cboDepartment")
        Me.cboDepartment.BackgroundImage = Nothing
        Me.cboDepartment.Font = Nothing
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Name = "cboDepartment"
        '
        'cboCompany
        '
        Me.cboCompany.AccessibleDescription = Nothing
        Me.cboCompany.AccessibleName = Nothing
        resources.ApplyResources(Me.cboCompany, "cboCompany")
        Me.cboCompany.BackgroundImage = Nothing
        Me.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompany.Font = Nothing
        Me.cboCompany.FormattingEnabled = True
        Me.cboCompany.Name = "cboCompany"
        '
        'btnSearch
        '
        Me.btnSearch.AccessibleDescription = Nothing
        Me.btnSearch.AccessibleName = Nothing
        resources.ApplyResources(Me.btnSearch, "btnSearch")
        Me.btnSearch.BackgroundImage = Nothing
        Me.btnSearch.Font = Nothing
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.AccessibleDescription = Nothing
        Me.txtName.AccessibleName = Nothing
        resources.ApplyResources(Me.txtName, "txtName")
        Me.txtName.BackgroundImage = Nothing
        Me.txtName.Font = Nothing
        Me.txtName.Name = "txtName"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Font = Nothing
        Me.Label2.Name = "Label2"
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
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Font = Nothing
        Me.Label1.Name = "Label1"
        '
        'btnReport
        '
        Me.btnReport.AccessibleDescription = Nothing
        Me.btnReport.AccessibleName = Nothing
        resources.ApplyResources(Me.btnReport, "btnReport")
        Me.btnReport.BackgroundImage = Nothing
        Me.btnReport.Font = Nothing
        Me.btnReport.Name = "btnReport"
        Me.btnReport.UseVisualStyleBackColor = True
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
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = Nothing
        Me.GroupBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackgroundImage = Nothing
        Me.GroupBox1.Controls.Add(Me.btnNoneSelectALL)
        Me.GroupBox1.Controls.Add(Me.btnSelectALL)
        Me.GroupBox1.Controls.Add(Me.lstEMP)
        Me.GroupBox1.Font = Nothing
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'btnNoneSelectALL
        '
        Me.btnNoneSelectALL.AccessibleDescription = Nothing
        Me.btnNoneSelectALL.AccessibleName = Nothing
        resources.ApplyResources(Me.btnNoneSelectALL, "btnNoneSelectALL")
        Me.btnNoneSelectALL.BackgroundImage = Nothing
        Me.btnNoneSelectALL.Font = Nothing
        Me.btnNoneSelectALL.Name = "btnNoneSelectALL"
        Me.btnNoneSelectALL.UseVisualStyleBackColor = True
        '
        'btnSelectALL
        '
        Me.btnSelectALL.AccessibleDescription = Nothing
        Me.btnSelectALL.AccessibleName = Nothing
        resources.ApplyResources(Me.btnSelectALL, "btnSelectALL")
        Me.btnSelectALL.BackgroundImage = Nothing
        Me.btnSelectALL.Font = Nothing
        Me.btnSelectALL.Name = "btnSelectALL"
        Me.btnSelectALL.UseVisualStyleBackColor = True
        '
        'lstEMP
        '
        Me.lstEMP.AccessibleDescription = Nothing
        Me.lstEMP.AccessibleName = Nothing
        resources.ApplyResources(Me.lstEMP, "lstEMP")
        Me.lstEMP.BackgroundImage = Nothing
        Me.lstEMP.CheckBoxes = True
        Me.lstEMP.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNo, Me.colCode, Me.colName, Me.colSName})
        Me.lstEMP.Font = Nothing
        Me.lstEMP.GridLines = True
        Me.lstEMP.Name = "lstEMP"
        Me.lstEMP.UseCompatibleStateImageBehavior = False
        Me.lstEMP.View = System.Windows.Forms.View.Details
        '
        'colNo
        '
        resources.ApplyResources(Me.colNo, "colNo")
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
        'GroupBox3
        '
        Me.GroupBox3.AccessibleDescription = Nothing
        Me.GroupBox3.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.BackgroundImage = Nothing
        Me.GroupBox3.Controls.Add(Me.rdEn)
        Me.GroupBox3.Controls.Add(Me.rdTh)
        Me.GroupBox3.Font = Nothing
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'rdEn
        '
        Me.rdEn.AccessibleDescription = Nothing
        Me.rdEn.AccessibleName = Nothing
        resources.ApplyResources(Me.rdEn, "rdEn")
        Me.rdEn.BackgroundImage = Nothing
        Me.rdEn.Font = Nothing
        Me.rdEn.Name = "rdEn"
        Me.rdEn.UseVisualStyleBackColor = True
        '
        'rdTh
        '
        Me.rdTh.AccessibleDescription = Nothing
        Me.rdTh.AccessibleName = Nothing
        resources.ApplyResources(Me.rdTh, "rdTh")
        Me.rdTh.BackgroundImage = Nothing
        Me.rdTh.Checked = True
        Me.rdTh.Font = Nothing
        Me.rdTh.Name = "rdTh"
        Me.rdTh.TabStop = True
        Me.rdTh.UseVisualStyleBackColor = True
        '
        'frmRptTimeSheet
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.j)
        Me.Font = Nothing
        Me.Icon = Nothing
        Me.KeyPreview = True
        Me.Name = "frmRptTimeSheet"
        Me.j.ResumeLayout(False)
        Me.j.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents j As System.Windows.Forms.GroupBox
    Friend WithEvents txtMonthYear As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstEMP As System.Windows.Forms.ListView
    Friend WithEvents colNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colSName As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnNoneSelectALL As System.Windows.Forms.Button
    Friend WithEvents btnSelectALL As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdTh As System.Windows.Forms.RadioButton
    Friend WithEvents rdEn As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rdContractor As System.Windows.Forms.RadioButton
    Friend WithEvents rdDay As System.Windows.Forms.RadioButton
    Friend WithEvents rdMonth As System.Windows.Forms.RadioButton
    Friend WithEvents rdAll As System.Windows.Forms.RadioButton
    Friend WithEvents cboEmpGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cboDivision As System.Windows.Forms.ComboBox
    Friend WithEvents cboPosition As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents cboCompany As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rdByDeptName As System.Windows.Forms.RadioButton
    Friend WithEvents rdByDeptCode As System.Windows.Forms.RadioButton
    Friend WithEvents rdByName As System.Windows.Forms.RadioButton
    Friend WithEvents rdByCode As System.Windows.Forms.RadioButton
End Class
