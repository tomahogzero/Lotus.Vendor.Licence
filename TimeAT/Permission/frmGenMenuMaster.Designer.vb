<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenMenuMaster
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
        Me.btnAddAuto = New DevComponents.DotNetBar.ButtonX
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.ChkMenuMain = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.ChkReadOnly = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.ChkFormApprove = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.lstMenu = New DevComponents.DotNetBar.Controls.ListViewEx
        Me.colNo = New System.Windows.Forms.ColumnHeader
        Me.ColRunning = New System.Windows.Forms.ColumnHeader
        Me.ColMenuId = New System.Windows.Forms.ColumnHeader
        Me.ColMenuName = New System.Windows.Forms.ColumnHeader
        Me.ColMenuEng = New System.Windows.Forms.ColumnHeader
        Me.ColMenu_LinkFrom = New System.Windows.Forms.ColumnHeader
        Me.ColNoPic = New System.Windows.Forms.ColumnHeader
        Me.colLastUpdate = New System.Windows.Forms.ColumnHeader
        Me.St_Approve = New System.Windows.Forms.ColumnHeader
        Me.ColReadOnly = New System.Windows.Forms.ColumnHeader
        Me.CalSetMainMenu = New System.Windows.Forms.ColumnHeader
        Me.txtOldMenuId = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txtMenuId = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtMenuNameEng = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.txtMenuName = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.txtNo_Pic = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lstMenuGroup = New DevComponents.DotNetBar.Controls.ListViewEx
        Me.ColNum = New System.Windows.Forms.ColumnHeader
        Me.ColMainMenuId = New System.Windows.Forms.ColumnHeader
        Me.ColMainMenu = New System.Windows.Forms.ColumnHeader
        Me.ColSubMenuId = New System.Windows.Forms.ColumnHeader
        Me.ColSubMenuName = New System.Windows.Forms.ColumnHeader
        Me.CboMenuMain = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.CboSubMenu = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.btnRefresh = New DevComponents.DotNetBar.ButtonX
        Me.BtnDelGroup = New DevComponents.DotNetBar.ButtonX
        Me.CboSaveGroup = New DevComponents.DotNetBar.ButtonX
        Me.txtSubId = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtMainId = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.ChkByItem = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.btnRunning = New DevComponents.DotNetBar.ButtonX
        Me.BtnGenMenuAuto = New DevComponents.DotNetBar.ButtonX
        Me.btnPageMenu = New DevComponents.DotNetBar.ButtonX
        Me.btnExit = New DevComponents.DotNetBar.ButtonX
        Me.btnClear = New DevComponents.DotNetBar.ButtonX
        Me.btnDelete = New DevComponents.DotNetBar.ButtonX
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddAuto
        '
        Me.btnAddAuto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAddAuto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAddAuto.Location = New System.Drawing.Point(1117, 46)
        Me.btnAddAuto.Name = "btnAddAuto"
        Me.btnAddAuto.Size = New System.Drawing.Size(148, 50)
        Me.btnAddAuto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAddAuto.TabIndex = 28
        Me.btnAddAuto.Text = "บันทึกเมนู Auto ทั้งหมด กำหนดครั้งแรกครั้งเดียว ไม่งั้น กลุ่มเมนุอาจเพี้ยนได้"
        Me.btnAddAuto.Visible = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.ChkMenuMain)
        Me.GroupPanel1.Controls.Add(Me.ChkReadOnly)
        Me.GroupPanel1.Controls.Add(Me.ChkFormApprove)
        Me.GroupPanel1.Location = New System.Drawing.Point(16, 122)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(439, 29)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 27
        '
        'ChkMenuMain
        '
        Me.ChkMenuMain.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ChkMenuMain.BackgroundStyle.Class = ""
        Me.ChkMenuMain.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChkMenuMain.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ChkMenuMain.Location = New System.Drawing.Point(6, -3)
        Me.ChkMenuMain.Name = "ChkMenuMain"
        Me.ChkMenuMain.Size = New System.Drawing.Size(135, 29)
        Me.ChkMenuMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ChkMenuMain.TabIndex = 1
        Me.ChkMenuMain.Text = "กำหนดว่าเป็นเมนูหลัก"
        '
        'ChkReadOnly
        '
        Me.ChkReadOnly.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ChkReadOnly.BackgroundStyle.Class = ""
        Me.ChkReadOnly.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChkReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ChkReadOnly.Location = New System.Drawing.Point(318, -2)
        Me.ChkReadOnly.Name = "ChkReadOnly"
        Me.ChkReadOnly.Size = New System.Drawing.Size(105, 29)
        Me.ChkReadOnly.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ChkReadOnly.TabIndex = 0
        Me.ChkReadOnly.Text = "ReadOnly"
        '
        'ChkFormApprove
        '
        Me.ChkFormApprove.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ChkFormApprove.BackgroundStyle.Class = ""
        Me.ChkFormApprove.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChkFormApprove.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ChkFormApprove.Location = New System.Drawing.Point(175, -3)
        Me.ChkFormApprove.Name = "ChkFormApprove"
        Me.ChkFormApprove.Size = New System.Drawing.Size(105, 29)
        Me.ChkFormApprove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ChkFormApprove.TabIndex = 0
        Me.ChkFormApprove.Text = "กำหนดผู้อนุมัติ"
        '
        'lstMenu
        '
        Me.lstMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.lstMenu.Border.Class = "ListViewBorder"
        Me.lstMenu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lstMenu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNo, Me.ColRunning, Me.ColMenuId, Me.ColMenuName, Me.ColMenuEng, Me.ColMenu_LinkFrom, Me.ColNoPic, Me.colLastUpdate, Me.St_Approve, Me.ColReadOnly, Me.CalSetMainMenu})
        Me.lstMenu.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lstMenu.FullRowSelect = True
        Me.lstMenu.GridLines = True
        Me.lstMenu.Location = New System.Drawing.Point(4, 237)
        Me.lstMenu.MultiSelect = False
        Me.lstMenu.Name = "lstMenu"
        Me.lstMenu.Size = New System.Drawing.Size(646, 313)
        Me.lstMenu.TabIndex = 26
        Me.lstMenu.UseCompatibleStateImageBehavior = False
        Me.lstMenu.View = System.Windows.Forms.View.Details
        '
        'colNo
        '
        Me.colNo.Text = "ที่"
        Me.colNo.Width = 34
        '
        'ColRunning
        '
        Me.ColRunning.Text = "Running"
        Me.ColRunning.Width = 100
        '
        'ColMenuId
        '
        Me.ColMenuId.Text = "MenuId"
        Me.ColMenuId.Width = 100
        '
        'ColMenuName
        '
        Me.ColMenuName.Text = "ชื่อเมนู"
        Me.ColMenuName.Width = 130
        '
        'ColMenuEng
        '
        Me.ColMenuEng.Text = "เมนู Eng (อ้างอิงในฟอร์ม)"
        Me.ColMenuEng.Width = 160
        '
        'ColMenu_LinkFrom
        '
        Me.ColMenu_LinkFrom.Text = "TagLinkFrom"
        Me.ColMenu_LinkFrom.Width = 160
        '
        'ColNoPic
        '
        Me.ColNoPic.Text = "ลำดับ Icon รูป"
        Me.ColNoPic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColNoPic.Width = 120
        '
        'colLastUpdate
        '
        Me.colLastUpdate.Text = "Last updated"
        Me.colLastUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colLastUpdate.Width = 0
        '
        'St_Approve
        '
        Me.St_Approve.Text = "อนุมัติ"
        Me.St_Approve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.St_Approve.Width = 90
        '
        'ColReadOnly
        '
        Me.ColReadOnly.Text = "ReadOnly"
        Me.ColReadOnly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColReadOnly.Width = 90
        '
        'CalSetMainMenu
        '
        Me.CalSetMainMenu.Text = "ตั้งค่าเมนูหลัก"
        Me.CalSetMainMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CalSetMainMenu.Width = 90
        '
        'txtOldMenuId
        '
        Me.txtOldMenuId.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtOldMenuId.Border.Class = "TextBoxBorder"
        Me.txtOldMenuId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtOldMenuId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtOldMenuId.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtOldMenuId.Location = New System.Drawing.Point(283, 15)
        Me.txtOldMenuId.MaxLength = 10
        Me.txtOldMenuId.Name = "txtOldMenuId"
        Me.txtOldMenuId.Size = New System.Drawing.Size(57, 21)
        Me.txtOldMenuId.TabIndex = 38
        Me.txtOldMenuId.Visible = False
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(16, 13)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(112, 20)
        Me.LabelX1.TabIndex = 37
        Me.LabelX1.Text = "รหัสเมนู : "
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtMenuId
        '
        Me.txtMenuId.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtMenuId.Border.Class = "TextBoxBorder"
        Me.txtMenuId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMenuId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtMenuId.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtMenuId.Location = New System.Drawing.Point(134, 14)
        Me.txtMenuId.MaxLength = 15
        Me.txtMenuId.Name = "txtMenuId"
        Me.txtMenuId.Size = New System.Drawing.Size(143, 21)
        Me.txtMenuId.TabIndex = 0
        '
        'txtMenuNameEng
        '
        Me.txtMenuNameEng.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtMenuNameEng.Border.Class = "TextBoxBorder"
        Me.txtMenuNameEng.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMenuNameEng.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtMenuNameEng.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtMenuNameEng.Location = New System.Drawing.Point(134, 70)
        Me.txtMenuNameEng.MaxLength = 50
        Me.txtMenuNameEng.Name = "txtMenuNameEng"
        Me.txtMenuNameEng.Size = New System.Drawing.Size(206, 21)
        Me.txtMenuNameEng.TabIndex = 2
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(5, 70)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(123, 20)
        Me.LabelX4.TabIndex = 35
        Me.LabelX4.Text = "ชื่อเมนู Eng  : "
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtMenuName
        '
        Me.txtMenuName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtMenuName.Border.Class = "TextBoxBorder"
        Me.txtMenuName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMenuName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtMenuName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtMenuName.Location = New System.Drawing.Point(134, 44)
        Me.txtMenuName.MaxLength = 50
        Me.txtMenuName.Name = "txtMenuName"
        Me.txtMenuName.Size = New System.Drawing.Size(206, 21)
        Me.txtMenuName.TabIndex = 1
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(16, 44)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(112, 20)
        Me.LabelX2.TabIndex = 36
        Me.LabelX2.Text = "ชื่อเมนูไทย : "
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(16, 96)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(112, 20)
        Me.LabelX6.TabIndex = 35
        Me.LabelX6.Text = "ลำดับรูป :"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtNo_Pic
        '
        Me.txtNo_Pic.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNo_Pic.Border.Class = "TextBoxBorder"
        Me.txtNo_Pic.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNo_Pic.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNo_Pic.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNo_Pic.Location = New System.Drawing.Point(134, 95)
        Me.txtNo_Pic.MaxLength = 50
        Me.txtNo_Pic.Name = "txtNo_Pic"
        Me.txtNo_Pic.Size = New System.Drawing.Size(206, 21)
        Me.txtNo_Pic.TabIndex = 3
        '
        'lstMenuGroup
        '
        Me.lstMenuGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.lstMenuGroup.Border.Class = "ListViewBorder"
        Me.lstMenuGroup.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lstMenuGroup.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColNum, Me.ColMainMenuId, Me.ColMainMenu, Me.ColSubMenuId, Me.ColSubMenuName})
        Me.lstMenuGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lstMenuGroup.FullRowSelect = True
        Me.lstMenuGroup.GridLines = True
        Me.lstMenuGroup.Location = New System.Drawing.Point(656, 237)
        Me.lstMenuGroup.MultiSelect = False
        Me.lstMenuGroup.Name = "lstMenuGroup"
        Me.lstMenuGroup.Size = New System.Drawing.Size(618, 313)
        Me.lstMenuGroup.TabIndex = 39
        Me.lstMenuGroup.UseCompatibleStateImageBehavior = False
        Me.lstMenuGroup.View = System.Windows.Forms.View.Details
        '
        'ColNum
        '
        Me.ColNum.Text = "#"
        Me.ColNum.Width = 34
        '
        'ColMainMenuId
        '
        Me.ColMainMenuId.Text = "MainID"
        Me.ColMainMenuId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColMainMenuId.Width = 78
        '
        'ColMainMenu
        '
        Me.ColMainMenu.Text = "ชื่อเมนูหลัก"
        Me.ColMainMenu.Width = 130
        '
        'ColSubMenuId
        '
        Me.ColSubMenuId.Text = "SubMenuID"
        Me.ColSubMenuId.Width = 160
        '
        'ColSubMenuName
        '
        Me.ColSubMenuName.Text = "ชื่อเมนูรอง"
        Me.ColSubMenuName.Width = 300
        '
        'CboMenuMain
        '
        Me.CboMenuMain.DisplayMember = "Text"
        Me.CboMenuMain.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CboMenuMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMenuMain.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CboMenuMain.FormattingEnabled = True
        Me.CboMenuMain.ItemHeight = 20
        Me.CboMenuMain.Location = New System.Drawing.Point(90, 10)
        Me.CboMenuMain.Name = "CboMenuMain"
        Me.CboMenuMain.Size = New System.Drawing.Size(402, 26)
        Me.CboMenuMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CboMenuMain.TabIndex = 40
        '
        'CboSubMenu
        '
        Me.CboSubMenu.DisplayMember = "Text"
        Me.CboSubMenu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CboSubMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSubMenu.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CboSubMenu.FormattingEnabled = True
        Me.CboSubMenu.ItemHeight = 20
        Me.CboSubMenu.Location = New System.Drawing.Point(90, 37)
        Me.CboSubMenu.Name = "CboSubMenu"
        Me.CboSubMenu.Size = New System.Drawing.Size(402, 26)
        Me.CboSubMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CboSubMenu.TabIndex = 40
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.LabelX9)
        Me.GroupPanel2.Controls.Add(Me.LabelX10)
        Me.GroupPanel2.Controls.Add(Me.btnRefresh)
        Me.GroupPanel2.Controls.Add(Me.BtnDelGroup)
        Me.GroupPanel2.Controls.Add(Me.CboSaveGroup)
        Me.GroupPanel2.Controls.Add(Me.txtSubId)
        Me.GroupPanel2.Controls.Add(Me.txtMainId)
        Me.GroupPanel2.Controls.Add(Me.LabelX5)
        Me.GroupPanel2.Controls.Add(Me.LabelX3)
        Me.GroupPanel2.Controls.Add(Me.CboSubMenu)
        Me.GroupPanel2.Controls.Add(Me.CboMenuMain)
        Me.GroupPanel2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(656, 12)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(618, 219)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.Class = ""
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.Class = ""
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.Class = ""
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 41
        Me.GroupPanel2.Text = "จัดกลุ่มเมนู"
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.Class = ""
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelX9.Location = New System.Drawing.Point(3, 139)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(394, 20)
        Me.LabelX9.TabIndex = 45
        Me.LabelX9.Text = "** การกำหนดกลุ่มเมนูตรงนี้มีผลกับการแสดงเมนูในโปรแกรม  กรุณาตรวจสอบ"
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.Class = ""
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelX10.Location = New System.Drawing.Point(3, 165)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(394, 17)
        Me.LabelX10.TabIndex = 46
        Me.LabelX10.Text = "และกำหนดเมนูให้ครบถ้วน"
        '
        'btnRefresh
        '
        Me.btnRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRefresh.Location = New System.Drawing.Point(262, 75)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(137, 51)
        Me.btnRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRefresh.TabIndex = 44
        Me.btnRefresh.Text = "รีเฟรช"
        '
        'BtnDelGroup
        '
        Me.BtnDelGroup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnDelGroup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnDelGroup.Location = New System.Drawing.Point(140, 75)
        Me.BtnDelGroup.Name = "BtnDelGroup"
        Me.BtnDelGroup.Size = New System.Drawing.Size(116, 52)
        Me.BtnDelGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnDelGroup.TabIndex = 43
        Me.BtnDelGroup.Text = "ลบ"
        '
        'CboSaveGroup
        '
        Me.CboSaveGroup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.CboSaveGroup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.CboSaveGroup.Location = New System.Drawing.Point(4, 75)
        Me.CboSaveGroup.Name = "CboSaveGroup"
        Me.CboSaveGroup.Size = New System.Drawing.Size(130, 52)
        Me.CboSaveGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CboSaveGroup.TabIndex = 43
        Me.CboSaveGroup.Text = "บันทึก"
        '
        'txtSubId
        '
        Me.txtSubId.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtSubId.Border.Class = "TextBoxBorder"
        Me.txtSubId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSubId.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSubId.Location = New System.Drawing.Point(498, 38)
        Me.txtSubId.Name = "txtSubId"
        Me.txtSubId.Size = New System.Drawing.Size(68, 23)
        Me.txtSubId.TabIndex = 42
        '
        'txtMainId
        '
        Me.txtMainId.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtMainId.Border.Class = "TextBoxBorder"
        Me.txtMainId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMainId.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtMainId.Location = New System.Drawing.Point(498, 11)
        Me.txtMainId.Name = "txtMainId"
        Me.txtMainId.Size = New System.Drawing.Size(68, 23)
        Me.txtMainId.TabIndex = 42
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(16, 37)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(68, 21)
        Me.LabelX5.TabIndex = 41
        Me.LabelX5.Text = "เมนูย่อย :"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(16, 10)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(68, 21)
        Me.LabelX3.TabIndex = 41
        Me.LabelX3.Text = "เมนูหลัก :"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.ChkByItem)
        Me.GroupPanel3.Controls.Add(Me.txtOldMenuId)
        Me.GroupPanel3.Controls.Add(Me.LabelX1)
        Me.GroupPanel3.Controls.Add(Me.btnRunning)
        Me.GroupPanel3.Controls.Add(Me.BtnGenMenuAuto)
        Me.GroupPanel3.Controls.Add(Me.txtMenuId)
        Me.GroupPanel3.Controls.Add(Me.txtNo_Pic)
        Me.GroupPanel3.Controls.Add(Me.txtMenuNameEng)
        Me.GroupPanel3.Controls.Add(Me.LabelX6)
        Me.GroupPanel3.Controls.Add(Me.LabelX4)
        Me.GroupPanel3.Controls.Add(Me.txtMenuName)
        Me.GroupPanel3.Controls.Add(Me.LabelX2)
        Me.GroupPanel3.Controls.Add(Me.GroupPanel1)
        Me.GroupPanel3.Controls.Add(Me.btnPageMenu)
        Me.GroupPanel3.Controls.Add(Me.btnExit)
        Me.GroupPanel3.Controls.Add(Me.btnClear)
        Me.GroupPanel3.Controls.Add(Me.btnDelete)
        Me.GroupPanel3.Controls.Add(Me.btnEdit)
        Me.GroupPanel3.Controls.Add(Me.btnAdd)
        Me.GroupPanel3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupPanel3.Location = New System.Drawing.Point(4, 8)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(646, 223)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.Class = ""
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.Class = ""
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.Class = ""
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 42
        Me.GroupPanel3.Text = "กำหนดเมนูใหม่"
        '
        'ChkByItem
        '
        Me.ChkByItem.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ChkByItem.BackgroundStyle.Class = ""
        Me.ChkByItem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChkByItem.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.ChkByItem.Checked = True
        Me.ChkByItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkByItem.CheckValue = "Y"
        Me.ChkByItem.Location = New System.Drawing.Point(522, 172)
        Me.ChkByItem.Name = "ChkByItem"
        Me.ChkByItem.Size = New System.Drawing.Size(115, 23)
        Me.ChkByItem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ChkByItem.TabIndex = 0
        Me.ChkByItem.Text = "เรียงตามรหัสเมนู"
        '
        'btnRunning
        '
        Me.btnRunning.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRunning.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRunning.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRunning.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btnRunning.Location = New System.Drawing.Point(346, 67)
        Me.btnRunning.Name = "btnRunning"
        Me.btnRunning.Size = New System.Drawing.Size(122, 48)
        Me.btnRunning.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRunning.TabIndex = 8
        Me.btnRunning.Text = "Update ลำดับเมนูใหม่"
        '
        'BtnGenMenuAuto
        '
        Me.BtnGenMenuAuto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnGenMenuAuto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnGenMenuAuto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnGenMenuAuto.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.BtnGenMenuAuto.Location = New System.Drawing.Point(346, 13)
        Me.BtnGenMenuAuto.Name = "BtnGenMenuAuto"
        Me.BtnGenMenuAuto.Size = New System.Drawing.Size(122, 48)
        Me.BtnGenMenuAuto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnGenMenuAuto.TabIndex = 8
        Me.BtnGenMenuAuto.Text = "Gen เมนูใหม่ Auto"
        '
        'btnPageMenu
        '
        Me.btnPageMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPageMenu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPageMenu.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPageMenu.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btnPageMenu.Location = New System.Drawing.Point(522, 14)
        Me.btnPageMenu.Name = "btnPageMenu"
        Me.btnPageMenu.Size = New System.Drawing.Size(115, 46)
        Me.btnPageMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPageMenu.TabIndex = 8
        Me.btnPageMenu.Text = "บันทึกเมนูรอง"
        '
        'btnExit
        '
        Me.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnExit.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btnExit.Location = New System.Drawing.Point(372, 157)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 38)
        Me.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "ออก"
        '
        'btnClear
        '
        Me.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClear.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btnClear.Location = New System.Drawing.Point(283, 157)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 38)
        Me.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "เคลียร์"
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDelete.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btnDelete.Location = New System.Drawing.Point(194, 157)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(83, 38)
        Me.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "ลบ"
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEdit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnEdit.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btnEdit.Location = New System.Drawing.Point(105, 157)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(83, 38)
        Me.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "แก้ไข"
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btnAdd.Location = New System.Drawing.Point(16, 157)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(83, 38)
        Me.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "เพิ่ม"
        '
        'frmGenMenuMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1277, 562)
        Me.Controls.Add(Me.GroupPanel3)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.lstMenuGroup)
        Me.Controls.Add(Me.btnAddAuto)
        Me.Controls.Add(Me.lstMenu)
        Me.Name = "frmGenMenuMaster"
        Me.Text = "กำหนดเมนูเริ่มต้น เฉพาะโปรแกรมเมอร์"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAddAuto As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ChkFormApprove As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents lstMenu As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents colNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColMenuId As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColMenuName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColMenuEng As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColMenu_LinkFrom As System.Windows.Forms.ColumnHeader
    Friend WithEvents colLastUpdate As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ColNoPic As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtOldMenuId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMenuId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtMenuNameEng As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMenuName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ChkMenuMain As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNo_Pic As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lstMenuGroup As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents ColNum As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColMainMenuId As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColMainMenu As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColSubMenuId As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColSubMenuName As System.Windows.Forms.ColumnHeader
    Friend WithEvents CboMenuMain As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents CboSubMenu As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtSubId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtMainId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CboSaveGroup As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnDelGroup As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnRefresh As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ChkReadOnly As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents St_Approve As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColReadOnly As System.Windows.Forms.ColumnHeader
    Friend WithEvents CalSetMainMenu As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ChkByItem As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnGenMenuAuto As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnRunning As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ColRunning As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPageMenu As DevComponents.DotNetBar.ButtonX
End Class
