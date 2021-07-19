Imports System.Data
Imports webAPI.Models

Public Class dt_Company
    Dim dt As DataTable
    Dim md As modelCompany
    Dim _count As Integer = 0

    Sub New()
        CreateColumn()
    End Sub

    Sub New(data As List(Of modelCompany))
        CreateColumn()
        InputData(data)
    End Sub

    Sub CreateColumn()
        dt = New DataTable
        dt.Columns.Add("Id", GetType(String))
        dt.Columns.Add("ModifiedAtUtc", GetType(String))
        dt.Columns.Add("CreatedAtUtc", GetType(String))
        dt.Columns.Add("CompanyName", GetType(String))
        dt.Columns.Add("CompanyId", GetType(String))
        dt.Columns.Add("CompanyType", GetType(String))
        dt.Columns.Add("Address1", GetType(String))
        dt.Columns.Add("Address2", GetType(String))
        dt.Columns.Add("CompanyGroupId", GetType(String))
        dt.Columns.Add("Enabled", GetType(String))
        dt.Columns.Add("CompanyTax", GetType(String))
        dt.Columns.Add("ContactEmail", GetType(String))
        dt.Columns.Add("ContactPhone", GetType(String))
    End Sub

    Sub InputData(data As List(Of modelCompany))
        For Each md As modelCompany In data
            dt.Rows.Add(md.Id,
                    md.ModifiedAtUtc,
                    md.CreatedAtUtc,
                    md.CompanyName,
                    md.CompanyId,
                    md.CompanyType,
                    md.Address1,
                    md.Address2,
                    md.CompanyGroupId,
                    md.Enabled,
                    md.CompanyTax,
                    md.ContactEmail,
                    md.ContactPhone)
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
