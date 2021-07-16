Imports TimeAttendance.utils
Imports System.IO
Imports System.Globalization

Imports System.Data
Imports System.Data.SqlClient

Public Class frmWeek_Detail
    Protected dbMgr As New DBManager
    Protected dbConnStr As String = dbMgr.getConnString

    Private Sub frmWeek_Detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnEdit.Visible = False
        btnDelete.Visible = False
        btnClear.Visible = False
        btnSearch.Visible = False
        btnPrint.Visible = False

        Call LoadWeek()
    End Sub

    Public Overrides Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If lblWK_Code.Text.Trim = "" Then
            MsgManager.ShowDialog(Me, "Week_Detail", Me.Text, "Please_Select_Round", MessageBoxIcon.Information)
            cboWeek.Focus()
            Exit Sub
        End If
        If lblWeek.Text.Trim = "" Then
            MsgManager.ShowDialog(Me, "Week_Detail", Me.Text, "Please_Select_Round_Edit", MessageBoxIcon.Information)
            Exit Sub
        End If
        If IsNumeric(txtDayST.Text) = False Then
            MsgManager.ShowDialog(Me, "Week_Detail", Me.Text, "Please_Input_Date_Numeric", MessageBoxIcon.Information)
            txtDayST.Focus()
            Exit Sub
        End If
        If CInt(txtDayST.Text) < 1 Or CInt(txtDayST.Text) > 31 Then
            MsgManager.ShowDialog(Me, "Week_Detail", Me.Text, "Please_Input_Date_Range", MessageBoxIcon.Information)
            txtDayST.Focus()
            Exit Sub
        End If

        If chkEndMonth.Checked = False Then
            If IsNumeric(txtDaySP.Text) = False Then
                MsgManager.ShowDialog(Me, "Week_Detail", Me.Text, "Please_Input_Date_Numeric", MessageBoxIcon.Information)
                txtDayST.Focus()
                Exit Sub
            End If
            If CInt(txtDaySP.Text) < 1 Or CInt(txtDaySP.Text) > 31 Then
                MsgManager.ShowDialog(Me, "Week_Detail", Me.Text, "Please_Input_Date_Range_EndMonth", MessageBoxIcon.Information)
                txtDaySP.Focus()
                Exit Sub
            End If
        End If

        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList

        Dim DayST As Integer = 0
        Dim DaySP As Integer = 0
        Dim PM_ST As Integer = 0
        Dim PM_SP As Integer = 0
        Dim NM_ST As Integer = 0
        Dim NM_SP As Integer = 0

        Dim EndMonth As Integer = 0

        DayST = txtDayST.Text.Trim
        If chkEndMonth.Checked = True Then
            DaySP = 0
            EndMonth = 1
        Else
            DaySP = txtDaySP.Text.Trim
            EndMonth = 0
        End If

        PM_ST = IIf(chkPM_ST.Checked, 1, 0)
        PM_SP = IIf(chkPM_SP.Checked, 1, 0)
        NM_ST = IIf(chkNM_ST.Checked, 1, 0)
        NM_SP = IIf(chkNM_SP.Checked, 1, 0)

        Data.Clear() : strType = ""
        Data.Add(lblWK_Code.Text.Trim) : strType &= "T"
        Data.Add(lblWeek.Text.Trim) : strType &= "T"
        Data.Add(DayST) : strType &= "I"
        Data.Add(DaySP) : strType &= "I"
        Data.Add(EndMonth) : strType &= "B"
        Data.Add(PM_ST) : strType &= "B"
        Data.Add(PM_SP) : strType &= "B"
        Data.Add(NM_ST) : strType &= "B"
        Data.Add(NM_SP) : strType &= "B"

        strSQL = "Update SAL_Week_Detail_Date Set " & _
                                            " Wk_DayST = @P3," & _
                                            " Wk_DaySP = @P4," & _
                                            " Wk_EndMonth = @P5, " & _
                                            " WK_PM_ST = @P6," & _
                                            " WK_PM_SP = @P7," & _
                                            " WK_NM_ST = @P8," & _
                                            " WK_NM_Sp = @P9" & _
                    " Where WK_Code = @P1 and " & _
                            " WK_Week = @P2 "

        Try

            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)

        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Me.Text)
            Exit Sub
        End Try

        MsgManager.ShowDialog(Me, "Messages", Me.Text, "Save_Complete", MessageBoxIcon.Information)

        Call ClearData()
        Call LoadDetailWeek()
    End Sub

    Private Sub ClearData()
        lblWeek.Text = ""
        txtDayST.Text = ""
        txtDaySP.Text = ""
        chkEndMonth.Checked = False

        chkPM_ST.Checked = False
        chkPM_SP.Checked = False
        chkNM_ST.Checked = False
        chkNM_SP.Checked = False
    End Sub

    Private Sub LoadWeek()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        strSQL = "Select WK_Name From SAL_Week Order By WK_Code"

        db.ExecuteCommand(Conn, dCmd, strSQL)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")


        With Ds.Tables("data")
            For Each dr As DataRow In .Rows
                cboWeek.Items.Add(dr("WK_Name"))
            Next
        End With
    End Sub

    Function GetWeek_Code(ByVal WK_Name As String) As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        Dim strType As String = ""
        Dim Data As New ArrayList

        Data.Clear() : strType = ""
        Data.Add(WK_Name.Trim) : strType &= "T"

        strSQL = "Select WK_Code " &
                        " From SAL_Week " &
                        " Where WK_Name = @P1 "

        Try

            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
            Da.SelectCommand = dCmd
            Da.Fill(Ds, "data")

        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Me.Text)
            Return ""
            Exit Function
        End Try

        With Ds.Tables("Data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Dim dr As DataRow = .Rows(0)
                Return dr("WK_Code")
            End If
        End With
    End Function


    Private Sub LoadDetailWeek()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        Dim strType As String = ""
        Dim Data As New ArrayList

        Data.Clear() : strType = ""
        Data.Add(lblWK_Code.Text.Trim) : strType &= "T"

        strSQL = "Select Wk_Code,WK_Week,Wk_DayST,Wk_DaySP,Wk_EndMonth, " &
                                        "WK_PM_ST,WK_PM_SP,WK_NM_ST,WK_NM_SP " &
                        " From sal_week_detail_date " &
                        " Where Wk_Code = @P1 "

        Try

            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
            Da.SelectCommand = dCmd
            Da.Fill(Ds, "data")

        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Me.Text)
            Exit Sub
        End Try

        With Ds.Tables("data")
            lstWeek.Items.Clear()

            Dim arrData() As String
            Dim List As New ListViewItem

            For Each dr As DataRow In .Rows
                Dim WK_PM_ST As String = ""
                Dim WK_NM_ST As String = ""
                Dim WK_PM_SP As String = ""
                Dim WK_NM_SP As String = ""
                Dim WK_Day_SP As String = ""
                Dim Wk_EndMonth As String = ""

                If dr("WK_PM_ST") = True Then
                    WK_PM_ST = "/"
                End If
                If dr("WK_NM_ST") = True Then
                    WK_NM_ST = "/"
                End If
                If dr("WK_PM_SP") = True Then
                    WK_PM_SP = "/"
                End If
                If dr("WK_NM_SP") = True Then
                    WK_NM_SP = "/"
                End If
                If dr("Wk_EndMonth") = True Then
                    WK_Day_SP = ""
                    Wk_EndMonth = "/"
                Else
                    WK_Day_SP = dr("Wk_DaySP")
                End If

                arrData = New String() {dr("WK_Week"),
                                        dr("Wk_DayST"),
                                        WK_PM_ST,
                                        WK_NM_ST,
                                        WK_Day_SP,
                                        WK_PM_SP,
                                        WK_NM_SP,
                                        Wk_EndMonth}
                List = New ListViewItem(arrData)
                lstWeek.Items.Add(List)
            Next
        End With
    End Sub

    Function IsID_IsExist(ByVal ID As String) As Boolean
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        Dim Data As New ArrayList
        Dim strType As String = ""

        Data.Clear() : strType = ""
        Data.Add(ID) : strType &= "T"

        strSQL = "Select * from Section" &
                " Where SecId = @P1"

        db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")


        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        End With
    End Function

    Private Sub txtDivId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblWeek.TextChanged

    End Sub

    Function AutoId() As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        strSQL = "Select Max(SecId) as maxId From Section"


        db.ExecuteCommand(Conn, dCmd, strSQL)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")


        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return "001"
            Else
                Dim dr As DataRow = .Rows(0)
                Return Format(dr("MaxID") + 1, "000")
            End If
        End With
    End Function

    Private Sub cboWeek_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboWeek.SelectedIndexChanged
        lblWK_Code.Text = GetWeek_Code(cboWeek.Text.Trim)
        Call LoadDetailWeek()
    End Sub

    Private Sub lstWeek_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstWeek.DoubleClick
        With lstWeek
            If .SelectedItems.Count = 0 Then Exit Sub

            If .SelectedItems(0).SubItems(2).Text.Trim = "" Then
                chkPM_ST.Checked = False
            Else
                chkPM_ST.Checked = True
            End If
            If .SelectedItems(0).SubItems(3).Text.Trim = "" Then
                chkNM_ST.Checked = False
            Else
                chkNM_ST.Checked = True
            End If

            If .SelectedItems(0).SubItems(5).Text.Trim = "" Then
                chkPM_SP.Checked = False
            Else
                chkPM_SP.Checked = True
            End If
            If .SelectedItems(0).SubItems(6).Text.Trim = "" Then
                chkNM_SP.Checked = False
            Else
                chkNM_SP.Checked = True
            End If

            If .SelectedItems(0).SubItems(7).Text.Trim = "" Then
                chkEndMonth.Checked = False
            Else
                chkEndMonth.Checked = True
            End If

            lblWeek.Text = .SelectedItems(0).SubItems(0).Text.Trim
            txtDayST.Text = .SelectedItems(0).SubItems(1).Text.Trim

            txtDaySP.Text = .SelectedItems(0).SubItems(4).Text.Trim
        End With
    End Sub

    Private Sub lstWeek_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstWeek.SelectedIndexChanged

    End Sub

    Private Sub chkPM_ST_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPM_ST.CheckedChanged
        If chkPM_ST.Checked = True Then
            chkNM_ST.Checked = False
            chkEndMonth.Checked = False
        End If
    End Sub

    Private Sub chkNM_ST_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNM_ST.CheckedChanged
        If chkNM_ST.Checked = True Then
            chkPM_ST.Checked = False
            chkEndMonth.Checked = False
        End If
    End Sub

    Private Sub chkEndMonth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEndMonth.CheckedChanged
        If chkEndMonth.Checked = True Then
            txtDaySP.Enabled = False
            txtDaySP.Text = "0"

            chkPM_SP.Checked = False
            chkNM_SP.Checked = False
        Else
            txtDaySP.Enabled = True
            txtDaySP.Text = "0"
        End If
    End Sub

    Private Sub chkPM_SP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPM_SP.CheckedChanged
        If chkPM_SP.Checked = True Then
            chkNM_SP.Checked = False
            chkEndMonth.Checked = False
        End If
    End Sub

    Private Sub chkNM_SP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNM_SP.CheckedChanged
        If chkNM_SP.Checked = True Then
            chkPM_SP.Checked = False
            chkEndMonth.Checked = False
        End If
    End Sub
End Class