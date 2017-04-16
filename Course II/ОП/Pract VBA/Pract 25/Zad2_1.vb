Sub Main()
    UserForm1.Show
End Sub

Private Sub CommandButton1_Click()
    ActiveDocument.Bookmarks("ЦЕНА").Range.Text = TextBox1.Text
    ActiveDocument.Bookmarks("ЦЕНА_ПРОПИСЬ").Range.Text = TextBox2.Text
    ActiveDocument.Bookmarks("ИНДЕКС").Range.Text = TextBox3.Text
    ActiveDocument.Bookmarks("АДРЕС").Range.Text = TextBox4.Text + " " + TextBox5.Text + " " + TextBox6.Text + " " + TextBox7.Text
    ActiveDocument.Bookmarks("КОМУ").Range.Text = TextBox13.Text
    ActiveDocument.Bookmarks("ОТ_КОГО").Range.Text = TextBox14.Text

    If (Frame4.Enabled = False) Then
        ActiveDocument.Bookmarks("ОБРАТНЫЙ_ИНДЕКС").Range.Text = " - "
        ActiveDocument.Bookmarks("ОБРАТНЫЙ_АДРЕС").Range.Text = " - "
    End If

    If (Frame4.Enabled = True) Then
        ActiveDocument.Bookmarks("ОБРАТНЫЙ_ИНДЕКС").Range.Text = TextBox8.Text
        ActiveDocument.Bookmarks("ОБРАТНЫЙ_АДРЕС").Range.Text = TextBox9.Text + " " + TextBox10.Text + " " + TextBox11.Text + " " + TextBox12.Text
    End If

    UserForm1.Hide

End Sub

Private Sub CommandButton2_Click()
    Unload UserForm1
End Sub

Private Sub OptionButton1_Click()
    Frame4.Enabled = True
End Sub

Private Sub OptionButton2_Click()
    Frame4.Enabled = False
End Sub
