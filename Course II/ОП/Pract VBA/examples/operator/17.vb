'Написать программу на VBA, которая позволяет в прямоугольной матрице 
осуществлять
'поиск чисел и их индексы, которые больше по модулю числа, введенного с 
клавиатуры

Private Sub CommandButton1_Click()

    Dim a(100, 100), i, j, n, m, p, r As Integer

    'Ввод исходных данных
    Label1.Caption = "Исходная матрица: " + Chr(13)
    Label2.Caption = "Максимумы строк: " + Chr(13)
    Label3.Caption = "Преобразованная матрица: " + Chr(13)
    
    n = CInt(InputBox("Введите кол-во строк:"))
    m = CInt(InputBox("Введите кол-во столбцов:"))
    p = CInt(InputBox("На сколько выполняем сдвиг?"))
    
    'Вывод исходной матрицы на Label1
    For i = 1 To n
        Label1.Caption = Label1.Caption + Chr(13)
        For j = 1 To m
            a(i, j) = CInt(Rnd() * 20 - 10)
            Label1.Caption = Label1.Caption + CStr(a(i, j)) + Chr(9)
        Next j
    Next i
    
    For r = LBound(a, 2) To UBound(a, 2)
        If (p < 0) Then
            For j = 1 To Abs(p)
                b = a(r, 1)
                For i = 1 To n - 1
                    a(r, i) = a(r, i + 1)
                Next i
                a(r, n) = b
            Next j
        End If
        
        If (p >= 0) Then
            For j = 1 To p
                b = a(r, n)
                For i = n To 2 Step -1
                    a(r, i) = a(r, i - 1)
                Next i
                a(r, 1) = b
             Next j
        End If
    Next r
    
    For i = 1 To n
        Label2.Caption = Label2.Caption + Chr(13)
        For j = 1 To m
            a(i, j) = CInt(Rnd() * 20 - 10)
            Label2.Caption = Label2.Caption + CStr(a(i, j)) + Chr(9)
        Next j
    Next i
    
End Sub

