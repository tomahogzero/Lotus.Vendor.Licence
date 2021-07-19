Imports TimeAttendance.utils

Public Class licence
    Public Shared Function LicenceKeyGen(data As String) As String
        Dim dbMgr As New DBManager
        Try
            Dim keygen As String = dbMgr.getEncryptStr_Lic(data)

            Return keygen
        Catch ex As Exception
            Return ""
        End Try
    End Function
End Class
