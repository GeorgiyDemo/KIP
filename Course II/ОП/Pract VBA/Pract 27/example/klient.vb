Public cn As ADODB.Connection
Public rs As ADODB.Recordset
Private Sub CommandButton1_Click() 'кнопка добавление
    ShowEmptyRecord
    rs.AddNew
    dobav
   IsDisable = True
  obnova.Enabled = False 'брокируем кнопки
   del.Enabled = False
    poisk.Enabled = False
     nazad11.Enabled = False
      nazad.Enabled = False
       next1.Enabled = False
       CommandButton1.Enabled = False
End Sub
Private Sub CommandButton3_Click()
UserForm4.Hide
UserForm2.Show
End Sub
Private Sub CommandButton4_Click() 'изменяем запись
    If MsgBox("Вы действительно хотите изменить данную запись?", vbYesNo 
+ vbQuestion) = vbYes Then
        Call dobav
        rs.Update
   
        If (Not IsDisable) Then
            IsDisable = False
        End If
    End If
    obnova.Enabled = True 'активируем кнопки
   del.Enabled = True
    poisk.Enabled = True
     nazad11.Enabled = True
      nazad.Enabled = True
       next1.Enabled = True
        CommandButton1.Enabled = True
End Sub

Private Sub del_Click() 'удаляем запись
 If (rs.RecordCount >= 1) Then
    If MsgBox("Удалить текущую запись?", vbYesNo + vbQuestion) = vbYes 
Then
        rs.Delete
        If (rs.RecordCount > 0) Then
            next1_Click
        Else
            ShowEmptyRecord
        End If
    End If
 End If
End Sub
Private Sub nazad_Click() 'переход к предыдущей записи
    If (rs.BOF = False) Then rs.MovePrevious
    If (rs.BOF = False) Then ShowRecord
End Sub
Private Sub nazad11_Click()
klient.Hide
UserForm2.Show
End Sub

Private Sub next1_Click() ' переход к след. записи
If (rs.EOF = False) Then rs.MoveNext
    If (rs.EOF = False) Then ShowRecord
End Sub
Private Sub obnova_Click() ' заполняем текстбоксы
ShowRecord
End Sub

Private Sub pervy_Click() 'переход к первой записи
    rs.MoveFirst
    ShowRecord
End Sub
Private Sub poisk_Click() ' кнопка поиска
 Dim ff, fff As Long
 Lname = TextBox4.Text
 If (Lname = "") Then 'если нечего не введено
    MsgBox "Не заполнено поле для поиска записей по коду"
 Else
     If (IsNumeric(Lname) = True) Then
         
         criteria = "[Код клиента] = '" & Lname & "'" 'ищем по коду
         ff = 0
         fff = adSearchForward
         rs.MoveFirst
         rs.Find criteria, ff, fff
         
         If rs.EOF Then 'если конец  записи
            MsgBox "Запись c кодом " + CStr(Lname) + " не найдена"
            Beep
         Else
            MsgBox "Запись c кодом " + CStr(Lname) + " найдена!"
            Beep
            ShowRecord
        End If
    End If
    If (IsNumeric(Lname) = False) Then
        criteria = "[ФИО] = '" & Lname & "'" ' ищем по фамилии
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
Private Sub posled_Click() ' переход к последней записи
    rs.MoveLast
    ShowRecord
End Sub

Private Sub UserForm_initialize() ' связь access c VBA
Set cn = New ADODB.Connection
cn.Provider = "Microsoft.ACE.OLEDB.12.0"
cn.ConnectionString = "C:\Users\Дос\Desktop\27\bank.accdb"
cn.Open
Set rs = New ADODB.Recordset
rs.CursorType = adOpenKeyset
rs.LockType = adLockOptimistic
rs.Source = "SELECT Клиент.* FROM Клиент;"
Set rs.ActiveConnection = cn
rs.Open
ShowEmptyRecord
End Sub
Private Sub ShowRecord() ' заполняем textbox  из  записей
    TextBox2.Text = rs.Fields("Код клиента").Value
    TextBox1.Text = rs.Fields("ФИО").Value
    TextBox3.Text = rs.Fields("Адрес").Value
End Sub
Private Sub ShowEmptyRecord() ' обнуляем textbox

    TextBox1.Text = Empty
    TextBox2.Text = Empty
      TextBox3.Text = Empty
End Sub
Private Sub dobav() ' добавляем данные в запись из textbox
rs.Fields("ФИО").Value = TextBox1.Text
rs.Fields("Код клиента").Value = TextBox2.Text
rs.Fields("Адрес").Value = TextBox3.Text
End Sub
