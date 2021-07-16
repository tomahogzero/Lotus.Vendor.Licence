Imports System.ComponentModel
Imports TimeAttendance.utils

Public Class AppConstantsLicence
    Public Const pPhrase As String = "$@nch@1"
    Public Const salt As String = "$@ltBy$@n"
    Public Const hash As String = "SHA1"
    Public Const iVector As String = "@1b2C3d4E5f6G7h8"
    Public Const iKey As Integer = 256
    Public Const pwdPhrase As String = "P@$$w0rD"
    Public Const pwdSalt As String = "$@lTeDByS@N"
    Public Const pwdIVector As String = "z1Y2x3W4v5U6t7s8"

    ' -- Username
    Public Const usrChar As String = "abcdefghijklmnopqrstuwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890_"

    '<TypeConverter(GetType(LocalizedEnumConverter))>
    'Public Enum SearchOperText
    '    '[Equals] = 0     '-- 0
    '    Equals     '-- 0
    '    NotEquals  '-- 1
    '    Contains   '-- 2
    '    StartWith  '-- 3
    '    EndWith    '-- 4
    'End Enum

    '<TypeConverter(GetType(LocalizedEnumConverter))> _
    'Public Enum Lang
    '    TH
    '    EN
    'End Enum

    '<TypeConverter(GetType(LocalizedEnumConverter))> _
    'Public Enum UType
    '    U
    '    T
    'End Enum

End Class
