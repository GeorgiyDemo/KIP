program round;
uses crt;
var k:byte;
    a:real;
begin
     clrscr;
     writeln('|1| Вычисление длины окружности');
     writeln('|2| Вычисление радиуса окружности');
     writeln('|3| Вычисление диаметра окружности');
     readln(k);
     readln(a);
     write('Площадь круга: ');
     case k of
          1:writeln(sqr(a)/(4*Pi):0:2);
          2:writeln(Pi* sqr(a):0:2);
          3:writeln(Pi* sqr(a/2):0:2);
          else writeln('???');
     end;
end.

