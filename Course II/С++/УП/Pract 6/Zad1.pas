program qwe1;  
uses crt; 
var n,m,j,i,k:integer; 
kol,sred,sum:real;
a:array [1..20,1..20] of integer; 
begin 
randomize; 
kol:=0;
sum:=0;
sred:=0;
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
for i:= 1 to n do
for j:= 1 to m do
if a[i,j]>=0 then begin
kol:=kol+1;
sum:=sum+a[i,j];
sred:=sum/kol;
end;
writeln('kol = ',kol);
writeln('sum = ',sum);
writeln('sred = ',sred);
end.
