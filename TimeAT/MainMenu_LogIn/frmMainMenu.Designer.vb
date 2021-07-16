<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.Date_HD = New System.Windows.Forms.ToolStripMenuItem()
        Me.Profile = New System.Windows.Forms.ToolStripMenuItem()
        Me.Emp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TicKet = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelTicket = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.AdjustLevel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuCash = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelBillCash = New System.Windows.Forms.ToolStripMenuItem()
        Me.SlipReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddDataLearning = New System.Windows.Forms.ToolStripMenuItem()
        Me.Config_HD = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigCourseStudy = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConfigCourseLevel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigDepartment = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigLearning = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConfigAlert = New System.Windows.Forms.ToolStripMenuItem()
        Me.Report_HD = New System.Windows.Forms.ToolStripMenuItem()
        Me.RptMenber = New System.Windows.Forms.ToolStripMenuItem()
        Me.RptMemberIn = New System.Windows.Forms.ToolStripMenuItem()
        Me.RptProfit = New System.Windows.Forms.ToolStripMenuItem()
        Me.RptAddLearning = New System.Windows.Forms.ToolStripMenuItem()
        Me.Permission = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserPass = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerPattern = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenMenuProgrammer = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintPreviewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.btnProduct = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnEmp = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnTicKet = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.btnPayment = New DevComponents.DotNetBar.ButtonItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.T_Code = New System.Windows.Forms.ToolStripStatusLabel()
        Me.T_Name = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PG2 = New System.Windows.Forms.ToolStripProgressBar()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        resources.ApplyResources(Me.MenuStrip, "MenuStrip")
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Date_HD, Me.Config_HD, Me.Report_HD, Me.Permission, Me.WindowsMenu, Me.mnuExit})
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        '
        'Date_HD
        '
        Me.Date_HD.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Profile, Me.Emp, Me.ToolStripMenuItem2, Me.TicKet, Me.CancelTicket, Me.ToolStripMenuItem6, Me.AdjustLevel, Me.ToolStripMenuItem1, Me.MenuCash, Me.CancelBillCash, Me.SlipReturn, Me.ToolStripMenuItem3, Me.AddDataLearning})
        Me.Date_HD.Image = Global.RSM.My.Resources.Resources.File
        Me.Date_HD.Name = "Date_HD"
        resources.ApplyResources(Me.Date_HD, "Date_HD")
        '
        'Profile
        '
        Me.Profile.Image = Global.RSM.My.Resources.Resources.Profiles
        Me.Profile.Name = "Profile"
        resources.ApplyResources(Me.Profile, "Profile")
        Me.Profile.Tag = "Profile"
        '
        'Emp
        '
        Me.Emp.Image = Global.RSM.My.Resources.Resources.People_Groups
        Me.Emp.Name = "Emp"
        resources.ApplyResources(Me.Emp, "Emp")
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        resources.ApplyResources(Me.ToolStripMenuItem2, "ToolStripMenuItem2")
        '
        'TicKet
        '
        Me.TicKet.Image = Global.RSM.My.Resources.Resources.Create_ticket
        Me.TicKet.Name = "TicKet"
        resources.ApplyResources(Me.TicKet, "TicKet")
        '
        'CancelTicket
        '
        Me.CancelTicket.Name = "CancelTicket"
        resources.ApplyResources(Me.CancelTicket, "CancelTicket")
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        resources.ApplyResources(Me.ToolStripMenuItem6, "ToolStripMenuItem6")
        '
        'AdjustLevel
        '
        Me.AdjustLevel.Image = Global.RSM.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_7_Courses
        Me.AdjustLevel.Name = "AdjustLevel"
        resources.ApplyResources(Me.AdjustLevel, "AdjustLevel")
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        'MenuCash
        '
        Me.MenuCash.Image = Global.RSM.My.Resources.Resources.Business_Cash1
        Me.MenuCash.Name = "MenuCash"
        resources.ApplyResources(Me.MenuCash, "MenuCash")
        '
        'CancelBillCash
        '
        Me.CancelBillCash.Name = "CancelBillCash"
        resources.ApplyResources(Me.CancelBillCash, "CancelBillCash")
        '
        'SlipReturn
        '
        Me.SlipReturn.Name = "SlipReturn"
        resources.ApplyResources(Me.SlipReturn, "SlipReturn")
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        resources.ApplyResources(Me.ToolStripMenuItem3, "ToolStripMenuItem3")
        '
        'AddDataLearning
        '
        Me.AddDataLearning.Name = "AddDataLearning"
        resources.ApplyResources(Me.AddDataLearning, "AddDataLearning")
        '
        'Config_HD
        '
        Me.Config_HD.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigCourseStudy, Me.ToolStripMenuItem4, Me.ConfigCourseLevel, Me.ConfigDepartment, Me.ConfigLearning, Me.ToolStripMenuItem5, Me.ConfigAlert})
        Me.Config_HD.Image = Global.RSM.My.Resources.Resources.Settings
        Me.Config_HD.Name = "Config_HD"
        resources.ApplyResources(Me.Config_HD, "Config_HD")
        '
        'ConfigCourseStudy
        '
        Me.ConfigCourseStudy.Name = "ConfigCourseStudy"
        resources.ApplyResources(Me.ConfigCourseStudy, "ConfigCourseStudy")
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        resources.ApplyResources(Me.ToolStripMenuItem4, "ToolStripMenuItem4")
        '
        'ConfigCourseLevel
        '
        Me.ConfigCourseLevel.Name = "ConfigCourseLevel"
        resources.ApplyResources(Me.ConfigCourseLevel, "ConfigCourseLevel")
        '
        'ConfigDepartment
        '
        Me.ConfigDepartment.Name = "ConfigDepartment"
        resources.ApplyResources(Me.ConfigDepartment, "ConfigDepartment")
        '
        'ConfigLearning
        '
        Me.ConfigLearning.Name = "ConfigLearning"
        resources.ApplyResources(Me.ConfigLearning, "ConfigLearning")
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        resources.ApplyResources(Me.ToolStripMenuItem5, "ToolStripMenuItem5")
        '
        'ConfigAlert
        '
        Me.ConfigAlert.Name = "ConfigAlert"
        resources.ApplyResources(Me.ConfigAlert, "ConfigAlert")
        '
        'Report_HD
        '
        Me.Report_HD.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RptMenber, Me.RptMemberIn, Me.RptProfit, Me.RptAddLearning})
        Me.Report_HD.Image = Global.RSM.My.Resources.Resources.Treetog_Junior_Document_yellow
        Me.Report_HD.Name = "Report_HD"
        resources.ApplyResources(Me.Report_HD, "Report_HD")
        '
        'RptMenber
        '
        Me.RptMenber.Name = "RptMenber"
        resources.ApplyResources(Me.RptMenber, "RptMenber")
        '
        'RptMemberIn
        '
        Me.RptMemberIn.Name = "RptMemberIn"
        resources.ApplyResources(Me.RptMemberIn, "RptMemberIn")
        '
        'RptProfit
        '
        Me.RptProfit.Name = "RptProfit"
        resources.ApplyResources(Me.RptProfit, "RptProfit")
        '
        'RptAddLearning
        '
        Me.RptAddLearning.Name = "RptAddLearning"
        resources.ApplyResources(Me.RptAddLearning, "RptAddLearning")
        '
        'Permission
        '
        Me.Permission.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserPass, Me.PerPattern, Me.PerUser, Me.GenMenuProgrammer})
        Me.Permission.Image = Global.RSM.My.Resources.Resources.Rafiqul_Hassan_Blogger_Key
        Me.Permission.Name = "Permission"
        resources.ApplyResources(Me.Permission, "Permission")
        Me.Permission.Tag = "Permission"
        '
        'UserPass
        '
        Me.UserPass.Name = "UserPass"
        resources.ApplyResources(Me.UserPass, "UserPass")
        Me.UserPass.Tag = "UserPass"
        '
        'PerPattern
        '
        Me.PerPattern.Name = "PerPattern"
        resources.ApplyResources(Me.PerPattern, "PerPattern")
        Me.PerPattern.Tag = "PerPattern"
        '
        'PerUser
        '
        Me.PerUser.Name = "PerUser"
        resources.ApplyResources(Me.PerUser, "PerUser")
        Me.PerUser.Tag = "PerUser"
        '
        'GenMenuProgrammer
        '
        resources.ApplyResources(Me.GenMenuProgrammer, "GenMenuProgrammer")
        Me.GenMenuProgrammer.Name = "GenMenuProgrammer"
        Me.GenMenuProgrammer.Tag = ""
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
        Me.WindowsMenu.Image = Global.RSM.My.Resources.Resources.Tatice_Operating_Systems_Windows_1_
        Me.WindowsMenu.Name = "WindowsMenu"
        resources.ApplyResources(Me.WindowsMenu, "WindowsMenu")
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        resources.ApplyResources(Me.CascadeToolStripMenuItem, "CascadeToolStripMenuItem")
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        resources.ApplyResources(Me.TileVerticalToolStripMenuItem, "TileVerticalToolStripMenuItem")
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        resources.ApplyResources(Me.TileHorizontalToolStripMenuItem, "TileHorizontalToolStripMenuItem")
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        resources.ApplyResources(Me.CloseAllToolStripMenuItem, "CloseAllToolStripMenuItem")
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        resources.ApplyResources(Me.ArrangeIconsToolStripMenuItem, "ArrangeIconsToolStripMenuItem")
        '
        'mnuExit
        '
        Me.mnuExit.Image = Global.RSM.My.Resources.Resources.Log_Out
        Me.mnuExit.Name = "mnuExit"
        resources.ApplyResources(Me.mnuExit, "mnuExit")
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.ToolStripSeparator1, Me.PrintToolStripButton, Me.PrintPreviewToolStripButton, Me.ToolStripSeparator2, Me.HelpToolStripButton})
        resources.ApplyResources(Me.ToolStrip, "ToolStrip")
        Me.ToolStrip.Name = "ToolStrip"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.NewToolStripButton, "NewToolStripButton")
        Me.NewToolStripButton.Name = "NewToolStripButton"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.OpenToolStripButton, "OpenToolStripButton")
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.SaveToolStripButton, "SaveToolStripButton")
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.PrintToolStripButton, "PrintToolStripButton")
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        '
        'PrintPreviewToolStripButton
        '
        Me.PrintPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.PrintPreviewToolStripButton, "PrintPreviewToolStripButton")
        Me.PrintPreviewToolStripButton.Name = "PrintPreviewToolStripButton"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.HelpToolStripButton, "HelpToolStripButton")
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        '
        'Bar1
        '
        Me.Bar1.AntiAlias = True
        Me.Bar1.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Bar1, "Bar1")
        Me.Bar1.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Right
        Me.Bar1.ForeColor = System.Drawing.Color.Black
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem2, Me.btnProduct, Me.BtnEmp, Me.BtnTicKet, Me.ButtonItem3, Me.btnPayment})
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabStop = False
        '
        'ButtonItem2
        '
        Me.ButtonItem2.Name = "ButtonItem2"
        resources.ApplyResources(Me.ButtonItem2, "ButtonItem2")
        '
        'btnProduct
        '
        Me.btnProduct.Image = Global.RSM.My.Resources.Resources.Profiles
        Me.btnProduct.ImageIndex = 0
        Me.btnProduct.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnProduct.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F1)
        resources.ApplyResources(Me.btnProduct, "btnProduct")
        '
        'BtnEmp
        '
        Me.BtnEmp.Image = Global.RSM.My.Resources.Resources.People_Groups
        Me.BtnEmp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BtnEmp.Name = "BtnEmp"
        resources.ApplyResources(Me.BtnEmp, "BtnEmp")
        '
        'BtnTicKet
        '
        Me.BtnTicKet.Image = Global.RSM.My.Resources.Resources.Create_ticket
        Me.BtnTicKet.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BtnTicKet.Name = "BtnTicKet"
        resources.ApplyResources(Me.BtnTicKet, "BtnTicKet")
        '
        'ButtonItem3
        '
        Me.ButtonItem3.Image = Global.RSM.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_7_Courses
        Me.ButtonItem3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem3.Name = "ButtonItem3"
        resources.ApplyResources(Me.ButtonItem3, "ButtonItem3")
        '
        'btnPayment
        '
        Me.btnPayment.Image = Global.RSM.My.Resources.Resources.Business_Cash
        Me.btnPayment.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5)
        resources.ApplyResources(Me.btnPayment, "btnPayment")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel5, Me.T_Code, Me.T_Name, Me.PG2})
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        resources.ApplyResources(Me.ToolStripStatusLabel1, "ToolStripStatusLabel1")
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        resources.ApplyResources(Me.ToolStripStatusLabel5, "ToolStripStatusLabel5")
        '
        'T_Code
        '
        resources.ApplyResources(Me.T_Code, "T_Code")
        Me.T_Code.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.T_Code.Name = "T_Code"
        '
        'T_Name
        '
        resources.ApplyResources(Me.T_Name, "T_Name")
        Me.T_Name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_Name.Name = "T_Name"
        '
        'PG2
        '
        Me.PG2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.PG2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PG2.MergeIndex = 0
        Me.PG2.Name = "PG2"
        resources.ApplyResources(Me.PG2, "PG2")
        Me.PG2.Step = 1
        Me.PG2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'frmMainMenu
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Bar1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMainMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintPreviewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Config_HD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigCourseStudy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigCourseLevel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigDepartment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Date_HD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Profile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuCash As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Emp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigLearning As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TicKet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdjustLevel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnProduct As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnEmp As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnTicKet As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnPayment As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddDataLearning As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigAlert As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Report_HD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RptMenber As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RptMemberIn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RptProfit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RptAddLearning As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CancelBillCash As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SlipReturn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelTicket As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Permission As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserPass As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerPattern As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenMenuProgrammer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents T_Code As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents T_Name As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PG2 As System.Windows.Forms.ToolStripProgressBar

End Class
