Imports TimeAttendance.utils
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class frmImportDevice
    Dim dtDevice As DataTable

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        With OpenFileDialog1
            .Filter = "CSV File|*.csv"
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

        btnImport.Enabled = False
        'ImportProfile(txtFileName.Text.Trim, txtRowSt.Text, txtRowSP.Text)
        ImportProfile(txtFileName.Text.Trim)
        btnImport.Enabled = True
    End Sub

    Private Sub ImportProfile(Filename As String)
        Try
            dtDevice.Rows.Clear()

            Using sr As IO.StreamReader = New IO.StreamReader(Filename)
                Dim line As String
                Dim i As Integer = 0
                While Not sr.EndOfStream
                    'If line Is Nothing Then
                    '    Return ""
                    'Else
                    '    Return line
                    'End If
                    line = sr.ReadLine()
                    If line <> "" And i > 0 Then
                        Dim data As String() = line.Split(",")
                        Dim dr As DataRow = dtDevice.NewRow()
                        dr("Fleet") = data(0)
                        dr("LastSeen") = data(1)
                        dr("Device") = data(2)
                        dr("AgentVersion") = data(3)
                        dr("Location") = data(4)
                        dr("BatteryLevel") = data(5)
                        dr("LastOnline") = data(6) & data(7)
                        dr("Manufacturer") = data(8)
                        dr("Model") = data(9)
                        dr("MACAddress") = data(10)
                        dr("EthernetMACAddress") = data(11)
                        dr("IPAddress") = data(12)
                        dr("AvailableMemory") = data(13)
                        dr("AvailableStorage") = data(14)
                        dr("SerialNumber") = data(15)
                        dr("IMEI") = data(16)
                        dr("SSID") = data(17)
                        dtDevice.Rows.Add(dr)
                    End If

                    i += 1
                End While
                sr.Close()
            End Using
        Catch ex As Exception
            'Err = ex.Message
            MsgBox(ex.Message)
            'Return ""
        End Try



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

    Private Function update_device(SerialNumber As String,
                                   Fleet As String,
                                   LastSeen As String,
                                   Device As String,
                                   AgentVersion As String,
                                   Location As String,
                                   BatteryLevel As String,
                                   LastOnline As String,
                                   Manufacturer As String,
                                   Model As String,
                                   MACAddress As String,
                                   EthernetMACAddress As String,
                                   IPAddress As String,
                                   AvailableMemory As String,
                                   AvailableStorage As String,
                                   IMEI As String,
                                   SSID As String, ByRef err As String) As Boolean

        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList
        Dim workstatus As String = ""

        err = ""

        '' ข้อมูลที่หัว ====================================================================

        Data.Clear() : strType = ""
        Data.Add(SerialNumber) : strType &= "T"
        Data.Add(Fleet) : strType &= "T"
        Data.Add(LastSeen) : strType &= "T"
        Data.Add(Device) : strType &= "T"
        Data.Add(AgentVersion) : strType &= "T"
        Data.Add(Location) : strType &= "T"
        Data.Add(BatteryLevel) : strType &= "T"
        Data.Add(LastOnline) : strType &= "T"
        Data.Add(Manufacturer) : strType &= "T"
        Data.Add(Model) : strType &= "T"
        Data.Add(MACAddress) : strType &= "T"
        Data.Add(EthernetMACAddress) : strType &= "T"
        Data.Add(IPAddress) : strType &= "T"
        Data.Add(AvailableMemory) : strType &= "T"
        Data.Add(AvailableStorage) : strType &= "T"
        Data.Add(IMEI) : strType &= "T"
        Data.Add(SSID) : strType &= "T"

        strSQL = "EXEC	[dbo].[sp_Save_Device]
		                @SerialNumber = @P1,
		                @Fleet = @P2,	
		                @LastSeen = @P3,
		                @Device = @P4,
		                @AgentVersion = @P5,
		                @Location = @P6,
		                @BatteryLevel = @P7,
		                @LastOnline = @P8,
		                @Manufacturer = @P9,
		                @Model = @P10,
		                @MACAddress = @P11,
		                @EthernetMACAddress = @P12,
		                @IPAddress = @P13,
		                @AvailableMemory = @P14,
		                @AvailableStorage = @P15,
		                @IMEI = @P16,
		                @SSID = @P17"
        Try
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
        Catch ex As Exception
            err = ex.Message
            Return False
        End Try
        err = ""
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

    Private Function get_device() As DataTable

        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Data As New ArrayList
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        strSQL = "select top 0 '' as updatestatus,* from device"
        Try
            db.ExecuteCommand_Select(Conn, dCmd, strSQL)
            da.SelectCommand = dCmd
            da.Fill(dt)
        Catch ex As Exception
            Return Nothing
        End Try
        Return dt
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

    Private Sub btnSetDefault_Click(sender As Object, e As EventArgs)
        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList


        '' ข้อมูลที่หัว ====================================================================

        Data.Clear() : strType = ""
        'Data.Add(Format(txtDueDate.EditValue, "yyyy/MM/dd")) : strType &= "T"

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
                'If .Rows.Count = 0 Then
                '    txtDueDate.EditValue = Now.Date
                'Else
                '    Dim dr As DataRow = .Rows(0)
                '    txtDueDate.EditValue = dr("duedate")
                'End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub load_device()
        gcDevice.DataSource = dtDevice
    End Sub

    Private Sub frmImportExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtDevice = get_device()
        load_device()
    End Sub

    Private Sub save_data()
        For Each dr As DataRow In dtDevice.Rows
            Dim err As String = ""

            If update_device(dr("SerialNumber"), dr("Fleet"),
                             dr("LastSeen"),
                             dr("Device"),
                             dr("AgentVersion"),
                             dr("Location"),
                             dr("BatteryLevel"),
                             dr("LastOnline"),
                             dr("Manufacturer"),
                             dr("Model"),
                             dr("MACAddress"),
                             dr("EthernetMACAddress"),
                             dr("IPAddress"),
                             dr("AvailableMemory"),
                             dr("AvailableStorage"),
                             dr("IMEI"),
                             dr("SSID"), err) = False Then
                dr("updatestatus") = err
            Else
                dr("updatestatus") = "Updated"
            End If
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call save_data()
        MsgBox("Complete")
    End Sub
End Class