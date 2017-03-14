Sub Yan()
    Dim i, j, sum, smax, t1, p1, b1 As Integer
    Dim buf As Double
    Dim smaxname As String

    Range("A1:F10").Copy
    Sheets.Add After:=ActiveSheet
    ActiveSheet.Paste

    'Базовое оформление таблицы
    Cells(12, 1).Value = "Начисление отпускных"
    Cells(12, 4).Value = "Профессия"
    Cells(12, 5).Value = "Кол-во"
    Cells(13, 4).Value = "Техник"
    Cells(14, 4).Value = "Программист"
    Cells(15, 4).Value = "Бухгалтер"
    Cells(17, 4).Value = "Макс. стаж:"
    Range("A2:A10").Copy
    Range("A13:A21").Select
    ActiveSheet.Paste

    
    'Вычисляем начисление отпускных
    smax = 0
    For i = 2 To 10
        sum = 0
        sum = (55 / 100) * Cells(i, 6).Value
        If (Cells(i, 3).Value < 5) Then
            sum = sum + ((5 / 100) * Cells(i, 6).Value)
        End If
        If (Cells(i, 3).Value >= 5) And (Cells(i, 3).Value < 11) Then
            sum = sum + ((10 / 100) * Cells(i, 6).Value)
        End If
        If (Cells(i, 3).Value > 10) Then
            If (Cells(i, 3).Value > smax) Then
                'Одновременно чекаем макс стаж
                smax = Cells(i, 3).Value
                smaxname = Cells(i, 1).Value
            End If
            sum = sum + ((15 / 100) * Cells(i, 6).Value)
        End If
    Cells(i + 11, 2).Value = sum
    Next i

    'Считаем кол-во профессий
    t1 = 0
    p1 = 0
    b1 = 0
    For i = 2 To 10
        If (Cells(i, 5).Value = "техник") Then
            t1 = t1 + 1
        End If
        If (Cells(i, 5).Value = "программист") Then
            p1 = p1 + 1
        End If
        If (Cells(i, 5).Value = "бухгалтер") Then
            b1 = b1 + 1
        End If
    Next i

    'Выводим все, что можно и нельзя
    Cells(13, 5).Value = t1
    Cells(14, 5).Value = p1
    Cells(15, 5).Value = b1
    Cells(18, 4).Value = smaxname
End Sub
