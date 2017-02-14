Sub Шаблон()
'
' Шаблон Макрос
'

'
    Range("A3").Select
    ActiveCell.FormulaR1C1 = "Район"
    Range("B3").Select
    ActiveCell.FormulaR1C1 = "Интервал глубин, м"
    Range("C3").Select
    ActiveCell.FormulaR1C1 = "М-1"
    Range("A1").Select
    
    Range("A1:D1").Select
    With Selection
        .HorizontalAlignment = xlCenter
        .VerticalAlignment = xlBottom
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .ShrinkToFit = False
        .MergeCells = False
    End With
    Selection.Merge
    Range("A2:D2").Select
    Range("D2").Activate
    With Selection
        .HorizontalAlignment = xlCenter
        .VerticalAlignment = xlBottom
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .ShrinkToFit = False
        .MergeCells = False
    End With
    Selection.Merge
    Range("A3:C8").Select
    Selection.Borders(xlDiagonalDown).LineStyle = xlNone
    Selection.Borders(xlDiagonalUp).LineStyle = xlNone
    With Selection.Borders(xlEdgeLeft)
        .LineStyle = xlContinuous
        .Weight = xlThin
        .ColorIndex = xlAutomatic
    End With
    With Selection.Borders(xlEdgeTop)
        .LineStyle = xlContinuous
        .Weight = xlThin
        .ColorIndex = xlAutomatic
    End With
    With Selection.Borders(xlEdgeBottom)
        .LineStyle = xlContinuous
        .Weight = xlThin
        .ColorIndex = xlAutomatic
    End With
    With Selection.Borders(xlEdgeRight)
        .LineStyle = xlContinuous
        .Weight = xlThin
        .ColorIndex = xlAutomatic
    End With
    With Selection.Borders(xlInsideVertical)
        .LineStyle = xlContinuous
        .Weight = xlThin
        .ColorIndex = xlAutomatic
    End With
    With Selection.Borders(xlInsideHorizontal)
        .LineStyle = xlContinuous
        .Weight = xlThin
        .ColorIndex = xlAutomatic
    End With
    With Selection.Font
        .Name = "Calibri"
        .Size = 14
        .Strikethrough = False
        .Superscript = False
        .Subscript = False
        .OutlineFont = False
        .Shadow = False
        .Underline = xlUnderlineStyleNone
        .ThemeColor = xlThemeColorLight1
        .TintAndShade = 0
        .ThemeFont = xlThemeFontMinor
    End With
    With Selection.Font
        .Name = "Times New Roman"
        .Size = 14
        .Strikethrough = False
        .Superscript = False
        .Subscript = False
        .OutlineFont = False
        .Shadow = False
        .Underline = xlUnderlineStyleNone
        .ThemeColor = xlThemeColorLight1
        .TintAndShade = 0
        .ThemeFont = xlThemeFontNone
    End With
    Range("A1:D2").Select
    With Selection.Font
        .Name = "Times New Roman"
        .Size = 12
        .Strikethrough = False
        .Superscript = False
        .Subscript = False
        .OutlineFont = False
        .Shadow = False
        .Underline = xlUnderlineStyleNone
        .ThemeColor = xlThemeColorLight1
        .TintAndShade = 0
        .ThemeFont = xlThemeFontNone
    End With
    With Selection.Font
        .Name = "Times New Roman"
        .Size = 14
        .Strikethrough = False
        .Superscript = False
        .Subscript = False
        .OutlineFont = False
        .Shadow = False
        .Underline = xlUnderlineStyleNone
        .ThemeColor = xlThemeColorLight1
        .TintAndShade = 0
        .ThemeFont = xlThemeFontNone
    End With
    Selection.Font.Bold = True
    Range("A1:D1").Select
    With Selection
        .HorizontalAlignment = xlGeneral
        .VerticalAlignment = xlBottom
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .ShrinkToFit = False
        .MergeCells = True
    End With
    Selection.Merge True
    Range("A2:D2").Select
    With Selection
        .HorizontalAlignment = xlGeneral
        .VerticalAlignment = xlBottom
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .ShrinkToFit = False
        .MergeCells = True
    End With
    Selection.Merge True
    Range("A1:C2").Select
    Range("C2").Activate
    With Selection
        .HorizontalAlignment = xlCenter
        .VerticalAlignment = xlBottom
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .ShrinkToFit = False
        .MergeCells = False
    End With
    Range("A1:C2").Select
    With Selection
        .HorizontalAlignment = xlCenter
        .VerticalAlignment = xlBottom
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .ShrinkToFit = False
        .MergeCells = False
    End With
    Selection.Merge
    With Selection
        .HorizontalAlignment = xlGeneral
        .VerticalAlignment = xlBottom
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .ShrinkToFit = False
        .MergeCells = True
    End With
    Selection.Merge True
    Range("A1:C1").Select
    Range("C1").Activate
    With Selection
        .HorizontalAlignment = xlCenter
        .VerticalAlignment = xlBottom
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .ShrinkToFit = False
        .MergeCells = False
    End With
    Selection.Merge
    Range("A1").Select
    ActiveCell.FormulaR1C1 = "Значения показателя вертикального ослабления"
    Range("A2").Select
    ActiveCell.FormulaR1C1 = "для открытых океанских районов"
    Range("A2:C2").Select
    Range("C2").Activate
    With Selection
        .HorizontalAlignment = xlCenter
        .VerticalAlignment = xlBottom
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .ShrinkToFit = False
        .MergeCells = False
    End With
    Selection.Merge
    Range("G5").Select
End Sub

Sub Цвета()
'
' Цвета Макрос
'

'
    Range("A3:A8").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.599993896298105)"
    Range("B3:B8").Select
    ExecuteExcel4Macro "PATTERNS(1,0,12611584,TRUE,2,3,0,0)"
    Range("C3:C8").Select
    ExecuteExcel4Macro "PATTERNS(1,0,15773696,TRUE,2,3,0,0)"
    Range("D1").Select
End Sub
Sub Задание2()
'
' Задание2 Макрос
'

'
    Range("A1").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.799981688894314)"
    Range("B1").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.799981688894314)"
    Range("C1").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.799981688894314)"
    Range("A2").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.599993896298105)"
    Range("B2").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.599993896298105)"
    Range("C2").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.599993896298105)"
    Range("A3").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.399975585192419)"
    Range("B3").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.399975585192419)"
    Range("C3").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.399975585192419)"
    Range("A4").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,-0.249977111117893)"
    Range("B4").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,-0.249977111117893)"
    Range("C4").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,-0.249977111117893)"
    Range("A5").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,-0.249977111117893)"
    Range("B5").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,-0.249977111117893)"
    Range("C5").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,-0.249977111117893)"
    Range("A6").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.399975585192419)"
    Range("B6").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.399975585192419)"
    Range("C6").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.399975585192419)"
    Range("A7").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.599993896298105)"
    Range("B7").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.599993896298105)"
    Range("C7").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.599993896298105)"
    Range("C8").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.799981688894314)"
    Range("B8").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.799981688894314)"
    Range("A8").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.799981688894314)"
    Range("A9").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.799981688894314)"
    Range("B9").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.799981688894314)"
    Range("C9").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.799981688894314)"
    Range("C10").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.599993896298105)"
    Range("B10").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.599993896298105)"
    Range("A10").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.599993896298105)"
    Range("A11").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.399975585192419)"
    Range("B11").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.399975585192419)"
    Range("C11").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.399975585192419)"
    Range("C12").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,-0.249977111117893)"
    Range("B12").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,-0.249977111117893)"
    Range("A12").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,-0.249977111117893)"
    Range("A13").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,-0.249977111117893)"
    Range("B13").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,-0.249977111117893)"
    Range("C13").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,-0.249977111117893)"
    Range("C14").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.399975585192419)"
    Range("B14").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.399975585192419)"
    Range("A14").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.399975585192419)"
    Range("A15").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.599993896298105)"
    Range("B15").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.599993896298105)"
    Range("C15").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.599993896298105)"
    Range("C16").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.599993896298105)"
    Range("C16").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.799981688894314)"
    Range("B16").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.799981688894314)"
    Range("A16").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.799981688894314)"
    Range("A17").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.599993896298105)"
    Range("B17").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.599993896298105)"
    Range("C17").Select
    ExecuteExcel4Macro "PATTERNS(1,0,5,TRUE,2,4,0,0.599993896298105)"
    Range("F3").Select
    Range("B1:C17").Select
    ActiveSheet.Shapes.AddChart2(216, xlBarClustered).Select
    ActiveChart.SetSourceData Source:=Range("Лист6!$B$1:$C$17")
    Range("D19").Select
End Sub
