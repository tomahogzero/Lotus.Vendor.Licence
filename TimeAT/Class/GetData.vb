Imports System.Data
Imports System.Data.SqlClient

Public Class GetData

    Public Shared Function encript_password(password As String)
        If password = "" Then
            Return ""
        Else
            Dim err As String = ""
            Dim ret As String = ""
            ret = webAPI.WebAPI.encrip_password(cValGolbal.urlPassword, password, err)
            If err <> "" Then
                Return ""
            Else
                Return ret
            End If
        End If
    End Function

    Public Shared Function GetHourHaftDay() As ArrayList
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim ar As New ArrayList
        strSQL = "Select HaftDay_M =isnull(HaftDay_M,4)," &
                        " HaftDay_A = Isnull(HaftDay_A,4) " &
                " From MainConfig "
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("Data")
            If .Rows.Count = 0 Then
                ar.Clear()
                ar.Add(4)
                ar.Add(4)
            Else
                Dim dr As DataRow = .Rows(0)
                ar.Clear()
                ar.Add(dr("HaftDay_M"))
                ar.Add(dr("HaftDay_A"))
            End If
        End With
        Return ar
    End Function

    Public Shared Function GetValId(ByVal Description As String) As String
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "select Code,Description " &
                " from TimeWorkingstatus " &
                " Where Description = '" & Description.Trim & "'" &
                " Order By Code"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("Code")
            End If
        End With
    End Function


    Public Shared Function GetDivisionId(ByVal Division As String) As String
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "select DivId " &
                " from Division " &
                " Where Division = '" & Division.Trim & "'"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("DivId")
            End If
        End With
    End Function

    Public Shared Function GetDepartmentId(ByVal Department As String) As String
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "select DeptId " &
                " from Department " &
                " Where Department = '" & Department.Trim & "'"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("DeptId")
            End If
        End With
    End Function

    'Public Shared Function GetSectionID(ByVal Department As String) As String
    '    Dim Da As SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim strSQL As String
    '    strSQL = "select SecId " & _
    '            " from Section " & _
    '            " Where Section = '" & Department.Trim & "'"
    '    Da = New SqlDataAdapter(strSQL, Conn)
    '    Da.Fill(Ds, "data")

    '    With Ds.Tables("data")
    '        If .Rows.Count = 0 Then
    '            Return ""
    '        Else
    '            Return .Rows(0).Item("SecId")
    '        End If
    '    End With
    'End Function

    Public Shared Function GetEmpGroupId(ByVal EmpGroup As String) As String
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "select GroupId " &
                " from EmpGroup " &
                " Where GroupName = '" & EmpGroup.Trim & "'"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("GroupId")
            End If
        End With
    End Function

    Public Shared Function GetBrokerId(ByVal BrokerName As String) As String
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "select BrokerId " &
                " from BrokerGroup " &
                " Where BrokerName = '" & BrokerName.Trim & "'"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("BrokerId")
            End If
        End With
    End Function

    Public Shared Function GetCompanyId(ByVal CompanyName As String) As String
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "select CompanyID from Company_Sub" &
                " Where CompanyName = '" & CompanyName.Trim & "'"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("CompanyId")
            End If
        End With


    End Function

    Public Shared Function GetPermision_export_excel(Empcode As String, menu_id As String) As Boolean

        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim Grp_Id As Integer = GetGrpId_byUser(Empcode.Trim)
        strSQL = "Select menu_Id from GenMenu_Pattern where GrpId=" & Grp_Id & " And menu_id='" & menu_id & "' and export_excel=1"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            If .Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        End With

    End Function

    Public Shared Function GetGrpId_byUser(ByVal code As String) As Integer
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim Strsql As String = ""

        Strsql = "select GrpId from [User] where userid='" & code & "'"

        Try
            'OpenConnect(True)
            Da = New SqlDataAdapter(Strsql, Conn)
            Da.Fill(Ds, "DATA")
            'OpenConnect(False)

            With Ds.Tables("DATA")
                If .Rows.Count = 0 Then
                    Return 0
                Else
                    Return .Rows(0).Item("GrpId")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'Public Shared Function GetDivisionId(ByVal DivisionName As String) As String
    '    Dim Da As SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim strSQL As String
    '    strSQL = "select DivId from Division" & _
    '            " Where Division = '" & DivisionName.Trim & "'"

    '    Da = New SqlDataAdapter(strSQL, Conn)
    '    Da.Fill(Ds, "data")

    '    With Ds.Tables("data")
    '        If .Rows.Count = 0 Then
    '            Return ""
    '        Else
    '            Return .Rows(0).Item("DivId")
    '        End If
    '    End With
    'End Function

    'Public Shared Function GetDepartmentID(ByVal DepartmentName As String) As String
    '    Dim Da As SqlDataAdapter
    '    Dim Ds As New DataSet
    '    Dim strSQL As String
    '    strSQL = "select DeptId from Department" & _
    '            " Where Department = '" & DepartmentName.Trim & "'"

    '    Da = New SqlDataAdapter(strSQL, Conn)
    '    Da.Fill(Ds, "data")

    '    With Ds.Tables("data")
    '        If .Rows.Count = 0 Then
    '            Return ""
    '        Else
    '            Return .Rows(0).Item("DeptId")
    '        End If
    '    End With
    'End Function

    Public Shared Function GetSectionID(ByVal SectionName As String) As String
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "select SecId from Section" &
                " Where Section = '" & SectionName.Trim & "'"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("SecId")
            End If
        End With
    End Function

    Public Shared Function GetGroupId(ByVal GroupName As String) As String
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "select GroupId from EmpGroup" &
                " Where GroupName = '" & GroupName.Trim & "'"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("GroupId")
            End If
        End With
    End Function

    Public Shared Function GetOTTypeIdx(ByVal Code As String) As Integer
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim ar As New ArrayList
        strSQL = "Select OtID " &
                " From EmpConfigOT " &
                " Where EmpCode = '" & Code.Trim & "'"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("Data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Dim dr As DataRow = .Rows(0)
                Return dr("OtID")
            End If
        End With
    End Function

    Public Shared Function GetOTFixedRate() As Single
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim ar As New ArrayList
        strSQL = "Select OtFixedRate = Isnull(OTFixedRate,0) from MainConfig"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("Data")
            If .Rows.Count = 0 Then
                Return 0
            Else
                Dim dr As DataRow = .Rows(0)
                Return dr("OtFixedRate")
            End If
        End With
    End Function

    Public Shared Function GetShowEmpName(ByVal EmpID As String) As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select Code,Fname,Lname From Emp" &
                " Where Code = '" & EmpID.Trim & "'"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("FName") & "  " & .Rows(0).Item("LName")
            End If
            '  Ds.Clear()
        End With
    End Function

    Public Shared Function GetDtDepartment() As DataSet
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim ar As New ArrayList
        strSQL = "Select ROW_NUMBER() OVER(ORDER BY dept.divid,dept.DeptId) as row" &
                        " ,dept.DivId,isnull(div.Division,'') as Division " &
                        " ,dept.DeptId,isnull(dept.Department,'') as Department" &
                " from Department dept" &
                        " left join Division div" &
                            " on dept.divid = div.divid " &
                " Order by dept.divid,dept.DeptId"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        Return Ds
    End Function

    Public Shared Function getNewID() As String
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select newid() as nID"
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("nID").ToString
            End If
            '  Ds.Clear()
        End With
    End Function

    Public Shared Function GetCompanyName() As String
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "select companyname " &
                    " from company "
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("companyname")
            End If
        End With
    End Function
End Class


Public Class ListViewComparer
    Implements IComparer

    Private m_ColumnNumber As Integer
    Private m_SortOrder As SortOrder

    Public Sub New(ByVal column_number As Integer, ByVal sort_order As SortOrder)
        m_ColumnNumber = column_number
        m_SortOrder = sort_order
    End Sub

    Public Function Compare(ByVal x As Object, ByVal y As Object) _
     As Integer Implements System.Collections.IComparer.Compare
        Dim item_x As ListViewItem = DirectCast(x, ListViewItem)
        Dim item_y As ListViewItem = DirectCast(y, ListViewItem)

        ' Get the sub-item values.
        Dim string_x As String
        If item_x.SubItems.Count <= m_ColumnNumber Then
            string_x = ""
        Else
            string_x = item_x.SubItems(m_ColumnNumber).Text
        End If

        Dim string_y As String
        If item_y.SubItems.Count <= m_ColumnNumber Then
            string_y = ""
        Else
            string_y = item_y.SubItems(m_ColumnNumber).Text
        End If

        ' Compare them.
        If m_SortOrder = SortOrder.Ascending Then
            Return String.Compare(string_x, string_y)
        Else
            Return String.Compare(string_y, string_x)
        End If
    End Function

End Class
