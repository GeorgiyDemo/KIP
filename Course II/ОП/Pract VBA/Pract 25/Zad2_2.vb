Sub Main()

    With UserForm1:
        .ComboBox1.AddItem "был украден"
        .ComboBox1.AddItem "был утоплен"
        .ComboBox1.AddItem "был сожжен"
        .ComboBox1.AddItem "разорван"
        .ComboBox1.AddItem "не был нужен"
        .ComboBox1.AddItem "съел кот"
        .ComboBox1.AddItem "обиделся и убежал"
        .Show
    End With

End Sub

Private Sub CommandButton1_Click()

    ActiveDocument.Bookmarks("ФАМИЛИЯ_ДИРЕКТОР").Range.Text = TextBox1.Text
    ActiveDocument.Bookmarks("ИО_ДИРЕКТОР").Range.Text = TextBox2.Text
    ActiveDocument.Bookmarks("ФАМИЛИЯ").Range.Text = TextBox3.Text
    ActiveDocument.Bookmarks("ИО").Range.Text = TextBox4.Text
    ActiveDocument.Bookmarks("ПРИЧИНА").Range.Text = ComboBox1.Value
    ActiveDocument.Bookmarks("СУММА").Range.Text = TextBox6.Text
    ActiveDocument.Bookmarks("ДАТА").Range.Text = "Дата: " + TextBox5.Text

    UserForm1.Hide
End Sub

Private Sub CommandButton2_Click()
    Unload UserForm1
End Sub
