Imports System.Data.SqlClient
Imports DevExpress.XtraGrid

Public Class viewdata
    Public Shared Sub LoadDevice(gc As GridControl)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        strSQL = "select * from Device"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")


        gc.DataSource = Ds
        gc.DataMember = "data"
    End Sub

    Public Shared Sub LoadDeviceLicence(gc As GridControl)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        strSQL = "select ld.*,isnull(c.Name,'') as CompanyGroupName,isnull(d.Device,'') as Device
                    from LotusDevice ld
	                    left join LotusCompanyGroup c
		                    on ld.CompanyGroupId = c.Id
                        left join Device d
                            on ld.SerialNo = d.DeviceSerialNo"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")


        gc.DataSource = Ds
        gc.DataMember = "data"
    End Sub
End Class
