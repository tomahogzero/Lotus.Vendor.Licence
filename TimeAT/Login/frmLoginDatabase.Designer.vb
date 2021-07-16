<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoginDatabase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginDatabase))
        Me.cboLang = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtPassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtDatabaseName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtServerName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtUserName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.btnExit = New DevComponents.DotNetBar.ButtonX()
        Me.btnLogIn = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboLang
        '
        Me.cboLang.DisplayMember = "Text"
        Me.cboLang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboLang.FormattingEnabled = True
        Me.cboLang.ItemHeight = 14
        Me.cboLang.Location = New System.Drawing.Point(278, 124)
        Me.cboLang.Name = "cboLang"
        Me.cboLang.Size = New System.Drawing.Size(124, 20)
        Me.cboLang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboLang.TabIndex = 19
        Me.cboLang.Visible = False
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(168, 127)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(104, 17)
        Me.LabelX5.TabIndex = 20
        Me.LabelX5.Text = "Language : "
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        Me.LabelX5.Visible = False
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.Border.Class = "TextBoxBorder"
        Me.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(278, 98)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(124, 20)
        Me.txtPassword.TabIndex = 16
        '
        'txtDatabaseName
        '
        '
        '
        '
        Me.txtDatabaseName.Border.Class = "TextBoxBorder"
        Me.txtDatabaseName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDatabaseName.Location = New System.Drawing.Point(278, 46)
        Me.txtDatabaseName.Name = "txtDatabaseName"
        Me.txtDatabaseName.Size = New System.Drawing.Size(124, 20)
        Me.txtDatabaseName.TabIndex = 9
        '
        'txtServerName
        '
        '
        '
        '
        Me.txtServerName.Border.Class = "TextBoxBorder"
        Me.txtServerName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtServerName.Location = New System.Drawing.Point(278, 20)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(124, 20)
        Me.txtServerName.TabIndex = 8
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(168, 46)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(104, 17)
        Me.LabelX4.TabIndex = 15
        Me.LabelX4.Text = "Database Name : "
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtUserName
        '
        '
        '
        '
        Me.txtUserName.Border.Class = "TextBoxBorder"
        Me.txtUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUserName.Location = New System.Drawing.Point(278, 72)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(124, 20)
        Me.txtUserName.TabIndex = 10
        Me.txtUserName.Text = "sa"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(168, 20)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(104, 17)
        Me.LabelX3.TabIndex = 13
        Me.LabelX3.Text = "Server Name : "
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(168, 98)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(104, 17)
        Me.LabelX2.TabIndex = 14
        Me.LabelX2.Text = "Password : "
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(168, 72)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(104, 17)
        Me.LabelX1.TabIndex = 12
        Me.LabelX1.Text = "Username : "
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.LogoPictureBox)
        Me.PanelEx1.Controls.Add(Me.cboLang)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.LabelX5)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.btnExit)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.btnLogIn)
        Me.PanelEx1.Controls.Add(Me.txtUserName)
        Me.PanelEx1.Controls.Add(Me.txtPassword)
        Me.PanelEx1.Controls.Add(Me.LabelX4)
        Me.PanelEx1.Controls.Add(Me.txtDatabaseName)
        Me.PanelEx1.Controls.Add(Me.txtServerName)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(425, 203)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 21
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.TimeAttendance.My.Resources.Resources.login
        Me.LogoPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LogoPictureBox.Location = New System.Drawing.Point(12, 20)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(150, 143)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 11
        Me.LogoPictureBox.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExit.Image = Global.TimeAttendance.My.Resources.Resources.logout
        Me.btnExit.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btnExit.Location = New System.Drawing.Point(297, 150)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 38)
        Me.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "ออก"
        '
        'btnLogIn
        '
        Me.btnLogIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLogIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnLogIn.Image = Global.TimeAttendance.My.Resources.Resources.System_Key
        Me.btnLogIn.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btnLogIn.Location = New System.Drawing.Point(168, 150)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(123, 38)
        Me.btnLogIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLogIn.TabIndex = 17
        Me.btnLogIn.Text = "Login"
        '
        'frmLoginDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 203)
        Me.Controls.Add(Me.PanelEx1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLoginDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataBase Login"
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboLang As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnLogIn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtDatabaseName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtServerName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtUserName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
End Class
