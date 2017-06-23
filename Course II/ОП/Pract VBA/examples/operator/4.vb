'Написать программу на VBA, которая позволяет в одномерном массиве осуществлять сортировку
'элементов по возрастанию/убыванию по выбору пользователя

Private Sub CommandButton1_Click()
    Dim a(100), i, j, sum, flag, proz As Integer

    'Ввод исходных данных
    Label1.Caption = "Исходный массив: " + Chr(13)
    Label2.Caption = "Преобразованный массив:" + Chr(13)
    n = InputBox("Введите размерность массива: ")

    'Вывод исходного массива на Label1
    For i = 1 To n
        a(i) = CInt(Rnd() * 20 - 10)
        Label1.Caption = Label1.Caption + CStr(a(i)) + " "
    Next i

    'Сортировка
    flag = InputBox("Как вы хотите отсортировать данный массив?" +Chr(13) + "1. По возрастанию" + Chr(13) + "2.По убыванию")
    Select Case flag

        Case 1
            For i = 1 To n
                For j = i + 1 To n - 1
                    If (a(i) > a(j)) Then
                        buf = a(i)
                        a(i) = a(j)
                        a(j) = buf
                    End If
                Next j
            Next i

        Case 2
            For i = 1 To n
                For j = i + 1 To n - 1
                    If (a(i) < a(j)) Then
                        buf = a(i)
                        a(i) = a(j)
                        a(j) = buf
                    End If
                Next j
            Next i

    End Select

    For i = 1 To n
        Label2.Caption = Label2.Caption + CStr(a(i)) + " "
    Next i

End Sub
