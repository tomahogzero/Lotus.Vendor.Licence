Imports System.Data
Imports System.Data.SqlClient
Imports TimeAttendance.utils

Public Class frmWorkingTime

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If IsDate("2006/01/01 " & txtDayStart.Text.Trim) = False Then
            'MsgBox("��سһ�͹�������١��ͧ����", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmWorkingTimeRS", Me.Text, "Check_Time", MessageBoxIcon.Information)
            txtDayStart.Focus()
            txtDayStart.SelectAll()
            Exit Sub
        End If

        If IsDate("2006/01/01 " & txtDayStop.Text.Trim) = False Then
            'MsgBox("��سһ�͹�������١��ͧ����", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmWorkingTimeRS", Me.Text, "Check_Time", MessageBoxIcon.Information)
            txtDayStop.Focus()
            txtDayStop.SelectAll()
            Exit Sub
        End If

        If IsDate("2006/01/01 " & txtMidDayStart.Text.Trim) = False Then
            'MsgBox("��سһ�͹�������١��ͧ����", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmWorkingTimeRS", Me.Text, "Check_Time", MessageBoxIcon.Information)
            txtMidDayStart.Focus()
            txtMidDayStart.SelectAll()
            Exit Sub
        End If

        If IsDate("2006/01/01 " & txtMidDayStop.Text.Trim) = False Then
            'MsgBox("��سһ�͹�������١��ͧ����", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmWorkingTimeRS", Me.Text, "Check_Time", MessageBoxIcon.Information)
            txtMidDayStop.Focus()
            txtMidDayStop.SelectAll()
            Exit Sub
        End If

        If IsDate("2006/01/01 " & txtTimeEndDay.Text.Trim) = False Then
            'MsgBox("��سһ�͹�������١��ͧ����", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmWorkingTimeRS", Me.Text, "Check_Time", MessageBoxIcon.Information)
            txtTimeEndDay.Focus()
            txtTimeEndDay.SelectAll()
            Exit Sub
        End If

        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Try
            strSQL = "Delete From TimeWorkingTime"
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            strSQL = "Insert Into " & _
                    " TimeWorkingTime(DayStart,DayStop,MidDayStart,MidDayStop,NextDay,TimeEndDay," & _
                    " Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday)" & _
                    " Values(" & _
                    " '" & txtDayStart.Text.Trim & "','" & txtDayStop.Text.Trim & "'," & _
                    " '" & txtMidDayStart.Text.Trim & "','" & txtMidDayStop.Text.Trim & "'," & _
                    " " & IIf(chkNextDay.Checked = True, 1, 0) & "," & _
                    " '" & txtTimeEndDay.Text.Trim & "'," & _
                    " " & IIf(chkMonDay.Checked = True, 1, 0) & "," & _
                    " " & IIf(chkTuesday.Checked = True, 1, 0) & "," & _
                    " " & IIf(chkWednesday.Checked = True, 1, 0) & "," & _
                    " " & IIf(chkThursday.Checked = True, 1, 0) & "," & _
                    " " & IIf(chkFriday.Checked = True, 1, 0) & "," & _
                    " " & IIf(chkSaturday.Checked = True, 1, 0) & "," & _
                    " " & IIf(chkSunday.Checked = True, 1, 0) & ")"

            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        'MsgBox("�ѹ�֡���������������", MsgBoxStyle.Information, Me.Text)
        MsgManager.ShowDialog(Me, "frmWorkingTimeRS", Me.Text, "Save_Complete", MessageBoxIcon.Information)
    End Sub

    Private Sub frmWorkingTime_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        fWorkingTime = Nothing
    End Sub

    Private Sub frmWorkingTime_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
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

    Private Sub frmWorkingTime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DA As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select * From TimeWorkingTime"
        DA = New SqlDataAdapter(strSQL, Conn)
        DA.Fill(Ds, "Data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                txtDayStart.Text = ""
                txtDayStop.Text = ""
                txtMidDayStart.Text = ""
                txtMidDayStop.Text = ""
                chkNextDay.Checked = False
                txtTimeEndDay.Text = ""
                chkMonDay.Checked = False
                chkTuesday.Checked = False
                chkWednesday.Checked = False
                chkThursday.Checked = False
                chkFriday.Checked = False
                chkSaturday.Checked = False
                chkSunday.Checked = False
                Ds.Clear()
                Exit Sub
            End If

            txtDayStart.Text = .Rows(0).Item("DayStart")
            txtDayStop.Text = .Rows(0).Item("DayStop")
            txtMidDayStart.Text = .Rows(0).Item("MidDayStart")
            txtMidDayStop.Text = .Rows(0).Item("MidDayStop")
            chkNextDay.Checked = .Rows(0).Item("NextDay")
            txtTimeEndDay.Text = .Rows(0).Item("TimeEndDay")
            chkMonDay.Checked = .Rows(0).Item("Monday")
            chkTuesday.Checked = .Rows(0).Item("Tuesday")
            chkWednesday.Checked = .Rows(0).Item("Wednesday")
            chkThursday.Checked = .Rows(0).Item("Thursday")
            chkFriday.Checked = .Rows(0).Item("Friday")
            chkSaturday.Checked = .Rows(0).Item("Saturday")
            chkSunday.Checked = .Rows(0).Item("Sunday")
            Ds.Clear()

        End With
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class