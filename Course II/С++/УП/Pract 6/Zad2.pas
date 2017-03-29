program KOT2;  
uses crt; 

var n, m, k : integer; 
    a:array [,] of integer;

procedure initarray();

  var i, j : integer;
  
  begin
    randomize;
    write('Введите n =>'); 
    readln(n); 
    writeln;
    a:=new integer[n+1,n+1];
    for i:= 1 to a.GetLength(0)-1 do
        for j:= 1 to a.GetLength(1)-1 do
          a[i,j]:=i+j;
     
    for i:= 1 to a.GetLength(0)-1 do
        for j:= 1 to a.GetLength(1)-1 do
          if ((i+j>n) or (n=i+i-1)) then
            a[i,j]:=n;
          
    
  end;
  
  procedure outarray();
  
  var i, j: integer;
  
  begin
  writeln('Полученный массив:');
  for i:= 1 to a.GetLength(0)-2 do
    begin
      writeln;
        for j:= 1 to a.GetLength(1)-2 do 
          write(a[i,j]:6); 
    end;
  readkey();
  end;
  
  begin
    repeat
      clrscr;
      writeln('1. Ввод массива');
      writeln('2. Вывод массива');
      writeln('0. Выход из программы');
      write('=> '); readln(k);
  
      case k of
        1 : initarray();
        2 : outarray();
      end;
  
    until (k=0);
  end.