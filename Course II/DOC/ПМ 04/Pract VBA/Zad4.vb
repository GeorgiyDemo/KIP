Option Explicit

Dim A(100), c(100), n, i, ksort, j, b, buf, kol, max, min, indexmin, knul, kp, ko, sumD, kD, q, index1D, index2D, indexmax, sumB, kot, p, prozB, sum(100) As Integer
Dim sred As Double

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

    If (CheckBox3.Value = True) Then
        Call third
    End If

    If (CheckBox4.Value = True) Then
        Call forth
    End If

    If (CheckBox5.Value = True) Then
        Call fifth
    End If

    If (CheckBox6.Value = True) Then
        Call sixth
    End If

    If (CheckBox7.Value = True) Then
        Call seventh
    End If

    If (CheckBox8.Value = True) Then
        Call sort
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
    Label1.Caption = Label1.Caption + Chr(13) + "Кол-во положительных элементов: " + CStr(kp) + Chr(13) + "Кол-во нулевых элементов: " + CStr(knul) + Chr(13) + "Кол-во отрицательных элементов: " + CStr(ko) + Chr(13)
    End Sub
    'Сумму элементов на четных местах и произведение на нечетных
    Sub third()
        sumB = 0
        prozB = 1
        For i = 0 To n
         If (i Mod 2 = 0) Then
            sumB = sumB + A(i)
        End If
        If (i Mod 2 = 1) Then
            prozB = prozB * A(i)
        End If
        Next i
    Label1.Caption = Label1.Caption + Chr(13) + "Сумма элементов на четных местах: " + CStr(sumB) + Chr(13) + "Произведение элементов на нечетных местах: " + CStr(prozB) + Chr(13)
    End Sub
    'Количество повторяющихся элементов и их индексы
    Sub forth()
        kol = 0
        For i = 0 To n
            For j = i + 1 To n
                If (A(i) = A(j)) Then
                    kol = kol + 1
                End If
            Next j
        Next i
        kol = kol * 2
        Label1.Caption = Label1.Caption + Chr(13) + "Кол-во повторяющихся элементов: " + CStr(kol)
        For i = 0 To n
            For j = i + 1 To n
                If (A(i) = A(j)) Then
                    Label1.Caption = Label1.Caption + Chr(13) + "Повторяется элемент: " + CStr(A(i))
                    Label1.Caption = Label1.Caption + " (i=" + CStr(i)
                    Label1.Caption = Label1.Caption + "  j=" + CStr(j) + ")"
                End If
            Next j
        Next i

    End Sub

    'Среднее арифметическое элементов между первым и последним положительными элементами
    Sub fifth()
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
    sred = sumD / kD
    Label1.Caption = Label1.Caption + Chr(13) + "Среднее ариф. между первым и последним положительными элементами: " + CStr(sred) + Chr(13)
    End Sub

    'Элементы и их индексы, которые меньше числа введенного с клавиатуры
    Sub sixth()
        Label1.Caption = Label1.Caption + Chr(13) + "Элементы и индексы меньше числа, введенного с клавиатуры: "
        'Ввод числа
        kot = InputBox("Введите число:")
        'Цикл
        For i = 0 To n
            If (A(i) < CInt(kot)) And (i < CInt(kot)) Then
                Label1.Caption = Label1.Caption + CStr(A(i)) + " "
            End If
        Next i
    Label1.Caption = Label1.Caption + Chr(13)
    End Sub

    'Сдвиг на p элементов вправо или влево
    Sub seventh()
    ' ksort = InputBox("Куда смещаемся??" + Chr(13) + "1. Налево" + Chr(13) + "2. Направо")
    '    ksort = CInt(ksort)
    '    Select Case ksort
    '        Case 1
    '           Call more
    '       Case 2
    '            Call less
    '
    '    End Select
    '
        Label1.Caption = Label1.Caption + Chr(13)
        p = InputBox("На сколько смещаемся?")
        If (p < 0) Then
            For j = 1 To Abs(p)
                b = A(1)
                For i = 1 To n - 1
                    A(i) = A(i + 1)
                Next i
                A(n) = b

            Next j
        End If
        If (p >= 0) Then
            For j = 1 To p
                b = A(n)
                For i = n To 2 Step -1
                    A(i) = A(i - 1)
                Next i
            A(1) = b
            Next j
        End If

    For i = 0 To UBound(A)
        Label1.Caption = Label1.Caption + CStr(A(i)) + " "
    Next i
    Label1.Caption = Label1.Caption + Chr(13)

    End Sub

     Sub more()
        'Занимаемся преобразованием массива по возрастанию
        Label1.Caption = Label1.Caption + Chr(13) + "Сортировка массива по возрастанию: " + Chr(13) + "["
          For i = 0 To n - 1
              For j = i + 1 To n
                   If A(j) < A(i) Then
                      buf = A(i)
                      A(i) = A(j)
                      A(j) = buf
                   End If
                Next j
          Next i
        For i = 0 To n
             Label1.Caption = Label1.Caption + CStr(A(i)) + " "
        Next i
        Label1.Caption = Label1.Caption + "]" + Chr(13)

         End Sub
     Sub less()
        'Занимаемся преобразованием массива по убыванию
        Label1.Caption = Label1.Caption + Chr(13) + "Сортировка массива по убыванию: " + Chr(13) + "["
          For i = 0 To n - 1
              For j = i + 1 To n
                   If A(j) > A(i) Then
                      buf = A(i)
                      A(i) = A(j)
                      A(j) = buf
                   End If
                Next j
          Next i
        For i = 0 To n
             Label1.Caption = Label1.Caption + CStr(A(i)) + " "
        Next i
        Label1.Caption = Label1.Caption + "]" + Chr(13)
        End Sub
     Sub sort()
     'Выбор массива по возрастанию/убыванию
     ksort = InputBox("Как вы хотите отсортировать массив?" + Chr(13) + "1. По возрастанию" + Chr(13) + "2. По убыванию")
     ksort = CInt(ksort)
     Select Case ksort
            Case 1
               Call more
            Case 2
                Call less

        End Select

    End Sub
