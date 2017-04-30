program rab;
uses crt;
type worker= record
  name,dolznost:string[111];
  zarplata:integer;
  staz:integer;
end;
var s:file of worker;
    f:array[1..100] of worker;
    srd_zarp:real;
    n,i:integer;
    
begin
assign(s,'baza.dat'); rewrite(s);
for i:=1 to 5 do 
  begin
    writeln('ФИО: '); Readln(f[i].name);
    writeln('Должность: '); Readln(f[i].dolznost);
    writeln('Зарплата: '); Readln(f[i].zarplata);
    writeln('Стаж: '); Readln(f[i].staz);
    write(s,f[i]);
  end;
end.
