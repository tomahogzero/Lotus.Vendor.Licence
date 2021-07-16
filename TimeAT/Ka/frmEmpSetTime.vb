Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports TimeAttendance.utils

Public Class frmEmpSetTime

    Private Sub frmEmpSetTime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBarX1.Visible = False
        Call LoadKA()
        Call LoadEmp()
        Call LoadCompany()

        If ComId <> "" Then
            cboCompany.Enabled = False
            cboCompany.SelectedItem = ComName

            cboCompany_Cal.Enabled = False
            cboCompany_Cal.SelectedItem = ComName.Trim
        End If

        Call SearchData.LoadDivision(Me, cboDivision, True)
        Call SearchData.LoadDepartment(Me, cboDepartment, "", True)

        Call SearchData.LoadDivision(Me, cboDivision_Cal, True)
        Call SearchData.LoadDepartment(Me, cboDepartment_Cal, "", True)
    End Sub

    Private Sub LoadDepartment()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select Department " & _
                " From Department " & _
                " Order By Department"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            cboDepartment.Properties.Items.Clear()
            cboDepartment.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))

            cboDepartment_Cal.Properties.Items.Clear()
            cboDepartment_Cal.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            For Each dr As DataRow In .Rows
                cboDepartment.Properties.Items.Add(dr("Department"))
                cboDepartment_Cal.Properties.Items.Add(dr("Department"))
            Next
            cboDepartment.SelectedIndex = 0
            cboDepartment_Cal.SelectedIndex = 0
        End With
    End Sub

    Private Sub LoadDivision()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select Division " & _
                " From Division " & _
                " Order By Division"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            cboDivision.Properties.Items.Clear()
            cboDivision.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))

            cboDivision_Cal.Properties.Items.Clear()
            cboDivision_Cal.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            For Each dr As DataRow In .Rows
                cboDivision.Properties.Items.Add(dr("Division"))
                cboDivision_Cal.Properties.Items.Add(dr("Division"))
            Next
            cboDivision.SelectedIndex = 0
            cboDivision_Cal.SelectedIndex = 0
        End With
    End Sub


    Private Sub LoadEmpGroup()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select GroupName " & _
                " From EmpGroup " & _
                " Order By GroupName"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            cboEmpGroup.Items.Clear()
            cboEmpGroup.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))

            cboEmpGroup_Cal.Items.Clear()
            cboEmpGroup_Cal.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))
            For Each dr As DataRow In .Rows
                cboEmpGroup.Items.Add(dr("GroupName"))
                cboEmpGroup_Cal.Items.Add(dr("GroupName"))
            Next
            cboEmpGroup.SelectedIndex = 0
            cboEmpGroup_Cal.SelectedIndex = 0
        End With
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub LoadKA()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""

        strSQL = "select Ka_Code,KaName From TimeKa Order By KaName"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                cboKa.Properties.Items.Clear()
            Else
                cboKa.Properties.Items.Clear()
                cboKa.Properties.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))

                For Each dr As DataRow In .Rows
                    cboKa.Properties.Items.Add(dr("KaName"))
                Next
            End If
            cboKa.SelectedIndex = 0
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

        strSQL &= ",Emp.Lname, " &
                        " Division = Isnull(Div.Division,''), " &
                        " Department = Isnull(Department.Department,''), " &
                        " Position = Isnull(Emp.Position,'')" &
                " From Emp " &
                          " Left join Department " &
                                " On emp.DeptId = Department.DeptId " &
                            " Left join Division div " &
                                " On Department.divid = div.divid " &
                " Where Code Not In (Select Code From TimeEmpKa) And Emp.WorkStatus = 'W'"


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
            query &= " Order By Div.Division,Department.Department,Emp.Code"
        End If

        If rdByDeptName.Checked = True Then
            query &= " Order By Div.Division,Department.Department,Fname,Lname"
        End If
        Return query

    End Function

    Private Sub LoadEmpKa(ByVal Ka_Code As String)
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        'Dim arrData() As String
        'Dim List As ListViewItem

        strSQL = "Select row_number() over("
        strSQL &= LoadEmpKa_order_by()
        strSQL &= " ) As row," &
                        " Emp.Code,"

        If cValGolbal.Lang = "TH" Then
            strSQL &= "isnull(Emp.title,'') + isnull(emp.Fname,'') as Fname"
        Else
            strSQL &= "isnull(Emp.title,'') + ' ' + isnull(emp.Fname,'') as Fname"
        End If

        strSQL &= ",Emp.Lname, " &
                        " Division = Isnull(Div.Division,''), " &
                        " Department = Isnull(Department.Department,''), " &
                        " Position = Isnull(Emp.Position,'') ," &
                        " KaName  = Isnull(Timeka.KaName,'') " &
                " From Emp Left Join Department " &
                            " On Emp.DeptId = Department.DeptId " &
                        " Left Join Division Div " &
                            " On Department.DivId = Div.DivId " &
                        " Left Join timeEmpKA Tk " &
                            " On emp.Code= Tk.Code " &
                        " Left Join TimeKa " &
                            " On Tk.Ka_Code=TimeKA.KA_Code " &
                 " Where 1=1 "

        If cboKa.SelectedIndex > 0 Then
            strSQL &= " And Isnull(TimeKa.KaName,'') = '" & cboKa.Text.Trim & "'"
        End If

        If cboDivision_Cal.SelectedIndex > 0 Then
            strSQL &= " And Isnull(Department.DivId,'') = '" & GetData.GetDivisionId(cboDivision_Cal.Text.Trim) & "'"
        End If

        If cboDepartment_Cal.SelectedIndex > 0 Then
            strSQL &= " and Isnull(Emp.DeptId,'') = '" & GetData.GetDepartmentId(cboDepartment_Cal.Text.Trim) & "'"
        End If

        strSQL &= LoadEmpKa_order_by()

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")


        GcEmp_Cal.DataSource = Ds
        GcEmp_Cal.DataMember = "Data"
    End Sub

    Function LoadEmpKa_order_by() As String
        Dim query As String = ""
        If rdByCode_Cal.Checked = True Then
            query &= " Order By Emp.Code"
        End If

        If rdByName_Cal.Checked = True Then
            query &= " Order By Fname,Lname"
        End If

        If rdByDeptCode_Cal.Checked = True Then
            query &= " Order By Div.Division,Department.Department,Emp.Code"
        End If

        If rdByDeptName_Cal.Checked = True Then
            query &= " Order By Div.Division,Department.Department,Fname,Lname"
        End If
        Return query
    End Function

    Private Sub cboKa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboKa.SelectedIndexChanged
        lblKaCode.Text = GetKaCode(cboKa.Text.Trim).Trim
        Call LoadEmpKa(lblKaCode.Text.Trim)
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        btnRefresh.Enabled = False
        Application.DoEvents()
        Call LoadEmp()
        btnRefresh.Enabled = True

        'Call LoadEmp()
        'Call LoadEmpKa(lblKaCode.Text.Trim)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If cboKa.SelectedIndex = 0 Then
            '     MsgBox("กรุณาเลือก กะ ที่ต้องการกำหนด", MsgBoxStyle.Information, "เลือกกะ")
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblKa.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            cboKa.Focus()
            Exit Sub
        End If

        If cboKa.Text = "" Then
            '  MsgBox("กรุณาเลือก กะ ที่ต้องการกำหนด", MsgBoxStyle.Information, "เลือกกะ")
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblKa.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            cboKa.Focus()
            Exit Sub
        End If

        Dim dCmd As New SqlCommand
        Dim strSQL As String

        If lblKaCode.Text.Trim = "" Then
            '  MsgManager.ShowDialog(Me, "frmEmpSetTimeRS", Me.Text, "Check_Time", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.check_time, MsgBoxStyle.Information, Me.Text)
            'MsgBox("¡ÃØ³ÒàÅ×Í¡àÇÅÒ·Ó§Ò¹´éÇÂ", MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        ProgressBarX1.Visible = True

        btnAdd.Enabled = False
        btnRemove.Enabled = False

        ProgressBar1.Value = 0
        ProgressBar1.Maximum = lstEmp.CheckedItems.Count

        '     With lstEmp
        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try

            Dim code As String = ""
            Dim rec As Integer = 1

            ' process every 1000 row

            ProgressBarX1.Value = 0
            ProgressBarX1.Maximum = GvEmp.GetSelectedRows.Count - 1

            For Each i As Long In GvEmp.GetSelectedRows

                Dim dr As DataRow = GvEmp.GetDataRow(i)
                ProgressBarX1.Value = i + 1
                'ProgressBarX1.Text = Format((i * 100) / ProgressBarX1.Maximum, "#0.00") & "%"
                ProgressBarX1.Text = i & "/" & ProgressBarX1.Maximum

                If code <> "" Then
                    code &= ","
                End If

                code &= "'" & dr("Code").ToString & "'"


                If (rec Mod 1000) = 0 Or rec >= GvEmp.GetSelectedRows.Count Then
                    strSQL = "Delete From TimeEmpKa " &
                            " Where Code in (" & code & ")"
                    dCmd.Connection = Conn
                    dCmd.CommandText = strSQL
                    dCmd.ExecuteNonQuery()

                    strSQL = "Insert Into TimeEmpKa(Code,Ka_Code)" &
                            " select code,'" & lblKaCode.Text.Trim & "'" &
                            " from emp " &
                            " where code in (" & code & ")"
                    dCmd.Connection = Conn
                    dCmd.CommandText = strSQL
                    dCmd.ExecuteNonQuery()

                    code = ""
                    Application.DoEvents()
                End If

                rec += 1

                'strSQL = "Delete From TimeEmpKa " &
                '        " Where Code ='" & dr("Code").ToString & "'"
                'dCmd.Connection = Conn
                'dCmd.CommandText = strSQL
                'dCmd.ExecuteNonQuery()

                'strSQL = "Insert Into TimeEmpKa(Code,Ka_Code) Values(" &
                '        " '" & dr("Code").ToString & "'," &
                '        " '" & lblKaCode.Text.Trim & "')"
                'dCmd.Connection = Conn
                'dCmd.CommandText = strSQL
                'dCmd.ExecuteNonQuery()

            Next
            Tn.Commit()
            btnAdd.Enabled = True
            btnRemove.Enabled = True
        Catch ex As Exception
            Tn.Rollback()
            btnAdd.Enabled = True
            btnRemove.Enabled = True
            'Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try
        Call btnRefresh_Click(Me, System.EventArgs.Empty)
        Call btnRefresh_Cal_Click(Me, System.EventArgs.Empty)

        ProgressBarX1.Visible = False
        '     End With
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Dim dCmd As New SqlCommand
        Dim strSQL As String

        'If lblKaCode.Text.Trim = "" Then
        '    'MsgBox("¡ÃØ³ÒàÅ×Í¡àÇÅÒ·Ó§Ò¹´éÇÂ", MsgBoxStyle.Information, Me.Text)
        '    MsgManager.ShowDialog(Me, "frmEmpSetTimeRS", Me.Text, "Check_Time", MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        ProgressBarX1.Visible = True
        btnAdd.Enabled = False
        btnRemove.Enabled = False

        '    With lstEmp_Cal
        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            '    For i As Integer = 0 To .CheckedItems.Count - 1
            '        strSQL = "Delete From TimeEmpKa " &
            '                " Where Code = '" & .CheckedItems(i).SubItems(1).Text.Trim & "'"
            '        dCmd.Connection = Conn
            '        dCmd.CommandText = strSQL
            '        dCmd.ExecuteNonQuery()

            '    Next

            Dim code As String = ""
            Dim rec As Integer = 1

            ProgressBarX1.Value = 0
            ProgressBarX1.Maximum = GvEmp_Cal.GetSelectedRows.Count - 1

            For Each i As Long In GvEmp_Cal.GetSelectedRows

                Dim dr As DataRow = GvEmp_Cal.GetDataRow(i)
                ProgressBarX1.Value = i + 1
                'ProgressBarX1.Text = Format((i * 100) / ProgressBarX1.Maximum, "#0.00") & "%"
                'Application.DoEvents()



                'strSQL = "Delete From TimeEmpKa " &
                '        " Where Code = '" & dr("Code").ToString & "'"
                'dCmd.Connection = Conn
                'dCmd.CommandText = strSQL
                'dCmd.ExecuteNonQuery()


                ProgressBarX1.Text = i & "/" & ProgressBarX1.Maximum
                'Application.DoEvents()

                If code <> "" Then
                    code &= ","
                End If

                code &= "'" & dr("Code").ToString & "'"


                If (rec Mod 1000) = 0 Or rec >= GvEmp_Cal.GetSelectedRows.Count Then
                    strSQL = "Delete From TimeEmpKa " &
                            " Where Code in (" & code & ")"
                    dCmd.Connection = Conn
                    dCmd.CommandText = strSQL
                    dCmd.ExecuteNonQuery()

                    code = ""
                    Application.DoEvents()
                End If

                rec += 1

            Next
            Tn.Commit()
            btnAdd.Enabled = True
            btnRemove.Enabled = True

            '    Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            btnAdd.Enabled = True
            btnRemove.Enabled = True
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try
        Call btnRefresh_Click(Me, System.EventArgs.Empty)
        Call btnRefresh_Cal_Click(Me, System.EventArgs.Empty)
        ProgressBarX1.Visible = False
        ' End With
    End Sub

    Private Sub LoadCompany()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select CompanyName From Company_Sub "
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            cboCompany.Items.Clear()
            cboCompany.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))

            cboCompany_Cal.Items.Clear()
            cboCompany_Cal.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))

            Dim I As Integer
            For I = 0 To .Rows.Count - 1
                cboCompany.Items.Add(.Rows(I).Item("CompanyName"))

                cboCompany_Cal.Items.Add(.Rows(I).Item("CompanyName"))
            Next
            Ds.Clear()
            cboCompany.SelectedIndex = 0
            cboCompany_Cal.SelectedIndex = 0
        End With
    End Sub


    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        With lstEmp
            For i As Integer = 0 To .Items.Count - 1
                .Items(i).Checked = True
            Next
        End With
    End Sub

    Private Sub btnNoneSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoneSelectAll.Click
        With lstEmp
            For i As Integer = 0 To .Items.Count - 1
                .Items(i).Checked = False
            Next
        End With
    End Sub

    Private Sub btnSelectAll2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll_Cal.Click
        With lstEmp_Cal
            For i As Integer = 0 To .Items.Count - 1
                .Items(i).Checked = True
            Next
        End With
    End Sub

    Private Sub btnNoneSelectAll2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoneSelectAll_Cal.Click
        With lstEmp_Cal
            For i As Integer = 0 To .Items.Count - 1
                .Items(i).Checked = False
            Next
        End With
    End Sub

    Private Sub btnRefresh_Cal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh_Cal.Click
        btnRefresh_Cal.Enabled = False
        Application.DoEvents()
        Call LoadEmpKa(lblKaCode.Text.Trim)
        btnRefresh_Cal.Enabled = True
    End Sub

    Private Sub frmEmpSetTime_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        SplitContainerControl1.SplitterPosition = pnlApp.Width / 2
    End Sub

    Private Sub SplitContainerControl1_SplitterPositionChanged(sender As Object, e As EventArgs) Handles SplitContainerControl1.SplitterPositionChanged
        grpLeft.Width = SplitContainerControl1.Panel1.Width - grpLeft.Left - 2
        grpRight.Width = SplitContainerControl1.Panel2.Width - grpRight.Left - 2
    End Sub

    Private Sub cboDivision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDivision.SelectedIndexChanged
        Call SearchData.LoadDepartment(Me, cboDepartment, GetData.GetDivisionId(cboDivision.Text.Trim), True)
    End Sub

    Private Sub cboDivision_Cal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDivision_Cal.SelectedIndexChanged
        Call SearchData.LoadDepartment(Me, cboDepartment_Cal, GetData.GetDivisionId(cboDivision_Cal.Text.Trim), True)
    End Sub
End Class
