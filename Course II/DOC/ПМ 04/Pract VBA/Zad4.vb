Option Explicit

Dim A(100), n, i, j, buf, max, min, indexmin, knul, kp, ko, indexmax, sumB, prozB, sum(100) As Integer

   Sub CommandButton1_Click()

    n = CInt(TextBox1.Text) - 1
    Label1.Caption = "Исходный массив:" + Chr(13) + "["

    For i = 0 To n
            A(i) = CInt(Rnd() * 100 - 50)
            Label1.Caption = Label1.Caption + CStr(A(i)) + " "
    Next i
    Label1.Caption = Label1.Caption + "]"
    If (CheckBox1.Value = True) Then
        Call first
    End If
    If (CheckBox2.Value = True) Then
        Call second
    End If
    End Sub

    'Индексы максимальных и минимальных элементов
    Sub first()
        max = A(0)
        min = A(0)
        For i = 0 To n
            If (A(i) > max) Then
                indexmax = i
                max = A(i)
            End If
            If (A(i) < min) Then
                indexmin = i
                min = A(i)
            End If
        Next i
    Label1.Caption = Label1.Caption + Chr(13) + "Максимальный элемент " + CStr(max) + " с индексом " + CStr(indexmax + 1) + Chr(13)
    Label1.Caption = Label1.Caption + "Минимальный элемент " + CStr(min) + " с индексом " + CStr(indexmin + 1) + Chr(13)
    End Sub
    'Количество положительных, отрицательных и нулевых элементов
    Sub second()
        knul = 0
        kp = 0
        ko = 0
        For i = 0 To n
            If (A(i) = 0) Then
                knul = knul + 1
            End If
            If (A(i) < 0) Then
                ko = ko + 1
            End If
            If (A(i) > 0) Then
                kp = kp + 1
            End If
        Next i
    Label1.Caption = Label1.Caption + Chr(13) + "Кол-во положительных элементов: " + CStr(kp) + Chr(13) + "Кол-во нулевых элементов: " + CStr(knul) + Chr(13) + "Кол-во отрицательных элементов: " + CStr(ko)
    End Sub
    'Сумму элементов на четных местах и произведение на нечетных
    Sub C()
        sumB = 0
        prozB = 1
        For i = 0 To UBound(n)
         If (i Mod 2 = 0) Then
            sumB = sumB + A(i)
        End If
        If (i Mod 2 = 1) Then
            prozB = prozB * A(i)
        End If
    End Sub
    'Количество повторяющихся элементов и их индексы

    'Среднее арифметическое элементов между первым и последним положительными элементами
    Function D()
        Private sumD, kD, index1D, index2D As Integer
        sumD = 0
        kD = 0
        'Ищем индекс 1 полож. элемента
        For i = 0 To n
            If (A(i) < 0) Then
                index1D = i
                Exit For
            End If
        Next i
        'Ищем индекс 2 полож. элемента с конца
        For i = n To 0 Step -1
            If (A(i) < 0) Then
                index2D = i
                Exit For
            End If
        Next i
        'Вычисляем сред. арифметическое
        For i = index1D + 1 To index2D - 1
            kD = kD + 1
            sumD = sumD + A(i)
        Next i
    D = sumD / kD
    End Function
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
