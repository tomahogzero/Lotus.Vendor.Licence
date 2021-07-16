Module ThaiBath

    Public Function Thainumber(ByVal TmpNumber As Double) As String
        Dim NumString As String
        Dim TmpInteger As String
        Dim TmpDecimal As String

        NumString = Trim(Str(TmpNumber))                  'แปลงตัวเลขให้เป็น String
        TmpInteger = Trim(Str(Fix(TmpNumber)))        'เอาเฉพาะจำนวนเต็มแล้วแปลงเป็น String
        If Len(NumString) > Len(TmpInteger) Then       'เช็คว่ามีทศนิยมหรือไม่
            If Len(NumString) - InStr(1, NumString, ".") = 1 Then  'ถ้ามีทศนิยมตำแหน่งเดียวเพิ่มเป็น 2 ตำแหน่ง
                NumString = NumString + "0"                                    'ด้วยการเติม 0
            End If
            'เอาเฉพาะทศนิยมแล้วแปลงให้เป็น String
            TmpDecimal = Mid(NumString, InStr(1, NumString, ".") + 1, Len(NumString))
            'แปลงตัวเลขเป็นข้อความทั้งจำนวนเต็มและทศนิยม
            Return StringNumber(TmpInteger) & "บาท" & StringNumber(TmpDecimal) & "สตางค์"
        Else
            'แปลงตัวเลขเป็นข้อความทั้งจำนวนเต็ม
            Return StringNumber(TmpInteger) & "บาทถ้วน"
        End If
    End Function

    Private Function StringNumber(ByVal GetValue As String) As String
        Dim ThaiString1 As String = ""
        Dim ThaiString2 As String = ""
        Dim TmpValue, Num_, Round_ As String
        Dim ArrColumn, ArrStrNumber As Object
        Dim ArrNumber, StrNumber, StrColumn As String
        Dim i, j As Integer
        ArrColumn = New String() {"", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน"}
        'ArrColumn = New Array("", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน")
        ArrStrNumber = New String() {"หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า", ""}
        ArrNumber = "1234567890"

        Round_ = IIf(Len(GetValue) Mod 6 = 0, Fix(Len(GetValue) / 6), Fix(Len(GetValue) / 6) + 1)
        For j = 1 To Round_
            ThaiString1 = ""
            TmpValue = Mid(Microsoft.VisualBasic.Right(GetValue, 6 * j), 1, Len(Microsoft.VisualBasic.Right(GetValue, 6 * j)) - ((j - 1) * 6))
            For i = 1 To Len(TmpValue)
                Num_ = Mid(Microsoft.VisualBasic.Right(TmpValue, i), 1, 1)   'ตัดเอาตัวเลข  1 ตัว
                'แปลงตัวเลขเป็นตัวอักษร
                StrNumber = ArrStrNumber(InStr(1, ArrNumber, Num_) - 1)
                'เช็คว่าค่าที่ได้เป็น 0 หรือไม่
                If Num_ <> "0" Then
                    'แปลงหลักเป็นตัวอักษร
                    StrColumn = ArrColumn(i - 1)
                    If Len(TmpValue) > 1 Then             'ตัวเลขมากว่า 1 หลัก
                        If i = 1 Then                                     'ข้อมูลหลักหน่วย
                            If Num_ = "1" Then StrNumber = "เอ็ด" ' แปลงเลข 1 เป็น เอ็ด
                        Else
                            If i = 2 Then                              'ข้อมูลหลักสิบ
                                If Num_ = "1" Then StrNumber = "" ' แปลงเลข 1 เป็น สิบ
                                If Num_ = "2" Then StrNumber = "ยี่" ' แปลงเลข 2 เป็น ยี่
                            End If
                        End If
                    End If
                    ThaiString1 = StrNumber & StrColumn & ThaiString1
                End If
            Next i
            Return ThaiString1 & IIf(j > 1, "ล้าน", "") & ThaiString2
        Next j
        Return ThaiString2
    End Function

End Module
