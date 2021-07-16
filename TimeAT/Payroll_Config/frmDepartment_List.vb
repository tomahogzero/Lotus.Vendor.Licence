Imports DevExpress.XtraGrid.Views.Grid
Imports TimeAttendance.utils
Imports System.IO
Imports System.Globalization

Imports System.Data
Imports System.Data.SqlClient

Public Class frmDepartment_List
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub frmDepartment_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadData()
    End Sub

    Private Sub GvHoliday_DoubleClick(sender As Object, e As EventArgs) Handles GvHoliday.DoubleClick
        Try
            Dim gv As GridView = CType(sender, GridView)

            '     If IsDBNull(gv.GetRowCellValue(gv.FocusedRowHandle, "Code")) = True Then Exit Sub

            'fEmp.txtdeptId.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "DeptId")
            'fEmp.txtDivId.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "DivId")
            'fEmp.txtDepartment.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Department")
            'fEmp.txtDivision.Text = gv.GetRowCellValue(gv.FocusedRowHandle, "Division")
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadData()

        GcHoliday.DataSource = GetData.GetDtDepartment
        GcHoliday.DataMember = "data"


    End Sub
End Class