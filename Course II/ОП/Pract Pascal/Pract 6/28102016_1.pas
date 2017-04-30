program meow;
uses crt;
var a:array[1..100,1..100] of integer;
    sum:array[1..100] of integer;
    n,m,i,j,k,s,buf,buf1:integer;

begin

     //Ввод
     clrscr;
     write('Введите n => ');Readln(n);
     write('Введите m => ');Readln(m);
     if (n = m) then writeln('Требуется прямоугольная 
матрица!')
     else
      begin
      
     //Генерация
     randomize;
     for i:=1 to n do begin
     writeln;
     for j:=1 to m do begin
              a[i,j]:=random(20)-10;
              write(a[i,j]:4);
         end;
      end;
      
      //Находим сумму отриц элементов строки и выводим
      for i:=1 to n do begin
      s:=0;
      for j:=1 to m do
        if a[i,j]<0 then 
           s:=s+a[i,j];
      sum[i]:=s;
      end;
      writeln;
      writeln;
      for i:=1 to n do begin
      writeln('Строка №',i,'= ',sum[i]);
      end;
      
      //Сортировка значений в  массиве sum
        for i:= 1 to n-1 do
          for k:=i+1 to n do
            if (sum[i]>sum[k]) then
              begin
              
                buf:=sum[i];
                sum[i]:=sum[k];
                sum[k]:=buf;
                
                for j:=1 to m do
                 begin
                  buf:=a[i,j];
                  a[i,j]:=a[k,j];
                  a[k,j]:=buf;
                 end;
               end;
             writeln;
      
      //Вывод матрицы
      for i:=1 to n do
        begin
          writeln;
          for j:=1 to m do
            write(a[i,j]:4);
        end;
    end;
   readkey;   
end.

