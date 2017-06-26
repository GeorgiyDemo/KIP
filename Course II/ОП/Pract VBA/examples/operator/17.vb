Private Sub CommandButton1_Click()
Dim a(100, 100), n, i, k, ch(100), buf, j, t, h(100), q, w As Integer
Randomize
    n = TextBox1
     w = TextBox2
      q = TextBox3
    Label1.Caption = Label1.Caption + "Исходный массив:" + Chr(10)
    For i = 0 To n - 1
    Label1.Caption = Label1.Caption + Chr(10)
    For j = 0 To n - 1
    a(i, j) = CInt(Rnd() * 100 - 60)
    Label1.Caption = Label1.Caption + CStr(a(i, j)) + Chr(9)
    Next j
    Next i
    
   If (q = 1) Then
For k = 1 To w
  For j = 0 To n - 1
  i = 0
  h(j) = a(0, j)
  Next j
  For i = 0 To n - 2
    For j = 0 To n - 1
      a(i, j) = a(i + 1, j)
      a(i + 1, j) = a(i, j)
      Next j
      Next i
  For j = 0 To n - 1
    a(n - 1, j) = h(j)
    Next j
Next k
Else:
For k = 1 To w
  For j = 0 To n - 1
  h(j) = a(n - 1, j)
  Next j
  For i = n - 1 To 1 Step -1
    For j = n - 1 To 0 Step -1
      a(i, j) = a(i - 1, j)
      a(i - 1, j) = a(i, j)
      Next j
      Next i
  For j = 0 To n - 1
    a(0, j) = h(j)
    Next j
Next k
End If

Label3.Caption = Label3.Caption + "Матрица после сдвига:" + Chr(10)
For i = 0 To n - 1
Label3.Caption = Label3.Caption + Chr(10)
For j = 0 To n - 1
Label3.Caption = Label3.Caption + CStr(a(i, j)) + Chr(9)
Next j
Next i

End Sub

