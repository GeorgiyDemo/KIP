program dem;
uses crt;
var i,num,kol:integer;
begin
     clrscr;
     kol:=0;
     for i:=1 to 3 do
     begin
          write('Введите чисто №',i,':');Readln(num);
          if (num<0) then kol:=kol+1;
     end;
     writeln('Кол-во отриц. чисел: ',kol);
end.
