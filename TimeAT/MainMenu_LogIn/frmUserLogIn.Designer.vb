<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserLogIn
    'Inherits System.Windows.Forms.Form
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserLogIn))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblServerName = New DevExpress.XtraEditors.LabelControl()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.cboLang = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnLogin = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtUsername = New DevExpress.XtraEditors.TextEdit()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cboLang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        resources.ApplyResources(Me.PanelControl1, "PanelControl1")
        Me.PanelControl1.Controls.Add(Me.lblServerName)
        Me.PanelControl1.Controls.Add(Me.btnExit)
        Me.PanelControl1.Controls.Add(Me.LabelX3)
        Me.PanelControl1.Controls.Add(Me.cboLang)
        Me.PanelControl1.Controls.Add(Me.btnLogin)
        Me.PanelControl1.Controls.Add(Me.LabelX4)
        Me.PanelControl1.Controls.Add(Me.txtPassword)
        Me.PanelControl1.Controls.Add(Me.txtUsername)
        Me.PanelControl1.Controls.Add(Me.LabelX1)
        Me.PanelControl1.Controls.Add(Me.LabelX2)
        Me.PanelControl1.Name = "PanelControl1"
        '
        'lblServerName
        '
        resources.ApplyResources(Me.lblServerName, "lblServerName")
        Me.lblServerName.Name = "lblServerName"
        '
        'btnExit
        '
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.Appearance.Font = CType(resources.GetObject("btnExit.Appearance.Font"), System.Drawing.Font)
        Me.btnExit.Appearance.FontSizeDelta = CType(resources.GetObject("btnExit.Appearance.FontSizeDelta"), Integer)
        Me.btnExit.Appearance.FontStyleDelta = CType(resources.GetObject("btnExit.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.btnExit.Appearance.GradientMode = CType(resources.GetObject("btnExit.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.btnExit.Appearance.Image = CType(resources.GetObject("btnExit.Appearance.Image"), System.Drawing.Image)
        Me.btnExit.Appearance.Options.UseFont = True
        Me.btnExit.ImageOptions.Image = CType(resources.GetObject("btnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnExit.Name = "btnExit"
        '
        'LabelX3
        '
        resources.ApplyResources(Me.LabelX3, "LabelX3")
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cboLang
        '
        resources.ApplyResources(Me.cboLang, "cboLang")
        Me.cboLang.EnterMoveNextControl = True
        Me.cboLang.Name = "cboLang"
        Me.cboLang.Properties.AccessibleDescription = resources.GetString("cboLang.Properties.AccessibleDescription")
        Me.cboLang.Properties.AccessibleName = resources.GetString("cboLang.Properties.AccessibleName")
        Me.cboLang.Properties.Appearance.Font = CType(resources.GetObject("cboLang.Properties.Appearance.Font"), System.Drawing.Font)
        Me.cboLang.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("cboLang.Properties.Appearance.FontSizeDelta"), Integer)
        Me.cboLang.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("cboLang.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.cboLang.Properties.Appearance.GradientMode = CType(resources.GetObject("cboLang.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.cboLang.Properties.Appearance.Image = CType(resources.GetObject("cboLang.Properties.Appearance.Image"), System.Drawing.Image)
        Me.cboLang.Properties.Appearance.Options.UseFont = True
        Me.cboLang.Properties.AutoHeight = CType(resources.GetObject("cboLang.Properties.AutoHeight"), Boolean)
        Me.cboLang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboLang.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboLang.Properties.DropDownRows = 15
        Me.cboLang.Properties.NullValuePrompt = resources.GetString("cboLang.Properties.NullValuePrompt")
        Me.cboLang.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("cboLang.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.cboLang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'btnLogin
        '
        resources.ApplyResources(Me.btnLogin, "btnLogin")
        Me.btnLogin.Appearance.Font = CType(resources.GetObject("btnLogin.Appearance.Font"), System.Drawing.Font)
        Me.btnLogin.Appearance.FontSizeDelta = CType(resources.GetObject("btnLogin.Appearance.FontSizeDelta"), Integer)
        Me.btnLogin.Appearance.FontStyleDelta = CType(resources.GetObject("btnLogin.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.btnLogin.Appearance.GradientMode = CType(resources.GetObject("btnLogin.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.btnLogin.Appearance.Image = CType(resources.GetObject("btnLogin.Appearance.Image"), System.Drawing.Image)
        Me.btnLogin.Appearance.Options.UseFont = True
        Me.btnLogin.ImageOptions.Image = CType(resources.GetObject("btnLogin.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLogin.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnLogin.Name = "btnLogin"
        '
        'LabelX4
        '
        resources.ApplyResources(Me.LabelX4, "LabelX4")
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtPassword
        '
        resources.ApplyResources(Me.txtPassword, "txtPassword")
        Me.txtPassword.EnterMoveNextControl = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.AccessibleDescription = resources.GetString("txtPassword.Properties.AccessibleDescription")
        Me.txtPassword.Properties.AccessibleName = resources.GetString("txtPassword.Properties.AccessibleName")
        Me.txtPassword.Properties.Appearance.Font = CType(resources.GetObject("txtPassword.Properties.Appearance.Font"), System.Drawing.Font)
        Me.txtPassword.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtPassword.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtPassword.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtPassword.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtPassword.Properties.Appearance.GradientMode = CType(resources.GetObject("txtPassword.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtPassword.Properties.Appearance.Image = CType(resources.GetObject("txtPassword.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtPassword.Properties.Appearance.Options.UseFont = True
        Me.txtPassword.Properties.AutoHeight = CType(resources.GetObject("txtPassword.Properties.AutoHeight"), Boolean)
        Me.txtPassword.Properties.Mask.AutoComplete = CType(resources.GetObject("txtPassword.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtPassword.Properties.Mask.BeepOnError = CType(resources.GetObject("txtPassword.Properties.Mask.BeepOnError"), Boolean)
        Me.txtPassword.Properties.Mask.EditMask = resources.GetString("txtPassword.Properties.Mask.EditMask")
        Me.txtPassword.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtPassword.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtPassword.Properties.Mask.MaskType = CType(resources.GetObject("txtPassword.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtPassword.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtPassword.Properties.Mask.PlaceHolder"), Char)
        Me.txtPassword.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtPassword.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtPassword.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtPassword.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtPassword.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtPassword.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtPassword.Properties.NullValuePrompt = resources.GetString("txtPassword.Properties.NullValuePrompt")
        Me.txtPassword.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtPassword.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.txtPassword.Properties.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        resources.ApplyResources(Me.txtUsername, "txtUsername")
        Me.txtUsername.EnterMoveNextControl = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Properties.AccessibleDescription = resources.GetString("txtUsername.Properties.AccessibleDescription")
        Me.txtUsername.Properties.AccessibleName = resources.GetString("txtUsername.Properties.AccessibleName")
        Me.txtUsername.Properties.Appearance.Font = CType(resources.GetObject("txtUsername.Properties.Appearance.Font"), System.Drawing.Font)
        Me.txtUsername.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtUsername.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtUsername.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtUsername.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtUsername.Properties.Appearance.GradientMode = CType(resources.GetObject("txtUsername.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtUsername.Properties.Appearance.Image = CType(resources.GetObject("txtUsername.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtUsername.Properties.Appearance.Options.UseFont = True
        Me.txtUsername.Properties.AutoHeight = CType(resources.GetObject("txtUsername.Properties.AutoHeight"), Boolean)
        Me.txtUsername.Properties.Mask.AutoComplete = CType(resources.GetObject("txtUsername.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtUsername.Properties.Mask.BeepOnError = CType(resources.GetObject("txtUsername.Properties.Mask.BeepOnError"), Boolean)
        Me.txtUsername.Properties.Mask.EditMask = resources.GetString("txtUsername.Properties.Mask.EditMask")
        Me.txtUsername.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtUsername.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtUsername.Properties.Mask.MaskType = CType(resources.GetObject("txtUsername.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtUsername.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtUsername.Properties.Mask.PlaceHolder"), Char)
        Me.txtUsername.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtUsername.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtUsername.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtUsername.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtUsername.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtUsername.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtUsername.Properties.NullValuePrompt = resources.GetString("txtUsername.Properties.NullValuePrompt")
        Me.txtUsername.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtUsername.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'LabelX1
        '
        resources.ApplyResources(Me.LabelX1, "LabelX1")
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX2
        '
        resources.ApplyResources(Me.LabelX2, "LabelX2")
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'frmUserLogIn
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmUserLogIn"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.cboLang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblServerName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboLang As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnLogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
End Class
