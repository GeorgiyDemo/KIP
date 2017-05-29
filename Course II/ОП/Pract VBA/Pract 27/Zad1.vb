Public cn As ADODB.Connection
Public rs As ADODB.Recordset
Public rsp As ADODB.Recordset

Private Sub CMDFirstButton_Click()
    rs.MoveFirst
    Call ShowRecord
End Sub

Private Sub CMDLastButton_Click()
    rs.MoveLast
    ShowRecord
End Sub

Private Sub CMDNextButton_Click()
    If Not rs.EOF Then
        rs.MoveNext
        ShowRecord
    Else
        rs.MoveLast
    End If
End Sub

Private Sub CMDPreviousButton_Click()
    If Not rs.BOF Then
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

Private Sub UserForm_Initialize()

    Set cn = New ADODB.Connection
    cn.Provider = "Microsoft.ACE.OLEDB.12.0"
    cn.ConnectionString = "C:\Computer_store.accdb"
    cn.Open
    Set rs = New ADODB.Recordset
    rs.CursorType = adOpenKeyset
    rs.LockType = adLockOptimistic
    rs.Source = "SELECT Клиент.* FROM Клиент"
    Set rs.ActiveConnection = cn
    rs.Open

    'cmdUpdate.Tag = "Update"
    'CMDFirstButton_Click

    'ShowEmptyRecord
    'Call ShowRecord

End Sub

Private Sub SetEnabled(IsUpdateOn As Boolean, IsOthersOn As Boolean)

End Sub

Private Sub FillRecord()

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
