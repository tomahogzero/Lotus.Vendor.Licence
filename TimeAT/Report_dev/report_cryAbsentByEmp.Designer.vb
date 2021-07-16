<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class report_cryAbsentByEmp
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
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(report_cryAbsentByEmp))
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.CalculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.reportName = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrLabel59 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.CalculatedField2 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.headdate = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.headname = New DevExpress.XtraReports.Parameters.Parameter()
        Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.CalculatedField6 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalculatedField3 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalculatedField4 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.paradate = New DevExpress.XtraReports.Parameters.Parameter()
        Me.type_use = New DevExpress.XtraReports.Parameters.Parameter()
        Me.CalculatedField5 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.computername = New DevExpress.XtraReports.Parameters.Parameter()
        Me.CalculatedField7 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.CalculatedField8 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.SubBand2 = New DevExpress.XtraReports.UI.SubBand()
        Me.pcLogo = New DevExpress.XtraReports.UI.XRPictureBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine6, Me.XrLabel14, Me.XrLabel4, Me.XrLabel1})
        Me.Detail.HeightF = 29.81249!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("row", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine6
        '
        Me.XrLine6.LocationFloat = New DevExpress.Utils.PointFloat(4.999997!, 25.17807!)
        Me.XrLine6.Name = "XrLine6"
        Me.XrLine6.SizeF = New System.Drawing.SizeF(777.0002!, 2.170139!)
        '
        'XrLabel14
        '
        Me.XrLabel14.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel14.BorderColor = System.Drawing.Color.Black
        Me.XrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel14.BorderWidth = 1.0!
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.code")})
        Me.XrLabel14.Font = New System.Drawing.Font("TH Sarabun New", 12.0!)
        Me.XrLabel14.ForeColor = System.Drawing.Color.Black
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(104.6186!, 1.0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(134.9579!, 21.95828!)
        Me.XrLabel14.StylePriority.UseBackColor = False
        Me.XrLabel14.StylePriority.UseBorderColor = False
        Me.XrLabel14.StylePriority.UseBorders = False
        Me.XrLabel14.StylePriority.UseBorderWidth = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseForeColor = False
        Me.XrLabel14.StylePriority.UsePadding = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0}"
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel14.Summary = XrSummary1
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel4.BorderColor = System.Drawing.Color.Black
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.BorderWidth = 1.0!
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Lname")})
        Me.XrLabel4.Font = New System.Drawing.Font("TH Sarabun New", 12.0!)
        Me.XrLabel4.ForeColor = System.Drawing.Color.Black
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(419.4466!, 0.9999956!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(362.5114!, 21.95828!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseBorderColor = False
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseBorderWidth = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UsePadding = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0}"
        XrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel4.Summary = XrSummary2
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.BorderColor = System.Drawing.Color.Black
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.BorderWidth = 1.0!
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Fname")})
        Me.XrLabel1.Font = New System.Drawing.Font("TH Sarabun New", 12.0!)
        Me.XrLabel1.ForeColor = System.Drawing.Color.Black
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(240.8631!, 0.9999956!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(168.3342!, 21.95828!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseBorderColor = False
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseBorderWidth = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UsePadding = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0}"
        XrSummary3.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel1.Summary = XrSummary3
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
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
        CustomSqlQuery1.Name = "vw_SO_quotation_report"
        CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "XrTableCell1"
        Me.XrTableCell1.Weight = 1.0R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "XrTableCell2"
        Me.XrTableCell2.Weight = 1.0R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "XrTableCell3"
        Me.XrTableCell3.Weight = 1.0R
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "XrTableCell4"
        Me.XrTableCell4.Weight = 1.0R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Text = "XrTableCell5"
        Me.XrTableCell5.Weight = 1.0R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Text = "XrTableCell6"
        Me.XrTableCell6.Weight = 1.0R
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
        Me.TopMarginBand1.HeightF = 20.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 28.0!
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
        'CalculatedField1
        '
        Me.CalculatedField1.DataMember = "vw_SO_quotation_report"
        Me.CalculatedField1.DisplayName = "remark_endbill"
        Me.CalculatedField1.Expression = "'Remark : ' + [remark_bill]"
        Me.CalculatedField1.Name = "CalculatedField1"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel16, Me.XrPageInfo2, Me.XrLabel15, Me.XrLine5, Me.XrPageInfo1})
        Me.PageFooter.HeightF = 33.33333!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrLabel16
        '
        Me.XrLabel16.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel16.BorderColor = System.Drawing.Color.Black
        Me.XrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel16.BorderWidth = 1.0!
        Me.XrLabel16.CanGrow = False
        Me.XrLabel16.Font = New System.Drawing.Font("TH Sarabun New", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel16.ForeColor = System.Drawing.Color.Black
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(696.6716!, 6.170135!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(36.62561!, 17.16319!)
        Me.XrLabel16.StylePriority.UseBackColor = False
        Me.XrLabel16.StylePriority.UseBorderColor = False
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseBorderWidth = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseForeColor = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "หน้า"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("TH Sarabun New", 8.0!)
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(734.3396!, 6.170136!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(48.66058!, 17.16319!)
        Me.XrPageInfo2.StylePriority.UseFont = False
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel15
        '
        Me.XrLabel15.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel15.BorderColor = System.Drawing.Color.Black
        Me.XrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel15.BorderWidth = 1.0!
        Me.XrLabel15.CanGrow = False
        Me.XrLabel15.Font = New System.Drawing.Font("TH Sarabun New", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.ForeColor = System.Drawing.Color.Black
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(4.957812!, 2.170154!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(36.62563!, 22.00009!)
        Me.XrLabel15.StylePriority.UseBackColor = False
        Me.XrLabel15.StylePriority.UseBorderColor = False
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseBorderWidth = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseForeColor = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "วันที่พิมพ์"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine5
        '
        Me.XrLine5.LineWidth = 2
        Me.XrLine5.LocationFloat = New DevExpress.Utils.PointFloat(4.957812!, 0!)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.SizeF = New System.Drawing.SizeF(777.0002!, 2.170139!)
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("TH Sarabun New", 8.0!)
        Me.XrPageInfo1.Format = "{0:dd/MM/yyyy HH:mm:ss}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(42.77284!, 5.170154!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(158.0357!, 18.16317!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        '
        'reportName
        '
        Me.reportName.DataMember = "vw_SO_quotation_report"
        Me.reportName.Expression = "'รายงานสรุปใบรับซื้อสินค้า ตามลูกค้า,ใบเสร็จ' + iif([Parameters.topRow] > 0,' (To" &
    "p ' + [Parameters.topRow] + ')','')"
        Me.reportName.Name = "reportName"
        '
        'XrLabel59
        '
        Me.XrLabel59.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel59.BorderColor = System.Drawing.Color.Black
        Me.XrLabel59.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel59.BorderWidth = 1.0!
        Me.XrLabel59.CanGrow = False
        Me.XrLabel59.Font = New System.Drawing.Font("TH Sarabun New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel59.ForeColor = System.Drawing.Color.Black
        Me.XrLabel59.LocationFloat = New DevExpress.Utils.PointFloat(105.6186!, 3.000005!)
        Me.XrLabel59.Name = "XrLabel59"
        Me.XrLabel59.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel59.SizeF = New System.Drawing.SizeF(134.958!, 25.00008!)
        Me.XrLabel59.StylePriority.UseBackColor = False
        Me.XrLabel59.StylePriority.UseBorderColor = False
        Me.XrLabel59.StylePriority.UseBorders = False
        Me.XrLabel59.StylePriority.UseBorderWidth = False
        Me.XrLabel59.StylePriority.UseFont = False
        Me.XrLabel59.StylePriority.UseForeColor = False
        Me.XrLabel59.StylePriority.UseTextAlignment = False
        Me.XrLabel59.Text = "รหัส"
        Me.XrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel10.BorderColor = System.Drawing.Color.Black
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel10.BorderWidth = 1.0!
        Me.XrLabel10.CanGrow = False
        Me.XrLabel10.Font = New System.Drawing.Font("TH Sarabun New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.ForeColor = System.Drawing.Color.Black
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(419.4466!, 2.999987!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(362.5114!, 25.0001!)
        Me.XrLabel10.StylePriority.UseBackColor = False
        Me.XrLabel10.StylePriority.UseBorderColor = False
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseBorderWidth = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseForeColor = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "สกุล"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel5.BorderColor = System.Drawing.Color.Black
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel5.BorderWidth = 1.0!
        Me.XrLabel5.CanGrow = False
        Me.XrLabel5.Font = New System.Drawing.Font("TH Sarabun New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.ForeColor = System.Drawing.Color.Black
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(243.5766!, 2.999987!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(165.6207!, 25.0001!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseBorderColor = False
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseBorderWidth = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "ชื่อ"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'CalculatedField2
        '
        Me.CalculatedField2.DataMember = "vw_SO_quotation_report"
        Me.CalculatedField2.DisplayName = "FnameLname"
        Me.CalculatedField2.Expression = "[Fname] + '     ' + [Lname]"
        Me.CalculatedField2.Name = "CalculatedField2"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pcLogo})
        Me.PageHeader.HeightF = 40.37499!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand2, Me.SubBand1})
        '
        'XrLabel18
        '
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.headdate, "Text", "")})
        Me.XrLabel18.Font = New System.Drawing.Font("TH Sarabun New", 14.0!)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(4.957962!, 32.02785!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(780.0001!, 25.0!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "XrLabel18"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'headdate
        '
        Me.headdate.Description = "headdate"
        Me.headdate.Name = "headdate"
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.headname, "Text", "")})
        Me.XrLabel2.Font = New System.Drawing.Font("TH Sarabun New", 16.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(4.957962!, 0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(780.0!, 30.02788!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'headname
        '
        Me.headname.Description = "headname"
        Me.headname.Name = "headname"
        '
        'SubBand1
        '
        Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrLine3, Me.XrLabel5, Me.XrLabel10, Me.XrLabel59})
        Me.SubBand1.HeightF = 31.64244!
        Me.SubBand1.Name = "SubBand1"
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(5.00001!, 0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(778.0001!, 2.0!)
        '
        'XrLine3
        '
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(4.957975!, 28.00009!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(777.0002!, 2.170139!)
        '
        'CalculatedField6
        '
        Me.CalculatedField6.DataMember = "vw_SO_quotation_report"
        Me.CalculatedField6.DisplayName = "DaydoTotal"
        Me.CalculatedField6.Expression = "Sum([DayDo])"
        Me.CalculatedField6.Name = "CalculatedField6"
        '
        'CalculatedField3
        '
        Me.CalculatedField3.DataMember = "vw_SO_quotation_report"
        Me.CalculatedField3.DisplayName = "Running"
        Me.CalculatedField3.Name = "CalculatedField3"
        '
        'CalculatedField4
        '
        Me.CalculatedField4.DataMember = "vw_SO_quotation_report"
        Me.CalculatedField4.Name = "CalculatedField4"
        '
        'ReportFooter
        '
        Me.ReportFooter.HeightF = 0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'paradate
        '
        Me.paradate.Description = "paradate"
        Me.paradate.Name = "paradate"
        '
        'type_use
        '
        Me.type_use.Description = "type_use"
        Me.type_use.Name = "type_use"
        '
        'CalculatedField5
        '
        Me.CalculatedField5.DataMember = "vw_SO_quotation_report"
        Me.CalculatedField5.DisplayName = "head_date"
        Me.CalculatedField5.Expression = "[Parameters.headname] + '  ' + [Parameters.cCheckDate]"
        Me.CalculatedField5.Name = "CalculatedField5"
        '
        'computername
        '
        Me.computername.Description = "computername"
        Me.computername.Name = "computername"
        '
        'CalculatedField7
        '
        Me.CalculatedField7.DataMember = "vw_SO_quotation_report"
        Me.CalculatedField7.DisplayName = "cal_abs"
        Me.CalculatedField7.Expression = "[Vacation]+[TimeAbsent]+[TimeLate]"
        Me.CalculatedField7.Name = "CalculatedField7"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel12, Me.XrLine2, Me.XrLabel11, Me.XrLabel7, Me.XrLabel6})
        Me.GroupHeader1.HeightF = 28.87851!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel12
        '
        Me.XrLabel12.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel12.BorderColor = System.Drawing.Color.Black
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel12.BorderWidth = 1.0!
        Me.XrLabel12.CanGrow = False
        Me.XrLabel12.Font = New System.Drawing.Font("TH Sarabun New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.ForeColor = System.Drawing.Color.Black
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(578.0488!, 3.666537!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(57.45898!, 22.00009!)
        Me.XrLabel12.StylePriority.UseBackColor = False
        Me.XrLabel12.StylePriority.UseBorderColor = False
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseBorderWidth = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseForeColor = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "คน"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(5.999973!, 26.70837!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(777.0002!, 2.170139!)
        '
        'XrLabel11
        '
        Me.XrLabel11.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel11.BorderColor = System.Drawing.Color.Black
        Me.XrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel11.BorderWidth = 1.0!
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Code")})
        Me.XrLabel11.Font = New System.Drawing.Font("TH Sarabun New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.ForeColor = System.Drawing.Color.Black
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(522.7865!, 3.70834!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(55.26236!, 21.95828!)
        Me.XrLabel11.StylePriority.UseBackColor = False
        Me.XrLabel11.StylePriority.UseBorderColor = False
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseBorderWidth = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseForeColor = False
        Me.XrLabel11.StylePriority.UsePadding = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0}"
        XrSummary4.Func = DevExpress.XtraReports.UI.SummaryFunc.Count
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel11.Summary = XrSummary4
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Department")})
        Me.XrLabel7.Font = New System.Drawing.Font("TH Sarabun New", 12.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(60.27734!, 3.708394!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(348.92!, 21.95824!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.Text = "XrLabel7"
        '
        'XrLabel6
        '
        Me.XrLabel6.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel6.BorderColor = System.Drawing.Color.Black
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel6.BorderWidth = 1.0!
        Me.XrLabel6.CanGrow = False
        Me.XrLabel6.Font = New System.Drawing.Font("TH Sarabun New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.ForeColor = System.Drawing.Color.Black
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(465.3275!, 3.666537!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(57.45898!, 22.00009!)
        Me.XrLabel6.StylePriority.UseBackColor = False
        Me.XrLabel6.StylePriority.UseBorderColor = False
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseBorderWidth = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "จำนวน"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel3.BorderColor = System.Drawing.Color.Black
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.BorderWidth = 1.0!
        Me.XrLabel3.CanGrow = False
        Me.XrLabel3.Font = New System.Drawing.Font("TH Sarabun New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.ForeColor = System.Drawing.Color.Black
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(327.1848!, 5.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(124.4232!, 22.00009!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseBorderColor = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseBorderWidth = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "ขาดทั้งหมดจำนวน"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel9
        '
        Me.XrLabel9.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel9.BorderColor = System.Drawing.Color.Black
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel9.BorderWidth = 1.0!
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Code")})
        Me.XrLabel9.Font = New System.Drawing.Font("TH Sarabun New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.ForeColor = System.Drawing.Color.Black
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(491.7865!, 5.0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(55.26236!, 21.95828!)
        Me.XrLabel9.StylePriority.UseBackColor = False
        Me.XrLabel9.StylePriority.UseBorderColor = False
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseBorderWidth = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseForeColor = False
        Me.XrLabel9.StylePriority.UsePadding = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        XrSummary5.FormatString = "{0:#,#}"
        XrSummary5.Func = DevExpress.XtraReports.UI.SummaryFunc.Count
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel9.Summary = XrSummary5
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel13, Me.XrLabel3, Me.XrLabel9})
        Me.GroupFooter1.HeightF = 31.84526!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLabel13
        '
        Me.XrLabel13.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel13.BorderColor = System.Drawing.Color.Black
        Me.XrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel13.BorderWidth = 1.0!
        Me.XrLabel13.CanGrow = False
        Me.XrLabel13.Font = New System.Drawing.Font("TH Sarabun New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel13.ForeColor = System.Drawing.Color.Black
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(547.0488!, 5.0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(57.45898!, 22.00009!)
        Me.XrLabel13.StylePriority.UseBackColor = False
        Me.XrLabel13.StylePriority.UseBorderColor = False
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseBorderWidth = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseForeColor = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "คน"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'CalculatedField8
        '
        Me.CalculatedField8.DataMember = "vw_SO_quotation_report"
        Me.CalculatedField8.DisplayName = "printdate"
        Me.CalculatedField8.Name = "CalculatedField8"
        '
        'SubBand2
        '
        Me.SubBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel18, Me.XrLabel2})
        Me.SubBand2.HeightF = 57.02785!
        Me.SubBand2.Name = "SubBand2"
        '
        'pcLogo
        '
        Me.pcLogo.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.pcLogo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopCenter
        Me.pcLogo.LocationFloat = New DevExpress.Utils.PointFloat(4.957803!, 0!)
        Me.pcLogo.Name = "pcLogo"
        Me.pcLogo.SizeF = New System.Drawing.SizeF(780.0002!, 40.37499!)
        Me.pcLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.pcLogo.StylePriority.UseBorders = False
        '
        'report_cryAbsentByEmp
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMarginBand1, Me.BottomMarginBand1, Me.PageFooter, Me.PageHeader, Me.ReportFooter, Me.GroupHeader1, Me.GroupFooter1})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.CalculatedField1, Me.reportName, Me.CalculatedField2, Me.CalculatedField6, Me.CalculatedField3, Me.CalculatedField4, Me.CalculatedField5, Me.CalculatedField7, Me.CalculatedField8})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "vw_SO_quotation_report"
        Me.DataSource = Me.SqlDataSource1
        Me.FilterString = "[datein] = #2019-05-01#"
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.hide_disPer, Me.hide_remark, Me.hide_disPer_bill, Me.hide_lastPage, Me.hide_Price, Me.hide_Tax})
        Me.Margins = New System.Drawing.Printing.Margins(29, 21, 20, 28)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.headname, Me.paradate, Me.type_use, Me.computername, Me.headdate})
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
    Friend WithEvents CalculatedField1 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents hide_Price As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents hide_Tax As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents reportName As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CalculatedField2 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents CalculatedField6 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel59 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CalculatedField3 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalculatedField4 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents headname As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents paradate As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents type_use As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents CalculatedField5 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents computername As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents CalculatedField7 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents SubBand1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents XrLine6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents headdate As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CalculatedField8 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents SubBand2 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents pcLogo As DevExpress.XtraReports.UI.XRPictureBox
End Class
