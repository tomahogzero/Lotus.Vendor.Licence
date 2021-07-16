Imports System.Data
Imports System.Data.SqlClient
Imports TimeAttendance.utils

Public Class frmUser

    Dim ID As Integer = 0
    Dim StaffId As String = ""
    Dim dvDepartment As DataView
    Dim dtData As DataTable

    Private m_SortingColumn As ColumnHeader

    Private Sub frmUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            If TypeOf Me.ActiveControl Is TextBox Then
                Dim tb As TextBox = DirectCast(Me.ActiveControl, TextBox)
                If tb.Multiline AndAlso tb.AcceptsReturn Then
                    e.Handled = False
                    Exit Sub
                End If
            End If
            e.Handled = True
            Dim oform As Form = Me.FindForm
            oform.SelectNextControl(oform.ActiveControl, True, True, True, True)
            oform.ActiveControl.Focus()
        End If
    End Sub

    Private Sub frmDepartment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call EnaCmd(True, False, False)
        Call LoadData()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click, btnEdit.Click
        If txtStaffId.Text.Trim = "" Then
            'MsgBox("��سһ�͹���ʾ�ѡ�ҹ", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmUserRS", Me.Text, "Insert_EmpID", MessageBoxIcon.Information)
            txtStaffId.Focus()
            Exit Sub
        End If
        If txtUsername.Text.Trim = "" Then
            'MsgBox("��سһ�͹���ʾ�ѡ�ҹ", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmUserRS", Me.Text, "Insert_EmpID", MessageBoxIcon.Information)
            txtPassword.Focus()
            Exit Sub
        End If
        'If txtPassword.Text.Trim <> txtConPass.Text.Trim Then
        '    MsgBox("���ʼ�ҹ�������͹�ѹ��سҡ�͡����", MsgBoxStyle.Information, Me.Text)
        '    txtPassword.Focus()
        '    Exit Sub
        'End If

        Dim strSQL As String = ""
        Dim dCmd As New SqlCommand
        Dim data As New ArrayList
        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn


        Try
            Dim c As New db
            strSQL = "delete from [user] Where UserId = @P1"
            data.Clear()
            data.Add(txtStaffId.Text.Trim)
            c.ExecuteCommand(Conn, dCmd, strSQL, "T", data)

            strSQL = "insert into [user](UserID,username,Password)" & _
                    " values(@P1,@P2,@P3)"
            data.Clear()
            data.Add(txtStaffId.Text.Trim)
            data.Add(txtUsername.Text.Trim)
            data.Add(GenCode.FinalEncript(TypeEn.EnCode, txtPassword.Text.Trim, PublicKey))
            c.ExecuteCommand(Conn, dCmd, strSQL, "TTT", data)
            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try

        Call btnRefresh_Click(Me, System.EventArgs.Empty)
    End Sub



    Private Sub LoadData()
        Dim strSQL As String = ""
        Dim dCmd As New SqlCommand
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim arrData() As String
        Dim List As ListViewItem
        strSQL = "select e.Code  , Title = isnull(e.Title,'') , Fname = ISNULL(e.Fname,'') , Lname = ISNULL(e.Lname,'') " & _
                        " , UserName = isnull(u.UserName,'') " & _
                " from emp e Inner Join [user] u " & _
                        " On e.Code = u.UserId" & _
                " where WorkStatus = 'W' " & _
                " order by Code "

        Try
            Dim c As New db
            c.ExecuteCommand(Conn, dCmd, strSQL)
            Da.SelectCommand = dCmd
            Da.Fill(Ds, "data")

            dtData = Ds.Tables(0)

            lstDepartment.Items.Clear()
            For Each dr As DataRow In dtData.Rows
                arrData = New String() {lstDepartment.Items.Count + 1, _
                                        dr("Code"), _
                                        dr("Fname"), _
                                        dr("Lname"), _
                                        dr("UserName")}
                List = New ListViewItem(arrData)
                lstDepartment.Items.Add(List)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub EnaCmd(ByVal Add As Boolean, ByVal Edit As Boolean, ByVal Delete As Boolean)
        btnAdd.Enabled = Add
        btnEdit.Enabled = Edit
        btnDelete.Enabled = Delete
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Call ClearData()
        Call LoadData()
        Call EnaCmd(True, False, False)
        txtStaffId.Focus()
    End Sub

    Private Sub ClearData()
        txtNo.Text = ""
        txtStaffId.Text = ""
        txtFirstName.Text = ""
        txtLname.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        ID = 0
    End Sub

    Private Sub lstDepartment_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lstDepartment.ColumnClick
        Dim Lst As ListView = CType(sender, ListView)
        Dim new_sorting_column As ColumnHeader = _
                                    Lst.Columns(e.Column)
        Dim sort_order As System.Windows.Forms.SortOrder
        If m_SortingColumn Is Nothing Then
            sort_order = SortOrder.Ascending
        Else
            If new_sorting_column.Equals(m_SortingColumn) Then
                If m_SortingColumn.Text.StartsWith("> ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                sort_order = SortOrder.Ascending
            End If

            m_SortingColumn.Text = m_SortingColumn.Text.Substring(2)
        End If

        m_SortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text = "> " & m_SortingColumn.Text
        Else
            m_SortingColumn.Text = "< " & m_SortingColumn.Text
        End If

        Lst.ListViewItemSorter = New ListViewComparer(e.Column, sort_order)

        Lst.Sort()
    End Sub

    Private Sub lstDepartment_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstDepartment.DoubleClick
        With lstDepartment
            If .SelectedItems.Count = 0 Then Exit Sub
            ' for check
            ID = .SelectedItems(0).SubItems(0).Text
            StaffId = .SelectedItems(0).SubItems(2).Text.Trim

            ' show
            Dim index As Integer
            index = .Items.IndexOf(.SelectedItems(0))
            Dim dr As DataRow = dtData.Rows(index)
            txtNo.Text = .SelectedItems(0).SubItems(1).Text.Trim
            txtStaffId.Text = dr("Code")
            txtFirstName.Text = dr("fname")
            txtLname.Text = dr("lname")
            txtUsername.Text = dr("Username")

            Call EnaCmd(False, True, True)
        End With
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'If MsgBox("Are you sure delete this reccord?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Delete Record") = MsgBoxResult.No Then Exit Sub
        If MsgManager.ConfirmDialog(Me, "frmUserRS", Me.Text, "Confirm_Del", _
        MessageBoxIcon.Information) = Windows.Forms.DialogResult.Cancel Then Exit Sub

        Dim strSQL As String = ""
        Dim dCmd As New SqlCommand
        Dim data As New ArrayList
        strSQL = "delete [user] " & _
                " where idcode = @P1"
        data.Add(txtStaffId.Text.Trim)

        Try
            Dim c As New db
            c.ExecuteCommand(Conn, dCmd, strSQL, "T", data)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Call btnRefresh_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub btnSetPermission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetPermission.Click
        Try
            If fRightManagementControl Is Nothing Then
                fRightManagementControl = New frmRightManagementControl
            Else
                If fRightManagementControl.IsDisposed = True Then
                    fRightManagementControl = New frmRightManagementControl
                End If
            End If
            fRightManagementControl.WindowState = FormWindowState.Maximized
            fRightManagementControl.MdiParent = Me.MdiParent
            fRightManagementControl.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub txtStaffId_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStaffId.LostFocus

        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select  Code  , Title = isnull(Title,'') ,Fname = ISNULL(Fname,'') ,Lname = ISNULL(Lname,'')  " & _
                 "from Emp " & _
                 " Where Code = '" & txtStaffId.Text.Trim & "'"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                txtStaffId.Text = ""
                txtFirstName.Text = ""
                txtLname.Text = ""
                Exit Sub
            End If
            txtStaffId.Text = .Rows(0).Item("Code")
            txtFirstName.Text = .Rows(0).Item("fName")
            txtLname.Text = .Rows(0).Item("LName")
        End With
    End Sub

    Private Sub txtStaffId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStaffId.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class