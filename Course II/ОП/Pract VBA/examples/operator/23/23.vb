'Написать программу на VBA, которая позволяет сортировать строки квадратной матрицы по убыванию максимумов в этих строках

Private Sub CommandButton1_Click()

    Dim a(100, 100), max(100), n, m, i, j, l As Integer

    'Ввод исходных данных
    Label1.Caption = "Исходная матрица: " + Chr(13)
    Label2.Caption = "Максимумы строк: " + Chr(13)
    Label3.Caption = "Преобразованная матрица: " + Chr(13)
    n = CInt(InputBox("Введите кол-во строк:"))
    m = CInt(InputBox("Введите кол-во столбцов:"))

    'Вывод исходной матрицы на Label1
    For i = 1 To n
    max(i) = -999
        Label1.Caption = Label1.Caption + Chr(13)
        For j = 1 To m
            a(i, j) = CInt(Rnd() * 20 - 10)
            Label1.Caption = Label1.Caption + CStr(a(i, j)) + Chr(9)
            If (a(i, j) > max(i)) Then
                max(i) = a(i, j)
            End If
        Next j
        'Выводим максимумы на Label2
        Label2.Caption = Label2.Caption + Chr(13) + "№" + CStr(i) + " " + CStr(max(i))
    Next i
    
    For i = 1 To n - 1
        For l = i + 1 To n
            If (max(i) < max(l)) Then
                For j = 1 To m
                    buf = a(i, j)
                    a(i, j) = a(l, j)
                    a(l, j) = buf
                Next j
            End If
        Next l
    Next i
   
    'Вывод отсортированной матрицы на Label3
    For i = 1 To n
        Label3.Caption = Label3.Caption + Chr(13)
        For j = 1 To m
            Label3.Caption = Label3.Caption + CStr(a(i, j)) + Chr(9)
        Next j
    Next i
    
End Sub


