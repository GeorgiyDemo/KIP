Public kmangr, klient As ADODB.Recordset

Private Sub UserForm_initialize()

    'Recordset для всей БД
    Set cn = New ADODB.Connection
    cn.Provider = "Microsoft.ACE.OLEDB.12.0"
    cn.ConnectionString = 
"C:\Users\georgiydemo\Documents\DEMKA\Computer_store.accdb"
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
    kmangr.Source = "SELECT [Менеджер по работе с клиентами].* FROM 
[Менеджер по работе с клиентами];"
    Set kmangr.ActiveConnection = cn
    kmangr.Open
    
    
    'Set sot = New ADODB.Recordset
    'sot.CursorType = adOpenKeyset
    'sot.LockType = adLockOptimistic
    'sot.Source = "SELECT Сотрудник.* FROM Сотрудник;" ' sot= таблица 
сотрудники
    'Set sot.ActiveConnection = cn
    'sot.Open

End Sub

Private Sub ExitButton_Click()
    Unload Me
    DOCMainForm.Show
End Sub

Private Sub OneButton_Click()

    Dim sredcounter, sredsum, codemax, codemin, kmax, kmin, buf As 
Integer
    Dim kmaxname, kminname As String
    Dim kotuk_doc As Document
    Set kotuk_doc = 
Application.Documents.Add("C:\Users\georgiydemo\Documents\DEMKA\OneButton.docx")
    
    klient.MoveFirst
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
            codemin = klient.Fields("КодКлиента").Value
            kminname = klient.Fields("Клиент").Value
        End If
        
        If (buf > kmax) Then
            kmax = buf
            codemax = klient.Fields("КодКлиента").Value
            kmaxname = klient.Fields("Клиент").Value
        End If
        
        klient.MoveNext
    Wend

    kotuk_doc.Bookmarks("дата").Range.Text = Date
    kotuk_doc.Bookmarks("время").Range.Text = Time
    
    kotuk_doc.Bookmarks("макс_код").Range.Text = CStr(codemax)
    kotuk_doc.Bookmarks("макс_фио").Range.Text = CStr(kmaxname)
    kotuk_doc.Bookmarks("макс_товар").Range.Text = CStr(kmax)
    
    kotuk_doc.Bookmarks("мин_код").Range.Text = CStr(codemin)
    kotuk_doc.Bookmarks("мин_фио").Range.Text = CStr(kminname)
    kotuk_doc.Bookmarks("мин_товар").Range.Text = CStr(kmin)
    
    kotuk_doc.Bookmarks("макс_код_общ").Range.Text = CStr(codemax)
    kotuk_doc.Bookmarks("мин_код_общ").Range.Text = CStr(codemin)
    kotuk_doc.Bookmarks("сред_код_общ").Range.Text = CStr(sredsum / 
sredcounter)
    
    
    DOCListForm.Hide
    kotuk_doc.Activate

End Sub

