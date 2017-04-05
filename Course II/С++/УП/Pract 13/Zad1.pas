var
   x,y: array[1..100] of integer;
   i,n,k: byte;
   sr: real;
begin
   randomize;
   write('размерность: ');
   readln(n);
   writeln('массив х:');
   for i:=1 to n do
      begin
         x[i]:=random(31);
         inc(sr,x[i]);
         write(x[i],' ');
      end;
   writeln;
   sr:=sr/n;
   writeln('массив у:');
   for i:=1 to n do
      begin
         y[i]:=random(31);
         write(y[i],' ');
      end;
   writeln;
   for i:=1 to n do
      if x[i]=y[i] then inc(k);
   writeln('cреднее арифметическое массива х: ',sr:0:1);
   writeln('число случаев равенства пар: ',k);
   readln
end.
