Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports TimeAttendance.utils
Imports System.Threading

Public Class frmEmpSetTimeByDate

    Dim lblDay As New ArrayList
    Dim dsEmpKa As DataSet

    Dim IsloadMonth As Boolean = False
    Dim trdLoadControlDay As New Thread(AddressOf LoadControlDay)
    Dim trdLoadMonthDetail As New Thread(AddressOf LoadMonthDetail)
    Dim trdClearDayBG As New Thread(AddressOf ClearDayBG)


    Private Sub frmEmpSetTimeByDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBarX1.Visible = False
        ProgressBarX2.Visible = False

        'trdLoadControlDay.Start()

        txtYear.Text = Now.Year
        'Call LoadMonth()
        '  cboMonth.SelectedIndex = Now.Month - 1
        Call SearchData.LoadMonth(cboMonth, False, True)


        Call LoadKA()

        Call SearchData.LoadDivision(Me, cboDivision, True)
        Call SearchData.LoadDepartment(Me, cboDepartment, "", True)

        Call LoadEmpKa()
    End Sub

    Private Sub LoadDepartment()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select Department " &
                " From Department " &
                " Order By Department"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            cboDepartment.Properties.Items.Clear()
            cboDepartment.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            For Each dr As DataRow In .Rows
                cboDepartment.Properties.Items.Add(dr("Department"))
            Next
            cboDepartment.SelectedIndex = 0
        End With
    End Sub

    Private Sub LoadDivision()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select Division " &
                " From Division " &
                " Order By Division"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            cboDivision.Properties.Items.Clear()
            cboDivision.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))

            For Each dr As DataRow In .Rows
                cboDivision.Properties.Items.Add(dr("Division"))
            Next
            cboDivision.SelectedIndex = 0
        End With
    End Sub

    Private Sub LoadMonth()
        IsloadMonth = True
        cboMonth.Properties.Items.Clear()
        For i As Integer = 1 To 12
            cboMonth.Properties.Items.Add(MonthNameThaiLang(i))
        Next
        IsloadMonth = False
    End Sub

    Private Sub LoadControlDay()
        'lblDay.Clear()
        'lblDay.Add(lbl1)
        'lblDay.Add(lbl2)
        'lblDay.Add(lbl3)
        'lblDay.Add(lbl4)
        'lblDay.Add(lbl5)

        'lblDay.Add(lbl6)
        'lblDay.Add(lbl7)
        'lblDay.Add(lbl8)
        'lblDay.Add(lbl9)
        'lblDay.Add(lbl10)

        'lblDay.Add(lbl11)
        'lblDay.Add(lbl12)
        'lblDay.Add(lbl13)
        'lblDay.Add(lbl14)
        'lblDay.Add(lbl15)

        'lblDay.Add(lbl16)
        'lblDay.Add(lbl17)
        'lblDay.Add(lbl18)
        'lblDay.Add(lbl19)
        'lblDay.Add(lbl20)

        'lblDay.Add(lbl21)
        'lblDay.Add(lbl22)
        'lblDay.Add(lbl23)
        'lblDay.Add(lbl24)
        'lblDay.Add(lbl25)

        'lblDay.Add(lbl26)
        'lblDay.Add(lbl27)
        'lblDay.Add(lbl28)
        'lblDay.Add(lbl29)
        'lblDay.Add(lbl30)

        'lblDay.Add(lbl31)
        'lblDay.Add(lbl32)
        'lblDay.Add(lbl33)
        'lblDay.Add(lbl34)
        'lblDay.Add(lbl35)

        'lblDay.Add(lbl36)
        'lblDay.Add(lbl37)
        'lblDay.Add(lbl38)
        'lblDay.Add(lbl39)
        'lblDay.Add(lbl40)

        'lblDay.Add(lbl41)
        'lblDay.Add(lbl42)

        'trdLoadControlDay.Abort()
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMonth.SelectedIndexChanged
        If IsloadMonth = False Then
            'trdLoadMonthDetail.Start()
            'trdClearDayBG.Start()
            Call LoadMonthDetail()
            'Call ClearDayBG()
        End If
    End Sub

    Private Sub LoadMonthDetail()
        If IsDate(txtYear.Text & "/" & cboMonth.SelectedIndex + 1 & "/01") = False Then Exit Sub
        Dim dDate As Date = txtYear.Text & "/" & Format(cboMonth.SelectedIndex + 1, "00") & "/01"
        'Dim StartDay As Integer = dDate.DayOfWeek
        'Dim endMonth As Integer = MonthEnd(dDate).Day


        cd_month.EditValue = dDate



        'grpCarlendar.Text = " ปฏิทิน เดือน " & cboMonth.Text.Trim & " " & txtYear.Text.Trim

        'Dim nDay As Integer = 0
        'For i As Integer = 0 To 41
        '    If i >= StartDay And i < StartDay + endMonth Then
        '        nDay += 1
        '        CType(lblDay(i), Label).Text = nDay
        '    Else
        '        CType(lblDay(i), Label).Text = ""
        '    End If
        'Next

        'trdLoadMonthDetail.Abort()
    End Sub

    Private Sub lbl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim lblControl As Label = CType(sender, Label)

        If lblControl.Text.Trim <> "" Then
            If lblControl.BackColor = Color.YellowGreen Then
                lblControl.BackColor = Color.Transparent
            Else
                lblControl.BackColor = Color.YellowGreen
            End If
        End If
    End Sub

    Private Sub ClearDayBG()
        For i As Integer = 0 To 41
            CType(lblDay(i), Label).BackColor = Color.Transparent
        Next

        trdClearDayBG.Abort()
    End Sub

    Private Sub LoadKA()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select Ka_Code,KaName From TimeKa Where isnull(ka_flexible,0) = 0 Order By KaName"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                cboKa.Properties.Items.Clear()
            Else
                cboKa.Properties.Items.Clear()
                For Each dr As DataRow In .Rows
                    cboKa.Properties.Items.Add(dr("KaName"))
                Next
            End If
        End With
    End Sub

    Function GetKaCode(ByVal KaName As String) As String
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select Ka_Code,KaName " &
                " From TimeKa " &
                " Where KaName = '" & KaName.Trim & "'"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("Ka_Code")
            End If
        End With
    End Function

    Private Sub LoadEmp()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""


        strSQL = "Select row_number() over("
        strSQL &= LoadEmp_order_by()
        strSQL &= " ) As row," &
                        " Emp.Code,"

        If cValGolbal.Lang = "TH" Then
            strSQL &= "isnull(Emp.title,'') + isnull(emp.Fname,'') as Fname"
        Else
            strSQL &= "isnull(Emp.title,'') + ' ' + isnull(emp.Fname,'') as Fname"
        End If

        strSQL &= ",Lname, " &
                        " Division = Isnull(Div.Division,''), " &
                        " Department = Isnull(Department.Department,''), " &
                        " Position = Isnull(Emp.Position,'')" &
                " From Emp Left Join Department " &
                            " On Emp.DeptId = Department.DeptId " &
                        " Left Join Division Div " &
                            " On Department.DivId = Div.DivId " &
                " Where WorkStatus = 'W' "

        If rdGPByDate.Checked = True Then
            strSQL &= " and Isnull(UseKaDate,0) = 1 "
        ElseIf rdGP_Normal.Checked = True Then
            strSQL &= " and Isnull(UseKaDate,0) = 0 "
        End If


        If cboDivision.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Department.DivId,'') = '" & GetData.GetDivisionId(cboDivision.Text.Trim) & "'"
        End If

        If cboDepartment.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Emp.DeptId,'') = '" & GetData.GetDepartmentId(cboDepartment.Text.Trim) & "'"
        End If


        strSQL &= LoadEmp_order_by()

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")


        GcEmp.DataSource = Ds
        GcEmp.DataMember = "Data"
    End Sub

    Function LoadEmp_order_by() As String
        Dim query As String = ""
        If rdByCode.Checked = True Then
            query &= " Order By Emp.Code"
        End If

        If rdByName.Checked = True Then
            query &= " Order By Fname,Lname"
        End If

        If rdByDeptCode.Checked = True Then
            query &= " Order By Div.Division,Department.Department,Fname,Lname"
        End If

        If rdByDeptName.Checked = True Then
            query &= " Order By Div.Division,Department.Department,Fname,Lname"
        End If
        Return query
    End Function

    Private Sub LoadEmpKa()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""

        strSQL = "Select top 0 ROW_NUMBER() OVER(ORDER BY Code) as row, " &
                " Code,Fname,Lname,Department = '',Division='',Position='' " &
                " From Emp " &
                " Order By Code"

        'strSQL = "Select ROW_NUMBER() OVER(ORDER BY Code) as row, " &
        '        " Code,Fname,Lname,Department " &
        '        " From Emp " &
        '        " Where Code In " &
        '                " (Select Code From TimeEmpKa" &
        '                " Where Ka_Code = '" & Ka_Code.Trim & "')" &
        '        " Order By Code"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        dsEmpKa = Ds

        GcEmpKa.DataSource = Ds
        GcEmpKa.DataMember = "Data"
    End Sub


    Private Sub cboKa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboKa.SelectedIndexChanged
        lblKaCode.Text = GetKaCode(cboKa.Text.Trim).Trim
        'Call LoadEmpKa(lblKaCode.Text.Trim)
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        btnRefresh.Enabled = False
        Application.DoEvents()
        Call LoadEmp()
        btnRefresh.Enabled = True
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        '  Dim List As ListViewItem
        '     Dim arrDATA() As String
        '     With lstEmp
        'For i As Integer = 0 To .CheckedItems.Count - 1
        '    If CheckDataListIsExist(.CheckedItems(i).SubItems(1).Text.Trim) = False Then
        '        arrDATA = New String() {lstEmpKa.Items.Count + 1,
        '                                .CheckedItems(i).SubItems(1).Text.Trim,
        '                                .CheckedItems(i).SubItems(2).Text.Trim,
        '                                .CheckedItems(i).SubItems(3).Text.Trim,
        '                                .CheckedItems(i).SubItems(4).Text.Trim}
        '        List = New ListViewItem(arrDATA)
        '        lstEmpKa.Items.Add(List)
        '    End If
        'Next

        ProgressBarX1.Visible = True
        ProgressBarX2.Visible = True
        btnAdd.Enabled = False
        btnRemove.Enabled = False


        ProgressBarX1.Value = 0
        ProgressBarX1.Maximum = GvEmp.GetSelectedRows.Count - 1

        dsEmpKa.Tables(0).Clear()
        dsEmpKa.Tables(0).BeginInit()

        For Each i As Long In GvEmp.GetSelectedRows

            Dim dr As DataRow = GvEmp.GetDataRow(i)
            ProgressBarX1.Value = i + 1
            ProgressBarX1.Text = i & "/" & ProgressBarX1.Maximum
            'Application.DoEvents()

            'With dsEmpKa.Tables(0)
            '    Dim drS() As DataRow = .Select("Code = '" & dr("Code") & "'")

            '    If drS.Count = 0 Then
            Dim ndr As DataRow = dsEmpKa.Tables(0).NewRow()
            ndr("row") = dsEmpKa.Tables(0).Rows.Count + 1
            ndr("Code") = dr("Code")
            ndr("Fname") = dr("Fname")
            ndr("Lname") = dr("Lname")
            ndr("Department") = dr("Department")
            ndr("Division") = dr("Division")
            ndr("Position") = dr("Position")
            dsEmpKa.Tables(0).Rows.Add(ndr)
            '    End If


            'End With


            '        arrDATA = New String() {lstEmpKa.Items.Count + 1,
            '                                .CheckedItems(i).SubItems(1).Text.Trim,
            '                                .CheckedItems(i).SubItems(2).Text.Trim,
            '                                .CheckedItems(i).SubItems(3).Text.Trim,
            '                                .CheckedItems(i).SubItems(4).Text.Trim}
            '        List = New ListViewItem(arrDATA)
            '        lstEmpKa.Items.Add(List)

            'arrDATA = New String() {GvEmp.RowCount + 1,
            '                       dr("Code").ToString,
            '                       dr("Fname").ToString,
            '                       dr("Lname").ToString,
            '                       dr("Department".ToString)}

        Next
        dsEmpKa.Tables(0).EndInit()

        '   Tn.Commit()
        btnAdd.Enabled = True
        btnRemove.Enabled = True
        ProgressBarX1.Visible = False
        ProgressBarX2.Visible = False

        '    End With
    End Sub


    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        With GvEmpKa
            For i As Integer = .GetSelectedRows.Count - 1 To 0 Step -1
                'For i As Integer = 0 To GvEmpKa.GetSelectedRows.Count - 1
                Dim rw As Integer = .GetSelectedRows(i)
                dsEmpKa.Tables(0).Rows.RemoveAt(rw)
            Next
        End With



    End Sub

    Private Sub btnClearList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    lstEmpKa.Items.Clear()

        '   GcEmpKa.DataSource = Nothing

        '   Call LoadClearGcKaByDay()

        GvEmpKa.SelectAll()

        With GvEmpKa
            For i As Integer = .GetSelectedRows.Count - 1 To 0 Step -1
                'For i As Integer = 0 To GvEmpKa.GetSelectedRows.Count - 1
                Dim rw As Integer = .GetSelectedRows(i)
                dsEmpKa.Tables(0).Rows.RemoveAt(rw)
            Next
        End With

        GcKaByDay.DataSource = Nothing
        txtCode.Text = ""
        txtName.Text = ""
        txtDepartment.Text = ""

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If lblKaCode.Text.Trim = "" Then
            'MsgBox("กรุณาเลือกกะที่ต้องการ กำหนด", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmEmpSetTimeByDateRS", Me.Text, "Config_Ka", MessageBoxIcon.Information)
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblKA.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            cboKa.Focus()
            Exit Sub
        End If
        'If lstEmpKa.Items.Count = 0 Then
        '    'MsgBox("กรุณาไม่มีพนักงานที่ต้องการ กำหนด", MsgBoxStyle.Information, Me.Text)
        '    MsgManager.ShowDialog(Me, "frmEmpSetTimeByDateRS", Me.Text, "Config_Emp", MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        'If GcEmpKa.DataSource = 0 Then
        '    MsgManager.ShowDialog(Me, "frmEmpSetTimeByDateRS", Me.Text, "Config_Emp", MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        Dim selDate As ArrayList = getSelectDate()

        If selDate.Count <= 0 Then
            'MsgBox("กรุณาเลือกวันที่ที่ต้องการกำหนดกะทำงาน", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmEmpSetTimeByDateRS", Me.Text, "Config_Ka_Day", MessageBoxIcon.Information)
            Exit Sub
        End If



        ProgressBarX1.Visible = True
        ProgressBarX2.Visible = True

        '    Dim Code As String
        Dim Ka_Code As String = lblKaCode.Text.Trim
        Dim Ka_Date As String
        Dim strSQL As String



        Dim dCmd As New SqlCommand
        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            'For i As Integer = 0 To lstEmpKa.Items.Count - 1
            '    Code = lstEmpKa.Items(i).SubItems(1).Text.Trim
            '    For j As Integer = 0 To 41
            '        Dim lblControl As Label = CType(lblDay(j), Label)
            '        If lblControl.BackColor = Color.YellowGreen Then
            '            Ka_Date = txtYear.Text.Trim & "/" &
            '                        Format(cboMonth.SelectedIndex + 1, "00") & "/" &
            '                        Format(CInt(lblControl.Text.Trim), "00")

            '            strSQL = "Delete From TimeEmpKaDate " &
            '                    " Where Code = '" & Code.Trim & "' and " &
            '                                " Ka_Date = '" & Ka_Date.Trim & "' "
            '            dCmd.Connection = Conn
            '            dCmd.CommandText = strSQL
            '            dCmd.ExecuteNonQuery()

            '            strSQL = "Insert Into TimeEmpKaDate" &
            '                        " (Code,Ka_Date,Ka_Code) Values(" &
            '                        " '" & Code.Trim & "'," &
            '                        " '" & Ka_Date.Trim & "'," &
            '                        " '" & Ka_Code.Trim & "')"
            '            dCmd.Connection = Conn
            '            dCmd.CommandText = strSQL
            '            dCmd.ExecuteNonQuery()
            '        End If
            '    Next
            'Next

            'Tn.Commit()


            Dim code As String = ""
            Dim rec As Integer = 1



            ProgressBarX1.Value = 0
            ProgressBarX1.Maximum = GvEmpKa.GetSelectedRows.Count - 1

            For Each i As Long In GvEmpKa.GetSelectedRows
                Dim dr As DataRow = GvEmpKa.GetDataRow(i)

                ProgressBarX1.Value = i + 1
                ProgressBarX1.Text = i & "/" & ProgressBarX1.Maximum

                If code <> "" Then
                    code &= ","
                End If

                code &= "'" & dr("Code").ToString & "'"


                If (rec Mod 2000) = 0 Or rec >= GvEmp.GetSelectedRows.Count Then

                    ProgressBarX2.Value = 0
                    ProgressBarX2.Maximum = selDate.Count

                    For j As Integer = 0 To selDate.Count - 1
                        ProgressBarX2.Value += 1

                        Ka_Date = selDate.Item(j)

                        strSQL = "Delete From TimeEmpKaDate " &
                                        " Where code in (" & code & ") and " &
                                                    " Ka_Date = '" & Ka_Date.Trim & "' "
                        dCmd.Connection = Conn
                        dCmd.CommandText = strSQL
                        dCmd.ExecuteNonQuery()

                        strSQL = "Insert Into TimeEmpKaDate" &
                                            " (Code,Ka_Date,Ka_Code)" &
                                                " select code,'" & Ka_Date.Trim & "','" & lblKaCode.Text.Trim & "'" &
                                                " from emp " &
                                                " where code in (" & code & ")"
                        dCmd.Connection = Conn
                        dCmd.CommandText = strSQL
                        dCmd.ExecuteNonQuery()
                    Next


                    code = ""
                    Application.DoEvents()
                End If

                rec += 1
            Next
            Tn.Commit()
            btnAdd.Enabled = True
            btnRemove.Enabled = True
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try
        '  MsgManager.ShowDialog(Me, "frmEmpSetTimeByDateRS", Me.Text, "Save_Complete", MessageBoxIcon.Information)
        MsgBox(My.Resources.res_warning_message.save_complete, MsgBoxStyle.Information, Me.Text)
        ProgressBarX1.Visible = False
        ProgressBarX2.Visible = False
        'MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information, Me.Text)
    End Sub

    'Function DaySelect() As Integer
    '    Dim total As Integer = 0
    '    For i As Integer = 0 To 41
    '        If CType(lblDay(i), Label).BackColor = Color.YellowGreen Then
    '            total += 1
    '        End If
    '    Next
    '    Return total
    'End Function

    Private Sub LoadKaDateByCode(ByVal Code As String, ByVal Month As Integer, ByVal Year As Integer)
        Dim strSQL As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet

        'Dim arrData() As String
        'Dim List As ListViewItem
        '  Dim dOfw As String
        strSQL = "select dOfW = datepart(dw,ka_date)," &
                     "dOfW_str = case datepart(dw,ka_date)" &
                        " when 1 then '" & My.Resources.res_day.Sun & "'" &
                        " when 2 then '" & My.Resources.res_day.Mon & "'" &
                        " when 3 then '" & My.Resources.res_day.Tue & "'" &
                        " when 4 then '" & My.Resources.res_day.Wed & "'" &
                        " when 5 then '" & My.Resources.res_day.Thu & "'" &
                        " when 6 then '" & My.Resources.res_day.Fri & "'" &
                        " when 7 then '" & My.Resources.res_day.Sat & "'" &
                        " Else '' End" &
                     " ,ka_date" &
                     ",t.ka_code, k.Timest, k.Timesp" &
                     " ,isnull(k.KaName,'') as KaName" &
                     " ,Timestsp=k.timest + ' ' + k.timesp " &
                " from timeempkadate t inner join TimeKa k " &
                        " On t.ka_code = k.ka_code  " &
                " where Code = '" & Code.Trim & "' and " &
                        " month(ka_date) = " & Month & " and " &
                        " year(ka_date)= " & Year &
                " Order by ka_date "

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        GcKaByDay.DataSource = Ds
        GcKaByDay.DataMember = "data"

        'With Ds.Tables("data")
        '    lstKaByDay.Items.Clear()
        '    For Each dr As DataRow In .Rows
        '        Select Case dr("dOfw")
        '            Case 1
        '                dOfw = "อา"
        '            Case 2
        '                dOfw = "จ"
        '            Case 3
        '                dOfw = "อ"
        '            Case 4
        '                dOfw = "พ"
        '            Case 5
        '                dOfw = "พฤ"
        '            Case 6
        '                dOfw = "ศ"
        '            Case 7
        '                dOfw = "ส"
        '            Case Else
        '                dOfw = ""
        '        End Select
        '        arrData = New String() {"",
        '                                dOfw,
        '                                Format(dr("ka_date"), "dd/MM/yyyy"),
        '                                dr("ka_code"),
        '                                Format(dr("TimeSt"), "HH:mm") & "-" & Format(dr("TimeSp"), "HH:mm")}
        '        List = New ListViewItem(arrData)
        '        lstKaByDay.Items.Add(List)

        '        If dr("dOfw") = 1 Or dr("dOfw") = 7 Then
        '            lstKaByDay.Items(lstKaByDay.Items.Count - 1).ForeColor = Color.Blue
        '        End If
        '    Next


        '   End With

    End Sub

    'Private Sub lstEmp_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    '    With lstEmp
    '        If .SelectedItems.Count <= 0 Then Exit Sub
    '        txtCode.Text = .SelectedItems(0).SubItems(1).Text.Trim
    '        txtName.Text = .SelectedItems(0).SubItems(2).Text.Trim & "   " & .SelectedItems(0).SubItems(3).Text.Trim
    '        txtDepartment.Text = .SelectedItems(0).SubItems(4).Text.Trim
    '        Call LoadKaDateByCode(txtCode.Text.Trim, cboMonth.SelectedIndex + 1, txtYear.Text.Trim)
    '        tbShowDate.SelectedIndex = 1
    '    End With
    'End Sub

    'Private Sub lstEmpKa_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    '    With lstEmpKa
    '        If .SelectedItems.Count <= 0 Then Exit Sub
    '        txtCode.Text = .SelectedItems(0).SubItems(1).Text.Trim
    '        txtName.Text = .SelectedItems(0).SubItems(2).Text.Trim & "   " & .SelectedItems(0).SubItems(3).Text.Trim
    '        txtDepartment.Text = .SelectedItems(0).SubItems(4).Text.Trim
    '        Call LoadKaDateByCode(txtCode.Text.Trim, cboMonth.SelectedIndex + 1, txtYear.Text.Trim)
    '        tbShowDate.SelectedIndex = 1
    '    End With
    'End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClearKa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If MsgBox("คุณต้องการยกเลิก กะทั้งเดือนของทุกคน ทุกวันหรือไม่", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        'If MsgManager.ConfirmDialog(Me, "frmEmpSetTimeByDateRS", Me.Text, "Cancle_Ka",
        '    MessageBoxIcon.Information) = DialogResult.Cancel Then Exit Sub

        If MsgBox(My.Resources.res_warning_message_spacial.Cancle_Ka, MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = vbNo Then Exit Sub


        Dim Month As Integer
        Dim Year As Integer

        If cboMonth.SelectedIndex < 0 Then
            'MsgBox("กรุณาเลือกเดือนด้วย", MsgBoxStyle.Information, Me.Text)
            '    MsgManager.ShowDialog(Me, "frmEmpSetTimeByDateRS", Me.Text, "Check_Month", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.Check_Month, MsgBoxStyle.Information, Me.Text)
            cboMonth.Focus()
            Exit Sub
        End If
        If IsNumeric(txtYear.Text.Trim) = False Then
            'MsgBox("กรุณาป้อนปีให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmEmpSetTimeByDateRS", Me.Text, "Check_Year", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.Check_Year, MsgBoxStyle.Information, Me.Text)
            txtYear.Focus()
            Exit Sub
        End If
        If CInt(txtYear.Text.Trim) < 1900 Or CInt(txtYear.Text.Trim) > 2500 Then
            'MsgBox("กรุณาป้อนปีให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            ' MsgManager.ShowDialog(Me, "frmEmpSetTimeByDateRS", Me.Text, "Check_Year", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.Check_Year, MsgBoxStyle.Information, Me.Text)
            txtYear.Focus()
            Exit Sub
        End If

        Month = cboMonth.SelectedIndex + 1
        Year = CInt(txtYear.Text.Trim)

        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            strSQL = "Delete From TimeEmpKaDate " &
                    " Where Month(Ka_Date) = " & Month & " and " &
                            " Year(Ka_Date) = " & Year
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()
            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try
        'Cancle_Ka_Complete
        '  MsgManager.ShowDialog(Me, "frmEmpSetTimeByDateRS", Me.Text, "Cancle_Ka_Complete", MessageBoxIcon.Information)
        MsgBox(My.Resources.res_warning_message_spacial.Cancle_Ka_Complete, MsgBoxStyle.Information, Me.Text)

        'MsgBox("ยกเลิกกะทั้งหมดเรียบร้อยแล้ว", MsgBoxStyle.Information, Me.Text)
    End Sub

    Private Sub btnDeleteKaByEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteKaByEmp.Click
        'If MsgBox("คุณต้องการยกเลิก กะทั้งเดือนของคนนี้หรือไม่", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        'If MsgManager.ConfirmDialog(Me, "frmEmpSetTimeByDateRS", Me.Text, "Cancle_Ka2",
        'MessageBoxIcon.Information) = DialogResult.Cancel Then Exit Sub
        If MsgBox(My.Resources.res_warning_message_spacial.Cancle_Ka2, MsgBoxStyle.Information Or MsgBoxStyle.YesNo, Me.Text) = vbNo Then Exit Sub

        If txtCode.Text.Trim = "" Then
            'MsgBox("กรุณาเลือกรายชื่อพนักงานด้วย", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmEmpSetTimeByDateRS", Me.Text, "Select_Emp", MessageBoxIcon.Information)
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblCode.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        'If lstKaByDay.CheckedItems.Count <= 0 Then
        '    'MsgBox("กรุณาเลือกรายการที่ต้องการลบด้วย", MsgBoxStyle.Information, Me.Text)
        '    MsgManager.ShowDialog(Me, "frmEmpSetTimeByDateRS", Me.Text, "Select_Data_For_Del", MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        If gvKaByDay.GetSelectedRows.Count = 0 Then
            '  MsgManager.ShowDialog(Me, "frmEmpSetTimeByDateRS", Me.Text, "Select_Data_For_Del", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message_spacial.Select_Data_For_Del, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn

        Try
            'For i As Integer = 0 To lstKaByDay.CheckedItems.Count - 1
            '    strSQL = "Delete From TimeEmpKaDate " &
            '            " Where Code = '" & txtCode.Text.Trim & "' and " &
            '                    " Convert(nVarchar(10),Ka_Date,111) = '" & ConvertDate(lstKaByDay.CheckedItems(i).SubItems(2).Text.Trim) & "'"

            '    dCmd.Connection = Conn
            '    dCmd.CommandText = strSQL
            '    dCmd.ExecuteNonQuery()
            'Next
            'Tn.Commit()

            Try


                ProgressBarX1.Value = 0
                ProgressBarX1.Maximum = gvKaByDay.GetSelectedRows.Count - 1

                For Each i As Long In gvKaByDay.GetSelectedRows

                    Dim dr As DataRow = gvKaByDay.GetDataRow(i)
                    'ProgressBarX1.Value = i + 1
                    'ProgressBarX1.Text = Format((i * 100) / ProgressBarX1.Maximum, "#0.00") & "%"
                    'Application.DoEvents()

                    strSQL = "Delete From TimeEmpKaDate " &
                            " Where Code = '" & txtCode.Text.Trim & "' and " &
                                    " Convert(nVarchar(10),Ka_Date,111) = '" & cDateTime.dbDate(dr("Ka_Date")) & "'"

                    dCmd.Connection = Conn
                    dCmd.CommandText = strSQL
                    dCmd.ExecuteNonQuery()
                Next
                Tn.Commit()
                btnAdd.Enabled = True
                btnRemove.Enabled = True
            Catch ex As Exception
                btnAdd.Enabled = True
                btnRemove.Enabled = True
                Tn.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
                Exit Sub
            End Try
            Call btnRefresh_Click(Me, System.EventArgs.Empty)
            Call LoadKaDateByCode(txtCode.Text.Trim, cboMonth.SelectedIndex + 1, txtYear.Text.Trim)
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try
        '  MsgManager.ShowDialog(Me, "frmEmpSetTimeByDateRS", Me.Text, "Cancle_Ka_Complete2", MessageBoxIcon.Information)
        MsgBox(My.Resources.res_warning_message_spacial.Cancle_Ka_Complete2, MsgBoxStyle.Information, Me.Text)
        'MsgBox("ยกเลิกกะเรียบร้อยแล้ว", MsgBoxStyle.Information, Me.Text)
    End Sub

    Private Sub GvEmpKa_CustomColumnDisplayText(sender As Object, e As CustomColumnDisplayTextEventArgs) Handles GvEmpKa.CustomColumnDisplayText
        If e.Column.Name = "colGNo" Then
            If e.ListSourceRowIndex >= 0 Then
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString
            End If
        End If
    End Sub


    Private Sub GvEmpKa_DoubleClick(sender As Object, e As EventArgs) Handles GvEmpKa.DoubleClick
        Try
            Dim gv As GridView = CType(sender, GridView)

            If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "Code")) = True Then Exit Sub


            txtCode.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Code")
            txtName.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Fname") & "   " & gv.GetRowCellValue(gv.FocusedRowHandle, "Lname")
            txtDepartment.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Department")
            Call LoadKaDateByCode(txtCode.Text.Trim, cboMonth.SelectedIndex + 1, txtYear.Text.Trim)
            '    tbShowDate.SelectedIndex = 1


            XtraTabControl1.SelectedTabPageIndex = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'If .SelectedItems.Count <= 0 Then Exit Sub
        'txtCode.Text = .SelectedItems(0).SubItems(1).Text.Trim
        'txtName.Text = .SelectedItems(0).SubItems(2).Text.Trim & "   " & .SelectedItems(0).SubItems(3).Text.Trim
        'txtDepartment.Text = .SelectedItems(0).SubItems(4).Text.Trim
        'Call LoadKaDateByCode(txtCode.Text.Trim, cboMonth.SelectedIndex + 1, txtYear.Text.Trim)
        'tbShowDate.SelectedIndex = 1


    End Sub

    Private Sub gvKaByDay_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles gvKaByDay.RowCellStyle
        Try
            Dim gv As GridView = CType(sender, GridView)

            Select Case e.Column.FieldName
                Case "dOfw"
                    If gv.GetRowCellValue(e.RowHandle, "dOfw") = 1 Or gv.GetRowCellValue(e.RowHandle, "dOfw") = 7 Then
                        e.Appearance.ForeColor = Color.Blue
                    End If
            End Select
        Catch ex As Exception

        End Try



        'If dr("dOfw") = 1 Or dr("dOfw") = 7 Then
        '    lstKaByDay.Items(lstKaByDay.Items.Count - 1).ForeColor = Color.Blue
        'End If
    End Sub



    Private Sub GvEmp_DoubleClick(sender As Object, e As EventArgs) Handles GvEmp.DoubleClick
        Try
            Dim gv As GridView = CType(sender, GridView)

            If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "Code")) = True Then Exit Sub


            txtCode.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Code")
            txtName.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Fname") & "   " & gv.GetRowCellValue(gv.FocusedRowHandle, "Lname")
            txtDepartment.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Department")
            Call LoadKaDateByCode(txtCode.Text.Trim, cboMonth.SelectedIndex + 1, txtYear.Text.Trim)
            '    tbShowDate.SelectedIndex = 1


            XtraTabControl1.SelectedTabPageIndex = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SplitContainerControl1_SplitterPositionChanged(sender As Object, e As EventArgs) Handles SplitContainerControl1.SplitterPositionChanged
        grpLeft.Width = SplitContainerControl1.Panel1.Width - grpLeft.Left - 2
        grpRight.Width = SplitContainerControl1.Panel2.Width - grpRight.Left - 2
    End Sub

    Private Sub frmEmpSetTimeByDate_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        SplitContainerControl1.SplitterPosition = pnlApp.Width / 2
    End Sub

    Private Sub cboDivision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDivision.SelectedIndexChanged
        Call SearchData.LoadDepartment(Me, cboDepartment, GetData.GetDivisionId(cboDivision.Text.Trim), True)
    End Sub

    Function getSelectDate() As ArrayList
        Dim ret As New ArrayList


        Dim dr As New DevExpress.XtraEditors.Controls.DateRangeCollection

        dr = cd_month.SelectedRanges

        ret.Clear()

        For i As Integer = 0 To dr.Count - 1
            Dim dst As DateTime = dr.Item(i).StartDate
            Dim dsp As DateTime = dr.Item(i).EndDate.AddDays(-1)
            Dim d As DateTime
            d = dst
            Do While d <= dsp
                ret.Add(Format(d, "yyyy/MM/dd"))
                d = d.AddDays(1)
            Loop
        Next

        Return ret
    End Function

    Private Sub LabelControl5_Click(sender As Object, e As EventArgs) Handles LabelControl5.Click

    End Sub

    Private Sub LabelControl10_Click(sender As Object, e As EventArgs) Handles LabelControl10.Click

    End Sub
End Class