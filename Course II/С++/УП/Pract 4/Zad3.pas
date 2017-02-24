program StrangeKOT;
const nmax=99999999;
var a:array[1..nmax] of longint;
    index1, num, one, two, i, n: integer;

begin
randomize;
write('¬ведите кол-во элементов массива n => '); read(n);

writeln('“екущий массив:');
for i:=1 to n do
begin
    a[i]:=random(20);
    write(a[i],' ');
end;
writeln;
write('¬ведите число A => '); read(num);

//“ут ищем элементы
for i:=1 to n do
  if (a[i]=num) then
  begin
      writeln('Ёлемент B найден!');
      index1:=i;
      writeln('є',i,'. B=',a[i]);
      break;
  end;

for i:=n downto 0 do
  if (a[i]=num) then
    if (index1<>i) then
    begin
        writeln('Ёлемент C найден!');
        writeln('є',i,'. C=',a[i]);
        break;
    end
    else
    begin
      writeln('Ёлементы C и B совпадают :c');
      break;
    end;

end.