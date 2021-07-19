Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports TimeAttendance.utils
Imports webAPI.Models

Public Class command
    Public Shared Sub GenDeviceLicence(gv As GridView, useNameSpingdel As Boolean)
        Dim dbMgr As New DBManager
        Dim err As String = ""

        For Each i As Long In gv.GetSelectedRows
            Dim dr As DataRow = gv.GetDataRow(i)

            Dim id As String = dr("Id").ToString()
            Dim Name As String = dr("Name")
            Dim Device As String = dr("Device")
            Dim SerialNo As String = dr("SerialNo")
            Dim CompanyGroupId As String = dr("CompanyGroupId").ToString()
            Dim SerialNoHash As String = licence.LicenceKeyGen(SerialNo & "," & CompanyGroupId)

            Dim md As New modelDeviceUpdate

            If useNameSpingdel = True Then
                md.Name = Device
            Else
                md.Name = Name
            End If
            md.SerialNo = SerialNo
            md.SerialNoHash = SerialNoHash

            If api.LogIn(err) = False Then Exit Sub
            If api.UpdateDevice(id, md, err) = False Then
                MsgBox(err)
            End If
        Next
    End Sub

    Public Shared Sub GenCompanyGroupLicenceToken(gv As GridView)
        Dim dbMgr As New DBManager
        Dim err As String = ""

        For Each i As Long In gv.GetSelectedRows
            Dim dr As DataRow = gv.GetDataRow(i)

            If IsDBNull(dr("CompanyGroupId")) = False Then
                Dim CompanyGroupId As String = dr("CompanyGroupId").ToString()
                Dim licenceKey As String = dr("licenceKey")
                Dim Name As String = dr("CompanyGroupName")

                If licenceKey <> "" Then
                    Dim md As New modelCompanyGroupUpdateToken
                    md.Name = Name
                    md.LicenseToken = licenceKey

                    If api.LogIn(err) = False Then Exit Sub
                    If api.UpdateCompanyGroupLicenceToken(CompanyGroupId, md, err) = False Then
                        MsgBox(err)
                    End If
                End If
            End If
        Next
    End Sub

    Public Shared Sub DeviceUpdateSerialNo(SerialNumber As String, newData As String)
        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList


        '' ข้อมูลที่หัว ====================================================================

        Data.Clear() : strType = ""
        Data.Add(SerialNumber) : strType &= "T"
        Data.Add(newData) : strType &= "T"


        strSQL = "update device set DeviceSerialNo = @P2" &
                " Where SerialNumber = @P1"
        Try
            db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
