Sub Main()
    Dim i, j, chetverkakol, three, four, five As Integer
    Dim chetverkaflag, troikaflag As Boolean
    Dim name As String
    
    three = 0
    four = 0
    five = 0
    
    Range("A1:J10").Copy
    Sheets.Add After:=ActiveSheet
    ActiveSheet.Paste
    
    Cells(12, 2).Value = "Стипендия"
    Cells(23, 1).Value = "Отличники"
    Cells(24, 1).Value = "Хорошисты"
    Cells(25, 1).Value = "Троечники"
    Cells(22, 1).Value = "Тип"
    Cells(22, 2).Value = "Кол-во"
    Cells(27, 1).Value = Cells(23, 1).Value
    
    'Заполняем табличку отличников
    Range("A1").Copy
    Range("A12").Select
    ActiveSheet.Paste
        
     For i = 3 To 10
        Cells(i + 10, 1).Value = Cells(i, 1).Value
     Next i
     
     For i = 3 To 10
     
        chetverkaflag = False
        troikaflag = False
        chetverkakol = 0
        For j = 2 To 10
            If (Cells(i, j) = 3) Then
                troikaflag = True
            End If
            If (Cells(i, j) = 4) Then
                chetverkaflag = True
                chetverkakol = chetverkakol + 1
            End If
        Next j
        
         If (troikaflag = True) Then
            three = three + 1
            Cells(i + 10, 2).Value = 0
         Else
            four = four + 1
            Cells(i + 10, 2).Value = 1200
         End If
         
        If ((chetverkakol < 3) And (troikaflag = False)) Then
            Cells(i + 10, 2).Value = 1800
        End If
        
        If ((chetverkaflag = False) And (chetverkakol < 3) And (troikaflag = False)) Then
            name = Cells(i, 1).Value
            Cells(i + 10, 2).Value = 2500
            five = five + 1
        End If
        Next i
        
        four = four - five
        Cells(23, 2).Value = five
        Cells(24, 2).Value = four
        Cells(25, 2).Value = three
        Cells(28, 1).Value = name
End Sub

