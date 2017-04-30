program Kollaps;
uses crt;
var a:array[1..1000, 1..1000] of integer;
n, i, j:integer;
begin
writeln('Введите n =>');Readln(n);
for i:=1 to n do
  begin
    writeln;
    for j:=1 to n do
      begin
        if (i=j) or (j=n+1-i)  then
          a[i,j]:=1
        else if ((i>j) and (i+j>n+1)) or ((i<j) and (i+j<n+1)) 
then
          a[i,j]:=1
       else 
          a[i, j]:=0;
          write(a[i, j]:2);
      end;
  end;
readkey;
end.
