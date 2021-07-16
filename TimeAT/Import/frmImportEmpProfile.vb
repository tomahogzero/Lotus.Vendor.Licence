Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports TimeAttendance.utils
Imports System.IO

Public Class frmImportEmpProfile

    Private Sub frmImportEmpProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        With OpenFileDialog1
            .Filter = "Excel File |*.xls;*.xlsx"
            If .ShowDialog() = DialogResult.OK Then
                txtFileName.Text = .FileName
                'txtFileName.Text = Replace(.FileName.Trim, ".xls", "")
                If txtFileName.Text = "" Then
                    MsgManager.ShowDialog(Me, "frmImportEmpProfileRS", Me.Text, "Filename_is_emptry", MessageBoxIcon.Information)
                    '    Exit Sub
                End If
            Else
                txtFileName.Text = ""
            End If

        End With
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        If txtFileName.Text.Trim = "" Then
            MsgManager.ShowDialog(Me, "frmImportEmpProfileRS", Me.Text, "Filename_is_emptry", MessageBoxIcon.Information)
            Exit Sub
        End If

        If IO.File.Exists(txtFileName.Text.Trim) = False Then
            MsgManager.ShowDialog(Me, "frmImportEmpProfileRS", Me.Text, "Filename_is_null", MessageBoxIcon.Information)
            Exit Sub
        End If

        If IsNumeric(txtRowSt.Text) = False Then
            MsgManager.ShowDialog(Me, "frmImportEmpProfileRS", Me.Text, "Input_is_numeric", MessageBoxIcon.Information)
            Exit Sub
        End If

        If CInt(txtRowSt.Text) > CInt(txtRowSP.Text) Then
            MsgManager.ShowDialog(Me, "frmImportEmpProfileRS", Me.Text, "Input_rowst_morethan_rowsp", MessageBoxIcon.Information)
            Exit Sub
        End If

        btnImport.Enabled = False
        ImportProfile(txtFileName.Text.Trim, txtRowSt.Text, txtRowSP.Text)
        btnImport.Enabled = True
    End Sub

    Private Sub btnExportTemplate_Click(sender As Object, e As EventArgs) Handles btnExportTemplate.Click
        Dim fileName As String = ""
        With SaveFileDialog1
            .Filter = "Excel File |*.xls;*.xlsx"
            If .ShowDialog() = DialogResult.OK Then
                fileName = Replace(Replace(.FileName.Trim, ".xls", ""), ".xlsx", "")
                If fileName = "" Then
                    MsgManager.ShowDialog(Me, "frmImportEmpProfileRS", Me.Text, "Filename_is_emptry", MessageBoxIcon.Information)
                    Exit Sub
                End If

                btnExportTemplate.Enabled = False
                Call ExportProfile(fileName)
                btnExportTemplate.Enabled = True
            End If

        End With
    End Sub


    Private Sub ImportProfile(Filename As String, rw_st As Integer, rw_sp As Integer)
        System.Threading.Thread.CurrentThread.CurrentCulture =
        System.Globalization.CultureInfo.CreateSpecificCulture("en-US")

        Dim app As New Excel.Application
        Dim exbook As Excel.Workbook
        Dim exsheet As Excel.Worksheet

        exbook = app.Workbooks.Open(Filename)
        exsheet = exbook.Sheets(1)


        Dim arr() As String
        Dim list As ListViewItem

        lstEmpProfile.Items.Clear()

        ProgressBar1.Value = 0
        ProgressBar1.Maximum = rw_sp - rw_st + 1
        Dim ii As Integer = 0
        Dim i As Integer = 0
        For ii = rw_st To rw_sp
            ProgressBar1.Value += 1
            arr = New String() {exsheet.Cells(ii, 1).Value, "",
                               exsheet.Cells(ii, 2).Value,
                               exsheet.Cells(ii, 3).Value,
                               exsheet.Cells(ii, 4).Value,
                               exsheet.Cells(ii, 5).Value,
                               exsheet.Cells(ii, 6).Value,
                               exsheet.Cells(ii, 7).Value,
                               exsheet.Cells(ii, 8).Value,
                               exsheet.Cells(ii, 9).Value,
                               exsheet.Cells(ii, 10).Value,
                               exsheet.Cells(ii, 11).Value,
                               exsheet.Cells(ii, 12).Value,
                               exsheet.Cells(ii, 13).Value,
                               exsheet.Cells(ii, 14).Value,
                               exsheet.Cells(ii, 15).Value}
            list = New ListViewItem(arr)
            lstEmpProfile.Items.Add(list)
        Next

        exbook = Nothing
        exsheet = Nothing
        'app.Quit()
        'app = Nothing

        '    MsgBox("complete")
        '    Exit Sub
    End Sub

    Private Sub ExportProfile(Filename As String)
        System.Threading.Thread.CurrentThread.CurrentCulture =
        System.Globalization.CultureInfo.CreateSpecificCulture("en-US")

        Dim app As New Excel.Application
        Dim exbook As Excel.Workbook
        Dim exsheet As Excel.Worksheet

        exbook = app.Workbooks.Add
        exsheet = exbook.Sheets(1)
        Dim xx As Integer = 0
        Dim yy As Integer = 0
        exsheet.Range("A1", "FF200").Font.Size = 8

        ' Color

        exsheet.Cells(1, 1).value = "ที่"
        exsheet.Cells(1, 2).value = "รหัสพนักงาน"
        exsheet.Cells(1, 3).value = "คำนำหน้าชื่อ"
        exsheet.Cells(1, 4).value = "ชื่อ"
        exsheet.Cells(1, 5).value = "สกุล"
        exsheet.Cells(1, 6).value = "Title"
        exsheet.Cells(1, 7).value = "Firstname"
        exsheet.Cells(1, 8).value = "Lastname"
        exsheet.Cells(1, 9).value = "ชื่อเล่น"
        exsheet.Cells(1, 10).value = "Sex(M:ชาย,F:หญิง)"
        exsheet.Cells(1, 11).value = "ฝ่าย"
        exsheet.Cells(1, 12).value = "แผนก"
        exsheet.Cells(1, 13).value = "ส่วน"
        exsheet.Cells(1, 14).value = "ตำแหน่ง"
        exsheet.Cells(1, 15).value = "สถานะ(W:ทำงาน,T:ออกงาน)"

        ' set column
        CExcel.ExcelSetColumnWidth(exsheet, 1, 1, 3)
        CExcel.ExcelSetColumnWidth(exsheet, 1, 2, 7.5)
        CExcel.ExcelSetColumnWidth(exsheet, 1, 3, 8.5)
        CExcel.ExcelSetColumnWidth(exsheet, 1, 4, 15)
        CExcel.ExcelSetColumnWidth(exsheet, 1, 5, 12)
        CExcel.ExcelSetColumnWidth(exsheet, 1, 6, 5)
        CExcel.ExcelSetColumnWidth(exsheet, 1, 7, 16)
        CExcel.ExcelSetColumnWidth(exsheet, 1, 8, 9)
        CExcel.ExcelSetColumnWidth(exsheet, 1, 9, 6)
        CExcel.ExcelSetColumnWidth(exsheet, 1, 10, 12)
        CExcel.ExcelSetColumnWidth(exsheet, 1, 11, 12)
        CExcel.ExcelSetColumnWidth(exsheet, 1, 12, 12)
        CExcel.ExcelSetColumnWidth(exsheet, 1, 13, 12)
        CExcel.ExcelSetColumnWidth(exsheet, 1, 14, 25)
        CExcel.ExcelSetColumnWidth(exsheet, 1, 15, 5)


        Dim dtEmp As DataTable = getEmpProfile()

        ProgressBar1.Value = 0
        ProgressBar1.Maximum = dtEmp.Rows.Count
        Dim i As Integer = 0
        Dim rw As Integer = 1
        For Each dr As DataRow In dtEmp.Rows
            i += 1
            rw += 1
            ProgressBar1.Value += 1

            exsheet.Cells(rw, 1).value = i
            exsheet.Cells(rw, 2).value = dr("code")
            exsheet.Cells(rw, 3).value = dr("Title")
            exsheet.Cells(rw, 4).value = dr("Fname")
            exsheet.Cells(rw, 5).value = dr("Lname")
            exsheet.Cells(rw, 6).value = dr("TitleEng")
            exsheet.Cells(rw, 7).value = dr("FnameEng")
            exsheet.Cells(rw, 8).value = dr("LnameEng")
            exsheet.Cells(rw, 9).value = dr("NickName")
            exsheet.Cells(rw, 10).value = dr("Sex")
            exsheet.Cells(rw, 11).value = dr("Division")
            exsheet.Cells(rw, 12).value = dr("Department")
            exsheet.Cells(rw, 13).value = dr("Section")
            exsheet.Cells(rw, 14).value = dr("Position")
            exsheet.Cells(rw, 15).value = dr("WorkStatus")
        Next
        'Summary reports T / R year 2011.

        '' Gen Head
        'With lstTimework
        '    ' Gen Head
        '    For i As Integer = 0 To .Columns.Count - 1
        '        exsheet.Cells(5, i + 1).value = .Columns(i).Text.Trim
        '        Select Case i
        '            Case 0
        '                CExcel.ExcelSetColumnWidth(exsheet, 5, i + 1, 5)
        '            Case 1
        '                CExcel.ExcelSetColumnWidth(exsheet, 5, i + 1, 10)
        '            Case 2
        '                CExcel.ExcelSetColumnWidth(exsheet, 5, i + 1, 10)
        '            Case 3
        '                CExcel.ExcelSetColumnWidth(exsheet, 5, i + 1, 25)
        '            Case 4
        '                CExcel.ExcelSetColumnWidth(exsheet, 5, i + 1, 10)
        '            Case Else
        '                CExcel.ExcelSetColumnWidth(exsheet, 5, i + 1, 8)
        '        End Select
        '        CExcel.ExcelBoarder(exsheet, 5, i + 1, 5, i + 1, False)
        '        CExcel.GenCenterAlignmentCenter(exsheet, 5, i + 1, 5, i + 1)
        '    Next
        '    ' Gen Date
        '    For r As Integer = 0 To .Items.Count - 1
        '        Dim row As Integer = r + 6
        '        For c As Integer = 0 To .Columns.Count - 1
        '            Dim col As Integer = c + 1
        '            Dim strText As String = ""
        '            Select Case c
        '                Case 0
        '                    CExcel.GenCenterAlignmentCenter(exsheet, row, col, row, col)
        '                Case 1
        '                    CExcel.GenCenterAlignmentCenter(exsheet, row, col, row, col)
        '                Case 2
        '                    CExcel.GenCenterAlignmentCenter(exsheet, row, col, row, col)
        '                    strText = "'"
        '                Case 3
        '                    CExcel.GenCenterAlignmentLeft(exsheet, row, col, row, col)
        '                Case 4
        '                    CExcel.GenCenterAlignmentCenter(exsheet, row, col, row, col)
        '                    strText = "'"
        '                Case Else
        '                    CExcel.GenCenterAlignmentCenter(exsheet, row, col, row, col)
        '            End Select
        '            exsheet.Cells(row, col).value = strText & .Items(r).SubItems(c).Text.Trim
        '            CExcel.ExcelBoarder(exsheet, row, col, row, col, False)
        '        Next
        '    Next
        'End With


        ' Save Detail ด้านล่าง
        exbook.SaveAs(Filename.Trim & ".xls")
        app.Visible = True

        exbook = Nothing
        exsheet = Nothing
        'app.Quit()
        'app = Nothing

        '    MsgBox("complete")
        '    Exit Sub
    End Sub

    Function getEmpProfile() As DataTable
        Dim ds As New DataSet
        Dim da As SqlDataAdapter

        Dim db As New DBManager
        Dim sql As String

        sql = "select emp.Code" &
                    " ,emp.Title,emp.Fname,emp.Lname,emp.NickName" &
                    " ,emp.TitleEng,emp.FnameEng,emp.LnameEng" &
                    " ,Sex" &
                    " ,Department.DivId,div.Division" &
                    " ,emp.DeptId,dept.Department" &
                    " ,emp.SecId,sec.Section" &
                    " ,emp.Position" &
                    " ,emp.WorkStatus" &
                " From Emp emp" &
                    " left join Department" &
                        " On emp.DeptId = dept.DeptId" &
                    " left join Division div" &
                        " On Department.DivId = div.DivId" &
                    " left join Section sec" &
                        " on emp.SecId = sec.SecId"

        Try
            da = New SqlDataAdapter(sql, Conn)
            da.Fill(ds, "data")


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Return Nothing
            Exit Function
        End Try
        Return ds.Tables("data")
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        btnSave.Enabled=False
        For i As Integer = 0 To lstEmpProfile.Items.Count - 1
            Dim sql As String
            Dim dcmd As New SqlCommand
            Dim da As New SqlDataAdapter
            Dim ds As New DataSet

            With lstEmpProfile
                sql = "exec spImportEmpProfile '" & .Items(i).SubItems(2).Text.Trim & "'," &
                            "'" & .Items(i).SubItems(3).Text.Trim & "'," &
                            "'" & .Items(i).SubItems(4).Text.Trim & "'," &
                            "'" & .Items(i).SubItems(5).Text.Trim & "'," &
                            "'" & .Items(i).SubItems(6).Text.Trim & "'," &
                            "'" & .Items(i).SubItems(7).Text.Trim & "'," &
                            "'" & .Items(i).SubItems(8).Text.Trim & "'," &
                            "'" & .Items(i).SubItems(9).Text.Trim & "'," &
                            "'" & .Items(i).SubItems(10).Text.Trim & "'," &
                            "'" & .Items(i).SubItems(11).Text.Trim & "'," &
                            "'" & .Items(i).SubItems(12).Text.Trim & "'," &
                            "'" & .Items(i).SubItems(13).Text.Trim & "'," &
                            "'" & .Items(i).SubItems(14).Text.Trim & "'," &
                            "'" & .Items(i).SubItems(15).Text.Trim & "','T'"
                dcmd.Connection = Conn
                dcmd.CommandText = sql
                da.SelectCommand = dcmd
                da.Fill(ds, "data")
            End With

            With ds.Tables("data")
                If .Rows.Count > 0 Then
                    Dim rt As String = .Rows(0).Item("Result")

                    lstEmpProfile.Items(i).SubItems(1).Text = rt
                End If
            End With

        Next

        btnSave.Enabled = True
    End Sub
End Class