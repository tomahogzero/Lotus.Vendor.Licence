<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoginPage
    'Inherits System.Windows.Forms.Form
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginPage))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblLang = New DevExpress.XtraEditors.LabelControl()
        Me.lblPassword = New DevExpress.XtraEditors.LabelControl()
        Me.lblUsername = New DevExpress.XtraEditors.LabelControl()
        Me.lblServerName = New DevExpress.XtraEditors.LabelControl()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cboLang = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnLogin = New DevExpress.XtraEditors.SimpleButton()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtUsername = New DevExpress.XtraEditors.TextEdit()
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
        Me.PanelControl1.Controls.Add(Me.lblLang)
        Me.PanelControl1.Controls.Add(Me.lblPassword)
        Me.PanelControl1.Controls.Add(Me.lblUsername)
        Me.PanelControl1.Controls.Add(Me.lblServerName)
        Me.PanelControl1.Controls.Add(Me.btnExit)
        Me.PanelControl1.Controls.Add(Me.cboLang)
        Me.PanelControl1.Controls.Add(Me.btnLogin)
        Me.PanelControl1.Controls.Add(Me.txtPassword)
        Me.PanelControl1.Controls.Add(Me.txtUsername)
        Me.PanelControl1.Name = "PanelControl1"
        '
        'lblLang
        '
        Me.lblLang.Appearance.Font = CType(resources.GetObject("lblLang.Appearance.Font"), System.Drawing.Font)
        Me.lblLang.Appearance.Options.UseFont = True
        resources.ApplyResources(Me.lblLang, "lblLang")
        Me.lblLang.Name = "lblLang"
        '
        'lblPassword
        '
        Me.lblPassword.Appearance.Font = CType(resources.GetObject("lblPassword.Appearance.Font"), System.Drawing.Font)
        Me.lblPassword.Appearance.Options.UseFont = True
        resources.ApplyResources(Me.lblPassword, "lblPassword")
        Me.lblPassword.Name = "lblPassword"
        '
        'lblUsername
        '
        Me.lblUsername.Appearance.Font = CType(resources.GetObject("lblUsername.Appearance.Font"), System.Drawing.Font)
        Me.lblUsername.Appearance.Options.UseFont = True
        resources.ApplyResources(Me.lblUsername, "lblUsername")
        Me.lblUsername.Name = "lblUsername"
        '
        'lblServerName
        '
        resources.ApplyResources(Me.lblServerName, "lblServerName")
        Me.lblServerName.Name = "lblServerName"
        '
        'btnExit
        '
        Me.btnExit.Appearance.Font = CType(resources.GetObject("btnExit.Appearance.Font"), System.Drawing.Font)
        Me.btnExit.Appearance.Options.UseFont = True
        Me.btnExit.ImageOptions.Image = CType(resources.GetObject("btnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.Name = "btnExit"
        '
        'cboLang
        '
        Me.cboLang.EnterMoveNextControl = True
        resources.ApplyResources(Me.cboLang, "cboLang")
        Me.cboLang.Name = "cboLang"
        Me.cboLang.Properties.Appearance.Font = CType(resources.GetObject("cboLang.Properties.Appearance.Font"), System.Drawing.Font)
        Me.cboLang.Properties.Appearance.Options.UseFont = True
        Me.cboLang.Properties.AutoHeight = CType(resources.GetObject("cboLang.Properties.AutoHeight"), Boolean)
        Me.cboLang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboLang.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboLang.Properties.DropDownRows = 15
        Me.cboLang.Properties.NullValuePrompt = resources.GetString("cboLang.Properties.NullValuePrompt")
        Me.cboLang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'btnLogin
        '
        Me.btnLogin.Appearance.Font = CType(resources.GetObject("btnLogin.Appearance.Font"), System.Drawing.Font)
        Me.btnLogin.Appearance.Options.UseFont = True
        Me.btnLogin.ImageOptions.Image = CType(resources.GetObject("btnLogin.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLogin.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        resources.ApplyResources(Me.btnLogin, "btnLogin")
        Me.btnLogin.Name = "btnLogin"
        '
        'txtPassword
        '
        Me.txtPassword.EnterMoveNextControl = True
        resources.ApplyResources(Me.txtPassword, "txtPassword")
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.Appearance.Font = CType(resources.GetObject("txtPassword.Properties.Appearance.Font"), System.Drawing.Font)
        Me.txtPassword.Properties.Appearance.Options.UseFont = True
        Me.txtPassword.Properties.AutoHeight = CType(resources.GetObject("txtPassword.Properties.AutoHeight"), Boolean)
        Me.txtPassword.Properties.Mask.EditMask = resources.GetString("txtPassword.Properties.Mask.EditMask")
        Me.txtPassword.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtPassword.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtPassword.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtPassword.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtPassword.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtPassword.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtPassword.Properties.NullValuePrompt = resources.GetString("txtPassword.Properties.NullValuePrompt")
        Me.txtPassword.Properties.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.EnterMoveNextControl = True
        resources.ApplyResources(Me.txtUsername, "txtUsername")
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Properties.Appearance.Font = CType(resources.GetObject("txtUsername.Properties.Appearance.Font"), System.Drawing.Font)
        Me.txtUsername.Properties.Appearance.Options.UseFont = True
        Me.txtUsername.Properties.AutoHeight = CType(resources.GetObject("txtUsername.Properties.AutoHeight"), Boolean)
        Me.txtUsername.Properties.Mask.EditMask = resources.GetString("txtUsername.Properties.Mask.EditMask")
        Me.txtUsername.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtUsername.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtUsername.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtUsername.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtUsername.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtUsername.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtUsername.Properties.NullValuePrompt = resources.GetString("txtUsername.Properties.NullValuePrompt")
        '
        'frmLoginPage
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmLoginPage"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cboLang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblServerName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboLang As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnLogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblLang As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPassword As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUsername As DevExpress.XtraEditors.LabelControl
End Class
