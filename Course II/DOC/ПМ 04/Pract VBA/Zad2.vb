Sub Main()
    Dim a(100, 100), b(100), max, i, j, m, n As Integer
    Dim s, sumstring As String

        n = InputBox("Введите кол-во строк:")
        m = InputBox("Введите кол-во столбцов:")

    Randomize
    For i = 1 To n
        b(i) = 0
        max = -99999
        Selection.TypeParagraph
        For j = 1 To m
            a(i, j) = CInt(Rnd() * 100 - 50)
            Selection.TypeText (a(i, j) & Chr(9))
            If (a(i, j) > max) Then
                max = a(i, j)
            End If
        Next j
        b(i) = max
    Next i

    Selection.TypeText (Chr(13) + "Максимальные в строке: " + Chr(13))
    'Вывод сумм строк и преобразование в квадраты
    For i = 1 To n
        Selection.TypeText (CStr(i) + ". " + CStr(b(i)) + Chr(13))
    Next i

    Selection.TypeText ("Квадраты: " + Chr(13))
    'Красивый вывод квадратов
    For i = 1 To n
        b(i) = b(i) ^ 2
        Selection.TypeText (CStr(i) + ". " + CStr(b(i)) + Chr(13))
    Next i

End Sub
