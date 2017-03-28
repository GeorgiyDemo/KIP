Private Sub CommandButton1_Click()

    Dim a(100, 100), n, i, j As Integer

    n = CInt(TextBox1.Text) - 1
    Label1.Caption = ""


    For i = 0 To n
        Label1.Caption = Label1.Caption + Chr(13)
        For j = 0 To n
            If ((i + j < n) And (i < j)) Or ((i + j > n) And (i > j)) Or (i = j) Or (i + j = n) Then
                a(i, j) = 1
            Else
                a(i, j) = 0
            End If
            Label1.Caption = Label1.Caption + " " + CStr(a(i, j))
        Next j
    Next i

End Sub
