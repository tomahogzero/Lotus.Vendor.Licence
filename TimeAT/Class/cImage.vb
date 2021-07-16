Imports System.Data.SqlClient
Imports System.IO

Public Class cImage
    Public Shared Function getCompanyLogo() As Image
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String
        Dim dCmd As New SqlCommand
        Dim db As New db

        Dim ret As Image

        strSQL = "Select top 1 logo From Company"
        db.ExecuteCommand(Conn, dCmd, strSQL)
        Da.SelectCommand = dCmd
        Da.Fill(Ds, "data")


        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return Nothing
            End If

            Dim drw As DataRow = .Rows(0)

            If IsDBNull(drw("logo")) = False Then
                Dim arrayImage() As Byte = CType(drw("logo"), Byte())
                Dim ms As New MemoryStream(arrayImage)
                ret = Image.FromStream(ms)
                '.SizeMode = PictureBoxSizeMode.StretchImage
                ms.Close()

                Return ret
            Else
                Return Nothing
            End If
        End With
    End Function
End Class
