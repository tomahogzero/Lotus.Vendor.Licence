Imports System.Data
Imports System.Data.SqlClient
Imports TimeAttendance.utils
Imports webAPI.Models

Public Class LotusCompany
    Public Shared Function Sync(ByRef err As String) As Boolean
        err = ""
        api.LogIn(err) : If err <> "" Then Return False
        Dim dt As DataTable = api.GetCompany(err)

        If err <> "" Then Return False

        For Each dr As DataRow In dt.Rows
            Dim md As modelCompany = MapData(dr)
            update(md, err)
        Next
        Return True
    End Function

    Private Shared Function MapData(dr As DataRow) As modelCompany
        Dim md As New modelCompany
        md.Id = IIf(IsDBNull(dr("Id")), "", dr("Id"))
        md.ModifiedAtUtc = IIf(IsDBNull(dr("ModifiedAtUtc")), "", dr("ModifiedAtUtc"))
        md.CreatedAtUtc = IIf(IsDBNull(dr("CreatedAtUtc")), "", dr("CreatedAtUtc"))
        md.CompanyName = IIf(IsDBNull(dr("CompanyName")), "", dr("CompanyName"))
        md.CompanyId = IIf(IsDBNull(dr("CompanyId")), "", dr("CompanyId"))
        md.CompanyType = IIf(IsDBNull(dr("CompanyType")), "", dr("CompanyType"))
        md.Address1 = IIf(IsDBNull(dr("Address1")), "", dr("Address1"))
        md.Address2 = IIf(IsDBNull(dr("Address2")), "", dr("Address2"))
        md.CompanyGroupId = IIf(IsDBNull(dr("CompanyGroupId")), "", dr("CompanyGroupId"))
        md.Enabled = IIf(IsDBNull(dr("Enabled")), "", dr("Enabled"))
        md.CompanyTax = IIf(IsDBNull(dr("CompanyTax")), "", dr("CompanyTax"))
        md.ContactEmail = IIf(IsDBNull(dr("ContactEmail")), "", dr("ContactEmail"))
        md.ContactPhone = IIf(IsDBNull(dr("ContactPhone")), "", dr("ContactPhone"))
        Return md
    End Function

    Private Shared Function update(md As modelCompany, ByRef err As String) As Boolean
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

        Data.Add(md.CompanyName) : strType &= "T"
        Data.Add(md.CompanyId) : strType &= "T"
        Data.Add(md.CompanyType) : strType &= "I"
        Data.Add(md.Address1) : strType &= "T"
        Data.Add(md.Address2) : strType &= "T"
        Data.Add(md.CompanyGroupId) : strType &= "T"
        Data.Add(md.Enabled) : strType &= "B"
        Data.Add(md.CompanyTax) : strType &= "T"
        Data.Add(md.ContactEmail) : strType &= "T"
        Data.Add(md.ContactPhone) : strType &= "T"

        strSQL = "EXEC	[dbo].[sp_Save_LotusCompany]
                          @Id = @P1,
                          @ModifiedAtUtc = @P2,
                          @CreatedAtUtc = @P3,
                          @CompanyName = @P4,
                          @CompanyId = @P5,
                          @CompanyType = @P6,
                          @Address1 = @P7,
                          @Address2 = @P8,
                          @CompanyGroupId = @P9,
                          @Enabled = @P10,
                          @CompanyTax = @P11,
                          @ContactEmail = @P12,
                          @ContactPhone = @P13"
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
