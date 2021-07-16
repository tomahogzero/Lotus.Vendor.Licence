Imports System.Data.SqlClient
Imports System.Data
Imports TimeAttendance.utils

Public Class db
    Public Sub CreateParam(ByRef Cmd As SqlCommand, ByVal StrType As String)
        'T:Text, M:Memo, Y:Currency, D:Datetime, I:Integer, S:Single, B:Boolean, P: Picture
        Dim i As Integer
        Dim j As String
        For i = 1 To Len(StrType)
            j = UCase(Mid(StrType, i, 1))
            Dim P1 As New SqlParameter
            P1.ParameterName = "@P" & i
            Select Case j
                Case "T"
                    P1.SqlDbType = SqlDbType.VarChar
                Case "M"
                    P1.SqlDbType = SqlDbType.Text
                Case "Y"
                    P1.SqlDbType = SqlDbType.Money
                Case "D"
                    P1.SqlDbType = SqlDbType.DateTime
                Case "I"
                    P1.SqlDbType = SqlDbType.Int
                Case "S"
                    P1.SqlDbType = SqlDbType.Decimal
                Case "B"
                    P1.SqlDbType = SqlDbType.Bit
                Case "P"
                    P1.SqlDbType = SqlDbType.Image
                Case "U"
                    P1.SqlDbType = SqlDbType.UniqueIdentifier
            End Select
            Cmd.Parameters.Add(P1)
        Next
    End Sub

    Public Sub ExecuteCommand(ByRef Cn As SqlConnection, ByRef Cmd As SqlCommand, ByVal strSQL As String, ByVal strType As String, ByVal data As ArrayList)
        Cmd.Connection = Cn
        Cmd.CommandText = strSQL
        Cmd.Parameters.Clear()
        CreateParam(Cmd, strType)
        For i As Integer = 0 To data.Count - 1
            Cmd.Parameters(i).Value = data(i)
        Next
        Cmd.ExecuteNonQuery()
    End Sub

    Public Sub ExecuteCommand(ByRef Cn As SqlConnection, ByRef Cmd As SqlCommand, ByVal strSQL As String)

        Cmd.Connection = Cn
        Cmd.CommandText = strSQL
        Cmd.ExecuteNonQuery()

    End Sub

    Public Sub ExecuteCommand_Select(ByRef Cn As SqlConnection, ByRef Cmd As SqlCommand, ByVal strSQL As String)

        Cmd.Connection = Cn
        Cmd.CommandText = strSQL
    End Sub

    Public Function GetDataTable(ByRef Cmd As SqlCommand,
     Optional ByVal TableName As String = "Table") As DataTable
        Dim DA As New SqlDataAdapter
        Dim DT As New DataTable(TableName)
        Dim Ds As New DataSet
        Try
            DA.SelectCommand = Cmd
            DA.Fill(Ds)
            DT = Ds.Tables(0)
        Catch x1 As Exception
            Err.Raise(60002, , x1.Message)
        End Try
        Return DT
    End Function

    Public Sub OpenDatabase(ByRef Conn As SqlConnection, ByVal Open As Boolean)
        If Open = True Then
            If Conn.State <> ConnectionState.Open Then
                Conn.Close()
            End If
            Conn = getDBConnection()
            Conn.Open()
        Else
            Conn.Close()
        End If
    End Sub

    Public Function getDBConnection() As SqlConnection
        Dim strConnString As String = getConnString()
        Return New SqlClient.SqlConnection(strConnString)
    End Function

    Public Function getConnString() As String
        Dim dbMgr As New DBManager
        'Dim strConnString As String = "" ConfigurationManager.ConnectionStrings(strConfName).ConnectionString
        Dim strConnString As String = "Data Source=" & dbMgr.getServerName.Trim & ";" &
                                        "Initial Catalog=" & dbMgr.getDatabaseName.Trim & ";" &
                                        "User ID=" & dbMgr.getUserName.Trim & ";" &
                                        "Password=" & dbMgr.getPassword.Trim & ";"

        Return strConnString.Trim
    End Function
End Class

