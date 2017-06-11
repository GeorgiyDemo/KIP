Public cn As ADODB.Connection
Public rs As ADODB.Recordset
Private Sub CommandButton2_Click()
vklad.Hide
UserForm2.Show
End Sub
Private Sub CommandButton1_Click() 'кнопка добавить
    ShowEmptyRecord
    rs.AddNew
    dobav
   IsDisable = True
  CommandButton4.Enabled = False
   next11.Enabled = False
    CommandButton6.Enabled = False
     CommandButton8.Enabled = False
     CommandButton2.Enabled = False
     CommandButton9.Enabled = False
CommandButton7.Enabled = False
 CommandButton1.Enabled = False
  CommandButton11.Enabled = False
   CommandButton12.Enabled = False
   TextBox3.Enabled = False
   
   
End Sub

Private Sub CommandButton10_Click() '  измение зап.
    If MsgBox("Вы действительно хотите изменить данную запись?", vbYesNo 
+ vbQuestion) = vbYes Then
        Call dobav
        rs.Update
   
        If (Not IsDisable) Then
            IsDisable = False
        End If
    End If
      CommandButton4.Enabled = True
   next11.Enabled = True
    CommandButton6.Enabled = True
     CommandButton8.Enabled = True
     CommandButton2.Enabled = True
     CommandButton7.Enabled = True
      CommandButton9.Enabled = True
       CommandButton1.Enabled = True
        CommandButton11.Enabled = True
   CommandButton12.Enabled = True
   TextBox3.Enabled = True
   
End Sub

Private Sub CommandButton11_Click() '  последняя
    rs.MoveLast
    ShowRecord
End Sub

Private Sub CommandButton12_Click() ' первая
 rs.MoveFirst
    ShowRecord
End Sub



Private Sub CommandButton4_Click() '  поиск
 Dim ff, fff As Long
 Lname = TextBox6.Text
 
 If (Lname = "") Then
    MsgBox "Не заполнено поле для поиска записей по коду"
 Else
     If (IsNumeric(Lname) = True) Then
         
         criteria = "[Номер вклада] = '" & Lname & "'" '  ищем номер
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
        End If
         TextBox6.Text = Empty
        
End Sub


Private Sub CommandButton6_Click() ' предыдущая
 If (rs.BOF = False) Then rs.MovePrevious
    If (rs.BOF = False) Then ShowRecord
End Sub

Private Sub CommandButton7_Click() ' удаляем
 If (rs.RecordCount >= 1) Then
    If MsgBox("Удалить текущую запись?", vbYesNo + vbQuestion) = vbYes 
Then
        rs.Delete
        If (rs.RecordCount > 0) Then
            next11_Click
        Else
            ShowEmptyRecord
        End If
    End If
 End If
  
End Sub



Private Sub CommandButton8_Click() '  готовим текст для печати
Dim sum, itog As Integer
Dim i As Document
sum = CInt(TextBox4.Text)
itog = sum * 1.08 '  умнажаем вклад на 8%

Set i = Application.Documents.Add("C:\Users\Дос\Desktop\27\vklad.docx")
i.Bookmarks("дата").Range.Text = Date
i.Bookmarks("сотрудник").Range.Text = TextBox1
i.Bookmarks("сотрудник1").Range.Text = TextBox1
i.Bookmarks("клиент").Range.Text = TextBox2
i.Bookmarks("клиент1").Range.Text = TextBox2
i.Bookmarks("сумма").Range.Text = TextBox4
i.Bookmarks("номер").Range.Text = TextBox5
i.Bookmarks("итог").Range.Text = CStr(itog)


vklad.Hide

i.Activate
End Sub

Private Sub CommandButton9_Click() '  заполняем тектстбокс
ShowRecord
End Sub


Private Sub next11_Click() ' след. запись
If (rs.EOF = False) Then rs.MoveNext
    If (rs.EOF = False) Then ShowRecord
End Sub


Private Sub UserForm_initialize() '  связь
Set cn = New ADODB.Connection
cn.Provider = "Microsoft.ACE.OLEDB.12.0"
cn.ConnectionString = "C:\Users\Дос\Desktop\27\bank.accdb"
cn.Open
Set rs = New ADODB.Recordset
rs.CursorType = adOpenKeyset
rs.LockType = adLockOptimistic
rs.Source = "SELECT Вклад.* FROM Вклад;"
Set rs.ActiveConnection = cn
rs.Open


ShowEmptyRecord

End Sub

Private Sub ShowRecord() ' заполняем записи из текстбокса
     TextBox1.Text = rs.Fields("Сотрудник").Value
    TextBox2.Text = rs.Fields("Клиент").Value
    TextBox4.Text = rs.Fields("Сумма").Value
    TextBox3.Text = rs.Fields("Дата").Value
    TextBox5.Text = rs.Fields("Номер вклада").Value
End Sub
Private Sub ShowEmptyRecord() '  обнуление

    TextBox1.Text = Empty
    TextBox2.Text = Empty
      TextBox3.Text = Empty
      TextBox4.Text = Empty
      TextBox5.Text = Empty
End Sub
Private Sub dobav() ' добавление данных в запись из текстбокса
rs.Fields("Сотрудник").Value = TextBox1.Text
rs.Fields("Клиент").Value = TextBox2.Text
rs.Fields("Дата").Value = Date
rs.Fields("Сумма").Value = TextBox4.Text
rs.Fields("Номер вклада").Value = TextBox5.Text
End Sub
