Imports System.Data.SqlClient
Imports System.Data
Imports TimeAttendance.utils

Public Class frmRPTTimeAbsent

    Dim ListvCol As vCol
    Dim ListvColType As vColType
    Dim ListType As Type

    Enum vCol
        vCol1
        vCol2
        vCol3
        vCol4
        vCol5
    End Enum

    Enum vColType
        vColType1
        vColType2
        vColType3
        vColType4
        vColType5
    End Enum

    Enum Type
        Department
        Division
        Section
    End Enum

    Private Sub frmRPTTimeAbsent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadCompany()
    End Sub

    Private Sub LoadCompany()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select CompanyName From Company_Sub "
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            cboCompany.Items.Clear()
            cboCompany.Items.Add(MsgManager.ShowLabel(Me, "Search", "All"))

            Dim I As Integer
            For I = 0 To .Rows.Count - 1
                cboCompany.Items.Add(.Rows(I).Item("CompanyName"))
            Next
            Ds.Clear()
            cboCompany.SelectedIndex = 0
        End With
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Call GenData()
        ReportPrint = Report.PrintTimeAbsent
        'Dim rpt As New frmViewReport
        'rpt.Show()

    End Sub

    Function GettypeDSS() As Type
        If cbSection.Checked = True Then
            Return Type.Section
        ElseIf cbDivision.Checked = True Then
            Return Type.Division

        ElseIf cbDepartment.Checked = True Then
            Return Type.Department
        Else
            Return Type.Section
        End If
    End Function

    Public Function HType() As String
        If Me.cbSection.Checked = True Then
            Return "˹��§ҹ"
        ElseIf Me.cbDivision.Checked = True Then
            Return "����"

        ElseIf Me.cbDepartment.Checked = True Then
            Return "Ἱ�"
        Else
            Return "˹��§ҹ"
        End If
    End Function

    Private Sub GenData()
        'If txtDateStart.Value = Nothing Then
        '    MsgBox("��س����͡��ǧ�ѹ������", MsgBoxStyle.Information, Me.Text)
        '    txtDateStart.Focus()
        '    Exit Sub
        'End If

        'If txtDateStop.Value = Nothing Then
        '    MsgBox("��سһ�͹��ǧ�ѹ������", MsgBoxStyle.Information, Me.Text)
        '    txtDateStop.Focus()
        '    Exit Sub
        'End If

        If txtDateStart.Value = Nothing Then
            'MsgBox("��س����͡��ǧ�ѹ������", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmRPTTimeworkSumaryRS", Me.Text, "Select_Date", MessageBoxIcon.Information)
            txtDateStart.Focus()
            Exit Sub
        End If

        If txtDateStop.Value = Nothing Then
            'MsgBox("��سһ�͹��ǧ�ѹ������", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmRPTTimeworkSumaryRS", Me.Text, "Insert_Date", MessageBoxIcon.Information)
            txtDateStop.Focus()
            Exit Sub
        End If

        Dim DTEmpSection As DataTable = GetDTEmpSection(GettypeDSS)

        Dim DateST As String = Format(txtDateStart.Value, "yyyy/MM/dd")
        Dim DateSP As String = Format(txtDateStop.Value, "yyyy/MM/dd")
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList
        Dim db As New db

        Try

            strSQL = " delete from RPT_TimeAbsent "
            db.ExecuteCommand(Conn, dCmd, strSQL)

            ProcessBar1.Value = 0
            ProcessBar1.Maximum = DTEmpSection.Rows.Count
            Dim i As Integer = 0
            ProcessBar1.Text = i & "/" & ProcessBar1.Maximum


            For Each dr As DataRow In DTEmpSection.Rows
                i += 1
                ProcessBar1.Text = i & "/" & ProcessBar1.Maximum
                ProcessBar1.Value = i


                Data.Clear() : strType = ""
                Data.Add(dr("Name")) : strType &= "T"
                Data.Add(GetEmpCount(dr("Code"), GettypeDSS)) : strType &= "S"
                Data.Add(GetTimevacation(dr("code"), GettypeDSS, DateST, DateSP, 1)) : strType &= "S"
                Data.Add(GetTimevacation(dr("code"), GettypeDSS, DateST, DateSP, 2)) : strType &= "S"
                Data.Add(GetTimevacation(dr("code"), GettypeDSS, DateST, DateSP, 3)) : strType &= "S"
                Data.Add(GetTimevacation(dr("code"), GettypeDSS, DateST, DateSP, 4)) : strType &= "S"
                Data.Add(GetTimevacation(dr("code"), GettypeDSS, DateST, DateSP, 5)) : strType &= "S"
                Data.Add(GetTimevacation(dr("code"), GettypeDSS, DateST, DateSP, 6)) : strType &= "S"
                Data.Add(GetTimevacation(dr("code"), GettypeDSS, DateST, DateSP, 7)) : strType &= "S"
                Data.Add(GetTimevacation(dr("code"), GettypeDSS, DateST, DateSP, 8)) : strType &= "S"
                Data.Add(GetAbs(dr("code"), GettypeDSS, DateST, DateSP)) : strType &= "S"

                strSQL = "Insert Into RPT_TimeAbsent(DDSName,EmpCount,V1,V2,V3,V4,V5,V6,V7,V8,Absent)" & _
                        " Values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11)"

                db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End Try
    End Sub

    Function GetDTEmpSection(ByVal type As Type) As DataTable
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim FieldId As String = ""
        Dim FieldName As String = ""
        Dim TabelName As String = ""

        Select Case type
            Case frmRPTTimeAbsent.Type.Division
                TabelName = "Division"
                FieldName = "Division"
                FieldId = "DivId"
            Case frmRPTTimeAbsent.Type.Section
                TabelName = "Section"
                FieldName = "Section"
                FieldId = "SecID"
            Case frmRPTTimeAbsent.Type.Department
                TabelName = "Department"
                FieldName = "Department"
                FieldId = "DeptID"
        End Select

        strSQL = "Select Code =isnull(" & FieldId.Trim & ",''), " & _
                        " Name =isnull(" & FieldName.Trim & ",'') " & _
                " From " & TabelName.Trim & " "

        If cboCompany.SelectedIndex > 0 Then
            strSQL &= " Where " & FieldId.Trim & " In (Select Code =isnull(" & FieldId.Trim & ",'')" & _
                                    " From Emp " & _
                                    " Where WorkStatus  = 'W' and " & _
                                            " CompanyId = '" & GetData.GetCompanyId(cboCompany.Text) & "')"
        End If


        'strSQL = "Select Code =isnull(" & FieldId.Trim & ",''), " & _
        '               " Name =isnull(" & FieldName.Trim & ",'') " & _
        '         " From " & TabelName.Trim & " "


        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        Return Ds.Tables("Data")
    End Function

    Function GetEmpCount(ByVal Code As String, ByVal rptType As Type) As Single
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        Dim FieldName As String = ""
        Select Case rptType
            Case frmRPTTimeAbsent.Type.Division
                FieldName = "DivId"
            Case frmRPTTimeAbsent.Type.Department
                FieldName = "DeptId"
            Case Else
                FieldName = "SecId"
        End Select

        strSQL = "select code=count(code) " & _
                    " from emp " & _
                        " where workstatus = 'W'" & _
                            " and " & FieldName.Trim & " = '" & Code.Trim & "'"


        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Return .Rows(0).Item("code")
            End If
        End With
    End Function

    Function GetAbs(ByVal Code As String, ByVal rptType As Type, ByVal DateST As String, ByVal DateSP As String) As Single
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        Dim FieldName As String = ""
        Select Case rptType
            Case frmRPTTimeAbsent.Type.Division
                FieldName = "DivId"
            Case frmRPTTimeAbsent.Type.Department
                FieldName = "DeptId"
            Case Else
                FieldName = "SecId"
        End Select

        strSQL = "select Absent = isnull(count(distinct(code)),0) from timeabsent" & _
                        " where code " & _
                            " in (select code from emp where " & FieldName.Trim & " = '" & Code & "' and workstatus = 'W')" & _
                                " and convert(nvarchar(10),datein,111)" & _
                                    " between '" & DateST & "' and '" & DateSP & "'"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Return .Rows(0).Item("Absent")
            End If
        End With
    End Function

    Function GetTimevacation(ByVal Code As String, ByVal rptType As Type, ByVal DateST As String, ByVal DateSP As String, ByVal Col As Integer) As Single
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim ValId As String = GetValId_Type(Col)

        Dim FieldName As String = ""
        Select Case rptType
            Case frmRPTTimeAbsent.Type.Division
                FieldName = "DivId"
            Case frmRPTTimeAbsent.Type.Department
                FieldName = "DeptId"
            Case Else
                FieldName = "SecId"
        End Select


        strSQL = "select amt = isnull(count(distinct(code)),0) from timevacation" & _
                        " where ValId = '" & ValId & "' " & _
                                " and convert(nvarchar(10),valdate,111)" & _
                                        " between '" & DateST & "' and '" & DateSP & "'" & _
                                        " and Code in (Select Code From Emp " & _
                                                    " Where WorkStatus = 'W' and " & _
                                                            " " & FieldName.Trim & "='" & Code & "')"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Return .Rows(0).Item("amt")
            End If
        End With
    End Function

    Function GetValId_Type(ByVal Col As Integer) As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim a As New ArrayList

        strSQL = "select ValId = VId_C" & Col & "" & _
                                   " from dbo.RPT_TimeAbsent_Config "

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Dim dr As DataRow = .Rows(0)
                Return dr("ValId")
            End If
        End With
    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtNameSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtDateStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LabelX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class