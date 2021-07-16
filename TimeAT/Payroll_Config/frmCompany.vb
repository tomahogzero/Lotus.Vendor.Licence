Imports TimeAttendance.utils
'Imports Payroll.Model
'Imports Payroll.controller
Imports System.IO
Imports System.Globalization

Imports System.Data
Imports System.Data.SqlClient

Public Class frmCompany
    Protected dbMgr As New DBManager
    Protected dbConnStr As String = dbMgr.getConnString

    Private Sub frmCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnClear.Visible = False
        Call LoadCompany()

        ' โหลด รูป *************
        Call LoadImage()
        ' ****************************
    End Sub

    Private Sub LoadImage()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        strSQL = "Select logo From Company"
        db.ExecuteCommand(Conn, dCmd, strSQL)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")


        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Me.picLogo.Image = Nothing
                Exit Sub
            End If

            Dim drw As DataRow = .Rows(0)

            If IsDBNull(drw("logo")) = False Then
                Dim arrayImage() As Byte = CType(drw("logo"), Byte())
                Dim ms As New MemoryStream(arrayImage)
                With Me.picLogo
                    .Image = Image.FromStream(ms)
                    '.SizeMode = PictureBoxSizeMode.StretchImage
                End With
                ms.Close()
            Else
                Me.picLogo.Image = Nothing
            End If
        End With
    End Sub

    Public Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtCompanyName.Text.Trim = "" Then
            MsgBox(My.Resources.res_warning_message_spacial.please_input_companyname, MsgBoxStyle.Information, Me.Text)
            txtCompanyName.Focus()
            Exit Sub
        End If


        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList

        Data.Clear() : strType = ""
        Data.Add(txtCompanyName.Text.Trim) : strType &= "T"
        Data.Add(txtAddress.Text.Trim) : strType &= "T"
        Data.Add(txtTaxId.Text.Trim) : strType &= "T"
        Data.Add(txtSocTaxId.Text.Trim) : strType &= "T"
        Data.Add(txtBuilding.Text.Trim) : strType &= "T"
        Data.Add(txtRoom.Text.Trim) : strType &= "T"
        Data.Add(txtFloor.Text.Trim) : strType &= "T"
        Data.Add(txtVillage.Text.Trim) : strType &= "T"
        Data.Add(txtHomeNo.Text.Trim) : strType &= "T"
        Data.Add(txtMoo.Text.Trim) : strType &= "T"
        Data.Add(txtSoy.Text.Trim) : strType &= "T"
        Data.Add(txtRoad.Text.Trim) : strType &= "T"
        Data.Add(txtTumbol.Text.Trim) : strType &= "T"
        Data.Add(txtAmphur.Text.Trim) : strType &= "T"
        Data.Add(txtProvince.Text.Trim) : strType &= "T"
        Data.Add(txtZipcode.Text.Trim) : strType &= "T"
        Data.Add(txtTel.Text.Trim) : strType &= "T"
        Data.Add(txtFax.Text.Trim) : strType &= "T"

        If ExistCompany() = False Then
            strSQL = "Insert Into Company(CompanyName,Address,TaxId,SocTaxId," &
                                " Building,Room,Floor,Village," &
                                " HomeNo,Moo,Soy,Road," &
                                " Tumbol,Amphur,Province,Zipcode," &
                                " Tel,Fax) Values " &
                                " (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12,@P13,@P14,@P15,@P16,@P17,@P18)"
        Else
            strSQL = "Update Company Set CompanyName = @P1," &
                                        " Address = @P2," &
                                        " TaxId = @P3," &
                                        " SocTaxId = @P4," &
                                        " Building = @P5," &
                                        " Room = @P6," &
                                        " Floor = @P7," &
                                        " Village = @P8," &
                                        " HomeNo = @P9," &
                                        " Moo = @P10," &
                                        " Soy = @P11," &
                                        " Road = @P12," &
                                        " Tumbol = @P13," &
                                        " Amphur = @P14," &
                                        " Province = @P15," &
                                        " Zipcode = @P16," &
                                        " Tel = @P17," &
                                        " Fax = @P18"
        End If
        Try
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Me.Text)
            Exit Sub
        End Try

        '' บันทึกรูปภาพ
        ''================================================
        'If Me.picLogo.Image Is Nothing Then
        '    picLogo.Image = Nothing
        'Else
        '    If txtpaht.Text <> "" Then
        '        Call SaveImage()
        '    End If
        'End If


        ' บันทึกรูปภาพ
        '================================================
        If Me.picLogo.Image Is Nothing Then
            picLogo.Image = Nothing
            Call UpdatePicture_NULL()
        Else
            '  picLogo.Image = New Bitmap(txtFileName.Text.Trim)
            If txtpaht.Text <> "" Then
                Call SaveImage()
            End If

        End If
        '================================================


        '   MsgBox("บันทึกเรียบร้อย", MsgBoxStyle.Information, "บันทึก")
        MsgBox(My.Resources.res_warning_message.save_complete, MsgBoxStyle.Information, Me.Text)
    End Sub

    Private Sub UpdatePicture_NULL()
        Dim cn As New SqlConnection
        Dim db As New db
        Dim dCmd As New SqlCommand

        '   Dim strType As String = ""
        Dim strSQL As String = ""


        strSQL = "Update company Set logo = NULL"
        Try

            db.ExecuteCommand(Conn, dCmd, strSQL)
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub SaveImage()
        'Dim cn As New SqlConnection
        Dim db As New db
        Dim dCmd As New SqlCommand
        ' Dim Result As New ResponseResult
        Dim data As New ArrayList
        Dim strType As String = ""
        Dim strSQL As String = ""
        Dim tn As SqlTransaction

        ' Try

        If Me.picLogo.Image Is Nothing Then

        Else
            Dim ms As New MemoryStream
            Me.picLogo.Image.Save(ms, Imaging.ImageFormat.Jpeg)

            Dim arrayImage() As Byte = ms.GetBuffer
            ms.Close() ' Closes the Memory Stream


            tn = Conn.BeginTransaction
            dCmd.Transaction = tn

            Try

                data.Clear() : strType = ""
                data.Add(arrayImage) : strType &= "P"

                strSQL = "UPdate company set logo=@P1 "
                db.ExecuteCommand(Conn, dCmd, strSQL, strType, data)
                tn.Commit()
            Catch ex As Exception
                '   Return Result
                MsgBox(ex.Message)
                tn.Rollback()
            End Try
        End If

    End Sub

    Public Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call LoadCompany()
    End Sub

    Function ExistCompany() As Boolean
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        strSQL = "Select * from Company"
        db.ExecuteCommand(Conn, dCmd, strSQL)
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

    Private Sub LoadCompany()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        strSQL = "Select * from Company"
        '
        db.ExecuteCommand(Conn, dCmd, strSQL)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        '

        With Ds.Tables("Data")
            If .Rows.Count = 0 Then
                Call ClearData()
                Exit Sub
            End If

            Dim dr As DataRow = .Rows(0)

            txtCompanyName.Text = dr("CompanyName")
            txtAddress.Text = dr("Address")
            txtTaxId.Text = dr("TaxId")
            txtSocTaxId.Text = dr("SocTaxId")
            ' new Address
            txtBuilding.Text = dr("Building")
            txtRoom.Text = dr("Room")
            txtFloor.Text = dr("Floor")
            txtVillage.Text = dr("Village")
            txtHomeNo.Text = dr("HomeNo")
            txtMoo.Text = dr("Moo")
            txtSoy.Text = dr("Soy")
            txtRoad.Text = dr("Road")
            txtTumbol.Text = dr("Tumbol")
            txtAmphur.Text = dr("Amphur")
            txtProvince.Text = dr("Province")
            txtZipcode.Text = dr("Zipcode")
            txtTel.Text = dr("Tel")
            txtFax.Text = dr("Fax")
        End With
    End Sub

    Private Sub ClearData()
        txtCompanyName.Text = ""
        txtAddress.Text = ""
        txtTaxId.Text = ""
        txtSocTaxId.Text = ""
        ' new Address
        txtBuilding.Text = ""
        txtRoom.Text = ""
        txtFloor.Text = ""
        txtVillage.Text = ""
        txtHomeNo.Text = ""
        txtMoo.Text = ""
        txtSoy.Text = ""
        txtRoad.Text = ""
        txtTumbol.Text = ""
        txtAmphur.Text = ""
        txtProvince.Text = ""
        txtZipcode.Text = ""
        txtTel.Text = ""
        txtFax.Text = ""
    End Sub

    Private Sub btnAddAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAddress.Click
        Dim Addr As String = ""

        If Trim(txtBuilding.Text) <> "" Then
            Addr = Addr & " " & Trim(txtBuilding.Text)
        End If
        If Trim(txtRoom.Text) <> "" Then
            Addr = Addr & " " & Trim(txtRoom.Text)
        End If
        If Trim(txtFloor.Text) <> "" Then
            Addr = Addr & " " & Trim(txtFloor.Text)
        End If
        If Trim(txtVillage.Text) <> "" Then
            Addr = Addr & " " & Trim(txtVillage.Text)
        End If
        If Trim(txtHomeNo.Text) <> "" Then
            Addr = Addr & " " & Trim(txtHomeNo.Text)
        End If
        If Trim(txtMoo.Text) <> "" Then
            Addr = Addr & " " & Trim(txtMoo.Text)
        End If
        If Trim(txtSoy.Text) <> "" Then
            Addr = Addr & " " & Trim(txtSoy.Text)
        End If
        If Trim(txtRoad.Text) <> "" Then
            Addr = Addr & " " & Trim(txtRoad.Text)
        End If
        If Trim(txtTumbol.Text) <> "" Then
            Addr = Addr & " " & Trim(txtTumbol.Text)
        End If
        If Trim(txtAmphur.Text) <> "" Then
            Addr = Addr & " " & Trim(txtAmphur.Text)
        End If
        If Trim(txtProvince.Text) <> "" Then
            Addr = Addr & " " & Trim(txtProvince.Text)
        End If
        txtAddress.Text = Addr
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label2.Click, Label9.Click, Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label4.Click, Label3.Click, Label18.Click, Label17.Click, Label16.Click, Label15.Click, Label14.Click, Label13.Click, Label12.Click, Label11.Click, Label10.Click

    End Sub

    Private Sub TextEdit6_EditValueChanged(sender As Object, e As EventArgs) Handles txtVillage.EditValueChanged, txtTumbol.EditValueChanged, txtSoy.EditValueChanged, txtProvince.EditValueChanged

    End Sub

    Private Sub btnFindPic_Click(sender As Object, e As EventArgs) Handles btnFindPic.Click
        Dim file As Image
        Dim f As New OpenFileDialog
        f.Filter = "JPG(*.JPG)|*.jpg"
        If f.ShowDialog = DialogResult.OK Then
            file = Image.FromFile(f.FileName)
            txtpaht.Text = f.FileName
            picLogo.Image = file
        End If
    End Sub

    Private Sub btnClearPic_Click(sender As Object, e As EventArgs) Handles btnClearPic.Click
        picLogo.Image = Nothing
    End Sub
End Class