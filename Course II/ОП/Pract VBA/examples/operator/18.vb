'Написать программу на VBA, которая позволяет в одномерном массиве осуществлять
'поиск чисел и их индексы, которые больше по модулю числа, введенного с клавиатуры

Private Sub CommandButton1_Click()

    Dim a(100), KOT, n, i As Integer

    'Ввод исходных данных
    Label1.Caption = "Исходный массив: " + Chr(13)
    KOT = CInt(InputBox("Введите число:"))
    Label2.Caption = "Числа, больше " + CStr(KOT) + " по модулю:" +Chr(13)
    n = CInt(InputBox("Введите размерность массива:"))

    'Вывод исходного массива на Label1, вывод чисел больше по модулю на Label2
    For i = 1 To n
        a(i) = CInt(Rnd() * 20 - 10)
        Label1.Caption = Label1.Caption + CStr(a(i)) + " "

        If (Abs(a(i)) > KOT) Then
            Label2.Caption = Label2.Caption + CStr(a(i)) + "(" + CStr(i)+ ")" + " "
        End If

    Next i

End Sub
