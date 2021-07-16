<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class report_EmpTimeWork_detail_Eng
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
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(report_EmpTimeWork_detail_Eng))
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary9 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary10 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary11 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary12 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary13 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary14 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary15 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary16 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary17 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary18 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.XrLabel121 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel119 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLine8 = New DevExpress.XtraReports.UI.XRLine()
        Me.reportName = New DevExpress.XtraReports.UI.CalculatedField()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel61 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel59 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SubBand2 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLabel47 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel42 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel58 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel56 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel55 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel54 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel53 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel52 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel51 = New DevExpress.XtraReports.UI.XRLabel()
        Me.CalculatedField2 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.headname = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.pcLogo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.headDate = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel60 = New DevExpress.XtraReports.UI.XRLabel()
        Me.companyname = New DevExpress.XtraReports.Parameters.Parameter()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.CalculatedField6 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalculatedField3 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalculatedField4 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.GroupHeader3 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine3, Me.XrLabel35, Me.XrLabel30, Me.XrLabel25, Me.XrLabel31, Me.XrLabel34, Me.XrLabel32, Me.XrLabel29, Me.XrLabel28, Me.XrLabel24, Me.XrLabel8, Me.XrLabel6, Me.XrLabel4, Me.XrLabel1, Me.XrLabel11})
        Me.Detail.HeightF = 23.95829!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("row", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine3
        '
        Me.XrLine3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.XrLine3.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(10.99994!, 21.95829!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(778.0001!, 2.0!)
        Me.XrLine3.StylePriority.UseForeColor = False
        '
        'XrLabel35
        '
        Me.XrLabel35.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel35.BorderColor = System.Drawing.Color.Black
        Me.XrLabel35.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel35.BorderWidth = 1.0!
        Me.XrLabel35.CanGrow = False
        Me.XrLabel35.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.OT1", "{0:n1}")})
        Me.XrLabel35.Font = New System.Drawing.Font("TH Sarabun New", 10.0!)
        Me.XrLabel35.ForeColor = System.Drawing.Color.Black
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(434.6211!, 0!)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(60.4212!, 21.95829!)
        Me.XrLabel35.StylePriority.UseBackColor = False
        Me.XrLabel35.StylePriority.UseBorderColor = False
        Me.XrLabel35.StylePriority.UseBorders = False
        Me.XrLabel35.StylePriority.UseBorderWidth = False
        Me.XrLabel35.StylePriority.UseFont = False
        Me.XrLabel35.StylePriority.UseForeColor = False
        Me.XrLabel35.StylePriority.UsePadding = False
        Me.XrLabel35.StylePriority.UseTextAlignment = False
        Me.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel30
        '
        Me.XrLabel30.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel30.BorderColor = System.Drawing.Color.Black
        Me.XrLabel30.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel30.BorderWidth = 1.0!
        Me.XrLabel30.CanGrow = False
        Me.XrLabel30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Val", "{0:n1}")})
        Me.XrLabel30.Font = New System.Drawing.Font("TH Sarabun New", 10.0!)
        Me.XrLabel30.ForeColor = System.Drawing.Color.Black
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(626.351!, 0!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(38.0!, 21.95829!)
        Me.XrLabel30.StylePriority.UseBackColor = False
        Me.XrLabel30.StylePriority.UseBorderColor = False
        Me.XrLabel30.StylePriority.UseBorders = False
        Me.XrLabel30.StylePriority.UseBorderWidth = False
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseForeColor = False
        Me.XrLabel30.StylePriority.UsePadding = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel25
        '
        Me.XrLabel25.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel25.BorderColor = System.Drawing.Color.Black
        Me.XrLabel25.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel25.BorderWidth = 1.0!
        Me.XrLabel25.CanGrow = False
        Me.XrLabel25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.DayDo_str", "{0:n2}")})
        Me.XrLabel25.Font = New System.Drawing.Font("TH Sarabun New", 10.0!)
        Me.XrLabel25.ForeColor = System.Drawing.Color.Black
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(391.237!, 0!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(43.384!, 21.95829!)
        Me.XrLabel25.StylePriority.UseBackColor = False
        Me.XrLabel25.StylePriority.UseBorderColor = False
        Me.XrLabel25.StylePriority.UseBorders = False
        Me.XrLabel25.StylePriority.UseBorderWidth = False
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseForeColor = False
        Me.XrLabel25.StylePriority.UsePadding = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrLabel25.Visible = False
        '
        'XrLabel31
        '
        Me.XrLabel31.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel31.BorderColor = System.Drawing.Color.Black
        Me.XrLabel31.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel31.BorderWidth = 1.0!
        Me.XrLabel31.CanGrow = False
        Me.XrLabel31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Absent_str")})
        Me.XrLabel31.Font = New System.Drawing.Font("TH Sarabun New", 10.0!)
        Me.XrLabel31.ForeColor = System.Drawing.Color.Black
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(664.351!, 0!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(37.70868!, 21.95829!)
        Me.XrLabel31.StylePriority.UseBackColor = False
        Me.XrLabel31.StylePriority.UseBorderColor = False
        Me.XrLabel31.StylePriority.UseBorders = False
        Me.XrLabel31.StylePriority.UseBorderWidth = False
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseForeColor = False
        Me.XrLabel31.StylePriority.UsePadding = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel34
        '
        Me.XrLabel34.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel34.BorderColor = System.Drawing.Color.Black
        Me.XrLabel34.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel34.BorderWidth = 1.0!
        Me.XrLabel34.CanGrow = False
        Me.XrLabel34.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.WorkTime", "{0:n1}")})
        Me.XrLabel34.Font = New System.Drawing.Font("TH Sarabun New", 10.0!)
        Me.XrLabel34.ForeColor = System.Drawing.Color.Black
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(739.8224!, 0!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(49.1778!, 21.95829!)
        Me.XrLabel34.StylePriority.UseBackColor = False
        Me.XrLabel34.StylePriority.UseBorderColor = False
        Me.XrLabel34.StylePriority.UseBorders = False
        Me.XrLabel34.StylePriority.UseBorderWidth = False
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.StylePriority.UseForeColor = False
        Me.XrLabel34.StylePriority.UsePadding = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel32
        '
        Me.XrLabel32.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel32.BorderColor = System.Drawing.Color.Black
        Me.XrLabel32.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel32.BorderWidth = 1.0!
        Me.XrLabel32.CanGrow = False
        Me.XrLabel32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Late", "{0:n0}")})
        Me.XrLabel32.Font = New System.Drawing.Font("TH Sarabun New", 10.0!)
        Me.XrLabel32.ForeColor = System.Drawing.Color.Black
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(702.0597!, 0!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(37.7627!, 21.95829!)
        Me.XrLabel32.StylePriority.UseBackColor = False
        Me.XrLabel32.StylePriority.UseBorderColor = False
        Me.XrLabel32.StylePriority.UseBorders = False
        Me.XrLabel32.StylePriority.UseBorderWidth = False
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseForeColor = False
        Me.XrLabel32.StylePriority.UsePadding = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel29
        '
        Me.XrLabel29.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel29.BorderColor = System.Drawing.Color.Black
        Me.XrLabel29.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel29.BorderWidth = 1.0!
        Me.XrLabel29.CanGrow = False
        Me.XrLabel29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.OT15", "{0:n1}")})
        Me.XrLabel29.Font = New System.Drawing.Font("TH Sarabun New", 10.0!)
        Me.XrLabel29.ForeColor = System.Drawing.Color.Black
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(560.4866!, 0!)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(60.41699!, 21.95829!)
        Me.XrLabel29.StylePriority.UseBackColor = False
        Me.XrLabel29.StylePriority.UseBorderColor = False
        Me.XrLabel29.StylePriority.UseBorders = False
        Me.XrLabel29.StylePriority.UseBorderWidth = False
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseForeColor = False
        Me.XrLabel29.StylePriority.UsePadding = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel28
        '
        Me.XrLabel28.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel28.BorderColor = System.Drawing.Color.Black
        Me.XrLabel28.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel28.BorderWidth = 1.0!
        Me.XrLabel28.CanGrow = False
        Me.XrLabel28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.OT3", "{0:n1}")})
        Me.XrLabel28.Font = New System.Drawing.Font("TH Sarabun New", 10.0!)
        Me.XrLabel28.ForeColor = System.Drawing.Color.Black
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(495.0423!, 0!)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(65.44431!, 21.95829!)
        Me.XrLabel28.StylePriority.UseBackColor = False
        Me.XrLabel28.StylePriority.UseBorderColor = False
        Me.XrLabel28.StylePriority.UseBorders = False
        Me.XrLabel28.StylePriority.UseBorderWidth = False
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseForeColor = False
        Me.XrLabel28.StylePriority.UsePadding = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel24
        '
        Me.XrLabel24.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel24.BorderColor = System.Drawing.Color.Black
        Me.XrLabel24.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel24.BorderWidth = 1.0!
        Me.XrLabel24.CanGrow = False
        Me.XrLabel24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Holiday")})
        Me.XrLabel24.Font = New System.Drawing.Font("TH Sarabun New", 10.0!)
        Me.XrLabel24.ForeColor = System.Drawing.Color.Black
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(241.9175!, 0!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(136.452!, 21.95828!)
        Me.XrLabel24.StylePriority.UseBackColor = False
        Me.XrLabel24.StylePriority.UseBorderColor = False
        Me.XrLabel24.StylePriority.UseBorders = False
        Me.XrLabel24.StylePriority.UseBorderWidth = False
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseForeColor = False
        Me.XrLabel24.StylePriority.UsePadding = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0}"
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel24.Summary = XrSummary1
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel8.BorderColor = System.Drawing.Color.Black
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.BorderWidth = 1.0!
        Me.XrLabel8.CanGrow = False
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Time4", "{0:HH:mm}")})
        Me.XrLabel8.Font = New System.Drawing.Font("TH Sarabun New", 10.0!)
        Me.XrLabel8.ForeColor = System.Drawing.Color.Black
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(204.9175!, 0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(33.0!, 21.95829!)
        Me.XrLabel8.StylePriority.UseBackColor = False
        Me.XrLabel8.StylePriority.UseBorderColor = False
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseBorderWidth = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseForeColor = False
        Me.XrLabel8.StylePriority.UsePadding = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel6.BorderColor = System.Drawing.Color.Black
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel6.BorderWidth = 1.0!
        Me.XrLabel6.CanGrow = False
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Time3", "{0:HH:mm}")})
        Me.XrLabel6.Font = New System.Drawing.Font("TH Sarabun New", 10.0!)
        Me.XrLabel6.ForeColor = System.Drawing.Color.Black
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(167.9452!, 0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(33.0!, 21.95829!)
        Me.XrLabel6.StylePriority.UseBackColor = False
        Me.XrLabel6.StylePriority.UseBorderColor = False
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseBorderWidth = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.StylePriority.UsePadding = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel4.BorderColor = System.Drawing.Color.Black
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.BorderWidth = 1.0!
        Me.XrLabel4.CanGrow = False
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Time2", "{0:HH:mm}")})
        Me.XrLabel4.Font = New System.Drawing.Font("TH Sarabun New", 10.0!)
        Me.XrLabel4.ForeColor = System.Drawing.Color.Black
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(130.9452!, 0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(33.0!, 21.95829!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseBorderColor = False
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseBorderWidth = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UsePadding = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.BorderColor = System.Drawing.Color.Black
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.BorderWidth = 1.0!
        Me.XrLabel1.CanGrow = False
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Time1", "{0:HH:mm}")})
        Me.XrLabel1.Font = New System.Drawing.Font("TH Sarabun New", 10.0!)
        Me.XrLabel1.ForeColor = System.Drawing.Color.Black
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(95.0!, 0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(33.0!, 21.95829!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseBorderColor = False
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseBorderWidth = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UsePadding = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel11.BorderColor = System.Drawing.Color.Black
        Me.XrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel11.BorderWidth = 1.0!
        Me.XrLabel11.CanGrow = False
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.DateIn", "{0:dd/MM/yyyy}")})
        Me.XrLabel11.Font = New System.Drawing.Font("TH Sarabun New", 10.0!)
        Me.XrLabel11.ForeColor = System.Drawing.Color.Black
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(10.99993!, 0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(84.00005!, 21.95829!)
        Me.XrLabel11.StylePriority.UseBackColor = False
        Me.XrLabel11.StylePriority.UseBorderColor = False
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseBorderWidth = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseForeColor = False
        Me.XrLabel11.StylePriority.UsePadding = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0}"
        XrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel11.Summary = XrSummary2
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        Me.BottomMarginBand1.HeightF = 23.0!
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
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel121, Me.XrPageInfo1, Me.XrLabel119, Me.XrPageInfo2, Me.XrLine8})
        Me.PageFooter.HeightF = 39.91318!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrLabel121
        '
        Me.XrLabel121.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel121.BorderColor = System.Drawing.Color.Black
        Me.XrLabel121.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel121.BorderWidth = 1.0!
        Me.XrLabel121.CanGrow = False
        Me.XrLabel121.Font = New System.Drawing.Font("TH Sarabun New", 8.0!)
        Me.XrLabel121.ForeColor = System.Drawing.Color.Black
        Me.XrLabel121.LocationFloat = New DevExpress.Utils.PointFloat(14.83334!, 4.75004!)
        Me.XrLabel121.Name = "XrLabel121"
        Me.XrLabel121.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel121.SizeF = New System.Drawing.SizeF(54.0!, 22.00009!)
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
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("TH Sarabun New", 8.0!)
        Me.XrPageInfo1.Format = "{0:dd/MM/yyyy HH:mm:ss}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(68.83335!, 4.75004!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(158.0357!, 21.16317!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel119
        '
        Me.XrLabel119.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel119.BorderColor = System.Drawing.Color.Black
        Me.XrLabel119.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel119.BorderWidth = 1.0!
        Me.XrLabel119.CanGrow = False
        Me.XrLabel119.Font = New System.Drawing.Font("TH Sarabun New", 8.0!)
        Me.XrLabel119.ForeColor = System.Drawing.Color.Black
        Me.XrLabel119.LocationFloat = New DevExpress.Utils.PointFloat(722.6385!, 4.75004!)
        Me.XrLabel119.Name = "XrLabel119"
        Me.XrLabel119.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel119.SizeF = New System.Drawing.SizeF(29.35052!, 17.16319!)
        Me.XrLabel119.StylePriority.UseBackColor = False
        Me.XrLabel119.StylePriority.UseBorderColor = False
        Me.XrLabel119.StylePriority.UseBorders = False
        Me.XrLabel119.StylePriority.UseBorderWidth = False
        Me.XrLabel119.StylePriority.UseFont = False
        Me.XrLabel119.StylePriority.UseForeColor = False
        Me.XrLabel119.StylePriority.UseTextAlignment = False
        Me.XrLabel119.Text = "Page"
        Me.XrLabel119.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("TH Sarabun New", 8.0!)
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(751.989!, 4.75004!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(38.01105!, 17.16319!)
        Me.XrPageInfo2.StylePriority.UseFont = False
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLine8
        '
        Me.XrLine8.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0!)
        Me.XrLine8.Name = "XrLine8"
        Me.XrLine8.SizeF = New System.Drawing.SizeF(779.0001!, 4.750061!)
        '
        'reportName
        '
        Me.reportName.DataMember = "vw_SO_quotation_report"
        Me.reportName.Expression = "'รายงานสรุปใบรับซื้อสินค้า ตามลูกค้า,ใบเสร็จ' + iif([Parameters.topRow] > 0,' (To" &
    "p ' + [Parameters.topRow] + ')','')"
        Me.reportName.Name = "reportName"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel61, Me.XrLabel59, Me.XrLabel13, Me.XrLabel16, Me.XrLabel17, Me.XrLabel18, Me.XrLabel12, Me.XrLabel10, Me.XrLabel9, Me.XrLabel7, Me.XrLabel5, Me.XrLabel3})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Code", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 52.50002!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand2})
        '
        'XrLabel61
        '
        Me.XrLabel61.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel61.BorderColor = System.Drawing.Color.Black
        Me.XrLabel61.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel61.BorderWidth = 1.0!
        Me.XrLabel61.CanGrow = False
        Me.XrLabel61.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.CalculatedField3")})
        Me.XrLabel61.Font = New System.Drawing.Font("TH Sarabun New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel61.ForeColor = System.Drawing.Color.Black
        Me.XrLabel61.LocationFloat = New DevExpress.Utils.PointFloat(49.18069!, 4.083071!)
        Me.XrLabel61.Name = "XrLabel61"
        Me.XrLabel61.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel61.SizeF = New System.Drawing.SizeF(78.81932!, 21.95829!)
        Me.XrLabel61.StylePriority.UseBackColor = False
        Me.XrLabel61.StylePriority.UseBorderColor = False
        Me.XrLabel61.StylePriority.UseBorders = False
        Me.XrLabel61.StylePriority.UseBorderWidth = False
        Me.XrLabel61.StylePriority.UseFont = False
        Me.XrLabel61.StylePriority.UseForeColor = False
        Me.XrLabel61.StylePriority.UsePadding = False
        Me.XrLabel61.StylePriority.UseTextAlignment = False
        XrSummary3.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel61.Summary = XrSummary3
        Me.XrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        Me.XrLabel59.LocationFloat = New DevExpress.Utils.PointFloat(11.77858!, 4.083071!)
        Me.XrLabel59.Name = "XrLabel59"
        Me.XrLabel59.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel59.SizeF = New System.Drawing.SizeF(34.34719!, 22.00009!)
        Me.XrLabel59.StylePriority.UseBackColor = False
        Me.XrLabel59.StylePriority.UseBorderColor = False
        Me.XrLabel59.StylePriority.UseBorders = False
        Me.XrLabel59.StylePriority.UseBorderWidth = False
        Me.XrLabel59.StylePriority.UseFont = False
        Me.XrLabel59.StylePriority.UseForeColor = False
        Me.XrLabel59.StylePriority.UseTextAlignment = False
        Me.XrLabel59.Text = "No. :"
        Me.XrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel13
        '
        Me.XrLabel13.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel13.BorderColor = System.Drawing.Color.Black
        Me.XrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel13.BorderWidth = 1.0!
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Department")})
        Me.XrLabel13.Font = New System.Drawing.Font("TH Sarabun New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel13.ForeColor = System.Drawing.Color.Black
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(406.4053!, 30.49992!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(364.5948!, 21.95828!)
        Me.XrLabel13.StylePriority.UseBackColor = False
        Me.XrLabel13.StylePriority.UseBorderColor = False
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseBorderWidth = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseForeColor = False
        Me.XrLabel13.StylePriority.UsePadding = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0}"
        XrSummary4.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel13.Summary = XrSummary4
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel16.BorderColor = System.Drawing.Color.Black
        Me.XrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel16.BorderWidth = 1.0!
        Me.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Division")})
        Me.XrLabel16.Font = New System.Drawing.Font("TH Sarabun New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel16.ForeColor = System.Drawing.Color.Black
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(68.83335!, 30.49992!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(241.5828!, 21.95828!)
        Me.XrLabel16.StylePriority.UseBackColor = False
        Me.XrLabel16.StylePriority.UseBorderColor = False
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseBorderWidth = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseForeColor = False
        Me.XrLabel16.StylePriority.UsePadding = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        XrSummary5.FormatString = "{0}"
        XrSummary5.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel16.Summary = XrSummary5
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel17
        '
        Me.XrLabel17.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel17.BorderColor = System.Drawing.Color.Black
        Me.XrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel17.BorderWidth = 1.0!
        Me.XrLabel17.CanGrow = False
        Me.XrLabel17.Font = New System.Drawing.Font("TH Sarabun New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel17.ForeColor = System.Drawing.Color.Black
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(325.5844!, 30.4999!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(80.82086!, 22.00009!)
        Me.XrLabel17.StylePriority.UseBackColor = False
        Me.XrLabel17.StylePriority.UseBorderColor = False
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseBorderWidth = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseForeColor = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "Department :"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel18.BorderColor = System.Drawing.Color.Black
        Me.XrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel18.BorderWidth = 1.0!
        Me.XrLabel18.CanGrow = False
        Me.XrLabel18.Font = New System.Drawing.Font("TH Sarabun New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel18.ForeColor = System.Drawing.Color.Black
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(10.99992!, 30.49992!)
        Me.XrLabel18.Multiline = True
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(57.83342!, 22.00009!)
        Me.XrLabel18.StylePriority.UseBackColor = False
        Me.XrLabel18.StylePriority.UseBorderColor = False
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseBorderWidth = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseForeColor = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "Section :"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(657.1849!, 4.083071!)
        Me.XrLabel12.Multiline = True
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(38.9953!, 22.00009!)
        Me.XrLabel12.StylePriority.UseBackColor = False
        Me.XrLabel12.StylePriority.UseBorderColor = False
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseBorderWidth = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseForeColor = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Shift :"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(325.5844!, 4.083071!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(139.0092!, 22.00009!)
        Me.XrLabel10.StylePriority.UseBackColor = False
        Me.XrLabel10.StylePriority.UseBorderColor = False
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseBorderWidth = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseForeColor = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "First name - Last name :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel9.BorderColor = System.Drawing.Color.Black
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel9.BorderWidth = 1.0!
        Me.XrLabel9.CanGrow = False
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.KaCode")})
        Me.XrLabel9.Font = New System.Drawing.Font("TH Sarabun New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.ForeColor = System.Drawing.Color.Black
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(696.1802!, 4.083061!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(74.81989!, 21.95828!)
        Me.XrLabel9.StylePriority.UseBackColor = False
        Me.XrLabel9.StylePriority.UseBorderColor = False
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseBorderWidth = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseForeColor = False
        Me.XrLabel9.StylePriority.UsePadding = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        XrSummary6.FormatString = "{0}"
        XrSummary6.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel9.Summary = XrSummary6
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel7.BorderColor = System.Drawing.Color.Black
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel7.BorderWidth = 1.0!
        Me.XrLabel7.CanGrow = False
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Code")})
        Me.XrLabel7.Font = New System.Drawing.Font("TH Sarabun New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.ForeColor = System.Drawing.Color.Black
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(217.9452!, 4.083061!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(106.9029!, 21.95828!)
        Me.XrLabel7.StylePriority.UseBackColor = False
        Me.XrLabel7.StylePriority.UseBorderColor = False
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseBorderWidth = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.StylePriority.UsePadding = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        XrSummary7.FormatString = "{0}"
        XrSummary7.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel7.Summary = XrSummary7
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(130.9452!, 4.083071!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(86.99998!, 22.00009!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseBorderColor = False
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseBorderWidth = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Employee ID :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel3.BorderColor = System.Drawing.Color.Black
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.BorderWidth = 1.0!
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.CalculatedField2")})
        Me.XrLabel3.Font = New System.Drawing.Font("TH Sarabun New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.ForeColor = System.Drawing.Color.Black
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(465.5936!, 4.083071!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(176.5721!, 21.95828!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseBorderColor = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseBorderWidth = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UsePadding = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        XrSummary8.FormatString = "{0}"
        XrSummary8.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel3.Summary = XrSummary8
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'SubBand2
        '
        Me.SubBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel47, Me.XrLabel45, Me.XrLabel44, Me.XrLabel43, Me.XrLabel42, Me.XrLabel40, Me.XrLabel39, Me.XrLine2, Me.XrLabel19, Me.XrLabel23, Me.XrLabel22, Me.XrLabel21, Me.XrLabel20, Me.XrLine1})
        Me.SubBand2.HeightF = 47.37513!
        Me.SubBand2.Name = "SubBand2"
        '
        'XrLabel47
        '
        Me.XrLabel47.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel47.BorderColor = System.Drawing.Color.Black
        Me.XrLabel47.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel47.BorderWidth = 1.0!
        Me.XrLabel47.CanGrow = False
        Me.XrLabel47.Font = New System.Drawing.Font("TH Sarabun New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel47.ForeColor = System.Drawing.Color.Black
        Me.XrLabel47.LocationFloat = New DevExpress.Utils.PointFloat(738.8224!, 2.000046!)
        Me.XrLabel47.Multiline = True
        Me.XrLabel47.Name = "XrLabel47"
        Me.XrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel47.SizeF = New System.Drawing.SizeF(49.17773!, 41.37507!)
        Me.XrLabel47.StylePriority.UseBackColor = False
        Me.XrLabel47.StylePriority.UseBorderColor = False
        Me.XrLabel47.StylePriority.UseBorders = False
        Me.XrLabel47.StylePriority.UseBorderWidth = False
        Me.XrLabel47.StylePriority.UseFont = False
        Me.XrLabel47.StylePriority.UseForeColor = False
        Me.XrLabel47.StylePriority.UseTextAlignment = False
        Me.XrLabel47.Text = "Working hour" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel45
        '
        Me.XrLabel45.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel45.BorderColor = System.Drawing.Color.Black
        Me.XrLabel45.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel45.BorderWidth = 1.0!
        Me.XrLabel45.CanGrow = False
        Me.XrLabel45.Font = New System.Drawing.Font("TH Sarabun New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel45.ForeColor = System.Drawing.Color.Black
        Me.XrLabel45.LocationFloat = New DevExpress.Utils.PointFloat(701.0597!, 21.37502!)
        Me.XrLabel45.Multiline = True
        Me.XrLabel45.Name = "XrLabel45"
        Me.XrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel45.SizeF = New System.Drawing.SizeF(37.76263!, 22.00009!)
        Me.XrLabel45.StylePriority.UseBackColor = False
        Me.XrLabel45.StylePriority.UseBorderColor = False
        Me.XrLabel45.StylePriority.UseBorders = False
        Me.XrLabel45.StylePriority.UseBorderWidth = False
        Me.XrLabel45.StylePriority.UseFont = False
        Me.XrLabel45.StylePriority.UseForeColor = False
        Me.XrLabel45.StylePriority.UseTextAlignment = False
        Me.XrLabel45.Text = "late" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel44
        '
        Me.XrLabel44.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel44.BorderColor = System.Drawing.Color.Black
        Me.XrLabel44.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel44.BorderWidth = 1.0!
        Me.XrLabel44.CanGrow = False
        Me.XrLabel44.Font = New System.Drawing.Font("TH Sarabun New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel44.ForeColor = System.Drawing.Color.Black
        Me.XrLabel44.LocationFloat = New DevExpress.Utils.PointFloat(663.3511!, 21.37502!)
        Me.XrLabel44.Multiline = True
        Me.XrLabel44.Name = "XrLabel44"
        Me.XrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel44.SizeF = New System.Drawing.SizeF(37.70868!, 22.00009!)
        Me.XrLabel44.StylePriority.UseBackColor = False
        Me.XrLabel44.StylePriority.UseBorderColor = False
        Me.XrLabel44.StylePriority.UseBorders = False
        Me.XrLabel44.StylePriority.UseBorderWidth = False
        Me.XrLabel44.StylePriority.UseFont = False
        Me.XrLabel44.StylePriority.UseForeColor = False
        Me.XrLabel44.StylePriority.UseTextAlignment = False
        Me.XrLabel44.Text = "Lacking" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel43
        '
        Me.XrLabel43.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel43.BorderColor = System.Drawing.Color.Black
        Me.XrLabel43.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel43.BorderWidth = 1.0!
        Me.XrLabel43.CanGrow = False
        Me.XrLabel43.Font = New System.Drawing.Font("TH Sarabun New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel43.ForeColor = System.Drawing.Color.Black
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(625.3511!, 21.37502!)
        Me.XrLabel43.Multiline = True
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(38.0!, 22.00009!)
        Me.XrLabel43.StylePriority.UseBackColor = False
        Me.XrLabel43.StylePriority.UseBorderColor = False
        Me.XrLabel43.StylePriority.UseBorders = False
        Me.XrLabel43.StylePriority.UseBorderWidth = False
        Me.XrLabel43.StylePriority.UseFont = False
        Me.XrLabel43.StylePriority.UseForeColor = False
        Me.XrLabel43.StylePriority.UseTextAlignment = False
        Me.XrLabel43.Text = "Leave" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel42
        '
        Me.XrLabel42.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel42.BorderColor = System.Drawing.Color.Black
        Me.XrLabel42.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel42.BorderWidth = 1.0!
        Me.XrLabel42.CanGrow = False
        Me.XrLabel42.Font = New System.Drawing.Font("TH Sarabun New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel42.ForeColor = System.Drawing.Color.Black
        Me.XrLabel42.LocationFloat = New DevExpress.Utils.PointFloat(559.4868!, 2.000046!)
        Me.XrLabel42.Multiline = True
        Me.XrLabel42.Name = "XrLabel42"
        Me.XrLabel42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel42.SizeF = New System.Drawing.SizeF(60.41693!, 41.37507!)
        Me.XrLabel42.StylePriority.UseBackColor = False
        Me.XrLabel42.StylePriority.UseBorderColor = False
        Me.XrLabel42.StylePriority.UseBorders = False
        Me.XrLabel42.StylePriority.UseBorderWidth = False
        Me.XrLabel42.StylePriority.UseFont = False
        Me.XrLabel42.StylePriority.UseForeColor = False
        Me.XrLabel42.StylePriority.UseTextAlignment = False
        Me.XrLabel42.Text = "OT normal day" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel40
        '
        Me.XrLabel40.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel40.BorderColor = System.Drawing.Color.Black
        Me.XrLabel40.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel40.BorderWidth = 1.0!
        Me.XrLabel40.CanGrow = False
        Me.XrLabel40.Font = New System.Drawing.Font("TH Sarabun New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel40.ForeColor = System.Drawing.Color.Black
        Me.XrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(494.0424!, 2.000046!)
        Me.XrLabel40.Multiline = True
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel40.SizeF = New System.Drawing.SizeF(65.44434!, 41.37507!)
        Me.XrLabel40.StylePriority.UseBackColor = False
        Me.XrLabel40.StylePriority.UseBorderColor = False
        Me.XrLabel40.StylePriority.UseBorders = False
        Me.XrLabel40.StylePriority.UseBorderWidth = False
        Me.XrLabel40.StylePriority.UseFont = False
        Me.XrLabel40.StylePriority.UseForeColor = False
        Me.XrLabel40.StylePriority.UseTextAlignment = False
        Me.XrLabel40.Text = "OT-Holiday(Out time)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel39
        '
        Me.XrLabel39.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel39.BorderColor = System.Drawing.Color.Black
        Me.XrLabel39.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel39.BorderWidth = 1.0!
        Me.XrLabel39.CanGrow = False
        Me.XrLabel39.Font = New System.Drawing.Font("TH Sarabun New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel39.ForeColor = System.Drawing.Color.Black
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(433.6212!, 2.000046!)
        Me.XrLabel39.Multiline = True
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(60.42126!, 41.37507!)
        Me.XrLabel39.StylePriority.UseBackColor = False
        Me.XrLabel39.StylePriority.UseBorderColor = False
        Me.XrLabel39.StylePriority.UseBorders = False
        Me.XrLabel39.StylePriority.UseBorderWidth = False
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.StylePriority.UseForeColor = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        Me.XrLabel39.Text = "OT-Holiday(In time)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(9.386508!, 45.37513!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(778.0001!, 2.0!)
        '
        'XrLabel19
        '
        Me.XrLabel19.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel19.BorderColor = System.Drawing.Color.Black
        Me.XrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel19.BorderWidth = 1.0!
        Me.XrLabel19.CanGrow = False
        Me.XrLabel19.Font = New System.Drawing.Font("TH Sarabun New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel19.ForeColor = System.Drawing.Color.Black
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(11.77858!, 21.37502!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(82.22147!, 22.00009!)
        Me.XrLabel19.StylePriority.UseBackColor = False
        Me.XrLabel19.StylePriority.UseBorderColor = False
        Me.XrLabel19.StylePriority.UseBorders = False
        Me.XrLabel19.StylePriority.UseBorderWidth = False
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseForeColor = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "Date"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel23
        '
        Me.XrLabel23.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel23.BorderColor = System.Drawing.Color.Black
        Me.XrLabel23.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel23.BorderWidth = 1.0!
        Me.XrLabel23.CanGrow = False
        Me.XrLabel23.Font = New System.Drawing.Font("TH Sarabun New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel23.ForeColor = System.Drawing.Color.Black
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(203.9176!, 21.37502!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(33.00002!, 22.00009!)
        Me.XrLabel23.StylePriority.UseBackColor = False
        Me.XrLabel23.StylePriority.UseBorderColor = False
        Me.XrLabel23.StylePriority.UseBorders = False
        Me.XrLabel23.StylePriority.UseBorderWidth = False
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseForeColor = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "Out"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel22
        '
        Me.XrLabel22.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel22.BorderColor = System.Drawing.Color.Black
        Me.XrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel22.BorderWidth = 1.0!
        Me.XrLabel22.CanGrow = False
        Me.XrLabel22.Font = New System.Drawing.Font("TH Sarabun New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel22.ForeColor = System.Drawing.Color.Black
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(166.9453!, 21.37502!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(33.0!, 22.00009!)
        Me.XrLabel22.StylePriority.UseBackColor = False
        Me.XrLabel22.StylePriority.UseBorderColor = False
        Me.XrLabel22.StylePriority.UseBorders = False
        Me.XrLabel22.StylePriority.UseBorderWidth = False
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseForeColor = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "In"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel21
        '
        Me.XrLabel21.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel21.BorderColor = System.Drawing.Color.Black
        Me.XrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel21.BorderWidth = 1.0!
        Me.XrLabel21.CanGrow = False
        Me.XrLabel21.Font = New System.Drawing.Font("TH Sarabun New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel21.ForeColor = System.Drawing.Color.Black
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(129.9453!, 21.37502!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(33.00002!, 22.00009!)
        Me.XrLabel21.StylePriority.UseBackColor = False
        Me.XrLabel21.StylePriority.UseBorderColor = False
        Me.XrLabel21.StylePriority.UseBorders = False
        Me.XrLabel21.StylePriority.UseBorderWidth = False
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseForeColor = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "Out"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel20
        '
        Me.XrLabel20.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel20.BorderColor = System.Drawing.Color.Black
        Me.XrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel20.BorderWidth = 1.0!
        Me.XrLabel20.CanGrow = False
        Me.XrLabel20.Font = New System.Drawing.Font("TH Sarabun New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel20.ForeColor = System.Drawing.Color.Black
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(94.00005!, 21.37502!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(33.00001!, 22.00009!)
        Me.XrLabel20.StylePriority.UseBackColor = False
        Me.XrLabel20.StylePriority.UseBorderColor = False
        Me.XrLabel20.StylePriority.UseBorders = False
        Me.XrLabel20.StylePriority.UseBorderWidth = False
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseForeColor = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "In"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(778.0001!, 2.0!)
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel15, Me.XrLabel14, Me.XrLine5, Me.XrLabel36, Me.XrLabel58, Me.XrLabel56, Me.XrLabel55, Me.XrLabel54, Me.XrLabel53, Me.XrLabel52, Me.XrLabel51})
        Me.GroupFooter1.HeightF = 22.22218!
        Me.GroupFooter1.KeepTogether = True
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry
        '
        'XrLabel15
        '
        Me.XrLabel15.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel15.BorderColor = System.Drawing.Color.Black
        Me.XrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel15.BorderWidth = 1.0!
        Me.XrLabel15.CanGrow = False
        Me.XrLabel15.Font = New System.Drawing.Font("TH Sarabun New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.ForeColor = System.Drawing.Color.Black
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(363.3638!, 2.000003!)
        Me.XrLabel15.Multiline = True
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(48.0415!, 16.40273!)
        Me.XrLabel15.StylePriority.UseBackColor = False
        Me.XrLabel15.StylePriority.UseBorderColor = False
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseBorderWidth = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseForeColor = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "Workday" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel14
        '
        Me.XrLabel14.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel14.BorderColor = System.Drawing.Color.Black
        Me.XrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel14.BorderWidth = 1.0!
        Me.XrLabel14.CanGrow = False
        Me.XrLabel14.Font = New System.Drawing.Font("TH Sarabun New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.ForeColor = System.Drawing.Color.Black
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(10.99993!, 2.000003!)
        Me.XrLabel14.Multiline = True
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(189.9453!, 16.40273!)
        Me.XrLabel14.StylePriority.UseBackColor = False
        Me.XrLabel14.StylePriority.UseBorderColor = False
        Me.XrLabel14.StylePriority.UseBorders = False
        Me.XrLabel14.StylePriority.UseBorderWidth = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseForeColor = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLine5
        '
        Me.XrLine5.LocationFloat = New DevExpress.Utils.PointFloat(10.99993!, 0!)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.SizeF = New System.Drawing.SizeF(778.0001!, 2.0!)
        '
        'XrLabel36
        '
        Me.XrLabel36.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel36.BorderColor = System.Drawing.Color.Black
        Me.XrLabel36.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel36.BorderWidth = 1.0!
        Me.XrLabel36.CanGrow = False
        Me.XrLabel36.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.DayDo")})
        Me.XrLabel36.Font = New System.Drawing.Font("TH Sarabun New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel36.ForeColor = System.Drawing.Color.Black
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(262.9578!, 2.000003!)
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(86.93948!, 16.40273!)
        Me.XrLabel36.StylePriority.UseBackColor = False
        Me.XrLabel36.StylePriority.UseBorderColor = False
        Me.XrLabel36.StylePriority.UseBorders = False
        Me.XrLabel36.StylePriority.UseBorderWidth = False
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.StylePriority.UseForeColor = False
        Me.XrLabel36.StylePriority.UsePadding = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        XrSummary9.FormatString = "{0:n0}"
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel36.Summary = XrSummary9
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel58
        '
        Me.XrLabel58.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel58.BorderColor = System.Drawing.Color.Black
        Me.XrLabel58.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel58.BorderWidth = 1.0!
        Me.XrLabel58.CanGrow = False
        Me.XrLabel58.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.WorkTime")})
        Me.XrLabel58.Font = New System.Drawing.Font("TH Sarabun New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel58.ForeColor = System.Drawing.Color.Black
        Me.XrLabel58.LocationFloat = New DevExpress.Utils.PointFloat(739.8224!, 2.000003!)
        Me.XrLabel58.Name = "XrLabel58"
        Me.XrLabel58.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel58.SizeF = New System.Drawing.SizeF(48.56415!, 16.40273!)
        Me.XrLabel58.StylePriority.UseBackColor = False
        Me.XrLabel58.StylePriority.UseBorderColor = False
        Me.XrLabel58.StylePriority.UseBorders = False
        Me.XrLabel58.StylePriority.UseBorderWidth = False
        Me.XrLabel58.StylePriority.UseFont = False
        Me.XrLabel58.StylePriority.UseForeColor = False
        Me.XrLabel58.StylePriority.UsePadding = False
        Me.XrLabel58.StylePriority.UseTextAlignment = False
        XrSummary10.FormatString = "{0:n1}"
        XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel58.Summary = XrSummary10
        Me.XrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel56
        '
        Me.XrLabel56.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel56.BorderColor = System.Drawing.Color.Black
        Me.XrLabel56.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel56.BorderWidth = 1.0!
        Me.XrLabel56.CanGrow = False
        Me.XrLabel56.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Late")})
        Me.XrLabel56.Font = New System.Drawing.Font("TH Sarabun New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel56.ForeColor = System.Drawing.Color.Black
        Me.XrLabel56.LocationFloat = New DevExpress.Utils.PointFloat(702.0597!, 2.000003!)
        Me.XrLabel56.Name = "XrLabel56"
        Me.XrLabel56.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel56.SizeF = New System.Drawing.SizeF(37.7627!, 16.40273!)
        Me.XrLabel56.StylePriority.UseBackColor = False
        Me.XrLabel56.StylePriority.UseBorderColor = False
        Me.XrLabel56.StylePriority.UseBorders = False
        Me.XrLabel56.StylePriority.UseBorderWidth = False
        Me.XrLabel56.StylePriority.UseFont = False
        Me.XrLabel56.StylePriority.UseForeColor = False
        Me.XrLabel56.StylePriority.UsePadding = False
        Me.XrLabel56.StylePriority.UseTextAlignment = False
        XrSummary11.FormatString = "{0:n0}"
        XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel56.Summary = XrSummary11
        Me.XrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel55
        '
        Me.XrLabel55.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel55.BorderColor = System.Drawing.Color.Black
        Me.XrLabel55.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel55.BorderWidth = 1.0!
        Me.XrLabel55.CanGrow = False
        Me.XrLabel55.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Absent")})
        Me.XrLabel55.Font = New System.Drawing.Font("TH Sarabun New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel55.ForeColor = System.Drawing.Color.Black
        Me.XrLabel55.LocationFloat = New DevExpress.Utils.PointFloat(664.3511!, 2.000003!)
        Me.XrLabel55.Name = "XrLabel55"
        Me.XrLabel55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel55.SizeF = New System.Drawing.SizeF(37.70862!, 16.40273!)
        Me.XrLabel55.StylePriority.UseBackColor = False
        Me.XrLabel55.StylePriority.UseBorderColor = False
        Me.XrLabel55.StylePriority.UseBorders = False
        Me.XrLabel55.StylePriority.UseBorderWidth = False
        Me.XrLabel55.StylePriority.UseFont = False
        Me.XrLabel55.StylePriority.UseForeColor = False
        Me.XrLabel55.StylePriority.UsePadding = False
        Me.XrLabel55.StylePriority.UseTextAlignment = False
        XrSummary12.FormatString = "{0:n0}"
        XrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel55.Summary = XrSummary12
        Me.XrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel54
        '
        Me.XrLabel54.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel54.BorderColor = System.Drawing.Color.Black
        Me.XrLabel54.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel54.BorderWidth = 1.0!
        Me.XrLabel54.CanGrow = False
        Me.XrLabel54.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Val", "{0:n1}")})
        Me.XrLabel54.Font = New System.Drawing.Font("TH Sarabun New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel54.ForeColor = System.Drawing.Color.Black
        Me.XrLabel54.LocationFloat = New DevExpress.Utils.PointFloat(626.351!, 2.000003!)
        Me.XrLabel54.Name = "XrLabel54"
        Me.XrLabel54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel54.SizeF = New System.Drawing.SizeF(38.00006!, 16.40273!)
        Me.XrLabel54.StylePriority.UseBackColor = False
        Me.XrLabel54.StylePriority.UseBorderColor = False
        Me.XrLabel54.StylePriority.UseBorders = False
        Me.XrLabel54.StylePriority.UseBorderWidth = False
        Me.XrLabel54.StylePriority.UseFont = False
        Me.XrLabel54.StylePriority.UseForeColor = False
        Me.XrLabel54.StylePriority.UsePadding = False
        Me.XrLabel54.StylePriority.UseTextAlignment = False
        XrSummary13.FormatString = "{0:n2}"
        XrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel54.Summary = XrSummary13
        Me.XrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel53
        '
        Me.XrLabel53.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel53.BorderColor = System.Drawing.Color.Black
        Me.XrLabel53.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel53.BorderWidth = 1.0!
        Me.XrLabel53.CanGrow = False
        Me.XrLabel53.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.OT15", "{0:n1}")})
        Me.XrLabel53.Font = New System.Drawing.Font("TH Sarabun New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel53.ForeColor = System.Drawing.Color.Black
        Me.XrLabel53.LocationFloat = New DevExpress.Utils.PointFloat(560.4866!, 2.000003!)
        Me.XrLabel53.Name = "XrLabel53"
        Me.XrLabel53.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel53.SizeF = New System.Drawing.SizeF(60.41699!, 16.40273!)
        Me.XrLabel53.StylePriority.UseBackColor = False
        Me.XrLabel53.StylePriority.UseBorderColor = False
        Me.XrLabel53.StylePriority.UseBorders = False
        Me.XrLabel53.StylePriority.UseBorderWidth = False
        Me.XrLabel53.StylePriority.UseFont = False
        Me.XrLabel53.StylePriority.UseForeColor = False
        Me.XrLabel53.StylePriority.UsePadding = False
        Me.XrLabel53.StylePriority.UseTextAlignment = False
        XrSummary14.FormatString = "{0:n2}"
        XrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel53.Summary = XrSummary14
        Me.XrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel52
        '
        Me.XrLabel52.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel52.BorderColor = System.Drawing.Color.Black
        Me.XrLabel52.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel52.BorderWidth = 1.0!
        Me.XrLabel52.CanGrow = False
        Me.XrLabel52.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.OT3", "{0:n1}")})
        Me.XrLabel52.Font = New System.Drawing.Font("TH Sarabun New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel52.ForeColor = System.Drawing.Color.Black
        Me.XrLabel52.LocationFloat = New DevExpress.Utils.PointFloat(495.0424!, 2.000003!)
        Me.XrLabel52.Name = "XrLabel52"
        Me.XrLabel52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel52.SizeF = New System.Drawing.SizeF(65.44434!, 16.40273!)
        Me.XrLabel52.StylePriority.UseBackColor = False
        Me.XrLabel52.StylePriority.UseBorderColor = False
        Me.XrLabel52.StylePriority.UseBorders = False
        Me.XrLabel52.StylePriority.UseBorderWidth = False
        Me.XrLabel52.StylePriority.UseFont = False
        Me.XrLabel52.StylePriority.UseForeColor = False
        Me.XrLabel52.StylePriority.UsePadding = False
        Me.XrLabel52.StylePriority.UseTextAlignment = False
        XrSummary15.FormatString = "{0:n2}"
        XrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel52.Summary = XrSummary15
        Me.XrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel51
        '
        Me.XrLabel51.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel51.BorderColor = System.Drawing.Color.Black
        Me.XrLabel51.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel51.BorderWidth = 1.0!
        Me.XrLabel51.CanGrow = False
        Me.XrLabel51.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.OT1", "{0:n1}")})
        Me.XrLabel51.Font = New System.Drawing.Font("TH Sarabun New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel51.ForeColor = System.Drawing.Color.Black
        Me.XrLabel51.LocationFloat = New DevExpress.Utils.PointFloat(420.8477!, 2.000003!)
        Me.XrLabel51.Name = "XrLabel51"
        Me.XrLabel51.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel51.SizeF = New System.Drawing.SizeF(74.19464!, 16.40273!)
        Me.XrLabel51.StylePriority.UseBackColor = False
        Me.XrLabel51.StylePriority.UseBorderColor = False
        Me.XrLabel51.StylePriority.UseBorders = False
        Me.XrLabel51.StylePriority.UseBorderWidth = False
        Me.XrLabel51.StylePriority.UseFont = False
        Me.XrLabel51.StylePriority.UseForeColor = False
        Me.XrLabel51.StylePriority.UsePadding = False
        Me.XrLabel51.StylePriority.UseTextAlignment = False
        XrSummary16.FormatString = "{0:n2}"
        XrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel51.Summary = XrSummary16
        Me.XrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'CalculatedField2
        '
        Me.CalculatedField2.DataMember = "vw_SO_quotation_report"
        Me.CalculatedField2.DisplayName = "FnameLname"
        Me.CalculatedField2.Expression = "[Title]+ ' ' +[Fname] + '     ' + [Lname]"
        Me.CalculatedField2.Name = "CalculatedField2"
        '
        'headname
        '
        Me.headname.Description = "headname"
        Me.headname.Name = "headname"
        Me.headname.ValueInfo = "รายงานเวลาทำงานของพนักงาน(แบบละเอียด)"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pcLogo})
        Me.PageHeader.HeightF = 40.37499!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand1})
        '
        'pcLogo
        '
        Me.pcLogo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.pcLogo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopCenter
        Me.pcLogo.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0!)
        Me.pcLogo.Name = "pcLogo"
        Me.pcLogo.SizeF = New System.Drawing.SizeF(782.2216!, 40.37499!)
        Me.pcLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.pcLogo.StylePriority.UseBorders = False
        '
        'SubBand1
        '
        Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel60})
        Me.SubBand1.HeightF = 53.50003!
        Me.SubBand1.Name = "SubBand1"
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.headDate, "Text", "")})
        Me.XrLabel2.Font = New System.Drawing.Font("TH Sarabun New", 16.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 26.75002!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(782.2215!, 26.75001!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "XrLabel60"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'headDate
        '
        Me.headDate.Description = "headDate"
        Me.headDate.Name = "headDate"
        Me.headDate.ValueInfo = "วันที่ 01/12/2019 - 30/12/2019"
        '
        'XrLabel60
        '
        Me.XrLabel60.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.headname, "Text", "")})
        Me.XrLabel60.Font = New System.Drawing.Font("TH Sarabun New", 16.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel60.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0!)
        Me.XrLabel60.Name = "XrLabel60"
        Me.XrLabel60.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel60.SizeF = New System.Drawing.SizeF(782.2215!, 26.75001!)
        Me.XrLabel60.StylePriority.UseFont = False
        Me.XrLabel60.StylePriority.UseTextAlignment = False
        Me.XrLabel60.Text = "XrLabel60"
        Me.XrLabel60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'companyname
        '
        Me.companyname.Description = "companyname"
        Me.companyname.Name = "companyname"
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel27})
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Department", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.HeightF = 21.95828!
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.Visible = False
        '
        'XrLabel27
        '
        Me.XrLabel27.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel27.BorderColor = System.Drawing.Color.Black
        Me.XrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel27.BorderWidth = 1.0!
        Me.XrLabel27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Department")})
        Me.XrLabel27.Font = New System.Drawing.Font("TH Sarabun New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel27.ForeColor = System.Drawing.Color.Black
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(49.1807!, 0!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(266.1807!, 21.95828!)
        Me.XrLabel27.StylePriority.UseBackColor = False
        Me.XrLabel27.StylePriority.UseBorderColor = False
        Me.XrLabel27.StylePriority.UseBorders = False
        Me.XrLabel27.StylePriority.UseBorderWidth = False
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseForeColor = False
        Me.XrLabel27.StylePriority.UsePadding = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        XrSummary17.FormatString = "{0}"
        XrSummary17.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel27.Summary = XrSummary17
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        'GroupHeader3
        '
        Me.GroupHeader3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel26})
        Me.GroupHeader3.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Division", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader3.HeightF = 21.95828!
        Me.GroupHeader3.Level = 2
        Me.GroupHeader3.Name = "GroupHeader3"
        Me.GroupHeader3.Visible = False
        '
        'XrLabel26
        '
        Me.XrLabel26.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel26.BorderColor = System.Drawing.Color.Black
        Me.XrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel26.BorderWidth = 1.0!
        Me.XrLabel26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Division")})
        Me.XrLabel26.Font = New System.Drawing.Font("TH Sarabun New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel26.ForeColor = System.Drawing.Color.Black
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(49.18069!, 0!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(266.1807!, 21.95828!)
        Me.XrLabel26.StylePriority.UseBackColor = False
        Me.XrLabel26.StylePriority.UseBorderColor = False
        Me.XrLabel26.StylePriority.UseBorders = False
        Me.XrLabel26.StylePriority.UseBorderWidth = False
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.StylePriority.UseForeColor = False
        Me.XrLabel26.StylePriority.UsePadding = False
        Me.XrLabel26.StylePriority.UseTextAlignment = False
        XrSummary18.FormatString = "{0}"
        XrSummary18.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel26.Summary = XrSummary18
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'report_EmpTimeWork_detail_Eng
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMarginBand1, Me.BottomMarginBand1, Me.PageFooter, Me.GroupHeader1, Me.GroupFooter1, Me.PageHeader, Me.GroupHeader2, Me.GroupHeader3})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.CalculatedField1, Me.reportName, Me.CalculatedField2, Me.CalculatedField6, Me.CalculatedField3, Me.CalculatedField4})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "vw_SO_quotation_report"
        Me.DataSource = Me.SqlDataSource1
        Me.FilterString = "[CompanyID] = '01'"
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.hide_disPer, Me.hide_remark, Me.hide_disPer_bill, Me.hide_lastPage, Me.hide_Price, Me.hide_Tax})
        Me.Margins = New System.Drawing.Printing.Margins(29, 21, 20, 23)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.headname, Me.companyname, Me.headDate})
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
    Friend WithEvents XrLine8 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents reportName As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents CalculatedField2 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents headname As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CalculatedField6 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel42 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel47 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel58 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel56 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel55 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel54 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel53 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel52 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel51 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel59 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel60 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CalculatedField3 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel61 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CalculatedField4 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents companyname As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel121 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel119 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents headDate As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SubBand1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents pcLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SubBand2 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader3 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
End Class
