program KOTIK_2;
uses crt;
var a:array[1..1000] of integer;
  p1, p2, n, i :integer;
begin
  clrscr;
  randomize;
  write('Введите размерность массива  => ');Readln(n);
  
  //Генерация массива
  writeln('Массив:');
  write('[');
  for i:=1 to n do
  begin
    a[i]:=random(20)-10;
    write(a[i],' ');
  end;
  write(']');
  writeln;
  
  //Сортировка
  p1:=1;
  p2:=1;
  for i:=1 to n do 
  if (a[i] < 0) then p1:=p1*a[i]
  else if (a[i] <> 0) then p2:=p2*a[i];
  
  //Сравнение p1 и p2
  writeln('P1= ',p1);
  writeln('P2= ',p2);
  
  if (abs(p1) > abs(p2)) then
    writeln('Произведение отрицательных элементов больше')
  else
    writeln('Произведение положительных элементов больше');
  
  readkey();
end.
