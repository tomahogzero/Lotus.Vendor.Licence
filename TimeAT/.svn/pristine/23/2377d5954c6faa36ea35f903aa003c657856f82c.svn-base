Imports System
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Text
Imports Microsoft.Win32

Module GenCode
    Public Function GenCode(ByVal TypeEnCode As TypeEn, ByVal StrValue As String, ByVal PubValue As String) As String
        Dim EnCodeValue As String = String.Empty
        Dim DeCodeValue As String = String.Empty
        Dim fChr As String = String.Empty
        Dim fPub As String = String.Empty
        Dim Result As String = String.Empty
        Dim intAsc As Integer
        Dim I As Integer
        If StrValue.Length > PubValue.Length Then
            For I = 0 To (StrValue.Length \ PubValue.Length)
                PubValue &= PubValue
            Next
        End If
        Select Case TypeEnCode
            Case TypeEn.EnCode
                For I = 1 To StrValue.Length
                    fChr = Mid(StrValue, I, 1)
                    fPub = Mid(PubValue, I, 1)
                    intAsc = Asc(fChr) + Asc(fPub)
                    intAsc = intAsc - 80 + (I Xor 9)
                    Result = Chr(intAsc)
                    EnCodeValue = EnCodeValue & Result
                Next
                Return EnCodeValue
            Case TypeEn.DeCode
                For I = 1 To StrValue.Length
                    fChr = Mid(StrValue, I, 1)
                    fPub = Mid(PubValue, I, 1)
                    intAsc = Asc(fChr)
                    intAsc = intAsc + 80 - (I Xor 9)
                    intAsc = intAsc - Asc(fPub)
                    Result = Chr(intAsc)
                    DeCodeValue = DeCodeValue & Result
                Next
                Return DeCodeValue
            Case Else
                Return ""
        End Select
    End Function

    Public Enum TypeEn
        EnCode = 0
        DeCode = 1
    End Enum

    Public Enum LicenceType
        Licence = 0
        Freeware = 1
        Lock = 2
    End Enum


    Public Function LicencePro() As LicenceType
        Dim Value As String
        Dim StringResult As String = String.Empty
        Dim CountResult As String = String.Empty
        Dim Counting As String = "01"
        Dim CountValue As String = String.Empty
        Dim Reg As RegistryKey
        Value = DevId

        ' Check Full Licence

        Reg = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(KeySet, False)
        If Reg Is Nothing Then
            StringResult = String.Empty
        Else
            StringResult = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(KeySet, False).GetValue(SubKey, "")
        End If

        If GenCode(TypeEn.EnCode, GenCode(TypeEn.EnCode, Value, PubKey), PubKey) <> StringResult Then ' ลงทะเบียนหรือยัง
            ' ยังไม่ได้ลง
            LicencePro = LicenceType.Freeware
            If StringResult = String.Empty Then
                Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(KeySet).SetValue(SubKey, GenCode(TypeEn.EnCode, "FREEWARE", PubKey))
                ' เพิ่มตั่วนับ
                Counting = Format(Now, "ssmm" & Counting & "hh")
                Reg = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(CountKeySet, False)
                If Reg Is Nothing Then
                    CountResult = String.Empty
                Else
                    CountResult = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(CountKeySet, False).GetValue(CountSubKey, "")
                End If
                If CountResult = String.Empty Then
                    Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(CountKeySet).SetValue(CountSubKey, GenCode(TypeEn.EnCode, Counting, PubKey))
                    TimeRemain = uMax - 1
                    Exit Function
                Else
                    CountValue = Format(Val(Mid(GenCode(TypeEn.DeCode, CountResult, PubKey), 5, 2)) + 1, "00")
                    TimeRemain = uMax - Val(CountValue)
                    If TimeRemain < 0 Then
                        LicencePro = LicenceType.Lock
                        Exit Function
                    End If
                    Counting = Format(Now, "ssmm" & CountValue & "hh")

                    Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(CountKeySet, True).DeleteValue(CountSubKey)
                    Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(CountKeySet, True).SetValue(CountSubKey, GenCode(TypeEn.EnCode, Counting, PubKey))
                    LicencePro = LicenceType.Freeware
                End If
            Else
                Reg = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(CountKeySet, False)
                If Reg Is Nothing Then
                    CountResult = String.Empty
                Else
                    CountResult = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(CountKeySet, False).GetValue(CountSubKey, "")
                End If
                If CountResult.Trim = String.Empty Then
                    LicencePro = LicenceType.Lock
                    Exit Function
                Else

                    CountValue = Format(Val(Mid(GenCode(TypeEn.DeCode, CountResult, PubKey), 5, 2)) + 1, "00")

                    TimeRemain = uMax - Val(CountValue)
                    If TimeRemain < 0 Then
                        LicencePro = LicenceType.Lock
                        Exit Function
                    End If
                    Counting = Format(Now, "ssmm" & CountValue & "hh")
                    Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(CountKeySet, True).DeleteValue(CountSubKey)
                    Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(CountKeySet, True).SetValue(CountSubKey, GenCode(TypeEn.EnCode, Counting, PubKey))
                    LicencePro = LicenceType.Freeware
                End If
            End If
        Else
            ' ลงทะเบียนแล้ว
            LicencePro = LicenceType.Licence
        End If
    End Function

    Public Function FullEncript(ByVal Data As String, ByVal TypeEnCode As TypeEn) As String
        Dim letter As String
        Dim full As String = ""
        If TypeEnCode = TypeEn.EnCode Then
            For i As Integer = 1 To Data.Length
                letter = Mid(Data.Trim, i, 1)
                full &= EncripLev1(letter, TypeEnCode)
            Next

            For i As Integer = full.Length + 1 To 45
                full &= "A"
            Next

        Else
            Dim inSt As Integer = InStr(Data, "A", CompareMethod.Text)
            Data = Left(Data, inSt - 1)
            For i As Integer = 1 To Data.Length Step +3
                letter = Mid(Data.Trim, i, 3)
                full &= EncripLev1(letter, TypeEnCode)
            Next
        End If
        Return full
    End Function

    Function EncripLev1(ByVal Data As String, ByVal TypeEnCode As TypeEn) As String
        If TypeEnCode = TypeEn.EnCode Then
            Return Format(Asc(Data.Trim), "000")
        Else
            Return Chr(Int(Data))
        End If
    End Function

    Function FinalEncript(ByVal TypeEnCode As TypeEn, ByVal Data As String, ByVal PubKey As String) As String
        If TypeEnCode = TypeEn.EnCode Then
            Return GenCode(TypeEn.EnCode, FullEncript(Data.Trim, TypeEn.EnCode), PubKey)
        Else
            Return FullEncript(GenCode(TypeEn.DeCode, Data.Trim, PubKey), TypeEn.DeCode)
        End If
    End Function

End Module
