Imports TimeAttendance.utils
Imports webAPI.Models

Public Class api
    Public Shared Function LogIn(ByRef err As String) As Boolean
        Dim dbMgr As New DBManager
        Try
            Dim _err As modelResultError = New modelResultError()
            Dim ret As webAPI.Models.model_Res_Login = webAPI.WebAPI.Login(dbMgr.APIUrl, dbMgr.APIUsername, dbMgr.APIPassword, _err)

            If ret IsNot Nothing Then
                cValGolbal.token = "Bearer " & ret.access_token
                cValGolbal.url_api_app = dbMgr.APIUrl
                cValGolbal.api_username = dbMgr.APIUsername
                cValGolbal.api_password = dbMgr.APIPassword
                Return True
            Else
                err = _err.message
                Return False
            End If
        Catch ex As Exception
            err = ex.Message
            Return False
        End Try
    End Function

    Public Shared Function GetDevice(ByRef err) As DataTable
        Try
            err = ""
            Dim ret As Object = webAPI.api.Device.GetList(cValGolbal.url_api_app, cValGolbal.token, err)

            If err <> "" Then
                Return Nothing
                Exit Function
            End If

            Dim res As List(Of modelDevice) = ret

            Dim data As New dt_Device(res)
            Return data.GetDataTable
        Catch ex As Exception
            err = ex.Message
            Return Nothing
        End Try
    End Function

    Public Shared Function GetCompany(ByRef err) As DataTable
        Try
            err = ""
            Dim ret As Object = webAPI.api.Company.GetList(cValGolbal.url_api_app, cValGolbal.token, err)

            If err <> "" Then
                Return Nothing
                Exit Function
            End If

            Dim res As List(Of modelCompany) = ret

            Dim data As New dt_Company(res)
            Return data.GetDataTable
        Catch ex As Exception
            err = ex.Message
            Return Nothing
        End Try
    End Function

    Public Shared Function GetCompanyGroup(ByRef err) As DataTable
        Try
            err = ""
            Dim ret As Object = webAPI.api.CompanyGroup.GetList(cValGolbal.url_api_app, cValGolbal.token, err)

            If err <> "" Then
                Return Nothing
                Exit Function
            End If

            Dim res As List(Of modelCompanyGroup) = ret

            Dim data As New dt_CompanyGroup(res)
            Return data.GetDataTable
        Catch ex As Exception
            err = ex.Message
            Return Nothing
        End Try
    End Function

    Public Shared Function UpdateDevice(deviceid As String, md As modelDeviceUpdate, ByRef err As String) As Boolean
        Try
            err = ""
            Dim ret As Boolean = webAPI.api.Device.Update(cValGolbal.url_api_app, cValGolbal.token, deviceid, md, err)

            Return ret
        Catch ex As Exception
            err = ex.Message
            Return False
        End Try
    End Function

    Public Shared Function UpdateCompanyGroupLicenceToken(companygroupid As String, md As modelCompanyGroupUpdateToken, ByRef err As String) As Boolean
        Try
            err = ""
            Dim ret As Boolean = webAPI.api.CompanyGroup.UpdateToken(cValGolbal.url_api_app, cValGolbal.token, companygroupid, md, err)

            Return ret
        Catch ex As Exception
            err = ex.Message
            Return False
        End Try
    End Function

    '#Region "Department"
    '    Public Shared Function GetDepartment(ByRef err) As DataTable
    '        Try
    '            err = ""
    '            Dim ret As Object = webAPI.department.GetList(cValGolbal.url_api_app, cValGolbal.token, err)

    '            If err <> "" Then
    '                Return Nothing
    '                Exit Function
    '            End If

    '            Dim res As webAPI.Models.model_department_res = ret

    '            Dim data As New dt_department(res.entities)
    '            Return data.GetDataTable
    '        Catch ex As Exception
    '            err = ex.Message
    '            Return Nothing
    '        End Try
    '    End Function

    '    Public Shared Function SaveDepartment(divid As String, name As String, code As String, number As String, ByRef err As String) As Boolean
    '        Try
    '            err = ""
    '            Dim ret As Object = webAPI.department.Save(cValGolbal.url_api_app, cValGolbal.token, divid, name, code, number, err)

    '            If ret Is Nothing Then
    '                If err <> "" Then
    '                    Return False
    '                End If
    '                Exit Function
    '            End If

    '            Dim data As webAPI.Models.model_department

    '            data = CType(ret, webAPI.Models.model_department)

    '            If data IsNot Nothing Then
    '                Return True
    '            Else
    '                Return False
    '            End If
    '        Catch ex As Exception
    '            err = ex.Message
    '            Return False
    '        End Try
    '    End Function
    '#End Region

    '#Region "Section"
    '    Public Shared Function GetSection(ByRef err) As DataTable
    '        Try
    '            err = ""
    '            Dim ret As Object = webAPI.section.GetList(cValGolbal.url_api_app, cValGolbal.token, err)

    '            If err <> "" Then
    '                Return Nothing
    '                Exit Function
    '            End If

    '            Dim res As webAPI.Models.model_section_res = ret

    '            Dim data As New dt_section(res.entities)
    '            Return data.GetDataTable
    '        Catch ex As Exception
    '            err = ex.Message
    '            Return Nothing
    '        End Try
    '    End Function

    '    Public Shared Function SaveSection(departmentId As String, name As String, code As String, number As String, ByRef err As String) As Boolean
    '        Try
    '            err = ""
    '            Dim ret As Object = webAPI.section.Save(cValGolbal.url_api_app, cValGolbal.token, departmentId, name, code, number, err)

    '            If ret Is Nothing Then
    '                If err <> "" Then
    '                    Return False
    '                End If
    '                Exit Function
    '            End If

    '            Dim data As webAPI.Models.model_section

    '            data = CType(ret, webAPI.Models.model_section)

    '            If data IsNot Nothing Then
    '                Return True
    '            Else
    '                Return False
    '            End If
    '        Catch ex As Exception
    '            err = ex.Message
    '            Return False
    '        End Try
    '    End Function
    '#End Region

    '#Region "Class"
    '    Public Shared Function GetClass(ByRef err) As DataTable
    '        Try
    '            err = ""
    '            Dim ret As Object = webAPI.classs.GetList(cValGolbal.url_api_app, cValGolbal.token, err)

    '            If err <> "" Then
    '                Return Nothing
    '                Exit Function
    '            End If

    '            Dim res As webAPI.Models.model_class_res = ret

    '            Dim data As New dt_class(res.entities)
    '            Return data.GetDataTable
    '        Catch ex As Exception
    '            err = ex.Message
    '            Return Nothing
    '        End Try
    '    End Function

    '    Public Shared Function SaveClass(sectionId As String, name As String, code As String, number As String, ByRef err As String) As Boolean
    '        Try
    '            err = ""
    '            Dim ret As Object = webAPI.classs.Save(cValGolbal.url_api_app, cValGolbal.token, sectionId, name, code, number, err)

    '            If ret Is Nothing Then
    '                If err <> "" Then
    '                    Return False
    '                End If
    '                Exit Function
    '            End If

    '            Dim data As webAPI.Models.model_classes

    '            data = CType(ret, webAPI.Models.model_classes)

    '            If data IsNot Nothing Then
    '                Return True
    '            Else
    '                Return False
    '            End If
    '        Catch ex As Exception
    '            err = ex.Message
    '            Return False
    '        End Try
    '    End Function
    '#End Region

    '#Region "SubClass"
    '    Public Shared Function GetSubClass(ByRef err) As DataTable
    '        Try
    '            err = ""
    '            Dim ret As Object = webAPI.subclass.GetList(cValGolbal.url_api_app, cValGolbal.token, err)

    '            If err <> "" Then
    '                Return Nothing
    '                Exit Function
    '            End If

    '            Dim res As webAPI.Models.model_subclass_res = ret

    '            Dim data As New dt_subclass(res.entities)

    '            Return data.GetDataTable
    '        Catch ex As Exception
    '            err = ex.Message
    '            Return Nothing
    '        End Try
    '    End Function

    '    Public Shared Function SaveSubClass(classId As String, name As String, code As String, number As String, ByRef err As String) As Boolean
    '        Try
    '            err = ""
    '            Dim ret As Object = webAPI.subclass.Save(cValGolbal.url_api_app, cValGolbal.token, classId, name, code, number, err)

    '            If ret Is Nothing Then
    '                If err <> "" Then
    '                    Return False
    '                End If
    '                Exit Function
    '            End If

    '            Dim data As webAPI.Models.model_subclass

    '            data = CType(ret, webAPI.Models.model_subclass)

    '            If data IsNot Nothing Then
    '                Return True
    '            Else
    '                Return False
    '            End If
    '        Catch ex As Exception
    '            err = ex.Message
    '            Return False
    '        End Try
    '    End Function
    '#End Region

    '#Region "Product"
    '    Public Shared Function GetProduct(ByRef err) As DataTable
    '        Try
    '            err = ""
    '            Dim data As New dt_product

    '            For i As Integer = 1 To 100
    '                Dim ret As Object = webAPI.product.GetList(cValGolbal.url_api_app, cValGolbal.token, i, err)
    '                If err <> "" Then
    '                    Return Nothing
    '                    Exit Function
    '                End If

    '                Dim res As webAPI.Models.model_product_res = ret

    '                If res.entities.Count > 0 Then
    '                    data.InputData(res.entities)
    '                Else
    '                    Exit For
    '                End If
    '            Next

    '            Return data.GetDataTable
    '        Catch ex As Exception
    '            err = ex.Message
    '            Return Nothing
    '        End Try
    '    End Function

    '    Public Shared Function SaveProduct(subClassId As String, upc As String, sku As String, itemNo As String, styleNo As String,
    '                        description As String, brand As String, piecesPerCarton As Double, unitOfMeasure As String, colorCode As String, sizeType As String, ByRef err As String) As Boolean

    '        Try
    '            err = ""
    '            Dim ret As Object = webAPI.product.Save(cValGolbal.url_api_app, cValGolbal.token,
    '                                                subClassId, upc, sku, itemNo, styleNo,
    '                                                description, brand, piecesPerCarton, unitOfMeasure, colorCode, sizeType,
    '                                                err)

    '            If ret Is Nothing Then
    '                If err <> "" Then
    '                    Return False
    '                End If
    '                Exit Function
    '            End If

    '            Dim data As webAPI.Models.model_product

    '            data = CType(ret, webAPI.Models.model_product)

    '            If data IsNot Nothing Then
    '                Return True
    '            Else
    '                Return False
    '            End If
    '        Catch ex As Exception
    '            err = ex.Message
    '            Return False
    '        End Try
    '    End Function
    '#End Region
End Class
