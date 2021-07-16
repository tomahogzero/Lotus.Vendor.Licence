Imports System.Threading.Thread
Imports System.Globalization

Public Class cDateTime
    Public Shared Function showDate(Data As DateTime) As String
        Return Convert.ToDateTime(Data).ToString("dd/MM/yyyy", cValGolbal.selCultureInfo)
    End Function

    Public Shared Function showYear() As String
        Return Convert.ToDateTime(Now.Date).ToString("yyyy", cValGolbal.selCultureInfo)
    End Function

    Public Shared Function showFormatDate(Data As DateTime, stringFormat As String) As String
        Return Convert.ToDateTime(Data).ToString(stringFormat, cValGolbal.selCultureInfo)
    End Function

    Public Shared Function showstYear() As String
        If Month(Date.Now) >= 4 Then
            Return Convert.ToDateTime(Now.Date).ToString("yyyy", cValGolbal.selCultureInfo)
        Else
            Return Convert.ToDateTime(Now.Date).ToString("yyyy", cValGolbal.selCultureInfo) - 1
        End If
    End Function

    Public Shared Function dbDate(Data As DateTime) As String
        Return Convert.ToDateTime(Data).ToString("yyyy/MM/dd", cValGolbal.dbCultureInfo)
    End Function

    Public Shared Function localFormatDate(Data As DateTime, stringFormat As String) As String
        Return Convert.ToDateTime(Data).ToString(stringFormat, cValGolbal.selCultureInfo)
    End Function

    Public Shared Function dbFormatDate(Data As DateTime, stringFormat As String) As String
        Return Convert.ToDateTime(Data).ToString(stringFormat, cValGolbal.dbCultureInfo)
    End Function

    Public Shared Function dbStyear(Data As String) As String
        Data = Data & "/01/01"
        Return Convert.ToDateTime(Data).ToString("yyyy", cValGolbal.dbCultureInfo)
    End Function

    Public Shared Function dbStyear2(Data As String) As String
        Data = Data & "/01/01"
        Return Convert.ToDateTime(Data).ToString("yy", cValGolbal.dbCultureInfo)
    End Function


    Public Shared Function showMonthName(i As Integer) As String
        'My.Resources.Culture = cValGolbal.selCultureInfo
        Select Case i
            Case 1
                Return My.Resources.res_month.m1
            Case 2
                Return My.Resources.res_month.m2
            Case 3
                Return My.Resources.res_month.m3
            Case 4
                Return My.Resources.res_month.m4
            Case 5
                Return My.Resources.res_month.m5
            Case 6
                Return My.Resources.res_month.m6
            Case 7
                Return My.Resources.res_month.m7
            Case 8
                Return My.Resources.res_month.m8
            Case 9
                Return My.Resources.res_month.m9
            Case 10
                Return My.Resources.res_month.m10
            Case 11
                Return My.Resources.res_month.m11
            Case 12
                Return My.Resources.res_month.m12
            Case Else
                Return ""
        End Select
    End Function




End Class
