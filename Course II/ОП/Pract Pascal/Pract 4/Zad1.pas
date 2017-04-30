program KOTIK;
uses crt;
var a:array[1..1000] of integer;
  zamena, n, Z, i ,kol:integer;
begin
  clrscr;
  randomize;
  write('Введите размерность массива  =>');Readln(n);
  
  //Генерация массива
  write('[');
  for i:=1 to n do
  begin
    a[i]:=random(20)-6;
    write(a[i],' ');
  end;
  write(']');
  writeln;
  write('Введите число Z => '); Readln(Z);
  
  //Замена
  zamena:=0;
  for i:=1 to n do
  if (a[i] > Z) then
    begin
      a[i]:=Z;
      zamena:=zamena+1;
    end;
    
  //Вывод
  write('[');
  for i:=1 to n do
    write(a[i],' ');
  write(']');
  writeln;
  write('Кол-во замен: ',zamena);
  readkey();

end.
  
