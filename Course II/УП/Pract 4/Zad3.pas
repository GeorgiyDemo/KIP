program StrangeKOT;
uses crt;
var a: array of integer;
    k, index1, num, one, two, n: integer;

procedure initarray();
  var i: integer;
  begin
    randomize;
    write('Введите кол-во элементов массива n => '); read(n);
    a := new integer[n+1];
    for i:=1 to n do
      a[i]:=random(20);
  end;

procedure outarray();
  var i: integer;
  begin
    writeln('Текущий массив:');
    for i:=1 to n do
      write(a[i],' ');
  readkey();
  end;

procedure finder(); //Тут ищем элементы
  var i: integer;
  begin
  writeln;
  write('Введите число A => '); read(num);
  for i:=1 to n do
    if (a[i]=num) then
      begin
        writeln('Элемент B найден!');
        index1:=i;
        writeln('№',i,'. B=',a[i]);
        break;
      end;

  for i:=n downto 0 do
    if (a[i]=num) then
      if (index1<>i) then
        begin
          writeln('Элемент C найден!');
          writeln('№',i,'. C=',a[i]);
          break;
        end
      else
        begin
          writeln('Элементы C и B совпадают :c');
          break;
        end;
    readkey();
  end;

begin
  repeat
  clrscr;
  writeln('1. Генерация массива');
  writeln('2. Вывод массива');
  writeln('3. Поиск элементов в массиве');
  writeln('0. Выход из программы');
  write('=> '); readln(k);
  
  case k of
   1 : initarray();
   2 : outarray();
   3 : finder();
  end;
  until (k=0);
end.
