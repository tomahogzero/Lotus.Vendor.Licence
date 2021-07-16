<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportMonthlySumary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportMonthlySumary))
        Me.txtMonthYear = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnReport = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtMonthYear
        '
        Me.txtMonthYear.AccessibleDescription = Nothing
        Me.txtMonthYear.AccessibleName = Nothing
        resources.ApplyResources(Me.txtMonthYear, "txtMonthYear")
        Me.txtMonthYear.BackgroundImage = Nothing
        Me.txtMonthYear.Font = Nothing
        Me.txtMonthYear.Name = "txtMonthYear"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Font = Nothing
        Me.Label1.Name = "Label1"
        '
        'btnReport
        '
        Me.btnReport.AccessibleDescription = Nothing
        Me.btnReport.AccessibleName = Nothing
        resources.ApplyResources(Me.btnReport, "btnReport")
        Me.btnReport.BackgroundImage = Nothing
        Me.btnReport.Font = Nothing
        Me.btnReport.Name = "btnReport"
        Me.btnReport.UseVisualStyleBackColor = True
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
        'frmReportMonthlySumary
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMonthYear)
        Me.Font = Nothing
        Me.Icon = Nothing
        Me.Name = "frmReportMonthlySumary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMonthYear As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
