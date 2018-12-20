Sub CreateSheet()
    Dim ws As Worksheet
    Set ws = ThisWorkbook.Sheets.Add(After:= _
    ThisWorkbook.Sheets(ThisWorkbook.Sheets.Count))
    ws.Name = "RESULT"
End Sub

Sub Main()

  Dim element As Range, a As String
  sheetname = ActiveSheet.Name
  CreateSheet
  Sheets(sheetname).Select
   counter = 0
    For Each element In Selection
      LArray = Split(CStr(element.Value), " ")
      For i = LBound(LArray) To UBound(LArray)
      Sheets("RESULT").Select
        
        ActiveSheet.Cells(counter + 1, i + 1).Select
        
        ActiveCell.FormulaR1C1 = CStr(LArray(i))
      Next
      counter = counter + 1
      Sheets(sheetname).Select
    Next
End Sub
