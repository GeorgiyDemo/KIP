Public kmangr, goods As ADODB.Recordset
Public geter, getmngr, getgoods As ADODB.Recordset
Public cli, mngr, sale, content As ADODB.Recordset

Sub OneButton()

    Dim sredcounter, sredsum, codemax, codemin, kmax, kmin, buf, 
mangrmax, mangrmin As Integer
    Dim kmaxname, kminname As String
    Dim kotuk_doc As Document
    Set kotuk_doc = 
Application.Documents.Add("C:\Users\georgiydemo\Documents\DEMKA\OneButton.docx")
    
    cli.MoveFirst
    kmangr.MoveFirst
    
    kmax = CInt(cli.Fields("ЕдТовара").Value)
    kmin = kmax
    sredcounter = 0
    sredsum = 0
    
    While Not cli.EOF
        buf = CInt(cli.Fields("ЕдТовара").Value)
        sredcounter = sredcounter + 1
        sredsum = sredsum + CInt(cli.Fields("ЕдТовара").Value)
        If (buf < kmin) Then
            kmin = buf
            mangrmin = cli.Fields("КодМенеджера").Value
            codemin = cli.Fields("КодКлиента").Value
            kminname = cli.Fields("Клиент").Value
        End If
        
        If (buf > kmax) Then
            kmax = buf
            mangrmax = cli.Fields("КодМенеджера").Value
            codemax = cli.Fields("КодКлиента").Value
            kmaxname = cli.Fields("Клиент").Value
        End If
        
        cli.MoveNext
    Wend
    
    'Ищем лучшего менеджера
    While Not kmangr.EOF
        If (mangrmax = kmangr.Fields("Код").Value) Then
            kotuk_doc.Bookmarks("макс_менеджер_фио").Range.Text = 
kmangr.Fields("Фамилия").Value + " " + kmangr.Fields("Имя").Value + " " 
+ kmangr.Fields("Отчество").Value
            kotuk_doc.Bookmarks("макс_менеджер_телефон").Range.Text = 
kmangr.Fields("Телефон").Value
        End If
        kmangr.MoveNext
    Wend
    
    'Ищем худшего менеджера
    kmangr.MoveFirst
    While Not kmangr.EOF
        If (mangrmin = kmangr.Fields("Код").Value) Then
            kotuk_doc.Bookmarks("мин_менеджер_фио").Range.Text = 
kmangr.Fields("Фамилия").Value + " " + kmangr.Fields("Имя").Value + " " 
+ kmangr.Fields("Отчество").Value
            kotuk_doc.Bookmarks("мин_менеджер_телефон").Range.Text = 
kmangr.Fields("Телефон").Value
        End If
        kmangr.MoveNext
    Wend
    
    With kotuk_doc
        .Bookmarks("дата").Range.Text = Date
        .Bookmarks("время").Range.Text = Time
        .Bookmarks("макс_фио").Range.Text = CStr(kmaxname)
        .Bookmarks("макс_товар").Range.Text = CStr(kmax)
        .Bookmarks("мин_фио").Range.Text = CStr(kminname)
        .Bookmarks("мин_товар").Range.Text = CStr(kmin)
        .Bookmarks("макс_код_общ").Range.Text = CStr(codemax)
        .Bookmarks("мин_код_общ").Range.Text = CStr(codemin)
        .Bookmarks("сред_код_общ").Range.Text = CStr(sredsum / 
sredcounter)
    End With
    
    DOCListForm.Hide
    kotuk_doc.Activate

End Sub

Sub TwoButton()
    Dim kot As Document
    Dim i As Integer
    
    Set kot = 
Application.Documents.Add("C:\Users\georgiydemo\Documents\DEMKA\UniversalDOC.docx")
    goods.MoveFirst
    i = 0
    
    Do Until goods.EOF
        i = i + 1
        goods.MoveNext
    Loop

    kot.Tables.Add Range:=Selection.Range, NumRows:=i + 1, 
NumColumns:=2, DefaultTableBehavior:=wdWord9TableBehavior, 
AutoFitBehavior:=wdAutoFitContent
            
    With Selection.Tables(1)
        If .Style <> "Сетка таблицы" Then
            .Style = "Сетка таблицы"
        End If
        .ApplyStyleHeadingRows = True
        .ApplyStyleLastRow = True
        .ApplyStyleFirstColumn = True
        .ApplyStyleLastColumn = True
        .Cell(0, 1).Range.Text = "Инвентарный номер"
        .Cell(0, 2).Range.Text = "Наименование"
        i = 1
        goods.MoveFirst
    End With
     
    Do Until goods.EOF
        i = i + 1
        Selection.Tables(1).Cell(i, 1).Range.Text = 
goods.Fields("КодТовара").Value
        Selection.Tables(1).Cell(i, 2).Range.Text = 
goods.Fields("Товар").Value
        goods.MoveNext
    Loop
    
    kot.Bookmarks("тема_отчета").Range.Text = "*Общий отчет по всем 
товарам, доступным в магазине*"
    kot.Bookmarks("время").Range.Text = Time
    kot.Bookmarks("дата").Range.Text = Date
    
    DOCListForm.Hide
    kot.Activate

End Sub

Sub ThreeButton()
        
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
        
     DOCListForm.Hide
     GetGoodsDOCSecond.Activate
End Sub

Sub FourButton()
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
        .TypeText Text:="Компания-поставщик"
        .MoveRight Unit:=wdCharacter, Count:=1
        .TypeText Text:="Представитель"
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
        
     DOCListForm.Hide
     GoodsDOCSecond.Activate
End Sub

Sub FiveButton()
    Dim input_code As Integer
    'input_code = inputbox(
End Sub

Private Sub UserForm_initialize()

    'Recordset для всей БД
    Set cn = New ADODB.Connection
    cn.Provider = "Microsoft.ACE.OLEDB.12.0"
    cn.ConnectionString = 
"C:\Users\georgiydemo\Documents\DEMKA\Computer_store.accdb"
    cn.Open
    
    'Параметры для запроса менеджеров по работе с клиентами
    Set kmangr = New ADODB.Recordset
    kmangr.CursorType = adOpenKeyset
    kmangr.LockType = adLockOptimistic
    kmangr.Source = "SELECT [Менеджер по работе с клиентами].* FROM 
[Менеджер по работе с клиентами];"
    Set kmangr.ActiveConnection = cn
    kmangr.Open
    
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
    
End Sub
Private Sub MainDOCButton_Click()

    If (OptionButton1.Value = True) Then
        Call OneButton
    End If
    If (OptionButton2.Value = True) Then
        Call TwoButton
    End If
     If (OptionButton3.Value = True) Then
        Call ThreeButton
    End If
    If (OptionButton4.Value = True) Then
        Call FourButton
    End If
    If (OptionButton5.Value = True) Then
        Call FiveButton
    End If
    
End Sub
Private Sub ExitButton_Click()
    Unload Me
    MainForm.Show
End Sub

