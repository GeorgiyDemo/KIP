'Фикс, без него никак
Option Explicit

'Создание поля игры
Sub CreateCatGame()

    'Цвет поля (серый)
    Const MAIN_CAT_COLOR As Long = rgbDarkSlateGrey
    
    'Красивенькое оформление поля
    With DemkaGame
        .Name = "Игра"
        Columns("B:Y").ColumnWidth = 2.14
        Columns("A").ColumnWidth = 13
        Columns("Z").ColumnWidth = 13
        Rows(1).RowHeight = 100
        Rows(24).RowHeight = 100
        Range("A1:Z1").Merge
        Range("A1").Interior.Color = MAIN_CAT_COLOR
        Range("A24:Z24").Merge
        Range("A24").Interior.Color = MAIN_CAT_COLOR
        Range("A2:A23").Merge
        Range("A2").Interior.Color = MAIN_CAT_COLOR
        Range("Z2:Z23").Merge
        Range("z2").Interior.Color = MAIN_CAT_COLOR
        Range("B2").Select
    End With
    
End Sub

'Псевдоокружная трасса
    Sub CircleGenerator()
    
    Dim KOMUK As Range
    Dim i As Integer
    Range("J11:P14").Interior.ColorIndex = 13
    For Each KOMUK In Range("J9:P9")
        i = Application.WorksheetFunction.RandBetween(0, 1)
        KOMUK.Offset(i).Interior.ColorIndex = 13
    Next
    For Each KOMUK In Range("J13:P13")
        i = Application.WorksheetFunction.RandBetween(-1, 0)
        KOMUK.Offset(i).Interior.ColorIndex = 13
    Next
    
    For Each KOMUK In Range("H11:H14")
        i = Application.WorksheetFunction.RandBetween(0, 1)
        KOMUK.Offset(, i).Interior.ColorIndex = 13
    Next
    For Each KOMUK In Range("R11:R14")
        i = Application.WorksheetFunction.RandBetween(-1, 0)
        KOMUK.Offset(, i).Interior.ColorIndex = 13
    Next
    
    'Заполнение
    For Each KOMUK In Range("J9:P9")
        If KOMUK.Interior.ColorIndex = 13 Then
            KOMUK.Offset(1).Interior.ColorIndex = 13
        End If
    Next
    For Each KOMUK In Range("J13:P13")
        If KOMUK.Interior.ColorIndex = 13 Then
            KOMUK.Offset(-1).Interior.ColorIndex = 13
        End If
    Next
    For Each KOMUK In Range("H11:H14")
        If KOMUK.Interior.ColorIndex = 13 Then
            KOMUK.Offset(, 1).Interior.ColorIndex = 13
        End If
    Next
    For Each KOMUK In Range("R11:R14")
        If KOMUK.Interior.ColorIndex = 13 Then
            KOMUK.Offset(, -1).Interior.ColorIndex = 13
        End If
    Next
    
    'Начало и конец заезда
    With Range("M17:M20").Interior
            .Pattern = xlUp
            .PatternColorIndex = xlAutomatic
            .ColorIndex = xlAutomatic
            .TintAndShade = 0
            .PatternTintAndShade = 0
    End With
    Range("N19").Interior.ColorIndex = 3
    Range("N19") = "2"
    Range("N20").Interior.ColorIndex = 8
    Range("N20") = "1"
    
End Sub

Sub SpeedFix()

    'Костыльно храним переменные в ячейках, действительно, а зачем?
    Range("A100") = 0
    Range("A101") = 0
    Range("A102") = 20
    Range("A103") = 14
    Range("A200") = 0
    Range("A201") = 0
    Range("A202") = 19
    Range("A203") = 14
    
End Sub

'Всем диапазон из котиков и добра
Sub OuterOwl()
    
    Dim i As Integer
    Dim KOMUK As Range
        For Each KOMUK In Range("B2:Y2")
            i = Application.WorksheetFunction.RandBetween(0, 2)
            KOMUK.Offset(i, 0).Interior.ColorIndex = 13
        Next
        For Each KOMUK In Range("b23:Y23")
            i = Application.WorksheetFunction.RandBetween(-2, 0)
            KOMUK.Offset(i, 0).Interior.ColorIndex = 13
        Next
        For Each KOMUK In Range("B5:B20")
            i = Application.WorksheetFunction.RandBetween(0, 2)
            KOMUK.Offset(0, i).Interior.ColorIndex = 13
        Next
        For Each KOMUK In Range("Y5:Y20")
            i = Application.WorksheetFunction.RandBetween(-2, 0)
            KOMUK.Offset(0, i).Interior.ColorIndex = 13
        Next
        For Each KOMUK In Range("B4:Y4")
            If KOMUK.Interior.ColorIndex = 13 Then
                KOMUK.Offset(-1).Interior.ColorIndex = 13
                KOMUK.Offset(-2).Interior.ColorIndex = 13
            End If
        Next
        For Each KOMUK In Range("B3:Y3")
            If KOMUK.Interior.ColorIndex = 13 Then
                KOMUK.Offset(-1).Interior.ColorIndex = 13
            End If
        Next
        For Each KOMUK In Range("B21:Y21")
            If KOMUK.Interior.ColorIndex = 13 Then
                KOMUK.Offset(1).Interior.ColorIndex = 13
                KOMUK.Offset(2).Interior.ColorIndex = 13
            End If
        Next
        For Each KOMUK In Range("B22:Y22")
            If KOMUK.Interior.ColorIndex = 13 Then
                KOMUK.Offset(1).Interior.ColorIndex = 13
            End If
        Next
        
        For Each KOMUK In Range("D2:D23")
            If KOMUK.Interior.ColorIndex = 13 Then
                KOMUK.Offset(, -1).Interior.ColorIndex = 13
                KOMUK.Offset(, -2).Interior.ColorIndex = 13
            End If
        Next
        For Each KOMUK In Range("C2:C23")
            If KOMUK.Interior.ColorIndex = 13 Then
                KOMUK.Offset(, -1).Interior.ColorIndex = 13
            End If
        Next
        For Each KOMUK In Range("W2:W23")
            If KOMUK.Interior.ColorIndex = 13 Then
                KOMUK.Offset(, 1).Interior.ColorIndex = 13
                KOMUK.Offset(, 2).Interior.ColorIndex = 13
            End If
        Next
        For Each KOMUK In Range("X2:X23")
            If KOMUK.Interior.ColorIndex = 13 Then
                KOMUK.Offset(, 1).Interior.ColorIndex = 13
            End If
        Next
        
End Sub

'Событие обработки кнопки
Sub Button1_Click()

    MsgBox ("Новая игра? Создаю новую трассу")
    Application.ScreenUpdating = False
    Range("A1:Z24").ClearContents
    Range("A1:Z24").ClearFormats
    CreateCatGame
    OuterOwl
    CircleGenerator
    SpeedFix
    
    Application.ScreenUpdating = True
    GameControl.Show
    
End Sub
