program meowt;
uses crt;
var i:integer;
    k:byte;
    c,str:string;
begin
clrscr;
  k:=3;
  write('Введите строку => ');Readln(str);
  writeln('- - - - - - - - - - - - - - -'); 
  writeln('Слова, содержащие ',k,' буквы:'); 
  for i:=1 to length(str) do
    if (str[i]<>' ') and (str[i]<>'.') then
      c:=c+str[i]
    else
      begin
        if (length(c)=k) then
          writeln(c);
        c:=''; 
      end;
  writeln('- - - - - - - - - - - - - - -');
readkey;
end.
