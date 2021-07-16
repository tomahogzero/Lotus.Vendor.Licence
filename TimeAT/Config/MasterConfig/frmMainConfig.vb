Imports TimeAttendance.utils
'Imports Payroll.Model
Imports System.IO
Imports System.Globalization

Imports System.Data
Imports System.Data.SqlClient

Public Class frmMainConfig
    Protected dbMgr As New DBManager
    Protected dbConnStr As String = dbMgr.getConnString

    Public Overrides Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If IsNumeric(txtVisaWornning.Text) = False Then txtVisaWornning.Text = "0"


        Dim db As New db
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim strType As String
        Dim Data As New ArrayList

        Data.Clear() : strType = ""
        Data.Add(txtVisaWornning.Text.Trim) : strType &= "I"
        Data.Add(txtPicPath.Text.Trim) : strType &= "T"
        Data.Add(IIf(optPayrollTotalNoDigit.Checked, 1, 0)) : strType &= "B"
        Data.Add(IIf(ChkTime.Checked, 1, 0)) : strType &= "B"
        
        If ExistCompany() = False Then
            strSQL = "Insert Into Company(VisaWornning,PicPath," & _
                                " Payroll_NoDigit,Cal_Sal_Range_Custom) " & _
                                " Values (@P1,@P2,@P3,@P4)"
        Else
            strSQL = "Update Company Set VisaWornning = @P1," & _
                                        " PicPath = @P2," & _
                                        " Payroll_NoDigit = @P3," & _
                                        " Cal_Sal_Range_Custom = @P4"
        End If
        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dCmd, strSQL, strType, Data)
        Call dbMgr.OpenDatabase(Conn, False)
        MsgManager.ShowDialog(Me, "Messages", Me.Text, "Save_Complete", MessageBoxIcon.Information)
    End Sub

    Public Overrides Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Call LoadCompany()
    End Sub


    Function ExistCompany() As Boolean
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        Call dbMgr.OpenDatabase(Conn, True)
        strSQL = "Select * from Company"
        db.ExecuteCommand(Conn, dCmd, strSQL)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)

        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        End With
    End Function

    Private Sub LoadCompany()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        strSQL = "Select * from Company"
        Call dbMgr.OpenDatabase(Conn, True)
        db.ExecuteCommand(Conn, dCmd, strSQL)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")
        Call dbMgr.OpenDatabase(Conn, False)

        With Ds.Tables("Data")
            If .Rows.Count = 0 Then
                Call ClearData()
                Exit Sub
            End If

            Dim dr As DataRow = .Rows(0)

            txtVisaWornning.Text = dr("VisaWornning")
            txtPicPath.Text = dr("PicPath")
            If dr("Payroll_NoDigit") = True Then
                optPayrollTotalNoDigit.Checked = True
            Else
                optPayrollTotal2Digit.Checked = True
            End If

            If dr("Cal_Sal_Range_Custom") = True Then
                ChkTime.Checked = True
            Else
                ChkTime.Checked = False
            End If
        End With
    End Sub

    Private Sub ClearData()
        txtVisaWornning.Text = ""
        optPayrollTotal2Digit.Checked = True
        ChkTime.Checked = False
    End Sub

    Private Sub frmMainConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnEdit.Visible = False
        btnDelete.Visible = False
        btnSearch.Visible = False
        btnPrint.Visible = False

        Call LoadCompany()
    End Sub
End Class