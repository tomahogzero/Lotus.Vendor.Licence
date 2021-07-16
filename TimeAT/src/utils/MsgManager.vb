Imports System
Imports System.IO
Imports System.Globalization
Imports System.Configuration
Imports System.Threading
Imports System.Resources

Namespace utils
    Public Class MsgManager
        Protected Shared MsgMgr As ResourceManager

        'Public Sub New()

        'End Sub

        'Public Sub New(ByVal obj As Object, ByVal res As String)
        '    Dim resDir As String = ConfigurationManager.AppSettings.Get("ResourcesDir")
        '    L10NRM = New ResourceManager(obj.GetType().Namespace & "." & res, obj.GetType().Assembly)
        'End Sub

        Public Shared Function GetNodeName(ByVal LocRM As ResourceManager, ByVal obj As Object, ByVal node As String, ByVal objNm As String) As String
            If LocRM Is Nothing Then
                LocRM = New ResourceManager(obj.GetType().Namespace & "." & objNm, obj.GetType().Assembly)
            End If

            Dim sNm As String
            Try
                sNm = LocRM.GetString(node)
                If (sNm <> "") Then
                    sNm = sNm
                Else
                    sNm = node
                End If
            Catch ex As Exception
                sNm = node
            End Try

            Return sNm
        End Function

        Public Shared Function GetMonthName(ByVal strDt As String, ByVal strCulture As String) As String
            'Dim MyDateTime As DateTime = DateTime.Parse(strDt, New CultureInfo(strCulture))
            Dim MyDateTime As DateTime = DateTime.Parse(strDt, CultureInfo.InvariantCulture)
            Dim Month As String = MyDateTime.ToString("MMMM", New CultureInfo(strCulture))

            Return Month
        End Function

        Public Shared Function GetTHYear(ByVal strDt As String) As String
            Dim myCal As New ThaiBuddhistCalendar()
            Dim MyDateTime As DateTime = DateTime.Parse(strDt, CultureInfo.InvariantCulture)

            Return myCal.GetYear(MyDateTime)
        End Function

        Public Shared Function ConfirmDialog(ByVal obj As Object, ByVal res As String, ByVal title As String, ByVal msg As String, ByVal icon As System.Windows.Forms.MessageBoxIcon) As System.Windows.Forms.DialogResult
            Dim resDir As String = ConfigurationManager.AppSettings.Get("ResourcesDir")
            MsgMgr = New ResourceManager(obj.GetType().Namespace & "." & res, obj.GetType().Assembly)

            Return MessageBox.Show(GetLocalizedString(msg), GetLocalizedString(title), MessageBoxButtons.OKCancel, icon, MessageBoxDefaultButton.Button2)
            'Return True
            'End If

            'Return False
        End Function

        Public Shared Function ShowDialog(ByVal obj As Object, ByVal res As String, ByVal title As String, ByVal msg As String, ByVal icon As System.Windows.Forms.MessageBoxIcon) As System.Windows.Forms.DialogResult
            'Dim resDir As String = ConfigurationManager.AppSettings.Get("ResourcesDir")
            MsgMgr = New ResourceManager(obj.GetType().Namespace & "." & res, obj.GetType().Assembly)
            Return MessageBox.Show(GetLocalizedString(msg), GetLocalizedString(title), MessageBoxButtons.OK, icon, MessageBoxDefaultButton.Button1)
            'Return MessageBox.Show(GetLocalizedString(msg), GetLocalizedString(title), MessageBoxButtons.OK, Nothing, MessageBoxDefaultButton.Button1)
        End Function

        Public Shared Function ShowLabel(ByVal obj As Object, ByVal res As String, ByVal msg As String) As String
            MsgMgr = New ResourceManager(obj.GetType().Namespace & "." & res, obj.GetType().Assembly)
            Return GetLocalizedString(msg)
        End Function

        Public Shared Function GetLocalizedString(ByVal node As String) As String
            Dim sNm As String
            Try
                sNm = MsgMgr.GetString(node)
                If (sNm <> "") Then
                    sNm = sNm
                Else
                    sNm = node
                End If
            Catch ex As Exception
                sNm = node
            End Try

            Return sNm
        End Function
    End Class
End Namespace

