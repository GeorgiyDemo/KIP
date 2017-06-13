Public cn As ADODB.Connection
Public cli, mngr, sale, content, goods As ADODB.Recordset

Private Sub Frame3_Click()

End Sub

Private Sub ListBox1_Click()

End Sub

Private Sub PrintButton_Click()

End Sub

Private Sub UserForm_initialize()
    
    Set cn = New ADODB.Connection
    cn.Provider = "Microsoft.ACE.OLEDB.12.0"
    cn.ConnectionString = "C:\Users\georgiydemo\Documents\DEMKA\Computer_store.accdb"
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
    mngr.Source = "SELECT [Менеджер по продажам].* FROM [Менеджер по продажам];"
    Set mngr.ActiveConnection = cn
    mngr.Open
    
    'Запросы для состава заказа
    Set content = New ADODB.Recordset
    content.CursorType = adOpenKeyset
    content.LockType = adLockOptimistic
    content.Source = "SELECT [Состав заказа].* FROM [Состав заказа];"
    Set content.ActiveConnection = cn
    content.Open
    
    'Запросы для состава заказа
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
    If MsgBox("Удалить текущую запись?", vbYesNo + vbQuestion) = vbYes Then
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
    If MsgBox("Вы действительно хотите обновить данную запись?", vbYesNo + vbQuestion) = vbYes Then
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
        If (sale.Fields("КодКлиента").Value = cli.Fields("Кодклиента").Value) Then
    
            TextBox6.Text = cli.Fields("Кодклиента").Value
            TextBox8.Text = cli.Fields("Клиент").Value
            TextBox7.Text = cli.Fields("ЕдТовара").Value
            TextBox5.Text = cli.Fields("КодМенеджера").Value
    
        End If
        cli.MoveNext
    Wend
    
    mngr.MoveFirst
    While Not mngr.EOF
        If (sale.Fields("КодМенеджераПродажи").Value = mngr.Fields("КодМенеджераПродажи").Value) Then
      
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
    
        If (sale.Fields("№ продажи").Value = content.Fields("№ Продажи").Value) Then
            goods.MoveFirst
            While Not goods.EOF

                If (content.Fields("КодТовара").Value = goods.Fields("КодТовара").Value) Then
                    ListBox1.AddItem goods.Fields("Товар").Value
                    ListBox1.List(i, 1) = content.Fields("Кол-во").Value
                    ListBox1.List(i, 2) = content.Fields("Цена").Value
                    tsum = tsum + ((content.Fields("Цена").Value) * (content.Fields("Кол-во").Value))
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

