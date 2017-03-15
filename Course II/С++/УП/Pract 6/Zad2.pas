program KOT;  
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
    begin    
    for j:= 1 to a.GetLength(1)-1 do
     a[i, j]:=i+j;
     end;
     
     for i:= 1 to a.GetLength(0)-1  do
    begin
    a[i, n]:=n;
    end;
    
    for j:= 1 to a.GetLength(1)-1 do
    begin
    a[n, j]:=n;
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