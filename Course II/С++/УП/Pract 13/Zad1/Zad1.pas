program meow1;
uses crt; 

var x,y: array[1..1000] of real;
    i,n,k,k1,k2: byte;
    sr: real;
  
procedure initarray();
  
  procedure generate();
  var i:integer;
  begin
    write('Введите размерность массивов => '); read(n);
    randomize;
    for i:=1 to n do
      x[i]:=random*20-10;
    for i:=1 to n do
      y[i]:=random*20-10;
  end;
  
  procedure enter();
  var i:integer;
  begin
    write('Введите размерность массивов => '); read(n);
    for i:=1 to n do
      begin
        write('Введите элемент №',i,':');
        read(x[i]);
      end;
    for i:=1 to n do
       begin
        write('Введите элемент №',i,':');
        read(y[i]);
      end;
  end;
  
  procedure files_in();
  var i,j:integer; f1,f2:file of double;
  begin
    assign(f1, 'mas1.txt');
    assign(f2, 'mas2.txt');
    reset(f1); reset(f2);
    for i:=1 to n do
        read(f1,(x[i]));
    close(f1);
    for i:=1 to n do
        read(f2,(y[i]));
    close(f2);
  end;
  
begin

  writeln('1. Генерация массивов');
  writeln('2. Ручной ввод масива');
  writeln('3. Чтение массива из файла');
  write('=> '); readln(k);
  
  case k of
       1 : generate();
       2 : enter();
       3 : files_in();
  end;
  
end;

procedure outarray();

  procedure monitor_out;
  var i:integer;
  begin
    writeln('Массив х:');
    for i:=1 to n do
      write(x[i]:10:2);
    writeln;
    writeln('Массив у:');
    for i:=1 to n do
      write(y[i]:10:2);
    readkey();
  end;
  
  procedure file_out;
  var f1,f2: file of double; i:integer;
  begin
    assign(f1,'out1.txt');
    assign(f2,'out2.txt');
    rewrite(f1);
    rewrite(f2);
    for i:=1 to n do
      write(f1, x[i]);
    close(f1);
    for i:=1 to n do
      write(f2, y[i]);
    close(f2);
  end;
  
begin
    writeln('1. Вывод массива на экран');
    writeln('2. Вывод массива в файл');
    write('=> '); readln(k);
  
     case k of
       1 : monitor_out();
       2 : file_out();
     end; 
end;

procedure sred();
var i:integer;
begin
  for i:=1 to n do
    sr:=sr+x[i];
  sr:=sr/n;
  writeln('Cреднее арифметическое массива х: ',sr:0:1);
  readkey();
end;

procedure kol();
var i:integer;
begin
  k1:=0;
  for i:=1 to n do
    if x[i]=y[i] then
      k1:=k1+1;
  writeln('Кол-во случаев равенства пар: ',k1);
  readkey();
end;


begin
  repeat
    clrscr;
    writeln('1. Ввод массивов');
    writeln('2. Вывод массивов');
    writeln('3. Cреднее арифмет. массива х');
    writeln('4. Кол-во случаев равенства пар');
    writeln('0. Выход из программы');
    write('=> '); readln(k);
  
     case k of
       1 : initarray();
       2 : outarray();
       3 : sred();
       4 : kol();
     end;
  
  until (k=0);
end.
