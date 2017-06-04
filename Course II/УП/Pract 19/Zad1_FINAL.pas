//Добавить изменение определенных данных в определенной строке

program KOT;
uses crt;

type worker = record
  name,dolznost,telephone : string[100];
  staz : integer;
end;

var s : file of worker;
    f : array[1..100] of worker;
    delflag : boolean;
    n, k, i, buf, delindex : integer;

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
      
      //Это если мы удалили какой-либо элемент
      if ((flag=false) and (delflag=true)) then
        begin
          writeln('Общая таблица текущей структуры:');
          writeln('ФИО          Должность          Стаж работы          Телефон');
          
          for i:=1 to buf-1 do 
            writeln(f[i].name,'          ',f[i].dolznost,'          ',f[i].staz,'          ',f[i].telephone);
        end
      
      //Вывод всех записей в структуре
      else if (flag=false) then
        begin
          writeln('Общая таблица текущей структуры:');
          writeln('ФИО          Должность          Стаж работы          Телефон');
          while not eof(s) do
          begin
            read(s,f[i]);
            writeln(f[i].name,'          ',f[i].dolznost,'          ',f[i].staz,'          ',f[i].telephone);
             i:=i+1;
          end;
          buf:=i;
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
  var checker : boolean;
      i : integer;
  
  function supervisor(str:string):boolean;
  begin
    if ((pos('361', str)=1) or (pos('+361', str)=1) or (pos('362', str)=1) or (pos('+362', str)=1) or (pos('273', str)=1) or (pos('+273', str)=1)) then
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
   writeln();
   
   for i:=1 to buf do
    if (supervisor(f[i].telephone) = true) then 
        writeln(f[i].name);
   
   if (checker=false) then
    writeln('Таких сотрудников нет');
    
   readkey();
end;

//Меню процедуры работы с данными
procedure ChangeData();

  //Процедура изменения данных
  procedure ChangeNewData();
  var newchanger, changeindex : integer;
  begin
    write('Введите № элемента для удаления: '); read(changeindex);
    writeln('Какие данные вы хотите удалить?');
    
    writeln('1. ФИО');
    writeln('2. Должность');
    writeln('3. Стаж');
    writeln('4. Телефон');
    write('=> ');
    readln(newchanger);
    
    case newchanger of
    
      1 : begin
            writeln('Введите новое ФИО для элемента №',changeindex,':');
            readln(f[changeindex].name);
          end;
      2 : begin
            writeln('Введите новую должность для элемента №',changeindex,':');
            readln(f[changeindex].dolznost);
          end;
      3 : begin
            writeln('Введите новый стаж для элемента №',changeindex,':');
            readln(f[changeindex].staz);
          end;
      4 : begin
            writeln('Введите новый телефон для элемента №',changeindex,':');
            readln(f[changeindex].telephone);
          end;
          
    end;
    write(s,f[changeindex]);
    writeln('Данные успешно обновлены!');
    readkey();
  end;
  
  //Процедура удаления данных из структуры
  procedure DelData();
  
      procedure worker(delindex : integer);
      var i : integer;
      begin
        for i:=delindex to buf-1 do begin
           f[i].name:=f[i+1].name;
           f[i].dolznost:=f[i+1].dolznost;
           f[i].staz:=f[i+1].staz;
           f[i].telephone:=f[i+1].telephone;
        end;
        delflag:=true;
       end;
  
  var k : integer;
  begin
    write('Введите № элемента для удаления: '); read(delindex);
    writeln('Вы действительно хотите удалить строку с индексом ',delindex,' ?');
    writeln('1. Да');
    writeln('2. Нет');
    write('=> ');
    readln(k);
    
    case k of
      1 : worker(delindex);
      2 : writeln('Хорошо, выходим в главное меню');
    end; 
    readkey();
  end;
  
  //Процедура добавления данных в структуру
  procedure AddData();
  begin
    writeln('*Добавление записи в структуру*');
    writeln('ФИО: '); Readln(f[buf+1].name);
    writeln('Должность: '); Readln(f[buf+1].dolznost);
    writeln('Стаж: '); Readln(f[buf+1].staz);
    writeln('Телефон: '); Readln(f[buf+1].telephone);
    write(s,f[buf+1]);
  end;

//Меню вывода
begin
    writeln('1. Удаление данных');
    writeln('2. Изменение данных');
    writeln('3. Добавление данных');
    write('=> '); readln(k);

     case k of
       1 : DelData;
       2 : ChangeNewData;
       3 : AddData;
     end;
end;

//Главное меню программы
begin
  delflag:=false;
  repeat
    clrscr;
    writeln('1. Ввод данных');
    writeln('2. Вывод данных');
    writeln('3. Поиск записей, согласно условию');
    writeln('4. Работа с данными');
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
