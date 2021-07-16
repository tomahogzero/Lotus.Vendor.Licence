<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBasicPage3
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBasicPage2))
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonItem()
        Me.btnEdit = New DevComponents.DotNetBar.ButtonItem()
        Me.btnDelete = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnDelAll = New DevComponents.DotNetBar.ButtonItem()
        Me.btnClear = New DevComponents.DotNetBar.ButtonItem()
        Me.btnSearch = New DevComponents.DotNetBar.ButtonItem()
        Me.btnPrint = New DevComponents.DotNetBar.ButtonItem()
        Me.btnAutosave = New DevComponents.DotNetBar.ButtonItem()
        Me.btnExit = New DevComponents.DotNetBar.ButtonItem()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar1
        '
        Me.Bar1.AntiAlias = True
        resources.ApplyResources(Me.Bar1, "Bar1")
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnAdd, Me.btnEdit, Me.btnDelete, Me.BtnDelAll, Me.btnClear, Me.btnSearch, Me.btnPrint, Me.btnAutosave, Me.btnExit})
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabStop = False
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
        Me.btnClear.Image = Global.TimeAttendance.My.Resources.Resources.Actions_edit_clear_locationbar_rtl
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
        Me.btnExit.Image = Global.TimeAttendance.My.Resources.Resources.logout
        Me.btnExit.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnExit.Name = "btnExit"
        resources.ApplyResources(Me.btnExit, "btnExit")
        '
        'frmBasicPage2
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Bar1)
        Me.Name = "frmBasicPage2"
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
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
