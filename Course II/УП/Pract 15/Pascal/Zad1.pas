program meow1;
uses crt; 

var a : array [1..100,1..100] of integer;
    c : array [1..100] of integer;
    x : array[1..100] of real;
    k, i, j, s, m, b : integer;
    p, q, n, v : real;
    xarray : boolean;
  
procedure initarray();
  
  procedure generate();
  var i,j:integer;
  begin
    write('Введите размерность массивов => '); read(m);
    randomize;
    for i:=1 to m do
       for j:=1 to m do
        a[i,j]:=random(20)-10;
        
    for i:=1 to m do
      c[i]:=random(20)-10;
  end;
  
  procedure enter();
  var i,j:integer;
  begin
    write('Введите размерность массивов => '); read(m);
    writeln('<Заполняем матрицу А>');
    for i:=1 to m do
      for j:=1 to m do
      begin
        write('Введите элемент [',i,',',j,']: ');
        read(a[i,j]);
      end;
      
    writeln('<Заполняем массив C>');
    for i:=1 to m do
       begin
        write('Введите элемент [',i,']: ');
        read(c[i]);
      end;
  end;

procedure files_in();
 var i,j:integer; fA,fC:file of integer;
begin
    assign(fA, 'inputA.txt');
    assign(fC, 'inputC.txt');
    reset(fA); reset(fC);
    for i:=1 to m do
        read(fC,(c[i]));
    close(fC);
    
    for i:=1 to m do
      for j:=1 to m do
        read(fA,(a[i,j]));
    close(fA);
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
  var i,j:integer;
  begin
    writeln('Матрица А:');
    for i:=1 to m do
      begin
      writeln;
      for j:=1 to m do
        write(a[i,j]:4);
      end;
    writeln;
    writeln('Массив C:');
    for i:=1 to m do
      write(c[i]:4);
    readkey();
  end;
  
  procedure file_out;
  var outer: file of real; 
      i,j:integer;
 begin
    assign(outer,'out.txt');
    rewrite(outer);
    
    //Матрица А
    for i:=1 to m do
     for j:=1 to m do
          write(outer, (a[i,j]));
    
    //Массив С
    for i:=1 to m do
      write(outer, (c[i]));
    
    //Массив x, если он сформирован 
    if (xarray=true) then
    begin
     writeln(outer, 'Сформированный массив x:');
      for i:=1 to m do
        write(outer, (x[i]));
    end;
     close(outer);
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

procedure counter();
  var i,j,k:integer;
  begin
  write('Введите переменную b =>');
  read(b);
  for i:=1 to m do
    for j:=1 to m do
      if (i=j) then
        s:=s+a[i,j];
  
  writeln('Массив x на выходе:');
  for i:=1 to m do
  begin
    if (i=1) then
      p:=1
    else
      p:=x[i-1];
    n:=(s/(p*c[i]));
    for k:=1 to m do
    begin
      v:=((a[k,i]+c[k])/(k*k+b));
      q:=q+v;
    end;
    
    x[i]:=n+q;
    n:=0;
    v:=0;
    q:=0;
    writeln(i,'. ',x[i]);
  end;
  xarray:=true;
  readkey();
end;


begin
  xarray:=false;
  repeat
    clrscr;
    writeln('1. Ввод массивов');
    writeln('2. Вывод массивов');
    writeln('3. Cреднее арифмет. массива х');
    writeln('0. Выход из программы');
    write('=> '); readln(k);
  
     case k of
       1 : initarray();
       2 : outarray();
       3 : counter();
     end;
  
  until (k=0);
end.
