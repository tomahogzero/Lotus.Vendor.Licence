<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class report_EmpTimeWork
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(report_EmpTimeWork))
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.lblTestTimework = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTestLateOut = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTestLate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLine8 = New DevExpress.XtraReports.UI.XRLine()
        Me.reportName = New DevExpress.XtraReports.UI.CalculatedField()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.lbSumTotalTimework = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbSumTotalLateOut = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbSumTotalLate = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbSumLate = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbSumWorkTime = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbSumLateOut = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.CalculatedField2 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.headname = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.pcLogo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.SubBand3 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.head_f_month = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel60 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SubBand2 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLabel125 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel124 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel123 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel122 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.companyname = New DevExpress.XtraReports.Parameters.Parameter()
        Me.CalculatedField6 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalculatedField3 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalculatedField4 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalculatedField5 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.GroupHeader3 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblTestTimework, Me.lblTestLateOut, Me.lblTestLate, Me.XrLabel11, Me.XrLabel8, Me.XrLabel4, Me.XrLabel6, Me.XrLine3, Me.XrLabel25, Me.XrLabel1})
        resources.ApplyResources(Me.Detail, "Detail")
        Me.Detail.KeepTogether = True
        Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("datein", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        '
        'lblTestTimework
        '
        resources.ApplyResources(Me.lblTestTimework, "lblTestTimework")
        Me.lblTestTimework.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblTestTimework.BorderWidth = 1.0!
        Me.lblTestTimework.CanGrow = False
        Me.lblTestTimework.Name = "lblTestTimework"
        Me.lblTestTimework.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTestTimework.StylePriority.UseBackColor = False
        Me.lblTestTimework.StylePriority.UseBorderColor = False
        Me.lblTestTimework.StylePriority.UseBorders = False
        Me.lblTestTimework.StylePriority.UseBorderWidth = False
        Me.lblTestTimework.StylePriority.UseFont = False
        Me.lblTestTimework.StylePriority.UseForeColor = False
        Me.lblTestTimework.StylePriority.UseTextAlignment = False
        '
        'lblTestLateOut
        '
        resources.ApplyResources(Me.lblTestLateOut, "lblTestLateOut")
        Me.lblTestLateOut.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblTestLateOut.BorderWidth = 1.0!
        Me.lblTestLateOut.CanGrow = False
        Me.lblTestLateOut.Name = "lblTestLateOut"
        Me.lblTestLateOut.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTestLateOut.StylePriority.UseBackColor = False
        Me.lblTestLateOut.StylePriority.UseBorderColor = False
        Me.lblTestLateOut.StylePriority.UseBorders = False
        Me.lblTestLateOut.StylePriority.UseBorderWidth = False
        Me.lblTestLateOut.StylePriority.UseFont = False
        Me.lblTestLateOut.StylePriority.UseForeColor = False
        Me.lblTestLateOut.StylePriority.UseTextAlignment = False
        '
        'lblTestLate
        '
        resources.ApplyResources(Me.lblTestLate, "lblTestLate")
        Me.lblTestLate.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblTestLate.BorderWidth = 1.0!
        Me.lblTestLate.CanGrow = False
        Me.lblTestLate.Name = "lblTestLate"
        Me.lblTestLate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTestLate.StylePriority.UseBackColor = False
        Me.lblTestLate.StylePriority.UseBorderColor = False
        Me.lblTestLate.StylePriority.UseBorders = False
        Me.lblTestLate.StylePriority.UseBorderWidth = False
        Me.lblTestLate.StylePriority.UseFont = False
        Me.lblTestLate.StylePriority.UseForeColor = False
        Me.lblTestLate.StylePriority.UseTextAlignment = False
        '
        'XrLabel11
        '
        resources.ApplyResources(Me.XrLabel11, "XrLabel11")
        Me.XrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel11.BorderWidth = 1.0!
        Me.XrLabel11.CanGrow = False
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Time4", "{0:HH:mm}")})
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.StylePriority.UseBackColor = False
        Me.XrLabel11.StylePriority.UseBorderColor = False
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseBorderWidth = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseForeColor = False
        Me.XrLabel11.StylePriority.UsePadding = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        '
        'XrLabel8
        '
        resources.ApplyResources(Me.XrLabel8, "XrLabel8")
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.BorderWidth = 1.0!
        Me.XrLabel8.CanGrow = False
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Time3", "{0:HH:mm}")})
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.StylePriority.UseBackColor = False
        Me.XrLabel8.StylePriority.UseBorderColor = False
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseBorderWidth = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseForeColor = False
        Me.XrLabel8.StylePriority.UsePadding = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        '
        'XrLabel4
        '
        resources.ApplyResources(Me.XrLabel4, "XrLabel4")
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.BorderWidth = 1.0!
        Me.XrLabel4.CanGrow = False
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Time2", "{0:HH:mm}")})
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
        '
        'XrLabel6
        '
        resources.ApplyResources(Me.XrLabel6, "XrLabel6")
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel6.BorderWidth = 1.0!
        Me.XrLabel6.CanGrow = False
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.DayOfWeek", "{0:n2}")})
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.StylePriority.UseBackColor = False
        Me.XrLabel6.StylePriority.UseBorderColor = False
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseBorderWidth = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.StylePriority.UsePadding = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        '
        'XrLine3
        '
        resources.ApplyResources(Me.XrLine3, "XrLine3")
        Me.XrLine3.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.StylePriority.UseForeColor = False
        '
        'XrLabel25
        '
        resources.ApplyResources(Me.XrLabel25, "XrLabel25")
        Me.XrLabel25.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel25.BorderWidth = 1.0!
        Me.XrLabel25.CanGrow = False
        Me.XrLabel25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Time1", "{0:HH:mm}")})
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.StylePriority.UseBackColor = False
        Me.XrLabel25.StylePriority.UseBorderColor = False
        Me.XrLabel25.StylePriority.UseBorders = False
        Me.XrLabel25.StylePriority.UseBorderWidth = False
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseForeColor = False
        Me.XrLabel25.StylePriority.UsePadding = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        '
        'XrLabel1
        '
        resources.ApplyResources(Me.XrLabel1, "XrLabel1")
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.BorderWidth = 1.0!
        Me.XrLabel1.CanGrow = False
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.datein", "{0:dd/MM/yyyy}")})
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
        'CalculatedField1
        '
        Me.CalculatedField1.DataMember = "vw_SO_quotation_report"
        resources.ApplyResources(Me.CalculatedField1, "CalculatedField1")
        Me.CalculatedField1.Expression = "'Remark : ' + [remark_bill]"
        Me.CalculatedField1.Name = "CalculatedField1"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrPageInfo2, Me.XrLine8})
        resources.ApplyResources(Me.PageFooter, "PageFooter")
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo1
        '
        resources.ApplyResources(Me.XrPageInfo1, "XrPageInfo1")
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        '
        'XrPageInfo2
        '
        resources.ApplyResources(Me.XrPageInfo2, "XrPageInfo2")
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.StylePriority.UseFont = False
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        '
        'XrLine8
        '
        resources.ApplyResources(Me.XrLine8, "XrLine8")
        Me.XrLine8.Name = "XrLine8"
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
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine6, Me.XrLabel10, Me.XrLabel5, Me.XrLabel3, Me.XrLabel18})
        resources.ApplyResources(Me.GroupHeader1, "GroupHeader1")
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("code", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLine6
        '
        resources.ApplyResources(Me.XrLine6, "XrLine6")
        Me.XrLine6.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.XrLine6.Name = "XrLine6"
        Me.XrLine6.StylePriority.UseForeColor = False
        '
        'XrLabel10
        '
        resources.ApplyResources(Me.XrLabel10, "XrLabel10")
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel10.BorderWidth = 1.0!
        Me.XrLabel10.CanGrow = False
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.StylePriority.UseBackColor = False
        Me.XrLabel10.StylePriority.UseBorderColor = False
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseBorderWidth = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseForeColor = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        '
        'XrLabel5
        '
        resources.ApplyResources(Me.XrLabel5, "XrLabel5")
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel5.BorderWidth = 1.0!
        Me.XrLabel5.CanGrow = False
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseBorderColor = False
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseBorderWidth = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        '
        'XrLabel3
        '
        resources.ApplyResources(Me.XrLabel3, "XrLabel3")
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.BorderWidth = 1.0!
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.CalculatedField2")})
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseBorderColor = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseBorderWidth = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UsePadding = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary1, "XrSummary1")
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel3.Summary = XrSummary1
        '
        'XrLabel18
        '
        resources.ApplyResources(Me.XrLabel18, "XrLabel18")
        Me.XrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel18.BorderWidth = 1.0!
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Code")})
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.StylePriority.UseBackColor = False
        Me.XrLabel18.StylePriority.UseBorderColor = False
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseBorderWidth = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseForeColor = False
        Me.XrLabel18.StylePriority.UsePadding = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary2, "XrSummary2")
        XrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel18.Summary = XrSummary2
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbSumTotalTimework, Me.lbSumTotalLateOut, Me.lbSumTotalLate, Me.lbSumLate, Me.lbSumWorkTime, Me.lbSumLateOut, Me.XrLine5, Me.XrLine4, Me.XrLabel26})
        resources.ApplyResources(Me.GroupFooter1, "GroupFooter1")
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'lbSumTotalTimework
        '
        resources.ApplyResources(Me.lbSumTotalTimework, "lbSumTotalTimework")
        Me.lbSumTotalTimework.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbSumTotalTimework.BorderWidth = 1.0!
        Me.lbSumTotalTimework.CanGrow = False
        Me.lbSumTotalTimework.Name = "lbSumTotalTimework"
        Me.lbSumTotalTimework.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbSumTotalTimework.StylePriority.UseBackColor = False
        Me.lbSumTotalTimework.StylePriority.UseBorderColor = False
        Me.lbSumTotalTimework.StylePriority.UseBorders = False
        Me.lbSumTotalTimework.StylePriority.UseBorderWidth = False
        Me.lbSumTotalTimework.StylePriority.UseFont = False
        Me.lbSumTotalTimework.StylePriority.UseForeColor = False
        Me.lbSumTotalTimework.StylePriority.UseTextAlignment = False
        '
        'lbSumTotalLateOut
        '
        resources.ApplyResources(Me.lbSumTotalLateOut, "lbSumTotalLateOut")
        Me.lbSumTotalLateOut.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbSumTotalLateOut.BorderWidth = 1.0!
        Me.lbSumTotalLateOut.CanGrow = False
        Me.lbSumTotalLateOut.Name = "lbSumTotalLateOut"
        Me.lbSumTotalLateOut.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbSumTotalLateOut.StylePriority.UseBackColor = False
        Me.lbSumTotalLateOut.StylePriority.UseBorderColor = False
        Me.lbSumTotalLateOut.StylePriority.UseBorders = False
        Me.lbSumTotalLateOut.StylePriority.UseBorderWidth = False
        Me.lbSumTotalLateOut.StylePriority.UseFont = False
        Me.lbSumTotalLateOut.StylePriority.UseForeColor = False
        Me.lbSumTotalLateOut.StylePriority.UseTextAlignment = False
        '
        'lbSumTotalLate
        '
        resources.ApplyResources(Me.lbSumTotalLate, "lbSumTotalLate")
        Me.lbSumTotalLate.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbSumTotalLate.BorderWidth = 1.0!
        Me.lbSumTotalLate.CanGrow = False
        Me.lbSumTotalLate.Name = "lbSumTotalLate"
        Me.lbSumTotalLate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbSumTotalLate.StylePriority.UseBackColor = False
        Me.lbSumTotalLate.StylePriority.UseBorderColor = False
        Me.lbSumTotalLate.StylePriority.UseBorders = False
        Me.lbSumTotalLate.StylePriority.UseBorderWidth = False
        Me.lbSumTotalLate.StylePriority.UseFont = False
        Me.lbSumTotalLate.StylePriority.UseForeColor = False
        Me.lbSumTotalLate.StylePriority.UseTextAlignment = False
        '
        'lbSumLate
        '
        resources.ApplyResources(Me.lbSumLate, "lbSumLate")
        Me.lbSumLate.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbSumLate.BorderWidth = 1.0!
        Me.lbSumLate.CanGrow = False
        Me.lbSumLate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Late")})
        Me.lbSumLate.Name = "lbSumLate"
        Me.lbSumLate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbSumLate.StylePriority.UseBackColor = False
        Me.lbSumLate.StylePriority.UseBorderColor = False
        Me.lbSumLate.StylePriority.UseBorders = False
        Me.lbSumLate.StylePriority.UseBorderWidth = False
        Me.lbSumLate.StylePriority.UseFont = False
        Me.lbSumLate.StylePriority.UseForeColor = False
        Me.lbSumLate.StylePriority.UsePadding = False
        Me.lbSumLate.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary3, "XrSummary3")
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.lbSumLate.Summary = XrSummary3
        '
        'lbSumWorkTime
        '
        resources.ApplyResources(Me.lbSumWorkTime, "lbSumWorkTime")
        Me.lbSumWorkTime.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbSumWorkTime.BorderWidth = 1.0!
        Me.lbSumWorkTime.CanGrow = False
        Me.lbSumWorkTime.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.WorkTime")})
        Me.lbSumWorkTime.Name = "lbSumWorkTime"
        Me.lbSumWorkTime.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbSumWorkTime.StylePriority.UseBackColor = False
        Me.lbSumWorkTime.StylePriority.UseBorderColor = False
        Me.lbSumWorkTime.StylePriority.UseBorders = False
        Me.lbSumWorkTime.StylePriority.UseBorderWidth = False
        Me.lbSumWorkTime.StylePriority.UseFont = False
        Me.lbSumWorkTime.StylePriority.UseForeColor = False
        Me.lbSumWorkTime.StylePriority.UsePadding = False
        Me.lbSumWorkTime.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary4, "XrSummary4")
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.lbSumWorkTime.Summary = XrSummary4
        '
        'lbSumLateOut
        '
        resources.ApplyResources(Me.lbSumLateOut, "lbSumLateOut")
        Me.lbSumLateOut.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbSumLateOut.BorderWidth = 1.0!
        Me.lbSumLateOut.CanGrow = False
        Me.lbSumLateOut.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.LateOT")})
        Me.lbSumLateOut.Name = "lbSumLateOut"
        Me.lbSumLateOut.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbSumLateOut.StylePriority.UseBackColor = False
        Me.lbSumLateOut.StylePriority.UseBorderColor = False
        Me.lbSumLateOut.StylePriority.UseBorders = False
        Me.lbSumLateOut.StylePriority.UseBorderWidth = False
        Me.lbSumLateOut.StylePriority.UseFont = False
        Me.lbSumLateOut.StylePriority.UseForeColor = False
        Me.lbSumLateOut.StylePriority.UsePadding = False
        Me.lbSumLateOut.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary5, "XrSummary5")
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.lbSumLateOut.Summary = XrSummary5
        '
        'XrLine5
        '
        resources.ApplyResources(Me.XrLine5, "XrLine5")
        Me.XrLine5.Name = "XrLine5"
        '
        'XrLine4
        '
        resources.ApplyResources(Me.XrLine4, "XrLine4")
        Me.XrLine4.Name = "XrLine4"
        '
        'XrLabel26
        '
        resources.ApplyResources(Me.XrLabel26, "XrLabel26")
        Me.XrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel26.BorderWidth = 1.0!
        Me.XrLabel26.CanGrow = False
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.StylePriority.UseBackColor = False
        Me.XrLabel26.StylePriority.UseBorderColor = False
        Me.XrLabel26.StylePriority.UseBorders = False
        Me.XrLabel26.StylePriority.UseBorderWidth = False
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.StylePriority.UseForeColor = False
        Me.XrLabel26.StylePriority.UseTextAlignment = False
        '
        'CalculatedField2
        '
        Me.CalculatedField2.DataMember = "vw_SO_quotation_report"
        resources.ApplyResources(Me.CalculatedField2, "CalculatedField2")
        Me.CalculatedField2.Expression = "[Title]+[Fname] + '   ' + [Lname]"
        Me.CalculatedField2.Name = "CalculatedField2"
        '
        'headname
        '
        resources.ApplyResources(Me.headname, "headname")
        Me.headname.Name = "headname"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pcLogo})
        resources.ApplyResources(Me.PageHeader, "PageHeader")
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand3, Me.SubBand2, Me.SubBand1})
        '
        'pcLogo
        '
        Me.pcLogo.Borders = DevExpress.XtraPrinting.BorderSide.None
        resources.ApplyResources(Me.pcLogo, "pcLogo")
        Me.pcLogo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopCenter
        Me.pcLogo.Name = "pcLogo"
        Me.pcLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.pcLogo.StylePriority.UseBorders = False
        '
        'SubBand3
        '
        Me.SubBand3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel60})
        resources.ApplyResources(Me.SubBand3, "SubBand3")
        Me.SubBand3.Name = "SubBand3"
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.head_f_month, "Text", "")})
        resources.ApplyResources(Me.XrLabel2, "XrLabel2")
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        '
        'head_f_month
        '
        resources.ApplyResources(Me.head_f_month, "head_f_month")
        Me.head_f_month.Name = "head_f_month"
        '
        'XrLabel60
        '
        Me.XrLabel60.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.headname, "Text", "")})
        resources.ApplyResources(Me.XrLabel60, "XrLabel60")
        Me.XrLabel60.Name = "XrLabel60"
        Me.XrLabel60.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel60.StylePriority.UseFont = False
        Me.XrLabel60.StylePriority.UseTextAlignment = False
        '
        'SubBand2
        '
        Me.SubBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel125, Me.XrLabel124, Me.XrLabel123, Me.XrLabel122})
        resources.ApplyResources(Me.SubBand2, "SubBand2")
        Me.SubBand2.Name = "SubBand2"
        '
        'XrLabel125
        '
        resources.ApplyResources(Me.XrLabel125, "XrLabel125")
        Me.XrLabel125.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel125.BorderWidth = 1.0!
        Me.XrLabel125.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Department")})
        Me.XrLabel125.Name = "XrLabel125"
        Me.XrLabel125.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel125.StylePriority.UseBackColor = False
        Me.XrLabel125.StylePriority.UseBorderColor = False
        Me.XrLabel125.StylePriority.UseBorders = False
        Me.XrLabel125.StylePriority.UseBorderWidth = False
        Me.XrLabel125.StylePriority.UseFont = False
        Me.XrLabel125.StylePriority.UseForeColor = False
        Me.XrLabel125.StylePriority.UsePadding = False
        Me.XrLabel125.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary6, "XrSummary6")
        XrSummary6.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel125.Summary = XrSummary6
        '
        'XrLabel124
        '
        resources.ApplyResources(Me.XrLabel124, "XrLabel124")
        Me.XrLabel124.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel124.BorderWidth = 1.0!
        Me.XrLabel124.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Division")})
        Me.XrLabel124.Name = "XrLabel124"
        Me.XrLabel124.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel124.StylePriority.UseBackColor = False
        Me.XrLabel124.StylePriority.UseBorderColor = False
        Me.XrLabel124.StylePriority.UseBorders = False
        Me.XrLabel124.StylePriority.UseBorderWidth = False
        Me.XrLabel124.StylePriority.UseFont = False
        Me.XrLabel124.StylePriority.UseForeColor = False
        Me.XrLabel124.StylePriority.UsePadding = False
        Me.XrLabel124.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary7, "XrSummary7")
        XrSummary7.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel124.Summary = XrSummary7
        '
        'XrLabel123
        '
        resources.ApplyResources(Me.XrLabel123, "XrLabel123")
        Me.XrLabel123.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel123.BorderWidth = 1.0!
        Me.XrLabel123.CanGrow = False
        Me.XrLabel123.Name = "XrLabel123"
        Me.XrLabel123.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel123.StylePriority.UseBackColor = False
        Me.XrLabel123.StylePriority.UseBorderColor = False
        Me.XrLabel123.StylePriority.UseBorders = False
        Me.XrLabel123.StylePriority.UseBorderWidth = False
        Me.XrLabel123.StylePriority.UseFont = False
        Me.XrLabel123.StylePriority.UseForeColor = False
        Me.XrLabel123.StylePriority.UseTextAlignment = False
        '
        'XrLabel122
        '
        resources.ApplyResources(Me.XrLabel122, "XrLabel122")
        Me.XrLabel122.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel122.BorderWidth = 1.0!
        Me.XrLabel122.CanGrow = False
        Me.XrLabel122.Name = "XrLabel122"
        Me.XrLabel122.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel122.StylePriority.UseBackColor = False
        Me.XrLabel122.StylePriority.UseBorderColor = False
        Me.XrLabel122.StylePriority.UseBorders = False
        Me.XrLabel122.StylePriority.UseBorderWidth = False
        Me.XrLabel122.StylePriority.UseFont = False
        Me.XrLabel122.StylePriority.UseForeColor = False
        Me.XrLabel122.StylePriority.UseTextAlignment = False
        '
        'SubBand1
        '
        Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrLine1, Me.XrLabel21, Me.XrLabel20, Me.XrLabel19, Me.XrLabel7, Me.XrLabel16, Me.XrLabel15, Me.XrLabel14, Me.XrLabel12, Me.XrLabel9})
        resources.ApplyResources(Me.SubBand1, "SubBand1")
        Me.SubBand1.Name = "SubBand1"
        '
        'XrLine2
        '
        resources.ApplyResources(Me.XrLine2, "XrLine2")
        Me.XrLine2.Name = "XrLine2"
        '
        'XrLine1
        '
        resources.ApplyResources(Me.XrLine1, "XrLine1")
        Me.XrLine1.Name = "XrLine1"
        '
        'XrLabel21
        '
        resources.ApplyResources(Me.XrLabel21, "XrLabel21")
        Me.XrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel21.BorderWidth = 1.0!
        Me.XrLabel21.CanGrow = False
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.StylePriority.UseBackColor = False
        Me.XrLabel21.StylePriority.UseBorderColor = False
        Me.XrLabel21.StylePriority.UseBorders = False
        Me.XrLabel21.StylePriority.UseBorderWidth = False
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseForeColor = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        '
        'XrLabel20
        '
        resources.ApplyResources(Me.XrLabel20, "XrLabel20")
        Me.XrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel20.BorderWidth = 1.0!
        Me.XrLabel20.CanGrow = False
        Me.XrLabel20.Multiline = True
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.StylePriority.UseBackColor = False
        Me.XrLabel20.StylePriority.UseBorderColor = False
        Me.XrLabel20.StylePriority.UseBorders = False
        Me.XrLabel20.StylePriority.UseBorderWidth = False
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseForeColor = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        '
        'XrLabel19
        '
        resources.ApplyResources(Me.XrLabel19, "XrLabel19")
        Me.XrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel19.BorderWidth = 1.0!
        Me.XrLabel19.CanGrow = False
        Me.XrLabel19.Multiline = True
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.StylePriority.UseBackColor = False
        Me.XrLabel19.StylePriority.UseBorderColor = False
        Me.XrLabel19.StylePriority.UseBorders = False
        Me.XrLabel19.StylePriority.UseBorderWidth = False
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseForeColor = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        '
        'XrLabel7
        '
        resources.ApplyResources(Me.XrLabel7, "XrLabel7")
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel7.BorderWidth = 1.0!
        Me.XrLabel7.CanGrow = False
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.StylePriority.UseBackColor = False
        Me.XrLabel7.StylePriority.UseBorderColor = False
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseBorderWidth = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        '
        'XrLabel16
        '
        resources.ApplyResources(Me.XrLabel16, "XrLabel16")
        Me.XrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel16.BorderWidth = 1.0!
        Me.XrLabel16.CanGrow = False
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.StylePriority.UseBackColor = False
        Me.XrLabel16.StylePriority.UseBorderColor = False
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseBorderWidth = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseForeColor = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        '
        'XrLabel15
        '
        resources.ApplyResources(Me.XrLabel15, "XrLabel15")
        Me.XrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel15.BorderWidth = 1.0!
        Me.XrLabel15.CanGrow = False
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.StylePriority.UseBackColor = False
        Me.XrLabel15.StylePriority.UseBorderColor = False
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseBorderWidth = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseForeColor = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        '
        'XrLabel14
        '
        resources.ApplyResources(Me.XrLabel14, "XrLabel14")
        Me.XrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel14.BorderWidth = 1.0!
        Me.XrLabel14.CanGrow = False
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.StylePriority.UseBackColor = False
        Me.XrLabel14.StylePriority.UseBorderColor = False
        Me.XrLabel14.StylePriority.UseBorders = False
        Me.XrLabel14.StylePriority.UseBorderWidth = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseForeColor = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        '
        'XrLabel12
        '
        resources.ApplyResources(Me.XrLabel12, "XrLabel12")
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel12.BorderWidth = 1.0!
        Me.XrLabel12.CanGrow = False
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.StylePriority.UseBackColor = False
        Me.XrLabel12.StylePriority.UseBorderColor = False
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseBorderWidth = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseForeColor = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        '
        'XrLabel9
        '
        resources.ApplyResources(Me.XrLabel9, "XrLabel9")
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel9.BorderWidth = 1.0!
        Me.XrLabel9.CanGrow = False
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.StylePriority.UseBackColor = False
        Me.XrLabel9.StylePriority.UseBorderColor = False
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseBorderWidth = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseForeColor = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        '
        'companyname
        '
        resources.ApplyResources(Me.companyname, "companyname")
        Me.companyname.Name = "companyname"
        '
        'CalculatedField6
        '
        Me.CalculatedField6.DataMember = "vw_SO_quotation_report"
        resources.ApplyResources(Me.CalculatedField6, "CalculatedField6")
        Me.CalculatedField6.Expression = "Sum([DayDo])"
        Me.CalculatedField6.Name = "CalculatedField6"
        '
        'CalculatedField3
        '
        Me.CalculatedField3.DataMember = "vw_SO_quotation_report"
        resources.ApplyResources(Me.CalculatedField3, "CalculatedField3")
        Me.CalculatedField3.Name = "CalculatedField3"
        '
        'CalculatedField4
        '
        Me.CalculatedField4.DataMember = "vw_SO_quotation_report"
        Me.CalculatedField4.Name = "CalculatedField4"
        '
        'CalculatedField5
        '
        Me.CalculatedField5.DataMember = "vw_SO_quotation_report"
        Me.CalculatedField5.Name = "CalculatedField5"
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel13})
        resources.ApplyResources(Me.GroupHeader2, "GroupHeader2")
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Department", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.KeepTogether = True
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'XrLabel13
        '
        resources.ApplyResources(Me.XrLabel13, "XrLabel13")
        Me.XrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel13.BorderWidth = 1.0!
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Department")})
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.StylePriority.UseBackColor = False
        Me.XrLabel13.StylePriority.UseBorderColor = False
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseBorderWidth = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseForeColor = False
        Me.XrLabel13.StylePriority.UsePadding = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary8, "XrSummary8")
        XrSummary8.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel13.Summary = XrSummary8
        '
        'GroupFooter2
        '
        resources.ApplyResources(Me.GroupFooter2, "GroupFooter2")
        Me.GroupFooter2.Level = 1
        Me.GroupFooter2.Name = "GroupFooter2"
        Me.GroupFooter2.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        '
        'GroupHeader3
        '
        Me.GroupHeader3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel17})
        resources.ApplyResources(Me.GroupHeader3, "GroupHeader3")
        Me.GroupHeader3.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Division", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader3.Level = 2
        Me.GroupHeader3.Name = "GroupHeader3"
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Division")})
        resources.ApplyResources(Me.XrLabel17, "XrLabel17")
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'report_EmpTimeWork
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMarginBand1, Me.BottomMarginBand1, Me.PageFooter, Me.GroupHeader1, Me.GroupFooter1, Me.PageHeader, Me.GroupHeader2, Me.GroupFooter2, Me.GroupHeader3})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.CalculatedField1, Me.reportName, Me.CalculatedField2, Me.CalculatedField6, Me.CalculatedField3, Me.CalculatedField4, Me.CalculatedField5})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "vw_SO_quotation_report"
        Me.DataSource = Me.SqlDataSource1
        resources.ApplyResources(Me, "$this")
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.hide_disPer, Me.hide_remark, Me.hide_disPer_bill, Me.hide_lastPage, Me.hide_Price, Me.hide_Tax})
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.headname, Me.companyname, Me.head_f_month})
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
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents CalculatedField2 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents headname As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CalculatedField6 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel60 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CalculatedField3 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalculatedField4 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents companyname As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents head_f_month As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents SubBand1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CalculatedField5 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lbSumLate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbSumWorkTime As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbSumLateOut As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTestTimework As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTestLateOut As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTestLate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SubBand2 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents XrLine6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel125 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel124 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel123 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel122 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents lbSumTotalTimework As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbSumTotalLateOut As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbSumTotalLate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SubBand3 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents pcLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents GroupHeader3 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
End Class
