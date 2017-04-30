program check;
uses crt;
var s:string;
    f:text;
    i,valid:integer;
begin
  clrscr;
  assign(f,'str.txt');
  reset(f);
  readln(f,s);
  
  writeln('Исходная строка из файла str.txt:');
  writeln(s);
  
  valid:=0;
  for i:=1 to length(s) do
    begin
    
      if s[i]='(' then
       valid:=valid+1
      
      else if s[i]=')' then
        valid:=valid-1;
    end;
  writeln;
  if (valid=0) then writeln('Скобки расставлены правильно')
    else if (valid=1) then writeln('Лишняя открывающая скобка')
      else if (valid>1) then writeln('Лишние открывающие 
скобки')
        else if (valid=-1) then writeln('Лишняя закрывающая 
скобка')
          else writeln ('Много лишних закрывающих скобок');
 readkey;
end.
