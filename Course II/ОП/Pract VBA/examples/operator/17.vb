Private Sub CommandButton1_Click()
    Dim a(100, 100), ch(100), h(100), buf, i, j, n, k, t, q, w As Integer

    'Размерность матрицы
    n = TextBox1.Text

    'На сколько делаем сдвиг
    w = TextBox2.Text

    'Сдвиг вверх/вниз (1 или 0)
    q = TextBox3.Text


    Label1.Caption = "Исходная матрица:" + Chr(10)
    Randomize
    For i = 0 To n - 1
        Label1.Caption = Label1.Caption + Chr(10)
        For j = 0 To n - 1
            a(i, j) = CInt(Rnd() * 100 - 60)
            Label1.Caption = Label1.Caption + CStr(a(i, j)) + Chr(9)
        Next j
    Next i

    If (q = 1) Then
        For k = 1 To w
            For j = 0 To n - 1
                i = 0
                h(j) = a(0, j)
            Next j
            For i = 0 To n - 2
                For j = 0 To n - 1
                    a(i, j) = a(i + 1, j)
                    a(i + 1, j) = a(i, j)
                Next j
            Next i
            For j = 0 To n - 1
                a(n - 1, j) = h(j)
            Next j
        Next k
    Else
        For k = 1 To w
            For j = 0 To n - 1
                h(j) = a(n - 1, j)
            Next j
            For i = n - 1 To 1 Step -1
                For j = n - 1 To 0 Step -1
                    a(i, j) = a(i - 1, j)
                    a(i - 1, j) = a(i, j)
                Next j
            Next i
            For j = 0 To n - 1
                a(0, j) = h(j)
            Next j
        Next k
    End If

    Label2.Caption = "Преобразованная матрица:" + Chr(10)
    For i = 0 To n - 1
        Label2.Caption = Label2.Caption + Chr(10)
        For j = 0 To n - 1
            Label2.Caption = Label2.Caption + CStr(a(i, j)) + Chr(9)
        Next j
    Next i

End Sub
