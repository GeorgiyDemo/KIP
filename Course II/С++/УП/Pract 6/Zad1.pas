program KOT;  
uses crt; 

var n, m, k : integer; 
    kol, mult, sum : real;
    a:array [,] of integer;

procedure initarray();

  var i, j : integer;
  begin
    randomize;
    write('Введите кол-во строк =>'); 
    readln(n); 
    write('Введите кол-во столбцов =>'); 
    readln(m);
    a:=new integer[n+1,m+1];
    writeln;
    for i:= 1 to a.GetLength(0)-1 do 
      begin 
        for j:= 1 to a.GetLength(1)-1 do 
          begin
            write('a[',i,',',j,'] = ');
            read(a[i,j]);
            writeln;
          end; 
      writeln; 
      end; 
  end;
  
  procedure outarray();
  
  var i, j: integer;
  begin
  writeln('Полученный массив:');
  for i:= 1 to a.GetLength(0)-1 do 
      begin 
      writeln;
        for j:= 1 to a.GetLength(1)-1 do 
          write(a[i,j]:6); 
       end;
  readkey();
  end;
  
  procedure counter();
  
  var i, j: integer;
  begin
  for i:= 1 to a.GetLength(0)-1 do
    for j:= 1 to a.GetLength(1)-1 do
      if (a[i,j]<0) then
        begin
          mult:=mult*a[i,j];
          sum:=sum+a[i,j];
          kol:=kol+1;
        end;
  writeln('Количество: ',kol);
  writeln('Сумма: ',sum);
  writeln('Произведение: ',mult);
  readkey();
  end;

  begin
    repeat
      kol:=0;
      sum:=0;
      mult:=1;
      clrscr;
      writeln('1. Ввод массива');
      writeln('2. Вывод массива');
      writeln('3. Вычисление');
      writeln('0. Выход из программы');
      write('=> '); readln(k);
  
  case k of
   1 : initarray();
   2 : outarray();
   3 : counter()
  end;
  
  until (k=0);
 
end.