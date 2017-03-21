Private Sub CommandButton1_Click()
    Dim a(100), b(100), i, j, k, n, p, index1, SNchet, Schet, KNchet, Kchet, index2, buf, mult As Integer
    Dim srednchet, sredchet As Double

    KOTlen = TextBox1.TextLength
    n = KOTlen / 2
    'Читаем данные с TextBox
    For i = 0 To n
        a(i) = Split(TextBox1.Text, " ")(i)
    Next i

    'Ищем первый нулевой элемент
    For i = 0 To n
        If (a(i) = 0) Then
            index1 = i
            Exit For
        End If
    Next i

    'Ищем второй нулевой элемент
    For i = 0 To n
        If (a(i) = 0) Then
            If (index1 <> i) Then
                index2 = i
                Exit For
            End If
        End If
    Next i

    'Узнаем произведение
    mult = 1
    For i = index1 + 1 To index2 - 1
        mult = mult * a(i)
    Next i

    Label1.Caption = "Произведение между первым и вторым нулевыми элементами: " & mult

    'Узнаем сред. арифметическое четных и нечетных
    Kchet = 0
    KNchet = 0
    Schet = 0
    SNchet = 0
     For i = 0 To n
        If ((a(i) Mod 2) = 0) Then
            Kchet = Kchet + 1
            Schet = Schet + a(i)
        End If
        If ((a(i) Mod 2) = 1) Then
            KNchet = KNchet + 1
            SNchet = SNchet + a(i)
        End If
     Next i

    srednchet = SNchet / KNchet
    sredchet = Schet / Kchet

   Label1.Caption = Label1.Caption + Chr(13) + "Сред. ариф. четных элементов: " & CStr(sredchet) + Chr(13) + "Сред. ариф. нечетных элементов: " & CStr(srednchet)

   'Занимаемся преобразованием массива
   k = 0
   j = 0

   For i = 0 To n
        p = i Mod 2
        If (p = 0) Then
            b(j) = a(i)
            j = j + 1
            k = k + 1
            a(i) = 0
        End If
    Next i


     For i = 0 To n
        If (a(i) <> 0) Then
           b(k) = a(i)
           k = k + 1
        End If
    Next i

    Label1.Caption = Label1.Caption + Chr(13) + "Отсортированный массив:" + Chr(13) + "["

    For i = 0 To n
       Label1.Caption = Label1.Caption + CStr(b(i)) + " "
    Next i
    Label1.Caption = Label1.Caption + "]"

End Sub
