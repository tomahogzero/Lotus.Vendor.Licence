Imports System.Data
Imports System.Data.SqlClient
Imports System.Threading.Tasks
Imports TimeAttendance.utils

Public Class cDBCommand
    Public Class ImportData
        Public Async Function StudentProfile_Select() As Task(Of ResultModelType)
            Dim returnValue As Integer = Nothing

            Try
                Dim db As New DBManager
                Dim result As ResultModelType = New ResultModelType()
                Dim SprocName As String = "[sp_student_profile]"
                Dim Inputs As Dictionary(Of String, ParameterStructure) = Nothing
                'Dim Inputs As Dictionary(Of String, ParameterStructure) = New Dictionary(Of String, ParameterStructure)() From {
                '        {"@ID", New ParameterStructure("@ID", System.Data.SqlDbType.Int, 0)}
                '    }
                Dim Output As Dictionary(Of String, ParameterStructure) = New Dictionary(Of String, ParameterStructure)() From {
                        {"@RowCount", New ParameterStructure("@RowCount", System.Data.SqlDbType.Int)},
                        {"@MessageResult", New ParameterStructure("@MessageResult", System.Data.SqlDbType.NVarChar, Nothing, 200)}
                    }
                result.DataSetResult = Await db.ExecuteToDataSetTask(SprocName, Inputs, returnValue, Output)
                Dim rowCount As Integer = Convert.ToInt32(Output("@RowCount").dbValue)
                result.Code = returnValue
                result.RowCount = rowCount
                result.Message = Output("@MessageResult").dbValue.ToString()
                result.Flag = If(returnValue = 0 AndAlso 0 < rowCount, True, False)
                Return result

            Catch ex As Exception
                Return New ResultModelType() With {
                    .Code = -3,
                    .Message = "Student information error! " & Environment.NewLine + ex.Message
                }
            End Try
        End Function
        Public Async Function ClassName_Select() As Task(Of ResultModelType)
            Dim returnValue As Integer = Nothing

            Try
                Dim db As New DBManager
                Dim result As ResultModelType = New ResultModelType()
                Dim SprocName As String = "[sp_class_name]"
                Dim Inputs As Dictionary(Of String, ParameterStructure) = Nothing
                'Dim Inputs As Dictionary(Of String, ParameterStructure) = New Dictionary(Of String, ParameterStructure)() From {
                '        {"@ID", New ParameterStructure("@ID", System.Data.SqlDbType.Int, 0)}
                '    }
                Dim Output As Dictionary(Of String, ParameterStructure) = New Dictionary(Of String, ParameterStructure)() From {
                        {"@RowCount", New ParameterStructure("@RowCount", System.Data.SqlDbType.Int)},
                        {"@MessageResult", New ParameterStructure("@MessageResult", System.Data.SqlDbType.NVarChar, Nothing, 200)}
                    }
                result.DataSetResult = Await db.ExecuteToDataSetTask(SprocName, Inputs, returnValue, Output)
                Dim rowCount As Integer = Convert.ToInt32(Output("@RowCount").dbValue)
                result.Code = returnValue
                result.RowCount = rowCount
                result.Message = Output("@MessageResult").dbValue.ToString()
                result.Flag = If(returnValue = 0 AndAlso 0 < rowCount, True, False)
                Return result

            Catch ex As Exception
                Return New ResultModelType() With {
                    .Code = -3,
                    .Message = "Class name information error! " & Environment.NewLine + ex.Message
                }
            End Try
        End Function
        Public Async Function TeacherProfile_Select() As Task(Of ResultModelType)
            Dim returnValue As Integer = Nothing

            Try
                Dim db As New DBManager
                Dim result As ResultModelType = New ResultModelType()
                Dim SprocName As String = "[sp_teacher_profile]"
                Dim Inputs As Dictionary(Of String, ParameterStructure) = Nothing
                'Dim Inputs As Dictionary(Of String, ParameterStructure) = New Dictionary(Of String, ParameterStructure)() From {
                '        {"@ID", New ParameterStructure("@ID", System.Data.SqlDbType.Int, 0)}
                '    }
                Dim Output As Dictionary(Of String, ParameterStructure) = New Dictionary(Of String, ParameterStructure)() From {
                        {"@RowCount", New ParameterStructure("@RowCount", System.Data.SqlDbType.Int)},
                        {"@MessageResult", New ParameterStructure("@MessageResult", System.Data.SqlDbType.NVarChar, Nothing, 200)}
                    }
                result.DataSetResult = Await db.ExecuteToDataSetTask(SprocName, Inputs, returnValue, Output)
                Dim rowCount As Integer = Convert.ToInt32(Output("@RowCount").dbValue)
                result.Code = returnValue
                result.RowCount = rowCount
                result.Message = Output("@MessageResult").dbValue.ToString()
                result.Flag = If(returnValue = 0 AndAlso 0 < rowCount, True, False)
                Return result

            Catch ex As Exception
                Return New ResultModelType() With {
                    .Code = -3,
                    .Message = "Teacher profile information error! " & Environment.NewLine + ex.Message
                }
            End Try
        End Function

        Public Async Function Teacher_Class_Select() As Task(Of ResultModelType)
            Dim returnValue As Integer = Nothing

            Try
                Dim db As New DBManager
                Dim result As ResultModelType = New ResultModelType()
                Dim SprocName As String = "[sp_teacher_class]"
                Dim Inputs As Dictionary(Of String, ParameterStructure) = Nothing
                'Dim Inputs As Dictionary(Of String, ParameterStructure) = New Dictionary(Of String, ParameterStructure)() From {
                '        {"@ID", New ParameterStructure("@ID", System.Data.SqlDbType.Int, 0)}
                '    }
                Dim Output As Dictionary(Of String, ParameterStructure) = New Dictionary(Of String, ParameterStructure)() From {
                        {"@RowCount", New ParameterStructure("@RowCount", System.Data.SqlDbType.Int)},
                        {"@MessageResult", New ParameterStructure("@MessageResult", System.Data.SqlDbType.NVarChar, Nothing, 200)}
                    }
                result.DataSetResult = Await db.ExecuteToDataSetTask(SprocName, Inputs, returnValue, Output)
                Dim rowCount As Integer = Convert.ToInt32(Output("@RowCount").dbValue)
                result.Code = returnValue
                result.RowCount = rowCount
                result.Message = Output("@MessageResult").dbValue.ToString()
                result.Flag = If(returnValue = 0 AndAlso 0 < rowCount, True, False)
                Return result

            Catch ex As Exception
                Return New ResultModelType() With {
                    .Code = -3,
                    .Message = "Teacher class information error! " & Environment.NewLine + ex.Message
                }
            End Try
        End Function
    End Class

    Public Class SaveData
        Public Async Function StudentProfile_Save(styer As String,
                                                  std_id As String,
                                                  id As Integer,
                                                  prefix As String,
                                                  firstname As String,
                                                  lastname As String,
                                                  prefix_eng As String,
                                                  firstname_eng As String,
                                                  lastname_eng As String,
                                                  class_id As String,
                                                  subclass As String,
                                                  sex As String,
                                                  mobile As String,
                                                  email As String) As Task(Of ResultModelType)
            Dim returnValue As Integer = Nothing

            If std_id = "7999" Then
                Dim a As String = "0"
            End If
            Try
                Dim db As New DBManager
                Dim result As ResultModelType = New ResultModelType()
                Dim SprocName As String = "[sp_student_profile_insert]"
                'Dim Inputs As Dictionary(Of String, ParameterStructure) = Nothing
                Dim Inputs As Dictionary(Of String, ParameterStructure) = New Dictionary(Of String, ParameterStructure)() From {
                        {"@styear", New ParameterStructure("@styear", System.Data.SqlDbType.NVarChar, styer)},
                        {"@std_id", New ParameterStructure("@std_id", System.Data.SqlDbType.NVarChar, std_id)},
                        {"@id", New ParameterStructure("@id", System.Data.SqlDbType.Int, id)},
                        {"@prefix", New ParameterStructure("@prefix", System.Data.SqlDbType.NVarChar, prefix)},
                        {"@firstname", New ParameterStructure("@firstname", System.Data.SqlDbType.NVarChar, firstname)},
                        {"@lastname", New ParameterStructure("@lastname", System.Data.SqlDbType.NVarChar, lastname)},
                        {"@prefix_eng", New ParameterStructure("@prefix_eng", System.Data.SqlDbType.NVarChar, prefix_eng)},
                        {"@firstname_eng", New ParameterStructure("@firstname_eng", System.Data.SqlDbType.NVarChar, firstname_eng)},
                        {"@lastname_eng", New ParameterStructure("@lastname_eng", System.Data.SqlDbType.NVarChar, lastname_eng)},
                        {"@class_id", New ParameterStructure("@class_id", System.Data.SqlDbType.NVarChar, class_id)},
                        {"@subclass", New ParameterStructure("@subclass", System.Data.SqlDbType.NVarChar, subclass)},
                        {"@sex", New ParameterStructure("@sex", System.Data.SqlDbType.NVarChar, sex)},
                        {"@mobile", New ParameterStructure("@mobile", System.Data.SqlDbType.NVarChar, mobile)},
                        {"@email", New ParameterStructure("@email", System.Data.SqlDbType.NVarChar, email)}
                    }
                Dim Output As Dictionary(Of String, ParameterStructure) = New Dictionary(Of String, ParameterStructure)() From {
                        {"@RowCount", New ParameterStructure("@RowCount", System.Data.SqlDbType.Int)},
                        {"@MessageResult", New ParameterStructure("@MessageResult", System.Data.SqlDbType.NVarChar, Nothing, 200)}
                    }
                result.DataSetResult = Await db.ExecuteToDataSetTask(SprocName, Inputs, returnValue, Output)
                Dim rowCount As Integer = Convert.ToInt32(Output("@RowCount").dbValue)
                result.Code = returnValue
                result.RowCount = rowCount
                result.Message = Output("@MessageResult").dbValue.ToString()
                result.Flag = If(returnValue = 0 AndAlso 0 < rowCount, True, False)
                Return result

            Catch ex As Exception
                Return New ResultModelType() With {
                    .Code = -3,
                    .Message = "Student information error! " & Environment.NewLine + ex.Message
                }
            End Try
        End Function
    End Class
End Class
