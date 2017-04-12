program meow2;
uses crt;
 
const n=3;
const m=7;

var a:array[1..1000,1..1000] of real;
    sum: real;
    i,j,ii,k,k1,k2: byte;
    bike: real;
  
procedure initarray();
  
  procedure generate();
  var i,j:integer;
  begin
    randomize;
    for i:=1 to n do
     for j:=1 to m do
      a[i,j]:=random*20-10;
  end;
  
  procedure enter();
  var i:integer;
  begin
    for i:=1 to n do
      begin
        write('Ââåäèòå ıëåìåíò ¹',i,',',j);
        read(a[i,j]);
      end;
  end;
  
  //ÏÎÔÈÊÑÈÒÜ______________________________________________
  procedure files();
  begin
  end;
begin

  writeln('1. Ãåíåğàöèÿ ìàññèâîâ');
  writeln('2. Ğó÷íîé ââîä ìàñèâà');
  writeln('3. ×òåíèå ìàññèâà èç ôàéëà');
  write('=> '); readln(k);
  
  case k of
       1 : generate();
       2 : enter();
       3 : files();
  end;
  
end;

procedure outarray();

  procedure monitor_out;
  var i,j:integer;
  begin
    writeln('Èñõîäíàÿ ìàòğèöà:');
    for i:=1 to n do
    begin
      writeln;
      for j:=1 to m do
        write(a[i,j]:10:5);
    end;
  readkey();
  end;
  
  procedure file_out;
  var f: Text;
      i,j:integer;
  begin
    assign(f, 'out.txt');
    rewrite(f);
    for i:=1 to n-1 do
      for j:=1 to m-1 do
        writeln(f, a[i,j]);
    Close(f);
  end;
  
begin
    writeln('1. Âûâîä ìàòğèöû íà ıêğàí');
    writeln('2. Âûâîä ìàòğèöû â ôàéë');
    write('=> '); readln(k);
  
     case k of
       1 : monitor_out();
       2 : file_out();
     end; 
end;

procedure v_input();
begin
  write('Ââåäèòå âåëè÷èíó => ');
  read(bike);
end;

procedure sum_kol();
var i,j:integer;
begin
  k1:=0;
    for i:= 1 to n do
      begin
      for j:= 1 to n do
        sum:=a[j,i]+sum;
      ii:=i;
      if (sum>bike) then
        begin
          sum:=0;
          k:=k+1;
          writeln(i,'- ñòîëáåö');
          writeln;
          for j:= 1 to n do
            begin
              write(' ',a[j,ii],' ');
              writeln;
            end
        end
      end;
  readkey();
  end;


begin
  repeat
    clrscr;
    writeln('1. Ââîä ìàññèâîâ');
    writeln('2. Âûâîä ìàññèâîâ');
    writeln('3. Ââîä âåëè÷èíû');
    writeln('4. Íîìåğà ñòîëáöîâ');
    writeln('0. Âûõîä èç ïğîãğàììû');
    write('=> '); readln(k);
  
     case k of
       1 : initarray();
       2 : outarray();
       3 : v_input();
       4 : sum_kol();
     end;
  
  until (k=0);
end.
