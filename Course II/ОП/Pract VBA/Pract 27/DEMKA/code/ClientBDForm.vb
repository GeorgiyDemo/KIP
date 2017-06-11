Public cn As ADODB.Connection
Public mainclient, clientmanager As ADODB.Recordset

Private Sub UserForm_initialize()

    Set cn = New ADODB.Connection
    cn.Provider = "Microsoft.ACE.OLEDB.12.0"
    cn.ConnectionString = "C:\Users\georgiydemo\Documents\DEMKA\Computer_store.accdb"
    cn.Open

    Set mainclient = New ADODB.Recordset
    mainclient.CursorType = adOpenKeyset
    mainclient.LockType = adLockOptimistic
    mainclient.Source = "SELECT Клиент.* FROM Клиент"
    Set mainclient.ActiveConnection = cn
    mainclient.Open

    Set clientmanager = New ADODB.Recordset
    clientmanager.CursorType = adOpenKeyset
    clientmanager.LockType = adLockOptimistic
    clientmanager.Source = "SELECT [Менеджер по работе с клиентами].* FROM [Менеджер по работе с клиентами];"
    Set clientmanager.ActiveConnection = cn
    clientmanager.Open

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
         mainclient.MoveFirst
         mainclient.Find criteria, skiprecord, direction

         If mainclient.EOF Then
            MsgBox "Запись c кодом " + CStr(Lname) + " не найдена"
            Beep
         Else
            ShowRecord
            Beep
        End If
    End If
    If (IsNumeric(Lname) = False) Then
        criteria = "[Клиент] = '" & Lname & "'"
         skiprecord = 0
         direction = adSearchForward
         mainclient.MoveFirst
         mainclient.Find criteria, skiprecord, direction

         If mainclient.EOF Then
            MsgBox "Запись c ФИО '" + CStr(Lname) + "' не найдена"
            Beep
         Else
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
    mainclient.AddNew
    FillRecord
    TextBox1.SetFocus
    IsDisable = True
    SetEnabled True, False

End Sub

Private Sub CMDDeleteButton_Click()
 If (mainclient.RecordCount >= 1) Then
    If MsgBox("Удалить текущую запись?", vbYesNo + vbQuestion) = vbYes Then
        mainclient.Delete
        If (mainclient.RecordCount > 0) Then
            CMDNextButton_Click
        Else
            ShowEmptyRecord
        End If
    End If
 End If
End Sub

Private Sub CMDFirstButton_Click()
    mainclient.MoveFirst
    ShowRecord
End Sub

Private Sub CMDLastButton_Click()
    mainclient.MoveLast
    ShowRecord
End Sub

Private Sub CMDNextButton_Click()
    If (mainclient.EOF = False) Then mainclient.MoveNext
    If (mainclient.EOF = False) Then ShowRecord
End Sub

Private Sub CMDPreviousButton_Click()
    If (mainclient.BOF = False) Then mainclient.MovePrevious
    If (mainclient.BOF = False) Then ShowRecord
End Sub

Private Sub CMDUpdateButton_Click()
    If MsgBox("Вы действительно хотите обновить данную запись?", vbYesNo + vbQuestion) = vbYes Then
        Call FillRecord
        mainclient.Update
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
    mainclient.Fields("Клиент").Value = CStr(TextBox2.Text)
    mainclient.Fields("ЕдТовара").Value = CInt(TextBox3.Text)
    mainclient.Fields("КодМенеджера").Value = CInt(TextBox4.Text)
End Sub

Private Sub ShowRecord()

    TextBox1.Text = mainclient.Fields("Кодклиента").Value
    TextBox2.Text = mainclient.Fields("Клиент").Value
    TextBox3.Text = mainclient.Fields("ЕдТовара").Value
    TextBox4.Text = mainclient.Fields("КодМенеджера").Value


    clientmanager.MoveFirst
    While Not clientmanager.EOF
        If (mainclient.Fields("КодМенеджера").Value = clientmanager.Fields("Код").Value) Then

            TextBox5.Text = clientmanager.Fields("Телефон").Value
            TextBox6.Text = clientmanager.Fields("Код").Value
            TextBox7.Text = clientmanager.Fields("Имя").Value
            TextBox8.Text = clientmanager.Fields("Фамилия").Value
            TextBox9.Text = clientmanager.Fields("Отчество").Value


        End If
        clientmanager.MoveNext
    Wend

End Sub

Private Sub ShowEmptyRecord()

    TextBox1.Text = Empty
    TextBox2.Text = Empty
    TextBox3.Text = 0
    TextBox4.Text = 1

End Sub

Private Sub ExitButton_Click()

    Unload Me
    BDMainForm.Show

End Sub
