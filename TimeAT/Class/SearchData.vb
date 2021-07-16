Imports System.Data
Imports System.Data.SqlClient
Imports TimeAttendance.utils

Public Class SearchData


    Public Shared Sub LoadCompany(ByVal sender As System.Object, ByVal Control As DevComponents.DotNetBar.Controls.ComboBoxEx, ByVal All As Boolean)
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        strSQL = "Select CompanyName From Company_Sub "
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            Control.Items.Clear()
            Control.Items.Add(MsgManager.ShowLabel(sender, "Search", "All"))

            Dim I As Integer
            For I = 0 To .Rows.Count - 1
                Control.Items.Add(.Rows(I).Item("CompanyName"))
            Next
            Ds.Clear()
            Control.SelectedIndex = 0
        End With
    End Sub

    'Public Shared Sub LoadDivision(ByVal sender As System.Object, ByVal control As DevExpress.XtraEditors.ComboBoxEdit, ByVal All As Boolean, ByVal companyid As String)

    'End Sub

    ' Public Shared Sub LoadDivision(ByVal sender As System.Object, ByVal Control As DevComponents.DotNetBar.Controls.ComboBoxEx, ByVal All As Boolean, ByVal CompanyId As String)
    Public Shared Sub LoadDivision(ByVal sender As System.Object, ByVal control As DevExpress.XtraEditors.ComboBoxEdit, ByVal All As Boolean)
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select DivId,Division " &
                " From Division "
        strSQL &= " Order By Division"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            control.Properties.Items.Clear()
            If All = True Then
                '   control.Properties.Items.Add(MsgManager.ShowLabel(sender, "Search", "All"))
                control.Properties.Items.Add(My.Resources.res_simple_label.all)
            End If

            For Each dr As DataRow In .Rows
                control.Properties.Items.Add(dr("Division"))
            Next
            If control.Properties.Items.Count > 0 Then
                control.SelectedIndex = 0
            End If
        End With
    End Sub

    Public Shared Sub LoadDepartment(ByVal sender As System.Object, ByVal Control As DevExpress.XtraEditors.ComboBoxEdit, ByVal All As Boolean)
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select Department " &
                " From Department "
        strSQL &= " Order By Department"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            Control.Properties.Items.Clear()

            If All = True Then
                '  Control.Properties.Items.Add(MsgManager.ShowLabel(sender, "Search", "All"))
                Control.Properties.Items.Add(My.Resources.res_simple_label.all)
            End If

            For Each dr As DataRow In .Rows
                Control.Properties.Items.Add(dr("Department"))
            Next
            If Control.Properties.Items.Count > 0 Then
                Control.SelectedIndex = 0
            End If

        End With
    End Sub

    Public Shared Sub LoadDepartment(ByVal sender As System.Object, ByVal Control As DevExpress.XtraEditors.ComboBoxEdit, divid As String, ByVal All As Boolean)
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select Department " &
                " From Department "

        If divid.Trim <> "" Then
            strSQL &= " where divid = '" & divid & "'"
        End If

        strSQL &= " Order By Department"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            Control.Properties.Items.Clear()

            If All = True Then
                '   Control.Properties.Items.Add(MsgManager.ShowLabel(sender, "Search", "All"))
                Control.Properties.Items.Add(My.Resources.res_simple_label.all)
            End If

            For Each dr As DataRow In .Rows
                Control.Properties.Items.Add(dr("Department"))
            Next
            If Control.Properties.Items.Count > 0 Then
                Control.SelectedIndex = 0
            End If

        End With
    End Sub

    Public Shared Sub LoadSection(ByVal sender As System.Object, ByVal Control As DevExpress.XtraEditors.ComboBoxEdit, ByVal All As Boolean)
        Dim CompanyId As String = ""

        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select Section " &
                " From Section "
        If CompanyId.Trim <> "" Then
            strSQL &= " Where SecId In (Select SecId From Emp Where WorkStatus = 'W' and CompanyId = '" & CompanyId.Trim & "')"
        End If
        strSQL &= " Order By Section"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            Control.Properties.Items.Clear()

            If All = True Then
                '   Control.Properties.Items.Add(MsgManager.ShowLabel(sender, "Search", "All"))
                Control.Properties.Items.Add(My.Resources.res_simple_label.all)
            End If

            For Each dr As DataRow In .Rows
                Control.Properties.Items.Add(dr("Section"))
            Next
            If Control.Properties.Items.Count > 0 Then
                Control.SelectedIndex = 0
            End If
        End With
    End Sub

    Public Shared Sub LoadPosition(ByVal sender As System.Object, ByVal Control As DevExpress.XtraEditors.ComboBoxEdit, ByVal All As Boolean)
        Dim CompanyId As String = ""
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select Position " &
                " From Emp "
        If CompanyId.Trim <> "" Then
            strSQL &= " Where Position In (Select LTrim(RTrim(Position)) From Emp Where WorkStatus = 'W' and CompanyId = '" & CompanyId.Trim & "')"
        End If
        strSQL &= " Group By Position " &
                " Order By Position"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            Control.Properties.Items.Clear()

            If All = True Then
                '  Control.Properties.Items.Add(MsgManager.ShowLabel(sender, "Search", "All"))
                Control.Properties.Items.Add(My.Resources.res_simple_label.all)
            End If

            For Each dr As DataRow In .Rows
                Control.Properties.Items.Add(dr("Position"))
            Next
            Control.SelectedIndex = 0
        End With
    End Sub

    Public Shared Sub LoadEmpGroup(ByVal sender As System.Object, ByVal Control As DevExpress.XtraEditors.ComboBoxEdit, ByVal All As Boolean)
        Dim CompanyId As String = ""

        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select GroupName " &
                " From EmpGroup "
        If CompanyId.Trim <> "" Then
            strSQL &= " Where GroupId In (Select GroupId From Emp Where WorkStatus = 'W' and CompanyId = '" & CompanyId.Trim & "')"
        End If
        strSQL &= " Order By GroupName"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            Control.Properties.Items.Clear()
            '  Control.Properties.Items.Add(MsgManager.ShowLabel(sender, "Search", "All"))
            Control.Properties.Items.Add(My.Resources.res_simple_label.all)

            For Each dr As DataRow In .Rows
                Control.Properties.Items.Add(dr("GroupName"))
            Next
            Control.SelectedIndex = 0
        End With
    End Sub


    Public Shared Sub LoadBroker(ByVal sender As System.Object, ByVal Control As DevComponents.DotNetBar.Controls.ComboBoxEx, ByVal All As Boolean)
        Dim CompanyId As String = ""
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "Select BrokerId,BrokerName " &
                " From BrokerGroup "
        If CompanyId.Trim <> "" Then
            strSQL &= " Where BrokerId In (Select BrokerId From Emp Where WorkStatus = 'W' and CompanyId = '" & CompanyId.Trim & "')"
        End If
        strSQL &= " Order By BrokerName"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            Control.Items.Clear()
            Control.Items.Add(MsgManager.ShowLabel(sender, "Search", "All"))
            '  Control.Properties.Items.Add(My.Resources.res_simple_label.all)

            For Each dr As DataRow In .Rows
                Control.Items.Add(dr("BrokerName"))
            Next
            Control.SelectedIndex = 0
        End With
    End Sub

    Public Shared Sub LoadMonth(ByVal Control As DevExpress.XtraEditors.ComboBoxEdit, ByVal All As Boolean, setDefault As Boolean)

        Control.Properties.Items.Clear()

        If All = True Then
            Control.Properties.Items.Add(My.Resources.res_simple_label.all)
        End If

        Control.Properties.Items.Add(My.Resources.res_month.m1)
        Control.Properties.Items.Add(My.Resources.res_month.m2)
        Control.Properties.Items.Add(My.Resources.res_month.m3)
        Control.Properties.Items.Add(My.Resources.res_month.m4)
        Control.Properties.Items.Add(My.Resources.res_month.m5)
        Control.Properties.Items.Add(My.Resources.res_month.m6)
        Control.Properties.Items.Add(My.Resources.res_month.m7)
        Control.Properties.Items.Add(My.Resources.res_month.m8)
        Control.Properties.Items.Add(My.Resources.res_month.m9)
        Control.Properties.Items.Add(My.Resources.res_month.m10)
        Control.Properties.Items.Add(My.Resources.res_month.m11)
        Control.Properties.Items.Add(My.Resources.res_month.m12)

        If setDefault = True Then
            If All = True Then
                Control.SelectedIndex = Now.Month
            Else
                Control.SelectedIndex = Now.Month - 1
            End If
        Else
            Control.SelectedIndex = 0
        End If
    End Sub
End Class
