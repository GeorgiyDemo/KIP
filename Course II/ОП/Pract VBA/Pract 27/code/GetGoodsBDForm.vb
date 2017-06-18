Public cn As ADODB.Connection
Public geter, getmngr, getgoods, goods As ADODB.Recordset

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
Private Sub UserForm_initialize()
    
    Set cn = New ADODB.Connection
    cn.Provider = "Microsoft.ACE.OLEDB.12.0"
    cn.ConnectionString = 
"C:\Users\georgiydemo\Documents\DEMKA\Computer_store.accdb"
    cn.Open

    'Запросы для БД "Поставки товара"
    Set getgoods = New ADODB.Recordset
    getgoods.CursorType = adOpenKeyset
    getgoods.LockType = adLockOptimistic
    getgoods.Source = "SELECT [Поставка Товара].* FROM [Поставка 
Товара];"
    Set getgoods.ActiveConnection = cn
    getgoods.Open

    'Запросы для БД "менеджер поставки"
    Set getmngr = New ADODB.Recordset
    getmngr.CursorType = adOpenKeyset
    getmngr.LockType = adLockOptimistic
    getmngr.Source = "SELECT [Менеджер Поставки].* FROM [Менеджер 
Поставки];"
    Set getmngr.ActiveConnection = cn
    getmngr.Open

'   'Запросы для БД "Поставщик"
    Set geter = New ADODB.Recordset
    geter.CursorType = adOpenKeyset
    geter.LockType = adLockOptimistic
    geter.Source = "SELECT [Поставщик].* FROM [Поставщик];"
    Set geter.ActiveConnection = cn
    geter.Open
    
    'Запросы для БД товаров
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

Private Sub CMDFindFirstSearch_Click()
    Dim skiprecord As Long
    Dim direction As Long
    Lname = TextBoxSearch.Text
    
    k = InputBox("По какому критерию вы хотите выполнить поиск?" + 
Chr(13) + "1. Код" + Chr(13) + "2. Дата")
    
    Select Case k
        Case 1
            criteria = "[КодПоставки] = '" & Lname & "'"
        Case 2
            criteria = "[ДатаПоставки] = '" & Lname & "'"
    End Select
        
    skiprecord = 0
    direction = adSearchForward
    getgoods.MoveFirst
    getgoods.Find criteria, skiprecord, direction
             
    If getgoods.EOF Then
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
    k = InputBox("1. Распечатать текущую поставку" + Chr(13) + "2. 
Распечатать все поставки в определенном промежутке времени")
    
    If (k = 1) Then
        Dim meow As Integer
        Dim GetGoodsDOC As Document
        Set GetGoodsDOC = 
Application.Documents.Add("C:\Users\georgiydemo\Documents\DEMKA\GetGoodsPrintOne.docx")
        meow = 0
        
        Selection.MoveDown Unit:=wdLine, Count:=18
        getgoods.MoveFirst
        goods.MoveFirst
        While Not goods.EOF
            If (getgoods.Fields("КодТовара").Value = 
goods.Fields("КодТовара").Value) Then
                meow = meow + 1
            End If
            goods.MoveNext
        Wend

        getgoods.MoveFirst
            GetGoodsDOC.Tables.Add Range:=Selection.Range, NumRows:=meow 
+ 1, NumColumns:=4, DefaultTableBehavior:=wdWord9TableBehavior, 
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
                getgoods.MoveFirst
                End With
            
        goods.MoveFirst
        While Not goods.EOF
            If (getgoods.Fields("КодТовара").Value = 
goods.Fields("КодТовара").Value) Then
                meow = meow + 1
                With Selection.Tables(1)
                    .Cell(meow, 1).Range.Text = Str(meow - 1)
                    .Cell(meow, 2).Range.Text = 
goods.Fields("Товар").Value
                    .Cell(meow, 3).Range.Text = 
getgoods.Fields("КоличествоТовараПоставки").Value
                    .Cell(meow, 4).Range.Text = 
getgoods.Fields("ЦенаТовараПоставки").Value
                End With
            End If
            goods.MoveNext
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
        
        With GetGoodsDOC
            .Bookmarks("номер_поставки").Range.Text = 
CStr(TextBox10.Text)
            .Bookmarks("дата_поставки").Range.Text = 
CStr(TextBox11.Text)
            
            .Bookmarks("поставщик_компания").Range.Text = 
CStr(TextBox8.Text)
            .Bookmarks("имя_представителя").Range.Text = 
CStr(TextBox7.Text)
            .Bookmarks("фамилия_представителя").Range.Text = 
CStr(TextBox5.Text)
            .Bookmarks("отчество_представителя").Range.Text = 
CStr(TextBox15.Text)
            .Bookmarks("телефон_представителя").Range.Text = 
CStr(TextBox16.Text)
            
            
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
        
        GetGoodsBDForm.Hide
        GetGoodsDOC.Activate
    End If
    
    If (k = 2) Then
        
        Dim moneymax, moneymin As Double
        Dim KOT_MEOW_MEOW As Integer
        Dim maxnumber, minnumber, maxcompany, mincompany, maxhuman, 
minhuman, maxmgr, minmgr, maxdata, mindata As String
        Dim first, second
        Dim GetGoodsDOCSecond As Document
        Set GetGoodsDOCSecond = 
Application.Documents.Add("C:\Users\georgiydemo\Documents\DEMKA\GetGoodsPrintTwo.docx")
        
        first = InputBox("Введите дату ОТ: (пример: 01.01.16)")
        second = InputBox("Введите дату ДО: (пример: " + CStr(Date) + 
")")
        
        getgoods.MoveFirst
        moneymax = getgoods.Fields("ЦенаТовараПоставки").Value
        moneymin = moneymax
        
        KOT_MEOW_MEOW = 0
        Selection.MoveDown Unit:=wdLine, Count:=3
       
        getgoods.MoveFirst
        While Not getgoods.EOF
            If (first < CDate(getgoods.Fields("ДатаПоставки").Value) And 
second > CDate(getgoods.Fields("ДатаПоставки").Value)) Then
                geter.MoveFirst
                While Not geter.EOF
                    If (geter.Fields("КодПоставщика").Value = 
getgoods.Fields("КодПоставщика").Value) Then
                        KOT_MEOW_MEOW = KOT_MEOW_MEOW + 1
                    End If
                    geter.MoveNext
                Wend
            End If
        getgoods.MoveNext
        Wend
        
        getgoods.MoveFirst
        GetGoodsDOCSecond.Tables.Add Range:=Selection.Range, 
NumRows:=KOT_MEOW_MEOW + 1, NumColumns:=6, 
DefaultTableBehavior:=wdWord9TableBehavior, 
AutoFitBehavior:=wdAutoFitContent
        With Selection.Tables(1)
            If .Style <> "Сетка таблицы" Then
               .Style = "Сетка таблицы"
            End If
            .Range.Font.Size = 10
            .ApplyStyleHeadingRows = True
            .ApplyStyleLastRow = True
            .ApplyStyleFirstColumn = True
            .ApplyStyleLastColumn = True
            KOT_MEOW_MEOW = 1
            getgoods.MoveFirst
        End With
        
        'Поиск записей между собой/поиск наиболее большой продажи/поиск 
наиболее маленькой продажи
        getgoods.MoveFirst
        While Not getgoods.EOF
            If (first < CDate(getgoods.Fields("ДатаПоставки").Value) And 
second > CDate(getgoods.Fields("ДатаПоставки").Value)) Then
                
                geter.MoveFirst
                While Not geter.EOF
                     If (geter.Fields("КодПоставщика").Value = 
getgoods.Fields("КодПоставщика").Value) Then
                        KOT_MEOW_MEOW = KOT_MEOW_MEOW + 1
                        With Selection.Tables(1)
                            .Cell(KOT_MEOW_MEOW, 1).Range.Text = 
CStr(KOT_MEOW_MEOW - 1)
                            .Cell(KOT_MEOW_MEOW, 2).Range.Text = 
geter.Fields("КомпанияПоставщик").Value
                            .Cell(KOT_MEOW_MEOW, 3).Range.Text = 
geter.Fields("ПредставительФамилия").Value + " " + 
geter.Fields("ПредставительИмя").Value + " " + 
geter.Fields("ПредставительОтчество").Value
                        End With
                            getmngr.MoveFirst
                            While Not getmngr.EOF
                                If 
(getmngr.Fields("КодМенеджераПоставки").Value = 
getgoods.Fields("КодМенеджераПоставки").Value) Then
                                    
Selection.Tables(1).Cell(KOT_MEOW_MEOW, 4).Range.Text = 
getmngr.Fields("Фамилия").Value + " " + getmngr.Fields("Имя").Value + " 
" + getmngr.Fields("Отчество").Value
                                End If
                                getmngr.MoveNext
                            Wend
                            getsum = 
(getgoods.Fields("ЦенаТовараПоставки").Value) * 
(getgoods.Fields("КоличествоТовараПоставки").Value)
                            If (getsum = 0) Then
                                Selection.Tables(1).Cell(KOT_MEOW_MEOW, 
5).Range.Text = "-"
                            Else
                                Selection.Tables(1).Cell(KOT_MEOW_MEOW, 
5).Range.Text = CStr(getsum)
                            End If
                            
                            Selection.Tables(1).Cell(KOT_MEOW_MEOW, 
6).Range.Text = getgoods.Fields("ДатаПоставки").Value
                            
                            'Макс доход
                            If (getsum > moneymax) Then
                            
                                moneymax = getsum
                                maxnumber = CStr(KOT_MEOW_MEOW - 1)
                                maxcompany = 
CStr(Selection.Tables(1).Cell(KOT_MEOW_MEOW, 2).Range.Text)
                                maxhuman = 
CStr(Selection.Tables(1).Cell(KOT_MEOW_MEOW, 3).Range.Text)
                                maxmgr = 
CStr(Selection.Tables(1).Cell(KOT_MEOW_MEOW, 4).Range.Text)
                                maxdata = 
CStr(Selection.Tables(1).Cell(KOT_MEOW_MEOW, 6).Range.Text)
                            
                            End If
                            
                            'Мин доход
                            If (getsum < moneymin) Then
                            
                                moneymin = getsum
                                minnumber = CStr(KOT_MEOW_MEOW - 1)
                                mincompany = 
CStr(Selection.Tables(1).Cell(KOT_MEOW_MEOW, 2).Range.Text)
                                minhuman = 
CStr(Selection.Tables(1).Cell(KOT_MEOW_MEOW, 3).Range.Text)
                                minmgr = 
CStr(Selection.Tables(1).Cell(KOT_MEOW_MEOW, 4).Range.Text)
                                mindata = 
CStr(Selection.Tables(1).Cell(KOT_MEOW_MEOW, 6).Range.Text)
                            
                            End If
                            
                    End If
                    geter.MoveNext
                Wend
            End If
        getgoods.MoveNext
        Wend

     With Selection
        .TypeText Text:="№"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="Компания-поставщик"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="ФИО представителя"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="ФИО менеджера"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="Цена (руб)"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="Дата"
        .MoveDown Unit:=wdLine, Count:=KOT_MEOW_MEOW + 2
    End With
    
    'Таблица для макс денег
    GetGoodsDOCSecond.Tables.Add Range:=Selection.Range, NumRows:=2, 
NumColumns:=6, DefaultTableBehavior:=wdWord9TableBehavior, 
AutoFitBehavior:=wdAutoFitContent
    With Selection.Tables(1)
        If .Style <> "Сетка таблицы" Then
            .Style = "Сетка таблицы"
    End If
    .Range.Font.Size = 10
    .ApplyStyleHeadingRows = True
    .ApplyStyleLastRow = True
    .ApplyStyleFirstColumn = True
    .ApplyStyleLastColumn = True
    End With
    
    With Selection.Tables(1)
        .Cell(0, 1).Range.Text = maxnumber
        .Cell(0, 2).Range.Text = maxcompany
        .Cell(0, 3).Range.Text = maxhuman
        .Cell(0, 4).Range.Text = maxmgr
        .Cell(0, 5).Range.Text = moneymax
        .Cell(0, 6).Range.Text = maxdata
    End With
    
    With Selection
        .TypeText Text:="№"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="Компания-поставщик"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="ФИО представителя"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="ФИО менеджера"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="Цена (руб)"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="Дата"
        .MoveDown Unit:=wdLine, Count:=4
    End With
   
   'Таблица для мин денег
   GetGoodsDOCSecond.Tables.Add Range:=Selection.Range, NumRows:=2, 
NumColumns:=6, DefaultTableBehavior:=wdWord9TableBehavior, 
AutoFitBehavior:=wdAutoFitContent
   With Selection.Tables(1)
        If .Style <> "Сетка таблицы" Then
            .Style = "Сетка таблицы"
        End If
    .Range.Font.Size = 10
    .Range.Font.Bold = wdToggle
    .ApplyStyleHeadingRows = True
    .ApplyStyleLastRow = True
    .ApplyStyleFirstColumn = True
    .ApplyStyleLastColumn = True
   End With
   
    With Selection.Tables(1)
        .Cell(0, 1).Range.Text = minnumber
        .Cell(0, 2).Range.Text = mincompany
        .Cell(0, 3).Range.Text = minhuman
        .Cell(0, 4).Range.Text = minmgr
        .Cell(0, 5).Range.Text = moneymin
        .Cell(0, 6).Range.Text = mindata
    End With
   
    With Selection
        .TypeText Text:="№"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="Компания-поставщик"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="ФИО представителя"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="ФИО менеджера"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="Цена (руб)"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="Дата"
        .MoveDown Unit:=wdLine, Count:=3
    End With
    
    With GetGoodsDOCSecond
        .Bookmarks("начало_дата").Range.Text = CStr(first)
        .Bookmarks("конец_дата").Range.Text = CStr(second)
        .Bookmarks("время").Range.Text = Time
        .Bookmarks("дата").Range.Text = Date
    End With
        
     GetGoodsBDForm.Hide
     GetGoodsDOCSecond.Activate
    End If
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
    getgoods.AddNew
    FillRecord
    ListBox1.Clear
    TextBox1.SetFocus
    
    'Блокировка большинства элементов
    TextBox6.Enabled = False
    TextBox7.Enabled = False
    TextBox8.Enabled = False
    TextBox5.Enabled = False
    TextBox15.Enabled = False
    TextBox16.Enabled = False
    TextBox1.Enabled = False
    TextBox2.Enabled = False
    TextBox3.Enabled = False
    TextBox4.Enabled = False
    TextBox9.Enabled = False
    TextBox14.Enabled = False
    TextBoxSearch.Enabled = False
    ListBox1.Enabled = False
    Frame1.Enabled = False
    Frame2.Enabled = False
    
    IsDisable = True
    SetEnabled True, False
    
End Sub

Private Sub CMDDeleteButton_Click()
 If (getgoods.RecordCount >= 1) Then
    If MsgBox("Удалить текущую запись?", vbYesNo + vbQuestion) = vbYes 
Then
        getgoods.Delete
        If (getgoods.RecordCount > 0) Then
            CMDNextButton_Click
        Else
            ShowEmptyRecord
        End If
    End If
 End If
End Sub

Private Sub CMDFirstButton_Click()
    getgoods.MoveFirst
    ShowRecord
End Sub

Private Sub CMDLastButton_Click()
    getgoods.MoveLast
    ShowRecord
End Sub

Private Sub CMDNextButton_Click()
    If (getgoods.EOF = False) Then getgoods.MoveNext
    If (getgoods.EOF = False) Then ShowRecord
End Sub

Private Sub CMDPreviousButton_Click()
    If (getgoods.BOF = False) Then getgoods.MovePrevious
    If (getgoods.BOF = False) Then ShowRecord
End Sub

Private Sub CMDUpdateButton_Click()
    If MsgBox("Вы действительно хотите обновить данную запись?", vbYesNo 
+ vbQuestion) = vbYes Then
        Call FillRecord
        getgoods.Update
        
        'Разблокировка большинства элементов
            TextBox6.Enabled = True
            TextBox7.Enabled = True
            TextBox8.Enabled = True
            TextBox5.Enabled = True
            TextBox15.Enabled = True
            TextBox16.Enabled = True
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox9.Enabled = True
            TextBox14.Enabled = True
            TextBoxSearch.Enabled = True
            ListBox1.Enabled = True
            Frame1.Enabled = True
            Frame2.Enabled = True
            
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
    getgoods.Fields("ДатаПоставки").Value = TextBox11.Text
    getgoods.Fields("ЦенаТовараПоставки").Value = TextBox18.Text
    getgoods.Fields("КоличествоТовараПоставки").Value = TextBox19.Text
    getgoods.Fields("КодТовара").Value = TextBox17.Text
    getgoods.Fields("КодМенеджераПоставки").Value = TextBox12.Text
    getgoods.Fields("КодПоставщика").Value = TextBox13.Text

End Sub

Private Sub ShowRecord()
    
    Dim getsum As Double
    Dim i As Integer
 
    i = 1
    ListBox1.Clear
    ListBox1.AddItem "Название"
    ListBox1.List(0, 1) = "Кол-во"
    ListBox1.List(0, 2) = "Цена"
 
    TextBox10.Text = getgoods.Fields("КодПоставки").Value
    TextBox11.Text = getgoods.Fields("ДатаПоставки").Value
    TextBox12.Text = getgoods.Fields("КодМенеджераПоставки").Value
    TextBox13.Text = getgoods.Fields("КодПоставщика").Value
    TextBox17.Text = getgoods.Fields("КодТовара").Value
    TextBox18.Text = getgoods.Fields("ЦенаТовараПоставки").Value
    TextBox19.Text = getgoods.Fields("КоличествоТовараПоставки").Value
 
    getsum = (getgoods.Fields("ЦенаТовараПоставки").Value) * 
(getgoods.Fields("КоличествоТовараПоставки").Value)
    TextBox14.Text = getsum
    
    geter.MoveFirst
    While Not geter.EOF
        If (getgoods.Fields("КодПоставщика").Value = 
geter.Fields("КодПоставщика").Value) Then
 
            TextBox6.Text = geter.Fields("КодПоставщика").Value
            TextBox8.Text = geter.Fields("КомпанияПоставщик").Value
            TextBox7.Text = geter.Fields("ПредставительИмя").Value
            TextBox5.Text = geter.Fields("ПредставительФамилия").Value
            TextBox15.Text = geter.Fields("ПредставительОтчество").Value
            TextBox16.Text = geter.Fields("ПредставительТелефон").Value
 
        End If
        geter.MoveNext
    Wend
 
    getmngr.MoveFirst
    While Not getmngr.EOF
        If (getgoods.Fields("КодМенеджераПоставки").Value = 
getmngr.Fields("КодМенеджераПоставки").Value) Then
            TextBox1.Text = getmngr.Fields("КодМенеджераПоставки").Value
            TextBox2.Text = getmngr.Fields("Имя").Value
            TextBox3.Text = getmngr.Fields("Фамилия").Value
            TextBox4.Text = getmngr.Fields("Отчество").Value
            TextBox9.Text = getmngr.Fields("Телефон").Value
        End If
 
        getmngr.MoveNext
    Wend
 
 
    goods.MoveFirst
    While Not goods.EOF
        If (getgoods.Fields("КодТовара").Value = 
goods.Fields("КодТовара").Value) Then
                    ListBox1.AddItem goods.Fields("Товар").Value
                    ListBox1.List(i, 1) = 
getgoods.Fields("КоличествоТовараПоставки").Value
                    ListBox1.List(i, 2) = 
getgoods.Fields("ЦенаТовараПоставки").Value
                    i = i + 1
        End If
        goods.MoveNext
    Wend
End Sub

Private Sub ShowEmptyRecord()
    
    TextBox11.Text = Empty
    TextBox14.Text = Empty
    
    'Дата продажи
    TextBox11.Text = Date
    'ЦенаТовараПоставки
    TextBox18.Text = 1
    'КоличествоТовараПоставки
    TextBox19.Text = 1
    'КодТовара
    TextBox17.Text = 1
    'КодМенеджераПоставки
    TextBox12.Text = 1
    'КодПоставщика
    TextBox13.Text = 1
    
End Sub

Private Sub ExitButton_Click()

    Unload Me
    BDMainForm.Show
    
End Sub

