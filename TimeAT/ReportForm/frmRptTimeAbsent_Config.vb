Imports System.Data
Imports System.Data.SqlClient
Imports TimeAttendance.utils

Public Class frmRptTimeAbsent_Config

    Private Sub frmRptTimeAbsent_Config_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadVacation()
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

            strSQL = "Delete From rpt_timeabsent_config"
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

            strSQL = "Insert Into RPT_TimeAbsent_Config(vC1,vC2,vC3," & _
                                    " vC4,vC5,vC6,vC7,vC8," & _
                                    " VId_C1,VId_C2,VId_C3,VId_C4," & _
                                    " VId_C5,VId_C6,VId_C7,VId_C8)" & _
                     " Values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12,@P13,@P14,@P15,@P16)"
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try
        'MsgBox("�ѹ�֡���������º��������", MsgBoxStyle.Information, Me.Text)
        MsgManager.ShowDialog(Me, "frmRptAllEmpWorkRS", Me.Text, "Save_Complete", MessageBoxIcon.Information)
    End Sub

    Private Sub LoadData()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = "select vC1=isnull(vC1,''),vC2=isnull(vC2,''),vC3=isnull(vC3,'')," & _
                        "vC4=isnull(vC4,''),vC5=isnull(vC5,''),vC6=isnull(vC6,'')," & _
                        "vC7=isnull(vC7,''),vC8=isnull(vC8,'')," & _
                        " vName1 = Isnull(tw1.Description,'')," & _
                        " vName2 = Isnull(tw2.Description,'')," & _
                        " vName3 = Isnull(tw3.Description,'')," & _
                        " vName4 = Isnull(tw4.Description,'')," & _
                        " vName5 = Isnull(tw5.Description,'')," & _
                        " vName6 = Isnull(tw6.Description,'')," & _
                        " vName7 = Isnull(tw7.Description,'')," & _
                        " vName8 = Isnull(tw8.Description,'') " & _
                " from rpt_timeabsent_config ts " & _
                        " left join timeworkingstatus tw1" & _
                                " on ts.VId_C1 = tw1.Code" & _
                        " left join timeworkingstatus tw2" & _
                                " on ts.VId_C2 = tw2.Code" & _
                        " left join timeworkingstatus tw3" & _
                                " on ts.VId_C3 = tw3.Code" & _
                        " left join timeworkingstatus tw4" & _
                                " on ts.VId_C4 = tw4.Code" & _
                        " left join timeworkingstatus tw5" & _
                                " on ts.VId_C5 = tw5.Code" & _
                         " left join timeworkingstatus tw6" & _
                                " on ts.VId_C6 = tw6.Code" & _
                        " left join timeworkingstatus tw7" & _
                                " on ts.VId_C7 = tw7.Code" & _
                        " left join timeworkingstatus tw8" & _
                                " on ts.VId_C8 = tw8.Code"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Call ClearData()
            Else
                Dim dr As DataRow = .Rows(0)
                txtVCol1.Text = dr("vC1")
                txtVCol2.Text = dr("vC2")
                txtVCol3.Text = dr("vC3")
                txtVCol4.Text = dr("vC4")
                txtVCol5.Text = dr("vC5")
                txtVCol6.Text = dr("vC6")
                txtVCol7.Text = dr("vC7")
                txtVCol8.Text = dr("vC8")
                cboVLink1.SelectedItem = dr("vName1")
                cboVLink2.SelectedItem = dr("vName2")
                cboVLink3.SelectedItem = dr("vName3")
                cboVLink4.SelectedItem = dr("vName4")
                cboVLink5.SelectedItem = dr("vName5")
                cboVLink6.SelectedItem = dr("vName6")
                cboVLink7.SelectedItem = dr("vName7")
                cboVLink8.SelectedItem = dr("vName8")
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
    End Sub
End Class
