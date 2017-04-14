program kot;
uses crt;
var y,x,sum,proz,chast,raz:real;
begin
     clrscr;
     write('х= ');Readln(x);
     write('y= ');Readln(y);
     sum:=x+y;
     raz:=x-y;
     proz:=x*y;
     chast:=x/y;
     writeln('Сумма: ',sum);
     writeln('Разность: ',raz);
     writeln('Произведение: ',proz);
     writeln('Частное: ',chast);
end.