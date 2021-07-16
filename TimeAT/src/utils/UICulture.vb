Imports System
Imports System.IO
Imports System.Globalization
Imports System.Configuration
Imports System.Threading

Imports System.Collections.Generic
Imports System.Text

Namespace utils

    Public Class UICulture
        Dim blnReqLogin As Boolean = True
        Dim blnCanc As Boolean = False

        Public Function getCurrentCulture() As String
            Return Thread.CurrentThread.CurrentCulture.ToString
        End Function

        'Public Shared Sub changeCulture()
        '    'Dim strCulture As String = ConfigurationManager.AppSettings.Get("DefaultCulture")
        '    changeCulture("DefaultCulture")
        'End Sub

        Public Shared Sub changeCulture(Optional ByVal pCulture As String = "", Optional ByVal sCulture As String = "")
            Dim strCulture As String = ""

            If pCulture = "" And sCulture = "" Then
                strCulture = ConfigurationManager.AppSettings.Get("DefaultCulture")
            ElseIf pCulture <> "" Then
                strCulture = ConfigurationManager.AppSettings.Get(pCulture)
            Else
                strCulture = sCulture
            End If

            Try
                Thread.CurrentThread.CurrentCulture = New CultureInfo(strCulture)
                Thread.CurrentThread.CurrentUICulture = New CultureInfo(strCulture)
            Catch e As Exception
                MessageBox.Show("Exception in UICulture: " & e.Message)
            End Try
        End Sub
    End Class
End Namespace
