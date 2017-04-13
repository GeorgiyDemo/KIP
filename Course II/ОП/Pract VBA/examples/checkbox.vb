Private Sub CommandButton1_Click()
    Dim a(100), k, i, s, z As Integer
    n = Split(TextBox1.Text, "")

    For i = 0 To UBound(n)
        a(i) = Val(n(i))
        Label1.Caption = Label1.Caption + Chr(13) + "Введите.." + CStr(z)
    Next i

    k = CInt(TextBox2.Text)

    If checkbox1.Checked = True Then
        For s = 0 To k
            z = a(UBound(n))
            For i = UBound(n) To 1 Step -1
                a(i) = a(i - 1)
            Next i
            a(0) = z
        Next s
    Else
        For s = 0 To k
            z = a(0)
            For i = 1 To UBound(n)
              a(i - 1) = a(i)
            Next i
            a(UBound(n)) = z
        Next s
    End If

    For i = 0 To UBound(n)
        Label1.Caption = Label1.Caption + Chr(9) + CStr(a(i))
    Next i

End Sub
