program MEOWTH;
const nmax=99999999;
var a:array[1..nmax] of longint;
    one, two, i, n: integer;

begin
randomize;
write('Введите кол-во элементов массива n => '); read(n);

writeln('Текущий массив:');
for i:=1 to n do
begin
    a[i]:=random(20);
    write(a[i],' ');
end;
for i:=1 to n do
    if ((a[i] mod 2=0) and (i mod 2=1)) then 
      a[i]:=0;

writeln;
writeln('Полученный массив:');
for i:=1 to n do
   write(a[i],' ');
end.