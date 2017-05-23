Public cn As ADODB.Connection
Public rs As ADODB.Recordset

Private Sub UserForm2_Initialize()
    Set cn = New ADODB.Connection
    cn.Provider = "Microsoft.ACE.OLEDB.12.0"
    cn.ConnectionString = "\\.psf\Home\Projects\KIP\Course II\ОП\Pract VBA\Pract 26\Computer_store.accdb"
    cn.Open
    Set rs = New ADODB.Recordset
    rs.CursorType = adOpenKeyset
    rs.LockType = adLockOptimistic
    rs.Source = "SELECT Продажа.* FROM Дисциплина order by Дисциплина.Код_пред"
    Set rs.ActiveConnection = cn
    rs.Open

    Do Until rs.EOF
    '    txtFind.AddItem rs Fields("Код_пред")
        rs.Movenext
    Loop

End Sub

Private Sub CommandButton8_Click()
    UserForm2.Hide
End Sub

Вывести весь ассортимент товаров
Вывести информацию о проданном товаре конкретного менеджера по продажам
