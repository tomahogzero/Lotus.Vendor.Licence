Module ThaiBath

    Public Function Thainumber(ByVal TmpNumber As Double) As String
        Dim NumString As String
        Dim TmpInteger As String
        Dim TmpDecimal As String

        NumString = Trim(Str(TmpNumber))                  '�ŧ����Ţ����� String
        TmpInteger = Trim(Str(Fix(TmpNumber)))        '���੾�Шӹǹ��������ŧ�� String
        If Len(NumString) > Len(TmpInteger) Then       '������շȹ����������
            If Len(NumString) - InStr(1, NumString, ".") = 1 Then  '����շȹ������˹����������� 2 ���˹�
                NumString = NumString + "0"                                    '���¡����� 0
            End If
            '���੾�зȹ��������ŧ����� String
            TmpDecimal = Mid(NumString, InStr(1, NumString, ".") + 1, Len(NumString))
            '�ŧ����Ţ�繢�ͤ�����駨ӹǹ�����зȹ���
            Return StringNumber(TmpInteger) & "�ҷ" & StringNumber(TmpDecimal) & "ʵҧ��"
        Else
            '�ŧ����Ţ�繢�ͤ�����駨ӹǹ���
            Return StringNumber(TmpInteger) & "�ҷ��ǹ"
        End If
    End Function

    Private Function StringNumber(ByVal GetValue As String) As String
        Dim ThaiString1 As String = ""
        Dim ThaiString2 As String = ""
        Dim TmpValue, Num_, Round_ As String
        Dim ArrColumn, ArrStrNumber As Object
        Dim ArrNumber, StrNumber, StrColumn As String
        Dim i, j As Integer
        ArrColumn = New String() {"", "�Ժ", "����", "�ѹ", "����", "�ʹ"}
        'ArrColumn = New Array("", "�Ժ", "����", "�ѹ", "����", "�ʹ")
        ArrStrNumber = New String() {"˹��", "�ͧ", "���", "���", "���", "ˡ", "��", "Ỵ", "���", ""}
        ArrNumber = "1234567890"

        Round_ = IIf(Len(GetValue) Mod 6 = 0, Fix(Len(GetValue) / 6), Fix(Len(GetValue) / 6) + 1)
        For j = 1 To Round_
            ThaiString1 = ""
            TmpValue = Mid(Microsoft.VisualBasic.Right(GetValue, 6 * j), 1, Len(Microsoft.VisualBasic.Right(GetValue, 6 * j)) - ((j - 1) * 6))
            For i = 1 To Len(TmpValue)
                Num_ = Mid(Microsoft.VisualBasic.Right(TmpValue, i), 1, 1)   '�Ѵ��ҵ���Ţ  1 ���
                '�ŧ����Ţ�繵���ѡ��
                StrNumber = ArrStrNumber(InStr(1, ArrNumber, Num_) - 1)
                '����Ҥ�ҷ������ 0 �������
                If Num_ <> "0" Then
                    '�ŧ��ѡ�繵���ѡ��
                    StrColumn = ArrColumn(i - 1)
                    If Len(TmpValue) > 1 Then             '����Ţ�ҡ��� 1 ��ѡ
                        If i = 1 Then                                     '��������ѡ˹���
                            If Num_ = "1" Then StrNumber = "���" ' �ŧ�Ţ 1 �� ���
                        Else
                            If i = 2 Then                              '��������ѡ�Ժ
                                If Num_ = "1" Then StrNumber = "" ' �ŧ�Ţ 1 �� �Ժ
                                If Num_ = "2" Then StrNumber = "���" ' �ŧ�Ţ 2 �� ���
                            End If
                        End If
                    End If
                    ThaiString1 = StrNumber & StrColumn & ThaiString1
                End If
            Next i
            Return ThaiString1 & IIf(j > 1, "��ҹ", "") & ThaiString2
        Next j
        Return ThaiString2
    End Function

End Module
