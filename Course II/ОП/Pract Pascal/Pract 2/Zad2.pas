program func;
uses crt;
var x,fx:real;
begin
     clrscr;
     write('Введите x: ');Readln(x);
     if (0<=x) and (x<=3) then
           fx:=(power(x,2));
     if (x>3) or (x<0) then
           fx:=4;
     writeln('F(x)= ',fx);
end.

