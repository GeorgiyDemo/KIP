program qwe1;
uses crt;
var n,m,j,i,k:integer;
a:array [1..20,1..20] of integer;
min:array[1..20] of integer;
begin
randomize;
write(' n= ');
readln(n);
write(' m= ');
readln(m);
writeln('Исходная матрица');
writeln;
for i:= 1 to n do
begin
for j:= 1 to m do
begin
a[i,j]:=random(20);
write(a[i,j]:6);
end;
writeln;
end;
writeln('Массив минимумов');
writeln;
for i:= 1 to n do begin
	min[i]:=a[i,1];
for j:= 2 to m do
if a[i,j]<min[i] then
	min[i]:=a[i,j];
 write(' ',min[i]);
 end;
 end.
