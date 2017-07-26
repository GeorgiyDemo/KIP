Private Sub btnGo_Click()
    
    'Извините, но иначе никак
    On Error GoTo errHandler
    
    'Иницилизация
    Dim Vx As Integer
    Vx = cmbVx.Value
    Dim Vy As Integer
    Vy = cmbVy.Value
    
    Dim x As Integer
    Dim y As Integer
    Dim intCat As Integer
    Dim MoveCat As Range
    
    If LabelP1.Visible = True Then
        intCat = 1
        Else: intCat = 2
    End If
    
    Select Case intCat
        Case 1
        'Скорость всего процесса
        x = DemkaGame.Range("A100") + Vx
        y = DemkaGame.Range("A101") + Vy
        DemkaGame.Range("A100") = x
        DemkaGame.Range("A101") = y
        
        'Перемещение
        With Cells(Int(CurrentRow.Value), Int(CurrentCol.Value))
            .ClearContents
            .Interior.ColorIndex = xlNone
            'Суть данного метода лучше дже не понимать, но y должен быть перед x
            Set MoveCat = .Offset(-y, x)
        End With
            
                If MoveCat.Interior.ColorIndex = xlNone Then
                    MoveCat = "1"
                    MoveCat.Interior.ColorIndex = 8
                    Range("A102") = MoveCat.Row
                    Range("A103") = MoveCat.Column
                Else: GoTo CheckerFalg
                End If
        
        'Установка формы для след. игрока
        LabelP1.Visible = False
        LabelP2.Visible = True
        CurrentX.Text = Range("A200")
        CurrentY.Text = Range("A201")
        CurrentRow.Text = Range("A202")
        CurrentCol.Text = Range("A203")
        Exit Sub
        
        'Обработка событий с игроком №2
        Case 2
        'Скорость
        x = DemkaGame.Range("A200") + Vx
        y = DemkaGame.Range("A201") + Vy
        DemkaGame.Range("A200") = x
        DemkaGame.Range("A201") = y
        
        'Перемещение
        With Cells(Int(CurrentRow.Value), Int(CurrentCol.Value))
            .ClearContents
            .Interior.ColorIndex = xlNone
            Set MoveCat = .Offset(-y, x)
        End With
            
                If MoveCat.Interior.ColorIndex = xlNone Then
                    MoveCat = "2"
                    MoveCat.Interior.ColorIndex = 3
                    Range("A202") = MoveCat.Row
                    Range("A203") = MoveCat.Column
                Else: GoTo CheckerFalg
                End If
        
        'Передаём форму дальше
        LabelP2.Visible = False
        LabelP1.Visible = True
        CurrentX.Text = Range("A100")
        CurrentY.Text = Range("A101")
        CurrentRow.Text = Range("A102")
        CurrentCol.Text = Range("A103")
        Exit Sub
        End Select
    
    'Победа/Поражение и т д
CheckerFalg:
        If MoveCat.Interior.ColorIndex = xlAutomatic Then
            MsgBox ("Вы выиграли!")
            MoveCat = "1"
            MoveCat.Interior.ColorIndex = 6
        Else: MsgBox ("Машина разбилась, попробуйте снова.")
        End If
        Unload GameControl
        Exit Sub
    
    'Если пользователь дурак-простак
errHandler:
        MsgBox ("Пожалуйста, введите значения")
        
End Sub

Private Sub UserForm_Initialize()

    'Само размещение формы
    Me.StartUpPosition = 0
    Me.Top = Application.Top + 25
    Me.Left = Application.Left + 30
    
    cmbVx.List = Array("-1", "0", "1")
    cmbVy.List = Array("-1", "0", "1")
    
    'Игрок №1 ходит первым
    LabelP1.Visible = True
    LabelP2.Visible = False
    CurrentRow.Text = Range("A102").Value
    CurrentCol.Text = Range("A103").Value
    CurrentX.Text = Range("A100").Value
    CurrentY.Text = Range("A101").Value
    
End Sub

