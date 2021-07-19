Imports System.Data
Imports webAPI.Models

Public Class dt_Device
    Dim dt As DataTable
    Dim md As modelDevice
    Dim _count As Integer = 0

    Sub New()
        CreateColumn()
    End Sub

    Sub New(data As List(Of modelDevice))
        CreateColumn()
        InputData(data)
    End Sub

    Sub CreateColumn()
        dt = New DataTable
        dt.Columns.Add("Id", GetType(String))
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("SerialNo", GetType(String))
        dt.Columns.Add("CompanyGroupId", GetType(String))
        dt.Columns.Add("ModifiedAtUtc", GetType(String))
        dt.Columns.Add("CreatedAtUtc", GetType(String))
        dt.Columns.Add("SerialNoHash", GetType(String))
    End Sub

    Sub InputData(data As List(Of modelDevice))
        For Each md As modelDevice In data
            dt.Rows.Add(md.Id,
                    md.Name,
                    md.SerialNo,
                    md.CompanyGroupId,
                    md.ModifiedAtUtc,
                    md.CreatedAtUtc,
                    md.SerialNoHash)
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
