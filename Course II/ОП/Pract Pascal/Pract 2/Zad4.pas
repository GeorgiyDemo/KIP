program tabul;
uses crt;
var i,a,b:integer;
h,fx,x:real;

begin
     clrscr;
     write('Введите значение a: ');Readln(x);
     write('Введите значение b: ');Readln(b);
     write('Введите шаг табуляции: ');Readln(h);
     writeln('Отлично, отрезок [',x,',',b,']');
     writeln('----------------------');
     write('x=       F(x)=');
     repeat
          fx:=x*sin(x);
          writeln;
          write(x:0:2,'     ',fx:0:4);
          x:=x+h;
     until (x=b);
     writeln;
     write('----------------------');
end.
