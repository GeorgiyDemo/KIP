program qwe1;
uses crt;
var n,m,j,i,k,max,min,mini,minj,maxi,maxj,buf:integer;
a:array [1..20,1..20] of integer;
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
max:=a[1,1];
min:=a[1,1];
for i:= 1 to n do
for j:= 1 to m do   begin
	if a[i,j]>max then  begin
	max:=a[i,j];
  maxi:=i;
  maxj:=j;
  end;
  if a[i,j]<min then begin
	min:=a[i,j];
  mini:=i;
  minj:=j;
  end;
  end;
  writeln('max= ',max);
  writeln('min= ',min);
  writeln('Меняем');
buf:=max;
a[maxi,maxj]:=a[mini,minj];
a[mini,minj]:=buf;
for i:= 1 to n do
begin
writeln;
for j:= 1 to m do
write(a[i,j]:6);
end;
writeln;
	end.
