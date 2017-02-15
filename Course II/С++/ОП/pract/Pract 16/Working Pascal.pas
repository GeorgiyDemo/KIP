uses crt;
const nmax=20;
var a:array[1..nmax,1..nmax] of integer;
    n,m,i,j,l:byte;
   sum,b:integer;
begin
clrscr;
randomize;
write('Количество строк n=');
readln(n);
write('Количество столбцов m=');
readln(m);
{вычисление количества отрицательных нечетных в строках и запись их в дополнительный столбец}
for i:=1 to n do
 begin
  sum:=0;
  for j:=1 to m do
   begin
    a[i,j]:=random(10)-5;
    if (a[i,j]<0) then sum:=sum+a[i,j];
   end;
  a[i,m+1]:=sum;
 end;
writeln('Исходный массив:');
writeln('Сум. отр.':(m*4+10));
for i:=1 to n do
 begin
  for j:=1 to m+1 do
  if j=m+1 then write(a[i,j]:6)
  else write(a[i,j]:4);
  writeln;
 end;
{перестановка строк по возрастанию количеств(по последнему столбцу)}
for i:=1 to n-1 do
for l:=i+1 to n do
if a[i,m+1]>a[l,m+1] then
for j:=1 to m+1 do
 begin
  b:=a[i,j];
  a[i,j]:=a[l,j];
  a[l,j]:=b;
 end;
writeln('Строки по убыванию количества отрицательных:');
writeln('Кол. отр.':(m*4+10));
for i:=1 to n do
 begin
  for j:=1 to m+1 do
  if j=m+1 then write(a[i,j]:6)
  else write(a[i,j]:4);
  writeln;
 end;
readln
end.