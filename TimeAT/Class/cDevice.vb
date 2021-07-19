Imports System.Data.SqlClient
Imports DevExpress.XtraGrid

Public Class cDevice
    Private Shared Function GetDevice() As DataTable

        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Data As New ArrayList
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        strSQL = "select * from device"
        Try
            db.ExecuteCommand_Select(Conn, dCmd, strSQL)
            da.SelectCommand = dCmd
            da.Fill(dt)
        Catch ex As Exception
            Return Nothing
        End Try
        Return dt
    End Function

    Private Shared Sub LoadGridControl(gc As GridControl, dt As DataTable)
        gc.DataSource = dt
    End Sub

End Class
