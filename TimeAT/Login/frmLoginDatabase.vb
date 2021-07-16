Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports TimeAttendance.utils
Imports System.Resources

Imports System.Globalization
Imports System.Threading
Imports System.Enum

Public Class frmLoginDatabase

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        Dim dbMgr As New DBManager
        'Dim Conn As SqlConnection = Nothing

        Try
            Conn = dbMgr.getDBConnection(txtServerName.Text.Trim, _
                                        txtDatabaseName.Text.Trim, _
                                        txtUserName.Text.Trim, _
                                        txtPassword.Text.Trim)
            ' Test Connection
            Conn.Open()
            ' Pass
            'Conn.Close()

            ' Set Status Login Database Pass
            LogDBPass = True

            sysUsername = txtUserName.Text.Trim
            sysPassword = txtPassword.Text.Trim
            sysServer = txtServerName.Text.Trim
            sysDatabase = txtDatabaseName.Text.Trim

            ' Re Setting Default Config
            Dim Config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

            ' Remove / Add New Default
            ' ServerName
            Config.AppSettings.Settings.Remove("ServerName")
            Config.AppSettings.Settings.Add("ServerName", txtServerName.Text.Trim)
            ' DatabaseName
            Config.AppSettings.Settings.Remove("DatabaseName")
            Config.AppSettings.Settings.Add("DatabaseName", txtDatabaseName.Text.Trim)
            ' UserName
            Config.AppSettings.Settings.Remove("UserName")
            Config.AppSettings.Settings.Add("UserName", txtUserName.Text.Trim)
            ' Password
            Config.AppSettings.Settings.Remove("Password")
            Config.AppSettings.Settings.Add("Password", dbMgr.getEncryptStr_Local(txtPassword.Text.Trim))

            ' Setting Language Default
            Dim Lang As String = "th-TH"
            Select Case cboLang.SelectedIndex
                Case 0  '-- Thai
                    Lang = "th-TH"
                Case 1  '-- English
                    Lang = "en-US"
            End Select


            Config.AppSettings.Settings.Remove("DefaultCulture")
            Config.AppSettings.Settings.Add("DefaultCulture", Lang)

            ' Switch Culture Language
            UICulture.changeCulture("", Lang)

            ' Modify/Refresh App Setting
            Config.Save(ConfigurationSaveMode.Modified)
            ConfigurationManager.RefreshSection("appSettings")

            '' Open Login Menu
            'Dim frmLogin As New frmLoginPage
            'frmLogin.Show()

            Me.Close()
        Catch ex As Exception
            MsgManager.ShowDialog(Me, "Messages", "LOGIN_Connect_Fail_Title", "LOGIN_Connect_Fail", MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub frmLoginDatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboLang.Items.Clear()
        cboLang.Items.Add("Thai")
        cboLang.Items.Add("English")
        cboLang.SelectedIndex = 1

        Call LoadDefault()
    End Sub

    Private Sub LoadDefault()
        Dim dbMgr As New DBManager
        txtUserName.Text = dbMgr.getUserName.Trim
        'sysPassword = dbMgr.getPassword.Trim
        txtServerName.Text = dbMgr.getServerName.Trim
        txtDatabaseName.Text = dbMgr.getDatabaseName.Trim
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class