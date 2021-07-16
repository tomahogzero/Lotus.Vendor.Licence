Imports TimeAttendance.utils
Imports System.IO
Imports System.Globalization

Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Public Class frmDivision_List
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub frmDivision_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadData()
    End Sub

    Private Sub LoadData()
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        strSQL = "Select ROW_NUMBER() OVER(ORDER BY DivId) as row,* from Division Order by DivId"
        '   
        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "Data")


        GcDivision_List.DataSource = Ds
        GcDivision_List.DataMember = "data"

    End Sub

    Private Sub GcDivision_List_Click(sender As Object, e As EventArgs) Handles GcDivision_List.Click

    End Sub

    Private Sub GvDivision_list_DoubleClick(sender As Object, e As EventArgs) Handles GvDivision_list.DoubleClick
        Try
            Dim gv As GridView = CType(sender, GridView)

            '     If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "Code")) = True Then Exit Sub

            'fEmp.txtDivId.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "DivId")
            'fEmp.txtDivision.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Division")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class