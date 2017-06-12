Public kmangr, klient, goods As ADODB.Recordset

Private Sub TwoButton_Click()
    Dim kot As Document
    Dim i As Integer
    
    Set kot = Application.Documents.Add("C:\Users\georgiydemo\Documents\DEMKA\UniversalDOC.docx")
    goods.MoveFirst
    i = 0
    
    Do Until goods.EOF
        i = i + 1
        goods.MoveNext
    Loop

    kot.Tables.Add Range:=Selection.Range, NumRows:=i + 1, NumColumns:=2, DefaultTableBehavior:=wdWord9TableBehavior, 
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
        Selection.Tables(1).Cell(i, 1).Range.Text = goods.Fields("КодТовара").Value
        Selection.Tables(1).Cell(i, 2).Range.Text = goods.Fields("Товар").Value
        goods.MoveNext
    Loop
    
    kot.Bookmarks("тема_отчета").Range.Text = "*Общий отчет по всем товарам, доступным в магазине*"
    kot.Bookmarks("время").Range.Text = Time
    kot.Bookmarks("дата").Range.Text = Date
    
    DOCListForm.Hide
    kot.Activate

End Sub

Private Sub UserForm_initialize()

    'Recordset для всей БД
    Set cn = New ADODB.Connection
    cn.Provider = "Microsoft.ACE.OLEDB.12.0"
    cn.ConnectionString = "C:\Users\georgiydemo\Documents\DEMKA\Computer_store.accdb"
    cn.Open
    
    'Параметры для запроса к клиентам
    Set klient = New ADODB.Recordset
    klient.CursorType = adOpenKeyset
    klient.LockType = adLockOptimistic
    klient.Source = "SELECT Клиент.* FROM Клиент;"
    Set klient.ActiveConnection = cn
    klient.Open
    
    'Параметры для запроса менеджеров по работе с клиентами
    Set kmangr = New ADODB.Recordset
    kmangr.CursorType = adOpenKeyset
    kmangr.LockType = adLockOptimistic
    kmangr.Source = "SELECT [Менеджер по работе с клиентами].* FROM [Менеджер по работе с клиентами];"
    Set kmangr.ActiveConnection = cn
    kmangr.Open
    
    'Параметры для запроса к товарам
    Set goods = New ADODB.Recordset
    goods.CursorType = adOpenKeyset
    goods.LockType = adLockOptimistic
    goods.Source = "SELECT [Товар].* FROM [Товар];"
    Set goods.ActiveConnection = cn
    goods.Open
    
End Sub

Private Sub ExitButton_Click()
    Unload Me
    DOCMainForm.Show
End Sub

Private Sub OneButton_Click()

    Dim sredcounter, sredsum, codemax, codemin, kmax, kmin, buf, mangrmax, mangrmin As Integer
    Dim kmaxname, kminname As String
    Dim kotuk_doc As Document
    Set kotuk_doc = Application.Documents.Add("C:\Users\georgiydemo\Documents\DEMKA\OneButton.docx")
    
    klient.MoveFirst
    kmangr.MoveFirst
    
    kmax = CInt(klient.Fields("ЕдТовара").Value)
    kmin = kmax
    sredcounter = 0
    sredsum = 0
    
    While Not klient.EOF
        buf = CInt(klient.Fields("ЕдТовара").Value)
        sredcounter = sredcounter + 1
        sredsum = sredsum + CInt(klient.Fields("ЕдТовара").Value)
        If (buf < kmin) Then
            kmin = buf
            mangrmin = klient.Fields("КодМенеджера").Value
            codemin = klient.Fields("КодКлиента").Value
            kminname = klient.Fields("Клиент").Value
        End If
        
        If (buf > kmax) Then
            kmax = buf
            mangrmax = klient.Fields("КодМенеджера").Value
            codemax = klient.Fields("КодКлиента").Value
            kmaxname = klient.Fields("Клиент").Value
        End If
        
        klient.MoveNext
    Wend
    
    'Ищем ищем лучшего менеджера
    While Not kmangr.EOF
        If (mangrmax = kmangr.Fields("Код").Value) Then
            kotuk_doc.Bookmarks("макс_менеджер_фио").Range.Text = kmangr.Fields("Фамилия").Value + " " + 
kmangr.Fields("Имя").Value + " " + kmangr.Fields("Отчество").Value
            kotuk_doc.Bookmarks("макс_менеджер_телефон").Range.Text = kmangr.Fields("Телефон").Value
        End If
        kmangr.MoveNext
    Wend
    
    'Ищем худшего менеджера
    kmangr.MoveFirst
    While Not kmangr.EOF
        If (mangrmin = kmangr.Fields("Код").Value) Then
            kotuk_doc.Bookmarks("мин_менеджер_фио").Range.Text = kmangr.Fields("Фамилия").Value + " " + 
kmangr.Fields("Имя").Value + " " + kmangr.Fields("Отчество").Value
            kotuk_doc.Bookmarks("мин_менеджер_телефон").Range.Text = kmangr.Fields("Телефон").Value
        End If
        kmangr.MoveNext
    Wend
    
    With kotuk_doc
        .Bookmarks("дата").Range.Text = Date
        .Bookmarks("время").Range.Text = Time
        .Bookmarks("макс_код").Range.Text = CStr(codemax)
        .Bookmarks("макс_фио").Range.Text = CStr(kmaxname)
        .Bookmarks("макс_товар").Range.Text = CStr(kmax)
        .Bookmarks("мин_код").Range.Text = CStr(codemin)
        .Bookmarks("мин_фио").Range.Text = CStr(kminname)
        .Bookmarks("мин_товар").Range.Text = CStr(kmin)
        .Bookmarks("макс_код_общ").Range.Text = CStr(codemax)
        .Bookmarks("мин_код_общ").Range.Text = CStr(codemin)
        .Bookmarks("сред_код_общ").Range.Text = CStr(sredsum / sredcounter)
    End With
    
    DOCListForm.Hide
    kotuk_doc.Activate

End Sub

