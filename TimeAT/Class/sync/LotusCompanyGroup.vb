Imports System.Data
Imports System.Data.SqlClient
Imports TimeAttendance.utils
Imports webAPI.Models

Public Class LotusCompanyGroup
    Public Shared Function Sync(ByRef err As String) As Boolean
        err = ""
        api.LogIn(err) : If err <> "" Then Return False
        Dim dt As DataTable = api.GetCompanyGroup(err)

        If err <> "" Then Return False

        For Each dr As DataRow In dt.Rows
            Dim md As modelCompanyGroup = MapData(dr)
            update(md, err)
        Next
        Return True
    End Function

    Private Shared Function MapData(dr As DataRow) As modelCompanyGroup
        Dim md As New modelCompanyGroup
        md.Id = IIf(IsDBNull(dr("Id")), "", dr("Id"))
        md.Name = IIf(IsDBNull(dr("Name")), "", dr("Name"))
        md.ModifiedAtUtc = IIf(IsDBNull(dr("ModifiedAtUtc")), "", dr("ModifiedAtUtc"))
        md.CreatedAtUtc = IIf(IsDBNull(dr("CreatedAtUtc")), "", dr("CreatedAtUtc"))
        md.LicenseToken = IIf(IsDBNull(dr("LicenseToken")), "", dr("LicenseToken"))
        Return md
    End Function

    Private Shared Function update(md As modelCompanyGroup, ByRef err As String) As Boolean
        Dim dbMgr As New DBManager
        Dim cn As New SqlConnection
        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList

        err = ""

        Data.Clear() : strType = ""
        Data.Add(md.Id) : strType &= "T"
        Data.Add(md.Name) : strType &= "T"

        If IsDBNull(md.ModifiedAtUtc) = True Then
            Data.Add(DBNull.Value) : strType &= "D"
        Else
            Data.Add(md.ModifiedAtUtc) : strType &= "D"
        End If


        If IsDBNull(md.CreatedAtUtc) = True Then
            Data.Add(DBNull.Value) : strType &= "D"
        Else
            Data.Add(md.CreatedAtUtc) : strType &= "D"
        End If

        Data.Add(md.LicenseToken) : strType &= "T"

        strSQL = "EXEC	[dbo].[sp_Save_LotusCompanyGroup]
                          @Id = @P1,
                          @Name = @P2,
                          @ModifiedAtUtc = @P3,
                          @CreatedAtUtc = @P4,
                          @LicenseToken = @P5"
        Try
            dbMgr.OpenDatabase(cn, True)
            db.ExecuteCommand(cn, dCmd, strSQL, strType, Data)
            dbMgr.OpenDatabase(cn, False)
        Catch ex As Exception
            err = ex.Message
            dbMgr.OpenDatabase(cn, False)
            Return False
        End Try
        err = ""
        Return True
    End Function

End Class
