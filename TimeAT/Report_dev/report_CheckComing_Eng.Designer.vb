<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class report_CheckComing_Eng
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
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim StoredProcQuery1 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(report_CheckComing_Eng))
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel61 = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrLabel119 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel121 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine8 = New DevExpress.XtraReports.UI.XRLine()
        Me.reportName = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalculatedField2 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Headname = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.pcLogo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.SubBand3 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLabel48 = New DevExpress.XtraReports.UI.XRLabel()
        Me.cCheckDate = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel60 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SubBand2 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.companyname = New DevExpress.XtraReports.Parameters.Parameter()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.CalculatedField6 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalculatedField3 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrCrossBandLine1 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.paradate = New DevExpress.XtraReports.Parameters.Parameter()
        Me.fullname = New DevExpress.XtraReports.Parameters.Parameter()
        Me.CalculatedField5 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrCrossBandBox1 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.XrCrossBandLine2 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine3 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine4 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine7 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine3, Me.XrLabel7, Me.XrLabel6, Me.XrLabel4, Me.XrLabel1, Me.XrLabel61})
        Me.Detail.HeightF = 24.34729!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("row", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine3
        '
        Me.XrLine3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.XrLine3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrLine3.ForeColor = System.Drawing.Color.Gray
        Me.XrLine3.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(5.374993!, 22.26394!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(777.6251!, 2.083332!)
        Me.XrLine3.StylePriority.UseBorderColor = False
        Me.XrLine3.StylePriority.UseBorderDashStyle = False
        Me.XrLine3.StylePriority.UseForeColor = False
        '
        'XrLabel7
        '
        Me.XrLabel7.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel7.BorderColor = System.Drawing.Color.Black
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel7.BorderWidth = 1.0!
        Me.XrLabel7.CanGrow = False
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.TimeOut")})
        Me.XrLabel7.Font = New System.Drawing.Font("TH Sarabun New", 12.0!)
        Me.XrLabel7.ForeColor = System.Drawing.Color.Black
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(525.3743!, 0.3056569!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(88.56287!, 21.95828!)
        Me.XrLabel7.StylePriority.UseBackColor = False
        Me.XrLabel7.StylePriority.UseBorderColor = False
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseBorderWidth = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.StylePriority.UsePadding = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0}"
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel7.Summary = XrSummary1
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel6.BorderColor = System.Drawing.Color.Black
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel6.BorderWidth = 1.0!
        Me.XrLabel6.CanGrow = False
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.TimeIn")})
        Me.XrLabel6.Font = New System.Drawing.Font("TH Sarabun New", 12.0!)
        Me.XrLabel6.ForeColor = System.Drawing.Color.Black
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(430.1389!, 0.3056569!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(93.76495!, 21.95828!)
        Me.XrLabel6.StylePriority.UseBackColor = False
        Me.XrLabel6.StylePriority.UseBorderColor = False
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseBorderWidth = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.StylePriority.UsePadding = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0}"
        XrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel6.Summary = XrSummary2
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel4.BorderColor = System.Drawing.Color.Black
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.BorderWidth = 1.0!
        Me.XrLabel4.CanGrow = False
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.CalculatedField5")})
        Me.XrLabel4.Font = New System.Drawing.Font("TH Sarabun New", 12.0!)
        Me.XrLabel4.ForeColor = System.Drawing.Color.Black
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(166.9452!, 0.3056569!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(262.1215!, 21.95828!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseBorderColor = False
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseBorderWidth = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UsePadding = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0}"
        XrSummary3.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel4.Summary = XrSummary3
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.BorderColor = System.Drawing.Color.Black
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.BorderWidth = 1.0!
        Me.XrLabel1.CanGrow = False
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.Code")})
        Me.XrLabel1.Font = New System.Drawing.Font("TH Sarabun New", 12.0!)
        Me.XrLabel1.ForeColor = System.Drawing.Color.Black
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(66.63889!, 0.3056574!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(96.3063!, 21.95828!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseBorderColor = False
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseBorderWidth = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UsePadding = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0}"
        XrSummary4.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel1.Summary = XrSummary4
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel61
        '
        Me.XrLabel61.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel61.BorderColor = System.Drawing.Color.Black
        Me.XrLabel61.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel61.BorderWidth = 1.0!
        Me.XrLabel61.CanGrow = False
        Me.XrLabel61.Font = New System.Drawing.Font("TH Sarabun New", 12.0!)
        Me.XrLabel61.ForeColor = System.Drawing.Color.Black
        Me.XrLabel61.LocationFloat = New DevExpress.Utils.PointFloat(7.361054!, 0.3056574!)
        Me.XrLabel61.Name = "XrLabel61"
        Me.XrLabel61.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel61.SizeF = New System.Drawing.SizeF(53.63894!, 21.33333!)
        Me.XrLabel61.StylePriority.UseBackColor = False
        Me.XrLabel61.StylePriority.UseBorderColor = False
        Me.XrLabel61.StylePriority.UseBorders = False
        Me.XrLabel61.StylePriority.UseBorderWidth = False
        Me.XrLabel61.StylePriority.UseFont = False
        Me.XrLabel61.StylePriority.UseForeColor = False
        Me.XrLabel61.StylePriority.UsePadding = False
        Me.XrLabel61.StylePriority.UseTextAlignment = False
        XrSummary5.FormatString = "{0:#,#}"
        XrSummary5.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel61.Summary = XrSummary5
        Me.XrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
        StoredProcQuery1.Name = "Query"
        QueryParameter1.Name = "@Date"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.paradate]", GetType(String))
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.StoredProcName = "spTimeCheckComing"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
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
        Me.TopMarginBand1.HeightF = 25.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 26.0!
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
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel119, Me.XrPageInfo2, Me.XrPageInfo1, Me.XrLabel121, Me.XrLine8})
        Me.PageFooter.HeightF = 33.33333!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrLabel119
        '
        Me.XrLabel119.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel119.BorderColor = System.Drawing.Color.Black
        Me.XrLabel119.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel119.BorderWidth = 1.0!
        Me.XrLabel119.CanGrow = False
        Me.XrLabel119.Font = New System.Drawing.Font("TH Sarabun New", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel119.ForeColor = System.Drawing.Color.Black
        Me.XrLabel119.LocationFloat = New DevExpress.Utils.PointFloat(721.5334!, 2.628432!)
        Me.XrLabel119.Name = "XrLabel119"
        Me.XrLabel119.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel119.SizeF = New System.Drawing.SizeF(30.8241!, 17.16319!)
        Me.XrLabel119.StylePriority.UseBackColor = False
        Me.XrLabel119.StylePriority.UseBorderColor = False
        Me.XrLabel119.StylePriority.UseBorders = False
        Me.XrLabel119.StylePriority.UseBorderWidth = False
        Me.XrLabel119.StylePriority.UseFont = False
        Me.XrLabel119.StylePriority.UseForeColor = False
        Me.XrLabel119.StylePriority.UseTextAlignment = False
        Me.XrLabel119.Text = "Page"
        Me.XrLabel119.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("TH Sarabun New", 8.0!)
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(752.3575!, 2.628429!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(30.64252!, 17.16319!)
        Me.XrPageInfo2.StylePriority.UseFont = False
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("TH Sarabun New", 8.0!)
        Me.XrPageInfo1.Format = "{0:dd/MM/yyyy HH:mm:ss}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(55.49427!, 3.17018!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(158.0357!, 17.62144!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel121
        '
        Me.XrLabel121.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel121.BorderColor = System.Drawing.Color.Black
        Me.XrLabel121.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel121.BorderWidth = 1.0!
        Me.XrLabel121.CanGrow = False
        Me.XrLabel121.Font = New System.Drawing.Font("TH Sarabun New", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel121.ForeColor = System.Drawing.Color.Black
        Me.XrLabel121.LocationFloat = New DevExpress.Utils.PointFloat(6.999997!, 2.628436!)
        Me.XrLabel121.Name = "XrLabel121"
        Me.XrLabel121.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel121.SizeF = New System.Drawing.SizeF(47.49427!, 17.16319!)
        Me.XrLabel121.StylePriority.UseBackColor = False
        Me.XrLabel121.StylePriority.UseBorderColor = False
        Me.XrLabel121.StylePriority.UseBorders = False
        Me.XrLabel121.StylePriority.UseBorderWidth = False
        Me.XrLabel121.StylePriority.UseFont = False
        Me.XrLabel121.StylePriority.UseForeColor = False
        Me.XrLabel121.StylePriority.UseTextAlignment = False
        Me.XrLabel121.Text = "Print Date :"
        Me.XrLabel121.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine8
        '
        Me.XrLine8.LocationFloat = New DevExpress.Utils.PointFloat(4.999995!, 0.4582935!)
        Me.XrLine8.Name = "XrLine8"
        Me.XrLine8.SizeF = New System.Drawing.SizeF(778.0002!, 2.170139!)
        '
        'reportName
        '
        Me.reportName.DataMember = "Query"
        Me.reportName.Expression = "'รายงานสรุปใบรับซื้อสินค้า ตามลูกค้า,ใบเสร็จ' + iif([Parameters.topRow] > 0,' (To" &
    "p ' + [Parameters.topRow] + ')','')"
        Me.reportName.Name = "reportName"
        '
        'CalculatedField2
        '
        Me.CalculatedField2.DataMember = "Query"
        Me.CalculatedField2.DisplayName = "FnameLname"
        Me.CalculatedField2.Expression = "[Fname] + '     ' + [Lname]"
        Me.CalculatedField2.Name = "CalculatedField2"
        '
        'Headname
        '
        Me.Headname.Description = "Headname"
        Me.Headname.Name = "Headname"
        '
        'PageHeader
        '
        Me.PageHeader.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pcLogo})
        Me.PageHeader.HeightF = 40.37499!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.StylePriority.UseBorderDashStyle = False
        Me.PageHeader.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand3, Me.SubBand1, Me.SubBand2})
        '
        'pcLogo
        '
        Me.pcLogo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.pcLogo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopCenter
        Me.pcLogo.LocationFloat = New DevExpress.Utils.PointFloat(7.000001!, 0!)
        Me.pcLogo.Name = "pcLogo"
        Me.pcLogo.SizeF = New System.Drawing.SizeF(776.5001!, 40.37499!)
        Me.pcLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.pcLogo.StylePriority.UseBorders = False
        '
        'SubBand3
        '
        Me.SubBand3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel48, Me.XrLabel60})
        Me.SubBand3.HeightF = 45.99998!
        Me.SubBand3.Name = "SubBand3"
        '
        'XrLabel48
        '
        Me.XrLabel48.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.cCheckDate, "Text", "")})
        Me.XrLabel48.Font = New System.Drawing.Font("TH Sarabun New", 16.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel48.LocationFloat = New DevExpress.Utils.PointFloat(6.41667!, 22.99999!)
        Me.XrLabel48.Name = "XrLabel48"
        Me.XrLabel48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel48.SizeF = New System.Drawing.SizeF(776.0004!, 23.0!)
        Me.XrLabel48.StylePriority.UseFont = False
        Me.XrLabel48.StylePriority.UseTextAlignment = False
        Me.XrLabel48.Text = "XrLabel48"
        Me.XrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'cCheckDate
        '
        Me.cCheckDate.Description = "cCheckDate"
        Me.cCheckDate.Name = "cCheckDate"
        '
        'XrLabel60
        '
        Me.XrLabel60.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.Headname, "Text", "")})
        Me.XrLabel60.Font = New System.Drawing.Font("TH Sarabun New", 16.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel60.LocationFloat = New DevExpress.Utils.PointFloat(6.41667!, 0!)
        Me.XrLabel60.Name = "XrLabel60"
        Me.XrLabel60.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel60.SizeF = New System.Drawing.SizeF(776.0004!, 23.0!)
        Me.XrLabel60.StylePriority.UseFont = False
        Me.XrLabel60.StylePriority.UseTextAlignment = False
        Me.XrLabel60.Text = "XrLabel60"
        Me.XrLabel60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'SubBand1
        '
        Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10, Me.XrLabel9, Me.XrLabel8, Me.XrLabel5})
        Me.SubBand1.HeightF = 25.00009!
        Me.SubBand1.Name = "SubBand1"
        '
        'XrLabel10
        '
        Me.XrLabel10.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel10.BorderColor = System.Drawing.Color.Black
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel10.BorderWidth = 1.0!
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.Department")})
        Me.XrLabel10.Font = New System.Drawing.Font("TH Sarabun New", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.ForeColor = System.Drawing.Color.Black
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(417.883!, 2.999996!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(307.0689!, 22.00009!)
        Me.XrLabel10.StylePriority.UseBackColor = False
        Me.XrLabel10.StylePriority.UseBorderColor = False
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseBorderWidth = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseForeColor = False
        Me.XrLabel10.StylePriority.UsePadding = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        XrSummary6.FormatString = "{0}"
        XrSummary6.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel10.Summary = XrSummary6
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel9.BorderColor = System.Drawing.Color.Black
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel9.BorderWidth = 1.0!
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.Division")})
        Me.XrLabel9.Font = New System.Drawing.Font("TH Sarabun New", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.ForeColor = System.Drawing.Color.Black
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(66.63892!, 2.999994!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(247.8471!, 22.00009!)
        Me.XrLabel9.StylePriority.UseBackColor = False
        Me.XrLabel9.StylePriority.UseBorderColor = False
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseBorderWidth = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseForeColor = False
        Me.XrLabel9.StylePriority.UsePadding = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        XrSummary7.FormatString = "{0}"
        XrSummary7.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel9.Summary = XrSummary7
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel8.BorderColor = System.Drawing.Color.Black
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.BorderWidth = 1.0!
        Me.XrLabel8.CanGrow = False
        Me.XrLabel8.Font = New System.Drawing.Font("TH Sarabun New", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.ForeColor = System.Drawing.Color.Black
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(327.6594!, 2.999994!)
        Me.XrLabel8.Multiline = True
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(89.84818!, 22.00009!)
        Me.XrLabel8.StylePriority.UseBackColor = False
        Me.XrLabel8.StylePriority.UseBorderColor = False
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseBorderWidth = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseForeColor = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Department :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel5.BorderColor = System.Drawing.Color.Black
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel5.BorderWidth = 1.0!
        Me.XrLabel5.CanGrow = False
        Me.XrLabel5.Font = New System.Drawing.Font("TH Sarabun New", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.ForeColor = System.Drawing.Color.Black
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(6.999996!, 2.999994!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(57.07232!, 22.00009!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseBorderColor = False
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseBorderWidth = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Section :"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'SubBand2
        '
        Me.SubBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine6, Me.XrLabel23, Me.XrLabel18, Me.XrLabel17, Me.XrLabel16, Me.XrLabel15, Me.XrLabel14})
        Me.SubBand2.HeightF = 29.95425!
        Me.SubBand2.Name = "SubBand2"
        '
        'XrLine6
        '
        Me.XrLine6.LocationFloat = New DevExpress.Utils.PointFloat(7.000007!, 27.88243!)
        Me.XrLine6.Name = "XrLine6"
        Me.XrLine6.SizeF = New System.Drawing.SizeF(776.0001!, 2.071823!)
        '
        'XrLabel23
        '
        Me.XrLabel23.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel23.BorderColor = System.Drawing.Color.Black
        Me.XrLabel23.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel23.BorderWidth = 1.0!
        Me.XrLabel23.CanGrow = False
        Me.XrLabel23.Font = New System.Drawing.Font("TH Sarabun New", 12.0!)
        Me.XrLabel23.ForeColor = System.Drawing.Color.Black
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(615.0095!, 5.0!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(165.9906!, 22.88242!)
        Me.XrLabel23.StylePriority.UseBackColor = False
        Me.XrLabel23.StylePriority.UseBorderColor = False
        Me.XrLabel23.StylePriority.UseBorders = False
        Me.XrLabel23.StylePriority.UseBorderWidth = False
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseForeColor = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "Signature"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel18
        '
        Me.XrLabel18.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel18.BorderColor = System.Drawing.Color.Black
        Me.XrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel18.BorderWidth = 1.0!
        Me.XrLabel18.CanGrow = False
        Me.XrLabel18.Font = New System.Drawing.Font("TH Sarabun New", 12.0!)
        Me.XrLabel18.ForeColor = System.Drawing.Color.Black
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(525.3743!, 5.0!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(88.56287!, 22.00009!)
        Me.XrLabel18.StylePriority.UseBackColor = False
        Me.XrLabel18.StylePriority.UseBorderColor = False
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseBorderWidth = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseForeColor = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "Out"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel17
        '
        Me.XrLabel17.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel17.BorderColor = System.Drawing.Color.Black
        Me.XrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel17.BorderWidth = 1.0!
        Me.XrLabel17.CanGrow = False
        Me.XrLabel17.Font = New System.Drawing.Font("TH Sarabun New", 12.0!)
        Me.XrLabel17.ForeColor = System.Drawing.Color.Black
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(431.0666!, 5.0!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(93.23553!, 22.00009!)
        Me.XrLabel17.StylePriority.UseBackColor = False
        Me.XrLabel17.StylePriority.UseBorderColor = False
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseBorderWidth = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseForeColor = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "In"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel16
        '
        Me.XrLabel16.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel16.BorderColor = System.Drawing.Color.Black
        Me.XrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel16.BorderWidth = 1.0!
        Me.XrLabel16.CanGrow = False
        Me.XrLabel16.Font = New System.Drawing.Font("TH Sarabun New", 12.0!)
        Me.XrLabel16.ForeColor = System.Drawing.Color.Black
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(166.9452!, 5.0!)
        Me.XrLabel16.Multiline = True
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(262.1213!, 22.00009!)
        Me.XrLabel16.StylePriority.UseBackColor = False
        Me.XrLabel16.StylePriority.UseBorderColor = False
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseBorderWidth = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseForeColor = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "First name - Last name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel15
        '
        Me.XrLabel15.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel15.BorderColor = System.Drawing.Color.Black
        Me.XrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel15.BorderWidth = 1.0!
        Me.XrLabel15.CanGrow = False
        Me.XrLabel15.Font = New System.Drawing.Font("TH Sarabun New", 12.0!)
        Me.XrLabel15.ForeColor = System.Drawing.Color.Black
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(66.63891!, 5.0!)
        Me.XrLabel15.Multiline = True
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(96.30628!, 22.00009!)
        Me.XrLabel15.StylePriority.UseBackColor = False
        Me.XrLabel15.StylePriority.UseBorderColor = False
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseBorderWidth = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseForeColor = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "Employee ID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel14
        '
        Me.XrLabel14.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel14.BorderColor = System.Drawing.Color.Black
        Me.XrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel14.BorderWidth = 1.0!
        Me.XrLabel14.CanGrow = False
        Me.XrLabel14.Font = New System.Drawing.Font("TH Sarabun New", 12.0!)
        Me.XrLabel14.ForeColor = System.Drawing.Color.Black
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(6.999987!, 5.0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(54.0!, 22.00009!)
        Me.XrLabel14.StylePriority.UseBackColor = False
        Me.XrLabel14.StylePriority.UseBorderColor = False
        Me.XrLabel14.StylePriority.UseBorders = False
        Me.XrLabel14.StylePriority.UseBorderWidth = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseForeColor = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "NO"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'companyname
        '
        Me.companyname.Description = "Companyname"
        Me.companyname.Name = "companyname"
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel11, Me.XrLine2})
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Department", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.HeightF = 22.0001!
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.Visible = False
        '
        'XrLabel11
        '
        Me.XrLabel11.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel11.BorderColor = System.Drawing.Color.Black
        Me.XrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel11.BorderWidth = 1.0!
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.Department")})
        Me.XrLabel11.Font = New System.Drawing.Font("TH Sarabun New", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.ForeColor = System.Drawing.Color.Black
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(107.5962!, 0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(217.3065!, 22.00009!)
        Me.XrLabel11.StylePriority.UseBackColor = False
        Me.XrLabel11.StylePriority.UseBorderColor = False
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseBorderWidth = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseForeColor = False
        Me.XrLabel11.StylePriority.UsePadding = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        XrSummary8.FormatString = "{0}"
        XrSummary8.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel11.Summary = XrSummary8
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 16.00011!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(771.9584!, 5.999992!)
        '
        'CalculatedField6
        '
        Me.CalculatedField6.DataMember = "Query"
        Me.CalculatedField6.DisplayName = "DaydoTotal"
        Me.CalculatedField6.Expression = "Sum([DayDo])"
        Me.CalculatedField6.Name = "CalculatedField6"
        '
        'CalculatedField3
        '
        Me.CalculatedField3.DataMember = "Query"
        Me.CalculatedField3.DisplayName = "Running"
        Me.CalculatedField3.Name = "CalculatedField3"
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine4, Me.XrLabel13, Me.XrLabel12})
        Me.ReportFooter.HeightF = 60.26789!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLine4
        '
        Me.XrLine4.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(524.3021!, 52.35125!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(200.6498!, 2.0!)
        '
        'XrLabel13
        '
        Me.XrLabel13.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel13.BorderColor = System.Drawing.Color.Black
        Me.XrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel13.BorderWidth = 1.0!
        Me.XrLabel13.CanGrow = False
        Me.XrLabel13.Font = New System.Drawing.Font("TH Sarabun New", 12.0!)
        Me.XrLabel13.ForeColor = System.Drawing.Color.Black
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(721.5334!, 30.35113!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(61.96661!, 22.0001!)
        Me.XrLabel13.StylePriority.UseBackColor = False
        Me.XrLabel13.StylePriority.UseBorderColor = False
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseBorderWidth = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseForeColor = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "Auditor"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel12.BorderColor = System.Drawing.Color.Black
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel12.BorderWidth = 1.0!
        Me.XrLabel12.CanGrow = False
        Me.XrLabel12.Font = New System.Drawing.Font("TH Sarabun New", 12.0!)
        Me.XrLabel12.ForeColor = System.Drawing.Color.Black
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(429.0666!, 30.35113!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(94.83719!, 22.00009!)
        Me.XrLabel12.StylePriority.UseBackColor = False
        Me.XrLabel12.StylePriority.UseBorderColor = False
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseBorderWidth = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseForeColor = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Signature"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrCrossBandLine1
        '
        Me.XrCrossBandLine1.EndBand = Me.GroupFooter1
        Me.XrCrossBandLine1.EndPointFloat = New DevExpress.Utils.PointFloat(63.00001!, 2.0!)
        Me.XrCrossBandLine1.LocationFloat = New DevExpress.Utils.PointFloat(63.00001!, 1.000003!)
        Me.XrCrossBandLine1.Name = "XrCrossBandLine1"
        Me.XrCrossBandLine1.StartBand = Me.SubBand2
        Me.XrCrossBandLine1.StartPointFloat = New DevExpress.Utils.PointFloat(63.00001!, 1.000003!)
        Me.XrCrossBandLine1.WidthF = 1.072308!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.HeightF = 2.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        Me.GroupFooter1.RepeatEveryPage = True
        '
        'paradate
        '
        Me.paradate.Description = "Date Time"
        Me.paradate.Name = "paradate"
        Me.paradate.ValueInfo = "2019/01/01"
        '
        'fullname
        '
        Me.fullname.Description = "fullname"
        Me.fullname.Name = "fullname"
        '
        'CalculatedField5
        '
        Me.CalculatedField5.DataMember = "Query"
        Me.CalculatedField5.DisplayName = "fullname"
        Me.CalculatedField5.Expression = "[Title]+ ' ' +[Fname] + '  ' + [Lname]"
        Me.CalculatedField5.Name = "CalculatedField5"
        '
        'XrCrossBandBox1
        '
        Me.XrCrossBandBox1.BorderWidth = 1.0!
        Me.XrCrossBandBox1.EndBand = Me.GroupFooter1
        Me.XrCrossBandBox1.EndPointFloat = New DevExpress.Utils.PointFloat(5.375!, 2.0!)
        Me.XrCrossBandBox1.LocationFloat = New DevExpress.Utils.PointFloat(5.375!, 0!)
        Me.XrCrossBandBox1.Name = "XrCrossBandBox1"
        Me.XrCrossBandBox1.StartBand = Me.SubBand2
        Me.XrCrossBandBox1.StartPointFloat = New DevExpress.Utils.PointFloat(5.375!, 0!)
        Me.XrCrossBandBox1.WidthF = 778.125!
        '
        'XrCrossBandLine2
        '
        Me.XrCrossBandLine2.EndBand = Me.GroupFooter1
        Me.XrCrossBandLine2.EndPointFloat = New DevExpress.Utils.PointFloat(162.9452!, 2.0!)
        Me.XrCrossBandLine2.LocationFloat = New DevExpress.Utils.PointFloat(162.9452!, 0!)
        Me.XrCrossBandLine2.Name = "XrCrossBandLine2"
        Me.XrCrossBandLine2.StartBand = Me.SubBand2
        Me.XrCrossBandLine2.StartPointFloat = New DevExpress.Utils.PointFloat(162.9452!, 0!)
        Me.XrCrossBandLine2.WidthF = 1.072311!
        '
        'XrCrossBandLine3
        '
        Me.XrCrossBandLine3.EndBand = Me.GroupFooter1
        Me.XrCrossBandLine3.EndPointFloat = New DevExpress.Utils.PointFloat(429.0666!, 2.0!)
        Me.XrCrossBandLine3.LocationFloat = New DevExpress.Utils.PointFloat(429.0666!, 0!)
        Me.XrCrossBandLine3.Name = "XrCrossBandLine3"
        Me.XrCrossBandLine3.StartBand = Me.SubBand2
        Me.XrCrossBandLine3.StartPointFloat = New DevExpress.Utils.PointFloat(429.0666!, 0!)
        Me.XrCrossBandLine3.WidthF = 1.0!
        '
        'XrCrossBandLine4
        '
        Me.XrCrossBandLine4.EndBand = Me.GroupFooter1
        Me.XrCrossBandLine4.EndPointFloat = New DevExpress.Utils.PointFloat(524.3021!, 2.0!)
        Me.XrCrossBandLine4.LocationFloat = New DevExpress.Utils.PointFloat(524.3021!, 0!)
        Me.XrCrossBandLine4.Name = "XrCrossBandLine4"
        Me.XrCrossBandLine4.StartBand = Me.SubBand2
        Me.XrCrossBandLine4.StartPointFloat = New DevExpress.Utils.PointFloat(524.3021!, 0!)
        Me.XrCrossBandLine4.WidthF = 1.0!
        '
        'XrCrossBandLine7
        '
        Me.XrCrossBandLine7.EndBand = Me.GroupFooter1
        Me.XrCrossBandLine7.EndPointFloat = New DevExpress.Utils.PointFloat(613.9372!, 2.0!)
        Me.XrCrossBandLine7.LocationFloat = New DevExpress.Utils.PointFloat(613.9372!, 1.000003!)
        Me.XrCrossBandLine7.Name = "XrCrossBandLine7"
        Me.XrCrossBandLine7.StartBand = Me.SubBand2
        Me.XrCrossBandLine7.StartPointFloat = New DevExpress.Utils.PointFloat(613.9372!, 1.000003!)
        Me.XrCrossBandLine7.WidthF = 1.0!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Division", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 23.0!
        Me.GroupHeader1.Level = 1
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.Visible = False
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.Division")})
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(187.2083!, 0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel2.Text = "XrLabel2"
        '
        'report_CheckComing_Eng
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMarginBand1, Me.BottomMarginBand1, Me.PageFooter, Me.PageHeader, Me.GroupHeader2, Me.ReportFooter, Me.GroupFooter1, Me.GroupHeader1})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.reportName, Me.CalculatedField2, Me.CalculatedField6, Me.CalculatedField3, Me.CalculatedField5})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandLine7, Me.XrCrossBandLine4, Me.XrCrossBandLine3, Me.XrCrossBandLine2, Me.XrCrossBandBox1, Me.XrCrossBandLine1})
        Me.DataMember = "Query"
        Me.DataSource = Me.SqlDataSource1
        Me.FilterString = "[DivId] = '004'"
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.hide_disPer, Me.hide_remark, Me.hide_disPer_bill, Me.hide_lastPage, Me.hide_Price, Me.hide_Tax})
        Me.Margins = New System.Drawing.Printing.Margins(29, 21, 25, 26)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Headname, Me.companyname, Me.cCheckDate, Me.paradate, Me.fullname})
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
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLine8 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents reportName As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalculatedField2 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Headname As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents CalculatedField6 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel60 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CalculatedField3 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel48 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cCheckDate As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents companyname As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel61 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCrossBandLine1 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents SubBand2 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paradate As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents fullname As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents CalculatedField5 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel121 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel119 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCrossBandBox1 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrCrossBandLine2 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine3 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine4 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine7 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents SubBand1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents pcLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents SubBand3 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
End Class
