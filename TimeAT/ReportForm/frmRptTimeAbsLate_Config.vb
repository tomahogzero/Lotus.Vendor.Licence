Imports System.Data
Imports System.Data.SqlClient
Imports TimeAttendance.utils

Public Class frmRptTimeAbsLate_Config

    Private Sub frmRptTimeAbsLate_Config_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadVacation()
        Call LoadCalType()

        Call LoadData()
    End Sub

    Private Sub LoadVacation()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "select Code,Description from TimeWorkingstatus Order By Code"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            cboVLink1.Items.Clear()
            cboVLink2.Items.Clear()
            cboVLink3.Items.Clear()
            cboVLink4.Items.Clear()
            cboVLink5.Items.Clear()
            cboVLink6.Items.Clear()
            cboVLink7.Items.Clear()
            cboVLink8.Items.Clear()
            cboVLink9.Items.Clear()
            cboVLink10.Items.Clear()

            cboVLink1.Items.Add("")
            cboVLink2.Items.Add("")
            cboVLink3.Items.Add("")
            cboVLink4.Items.Add("")
            cboVLink5.Items.Add("")
            cboVLink6.Items.Add("")
            cboVLink7.Items.Add("")
            cboVLink8.Items.Add("")
            cboVLink9.Items.Add("")
            cboVLink10.Items.Add("")
            For Each dr As DataRow In .Rows
                cboVLink1.Items.Add(dr("Description"))
                cboVLink2.Items.Add(dr("Description"))
                cboVLink3.Items.Add(dr("Description"))
                cboVLink4.Items.Add(dr("Description"))
                cboVLink5.Items.Add(dr("Description"))
                cboVLink6.Items.Add(dr("Description"))
                cboVLink7.Items.Add(dr("Description"))
                cboVLink8.Items.Add(dr("Description"))
                cboVLink9.Items.Add(dr("Description"))
                cboVLink10.Items.Add(dr("Description"))
            Next
        End With
    End Sub

    Private Sub LoadCalType()
        ' Clear
        cboVCalType1.Items.Clear()
        cboVCalType2.Items.Clear()
        cboVCalType3.Items.Clear()
        cboVCalType4.Items.Clear()
        cboVCalType5.Items.Clear()
        cboVCalType6.Items.Clear()
        cboVCalType7.Items.Clear()
        cboVCalType8.Items.Clear()
        cboVCalType9.Items.Clear()
        cboVCalType10.Items.Clear()
        cboAbsCalType.Items.Clear()

        ' Add Type
        cboVCalType1.Items.Add("«—π") : cboVCalType1.Items.Add("™—Ë«‚¡ß")
        cboVCalType2.Items.Add("«—π") : cboVCalType2.Items.Add("™—Ë«‚¡ß")
        cboVCalType3.Items.Add("«—π") : cboVCalType3.Items.Add("™—Ë«‚¡ß")
        cboVCalType4.Items.Add("«—π") : cboVCalType4.Items.Add("™—Ë«‚¡ß")
        cboVCalType5.Items.Add("«—π") : cboVCalType5.Items.Add("™—Ë«‚¡ß")
        cboVCalType6.Items.Add("«—π") : cboVCalType6.Items.Add("™—Ë«‚¡ß")
        cboVCalType7.Items.Add("«—π") : cboVCalType7.Items.Add("™—Ë«‚¡ß")
        cboVCalType8.Items.Add("«—π") : cboVCalType5.Items.Add("™—Ë«‚¡ß")
        cboVCalType9.Items.Add("«—π") : cboVCalType6.Items.Add("™—Ë«‚¡ß")
        cboVCalType10.Items.Add("«—π") : cboVCalType7.Items.Add("™—Ë«‚¡ß")
        cboAbsCalType.Items.Add("«—π") : cboAbsCalType.Items.Add("™—Ë«‚¡ß")

        ' Set Focus
        cboVCalType1.SelectedIndex = 0
        cboVCalType2.SelectedIndex = 0
        cboVCalType3.SelectedIndex = 0
        cboVCalType4.SelectedIndex = 0
        cboVCalType5.SelectedIndex = 0
        cboVCalType6.SelectedIndex = 0
        cboVCalType7.SelectedIndex = 0
        cboVCalType8.SelectedIndex = 0
        cboVCalType9.SelectedIndex = 0
        cboVCalType10.SelectedIndex = 0
        cboAbsCalType.SelectedIndex = 0
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Data As New ArrayList
        Dim strType As String
        Dim db As New db
        Try

            strSQL = "Delete From RPT_TimeAbsLate_config"
            db.ExecuteCommand(Conn, dCmd, strSQL)

            Data.Clear() : strType = ""
            Data.Add(txtVCol1.Text.Trim) : strType &= "T"
            Data.Add(txtVCol2.Text.Trim) : strType &= "T"
            Data.Add(txtVCol3.Text.Trim) : strType &= "T"
            Data.Add(txtVCol4.Text.Trim) : strType &= "T"
            Data.Add(txtVCol5.Text.Trim) : strType &= "T"
            Data.Add(txtVCol6.Text.Trim) : strType &= "T"
            Data.Add(txtVCol7.Text.Trim) : strType &= "T"
            Data.Add(txtVCol8.Text.Trim) : strType &= "T"
            Data.Add(txtVCol9.Text.Trim) : strType &= "T"
            Data.Add(txtVCol10.Text.Trim) : strType &= "T"

            Data.Add(GetData.GetValId(cboVLink1.Text.Trim)) : strType &= "T"
            Data.Add(GetData.GetValId(cboVLink2.Text.Trim)) : strType &= "T"
            Data.Add(GetData.GetValId(cboVLink3.Text.Trim)) : strType &= "T"
            Data.Add(GetData.GetValId(cboVLink4.Text.Trim)) : strType &= "T"
            Data.Add(GetData.GetValId(cboVLink5.Text.Trim)) : strType &= "T"
            Data.Add(GetData.GetValId(cboVLink6.Text.Trim)) : strType &= "T"
            Data.Add(GetData.GetValId(cboVLink7.Text.Trim)) : strType &= "T"
            Data.Add(GetData.GetValId(cboVLink8.Text.Trim)) : strType &= "T"
            Data.Add(GetData.GetValId(cboVLink9.Text.Trim)) : strType &= "T"
            Data.Add(GetData.GetValId(cboVLink10.Text.Trim)) : strType &= "T"

            Data.Add(IIf(cboVCalType1.SelectedIndex = 0, "D", "H")) : strType &= "T"
            Data.Add(IIf(cboVCalType2.SelectedIndex = 0, "D", "H")) : strType &= "T"
            Data.Add(IIf(cboVCalType3.SelectedIndex = 0, "D", "H")) : strType &= "T"
            Data.Add(IIf(cboVCalType4.SelectedIndex = 0, "D", "H")) : strType &= "T"
            Data.Add(IIf(cboVCalType5.SelectedIndex = 0, "D", "H")) : strType &= "T"
            Data.Add(IIf(cboVCalType6.SelectedIndex = 0, "D", "H")) : strType &= "T"
            Data.Add(IIf(cboVCalType7.SelectedIndex = 0, "D", "H")) : strType &= "T"
            Data.Add(IIf(cboVCalType8.SelectedIndex = 0, "D", "H")) : strType &= "T"
            Data.Add(IIf(cboVCalType9.SelectedIndex = 0, "D", "H")) : strType &= "T"
            Data.Add(IIf(cboVCalType10.SelectedIndex = 0, "D", "H")) : strType &= "T"

            Data.Add(IIf(cboAbsCalType.SelectedIndex = 0, "D", "H")) : strType &= "T"

            strSQL = "Insert Into RPT_TimeAbsLate_config(VC1,VC2,VC3,VC4,VC5,VC6,VC7,VC8,VC9,VC10," & _
                          " VID1,VID2,VID3,VID4,VID5,VID6,VID7,VID8,VID9,VID10," & _
                          " VCType1,VCType2,VCType3,VCType4,VCType5,VCType6,VCType7,VCType8,VCType9,VCType10,AbsCType) " & _
                     " Values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12,@P13,@P14,@P15," & _
                            " @P16,@p17,@p18,@p19,@p20,@p21,@p22,@p23,@p24,@p25,@p26,@p27,@p28,@p29,@p30,@p31)"

            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try
        MsgManager.ShowDialog(Me, "frmRptAllEmpWorkRS", Me.Text, "Save_Complete", MessageBoxIcon.Information)
        'MsgBox("∫—π∑÷°¢ÈÕ¡Ÿ≈‡√’¬∫√ÈÕ¬·≈È«", MsgBoxStyle.Information, Me.Text)
    End Sub

    Private Sub LoadData()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "select VC1,VC2,VC3,VC4,VC5,VC6,VC7,VC8,VC9,VC10, " & _
                        " vName1 = Isnull(tw1.Description,'')," & _
                        " vName2 = Isnull(tw2.Description,'')," & _
                        " vName3 = Isnull(tw3.Description,'')," & _
                        " vName4 = Isnull(tw4.Description,'')," & _
                        " vName5 = Isnull(tw5.Description,'')," & _
                        " vName6 = Isnull(tw6.Description,'')," & _
                        " vName7 = Isnull(tw7.Description,'')," & _
                        " vName8 = Isnull(tw8.Description,'')," & _
                        " vName9 = Isnull(tw9.Description,'')," & _
                        " vName10 = Isnull(tw10.Description,'')," & _
                        " VCType1,VCType2,VCType3,VCType4,VCType5,VCType6,VCType7," & _
                        " VCType8,VCType9,VCType10,AbsCType " & _
                " from RPT_TimeAbsLate_config ts " & _
                        " left join timeworkingstatus tw1" & _
                                " on ts.VID1 = tw1.Code" & _
                        " left join timeworkingstatus tw2" & _
                                " on ts.VID2 = tw2.Code" & _
                        " left join timeworkingstatus tw3" & _
                                " on ts.VID3 = tw3.Code" & _
                        " left join timeworkingstatus tw4" & _
                                " on ts.VID4 = tw4.Code" & _
                        " left join timeworkingstatus tw5" & _
                                " on ts.VID5 = tw5.Code" & _
                        " left join timeworkingstatus tw6" & _
                                " on ts.VID6 = tw6.Code" & _
                        " left join timeworkingstatus tw7" & _
                                " on ts.VID7 = tw7.Code" & _
                        " left join timeworkingstatus tw8" & _
                                " on ts.VID8 = tw8.Code" & _
                        " left join timeworkingstatus tw9" & _
                                " on ts.VID9 = tw9.Code" & _
                        " left join timeworkingstatus tw10" & _
                                " on ts.VID10 = tw10.Code"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Call ClearData()
            Else
                Dim dr As DataRow = .Rows(0)
                txtVCol1.Text = dr("VC1")
                txtVCol2.Text = dr("VC2")
                txtVCol3.Text = dr("VC3")
                txtVCol4.Text = dr("VC4")
                txtVCol5.Text = dr("VC5")
                txtVCol6.Text = dr("VC6")
                txtVCol7.Text = dr("VC7")
                txtVCol8.Text = dr("VC8")
                txtVCol9.Text = dr("VC9")
                txtVCol10.Text = dr("VC10")
                cboVLink1.SelectedItem = dr("vName1")
                cboVLink2.SelectedItem = dr("vName2")
                cboVLink3.SelectedItem = dr("vName3")
                cboVLink4.SelectedItem = dr("vName4")
                cboVLink5.SelectedItem = dr("vName5")
                cboVLink6.SelectedItem = dr("vName6")
                cboVLink7.SelectedItem = dr("vName7")
                cboVLink8.SelectedItem = dr("vName8")
                cboVLink9.SelectedItem = dr("vName9")
                cboVLink10.SelectedItem = dr("vName10")
                cboVCalType1.SelectedIndex = IIf(dr("VCType1") = "D", 0, 1)
                cboVCalType2.SelectedIndex = IIf(dr("VCType2") = "D", 0, 1)
                cboVCalType3.SelectedIndex = IIf(dr("VCType3") = "D", 0, 1)
                cboVCalType4.SelectedIndex = IIf(dr("VCType4") = "D", 0, 1)
                cboVCalType5.SelectedIndex = IIf(dr("VCType5") = "D", 0, 1)
                cboVCalType6.SelectedIndex = IIf(dr("VCType6") = "D", 0, 1)
                cboVCalType7.SelectedIndex = IIf(dr("VCType7") = "D", 0, 1)
                cboVCalType8.SelectedIndex = IIf(dr("VCType8") = "D", 0, 1)
                cboVCalType9.SelectedIndex = IIf(dr("VCType9") = "D", 0, 1)
                cboVCalType10.SelectedIndex = IIf(dr("VCType10") = "D", 0, 1)
                cboAbsCalType.SelectedIndex = IIf(dr("AbsCType") = "D", 0, 1)
            End If
        End With
    End Sub

    Private Sub ClearData()
        txtVCol1.Text = ""
        txtVCol2.Text = ""
        txtVCol3.Text = ""
        txtVCol4.Text = ""
        txtVCol5.Text = ""
        txtVCol6.Text = ""
        txtVCol7.Text = ""
        txtVCol8.Text = ""
        txtVCol9.Text = ""
        txtVCol10.Text = ""
        cboVLink1.SelectedIndex = 0
        cboVLink2.SelectedIndex = 0
        cboVLink3.SelectedIndex = 0
        cboVLink4.SelectedIndex = 0
        cboVLink5.SelectedIndex = 0
        cboVLink6.SelectedIndex = 0
        cboVLink7.SelectedIndex = 0
        cboVLink8.SelectedIndex = 0
        cboVLink9.SelectedIndex = 0
        cboVLink10.SelectedIndex = 0
        cboVCalType1.SelectedIndex = 0
        cboVCalType2.SelectedIndex = 0
        cboVCalType3.SelectedIndex = 0
        cboVCalType4.SelectedIndex = 0
        cboVCalType5.SelectedIndex = 0
        cboVCalType6.SelectedIndex = 0
        cboVCalType7.SelectedIndex = 0
        cboVCalType8.SelectedIndex = 0
        cboVCalType9.SelectedIndex = 0
        cboVCalType10.SelectedIndex = 0
        cboAbsCalType.SelectedIndex = 0
    End Sub
End Class
