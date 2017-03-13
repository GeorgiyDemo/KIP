Sub DEMKA()

    Dim i, j, min, minindex, sum As Integer
    Dim buf As Double
    
    Range("A1:G8").Copy
    Sheets.Add After:=ActiveSheet
    ActiveSheet.Paste
    
    'Заполняем таблицу товаров за 6 лет
    
    Cells(10, 1).Value = "Общее кол-во товаров"
    Cells(10, 4).Value = "Общий доход от товаров"
    Cells(10, 7).Value = "Наименьший доход"
    
    Cells(11, 7).Value = "Кол-во"
    Cells(11, 8).Value = "Доход"
    
    Range("A1:G1").Copy
    Range("I1:N1").Select
    ActiveSheet.Paste
    
    'Общее кол-во товаров за 6 лет
    For i = 2 To 8
    Cells(i + 9, 1).Value = "товар " & i - 1
        For j = 2 To 7
            sum = sum + Cells(i, j).Value
        Next j
        Cells(i + 9, 2).Value = sum
        sum = 0
    Next i
    
    'Узнаем доход от товаров за каждый год
    For i = 2 To 8
        Cells(i, 9).Value = "товар " & i - 1
        For j = 2 To 7
            buf = Cells(i, j).Value
            If (Cells(i, j) >= 200) Then
                buf = buf * (100 + 3) / 100
            ElseIf ((Cells(i, j) > 123) And (Cells(i, j) < 200)) Then
                buf = buf * (100 + 10) / 100
             ElseIf (Cells(i, j) < 123) Then
                buf = buf * (100 + 25) / 100
           End If
            Cells(i, j + 8).Value = buf
        Next j
    Next i
    
    'Общий доход от товаров за 6 лет
    For i = 2 To 8
    Cells(i + 9, 4).Value = "товар " & i - 1
        For j = 10 To 16
            sum = sum + Cells(i, j).Value
        Next j
        Cells(i + 9, 5).Value = sum
        sum = 0
    Next i
    
    'Наименьший доход за 6 лет
    min = Cells(11, 5).Value
    For i = 12 To 17
        If min > Cells(i, 5).Value Then
            minindex = i
            min = Cells(i, 5).Value
        End If
    Next i
    
    Cells(12, 7).Value = Cells(minindex, 2).Value
    Cells(12, 8).Value = Cells(minindex, 5).Value
    
End Sub