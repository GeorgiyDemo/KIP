Private Sub CommandButton1_Click()
    Dim a(100, 100), max(100), i, j, buf, index1, index2 As Integer
    
    'Ввод исходных данных
    Label1.Caption = "Исходная матрица" + Chr(13)
    Label2.Caption = "Преобразованная матрица" + Chr(13)
    n = InputBox("Введите размерность матрицы")
    
    'Вывод исходной матрицы на Label1
    For i = 1 To n
    Label1.Caption = Label1.Caption + Chr(13)
        For j = 1 To n
            a(i, j) = CInt(Rnd() * 20 - 10)
            Label1.Caption = Label1.Caption + CStr(a(i, j)) + Chr(9)
        Next j
    Next i
    
    'Перестановка исходных элементов
    max(1) = a(1, 1)
    For i = 1 To n
        For j = 1 To n
             If a(i, j) > max(i) Then
                max(i) = a(i, j)
                index1 = i
                index2 = j
             End If
        Next j
        buf = a(i, i)
        a(i, i) = max(i)
        a(index1, index2) = buf
    Next i
        
    'Вывод полученной матрицы на Label2
    For i = 1 To n
        Label2.Caption = Label2.Caption + Chr(13)
        For j = 1 To n
            Label2.Caption = Label2.Caption + CStr(a(i, j)) + Chr(9)
        Next j
    Next i
    
End Sub

