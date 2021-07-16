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

End Class
