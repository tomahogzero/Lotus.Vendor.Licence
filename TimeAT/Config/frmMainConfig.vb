Imports System.Data
Imports System.Data.SqlClient
Imports TimeAttendance.utils

Public Class frmMainConfig
    Private Sub frmMainConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadDATA()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strSQL As String
        Dim dCmd As New SqlCommand

        If IsNumeric(txtStartDay.Text) = False Then
            '    MsgBox("กรุณาป้อนตัวเลขให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            MsgBox(My.Resources.res_warning_message.correct_number, MsgBoxStyle.Information, Me.Text)
            txtStartDay.Focus()
            Exit Sub
        End If

        If IsNumeric(txtEndDay.Text) = False Then
            '  MsgBox("กรุณาป้อนตัวเลขให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            MsgBox(My.Resources.res_warning_message.correct_number, MsgBoxStyle.Information, Me.Text)
            txtEndDay.Focus()
            Exit Sub
        End If


        If IsNumeric(txtHaftDay_M.Text) = False Then
            'MsgBox("กรุณาป้อนวันที่เป็นตัวเลขให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmMainConfigRS", Me.Text, "Check_Date", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
            txtHaftDay_M.Focus()
            Exit Sub
        End If

        If Not (CInt(txtHaftDay_M.Text) > 0 And CInt(txtEndDay.Text) <= 28) Then
            'MsgBox("วันที่เริ่มควรป้อนได้ตั้งแต่วันที่ 1-28 เท่านั้น", MsgBoxStyle.Information, Me.Text)
            ' MsgManager.ShowDialog(Me, "frmMainConfigRS", Me.Text, "Check_Date_Start", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message_spacial.Check_Date_Start, MsgBoxStyle.Information, Me.Text)
            txtHaftDay_M.Focus()
            Exit Sub
        End If

        If IsNumeric(txtEndDay.Text) = False Then
            'MsgBox("กรุณาป้อนวันที่เป็นตัวเลขให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            '  MsgManager.ShowDialog(Me, "frmMainConfigRS", Me.Text, "Check_Date", MessageBoxIcon.Information)
            MsgBox(My.Resources.res_warning_message.please_input_date, MsgBoxStyle.Information, Me.Text)
            txtEndDay.Focus()
            Exit Sub
        End If

        If chkEndMonth.Checked = False Then
            If Not (CInt(txtEndDay.Text) > 0 And CInt(txtEndDay.Text) <= 28) Then
                'MsgBox("วันที่เริ่มควรป้อนได้ตั้งแต่วันที่ 1-28 เท่านั้น" & Chr(10) & _
                '        "*** ถ้าต้องการสิ้นเดือนก็ติ๊กที่ ถึงสิ้นเดือน แทน", MsgBoxStyle.Information, Me.Text)
                '   MsgManager.ShowDialog(Me, "frmMainConfigRS", Me.Text, "Check_Date_Start2", MessageBoxIcon.Information)
                MsgBox(My.Resources.res_warning_message_spacial.Check_Date_Start2, MsgBoxStyle.Information, Me.Text)

                txtEndDay.Focus()
                Exit Sub
            End If
        End If

        ' ช่วงเวลาคำนวณ time1 - 4
        If IsNumeric(txtTimeST_Cal_T1_PlusMin.Text) = False Then
            '  MsgBox("กรุณาป้อนตัวเลขให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            MsgBox(My.Resources.res_warning_message.correct_number, MsgBoxStyle.Information, Me.Text)
            txtTimeST_Cal_T1_PlusMin.Focus()
            Exit Sub
        End If

        If IsNumeric(txtRestST_Cal_T2_MinusMin.Text) = False Then
            ' MsgBox("กรุณาป้อนตัวเลขให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            MsgBox(My.Resources.res_warning_message.correct_number, MsgBoxStyle.Information, Me.Text)
            txtRestST_Cal_T2_MinusMin.Focus()
            Exit Sub
        End If

        If IsNumeric(txtRestSP_Cal_T3_PlusMin.Text) = False Then
            '  MsgBox("กรุณาป้อนตัวเลขให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            MsgBox(My.Resources.res_warning_message.correct_number, MsgBoxStyle.Information, Me.Text)
            txtRestSP_Cal_T3_PlusMin.Focus()
            Exit Sub
        End If

        If IsNumeric(txtTimeSP_Cal_T4_MinusMin.Text) = False Then
            ' MsgBox("กรุณาป้อนตัวเลขให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            MsgBox(My.Resources.res_warning_message.correct_number, MsgBoxStyle.Information, Me.Text)
            txtTimeSP_Cal_T4_MinusMin.Focus()
            Exit Sub
        End If

        ' เตื่อน alert message

        txtTimeST_Alert_Befor_Min.Text = "0"
        txtTimeSP_Alert_After_Min.Text = "0"
        txtTimeSP_Alert_Befor_Min.Text = "0"
        txtTimeSP_Alert_After_Min.Text = "0"

        If IsNumeric(txtTimeST_Alert_Befor_Min.Text) = False Then
            '  MsgBox("กรุณาป้อนตัวเลขให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            MsgBox(My.Resources.res_warning_message.correct_number, MsgBoxStyle.Information, Me.Text)
            txtTimeST_Alert_Befor_Min.Focus()
            Exit Sub
        End If

        If IsNumeric(txtTimeST_Alert_After_Min.Text) = False Then
            '   MsgBox("กรุณาป้อนตัวเลขให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            MsgBox(My.Resources.res_warning_message.correct_number, MsgBoxStyle.Information, Me.Text)
            txtTimeST_Alert_After_Min.Focus()
            Exit Sub
        End If

        If IsNumeric(txtTimeSP_Alert_Befor_Min.Text) = False Then
            ' MsgBox("กรุณาป้อนตัวเลขให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            MsgBox(My.Resources.res_warning_message.correct_number, MsgBoxStyle.Information, Me.Text)
            txtTimeSP_Alert_Befor_Min.Focus()
            Exit Sub
        End If

        If IsNumeric(txtTimeSP_Alert_After_Min.Text) = False Then
            ' MsgBox("กรุณาป้อนตัวเลขให้ถูกต้องด้วย", MsgBoxStyle.Information, Me.Text)
            MsgBox(My.Resources.res_warning_message.correct_number, MsgBoxStyle.Information, Me.Text)
            txtTimeSP_Alert_After_Min.Focus()
            Exit Sub
        End If


        If IsNumeric(txtAdjTimeOut.Text) = False Then
            txtAdjTimeOut.Text = 0
        End If

        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        Try
            strSQL = "Delete From MainConfig"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            strSQL = " Insert Into MainConfig(DayST," &
                                            " DaySP," &
                                            " PreviousM," &
                                            " NextM," &
                                            " EndM," &
                                            " HaftDay_M," &
                                            " HaftDay_A," &
                                            " AdjTimeOut," &
                                            " AdjTimeOut_Hour," &
                                            " TimeST_Cal_T1_PlusMin," &
                                            " TimeSP_Cal_T4_MinusMin," &
                                            " RestST_Cal_T2_MinusMin," &
                                            " RestSP_Cal_T3_PlusMin," &
                                            " TimeST_Alert_Befor_Min," &
                                            " TimeST_Alert_After_Min," &
                                            " TimeSP_Alert_Befor_Min," &
                                            " TimeSP_Alert_After_Min)" &
                            " Values('" & Format(CInt(txtStartDay.Text), "00") & "','" & Format(CInt(txtEndDay.Text), "00") & "'," &
                                " " & IIf(chkPreviousMonth.Checked, 1, 0) & "," &
                                " " & IIf(chkNextMonth.Checked, 1, 0) & "," &
                                " " & IIf(chkEndMonth.Checked, 1, 0) & "," &
                                " " & txtHaftDay_M.Text & "," &
                                " " & txtHaftDay_A.Text & "," &
                                " " & IIf(chkAdjTimeOUT.Checked, 1, 0) & "," &
                                " " & txtAdjTimeOut.Text & "," &
                                " " & txtTimeST_Cal_T1_PlusMin.Text & "," &
                                " " & txtTimeSP_Cal_T4_MinusMin.Text & "," &
                                " " & txtRestST_Cal_T2_MinusMin.Text & "," &
                                " " & txtRestSP_Cal_T3_PlusMin.Text & "," &
                                " " & txtTimeST_Alert_Befor_Min.Text & "," &
                                " " & txtTimeST_Alert_After_Min.Text & "," &
                                " " & txtTimeSP_Alert_Befor_Min.Text & "," &
                                " " & txtTimeSP_Alert_After_Min.Text & "" &
                                ")"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()
            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try
        '  MsgManager.ShowDialog(Me, "frmMainConfigRS", Me.Text, "Save_Complete", MessageBoxIcon.Information)
        MsgBox(My.Resources.res_warning_message.save_complete, MsgBoxStyle.Information, Me.Text)
        'MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information, Me.Text)
    End Sub

    Private Sub LoadDATA()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = " Select " &
                        " isnull(DayST,'01') as DayST, " &
                        " isnull(DaySP,'30') as DaySP, " &
                        " isnull(PreviousM,0) as PreviousM, " &
                        " isnull(NextM,0) as NextM, " &
                        " isnull(EndM,0) as EndM, " &
                        " isnull(HaftDay_M,0) as HaftDay_M, " &
                        " isnull(HaftDay_A,0) as HaftDay_A, " &
                        " isnull(AdjTimeOut,0) as AdjTimeOut, " &
                        " isnull(AdjTimeOut_Hour,0) as AdjTimeOut_Hour, " &
                        " isnull(TimeST_Cal_T1_PlusMin,0) as TimeST_Cal_T1_PlusMin, " &
                        " isnull(TimeSP_Cal_T4_MinusMin,0) as TimeSP_Cal_T4_MinusMin, " &
                        " isnull(RestST_Cal_T2_MinusMin,0) as RestST_Cal_T2_MinusMin, " &
                        " isnull(RestSP_Cal_T3_PlusMin,0) as RestSP_Cal_T3_PlusMin, " &
                        " isnull(TimeST_Alert_Befor_Min,0) as TimeST_Alert_Befor_Min, " &
                        " isnull(TimeST_Alert_After_Min,0) as TimeST_Alert_After_Min, " &
                        " isnull(TimeSP_Alert_Befor_Min,0) as TimeSP_Alert_Befor_Min, " &
                        " isnull(TimeSP_Alert_After_Min,0) as TimeSP_Alert_After_Min " &
                " From MainConfig "

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Exit Sub
            End If


            Dim Dr As DataRow = .Rows(0)

            txtStartDay.Text = Dr("DayST")
            txtEndDay.Text = Dr("DaySP")
            chkPreviousMonth.Checked = Dr("PreviousM")
            chkNextMonth.Checked = Dr("NextM")
            chkEndMonth.Checked = Dr("EndM")

            txtHaftDay_M.Text = Dr("HaftDay_M")
            txtHaftDay_A.Text = Dr("HaftDay_A")



            If IsDBNull(Dr("AdjTimeOut")) = True Then
                chkAdjTimeOUT.Checked = False
            Else
                If Dr("AdjTimeOut") = True Then
                    chkAdjTimeOUT.Checked = True
                Else
                    chkAdjTimeOUT.Checked = False
                End If
            End If

            If IsDBNull(Dr("AdjTimeOut_Hour")) = True Then
                txtAdjTimeOut.Text = "0"
            Else
                txtAdjTimeOut.Text = Dr("AdjTimeOut_Hour")
            End If

            txtTimeST_Cal_T1_PlusMin.Text = Dr("TimeST_Cal_T1_PlusMin")
            txtTimeSP_Cal_T4_MinusMin.Text = Dr("TimeSP_Cal_T4_MinusMin")
            txtRestST_Cal_T2_MinusMin.Text = Dr("RestST_Cal_T2_MinusMin")
            txtRestSP_Cal_T3_PlusMin.Text = Dr("RestSP_Cal_T3_PlusMin")
            txtTimeST_Alert_Befor_Min.Text = Dr("TimeST_Alert_Befor_Min")
            txtTimeST_Alert_After_Min.Text = Dr("TimeST_Alert_After_Min")
            txtTimeSP_Alert_Befor_Min.Text = Dr("TimeSP_Alert_Befor_Min")
            txtTimeSP_Alert_After_Min.Text = Dr("TimeSP_Alert_After_Min")
        End With
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub chkPreviousMonth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPreviousMonth.CheckedChanged
        If chkPreviousMonth.Checked = True Then
            chkNextMonth.Checked = False
            chkEndMonth.Checked = False
        End If
    End Sub

    Private Sub chkNextMonth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNextMonth.CheckedChanged
        If chkNextMonth.Checked = True Then
            chkPreviousMonth.Checked = False
            chkEndMonth.Checked = False
        End If
    End Sub

    Private Sub chkEndMonth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEndMonth.CheckedChanged
        If chkEndMonth.Checked = True Then
            chkPreviousMonth.Checked = False
            chkNextMonth.Checked = False

            txtHaftDay_M.Text = "1"
            txtEndDay.Text = "0"
        End If
    End Sub

    Private Sub LabelControl9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PanelControl5_Paint(sender As Object, e As PaintEventArgs) Handles PanelControl5.Paint

    End Sub
End Class