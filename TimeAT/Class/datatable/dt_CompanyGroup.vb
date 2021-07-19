Imports System.Data
Imports webAPI.Models

Public Class dt_CompanyGroup
    Dim dt As DataTable
    Dim md As modelCompanyGroup
    Dim _count As Integer = 0

    Sub New()
        CreateColumn()
    End Sub

    Sub New(data As List(Of modelCompanyGroup))
        CreateColumn()
        InputData(data)
    End Sub

    Sub CreateColumn()
        dt = New DataTable
        dt.Columns.Add("Id", GetType(String))
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("ModifiedAtUtc", GetType(String))
        dt.Columns.Add("CreatedAtUtc", GetType(String))
        dt.Columns.Add("LicenseToken", GetType(String))
    End Sub

    Sub InputData(data As List(Of modelCompanyGroup))
        For Each md As modelCompanyGroup In data
            dt.Rows.Add(md.Id,
                    md.Name,
                    md.ModifiedAtUtc,
                    md.CreatedAtUtc,
                    md.LicenseToken)
        Next
        _count = data.Count
    End Sub

    Function GetDataTable() As DataTable
        Return dt
    End Function

    Function GetDataSet() As DataSet
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Return ds
    End Function

    Function Count() As Integer
        Return _count
    End Function

End Class
