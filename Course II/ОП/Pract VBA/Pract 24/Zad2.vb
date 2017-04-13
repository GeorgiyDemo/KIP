Private Sub CommandButton1_Click()

    Dim a(100, 100), n, m, i, j, buf, sum(100) As Integer
    
    n = CInt(TextBox1.Text) - 1
    m = CInt(TextBox2.Text) - 1
    Label1.Caption = ""
    Label4.Caption = ""
    
    For i = 0 To n
        Label1.Caption = Label1.Caption + Chr(13)
        For j = 0 To m
            a(i, j) = CInt(Rnd() * 100 - 50)
            Label1.Caption = Label1.Caption + Chr(9) + CStr(a(i, j))
        Next j
    Next i

    For i = 0 To n
        sum(i) = 0
        For j = 0 To m
            If (a(i, j) < 0) Then
                sum(i) = sum(i) + a(i, j)
            End If
        Next j
    Next i

    'Сама сортировка
    For i = 0 To n - 1
        For k = i + 1 To n
            If (sum(i) < sum(k)) Then
                buf = sum(i)
                sum(i) = sum(k)
                sum(k) = buf
                For j = 0 To m
                    buf = a(i, j)
                    a(i, j) = a(k, j)
                    a(k, j) = buf
                Next j
            End If
        Next k
    Next i

    'Вывод всего на Label
    For i = 0 To n
        Label4.Caption = Label4.Caption + Chr(13)
        For j = 0 To m
            Label4.Caption = Label4.Caption + Chr(9) + CStr(a(i, j))
        Next j
    Next i
    
End Sub
