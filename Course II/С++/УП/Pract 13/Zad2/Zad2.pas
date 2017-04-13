program meow2;
uses crt;
 
const n=3;
const m=7;

var a:array[1..1000,1..1000] of real;
    sum: real;
    f : file of double;
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
        write('Введите элемент №',i,',',j);
        read(a[i,j]);
      end;
  end;
  
  procedure files_in();
  begin
    assign(f, 'mas1.txt');
    reset(f);
    for i:=1 to n do
      for j:=1 to m do
        read(f, (a[i,j]));
        close(f);
  end;
  
  procedure files_out();
  var f: file of double; s:string; i:integer;
  begin
    assign(f,'out.txt');
    rewrite(f)
    for i:=1 to n do
      for j:=1 to m do
    assign(f, 'mas1.txt');
    reset(f);
    for i:=1 to n do
      for j:=1 to m do
        read(f, (a[i,j]));
        close(f);
  end;
  
begin

  writeln('1. Генерация массивов');
  writeln('2. Ручной ввод масива');
  writeln('3. Чтение массива из файла');
  
  write('=> '); readln(k);
  
  case k of
       1 : generate();
       2 : enter();
       3 : files_in();
       4 : files_out();
  end;
  
end;

procedure outarray();

  procedure monitor_out;
  var i,j:integer;
  begin
    writeln('Исходная матрица:');
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
    writeln('1. Вывод матрицы на экран');
    writeln('2. Вывод матрицы в файл');
    write('=> '); readln(k);
  
     case k of
       1 : monitor_out();
       2 : file_out();
     end; 
end;

procedure v_input();
begin
  write('Введите величину => ');
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
          writeln(i,'- столбец');
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
    writeln('1. Ввод массивов');
    writeln('2. Вывод массивов');
    writeln('3. Ввод величины');
    writeln('4. Номера столбцов');
    writeln('0. Выход из программы');
    write('=> '); readln(k);
  
     case k of
       1 : initarray();
       2 : outarray();
       3 : v_input();
       4 : sum_kol();
     end;
  
  until (k=0);
end.
