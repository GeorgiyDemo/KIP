;------------------------------------------------------------------------------
;
;       Пример установочного скрипта для Inno Setup 5.5.5
;       (c) maisvendoo, 15.04.2015
;
;------------------------------------------------------------------------------

;------------------------------------------------------------------------------
;   Определяем некоторые константы
;------------------------------------------------------------------------------

; Имя приложения
#define   Name       "Программа для вычисления НОД"
; Версия приложения
#define   Version    "0.0.1"
; Фирма-разработчик
#define   Publisher  "Cambridge university"
; Сайт фирмы разработчика
#define   URL        "http://www.github.com/GeorgiyDemo/"
; Имя исполняемого модуля
#define   ExeName    "Module3.exe"
;Тело скрипта разделяется на секции, каждая из которых несет свое функциональное назначение. Обязательная секция [Setup] задает глобальные параметры работы инсталлятора и деинсталатора. 
;------------------------------------------------------------------------------
;   Параметры установки
;------------------------------------------------------------------------------
[Setup]
; Уникальный идентификатор приложения, 
;сгенерированный через {73041752-596E-4AC2-9D2D-8ABBB4553E71} -> Generate GUID
AppId={{73041752-596E-4AC2-9D2D-8ABBB4553E71}
; Прочая информация, отображаемая при установке
AppName={#Name}
AppVersion={#Version}
AppPublisher={#Publisher}
AppPublisherURL={#URL}
AppSupportURL={#URL}
AppUpdatesURL={#URL}
; Путь установки по-умолчанию
DefaultDirName={pf}\{#Name}
; Имя группы в меню "Пуск"
DefaultGroupName={#Name}
; Каталог, куда будет записан собранный setup и имя исполняемого файла
OutputDir=C:\READY\test-setup
OutputBaseFileName=test-setup
; Файл иконки
 SetupIconFile=C:\RESOURCES\ICON.ico
; Параметры сжатия
Compression=lzma
SolidCompression=yes
;В хорошем инсталяторе должна быть поддержка нескольких языков. Включаем её в наш «сетап», используя опциональную секцию [Languages]. При отсутствии данной секции будет использоваться английский язык.


[Code]
function IsDotNetDetected(version: string; release: cardinal): boolean;

var 
    reg_key: string; // Просматриваемый подраздел системного реестра
    success: boolean; // Флаг наличия запрашиваемой версии .NET
    release45: cardinal; // Номер релиза для версии 4.5.x
    key_value: cardinal; // Прочитанное из реестра значение ключа
    sub_key: string;

begin

    success := false;
    reg_key := 'SOFTWARE\Microsoft\NET Framework Setup\NDP\';
   // Вресия 3.0
    if Pos('v3.0', version) = 1 then
      begin
          sub_key := 'v3.0';
          reg_key := reg_key + sub_key;
          success := RegQueryDWordValue(HKLM, reg_key, 'InstallSuccess', 
key_value);
          success := success and (key_value = 1);
      end;

    // Вресия 3.5
    if Pos('v3.5', version) = 1 then
      begin
          sub_key := 'v3.5';
          reg_key := reg_key + sub_key;
          success := RegQueryDWordValue(HKLM, reg_key, 'Install', 
key_value);
          success := success and (key_value = 1);
  end; 

     // Вресия 4.0 клиентский профиль 
     if Pos('v4.0 Client Profile', version) = 1 then 
      begin 
          sub_key := 'v4\Client'; 
          reg_key := reg_key + sub_key; 
          success := RegQueryDWordValue(HKLM, reg_key, 'Install', 
key_value); 
          success := success and (key_value = 1); 
      end; 

     // Вресия 4.0 расширенный профиль 
     if Pos('v4.0 Full Profile', version) = 1 then 
      begin 
          sub_key := 'v4\Full'; 
          reg_key := reg_key + sub_key; 
          success := RegQueryDWordValue(HKLM, reg_key, 'Install', 
key_value); 
          success := success and (key_value = 1); 
      end; 

     // Вресия 4.5 
     if Pos('v4.5', version) = 1 then 
      begin 
          sub_key := 'v4\Full'; 
          reg_key := reg_key + sub_key; 
          success := RegQueryDWordValue(HKLM, reg_key, 'Release', 
release45); 
          success := success and (release45 >= release); 
      end; 
         
    result := success; 

end;

function IsRequiredDotNetDetected(): boolean;
begin
    result := IsDotNetDetected('v4.0 Full Profile', 0);
end;

//-----------------------------------------------------------------------------
//    Callback-функция, вызываемая при инициализации установки
//-----------------------------------------------------------------------------
function InitializeSetup(): boolean;
begin

  // Если нет тербуемой версии .NET выводим сообщение о том, что инсталлятор
  // попытается установить её на данный компьютер
  if not IsDotNetDetected('v4.0 Full Profile', 0) then
    begin
      MsgBox('{#Name} requires Microsoft .NET Framework 4.0 Full Profile.'#13#13'The installer will attempt to install it', mbInformation, MB_OK);
    end;   

  result := true;
end;
 


[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"; LicenseFile: "C:\RESOURCES\LIC_RUS.txt"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"; LicenseFile: "C:\RESOURCES\LIC_RUS.txt"
;Обычно установщик предлагает нам, например, определится, хотим мы или не хотим создать ярлык на рабочем столе. Такие опции установки определяются необязательной секцией [Tasks]

;------------------------------------------------------------------------------
;   Опционально - некоторые задачи, которые надо выполнить при установке
;------------------------------------------------------------------------------
[Tasks]
; Создание иконки на рабочем столе
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
;Теперь укажем, какие файлы надо включить в дистрибутив и где их надо поместить при установке. Для этого используется обязательная секция 
[Files]

;------------------------------------------------------------------------------
;   Файлы, которые надо включить в пакет установщика
;------------------------------------------------------------------------------
[Files]


; .NET Framework 4.0
Source: "C:\READY\NET_FRAMEWORK.exe"; DestDir: "{tmp}"; Flags: deleteafterinstall; Check: not IsRequiredDotNetDetected

; Исполняемый файл
Source: "C:\RESOURCES\Module3.exe"; DestDir: "{app}"; Flags: ignoreversion

; Прилагающиеся ресурсы
Source: "C:\RESOURCES\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
;Наконец, чтобы всё было красиво, опционально укажем компилятору, где брать иконки для размещения в меню программ и на рабочем столе

;------------------------------------------------------------------------------
;   Указываем установщику, где он должен взять иконки
;------------------------------------------------------------------------------ 
[Icons]

Name: "{group}\{#Name}"; Filename: "{app}\{#ExeName}"

Name: "{commondesktop}\{#Name}"; Filename: "{app}\{#ExeName}"; Tasks: desktopicon

[Run]

Filename: {tmp}\NET_FRAMEWORK.exe; Parameters: "/q:a /c:""install /l /q"""; Check: not IsRequiredDotNetDetected; StatusMsg: Microsoft Framework 4.5 is installed. Please wait...

