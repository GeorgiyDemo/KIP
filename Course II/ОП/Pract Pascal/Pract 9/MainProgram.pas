program Modules;
uses Matrix;
const nmax=10;
var a,b,c,buf1,buf2:matrica;
    tosort:array[1..nMax] of matrica;
    result, buf, opr: array [1..nMax] of real;
    mmax,z,j,i:integer;
    flag:char;
    mainflag:real;
    n,k:byte;

begin
writeln('Используя разработанный модуль matrix, решить 
следующие задачи:');
writeln('a) систему линейных уравнений N-го порядка (2<= N <= 
10) методом Крамера');
writeln('б) отсортировать заданный массив меличин типа Matrica 
в порядке возрастания значений определителей матриц');
writeln('в) найти матрицу С, равную A*B-B*A, если заданы 
величины A и B типа Matrica');
write('=> '); read(flag);
case flag of
  'а' : begin
        write('Введите n => ');Read(n);
        for i:=1 to n do
          begin
           writeln;
          for j:=1 to n do
            begin
              a[i,j]:=(random(50)-25)/5;
              write(a[i,j]:5, ' ');
            end;
           end;
        writeln;
        writeln;
   write('Свободные члены уравнения:');
   writeln;
   for i:=1 to n do
    begin
      result[i]:=(random(50)-25)/5;
      write(result[i], ' ');
    end;
    writeln;
    writeln;
    writeln('Результат:');   
    mainflag:=opred(a,n);
    for j:=1 to n do
     begin
     for i:=1 to n do
      begin
        buf[i]:=a[i,j];
        a[i,j]:=result[i];
      end;
      opr[j]:=opred(a,n);
      for i:=1 to n do
        a[i,j]:=buf[i];
      end;
    writeln;
    for i:=1 to n do
      writeln('X',i,' ≈ ',(opr[i]/mainflag):6:4);
    end;

  'б' : begin
          write('Кол-во матриц => '); read(k);
          write('Порядок матриц => '); readln(n);
          begin
            for z:=1 to k do
              begin
              for i:=1 to n do
                begin
                  writeln;
                  for j:=1 to n do
                    begin
                      a[i,j]:=(random(50)-25)/5;
                        write(a[i,j]:5, ' ');
                    end;
                 end;
                tosort[z]:=a;
              writeln;
              end;
             writeln;
            end;
          writeln('Результат:');
          for i:=1 to k do
            result[i]:=opred(tosort[i], n);
            for i:=1 to n-1 do
              for z:=i to k do
                if (result[i]>result[z]) then
                  begin
                    mainflag:=result[i];
                    result[i]:=result[z];
                    result[z]:=mainflag;
                    a:=tosort[i];
                    tosort[i]:=tosort[z];
                    tosort[z]:=a;
                  end;
                  for z:=1 to k do
                   begin 
                      a:=tosort[z];
                      for i:=1 to n do
                        begin
                          writeln;
                          for j:= 1 to n do
                            write(a[i,j]:5, ' ');
                        end;
                      writeln;
                    end;
        end;

  'в' : begin
        randomize;
        write('Введите n => ');Read(n);
        write('A=');
          for i:=1 to n do
            begin
              writeln;
              for j:=1 to n do
                begin
                a[i,j]:=random(9);
                write(a[i,j]:4);
                end;
            end;
            writeln;
            write('B=');
            for i:=1 to n do
            begin
             writeln;
              for j:=1 to n do
               begin
                b[i,j]:=random(9);
                write(b[i,j]:4);
               end;
            end;
            writeln;
           buf1:=umnoz(a,b);
           buf2:=umnoz(b,a);
           for i:=1 to n do
            begin
              for j:=1 to n do
               begin
                buf2[i,j]:=buf2[i,j]*(-1)
               end;
            end;
            c:=summa(buf1,buf2,10);
            writeln('C= (результат)');
            for i:=1 to n do
            begin
             writeln;
              for j:=1 to n do
               begin
                write(c[i,j]:4);
               end;
           end;
      end;
 end;
end.
