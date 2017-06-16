Public cn As ADODB.Connection
Public cli, mngr, sale, content, goods As ADODB.Recordset

Function Translater(number)

    Dim rub, units, dozens, hundrunits, nadc, sizes, i, m
    
    If (number >= 1E+15) Or (number < 0) Then
        Exit Function
    End If
    
    hundrunits = Array("", "сто ", "двести ", "триста ", "четыреста ", 
"пятьсот ", "шестьсот ", "семьсот ", "восемьсот ", "девятьсот ")
    dozens = Array("", "", "двадцать ", "тридцать ", "сорок ", 
"пятьдесят ", "шестьдесят ", "семьдесят ", "восемьдесят ", "девяносто ")
    nadc = Array("десять ", "одиннадцать ", "двенадцать ", "тринадцать 
", "четырнадцать ", "пятнадцать ", "шестнадцать ", "семнадцать ", 
"восемнадцать ", "девятнадцать ")
    units = Array("", "один ", "два ", "три ", "четыре ", "пять ", 
"шесть ", "семь ", "восемь ", "девять ", "", "одна ", "две ")
    sizes = Array("триллион ", "триллиона ", "триллионов ", "миллиард ", 
"миллиарда ", "миллиардов ", "миллион ", "миллиона ", "миллионов ", 
"тысяча ", "тысячи ", "тысяч ", "рубль ", "рубля ", "рублей ")

    rub = Left(Format(number, "000000000000000"), 15)

    If (CDbl(rub) = 0) Then
        m = "ноль "
    End If
    
    For i = 1 To Len(rub) Step 3
        If Mid(rub, i, 3) <> "000" Or i = Len(rub) - 2 Then
                m = m & hundrunits(CInt(Mid(rub, i, 1))) & IIf(Mid(rub, 
i + 1, 1) = "1", nadc(CInt(Mid(rub, i + 2, 1))), _
                dozens(CInt(Mid(rub, i + 1, 1))) & units(CInt(Mid(rub, i 
+ 2, 1)) + IIf(i = Len(rub) - 5 And CInt(Mid(rub, i + 2, 1)) < 3, 10, 
0))) & _
                IIf(Mid(rub, i + 1, 1) = "1" Or (Mid(rub, i + 2, 1) + 9) 
Mod 10 >= 4, sizes(i + 1), IIf(Mid(rub, i + 2, 1) = "1", sizes(i - 1), 
sizes(i)))
        End If
    Next i
    Translater = LCase(Left(m, 1)) & Mid(m, 2)
    
End Function

Private Sub CMDFindFirstSearch_Click()
    Dim skiprecord As Long
    Dim direction As Long
    Lname = TextBoxSearch.Text
    
    k = InputBox("По какому критерию вы хотите выполнить поиск?" + 
Chr(13) + "1. Код" + Chr(13) + "2. Дата")
    
    Select Case k
        Case 1
            criteria = "[№ продажи] = '" & Lname & "'"
        Case 2
            criteria = "[Дата продажи] = '" & Lname & "'"
    End Select
        
    skiprecord = 0
    direction = adSearchForward
    sale.MoveFirst
    sale.Find criteria, skiprecord, direction
             
    If sale.EOF Then
        MsgBox "Запись не найдена"
        Beep
    Else
        MsgBox "Запись найдена!"
        ShowRecord
        Beep
    End If
End Sub


Private Sub PrintButton_Click()
    Dim k As Integer
    k = InputBox("1. Распечатать текущую продажу" + Chr(13) + "2. 
Распечатать все продажи в определенном промежутке времени")
    
    If (k = 1) Then
        Dim meow As Integer
        Dim GoodsDOC As Document
        Set GoodsDOC = 
Application.Documents.Add("C:\Users\georgiydemo\Documents\DEMKA\GoodsPrintOne.docx")
        meow = 0
        
        Selection.MoveDown Unit:=wdLine, Count:=14
    
        content.MoveFirst
        While Not content.EOF
        
            If (sale.Fields("№ продажи").Value = content.Fields("№ 
Продажи").Value) Then
                goods.MoveFirst
                While Not goods.EOF
                    If (content.Fields("КодТовара").Value = 
goods.Fields("КодТовара").Value) Then
                        meow = meow + 1
                    End If
                    goods.MoveNext
                Wend
            End If
            content.MoveNext
        Wend
      
        content.MoveFirst
            GoodsDOC.Tables.Add Range:=Selection.Range, NumRows:=meow + 
1, NumColumns:=4, DefaultTableBehavior:=wdWord9TableBehavior, 
AutoFitBehavior:=wdAutoFitContent
                
                With Selection.Tables(1)
                    If .Style <> "Сетка таблицы" Then
                        .Style = "Сетка таблицы"
                    End If
                    .Range.Font.Size = 16
                    .Range.Font.Bold = wdToggle
                    .ApplyStyleHeadingRows = True
                    .ApplyStyleLastRow = True
                    .ApplyStyleFirstColumn = True
                    .ApplyStyleLastColumn = True
                   
                    meow = 1
                content.MoveFirst
                End With
            
        content.MoveFirst
        While Not content.EOF
        
            If (sale.Fields("№ продажи").Value = content.Fields("№ 
Продажи").Value) Then
                goods.MoveFirst
                While Not goods.EOF
    
                    If (content.Fields("КодТовара").Value = 
goods.Fields("КодТовара").Value) Then
                        meow = meow + 1
                        With Selection.Tables(1)
                            .Cell(meow, 1).Range.Text = Str(meow - 1)
                            .Cell(meow, 2).Range.Text = 
goods.Fields("Товар").Value
                            .Cell(meow, 3).Range.Text = 
content.Fields("Кол-во").Value
                            .Cell(meow, 4).Range.Text = 
content.Fields("Цена").Value
                    
                        End With
                    End If
                    goods.MoveNext
                Wend
            End If
            content.MoveNext
        Wend
        
        'Хотфикс заголовков таблицы
        Selection.TypeText Text:="№"
        Selection.MoveRight Unit:=wdCharacter, Count:=1
        Selection.TypeText Text:="Название"
        Selection.MoveRight Unit:=wdCharacter, Count:=1
        Selection.TypeText Text:="Кол-во (шт)"
        Selection.MoveRight Unit:=wdCharacter, Count:=1
        Selection.TypeText Text:="Цена (руб)"
        Selection.MoveDown Unit:=wdLine, Count:=1
        
        With GoodsDOC
            .Bookmarks("номер_чека").Range.Text = CStr(TextBox10.Text)
            .Bookmarks("время_покупки").Range.Text = 
CStr(TextBox11.Text)
            .Bookmarks("фио_клиента").Range.Text = CStr(TextBox8.Text)
            .Bookmarks("менеджер_имя").Range.Text = CStr(TextBox2.Text)
            .Bookmarks("менеджер_фамилия").Range.Text = 
CStr(TextBox3.Text)
            .Bookmarks("менеджер_отчество").Range.Text = 
CStr(TextBox4.Text)
            .Bookmarks("менеджер_телефон").Range.Text = 
CStr(TextBox9.Text)
            .Bookmarks("сумма_общ").Range.Text = CStr(TextBox14.Text) + 
" руб. (" + Translater(TextBox14.Text) + ")" + Chr(13)
            .Bookmarks("время").Range.Text = Time
            .Bookmarks("дата").Range.Text = Date
        End With
        
        GoodsSaleBDForm.Hide
        GoodsDOC.Activate
    End If
    
    'Допилить
    If (k = 2) Then
        
        Dim moneymax, moneymin As Double
        Dim KOT_MEOW_MEOW As Integer
        Dim maxnumber, minnumber, maxcli, mincli, maxmgr, minmgr, 
maxdata, mindata As String
        Dim first, second
        Dim GoodsDOCSecond As Document
        Set GoodsDOCSecond = 
Application.Documents.Add("C:\Users\georgiydemo\Documents\DEMKA\GoodsPrintTwo.docx")
        
        first = InputBox("Введите дату ОТ: (пример: 01.01.16)")
        second = InputBox("Введите дату ДО: (пример: " + CStr(Date) + 
")")
        
        moneymax = 0
        content.MoveFirst
        While Not content.EOF
            If (content.Fields("№ Продажи").Value = 1) Then
                moneymax = moneymax + ((content.Fields("Цена").Value) * 
(content.Fields("Кол-во").Value))
            End If
            content.MoveNext
        Wend
        moneymin = moneymax
        
        KOT_MEOW_MEOW = 0
        Selection.MoveDown Unit:=wdLine, Count:=3
        sale.MoveFirst
        While Not sale.EOF
            If (first < CDate(sale.Fields("Дата продажи").Value) And 
second > CDate(sale.Fields("Дата продажи").Value)) Then
                cli.MoveFirst
                While Not cli.EOF
                    If (cli.Fields("Кодклиента").Value = 
sale.Fields("КодКлиента").Value) Then
                        KOT_MEOW_MEOW = KOT_MEOW_MEOW + 1
                    End If
                    cli.MoveNext
                Wend
            End If
        sale.MoveNext
        Wend
        
        sale.MoveFirst
        GoodsDOCSecond.Tables.Add Range:=Selection.Range, 
NumRows:=KOT_MEOW_MEOW + 1, NumColumns:=5, 
DefaultTableBehavior:=wdWord9TableBehavior, 
AutoFitBehavior:=wdAutoFitContent
        With Selection.Tables(1)
            If .Style <> "Сетка таблицы" Then
               .Style = "Сетка таблицы"
            End If
            .Range.Font.Size = 11
            .ApplyStyleHeadingRows = True
            .ApplyStyleLastRow = True
            .ApplyStyleFirstColumn = True
            .ApplyStyleLastColumn = True
            KOT_MEOW_MEOW = 1
            sale.MoveFirst
        End With
        
        'Поиск записей между собой/поиск наиболее большой продажи/поиск 
наиболее маленькой продажи
        sale.MoveFirst
        While Not sale.EOF
            If (first < CDate(sale.Fields("Дата продажи").Value) And 
second > CDate(sale.Fields("Дата продажи").Value)) Then
                cli.MoveFirst
                While Not cli.EOF
                    If (cli.Fields("Кодклиента").Value = 
sale.Fields("КодКлиента").Value) Then
                        KOT_MEOW_MEOW = KOT_MEOW_MEOW + 1
                        With Selection.Tables(1)
                            .Cell(KOT_MEOW_MEOW, 1).Range.Text = 
CStr(KOT_MEOW_MEOW - 1)
                            .Cell(KOT_MEOW_MEOW, 2).Range.Text = 
cli.Fields("Клиент").Value
                            mngr.MoveFirst
                            While Not mngr.EOF
                                If 
(mngr.Fields("КодМенеджераПродажи").Value = 
sale.Fields("КодМенеджераПродажи").Value) Then
                                    
Selection.Tables(1).Cell(KOT_MEOW_MEOW, 3).Range.Text = 
mngr.Fields("Фамилия").Value + " " + mngr.Fields("Имя").Value + " " + 
mngr.Fields("Отчество").Value
                                End If
                                mngr.MoveNext
                            Wend
                            tsum = 0
                            content.MoveFirst
                             While Not content.EOF
                                If (content.Fields("№ Продажи").Value = 
sale.Fields("№ продажи").Value) Then
                                    tsum = tsum + 
((content.Fields("Цена").Value) * (content.Fields("Кол-во").Value))
                                End If
                                content.MoveNext
                            Wend
                            If (tsum = 0) Then
                                Selection.Tables(1).Cell(KOT_MEOW_MEOW, 
4).Range.Text = "-"
                            Else
                                Selection.Tables(1).Cell(KOT_MEOW_MEOW, 
4).Range.Text = CStr(tsum)
                            End If
                            
                            'Макс доход
                            If (tsum > moneymax) Then
                                
                                moneymax = tsum
                                maxnumber = CStr(KOT_MEOW_MEOW - 1)
                                maxcli = 
CStr(Selection.Tables(1).Cell(KOT_MEOW_MEOW, 2).Range.Text)
                                maxmgr = 
CStr(Selection.Tables(1).Cell(KOT_MEOW_MEOW, 3).Range.Text)
                                maxdata = CStr(sale.Fields("Дата 
продажи").Value)
                                
                            End If
                            
                            'Мин доход
                             If (tsum < moneymin) Then
                                
                                moneymin = tsum
                                minnumber = CStr(KOT_MEOW_MEOW - 1)
                                mincli = 
CStr(Selection.Tables(1).Cell(KOT_MEOW_MEOW, 2).Range.Text)
                                minmgr = 
CStr(Selection.Tables(1).Cell(KOT_MEOW_MEOW, 3).Range.Text)
                                mindata = CStr(sale.Fields("Дата 
продажи").Value)
                                
                            End If
                        
                            Selection.Tables(1).Cell(KOT_MEOW_MEOW, 
5).Range.Text = sale.Fields("Дата продажи").Value
                        End With
                    End If
                    cli.MoveNext
                Wend
            End If
        sale.MoveNext
        Wend


     With Selection
        .TypeText Text:="№"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="ФИО клиента"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="ФИО менеджера"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="Цена (руб)"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="Дата"
        .MoveDown Unit:=wdLine, Count:=KOT_MEOW_MEOW + 2
    End With
    
    'Таблица для макс денег
    GoodsDOCSecond.Tables.Add Range:=Selection.Range, NumRows:=2, 
NumColumns:=5, DefaultTableBehavior:=wdWord9TableBehavior, 
AutoFitBehavior:=wdAutoFitContent
    With Selection.Tables(1)
        If .Style <> "Сетка таблицы" Then
            .Style = "Сетка таблицы"
    End If
    .Range.Font.Size = 11
    .ApplyStyleHeadingRows = True
    .ApplyStyleLastRow = True
    .ApplyStyleFirstColumn = True
    .ApplyStyleLastColumn = True
    End With
    
    With Selection.Tables(1)
        .Cell(0, 1).Range.Text = maxnumber
        .Cell(0, 2).Range.Text = maxcli
        .Cell(0, 3).Range.Text = maxmgr
        .Cell(0, 4).Range.Text = moneymax
        .Cell(0, 5).Range.Text = maxdata
    End With
    
    With Selection
        .TypeText Text:="№"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="ФИО клиента"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="ФИО менеджера"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="Цена (руб)"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="Дата"
        .MoveDown Unit:=wdLine, Count:=4
    End With
    
    'Таблица для мин денег
    GoodsDOCSecond.Tables.Add Range:=Selection.Range, NumRows:=2, 
NumColumns:=5, DefaultTableBehavior:=wdWord9TableBehavior, 
AutoFitBehavior:=wdAutoFitContent
    With Selection.Tables(1)
        If .Style <> "Сетка таблицы" Then
            .Style = "Сетка таблицы"
    End If
    .Range.Font.Size = 11
    .Range.Font.Bold = wdToggle
    .ApplyStyleHeadingRows = True
    .ApplyStyleLastRow = True
    .ApplyStyleFirstColumn = True
    .ApplyStyleLastColumn = True
    End With
    
    With Selection.Tables(1)
        .Cell(0, 1).Range.Text = minnumber
        .Cell(0, 2).Range.Text = mincli
        .Cell(0, 3).Range.Text = minmgr
        .Cell(0, 4).Range.Text = moneymin
        .Cell(0, 5).Range.Text = mindata
    End With
    
    With Selection
        .TypeText Text:="№"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="ФИО клиента"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="ФИО менеджера"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="Цена (руб)"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="Дата"
        .MoveDown Unit:=wdLine, Count:=3
    End With
    
     With GoodsDOCSecond
        .Bookmarks("начало_дата").Range.Text = CStr(first)
        .Bookmarks("конец_дата").Range.Text = CStr(second)
        .Bookmarks("время").Range.Text = Time
        .Bookmarks("дата").Range.Text = Date
     End With
        
     GoodsSaleBDForm.Hide
     GoodsDOCSecond.Activate
    End If
End Sub

Private Sub UserForm_initialize()
    
    Set cn = New ADODB.Connection
    cn.Provider = "Microsoft.ACE.OLEDB.12.0"
    cn.ConnectionString = 
"C:\Users\georgiydemo\Documents\DEMKA\Computer_store.accdb"
    cn.Open

    'Запросы для продажи
    Set sale = New ADODB.Recordset
    sale.CursorType = adOpenKeyset
    sale.LockType = adLockOptimistic
    sale.Source = "SELECT Продажа.* FROM Продажа"
    Set sale.ActiveConnection = cn
    sale.Open

    'Запросы для клиента
    Set cli = New ADODB.Recordset
    cli.CursorType = adOpenKeyset
    cli.LockType = adLockOptimistic
    cli.Source = "SELECT Клиент.* FROM Клиент"
    Set cli.ActiveConnection = cn
    cli.Open

'   'Запросы для менеджера
    Set mngr = New ADODB.Recordset
    mngr.CursorType = adOpenKeyset
    mngr.LockType = adLockOptimistic
    mngr.Source = "SELECT [Менеджер по продажам].* FROM [Менеджер по 
продажам];"
    Set mngr.ActiveConnection = cn
    mngr.Open
    
    'Запросы для состава заказа
    Set content = New ADODB.Recordset
    content.CursorType = adOpenKeyset
    content.LockType = adLockOptimistic
    content.Source = "SELECT [Состав заказа].* FROM [Состав заказа];"
    Set content.ActiveConnection = cn
    content.Open
    
    'Запросы для товаров
    Set goods = New ADODB.Recordset
    goods.CursorType = adOpenKeyset
    goods.LockType = adLockOptimistic
    goods.Source = "SELECT [Товар].* FROM [Товар];"
    Set goods.ActiveConnection = cn
    goods.Open
    
    
    CMDUpdateButton.Tag = "Update"
    ShowEmptyRecord
    CMDFirstButton_Click

End Sub

Private Sub CMDFindFimainclienttSearch_Click()
 
 Dim skiprecord As Long
 Dim direction As Long
 Lname = TextBoxSearch.Text
 
 If (Lname = "") Then
    MsgBox "Не заполнено поле для поиска записей по коду"
 Else
     If (IsNumeric(Lname) = True) Then
         
         criteria = "[Кодклиента] = '" & Lname & "'"
         skiprecord = 0
         direction = adSearchForward
         sale.MoveFirst
         sale.Find criteria, skiprecord, direction
         
         If sale.EOF Then
             MsgBox "Запись не найдена"
            Beep
         Else
            MsgBox "Запись найдена!"
            ShowRecord
            Beep
        End If
    End If
    If (IsNumeric(Lname) = False) Then
        criteria = "[Клиент] = '" & Lname & "'"
         skiprecord = 0
         direction = adSearchForward
         sale.MoveFirst
         sale.Find criteria, skiprecord, direction
         
         If sale.EOF Then
            MsgBox "Запись не найдена"
            Beep
         Else
            MsgBox "Запись найдена!"
            ShowRecord
            Beep
        End If
    End If
  End If
End Sub

Private Sub RefreshButton_Click()
    ShowRecord
End Sub

Private Sub CMDAddButton_Click()
    ShowEmptyRecord
    sale.AddNew
    FillRecord
    ListBox1.Clear
    TextBox1.SetFocus
    IsDisable = True
    SetEnabled True, False
    
End Sub

Private Sub CMDDeleteButton_Click()
 If (sale.RecordCount >= 1) Then
    If MsgBox("Удалить текущую запись?", vbYesNo + vbQuestion) = vbYes 
Then
        sale.Delete
        If (sale.RecordCount > 0) Then
            CMDNextButton_Click
        Else
            ShowEmptyRecord
        End If
    End If
 End If
End Sub

Private Sub CMDFirstButton_Click()
    sale.MoveFirst
    ShowRecord
End Sub

Private Sub CMDLastButton_Click()
    sale.MoveLast
    ShowRecord
End Sub

Private Sub CMDNextButton_Click()
    If (sale.EOF = False) Then sale.MoveNext
    If (sale.EOF = False) Then ShowRecord
End Sub

Private Sub CMDPreviousButton_Click()
    If (sale.BOF = False) Then sale.MovePrevious
    If (sale.BOF = False) Then ShowRecord
End Sub

Private Sub CMDUpdateButton_Click()
    If MsgBox("Вы действительно хотите обновить данную запись?", vbYesNo 
+ vbQuestion) = vbYes Then
        Call FillRecord
        sale.Update
        Call SetEnabled(True, True)
        If (Not IsDisable) Then
            IsDisable = False
        End If
    End If
End Sub

Private Sub SetEnabled(IsUpdateOn As Boolean, IsOthersOn As Boolean)
    Dim ctrl As Control
    For Each ctrl In Controls
    
        If (LCase(Left(ctrl.Name, 3)) = "cmd") Then
            If (ctrl.Tag = "Update") Then
                ctrl.Enabled = IsUpdateOn
            Else
                ctrl.Enabled = IsOthersOn
            End If
        End If
    Next
End Sub

Private Sub FillRecord()
    sale.Fields("Дата продажи").Value = TextBox11.Text
    sale.Fields("КодМенеджераПродажи").Value = TextBox12.Text
    sale.Fields("КодКлиента").Value = TextBox13.Text
End Sub

Private Sub ShowRecord()
    Dim tsum As Double
    Dim i As Integer
    
    tsum = 0
    i = 1
    ListBox1.Clear
    ListBox1.AddItem "Название"
    ListBox1.List(0, 1) = "Кол-во"
    ListBox1.List(0, 2) = "Цена"
    
    
    TextBox10.Text = sale.Fields("№ продажи").Value
    TextBox11.Text = sale.Fields("Дата продажи").Value
    TextBox12.Text = sale.Fields("КодМенеджераПродажи").Value
    TextBox13.Text = sale.Fields("КодКлиента").Value
    
    cli.MoveFirst
    While Not cli.EOF
        If (sale.Fields("КодКлиента").Value = 
cli.Fields("Кодклиента").Value) Then
    
            TextBox6.Text = cli.Fields("Кодклиента").Value
            TextBox8.Text = cli.Fields("Клиент").Value
            TextBox7.Text = cli.Fields("ЕдТовара").Value
            TextBox5.Text = cli.Fields("КодМенеджера").Value
    
        End If
        cli.MoveNext
    Wend
    
    mngr.MoveFirst
    While Not mngr.EOF
        If (sale.Fields("КодМенеджераПродажи").Value = 
mngr.Fields("КодМенеджераПродажи").Value) Then
      
            TextBox1.Text = mngr.Fields("КодМенеджераПродажи").Value
            TextBox2.Text = mngr.Fields("Имя").Value
            TextBox3.Text = mngr.Fields("Фамилия").Value
            TextBox4.Text = mngr.Fields("Отчество").Value
            TextBox9.Text = mngr.Fields("Телефон").Value
        End If
        
        mngr.MoveNext
    Wend
    
    content.MoveFirst
    While Not content.EOF
    
        If (sale.Fields("№ продажи").Value = content.Fields("№ 
Продажи").Value) Then
            goods.MoveFirst
            While Not goods.EOF

                If (content.Fields("КодТовара").Value = 
goods.Fields("КодТовара").Value) Then
                    ListBox1.AddItem goods.Fields("Товар").Value
                    ListBox1.List(i, 1) = content.Fields("Кол-во").Value
                    ListBox1.List(i, 2) = content.Fields("Цена").Value
                    tsum = tsum + ((content.Fields("Цена").Value) * 
(content.Fields("Кол-во").Value))
                    i = i + 1
                End If
                goods.MoveNext
            Wend
        End If
        
       
        content.MoveNext
    Wend
    TextBox14.Text = tsum
End Sub

Private Sub ShowEmptyRecord()

    TextBox10.Text = Empty
    TextBox11.Text = Date
    TextBox12.Text = 1
    TextBox13.Text = 1
    
End Sub

Private Sub ExitButton_Click()

    Unload Me
    BDMainForm.Show
    
End Sub

