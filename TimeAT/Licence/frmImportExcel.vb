Imports Microsoft.Office.Interop
Imports TimeAttendance.utils
Imports System.Data
Imports System.Data.SqlClient


Public Class frmImportExcel
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        With OpenFileDialog1
            .Filter = "Excel File|*.xls;*.xlsx"
            If .ShowDialog = DialogResult.OK Then
                txtFileName.Text = .FileName
            End If
        End With
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        If txtFileName.Text.Trim = "" Then
            MsgManager.ShowDialog(Me, "frmImportEmpProfileRS", Me.Text, "Filename_is_emptry", MessageBoxIcon.Information)
            Exit Sub
        End If

        If IO.File.Exists(txtFileName.Text.Trim) = False Then
            MsgManager.ShowDialog(Me, "frmImportEmpProfileRS", Me.Text, "Filename_is_null", MessageBoxIcon.Information)
            Exit Sub
        End If

        If IsNumeric(txtRowSt.Text) = False Then
            MsgManager.ShowDialog(Me, "frmImportEmpProfileRS", Me.Text, "Input_is_numeric", MessageBoxIcon.Information)
            Exit Sub
        End If

        If CInt(txtRowSt.Text) > CInt(txtRowSP.Text) Then
            MsgManager.ShowDialog(Me, "frmImportEmpProfileRS", Me.Text, "Input_rowst_morethan_rowsp", MessageBoxIcon.Information)
            Exit Sub
        End If

        btnImport.Enabled = False
        ImportProfile(txtFileName.Text.Trim, txtRowSt.Text, txtRowSP.Text)
        btnImport.Enabled = True
    End Sub

    Private Sub ImportProfile(Filename As String, rw_st As Integer, rw_sp As Integer)
        System.Threading.Thread.CurrentThread.CurrentCulture =
        System.Globalization.CultureInfo.CreateSpecificCulture("en-US")

        Dim vendorid As String = ""
        Dim juristic_reg_no As String = ""
        Dim vendor_name As String = ""
        Dim building As String = ""
        Dim room As String = ""
        Dim floor As String = ""
        Dim village As String = ""
        Dim homeno As String = ""
        Dim moo As String = ""
        Dim soi As String = ""
        Dim road As String = ""
        Dim tumbol As String = ""
        Dim amphur As String = ""
        Dim province As String = ""
        Dim zipcode As String = ""
        Dim tel As String = ""
        Dim email As String = ""
        Dim sign_contract_name As String = ""
        Dim sign_contract_name2 As String = ""
        Dim product_buy As String = ""
        Dim product_buy_set As String = ""
        Dim product_hire As String = ""
        Dim product_hire_set As String = ""
        Dim contract_name As String = ""
        Dim contract_tel As String = ""
        Dim contract_email As String = ""

        Dim buy_set As Integer = 0
        Dim hire_set As Integer = 0

        Dim address1 As String = ""
        Dim address2 As String = ""

        Dim app As New Excel.Application
        Dim exbook As Excel.Workbook
        Dim exsheet As Excel.Worksheet

        exbook = app.Workbooks.Open(Filename)
        exsheet = exbook.Sheets(1)

        ProgressBar1.Value = 0
        ProgressBar1.Maximum = rw_sp - rw_st + 1
        Dim ii As Integer = 0
        Dim i As Integer = 0
        For ii = rw_st To rw_sp
            ProgressBar1.Value += 1

            vendorid = CheckNothing(exsheet.Cells(ii, CInt(txtVendorId.Text)).Value)
            juristic_reg_no = CheckNothing(exsheet.Cells(ii, CInt(txtJuristic_Person_Registration_No.Text)).Value)
            vendor_name = CheckNothing(exsheet.Cells(ii, CInt(txtVendorName.Text)).Value)
            building = CheckNothing(exsheet.Cells(ii, CInt(txtBuilding.Text)).Value)
            room = CheckNothing(exsheet.Cells(ii, CInt(txtRoomNo.Text)).Value)
            floor = CheckNothing(exsheet.Cells(ii, CInt(txtFloor.Text)).Value)
            village = CheckNothing(exsheet.Cells(ii, CInt(txtVillage.Text)).Value)
            homeno = CheckNothing(exsheet.Cells(ii, CInt(txtHomeNo.Text)).Value)
            moo = CheckNothing(exsheet.Cells(ii, CInt(txtMoo.Text)).Value)
            soi = CheckNothing(exsheet.Cells(ii, CInt(txtSoi.Text)).Value)
            road = CheckNothing(exsheet.Cells(ii, CInt(txtRoad.Text)).Value)
            tumbol = CheckNothing(exsheet.Cells(ii, CInt(txtTumbol.Text)).Value)
            amphur = CheckNothing(exsheet.Cells(ii, CInt(txtAmphur.Text)).Value)
            province = CheckNothing(exsheet.Cells(ii, CInt(txtProvince.Text)).Value)
            zipcode = CheckNothing(exsheet.Cells(ii, CInt(txtZipcode.Text)).Value)
            tel = CheckNothing(exsheet.Cells(ii, CInt(txtTel.Text)).Value)
            email = CheckNothing(exsheet.Cells(ii, CInt(txtEmail.Text)).Value)
            sign_contract_name = CheckNothing(exsheet.Cells(ii, CInt(txtSign_Contract_Name1.Text)).Value)
            sign_contract_name2 = CheckNothing(exsheet.Cells(ii, CInt(txtSign_Contract_Name2.Text)).Value)
            product_buy = CheckNothing(exsheet.Cells(ii, CInt(txtProductBuy.Text)).Value)
            product_buy_set = CheckNothing(exsheet.Cells(ii, CInt(txtProductBuy_Set.Text)).Value)
            product_hire = CheckNothing(exsheet.Cells(ii, CInt(txtProductHire.Text)).Value)
            product_hire_set = CheckNothing(exsheet.Cells(ii, CInt(txtProductHire_Set.Text)).Value)
            contract_name = CheckNothing(exsheet.Cells(ii, CInt(txtContract_Name.Text)).Value)
            contract_tel = CheckNothing(exsheet.Cells(ii, CInt(txtContract_Tel.Text)).Value)
            contract_email = CheckNothing(exsheet.Cells(ii, CInt(txtContract_EMail.Text)).Value)

            address1 = GenAddress1(building, room, floor, village, homeno, moo, soi, road, tumbol, province)
            address2 = GenAddress2(amphur, province)

            Dim err As String = ""
            Dim ret As Boolean = False

            ret = update_vendor(vendorid, juristic_reg_no, vendor_name, address1, address2, zipcode, tel, email, sign_contract_name, sign_contract_name2, contract_name, contract_tel, contract_email, err)

            If ret = False Then
                lstLog.Items.Insert(0, err)
            Else
                lstLog.Items.Insert(0, vendorid & "- Updated")
            End If

            If IsNumeric(Replace(product_buy_set, "ชุด", "")) = True Then
                buy_set = CInt(Replace(product_buy_set, "ชุด", ""))

                err = ""
                ret = save_buy(vendorid, buy_set, Format(txtDueDate.EditValue, "yyyy/MM/dd"), err)

                If ret = False Then
                    lstLog.Items.Insert(0, vendorid & " - สินค้าซื้อ - " & err)
                Else
                    lstLog.Items.Insert(0, vendorid & "- สินค้าซื้อ - เรียบร้อยแล้ว")
                End If

            End If

            If IsNumeric(Replace(product_hire_set, "ชุด", "")) = True Then
                hire_set = CInt(Replace(product_hire_set, "ชุด", ""))

                err = ""
                ret = save_hire(vendorid, hire_set, err)

                If ret = False Then
                    lstLog.Items.Insert(0, vendorid & " - สินค้าเช่า - " & err)
                Else
                    lstLog.Items.Insert(0, vendorid & "- สินค้าเช่า - เรียบร้อยแล้ว")
                End If

            End If

        Next

        exbook = Nothing
        exsheet = Nothing
        'app.Quit()
        'app = Nothing

        '    MsgBox("complete")
        '    Exit Sub
    End Sub

    Function CheckNothing(data As String) As String
        If data Is Nothing Then
            Return ""
        Else
            If data.Trim = "-" Then
                data = ""
            End If
            Return data
        End If
    End Function

    Private Function GenAddress1(building As String, room As String, floor As String, village As String, homeno As String, moo As String, soi As String, road As String, tumbol As String, province As String)
        Dim address As String = ""

        If building <> "" And building <> "-" Then
            building = "อาคาร" & building
        Else
            building = ""
        End If

        address = building

        If room <> "" And room <> "-" Then
            room = "ห้อง " & room
        Else
            room = ""
        End If

        address &= " " & room

        If floor <> "" And floor <> "-" Then
            floor = "ชั้น " & floor
        End If

        address &= " " & floor
        address = Replace(address, "  ", " ")

        If village <> "" And village <> "-" Then
            village = "หมู่บ้าน" & village
        End If

        address &= " " & village
        address = Replace(address, "  ", " ")

        If homeno <> "" And homeno <> "-" Then
            homeno = "เลขที่ " & homeno
        End If

        address &= " " & homeno
        address = Replace(address, "  ", " ")

        If moo <> "" And moo <> "-" Then
            moo = "หมู่ " & moo
        End If

        address &= " " & moo
        address = Replace(address, "  ", " ")

        If soi <> "" And soi <> "-" Then
            soi = "ซอย" & soi
        End If

        address &= " " & soi
        address = Replace(address, "  ", " ")

        If road <> "" And road <> "-" Then
            road = "ถนน" & road
        End If

        address &= " " & road
        address = Replace(address, "  ", " ")

        If tumbol <> "" And tumbol <> "-" Then
            If province = "กรุงเทพฯ" Or province = "กรุงเทพมหานคร" Or province = "กทม" Or province = "กทม." Then
                tumbol = "แขวง" & tumbol
            Else
                tumbol = "ต." & tumbol
            End If
        Else
            tumbol = ""
        End If

        address &= " " & tumbol
        address = Replace(address, "  ", " ")

        Return address
    End Function

    Private Function GenAddress2(amphur As String, province As String)
        Dim address As String = ""

        If amphur <> "" And amphur <> "-" Then
            If province = "กรุงเทพฯ" Or province = "กรุงเทพมหานคร" Or province = "กทม" Or province = "กทม." Then
                amphur = "เขต" & amphur
            Else
                amphur = "อ." & amphur
            End If
        Else
            amphur = ""
        End If

        address &= amphur
        address = Replace(address, "  ", " ")

        If province <> "" And province <> "-" Then
            If province = "กรุงเทพฯ" Or province = "กรุงเทพมหานคร" Or province = "กทม" Or province = "กทม." Then
                province = province
            Else
                province = "จ." & province
            End If
        Else
            province = ""
        End If

        address &= " " & province
        address = Replace(address, "  ", " ")

        Return address
    End Function

    Private Function update_vendor(vendorid As String,
                              juristic_reg_no As String,
                              vendor_name As String,
                              address1 As String,
                              address2 As String,
                              zipcode As String,
                              tel As String,
                              email As String,
                              sign_contract_name As String,
                              sign_contract_name2 As String,
                              contract_name As String,
                              contract_tel As String,
                              contract_email As String,
                              ByRef err As String) As Boolean

        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList
        Dim workstatus As String = ""

        '' ข้อมูลที่หัว ====================================================================

        Data.Clear() : strType = ""
        Data.Add(vendorid) : strType &= "T"
        Data.Add(juristic_reg_no) : strType &= "T"
        Data.Add(vendor_name) : strType &= "T"
        Data.Add(address1) : strType &= "T"
        Data.Add(address2) : strType &= "T"
        Data.Add(zipcode) : strType &= "T"
        Data.Add(tel) : strType &= "T"
        Data.Add(email) : strType &= "T"
        Data.Add(sign_contract_name) : strType &= "T"
        Data.Add(sign_contract_name2) : strType &= "T"
        Data.Add(contract_name) : strType &= "T"
        Data.Add(contract_tel) : strType &= "T"
        Data.Add(contract_email) : strType &= "T"

        strSQL = "UPDATE [dbo].[vendor_group]" &
                   " Set [juristic_person_registration_no] = @P2" &
                      " ,[vendor_name] = @P3" &
                      " ,[address1] = @P4" &
                      " ,[address2] = @P5" &
                      " ,[zipcode] = @P6" &
                      " ,[tel] = @P7" &
                      " ,[email] = @P8" &
                      " ,[sign_contract_name] = @P9" &
                      " ,[sign_contract_name2] = @P10" &
                      " ,[contract_name] = @P11" &
                      " ,[contract_tel] = @P12" &
                      " ,[contract_email] = @P13" &
                      " ,[updatedate] = getdate()" &
                      " ,lic_start_date = convert(date,getdate())" &
                      " ,contract_date = convert(date,getdate())" &
                 " WHERE vendorid = @P1"
        Try
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
        Catch ex As Exception
            err = ex.Message
            Return False
        End Try
        Return True
    End Function

    Private Function save_buy(vendorid As String,
                          qty As Integer,
                          duedate As String,
                          ByRef err As String)

        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList


        '' ข้อมูลที่หัว ====================================================================

        Data.Clear() : strType = ""
        Data.Add(vendorid) : strType &= "T"
        Data.Add(qty) : strType &= "I"
        Data.Add(duedate) : strType &= "T"

        strSQL = "exec sp_product_buy_v2 @P1,@P2,@P3"
        Try
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
        Catch ex As Exception
            err = ex.Message
            Return False
        End Try
        Return True
    End Function

    Private Function save_hire(vendorid As String,
                      qty As Integer,
                      ByRef err As String)

        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList


        '' ข้อมูลที่หัว ====================================================================

        Data.Clear() : strType = ""
        Data.Add(vendorid) : strType &= "T"
        Data.Add(qty) : strType &= "I"

        strSQL = "exec sp_product_hire @P1,@P2"
        Try
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
        Catch ex As Exception
            err = ex.Message
            Return False
        End Try
        Return True
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSetDefault_Click(sender As Object, e As EventArgs) Handles btnSetDefault.Click
        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList


        '' ข้อมูลที่หัว ====================================================================

        Data.Clear() : strType = ""
        Data.Add(Format(txtDueDate.EditValue, "yyyy/MM/dd")) : strType &= "T"

        strSQL = "delete from [setting] " & Environment.NewLine &
                " insert into [setting](duedate) values(@P1)"
        Try
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub GetDueDate()
        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        strSQL = "select * from [setting]"

        Try
            db.ExecuteCommand_Select(Conn, dCmd, strSQL)
            da.SelectCommand = dCmd
            da.Fill(ds, "data")
            With ds.Tables("data")
                If .Rows.Count = 0 Then
                    txtDueDate.EditValue = Now.Date
                Else
                    Dim dr As DataRow = .Rows(0)
                    txtDueDate.EditValue = dr("duedate")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmImportExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDueDate()
    End Sub
End Class