Imports System.Configuration

Public Class AppVar
    'Public Shared FrmSearchQry As IQueryable
    'Public Shared SharedImgFolder As String = ConfigurationManager.AppSettings.Get("SharedImgDir")
    'Public Shared IsMultiCompany As Boolean = If(ConfigurationManager.AppSettings.Get("SelectCompanyAtLogin") = "1", True, False)
    'Public Shared IsPwdEncrypt As Boolean = If(ConfigurationManager.AppSettings.Get("EncReq") = "1", True, False)
    Public Shared hsh As Hashtable
    Public Shared DefaultCompID As String = "001"
End Class