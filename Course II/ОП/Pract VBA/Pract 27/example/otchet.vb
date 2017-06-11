Dim sumk, sumv, itog As Integer
Public cn As ADODB.Connection
Public rs As ADODB.Recordset
Public rss As ADODB.Recordset
Public sot As ADODB.Recordset

Private Sub CheckBox1_Click() '  отчет о прибыли
While Not rs.EOF '  пока не конец записи
sumk = sumk + CInt(rs.Fields("Сумма").Value) '  суммируем
rs.MoveNext '  след. запись
Wend

While Not rss.EOF
sumv = sumv + CInt(rss.Fields("Сумма").Value)
rss.MoveNext
Wend

itog = sumv - sumk '  итог вклад-кредит

Dim i As Document '  выводим в форд
Set i = Application.Documents.Add("C:\Users\Дос\Desktop\27\otchet.docx")
i.Bookmarks("дата").Range.Text = Date

i.Bookmarks("кредит").Range.Text = CStr(sumk) '  в закладку кредит 
помешаем сумму кредита
i.Bookmarks("вклад").Range.Text = CStr(sumv)
i.Bookmarks("итог").Range.Text = CStr(itog)

otchet.Hide
i.Activate
End Sub

Private Sub CheckBox2_Click() '  поиск по дате
Dim ot, doo
ot = InputBox("Введите дату ОТ: (пример: 01.01.2000)") '  берем дату
doo = InputBox("Введите дату ДО: (пример: 01.01.2000)")
Dim i As Document
Set i = 
Application.Documents.Add("C:\Users\Дос\Desktop\27\otchet_kredit.docx")
i.Bookmarks("дата1").Range.Text = Date
i.Bookmarks("от").Range.Text = CStr(ot)
i.Bookmarks("до").Range.Text = CStr(doo)
While Not rss.EOF '  пока не конец записи
If (ot < CDate(rss.Fields("Дата").Value) And doo > 
CDate(rss.Fields("Дата").Value)) Then '  если запись входит в 
промежуток,то
i.Bookmarks("сотрудник").Range.Text = rss.Fields("Сотрудник").Value & 
Chr(13) '  вывод инфу о договоре
i.Bookmarks("клиент").Range.Text = rss.Fields("Клиент").Value & Chr(13)
i.Bookmarks("сумма").Range.Text = rss.Fields("Сумма").Value & Chr(13)
i.Bookmarks("дата").Range.Text = rss.Fields("Дата").Value & Chr(13)
End If
rss.MoveNext '  след запись
Wend
otchet.Hide
i.Activate

End Sub

Private Sub CheckBox3_Click() '  отчет о работники по фамилии
Dim fio
fio = InputBox("Введите ФИО сотрудника") '  спрашиваем фио


Dim i As Document
Set i = 
Application.Documents.Add("C:\Users\Дос\Desktop\27\otchet_rabotnik.docx")
i.Bookmarks("дата").Range.Text = Date
i.Bookmarks("работник").Range.Text = fio

While Not rs.EOF
If (fio = rs.Fields("Сотрудник").Value) Then '  если наш сотрудник,то 
выводим
i.Bookmarks("договор").Range.Text = rs.Fields("Номер вклада").Value & " 
от  " & rs.Fields("Дата").Value & Chr(13)
End If
rs.MoveNext
Wend

While Not rss.EOF
If (fio = rss.Fields("Сотрудник").Value) Then '  ищем этого же 
сотрудника в записях о кредитах
i.Bookmarks("договор1").Range.Text = rss.Fields("Номер кредита").Value & 
" от  " & rss.Fields("Дата").Value & Chr(13)
End If
rss.MoveNext ' след
Wend
i.Activate
otchet.Hide
End Sub

Private Sub CheckBox4_Click() '  отчет с датой о вкладах
Dim ot, doo
ot = InputBox("Введите дату ОТ: (пример: 01.01.2000)")
doo = InputBox("Введите дату ДО: (пример: 01.01.2000)")
Dim i As Document
Set i = 
Application.Documents.Add("C:\Users\Дос\Desktop\27\otchet_vklad.docx")
i.Bookmarks("дата1").Range.Text = Date
i.Bookmarks("от").Range.Text = CStr(ot)
i.Bookmarks("до").Range.Text = CStr(doo)
While Not rs.EOF
If (ot < CDate(rs.Fields("Дата").Value) And doo > 
CDate(rs.Fields("Дата").Value)) Then
i.Bookmarks("сотрудник").Range.Text = rs.Fields("Сотрудник").Value & 
Chr(13)
i.Bookmarks("клиент").Range.Text = rs.Fields("Клиент").Value & Chr(13)
i.Bookmarks("сумма").Range.Text = rs.Fields("Сумма").Value & Chr(13)
i.Bookmarks("дата").Range.Text = rs.Fields("Дата").Value & Chr(13)

End If
rs.MoveNext
Wend
otchet.Hide
i.Activate
End Sub

Private Sub CommandButton1_Click()
otchet.Hide
UserForm1.Show

End Sub
Private Sub UserForm_initialize() ' связь
Set cn = New ADODB.Connection
cn.Provider = "Microsoft.ACE.OLEDB.12.0"
cn.ConnectionString = "C:\Users\Дос\Desktop\27\bank.accdb"
cn.Open
Set rs = New ADODB.Recordset ' rs= таблица Вклады
rs.CursorType = adOpenKeyset
rs.LockType = adLockOptimistic
rs.Source = "SELECT Вклад.* FROM Вклад;"
Set rs.ActiveConnection = cn
rs.Open



Set rss = New ADODB.Recordset ' rss= таблица кредиты
rss.CursorType = adOpenKeyset
rss.LockType = adLockOptimistic
rss.Source = "SELECT Кредит.* FROM Кредит;"
Set rss.ActiveConnection = cn
rss.Open


Set sot = New ADODB.Recordset
sot.CursorType = adOpenKeyset
sot.LockType = adLockOptimistic
sot.Source = "SELECT Сотрудник.* FROM Сотрудник;" ' sot= таблица 
сотрудники
Set sot.ActiveConnection = cn
sot.Open

End Sub

