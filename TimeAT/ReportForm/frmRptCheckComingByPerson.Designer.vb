<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptCheckComingByPerson
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptCheckComingByPerson))
        Me.j = New System.Windows.Forms.GroupBox
        Me.txtDateSP = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDateST = New System.Windows.Forms.MaskedTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNameSearch = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCode1 = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rdContractor = New System.Windows.Forms.RadioButton
        Me.rdDay = New System.Windows.Forms.RadioButton
        Me.rdMonth = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.cboCompany = New System.Windows.Forms.ComboBox
        Me.cboEmpGroup = New System.Windows.Forms.ComboBox
        Me.cboDivision = New System.Windows.Forms.ComboBox
        Me.cboPosition = New System.Windows.Forms.ComboBox
        Me.cboDepartment = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnReport = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.txtShowName = New System.Windows.Forms.TextBox
        Me.j.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'j
        '
        Me.j.Controls.Add(Me.txtDateSP)
        Me.j.Controls.Add(Me.Label1)
        Me.j.Controls.Add(Me.txtDateST)
        Me.j.Controls.Add(Me.Label9)
        resources.ApplyResources(Me.j, "j")
        Me.j.Name = "j"
        Me.j.TabStop = False
        '
        'txtDateSP
        '
        resources.ApplyResources(Me.txtDateSP, "txtDateSP")
        Me.txtDateSP.Name = "txtDateSP"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'txtDateST
        '
        resources.ApplyResources(Me.txtDateST, "txtDateST")
        Me.txtDateST.Name = "txtDateST"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.cboCompany)
        Me.GroupBox2.Controls.Add(Me.cboEmpGroup)
        Me.GroupBox2.Controls.Add(Me.cboDivision)
        Me.GroupBox2.Controls.Add(Me.cboPosition)
        Me.GroupBox2.Controls.Add(Me.cboDepartment)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtShowName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNameSearch)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCode1)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txtNameSearch
        '
        resources.ApplyResources(Me.txtNameSearch, "txtNameSearch")
        Me.txtNameSearch.Name = "txtNameSearch"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'txtCode1
        '
        resources.ApplyResources(Me.txtCode1, "txtCode1")
        Me.txtCode1.Name = "txtCode1"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rdContractor)
        Me.GroupBox5.Controls.Add(Me.rdDay)
        Me.GroupBox5.Controls.Add(Me.rdMonth)
        Me.GroupBox5.Controls.Add(Me.RadioButton1)
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
        'RadioButton1
        '
        resources.ApplyResources(Me.RadioButton1, "RadioButton1")
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = True
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
        'cboPosition
        '
        Me.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPosition.FormattingEnabled = True
        resources.ApplyResources(Me.cboPosition, "cboPosition")
        Me.cboPosition.Name = "cboPosition"
        '
        'cboDepartment
        '
        Me.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartment.FormattingEnabled = True
        resources.ApplyResources(Me.cboDepartment, "cboDepartment")
        Me.cboDepartment.Name = "cboDepartment"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
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
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
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
        'txtShowName
        '
        resources.ApplyResources(Me.txtShowName, "txtShowName")
        Me.txtShowName.Name = "txtShowName"
        Me.txtShowName.ReadOnly = True
        '
        'frmRptCheckComingByPerson
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.j)
        Me.KeyPreview = True
        Me.Name = "frmRptCheckComingByPerson"
        Me.j.ResumeLayout(False)
        Me.j.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents j As System.Windows.Forms.GroupBox
    Friend WithEvents txtDateST As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtDateSP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rdContractor As System.Windows.Forms.RadioButton
    Friend WithEvents rdDay As System.Windows.Forms.RadioButton
    Friend WithEvents rdMonth As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents cboCompany As System.Windows.Forms.ComboBox
    Friend WithEvents cboEmpGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cboDivision As System.Windows.Forms.ComboBox
    Friend WithEvents cboPosition As System.Windows.Forms.ComboBox
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNameSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCode1 As System.Windows.Forms.TextBox
    Friend WithEvents txtShowName As System.Windows.Forms.TextBox
End Class
