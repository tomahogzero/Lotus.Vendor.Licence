Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.UserSkins
Imports TimeAttendance.utils
Imports System.Globalization
Imports System.Threading
Imports System.Threading.Thread

Module modStartup
    Public LogDBPass As Boolean = False
    Public LogUserPass As Boolean = False

    Public UserId As String = ""
    Public Default_Lang As String = "th"

    Public U_Username As String = ""

    Public sysUsername As String = ""
    Public sysPassword As String = ""
    Public sysServer As String = ""
    Public sysDatabase As String = ""

    Sub Main()
        Dim dbMgr As New DBManager
        'Dim Conn As SqlConnection = Nothing

        Application.EnableVisualStyles()

        BonusSkins.Register()
        SkinManager.EnableFormSkins()
        UserLookAndFeel.Default.SetSkinStyle(dbMgr.getSkinName)

        cValGolbal.SkinName = dbMgr.getSkinName

        If constdef.cLanguage.Language = "MULTI" Then
            cValGolbal.Lang = dbMgr.getDefaultLanguage
        Else
            cValGolbal.Lang = constdef.cLanguage.Language
        End If


        Select Case cValGolbal.Lang
            Case "TH"  '-- Thai
                CurrentThread.CurrentCulture = New CultureInfo("th-TH")
                CurrentThread.CurrentUICulture = New CultureInfo("th-TH")
                cValGolbal.Lang = "TH"
            Case "EN"  '-- English
                CurrentThread.CurrentCulture = New CultureInfo("en-US")
                CurrentThread.CurrentUICulture = New CultureInfo("en-US")
                cValGolbal.Lang = "EN"
        End Select

        ' Test LogIn
        If TestLogIn() = True Then
            Dim frmLicence As New frmVendorLicence
            Application.Run(frmLicence)
        Else
            ' Test Login Fail to Open Login Database
            Dim frmLogInUser As New frmLoginDatabase
            Application.Run(frmLogInUser)

            If LogDBPass = True Then
                Dim frmLogin As New frmLoginPage
                Application.Run(frmLogin)
            End If
        End If

        ' Login User Pass Open Mainmenu
        If LogUserPass = True Then
            Dim frmLicence = New frmVendorLicence
            Application.Run(frmLicence)

        End If

    End Sub

    Function TestLogIn() As Boolean
        Dim dbMgr As New DBManager
        'Dim Conn As SqlConnection = Nothing

        Try
            Conn = dbMgr.getDBConnection()
            Conn.Open()
            'Conn.Close()

            sysUsername = dbMgr.getUserName.Trim
            sysPassword = dbMgr.getPassword.Trim
            sysServer = dbMgr.getServerName.Trim
            sysDatabase = dbMgr.getDatabaseName.Trim

        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Function TestLogIn(ByVal Password As String) As Boolean
        Dim dbMgr As New DBManager
        'Dim Conn As SqlConnection = Nothing

        Try
            Conn = dbMgr.getDBConnection(dbMgr.getServerName, dbMgr.getDatabaseName, "sa", Password.Trim)
            Conn.Open()
            'Conn.Close()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
End Module
