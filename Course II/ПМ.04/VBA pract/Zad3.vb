Private Sub CommandButton1_Click()
    Dim a(100), i, j, max, min, indexmax, indexmin, Kmax, Kmin, Smax, Smin As Integer
    Dim r1, r2 As Double

    Label1.Caption = ""
    'Читаем данные с TextBox
    n = Split(TextBox1.Text, " ")
    For i = 0 To UBound(n)
        a(i) = Val(n(i))
    Next i

    'Индексы максимальных и минимальных элементов
    max = a(0)
    min = a(0)
    For i = 0 To UBound(n)

        If (a(i) > max) Then
            indexmax = i
            max = a(i)
        End If

        If (a(i) < min) Then
            indexmin = i
            min = a(i)
        End If
    Next i

    'Узнаем сред. арифметическое положительных и отрицательных
    Kmin = 0
    Kmax = 0
    Smin = 0
    Smax = 0
     For i = 0 To UBound(n)

        If (a(i) > 0) Then
            Kmax = Kmax + 1
            Smax = Smax + a(i)
        End If

        If (a(i) < 0) Then
            Kmin = Kmin + 1
            Smin = Smin + a(i)
        End If
     Next i

    r1 = Smin / Kmin
    r2 = Smax / Kmax

   'Вывод на форму
   Label1.Caption = Label1.Caption + Chr(13) + "Сред. ариф. положительных элементов: " & CStr(r2) + Chr(13) + "Сред. ариф. отрицательных элементов:" & CStr(r1)
   Label1.Caption = Label1.Caption + Chr(13) + "Максимальный элемент " + CStr(max) + " с индексом " + CStr(indexmax + 1) + Chr(13) + "Минимальный элемент " + CStr(min) + " с индексом " + CStr(indexmin + 1)
End Sub
