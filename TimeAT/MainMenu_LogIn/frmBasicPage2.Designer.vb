<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBasicPage2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBasicPage2))
        Me.BarMaster = New DevComponents.DotNetBar.Bar
        Me.btnAdd = New DevComponents.DotNetBar.ButtonItem
        Me.btnEdit = New DevComponents.DotNetBar.ButtonItem
        Me.btnDelete = New DevComponents.DotNetBar.ButtonItem
        Me.BtnDelAll = New DevComponents.DotNetBar.ButtonItem
        Me.btnClear = New DevComponents.DotNetBar.ButtonItem
        Me.btnSearch = New DevComponents.DotNetBar.ButtonItem
        Me.btnPrint = New DevComponents.DotNetBar.ButtonItem
        Me.btnAutosave = New DevComponents.DotNetBar.ButtonItem
        Me.btnExit = New DevComponents.DotNetBar.ButtonItem
        CType(Me.BarMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarMaster
        '
        Me.BarMaster.AntiAlias = True
        resources.ApplyResources(Me.BarMaster, "BarMaster")
        Me.BarMaster.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnAdd, Me.btnEdit, Me.btnDelete, Me.BtnDelAll, Me.btnClear, Me.btnSearch, Me.btnPrint, Me.btnAutosave, Me.btnExit})
        Me.BarMaster.Name = "BarMaster"
        Me.BarMaster.Stretch = True
        Me.BarMaster.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BarMaster.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnAdd.Image = Global.TimeAttendance.My.Resources.Resources.Actions_stock_save_as_1_
        Me.btnAdd.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnAdd.Name = "btnAdd"
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        '
        'btnEdit
        '
        Me.btnEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnEdit.Image = Global.TimeAttendance.My.Resources.Resources.Pencil
        Me.btnEdit.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnEdit.Name = "btnEdit"
        resources.ApplyResources(Me.btnEdit, "btnEdit")
        '
        'btnDelete
        '
        Me.btnDelete.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnDelete.Image = Global.TimeAttendance.My.Resources.Resources.Actions_button_cancel
        Me.btnDelete.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnDelete.Name = "btnDelete"
        resources.ApplyResources(Me.btnDelete, "btnDelete")
        '
        'BtnDelAll
        '
        Me.BtnDelAll.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnDelAll.Name = "BtnDelAll"
        resources.ApplyResources(Me.BtnDelAll, "BtnDelAll")
        '
        'btnClear
        '
        Me.btnClear.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnClear.Image = Global.TimeAttendance.My.Resources.Resources.Actions_edit_clear_locationbar_rtl1
        Me.btnClear.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnClear.Name = "btnClear"
        resources.ApplyResources(Me.btnClear, "btnClear")
        '
        'btnSearch
        '
        Me.btnSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnSearch.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnSearch.Name = "btnSearch"
        resources.ApplyResources(Me.btnSearch, "btnSearch")
        '
        'btnPrint
        '
        Me.btnPrint.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnPrint.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnPrint.Name = "btnPrint"
        resources.ApplyResources(Me.btnPrint, "btnPrint")
        '
        'btnAutosave
        '
        Me.btnAutosave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnAutosave.ImageFixedSize = New System.Drawing.Size(14, 14)
        Me.btnAutosave.Name = "btnAutosave"
        resources.ApplyResources(Me.btnAutosave, "btnAutosave")
        '
        'btnExit
        '
        Me.btnExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnExit.Image = Global.TimeAttendance.My.Resources.Resources.Logout_1_
        Me.btnExit.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnExit.Name = "btnExit"
        resources.ApplyResources(Me.btnExit, "btnExit")
        '
        'frmBasicPage2
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BarMaster)
        Me.Name = "frmBasicPage2"
        CType(Me.BarMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarMaster As DevComponents.DotNetBar.Bar
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnClear As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnSearch As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnPrint As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnAutosave As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnDelAll As DevComponents.DotNetBar.ButtonItem

End Class
