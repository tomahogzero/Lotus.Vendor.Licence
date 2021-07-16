Imports System.IO
Imports System.IO.FileStream
Imports System.Xml
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports TimeAttendance.utils

Public Class frmGetText

    Private Sub btnGetText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetText.Click
        btnGetText.Enabled = False
        Dim FileName As String
        Dim FullFileName As String
        On Error GoTo Err
        FullFileName = txtFileName.Text.Trim
        If FullFileName = "" Then Exit Sub
        If Dir(FullFileName).Trim = "" Then
            'MsgBox("��辺�����͹���س����͡����", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmGetTextRS", Me.Text, "FileName_NotFound", MessageBoxIcon.Information)
            Exit Sub
        End If


        lblStatus.Text = "���ѧ ����Ң����� ��س����ѡ���� ....."
        lblStatus.ForeColor = Color.DarkBlue
        Application.DoEvents()

        Select Case cboGetText.SelectedIndex + 1
            Case 1
                Call GetType1(FullFileName)
            Case 2
                Call GetType2(FullFileName)
            Case 3
                Call GetType3(FullFileName)
            Case 4
                Call GetType4(FullFileName)
            Case 5
                Call GetType5(FullFileName)
            Case 6
                Call GetType6(FullFileName)
            Case 7
                Call GetType7(FullFileName)
            Case 8
                Call GetType8(FullFileName)
            Case 9
                Call GetType9(FullFileName)
            Case 10
                Call GetType10(FullFileName)
            Case 11
                Call GetType11(FullFileName)
            Case 12
                Call GetType12(FullFileName)
            Case 13
                Call GetType13_CKC(FullFileName)
            Case 0

        End Select


        'MessageBox.Show("��������º��������", )
        If chkAutoSave.Checked = True Then
            lblStatus.Text = "���ѧ�ѹ�ա������ ��س����ѡ���� .............."
            lblStatus.ForeColor = Color.DarkGreen
            Application.DoEvents()
            Call btnSave_Click(Me, System.EventArgs.Empty)
            lblStatus.ForeColor = Color.Green
            lblStatus.Text = "�ѹ�֡���������º��������"

            Application.DoEvents()
        Else
            'MsgBox("����� ���º��������", MsgBoxStyle.Information, Me.Text)
            MsgManager.ShowDialog(Me, "frmGetTextRS", Me.Text, "Import_Success", MessageBoxIcon.Information)
            lblStatus.Text = "����Ң��������º��������   ��سҺѹ�֡�����Ŵ���"
            lblStatus.ForeColor = Color.Green
            Application.DoEvents()
        End If
        lblStatus.Text = "-"
        lblStatus.ForeColor = Color.Black
        btnGetText.Enabled = True
        Exit Sub
Err:
        btnGetText.Enabled = True
        MessageBox.Show(Err.Number & " " & Err.Description)
    End Sub

    Private Sub GetType1(ByVal FullFileName As String)
        ' Format 20364            201002221348F1001

        Dim List As ListViewItem
        Dim arrData() As String

        Dim Sr As New System.IO.StreamReader(FullFileName)
        Dim line As String

        Dim Code As String = ""
        Dim strDateTime As String = ""

        Dim Barcode As String = ""
        Dim Col As Integer
        Dim row As Integer = 0
        Dim BarCodeErr As String = ""
        Dim CodeErr As String = ""
        Dim DateTimeError As String = ""
        Dim StatusError As String

        ' Read and display the lines from the file until the end 
        ' of the file is reached.

        lstListFile.Items.Clear()
        lstListFileErr.Items.Clear()
        lstListFile.BeginUpdate()

        Dim intSplace As Integer = 0

        Do While Sr.Peek() >= 0
            ' Format 0080            20100823070801001
            line = Sr.ReadLine()
            Col = 0
            intSplace = InStr(line, " ", CompareMethod.Text)
            'Code = Mid(line, 1, 9)
            Barcode = LeftText(line, intSplace - 1)

            Code = GetEmpCode(Barcode).Trim

            line = RightText(line, line.Length - intSplace).Trim

            strDateTime = LeftText(line, 12)

            strDateTime = Mid(strDateTime.Trim, 1, 4) & "/" & Mid(strDateTime.Trim, 5, 2) & "/" & Mid(strDateTime.Trim, 7, 2) & " " & _
                        Mid(strDateTime.Trim, 9, 2) & ":" & Mid(strDateTime.Trim, 11, 2)


            ' Format 000 1 20100816 0704 F01 00001

            'line = Sr.ReadLine()
            'line = Mid(line, 7, line.Length - 6)
            'Col = 0
            'intSplace = InStr(line, " ", CompareMethod.Text)

            'strDateTime = Replace(LeftText(line, 13), " ", "")

            'strDateTime = Mid(strDateTime.Trim, 1, 4) & "/" & Mid(strDateTime.Trim, 5, 2) & "/" & Mid(strDateTime.Trim, 7, 2) & " " & _
            '            Mid(strDateTime.Trim, 9, 2) & ":" & Mid(strDateTime.Trim, 11, 2)

            'line = Mid(line, 14, line.Length - 13).Trim


            'Barcode = Mid(line, 5, line.Length - 4)

            'Code = GetEmpCode(Barcode).Trim

            row += 1
            lblStatus.Text = " ����Ң����� ��� " & row
            Application.DoEvents()

            BarCodeErr = ""
            CodeErr = ""
            DateTimeError = ""
            StatusError = ""
            If Code.Trim = "" Then
                CodeErr = "{��辺���ʾ��.}"
                StatusError &= CodeErr
            ElseIf Code.Length > 30 Then
                CodeErr = "{�ҡ���� 30 ����ѡ��}"
                StatusError &= " " & CodeErr
            End If

            If Barcode.Trim = "" Then
                BarCodeErr = "{Barcode ��ҧ}"
                StatusError &= " " & BarCodeErr
            End If

            If IsDate(strDateTime.Trim) = False Then
                DateTimeError = "{�����������ѹ���}"
                StatusError &= " " & DateTimeError
            End If

            If StatusError <> "" Then
                arrData = New String() {row, _
                                        StatusError.Trim, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFileErr.Items.Add(List)
            Else
                arrData = New String() {lstListFile.Items.Count + 1, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFile.Items.Add(List)
            End If
        Loop
        lstListFile.EndUpdate()
        Sr.Close()
    End Sub

    Private Sub GetType2(ByVal FullFileName As String)
        ' Format 31201008310806010000000000200000
        ' Format 31 20100831 0806 01 00000000002 00000
        Dim List As ListViewItem
        Dim arrData() As String

        Dim Sr As New System.IO.StreamReader(FullFileName)
        Dim line As String

        Dim Code As String = ""
        Dim strDateTime As String = ""

        Dim Barcode As String = ""
        Dim Col As Integer

        Dim row As Integer = 0
        Dim BarCodeErr As String = ""
        Dim CodeErr As String = ""
        Dim DateTimeError As String = ""
        Dim StatusError As String

        ' Read and display the lines from the file until the end 
        ' of the file is reached.

        lstListFile.Items.Clear()
        lstListFileErr.Items.Clear()
        lstListFile.BeginUpdate()

        Dim intSplace As Integer = 0

        Do While Sr.Peek() >= 0
            ' Format 0080            20100823070801001
            line = Sr.ReadLine()
            Col = 0
            'Code = Mid(line, 1, 9)
            Barcode = Mid(line, 25, 4)

            Code = GetEmpCode(Barcode).Trim

            strDateTime = Mid(line, 3, 12)

            strDateTime = Mid(strDateTime.Trim, 1, 4) & "/" & Mid(strDateTime.Trim, 5, 2) & "/" & Mid(strDateTime.Trim, 7, 2) & " " & _
                        Mid(strDateTime.Trim, 9, 2) & ":" & Mid(strDateTime.Trim, 11, 2)

            row += 1
            lblStatus.Text = " ����Ң����� ��� " & row
            Application.DoEvents()

            BarCodeErr = ""
            CodeErr = ""
            DateTimeError = ""
            StatusError = ""
            If Code.Trim = "" Then
                CodeErr = "{��辺���ʾ��.}"
                StatusError &= CodeErr
            ElseIf Code.Length > 30 Then
                CodeErr = "{�ҡ���� 30 ����ѡ��}"
                StatusError &= " " & CodeErr
            End If

            If Barcode.Trim = "" Then
                BarCodeErr = "{Barcode ��ҧ}"
                StatusError &= " " & BarCodeErr
            End If

            If IsDate(strDateTime.Trim) = False Then
                DateTimeError = "{�����������ѹ���}"
                StatusError &= " " & DateTimeError
            End If

            If StatusError <> "" Then
                arrData = New String() {row, _
                                        StatusError.Trim, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFileErr.Items.Add(List)
            Else
                arrData = New String() {lstListFile.Items.Count + 1, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFile.Items.Add(List)
            End If
        Loop
        lstListFile.EndUpdate()
        Sr.Close()
    End Sub

    Private Sub GetType3(ByVal FullFileName As String)
        ' Format K01 101104 0917 010 100042
        ' Format K011011040917010100042
        Dim List As ListViewItem
        Dim arrData() As String

        Dim Sr As New System.IO.StreamReader(FullFileName)
        Dim line As String

        Dim Code As String = ""
        Dim strDateTime As String = ""

        Dim Barcode As String = ""
        Dim Col As Integer

        Dim row As Integer = 0
        Dim BarCodeErr As String = ""
        Dim CodeErr As String = ""
        Dim DateTimeError As String = ""
        Dim StatusError As String

        ' Read and display the lines from the file until the end 
        ' of the file is reached.

        lstListFile.Items.Clear()
        lstListFileErr.Items.Clear()
        lstListFile.BeginUpdate()

        Dim intSplace As Integer = 0

        Do While Sr.Peek() >= 0
            ' Format 0080            20100823070801001
            line = Sr.ReadLine()
            Col = 0
            'Code = Mid(line, 1, 9)
            Barcode = Mid(line, 17, 6)

            Code = GetEmpCode(Barcode).Trim

            strDateTime = Mid(line, 4, 10)
            '101104 0917
            strDateTime = "20" & Mid(strDateTime.Trim, 1, 2) & "/" & Mid(strDateTime.Trim, 3, 2) & "/" & Mid(strDateTime.Trim, 5, 2) & " " & _
                        Mid(strDateTime.Trim, 7, 2) & ":" & Mid(strDateTime.Trim, 9, 2)

            row += 1
            lblStatus.Text = " ����Ң����� ��� " & row
            Application.DoEvents()

            BarCodeErr = ""
            CodeErr = ""
            DateTimeError = ""
            StatusError = ""
            If Code.Trim = "" Then
                CodeErr = "{��辺���ʾ��.}"
                StatusError &= CodeErr
            ElseIf Code.Length > 30 Then
                CodeErr = "{�ҡ���� 30 ����ѡ��}"
                StatusError &= " " & CodeErr
            End If

            If Barcode.Trim = "" Then
                BarCodeErr = "{Barcode ��ҧ}"
                StatusError &= " " & BarCodeErr
            End If

            If IsDate(strDateTime.Trim) = False Then
                DateTimeError = "{�����������ѹ���}"
                StatusError &= " " & DateTimeError
            End If

            If StatusError <> "" Then
                arrData = New String() {row, _
                                        StatusError.Trim, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFileErr.Items.Add(List)
            Else
                arrData = New String() {lstListFile.Items.Count + 1, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFile.Items.Add(List)
            End If
        Loop
        lstListFile.EndUpdate()
        Sr.Close()
    End Sub

    Private Sub GetType4(ByVal FullFileName As String)
        ' Format  OUR COMPANY 10014          10014 21/04/2011 07:28:00  C/In     102
        ' Format                            ���ʺѵ�              �ѹ�������
        Dim List As ListViewItem
        Dim arrData() As String

        Dim Sr As New System.IO.StreamReader(FullFileName)
        Dim line As String

        Dim Code As String = ""
        Dim strDateTime As String = ""

        Dim Barcode As String = ""
        Dim Col As Integer

        Dim row As Integer = 0
        Dim BarCodeErr As String = ""
        Dim CodeErr As String = ""
        Dim DateTimeError As String = ""
        Dim StatusError As String

        ' Read and display the lines from the file until the end 
        ' of the file is reached.

        lstListFile.Items.Clear()
        lstListFileErr.Items.Clear()
        lstListFile.BeginUpdate()

        Dim intSplace As Integer = 0

        Do While Sr.Peek() >= 0
            ' Format 0080            20100823070801001
            line = Sr.ReadLine()
            Col = 0
            'Code = Mid(line, 1, 9)
            line = Mid(line.Trim, 28, 25)
            Barcode = Mid(line, 1, 5)

            Code = GetEmpCode(Barcode).Trim

            strDateTime = Mid(line, 7, 16)
            '21/04/2011 07:28:00
            strDateTime = ConvertDate(Mid(strDateTime, 1, 10)) & " " & Mid(strDateTime, 12, 5)
            ' "20" & Mid(strDateTime.Trim, 1, 2) & "/" & Mid(strDateTime.Trim, 3, 2) & "/" & Mid(strDateTime.Trim, 5, 2) & " " & _
            '                        Mid(strDateTime.Trim, 7, 2) & ":" & Mid(strDateTime.Trim, 9, 2)

            row += 1
            lblStatus.Text = " ����Ң����� ��� " & row
            Application.DoEvents()

            BarCodeErr = ""
            CodeErr = ""
            DateTimeError = ""
            StatusError = ""
            If Code.Trim = "" Then
                CodeErr = "{��辺���ʾ��.}"
                StatusError &= CodeErr
            ElseIf Code.Length > 30 Then
                CodeErr = "{�ҡ���� 30 ����ѡ��}"
                StatusError &= " " & CodeErr
            End If

            If Barcode.Trim = "" Then
                BarCodeErr = "{Barcode ��ҧ}"
                StatusError &= " " & BarCodeErr
            End If

            If IsDate(strDateTime.Trim) = False Then
                DateTimeError = "{�����������ѹ���}"
                StatusError &= " " & DateTimeError
            End If

            If StatusError <> "" Then
                arrData = New String() {row, _
                                        StatusError.Trim, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFileErr.Items.Add(List)
            Else
                arrData = New String() {lstListFile.Items.Count + 1, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFile.Items.Add(List)
            End If
        Loop
        lstListFile.EndUpdate()
        Sr.Close()
    End Sub

    Private Sub GetType5(ByVal FullFileName As String)
        'No.	MchNo	EnrNo		Verify	InOut	DateTime
        '00001	01	    02453469	35	    0	    2011/08/10 11:56:05
        Dim List As ListViewItem
        Dim arrData() As String

        Dim Sr As New System.IO.StreamReader(FullFileName)
        Dim line As String

        Dim Code As String = ""
        Dim strDateTime As String = ""

        Dim Barcode As String = ""
        Dim Col As Integer

        Dim row As Integer = 0
        Dim BarCodeErr As String = ""
        Dim CodeErr As String = ""
        Dim DateTimeError As String = ""
        Dim StatusError As String

        ' Read and display the lines from the file until the end 
        ' of the file is reached.

        lstListFile.Items.Clear()
        lstListFileErr.Items.Clear()

        lstListFile.BeginUpdate()

        Dim intSplace As Integer = 0

        Do While Sr.Peek() >= 0
            ' Format 0080            20100823070801001
            line = Sr.ReadLine()
            Col = 0
            'Code = Mid(line, 1, 9)
            'line = Mid(line.Trim, 28, 25)
            Barcode = Mid(line, 10, 8)

            Code = GetEmpCode(Barcode).Trim

            strDateTime = LeftText(RightText(line, 19), 16)
            '21/04/2011 07:28:00
            'strDateTime = ConvertDate(Mid(strDateTime, 1, 10)) & " " & Mid(strDateTime, 12, 5)
            ' "20" & Mid(strDateTime.Trim, 1, 2) & "/" & Mid(strDateTime.Trim, 3, 2) & "/" & Mid(strDateTime.Trim, 5, 2) & " " & _
            '                        Mid(strDateTime.Trim, 7, 2) & ":" & Mid(strDateTime.Trim, 9, 2)

            row += 1
            lblStatus.Text = " ����Ң����� ��� " & row
            Application.DoEvents()

            BarCodeErr = ""
            CodeErr = ""
            DateTimeError = ""
            StatusError = ""
            If Code.Trim = "" Then
                CodeErr = "{��辺���ʾ��.}"
                StatusError &= CodeErr
            ElseIf Code.Length > 30 Then
                CodeErr = "{�ҡ���� 30 ����ѡ��}"
                StatusError &= " " & CodeErr
            End If

            If Barcode.Trim = "" Then
                BarCodeErr = "{Barcode ��ҧ}"
                StatusError &= " " & BarCodeErr
            End If

            If IsDate(strDateTime.Trim) = False Then
                DateTimeError = "{�����������ѹ���}"
                StatusError &= " " & DateTimeError
            End If

            If StatusError <> "" Then
                arrData = New String() {row, _
                                        StatusError.Trim, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFileErr.Items.Add(List)
            Else
                arrData = New String() {lstListFile.Items.Count + 1, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFile.Items.Add(List)
            End If
        Loop
        lstListFile.EndUpdate()
        Sr.Close()
    End Sub

    Private Sub GetType6(ByVal FullFileName As String)
        'No.	MchNo	EnrNo		Verify	InOut	DateTime
        '00001	01	    02453469	35	    0	    2011/08/10 11:56:05
        '01354074         T10831111147900
        Dim List As ListViewItem
        Dim arrData() As String

        Dim Sr As New System.IO.StreamReader(FullFileName)
        Dim line As String

        Dim Code As String = ""
        Dim strDateTime As String = ""

        Dim Barcode As String = ""
        Dim Col As Integer

        Dim row As Integer = 0
        lblStatus.Text = " ����Ң����� ��� " & row
        Application.DoEvents()

        Dim BarCodeErr As String = ""
        Dim CodeErr As String = ""
        Dim DateTimeError As String = ""
        Dim StatusError As String

        ' Read and display the lines from the file until the end 
        ' of the file is reached.

        lstListFile.Items.Clear()
        lstListFileErr.Items.Clear()

        lstListFile.BeginUpdate()

        Dim intSplace As Integer = 0

        Do While Sr.Peek() >= 0
            ' Format 0080            20100823070801001
            '12345678901234567890123456789012
            '01354074         T10831111147900
            line = Sr.ReadLine()
            Col = 0
            'Code = Mid(line, 1, 9)
            'line = Mid(line.Trim, 28, 25)
            Barcode = Trim(Mid(line, 3, 10))

            Code = GetEmpCode(Barcode).Trim

            strDateTime = Mid(line, 20, 10)
            '21/04/2011 07:28:00
            strDateTime = "20" & Mid(strDateTime.Trim, 5, 2) & "/" & Mid(strDateTime.Trim, 1, 2) & "/" & Mid(strDateTime.Trim, 3, 2) & " " & _
                                    Mid(strDateTime.Trim, 7, 2) & ":" & Mid(strDateTime.Trim, 9, 2)

            'strDateTime = ConvertDate(Mid(strDateTime, 1, 10)) & " " & Mid(strDateTime, 12, 5)
            ' "20" & Mid(strDateTime.Trim, 1, 2) & "/" & Mid(strDateTime.Trim, 3, 2) & "/" & Mid(strDateTime.Trim, 5, 2) & " " & _
            '                        Mid(strDateTime.Trim, 7, 2) & ":" & Mid(strDateTime.Trim, 9, 2)

            row += 1
            lblStatus.Text = " ����Ң����� ��� " & row
            Application.DoEvents()

            BarCodeErr = ""
            CodeErr = ""
            DateTimeError = ""
            StatusError = ""
            If Code.Trim = "" Then
                CodeErr = "{��辺���ʾ��.}"
                StatusError &= CodeErr
            ElseIf Code.Length > 30 Then
                CodeErr = "{�ҡ���� 30 ����ѡ��}"
                StatusError &= " " & CodeErr
            End If

            If Barcode.Trim = "" Then
                BarCodeErr = "{Barcode ��ҧ}"
                StatusError &= " " & BarCodeErr
            End If

            If IsDate(strDateTime.Trim) = False Then
                DateTimeError = "{�����������ѹ���}"
                StatusError &= " " & DateTimeError
            End If

            If StatusError <> "" Then
                arrData = New String() {row, _
                                        StatusError.Trim, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFileErr.Items.Add(List)
            Else
                arrData = New String() {lstListFile.Items.Count + 1, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFile.Items.Add(List)
            End If
        Loop
        lstListFile.EndUpdate()
        Sr.Close()
    End Sub

    Private Sub GetType7(ByVal FullFileName As String)
        '����                               �ѹ��� ����
        '04156519            201108151039F2001
        'PI-053            201110180552F1002
        Dim List As ListViewItem
        Dim arrData() As String

        Dim Sr As New System.IO.StreamReader(FullFileName)
        Dim line As String

        Dim Code As String = ""
        Dim strDateTime As String = ""

        Dim Barcode As String = ""
        Dim Col As Integer

        Dim row As Integer = 0
        lblStatus.Text = " ����Ң����� ��� " & row
        Application.DoEvents()

        Dim BarCodeErr As String = ""
        Dim CodeErr As String = ""
        Dim DateTimeError As String = ""
        Dim StatusError As String

        ' Read and display the lines from the file until the end 
        ' of the file is reached.

        lstListFile.Items.Clear()
        lstListFileErr.Items.Clear()

        lstListFile.BeginUpdate()

        Dim intSplace As Integer = 0

        Do While Sr.Peek() >= 0
            '04156519            201108151039F2001
            line = Sr.ReadLine()
            Col = 0
            'Code = Mid(line, 1, 9)
            'line = Mid(line.Trim, 28, 25)
            Barcode = Trim(Mid(line, 1, 18))

            Code = GetEmpCode(Barcode).Trim

            strDateTime = Mid(line, 19, 13)
            '21/04/2011 07:28:00
            strDateTime = Mid(strDateTime.Trim, 1, 4) & "/" & Mid(strDateTime.Trim, 5, 2) & "/" & Mid(strDateTime.Trim, 7, 2) & " " & _
                                    Mid(strDateTime.Trim, 9, 2) & ":" & Mid(strDateTime.Trim, 11, 2)

            'strDateTime = ConvertDate(Mid(strDateTime, 1, 10)) & " " & Mid(strDateTime, 12, 5)
            ' "20" & Mid(strDateTime.Trim, 1, 2) & "/" & Mid(strDateTime.Trim, 3, 2) & "/" & Mid(strDateTime.Trim, 5, 2) & " " & _
            '                        Mid(strDateTime.Trim, 7, 2) & ":" & Mid(strDateTime.Trim, 9, 2)

            row += 1
            lblStatus.Text = " ����Ң����� ��� " & row
            Application.DoEvents()

            BarCodeErr = ""
            CodeErr = ""
            DateTimeError = ""
            StatusError = ""
            If Code.Trim = "" Then
                CodeErr = "{��辺���ʾ��.}"
                StatusError &= CodeErr
            ElseIf Code.Length > 30 Then
                CodeErr = "{�ҡ���� 30 ����ѡ��}"
                StatusError &= " " & CodeErr
            End If

            If Barcode.Trim = "" Then
                BarCodeErr = "{Barcode ��ҧ}"
                StatusError &= " " & BarCodeErr
            End If

            If IsDate(strDateTime.Trim) = False Then
                DateTimeError = "{�����������ѹ���}"
                StatusError &= " " & DateTimeError
            End If

            If StatusError <> "" Then
                arrData = New String() {row, _
                                        StatusError.Trim, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFileErr.Items.Add(List)
            Else
                arrData = New String() {lstListFile.Items.Count + 1, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFile.Items.Add(List)
            End If
        Loop
        lstListFile.EndUpdate()
        Sr.Close()
    End Sub


    Private Sub GetType8(ByVal FullFileName As String)
        '����                               �ѹ��� ����
        '117771 120201 1538 01
        '117771120201153801
        Dim List As ListViewItem
        Dim arrData() As String

        Dim Sr As New System.IO.StreamReader(FullFileName)
        Dim line As String

        Dim Code As String = ""
        Dim strDateTime As String = ""

        Dim Barcode As String = ""
        Dim Col As Integer

        Dim row As Integer = 0
        lblStatus.Text = " ����Ң����� ��� " & row
        Application.DoEvents()

        Dim BarCodeErr As String = ""
        Dim CodeErr As String = ""
        Dim DateTimeError As String = ""
        Dim StatusError As String

        ' Read and display the lines from the file until the end 
        ' of the file is reached.

        lstListFile.Items.Clear()
        lstListFileErr.Items.Clear()

        lstListFile.BeginUpdate()

        Dim intSplace As Integer = 0

        Do While Sr.Peek() >= 0
            '04156519            201108151039F2001
            line = Sr.ReadLine()
            Col = 0
            'Code = Mid(line, 1, 9)
            'line = Mid(line.Trim, 28, 25)
            Barcode = Trim(Mid(line, 1, 6))

            Code = GetEmpCode(Barcode).Trim

            strDateTime = Mid(line, 7, 10)
            '120201 1538
            'strDateTime = Mid(strDateTime.Trim, 1, 4) & "/" & Mid(strDateTime.Trim, 5, 2) & "/" & Mid(strDateTime.Trim, 7, 2) & " " & _
            '                        Mid(strDateTime.Trim, 9, 2) & ":" & Mid(strDateTime.Trim, 11, 2)

            strDateTime = "20" & Mid(strDateTime.Trim, 1, 2) & "/" & Mid(strDateTime.Trim, 3, 2) & "/" & Mid(strDateTime.Trim, 5, 2) & " " & _
                                    Mid(strDateTime.Trim, 7, 2) & ":" & Mid(strDateTime.Trim, 9, 2)

            row += 1
            lblStatus.Text = " ����Ң����� ��� " & row
            Application.DoEvents()

            BarCodeErr = ""
            CodeErr = ""
            DateTimeError = ""
            StatusError = ""
            If Code.Trim = "" Then
                CodeErr = "{��辺���ʾ��.}"
                StatusError &= CodeErr
            ElseIf Code.Length > 30 Then
                CodeErr = "{�ҡ���� 30 ����ѡ��}"
                StatusError &= " " & CodeErr
            End If

            If Barcode.Trim = "" Then
                BarCodeErr = "{Barcode ��ҧ}"
                StatusError &= " " & BarCodeErr
            End If

            If IsDate(strDateTime.Trim) = False Then
                DateTimeError = "{�����������ѹ���}"
                StatusError &= " " & DateTimeError
            End If

            If StatusError <> "" Then
                arrData = New String() {row, _
                                        StatusError.Trim, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFileErr.Items.Add(List)
            Else
                arrData = New String() {lstListFile.Items.Count + 1, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFile.Items.Add(List)
            End If
        Loop
        lstListFile.EndUpdate()
        Sr.Close()
    End Sub

    Private Sub GetType9(ByVal FullFileName As String)
        '31201201040739000200PSR.00170001
        '31 20120104 0739 000200 PSR.0017 0001
        Dim List As ListViewItem
        Dim arrData() As String

        Dim Sr As New System.IO.StreamReader(FullFileName)
        Dim line As String

        Dim Code As String = ""
        Dim strDateTime As String = ""

        Dim Barcode As String = ""
        Dim Col As Integer

        Dim row As Integer = 0
        lblStatus.Text = " ����Ң����� ��� " & row
        Application.DoEvents()

        Dim BarCodeErr As String = ""
        Dim CodeErr As String = ""
        Dim DateTimeError As String = ""
        Dim StatusError As String

        ' Read and display the lines from the file until the end 
        ' of the file is reached.

        lstListFile.Items.Clear()
        lstListFileErr.Items.Clear()

        lstListFile.BeginUpdate()

        Dim intSplace As Integer = 0

        Do While Sr.Peek() >= 0
            '04156519            201108151039F2001
            line = Sr.ReadLine()
            Col = 0
            'Code = Mid(line, 1, 9)
            'line = Mid(line.Trim, 28, 25)
            Barcode = Trim(Mid(line, 21, 8))

            Code = GetEmpCode(Barcode).Trim

            strDateTime = Mid(line, 3, 12)
            '120201 1538
            strDateTime = Mid(strDateTime.Trim, 1, 4) & "/" & Mid(strDateTime.Trim, 5, 2) & "/" & Mid(strDateTime.Trim, 7, 2) & " " & _
                                    Mid(strDateTime.Trim, 9, 2) & ":" & Mid(strDateTime.Trim, 11, 2)

            'strDateTime = "20" & Mid(strDateTime.Trim, 1, 2) & "/" & Mid(strDateTime.Trim, 3, 2) & "/" & Mid(strDateTime.Trim, 5, 2) & " " & _
            '                        Mid(strDateTime.Trim, 7, 2) & ":" & Mid(strDateTime.Trim, 9, 2)

            row += 1
            lblStatus.Text = " ����Ң����� ��� " & row
            Application.DoEvents()

            BarCodeErr = ""
            CodeErr = ""
            DateTimeError = ""
            StatusError = ""
            If Code.Trim = "" Then
                CodeErr = "{��辺���ʾ��.}"
                StatusError &= CodeErr
            ElseIf Code.Length > 30 Then
                CodeErr = "{�ҡ���� 30 ����ѡ��}"
                StatusError &= " " & CodeErr
            End If

            If Barcode.Trim = "" Then
                BarCodeErr = "{Barcode ��ҧ}"
                StatusError &= " " & BarCodeErr
            End If

            If IsDate(strDateTime.Trim) = False Then
                DateTimeError = "{�����������ѹ���}"
                StatusError &= " " & DateTimeError
            End If

            If StatusError <> "" Then
                arrData = New String() {row, _
                                        StatusError.Trim, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFileErr.Items.Add(List)
            Else
                arrData = New String() {lstListFile.Items.Count + 1, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFile.Items.Add(List)
            End If
        Loop
        lstListFile.EndUpdate()
        Sr.Close()
    End Sub

    Private Sub GetType10(ByVal FullFileName As String)
        '01	27-03-2012	15:44:49	'058823		0001
        Dim List As ListViewItem
        Dim arrData() As String

        Dim Sr As New System.IO.StreamReader(FullFileName)
        Dim line As String

        Dim Code As String = ""
        Dim strDateTime As String = ""

        Dim Barcode As String = ""
        Dim Col As Integer

        Dim row As Integer = 0
        lblStatus.Text = " ����Ң����� ��� " & row
        Application.DoEvents()

        Dim BarCodeErr As String = ""
        Dim CodeErr As String = ""
        Dim DateTimeError As String = ""
        Dim StatusError As String

        ' Read and display the lines from the file until the end 
        ' of the file is reached.

        lstListFile.Items.Clear()
        lstListFileErr.Items.Clear()

        lstListFile.BeginUpdate()

        Dim intSplace As Integer = 0

        Do While Sr.Peek() >= 0
            '04156519            201108151039F2001
            line = Sr.ReadLine()
            Col = 0
            'Code = Mid(line, 1, 9)
            'line = Mid(line.Trim, 28, 25)
            Barcode = Trim(Mid(line, 25, 7))

            Code = GetEmpCode(Barcode).Trim

            strDateTime = Mid(line, 4, 16)
            '120201 1538
            strDateTime = Mid(strDateTime.Trim, 7, 4) & "/" & Mid(strDateTime.Trim, 4, 2) & "/" & Mid(strDateTime.Trim, 1, 2) & " " & _
                                    Mid(strDateTime.Trim, 12, 2) & ":" & Mid(strDateTime.Trim, 15, 2)

            'strDateTime = "20" & Mid(strDateTime.Trim, 1, 2) & "/" & Mid(strDateTime.Trim, 3, 2) & "/" & Mid(strDateTime.Trim, 5, 2) & " " & _
            '                        Mid(strDateTime.Trim, 7, 2) & ":" & Mid(strDateTime.Trim, 9, 2)

            row += 1
            lblStatus.Text = " ����Ң����� ��� " & row
            Application.DoEvents()

            BarCodeErr = ""
            CodeErr = ""
            DateTimeError = ""
            StatusError = ""
            If Code.Trim = "" Then
                CodeErr = "{��辺���ʾ��.}"
                StatusError &= CodeErr
            ElseIf Code.Length > 30 Then
                CodeErr = "{�ҡ���� 30 ����ѡ��}"
                StatusError &= " " & CodeErr
            End If

            If Barcode.Trim = "" Then
                BarCodeErr = "{Barcode ��ҧ}"
                StatusError &= " " & BarCodeErr
            End If

            If IsDate(strDateTime.Trim) = False Then
                DateTimeError = "{�����������ѹ���}"
                StatusError &= " " & DateTimeError
            End If

            If StatusError <> "" Then
                arrData = New String() {row, _
                                        StatusError.Trim, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFileErr.Items.Add(List)
            Else
                arrData = New String() {lstListFile.Items.Count + 1, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFile.Items.Add(List)
            End If
        Loop
        lstListFile.EndUpdate()
        Sr.Close()
    End Sub

    Private Sub GetType11(ByVal FullFileName As String)
        '        0013448176                 2012/04/20  10:38
        Dim List As ListViewItem
        Dim arrData() As String

        Dim Sr As New System.IO.StreamReader(FullFileName)
        Dim line As String

        Dim Code As String = ""
        Dim strDateTime As String = ""

        Dim Barcode As String = ""
        Dim Col As Integer

        Dim row As Integer = 0
        lblStatus.Text = " ����Ң����� ��� " & row
        Application.DoEvents()

        Dim BarCodeErr As String = ""
        Dim CodeErr As String = ""
        Dim DateTimeError As String = ""
        Dim StatusError As String

        ' Read and display the lines from the file until the end 
        ' of the file is reached.

        lstListFile.Items.Clear()
        lstListFileErr.Items.Clear()

        lstListFile.BeginUpdate()

        Dim intSplace As Integer = 0

        Do While Sr.Peek() >= 0
            '        0013448176                 2012/04/20  10:38
            line = Sr.ReadLine()
            Col = 0
            'Code = Mid(line, 1, 9)
            'line = Mid(line.Trim, 28, 25)
            Barcode = Trim(Mid(line, 9, 10))

            Code = GetEmpCode(Barcode).Trim

            strDateTime = Mid(line, 36, 10) & " " & Mid(line, 48, 5)
            '120201 1538
            'strDateTime = Mid(strDateTime.Trim, 7, 4) & "/" & Mid(strDateTime.Trim, 4, 2) & "/" & Mid(strDateTime.Trim, 1, 2) & " " & _
            '                        Mid(strDateTime.Trim, 12, 2) & ":" & Mid(strDateTime.Trim, 15, 2)

            'strDateTime = "20" & Mid(strDateTime.Trim, 1, 2) & "/" & Mid(strDateTime.Trim, 3, 2) & "/" & Mid(strDateTime.Trim, 5, 2) & " " & _
            '                        Mid(strDateTime.Trim, 7, 2) & ":" & Mid(strDateTime.Trim, 9, 2)

            row += 1
            lblStatus.Text = " ����Ң����� ��� " & row
            Application.DoEvents()

            BarCodeErr = ""
            CodeErr = ""
            DateTimeError = ""
            StatusError = ""
            If Code.Trim = "" Then
                CodeErr = "{��辺���ʾ��.}"
                StatusError &= CodeErr
            ElseIf Code.Length > 30 Then
                CodeErr = "{�ҡ���� 30 ����ѡ��}"
                StatusError &= " " & CodeErr
            End If

            If Barcode.Trim = "" Then
                BarCodeErr = "{Barcode ��ҧ}"
                StatusError &= " " & BarCodeErr
            End If

            If IsDate(strDateTime.Trim) = False Then
                DateTimeError = "{�����������ѹ���}"
                StatusError &= " " & DateTimeError
            End If

            If StatusError <> "" Then
                arrData = New String() {row, _
                                        StatusError.Trim, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFileErr.Items.Add(List)
            Else
                arrData = New String() {lstListFile.Items.Count + 1, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFile.Items.Add(List)
            End If
        Loop
        lstListFile.EndUpdate()
        Sr.Close()
    End Sub

    Private Sub GetType12(ByVal FullFileName As String)
        '53-2-131            201211230711F1001'
        Dim List As ListViewItem
        Dim arrData() As String

        Dim Sr As New System.IO.StreamReader(FullFileName)
        Dim line As String

        Dim Code As String = ""
        Dim strDateTime As String = ""

        Dim Barcode As String = ""
        Dim Col As Integer

        Dim row As Integer = 0
        lblStatus.Text = " ����Ң����� ��� " & row
        Application.DoEvents()

        Dim BarCodeErr As String = ""
        Dim CodeErr As String = ""
        Dim DateTimeError As String = ""
        Dim StatusError As String

        ' Read and display the lines from the file until the end 
        ' of the file is reached.

        lstListFile.Items.Clear()
        lstListFileErr.Items.Clear()

        lstListFile.BeginUpdate()

        Dim intSplace As Integer = 0

        Do While Sr.Peek() >= 0
            ' ��ͧ��¹ ��ҹ�ҡ��ѧ��˹�� ������� ���� + ��ͧ��ҧ 12 + �ѹ��� �������
            '53-2-131            201211230711F1001'
            line = Sr.ReadLine()


            Dim TimeData As String = RightText(line, 17)
            Dim CodeData As String = LeftText(line, Len(line) - 17)
            Col = 0
            Code = Replace(CodeData.Trim, "-", "")
            'line = Mid(line.Trim, 28, 25)
            'Barcode = Trim(Mid(line, 9, 10))

            'Code = GetEmpCode(Barcode).Trim

            strDateTime = LeftText(TimeData, 12)
            '120201 1538
            strDateTime = Mid(strDateTime.Trim, 1, 4) & "/" & Mid(strDateTime.Trim, 5, 2) & "/" & Mid(strDateTime.Trim, 7, 2) & " " & _
                                    Mid(strDateTime.Trim, 9, 2) & ":" & Mid(strDateTime.Trim, 11, 2)

            'strDateTime = "20" & Mid(strDateTime.Trim, 1, 2) & "/" & Mid(strDateTime.Trim, 3, 2) & "/" & Mid(strDateTime.Trim, 5, 2) & " " & _
            '                        Mid(strDateTime.Trim, 7, 2) & ":" & Mid(strDateTime.Trim, 9, 2)

            row += 1
            lblStatus.Text = " ����Ң����� ��� " & row
            Application.DoEvents()

            BarCodeErr = ""
            CodeErr = ""
            DateTimeError = ""
            StatusError = ""

            If EmpCodeIsExist(Code.Trim) = False Then
                CodeErr = "{��辺���ʾ��.}" & Code.Trim
                StatusError &= CodeErr
            End If

            'If Code.Trim = "" Then
            '    CodeErr = "{��辺���ʾ��.}"
            '    StatusError &= CodeErr
            'ElseIf Code.Length > 30 Then
            '    CodeErr = "{�ҡ���� 30 ����ѡ��}"
            '    StatusError &= " " & CodeErr
            'End If

            'If Barcode.Trim = "" Then
            '    BarCodeErr = "{Barcode ��ҧ}"
            '    StatusError &= " " & BarCodeErr
            'End If

            If IsDate(strDateTime.Trim) = False Then
                DateTimeError = "{�����������ѹ���}"
                StatusError &= " " & DateTimeError
            End If

            If StatusError <> "" Then
                arrData = New String() {row, _
                                        StatusError.Trim, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFileErr.Items.Add(List)
            Else
                arrData = New String() {lstListFile.Items.Count + 1, _
                                        Barcode.Trim, _
                                        Code.Trim, _
                                        strDateTime.Trim}
                List = New ListViewItem(arrData)
                lstListFile.Items.Add(List)
            End If
        Loop
        lstListFile.EndUpdate()
        Sr.Close()
    End Sub

    Private Sub GetType13_CKC(ByVal FullFileName As String)
        '1      (2 ����)       3               4       6               6           7           (8 ���ʾ�ѡ�ҹ)                           9
        'Index,Time    ,Station        ,Num   ,Name           ,Department,Department:2,UserID                    ,Status              
        '0029 ,07:49:59,54 in          ,0218  ,Nam-oye T.(Guard5),Admin     ,Security  ,SG01                      ,(M11)Normal Access  

        Dim List As ListViewItem
        Dim arrData() As String

        Dim Sr As New System.IO.StreamReader(FullFileName)
        Dim line As String

        Dim Code As String = ""
        Dim strDateTime As String = ""

        Dim Barcode As String = ""
        Dim Col As Integer
        Dim row As Integer = 0
        Dim BarCodeErr As String = ""
        Dim CodeErr As String = ""
        Dim DateTimeError As String = ""
        Dim StatusError As String

        Dim Station As String = ""

        ' Read and display the lines from the file until the end 
        ' of the file is reached.

        lstListFile.Items.Clear()
        lstListFileErr.Items.Clear()
        lstListFile.BeginUpdate()

        Dim intSplace As Integer = 0

        Do While Sr.Peek() >= 0
            ' Format 0080            20100823070801001
            line = Sr.ReadLine()
            Col = 0

            Dim strData As New ArrayList
            strData.Clear()
            For i As Integer = 1 To 9
                Dim data As String = ""

                intSplace = InStr(line, ",", CompareMethod.Text)
                If intSplace = 0 Then
                    data = Mid(line, 1)
                Else
                    data = Mid(line, 1, intSplace)
                End If

                data = Replace(data, ",", "")
                strData.Add(data)

                line = Mid(line, intSplace + 1)
            Next

            'Code = Mid(line, 1, 9)
            Barcode = strData(7)

            Code = strData(7)

            Station = strData(2)


            strDateTime = ConvertDate(txtDate.Text) & " " & LeftText(strData(1), 5)

            'strDateTime = Mid(strDateTime.Trim, 1, 4) & "/" & Mid(strDateTime.Trim, 5, 2) & "/" & Mid(strDateTime.Trim, 7, 2) & " " & _
            '            Mid(strDateTime.Trim, 9, 2) & ":" & Mid(strDateTime.Trim, 11, 2)


            ' Format 000 1 20100816 0704 F01 00001

            'line = Sr.ReadLine()
            'line = Mid(line, 7, line.Length - 6)
            'Col = 0
            'intSplace = InStr(line, " ", CompareMethod.Text)

            'strDateTime = Replace(LeftText(line, 13), " ", "")

            'strDateTime = Mid(strDateTime.Trim, 1, 4) & "/" & Mid(strDateTime.Trim, 5, 2) & "/" & Mid(strDateTime.Trim, 7, 2) & " " & _
            '            Mid(strDateTime.Trim, 9, 2) & ":" & Mid(strDateTime.Trim, 11, 2)

            'line = Mid(line, 14, line.Length - 13).Trim


            'Barcode = Mid(line, 5, line.Length - 4)

            'Code = GetEmpCode(Barcode).Trim

            If GetStationInUsed(Station.Trim) = True Then
                row += 1
                lblStatus.Text = " ����Ң����� ��� " & row
                Application.DoEvents()

                BarCodeErr = ""
                CodeErr = ""
                DateTimeError = ""
                StatusError = ""
                If Code.Trim = "" Then
                    CodeErr = "{��辺���ʾ��.}"
                    StatusError &= CodeErr
                ElseIf Code.Length > 30 Then
                    CodeErr = "{�ҡ���� 30 ����ѡ��}"
                    StatusError &= " " & CodeErr
                End If

                If Barcode.Trim = "" Then
                    BarCodeErr = "{Barcode ��ҧ}"
                    StatusError &= " " & BarCodeErr
                End If

                If IsDate(strDateTime.Trim) = False Then
                    DateTimeError = "{�����������ѹ���}"
                    StatusError &= " " & DateTimeError
                End If

                If StatusError <> "" Then
                    arrData = New String() {row, _
                                            StatusError.Trim, _
                                            Barcode.Trim, _
                                            Code.Trim, _
                                            strDateTime.Trim}
                    List = New ListViewItem(arrData)
                    lstListFileErr.Items.Add(List)
                Else
                    arrData = New String() {lstListFile.Items.Count + 1, _
                                            Barcode.Trim, _
                                            Code.Trim, _
                                            strDateTime.Trim}
                    List = New ListViewItem(arrData)
                    lstListFile.Items.Add(List)
                End If
            End If
        Loop
        lstListFile.EndUpdate()
        Sr.Close()
    End Sub


    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "All File|*.*"
        'OpenFileDialog1.Filter = "All File|*.dat,*.txt,*.CSV,*.*"
        If OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub

        Application.DoEvents()
        If Trim(OpenFileDialog1.FileName) = "" Then
            txtFileName.Text = ""
            Exit Sub
        End If
        Dim FileName As String = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
        Dim FileNameExt As String = System.IO.Path.GetExtension(OpenFileDialog1.FileName)
        FileName = Replace(FileName, FileNameExt, "")
        Dim dDate As String = RightText(FileName, 8)
        dDate = Mid(dDate, 7, 2) & "/" & Mid(dDate, 5, 2) & "/" & Mid(dDate, 1, 4)
        If IsDate(ConvertDate(dDate)) = True Then
            txtDate.Text = dDate
        Else
            txtDate.Text = ""
        End If
        'txtFileName.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
        txtFileName.Text = OpenFileDialog1.FileName

    End Sub

    Function InsertZero(ByVal Data As String, ByVal AllLength As Integer) As String
        Dim Lng As Integer
        Dim I As Integer
        Dim Result As String
        Result = Data.Trim
        Lng = Data.Length
        For I = 1 To AllLength - Lng
            Result = "0" & Result
        Next
        Return Result.Trim
    End Function

    Private Sub frmGetText_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        fGetText = Nothing
    End Sub

    Private Sub frmGetText_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboGetText.SelectedIndex = GetTextType() - 1
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        btnSave.Enabled = False
        Dim dCmd As New SqlCommand
        Dim strSQL As String
        Dim Tn As SqlTransaction
        Tn = Conn.BeginTransaction
        dCmd.Transaction = Tn
        ProgressBar1.Maximum = lstListFile.Items.Count
        ProgressBar1.Value = 0
        Try
            strSQL = "Delete From TimeMaster Where FromFile = '" & System.IO.Path.GetFileName(txtFileName.Text.Trim) & "'"
            If CView = True Then
                strSQL &= " and  "
            End If
            dCmd.Connection = Conn
            dCmd.CommandText = strSQL
            dCmd.ExecuteNonQuery()

            Dim I As Integer
            For I = 0 To lstListFile.Items.Count - 1
                strSQL = "Delete From TimeMaster " & _
                        " Where Code = '" & lstListFile.Items(I).SubItems(2).Text.Trim & "' and " & _
                                " Replace(Convert(nVarchar(16),DateIn,121),'-','/') =  '" & lstListFile.Items(I).SubItems(3).Text.Trim & "'"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()

                strSQL = "Insert Into TimeMaster(Code,DateIn,FromFile) Values(" & _
                        " '" & lstListFile.Items(I).SubItems(2).Text.Trim & "'," & _
                        " '" & lstListFile.Items(I).SubItems(3).Text.Trim & "'," & _
                        " '" & System.IO.Path.GetFileName(txtFileName.Text.Trim) & "')"
                dCmd.Connection = Conn
                dCmd.CommandText = strSQL
                dCmd.ExecuteNonQuery()

                ProgressBar1.Value = I
                lblStatus.Text = "�ѹ�֡������ " & I & "/" & lstListFile.Items.Count
                Application.DoEvents()
            Next

            Tn.Commit()
        Catch ex As Exception
            Tn.Rollback()
            btnSave.Enabled = True
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Save Error")
            Exit Sub
        End Try
        btnSave.Enabled = True
        'MsgBox("�ѹ�֡���������º��������", MsgBoxStyle.Information, Me.Text)
        MsgManager.ShowDialog(Me, "frmGetTextRS", Me.Text, "Save_Complete", MessageBoxIcon.Information)
    End Sub


    Function GetEmpCode(ByVal Barcode As String) As String
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select Code " & _
                " From EmpSetBarcode " & _
                " Where Barcode = '" & Barcode.Trim & "'"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return ""
            Else
                Return .Rows(0).Item("Code")
            End If
        End With
    End Function

    Function EmpCodeIsExist(ByVal Code As String) As Boolean
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select Code " & _
                " From Emp " & _
                " Where Code = '" & Code.Trim & "'"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        End With
    End Function

    Function GetStationInUsed(ByVal Station As String) As Boolean
        Dim Da As SqlDataAdapter
        Dim Ds As New DataSet
        Dim strSQL As String = ""
        strSQL = "select * " & _
                " From TimeMatchine_Station " & _
                " Where Station = '" & Station.Trim & "'"

        Da = New SqlDataAdapter(strSQL, Conn)
        Da.Fill(Ds, "data")
        With Ds.Tables("data")
            If .Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        End With
    End Function

    Private Sub cboGetText_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGetText.SelectedIndexChanged

    End Sub
End Class
