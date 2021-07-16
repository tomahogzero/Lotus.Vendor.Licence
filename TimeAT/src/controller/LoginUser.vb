Imports System.Data.SqlClient
Imports TimeAttendance.utils
Imports TimeAttendance.Model


Namespace controller
    Public Class LoginUser
        Private login As Boolean = False
        Public Shared usr As User = Nothing
        'Public Shared uRole As Role = New Role()

        Public Function isLogin() As Boolean
            Return login
        End Function

        Public Overridable Function userLogin(ByVal conn As SqlConnection, ByVal com As String, _
                                            ByVal strUsr As String, ByVal strPwd As String) As User
            Dim strTmp As String = ""
            Dim encPwd As String
            Dim rdrQuery As String = "SELECT * FROM tUser WHERE UserID = @Username AND Password = @Password AND ComId = @ComId " & _
                                    "AND (Status = 'A' AND getDate() BETWEEN IsNull(Eff_From, '1/1/1900') AND IsNull(Eff_To, '12/31/9999')) "

            'If AppVar.IsPwdEncrypt Then
            encPwd = SecEncLib.Encryption.Encrypt(strPwd, AppConstants.pwdPhrase, AppConstants.pwdSalt, AppConstants.hash, 2, AppConstants.pwdIVector, AppConstants.iKey)
            'Else
            'encPwd = strPwd
            'End If

            Try
                conn.Open()
                Dim cmd As New SqlCommand(rdrQuery, conn)
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = strUsr
                'cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = strPwd
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = encPwd
                cmd.Parameters.Add("@ComId", SqlDbType.NVarChar, 15).Value = com
                Dim rdr As SqlDataReader = cmd.ExecuteReader()
                While rdr.Read()
                    'usr.Name = rdr("UserNm").ToString()
                    usr = New User(rdr("ComID").ToString(), rdr("UserID").ToString(), rdr("UserNm").ToString(), rdr("UserType").ToString())
                    login = True
                    'uRole.SetPrincipalPolicy(usr.UserID)
                End While
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            Finally
                conn.Close()
            End Try

            Return usr
        End Function

        Public Sub doLogin(ByVal comp As String, ByVal user As String, ByVal pwd As String)
            Dim dbMgr As New DBManager
            Dim dbConnWH As SqlConnection = dbMgr.getDBConnection

            userLogin(dbConnWH, comp, user, pwd)
        End Sub
    End Class
End Namespace

