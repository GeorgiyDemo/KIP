program KOMUK;
const nmax=99999999;
var a:array[1..nmax] of longint;
    one, two, i, n: integer;

begin
randomize;
write('Введите кол-во элементов массива n => '); read(n);
write('Введите 1-й элемент массива => '); read(one);
write('Введите 2-й элемент массива => '); read(two);

a[1]:=one;
a[2]:=two;

for i:=3 to n do
    a[i]:=(a[i-1]+a[i-2])*i;

writeln('Полученный массив:');
write('[');
for i:=1 to n do
    write(a[i],' ');
write(']');
end.