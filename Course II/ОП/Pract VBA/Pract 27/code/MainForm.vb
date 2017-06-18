Private Sub BDButton_Click()
    Unload Me
    BDMainForm.Show
End Sub

Private Sub DOCButton_Click()
    Unload Me
    DOCListForm.Show
End Sub

Private Sub ExitButton_Click()
    If (MsgBox("Вы действительно хотите выйти?", vbYesNo + vbQuestion) = 
vbYes) Then
        Unload Me
    End If
End Sub

