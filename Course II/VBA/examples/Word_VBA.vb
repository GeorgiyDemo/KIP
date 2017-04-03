'---------------------------------------------------------
Sub CommandButton1_Click()
	Dim zv as document
	Set zv=Applications.Documents.Add("С:\zav.doc")
	zv.bookmarks("Зав ФИО").Range.Text=Textbox1
	zv.bookmarks("Группа").Range.Text=Textbox2
	zv.bookmarks("ФИО ст").Range.Text=Textbox3
	zv.bookmarks("Дата пропуска").Range.Text=Textbox4
	zv.bookmarks("Причина пропуска").Range.Text=Textbox5
	zv.bookmarks("Текущая дата").Range.Text=Date(now())
	zv.bookmarks("ФИО студ").Range.Text=Textbox6
End Sub
'---------------------------------------------------------
Sub UserForm1_Initalize()
	Combobox1.AddItem "Иванов И И"
	Combobox1.AddItem "Петров П П"
	Combobox1.AddItem "Сидоров С С"
End Sub

Sub CommandButton1_Click()
	ActiveDocument.Tables(1).Cell(1,1).Range.Text InsertAfter Combobox1.text
	ActiveDocument.Tables(1).Cell(1,2).Range.Text=Textbox1
	ActiveDocument.Tables(1).Cell(1,3).Range.Text=Textbox2
	ActiveDocument.Tables(1).Cell(1,4).Range.Text=Textbox3
End Sub
'---------------------------------------------------------


	