Public cn As ADODB.Connection
Public rs As ADODB.Recordset

Private Sub CommandButton1_Click() 'кнопка добавить
    ShowEmptyRecord
    rs.AddNew
    dobav
   IsDisable = True
  CommandButton9.Enabled = False
    CommandButton8.Enabled = False
      CommandButton7.Enabled = False
        CommandButton6.Enabled = False
          CommandButton2.Enabled = False
            CommandButton3.Enabled = False
             CommandButton4.Enabled = False
                CommandButton5.Enabled = False
                CommandButton1.Enabled = False
 
End Sub

Private Sub CommandButton10_Click() 'изменяем запись
If MsgBox("Вы действительно хотите изменить данную запись?", vbYesNo + 
vbQuestion) = vbYes Then
        Call dobav ' вызваем функцию dobav
        rs.Update 'обновляем записи
   
        If (Not IsDisable) Then
            IsDisable = False
        End If
    End If
      CommandButton9.Enabled = True
    CommandButton8.Enabled = True
      CommandButton7.Enabled = True
        CommandButton6.Enabled = True
          CommandButton2.Enabled = True
            CommandButton3.Enabled = True
                CommandButton5.Enabled = True
                CommandButton4.Enabled = True
                   CommandButton1.Enabled = True
End Sub

Private Sub CommandButton2_Click() 'удаляем запись
 If (rs.RecordCount >= 1) Then
    If MsgBox("Удалить текущую запись?", vbYesNo + vbQuestion) = vbYes 
Then
        rs.Delete
        If (rs.RecordCount > 0) Then ' если не кончились записи
           CommandButton5_Click ' след. запись
        Else
            ShowEmptyRecord
        End If
    End If
 End If
End Sub

Private Sub CommandButton3_Click()
sotrudnik.Hide
UserForm2.Show
End Sub

Private Sub CommandButton4_Click() 'поиск
 Dim ff, fff As Long
 Lname = TextBox4.Text ' текст для поиска
 
 If (Lname = "") Then
    MsgBox "Не заполнено поле для поиска записей по коду"
 Else
     If (IsNumeric(Lname) = True) Then
         
         criteria = "[Табельный номер] = '" & Lname & "'" ' поиск по 
номеру
         ff = 0
         fff = adSearchForward
         rs.MoveFirst
         rs.Find criteria, ff, fff
         
         If rs.EOF Then
            MsgBox "Запись c кодом " + CStr(Lname) + " не найдена"
            Beep
         Else
            MsgBox "Запись c кодом " + CStr(Lname) + " найдена!"
            Beep
            ShowRecord
        End If
    End If
    If (IsNumeric(Lname) = False) Then ' поиск по фио
        criteria = "[ФИО] = '" & Lname & "'"
         ff = 0
         fff = adSearchForward
         rs.MoveFirst
         rs.Find criteria, ff, fff
         
         If rs.EOF Then
            MsgBox "Запись c ФИО '" + CStr(Lname) + "' не найдена"
            Beep
         Else
            MsgBox "Запись c ФИО '" + CStr(Lname) + "' найдена!"
            Beep
            ShowRecord
        End If
    End If
  End If
  TextBox4.Text = Empty
End Sub

Private Sub CommandButton5_Click() ' след. запись
If (rs.EOF = False) Then rs.MoveNext
    If (rs.EOF = False) Then ShowRecord
End Sub

Private Sub CommandButton6_Click() 'предыдущая запись
   If (rs.BOF = False) Then rs.MovePrevious
    If (rs.BOF = False) Then ShowRecord
End Sub

Private Sub CommandButton7_Click() 'последняя запись
  rs.MoveLast
    ShowRecord
End Sub

Private Sub CommandButton8_Click() ' первая запись
rs.MoveFirst
    ShowRecord
End Sub

Private Sub CommandButton9_Click() 'заполняем текстом
ShowRecord
End Sub

Private Sub UserForm_initialize() 'связь
Set cn = New ADODB.Connection
cn.Provider = "Microsoft.ACE.OLEDB.12.0"
cn.ConnectionString = "C:\Users\Дос\Desktop\27\bank.accdb"
cn.Open
Set rs = New ADODB.Recordset
rs.CursorType = adOpenKeyset
rs.LockType = adLockOptimistic
rs.Source = "SELECT Сотрудник.* FROM Сотрудник;"
Set rs.ActiveConnection = cn
rs.Open

ShowEmptyRecord
End Sub
Private Sub ShowRecord() ' заполняем текстбокс из записи

    TextBox2.Text = rs.Fields("Табельный номер").Value
    TextBox1.Text = rs.Fields("ФИО").Value
    TextBox3.Text = rs.Fields("Должность").Value
End Sub
Private Sub ShowEmptyRecord() ' обнуляем текстбоксы

    TextBox1.Text = Empty
    TextBox2.Text = Empty
      TextBox3.Text = Empty
End Sub

Private Sub dobav() ' добавляем в запись из текстбокс
rs.Fields("ФИО").Value = TextBox1.Text
rs.Fields("Табельный номер").Value = TextBox2.Text
rs.Fields("Должность").Value = TextBox3.Text
End Sub

