Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports TimeAttendance.utils

Public Class frmWorkSpecial

    Private Sub frmWorkSpecial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDate_Hol.Text = Format(Now, "dd/MM/yyyy")
        txtDate_Work.Text = Format(Now, "dd/MM/yyyy")
        Call EnaBtn_Work(True, False)
        Call EnaBtn_Hol(True, False)

        'Call LoadWork()
        'Call LoadHoliday()
        Call LoadWorkDev()
        Call LoadHolidayDev()

    End Sub

    Private Sub btnAdd_W_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd_W.Click
        Dim strSQL As String
        Dim strType As String
        Dim dCmd As New SqlCommand
        Dim data As New ArrayList
        Dim db As New db
        Dim Tn As SqlTransaction

        'Dim arrData() As String
        'Dim List As ListViewItem


        If ChkDate_Hol(txtDate_Work.Text.Trim) = True Then
            'MsgBox("ไม่สามารถบันทึกได้ เนื่องจากการกำหนด {วันที่ทำงานพิเศษ} ต้องไม่ตรงกับ {วันที่วันหยุดพิเศษ}", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "วันที่ซ้ำ")
            ' MsgManager.ShowDialog(Me, "frmWorkSpecialRS", Me.Text, "Save_Failed", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message_spacial.Save_Failed_spacial_holiday, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        'เงือนไขการกำหนด ห้ามป้อนซ้ำ
        If ChkDate_Work(txtDate_Work.Text.Trim) = True Then
            'MsgBox("ไม่สามารถแก้ไขได้เนื่องจากวันที่  " & txtDate_Work.Text.Trim & "  ได้บันทึกไปแล้ว", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "วันที่ซ้ำ")
            '  MsgManager.ShowDialog(Me, "frmWorkSpecialRS", Me.Text, "Edit_Failed", MessageBoxIcon.Information)

            MsgBox(My.Resources.res_warning_message_spacial.Edit_Failed_spacial_holiday, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If



        'Call OpenConnect(True)
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn

        Try
            data.Clear() : strType = ""
            data.Add(ConvertDate(txtDate_Work.Text.Trim)) : strType &= "T"
            data.Add(txtRemark_Work.Text.Trim) : strType &= "T"

            strSQL = "Insert Into TimeWork_Spa_Config(DatetimeWork,Remark)" &
                                " Values(@P1,@P2)"
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, data)

            Tn.Commit()
            'Call OpenConnect(False)
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try

        Call btnClear_W_Click(Me, System.EventArgs.Empty)
        '  Call EnaBtn_Work(True, False)

    End Sub

    Private Sub btnAdd_H_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd_H.Click
        Dim strSQL As String
        Dim strType As String
        Dim dCmd As New SqlCommand
        Dim data As New ArrayList
        Dim db As New db
        Dim Tn As SqlTransaction
        'Dim arrData() As String
        'Dim List As ListViewItem


        If ChkDate_Work(txtDate_Hol.Text.Trim) = True Then
            'MsgBox("ไม่สามารถบันทึกได้ เนื่องจากการกำหนด {วันที่วันหยุดพิเศษ} ต้องไม่ตรงกับ {วันที่วันทำงานพิเศษ}", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "วันที่ซ้ำ")
            ' MsgManager.ShowDialog(Me, "frmWorkSpecialRS", Me.Text, "Save_Failed", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message_spacial.Save_Failed_spacial_holiday, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If


        'เงือนไข ห้ามบันทึกซ้ำใน Data ตัวเอง
        If ChkDate_Hol(txtDate_Hol.Text.Trim) = True Then
            'MsgBox("ไม่สามารถแก้ไขได้เนื่องจากวันที่  " & txtDate_Work.Text.Trim & "  ได้บันทึกไปแล้ว", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "วันที่ซ้ำ")
            '  MsgManager.ShowDialog(Me, "frmWorkSpecialRS", Me.Text, "Edit_Failed", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message_spacial.Edit_Failed_spacial_holiday, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        'Call OpenConnect(True)
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn

        Try
            data.Clear() : strType = ""
            data.Add(ConvertDate(txtDate_Hol.Text.Trim)) : strType &= "T"
            data.Add(txtRemart_Hol.Text.Trim) : strType &= "T"

            strSQL = "Insert Into TimeHoliday_Spa_Config(datetimeHoliday,Remark)" &
                                " Values(@P1,@P2)"
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, data)

            Tn.Commit()
            'Call OpenConnect(False)
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try

        Call btnClear_H_Click(Me, System.EventArgs.Empty)
        ' Call EnaBtn_Hol(True, False)
    End Sub

    Private Sub LoadWork()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        Dim arrData() As String
        Dim List As ListViewItem

        strSQL = "select * from TimeWork_Spa_Config"

        Try
            'Call OpenConnect(True)
            Da = New SqlDataAdapter(strSQL, Conn)
            Da.Fill(Ds, "data")
            'Call OpenConnect(False)

            With Ds.Tables("data")
                lstWork.BeginUpdate()
                lstWork.Items.Clear()
                Dim I As Integer = 0
                For Each drw As DataRow In .Rows
                    I += 1
                    arrData = New String() {I,
                                            drw("DatetimeWork"),
                                            drw("Remark")}
                    List = New ListViewItem(arrData)
                    lstWork.Items.Add(List)
                Next
                lstWork.EndUpdate()
            End With
        Catch ex As Exception
            lstWork.EndUpdate()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
    End Sub

    Private Sub LoadWorkDev()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "select ROW_NUMBER() OVER(ORDER BY DateTimeWork desc) as row, * from TimeWork_Spa_Config order by DateTimeWork desc"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        GcWork.DataSource = Ds
        GcWork.DataMember = "Data"
    End Sub


    Private Sub LoadHoliday()
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        Dim arrData() As String
        Dim List As ListViewItem

        strSQL = "select ROW_NUMBER() OVER(ORDER BY DateTimeHoliday) as row, * from TimeHoliday_Spa_Config Order by  DateTimeHoliday"

        Try
            'Call OpenConnect(True)
            Da = New SqlDataAdapter(strSQL, Conn)
            Da.Fill(Ds, "data")
            'Call OpenConnect(False)

            With Ds.Tables("data")
                lstHol.BeginUpdate()
                lstHol.Items.Clear()
                Dim I As Integer = 0
                For Each drw As DataRow In .Rows
                    I += 1
                    arrData = New String() {I,
                                            drw("DatetimeHoliday"),
                                            drw("Remark")}
                    List = New ListViewItem(arrData)
                    lstHol.Items.Add(List)
                Next
                lstHol.EndUpdate()
            End With
        Catch ex As Exception
            lstHol.EndUpdate()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
    End Sub

    Private Sub LoadHolidayDev()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "select row_number() over(order by datetimeholiday desc) as row, * from TimeHoliday_Spa_Config order by datetimeholiday desc"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        GcHol.DataSource = Ds
        GcHol.DataMember = "Data"
    End Sub

    Private Sub btnClear_W_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear_W.Click
        '   txtDate_Work.EditValue = Now.Date
        txtDate_Work.Text = ""
        txtRemark_Work.Text = ""
        '  Call LoadWork()
        Call LoadWorkDev()
        Call EnaBtn_Work(True, False)

    End Sub

    Private Sub btnClear_H_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear_H.Click
        txtDate_Hol.Text = ""
        txtRemart_Hol.Text = ""
        '    Call LoadHoliday()
        Call LoadHolidayDev()
        Call EnaBtn_Hol(True, False)

    End Sub

    Private Sub btnDel_W_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel_W.Click
        Dim strSQL As String
        Dim strType As String
        Dim dCmd As New SqlCommand
        Dim data As New ArrayList
        Dim db As New db

        'Call OpenConnect(True)
        Try
            data.Clear() : strType = ""
            data.Add(ConvertDate(txtDate_Work.Text.Trim)) : strType &= "T"

            ' ลบข้อมูล เวลาทำงานพิเศษ
            strSQL = "Delete From TimeWork_Spa_Config " &
                    " Where DateTimeWork=@P1"
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, data)

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Call btnClear_W_Click(Me, System.EventArgs.Empty)

    End Sub

    Private Sub btnDel_H_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel_H.Click
        Dim strSQL As String
        Dim strType As String
        Dim dCmd As New SqlCommand
        Dim data As New ArrayList
        Dim db As New db

        'Call OpenConnect(True)
        Try
            data.Clear() : strType = ""
            data.Add(ConvertDate(txtDate_Hol.Text.Trim)) : strType &= "T"

            ' ลบข้อมูล เวลาทำงานพิเศษ
            strSQL = "Delete From TimeHoliday_Spa_Config " &
                    " Where DateTimeHoliday=@P1"
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, data)

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        ' Call LoadHoliday()
        Call btnClear_H_Click(Me, System.EventArgs.Empty)
    End Sub

    Function ChkDate_Work(ByVal DateWork As String) As String
        Dim DA As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select * from Timework_Spa_config Where DatetimeWork='" & ConvertDate(DateWork.Trim) & "'"

        Try
            'Call OpenConnect(True)
            DA = New SqlDataAdapter(Strsql, Conn)
            DA.Fill(Ds, "DATA")
            'Call OpenConnect(False)


            With Ds.Tables("DATA")
                If .Rows.Count = 0 Then
                    Return False
                Else
                    Return True
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function ChkDate_Hol(ByVal DateWork As String) As String
        Dim DA As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = "Select * from TimeHoliday_Spa_config Where DatetimeHoliday='" & ConvertDate(DateWork.Trim) & "'"

        Try
            'Call OpenConnect(True)
            DA = New SqlDataAdapter(Strsql, Conn)
            DA.Fill(Ds, "DATA")
            'Call OpenConnect(False)

            With Ds.Tables("DATA")
                If .Rows.Count = 0 Then
                    Return False
                Else
                    Return True
                End If
            End With

        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub EnaBtn_Work(ByVal Add As Boolean, ByVal Del As Boolean)
        btnAdd_W.Enabled = Add
        btnDel_W.Enabled = Del
    End Sub

    Private Sub EnaBtn_Hol(ByVal Add As Boolean, ByVal Del As Boolean)
        btnAdd_H.Enabled = Add
        btnDel_H.Enabled = Del
    End Sub

    Private Sub lstHol_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstHol.DoubleClick

        With lstHol
            Dim i As Integer
            For i = 0 To lstHol.SelectedItems.Count - 1
                txtDate_Hol.Text = lstHol.SelectedItems(i).SubItems(1).Text.Trim
                txtRemart_Hol.Text = lstHol.SelectedItems(i).SubItems(2).Text.Trim
            Next
        End With
        Call EnaBtn_Hol(False, True)
    End Sub

    Private Sub lstHol_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstHol.SelectedIndexChanged

    End Sub

    Private Sub lstWork_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstWork.DoubleClick

        With lstWork
            Dim i As Integer
            For i = 0 To lstWork.SelectedItems.Count - 1
                txtDate_Work.Text = lstWork.SelectedItems(i).SubItems(1).Text.Trim
                txtRemark_Work.Text = lstWork.SelectedItems(i).SubItems(2).Text.Trim
            Next
        End With
        Call EnaBtn_Work(False, True)
    End Sub

    Private Sub lstWork_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstWork.SelectedIndexChanged

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub GcHol_Click(sender As Object, e As EventArgs) Handles GcHol.Click

    End Sub

    Private Sub GvHol_DoubleClick(sender As Object, e As EventArgs) Handles GvHol.DoubleClick
        'With lstHol
        '    Dim i As Integer
        '    For i = 0 To lstHol.SelectedItems.Count - 1
        '        txtDate_Hol.Text = lstHol.SelectedItems(i).SubItems(1).Text.Trim
        '        txtRemart_Hol.Text = lstHol.SelectedItems(i).SubItems(2).Text.Trim
        '    Next
        'End With
        'Call EnaBtn_Hol(False, True)

        Try
            Dim gv As GridView = CType(sender, GridView)

            txtDate_Hol.EditValue = gv.GetRowCellValue(gv.FocusedRowHandle, "DateTimeHoliday")
            txtRemart_Hol.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Remark")

            Call EnaBtn_Hol(False, True)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GvWork_DoubleClick(sender As Object, e As EventArgs) Handles GvWork.DoubleClick

        Try
            Dim gv As GridView = CType(sender, GridView)
            txtDate_Work.EditValue = gv.GetRowCellValue(gv.FocusedRowHandle, "DateTimeWork")
            txtRemark_Work.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Remark")

            Call EnaBtn_Work(False, True)
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub GvEmp_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GvWork.CustomDrawCell
    '    If e.Column.Name = "colrow" Then
    '        If e.RowHandle < -1 Then
    '            e.DisplayText = "0"
    '        Else
    '            e.DisplayText = (e.RowHandle + 1).ToString
    '        End If
    '    End If

    'End Sub

    'Private Sub GvEmp_Cal_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GvHol.CustomDrawCell
    '    If e.Column.Name = "GridColumn1" Then
    '        If e.RowHandle < -1 Then
    '            e.DisplayText = "0"
    '        Else
    '            e.DisplayText = (e.RowHandle + 1).ToString
    '        End If
    '    End If

    'End Sub


End Class