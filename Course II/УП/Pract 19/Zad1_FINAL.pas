program KOT;
uses crt;

type worker = record
  name,dolznost,telephone : string[100];
  staz : integer;
end;

var s : file of worker;
    f : array[1..100] of worker;
    n,k,i,buf : integer;

//Процедура формирования меню ввода
procedure initarray();
    //Процедура ручного ввода
    procedure input_struct();
      var i:integer;
      begin
        assign(s,'soz.dat'); rewrite(s);
        write('Введите кол-во записей в структуре => ');
        readln(n);
        buf:=n;
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
        buf:=i;
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
  //Процедура вывода структуры на экран
  procedure monitor_out(flag:boolean);
  var i,j:integer;
  begin
      i:=1;
      reset(s);
      
      //Вывод первой записи в структуре
      if (flag=true) then
        begin
          writeln('Первая запись текущей структуры:');
          writeln('ФИО          Должность          Стаж работы          Телефон');
          writeln(f[1].name,'          ',f[1].dolznost,'          ',f[1].staz,'          ',f[1].telephone);
        end;
      
      //Вывод всех записей в структуре
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
    write('=> '); readln(k);

     case k of
       1 : monitor_out(false);
       2 : monitor_out(true);
     end;
end;

//Процедура поиска данных
procedure search();
  var checker:boolean;
  
  function supervisor(str:string):boolean;
  begin
    if ((str = '361') or (str= '+361') or (str = '362') or (str = '+362') or (str = '273') or (str = '+273')) then
      begin
        supervisor:=true;
        checker:=true;
      end
    else
      supervisor:=false;
  end;
begin
   writeln('*Поиск данных в структуре, согласно условию*');
   writeln('ФИО сотрудников, номера телефонов которых начинаются с 361/362/273');
   checker:=false;
   while not eof(s) do
   begin
    read(s,f[i]);
    
    if (supervisor(f[i].telephone) = true) then 
        writeln(f[i].name);
      i:=i+1;
   end;
   
   if (checker=false) then
    writeln('Таких сотрудников нет');
    
   readkey();
end;

//Меню процедуры добавления/удаления данных
procedure ChangeData();
  //Процедура добавления данных
  procedure AddData();
  begin
    writeln('*Добавление записи в структуру*');
    writeln('ФИО: '); Readln(f[buf+1].name);
    writeln('Должность: '); Readln(f[buf+1].dolznost);
    writeln('Стаж: '); Readln(f[buf+1].staz);
    writeln('Телефон: '); Readln(f[buf+1].telephone);
    write(s,f[buf+1]);
  end;
  
  procedure DelData();
  begin
    writeln('ЯНЕРАБОТАЮ');
  end;

//Меню вывода
begin
    writeln('1. Удаление данных');
    writeln('2. Добавление данных');
    write('=> '); readln(k);

     case k of
       1 : DelData;
       2 : AddData;
     end;
end;

//Главное меню программы
begin

  repeat
    clrscr;
    writeln('1. Ввод данных');
    writeln('2. Вывод данных');
    writeln('3. Поиск записей, согласно условию');
    writeln('4. Добавление/удаление данных');
    writeln('0. Выход из программы');
    write('=> '); readln(k);

     case k of
       1 : initarray();
       2 : outarray();
       3 : search();
       4 : ChangeData();
     end;

  until (k=0);
end.
