Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports TimeAttendance.utils

Public Class frmOtDeductRate

    Private Sub frmOtDeductRate_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        '   fOTRate = Nothing
    End Sub

    Private Sub frmLateRateCash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
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

    Private Sub frmOTRate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ClearData()
        '   Call LoadData()
        Call LoadDatadev()
        Call EnaCmd(True, False, False)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call ClearData()
        ' Call LoadData()
        Call LoadDatadev()
        Call EnaCmd(True, False, False)
        txtCode.Focus()
    End Sub

    Private Sub ClearData()
        txtCode.Text = ""
        txtMnStart.Text = ""
        txtMnStop.Text = ""
        txtPay.Text = ""
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtCode.Text.Trim = "" Then
            'MsgBox("กรุณาป้อนรหัสด้วย", MsgBoxStyle.Information, Me.Text)

            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblCode.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtCode.Focus()
            Exit Sub
        End If

        If IsNumeric(txtMnStart.Text.Trim) = False Then
            'MsgBox("กรุณาป้อน OT (นาที) เป็นตัวเลขให้ถูกต้อง", MsgBoxStyle.Information, Me.Text)
            '    MsgManager.ShowDialog(Me, "frmOTRateRS", Me.Text, "Insert_OT", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.correct_number, MsgBoxStyle.Information, Me.Text)
            txtMnStart.Focus()
            Exit Sub
        End If

        If IsNumeric(txtMnStop.Text.Trim) = False Then
            'MsgBox("กรุณาป้อน OT (นาที) เป็นตัวเลขให้ถูกต้อง", MsgBoxStyle.Information, Me.Text)
            ' MsgManager.ShowDialog(Me, "frmOTRateRS", Me.Text, "Insert_OT", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.correct_number, MsgBoxStyle.Information, Me.Text)
            txtMnStop.Focus()
            Exit Sub
        End If

        If IsNumeric(txtPay.Text.Trim) = False Then
            'MsgBox("กรุณาป้อนตัวเลขให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmOTRateRS", Me.Text, "Check_Number", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.correct_number, MsgBoxStyle.Information, Me.Text)
            txtPay.Focus()
            txtPay.SelectAll()
            Exit Sub
        End If

        If dataIsExist(CInt(txtMnStart.Text), CInt(txtMnStop.Text)) = True Then
            'MsgBox("นาทีนี้ถูกใช้แล้ว กรุณาเปลี่ยนใหม่", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmOTRateRS", Me.Text, "MS_In_Use", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message_spacial.MS_In_Use, MsgBoxStyle.Information, Me.Text)
            txtMnStart.Focus()
            Exit Sub
        End If

        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Code As String = txtCode.Text.Trim
        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try

            strSQL = "Delete From TimeOTDeducRate" &
                    " Where Code = '" & Code.Trim & "'"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            strSQL = "Insert Into TimeOTDeducRate(Code,MnST,MnSP,Deduc,LastUpdate) Values(" &
                    " '" & Code.Trim & "'," &
                    " " & txtMnStart.Text.Trim & "," &
                    " " & txtMnStop.Text.Trim & "," &
                    " " & txtPay.Text.Trim & "," &
                    " Getdate())"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim Code As String = txtCode.Text.Trim

        If txtCode.Text.Trim = "" Then
            'MsgBox("กรุณาป้อนรหัสด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmOTRateRS", Me.Text, "Insert_ID", MessageBoxIcon.Information)
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblCode.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtCode.Focus()
            Exit Sub
        End If

        If IsNumeric(txtMnStart.Text.Trim) = False Then
            'MsgBox("กรุณาป้อน OT (นาที) เป็นตัวเลขให้ถูกต้อง", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmOTRateRS", Me.Text, "Insert_OT", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.correct_number, MsgBoxStyle.Information, Me.Text)
            txtMnStart.Focus()
            Exit Sub
        End If

        If IsNumeric(txtMnStop.Text.Trim) = False Then
            'MsgBox("กรุณาป้อน OT (นาที) เป็นตัวเลขให้ถูกต้อง", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmOTRateRS", Me.Text, "Insert_OT", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.correct_number, MsgBoxStyle.Information, Me.Text)
            txtMnStop.Focus()
            Exit Sub
        End If

        If IsNumeric(txtPay.Text.Trim) = False Then
            'MsgBox("กรุณาป้อนตัวเลขให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmOTRateRS", Me.Text, "Check_Number", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.correct_number, MsgBoxStyle.Information, Me.Text)
            txtPay.Focus()
            txtPay.SelectAll()
            Exit Sub
        End If

        If dataIsExist(CInt(txtMnStart.Text), CInt(txtMnStop.Text), Code.Trim) = True Then
            'MsgBox("นาทีนี้ถูกใช้แล้ว กรุณาเปลี่ยนใหม่", MsgBoxStyle.Information, Me.Text)
            '   MsgManager.ShowDialog(Me, "frmOTRateRS", Me.Text, "MS_In_Use", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message_spacial.MS_In_Use, MsgBoxStyle.Information, Me.Text)
            txtMnStart.Focus()
            Exit Sub
        End If

        Dim dCmd As New SqlCommand
        Dim strSQL As String

        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try

            strSQL = "Delete From TimeOTDeducRate" &
                    " Where Code = '" & Code.Trim & "'"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            strSQL = "Insert Into TimeOTDeducRate(Code,MnST,MnSP,Deduc,LastUpdate) Values(" &
                    " '" & Code.Trim & "'," &
                    " " & txtMnStart.Text.Trim & "," &
                    " " & txtMnStop.Text.Trim & "," &
                    " " & txtPay.Text.Trim & "," &
                    " Getdate())"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim Code As String = txtCode.Text.Trim

        If txtCode.Text.Trim = "" Then
            'MsgBox("กรุณาป้อนรหัสด้วย", MsgBoxStyle.Information, Me.Text)
            '    MsgManager.ShowDialog(Me, "frmOTRateRS", Me.Text, "Insert_ID", MessageBoxIcon.Information)
            MsgBox(String.Format(My.Resources.res_warning_message.please_input_1parameter, Replace(lblCode.Text, ":", "")), MsgBoxStyle.Information, Me.Text)
            txtCode.Focus()
            Exit Sub
        End If

        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            strSQL = "Delete From TimeOTDeducRate" &
                    " Where Code = '" & Code.Trim & "'"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End Try
        Call btnClear_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub LoadData()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim arrData() As String
        Dim List As ListViewItem
        strSQL = "Select Code," &
                        " MnST = Isnull(MnST,0)," &
                        " MnSP = Isnull(MnSP,0)," &
                        " Deduc = Isnull(Deduc,0),LastUpdate" &
                " From TimeOTDeducRate " &
                " Order by MnST"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            lstOtRate.Items.Clear()
            Dim I As Integer
            For I = 0 To .Rows.Count - 1
                arrData = New String() {I + 1,
                                    .Rows(I).Item("Code"),
                                    .Rows(I).Item("MnST"),
                                    .Rows(I).Item("MnSP"),
                                    .Rows(I).Item("Deduc"),
                                    Format(.Rows(I).Item("LastUpdate"), "dd/MM/yyyy HH:mm:ss")}
                List = New ListViewItem(arrData)
                lstOtRate.Items.Add(List)
            Next
            Ds.Clear()
        End With
    End Sub

    Private Sub LoadDatadev()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "Select ROW_NUMBER() OVER(ORDER BY MnST) as row, Code," &
                        " MnST = Isnull(MnST,0)," &
                        " MnSP = Isnull(MnSP,0)," &
                        " Deduc = Isnull(Deduc,0),LastUpdate" &
                " From TimeOTDeducRate " &
                " Order by MnST"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")

        GcOtRate.DataSource = Ds
        GcOtRate.DataMember = "Data"

    End Sub

    Private Sub EnaCmd(ByVal Add As Boolean, ByVal Edit As Boolean, ByVal Delete As Boolean)
        btnAdd.Enabled = Add
        btnEdit.Enabled = Edit
        btnDelete.Enabled = Delete
    End Sub

    Private Sub txtCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select Code," &
                        " MnST = Isnull(MnST,0)," &
                        " MnSP = Isnull(MnSP,0)," &
                        " Deduc = Isnull(Deduc,0),LastUpdate" &
                " From TimeOTDeducRate " &
                " Where Code = '" & txtCode.Text.Trim & "'" &
                " Order by Code "
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            If .Rows.Count = 0 Then
                Dim Code As String
                Code = txtCode.Text.Trim
                Call ClearData()
                txtCode.Text = Code.Trim
                Call EnaCmd(True, False, False)
                Ds.Clear()
                Exit Sub
            End If
            txtMnStart.Text = .Rows(0).Item("MnST")
            txtMnStop.Text = .Rows(0).Item("MnSP")
            txtPay.Text = .Rows(0).Item("Deduc")
            Call EnaCmd(False, True, True)
        End With
    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lstOtRate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstOtRate.SelectedIndexChanged
        With lstOtRate
            If .SelectedItems.Count = 0 Then Exit Sub
            Dim Code As String = .SelectedItems(0).SubItems(1).Text.Trim
            txtCode.Text = Code.Trim
            txtCode_LostFocus(Me, System.EventArgs.Empty)
        End With
    End Sub

    Private Sub btnGenScrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FileName As String
        'SaveFileDialog1.Filter = "All File|*.*"
        SaveFileDialog1.Filter = "Text File|*.txt"
        SaveFileDialog1.ShowDialog()
        Application.DoEvents()
        If Trim(SaveFileDialog1.FileName) = "" Then
            FileName = ""
            Exit Sub
        End If
        'txtFileName.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
        FileName = SaveFileDialog1.FileName

        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim SQLExport As String

        strSQL = "Select * from TimeOTDeducRate Order By Code"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            Dim I As Integer
            For I = 0 To Ds.Tables("Data").Rows.Count - 1
                Dim file As New System.IO.StreamWriter(FileName, True)

                SQLExport = "Insert Into TimeOTDeducRate(Code,Holiday,TimeSt,TimeSp,Amt,Rate,Remark,LastUpdate) Values(" &
                            " '" & .Rows(I).Item("Code") & "'," &
                            " " & .Rows(I).Item("Holiday") & "," &
                            " '" & .Rows(I).Item("TimeSt") & "'," &
                            " '" & .Rows(I).Item("TimeSp") & "'," &
                            " " & .Rows(I).Item("Amt") & "," &
                            " " & .Rows(I).Item("Rate") & "," &
                            " '" & .Rows(I).Item("Remark") & "'," &
                            " Getdate())"

                file.WriteLine(SQLExport)
                file.Close()
            Next
            '  MsgManager.ShowDialog(Me, "frmOTRateRS", Me.Text, "Gen_Scrip_Complete", MessageBoxIcon.Information)

            MsgBox(My.Resources.res_warning_message_spacial.Gen_Scrip_Complete, MsgBoxStyle.Information, Me.Text)
            'MsgBox("Gen Scrip Complete", MsgBoxStyle.Information, "Gen Scrip")
        End With
    End Sub

    Function dataIsExist(ByVal MnST As Integer, ByVal MnSP As Integer) As Boolean
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSQL As String

        strSQL = "Select MnST " &
                " From TimeOTDeducRate " &
                " Where (" & MnST & " Between MnST and MnSP) Or " &
                    " (" & MnSP & " Between MnST and MnSP) "
        da = New SqlDataAdapter(strSQL, Conn)
        da.Fill(ds, "data")

        With ds.Tables("data")
            If .Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        End With
    End Function

    Function dataIsExist(ByVal MnST As Integer, ByVal MnSP As Integer, ByVal Code As String) As Boolean
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSQL As String

        strSQL = "Select MnST " &
                " From TimeOTDeducRate " &
                " Where Code <> '" & Code.Trim & "' and ((" & MnST & " Between MnST and MnSP) Or " &
                    " (" & MnSP & " Between MnST and MnSP)) "
        da = New SqlDataAdapter(strSQL, Conn)
        da.Fill(ds, "data")

        With ds.Tables("data")
            If .Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        End With
    End Function



    Private Sub GvOtRate_DoubleClick(sender As Object, e As EventArgs) Handles GvOtRate.DoubleClick
        Try
            Dim gv As GridView = CType(sender, GridView)

            '   If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "Code")) = True Then Exit Sub

            txtCode.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Code")
            txtMnStart.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "MnST")
            txtMnStop.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "MnSP")
            txtPay.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Deduc")
            txtCode_LostFocus(Me, System.EventArgs.Empty)
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub GvHoliday_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GvOtRate.CustomDrawCell
    '    If e.Column.Name = "colrow" Then
    '        If e.RowHandle < -1 Then
    '            e.DisplayText = "0"
    '        Else
    '            e.DisplayText = (e.RowHandle + 1).ToString
    '        End If
    '    End If

    'End Sub

    Private Sub GcOtRate_Click(sender As Object, e As EventArgs) Handles GcOtRate.Click

    End Sub

    Private Sub txtCode_EditValueChanged(sender As Object, e As EventArgs) Handles txtCode.EditValueChanged

    End Sub



    Private Sub txtMnStart_EditValueChanged(sender As Object, e As EventArgs) Handles txtMnStart.EditValueChanged

    End Sub

    Private Sub txtMnStart_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMnStart.KeyPress
        'If Asc(e.KeyChar) = 13 Then
        '    txtMnStop.Text = ""
        '    txtMnStop.Focus()

        'End If
    End Sub

    Private Sub txtMnStop_EditValueChanged(sender As Object, e As EventArgs) Handles txtMnStop.EditValueChanged

    End Sub

    Private Sub txtMnStop_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMnStop.KeyPress
        'If Asc(e.KeyChar) = 13 Then
        '    txtPay.Text = ""
        '    txtPay.Focus()

        'End If
    End Sub

    Private Sub PanelControl1_Paint(sender As Object, e As PaintEventArgs) Handles PanelControl1.Paint

    End Sub
End Class