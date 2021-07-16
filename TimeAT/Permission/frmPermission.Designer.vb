<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPermission
    ' Inherits System.Windows.Forms.Form
    '   Inherits frmBasicPage2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPermission))
        Me.ChkAllCompany = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.btnSetPermission = New DevComponents.DotNetBar.ButtonX()
        Me.rdoGroup = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.rdoSingle = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.btnFind = New DevComponents.DotNetBar.ButtonX()
        Me.lstShow = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.colNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colUsername = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.collastname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.coldiv = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.txtUsername = New DevExpress.XtraEditors.TextEdit()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtConPass = New DevExpress.XtraEditors.TextEdit()
        Me.GcUser = New DevExpress.XtraGrid.GridControl()
        Me.GvUser = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode_lar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription_lar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReduc_lar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotdeduc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colremark_lar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cboTransport_detail = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboUnitName = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtOldUserName = New DevExpress.XtraEditors.TextEdit()
        Me.lblUsername = New DevExpress.XtraEditors.LabelControl()
        Me.lblPassword = New DevExpress.XtraEditors.LabelControl()
        Me.lblConPass = New DevExpress.XtraEditors.LabelControl()
        Me.lblCode = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnshowemp = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lblEmpName = New DevExpress.XtraEditors.TextEdit()
        Me.txtCode_Old = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOldUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.lblEmpName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode_Old.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChkAllCompany
        '
        resources.ApplyResources(Me.ChkAllCompany, "ChkAllCompany")
        Me.ChkAllCompany.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ChkAllCompany.BackgroundStyle.Class = ""
        Me.ChkAllCompany.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightColor(Me.ChkAllCompany, CType(resources.GetObject("ChkAllCompany.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.ChkAllCompany, CType(resources.GetObject("ChkAllCompany.HighlightOnFocus"), Boolean))
        Me.ChkAllCompany.Name = "ChkAllCompany"
        Me.ChkAllCompany.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ChkAllCompany.TextColor = System.Drawing.Color.Red
        '
        'btnSetPermission
        '
        resources.ApplyResources(Me.btnSetPermission, "btnSetPermission")
        Me.btnSetPermission.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSetPermission.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Highlighter1.SetHighlightColor(Me.btnSetPermission, CType(resources.GetObject("btnSetPermission.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.btnSetPermission, CType(resources.GetObject("btnSetPermission.HighlightOnFocus"), Boolean))
        Me.btnSetPermission.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnSetPermission.Name = "btnSetPermission"
        Me.btnSetPermission.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'rdoGroup
        '
        resources.ApplyResources(Me.rdoGroup, "rdoGroup")
        Me.rdoGroup.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.rdoGroup.BackgroundStyle.Class = ""
        Me.rdoGroup.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rdoGroup.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.Highlighter1.SetHighlightColor(Me.rdoGroup, CType(resources.GetObject("rdoGroup.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.rdoGroup, CType(resources.GetObject("rdoGroup.HighlightOnFocus"), Boolean))
        Me.rdoGroup.Name = "rdoGroup"
        Me.rdoGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
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
        Me.Highlighter1.SetHighlightColor(Me.LabelX1, CType(resources.GetObject("LabelX1.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.LabelX1, CType(resources.GetObject("LabelX1.HighlightOnFocus"), Boolean))
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX6
        '
        resources.ApplyResources(Me.LabelX6, "LabelX6")
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightColor(Me.LabelX6, CType(resources.GetObject("LabelX6.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.LabelX6, CType(resources.GetObject("LabelX6.HighlightOnFocus"), Boolean))
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'rdoSingle
        '
        resources.ApplyResources(Me.rdoSingle, "rdoSingle")
        Me.rdoSingle.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.rdoSingle.BackgroundStyle.Class = ""
        Me.rdoSingle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rdoSingle.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rdoSingle.Checked = True
        Me.rdoSingle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rdoSingle.CheckValue = "Y"
        Me.Highlighter1.SetHighlightColor(Me.rdoSingle, CType(resources.GetObject("rdoSingle.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.rdoSingle, CType(resources.GetObject("rdoSingle.HighlightOnFocus"), Boolean))
        Me.rdoSingle.Name = "rdoSingle"
        Me.rdoSingle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'btnFind
        '
        resources.ApplyResources(Me.btnFind, "btnFind")
        Me.btnFind.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFind.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Highlighter1.SetHighlightColor(Me.btnFind, CType(resources.GetObject("btnFind.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.btnFind, CType(resources.GetObject("btnFind.HighlightOnFocus"), Boolean))
        Me.btnFind.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'lstShow
        '
        resources.ApplyResources(Me.lstShow, "lstShow")
        '
        '
        '
        Me.lstShow.Border.Class = "ListViewBorder"
        Me.lstShow.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lstShow.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNo, Me.colcode, Me.colUsername, Me.colname, Me.collastname, Me.coldiv})
        Me.lstShow.FullRowSelect = True
        Me.lstShow.GridLines = True
        Me.Highlighter1.SetHighlightColor(Me.lstShow, CType(resources.GetObject("lstShow.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.lstShow, CType(resources.GetObject("lstShow.HighlightOnFocus"), Boolean))
        Me.lstShow.Name = "lstShow"
        Me.lstShow.UseCompatibleStateImageBehavior = False
        Me.lstShow.View = System.Windows.Forms.View.Details
        '
        'colNo
        '
        resources.ApplyResources(Me.colNo, "colNo")
        '
        'colcode
        '
        resources.ApplyResources(Me.colcode, "colcode")
        '
        'colUsername
        '
        resources.ApplyResources(Me.colUsername, "colUsername")
        '
        'colname
        '
        resources.ApplyResources(Me.colname, "colname")
        '
        'collastname
        '
        resources.ApplyResources(Me.collastname, "collastname")
        '
        'coldiv
        '
        resources.ApplyResources(Me.coldiv, "coldiv")
        '
        'Highlighter1
        '
        resources.ApplyResources(Me.Highlighter1, "Highlighter1")
        '
        'txtUsername
        '
        resources.ApplyResources(Me.txtUsername, "txtUsername")
        Me.txtUsername.EnterMoveNextControl = True
        Me.Highlighter1.SetHighlightColor(Me.txtUsername, CType(resources.GetObject("txtUsername.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.txtUsername, CType(resources.GetObject("txtUsername.HighlightOnFocus"), Boolean))
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Properties.AccessibleDescription = resources.GetString("txtUsername.Properties.AccessibleDescription")
        Me.txtUsername.Properties.AccessibleName = resources.GetString("txtUsername.Properties.AccessibleName")
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
        'txtPassword
        '
        resources.ApplyResources(Me.txtPassword, "txtPassword")
        Me.txtPassword.EnterMoveNextControl = True
        Me.Highlighter1.SetHighlightColor(Me.txtPassword, CType(resources.GetObject("txtPassword.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.txtPassword, CType(resources.GetObject("txtPassword.HighlightOnFocus"), Boolean))
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.AccessibleDescription = resources.GetString("txtPassword.Properties.AccessibleDescription")
        Me.txtPassword.Properties.AccessibleName = resources.GetString("txtPassword.Properties.AccessibleName")
        Me.txtPassword.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtPassword.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtPassword.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtPassword.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtPassword.Properties.Appearance.GradientMode = CType(resources.GetObject("txtPassword.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtPassword.Properties.Appearance.Image = CType(resources.GetObject("txtPassword.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtPassword.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPassword.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
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
        '
        'txtCode
        '
        resources.ApplyResources(Me.txtCode, "txtCode")
        Me.txtCode.EnterMoveNextControl = True
        Me.Highlighter1.SetHighlightColor(Me.txtCode, CType(resources.GetObject("txtCode.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.txtCode, CType(resources.GetObject("txtCode.HighlightOnFocus"), Boolean))
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.AccessibleDescription = resources.GetString("txtCode.Properties.AccessibleDescription")
        Me.txtCode.Properties.AccessibleName = resources.GetString("txtCode.Properties.AccessibleName")
        Me.txtCode.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtCode.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtCode.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtCode.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtCode.Properties.Appearance.GradientMode = CType(resources.GetObject("txtCode.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtCode.Properties.Appearance.Image = CType(resources.GetObject("txtCode.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtCode.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtCode.Properties.AutoHeight = CType(resources.GetObject("txtCode.Properties.AutoHeight"), Boolean)
        Me.txtCode.Properties.Mask.AutoComplete = CType(resources.GetObject("txtCode.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtCode.Properties.Mask.BeepOnError = CType(resources.GetObject("txtCode.Properties.Mask.BeepOnError"), Boolean)
        Me.txtCode.Properties.Mask.EditMask = resources.GetString("txtCode.Properties.Mask.EditMask")
        Me.txtCode.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtCode.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtCode.Properties.Mask.MaskType = CType(resources.GetObject("txtCode.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtCode.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtCode.Properties.Mask.PlaceHolder"), Char)
        Me.txtCode.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtCode.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtCode.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtCode.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtCode.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtCode.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtCode.Properties.NullValuePrompt = resources.GetString("txtCode.Properties.NullValuePrompt")
        Me.txtCode.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtCode.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.txtCode.Properties.ReadOnly = True
        Me.txtCode.TabStop = False
        '
        'txtConPass
        '
        resources.ApplyResources(Me.txtConPass, "txtConPass")
        Me.txtConPass.EnterMoveNextControl = True
        Me.Highlighter1.SetHighlightColor(Me.txtConPass, CType(resources.GetObject("txtConPass.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.txtConPass, CType(resources.GetObject("txtConPass.HighlightOnFocus"), Boolean))
        Me.txtConPass.Name = "txtConPass"
        Me.txtConPass.Properties.AccessibleDescription = resources.GetString("txtConPass.Properties.AccessibleDescription")
        Me.txtConPass.Properties.AccessibleName = resources.GetString("txtConPass.Properties.AccessibleName")
        Me.txtConPass.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtConPass.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtConPass.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtConPass.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtConPass.Properties.Appearance.GradientMode = CType(resources.GetObject("txtConPass.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtConPass.Properties.Appearance.Image = CType(resources.GetObject("txtConPass.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtConPass.Properties.Appearance.Options.UseTextOptions = True
        Me.txtConPass.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtConPass.Properties.AutoHeight = CType(resources.GetObject("txtConPass.Properties.AutoHeight"), Boolean)
        Me.txtConPass.Properties.DisplayFormat.FormatString = "n0"
        Me.txtConPass.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtConPass.Properties.EditFormat.FormatString = "n0"
        Me.txtConPass.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtConPass.Properties.Mask.AutoComplete = CType(resources.GetObject("txtConPass.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtConPass.Properties.Mask.BeepOnError = CType(resources.GetObject("txtConPass.Properties.Mask.BeepOnError"), Boolean)
        Me.txtConPass.Properties.Mask.EditMask = resources.GetString("txtConPass.Properties.Mask.EditMask")
        Me.txtConPass.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtConPass.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtConPass.Properties.Mask.MaskType = CType(resources.GetObject("txtConPass.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtConPass.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtConPass.Properties.Mask.PlaceHolder"), Char)
        Me.txtConPass.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtConPass.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtConPass.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtConPass.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtConPass.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtConPass.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtConPass.Properties.NullValuePrompt = resources.GetString("txtConPass.Properties.NullValuePrompt")
        Me.txtConPass.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtConPass.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'GcUser
        '
        resources.ApplyResources(Me.GcUser, "GcUser")
        Me.GcUser.EmbeddedNavigator.AccessibleDescription = resources.GetString("GcUser.EmbeddedNavigator.AccessibleDescription")
        Me.GcUser.EmbeddedNavigator.AccessibleName = resources.GetString("GcUser.EmbeddedNavigator.AccessibleName")
        Me.GcUser.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GcUser.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GcUser.EmbeddedNavigator.Anchor = CType(resources.GetObject("GcUser.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GcUser.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GcUser.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GcUser.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GcUser.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GcUser.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GcUser.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GcUser.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GcUser.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GcUser.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GcUser.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GcUser.EmbeddedNavigator.ToolTip = resources.GetString("GcUser.EmbeddedNavigator.ToolTip")
        Me.GcUser.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GcUser.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GcUser.EmbeddedNavigator.ToolTipTitle = resources.GetString("GcUser.EmbeddedNavigator.ToolTipTitle")
        Me.Highlighter1.SetHighlightColor(Me.GcUser, CType(resources.GetObject("GcUser.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.GcUser, CType(resources.GetObject("GcUser.HighlightOnFocus"), Boolean))
        Me.GcUser.MainView = Me.GvUser
        Me.GcUser.Name = "GcUser"
        Me.GcUser.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.BtnDel, Me.cboTransport_detail, Me.cboUnitName})
        Me.GcUser.TabStop = False
        Me.GcUser.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvUser})
        '
        'GvUser
        '
        Me.GvUser.Appearance.HeaderPanel.Font = CType(resources.GetObject("GvUser.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GvUser.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GvUser.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GvUser.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GvUser.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GvUser.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GvUser.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GvUser.Appearance.HeaderPanel.Image = CType(resources.GetObject("GvUser.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GvUser.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvUser.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GvUser.Appearance.Row.FontSizeDelta"), Integer)
        Me.GvUser.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GvUser.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GvUser.Appearance.Row.GradientMode = CType(resources.GetObject("GvUser.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GvUser.Appearance.Row.Image = CType(resources.GetObject("GvUser.Appearance.Row.Image"), System.Drawing.Image)
        Me.GvUser.Appearance.Row.Options.UseFont = True
        resources.ApplyResources(Me.GvUser, "GvUser")
        Me.GvUser.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colrow, Me.colcode_lar, Me.colDescription_lar, Me.colReduc_lar, Me.colNotdeduc, Me.colremark_lar})
        Me.GvUser.GridControl = Me.GcUser
        Me.GvUser.Name = "GvUser"
        Me.GvUser.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.GvUser.OptionsView.ColumnAutoWidth = False
        Me.GvUser.OptionsView.ShowAutoFilterRow = True
        Me.GvUser.OptionsView.ShowGroupPanel = False
        '
        'colrow
        '
        Me.colrow.AppearanceCell.FontSizeDelta = CType(resources.GetObject("colrow.AppearanceCell.FontSizeDelta"), Integer)
        Me.colrow.AppearanceCell.FontStyleDelta = CType(resources.GetObject("colrow.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.colrow.AppearanceCell.GradientMode = CType(resources.GetObject("colrow.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.colrow.AppearanceCell.Image = CType(resources.GetObject("colrow.AppearanceCell.Image"), System.Drawing.Image)
        Me.colrow.AppearanceCell.Options.UseTextOptions = True
        Me.colrow.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colrow.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("colrow.AppearanceHeader.FontSizeDelta"), Integer)
        Me.colrow.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("colrow.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.colrow.AppearanceHeader.GradientMode = CType(resources.GetObject("colrow.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.colrow.AppearanceHeader.Image = CType(resources.GetObject("colrow.AppearanceHeader.Image"), System.Drawing.Image)
        Me.colrow.AppearanceHeader.Options.UseTextOptions = True
        Me.colrow.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colrow, "colrow")
        Me.colrow.FieldName = "row"
        Me.colrow.Name = "colrow"
        Me.colrow.OptionsColumn.AllowEdit = False
        Me.colrow.OptionsColumn.TabStop = False
        '
        'colcode_lar
        '
        Me.colcode_lar.AppearanceCell.FontSizeDelta = CType(resources.GetObject("colcode_lar.AppearanceCell.FontSizeDelta"), Integer)
        Me.colcode_lar.AppearanceCell.FontStyleDelta = CType(resources.GetObject("colcode_lar.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.colcode_lar.AppearanceCell.GradientMode = CType(resources.GetObject("colcode_lar.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.colcode_lar.AppearanceCell.Image = CType(resources.GetObject("colcode_lar.AppearanceCell.Image"), System.Drawing.Image)
        Me.colcode_lar.AppearanceCell.Options.UseTextOptions = True
        Me.colcode_lar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colcode_lar.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("colcode_lar.AppearanceHeader.FontSizeDelta"), Integer)
        Me.colcode_lar.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("colcode_lar.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.colcode_lar.AppearanceHeader.GradientMode = CType(resources.GetObject("colcode_lar.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.colcode_lar.AppearanceHeader.Image = CType(resources.GetObject("colcode_lar.AppearanceHeader.Image"), System.Drawing.Image)
        Me.colcode_lar.AppearanceHeader.Options.UseTextOptions = True
        Me.colcode_lar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colcode_lar, "colcode_lar")
        Me.colcode_lar.FieldName = "UserId"
        Me.colcode_lar.Name = "colcode_lar"
        Me.colcode_lar.OptionsColumn.AllowEdit = False
        '
        'colDescription_lar
        '
        resources.ApplyResources(Me.colDescription_lar, "colDescription_lar")
        Me.colDescription_lar.FieldName = "Username"
        Me.colDescription_lar.Name = "colDescription_lar"
        Me.colDescription_lar.OptionsColumn.AllowEdit = False
        '
        'colReduc_lar
        '
        Me.colReduc_lar.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("colReduc_lar.AppearanceHeader.FontSizeDelta"), Integer)
        Me.colReduc_lar.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("colReduc_lar.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.colReduc_lar.AppearanceHeader.GradientMode = CType(resources.GetObject("colReduc_lar.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.colReduc_lar.AppearanceHeader.Image = CType(resources.GetObject("colReduc_lar.AppearanceHeader.Image"), System.Drawing.Image)
        Me.colReduc_lar.AppearanceHeader.Options.UseTextOptions = True
        Me.colReduc_lar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colReduc_lar, "colReduc_lar")
        Me.colReduc_lar.FieldName = "Name"
        Me.colReduc_lar.Name = "colReduc_lar"
        Me.colReduc_lar.OptionsColumn.AllowEdit = False
        '
        'colNotdeduc
        '
        Me.colNotdeduc.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("colNotdeduc.AppearanceHeader.FontSizeDelta"), Integer)
        Me.colNotdeduc.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("colNotdeduc.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.colNotdeduc.AppearanceHeader.GradientMode = CType(resources.GetObject("colNotdeduc.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.colNotdeduc.AppearanceHeader.Image = CType(resources.GetObject("colNotdeduc.AppearanceHeader.Image"), System.Drawing.Image)
        Me.colNotdeduc.AppearanceHeader.Options.UseTextOptions = True
        Me.colNotdeduc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colNotdeduc, "colNotdeduc")
        Me.colNotdeduc.FieldName = "LName"
        Me.colNotdeduc.Name = "colNotdeduc"
        Me.colNotdeduc.OptionsColumn.AllowEdit = False
        '
        'colremark_lar
        '
        resources.ApplyResources(Me.colremark_lar, "colremark_lar")
        Me.colremark_lar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colremark_lar.FieldName = "Department"
        Me.colremark_lar.Name = "colremark_lar"
        Me.colremark_lar.OptionsColumn.AllowEdit = False
        '
        'BtnDel
        '
        resources.ApplyResources(Me.BtnDel, "BtnDel")
        Me.BtnDel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("BtnDel.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.BtnDel.Mask.AutoComplete = CType(resources.GetObject("BtnDel.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.BtnDel.Mask.BeepOnError = CType(resources.GetObject("BtnDel.Mask.BeepOnError"), Boolean)
        Me.BtnDel.Mask.EditMask = resources.GetString("BtnDel.Mask.EditMask")
        Me.BtnDel.Mask.IgnoreMaskBlank = CType(resources.GetObject("BtnDel.Mask.IgnoreMaskBlank"), Boolean)
        Me.BtnDel.Mask.MaskType = CType(resources.GetObject("BtnDel.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.BtnDel.Mask.PlaceHolder = CType(resources.GetObject("BtnDel.Mask.PlaceHolder"), Char)
        Me.BtnDel.Mask.SaveLiteral = CType(resources.GetObject("BtnDel.Mask.SaveLiteral"), Boolean)
        Me.BtnDel.Mask.ShowPlaceHolders = CType(resources.GetObject("BtnDel.Mask.ShowPlaceHolders"), Boolean)
        Me.BtnDel.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("BtnDel.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'cboTransport_detail
        '
        resources.ApplyResources(Me.cboTransport_detail, "cboTransport_detail")
        Me.cboTransport_detail.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboTransport_detail.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboTransport_detail.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("cboTransport_detail.Columns"), CType(resources.GetObject("cboTransport_detail.Columns1"), Integer), resources.GetString("cboTransport_detail.Columns2"))})
        Me.cboTransport_detail.DisplayMember = "TransName"
        Me.cboTransport_detail.Name = "cboTransport_detail"
        Me.cboTransport_detail.ValueMember = "transcomId"
        '
        'cboUnitName
        '
        resources.ApplyResources(Me.cboUnitName, "cboUnitName")
        Me.cboUnitName.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cboUnitName.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cboUnitName.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("cboUnitName.Columns"), resources.GetString("cboUnitName.Columns1"))})
        Me.cboUnitName.DisplayMember = "unit"
        Me.cboUnitName.Name = "cboUnitName"
        Me.cboUnitName.ValueMember = "unitid"
        '
        'btnAdd
        '
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        Me.Highlighter1.SetHighlightColor(Me.btnAdd, CType(resources.GetObject("btnAdd.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.btnAdd, CType(resources.GetObject("btnAdd.HighlightOnFocus"), Boolean))
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("btnAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnAdd.Name = "btnAdd"
        '
        'btnEdit
        '
        resources.ApplyResources(Me.btnEdit, "btnEdit")
        Me.Highlighter1.SetHighlightColor(Me.btnEdit, CType(resources.GetObject("btnEdit.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.btnEdit, CType(resources.GetObject("btnEdit.HighlightOnFocus"), Boolean))
        Me.btnEdit.ImageOptions.Image = CType(resources.GetObject("btnEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnEdit.Name = "btnEdit"
        '
        'btnDelete
        '
        resources.ApplyResources(Me.btnDelete, "btnDelete")
        Me.Highlighter1.SetHighlightColor(Me.btnDelete, CType(resources.GetObject("btnDelete.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.btnDelete, CType(resources.GetObject("btnDelete.HighlightOnFocus"), Boolean))
        Me.btnDelete.ImageOptions.Image = CType(resources.GetObject("btnDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnDelete.Name = "btnDelete"
        '
        'btnClear
        '
        resources.ApplyResources(Me.btnClear, "btnClear")
        Me.Highlighter1.SetHighlightColor(Me.btnClear, CType(resources.GetObject("btnClear.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.btnClear, CType(resources.GetObject("btnClear.HighlightOnFocus"), Boolean))
        Me.btnClear.ImageOptions.Image = CType(resources.GetObject("btnClear.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClear.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnClear.Name = "btnClear"
        '
        'SimpleButton2
        '
        resources.ApplyResources(Me.SimpleButton2, "SimpleButton2")
        Me.Highlighter1.SetHighlightColor(Me.SimpleButton2, CType(resources.GetObject("SimpleButton2.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.SimpleButton2, CType(resources.GetObject("SimpleButton2.HighlightOnFocus"), Boolean))
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.SimpleButton2.Name = "SimpleButton2"
        '
        'txtOldUserName
        '
        resources.ApplyResources(Me.txtOldUserName, "txtOldUserName")
        Me.txtOldUserName.EnterMoveNextControl = True
        Me.Highlighter1.SetHighlightColor(Me.txtOldUserName, CType(resources.GetObject("txtOldUserName.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.txtOldUserName, CType(resources.GetObject("txtOldUserName.HighlightOnFocus"), Boolean))
        Me.txtOldUserName.Name = "txtOldUserName"
        Me.txtOldUserName.Properties.AccessibleDescription = resources.GetString("txtOldUserName.Properties.AccessibleDescription")
        Me.txtOldUserName.Properties.AccessibleName = resources.GetString("txtOldUserName.Properties.AccessibleName")
        Me.txtOldUserName.Properties.AutoHeight = CType(resources.GetObject("txtOldUserName.Properties.AutoHeight"), Boolean)
        Me.txtOldUserName.Properties.Mask.AutoComplete = CType(resources.GetObject("txtOldUserName.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtOldUserName.Properties.Mask.BeepOnError = CType(resources.GetObject("txtOldUserName.Properties.Mask.BeepOnError"), Boolean)
        Me.txtOldUserName.Properties.Mask.EditMask = resources.GetString("txtOldUserName.Properties.Mask.EditMask")
        Me.txtOldUserName.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtOldUserName.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtOldUserName.Properties.Mask.MaskType = CType(resources.GetObject("txtOldUserName.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtOldUserName.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtOldUserName.Properties.Mask.PlaceHolder"), Char)
        Me.txtOldUserName.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtOldUserName.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtOldUserName.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtOldUserName.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtOldUserName.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtOldUserName.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtOldUserName.Properties.NullValuePrompt = resources.GetString("txtOldUserName.Properties.NullValuePrompt")
        Me.txtOldUserName.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtOldUserName.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'lblUsername
        '
        resources.ApplyResources(Me.lblUsername, "lblUsername")
        Me.lblUsername.Appearance.FontSizeDelta = CType(resources.GetObject("lblUsername.Appearance.FontSizeDelta"), Integer)
        Me.lblUsername.Appearance.FontStyleDelta = CType(resources.GetObject("lblUsername.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.lblUsername.Appearance.GradientMode = CType(resources.GetObject("lblUsername.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.lblUsername.Appearance.Image = CType(resources.GetObject("lblUsername.Appearance.Image"), System.Drawing.Image)
        Me.lblUsername.Appearance.Options.UseTextOptions = True
        Me.lblUsername.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Highlighter1.SetHighlightColor(Me.lblUsername, CType(resources.GetObject("lblUsername.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.lblUsername, CType(resources.GetObject("lblUsername.HighlightOnFocus"), Boolean))
        Me.lblUsername.Name = "lblUsername"
        '
        'lblPassword
        '
        resources.ApplyResources(Me.lblPassword, "lblPassword")
        Me.lblPassword.Appearance.FontSizeDelta = CType(resources.GetObject("lblPassword.Appearance.FontSizeDelta"), Integer)
        Me.lblPassword.Appearance.FontStyleDelta = CType(resources.GetObject("lblPassword.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.lblPassword.Appearance.GradientMode = CType(resources.GetObject("lblPassword.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.lblPassword.Appearance.Image = CType(resources.GetObject("lblPassword.Appearance.Image"), System.Drawing.Image)
        Me.lblPassword.Appearance.Options.UseTextOptions = True
        Me.lblPassword.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Highlighter1.SetHighlightColor(Me.lblPassword, CType(resources.GetObject("lblPassword.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.lblPassword, CType(resources.GetObject("lblPassword.HighlightOnFocus"), Boolean))
        Me.lblPassword.Name = "lblPassword"
        '
        'lblConPass
        '
        resources.ApplyResources(Me.lblConPass, "lblConPass")
        Me.lblConPass.Appearance.FontSizeDelta = CType(resources.GetObject("lblConPass.Appearance.FontSizeDelta"), Integer)
        Me.lblConPass.Appearance.FontStyleDelta = CType(resources.GetObject("lblConPass.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.lblConPass.Appearance.GradientMode = CType(resources.GetObject("lblConPass.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.lblConPass.Appearance.Image = CType(resources.GetObject("lblConPass.Appearance.Image"), System.Drawing.Image)
        Me.lblConPass.Appearance.Options.UseTextOptions = True
        Me.lblConPass.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Highlighter1.SetHighlightColor(Me.lblConPass, CType(resources.GetObject("lblConPass.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.lblConPass, CType(resources.GetObject("lblConPass.HighlightOnFocus"), Boolean))
        Me.lblConPass.Name = "lblConPass"
        '
        'lblCode
        '
        resources.ApplyResources(Me.lblCode, "lblCode")
        Me.lblCode.Appearance.FontSizeDelta = CType(resources.GetObject("lblCode.Appearance.FontSizeDelta"), Integer)
        Me.lblCode.Appearance.FontStyleDelta = CType(resources.GetObject("lblCode.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.lblCode.Appearance.GradientMode = CType(resources.GetObject("lblCode.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.lblCode.Appearance.Image = CType(resources.GetObject("lblCode.Appearance.Image"), System.Drawing.Image)
        Me.lblCode.Appearance.Options.UseTextOptions = True
        Me.lblCode.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Highlighter1.SetHighlightColor(Me.lblCode, CType(resources.GetObject("lblCode.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.lblCode, CType(resources.GetObject("lblCode.HighlightOnFocus"), Boolean))
        Me.lblCode.Name = "lblCode"
        '
        'GroupControl1
        '
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Controls.Add(Me.ChkAllCompany)
        Me.GroupControl1.Controls.Add(Me.btnSetPermission)
        Me.GroupControl1.Controls.Add(Me.btnshowemp)
        Me.GroupControl1.Controls.Add(Me.rdoGroup)
        Me.GroupControl1.Controls.Add(Me.btnFind)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.lblCode)
        Me.GroupControl1.Controls.Add(Me.txtUsername)
        Me.GroupControl1.Controls.Add(Me.LabelX1)
        Me.GroupControl1.Controls.Add(Me.lblEmpName)
        Me.GroupControl1.Controls.Add(Me.LabelX6)
        Me.GroupControl1.Controls.Add(Me.txtOldUserName)
        Me.GroupControl1.Controls.Add(Me.txtConPass)
        Me.GroupControl1.Controls.Add(Me.rdoSingle)
        Me.GroupControl1.Controls.Add(Me.lblConPass)
        Me.GroupControl1.Controls.Add(Me.txtCode_Old)
        Me.GroupControl1.Controls.Add(Me.txtCode)
        Me.GroupControl1.Controls.Add(Me.lblUsername)
        Me.GroupControl1.Controls.Add(Me.lblPassword)
        Me.GroupControl1.Controls.Add(Me.txtPassword)
        Me.Highlighter1.SetHighlightColor(Me.GroupControl1, CType(resources.GetObject("GroupControl1.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.GroupControl1, CType(resources.GetObject("GroupControl1.HighlightOnFocus"), Boolean))
        Me.GroupControl1.Name = "GroupControl1"
        '
        'btnshowemp
        '
        resources.ApplyResources(Me.btnshowemp, "btnshowemp")
        Me.Highlighter1.SetHighlightColor(Me.btnshowemp, CType(resources.GetObject("btnshowemp.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.btnshowemp, CType(resources.GetObject("btnshowemp.HighlightOnFocus"), Boolean))
        Me.btnshowemp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnshowemp.Name = "btnshowemp"
        '
        'LabelControl5
        '
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Appearance.FontSizeDelta = CType(resources.GetObject("LabelControl5.Appearance.FontSizeDelta"), Integer)
        Me.LabelControl5.Appearance.FontStyleDelta = CType(resources.GetObject("LabelControl5.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.LabelControl5.Appearance.GradientMode = CType(resources.GetObject("LabelControl5.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.LabelControl5.Appearance.Image = CType(resources.GetObject("LabelControl5.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Highlighter1.SetHighlightColor(Me.LabelControl5, CType(resources.GetObject("LabelControl5.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.LabelControl5, CType(resources.GetObject("LabelControl5.HighlightOnFocus"), Boolean))
        Me.LabelControl5.Name = "LabelControl5"
        '
        'lblEmpName
        '
        resources.ApplyResources(Me.lblEmpName, "lblEmpName")
        Me.lblEmpName.EnterMoveNextControl = True
        Me.Highlighter1.SetHighlightColor(Me.lblEmpName, CType(resources.GetObject("lblEmpName.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.lblEmpName, CType(resources.GetObject("lblEmpName.HighlightOnFocus"), Boolean))
        Me.lblEmpName.Name = "lblEmpName"
        Me.lblEmpName.Properties.AccessibleDescription = resources.GetString("lblEmpName.Properties.AccessibleDescription")
        Me.lblEmpName.Properties.AccessibleName = resources.GetString("lblEmpName.Properties.AccessibleName")
        Me.lblEmpName.Properties.Appearance.BackColor = CType(resources.GetObject("lblEmpName.Properties.Appearance.BackColor"), System.Drawing.Color)
        Me.lblEmpName.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("lblEmpName.Properties.Appearance.FontSizeDelta"), Integer)
        Me.lblEmpName.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("lblEmpName.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.lblEmpName.Properties.Appearance.GradientMode = CType(resources.GetObject("lblEmpName.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.lblEmpName.Properties.Appearance.Image = CType(resources.GetObject("lblEmpName.Properties.Appearance.Image"), System.Drawing.Image)
        Me.lblEmpName.Properties.Appearance.Options.UseBackColor = True
        Me.lblEmpName.Properties.AutoHeight = CType(resources.GetObject("lblEmpName.Properties.AutoHeight"), Boolean)
        Me.lblEmpName.Properties.Mask.AutoComplete = CType(resources.GetObject("lblEmpName.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.lblEmpName.Properties.Mask.BeepOnError = CType(resources.GetObject("lblEmpName.Properties.Mask.BeepOnError"), Boolean)
        Me.lblEmpName.Properties.Mask.EditMask = resources.GetString("lblEmpName.Properties.Mask.EditMask")
        Me.lblEmpName.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("lblEmpName.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.lblEmpName.Properties.Mask.MaskType = CType(resources.GetObject("lblEmpName.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.lblEmpName.Properties.Mask.PlaceHolder = CType(resources.GetObject("lblEmpName.Properties.Mask.PlaceHolder"), Char)
        Me.lblEmpName.Properties.Mask.SaveLiteral = CType(resources.GetObject("lblEmpName.Properties.Mask.SaveLiteral"), Boolean)
        Me.lblEmpName.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("lblEmpName.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.lblEmpName.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("lblEmpName.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.lblEmpName.Properties.NullValuePrompt = resources.GetString("lblEmpName.Properties.NullValuePrompt")
        Me.lblEmpName.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("lblEmpName.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.lblEmpName.Properties.ReadOnly = True
        Me.lblEmpName.TabStop = False
        '
        'txtCode_Old
        '
        resources.ApplyResources(Me.txtCode_Old, "txtCode_Old")
        Me.txtCode_Old.EnterMoveNextControl = True
        Me.Highlighter1.SetHighlightColor(Me.txtCode_Old, CType(resources.GetObject("txtCode_Old.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.txtCode_Old, CType(resources.GetObject("txtCode_Old.HighlightOnFocus"), Boolean))
        Me.txtCode_Old.Name = "txtCode_Old"
        Me.txtCode_Old.Properties.AccessibleDescription = resources.GetString("txtCode_Old.Properties.AccessibleDescription")
        Me.txtCode_Old.Properties.AccessibleName = resources.GetString("txtCode_Old.Properties.AccessibleName")
        Me.txtCode_Old.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtCode_Old.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtCode_Old.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtCode_Old.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtCode_Old.Properties.Appearance.GradientMode = CType(resources.GetObject("txtCode_Old.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtCode_Old.Properties.Appearance.Image = CType(resources.GetObject("txtCode_Old.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtCode_Old.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCode_Old.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtCode_Old.Properties.AutoHeight = CType(resources.GetObject("txtCode_Old.Properties.AutoHeight"), Boolean)
        Me.txtCode_Old.Properties.Mask.AutoComplete = CType(resources.GetObject("txtCode_Old.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtCode_Old.Properties.Mask.BeepOnError = CType(resources.GetObject("txtCode_Old.Properties.Mask.BeepOnError"), Boolean)
        Me.txtCode_Old.Properties.Mask.EditMask = resources.GetString("txtCode_Old.Properties.Mask.EditMask")
        Me.txtCode_Old.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtCode_Old.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtCode_Old.Properties.Mask.MaskType = CType(resources.GetObject("txtCode_Old.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtCode_Old.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtCode_Old.Properties.Mask.PlaceHolder"), Char)
        Me.txtCode_Old.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtCode_Old.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtCode_Old.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtCode_Old.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtCode_Old.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtCode_Old.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtCode_Old.Properties.NullValuePrompt = resources.GetString("txtCode_Old.Properties.NullValuePrompt")
        Me.txtCode_Old.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtCode_Old.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.txtCode_Old.Properties.ReadOnly = True
        Me.txtCode_Old.TabStop = False
        '
        'frmPermission
        '
        resources.ApplyResources(Me, "$this")
        Me.Appearance.FontSizeDelta = CType(resources.GetObject("frmPermission.Appearance.FontSizeDelta"), Integer)
        Me.Appearance.FontStyleDelta = CType(resources.GetObject("frmPermission.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.Appearance.GradientMode = CType(resources.GetObject("frmPermission.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.Appearance.Image = CType(resources.GetObject("frmPermission.Appearance.Image"), System.Drawing.Image)
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GcUser)
        Me.Controls.Add(Me.lstShow)
        Me.Highlighter1.SetHighlightColor(Me, CType(resources.GetObject("$this.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me, CType(resources.GetObject("$this.HighlightOnFocus"), Boolean))
        Me.Name = "frmPermission"
        CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTransport_detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnitName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOldUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.lblEmpName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode_Old.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFind As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSetPermission As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lstShow As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents rdoGroup As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents rdoSingle As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents colNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colcode As System.Windows.Forms.ColumnHeader
    Friend WithEvents colUsername As System.Windows.Forms.ColumnHeader
    Friend WithEvents colname As System.Windows.Forms.ColumnHeader
    Friend WithEvents collastname As System.Windows.Forms.ColumnHeader
    Friend WithEvents coldiv As System.Windows.Forms.ColumnHeader
    Friend WithEvents ChkAllCompany As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents txtUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtConPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GcUser As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvUser As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colrow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode_lar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription_lar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReduc_lar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotdeduc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colremark_lar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cboTransport_detail As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboUnitName As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtOldUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblUsername As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPassword As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblConPass As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnshowemp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblEmpName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCode_Old As DevExpress.XtraEditors.TextEdit
End Class
