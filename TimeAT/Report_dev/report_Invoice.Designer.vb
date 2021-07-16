<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class report_Invoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(report_Invoice))
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim ShapeRectangle1 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel59 = New DevExpress.XtraReports.UI.XRLabel()
        Me.h14 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.reportName = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalculatedField2 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Headname = New DevExpress.XtraReports.Parameters.Parameter()
        Me.cCheckDate = New DevExpress.XtraReports.Parameters.Parameter()
        Me.companyname = New DevExpress.XtraReports.Parameters.Parameter()
        Me.CalculatedField6 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalculatedField3 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.paradate = New DevExpress.XtraReports.Parameters.Parameter()
        Me.fullname = New DevExpress.XtraReports.Parameters.Parameter()
        Me.CalculatedField5 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.division_name = New DevExpress.XtraReports.UI.CalculatedField()
        Me.department_name = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Lang = New DevExpress.XtraReports.Parameters.Parameter()
        Me.h16 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.d14 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.calContract_Name = New DevExpress.XtraReports.UI.CalculatedField()
        Me.contract_at_str = New DevExpress.XtraReports.UI.CalculatedField()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel61 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel71 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel67 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel63 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel60 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel42 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel58 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel57 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel56 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel55 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel47 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel46 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable5 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell43 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel87 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel88 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel86 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel85 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel84 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel83 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel82 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.calAddress = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrCrossBandBox1 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.XrCrossBandLine1 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.calDueDate = New DevExpress.XtraReports.UI.CalculatedField()
        Me.calTotal = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrCrossBandLine2 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrLabel51 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel54 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel53 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel52 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel50 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel49 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel48 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrShape1 = New DevExpress.XtraReports.UI.XRShape()
        Me.XrCrossBandLine3 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine4 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine5 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine6 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine7 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine8 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine9 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine10 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine11 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine12 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel59, Me.XrLabel21, Me.XrLabel5, Me.XrLabel3, Me.XrLabel22, Me.XrLabel27, Me.XrLabel26, Me.XrLabel25, Me.XrLabel24, Me.XrPictureBox3, Me.XrLabel2, Me.XrLabel1, Me.XrPictureBox2, Me.XrLabel20, Me.XrLabel19, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6})
        resources.ApplyResources(Me.Detail, "Detail")
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("row", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        '
        'XrLabel59
        '
        resources.ApplyResources(Me.XrLabel59, "XrLabel59")
        Me.XrLabel59.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel59.CanGrow = False
        Me.XrLabel59.FormattingRules.Add(Me.h14)
        Me.XrLabel59.Name = "XrLabel59"
        Me.XrLabel59.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel59.StylePriority.UseBackColor = False
        Me.XrLabel59.StylePriority.UseBorders = False
        Me.XrLabel59.StylePriority.UseFont = False
        Me.XrLabel59.StylePriority.UseTextAlignment = False
        '
        'h14
        '
        Me.h14.Formatting.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.h14.Name = "h14"
        '
        'XrLabel21
        '
        resources.ApplyResources(Me.XrLabel21, "XrLabel21")
        Me.XrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel21.CanGrow = False
        Me.XrLabel21.FormattingRules.Add(Me.h14)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel21.StylePriority.UseBackColor = False
        Me.XrLabel21.StylePriority.UseBorders = False
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        '
        'XrLabel5
        '
        resources.ApplyResources(Me.XrLabel5, "XrLabel5")
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel5.CanGrow = False
        Me.XrLabel5.FormattingRules.Add(Me.h14)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        '
        'XrLabel3
        '
        resources.ApplyResources(Me.XrLabel3, "XrLabel3")
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.CanGrow = False
        Me.XrLabel3.FormattingRules.Add(Me.h14)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        '
        'XrLabel22
        '
        resources.ApplyResources(Me.XrLabel22, "XrLabel22")
        Me.XrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel22.CanGrow = False
        Me.XrLabel22.FormattingRules.Add(Me.h14)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel22.StylePriority.UseBackColor = False
        Me.XrLabel22.StylePriority.UseBorders = False
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        '
        'XrLabel27
        '
        resources.ApplyResources(Me.XrLabel27, "XrLabel27")
        Me.XrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel27.CanGrow = False
        Me.XrLabel27.FormattingRules.Add(Me.h14)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel27.StylePriority.UseBackColor = False
        Me.XrLabel27.StylePriority.UseBorders = False
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        '
        'XrLabel26
        '
        resources.ApplyResources(Me.XrLabel26, "XrLabel26")
        Me.XrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel26.CanGrow = False
        Me.XrLabel26.FormattingRules.Add(Me.h14)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel26.StylePriority.UseBackColor = False
        Me.XrLabel26.StylePriority.UseBorders = False
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.StylePriority.UseTextAlignment = False
        '
        'XrLabel25
        '
        resources.ApplyResources(Me.XrLabel25, "XrLabel25")
        Me.XrLabel25.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel25.CanGrow = False
        Me.XrLabel25.FormattingRules.Add(Me.h14)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel25.StylePriority.UseBackColor = False
        Me.XrLabel25.StylePriority.UseBorders = False
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        '
        'XrLabel24
        '
        Me.XrLabel24.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel24.CanGrow = False
        resources.ApplyResources(Me.XrLabel24, "XrLabel24")
        Me.XrLabel24.FormattingRules.Add(Me.h14)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel24.StylePriority.UseBorders = False
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.Borders = DevExpress.XtraPrinting.BorderSide.None
        resources.ApplyResources(Me.XrPictureBox3, "XrPictureBox3")
        Me.XrPictureBox3.Image = CType(resources.GetObject("XrPictureBox3.Image"), System.Drawing.Image)
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.StylePriority.UseBorders = False
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel2.CanGrow = False
        resources.ApplyResources(Me.XrLabel2, "XrLabel2")
        Me.XrLabel2.FormattingRules.Add(Me.h14)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.CanGrow = False
        resources.ApplyResources(Me.XrLabel1, "XrLabel1")
        Me.XrLabel1.FormattingRules.Add(Me.h14)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.Borders = DevExpress.XtraPrinting.BorderSide.None
        resources.ApplyResources(Me.XrPictureBox2, "XrPictureBox2")
        Me.XrPictureBox2.Image = CType(resources.GetObject("XrPictureBox2.Image"), System.Drawing.Image)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.StylePriority.UseBorders = False
        '
        'XrLabel20
        '
        Me.XrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.Total", "{0:n2}")})
        resources.ApplyResources(Me.XrLabel20, "XrLabel20")
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 10, 0, 0, 254.0!)
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UsePadding = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        '
        'XrLabel19
        '
        Me.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.price", "{0:n2}")})
        resources.ApplyResources(Me.XrLabel19, "XrLabel19")
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 10, 0, 0, 254.0!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UsePadding = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.qty")})
        resources.ApplyResources(Me.XrLabel9, "XrLabel9")
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 10, 0, 0, 254.0!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UsePadding = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.unit")})
        resources.ApplyResources(Me.XrLabel8, "XrLabel8")
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        '
        'XrLabel7
        '
        resources.ApplyResources(Me.XrLabel7, "XrLabel7")
        Me.XrLabel7.FormattingRules.Add(Me.h14)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        '
        'XrLabel6
        '
        Me.XrLabel6.CanGrow = False
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.productname")})
        resources.ApplyResources(Me.XrLabel6, "XrLabel6")
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        '
        'XrLabel4
        '
        Me.XrLabel4.CanGrow = False
        resources.ApplyResources(Me.XrLabel4, "XrLabel4")
        Me.XrLabel4.FormattingRules.Add(Me.h14)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
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
        CustomSqlQuery1.Name = "Query"
        CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
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
        Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
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
        resources.ApplyResources(Me.CalculatedField2, "CalculatedField2")
        Me.CalculatedField2.Expression = "[Fname] + '     ' + [Lname]"
        Me.CalculatedField2.Name = "CalculatedField2"
        '
        'Headname
        '
        resources.ApplyResources(Me.Headname, "Headname")
        Me.Headname.Name = "Headname"
        '
        'cCheckDate
        '
        resources.ApplyResources(Me.cCheckDate, "cCheckDate")
        Me.cCheckDate.Name = "cCheckDate"
        '
        'companyname
        '
        resources.ApplyResources(Me.companyname, "companyname")
        Me.companyname.Name = "companyname"
        '
        'CalculatedField6
        '
        Me.CalculatedField6.DataMember = "Query"
        resources.ApplyResources(Me.CalculatedField6, "CalculatedField6")
        Me.CalculatedField6.Expression = "Sum([DayDo])"
        Me.CalculatedField6.Name = "CalculatedField6"
        '
        'CalculatedField3
        '
        Me.CalculatedField3.DataMember = "Query"
        resources.ApplyResources(Me.CalculatedField3, "CalculatedField3")
        Me.CalculatedField3.Name = "CalculatedField3"
        '
        'paradate
        '
        resources.ApplyResources(Me.paradate, "paradate")
        Me.paradate.Name = "paradate"
        Me.paradate.ValueInfo = "2019/01/01"
        '
        'fullname
        '
        resources.ApplyResources(Me.fullname, "fullname")
        Me.fullname.Name = "fullname"
        '
        'CalculatedField5
        '
        Me.CalculatedField5.DataMember = "Query"
        resources.ApplyResources(Me.CalculatedField5, "CalculatedField5")
        Me.CalculatedField5.Expression = "[Title]+[Fname] + '  ' + [Lname]"
        Me.CalculatedField5.Name = "CalculatedField5"
        '
        'division_name
        '
        Me.division_name.DataMember = "Query"
        Me.division_name.Expression = "iif([Parameters.Lang] = 'TH'" & Global.Microsoft.VisualBasic.ChrW(10) & ",'ฝ่าย : ' + [Division]" & Global.Microsoft.VisualBasic.ChrW(10) & ",'Section : ' + [Division])"
        Me.division_name.Name = "division_name"
        '
        'department_name
        '
        Me.department_name.DataMember = "Query"
        Me.department_name.Expression = "iif([Parameters.Lang] = 'TH'," & Global.Microsoft.VisualBasic.ChrW(10) & "'แผนก : ' + [Department]" & Global.Microsoft.VisualBasic.ChrW(10) & ",'Department : ' + [Depart" &
    "ment])"
        Me.department_name.Name = "department_name"
        '
        'Lang
        '
        Me.Lang.Name = "Lang"
        Me.Lang.ValueInfo = "TH"
        '
        'h16
        '
        Me.h16.Formatting.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.h16.Name = "h16"
        '
        'd14
        '
        Me.d14.Formatting.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.d14.Name = "d14"
        '
        'calContract_Name
        '
        Me.calContract_Name.DataMember = "Query"
        Me.calContract_Name.Expression = "iif([sign_contract_name2]<>'',[sign_contract_name] + ' และ ' + [sign_contract_nam" &
    "e2],[sign_contract_name])"
        Me.calContract_Name.Name = "calContract_Name"
        '
        'contract_at_str
        '
        Me.contract_at_str.DataMember = "Query"
        Me.contract_at_str.Name = "contract_at_str"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel61, Me.XrLabel71, Me.XrLabel67, Me.XrLabel63, Me.XrLabel60, Me.XrLabel42, Me.XrLabel58, Me.XrLabel57, Me.XrLabel56, Me.XrLabel55, Me.XrLabel47, Me.XrLabel46, Me.XrLabel45, Me.XrLabel44, Me.XrTable5, Me.XrTable3, Me.XrLabel87, Me.XrLabel88, Me.XrLabel86, Me.XrLabel85, Me.XrLabel84, Me.XrLabel83, Me.XrLabel82, Me.XrTable1, Me.XrLabel11, Me.XrLabel10, Me.XrLabel4, Me.XrPictureBox1})
        resources.ApplyResources(Me.PageHeader, "PageHeader")
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel61
        '
        Me.XrLabel61.CanGrow = False
        resources.ApplyResources(Me.XrLabel61, "XrLabel61")
        Me.XrLabel61.EditOptions.Enabled = True
        Me.XrLabel61.FormattingRules.Add(Me.h14)
        Me.XrLabel61.Name = "XrLabel61"
        Me.XrLabel61.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel61.StylePriority.UseFont = False
        Me.XrLabel61.StylePriority.UseTextAlignment = False
        '
        'XrLabel71
        '
        Me.XrLabel71.CanGrow = False
        resources.ApplyResources(Me.XrLabel71, "XrLabel71")
        Me.XrLabel71.FormattingRules.Add(Me.h14)
        Me.XrLabel71.Name = "XrLabel71"
        Me.XrLabel71.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel71.StylePriority.UseFont = False
        Me.XrLabel71.StylePriority.UseTextAlignment = False
        '
        'XrLabel67
        '
        Me.XrLabel67.CanGrow = False
        resources.ApplyResources(Me.XrLabel67, "XrLabel67")
        Me.XrLabel67.FormattingRules.Add(Me.h14)
        Me.XrLabel67.Name = "XrLabel67"
        Me.XrLabel67.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel67.StylePriority.UseFont = False
        Me.XrLabel67.StylePriority.UseTextAlignment = False
        '
        'XrLabel63
        '
        Me.XrLabel63.CanGrow = False
        resources.ApplyResources(Me.XrLabel63, "XrLabel63")
        Me.XrLabel63.FormattingRules.Add(Me.h14)
        Me.XrLabel63.Name = "XrLabel63"
        Me.XrLabel63.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel63.StylePriority.UseFont = False
        Me.XrLabel63.StylePriority.UseTextAlignment = False
        '
        'XrLabel60
        '
        Me.XrLabel60.CanGrow = False
        resources.ApplyResources(Me.XrLabel60, "XrLabel60")
        Me.XrLabel60.FormattingRules.Add(Me.h14)
        Me.XrLabel60.Name = "XrLabel60"
        Me.XrLabel60.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel60.StylePriority.UseFont = False
        Me.XrLabel60.StylePriority.UseTextAlignment = False
        '
        'XrLabel42
        '
        Me.XrLabel42.CanGrow = False
        resources.ApplyResources(Me.XrLabel42, "XrLabel42")
        Me.XrLabel42.FormattingRules.Add(Me.h14)
        Me.XrLabel42.Name = "XrLabel42"
        Me.XrLabel42.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel42.StylePriority.UseFont = False
        Me.XrLabel42.StylePriority.UseTextAlignment = False
        '
        'XrLabel58
        '
        Me.XrLabel58.CanGrow = False
        resources.ApplyResources(Me.XrLabel58, "XrLabel58")
        Me.XrLabel58.FormattingRules.Add(Me.h14)
        Me.XrLabel58.Name = "XrLabel58"
        Me.XrLabel58.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel58.StylePriority.UseFont = False
        Me.XrLabel58.StylePriority.UseTextAlignment = False
        '
        'XrLabel57
        '
        Me.XrLabel57.CanGrow = False
        resources.ApplyResources(Me.XrLabel57, "XrLabel57")
        Me.XrLabel57.FormattingRules.Add(Me.h14)
        Me.XrLabel57.Name = "XrLabel57"
        Me.XrLabel57.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel57.StylePriority.UseFont = False
        Me.XrLabel57.StylePriority.UseTextAlignment = False
        '
        'XrLabel56
        '
        Me.XrLabel56.CanGrow = False
        resources.ApplyResources(Me.XrLabel56, "XrLabel56")
        Me.XrLabel56.FormattingRules.Add(Me.h14)
        Me.XrLabel56.Name = "XrLabel56"
        Me.XrLabel56.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel56.StylePriority.UseFont = False
        Me.XrLabel56.StylePriority.UseTextAlignment = False
        '
        'XrLabel55
        '
        Me.XrLabel55.CanGrow = False
        resources.ApplyResources(Me.XrLabel55, "XrLabel55")
        Me.XrLabel55.FormattingRules.Add(Me.h14)
        Me.XrLabel55.Name = "XrLabel55"
        Me.XrLabel55.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel55.StylePriority.UseFont = False
        Me.XrLabel55.StylePriority.UseTextAlignment = False
        '
        'XrLabel47
        '
        Me.XrLabel47.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot
        Me.XrLabel47.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel47.CanGrow = False
        Me.XrLabel47.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.invoicedate", "{0:dd/MM/yyyy}")})
        resources.ApplyResources(Me.XrLabel47, "XrLabel47")
        Me.XrLabel47.Name = "XrLabel47"
        Me.XrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel47.StylePriority.UseBorderDashStyle = False
        Me.XrLabel47.StylePriority.UseBorders = False
        Me.XrLabel47.StylePriority.UseFont = False
        Me.XrLabel47.StylePriority.UseTextAlignment = False
        '
        'XrLabel46
        '
        Me.XrLabel46.CanGrow = False
        resources.ApplyResources(Me.XrLabel46, "XrLabel46")
        Me.XrLabel46.FormattingRules.Add(Me.h14)
        Me.XrLabel46.Name = "XrLabel46"
        Me.XrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel46.StylePriority.UseFont = False
        Me.XrLabel46.StylePriority.UseTextAlignment = False
        '
        'XrLabel45
        '
        Me.XrLabel45.CanGrow = False
        resources.ApplyResources(Me.XrLabel45, "XrLabel45")
        Me.XrLabel45.FormattingRules.Add(Me.h14)
        Me.XrLabel45.Name = "XrLabel45"
        Me.XrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel45.StylePriority.UseFont = False
        Me.XrLabel45.StylePriority.UseTextAlignment = False
        '
        'XrLabel44
        '
        Me.XrLabel44.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot
        Me.XrLabel44.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel44.CanGrow = False
        Me.XrLabel44.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.VendorId")})
        resources.ApplyResources(Me.XrLabel44, "XrLabel44")
        Me.XrLabel44.Name = "XrLabel44"
        Me.XrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel44.StylePriority.UseBorderDashStyle = False
        Me.XrLabel44.StylePriority.UseBorders = False
        Me.XrLabel44.StylePriority.UseFont = False
        Me.XrLabel44.StylePriority.UseTextAlignment = False
        '
        'XrTable5
        '
        Me.XrTable5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        resources.ApplyResources(Me.XrTable5, "XrTable5")
        Me.XrTable5.Name = "XrTable5"
        Me.XrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow11, Me.XrTableRow12})
        Me.XrTable5.StylePriority.UseBorders = False
        Me.XrTable5.StylePriority.UseFont = False
        Me.XrTable5.StylePriority.UseTextAlignment = False
        '
        'XrTableRow11
        '
        Me.XrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell34, Me.XrTableCell35, Me.XrTableCell36, Me.XrTableCell37, Me.XrTableCell38, Me.XrTableCell49})
        resources.ApplyResources(Me.XrTableRow11, "XrTableRow11")
        Me.XrTableRow11.Name = "XrTableRow11"
        '
        'XrTableCell34
        '
        Me.XrTableCell34.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableCell34.CanGrow = False
        resources.ApplyResources(Me.XrTableCell34, "XrTableCell34")
        Me.XrTableCell34.Multiline = True
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.StylePriority.UseBorders = False
        Me.XrTableCell34.StylePriority.UseTextAlignment = False
        '
        'XrTableCell35
        '
        Me.XrTableCell35.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableCell35.CanGrow = False
        resources.ApplyResources(Me.XrTableCell35, "XrTableCell35")
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.StylePriority.UseBorders = False
        Me.XrTableCell35.StylePriority.UseFont = False
        Me.XrTableCell35.StylePriority.UseTextAlignment = False
        '
        'XrTableCell36
        '
        Me.XrTableCell36.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableCell36.CanGrow = False
        resources.ApplyResources(Me.XrTableCell36, "XrTableCell36")
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.StylePriority.UseBorders = False
        Me.XrTableCell36.StylePriority.UseTextAlignment = False
        '
        'XrTableCell37
        '
        Me.XrTableCell37.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableCell37.CanGrow = False
        resources.ApplyResources(Me.XrTableCell37, "XrTableCell37")
        Me.XrTableCell37.Name = "XrTableCell37"
        Me.XrTableCell37.StylePriority.UseBorders = False
        Me.XrTableCell37.StylePriority.UseFont = False
        Me.XrTableCell37.StylePriority.UseTextAlignment = False
        '
        'XrTableCell38
        '
        Me.XrTableCell38.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableCell38.CanGrow = False
        resources.ApplyResources(Me.XrTableCell38, "XrTableCell38")
        Me.XrTableCell38.Name = "XrTableCell38"
        Me.XrTableCell38.StylePriority.UseBorders = False
        Me.XrTableCell38.StylePriority.UseFont = False
        Me.XrTableCell38.StylePriority.UseTextAlignment = False
        '
        'XrTableCell49
        '
        Me.XrTableCell49.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableCell49.CanGrow = False
        resources.ApplyResources(Me.XrTableCell49, "XrTableCell49")
        Me.XrTableCell49.Name = "XrTableCell49"
        Me.XrTableCell49.StylePriority.UseBorders = False
        Me.XrTableCell49.StylePriority.UseFont = False
        Me.XrTableCell49.StylePriority.UseTextAlignment = False
        '
        'XrTableRow12
        '
        Me.XrTableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell39, Me.XrTableCell40, Me.XrTableCell41, Me.XrTableCell42, Me.XrTableCell43, Me.XrTableCell50})
        resources.ApplyResources(Me.XrTableRow12, "XrTableRow12")
        Me.XrTableRow12.Name = "XrTableRow12"
        '
        'XrTableCell39
        '
        Me.XrTableCell39.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell39.CanGrow = False
        resources.ApplyResources(Me.XrTableCell39, "XrTableCell39")
        Me.XrTableCell39.Name = "XrTableCell39"
        Me.XrTableCell39.StylePriority.UseBorders = False
        Me.XrTableCell39.StylePriority.UseFont = False
        Me.XrTableCell39.StylePriority.UseTextAlignment = False
        '
        'XrTableCell40
        '
        Me.XrTableCell40.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell40.CanGrow = False
        resources.ApplyResources(Me.XrTableCell40, "XrTableCell40")
        Me.XrTableCell40.Name = "XrTableCell40"
        Me.XrTableCell40.StylePriority.UseBorders = False
        Me.XrTableCell40.StylePriority.UseFont = False
        Me.XrTableCell40.StylePriority.UseTextAlignment = False
        '
        'XrTableCell41
        '
        Me.XrTableCell41.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell41.CanGrow = False
        resources.ApplyResources(Me.XrTableCell41, "XrTableCell41")
        Me.XrTableCell41.Name = "XrTableCell41"
        Me.XrTableCell41.StylePriority.UseBorders = False
        Me.XrTableCell41.StylePriority.UseFont = False
        Me.XrTableCell41.StylePriority.UseTextAlignment = False
        '
        'XrTableCell42
        '
        Me.XrTableCell42.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell42.CanGrow = False
        resources.ApplyResources(Me.XrTableCell42, "XrTableCell42")
        Me.XrTableCell42.Name = "XrTableCell42"
        Me.XrTableCell42.StylePriority.UseBorders = False
        Me.XrTableCell42.StylePriority.UseFont = False
        Me.XrTableCell42.StylePriority.UseTextAlignment = False
        '
        'XrTableCell43
        '
        Me.XrTableCell43.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell43.CanGrow = False
        resources.ApplyResources(Me.XrTableCell43, "XrTableCell43")
        Me.XrTableCell43.Name = "XrTableCell43"
        Me.XrTableCell43.StylePriority.UseBorders = False
        Me.XrTableCell43.StylePriority.UseFont = False
        Me.XrTableCell43.StylePriority.UseTextAlignment = False
        '
        'XrTableCell50
        '
        Me.XrTableCell50.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell50.CanGrow = False
        resources.ApplyResources(Me.XrTableCell50, "XrTableCell50")
        Me.XrTableCell50.Name = "XrTableCell50"
        Me.XrTableCell50.StylePriority.UseBorders = False
        Me.XrTableCell50.StylePriority.UseFont = False
        Me.XrTableCell50.StylePriority.UseTextAlignment = False
        '
        'XrTable3
        '
        Me.XrTable3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        resources.ApplyResources(Me.XrTable3, "XrTable3")
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow6, Me.XrTableRow7, Me.XrTableRow10})
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.XrTableCell15, Me.XrTableCell16, Me.XrTableCell17, Me.XrTableCell18})
        resources.ApplyResources(Me.XrTableRow6, "XrTableRow6")
        Me.XrTableRow6.Name = "XrTableRow6"
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell7.CanGrow = False
        resources.ApplyResources(Me.XrTableCell7, "XrTableCell7")
        Me.XrTableCell7.Multiline = True
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseBorders = False
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell15.CanGrow = False
        resources.ApplyResources(Me.XrTableCell15, "XrTableCell15")
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.StylePriority.UseBorders = False
        Me.XrTableCell15.StylePriority.UseFont = False
        Me.XrTableCell15.StylePriority.UseTextAlignment = False
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell16.CanGrow = False
        resources.ApplyResources(Me.XrTableCell16, "XrTableCell16")
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.StylePriority.UseBorders = False
        Me.XrTableCell16.StylePriority.UseTextAlignment = False
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell17.CanGrow = False
        resources.ApplyResources(Me.XrTableCell17, "XrTableCell17")
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.StylePriority.UseBorders = False
        Me.XrTableCell17.StylePriority.UseFont = False
        Me.XrTableCell17.StylePriority.UseTextAlignment = False
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell18.CanGrow = False
        resources.ApplyResources(Me.XrTableCell18, "XrTableCell18")
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.StylePriority.UseBorders = False
        Me.XrTableCell18.StylePriority.UseFont = False
        Me.XrTableCell18.StylePriority.UseTextAlignment = False
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell24, Me.XrTableCell25, Me.XrTableCell26, Me.XrTableCell27, Me.XrTableCell28})
        resources.ApplyResources(Me.XrTableRow7, "XrTableRow7")
        Me.XrTableRow7.Name = "XrTableRow7"
        '
        'XrTableCell24
        '
        Me.XrTableCell24.CanGrow = False
        resources.ApplyResources(Me.XrTableCell24, "XrTableCell24")
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.StylePriority.UseFont = False
        Me.XrTableCell24.StylePriority.UseTextAlignment = False
        '
        'XrTableCell25
        '
        Me.XrTableCell25.CanGrow = False
        resources.ApplyResources(Me.XrTableCell25, "XrTableCell25")
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.StylePriority.UseFont = False
        Me.XrTableCell25.StylePriority.UseTextAlignment = False
        '
        'XrTableCell26
        '
        Me.XrTableCell26.CanGrow = False
        resources.ApplyResources(Me.XrTableCell26, "XrTableCell26")
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.StylePriority.UseFont = False
        Me.XrTableCell26.StylePriority.UseTextAlignment = False
        '
        'XrTableCell27
        '
        Me.XrTableCell27.CanGrow = False
        resources.ApplyResources(Me.XrTableCell27, "XrTableCell27")
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.StylePriority.UseFont = False
        Me.XrTableCell27.StylePriority.UseTextAlignment = False
        '
        'XrTableCell28
        '
        Me.XrTableCell28.CanGrow = False
        resources.ApplyResources(Me.XrTableCell28, "XrTableCell28")
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.StylePriority.UseFont = False
        Me.XrTableCell28.StylePriority.UseTextAlignment = False
        '
        'XrTableRow10
        '
        Me.XrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell29, Me.XrTableCell30, Me.XrTableCell31, Me.XrTableCell32, Me.XrTableCell33})
        resources.ApplyResources(Me.XrTableRow10, "XrTableRow10")
        Me.XrTableRow10.Name = "XrTableRow10"
        '
        'XrTableCell29
        '
        resources.ApplyResources(Me.XrTableCell29, "XrTableCell29")
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.StylePriority.UseFont = False
        Me.XrTableCell29.StylePriority.UseTextAlignment = False
        '
        'XrTableCell30
        '
        Me.XrTableCell30.CanGrow = False
        Me.XrTableCell30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.contract_no")})
        resources.ApplyResources(Me.XrTableCell30, "XrTableCell30")
        Me.XrTableCell30.EditOptions.Enabled = True
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.StylePriority.UseFont = False
        Me.XrTableCell30.StylePriority.UseTextAlignment = False
        '
        'XrTableCell31
        '
        Me.XrTableCell31.CanGrow = False
        resources.ApplyResources(Me.XrTableCell31, "XrTableCell31")
        Me.XrTableCell31.EditOptions.Enabled = True
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.StylePriority.UseFont = False
        Me.XrTableCell31.StylePriority.UseTextAlignment = False
        '
        'XrTableCell32
        '
        Me.XrTableCell32.CanGrow = False
        Me.XrTableCell32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.duedate_str", "{0:dd MMM yyyy}")})
        resources.ApplyResources(Me.XrTableCell32, "XrTableCell32")
        Me.XrTableCell32.EditOptions.Enabled = True
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.StylePriority.UseFont = False
        Me.XrTableCell32.StylePriority.UseTextAlignment = False
        '
        'XrTableCell33
        '
        resources.ApplyResources(Me.XrTableCell33, "XrTableCell33")
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.StylePriority.UseFont = False
        Me.XrTableCell33.StylePriority.UseTextAlignment = False
        '
        'XrLabel87
        '
        Me.XrLabel87.CanGrow = False
        resources.ApplyResources(Me.XrLabel87, "XrLabel87")
        Me.XrLabel87.FormattingRules.Add(Me.h14)
        Me.XrLabel87.Name = "XrLabel87"
        Me.XrLabel87.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel87.StylePriority.UseFont = False
        Me.XrLabel87.StylePriority.UseTextAlignment = False
        '
        'XrLabel88
        '
        Me.XrLabel88.CanGrow = False
        resources.ApplyResources(Me.XrLabel88, "XrLabel88")
        Me.XrLabel88.FormattingRules.Add(Me.h14)
        Me.XrLabel88.Name = "XrLabel88"
        Me.XrLabel88.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel88.StylePriority.UseFont = False
        Me.XrLabel88.StylePriority.UseTextAlignment = False
        '
        'XrLabel86
        '
        Me.XrLabel86.CanGrow = False
        Me.XrLabel86.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.calAddress")})
        resources.ApplyResources(Me.XrLabel86, "XrLabel86")
        Me.XrLabel86.EditOptions.Enabled = True
        Me.XrLabel86.Name = "XrLabel86"
        Me.XrLabel86.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel86.StylePriority.UseFont = False
        Me.XrLabel86.StylePriority.UseTextAlignment = False
        Me.XrLabel86.TextTrimming = System.Drawing.StringTrimming.Word
        '
        'XrLabel85
        '
        Me.XrLabel85.CanGrow = False
        resources.ApplyResources(Me.XrLabel85, "XrLabel85")
        Me.XrLabel85.FormattingRules.Add(Me.h14)
        Me.XrLabel85.Name = "XrLabel85"
        Me.XrLabel85.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel85.StylePriority.UseFont = False
        Me.XrLabel85.StylePriority.UseTextAlignment = False
        '
        'XrLabel84
        '
        Me.XrLabel84.CanGrow = False
        resources.ApplyResources(Me.XrLabel84, "XrLabel84")
        Me.XrLabel84.FormattingRules.Add(Me.h14)
        Me.XrLabel84.Name = "XrLabel84"
        Me.XrLabel84.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel84.StylePriority.UseFont = False
        Me.XrLabel84.StylePriority.UseTextAlignment = False
        '
        'XrLabel83
        '
        Me.XrLabel83.CanGrow = False
        Me.XrLabel83.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.vendor_name")})
        resources.ApplyResources(Me.XrLabel83, "XrLabel83")
        Me.XrLabel83.Name = "XrLabel83"
        Me.XrLabel83.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel83.StylePriority.UseFont = False
        Me.XrLabel83.StylePriority.UseTextAlignment = False
        '
        'XrLabel82
        '
        Me.XrLabel82.CanGrow = False
        resources.ApplyResources(Me.XrLabel82, "XrLabel82")
        Me.XrLabel82.FormattingRules.Add(Me.h14)
        Me.XrLabel82.Name = "XrLabel82"
        Me.XrLabel82.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel82.StylePriority.UseFont = False
        Me.XrLabel82.StylePriority.UseTextAlignment = False
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        resources.ApplyResources(Me.XrTable1, "XrTable1")
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell23, Me.XrTableCell8, Me.XrTableCell10, Me.XrTableCell9})
        resources.ApplyResources(Me.XrTableRow3, "XrTableRow3")
        Me.XrTableRow3.Name = "XrTableRow3"
        '
        'XrTableCell23
        '
        resources.ApplyResources(Me.XrTableCell23, "XrTableCell23")
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.StylePriority.UseFont = False
        Me.XrTableCell23.StylePriority.UseTextAlignment = False
        '
        'XrTableCell8
        '
        Me.XrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.bookno")})
        resources.ApplyResources(Me.XrTableCell8, "XrTableCell8")
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseFont = False
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        '
        'XrTableCell10
        '
        resources.ApplyResources(Me.XrTableCell10, "XrTableCell10")
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseFont = False
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        '
        'XrTableCell9
        '
        Me.XrTableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.idno")})
        resources.ApplyResources(Me.XrTableCell9, "XrTableCell9")
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        '
        'XrLabel11
        '
        Me.XrLabel11.CanGrow = False
        resources.ApplyResources(Me.XrLabel11, "XrLabel11")
        Me.XrLabel11.FormattingRules.Add(Me.h14)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        '
        'XrLabel10
        '
        Me.XrLabel10.CanGrow = False
        resources.ApplyResources(Me.XrLabel10, "XrLabel10")
        Me.XrLabel10.FormattingRules.Add(Me.h14)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        '
        'XrPictureBox1
        '
        resources.ApplyResources(Me.XrPictureBox1, "XrPictureBox1")
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        '
        'calAddress
        '
        Me.calAddress.DataMember = "Query"
        Me.calAddress.Expression = "[address1] + ' ' + Char(10) + [address2] + ' ' + [zipcode]"
        Me.calAddress.Name = "calAddress"
        '
        'XrCrossBandBox1
        '
        Me.XrCrossBandBox1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.XrCrossBandBox1.BorderWidth = 1.0!
        resources.ApplyResources(Me.XrCrossBandBox1, "XrCrossBandBox1")
        Me.XrCrossBandBox1.EndBand = Me.PageHeader
        Me.XrCrossBandBox1.Name = "XrCrossBandBox1"
        Me.XrCrossBandBox1.StartBand = Me.PageHeader
        Me.XrCrossBandBox1.WidthF = 1838.5!
        '
        'XrCrossBandLine1
        '
        Me.XrCrossBandLine1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        resources.ApplyResources(Me.XrCrossBandLine1, "XrCrossBandLine1")
        Me.XrCrossBandLine1.EndBand = Me.PageHeader
        Me.XrCrossBandLine1.Name = "XrCrossBandLine1"
        Me.XrCrossBandLine1.StartBand = Me.PageHeader
        Me.XrCrossBandLine1.WidthF = 3.000061!
        '
        'calDueDate
        '
        Me.calDueDate.DataMember = "Query"
        Me.calDueDate.Expression = "AddDays([invoicedate],15 )"
        Me.calDueDate.Name = "calDueDate"
        '
        'calTotal
        '
        Me.calTotal.DataMember = "Query"
        Me.calTotal.Expression = "[qty]*[price]"
        Me.calTotal.Name = "calTotal"
        '
        'XrCrossBandLine2
        '
        Me.XrCrossBandLine2.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        resources.ApplyResources(Me.XrCrossBandLine2, "XrCrossBandLine2")
        Me.XrCrossBandLine2.EndBand = Me.PageFooter
        Me.XrCrossBandLine2.Name = "XrCrossBandLine2"
        Me.XrCrossBandLine2.StartBand = Me.PageHeader
        Me.XrCrossBandLine2.WidthF = 3.527832!
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel51, Me.XrLabel54, Me.XrLabel53, Me.XrLabel52, Me.XrLabel50, Me.XrLabel49, Me.XrLabel48, Me.XrLabel41, Me.XrLabel40, Me.XrLabel39, Me.XrLabel38, Me.XrLabel37, Me.XrLine6, Me.XrLine5, Me.XrLine4, Me.XrLine3, Me.XrLine2, Me.XrLine1, Me.XrLabel36, Me.XrLabel35, Me.XrLabel34, Me.XrLabel33, Me.XrLabel32, Me.XrLabel31, Me.XrLabel30, Me.XrLabel29, Me.XrLabel28, Me.XrShape1})
        resources.ApplyResources(Me.PageFooter, "PageFooter")
        Me.PageFooter.Name = "PageFooter"
        '
        'XrLabel51
        '
        Me.XrLabel51.CanGrow = False
        resources.ApplyResources(Me.XrLabel51, "XrLabel51")
        Me.XrLabel51.FormattingRules.Add(Me.h14)
        Me.XrLabel51.Name = "XrLabel51"
        Me.XrLabel51.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel51.StylePriority.UseFont = False
        Me.XrLabel51.StylePriority.UseTextAlignment = False
        '
        'XrLabel54
        '
        Me.XrLabel54.CanGrow = False
        Me.XrLabel54.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.endTotal", "{0:n2}")})
        resources.ApplyResources(Me.XrLabel54, "XrLabel54")
        Me.XrLabel54.Name = "XrLabel54"
        Me.XrLabel54.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 10, 0, 0, 254.0!)
        Me.XrLabel54.StylePriority.UseFont = False
        Me.XrLabel54.StylePriority.UsePadding = False
        Me.XrLabel54.StylePriority.UseTextAlignment = False
        '
        'XrLabel53
        '
        Me.XrLabel53.CanGrow = False
        Me.XrLabel53.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.vat", "{0:n2}")})
        resources.ApplyResources(Me.XrLabel53, "XrLabel53")
        Me.XrLabel53.Name = "XrLabel53"
        Me.XrLabel53.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 10, 0, 0, 254.0!)
        Me.XrLabel53.StylePriority.UseFont = False
        Me.XrLabel53.StylePriority.UsePadding = False
        Me.XrLabel53.StylePriority.UseTextAlignment = False
        '
        'XrLabel52
        '
        Me.XrLabel52.CanGrow = False
        Me.XrLabel52.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.Total", "{0:n2}")})
        resources.ApplyResources(Me.XrLabel52, "XrLabel52")
        Me.XrLabel52.Name = "XrLabel52"
        Me.XrLabel52.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 10, 0, 0, 254.0!)
        Me.XrLabel52.StylePriority.UseFont = False
        Me.XrLabel52.StylePriority.UsePadding = False
        Me.XrLabel52.StylePriority.UseTextAlignment = False
        '
        'XrLabel50
        '
        Me.XrLabel50.CanGrow = False
        Me.XrLabel50.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.Total", "{0:n2}")})
        resources.ApplyResources(Me.XrLabel50, "XrLabel50")
        Me.XrLabel50.Name = "XrLabel50"
        Me.XrLabel50.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 10, 0, 0, 254.0!)
        Me.XrLabel50.StylePriority.UseFont = False
        Me.XrLabel50.StylePriority.UsePadding = False
        Me.XrLabel50.StylePriority.UseTextAlignment = False
        '
        'XrLabel49
        '
        Me.XrLabel49.CanGrow = False
        Me.XrLabel49.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.endTotal_Thaibath")})
        resources.ApplyResources(Me.XrLabel49, "XrLabel49")
        Me.XrLabel49.FormattingRules.Add(Me.h14)
        Me.XrLabel49.Name = "XrLabel49"
        Me.XrLabel49.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel49.StylePriority.UseFont = False
        Me.XrLabel49.StylePriority.UseTextAlignment = False
        '
        'XrLabel48
        '
        Me.XrLabel48.CanGrow = False
        resources.ApplyResources(Me.XrLabel48, "XrLabel48")
        Me.XrLabel48.FormattingRules.Add(Me.h14)
        Me.XrLabel48.Name = "XrLabel48"
        Me.XrLabel48.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel48.StylePriority.UseFont = False
        Me.XrLabel48.StylePriority.UseTextAlignment = False
        '
        'XrLabel41
        '
        resources.ApplyResources(Me.XrLabel41, "XrLabel41")
        Me.XrLabel41.FormattingRules.Add(Me.h14)
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel41.StylePriority.UseFont = False
        Me.XrLabel41.StylePriority.UseTextAlignment = False
        '
        'XrLabel40
        '
        resources.ApplyResources(Me.XrLabel40, "XrLabel40")
        Me.XrLabel40.FormattingRules.Add(Me.h14)
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel40.StylePriority.UseFont = False
        Me.XrLabel40.StylePriority.UseTextAlignment = False
        '
        'XrLabel39
        '
        Me.XrLabel39.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        resources.ApplyResources(Me.XrLabel39, "XrLabel39")
        Me.XrLabel39.FormattingRules.Add(Me.h14)
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel39.StylePriority.UseBorders = False
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        '
        'XrLabel38
        '
        resources.ApplyResources(Me.XrLabel38, "XrLabel38")
        Me.XrLabel38.FormattingRules.Add(Me.h14)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel38.StylePriority.UseFont = False
        Me.XrLabel38.StylePriority.UseTextAlignment = False
        '
        'XrLabel37
        '
        resources.ApplyResources(Me.XrLabel37, "XrLabel37")
        Me.XrLabel37.FormattingRules.Add(Me.h14)
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel37.StylePriority.UseFont = False
        Me.XrLabel37.StylePriority.UseTextAlignment = False
        '
        'XrLine6
        '
        Me.XrLine6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot
        resources.ApplyResources(Me.XrLine6, "XrLine6")
        Me.XrLine6.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.XrLine6.LineWidth = 3
        Me.XrLine6.Name = "XrLine6"
        Me.XrLine6.StylePriority.UseBorderDashStyle = False
        '
        'XrLine5
        '
        Me.XrLine5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        resources.ApplyResources(Me.XrLine5, "XrLine5")
        Me.XrLine5.LineWidth = 3
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.StylePriority.UseBorderDashStyle = False
        '
        'XrLine4
        '
        Me.XrLine4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot
        resources.ApplyResources(Me.XrLine4, "XrLine4")
        Me.XrLine4.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.XrLine4.LineWidth = 3
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.StylePriority.UseBorderDashStyle = False
        '
        'XrLine3
        '
        Me.XrLine3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot
        resources.ApplyResources(Me.XrLine3, "XrLine3")
        Me.XrLine3.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.XrLine3.LineWidth = 3
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.StylePriority.UseBorderDashStyle = False
        '
        'XrLine2
        '
        resources.ApplyResources(Me.XrLine2, "XrLine2")
        Me.XrLine2.LineWidth = 3
        Me.XrLine2.Name = "XrLine2"
        '
        'XrLine1
        '
        resources.ApplyResources(Me.XrLine1, "XrLine1")
        Me.XrLine1.LineWidth = 3
        Me.XrLine1.Name = "XrLine1"
        '
        'XrLabel36
        '
        Me.XrLabel36.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Query.invoicedate", "{0:dd/MM/yyyy}")})
        resources.ApplyResources(Me.XrLabel36, "XrLabel36")
        Me.XrLabel36.FormattingRules.Add(Me.h14)
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        '
        'XrLabel35
        '
        resources.ApplyResources(Me.XrLabel35, "XrLabel35")
        Me.XrLabel35.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel35.FormattingRules.Add(Me.h14)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel35.StylePriority.UseBorderColor = False
        Me.XrLabel35.StylePriority.UseBorders = False
        Me.XrLabel35.StylePriority.UseFont = False
        Me.XrLabel35.StylePriority.UseForeColor = False
        Me.XrLabel35.StylePriority.UseTextAlignment = False
        '
        'XrLabel34
        '
        resources.ApplyResources(Me.XrLabel34, "XrLabel34")
        Me.XrLabel34.FormattingRules.Add(Me.h14)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        '
        'XrLabel33
        '
        resources.ApplyResources(Me.XrLabel33, "XrLabel33")
        Me.XrLabel33.FormattingRules.Add(Me.h14)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        '
        'XrLabel32
        '
        Me.XrLabel32.CanGrow = False
        resources.ApplyResources(Me.XrLabel32, "XrLabel32")
        Me.XrLabel32.FormattingRules.Add(Me.h14)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        '
        'XrLabel31
        '
        Me.XrLabel31.CanGrow = False
        resources.ApplyResources(Me.XrLabel31, "XrLabel31")
        Me.XrLabel31.FormattingRules.Add(Me.h14)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        '
        'XrLabel30
        '
        Me.XrLabel30.CanGrow = False
        resources.ApplyResources(Me.XrLabel30, "XrLabel30")
        Me.XrLabel30.FormattingRules.Add(Me.h14)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        '
        'XrLabel29
        '
        Me.XrLabel29.CanGrow = False
        resources.ApplyResources(Me.XrLabel29, "XrLabel29")
        Me.XrLabel29.FormattingRules.Add(Me.h14)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        '
        'XrLabel28
        '
        Me.XrLabel28.CanGrow = False
        resources.ApplyResources(Me.XrLabel28, "XrLabel28")
        Me.XrLabel28.FormattingRules.Add(Me.h14)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        '
        'XrShape1
        '
        resources.ApplyResources(Me.XrShape1, "XrShape1")
        Me.XrShape1.Name = "XrShape1"
        ShapeRectangle1.Fillet = 30
        Me.XrShape1.Shape = ShapeRectangle1
        '
        'XrCrossBandLine3
        '
        Me.XrCrossBandLine3.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        resources.ApplyResources(Me.XrCrossBandLine3, "XrCrossBandLine3")
        Me.XrCrossBandLine3.EndBand = Me.PageFooter
        Me.XrCrossBandLine3.Name = "XrCrossBandLine3"
        Me.XrCrossBandLine3.StartBand = Me.PageHeader
        Me.XrCrossBandLine3.WidthF = 3.527832!
        '
        'XrCrossBandLine4
        '
        Me.XrCrossBandLine4.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        resources.ApplyResources(Me.XrCrossBandLine4, "XrCrossBandLine4")
        Me.XrCrossBandLine4.EndBand = Me.PageFooter
        Me.XrCrossBandLine4.Name = "XrCrossBandLine4"
        Me.XrCrossBandLine4.StartBand = Me.PageHeader
        Me.XrCrossBandLine4.WidthF = 3.527832!
        '
        'XrCrossBandLine5
        '
        Me.XrCrossBandLine5.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        resources.ApplyResources(Me.XrCrossBandLine5, "XrCrossBandLine5")
        Me.XrCrossBandLine5.EndBand = Me.Detail
        Me.XrCrossBandLine5.Name = "XrCrossBandLine5"
        Me.XrCrossBandLine5.StartBand = Me.PageHeader
        Me.XrCrossBandLine5.WidthF = 3.527832!
        '
        'XrCrossBandLine6
        '
        Me.XrCrossBandLine6.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        resources.ApplyResources(Me.XrCrossBandLine6, "XrCrossBandLine6")
        Me.XrCrossBandLine6.EndBand = Me.Detail
        Me.XrCrossBandLine6.Name = "XrCrossBandLine6"
        Me.XrCrossBandLine6.StartBand = Me.PageHeader
        Me.XrCrossBandLine6.WidthF = 3.527771!
        '
        'XrCrossBandLine7
        '
        Me.XrCrossBandLine7.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        resources.ApplyResources(Me.XrCrossBandLine7, "XrCrossBandLine7")
        Me.XrCrossBandLine7.EndBand = Me.PageFooter
        Me.XrCrossBandLine7.Name = "XrCrossBandLine7"
        Me.XrCrossBandLine7.StartBand = Me.PageHeader
        Me.XrCrossBandLine7.WidthF = 3.527802!
        '
        'XrCrossBandLine8
        '
        Me.XrCrossBandLine8.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        resources.ApplyResources(Me.XrCrossBandLine8, "XrCrossBandLine8")
        Me.XrCrossBandLine8.EndBand = Me.PageFooter
        Me.XrCrossBandLine8.Name = "XrCrossBandLine8"
        Me.XrCrossBandLine8.StartBand = Me.PageHeader
        Me.XrCrossBandLine8.WidthF = 3.527805!
        '
        'XrCrossBandLine9
        '
        Me.XrCrossBandLine9.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        resources.ApplyResources(Me.XrCrossBandLine9, "XrCrossBandLine9")
        Me.XrCrossBandLine9.EndBand = Me.Detail
        Me.XrCrossBandLine9.Name = "XrCrossBandLine9"
        Me.XrCrossBandLine9.StartBand = Me.Detail
        Me.XrCrossBandLine9.WidthF = 3.607971!
        '
        'XrCrossBandLine10
        '
        Me.XrCrossBandLine10.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        resources.ApplyResources(Me.XrCrossBandLine10, "XrCrossBandLine10")
        Me.XrCrossBandLine10.EndBand = Me.PageFooter
        Me.XrCrossBandLine10.Name = "XrCrossBandLine10"
        Me.XrCrossBandLine10.StartBand = Me.Detail
        Me.XrCrossBandLine10.WidthF = 3.527893!
        '
        'XrCrossBandLine11
        '
        Me.XrCrossBandLine11.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        resources.ApplyResources(Me.XrCrossBandLine11, "XrCrossBandLine11")
        Me.XrCrossBandLine11.EndBand = Me.Detail
        Me.XrCrossBandLine11.Name = "XrCrossBandLine11"
        Me.XrCrossBandLine11.StartBand = Me.Detail
        Me.XrCrossBandLine11.WidthF = 3.527954!
        '
        'XrCrossBandLine12
        '
        Me.XrCrossBandLine12.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        resources.ApplyResources(Me.XrCrossBandLine12, "XrCrossBandLine12")
        Me.XrCrossBandLine12.EndBand = Me.PageFooter
        Me.XrCrossBandLine12.Name = "XrCrossBandLine12"
        Me.XrCrossBandLine12.StartBand = Me.Detail
        Me.XrCrossBandLine12.WidthF = 3.527832!
        '
        'report_Invoice
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMarginBand1, Me.BottomMarginBand1, Me.PageHeader, Me.PageFooter})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.reportName, Me.CalculatedField2, Me.CalculatedField6, Me.CalculatedField3, Me.CalculatedField5, Me.division_name, Me.department_name, Me.calContract_Name, Me.contract_at_str, Me.calAddress, Me.calDueDate, Me.calTotal})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandLine12, Me.XrCrossBandLine11, Me.XrCrossBandLine10, Me.XrCrossBandLine9, Me.XrCrossBandLine8, Me.XrCrossBandLine7, Me.XrCrossBandLine6, Me.XrCrossBandLine5, Me.XrCrossBandLine4, Me.XrCrossBandLine3, Me.XrCrossBandLine2, Me.XrCrossBandLine1, Me.XrCrossBandBox1})
        Me.DataMember = "Query"
        Me.DataSource = Me.SqlDataSource1
        resources.ApplyResources(Me, "$this")
        Me.FilterString = "[bookno] = 'V64' And [idno] = '104'"
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.hide_disPer, Me.hide_remark, Me.hide_disPer_bill, Me.hide_lastPage, Me.hide_Price, Me.hide_Tax, Me.h16, Me.h14, Me.d14})
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Headname, Me.companyname, Me.cCheckDate, Me.paradate, Me.fullname, Me.Lang})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField, Me.PageHeaderCaption, Me.PageHeaderField})
        Me.Version = "17.1"
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents reportName As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalculatedField2 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Headname As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents CalculatedField6 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalculatedField3 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cCheckDate As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents companyname As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents paradate As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents fullname As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents CalculatedField5 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents division_name As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents department_name As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Lang As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents h14 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents h16 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents d14 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents calContract_Name As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents contract_at_str As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel86 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel85 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel84 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel83 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel82 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents calAddress As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel88 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel87 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCrossBandBox1 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrCrossBandLine1 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents calDueDate As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrTable5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow11 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell37 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell38 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell49 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow12 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell39 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell40 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell41 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell42 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell43 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents calTotal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrCrossBandLine2 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCrossBandLine3 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine4 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine5 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine6 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine7 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine8 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrLine6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrCrossBandLine9 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine10 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine11 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine12 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel47 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel51 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel54 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel53 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel52 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel50 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel49 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel48 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrShape1 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents XrLabel56 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel55 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel58 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel57 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel59 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel42 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel60 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel67 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel63 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel71 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel61 As DevExpress.XtraReports.UI.XRLabel
End Class
