<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptTimeSumAbsentLate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptTimeSumAbsentLate))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboMonth = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDateSp = New System.Windows.Forms.MaskedTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDateSt = New System.Windows.Forms.MaskedTextBox
        Me.txtYear = New System.Windows.Forms.TextBox
        Me.btnReport = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cboCompany = New System.Windows.Forms.ComboBox
        Me.cboEmpGroup = New System.Windows.Forms.ComboBox
        Me.cboDivision = New System.Windows.Forms.ComboBox
        Me.cboDepartment = New System.Windows.Forms.ComboBox
        Me.cboPosition = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rdContractor = New System.Windows.Forms.RadioButton
        Me.rdDay = New System.Windows.Forms.RadioButton
        Me.rdMonth = New System.Windows.Forms.RadioButton
        Me.rdAll = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNameSearch = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCode1 = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboMonth)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDateSp)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDateSt)
        Me.GroupBox1.Controls.Add(Me.txtYear)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.FormattingEnabled = True
        resources.ApplyResources(Me.cboMonth, "cboMonth")
        Me.cboMonth.Name = "cboMonth"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txtDateSp
        '
        resources.ApplyResources(Me.txtDateSp, "txtDateSp")
        Me.txtDateSp.Name = "txtDateSp"
        Me.txtDateSp.ValidatingType = GetType(Date)
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'txtDateSt
        '
        resources.ApplyResources(Me.txtDateSt, "txtDateSt")
        Me.txtDateSt.Name = "txtDateSt"
        Me.txtDateSt.ValidatingType = GetType(Date)
        '
        'txtYear
        '
        resources.ApplyResources(Me.txtYear, "txtYear")
        Me.txtYear.Name = "txtYear"
        '
        'btnReport
        '
        resources.ApplyResources(Me.btnReport, "btnReport")
        Me.btnReport.Name = "btnReport"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.Name = "btnExit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboCompany)
        Me.GroupBox2.Controls.Add(Me.cboEmpGroup)
        Me.GroupBox2.Controls.Add(Me.cboDivision)
        Me.GroupBox2.Controls.Add(Me.cboDepartment)
        Me.GroupBox2.Controls.Add(Me.cboPosition)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'cboCompany
        '
        Me.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompany.FormattingEnabled = True
        resources.ApplyResources(Me.cboCompany, "cboCompany")
        Me.cboCompany.Name = "cboCompany"
        '
        'cboEmpGroup
        '
        Me.cboEmpGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpGroup.FormattingEnabled = True
        resources.ApplyResources(Me.cboEmpGroup, "cboEmpGroup")
        Me.cboEmpGroup.Name = "cboEmpGroup"
        '
        'cboDivision
        '
        Me.cboDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivision.FormattingEnabled = True
        resources.ApplyResources(Me.cboDivision, "cboDivision")
        Me.cboDivision.Name = "cboDivision"
        '
        'cboDepartment
        '
        Me.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartment.FormattingEnabled = True
        resources.ApplyResources(Me.cboDepartment, "cboDepartment")
        Me.cboDepartment.Name = "cboDepartment"
        '
        'cboPosition
        '
        Me.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPosition.FormattingEnabled = True
        resources.ApplyResources(Me.cboPosition, "cboPosition")
        Me.cboPosition.Name = "cboPosition"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rdContractor)
        Me.GroupBox5.Controls.Add(Me.rdDay)
        Me.GroupBox5.Controls.Add(Me.rdMonth)
        Me.GroupBox5.Controls.Add(Me.rdAll)
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        '
        'rdContractor
        '
        resources.ApplyResources(Me.rdContractor, "rdContractor")
        Me.rdContractor.Name = "rdContractor"
        Me.rdContractor.UseVisualStyleBackColor = True
        '
        'rdDay
        '
        resources.ApplyResources(Me.rdDay, "rdDay")
        Me.rdDay.Name = "rdDay"
        Me.rdDay.UseVisualStyleBackColor = True
        '
        'rdMonth
        '
        resources.ApplyResources(Me.rdMonth, "rdMonth")
        Me.rdMonth.Name = "rdMonth"
        Me.rdMonth.UseVisualStyleBackColor = True
        '
        'rdAll
        '
        resources.ApplyResources(Me.rdAll, "rdAll")
        Me.rdAll.Checked = True
        Me.rdAll.Name = "rdAll"
        Me.rdAll.TabStop = True
        Me.rdAll.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtNameSearch)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtCode1)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'txtNameSearch
        '
        resources.ApplyResources(Me.txtNameSearch, "txtNameSearch")
        Me.txtNameSearch.Name = "txtNameSearch"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'txtCode1
        '
        resources.ApplyResources(Me.txtCode1, "txtCode1")
        Me.txtCode1.Name = "txtCode1"
        '
        'frmRptTimeSumAbsentLate
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRptTimeSumAbsentLate"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDateSp As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDateSt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCompany As System.Windows.Forms.ComboBox
    Friend WithEvents cboEmpGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cboDivision As System.Windows.Forms.ComboBox
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents cboPosition As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rdContractor As System.Windows.Forms.RadioButton
    Friend WithEvents rdDay As System.Windows.Forms.RadioButton
    Friend WithEvents rdMonth As System.Windows.Forms.RadioButton
    Friend WithEvents rdAll As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNameSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCode1 As System.Windows.Forms.TextBox
End Class
