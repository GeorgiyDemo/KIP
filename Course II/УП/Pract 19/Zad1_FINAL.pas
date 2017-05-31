program meow1;
uses crt;

type worker= record
  name,dolznost,telephone:string[111];
  staz:integer;
end;

var s:file of worker;
    f:array[1..100] of worker;
    n,k,i:integer;

//Процедура формирования меню ввода
procedure initarray();

//Процедура ручного ввода
    procedure input_struct();

      var i:integer;
      begin
        assign(s,'soz.dat'); rewrite(s);
        write('Введите кол-во записей в структуре => ');
        readln(n);
        for i:=1 to n do
          begin
            writeln('ФИО: '); Readln(f[i].name);
            writeln('Должность: '); Readln(f[i].dolznost);
            writeln('Стаж: '); Readln(f[i].staz);
            writeln('Телефон: '); Readln(f[i].telephone);
            write(s,f[i]);
          end;
     end;

     //Ввод из файла
     procedure file_struct();
     begin
        assign(s,'soz.dat'); reset(s);
        i:=1;

        while not eof(s) do
        begin
          read(s,f[i]);
          i:=i+1;
        end;
    end;

//Меню ввода
    begin
        writeln('1. Ручной ввод структуры');
        writeln('2. Ввод структуры из файла');

        write('=> '); readln(k);

         case k of
           1 : input_struct();
           2 : file_struct();
         end;
end;

//Процедура формирования меню вывода
procedure outarray();

  //Процедура вывод структуры на экран
  procedure monitor_out(flag:boolean);
  var i,j:integer;
  begin
      i:=1;
      reset(s);

      if (flag=true) then
        begin
          writeln('Первая запись текущей структуры:');
          writeln('ФИО          Должность          Стаж работы          Телефон');
          writeln(f[1].name,'          ',f[1].dolznost,'          ',f[1].staz,'          ',f[1].telephone);
        end;

      if (flag=false) then
        begin
          writeln('Общая таблица текущей структуры:');
          writeln('ФИО          Должность          Стаж работы          Телефон');
          while not eof(s) do
          begin
            read(s,f[i]);
            writeln(f[i].name,'          ',f[i].dolznost,'          ',f[i].staz,'          ',f[i].telephone);
            i:=i+1;
          end;
        end;
  readkey();
end;

//Меню вывода
begin
    writeln('1. Вывод всей структуры');
    writeln('2. Вывод первой записи структуры');
    writeln('3. Дополнение данных новыми записями');

    write('=> '); readln(k);

     case k of
       1 : monitor_out(false);
       2 : monitor_out(true);
       3 : writeln('ДОПОЛНЯЕМ_ДАННЫЕ');
     end;
end;

//Главное меню программы
begin

  repeat
    clrscr;
    writeln('1. Ввод данных в структуру');
    writeln('2. Вывод данных');
    writeln('3. Поиск записей файла');
    writeln('4. Удаление данных из файла');
    writeln('0. Выход из программы');
    write('=> '); readln(k);

     case k of
       1 : initarray();
       2 : outarray();
       //3 : counter();
       //4 :
     end;

  until (k=0);
end.
