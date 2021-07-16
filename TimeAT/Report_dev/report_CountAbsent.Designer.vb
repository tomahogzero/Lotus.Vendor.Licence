<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class report_CountAbsent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(report_CountAbsent))
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim StoredProcQuery1 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter3 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim XrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary9 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary10 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary11 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary12 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.lbComePer = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbLatePer = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbVaPer = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbAbsentPer = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbTotalEmp = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbAbsent = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbVa = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbLate = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbCome = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.reportName = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel59 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.CalculatedField2 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.pcLogo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.SubBand3 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.headDate = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.headname = New DevExpress.XtraReports.Parameters.Parameter()
        Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.companyname = New DevExpress.XtraReports.Parameters.Parameter()
        Me.CalculatedField6 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalculatedField3 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalculatedField4 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.lbTotalVacation = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine7 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.lbTotalComePer = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbTotalLatePer = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbTotalVaPer = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbTotalAbsPer = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTotalEmp = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbTotalAbsent = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbTotalLate = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbTotalCome = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SubBand2 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paradate = New DevExpress.XtraReports.Parameters.Parameter()
        Me.type_use = New DevExpress.XtraReports.Parameters.Parameter()
        Me.CalculatedField5 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.computername = New DevExpress.XtraReports.Parameters.Parameter()
        Me.CalculatedField7 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrCrossBandLine1 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine2 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine3 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine4 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine5 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine6 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine7 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine8 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine9 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine10 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandBox1 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbComePer, Me.lbLatePer, Me.lbVaPer, Me.lbAbsentPer, Me.lbTotalEmp, Me.XrLine6, Me.XrLabel14, Me.lbAbsent, Me.lbVa, Me.lbLate, Me.lbCome, Me.XrLabel1})
        resources.ApplyResources(Me.Detail, "Detail")
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("division", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("department", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        '
        'lbComePer
        '
        resources.ApplyResources(Me.lbComePer, "lbComePer")
        Me.lbComePer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbComePer.BorderWidth = 1.0!
        Me.lbComePer.CanGrow = False
        Me.lbComePer.Name = "lbComePer"
        Me.lbComePer.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbComePer.StylePriority.UseBackColor = False
        Me.lbComePer.StylePriority.UseBorderColor = False
        Me.lbComePer.StylePriority.UseBorders = False
        Me.lbComePer.StylePriority.UseBorderWidth = False
        Me.lbComePer.StylePriority.UseFont = False
        Me.lbComePer.StylePriority.UseForeColor = False
        Me.lbComePer.StylePriority.UsePadding = False
        Me.lbComePer.StylePriority.UseTextAlignment = False
        '
        'lbLatePer
        '
        resources.ApplyResources(Me.lbLatePer, "lbLatePer")
        Me.lbLatePer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbLatePer.BorderWidth = 1.0!
        Me.lbLatePer.CanGrow = False
        Me.lbLatePer.Name = "lbLatePer"
        Me.lbLatePer.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbLatePer.StylePriority.UseBackColor = False
        Me.lbLatePer.StylePriority.UseBorderColor = False
        Me.lbLatePer.StylePriority.UseBorders = False
        Me.lbLatePer.StylePriority.UseBorderWidth = False
        Me.lbLatePer.StylePriority.UseFont = False
        Me.lbLatePer.StylePriority.UseForeColor = False
        Me.lbLatePer.StylePriority.UsePadding = False
        Me.lbLatePer.StylePriority.UseTextAlignment = False
        '
        'lbVaPer
        '
        resources.ApplyResources(Me.lbVaPer, "lbVaPer")
        Me.lbVaPer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbVaPer.BorderWidth = 1.0!
        Me.lbVaPer.CanGrow = False
        Me.lbVaPer.Name = "lbVaPer"
        Me.lbVaPer.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbVaPer.StylePriority.UseBackColor = False
        Me.lbVaPer.StylePriority.UseBorderColor = False
        Me.lbVaPer.StylePriority.UseBorders = False
        Me.lbVaPer.StylePriority.UseBorderWidth = False
        Me.lbVaPer.StylePriority.UseFont = False
        Me.lbVaPer.StylePriority.UseForeColor = False
        Me.lbVaPer.StylePriority.UsePadding = False
        Me.lbVaPer.StylePriority.UseTextAlignment = False
        '
        'lbAbsentPer
        '
        resources.ApplyResources(Me.lbAbsentPer, "lbAbsentPer")
        Me.lbAbsentPer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbAbsentPer.BorderWidth = 1.0!
        Me.lbAbsentPer.CanGrow = False
        Me.lbAbsentPer.Name = "lbAbsentPer"
        Me.lbAbsentPer.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbAbsentPer.StylePriority.UseBackColor = False
        Me.lbAbsentPer.StylePriority.UseBorderColor = False
        Me.lbAbsentPer.StylePriority.UseBorders = False
        Me.lbAbsentPer.StylePriority.UseBorderWidth = False
        Me.lbAbsentPer.StylePriority.UseFont = False
        Me.lbAbsentPer.StylePriority.UseForeColor = False
        Me.lbAbsentPer.StylePriority.UsePadding = False
        Me.lbAbsentPer.StylePriority.UseTextAlignment = False
        '
        'lbTotalEmp
        '
        resources.ApplyResources(Me.lbTotalEmp, "lbTotalEmp")
        Me.lbTotalEmp.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbTotalEmp.BorderWidth = 1.0!
        Me.lbTotalEmp.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.totalEmp")})
        Me.lbTotalEmp.Name = "lbTotalEmp"
        Me.lbTotalEmp.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbTotalEmp.StylePriority.UseBackColor = False
        Me.lbTotalEmp.StylePriority.UseBorderColor = False
        Me.lbTotalEmp.StylePriority.UseBorders = False
        Me.lbTotalEmp.StylePriority.UseBorderWidth = False
        Me.lbTotalEmp.StylePriority.UseFont = False
        Me.lbTotalEmp.StylePriority.UseForeColor = False
        Me.lbTotalEmp.StylePriority.UsePadding = False
        Me.lbTotalEmp.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary1, "XrSummary1")
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.lbTotalEmp.Summary = XrSummary1
        '
        'XrLine6
        '
        resources.ApplyResources(Me.XrLine6, "XrLine6")
        Me.XrLine6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLine6.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.XrLine6.Name = "XrLine6"
        Me.XrLine6.StylePriority.UseBorderColor = False
        Me.XrLine6.StylePriority.UseBorderDashStyle = False
        Me.XrLine6.StylePriority.UseForeColor = False
        '
        'XrLabel14
        '
        resources.ApplyResources(Me.XrLabel14, "XrLabel14")
        Me.XrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel14.BorderWidth = 1.0!
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.division")})
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.StylePriority.UseBackColor = False
        Me.XrLabel14.StylePriority.UseBorderColor = False
        Me.XrLabel14.StylePriority.UseBorders = False
        Me.XrLabel14.StylePriority.UseBorderWidth = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseForeColor = False
        Me.XrLabel14.StylePriority.UsePadding = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary2, "XrSummary2")
        XrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel14.Summary = XrSummary2
        '
        'lbAbsent
        '
        resources.ApplyResources(Me.lbAbsent, "lbAbsent")
        Me.lbAbsent.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbAbsent.BorderWidth = 1.0!
        Me.lbAbsent.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.TimeAbsent")})
        Me.lbAbsent.Name = "lbAbsent"
        Me.lbAbsent.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbAbsent.StylePriority.UseBackColor = False
        Me.lbAbsent.StylePriority.UseBorderColor = False
        Me.lbAbsent.StylePriority.UseBorders = False
        Me.lbAbsent.StylePriority.UseBorderWidth = False
        Me.lbAbsent.StylePriority.UseFont = False
        Me.lbAbsent.StylePriority.UseForeColor = False
        Me.lbAbsent.StylePriority.UsePadding = False
        Me.lbAbsent.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary3, "XrSummary3")
        XrSummary3.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.lbAbsent.Summary = XrSummary3
        '
        'lbVa
        '
        resources.ApplyResources(Me.lbVa, "lbVa")
        Me.lbVa.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbVa.BorderWidth = 1.0!
        Me.lbVa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Vacation")})
        Me.lbVa.Name = "lbVa"
        Me.lbVa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbVa.StylePriority.UseBackColor = False
        Me.lbVa.StylePriority.UseBorderColor = False
        Me.lbVa.StylePriority.UseBorders = False
        Me.lbVa.StylePriority.UseBorderWidth = False
        Me.lbVa.StylePriority.UseFont = False
        Me.lbVa.StylePriority.UseForeColor = False
        Me.lbVa.StylePriority.UsePadding = False
        Me.lbVa.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary4, "XrSummary4")
        XrSummary4.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.lbVa.Summary = XrSummary4
        '
        'lbLate
        '
        resources.ApplyResources(Me.lbLate, "lbLate")
        Me.lbLate.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbLate.BorderWidth = 1.0!
        Me.lbLate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.TimeLate")})
        Me.lbLate.Name = "lbLate"
        Me.lbLate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbLate.StylePriority.UseBackColor = False
        Me.lbLate.StylePriority.UseBorderColor = False
        Me.lbLate.StylePriority.UseBorders = False
        Me.lbLate.StylePriority.UseBorderWidth = False
        Me.lbLate.StylePriority.UseFont = False
        Me.lbLate.StylePriority.UseForeColor = False
        Me.lbLate.StylePriority.UsePadding = False
        Me.lbLate.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary5, "XrSummary5")
        XrSummary5.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.lbLate.Summary = XrSummary5
        '
        'lbCome
        '
        resources.ApplyResources(Me.lbCome, "lbCome")
        Me.lbCome.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbCome.BorderWidth = 1.0!
        Me.lbCome.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Come")})
        Me.lbCome.Name = "lbCome"
        Me.lbCome.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbCome.StylePriority.UseBackColor = False
        Me.lbCome.StylePriority.UseBorderColor = False
        Me.lbCome.StylePriority.UseBorders = False
        Me.lbCome.StylePriority.UseBorderWidth = False
        Me.lbCome.StylePriority.UseFont = False
        Me.lbCome.StylePriority.UseForeColor = False
        Me.lbCome.StylePriority.UsePadding = False
        Me.lbCome.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary6, "XrSummary6")
        XrSummary6.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.lbCome.Summary = XrSummary6
        '
        'XrLabel1
        '
        resources.ApplyResources(Me.XrLabel1, "XrLabel1")
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.BorderWidth = 1.0!
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.department")})
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
        resources.ApplyResources(XrSummary7, "XrSummary7")
        XrSummary7.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        Me.XrLabel1.Summary = XrSummary7
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
        StoredProcQuery1.Name = "vw_SO_quotation_report"
        QueryParameter1.Name = "@DateIn"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.paradate]", GetType(String))
        QueryParameter2.Name = "@Type"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.type_use]", GetType(String))
        QueryParameter3.Name = "@ComName"
        QueryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter3.Value = New DevExpress.DataAccess.Expression("[Parameters.computername]", GetType(String))
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.Parameters.Add(QueryParameter2)
        StoredProcQuery1.Parameters.Add(QueryParameter3)
        StoredProcQuery1.StoredProcName = "spRPT_TimeAbslateValCountDialy"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3})
        Me.XrTableRow1.Name = "XrTableRow1"
        resources.ApplyResources(Me.XrTableRow1, "XrTableRow1")
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        resources.ApplyResources(Me.XrTableCell1, "XrTableCell1")
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Name = "XrTableCell2"
        resources.ApplyResources(Me.XrTableCell2, "XrTableCell2")
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Name = "XrTableCell3"
        resources.ApplyResources(Me.XrTableCell3, "XrTableCell3")
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6})
        Me.XrTableRow2.Name = "XrTableRow2"
        resources.ApplyResources(Me.XrTableRow2, "XrTableRow2")
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Name = "XrTableCell4"
        resources.ApplyResources(Me.XrTableCell4, "XrTableCell4")
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Name = "XrTableCell5"
        resources.ApplyResources(Me.XrTableCell5, "XrTableCell5")
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Name = "XrTableCell6"
        resources.ApplyResources(Me.XrTableCell6, "XrTableCell6")
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
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2, Me.XrPageInfo1, Me.XrLine2})
        resources.ApplyResources(Me.PageFooter, "PageFooter")
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo2
        '
        resources.ApplyResources(Me.XrPageInfo2, "XrPageInfo2")
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.StylePriority.UseFont = False
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
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
        'XrLine2
        '
        resources.ApplyResources(Me.XrLine2, "XrLine2")
        Me.XrLine2.Name = "XrLine2"
        '
        'reportName
        '
        Me.reportName.DataMember = "vw_SO_quotation_report"
        Me.reportName.Expression = "'รายงานสรุปใบรับซื้อสินค้า ตามลูกค้า,ใบเสร็จ' + iif([Parameters.topRow] > 0,' (To" &
    "p ' + [Parameters.topRow] + ')','')"
        Me.reportName.Name = "reportName"
        '
        'XrLabel23
        '
        resources.ApplyResources(Me.XrLabel23, "XrLabel23")
        Me.XrLabel23.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel23.BorderWidth = 1.0!
        Me.XrLabel23.CanGrow = False
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.StylePriority.UseBackColor = False
        Me.XrLabel23.StylePriority.UseBorderColor = False
        Me.XrLabel23.StylePriority.UseBorders = False
        Me.XrLabel23.StylePriority.UseBorderWidth = False
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseForeColor = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
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
        'XrLabel59
        '
        resources.ApplyResources(Me.XrLabel59, "XrLabel59")
        Me.XrLabel59.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel59.BorderWidth = 1.0!
        Me.XrLabel59.CanGrow = False
        Me.XrLabel59.Name = "XrLabel59"
        Me.XrLabel59.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel59.StylePriority.UseBackColor = False
        Me.XrLabel59.StylePriority.UseBorderColor = False
        Me.XrLabel59.StylePriority.UseBorders = False
        Me.XrLabel59.StylePriority.UseBorderWidth = False
        Me.XrLabel59.StylePriority.UseFont = False
        Me.XrLabel59.StylePriority.UseForeColor = False
        Me.XrLabel59.StylePriority.UseTextAlignment = False
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
        'CalculatedField2
        '
        Me.CalculatedField2.DataMember = "vw_SO_quotation_report"
        resources.ApplyResources(Me.CalculatedField2, "CalculatedField2")
        Me.CalculatedField2.Expression = "[Fname] + '     ' + [Lname]"
        Me.CalculatedField2.Name = "CalculatedField2"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pcLogo})
        resources.ApplyResources(Me.PageHeader, "PageHeader")
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand3, Me.SubBand1})
        '
        'pcLogo
        '
        Me.pcLogo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.pcLogo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopCenter
        resources.ApplyResources(Me.pcLogo, "pcLogo")
        Me.pcLogo.Name = "pcLogo"
        Me.pcLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.pcLogo.StylePriority.UseBorders = False
        '
        'SubBand3
        '
        Me.SubBand3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel19, Me.XrLabel2})
        resources.ApplyResources(Me.SubBand3, "SubBand3")
        Me.SubBand3.Name = "SubBand3"
        '
        'XrLabel19
        '
        Me.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.headDate, "Text", "")})
        resources.ApplyResources(Me.XrLabel19, "XrLabel19")
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        '
        'headDate
        '
        resources.ApplyResources(Me.headDate, "headDate")
        Me.headDate.Name = "headDate"
        Me.headDate.ValueInfo = "ประจำวันที่ : "
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.headname, "Text", "")})
        resources.ApplyResources(Me.XrLabel2, "XrLabel2")
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        '
        'headname
        '
        resources.ApplyResources(Me.headname, "headname")
        Me.headname.Name = "headname"
        '
        'SubBand1
        '
        Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel22, Me.XrLabel16, Me.XrLabel17, Me.XrLabel12, Me.XrLabel15, Me.XrLabel9, Me.XrLabel11, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6, Me.XrLine1, Me.XrLine3, Me.XrLabel23, Me.XrLabel21, Me.XrLabel20, Me.XrLabel5, Me.XrLabel10, Me.XrLabel59})
        resources.ApplyResources(Me.SubBand1, "SubBand1")
        Me.SubBand1.Name = "SubBand1"
        '
        'XrLabel22
        '
        resources.ApplyResources(Me.XrLabel22, "XrLabel22")
        Me.XrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel22.BorderWidth = 1.0!
        Me.XrLabel22.CanGrow = False
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.StylePriority.UseBackColor = False
        Me.XrLabel22.StylePriority.UseBorderColor = False
        Me.XrLabel22.StylePriority.UseBorders = False
        Me.XrLabel22.StylePriority.UseBorderWidth = False
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseForeColor = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
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
        'XrLabel17
        '
        resources.ApplyResources(Me.XrLabel17, "XrLabel17")
        Me.XrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel17.BorderWidth = 1.0!
        Me.XrLabel17.CanGrow = False
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.StylePriority.UseBackColor = False
        Me.XrLabel17.StylePriority.UseBorderColor = False
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseBorderWidth = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseForeColor = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
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
        'XrLabel11
        '
        resources.ApplyResources(Me.XrLabel11, "XrLabel11")
        Me.XrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel11.BorderWidth = 1.0!
        Me.XrLabel11.CanGrow = False
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.StylePriority.UseBackColor = False
        Me.XrLabel11.StylePriority.UseBorderColor = False
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseBorderWidth = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseForeColor = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        '
        'XrLabel8
        '
        resources.ApplyResources(Me.XrLabel8, "XrLabel8")
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.BorderWidth = 1.0!
        Me.XrLabel8.CanGrow = False
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.StylePriority.UseBackColor = False
        Me.XrLabel8.StylePriority.UseBorderColor = False
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseBorderWidth = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseForeColor = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        '
        'XrLabel7
        '
        resources.ApplyResources(Me.XrLabel7, "XrLabel7")
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel7.BorderWidth = 1.0!
        Me.XrLabel7.CanGrow = False
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
        'XrLabel6
        '
        resources.ApplyResources(Me.XrLabel6, "XrLabel6")
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel6.BorderWidth = 1.0!
        Me.XrLabel6.CanGrow = False
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.StylePriority.UseBackColor = False
        Me.XrLabel6.StylePriority.UseBorderColor = False
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseBorderWidth = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        '
        'XrLine1
        '
        resources.ApplyResources(Me.XrLine1, "XrLine1")
        Me.XrLine1.Name = "XrLine1"
        '
        'XrLine3
        '
        resources.ApplyResources(Me.XrLine3, "XrLine3")
        Me.XrLine3.Name = "XrLine3"
        '
        'companyname
        '
        resources.ApplyResources(Me.companyname, "companyname")
        Me.companyname.Name = "companyname"
        Me.companyname.ValueInfo = "บรัษัท"
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
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbTotalVacation, Me.XrLine7, Me.XrLine4, Me.lbTotalComePer, Me.lbTotalLatePer, Me.lbTotalVaPer, Me.lbTotalAbsPer, Me.lblTotalEmp, Me.lbTotalAbsent, Me.lbTotalLate, Me.lbTotalCome, Me.XrLabel3})
        resources.ApplyResources(Me.ReportFooter, "ReportFooter")
        Me.ReportFooter.Name = "ReportFooter"
        Me.ReportFooter.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand2})
        '
        'lbTotalVacation
        '
        resources.ApplyResources(Me.lbTotalVacation, "lbTotalVacation")
        Me.lbTotalVacation.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbTotalVacation.BorderWidth = 1.0!
        Me.lbTotalVacation.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Vacation")})
        Me.lbTotalVacation.Name = "lbTotalVacation"
        Me.lbTotalVacation.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbTotalVacation.StylePriority.UseBackColor = False
        Me.lbTotalVacation.StylePriority.UseBorderColor = False
        Me.lbTotalVacation.StylePriority.UseBorders = False
        Me.lbTotalVacation.StylePriority.UseBorderWidth = False
        Me.lbTotalVacation.StylePriority.UseFont = False
        Me.lbTotalVacation.StylePriority.UseForeColor = False
        Me.lbTotalVacation.StylePriority.UsePadding = False
        Me.lbTotalVacation.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary8, "XrSummary8")
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.lbTotalVacation.Summary = XrSummary8
        '
        'XrLine7
        '
        resources.ApplyResources(Me.XrLine7, "XrLine7")
        Me.XrLine7.Name = "XrLine7"
        '
        'XrLine4
        '
        Me.XrLine4.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        resources.ApplyResources(Me.XrLine4, "XrLine4")
        Me.XrLine4.Name = "XrLine4"
        '
        'lbTotalComePer
        '
        resources.ApplyResources(Me.lbTotalComePer, "lbTotalComePer")
        Me.lbTotalComePer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbTotalComePer.BorderWidth = 1.0!
        Me.lbTotalComePer.CanGrow = False
        Me.lbTotalComePer.Name = "lbTotalComePer"
        Me.lbTotalComePer.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbTotalComePer.StylePriority.UseBackColor = False
        Me.lbTotalComePer.StylePriority.UseBorderColor = False
        Me.lbTotalComePer.StylePriority.UseBorders = False
        Me.lbTotalComePer.StylePriority.UseBorderWidth = False
        Me.lbTotalComePer.StylePriority.UseFont = False
        Me.lbTotalComePer.StylePriority.UseForeColor = False
        Me.lbTotalComePer.StylePriority.UsePadding = False
        Me.lbTotalComePer.StylePriority.UseTextAlignment = False
        '
        'lbTotalLatePer
        '
        resources.ApplyResources(Me.lbTotalLatePer, "lbTotalLatePer")
        Me.lbTotalLatePer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbTotalLatePer.BorderWidth = 1.0!
        Me.lbTotalLatePer.CanGrow = False
        Me.lbTotalLatePer.Name = "lbTotalLatePer"
        Me.lbTotalLatePer.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbTotalLatePer.StylePriority.UseBackColor = False
        Me.lbTotalLatePer.StylePriority.UseBorderColor = False
        Me.lbTotalLatePer.StylePriority.UseBorders = False
        Me.lbTotalLatePer.StylePriority.UseBorderWidth = False
        Me.lbTotalLatePer.StylePriority.UseFont = False
        Me.lbTotalLatePer.StylePriority.UseForeColor = False
        Me.lbTotalLatePer.StylePriority.UsePadding = False
        Me.lbTotalLatePer.StylePriority.UseTextAlignment = False
        '
        'lbTotalVaPer
        '
        resources.ApplyResources(Me.lbTotalVaPer, "lbTotalVaPer")
        Me.lbTotalVaPer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbTotalVaPer.BorderWidth = 1.0!
        Me.lbTotalVaPer.CanGrow = False
        Me.lbTotalVaPer.Name = "lbTotalVaPer"
        Me.lbTotalVaPer.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbTotalVaPer.StylePriority.UseBackColor = False
        Me.lbTotalVaPer.StylePriority.UseBorderColor = False
        Me.lbTotalVaPer.StylePriority.UseBorders = False
        Me.lbTotalVaPer.StylePriority.UseBorderWidth = False
        Me.lbTotalVaPer.StylePriority.UseFont = False
        Me.lbTotalVaPer.StylePriority.UseForeColor = False
        Me.lbTotalVaPer.StylePriority.UsePadding = False
        Me.lbTotalVaPer.StylePriority.UseTextAlignment = False
        '
        'lbTotalAbsPer
        '
        resources.ApplyResources(Me.lbTotalAbsPer, "lbTotalAbsPer")
        Me.lbTotalAbsPer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbTotalAbsPer.BorderWidth = 1.0!
        Me.lbTotalAbsPer.CanGrow = False
        Me.lbTotalAbsPer.Name = "lbTotalAbsPer"
        Me.lbTotalAbsPer.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbTotalAbsPer.StylePriority.UseBackColor = False
        Me.lbTotalAbsPer.StylePriority.UseBorderColor = False
        Me.lbTotalAbsPer.StylePriority.UseBorders = False
        Me.lbTotalAbsPer.StylePriority.UseBorderWidth = False
        Me.lbTotalAbsPer.StylePriority.UseFont = False
        Me.lbTotalAbsPer.StylePriority.UseForeColor = False
        Me.lbTotalAbsPer.StylePriority.UsePadding = False
        Me.lbTotalAbsPer.StylePriority.UseTextAlignment = False
        '
        'lblTotalEmp
        '
        resources.ApplyResources(Me.lblTotalEmp, "lblTotalEmp")
        Me.lblTotalEmp.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblTotalEmp.BorderWidth = 1.0!
        Me.lblTotalEmp.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.totalEmp")})
        Me.lblTotalEmp.Name = "lblTotalEmp"
        Me.lblTotalEmp.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTotalEmp.StylePriority.UseBackColor = False
        Me.lblTotalEmp.StylePriority.UseBorderColor = False
        Me.lblTotalEmp.StylePriority.UseBorders = False
        Me.lblTotalEmp.StylePriority.UseBorderWidth = False
        Me.lblTotalEmp.StylePriority.UseFont = False
        Me.lblTotalEmp.StylePriority.UseForeColor = False
        Me.lblTotalEmp.StylePriority.UsePadding = False
        Me.lblTotalEmp.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary9, "XrSummary9")
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.lblTotalEmp.Summary = XrSummary9
        '
        'lbTotalAbsent
        '
        resources.ApplyResources(Me.lbTotalAbsent, "lbTotalAbsent")
        Me.lbTotalAbsent.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbTotalAbsent.BorderWidth = 1.0!
        Me.lbTotalAbsent.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.TimeAbsent")})
        Me.lbTotalAbsent.Name = "lbTotalAbsent"
        Me.lbTotalAbsent.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbTotalAbsent.StylePriority.UseBackColor = False
        Me.lbTotalAbsent.StylePriority.UseBorderColor = False
        Me.lbTotalAbsent.StylePriority.UseBorders = False
        Me.lbTotalAbsent.StylePriority.UseBorderWidth = False
        Me.lbTotalAbsent.StylePriority.UseFont = False
        Me.lbTotalAbsent.StylePriority.UseForeColor = False
        Me.lbTotalAbsent.StylePriority.UsePadding = False
        Me.lbTotalAbsent.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary10, "XrSummary10")
        XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.lbTotalAbsent.Summary = XrSummary10
        '
        'lbTotalLate
        '
        resources.ApplyResources(Me.lbTotalLate, "lbTotalLate")
        Me.lbTotalLate.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbTotalLate.BorderWidth = 1.0!
        Me.lbTotalLate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.TimeLate")})
        Me.lbTotalLate.Name = "lbTotalLate"
        Me.lbTotalLate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbTotalLate.StylePriority.UseBackColor = False
        Me.lbTotalLate.StylePriority.UseBorderColor = False
        Me.lbTotalLate.StylePriority.UseBorders = False
        Me.lbTotalLate.StylePriority.UseBorderWidth = False
        Me.lbTotalLate.StylePriority.UseFont = False
        Me.lbTotalLate.StylePriority.UseForeColor = False
        Me.lbTotalLate.StylePriority.UsePadding = False
        Me.lbTotalLate.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary11, "XrSummary11")
        XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.lbTotalLate.Summary = XrSummary11
        '
        'lbTotalCome
        '
        resources.ApplyResources(Me.lbTotalCome, "lbTotalCome")
        Me.lbTotalCome.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lbTotalCome.BorderWidth = 1.0!
        Me.lbTotalCome.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_SO_quotation_report.Come")})
        Me.lbTotalCome.Name = "lbTotalCome"
        Me.lbTotalCome.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbTotalCome.StylePriority.UseBackColor = False
        Me.lbTotalCome.StylePriority.UseBorderColor = False
        Me.lbTotalCome.StylePriority.UseBorders = False
        Me.lbTotalCome.StylePriority.UseBorderWidth = False
        Me.lbTotalCome.StylePriority.UseFont = False
        Me.lbTotalCome.StylePriority.UseForeColor = False
        Me.lbTotalCome.StylePriority.UsePadding = False
        Me.lbTotalCome.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary12, "XrSummary12")
        XrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.lbTotalCome.Summary = XrSummary12
        '
        'XrLabel3
        '
        resources.ApplyResources(Me.XrLabel3, "XrLabel3")
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.BorderWidth = 1.0!
        Me.XrLabel3.CanGrow = False
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseBorderColor = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseBorderWidth = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        '
        'SubBand2
        '
        Me.SubBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.XrLine5, Me.XrLabel13})
        resources.ApplyResources(Me.SubBand2, "SubBand2")
        Me.SubBand2.Name = "SubBand2"
        '
        'XrLabel4
        '
        resources.ApplyResources(Me.XrLabel4, "XrLabel4")
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.BorderWidth = 1.0!
        Me.XrLabel4.CanGrow = False
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseBorderColor = False
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseBorderWidth = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        '
        'XrLine5
        '
        Me.XrLine5.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        resources.ApplyResources(Me.XrLine5, "XrLine5")
        Me.XrLine5.Name = "XrLine5"
        '
        'XrLabel13
        '
        resources.ApplyResources(Me.XrLabel13, "XrLabel13")
        Me.XrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel13.BorderWidth = 1.0!
        Me.XrLabel13.CanGrow = False
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.StylePriority.UseBackColor = False
        Me.XrLabel13.StylePriority.UseBorderColor = False
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseBorderWidth = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseForeColor = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        '
        'paradate
        '
        resources.ApplyResources(Me.paradate, "paradate")
        Me.paradate.Name = "paradate"
        '
        'type_use
        '
        resources.ApplyResources(Me.type_use, "type_use")
        Me.type_use.Name = "type_use"
        '
        'CalculatedField5
        '
        Me.CalculatedField5.DataMember = "vw_SO_quotation_report"
        resources.ApplyResources(Me.CalculatedField5, "CalculatedField5")
        Me.CalculatedField5.Expression = "[Parameters.headname] + '  ' + [Parameters.cCheckDate]"
        Me.CalculatedField5.Name = "CalculatedField5"
        '
        'computername
        '
        resources.ApplyResources(Me.computername, "computername")
        Me.computername.Name = "computername"
        '
        'CalculatedField7
        '
        Me.CalculatedField7.DataMember = "vw_SO_quotation_report"
        resources.ApplyResources(Me.CalculatedField7, "CalculatedField7")
        Me.CalculatedField7.Expression = "[Vacation]+[TimeAbsent]+[TimeLate]"
        Me.CalculatedField7.Name = "CalculatedField7"
        '
        'XrCrossBandLine1
        '
        Me.XrCrossBandLine1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.XrCrossBandLine1.EndBand = Me.ReportFooter
        resources.ApplyResources(Me.XrCrossBandLine1, "XrCrossBandLine1")
        Me.XrCrossBandLine1.Name = "XrCrossBandLine1"
        Me.XrCrossBandLine1.StartBand = Me.SubBand1
        Me.XrCrossBandLine1.WidthF = 1.0!
        '
        'XrCrossBandLine2
        '
        Me.XrCrossBandLine2.EndBand = Me.ReportFooter
        resources.ApplyResources(Me.XrCrossBandLine2, "XrCrossBandLine2")
        Me.XrCrossBandLine2.Name = "XrCrossBandLine2"
        Me.XrCrossBandLine2.StartBand = Me.SubBand1
        Me.XrCrossBandLine2.WidthF = 1.0!
        '
        'XrCrossBandLine3
        '
        Me.XrCrossBandLine3.EndBand = Me.ReportFooter
        resources.ApplyResources(Me.XrCrossBandLine3, "XrCrossBandLine3")
        Me.XrCrossBandLine3.Name = "XrCrossBandLine3"
        Me.XrCrossBandLine3.StartBand = Me.SubBand1
        Me.XrCrossBandLine3.WidthF = 1.0!
        '
        'XrCrossBandLine4
        '
        Me.XrCrossBandLine4.EndBand = Me.ReportFooter
        resources.ApplyResources(Me.XrCrossBandLine4, "XrCrossBandLine4")
        Me.XrCrossBandLine4.Name = "XrCrossBandLine4"
        Me.XrCrossBandLine4.StartBand = Me.SubBand1
        Me.XrCrossBandLine4.WidthF = 1.0!
        '
        'XrCrossBandLine5
        '
        Me.XrCrossBandLine5.EndBand = Me.ReportFooter
        resources.ApplyResources(Me.XrCrossBandLine5, "XrCrossBandLine5")
        Me.XrCrossBandLine5.Name = "XrCrossBandLine5"
        Me.XrCrossBandLine5.StartBand = Me.SubBand1
        Me.XrCrossBandLine5.WidthF = 1.0!
        '
        'XrCrossBandLine6
        '
        Me.XrCrossBandLine6.EndBand = Me.ReportFooter
        resources.ApplyResources(Me.XrCrossBandLine6, "XrCrossBandLine6")
        Me.XrCrossBandLine6.Name = "XrCrossBandLine6"
        Me.XrCrossBandLine6.StartBand = Me.SubBand1
        Me.XrCrossBandLine6.WidthF = 1.0!
        '
        'XrCrossBandLine7
        '
        Me.XrCrossBandLine7.EndBand = Me.ReportFooter
        resources.ApplyResources(Me.XrCrossBandLine7, "XrCrossBandLine7")
        Me.XrCrossBandLine7.Name = "XrCrossBandLine7"
        Me.XrCrossBandLine7.StartBand = Me.SubBand1
        Me.XrCrossBandLine7.WidthF = 1.0!
        '
        'XrCrossBandLine8
        '
        Me.XrCrossBandLine8.EndBand = Me.ReportFooter
        resources.ApplyResources(Me.XrCrossBandLine8, "XrCrossBandLine8")
        Me.XrCrossBandLine8.Name = "XrCrossBandLine8"
        Me.XrCrossBandLine8.StartBand = Me.SubBand1
        Me.XrCrossBandLine8.WidthF = 1.0!
        '
        'XrCrossBandLine9
        '
        Me.XrCrossBandLine9.EndBand = Me.ReportFooter
        resources.ApplyResources(Me.XrCrossBandLine9, "XrCrossBandLine9")
        Me.XrCrossBandLine9.Name = "XrCrossBandLine9"
        Me.XrCrossBandLine9.StartBand = Me.SubBand1
        Me.XrCrossBandLine9.WidthF = 1.0!
        '
        'XrCrossBandLine10
        '
        Me.XrCrossBandLine10.EndBand = Me.ReportFooter
        resources.ApplyResources(Me.XrCrossBandLine10, "XrCrossBandLine10")
        Me.XrCrossBandLine10.Name = "XrCrossBandLine10"
        Me.XrCrossBandLine10.StartBand = Me.SubBand1
        Me.XrCrossBandLine10.WidthF = 1.0!
        '
        'XrCrossBandBox1
        '
        Me.XrCrossBandBox1.BorderWidth = 1.0!
        Me.XrCrossBandBox1.EndBand = Me.SubBand2
        resources.ApplyResources(Me.XrCrossBandBox1, "XrCrossBandBox1")
        Me.XrCrossBandBox1.Name = "XrCrossBandBox1"
        Me.XrCrossBandBox1.StartBand = Me.SubBand1
        Me.XrCrossBandBox1.WidthF = 764.3167!
        '
        'report_CountAbsent
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMarginBand1, Me.BottomMarginBand1, Me.PageFooter, Me.PageHeader, Me.ReportFooter})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.CalculatedField1, Me.reportName, Me.CalculatedField2, Me.CalculatedField6, Me.CalculatedField3, Me.CalculatedField4, Me.CalculatedField5, Me.CalculatedField7})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandLine10, Me.XrCrossBandLine9, Me.XrCrossBandLine8, Me.XrCrossBandLine7, Me.XrCrossBandBox1, Me.XrCrossBandLine6, Me.XrCrossBandLine5, Me.XrCrossBandLine4, Me.XrCrossBandLine3, Me.XrCrossBandLine2, Me.XrCrossBandLine1})
        Me.DataMember = "vw_SO_quotation_report"
        Me.DataSource = Me.SqlDataSource1
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.hide_disPer, Me.hide_remark, Me.hide_disPer_bill, Me.hide_lastPage, Me.hide_Price, Me.hide_Tax})
        resources.ApplyResources(Me, "$this")
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.headname, Me.paradate, Me.type_use, Me.computername, Me.companyname, Me.headDate})
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
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CalculatedField6 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel59 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CalculatedField3 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalculatedField4 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents headname As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents lbAbsent As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbVa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbLate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbCome As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paradate As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents type_use As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents CalculatedField5 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents computername As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents CalculatedField7 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents lbTotalCome As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SubBand1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents XrLine6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrCrossBandLine1 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine2 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine3 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine4 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine5 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine6 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents lbTotalAbsent As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbTotalLate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents headDate As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents companyname As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents lbTotalEmp As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTotalEmp As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrCrossBandLine7 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine8 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine9 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine10 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents lbComePer As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbLatePer As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbVaPer As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbAbsentPer As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbTotalComePer As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbTotalLatePer As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbTotalVaPer As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbTotalAbsPer As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrCrossBandBox1 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents SubBand2 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents XrLine7 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lbTotalVacation As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SubBand3 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents pcLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
End Class
