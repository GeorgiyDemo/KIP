program MEOWTH;
uses crt;

var a: array of integer;
    k, n: integer;

procedure initarray();
  var i:integer;
  begin
    randomize;
    write('Введите кол-во элементов массива n => '); read(n);
    a := new integer[n+1];
    for i:=1 to n do
        a[i]:=random(20);
  end;

procedure outarray();
  var i:integer;
  begin
    writeln('Массив:');
    for i:=1 to n do
      write(a[i],' ');
  readkey();
  end;
  
procedure sort();
  var i:integer;
  begin
  for i:=1 to n do
      if ((a[i] mod 2=0) and (i mod 2=1)) then 
        a[i]:=0;
  end;
  
begin
  repeat
  clrscr;
  writeln('1. Генерация массива');
  writeln('2. Вывод массива');
  writeln('3. Сортировка массива');
  writeln('0. Выход из программы');
  write('=> '); readln(k);
  
  case k of
   1 : initarray();
   2 : outarray();
   3 : sort();
  end;
  until (k=0);
end.