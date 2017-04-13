Sub Zad1()
 Dim x, y, n1 As Integer
 Dim result, n2 As Double

 x = InputBox("Введите x")
 y = InputBox("Введите y")

 n1 = y - (Abs(x) ^ (1 / 2))
 n2 = x - (y / (x + (x ^ 2 / 4)))

 result = Log(Abs(n1 * n2))
 MsgBox ("Результат: " & result)

End Sub

Sub Zad2()
 Dim x, y As Integer

 x = InputBox("Введите x")

 If (x >= 0) And (x <= 3) Then
    y = x ^ 2
 End If

 If ((x > 3) Or (x < 0)) Then
    y = 4
 End If

 MsgBox ("Результат: " & y)

End Sub

Sub Zad3()

 Const pi As Double = 3.141
 Dim k, a As Integer
 Dim result As Double

 k = InputBox("|1| Вычисление длинны окружности" + Chr(13) + "|2| Вычисление радиуса окружности" + Chr(13) + "|3| Вычисление диаметра окружности")

 Select Case k
            Case 1
                a = InputBox("Введите а")
                result = (a ^ (1 / 2)) / (4 * pi)
            Case 2
                a = InputBox("Введите а")
                result = pi * a ^ (1 / 2)
            Case 3
                a = InputBox("Введите а")
                result = pi * (a / 2) ^ (1 / 2)
        End Select
 MsgBox ("Результат: " & result)
End Sub
