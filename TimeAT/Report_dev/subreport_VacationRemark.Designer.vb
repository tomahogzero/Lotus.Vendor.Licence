<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class subreport_VacationRemark
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(subreport_VacationRemark))
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.hide_Price = New DevExpress.XtraReports.UI.FormattingRule()
        Me.hide_disPer = New DevExpress.XtraReports.UI.FormattingRule()
        Me.hide_remark = New DevExpress.XtraReports.UI.FormattingRule()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.hide_disPer_bill = New DevExpress.XtraReports.UI.FormattingRule()
        Me.hide_Tax = New DevExpress.XtraReports.UI.FormattingRule()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageHeaderCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageHeaderField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.hide_lastPage = New DevExpress.XtraReports.UI.FormattingRule()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel4, Me.XrLabel1})
        resources.ApplyResources(Me.Detail, "Detail")
        Me.Detail.KeepTogether = True
        Me.Detail.MultiColumn.ColumnCount = 3
        Me.Detail.MultiColumn.ColumnWidth = 220.0!
        Me.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
        Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Code", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        '
        'XrLabel2
        '
        resources.ApplyResources(Me.XrLabel2, "XrLabel2")
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel2.BorderWidth = 1.0!
        Me.XrLabel2.CanGrow = False
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseBorderColor = False
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseBorderWidth = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.StylePriority.UsePadding = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary1, "XrSummary1")
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel2.Summary = XrSummary1
        '
        'XrLabel4
        '
        resources.ApplyResources(Me.XrLabel4, "XrLabel4")
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.BorderWidth = 1.0!
        Me.XrLabel4.CanGrow = False
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.Description")})
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseBorderColor = False
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseBorderWidth = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UsePadding = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary2, "XrSummary2")
        XrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel4.Summary = XrSummary2
        '
        'XrLabel1
        '
        resources.ApplyResources(Me.XrLabel1, "XrLabel1")
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.BorderWidth = 1.0!
        Me.XrLabel1.CanGrow = False
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.Code")})
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseBorderColor = False
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseBorderWidth = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UsePadding = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary3, "XrSummary3")
        XrSummary3.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel1.Summary = XrSummary3
        '
        'hide_Price
        '
        Me.hide_Price.Condition = "[Parameters.ShowPrice] = 0"
        Me.hide_Price.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.hide_Price.Name = "hide_Price"
        '
        'hide_disPer
        '
        Me.hide_disPer.Condition = "[disPer] = 0"
        Me.hide_disPer.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.hide_disPer.Name = "hide_disPer"
        '
        'hide_remark
        '
        Me.hide_remark.Condition = "[remark] = ''"
        Me.hide_remark.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.hide_remark.Name = "hide_remark"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "payroll_Connection"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        ColumnExpression1.ColumnName = "Code"
        Table1.Name = "TimeWorkingStatus"
        ColumnExpression1.Table = Table1
        Column1.Expression = ColumnExpression1
        ColumnExpression2.ColumnName = "Description"
        ColumnExpression2.Table = Table1
        Column2.Expression = ColumnExpression2
        SelectQuery1.Columns.Add(Column1)
        SelectQuery1.Columns.Add(Column2)
        SelectQuery1.Name = "Query"
        SelectQuery1.Tables.Add(Table1)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0iU3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IlF1ZXJ5Ij48RmllbGQgTmFtZ" &
    "T0iQ29kZSIgVHlwZT0iU3RyaW5nIiAvPjxGaWVsZCBOYW1lPSJEZXNjcmlwdGlvbiIgVHlwZT0iU3Rya" &
    "W5nIiAvPjwvVmlldz48L0RhdGFTZXQ+"
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3})
        resources.ApplyResources(Me.XrTableRow1, "XrTableRow1")
        Me.XrTableRow1.Name = "XrTableRow1"
        '
        'XrTableCell1
        '
        resources.ApplyResources(Me.XrTableCell1, "XrTableCell1")
        Me.XrTableCell1.Name = "XrTableCell1"
        '
        'XrTableCell2
        '
        resources.ApplyResources(Me.XrTableCell2, "XrTableCell2")
        Me.XrTableCell2.Name = "XrTableCell2"
        '
        'XrTableCell3
        '
        resources.ApplyResources(Me.XrTableCell3, "XrTableCell3")
        Me.XrTableCell3.Name = "XrTableCell3"
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6})
        resources.ApplyResources(Me.XrTableRow2, "XrTableRow2")
        Me.XrTableRow2.Name = "XrTableRow2"
        '
        'XrTableCell4
        '
        resources.ApplyResources(Me.XrTableCell4, "XrTableCell4")
        Me.XrTableCell4.Name = "XrTableCell4"
        '
        'XrTableCell5
        '
        resources.ApplyResources(Me.XrTableCell5, "XrTableCell5")
        Me.XrTableCell5.Name = "XrTableCell5"
        '
        'XrTableCell6
        '
        resources.ApplyResources(Me.XrTableCell6, "XrTableCell6")
        Me.XrTableCell6.Name = "XrTableCell6"
        '
        'hide_disPer_bill
        '
        Me.hide_disPer_bill.Condition = "[discountPer_bill] = 0"
        Me.hide_disPer_bill.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.hide_disPer_bill.Name = "hide_disPer_bill"
        '
        'hide_Tax
        '
        Me.hide_Tax.Condition = "[taxPer] = 0"
        Me.hide_Tax.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.hide_Tax.Name = "hide_Tax"
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1.0!
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 24.0!)
        Me.Title.ForeColor = System.Drawing.Color.Black
        Me.Title.Name = "Title"
        '
        'FieldCaption
        '
        Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
        Me.FieldCaption.BorderColor = System.Drawing.Color.Black
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.FieldCaption.BorderWidth = 1.0!
        Me.FieldCaption.Font = New System.Drawing.Font("TH Sarabun New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FieldCaption.ForeColor = System.Drawing.Color.Black
        Me.FieldCaption.Name = "FieldCaption"
        '
        'PageInfo
        '
        Me.PageInfo.BackColor = System.Drawing.Color.Transparent
        Me.PageInfo.BorderColor = System.Drawing.Color.Black
        Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageInfo.BorderWidth = 1.0!
        Me.PageInfo.Font = New System.Drawing.Font("TH Sarabun New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageInfo.ForeColor = System.Drawing.Color.Black
        Me.PageInfo.Name = "PageInfo"
        '
        'DataField
        '
        Me.DataField.BackColor = System.Drawing.Color.Transparent
        Me.DataField.BorderColor = System.Drawing.Color.Black
        Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataField.BorderWidth = 1.0!
        Me.DataField.Font = New System.Drawing.Font("TH Sarabun New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataField.ForeColor = System.Drawing.Color.Black
        Me.DataField.Name = "DataField"
        Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'TopMarginBand1
        '
        resources.ApplyResources(Me.TopMarginBand1, "TopMarginBand1")
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        resources.ApplyResources(Me.BottomMarginBand1, "BottomMarginBand1")
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'PageHeaderCaption
        '
        Me.PageHeaderCaption.Font = New System.Drawing.Font("TH Sarabun New", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageHeaderCaption.Name = "PageHeaderCaption"
        '
        'PageHeaderField
        '
        Me.PageHeaderField.Font = New System.Drawing.Font("TH Sarabun New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageHeaderField.Name = "PageHeaderField"
        '
        'hide_lastPage
        '
        Me.hide_lastPage.Condition = "[disPer] = 0"
        Me.hide_lastPage.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.hide_lastPage.Name = "hide_lastPage"
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrLabel18})
        resources.ApplyResources(Me.ReportHeader, "ReportHeader")
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLine1
        '
        resources.ApplyResources(Me.XrLine1, "XrLine1")
        Me.XrLine1.Name = "XrLine1"
        '
        'XrLabel18
        '
        resources.ApplyResources(Me.XrLabel18, "XrLabel18")
        Me.XrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel18.BorderWidth = 1.0!
        Me.XrLabel18.CanGrow = False
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.StylePriority.UseBackColor = False
        Me.XrLabel18.StylePriority.UseBorderColor = False
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseBorderWidth = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseForeColor = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        '
        'subreport_VacationRemark
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMarginBand1, Me.BottomMarginBand1, Me.ReportHeader})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "Query"
        Me.DataSource = Me.SqlDataSource1
        resources.ApplyResources(Me, "$this")
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.hide_disPer, Me.hide_remark, Me.hide_disPer_bill, Me.hide_lastPage, Me.hide_Price, Me.hide_Tax})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField, Me.PageHeaderCaption, Me.PageHeaderField})
        Me.Version = "17.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeaderCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageHeaderField As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents hide_disPer As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents hide_remark As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents hide_disPer_bill As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents hide_lastPage As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents hide_Price As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents hide_Tax As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
End Class
