Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports TimeAttendance.utils


Public Class frmReportYearlySumary

    Private Sub frmReportYearlySumary_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        fReportYearlySumary = Nothing
    End Sub

    Private Sub frmReportYearlySumary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        System.Threading.Thread.CurrentThread.CurrentCulture = _
        System.Globalization.CultureInfo.CreateSpecificCulture("en-US")

        Dim app As New Excel.Application
        Dim exbook As Excel.Workbook
        Dim exsheet As Excel.Worksheet


        btnReport.Text = "���ѡ����...."
        btnReport.Enabled = False

        exbook = app.Workbooks.Add
        exsheet = exbook.Sheets(1)

        exsheet.Range("A1", "FF200").Font.Size = 8
        exsheet.Range("A4", "FF5").HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
        exsheet.Range("A4", "D6").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        ' Set Column Width
        exsheet.Range("A1").ColumnWidth = 3
        exsheet.Range("B1").ColumnWidth = 5
        exsheet.Range("C1").ColumnWidth = 13
        exsheet.Range("D1").ColumnWidth = 13

        exsheet.Range("E1", "FF1").ColumnWidth = 5

        exsheet.Cells(1, 1).value = "�ç�ӧҹૹ���Ť͹�ǹ��"
        exsheet.Cells(2, 1).value = "��ػ�ʹ��Шӻ� " & txtYear.Text.Trim

        exsheet.Cells(5, 1).value = "NO."
        exsheet.Cells(5, 2).value = "Code"
        exsheet.Cells(5, 3).value = "���� - ʡ��"
        exsheet.Range("C5", "D5").Merge(1)

        exsheet.Cells(4, 5).value = "�.�."
        exsheet.Range(GenColumnExcel(5, 4), GenColumnExcel(8, 4)).Merge(1)
        exsheet.Cells(5, 5).value = "��"
        exsheet.Cells(5, 6).value = "���"
        exsheet.Cells(5, 7).value = "��"
        exsheet.Cells(5, 8).value = "�Ҵ"

        exsheet.Cells(4, 9).value = "��.�."
        exsheet.Range(GenColumnExcel(9, 4), GenColumnExcel(12, 4)).Merge(1)
        exsheet.Cells(5, 9).value = "��"
        exsheet.Cells(5, 10).value = "���"
        exsheet.Cells(5, 11).value = "��"
        exsheet.Cells(5, 12).value = "�Ҵ"

        exsheet.Cells(4, 13).value = "�.�."
        exsheet.Range(GenColumnExcel(13, 4), GenColumnExcel(16, 4)).Merge(1)
        exsheet.Cells(5, 13).value = "��"
        exsheet.Cells(5, 14).value = "���"
        exsheet.Cells(5, 15).value = "��"
        exsheet.Cells(5, 16).value = "�Ҵ"

        exsheet.Cells(4, 17).value = "�.�."
        exsheet.Range(GenColumnExcel(17, 4), GenColumnExcel(20, 4)).Merge(1)
        exsheet.Cells(5, 17).value = "��"
        exsheet.Cells(5, 18).value = "���"
        exsheet.Cells(5, 19).value = "��"
        exsheet.Cells(5, 20).value = "�Ҵ"

        exsheet.Cells(4, 21).value = "�.�."
        exsheet.Range(GenColumnExcel(21, 4), GenColumnExcel(24, 4)).Merge(1)
        exsheet.Cells(5, 21).value = "��"
        exsheet.Cells(5, 22).value = "���"
        exsheet.Cells(5, 23).value = "��"
        exsheet.Cells(5, 24).value = "�Ҵ"

        exsheet.Cells(4, 25).value = "�.�."
        exsheet.Range(GenColumnExcel(25, 4), GenColumnExcel(28, 4)).Merge(1)
        exsheet.Cells(5, 25).value = "��"
        exsheet.Cells(5, 26).value = "���"
        exsheet.Cells(5, 27).value = "��"
        exsheet.Cells(5, 28).value = "�Ҵ"

        exsheet.Cells(4, 29).value = "�.�."
        exsheet.Range(GenColumnExcel(29, 4), GenColumnExcel(32, 4)).Merge(1)
        exsheet.Cells(5, 29).value = "��"
        exsheet.Cells(5, 30).value = "���"
        exsheet.Cells(5, 31).value = "��"
        exsheet.Cells(5, 32).value = "�Ҵ"

        exsheet.Cells(4, 33).value = "�.�."
        exsheet.Range(GenColumnExcel(33, 4), GenColumnExcel(36, 4)).Merge(1)
        exsheet.Cells(5, 33).value = "��"
        exsheet.Cells(5, 34).value = "���"
        exsheet.Cells(5, 35).value = "��"
        exsheet.Cells(5, 36).value = "�Ҵ"

        exsheet.Cells(4, 37).value = "�.�."
        exsheet.Range(GenColumnExcel(37, 4), GenColumnExcel(40, 4)).Merge(1)
        exsheet.Cells(5, 37).value = "��"
        exsheet.Cells(5, 38).value = "���"
        exsheet.Cells(5, 39).value = "��"
        exsheet.Cells(5, 40).value = "�Ҵ"

        exsheet.Cells(4, 41).value = "�.�."
        exsheet.Range(GenColumnExcel(41, 4), GenColumnExcel(44, 4)).Merge(1)
        exsheet.Cells(5, 41).value = "��"
        exsheet.Cells(5, 42).value = "���"
        exsheet.Cells(5, 43).value = "��"
        exsheet.Cells(5, 44).value = "�Ҵ"

        exsheet.Cells(4, 45).value = "��.�."
        exsheet.Range(GenColumnExcel(45, 4), GenColumnExcel(48, 4)).Merge(1)
        exsheet.Cells(5, 45).value = "��"
        exsheet.Cells(5, 46).value = "���"
        exsheet.Cells(5, 47).value = "��"
        exsheet.Cells(5, 48).value = "�Ҵ"

        exsheet.Cells(4, 49).value = "��.�."
        exsheet.Range(GenColumnExcel(49, 4), GenColumnExcel(52, 4)).Merge(1)
        exsheet.Cells(5, 49).value = "��"
        exsheet.Cells(5, 50).value = "���"
        exsheet.Cells(5, 51).value = "��"
        exsheet.Cells(5, 52).value = "�Ҵ"


        ' Load �Ԫ� / ˹��¡Ԩ
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim CurRow As Integer
        Dim I As Integer
        Dim J As Integer
        strSQL = "Exec spTimeSumaryAllYear '" & txtYear.Text.Trim & "'"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            CurRow = 6
            For I = 0 To .Rows.Count - 1
                exsheet.Cells(CurRow + I, 1).value = I + 1
                exsheet.Cells(CurRow + I, 2).value = "'" & .Rows(I).Item(0)
                For J = 1 To 50
                    exsheet.Cells(CurRow + I, J + 2).value = .Rows(I).Item(J)
                Next
            Next
        End With

        btnReport.Text = "��§ҹ"
        btnReport.Enabled = True

        Dim FileName As String
        With SaveFileDialog1
            .Filter = "Excel File |*.XLS"
            .ShowDialog()
            FileName = Replace(.FileName.Trim, ".xls", "")
            If FileName.Trim = "" Then
                'MsgBox("��سһ�͹����������", MsgBoxStyle.Information, Me.Text)
                MsgManager.ShowDialog(Me, "frmRPTTimeworkSumaryByWeekRS", Me.Text, "Insert_FineName", MessageBoxIcon.Information)
                Exit Sub
            End If
        End With
        exbook.SaveAs(FileName.Trim)
        app.Visible = True

        exbook = Nothing
        exsheet = Nothing
    End Sub

    Function FirstChar(ByVal Col As Integer) As String
        Dim MaxChr As Integer = 26
        If Col \ MaxChr > 1 Or (Col \ MaxChr = 1 And Col Mod MaxChr <> 0) Then
            If (Col Mod MaxChr = 0) And Col \ MaxChr > 1 Then
                Return Chr((Asc("A") - 2) + (Col \ MaxChr))
            Else
                Return Chr((Asc("A") - 1) + (Col \ MaxChr))
            End If
        Else
            Return ""
        End If
    End Function

    Function GenColumnExcel(ByVal Col As Integer, ByVal Row As Integer) As String
        Dim IntColumn As Integer
        IntColumn = (Asc("A") - 1) + ((IIf(Col Mod 26 = 0, 26, Col Mod 26)))
        Return FirstChar(Col) & Chr(IntColumn) & Row
    End Function
End Class