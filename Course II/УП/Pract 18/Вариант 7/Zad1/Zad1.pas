
var s : string;
    i:integer;
begin
s:='what , do yu are   ,do';
i:=1;
while (i<length(s)) do begin
  while (i<length(s)) and(s[i]<>',') do inc(i);
    while s[i-1]=' ' do begin delete(s,i-1,1); dec(i);end;
    while copy(s,i+1,2)=' ' do  delete(s,i+1,1);
 insert(' ',s,i+1);
 inc(i);
end;
write(s);readln;
end.