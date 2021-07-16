<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNo = New System.Windows.Forms.TextBox
        Me.txtStaffId = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnSetPermission = New System.Windows.Forms.Button
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtConPass = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtLname = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lstDepartment = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.colUsername = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Font = Nothing
        Me.Label1.Name = "Label1"
        '
        'txtNo
        '
        Me.txtNo.AccessibleDescription = Nothing
        Me.txtNo.AccessibleName = Nothing
        resources.ApplyResources(Me.txtNo, "txtNo")
        Me.txtNo.BackgroundImage = Nothing
        Me.txtNo.Font = Nothing
        Me.txtNo.Name = "txtNo"
        Me.txtNo.ReadOnly = True
        Me.txtNo.TabStop = False
        '
        'txtStaffId
        '
        Me.txtStaffId.AccessibleDescription = Nothing
        Me.txtStaffId.AccessibleName = Nothing
        resources.ApplyResources(Me.txtStaffId, "txtStaffId")
        Me.txtStaffId.BackgroundImage = Nothing
        Me.txtStaffId.Font = Nothing
        Me.txtStaffId.Name = "txtStaffId"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Font = Nothing
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Font = Nothing
        Me.Label3.Name = "Label3"
        '
        'txtFirstName
        '
        Me.txtFirstName.AccessibleDescription = Nothing
        Me.txtFirstName.AccessibleName = Nothing
        resources.ApplyResources(Me.txtFirstName, "txtFirstName")
        Me.txtFirstName.BackgroundImage = Nothing
        Me.txtFirstName.Font = Nothing
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleDescription = Nothing
        Me.btnAdd.AccessibleName = Nothing
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        Me.btnAdd.BackgroundImage = Nothing
        Me.btnAdd.Font = Nothing
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = Nothing
        Me.GroupBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackgroundImage = Nothing
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtConPass)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtLname)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtStaffId)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNo)
        Me.GroupBox1.Font = Nothing
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleDescription = Nothing
        Me.GroupBox2.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.BackgroundImage = Nothing
        Me.GroupBox2.Controls.Add(Me.btnSetPermission)
        Me.GroupBox2.Controls.Add(Me.txtUsername)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = Nothing
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'btnSetPermission
        '
        Me.btnSetPermission.AccessibleDescription = Nothing
        Me.btnSetPermission.AccessibleName = Nothing
        resources.ApplyResources(Me.btnSetPermission, "btnSetPermission")
        Me.btnSetPermission.BackgroundImage = Nothing
        Me.btnSetPermission.Font = Nothing
        Me.btnSetPermission.Name = "btnSetPermission"
        Me.btnSetPermission.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.AccessibleDescription = Nothing
        Me.txtUsername.AccessibleName = Nothing
        resources.ApplyResources(Me.txtUsername, "txtUsername")
        Me.txtUsername.BackgroundImage = Nothing
        Me.txtUsername.Font = Nothing
        Me.txtUsername.Name = "txtUsername"
        '
        'Label7
        '
        Me.Label7.AccessibleDescription = Nothing
        Me.Label7.AccessibleName = Nothing
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Font = Nothing
        Me.Label7.Name = "Label7"
        '
        'txtConPass
        '
        Me.txtConPass.AccessibleDescription = Nothing
        Me.txtConPass.AccessibleName = Nothing
        resources.ApplyResources(Me.txtConPass, "txtConPass")
        Me.txtConPass.BackgroundImage = Nothing
        Me.txtConPass.Font = Nothing
        Me.txtConPass.Name = "txtConPass"
        Me.txtConPass.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AccessibleDescription = Nothing
        Me.Label5.AccessibleName = Nothing
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Font = Nothing
        Me.Label5.Name = "Label5"
        '
        'txtPassword
        '
        Me.txtPassword.AccessibleDescription = Nothing
        Me.txtPassword.AccessibleName = Nothing
        resources.ApplyResources(Me.txtPassword, "txtPassword")
        Me.txtPassword.BackgroundImage = Nothing
        Me.txtPassword.Font = Nothing
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtLname
        '
        Me.txtLname.AccessibleDescription = Nothing
        Me.txtLname.AccessibleName = Nothing
        resources.ApplyResources(Me.txtLname, "txtLname")
        Me.txtLname.BackgroundImage = Nothing
        Me.txtLname.Font = Nothing
        Me.txtLname.Name = "txtLname"
        Me.txtLname.ReadOnly = True
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = Nothing
        Me.Label4.AccessibleName = Nothing
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Font = Nothing
        Me.Label4.Name = "Label4"
        '
        'Label6
        '
        Me.Label6.AccessibleDescription = Nothing
        Me.Label6.AccessibleName = Nothing
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Font = Nothing
        Me.Label6.Name = "Label6"
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleDescription = Nothing
        Me.btnEdit.AccessibleName = Nothing
        resources.ApplyResources(Me.btnEdit, "btnEdit")
        Me.btnEdit.BackgroundImage = Nothing
        Me.btnEdit.Font = Nothing
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleDescription = Nothing
        Me.btnDelete.AccessibleName = Nothing
        resources.ApplyResources(Me.btnDelete, "btnDelete")
        Me.btnDelete.BackgroundImage = Nothing
        Me.btnDelete.Font = Nothing
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.UseVisualStyleBackColor = True
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
        'lstDepartment
        '
        Me.lstDepartment.AccessibleDescription = Nothing
        Me.lstDepartment.AccessibleName = Nothing
        resources.ApplyResources(Me.lstDepartment, "lstDepartment")
        Me.lstDepartment.BackgroundImage = Nothing
        Me.lstDepartment.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.colUsername})
        Me.lstDepartment.Font = Nothing
        Me.lstDepartment.FullRowSelect = True
        Me.lstDepartment.GridLines = True
        Me.lstDepartment.Name = "lstDepartment"
        Me.lstDepartment.UseCompatibleStateImageBehavior = False
        Me.lstDepartment.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        resources.ApplyResources(Me.ColumnHeader1, "ColumnHeader1")
        '
        'ColumnHeader2
        '
        resources.ApplyResources(Me.ColumnHeader2, "ColumnHeader2")
        '
        'ColumnHeader3
        '
        resources.ApplyResources(Me.ColumnHeader3, "ColumnHeader3")
        '
        'ColumnHeader4
        '
        resources.ApplyResources(Me.ColumnHeader4, "ColumnHeader4")
        '
        'colUsername
        '
        resources.ApplyResources(Me.colUsername, "colUsername")
        '
        'frmUser
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.lstDepartment)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = Nothing
        Me.Icon = Nothing
        Me.KeyPreview = True
        Me.Name = "frmUser"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtStaffId As System.Windows.Forms.TextBox
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lstDepartment As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSetPermission As System.Windows.Forms.Button
    Friend WithEvents colUsername As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtConPass As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
