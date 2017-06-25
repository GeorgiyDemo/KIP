'Написать программу на VBA, которая позволяет в прямоугольной матрице осуществлять
'поиск чисел и их индексы, которые больше по модулю числа, введенного с клавиатуры

Private Sub CommandButton1_Click()

    Dim a(100, 100), KOT, n, m, i, j As Integer

    'Ввод исходных данных
    Label1.Caption = "Исходная матрица: " + Chr(13)
    KOT = CInt(InputBox("Введите число:"))
    Label2.Caption = "Числа, больше " + CStr(KOT) + " по модулю:" + Chr(13)
    
    n = CInt(InputBox("Введите кол-во строк:"))
    m = CInt(InputBox("Введите кол-во столбцов:"))

    'Вывод исходной матрицы на Label1, вывод чисел больше по модулю на Label2
    For i = 1 To n
        Label1.Caption = Label1.Caption + Chr(13)
        For j = 1 To m
            a(i, j) = CInt(Rnd() * 20 - 10)
            Label1.Caption = Label1.Caption + CStr(a(i, j)) + Chr(9)
    
            If (Abs(a(i, j)) > KOT) Then
                Label2.Caption = Label2.Caption + CStr(a(i, j)) + "(" + 
CStr(i) + ")" + " "
            End If
        Next j
    Next i

End Sub

