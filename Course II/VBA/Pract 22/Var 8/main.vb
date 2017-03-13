Sub Main()

    Dim i, j, sum, MIN, MAX, RARfix, MOY_RAYON, KvartalSum As Integer
    Dim MAXCountry, MINCountry As String

    Range("A1:M7").Copy
    Sheets.Add After:=ActiveSheet
    ActiveSheet.Paste

    Range("A1:A7").Copy
    Range("A9:A16").Select
    ActiveSheet.Paste

    Cells(1, 14).Value = "Îáùåå êîë-âî ïóòåâîê"
    Cells(17, 1).Value = "Ìàêñ êîë-âî ïóòåâîê"
    Cells(18, 1).Value = "Ìèí êîë-âî ïóòåâîê"

    For i = 2 To 5
        Cells(9, i).Value = i - 1 & " êâàðòàë"
    Next i
    For i = 7 To 10
        Cells(9, i).Value = i - 6 & " êâàðòàë"
    Next i

    For i = 2 To 7
        For j = 2 To 14
            sum = sum + Cells(i, j).Value
        Next j
        Cells(i, 14).Value = sum
        sum = 0
    Next i

    For i = 2 To 7
    RARfix = 2
    MOY_RAYON = 0
    KvartalSum = 0
        For j = 2 To 14
            KvartalSum = KvartalSum + Cells(i, j).Value
            MOY_RAYON = MOY_RAYON + 1
            If MOY_RAYON = 3 Then
                Cells(i + 8, RARfix).Value = KvartalSum
                RARfix = RARfix + 1
                MOY_RAYON = 0
                KvartalSum = 0
            End If
        Next j
    Next i
    
    For i = 10 To 15
        For j = 2 To 5

            If (j = 2) Then
                Cells(i, j + 5).Value = Cells(i, j).Value + (Cells(i, j).Value * 10 / 100)
            End If
            If ((j = 3) Or (j = 5)) Then
                Cells(i, j + 5).Value = Cells(i, j).Value + (Cells(i, j).Value * 20 / 100)
            End If
            If (j = 4) Then
                Cells(i, j + 5).Value = Cells(i, j).Value + (Cells(i, j).Value * 45 / 100)
            End If

        Next j
    Next i

    MIN = Cells(2, 14).Value
    MAX = MIN
    For i = 2 To 7
     If (Cells(i, 14).Value < MIN) Then
        MIN = Cells(i, 14).Value
        MINCountry = Cells(i, 1).Value
     End If
     If (Cells(i, 14).Value > MAX) Then
        MAX = Cells(i, 14).Value
        MAXCountry = Cells(i, 1).Value
     End If
    Next i

    Cells(17, 4).Value = MAXCountry
    Cells(17, 5).Value = MAX
    Cells(18, 4).Value = MINCountry
    Cells(18, 5).Value = MIN

End Sub
