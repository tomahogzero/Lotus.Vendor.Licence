Imports System
Imports System.IO
Imports System.Globalization
Imports System.Configuration
Imports System.Threading
Imports System.Data.SqlClient

Namespace utils
    Public Class DBManager
        Dim enc As Boolean = False
        Dim conn As SqlConnection = Nothing

        Public Function getConnString() As String
            'Dim strConnString As String = "" ConfigurationManager.ConnectionStrings(strConfName).ConnectionString
            Dim strConnString As String = "Data Source=" & getServerName.Trim & ";" & _
                                            "Initial Catalog=" & getDatabaseName.Trim & ";" & _
                                            "User ID=" & getUserName.Trim & ";" & _
                                            "Password=" & getPassword.Trim & ";"

            Return strConnString.Trim
        End Function

        Public Function getConnString(ByVal ServerName As String, ByVal DatabaseName As String, ByVal UserName As String, ByVal Password As String) As String
            'Dim strConnString As String = "" ConfigurationManager.ConnectionStrings(strConfName).ConnectionString
            Dim strConnString As String = "Data Source=" & ServerName.Trim & ";" & _
                                            "Initial Catalog=" & DatabaseName.Trim & ";" & _
                                            "User ID=" & UserName.Trim & ";" & _
                                            "Password=" & Password.Trim & ";"

            Return strConnString.Trim
        End Function

        Public Function getDecryptStr(ByVal strTmp As String) As String
            Return SecDecLib.Dec.Decrypt(strTmp, AppConstants.pwdPhrase, AppConstants.pwdSalt, AppConstants.hash, 2, AppConstants.pwdIVector, AppConstants.iKey)
        End Function

        Public Function getDecryptStr_Lic(ByVal strTmp As String) As String
            Return SecDecLib.Dec.Decrypt(strTmp, AppConstantsLicence.pwdPhrase, AppConstantsLicence.pwdSalt, AppConstantsLicence.hash, 2, AppConstantsLicence.pwdIVector, AppConstantsLicence.iKey)
        End Function


        Public Function getEncryptStr(ByVal strTmp As String) As String
            'Return GetData.encript_password(strTmp)
            Return SecEncLib.Encryption.Encrypt(strTmp, AppConstants.pwdPhrase, AppConstants.pwdSalt, AppConstants.hash, 2, AppConstants.pwdIVector, AppConstants.iKey)
        End Function

        Public Function getEncryptStr_Local(ByVal strTmp As String) As String
            'Return GetData.encript_password(strTmp)
            Return SecEncLib.Encryption.Encrypt(strTmp, AppConstants.pwdPhrase, AppConstants.pwdSalt, AppConstants.hash, 2, AppConstants.pwdIVector, AppConstants.iKey)
        End Function

        Public Function getEncryptStr_Lic(ByVal strTmp As String) As String
            Return SecEncLib.Encryption.Encrypt(strTmp, AppConstantsLicence.pwdPhrase, AppConstantsLicence.pwdSalt, AppConstantsLicence.hash, 2, AppConstantsLicence.pwdIVector, AppConstantsLicence.iKey)
        End Function

        Public Function getServerName() As String
            Return System.Configuration.ConfigurationManager.AppSettings.Item("ServerName").Trim
        End Function

        Public Function getDatabaseName() As String
            Return System.Configuration.ConfigurationManager.AppSettings.Item("DatabaseName").Trim
        End Function

        Public Function getdfUserName() As String
            'Try
            Return System.Configuration.ConfigurationManager.AppSettings.Item("dfUserName").Trim
            'Catch ex As Exception
            '    Return ""
            'End Try
        End Function

        Public Function getUserName() As String
            Return System.Configuration.ConfigurationManager.AppSettings.Item("UserName").Trim
        End Function

        Public Function getPassword() As String
            Dim strPass As String = System.Configuration.ConfigurationManager.AppSettings.Item("Password").Trim
            Return getDecryptStr(strPass)
        End Function

        Public Function getDefaultLanguage() As String
            Return System.Configuration.ConfigurationManager.AppSettings.Item("DefaultCulture").Trim
        End Function

        Public Function getSkinName() As String
            Return System.Configuration.ConfigurationManager.AppSettings.Item("SkinName").Trim
        End Function

        Public Function PDF_Path_Contract() As String
            Return System.Configuration.ConfigurationManager.AppSettings.Item("PDF_Path_Contract").Trim
        End Function

        Public Function PDF_Path_Invoice() As String
            Return System.Configuration.ConfigurationManager.AppSettings.Item("PDF_Path_Invoice").Trim
        End Function

        Public Function APIUrl() As String
            Return System.Configuration.ConfigurationManager.AppSettings.Item("APIUrl").Trim
        End Function

        Public Function APIUsername() As String
            Return System.Configuration.ConfigurationManager.AppSettings.Item("APIUsername").Trim
        End Function

        Public Function APIPassword() As String
            Return System.Configuration.ConfigurationManager.AppSettings.Item("APIPassword").Trim
        End Function

        Public Function getDBConnection() As SqlConnection
            Dim strConnString As String = getConnString()
            Return New SqlClient.SqlConnection(strConnString)
        End Function

        Public Function getDBConnection(ByVal ServerName As String, ByVal DatabaseName As String, ByVal UserName As String, ByVal Password As String) As SqlConnection
            Dim strConnString As String = getConnString(ServerName.Trim, DatabaseName.Trim, UserName.Trim, Password.Trim)
            Return New SqlClient.SqlConnection(strConnString)
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

        Public Function getServerTime() As Date
            Dim strSQL As String = "Select SrvTime = GetDate()"
            'Dim Conn As New SqlConnection

            ' Open DB
            'Call OpenDatabase(Conn, True)
            Dim Da As New SqlDataAdapter(strSQL, Conn)
            Dim Ds As New DataSet
            Da.Fill(Ds, "data")

            Return Ds.Tables("Data").Rows(0).Item("SrvTime")
        End Function


        Private Function ConfigurationManager() As Object
            Throw New NotImplementedException
        End Function


    End Class
End Namespace
