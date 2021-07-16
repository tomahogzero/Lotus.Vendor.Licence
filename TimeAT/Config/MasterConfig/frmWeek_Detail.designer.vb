<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWeek_Detail
    Inherits frmBasicPage2

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWeek_Detail))
        Me.lstWeek = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.colNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colST_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colP_M = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colN_M = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTo_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSP_P_M = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSP_N_M = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colEndMonth = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkEndMonth = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkNM_SP = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkNM_ST = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkPM_SP = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkPM_ST = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cboWeek = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblWK_Code = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtDaySP = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtDayST = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.lblWeek = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstWeek
        '
        resources.ApplyResources(Me.lstWeek, "lstWeek")
        '
        '
        '
        Me.lstWeek.Border.Class = "ListViewBorder"
        Me.lstWeek.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lstWeek.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNo, Me.colST_Date, Me.colP_M, Me.colN_M, Me.colTo_Date, Me.colSP_P_M, Me.colSP_N_M, Me.colEndMonth})
        Me.lstWeek.FullRowSelect = True
        Me.lstWeek.GridLines = True
        Me.Highlighter1.SetHighlightColor(Me.lstWeek, CType(resources.GetObject("lstWeek.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.lstWeek, CType(resources.GetObject("lstWeek.HighlightOnFocus"), Boolean))
        Me.lstWeek.MultiSelect = False
        Me.lstWeek.Name = "lstWeek"
        Me.lstWeek.UseCompatibleStateImageBehavior = False
        Me.lstWeek.View = System.Windows.Forms.View.Details
        '
        'colNo
        '
        resources.ApplyResources(Me.colNo, "colNo")
        '
        'colST_Date
        '
        resources.ApplyResources(Me.colST_Date, "colST_Date")
        '
        'colP_M
        '
        resources.ApplyResources(Me.colP_M, "colP_M")
        '
        'colN_M
        '
        resources.ApplyResources(Me.colN_M, "colN_M")
        '
        'colTo_Date
        '
        resources.ApplyResources(Me.colTo_Date, "colTo_Date")
        '
        'colSP_P_M
        '
        resources.ApplyResources(Me.colSP_P_M, "colSP_P_M")
        '
        'colSP_N_M
        '
        resources.ApplyResources(Me.colSP_N_M, "colSP_N_M")
        '
        'colEndMonth
        '
        resources.ApplyResources(Me.colEndMonth, "colEndMonth")
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.chkEndMonth)
        Me.GroupBox1.Controls.Add(Me.chkNM_SP)
        Me.GroupBox1.Controls.Add(Me.chkNM_ST)
        Me.GroupBox1.Controls.Add(Me.chkPM_SP)
        Me.GroupBox1.Controls.Add(Me.chkPM_ST)
        Me.GroupBox1.Controls.Add(Me.cboWeek)
        Me.GroupBox1.Controls.Add(Me.lblWK_Code)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.txtDaySP)
        Me.GroupBox1.Controls.Add(Me.txtDayST)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.lblWeek)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.Highlighter1.SetHighlightColor(Me.GroupBox1, CType(resources.GetObject("GroupBox1.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.GroupBox1, CType(resources.GetObject("GroupBox1.HighlightOnFocus"), Boolean))
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'chkEndMonth
        '
        resources.ApplyResources(Me.chkEndMonth, "chkEndMonth")
        '
        '
        '
        Me.chkEndMonth.BackgroundStyle.Class = ""
        Me.chkEndMonth.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightColor(Me.chkEndMonth, CType(resources.GetObject("chkEndMonth.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.chkEndMonth, CType(resources.GetObject("chkEndMonth.HighlightOnFocus"), Boolean))
        Me.chkEndMonth.Name = "chkEndMonth"
        Me.chkEndMonth.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'chkNM_SP
        '
        resources.ApplyResources(Me.chkNM_SP, "chkNM_SP")
        '
        '
        '
        Me.chkNM_SP.BackgroundStyle.Class = ""
        Me.chkNM_SP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightColor(Me.chkNM_SP, CType(resources.GetObject("chkNM_SP.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.chkNM_SP, CType(resources.GetObject("chkNM_SP.HighlightOnFocus"), Boolean))
        Me.chkNM_SP.Name = "chkNM_SP"
        Me.chkNM_SP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'chkNM_ST
        '
        resources.ApplyResources(Me.chkNM_ST, "chkNM_ST")
        '
        '
        '
        Me.chkNM_ST.BackgroundStyle.Class = ""
        Me.chkNM_ST.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightColor(Me.chkNM_ST, CType(resources.GetObject("chkNM_ST.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.chkNM_ST, CType(resources.GetObject("chkNM_ST.HighlightOnFocus"), Boolean))
        Me.chkNM_ST.Name = "chkNM_ST"
        Me.chkNM_ST.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'chkPM_SP
        '
        resources.ApplyResources(Me.chkPM_SP, "chkPM_SP")
        '
        '
        '
        Me.chkPM_SP.BackgroundStyle.Class = ""
        Me.chkPM_SP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightColor(Me.chkPM_SP, CType(resources.GetObject("chkPM_SP.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.chkPM_SP, CType(resources.GetObject("chkPM_SP.HighlightOnFocus"), Boolean))
        Me.chkPM_SP.Name = "chkPM_SP"
        Me.chkPM_SP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'chkPM_ST
        '
        resources.ApplyResources(Me.chkPM_ST, "chkPM_ST")
        '
        '
        '
        Me.chkPM_ST.BackgroundStyle.Class = ""
        Me.chkPM_ST.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightColor(Me.chkPM_ST, CType(resources.GetObject("chkPM_ST.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.chkPM_ST, CType(resources.GetObject("chkPM_ST.HighlightOnFocus"), Boolean))
        Me.chkPM_ST.Name = "chkPM_ST"
        Me.chkPM_ST.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cboWeek
        '
        resources.ApplyResources(Me.cboWeek, "cboWeek")
        Me.cboWeek.DisplayMember = "Text"
        Me.cboWeek.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWeek.FormattingEnabled = True
        Me.Highlighter1.SetHighlightColor(Me.cboWeek, CType(resources.GetObject("cboWeek.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.cboWeek, CType(resources.GetObject("cboWeek.HighlightOnFocus"), Boolean))
        Me.cboWeek.Name = "cboWeek"
        Me.cboWeek.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'lblWK_Code
        '
        resources.ApplyResources(Me.lblWK_Code, "lblWK_Code")
        Me.lblWK_Code.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblWK_Code.BackgroundStyle.Class = ""
        Me.lblWK_Code.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightColor(Me.lblWK_Code, CType(resources.GetObject("lblWK_Code.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.lblWK_Code, CType(resources.GetObject("lblWK_Code.HighlightOnFocus"), Boolean))
        Me.lblWK_Code.Name = "lblWK_Code"
        Me.lblWK_Code.TextAlignment = System.Drawing.StringAlignment.Far
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
        Me.Highlighter1.SetHighlightColor(Me.LabelX3, CType(resources.GetObject("LabelX3.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.LabelX3, CType(resources.GetObject("LabelX3.HighlightOnFocus"), Boolean))
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
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
        'txtDaySP
        '
        resources.ApplyResources(Me.txtDaySP, "txtDaySP")
        '
        '
        '
        Me.txtDaySP.Border.Class = "TextBoxBorder"
        Me.txtDaySP.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDaySP.ButtonCustom.DisplayPosition = CType(resources.GetObject("txtDaySP.ButtonCustom.DisplayPosition"), Integer)
        Me.txtDaySP.ButtonCustom.Image = CType(resources.GetObject("txtDaySP.ButtonCustom.Image"), System.Drawing.Image)
        Me.txtDaySP.ButtonCustom.Text = resources.GetString("txtDaySP.ButtonCustom.Text")
        Me.txtDaySP.ButtonCustom2.DisplayPosition = CType(resources.GetObject("txtDaySP.ButtonCustom2.DisplayPosition"), Integer)
        Me.txtDaySP.ButtonCustom2.Image = CType(resources.GetObject("txtDaySP.ButtonCustom2.Image"), System.Drawing.Image)
        Me.txtDaySP.ButtonCustom2.Text = resources.GetString("txtDaySP.ButtonCustom2.Text")
        Me.Highlighter1.SetHighlightColor(Me.txtDaySP, CType(resources.GetObject("txtDaySP.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.txtDaySP, CType(resources.GetObject("txtDaySP.HighlightOnFocus"), Boolean))
        Me.txtDaySP.Name = "txtDaySP"
        '
        'txtDayST
        '
        resources.ApplyResources(Me.txtDayST, "txtDayST")
        '
        '
        '
        Me.txtDayST.Border.Class = "TextBoxBorder"
        Me.txtDayST.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDayST.ButtonCustom.DisplayPosition = CType(resources.GetObject("txtDayST.ButtonCustom.DisplayPosition"), Integer)
        Me.txtDayST.ButtonCustom.Image = CType(resources.GetObject("txtDayST.ButtonCustom.Image"), System.Drawing.Image)
        Me.txtDayST.ButtonCustom.Text = resources.GetString("txtDayST.ButtonCustom.Text")
        Me.txtDayST.ButtonCustom2.DisplayPosition = CType(resources.GetObject("txtDayST.ButtonCustom2.DisplayPosition"), Integer)
        Me.txtDayST.ButtonCustom2.Image = CType(resources.GetObject("txtDayST.ButtonCustom2.Image"), System.Drawing.Image)
        Me.txtDayST.ButtonCustom2.Text = resources.GetString("txtDayST.ButtonCustom2.Text")
        Me.Highlighter1.SetHighlightColor(Me.txtDayST, CType(resources.GetObject("txtDayST.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.txtDayST, CType(resources.GetObject("txtDayST.HighlightOnFocus"), Boolean))
        Me.txtDayST.Name = "txtDayST"
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
        Me.Highlighter1.SetHighlightColor(Me.LabelX4, CType(resources.GetObject("LabelX4.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.LabelX4, CType(resources.GetObject("LabelX4.HighlightOnFocus"), Boolean))
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblWeek
        '
        resources.ApplyResources(Me.lblWeek, "lblWeek")
        '
        '
        '
        Me.lblWeek.Border.Class = "TextBoxBorder"
        Me.lblWeek.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblWeek.ButtonCustom.DisplayPosition = CType(resources.GetObject("lblWeek.ButtonCustom.DisplayPosition"), Integer)
        Me.lblWeek.ButtonCustom.Image = CType(resources.GetObject("lblWeek.ButtonCustom.Image"), System.Drawing.Image)
        Me.lblWeek.ButtonCustom.Text = resources.GetString("lblWeek.ButtonCustom.Text")
        Me.lblWeek.ButtonCustom2.DisplayPosition = CType(resources.GetObject("lblWeek.ButtonCustom2.DisplayPosition"), Integer)
        Me.lblWeek.ButtonCustom2.Image = CType(resources.GetObject("lblWeek.ButtonCustom2.Image"), System.Drawing.Image)
        Me.lblWeek.ButtonCustom2.Text = resources.GetString("lblWeek.ButtonCustom2.Text")
        Me.Highlighter1.SetHighlightColor(Me.lblWeek, CType(resources.GetObject("lblWeek.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.lblWeek, CType(resources.GetObject("lblWeek.HighlightOnFocus"), Boolean))
        Me.lblWeek.Name = "lblWeek"
        Me.lblWeek.ReadOnly = True
        Me.lblWeek.TabStop = False
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
        Me.Highlighter1.SetHighlightColor(Me.LabelX2, CType(resources.GetObject("LabelX2.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me.LabelX2, CType(resources.GetObject("LabelX2.HighlightOnFocus"), Boolean))
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        resources.ApplyResources(Me.Highlighter1, "Highlighter1")
        '
        'frmWeek_Detail
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lstWeek)
        Me.Controls.Add(Me.GroupBox1)
        Me.Highlighter1.SetHighlightColor(Me, CType(resources.GetObject("$this.HighlightColor"), DevComponents.DotNetBar.Validator.eHighlightColor))
        Me.Highlighter1.SetHighlightOnFocus(Me, CType(resources.GetObject("$this.HighlightOnFocus"), Boolean))
        Me.Name = "frmWeek_Detail"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.lstWeek, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstWeek As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents colNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colST_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents colP_M As System.Windows.Forms.ColumnHeader
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblWeek As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDayST As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents cboWeek As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblWK_Code As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkEndMonth As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkNM_SP As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkNM_ST As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkPM_SP As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkPM_ST As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDaySP As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents colN_M As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTo_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSP_P_M As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSP_N_M As System.Windows.Forms.ColumnHeader
    Friend WithEvents colEndMonth As System.Windows.Forms.ColumnHeader
End Class
