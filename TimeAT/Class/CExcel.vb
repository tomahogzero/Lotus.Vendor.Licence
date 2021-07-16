Imports Microsoft.Office.Interop

Public Class CExcel
    Public Shared Function FirstChar(ByVal Col As Integer) As String
        Dim MaxChr As Integer = 26
        Dim FirstChar_Col As Integer = Col \ 26

        If Col \ 26 = 0 Then
            Return ""
        ElseIf Col \ 26 = 1 And Col Mod 26 = 0 Then
            Return ""
        ElseIf Col \ 26 > 1 And Col Mod 26 = 0 Then
            Return Chr((Asc("A") - 1) + FirstChar_Col - 1)
        Else
            Return Chr((Asc("A") - 1) + FirstChar_Col)
        End If
    End Function

    Public Shared Function GenColumnExcel(ByVal Row As Integer, ByVal Col As Integer) As String
        Dim IntColumn As Integer
        IntColumn = (Asc("A") - 1) + ((IIf(Col Mod 26 = 0, 26, Col Mod 26)))
        Return FirstChar(Col) & Chr(IntColumn) & Row
    End Function

    Public Shared Sub ExcelSetColumnWidth(ByVal ex As Excel.Worksheet, ByVal Row As Integer, ByVal Col As Integer, ByVal ColumnWidth As Double)
        ex.Range(GenColumnExcel(Row, Col)).ColumnWidth = ColumnWidth
    End Sub

    Public Shared Sub ExcelSetFontBold(ByVal ex As Excel.Worksheet, ByVal Row As Integer, ByVal Col As Integer)
        ex.Range(GenColumnExcel(Row, Col)).Font.Bold = True
    End Sub

    Public Shared Sub ExcelMeargeColumn(ByVal ex As Excel.Worksheet, ByVal RowFrom As Integer, ByVal ColFrom As Integer, ByVal RowTo As Integer, ByVal ColTo As Integer)
        ex.Range(GenColumnExcel(RowFrom, ColFrom), GenColumnExcel(RowTo, ColTo)).Merge()
    End Sub

    Public Shared Sub GenCenterAlignmentCenter(ByVal ex As Excel.Worksheet, ByVal RowFrom As Integer, ByVal ColFrom As Integer, ByVal RowTo As Integer, ByVal ColTo As Integer)
        ex.Range(GenColumnExcel(RowFrom, ColFrom), GenColumnExcel(RowTo, ColTo)).HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
        ex.Range(GenColumnExcel(RowFrom, ColFrom), GenColumnExcel(RowTo, ColTo)).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    End Sub

    Public Shared Sub GenCenterAlignmentRight(ByVal ex As Excel.Worksheet, ByVal RowFrom As Integer, ByVal ColFrom As Integer, ByVal RowTo As Integer, ByVal ColTo As Integer)
        ex.Range(GenColumnExcel(RowFrom, ColFrom), GenColumnExcel(RowTo, ColTo)).HorizontalAlignment = HorizontalAlignment.Right
        ex.Range(GenColumnExcel(RowFrom, ColFrom), GenColumnExcel(RowTo, ColTo)).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    End Sub

    Public Shared Sub GenCenterAlignmentLeft(ByVal ex As Excel.Worksheet, ByVal RowFrom As Integer, ByVal ColFrom As Integer, ByVal RowTo As Integer, ByVal ColTo As Integer)
        ex.Range(GenColumnExcel(RowFrom, ColFrom), GenColumnExcel(RowTo, ColTo)).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        ex.Range(GenColumnExcel(RowFrom, ColFrom), GenColumnExcel(RowTo, ColTo)).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    End Sub

    Public Shared Sub ExcelFormatNumber(ByVal ex As Excel.Worksheet, ByVal RowFrom As Integer, ByVal ColFrom As Integer, ByVal RowTo As Integer, ByVal ColTo As Integer)
        ex.Range(GenColumnExcel(RowFrom, ColFrom), GenColumnExcel(RowTo, ColTo)).NumberFormat = "#,##0.00"
    End Sub

    Public Shared Sub ExcelFormatDate(ByVal ex As Excel.Worksheet, ByVal RowFrom As Integer, ByVal ColFrom As Integer, ByVal RowTo As Integer, ByVal ColTo As Integer)
        ex.Range(GenColumnExcel(RowFrom, ColFrom), GenColumnExcel(RowTo, ColTo)).NumberFormat = "dd/MM/yyyy;@"
    End Sub

    Public Shared Sub ExcelBoarder(ByVal ex As Excel.Worksheet, ByVal RowFrom As Integer, ByVal ColFrom As Integer, ByVal RowTo As Integer, ByVal ColTo As Integer)
        With ex.Range(GenColumnExcel(RowFrom, ColFrom), GenColumnExcel(RowTo, ColTo))
            '.Borders.ColorIndex = 0
            '.Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            '.Borders(Excel.XlBordersIndex.xlInsideHorizontal).Weight = Excel.XlBorderWeight.xlThin
            '.Borders(Excel.XlBordersIndex.xlInsideVertical).Weight = Excel.XlBorderWeight.xlThin
            '.Interior.Color = ColorTranslator.ToOle(Color.Yellow)

            .Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin
            .Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlThin
            .Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = Excel.XlBorderWeight.xlThin
            .Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = Excel.XlBorderWeight.xlThin
        End With
    End Sub

    Public Shared Sub ExcelBoarder(ByVal ex As Excel.Worksheet, ByVal RowFrom As Integer, ByVal ColFrom As Integer, ByVal RowTo As Integer, ByVal ColTo As Integer, ByVal BGColor As Color, ByVal Boarder As Boolean)
        With ex.Range(GenColumnExcel(RowFrom, ColFrom), GenColumnExcel(RowTo, ColTo))
            'If LineInner = True Then
            '    .Borders.ColorIndex = 0
            'End If

            '.Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            '.Borders(Excel.XlBordersIndex.xlInsideHorizontal).Weight = Excel.XlBorderWeight.xlThin
            '.Borders(Excel.XlBordersIndex.xlInsideVertical).Weight = Excel.XlBorderWeight.xlThin
            .Interior.Color = ColorTranslator.ToOle(BGColor)

            If Boarder = True Then
                .Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin
                .Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlThin
                .Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = Excel.XlBorderWeight.xlThin
                .Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = Excel.XlBorderWeight.xlThin
            End If
        End With
    End Sub

    Public Shared Sub ExcelBoarder(ByVal ex As Excel.Worksheet, ByVal RowFrom As Integer, ByVal ColFrom As Integer, ByVal RowTo As Integer, ByVal ColTo As Integer, ByVal BGColor As Color, ByVal Boarder As Boolean, ByVal LineInner As Boolean)
        With ex.Range(GenColumnExcel(RowFrom, ColFrom), GenColumnExcel(RowTo, ColTo))
            If LineInner = True Then
                .Borders.ColorIndex = 0
            End If

            '.Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            '.Borders(Excel.XlBordersIndex.xlInsideHorizontal).Weight = Excel.XlBorderWeight.xlThin
            '.Borders(Excel.XlBordersIndex.xlInsideVertical).Weight = Excel.XlBorderWeight.xlThin
            .Interior.Color = ColorTranslator.ToOle(BGColor)

            If Boarder = True Then
                .Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin
                .Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlThin
                .Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = Excel.XlBorderWeight.xlThin
                .Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = Excel.XlBorderWeight.xlThin
            End If
        End With
    End Sub

    Public Shared Sub ExcelBoarder(ByVal ex As Excel.Worksheet, ByVal RowFrom As Integer, ByVal ColFrom As Integer, ByVal RowTo As Integer, ByVal ColTo As Integer, ByVal Boarder As Boolean)
        With ex.Range(GenColumnExcel(RowFrom, ColFrom), GenColumnExcel(RowTo, ColTo))
            'If LineInner = True Then
            '    .Borders.ColorIndex = 0
            'End If

            '.Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            '.Borders(Excel.XlBordersIndex.xlInsideHorizontal).Weight = Excel.XlBorderWeight.xlThin
            '.Borders(Excel.XlBordersIndex.xlInsideVertical).Weight = Excel.XlBorderWeight.xlThin

            If Boarder = True Then
                .Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin
                .Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlThin
                .Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = Excel.XlBorderWeight.xlThin
                .Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = Excel.XlBorderWeight.xlThin
            End If
        End With
    End Sub

    Public Shared Sub ExcelBoarder(ByVal ex As Excel.Worksheet, ByVal RowFrom As Integer, ByVal ColFrom As Integer, ByVal RowTo As Integer, ByVal ColTo As Integer, ByVal Boarder As Boolean, ByVal LineInner As Boolean)
        With ex.Range(GenColumnExcel(RowFrom, ColFrom), GenColumnExcel(RowTo, ColTo))
            If LineInner = True Then
                .Borders.ColorIndex = 0
            End If

            '.Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            '.Borders(Excel.XlBordersIndex.xlInsideHorizontal).Weight = Excel.XlBorderWeight.xlThin
            '.Borders(Excel.XlBordersIndex.xlInsideVertical).Weight = Excel.XlBorderWeight.xlThin

            If Boarder = True Then
                .Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin
                .Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlThin
                .Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = Excel.XlBorderWeight.xlThin
                .Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = Excel.XlBorderWeight.xlThin
            End If
        End With
    End Sub

    '       With exsheet.Range(CExcel.GenColumnExcel(4, 1), CExcel.GenColumnExcel(4, Col + 1))
    '        .Borders.ColorIndex = 0 'ขนาด Barder 0 ก็มีเส้น
    ''.Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
    '        .Borders(Excel.XlBordersIndex.xlInsideHorizontal).Weight = Excel.XlBorderWeight.xlThick
    '        .Interior.Color = ColorTranslator.ToOle(Color.Yellow) ป้อนสีพื้น 
    '    End With

End Class
