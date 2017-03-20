Sub Main()
    UserForm1.Show
End Sub

Private Sub CommandButton1_Click()
    Dim a(100), i, buf, proz As Integer

    KOTlen = TextBox1.TextLength
    For i = 0 To (KOTlen / 2)
        a(i) = Split(TextBox1.Text, " ")(i)
    Next i

End Sub
