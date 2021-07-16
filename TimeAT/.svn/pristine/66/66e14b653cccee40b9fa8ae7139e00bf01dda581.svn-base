Imports System.Data
Imports System.Data.SqlClient

Public Class frmConfigViewCompany

    Private Sub frmConfigViewCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadCompany()
        btnOK.Enabled = False
    End Sub
    Private Sub LoadCompany()
      
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = " select pc.CompanyID , cs.CompanyName " & _
                 " from PermissionTimeAtt_Company pc " & _
                     " Left Join Emp e " & _
                             " on pc.IdCode = e.Code " & _
                     " Left Join [User] u " & _
                             " on e.Code = u.UserID " & _
                     " Left Join Company_Sub cs " & _
                             " on pc.CompanyID = cs.CompanyID " & _
                 " where  u.username = '" & cUsername & "'"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")
        With Ds.Tables("Data")
            cboCompany.Items.Clear()
            Dim I As Integer
            For I = 0 To .Rows.Count - 1
                cboCompany.Items.Add(.Rows(I).Item("CompanyName"))
            Next
            Ds.Clear()
        End With

    End Sub

    Public Shared Function GetCompanyId(ByVal CompananyName As String) As String
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String

        strSQL = " select CompanyID From Company_sub " & _
                      " where CompanyName = '" & CompananyName & "'"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("CompanyID")
            End If
        End With
    End Function

    Private Sub cboCompany_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompany.SelectedIndexChanged
        txtCompanyID.Text = GetCompanyId(cboCompany.SelectedItem)

        btnOK.Enabled = True


    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If cUsername = "sa" Then
            ComId = txtCompanyID.Text
            ComName = cboCompany.SelectedItem
        Else
            ComId = ""
            ComName = ""
        End If
        Me.Close()
    End Sub
End Class