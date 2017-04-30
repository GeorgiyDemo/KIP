program meow;
uses crt;
var a:array[1..1000] of integer;
    n,i,j:integer;
    f,max:real;
function s(x1,x2,y1,y2:integer):real;
begin
    s:=sqrt(sqr(x2-x1)+sqr(y2-y1));
end;
begin
  clrscr;
  randomize;
  write('Введите n => ');Readln(n);
  writeln('----------------------------');
  for i:= 1 to n do
    begin
        a[i]:=random(20)-6;
        write(a[i]:5);
    end;
  writeln;
  writeln('----------------------------');
  max:=0;
  for i:=1 to n-1 do begin
    for j:=i+1 to n do 
      if (s(a[i],a[j-1],a[i+1],a[j])>max) then
        max:=s(a[i],a[i+1],a[j-1],a[j]);
  end;
  writeln;
  writeln('----------------------------');
  writeln('Максимальное расстояние между точками: ',max);
  writeln('----------------------------');
end.
