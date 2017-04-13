Sub Main()
    Dim a(100, 100), sum, i, j, n, kmin, kmax, min, max, scal As Integer
    Dim flag As Boolean

    n = InputBox("Введите размерность квадратной матрицы:")

    Randomize
    For i = 1 To n
        Selection.TypeParagraph
        For j = 1 To n
            a(i, j) = CInt(Rnd() * 100 - 50)
            Selection.TypeText (a(i, j) & Chr(9))
        Next j
    Next i

    'Если k строка совпадаает с k столбцом
    Selection.TypeParagraph
    For i = 1 To n
        flag = True
        For j = 1 To n
            If (a(i, j) <> a(j, i)) Then
                flag = False
                Exit For
            End If
        Next j
        If (flag) Then
            Selection.TypeText (CStr(i) + " ")
        End If
    Next i

    'Сумма элементов в тех строках, где есть хоть одно отрицательное число
    Selection.TypeParagraph
    For i = 1 To n
        flag = False
        For j = 1 To n
            If (a(i, j) < 0) Then
                flag = True
            End If
        Next j
        If (flag) Then
            sum = 0
            For j = 1 To n
                sum = sum + a(i, j)
            Next j
            Selection.TypeText ("Сумма строки №" + CStr(i) + " " + CStr(sum))
            Selection.TypeParagraph
        End If
    Next i

    'Скалярное произведение строки с наибольшим элементом на столбец с наименьшим
    Selection.TypeParagraph
    scal = 1
    min = a(0, 0)
    max = min
    For i = 1 To n
        For j = 1 To n
            If (a(i, j) < min) Then
                min = a(i, j)
                kmin = j
            End If

            If (a(i, j) > max) Then
                max = a(i, j)
                kmax = i
            End If
        Next j
    Next i

    For i = 1 To n
        scal = scal + a(kmax, i) * a(i, kmin)
    Next i
    Selection.TypeText ("Скалярное произведение строки  №" + CStr(kmax) + " и столбца №" + CStr(kmin) + " = " + CStr(scal))
End Sub
