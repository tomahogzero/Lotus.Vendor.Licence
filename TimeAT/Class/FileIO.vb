Imports System.Text

Public Class FileIO
    Public Class FileIO

        Public Shared Sub WriteToFile(strToWrite As String)
            Dim stream As IO.StreamWriter = Nothing
            Try
                Dim fileName As String = "Log-" & Format(Now.Date, "yyyyMM")
                stream = New IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Log\" + fileName + ".txt", True, Encoding.UTF8)

                stream.Write(strToWrite + vbNewLine)
                stream.Flush()
                stream.Close()
            Catch ex As Exception

            End Try
        End Sub

        Public Shared Sub WriteToFile(fileName As String, strToWrite As String)
            Dim stream As IO.StreamWriter = Nothing
            Try
                stream = New IO.StreamWriter(fileName, True, Encoding.UTF8)
                stream.Write(strToWrite)
                stream.Flush()
                stream.Close()
            Catch ex As Exception

            End Try
        End Sub

    End Class

    Public Shared Function ReadToFile(FileName As String, ByRef err As String) As String
        err = ""
        Try
            Using sr As IO.StreamReader = New IO.StreamReader(FileName)
                Dim line As String
                line = sr.ReadLine()

                sr.Close()

                If line Is Nothing Then
                    Return ""
                Else
                    Return line
                End If
            End Using
        Catch ex As Exception
            err = ex.Message
            Return ""
        End Try
    End Function
End Class
