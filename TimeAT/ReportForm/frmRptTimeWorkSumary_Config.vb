Imports System.Data
Imports System.Data.SqlClient
Imports TimeAttendance.utils

Public Class frmRptTimeWorkSumary_Config

    Private Sub frmRptTimeWorkSumary_Config_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadVacation()
        Call LoadCalType()
        Call LoadData()
    End Sub

    Private Sub LoadVacation()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "select Code,Description = isnull(Description,'') from TimeWorkingstatus Order By Code"
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

            cboVLink1.Items.Add("")
            cboVLink2.Items.Add("")
            cboVLink3.Items.Add("")
            cboVLink4.Items.Add("")
            cboVLink5.Items.Add("")
            cboVLink6.Items.Add("")
            cboVLink7.Items.Add("")
            cboVLink8.Items.Add("")
            For Each dr As DataRow In .Rows
                cboVLink1.Items.Add(dr("Description"))
                cboVLink2.Items.Add(dr("Description"))
                cboVLink3.Items.Add(dr("Description"))
                cboVLink4.Items.Add(dr("Description"))
                cboVLink5.Items.Add(dr("Description"))
                cboVLink6.Items.Add(dr("Description"))
                cboVLink7.Items.Add(dr("Description"))
                cboVLink8.Items.Add(dr("Description"))
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

        cboAbsCalType.Items.Clear()

        ' Add Type
        cboVCalType1.Items.Add("«—π") : cboVCalType1.Items.Add("™—Ë«‚¡ß")
        cboVCalType2.Items.Add("«—π") : cboVCalType2.Items.Add("™—Ë«‚¡ß")
        cboVCalType3.Items.Add("«—π") : cboVCalType3.Items.Add("™—Ë«‚¡ß")
        cboVCalType4.Items.Add("«—π") : cboVCalType4.Items.Add("™—Ë«‚¡ß")
        cboVCalType5.Items.Add("«—π") : cboVCalType5.Items.Add("™—Ë«‚¡ß")
        cboVCalType6.Items.Add("«—π") : cboVCalType6.Items.Add("™—Ë«‚¡ß")
        cboVCalType7.Items.Add("«—π") : cboVCalType7.Items.Add("™—Ë«‚¡ß")
        cboVCalType8.Items.Add("«—π") : cboVCalType8.Items.Add("™—Ë«‚¡ß")
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

            strSQL = "Delete From rpt_timeworksumarize_config"
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

            Data.Add(GetData.GetValId(cboVLink1.Text.Trim)) : strType &= "T"
            Data.Add(GetData.GetValId(cboVLink2.Text.Trim)) : strType &= "T"
            Data.Add(GetData.GetValId(cboVLink3.Text.Trim)) : strType &= "T"
            Data.Add(GetData.GetValId(cboVLink4.Text.Trim)) : strType &= "T"
            Data.Add(GetData.GetValId(cboVLink5.Text.Trim)) : strType &= "T"
            Data.Add(GetData.GetValId(cboVLink6.Text.Trim)) : strType &= "T"
            Data.Add(GetData.GetValId(cboVLink7.Text.Trim)) : strType &= "T"
            Data.Add(GetData.GetValId(cboVLink8.Text.Trim)) : strType &= "T"

            Data.Add(IIf(cboVCalType1.SelectedIndex = 0, "D", "H")) : strType &= "T"
            Data.Add(IIf(cboVCalType2.SelectedIndex = 0, "D", "H")) : strType &= "T"
            Data.Add(IIf(cboVCalType3.SelectedIndex = 0, "D", "H")) : strType &= "T"
            Data.Add(IIf(cboVCalType4.SelectedIndex = 0, "D", "H")) : strType &= "T"
            Data.Add(IIf(cboVCalType5.SelectedIndex = 0, "D", "H")) : strType &= "T"
            Data.Add(IIf(cboVCalType6.SelectedIndex = 0, "D", "H")) : strType &= "T"
            Data.Add(IIf(cboVCalType7.SelectedIndex = 0, "D", "H")) : strType &= "T"
            Data.Add(IIf(cboVCalType8.SelectedIndex = 0, "D", "H")) : strType &= "T"

            Data.Add(IIf(cboAbsCalType.SelectedIndex = 0, "D", "H")) : strType &= "T"

            strSQL = "Insert Into rpt_timeworksumarize_config(vCol1,vCol2,vCol3,vCol4,vCol5,vCol6,vCol7,vCol8," & _
                          " ValId_Col1,ValId_Col2,ValId_Col3,ValId_Col4,ValId_Col5,ValId_Col6,ValId_Col7,ValId_Col8," & _
                          " vCalType1,vCalType2,vCalType3,vCalType4,vCalType5,vCalType6,vCalType7,vCalType8,absCalType) " & _
                     " Values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12,@P13,@P14,@P15,@P16,@P17,@P18,@P19,@P20," & _
                            " @P21,@P22,@P23,@P24,@P25 )"
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try
        'MsgBox("∫—π∑÷°¢ÈÕ¡Ÿ≈‡√’¬∫√ÈÕ¬·≈È«", MsgBoxStyle.Information, Me.Text)
        MsgManager.ShowDialog(Me, "frmRptAllEmpWorkRS", Me.Text, "Save_Complete", MessageBoxIcon.Information)
    End Sub

    Private Sub LoadData()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "select vCol1 = isnull(vCol1,''),vCol2 = isnull(vCol2,'')" & _
                        ",vCol3 = isnull(vCol3,''),vCol4=isnull(vCol4,'')" & _
                        ",vCol5 = isnull(vCol5,''),vCol6 = isnull(vCol6,'')" & _
                        ",vCol7 = isnull(vCol7,''),vCol8 = isnull(vCol8,'')," & _
                        " vName1 = Isnull(tw1.Description,'')," & _
                        " vName2 = Isnull(tw2.Description,'')," & _
                        " vName3 = Isnull(tw3.Description,'')," & _
                        " vName4 = Isnull(tw4.Description,'')," & _
                        " vName5 = Isnull(tw5.Description,'')," & _
                        " vName6 = Isnull(tw6.Description,'')," & _
                        " vName7 = Isnull(tw7.Description,'')," & _
                        " vName8 = Isnull(tw8.Description,'')," & _
                        " vCalType1=isnull(vCalType1,''),vCalType2=isnull(vCalType2,'')" & _
                        ",vCalType3=isnull(vCalType3,''),vCalType4=isnull(vCalType4,'')" & _
                        ",vCalType5=isnull(vCalType5,'')," & _
                        " vCalType6=isnull(vCalType6,''),vCalType7=isnull(vCalType7,'')" & _
                        ",vCalType8=isnull(vCalType8,''),absCalType=isnull(absCalType,'') " & _
                " from rpt_timeworksumarize_config ts " & _
                        " left join timeworkingstatus tw1" & _
                                " on ts.ValId_Col1 = tw1.Code" & _
                        " left join timeworkingstatus tw2" & _
                                " on ts.ValId_Col2 = tw2.Code" & _
                        " left join timeworkingstatus tw3" & _
                                " on ts.ValId_Col3 = tw3.Code" & _
                        " left join timeworkingstatus tw4" & _
                                " on ts.ValId_Col4 = tw4.Code" & _
                        " left join timeworkingstatus tw5" & _
                                " on ts.ValId_Col5 = tw5.Code" & _
                         " left join timeworkingstatus tw6" & _
                                " on ts.ValId_Col6 = tw6.Code" & _
                        " left join timeworkingstatus tw7" & _
                                " on ts.ValId_Col7 = tw7.Code" & _
                        " left join timeworkingstatus tw8" & _
                                " on ts.ValId_Col8 = tw8.Code"
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
                txtVCol6.Text = dr("vCol6")
                txtVCol7.Text = dr("vCol7")
                txtVCol8.Text = dr("vCol8")
                cboVLink1.SelectedItem = dr("vName1")
                cboVLink2.SelectedItem = dr("vName2")
                cboVLink3.SelectedItem = dr("vName3")
                cboVLink4.SelectedItem = dr("vName4")
                cboVLink5.SelectedItem = dr("vName5")
                cboVLink6.SelectedItem = dr("vName6")
                cboVLink7.SelectedItem = dr("vName7")
                cboVLink8.SelectedItem = dr("vName8")
                cboVCalType1.SelectedIndex = IIf(dr("vCalType1") = "D", 0, 1)
                cboVCalType2.SelectedIndex = IIf(dr("vCalType2") = "D", 0, 1)
                cboVCalType3.SelectedIndex = IIf(dr("vCalType3") = "D", 0, 1)
                cboVCalType4.SelectedIndex = IIf(dr("vCalType4") = "D", 0, 1)
                cboVCalType5.SelectedIndex = IIf(dr("vCalType5") = "D", 0, 1)
                cboVCalType6.SelectedIndex = IIf(dr("vCalType6") = "D", 0, 1)
                cboVCalType7.SelectedIndex = IIf(dr("vCalType7") = "D", 0, 1)
                cboVCalType8.SelectedIndex = IIf(dr("vCalType8") = "D", 0, 1)
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
        txtVCol6.Text = ""
        txtVCol7.Text = ""
        txtVCol8.Text = ""
        cboVLink1.SelectedIndex = 0
        cboVLink2.SelectedIndex = 0
        cboVLink3.SelectedIndex = 0
        cboVLink4.SelectedIndex = 0
        cboVLink5.SelectedIndex = 0
        cboVLink6.SelectedIndex = 0
        cboVLink7.SelectedIndex = 0
        cboVLink8.SelectedIndex = 0
        cboVCalType1.SelectedIndex = 0
        cboVCalType2.SelectedIndex = 0
        cboVCalType3.SelectedIndex = 0
        cboVCalType4.SelectedIndex = 0
        cboVCalType5.SelectedIndex = 0
        cboVCalType6.SelectedIndex = 0
        cboVCalType7.SelectedIndex = 0
        cboVCalType8.SelectedIndex = 0
        cboAbsCalType.SelectedIndex = 0
    End Sub


End Class
