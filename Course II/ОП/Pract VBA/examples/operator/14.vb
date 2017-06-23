'Написать программу на VBA, которая позволяет заполнять матрицу
'произвольного размера нулями и единицами в шахматном порядке

Private Sub CommandButton1_Click()

    Dim a(100, 100), n, m, i, j As Integer

    'Ввод исходных данных
    Label1.Caption = "Исходный массив: " + Chr(13)
    Label2.Caption = "Преобразованный массив:" + Chr(13)

    n = InputBox("Введите кол-во строк в массиве: ")
    m = InputBox("Введите кол-во столбцов в массиве: ")
    
    'Вывод исходного массива на Label1
    For i = 1 To n
        Label1.Caption = Label1.Caption + Chr(13)
        For j = 1 To m
        If ((i + j) Mod 2 = 0) Then
            a(i, j) = 0
        Else
            a(i, j) = 1
        End If

        Label1.Caption = Label1.Caption + CStr(a(i, j)) + " "
        Next j
    Next i

End Sub
