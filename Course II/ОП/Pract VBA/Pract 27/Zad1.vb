Public cn As ADODB.Connection
Public rs As ADODB.Recordset
Public rsp As ADODB.Recordset

Private Sub UserForm_Initialize()

    Set cn = New ADODB.Connection
    cn.Provider = "Microsoft.ACE.OLEDB.12.0"
    cn.ConnectionString = "C:\Users\georgiydemo\Documents\Computer_store.accdb"
    cn.Open
    Set rs = New ADODB.Recordset
    rs.CursorType = adOpenKeyset
    rs.LockType = adLockOptimistic
    rs.Source = "SELECT Клиент.* FROM Клиент"
    Set rs.ActiveConnection = cn
    rs.Open

    CMDUpdateButton.Tag = "Update"
    'cmdUpdate.Tag = "Update"
    'CMDFirstButton_Click

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
    If (rs.EOF = False) Then
        rs.MoveNext
        ShowRecord
    Else
        rs.MoveLast
    End If
End Sub

Private Sub CMDPreviousButton_Click()

    If (Not rs.BOF) Then
        rs.MovePrevious
        ShowRecord
    Else
        rs.MoveFirst
    End If

End Sub

Private Sub CMDUpdateButton_Click()

    Call FillRecord
    rs.Update
    Call SetEnabled(True, True)
    If (Not IsDisable) Then
        IsDisable = False
    End If

End Sub

Private Sub SetEnabled(IsUpdateOn As Boolean, IsOthersOn As Boolean)
    Dim ctrl As Control
    For Each ctrl In Controls

    If (LCase(Left(ctrl.Name, 3)) = "cmd") Then
        If (ctrl.Tag = "Update") Then
            ctrl.Enabled = IsUpdateOn
            'продолжение..
End Sub

Private Sub FillRecord()

    'Тут проблема с типами, пока не знаю что делать
    rs.Fields("Кодклиента").Value = TextBox1.Text
    rs.Fields("Клиент").Value = TextBox2.Text

End Sub

Private Sub ShowRecord()

    TextBox1.Text = rs.Fields("Кодклиента").Value
    TextBox2.Text = rs.Fields("Клиент").Value

End Sub

Private Sub ShowEmptyRecord()

    TextBox1.Text = Empty
    TextBox2.Text = Empty

End Sub

Private Sub ExitButton_Click()

    Unload Me
    BDMainForm.Show

End Sub
