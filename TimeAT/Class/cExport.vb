Imports System.Data

Public Class cExport

    Public Shared Sub Export_GridView(save_dialog As System.Windows.Forms.SaveFileDialog, gv As DevExpress.XtraGrid.Views.Grid.GridView, cbo_export As DevExpress.XtraEditors.ComboBoxEdit)
        Dim PathFileName As String = ""

        Select Case cbo_export.Text
            Case "pdf"
                With save_dialog
                    .Filter = "pdf|*.pdf"
                    If .ShowDialog = DialogResult.OK Then
                        PathFileName = .FileName
                    Else
                        Exit Sub
                    End If

                End With
                gv.ExportToPdf(PathFileName)
            Case "xls"
                With save_dialog
                    .Filter = "Excel|*.xls"
                    If .ShowDialog = DialogResult.OK Then
                        PathFileName = .FileName
                    Else
                        Exit Sub
                    End If

                End With
                gv.ExportToXls(PathFileName)
            Case "xlsx"
                With save_dialog
                    .Filter = "Excel 2007 ขึ้นไป|*.xlsx"
                    If .ShowDialog = DialogResult.OK Then
                        PathFileName = .FileName
                    Else
                        Exit Sub
                    End If

                End With
                gv.ExportToXlsx(PathFileName)
            Case "html"
                With save_dialog
                    .Filter = "HTML File|*.html"
                    If .ShowDialog = DialogResult.OK Then
                        PathFileName = .FileName
                    Else
                        Exit Sub
                    End If

                End With
                gv.ExportToPdf(PathFileName)
        End Select
    End Sub
End Class
