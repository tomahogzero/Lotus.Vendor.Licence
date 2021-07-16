Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class cProcessTime
    Public Shared Function processTimeAll(datein As DateTime, code As String) As String
        Dim dcmd As New SqlCommand

        Dim err As String = processTime(dcmd, datein, code)
        If err.Trim <> "" Then
            Return "คำนวณเวลาทำงาน -" & err
        End If

        err = processLate(dcmd, datein, code)
        If err.Trim <> "" Then
            Return "คำนวณสาย -" & err
        End If

        err = processOt(dcmd, datein, code)
        If err.Trim <> "" Then
            Return "คำนวณ Ot -" & err
        End If

        err = processAbs(dcmd, datein, code)
        If err.Trim <> "" Then
            Return "คำนวณ ขาด -" & err
        End If

        Return ""
    End Function

    Public Shared Function processTimeAll(dcmd As SqlCommand, datein As DateTime, code As String) As String

        Dim err As String = processTime(dcmd, datein, code)
        If err.Trim <> "" Then
            Return "คำนวณเวลาทำงาน -" & err
        End If

        err = processLate(dcmd, datein, code)
        If err.Trim <> "" Then
            Return "คำนวณสาย -" & err
        End If

        err = processOt(dcmd, datein, code)
        If err.Trim <> "" Then
            Return "คำนวณ Ot -" & err
        End If

        err = processAbs(dcmd, datein, code)
        If err.Trim <> "" Then
            Return "คำนวณ ขาด -" & err
        End If

        Return ""
    End Function

    Public Shared Function processTimeAll_withLog(datein As DateTime, code As String, lblog As DevExpress.XtraEditors.ListBoxControl) As String
        Dim dcmd As New SqlCommand

        Dim time As String = ""

        time = Format(Now, "HH:mm:ss")

        Dim err As String = processTime(dcmd, datein, code)
        If err.Trim <> "" Then
            lblog.Items.Insert(0, cDateTime.showDate(datein) & " (" & time & ")" & " - " & My.Resources.res_simple_label.Process_WorkingTime & " : " & err)
            Return "คำนวณเวลาทำงาน -" & err
        Else
            lblog.Items.Insert(0, cDateTime.showDate(datein) & " (" & time & ")" & " - " & My.Resources.res_simple_label.Process_WorkingTime & " : " & My.Resources.res_simple_label.Completed)
        End If

        lblog.SelectedIndex = 0
        Application.DoEvents()
        time = Format(Now, "HH:mm:ss")

        err = processLate(dcmd, datein, code)
        If err.Trim <> "" Then
            lblog.Items.Insert(0, cDateTime.showDate(datein) & " (" & time & ")" & " - " & My.Resources.res_simple_label.Process_Late & " : " & err)
            Return "คำนวณสาย -" & err
        Else
            lblog.Items.Insert(0, cDateTime.showDate(datein) & " (" & time & ")" & " - " & My.Resources.res_simple_label.Process_Late & " : " & My.Resources.res_simple_label.Completed)
        End If
        lblog.SelectedIndex = 0
        Application.DoEvents()
        time = Format(Now, "HH:mm:ss")

        err = processOt(dcmd, datein, code)
        If err.Trim <> "" Then
            lblog.Items.Insert(0, cDateTime.showDate(datein) & " (" & time & ")" & " - " & My.Resources.res_simple_label.Process_OT & " : " & err)
            Return "คำนวณ Ot -" & err
        Else
            lblog.Items.Insert(0, cDateTime.showDate(datein) & " (" & time & ")" & " - " & My.Resources.res_simple_label.Process_OT & " : " & My.Resources.res_simple_label.Completed)
        End If
        lblog.SelectedIndex = 0
        Application.DoEvents()
        time = Format(Now, "HH:mm:ss")

        err = processAbs(dcmd, datein, code)
        If err.Trim <> "" Then
            lblog.Items.Insert(0, cDateTime.showDate(datein) & " (" & time & ")" & " - " & My.Resources.res_simple_label.Process_Absent & " : " & err)
            Return "คำนวณ ขาด -" & err
        Else
            lblog.Items.Insert(0, cDateTime.showDate(datein) & " (" & time & ")" & " - " & My.Resources.res_simple_label.Process_Absent & " : " & My.Resources.res_simple_label.Completed)
        End If
        lblog.Items.Insert(0, "--------------------------------------------------------------------------------------------------")
        lblog.SelectedIndex = 0
        Application.DoEvents()
        Return ""
    End Function

    Public Shared Function processTime(dcmd As SqlCommand, datein As DateTime, code As String) As String
        Try
            ' clear data by date
            StrSql = "exec spTimeGenTimeWork_Clear '" & Format(datein, "yyyy/MM/dd") & "','" & code & "'"
            dcmd.Connection = Conn
            dcmd.CommandText = StrSql
            dcmd.CommandTimeout = 60
            dcmd.ExecuteNonQuery()

            ' calculate spacial ka (8 hour)
            StrSql = "exec spTimeGenTimeWork_KaSpacial '" & Format(datein, "yyyy/MM/dd") & "','" & code & "'"
            dcmd.Connection = Conn
            dcmd.CommandText = StrSql
            dcmd.CommandTimeout = 60
            dcmd.ExecuteNonQuery()

            ' calculate flexible hour
            StrSql = "exec spTimeGenTimeWork_FlexibleHour '" & Format(datein, "yyyy/MM/dd") & "','" & code & "'"
            dcmd.Connection = Conn
            dcmd.CommandText = StrSql
            dcmd.CommandTimeout = 60
            dcmd.ExecuteNonQuery()

            ' calculate ka by date
            StrSql = "exec spTimeGenTimeWork_KaDate '" & Format(datein, "yyyy/MM/dd") & "','" & code & "'"
            dcmd.Connection = Conn
            dcmd.CommandText = StrSql
            dcmd.CommandTimeout = 60
            dcmd.ExecuteNonQuery()

            ' calculate ka standard
            StrSql = "exec spTimeGenTimeWork_EmpKa '" & Format(datein, "yyyy/MM/dd") & "','" & code & "'"
            dcmd.Connection = Conn
            dcmd.CommandText = StrSql
            dcmd.CommandTimeout = 60
            dcmd.ExecuteNonQuery()

            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Shared Function processLate(dcmd As SqlCommand, datein As DateTime, code As String) As String
        Try
            ' clear data by date
            StrSql = "exec spTimeGenLate_Clear '" & Format(datein, "yyyy/MM/dd") & "','" & code & "'"
            dcmd.Connection = Conn
            dcmd.CommandText = StrSql
            dcmd.CommandTimeout = 60
            dcmd.ExecuteNonQuery()

            ' calculate late ka basic , ka by date
            StrSql = "exec spTimeGenLate '" & Format(datein, "yyyy/MM/dd") & "','" & code & "'"
            dcmd.Connection = Conn
            dcmd.CommandText = StrSql
            dcmd.CommandTimeout = 60
            dcmd.ExecuteNonQuery()

            ' calculate flexible hour
            StrSql = "exec spTimeGenLate_FlexibleHour '" & Format(datein, "yyyy/MM/dd") & "','" & code & "'"
            dcmd.Connection = Conn
            dcmd.CommandText = StrSql
            dcmd.CommandTimeout = 60
            dcmd.ExecuteNonQuery()

            ' sum late
            StrSql = "exec spTimeGenLate_SumTotal '" & Format(datein, "yyyy/MM/dd") & "','" & code & "'"
            dcmd.Connection = Conn
            dcmd.CommandText = StrSql
            dcmd.CommandTimeout = 60
            dcmd.ExecuteNonQuery()

            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function


    Public Shared Function processOt(dcmd As SqlCommand, datein As DateTime, code As String) As String
        Try
            ' clear data by date
            StrSql = "exec spTimeGenOTAll_Clear '" & Format(datein, "yyyy/MM/dd") & "','" & code & "'"
            dcmd.Connection = Conn
            dcmd.CommandText = StrSql
            dcmd.CommandTimeout = 60
            dcmd.ExecuteNonQuery()

            ' calculate ot day , ot hour
            StrSql = "exec spTimeGenOTAll '" & Format(datein, "yyyy/MM/dd") & "','" & code & "'"
            dcmd.Connection = Conn
            dcmd.CommandText = StrSql
            dcmd.CommandTimeout = 60
            dcmd.ExecuteNonQuery()

            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Shared Function processAbs(dcmd As SqlCommand, datein As DateTime, code As String) As String
        Try
            ' clear data by date
            StrSql = "exec spTimeAbsAll '" & Format(datein, "yyyy/MM/dd") & "','" & code & "'"
            dcmd.Connection = Conn
            dcmd.CommandText = StrSql
            dcmd.CommandTimeout = 60
            dcmd.ExecuteNonQuery()

            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

End Class
