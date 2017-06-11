Public cn As ADODB.Connection
Public rs As ADODB.Recordset

Private Sub CMDFindFirstSearch_Click()

    Dim skiprecord As Long
    Dim direction As Long
    Lname = TextBoxSearch.Text
    
    k = InputBox("По какому критерию вы хотите выполнить поиск?" + Chr(13) + "1. Код" + Chr(13) + "2. Имя" + Chr(13) + "3. 
Фамилия" + Chr(13) + "4. Отчество" + Chr(13) + "5. Телефон")
    
    criteria = "[КодМенеджераПродажи] = '" & Lname & "'"
         skiprecord = 0
         direction = adSearchForward
         rs.MoveFirst
         rs.Find criteria, skiprecord, direction
         
         If rs.EOF Then
            MsgBox "Запись c кодом " + CStr(Lname) + " не найдена"
            Beep
         Else
            MsgBox "Запись c кодом " + CStr(Lname) + " найдена!"
            Beep
            ShowRecord
        End If
    '
End Sub

Private Sub RefreshButton_Click()
    ShowRecord
End Sub

Private Sub UserForm_initialize()

    Set cn = New ADODB.Connection
    cn.Provider = "Microsoft.ACE.OLEDB.12.0"
    cn.ConnectionString = "C:\Users\georgiydemo\Documents\Computer_store.accdb"
    cn.Open
    Set rs = New ADODB.Recordset
    rs.CursorType = adOpenKeyset
    rs.LockType = adLockOptimistic
    rs.Source = "SELECT [Менеджер по продажам].* FROM [Менеджер по продажам];"
    Set rs.ActiveConnection = cn
    rs.Open
    
    CMDUpdateButton.Tag = "Update"
    ShowEmptyRecord
    CMDFirstButton_Click
    
End Sub

Private Sub CMDAddButton_Click()

    ShowEmptyRecord
    rs.AddNew
    FillRecord
    TextBox1.SetFocus
    IsDisable = True
    SetEnabled True, False

End Sub

Private Sub CMDDeleteButton_Click()

 If (rs.RecordCount >= 1) Then
    If MsgBox("Удалить текущую запись?", vbYesNo + vbQuestion) = vbYes Then
        rs.Delete
        If (rs.RecordCount > 0) Then
            CMDNextButton_Click
        Else
            ShowEmptyRecord
        End If
    End If
 End If
End Sub

Private Sub CMDFirstButton_Click()
    rs.MoveFirst
    ShowRecord
End Sub

Private Sub CMDLastButton_Click()
    rs.MoveLast
    ShowRecord
End Sub

Private Sub CMDNextButton_Click()
    If (rs.EOF = False) Then rs.MoveNext
    If (rs.EOF = False) Then ShowRecord
End Sub

Private Sub CMDPreviousButton_Click()
    If (rs.BOF = False) Then rs.MovePrevious
    If (rs.BOF = False) Then ShowRecord
End Sub

Private Sub CMDUpdateButton_Click()
    If MsgBox("Вы действительно хотите обновить данную запись?", vbYesNo + vbQuestion) = vbYes Then
        Call FillRecord
        rs.Update
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

    rs.Fields("Имя").Value = TextBox2.Text
    rs.Fields("Фамилия").Value = TextBox3.Text
    rs.Fields("Отчество").Value = TextBox4.Text
    rs.Fields("Телефон").Value = TextBox5.Text
    
End Sub

Private Sub ShowRecord()

    TextBox1.Text = rs.Fields("КодМенеджераПродажи").Value
    TextBox2.Text = rs.Fields("Имя").Value
    TextBox3.Text = rs.Fields("Фамилия").Value
    TextBox4.Text = rs.Fields("Отчество").Value
    TextBox5.Text = rs.Fields("Телефон").Value
    
End Sub

Private Sub ShowEmptyRecord()

    TextBox1.Text = Empty
    TextBox2.Text = Empty
    TextBox3.Text = Empty
    TextBox4.Text = Empty
    TextBox5.Text = Empty

End Sub

Private Sub ExitButton_Click()

    Unload Me
    BDMainForm.Show
    
End Sub

