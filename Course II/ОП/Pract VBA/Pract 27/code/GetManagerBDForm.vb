Public cn As ADODB.Connection
Public rs As ADODB.Recordset

Private Sub CMDFindFirstSearch_Click()
    On Error GoTo ErrorHandler
    Dim skiprecord As Long
    Dim direction As Long
    Lname = TextBoxSearch.Text
    
    k = InputBox("По какому критерию вы хотите выполнить поиск?" + 
Chr(13) + "1. Код" + Chr(13) + "2. Имя" + Chr(13) + "3. Фамилия" + 
Chr(13) + "4. Отчество" + Chr(13) + "5. Телефон")
    
    Select Case k
        Case 1
            criteria = "[КодМенеджераПоставки] = '" & Lname & "'"
        Case 2
            criteria = "[Имя] = '" & Lname & "'"
        Case 3
            criteria = "[Фамилия] = '" & Lname & "'"
        Case 4
            criteria = "[Отчество] = '" & Lname & "'"
        Case 5
            criteria = "[Телефон] = '" & Lname & "'"
    End Select
        
    skiprecord = 0
    direction = adSearchForward
    rs.MoveFirst
    rs.Find criteria, skiprecord, direction
             
    If rs.EOF Then
        MsgBox "Запись не найдена"
        Beep
    Else
        MsgBox "Запись найдена!"
        ShowRecord
        Beep
    End If
ErrorHandler:
    On Error Resume Next
End Sub

Private Sub PrintButton_Click()
    Dim kot As Document
    Dim i As Integer
    Set kot = 
Application.Documents.Add("C:\Users\georgiydemo\Documents\DEMKA\UniversalDOC.docx")
    
    i = 0
    rs.MoveFirst
    
    Do Until rs.EOF
        i = i + 1
        rs.MoveNext
    Loop
    
        kot.Tables.Add Range:=Selection.Range, NumRows:=i + 1, 
NumColumns:=5, DefaultTableBehavior:=wdWord9TableBehavior, 
AutoFitBehavior:=wdAutoFitContent
            
            With Selection.Tables(1)
                If .Style <> "Сетка таблицы" Then
                    .Style = "Сетка таблицы"
                End If
                .ApplyStyleHeadingRows = True
                .ApplyStyleLastRow = True
                .ApplyStyleFirstColumn = True
                .ApplyStyleLastColumn = True
                .Cell(0, 1).Range.Text = "№"
                .Cell(0, 2).Range.Text = "Фамилия"
                .Cell(0, 3).Range.Text = "Имя"
                .Cell(0, 4).Range.Text = "Отчество"
                .Cell(0, 5).Range.Text = "Телефон"
                i = 1
            rs.MoveFirst
            End With
     
        Do Until rs.EOF
            i = i + 1
            With Selection.Tables(1)
                .Cell(i, 1).Range.Text = 
rs.Fields("КодМенеджераПоставки").Value
                .Cell(i, 2).Range.Text = rs.Fields("Фамилия").Value
                .Cell(i, 3).Range.Text = rs.Fields("Имя").Value
                .Cell(i, 4).Range.Text = rs.Fields("Отчество").Value
                .Cell(i, 5).Range.Text = rs.Fields("Телефон").Value
            End With
            rs.MoveNext
        Loop
    
    kot.Bookmarks("тема_отчета").Range.Text = "*Общий отчет по 
менеджерам поставки*"
    kot.Bookmarks("время").Range.Text = Time
    kot.Bookmarks("дата").Range.Text = Date
    
    GetManagerBDForm.Hide
    kot.Activate

End Sub

Private Sub RefreshButton_Click()
    ShowRecord
End Sub

Private Sub UserForm_initialize()

    Set cn = New ADODB.Connection
    cn.Provider = "Microsoft.ACE.OLEDB.12.0"
    cn.ConnectionString = 
"C:\Users\georgiydemo\Documents\DEMKA\Computer_store.accdb"
    cn.Open
    Set rs = New ADODB.Recordset
    rs.CursorType = adOpenKeyset
    rs.LockType = adLockOptimistic
    rs.Source = "SELECT [Менеджер Поставки].* FROM [Менеджер Поставки];"
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
    TextBoxSearch.Enabled = False
    IsDisable = True
    SetEnabled True, False

End Sub

Private Sub CMDDeleteButton_Click()

 If (rs.RecordCount >= 1) Then
    If MsgBox("Удалить текущую запись?", vbYesNo + vbQuestion) = vbYes 
Then
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
    If MsgBox("Вы действительно хотите обновить данную запись?", vbYesNo 
+ vbQuestion) = vbYes Then
        Call FillRecord
        rs.Update
        TextBoxSearch.Enabled = True
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

    TextBox1.Text = rs.Fields("КодМенеджераПоставки").Value
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

