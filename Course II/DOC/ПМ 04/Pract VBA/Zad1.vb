Sub DEMKA()

    Dim i, j, min, max, fix1, fix2, sum, k As Integer
    Dim namemax, namemin As String
    Dim buf As Double

    Range("A1:H9").Copy
    Sheets.Add After:=ActiveSheet
    ActiveSheet.Paste

    Range("A1:A9").Copy
    Range("A10:A19").Select
    ActiveSheet.Paste

    'Сред. балл и его вычисление
    sum = 0
    k = 0
    Cells(11, 2).Value = "Средний балл по аттестату"
    Cells(11, 5).Value = "Средний балл по экзаменам"
    Cells(11, 8).Value = "Общий сред балл"
    'Аттестат
    For i = 3 To 9
        For j = 2 To 6
            sum = sum + Cells(i, j).Value
            k = k + 1
        Next j
        buf = sum / k
        Cells(i + 9, 2).Value = buf
        sum = 0
        k = 0
    Next i
    'Экзамены
    For i = 3 To 9
        For j = 7 To 8
            sum = sum + Cells(i, j).Value
            k = k + 1
        Next j
        buf = sum / k
        Cells(i + 9, 5).Value = buf
        sum = 0
        k = 0
    Next i
    'Общий сред балл
    For i = 12 To 18
        sum = sum + Cells(i, 2).Value + sum + Cells(i, 5).Value
        buf = sum / 2
        Cells(i, 8).Value = buf
        sum = 0
    Next i
        buf = sum / 2

    'Обработка бюджетников/небюджетников
    Cells(20, 1).Value = "Бюджет"
    Cells(20, 2).Value = "Платная основа"
    fix1 = 21
    fix2 = 21
    For i = 12 To 18
        If (Cells(i, 8).Value >= 8) Then
             Cells(fix2, 1).Value = Cells(i, 1).Value
             fix2 = fix2 + 1
        End If
         If (Cells(i, 8).Value < 8) Then
             Cells(fix1, 2).Value = Cells(i, 1).Value
             fix1 = fix1 + 1
        End If

    Next i

    'Макс/мин
     Cells(21, 5).Value = "Макс. балл"
     Cells(20, 5).Value = "Мин. балл"
     max = Cells(12, 8).Value
     min = max
     For i = 13 To 18

        If (Cells(i, 8).Value < min) Then
            min = Cells(i, 8).Value
            namemin = Cells(i, 1).Value
        End If

        If (Cells(i, 8).Value > max) Then
         max = Cells(i, 8).Value
         namemax = Cells(i, 1).Value
        End If

     Next i

     Cells(20, 6).Value = namemin
     Cells(20, 7).Value = min

     Cells(21, 6).Value = namemax
     Cells(21, 7).Value = max

End Sub
