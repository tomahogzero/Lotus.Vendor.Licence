Imports System.Data
Imports System.Data.SqlClient
Imports TimeAttendance.utils

Public Class frmRPTSummarizeVacationByYear_Config

    Private Sub frmRPTSummarizeVacationByYear_Config_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadData()
    End Sub

    Private Sub TapyAbsent()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim List As New ListViewItem
        Dim arrData() As String

        strSQL = "select code,description " & _
                    "from dbo.TimeWorkingStatus"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                'MsgBox("����բ����ŷ�����!!!")
                MsgManager.ShowDialog(Me, "frmRPTSummarizeVacationByYear_ConfigRS", Me.Text, "Data_Search_NotFound", MessageBoxIcon.Information)
                clbAbsType.Items.Clear()
                Exit Sub
            End If
            clbAbsType.Items.Clear()
            For Each dr As DataRow In .Rows
                arrData = New String() {dr("code"), _
                                        dr("description")}
                List = New ListViewItem(arrData)
                clbAbsType.Items.Add(List)
            Next

        End With

    End Sub

    Private Sub CheckID(ByVal i As Integer)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "select valid  " & _
                    "from dbo.RPT_SummarizeVacationByYear_Config_Detail " & _
                    "where ID= 'C" & i & "'"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            lvType.Items.Clear()
            For Each dr As DataRow In .Rows
                lvType.Items.Add(dr("valid"))
            Next
        End With
    End Sub

    Private Sub CheckItem()
        Dim ct As Integer = 0
        Dim dt As Integer = 0
        ct = lvType.Items.Count
        dt = clbAbsType.Items.Count
        For c As Integer = 0 To ct - 1
            For d As Integer = 0 To dt - 1
                If lvType.Items(c).ToString.Trim = clbAbsType.Items(d).ToString.Trim Then
                    clbAbsType.Items(d).Checked = True
                End If
            Next
        Next
    End Sub

    Private Sub txtVCol1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVCol1.GotFocus
        Call ChechGotFogus(1)

        Call TapyAbsent()
        Call CheckID(1)
        Call CheckItem()
    End Sub

    Private Sub txtVCol2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVCol2.GotFocus
        Call ChechGotFogus(2)

        Call TapyAbsent()
        Call CheckID(2)
        Call CheckItem()
    End Sub

    Private Sub txtVCol3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVCol3.GotFocus
        Call ChechGotFogus(3)

        Call TapyAbsent()
        Call CheckID(3)
        Call CheckItem()
    End Sub

    Private Sub txtVCol4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVCol4.GotFocus
        Call ChechGotFogus(4)

        Call TapyAbsent()
        Call CheckID(4)
        Call CheckItem()
    End Sub

    Private Sub txtVCol5_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVCol5.GotFocus
        Call ChechGotFogus(5)

        Call TapyAbsent()
        Call CheckID(5)
        Call CheckItem()
    End Sub

    Private Sub LoadData()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "select vCol1=isnull(vCol1,''),vCol2=isnull(vCol2,'')," & _
                        "vCol3=isnull(vCol3,''),vCol4=isnull(vCol4,'')," & _
                        "vCol5=isnull(vCol5,'')," & _
                        "vCalType1=isnull(vCalType1,''),vCalType2=isnull(vCalType2,'')," & _
                        "vCalType3=isnull(vCalType3,''),vCalType4=isnull(vCalType4,'')," & _
                        "vCalType5=isnull(vCalType5,''),absCalType=isnull(absCalType,'') " & _
                        "from RPT_SummarizeVacationByYear_Config"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Call ClearData()
            Else
                Dim dr As DataRow = .Rows(0)
                txtVCol1.Text = dr("vCol1")
                txtVCol2.Text = dr("vCol2")
                txtVCol3.Text = dr("vCol3")
                txtVCol4.Text = dr("vCol4")
                txtVCol5.Text = dr("vCol5")
                cboVCalType1.SelectedIndex = IIf(dr("vCalType1") = "D", 0, 1)
                cboVCalType2.SelectedIndex = IIf(dr("vCalType2") = "D", 0, 1)
                cboVCalType3.SelectedIndex = IIf(dr("vCalType3") = "D", 0, 1)
                cboVCalType4.SelectedIndex = IIf(dr("vCalType4") = "D", 0, 1)
                cboVCalType5.SelectedIndex = IIf(dr("vCalType5") = "D", 0, 1)
                cboAbsCalType.SelectedIndex = IIf(dr("absCalType") = "D", 0, 1)
            End If
        End With
    End Sub

    Private Sub ClearData()
        txtVCol1.Text = ""
        txtVCol2.Text = ""
        txtVCol3.Text = ""
        txtVCol4.Text = ""
        txtVCol5.Text = ""
        cboVCalType1.SelectedIndex = 0
        cboVCalType2.SelectedIndex = 0
        cboVCalType3.SelectedIndex = 0
        cboVCalType4.SelectedIndex = 0
        cboVCalType5.SelectedIndex = 0
        cboAbsCalType.SelectedIndex = 0
    End Sub

    Private Sub SaveData(ByVal i As Integer)
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Data As New ArrayList
        Dim strType As String
        Dim db As New db
        Dim Cdata As Integer
        Dim setmid As String = ""
        Cdata = clbAbsType.Items.Count

        Try

            strSQL = "Delete From RPT_SummarizeVacationByYear_Config_Detail where id = 'C" & i & "'"
            db.ExecuteCommand(Conn, dCmd, strSQL)

            For cd As Integer = 0 To Cdata - 1
                If clbAbsType.Items(cd).Checked = True Then

                    setmid = Mid((clbAbsType.Items(cd).ToString.Trim), 14, 16)
                    Label1.Text = Mid(setmid, 3, 3)
                    Data.Clear() : strType = ""
                    Data.Add("C" & i & "") : strType &= "T"
                    Data.Add(Label1.Text.Trim) : strType &= "T"
                    strSQL = "Insert Into RPT_SummarizeVacationByYear_Config_Detail" & _
                                            "(id,valid) " & _
                             " Values(@P1,@P2 )"
                    db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
                    setmid = ""
                    Label1.Text = ""
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try
        'MsgBox("�ѹ�֡���������º��������", MsgBoxStyle.Information, Me.Text)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Data As New ArrayList
        Dim strType As String
        Dim db As New db
        Try

            strSQL = "Delete From RPT_SummarizeVacationByYear_Config"
            db.ExecuteCommand(Conn, dCmd, strSQL)

            Data.Clear() : strType = ""
            Data.Add(txtVCol1.Text.Trim) : strType &= "T"
            Data.Add(txtVCol2.Text.Trim) : strType &= "T"
            Data.Add(txtVCol3.Text.Trim) : strType &= "T"
            Data.Add(txtVCol4.Text.Trim) : strType &= "T"
            Data.Add(txtVCol5.Text.Trim) : strType &= "T"
            Data.Add(IIf(cboVCalType1.SelectedIndex = 0, "D", "H")) : strType &= "T"
            Data.Add(IIf(cboVCalType2.SelectedIndex = 0, "D", "H")) : strType &= "T"
            Data.Add(IIf(cboVCalType3.SelectedIndex = 0, "D", "H")) : strType &= "T"
            Data.Add(IIf(cboVCalType4.SelectedIndex = 0, "D", "H")) : strType &= "T"
            Data.Add(IIf(cboVCalType5.SelectedIndex = 0, "D", "H")) : strType &= "T"
            Data.Add(IIf(cboAbsCalType.SelectedIndex = 0, "D", "H")) : strType &= "T"

            strSQL = "Insert Into RPT_SummarizeVacationByYear_Config(vCol1,vCol2,vCol3," & _
                                    " vCol4,vCol5," & _
                                    " vCalType1,vCalType2,vCalType3," & _
                                    " vCalType4,vCalType5,absCalType )" & _
                     " Values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11 )"
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try
        MsgManager.ShowDialog(Me, "frmRptAllEmpWorkRS", Me.Text, "Save_Complete", MessageBoxIcon.Information)
        'MsgBox("�ѹ�֡���������º��������", MsgBoxStyle.Information, Me.Text)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub



    Private Sub btnSaveType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveType.Click
        Call SaveData(CInt(lblColumnID.Text.Trim))
        Call CheckID(CInt(lblColumnID.Text.Trim))
        Call CheckItem()
        lblColumnID.Text = ""

        MsgManager.ShowDialog(Me, "frmRPTSummarizeVacationByYear_ConfigRS", Me.Text, "Save_Type", MessageBoxIcon.Information)
        'MsgBox("�ѹ�֡���������º��������", MsgBoxStyle.Information, Me.Text)
    End Sub

    Private Sub txtVCol1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVCol1.LostFocus

    End Sub

    Private Sub ChechGotFogus(ByVal i As Integer)
        lblColumnID.Text = CStr(i)
        lblColumns.Text = "Columns " & i
    End Sub

End Class